namespace PasswordHash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.button1_sha256 = new System.Windows.Forms.Button();
            this.label1_pass = new System.Windows.Forms.Label();
            this.label1_hash = new System.Windows.Forms.Label();
            this.button1_sha512 = new System.Windows.Forms.Button();
            this.button1_sha1 = new System.Windows.Forms.Button();
            this.button_MD5 = new System.Windows.Forms.Button();
            this.button_RIPEMD160 = new System.Windows.Forms.Button();
            this.groupBox_deprecated = new System.Windows.Forms.GroupBox();
            this.groupBox_actual = new System.Windows.Forms.GroupBox();
            this.button1_Blake2b = new System.Windows.Forms.Button();
            this.button1_sha384 = new System.Windows.Forms.Button();
            this.groupBox_deprecated.SuspendLayout();
            this.groupBox_actual.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_password
            // 
            this.textBox1_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_password.Location = new System.Drawing.Point(16, 25);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.Size = new System.Drawing.Size(756, 20);
            this.textBox1_password.TabIndex = 0;
            // 
            // textBox1_result
            // 
            this.textBox1_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_result.Location = new System.Drawing.Point(16, 87);
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(756, 20);
            this.textBox1_result.TabIndex = 1;
            // 
            // button1_sha256
            // 
            this.button1_sha256.Location = new System.Drawing.Point(168, 19);
            this.button1_sha256.Name = "button1_sha256";
            this.button1_sha256.Size = new System.Drawing.Size(75, 23);
            this.button1_sha256.TabIndex = 4;
            this.button1_sha256.Text = "SHA256";
            this.button1_sha256.UseVisualStyleBackColor = true;
            this.button1_sha256.Click += new System.EventHandler(this.button1_sha256_Click);
            // 
            // label1_pass
            // 
            this.label1_pass.AutoSize = true;
            this.label1_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_pass.Location = new System.Drawing.Point(13, 9);
            this.label1_pass.Name = "label1_pass";
            this.label1_pass.Size = new System.Drawing.Size(84, 13);
            this.label1_pass.TabIndex = 3;
            this.label1_pass.Text = "Text to Hash:";
            // 
            // label1_hash
            // 
            this.label1_hash.AutoSize = true;
            this.label1_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_hash.Location = new System.Drawing.Point(13, 71);
            this.label1_hash.Name = "label1_hash";
            this.label1_hash.Size = new System.Drawing.Size(40, 13);
            this.label1_hash.TabIndex = 4;
            this.label1_hash.Text = "Hash:";
            // 
            // button1_sha512
            // 
            this.button1_sha512.Location = new System.Drawing.Point(6, 19);
            this.button1_sha512.Name = "button1_sha512";
            this.button1_sha512.Size = new System.Drawing.Size(75, 23);
            this.button1_sha512.TabIndex = 2;
            this.button1_sha512.Text = "SHA512";
            this.button1_sha512.UseVisualStyleBackColor = true;
            this.button1_sha512.Click += new System.EventHandler(this.button1_sha512_Click);
            // 
            // button1_sha1
            // 
            this.button1_sha1.Location = new System.Drawing.Point(6, 24);
            this.button1_sha1.Name = "button1_sha1";
            this.button1_sha1.Size = new System.Drawing.Size(75, 23);
            this.button1_sha1.TabIndex = 6;
            this.button1_sha1.Text = "SHA1";
            this.button1_sha1.UseVisualStyleBackColor = true;
            this.button1_sha1.Click += new System.EventHandler(this.button1_sha1_Click);
            // 
            // button_MD5
            // 
            this.button_MD5.Location = new System.Drawing.Point(168, 24);
            this.button_MD5.Name = "button_MD5";
            this.button_MD5.Size = new System.Drawing.Size(75, 23);
            this.button_MD5.TabIndex = 7;
            this.button_MD5.Text = "MD5";
            this.button_MD5.UseVisualStyleBackColor = true;
            this.button_MD5.Click += new System.EventHandler(this.button_MD5_Click);
            // 
            // button_RIPEMD160
            // 
            this.button_RIPEMD160.Location = new System.Drawing.Point(87, 24);
            this.button_RIPEMD160.Name = "button_RIPEMD160";
            this.button_RIPEMD160.Size = new System.Drawing.Size(75, 23);
            this.button_RIPEMD160.TabIndex = 5;
            this.button_RIPEMD160.Text = "RIPEMD160";
            this.button_RIPEMD160.UseVisualStyleBackColor = true;
            this.button_RIPEMD160.Click += new System.EventHandler(this.button_RIPEMD160_Click);
            // 
            // groupBox_deprecated
            // 
            this.groupBox_deprecated.Controls.Add(this.button1_sha1);
            this.groupBox_deprecated.Controls.Add(this.button_RIPEMD160);
            this.groupBox_deprecated.Controls.Add(this.button_MD5);
            this.groupBox_deprecated.Location = new System.Drawing.Point(22, 248);
            this.groupBox_deprecated.Name = "groupBox_deprecated";
            this.groupBox_deprecated.Size = new System.Drawing.Size(750, 100);
            this.groupBox_deprecated.TabIndex = 10;
            this.groupBox_deprecated.TabStop = false;
            this.groupBox_deprecated.Text = "Deprecated";
            // 
            // groupBox_actual
            // 
            this.groupBox_actual.Controls.Add(this.button1_Blake2b);
            this.groupBox_actual.Controls.Add(this.button1_sha384);
            this.groupBox_actual.Controls.Add(this.button1_sha256);
            this.groupBox_actual.Controls.Add(this.button1_sha512);
            this.groupBox_actual.Location = new System.Drawing.Point(22, 128);
            this.groupBox_actual.Name = "groupBox_actual";
            this.groupBox_actual.Size = new System.Drawing.Size(750, 100);
            this.groupBox_actual.TabIndex = 9;
            this.groupBox_actual.TabStop = false;
            this.groupBox_actual.Text = "Actual";
            // 
            // button1_Blake2b
            // 
            this.button1_Blake2b.Location = new System.Drawing.Point(249, 19);
            this.button1_Blake2b.Name = "button1_Blake2b";
            this.button1_Blake2b.Size = new System.Drawing.Size(75, 23);
            this.button1_Blake2b.TabIndex = 5;
            this.button1_Blake2b.Text = "Blake2B";
            this.button1_Blake2b.UseVisualStyleBackColor = true;
            this.button1_Blake2b.Click += new System.EventHandler(this.button1_Blake2b_Click);
            // 
            // button1_sha384
            // 
            this.button1_sha384.Location = new System.Drawing.Point(87, 19);
            this.button1_sha384.Name = "button1_sha384";
            this.button1_sha384.Size = new System.Drawing.Size(75, 23);
            this.button1_sha384.TabIndex = 3;
            this.button1_sha384.Text = "SHA384";
            this.button1_sha384.UseVisualStyleBackColor = true;
            this.button1_sha384.Click += new System.EventHandler(this.button1_sha384_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 360);
            this.Controls.Add(this.groupBox_actual);
            this.Controls.Add(this.groupBox_deprecated);
            this.Controls.Add(this.label1_hash);
            this.Controls.Add(this.label1_pass);
            this.Controls.Add(this.textBox1_result);
            this.Controls.Add(this.textBox1_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1980, 400);
            this.MinimumSize = new System.Drawing.Size(806, 399);
            this.Name = "Form1";
            this.Text = "Password Hasher";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.credits_00);
            this.groupBox_deprecated.ResumeLayout(false);
            this.groupBox_actual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.TextBox textBox1_result;
        private System.Windows.Forms.Button button1_sha256;
        private System.Windows.Forms.Label label1_pass;
        private System.Windows.Forms.Label label1_hash;
        private System.Windows.Forms.Button button1_sha512;
        private System.Windows.Forms.Button button1_sha1;
        private System.Windows.Forms.Button button_MD5;
        private System.Windows.Forms.Button button_RIPEMD160;
        private System.Windows.Forms.GroupBox groupBox_deprecated;
        private System.Windows.Forms.GroupBox groupBox_actual;
        private System.Windows.Forms.Button button1_sha384;
        private System.Windows.Forms.Button button1_Blake2b;
    }
}

