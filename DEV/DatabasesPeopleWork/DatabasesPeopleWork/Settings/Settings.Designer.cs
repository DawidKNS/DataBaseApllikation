namespace DatabasesPeopleWork.Settings
{
    partial class Settings_Name
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
            this.ConnectionStringDB_txt = new System.Windows.Forms.Label();
            this.TextBox_ConnectionStringDB = new System.Windows.Forms.TextBox();
            this.Button_UpdateConnectionStringDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionStringDB_txt
            // 
            this.ConnectionStringDB_txt.AutoSize = true;
            this.ConnectionStringDB_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionStringDB_txt.Location = new System.Drawing.Point(24, 43);
            this.ConnectionStringDB_txt.Name = "ConnectionStringDB_txt";
            this.ConnectionStringDB_txt.Size = new System.Drawing.Size(336, 25);
            this.ConnectionStringDB_txt.TabIndex = 0;
            this.ConnectionStringDB_txt.Text = "ConnectionString to databases";
            // 
            // TextBox_ConnectionStringDB
            // 
            this.TextBox_ConnectionStringDB.Location = new System.Drawing.Point(382, 47);
            this.TextBox_ConnectionStringDB.Name = "TextBox_ConnectionStringDB";
            this.TextBox_ConnectionStringDB.Size = new System.Drawing.Size(313, 20);
            this.TextBox_ConnectionStringDB.TabIndex = 1;
            // 
            // Button_UpdateConnectionStringDB
            // 
            this.Button_UpdateConnectionStringDB.Location = new System.Drawing.Point(726, 47);
            this.Button_UpdateConnectionStringDB.Name = "Button_UpdateConnectionStringDB";
            this.Button_UpdateConnectionStringDB.Size = new System.Drawing.Size(97, 23);
            this.Button_UpdateConnectionStringDB.TabIndex = 2;
            this.Button_UpdateConnectionStringDB.Text = "Update";
            this.Button_UpdateConnectionStringDB.UseVisualStyleBackColor = true;
            // 
            // Settings_Name
            // 
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.Button_UpdateConnectionStringDB);
            this.Controls.Add(this.TextBox_ConnectionStringDB);
            this.Controls.Add(this.ConnectionStringDB_txt);
            this.Name = "Settings_Name";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_Name_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectionStringDB_txt;
        private System.Windows.Forms.TextBox TextBox_ConnectionStringDB;
        private System.Windows.Forms.Button Button_UpdateConnectionStringDB;
    }
}