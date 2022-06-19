# 도로명 주소 C# WindowForm으로 만들기
> 승인키 만료기한은 2022-06-25 이다.(행정안전부 opnAPI)

><img src="/Address/IntroImage.jpg" width="450px" height="300px" title="openAPI주소" ></img><br/>
```
	public interface AddrT
	{
		void SetData(string Data);
	}
```
```
	public partial class AddrU : Form, AddrT
	{
        	//private AddrShowD addrShowD = new AddrShowD();
        	private string m_test = string.Empty;
        	private Addr m_addr = new Addr();
		private AddrShowD addrShowD = null;

        	public AddrU()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			addrShowD = new AddrShowD(this as AddrT);
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

		public void SetData(string Data)
		{
			txtInput.Text = Data;
		}
	}

```
> ### 주요사항: .NET Framework 4.0대 이상은 Json 쓰면 되고, 아니면 XML써야함
> ### 인터페이스 사용해서 다이얼로그에서 일반 폼으로 데이터 이동
> 
