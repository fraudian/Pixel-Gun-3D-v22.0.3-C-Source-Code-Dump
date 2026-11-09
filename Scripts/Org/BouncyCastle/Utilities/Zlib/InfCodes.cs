using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    internal sealed class InfCodes
    {
        // Fields
        private static readonly int[] inflate_mask;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        private const int START = 0;
        private const int LEN = 1;
        private const int LENEXT = 2;
        private const int DIST = 3;
        private const int DISTEXT = 4;
        private const int COPY = 5;
        private const int LIT = 6;
        private const int WASH = 7;
        private const int END = 8;
        private const int BADCODE = 9;
        private int mode;
        private int len;
        private int[] tree;
        private int tree_index;
        private int need;
        private int lit;
        private int get;
        private int dist;
        private byte lbits;
        private byte dbits;
        private int[] ltree;
        private int ltree_index;
        private int[] dtree;
        private int dtree_index;
        
        // Methods
        internal InfCodes()
        {
        
        }
        internal void init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            this.mode = 0;
            this.lbits = bl;
            this.dbits = bd;
            this.ltree = tl;
            this.ltree_index = tl_index;
            this.dtree = td;
            this.dtree_index = td_index;
            this.tree = 0;
        }
        internal int proc(Org.BouncyCastle.Utilities.Zlib.InfBlocks s, Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
        {
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_58;
            Org.BouncyCastle.Utilities.Zlib.InfCodes val_59;
            var val_60;
            int val_61;
            int val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_70;
            int val_71;
            var val_72;
            bool val_73;
            var val_74;
            int val_75;
            var val_77;
            int val_78;
            int val_79;
            int val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_103;
            var val_104;
            var val_105;
            var val_106;
            var val_107;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_115;
            var val_116;
            var val_118;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_121;
            val_58 = s;
            val_59 = this;
            if(z != null)
            {
                    val_60 = z;
                val_61 = z.next_in_index;
            }
            else
            {
                    val_60 = 24;
                val_61 = 28563616;
            }
            
            if(val_58 == null)
            {
                goto label_3;
            }
            
            val_62 = s.bitb;
            val_63 = s + 72 + -4;
            val_64 = s + 72;
            val_65 = mem[s + 72 + 32];
            val_65 = s + 72 + 32;
            val_66 = mem[s + 72 + 28];
            val_66 = s + 72 + 28;
            if(val_65 < val_66)
            {
                goto label_4;
            }
            
            goto label_137;
            label_3:
            val_62 = 0;
            val_63 = 5;
            val_65 = 123372880;
            val_67 = 100;
            if(val_65 >= 0)
            {
                goto label_137;
            }
            
            val_68 = 100;
            val_66 = 0;
            label_4:
            var val_1 = val_66 + val_65;
            goto label_137;
            label_144:
            var val_63 = 106047680 + (s.end) << 2;
            val_63 = val_63 + 106047680;
            goto (106047680 + (s.end) << 2 + 106047680);
            label_19:
            int val_64 = z.avail_in;
            if(val_64 == 0)
            {
                goto label_109;
            }
            
            val_64 = val_64 - 1;
            val_72 =  + 1;
            var val_3 = (z + 16) + 28563616;
            var val_65 = (z + 16 + 28563616) + 32;
            val_63 = val_63 + 8;
            val_65 = val_65 << (val_63 & 31);
            val_62 = val_65 | val_62;
            if(val_63 < )
            {
                goto label_19;
            }
            
            goto label_20;
            label_27:
            int val_66 = val_64;
            if(val_66 == 0)
            {
                goto label_109;
            }
            
            val_66 = val_66 - 1;
            val_74 =  + 1;
            var val_5 = (z + 16) + 28563616;
            var val_67 = (z + 16 + 28563616) + 32;
            val_63 = val_63 + 8;
            val_67 = val_67 << (val_63 & 31);
            val_62 = val_67 | val_62;
            if(val_63 < )
            {
                goto label_27;
            }
            
            goto label_28;
            label_20:
            val_77 = null;
            val_77 = null;
            val_78 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE;
            int val_7 = val_78 + ((this.get) << 2);
            int val_68 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (this.get) << 2) + 32;
            val_79 = val_63 - ;
            val_73 = mem[1152921543873817733];
            val_68 = val_68 & val_62;
            val_80 = val_62 >> ( & 31);
            val_68 = val_68 + mem[1152921543873817700];
            mem[1152921543873817712] = mem[1152921543873817760];
            this.need = val_73;
            mem[1152921543873817696] = 3;
            mem[1152921543873817700] = val_68;
            mem[1152921543873817704] = mem[1152921543873817752];
            val_81 = ;
            if(val_79 >= val_73)
            {
                goto label_37;
            }
            
            val_71 = r;
            val_70 = val_81;
            label_42:
            int val_69 = val_66;
            if(val_69 == 0)
            {
                goto label_38;
            }
            
            val_69 = val_69 - 1;
            val_81 = val_70 + 1;
            var val_9 = (z + 16) + 28563616;
            var val_70 = (z + 16 + 28563616) + 32;
            int val_10 = val_79 & 31;
            val_82 = val_79 + 8;
            val_70 = val_70 << val_10;
            val_83 = val_70 | val_80;
            if(val_82 < val_73)
            {
                goto label_42;
            }
            
            label_37:
            val_59 = val_59;
            val_84 = null;
            val_84 = null;
            int val_11 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((long)(int)(mem[1152921543873817733])) << 2);
            var val_71 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32;
            val_71 = val_71 & val_83;
            val_71 = val_71 + mem[1152921543873817712];
            int val_12 = val_71 + (val_71 << 1);
            val_10 = val_12 + 1;
            var val_13 = mem[1152921543873817704] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this.get) & 31)) | (s.bitb >> (this.get & 31))) << 2);
            var val_14 = mem[1152921543873817704] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this.get) & 31)) | (s.bitb >> (this.get & 31))) << 2);
            val_85 = mem[(mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32];
            val_85 = (mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32;
            if(mem[1152921543873817704] == 0)
            {
                    val_85 = val_85;
            }
            
            if(val_12 >= (mem[1152921543873817752] + 24))
            {
                    val_85 = val_85;
            }
            
            var val_16 = mem[1152921543873817704] + (((long)(int)(((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this.get) & 31)) | (s.bitb >> (this.get & 31)))) << 2);
            int val_72 = (mem[1152921543873817752] + ((long)(int)(((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this. + 32;
            val_62 = val_83 >> (((mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32) & 31);
            val_63 = val_82 - val_85;
            if((val_72 & 16) != 0)
            {
                goto label_53;
            }
            
            if((val_72 & 64) != 0)
            {
                goto label_54;
            }
            
            this.need = val_72;
            val_58 = val_58;
            int val_17 = val_12 + 2;
            var val_18 = mem[1152921543873817704] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this.get) & 31)) | (s.bitb >> (this.get & 31))) << 2);
            val_86 = mem[(mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32];
            val_86 = (mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32;
            goto label_57;
            label_53:
            val_72 = val_72 & 15;
            this.get = val_72;
            val_58 = val_58;
            int val_19 = val_12 + 2;
            var val_20 = mem[1152921543873817704] + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this.get) & 31)) | (s.bitb >> (this.get & 31))) << 2);
            mem[1152921543873817696] = 4;
            mem[1152921543873817728] = (mem[1152921543873817752] + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(mem[1152921543873817733])) << 2) + 32 & (((z + 16 + 28563616) + 32 << ((s + 72 + -4 - this + 32;
            goto label_137;
            label_28:
            val_59 = val_59;
            val_88 = null;
            val_88 = null;
            val_58 = val_58;
            int val_21 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((val_70 + 1) + 44) << 2);
            var val_73 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((val_70 + 1) + 44) << 2) + 32;
            val_63 = val_63 - ;
            val_73 = val_73 & val_62;
            val_62 = val_62 >> ( & 31);
            val_75 = val_73 + mem[1152921543873817728];
            mem[1152921543873817728] = val_75;
            mem[1152921543873817696] = 5;
            val_89 = val_65 - val_75;
            if((val_89 & 2147483648) != 0)
            {
                    do
            {
                val_89 = (s + 96) + val_89;
            }
            while((val_89 & 2147483648) != 0);
            
            }
            
            if(mem[1152921543873817700] != 0)
            {
                goto label_88;
            }
            
            goto label_89;
            label_82:
            val_90 = mem[s + 88];
            val_90 = s + 88;
            val_91 = mem[s + 88];
            val_91 = s + 88;
            if(val_91 != 0)
            {
                goto label_83;
            }
            
            goto label_71;
            label_88:
            if((s.end - val_65) != 0)
            {
                goto label_76;
            }
            
            if((val_65 != (s + 96)) || ((s + 72 + 28) == 0))
            {
                goto label_75;
            }
            
            val_93 = 0;
            if((((s + 72 + 28) > 0) ? ((s + 72 + 28) - 1) : (val_65)) != 0)
            {
                goto label_76;
            }
            
            label_75:
            mem[104] = val_93;
            val_93 = mem[104];
            if(val_93 < (s + 72 + 28))
            {
                    val_92 = (s + 72 + 28) + val_93;
                val_94 = mem[s + 96];
                val_94 = s + 96;
            }
            else
            {
                    val_94 = mem[s + 96];
                val_94 = s + 96;
                val_92 = val_94 - val_93;
            }
            
            if((val_93 == val_94) && ((s + 72 + 28) != 0))
            {
                    var val_27 = ((s + 72 + 28) > 0) ? ((s + 72 + 28) - 1) : (val_93);
                val_93 = 0;
            }
            
            if(val_27 == 0)
            {
                goto label_81;
            }
            
            label_76:
            if(val_58 == 0)
            {
                goto label_82;
            }
            
            val_91 = mem[s + 88];
            val_91 = s + 88;
            val_90 = val_91;
            if(val_91 != 0)
            {
                goto label_83;
            }
            
            label_71:
            label_83:
            var val_28 = val_91 + (long)val_89;
            var val_29 = val_90 + 0;
            mem2[0] = (s + 88 + (long)(int)((s + 96 + (s + 72 + 32 - (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((val_70 + 1) + 44) << 2) + 32 & (((z + 16 + 28563616) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + (me + 32;
            val_58 = val_58;
            val_65 = val_93 + 1;
            val_89 = val_89 + 1;
            val_27 = val_27 - 1;
            int val_30 = mem[1152921543873817700] - 1;
            var val_31 = (val_89 == (s + 96)) ? 0 : (val_89);
            mem[1152921543873817700] = val_30;
            if(val_30 != 0)
            {
                goto label_88;
            }
            
            goto label_89;
            label_113:
            var val_75 = z + 28;
            if(val_75 == 0)
            {
                goto label_109;
            }
            
            val_75 = val_75 - 1;
            val_104 =  + 1;
            var val_38 = (z + 16) + (long);
            var val_76 = (z + 16 + (long)(int)((val_70 + 1))) + 32;
            var val_39 =  & 31;
            val_105 =  + 8;
            val_76 = val_76 << val_39;
            val_106 = val_76 | ;
            if(val_105 < )
            {
                goto label_113;
            }
            
            val_59 = val_59;
            val_107 = null;
            val_107 = null;
            int val_40 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((long)(int)(this.lbits)) << 2);
            var val_77 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32;
            val_77 = val_77 & val_106;
            val_77 = val_77 + ;
            int val_41 = val_77 + (val_77 << 1);
            val_39 = val_41 + 1;
            System.Int32[] val_42 =  + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((O)) << 2);
            var val_78 = mem[(this.ltree + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb))  + 32];
            System.Int32[] val_43 =  + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((O)) << 2);
            val_78 = val_78 & 31;
            System.Int32[] val_44 =  + (((long)(int)(((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((Or)) << 2);
            int val_81 = mem[(this.ltree + ((long)(int)(((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + + 32];
            val_62 = val_106 >> val_78;
            val_63 = val_105 - (mem[(this.ltree + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb))  + 32]);
            if(val_81 == 0)
            {
                goto label_124;
            }
            
            if((val_81 & 16) != 0)
            {
                goto label_125;
            }
            
            val_58 = val_58;
            if((val_81 & 64) != 0)
            {
                goto label_126;
            }
            
            this.need = val_81;
            int val_45 = val_41 + 2;
            System.Int32[] val_46 =  + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((O)) << 2);
            val_86 = mem[(this.ltree + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb))  + 32];
            label_57:
            var val_79 = 0;
            val_79 = val_79 + 0;
            val_86 = val_86 + val_79;
            mem[1152921543873817712] = val_86;
            goto label_137;
            label_124:
            int val_80 = val_41;
            val_58 = val_58;
            val_80 = val_80 + 2;
            System.Int32[] val_47 =  + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((O)) << 2);
            mem[1152921543873817696] = 6;
            mem[1152921543873817720] = mem[(this.ltree + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb))  + 32];
            goto label_137;
            label_125:
            val_81 = val_81 & 15;
            this.get = val_81;
            val_58 = val_58;
            int val_48 = val_41 + 2;
            System.Int32[] val_49 =  + (((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb)) + this.ltree_index) + ((((O)) << 2);
            mem[1152921543873817696] = 2;
            mem[1152921543873817700] = mem[(this.ltree + ((long)(int)((((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(this.lbits)) << 2) + 32 & (((z + 16 + (long)(int)((val_70 + 1))) + 32 << (s + 72 + -4 & 31)) | s.bitb))  + 32];
            goto label_137;
            label_126:
            if((val_81 & 32) == 0)
            {
                goto label_136;
            }
            
            mem[1152921543873817696] = 7;
            goto label_137;
            label_89:
            mem2[0] = 0;
            label_137:
            if(((val_70 + 1) + 16) <= 9)
            {
                goto label_144;
            }
            
            if(0 == 0)
            {
                goto label_145;
            }
            
            mem[72] = val_62;
            goto label_146;
            label_109:
            val_108 = z;
            if(val_58 == 0)
            {
                goto label_147;
            }
            
            mem[72] = val_62;
            goto label_151;
            label_38:
            if(val_58 == 0)
            {
                goto label_149;
            }
            
            mem[72] = val_80;
            goto label_150;
            label_147:
            mem[72] = val_62;
            goto label_151;
            label_81:
            mem[72] = val_62;
            mem[68] = val_63;
            if(z == 0)
            {
                goto label_152;
            }
            
            mem2[0] = val_75;
            val_109 = val_60;
            var val_82 = ;
            val_82 = val_104 - val_82;
            val_82 = (z + 32) + (val_82 << );
            mem2[0] = val_82;
            val_110 = val_104;
            goto label_153;
            label_149:
            mem[72] = val_80;
            label_150:
            val_108 = z;
            label_151:
            mem[68] = val_79;
            if(val_108 != 0)
            {
                    mem2[0] = 0;
                val_111 = val_60;
                var val_83 = ;
                val_83 = val_70 - val_83;
                val_83 = (z + 32) + (val_83 << );
                mem2[0] = val_83;
            }
            else
            {
                    mem2[0] = 0;
                val_108 = 32;
                val_78 = 64;
                val_111 = val_60;
                val_103 = ;
                var val_53 = val_70 - val_103;
                val_53 = val_78 + (val_53 << );
                mem[32] = val_53;
            }
            
            mem[24] = val_70;
            if(val_58 != 0)
            {
                    mem[104] = val_65;
            }
            else
            {
                    mem[104] = val_65;
            }
            
            return val_58.inflate_flush(z:  z, r:  val_71);
            label_152:
            mem2[0] = val_75;
            val_109 = val_60;
            var val_54 = val_104 - mem[24];
            val_54 = mem[32] + (val_54 << );
            mem[32] = val_54;
            val_110 = val_104;
            label_153:
            mem[24] = val_110;
            mem[104] = val_93;
            return val_58.inflate_flush(z:  z, r:  val_71);
            label_145:
            mem[72] = val_62;
            label_146:
            mem[68] = val_63;
            if(z != 0)
            {
                    mem2[0] = ;
                val_115 = val_60;
                val_116 = ;
                var val_86 = mem[24];
                val_86 = val_116 - val_86;
                val_86 = (z + 32) + (val_86 << );
                mem2[0] = val_86;
            }
            else
            {
                    mem2[0] = ;
                val_115 = val_60;
                val_116 = ;
                var val_59 = val_116 - mem[24];
                val_59 = mem[32] + (val_59 << );
                mem[32] = val_59;
            }
            
            mem[24] = val_116;
            if(0 == 0)
            {
                goto label_178;
            }
            
            mem[104] = ;
            return val_58.inflate_flush(z:  z, r:  val_71);
            label_194:
            mem[104] = ;
            return val_58.inflate_flush(z:  z, r:  val_71);
            label_178:
            mem[104] = ;
            return val_58.inflate_flush(z:  z, r:  val_71);
            label_54:
            mem[1152921543873817696] = 9;
            val_121 = z;
            mem2[0] = "invalid distance code";
            goto label_184;
            label_136:
            mem[1152921543873817696] = 9;
            val_121 = z;
            mem2[0] = "invalid literal/length code";
            label_184:
            if(val_58 != 0)
            {
                    mem[72] = val_62;
            }
            else
            {
                    mem[72] = val_62;
            }
            
            mem[68] = val_63;
            mem2[0] = ;
            var val_91 = ;
            val_91 =  - val_91;
            val_91 = (z + 32) + (val_91 << );
            mem2[0] = val_91;
            mem[24] = ;
            if(val_58 != 0)
            {
                goto label_194;
            }
            
            mem[104] = ;
            return val_58.inflate_flush(z:  z, r:  val_71);
        }
        internal void free(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
        
        }
        internal int inflate_fast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, Org.BouncyCastle.Utilities.Zlib.InfBlocks s, Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            int val_25;
            int val_81;
            int val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            int val_87;
            var val_88;
            var val_89;
            var val_90;
            int val_91;
            var val_92;
            var val_93;
            int val_94;
            int val_95;
            System.Int32[] val_96;
            var val_97;
            var val_98;
            var val_99;
            int val_100;
            var val_101;
            var val_102;
            var val_103;
            int val_104;
            int val_105;
            var val_106;
            int val_107;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_108;
            int val_109;
            int val_110;
            int val_111;
            int val_112;
            var val_113;
            var val_114;
            System.Array val_115;
            System.Array val_116;
            int val_117;
            var val_118;
            var val_119;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_120;
            var val_121;
            System.Array val_122;
            System.Array val_123;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_124;
            int val_125;
            int val_126;
            int val_127;
            var val_128;
            int val_129;
            var val_130;
            var val_131;
            int val_132;
            int val_133;
            var val_134;
            Org.BouncyCastle.Utilities.Zlib.InfBlocks val_135;
            int val_136;
            int val_137;
            var val_138;
            if(z != null)
            {
                    val_81 = z.next_in_index;
            }
            else
            {
                    val_81 = 28563616;
            }
            
            if(s == 0)
            {
                goto label_3;
            }
            
            val_82 = mem[s + 72];
            val_82 = s + 72;
            val_83 = s + 72 + -4;
            val_84 = s + 72;
            val_85 = mem[s + 72 + 32];
            val_85 = s + 72 + 32;
            val_86 = mem[s + 72 + 28];
            val_86 = s + 72 + 28;
            if(val_85 < val_86)
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            val_82 = 0;
            val_83 = 5;
            val_84 = 104;
            val_85 = 123372880;
            if(123372880 >= 0)
            {
                goto label_6;
            }
            
            val_86 = 0;
            val_84 = 104;
            label_4:
            val_87 = val_86 + val_85;
            goto label_7;
            label_6:
            label_5:
            val_87 = (s + 96) - val_85;
            label_7:
            var val_79 = val_85;
            val_88 = null;
            val_88 = null;
            int val_1 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((long)(int)(bl)) << 2);
            int val_77 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE;
            int val_2 = val_77 + (((long)(int)(bd)) << 2);
            var val_80 = val_79;
            goto label_129;
            label_106:
            int val_3 = bd + 2;
            val_77 = val_77 & 15;
            val_89 = null;
            int val_78 = tl[((long)(int)((bd + 2))) << 2];
            val_89 = null;
            int val_4 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15)) << 2);
            val_90 = val_80 - val_77;
            val_91 = val_82 >> val_77;
            val_92 = ((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15)) << 2) + 32) & val_82;
            if(val_90 > 14)
            {
                    val_93 = val_81;
                val_94 = val_78;
                val_95 = td_index;
                val_96 = td;
            }
            else
            {
                    int val_5 = val_77 + 14;
                val_5 = val_5 - val_80;
                var val_81 = -123372883;
                val_79 = val_5 >> 3;
                val_5 = val_5 & 4294967288;
                val_5 = val_80 + val_5;
                val_80 = val_5 + 8;
                int val_6 = val_81 - val_77;
                do
            {
                var val_8 = (z + 16) + 28563616;
                var val_82 = (z + 16 + 28563616) + 32;
                val_81 = (val_6 + 8) & 31;
                val_6 = val_6 + 8;
                val_82 = val_82 << val_81;
                val_91 = val_82 | val_91;
            }
            while(val_6 < 7);
            
                int val_83 = z.avail_in;
                val_96 = td;
                val_90 = val_80 - val_77;
                val_83 = val_83 - 1;
                val_83 = val_83 - val_79;
                val_93 = 28563617 + val_79;
                val_94 = val_78;
                val_95 = td_index;
                val_92 = val_92;
            }
            
            val_94 = val_92 + val_94;
            val_97 = val_91 & ((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bd)) << 2) + 32);
            if(val_96 != 0)
            {
                goto label_27;
            }
            
            goto label_27;
            label_37:
            if((val_6 & 64) != 0)
            {
                goto label_28;
            }
            
            val_96 = td;
            int val_9 = val_80 + 2;
            val_98 = null;
            System.Int32[] val_10 = val_96 + (((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2);
            val_98 = null;
            val_97 = ((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32) + val_97;
            int val_11 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((((-123372883 - (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15)) + 8)) << 2);
            var val_84 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((-123372883 - (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15)) + 8)) << 2) + 32;
            val_84 = val_84 & val_91;
            val_97 = val_97 + val_84;
            label_27:
            val_99 = mem[td + 24];
            val_99 = td + 24;
            int val_12 = val_97 + val_95;
            val_12 = val_12 + (val_12 << 1);
            if(val_12 >= val_99)
            {
                    val_99 = mem[td + 24];
                val_99 = td + 24;
            }
            
            System.Int32[] val_13 = val_96 + (((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 << (((-123372883 - (Or)) << 2);
            var val_14 = (long)val_12 + 1;
            if(val_14 >= val_99)
            {
                    val_99 = mem[td + 24];
                val_99 = td + 24;
            }
            
            val_96 = val_96 + (((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 << (((-12)) << 2);
            val_100 = mem[(td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563 + 32];
            val_100 = (td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563 + 32;
            val_101 = val_91 >> (val_100 & 31);
            if((long)val_14 >= val_99)
            {
                    val_100 = mem[(td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563 + 32];
                val_100 = (td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563 + 32;
            }
            
            val_102 = val_90 - val_100;
            if((((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 <<  + 32) & 16) == 0)
            {
                goto label_37;
            }
            
            var val_16 = ((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 <<  + 32) & 15;
            if(val_102 < val_16)
            {
                    int val_17 = val_16 - 1;
                val_17 = val_17 - val_102;
                val_100 = val_17 >> 3;
                val_81 = (val_93 + (val_17 >> 3)) + 1;
                val_17 = val_17 & 4294967288;
                var val_85 = val_102;
                do
            {
                int val_19 = val_93 + 1;
                var val_20 = (z + 16) + (long)val_93;
                var val_86 = (z + 16 + (long)(int)((28563617 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) >> 3)))) + 32;
                val_85 = val_85 + 8;
                val_86 = val_86 << (val_85 & 31);
                val_101 = val_86 | val_101;
            }
            while(val_85 < val_16);
            
                int val_87 = val_83;
                int val_88 = val_17;
                val_87 = val_87 - 1;
                val_88 = val_102 + val_88;
                val_87 = val_87 - val_100;
                val_102 = val_88 + 8;
            }
            else
            {
                    val_81 = val_93;
            }
            
            var val_22 = (long)val_12 + 2;
            val_103 = null;
            System.Int32[] val_23 = td + (((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 << (((-12)) << 2);
            val_104 = val_94;
            int val_24 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563616) + 32 <<) << 2);
            var val_89 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) +  + 32;
            int val_90 = val_87;
            val_105 = val_101 >> val_16;
            val_106 = val_102 - val_16;
            val_89 = val_89 & val_101;
            val_89 = val_89 + ((td + ((long)(int)(((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 14) - val_85) & 4294967288)) + 8) + 2))) << 2) + 32 + ((((z + 16 + 28563 + 32);
            val_107 = val_25;
            val_90 = val_90 - ;
            int val_26 = val_107 - val_89;
            if(val_16 >= (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + 24))
            {
                goto label_51;
            }
            
            val_108 = s;
            do
            {
                var val_93 = val_26;
                val_109 = (s + 96) + val_93;
            }
            while((val_109 & 2147483648) != 0);
            
            if( <= (-val_93))
            {
                goto label_54;
            }
            
            var val_91 = val_25;
            val_110 =  + val_93;
            val_91 = val_91 - val_109;
            if((val_91 < 1) || (val_91 >= (-val_93)))
            {
                goto label_56;
            }
            
            var val_92 = val_25;
            val_92 = val_92 + (s + 96);
            do
            {
                var val_28 = (s + 88) + ((long)(s + 96) + val_93);
                val_111 = val_25 + 1;
                if(val_25 >= (s + 88 + 24))
            {
                    val_25 = val_111;
                val_111 = val_25;
            }
            
                var val_29 = (s + 88) + (long)val_25;
                mem2[0] = (s + 88 + (long)(int)((s + 96 + (val_25 - (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BAD + 32;
                val_108 = s;
                val_93 = val_93 + 1;
                val_25 = val_111;
            }
            while(val_93 != 0);
            
            val_110 = val_110;
            val_112 = val_92 - val_109;
            val_109 = 0;
            goto label_73;
            label_51:
            val_108 = s;
            if(val_89 != 1)
            {
                goto label_62;
            }
            
            if(val_108 == 0)
            {
                goto label_63;
            }
            
            if((s + 88) != 0)
            {
                goto label_74;
            }
            
            label_75:
            label_74:
            var val_30 = (s + 88) + (long)val_26;
            var val_31 = (s + 88) + (long)val_25;
            mem2[0] = (s + 88 + (long)(int)((val_25 - (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15) + 32;
            if(val_108 == 0)
            {
                goto label_68;
            }
            
            val_113 = mem[s + 88];
            val_113 = s + 88;
            val_114 = val_113;
            goto label_69;
            label_54:
            val_112 = val_25;
            goto label_73;
            label_62:
            if(val_108 == 0)
            {
                goto label_71;
            }
            
            val_115 = mem[s + 88];
            val_115 = s + 88;
            val_116 = val_115;
            goto label_72;
            label_56:
            System.Array.Copy(sourceArray:  s + 88, sourceIndex:  val_109, destinationArray:  s + 88, destinationIndex:  val_25, length:  -val_93);
            val_109 = 0;
            val_112 = val_25 - val_93;
            goto label_73;
            label_63:
            if((s + 88) != 0)
            {
                goto label_74;
            }
            
            goto label_75;
            label_68:
            val_114 = mem[s + 88];
            val_114 = s + 88;
            val_113 = mem[s + 88];
            val_113 = s + 88;
            label_69:
            var val_33 = val_113 + ((long)val_26 + 1);
            var val_94 = val_25;
            val_94 = val_94 + 2;
            val_109 = val_26 + 2;
            var val_35 = val_114 + ((long)val_94 + 1);
            mem2[0] = (s + 88 + (long)(int)(((val_25 - (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15 + 32;
            val_117 = val_110;
            val_112 = val_94;
            goto label_80;
            label_71:
            val_116 = mem[s + 88];
            val_116 = s + 88;
            val_115 = mem[s + 88];
            val_115 = s + 88;
            val_107 = val_25;
            label_72:
            System.Array.Copy(sourceArray:  val_116, sourceIndex:  val_26, destinationArray:  val_115, destinationIndex:  val_107, length:  2);
            val_108 = s;
            val_112 = val_107 + 2;
            val_109 = val_26 + 2;
            label_80:
            val_110 =  - 2;
            label_73:
            val_89 = val_112 - val_109;
            if((val_89 < 1) || (val_110 <= val_89))
            {
                goto label_82;
            }
            
            var val_95 = val_110;
            val_25 = val_112;
            goto label_91;
            label_86:
            val_118 = mem[s + 88];
            val_118 = s + 88;
            val_119 = mem[s + 88];
            val_119 = s + 88;
            if(val_119 != 0)
            {
                goto label_87;
            }
            
            goto label_85;
            label_91:
            if(val_108 == 0)
            {
                goto label_86;
            }
            
            val_119 = mem[s + 88];
            val_119 = s + 88;
            val_118 = val_119;
            if(val_119 != 0)
            {
                goto label_87;
            }
            
            label_85:
            label_87:
            var val_36 = val_119 + (long)val_109;
            var val_37 = val_112 + 1;
            val_109 = val_109 + 1;
            var val_38 = val_118 + (long)val_112;
            mem2[0] = (s + 88 + (long)(int)(((val_25 - (((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((td + ((long)(int)((((((td + ((long)(int)((((val_85 + ((((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE & 15 + 32;
            val_120 = s;
            val_95 = val_95 - 1;
            if(val_95 != 0)
            {
                goto label_91;
            }
            
            val_121 = val_25 + val_110;
            goto label_92;
            label_82:
            if(val_108 != 0)
            {
                    val_122 = mem[s + 88];
                val_122 = s + 88;
                val_123 = val_122;
            }
            else
            {
                    val_123 = mem[s + 88];
                val_123 = s + 88;
                val_122 = mem[s + 88];
                val_122 = s + 88;
            }
            
            System.Array.Copy(sourceArray:  val_123, sourceIndex:  val_109, destinationArray:  val_122, destinationIndex:  val_112, length:  val_110);
            val_120 = s;
            val_121 = val_112 + val_110;
            label_92:
            val_124 = z;
            val_125 = val_90;
            goto label_95;
            label_129:
            val_25 = val_80;
            if(val_83 <= 19)
            {
                    var val_39 = 19 - val_83;
                var val_96 = val_83;
                do
            {
                var val_44 = val_81 + 1;
                var val_45 = (z + 16) + 28563616;
                var val_97 = (z + 16 + 28563616) + 32;
                val_96 = val_96 + 8;
                val_97 = val_97 << (val_96 & 31);
                val_82 = val_97 | val_82;
            }
            while(val_96 < 12);
            
                int val_98 = val_87;
                val_83 = (val_83 + (val_39 & 4294967288)) + 8;
                val_81 = (val_81 + (val_39 >> 3)) + 1;
                val_98 = val_98 - 1;
                val_98 = val_98 - (val_39 >> 3);
            }
            
            var val_48 = val_82 & ((Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32);
            int val_99 = tl_index;
            val_99 = val_48 + val_99;
            int val_49 = val_99 + (val_99 << 1);
            int val_100 = tl[((long)(int)(((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & 3)) << 2];
            if(val_100 == 0)
            {
                goto label_103;
            }
            
            label_114:
            val_126 = tl.Length;
            int val_50 = val_49 + 1;
            if(val_50 >= val_126)
            {
                    val_126 = tl.Length;
            }
            
            val_127 = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2];
            if((long)val_50 >= val_126)
            {
                    val_127 = mem[tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2] + 32];
                val_127 = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2] + 32;
            }
            
            val_82 = val_82 >> (val_127 & 31);
            var val_52 = val_83 - val_127;
            if((val_100 & 16) != 0)
            {
                goto label_106;
            }
            
            if((val_100 & 64) != 0)
            {
                goto label_107;
            }
            
            int val_53 = val_49 + 2;
            val_128 = null;
            int val_101 = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2];
            val_128 = null;
            val_101 = val_101 + val_48;
            int val_54 = Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + (((long)(int)(tl[((long)(int)(((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & 3)) << 2][0])) << 2);
            var val_102 = (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(tl[((long)(int)(((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long) + 32;
            val_102 = val_102 & val_82;
            val_48 = val_101 + val_102;
            int val_103 = tl_index;
            val_103 = val_48 + val_103;
            int val_55 = val_103 + (val_103 << 1);
            if((tl[((long)(int)(((((tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616)) << 2]) != 0)
            {
                goto label_114;
            }
            
            val_129 = tl.Length;
            int val_56 = val_55 + 1;
            if(val_56 >= val_129)
            {
                    val_129 = tl.Length;
            }
            
            int val_105 = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 2856361)) << 2];
            val_130 = val_105;
            if((long)val_56 >= val_129)
            {
                    val_130 = mem[tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 2856361)) << 2] + 32];
                val_130 = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 2856361)) << 2] + 32;
            }
            
            int val_58 = val_55 + 2;
            val_124 = z;
            val_105 = val_82 >> (val_105 & 31);
            val_106 = val_52 - val_130;
            val_131 = 123372881;
            var val_59 = (s + 88) + 123372880;
            mem2[0] = tl[((long)(int)((((((tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 2856361)) << 2];
            val_132 = val_90;
            val_120 = s;
            goto label_121;
            label_103:
            val_133 = tl.Length;
            int val_60 = val_49 + 1;
            if(val_60 >= val_133)
            {
                    val_133 = tl.Length;
            }
            
            int val_107 = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2];
            val_134 = val_107;
            if((long)val_60 >= val_133)
            {
                    val_134 = mem[tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2] + 32];
                val_134 = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2] + 32;
            }
            
            int val_62 = val_49 + 2;
            val_105 = val_82 >> (val_107 & 31);
            val_106 = val_83 - val_134;
            val_131 = 123372881;
            var val_63 = (s + 88) + 123372880;
            mem2[0] = tl[((long)(int)((((((((z + 16 + 28563616) + 32 << (val_83 & 31)) | val_82) & (Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE + ((long)(int)(bl)) << 2) + 32) + tl_index) + ((((((z + 16 + 28563616) + 32 << (val_83 & )) << 2];
            val_132 = val_90;
            val_120 = s;
            val_124 = z;
            label_121:
            val_121 = val_131;
            val_125 = val_132 - 1;
            label_95:
            if(val_125 >= 258)
            {
                    if(val_98 > 9)
            {
                goto label_129;
            }
            
            }
            
            var val_109 = z + 28;
            var val_64 = val_106 >> 3;
            val_109 = val_109 - val_98;
            var val_65 = (val_64 < val_109) ? (val_64) : (val_109);
            var val_67 = val_81 - val_65;
            if(val_120 == 0)
            {
                goto label_131;
            }
            
            mem[72] = val_105;
            goto label_132;
            label_107:
            val_135 = s;
            if((val_100 & 32) != 0)
            {
                goto label_134;
            }
            
            mem2[0] = "invalid literal/length code";
            var val_110 = z + 28;
            var val_69 = val_52 >> 3;
            val_110 = val_110 - val_98;
            var val_70 = (val_69 < val_110) ? (val_69) : (val_110);
            val_127 = val_70 + val_98;
            var val_71 = val_81 - val_70;
            val_52 = val_52 - (val_70 << 3);
            if(val_135 == 0)
            {
                goto label_136;
            }
            
            mem[72] = val_82;
            goto label_137;
            label_28:
            if(z == 0)
            {
                goto label_138;
            }
            
            mem2[0] = "invalid distance code";
            goto label_139;
            label_134:
            var val_111 = z + 28;
            var val_72 = val_52 >> 3;
            val_111 = val_111 - val_98;
            var val_73 = (val_72 < val_111) ? (val_72) : (val_111);
            val_127 = val_73 + val_98;
            val_136 = val_81 - val_73;
            val_137 = val_52 - (val_73 << 3);
            if(val_135 == 0)
            {
                goto label_140;
            }
            
            mem[72] = val_82;
            goto label_141;
            label_138:
            mem[64] = "invalid distance code";
            label_139:
            var val_112 = z + 28;
            int val_74 = val_90 >> 3;
            val_135 = 72;
            val_112 = val_112 - val_98;
            var val_75 = (val_74 < val_112) ? (val_74) : (val_112);
            val_137 = val_75 + val_98;
            val_136 = val_93 - val_75;
            if(s != 0)
            {
                    mem[72] = val_91;
            }
            else
            {
                    mem[72] = val_91;
            }
            
            mem[68] = val_90 - (val_75 << 3);
            mem2[0] = val_137;
            var val_113 = 28563616;
            val_113 = val_136 - val_113;
            val_113 = (z + 32) + (val_113 << );
            mem2[0] = val_113;
            mem[24] = val_136;
            if(s != 0)
            {
                goto label_146;
            }
            
            label_147:
            label_146:
            val_138 = -3;
            goto label_145;
            label_136:
            mem[72] = val_82;
            label_137:
            mem[68] = val_52;
            mem2[0] = val_127;
            int val_114 = mem[24];
            val_114 = val_71 - val_114;
            val_114 = (z + 32) + (val_114 << );
            mem2[0] = val_114;
            mem[24] = val_71;
            if(val_135 != 0)
            {
                goto label_146;
            }
            
            goto label_147;
            label_140:
            mem[72] = val_82;
            label_141:
            mem[68] = val_137;
            mem2[0] = val_127;
            var val_115 = mem[24];
            val_115 = val_136 - val_115;
            val_115 = (z + 32) + (val_115 << );
            mem2[0] = val_115;
            mem[24] = val_136;
            val_138 = 1;
            label_145:
            label_150:
            mem[104] = val_25;
            return (int)val_138;
            label_131:
            mem[72] = val_105;
            label_132:
            mem[68] = val_106 - (val_65 << 3);
            mem2[0] = val_65 + val_98;
            var val_116 = mem[24];
            val_116 = val_67 - val_116;
            val_116 = (z + 32) + (val_116 << );
            mem2[0] = val_116;
            mem[24] = val_67;
            if(val_120 != 0)
            {
                goto label_150;
            }
            
            goto label_150;
        }
        private static InfCodes()
        {
            Org.BouncyCastle.Utilities.Zlib.InfCodes.BADCODE = new int[17] {0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535};
        }
    
    }

}
