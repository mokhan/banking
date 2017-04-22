public class Quantity
{
  double amount;
  UnitOfMeasure unit;

  public Quantity(double amount, UnitOfMeasure unit)
  {
    this.amount = amount;
    this.unit = unit;
  }

  public bool Equals(Quantity other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return other.amount.Equals(amount) && Equals(other.unit, unit);
  }

  public override bool Equals(object obj)
  {
    if (ReferenceEquals(null, obj)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != typeof (Quantity)) return false;
    return Equals((Quantity) obj);
  }

  public override int GetHashCode()
  {
    unchecked
    {
      return (amount.GetHashCode()*397) ^ (unit != null ? unit.GetHashCode() : 0);
    }
  }
}

public interface UnitOfMeasure
{
}

public class Currency : UnitOfMeasure
{
  public static Currency CAD = new Currency("CAD");
  public static Currency USD = new Currency("USD");

  string pneumonic;

  public Currency(string pneumonic)
  {
    this.pneumonic = pneumonic;
  }
}
