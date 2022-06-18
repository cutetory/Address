using System;
using System.Windows.Forms;
using Address.Address;
using System.Text.Json;


namespace Address
{
	public partial class AddrU : Form
	{
        private string m_test = string.Empty;

        private Addr m_addr = new Addr();
        public AddrU()
		{
			InitializeComponent();
		}
        public void EditToModel()
		{
            m_addr.M_Keyword = textBox1.Text;
        }
        /// <summary>
        /// Json 파싱
        /// </summary>
        private void AddrAlgorithmU()
        {
            string temp = m_addr.AddrAlgorithmM();

            // Native Object 생성
            JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions
            {
                AllowTrailingCommas = true // 데이터 후행의 쉼표 허용 여부
            };
            JsonDocument jsonDocument = JsonDocument.Parse(temp, jsonDocumentOptions);

            // Json Data 전체 출력
            Console.WriteLine(jsonDocument.RootElement);

			// JSON 데이터 중 일부 출력
			Console.WriteLine($"주소: {jsonDocument.RootElement.GetProperty("results").GetProperty("juso")[0].GetProperty("roadAddr")}");
            JsonElement jsonElement = jsonDocument.RootElement.GetProperty("results").GetProperty("juso");
            int foreachIndex = 0;
            foreach (JsonElement results in jsonElement.EnumerateArray())
			{
                var test = results.GetProperty("roadAddr");
                textBox2.Text += test.ToString();
                textBox2.Text += Environment.NewLine;
                foreachIndex++;
			}
        }

		private void button1_Click(object sender, EventArgs e)
		{
            textBox2.Text = string.Empty;
            EditToModel();
            AddrAlgorithmU();
        }

	}
}
