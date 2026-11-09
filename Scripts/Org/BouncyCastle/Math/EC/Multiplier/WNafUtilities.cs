using UnityEngine;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
    public abstract class WNafUtilities
    {
        // Fields
        public static readonly string PRECOMP_NAME;
        private static readonly int[] DEFAULT_WINDOW_SIZE_CUTOFFS;
        private static readonly byte[] EMPTY_BYTES;
        private static readonly int[] EMPTY_INTS;
        private static readonly Org.BouncyCastle.Math.EC.ECPoint[] EMPTY_POINTS;
        
        // Methods
        public static int[] GenerateCompactNaf(Org.BouncyCastle.Math.BigInteger k)
        {
            System.Int32[] val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_18;
            var val_19;
            if(k.BitLength >= 65536)
            {
                goto label_2;
            }
            
            if(k.SignValue == 0)
            {
                goto label_4;
            }
            
            Org.BouncyCastle.Math.BigInteger val_4 = k.ShiftLeft(n:  1).Add(value:  k);
            int val_5 = val_4.BitLength;
            int val_6 = val_5 >> 1;
            int[] val_7 = new int[0];
            val_14 = val_7;
            int val_9 = val_5 - 1;
            if(val_9 < 2)
            {
                goto label_9;
            }
            
            val_15 = 0;
            int val_16 = 0;
            val_16 = 1;
            do
            {
                if((val_4.Xor(value:  k).TestBit(n:  1)) != false)
            {
                    val_16 = ((((k.TestBit(n:  1)) & true) != 0) ? (-(-65536)) : -65536) | val_16;
                val_16 = val_16 + 1;
                val_14[0] = val_16;
                val_17 = 1;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_17 = val_16 + 1;
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 < val_9);
            
            label_25:
            val_18 = val_15 + 1;
            val_14[0] = val_17 | 65536;
            if(val_18 >= val_7.Length)
            {
                    return val_14;
            }
            
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(a:  val_7, length:  val_18);
            label_4:
            val_18 = 1152921505515577344;
            val_19 = null;
            val_19 = null;
            val_14 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_INTS;
            return val_14;
            label_9:
            if(val_14 != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_2:
            System.ArgumentException val_15 = new System.ArgumentException(message:  "must have bitlength < 2^16", paramName:  "k");
        }
        public static int[] GenerateCompactWindowNaf(int width, Org.BouncyCastle.Math.BigInteger k)
        {
            Org.BouncyCastle.Math.BigInteger val_23;
            var val_24;
            System.Int32[] val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            string val_31;
            string val_32;
            val_23 = k;
            if()
            {
                    return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactNaf(k:  val_23);
            }
            
            if((width - 2) >= 15)
            {
                goto label_4;
            }
            
            if(val_23.BitLength >= 65536)
            {
                goto label_6;
            }
            
            if(val_23.SignValue == 0)
            {
                goto label_8;
            }
            
            int val_6 = (val_23.BitLength / width) + 1;
            int[] val_7 = new int[0];
            val_24 = 1 << (width & 31);
            val_25 = val_7;
            val_26 = 0;
            val_27 = 0;
            val_28 = 0;
            int val_9 = val_24 - 1;
            int val_10 = val_24 >> 1;
            goto label_13;
            label_19:
            if((val_28 ^ (val_23.TestBit(n:  0))) != true)
            {
                    val_26 = 1;
            }
            else
            {
                    val_23 = val_23.ShiftRight(n:  0);
                int val_15 = val_23.IntValue & val_9;
                val_15 = val_15 + 0;
                var val_16 = (val_15 != val_10) ? 1 : 0;
                val_9 = val_15 - ((val_15 != val_10) ? (val_24) : 0);
                val_27 = (val_26 - ((val_27 > 0) ? 1 : 0)) | (val_9 << 16);
                val_25[0] = val_27;
                val_24 = val_24;
                val_26 = width;
                val_27 = 1;
            }
            
            label_13:
            if(val_26 <= val_23.BitLength)
            {
                goto label_19;
            }
            
            if(val_27 >= val_7.Length)
            {
                    return val_25;
            }
            
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(a:  val_7, length:  1);
            label_8:
            val_23 = 1152921505515577344;
            val_29 = null;
            val_29 = null;
            val_25 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_INTS;
            return val_25;
            label_4:
            val_31 = "must be in the range [2, 16]";
            val_32 = "width";
            goto label_26;
            label_6:
            val_31 = "must have bitlength < 2^16";
            val_32 = "k";
            label_26:
            null = new System.ArgumentException(message:  val_31, paramName:  val_32);
        }
        public static byte[] GenerateJsf(Org.BouncyCastle.Math.BigInteger g, Org.BouncyCastle.Math.BigInteger h)
        {
            var val_26;
            var val_27;
            int val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            System.Byte[] val_35;
            System.Byte[] val_36;
            val_26 = h;
            val_27 = g;
            val_28 = val_27.BitLength;
            int val_28 = val_26.BitLength;
            val_28 = (System.Math.Max(val1:  val_28, val2:  val_28)) + 1;
            byte[] val_4 = new byte[0];
            val_29 = 0;
            val_30 = 0;
            val_31 = 0;
            val_32 = 0;
            goto label_5;
            label_21:
            var val_29 = 0;
            int val_7 = (val_27.IntValue >> val_29) + val_31;
            int val_9 = val_26.IntValue >> val_29;
            val_9 = val_9 + val_30;
            if((val_7 & 1) != 0)
            {
                goto label_8;
            }
            
            val_33 = 0;
            if((val_9 & 1) == 0)
            {
                goto label_9;
            }
            
            label_11:
            int val_10 = val_9 & 7;
            val_9 = val_9 & 2;
            val_9 = (val_9 & 1) - val_9;
            val_10 = val_9 + val_10;
            int val_12 = val_7 & 3;
            var val_13 = (val_10 == 4) ? (-val_9) : (val_9);
            goto label_10;
            label_8:
            int val_14 = val_7 & 1;
            int val_16 = val_7 & 7;
            val_14 = val_14 - (val_7 & 2);
            val_16 = val_14 + val_16;
            val_29 = ((val_9 & 3) == 2) ? (-val_14) : (val_14);
            if((val_9 & 1) != 0)
            {
                goto label_11;
            }
            
            label_9:
            val_34 = 0;
            label_10:
            val_29 = 1;
            if(val_29 == 30)
            {
                    val_27 = val_27.ShiftRight(n:  30);
                val_26 = val_26.ShiftRight(n:  30);
                val_29 = 0;
            }
            
            val_35 = val_4;
            if(val_35 == 0)
            {
                    val_35 = val_4;
            }
            
            val_31 = val_31 ^ ((0 == (val_29 + 1)) ? 1 : 0);
            val_30 = val_30 ^ ((0 == (val_34 + 1)) ? 1 : 0);
            val_28 = 1;
            if(val_32 >= mem[1152921544115901640])
            {
                    val_35 = val_4;
            }
            
            System.Byte[] val_24 = val_35 + 0;
            val_32 = val_28;
            mem2[0] = val_34;
            label_5:
            if((((val_31 | val_30) != 0) || (val_27.BitLength > val_29)) || (val_26.BitLength > val_29))
            {
                goto label_21;
            }
            
            val_36 = val_4;
            if(val_36 == 0)
            {
                    val_36 = val_4;
            }
            
            if(val_32 >= mem[1152921544115901640])
            {
                    return val_36;
            }
            
            val_36 = val_4;
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(a:  val_4, length:  1);
        }
        public static byte[] GenerateNaf(Org.BouncyCastle.Math.BigInteger k)
        {
            System.Byte[] val_12;
            var val_13;
            var val_14;
            var val_15;
            if(k.SignValue != 0)
            {
                    Org.BouncyCastle.Math.BigInteger val_3 = k.ShiftLeft(n:  1).Add(value:  k);
                int val_4 = val_3.BitLength;
                int val_5 = val_4 - 1;
                val_12 = new byte[0];
                if(val_5 >= 2)
            {
                    val_13 = 1;
                do
            {
                if((val_3.Xor(value:  k).TestBit(n:  1)) != false)
            {
                    val_13 = val_13 + 1;
                val_12[(long)val_13 - 1] = (((k.TestBit(n:  1)) & true) != 0) ? (-0) : 0;
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < val_5);
            
            }
            
                val_14 = (long)val_4 - 2;
                val_12[val_14] = 1;
                return val_12;
            }
            
            val_14 = 1152921505515577344;
            val_15 = null;
            val_15 = null;
            val_12 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_BYTES;
            return val_12;
        }
        public static byte[] GenerateWindowNaf(int width, Org.BouncyCastle.Math.BigInteger k)
        {
            Org.BouncyCastle.Math.BigInteger val_23;
            var val_24;
            System.Byte[] val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            val_23 = k;
            if()
            {
                    return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateNaf(k:  val_23);
            }
            
            if((width - 2) >= 7)
            {
                goto label_4;
            }
            
            if(val_23.SignValue == 0)
            {
                goto label_6;
            }
            
            int val_4 = val_23.BitLength + 1;
            byte[] val_5 = new byte[0];
            val_24 = 1 << (width & 31);
            val_25 = val_5;
            val_26 = 0;
            val_27 = 0;
            val_28 = 0;
            int val_8 = val_24 >> 1;
            goto label_11;
            label_17:
            if((val_28 ^ (val_23.TestBit(n:  0))) != true)
            {
                    val_26 = 1;
            }
            else
            {
                    val_23 = val_23.ShiftRight(n:  0);
                int val_14 = (val_23.IntValue & (val_24 - 1)) + 0;
                var val_15 = (val_14 != val_8) ? 1 : 0;
                var val_17 = (val_27 > 0) ? 1 : 0;
                val_17 = val_27 - val_17;
                var val_18 = val_17 + val_26;
                val_27 = val_18 + 1;
                val_25[(long)val_18] = val_14 - ((val_14 != val_8) ? (val_24) : 0);
                val_24 = val_24;
                val_26 = width;
            }
            
            label_11:
            if(val_26 <= val_23.BitLength)
            {
                goto label_17;
            }
            
            if(val_27 >= val_5.Length)
            {
                    return val_25;
            }
            
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(a:  val_5, length:  val_27);
            label_6:
            val_23 = 1152921505515577344;
            val_29 = null;
            val_29 = null;
            val_25 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_BYTES;
            return val_25;
            label_4:
            System.ArgumentException val_21 = new System.ArgumentException(message:  "must be in the range [2, 8]", paramName:  "width");
        }
        public static int GetNafWeight(Org.BouncyCastle.Math.BigInteger k)
        {
            int val_1 = k.SignValue;
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            Org.BouncyCastle.Math.BigInteger val_4 = k.ShiftLeft(n:  1).Add(value:  k).Xor(value:  k);
            if(val_4 != null)
            {
                    return val_4.BitCount;
            }
            
            return val_4.BitCount;
        }
        public static Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo GetWNafPreCompInfo(Org.BouncyCastle.Math.EC.ECPoint p)
        {
            null = null;
            if(p != null)
            {
                    return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(preCompInfo:  p);
            }
            
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(preCompInfo:  p);
        }
        public static Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo GetWNafPreCompInfo(Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
        {
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_1 = null;
            preCompInfo = val_1;
            val_1 = new Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo();
            return (Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo)preCompInfo;
        }
        public static int GetWindowSize(int bits)
        {
            null = null;
            return Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits:  bits, windowSizeCutoffs:  Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.DEFAULT_WINDOW_SIZE_CUTOFFS);
        }
        public static int GetWindowSize(int bits, int[] windowSizeCutoffs)
        {
            goto label_0;
            label_4:
            if((windowSizeCutoffs[((long)(int)(W22)) << 2]) > bits)
            {
                    return (int)2;
            }
            
            2 = 3;
            label_0:
            if(1 < windowSizeCutoffs.Length)
            {
                goto label_4;
            }
            
            return (int)2;
        }
        public static Org.BouncyCastle.Math.EC.ECPoint MapPointWithPrecomp(Org.BouncyCastle.Math.EC.ECPoint p, int width, bool includeNegated, Org.BouncyCastle.Math.EC.ECPointMap pointMap)
        {
            Org.BouncyCastle.Math.EC.ECPoint val_8;
            bool val_9;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            val_8 = pointMap;
            val_9 = includeNegated;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_1 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p:  p, width:  width, includeNegated:  val_9);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_9 = 0;
            val_11 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_4 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(preCompInfo:  p);
            if(val_1 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_13 = 0;
                val_12 = val_8.Map(p:  val_1);
            }
            
            val_16 = val_1;
            Org.BouncyCastle.Math.EC.ECPoint[] val_7 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            val_17 = 0;
            goto label_20;
            label_34:
            if(val_17 >= 1152921512609633008)
            {
                    val_18 = 0;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_18 = 0;
            val_15 = public Org.BouncyCastle.Math.EC.ECPoint Org.BouncyCastle.Math.EC.ECPointMap::Map(Org.BouncyCastle.Math.EC.ECPoint p);
            Org.BouncyCastle.Math.EC.ECPoint val_9 = val_8.Map(p:  Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo.__il2cppRuntimeField_byval_arg);
            if(val_7 == null)
            {
                goto label_27;
            }
            
            if(val_9 != null)
            {
                goto label_28;
            }
            
            goto label_31;
            label_27:
            if(val_9 == null)
            {
                goto label_31;
            }
            
            label_28:
            if(val_9 == null)
            {
                    val_15 = 0;
            }
            
            label_31:
            if(val_17 >= val_7.Length)
            {
                    val_15 = 0;
            }
            
            val_17 = 1;
            val_7[0] = val_9;
            label_20:
            if(val_17 < val_1.m_preCompNeg)
            {
                goto label_34;
            }
            
            if(includeNegated == false)
            {
                goto label_36;
            }
            
            val_16 = 0;
            goto label_38;
            label_45:
            if(val_16 >= val_7.Length)
            {
                    val_20 = 0;
            }
            
            val_8 = val_7[0];
            if((val_8 != null) && (val_8 == null))
            {
                    val_20 = 0;
            }
            
            if(val_16 >= val_10.Length)
            {
                    val_20 = 0;
            }
            
            val_16 = 1;
            new Org.BouncyCastle.Math.EC.ECPoint[0][0] = val_8;
            label_38:
            if(val_16 < val_10.Length)
            {
                goto label_45;
            }
            
            label_36:
            val_21 = null;
            val_21 = null;
            if(p != null)
            {
                    return (Org.BouncyCastle.Math.EC.ECPoint)val_8.Map(p:  p);
            }
            
            return (Org.BouncyCastle.Math.EC.ECPoint)val_8.Map(p:  p);
        }
        public static Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo Precompute(Org.BouncyCastle.Math.EC.ECPoint p, int width, bool includeNegated)
        {
            Org.BouncyCastle.Math.EC.ECPoint[] val_14;
            var val_15;
            var val_16;
            var val_17;
            Org.BouncyCastle.Math.EC.ECPoint val_18;
            Org.BouncyCastle.Math.EC.ECPoint[] val_19;
            Org.BouncyCastle.Math.EC.ECPoint[] val_20;
            var val_21;
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            Org.BouncyCastle.Math.EC.ECPoint val_28;
            val_14 = includeNegated;
            val_15 = 1152921505515577344;
            val_16 = null;
            val_16 = null;
            Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo val_1 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(preCompInfo:  p);
            val_17 = 0;
            val_18 = (System.Math.Max(val1:  0, val2:  width - 2)) & 31;
            int val_4 = 1 << val_18;
            val_19 = val_1;
            if(val_19 != null)
            {
                    val_20 = val_1.m_preCompNeg;
            }
            else
            {
                    val_21 = null;
                val_21 = null;
                val_20 = 0;
                val_19 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_POINTS;
            }
            
            int val_5 = val_4 - val_20;
            if()
            {
                goto label_12;
            }
            
            val_22 = val_4;
            val_19 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ResizeTable(a:  val_19, length:  val_22);
            if(val_18 == 0)
            {
                goto label_15;
            }
            
            val_23 = val_20;
            if(val_20 == 0)
            {
                    if(p == null)
            {
                    val_22 = 0;
                val_24 = 0;
            }
            
                if(val_6.Length == 0)
            {
                    val_22 = 0;
                val_24 = 0;
            }
            
                val_23 = 1;
                val_19[0] = p;
            }
            
            if(val_18 != 1)
            {
                goto label_20;
            }
            
            val_18 = p;
            val_19[1] = val_18;
            if(p != null)
            {
                goto label_65;
            }
            
            label_66:
            val_18 = 0;
            label_65:
            val_25 = val_20;
            label_12:
            if(val_1 != null)
            {
                goto label_37;
            }
            
            label_38:
            label_37:
            if(val_14 == false)
            {
                goto label_27;
            }
            
            val_14 = val_1;
            if(val_14 == null)
            {
                goto label_28;
            }
            
            val_20 = val_1.m_preCompNeg;
            if(val_4 <= val_20)
            {
                goto label_32;
            }
            
            val_14 = Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ResizeTable(a:  val_14, length:  val_4);
            goto label_32;
            label_15:
            val_19[0] = p;
            if(val_1 != null)
            {
                goto label_37;
            }
            
            goto label_38;
            label_28:
            val_14 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            val_20 = 0;
            label_32:
            if(val_20 >= val_4)
            {
                goto label_39;
            }
            
            var val_10 = (long)val_4 - (val_20 << );
            label_49:
            if(val_20 >= val_6.Length)
            {
                    val_26 = 0;
            }
            
            if(val_14 == null)
            {
                goto label_43;
            }
            
            if(1152921512609633008 != null)
            {
                goto label_44;
            }
            
            goto label_47;
            label_43:
            if(1152921512609633008 == null)
            {
                goto label_47;
            }
            
            label_44:
            if(1152921512609633008 == null)
            {
                    val_26 = 0;
            }
            
            label_47:
            if(val_20 >= val_8.Length)
            {
                    val_26 = 0;
            }
            
            mem2[0] = 1152921512609633008;
            val_10 = val_10 - 1;
            val_20 = val_20 + 1;
            if(val_10 != 0)
            {
                goto label_49;
            }
            
            label_39:
            val_15 = 1152921505515577344;
            label_27:
            val_27 = null;
            if(p != null)
            {
                    return val_1;
            }
            
            return val_1;
            label_20:
            var val_14 = val_23;
            val_14 = val_14 - 1;
            if(val_14 >= val_6.Length)
            {
                    val_24 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_15 = val_19[(long)val_14];
            if(val_1 == null)
            {
                goto label_56;
            }
            
            label_71:
            label_69:
            label_84:
            if(1 >= val_4)
            {
                goto label_57;
            }
            
            do
            {
                val_19[1] = val_15;
            }
            while((1 + 1) < (long)val_4);
            
            if(p != null)
            {
                goto label_65;
            }
            
            goto label_66;
            label_57:
            if(p != null)
            {
                goto label_65;
            }
            
            goto label_66;
            label_56:
            if(val_6.Length == 0)
            {
                    val_24 = 0;
            }
            
            Org.BouncyCastle.Math.EC.ECPoint val_16 = val_19[0];
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  p)) == false)
            {
                goto label_69;
            }
            
            if((p < 64) || ((p - 2) > 2))
            {
                goto label_71;
            }
            
            val_28 = val_16;
            if(val_28 == 0)
            {
                    val_28 = val_16;
            }
            
            if(val_20 != 0)
            {
                goto label_84;
            }
            
            val_19[0] = val_15;
            goto label_84;
        }
        private static byte[] Trim(byte[] a, int length)
        {
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  val_1.Length);
            return (System.Byte[])val_1;
        }
        private static int[] Trim(int[] a, int length)
        {
            int[] val_1 = new int[0];
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  val_1.Length);
            return (System.Int32[])val_1;
        }
        private static Org.BouncyCastle.Math.EC.ECPoint[] ResizeTable(Org.BouncyCastle.Math.EC.ECPoint[] a, int length)
        {
            Org.BouncyCastle.Math.EC.ECPoint[] val_1 = new Org.BouncyCastle.Math.EC.ECPoint[0];
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  a.Length);
            return val_1;
        }
        protected WNafUtilities()
        {
        
        }
        private static WNafUtilities()
        {
            Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME = "bc_wnaf";
            Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.DEFAULT_WINDOW_SIZE_CUTOFFS = new int[6] {13, 41, 121, 337, 897, 2305};
            Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_BYTES = new byte[0];
            Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_INTS = new int[0];
            Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_POINTS = new Org.BouncyCastle.Math.EC.ECPoint[0];
        }
    
    }

}
