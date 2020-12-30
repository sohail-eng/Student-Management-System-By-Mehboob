
namespace Student_Management_System_By_Mehboob
{
    partial class Form1
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
            this.boxname = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.erorname = new System.Windows.Forms.Label();
            this.errorpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // boxname
            // 
            this.boxname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxname.FormattingEnabled = true;
            this.boxname.Location = new System.Drawing.Point(220, 71);
            this.boxname.Name = "boxname";
            this.boxname.Size = new System.Drawing.Size(182, 33);
            this.boxname.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(220, 113);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(182, 30);
            this.txtpass.TabIndex = 6;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(232, 167);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(126, 44);
            this.login.TabIndex = 7;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(12, 231);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(126, 44);
            this.signup.TabIndex = 8;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Forget Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erorname
            // 
            this.erorname.Image = global::Student_Management_System_By_Mehboob.Properties.Resources.rsz_1rsz_clipart7178;
            this.erorname.Location = new System.Drawing.Point(408, 74);
            this.erorname.Name = "erorname";
            this.erorname.Size = new System.Drawing.Size(36, 29);
            this.erorname.TabIndex = 10;
            this.erorname.Visible = false;
            // 
            // errorpass
            // 
            this.errorpass.Image = global::Student_Management_System_By_Mehboob.Properties.Resources.rsz_1rsz_clipart7178;
            this.errorpass.Location = new System.Drawing.Point(408, 113);
            this.errorpass.Name = "errorpass";
            this.errorpass.Size = new System.Drawing.Size(36, 29);
            this.errorpass.TabIndex = 11;
            this.errorpass.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(540, 287);
            this.Controls.Add(this.errorpass);
            this.Controls.Add(this.erorname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.boxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(556, 326);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label erorname;
        private System.Windows.Forms.Label errorpass;
    }
}

