namespace FactoryMethod.Notification
{
   public static class NotificationFactory
    {
        public static INotification Create(string type)
        {
            return type switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                "whatsapp" => new WhatsAppNotification(),
                "telegram" => new TelegramNotification(),
                "slack" => new SlackNotification(),
                _ => throw new ArgumentException($"Tipo de notificação '{type}' não suportado")
            };
        }
    }
}
