namespace FactoryMethod.Notification
{
    public class SlackNotification : INotification
    {
        public string Channel { get; set; }
        public string Text { get; set; }

        public void Send()
        {
            Console.WriteLine($"📱 Enviando Slack para {Channel}");
            Console.WriteLine($"   Mensagem: {Text}");
        }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var sms = new SlackNotification();
            sms.Channel = recipient;
            sms.Text = $"Pedido {orderNumber} confirmado!";
            sms.Send();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var sms = new SlackNotification();
            sms.Channel = recipient;
            sms.Text = $"Pagamento pendente: R$ {amount:N2}";
            sms.Send();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var sms = new SlackNotification();
            sms.Channel = recipient;
            sms.Text = $"Pedido enviado! Rastreamento: {trackingCode}";
            sms.Send();
        }
    }
}
