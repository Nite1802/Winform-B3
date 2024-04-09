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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<int> listNumber = new List<int>();
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            try
            {
                listNumber.Add(int.Parse(tBoxAddNode.Text));
                tBoxAddNode.Text = "";
            }
            catch (Exception m)
            {

                throw new Exception(m.Message);
            }
        }
        private int MyComparer(int x, int y)
        {
            if (x < y) return -1;
            if (y > x) return 1;
            return 0;
        }

        private void btnAscSort_Click(object sender, EventArgs e)
        {
            listNumber.Sort((int a, int b) => MyComparer(a, b));
            btnInsert_Click(sender, e);
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            labelResult.Text = new Form1().ConvertArrayToString(listNumber.ToArray());
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            listNumber.Sort((int a, int b) => MyComparer(b, a));
            btnInsert_Click(sender, e);
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            listNumber.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
