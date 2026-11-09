using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class AbstractFpCurve : ECCurve
    {
        // Methods
        protected AbstractFpCurve(Org.BouncyCastle.Math.BigInteger q)
        {
            Org.BouncyCastle.Math.Field.IFiniteField val_1 = Org.BouncyCastle.Math.Field.FiniteFields.GetPrimeField(characteristic:  q);
        }
        public override bool IsValidFieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_6;
            if((x != null) && ((x.SignValue & 2147483648) == 0))
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            val_6 = (x.CompareTo(value:  this.Field.Characteristic)) >> 31;
            return (bool)val_6;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, Org.BouncyCastle.Math.BigInteger X1)
        {
            var val_6;
            Org.BouncyCastle.Math.EC.ECFieldElement val_1 = this.A;
            Org.BouncyCastle.Math.EC.ECFieldElement val_3 = this.B;
            val_6 = this.Configure();
            if(val_6 != null)
            {
                    var val_4 = (yTilde == 1) ? 1 : 0;
                val_4 = val_4 ^ val_6;
                if((val_4 & 1) == 0)
            {
                goto typeof(Org.BouncyCastle.Math.EC.AbstractFpCurve).__il2cppRuntimeField_1F8;
            }
            
                val_6 = val_6;
            }
            else
            {
                    System.ArgumentException val_5 = new System.ArgumentException(message:  "Invalid point compression");
            }
        
        }
    
    }

}
