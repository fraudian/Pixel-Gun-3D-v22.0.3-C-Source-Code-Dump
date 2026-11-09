using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
    public sealed class Tables8kGcmMultiplier : IGcmMultiplier
    {
        // Fields
        private byte[] H;
        private uint[][][] M;
        
        // Methods
        public void Init(byte[] H)
        {
            var val_18;
            System.UInt32[] val_19;
            System.UInt32[] val_20;
            System.UInt32[] val_21;
            System.UInt32[] val_22;
            System.UInt32[] val_23;
            if(this.M == null)
            {
                goto label_1;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.H, b:  H)) == false)
            {
                goto label_2;
            }
            
            return;
            label_1:
            this.M = new System.UInt32[][][32];
            label_2:
            this.H = Org.BouncyCastle.Utilities.Arrays.Clone(data:  H);
            this.M[0] = new System.UInt32[][16];
            this.M[1] = new System.UInt32[][16];
            this.M[0][0] = new uint[4];
            this.M[1][0] = new uint[4];
            System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUints(bs:  H);
            val_18 = 4;
            this.M[1][8] = val_8;
            goto label_31;
            label_49:
            object val_9 = val_8[0].Clone();
            if(val_9 == null)
            {
                goto label_34;
            }
            
            val_19 = val_9;
            if(val_19 != null)
            {
                goto label_35;
            }
            
            label_34:
            val_19 = 0;
            label_35:
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP(x:  val_19);
            System.UInt32[][] val_27 = this.M[1];
            if(val_27 == null)
            {
                goto label_40;
            }
            
            if(val_19 != 0)
            {
                goto label_41;
            }
            
            goto label_44;
            label_40:
            if(val_19 == 0)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_27[val_18] = val_19;
            val_18 = 0;
            label_31:
            if(val_18 != 0)
            {
                goto label_49;
            }
            
            object val_11 = this.M[1][1].Clone();
            if(val_11 == null)
            {
                goto label_52;
            }
            
            val_20 = val_11;
            if(val_20 != null)
            {
                goto label_53;
            }
            
            label_52:
            val_20 = 0;
            label_53:
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP(x:  val_20);
            this.M[0][8] = val_20;
            label_79:
            object val_12 = this.M[0][0].Clone();
            if(val_12 == null)
            {
                goto label_67;
            }
            
            val_21 = val_12;
            if(val_21 != null)
            {
                goto label_68;
            }
            
            label_67:
            val_21 = 0;
            label_68:
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP(x:  val_21);
            System.UInt32[][] val_33 = this.M[0];
            if(val_33 == null)
            {
                goto label_73;
            }
            
            if(val_21 != 0)
            {
                goto label_74;
            }
            
            goto label_77;
            label_73:
            if(val_21 == 0)
            {
                goto label_77;
            }
            
            label_74:
            label_77:
            val_33[4] = val_21;
            if(0 != 0)
            {
                goto label_79;
            }
            
            goto label_81;
            label_132:
            if(0 < 2)
            {
                goto label_81;
            }
            
            this.M[0] = new System.UInt32[][16];
            this.M[0][0] = new uint[4];
            label_107:
            object val_16 = this.M[(long)W26 - 1][8].Clone();
            if(val_16 == null)
            {
                goto label_97;
            }
            
            val_22 = val_16;
            if(val_22 != null)
            {
                goto label_98;
            }
            
            label_97:
            val_22 = 0;
            label_98:
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP8(x:  val_22);
            this.M[0][8] = val_22;
            if(0 != 0)
            {
                goto label_107;
            }
            
            label_81:
            label_131:
            if(2 < 2)
            {
                goto label_108;
            }
            
            label_130:
            object val_17 = this.M[0][2].Clone();
            if(val_17 == null)
            {
                goto label_114;
            }
            
            val_23 = val_17;
            if(val_23 != null)
            {
                goto label_115;
            }
            
            label_114:
            val_23 = 0;
            label_115:
            var val_18 = 5 - 4;
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(x:  val_23, y:  this.M[0][1]);
            System.UInt32[][] val_42 = this.M[0];
            if(val_42 == null)
            {
                goto label_124;
            }
            
            if(val_23 != 0)
            {
                goto label_125;
            }
            
            goto label_128;
            label_124:
            if(val_23 == 0)
            {
                goto label_128;
            }
            
            label_125:
            label_128:
            var val_19 = 2 + 5;
            val_19 = val_19 - 4;
            var val_21 = 5 + 1;
            val_42[(long)val_19] = val_23;
            if((5 - 3) < 2)
            {
                goto label_130;
            }
            
            label_108:
            if(0 <= 15)
            {
                goto label_131;
            }
            
            if((0 + 1) != 32)
            {
                goto label_132;
            }
        
        }
        public void MultiplyH(byte[] x)
        {
            uint[] val_1 = new uint[4];
            var val_29 = 0;
            do
            {
                var val_2 = val_29 + 30;
                byte val_8 = x[1];
                byte val_4 = val_8 & 15;
                val_8 = val_8 & 15;
                System.UInt32[] val_9 = this.M[val_29][val_8];
                uint val_11 = val_9[0];
                val_11 = val_11 ^ val_1[0];
                val_1[0] = val_11;
                uint val_13 = val_9[0];
                val_13 = val_13 ^ val_1[0];
                val_1[0] = val_13;
                uint val_15 = val_9[1];
                val_15 = val_15 ^ val_1[1];
                val_1[1] = val_15;
                uint val_17 = val_9[1];
                val_17 = val_17 ^ val_1[1];
                val_1[1] = val_17;
                var val_5 = val_29 + 31;
                byte val_19 = x[1];
                val_19 = val_19 >> 4;
                System.UInt32[] val_20 = this.M[val_29][val_19];
                uint val_22 = val_20[0];
                val_22 = val_22 ^ val_1[0];
                val_1[0] = val_22;
                uint val_24 = val_20[0];
                val_24 = val_24 ^ val_1[0];
                val_1[0] = val_24;
                uint val_26 = val_20[1];
                val_26 = val_26 ^ val_1[1];
                val_1[1] = val_26;
                uint val_28 = val_20[1];
                var val_6 = 47 - 1;
                val_29 = val_29 - 2;
                val_28 = val_28 ^ val_1[1];
                val_1[1] = val_28;
            }
            while((47 - 32) > 0);
            
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  val_1, bs:  x, off:  0);
        }
        public Tables8kGcmMultiplier()
        {
        
        }
    
    }

}
