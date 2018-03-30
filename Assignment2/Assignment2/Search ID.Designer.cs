namespace Assignment2
{
    partial class Search_ID
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
            this.idSearchTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idSearchTxtBox
            // 
            this.idSearchTxtBox.Location = new System.Drawing.Point(71, 47);
            this.idSearchTxtBox.Name = "idSearchTxtBox";
            this.idSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idSearchTxtBox.TabIndex = 0;
            // 
            // Search_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 324);
            this.Controls.Add(this.idSearchTxtBox);
            this.Name = "Search_ID";
            this.Text = "Search_ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idSearchTxtBox;
    }
}