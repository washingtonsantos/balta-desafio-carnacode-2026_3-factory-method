namespace FactoryMethod.Notification
{
    public class PushNotification : INotification
    {
        public string DeviceToken { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int Badge { get; set; }

        public void Send()
        {
            Console.WriteLine($"🔔 Enviando Push para dispositivo {DeviceToken}");
            Console.WriteLine($"   Título: {Title}");
            Console.WriteLine($"   Mensagem: {Message}");
        }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var push = new PushNotification();
            push.DeviceToken = recipient;
            push.Title = "Pedido Confirmado";
            push.Message = $"Pedido {orderNumber} confirmado!";
            push.Badge = 1;
            push.Send();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var push = new PushNotification();
            push.DeviceToken = recipient;
            push.Title = "Lembrete de Pagamento";
            push.Message = $"Pagamento pendente: R$ {amount:N2}";
            push.Badge = 1;
            push.Send();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var push = new PushNotification();
            push.DeviceToken = recipient;
            push.Title = "Pedido Enviado";
            push.Message = $"Rastreamento: {trackingCode}";
            push.Badge = 1;
            push.Send();
        }
    }
}
