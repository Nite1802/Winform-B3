namespace _27_Vy_N2_B3
{
    partial class Form4
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
            labelDice1 = new Label();
            labelDice2 = new Label();
            labelDice3 = new Label();
            rbtnOption1 = new RadioButton();
            rbtnOption2 = new RadioButton();
            btnPlay = new Button();
            label4 = new Label();
            labelScore = new Label();
            SuspendLayout();
            // 
            // labelDice1
            // 
            labelDice1.BackColor = Color.FromArgb(128, 255, 255);
            labelDice1.Location = new Point(65, 25);
            labelDice1.Name = "labelDice1";
            labelDice1.Size = new Size(81, 74);
            labelDice1.TabIndex = 0;
            labelDice1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDice2
            // 
            labelDice2.BackColor = Color.FromArgb(128, 255, 255);
            labelDice2.Location = new Point(184, 25);
            labelDice2.Name = "labelDice2";
            labelDice2.Size = new Size(81, 74);
            labelDice2.TabIndex = 1;
            labelDice2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDice3
            // 
            labelDice3.BackColor = Color.FromArgb(128, 255, 255);
            labelDice3.Location = new Point(303, 25);
            labelDice3.Name = "labelDice3";
            labelDice3.Size = new Size(81, 74);
            labelDice3.TabIndex = 2;
            labelDice3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbtnOption1
            // 
            rbtnOption1.AutoSize = true;
            rbtnOption1.Checked = true;
            rbtnOption1.Location = new Point(94, 131);
            rbtnOption1.Margin = new Padding(3, 2, 3, 2);
            rbtnOption1.Name = "rbtnOption1";
            rbtnOption1.Size = new Size(48, 19);
            rbtnOption1.TabIndex = 3;
            rbtnOption1.TabStop = true;
            rbtnOption1.Text = "3-10";
            rbtnOption1.UseVisualStyleBackColor = true;
            // 
            // rbtnOption2
            // 
            rbtnOption2.AutoSize = true;
            rbtnOption2.Location = new Point(268, 131);
            rbtnOption2.Margin = new Padding(3, 2, 3, 2);
            rbtnOption2.Name = "rbtnOption2";
            rbtnOption2.Size = new Size(54, 19);
            rbtnOption2.TabIndex = 4;
            rbtnOption2.Text = "11-18";
            rbtnOption2.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(170, 170);
            btnPlay.Margin = new Padding(3, 2, 3, 2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(82, 22);
            btnPlay.TabIndex = 5;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 227);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Your Scores:";
            // 
            // labelScore
            // 
            labelScore.BorderStyle = BorderStyle.FixedSingle;
            labelScore.Location = new Point(185, 227);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(54, 19);
            labelScore.TabIndex = 7;
            labelScore.Text = "0";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 286);
            Controls.Add(labelScore);
            Controls.Add(label4);
            Controls.Add(btnPlay);
            Controls.Add(rbtnOption2);
            Controls.Add(rbtnOption1);
            Controls.Add(labelDice3);
            Controls.Add(labelDice2);
            Controls.Add(labelDice1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDice1;
        private Label labelDice2;
        private Label labelDice3;
        private RadioButton rbtnOption1;
        private RadioButton rbtnOption2;
        private Button btnPlay;
        private Label label4;
        private Label labelScore;
    }
}