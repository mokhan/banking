public class Currency : UnitOfMeasure
{
  public static Currency CAD = new Currency("CAD");
  public static Currency USD = new Currency("USD");
  public static Currency MXN = new Currency("MXN");

  string pneumonic;

  public Currency(string pneumonic)
  {
    this.pneumonic = pneumonic;
  }

  public decimal convert(decimal amount, UnitOfMeasure currency)
  {
    if (currency == Currency.USD) {
      return amount * 2;
    }

    if (currency == Currency.MXN) {
      return amount / 10;
    }

    return amount;
  }

  public override string ToString()
  {
    return this.pneumonic;
  }
}
