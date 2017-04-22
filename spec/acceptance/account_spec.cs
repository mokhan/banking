using Xunit;

namespace Acceptance
{
  public class AccountSpec
  {
    [Fact]
    public void case_one()
    {
      var account = new Account();

      account.deposit(new Quantity(100, Currency.CAD));
      account.deposit(new Quantity(300, Currency.USD));

      Assert.Equal(new Quantity(700, Currency.CAD), account.balance());
    }

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

    [Fact]
    public void case_three()
    {
      var account_1010 = new Account();
      var account_5500 = new Account();

      account_1010.deposit(new Quantity(7425, Currency.CAD));
      account_5500.deposit(new Quantity(15000, Currency.CAD));
      account_5500.withdraw(new Quantity(5000, Currency.CAD));
      account_1010.transfer(new Quantity(7300, Currency.CAD), account_5500);
      account_1010.deposit(new Quantity(13726, Currency.MXN));

      Assert.Equal(new Quantity(1497.60, Currency.CAD), account_1010.balance());
      Assert.Equal(new Quantity(17300.00, Currency.CAD), account_5500.balance());
    }

    [Fact]
    public void case_four()
    {
      var account_0123 = new Account();
      var account_0456 = new Account();

      account_0123.deposit(new Quantity(150, Currency.CAD));
      account_0456.deposit(new Quantity(65000, Currency.CAD));

      account_0123.withdraw(new Quantity(70, Currency.USD));
      account_0456.deposit(new Quantity(23789, Currency.USD));

      account_0456.transfer(new Quantity(23.75, Currency.CAD), account_0123);

      Assert.Equal(new Quantity(33.75, Currency.CAD), account_0123.balance());
      Assert.Equal(new Quantity(112554.25, Currency.CAD), account_0456.balance());
    }
  }
}
