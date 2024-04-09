namespace _27_Vy_N2_B3
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
            labelResult = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnErease = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.FromArgb(255, 255, 128);
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Location = new Point(67, 42);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(320, 81);
            labelResult.TabIndex = 0;
            labelResult.Text = "array";
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(77, 52);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 1;
            label2.Text = "Các phần tử trong mảng là:";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(47, 153);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnErease
            // 
            btnErease.Location = new Point(172, 153);
            btnErease.Name = "btnErease";
            btnErease.Size = new Size(94, 29);
            btnErease.TabIndex = 3;
            btnErease.Text = "Erease";
            btnErease.UseVisualStyleBackColor = true;
            btnErease.Click += btnErease_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(302, 153);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 323);
            Controls.Add(btnStop);
            Controls.Add(btnErease);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private Label label2;
        private Button btnInsert;
        private Button btnErease;
        private Button btnStop;
    }
}