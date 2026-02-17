namespace FactoryMethod.Notification
{
    public interface INotification
    {
        void Send();
        void SendOrderConfirmation(string recipient, string orderNumber);
        void SendShippingUpdate(string recipient, string trackingCode);
        void SendPaymentReminder(string recipient, decimal amount);
    }
}
