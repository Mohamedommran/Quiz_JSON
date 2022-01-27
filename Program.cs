using System.Text.Json;

namespace QuizzJSON
{
    public class Json
    {
        public Dictionary<string,User> users { get; set; }
        public string[] questions { get; set; }
        public string[] answers { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "C:/Users/Mody/Desktop/QuizzJSON/quizz.json";
            string jsonString = File.ReadAllText(fileName);
            Json json = JsonSerializer.Deserialize<Json>(jsonString);


            Console.WriteLine(json.users["admin"].name);
        }
    }
}