

using Newtonsoft.Json.Linq;

var client = new HttpClient();

string WestURl = "https://api.kanye.rest";
string SwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

for (int i = 0; i < 5; i++)
{
    var WestResponse = client.GetStringAsync(WestURl).Result;
    var WestQuote = JObject.Parse(WestResponse).GetValue("quote").ToString();

    var SwansonResponse = client.GetStringAsync(SwansonURL).Result;

    var SwansonQuote = JArray.Parse(SwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


    Console.WriteLine($"Mr.West says: {WestQuote}");
    Console.WriteLine($"Mr.Swanson says: {SwansonQuote}");
    Console.WriteLine();

    
        
}

    