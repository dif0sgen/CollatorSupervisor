using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CollatorSupervisor
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
            this.tmUpdateState = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIPAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            Speed = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.btnStart.Image = global::CollatorSupervisor.Properties.Resources.Group_9;
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
            // tmUpdateState
            // 
            this.tmUpdateState.Enabled = true;
            this.tmUpdateState.Tick += new System.EventHandler(this.InterfaceUpdate);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox11);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // checkBox12
            // 
            resources.ApplyResources(this.checkBox12, "checkBox12");
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            resources.ApplyResources(this.checkBox11, "checkBox11");
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = false;
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
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btnDWN.Image = global::CollatorSupervisor.Properties.Resources.Group_13;
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
            this.btnUP.Image = global::CollatorSupervisor.Properties.Resources.Group_16;
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
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
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
            this.tabPage1.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.checkBox19);
            this.flowLayoutPanel2.Controls.Add(this.checkBox18);
            this.flowLayoutPanel2.Controls.Add(this.checkBox17);
            this.flowLayoutPanel2.Controls.Add(this.checkBox16);
            this.flowLayoutPanel2.Controls.Add(this.checkBox15);
            this.flowLayoutPanel2.Controls.Add(this.checkBox14);
            this.flowLayoutPanel2.Controls.Add(this.checkBox13);
            this.flowLayoutPanel2.Controls.Add(this.checkBox5);
            this.flowLayoutPanel2.Controls.Add(this.checkBox4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // checkBox19
            // 
            resources.ApplyResources(this.checkBox19, "checkBox19");
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            resources.ApplyResources(this.checkBox18, "checkBox18");
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            resources.ApplyResources(this.checkBox17, "checkBox17");
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            resources.ApplyResources(this.checkBox16, "checkBox16");
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            resources.ApplyResources(this.checkBox15, "checkBox15");
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            resources.ApplyResources(this.checkBox14, "checkBox14");
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            resources.ApplyResources(this.checkBox13, "checkBox13");
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.textBox32);
            this.flowLayoutPanel3.Controls.Add(this.textBox33);
            this.flowLayoutPanel3.Controls.Add(this.textBox34);
            this.flowLayoutPanel3.Controls.Add(this.textBox35);
            this.flowLayoutPanel3.Controls.Add(this.textBox36);
            this.flowLayoutPanel3.Controls.Add(this.textBox15);
            this.flowLayoutPanel3.Controls.Add(this.textBox90);
            this.flowLayoutPanel3.Controls.Add(this.textBox91);
            this.flowLayoutPanel3.Controls.Add(this.textBox92);
            this.flowLayoutPanel3.Controls.Add(this.textBox93);
            this.flowLayoutPanel3.Controls.Add(this.textBox94);
            this.flowLayoutPanel3.Controls.Add(this.textBox95);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox32, "textBox32");
            this.textBox32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox33, "textBox33");
            this.textBox33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox34, "textBox34");
            this.textBox34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox35, "textBox35");
            this.textBox35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox36, "textBox36");
            this.textBox36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            // 
            // textBox90
            // 
            this.textBox90.BackColor = System.Drawing.Color.White;
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox90, "textBox90");
            this.textBox90.ForeColor = System.Drawing.Color.Black;
            this.textBox90.Name = "textBox90";
            this.textBox90.ReadOnly = true;
            // 
            // textBox91
            // 
            this.textBox91.BackColor = System.Drawing.Color.White;
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox91, "textBox91");
            this.textBox91.ForeColor = System.Drawing.Color.Black;
            this.textBox91.Name = "textBox91";
            this.textBox91.ReadOnly = true;
            // 
            // textBox92
            // 
            this.textBox92.BackColor = System.Drawing.Color.White;
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox92, "textBox92");
            this.textBox92.ForeColor = System.Drawing.Color.Black;
            this.textBox92.Name = "textBox92";
            this.textBox92.ReadOnly = true;
            // 
            // textBox93
            // 
            this.textBox93.BackColor = System.Drawing.Color.White;
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox93, "textBox93");
            this.textBox93.ForeColor = System.Drawing.Color.Black;
            this.textBox93.Name = "textBox93";
            this.textBox93.ReadOnly = true;
            // 
            // textBox94
            // 
            this.textBox94.BackColor = System.Drawing.Color.White;
            this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox94, "textBox94");
            this.textBox94.ForeColor = System.Drawing.Color.Black;
            this.textBox94.Name = "textBox94";
            this.textBox94.ReadOnly = true;
            // 
            // textBox95
            // 
            this.textBox95.BackColor = System.Drawing.Color.White;
            this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox95, "textBox95");
            this.textBox95.ForeColor = System.Drawing.Color.Black;
            this.textBox95.Name = "textBox95";
            this.textBox95.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
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
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(103)))), ((int)(((byte)(210)))));
            this.button4.Image = global::CollatorSupervisor.Properties.Resources.Group_24;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.textBox62);
            this.flowLayoutPanel1.Controls.Add(this.textBox43);
            this.flowLayoutPanel1.Controls.Add(this.textBox47);
            this.flowLayoutPanel1.Controls.Add(this.textBox64);
            this.flowLayoutPanel1.Controls.Add(this.textBox63);
            this.flowLayoutPanel1.Controls.Add(this.textBox39);
            this.flowLayoutPanel1.Controls.Add(this.textBox40);
            this.flowLayoutPanel1.Controls.Add(this.textBox57);
            this.flowLayoutPanel1.Controls.Add(this.textBox70);
            this.flowLayoutPanel1.Controls.Add(this.textBox71);
            this.flowLayoutPanel1.Controls.Add(this.textBox69);
            this.flowLayoutPanel1.Controls.Add(this.textBox72);
            this.flowLayoutPanel1.Controls.Add(this.textBox78);
            this.flowLayoutPanel1.Controls.Add(this.textBox73);
            this.flowLayoutPanel1.Controls.Add(this.textBox68);
            this.flowLayoutPanel1.Controls.Add(this.textBox74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
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
            // textBox63
            // 
            this.textBox63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox63, "textBox63");
            this.textBox63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox63.Name = "textBox63";
            this.textBox63.ReadOnly = true;
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
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox57, "textBox57");
            this.textBox57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox57.Name = "textBox57";
            this.textBox57.ReadOnly = true;
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
            // textBox69
            // 
            this.textBox69.BackColor = System.Drawing.Color.White;
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox69, "textBox69");
            this.textBox69.ForeColor = System.Drawing.Color.Black;
            this.textBox69.Name = "textBox69";
            this.textBox69.ReadOnly = true;
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
            // textBox78
            // 
            this.textBox78.BackColor = System.Drawing.Color.White;
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox78, "textBox78");
            this.textBox78.ForeColor = System.Drawing.Color.Black;
            this.textBox78.Name = "textBox78";
            this.textBox78.ReadOnly = true;
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
            // textBox68
            // 
            this.textBox68.BackColor = System.Drawing.Color.White;
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox68, "textBox68");
            this.textBox68.ForeColor = System.Drawing.Color.Black;
            this.textBox68.Name = "textBox68";
            this.textBox68.ReadOnly = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmUpdateState;
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
        private TabPage tabPage3;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private TabPage tabPage2;
        private Label label29;
        private GroupBox groupBox4;
        private ListBox listBox1;
        private Button btnDWN;
        private TrackBar trackBar1;
        private Button btnUP;
        private TextBox textBox4;
        private Label label28;
        private TextBox textBox52;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox36;
        private TextBox textBox15;
        private TextBox textBox90;
        private TextBox textBox91;
        private TextBox textBox92;
        private TextBox textBox93;
        private TextBox textBox94;
        private TextBox textBox95;
        private TextBox textBox1;
        private TextBox textBox12;
        private TextBox textBox14;
        private TextBox textBox11;
        private TextBox textBox6;
        private Label label48;
        private Label label47;
        private CheckBox checkBox3;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label12;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox62;
        private TextBox textBox43;
        private TextBox textBox47;
        private TextBox textBox64;
        private TextBox textBox63;
        private TextBox textBox39;
        private TextBox textBox40;
        private TextBox textBox57;
        private TextBox textBox70;
        private TextBox textBox71;
        private TextBox textBox69;
        private TextBox textBox72;
        private TextBox textBox78;
        private TextBox textBox73;
        private TextBox textBox68;
        private TextBox textBox74;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Label label31;
        private Label label32;
        private Label label19;
        private Label label20;
        private Label label23;
        private Label label24;
        private Label label18;
        private Label label17;
        private Label label10;
        private Label label9;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TabControl tabControl1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBox19;
        private CheckBox checkBox18;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lblPort;
        private TextBox txtIPAdress;
        private Label lblAdress;
        private TextBox txtPort;
        private PictureBox pictureBox3;
    }
}

