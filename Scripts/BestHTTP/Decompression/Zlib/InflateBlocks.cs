using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal sealed class InflateBlocks
    {
        // Fields
        private const int MANY = 1440;
        internal static readonly int[] border;
        private BestHTTP.Decompression.Zlib.InflateBlocks.InflateBlockMode mode;
        internal int left;
        internal int table;
        internal int index;
        internal int[] blens;
        internal int[] bb;
        internal int[] tb;
        internal BestHTTP.Decompression.Zlib.InflateCodes codes;
        internal int last;
        internal BestHTTP.Decompression.Zlib.ZlibCodec _codec;
        internal int bitk;
        internal int bitb;
        internal int[] hufts;
        internal byte[] window;
        internal int end;
        internal int readAt;
        internal int writeAt;
        internal object checkfn;
        internal uint check;
        internal BestHTTP.Decompression.Zlib.InfTree inftree;
        
        // Methods
        internal InflateBlocks(BestHTTP.Decompression.Zlib.ZlibCodec codec, object checkfn, int w)
        {
            this.bb = new int[1];
            this.tb = new int[1];
            this.codes = new BestHTTP.Decompression.Zlib.InflateCodes();
            this.inftree = new BestHTTP.Decompression.Zlib.InfTree();
            val_5 = new System.Object();
            this._codec = codec;
            this.hufts = new int[4320];
            this.window = new byte[0];
            this.end = w;
            this.checkfn = val_5;
            this.mode = 0;
            uint val_8 = this.Reset();
        }
        internal uint Reset()
        {
            this.mode = 0;
            this.bitk = 0;
            this.bitb = 0;
            this.readAt = 0;
            this.writeAt = 0;
            if(this.checkfn == null)
            {
                    return (uint)this.check;
            }
            
            this.check = 1;
            this._codec._Adler32 = 1;
            return (uint)this.check;
        }
        internal int Process(int r)
        {
            var val_70;
            BestHTTP.Decompression.Zlib.InflateBlocks val_71;
            BestHTTP.Decompression.Zlib.ZlibCodec val_72;
            int val_73;
            int val_74;
            int val_75;
            int val_76;
            BestHTTP.Decompression.Zlib.ZlibCodec val_77;
            int val_78;
            var val_80;
            var val_81;
            int val_82;
            InflateBlockMode val_83;
            BestHTTP.Decompression.Zlib.InflateBlocks val_84;
            int val_85;
            int val_86;
            int val_87;
            var val_88;
            var val_89;
            int val_90;
            var val_91;
            int val_92;
            int val_93;
            int val_94;
            int val_95;
            var val_96;
            var val_97;
            var val_98;
            int val_99;
            var val_100;
            var val_101;
            var val_102;
            byte val_103;
            int val_104;
            var val_105;
            System.Int32[] val_106;
            System.Int32[] val_107;
            BestHTTP.Decompression.Zlib.InflateBlocks val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            int val_114;
            var val_115;
            var val_116;
            BestHTTP.Decompression.Zlib.InflateBlocks val_117;
            var val_118;
            System.Int32[] val_119;
            System.Int32[] val_120;
            System.Int32[] val_121;
            BestHTTP.Decompression.Zlib.InflateBlocks val_122;
            BestHTTP.Decompression.Zlib.ZlibCodec val_123;
            BestHTTP.Decompression.Zlib.ZlibCodec val_124;
            var val_125;
            BestHTTP.Decompression.Zlib.ZlibCodec val_126;
            BestHTTP.Decompression.Zlib.ZlibCodec val_127;
            BestHTTP.Decompression.Zlib.ZlibCodec val_128;
            BestHTTP.Decompression.Zlib.ZlibCodec val_129;
            BestHTTP.Decompression.Zlib.ZlibCodec val_130;
            BestHTTP.Decompression.Zlib.ZlibCodec val_131;
            BestHTTP.Decompression.Zlib.ZlibCodec val_132;
            BestHTTP.Decompression.Zlib.ZlibCodec val_133;
            string val_134;
            BestHTTP.Decompression.Zlib.ZlibCodec val_135;
            BestHTTP.Decompression.Zlib.InflateBlocks val_136;
            var val_137;
            BestHTTP.Decompression.Zlib.ZlibCodec val_138;
            val_70 = r;
            val_71 = this;
            val_72 = this._codec;
            if(this._codec != null)
            {
                goto label_1;
            }
            
            val_72 = this._codec;
            if(val_72 == null)
            {
                goto label_225;
            }
            
            label_1:
            val_73 = this._codec.AvailableBytesIn;
            int val_71 = this.readAt;
            val_74 = this._codec.NextIn;
            val_75 = this.bitk;
            val_76 = this.bitb;
            if(val_71 <= this.writeAt)
            {
                goto label_3;
            }
            
            val_71 = val_71 + (~this.writeAt);
            goto label_72;
            label_3:
            int val_72 = this.end;
            val_72 = val_72 - this.writeAt;
            goto label_72;
            label_170:
            val_77 = this._codec;
            if(this._codec != null)
            {
                goto label_6;
            }
            
            val_77 = this._codec;
            if(val_77 == null)
            {
                goto label_225;
            }
            
            label_6:
            val_73 = this._codec.AvailableBytesIn;
            val_74 = this._codec.NextIn;
            val_75 = this.bitk;
            val_76 = this.bitb;
            if(this.readAt > this.writeAt)
            {
                    val_78 = this.readAt + (~this.writeAt);
            }
            else
            {
                    val_78 = this.end - this.writeAt;
            }
            
            if(this.last != 0)
            {
                goto label_10;
            }
            
            val_70 = 0;
            this.mode = 0;
            label_72:
            label_41:
            if(this.mode > 9)
            {
                goto label_17;
            }
            
            var val_76 = 106049244 + (this.mode) << 2;
            val_76 = val_76 + 106049244;
            goto (106049244 + (this.mode) << 2 + 106049244);
            label_24:
            if( == 0)
            {
                goto label_20;
            }
            
            System.Byte[] val_102 = this._codec.InputBuffer;
            val_73 =  - 1;
            val_74 =  + 1;
            byte val_77 = val_102[(long)];
            int val_6 = val_75 & 31;
            val_80 = val_75 + 8;
            val_77 = val_77 << val_6;
            val_76 = val_77 | val_76;
            val_75 = val_80;
            if(val_75 <= 6)
            {
                goto label_24;
            }
            
            val_6 = val_76 & 1;
            this.last = val_6;
            if(((uint)(val_76 >> 1) & 3) == 1)
            {
                goto label_25;
            }
            
            if(((uint)(val_76 >> 1) & 3) == 2)
            {
                goto label_26;
            }
            
            if(((uint)(val_76 >> 1) & 3) == 3)
            {
                goto label_27;
            }
            
            int val_7 = val_80 - 3;
            int val_9 = val_7 & 7;
            val_76 = (val_76 >> 3) >> val_9;
            int val_10 = val_7 - val_9;
            val_83 = 1;
            goto label_40;
            label_25:
            int[] val_11 = new int[1];
            int[] val_12 = new int[1];
            System.Int32[][] val_13 = new System.Int32[][1];
            System.Int32[][] val_14 = new System.Int32[][1];
            int val_15 = BestHTTP.Decompression.Zlib.InfTree.inflate_trees_fixed(bl:  val_11, bd:  val_12, tl:  val_13, td:  val_14, z:  null);
            mem2[0] = 0;
            mem2[0] = val_11[0];
            mem2[0] = val_12[0];
            mem2[0] = val_13[0];
            mem2[0] = 0;
            mem2[0] = val_14[0];
            mem2[0] = 0;
            mem2[0] = 0;
            val_84 = val_71;
            val_76 = val_76 >> 3;
            int val_16 = val_80 - 3;
            val_83 = 6;
            goto label_40;
            label_26:
            val_76 = val_76 >> 3;
            int val_17 = val_80 - 3;
            val_83 = 3;
            label_40:
            this.mode = val_83;
            goto label_41;
            label_47:
            if(val_73 == 0)
            {
                goto label_75;
            }
            
            val_85 = val_73 - 1;
            int val_18 = val_74 + 1;
            byte val_82 = this._codec.InputBuffer[(long)val_74];
            val_82 = val_82 << (val_17 & 31);
            val_86 = val_17 + 8;
            val_87 = val_82 | val_76;
            if(val_17 <= 23)
            {
                goto label_47;
            }
            
            val_82 = val_87 >> 16;
            val_82 = val_82 ^ 65535;
            if(val_82 != val_87)
            {
                goto label_48;
            }
            
            this.left = val_82;
            if(val_82 == 0)
            {
                goto label_49;
            }
            
            val_88 = 2;
            goto label_50;
            label_63:
            if(val_85 == 0)
            {
                goto label_75;
            }
            
            val_89 = val_85 - 1;
            val_18 = val_18 + 1;
            if(val_18 >= this._codec.InputBuffer.Length)
            {
                    val_90 = 0;
            }
            
            byte val_84 = this._codec.InputBuffer[(long)val_18];
            int val_23 = val_86 & 31;
            val_91 = 0;
            val_84 = val_84 << val_23;
            val_86 = val_86 + 8;
            val_87 = val_84 | val_87;
            val_92 = val_18;
            if(val_86 <= 5)
            {
                goto label_63;
            }
            
            val_84 = val_87 & 31;
            val_23 = val_87 & 16383;
            this.table = val_23;
            if((val_84 > 29) || (((uint)(val_87 >> 5) & 31) >= 30))
            {
                goto label_65;
            }
            
            val_84 = val_84 + ((uint)(val_87 >> 5) & 31);
            val_84 = val_84 + 258;
            if(this.blens != null)
            {
                    if(val_84 <= this.blens.Length)
            {
                goto label_67;
            }
            
            }
            
            int[] val_24 = new int[0];
            this.blens = val_24;
            goto label_68;
            label_49:
            label_50:
            this.mode = (this.last == 0) ? 0 : 7;
            goto label_72;
            label_67:
            val_90 = val_84;
            System.Array.Clear(array:  this.blens, index:  0, length:  val_90);
            label_68:
            val_93 = 0;
            val_97 = val_87 >> 14;
            val_98 = val_86 - 14;
            this.index = 0;
            this.mode = 4;
            int val_85 = this.table;
            val_85 = val_85 >> 10;
            val_85 = val_85 + 4;
            if(val_93 >= val_85)
            {
                goto label_73;
            }
            
            label_86:
            if(val_98 > 2)
            {
                goto label_74;
            }
            
            label_79:
            if(val_89 == 0)
            {
                goto label_75;
            }
            
            val_99 = val_89 - 1;
            if(val_92 >= this._codec.InputBuffer.Length)
            {
                    val_90 = 0;
            }
            
            byte val_86 = this._codec.InputBuffer[(long)val_92];
            val_91 = 0;
            val_86 = val_86 << (val_98 & 31);
            val_100 = val_98 + 8;
            val_101 = val_86 | val_97;
            val_92 = val_92 + 1;
            if(val_98 <= 6)
            {
                goto label_79;
            }
            
            label_74:
            val_102 = null;
            val_102 = null;
            this.index = this.index + 1;
            if(this.index >= BestHTTP.Decompression.Zlib.InflateBlocks.border.Length)
            {
                    val_90 = 0;
            }
            
            System.Int32[] val_29 = BestHTTP.Decompression.Zlib.InflateBlocks.border + ((this.index) << 2);
            if(((BestHTTP.Decompression.Zlib.InflateBlocks.border + (this.index) << 2) + 32) >= this.blens.Length)
            {
                    val_90 = 0;
            }
            
            this.blens[((BestHTTP.Decompression.Zlib.InflateBlocks.border + (this.index) << 2) + 32) << 2] = val_101 & 7;
            int val_87 = this.table;
            val_93 = this.index;
            val_103 = val_101 >> 3;
            val_104 = val_100 - 3;
            val_87 = val_87 >> 10;
            val_87 = val_87 + 4;
            if(val_93 < val_87)
            {
                goto label_86;
            }
            
            label_73:
            if(val_93 <= 18)
            {
                    do
            {
                val_105 = null;
                val_93 = this.index;
                val_105 = null;
                this.index = val_93 + 1;
                if(val_93 >= BestHTTP.Decompression.Zlib.InflateBlocks.border.Length)
            {
                    val_90 = 0;
            }
            
                System.Int32[] val_32 = BestHTTP.Decompression.Zlib.InflateBlocks.border + (((long)(int)(this.index)) << 2);
                if(((BestHTTP.Decompression.Zlib.InflateBlocks.border + ((long)(int)(this.index)) << 2) + 32) >= this.blens.Length)
            {
                    val_90 = 0;
            }
            
                this.blens[((BestHTTP.Decompression.Zlib.InflateBlocks.border + ((long)(int)(this.index)) << 2) + 32) << 2] = 0;
            }
            while(this.index < 19);
            
            }
            
            if(this.bb.Length == 0)
            {
                    val_90 = 0;
            }
            
            this.bb[0] = 7;
            val_106 = this.bb;
            val_107 = this.tb;
            if(this.inftree == null)
            {
                    val_107 = val_107;
                val_106 = val_106;
            }
            
            int val_33 = this.inftree.inflate_trees_bits(c:  this.blens, bb:  val_106, tb:  val_107, hp:  this.hufts, z:  this._codec);
            if(val_33 != 0)
            {
                goto label_98;
            }
            
            val_108 = val_71;
            val_94 = 0;
            this.index = 0;
            this.mode = 5;
            var val_88 = (uint)(this.table >> 5) & 31;
            val_88 = (this.table & 31) + val_88;
            val_88 = val_88 + 258;
            if(val_94 >= val_88)
            {
                goto label_99;
            }
            
            label_148:
            int val_89 = this.bb[0];
            if(val_104 >= val_89)
            {
                goto label_102;
            }
            
            label_107:
            if(val_99 == 0)
            {
                goto label_103;
            }
            
            val_99 = val_99 - 1;
            val_95 = val_92 + 1;
            byte val_90 = this._codec.InputBuffer[(long)val_92];
            val_109 = val_104 + 8;
            val_90 = val_90 << (val_104 & 31);
            val_96 = 0;
            val_110 = val_90 | val_103;
            if(val_109 < val_89)
            {
                goto label_107;
            }
            
            goto label_108;
            label_102:
            val_95 = val_92;
            val_96 = val_91;
            label_108:
            val_111 = null;
            val_111 = null;
            System.Int32[] val_36 = BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + ((this.bb[0]) << 2);
            byte val_37 = ((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32) & val_103;
            val_37 = val_37 + val_107[0];
            val_37 = val_37 + (val_37 << 1);
            val_37 = val_37 + 1;
            int val_92 = this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)(((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : ??? : thi)) << 2];
            System.Int32[] val_95 = this.hufts;
            System.Int32[] val_38 = BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + ((this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._codec.InputBuffer[(long)(int)(((((val_3 > val_2 ? this.last > 0 ? (this.last - 1) : ??? : thi)) << 2][0]) << 2);
            byte val_39 = ((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((this._ + 32) & val_103;
            val_39 = val_39 + val_107[0];
            val_39 = val_39 + (val_39 << 1);
            val_39 = val_39 + 2;
            int val_94 = val_95[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((th)) << 2];
            if(val_94 <= 15)
            {
                goto label_123;
            }
            
            val_95[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((th)) << 2] = val_94 - 14;
            var val_40 = (val_94 == 18) ? 7 : (val_95[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((th)) << 2]);
            val_95 = val_40 + val_92;
            var val_41 = (val_94 == 18) ? 11 : 3;
            if(val_104 >= val_95)
            {
                goto label_124;
            }
            
            label_129:
            if(val_99 == 0)
            {
                goto label_125;
            }
            
            val_99 = val_99 - 1;
            val_112 = val_95 + 1;
            byte val_96 = this._codec.InputBuffer[(long)val_95];
            val_109 = val_104 + 8;
            val_96 = val_96 << (val_104 & 31);
            val_113 = 0;
            val_110 = val_96 | val_103;
            if(val_109 < val_95)
            {
                goto label_129;
            }
            
            goto label_130;
            label_123:
            this.index = this.index + 1;
            val_76 = val_103 >> (val_92 & 31);
            val_75 = val_104 - val_92;
            mem2[0] = val_94;
            val_108 = val_108;
            val_114 = this.index;
            goto label_133;
            label_124:
            val_112 = val_95;
            val_113 = val_96;
            label_130:
            val_115 = null;
            val_115 = null;
            byte val_47 = val_103 >> (val_92 & 31);
            System.Int32[] val_48 = BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (((long)(int)(this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.bb[0]) << 2) + 32 & (((th)) << 2] == 18 ? 7 : (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.)) << 2);
            val_76 = val_47 >> (val_40 & 31);
            val_75 = (val_104 - val_92) - val_40;
            int val_52 = (this.table & 31) + ((uint)(this.table >> 5) & 31);
            val_116 = val_41;
            val_52 = val_52 + 258;
            val_92 = (((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + ((long)(int)(this.hufts[((long)(int)((((((BestHTTP.Decompression.Zlib.InternalInflateConstants.InflateMask + (this.hufts[((long)(int + 32) & val_47) + val_116;
            if(val_92 > val_52)
            {
                goto label_140;
            }
            
            if(this.index <= 0)
            {
                    if(val_94 == 16)
            {
                goto label_140;
            }
            
            }
            
            if(val_94 == 16)
            {
                    val_117 = val_108;
                int val_54 = this.index - 1;
                System.Int32[] val_55 = this.blens + (((long)(int)(((this.index + 1) - 1))) << 2);
                val_118 = mem[(val_24 + ((long)(int)(((this.index + 1) - 1))) << 2) + 32];
                val_116 = val_41;
            }
            else
            {
                    val_117 = val_108;
                val_118 = 0;
            }
            
            var val_97 = -val_92;
            do
            {
                int val_57 = this.index + 1;
                System.Int32[] val_58 = this.blens + (((long)(int)((this.index + 1))) << 2);
                mem2[0] = val_118;
                val_108 = val_108;
                val_97 = val_97 + 1;
            }
            while(val_97 != 0);
            
            val_95 = val_112;
            val_96 = val_113;
            val_114 = val_116 + this.index;
            this.index = val_114;
            label_133:
            var val_98 = (uint)(this.table >> 5) & 31;
            val_98 = (this.table & 31) + val_98;
            val_98 = val_98 + 258;
            if(val_114 < val_98)
            {
                goto label_148;
            }
            
            goto label_149;
            label_99:
            val_95 = val_92;
            val_96 = val_91;
            label_149:
            this.tb[0] = 0;
            int[] val_60 = new int[1];
            val_60[0] = 9;
            int[] val_61 = new int[1];
            val_61[0] = 6;
            int[] val_63 = new int[1];
            val_119 = val_63;
            val_120 = this.blens;
            val_121 = this.hufts;
            if(this.inftree == null)
            {
                    val_121 = val_121;
                val_119 = val_119;
                val_120 = val_120;
            }
            
            int val_67 = this.inftree.inflate_trees_dynamic(nl:  (this.table & 31) + 257, nd:  ((uint)(this.table >> 5) & 31) + 1, c:  val_24, bl:  val_60, bd:  val_61, tl:  new int[1], td:  val_63, hp:  val_121, z:  this._codec);
            if(val_67 != 0)
            {
                goto label_157;
            }
            
            mem2[0] = 0;
            mem2[0] = val_60[0];
            mem2[0] = val_61[0];
            mem2[0] = mem[1152921553813747536];
            mem2[0] = this.hufts;
            mem2[0] = mem[1152921553813751648];
            mem2[0] = this.hufts;
            mem2[0] = 0;
            val_122 = val_108;
            this.mode = 6;
            this.bitk = val_104;
            this.bitb = val_103;
            this._codec.AvailableBytesIn = val_99;
            val_123 = this._codec;
            if(this._codec != null)
            {
                goto label_166;
            }
            
            val_123 = this._codec;
            if(val_123 == null)
            {
                goto label_225;
            }
            
            label_166:
            int val_100 = this._codec.NextIn;
            val_100 = val_95 - val_100;
            val_100 = this._codec.TotalBytesIn + (val_100 << );
            this._codec.TotalBytesIn = val_100;
            val_124 = this._codec;
            this._codec.NextIn = val_95;
            val_82 = mem[1152921553812900360];
            this.writeAt = 0;
            val_81 = val_82.Process(blocks:  this, r:  0);
            if(val_81 == 1)
            {
                goto label_170;
            }
            
            return this.Flush(r:  -3);
            label_20:
            this.bitk = val_75;
            this.bitb = val_76;
            val_125 = 0;
            this._codec.AvailableBytesIn = 0;
            label_222:
            val_124 = this._codec;
            val_126 = val_124;
            if(val_124 != null)
            {
                goto label_193;
            }
            
            label_194:
            val_126 = this._codec;
            if(val_126 == null)
            {
                goto label_225;
            }
            
            label_193:
            int val_101 = this._codec.NextIn;
            val_101 =  - val_101;
            val_101 = this._codec.TotalBytesIn + (val_101 << );
            this._codec.TotalBytesIn = val_101;
            val_127 = this._codec;
            if(val_127 != null)
            {
                goto label_190;
            }
            
            goto label_225;
            label_27:
            val_102 = val_76 >> 3;
            this.mode = 9;
            this._codec.Message = "invalid block type";
            this.bitk = val_80 - 3;
            this.bitb = val_102;
            this._codec.AvailableBytesIn = val_73;
            label_220:
            val_124 = this._codec;
            val_128 = val_124;
            if(val_124 != null)
            {
                goto label_179;
            }
            
            val_128 = this._codec;
            if(val_128 == null)
            {
                goto label_225;
            }
            
            label_179:
            int val_103 = this._codec.NextIn;
            val_103 = val_74 - val_103;
            val_103 = this._codec.TotalBytesIn + (val_103 << );
            this._codec.TotalBytesIn = val_103;
            val_127 = this._codec;
            if(val_127 == null)
            {
                goto label_225;
            }
            
            val_81 = -3;
            label_204:
            val_82 = val_74;
            label_213:
            val_125 = 0;
            label_190:
            this._codec.NextIn = val_82;
            this.writeAt = 0;
            return this.Flush(r:  -3);
            label_17:
            this.bitk = val_75;
            this.bitb = val_76;
            this._codec.AvailableBytesIn = ;
            val_129 = this._codec;
            if(this._codec != null)
            {
                goto label_183;
            }
            
            val_129 = this._codec;
            if(val_129 == null)
            {
                goto label_225;
            }
            
            label_183:
            int val_104 = this._codec.NextIn;
            val_104 =  - val_104;
            val_104 = this._codec.TotalBytesIn + (val_104 << );
            this._codec.TotalBytesIn = val_104;
            if(this._codec == null)
            {
                goto label_225;
            }
            
            goto label_204;
            label_103:
            label_75:
            this.bitk = val_104;
            this.bitb = val_103;
            this._codec.AvailableBytesIn = 0;
            val_130 = this._codec;
            if(this._codec != null)
            {
                goto label_188;
            }
            
            val_130 = this._codec;
            if(val_130 == null)
            {
                goto label_225;
            }
            
            label_188:
            int val_105 = this._codec.NextIn;
            label_226:
            val_105 = val_92 - val_105;
            val_105 = this._codec.TotalBytesIn + (val_105 << );
            this._codec.TotalBytesIn = val_105;
            if(this._codec != null)
            {
                goto label_190;
            }
            
            goto label_225;
            label_125:
            this.bitk = val_104;
            this.bitb = val_103;
            this._codec.AvailableBytesIn = 0;
            if(this._codec != null)
            {
                goto label_193;
            }
            
            goto label_194;
            label_10:
            this.mode = 7;
            this.writeAt = 0;
            int val_70 = this.Flush(r:  0);
            if(this.readAt != this.writeAt)
            {
                goto label_195;
            }
            
            this.mode = 8;
            this.bitk = val_75;
            this.bitb = val_76;
            this._codec.AvailableBytesIn = val_73;
            val_131 = this._codec;
            if(this._codec != null)
            {
                goto label_197;
            }
            
            val_131 = this._codec;
            if(val_131 == null)
            {
                goto label_225;
            }
            
            label_197:
            int val_106 = this._codec.NextIn;
            val_106 = val_74 - val_106;
            val_106 = this._codec.TotalBytesIn + (val_106 << );
            this._codec.TotalBytesIn = val_106;
            if(this._codec == null)
            {
                goto label_225;
            }
            
            goto label_204;
            label_195:
            this.bitk = val_75;
            this.bitb = val_76;
            this._codec.AvailableBytesIn = val_73;
            val_132 = this._codec;
            if(this._codec != null)
            {
                goto label_202;
            }
            
            val_132 = this._codec;
            if(val_132 == null)
            {
                goto label_225;
            }
            
            label_202:
            int val_107 = this._codec.NextIn;
            val_107 = val_74 - val_107;
            val_107 = this._codec.TotalBytesIn + (val_107 << );
            this._codec.TotalBytesIn = val_107;
            if(this._codec != null)
            {
                goto label_204;
            }
            
            goto label_225;
            label_65:
            val_133 = this._codec;
            this.mode = 9;
            val_134 = "too many length or distance symbols";
            goto label_207;
            label_140:
            this.blens = 0;
            this.mode = 9;
            this._codec.Message = "invalid bit length repeat";
            this.bitk = val_75;
            this.bitb = val_76;
            this._codec.AvailableBytesIn = val_99;
            val_135 = this._codec;
            if(this._codec != null)
            {
                goto label_210;
            }
            
            val_135 = this._codec;
            if(val_135 == null)
            {
                goto label_225;
            }
            
            label_210:
            int val_108 = this._codec.NextIn;
            val_108 = val_112 - val_108;
            val_108 = this._codec.TotalBytesIn + (val_108 << );
            this._codec.TotalBytesIn = val_108;
            if(this._codec == null)
            {
                goto label_225;
            }
            
            goto label_213;
            label_157:
            if(val_67 != 3)
            {
                goto label_214;
            }
            
            val_136 = val_108;
            this.blens = 0;
            this.mode = 9;
            goto label_215;
            label_98:
            if(val_33 != 3)
            {
                goto label_216;
            }
            
            val_137 = val_71;
            this.blens = 0;
            this.mode = 9;
            goto label_217;
            label_48:
            val_133 = this._codec;
            this.mode = 9;
            val_134 = "invalid stored block lengths";
            label_207:
            this._codec.Message = val_134;
            this.bitk = val_86;
            this.bitb = val_87;
            this._codec.AvailableBytesIn = val_85;
            goto label_220;
            label_214:
            val_136 = val_108;
            label_215:
            this.bitk = val_104;
            this.bitb = val_103;
            this._codec.AvailableBytesIn = val_99;
            goto label_222;
            label_216:
            val_137 = val_71;
            label_217:
            this.bitk = val_104;
            this.bitb = val_103;
            this._codec.AvailableBytesIn = val_99;
            val_138 = this._codec;
            if(this._codec != null)
            {
                goto label_226;
            }
            
            val_138 = this._codec;
            if(val_138 == null)
            {
                goto label_225;
            }
            
            goto label_226;
            label_225:
        }
        internal void Free()
        {
            uint val_1 = this.Reset();
            this.hufts = 0;
            this.window = 0;
        }
        internal void SetDictionary(byte[] d, int start, int n)
        {
            System.Array.Copy(sourceArray:  d, sourceIndex:  start, destinationArray:  this.window, destinationIndex:  0, length:  n);
            this.readAt = n;
            this.writeAt = n;
        }
        internal int SyncPoint()
        {
            return (int)(this.mode == 1) ? 1 : 0;
        }
        internal int Flush(int r)
        {
            var val_8;
            int val_9;
            var val_10;
            int val_11;
            BestHTTP.Decompression.Zlib.ZlibCodec val_12;
            int val_13;
            BestHTTP.Decompression.Zlib.ZlibCodec val_14;
            long val_15;
            BestHTTP.Decompression.Zlib.ZlibCodec val_16;
            BestHTTP.Decompression.Zlib.ZlibCodec val_17;
            int val_18;
            var val_19;
            val_8 = r;
            var val_8 = 0;
            label_23:
            val_9 = this.writeAt;
            if(val_8 != 0)
            {
                goto label_1;
            }
            
            val_10 = mem[this.writeAt];
            val_10 = this.writeAt;
            val_9 = this.end;
            if(this.readAt <= val_10)
            {
                goto label_2;
            }
            
            label_1:
            val_10 = mem[this.end];
            val_10 = val_9;
            label_2:
            val_11 = val_10 - this.readAt;
            if(val_11 == 0)
            {
                    return (int)(val_8 == 5) ? 0 : (val_8);
            }
            
            if(val_11 > this._codec.AvailableBytesOut)
            {
                    val_11 = this._codec.AvailableBytesOut;
            }
            
            val_12 = this._codec;
            if(val_12 != null)
            {
                    val_13 = this._codec.AvailableBytesOut;
            }
            else
            {
                    val_13 = 3670080;
                val_12 = 52;
            }
            
            mem[52] = val_13 - val_11;
            val_14 = this._codec;
            if(val_14 != null)
            {
                    val_15 = this._codec.TotalBytesOut;
            }
            else
            {
                    val_15 = 4194311;
                val_14 = 56;
            }
            
            mem[56] = val_15 + (val_11 << );
            if(this.checkfn != null)
            {
                    uint val_4 = BestHTTP.Decompression.Zlib.Adler.Adler32(adler:  this.check, buf:  this.window, index:  this.readAt, len:  val_11);
                this.check = val_4;
                this._codec._Adler32 = val_4;
            }
            
            val_16 = this._codec;
            if(this._codec != null)
            {
                goto label_15;
            }
            
            val_16 = this._codec;
            if(val_16 == null)
            {
                goto label_16;
            }
            
            label_15:
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.readAt, destinationArray:  this._codec.OutputBuffer, destinationIndex:  this._codec.NextOut, length:  val_11);
            val_17 = this._codec;
            if(val_17 != null)
            {
                    val_18 = this._codec.NextOut;
            }
            else
            {
                    val_18 = 0;
                val_17 = 48;
            }
            
            mem[48] = val_18 + val_11;
            int val_7 = this.readAt;
            val_7 = val_7 + val_11;
            this.readAt = val_7;
            if((val_8 != 0) || (val_7 != this.end))
            {
                goto label_20;
            }
            
            this.readAt = 0;
            if(this.writeAt != val_7)
            {
                goto label_23;
            }
            
            mem2[0] = 0;
            goto label_23;
            label_20:
            val_8 = val_8 + 2;
            if(val_8 < 2)
            {
                goto label_23;
            }
            
            val_19 = (val_11 == 0) ? 0 : (val_8);
            return (int)(val_8 == 5) ? 0 : (val_8);
            label_16:
        }
        private static InflateBlocks()
        {
            BestHTTP.Decompression.Zlib.InflateBlocks.border = new int[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
        }
    
    }

}
