using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal sealed class InfTree
    {
        // Fields
        private const int MANY = 1440;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        internal const int fixed_bl = 9;
        internal const int fixed_bd = 5;
        internal static readonly int[] fixed_tl;
        internal static readonly int[] fixed_td;
        internal static readonly int[] cplens;
        internal static readonly int[] cplext;
        internal static readonly int[] cpdist;
        internal static readonly int[] cpdext;
        internal const int BMAX = 15;
        internal int[] hn;
        internal int[] v;
        internal int[] c;
        internal int[] r;
        internal int[] u;
        internal int[] x;
        
        // Methods
        private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
        {
            System.Int32[] val_35;
            int val_36;
            int val_37;
            System.Int32[] val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            System.Int32[] val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_53;
            var val_54;
            val_35 = m;
            val_36 = n;
            val_37 = b;
            var val_44 = 0;
            do
            {
                val_38 = this.c;
                int val_1 = bindex + val_44;
                int val_42 = val_37[((long)(int)((bindex + 0))) << 2];
                int val_43 = val_38[(b[((long)(int)((bindex + 0))) << 2][0]) << 2];
                val_44 = val_44 + 1;
                val_43 = val_43 + 1;
                val_38[(b[((long)(int)((bindex + 0))) << 2][0]) << 2] = val_43;
            }
            while(val_36 != val_44);
            
            if(this.c[0] == val_36)
            {
                    mem2[0] = 0;
                val_39 = 0;
                val_35[0] = 0;
                return (int)val_39;
            }
            
            int val_46 = val_35[0];
            val_40 = 0;
            label_18:
            var val_2 = val_40 + 1;
            if(this.c[0] != 0)
            {
                goto label_17;
            }
            
            val_40 = val_40 + 1;
            if(val_40 < 15)
            {
                goto label_18;
            }
            
            label_17:
            var val_3 = val_40 + 1;
            var val_4 = (val_46 < val_3) ? (val_3) : (val_46);
            val_41 = 23;
            label_22:
            var val_5 = 23 - 8;
            if(this.c[7] != 0)
            {
                goto label_21;
            }
            
            val_41 = 23 - 1;
            if(val_41 != 8)
            {
                goto label_22;
            }
            
            label_21:
            var val_6 = val_41 - 8;
            int val_7 = (val_4 > val_6) ? (val_6) : (val_4);
            val_35[0] = val_7;
            val_42 = 1 << (val_3 & 31);
            val_35 = val_3;
            goto label_25;
            label_29:
            var val_9 = val_3 + (((long)(int)(((val_40 + 1) + 1))) << 2);
            var val_49 = (((val_40 + 1) + 1) + ((long)(int)(((val_40 + 1) + 1))) << 2) + 32;
            val_49 = val_42 - val_49;
            if((val_49 & 2147483648) != 0)
            {
                goto label_75;
            }
            
            val_35 = val_35 + 1;
            val_42 = val_49 << 1;
            label_25:
            if(val_35 < val_6)
            {
                goto label_29;
            }
            
            val_38 = val_42 - (this.c[((long)(int)(((23 - 1) - 8))) << 2]);
            if((val_38 & 2147483648) != 0)
            {
                goto label_75;
            }
            
            int val_51 = this.c[((long)(int)(((23 - 1) - 8))) << 2];
            val_51 = val_51 + val_38;
            this.c[((long)(int)(((23 - 1) - 8))) << 2] = val_51;
            this.x[0] = 0;
            if(val_6 != 1)
            {
                    int val_53 = 0;
                var val_54 = 1;
                do
            {
                var val_10 = val_54 + 1;
                val_53 = this.c[4] + val_53;
                val_54 = val_54 + 1;
                this.x[((long)(int)((1 + 1))) << 2] = val_53;
            }
            while(val_6 != val_54);
            
            }
            
            val_43 = v;
            var val_57 = 0;
            do
            {
                int val_11 = bindex + val_57;
                if((val_37[((long)(int)((bindex + 0))) << 2]) != 0)
            {
                    this.x[(b[((long)(int)((bindex + 0))) << 2][0]) << 2] = (this.x[(b[((long)(int)((bindex + 0))) << 2][0]) << 2]) + 1;
                System.Int32[] val_13 = val_43 + ((this.x[(b[((long)(int)((bindex + 0))) << 2][0]) << 2][0]) << 2);
                mem2[0] = val_57;
            }
            
                val_57 = val_57 + 1;
            }
            while(val_57 < val_36);
            
            val_38 = val_3;
            this.x[0] = 0;
            val_35 = this.u;
            val_35[0] = 0;
            if(val_38 <= val_6)
            {
                goto label_56;
            }
            
            label_133:
            if(val_38 == 0)
            {
                    return (int)val_39;
            }
            
            var val_14 = (val_6 != 1) ? -5 : 0;
            return (int)val_39;
            label_56:
            val_37 = 0;
            val_36 = -val_7;
            var val_15 = ((~val_6) <= (~val_4)) ? (~val_4) : (!val_6);
            var val_16 = val_38 + 1;
            val_44 = 0;
            val_15 = val_15 + 1;
            label_132:
            int val_59 = this.c[((long)(int)(((val_40 + 1) + 1))) << 2];
            if(val_59 == 0)
            {
                goto label_61;
            }
            
            var val_17 = val_38 + 31;
            val_17 = val_17 & 31;
            val_17 = 1 << val_17;
            label_130:
            var val_18 = val_36 + val_7;
            if(val_38 <= val_18)
            {
                goto label_62;
            }
            
            val_35 = val_15 - val_36;
            label_96:
            var val_61 = val_18;
            var val_60 = val_6;
            val_45 = val_38 - val_61;
            val_60 = val_60 - val_61;
            val_61 = val_45 & 31;
            var val_19 = (val_60 > val_7) ? (val_7) : (val_60);
            var val_62 = 1;
            val_62 = val_62 << val_61;
            int val_20 = val_62 - val_59;
            if((val_60 <= val_7) || (val_45 >= val_19))
            {
                goto label_72;
            }
            
            val_45 = val_45 + 1;
            if(val_45 >= val_19)
            {
                goto label_72;
            }
            
            var val_65 = val_16;
            label_71:
            val_20 = val_20 << 1;
            if(val_20 <= (this.c[((long)(int)((((val_40 + 1) + 1) + 1))) << 2]))
            {
                goto label_68;
            }
            
            val_65 = val_65 + 1;
            val_45 = (val_35 + val_65) + 1;
            val_20 = val_20 - (this.c[((long)(int)((((val_40 + 1) + 1) + 1))) << 2]);
            if(val_45 < val_19)
            {
                goto label_71;
            }
            
            goto label_72;
            label_68:
            val_45 = (val_35 + val_65) + 1;
            label_72:
            val_38 = 1 << (val_45 & 31);
            var val_66 = hn + 32;
            val_66 = val_66 + val_38;
            if(val_66 > 1440)
            {
                goto label_75;
            }
            
            var val_24 = val_44 + 1;
            this.u[((long)(int)((val_44 + 1))) << 2] = hn + 32;
            var val_67 = hn + 32;
            val_67 = val_67 + val_38;
            mem2[0] = val_67;
            if(val_24 != 0)
            {
                    this.x[((long)(int)((val_44 + 1))) << 2] = val_37;
                this.r[0] = (int)val_45 & 255;
                this.r[0] = (int)val_7 & 255;
                val_36 = val_36 & 31;
                var val_25 = val_37 >> val_36;
                var val_69 = hn + 32;
                val_69 = val_69 - val_25;
                val_36 = val_69 - this.u[0];
                this.r[1] = val_36;
                val_46 = val_61;
                int val_70 = this.u[0];
                val_70 = val_70 + val_25;
                System.Array.Copy(sourceArray:  this.r, sourceIndex:  0, destinationArray:  hp, destinationIndex:  val_70 + (val_70 << 1), length:  3);
                val_44 = val_24;
                val_43 = v;
                val_47 = val_38;
                val_48 = val_7;
            }
            else
            {
                    val_43 = v;
                val_48 = val_7;
                val_46 = val_61;
                val_44 = 0;
                mem2[0] = hn + 32;
                val_47 = val_38;
            }
            
            val_35 = val_35 + val_15;
            if(val_47 > (val_46 + val_48))
            {
                goto label_96;
            }
            
            goto label_97;
            label_62:
            val_46 = val_36;
            label_97:
            var val_28 = val_38 - val_46;
            this.r[0] = (int)val_28 & 255;
            if(0 >= (this.x[((long)(int)(((23 - 1) - 8))) << 2]))
            {
                goto label_100;
            }
            
            val_49 = mem[v + 24];
            val_49 = v + 24;
            if(0 >= val_49)
            {
                    val_49 = mem[v + 24];
                val_49 = v + 24;
            }
            
            System.Int32[] val_29 = val_43 + 0;
            val_50 = (v + 0) + 32;
            if(0 >= val_49)
            {
                    val_50 = mem[(v + 0) + 32];
                val_50 = (v + 0) + 32;
            }
            
            if(((v + 0) + 32) >= s)
            {
                goto label_104;
            }
            
            this.r[0] = (val_50 < 256) ? 0 : 96;
            val_51 = mem[(v + 0) + 32];
            val_51 = (v + 0) + 32;
            goto label_113;
            label_100:
            val_51 = 192;
            goto label_113;
            label_104:
            int val_71 = s;
            val_71 = val_50 - val_71;
            System.Int32[] val_31 = e + (((long)(int)(((v + 0) + 32 - s))) << 2);
            int val_72 = (e + ((long)(int)(((v + 0) + 32 - s))) << 2) + 32;
            val_72 = (1342177280 + (val_72 << 24)) >> 24;
            this.r[0] = val_72;
            int val_73 = s;
            val_73 = ((v + 0) + 32) - val_73;
            System.Int32[] val_33 = d + (((long)(int)(((v + 0) + 32 - s))) << 2);
            val_51 = mem[(d + ((long)(int)(((v + 0) + 32 - s))) << 2) + 32];
            val_51 = (d + ((long)(int)(((v + 0) + 32 - s))) << 2) + 32;
            label_113:
            mem2[0] = val_51;
            var val_35 = val_37 >> (val_46 & 31);
            if(val_35 < val_38)
            {
                    var val_74 = hn + 32;
                val_28 = 1 << (val_28 & 31);
                val_74 = val_74 + val_35;
                int val_37 = val_74 + (val_74 << 1);
                do
            {
                System.Array.Copy(sourceArray:  this.r, sourceIndex:  0, destinationArray:  hp, destinationIndex:  val_37, length:  3);
                val_35 = val_35 + val_28;
                val_37 = val_37 + (val_28 + (val_28 << 1));
            }
            while(val_35 < val_38);
            
            }
            
            int val_75 = val_59;
            val_75 = val_75 - 1;
            var val_76 = val_17;
            do
            {
                val_37 = val_37 ^ val_76;
                val_76 = val_76 >> 1;
            }
            while((val_37 & val_76) != 0);
            
            val_53 = val_46;
            goto label_126;
            label_129:
            val_44 = -1;
            val_53 = val_53 - val_7;
            label_126:
            var val_78 = 1;
            var val_41 = val_78 << (val_53 & 31);
            val_41 = val_41 - 1;
            val_78 = val_41 & val_37;
            if(val_78 != (this.x[-4]))
            {
                goto label_129;
            }
            
            val_54 = val_38;
            if(val_75 != 0)
            {
                goto label_130;
            }
            
            goto label_131;
            label_61:
            val_54 = val_38;
            label_131:
            val_54 = val_54 + 1;
            var val_79 = val_16;
            val_79 = val_79 + 1;
            if(val_54 <= val_6)
            {
                goto label_132;
            }
            
            goto label_133;
            label_75:
            val_39 = -3;
            return (int)val_39;
        }
        internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, BestHTTP.Decompression.Zlib.ZlibCodec z)
        {
            var val_2;
            string val_3;
            this.initWorkArea(vsize:  19);
            this.hn[0] = 0;
            val_2 = this.huft_build(b:  c, bindex:  0, n:  19, s:  19, d:  0, e:  0, t:  tb, m:  bb, hp:  hp, hn:  this.hn, v:  this.v);
            if(val_2 == 5)
            {
                goto label_3;
            }
            
            if(val_2 != 3)
            {
                goto label_4;
            }
            
            val_3 = "oversubscribed dynamic bit lengths tree";
            goto label_6;
            label_4:
            if(bb[0] != 0)
            {
                    return (int)val_2;
            }
            
            label_3:
            val_3 = "incomplete dynamic bit lengths tree";
            label_6:
            val_2 = -3;
            z.Message = val_3;
            return (int)val_2;
        }
        internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, BestHTTP.Decompression.Zlib.ZlibCodec z)
        {
            var val_3;
            var val_4;
            var val_5;
            string val_6;
            this.initWorkArea(vsize:  32);
            this.hn[0] = 0;
            val_3 = null;
            val_3 = null;
            val_4 = this;
            int val_1 = this.huft_build(b:  c, bindex:  0, n:  nl, s:  1, d:  BestHTTP.Decompression.Zlib.InfTree.cplens, e:  BestHTTP.Decompression.Zlib.InfTree.cplext, t:  tl, m:  bl, hp:  hp, hn:  this.hn, v:  this.v);
            if(val_1 == 4)
            {
                    return (int)val_4;
            }
            
            if(val_1 == 3)
            {
                goto label_6;
            }
            
            if((val_1 != 0) || (bl[0] == 0))
            {
                goto label_10;
            }
            
            this.initWorkArea(vsize:  32);
            val_5 = null;
            val_5 = null;
            System.Int32[] val_4 = this.hn;
            val_4 = (this.huft_build(b:  c, bindex:  nl, n:  nd, s:  0, d:  BestHTTP.Decompression.Zlib.InfTree.cpdist, e:  BestHTTP.Decompression.Zlib.InfTree.cpdext, t:  td, m:  bd, hp:  hp, hn:  val_4, v:  this.v)) + 5;
            if(val_4 > 5)
            {
                goto label_13;
            }
            
            var val_5 = 106049220 + ((val_2 + 5)) << 2;
            val_5 = val_5 + 106049220;
            goto (106049220 + ((val_2 + 5)) << 2 + 106049220);
            label_10:
            val_6 = "incomplete literal/length tree";
            goto label_26;
            label_6:
            val_6 = "oversubscribed literal/length tree";
            label_26:
            val_4 = -3;
            z.Message = val_6;
            return (int)val_4;
            label_13:
            if((???) != 0)
            {
                goto label_26;
            }
            
            goto label_26;
        }
        internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, BestHTTP.Decompression.Zlib.ZlibCodec z)
        {
            var val_1;
            bl[0] = 9;
            bd[0] = 5;
            val_1 = null;
            val_1 = null;
            if(tl == null)
            {
                goto label_7;
            }
            
            if(BestHTTP.Decompression.Zlib.InfTree.BMAX != 0)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(BestHTTP.Decompression.Zlib.InfTree.BMAX == 0)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            tl[0] = BestHTTP.Decompression.Zlib.InfTree.BMAX;
            if(td == null)
            {
                goto label_13;
            }
            
            if(BestHTTP.Decompression.Zlib.InfTree.fixed_td != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(BestHTTP.Decompression.Zlib.InfTree.fixed_td == null)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            td[0] = BestHTTP.Decompression.Zlib.InfTree.fixed_td;
            return 0;
        }
        private void initWorkArea(int vsize)
        {
            System.Int32[] val_8;
            if(this.hn == null)
            {
                goto label_1;
            }
            
            if(this.v.Length >= vsize)
            {
                goto label_3;
            }
            
            this.v = new int[0];
            goto label_4;
            label_1:
            this.hn = new int[1];
            this.v = new int[0];
            this.c = new int[16];
            this.r = new int[3];
            this.u = new int[15];
            this.x = new int[16];
            return;
            label_3:
            val_8 = this.v;
            label_4:
            System.Array.Clear(array:  val_8, index:  0, length:  vsize);
            System.Array.Clear(array:  this.c, index:  0, length:  16);
            this.r[0] = 0;
            this.r[0] = 0;
            this.r[1] = 0;
            System.Array.Clear(array:  this.u, index:  0, length:  15);
            System.Array.Clear(array:  this.x, index:  0, length:  16);
        }
        public InfTree()
        {
        
        }
        private static InfTree()
        {
            BestHTTP.Decompression.Zlib.InfTree.BMAX = new int[1536] {96, 7, 256, 0, 8, 80, 0, 8, 16, 84, 8, 115, 82, 7, 31, 0, 8, 112, 0, 8, 48, 0, 9, 192, 80, 7, 10, 0, 8, 96, 0, 8, 32, 0, 9, 160, 0, 8, 0, 0, 8, 128, 0, 8, 64, 0, 9, 224, 80, 7, 6, 0, 8, 88, 0, 8, 24, 0, 9, 144, 83, 7, 59, 0, 8, 120, 0, 8, 56, 0, 9, 208, 81, 7, 17, 0, 8, 104, 0, 8, 40, 0, 9, 176, 0, 8, 8, 0, 8, 136, 0, 8, 72, 0, 9, 240, 80, 7, 4, 0, 8, 84, 0, 8, 20, 85, 8, 227, 83, 7, 43, 0, 8, 116, 0, 8, 52, 0, 9, 200, 81, 7, 13, 0, 8, 100, 0, 8, 36, 0, 9, 168, 0, 8, 4, 0, 8, 132, 0, 8, 68, 0, 9, 232, 80, 7, 8, 0, 8, 92, 0, 8, 28, 0, 9, 152, 84, 7, 83, 0, 8, 124, 0, 8, 60, 0, 9, 216, 82, 7, 23, 0, 8, 108, 0, 8, 44, 0, 9, 184, 0, 8, 12, 0, 8, 140, 0, 8, 76, 0, 9, 248, 80, 7, 3, 0, 8, 82, 0, 8, 18, 85, 8, 163, 83, 7, 35, 0, 8, 114, 0, 8, 50, 0, 9, 196, 81, 7, 11, 0, 8, 98, 0, 8, 34, 0, 9, 164, 0, 8, 2, 0, 8, 130, 0, 8, 66, 0, 9, 228, 80, 7, 7, 0, 8, 90, 0, 8, 26, 0, 9, 148, 84, 7, 67, 0, 8, 122, 0, 8, 58, 0, 9, 212, 82, 7, 19, 0, 8, 106, 0, 8, 42, 0, 9, 180, 0, 8, 10, 0, 8, 138, 0, 8, 74, 0, 9, 244, 80, 7, 5, 0, 8, 86, 0, 8, 22, 192, 8, 0, 83, 7, 51, 0, 8, 118, 0, 8, 54, 0, 9, 204, 81, 7, 15, 0, 8, 102, 0, 8, 38, 0, 9, 172, 0, 8, 6, 0, 8, 134, 0, 8, 70, 0, 9, 236, 80, 7, 9, 0, 8, 94, 0, 8, 30, 0, 9, 156, 84, 7, 99, 0, 8, 126, 0, 8, 62, 0, 9, 220, 82, 7, 27, 0, 8, 110, 0, 8, 46, 0, 9, 188, 0, 8, 14, 0, 8, 142, 0, 8, 78, 0, 9, 252, 96, 7, 256, 0, 8, 81, 0, 8, 17, 85, 8, 131, 82, 7, 31, 0, 8, 113, 0, 8, 49, 0, 9, 194, 80, 7, 10, 0, 8, 97, 0, 8, 33, 0, 9, 162, 0, 8, 1, 0, 8, 129, 0, 8, 65, 0, 9, 226, 80, 7, 6, 0, 8, 89, 0, 8, 25, 0, 9, 146, 83, 7, 59, 0, 8, 121, 0, 8, 57, 0, 9, 210, 81, 7, 17, 0, 8, 105, 0, 8, 41, 0, 9, 178, 0, 8, 9, 0, 8, 137, 0, 8, 73, 0, 9, 242, 80, 7, 4, 0, 8, 85, 0, 8, 21, 80, 8, 258, 83, 7, 43, 0, 8, 117, 0, 8, 53, 0, 9, 202, 81, 7, 13, 0, 8, 101, 0, 8, 37, 0, 9, 170, 0, 8, 5, 0, 8, 133, 0, 8, 69, 0, 9, 234, 80, 7, 8, 0, 8, 93, 0, 8, 29, 0, 9, 154, 84, 7, 83, 0, 8, 125, 0, 8, 61, 0, 9, 218, 82, 7, 23, 0, 8, 109, 0, 8, 45, 0, 9, 186, 0, 8, 13, 0, 8, 141, 0, 8, 77, 0, 9, 250, 80, 7, 3, 0, 8, 83, 0, 8, 19, 85, 8, 195, 83, 7, 35, 0, 8, 115, 0, 8, 51, 0, 9, 198, 81, 7, 11, 0, 8, 99, 0, 8, 35, 0, 9, 166, 0, 8, 3, 0, 8, 131, 0, 8, 67, 0, 9, 230, 80, 7, 7, 0, 8, 91, 0, 8, 27, 0, 9, 150, 84, 7, 67, 0, 8, 123, 0, 8, 59, 0, 9, 214, 82, 7, 19, 0, 8, 107, 0, 8, 43, 0, 9, 182, 0, 8, 11, 0, 8, 139, 0, 8, 75, 0, 9, 246, 80, 7, 5, 0, 8, 87, 0, 8, 23, 192, 8, 0, 83, 7, 51, 0, 8, 119, 0, 8, 55, 0, 9, 206, 81, 7, 15, 0, 8, 103, 0, 8, 39, 0, 9, 174, 0, 8, 7, 0, 8, 135, 0, 8, 71, 0, 9, 238, 80, 7, 9, 0, 8, 95, 0, 8, 31, 0, 9, 158, 84, 7, 99, 0, 8, 127, 0, 8, 63, 0, 9, 222, 82, 7, 27, 0, 8, 111, 0, 8, 47, 0, 9, 190, 0, 8, 15, 0, 8, 143, 0, 8, 79, 0, 9, 254, 96, 7, 256, 0, 8, 80, 0, 8, 16, 84, 8, 115, 82, 7, 31, 0, 8, 112, 0, 8, 48, 0, 9, 193, 80, 7, 10, 0, 8, 96, 0, 8, 32, 0, 9, 161, 0, 8, 0, 0, 8, 128, 0, 8, 64, 0, 9, 225, 80, 7, 6, 0, 8, 88, 0, 8, 24, 0, 9, 145, 83, 7, 59, 0, 8, 120, 0, 8, 56, 0, 9, 209, 81, 7, 17, 0, 8, 104, 0, 8, 40, 0, 9, 177, 0, 8, 8, 0, 8, 136, 0, 8, 72, 0, 9, 241, 80, 7, 4, 0, 8, 84, 0, 8, 20, 85, 8, 227, 83, 7, 43, 0, 8, 116, 0, 8, 52, 0, 9, 201, 81, 7, 13, 0, 8, 100, 0, 8, 36, 0, 9, 169, 0, 8, 4, 0, 8, 132, 0, 8, 68, 0, 9, 233, 80, 7, 8, 0, 8, 92, 0, 8, 28, 0, 9, 153, 84, 7, 83, 0, 8, 124, 0, 8, 60, 0, 9, 217, 82, 7, 23, 0, 8, 108, 0, 8, 44, 0, 9, 185, 0, 8, 12, 0, 8, 140, 0, 8, 76, 0, 9, 249, 80, 7, 3, 0, 8, 82, 0, 8, 18, 85, 8, 163, 83, 7, 35, 0, 8, 114, 0, 8, 50, 0, 9, 197, 81, 7, 11, 0, 8, 98, 0, 8, 34, 0, 9, 165, 0, 8, 2, 0, 8, 130, 0, 8, 66, 0, 9, 229, 80, 7, 7, 0, 8, 90, 0, 8, 26, 0, 9, 149, 84, 7, 67, 0, 8, 122, 0, 8, 58, 0, 9, 213, 82, 7, 19, 0, 8, 106, 0, 8, 42, 0, 9, 181, 0, 8, 10, 0, 8, 138, 0, 8, 74, 0, 9, 245, 80, 7, 5, 0, 8, 86, 0, 8, 22, 192, 8, 0, 83, 7, 51, 0, 8, 118, 0, 8, 54, 0, 9, 205, 81, 7, 15, 0, 8, 102, 0, 8, 38, 0, 9, 173, 0, 8, 6, 0, 8, 134, 0, 8, 70, 0, 9, 237, 80, 7, 9, 0, 8, 94, 0, 8, 30, 0, 9, 157, 84, 7, 99, 0, 8, 126, 0, 8, 62, 0, 9, 221, 82, 7, 27, 0, 8, 110, 0, 8, 46, 0, 9, 189, 0, 8, 14, 0, 8, 142, 0, 8, 78, 0, 9, 253, 96, 7, 256, 0, 8, 81, 0, 8, 17, 85, 8, 131, 82, 7, 31, 0, 8, 113, 0, 8, 49, 0, 9, 195, 80, 7, 10, 0, 8, 97, 0, 8, 33, 0, 9, 163, 0, 8, 1, 0, 8, 129, 0, 8, 65, 0, 9, 227, 80, 7, 6, 0, 8, 89, 0, 8, 25, 0, 9, 147, 83, 7, 59, 0, 8, 121, 0, 8, 57, 0, 9, 211, 81, 7, 17, 0, 8, 105, 0, 8, 41, 0, 9, 179, 0, 8, 9, 0, 8, 137, 0, 8, 73, 0, 9, 243, 80, 7, 4, 0, 8, 85, 0, 8, 21, 80, 8, 258, 83, 7, 43, 0, 8, 117, 0, 8, 53, 0, 9, 203, 81, 7, 13, 0, 8, 101, 0, 8, 37, 0, 9, 171, 0, 8, 5, 0, 8, 133, 0, 8, 69, 0, 9, 235, 80, 7, 8, 0, 8, 93, 0, 8, 29, 0, 9, 155, 84, 7, 83, 0, 8, 125, 0, 8, 61, 0, 9, 219, 82, 7, 23, 0, 8, 109, 0, 8, 45, 0, 9, 187, 0, 8, 13, 0, 8, 141, 0, 8, 77, 0, 9, 251, 80, 7, 3, 0, 8, 83, 0, 8, 19, 85, 8, 195, 83, 7, 35, 0, 8, 115, 0, 8, 51, 0, 9, 199, 81, 7, 11, 0, 8, 99, 0, 8, 35, 0, 9, 167, 0, 8, 3, 0, 8, 131, 0, 8, 67, 0, 9, 231, 80, 7, 7, 0, 8, 91, 0, 8, 27, 0, 9, 151, 84, 7, 67, 0, 8, 123, 0, 8, 59, 0, 9, 215, 82, 7, 19, 0, 8, 107, 0, 8, 43, 0, 9, 183, 0, 8, 11, 0, 8, 139, 0, 8, 75, 0, 9, 247, 80, 7, 5, 0, 8, 87, 0, 8, 23, 192, 8, 0, 83, 7, 51, 0, 8, 119, 0, 8, 55, 0, 9, 207, 81, 7, 15, 0, 8, 103, 0, 8, 39, 0, 9, 175, 0, 8, 7, 0, 8, 135, 0, 8, 71, 0, 9, 239, 80, 7, 9, 0, 8, 95, 0, 8, 31, 0, 9, 159, 84, 7, 99, 0, 8, 127, 0, 8, 63, 0, 9, 223, 82, 7, 27, 0, 8, 111, 0, 8, 47, 0, 9, 191, 0, 8, 15, 0, 8, 143, 0, 8, 79, 0, 9, 255};
            BestHTTP.Decompression.Zlib.InfTree.fixed_td = new int[96] {80, 5, 1, 87, 5, 257, 83, 5, 17, 91, 5, 4097, 81, 5, 5, 89, 5, 1025, 85, 5, 65, 93, 5, 16385, 80, 5, 3, 88, 5, 513, 84, 5, 33, 92, 5, 8193, 82, 5, 9, 90, 5, 2049, 86, 5, 129, 192, 5, 24577, 80, 5, 2, 87, 5, 385, 83, 5, 25, 91, 5, 6145, 81, 5, 7, 89, 5, 1537, 85, 5, 97, 93, 5, 24577, 80, 5, 4, 88, 5, 769, 84, 5, 49, 92, 5, 12289, 82, 5, 13, 90, 5, 3073, 86, 5, 193, 192, 5, 24577};
            BestHTTP.Decompression.Zlib.InfTree.cplens = new int[31] {3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 19, 23, 27, 31, 35, 43, 51, 59, 67, 83, 99, 115, 131, 163, 195, 227, 258, 0, 0};
            BestHTTP.Decompression.Zlib.InfTree.cplext = new int[31] {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0, 112, 112};
            BestHTTP.Decompression.Zlib.InfTree.cpdist = new int[30] {1, 2, 3, 4, 5, 7, 9, 13, 17, 25, 33, 49, 65, 97, 129, 193, 257, 385, 513, 769, 1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577};
            BestHTTP.Decompression.Zlib.InfTree.cpdext = new int[30] {0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13};
        }
    
    }

}
