using Xunit;

namespace Acceptance
{
  public class AccountSpec
  {
    [Fact]
    public void case_two()
    {
      var account = new Account();
      account.deposit(new Quantity(35000.0, Currency.CAD));

      account.withdraw(new Quantity(5000.0, Currency.MXN));
      account.withdraw(new Quantity(12500.0, Currency.USD));
      account.deposit(new Quantity(300.0, Currency.CAD));

      Assert.Equal(new Quantity(9800, Currency.CAD), account.balance());
    }
  }
}
