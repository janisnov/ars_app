
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("стойки");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("основы маскировки");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("органы управления");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("способы удержания");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("работа с оружием", new System.Windows.Forms.TreeNode[] {
            treeNode303,
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("Индивидуальная подготовка", new System.Windows.Forms.TreeNode[] {
            treeNode301,
            treeNode302,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Построение");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("комуникация");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("командная работа", new System.Windows.Forms.TreeNode[] {
            treeNode307,
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Baofeng uv-5r");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("рации", new System.Windows.Forms.TreeNode[] {
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("гарнитура");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("комуникация", new System.Windows.Forms.TreeNode[] {
            treeNode311,
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("магазинные");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("под рацию");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("административные");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("утилитарные(сухарки)");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("гранатные");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("подсумки", new System.Windows.Forms.TreeNode[] {
            treeNode314,
            treeNode315,
            treeNode316,
            treeNode317,
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Шлем");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("бронежилет/platecarrier");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Разгрузки");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Варбелт");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("снаряжение", new System.Windows.Forms.TreeNode[] {
            treeNode313,
            treeNode319,
            treeNode320,
            treeNode321,
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Тех. составляющая");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1208, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Теория";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(198, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1004, 582);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 6);
            this.treeView1.Name = "treeView1";
            treeNode301.Name = "pos";
            treeNode301.Text = "стойки";
            treeNode302.Name = "bsc_dsg";
            treeNode302.Text = "основы маскировки";
            treeNode303.Name = "mgnt_bds";
            treeNode303.Text = "органы управления";
            treeNode304.Name = "vrt_hld";
            treeNode304.Text = "способы удержания";
            treeNode305.Name = "oper_frarm";
            treeNode305.Text = "работа с оружием";
            treeNode306.Name = "ind_trn";
            treeNode306.Text = "Индивидуальная подготовка";
            treeNode307.Name = "frmt";
            treeNode307.Text = "Построение";
            treeNode308.Name = "com";
            treeNode308.Text = "комуникация";
            treeNode309.Name = "cmd_wrk";
            treeNode309.Text = "командная работа";
            treeNode310.Name = "uv-5r";
            treeNode310.Text = "Baofeng uv-5r";
            treeNode311.Name = "wt";
            treeNode311.Text = "рации";
            treeNode312.Name = "headst";
            treeNode312.Text = "гарнитура";
            treeNode313.Name = "gear_com";
            treeNode313.Text = "комуникация";
            treeNode314.Name = "pchs_mg";
            treeNode314.Text = "магазинные";
            treeNode315.Name = "pchs_wt";
            treeNode315.Text = "под рацию";
            treeNode316.Name = "pchs_adm";
            treeNode316.Text = "административные";
            treeNode317.Name = "pchs_ut";
            treeNode317.Text = "утилитарные(сухарки)";
            treeNode318.Name = "pchs_gr";
            treeNode318.Text = "гранатные";
            treeNode319.Name = "pchs";
            treeNode319.Text = "подсумки";
            treeNode320.Name = "hlmt";
            treeNode320.Text = "Шлем";
            treeNode321.Name = "pltcar";
            treeNode321.Text = "бронежилет/platecarrier";
            treeNode322.Name = "chst_rig";
            treeNode322.Text = "Разгрузки";
            treeNode323.Name = "wr_blt";
            treeNode323.Text = "Варбелт";
            treeNode324.Name = "gear";
            treeNode324.Text = "снаряжение";
            treeNode325.Name = "tech_asp";
            treeNode325.Text = "Тех. составляющая";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode306,
            treeNode309,
            treeNode324,
            treeNode325});
            this.treeView1.Size = new System.Drawing.Size(189, 582);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "НАТО -> предложения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1208, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "предложения  -> НАТО";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "генерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 551);
            this.label2.TabIndex = 3;
            this.label2.Text = "сгенерированый текст";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "количество слов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(604, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "вводите буквы";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(101, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "закончить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

