using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
    public class Tables1kGcmExponentiator : IGcmExponentiator
    {
        // Fields
        private System.Collections.IList lookupPowX2;
        
        // Methods
        public void Init(byte[] x)
        {
            System.Collections.IList val_7;
            System.UInt32[] val_9;
            var val_10;
            System.UInt32[] val_1 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUints(bs:  x);
            val_7 = this.lookupPowX2;
            if(val_7 == null)
            {
                goto label_3;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            object val_3 = val_7.Item[0];
            if(val_3 == null)
            {
                goto label_8;
            }
            
            val_7 = null;
            val_9 = val_3;
            if(val_9 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_9 = 0;
            label_9:
            val_10 = 0;
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  val_1, b:  val_9)) == true)
            {
                    return;
            }
            
            label_3:
            val_7 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  8);
            this.lookupPowX2 = val_7;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 2;
            int val_8 = val_7.Add(value:  val_1);
        }
        public void ExponentiateX(long pow, byte[] output)
        {
            System.UInt32[] val_5;
            long val_6 = pow;
            System.UInt32[] val_1 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.OneAsUints();
            if(val_6 < 1)
            {
                goto label_3;
            }
            
            var val_7 = 0;
            label_16:
            if((val_6 & 1) == 0)
            {
                goto label_4;
            }
            
            this.EnsureAvailable(bit:  0);
            var val_5 = 0;
            val_5 = val_5 + 1;
            object val_3 = this.lookupPowX2.Item[0];
            if(val_3 == null)
            {
                goto label_14;
            }
            
            val_5 = val_3;
            if(val_5 != null)
            {
                goto label_13;
            }
            
            label_14:
            val_5 = 0;
            label_13:
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x:  val_1, y:  val_5);
            label_4:
            val_6 = val_6 >> 1;
            val_7 = val_7 + 1;
            if(val_6 > 0)
            {
                goto label_16;
            }
            
            label_3:
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  val_1, bs:  output, off:  0);
        }
        private void EnsureAvailable(int bit)
        {
            var val_7;
            var val_9;
            var val_11;
            System.UInt32[] val_12;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = 1;
            val_9 = this.lookupPowX2.Count;
            if(val_9 > bit)
            {
                    return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_7 = 0;
            val_11 = public System.Object System.Collections.IList::get_Item(int index);
            object val_5 = this.lookupPowX2.Item[val_9 - 1];
            if(val_5 == null)
            {
                goto label_12;
            }
            
            val_12 = val_5;
            if(val_12 != null)
            {
                goto label_13;
            }
            
            val_11 = 0;
            label_12:
            val_12 = 0;
            label_13:
            do
            {
                System.UInt32[] val_7 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_12);
                Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x:  val_7, y:  val_7);
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_11 = 2;
                int val_9 = this.lookupPowX2.Add(value:  val_7);
                val_9 = val_9 + 1;
            }
            while(val_9 <= bit);
        
        }
        public Tables1kGcmExponentiator()
        {
        
        }
    
    }

}
