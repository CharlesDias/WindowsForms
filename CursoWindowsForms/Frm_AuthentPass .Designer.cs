namespace CursoWindowsForms
{
    partial class Frm_AuthentPass
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
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(12, 45);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(218, 20);
            this.Txt_Password.TabIndex = 0;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(12, 90);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(0, 22);
            this.Lbl_Result.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(245, 42);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Clean";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.Location = new System.Drawing.Point(245, 71);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(111, 23);
            this.Btn_ShowPassword.TabIndex = 3;
            this.Btn_ShowPassword.Text = "Show Password";
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.Click += new System.EventHandler(this.Btn_ShowPassword_Click);
            // 
            // Frm_AuthentPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Txt_Password);
            this.Name = "Frm_AuthentPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authenticate Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_ShowPassword;
    }
}