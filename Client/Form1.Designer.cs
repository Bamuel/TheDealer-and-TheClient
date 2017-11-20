namespace Task4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.iptextbox = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.BGcolor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP : ";
            // 
            // iptextbox
            // 
            this.iptextbox.Location = new System.Drawing.Point(827, 532);
            this.iptextbox.Name = "iptextbox";
            this.iptextbox.Size = new System.Drawing.Size(100, 31);
            this.iptextbox.TabIndex = 1;
            this.iptextbox.Text = "localhost";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(827, 585);
            this.btnConn.Name = "btnConn";
            this.btnConn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConn.Size = new System.Drawing.Size(100, 43);
            this.btnConn.TabIndex = 2;
            this.btnConn.Text = "Join";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.Transparent;
            this.paintBox.Location = new System.Drawing.Point(522, 12);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(369, 113);
            this.paintBox.TabIndex = 3;
            this.paintBox.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(305, 388);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // BGcolor
            // 
            this.BGcolor.Location = new System.Drawing.Point(13, 532);
            this.BGcolor.Name = "BGcolor";
            this.BGcolor.Size = new System.Drawing.Size(158, 76);
            this.BGcolor.TabIndex = 5;
            this.BGcolor.Text = "Change BG Color";
            this.BGcolor.UseVisualStyleBackColor = true;
            this.BGcolor.Click += new System.EventHandler(this.BGcolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 640);
            this.Controls.Add(this.BGcolor);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.iptextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task4 SAMUEL LEVIN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iptextbox;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.PictureBox paintBox;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button BGcolor;
    }
}

