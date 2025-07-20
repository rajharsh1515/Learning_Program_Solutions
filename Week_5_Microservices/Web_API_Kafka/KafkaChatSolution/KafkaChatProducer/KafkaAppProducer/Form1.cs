using Confluent.Kafka;
using System;
using System.Windows.Forms;

namespace KafkaChatProducer
{
    public partial class Form1 : Form
    {
        private readonly IProducer<Null, string> _producer;

        public Form1()
        {
            InitializeComponent();

            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                var message = txtMessage.Text.Trim();
                await _producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                lstMessages.Items.Add("You: " + message);
                txtMessage.Clear();
            }
        }
    }
}
