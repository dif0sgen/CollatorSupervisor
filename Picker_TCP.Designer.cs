using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TCP_LISTENER_Delta
{
    partial class Form_Listener
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ///<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Speed;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listener));
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label8;
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblStat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            this.MotorSpeedSliderControl = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblEvents = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIPAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDWN = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnUP = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            Speed = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorSpeedSliderControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Speed
            // 
            resources.ApplyResources(Speed, "Speed");
            Speed.Name = "Speed";
            // 
            // label27
            // 
            resources.ApplyResources(label27, "label27");
            label27.Name = "label27";
            label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnStart.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_9;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblStat
            // 
            resources.ApplyResources(this.lblStat, "lblStat");
            this.lblStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.lblStat.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStat.ForeColor = System.Drawing.Color.White;
            this.lblStat.Name = "lblStat";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Name = "textBox3";
            // 
            // textBox45
            // 
            resources.ApplyResources(this.textBox45, "textBox45");
            this.textBox45.Name = "textBox45";
            this.textBox45.TextChanged += new System.EventHandler(this.textBox45_TextChanged_1);
            this.textBox45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // textBox44
            // 
            resources.ApplyResources(this.textBox44, "textBox44");
            this.textBox44.Name = "textBox44";
            this.textBox44.TextChanged += new System.EventHandler(this.textBox44_TextChanged_1);
            this.textBox44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Maximum = 20000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.SmallChange = 100;
            this.trackBar2.TickFrequency = 2000;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label41);
            this.tabPage4.Controls.Add(this.textBox21);
            this.tabPage4.Controls.Add(this.textBox20);
            this.tabPage4.Controls.Add(this.textBox13);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.txtMessages);
            this.tabPage4.Controls.Add(this.label40);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btnTXT);
            this.tabPage4.Controls.Add(this.MotorSpeedSliderControl);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.btnClose);
            this.tabPage4.Controls.Add(this.btnNext);
            this.tabPage4.Controls.Add(this.labelSpeed);
            this.tabPage4.Controls.Add(this.btnPrev);
            this.tabPage4.Controls.Add(this.btnOpen);
            this.tabPage4.Controls.Add(this.lblEvents);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // txtMessages
            // 
            resources.ApplyResources(this.txtMessages, "txtMessages");
            this.txtMessages.Name = "txtMessages";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button3.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_32;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button2.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_24;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button1.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTXT
            // 
            resources.ApplyResources(this.btnTXT, "btnTXT");
            this.btnTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnTXT.FlatAppearance.BorderSize = 0;
            this.btnTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.UseVisualStyleBackColor = false;
            // 
            // MotorSpeedSliderControl
            // 
            this.MotorSpeedSliderControl.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.MotorSpeedSliderControl, "MotorSpeedSliderControl");
            this.MotorSpeedSliderControl.LargeChange = 10;
            this.MotorSpeedSliderControl.Maximum = 100;
            this.MotorSpeedSliderControl.Name = "MotorSpeedSliderControl";
            this.MotorSpeedSliderControl.SmallChange = 10;
            this.MotorSpeedSliderControl.TickFrequency = 10;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // labelSpeed
            // 
            resources.ApplyResources(this.labelSpeed, "labelSpeed");
            this.labelSpeed.Name = "labelSpeed";
            // 
            // btnPrev
            // 
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // lblEvents
            // 
            resources.ApplyResources(this.lblEvents, "lblEvents");
            this.lblEvents.Name = "lblEvents";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox28);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.textBox26);
            this.groupBox5.Controls.Add(this.textBox27);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox22);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.textBox23);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.textBox24);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBox28
            // 
            resources.ApplyResources(this.textBox28, "textBox28");
            this.textBox28.Name = "textBox28";
            this.textBox28.TextChanged += new System.EventHandler(this.textBox28_TextChanged);
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // textBox26
            // 
            resources.ApplyResources(this.textBox26, "textBox26");
            this.textBox26.Name = "textBox26";
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // textBox27
            // 
            resources.ApplyResources(this.textBox27, "textBox27");
            this.textBox27.Name = "textBox27";
            this.textBox27.TextChanged += new System.EventHandler(this.textBox27_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // textBox23
            // 
            resources.ApplyResources(this.textBox23, "textBox23");
            this.textBox23.Name = "textBox23";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox23_TextChanged);
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // textBox24
            // 
            resources.ApplyResources(this.textBox24, "textBox24");
            this.textBox24.Name = "textBox24";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txtIPAdress);
            this.groupBox1.Controls.Add(this.lblAdress);
            this.groupBox1.Controls.Add(this.txtPort);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblPort
            // 
            resources.ApplyResources(this.lblPort, "lblPort");
            this.lblPort.Name = "lblPort";
            // 
            // txtIPAdress
            // 
            resources.ApplyResources(this.txtIPAdress, "txtIPAdress");
            this.txtIPAdress.Name = "txtIPAdress";
            this.txtIPAdress.TextChanged += new System.EventHandler(this.txtIPAdress_TextChanged);
            // 
            // lblAdress
            // 
            resources.ApplyResources(this.lblAdress, "lblAdress");
            this.lblAdress.Name = "lblAdress";
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox11);
            this.tabPage2.Controls.Add(this.checkBox12);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            resources.ApplyResources(this.checkBox11, "checkBox11");
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox12
            // 
            resources.ApplyResources(this.checkBox12, "checkBox12");
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.btnDWN);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.btnUP);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.textBox52);
            this.groupBox4.Controls.Add(Speed);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2")});
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDWN
            // 
            resources.ApplyResources(this.btnDWN, "btnDWN");
            this.btnDWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnDWN.FlatAppearance.BorderSize = 0;
            this.btnDWN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnDWN.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_13;
            this.btnDWN.Name = "btnDWN";
            this.btnDWN.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Maximum = 30000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TickFrequency = 3000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnUP
            // 
            resources.ApplyResources(this.btnUP, "btnUP");
            this.btnUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnUP.FlatAppearance.BorderSize = 0;
            this.btnUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.btnUP.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_16;
            this.btnUP.Name = "btnUP";
            this.btnUP.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // textBox52
            // 
            this.textBox52.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox52, "textBox52");
            this.textBox52.Name = "textBox52";
            this.textBox52.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.imageBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.checkBox10);
            this.tabPage1.Controls.Add(this.checkBox9);
            this.tabPage1.Controls.Add(this.checkBox8);
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button4.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_24;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button5.Image = global::TCP_LISTENER_Delta.Properties.Resources.Group_21;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.textBox39);
            this.flowLayoutPanel1.Controls.Add(this.textBox40);
            this.flowLayoutPanel1.Controls.Add(this.textBox43);
            this.flowLayoutPanel1.Controls.Add(this.textBox47);
            this.flowLayoutPanel1.Controls.Add(this.textBox64);
            this.flowLayoutPanel1.Controls.Add(this.textBox62);
            this.flowLayoutPanel1.Controls.Add(this.textBox63);
            this.flowLayoutPanel1.Controls.Add(this.textBox55);
            this.flowLayoutPanel1.Controls.Add(this.textBox56);
            this.flowLayoutPanel1.Controls.Add(this.textBox57);
            this.flowLayoutPanel1.Controls.Add(this.textBox58);
            this.flowLayoutPanel1.Controls.Add(this.textBox59);
            this.flowLayoutPanel1.Controls.Add(this.textBox60);
            this.flowLayoutPanel1.Controls.Add(this.textBox61);
            this.flowLayoutPanel1.Controls.Add(this.textBox65);
            this.flowLayoutPanel1.Controls.Add(this.textBox66);
            this.flowLayoutPanel1.Controls.Add(this.textBox67);
            this.flowLayoutPanel1.Controls.Add(this.textBox68);
            this.flowLayoutPanel1.Controls.Add(this.textBox78);
            this.flowLayoutPanel1.Controls.Add(this.textBox69);
            this.flowLayoutPanel1.Controls.Add(this.textBox70);
            this.flowLayoutPanel1.Controls.Add(this.textBox71);
            this.flowLayoutPanel1.Controls.Add(this.textBox72);
            this.flowLayoutPanel1.Controls.Add(this.textBox73);
            this.flowLayoutPanel1.Controls.Add(this.textBox74);
            this.flowLayoutPanel1.Controls.Add(this.textBox75);
            this.flowLayoutPanel1.Controls.Add(this.textBox76);
            this.flowLayoutPanel1.Controls.Add(this.textBox77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // textBox39
            // 
            this.textBox39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox39, "textBox39");
            this.textBox39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox40, "textBox40");
            this.textBox40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox40.Name = "textBox40";
            this.textBox40.ReadOnly = true;
            // 
            // textBox43
            // 
            this.textBox43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox43, "textBox43");
            this.textBox43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox43.Name = "textBox43";
            this.textBox43.ReadOnly = true;
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox47, "textBox47");
            this.textBox47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox47.Name = "textBox47";
            this.textBox47.ReadOnly = true;
            // 
            // textBox64
            // 
            this.textBox64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox64, "textBox64");
            this.textBox64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox64.Name = "textBox64";
            this.textBox64.ReadOnly = true;
            // 
            // textBox62
            // 
            this.textBox62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox62, "textBox62");
            this.textBox62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox62.Name = "textBox62";
            this.textBox62.ReadOnly = true;
            // 
            // textBox63
            // 
            this.textBox63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox63, "textBox63");
            this.textBox63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox63.Name = "textBox63";
            this.textBox63.ReadOnly = true;
            // 
            // textBox55
            // 
            this.textBox55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox55, "textBox55");
            this.textBox55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox55.Name = "textBox55";
            this.textBox55.ReadOnly = true;
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox56, "textBox56");
            this.textBox56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox56.Name = "textBox56";
            this.textBox56.ReadOnly = true;
            // 
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox57, "textBox57");
            this.textBox57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox57.Name = "textBox57";
            this.textBox57.ReadOnly = true;
            // 
            // textBox58
            // 
            this.textBox58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox58, "textBox58");
            this.textBox58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox58.Name = "textBox58";
            this.textBox58.ReadOnly = true;
            // 
            // textBox59
            // 
            this.textBox59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox59, "textBox59");
            this.textBox59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox59.Name = "textBox59";
            this.textBox59.ReadOnly = true;
            // 
            // textBox60
            // 
            this.textBox60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox60, "textBox60");
            this.textBox60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox60.Name = "textBox60";
            this.textBox60.ReadOnly = true;
            // 
            // textBox61
            // 
            this.textBox61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox61, "textBox61");
            this.textBox61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox61.Name = "textBox61";
            this.textBox61.ReadOnly = true;
            // 
            // textBox65
            // 
            this.textBox65.BackColor = System.Drawing.Color.White;
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox65, "textBox65");
            this.textBox65.ForeColor = System.Drawing.Color.Black;
            this.textBox65.Name = "textBox65";
            this.textBox65.ReadOnly = true;
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.Color.White;
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox66, "textBox66");
            this.textBox66.ForeColor = System.Drawing.Color.Black;
            this.textBox66.Name = "textBox66";
            this.textBox66.ReadOnly = true;
            // 
            // textBox67
            // 
            this.textBox67.BackColor = System.Drawing.Color.White;
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox67, "textBox67");
            this.textBox67.ForeColor = System.Drawing.Color.Black;
            this.textBox67.Name = "textBox67";
            this.textBox67.ReadOnly = true;
            // 
            // textBox68
            // 
            this.textBox68.BackColor = System.Drawing.Color.White;
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox68, "textBox68");
            this.textBox68.ForeColor = System.Drawing.Color.Black;
            this.textBox68.Name = "textBox68";
            this.textBox68.ReadOnly = true;
            // 
            // textBox78
            // 
            this.textBox78.BackColor = System.Drawing.Color.White;
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox78, "textBox78");
            this.textBox78.ForeColor = System.Drawing.Color.Black;
            this.textBox78.Name = "textBox78";
            this.textBox78.ReadOnly = true;
            // 
            // textBox69
            // 
            this.textBox69.BackColor = System.Drawing.Color.White;
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox69, "textBox69");
            this.textBox69.ForeColor = System.Drawing.Color.Black;
            this.textBox69.Name = "textBox69";
            this.textBox69.ReadOnly = true;
            // 
            // textBox70
            // 
            this.textBox70.BackColor = System.Drawing.Color.White;
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox70, "textBox70");
            this.textBox70.ForeColor = System.Drawing.Color.Black;
            this.textBox70.Name = "textBox70";
            this.textBox70.ReadOnly = true;
            // 
            // textBox71
            // 
            this.textBox71.BackColor = System.Drawing.Color.White;
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox71, "textBox71");
            this.textBox71.ForeColor = System.Drawing.Color.Black;
            this.textBox71.Name = "textBox71";
            this.textBox71.ReadOnly = true;
            // 
            // textBox72
            // 
            this.textBox72.BackColor = System.Drawing.Color.White;
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox72, "textBox72");
            this.textBox72.ForeColor = System.Drawing.Color.Black;
            this.textBox72.Name = "textBox72";
            this.textBox72.ReadOnly = true;
            // 
            // textBox73
            // 
            this.textBox73.BackColor = System.Drawing.Color.White;
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox73, "textBox73");
            this.textBox73.ForeColor = System.Drawing.Color.Black;
            this.textBox73.Name = "textBox73";
            this.textBox73.ReadOnly = true;
            // 
            // textBox74
            // 
            this.textBox74.BackColor = System.Drawing.Color.White;
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox74, "textBox74");
            this.textBox74.ForeColor = System.Drawing.Color.Black;
            this.textBox74.Name = "textBox74";
            this.textBox74.ReadOnly = true;
            // 
            // textBox75
            // 
            this.textBox75.BackColor = System.Drawing.Color.White;
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox75, "textBox75");
            this.textBox75.ForeColor = System.Drawing.Color.Black;
            this.textBox75.Name = "textBox75";
            this.textBox75.ReadOnly = true;
            // 
            // textBox76
            // 
            this.textBox76.BackColor = System.Drawing.Color.White;
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox76, "textBox76");
            this.textBox76.ForeColor = System.Drawing.Color.Black;
            this.textBox76.Name = "textBox76";
            this.textBox76.ReadOnly = true;
            // 
            // textBox77
            // 
            this.textBox77.BackColor = System.Drawing.Color.White;
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox77, "textBox77");
            this.textBox77.ForeColor = System.Drawing.Color.Black;
            this.textBox77.Name = "textBox77";
            this.textBox77.ReadOnly = true;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // imageBox1
            // 
            resources.ApplyResources(this.imageBox1, "imageBox1");
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.TabStop = false;
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            resources.ApplyResources(this.checkBox9, "checkBox9");
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Form_Listener
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form_Listener";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorSpeedSliderControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.TrackBar MotorSpeedSliderControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIPAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDWN;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private ListBox listBox1;
    }
}

