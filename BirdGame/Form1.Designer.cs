namespace BirdGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.SnowFlake = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            this.SuspendLayout();
            // 
            // Tree1
            // 
            this.Tree1.Image = ((System.Drawing.Image)(resources.GetObject("Tree1.Image")));
            this.Tree1.Location = new System.Drawing.Point(811, 22);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(247, 336);
            this.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree1.TabIndex = 0;
            this.Tree1.TabStop = false;
            this.Tree1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tree2
            // 
            this.Tree2.Image = ((System.Drawing.Image)(resources.GetObject("Tree2.Image")));
            this.Tree2.Location = new System.Drawing.Point(811, 748);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(247, 301);
            this.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree2.TabIndex = 1;
            this.Tree2.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(21, 1055);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1448, 146);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(227, 490);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(328, 155);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 3;
            this.Santa.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(376, 12);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(265, 198);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 4;
            this.moon.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // SnowFlake
            // 
            this.SnowFlake.Image = ((System.Drawing.Image)(resources.GetObject("SnowFlake.Image")));
            this.SnowFlake.Location = new System.Drawing.Point(100, 636);
            this.SnowFlake.Name = "SnowFlake";
            this.SnowFlake.Size = new System.Drawing.Size(121, 77);
            this.SnowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnowFlake.TabIndex = 7;
            this.SnowFlake.TabStop = false;
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(1224, 853);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(181, 196);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 8;
            this.house.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(67, 110);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(175, 54);
            this.scorelabel.TabIndex = 9;
            this.scorelabel.Text = "Score: 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(753, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 112);
            this.button1.TabIndex = 10;
            this.button1.Text = "PLAY AGAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1496, 1201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.house);
            this.Controls.Add(this.SnowFlake);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Tree2);
            this.Controls.Add(this.Tree1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Tree2;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox SnowFlake;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Button button1;
    }
}

