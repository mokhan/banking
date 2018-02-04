using Xunit;

public class CurrencySpec
{
  [Fact]
  public void converts_USD_to_CAD()
  {
    var result = Currency.CAD.convert(0.50M, Currency.USD);
    Assert.Equal(1, result);
  }

  [Fact]
  public void converts_MXN_to_CAD()
  {
    var result = Currency.CAD.convert(10.0M, Currency.MXN);
    Assert.Equal(1.0M, result);
  }

  [Fact]
  public void converts_CAD_to_CAD()
  {
    var result = Currency.CAD.convert(10.0M, Currency.CAD);
    Assert.Equal(10.0M, result);
  }
}
