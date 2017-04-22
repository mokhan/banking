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
}
