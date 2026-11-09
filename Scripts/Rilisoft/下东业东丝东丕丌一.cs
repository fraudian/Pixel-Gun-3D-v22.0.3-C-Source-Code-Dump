using UnityEngine;

namespace Rilisoft
{
    internal sealed class 下东业东丝东丕丌一 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.下东业东丝东丕丌一.丆丄万七一万丑丛丁> 一三业丟七与下上世;
        
        // Methods
        public 下东业东丝东丕丌一(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            var val_11;
            var val_12;
            this.一三业丟七与下上世 = new System.Collections.Generic.List<丆丄万七一万丑丛丁>();
            if(this.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            int val_3 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count;
            if(val_3 != 0)
            {
                    do
            {
                val_12 = null;
                val_12 = null;
                下与业丆下三丅丅丝 val_4 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
                int val_5 = val_4.下上不丏专丄丆业世.Count;
                if(val_5 != 0)
            {
                    var val_11 = 0;
                do
            {
                .一丘东丌丑且丏一丙 = val_4.下上不丏专丄丆业世.Item[0].一七与丅上丁丙丂不();
                this.一三业丟七与下上世.Add(item:  new 下东业东丝东丕丌一.丆丄万七一万丑丛丁());
                val_11 = val_11 + 1;
            }
            while(val_5 != val_11);
            
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
            }
            while(val_12 != val_3);
            
            }
            
            this.业不不且丐且与不与();
            Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七丘不丝一下专业万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.下东业东丝东丕丌一::上专丄丑专丑丘业丌()));
        }
        private void 业不不且丐且与不与()
        {
            var val_8;
            var val_17;
            System.Func<丆丄万七一万丑丛丁, System.Boolean> val_19;
            bool val_5 = UnityEngine.Debug.isDebugBuild;
            List.Enumerator<T> val_6 = this.一三业丟七与下上世.GetEnumerator();
            goto label_4;
            label_8:
            string val_9 = val_8.丐丏七丌丕丗业且上();
            val_9.m_stringLength = new System.Collections.Generic.HashSet<System.String>(collection:  CoinBonus.丆丈专万丁丝丈与丅()).Contains(item:  1152921523757905360);
            mem2[0] = new System.Collections.Generic.HashSet<System.String>(collection:  CoinBonus.世丗不丒丞不丕一丐()).Contains(item:  1152921523757905360);
            label_4:
            if(((-1087469696) & 1) != 0)
            {
                goto label_8;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            bool val_14 = UnityEngine.Debug.isDebugBuild;
            val_17 = null;
            val_17 = null;
            val_19 = 下东业东丝东丕丌一.<>c.<>9__2_0;
            if(val_19 == null)
            {
                    System.Func<丆丄万七一万丑丛丁, System.Boolean> val_15 = null;
                val_19 = val_15;
                val_15 = new System.Func<丆丄万七一万丑丛丁, System.Boolean>(object:  下东业东丝东丕丌一.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 下东业东丝东丕丌一.<>c::万丌丄七丂丟万丞丌(Rilisoft.下东业东丝东丕丌一.丆丄万七一万丑丛丁 专上丘丈丁世一丐且));
                下东业东丝东丕丌一.<>c.<>9__2_0 = val_19;
            }
            
            if((System.Linq.Enumerable.All<丆丄万七一万丑丛丁>(source:  this.一三业丟七与下上世, predicate:  val_15)) == false)
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        private void 上专丄丑专丑丘业丌()
        {
            var val_11;
            System.Func<丆丄万七一万丑丛丁, System.Boolean> val_13;
            List.Enumerator<T> val_3 = this.一三业丟七与下上世.GetEnumerator();
            goto label_2;
            label_4:
            string val_4 = 0.丐丏七丌丕丗业且上();
            val_4.m_stringLength = System.Linq.Enumerable.Contains<System.String>(source:  CoinBonus.丆丈专万丁丝丈与丅(), value:  public 丆丄万七一万丑丛丁 List.Enumerator<丆丄万七一万丑丛丁>::get_Current());
            mem2[0] = System.Linq.Enumerable.Contains<System.String>(source:  CoinBonus.世丗不丒丞不丕一丐(), value:  public 丆丄万七一万丑丛丁 List.Enumerator<丆丄万七一万丑丛丁>::get_Current());
            label_2:
            if(((-1087233768) & 1) != 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_11 = null;
            val_11 = null;
            val_13 = 下东业东丝东丕丌一.<>c.<>9__3_0;
            if(val_13 == null)
            {
                    System.Func<丆丄万七一万丑丛丁, System.Boolean> val_9 = null;
                val_13 = val_9;
                val_9 = new System.Func<丆丄万七一万丑丛丁, System.Boolean>(object:  下东业东丝东丕丌一.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 下东业东丝东丕丌一.<>c::丘丁丟东丞三丏丐且(Rilisoft.下东业东丝东丕丌一.丆丄万七一万丑丛丁 专上丘丈丁世一丐且));
                下东业东丝东丕丌一.<>c.<>9__3_0 = val_13;
            }
            
            if((System.Linq.Enumerable.All<丆丄万七一万丑丛丁>(source:  this.一三业丟七与下上世, predicate:  val_9)) == false)
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丆不与丐丞丗丕一丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.下东业东丝东丕丌一::上专丄丑专丑丘业丌()));
        }
    
    }

}
