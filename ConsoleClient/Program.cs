using MyMassenger1;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

internal class Program
{
    private static void Main(string[] args)

    {
        Message msg = new Message("RusAl","Privet",DateTime.UtcNow);
        string output = JsonConvert.SerializeObject(msg);
        Console.WriteLine(output);
        Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
        Console.WriteLine(deserializedMsg);
        //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-09-13T08:55:00.1457458Z"}
        //Console.WriteLine("Начало проекта!");
        //Console.WriteLine(msg.ToString());
    }
}