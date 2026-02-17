namespace FactoryMethod.Notification
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void Send()
        {
            Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
        }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var sms = new SmsNotification();
            sms.PhoneNumber = recipient;
            sms.Message = $"Pedido {orderNumber} confirmado!";
            sms.Send();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var sms = new SmsNotification();
            sms.PhoneNumber = recipient;
            sms.Message = $"Pagamento pendente: R$ {amount:N2}";
            sms.Send();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var sms = new SmsNotification();
            sms.PhoneNumber = recipient;
            sms.Message = $"Pedido enviado! Rastreamento: {trackingCode}";
            sms.Send();
        }
    }
}
