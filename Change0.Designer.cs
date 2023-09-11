namespace WindowsFormsApp3
{
    partial class Change0
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.btnCnfm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNPass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(120, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Edit Your Infos";
            // 
            // txtNPass
            // 
            this.txtNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNPass.Location = new System.Drawing.Point(160, 187);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.PasswordChar = '•';
            this.txtNPass.Size = new System.Drawing.Size(150, 24);
            this.txtNPass.TabIndex = 30;
            // 
            // btnCnfm
            // 
            this.btnCnfm.Location = new System.Drawing.Point(110, 332);
            this.btnCnfm.Name = "btnCnfm";
            this.btnCnfm.Size = new System.Drawing.Size(133, 37);
            this.btnCnfm.TabIndex = 26;
            this.btnCnfm.Text = "Confirm";
            this.btnCnfm.UseVisualStyleBackColor = true;
            this.btnCnfm.Click += new System.EventHandler(this.btnCnfm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(140, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "*Password:";
            // 
            // txtNPass1
            // 
            this.txtNPass1.BackColor = System.Drawing.Color.White;
            this.txtNPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNPass1.Location = new System.Drawing.Point(160, 233);
            this.txtNPass1.Name = "txtNPass1";
            this.txtNPass1.PasswordChar = '•';
            this.txtNPass1.Size = new System.Drawing.Size(150, 24);
            this.txtNPass1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPass.Location = new System.Drawing.Point(160, 142);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '•';
            this.txtOldPass.Size = new System.Drawing.Size(150, 24);
            this.txtOldPass.TabIndex = 40;
            // 
            // Change0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(355, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPass1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNPass);
            this.Controls.Add(this.btnCnfm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.Button btnCnfm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNPass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPass;
    }
}