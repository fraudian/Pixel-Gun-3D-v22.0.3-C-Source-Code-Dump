using UnityEngine;

namespace PGCompany.ItemSystem
{
    internal class 专丑丐东下与万世万 : 丒三丟丝丗与不丈丞, 业且丗丐丛丆丈丙丈
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈> 丁丈万且丟丁业七丆;
        private readonly PGCompany.ItemSystem.业且丗丐丛丆丈丙丈 世上丄与丈一上丆且;
        
        // Methods
        public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)
        {
            System.Type val_8;
            var val_9;
            PGCompany.ItemSystem.业且丗丐丛丆丈丙丈 val_10;
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  下丅丙一丂丗丅丝七);
            val_9 = public System.Boolean System.Collections.Generic.Dictionary<System.Type, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈>::ContainsKey(System.Type key);
            if((this.丁丈万且丟丁业七丆.ContainsKey(key:  val_8.GetType())) == false)
            {
                goto label_4;
            }
            
            val_8 = val_8.GetType();
            val_9 = public PGCompany.ItemSystem.业且丗丐丛丆丈丙丈 System.Collections.Generic.Dictionary<System.Type, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈>::get_Item(System.Type key);
            val_10 = this.丁丈万且丟丁业七丆.Item[val_8];
            if(val_10 != null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_4:
            val_10 = this.世上丄与丈一上丆且;
            if(val_10 != null)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 0;
            return val_10.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  下丅丙一丂丗丅丝七);
        }
        public 专丑丐东下与万世万()
        {
            System.Collections.Generic.Dictionary<System.Type, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈> val_1 = new System.Collections.Generic.Dictionary<System.Type, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈>();
            val_1.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new 专丑丐东下与万世万.业丄一丘七丘东丟专());
            val_1.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new 专丑丐东下与万世万.丑下丏丅与丐丆专三());
            val_1.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new 专丑丐东下与万世万.丑业丌丆三丈七丄世());
            专丑丐东下与万世万.七丆且丞下一丟丏丝 val_9 = new 专丑丐东下与万世万.七丆且丞下一丟丏丝();
            val_1.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_9);
            this.丁丈万且丟丁业七丆 = val_1;
            this.世上丄与丈一上丆且 = new 专丑丐东下与万世万.丐丙丑丄且丟丆丛丏();
            val_9 = new System.Object();
        }
    
    }

}
