using UnityEngine;

namespace Org.BouncyCastle.Math.EC
{
    public class ECAlgorithms
    {
        // Methods
        public static bool IsF2mCurve(Org.BouncyCastle.Math.EC.ECCurve c)
        {
            if(c != null)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mField(field:  c);
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mField(field:  c);
        }
        public static bool IsF2mField(Org.BouncyCastle.Math.Field.IFiniteField field)
        {
            var val_4;
            var val_7;
            var val_8;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4 = 1;
            if(field.Dimension >= 2)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_4 = 0;
                val_7 = null;
                val_7 = null;
                if((field.Characteristic & 1) != 0)
            {
                    var val_5 = (field != 0) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public static bool IsFpCurve(Org.BouncyCastle.Math.EC.ECCurve c)
        {
            if(c != null)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpField(field:  c);
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpField(field:  c);
        }
        public static bool IsFpField(Org.BouncyCastle.Math.Field.IFiniteField field)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (bool)(field.Dimension == 1) ? 1 : 0;
        }
        public static Org.BouncyCastle.Math.EC.ECPoint SumOfMultiplies(Org.BouncyCastle.Math.EC.ECPoint[] ps, Org.BouncyCastle.Math.BigInteger[] ks)
        {
            var val_20;
            Org.BouncyCastle.Math.BigInteger[] val_21;
            var val_22;
            val_21 = ks;
            val_22 = ps;
            if((((val_22 == null) || (val_21 == null)) || (ps.Length != ks.Length)) || (ps.Length <= 0))
            {
                goto label_4;
            }
            
            if(ps.Length == 2)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(P:  val_22 + 32, a:  val_21 + 32, Q:  val_22 + 32 + 8, b:  val_21 + 32 + 8);
            }
            
            if(ps.Length != 1)
            {
                goto label_6;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_21 = val_22[0];
            Org.BouncyCastle.Math.BigInteger val_22 = val_21[0];
            val_22 = ???;
            val_21 = ???;
            val_20 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_328;
            label_6:
            Org.BouncyCastle.Math.EC.ECPoint val_23 = val_22[0];
            Org.BouncyCastle.Math.EC.ECPoint[] val_14 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            var val_24 = 0;
            val_14[0] = val_23;
            do
            {
                var val_16 = val_24 + 1;
                mem2[0] = Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(c:  val_23, p:  null);
                val_24 = val_24 + 1;
            }
            while(((ps.Length & 4294967295) - 1) != val_24);
            
            if(val_23 == null)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(ps:  val_14, ks:  val_21));
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_18 = Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultipliesGlv(ps:  val_14, ks:  val_21, glvEndomorphism:  val_23);
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(ps:  val_14, ks:  val_21));
            label_4:
            System.ArgumentException val_20 = new System.ArgumentException(message:  "point and scalar arrays should be non-null, and of equal, non-zero, length");
        }
        public static Org.BouncyCastle.Math.EC.ECPoint SumOfTwoMultiplies(Org.BouncyCastle.Math.EC.ECPoint P, Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.EC.ECPoint Q, Org.BouncyCastle.Math.BigInteger b)
        {
            Org.BouncyCastle.Math.BigInteger val_7;
            Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism val_8;
            Org.BouncyCastle.Math.EC.ECPoint val_9;
            var val_10;
            val_7 = b;
            val_8 = P;
            val_9 = Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(c:  P, p:  Q);
            if(val_8 == null)
            {
                goto label_2;
            }
            
            if((val_8 & 1) == 0)
            {
                goto label_5;
            }
            
            val_7 = val_9;
            val_10 = P;
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P:  P, k:  a, Q:  val_9, l:  val_7));
            label_2:
            label_5:
            val_8 = val_8;
            if(val_8 == null)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P:  P, k:  a, Q:  val_9, l:  val_7));
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_3 = new Org.BouncyCastle.Math.EC.ECPoint[2];
            val_3[0] = P;
            val_3[1] = val_9;
            Org.BouncyCastle.Math.BigInteger[] val_4 = new Org.BouncyCastle.Math.BigInteger[2];
            val_9 = val_4;
            val_9[0] = a;
            val_9[1] = val_7;
            Org.BouncyCastle.Math.EC.ECPoint val_5 = Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultipliesGlv(ps:  val_3, ks:  val_4, glvEndomorphism:  val_8);
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P:  P, k:  a, Q:  val_9, l:  val_7));
        }
        public static Org.BouncyCastle.Math.EC.ECPoint ShamirsTrick(Org.BouncyCastle.Math.EC.ECPoint P, Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.EC.ECPoint Q, Org.BouncyCastle.Math.BigInteger l)
        {
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ValidatePoint(p:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickJsf(P:  P, k:  k, Q:  Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(c:  P, p:  Q), l:  l));
        }
        public static Org.BouncyCastle.Math.EC.ECPoint ImportPoint(Org.BouncyCastle.Math.EC.ECCurve c, Org.BouncyCastle.Math.EC.ECPoint p)
        {
            if((c & 1) != 0)
            {
                
            }
            else
            {
                    System.ArgumentException val_1 = new System.ArgumentException(message:  "Point must be on the same curve");
            }
        
        }
        public static void MontgomeryTrick(Org.BouncyCastle.Math.EC.ECFieldElement[] zs, int off, int len)
        {
            Org.BouncyCastle.Math.EC.ECAlgorithms.MontgomeryTrick(zs:  zs, off:  off, len:  len, scale:  0);
        }
        public static void MontgomeryTrick(Org.BouncyCastle.Math.EC.ECFieldElement[] zs, int off, int len, Org.BouncyCastle.Math.EC.ECFieldElement scale)
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            Org.BouncyCastle.Math.EC.ECFieldElement val_16;
            var val_17;
            val_7 = len;
            Org.BouncyCastle.Math.EC.ECFieldElement[] val_1 = new Org.BouncyCastle.Math.EC.ECFieldElement[0];
            if(zs.Length <= off)
            {
                    val_8 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECFieldElement val_6 = zs[(long)off];
            if((val_6 != null) && (val_6 == null))
            {
                    val_8 = 0;
            }
            
            if(val_1.Length == 0)
            {
                    val_8 = 0;
            }
            
            val_1[0] = val_6;
            if(val_7 >= 2)
            {
                    val_9 = val_7 - 1;
                do
            {
                if(0 >= val_1.Length)
            {
                    val_10 = 0;
            }
            
                int val_3 = (off + 1) + 0;
                if(val_3 >= zs.Length)
            {
                    val_10 = 0;
            }
            
                Org.BouncyCastle.Math.EC.ECFieldElement val_8 = zs[(long)val_3];
                val_11 = 0 + 1;
                val_7 = val_1[0];
                if((val_7 != null) && (val_7 == null))
            {
                    val_12 = 0;
            }
            
                if(val_11 >= val_1.Length)
            {
                    val_12 = 0;
            }
            
                val_13 = 0 + 1;
                val_1[0] = val_7;
            }
            while(val_9 != val_13);
            
            }
            else
            {
                    val_9 = 0;
            }
            
            if(scale != null)
            {
                    if(0 >= val_1.Length)
            {
                    val_14 = 0;
            }
            
                val_7 = val_1[0];
                if((val_7 != null) && (val_7 == null))
            {
                    val_15 = 0;
            }
            
                if(0 >= val_1.Length)
            {
                    val_15 = 0;
            }
            
                mem2[0] = val_7;
            }
            
            if(0 >= val_1.Length)
            {
                    val_15 = 0;
            }
            
            val_16 = val_1[0];
            if(0 >= 1)
            {
                    var val_4 = 0 + 1;
                val_13 = off - 1;
                do
            {
                val_11 = val_13 + val_4;
                if(val_11 >= zs.Length)
            {
                    val_15 = 0;
            }
            
                val_7 = zs[(long)val_11];
                if((val_4 - 2) >= val_1.Length)
            {
                    val_15 = 0;
            }
            
                val_17 = mem[282584257677135];
                if((0 != 0) && (0 == 0))
            {
                    val_17 = 0;
            }
            
                if(val_11 >= zs.Length)
            {
                    val_17 = 0;
            }
            
                mem2[0] = 0;
                val_4 = val_4 - 1;
                val_16 = val_16;
            }
            while(val_4 > 1);
            
            }
            
            mem2[0] = val_16;
        }
        public static Org.BouncyCastle.Math.EC.ECPoint ReferenceMultiply(Org.BouncyCastle.Math.EC.ECPoint p, Org.BouncyCastle.Math.BigInteger k)
        {
            var val_7;
            Org.BouncyCastle.Math.BigInteger val_1 = k.Abs();
            val_7 = p;
            int val_2 = val_1.BitLength;
            if((val_2 >= 1) && (val_2 >= 2))
            {
                    var val_7 = 1;
                do
            {
                if((val_1.TestBit(n:  1)) != false)
            {
                    val_7 = ((val_1.TestBit(n:  0)) != true) ? p : (val_7);
            }
            
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            }
            
            if((k.SignValue & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_7;
            }
            
            if(val_7 == 0)
            {
                
            }
        
        }
        public static Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(Org.BouncyCastle.Math.EC.ECPoint p)
        {
            if(p.IsValid() != false)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)p;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Invalid point", paramName:  "p");
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickJsf(Org.BouncyCastle.Math.EC.ECPoint P, Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.EC.ECPoint Q, Org.BouncyCastle.Math.BigInteger l)
        {
            Org.BouncyCastle.Math.BigInteger val_8;
            Org.BouncyCastle.Math.EC.ECPoint val_9;
            int val_10;
            var val_11;
            var val_12;
            val_8 = k;
            val_9 = P;
            Org.BouncyCastle.Math.EC.ECPoint[] val_1 = new Org.BouncyCastle.Math.EC.ECPoint[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Q != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Q == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Q;
            val_1[1] = P;
            val_1[2] = P;
            val_1[3] = P;
            Org.BouncyCastle.Math.EC.ECPoint[] val_2 = new Org.BouncyCastle.Math.EC.ECPoint[9];
            Org.BouncyCastle.Math.EC.ECPoint val_5 = val_1[3];
            if(val_2 == null)
            {
                goto label_19;
            }
            
            if(val_5 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_5 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            val_2[0] = val_5;
            val_2[1] = val_1[2];
            val_2[2] = val_1[1];
            val_2[3] = val_1[0];
            val_2[4] = val_9;
            val_2[5] = val_1[0];
            val_2[6] = val_1[1];
            val_2[7] = val_1[2];
            val_2[8] = val_1[3];
            System.Byte[] val_3 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateJsf(g:  val_8, h:  l);
            int val_13 = val_3.Length;
            int val_4 = val_13 - 1;
            if((val_4 & 2147483648) != 0)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_9;
            }
            
            val_10 = val_13 & 4294967295;
            val_11 = (long)val_4 + 32;
            val_12 = val_13 - 2;
            goto label_63;
            label_67:
            val_10 = val_3.Length;
            val_11 = val_11 - 1;
            val_12 = val_12 - 1;
            label_63:
            val_13 = val_11 - 32;
            val_8 = val_2[-8];
            val_9 = val_9;
            if((val_12 & 2147483648) == 0)
            {
                goto label_67;
            }
            
            return (Org.BouncyCastle.Math.EC.ECPoint)val_9;
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(Org.BouncyCastle.Math.EC.ECPoint P, Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.EC.ECPoint Q, Org.BouncyCastle.Math.BigInteger l)
        {
            int val_1 = k.SignValue;
            Org.BouncyCastle.Math.BigInteger val_3 = k.Abs();
            Org.BouncyCastle.Math.BigInteger val_4 = l.Abs();
            int val_8 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  val_3.BitLength)));
            int val_12 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  val_4.BitLength)));
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_13 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p:  P, width:  val_8, includeNegated:  true);
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_14 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p:  Q, width:  val_12, includeNegated:  true);
            int val_15 = val_1 >> 30;
            val_15 = val_15 & 2;
            val_15 = val_15 | 4;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_16 = 1152921505515524096 + val_15;
            int val_18 = l.SignValue >> 31;
            int val_19 = val_18 & 2;
            val_19 = val_19 | 4;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_20 = 1152921505515524096 + val_19;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_23 = 1152921505515524096 + ((val_1 >= 0) ? 96 : 64);
            int val_25 = val_18 + 6;
            val_25 = val_25 & 4294967294;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_26 = 1152921505515524096 + val_25;
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(preCompP:  val_13.Equals(obj:  mem[(1152921505515524096 + (((val_1 >> 30) & 2) | 4)) + 296 + 8]), preCompNegP:  val_13.Equals(obj:  mem[(1152921505515524096 + val_1 >= 0 ? 96 : 64) + 296 + 8]), wnafP:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_8, k:  val_3), preCompQ:  val_14.Equals(obj:  mem[(1152921505515524096 + (((val_2 >> 31) & 2) | 4)) + 296 + 8]), preCompNegQ:  val_14.Equals(obj:  mem[(1152921505515524096 + (((val_2 >> 31) + 6) & 4294967294)) + 296 + 8]), wnafQ:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_12, k:  val_4));
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(Org.BouncyCastle.Math.EC.ECPoint P, Org.BouncyCastle.Math.BigInteger k, Org.BouncyCastle.Math.EC.ECPointMap pointMapQ, Org.BouncyCastle.Math.BigInteger l)
        {
            int val_1 = k.SignValue;
            Org.BouncyCastle.Math.BigInteger val_3 = k.Abs();
            Org.BouncyCastle.Math.BigInteger val_4 = l.Abs();
            int val_10 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  System.Math.Max(val1:  val_3.BitLength, val2:  val_4.BitLength))));
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_12 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(p:  P);
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_13 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(p:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MapPointWithPrecomp(p:  P, width:  val_10, includeNegated:  true, pointMap:  pointMapQ));
            int val_14 = val_1 >> 30;
            val_14 = val_14 & 2;
            val_14 = val_14 | 4;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_15 = 1152921505515524096 + val_14;
            int val_17 = l.SignValue >> 31;
            int val_18 = val_17 & 2;
            val_18 = val_18 | 4;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_19 = 1152921505515524096 + val_18;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_22 = 1152921505515524096 + ((val_1 >= 0) ? 96 : 64);
            int val_24 = val_17 + 6;
            val_24 = val_24 & 4294967294;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_25 = 1152921505515524096 + val_24;
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(preCompP:  val_12.Equals(obj:  mem[(1152921505515524096 + (((val_1 >> 30) & 2) | 4)) + 296 + 8]), preCompNegP:  val_12.Equals(obj:  mem[(1152921505515524096 + val_1 >= 0 ? 96 : 64) + 296 + 8]), wnafP:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_10, k:  val_3), preCompQ:  val_13.Equals(obj:  mem[(1152921505515524096 + (((val_2 >> 31) & 2) | 4)) + 296 + 8]), preCompNegQ:  val_13.Equals(obj:  mem[(1152921505515524096 + (((val_2 >> 31) + 6) & 4294967294)) + 296 + 8]), wnafQ:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_10, k:  val_4));
        }
        private static Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(Org.BouncyCastle.Math.EC.ECPoint[] preCompP, Org.BouncyCastle.Math.EC.ECPoint[] preCompNegP, byte[] wnafP, Org.BouncyCastle.Math.EC.ECPoint[] preCompQ, Org.BouncyCastle.Math.EC.ECPoint[] preCompNegQ, byte[] wnafQ)
        {
            var val_11;
            var val_12;
            var val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            byte val_18;
            byte val_19;
            var val_20;
            var val_21;
            var val_23;
            var val_24;
            var val_25;
            val_12 = wnafQ;
            val_13 = wnafP;
            if(mem[137158695] == false)
            {
                goto label_0;
            }
            
            if(val_13 == null)
            {
                goto label_1;
            }
            
            label_38:
            label_40:
            val_14 = wnafQ.Length;
            val_15 = System.Math.Max(val1:  wnafP.Length, val2:  val_14);
            if(preCompP.Length == 0)
            {
                    val_14 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_11 = preCompP[0];
            val_16 = val_15 - 1;
            if((val_16 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_15 = 0;
            val_17 = val_11;
            label_34:
            if(val_16 < wnafP.Length)
            {
                    val_18 = val_13[(long)val_16];
            }
            else
            {
                    val_18 = 0;
            }
            
            if(val_16 < wnafQ.Length)
            {
                    val_19 = val_12[(long)val_16];
            }
            else
            {
                    val_19 = 0;
            }
            
            if((val_19 | val_18) != 0)
            {
                goto label_16;
            }
            
            val_16 = val_16 - 1;
            val_15 = val_15 + 1;
            if((val_16 & 2147483648) == 0)
            {
                goto label_34;
            }
            
            goto label_18;
            label_16:
            val_20 = val_11;
            if(val_18 != 0)
            {
                    var val_3 = (val_18 < 0) ? (-val_18) : (val_18);
                var val_5 = val_3 >> 1;
                val_18 = (long)(val_3 >> 1) & 2147483647;
                var val_6 = ((val_18 < 0) ? preCompNegP : preCompP) + (((long)((val_18 < 0 ?  (-val_18) : val_18>>1) & 0x7FFFFFFF)) << 3);
                val_21 = val_11;
            }
            
            if(val_19 != 0)
            {
                    var val_9 = ((val_19 < 0) ? (-val_19) : (val_19)) >> 1;
                var val_10 = ((val_19 < 0) ? preCompNegQ : preCompQ) + (((long)((val_19 < 0 ?  (-val_19) : val_19>>1) & 0x7FFFFFFF)) << 3);
                val_23 = val_21;
            }
            
            if(val_15 >= 1)
            {
                    val_24 = val_17;
                val_15 = 0;
            }
            
            val_16 = val_16 - 1;
            val_25 = val_24;
            if((val_16 & 2147483648) == 0)
            {
                goto label_34;
            }
            
            return (Org.BouncyCastle.Math.EC.ECPoint)val_25;
            label_18:
            if(val_15 < 1)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_25;
            }
            
            val_11 = ???;
            val_12 = ???;
            val_13 = ???;
            goto typeof(Org.BouncyCastle.Math.EC.ECPoint).__il2cppRuntimeField_308;
            label_0:
            mem2[0] = 1;
            if(val_13 != 0)
            {
                goto label_38;
            }
            
            label_1:
            if(val_12 != 0)
            {
                goto label_40;
            }
            
            goto label_40;
            label_9:
            val_25 = val_11;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_25;
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(Org.BouncyCastle.Math.EC.ECPoint[] ps, Org.BouncyCastle.Math.BigInteger[] ks)
        {
            Org.BouncyCastle.Math.EC.ECPoint[] val_14 = ps;
            bool[] val_2 = new bool[0];
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_3 = new Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[0];
            System.Byte[][] val_4 = new System.Byte[][0];
            if(ps.Length < 1)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs:  val_2, infos:  val_3, wnafs:  val_4);
            }
            
            Org.BouncyCastle.Math.BigInteger[] val_14 = ks[32];
            System.Boolean[] val_15 = val_2[32];
            Org.BouncyCastle.Math.EC.ECPoint[] val_16 = val_14[32];
            var val_19 = 0;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_17 = val_3[32];
            System.Byte[][] val_18 = val_4[32];
            label_25:
            mem2[0] = (ks[0x20] + 0.SignValue) >> 31;
            Org.BouncyCastle.Math.BigInteger val_7 = ks[0x20] + 0.Abs();
            int val_11 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  val_7.BitLength)));
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_12 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p:  ps[0x20] + 0, width:  val_11, includeNegated:  true);
            if(val_3 == null)
            {
                goto label_15;
            }
            
            if(val_12 != null)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            if(val_12 == null)
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            mem2[0] = val_12;
            val_14 = val_14;
            mem2[0] = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_11, k:  val_7);
            val_19 = val_19 + 1;
            if((ps.Length & 4294967295) != val_19)
            {
                goto label_25;
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs:  val_2, infos:  val_3, wnafs:  val_4);
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultipliesGlv(Org.BouncyCastle.Math.EC.ECPoint[] ps, Org.BouncyCastle.Math.BigInteger[] ks, Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism)
        {
            Org.BouncyCastle.Math.EC.ECPoint[] val_11;
            var val_12;
            int val_13;
            var val_14;
            var val_15;
            val_11 = ps;
            if(ps.Length == 0)
            {
                    val_12 = 0;
            }
            
            val_13 = ps.Length;
            Org.BouncyCastle.Math.BigInteger[] val_1 = new Org.BouncyCastle.Math.BigInteger[0];
            if(val_13 <= 0)
            {
                goto label_5;
            }
            
            var val_22 = 0;
            var val_21 = 0;
            label_26:
            val_15 = 0;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_15 = 0;
            val_12 = public Org.BouncyCastle.Math.BigInteger[] Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism::DecomposeScalar(Org.BouncyCastle.Math.BigInteger k);
            Org.BouncyCastle.Math.BigInteger[] val_5 = glvEndomorphism.DecomposeScalar(k:  ks[val_22].Mod(m:  val_11[0]));
            if(val_5.Length == 0)
            {
                    val_12 = 0;
            }
            
            Org.BouncyCastle.Math.BigInteger val_19 = val_5[0];
            if(val_1 == null)
            {
                goto label_16;
            }
            
            if(val_19 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_19 == null)
            {
                goto label_20;
            }
            
            label_17:
            if(val_19 == null)
            {
                    val_12 = 0;
            }
            
            label_20:
            val_13 = 0;
            if(val_21 >= val_1.Length)
            {
                    val_12 = 0;
            }
            
            val_1[val_13] = val_19;
            if(val_5.Length <= 1)
            {
                    val_12 = 0;
            }
            
            Org.BouncyCastle.Math.BigInteger val_20 = val_5[1];
            var val_6 = val_21 | 1;
            if((val_20 != null) && (val_20 == null))
            {
                    val_12 = 0;
            }
            
            val_21 = val_21 + 2;
            if(val_6 >= val_1.Length)
            {
                    val_12 = 0;
            }
            
            val_22 = val_22 + 1;
            val_1[(long)val_6] = val_20;
            if(val_22 != (val_13 & 4294967295))
            {
                goto label_26;
            }
            
            val_11 = val_11;
            val_14 = ???;
            label_5:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_12 = 0;
            Org.BouncyCastle.Math.EC.ECPointMap val_8 = glvEndomorphism.PointMap;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_12 = 1;
            if(glvEndomorphism.HasEfficientPointMap != false)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(ps:  val_11, pointMap:  val_8, ks:  val_1);
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_11 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            if(val_13 < 1)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(ps:  val_11, ks:  val_1);
            }
            
            var val_26 = 0;
            val_13 = val_13 & 4294967295;
            label_55:
            if(0 >= (ps + 24))
            {
                    val_12 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_12 = val_11 + 0;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_12 = 0;
            if(val_11 == null)
            {
                goto label_46;
            }
            
            if(((ps + 0) + 32) != 0)
            {
                goto label_47;
            }
            
            goto label_50;
            label_46:
            if(((ps + 0) + 32) == 0)
            {
                goto label_50;
            }
            
            label_47:
            label_50:
            val_11[0] = (ps + 0) + 32;
            val_11 = val_11;
            val_26 = val_26 + 2;
            val_14 = 0 + 1;
            val_11[(long)val_26 | 1] = val_8.Map(p:  (ps + 0) + 32);
            if(val_14 != val_13)
            {
                goto label_55;
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(ps:  val_11, ks:  val_1);
        }
        internal static Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(Org.BouncyCastle.Math.EC.ECPoint[] ps, Org.BouncyCastle.Math.EC.ECPointMap pointMap, Org.BouncyCastle.Math.BigInteger[] ks)
        {
            var val_22;
            System.Boolean[] val_23;
            System.Byte[][] val_24;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_25;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_26;
            bool[] val_1 = new bool[0];
            val_23 = val_1;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_2 = new Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[0];
            System.Byte[][] val_3 = new System.Byte[][0];
            val_24 = val_3;
            if(ps.Length < 1)
            {
                    return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs:  val_1, infos:  val_2, wnafs:  val_3);
            }
            
            Org.BouncyCastle.Math.EC.ECPoint[] val_27 = ps;
            var val_35 = 0;
            var val_36 = 1;
            val_27 = val_27 + 32;
            label_38:
            Org.BouncyCastle.Math.BigInteger val_28 = ks[0];
            val_23[0] = val_28.SignValue >> 31;
            Org.BouncyCastle.Math.BigInteger val_7 = val_28.Abs();
            var val_29 = 4294967296;
            val_29 = val_35 + val_29;
            var val_8 = val_29 >> 32;
            Org.BouncyCastle.Math.BigInteger val_30 = ks[val_8];
            val_23[val_8] = val_30.SignValue >> 31;
            Org.BouncyCastle.Math.BigInteger val_11 = val_30.Abs();
            int val_17 = System.Math.Max(val1:  2, val2:  System.Math.Min(val1:  16, val2:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  System.Math.Max(val1:  val_7.BitLength, val2:  val_11.BitLength))));
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_19 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(p:  (ps + 32) + 0);
            val_25 = val_2;
            if(val_25 == 0)
            {
                goto label_20;
            }
            
            if(val_19 != null)
            {
                goto label_21;
            }
            
            goto label_24;
            label_20:
            val_25 = val_2;
            if(val_19 == null)
            {
                goto label_24;
            }
            
            label_21:
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_31 = val_25[4];
            val_25 = val_2;
            if(val_19 == null)
            {
                    val_25 = val_2;
            }
            
            label_24:
            if(0 >= mem[1152921544055359848])
            {
                    val_25 = val_2;
            }
            
            val_26 = val_25;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_20 = val_25 + 0;
            mem2[0] = val_19;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_21 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(p:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MapPointWithPrecomp(p:  (ps + 32) + 0, width:  val_17, includeNegated:  true, pointMap:  pointMap));
            if(val_21 != null)
            {
                    Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_32 = val_2[4];
            }
            
            if(val_36 >= mem[1152921544055359848])
            {
                    val_26 = val_2;
            }
            
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_22 = val_26 + ((((0 + 4294967296) >> 32)) << 3);
            mem2[0] = val_21;
            System.Byte[] val_23 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_17, k:  val_7);
            val_24 = val_24;
            val_23 = val_23;
            if(val_24 == 0)
            {
                goto label_29;
            }
            
            if(val_23 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(val_23 == null)
            {
                goto label_33;
            }
            
            label_30:
            System.Byte[] val_33 = val_3[4];
            label_33:
            System.Byte[][] val_24 = val_24 + 0;
            mem2[0] = val_23;
            System.Byte[] val_25 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width:  val_17, k:  val_11);
            if(val_25 != null)
            {
                    System.Byte[] val_34 = val_3[4];
            }
            
            System.Byte[][] val_26 = val_24 + ((((0 + 4294967296) >> 32)) << 3);
            mem2[0] = val_25;
            val_22 = 0 + 1;
            val_35 = val_35 + 8589934592;
            val_36 = val_36 + 2;
            if((ps.Length & 4294967295) != val_22)
            {
                goto label_38;
            }
            
            return Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs:  val_1, infos:  val_2, wnafs:  val_3);
        }
        private static Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(bool[] negs, Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] infos, byte[][] wnafs)
        {
            Org.BouncyCastle.Math.EC.ECPoint val_4;
            var val_9;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            int val_30;
            System.Byte[][] val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            val_25 = wnafs.Length & 4294967295;
            if(wnafs.Length < 1)
            {
                goto label_2;
            }
            
            val_26 = 0;
            val_28 = val_25;
            goto label_3;
            label_8:
            val_26 = 1;
            val_28 = mem[wnafs + 24];
            val_28 = wnafs + 24;
            label_3:
            val_30 = mem[X25 + 24];
            val_30 = X25 + 24;
            if((val_25 - 1) != val_26)
            {
                goto label_8;
            }
            
            val_31 = wnafs;
            val_32 = (System.Math.Max(val1:  0, val2:  val_30)) - 1;
            if(infos != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            if(infos.Length == 0)
            {
                    val_30 = 0;
            }
            
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_22 = infos[0];
            if(infos[0].m_preCompNeg == null)
            {
                    val_33 = 0;
            }
            
            if((val_32 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            System.Byte[][] val_3 = val_31 + 32;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] val_23 = infos[32];
            val_35 = 0;
            System.Boolean[] val_24 = negs[32];
            goto label_47;
            label_2:
            if(infos != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_16:
            val_36 = infos[0].m_twice;
            return (Org.BouncyCastle.Math.EC.ECPoint)val_36;
            label_44:
            val_27 = val_4;
            if(val_27 != 0)
            {
                goto label_46;
            }
            
            goto label_22;
            label_47:
            val_4 = infos[0].m_twice;
            label_42:
            if(wnafs.Length < 1)
            {
                goto label_23;
            }
            
            val_29 = infos[0].m_twice;
            do
            {
                if(0 >= (wnafs + 24))
            {
                    val_34 = 0;
            }
            
                if(val_32 < ((wnafs + 32) + 0 + 24))
            {
                    if(val_32 >= ((wnafs + 32) + 0 + 24))
            {
                    val_34 = 0;
            }
            
                var val_25 = (long)val_32;
                val_25 = ((wnafs + 32) + 0) + val_25;
                var val_26 = ((wnafs + 32) + 0 + (long)(int)((val_2 - 1))) + 32;
                if(val_26 != 0)
            {
                    if(0 >= infos.Length)
            {
                    val_34 = 0;
            }
            
                if(0 >= negs.Length)
            {
                    val_34 = 0;
            }
            
                val_26 = val_26 >> 31;
                var val_27 = infos[0x20] + 0;
                val_27 = val_27 + ((val_26 == (negs[0x20] + 0)) ? 64 : 96);
                var val_7 = ((val_26 < 0) ? (-val_26) : (val_26)) >> 1;
                var val_8 = (infos[0x20] + 0) + (((long)((((wnafs + 32) + 0 + (long)(int)((val_2 - 1))) + 32 < 0 ?  (-((wnafs + 32) + 0 + (long)(int)((val_2 - 1))) + 32) : ((wnafs + 32) + 0 + (long)(int)((val_2 - 1))) + 32>>1) & 0x7FFFFFFF)) << 3);
                val_25 = val_25;
                val_37 = val_32;
                val_31 = wnafs;
                val_29 = val_29;
            }
            
            }
            
                val_27 = 0 + 1;
            }
            while(val_25 != val_27);
            
            val_35 = val_35;
            if(val_29 != infos[0].m_twice)
            {
                goto label_41;
            }
            
            label_23:
            val_38 = val_37 - 1;
            val_35 = val_35 + 1;
            if((val_38 & 2147483648) == 0)
            {
                goto label_42;
            }
            
            goto label_43;
            label_41:
            if(val_35 < 1)
            {
                goto label_44;
            }
            
            val_27 = val_4;
            if(val_27 != 0)
            {
                goto label_46;
            }
            
            label_22:
            label_46:
            val_36 = val_27;
            val_38 = val_37 - 1;
            if((val_38 & 2147483648) == 0)
            {
                goto label_47;
            }
            
            return (Org.BouncyCastle.Math.EC.ECPoint)val_36;
            label_43:
            if(val_35 >= 1)
            {
                    val_31 = ???;
                val_38 = ???;
                val_27 = ???;
                val_29 = ???;
                val_25 = ???;
            }
            else
            {
                    val_36 = val_9;
                return (Org.BouncyCastle.Math.EC.ECPoint)val_36;
            }
        
        }
        public ECAlgorithms()
        {
        
        }
    
    }

}
