public class Deposit : Entry
{
  Quantity quantity;

  public Deposit(Quantity quantity)
  {
    this.quantity = quantity;
  }

  public Quantity apply_to(Quantity quantity)
  {
    return quantity.plus(this.quantity);
  }
}
