namespace MainApp;

public class PayPalPayment : IPayment
{
    public void Pay(Double amount)
    {
        Console.WriteLine($"Lyckades betala ${amount} till köparen med Paypal.");
    }
}
