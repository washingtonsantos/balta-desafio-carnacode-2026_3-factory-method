namespace FactoryMethod.Notification
{
    public class TelegramNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool UseTemplate { get; set; }

        public void Send()
        {
            Console.WriteLine($"💬 Enviando Telegram para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
            Console.WriteLine($"   Template: {UseTemplate}");
        }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var whatsapp = new TelegramNotification();
            whatsapp.PhoneNumber = recipient;
            whatsapp.Message = $"✅ Seu pedido {orderNumber} foi confirmado!";
            whatsapp.UseTemplate = true;
            whatsapp.Send();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var whatsapp = new TelegramNotification();
            whatsapp.PhoneNumber = recipient;
            whatsapp.Message = $"Pagamento pendente: R$ {amount:N2}";
            whatsapp.UseTemplate = true;
            whatsapp.Send();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var whatsapp = new TelegramNotification();
            whatsapp.PhoneNumber = recipient;
            whatsapp.Message = $"📦 Pedido enviado! Rastreamento: {trackingCode}";
            whatsapp.UseTemplate = true;
            whatsapp.Send();
        }
    }
}
