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
        int motorSpeed;
        int motorSpeedX;
        int motorSpeedY;
        int ManSpd;
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
        private bool[] CONTROL_WRITE = new bool[14];
        private bool[] CONTROL_READ = new bool[14];
        private string[] files;
      
        private bool check1 = false;
    
        string sub = "";
        string tesser;


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
            this.Closing += new CancelEventHandler(this.Form_Listener_Close);
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
            textBox45.Text = Properties.Settings.Default.ACC_Y_MAN;
            textBox44.Text = Properties.Settings.Default.DEC_Y_MAN;
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
            textBox4.Text = Properties.Settings.Default.ManSpdSave.ToString();
            trackBar1.Value = Properties.Settings.Default.ManSpdSave;
            checkBox12.Checked = Properties.Settings.Default.CollatorSave;
            checkBox11.Checked = Properties.Settings.Default.RailcartSave;

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

                        WORD_WRITE[2] = Convert.ToInt32(motorSpeedX); //Write Manual Speed X
                        WORD_WRITE[10] = Convert.ToInt32(ManSpd);//Write ManSpd
                        WORD_WRITE[30] = Convert.ToInt32(motorSpeed); //Write Main Speed Percent
                        WORD_WRITE[4] = txt1; //ACC X
                        WORD_WRITE[12] = txt3; //ACC Y
                        WORD_WRITE[28] = txt2; //ACC X
                        WORD_WRITE[26] = txt4; //ACC Y
                        WORD_WRITE[32] = txt5; //SPD X1
                        WORD_WRITE[34] = txt6; //SPD X2
                        WORD_WRITE[36] = txt7; //SPD Y1
                        WORD_WRITE[38] = txt8; //SPD Y2
                        WORD_WRITE[48] = txt9; //POSITION 1
                        WORD_WRITE[50] = txt10; //POSITION 2
                        WORD_WRITE[52] = txt11; //POSITION 3
                        WORD_WRITE[16] = Grab_TMR; //Grab_TMR
                        WORD_WRITE[18] = Scan_TMR; //Scan_TMR
                        WORD_WRITE[20] = Release_TMR; //Release_TMR
                        WORD_WRITE[54] = Hi;

                        CONTROL_WRITE[0] = checkBox1.Checked; //M100
                        CONTROL_WRITE[1] = checkBox2.Checked; //M101
                        CONTROL_WRITE[2] = checkBox3.Checked; //M102
                        CONTROL_WRITE[3] = checkBox4.Checked; //M103
                        CONTROL_WRITE[4] = checkBox5.Checked; //M104
                        CONTROL_WRITE[5] = checkBox6.Checked; //M105
                        CONTROL_WRITE[6] = checkBox7.Checked; //M106
                        CONTROL_WRITE[7] = checkBox8.Checked; //M107
                        CONTROL_WRITE[8] = checkBox9.Checked; //M108
                        CONTROL_WRITE[9] = checkBox10.Checked; //M109
                        CONTROL_WRITE[10] = BoolUp; //M110
                        CONTROL_WRITE[11] = BoolDwn; //M111
                        CONTROL_WRITE[12] = BoolCollator; //M112
                        CONTROL_WRITE[13] = BoolRailcart; //M113
                        try
                        {
                            modbus.WriteMultipleCoils(100, CONTROL_WRITE); // WRITE ALL BITS
                        }

                        catch (Exception ex)
                       {
                           MessageBox.Show("Write mulriple coils: " + ex.Message);
                       }
                        try
                        {
                            modbus.WriteMultipleRegisters(0, WORD_WRITE); ;  // WRITE ALL WORDS
                        }

                       catch (Exception ex)
                        {
                           MessageBox.Show("Write mulriple registers: " + ex.Message);
                        }
                        if (check1 == true)
                        {
                            try
                            {
                                WORD_READ = modbus.ReadHoldingRegisters(0, 56); //READ ALL WORDS
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
                                CONTROL_READ = modbus.ReadCoils(200, 14);
                            }
                            
                            catch (Exception ex)
                            {
                                MessageBox.Show("Read bits MDBS: " + ex.Message);
                            }
                            bit1 = CONTROL_READ[0]; //M200
                            bit2 = CONTROL_READ[1]; //M201
                            bit3 = CONTROL_READ[2]; //M202
                            bit4 = CONTROL_READ[3]; //M203
                            bit5 = CONTROL_READ[4]; //M204
                            bit6 = CONTROL_READ[5]; //M205
                            bit7 = CONTROL_READ[6]; //M206
                            bit8 = CONTROL_READ[7]; //M207
                            bit9 = CONTROL_READ[8]; //M208
                            bit10 = CONTROL_READ[9]; //M209
                            bit11 = CONTROL_READ[10]; //M210
                            bit12 = CONTROL_READ[11]; //M211
                            bit13 = CONTROL_READ[12]; //M212
                            bit14 = CONTROL_READ[13]; //M213


                            if (CONTROL_READ[0] == true) // GREEN UP
                            {
                                this.label9.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[0] == false) // STANDART UP
                            {
                                this.label9.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[1] == true) // GREEN DOWN
                            {
                                this.label10.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[1] == false) // STANDART DOWN
                            {
                                this.label10.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[2] == true) // GREEN DOWN
                            {
                                this.label17.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[2] == false) // STANDART DOWN
                            {
                                this.label17.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[3] == true) // GREEN DOWN
                            {
                                this.label18.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[3] == false) // STANDART DOWN
                            {
                                this.label18.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[4] == true) // GREEN DOWN
                            {
                                this.label24.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[4] == false) // STANDART DOWN
                            {
                                this.label24.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[5] == true) // GREEN DOWN
                            {
                                this.label23.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[5] == false) // STANDART DOWN
                            {
                                this.label23.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[6] == true) // GREEN DOWN
                            {
                                this.label20.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[6] == false) // STANDART DOWN
                            {
                                this.label20.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[7] == true) // GREEN DOWN
                            {
                                this.label19.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[7] == false) // STANDART DOWN
                            {
                                this.label19.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[8] == true) // GREEN DOWN
                            {
                                this.label32.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[8] == false) // STANDART DOWN
                            {
                                this.label32.BackColor = System.Drawing.Color.White;
                            }
                            if (CONTROL_READ[9] == true) // GREEN DOWN
                            {
                                this.label31.BackColor = System.Drawing.Color.Green;
                            }
                            else if (CONTROL_READ[9] == false) // STANDART DOWN
                            {
                                this.label31.BackColor = System.Drawing.Color.White;
                            }
                            //if (START == true & HOME == false) // GREEN START, STANDART STOP, STANDART HOME
                            //{
                            //    this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_23;
                            //    this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_22;
                            //    this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_26;
                            //}
                            //if (START == false) // RED STOP, STANDART START,STANDART HOME
                            //{
                            //    this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
                            //    this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_24;
                            //    this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_26;
                            //}
                            //if (HOME == true & START == false) // GREEN HOME, STANDART STOP, STANDART START
                            //{
                            //    this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_22;
                            //    this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_27;
                            //    this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
                            //}
                            //if (InvokeRequired)
                            //{
                            //    Invoke(new Action(() =>
                            //    {
                            //        if (tabControl1.Controls[0] == tabControl1.SelectedTab) // AUTO MODE ON
                            //            CONTROL[4] = true;
                            //        if (tabControl1.Controls[1] == tabControl1.SelectedTab) // AUTO MODE OFF
                            //            CONTROL[4] = false;
                            //        if (tabControl1.Controls[2] == tabControl1.SelectedTab) // AUTO MODE OFF
                            //            CONTROL[4] = false;
                            //    }));
                            //}
                            //else
                            //{
                            //    if (tabControl1.Controls[0] == tabControl1.SelectedTab) // AUTO MODE ON
                            //        CONTROL[4] = true;
                            //    if (tabControl1.Controls[1] == tabControl1.SelectedTab) // AUTO MODE OFF
                            //        CONTROL[4] = false;
                            //    if (tabControl1.Controls[2] == tabControl1.SelectedTab) // AUTO MODE OFF
                            //        CONTROL[4] = false;
                            //}
                            //if (Solenoid == true) // GREEN RIGHT
                            //{
                            //    this.label8.BackColor = System.Drawing.Color.Green;
                            //}
                            //else if (Solenoid == false) // STANDART RIGHT
                            //{
                            //    this.label8.BackColor = System.Drawing.Color.White;
                            //}
                            //if (UpLim == true) // GREEN RIGHT
                            //{
                            //    this.label11.BackColor = System.Drawing.Color.Green;
                            //}
                            //else if (UpLim == false) // STANDART RIGHT
                            //{
                            //    this.label11.BackColor = System.Drawing.Color.White;
                            //}
                            //if (DownLim == true) // GREEN RIGHT
                            //{
                            //    this.label12.BackColor = System.Drawing.Color.Green;
                            //}
                            //else if (DownLim == false) // STANDART RIGHT
                            //{
                            //    this.label12.BackColor = System.Drawing.Color.White;
                            //}
                            //if (PapLim == true) // GREEN RIGHT
                            //{
                            //    this.label14.BackColor = System.Drawing.Color.Green;
                            //    this.label15.BackColor = System.Drawing.Color.Green;
                            //}
                            //else if (PapLim == false) // STANDART RIGHT
                            //{
                            //    this.label14.BackColor = System.Drawing.Color.White;
                            //    this.label15.BackColor = System.Drawing.Color.White;
                            //}
                            //if (PresLim == true) // GREEN RIGHT
                            //{
                            //    this.label13.BackColor = System.Drawing.Color.Green;
                            //    this.label16.BackColor = System.Drawing.Color.Green;
                            //}
                            //else if (PresLim == false) // STANDART RIGHT
                            //{
                            //    this.label13.BackColor = System.Drawing.Color.White;
                            //    this.label16.BackColor = System.Drawing.Color.White;
                            //}
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
                        //MotorSpeedSliderControl.Value = Properties.Settings.Default.SpeedPERC;// PERCENT OF MAIN SPEED = SAVED VALUE
                        //motorSpeed = MotorSpeedSliderControl.Value;                           //
                        //trackBar2.Value = Properties.Settings.Default.RailcartSave;            // MANUAL SPEED Y = SAVED VALUE
                        //motorSpeedY = trackBar2.Value;

                        DateTime thisDay = DateTime.Now;
                        textBox3.Text = thisDay.ToString("d") + @"
" + thisDay.ToString("T");
                        textBox6.Text = "["+ JobID + "] - [" + SchoolName + "]"+ @"
" + "Calendar type: " + CalendarType;
                        textBox29.Text = "Pos: " + "1" + @"
" + "[" + "Month"+"]";
                        textBox30.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox31.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox32.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox33.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox34.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox35.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox43.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox46.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox47.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox48.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox49.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox50.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox51.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";

                        if (modbus.Connected == false)
                        {
                            lblStat.Text = "Status: Disconnected";
                            textBox13.Text = "";
                            textBox1.Text = "";
                            textBox20.Text = "";
                            textBox21.Text = "";
                            textBox9.Text = "";
                        }
                    }));
                    }
                    else
                    {
                        //MotorSpeedSliderControl.Value = Properties.Settings.Default.SpeedPERC;
                        //motorSpeed = MotorSpeedSliderControl.Value;
                        //trackBar2.Value = Properties.Settings.Default.RailcartSave;
                        //motorSpeedY = trackBar2.Value;

                        DateTime thisDay = DateTime.Now;
                        textBox3.Text = thisDay.ToString("d") + @"
" + thisDay.ToString("T");
                        textBox6.Text = "[" + JobID + "] - [" + SchoolName + "]" + @"
" + "Calendar type: " + CalendarType;
                        textBox29.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox30.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox31.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox32.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox33.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox34.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox35.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox43.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox46.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox47.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox48.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox49.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox50.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";
                        textBox51.Text = "Pos: " + "1" + @"
" + "[" + "Month" + "]";


                        if (modbus.Connected == false)
                        {
                            lblStat.Text = "Status: Disconnected";
                            textBox13.Text = "";
                            textBox1.Text = "";
                            textBox20.Text = "";
                            textBox21.Text = "";
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
                                textBox9.Text = WORD_READ[10].ToString(); //M1 SPEED (Manual Speed Y)
                                textBox1.Text = WORD_READ[30].ToString() + "%"; // PERCENT OF MAIN SPEED
                                textBox13.Text = posXtab1.ToString(); //position Y Tab1
                                textBox20.Text = WORD_READ[44].ToString(); //SPD Y1 Tab1
                                textBox21.Text = WORD_READ[46].ToString(); //SPD Y2 Tab1
                                

                            }));
                        }

                        else
                        {
                            textBox9.Text = WORD_READ[10].ToString(); //M1 SPEED (Manual Speed Y)
                            textBox1.Text = WORD_READ[30].ToString() + "%"; // PERCENT OF MAIN SPEED
                            textBox13.Text = posXtab1.ToString(); //position Y Tab1
                            textBox20.Text = WORD_READ[44].ToString(); //SPD Y1 Tab1
                            textBox21.Text = WORD_READ[46].ToString(); //SPD Y2 Tab1

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
            Properties.Settings.Default.ACC_Y_MAN = textBox45.Text;
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
            Properties.Settings.Default.DEC_Y_MAN = textBox44.Text;
            Properties.Settings.Default.Save();
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

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            JobID = textBox7.Text.ToString();
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            SchoolName = textBox8.Text.ToString();
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            CalendarType = textBox10.Text.ToString();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ManSpd = trackBar1.Value;
            textBox4.Text = ManSpd.ToString();
            Properties.Settings.Default.ManSpdSave = ManSpd;
            Properties.Settings.Default.Save();
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
    }
}
    