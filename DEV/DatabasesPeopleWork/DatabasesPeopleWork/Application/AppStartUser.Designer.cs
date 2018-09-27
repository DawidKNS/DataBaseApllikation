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
            this.BT_GoToDB = new System.Windows.Forms.Button();
            this.BT_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hallo_txt
            // 
            this.Hallo_txt.AutoSize = true;
            this.Hallo_txt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hallo_txt.Location = new System.Drawing.Point(33, 18);
            this.Hallo_txt.Name = "Hallo_txt";
            this.Hallo_txt.Size = new System.Drawing.Size(0, 25);
            this.Hallo_txt.TabIndex = 0;
            // 
            // Data_txt
            // 
            this.Data_txt.AutoSize = true;
            this.Data_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Data_txt.Location = new System.Drawing.Point(253, 19);
            this.Data_txt.Name = "Data_txt";
            this.Data_txt.Size = new System.Drawing.Size(0, 24);
            this.Data_txt.TabIndex = 1;
            // 
            // BT_GoToDB
            // 
            this.BT_GoToDB.Location = new System.Drawing.Point(175, 96);
            this.BT_GoToDB.Name = "BT_GoToDB";
            this.BT_GoToDB.Size = new System.Drawing.Size(158, 35);
            this.BT_GoToDB.TabIndex = 2;
            this.BT_GoToDB.Text = "Go to Databases";
            this.BT_GoToDB.UseVisualStyleBackColor = true;
            this.BT_GoToDB.Click += new System.EventHandler(this.BT_GoToDB_Click);
            // 
            // BT_AddUser
            // 
            this.BT_AddUser.Location = new System.Drawing.Point(175, 159);
            this.BT_AddUser.Name = "BT_AddUser";
            this.BT_AddUser.Size = new System.Drawing.Size(158, 35);
            this.BT_AddUser.TabIndex = 3;
            this.BT_AddUser.Text = "Add Users";
            this.BT_AddUser.UseVisualStyleBackColor = true;
            this.BT_AddUser.Visible = false;
            this.BT_AddUser.Click += new System.EventHandler(this.BT_AddUser_Click);
            // 
            // User_Window
            // 
            this.ClientSize = new System.Drawing.Size(488, 266);
            this.Controls.Add(this.BT_AddUser);
            this.Controls.Add(this.BT_GoToDB);
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
        private System.Windows.Forms.Button BT_GoToDB;
        private System.Windows.Forms.Button BT_AddUser;
    }
}