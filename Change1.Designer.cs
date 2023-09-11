namespace WindowsFormsApp3
{
    partial class Change1
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.txtNLname = new System.Windows.Forms.TextBox();
            this.txtNFname = new System.Windows.Forms.TextBox();
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.btnCnfm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNPass1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(139, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "New Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "New Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "New First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(119, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Edit Your Infos";
            // 
            // txtNPass
            // 
            this.txtNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNPass.Location = new System.Drawing.Point(158, 241);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.PasswordChar = '•';
            this.txtNPass.Size = new System.Drawing.Size(150, 24);
            this.txtNPass.TabIndex = 42;
            // 
            // txtNLname
            // 
            this.txtNLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNLname.Location = new System.Drawing.Point(158, 201);
            this.txtNLname.Name = "txtNLname";
            this.txtNLname.Size = new System.Drawing.Size(150, 24);
            this.txtNLname.TabIndex = 41;
            // 
            // txtNFname
            // 
            this.txtNFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNFname.Location = new System.Drawing.Point(158, 158);
            this.txtNFname.Name = "txtNFname";
            this.txtNFname.Size = new System.Drawing.Size(150, 24);
            this.txtNFname.TabIndex = 40;
            // 
            // txtNUser
            // 
            this.txtNUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNUser.Location = new System.Drawing.Point(158, 113);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(150, 24);
            this.txtNUser.TabIndex = 39;
            // 
            // btnCnfm
            // 
            this.btnCnfm.Location = new System.Drawing.Point(109, 332);
            this.btnCnfm.Name = "btnCnfm";
            this.btnCnfm.Size = new System.Drawing.Size(133, 37);
            this.btnCnfm.TabIndex = 38;
            this.btnCnfm.Text = "Confirm";
            this.btnCnfm.UseVisualStyleBackColor = true;
            this.btnCnfm.Click += new System.EventHandler(this.btnCnfm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "*Password:";
            // 
            // txtNPass1
            // 
            this.txtNPass1.BackColor = System.Drawing.Color.White;
            this.txtNPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNPass1.Location = new System.Drawing.Point(158, 281);
            this.txtNPass1.Name = "txtNPass1";
            this.txtNPass1.PasswordChar = '•';
            this.txtNPass1.Size = new System.Drawing.Size(150, 24);
            this.txtNPass1.TabIndex = 49;
            // 
            // Change1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(355, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPass1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNPass);
            this.Controls.Add(this.txtNLname);
            this.Controls.Add(this.txtNFname);
            this.Controls.Add(this.txtNUser);
            this.Controls.Add(this.btnCnfm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.TextBox txtNLname;
        private System.Windows.Forms.TextBox txtNFname;
        private System.Windows.Forms.TextBox txtNUser;
        private System.Windows.Forms.Button btnCnfm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNPass1;
    }
}