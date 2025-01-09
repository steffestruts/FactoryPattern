namespace MainApp;

public class GooglePayPayment : IPayment
{
    public void Pay(Double amount)
    {
        Console.WriteLine($"Lyckades betala ${amount} till köparen med GooglePay.");
    }
}
