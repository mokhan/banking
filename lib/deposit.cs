public class Deposit : Entry
{
  Quantity quantity;

  public Deposit(Quantity quantity)
  {
    this.quantity = quantity;
  }

  public Quantity ApplyTo(Quantity quantity)
  {
    return quantity.plus(this.quantity);
  }
}
