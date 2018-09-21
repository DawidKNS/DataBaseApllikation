namespace DatabasesPeopleWork.DataBases
{
    partial class User_Window
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
            this.Hallo_txt = new System.Windows.Forms.Label();
            this.Data_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hallo_txt
            // 
            this.Hallo_txt.AutoSize = true;
            this.Hallo_txt.Location = new System.Drawing.Point(531, 18);
            this.Hallo_txt.Name = "Hallo_txt";
            this.Hallo_txt.Size = new System.Drawing.Size(35, 13);
            this.Hallo_txt.TabIndex = 0;
            this.Hallo_txt.Text = "label1";
            // 
            // Data_txt
            // 
            this.Data_txt.AutoSize = true;
            this.Data_txt.Location = new System.Drawing.Point(612, 18);
            this.Data_txt.Name = "Data_txt";
            this.Data_txt.Size = new System.Drawing.Size(0, 13);
            this.Data_txt.TabIndex = 1;
            // 
            // User_Window
            // 
            this.ClientSize = new System.Drawing.Size(689, 466);
            this.Controls.Add(this.Data_txt);
            this.Controls.Add(this.Hallo_txt);
            this.Name = "User_Window";
            this.Text = "DatabasesPepolWork - User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataBaseExplorer_FormClosed);
            this.Load += new System.EventHandler(this.User_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hallo_txt;
        private System.Windows.Forms.Label Data_txt;
    }
}