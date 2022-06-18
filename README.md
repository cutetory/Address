# 도로명 주소 C# WindowForm으로 만들기
> 승인키 만료기간은 2022-06-25 이다.
> ```
> private void AddrAlgorithmU()
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
> ```
> 
