namespace MainApp;

public class CreditCardPayment : IPayment
{
    public void Pay(Double amount)
    {
        Console.WriteLine($"Lyckades betala ${amount} till köparen med kreditkort.");
    }
}
