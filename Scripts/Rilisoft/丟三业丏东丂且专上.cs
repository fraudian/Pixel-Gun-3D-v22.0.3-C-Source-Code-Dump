using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丟三业丏东丂且专上 : 三丐丈万丒丌丄与万
    {
        // Fields
        private const int 丌丅丙万丘不三丟丝 = 16;
        private const int 丘一丏与丗丐一且丈 = 32;
        private const int 丈丕专丅丗丂丗一丅 = 20;
        private static readonly byte[] 与七三七上丏专专丆;
        private readonly byte[] 一东七世丂丗丂丞一;
        private readonly byte[] 丈业万万丗丆万且七;
        private readonly byte[] 丘丆且丁下一丑丅三;
        private readonly byte[] 专丈下丑丏东丒丕丁;
        private readonly System.Security.Cryptography.SymmetricAlgorithm 丏丌丞丙上世丕丈丏;
        private readonly Rilisoft.丟三业丏东丂且专上.与丐万丟万且丅丞丈 丄丅丂丄丅丞丆丈七;
        
        // Properties
        public int 丝丈丛不丛且丗不丕 { get; }
        public int 丞东与丂丄丕丂上丄 { get; }
        private int 七丌丕不丑业业且万 { get; }
        private int 丁丟丝不丈业且上丙 { get; }
        
        // Methods
        public 丟三业丏东丂且专上(byte[] 丅丄三丅丑丑丞且万)
        {
            var val_12;
            var val_13;
            this.丄丅丂丄丅丞丆丈七 = new 丟三业丏东丂且专上.与丐万丟万且丅丞丈();
            if(丅丄三丅丑丑丞且万 == null)
            {
                goto label_1;
            }
            
            this.丏丌丞丙上世丕丈丏 = System.Security.Cryptography.Rijndael.Create();
            int val_3 = System.Math.Max(val1:  32, val2:  8);
            if(val_3 > 丅丄三丅丑丑丞且万.Length)
            {
                goto label_10;
            }
            
            this.丘丆且丁下一丑丅三 = new byte[32];
            this.专丈下丑丏东丒丕丁 = new byte[16];
            byte[] val_6 = new byte[32];
            this.一东七世丂丗丂丞一 = val_6;
            System.Array.Copy(sourceArray:  丅丄三丅丑丑丞且万, sourceIndex:  0, destinationArray:  val_6, destinationIndex:  0, length:  val_6.Length);
            byte[] val_7 = new byte[8];
            this.丈业万万丗丆万且七 = val_7;
            System.Array.Copy(sourceArray:  丅丄三丅丑丑丞且万, sourceIndex:  丅丄三丅丑丑丞且万.Length - 8, destinationArray:  val_7, destinationIndex:  0, length:  val_7.Length);
            return;
            label_1:
            val_12 = 1152921542534007600;
            val_13 = new System.ArgumentNullException(paramName:  "masterKey");
            goto label_13;
            label_10:
            val_12 = 1152921542534007600;
            val_13 = new System.ArgumentException(message:  "Master key should be at least " + val_3 + " bytes.", paramName:  "masterKey");
            label_13:
        }
        public int 丈万一业且丈下丞丑()
        {
            return 84;
        }
        public int 下万丒丗下丐丛丅丛()
        {
            return 68;
        }
        public bool 丛丗上丝业下不丈丟(System.ArraySegment<byte> 丕丑丏世上丄丐且丑, byte[] 一不丑七万万丁不丌)
        {
            var val_3;
            if( >= 68)
            {
                    bool val_2 = this.丟一丙丞丑丁上丒不(一不丑七万万丁不丌:  X3).与丛丐且丝不一丄不(丕丑丏世上丄丐且丑:  new System.ArraySegment<System.Byte>() {_count = 丕丑丏世上丄丐且丑._count}, 丌世世丙专丄三七且:  一不丑七万万丁不丌);
            }
            else
            {
                    val_3 = 0;
            }
            
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        private bool 与丛丐且丝不一丄不(System.ArraySegment<byte> 丕丑丏世上丄丐且丑, byte[] 丌世世丙专丄三七且)
        {
            string val_1 = 丕丑丏世上丄丐且丑._count.丐丏七丌丕丗业且上();
            System.Security.Cryptography.HMACSHA1 val_2 = new System.Security.Cryptography.HMACSHA1(key:  X3, useManagedSha1:  true);
            if(val_2 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_2.Dispose();
            }
            
            return (bool)Rilisoft.丟三业丏东丂且专上.一七世不丁丛丞万专(丈丂丕下丏丈丞丗业:  0.丐丏七丌丕丗业且上(), 上丆丙丏丞丅业万且:  -726743200, 丂丌丌丛丆丆丙丌丈:  val_2.ComputeHash(buffer:  丕丑丏世上丄丐且丑._count.丐丏七丌丕丗业且上(), offset:  0, count:  -726743204), 七丅丂丑万丐专丅丙:  0, 丏上万丅丏一不不丕:  val_4.Length);
        }
        public System.ArraySegment<byte> 丘丞丕丏一丌三丟丅(System.ArraySegment<byte> 丏专世丐万丑万三不, byte[] 一不丑七万万丁不丌, byte[] 丏东丑丘丂与万丕丑)
        {
            var val_20;
            var val_21;
            var val_22;
            System.Byte[] val_23;
            var val_24;
            var val_25;
            var val_26;
            string val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_21 = this;
            if(X4 == 0)
            {
                goto label_1;
            }
            
            if((-726187604) > (X4 + 24))
            {
                goto label_2;
            }
            
            if((this.丟一丙丞丑丁上丒不(一不丑七万万丁不丌:  丏东丑丘丂与万丕丑).与丛丐且丝不一丄不(丕丑丏世上丄丐且丑:  new System.ArraySegment<System.Byte>() {_count = 丏专世丐万丑万三不._count}, 丌世世丙专丄三七且:  一不丑七万万丁不丌)) == false)
            {
                goto label_3;
            }
            
            string val_3 = 丏专世丐万丑万三不._count.丐丏七丌丕丗业且上();
            string val_4 = 丏专世丐万丑万三不._count.丐丏七丌丕丗业且上();
            string val_5 = 丏专世丐万丑万三不._count.丐丏七丌丕丗业且上();
            val_22 = 0;
            val_23 = this.丘丆且丁下一丑丅三;
            goto label_4;
            label_12:
            string val_6 = 0.丐丏七丌丕丗业且上();
            var val_20 = val_22 + val_20;
            var val_21 = (long)val_20;
            val_21 = val_6 + val_21;
            val_22 = 1;
            this.丘丆且丁下一丑丅三[0] = val_6 ^ this.一东七世丂丗丂丞一[0];
            label_4:
            if(val_22 != (mem[this.丘丆且丁下一丑丅三] + 24))
            {
                goto label_12;
            }
            
            System.Array.Copy(sourceArray:  0.丐丏七丌丕丗业且上(), sourceIndex:  -726187568, destinationArray:  this.专丈下丑丏东丒丕丁, destinationIndex:  0, length:  this.专丈下丑丏东丒丕丁.Length);
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  this.丏丌丞丙上世丕丈丏, mode:  1);
            string val_11 = 0.丐丏七丌丕丗业且上();
            new System.Security.Cryptography.CryptoStream().Close();
            System.Array.Copy(sourceArray:  new System.IO.MemoryStream(), sourceIndex:  0, destinationArray:  0.丐丏七丌丕丗业且上(), destinationIndex:  -726187600, length:  -726187600);
            val_20 = 0;
            val_24 = 0;
            val_25 = 0;
            val_26 = 0;
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_21;
            label_3:
            val_20 = 0;
            val_24 = 0;
            return (System.ArraySegment<System.Byte>);
            label_21:
            new System.Security.Cryptography.CryptoStream().Dispose();
            if(val_26 == 1)
            {
                    if(val_25 != 0)
            {
                    val_25 = 0;
            }
            
                val_26 = 0;
            }
            
            if(new System.IO.MemoryStream() != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                new System.IO.MemoryStream().Dispose();
            }
            
            if(val_26 == 1)
            {
                    if(val_25 != 0)
            {
                    val_25 = 0;
            }
            
                val_26 = 0;
            }
            
            label_69:
            if(this.丏丌丞丙上世丕丈丏 != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                this.丏丌丞丙上世丕丈丏.Dispose();
            }
            
            if(val_26 != 1)
            {
                goto label_39;
            }
            
            if(val_25 != 0)
            {
                    val_25 = 0;
            }
            
            val_26 = 0;
            goto label_39;
            label_1:
            System.ArgumentNullException val_16 = null;
            val_30 = val_16;
            val_16 = new System.ArgumentNullException(paramName:  "outputBuffer");
            val_31 = 1152921542535339776;
            val_32 = val_30;
            goto label_40;
            label_2:
            val_30 = "Output buffer is too short: "("Output buffer is too short: ") + X4 + 24(X4 + 24);
            val_31 = 1152921542535339776;
            val_32 = new System.ArgumentException(message:  val_30, paramName:  "outputBuffer");
            label_40:
            val_33 = 0;
            val_34 = val_32;
            val_26 = 0;
            if( != 1)
            {
                goto label_76;
            }
            
            goto label_69;
            label_76:
            if( != 1)
            {
                goto label_86;
            }
            
            val_23 = val_30 + 32;
            label_39:
            System.Array.Clear(array:  1152921504624312320, index:  0, length:  1285006336);
            System.Array.Clear(array:  val_30, index:  0, length:  1285006336);
            if( != 1)
            {
                    return (System.ArraySegment<System.Byte>);
            }
            
            if(null == null)
            {
                    return (System.ArraySegment<System.Byte>);
            }
            
            return (System.ArraySegment<System.Byte>);
            label_86:
        }
        public System.ArraySegment<byte> 三丙业业世丙丏丝丝(System.ArraySegment<byte> 下丟丗丛丅丗丒与丙, byte[] 一不丑七万万丁不丌, byte[] 丏东丑丘丂与万丕丑)
        {
            System.Array val_20;
            System.Byte[] val_21;
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_28;
            var val_29;
            var val_30;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_21 = 丏东丑丘丂与万丕丑;
            val_22 = this;
            if(X4 == 0)
            {
                goto label_1;
            }
            
            if((-725140428) > (X4 + 24))
            {
                goto label_2;
            }
            
            this.丄丅丂丄丅丞丆丈七.一丑丟丑丅业万一不(一丐丗丁丞丆丅丟丄:  this.丘丆且丁下一丑丅三);
            this.丄丅丂丄丅丞丆丈七.一丑丟丑丅业万一不(一丐丗丁丞丆丅丟丄:  this.专丈下丑丏东丒丕丁);
            System.Array.Copy(sourceArray:  this.丘丆且丁下一丑丅三, sourceIndex:  0, destinationArray:  0.丐丏七丌丕丗业且上(), destinationIndex:  -725140528, length:  -725140528);
            System.Array.Copy(sourceArray:  this.专丈下丑丏东丒丕丁, sourceIndex:  0, destinationArray:  0.丐丏七丌丕丗业且上(), destinationIndex:  -725140544, length:  -725140544);
            val_23 = 0;
            goto label_5;
            label_13:
            val_23 = 1;
            this.丘丆且丁下一丑丅三[0] = this.丘丆且丁下一丑丅三[0] ^ this.一东七世丂丗丂丞一[0];
            label_5:
            if(val_23 != this.丘丆且丁下一丑丅三.Length)
            {
                goto label_13;
            }
            
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  this.丏丌丞丙上世丕丈丏, mode:  1);
            string val_6 = 下丟丗丛丅丗丒与丙._count.丐丏七丌丕丗业且上();
            new System.Security.Cryptography.CryptoStream().Close();
            System.Array.Copy(sourceArray:  new System.IO.MemoryStream(), sourceIndex:  0, destinationArray:  0.丐丏七丌丕丗业且上(), destinationIndex:  -725140560, length:  -725140560);
            new System.Security.Cryptography.HMACSHA1() = new System.Security.Cryptography.HMACSHA1(key:  this.丟一丙丞丑丁上丒不(一不丑七万万丁不丌:  val_21), useManagedSha1:  true);
            val_24 = -725140640;
            System.Array.Copy(sourceArray:  new System.Security.Cryptography.HMACSHA1().ComputeHash(buffer:  0.丐丏七丌丕丗业且上(), offset:  0, count:  -725140512), sourceIndex:  0, destinationArray:  0.丐丏七丌丕丗业且上(), destinationIndex:  -725140592, length:  -725140592);
            val_25 = 0;
            val_26 = 0;
            if(new System.Security.Cryptography.HMACSHA1() != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                new System.Security.Cryptography.HMACSHA1().Dispose();
            }
            
            if((val_25 != 1) && (504 == 504))
            {
                    val_25 = 0;
            }
            else
            {
                    if(val_26 != 0)
            {
                    val_26 = 0;
            }
            
            }
            
            val_28 = 0;
            val_29 = 0;
            val_21 = 1;
            val_30 = val_26;
            if(new System.Security.Cryptography.CryptoStream() == null)
            {
                goto label_105;
            }
            
            label_104:
            var val_23 = 0;
            val_23 = val_23 + 1;
            new System.Security.Cryptography.CryptoStream().Dispose();
            label_105:
            if(val_21 == 1)
            {
                goto label_33;
            }
            
            if(val_30 == 0)
            {
                goto label_36;
            }
            
            if(585 != 585)
            {
                goto label_35;
            }
            
            goto label_36;
            label_33:
            if(val_30 == 0)
            {
                goto label_37;
            }
            
            label_35:
            val_26 = 0;
            val_30 = 0;
            label_36:
            if(new System.IO.MemoryStream() == null)
            {
                goto label_108;
            }
            
            label_107:
            var val_24 = 0;
            val_24 = val_24 + 1;
            new System.IO.MemoryStream().Dispose();
            label_108:
            if(val_21 == 1)
            {
                goto label_43;
            }
            
            if(val_30 == 0)
            {
                goto label_46;
            }
            
            if(585 != 585)
            {
                goto label_45;
            }
            
            goto label_46;
            label_43:
            if(val_30 == 0)
            {
                goto label_47;
            }
            
            label_45:
            val_26 = 0;
            val_30 = 0;
            label_46:
            if(this.丏丌丞丙上世丕丈丏 == null)
            {
                goto label_111;
            }
            
            label_110:
            var val_25 = 0;
            val_25 = val_25 + 1;
            this.丏丌丞丙上世丕丈丏.Dispose();
            label_111:
            if(val_21 == 1)
            {
                goto label_53;
            }
            
            if(val_30 == 0)
            {
                goto label_59;
            }
            
            if(585 != 585)
            {
                goto label_55;
            }
            
            goto label_59;
            label_53:
            if(val_30 == 0)
            {
                goto label_57;
            }
            
            label_55:
            val_26 = 0;
            val_30 = 0;
            goto label_59;
            label_57:
            val_26 = 0;
            val_21 = 0;
            goto label_59;
            label_47:
            if(this.丏丌丞丙上世丕丈丏 != null)
            {
                goto label_110;
            }
            
            goto label_111;
            label_37:
            if(new System.IO.MemoryStream() != null)
            {
                goto label_107;
            }
            
            goto label_108;
            label_1:
            System.ArgumentNullException val_17 = null;
            val_22 = val_17;
            val_17 = new System.ArgumentNullException(paramName:  "outputBuffer");
            val_34 = 1152921542536386928;
            val_35 = val_22;
            goto label_65;
            label_2:
            val_22 = "Output buffer is too short: "("Output buffer is too short: ") + X4 + 24(X4 + 24);
            System.ArgumentException val_19 = null;
            val_20 = val_19;
            val_19 = new System.ArgumentException(message:  val_22, paramName:  "outputBuffer");
            val_34 = 1152921542536386928;
            val_35 = val_20;
            label_65:
            val_36 = 0;
            val_37 = val_35;
            if( != 1)
            {
                goto label_103;
            }
            
            if(X22 != 0)
            {
                goto label_104;
            }
            
            goto label_105;
            label_103:
            val_28 = 0;
            val_29 = 0;
            if( != 1)
            {
                goto label_106;
            }
            
            if(X21 != 0)
            {
                goto label_107;
            }
            
            goto label_108;
            label_106:
            if( != 1)
            {
                goto label_112;
            }
            
            if(val_20 != null)
            {
                goto label_110;
            }
            
            goto label_111;
            label_112:
            val_24 = -725140640;
            if( != 1)
            {
                goto label_132;
            }
            
            val_30 = 1152921504616964096;
            label_59:
            System.Array.Clear(array:  val_19, index:  0, length:  -724518800);
            System.Array.Clear(array:  val_22, index:  0, length:  -724518800);
            if( != 1)
            {
                    if(val_30 == null)
            {
                    return (System.ArraySegment<System.Byte>);
            }
            
                if(val_24 == 585)
            {
                    return (System.ArraySegment<System.Byte>);
            }
            
                return (System.ArraySegment<System.Byte>);
            }
            
            if(val_30 != null)
            {
                    return (System.ArraySegment<System.Byte>);
            }
            
            return (System.ArraySegment<System.Byte>);
            label_132:
        }
        private static bool 一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕)
        {
            System.Byte[] val_16;
            int val_17;
            int val_18;
            bool val_1 = static_value_082C43D2;
            if(丈丂丕下丏丈丞丗业 != 0)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_3;
            }
            
            if()
            {
                goto label_5;
            }
            
            return (bool)val_15;
            label_3:
            new System.ArgumentNullException() = new System.ArgumentNullException(paramName:  "left");
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_5:
            if(丂丌丌丛丆丆丙丌丈 != 0)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_9;
            }
            
            if()
            {
                goto label_11;
            }
            
            return (bool)val_15;
            label_9:
            new System.ArgumentNullException() = new System.ArgumentNullException(paramName:  "right");
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_11:
            if((上丆丙丏丞丅业万且 & 2147483648) == 0)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_15;
            }
            
            if()
            {
                goto label_17;
            }
            
            return (bool)val_15;
            label_15:
            val_17 = 0;
            new System.ArgumentOutOfRangeException() = new System.ArgumentOutOfRangeException(paramName:  "leftOffset", message:  "leftOffset < 0");
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_17:
            if((七丅丂丑万丐专丅丙 & 2147483648) == 0)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_21;
            }
            
            if()
            {
                goto label_23;
            }
            
            return (bool)val_15;
            label_21:
            val_17 = 0;
            new System.ArgumentOutOfRangeException() = new System.ArgumentOutOfRangeException(paramName:  "rightOffset", message:  "rightOffset < 0");
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_23:
            if((丏上万丅丏一不不丕 & 2147483648) == 0)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_27;
            }
            
            if()
            {
                goto label_29;
            }
            
            return (bool)val_15;
            label_27:
            val_17 = 0;
            new System.ArgumentOutOfRangeException() = new System.ArgumentOutOfRangeException(paramName:  "length", message:  "length < 0");
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_29:
            if(上丆丙丏丞丅业万且 <= (丈丂丕下丏丈丞丗业 + 24))
            {
                
            }
            
            if(0 == 0)
            {
                goto label_37;
            }
            
            if(上丆丙丏丞丅业万且 == (丈丂丕下丏丈丞丗业 + 24))
            {
                goto label_35;
            }
            
            return (bool)val_15;
            label_37:
            val_17 = 丏上万丅丏一不不丕;
            new System.ArgumentException() = new System.ArgumentException(message:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "leftOffset + length > left.Length: {0} + {1} > {2}", arg0:  上丆丙丏丞丅业万且, arg1:  丏上万丅丏一不不丕, arg2:  丈丂丕下丏丈丞丗业 + 24));
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            label_35:
            val_18 = 丏上万丅丏一不不丕;
            if(七丅丂丑万丐专丅丙 <= (丂丌丌丛丆丆丙丌丈 + 24))
            {
                
            }
            
            if(0 == 0)
            {
                goto label_48;
            }
            
            if(七丅丂丑万丐专丅丙 == (丂丌丌丛丆丆丙丌丈 + 24))
            {
                goto label_53;
            }
            
            return (bool)val_15;
            label_48:
            val_17 = 丏上万丅丏一不不丕;
            new System.ArgumentException() = new System.ArgumentException(message:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "rightOffset + length > right.Length: {0} + {1} > {2}", arg0:  七丅丂丑万丐专丅丙, arg1:  丏上万丅丏一不不丕, arg2:  丂丌丌丛丆丆丙丌丈 + 24));
            val_16 = static System.Boolean Rilisoft.丟三业丏东丂且专上::一七世不丁丛丞万专(byte[] 丈丂丕下丏丈丞丗业, int 上丆丙丏丞丅业万且, byte[] 丂丌丌丛丆丆丙丌丈, int 七丅丂丑万丐专丅丙, int 丏上万丅丏一不不丕);
            val_18 = 0;
            goto label_53;
            label_58:
            System.Byte[] val_17 = 0;
            System.Byte[] val_16 = 丈丂丕下丏丈丞丗业;
            val_16 = val_16 ^ 丂丌丌丛丆丆丙丌丈;
            val_17 = val_17 | val_16;
            val_18 = 1;
            label_53:
            if(0 != 丏上万丅丏一不不丕)
            {
                
            }
            
            if(0 == 0)
            {
                goto label_56;
            }
            
            if(0 == 丏上万丅丏一不不丕)
            {
                goto label_58;
            }
            
            return this.丘丞丕丏一丌三丟丅(丏专世丐万丑万三不:  new System.ArraySegment<System.Byte>() {_count = 1}, 一不丑七万万丁不丌:  val_16, 丏东丑丘丂与万丕丑:  丏上万丅丏一不不丕);
            label_56:
            var val_15 = (((((val_17 == null) ? 1 : 0) != 1) ? 1 : 0) != 0) ? 1 : 0;
            val_15 = val_15 & 1;
            return (bool)val_15;
        }
        private byte[] 丟一丙丞丑丁上丒不(byte[] 一不丑七万万丁不丌)
        {
            System.Byte[] val_2;
            var val_3;
            val_2 = 一不丑七万万丁不丌;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = Rilisoft.丟三业丏东丂且专上.与七三七上丏专专丆;
            }
            
            if((new System.Security.Cryptography.Rfc2898DeriveBytes(password:  val_2, salt:  this.丈业万万丗丆万且七, iterations:  1)) == null)
            {
                
            }
        
        }
        private int 下且丐丛东与下丕丛()
        {
            return 16;
        }
        private int 丑丄与东丞丞世丙丆()
        {
            return 48;
        }
        private static 丟三业丏东丂且专上()
        {
            Rilisoft.丟三业丏东丂且专上.与七三七上丏专专丆 = new byte[0];
        }
    
    }

}
