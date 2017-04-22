using Xunit;

public class QuantitySpec
{
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

  [Fact]
  public void it_is_not_an_equal_when_different_currencies()
  {
    Assert.NotEqual(new Quantity(100, Currency.CAD), new Quantity(100, Currency.USD));
  }

  [Fact]
  public void it_converts_USD_to_CAD()
  {
    var result = new Quantity(0.50, Currency.USD).convert_to(Currency.CAD);
    Assert.Equal(new Quantity(1.0, Currency.CAD), result);
  }

  [Fact]
  public void it_converts_MXN_to_CAD()
  {
    var result = new Quantity(10, Currency.MXN).convert_to(Currency.CAD);
    Assert.Equal(new Quantity(1.0, Currency.CAD), result);
  }

  [Fact]
  public void it_adds_to_quantities()
  {
    var result = new Quantity(100, Currency.CAD).plus(new Quantity(100, Currency.CAD));
    Assert.Equal(new Quantity(200, Currency.CAD), result);
  }

  [Fact]
  public void it_adds_CAD_and_USD()
  {
    var result = new Quantity(100, Currency.CAD).plus(new Quantity(50, Currency.USD));
    Assert.Equal(new Quantity(200, Currency.CAD), result);
  }
}
