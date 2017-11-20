namespace Task4 {
    partial class GameForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.CARDNUM1 = new System.Windows.Forms.PictureBox();
            this.CARDNUM2 = new System.Windows.Forms.PictureBox();
            this.CARDNUM3 = new System.Windows.Forms.PictureBox();
            this.CARDNUM4 = new System.Windows.Forms.PictureBox();
            this.oppCard1 = new System.Windows.Forms.PictureBox();
            this.oppCard2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oppCard3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(790, 489);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(160, 46);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(790, 554);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(160, 46);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // CARDNUM1
            // 
            this.CARDNUM1.Location = new System.Drawing.Point(12, 397);
            this.CARDNUM1.Name = "CARDNUM1";
            this.CARDNUM1.Size = new System.Drawing.Size(150, 203);
            this.CARDNUM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CARDNUM1.TabIndex = 2;
            this.CARDNUM1.TabStop = false;
            // 
            // CARDNUM2
            // 
            this.CARDNUM2.Location = new System.Drawing.Point(185, 397);
            this.CARDNUM2.Name = "CARDNUM2";
            this.CARDNUM2.Size = new System.Drawing.Size(150, 203);
            this.CARDNUM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CARDNUM2.TabIndex = 3;
            this.CARDNUM2.TabStop = false;
            // 
            // CARDNUM3
            // 
            this.CARDNUM3.Enabled = false;
            this.CARDNUM3.Location = new System.Drawing.Point(358, 397);
            this.CARDNUM3.Name = "CARDNUM3";
            this.CARDNUM3.Size = new System.Drawing.Size(150, 203);
            this.CARDNUM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CARDNUM3.TabIndex = 4;
            this.CARDNUM3.TabStop = false;
            this.CARDNUM3.Visible = false;
            // 
            // CARDNUM4
            // 
            this.CARDNUM4.Enabled = false;
            this.CARDNUM4.Location = new System.Drawing.Point(531, 397);
            this.CARDNUM4.Name = "CARDNUM4";
            this.CARDNUM4.Size = new System.Drawing.Size(150, 203);
            this.CARDNUM4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CARDNUM4.TabIndex = 5;
            this.CARDNUM4.TabStop = false;
            this.CARDNUM4.Visible = false;
            // 
            // oppCard1
            // 
            this.oppCard1.Image = ((System.Drawing.Image)(resources.GetObject("oppCard1.Image")));
            this.oppCard1.Location = new System.Drawing.Point(792, 12);
            this.oppCard1.Name = "oppCard1";
            this.oppCard1.Size = new System.Drawing.Size(150, 203);
            this.oppCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppCard1.TabIndex = 6;
            this.oppCard1.TabStop = false;
            // 
            // oppCard2
            // 
            this.oppCard2.Image = ((System.Drawing.Image)(resources.GetObject("oppCard2.Image")));
            this.oppCard2.Location = new System.Drawing.Point(619, 12);
            this.oppCard2.Name = "oppCard2";
            this.oppCard2.Size = new System.Drawing.Size(150, 203);
            this.oppCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppCard2.TabIndex = 7;
            this.oppCard2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "YOU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(620, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "OPPENENT";
            // 
            // oppCard3
            // 
            this.oppCard3.Image = ((System.Drawing.Image)(resources.GetObject("oppCard3.Image")));
            this.oppCard3.Location = new System.Drawing.Point(444, 12);
            this.oppCard3.Name = "oppCard3";
            this.oppCard3.Size = new System.Drawing.Size(150, 203);
            this.oppCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppCard3.TabIndex = 10;
            this.oppCard3.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.oppCard3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oppCard2);
            this.Controls.Add(this.oppCard1);
            this.Controls.Add(this.CARDNUM4);
            this.Controls.Add(this.CARDNUM3);
            this.Controls.Add(this.CARDNUM2);
            this.Controls.Add(this.CARDNUM1);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Name = "GameForm";
            this.Text = "TASK 4 SAMUEL LEVIN";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARDNUM4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppCard3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.PictureBox CARDNUM1;
        private System.Windows.Forms.PictureBox CARDNUM2;
        private System.Windows.Forms.PictureBox CARDNUM3;
        private System.Windows.Forms.PictureBox CARDNUM4;
        private System.Windows.Forms.PictureBox oppCard1;
        private System.Windows.Forms.PictureBox oppCard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox oppCard3;
    }
}