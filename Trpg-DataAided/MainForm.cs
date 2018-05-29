using System;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class MainForm : Form
    {
        DataForm dataForm;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了。。。/r/n" + ex.Message);
            }

        }

        private void Init()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Manager.Instance.list;

        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            if (dataForm != null)
            {
                dataForm.Close();
            }
            dataForm = new DataForm();
            dataForm.InitFromData(Manager.Instance.list[index]);

            dataForm.Show();
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void CreatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Instance.Create();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Manager.Instance.list;
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？删除后无法找回噢", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Manager.Instance.Remove(id);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Manager.Instance.list;
            }
        }
    }
}
