using Xunit;

public class AccountSpec
{
  [Fact]
  public void it_increases_the_balance_after_a_deposit()
  {
    var account = new Account();

    account.deposit(new Quantity(100, Currency.CAD));
    account.deposit(new Quantity(300, Currency.USD));

    Assert.Equal(new Quantity(700, Currency.CAD), account.balance());
  }

  [Fact]
  public void it_decreases_the_balance_after_a_withdrawal()
  {
    var account = new Account();
    account.deposit(new Quantity(100.00M, Currency.CAD));

    account.withdraw(new Quantity(50.0M, Currency.CAD));

    Assert.Equal(new Quantity(50.0M, Currency.CAD), account.balance());
  }

  [Fact]
  public void it_transfers_money_from_one_account_to_another()
  {
    var account_a = new Account();
    var account_b = new Account();

    account_a.deposit(new Quantity(100, Currency.CAD));
    account_b.deposit(new Quantity(100, Currency.CAD));

    account_a.transfer(new Quantity(50, Currency.CAD), account_b);

    Assert.Equal(new Quantity(50, Currency.CAD), account_a.balance());
    Assert.Equal(new Quantity(150, Currency.CAD), account_b.balance());
  }
}
