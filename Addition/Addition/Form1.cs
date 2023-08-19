namespace Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* private void button1_Click(object sender, EventArgs e)
         {
             String data1 = textBox1.Text;
             String data2 = textBox2.Text;
             int a1 = int.Parse(data1);
             int a2 = int.Parse(data2);
             int a3 = a1 + a2;
             textBox3.Text = a3.ToString();
         }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String data1 = textBox1.Text;
            String data2 = textBox2.Text;
            int a1 = int.Parse(data1);
            int a2 = int.Parse(data2);
            int a3 = a1 + a2;
            textBox3.Text = a3.ToString();

        }
    }
}