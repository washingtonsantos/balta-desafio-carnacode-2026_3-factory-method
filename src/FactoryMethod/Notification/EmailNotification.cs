namespace FactoryMethod.Notification
{
    public class EmailNotification : INotification
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        public void Send()
        {
            Console.WriteLine($"📧 Enviando Email para {Recipient}");
            Console.WriteLine($"   Assunto: {Subject}");
            Console.WriteLine($"   Mensagem: {Body}");
        }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var email = new EmailNotification();
            email.Recipient = recipient;
            email.Subject = "Confirmação de Pedido";
            email.Body = $"Seu pedido {orderNumber} foi confirmado!";
            email.IsHtml = true;
            email.Send();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var email = new EmailNotification();
            email.Recipient = recipient;
            email.Subject = "Lembrete de Pagamento";
            email.Body = $"Você tem um pagamento pendente de R$ {amount:N2}";
            email.IsHtml = true;
            email.Send();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var email = new EmailNotification();
            email.Recipient = recipient;
            email.Subject = "Pedido Enviado";
            email.Body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}";
            email.IsHtml = true;
            email.Send();
        }
    }
}
