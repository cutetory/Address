using Address.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address
{
	/// <summary>
	/// 도로명주소, 건물명 ShowDialog폼
	/// </summary>
	public partial class AddrShowD : Form
	{
		private Addr m_addr = new Addr();
		private AddrU m_addrU = null;
		private AddrT m_addrT = null;
		public AddrShowD()
		{
			InitializeComponent();
			Console.WriteLine("AddrShowD() 생성자");
		}
		public AddrShowD(AddrT _addrT)
		{
			InitializeComponent();
			m_addrT = _addrT;
			Console.WriteLine("AddrShowD(AddrT _addrT) 생성자");
		}
		/// <summary>
		/// Addr클래스에 주소 검색을 위한 키워드 정보 보냄
		/// </summary>
		private void EditToKeyword()
		{
			m_addr.M_Keyword = txtAddrShowD.Text;
		}
		/// <summary>
		/// 확인하고 검색창 종료
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddrShowD_Click(object sender, EventArgs e)
		{
			m_addrT.SetData(txtAddrShowDResult.Text);
			this.Close();
		}
		/// <summary>
		/// 건물명과 도로명주소 검색 버튼
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddrShowSearch_Click(object sender, EventArgs e)
		{
			dgvAddrShowD.Rows.Clear();
			EditToKeyword();
			AddrAlgorithmU();
		}
		/// <summary>
		/// 건물명과 도로명주소를 openAPI에서 검색하여 불러오는 기능
		/// </summary>
		private void AddrAlgorithmU()
		{
			string temp = m_addr.AddrAlgorithmM();
			try
			{
				// Native Object 생성
				JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions
				{
					AllowTrailingCommas = true // 데이터 후행의 쉼표 허용 여부
				};
				JsonDocument jsonDocument = JsonDocument.Parse(temp, jsonDocumentOptions);

				// Json Data 전체 출력
				//Console.WriteLine(jsonDocument.RootElement);

				// JSON 데이터 중 일부 출력
				//Console.WriteLine($"주소: {jsonDocument.RootElement.GetProperty("results").GetProperty("juso")[0].GetProperty("roadAddr")}");
				JsonElement jsonElement = jsonDocument.RootElement.GetProperty("results").GetProperty("juso");
				if (!string.IsNullOrEmpty(jsonElement.ToString()))
				{
					int foreachIndex = 0;
					foreach (JsonElement results in jsonElement.EnumerateArray())
					{
						var test = results.GetProperty("roadAddr");
						var test2 = results.GetProperty("bdNm");
						dgvAddrShowD.Rows.Add(test, test2);
						foreachIndex++;
					}
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// 데이터그리드뷰에 도로명주소, 건물명 컬럼 추가(Load 시 실행)
		/// </summary>
		private void DataGrid()
		{
			dgvAddrShowD.Columns.Add("roadAddr", "도로명주소");
			dgvAddrShowD.Columns.Add("bdNm", "건물명");
		}

		/// <summary>
		/// AddrShowD폼 실행 시 DataGrid뷰 Setting
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddrShowD_Load(object sender, EventArgs e)
		{
			DataGrid();
		}

		/// <summary>
		/// ColumnIndex : -1 == 선택, 0 == 도로명주소, 1 == 건물명
		/// </summary>
		/// <example></example>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvAddrShowD_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if(e.ColumnIndex == -1 && e.RowIndex < dgvAddrShowD.RowCount -1)
				{
					dgvAddrShowD.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
					var test = dgvAddrShowD.SelectedRows[0].Cells[0].Value;
					var test2 = dgvAddrShowD.SelectedRows[0].Cells[1].Value;
					Console.WriteLine(test.ToString());
					Console.WriteLine(test2.ToString());
					txtAddrShowDResult.Text = test.ToString();
				}
				else if(e.ColumnIndex == 0 && e.RowIndex!=-1)
				{
					MessageBox.Show("왼쪽(<<)의 로우인덱스를 클릭하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if(e.ColumnIndex == 1 && e.RowIndex!=-1)
				{
					MessageBox.Show("왼쪽(<<)의 로우인덱스를 클릭하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				//Console.WriteLine(test[1].Value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
