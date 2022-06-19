using System;
using System.Windows.Forms;
using Address.Address;
using System.Text.Json;
using System.Data;

namespace Address
{
	public partial class AddrU : Form
	{
        private AddrShowD addrShowD = new AddrShowD();
        private string m_test = string.Empty;
        private Addr m_addr = new Addr();
        public AddrU()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            addrShowD.StartPosition = FormStartPosition.CenterScreen;
            addrShowD.ShowDialog();
        }

        private void DataGrid()
		{
            dgv.Columns.Add("roadAddr", "도로명주소");
            dgv.Columns.Add("bdNm", "건물명");
		}

		private void AddrU_Load(object sender, EventArgs e)
		{
            DataGrid();
        }
	}
}
