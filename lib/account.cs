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

  public void withdraw(Quantity quantity)
  {
    this.entries.Add(new Withdrawal(quantity));
  }

  public void transfer(Quantity quantity, Account to)
  {
    withdraw(quantity);
    to.deposit(quantity);
  }

  public Quantity balance()
  {
    Quantity total = new Quantity(0, Currency.CAD);
    foreach (var entry in this.entries)
    {
      total = entry.apply_to(total);
    }
    return total;
  }
}
