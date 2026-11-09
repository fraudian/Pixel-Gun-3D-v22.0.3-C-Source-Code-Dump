using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Abc
{
    internal class SimpleBigDecimal
    {
        // Fields
        private readonly Org.BouncyCastle.Math.BigInteger bigInt;
        private readonly int scale;
        
        // Properties
        public int IntValue { get; }
        public long LongValue { get; }
        public int Scale { get; }
        
        // Methods
        public static Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal GetInstance(Org.BouncyCastle.Math.BigInteger val, int scale)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  val.ShiftLeft(n:  scale), scale:  scale);
        }
        public SimpleBigDecimal(Org.BouncyCastle.Math.BigInteger bigInt, int scale)
        {
            if((scale & 2147483648) == 0)
            {
                    this.bigInt = bigInt;
                this.scale = scale;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "scale may not be negative");
        }
        private SimpleBigDecimal(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal limBigDec)
        {
            if(limBigDec != null)
            {
                    this.bigInt = limBigDec.bigInt;
            }
            else
            {
                    this.bigInt = 11993091;
            }
            
            this.scale = limBigDec.scale;
        }
        private void CheckScale(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
        {
            if(this.scale == b.scale)
            {
                    return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "Only SimpleBigDecimal of same scale allowed in arithmetic operations");
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal AdjustScale(int newScale)
        {
            if((newScale & 2147483648) == 0)
            {
                    if(this.scale == newScale)
            {
                    return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)this;
            }
            
                newScale = newScale - this.scale;
                Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_2 = null;
                this = val_2;
                val_2 = new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.ShiftLeft(n:  newScale), scale:  newScale);
                return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)this;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "scale may not be negative");
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Add(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
        {
            this.CheckScale(b:  b);
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Add(value:  b.bigInt), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Add(Org.BouncyCastle.Math.BigInteger b)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Add(value:  b.ShiftLeft(n:  this.scale)), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Negate()
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Negate(), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Subtract(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
        {
            return this.Add(b:  b.Negate());
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Subtract(Org.BouncyCastle.Math.BigInteger b)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Subtract(n:  b.ShiftLeft(n:  this.scale)), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Multiply(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
        {
            this.CheckScale(b:  b);
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Multiply(val:  b.bigInt), scale:  this.scale << 1);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Multiply(Org.BouncyCastle.Math.BigInteger b)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Multiply(val:  b), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Divide(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
        {
            this.CheckScale(b:  b);
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.ShiftLeft(n:  this.scale).Divide(val:  b.bigInt), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Divide(Org.BouncyCastle.Math.BigInteger b)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.Divide(val:  b), scale:  this.scale);
        }
        public Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal ShiftLeft(int n)
        {
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  this.bigInt.ShiftLeft(n:  n), scale:  this.scale);
        }
        public int CompareTo(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val)
        {
            this.CheckScale(b:  val);
            if(this.bigInt != null)
            {
                    return this.bigInt.CompareTo(value:  val.bigInt);
            }
            
            return this.bigInt.CompareTo(value:  val.bigInt);
        }
        public int CompareTo(Org.BouncyCastle.Math.BigInteger val)
        {
            if(this.bigInt != null)
            {
                    return this.bigInt.CompareTo(value:  val.ShiftLeft(n:  this.scale));
            }
            
            return this.bigInt.CompareTo(value:  val.ShiftLeft(n:  this.scale));
        }
        public Org.BouncyCastle.Math.BigInteger Floor()
        {
            if(this.bigInt != null)
            {
                    return this.bigInt.ShiftRight(n:  this.scale);
            }
            
            return this.bigInt.ShiftRight(n:  this.scale);
        }
        public Org.BouncyCastle.Math.BigInteger Round()
        {
            null = null;
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_3 = this.Add(b:  new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  Org.BouncyCastle.Math.BigInteger.One, scale:  1).AdjustScale(newScale:  this.scale));
            if(val_3 != null)
            {
                    return val_3.Floor();
            }
            
            return val_3.Floor();
        }
        public int get_IntValue()
        {
            Org.BouncyCastle.Math.BigInteger val_1 = this.Floor();
            if(val_1 != null)
            {
                    return val_1.IntValue;
            }
            
            return val_1.IntValue;
        }
        public long get_LongValue()
        {
            Org.BouncyCastle.Math.BigInteger val_1 = this.Floor();
            if(val_1 != null)
            {
                    return val_1.LongValue;
            }
            
            return val_1.LongValue;
        }
        public int get_Scale()
        {
            return (int)this.scale;
        }
        public override string ToString()
        {
            string val_19;
            Org.BouncyCastle.Math.BigInteger val_20;
            var val_21;
            var val_22;
            char val_23;
            var val_24;
            Org.BouncyCastle.Math.BigInteger val_25;
            string val_26;
            var val_27;
            if(this.scale == 0)
            {
                goto label_1;
            }
            
            val_19 = this.Floor();
            val_20 = val_19.ShiftLeft(n:  this.scale);
            Org.BouncyCastle.Math.BigInteger val_3 = this.bigInt.Subtract(n:  val_20);
            if((this.bigInt.sign & 2147483648) != 0)
            {
                goto label_5;
            }
            
            label_35:
            if(val_1.sign == 1)
            {
                    val_21 = null;
                val_21 = null;
                val_20 = Org.BouncyCastle.Math.BigInteger.Zero;
                if((val_3 & 1) == 0)
            {
                    val_22 = null;
                val_22 = null;
                val_20 = Org.BouncyCastle.Math.BigInteger.One;
                val_19 = val_19.Add(value:  val_20);
            }
            
            }
            
            char[] val_5 = new char[0];
            string val_6 = val_3.ToString(radix:  2);
            val_23 = val_6.Length;
            int val_8 = this.scale - val_23;
            if(val_8 >= 1)
            {
                    var val_19 = 0;
                val_24 = val_8;
                do
            {
                mem2[0] = 48;
                val_19 = val_19 + 1;
            }
            while(val_24 != val_19);
            
            }
            
            if(val_23 >= 1)
            {
                    var val_20 = 0;
                val_24 = val_23;
                do
            {
                val_23 = val_6.Chars[0];
                int val_10 = val_8 + val_20;
                val_20 = val_20 + 1;
                val_5[((long)(int)(((this.scale - val_7) + 0))) << 1] = val_23;
            }
            while(val_24 != val_20);
            
            }
            
            string val_11 = 0.CreateString(val:  val_5);
            System.Text.StringBuilder val_12 = null;
            val_25 = val_12;
            val_12 = new System.Text.StringBuilder(value:  val_19);
            if(val_25 == null)
            {
                goto label_26;
            }
            
            System.Text.StringBuilder val_13 = val_12.Append(value:  ".");
            val_26 = val_11;
            System.Text.StringBuilder val_14 = val_12.Append(value:  val_26);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
            label_1:
            val_25 = this.bigInt;
            if(val_25 != null)
            {
                goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
            }
            
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
            label_5:
            val_27 = null;
            val_27 = null;
            Org.BouncyCastle.Math.BigInteger val_16 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  this.scale).Subtract(n:  val_3);
            if(val_19 != null)
            {
                goto label_35;
            }
            
            goto label_35;
            label_26:
            System.Text.StringBuilder val_17 = val_12.Append(value:  ".");
            val_26 = val_11;
            System.Text.StringBuilder val_18 = val_12.Append(value:  val_26);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        public override bool Equals(object obj)
        {
            var val_3;
            var val_4;
            if(this != obj)
            {
                    if(obj != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
                val_3 = mem[(System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 16];
                val_3 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 16;
                if((this.bigInt & 1) != 0)
            {
                    var val_2 = (this.scale == ((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24)) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
                val_4 = 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            Org.BouncyCastle.Math.BigInteger val_1 = this.bigInt;
            val_1 = this.scale ^ val_1;
            return (int)val_1;
        }
    
    }

}
