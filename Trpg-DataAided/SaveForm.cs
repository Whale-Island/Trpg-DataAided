using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        public int Category;
        public string Description;

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = CategoryComboBox.SelectedIndex;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Description = DescriptionTextBox.Text;
        }

    }
}
