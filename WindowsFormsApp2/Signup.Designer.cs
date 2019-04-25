namespace WindowsFormsApp2
{
    partial class Signup
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
            this.btnsign_cancel = new System.Windows.Forms.Button();
            this.lblsign_password = new System.Windows.Forms.Label();
            this.lblsign_username = new System.Windows.Forms.Label();
            this.txtsign_password = new System.Windows.Forms.TextBox();
            this.txtsign_username = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txtsign_password2 = new System.Windows.Forms.TextBox();
            this.lblsign_password2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsign_cancel
            // 
            this.btnsign_cancel.Location = new System.Drawing.Point(156, 216);
            this.btnsign_cancel.Name = "btnsign_cancel";
            this.btnsign_cancel.Size = new System.Drawing.Size(75, 23);
            this.btnsign_cancel.TabIndex = 11;
            this.btnsign_cancel.Text = "Cancel";
            this.btnsign_cancel.UseVisualStyleBackColor = true;
            this.btnsign_cancel.Click += new System.EventHandler(this.btnsign_cancel_Click);
            // 
            // lblsign_password
            // 
            this.lblsign_password.AutoSize = true;
            this.lblsign_password.Location = new System.Drawing.Point(57, 111);
            this.lblsign_password.Name = "lblsign_password";
            this.lblsign_password.Size = new System.Drawing.Size(53, 13);
            this.lblsign_password.TabIndex = 10;
            this.lblsign_password.Text = "Password";
            // 
            // lblsign_username
            // 
            this.lblsign_username.AutoSize = true;
            this.lblsign_username.Location = new System.Drawing.Point(57, 55);
            this.lblsign_username.Name = "lblsign_username";
            this.lblsign_username.Size = new System.Drawing.Size(55, 13);
            this.lblsign_username.TabIndex = 9;
            this.lblsign_username.Text = "Username";
            // 
            // txtsign_password
            // 
            this.txtsign_password.Location = new System.Drawing.Point(156, 104);
            this.txtsign_password.Name = "txtsign_password";
            this.txtsign_password.Size = new System.Drawing.Size(202, 20);
            this.txtsign_password.TabIndex = 8;
            this.txtsign_password.TextChanged += new System.EventHandler(this.txtsign_password_TextChanged);
            // 
            // txtsign_username
            // 
            this.txtsign_username.Location = new System.Drawing.Point(156, 55);
            this.txtsign_username.Name = "txtsign_username";
            this.txtsign_username.Size = new System.Drawing.Size(202, 20);
            this.txtsign_username.TabIndex = 7;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(283, 216);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txtsign_password2
            // 
            this.txtsign_password2.Location = new System.Drawing.Point(156, 158);
            this.txtsign_password2.Name = "txtsign_password2";
            this.txtsign_password2.Size = new System.Drawing.Size(202, 20);
            this.txtsign_password2.TabIndex = 12;
            this.txtsign_password2.TextChanged += new System.EventHandler(this.txtsign_password2_TextChanged);
            // 
            // lblsign_password2
            // 
            this.lblsign_password2.AutoSize = true;
            this.lblsign_password2.Location = new System.Drawing.Point(57, 161);
            this.lblsign_password2.Name = "lblsign_password2";
            this.lblsign_password2.Size = new System.Drawing.Size(91, 13);
            this.lblsign_password2.TabIndex = 13;
            this.lblsign_password2.Text = "Confirm Password";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.lblsign_password2);
            this.Controls.Add(this.txtsign_password2);
            this.Controls.Add(this.btnsign_cancel);
            this.Controls.Add(this.lblsign_password);
            this.Controls.Add(this.lblsign_username);
            this.Controls.Add(this.txtsign_password);
            this.Controls.Add(this.txtsign_username);
            this.Controls.Add(this.btn_signup);
            this.Name = "Signup";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsign_cancel;
        private System.Windows.Forms.Label lblsign_password;
        private System.Windows.Forms.Label lblsign_username;
        private System.Windows.Forms.TextBox txtsign_password;
        private System.Windows.Forms.TextBox txtsign_username;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txtsign_password2;
        private System.Windows.Forms.Label lblsign_password2;
    }
}