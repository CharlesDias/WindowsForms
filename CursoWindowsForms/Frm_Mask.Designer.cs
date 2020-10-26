namespace CursoWindowsForms
{
    partial class Frm_Mask
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
            this.Msk_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Content = new System.Windows.Forms.Label();
            this.Lbl_ActiveMask = new System.Windows.Forms.Label();
            this.Btn_Time = new System.Windows.Forms.Button();
            this.Btn_CEP = new System.Windows.Forms.Button();
            this.Btn_Currency = new System.Windows.Forms.Button();
            this.Btn_Phone = new System.Windows.Forms.Button();
            this.Btn_Password = new System.Windows.Forms.Button();
            this.Btn_Date = new System.Windows.Forms.Button();
            this.Btn_ShowContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_TextBox
            // 
            this.Msk_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_TextBox.Location = new System.Drawing.Point(23, 31);
            this.Msk_TextBox.Mask = "00/00/0000";
            this.Msk_TextBox.Name = "Msk_TextBox";
            this.Msk_TextBox.Size = new System.Drawing.Size(258, 26);
            this.Msk_TextBox.TabIndex = 0;
            this.Msk_TextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_Content
            // 
            this.Lbl_Content.AutoSize = true;
            this.Lbl_Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Content.Location = new System.Drawing.Point(23, 246);
            this.Lbl_Content.Name = "Lbl_Content";
            this.Lbl_Content.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Content.TabIndex = 1;
            // 
            // Lbl_ActiveMask
            // 
            this.Lbl_ActiveMask.AutoSize = true;
            this.Lbl_ActiveMask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ActiveMask.Location = new System.Drawing.Point(23, 75);
            this.Lbl_ActiveMask.Name = "Lbl_ActiveMask";
            this.Lbl_ActiveMask.Size = new System.Drawing.Size(0, 19);
            this.Lbl_ActiveMask.TabIndex = 2;
            // 
            // Btn_Time
            // 
            this.Btn_Time.Location = new System.Drawing.Point(23, 110);
            this.Btn_Time.Name = "Btn_Time";
            this.Btn_Time.Size = new System.Drawing.Size(82, 37);
            this.Btn_Time.TabIndex = 3;
            this.Btn_Time.Text = "Time";
            this.Btn_Time.UseVisualStyleBackColor = true;
            this.Btn_Time.Click += new System.EventHandler(this.Btn_Time_Click);
            // 
            // Btn_CEP
            // 
            this.Btn_CEP.Location = new System.Drawing.Point(111, 110);
            this.Btn_CEP.Name = "Btn_CEP";
            this.Btn_CEP.Size = new System.Drawing.Size(82, 37);
            this.Btn_CEP.TabIndex = 4;
            this.Btn_CEP.Text = "CEP";
            this.Btn_CEP.UseVisualStyleBackColor = true;
            this.Btn_CEP.Click += new System.EventHandler(this.Btn_CEP_Click);
            // 
            // Btn_Currency
            // 
            this.Btn_Currency.Location = new System.Drawing.Point(199, 110);
            this.Btn_Currency.Name = "Btn_Currency";
            this.Btn_Currency.Size = new System.Drawing.Size(82, 37);
            this.Btn_Currency.TabIndex = 5;
            this.Btn_Currency.Text = "Currency";
            this.Btn_Currency.UseVisualStyleBackColor = true;
            this.Btn_Currency.Click += new System.EventHandler(this.Btn_Currency_Click);
            // 
            // Btn_Phone
            // 
            this.Btn_Phone.Location = new System.Drawing.Point(199, 153);
            this.Btn_Phone.Name = "Btn_Phone";
            this.Btn_Phone.Size = new System.Drawing.Size(82, 37);
            this.Btn_Phone.TabIndex = 8;
            this.Btn_Phone.Text = "Phone";
            this.Btn_Phone.UseVisualStyleBackColor = true;
            this.Btn_Phone.Click += new System.EventHandler(this.Btn_Phone_Click);
            // 
            // Btn_Password
            // 
            this.Btn_Password.Location = new System.Drawing.Point(111, 153);
            this.Btn_Password.Name = "Btn_Password";
            this.Btn_Password.Size = new System.Drawing.Size(82, 37);
            this.Btn_Password.TabIndex = 7;
            this.Btn_Password.Text = "Password";
            this.Btn_Password.UseVisualStyleBackColor = true;
            this.Btn_Password.Click += new System.EventHandler(this.Btn_Password_Click);
            // 
            // Btn_Date
            // 
            this.Btn_Date.Location = new System.Drawing.Point(23, 153);
            this.Btn_Date.Name = "Btn_Date";
            this.Btn_Date.Size = new System.Drawing.Size(82, 37);
            this.Btn_Date.TabIndex = 6;
            this.Btn_Date.Text = "Date";
            this.Btn_Date.UseVisualStyleBackColor = true;
            this.Btn_Date.Click += new System.EventHandler(this.Btn_Date_Click);
            // 
            // Btn_ShowContent
            // 
            this.Btn_ShowContent.Location = new System.Drawing.Point(23, 196);
            this.Btn_ShowContent.Name = "Btn_ShowContent";
            this.Btn_ShowContent.Size = new System.Drawing.Size(258, 37);
            this.Btn_ShowContent.TabIndex = 9;
            this.Btn_ShowContent.Text = "Show Content";
            this.Btn_ShowContent.UseVisualStyleBackColor = true;
            this.Btn_ShowContent.Click += new System.EventHandler(this.Btn_ShowContent_Click);
            // 
            // Frm_Mask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.Btn_ShowContent);
            this.Controls.Add(this.Btn_Phone);
            this.Controls.Add(this.Btn_Password);
            this.Controls.Add(this.Btn_Date);
            this.Controls.Add(this.Btn_Currency);
            this.Controls.Add(this.Btn_CEP);
            this.Controls.Add(this.Btn_Time);
            this.Controls.Add(this.Lbl_ActiveMask);
            this.Controls.Add(this.Lbl_Content);
            this.Controls.Add(this.Msk_TextBox);
            this.Name = "Frm_Mask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mask Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_TextBox;
        private System.Windows.Forms.Label Lbl_Content;
        private System.Windows.Forms.Label Lbl_ActiveMask;
        private System.Windows.Forms.Button Btn_Time;
        private System.Windows.Forms.Button Btn_CEP;
        private System.Windows.Forms.Button Btn_Currency;
        private System.Windows.Forms.Button Btn_Phone;
        private System.Windows.Forms.Button Btn_Password;
        private System.Windows.Forms.Button Btn_Date;
        private System.Windows.Forms.Button Btn_ShowContent;
    }
}