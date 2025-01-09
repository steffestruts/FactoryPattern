namespace MainApp;

public class ApplePayPayment : IPayment
{
    public void Pay(Double amount)
    {
        Console.WriteLine($"Lyckades betala ${amount} till köparen med Apple Pay.");
    }
}
