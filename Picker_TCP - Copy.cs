using EasyModbus;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.IO;
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

namespace TCP_LISTENER_Delta
{

    public partial class Form_Listener : Form
    {

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
        string step;
        int step2;
        int step3;
        int ReadModbus;
        int motorSpeed;
        int motorSpeedX;
        int motorSpeedY;
        int numshots;
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
        Int32 posXtab1;
        Int32 posXtab2;
        Int32 posYtab1;
        Int32 posYtab2;
        Int32 Hi;
        private int imageIndex;
        private string[] imageList;
        private bool[] M = new bool[6];
        private Int32[] D = new Int32[56];
        private Int32[] SPDX = new Int32[56];
        private Int32[] SPDY = new Int32[1];
        private Int32[] ACCX = new Int32[1];
        private Int32[] ACCY = new Int32[1];
        bool[] Abool = new bool[18];
        private bool[] CONTROL = new bool[11];
        private bool[] Mcontrol = new bool[11];
        private string[] files;
        private bool M1 = false;
        private bool M2 = false;
        private bool M3 = false;
        private bool M4 = false;
        private bool M5 = false;
        private bool M6 = false;
        private bool M7 = false;
        private bool M8 = false;
        private bool M9 = false;
        private bool M10 = false;
        private bool M11 = false;
        private bool M12 = false;
        private bool F = false;
        private bool BTNCon;
        private bool UP;
        private bool DOWN;
        private bool LEFT;
        private bool RIGHT;
        private bool START;
        private bool STOP;
        private bool HOME;
        private bool Solenoid;
        private bool UpLim;
        private bool DownLim;
        private bool RightLim;
        private bool LeftLim;
        private bool PapLim;
        private bool PresLim;
        private bool check1 = false;
        private bool check2 = false;

        string sub = "";
        string tesser;
        double IntPosition;
        double PosDiff;
        double Pos_Prev;

        /// 
        /// Init Form
        /// 
        public Form_Listener()
        {
            InitializeComponent();

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
            this.Closing += new CancelEventHandler(this.Form_Listener_Closing);
            btnUP.MouseUp += btnUP_Up;
            btnUP.MouseDown += btnUP_Down;
            btnUP.MouseEnter += btnUp_ENTER;
            btnDWN.MouseDown += btnDWN_Down;
            btnDWN.MouseUp += btnDWN_Up;
            btnDWN.MouseEnter += btnDWN_ENTER;
            btnStart.MouseEnter += OnMouseEnterButton1;
            btnStart.MouseLeave += OnMouseLeaveButton1;
            button5.MouseDown += SOL_Down;
            button5.MouseUp += SOL_Up;
            button5.MouseEnter += SOL_ENTER;

            ///
            /// GET SAVED VALUES
            ///
            textBox45.Text = Properties.Settings.Default.ACC_X_MAN;
            textBox44.Text = Properties.Settings.Default.DEC_X_MAN;
            txtPort.Text = Properties.Settings.Default.Port;
            txtIPAdress.Text = Properties.Settings.Default.IP;
            textBox16.Text = Properties.Settings.Default.SpeedY1;
            textBox17.Text = Properties.Settings.Default.SpeedY2;
            textBox24.Text = Properties.Settings.Default.POS1;
            textBox23.Text = Properties.Settings.Default.POS2;
            textBox22.Text = Properties.Settings.Default.POS3;
            textBox27.Text = Properties.Settings.Default.GrabTMR;
            textBox26.Text = Properties.Settings.Default.ScanTMR;
            textBox28.Text = Properties.Settings.Default.ReleaseTMR;
            textBox5.Text = Properties.Settings.Default.tesPath;
            textBox2.Text = Properties.Settings.Default.Height;

        }
        /// 
        /// STOP
        /// 
        private void button2_Click(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                CONTROL[5] = false;
                CONTROL[6] = true;
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
                if (txt9 == txt10 || txt10 == txt11 || txt11 == txt9)
                {
                    MessageBox.Show("Incorrect position value. Coordinates have the same values");
                }
                else if (txt9 != txt10 & txt10 != txt11 & txt11 != txt9)
                {
                    if (motorSpeed > 0 & D[40] > 0 & D[42] > 0 & D[44] > 0 & D[46] > 0)
                    {
                        CONTROL[5] = true;
                    }
                    else if (motorSpeed == 0 || D[40] == 0 || D[42] == 0 || D[44] == 0 || D[46] == 0)
                    {
                        CONTROL[5] = false;
                        MessageBox.Show("Speed is 0, set higher value");
                    }
                }
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
                if (motorSpeed > 0 & D[40] > 0 & D[42] > 0 & D[44] > 0 & D[46] > 0)
                {
                    CONTROL[7] = true;
                }
                else if (motorSpeed == 0 || D[40] == 0 || D[42] == 0 || D[44] == 0 || D[46] == 0)
                {
                    CONTROL[7] = false;
                    MessageBox.Show("Speed is 0, set higher value");
                }
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
            btnStart.BackColor = System.Drawing.Color.FromArgb(115, 115, 115);
        }


