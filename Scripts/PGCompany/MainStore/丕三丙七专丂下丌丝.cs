using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丕三丙七专丂下丌丝
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.MainStore.丕三丙七专丂下丌丝.丛且丐下世与丘丆丗> 业丄丌丗丐七丐丗上;
        private static int 丐丙业丁上丝丁丆丗;
        
        // Methods
        internal 丕三丙七专丂下丌丝()
        {
            this.业丄丌丗丐七丐丗上 = new System.Collections.Generic.Dictionary<System.Int32, 丛且丐下世与丘丆丗>();
        }
        internal int 下丌业业丐丘丐丘三(TagSystem.三与下丘七丘丌丏丄 东丌丕上丞万丌丙丑, TagSystem.下万上丅丗丂丄七上 丟且丒专下丈七丗丕, System.Action<PGCompany.MainStore.丑东丁丏丘丏世丄丙> 业丒丒专丞丒丘丌丗)
        {
            int val_1 = this.丛东丙丕七丟丙与不();
            this.业丄丌丗丐七丐丗上.Add(key:  val_1, value:  new 丛且丐下世与丘丆丗() {下丄丈不与世丐业专 = val_1, 丈世丛丕且不丟丈七 = 东丌丕上丞万丌丙丑, 丙丛上世丅丆专与丟 = 丟且丒专下丈七丗丕, 三丟下三七丘丗一丏 = 业丒丒专丞丒丘丌丗});
            return val_1;
        }
        internal void 万不丒上丕丗丂丘丒(int 且与丆丑下丕七丑丗)
        {
            if((this.业丄丌丗丐七丐丗上.ContainsKey(key:  且与丆丑下丕七丑丗)) == false)
            {
                    return;
            }
            
            bool val_2 = this.业丄丌丗丐七丐丗上.Remove(key:  且与丆丑下丕七丑丗);
        }
        internal void 万丆丞丒丄丗与丄丘(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, PGCompany.MainStore.丞专且与丆万丒三下 丕丁丘七且丝丟丐丁)
        {
            var val_8;
            var val_9;
            TagSystem.三与下丘七丘丌丏丄 val_10;
            TagSystem.下万上丅丗丂丄七上 val_11;
            var val_13;
            var val_16;
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return;
            }
            
            val_16 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛();
            if(val_16 == null)
            {
                    return;
            }
            
            if(val_16.不丈丅万不下丙丄丅() == false)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.业丄丌丗丐七丐丗上.GetEnumerator();
            label_10:
            if(((-608146848) & 1) == 0)
            {
                goto label_5;
            }
            
            if(((val_8 == 0) || (val_9 == 0)) || (((val_16.丂丆世世丕丅丕丅上(丘丛丏丘丝七世七丅:  val_10, 丟且丒专下丈七丗丕:  val_11)) == false) || (val_13 == 0)))
            {
                goto label_10;
            }
            
            new PGCompany.MainStore.丑东丁丏丘丏世丄丙() = new PGCompany.MainStore.丑东丁丏丘丏世丄丙(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 丕丁丘七且丝丟丐丁:  丕丁丘七且丝丟丐丁 = 丕丁丘七且丝丟丐丁);
            val_13.Invoke(obj:  new PGCompany.MainStore.丑东丁丏丘丏世丄丙());
            goto label_10;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private int 丛东丙丕七丟丙与不()
        {
            int val_1 = PGCompany.MainStore.丕三丙七专丂下丌丝.丐丙业丁上丝丁丆丗;
            val_1 = val_1 + 1;
            PGCompany.MainStore.丕三丙七专丂下丌丝.丐丙业丁上丝丁丆丗 = val_1;
            return (int)PGCompany.MainStore.丕三丙七专丂下丌丝.丐丙业丁上丝丁丆丗;
        }
    
    }

}
