namespace PicturePuzzleGame
{
    partial class frmPicturePuzzleGame
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbImages = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovesCount = new System.Windows.Forms.Label();
            this.gbImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PicturePuzzleGame.Properties.Resources.cute_cat;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(550, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original";
            // 
            // gbImages
            // 
            this.gbImages.Controls.Add(this.pb1);
            this.gbImages.Controls.Add(this.pb2);
            this.gbImages.Controls.Add(this.pb3);
            this.gbImages.Controls.Add(this.pb4);
            this.gbImages.Controls.Add(this.pb5);
            this.gbImages.Controls.Add(this.pb6);
            this.gbImages.Controls.Add(this.pb7);
            this.gbImages.Controls.Add(this.pb8);
            this.gbImages.Controls.Add(this.pb9);
            this.gbImages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImages.Location = new System.Drawing.Point(12, 29);
            this.gbImages.Name = "gbImages";
            this.gbImages.Size = new System.Drawing.Size(438, 564);
            this.gbImages.TabIndex = 1;
            this.gbImages.TabStop = false;
            this.gbImages.Text = "Puzzle Box";
            // 
            // pb1
            // 
            this.pb1.Image = global::PicturePuzzleGame.Properties.Resources._1;
            this.pb1.Location = new System.Drawing.Point(292, 380);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(140, 178);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::PicturePuzzleGame.Properties.Resources._2;
            this.pb2.Location = new System.Drawing.Point(149, 380);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(140, 178);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            this.pb2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::PicturePuzzleGame.Properties.Resources._3;
            this.pb3.Location = new System.Drawing.Point(6, 380);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(140, 178);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            this.pb3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::PicturePuzzleGame.Properties.Resources._4;
            this.pb4.Location = new System.Drawing.Point(292, 200);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(140, 178);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            this.pb4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::PicturePuzzleGame.Properties.Resources._5;
            this.pb5.Location = new System.Drawing.Point(149, 200);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(140, 178);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            this.pb5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::PicturePuzzleGame.Properties.Resources._6;
            this.pb6.Location = new System.Drawing.Point(6, 200);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(140, 178);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 4;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            this.pb6.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::PicturePuzzleGame.Properties.Resources._7;
            this.pb7.Location = new System.Drawing.Point(292, 20);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(140, 178);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 3;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            this.pb7.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::PicturePuzzleGame.Properties.Resources._9;
            this.pb8.Location = new System.Drawing.Point(149, 20);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(140, 178);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 1;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            this.pb8.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::PicturePuzzleGame.Properties.Resources._8;
            this.pb9.Location = new System.Drawing.Point(6, 20);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(140, 178);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 2;
            this.pb9.TabStop = false;
            this.pb9.Tag = "9";
            this.pb9.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PicturePuzzleGame.Properties.Resources._1;
            this.pictureBox10.Location = new System.Drawing.Point(340, 227);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(140, 178);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::PicturePuzzleGame.Properties.Resources._1;
            this.pictureBox11.Location = new System.Drawing.Point(182, 227);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(140, 178);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PicturePuzzleGame.Properties.Resources._1;
            this.pictureBox12.Location = new System.Drawing.Point(21, 227);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(140, 178);
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Green;
            this.lblTimer.Location = new System.Drawing.Point(606, 376);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(191, 86);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(636, 478);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(123, 55);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(636, 551);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(123, 55);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moves Count:";
            // 
            // lblMovesCount
            // 
            this.lblMovesCount.AutoSize = true;
            this.lblMovesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesCount.ForeColor = System.Drawing.Color.Navy;
            this.lblMovesCount.Location = new System.Drawing.Point(267, 600);
            this.lblMovesCount.Name = "lblMovesCount";
            this.lblMovesCount.Size = new System.Drawing.Size(43, 50);
            this.lblMovesCount.TabIndex = 6;
            this.lblMovesCount.Text = "0";
            // 
            // frmPicturePuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(892, 657);
            this.Controls.Add(this.lblMovesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.gbImages);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPicturePuzzleGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbImages;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovesCount;
    }
}

