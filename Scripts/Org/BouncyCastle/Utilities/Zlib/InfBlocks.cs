using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    internal sealed class InfBlocks
    {
        // Fields
        private const int MANY = 1440;
        private static readonly int[] inflate_mask;
        private static readonly int[] border;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        private const int TYPE = 0;
        private const int LENS = 1;
        private const int STORED = 2;
        private const int TABLE = 3;
        private const int BTREE = 4;
        private const int DTREE = 5;
        private const int CODES = 6;
        private const int DRY = 7;
        private const int DONE = 8;
        private const int BAD = 9;
        internal int mode;
        internal int left;
        internal int table;
        internal int index;
        internal int[] blens;
        internal int[] bb;
        internal int[] tb;
        internal Org.BouncyCastle.Utilities.Zlib.InfCodes codes;
        private int last;
        internal int bitk;
        internal int bitb;
        internal int[] hufts;
        internal byte[] window;
        internal int end;
        internal int read;
        internal int write;
        internal object checkfn;
        internal long check;
        internal Org.BouncyCastle.Utilities.Zlib.InfTree inftree;
        
        // Methods
        internal InfBlocks(Org.BouncyCastle.Utilities.Zlib.ZStream z, object checkfn, int w)
        {
            this.bb = new int[1];
            this.tb = new int[1];
            this.codes = new Org.BouncyCastle.Utilities.Zlib.InfCodes();
            this.inftree = new Org.BouncyCastle.Utilities.Zlib.InfTree();
            val_5 = new System.Object();
            this.hufts = new int[4320];
            this.window = new byte[0];
            this.end = w;
            this.checkfn = val_5;
            this.mode = 0;
            this.reset(z:  z, c:  0);
        }
        internal void reset(Org.BouncyCastle.Utilities.Zlib.ZStream z, long[] c)
        {
            if(c != null)
            {
                    c[0] = this.check;
            }
            
            this.mode = 0;
            this.bitk = 0;
            this.bitb = 0;
            this.read = 0;
            this.write = 0;
            if(this.checkfn == null)
            {
                    return;
            }
            
            this.check = 1;
            z.adler = 1;
        }
        internal int proc(Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
        {
            Org.BouncyCastle.Utilities.Zlib.InfCodes val_84;
            int val_85;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_86;
            int val_87;
            int val_88;
            int val_89;
            int val_90;
            int val_91;
            int val_92;
            var val_94;
            var val_95;
            int val_96;
            byte val_97;
            int val_98;
            int val_99;
            byte val_100;
            var val_101;
            int val_102;
            var val_103;
            var val_104;
            int val_105;
            System.Int32[] val_106;
            var val_107;
            var val_108;
            int val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            var val_116;
            byte val_117;
            int val_118;
            var val_119;
            System.Int32[] val_120;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_121;
            var val_122;
            var val_123;
            var val_124;
            var val_125;
            var val_126;
            var val_127;
            var val_128;
            var val_129;
            var val_130;
            var val_131;
            var val_132;
            byte val_133;
            int val_134;
            byte val_135;
            var val_136;
            var val_137;
            System.Int32[] val_138;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_139;
            var val_140;
            string val_141;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_142;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_143;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_144;
            var val_145;
            val_85 = r;
            val_86 = z;
            if(val_86 != null)
            {
                    val_87 = z.next_in_index;
            }
            else
            {
                    val_87 = 28563616;
            }
            
            int val_87 = this.read;
            val_88 = z.avail_in;
            val_89 = this.bitk;
            val_90 = this.bitb;
            if(val_87 <= this.write)
            {
                goto label_3;
            }
            
            val_87 = val_87 + (~this.write);
            goto label_73;
            label_3:
            int val_88 = this.end;
            val_88 = val_88 - this.write;
            goto label_73;
            label_175:
            if(val_86 != null)
            {
                    val_91 = mem[z.avail_in];
                val_91 = val_88;
            }
            else
            {
                    val_91 = mem[z.avail_in];
                val_91 = val_88;
            }
            
            val_88 = z.avail_in;
            val_89 = this.bitk;
            val_90 = this.bitb;
            if(this.read > this.write)
            {
                    val_92 = this.read + (~this.write);
            }
            else
            {
                    val_92 = this.end - this.write;
            }
            
            if(this.last != 0)
            {
                goto label_11;
            }
            
            val_85 = 0;
            this.mode = 0;
            label_73:
            label_42:
            if(this.mode > 9)
            {
                goto label_18;
            }
            
            var val_91 = 106047616 + (this.mode) << 2;
            val_91 = val_91 + 106047616;
            goto (106047616 + (this.mode) << 2 + 106047616);
            label_25:
            if( == 0)
            {
                goto label_132;
            }
            
            val_88 =  - 1;
            val_87 =  + 1;
            byte val_92 = z.next_in[(long)];
            int val_6 = val_89 & 31;
            val_94 = val_89 + 8;
            val_92 = val_92 << val_6;
            val_85 = 0;
            val_97 = val_92 | val_90;
            if(val_89 <= 6)
            {
                goto label_25;
            }
            
            val_6 = val_97 & 1;
            this.last = val_6;
            if(((uint)(val_97 >> 1) & 3) == 1)
            {
                goto label_26;
            }
            
            if(((uint)(val_97 >> 1) & 3) == 2)
            {
                goto label_27;
            }
            
            if(((uint)(val_97 >> 1) & 3) == 3)
            {
                goto label_28;
            }
            
            int val_7 = val_94 - 3;
            int val_9 = val_7 & 7;
            val_97 = (val_97 >> 3) >> val_9;
            int val_10 = val_7 - val_9;
            val_98 = 1;
            goto label_41;
            label_26:
            int[] val_11 = new int[1];
            int[] val_12 = new int[1];
            System.Int32[][] val_13 = new System.Int32[][1];
            System.Int32[][] val_14 = new System.Int32[][1];
            int val_15 = Org.BouncyCastle.Utilities.Zlib.InfTree.inflate_trees_fixed(bl:  val_11, bd:  val_12, tl:  val_13, td:  val_14, z:  null);
            this.codes.mode = 0;
            this.codes.lbits = val_11[0];
            this.codes.dbits = val_12[0];
            this.codes.ltree = val_13[0];
            this.codes.ltree_index = 0;
            this.codes.dtree = val_14[0];
            this.codes.dtree_index = 0;
            this.codes.tree = 0;
            val_97 = val_97 >> 3;
            int val_16 = val_94 - 3;
            val_98 = 6;
            goto label_41;
            label_27:
            val_97 = val_97 >> 3;
            int val_17 = val_94 - 3;
            val_98 = 3;
            label_41:
            this.mode = val_98;
            goto label_42;
            label_48:
            if(val_88 == 0)
            {
                goto label_80;
            }
            
            val_88 = val_88 - 1;
            int val_18 = val_87 + 1;
            byte val_97 = z.next_in[(long)val_87];
            val_97 = val_97 << (val_17 & 31);
            val_99 = val_17 + 8;
            val_100 = val_97 | val_97;
            if(val_17 <= 23)
            {
                goto label_48;
            }
            
            val_97 = val_100 >> 16;
            val_97 = val_97 ^ 65535;
            if(val_97 != val_100)
            {
                goto label_49;
            }
            
            this.left = val_97;
            if(val_97 == 0)
            {
                goto label_50;
            }
            
            val_101 = 2;
            goto label_51;
            label_64:
            if(val_88 == 0)
            {
                goto label_80;
            }
            
            val_102 = val_88 - 1;
            val_18 = val_18 + 1;
            if(val_18 >= z.next_in.Length)
            {
                    val_103 = 0;
            }
            
            byte val_99 = z.next_in[(long)val_18];
            int val_23 = val_99 & 31;
            val_104 = 0;
            val_99 = val_99 << val_23;
            val_99 = val_99 + 8;
            val_100 = val_99 | val_100;
            val_105 = val_18;
            if(val_99 <= 5)
            {
                goto label_64;
            }
            
            val_99 = val_100 & 31;
            val_23 = val_100 & 16383;
            mem[1152921543871716344] = val_23;
            if((val_99 > 29) || (((uint)(val_100 >> 5) & 31) >= 30))
            {
                goto label_66;
            }
            
            val_106 = mem[1152921543871716352];
            val_99 = val_99 + ((uint)(val_100 >> 5) & 31);
            byte val_24 = val_99 + 258;
            if(val_106 != 0)
            {
                    if(val_24 <= (mem[1152921543871716352] + 24))
            {
                goto label_68;
            }
            
            }
            
            int[] val_25 = new int[0];
            mem[1152921543871716352] = val_25;
            goto label_69;
            label_50:
            label_51:
            this.mode = (this.last == 0) ? 0 : 7;
            goto label_73;
            label_68:
            val_111 = 0;
            goto label_74;
            label_77:
            val_106 = mem[1152921543871716352];
            val_111 = 1;
            label_74:
            if(val_111 >= mem[1152921543872031032])
            {
                    val_103 = 0;
            }
            
            System.Int32[] val_28 = val_106 + 4;
            mem2[0] = 0;
            if((val_24 - 1) != val_111)
            {
                goto label_77;
            }
            
            label_69:
            val_107 = 0;
            val_112 = val_100 >> 14;
            val_113 = val_99 - 14;
            mem[1152921543871716348] = 0;
            this.mode = 4;
            byte val_100 = mem[1152921543871716344];
            val_100 = val_100 >> 10;
            val_100 = val_100 + 4;
            if(val_107 >= val_100)
            {
                goto label_78;
            }
            
            label_91:
            if(val_113 > 2)
            {
                goto label_79;
            }
            
            label_84:
            if(val_102 == 0)
            {
                goto label_80;
            }
            
            val_102 = val_102 - 1;
            if(val_105 >= z.next_in.Length)
            {
                    val_103 = 0;
            }
            
            byte val_101 = z.next_in[(long)val_105];
            val_104 = 0;
            val_101 = val_101 << (val_113 & 31);
            val_114 = val_113 + 8;
            val_115 = val_101 | val_112;
            val_105 = val_105 + 1;
            if(val_113 <= 6)
            {
                goto label_84;
            }
            
            label_79:
            val_116 = null;
            val_116 = null;
            mem[1152921543871716348] = 1;
            if(0 >= Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length)
            {
                    val_103 = 0;
            }
            
            if((Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length + 32) >= mem[1152921543872031032])
            {
                    val_103 = 0;
            }
            
            System.Int32[] val_32 = mem[1152921543871716352] + ((Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length + 32) << 2);
            mem2[0] = val_115 & 7;
            byte val_102 = mem[1152921543871716344];
            val_107 = mem[1152921543871716348];
            val_117 = val_115 >> 3;
            val_118 = val_114 - 3;
            val_102 = val_102 >> 10;
            val_102 = val_102 + 4;
            if(1 < val_102)
            {
                goto label_91;
            }
            
            label_78:
            if(val_107 <= 18)
            {
                    do
            {
                val_119 = null;
                val_107 = mem[1152921543871716348];
                val_119 = null;
                mem[1152921543871716348] = val_107 + 1;
                if(1 >= Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length)
            {
                    val_103 = 0;
            }
            
                if((Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length + 32) >= mem[1152921543872031032])
            {
                    val_103 = 0;
            }
            
                System.Int32[] val_34 = mem[1152921543871716352] + ((Org.BouncyCastle.Utilities.Zlib.InfBlocks.border.Length + 32) << 2);
                mem2[0] = 0;
            }
            while(mem[1152921543871716348] < 19);
            
            }
            
            if((mem[1152921543871716360] + 24) == 0)
            {
                    val_103 = 0;
            }
            
            mem2[0] = 7;
            val_120 = mem[1152921543871716360];
            if(mem[1152921543871716448] == 0)
            {
                    val_120 = val_120;
            }
            
            int val_35 = mem[1152921543871716448].inflate_trees_bits(c:  val_25, bb:  val_120, tb:  mem[1152921543871716368], hp:  mem[1152921543871716400], z:  val_86);
            if(val_35 != 0)
            {
                goto label_103;
            }
            
            val_121 = this;
            val_108 = 0;
            mem[1152921543871716348] = 0;
            this.mode = 5;
            var val_103 = (uint)(mem[1152921543871716344] >> 5) & 31;
            val_103 = (mem[1152921543871716344] & 31) + val_103;
            val_103 = val_103 + 258;
            if(val_108 >= val_103)
            {
                goto label_104;
            }
            
            label_155:
            if(val_118 >= (mem[1152921543871716360] + 32))
            {
                goto label_107;
            }
            
            label_112:
            if(val_102 == 0)
            {
                goto label_108;
            }
            
            val_102 = val_102 - 1;
            val_122 = val_105 + 1;
            var val_37 = (z + 16) + (long)val_105;
            var val_104 = (z + 16 + (long)(int)((((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : ??? : this.left > val_88 ? z.avail_in : this.left + z.avail_in) + 1) + 1) + 1) + 1))) + 32;
            val_123 = val_118 + 8;
            val_104 = val_104 << (val_118 & 31);
            val_124 = 0;
            val_125 = val_104 | val_117;
            if(val_123 < (mem[1152921543871716360] + 32))
            {
                goto label_112;
            }
            
            goto label_113;
            label_107:
            val_122 = val_105;
            val_124 = val_104;
            label_113:
            val_126 = null;
            val_126 = null;
            int val_39 = Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716360] + 32) << 2);
            byte val_40 = ((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32) & val_117;
            val_40 = val_40 + (mem[1152921543871716368] + 32);
            val_40 = val_40 + (val_40 << 1);
            val_40 = val_40 + 1;
            var val_41 = mem[1152921543871716400] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.next_in[(long)(int)(((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : ??? : this.left > val_8)) << 2);
            val_85 = mem[(mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.next_in[(long)(int)(((((val_3 > val_2 ? this.last > 0 ?  + 32];
            val_85 = (mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.next_in[(long)(int)(((((val_3 > val_2 ? this.last > 0 ?  + 32;
            int val_42 = Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.next_in[(long)(int)(((((val_3 > val_2 ? this.last > 0 ?  + 32) << 2);
            byte val_43 = ((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.next_i + 32) & val_117;
            val_43 = val_43 + (mem[1152921543871716368] + 32);
            val_43 = val_43 + (val_43 << 1);
            val_43 = val_43 + 2;
            var val_44 = mem[1152921543871716400] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[1152921543871716360] + 32) << 2) + 32 & (((z.ne)) << 2);
            val_127 = mem[(mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[115292 + 32];
            val_127 = (mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[115292 + 32;
            if(val_127 <= 15)
            {
                goto label_130;
            }
            
            val_86 = val_86;
            var val_46 = (val_127 == 18) ? 7 : (val_127 - 14);
            val_84 = val_46 + val_85;
            var val_47 = (val_127 == 18) ? 11 : 3;
            if(val_118 >= val_84)
            {
                goto label_131;
            }
            
            label_136:
            if(val_102 == 0)
            {
                goto label_132;
            }
            
            val_128 = val_102 - 1;
            val_129 = val_122 + 1;
            var val_48 = (z + 16) + (long)val_122;
            var val_105 = (z + 16 + (long)(int)((((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : ??? : this.left > val_88 ? z.avail_in : this.left + z.avail_in) + 1) + 1) + 1) + 1))) + 32;
            val_130 = val_118 + 8;
            val_105 = val_105 << (val_118 & 31);
            val_131 = 0;
            val_132 = val_105 | val_117;
            if(val_130 < val_84)
            {
                goto label_136;
            }
            
            goto label_137;
            label_130:
            mem[1152921543871716348] = mem[1152921543871716348] + 1;
            if(mem[1152921543871716352] == 0)
            {
                    val_127 = val_127;
            }
            
            val_133 = val_117 >> (val_85 & 31);
            val_134 = val_118 - val_85;
            if(mem[1152921543871716348] >= mem[1152921543872031032])
            {
                    val_127 = val_127;
            }
            
            System.Int32[] val_52 = mem[1152921543871716352] + 0;
            mem2[0] = val_127;
            val_135 = mem[1152921543871716348];
            goto label_140;
            label_131:
            val_129 = val_122;
            val_131 = val_124;
            label_137:
            val_136 = null;
            val_136 = null;
            byte val_55 = val_117 >> (val_85 & 31);
            int val_56 = Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (((long)(int)(val_127 == 0x12 ? 7 : ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + (mem[11529)) << 2);
            val_133 = val_55 >> (val_46 & 31);
            val_134 = (val_118 - val_85) - val_46;
            byte val_60 = (mem[1152921543871716344] & 31) + ((uint)(mem[1152921543871716344] >> 5) & 31);
            val_85 = (((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((long)(int)(val_127 == 0x12 ? 7 : ((mem[1152921543871716400] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD + ((mem[115292154387171 + 32) & val_55) + val_47;
            val_60 = val_60 + 258;
            if(val_85 > val_60)
            {
                goto label_147;
            }
            
            if(mem[1152921543871716348] <= 0)
            {
                    if(val_127 == 16)
            {
                goto label_147;
            }
            
            }
            
            if(val_127 == 16)
            {
                    var val_62 = mem[1152921543871716348] - 1;
                System.Int32[] val_63 = mem[1152921543871716352] + (((long)(int)(((mem[1152921543871716348] + 1) - 1))) << 2);
                val_137 = mem[(val_25 + ((long)(int)(((mem[1152921543871716348] + 1) - 1))) << 2) + 32];
                val_137 = (val_25 + ((long)(int)(((mem[1152921543871716348] + 1) - 1))) << 2) + 32;
            }
            else
            {
                    val_137 = 0;
            }
            
            var val_106 = -val_85;
            do
            {
                var val_65 = mem[1152921543871716348] + 1;
                System.Int32[] val_66 = mem[1152921543871716352] + (((long)(int)((mem[1152921543871716348] + 1))) << 2);
                val_106 = val_106 + 1;
                mem2[0] = val_137;
            }
            while(val_106 != 0);
            
            val_109 = val_129;
            val_110 = val_131;
            val_135 = val_47 + mem[1152921543871716348];
            mem[1152921543871716348] = val_135;
            val_121 = this;
            label_140:
            var val_107 = (uint)(mem[1152921543871716344] >> 5) & 31;
            val_107 = (mem[1152921543871716344] & 31) + val_107;
            val_107 = val_107 + 258;
            if(val_135 < val_107)
            {
                goto label_155;
            }
            
            goto label_156;
            label_104:
            val_109 = val_105;
            val_110 = val_104;
            label_156:
            mem2[0] = 0;
            int[] val_68 = new int[1];
            int[] val_69 = new int[1];
            val_68[0] = 9;
            val_69[0] = 6;
            val_138 = mem[1152921543871716352];
            if(mem[1152921543871716448] == 0)
            {
                    val_138 = val_138;
            }
            
            int val_75 = mem[1152921543871716448].inflate_trees_dynamic(nl:  (mem[1152921543871716344] & 31) + 257, nd:  ((uint)(mem[1152921543871716344] >> 5) & 31) + 1, c:  val_25, bl:  val_68, bd:  val_69, tl:  new int[1], td:  new int[1], hp:  mem[1152921543871716400], z:  val_86);
            if(val_75 != 0)
            {
                goto label_164;
            }
            
            val_84 = this.codes;
            val_85 = mem[1152921543872084336];
            this.codes.mode = 0;
            this.codes.lbits = val_68[0];
            this.codes.ltree = mem[1152921543871716400];
            this.codes.ltree_index = mem[1152921543872080224];
            this.codes.dtree = mem[1152921543871716400];
            this.codes.dbits = val_69[0];
            this.codes.dtree_index = val_85;
            this.codes.tree = 0;
            val_139 = this;
            this.mode = 6;
            val_86 = val_86;
            this.bitk = val_118;
            this.bitb = val_117;
            if(val_86 != 0)
            {
                    mem2[0] = val_102;
                val_88 = 24;
                var val_110 = 28563616;
                val_110 = val_109 - val_110;
                val_110 = (z + 32) + (val_110 << );
                mem2[0] = val_110;
            }
            else
            {
                    mem2[0] = val_102;
                val_84 = mem[z + 32];
                val_84 = z + 32;
                val_88 = 24;
                int val_76 = val_109 - 28563616;
                val_76 = val_84 + (val_76 << );
                mem2[0] = val_76;
            }
            
            mem[24] = val_109;
            this.write = 0;
            val_95 = this.codes.proc(s:  this, z:  val_86, r:  0);
            if(val_95 == 1)
            {
                goto label_175;
            }
            
            return this.inflate_flush(z:  val_86, r:  -3);
            label_132:
            val_139 = this;
            this.bitk = val_89;
            this.bitb = val_90;
            if(val_86 == null)
            {
                goto label_177;
            }
            
            z.avail_in = 0;
            label_208:
            val_140 = 24;
            int val_111 = mem[24];
            val_111 =  - val_111;
            val_111 = z.total_in + (val_111 << );
            z.total_in = val_111;
            goto label_206;
            label_28:
            int val_78 = val_94 - 3;
            val_139 = this;
            val_84 = val_97 >> 3;
            this.mode = 9;
            if(val_86 == null)
            {
                goto label_179;
            }
            
            z.msg = "invalid block type";
            this.bitk = val_78;
            this.bitb = val_84;
            label_204:
            z.avail_in = val_88;
            val_140 = 24;
            int val_112 = mem[24];
            val_112 = val_87 - val_112;
            val_112 = z.total_in + (val_112 << );
            z.total_in = val_112;
            goto label_180;
            label_177:
            z.avail_in = 0;
            label_212:
            val_84 = 32;
            val_140 = 24;
            val_88 = mem[24];
            int val_79 =  - val_88;
            val_79 = 64 + (val_79 << );
            mem[32] = val_79;
            goto label_206;
            label_179:
            mem[64] = "invalid block type";
            this.bitk = val_78;
            this.bitb = val_84;
            label_213:
            z.avail_in = val_88;
            val_84 = 32;
            val_88 = mem[32];
            val_140 = 24;
            int val_80 = val_87 - mem[24];
            val_80 = val_88 + (val_80 << );
            mem[32] = val_80;
            label_180:
            val_95 = -3;
            label_211:
            val_96 = val_87;
            label_206:
            mem[24] = val_96;
            this.write = 0;
            return this.inflate_flush(z:  val_86, r:  -3);
            label_80:
            this.bitk = val_17;
            this.bitb = val_97;
            if(val_86 == null)
            {
                goto label_182;
            }
            
            label_188:
            z.avail_in = 0;
            int val_113 = mem[24];
            val_113 = val_87 - val_113;
            val_113 = z.total_in + (val_113 << );
            z.total_in = val_113;
            goto label_206;
            label_18:
            this.bitk = val_89;
            this.bitb = val_90;
            if(val_86 == null)
            {
                goto label_184;
            }
            
            z.avail_in = ;
            int val_114 = mem[24];
            val_114 =  - val_114;
            val_114 = z.total_in + (val_114 << );
            z.total_in = val_114;
            goto label_211;
            label_108:
            this.bitk = val_118;
            this.bitb = val_117;
            if(val_86 != 0)
            {
                goto label_188;
            }
            
            label_182:
            mem2[0] = 0;
            int val_81 = val_105 - mem[24];
            val_81 = mem[32] + (val_81 << );
            mem[32] = val_81;
            goto label_206;
            label_184:
            z.avail_in = ;
            int val_82 =  - mem[24];
            val_82 = mem[32] + (val_82 << );
            mem[32] = val_82;
            goto label_211;
            label_11:
            this.mode = 7;
            this.write = 0;
            int val_83 = this.inflate_flush(z:  val_86, r:  0);
            if(this.read != this.write)
            {
                goto label_202;
            }
            
            this.mode = 8;
            this.bitk = val_89;
            this.bitb = val_90;
            if(val_86 == null)
            {
                goto label_192;
            }
            
            z.avail_in = val_88;
            int val_115 = mem[24];
            val_115 = val_91 - val_115;
            val_115 = z.total_in + (val_115 << );
            z.total_in = val_115;
            goto label_211;
            label_192:
            z.avail_in = val_88;
            int val_84 = val_91 - mem[24];
            val_84 = mem[32] + (val_84 << );
            mem[32] = val_84;
            goto label_211;
            label_66:
            this.mode = 9;
            if(val_86 == null)
            {
                goto label_195;
            }
            
            val_141 = "too many length or distance symbols";
            goto label_196;
            label_147:
            mem[1152921543871716352] = 0;
            this.mode = 9;
            if(val_86 == 0)
            {
                goto label_197;
            }
            
            mem2[0] = "invalid bit length repeat";
            this.bitk = val_134;
            this.bitb = val_133;
            mem2[0] = val_102;
            int val_116 = mem[24];
            val_116 = val_129 - val_116;
            val_116 = (z + 32) + (val_116 << );
            mem2[0] = val_116;
            goto label_206;
            label_164:
            if(val_75 != 3)
            {
                goto label_199;
            }
            
            val_142 = this;
            mem[1152921543871716352] = 0;
            this.mode = 9;
            val_143 = val_86;
            goto label_200;
            label_103:
            if(val_35 != 3)
            {
                goto label_201;
            }
            
            val_144 = this;
            mem[1152921543871716352] = 0;
            this.mode = 9;
            goto label_202;
            label_49:
            this.mode = 9;
            if(val_86 == null)
            {
                goto label_203;
            }
            
            val_141 = "invalid stored block lengths";
            label_196:
            z.msg = val_141;
            this.bitk = val_99;
            this.bitb = val_100;
            goto label_204;
            label_195:
            val_145 = "too many length or distance symbols";
            goto label_205;
            label_197:
            mem[64] = "invalid bit length repeat";
            this.bitk = val_134;
            this.bitb = val_133;
            mem2[0] = val_102;
            int val_85 = val_129 - mem[24];
            val_85 = mem[32] + (val_85 << );
            mem[32] = val_85;
            goto label_206;
            label_199:
            val_143 = val_86;
            val_142 = this;
            label_200:
            this.bitk = val_118;
            this.bitb = val_117;
            if(val_143 == 0)
            {
                goto label_207;
            }
            
            mem2[0] = val_102;
            goto label_208;
            label_201:
            val_144 = this;
            label_202:
            this.bitk = val_118;
            this.bitb = val_117;
            if(val_86 == null)
            {
                goto label_209;
            }
            
            z.avail_in = val_102;
            int val_117 = mem[24];
            val_117 = val_105 - val_117;
            val_117 = z.total_in + (val_117 << );
            z.total_in = val_117;
            goto label_211;
            label_209:
            z.avail_in = val_102;
            int val_86 = val_105 - mem[24];
            val_86 = mem[32] + (val_86 << );
            mem[32] = val_86;
            goto label_211;
            label_207:
            mem2[0] = val_102;
            goto label_212;
            label_203:
            val_145 = "invalid stored block lengths";
            label_205:
            mem[64] = val_145;
            this.bitk = val_99;
            this.bitb = val_100;
            goto label_213;
        }
        internal void free(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            this.reset(z:  z, c:  0);
            this.hufts = 0;
            this.window = 0;
        }
        internal void set_dictionary(byte[] d, int start, int n)
        {
            System.Array.Copy(sourceArray:  d, sourceIndex:  start, destinationArray:  this.window, destinationIndex:  0, length:  n);
            this.read = n;
            this.write = n;
        }
        internal int sync_point()
        {
            return (int)(this.mode == 1) ? 1 : 0;
        }
        internal int inflate_flush(Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
        {
            int val_8;
            int val_9;
            System.Byte[] val_10;
            System.Byte[] val_12;
            var val_13;
            int val_14;
            int val_15;
            val_8 = this.write;
            val_9 = z.next_out_index;
            if(this.read > val_8)
            {
                    val_8 = this.end;
            }
            
            int val_7 = z.avail_out;
            val_8 = val_8 - this.read;
            int val_1 = (val_8 > val_7) ? (val_7) : (val_8);
            val_8 = val_7 - val_1;
            val_7 = z.total_out + (val_1 << );
            z.avail_out = val_8;
            z.total_out = val_7;
            if(this.checkfn != null)
            {
                    val_12 = this;
                long val_3 = 0.adler32(adler:  this.check, buf:  this.window, index:  this.read, len:  val_1);
                this.check = val_3;
                z.adler = val_3;
            }
            else
            {
                    val_12 = this.window;
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.read, destinationArray:  z.next_out, destinationIndex:  val_9, length:  val_1);
            val_13 = val_1 + this.read;
            val_14 = val_1 + val_9;
            if(val_13 == this.end)
            {
                    val_15 = this.write;
                if(val_15 == val_13)
            {
                    val_15 = 0;
                this.write = 0;
            }
            
                int val_8 = z.avail_out;
                int val_4 = (val_15 > val_8) ? (val_8) : (val_15);
                val_15 = val_8 - val_4;
                val_8 = z.total_out + (val_4 << );
                z.avail_out = val_15;
                z.total_out = val_8;
                if(this.checkfn != null)
            {
                    val_9 = this.check;
                val_10 = this.window;
                long val_6 = 0.adler32(adler:  val_9, buf:  val_10, index:  0, len:  val_4);
                this.check = val_6;
                z.adler = val_6;
            }
            
                System.Array.Copy(sourceArray:  mem[this.window], sourceIndex:  0, destinationArray:  z.next_out, destinationIndex:  val_14, length:  val_4);
                val_14 = val_4 + val_14;
            }
            
            z.next_out_index = val_14;
            this.read = val_4;
            return (int)(val_4 == 0) ? 0 : ((val_1 == 0) ? 0 : r);
        }
        private static InfBlocks()
        {
            Org.BouncyCastle.Utilities.Zlib.InfBlocks.BAD = new int[17] {0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535};
            Org.BouncyCastle.Utilities.Zlib.InfBlocks.border = new int[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
        }
    
    }

}
