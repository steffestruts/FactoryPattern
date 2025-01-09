using MainApp;

IPayment payment = PaymentFactory.create(PaymentMethod.ApplePay);
payment.Pay(1000.0);

/// <summary>
/// Använde den här videon i denna egna övning: https://www.youtube.com/watch?v=ub3P8c87cwk
/// </summary>

Console.ReadKey();