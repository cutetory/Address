using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;

namespace Address.Address
{
	/// <summary>
	/// 이 폼에서 AddrShowD폼이 ShowDialog형태로 팝업되며, 팝업창의 결과가 최종 출력되는 곳.
	/// </summary>
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
	}
}
