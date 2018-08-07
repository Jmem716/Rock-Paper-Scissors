namespace RPS
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
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rockImg = new System.Windows.Forms.PictureBox();
            this.paperImg = new System.Windows.Forms.PictureBox();
            this.scissorsImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.winLoseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsImg)).BeginInit();
            this.SuspendLayout();
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(263, 65);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(75, 23);
            this.scissorsButton.TabIndex = 0;
            this.scissorsButton.Text = "SCISSORS";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(182, 65);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "PAPER";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(101, 65);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 2;
            this.rockButton.Text = "ROCK";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose one:";
            // 
            // rockImg
            // 
            this.rockImg.Image = ((System.Drawing.Image)(resources.GetObject("rockImg.Image")));
            this.rockImg.Location = new System.Drawing.Point(235, 129);
            this.rockImg.Name = "rockImg";
            this.rockImg.Size = new System.Drawing.Size(64, 66);
            this.rockImg.TabIndex = 4;
            this.rockImg.TabStop = false;
            // 
            // paperImg
            // 
            this.paperImg.Image = ((System.Drawing.Image)(resources.GetObject("paperImg.Image")));
            this.paperImg.Location = new System.Drawing.Point(237, 129);
            this.paperImg.Name = "paperImg";
            this.paperImg.Size = new System.Drawing.Size(64, 66);
            this.paperImg.TabIndex = 5;
            this.paperImg.TabStop = false;
            // 
            // scissorsImg
            // 
            this.scissorsImg.Image = ((System.Drawing.Image)(resources.GetObject("scissorsImg.Image")));
            this.scissorsImg.Location = new System.Drawing.Point(235, 128);
            this.scissorsImg.Name = "scissorsImg";
            this.scissorsImg.Size = new System.Drawing.Size(66, 67);
            this.scissorsImg.TabIndex = 6;
            this.scissorsImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "The computer chose:";
            // 
            // winLoseLabel
            // 
            this.winLoseLabel.AutoSize = true;
            this.winLoseLabel.Location = new System.Drawing.Point(209, 217);
            this.winLoseLabel.Name = "winLoseLabel";
            this.winLoseLabel.Size = new System.Drawing.Size(0, 13);
            this.winLoseLabel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.winLoseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scissorsImg);
            this.Controls.Add(this.paperImg);
            this.Controls.Add(this.rockImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.scissorsButton);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rockImg;
        private System.Windows.Forms.PictureBox paperImg;
        private System.Windows.Forms.PictureBox scissorsImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label winLoseLabel;
        private System.Windows.Forms.Label label3;
    }
}

