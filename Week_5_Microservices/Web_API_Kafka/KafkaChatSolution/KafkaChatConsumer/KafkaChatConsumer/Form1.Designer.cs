namespace KafkaChatConsumer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstMessages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 15;
            this.lstMessages.Location = new System.Drawing.Point(12, 12);
            this.lstMessages.Size = new System.Drawing.Size(710, 334);

            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.lstMessages);
            this.Text = "Kafka Chat - Consumer";
            this.ResumeLayout(false);
        }
    }
}
