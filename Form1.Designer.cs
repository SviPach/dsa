namespace DSA
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
            this.textBox_key_n = new System.Windows.Forms.TextBox();
            this.textBox_key_d = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_keys_generate = new System.Windows.Forms.Button();
            this.button_keys_change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_key_e = new System.Windows.Forms.TextBox();
            this.button_keys_check = new System.Windows.Forms.Button();
            this.button_generatedKeysInfo = new System.Windows.Forms.Button();
            this.button_file_open = new System.Windows.Forms.Button();
            this.label_file_name = new System.Windows.Forms.Label();
            this.button_file_sign = new System.Windows.Forms.Button();
            this.button_file_info = new System.Windows.Forms.Button();
            this.button_signature_check = new System.Windows.Forms.Button();
            this.button_archive_open = new System.Windows.Forms.Button();
            this.label_archive_name = new System.Windows.Forms.Label();
            this.button_private_key_read = new System.Windows.Forms.Button();
            this.button_public_key_read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_key_n
            // 
            this.textBox_key_n.Location = new System.Drawing.Point(82, 61);
            this.textBox_key_n.Name = "textBox_key_n";
            this.textBox_key_n.Size = new System.Drawing.Size(364, 22);
            this.textBox_key_n.TabIndex = 0;
            // 
            // textBox_key_d
            // 
            this.textBox_key_d.Location = new System.Drawing.Point(82, 117);
            this.textBox_key_d.Name = "textBox_key_d";
            this.textBox_key_d.Size = new System.Drawing.Size(364, 22);
            this.textBox_key_d.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "N:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "D:";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(728, 364);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_keys_generate
            // 
            this.button_keys_generate.Location = new System.Drawing.Point(481, 57);
            this.button_keys_generate.Name = "button_keys_generate";
            this.button_keys_generate.Size = new System.Drawing.Size(128, 26);
            this.button_keys_generate.TabIndex = 13;
            this.button_keys_generate.Text = "Generate keys";
            this.button_keys_generate.UseVisualStyleBackColor = true;
            this.button_keys_generate.Click += new System.EventHandler(this.button_keys_generate_Click);
            // 
            // button_keys_change
            // 
            this.button_keys_change.Location = new System.Drawing.Point(481, 111);
            this.button_keys_change.Name = "button_keys_change";
            this.button_keys_change.Size = new System.Drawing.Size(128, 28);
            this.button_keys_change.TabIndex = 14;
            this.button_keys_change.Text = "Change keys";
            this.button_keys_change.UseVisualStyleBackColor = true;
            this.button_keys_change.Click += new System.EventHandler(this.button_keys_change_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "E:";
            // 
            // textBox_key_e
            // 
            this.textBox_key_e.Location = new System.Drawing.Point(82, 89);
            this.textBox_key_e.Name = "textBox_key_e";
            this.textBox_key_e.Size = new System.Drawing.Size(364, 22);
            this.textBox_key_e.TabIndex = 16;
            // 
            // button_keys_check
            // 
            this.button_keys_check.Location = new System.Drawing.Point(481, 84);
            this.button_keys_check.Name = "button_keys_check";
            this.button_keys_check.Size = new System.Drawing.Size(128, 27);
            this.button_keys_check.TabIndex = 18;
            this.button_keys_check.Text = "Check keys";
            this.button_keys_check.UseVisualStyleBackColor = true;
            this.button_keys_check.Click += new System.EventHandler(this.button_keys_check_Click);
            // 
            // button_generatedKeysInfo
            // 
            this.button_generatedKeysInfo.Location = new System.Drawing.Point(615, 57);
            this.button_generatedKeysInfo.Name = "button_generatedKeysInfo";
            this.button_generatedKeysInfo.Size = new System.Drawing.Size(188, 26);
            this.button_generatedKeysInfo.TabIndex = 19;
            this.button_generatedKeysInfo.Text = "Generated keys info";
            this.button_generatedKeysInfo.UseVisualStyleBackColor = true;
            this.button_generatedKeysInfo.Click += new System.EventHandler(this.button_generatedKeysInfo_Click);
            // 
            // button_file_open
            // 
            this.button_file_open.Location = new System.Drawing.Point(177, 181);
            this.button_file_open.Name = "button_file_open";
            this.button_file_open.Size = new System.Drawing.Size(146, 28);
            this.button_file_open.TabIndex = 20;
            this.button_file_open.Text = "Open file";
            this.button_file_open.UseVisualStyleBackColor = true;
            this.button_file_open.Click += new System.EventHandler(this.button_file_open_Click);
            // 
            // label_file_name
            // 
            this.label_file_name.Location = new System.Drawing.Point(329, 186);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(286, 23);
            this.label_file_name.TabIndex = 21;
            this.label_file_name.Text = "---";
            // 
            // button_file_sign
            // 
            this.button_file_sign.Location = new System.Drawing.Point(177, 211);
            this.button_file_sign.Name = "button_file_sign";
            this.button_file_sign.Size = new System.Drawing.Size(146, 28);
            this.button_file_sign.TabIndex = 22;
            this.button_file_sign.Text = "Sign file";
            this.button_file_sign.UseVisualStyleBackColor = true;
            this.button_file_sign.Click += new System.EventHandler(this.button_file_sign_Click);
            // 
            // button_file_info
            // 
            this.button_file_info.Location = new System.Drawing.Point(615, 84);
            this.button_file_info.Name = "button_file_info";
            this.button_file_info.Size = new System.Drawing.Size(188, 27);
            this.button_file_info.TabIndex = 25;
            this.button_file_info.Text = "File info";
            this.button_file_info.UseVisualStyleBackColor = true;
            this.button_file_info.Click += new System.EventHandler(this.button_file_info_Click);
            // 
            // button_signature_check
            // 
            this.button_signature_check.Location = new System.Drawing.Point(177, 286);
            this.button_signature_check.Name = "button_signature_check";
            this.button_signature_check.Size = new System.Drawing.Size(146, 28);
            this.button_signature_check.TabIndex = 27;
            this.button_signature_check.Text = "Check signature";
            this.button_signature_check.UseVisualStyleBackColor = true;
            this.button_signature_check.Click += new System.EventHandler(this.button_signature_check_Click);
            // 
            // button_archive_open
            // 
            this.button_archive_open.Location = new System.Drawing.Point(177, 256);
            this.button_archive_open.Name = "button_archive_open";
            this.button_archive_open.Size = new System.Drawing.Size(146, 27);
            this.button_archive_open.TabIndex = 28;
            this.button_archive_open.Text = "Open archive";
            this.button_archive_open.UseVisualStyleBackColor = true;
            this.button_archive_open.Click += new System.EventHandler(this.button_archive_open_Click);
            // 
            // label_archive_name
            // 
            this.label_archive_name.Location = new System.Drawing.Point(329, 260);
            this.label_archive_name.Name = "label_archive_name";
            this.label_archive_name.Size = new System.Drawing.Size(286, 23);
            this.label_archive_name.TabIndex = 29;
            this.label_archive_name.Text = "---";
            // 
            // button_private_key_read
            // 
            this.button_private_key_read.Location = new System.Drawing.Point(329, 335);
            this.button_private_key_read.Name = "button_private_key_read";
            this.button_private_key_read.Size = new System.Drawing.Size(146, 28);
            this.button_private_key_read.TabIndex = 30;
            this.button_private_key_read.Text = "Read private key";
            this.button_private_key_read.UseVisualStyleBackColor = true;
            this.button_private_key_read.Click += new System.EventHandler(this.button_private_key_read_Click);
            // 
            // button_public_key_read
            // 
            this.button_public_key_read.Location = new System.Drawing.Point(177, 335);
            this.button_public_key_read.Name = "button_public_key_read";
            this.button_public_key_read.Size = new System.Drawing.Size(146, 28);
            this.button_public_key_read.TabIndex = 31;
            this.button_public_key_read.Text = "Read public key";
            this.button_public_key_read.UseVisualStyleBackColor = true;
            this.button_public_key_read.Click += new System.EventHandler(this.button_public_key_read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 400);
            this.Controls.Add(this.button_public_key_read);
            this.Controls.Add(this.button_private_key_read);
            this.Controls.Add(this.label_archive_name);
            this.Controls.Add(this.button_archive_open);
            this.Controls.Add(this.button_signature_check);
            this.Controls.Add(this.button_file_info);
            this.Controls.Add(this.button_file_sign);
            this.Controls.Add(this.label_file_name);
            this.Controls.Add(this.button_file_open);
            this.Controls.Add(this.button_generatedKeysInfo);
            this.Controls.Add(this.button_keys_check);
            this.Controls.Add(this.textBox_key_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_keys_change);
            this.Controls.Add(this.button_keys_generate);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_key_d);
            this.Controls.Add(this.textBox_key_n);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_public_key_read;

        private System.Windows.Forms.Button button_private_key_read;

        private System.Windows.Forms.Label label_archive_name;

        private System.Windows.Forms.Button button_archive_open;

        private System.Windows.Forms.Button button_signature_check;

        private System.Windows.Forms.Button button_signature_type_;

        private System.Windows.Forms.Button button_file_info;

        private System.Windows.Forms.Button button_file_sign;

        private System.Windows.Forms.Label label_file_name;

        private System.Windows.Forms.Button button_file_open;

        private System.Windows.Forms.Button button_generatedKeysInfo;

        private System.Windows.Forms.Button button_keys_check;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_key_e;

        private System.Windows.Forms.Button button_keys_generate;
        private System.Windows.Forms.Button button_keys_change;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;

        private System.Windows.Forms.TextBox textBox_key_n;
        private System.Windows.Forms.TextBox textBox_key_d;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}