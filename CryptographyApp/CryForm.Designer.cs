namespace CryptographyApp
{
    partial class CryForm
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
            this.tb_key = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_encryption = new System.Windows.Forms.GroupBox();
            this.bt_encryption = new System.Windows.Forms.Button();
            this.gb_encryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(54, 35);
            this.tb_key.MaxLength = 2;
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(100, 20);
            this.tb_key.TabIndex = 1;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(6, 138);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(430, 356);
            this.tb_input.TabIndex = 2;
            this.tb_input.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text to be encrypted:";
            // 
            // gb_encryption
            // 
            this.gb_encryption.Controls.Add(this.bt_encryption);
            this.gb_encryption.Controls.Add(this.label2);
            this.gb_encryption.Controls.Add(this.label1);
            this.gb_encryption.Controls.Add(this.tb_key);
            this.gb_encryption.Controls.Add(this.tb_input);
            this.gb_encryption.Location = new System.Drawing.Point(12, 12);
            this.gb_encryption.Name = "gb_encryption";
            this.gb_encryption.Size = new System.Drawing.Size(442, 500);
            this.gb_encryption.TabIndex = 4;
            this.gb_encryption.TabStop = false;
            this.gb_encryption.Text = "Encryption";
            // 
            // bt_encryption
            // 
            this.bt_encryption.Location = new System.Drawing.Point(287, 38);
            this.bt_encryption.Name = "bt_encryption";
            this.bt_encryption.Size = new System.Drawing.Size(75, 23);
            this.bt_encryption.TabIndex = 4;
            this.bt_encryption.Text = "Encryption";
            this.bt_encryption.UseVisualStyleBackColor = true;
            this.bt_encryption.Click += new System.EventHandler(this.bt_encryption_Click);
            // 
            // CryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 524);
            this.Controls.Add(this.gb_encryption);
            this.Name = "CryForm";
            this.Text = "Cryptography Application";
            this.Load += new System.EventHandler(this.CryForm_Load);
            this.gb_encryption.ResumeLayout(false);
            this.gb_encryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.RichTextBox tb_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_encryption;
        private System.Windows.Forms.Button bt_encryption;
    }
}

