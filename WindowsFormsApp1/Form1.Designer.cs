
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("стойки");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("основы маскировки");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("органы управления");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("способы удержания");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("работа с оружием", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Индивидуальная подготовка", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("построения");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("комуникация");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Командная подготовка", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Baofeng uv-5r");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Рации", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("гарнитура");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("комуникация", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("магазинные");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("под рацию");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("административные");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("утилитарные(сухарки)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("гранатные");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("подсумки", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Шлем");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("бронежилет/platecarrier");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Разгрузки");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Варбелт");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Снаряжение", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Тех. составляющая");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 620);
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
            treeNode1.Name = "ind_pos";
            treeNode1.Text = "стойки";
            treeNode2.Name = "Node6";
            treeNode2.Text = "основы маскировки";
            treeNode3.Name = "Node23";
            treeNode3.Text = "органы управления";
            treeNode4.Name = "Node22";
            treeNode4.Text = "способы удержания";
            treeNode5.Name = "Node21";
            treeNode5.Text = "работа с оружием";
            treeNode6.Name = "ind_exs";
            treeNode6.Text = "Индивидуальная подготовка";
            treeNode7.Name = "Node7";
            treeNode7.Text = "построения";
            treeNode8.Name = "Node8";
            treeNode8.Text = "комуникация";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Командная подготовка";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Baofeng uv-5r";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Рации";
            treeNode12.Name = "Node10";
            treeNode12.Text = "гарнитура";
            treeNode13.Name = "Node9";
            treeNode13.Text = "комуникация";
            treeNode14.Name = "Node12";
            treeNode14.Text = "магазинные";
            treeNode15.Name = "Node13";
            treeNode15.Text = "под рацию";
            treeNode16.Name = "Node14";
            treeNode16.Text = "административные";
            treeNode17.Name = "Node15";
            treeNode17.Text = "утилитарные(сухарки)";
            treeNode18.Name = "Node16";
            treeNode18.Text = "гранатные";
            treeNode19.Name = "Node11";
            treeNode19.Text = "подсумки";
            treeNode20.Name = "Node17";
            treeNode20.Text = "Шлем";
            treeNode21.Name = "Node18";
            treeNode21.Text = "бронежилет/platecarrier";
            treeNode22.Name = "Node19";
            treeNode22.Text = "Разгрузки";
            treeNode23.Name = "Node20";
            treeNode23.Text = "Варбелт";
            treeNode24.Name = "Node2";
            treeNode24.Text = "Снаряжение";
            treeNode25.Name = "Node24";
            treeNode25.Text = "Тех. составляющая";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode24,
            treeNode25});
            this.treeView1.Size = new System.Drawing.Size(189, 582);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1208, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Практика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

