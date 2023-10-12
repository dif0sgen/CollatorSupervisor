using EasyModbus;
//using Emgu.CV.OCR;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using TCP_LISTENER_Delta.Properties;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.IO;
using System.Text.RegularExpressions;
using DirectShowLib;
using System.Resources;
using CollatorSupervisor.Properties;

namespace CollatorSupervisor
{

    public partial class Form_Listener : Form
    {
        Dictionary<string, System.Drawing.Image> AugmentedRealityImages = new Dictionary<string, System.Drawing.Image>();

        bool captureFromCam = true;
        int frameCount = 0;
        int oldFrameCount = 0;
        bool showAngle;
        int camWidth = 640;
        int camHeight = 480;
        string templateFile;

        ModbusClient modbus = new ModbusClient();
        System.Timers.Timer aTimer = new System.Timers.Timer();
        System.Timers.Timer bTimer = new System.Timers.Timer();

        // Set up the controls and events to be used and update the device list.

        public delegate void InvokeDelegate();
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;
        private Thread n_server;
        private Thread n_shot;
        private TcpListener listener;
        string out1 = "0";
        string out2 = "0";
        string position = "";


        string JobID = "JobID";
        string SchoolName = "SchoolName";
        string CalendarType = "CZ S-S";
        public int ACC_X_MAN;
        int motorSpeed;
        int motorSpeedX;
        int motorSpeedY;
        int ManSpd;
        int IndexMonth;
        int AdaptiveThBlockSize;
        int txt1;
        int txt2;
        int txt3;
        int txt4;
        int txt5;
        int txt6;
        int txt7;
        int txt8;
        int txt9;
        int txt10;
        int txt11;
        int Scan_TMR;
        int Grab_TMR;
        int Release_TMR;
        int i;
        int milliseconds = 300;
        //alarms
        bool Rilecart_emergency_stop;
        bool Rilecart_missing_fin;
        bool Rilecart_stop;
        bool Rilecart_bypass;
        bool Collator_Missing_left;
        bool Collator_Missing_right;
        bool Collator_Paper_jam;
        bool Collator_bypass;
        bool Rotation_paper_jam;
        bool Rilecart_run;
        bool DoubleON;
        bool scan = false;
        bool scan_local;


        bool bit1;
        bool bit2;
        bool bit3;
        bool bit4;
        bool bit5;
        bool bit6;
        bool bit7;
        bool bit8;
        bool bit9;
        bool bit10;
        bool bit11;
        bool bit12;
        bool bit13;
        bool bit14;
        bool angle0;
        bool angle90;
        bool angle180;
        bool run = false;
        bool BoolUp;
        bool BoolDwn;
        bool BoolCollator;
        bool BoolRailcart;
        Int32 posXtab1;
        Int32 posXtab2;
        Int32 posYtab1;
        Int32 posYtab2;
        Int32 Hi;
        private int imageIndex;
        private string[] imageList;
        private Int32[] WORD_READ = new Int32[56];
        private Int32[] WORD_WRITE = new Int32[56];
        private bool[] CONTROL_WRITE = new bool[26];
        private bool[] CONTROL_READ = new bool[39];
        private string[] files;

        private bool check1 = false;
        private bool check2 = false;

        string sub = "";
        string tesser;


