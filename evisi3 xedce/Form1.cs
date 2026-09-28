namespace evisi3_xedce
{
    public partial class Form1 : Form
    {
        private int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = a;
            comboBox1.Text = b;
            comboBox2.Text = c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            listBox1.Items.Add(count.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " " + tarix.Text + " " +
                saat.Text + " " + yer.Text + " " + adsoyad.Text);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            saat.Clear();
            yer.Clear();
            adsoyad.Clear();
            fin.Clear();
            email.Clear();
            telefon.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
