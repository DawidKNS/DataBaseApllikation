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
            this.Welcome_txtU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_txtU
            // 
            this.Welcome_txtU.AutoSize = true;
            this.Welcome_txtU.Location = new System.Drawing.Point(305, 22);
            this.Welcome_txtU.Name = "Welcome_txtU";
            this.Welcome_txtU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Welcome_txtU.Size = new System.Drawing.Size(101, 25);
            this.Welcome_txtU.TabIndex = 0;
            this.Welcome_txtU.Text = "Welcome!";
            // 
            // User_Window
            // 
            this.ClientSize = new System.Drawing.Size(751, 546);
            this.Controls.Add(this.Welcome_txtU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "User_Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataBaseExplorer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_txtU;
    }
}