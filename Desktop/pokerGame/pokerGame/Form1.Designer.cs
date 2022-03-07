namespace pokerGame
{
    partial class Main
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
            this.generateButton = new System.Windows.Forms.Button();
            this.tabHandTwo = new System.Windows.Forms.TabControl();
            this.tabHandOne = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.handOne2 = new System.Windows.Forms.PictureBox();
            this.handOne3 = new System.Windows.Forms.PictureBox();
            this.handOne4 = new System.Windows.Forms.PictureBox();
            this.handOne5 = new System.Windows.Forms.PictureBox();
            this.handOne1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newHandTwo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.handTwo1 = new System.Windows.Forms.PictureBox();
            this.handTwo2 = new System.Windows.Forms.PictureBox();
            this.handTwo5 = new System.Windows.Forms.PictureBox();
            this.handTwo4 = new System.Windows.Forms.PictureBox();
            this.handTwo3 = new System.Windows.Forms.PictureBox();
            this.p1Result = new System.Windows.Forms.Label();
            this.p2Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabHandTwo.SuspendLayout();
            this.tabHandOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handOne2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo3)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(21, 31);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(132, 54);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate Hands";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tabHandTwo
            // 
            this.tabHandTwo.Controls.Add(this.tabHandOne);
            this.tabHandTwo.Controls.Add(this.tabPage2);
            this.tabHandTwo.Location = new System.Drawing.Point(12, 135);
            this.tabHandTwo.Name = "tabHandTwo";
            this.tabHandTwo.SelectedIndex = 0;
            this.tabHandTwo.Size = new System.Drawing.Size(791, 347);
            this.tabHandTwo.TabIndex = 13;
            // 
            // tabHandOne
            // 
            this.tabHandOne.BackColor = System.Drawing.Color.DarkGreen;
            this.tabHandOne.Controls.Add(this.button1);
            this.tabHandOne.Controls.Add(this.label2);
            this.tabHandOne.Controls.Add(this.handOne2);
            this.tabHandOne.Controls.Add(this.handOne3);
            this.tabHandOne.Controls.Add(this.handOne4);
            this.tabHandOne.Controls.Add(this.handOne5);
            this.tabHandOne.Controls.Add(this.handOne1);
            this.tabHandOne.Location = new System.Drawing.Point(4, 29);
            this.tabHandOne.Name = "tabHandOne";
            this.tabHandOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabHandOne.Size = new System.Drawing.Size(783, 314);
            this.tabHandOne.TabIndex = 0;
            this.tabHandOne.Text = "Hand One";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "New Hand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.newHandOne_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Player One Hand";
            // 
            // handOne2
            // 
            this.handOne2.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handOne2.Location = new System.Drawing.Point(192, 52);
            this.handOne2.Name = "handOne2";
            this.handOne2.Size = new System.Drawing.Size(132, 189);
            this.handOne2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handOne2.TabIndex = 9;
            this.handOne2.TabStop = false;
            // 
            // handOne3
            // 
            this.handOne3.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handOne3.Location = new System.Drawing.Point(330, 52);
            this.handOne3.Name = "handOne3";
            this.handOne3.Size = new System.Drawing.Size(132, 189);
            this.handOne3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handOne3.TabIndex = 8;
            this.handOne3.TabStop = false;
            // 
            // handOne4
            // 
            this.handOne4.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handOne4.Location = new System.Drawing.Point(468, 52);
            this.handOne4.Name = "handOne4";
            this.handOne4.Size = new System.Drawing.Size(132, 189);
            this.handOne4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handOne4.TabIndex = 7;
            this.handOne4.TabStop = false;
            // 
            // handOne5
            // 
            this.handOne5.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handOne5.Location = new System.Drawing.Point(606, 52);
            this.handOne5.Name = "handOne5";
            this.handOne5.Size = new System.Drawing.Size(132, 189);
            this.handOne5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handOne5.TabIndex = 6;
            this.handOne5.TabStop = false;
            // 
            // handOne1
            // 
            this.handOne1.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handOne1.Location = new System.Drawing.Point(54, 52);
            this.handOne1.Name = "handOne1";
            this.handOne1.Size = new System.Drawing.Size(132, 189);
            this.handOne1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handOne1.TabIndex = 5;
            this.handOne1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.newHandTwo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.handTwo1);
            this.tabPage2.Controls.Add(this.handTwo2);
            this.tabPage2.Controls.Add(this.handTwo5);
            this.tabPage2.Controls.Add(this.handTwo4);
            this.tabPage2.Controls.Add(this.handTwo3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hand Two";
            // 
            // newHandTwo
            // 
            this.newHandTwo.Location = new System.Drawing.Point(54, 263);
            this.newHandTwo.Name = "newHandTwo";
            this.newHandTwo.Size = new System.Drawing.Size(132, 32);
            this.newHandTwo.TabIndex = 18;
            this.newHandTwo.Text = "New Hand";
            this.newHandTwo.UseVisualStyleBackColor = true;
            this.newHandTwo.Click += new System.EventHandler(this.newHandTwo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player Two Hand";
            // 
            // handTwo1
            // 
            this.handTwo1.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handTwo1.Location = new System.Drawing.Point(54, 52);
            this.handTwo1.Name = "handTwo1";
            this.handTwo1.Size = new System.Drawing.Size(132, 189);
            this.handTwo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handTwo1.TabIndex = 14;
            this.handTwo1.TabStop = false;
            // 
            // handTwo2
            // 
            this.handTwo2.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handTwo2.Location = new System.Drawing.Point(192, 52);
            this.handTwo2.Name = "handTwo2";
            this.handTwo2.Size = new System.Drawing.Size(132, 189);
            this.handTwo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handTwo2.TabIndex = 13;
            this.handTwo2.TabStop = false;
            // 
            // handTwo5
            // 
            this.handTwo5.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handTwo5.Location = new System.Drawing.Point(606, 52);
            this.handTwo5.Name = "handTwo5";
            this.handTwo5.Size = new System.Drawing.Size(132, 189);
            this.handTwo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handTwo5.TabIndex = 12;
            this.handTwo5.TabStop = false;
            // 
            // handTwo4
            // 
            this.handTwo4.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handTwo4.Location = new System.Drawing.Point(468, 52);
            this.handTwo4.Name = "handTwo4";
            this.handTwo4.Size = new System.Drawing.Size(132, 189);
            this.handTwo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handTwo4.TabIndex = 11;
            this.handTwo4.TabStop = false;
            // 
            // handTwo3
            // 
            this.handTwo3.Image = global::HW4ChristensenJakob.Properties.Resources.purple_back;
            this.handTwo3.Location = new System.Drawing.Point(330, 52);
            this.handTwo3.Name = "handTwo3";
            this.handTwo3.Size = new System.Drawing.Size(132, 189);
            this.handTwo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handTwo3.TabIndex = 10;
            this.handTwo3.TabStop = false;
            // 
            // p1Result
            // 
            this.p1Result.BackColor = System.Drawing.Color.Ivory;
            this.p1Result.Location = new System.Drawing.Point(439, 31);
            this.p1Result.Name = "p1Result";
            this.p1Result.Size = new System.Drawing.Size(177, 42);
            this.p1Result.TabIndex = 14;
            // 
            // p2Result
            // 
            this.p2Result.BackColor = System.Drawing.Color.Ivory;
            this.p2Result.Location = new System.Drawing.Point(439, 90);
            this.p2Result.Name = "p2Result";
            this.p2Result.Size = new System.Drawing.Size(177, 42);
            this.p2Result.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(262, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 42);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player One Result:";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(262, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player Two Result:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(722, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "WINNER!";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.Ivory;
            this.resultLabel.Location = new System.Drawing.Point(722, 67);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 54);
            this.resultLabel.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(845, 547);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p2Result);
            this.Controls.Add(this.p1Result);
            this.Controls.Add(this.tabHandTwo);
            this.Controls.Add(this.generateButton);
            this.Name = "Main";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabHandTwo.ResumeLayout(false);
            this.tabHandOne.ResumeLayout(false);
            this.tabHandOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handOne2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handOne1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handTwo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl tabHandTwo;
        private System.Windows.Forms.TabPage tabHandOne;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox handOne2;
        private System.Windows.Forms.PictureBox handOne3;
        private System.Windows.Forms.PictureBox handOne4;
        private System.Windows.Forms.PictureBox handOne5;
        private System.Windows.Forms.PictureBox handOne1;
        private System.Windows.Forms.PictureBox handTwo1;
        private System.Windows.Forms.PictureBox handTwo2;
        private System.Windows.Forms.PictureBox handTwo5;
        private System.Windows.Forms.PictureBox handTwo4;
        private System.Windows.Forms.PictureBox handTwo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newHandTwo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label p1Result;
        private System.Windows.Forms.Label p2Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

