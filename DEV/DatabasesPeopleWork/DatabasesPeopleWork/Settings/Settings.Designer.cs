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
            this.buttonUP_DatabaseName = new System.Windows.Forms.Button();
            this.DatabaseName_Text = new System.Windows.Forms.Label();
            this.textBox_DatabaseName = new System.Windows.Forms.TextBox();
            this.button_UpdateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionStringDB_txt
            // 
            this.ConnectionStringDB_txt.AutoSize = true;
            this.ConnectionStringDB_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionStringDB_txt.Location = new System.Drawing.Point(24, 43);
            this.ConnectionStringDB_txt.Name = "ConnectionStringDB_txt";
            this.ConnectionStringDB_txt.Size = new System.Drawing.Size(324, 25);
            this.ConnectionStringDB_txt.TabIndex = 0;
            this.ConnectionStringDB_txt.Text = "ConnectionString to database";
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
            this.Button_UpdateConnectionStringDB.Click += new System.EventHandler(this.Button_UpdateConnectionStringDB_Click);
            // 
            // buttonUP_DatabaseName
            // 
            this.buttonUP_DatabaseName.Location = new System.Drawing.Point(726, 107);
            this.buttonUP_DatabaseName.Name = "buttonUP_DatabaseName";
            this.buttonUP_DatabaseName.Size = new System.Drawing.Size(97, 23);
            this.buttonUP_DatabaseName.TabIndex = 3;
            this.buttonUP_DatabaseName.Text = "Update";
            this.buttonUP_DatabaseName.UseVisualStyleBackColor = true;
            this.buttonUP_DatabaseName.Click += new System.EventHandler(this.buttonUP_DatabaseName_Click);
            // 
            // DatabaseName_Text
            // 
            this.DatabaseName_Text.AutoSize = true;
            this.DatabaseName_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseName_Text.Location = new System.Drawing.Point(24, 101);
            this.DatabaseName_Text.Name = "DatabaseName_Text";
            this.DatabaseName_Text.Size = new System.Drawing.Size(179, 25);
            this.DatabaseName_Text.TabIndex = 4;
            this.DatabaseName_Text.Text = "Database Name";
            this.DatabaseName_Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_DatabaseName
            // 
            this.textBox_DatabaseName.Location = new System.Drawing.Point(382, 107);
            this.textBox_DatabaseName.Name = "textBox_DatabaseName";
            this.textBox_DatabaseName.Size = new System.Drawing.Size(313, 20);
            this.textBox_DatabaseName.TabIndex = 5;
            // 
            // button_UpdateAll
            // 
            this.button_UpdateAll.Location = new System.Drawing.Point(726, 414);
            this.button_UpdateAll.Name = "button_UpdateAll";
            this.button_UpdateAll.Size = new System.Drawing.Size(127, 31);
            this.button_UpdateAll.TabIndex = 6;
            this.button_UpdateAll.Text = "Update ALL";
            this.button_UpdateAll.UseVisualStyleBackColor = true;
            this.button_UpdateAll.Click += new System.EventHandler(this.button_UpdateAll_Click);
            // 
            // Settings_Name
            // 
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.button_UpdateAll);
            this.Controls.Add(this.textBox_DatabaseName);
            this.Controls.Add(this.DatabaseName_Text);
            this.Controls.Add(this.buttonUP_DatabaseName);
            this.Controls.Add(this.Button_UpdateConnectionStringDB);
            this.Controls.Add(this.TextBox_ConnectionStringDB);
            this.Controls.Add(this.ConnectionStringDB_txt);
            this.Name = "Settings_Name";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_Name_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectionStringDB_txt;
        private System.Windows.Forms.TextBox TextBox_ConnectionStringDB;
        private System.Windows.Forms.Button Button_UpdateConnectionStringDB;
        private System.Windows.Forms.Button buttonUP_DatabaseName;
        private System.Windows.Forms.Label DatabaseName_Text;
        private System.Windows.Forms.TextBox textBox_DatabaseName;
        private System.Windows.Forms.Button button_UpdateAll;
    }
}