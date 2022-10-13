using System.Runtime.Intrinsics.X86;

namespace STO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            var NewForm2 = new Form2();
            NewForm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var NewForm3 = new Form3();
            NewForm3.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
        }
    }
}