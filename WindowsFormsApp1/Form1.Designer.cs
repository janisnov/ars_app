
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
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("стойки");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("основы маскировки");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("органы управления");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("способы удержания");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("работа с оружием", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode104});
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Индивидуальная подготовка", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Построение");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("комуникация");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("командная работа", new System.Windows.Forms.TreeNode[] {
            treeNode107,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Baofeng uv-5r");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("рации", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("гарнитура");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("комуникация", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("магазинные");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("под рацию");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("административные");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("утилитарные(сухарки)");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("гранатные");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("подсумки", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Шлем");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("бронежилет/platecarrier");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Разгрузки");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Варбелт");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("снаряжение", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode119,
            treeNode120,
            treeNode121,
            treeNode122,
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Тех. составляющая");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabPage1.Size = new System.Drawing.Size(1232, 631);
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
            treeNode101.Name = "pos";
            treeNode101.Text = "стойки";
            treeNode102.Name = "bsc_dsg";
            treeNode102.Text = "основы маскировки";
            treeNode103.Name = "mgnt_bds";
            treeNode103.Text = "органы управления";
            treeNode104.Name = "vrt_hld";
            treeNode104.Text = "способы удержания";
            treeNode105.Name = "oper_frarm";
            treeNode105.Text = "работа с оружием";
            treeNode106.Name = "ind_trn";
            treeNode106.Text = "Индивидуальная подготовка";
            treeNode107.Name = "frmt";
            treeNode107.Text = "Построение";
            treeNode108.Name = "com";
            treeNode108.Text = "комуникация";
            treeNode109.Name = "cmd_wrk";
            treeNode109.Text = "командная работа";
            treeNode110.Name = "uv-5r";
            treeNode110.Text = "Baofeng uv-5r";
            treeNode111.Name = "wt";
            treeNode111.Text = "рации";
            treeNode112.Name = "headst";
            treeNode112.Text = "гарнитура";
            treeNode113.Name = "gear_com";
            treeNode113.Text = "комуникация";
            treeNode114.Name = "pchs_mg";
            treeNode114.Text = "магазинные";
            treeNode115.Name = "pchs_wt";
            treeNode115.Text = "под рацию";
            treeNode116.Name = "pchs_adm";
            treeNode116.Text = "административные";
            treeNode117.Name = "pchs_ut";
            treeNode117.Text = "утилитарные(сухарки)";
            treeNode118.Name = "pchs_gr";
            treeNode118.Text = "гранатные";
            treeNode119.Name = "pchs";
            treeNode119.Text = "подсумки";
            treeNode120.Name = "hlmt";
            treeNode120.Text = "Шлем";
            treeNode121.Name = "pltcar";
            treeNode121.Text = "бронежилет/platecarrier";
            treeNode122.Name = "chst_rig";
            treeNode122.Text = "Разгрузки";
            treeNode123.Name = "wr_blt";
            treeNode123.Text = "Варбелт";
            treeNode124.Name = "gear";
            treeNode124.Text = "снаряжение";
            treeNode125.Name = "tech_asp";
            treeNode125.Text = "Тех. составляющая";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode109,
            treeNode124,
            treeNode125});
            this.treeView1.Size = new System.Drawing.Size(189, 582);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ответ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "количество слов";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 551);
            this.label2.TabIndex = 3;
            this.label2.Text = "сгенерированый текст";
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1232, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "предложения  -> НАТО";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(619, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

