using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    public abstract class Arrays
    {
        // Methods
        public static bool AreEqual(bool[] a, bool[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        public static bool AreEqual(char[] a, char[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        public static bool AreEqual(byte[] a, byte[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        public static bool AreSame(byte[] a, byte[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        public static bool ConstantTimeAreEqual(byte[] a, byte[] b)
        {
            var val_4;
            if(a.Length != b.Length)
            {
                goto label_2;
            }
            
            if(a.Length == 0)
            {
                goto label_3;
            }
            
            var val_6 = 0;
            do
            {
                byte val_5 = b[(long)a.Length - 1];
                val_5 = val_5 ^ (a[(long)a.Length - 1]);
                val_5 = val_5 & 255;
                val_6 = val_6 | val_5;
            }
            while((((long)a.Length - 1) - 1) != 1);
            
            var val_3 = (val_6 == 0) ? 1 : 0;
            return (bool)val_4;
            label_2:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        public static bool AreEqual(int[] a, int[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        public static bool AreEqual(uint[] a, uint[] b)
        {
            if(a == b)
            {
                    return true;
            }
            
            if(a == null)
            {
                    return false;
            }
            
            if(b == null)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.HaveSameContents(a:  a, b:  b);
        }
        private static bool HaveSameContents(bool[] a, bool[] b)
        {
            int val_3;
            var val_4;
            val_3 = a.Length;
            if(val_3 != b.Length)
            {
                goto label_2;
            }
            
            val_3 = val_3 - 1;
            label_6:
            if(val_3 == 1)
            {
                goto label_3;
            }
            
            val_3 = val_3 - 1;
            var val_2 = (b[(long)val_3] == true) ? 1 : 0;
            val_2 = ((a[(long)val_3] == true) ? 1 : 0) ^ val_2;
            if((val_2 & 1) == 0)
            {
                goto label_6;
            }
            
            label_2:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        private static bool HaveSameContents(char[] a, char[] b)
        {
            int val_1;
            var val_2;
            val_1 = a.Length;
            if(val_1 != b.Length)
            {
                goto label_2;
            }
            
            val_1 = val_1 - 1;
            label_6:
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_1 = val_1 - 1;
            if((a[((long)(int)((a.Length - 1))) << 1]) == (b[((long)(int)((a.Length - 1))) << 1]))
            {
                goto label_6;
            }
            
            label_2:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        private static bool HaveSameContents(byte[] a, byte[] b)
        {
            int val_1;
            var val_2;
            val_1 = a.Length;
            if(val_1 != b.Length)
            {
                goto label_2;
            }
            
            val_1 = val_1 - 1;
            label_6:
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_1 = val_1 - 1;
            if(a[(long)val_1] == b[(long)val_1])
            {
                goto label_6;
            }
            
            label_2:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        private static bool HaveSameContents(int[] a, int[] b)
        {
            int val_1;
            var val_2;
            val_1 = a.Length;
            if(val_1 != b.Length)
            {
                goto label_2;
            }
            
            val_1 = val_1 - 1;
            label_6:
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_1 = val_1 - 1;
            if((a[((long)(int)((a.Length - 1))) << 2]) == (b[((long)(int)((a.Length - 1))) << 2]))
            {
                goto label_6;
            }
            
            label_2:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        private static bool HaveSameContents(uint[] a, uint[] b)
        {
            int val_1;
            var val_2;
            val_1 = a.Length;
            if(val_1 != b.Length)
            {
                goto label_2;
            }
            
            val_1 = val_1 - 1;
            label_6:
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_1 = val_1 - 1;
            if((a[((long)(int)((a.Length - 1))) << 2]) == (b[((long)(int)((a.Length - 1))) << 2]))
            {
                goto label_6;
            }
            
            label_2:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        public static string ToString(object[] a)
        {
            object val_7;
            var val_8;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  91);
            if(a.Length != 0)
            {
                    val_7 = a[0];
                System.Text.StringBuilder val_2 = val_1.Append(value:  val_7);
                if(a.Length >= 2)
            {
                    var val_8 = 1;
                do
            {
                val_7 = val_1.Append(value:  ", ");
                System.Text.StringBuilder val_4 = val_7.Append(value:  a[1]);
                val_8 = val_8 + 1;
            }
            while(val_8 < a.Length);
            
            }
            
            }
            
            if(val_1 != null)
            {
                    val_8 = 93;
                System.Text.StringBuilder val_5 = val_1.Append(value:  ']');
            }
            else
            {
                    val_8 = 93;
                System.Text.StringBuilder val_6 = val_1.Append(value:  ']');
            }
        
        }
        public static int GetHashCode(byte[] data)
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            int val_1 = data.Length - 1;
            val_6 = data.Length + 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            val_7 = data.Length & 4294967295;
            val_8 = (long)val_1;
            val_9 = data.Length - 2;
            goto label_2;
            label_4:
            val_7 = data.Length;
            val_8 = val_8 - 1;
            val_9 = val_9 - 1;
            label_2:
            val_6 = (val_6 + (val_6 << 8)) ^ data[val_8];
            if((val_9 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            return (int)val_6;
        }
        public static int GetHashCode(byte[] data, int off, int len)
        {
            var val_5;
            var val_6;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            val_5 = len - 1;
            val_6 = len + 1;
            if((val_5 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            do
            {
                val_5 = val_5 - 1;
                val_6 = (val_6 + (val_6 << 8)) ^ (data[(long)off + val_5]);
            }
            while((val_5 & 2147483648) == 0);
            
            return (int)val_6;
        }
        public static int GetHashCode(int[] data)
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            int val_1 = data.Length - 1;
            val_6 = data.Length + 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            val_7 = data.Length & 4294967295;
            val_8 = (long)val_1;
            val_9 = data.Length - 2;
            goto label_2;
            label_4:
            val_7 = data.Length;
            val_8 = val_8 - 1;
            val_9 = val_9 - 1;
            label_2:
            val_6 = (data[(((long)(int)((data.Length - 1)) - 1)) << 2]) ^ (val_6 + (val_6 << 8));
            if((val_9 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            return (int)val_6;
        }
        public static int GetHashCode(int[] data, int off, int len)
        {
            var val_5;
            var val_6;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            val_5 = len - 1;
            val_6 = len + 1;
            if((val_5 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            do
            {
                int val_1 = off + val_5;
                val_5 = val_5 - 1;
                val_6 = (data[((long)(int)((off + (len - 1)))) << 2]) ^ (val_6 + (val_6 << 8));
            }
            while((val_5 & 2147483648) == 0);
            
            return (int)val_6;
        }
        public static int GetHashCode(uint[] data)
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            int val_1 = data.Length - 1;
            val_6 = data.Length + 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            val_7 = data.Length & 4294967295;
            val_8 = (long)val_1;
            val_9 = data.Length - 2;
            goto label_2;
            label_4:
            val_7 = data.Length;
            val_8 = val_8 - 1;
            val_9 = val_9 - 1;
            label_2:
            val_6 = (data[(((long)(int)((data.Length - 1)) - 1)) << 2]) ^ (val_6 + (val_6 << 8));
            if((val_9 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            return (int)val_6;
        }
        public static int GetHashCode(uint[] data, int off, int len)
        {
            var val_5;
            var val_6;
            if(data == null)
            {
                    return (int)val_6;
            }
            
            val_5 = len - 1;
            val_6 = len + 1;
            if((val_5 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            do
            {
                int val_1 = off + val_5;
                val_5 = val_5 - 1;
                val_6 = (data[((long)(int)((off + (len - 1)))) << 2]) ^ (val_6 + (val_6 << 8));
            }
            while((val_5 & 2147483648) == 0);
            
            return (int)val_6;
        }
        public static int GetHashCode(ulong[] data)
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            if(data == null)
            {
                goto label_0;
            }
            
            int val_1 = data.Length - 1;
            val_6 = data.Length + 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_6;
            }
            
            val_7 = data.Length & 4294967295;
            val_8 = (long)val_1;
            val_9 = data.Length - 2;
            goto label_2;
            label_4:
            val_7 = data.Length;
            val_8 = val_8 - 1;
            val_9 = val_9 - 1;
            label_2:
            ulong val_3 = data[val_8];
            val_3 = (val_6 + (val_6 << 8)) ^ val_3;
            val_3 = val_3 + (val_3 << 8);
            val_6 = val_3 ^ data[val_8];
            if((val_9 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            return (int)val_6;
            label_0:
            val_6 = 0;
            return (int)val_6;
        }
        public static int GetHashCode(ulong[] data, int off, int len)
        {
            var val_5;
            if(data != null)
            {
                    int val_1 = len - 1;
                val_5 = len + 1;
                if((val_1 & 2147483648) != 0)
            {
                    return (int)val_5;
            }
            
                do
            {
                ulong val_4 = data[(long)off + val_1];
                val_1 = val_1 - 1;
                val_4 = (val_5 + (val_5 << 8)) ^ val_4;
                val_4 = val_4 + (val_4 << 8);
                val_5 = val_4 ^ (data[(long)off + val_1]);
            }
            while((val_1 & 2147483648) == 0);
            
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public static byte[] Clone(byte[] data)
        {
            var val_3;
            var val_4;
            val_3 = data;
            if(val_3 != null)
            {
                    object val_1 = val_3.Clone();
                if(val_1 == null)
            {
                    return (System.Byte[])val_4;
            }
            
                val_4 = val_1;
                val_3 = null;
                if(val_4 != null)
            {
                    return (System.Byte[])val_4;
            }
            
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
        public static byte[] Clone(byte[] data, byte[] existing)
        {
            System.Byte[] val_1 = existing;
            if(data != null)
            {
                    if(val_1 == null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  data);
            }
            
                if(existing.Length != data.Length)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  data);
            }
            
                System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1 = existing, destinationIndex:  0, length:  existing.Length);
                return (System.Byte[])val_1;
            }
            
            val_1 = 0;
            return (System.Byte[])val_1;
        }
        public static int[] Clone(int[] data)
        {
            var val_3;
            var val_4;
            val_3 = data;
            if(val_3 != null)
            {
                    object val_1 = val_3.Clone();
                if(val_1 == null)
            {
                    return (System.Int32[])val_4;
            }
            
                val_4 = val_1;
                val_3 = null;
                if(val_4 != null)
            {
                    return (System.Int32[])val_4;
            }
            
            }
            
            val_4 = 0;
            return (System.Int32[])val_4;
        }
        internal static uint[] Clone(uint[] data)
        {
            var val_3;
            var val_4;
            val_3 = data;
            if(val_3 != null)
            {
                    object val_1 = val_3.Clone();
                if(val_1 == null)
            {
                    return (System.UInt32[])val_4;
            }
            
                val_4 = val_1;
                val_3 = null;
                if(val_4 != null)
            {
                    return (System.UInt32[])val_4;
            }
            
            }
            
            val_4 = 0;
            return (System.UInt32[])val_4;
        }
        public static long[] Clone(long[] data)
        {
            var val_3;
            var val_4;
            val_3 = data;
            if(val_3 != null)
            {
                    object val_1 = val_3.Clone();
                if(val_1 == null)
            {
                    return (System.Int64[])val_4;
            }
            
                val_4 = val_1;
                val_3 = null;
                if(val_4 != null)
            {
                    return (System.Int64[])val_4;
            }
            
            }
            
            val_4 = 0;
            return (System.Int64[])val_4;
        }
        public static ulong[] Clone(ulong[] data)
        {
            var val_3;
            var val_4;
            val_3 = data;
            if(val_3 != null)
            {
                    object val_1 = val_3.Clone();
                if(val_1 == null)
            {
                    return (System.UInt64[])val_4;
            }
            
                val_4 = val_1;
                val_3 = null;
                if(val_4 != null)
            {
                    return (System.UInt64[])val_4;
            }
            
            }
            
            val_4 = 0;
            return (System.UInt64[])val_4;
        }
        public static ulong[] Clone(ulong[] data, ulong[] existing)
        {
            System.UInt64[] val_1 = existing;
            if(data != null)
            {
                    if(val_1 == null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  data);
            }
            
                if(existing.Length != data.Length)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  data);
            }
            
                System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1 = existing, destinationIndex:  0, length:  existing.Length);
                return (System.UInt64[])val_1;
            }
            
            val_1 = 0;
            return (System.UInt64[])val_1;
        }
        public static bool Contains(byte[] a, byte n)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            label_3:
            if(val_1 >= a.Length)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(a[0] != n)
            {
                goto label_3;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool Contains(short[] a, short n)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            label_3:
            if(val_1 >= a.Length)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(a[0] != n)
            {
                goto label_3;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool Contains(int[] a, int n)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            label_3:
            if(val_1 >= a.Length)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(a[0] != n)
            {
                goto label_3;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        public static void Fill(byte[] buf, byte b)
        {
            int val_2;
            var val_3;
            var val_4;
            val_2 = buf.Length;
            if(val_2 < 1)
            {
                    return;
            }
            
            val_3 = (long)val_2;
            val_4 = val_2 - 1;
            goto label_2;
            label_4:
            val_2 = buf.Length;
            val_3 = val_3 - 1;
            val_4 = val_4 - 1;
            label_2:
            mem2[0] = b;
            if(val_3 >= 2)
            {
                goto label_4;
            }
        
        }
        public static byte[] CopyOf(byte[] data, int newLength)
        {
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  newLength, val2:  data.Length));
            return (System.Byte[])val_1;
        }
        public static char[] CopyOf(char[] data, int newLength)
        {
            char[] val_1 = new char[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  newLength, val2:  data.Length));
            return (System.Char[])val_1;
        }
        public static int[] CopyOf(int[] data, int newLength)
        {
            int[] val_1 = new int[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  newLength, val2:  data.Length));
            return (System.Int32[])val_1;
        }
        public static long[] CopyOf(long[] data, int newLength)
        {
            long[] val_1 = new long[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  newLength, val2:  data.Length));
            return (System.Int64[])val_1;
        }
        public static Org.BouncyCastle.Math.BigInteger[] CopyOf(Org.BouncyCastle.Math.BigInteger[] data, int newLength)
        {
            Org.BouncyCastle.Math.BigInteger[] val_1 = new Org.BouncyCastle.Math.BigInteger[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  System.Math.Min(val1:  newLength, val2:  data.Length));
            return val_1;
        }
        public static byte[] CopyOfRange(byte[] data, int from, int to)
        {
            byte[] val_2 = new byte[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  from, destinationArray:  val_2, destinationIndex:  0, length:  System.Math.Min(val1:  Org.BouncyCastle.Utilities.Arrays.GetLength(from:  from, to:  to), val2:  data.Length - from));
            return (System.Byte[])val_2;
        }
        public static int[] CopyOfRange(int[] data, int from, int to)
        {
            int[] val_2 = new int[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  from, destinationArray:  val_2, destinationIndex:  0, length:  System.Math.Min(val1:  Org.BouncyCastle.Utilities.Arrays.GetLength(from:  from, to:  to), val2:  data.Length - from));
            return (System.Int32[])val_2;
        }
        public static long[] CopyOfRange(long[] data, int from, int to)
        {
            long[] val_2 = new long[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  from, destinationArray:  val_2, destinationIndex:  0, length:  System.Math.Min(val1:  Org.BouncyCastle.Utilities.Arrays.GetLength(from:  from, to:  to), val2:  data.Length - from));
            return (System.Int64[])val_2;
        }
        public static Org.BouncyCastle.Math.BigInteger[] CopyOfRange(Org.BouncyCastle.Math.BigInteger[] data, int from, int to)
        {
            Org.BouncyCastle.Math.BigInteger[] val_2 = new Org.BouncyCastle.Math.BigInteger[0];
            System.Array.Copy(sourceArray:  data, sourceIndex:  from, destinationArray:  val_2, destinationIndex:  0, length:  System.Math.Min(val1:  Org.BouncyCastle.Utilities.Arrays.GetLength(from:  from, to:  to), val2:  data.Length - from));
            return val_2;
        }
        private static int GetLength(int from, int to)
        {
            int val_1 = to - from;
            if((val_1 & 2147483648) == 0)
            {
                    return val_1;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  from + " > "(" > ") + to);
        }
        public static byte[] Append(byte[] a, byte b)
        {
            System.Array val_4;
            if(a != null)
            {
                    int val_1 = a.Length + 1;
                byte[] val_2 = new byte[0];
                val_4 = val_2;
                System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            }
            else
            {
                    val_4 = new byte[1];
            }
            
            mem2[0] = b;
            return (System.Byte[])val_4;
        }
        public static short[] Append(short[] a, short b)
        {
            System.Array val_4;
            if(a != null)
            {
                    int val_1 = a.Length + 1;
                short[] val_2 = new short[0];
                val_4 = val_2;
                System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            }
            else
            {
                    val_4 = new short[1];
            }
            
            mem2[0] = b;
            return (System.Int16[])val_4;
        }
        public static int[] Append(int[] a, int b)
        {
            System.Array val_4;
            if(a != null)
            {
                    int val_1 = a.Length + 1;
                int[] val_2 = new int[0];
                val_4 = val_2;
                System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            }
            else
            {
                    val_4 = new int[1];
            }
            
            mem2[0] = b;
            return (System.Int32[])val_4;
        }
        public static byte[] Concatenate(byte[] a, byte[] b)
        {
            System.Byte[] val_3;
            if(a == null)
            {
                goto label_1;
            }
            
            if(b == null)
            {
                goto label_2;
            }
            
            int val_1 = b.Length + a.Length;
            byte[] val_2 = new byte[0];
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            System.Array.Copy(sourceArray:  b, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  a.Length, length:  b.Length);
            return (System.Byte[])val_2;
            label_1:
            val_3 = b;
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3 = a);
            label_2:
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3);
        }
        public static byte[] ConcatenateAll(byte[][] vs)
        {
            var val_3;
            var val_4;
            System.Byte[] val_5;
            System.Byte[][] val_1 = new System.Byte[][0];
            if(vs.Length >= 1)
            {
                    val_3 = 0;
                val_4 = 0;
                do
            {
                val_5 = vs[0];
                if(val_5 != null)
            {
                    val_1[0] = val_5;
                val_3 = val_3 + 1;
                val_4 = val_4 + vs[0x0][0].Length;
            }
            
            }
            while((0 + 1) < vs.Length);
            
            }
            else
            {
                    val_4 = 0;
                val_3 = 0;
            }
            
            byte[] val_4 = new byte[0];
            if(val_3 < 1)
            {
                    return (System.Byte[])val_4;
            }
            
            var val_5 = 0;
            val_3 = val_3;
            do
            {
                System.Array.Copy(sourceArray:  1152921512556292880, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  System.Byte[][].__il2cppRuntimeField_namespaze);
                val_5 = val_5 + 1;
            }
            while(val_3 != val_5);
            
            return (System.Byte[])val_4;
        }
        public static int[] Concatenate(int[] a, int[] b)
        {
            System.Int32[] val_3;
            if(a == null)
            {
                goto label_1;
            }
            
            if(b == null)
            {
                goto label_2;
            }
            
            int val_1 = b.Length + a.Length;
            int[] val_2 = new int[0];
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            System.Array.Copy(sourceArray:  b, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  a.Length, length:  b.Length);
            return (System.Int32[])val_2;
            label_1:
            val_3 = b;
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3 = a);
            label_2:
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_3);
        }
        public static byte[] Prepend(byte[] a, byte b)
        {
            System.Array val_4;
            if(a == null)
            {
                goto label_1;
            }
            
            int val_1 = a.Length + 1;
            byte[] val_2 = new byte[0];
            val_4 = val_2;
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  1, length:  a.Length);
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_4 = new byte[1];
            if(val_4 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            val_4[0] = b;
            return (System.Byte[])val_4;
        }
        public static short[] Prepend(short[] a, short b)
        {
            System.Array val_4;
            if(a == null)
            {
                goto label_1;
            }
            
            int val_1 = a.Length + 1;
            short[] val_2 = new short[0];
            val_4 = val_2;
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  1, length:  a.Length);
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_4 = new short[1];
            if(val_4 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            val_4[0] = b;
            return (System.Int16[])val_4;
        }
        public static int[] Prepend(int[] a, int b)
        {
            System.Array val_4;
            if(a == null)
            {
                goto label_1;
            }
            
            int val_1 = a.Length + 1;
            int[] val_2 = new int[0];
            val_4 = val_2;
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  1, length:  a.Length);
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_4 = new int[1];
            if(val_4 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            val_4[0] = b;
            return (System.Int32[])val_4;
        }
        public static byte[] Reverse(byte[] a)
        {
            var val_4;
            if(a != null)
            {
                    int val_1 = a.Length & 4294967295;
                int val_3 = a.Length - 1;
                val_4 = new byte[0];
                if((val_3 & 2147483648) != 0)
            {
                    return (System.Byte[])val_4;
            }
            
                var val_5 = 0;
                var val_6 = (long)val_3;
                do
            {
                val_5 = val_5 + 1;
                val_6 = val_6 - 1;
                val_4[val_6] = a[0];
            }
            while(a.Length != val_5);
            
                return (System.Byte[])val_4;
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
        public static int[] Reverse(int[] a)
        {
            var val_4;
            if(a != null)
            {
                    int val_1 = a.Length & 4294967295;
                int val_3 = a.Length - 1;
                val_4 = new int[0];
                if((val_3 & 2147483648) != 0)
            {
                    return (System.Int32[])val_4;
            }
            
                var val_5 = 0;
                var val_6 = (long)val_3;
                do
            {
                val_5 = val_5 + 1;
                val_6 = val_6 - 1;
                val_4[((long)(int)((a.Length - 1))) << 2] = a[0];
            }
            while(a.Length != val_5);
            
                return (System.Int32[])val_4;
            }
            
            val_4 = 0;
            return (System.Int32[])val_4;
        }
        protected Arrays()
        {
        
        }
    
    }

}
