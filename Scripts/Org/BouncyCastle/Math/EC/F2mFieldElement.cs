using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class F2mFieldElement : ECFieldElement
    {
        // Fields
        public const int Gnb = 1;
        public const int Tpb = 2;
        public const int Ppb = 3;
        private int representation;
        private int m;
        private int[] ks;
        private Org.BouncyCastle.Math.EC.LongArray x;
        
        // Properties
        public override int BitLength { get; }
        public override bool IsOne { get; }
        public override bool IsZero { get; }
        public override string FieldName { get; }
        public override int FieldSize { get; }
        public int Representation { get; }
        public int M { get; }
        public int K1 { get; }
        public int K2 { get; }
        public int K3 { get; }
        
        // Methods
        public F2mFieldElement(int m, int k1, int k2, int k3, Org.BouncyCastle.Math.BigInteger x)
        {
            int val_10;
            System.Int32[] val_11;
            int val_12;
            var val_14;
            string val_16;
            val_10 = k1;
            val_1 = new System.Object();
            if(((val_1 == null) || ((val_1.SignValue & 2147483648) != 0)) || (val_1.BitLength > m))
            {
                goto label_3;
            }
            
            if((k2 | k3) == 0)
            {
                goto label_4;
            }
            
            if(k2 >= k3)
            {
                goto label_5;
            }
            
            if(k2 <= 0)
            {
                goto label_6;
            }
            
            this.representation = 3;
            val_11 = new int[3];
            val_12 = val_5.Length;
            if(val_12 == 0)
            {
                    val_12 = val_5.Length;
            }
            
            val_11[0] = val_10;
            if(val_12 <= 1)
            {
                    val_12 = val_5.Length;
            }
            
            val_11[0] = k2;
            val_10 = k3;
            goto label_11;
            label_4:
            this.representation = 2;
            val_11 = new int[1];
            label_11:
            mem2[0] = val_10;
            this.ks = val_11;
            this.m = m;
            this.x = new Org.BouncyCastle.Math.EC.LongArray(bigInt:  Org.BouncyCastle.Math.BigInteger val_1 = x);
            return;
            label_3:
            System.ArgumentException val_8 = null;
            val_14 = val_8;
            val_8 = new System.ArgumentException(message:  "value invalid in F2m field element", paramName:  "x");
            goto label_14;
            label_5:
            val_16 = "k2 must be smaller than k3";
            goto label_15;
            label_6:
            System.ArgumentException val_9 = null;
            val_16 = "k2 must be larger than 0";
            label_15:
            val_14 = val_9;
            val_9 = new System.ArgumentException(message:  val_16);
            label_14:
        }
        public F2mFieldElement(int m, int k, Org.BouncyCastle.Math.BigInteger x)
        {
        
        }
        private F2mFieldElement(int m, int[] ks, Org.BouncyCastle.Math.EC.LongArray x)
        {
            val_1 = new System.Object();
            this.m = m;
            this.ks = ks;
            this.x = val_1;
            this.representation = (ks.Length != 1) ? (2 + 1) : 2;
        }
        public override int get_BitLength()
        {
            if(this.x != null)
            {
                    return this.x.Degree();
            }
            
            return this.x.Degree();
        }
        public override bool get_IsOne()
        {
            if(this.x != null)
            {
                    return this.x.IsOne();
            }
            
            return this.x.IsOne();
        }
        public override bool get_IsZero()
        {
            if(this.x != null)
            {
                    return this.x.IsZero();
            }
            
            return this.x.IsZero();
        }
        public override bool TestBitZero()
        {
            if(this.x != null)
            {
                    return this.x.TestBitZero();
            }
            
            return this.x.TestBitZero();
        }
        public override Org.BouncyCastle.Math.BigInteger ToBigInteger()
        {
            if(this.x != null)
            {
                    return this.x.ToBigInteger();
            }
            
            return this.x.ToBigInteger();
        }
        public override string get_FieldName()
        {
            return "F2m";
        }
        public override int get_FieldSize()
        {
            return (int)this.m;
        }
        public static void CheckFieldElements(Org.BouncyCastle.Math.EC.ECFieldElement a, Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            string val_5;
            if((a == null) || (b == null))
            {
                goto label_6;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  35261, b:  b)) == false)
            {
                goto label_9;
            }
            
            return;
            label_6:
            val_5 = "Field elements are not both instances of F2mFieldElement";
            goto label_11;
            label_9:
            val_5 = "Field elements are not elements of the same field F2m";
            label_11:
             = new System.ArgumentException(message:  null);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Add(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            var val_5 = 0;
            Org.BouncyCastle.Math.EC.LongArray val_1 = this.x.Copy();
            if(b != null)
            {
                    val_1.AddShiftedByWords(other:  b, words:  0);
                return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  val_1);
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  this.x.AddOne());
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Subtract(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            goto typeof(Org.BouncyCastle.Math.EC.F2mFieldElement).__il2cppRuntimeField_198;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Multiply(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  this.x.ModMultiply(other:  b, m:  this.m, ks:  this.ks));
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            goto typeof(Org.BouncyCastle.Math.EC.F2mFieldElement).__il2cppRuntimeField_268;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement b, Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.EC.LongArray val_10;
            int val_11;
            System.Int32[] val_12;
            val_10 = this.x.Multiply(other:  b, m:  this.m, ks:  this.ks);
            Org.BouncyCastle.Math.EC.LongArray val_7 = x.Multiply(other:  X24, m:  this.m, ks:  this.ks);
            if((val_10 == this.x) || (val_10 == b))
            {
                goto label_19;
            }
            
            if(val_10 == null)
            {
                goto label_20;
            }
            
            label_23:
            val_10.AddShiftedByWords(other:  val_7, words:  0);
            val_11 = this.m;
            val_12 = this.ks;
            goto label_21;
            label_19:
            val_10 = val_10.Copy();
            if(val_10 != null)
            {
                goto label_23;
            }
            
            label_20:
            0.AddShiftedByWords(other:  val_7, words:  0);
            val_11 = this.m;
            val_12 = this.ks;
            label_21:
            val_10.Reduce(m:  val_11, ks:  val_12);
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  val_10);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Divide(Org.BouncyCastle.Math.EC.ECFieldElement b)
        {
            if(b == null)
            {
                
            }
        
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Negate()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Square()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  this.x.ModSquare(m:  this.m, ks:  this.ks));
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            goto typeof(Org.BouncyCastle.Math.EC.F2mFieldElement).__il2cppRuntimeField_288;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(Org.BouncyCastle.Math.EC.ECFieldElement x, Org.BouncyCastle.Math.EC.ECFieldElement y)
        {
            Org.BouncyCastle.Math.EC.LongArray val_9;
            int val_10;
            System.Int32[] val_11;
            val_9 = this.x.Square(m:  this.m, ks:  this.ks);
            Org.BouncyCastle.Math.EC.LongArray val_6 = x.Multiply(other:  X23, m:  this.m, ks:  this.ks);
            if(val_9 == this.x)
            {
                goto label_13;
            }
            
            if(val_9 == null)
            {
                goto label_14;
            }
            
            label_17:
            val_9.AddShiftedByWords(other:  val_6, words:  0);
            val_10 = this.m;
            val_11 = this.ks;
            goto label_15;
            label_13:
            val_9 = this.x.Copy();
            if(val_9 != null)
            {
                goto label_17;
            }
            
            label_14:
            0.AddShiftedByWords(other:  val_6, words:  0);
            val_10 = this.m;
            val_11 = this.ks;
            label_15:
            val_9.Reduce(m:  val_10, ks:  val_11);
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  val_9);
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
        {
            System.Int32[] val_3;
            int val_4;
            var val_5;
            val_4 = pow;
            val_5 = this;
            if(val_4 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
            }
            
            val_3 = this.ks;
            val_4 = this.x.ModSquareN(n:  val_4, m:  this.m, ks:  val_3);
            Org.BouncyCastle.Math.EC.F2mFieldElement val_2 = null;
            val_5 = val_2;
            val_2 = new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  val_3, x:  val_4);
            return (Org.BouncyCastle.Math.EC.ECFieldElement)val_5;
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Invert()
        {
            return (Org.BouncyCastle.Math.EC.ECFieldElement)new Org.BouncyCastle.Math.EC.F2mFieldElement(m:  this.m, ks:  this.ks, x:  this.x.ModInverse(m:  this.m, ks:  this.ks));
        }
        public override Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
        {
            if(this.x.IsZero() == true)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            if(this.x.IsOne() != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECFieldElement)this;
            }
            
            int val_3 = this.m - 1;
            goto typeof(Org.BouncyCastle.Math.EC.F2mFieldElement).__il2cppRuntimeField_298;
        }
        public int get_Representation()
        {
            return (int)this.representation;
        }
        public int get_M()
        {
            return (int)this.m;
        }
        public int get_K1()
        {
            return (int)this.ks[0];
        }
        public int get_K2()
        {
            System.Int32[] val_1;
            int val_2;
            val_1 = this;
            if(this.ks.Length < 2)
            {
                    val_2 = 0;
                return val_2;
            }
            
            val_1 = this.ks;
            val_2 = val_1[1];
            return val_2;
        }
        public int get_K3()
        {
            System.Int32[] val_1;
            int val_2;
            val_1 = this;
            if(this.ks.Length < 3)
            {
                    val_2 = 0;
                return val_2;
            }
            
            val_1 = this.ks;
            val_2 = val_1[2];
            return val_2;
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        public virtual bool Equals(Org.BouncyCastle.Math.EC.F2mFieldElement other)
        {
            if(this.m != other.m)
            {
                    return false;
            }
            
            if(this.representation != other.representation)
            {
                    return false;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.ks, b:  other.ks)) == false)
            {
                    return false;
            }
            
            other = ???;
            goto typeof(Org.BouncyCastle.Math.EC.LongArray).__il2cppRuntimeField_168;
        }
        public override int GetHashCode()
        {
            int val_1 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.ks);
            val_1 = this.m ^ this.x ^ val_1;
            return (int)val_1;
        }
    
    }

}
