using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Kafka Chat App");
        Console.WriteLine("Choose mode: 1 - Send message | 2 - Receive messages");
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            while (true)
            {
                Console.Write("You: ");
                var message = Console.ReadLine();
                await KafkaProducer.ProduceAsync(message);
            }
        }
        else if (choice == "2")
        {
            KafkaConsumer.ConsumeMessages();
        }
        else
        {
            Console.WriteLine("❌ Invalid choice.");
        }
    }
}
