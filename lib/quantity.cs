public class Quantity
{
  decimal amount;
  UnitOfMeasure unit;

  public Quantity(decimal amount, UnitOfMeasure unit)
  {
    this.amount = amount;
    this.unit = unit;
  }

  public Quantity convert_to(UnitOfMeasure unit)
  {
    return new Quantity(unit.convert(this.amount, this.unit), unit);
  }

  public Quantity plus(Quantity other)
  {
    var converted = other.convert_to(this.unit);
    return new Quantity(this.amount + converted.amount, this.unit);
  }

  public Quantity subtract(Quantity other)
  {
    var converted = other.convert_to(this.unit);
    return new Quantity(this.amount - converted.amount, this.unit);
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

  public override string ToString()
  {
    return this.amount.ToString() + " " + this.unit.ToString();
  }
}
