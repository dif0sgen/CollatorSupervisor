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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblStat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            Speed = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.tabPage1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Name = "tabPage1";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.checkBox15);
            this.flowLayoutPanel2.Controls.Add(this.checkBox19);
            this.flowLayoutPanel2.Controls.Add(this.checkBox18);
            this.flowLayoutPanel2.Controls.Add(this.checkBox17);
            this.flowLayoutPanel2.Controls.Add(this.checkBox16);
            this.flowLayoutPanel2.Controls.Add(this.checkBox14);
            this.flowLayoutPanel2.Controls.Add(this.checkBox13);
            this.flowLayoutPanel2.Controls.Add(this.checkBox5);
            this.flowLayoutPanel2.Controls.Add(this.checkBox4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // checkBox15
            // 
            resources.ApplyResources(this.checkBox15, "checkBox15");
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.label36, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label35, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label34, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label33, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label30, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.label16, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.label15, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.textBox17, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox16, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox13, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox10, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox8, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.textBox23, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox22, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox21, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox20, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox19, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox18, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // textBox23
            // 
            resources.ApplyResources(this.textBox23, "textBox23");
            this.textBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.textBox14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox12, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox11, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Name = "textBox14";
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Name = "textBox12";
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Name = "textBox11";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
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
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnStart, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblStat, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.pictureBox2, 3, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
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
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Form_Listener
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Listener";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private TextBox textBox12;
        private TextBox textBox14;
        private TextBox textBox11;
        private TextBox textBox6;
        private Button button4;
        private TabControl tabControl1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lblPort;
        private TextBox txtIPAdress;
        private Label lblAdress;
        private TextBox txtPort;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label15;
        private Label label16;
        private Label label26;
        private Label label30;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox10;
        private TextBox textBox13;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBox15;
        private CheckBox checkBox19;
        private CheckBox checkBox18;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}

