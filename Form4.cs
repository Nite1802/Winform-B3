using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Vy_N2_B3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //lac xuc xac
            int a, b, c;
            a = new Random().Next(1, 6);
            b = new Random().Next(1, 6);
            c = new Random().Next(1, 6);
            labelDice1.Text = a.ToString();
            labelDice2.Text = b.ToString();
            labelDice3.Text = c.ToString();
            // kiem tra player
            int sum = a + b + c;
            int playerScores;
            try
            {
                playerScores = int.Parse(labelScore.Text);
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            if (rbtnOption1.Checked && sum >= 3 && sum <= 10)
            {
                playerScores += 10;
            }
            else if (rbtnOption2.Checked && sum >= 11 && sum <= 18)
            {
                playerScores += 10;
            }
            else playerScores -= 10;
            //tinh diem
            labelScore.Text = playerScores.ToString();
        }
    }
}
