using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace testWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();

            string APIDomain = "https://api.openweathermap.org";
            string URL = $"{APIDomain}/data/2.5/forecast/daily?q={city}&cnt=17&appid=98ba4333281c6d0711ca78d2d0481c3d&units=metric";

            WebRequest request = WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine($"Status: {response.StatusDescription}\n");
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            Resp resp = JsonConvert.DeserializeObject<Resp>(responseFromServer);
            Console.WriteLine($"City: {resp.City.Name}\n");
            for (int i = 0; i < 7; i++)
            {
                DateTime Date = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(resp.List[i].Dt);
                Console.WriteLine($"Weather: {Math.Round(resp.List[i].Temp.Day)}, {resp.List[i].Weather[0].Main}\n{Date}\n");
            }
            Console.ReadKey();
        }
    }
}
