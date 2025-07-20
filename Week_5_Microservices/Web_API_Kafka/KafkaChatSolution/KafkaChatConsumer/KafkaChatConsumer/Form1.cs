using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaChatConsumer
{
    public partial class Form1 : Form
    {
        private IConsumer<Null, string> _consumer;
        private CancellationTokenSource _cts;

        public Form1()
        {
            InitializeComponent();

            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            _consumer = new ConsumerBuilder<Null, string>(config).Build();
            _consumer.Subscribe("chat-topic");

            _cts = new CancellationTokenSource();
            Task.Run(() => ListenMessages(_cts.Token));
        }

        private void ListenMessages(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    var result = _consumer.Consume(token);
                    Invoke(new Action(() =>
                    {
                        lstMessages.Items.Add("Friend: " + result.Message.Value);
                    }));
                }
            }
            catch (OperationCanceledException)
            {
                // Graceful exit
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _cts.Cancel();
            _consumer.Close();
            base.OnFormClosing(e);
        }
    }
}
