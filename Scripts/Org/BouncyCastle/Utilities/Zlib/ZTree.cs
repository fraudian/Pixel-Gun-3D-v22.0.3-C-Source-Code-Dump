using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    internal sealed class ZTree
    {
        // Fields
        private const int MAX_BITS = 15;
        private const int BL_CODES = 19;
        private const int D_CODES = 30;
        private const int LITERALS = 256;
        private const int LENGTH_CODES = 29;
        private const int L_CODES = 286;
        private const int HEAP_SIZE = 573;
        internal const int MAX_BL_BITS = 7;
        internal const int END_BLOCK = 256;
        internal const int REP_3_6 = 16;
        internal const int REPZ_3_10 = 17;
        internal const int REPZ_11_138 = 18;
        internal static readonly int[] extra_lbits;
        internal static readonly int[] extra_dbits;
        internal static readonly int[] extra_blbits;
        internal static readonly byte[] bl_order;
        internal const int Buf_size = 16;
        internal const int DIST_CODE_LEN = 512;
        internal static readonly byte[] _dist_code;
        internal static readonly byte[] _length_code;
        internal static readonly int[] base_length;
        internal static readonly int[] base_dist;
        internal short[] dyn_tree;
        internal int max_code;
        internal Org.BouncyCastle.Utilities.Zlib.StaticTree stat_desc;
        
        // Methods
        internal static int d_code(int dist)
        {
            var val_3;
            var val_4;
            var val_5;
            System.Byte[] val_6;
            var val_7;
            val_3 = dist;
            val_4 = null;
            if(val_3 >= 256)
            {
                    val_5 = null;
                val_6 = Org.BouncyCastle.Utilities.Zlib.ZTree._dist_code;
                val_3 = (val_3 >> 7) + 256;
            }
            else
            {
                    val_7 = null;
                val_6 = Org.BouncyCastle.Utilities.Zlib.ZTree._dist_code;
            }
            
            System.Byte[] val_2 = val_6 + (long)val_3;
            return (int)(Org.BouncyCastle.Utilities.Zlib.ZTree._dist_code + (long)(int)(dist)) + 32;
        }
        internal void gen_bitlen(Org.BouncyCastle.Utilities.Zlib.Deflate s)
        {
            Org.BouncyCastle.Utilities.Zlib.StaticTree val_13;
            System.Int16[] val_14;
            int val_15;
            var val_16;
            int val_17;
            System.Int16[] val_18;
            int val_19;
            int val_20;
            var val_21;
            var val_22;
            val_13 = this.stat_desc;
            val_14 = this.dyn_tree;
            if(val_13 == null)
            {
                goto label_0;
            }
            
            goto label_1;
            label_0:
            if(this.stat_desc == null)
            {
                goto label_2;
            }
            
            val_13 = this.stat_desc;
            label_1:
            label_57:
            label_58:
            val_15 = this.stat_desc.max_length;
            val_16 = 0;
            goto label_3;
            label_7:
            val_16 = 1;
            s.bl_count[0] = 0;
            label_3:
            if(val_16 < 16)
            {
                goto label_7;
            }
            
            val_17 = s.heap_max;
            int val_13 = s.heap[(s.heap_max) << 2];
            val_18 = 1;
            val_14[val_18] = 0;
            int val_1 = s.heap_max + 1;
            if(val_1 > 572)
            {
                    return;
            }
            
            do
            {
                val_19 = this.dyn_tree.Length;
                if(1 >= val_19)
            {
                    val_19 = this.dyn_tree.Length;
            }
            
                short val_14 = val_14[1];
                long val_16 = 1;
                if(1 >= val_19)
            {
                    val_19 = this.dyn_tree.Length;
            }
            
                short val_15 = val_14[val_16];
                val_20 = val_15;
                var val_3 = (val_20 <= val_15) ? (0 + 1) : 0;
                val_16 = (val_20 <= val_15) ? (val_20) : (val_15 + 1);
                mem2[0] = val_16;
                if(null <= this.max_code)
            {
                    short val_17 = s.bl_count[(long)val_16];
                val_20 = this.stat_desc.extra_base;
                val_17 = val_17 + 1;
                System.Int32[] val_4 = 1152921505842138720 - val_20;
                s.bl_count[(long)val_16] = val_17;
                if(val_16 < s.bl_count.Length)
            {
                    val_15 = 0;
            }
            else
            {
                    System.Int32[] val_5 = this.stat_desc.extra_bits + (((long)(int)((1152921505842138720 - this.stat_desc.extra_base))) << 2);
                val_15 = mem[(this.stat_desc.extra_bits + ((long)(int)((1152921505842138720 - this.stat_desc.extra_base))) << 2) + 32];
                val_15 = (this.stat_desc.extra_bits + ((long)(int)((1152921505842138720 - this.stat_desc.extra_base))) << 2) + 32;
            }
            
                System.Int16[] val_18 = val_14;
                val_18 = val_18 + (-3648767616);
                val_18 = mem[(this.dyn_tree + -3648767616) + 32];
                val_18 = (this.dyn_tree + -3648767616) + 32;
                int val_6 = val_15 + val_16;
                val_6 = s.opt_len + (val_6 * val_18);
                s.opt_len = val_6;
                if(this.stat_desc.static_tree != 0)
            {
                    System.Int16[] val_19 = this.stat_desc.static_tree;
                val_19 = val_19 + 2;
                int val_20 = (this.stat_desc.static_tree + 2) + 32;
                val_20 = val_15 + val_20;
                val_20 = s.static_len + (val_20 * val_18);
                s.static_len = val_20;
            }
            
            }
            
                val_14 = val_14;
                val_1 = val_1 + 1;
                val_17 = (s.heap_max + 32) + 4;
            }
            while(val_1 != 573);
            
            if(val_3 == 0)
            {
                    return;
            }
            
            val_17 = 65535;
            do
            {
                var val_21 = val_15;
                do
            {
                val_21 = val_21 - 1;
            }
            while(s.bl_count[(long)val_21] == 0);
            
                val_15 = s.bl_count;
                short val_23 = val_15[(long)val_21];
                val_23 = val_23 + val_17;
                val_15[(long)val_21] = val_23;
                short val_24 = s.bl_count[(long)val_21 + 1];
                val_24 = val_24 + 2;
                s.bl_count[(long)val_21 + 1] = val_24;
                val_18 = s.bl_count;
                val_3 = val_3 - 2;
                short val_25 = val_18[(long)val_15];
                val_25 = val_25 + val_17;
                val_18[(long)val_15] = val_25;
            }
            while(val_3 > 0);
            
            if(val_15 == 0)
            {
                    return;
            }
            
            label_56:
            val_18 = s.bl_count;
            int val_29 = val_15;
            short val_26 = val_18[(long)val_29];
            label_55:
            val_15 = 573;
            label_47:
            if(val_26 == 0)
            {
                goto label_44;
            }
            
            var val_8 = 573 - 1;
            int val_27 = s.heap[((long)(int)((573 - 1))) << 2];
            if(val_27 > this.max_code)
            {
                goto label_47;
            }
            
            System.Int16[] val_9 = val_14 + 2;
            if(val_29 != ((this.dyn_tree + 2) + 32))
            {
                    val_21 = mem[this.dyn_tree + 24];
                val_21 = this.dyn_tree + 24;
                int val_10 = val_27 << 1;
                if(1 < val_21)
            {
                    val_22 = ((this.dyn_tree + 2) + 32) & 65535;
            }
            else
            {
                    val_22 = mem[(this.dyn_tree + 2) + 32];
                val_22 = (this.dyn_tree + 2) + 32;
                val_21 = mem[this.dyn_tree + 24];
                val_21 = this.dyn_tree + 24;
            }
            
                System.Int16[] val_11 = val_14 + (((long)(int)((s.heap[((long)(int)((573 - 1))) << 2][0] << 1))) << 1);
                int val_28 = (this.dyn_tree + ((long)(int)((s.heap[((long)(int)((573 - 1))) << 2][0] << 1))) << 1) + 32;
                val_28 = s.opt_len + ((val_15 - val_22) * val_28);
                s.opt_len = val_28;
                mem2[0] = val_15;
            }
            
            val_26 = val_26 - 1;
            goto label_55;
            label_44:
            val_29 = val_29 - 1;
            val_17 = val_15;
            if(val_29 != 0)
            {
                goto label_56;
            }
            
            return;
            label_2:
            if(this.stat_desc != null)
            {
                goto label_57;
            }
            
            if(this.stat_desc != null)
            {
                goto label_58;
            }
        
        }
        internal void build_tree(Org.BouncyCastle.Utilities.Zlib.Deflate s)
        {
            Org.BouncyCastle.Utilities.Zlib.StaticTree val_23;
            int val_24;
            var val_25;
            var val_26;
            System.Int32[] val_27;
            var val_28;
            var val_29;
            val_23 = this.stat_desc;
            if(this.stat_desc != null)
            {
                goto label_1;
            }
            
            val_23 = this.stat_desc;
            if(val_23 == null)
            {
                goto label_2;
            }
            
            label_1:
            if(s != null)
            {
                    val_24 = s.heap_len;
                s.heap_len = 0;
            }
            else
            {
                    val_24 = 256;
                mem[256] = 0;
            }
            
            s.heap_max = 573;
            if(this.stat_desc.elems <= 0)
            {
                goto label_5;
            }
            
            System.Int16[] val_28 = this.dyn_tree[24];
            var val_32 = 0;
            var val_31 = 0;
            var val_33 = 1;
            label_18:
            var val_1 = val_33 - 1;
            if(this.dyn_tree[0] == 0)
            {
                goto label_8;
            }
            
            if(s == null)
            {
                goto label_9;
            }
            
            val_26 = mem[s.heap];
            val_26 = s.heap;
            goto label_10;
            label_8:
            var val_30 = 4294967296;
            val_30 = val_32 + val_30;
            this.dyn_tree[val_30 >> 32] = 0;
            goto label_12;
            label_9:
            val_26 = mem[s.heap];
            val_26 = s.heap;
            val_25 = mem[256];
            label_10:
            mem[256] = 1;
            System.Int32[] val_3 = val_26 + 4;
            mem2[0] = val_31;
            System.Byte[] val_4 = s.depth + val_31;
            mem2[0] = 0;
            label_12:
            val_31 = val_31 + 1;
            val_32 = val_32 + 8589934592;
            val_33 = val_33 + 2;
            if(this.stat_desc.elems != val_31)
            {
                goto label_18;
            }
            
            val_27 = s.heap;
            goto label_30;
            label_5:
            System.Int16[] val_34 = this.dyn_tree[24];
            val_27 = s.heap;
            goto label_30;
            label_33:
            if(s != null)
            {
                    val_28 = mem[s.heap];
            }
            else
            {
                    val_28 = mem[s.heap];
            }
            
            mem[256] = mem[256] + 1;
            var val_6 = (0 >= 2) ? 0 : (0 + 1);
            int val_7 = (0 < 2) ? (0 + 1) : 0;
            var val_8 = val_28 + (((long)(int)((mem[256] + 1))) << 2);
            mem2[0] = val_6;
            var val_9 = val_6 << 1;
            this.dyn_tree[(long)val_9] = 1;
            System.Byte[] val_10 = s.depth + (long)val_6;
            mem2[0] = 0;
            int val_35 = s.opt_len;
            val_35 = val_35 - 1;
            s.opt_len = val_35;
            if(this.stat_desc.static_tree != null)
            {
                    val_9 = (long)val_9 | 1;
                short val_36 = this.stat_desc.static_tree[(long)val_9];
                val_36 = s.static_len - val_36;
                s.static_len = val_36;
            }
            
            label_30:
            if(mem[256] < 2)
            {
                goto label_33;
            }
            
            mem[1152921543893191128] = val_7;
            var val_37 = mem[256];
            if(val_37 >= 2)
            {
                    val_37 = val_37 >> 1;
                int val_11 = val_37 + 1;
                do
            {
                val_11 = val_11 - 1;
                s.pqdownheap(tree:  this.dyn_tree, k:  val_11);
            }
            while(val_11 > 1);
            
            }
            
            int val_12 = this.stat_desc.elems << 1;
            do
            {
                mem[256] = mem[256] - 1;
                var val_14 = mem[s.heap] + (((mem[256] + 1)) << 2);
                mem2[0] = (mem[s.heap] + ((mem[256] + 1)) << 2) + 32;
                s.pqdownheap(tree:  this.dyn_tree, k:  1);
                int val_38 = s.heap[0];
                s.heap_max = s.heap_max - 1;
                s.heap[((long)(int)((s.heap_max - 1))) << 2] = mem[s.heap] + 36;
                s.heap_max = s.heap_max - 1;
                s.heap[((long)(int)((s.heap_max - 1))) << 2] = val_38;
                var val_17 = (mem[s.heap] + 36) << 1;
                val_29 = mem[this.dyn_tree[0x18]];
                val_29 = val_34;
                if(val_17 >= val_29)
            {
                    val_29 = mem[this.dyn_tree[0x18]];
                val_29 = val_34;
            }
            
                short val_39 = this.dyn_tree[(long)val_17];
                int val_18 = val_38 << 1;
                if(val_18 >= val_29)
            {
                    val_29 = mem[this.dyn_tree[0x18]];
                val_29 = val_34;
            }
            
                val_39 = this.dyn_tree[(long)val_18] + val_39;
                this.dyn_tree[(long)val_12] = val_39;
                System.Byte[] val_19 = s.depth + ((long)mem[s.heap] + 36);
                System.Byte[] val_20 = s.depth + (long)val_38;
                byte val_41 = (s.depth + (long)(int)(s.heap[0])) + 32;
                val_41 = ((System.Math.Max(val1:  (s.depth + (long)(int)(mem[s.heap] + 36)) + 32, val2:  val_41)) & 255) + 1;
                System.Byte[] val_23 = s.depth + (long)this.stat_desc.elems;
                mem2[0] = val_41;
                this.dyn_tree[(long)(long)val_18 | 1] = this.stat_desc.elems;
                this.dyn_tree[(long)(long)val_17 | 1] = this.stat_desc.elems;
                int val_26 = this.stat_desc.elems + 1;
                mem2[0] = this.stat_desc.elems;
                s.pqdownheap(tree:  this.dyn_tree, k:  1);
                val_12 = val_12 + 2;
            }
            while(mem[256] > 1);
            
            s.heap_max = s.heap_max - 1;
            s.heap[((long)(int)((s.heap_max - 1))) << 2] = s.heap[0];
            this.gen_bitlen(s:  s);
            Org.BouncyCastle.Utilities.Zlib.ZTree.gen_codes(tree:  this.dyn_tree, max_code:  val_7, bl_count:  s.bl_count);
            return;
            label_2:
        }
        internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
        {
            var val_5;
            var val_6;
            short[] val_1 = new short[16];
            do
            {
                var val_2 = 0 + 1;
                mem2[0] = 0;
                val_6 = 0 + 1;
            }
            while(val_6 != 15);
            
            if((max_code & 2147483648) != 0)
            {
                    return;
            }
            
            val_6 = 1152921505510412288;
            var val_9 = 0;
            do
            {
                short val_6 = tree[1];
                if(val_6 != 0)
            {
                    short val_7 = val_1[(long)val_6];
                val_1[(long)val_6] = val_7 + 1;
                var val_8 = 0;
                short val_4 = val_6 + 1;
                do
            {
                val_4 = val_4 - 1;
                val_6 = (val_7 & 1) | val_8;
                val_7 = val_7 >> 1;
                val_8 = val_6 << 1;
            }
            while(val_4 > 1);
            
                val_5 = 0;
                tree[val_5] = val_6;
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 <= max_code);
        
        }
        internal static int bi_reverse(int code, int len)
        {
            var val_3 = 0;
            do
            {
                len = len - 1;
                val_3 = (code & 1) | val_3;
                code = code >> 1;
                val_3 = val_3 << 1;
            }
            while(len > 0);
            
            return (int)val_3 >> 1;
        }
        public ZTree()
        {
        
        }
        private static ZTree()
        {
            Org.BouncyCastle.Utilities.Zlib.ZTree.DIST_CODE_LEN = new int[29] {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0};
            Org.BouncyCastle.Utilities.Zlib.ZTree.extra_dbits = new int[30] {0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13};
            Org.BouncyCastle.Utilities.Zlib.ZTree.extra_blbits = new int[19] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 7};
            Org.BouncyCastle.Utilities.Zlib.ZTree.bl_order = new byte[19] {16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15};
            Org.BouncyCastle.Utilities.Zlib.ZTree._dist_code = new byte[512] {0, 1, 2, 3, 4, 4, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 0, 0, 16, 17, 18, 18, 19, 19, 20, 20, 20, 20, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29};
            Org.BouncyCastle.Utilities.Zlib.ZTree._length_code = new byte[256] {0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14, 15, 15, 15, 15, 16, 16, 16, 16, 16, 16, 16, 16, 17, 17, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19, 19, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 28};
            Org.BouncyCastle.Utilities.Zlib.ZTree.base_length = new int[29] {0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 14, 16, 20, 24, 28, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 0};
            Org.BouncyCastle.Utilities.Zlib.ZTree.base_dist = new int[30] {0, 1, 2, 3, 4, 6, 8, 12, 16, 24, 32, 48, 64, 96, 128, 192, 256, 384, 512, 768, 1024, 1536, 2048, 3072, 4096, 6144, 8192, 12288, 16384, 24576};
        }
    
    }

}
