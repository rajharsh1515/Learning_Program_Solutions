using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;

public class KafkaConsumer
{
    private const string bootstrapServers = "localhost:9092";
    private const string topic = "chat-topic";
    private const string groupId = "chat-consumer-group";

    public static void ConsumeMessages()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = groupId,
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(topic);

        Console.WriteLine(" Listening for chat messages...\n");

        try
        {
            while (true)
            {
                var result = consumer.Consume(CancellationToken.None);
                Console.WriteLine($" Received: {result.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}
