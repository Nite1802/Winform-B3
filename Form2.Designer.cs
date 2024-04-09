namespace _27_Vy_N2_B3
{
    partial class Form2
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
            btnAddNode = new Button();
            btnAscSort = new Button();
            btnDescSort = new Button();
            btnInsert = new Button();
            BtnErase = new Button();
            btnStop = new Button();
            tBoxAddNode = new TextBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(29, 12);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(226, 42);
            btnAddNode.TabIndex = 0;
            btnAddNode.Text = "Nhập 1 phần từ vào mảng:";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // btnAscSort
            // 
            btnAscSort.Location = new Point(376, 12);
            btnAscSort.Name = "btnAscSort";
            btnAscSort.Size = new Size(75, 90);
            btnAscSort.TabIndex = 2;
            btnAscSort.Text = "Sắp xếp tăng";
            btnAscSort.UseVisualStyleBackColor = true;
            btnAscSort.Click += btnAscSort_Click;
            // 
            // btnDescSort
            // 
            btnDescSort.Location = new Point(377, 124);
            btnDescSort.Name = "btnDescSort";
            btnDescSort.Size = new Size(75, 85);
            btnDescSort.TabIndex = 2;
            btnDescSort.Text = "Sắp xếp giảm";
            btnDescSort.UseVisualStyleBackColor = true;
            btnDescSort.Click += btnDescSort_Click;
            // 
            // btnInsert
            // 
            btnInsert.AutoSize = true;
            btnInsert.Location = new Point(29, 221);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 30);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // BtnErase
            // 
            BtnErase.Location = new Point(175, 222);
            BtnErase.Name = "BtnErase";
            BtnErase.Size = new Size(94, 29);
            BtnErase.TabIndex = 4;
            BtnErase.Text = "Erase";
            BtnErase.UseVisualStyleBackColor = true;
            BtnErase.Click += BtnErase_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(328, 222);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // tBoxAddNode
            // 
            tBoxAddNode.Location = new Point(261, 25);
            tBoxAddNode.Name = "tBoxAddNode";
            tBoxAddNode.Size = new Size(94, 27);
            tBoxAddNode.TabIndex = 6;
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.FromArgb(255, 255, 192);
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Location = new Point(29, 57);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(342, 152);
            labelResult.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 263);
            Controls.Add(labelResult);
            Controls.Add(tBoxAddNode);
            Controls.Add(btnStop);
            Controls.Add(BtnErase);
            Controls.Add(btnInsert);
            Controls.Add(btnDescSort);
            Controls.Add(btnAscSort);
            Controls.Add(btnAddNode);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNode;
        private Button btnAscSort;
        private Button btnDescSort;
        private Button btnInsert;
        private Button BtnErase;
        private Button btnStop;
        private TextBox tBoxAddNode;
        private Label labelResult;
    }
}