namespace JTIFinance.GUI
{
    partial class HeaderTest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::JTIFinance.Properties.Resources.wallpaper_800x600_1336;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JTIFinance.Properties.Resources.wallpaper_800x600_1336;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 388);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(204, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 188);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(160, 159);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "tabPage1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(160, 159);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "tabPage2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // HeaderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JTIFinance.Properties.Resources.wallpaper_800x600_1336;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HeaderTest";
            this.Text = "HeaderTest";
            this.Load += new System.EventHandler(this.HeaderTest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;




    }
}