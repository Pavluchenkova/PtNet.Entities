using System;

namespace PtNet.Entities
{
    public class Dimension
    {
        public decimal Value { get; set; }

        public LengthUnits Units { get; }

        public Dimension() : this(0.0m, LengthUnits.Mm)
        {
        }

        public Dimension(decimal value, LengthUnits units)
        {
            Value = value;
            Units = units;
        }

        public override string ToString()
        {
            return $"{Value} {Units}";
        }

        public override bool Equals(object obj)
        {
            // TODO: Implement Equals() method
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // TODO: Implement GetHashCode() method
            return base.GetHashCode();
        }

        public static Dimension operator +(Dimension x, Dimension y)
        {
            // TODO: Implement + operator
            throw new NotImplementedException();
        }

        public static Dimension operator -(Dimension x, Dimension y)
        {
            // TODO: Implement - operator
            throw new NotImplementedException();
        }

        public static Dimension operator *(Dimension x, Dimension y)
        {
            // TODO: Implement * operator
            throw new NotImplementedException();
        }

        public static Dimension operator /(Dimension x, Dimension y)
        {
            // TODO: Implement / operator
            throw new NotImplementedException();
        }

        public static Dimension operator ==(Dimension x, Dimension y)
        {
            // TODO: Implement == operator
            throw new NotImplementedException();
        }

        public static Dimension operator !=(Dimension x, Dimension y)
        {
            // TODO: Implement != operator
            throw new NotImplementedException();
        }

        public static Dimension operator >(Dimension x, Dimension y)
        {
            // TODO: Implement > operator
            throw new NotImplementedException();
        }

        public static Dimension operator <(Dimension x, Dimension y)
        {
            // TODO: Implement < operator
            throw new NotImplementedException();
        }

        public static Dimension operator >=(Dimension x, Dimension y)
        {
            // TODO: Implement >= operator
            throw new NotImplementedException();
        }

        public static Dimension operator <=(Dimension x, Dimension y)
        {
            // TODO: Implement <= operator
            throw new NotImplementedException();
        }
    }
}
