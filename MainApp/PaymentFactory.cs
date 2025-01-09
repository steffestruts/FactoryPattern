namespace MainApp;

public class PaymentFactory
{
    public static IPayment create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();
            case PaymentMethod.GooglePay:
                return new GooglePayPayment();
            case PaymentMethod.PayPal:
                return new PayPalPayment();
            case PaymentMethod.ApplePay:
                return new ApplePayPayment();
            default:
                throw new NotSupportedException(
                        $"Betalningsmetod {paymentMethod} stöds ej för tillfället!"
                    );
        }
    }
}

/// <summary>
/// Testar summary som Hans tipsade om. Kunde förenkla switchen men låter det vara så kan se mer av det.
/// Nedanför är en förenklad version av förenklingen som jag tog med.
/// PaymentMethod.CreditCard => new CreditCardPayment(),
/// </summary>
