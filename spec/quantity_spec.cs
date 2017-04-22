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
}

public class CurrencySpec
{
  [Fact]
  public void converts_USD_to_CAD()
  {
    var result = Currency.CAD.convert(0.50, Currency.USD);
    Assert.Equal(1, result);
  }

  [Fact]
  public void converts_MXN_to_CAD()
  {
    var result = Currency.CAD.convert(10.0, Currency.MXN);
    Assert.Equal(1.0, result);
  }

  [Fact]
  public void converts_CAD_to_CAD()
  {
    var result = Currency.CAD.convert(10.0, Currency.CAD);
    Assert.Equal(10.0, result);
  }
}
