namespace _27_Vy_N2_B3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string ConvertArrayToString<T>(T[] array)
        {
            string s = "";
            foreach (T t in array)
            {
                s += t.ToString() + "  ";
            }
            return s;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(1, 10);
            labelResult.Text = ConvertArrayToString<int>(array);
        }

        private void btnErease_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}