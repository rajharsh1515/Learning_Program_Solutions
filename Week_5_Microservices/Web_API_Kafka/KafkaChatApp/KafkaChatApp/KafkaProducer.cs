using Confluent.Kafka;
using System;
using System.Threading.Tasks;

public class KafkaProducer
{
    private const string bootstrapServers = "localhost:9092";
    private const string topic = "chat-topic";

    public static async Task ProduceAsync(string message)
    {
        var config = new ProducerConfig { BootstrapServers = bootstrapServers };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        try
        {
            var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
            Console.WriteLine($" Sent: {message} | Partition: {result.Partition}, Offset: {result.Offset}");
        }
        catch (ProduceException<Null, string> e)
        {
            Console.WriteLine($" Error: {e.Error.Reason}");
        }
    }
}
