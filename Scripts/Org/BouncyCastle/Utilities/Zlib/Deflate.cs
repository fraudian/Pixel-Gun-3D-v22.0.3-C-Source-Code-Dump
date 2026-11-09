using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    public sealed class Deflate
    {
        // Fields
        private const int MAX_MEM_LEVEL = 9;
        private const int Z_DEFAULT_COMPRESSION = -1;
        private const int MAX_WBITS = 15;
        private const int DEF_MEM_LEVEL = 8;
        private const int STORED = 0;
        private const int FAST = 1;
        private const int SLOW = 2;
        private static readonly Org.BouncyCastle.Utilities.Zlib.Deflate.Config[] config_table;
        private static readonly string[] z_errmsg;
        private const int NeedMore = 0;
        private const int BlockDone = 1;
        private const int FinishStarted = 2;
        private const int FinishDone = 3;
        private const int PRESET_DICT = 32;
        private const int Z_FILTERED = 1;
        private const int Z_HUFFMAN_ONLY = 2;
        private const int Z_DEFAULT_STRATEGY = 0;
        private const int Z_NO_FLUSH = 0;
        private const int Z_PARTIAL_FLUSH = 1;
        private const int Z_SYNC_FLUSH = 2;
        private const int Z_FULL_FLUSH = 3;
        private const int Z_FINISH = 4;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        private const int INIT_STATE = 42;
        private const int BUSY_STATE = 113;
        private const int FINISH_STATE = 666;
        private const int Z_DEFLATED = 8;
        private const int STORED_BLOCK = 0;
        private const int STATIC_TREES = 1;
        private const int DYN_TREES = 2;
        private const int Z_BINARY = 0;
        private const int Z_ASCII = 1;
        private const int Z_UNKNOWN = 2;
        private const int Buf_size = 16;
        private const int REP_3_6 = 16;
        private const int REPZ_3_10 = 17;
        private const int REPZ_11_138 = 18;
        private const int MIN_MATCH = 3;
        private const int MAX_MATCH = 258;
        private const int MIN_LOOKAHEAD = 262;
        private const int MAX_BITS = 15;
        private const int D_CODES = 30;
        private const int BL_CODES = 19;
        private const int LENGTH_CODES = 29;
        private const int LITERALS = 256;
        private const int L_CODES = 286;
        private const int HEAP_SIZE = 573;
        private const int END_BLOCK = 256;
        internal Org.BouncyCastle.Utilities.Zlib.ZStream strm;
        internal int status;
        internal byte[] pending_buf;
        internal int pending_buf_size;
        internal int pending_out;
        internal int pending;
        internal int noheader;
        internal byte data_type;
        internal byte method;
        internal int last_flush;
        internal int w_size;
        internal int w_bits;
        internal int w_mask;
        internal byte[] window;
        internal int window_size;
        internal short[] prev;
        internal short[] head;
        internal int ins_h;
        internal int hash_size;
        internal int hash_bits;
        internal int hash_mask;
        internal int hash_shift;
        internal int block_start;
        internal int match_length;
        internal int prev_match;
        internal int match_available;
        internal int strstart;
        internal int match_start;
        internal int lookahead;
        internal int prev_length;
        internal int max_chain_length;
        internal int max_lazy_match;
        internal int level;
        internal int strategy;
        internal int good_match;
        internal int nice_match;
        internal short[] dyn_ltree;
        internal short[] dyn_dtree;
        internal short[] bl_tree;
        internal Org.BouncyCastle.Utilities.Zlib.ZTree l_desc;
        internal Org.BouncyCastle.Utilities.Zlib.ZTree d_desc;
        internal Org.BouncyCastle.Utilities.Zlib.ZTree bl_desc;
        internal short[] bl_count;
        internal int[] heap;
        internal int heap_len;
        internal int heap_max;
        internal byte[] depth;
        internal int l_buf;
        internal int lit_bufsize;
        internal int last_lit;
        internal int d_buf;
        internal int opt_len;
        internal int static_len;
        internal int matches;
        internal int last_eob_len;
        internal uint bi_buf;
        internal int bi_valid;
        
        // Methods
        private static Deflate()
        {
            string[] val_1 = new string[10];
            val_1[0] = "need dictionary";
            val_1[1] = "stream end";
            val_1[2] = "";
            val_1[3] = "file error";
            val_1[4] = "stream error";
            val_1[5] = "data error";
            val_1[6] = "insufficient memory";
            val_1[7] = "buffer error";
            val_1[8] = "incompatible version";
            val_1[9] = "";
            Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg = val_1;
            Config[] val_2 = new Config[10];
            Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK = val_2;
            Deflate.Config val_3 = new Deflate.Config();
            .good_length = 0;
            .max_lazy = 0;
            .nice_length = 0;
            .max_chain = 0;
            .func = 0;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_32;
            }
            
            if(val_3 != null)
            {
                goto label_33;
            }
            
            goto label_36;
            label_32:
            if(val_3 == null)
            {
                goto label_36;
            }
            
            label_33:
            Config val_13 = val_2[4];
            label_36:
            mem[1152921543855648400] = val_3;
            Deflate.Config val_4 = new Deflate.Config();
            .func = 1;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 17179869192;
            .max_chain = 4;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_38;
            }
            
            if(val_4 != null)
            {
                goto label_39;
            }
            
            goto label_42;
            label_38:
            if(val_4 == null)
            {
                goto label_42;
            }
            
            label_39:
            Config val_14 = val_2[4];
            label_42:
            mem[1152921543855648408] = val_4;
            Deflate.Config val_5 = new Deflate.Config();
            .func = 1;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 34359738384;
            .max_chain = 8;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_44;
            }
            
            if(val_5 != null)
            {
                goto label_45;
            }
            
            goto label_48;
            label_44:
            if(val_5 == null)
            {
                goto label_48;
            }
            
            label_45:
            Config val_15 = val_2[4];
            label_48:
            mem[1152921543855648416] = val_5;
            Deflate.Config val_6 = new Deflate.Config();
            .func = 1;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 137438953504;
            .max_chain = 32;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_50;
            }
            
            if(val_6 != null)
            {
                goto label_51;
            }
            
            goto label_54;
            label_50:
            if(val_6 == null)
            {
                goto label_54;
            }
            
            label_51:
            Config val_16 = val_2[4];
            label_54:
            mem[1152921543855648424] = val_6;
            Deflate.Config val_7 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 68719476752;
            .max_chain = 16;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_56;
            }
            
            if(val_7 != null)
            {
                goto label_57;
            }
            
            goto label_60;
            label_56:
            if(val_7 == null)
            {
                goto label_60;
            }
            
            label_57:
            Config val_17 = val_2[4];
            label_60:
            val_2[4] = val_7;
            Deflate.Config val_8 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 137438953504;
            .max_chain = 32;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_62;
            }
            
            if(val_8 != null)
            {
                goto label_63;
            }
            
            goto label_66;
            label_62:
            if(val_8 == null)
            {
                goto label_66;
            }
            
            label_63:
            Config val_18 = val_2[4];
            label_66:
            mem[1152921543855648440] = val_8;
            Deflate.Config val_9 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 549755814016;
            .max_chain = 128;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_68;
            }
            
            if(val_9 != null)
            {
                goto label_69;
            }
            
            goto label_72;
            label_68:
            if(val_9 == null)
            {
                goto label_72;
            }
            
            label_69:
            Config val_19 = val_2[4];
            label_72:
            mem[1152921543855648448] = val_9;
            Deflate.Config val_10 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 1099511627904;
            .max_chain = 256;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_74;
            }
            
            if(val_10 != null)
            {
                goto label_75;
            }
            
            goto label_78;
            label_74:
            if(val_10 == null)
            {
                goto label_78;
            }
            
            label_75:
            Config val_20 = val_2[4];
            label_78:
            mem[1152921543855648456] = val_10;
            Deflate.Config val_11 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 4398046511362;
            .max_chain = 1024;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_80;
            }
            
            if(val_11 != null)
            {
                goto label_81;
            }
            
            goto label_84;
            label_80:
            if(val_11 == null)
            {
                goto label_84;
            }
            
            label_81:
            Config val_21 = val_2[4];
            label_84:
            mem[1152921543855648464] = val_11;
            Deflate.Config val_12 = new Deflate.Config();
            .func = 2;
            .good_length = ;
            .max_lazy = ;
            .nice_length = 17592186044674;
            .max_chain = 4096;
            if(Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK == 0)
            {
                goto label_86;
            }
            
            if(val_12 != null)
            {
                goto label_87;
            }
            
            goto label_90;
            label_86:
            if(val_12 == null)
            {
                goto label_90;
            }
            
            label_87:
            Config val_22 = val_2[4];
            label_90:
            mem[1152921543855648472] = val_12;
        }
        internal Deflate()
        {
            this.l_desc = new Org.BouncyCastle.Utilities.Zlib.ZTree();
            this.d_desc = new Org.BouncyCastle.Utilities.Zlib.ZTree();
            this.bl_desc = new Org.BouncyCastle.Utilities.Zlib.ZTree();
            this.bl_count = new short[16];
            this.heap = new int[573];
            this.depth = new byte[573];
            this.dyn_ltree = new short[1146];
            this.dyn_dtree = new short[122];
            this.bl_tree = new short[78];
        }
        internal void lm_init()
        {
            var val_6;
            int val_6 = this.w_size;
            val_6 = val_6 << 1;
            this.window_size = val_6;
            this.head[(long)this.hash_size - 1] = 0;
            int val_7 = this.hash_size;
            val_7 = val_7 - 1;
            if(val_7 >= 1)
            {
                    var val_8 = 0;
                do
            {
                this.head[0] = 0;
                int val_9 = this.hash_size;
                val_8 = val_8 + 1;
                val_9 = val_9 - 1;
            }
            while(val_8 < val_9);
            
            }
            
            val_6 = null;
            val_6 = null;
            int val_2 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            this.max_lazy_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 20;
            int val_3 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            this.good_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 16;
            int val_4 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            this.nice_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 24;
            int val_5 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            this.match_available = 0;
            this.strstart = 0;
            this.lookahead = 0;
            this.prev_length = 2;
            this.block_start = 0;
            this.match_length = 2;
            this.max_chain_length = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 28;
            this.ins_h = 0;
        }
        internal void tr_init()
        {
            var val_1;
            this.l_desc.dyn_tree = this.dyn_ltree;
            val_1 = null;
            val_1 = null;
            this.l_desc.stat_desc = Org.BouncyCastle.Utilities.Zlib.StaticTree.static_l_desc;
            this.d_desc.dyn_tree = this.dyn_dtree;
            this.d_desc.stat_desc = Org.BouncyCastle.Utilities.Zlib.StaticTree.static_d_desc;
            this.bl_desc.dyn_tree = this.bl_tree;
            this.bl_desc.stat_desc = Org.BouncyCastle.Utilities.Zlib.StaticTree.static_bl_desc;
            this.bi_valid = 0;
            mem2[0] = 8;
            this.init_block();
        }
        internal void init_block()
        {
            var val_2 = 16;
            do
            {
                var val_1 = val_2 - 16;
                this.dyn_ltree[0] = 0;
                val_2 = val_2 + 2;
            }
            while(val_2 != 588);
            
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 2;
                this.dyn_dtree[val_3] = 0;
            }
            while(val_3 != 60);
            
            var val_4 = 0;
            do
            {
                val_4 = val_4 + 2;
                this.bl_tree[val_4] = 0;
            }
            while(val_4 != 38);
            
            this.dyn_ltree[512] = 1;
            this.opt_len = 0;
            this.static_len = 0;
            this.matches = 0;
            this.last_lit = 0;
        }
        internal void pqdownheap(short[] tree, int k)
        {
            int val_7;
            var val_8;
            var val_9;
            int val_10;
            val_7 = (long)k;
            int val_5 = this.heap[((long)(int)(k)) << 2];
            val_8 = k << 1;
            if(val_8 > this.heap_len)
            {
                goto label_16;
            }
            
            label_20:
            if(val_8 < this.heap_len)
            {
                    var val_3 = ((Org.BouncyCastle.Utilities.Zlib.Deflate.smaller(tree:  tree, n:  this.heap[((long)(int)(((k << 1) | 1))) << 2], m:  this.heap[((long)(int)((k << 1))) << 2], depth:  this.depth)) != true) ? ((long)val_8 | 1) : (val_8);
            }
            else
            {
                    val_9 = val_8;
            }
            
            val_8 = (long)val_9;
            val_7 = this.heap[((long)(int)((k << 1))) << 2];
            if((Org.BouncyCastle.Utilities.Zlib.Deflate.smaller(tree:  tree, n:  val_5, m:  val_7, depth:  this.depth)) == true)
            {
                goto label_16;
            }
            
            val_7 = this.heap;
            val_10 = this.heap.Length;
            if(val_9 >= val_10)
            {
                    val_10 = this.heap.Length;
            }
            
            val_7[((long)(int)(k)) << 2] = val_7[((long)(int)((k << 1))) << 2];
            val_8 = val_9 << 1;
            if(val_8 <= this.heap_len)
            {
                goto label_20;
            }
            
            goto label_21;
            label_16:
            val_9 = k;
            label_21:
            this.heap[((long)(int)(k)) << 2] = val_5;
        }
        internal static bool smaller(short[] tree, int n, int m, byte[] depth)
        {
            byte val_4;
            int val_5;
            var val_6;
            int val_7;
            val_4 = n;
            val_5 = tree.Length;
            int val_1 = val_4 << 1;
            if(val_1 >= val_5)
            {
                    val_5 = tree.Length;
            }
            
            short val_4 = tree[(long)val_1];
            short val_5 = tree[(long)m << 1];
            if(val_4 < val_5)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            if(val_4 == val_5)
            {
                    val_7 = depth.Length;
                if(val_7 <= val_4)
            {
                    val_7 = depth.Length;
            }
            
                val_4 = depth[(long)val_4];
                var val_3 = (val_4 <= depth[(long)m]) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        internal void scan_tree(short[] tree, int max_code)
        {
            int val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = tree.Length;
            if(val_9 <= 1)
            {
                    val_9 = tree.Length;
            }
            
            short val_11 = tree[1];
            int val_1 = max_code << 1;
            val_1 = val_1 + 3;
            var val_14 = 0;
            tree[(long)val_1] = 65535;
            label_23:
            var val_13 = 0;
            var val_4 = 0 + 3;
            label_6:
            if((val_14 + val_13) > max_code)
            {
                    return;
            }
            
            short val_12 = tree[(long)val_4];
            val_13 = val_13 + 1;
            if(val_13 >= ((val_11 == 0) ? 138 : 7))
            {
                goto label_5;
            }
            
            val_4 = val_4 + 2;
            if(val_11 == val_12)
            {
                goto label_6;
            }
            
            label_5:
            val_14 = val_14 + val_13;
            if(val_13 < ((val_11 != 0) ? (3 + 1) : 3))
            {
                    val_10 = mem[1152921543858161136] + ((tree[1] == 0 ? 138 : 7) << 1);
                val_11 = ((mem[1152921543858161136] + (tree[1] == 0 ? 138 : 7) << 1) + 32) + val_13;
            }
            else
            {
                    if(val_11 != 0)
            {
                    if(val_11 != 0)
            {
                    var val_6 = mem[1152921543858161136] + (((0 + 1)) << 1);
                var val_15 = (mem[1152921543858161136] + ((0 + 1)) << 1) + 32;
                val_15 = val_15 + 1;
                mem2[0] = val_15;
            }
            
                val_10 = mem[1152921543858161136];
                val_12 = mem[mem[1152921543858161136] + 96];
                val_12 = mem[1152921543858161136] + 96;
            }
            else
            {
                    val_10 = mem[1152921543858161136];
                if((val_13 - 1) > 9)
            {
                    val_12 = mem[mem[1152921543858161136] + 104];
                val_12 = mem[1152921543858161136] + 104;
            }
            else
            {
                    val_12 = mem[mem[1152921543858161136] + 100];
                val_12 = mem[1152921543858161136] + 100;
            }
            
            }
            
                val_11 = val_12 + 1;
            }
            
            mem2[0] = val_11;
            var val_9 = (val_11 != val_12) ? (3 + 1) : 3;
            var val_10 = (val_12 == 0) ? 138 : ((val_11 != val_12) ? (6 + 1) : 6);
            goto label_23;
        }
        internal int build_bl_tree()
        {
            var val_1;
            var val_2;
            this.scan_tree(tree:  this.dyn_ltree, max_code:  this.l_desc.max_code);
            this.scan_tree(tree:  this.dyn_dtree, max_code:  this.d_desc.max_code);
            this.bl_desc.build_tree(s:  this);
            val_1 = 50;
            label_11:
            val_2 = null;
            val_2 = null;
            if(this.bl_tree[1] != 0)
            {
                goto label_10;
            }
            
            val_1 = 50 - 1;
            if((50 - 32) > 3)
            {
                goto label_11;
            }
            
            label_10:
            int val_5 = this.opt_len;
            var val_2 = val_1 - 32;
            val_5 = (val_2 + (val_2 << 1)) + val_5;
            val_5 = val_5 + 17;
            this.opt_len = val_5;
            return (int)val_2;
        }
        internal void send_all_trees(int lcodes, int dcodes, int blcodes)
        {
            var val_3;
            var val_4;
            int val_3 = dcodes;
            lcodes = lcodes - 257;
            this.send_bits(val:  lcodes, length:  5);
            val_3 = val_3 - 1;
            this.send_bits(val:  val_3, length:  5);
            this.send_bits(val:  blcodes - 4, length:  4);
            if(blcodes >= 1)
            {
                    do
            {
                val_4 = null;
                val_4 = null;
                this.send_bits(val:  this.bl_tree[1], length:  3);
                val_3 = 0 + 1;
            }
            while(blcodes != val_3);
            
            }
            
            this.send_tree(tree:  this.dyn_ltree, max_code:  lcodes - 1);
            this.send_tree(tree:  this.dyn_dtree, max_code:  val_3);
        }
        internal void send_tree(short[] tree, int max_code)
        {
            var val_6;
            var val_7;
            int val_8;
            short val_13 = tree[1];
            var val_16 = 0;
            label_12:
            var val_15 = 10;
            var val_3 = 0 + 3;
            label_6:
            var val_4 = val_16 + val_15;
            val_4 = val_4 + 11;
            var val_17 = 0;
            if(val_4 > max_code)
            {
                    return;
            }
            
            short val_14 = tree[(long)val_3];
            val_15 = val_15 + 1;
            if((val_15 + 12) >= ((val_13 == 0) ? 138 : 7))
            {
                goto label_5;
            }
            
            val_3 = val_3 + 2;
            var val_6 = val_17 - 1;
            if(val_13 == val_14)
            {
                goto label_6;
            }
            
            label_5:
            val_6 = val_15 + 11;
            val_16 = (val_16 + val_15) + 11;
            if(val_6 >= ((val_13 != 0) ? (3 + 1) : 3))
            {
                goto label_7;
            }
            
            do
            {
                this.send_code(c:  val_13, tree:  this.bl_tree);
                val_17 = val_17 + 1;
            }
            while(val_17 != 0);
            
            goto label_9;
            label_7:
            var val_8 = val_15 + 10;
            if(val_13 == 0)
            {
                goto label_10;
            }
            
            if(val_13 != 0)
            {
                    this.send_code(c:  val_13, tree:  this.bl_tree);
                val_6 = val_8;
            }
            
            this.send_code(c:  16, tree:  this.bl_tree);
            this.send_bits(val:  val_6 - 3, length:  2);
            label_9:
            label_15:
            var val_11 = (val_13 != val_14) ? (3 + 1) : 3;
            var val_12 = (val_14 == 0) ? 138 : ((val_13 != val_14) ? (6 + 1) : 6);
            goto label_12;
            label_10:
            if(val_8 > 9)
            {
                    this.send_code(c:  18, tree:  this.bl_tree);
                val_7 = 7;
                val_8 = val_15;
            }
            else
            {
                    this.send_code(c:  17, tree:  this.bl_tree);
                val_8 = val_15 + 8;
                val_7 = 3;
            }
            
            this.send_bits(val:  val_8, length:  3);
            goto label_15;
        }
        internal void put_byte(byte[] p, int start, int len)
        {
            System.Array.Copy(sourceArray:  p, sourceIndex:  start, destinationArray:  this.pending_buf, destinationIndex:  this.pending, length:  len);
            int val_1 = this.pending;
            val_1 = val_1 + len;
            this.pending = val_1;
        }
        internal void put_byte(byte c)
        {
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = c;
        }
        internal void put_short(int w)
        {
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = w;
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = w >> 8;
        }
        internal void putShortMSB(int b)
        {
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = b >> 8;
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = b;
        }
        internal void send_code(int c, short[] tree)
        {
            int val_3;
            int val_1 = c << 1;
            val_3 = tree.Length;
            if(val_1 >= val_3)
            {
                    val_3 = tree.Length;
            }
            
            this.send_bits(val:  tree[(long)val_1], length:  tree[(long)val_1 | 1]);
        }
        internal void send_bits(int val, int length)
        {
            int val_6;
            var val_6 = 16;
            int val_1 = this.bi_valid & 31;
            val_6 = val_6 - length;
            val_1 = val << val_1;
            int val_2 = val_1 | this.bi_buf;
            this.bi_buf = val_2;
            if(this.bi_valid > val_6)
            {
                    this.pending = this.pending + 1;
                this.pending_buf[this.pending] = val_2;
                this.pending = this.pending + 1;
                this.pending_buf[this.pending] = this.bi_buf >> 8;
                int val_8 = this.bi_valid;
                uint val_7 = 16;
                val_7 = val_7 - val_8;
                val_7 = val_7 & 31;
                val_8 = length + val_8;
                val_7 = val >> val_7;
                this.bi_buf = val_7;
                val_6 = val_8 - 16;
            }
            else
            {
                    val_6 = this.bi_valid + length;
            }
            
            this.bi_valid = val_6;
        }
        internal void _tr_align()
        {
            var val_1;
            var val_2;
            this.send_bits(val:  2, length:  3);
            val_1 = null;
            val_1 = null;
            this.send_code(c:  256, tree:  Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree);
            this.bi_flush();
            int val_1 = this.last_eob_len;
            val_1 = val_1 + 11;
            val_1 = val_1 - this.bi_valid;
            if(val_1 <= 8)
            {
                    this.send_bits(val:  2, length:  3);
                val_2 = null;
                val_2 = null;
                this.send_code(c:  256, tree:  Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree);
                this.bi_flush();
            }
            
            this.last_eob_len = 7;
        }
        internal bool _tr_tally(int dist, int lc)
        {
            var val_16;
            var val_17;
            System.Int16[] val_18;
            int val_19;
            var val_20;
            var val_21;
            this.pending_buf[(long)this.d_buf + (this.last_lit << 1)] = dist >> 8;
            int val_3 = this.d_buf + (this.last_lit << 1);
            val_3 = val_3 + 1;
            this.pending_buf[(long)val_3] = dist;
            this.pending_buf[(long)this.last_lit + this.l_buf] = lc;
            int val_16 = this.last_lit;
            val_16 = val_16 + 1;
            this.last_lit = val_16;
            if(dist == 0)
            {
                goto label_7;
            }
            
            int val_17 = this.matches;
            val_17 = val_17 + 1;
            this.matches = val_17;
            val_16 = null;
            val_16 = null;
            System.Byte[] val_5 = Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + (long)lc;
            val_17 = mem[(Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + (long)(int)(lc)) + 32];
            val_17 = (Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + (long)(int)(lc)) + 32;
            short val_18 = this.dyn_ltree[514];
            val_18 = val_18 + 1;
            this.dyn_ltree[514] = val_18;
            val_18 = this.dyn_dtree;
            if(val_18 != null)
            {
                goto label_28;
            }
            
            label_29:
            label_28:
            short val_19 = val_18[(long)(Org.BouncyCastle.Utilities.Zlib.ZTree.d_code(dist:  dist - 1)) << 1];
            val_19 = val_19 + 1;
            val_18[(long)(Org.BouncyCastle.Utilities.Zlib.ZTree.d_code(dist:  dist - 1)) << 1] = val_19;
            val_19 = this.last_lit;
            if(((val_19 & 8191) == 0) && (this.level >= 3))
            {
                    var val_21 = 0;
                do
            {
                val_20 = null;
                val_20 = null;
                var val_22 = Org.BouncyCastle.Utilities.Zlib.ZTree.extra_dbits.Length + 32;
                val_21 = val_21 + 1;
                val_17 = 0 + 2;
                val_22 = val_22 + 5;
                val_18 = (val_19 << 3) + (val_22 * this.dyn_dtree[0]);
            }
            while(val_21 != 30);
            
                val_19 = this.last_lit;
                if(this.matches < (((val_19 < 0) ? (val_19 + 1) : (val_19)) >> 1))
            {
                    int val_12 = this.strstart - this.block_start;
                if((val_18 >> 3) < (((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1))
            {
                    val_21 = 1;
                return (bool)(val_19 == val_23) ? 1 : 0;
            }
            
            }
            
            }
            
            int val_23 = this.lit_bufsize;
            val_23 = val_23 - 1;
            return (bool)(val_19 == val_23) ? 1 : 0;
            label_7:
            if(this.dyn_ltree != null)
            {
                goto label_28;
            }
            
            goto label_29;
        }
        internal void compress_block(short[] ltree, short[] dtree)
        {
            System.Int32[] val_15;
            System.Byte[] val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this.last_lit == 0)
            {
                goto label_1;
            }
            
            var val_18 = 0;
            var val_19 = 1;
            label_30:
            int val_1 = val_19 + this.d_buf;
            val_1 = val_1 - 1;
            byte val_15 = this.pending_buf[(long)val_1];
            byte val_16 = this.pending_buf[(long)val_19 + this.d_buf];
            val_16 = this.pending_buf;
            val_15 = (long)val_18 + this.l_buf;
            byte val_17 = val_16[val_15];
            val_18 = val_18 + 1;
            if(val_16 == 0)
            {
                goto label_8;
            }
            
            val_17 = null;
            val_17 = null;
            System.Byte[] val_4 = Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + val_17;
            this.send_code(c:  (((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) | 256) + 1, tree:  ltree);
            int val_7 = Org.BouncyCastle.Utilities.Zlib.ZTree.DIST_CODE_LEN + (((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) << 2);
            if(((Org.BouncyCastle.Utilities.Zlib.ZTree.DIST_CODE_LEN + ((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) << 2) + 32) != 0)
            {
                    val_18 = null;
                val_18 = null;
                val_15 = Org.BouncyCastle.Utilities.Zlib.ZTree.base_length;
                System.Int32[] val_8 = val_15 + (((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) << 2);
                this.send_bits(val:  val_17 - ((Org.BouncyCastle.Utilities.Zlib.ZTree.base_length + ((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) << 2) + 32), length:  (Org.BouncyCastle.Utilities.Zlib.ZTree.DIST_CODE_LEN + ((Org.BouncyCastle.Utilities.Zlib.ZTree._length_code + this.pending_buf[(long)(int)((0 + this.l_buf))][0]) + 32) << 2) + 32);
            }
            
            byte val_10 = val_16 - 1;
            val_16 = Org.BouncyCastle.Utilities.Zlib.ZTree.d_code(dist:  val_10);
            this.send_code(c:  val_16, tree:  dtree);
            System.Int32[] val_12 = Org.BouncyCastle.Utilities.Zlib.ZTree.extra_dbits + (((long)(int)(val_11)) << 2);
            if(((Org.BouncyCastle.Utilities.Zlib.ZTree.extra_dbits + ((long)(int)(val_11)) << 2) + 32) == 0)
            {
                goto label_29;
            }
            
            val_19 = null;
            val_19 = null;
            val_15 = Org.BouncyCastle.Utilities.Zlib.ZTree.base_dist;
            System.Int32[] val_13 = val_15 + (((long)(int)(val_11)) << 2);
            this.send_bits(val:  val_10 - ((Org.BouncyCastle.Utilities.Zlib.ZTree.base_dist + ((long)(int)(val_11)) << 2) + 32), length:  (Org.BouncyCastle.Utilities.Zlib.ZTree.extra_dbits + ((long)(int)(val_11)) << 2) + 32);
            goto label_29;
            label_8:
            this.send_code(c:  val_17, tree:  ltree);
            label_29:
            val_19 = val_19 + 2;
            if(val_18 < this.last_lit)
            {
                goto label_30;
            }
            
            label_1:
            this.send_code(c:  256, tree:  ltree);
            this.last_eob_len = ltree[513];
        }
        internal void set_data_type()
        {
            var val_5 = 0;
            var val_6 = 0;
            do
            {
                val_5 = val_5 + 2;
                val_6 = val_6 + this.dyn_ltree[val_5];
            }
            while(val_5 != 14);
            
            var val_9 = 0;
            var val_8 = 30;
            do
            {
                var val_1 = val_8 - 16;
                val_8 = val_8 + 2;
                val_9 = val_9 + this.dyn_ltree[14];
            }
            while(val_8 != 272);
            
            val_9 = val_9 >> 2;
            do
            {
                var val_2 = val_8 - 16;
                val_8 = val_8 + 2;
                val_6 = val_6 + 1152921506176191536;
            }
            while(val_8 != 528);
            
            this.data_type = (val_6 <= val_9) ? 1 : 0;
        }
        internal void bi_flush()
        {
            System.Byte[] val_6;
            int val_7;
            if(this.bi_valid == 16)
            {
                    this.pending = this.pending + 1;
                this.pending_buf[this.pending] = this.bi_buf;
                val_6 = this.pending_buf;
                this.pending = this.pending + 1;
                val_7 = 0;
                val_6[this.pending] = this.bi_buf >> 8;
                this.bi_buf = 0;
            }
            else
            {
                    if(this.bi_valid < 8)
            {
                    return;
            }
            
                val_6 = this.pending_buf;
                this.pending = this.pending + 1;
                val_6[this.pending] = this.bi_buf;
                this.bi_buf = (uint)(this.bi_buf >> 8) & 255;
                val_7 = this.bi_valid - 8;
            }
            
            this.bi_valid = val_7;
        }
        internal void bi_windup()
        {
            int val_4;
            System.Byte[] val_5;
            uint val_6;
            if(this.bi_valid >= 9)
            {
                goto label_0;
            }
            
            if(this.bi_valid < 1)
            {
                goto label_1;
            }
            
            val_4 = this.pending;
            val_5 = this.pending_buf;
            val_6 = this.bi_buf;
            this.pending = val_4 + 1;
            if(val_4 >= this.pending_buf.Length)
            {
                goto label_3;
            }
            
            goto label_8;
            label_0:
            this.pending = this.pending + 1;
            this.pending_buf[this.pending] = this.bi_buf;
            val_4 = this.pending;
            val_5 = this.pending_buf;
            this.pending = val_4 + 1;
            val_6 = this.bi_buf >> 8;
            if(val_4 < this.pending_buf.Length)
            {
                goto label_8;
            }
            
            label_3:
            label_8:
            val_5[val_4] = val_6;
            label_1:
            this.bi_buf = 0;
            this.bi_valid = 0;
        }
        internal void copy_block(int buf, int len, bool header)
        {
            this.bi_windup();
            this.last_eob_len = 8;
            if(header != false)
            {
                    this.put_short(w:  (int)len & 65535);
                this.put_short(w:  ((len << 16) ^ 4294901760) >> 16);
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  buf, destinationArray:  this.pending_buf, destinationIndex:  this.pending, length:  len);
            int val_4 = this.pending;
            val_4 = val_4 + len;
            this.pending = val_4;
        }
        internal void flush_block_only(bool eof)
        {
            this._tr_flush_block(buf:  (this.block_start >= 0) ? this.block_start : (!0), stored_len:  this.strstart - this.block_start, eof:  eof);
            this.block_start = this.strstart;
            this.strm.flush_pending();
        }
        internal int deflate_stored(int flush)
        {
            int val_8;
            int val_9;
            int val_10;
            var val_11;
            int val_8 = this.pending_buf_size;
            val_8 = val_8 - 5;
            label_8:
            val_8 = this.lookahead;
            if(val_8 > 1)
            {
                goto label_0;
            }
            
            this.fill_window();
            val_8 = this.lookahead;
            if(val_8 == 0)
            {
                goto label_1;
            }
            
            label_0:
            val_9 = this.block_start;
            this.lookahead = 0;
            val_10 = val_8 + this.strstart;
            int val_2 = val_9 + ((val_8 < 65535) ? (val_8) : 65535);
            this.strstart = val_10;
            if(val_10 != 0)
            {
                    if(val_10 < val_2)
            {
                goto label_3;
            }
            
            }
            
            val_10 = val_10 - val_2;
            this.lookahead = val_10;
            this.strstart = val_2;
            this.flush_block_only(eof:  false);
            if(this.strm.avail_out == 0)
            {
                goto label_10;
            }
            
            val_10 = this.strstart;
            val_9 = this.block_start;
            label_3:
            val_10 = val_10 - val_9;
            if(val_10 < (this.w_size - 262))
            {
                goto label_8;
            }
            
            this.flush_block_only(eof:  false);
            if(this.strm.avail_out != 0)
            {
                goto label_8;
            }
            
            goto label_10;
            label_1:
            if(flush == 0)
            {
                goto label_10;
            }
            
            this.flush_block_only(eof:  (flush == 4) ? 1 : 0);
            if(this.strm.avail_out == 0)
            {
                goto label_12;
            }
            
            var val_5 = (flush == 4) ? 3 : (0 + 1);
            return (int)val_11;
            label_10:
            val_11 = 0;
            return (int)val_11;
            label_12:
            var val_7 = ((flush == 4) ? 1 : 0) << 1;
            return (int)val_11;
        }
        internal void _tr_stored_block(int buf, int stored_len, bool eof)
        {
            this.send_bits(val:  eof, length:  3);
            this.copy_block(buf:  buf, len:  stored_len, header:  true);
        }
        internal void _tr_flush_block(int buf, int stored_len, bool eof)
        {
            int val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Int16[] val_18;
            System.Int16[] val_19;
            val_13 = stored_len;
            if(this.level >= 1)
            {
                    if(this.data_type == 2)
            {
                    this.set_data_type();
            }
            
                this.l_desc.build_tree(s:  this);
                this.d_desc.build_tree(s:  this);
                val_14 = this.build_bl_tree() + 1;
                int val_2 = this.opt_len + 10;
                val_15 = (this.static_len + 10) >> 3;
                var val_5 = (val_15 > (val_2 >> 3)) ? (val_2 >> 3) : (val_15);
            }
            else
            {
                    val_15 = val_13 + 5;
                val_14 = 1;
                val_16 = val_15;
            }
            
            if((buf != 1) && ((val_13 + 4) <= val_16))
            {
                    eof = eof;
                this._tr_stored_block(buf:  buf, stored_len:  val_13, eof:  eof);
            }
            else
            {
                    if(val_15 == val_16)
            {
                    this.send_bits(val:  (eof != true) ? (2 + 1) : 2, length:  3);
                val_13 = 1152921505510252544;
                val_17 = null;
                val_17 = null;
                val_18 = Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree;
                val_19 = Org.BouncyCastle.Utilities.Zlib.StaticTree.static_dtree;
            }
            else
            {
                    this.send_bits(val:  (eof != true) ? (4 + 1) : 4, length:  3);
                val_13 = this.l_desc.max_code;
                this.send_all_trees(lcodes:  val_13 + 1, dcodes:  this.d_desc.max_code + 1, blcodes:  1);
                val_18 = this.dyn_ltree;
                val_19 = this.dyn_dtree;
            }
            
                this.compress_block(ltree:  val_18, dtree:  val_19);
            }
            
            this.init_block();
            if(eof == false)
            {
                    return;
            }
            
            this.bi_windup();
        }
        internal void fill_window()
        {
            int val_11;
            System.Int16[] val_12;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_13;
            label_26:
            int val_10 = this.window_size;
            int val_11 = this.lookahead;
            val_10 = val_10 - val_11;
            val_11 = val_10 - this.strstart;
            if(val_11 == 1)
            {
                goto label_0;
            }
            
            if(val_11 != 0)
            {
                goto label_1;
            }
            
            val_11 = this.strstart | val_11;
            if(val_11 == 0)
            {
                goto label_2;
            }
            
            label_1:
            int val_1 = this.w_size << 1;
            val_1 = val_1 - 262;
            if(this.strstart < val_1)
            {
                goto label_15;
            }
            
            System.Array.Copy(sourceArray:  this.window, sourceIndex:  this.w_size, destinationArray:  this.window, destinationIndex:  0, length:  this.w_size);
            int val_13 = this.strstart;
            int val_12 = this.match_start;
            int val_14 = this.w_size;
            val_12 = val_12 - val_14;
            val_13 = val_13 - val_14;
            val_14 = this.block_start - val_14;
            int val_2 = this.hash_size - 1;
            this.strstart = val_13;
            this.match_start = val_12;
            this.block_start = val_14;
            do
            {
                short val_15 = this.head[(long)val_2];
                val_15 = (this.w_size > val_15) ? 0 : (val_15 - this.w_size);
                val_2 = val_2 - 1;
                this.head[(long)val_2] = val_15;
            }
            while(val_2 != 1);
            
            int val_4 = this.w_size - 1;
            do
            {
                short val_16 = this.prev[(long)val_4];
                val_12 = this.prev;
                val_16 = (this.w_size > val_16) ? 0 : (val_16 - this.w_size);
                val_4 = val_4 - 1;
                val_12[(long)val_4] = val_16;
            }
            while(val_4 != 1);
            
            val_11 = this.w_size + val_11;
            goto label_15;
            label_0:
            val_11 = -2;
            goto label_15;
            label_2:
            val_11 = this.w_size;
            label_15:
            val_13 = this.strm;
            if(this.strm.avail_in == 0)
            {
                    return;
            }
            
            val_13 = this.strm;
            val_12 = this.strstart;
            int val_17 = this.lookahead;
            val_17 = val_17 + (val_13.read_buf(buf:  this.window, start:  this.lookahead + val_12, size:  val_11));
            this.lookahead = val_17;
            if(val_17 >= 3)
            {
                    val_13 = this.hash_shift;
                byte val_18 = this.window[this.strstart];
                this.ins_h = val_18;
                val_12 = (long)this.strstart + 1;
                byte val_19 = this.window[val_12];
                int val_9 = val_13 & 31;
                val_9 = val_18 << val_9;
                val_19 = val_9 ^ val_19;
                val_19 = val_19 & this.hash_mask;
                this.ins_h = val_19;
                if(this.lookahead > 261)
            {
                    return;
            }
            
            }
            
            if(this.strm.avail_in != 0)
            {
                goto label_26;
            }
        
        }
        internal int deflate_fast(int flush)
        {
            short val_20;
            int val_21;
            short val_22;
            var val_23;
            int val_24;
            var val_25;
            val_20 = 0;
            goto label_23;
            label_19:
            val_21 = this;
            this.match_length = this.longest_match(cur_match:  0);
            goto label_1;
            label_23:
            if(this.lookahead > 261)
            {
                goto label_3;
            }
            
            this.fill_window();
            if(this.lookahead > 261)
            {
                goto label_3;
            }
            
            if(flush == 0)
            {
                goto label_4;
            }
            
            if(this.lookahead == 0)
            {
                goto label_5;
            }
            
            if(this.lookahead < 3)
            {
                goto label_6;
            }
            
            label_3:
            int val_19 = this.ins_h;
            byte val_18 = this.window[(long)this.strstart + 2];
            int val_3 = this.hash_shift & 31;
            val_3 = val_19 << val_3;
            val_18 = val_3 ^ val_18;
            val_19 = val_18 & this.hash_mask;
            this.ins_h = val_19;
            val_20 = this.head[(long)val_19];
            val_22 = this.head[this.ins_h];
            val_23 = this.w_mask & this.strstart;
            this.prev[(long)val_23] = val_22;
            this.head[this.ins_h] = this.strstart;
            label_6:
            if(val_20 != 0)
            {
                    int val_20 = this.strstart;
                val_20 = val_20 - val_20;
                val_20 = val_20 & 65535;
                val_23 = this.w_size - 262;
                if(val_20 <= val_23)
            {
                    if(this.strategy != 2)
            {
                goto label_19;
            }
            
            }
            
            }
            
            val_21 = this.match_length;
            label_1:
            if(this.strategy >= 2)
            {
                goto label_20;
            }
            
            val_24 = this.strstart;
            int val_22 = this.lookahead;
            int val_23 = this.strstart;
            val_22 = val_22 - 1;
            val_23 = val_23 + 1;
            this.lookahead = val_22;
            this.strstart = val_23;
            if((this._tr_tally(dist:  0, lc:  this.window[val_24])) == false)
            {
                goto label_23;
            }
            
            goto label_39;
            label_20:
            bool val_7 = this._tr_tally(dist:  this.strstart - this.match_start, lc:  val_21 - 3);
            int val_24 = this.lookahead;
            int val_25 = this.match_length;
            val_24 = val_24 - val_25;
            this.lookahead = val_24;
            if((val_24 >= 3) && (val_25 <= this.max_lazy_match))
            {
                    val_25 = val_25 - 1;
                this.match_length = val_25;
                do
            {
                int val_27 = this.ins_h;
                this.strstart = this.strstart + 1;
                byte val_26 = this.window[(long)this.strstart + 3];
                int val_10 = this.hash_shift & 31;
                val_10 = val_27 << val_10;
                val_26 = val_10 ^ val_26;
                val_27 = val_26 & this.hash_mask;
                this.ins_h = val_27;
                val_20 = this.head[(long)val_27];
                this.prev[(long)this.w_mask & this.strstart] = this.head[this.ins_h];
                val_24 = this.head;
                val_22 = this.strstart;
                val_24[this.ins_h] = val_22;
                int val_29 = this.match_length;
                val_29 = val_29 - 1;
                this.match_length = val_29;
            }
            while(val_29 != 0);
            
                int val_30 = this.strstart;
                val_30 = val_30 + 1;
                this.strstart = val_30;
                if(val_7 == false)
            {
                goto label_23;
            }
            
            }
            else
            {
                    this.match_length = 0;
                int val_12 = val_25 + this.strstart;
                this.strstart = val_12;
                val_24 = this.window[(long)val_12];
                val_22 = this.window;
                this.ins_h = val_24;
                byte val_31 = val_22[(long)this.strstart + 1];
                int val_14 = this.hash_shift & 31;
                val_14 = val_24 << val_14;
                val_31 = val_14 ^ val_31;
                val_31 = val_31 & this.hash_mask;
                this.ins_h = val_31;
                if(val_7 == false)
            {
                goto label_23;
            }
            
            }
            
            label_39:
            this.flush_block_only(eof:  false);
            if(this.strm.avail_out != 0)
            {
                goto label_23;
            }
            
            label_4:
            val_25 = 0;
            return (int)val_25;
            label_5:
            this.flush_block_only(eof:  (flush == 4) ? 1 : 0);
            if(this.strm.avail_out != 0)
            {
                    var val_16 = (flush == 4) ? 3 : (0 + 1);
                return (int)val_25;
            }
            
            val_25 = ((flush == 4) ? 1 : 0) << 1;
            return (int)val_25;
        }
        internal int deflate_slow(int flush)
        {
            short val_25;
            int val_26;
            int val_27;
            int val_28;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_29;
            int val_30;
            int val_31;
            int val_32;
            var val_33;
            val_25 = 0;
            goto label_51;
            label_45:
            int val_22 = this.strstart;
            int val_21 = this.lookahead;
            val_21 = val_22 + val_21;
            val_22 = val_22 - 1;
            val_26 = val_21 - 3;
            int val_23 = this.prev_length;
            val_27 = val_23 - 2;
            val_23 = (this.lookahead + 1) - val_23;
            this.lookahead = val_23;
            this.prev_length = val_27;
            do
            {
                int val_4 = this.strstart + 1;
                this.strstart = val_4;
                if(val_4 <= val_26)
            {
                    int val_25 = this.ins_h;
                byte val_24 = this.window[(long)this.strstart + 3];
                int val_6 = this.hash_shift & 31;
                val_6 = val_25 << val_6;
                val_24 = val_6 ^ val_24;
                val_25 = val_24 & this.hash_mask;
                this.ins_h = val_25;
                val_28 = this.strstart;
                val_25 = this.head[(long)val_25];
                this.prev[(long)this.w_mask & val_28] = this.head[this.ins_h];
                this.head[this.ins_h] = this.strstart;
                val_27 = this.prev_length;
            }
            
                val_27 = val_27 - 1;
                this.prev_length = val_27;
            }
            while(val_27 != 0);
            
            int val_27 = this.strstart;
            this.match_length = 2;
            val_27 = val_27 + 1;
            this.match_available = 0;
            this.strstart = val_27;
            if((this._tr_tally(dist:  val_22 - this.prev_match, lc:  0)) == false)
            {
                goto label_51;
            }
            
            this.flush_block_only(eof:  false);
            val_29 = this.strm;
            if(val_29 != null)
            {
                goto label_50;
            }
            
            goto label_15;
            label_51:
            val_30 = this.lookahead;
            goto label_17;
            label_46:
            val_30 = this.lookahead - 1;
            this.match_available = 1;
            this.strstart = this.strstart + 1;
            this.lookahead = val_30;
            goto label_17;
            label_42:
            val_31 = this;
            int val_9 = this.longest_match(cur_match:  0);
            this.match_length = val_9;
            if(val_9 > 5)
            {
                goto label_39;
            }
            
            if(this.strategy != 1)
            {
                goto label_19;
            }
            
            label_22:
            val_31 = 2;
            this.match_length = val_31;
            goto label_39;
            label_19:
            if(val_9 != 3)
            {
                goto label_39;
            }
            
            int val_28 = this.strstart;
            val_28 = val_28 - this.match_start;
            if(val_28 > 4096)
            {
                goto label_22;
            }
            
            val_31 = 3;
            goto label_39;
            label_17:
            if(val_30 > 261)
            {
                goto label_25;
            }
            
            this.fill_window();
            if(this.lookahead > 261)
            {
                goto label_25;
            }
            
            if(flush == 0)
            {
                goto label_26;
            }
            
            if(this.lookahead == 0)
            {
                goto label_27;
            }
            
            if(this.lookahead < 3)
            {
                goto label_28;
            }
            
            label_25:
            int val_30 = this.ins_h;
            byte val_29 = this.window[(long)this.strstart + 2];
            int val_11 = this.hash_shift & 31;
            val_11 = val_30 << val_11;
            val_29 = val_11 ^ val_29;
            val_30 = val_29 & this.hash_mask;
            this.ins_h = val_30;
            val_28 = this.head;
            val_25 = this.head[(long)val_30];
            this.prev[(long)this.w_mask & this.strstart] = val_28[this.ins_h];
            val_26 = this.strstart;
            this.head[this.ins_h] = val_26;
            label_28:
            val_32 = this.match_length;
            val_31 = 2;
            this.prev_length = val_32;
            this.match_length = val_31;
            this.prev_match = this.match_start;
            if(val_25 == 0)
            {
                goto label_39;
            }
            
            if(val_32 >= this.max_lazy_match)
            {
                goto label_40;
            }
            
            int val_32 = this.strstart;
            int val_33 = this.w_size;
            val_32 = val_32 - val_25;
            val_32 = val_32 & 65535;
            val_33 = val_33 - 262;
            if(val_32 <= val_33)
            {
                    if(this.strategy != 2)
            {
                goto label_42;
            }
            
            }
            
            val_31 = 2;
            label_39:
            val_32 = this.prev_length;
            goto label_43;
            label_40:
            val_31 = 2;
            label_43:
            int val_13 = val_32 - 3;
            if(val_32 >= this.max_lazy_match)
            {
                    if(val_31 <= val_32)
            {
                goto label_45;
            }
            
            }
            
            if(this.match_available == 0)
            {
                goto label_46;
            }
            
            if((this._tr_tally(dist:  0, lc:  this.window[(long)this.strstart - 1])) != false)
            {
                    this.flush_block_only(eof:  false);
            }
            
            int val_35 = this.strstart;
            int val_36 = this.lookahead;
            val_29 = this.strm;
            val_35 = val_35 + 1;
            val_36 = val_36 - 1;
            this.strstart = val_35;
            this.lookahead = val_36;
            if(val_29 != null)
            {
                goto label_50;
            }
            
            label_15:
            label_50:
            if(this.strm.avail_out != 0)
            {
                goto label_51;
            }
            
            label_26:
            val_33 = 0;
            return (int)val_33;
            label_27:
            if(this.match_available != 0)
            {
                    val_25 = this.window;
                bool val_17 = this._tr_tally(dist:  0, lc:  val_25[(long)this.strstart - 1]);
                this.match_available = 0;
            }
            
            this.flush_block_only(eof:  (flush == 4) ? 1 : 0);
            if(this.strm.avail_out != 0)
            {
                    var val_19 = (flush == 4) ? 3 : (0 + 1);
                return (int)val_33;
            }
            
            val_33 = ((flush == 4) ? 1 : 0) << 1;
            return (int)val_33;
        }
        internal int longest_match(int cur_match)
        {
            int val_56;
            int val_57;
            var val_58;
            int val_59;
            System.Byte[] val_60;
            var val_61;
            var val_62;
            int val_49 = this.w_size;
            val_56 = this.prev_length;
            val_57 = this.max_chain_length;
            val_49 = val_49 - 262;
            val_49 = this.strstart - val_49;
            var val_1 = () ? (val_49) : 0;
            int val_2 = val_56 + this.strstart;
            val_58 = val_1;
            int val_4 = this.strstart + 258;
            var val_7 = (this.prev_length < this.good_match) ? (val_57) : (val_57 >> 2);
            val_59 = this.w_mask;
            label_77:
            val_60 = this.window;
            if((val_60[(long)cur_match + val_56]) != this.window[(long)val_2])
            {
                goto label_68;
            }
            
            val_60 = this.window;
            if((val_60[(long)((long)cur_match + val_56) - 1]) != (this.window[(long)val_2 - 1]))
            {
                goto label_68;
            }
            
            val_60 = this.window;
            if(this.window[(long)cur_match] != val_60[this.strstart])
            {
                goto label_68;
            }
            
            val_60 = this.window;
            if((this.window[(long)cur_match + 1]) != (val_60[(long)this.strstart + 1]))
            {
                goto label_68;
            }
            
            int val_74 = this.strstart + 2;
            var val_72 = 0;
            label_60:
            val_60 = this.window;
            val_56 = val_56;
            val_61 = (long)(cur_match + val_72) + 3;
            if((this.window[(long)(this.strstart + val_72) + 3]) != val_60[val_61])
            {
                goto label_24;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 4;
            if((this.window[(long)(this.strstart + val_72) + 4]) != val_60[val_61])
            {
                goto label_29;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 5;
            if((this.window[(long)(this.strstart + val_72) + 5]) != val_60[val_61])
            {
                goto label_34;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 6;
            if((this.window[(long)(this.strstart + val_72) + 6]) != val_60[val_61])
            {
                goto label_39;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 7;
            if((this.window[(long)(this.strstart + val_72) + 7]) != val_60[val_61])
            {
                goto label_44;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 8;
            if((this.window[(long)(this.strstart + val_72) + 8]) != val_60[val_61])
            {
                goto label_49;
            }
            
            val_60 = this.window;
            val_61 = (long)(cur_match + val_72) + 9;
            if((this.window[(long)(this.strstart + val_72) + 9]) != val_60[val_61])
            {
                goto label_54;
            }
            
            int val_42 = (this.strstart + val_72) + 10;
            val_60 = this.window[(long)val_42];
            val_72 = val_72 + 8;
            if(val_42 >= val_4)
            {
                goto label_59;
            }
            
            val_74 = val_74 + 8;
            if(val_60 == (this.window[(long)(cur_match + val_72) + 10]))
            {
                goto label_60;
            }
            
            label_59:
            val_59 = this.w_mask;
            val_58 = val_1;
            val_56 = val_56;
            val_62 = (this.strstart + val_72) + 2;
            goto label_61;
            label_24:
            val_62 = val_74 + 1;
            goto label_67;
            label_29:
            val_62 = val_74 + 2;
            goto label_67;
            label_34:
            val_62 = val_74 + 3;
            goto label_67;
            label_39:
            val_62 = val_74 + 4;
            goto label_67;
            label_44:
            val_62 = val_74 + 5;
            goto label_67;
            label_49:
            val_62 = val_74 + 6;
            goto label_67;
            label_54:
            val_62 = val_74 + 7;
            label_67:
            val_59 = this.w_mask;
            val_58 = val_1;
            label_61:
            int val_75 = val_4;
            val_62 = val_62 - val_75;
            val_57 = val_62 + 258;
            if(val_57 > val_56)
            {
                    this.match_start = cur_match;
                if(val_57 >= ((this.nice_match > this.lookahead) ? this.lookahead : this.nice_match))
            {
                    return (int)(val_56 > this.lookahead) ? this.lookahead : (val_56);
            }
            
                int val_46 = val_57 + this.strstart;
                val_75 = val_46 - 1;
                val_60 = this.window;
                byte val_76 = this.window[(long)val_75];
                val_58 = val_1;
                byte val_77 = val_60[(long)val_46];
                val_56 = val_57;
            }
            
            label_68:
            if(val_58 >= (this.prev[(long)cur_match & val_59]))
            {
                    return (int)(val_56 > this.lookahead) ? this.lookahead : (val_56);
            }
            
            val_7 = val_7 - 1;
            if(val_7 != 0)
            {
                goto label_77;
            }
            
            return (int)(val_56 > this.lookahead) ? this.lookahead : (val_56);
        }
        internal int deflateInit(Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level, int bits)
        {
            return this.deflateInit2(strm:  strm, level:  level, method:  8, windowBits:  bits, memLevel:  8, strategy:  0);
        }
        internal int deflateInit(Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level)
        {
            return this.deflateInit2(strm:  strm, level:  level, method:  8, windowBits:  15, memLevel:  8, strategy:  0);
        }
        internal int deflateInit2(Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level, int method, int windowBits, int memLevel, int strategy)
        {
            var val_21;
            var val_22;
            val_21 = windowBits;
            int val_1 = (level == 1) ? 6 : level;
            int val_2 = (val_21 < 0) ? (-val_21) : (val_21);
            val_22 = -2;
            strm.msg = 0;
            if(strategy > 2)
            {
                    return (int)val_22;
            }
            
            if(val_1 > 9)
            {
                    return (int)val_22;
            }
            
            if((val_2 - 9) > 6)
            {
                    return (int)val_22;
            }
            
            if(method != 8)
            {
                    return (int)val_22;
            }
            
            if((memLevel - 1) > 8)
            {
                    return (int)val_22;
            }
            
            strm.dstate = this;
            int val_6 = val_2 & 31;
            val_21 = 1;
            this.noheader = val_21 >> 31;
            int val_7 = memLevel + 9;
            val_6 = val_21 << val_6;
            int val_8 = memLevel + 7;
            this.w_size = val_6;
            this.w_bits = val_2;
            val_2 = val_6 - 1;
            this.w_mask = val_2;
            int val_9 = val_8 & 31;
            val_9 = val_21 << val_9;
            this.hash_size = val_9;
            this.hash_bits = val_8;
            val_9 = val_9 - 1;
            this.hash_mask = val_9;
            this.hash_shift = 0;
            var val_10 = val_6 << 1;
            this.window = new byte[0];
            this.prev = new short[0];
            int val_14 = memLevel + 6;
            val_14 = val_14 & 31;
            val_14 = val_21 << val_14;
            this.head = new short[0];
            this.lit_bufsize = val_14;
            int val_15 = val_14 << 2;
            this.pending_buf = new byte[0];
            int val_19 = (this.lit_bufsize < 0) ? (this.lit_bufsize + 1) : this.lit_bufsize;
            val_19 = val_19 >> 1;
            this.level = val_1;
            this.strategy = strategy;
            this.pending_buf_size = this.lit_bufsize << 2;
            this.l_buf = this.lit_bufsize + (this.lit_bufsize << 1);
            this.d_buf = val_19;
            this.method = 8;
            int val_20 = this.deflateReset(strm:  strm);
            val_22 = 0;
            return (int)val_22;
        }
        internal int deflateReset(Org.BouncyCastle.Utilities.Zlib.ZStream strm)
        {
            int val_2;
            if(strm != null)
            {
                    strm.total_in = 0;
                strm.total_out = 0;
                strm.msg = 0;
            }
            else
            {
                    mem[56] = 0;
                mem[32] = 0;
                mem[64] = 0;
            }
            
            strm.data_type = 2;
            val_2 = this.noheader;
            this.pending_out = 0;
            this.pending = 0;
            if((val_2 & 2147483648) != 0)
            {
                    val_2 = 0;
                this.noheader = 0;
            }
            
            this.status = (val_2 == 0) ? 42 : 113;
            strm.adler = 1;
            this.last_flush = 0;
            this.tr_init();
            this.lm_init();
            return 0;
        }
        internal int deflateEnd()
        {
            if((this.status != 42) && (this.status != 666))
            {
                    if(this.status != 113)
            {
                    return -2;
            }
            
            }
            
            this.pending_buf = 0;
            this.window = 0;
            this.prev = 0;
            this.head = 0;
            return (int)(this.status != 113) ? 0 : -3;
        }
        internal int deflateParams(Org.BouncyCastle.Utilities.Zlib.ZStream strm, int _level, int _strategy)
        {
            int val_10;
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_10 = 6;
            int val_1 = (_level == 1) ? (val_10) : _level;
            val_12 = -2;
            if(val_1 > 9)
            {
                    return (int)val_12;
            }
            
            val_10 = val_1 >> 31;
            if(val_10 != 0)
            {
                    return (int)val_12;
            }
            
            val_12 = -2;
            if(_strategy > 2)
            {
                    return (int)val_12;
            }
            
            if((_strategy >> 31) != 0)
            {
                    return (int)val_12;
            }
            
            val_10 = 1152921505509879808;
            val_13 = null;
            val_13 = null;
            int val_3 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            int val_4 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (((long)(int)(_level == 1 ? 6 : _level)) << 3);
            if((((Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 32) != ((Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((long)(int)(_level == 1 ? 6 : _level)) << 3) + 32 + 32)) && (strm.total_in != 0))
            {
                    if(strm.dstate == null)
            {
                goto label_33;
            }
            
                val_12 = strm.dstate.deflate(strm:  strm, flush:  1);
            }
            else
            {
                    val_12 = 0;
            }
            
            label_33:
            if(this.level != val_1)
            {
                    this.level = val_1;
                val_14 = null;
                val_14 = null;
                val_11 = this.level;
                int val_6 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (((long)(int)(this.level)) << 3);
                this.max_lazy_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((long)(int)(this.level)) << 3) + 32 + 20;
                int val_7 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
                this.good_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 16;
                int val_8 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
                this.nice_match = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 24;
                val_10 = this.level;
                int val_9 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
                this.max_chain_length = (Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 28;
            }
            
            this.strategy = _strategy;
            return (int)val_12;
        }
        internal int deflateSetDictionary(Org.BouncyCastle.Utilities.Zlib.ZStream strm, byte[] dictionary, int dictLength)
        {
            Org.BouncyCastle.Utilities.Zlib.Adler32 val_8;
            int val_9;
            if((dictionary == null) || (this.status != 42))
            {
                    return -2;
            }
            
            if(strm != null)
            {
                    val_8 = strm._adler;
            }
            else
            {
                    val_8 = 123372880;
            }
            
            strm.adler = 0.adler32(adler:  strm.adler, buf:  dictionary, index:  0, len:  dictLength);
            if(dictLength < 3)
            {
                    return -2;
            }
            
            int val_9 = this.w_size;
            val_9 = val_9 - 262;
            int val_3 = (val_9 < dictLength) ? (val_9) : dictLength;
            System.Array.Copy(sourceArray:  dictionary, sourceIndex:  (val_9 < dictLength) ? (dictLength - val_9) : 0, destinationArray:  this.window, destinationIndex:  0, length:  val_3);
            this.strstart = val_3;
            this.block_start = val_3;
            byte val_10 = this.window[0];
            this.ins_h = val_10;
            byte val_11 = this.window[1];
            int val_5 = this.hash_shift & 31;
            val_5 = val_10 << val_5;
            val_11 = val_5 ^ val_11;
            val_9 = val_11 & this.hash_mask;
            val_3 = val_3 - 3;
            this.ins_h = val_9;
            if((val_3 & 2147483648) != 0)
            {
                    return -2;
            }
            
            short val_15 = 0;
            goto label_11;
            label_20:
            val_9 = this.ins_h;
            label_11:
            int val_13 = (long)val_15 + 2;
            byte val_12 = this.window[val_13];
            int val_7 = this.hash_shift & 31;
            val_7 = val_9 << val_7;
            val_12 = val_7 ^ val_12;
            val_13 = val_12 & this.hash_mask;
            this.ins_h = val_13;
            this.prev[(long)this.w_mask & val_15] = this.head[(long)val_13];
            this.head[this.ins_h] = val_15;
            val_15 = val_15 + 1;
            if(val_15 <= val_3)
            {
                goto label_20;
            }
            
            return -2;
        }
        internal int deflate(Org.BouncyCastle.Utilities.Zlib.ZStream strm, int flush)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(flush > 4)
            {
                    return -2;
            }
            
            if(strm.next_out == null)
            {
                goto label_6;
            }
            
            if(strm.next_in == null)
            {
                goto label_4;
            }
            
            label_16:
            if(flush != 4)
            {
                    if(this.status == 666)
            {
                goto label_6;
            }
            
            }
            
            if(strm.avail_out == 0)
            {
                goto label_14;
            }
            
            this.strm = strm;
            this.last_flush = flush;
            if(this.status == 42)
            {
                    int val_13 = this.level;
                int val_14 = this.w_bits;
                val_13 = val_13 + 255;
                val_14 = 30719 + (val_14 << 12);
                var val_1 = (((uint)(val_13 >> 1) & 127) < 3) ? ((uint)(val_13 >> 1) & 127) : 3;
                val_14 = val_14 | (val_1 << 6);
                val_1 = val_14 | 32;
                val_14 = (this.strstart == 0) ? (val_14) : (val_1);
                var val_15 = 0;
                val_15 = val_15 + val_14;
                val_1 = val_15 >> 4;
                val_15 = val_1 + (val_15 >> 31);
                val_1 = val_15 << 5;
                val_15 = val_1 - val_15;
                val_15 = val_14 - val_15;
                val_14 = val_14 | 31;
                this.status = 113;
                this.putShortMSB(b:  val_14 - val_15);
                if(this.strstart != 0)
            {
                    this.putShortMSB(b:  strm.adler >> 16);
                this.putShortMSB(b:  strm.adler);
            }
            
                strm.adler = 1;
            }
            
            if(this.pending == 0)
            {
                goto label_11;
            }
            
            strm.flush_pending();
            if(strm.avail_out == 0)
            {
                goto label_58;
            }
            
            label_23:
            if(this.status != 666)
            {
                goto label_13;
            }
            
            if(strm.avail_in != 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_4:
            if(strm.avail_in == 0)
            {
                goto label_16;
            }
            
            label_6:
            val_13 = null;
            val_13 = null;
            strm.msg = Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg + 64;
            return -2;
            label_11:
            if(((flush == 4) || (this.last_flush < flush)) || (strm.avail_in != 0))
            {
                goto label_23;
            }
            
            label_14:
            val_14 = null;
            val_14 = null;
            strm.msg = Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg + 88;
            return -2;
            label_13:
            if(strm.avail_in != 0)
            {
                goto label_30;
            }
            
            label_15:
            var val_4 = (this.status == 666) ? 1 : 0;
            if(this.lookahead != 0)
            {
                goto label_30;
            }
            
            val_4 = ((flush == 0) ? 1 : 0) | val_4;
            if((val_4 & 1) != 0)
            {
                goto label_45;
            }
            
            label_30:
            val_15 = null;
            val_15 = null;
            int val_6 = Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + ((this.level) << 3);
            if(((Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 32) == 2)
            {
                goto label_37;
            }
            
            if(((Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 32) == 1)
            {
                goto label_38;
            }
            
            if(((Org.BouncyCastle.Utilities.Zlib.Deflate.END_BLOCK + (this.level) << 3) + 32 + 32) != 0)
            {
                goto label_45;
            }
            
            val_16 = this;
            int val_7 = this.deflate_stored(flush:  flush);
            goto label_41;
            label_37:
            val_16 = this;
            int val_8 = this.deflate_slow(flush:  flush);
            goto label_41;
            label_38:
            val_16 = this;
            int val_9 = this.deflate_fast(flush:  flush);
            label_41:
            if((val_9 & 4294967294) == 2)
            {
                    this.status = 666;
            }
            
            if(val_9 == 2)
            {
                goto label_43;
            }
            
            if(val_9 == 1)
            {
                goto label_44;
            }
            
            if(val_9 != 0)
            {
                goto label_45;
            }
            
            label_43:
            if(strm.avail_out != 0)
            {
                    return -2;
            }
            
            goto label_58;
            label_44:
            if(flush != 1)
            {
                goto label_48;
            }
            
            this._tr_align();
            if(strm != null)
            {
                goto label_49;
            }
            
            goto label_56;
            label_48:
            this._tr_stored_block(buf:  0, stored_len:  0, eof:  false);
            if((flush == 3) && (this.hash_size >= 1))
            {
                    var val_16 = 0;
                do
            {
                this.head[0] = 0;
                val_16 = val_16 + 1;
            }
            while(val_16 < this.hash_size);
            
            }
            
            if(strm == null)
            {
                goto label_56;
            }
            
            label_49:
            strm.flush_pending();
            goto label_57;
            label_56:
            0.flush_pending();
            label_57:
            if(strm.avail_out == 0)
            {
                goto label_58;
            }
            
            label_45:
            if(flush != 4)
            {
                    return -2;
            }
            
            if(this.noheader == 0)
            {
                goto label_60;
            }
            
            return -2;
            label_58:
            this.last_flush = 0;
            return -2;
            label_60:
            this.putShortMSB(b:  strm.adler >> 16);
            this.putShortMSB(b:  strm.adler);
            strm.flush_pending();
            this.noheader = 0;
            var val_12 = (this.pending == 0) ? 1 : 0;
            return -2;
        }
    
    }

}