        /// 
        /// Speed track bar
        /// 
        private void MotorSpeedSliderControl_Scroll(object sender, EventArgs e)
        {
            motorSpeed = MotorSpeedSliderControl.Value;
            Properties.Settings.Default.SpeedPERC = MotorSpeedSliderControl.Value;
            Properties.Settings.Default.Save();
        }
        /// 
        /// Speed track bar
        /// 
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            motorSpeedY = trackBar2.Value;
            Properties.Settings.Default.SPEED_Y_MAN = trackBar2.Value;
            Properties.Settings.Default.Save();
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
                if (modbus.Connected == true)
                    lblStat.Text = "Status: Connected";
                this.btnStart.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_10;
                //this.lblStat.ForeColor = System.Drawing.Color.Green;
            }
            else if (modbus.Connected == true)
            {
                try
                {

                    check1 = false;
                    this.btnStart.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_9;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Disconnect Modbus: "+ex.Message);

                }
            }
        }
        /// 
        /// Open file dialog
        /// 
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog newOpenFile = new OpenFileDialog();
            newOpenFile.Filter = ".jpg, .jpeg, .bmp, .gif, .png|*.jpg;*.jpeg;*bmp;*gif;*.png";
            if (newOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Load(newOpenFile.FileName);
                label2.Text = "Name: " + pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                sub = pictureBox1.ImageLocation.Substring(0, pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                label3.Text = "Path: " + sub;
                imageList = Directory.GetFiles(sub);
            }
        }
        /// 
        /// CLOSE FILE + RESET ALL STRINGS
        /// 
        private void btnClose_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            sub = "";
            label2.Text = "Name: ";
            label3.Text = "Path: ";
            richTextBox1.Text = "";
            pictureBox1.ImageLocation = "";
        }
        /// 
        /// Next file
        /// 
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (sub != "")
            {
                try
                {
                    files = Directory.GetFiles(sub);
                    if (i < files.Length - 1)
                    {
                        i++;
                        pictureBox1.Load(files[i]);
                        label2.Text = "Name: " + pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        sub = pictureBox1.ImageLocation.Substring(0, pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        label3.Text = "Path: " + sub;
                    }
                    else if (i == files.Length - 1)
                    {
                        i = 0;
                        pictureBox1.Load(files[i]);
                        label2.Text = "Name: " + pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        sub = pictureBox1.ImageLocation.Substring(0, pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        label3.Text = "Path: " + sub;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Next picture: "+ex.Message);
                }

            }
            /// 
            /// Previous file
            /// 
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (sub != "")
            {
                try
                {
                    files = Directory.GetFiles(sub); // GET ARRAY OF FILES
                    if (i == 0)
                    {
                        i = files.Length - 1;
                        pictureBox1.Load(files[i]); // LOAD FILE #I FROM ARRAY
                        label2.Text = "Name: " + pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf("\\") + 1); //NAME
                        sub = pictureBox1.ImageLocation.Substring(0, pictureBox1.ImageLocation.LastIndexOf("\\") + 1); //PATH
                        label3.Text = "Path: " + sub;
                        imageList = Directory.GetFiles(sub);
                    }
                    else if (i > 0)
                    {
                        i--;
                        pictureBox1.Load(files[i]);
                        label2.Text = "Name: " + pictureBox1.ImageLocation.Substring(pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        sub = pictureBox1.ImageLocation.Substring(0, pictureBox1.ImageLocation.LastIndexOf("\\") + 1);
                        label3.Text = "Path: " + sub;
                        imageList = Directory.GetFiles(sub);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Prev picture: "+ex.Message);
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

                        SPDX[2] = Convert.ToInt32(motorSpeedX); //Write Manual Speed X
                        SPDX[10] = Convert.ToInt32(motorSpeedY);//Write Manual Speed Y
                        SPDX[30] = Convert.ToInt32(motorSpeed); //Write Main Speed Percent
                        SPDX[4] = txt1; //ACC X
                        SPDX[12] = txt3; //ACC Y
                        SPDX[28] = txt2; //ACC X
                        SPDX[26] = txt4; //ACC Y
                        SPDX[32] = txt5; //SPD X1
                        SPDX[34] = txt6; //SPD X2
                        SPDX[36] = txt7; //SPD Y1
                        SPDX[38] = txt8; //SPD Y2
                        SPDX[48] = txt9; //POSITION 1
                        SPDX[50] = txt10; //POSITION 2
                        SPDX[52] = txt11; //POSITION 3
                        SPDX[16] = Grab_TMR; //Grab_TMR
                        SPDX[18] = Scan_TMR; //Scan_TMR
                        SPDX[20] = Release_TMR; //Release_TMR
                        SPDX[54] = Hi;

                        //modbus.WriteMultipleCoils(147, Abool);
                        try
                        {
                            modbus.WriteMultipleCoils(11, CONTROL); // WRITE ALL BITS
                        }

                        catch (Exception ex)
                       {
                           MessageBox.Show("Write mulriple coils: " + ex.Message);
                       }
                        //Thread.Sleep(milliseconds);

                        try
                        {
                            modbus.WriteMultipleRegisters(0, SPDX); ;  // WRITE ALL WORDS
                        }

                       catch (Exception ex)
                        {
                           MessageBox.Show("Write mulriple registers: " + ex.Message);
                        }
                        CONTROL[7] = false;// RESET "HOME" AFTER WRITING
                        CONTROL[6] = false;// RESET "STOP" AFTER WRITING
                        if (check1 == true)
                        {
                            try
                            {
                                D = modbus.ReadHoldingRegisters(0, 56); //READ ALL WORDS
                                posXtab1 = EasyModbus.ModbusClient.ConvertRegistersToInt(modbus.ReadHoldingRegisters(24, 2));
                                posYtab1 = EasyModbus.ModbusClient.ConvertRegistersToInt(modbus.ReadHoldingRegisters(22, 2));
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Read words MDBS: " + ex.Message);
                            }

                            //Thread.Sleep(milliseconds);
                            try
                            {
                                Mcontrol = modbus.ReadCoils(11, 11);
                                M = modbus.ReadCoils(22, 6);
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Read bits MDBS: " + ex.Message);
                            }

                            CONTROL[10] = Mcontrol[10];
                            UP = Mcontrol[0];
                            DOWN = Mcontrol[1];
                            LEFT = Mcontrol[2];
                            RIGHT = Mcontrol[3];
                            START = Mcontrol[5];
                            HOME = Mcontrol[8];
                            Solenoid = Mcontrol[9];
                            RightLim = M[0];
                            LeftLim = M[1];
                            UpLim = M[2];
                            DownLim = M[3];
                            PresLim = M[4];
                            PapLim = M[5];
                            //Thread.Sleep(milliseconds);


                            if (UP == true) // GREEN UP
                            {
                                this.label28.BackColor = System.Drawing.Color.Green;
                            }
                            else if (UP == false) // STANDART UP
                            {
                                this.label28.BackColor = System.Drawing.Color.White;
                            }
                            if (DOWN == true) // GREEN DOWN
                            {
                                this.label29.BackColor = System.Drawing.Color.Green;
                            }
                            else if (DOWN == false) // STANDART DOWN
                            {
                                this.label29.BackColor = System.Drawing.Color.White;
                            }
                            if (START == true & HOME == false) // GREEN START, STANDART STOP, STANDART HOME
                            {
                                this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_23;
                                this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_22;
                                this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_26;
                            }
                            if (START == false) // RED STOP, STANDART START,STANDART HOME
                            {
                                this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
                                this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_24;
                                this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_26;
                            }
                            if (HOME == true & START == false) // GREEN HOME, STANDART STOP, STANDART START
                            {
                                this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_22;
                                this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_27;
                                this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
                            }
                            if (InvokeRequired)
                            {
                                Invoke(new Action(() =>
                                {
                                    if (tabControl1.Controls[0] == tabControl1.SelectedTab) // AUTO MODE ON
                                        CONTROL[4] = true;
                                    if (tabControl1.Controls[1] == tabControl1.SelectedTab) // AUTO MODE OFF
                                        CONTROL[4] = false;
                                    if (tabControl1.Controls[2] == tabControl1.SelectedTab) // AUTO MODE OFF
                                        CONTROL[4] = false;
                                }));
                            }
                            else
                            {
                                if (tabControl1.Controls[0] == tabControl1.SelectedTab) // AUTO MODE ON
                                    CONTROL[4] = true;
                                if (tabControl1.Controls[1] == tabControl1.SelectedTab) // AUTO MODE OFF
                                    CONTROL[4] = false;
                                if (tabControl1.Controls[2] == tabControl1.SelectedTab) // AUTO MODE OFF
                                    CONTROL[4] = false;
                            }
                            if (Solenoid == true) // GREEN RIGHT
                            {
                                this.label8.BackColor = System.Drawing.Color.Green;
                            }
                            else if (Solenoid == false) // STANDART RIGHT
                            {
                                this.label8.BackColor = System.Drawing.Color.White;
                            }
                            if (UpLim == true) // GREEN RIGHT
                            {
                                this.label11.BackColor = System.Drawing.Color.Green;
                            }
                            else if (UpLim == false) // STANDART RIGHT
                            {
                                this.label11.BackColor = System.Drawing.Color.White;
                            }
                            if (DownLim == true) // GREEN RIGHT
                            {
                                this.label12.BackColor = System.Drawing.Color.Green;
                            }
                            else if (DownLim == false) // STANDART RIGHT
                            {
                                this.label12.BackColor = System.Drawing.Color.White;
                            }
                            if (PapLim == true) // GREEN RIGHT
                            {
                                this.label14.BackColor = System.Drawing.Color.Green;
                                this.label15.BackColor = System.Drawing.Color.Green;
                            }
                            else if (PapLim == false) // STANDART RIGHT
                            {
                                this.label14.BackColor = System.Drawing.Color.White;
                                this.label15.BackColor = System.Drawing.Color.White;
                            }
                            if (PresLim == true) // GREEN RIGHT
                            {
                                this.label13.BackColor = System.Drawing.Color.Green;
                                this.label16.BackColor = System.Drawing.Color.Green;
                            }
                            else if (PresLim == false) // STANDART RIGHT
                            {
                                this.label13.BackColor = System.Drawing.Color.White;
                                this.label16.BackColor = System.Drawing.Color.White;
                            }
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
            while (true)
            {
                try
                {

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                    {
                        MotorSpeedSliderControl.Value = Properties.Settings.Default.SpeedPERC;// PERCENT OF MAIN SPEED = SAVED VALUE
                        motorSpeed = MotorSpeedSliderControl.Value;                           //
                        trackBar2.Value = Properties.Settings.Default.SPEED_Y_MAN;            // MANUAL SPEED Y = SAVED VALUE
                        motorSpeedY = trackBar2.Value;

                        DateTime thisDay = DateTime.Now;
                        textBox3.Text = thisDay.ToString("d") + " | " + thisDay.ToString("T");
                        textBox6.Text = "["+ JobID + "] - [" + SchoolName + "]"+ @"
" + "Calendar type: " + CalendarType;

                        if (modbus.Connected == false)
                        {
                            lblStat.Text = "Status: Disconnected";
                            textBox13.Text = "";
                            textBox1.Text = "";
                            textBox20.Text = "";
                            textBox21.Text = "";
                            textBox4.Text = "";
                            textBox9.Text = "";
                        }
                    }));
                    }
                    else
                    {
                        MotorSpeedSliderControl.Value = Properties.Settings.Default.SpeedPERC;
                        motorSpeed = MotorSpeedSliderControl.Value;
                        trackBar2.Value = Properties.Settings.Default.SPEED_Y_MAN;
                        motorSpeedY = trackBar2.Value;

                        DateTime thisDay = DateTime.Now;
                        textBox3.Text = thisDay.ToString("d") + " | " + thisDay.ToString("T");
                        textBox6.Text = "[" + JobID + "] - [" + SchoolName + "]" + @"
" + "Calendar type: " + CalendarType;


                        if (modbus.Connected == false)
                        {
                            lblStat.Text = "Status: Disconnected";
                            textBox13.Text = "";
                            textBox1.Text = "";
                            textBox20.Text = "";
                            textBox21.Text = "";
                            textBox4.Text = "";
                            textBox9.Text = "";
                        }
                    }
                }
                catch (Exception ex) when (ex.Source == "mscorlib")
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Write trackbar from memory: "+ex.Message);
                }
                if (modbus.Connected == true)
                {
                    try
                    {

                        //if (D[2] < 0)
                        //    resultX = (unchecked((uint)D[2]) - 4294901762);
                        //if (D[2] >= 0)
                        //    resultX = (unchecked((uint)D[2]));
                        //if (D[30] < 0)
                        //   result = (unchecked((uint)D[30]) - 4294901762);
                        //if (D[30] >= 0)
                        //    result = (unchecked((uint)D[30]));
                        //if (D[10] < 0)
                        //    resultY = (unchecked((uint)D[10]) - 4294901762);
                        //if (D[10] >= 0)
                        //    resultY = (unchecked((uint)D[10]));

                        if (InvokeRequired)
                        {
                            Invoke(new Action(() =>
                            {
                                textBox9.Text = D[10].ToString(); //M1 SPEED (Manual Speed Y)
                                textBox1.Text = D[30].ToString() + "%"; // PERCENT OF MAIN SPEED
                                textBox4.Text = posXtab1.ToString(); //position Y Tab2
                                textBox13.Text = posXtab1.ToString(); //position Y Tab1
                                textBox20.Text = D[44].ToString(); //SPD Y1 Tab1
                                textBox21.Text = D[46].ToString(); //SPD Y2 Tab1


                            }));
                        }

                        else
                        {
                            textBox9.Text = D[10].ToString(); //M1 SPEED (Manual Speed Y)
                            textBox1.Text = D[30].ToString() + "%"; // PERCENT OF MAIN SPEED  
                            textBox4.Text = posXtab1.ToString(); //position Y Tab2
                            textBox13.Text = posXtab1.ToString(); //position Y Tab1
                            textBox20.Text = D[44].ToString(); //SPD Y1 Tab1
                            textBox21.Text = D[46].ToString(); //SPD Y2 Tab1


                        }

                    }
                    catch (Exception ex) when (ex.Source == "mscorlib")
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Positions from modbus: "+ex.Message);
                    }
                }
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
            Properties.Settings.Default.ACC_X_MAN = textBox45.Text;
            Properties.Settings.Default.Save();
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
            Properties.Settings.Default.DEC_X_MAN = textBox44.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// BTN UP
        /// 
        private void btnUP_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (motorSpeedY > 0)
                {
                    CONTROL[0] = true;
                }
                else if (motorSpeedY == 0)
                {
                    CONTROL[0] = false;
                    MessageBox.Show("Set speed Y greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }

        }
        private void btnUP_Up(object sender, EventArgs e)
        {
            CONTROL[0] = false;
        }
        /// 
        /// BTN RIGHT
        /// 
        private void btnRIGHT_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (motorSpeedX > 0)
                {
                    CONTROL[3] = true;
                }
                else if (motorSpeedX == 0)
                {
                    CONTROL[3] = false;
                    MessageBox.Show("Set speed X greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        private void btnRIGHT_Up(object sender, EventArgs e)
        {
            CONTROL[3] = false;
        }
        /// 
        /// BTN LEFT
        /// 
        private void btnLEFT_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (motorSpeedX > 0)
                {
                    CONTROL[2] = true;
                }
                else if (motorSpeedX == 0)
                {
                    CONTROL[2] = false;
                    MessageBox.Show("Set speed X greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }
        }
        private void btnLEFT_Up(object sender, EventArgs e)
        {
            CONTROL[2] = false;
        }
        /// 
        /// BTN DOWN
        /// 
        private void btnDWN_Down(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                if (motorSpeedY > 0)
                {
                    CONTROL[1] = true;
                }
                else if (motorSpeedY == 0)
                {
                    CONTROL[1] = false;
                    MessageBox.Show("Set speed Y greater than 0");
                }
            }
            else if (modbus.Connected == false)
            {
                MessageBox.Show("PLC disabled");
            }

        }
        private void btnDWN_Up(object sender, EventArgs e)
        {
            CONTROL[1] = false;
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
        /// READ TXT FROM PICTURE
        /// 
        private void btnTXT_Click(object sender, EventArgs e)
        {
            try
            {
                Tesseract tesseract = new Tesseract(@tesser, "eng", OcrEngineMode.TesseractLstmCombined);
                tesseract.SetImage(new Image<Bgr, byte>(pictureBox1.ImageLocation));
                tesseract.Recognize();
                richTextBox1.Text = tesseract.GetUTF8Text();
                tesseract.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tesseract"+ex.Message);
            }
        }
        /// 
        /// MAIN SPEED Y1
        /// 
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            {

                if (textBox16.Text == "")
                {
                    return;
                }
                else if (textBox16.Text != "")
                {
                    Int32 txt = Convert.ToInt32(textBox16.Text);
                    if (txt > 20000)
                    {
                        MessageBox.Show("Set value from 0 to 20000");
                        txt7 = 20000;
                        textBox16.Text = "20000";
                    }
                    else if (txt <= 20000)
                        txt7 = txt;
                }
            }
            Properties.Settings.Default.SpeedY1 = textBox16.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// RELEASE TIMER INPUT
        /// 
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            {

                if (textBox17.Text == "")
                {
                    return;
                }
                else if (textBox17.Text != "")
                {
                    Int32 txt = Convert.ToInt32(textBox17.Text);
                    if (txt > 20000)
                    {
                        MessageBox.Show("Set value from 0 to 20000");
                        txt8 = 20000;
                        textBox17.Text = "20000";
                    }
                    else if (txt <= 20000)
                        txt8 = txt;
                }
            }
            Properties.Settings.Default.SpeedY2 = textBox17.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// RELEASE POSITION Y INPUT
        /// 
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "")
            {
                return;
            }
            else if (textBox24.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox24.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    txt9 = 20000;
                    textBox24.Text = "20000";
                }
                else if (txt <= 20000)
                    txt9 = txt;
            }
            Properties.Settings.Default.POS1 = textBox24.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// SCAN POSITION Y INPUT
        /// 
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                return;
            }
            else if (textBox23.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox23.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    txt10 = 20000;
                    textBox23.Text = "20000";
                }
                else if (txt <= 20000)
                    txt10 = txt;
            }
            Properties.Settings.Default.POS2 = textBox23.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// GRAB POSITION Y INPUT
        /// 
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "")
            {
                return;
            }
            else if (textBox22.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox22.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    txt11 = 20000;
                    textBox22.Text = "20000";
                }
                else if (txt <= 20000)
                    txt11 = txt;
            }
            Properties.Settings.Default.POS3 = textBox22.Text;
            Properties.Settings.Default.Save();
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
        /// 
        /// GRAB TIMER INPUT
        /// 
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "")
            {
                return;
            }
            else if (textBox27.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox27.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    Grab_TMR = 20000;
                    textBox27.Text = "20000";
                }
                else if (txt <= 20000)
                    Grab_TMR = txt;
            }
            Properties.Settings.Default.GrabTMR = textBox27.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// SCAN TIMER INPUT
        /// 
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "")
            {
                return;
            }
            else if (textBox26.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox26.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    Scan_TMR = 20000;
                    textBox26.Text = "20000";
                }
                else if (txt <= 20000)
                    Scan_TMR = txt;
            }
            Properties.Settings.Default.ScanTMR = textBox26.Text;
            Properties.Settings.Default.Save();
        }
        /// 
        /// RELEASE TIMER INPUT
        /// 
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text == "")
            {
                return;
            }
            else if (textBox22.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox28.Text);
                if (txt > 20000)
                {
                    MessageBox.Show("Set value from 0 to 20000");
                    Release_TMR = 20000;
                    textBox28.Text = "20000";
                }
                else if (txt <= 20000)
                    Release_TMR = txt;
            }
            Properties.Settings.Default.ReleaseTMR = textBox28.Text;
            Properties.Settings.Default.Save();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            tesser = textBox5.Text;
            Properties.Settings.Default.tesPath = textBox5.Text;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modbus.Connected == true)
            {
                //if (Solenoid == false)
                //{
                    CONTROL[9] = !CONTROL[9];
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
        private void SOL_ENTER(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.White;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                return;
            }
            else if (textBox2.Text != "")
            {
                Int32 txt = Convert.ToInt32(textBox2.Text);
                if (txt > 20000 | txt < -20000)
                {
                    MessageBox.Show("Set value from -20000 to 20000");
                    Hi = 0;
                    textBox2.Text = "0";
                }
                else if (txt > -20000 | txt < 20000)
                    Hi = txt;
            }
            Properties.Settings.Default.Height = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void Form_Listener_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                check1 = false;
                modbus.Disconnect();
                thread1.Abort();;
                thread2.Abort();
            }
            catch
            {
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            JobID = textBox7.Text.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SchoolName = textBox8.Text.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CalendarType = textBox10.Text.ToString();
        }
    }
}
    