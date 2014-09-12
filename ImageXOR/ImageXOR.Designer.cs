namespace ImageXOR
{
    partial class ImageXOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageXOR));
            this.pictureKey = new System.Windows.Forms.PictureBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadMessage1 = new System.Windows.Forms.Button();
            this.pictureM1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadMessage2 = new System.Windows.Forms.Button();
            this.pictureM2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureC1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureC2 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureDifference = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureM2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureC1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureC2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDifference)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureKey
            // 
            this.pictureKey.Location = new System.Drawing.Point(26, 100);
            this.pictureKey.Name = "pictureKey";
            this.pictureKey.Size = new System.Drawing.Size(128, 128);
            this.pictureKey.TabIndex = 0;
            this.pictureKey.TabStop = false;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(40, 40);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(100, 45);
            this.btnGenerateKey.TabIndex = 1;
            this.btnGenerateKey.Text = "Generate Random Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateKey);
            this.groupBox1.Controls.Add(this.pictureKey);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 - Generate a Random Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadMessage1);
            this.groupBox2.Controls.Add(this.pictureM1);
            this.groupBox2.Location = new System.Drawing.Point(220, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 250);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 - Load Image Message 1";
            // 
            // btnLoadMessage1
            // 
            this.btnLoadMessage1.Location = new System.Drawing.Point(40, 40);
            this.btnLoadMessage1.Name = "btnLoadMessage1";
            this.btnLoadMessage1.Size = new System.Drawing.Size(100, 45);
            this.btnLoadMessage1.TabIndex = 1;
            this.btnLoadMessage1.Text = "Load Image Message 1";
            this.btnLoadMessage1.UseVisualStyleBackColor = true;
            this.btnLoadMessage1.Click += new System.EventHandler(this.btnLoadMessage1_Click);
            // 
            // pictureM1
            // 
            this.pictureM1.Location = new System.Drawing.Point(26, 100);
            this.pictureM1.Name = "pictureM1";
            this.pictureM1.Size = new System.Drawing.Size(128, 128);
            this.pictureM1.TabIndex = 0;
            this.pictureM1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadMessage2);
            this.groupBox3.Controls.Add(this.pictureM2);
            this.groupBox3.Location = new System.Drawing.Point(420, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 250);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 - Load Image Message 2";
            // 
            // btnLoadMessage2
            // 
            this.btnLoadMessage2.Location = new System.Drawing.Point(40, 40);
            this.btnLoadMessage2.Name = "btnLoadMessage2";
            this.btnLoadMessage2.Size = new System.Drawing.Size(100, 45);
            this.btnLoadMessage2.TabIndex = 1;
            this.btnLoadMessage2.Text = "Load Image Message 2";
            this.btnLoadMessage2.UseVisualStyleBackColor = true;
            this.btnLoadMessage2.Click += new System.EventHandler(this.btnLoadMessage2_Click);
            // 
            // pictureM2
            // 
            this.pictureM2.Location = new System.Drawing.Point(26, 100);
            this.pictureM2.Name = "pictureM2";
            this.pictureM2.Size = new System.Drawing.Size(128, 128);
            this.pictureM2.TabIndex = 0;
            this.pictureM2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureC1);
            this.groupBox4.Location = new System.Drawing.Point(20, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "C1 - Message 1 XOR Key";
            // 
            // pictureC1
            // 
            this.pictureC1.Location = new System.Drawing.Point(26, 40);
            this.pictureC1.Name = "pictureC1";
            this.pictureC1.Size = new System.Drawing.Size(128, 128);
            this.pictureC1.TabIndex = 0;
            this.pictureC1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureC2);
            this.groupBox5.Location = new System.Drawing.Point(220, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 200);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "C2 - Message 2 XOR Key";
            // 
            // pictureC2
            // 
            this.pictureC2.Location = new System.Drawing.Point(26, 40);
            this.pictureC2.Name = "pictureC2";
            this.pictureC2.Size = new System.Drawing.Size(128, 128);
            this.pictureC2.TabIndex = 0;
            this.pictureC2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureDifference);
            this.groupBox6.Location = new System.Drawing.Point(420, 290);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 200);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "C1 XOR C2";
            // 
            // pictureDifference
            // 
            this.pictureDifference.Location = new System.Drawing.Point(26, 40);
            this.pictureDifference.Name = "pictureDifference";
            this.pictureDifference.Size = new System.Drawing.Size(128, 128);
            this.pictureDifference.TabIndex = 0;
            this.pictureDifference.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 496);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(513, 155);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // ImageXOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 670);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageXOR";
            this.Text = "Two Time Pad Demonstration with Images";
            ((System.ComponentModel.ISupportInitialize)(this.pictureKey)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureM1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureM2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureC1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureC2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDifference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureKey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadMessage1;
        private System.Windows.Forms.PictureBox pictureM1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoadMessage2;
        private System.Windows.Forms.PictureBox pictureM2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureC1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureC2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureDifference;
        private System.Windows.Forms.TextBox textBox1;
    }
}

