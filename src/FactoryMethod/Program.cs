using FactoryMethod.Notification;

Console.WriteLine("=== Sistema de Notificações ===\n");

// Cliente 1 prefere Email
var notification = NotificationFactory.Create("email");
notification.SendOrderConfirmation("cliente@email.com", "12345");
Console.WriteLine();

// Cliente 2 prefere SMS
notification = NotificationFactory.Create("sms");
notification.SendOrderConfirmation("+5511999999999", "12346");
Console.WriteLine();

// Cliente 3 prefere Push
notification = NotificationFactory.Create("push");
notification.SendShippingUpdate("device-token-abc123", "BR123456789");
Console.WriteLine();

// Cliente 4 prefere WhatsApp
notification = NotificationFactory.Create("whatsapp");
notification.SendPaymentReminder("+5511888888888", 150.00m);
Console.WriteLine();

// Cliente 5 prefere Telegram
notification = NotificationFactory.Create("telegram");
notification.SendPaymentReminder("+5511777777777", 450.00m);
Console.WriteLine();

// Cliente 6 prefere Slack
notification = NotificationFactory.Create("slack");
notification.SendShippingUpdate("D123ABC456", "BR102030405");