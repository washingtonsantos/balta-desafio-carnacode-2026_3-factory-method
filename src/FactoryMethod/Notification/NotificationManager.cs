namespace FactoryMethod.Notification
{
    public class NotificationManager
    {
        public void SendOrderConfirmation(string recipient, string orderNumber, string notificationType)
        {
            // Problema: Lógica de criação de notificações acoplada no método
            // Adicionar novo tipo de notificação requer modificar este código

            if (notificationType == "email")
            {
                var email = new EmailNotification();
                email.Recipient = recipient;
                email.Subject = "Confirmação de Pedido";
                email.Body = $"Seu pedido {orderNumber} foi confirmado!";
                email.IsHtml = true;
                email.Send();
            }
            else if (notificationType == "sms")
            {
                var sms = new SmsNotification();
                sms.PhoneNumber = recipient;
                sms.Message = $"Pedido {orderNumber} confirmado!";
                sms.Send();
            }
            else if (notificationType == "push")
            {
                var push = new PushNotification();
                push.DeviceToken = recipient;
                push.Title = "Pedido Confirmado";
                push.Message = $"Pedido {orderNumber} confirmado!";
                push.Badge = 1;
                push.Send();
            }
            else if (notificationType == "whatsapp")
            {
                var whatsapp = new WhatsAppNotification();
                whatsapp.PhoneNumber = recipient;
                whatsapp.Message = $"✅ Seu pedido {orderNumber} foi confirmado!";
                whatsapp.UseTemplate = true;
                whatsapp.Send();
            }
            else
            {
                throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado");
            }
        }

        public void SendShippingUpdate(string recipient, string trackingCode, string notificationType)
        {
            // Problema: Código duplicado - mesma estrutura condicional repetida
            if (notificationType == "email")
            {
                var email = new EmailNotification();
                email.Recipient = recipient;
                email.Subject = "Pedido Enviado";
                email.Body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}";
                email.IsHtml = true;
                email.Send();
            }
            else if (notificationType == "sms")
            {
                var sms = new SmsNotification();
                sms.PhoneNumber = recipient;
                sms.Message = $"Pedido enviado! Rastreamento: {trackingCode}";
                sms.Send();
            }
            else if (notificationType == "push")
            {
                var push = new PushNotification();
                push.DeviceToken = recipient;
                push.Title = "Pedido Enviado";
                push.Message = $"Rastreamento: {trackingCode}";
                push.Badge = 1;
                push.Send();
            }
            else if (notificationType == "whatsapp")
            {
                var whatsapp = new WhatsAppNotification();
                whatsapp.PhoneNumber = recipient;
                whatsapp.Message = $"📦 Pedido enviado! Rastreamento: {trackingCode}";
                whatsapp.UseTemplate = true;
                whatsapp.Send();
            }
        }

        public void SendPaymentReminder(string recipient, decimal amount, string notificationType)
        {
            // Problema: Cada novo método repete a mesma lógica condicional
            if (notificationType == "email")
            {
                var email = new EmailNotification();
                email.Recipient = recipient;
                email.Subject = "Lembrete de Pagamento";
                email.Body = $"Você tem um pagamento pendente de R$ {amount:N2}";
                email.IsHtml = true;
                email.Send();
            }
            else if (notificationType == "sms")
            {
                var sms = new SmsNotification();
                sms.PhoneNumber = recipient;
                sms.Message = $"Pagamento pendente: R$ {amount:N2}";
                sms.Send();
            }
            // ... mesmo padrão se repete
        }
    }
}
