
namespace Student_Management_System_By_Mehboob
{
    partial class ProductKey
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
            this.txtregister = new System.Windows.Forms.TextBox();
            this.btregister = new System.Windows.Forms.Button();
            this.erpkey = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Product Key";
            // 
            // txtregister
            // 
            this.txtregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregister.Location = new System.Drawing.Point(31, 88);
            this.txtregister.Name = "txtregister";
            this.txtregister.Size = new System.Drawing.Size(223, 24);
            this.txtregister.TabIndex = 1;
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.Location = new System.Drawing.Point(89, 164);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(98, 41);
            this.btregister.TabIndex = 2;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // erpkey
            // 
            this.erpkey.BackColor = System.Drawing.Color.Transparent;
            this.erpkey.Image = global::Student_Management_System_By_Mehboob.Properties.Resources.rsz_1rsz_clipart7178;
            this.erpkey.Location = new System.Drawing.Point(260, 95);
            this.erpkey.Name = "erpkey";
            this.erpkey.Size = new System.Drawing.Size(16, 13);
            this.erpkey.TabIndex = 3;
            this.erpkey.Visible = false;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(70, 127);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(140, 18);
            this.lblinfo.TabIndex = 4;
            this.lblinfo.Text = "Product Key Error !!!";
            this.lblinfo.Visible = false;
            // 
            // ProductKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.erpkey);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.txtregister);
            this.Controls.Add(this.label1);
            this.Name = "ProductKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductKey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductKey_FormClosing);
            this.Load += new System.EventHandler(this.ProductKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtregister;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Label erpkey;
        private System.Windows.Forms.Label lblinfo;
    }
}