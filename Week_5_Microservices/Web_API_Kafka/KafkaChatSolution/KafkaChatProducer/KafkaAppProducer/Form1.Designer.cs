namespace KafkaChatProducer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstMessages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.txtMessage.Location = new System.Drawing.Point(12, 310);
            this.txtMessage.Size = new System.Drawing.Size(600, 23);

            this.btnSend.Location = new System.Drawing.Point(620, 310);
            this.btnSend.Size = new System.Drawing.Size(100, 38);
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.lstMessages.Location = new System.Drawing.Point(12, 12);
            this.lstMessages.Size = new System.Drawing.Size(708, 290);

            this.ClientSize = new System.Drawing.Size(734, 350);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Text = "Kafka Chat - Producer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
