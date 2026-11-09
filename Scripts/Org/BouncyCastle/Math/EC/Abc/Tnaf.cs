using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Abc
{
    internal class Tnaf
    {
        // Fields
        private static readonly Org.BouncyCastle.Math.BigInteger MinusOne;
        private static readonly Org.BouncyCastle.Math.BigInteger MinusTwo;
        private static readonly Org.BouncyCastle.Math.BigInteger MinusThree;
        private static readonly Org.BouncyCastle.Math.BigInteger Four;
        public const sbyte Width = 4;
        public const sbyte Pow2Width = 16;
        public static readonly Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha0;
        public static readonly sbyte[][] Alpha0Tnaf;
        public static readonly Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha1;
        public static readonly sbyte[][] Alpha1Tnaf;
        
        // Methods
        public static Org.BouncyCastle.Math.BigInteger Norm(sbyte mu, Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
        {
            var val_9;
            if(lambda == null)
            {
                goto label_1;
            }
            
            if(lambda.u != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            Org.BouncyCastle.Math.BigInteger val_1 = lambda.u.Multiply(val:  lambda.u);
            if(lambda == null)
            {
                goto label_3;
            }
            
            val_9 = mem[lambda + 16];
            val_9 = lambda + 16;
            goto label_4;
            label_1:
            if(11993091 != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_9 = mem[lambda + 16];
            val_9 = lambda + 16;
            label_4:
            Org.BouncyCastle.Math.BigInteger val_2 = val_9.Multiply(val:  lambda.v);
            sbyte val_5 = mu & 255;
            if(val_5 == 255)
            {
                goto label_10;
            }
            
            if(val_5 != 1)
            {
                goto label_11;
            }
            
            if((val_1.Add(value:  val_2)) != null)
            {
                    return 0.Add(value:  lambda.v.Multiply(val:  lambda.v).ShiftLeft(n:  1));
            }
            
            return 0.Add(value:  lambda.v.Multiply(val:  lambda.v).ShiftLeft(n:  1));
            label_10:
            if((val_1.Subtract(n:  val_2)) != null)
            {
                    return 0.Add(value:  lambda.v.Multiply(val:  lambda.v).ShiftLeft(n:  1));
            }
            
            return 0.Add(value:  lambda.v.Multiply(val:  lambda.v).ShiftLeft(n:  1));
            label_11:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "mu must be 1 or -1");
        }
        public static Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Norm(sbyte mu, Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal u, Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal v)
        {
            var val_10;
            if(u != null)
            {
                    val_10 = u.Multiply(b:  u);
            }
            else
            {
                    val_10 = 0.Multiply(b:  0m);
            }
            
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_3 = u.Multiply(b:  v);
            sbyte val_6 = mu & 255;
            if(val_6 == 255)
            {
                goto label_5;
            }
            
            if(val_6 != 1)
            {
                goto label_6;
            }
            
            if((val_10.Add(b:  val_3)) != null)
            {
                    return 0.Add(b:  v.Multiply(b:  v).ShiftLeft(n:  1));
            }
            
            return 0.Add(b:  v.Multiply(b:  v).ShiftLeft(n:  1));
            label_5:
            if((val_10.Subtract(b:  val_3)) != null)
            {
                    return 0.Add(b:  v.Multiply(b:  v).ShiftLeft(n:  1));
            }
            
            return 0.Add(b:  v.Multiply(b:  v).ShiftLeft(n:  1));
            label_6:
            System.ArgumentException val_9 = new System.ArgumentException(message:  "mu must be 1 or -1");
        }
        public static Org.BouncyCastle.Math.EC.Abc.ZTauElement Round(Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda0, Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda1, sbyte mu)
        {
            var val_35;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            string val_47;
            if(lambda1.scale != lambda0.scale)
            {
                goto label_3;
            }
            
            sbyte val_1 = mu & 255;
            if(val_1 != 1)
            {
                    if(val_1 != 255)
            {
                goto label_5;
            }
            
            }
            
            Org.BouncyCastle.Math.BigInteger val_2 = lambda0.Round();
            Org.BouncyCastle.Math.BigInteger val_3 = lambda1.Round();
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_4 = lambda0.Subtract(b:  val_2);
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_5 = lambda1.Subtract(b:  val_3);
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_6 = val_4.Add(b:  val_4);
            if((mu & 255) == 1)
            {
                    Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_8 = val_6.Add(b:  val_5);
            }
            else
            {
                    Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_9 = val_6.Subtract(b:  val_5);
            }
            
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_11 = val_5.Add(b:  val_5).Add(b:  val_5);
            Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_12 = val_11.Add(b:  val_5);
            if((mu & 255) == 1)
            {
                    val_35 = val_4.Subtract(b:  val_11);
                Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_15 = val_4.Add(b:  val_12);
            }
            else
            {
                    val_35 = val_4.Add(b:  val_11);
                Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val_17 = val_4.Subtract(b:  val_12);
            }
            
            val_37 = null;
            val_37 = null;
            if(((val_9.CompareTo(val:  Org.BouncyCastle.Math.BigInteger.One)) & 2147483648) == 0)
            {
                    val_38 = null;
                val_38 = null;
                int val_19 = val_35.CompareTo(val:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width);
                var val_21 = (val_19 >= 0) ? 0 : mu;
                val_40 = (val_19 >> 31) ^ 1;
            }
            else
            {
                    val_41 = null;
                val_41 = null;
                val_40 = 0;
            }
            
            val_42 = null;
            val_42 = null;
            if(((val_9.CompareTo(val:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width)) & 2147483648) != 0)
            {
                goto label_32;
            }
            
            val_43 = null;
            val_44 = 1152921505512914944;
            val_43 = null;
            if(((val_17.CompareTo(val:  Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusTwo)) & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.Abc.ZTauElement)new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  val_2.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  -1)), v:  val_3.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (int)(((val_17.CompareTo(val:  Org.BouncyCastle.Math.BigInteger.Two)) < 0) ? 0 : mu) & 255)));
            }
            
            goto label_37;
            label_32:
            val_44 = 1152921505512914944;
            val_45 = null;
            val_45 = null;
            if(((val_35.CompareTo(val:  Org.BouncyCastle.Math.BigInteger.One)) & 2147483648) != 0)
            {
                goto label_41;
            }
            
            label_37:
            val_39 = -((int)mu & 255);
            return (Org.BouncyCastle.Math.EC.Abc.ZTauElement)new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  val_2.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  -1)), v:  val_3.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (int)(((val_17.CompareTo(val:  Org.BouncyCastle.Math.BigInteger.Two)) < 0) ? 0 : mu) & 255)));
            label_41:
            val_40 = 255;
            return (Org.BouncyCastle.Math.EC.Abc.ZTauElement)new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  val_2.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  -1)), v:  val_3.Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (int)(((val_17.CompareTo(val:  Org.BouncyCastle.Math.BigInteger.Two)) < 0) ? 0 : mu) & 255)));
            label_3:
            val_47 = "lambda0 and lambda1 do not have same scale";
            goto label_47;
            label_5:
            val_47 = "mu must be 1 or -1";
            label_47:
            null = new System.ArgumentException(message:  val_47);
        }
        public static Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal ApproximateDivisionByN(Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.BigInteger s, Org.BouncyCastle.Math.BigInteger vm, sbyte a, int m, int c)
        {
            Org.BouncyCastle.Math.BigInteger val_18;
            var val_19;
            int val_1 = m + 5;
            int val_4 = ((val_1 < 0) ? (m + 6) : (val_1)) >> 1;
            int val_5 = m + a;
            val_5 = val_5 - 2;
            val_5 = val_5 - c;
            Org.BouncyCastle.Math.BigInteger val_8 = s.Multiply(val:  k.ShiftRight(n:  val_5 - val_4));
            Org.BouncyCastle.Math.BigInteger val_11 = val_8.Add(value:  vm.Multiply(val:  val_8.ShiftRight(n:  m)));
            if(val_11 != null)
            {
                    val_18 = val_11.ShiftRight(n:  val_4);
            }
            else
            {
                    val_18 = 0.ShiftRight(n:  val_4);
            }
            
            if((val_11.TestBit(n:  val_4 - 1)) == false)
            {
                    return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  val_18 = val_18.Add(value:  Org.BouncyCastle.Math.BigInteger.One), scale:  c);
            }
            
            val_19 = null;
            val_19 = null;
            return (Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal)new Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(bigInt:  val_18, scale:  c);
        }
        public static sbyte[] TauAdicNaf(sbyte mu, Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
        {
            Org.BouncyCastle.Math.BigInteger val_23;
            Org.BouncyCastle.Math.BigInteger val_24;
            var val_25;
            var val_26;
            var val_27;
            sbyte val_28;
            var val_29;
            var val_31;
            var val_32;
            var val_34;
            var val_35;
            sbyte val_1 = mu & 255;
            if(val_1 != 1)
            {
                    if(val_1 != 255)
            {
                goto label_2;
            }
            
            }
            
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_24 = lambda;
            int val_3 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Norm(mu:  mu, lambda:  val_24).BitLength;
            val_24 = (val_3 > 30) ? (val_3 + 4) : 34;
            sbyte[] val_5 = new sbyte[0];
            if(lambda != null)
            {
                    val_23 = lambda.u;
            }
            else
            {
                    val_23 = 11993091;
            }
            
            val_24 = lambda.v;
            val_25 = 0;
            goto label_8;
            label_42:
            if((val_23.TestBit(n:  0)) == false)
            {
                goto label_9;
            }
            
            val_26 = null;
            val_26 = null;
            val_27 = null;
            val_27 = null;
            val_28 = Org.BouncyCastle.Math.BigInteger.Two.Subtract(n:  val_23.Subtract(n:  val_24.ShiftLeft(n:  1)).Mod(m:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Four)).IntValue;
            if(0 >= val_5.Length)
            {
                    val_29 = 0;
            }
            
            val_5[0] = val_28;
            if(0 >= val_5.Length)
            {
                    val_29 = 0;
                val_28 = mem[val_5[0x0] + 32];
                val_28 = val_5[0x0] + 32;
            }
            
            if((val_28 & 255) != 1)
            {
                goto label_21;
            }
            
            Org.BouncyCastle.Math.BigInteger val_13 = val_23.ClearBit(n:  0);
            goto label_22;
            label_9:
            if(0 >= val_5.Length)
            {
                    val_29 = 0;
            }
            
            val_31 = 0;
            val_5[0] = 0;
            goto label_25;
            label_21:
            val_32 = null;
            val_32 = null;
            Org.BouncyCastle.Math.BigInteger val_14 = val_23.Add(value:  Org.BouncyCastle.Math.BigInteger.One);
            label_22:
            if(val_14 != null)
            {
                    val_31 = 0;
            }
            else
            {
                    val_31 = 1;
            }
            
            val_25 = 0;
            label_25:
            Org.BouncyCastle.Math.BigInteger val_15 = val_14.ShiftRight(n:  1);
            if((mu & 255) == 1)
            {
                    Org.BouncyCastle.Math.BigInteger val_17 = val_24.Add(value:  val_15);
            }
            
            val_24 = val_14.ShiftRight(n:  1).Negate();
            val_23 = val_24.Subtract(n:  val_15);
            label_8:
            val_34 = null;
            val_34 = null;
            if((val_23 & 1) == 0)
            {
                goto label_42;
            }
            
            val_35 = null;
            val_35 = null;
            if((val_24 & 1) == 0)
            {
                goto label_42;
            }
            
            sbyte[] val_22 = new sbyte[0];
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  0, destinationArray:  val_22, destinationIndex:  0, length:  val_25 + 1);
            return (System.SByte[])val_22;
            label_2:
            System.ArgumentException val_23 = new System.ArgumentException(message:  "mu must be 1 or -1");
        }
        public static Org.BouncyCastle.Math.EC.AbstractF2mPoint Tau(Org.BouncyCastle.Math.EC.AbstractF2mPoint p)
        {
            if(p == null)
            {
                
            }
        
        }
        public static sbyte GetMu(Org.BouncyCastle.Math.EC.AbstractF2mCurve curve)
        {
            var val_3;
            var val_4;
            if(null == null)
            {
                goto label_4;
            }
            
            val_3 = null;
            val_3 = null;
            if((curve.A & 1) == 0)
            {
                goto label_7;
            }
            
            val_4 = 1;
            return (sbyte)val_4;
            label_4:
            val_4 = 255;
            return (sbyte)val_4;
            label_7:
            System.ArgumentException val_2 = new System.ArgumentException(message:  "No Koblitz curve (ABC), TNAF multiplication not possible");
        }
        public static sbyte GetMu(Org.BouncyCastle.Math.EC.ECFieldElement curveA)
        {
            return (sbyte)((curveA & 1) != 0) ? (-0) : 0;
        }
        public static sbyte GetMu(int curveA)
        {
            return (sbyte)(curveA != 0) ? (-0) : 0;
        }
        public static Org.BouncyCastle.Math.BigInteger[] GetLucas(sbyte mu, int k, bool doV)
        {
            var val_10;
            var val_11;
            Org.BouncyCastle.Math.BigInteger val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            var val_14;
            Org.BouncyCastle.Math.BigInteger val_15;
            var val_16;
            var val_17;
            sbyte val_1 = mu & 255;
            if(val_1 != 1)
            {
                    if(val_1 != 255)
            {
                goto label_2;
            }
            
            }
            
            val_10 = null;
            if(doV != false)
            {
                    val_11 = null;
                val_12 = Org.BouncyCastle.Math.BigInteger.Two;
                val_13 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (int)mu & 255);
            }
            else
            {
                    val_14 = null;
                val_12 = Org.BouncyCastle.Math.BigInteger.Zero;
                val_13 = Org.BouncyCastle.Math.BigInteger.One;
            }
            
            if(k >= 2)
            {
                    int val_3 = k - 1;
                do
            {
                val_15 = val_13;
                if((mu & 255) != 1)
            {
                    val_16 = val_15.Negate();
            }
            
                val_17 = val_16.Subtract(n:  val_12.ShiftLeft(n:  1));
                val_3 = val_3 - 1;
            }
            while(val_3 != 0);
            
            }
            else
            {
                    val_15 = val_12;
            }
            
            Org.BouncyCastle.Math.BigInteger[] val_8 = new Org.BouncyCastle.Math.BigInteger[2];
            val_8[0] = val_15;
            val_8[1] = val_13;
            return val_8;
            label_2:
            System.ArgumentException val_9 = new System.ArgumentException(message:  "mu must be 1 or -1");
        }
        public static Org.BouncyCastle.Math.BigInteger GetTw(sbyte mu, int w)
        {
            var val_7;
            var val_8;
            if(w != 4)
            {
                goto label_1;
            }
            
            if((mu & 255) != 1)
            {
                goto label_2;
            }
            
            val_7 = 6;
            return Org.BouncyCastle.Math.BigInteger.ValueOf(value:  10);
            label_1:
            Org.BouncyCastle.Math.BigInteger[] val_2 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu:  mu, k:  w, doV:  false);
            val_8 = null;
            val_8 = null;
            Org.BouncyCastle.Math.BigInteger val_3 = Org.BouncyCastle.Math.BigInteger.Zero.SetBit(n:  w);
            Org.BouncyCastle.Math.BigInteger val_6 = Org.BouncyCastle.Math.BigInteger.Two.Multiply(val:  val_2[0]).Multiply(val:  val_2[1].ModInverse(m:  val_3));
            if(val_6 != null)
            {
                    return val_6.Mod(m:  val_3);
            }
            
            return val_6.Mod(m:  val_3);
            label_2:
            val_7 = 10;
            return Org.BouncyCastle.Math.BigInteger.ValueOf(value:  10);
        }
        public static Org.BouncyCastle.Math.BigInteger[] GetSi(Org.BouncyCastle.Math.EC.AbstractF2mCurve curve)
        {
            int val_18;
            var val_19;
            if((curve & 1) != 0)
            {
                    int val_2 = curve.A.IntValue;
                int val_5 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetShiftsForCofactor(h:  curve.Cofactor);
                Org.BouncyCastle.Math.BigInteger[] val_8 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu:  (val_2 != 0) ? (-0) : 0, k:  (curve + 3) - val_2, doV:  false);
                if(val_2 != 0)
            {
                    val_18 = val_8.Length;
                if(val_18 == 0)
            {
                    val_18 = val_8.Length;
            }
            
                val_8[0] = val_8[0].Negate();
                val_8[1] = val_8[1].Negate();
            }
            
                val_19 = null;
                val_19 = null;
                Org.BouncyCastle.Math.BigInteger[] val_16 = new Org.BouncyCastle.Math.BigInteger[2];
                val_16[0] = Org.BouncyCastle.Math.BigInteger.One.Add(value:  val_8[1]).ShiftRight(n:  val_5);
                val_16[1] = Org.BouncyCastle.Math.BigInteger.One.Add(value:  val_8[0]).ShiftRight(n:  val_5).Negate();
                return val_16;
            }
            
            System.ArgumentException val_17 = new System.ArgumentException(message:  "si is defined for Koblitz curves only");
        }
        public static Org.BouncyCastle.Math.BigInteger[] GetSi(int fieldSize, int curveA, Org.BouncyCastle.Math.BigInteger cofactor)
        {
            int val_13;
            var val_14;
            int val_2 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetShiftsForCofactor(h:  cofactor);
            curveA = (fieldSize + 3) - curveA;
            Org.BouncyCastle.Math.BigInteger[] val_4 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu:  (curveA != 0) ? (-0) : 0, k:  curveA, doV:  false);
            if(curveA != 0)
            {
                    val_13 = val_4.Length;
                if(val_13 == 0)
            {
                    val_13 = val_4.Length;
            }
            
                val_4[0] = val_4[0].Negate();
                val_4[1] = val_4[1].Negate();
            }
            
            val_14 = null;
            val_14 = null;
            Org.BouncyCastle.Math.BigInteger[] val_12 = new Org.BouncyCastle.Math.BigInteger[2];
            val_12[0] = Org.BouncyCastle.Math.BigInteger.One.Add(value:  val_4[1]).ShiftRight(n:  val_2);
            val_12[1] = Org.BouncyCastle.Math.BigInteger.One.Add(value:  val_4[0]).ShiftRight(n:  val_2).Negate();
            return val_12;
        }
        protected static int GetShiftsForCofactor(Org.BouncyCastle.Math.BigInteger h)
        {
            var val_4;
            if((h == null) || (h.BitLength > 3))
            {
                goto label_4;
            }
            
            int val_2 = h.IntValue;
            if(val_2 == 2)
            {
                goto label_3;
            }
            
            if(val_2 != 4)
            {
                goto label_4;
            }
            
            val_4 = 2;
            return (int)val_4;
            label_3:
            val_4 = 1;
            return (int)val_4;
            label_4:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "h (Cofactor) must be 2 or 4");
        }
        public static Org.BouncyCastle.Math.EC.Abc.ZTauElement PartModReduction(Org.BouncyCastle.Math.BigInteger k, int m, sbyte a, Org.BouncyCastle.Math.BigInteger[] s, sbyte mu, sbyte c)
        {
            int val_18 = s.Length;
            if(val_18 == 0)
            {
                    val_18 = s.Length;
            }
            
            Org.BouncyCastle.Math.BigInteger val_18 = s[0];
            Org.BouncyCastle.Math.BigInteger val_19 = s[1];
            if((mu & 255) == 1)
            {
                    Org.BouncyCastle.Math.BigInteger val_2 = val_18.Add(value:  val_19);
            }
            
            Org.BouncyCastle.Math.BigInteger val_20 = Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu:  mu, k:  m, doV:  true)[1];
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_7 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Round(lambda0:  Org.BouncyCastle.Math.EC.Abc.Tnaf.ApproximateDivisionByN(k:  k, s:  s[0], vm:  val_20, a:  a, m:  m, c:  (int)c & 255), lambda1:  Org.BouncyCastle.Math.EC.Abc.Tnaf.ApproximateDivisionByN(k:  k, s:  s[1], vm:  val_20, a:  a, m:  m, c:  (int)c & 255), mu:  mu);
            return (Org.BouncyCastle.Math.EC.Abc.ZTauElement)new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  k.Subtract(n:  val_18.Subtract(n:  val_19).Multiply(val:  val_7.u)).Subtract(n:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  2).Multiply(val:  s[1]).Multiply(val:  val_7.v)), v:  s[1].Multiply(val:  val_7.u).Subtract(n:  s[0].Multiply(val:  val_7.v)));
        }
        public static Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyRTnaf(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            if(p.Curve != null)
            {
                    public Org.BouncyCastle.Math.EC.ECCurve Org.BouncyCastle.Math.EC.ECPoint::get_Curve() = 0;
            }
            
            int val_4 = 0.IntValue;
            return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyTnaf(p:  p, lambda:  Org.BouncyCastle.Math.EC.Abc.Tnaf.PartModReduction(k:  k, m:  0, a:  val_4, s:  0, mu:  (val_4 != 0) ? (-0) : 0, c:  10));
        }
        public static Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyTnaf(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
        {
            var val_8 = p.Curve;
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            if(val_8 != null)
            {
                    return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyFromTnaf(p:  p, u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicNaf(mu:  ((val_8 & 1) != 0) ? (-0) : 0, lambda:  lambda));
            }
            
            return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyFromTnaf(p:  p, u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicNaf(mu:  ((val_8 & 1) != 0) ? (-0) : 0, lambda:  lambda));
        }
        public static Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyFromTnaf(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte[] u)
        {
            var val_7;
            var val_8;
            val_7 = p.Curve;
            if(val_7 != null)
            {
                    val_7 = 0;
            }
            
            val_8 = p;
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            int val_7 = u.Length;
            label_18:
            var val_8 = 0;
            label_12:
            val_7 = val_7 - 1;
            if((val_7 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_8 = val_8 + 1;
            sbyte val_9 = u[(long)val_7];
            if(val_9 == 0)
            {
                goto label_12;
            }
            
            var val_5 = (val_9 > 0) ? p : (val_8);
            if(val_7 == 0)
            {
                goto label_18;
            }
            
            goto label_18;
            label_10:
            if(val_8 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)val_7;
            }
            
            val_7 = val_7;
            return (Org.BouncyCastle.Math.EC.AbstractF2mPoint)val_7;
        }
        public static sbyte[] TauAdicWNaf(sbyte mu, Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda, sbyte width, Org.BouncyCastle.Math.BigInteger pow2w, Org.BouncyCastle.Math.BigInteger tw, Org.BouncyCastle.Math.EC.Abc.ZTauElement[] alpha)
        {
            sbyte val_29;
            Org.BouncyCastle.Math.BigInteger val_30;
            Org.BouncyCastle.Math.BigInteger val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            sbyte val_36;
            var val_39;
            var val_40;
            val_29 = mu;
            sbyte val_1 = val_29 & 255;
            if(val_1 != 1)
            {
                    if(val_1 != 255)
            {
                goto label_2;
            }
            
            }
            
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_29 = lambda;
            int val_3 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Norm(mu:  val_29, lambda:  val_29).BitLength;
            val_29 = ((val_3 > 30) ? (val_3 + 4) : 34) + width;
            sbyte[] val_6 = new sbyte[0];
            Org.BouncyCastle.Math.BigInteger val_7 = pow2w.ShiftRight(n:  1);
            if(lambda != null)
            {
                    val_30 = lambda.u;
            }
            else
            {
                    val_30 = 11993091;
            }
            
            val_31 = lambda.v;
            goto label_9;
            label_49:
            if((val_30.TestBit(n:  0)) == false)
            {
                goto label_10;
            }
            
            val_32 = val_30.Add(value:  val_31.Multiply(val:  tw)).Mod(m:  pow2w);
            if(val_32 == null)
            {
                goto label_13;
            }
            
            if(((val_32.CompareTo(value:  val_7)) & 2147483648) == 0)
            {
                goto label_14;
            }
            
            goto label_21;
            label_10:
            val_29 = 0;
            if(0 >= val_6.Length)
            {
                    val_33 = 0;
            }
            
            val_34 = 0;
            val_6[val_29] = 0;
            goto label_36;
            label_13:
            if(((0.CompareTo(value:  val_7)) & 2147483648) != 0)
            {
                goto label_19;
            }
            
            label_14:
            val_32 = val_32.Subtract(n:  pow2w);
            if(val_32 != null)
            {
                goto label_21;
            }
            
            goto label_21;
            label_19:
            val_32 = 0;
            label_21:
            int val_15 = val_32.IntValue;
            if(0 >= val_6.Length)
            {
                    val_33 = 0;
            }
            
            int val_16 = val_15 << 24;
            val_6[0] = val_15;
            var val_17 = (val_16 <= (-16777216)) ? (-val_15) : (val_15);
            if(((int)val_17 & 255) >= alpha.Length)
            {
                    val_33 = 0;
            }
            
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_30 = alpha[(int)val_17 & 255];
            if(val_16 >= (-16777215))
            {
                    val_35 = val_30.Subtract(n:  alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)][0].u);
                if(((int)val_17 & 255) >= alpha.Length)
            {
                    val_33 = 0;
            }
            
                val_29 = mem[alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32];
                val_29 = alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32;
                val_36 = val_29;
                Org.BouncyCastle.Math.BigInteger val_19 = val_31.Subtract(n:  alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32 + 24);
            }
            else
            {
                    val_35 = val_30.Add(value:  alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)][0].u);
                if(((int)val_17 & 255) >= alpha.Length)
            {
                    val_33 = 0;
            }
            
                val_29 = mem[alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32];
                val_29 = alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32;
                val_36 = val_29;
                Org.BouncyCastle.Math.BigInteger val_21 = val_31.Add(value:  alpha[(int)(sbyte)((val_16 <= -16777216 ?  (-val_15) : val_15) & 0xFF)] + 32 + 24);
            }
            
            if(val_35 != null)
            {
                    val_34 = 0;
            }
            else
            {
                    val_34 = 1;
            }
            
            label_36:
            Org.BouncyCastle.Math.BigInteger val_22 = val_35.ShiftRight(n:  1);
            if((val_36 & 255) == 1)
            {
                    Org.BouncyCastle.Math.BigInteger val_24 = val_21.Add(value:  val_22);
            }
            
            val_31 = val_35.ShiftRight(n:  1).Negate();
            val_30 = val_21.Subtract(n:  val_22);
            label_9:
            val_39 = null;
            val_39 = null;
            if((val_30 & 1) == 0)
            {
                goto label_49;
            }
            
            val_40 = null;
            val_40 = null;
            if((val_31 & 1) == 0)
            {
                goto label_49;
            }
            
            return (System.SByte[])val_6;
            label_2:
            System.ArgumentException val_28 = new System.ArgumentException(message:  "mu must be 1 or -1");
        }
        public static Org.BouncyCastle.Math.EC.AbstractF2mPoint[] GetPreComp(Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte a)
        {
            Org.BouncyCastle.Math.EC.AbstractF2mPoint val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.SByte[] val_11;
            int val_12;
            val_7 = null;
            if((a & 255) != 0)
            {
                    val_8 = null;
                val_9 = 1152921505521545272;
            }
            else
            {
                    val_10 = null;
                val_9 = 1152921505521545256;
            }
            
            int val_6 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length;
            val_6 = val_6 + 1;
            val_11 = val_6 >> 1;
            Org.BouncyCastle.Math.EC.AbstractF2mPoint[] val_2 = new Org.BouncyCastle.Math.EC.AbstractF2mPoint[0];
            if((p != null) && (p == null))
            {
                    val_11 = 0;
            }
            
            if(val_2.Length == 0)
            {
                    val_11 = 0;
            }
            
            val_2[0] = p;
            if(Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length < 4)
            {
                goto label_12;
            }
            
            val_12 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length;
            goto label_13;
            label_20:
            val_12 = mem[Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf + 24];
            val_12 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length;
            label_13:
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length
            val_11 = Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length + 32;
            val_6 = Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyFromTnaf(p:  p, u:  val_11);
            if((val_6 != null) && (val_6 == null))
            {
                    val_11 = 0;
            }
            
            if(1 >= val_2.Length)
            {
                    val_11 = 0;
            }
            
            val_2[1] = val_6;
            if((3 + 2) < Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf.Length)
            {
                goto label_20;
            }
            
            label_12:
            if(p.Curve != null)
            {
                    return val_2;
            }
            
            return val_2;
        }
        public Tnaf()
        {
        
        }
        private static Tnaf()
        {
            var val_25;
            int val_26;
            int val_27;
            int val_28;
            int val_29;
            int val_30;
            int val_31;
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width = Org.BouncyCastle.Math.BigInteger.One.Negate();
            Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusTwo = Org.BouncyCastle.Math.BigInteger.Two.Negate();
            Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusThree = Org.BouncyCastle.Math.BigInteger.Three.Negate();
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Four = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
            Org.BouncyCastle.Math.EC.Abc.ZTauElement[] val_5 = new Org.BouncyCastle.Math.EC.Abc.ZTauElement[9];
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_6 = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.BigInteger.One, v:  Org.BouncyCastle.Math.BigInteger.Zero);
            if(val_5 == null)
            {
                goto label_6;
            }
            
            if(val_6 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_6 == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_5[1] = val_6;
            val_5[3] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusThree, v:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width);
            val_5[5] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width, v:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width);
            val_5[7] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.BigInteger.One, v:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width);
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0 = val_5;
            System.SByte[][] val_10 = new System.SByte[][8];
            sbyte[] val_11 = new sbyte[1];
            val_11[0] = 1;
            val_10[1] = val_11;
            sbyte[] val_12 = new sbyte[3];
            val_26 = val_12.Length;
            if(val_26 == 0)
            {
                    val_26 = val_12.Length;
            }
            
            val_12[0] = 255;
            val_12[2] = 1;
            val_10[3] = val_12;
            sbyte[] val_13 = new sbyte[3];
            val_27 = val_13.Length;
            if(val_27 == 0)
            {
                    val_27 = val_13.Length;
            }
            
            val_13[0] = 1;
            val_13[2] = 1;
            val_10[5] = val_13;
            sbyte[] val_14 = new sbyte[4];
            val_28 = val_14.Length;
            if(val_28 == 0)
            {
                    val_28 = val_14.Length;
            }
            
            val_14[0] = 255;
            val_14[3] = 1;
            val_10[7] = val_14;
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf = val_10;
            Org.BouncyCastle.Math.EC.Abc.ZTauElement[] val_15 = new Org.BouncyCastle.Math.EC.Abc.ZTauElement[9];
            Org.BouncyCastle.Math.EC.Abc.ZTauElement val_16 = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.BigInteger.One, v:  Org.BouncyCastle.Math.BigInteger.Zero);
            if(val_15 == null)
            {
                goto label_41;
            }
            
            if(val_16 != null)
            {
                goto label_42;
            }
            
            goto label_45;
            label_41:
            if(val_16 == null)
            {
                goto label_45;
            }
            
            label_42:
            label_45:
            val_15[1] = val_16;
            val_15[3] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusThree, v:  Org.BouncyCastle.Math.BigInteger.One);
            val_15[5] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.EC.Abc.Tnaf.Pow2Width, v:  Org.BouncyCastle.Math.BigInteger.One);
            val_15[7] = new Org.BouncyCastle.Math.EC.Abc.ZTauElement(u:  Org.BouncyCastle.Math.BigInteger.One, v:  Org.BouncyCastle.Math.BigInteger.One);
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1 = val_15;
            System.SByte[][] val_20 = new System.SByte[][8];
            sbyte[] val_21 = new sbyte[1];
            val_21[0] = 1;
            val_20[1] = val_21;
            sbyte[] val_22 = new sbyte[3];
            val_29 = val_22.Length;
            if(val_29 == 0)
            {
                    val_29 = val_22.Length;
            }
            
            val_22[0] = 255;
            val_22[2] = 1;
            val_20[3] = val_22;
            sbyte[] val_23 = new sbyte[3];
            val_30 = val_23.Length;
            if(val_30 == 0)
            {
                    val_30 = val_23.Length;
            }
            
            val_23[0] = 1;
            val_23[2] = 1;
            val_20[5] = val_23;
            sbyte[] val_24 = new sbyte[4];
            val_31 = val_24.Length;
            if(val_31 == 0)
            {
                    val_31 = val_24.Length;
            }
            
            val_24[0] = 255;
            val_24[3] = 255;
            val_20[7] = val_24;
            Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1Tnaf = val_20;
        }
    
    }

}