        /// 
        /// Init Form
        /// 
        public Form_Listener()
        {
            this.InitializeComponent();

            thread1 = new Thread(() => ReadMDBS("MDBS"));
            thread2 = new Thread(() => WriteMDBS("WRITE"));
            //thread3 = new Thread(() => btnOpen_Click("IMAGE"));
            thread1.Start();
            thread2.Start();
            

            imageIndex = 0;
            //aTimer.Elapsed += ReadMDBS; //CYCLE VOID
            //aTimer.Interval = 50;
            //aTimer.AutoReset = true;
            //aTimer.Enabled = true;
            //bTimer.Elapsed += WriteMDBS;//CYCLE VOID
            //bTimer.Interval = 50;
            //bTimer.AutoReset = true;
            //bTimer.Enabled = true;
            this.Closing += new CancelEventHandler(this.Form_Listener_Close);
            btnUP.MouseUp += btnUP_Up;
            btnUP.MouseDown += btnUP_Down;
            btnUP.MouseEnter += btnUp_ENTER;
            btnDWN.MouseDown += btnDWN_Down;
            btnDWN.MouseUp += btnDWN_Up;
            btnDWN.MouseEnter += btnDWN_ENTER;
            btnStart.MouseEnter += OnMouseEnterButton1;
            btnStart.MouseLeave += OnMouseLeaveButton1;


            ///
            /// GET SAVED VALUES
            ///
           
            txtPort.Text = Properties.Settings.Default.Port;
            txtIPAdress.Text = Properties.Settings.Default.IP;
            checkBox12.Checked = Properties.Settings.Default.CollatorSave;
            checkBox11.Checked = Properties.Settings.Default.RailcartSave;

            //DirectShowLib.DsDevice[] _SystemCamereas = DirectShowLib.DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            //Video_Device[] WebCams = new Video_Device[_SystemCamereas.Length];
            //for (int i = 0; i < _SystemCamereas.Length; i++)
            //{
            //    WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
            //    Camera_Selection.Items.Add(WebCams[i].ToString());
            //}
        }
 
