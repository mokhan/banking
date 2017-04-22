using System.Collections.Generic;

public class Account
{
  IList<Entry> entries;

  public Account()
  {
    this.entries = new List<Entry>();
  }

  public void deposit(Quantity quantity)
  {
    this.entries.Add(new Deposit(quantity));
  }

  public Quantity balance()
  {
    Quantity total = new Quantity(0, Currency.CAD);
    foreach (var entry in this.entries)
    {
      total = entry.ApplyTo(total);
    }
    return total;
  }
}

public interface Entry
{
  Quantity ApplyTo(Quantity quantity);
}

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
