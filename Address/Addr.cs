using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;

namespace Address.Address
{
    public class Addr
    {
		private string m_keyword = string.Empty;//부곡로 32-12

		public string M_Keyword { get => m_keyword; set => m_keyword = value; }

		public string AddrAlgorithmM()
		{
			string url = "https://www.juso.go.kr/addrlink/addrLinkApi.do?resultType=json&currentPage=1&countPerPage=10&hstryYn=Y";
			StringBuilder sb = new StringBuilder(url);

			string confmKey = "&confmKey=devU01TX0FVVEgyMDIyMDYxODIwNTAyMjExMjcwNDE=&keyword=";

			sb.Append(confmKey);
			sb.Append(m_keyword);
			Console.WriteLine(sb.ToString());

			var request = (HttpWebRequest)WebRequest.Create(sb.ToString());
			request.Method = "GET";
			string results = string.Empty;
			HttpWebResponse response;
			using(response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				results = reader.ReadToEnd();
			}
			return results;
		}
		/*public string AddrAlgorithmU()
		{
			string url = "http://apis.data.go.kr/1741000/StanReginCd/getStanReginCdList"; // URL
			url += "?ServiceKey=" + "3lrloy74j7DsniR33wDUntUY0w75bEolEtxO8M%2FGV32%2BpRlyq4BnVBdFOS%2BwR0VywVK%2BaN%2F0AuR23xRxn%2FQ3FQ%3D%3D"; // Service Key
			url += "&pageNo=1";
			url += "&numOfRows=3";
			url += "&type=json";
			url += "&locatadd_nm=서울특별시";

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			string results = string.Empty;
			HttpWebResponse response;
			using (response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				results = reader.ReadToEnd();
			}

			Console.WriteLine(results);
			return results;
		}*/
		/// <summary>
		/// 아이피주소 및 주소
		/// </summary>
		/// <returns></returns>
		/*        public string AddrAlgorithmU()
				{
					string url = "http://apis.data.go.kr/B551505/whois/ip_address"; // URL
					url += "?ServiceKey=" + "3lrloy74j7DsniR33wDUntUY0w75bEolEtxO8M%2FGV32%2BpRlyq4BnVBdFOS%2BwR0VywVK%2BaN%2F0AuR23xRxn%2FQ3FQ%3D%3D"; // Service Key
					//url += "&query=202.30.50.51";
					url += "&query=59.60.122.148";
					url += "&answer=json";

					var request = (HttpWebRequest)WebRequest.Create(url);
					request.Method = "GET";

					string results = string.Empty;
					HttpWebResponse response;
					using (response = request.GetResponse() as HttpWebResponse)
					{
						StreamReader reader = new StreamReader(response.GetResponseStream());
						results = reader.ReadToEnd();
					}

					Console.WriteLine(results);
					return results;
				}*/
	}
}