        /// 
        /// STOP
        /// 
        private void button2_Click(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                //CONTROL[5] = false;
                //CONTROL[6] = true;
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        /// 
        /// START
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {

            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        /// 
        /// HOME
        ///
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {

            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        /// 
        /// Set color on mouse BTN_Connect
        /// 
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            btnStart.BackColor = System.Drawing.Color.FromArgb(218, 67, 60); // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            btnStart.BackColor = System.Drawing.Color.DimGray;
        }
        /// 
        /// Connect to PLC
        /// 
        private void btnStart_Click(object sender, EventArgs e)
        {
            modbus.IPAddress = Convert.ToString(txtIPAdress.Text);
            modbus.Port = Convert.ToInt32(txtPort.Text);
            if (modbus.Connected == false)
            {
                try
                {

                    modbus.Connect();
                    check1 = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connect Modbus"+ex.Message);
                }
                //if (modbus.Connected == true)
                //lblStat.Text = "Status: Connected";
                
                //this.lblStat.ForeColor = System.Drawing.Color.Green;
            }
            else if (modbus.Connected == true)
            {
                try
                {
                    check1 = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Disconnect Modbus: "+ex.Message);

                }
            }
        }


         

        /// 
        /// Read/Write Modbus cycle
        /// 
        void ReadMDBS(string name)
        {
            while (true)
            {
                if (modbus.Connected == true)
                {
                    try
                    {

                        //WORD_WRITE[2] = Convert.ToInt32(motorSpeedX); //Write Manual Speed X
                        //WORD_WRITE[10] = Convert.ToInt32(ManSpd);//Write ManSpd
                        //WORD_WRITE[30] = Convert.ToInt32(motorSpeed); //Write Main Speed Percent
                        //WORD_WRITE[4] = txt1; //ACC X
                        //WORD_WRITE[12] = txt3; //ACC Y
                        //WORD_WRITE[28] = txt2; //ACC X
                        //WORD_WRITE[26] = txt4; //ACC Y
                        //WORD_WRITE[32] = txt5; //SPD X1
                        //WORD_WRITE[34] = txt6; //SPD X2
                        //WORD_WRITE[36] = txt7; //SPD Y1
                        //WORD_WRITE[38] = txt8; //SPD Y2
                        //WORD_WRITE[48] = txt9; //POSITION 1
                        //WORD_WRITE[50] = txt10; //POSITION 2
                        //WORD_WRITE[52] = txt11; //POSITION 3
                        //WORD_WRITE[16] = Grab_TMR; //Grab_TMR
                        //WORD_WRITE[18] = Scan_TMR; //Scan_TMR
                        //WORD_WRITE[20] = Release_TMR; //Release_TMR
                        //WORD_WRITE[54] = Hi;

                        CONTROL_WRITE[2] = angle0; //M1002
                        CONTROL_WRITE[3] = angle90; //M1003
                        CONTROL_WRITE[4] = angle180; //M1004
                        CONTROL_WRITE[10] = BoolUp; //M1010
                        CONTROL_WRITE[11] = BoolDwn; //M1011
                        CONTROL_WRITE[12] = BoolCollator; //M1012
                        CONTROL_WRITE[13] = BoolRailcart; //M1013
                        //CONTROL_WRITE[15] = run; //M1015
                        CONTROL_WRITE[16] = checkBox19.Checked; //M1016
                        CONTROL_WRITE[17] = checkBox18.Checked; //M1017
                        CONTROL_WRITE[18] = checkBox17.Checked; //M1018
                        CONTROL_WRITE[19] = checkBox16.Checked; //M1019
                        CONTROL_WRITE[20] = checkBox15.Checked; //M1020
                        CONTROL_WRITE[21] = checkBox14.Checked; //M1021
                        CONTROL_WRITE[22] = checkBox13.Checked; //M1022
                        CONTROL_WRITE[23] = checkBox5.Checked; //M1023
                        CONTROL_WRITE[24] = checkBox4.Checked; //M1024
                        CONTROL_WRITE[25] = scan;

                        try
                        {
                            if (check2 == true)
                            {
                                modbus.WriteSingleCoil(2019, false);
                                check2 = false;
                            }
                            modbus.WriteMultipleCoils(1000, CONTROL_WRITE); // WRITE ALL BITS
                            //CONTROL_WRITE[25] = false;
                        }

                        catch (Exception ex)
                       {
                           MessageBox.Show("Write mulriple coils: " + ex.Message);
                       }
                        try
                        {
                            //modbus.WriteMultipleRegisters(0, WORD_WRITE); ;  // WRITE ALL WORDS
                        }

                       catch (Exception ex)
                        {
                           MessageBox.Show("Write mulriple registers: " + ex.Message);
                        }
                        if (check1 == true)
                        {
                            try
                            {
                                //WORD_READ = modbus.ReadHoldingRegisters(0, 1); //READ ALL WORDS
                                //posXtab1 = EasyModbus.ModbusClient.ConvertRegistersToInt(modbus.ReadHoldingRegisters(24, 2));
                                //posYtab1 = EasyModbus.ModbusClient.ConvertRegistersToInt(modbus.ReadHoldingRegisters(22, 2));
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Read words MDBS: " + ex.Message);
                            }

                            //Thread.Sleep(milliseconds);
                            try
                            {
                                CONTROL_READ = modbus.ReadCoils(2000, 39);
                            }
                            
                            catch (Exception ex)
                            {
                                MessageBox.Show("Read bits MDBS: " + ex.Message);
                            }
                            bit1 = CONTROL_READ[0]; //M2000
                            Rilecart_stop = CONTROL_READ[1]; //M2001
                            bit3 = CONTROL_READ[2]; //M2002
                            bit4 = CONTROL_READ[3]; //M2003
                            bit5 = CONTROL_READ[4]; //M2004
                            Collator_Missing_left = CONTROL_READ[5]; //M2005
                            Collator_Missing_right = CONTROL_READ[6]; //M2006
                            Collator_Paper_jam = CONTROL_READ[7]; //M2007
                            Rilecart_emergency_stop = CONTROL_READ[8]; //M2008
                            Rilecart_missing_fin = CONTROL_READ[9]; //M2009
                            bit11 = CONTROL_READ[10]; //M2010
                            bit12 = CONTROL_READ[11]; //M2011
                            Collator_bypass = CONTROL_READ[12]; //M2012
                            Rilecart_bypass = CONTROL_READ[13]; //M2013
                            Rotation_paper_jam = CONTROL_READ[14]; //M2014
                            bit2 = CONTROL_READ[15]; //M2015
                            Rilecart_run = CONTROL_READ[17]; //M2017
                            DoubleON = CONTROL_READ[18]; //M2018
                        }
                        else if (check1 == false)
                        {
                             modbus.Disconnect();
                        }
                    }
                    catch (Exception ex) when (ex.Source == "mscorlib")
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        string msg = Convert.ToString(ex.InnerException);
                        MessageBox.Show("Read MDBS: " + ex.Message);
                    }
                }
           
            }
        }
        /// 
        /// Write data to box, from modbus
        /// 
        void WriteMDBS(string name)
        {

        }
        
        private void InterfaceUpdate(object sender, EventArgs e)

        //void InterfaceUpdate()
        {
            if (CONTROL_READ[16] == false) //
            {
                this.flowLayoutPanel2.Visible = true;
                this.flowLayoutPanel2.Enabled = true;
            }
            else if (CONTROL_READ[16] == true) //
            {
                this.flowLayoutPanel2.Visible = false;
                this.flowLayoutPanel2.Enabled = false;
            }
            if (CONTROL_READ[19] == true && scan == true)
            {
                tbResult.Items.Add(" ");
                tbResult.Items.Add("                      SCAN           ");
                tbResult.Items.Add(" ");
                tbResult.Items.Add("Front - " + CONTROL_READ[20]);
                tbResult.Items.Add("January - " + CONTROL_READ[21]);
                tbResult.Items.Add("February - " + CONTROL_READ[22]);
                tbResult.Items.Add("March - " + CONTROL_READ[23]);
                tbResult.Items.Add("April - " + CONTROL_READ[24]);
                tbResult.Items.Add("May - " + CONTROL_READ[25]);
                tbResult.Items.Add("June - " + CONTROL_READ[26]);
                tbResult.Items.Add("July - " + CONTROL_READ[27]);
                tbResult.Items.Add("August - " + CONTROL_READ[28]);
                tbResult.Items.Add("September - " + CONTROL_READ[29]);
                tbResult.Items.Add("October - " + CONTROL_READ[30]);
                tbResult.Items.Add("November - " + CONTROL_READ[31]);
                tbResult.Items.Add("December - " + CONTROL_READ[32]);
                tbResult.Items.Add("Rear - " + CONTROL_READ[33]);
                check2 = true;
                scan = false;
            }
            string Collator1 = null;
            string Collator2 = null;
            string Collator3 = null;
            string Collator4 = null;
            string Collator5 = null;
            string Rilecart1 = null;
            string Rilecart2 = null;
            string Rilecart3 = null;
            string Rilecart4 = null;
            string Rotation = null;
            string RunStat1 = null;
            string RunStat2 = null;
            string RunStat3 = null;

            pictureBox2.Refresh();
            if (modbus.Connected == true)
            {
                lblStat.Text = "Status: Connected";
                this.btnStart.Image = global::CollatorSupervisor.Properties.Resources.Group_10;
                btnStart.Refresh();
                lblStat.Refresh();
            }

            else if (modbus.Connected == false)
            {
                lblStat.Text = "Status: Disconnected";
                this.btnStart.Image = global::CollatorSupervisor.Properties.Resources.Group_9;
                btnStart.Refresh();
                lblStat.Refresh();
            }

            //MotorSpeedSliderControl.Value = Properties.Settings.Default.SpeedPERC;// PERCENT OF MAIN SPEED = SAVED VALUE
            //motorSpeed = MotorSpeedSliderControl.Value;                           //
            //trackBar2.Value = Properties.Settings.Default.RailcartSave;            // MANUAL SPEED Y = SAVED VALUE
            //motorSpeedY = trackBar2.Value;

            DateTime thisDay = DateTime.Now;
            textBox3.Text = thisDay.ToString("d") + @"
" + thisDay.ToString("T");
            textBox6.Text = "[" + JobID + "] - [" + SchoolName + "]" + @"
" + "Calendar type: " + CalendarType;


               RunStat1 = "READY";
               RunStat2 = "READY";
               RunStat3 = "READY";

            //else if (run == false)
            //{
            //    RunStat1 = "STOP";
            //    RunStat2 = "STOP";
            //    RunStat3 = "STOP";
            //}
            if (Collator_Missing_left == true)
            {
                Collator1 = "Missing left" + @"
";
                tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(218, 67, 60);
                label1.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                label7.ForeColor = System.Drawing.Color.White;
                label15.ForeColor = System.Drawing.Color.White;
                label16.ForeColor = System.Drawing.Color.White;
            }
            if (Collator_Missing_left == false)
            {
                Collator1 = null;
                tableLayoutPanel6.BackColor = Color.White;
                label1.ForeColor = System.Drawing.Color.Gray;
                label2.ForeColor = System.Drawing.Color.Gray;
                label3.ForeColor = System.Drawing.Color.Gray;
                label4.ForeColor = System.Drawing.Color.Gray;
                label6.ForeColor = System.Drawing.Color.Gray;
                label7.ForeColor = System.Drawing.Color.Gray;
                label15.ForeColor = System.Drawing.Color.Gray;
                label16.ForeColor = System.Drawing.Color.Gray;
            }
            if (Collator_Missing_right == true)
            {
                Collator2 = "Missing right" + @"
";
                tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(218, 67, 60);
                label26.ForeColor = System.Drawing.Color.White;
                label30.ForeColor = System.Drawing.Color.White;
                label33.ForeColor = System.Drawing.Color.White;
                label34.ForeColor = System.Drawing.Color.White;
                label35.ForeColor = System.Drawing.Color.White;
                label36.ForeColor = System.Drawing.Color.White;
            }
            if (Collator_Missing_right == false)
            {
                Collator2 = null; 
                tableLayoutPanel7.BackColor = Color.White;
                label26.ForeColor = System.Drawing.Color.Gray;
                label30.ForeColor = System.Drawing.Color.Gray;
                label33.ForeColor = System.Drawing.Color.Gray;
                label34.ForeColor = System.Drawing.Color.Gray;
                label35.ForeColor = System.Drawing.Color.Gray;
                label36.ForeColor = System.Drawing.Color.Gray;
            }
            if (Collator_Paper_jam == true)
            {
                Collator3 = "Paper jam" + @"
";
                    
                }
            if (Collator_Paper_jam == false)
            {
                Collator3 = null;
            }
            if (Collator_bypass == true)
            {
                Collator4 = "Collator bypass";
            }
            if (Collator_bypass == false)
            {
                Collator4 = null;
            }
            if (DoubleON == true)
            {
                Collator5 = "Double" + @"
";

            }
            if (DoubleON == false)
            {
                Collator5 = null;
            }


            if (Collator_Paper_jam == true || Collator_Missing_right == true || Collator_Missing_left == true || DoubleON == true)
            {
                textBox14.BackColor = System.Drawing.Color.FromArgb(218, 67, 60);
                textBox14.Text = Collator1 + Collator2 + Collator3 + Collator4 + Collator5;
                textBox14.ForeColor = System.Drawing.Color.White;
            }
//            if (Collator_Paper_jam == false && Collator_Missing_right == false && Collator_Missing_left == false)
//            {
//                textBox14.BackColor = System.Drawing.Color.FromArgb(45, 232, 14);
//                textBox14.Text = Collator4 + @"
//" + RunStat3;
//                textBox14.ForeColor = System.Drawing.Color.Black;
//            }
            if (Collator_Paper_jam == false && Collator_Missing_right == false && Collator_Missing_left == false && DoubleON == false)
            {
                textBox14.BackColor = System.Drawing.Color.FromArgb(218, 218, 218);
                textBox14.Text = Collator4 + @"
" + RunStat3;
                textBox14.ForeColor = System.Drawing.Color.Black;
            }
            ////////////////////////////////////////////////////
            if (Rilecart_emergency_stop == true)
            {
                Rilecart1 = "Emergency stop" + @"
";
            }
            if (Rilecart_emergency_stop == false)
            {
                Rilecart1 = null;
            }
            if (Rilecart_missing_fin == true)
            {
                Rilecart2 = "Missing fin" + @"
";
            }
            if (Rilecart_missing_fin == false)
            {
                Rilecart2 = null;
            }

            if (Rilecart_stop == true)
            {
                Rilecart3 = "Rilecart STOP" + @"
";
            }
            if (Rilecart_stop == false)
            {
                Rilecart3 = null;
            }
            if (Rilecart_bypass == true)
            {
                Rilecart4 = "Rilecart bypass";
            }
            if (Rilecart_bypass == false)
            {
                Rilecart4 = null;
            }

            if (Rilecart_emergency_stop == true || Rilecart_missing_fin == true || Rilecart_stop == true)
            {
                textBox11.BackColor = System.Drawing.Color.FromArgb(218, 67, 60);
                textBox11.Text = Rilecart1 + Rilecart2 + Rilecart3 + Rilecart4;
                textBox11.ForeColor = System.Drawing.Color.White;
            }
            if (Rilecart_run == true && Rilecart_emergency_stop == false && Rilecart_missing_fin == false && Rilecart_stop == false)
            {
                textBox11.BackColor = System.Drawing.Color.FromArgb(45, 232, 14);
                textBox11.Text = Rilecart4 + @"
" + "RILECART RUN";
                textBox11.ForeColor = System.Drawing.Color.Black;
            }
            if (Rilecart_run == false && Rilecart_emergency_stop == false && Rilecart_missing_fin == false && Rilecart_stop == false)
            {
                textBox11.BackColor = System.Drawing.Color.FromArgb(218, 218, 218);
                textBox11.Text = Rilecart4 + @"
" + RunStat1;
                textBox11.ForeColor = System.Drawing.Color.Black;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            if (Rotation_paper_jam == true)
            {
                Rotation = "Turntable paper jam";
                textBox12.BackColor = System.Drawing.Color.FromArgb(218, 67, 60);
                textBox12.ForeColor = System.Drawing.Color.White;
                textBox12.Text = Rotation;

            }
//            if (Rotation_paper_jam == false)
//            {
//                Rotation = null;
//                textBox12.BackColor = System.Drawing.Color.FromArgb(45, 232, 14);
//                textBox12.ForeColor = System.Drawing.Color.Black;
//                textBox12.Text = Rotation + @"
//" + RunStat2;
//            }
            if (Rotation_paper_jam == false)
            {
                Rotation = null;
                textBox12.BackColor = System.Drawing.Color.FromArgb(218, 218, 218);
                textBox12.ForeColor = System.Drawing.Color.Black;
                textBox12.Text = Rotation + @"
" + RunStat2;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            if (DoubleON == true || Collator_Paper_jam == true || Collator_Missing_right == true || Collator_Missing_left == true || Rilecart_emergency_stop == true || Rilecart_missing_fin == true || Rilecart_stop == true || Rotation_paper_jam == true)
            {
                //tabPage1.BackgroundImage = Resources.Rectangle_146__1_;
            }
            //else if (Collator_Paper_jam == false && Collator_Missing_right == false && Collator_Missing_left == false && Rilecart_emergency_stop == false && Rilecart_missing_fin == false && Rilecart_stop == false && Rotation_paper_jam == false)
            //{
            //    pictureBox3.Image = Resources.Rectangle_147__2_;

            //}
            else if (DoubleON = false && Collator_Paper_jam == false && Collator_Missing_right == false && Collator_Missing_left == false && Rilecart_emergency_stop == false && Rilecart_missing_fin == false && Rilecart_stop == false && Rotation_paper_jam == false)
            {
                //tabPage1.BackgroundImage = null;
            }

            //                        textBox30.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox31.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox32.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox33.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox34.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox35.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox43.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox46.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox47.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox48.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox49.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox50.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";
            //                        textBox51.Text = "Pos: " + "1" + @"
            //" + "[" + "Month" + "]";

            if (modbus.Connected == false)
            {
                textBox9.Text = "";
            }
        }
        /// 
        /// Write X ACC
        /// 
        private void textBox45_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox45.Text == "")
            {
                return;
            }
            else if (textBox45.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox45.Text);
                if (txt > 1000)
                {
                    MessageBox.Show("Set value from 0 to 1000");
                    txt1 = 1000;
                    textBox45.Text = "1000";
                }
                else if (txt <= 1000)
                    txt1 = txt;
            }
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '.') || (e.KeyChar == (char)Keys.Back)) //|| (e.KeyChar == '-')
            {
                return;
            }
            e.Handled = true;
        }
        /// 
        /// Write X DEC
        /// 
        private void textBox44_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox44.Text == "")
            {
                return;
            }
            else if (textBox44.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox44.Text);
                if (txt > 1000)
                {
                    MessageBox.Show("Set value from 0 to 1000");
                    txt2 = 1000;
                    textBox44.Text = "1000";
                }
                else if (txt <= 1000)
                    txt2 = txt;
            }
        }
        /// 
        /// BTN UP
        /// 
        private void btnUP_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (ManSpd > 0)
                {
                   BoolUp = true;
                }
                else if (ManSpd == 0)
                {
                   BoolUp = false;
                   MessageBox.Show("set speed greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("plc disabled");
            }

        }
        private void btnUP_Up(object sender, EventArgs e)
        {
            BoolUp = false;
        }

        ///// 
        ///// BTN DOWN
        ///// 
        private void btnDWN_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (ManSpd > 0)
                {
                    BoolDwn = true;
                }
               else if (ManSpd == 0)
                {
                    BoolDwn = false;
                    MessageBox.Show("Set speed greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }

        }
        private void btnDWN_Up(object sender, EventArgs e)
        {
            BoolDwn = false;
        }
        /// 
        /// WHITE BACKGROUND IF MOUSE ENTER
        /// 
        private void btnDWN_ENTER(object sender, EventArgs e)
        {
            btnDWN.BackColor = System.Drawing.Color.White;
        }
        /// 
        /// WHITE BACKGROUND IF MOUSE ENTER
        /// 
        private void btnUp_ENTER(object sender, EventArgs e)
        {
            btnUP.BackColor = System.Drawing.Color.White;
        }
        /// 
        /// PORT INPUT
        /// 
        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// IP INPUT
        /// 
        private void txtIPAdress_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = txtIPAdress.Text;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                //if (Solenoid == false)
                //{
                //    CONTROL[9] = !CONTROL[9];
                //}
                //if (Solenoid == true)
                //{
                //    CONTROL[9] = false;
               // }
                  
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        
        private void SOL_Down(object sender, EventArgs e)
        {
          //  if (modbus.Connected == true)
          //  {
//
          //          CONTROL[9] = true;
          //  }
          //  else if (modbus.Connected == false)
          //  {
          //      MessageBox.Show("PLC disabled");
          //  }
        }
        private void SOL_Up(object sender, EventArgs e)
        {
          //  CONTROL[9] = false;
        }

        private void Form_Listener_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }




        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ManSpd = trackBar1.Value;
            textBox4.Text = ManSpd.ToString();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            BoolCollator = checkBox12.Checked;
            Properties.Settings.Default.CollatorSave = BoolCollator;
            Properties.Settings.Default.Save();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            BoolRailcart = checkBox11.Checked;
            Properties.Settings.Default.RailcartSave = BoolRailcart;
            Properties.Settings.Default.Save();
        }

        private void Form_Listener_Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                check1 = false;
                Thread.Sleep(100);
                modbus.Disconnect();
                thread1.Abort(); ;
                thread2.Abort();
            }
            catch
            {
                return;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            run = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "0")
            {
                angle0 = true;
                angle90 = false;
                angle180 = false;
            }
            if (listBox1.Text == "90")
            {
                angle0 = false;
                angle90 = true;
                angle180 = false;
            }
            if (listBox1.Text == "180")
            {
                angle0 = false;
                angle90 = false;
                angle180 = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbResult.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            scan = true; 
        }
    }
}
    