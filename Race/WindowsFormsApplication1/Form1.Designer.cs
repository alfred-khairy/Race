namespace WindowsFormsApplication1
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
            this.RaceTrackPI = new System.Windows.Forms.PictureBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.JoeBetLabel = new System.Windows.Forms.Label();
            this.BobBetLabel = new System.Windows.Forms.Label();
            this.AlBetLabel = new System.Windows.Forms.Label();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.BetButton = new System.Windows.Forms.Button();
            this.BetPrice = new System.Windows.Forms.NumericUpDown();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.BetterNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dog1PImage = new System.Windows.Forms.PictureBox();
            this.Dog2PImage = new System.Windows.Forms.PictureBox();
            this.Dog3PImage = new System.Windows.Forms.PictureBox();
            this.Dog4PImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceTrackPI
            // 
            this.RaceTrackPI.ErrorImage = ((System.Drawing.Image)(resources.GetObject("RaceTrackPI.ErrorImage")));
            this.RaceTrackPI.Image = ((System.Drawing.Image)(resources.GetObject("RaceTrackPI.Image")));
            this.RaceTrackPI.Location = new System.Drawing.Point(13, 12);
            this.RaceTrackPI.Name = "RaceTrackPI";
            this.RaceTrackPI.Size = new System.Drawing.Size(1000, 361);
            this.RaceTrackPI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RaceTrackPI.TabIndex = 0;
            this.RaceTrackPI.TabStop = false;
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(725, 53);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(206, 114);
            this.RaceButton.TabIndex = 1;
            this.RaceButton.Text = "Race";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // JoeBetLabel
            // 
            this.JoeBetLabel.AutoSize = true;
            this.JoeBetLabel.Location = new System.Drawing.Point(329, 55);
            this.JoeBetLabel.Name = "JoeBetLabel";
            this.JoeBetLabel.Size = new System.Drawing.Size(87, 17);
            this.JoeBetLabel.TabIndex = 2;
            this.JoeBetLabel.Text = "JoeBetLabel";
            // 
            // BobBetLabel
            // 
            this.BobBetLabel.AutoSize = true;
            this.BobBetLabel.Location = new System.Drawing.Point(329, 84);
            this.BobBetLabel.Name = "BobBetLabel";
            this.BobBetLabel.Size = new System.Drawing.Size(89, 17);
            this.BobBetLabel.TabIndex = 3;
            this.BobBetLabel.Text = "BobBetLabel";
            // 
            // AlBetLabel
            // 
            this.AlBetLabel.AutoSize = true;
            this.AlBetLabel.Location = new System.Drawing.Point(333, 115);
            this.AlBetLabel.Name = "AlBetLabel";
            this.AlBetLabel.Size = new System.Drawing.Size(76, 17);
            this.AlBetLabel.TabIndex = 4;
            this.AlBetLabel.Text = "AlBetLabel";
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(9, 53);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(52, 21);
            this.JoeRadioButton.TabIndex = 5;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "Joe";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(92, 145);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(92, 31);
            this.BetButton.TabIndex = 9;
            this.BetButton.Text = "Bets";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // BetPrice
            // 
            this.BetPrice.Location = new System.Drawing.Point(211, 145);
            this.BetPrice.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BetPrice.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetPrice.Name = "BetPrice";
            this.BetPrice.Size = new System.Drawing.Size(120, 22);
            this.BetPrice.TabIndex = 10;
            this.BetPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(9, 82);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(54, 21);
            this.BobRadioButton.TabIndex = 7;
            this.BobRadioButton.TabStop = true;
            this.BobRadioButton.Text = "Bob";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(9, 112);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(41, 21);
            this.AlRadioButton.TabIndex = 6;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.Text = "Al";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(548, 145);
            this.DogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(120, 22);
            this.DogNumber.TabIndex = 11;
            this.DogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BetterNameLabel
            // 
            this.BetterNameLabel.AutoSize = true;
            this.BetterNameLabel.Location = new System.Drawing.Point(6, 152);
            this.BetterNameLabel.Name = "BetterNameLabel";
            this.BetterNameLabel.Size = new System.Drawing.Size(46, 17);
            this.BetterNameLabel.TabIndex = 8;
            this.BetterNameLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bucks on dog number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DogNumber);
            this.groupBox1.Controls.Add(this.BetPrice);
            this.groupBox1.Controls.Add(this.BetButton);
            this.groupBox1.Controls.Add(this.BetterNameLabel);
            this.groupBox1.Controls.Add(this.BobRadioButton);
            this.groupBox1.Controls.Add(this.AlRadioButton);
            this.groupBox1.Controls.Add(this.JoeRadioButton);
            this.groupBox1.Controls.Add(this.AlBetLabel);
            this.groupBox1.Controls.Add(this.BobBetLabel);
            this.groupBox1.Controls.Add(this.JoeBetLabel);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 212);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // Dog1PImage
            // 
            this.Dog1PImage.Image = ((System.Drawing.Image)(resources.GetObject("Dog1PImage.Image")));
            this.Dog1PImage.Location = new System.Drawing.Point(22, 21);
            this.Dog1PImage.Name = "Dog1PImage";
            this.Dog1PImage.Size = new System.Drawing.Size(133, 50);
            this.Dog1PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1PImage.TabIndex = 14;
            this.Dog1PImage.TabStop = false;
            // 
            // Dog2PImage
            // 
            this.Dog2PImage.Image = ((System.Drawing.Image)(resources.GetObject("Dog2PImage.Image")));
            this.Dog2PImage.Location = new System.Drawing.Point(22, 102);
            this.Dog2PImage.Name = "Dog2PImage";
            this.Dog2PImage.Size = new System.Drawing.Size(133, 50);
            this.Dog2PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2PImage.TabIndex = 15;
            this.Dog2PImage.TabStop = false;
            // 
            // Dog3PImage
            // 
            this.Dog3PImage.Image = ((System.Drawing.Image)(resources.GetObject("Dog3PImage.Image")));
            this.Dog3PImage.Location = new System.Drawing.Point(22, 204);
            this.Dog3PImage.Name = "Dog3PImage";
            this.Dog3PImage.Size = new System.Drawing.Size(133, 50);
            this.Dog3PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3PImage.TabIndex = 16;
            this.Dog3PImage.TabStop = false;
            // 
            // Dog4PImage
            // 
            this.Dog4PImage.Image = ((System.Drawing.Image)(resources.GetObject("Dog4PImage.Image")));
            this.Dog4PImage.Location = new System.Drawing.Point(22, 301);
            this.Dog4PImage.Name = "Dog4PImage";
            this.Dog4PImage.Size = new System.Drawing.Size(133, 50);
            this.Dog4PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4PImage.TabIndex = 17;
            this.Dog4PImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 627);
            this.Controls.Add(this.Dog4PImage);
            this.Controls.Add(this.Dog3PImage);
            this.Controls.Add(this.Dog2PImage);
            this.Controls.Add(this.Dog1PImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RaceTrackPI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RaceTrackPI;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label JoeBetLabel;
        private System.Windows.Forms.Label BobBetLabel;
        private System.Windows.Forms.Label AlBetLabel;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.NumericUpDown BetPrice;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.Label BetterNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Dog1PImage;
        private System.Windows.Forms.PictureBox Dog2PImage;
        private System.Windows.Forms.PictureBox Dog3PImage;
        private System.Windows.Forms.PictureBox Dog4PImage;
    }
}

