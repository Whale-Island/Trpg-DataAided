using System;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class DataForm : Form
    {
        Player player;
        public DataForm()
        {
            InitializeComponent();
        }

        public void InitFromData(Player player)
        {
            this.player = player;
            textBox37.Text = player.Nickname;
          

        }

        private void DataForm_Activated(object sender, EventArgs e)
        {
            groupBox1.Focus();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, System.EventArgs e)
        {

        }

        private void label1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void label14_Click(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            player.Nickname = sender.ToString();
        }

    }
}
