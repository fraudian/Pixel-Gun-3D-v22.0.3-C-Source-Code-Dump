using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public abstract class AbstractF2mCurve : ECCurve
    {
        // Fields
        private Org.BouncyCastle.Math.BigInteger[] si;
        
        // Properties
        public virtual bool IsKoblitz { get; }
        
        // Methods
        public static Org.BouncyCastle.Math.BigInteger Inverse(int m, int[] ks, Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.EC.LongArray val_2 = new Org.BouncyCastle.Math.EC.LongArray(bigInt:  x).ModInverse(m:  m, ks:  ks);
            if(val_2 != null)
            {
                    return val_2.ToBigInteger();
            }
            
            return val_2.ToBigInteger();
        }
        private static Org.BouncyCastle.Math.Field.IFiniteField BuildField(int m, int k1, int k2, int k3)
        {
            System.Int32[] val_4;
            int val_5;
            int val_6;
            string val_8;
            if(k1 == 0)
            {
                goto label_1;
            }
            
            if(k2 == 0)
            {
                goto label_2;
            }
            
            if(k2 <= k1)
            {
                goto label_3;
            }
            
            if(k3 <= k2)
            {
                goto label_4;
            }
            
            val_4 = new int[5];
            val_5 = val_1.Length;
            if(val_5 <= 1)
            {
                    val_5 = val_1.Length;
            }
            
            val_4[0] = k1;
            if(val_5 <= 2)
            {
                    val_5 = val_1.Length;
            }
            
            val_4[1] = k2;
            if(val_5 <= 3)
            {
                    val_5 = val_1.Length;
            }
            
            val_4[1] = k3;
            val_4[2] = m;
            return Org.BouncyCastle.Math.Field.FiniteFields.GetBinaryExtensionField(exponents:  int[] val_2 = new int[3]);
            label_2:
            if(k3 != 0)
            {
                goto label_11;
            }
            
            val_4 = val_2;
            val_6 = val_2.Length;
            if(val_6 <= 1)
            {
                    val_6 = val_2.Length;
            }
            
            val_4[0] = k1;
            val_4[1] = m;
            return Org.BouncyCastle.Math.Field.FiniteFields.GetBinaryExtensionField(exponents:  val_2);
            label_1:
            val_8 = "k1 must be > 0";
            goto label_19;
            label_3:
            val_8 = "k2 must be > k1";
            goto label_19;
            label_4:
            val_8 = "k3 must be > k2";
            goto label_19;
            label_11:
            val_8 = "k3 must be 0 if k2 == 0";
            label_19:
            null = new System.ArgumentException(message:  val_8);
        }
        protected AbstractF2mCurve(int m, int k1, int k2, int k3)
        {
            Org.BouncyCastle.Math.Field.IFiniteField val_1 = Org.BouncyCastle.Math.EC.AbstractF2mCurve.BuildField(m:  m, k1:  k1, k2:  k2, k3:  k3);
        }
        public override bool IsValidFieldElement(Org.BouncyCastle.Math.BigInteger x)
        {
            var val_4;
            if(x != null)
            {
                    if((x.SignValue & 2147483648) == 0)
            {
                    var val_3 = (x.BitLength <= this) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public override Org.BouncyCastle.Math.EC.ECPoint CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y, bool withCompression)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = withCompression;
            val_10 = this;
            if((this.CoordinateSystem - 5) > 1)
            {
                goto label_6;
            }
            
            this.SetPreCompInfo(point:  public System.Void Org.BouncyCastle.Math.EC.ECCurve::SetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo), name:  typeof(Org.BouncyCastle.Math.EC.AbstractF2mCurve).__il2cppRuntimeField_180, preCompInfo:  withCompression);
            val_7 = this;
            if((val_7 & 1) == 0)
            {
                goto label_4;
            }
            
            val_7 = val_10;
            Org.BouncyCastle.Math.EC.ECFieldElement val_3 = this.B;
            if((this.B & 1) != 0)
            {
                goto label_6;
            }
            
            System.ArgumentException val_5 = null;
            val_8 = val_5;
            val_5 = new System.ArgumentException();
            val_11 = 1152921544063940736;
            val_9 = public Org.BouncyCastle.Math.EC.ECPoint Org.BouncyCastle.Math.EC.AbstractF2mCurve::CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y, bool withCompression);
            label_4:
            val_10 = this.丙丐丕丆丒丂丆东丐(丈丏万丄丒业丅丒一:  new System.Collections.Generic.KeyValuePair<System.String, System.Object>() {Value = this});
            label_6:
            System.ArgumentException val_7 = val_8 & 1;
            goto typeof(Org.BouncyCastle.Math.EC.AbstractF2mCurve).__il2cppRuntimeField_1F8;
        }
        protected override Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, Org.BouncyCastle.Math.BigInteger X1)
        {
            var val_10;
            var val_11;
            var val_12;
            this.SetPreCompInfo(point:  public System.Void Org.BouncyCastle.Math.EC.ECCurve::SetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name, Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo), name:  typeof(Org.BouncyCastle.Math.EC.AbstractF2mCurve).__il2cppRuntimeField_180, preCompInfo:  null);
            if((this & 1) == 0)
            {
                goto label_2;
            }
            
            val_10 = this.B;
            val_11 = val_10;
            goto label_4;
            label_2:
            Org.BouncyCastle.Math.EC.ECFieldElement val_4 = this.A;
            val_12 = this.SolveQuadradicEquation(beta:  this.CreatePoint(x:  this.B, y:  public Org.BouncyCastle.Math.EC.ECPoint Org.BouncyCastle.Math.EC.ECCurve::CreatePoint(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger y)));
            if(val_12 == null)
            {
                goto label_14;
            }
            
            var val_6 = (yTilde == 1) ? 1 : 0;
            val_6 = val_6 ^ val_12;
            if((val_6 & 1) != 0)
            {
                    val_12 = val_12;
            }
            
            val_10 = this.CoordinateSystem - 5;
            if(val_10 <= 1)
            {
                
            }
            
            val_11 = val_12;
            label_4:
            if(val_11 == null)
            {
                goto label_14;
            }
            
            goto typeof(Org.BouncyCastle.Math.EC.AbstractF2mCurve).__il2cppRuntimeField_1F8;
            label_14:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Invalid point compression");
        }
        private Org.BouncyCastle.Math.EC.ECFieldElement SolveQuadradicEquation(Org.BouncyCastle.Math.EC.ECFieldElement beta)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_7;
            var val_8;
            if((beta & 1) != 0)
            {
                    val_4 = beta;
                return (Org.BouncyCastle.Math.EC.ECFieldElement)val_4;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = this;
            label_18:
            Org.BouncyCastle.Math.BigInteger val_1 = Org.BouncyCastle.Math.BigInteger.Arbitrary(sizeInBits:  802737472);
            val_7 = 1;
            val_8 = beta;
            val_4 = val_3;
            goto label_8;
            label_13:
            val_4 = this.Configure();
            val_8 = val_8;
            val_7 = 2;
            label_8:
            if(val_7 < this)
            {
                goto label_13;
            }
            
            if((val_8 & 1) == 0)
            {
                goto label_14;
            }
            
            if((val_4 & 1) != 0)
            {
                goto label_18;
            }
            
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_4;
            label_14:
            val_4 = 0;
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_4;
        }
        internal virtual Org.BouncyCastle.Math.BigInteger[] GetSi()
        {
            var val_3;
            var val_4;
            if(this.si != null)
            {
                    return (Org.BouncyCastle.Math.BigInteger[])this.si;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(this.si != null)
            {
                    val_3 = 0;
                val_4 = 0;
            }
            else
            {
                    val_3 = 0;
                val_4 = 0;
                this.si = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetSi(curve:  this);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_3 != 1)
            {
                    return (Org.BouncyCastle.Math.BigInteger[])this.si;
            }
            
            if(val_4 == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger[])this.si;
            }
            
            return (Org.BouncyCastle.Math.BigInteger[])this.si;
        }
        public virtual bool get_IsKoblitz()
        {
            var val_1;
            if(((X8 == 0) || (X8 == 0)) || ((X20 & 1) == 0))
            {
                goto label_3;
            }
            
            if((X20 & 1) == 0)
            {
                goto label_5;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_3:
            val_1 = 0;
            return (bool)val_1;
            label_5:
            if(this != null)
            {
                    return this.GetPreCompInfo(point:  public Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Org.BouncyCastle.Math.EC.ECCurve::GetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name), name:  public Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Org.BouncyCastle.Math.EC.ECCurve::GetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name));
            }
            
            return this.GetPreCompInfo(point:  public Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Org.BouncyCastle.Math.EC.ECCurve::GetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name), name:  public Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Org.BouncyCastle.Math.EC.ECCurve::GetPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint point, string name));
        }
    
    }

}
