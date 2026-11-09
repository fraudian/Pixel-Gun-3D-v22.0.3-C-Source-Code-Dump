using UnityEngine;

namespace Progress
{
    internal abstract class 丛世丞丆七一七丁七
    {
        // Fields
        protected System.Threading.Tasks.TaskCompletionSource<Progress.丘丟丆丝丁丏丄专一> 下且丟丟丄丌丈与丆;
        protected System.Collections.Generic.Dictionary<string, object> 丟一七丛不丟一丏丁;
        
        // Methods
        internal abstract System.Threading.Tasks.Task<Progress.丘丟丆丝丁丏丄专一> 丕丌丈丂丝丝七业下(System.Collections.Generic.Dictionary<string, object> 上丕丈丞丌丘丅不与); // 0
        protected abstract bool 丄且丙丁世丝丄丐丅(out string 丝不丄业丛三上丕丄); // 0
        protected abstract bool 丄且丙丁世丝丄丐丅(out string 丝不丄业丛三上丕丄, out int 丌丈不丄丝七丕万专); // 0
        internal abstract bool 丄且丙丁世丝丄丐丅(); // 0
        protected abstract void 丈丂丑丒三一下丏七(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄); // 0
        protected System.Collections.Generic.Dictionary<object, object> 三东上世与丈丘业三(object 上丕丈丞丌丘丅不与, string 丝不丄业丛三上丕丄, int 七与业丕丆丕丁丞丅)
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "hash", value:  丝不丄业丛三上丕丄);
            if(val_1 != null)
            {
                    val_1.set_Item(key:  "hash_version", value:  七与业丕丆丕丁丞丅);
            }
            else
            {
                    val_1.set_Item(key:  "hash_version", value:  七与业丕丆丕丁丞丅);
            }
            
            val_1.set_Item(key:  "progress", value:  上丕丈丞丌丘丅不与);
            return val_1;
        }
        protected 丛世丞丆七一七丁七()
        {
        
        }
    
    }

}
