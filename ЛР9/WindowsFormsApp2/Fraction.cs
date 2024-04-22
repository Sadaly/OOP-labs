using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;


namespace WindowsFormsApp2
{
    [Serializable]
    class Fraction: IComparable
    {
        uint numerator;
        uint denominator;
        int integer_part;
        public Fraction(int integer_part, uint numerator, uint denominator)
        {
            this.integer_part = integer_part;
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public uint Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public uint Denominator
            { get { return denominator; } set { denominator = value; } }
        public int IntegerPart
            { get { return integer_part; } set { integer_part = value; } }
        public int CompareTo(object obj)
        {
            Fraction fraction = (Fraction)obj;
            if (numerator > fraction.numerator)
                return 1;
            else if (numerator == fraction.numerator)
                return 0;
            return -1;
        }
        public bool Equal(Fraction obj)
        {
            if ((numerator == obj.numerator) && (denominator == obj.denominator) && (integer_part == obj.integer_part))
                return true;
            return false;
        }
        public bool IsImproper()
        {
            if (numerator > denominator)
                return true;
            return false;
        }
        public void MakeProper()
        {
            integer_part += (int)(numerator / denominator);
            numerator = numerator % denominator;
            
        }
        public string Print()
        {
            return "("+ integer_part.ToString() + ", " + numerator.ToString() + ", " + denominator.ToString() + ")";
        }

    }
}
