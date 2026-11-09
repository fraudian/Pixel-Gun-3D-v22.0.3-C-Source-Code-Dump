using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsUtilities
    {
        // Fields
        public static readonly byte[] EmptyBytes;
        public static readonly short[] EmptyShorts;
        public static readonly int[] EmptyInts;
        public static readonly long[] EmptyLongs;
        internal static readonly byte[] SSL_CLIENT;
        internal static readonly byte[] SSL_SERVER;
        internal static readonly byte[][] SSL3_CONST;
        
        // Methods
        public static void CheckUint8(int i)
        {
            if((i & 4294967040) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint8(long i)
        {
            if((i & (-256)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint16(int i)
        {
            if((i & 4294901760) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint16(long i)
        {
            if((i & (-65536)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint24(int i)
        {
            if((i & 4278190080) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint24(long i)
        {
            if((i & (-16777216)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint32(long i)
        {
            if((i & (-4294967296)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint48(long i)
        {
            if((i & (-281474976710656)) == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static void CheckUint64(long i)
        {
        
        }
        public static bool IsValidUint8(int i)
        {
            return (bool)((i & (-256)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint8(long i)
        {
            return (bool)((i & (-256)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint16(int i)
        {
            return (bool)((i & (-65536)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint16(long i)
        {
            return (bool)((i & (-65536)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint24(int i)
        {
            return (bool)((i & (-16777216)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint24(long i)
        {
            return (bool)((i & (-16777216)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint32(long i)
        {
            return (bool)((i & (-4294967296)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint48(long i)
        {
            return (bool)((i & (-281474976710656)) != 0) ? 1 : 0;
        }
        public static bool IsValidUint64(long i)
        {
            return true;
        }
        public static bool IsSsl(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_2 = context.ServerVersion;
            if(val_2 != null)
            {
                    return val_2.IsSsl;
            }
            
            return val_2.IsSsl;
        }
        public static bool IsTlsV11(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
        {
            null = null;
            if(Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11 != null)
            {
                    return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version:  version.GetEquivalentTLSVersion());
            }
            
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version:  version.GetEquivalentTLSVersion());
        }
        public static bool IsTlsV11(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV11(version:  context.ServerVersion);
        }
        public static bool IsTlsV12(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
        {
            null = null;
            if(Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12 != null)
            {
                    return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version:  version.GetEquivalentTLSVersion());
            }
            
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version:  version.GetEquivalentTLSVersion());
        }
        public static bool IsTlsV12(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(version:  context.ServerVersion);
        }
        public static void WriteUint8(byte i, System.IO.Stream output)
        {
            if(output == null)
            {
                
            }
        
        }
        public static void WriteUint8(byte i, byte[] buf, int offset)
        {
            buf[(long)offset] = i;
        }
        public static void WriteUint16(int i, System.IO.Stream output)
        {
            int val_1 = i >> 8;
            if(output == null)
            {
                
            }
        
        }
        public static void WriteUint16(int i, byte[] buf, int offset)
        {
            buf[(long)offset] = i >> 8;
            buf[(long)offset + 1] = i;
        }
        public static void WriteUint24(int i, System.IO.Stream output)
        {
            int val_1 = i >> 16;
            if(output != null)
            {
                    int val_2 = i >> 8;
            }
            else
            {
                    int val_3 = i >> 8;
            }
        
        }
        public static void WriteUint24(int i, byte[] buf, int offset)
        {
            buf[(long)offset] = i >> 16;
            buf[(long)offset + 1] = i >> 8;
            buf[(long)offset + 2] = i;
        }
        public static void WriteUint32(long i, System.IO.Stream output)
        {
            long val_1 = i >> 24;
            if(output != null)
            {
                    long val_2 = i >> 16;
            }
            else
            {
                    long val_3 = i >> 16;
            }
            
            long val_4 = i >> 8;
            if(output == null)
            {
                
            }
        
        }
        public static void WriteUint32(long i, byte[] buf, int offset)
        {
            buf[(long)offset] = i >> 24;
            buf[(long)offset + 1] = i >> 16;
            buf[(long)offset + 2] = i >> 8;
            buf[(long)offset + 3] = i;
        }
        public static void WriteUint48(long i, System.IO.Stream output)
        {
            long val_1 = i >> 40;
            if(output != null)
            {
                    long val_2 = i >> 32;
            }
            else
            {
                    long val_3 = i >> 32;
            }
            
            long val_4 = i >> 24;
            if(output != null)
            {
                    long val_5 = i >> 16;
            }
            else
            {
                    long val_6 = i >> 16;
            }
            
            long val_7 = i >> 8;
            if(output == null)
            {
                
            }
        
        }
        public static void WriteUint48(long i, byte[] buf, int offset)
        {
            buf[(long)offset] = i >> 40;
            buf[(long)offset + 1] = i >> 32;
            buf[(long)offset + 2] = i >> 24;
            buf[(long)offset + 3] = i >> 16;
            buf[(long)offset + 4] = i >> 8;
            buf[(long)offset + 5] = i;
        }
        public static void WriteUint64(long i, System.IO.Stream output)
        {
            long val_1 = i >> 56;
            if(output != null)
            {
                    long val_2 = i >> 48;
            }
            else
            {
                    long val_3 = i >> 48;
            }
            
            long val_4 = i >> 40;
            if(output != null)
            {
                    long val_5 = i >> 32;
            }
            else
            {
                    long val_6 = i >> 32;
            }
            
            long val_7 = i >> 24;
            if(output != null)
            {
                    long val_8 = i >> 16;
            }
            else
            {
                    long val_9 = i >> 16;
            }
            
            long val_10 = i >> 8;
            if(output == null)
            {
                
            }
        
        }
        public static void WriteUint64(long i, byte[] buf, int offset)
        {
            buf[(long)offset] = i >> 56;
            buf[(long)offset + 1] = i >> 48;
            buf[(long)offset + 2] = i >> 40;
            buf[(long)offset + 3] = i >> 32;
            buf[(long)offset + 4] = i >> 24;
            buf[(long)offset + 5] = i >> 16;
            buf[(long)offset + 6] = i >> 8;
            buf[(long)offset + 7] = i;
        }
        public static void WriteOpaque8(byte[] buf, System.IO.Stream output)
        {
            if(output == null)
            {
                
            }
        
        }
        public static void WriteOpaque16(byte[] buf, System.IO.Stream output)
        {
            System.IO.Stream val_1 = output;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  buf.Length, output:  val_1 = output);
            if(buf == null)
            {
                goto label_4;
            }
            
            label_7:
            val_1 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
            label_4:
            if(val_1 != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public static void WriteOpaque24(byte[] buf, System.IO.Stream output)
        {
            System.IO.Stream val_1 = output;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(i:  buf.Length, output:  val_1 = output);
            if(buf == null)
            {
                goto label_4;
            }
            
            label_7:
            val_1 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
            label_4:
            if(val_1 != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public static void WriteUint8Array(byte[] uints, System.IO.Stream output)
        {
            if(uints == null)
            {
                goto label_0;
            }
            
            label_3:
            output = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
            label_0:
            if(output != 0)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public static void WriteUint8Array(byte[] uints, byte[] buf, int offset)
        {
            var val_2 = 0;
            goto label_1;
            label_6:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  uints[0], buf:  buf, offset:  offset + val_2);
            val_2 = 1;
            label_1:
            if(val_2 < uints.Length)
            {
                goto label_6;
            }
        
        }
        public static void WriteUint8ArrayWithUint8Length(byte[] uints, System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(i:  uints.Length);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8Array(uints:  uints, output:  output);
        }
        public static void WriteUint8ArrayWithUint8Length(byte[] uints, byte[] buf, int offset)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(i:  uints.Length);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  uints.Length, buf:  buf, offset:  offset);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8Array(uints:  uints, buf:  buf, offset:  offset + 1);
        }
        public static void WriteUint16Array(int[] uints, System.IO.Stream output)
        {
            int val_1;
            goto label_1;
            label_6:
            val_1 = uints[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_1, output:  output);
            0 = 1;
            label_1:
            if(0 < uints.Length)
            {
                goto label_6;
            }
        
        }
        public static void WriteUint16Array(int[] uints, byte[] buf, int offset)
        {
            int val_1;
            var val_2;
            val_1 = offset;
            val_2 = 0;
            goto label_1;
            label_6:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  uints[0], buf:  buf, offset:  val_1);
            val_1 = val_1 + 2;
            val_2 = 1;
            label_1:
            if(val_2 < uints.Length)
            {
                goto label_6;
            }
        
        }
        public static void WriteUint16ArrayWithUint16Length(int[] uints, System.IO.Stream output)
        {
            int val_1 = uints.Length << 1;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_1);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_1, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16Array(uints:  uints, output:  output);
        }
        public static void WriteUint16ArrayWithUint16Length(int[] uints, byte[] buf, int offset)
        {
            int val_1 = uints.Length << 1;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_1);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_1, buf:  buf, offset:  offset);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16Array(uints:  uints, buf:  buf, offset:  offset + 2);
        }
        public static byte[] EncodeOpaque8(byte[] buf)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(i:  buf.Length);
            if(buf != null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Prepend(a:  buf, b:  buf.Length);
            }
            
            return Org.BouncyCastle.Utilities.Arrays.Prepend(a:  buf, b:  buf.Length);
        }
        public static byte[] EncodeUint8ArrayWithUint8Length(byte[] uints)
        {
            int val_1 = uints.Length + 1;
            byte[] val_2 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(uints:  uints, buf:  val_2, offset:  0);
            return (System.Byte[])val_2;
        }
        public static byte[] EncodeUint16ArrayWithUint16Length(int[] uints)
        {
            int val_3 = uints.Length;
            val_3 = val_3 << 1;
            int val_1 = val_3 + 2;
            byte[] val_2 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(uints:  uints, buf:  val_2, offset:  0);
            return (System.Byte[])val_2;
        }
        public static byte ReadUint8(System.IO.Stream input)
        {
            if((input & 2147483648) == 0)
            {
                    return (byte)input;
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        public static byte ReadUint8(byte[] buf, int offset)
        {
            return (byte)buf[(long)offset];
        }
        public static int ReadUint16(System.IO.Stream input)
        {
            System.IO.Stream val_2 = input;
            if((val_2 & 2147483648) == 0)
            {
                    val_2 = val_2 | (input << 8);
                return (int)val_2;
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        public static int ReadUint16(byte[] buf, int offset)
        {
            int val_2 = buf.Length;
            if(val_2 <= offset)
            {
                    val_2 = buf.Length;
            }
            
            byte val_2 = buf[(long)offset];
            return (int)buf[(long)offset + 1];
        }
        public static int ReadUint24(System.IO.Stream input)
        {
            System.IO.Stream val_3 = input;
            if((val_3 & 2147483648) == 0)
            {
                    System.IO.Stream val_1 = input << 8;
                val_1 = val_1 | (input << 16);
                val_3 = val_1 | val_3;
                return (int)val_3;
            }
            
            System.IO.EndOfStreamException val_2 = new System.IO.EndOfStreamException();
        }
        public static int ReadUint24(byte[] buf, int offset)
        {
            int val_4 = buf.Length;
            if(val_4 <= offset)
            {
                    val_4 = buf.Length;
            }
            
            int val_1 = offset + 1;
            if(val_1 >= val_4)
            {
                    val_4 = buf.Length;
            }
            
            byte val_5 = buf[(long)val_1];
            buf = (buf[(long)offset] << 16) | (buf[(long)offset + 2]);
            return (int)buf;
        }
        public static long ReadUint32(System.IO.Stream input)
        {
            System.IO.Stream val_3 = input;
            if((val_3 & 2147483648) == 0)
            {
                    System.IO.Stream val_1 = input << 16;
                val_1 = val_1 | (input << 24);
                val_1 = val_1 | (input << 8);
                val_3 = val_1 | val_3;
                return (long)val_3;
            }
            
            System.IO.EndOfStreamException val_2 = new System.IO.EndOfStreamException();
        }
        public static long ReadUint32(byte[] buf, int offset)
        {
            int val_5 = buf.Length;
            if(val_5 <= offset)
            {
                    val_5 = buf.Length;
            }
            
            int val_1 = offset + 1;
            if(val_1 >= val_5)
            {
                    val_5 = buf.Length;
            }
            
            byte val_6 = buf[(long)val_1];
            int val_2 = offset + 2;
            if(val_2 >= val_5)
            {
                    val_5 = buf.Length;
            }
            
            byte val_7 = buf[(long)val_2];
            buf = (buf[(long)offset] << 24) | (buf[(long)offset + 3]);
            return (long)buf;
        }
        public static long ReadUint48(System.IO.Stream input)
        {
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input:  input);
            int val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input:  input);
            val_2 = val_2 | ((val_1) << 24);
            return (long)val_2;
        }
        public static long ReadUint48(byte[] buf, int offset)
        {
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf:  buf, offset:  offset);
            int val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf:  buf, offset:  offset + 3);
            val_3 = val_3 | ((val_1) << 24);
            return (long)val_3;
        }
        public static byte[] ReadAllOrNothing(int length, System.IO.Stream input)
        {
            var val_4;
            System.Byte[] val_5;
            var val_6;
            val_4 = length;
            if(val_4 <= 0)
            {
                goto label_1;
            }
            
            byte[] val_1 = new byte[0];
            val_5 = val_1;
            int val_2 = Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  input, buf:  val_1);
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            if(val_2 == val_4)
            {
                    return (System.Byte[])val_5;
            }
            
            System.IO.EndOfStreamException val_3 = new System.IO.EndOfStreamException();
            label_1:
            val_4 = 1152921505529954304;
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
            return (System.Byte[])val_5;
            label_2:
            val_5 = 0;
            return (System.Byte[])val_5;
        }
        public static byte[] ReadFully(int length, System.IO.Stream input)
        {
            var val_4;
            System.Byte[] val_5;
            var val_6;
            val_4 = length;
            if(val_4 > 0)
            {
                    byte[] val_1 = new byte[0];
                val_5 = val_1;
                if((Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  input, buf:  val_1)) == val_4)
            {
                    return val_5;
            }
            
                System.IO.EndOfStreamException val_3 = new System.IO.EndOfStreamException();
            }
            
            val_4 = 1152921505529954304;
            val_6 = null;
            val_6 = null;
            val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
            return val_5;
        }
        public static void ReadFully(byte[] buf, System.IO.Stream input)
        {
            if((Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  input, buf:  buf, off:  0, len:  buf.Length)) >= buf.Length)
            {
                    return;
            }
            
            System.IO.EndOfStreamException val_2 = new System.IO.EndOfStreamException();
        }
        public static byte[] ReadOpaque8(System.IO.Stream input)
        {
            byte val_2 = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255;
            byte[] val_3 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(buf:  val_3, input:  input);
            return (System.Byte[])val_3;
        }
        public static byte[] ReadOpaque16(System.IO.Stream input)
        {
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            byte[] val_2 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(buf:  val_2, input:  input);
            return (System.Byte[])val_2;
        }
        public static byte[] ReadOpaque24(System.IO.Stream input)
        {
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input:  input), input:  input);
        }
        public static byte[] ReadUint8Array(int count, System.IO.Stream input)
        {
            byte[] val_1 = new byte[0];
            if(count < 1)
            {
                    return (System.Byte[])val_1;
            }
            
            var val_3 = 0;
            do
            {
                mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input);
                val_3 = val_3 + 1;
            }
            while(count != val_3);
            
            return (System.Byte[])val_1;
        }
        public static int[] ReadUint16Array(int count, System.IO.Stream input)
        {
            int[] val_1 = new int[0];
            if(count < 1)
            {
                    return (System.Int32[])val_1;
            }
            
            var val_3 = 0;
            do
            {
                mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
                val_3 = val_3 + 1;
            }
            while(count != val_3);
            
            return (System.Int32[])val_1;
        }
        public static Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion(byte[] buf, int offset)
        {
            int val_2 = buf.Length;
            if(val_2 <= offset)
            {
                    val_2 = buf.Length;
            }
            
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.Get(major:  buf[(long)offset], minor:  buf[(long)offset + 1]);
        }
        public static Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion(System.IO.Stream input)
        {
            System.IO.Stream val_2 = input;
            if((input & 2147483648) == 0)
            {
                    val_2 = val_2 & (~(input >> 31));
                return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.Get(major:  val_2, minor:  input);
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        public static int ReadVersionRaw(byte[] buf, int offset)
        {
            int val_2 = buf.Length;
            if(val_2 <= offset)
            {
                    val_2 = buf.Length;
            }
            
            byte val_2 = buf[(long)offset];
            return (int)buf[(long)offset + 1];
        }
        public static int ReadVersionRaw(System.IO.Stream input)
        {
            System.IO.Stream val_2 = input;
            if((val_2 & 2147483648) == 0)
            {
                    val_2 = val_2 | (input << 8);
                return (int)val_2;
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        public static Org.BouncyCastle.Asn1.Asn1Object ReadAsn1Object(byte[] encoding)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  encoding, writable:  false);
            Org.BouncyCastle.Asn1.Asn1Object val_3 = new Org.BouncyCastle.Asn1.Asn1InputStream(inputStream:  val_1, limit:  encoding.Length).ReadObject();
            if((val_3 != null) && (val_1 == val_1))
            {
                    return val_3;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        public static Org.BouncyCastle.Asn1.Asn1Object ReadDerObject(byte[] encoding)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadAsn1Object(encoding:  encoding);
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  val_1.GetEncoded(encoding:  "DER"), b:  encoding)) != false)
            {
                    return val_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        public static void WriteGmtUnixTime(byte[] buf, int offset)
        {
            long val_1 = Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
            buf[(long)offset] = 0;
            buf[(long)offset + 1] = 0;
            buf[(long)offset + 2] = 0;
            buf[(long)offset + 3] = 18446744073709551;
        }
        public static void WriteVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, System.IO.Stream output)
        {
            int val_1 = version.MajorVersion;
            int val_2 = version.MinorVersion;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_338;
        }
        public static void WriteVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, byte[] buf, int offset)
        {
            buf[(long)offset] = version.MajorVersion;
            buf[(long)offset + 1] = version.MinorVersion;
        }
        public static System.Collections.IList GetDefaultDssSignatureAlgorithms()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(obj:  new Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash:  2, signature:  2));
        }
        public static System.Collections.IList GetDefaultECDsaSignatureAlgorithms()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(obj:  new Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash:  2, signature:  3));
        }
        public static System.Collections.IList GetDefaultRsaSignatureAlgorithms()
        {
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(obj:  new Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash:  2, signature:  1));
        }
        public static byte[] GetExtensionData(System.Collections.IDictionary extensions, int extensionType)
        {
            var val_3;
            var val_5;
            val_3 = extensions;
            if(val_3 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_5 = val_3;
                object val_2 = val_5.Item[extensionType];
                if(val_2 == null)
            {
                    return (System.Byte[])val_5;
            }
            
                val_5 = val_2;
                val_3 = null;
                if(val_5 != null)
            {
                    return (System.Byte[])val_5;
            }
            
            }
            
            val_5 = 0;
            return (System.Byte[])val_5;
        }
        public static System.Collections.IList GetDefaultSupportedSignatureAlgorithms()
        {
            var val_6;
            var val_7;
            var val_8;
            System.Collections.IList val_3 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_6 = 0;
            goto label_3;
            label_16:
            val_7 = 0;
            goto label_4;
            label_14:
            Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm val_4 = null;
            val_8 = 1152921505721910208;
            val_4 = new Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash:  new byte[5] {2, 3, 4, 5, 6}[0], signature:  192);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 2;
            int val_6 = val_3.Add(value:  val_4);
            val_7 = 1;
            label_4:
            if(val_7 < val_1.Length)
            {
                goto label_14;
            }
            
            val_6 = 1;
            label_3:
            if(val_6 < val_2.Length)
            {
                goto label_16;
            }
            
            return val_3;
        }
        public static Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials signerCredentials)
        {
            var val_5;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context)) != false)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    val_5 = 0;
                return val_3;
            }
            
            val_5 = signerCredentials;
            Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm val_3 = val_5.SignatureAndHashAlgorithm;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static bool HasExpectedEmptyExtensionData(System.Collections.IDictionary extensions, int extensionType, byte alertDescription)
        {
            var val_3;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  extensionType)) == null)
            {
                    return (bool)val_3;
            }
            
            if(val_1.Length == 0)
            {
                    val_3 = 1;
                return (bool)val_3;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  alertDescription);
        }
        public static Org.BouncyCastle.Crypto.Tls.TlsSession ImportSession(byte[] sessionID, Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters)
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsSession)new Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(sessionID:  sessionID, sessionParameters:  sessionParameters);
        }
        public static bool IsSignatureAlgorithmsExtensionAllowed(Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion)
        {
            null = null;
            if(Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12 != null)
            {
                    return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version:  clientVersion.GetEquivalentTLSVersion());
            }
            
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version:  clientVersion.GetEquivalentTLSVersion());
        }
        public static void AddSignatureAlgorithmsExtension(System.Collections.IDictionary extensions, System.Collections.IList supportedSignatureAlgorithms)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            extensions.set_Item(key:  13, value:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms:  supportedSignatureAlgorithms));
        }
        public static System.Collections.IList GetSignatureAlgorithmsExtension(System.Collections.IDictionary extensions)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  extensions, extensionType:  13);
            if(val_1 == null)
            {
                    return (System.Collections.IList)val_1;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadSignatureAlgorithmsExtension(extensionData:  val_1);
        }
        public static byte[] CreateSignatureAlgorithmsExtension(System.Collections.IList supportedSignatureAlgorithms)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms:  supportedSignatureAlgorithms, allowAnonymous:  false, output:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        public static System.Collections.IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
        {
            if(extensionData != null)
            {
                    System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  extensionData, writable:  false);
                Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_1);
                return (System.Collections.IList)Org.BouncyCastle.Crypto.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(allowAnonymous:  false, input:  val_1);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "extensionData");
        }
        public static void EncodeSupportedSignatureAlgorithms(System.Collections.IList supportedSignatureAlgorithms, bool allowAnonymous, System.IO.Stream output)
        {
            var val_14;
            var val_15;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_14 = supportedSignatureAlgorithms;
            if(val_14 == null)
            {
                goto label_1;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_15 = 1;
            if(val_14.Count < 1)
            {
                goto label_11;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_15 = 1;
            if(val_14.Count >= 32768)
            {
                goto label_11;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_15 = 1;
            int val_7 = val_14.Count << 1;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_7);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_7, output:  output);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_15 = 0;
            val_14 = val_14.GetEnumerator();
            label_41:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_15 = 0;
            if(val_14.MoveNext() == false)
            {
                goto label_27;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_15 = 1;
            val_22 = val_14.Current;
            if(val_22 != null)
            {
                    val_15 = 0;
                val_22 = 0;
            }
            
            if(allowAnonymous == false)
            {
                goto label_36;
            }
            
            if(val_22 != 0)
            {
                goto label_41;
            }
            
            goto label_41;
            label_36:
            if(0 == 0)
            {
                goto label_40;
            }
            
            goto label_41;
            label_27:
            val_23 = 0;
            val_24 = 0;
            goto label_42;
            label_11:
            System.ArgumentException val_16 = null;
            val_25 = val_16;
            val_16 = new System.ArgumentException(message:  "must have length from 1 to (2^15 - 1)", paramName:  "supportedSignatureAlgorithms");
            goto label_51;
            label_40:
            new System.ArgumentException() = new System.ArgumentException(message:  "SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
            label_1:
            System.ArgumentNullException val_18 = null;
            val_25 = val_18;
            val_18 = new System.ArgumentNullException(paramName:  "supportedSignatureAlgorithms");
            label_51:
            val_26 = 0;
            val_27 = val_25;
            if(val_26 != 1)
            {
                goto label_52;
            }
            
            val_23 = 0;
            label_42:
            if(val_14 != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_14.Dispose();
            }
            
            if(val_23 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_52:
        }
        public static System.Collections.IList ParseSupportedSignatureAlgorithms(bool allowAnonymous, System.IO.Stream input)
        {
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            if((val_1 < 2) || ((val_1 & 1) != 0))
            {
                goto label_16;
            }
            
            int val_2 = val_1 >> 1;
            System.Collections.IList val_3 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  val_2);
            var val_10 = 0;
            do
            {
                Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm val_4 = Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm.Parse(input:  input);
                if(allowAnonymous != true)
            {
                    if((val_4 & 255) == null)
            {
                goto label_9;
            }
            
            }
            
                var val_9 = 0;
                val_9 = val_9 + 1;
                int val_7 = val_3.Add(value:  val_4);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_2);
            
            return val_3;
            label_9:
            label_16:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            goto label_16;
        }
        public static void VerifySupportedSignatureAlgorithm(System.Collections.IList supportedSignatureAlgorithms, Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAlgorithm)
        {
            var val_17;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            string val_24;
            if(supportedSignatureAlgorithms == null)
            {
                goto label_1;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(supportedSignatureAlgorithms.Count < 1)
            {
                goto label_11;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(supportedSignatureAlgorithms.Count >= 32768)
            {
                goto label_11;
            }
            
            if(signatureAlgorithm == null)
            {
                goto label_12;
            }
            
            if((signatureAlgorithm & 255) == null)
            {
                goto label_61;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.IEnumerator val_7 = supportedSignatureAlgorithms.GetEnumerator();
            goto label_28;
            label_36:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17 = public System.Object System.Collections.IEnumerator::get_Current();
            if(val_7.Current != null)
            {
                    val_17 = 0;
            }
            
            if((0 != signatureAlgorithm) || (0 != signatureAlgorithm))
            {
                goto label_28;
            }
            
            goto label_29;
            label_28:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_7.MoveNext() == true)
            {
                goto label_36;
            }
            
            val_19 = 0;
            val_20 = 0;
            val_21 = 152;
            goto label_38;
            label_29:
            val_19 = 0;
            val_20 = 0;
            val_21 = 160;
            goto label_38;
            label_11:
            System.ArgumentException val_14 = null;
            val_22 = val_14;
            val_14 = new System.ArgumentException(message:  "must have length from 1 to (2^15 - 1)", paramName:  "supportedSignatureAlgorithms");
            goto label_41;
            label_1:
            val_24 = "supportedSignatureAlgorithms";
            goto label_40;
            label_12:
            System.ArgumentNullException val_15 = null;
            val_24 = "signatureAlgorithm";
            label_40:
            val_22 = val_15;
            val_15 = new System.ArgumentNullException(paramName:  val_24);
            goto label_41;
            label_38:
            if(supportedSignatureAlgorithms != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                supportedSignatureAlgorithms.Dispose();
            }
            
            if( == 1)
            {
                goto label_56;
            }
            
            if(160 != 160)
            {
                goto label_57;
            }
            
            return;
            label_56:
            if( != 0)
            {
                goto label_58;
            }
            
            goto label_61;
            label_57:
            if(( == 0) || (160 == 152))
            {
                goto label_61;
            }
            
            label_58:
            label_61:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_17 = null;
            val_22 = val_17;
            val_17 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            label_41:
        }
        public static byte[] PRF(Org.BouncyCastle.Crypto.Tls.TlsContext context, byte[] secret, string asciiLabel, byte[] seed, int size)
        {
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(context.ServerVersion.IsSsl != true)
            {
                    System.Byte[] val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(a:  Org.BouncyCastle.Utilities.Strings.ToByteArray(s:  asciiLabel), b:  seed);
                var val_12 = 0;
                val_12 = val_12 + 1;
                Org.BouncyCastle.Crypto.Tls.SecurityParameters val_7 = context.SecurityParameters;
                if(val_7 == null)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF_legacy(secret:  secret, label:  typeof(Org.BouncyCastle.Crypto.Tls.SecurityParameters).__il2cppRuntimeField_1A0, labelSeed:  val_5, size:  size);
            }
            
                byte[] val_9 = new byte[0];
                Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(digest:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreatePrfHash(prfAlgorithm:  val_7), secret:  secret, seed:  val_5, output:  val_9);
                return (System.Byte[])val_9;
            }
            
            System.InvalidOperationException val_10 = new System.InvalidOperationException(message:  "No PRF available for SSLv3 session");
        }
        public static byte[] PRF_legacy(byte[] secret, string asciiLabel, byte[] seed, int size)
        {
            System.Byte[] val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(a:  Org.BouncyCastle.Utilities.Strings.ToByteArray(s:  asciiLabel), b:  seed);
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF_legacy(secret:  secret, label:  val_2, labelSeed:  val_2, size:  size);
        }
        internal static byte[] PRF_legacy(byte[] secret, byte[] label, byte[] labelSeed, int size)
        {
            int val_11 = size;
            int val_12 = secret.Length;
            val_12 = ((val_12 + 1) < 0) ? (val_12 + 2) : (val_12 + 1);
            int val_3 = val_12 >> 1;
            byte[] val_4 = new byte[0];
            byte[] val_5 = new byte[0];
            System.Array.Copy(sourceArray:  secret, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  val_3);
            System.Array.Copy(sourceArray:  secret, sourceIndex:  secret.Length - val_3, destinationArray:  val_5, destinationIndex:  0, length:  val_3);
            byte[] val_7 = new byte[0];
            byte[] val_8 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(digest:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  1), secret:  val_4, seed:  labelSeed, output:  val_7);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(digest:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  2), secret:  val_5, seed:  labelSeed, output:  val_8);
            if(val_11 < 1)
            {
                    return (System.Byte[])val_7;
            }
            
            do
            {
                mem2[0] = 1152921505721910208 ^ 1152921505721910208;
                val_11 = 0 + 1;
            }
            while(val_11 != val_11);
            
            return (System.Byte[])val_7;
        }
        internal static byte[] Concat(byte[] a, byte[] b)
        {
            if(a == null)
            {
                goto label_1;
            }
            
            label_7:
            int val_1 = b.Length + a.Length;
            byte[] val_2 = new byte[0];
            if(a == null)
            {
                goto label_3;
            }
            
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            goto label_4;
            label_1:
            if(b != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_3:
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  a.Length);
            label_4:
            System.Array.Copy(sourceArray:  b, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  a.Length, length:  b.Length);
            return (System.Byte[])val_2;
        }
        internal static void HMacHash(Org.BouncyCastle.Crypto.IDigest digest, byte[] secret, byte[] seed, byte[] output)
        {
            var val_11;
            Org.BouncyCastle.Crypto.Macs.HMac val_1 = new Org.BouncyCastle.Crypto.Macs.HMac(digest:  digest);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_2 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  secret);
            var val_10 = 0;
            val_10 = val_10 + 1;
            int val_4 = digest.GetDigestSize();
            int val_11 = output.Length;
            val_11 = val_4 + val_11;
            val_11 = (val_11 - 1) / val_4;
            byte[] val_6 = new byte[641171680];
            if(val_11 < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            var val_12 = 0;
            do
            {
                System.Array.Copy(sourceArray:  new byte[641171680], sourceIndex:  0, destinationArray:  output, destinationIndex:  0, length:  System.Math.Min(val1:  val_4, val2:  val_13 + output.Length));
                val_11 = val_11 - 1;
                val_12 = val_12 + val_4;
                val_13 = val_13 - val_4;
            }
            while(val_11 != 0);
        
        }
        internal static void ValidateKeyUsage(Org.BouncyCastle.Asn1.X509.X509CertificateStructure c, int keyUsageBits)
        {
            var val_7;
            Org.BouncyCastle.Asn1.X509.X509Extensions val_2 = c.TbsCertificate.Extensions;
            if(val_2 == null)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            Org.BouncyCastle.Asn1.X509.X509Extension val_3 = val_2.GetExtension(oid:  Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage);
            if(val_3 == null)
            {
                    return;
            }
            
            byte val_7 = Org.BouncyCastle.Asn1.X509.KeyUsage.GetInstance(obj:  val_3).GetBytes()[0];
            val_7 = keyUsageBits & (~val_7);
            if(val_7 == 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  46);
        }
        internal static byte[] CalculateKeyBlock(Org.BouncyCastle.Crypto.Tls.TlsContext context, int size)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_2 = context.SecurityParameters;
            System.Byte[] val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(a:  val_2, b:  val_2);
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  context)) == false)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context:  context, secret:  val_2, asciiLabel:  "key expansion", seed:  val_3, size:  size);
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock_Ssl(master_secret:  val_2, random:  val_3, size:  size);
        }
        internal static byte[] CalculateKeyBlock_Ssl(byte[] master_secret, byte[] random, int size)
        {
            int val_17;
            var val_18;
            Org.BouncyCastle.Crypto.IDigest val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  1);
            Org.BouncyCastle.Crypto.IDigest val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  2);
            var val_19 = 0;
            val_19 = val_19 + 1;
            int val_4 = val_1.GetDigestSize();
            var val_20 = 0;
            val_20 = val_20 + 1;
            int val_6 = val_2.GetDigestSize();
            byte[] val_7 = new byte[0];
            val_17 = size;
            int val_8 = val_4 + val_17;
            byte[] val_9 = new byte[0];
            if(val_17 < 1)
            {
                    return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_9, from:  0, to:  size);
            }
            
            var val_28 = 0;
            var val_29 = 0;
            label_68:
            val_18 = null;
            val_18 = null;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32) == 0)
            {
                goto label_18;
            }
            
            label_25:
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_23;
            label_18:
            if(val_2 != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_23:
            val_2.BlockUpdate(input:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32, inOff:  0, length:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32 + 24);
            if(master_secret == null)
            {
                goto label_26;
            }
            
            label_33:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_31;
            label_26:
            if(val_2 != null)
            {
                goto label_33;
            }
            
            goto label_33;
            label_31:
            val_2.BlockUpdate(input:  master_secret, inOff:  0, length:  master_secret.Length);
            if(random == null)
            {
                goto label_34;
            }
            
            label_41:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_39;
            label_34:
            if(val_2 != null)
            {
                goto label_41;
            }
            
            goto label_41;
            label_39:
            val_2.BlockUpdate(input:  random, inOff:  0, length:  random.Length);
            var val_24 = 0;
            val_24 = val_24 + 1;
            int val_14 = val_2.DoFinal(output:  val_7, outOff:  0);
            if(master_secret == null)
            {
                goto label_47;
            }
            
            label_54:
            var val_25 = 0;
            val_25 = val_25 + 1;
            goto label_52;
            label_47:
            if(val_1 != null)
            {
                goto label_54;
            }
            
            goto label_54;
            label_52:
            val_1.BlockUpdate(input:  master_secret, inOff:  0, length:  master_secret.Length);
            if(val_7 == null)
            {
                goto label_55;
            }
            
            label_62:
            val_17 = val_7.Length;
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_60;
            label_55:
            if(val_1 != null)
            {
                goto label_62;
            }
            
            goto label_62;
            label_60:
            val_1.BlockUpdate(input:  val_7, inOff:  0, length:  val_17);
            var val_27 = 0;
            val_27 = val_27 + 1;
            int val_18 = val_1.DoFinal(output:  val_9, outOff:  0);
            val_28 = val_28 + 1;
            val_29 = val_29 + val_4;
            if(val_29 < size)
            {
                goto label_68;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data:  val_9, from:  0, to:  size);
        }
        internal static byte[] CalculateMasterSecret(Org.BouncyCastle.Crypto.Tls.TlsContext context, byte[] pre_master_secret)
        {
            var val_5;
            System.Byte[] val_6;
            var val_7;
            System.Byte[] val_8;
            var val_9;
            string val_10;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_2 = context.SecurityParameters;
            if(val_2 == null)
            {
                goto label_6;
            }
            
            val_5 = val_2;
            val_6 = val_2;
            if(val_2.extendedMasterSecret == false)
            {
                goto label_7;
            }
            
            label_9:
            val_7 = val_6;
            goto label_8;
            label_6:
            val_5 = 92;
            val_6 = 0;
            if(0 != 0)
            {
                goto label_9;
            }
            
            label_7:
            val_8 = val_6;
            System.Byte[] val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(a:  val_8, b:  val_6);
            label_8:
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  context)) != false)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateMasterSecret_Ssl(pre_master_secret:  pre_master_secret, random:  val_3);
            }
            
            if(0 != 0)
            {
                    val_8 = 1152921505525694464;
                val_9 = null;
                val_9 = null;
                return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context:  context, secret:  pre_master_secret, asciiLabel:  val_10 = "master secret", seed:  val_3, size:  48);
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context:  context, secret:  pre_master_secret, asciiLabel:  val_10, seed:  val_3, size:  48);
        }
        internal static byte[] CalculateMasterSecret_Ssl(byte[] pre_master_secret, byte[] random)
        {
            var val_17;
            Org.BouncyCastle.Crypto.IDigest val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  1);
            Org.BouncyCastle.Crypto.IDigest val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  2);
            var val_19 = 0;
            val_19 = val_19 + 1;
            int val_4 = val_1.GetDigestSize();
            var val_20 = 0;
            val_20 = val_20 + 1;
            int val_6 = val_2.GetDigestSize();
            byte[] val_7 = new byte[0];
            int val_8 = val_4 + (val_4 << 1);
            byte[] val_9 = new byte[0];
            var val_28 = 0;
            var val_29 = 0;
            label_67:
            val_17 = null;
            val_17 = null;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32) == 0)
            {
                goto label_17;
            }
            
            label_24:
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_22;
            label_17:
            if(val_2 != null)
            {
                goto label_24;
            }
            
            goto label_24;
            label_22:
            val_2.BlockUpdate(input:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32, inOff:  0, length:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST.Length + 32 + 24);
            if(pre_master_secret == null)
            {
                goto label_25;
            }
            
            label_32:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_30;
            label_25:
            if(val_2 != null)
            {
                goto label_32;
            }
            
            goto label_32;
            label_30:
            val_2.BlockUpdate(input:  pre_master_secret, inOff:  0, length:  pre_master_secret.Length);
            if(random == null)
            {
                goto label_33;
            }
            
            label_40:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_38;
            label_33:
            if(val_2 != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_38:
            val_2.BlockUpdate(input:  random, inOff:  0, length:  random.Length);
            var val_24 = 0;
            val_24 = val_24 + 1;
            int val_14 = val_2.DoFinal(output:  val_7, outOff:  0);
            if(pre_master_secret == null)
            {
                goto label_46;
            }
            
            label_53:
            var val_25 = 0;
            val_25 = val_25 + 1;
            goto label_51;
            label_46:
            if(val_1 != null)
            {
                goto label_53;
            }
            
            goto label_53;
            label_51:
            val_1.BlockUpdate(input:  pre_master_secret, inOff:  0, length:  pre_master_secret.Length);
            if(val_7 == null)
            {
                goto label_54;
            }
            
            label_61:
            var val_26 = 0;
            val_26 = val_26 + 1;
            goto label_59;
            label_54:
            if(val_1 != null)
            {
                goto label_61;
            }
            
            goto label_61;
            label_59:
            val_1.BlockUpdate(input:  val_7, inOff:  0, length:  val_7.Length);
            var val_27 = 0;
            val_27 = val_27 + 1;
            int val_18 = val_1.DoFinal(output:  val_9, outOff:  0);
            val_28 = val_28 + 1;
            val_29 = val_29 + val_4;
            if(val_28 != 3)
            {
                goto label_67;
            }
            
            return (System.Byte[])val_9;
        }
        internal static byte[] CalculateVerifyData(Org.BouncyCastle.Crypto.Tls.TlsContext context, string asciiLabel, byte[] handshakeHash)
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  context)) != false)
            {
                    return (System.Byte[])handshakeHash;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_3 = context.SecurityParameters;
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context:  context, secret:  val_3, asciiLabel:  asciiLabel, seed:  handshakeHash, size:  val_3);
        }
        public static Org.BouncyCastle.Crypto.IDigest CreateHash(byte hashAlgorithm)
        {
            byte val_1 = hashAlgorithm & 255;
            val_1 = val_1 - 1;
            if(val_1 <= 5)
            {
                    var val_9 = 106049484 + (((hashAlgorithm & 255) - 1)) << 2;
                val_9 = val_9 + 106049484;
            }
            else
            {
                    System.ArgumentException val_8 = new System.ArgumentException(message:  "unknown HashAlgorithm", paramName:  "hashAlgorithm");
            }
        
        }
        public static Org.BouncyCastle.Crypto.IDigest CreateHash(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
        {
            if(signatureAndHashAlgorithm == null)
            {
                    return (Org.BouncyCastle.Crypto.IDigest)new Org.BouncyCastle.Crypto.Tls.CombinedHash();
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  signatureAndHashAlgorithm);
        }
        public static Org.BouncyCastle.Crypto.IDigest CloneHash(byte hashAlgorithm, Org.BouncyCastle.Crypto.IDigest hash)
        {
            Org.BouncyCastle.Crypto.Digests.MD5Digest val_16;
            var val_18;
            val_16 = hash;
            byte val_1 = hashAlgorithm & 255;
            val_1 = val_1 - 1;
            if(val_1 <= 5)
            {
                    var val_16 = 106049508 + (((hashAlgorithm & 255) - 1)) << 2;
                val_16 = val_16 + 106049508;
            }
            else
            {
                    val_18 = new System.ArgumentException(message:  "unknown HashAlgorithm", paramName:  "hashAlgorithm");
            }
        
        }
        public static Org.BouncyCastle.Crypto.IDigest CreatePrfHash(int prfAlgorithm)
        {
            if(prfAlgorithm == 0)
            {
                    return (Org.BouncyCastle.Crypto.IDigest)new Org.BouncyCastle.Crypto.Tls.CombinedHash();
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm:  prfAlgorithm));
        }
        public static Org.BouncyCastle.Crypto.IDigest ClonePrfHash(int prfAlgorithm, Org.BouncyCastle.Crypto.IDigest hash)
        {
            Org.BouncyCastle.Crypto.IDigest val_5 = hash;
            if(prfAlgorithm != 0)
            {
                    return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm:  prfAlgorithm), hash:  val_5 = hash);
            }
            
            if(val_5 != null)
            {
                    val_5 = 0;
            }
            
            new Org.BouncyCastle.Crypto.Tls.CombinedHash() = new Org.BouncyCastle.Crypto.Tls.CombinedHash(t:  val_5);
            return (Org.BouncyCastle.Crypto.IDigest)new Org.BouncyCastle.Crypto.Tls.CombinedHash();
        }
        public static byte GetHashAlgorithmForPrfAlgorithm(int prfAlgorithm)
        {
            var val_2;
            string val_4;
            if(prfAlgorithm == 1)
            {
                goto label_1;
            }
            
            if(prfAlgorithm != 2)
            {
                goto label_2;
            }
            
            val_2 = 5;
            return (byte)val_2;
            label_1:
            val_2 = 4;
            return (byte)val_2;
            label_2:
            if(prfAlgorithm == 0)
            {
                    val_4 = "legacy PRF not a valid algorithm";
            }
            else
            {
                    val_4 = "unknown PrfAlgorithm";
            }
            
            null = new System.ArgumentException(message:  val_4, paramName:  "prfAlgorithm");
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOidForHashAlgorithm(byte hashAlgorithm)
        {
            byte val_1 = hashAlgorithm & 255;
            val_1 = val_1 - 1;
            if(val_1 <= 5)
            {
                    var val_3 = 106049532 + (((hashAlgorithm & 255) - 1)) << 2;
                val_3 = val_3 + 106049532;
            }
            else
            {
                    System.ArgumentException val_2 = new System.ArgumentException(message:  "unknown HashAlgorithm", paramName:  "hashAlgorithm");
            }
        
        }
        internal static short GetClientCertificateType(Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate, Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
        {
            Org.BouncyCastle.Asn1.X509.X509CertificateStructure val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = clientCertificate;
            if((val_9 & 1) != 0)
            {
                    val_10 = 65535;
                return (short);
            }
            
            val_9 = val_9;
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter val_2 = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo:  val_9.SubjectPublicKeyInfo);
            if(val_2.IsPrivate != true)
            {
                    if(val_2 != null)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(c:  val_9, keyUsageBits:  128);
                val_10 = 64;
                return (short);
            }
            
                new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  43);
            }
            
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            val_11 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            if(0 == 1)
            {
                    val_12 = val_11;
                if((null & 1) != 0)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8 = null;
                val_12 = val_8;
                val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  43, alertCause:  1152921505528889344);
            }
            
                mem[8] = null;
                val_11 = 8;
            }
        
        }
        internal static void TrackHashAlgorithms(Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash handshakeHash, System.Collections.IList supportedSignatureAlgorithms)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_17;
            var val_18;
            var val_20;
            val_12 = supportedSignatureAlgorithms;
            if(val_12 == null)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = 0;
            System.Collections.IEnumerator val_2 = val_12.GetEnumerator();
            label_29:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = 0;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_13 = 1;
            val_17 = public System.Object System.Collections.IEnumerator::get_Current();
            val_18 = val_2.Current;
            if(val_18 != null)
            {
                    val_17 = 0;
                val_13 = 0;
            }
            
            if(val_18 != null)
            {
                    val_17 = null;
                val_17 = 0;
                val_13 = 0;
                val_18 = 0;
            }
            
            if((Org.BouncyCastle.Crypto.Tls.HashAlgorithm.IsPrivate(hashAlgorithm:  0)) == true)
            {
                goto label_29;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 2;
            handshakeHash.TrackHashAlgorithm(hashAlgorithm:  0);
            goto label_29;
            label_11:
            val_11 = 0;
            val_20 = 0;
            val_12 = val_2;
            if(val_12 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_12.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public static bool HasSigningCapability(byte clientCertificateType)
        {
            byte val_1 = clientCertificateType & 255;
            if((val_1 - 1) < 2)
            {
                    return true;
            }
            
            return (bool)(val_1 == 64) ? 1 : 0;
        }
        public static Org.BouncyCastle.Crypto.Tls.TlsSigner CreateTlsSigner(byte clientCertificateType)
        {
            var val_6;
            byte val_1 = clientCertificateType & 255;
            if(val_1 == 1)
            {
                goto label_1;
            }
            
            if(val_1 == 64)
            {
                goto label_2;
            }
            
            if(val_1 != 2)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsDssSigner val_2 = null;
            val_6 = val_2;
            val_2 = new Org.BouncyCastle.Crypto.Tls.TlsDssSigner();
            return (Org.BouncyCastle.Crypto.Tls.TlsSigner)val_6;
            label_1:
            Org.BouncyCastle.Crypto.Tls.TlsRsaSigner val_3 = null;
            val_6 = val_3;
            val_3 = new Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
            return (Org.BouncyCastle.Crypto.Tls.TlsSigner)val_6;
            label_2:
            Org.BouncyCastle.Crypto.Tls.TlsECDsaSigner val_4 = null;
            val_6 = val_4;
            val_4 = new Org.BouncyCastle.Crypto.Tls.TlsECDsaSigner();
            return (Org.BouncyCastle.Crypto.Tls.TlsSigner)val_6;
            label_3:
            System.ArgumentException val_5 = new System.ArgumentException(message:  "not a type with signing capability", paramName:  "clientCertificateType");
        }
        private static byte[][] GenSsl3Const()
        {
            System.Byte[][] val_1 = new System.Byte[][10];
            label_7:
            byte[] val_3 = new byte[0];
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  val_3, b:  0 + 65);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_3 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            mem2[0] = val_3;
            if((0 + 1) != 10)
            {
                goto label_7;
            }
            
            return val_1;
        }
        private static System.Collections.IList VectorOfOne(object obj)
        {
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  1);
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_3 = val_1.Add(value:  obj);
            return val_1;
        }
        public static int GetCipherType(int ciphersuite)
        {
            var val_5;
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(ciphersuite:  ciphersuite);
            if((val_1 - 1) < 20)
            {
                    val_5 = mem[106054112 + ((val_1 - 1)) << 2];
                val_5 = 106054112 + ((val_1 - 1)) << 2;
                return (int)val_5;
            }
            
            if((val_1 - 102) < 3)
            {
                    val_5 = 2;
                return (int)val_5;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static int GetEncryptionAlgorithm(int ciphersuite)
        {
            var val_3;
            if(ciphersuite > 49327)
            {
                goto label_1;
            }
            
            if((ciphersuite - 1) > 195)
            {
                goto label_2;
            }
            
            var val_3 = 106049556 + ((ciphersuite - 1)) << 2;
            val_3 = val_3 + 106049556;
            goto (106049556 + ((ciphersuite - 1)) << 2 + 106049556);
            label_1:
            var val_4 = 52391;
            val_4 = ciphersuite + val_4;
            if(val_4 < 7)
            {
                goto label_4;
            }
            
            var val_5 = 65279;
            val_5 = ciphersuite + val_5;
            if(val_5 >= 22)
            {
                goto label_10;
            }
            
            var val_6 = 4128831;
            val_6 = val_6 >> val_5;
            if((val_6 & 1) == 0)
            {
                goto label_10;
            }
            
            val_3 = mem[106054192 + ((ciphersuite + 65279)) << 2];
            val_3 = 106054192 + ((ciphersuite + 65279)) << 2;
            return (int);
            label_4:
            val_3 = 102;
            return (int);
            label_2:
            var val_7 = -49153;
            val_7 = ciphersuite + val_7;
            if(val_7 > 174)
            {
                goto label_10;
            }
            
            var val_8 = 106050340 + ((ciphersuite + -49153)) << 2;
            val_8 = val_8 + 106050340;
            goto (106050340 + ((ciphersuite + -49153)) << 2 + 106050340);
            label_10:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static int GetKeyExchangeAlgorithm(int ciphersuite)
        {
            if(ciphersuite > 196)
            {
                goto label_1;
            }
            
            if((ciphersuite - 1) > 195)
            {
                goto label_17;
            }
            
            var val_3 = 106051856 + ((ciphersuite - 1)) << 2;
            val_3 = val_3 + 106051856;
            goto (106051856 + ((ciphersuite - 1)) << 2 + 106051856);
            label_1:
            var val_4 = -49153;
            val_4 = ciphersuite + val_4;
            if(val_4 > 174)
            {
                goto label_4;
            }
            
            var val_5 = 106051040 + ((ciphersuite + -49153)) << 2;
            val_5 = val_5 + 106051040;
            goto (106051040 + ((ciphersuite + -49153)) << 2 + 106051040);
            label_4:
            var val_6 = 65279;
            val_6 = ciphersuite + val_6;
            if(val_6 > 21)
            {
                goto label_15;
            }
            
            var val_7 = 106051768 + ((ciphersuite + 65279)) << 2;
            val_7 = val_7 + 106051768;
            goto (106051768 + ((ciphersuite + 65279)) << 2 + 106051768);
            label_15:
            var val_8 = 52391;
            val_8 = ciphersuite + val_8;
            if(val_8 > 6)
            {
                goto label_17;
            }
            
            var val_9 = 106051740 + ((ciphersuite + 52391)) << 2;
            val_9 = val_9 + 106051740;
            goto (106051740 + ((ciphersuite + 52391)) << 2 + 106051740);
            label_17:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static int GetMacAlgorithm(int ciphersuite)
        {
            var val_4;
            if(ciphersuite > 49327)
            {
                goto label_1;
            }
            
            if((ciphersuite - 1) > 4)
            {
                goto label_2;
            }
            
            var val_4 = 106052640 + ((ciphersuite - 1)) << 2;
            val_4 = val_4 + 106052640;
            goto (106052640 + ((ciphersuite - 1)) << 2 + 106052640);
            label_1:
            var val_5 = 65279;
            val_5 = ciphersuite + val_5;
            val_4 = 0;
            if(val_5 <= 21)
            {
                    val_5 = 1 << val_5;
                val_5 = val_5 & 4128831;
                if(val_5 != 0)
            {
                    return (int);
            }
            
            }
            
            var val_6 = 52391;
            val_6 = ciphersuite + val_6;
            if(val_6 < 7)
            {
                    return (int);
            }
            
            goto label_10;
            label_2:
            if((ciphersuite - 10) > 186)
            {
                goto label_8;
            }
            
            var val_7 = 106052660 + ((ciphersuite - 10)) << 2;
            val_7 = val_7 + 106052660;
            goto (106052660 + ((ciphersuite - 10)) << 2 + 106052660);
            label_8:
            var val_8 = -49153;
            val_8 = ciphersuite + val_8;
            if(val_8 > 174)
            {
                goto label_10;
            }
            
            var val_9 = 106053408 + ((ciphersuite + -49153)) << 2;
            val_9 = val_9 + 106053408;
            goto (106053408 + ((ciphersuite + -49153)) << 2 + 106053408);
            label_10:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetMinimumVersion(int ciphersuite)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            if(ciphersuite > 49202)
            {
                goto label_1;
            }
            
            if(ciphersuite > 107)
            {
                goto label_2;
            }
            
            int val_1 = ciphersuite - 59;
            if(val_1 > 48)
            {
                goto label_19;
            }
            
            val_3 = 1 << val_1;
            val_4 = 63;
            goto label_4;
            label_1:
            if(ciphersuite > 49327)
            {
                goto label_5;
            }
            
            var val_3 = 49265;
            val_3 = ciphersuite + val_3;
            if(val_3 < 34)
            {
                goto label_20;
            }
            
            var val_4 = 49307;
            val_4 = ciphersuite + val_4;
            if(val_4 > 19)
            {
                goto label_19;
            }
            
            goto label_20;
            label_2:
            int val_2 = ciphersuite - 156;
            if(val_2 > 41)
            {
                goto label_9;
            }
            
            val_3 = 1 << val_2;
            val_4 = 4393751543808;
            val_4 = 1023;
            label_4:
            val_3 = val_3 & 4396973028351;
            if(val_3 != 0)
            {
                goto label_20;
            }
            
            label_19:
            val_5 = 1152921505526759424;
            val_6 = null;
            val_6 = null;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)val_7;
            label_5:
            var val_5 = 65279;
            val_5 = ciphersuite + val_5;
            if(val_5 > 21)
            {
                goto label_14;
            }
            
            val_5 = 1 << val_5;
            val_5 = val_5 & 4128831;
            if(val_5 != 0)
            {
                goto label_20;
            }
            
            label_14:
            var val_6 = 52391;
            val_6 = ciphersuite + val_6;
            if(val_6 >= 7)
            {
                goto label_19;
            }
            
            label_20:
            val_5 = 1152921505526759424;
            val_8 = null;
            val_8 = null;
            val_7 = 1152921505526763544;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)val_7;
            label_9:
            var val_7 = 49186;
            val_7 = ciphersuite + val_7;
            if(val_7 > 15)
            {
                goto label_19;
            }
            
            goto label_20;
        }
        public static bool IsAeadCipherSuite(int ciphersuite)
        {
            return (bool)((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite:  ciphersuite)) == 2) ? 1 : 0;
        }
        public static bool IsBlockCipherSuite(int ciphersuite)
        {
            return (bool)((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite:  ciphersuite)) == 1) ? 1 : 0;
        }
        public static bool IsStreamCipherSuite(int ciphersuite)
        {
            return (bool)((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite:  ciphersuite)) == 0) ? 1 : 0;
        }
        public static bool IsValidCipherSuiteForVersion(int cipherSuite, Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
        {
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetMinimumVersion(ciphersuite:  cipherSuite);
            if(val_1 != null)
            {
                    return val_1.IsEqualOrEarlierVersionOf(version:  serverVersion.GetEquivalentTLSVersion());
            }
            
            return val_1.IsEqualOrEarlierVersionOf(version:  serverVersion.GetEquivalentTLSVersion());
        }
        protected TlsUtilities()
        {
        
        }
        private static TlsUtilities()
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyShorts = new short[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyInts = new int[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyLongs = new long[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL_CLIENT = new byte[4];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL_SERVER = new byte[4];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GenSsl3Const();
        }
    
    }

}
