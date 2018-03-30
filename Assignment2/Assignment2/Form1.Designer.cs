namespace Assignment2
{
    partial class MenuForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cGPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchIdBtn = new System.Windows.Forms.Button();
            this.searchNameBtn = new System.Windows.Forms.Button();
            this.searchSemBtn = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(665, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.markToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.markToolStripMenuItem.Text = "Mark";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cGPAToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortToolStripMenuItem.Text = "Sort by";
            // 
            // cGPAToolStripMenuItem
            // 
            this.cGPAToolStripMenuItem.Name = "cGPAToolStripMenuItem";
            this.cGPAToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cGPAToolStripMenuItem.Text = "CGPA";
            this.cGPAToolStripMenuItem.Click += new System.EventHandler(this.cGPAToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(373, 175);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(118, 43);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display All";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchIdBtn
            // 
            this.searchIdBtn.Location = new System.Drawing.Point(106, 157);
            this.searchIdBtn.Name = "searchIdBtn";
            this.searchIdBtn.Size = new System.Drawing.Size(75, 23);
            this.searchIdBtn.TabIndex = 2;
            this.searchIdBtn.Text = "ID";
            this.searchIdBtn.UseVisualStyleBackColor = true;
            this.searchIdBtn.Click += new System.EventHandler(this.searchIdBtn_Click);
            // 
            // searchNameBtn
            // 
            this.searchNameBtn.Location = new System.Drawing.Point(106, 195);
            this.searchNameBtn.Name = "searchNameBtn";
            this.searchNameBtn.Size = new System.Drawing.Size(75, 23);
            this.searchNameBtn.TabIndex = 3;
            this.searchNameBtn.Text = "Name";
            this.searchNameBtn.UseVisualStyleBackColor = true;
            this.searchNameBtn.Click += new System.EventHandler(this.searchNameBtn_Click);
            // 
            // searchSemBtn
            // 
            this.searchSemBtn.Location = new System.Drawing.Point(106, 234);
            this.searchSemBtn.Name = "searchSemBtn";
            this.searchSemBtn.Size = new System.Drawing.Size(75, 23);
            this.searchSemBtn.TabIndex = 4;
            this.searchSemBtn.Text = "Semester";
            this.searchSemBtn.UseVisualStyleBackColor = true;
            this.searchSemBtn.Click += new System.EventHandler(this.searchSemBtn_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Location = new System.Drawing.Point(73, 121);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(140, 167);
            this.searchGroupBox.TabIndex = 5;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 372);
            this.Controls.Add(this.searchSemBtn);
            this.Controls.Add(this.searchNameBtn);
            this.Controls.Add(this.searchIdBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.searchGroupBox);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuForm";
            this.Text = "Menu";
      
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cGPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button searchIdBtn;
        private System.Windows.Forms.Button searchNameBtn;
        private System.Windows.Forms.Button searchSemBtn;
        private System.Windows.Forms.GroupBox searchGroupBox;

    }
}

