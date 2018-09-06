namespace PeopleDatabase
{
    partial class LogIn
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLogIn = new System.Windows.Forms.Label();
            this.UserT = new System.Windows.Forms.Label();
            this.PasswordT = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLogIn
            // 
            this.TitleLogIn.AutoSize = true;
            this.TitleLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLogIn.Location = new System.Drawing.Point(208, 22);
            this.TitleLogIn.Name = "TitleLogIn";
            this.TitleLogIn.Size = new System.Drawing.Size(119, 46);
            this.TitleLogIn.TabIndex = 0;
            this.TitleLogIn.Text = "LogIn";
            this.TitleLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserT
            // 
            this.UserT.AutoSize = true;
            this.UserT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserT.Location = new System.Drawing.Point(110, 106);
            this.UserT.Name = "UserT";
            this.UserT.Size = new System.Drawing.Size(58, 26);
            this.UserT.TabIndex = 1;
            this.UserT.Text = "User";
            // 
            // PasswordT
            // 
            this.PasswordT.AutoSize = true;
            this.PasswordT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordT.Location = new System.Drawing.Point(60, 153);
            this.PasswordT.Name = "PasswordT";
            this.PasswordT.Size = new System.Drawing.Size(108, 26);
            this.PasswordT.TabIndex = 2;
            this.PasswordT.Text = "Password";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(207, 112);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(145, 20);
            this.User.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(207, 159);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 20);
            this.password.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.Location = new System.Drawing.Point(173, 220);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginButton.Size = new System.Drawing.Size(220, 51);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LogIn";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 360);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.PasswordT);
            this.Controls.Add(this.UserT);
            this.Controls.Add(this.TitleLogIn);
            this.Name = "LogIn";
            this.Text = "People Database - LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLogIn;
        private System.Windows.Forms.Label UserT;
        private System.Windows.Forms.Label PasswordT;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button LoginButton;
    }
}

