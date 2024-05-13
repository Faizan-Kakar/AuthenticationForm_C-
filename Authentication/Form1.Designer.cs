namespace Authentication
{
    partial class create
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(202, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(320, 20);
            this.email.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(202, 262);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(320, 20);
            this.password.TabIndex = 6;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(202, 318);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(320, 20);
            this.confirmPassword.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(202, 121);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(320, 20);
            this.lastName.TabIndex = 8;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(202, 62);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(320, 20);
            this.firstName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(235, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(229, 36);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Location = new System.Drawing.Point(381, 415);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(37, 13);
            this.loginLink.TabIndex = 11;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Already have an accout?";
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "create";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label6;
    }
}

