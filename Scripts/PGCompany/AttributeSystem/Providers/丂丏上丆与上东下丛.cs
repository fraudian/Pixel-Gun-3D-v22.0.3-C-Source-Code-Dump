using UnityEngine;

namespace PGCompany.AttributeSystem.Providers
{
    internal sealed class 丂丏上丆与上东下丛 : 且丁丞与不三丟丌丅, IDisposable
    {
        // Fields
        private PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 世丈丝丏三且丙丝上;
        private System.Action<int> 丄丙上与专丂丅丘丄;
        
        // Methods
        internal 丂丏上丆与上东下丛(PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丆下丕丅丕一丝丁丛)
        {
            this.世丈丝丏三且丙丝上 = 丆下丕丅丕一丝丁丛;
            Progress.东丞丕丛丘七丌丟丛.丞丐上丈与丙丐一丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丂丏上丆与上东下丛::丒下丏丐东丆丄丝丄()));
        }
        public void Dispose()
        {
            Progress.东丞丕丛丘七丌丟丛.专不丂丂丝一与业世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丂丏上丆与上东下丛::丒下丏丐东丆丄丝丄()));
        }
        private void 丒下丏丐东丆丄丝丄()
        {
            if(this.丄丙上与专丂丅丘丄 == null)
            {
                    return;
            }
            
            this.丄丙上与专丂丅丘丄.Invoke(obj:  this.世丈丝丏三且丙丝上);
        }
        public void 丟丗与丅与七上丞丑(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丙上与专丂丅丘丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560600746264);
        
        }
        public void 三丗专上丏上丟三业(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丙上与专丂丅丘丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560600882840);
        
        }
        public bool 丟丐下丐三一丄丞丑<T>(int 丆下丕丅丕一丝丁丛)
        {
            return true;
        }
        public T 东且丛且业丗丑丙丗<T>(int 丆下丕丅丕一丝丁丛)
        {
            var val_14;
            var val_15;
            long val_16;
            var val_17;
            var val_18;
            long val_19;
            var val_20;
            if(PixelTime.丙丅丅业丟丁世丁丗() < 1)
            {
                goto label_13;
            }
            
            if(this.世丈丝丏三且丙丝上 <= 63201)
            {
                goto label_4;
            }
            
            if(this.世丈丝丏三且丙丝上 == 64201)
            {
                goto label_5;
            }
            
            if(this.世丈丝丏三且丙丝上 == 65201)
            {
                goto label_6;
            }
            
            if(this.世丈丝丏三且丙丝上 != 66201)
            {
                goto label_13;
            }
            
            val_14 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆();
            int val_3 = val_14.丑丈上且丟且丞丂上();
            goto label_26;
            label_4:
            if(this.世丈丝丏三且丙丝上 == 62201)
            {
                goto label_12;
            }
            
            if(this.世丈丝丏三且丙丝上 != 63201)
            {
                goto label_13;
            }
            
            val_15 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆();
            val_16 = PixelTime.丙丅丅业丟丁世丁丗();
            val_17 = 24;
            goto label_19;
            label_13:
            val_14 = 0;
            goto label_26;
            label_12:
            val_15 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆();
            val_16 = PixelTime.丙丅丅业丟丁世丁丗();
            val_17 = 1;
            label_19:
            val_14 = val_15;
            int val_8 = val_14.丄丈丏三与丂丆丘丌(下丞丗丌且丒且不丙:  1, 丑专丛丅丞下丄丈丞:  val_16);
            goto label_26;
            label_5:
            val_18 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆();
            val_19 = PixelTime.丙丅丅业丟丁世丁丗();
            val_20 = 7;
            goto label_32;
            label_6:
            val_18 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆();
            val_19 = PixelTime.丙丅丅业丟丁世丁丗();
            val_20 = 30;
            label_32:
            val_14 = val_18;
            int val_13 = val_14.一丄上三丘丆东万丆(三丘丑丏不万丟与丘:  30, 丑专丛丅丞下丄丈丞:  val_19);
            label_26:
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return (int)null;
            }
            
            return (int)null;
        }
        public void 丂上丆且丘三不丟业<T>(int 丆下丕丅丕一丝丁丛, T 丙业与丙丗丝不丈东, PGCompany.AttributeSystem.丌丑业丈丅丟丙与且 专丒丌丆下丐丞丟丞)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
    
    }

}
