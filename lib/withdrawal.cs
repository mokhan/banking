public class Withdrawal : Entry
{
  Quantity quantity;

  public Withdrawal(Quantity quantity)
  {
    this.quantity = quantity;
  }

  public Quantity apply_to(Quantity quantity)
  {
    return quantity.subtract(this.quantity);
  }
}
