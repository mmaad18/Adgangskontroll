namespace Client
{
    partial class Adgang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adgang));
            this.sendBtn = new System.Windows.Forms.Button();
            this.ipFelt = new System.Windows.Forms.TextBox();
            this.txtbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAvslutt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kortleserID = new System.Windows.Forms.TextBox();
            this.brukerID = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(18, 449);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(264, 40);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // ipFelt
            // 
            this.ipFelt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.ipFelt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipFelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipFelt.ForeColor = System.Drawing.Color.White;
            this.ipFelt.Location = new System.Drawing.Point(136, 288);
            this.ipFelt.Name = "ipFelt";
            this.ipFelt.Size = new System.Drawing.Size(146, 26);
            this.ipFelt.TabIndex = 3;
            this.ipFelt.Text = "127.0.0.1";
            this.ipFelt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbPort
            // 
            this.txtbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.txtbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPort.ForeColor = System.Drawing.Color.White;
            this.txtbPort.Location = new System.Drawing.Point(220, 320);
            this.txtbPort.MaxLength = 5;
            this.txtbPort.Name = "txtbPort";
            this.txtbPort.Size = new System.Drawing.Size(62, 26);
            this.txtbPort.TabIndex = 5;
            this.txtbPort.Text = "9090";
            this.txtbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(14, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Portnummer:";
            // 
            // btAvslutt
            // 
            this.btAvslutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.btAvslutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAvslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvslutt.ForeColor = System.Drawing.Color.White;
            this.btAvslutt.Location = new System.Drawing.Point(18, 495);
            this.btAvslutt.Name = "btAvslutt";
            this.btAvslutt.Size = new System.Drawing.Size(264, 40);
            this.btAvslutt.TabIndex = 8;
            this.btAvslutt.Text = "Avslutt";
            this.btAvslutt.UseVisualStyleBackColor = false;
            this.btAvslutt.Click += new System.EventHandler(this.btAvslutt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(14, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kortleser IP:";
            // 
            // kortleserID
            // 
            this.kortleserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.kortleserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kortleserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kortleserID.ForeColor = System.Drawing.Color.White;
            this.kortleserID.Location = new System.Drawing.Point(220, 352);
            this.kortleserID.MaxLength = 4;
            this.kortleserID.Name = "kortleserID";
            this.kortleserID.Size = new System.Drawing.Size(62, 26);
            this.kortleserID.TabIndex = 10;
            this.kortleserID.Text = "1234";
            this.kortleserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // brukerID
            // 
            this.brukerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.brukerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brukerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brukerID.ForeColor = System.Drawing.Color.White;
            this.brukerID.Location = new System.Drawing.Point(220, 384);
            this.brukerID.MaxLength = 4;
            this.brukerID.Name = "brukerID";
            this.brukerID.Size = new System.Drawing.Size(62, 26);
            this.brukerID.TabIndex = 11;
            this.brukerID.Text = "4321";
            this.brukerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(59)))));
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.ForeColor = System.Drawing.Color.White;
            this.pin.Location = new System.Drawing.Point(220, 416);
            this.pin.MaxLength = 4;
            this.pin.Name = "pin";
            this.pin.PasswordChar = '⚿';
            this.pin.Size = new System.Drawing.Size(62, 29);
            this.pin.TabIndex = 12;
            this.pin.Text = "9090";
            this.pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(14, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kortleser ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(14, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bruker ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(14, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Client.Properties.Resources.lockwhite;
            this.pictureBox1.Location = new System.Drawing.Point(50, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Adgang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Client.Properties.Resources.S7_Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 608);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.brukerID);
            this.Controls.Add(this.kortleserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAvslutt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbPort);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.ipFelt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adgang";
            this.Padding = new System.Windows.Forms.Padding(15, 70, 15, 70);
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox ipFelt;
        private System.Windows.Forms.TextBox txtbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAvslutt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kortleserID;
        private System.Windows.Forms.TextBox brukerID;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

