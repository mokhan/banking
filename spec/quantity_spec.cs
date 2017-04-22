using Xunit;

public class QuantitySpec
{
  public QuantitySpec()
  {
  }

  [Fact]
  public void it_is_equal()
  {
    Assert.Equal(new Quantity(100, Currency.CAD), new Quantity(100, Currency.CAD));
  }

  [Fact]
  public void it_is_not_equal()
  {
    Assert.NotEqual(new Quantity(100, Currency.CAD), new Quantity(200, Currency.CAD));
  }
}
