using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丁丄与下丄丌丈下丟
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Collections.IEnumerator> 丞丗一丐丕丈业丘不;
        private readonly System.Collections.Generic.List<System.Collections.IEnumerator> 丂丝下一丈丏丄丙业;
        internal static byte[] 不不丂丆丟丑丌丈丕;
        
        // Methods
        public void 万丂丝丁东丑丕丌丌(System.Collections.IEnumerator 丙世三一丐丗丄丁万)
        {
            if(丙世三一丐丗丄丁万 == null)
            {
                    return;
            }
            
            if((this.丞丗一丐丕丈业丘不.Contains(item:  丙世三一丐丗丄丁万)) != false)
            {
                    return;
            }
            
            this.丞丗一丐丕丈业丘不.Add(item:  丙世三一丐丗丄丁万);
        }
        public void Remove(System.Collections.IEnumerator 丙世三一丐丗丄丁万)
        {
            if(丙世三一丐丗丄丁万 == null)
            {
                    return;
            }
            
            if((this.丞丗一丐丕丈业丘不.Contains(item:  丙世三一丐丗丄丁万)) == false)
            {
                    return;
            }
            
            bool val_2 = this.丞丗一丐丕丈业丘不.Remove(item:  丙世三一丐丗丄丁万);
        }
        public void 丛丙世丞丌丄业丙丅()
        {
            System.Collections.Generic.List<System.Collections.IEnumerator> val_8;
            var val_9;
            int val_1 = this.丞丗一丐丕丈业丘不.Count;
            if(val_1 >= 1)
            {
                    var val_9 = 0;
                do
            {
                System.Collections.IEnumerator val_2 = this.丞丗一丐丕丈业丘不.Item[0];
                var val_8 = 0;
                val_8 = val_8 + 1;
                if(val_2.MoveNext() != true)
            {
                    val_8 = this.丂丝下一丈丏丄丙业;
                val_8.Add(item:  val_2);
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 != val_1);
            
            }
            
            int val_5 = this.丂丝下一丈丏丄丙业.Count;
            if(val_5 < 1)
            {
                    return;
            }
            
            val_9 = 0;
            goto label_14;
            label_17:
            val_8 = this.丞丗一丐丕丈业丘不;
            bool val_7 = val_8.Remove(item:  val_2.Item[0]);
            val_9 = 1;
            label_14:
            if(val_9 < val_5)
            {
                goto label_17;
            }
            
            this.丂丝下一丈丏丄丙业.Clear();
        }
        internal static void 七一丘丕下丙下一丑(string 丂七丂丞专丛丟丙七)
        {
            var val_11;
            var val_12;
            var val_13;
            byte val_14;
            var val_15;
            val_11 = null;
            val_11 = null;
            byte[] val_1 = new byte[32];
            val_12 = 0;
            val_13 = 87;
            goto label_3;
            label_9:
            if(丂七丂丞专丛丟丙七 != null)
            {
                    val_14 = 丂七丂丞专丛丟丙七.Chars[0];
            }
            else
            {
                    val_14 = 0.Chars[0];
            }
            
            val_14 = (val_14 & 65535) - (((丂七丂丞专丛丟丙七.Chars[0] & 65535) < (':')) ? 48 : 87);
            val_12 = 1;
            val_1[0] = val_14;
            label_3:
            if(val_12 < 丂七丂丞专丛丟丙七.Length)
            {
                goto label_9;
            }
            
            byte[] val_9 = new byte[32];
            val_15 = 0;
            goto label_10;
            label_17:
            byte val_11 = val_1[0];
            val_15 = 1;
            val_9[0] = (val_3 & 65535) + 32;
            label_10:
            if(val_15 < val_1.Length)
            {
                goto label_17;
            }
            
            byte[] val_10 = new byte[32];
            Rilisoft.丁丄与下丄丌丈下丟.不不丂丆丟丑丌丈丕 = val_10;
            System.Array.Copy(sourceArray:  val_9, destinationArray:  val_10, length:  32);
        }
        public 丁丄与下丄丌丈下丟()
        {
            this.丞丗一丐丕丈业丘不 = new System.Collections.Generic.List<System.Collections.IEnumerator>();
            this.丂丝下一丈丏丄丙业 = new System.Collections.Generic.List<System.Collections.IEnumerator>();
        }
    
    }

}
