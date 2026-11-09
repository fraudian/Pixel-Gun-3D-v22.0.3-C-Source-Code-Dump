using UnityEngine;

namespace PGCompany
{
    internal sealed class 丝丌且丈丛丘丝不万 : 丝丆丌丏丆丆丗丙三
    {
        // Fields
        private string 丏专丘丕丐丗丄丆丅;
        private UnityEngine.GameObject 丟一丑上万丌与万丗;
        private bool 丕业丈业丒不丙东三;
        
        // Methods
        internal 丝丌且丈丛丘丝不万(string 万下专丑丄业丐丘丒, string 且丁世丝丒一业下丄)
        {
            this.丏专丘丕丐丗丄丆丅 = 且丁世丝丒一业下丄;
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            var val_14;
            System.Func<TagSystem.CompoundTagBehaviour, System.Boolean> val_16;
            if(this.丟一丑上万丌与万丗 != 0)
            {
                    return;
            }
            
            if(this.丕业丈业丒不丙东三 != false)
            {
                    return;
            }
            
            System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> val_3 = TagSystem.丐丝丙不丛丞丏丌丏.丑七不且上丗丁一世().不丄丑东丈丅上丌业(丆万一不丌且东丐丐:  this.丏专丘丕丐丗丄丆丅);
            if(val_3 == null)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = 丝丌且丈丛丘丝不万.<>c.<>9__4_0;
            if(val_16 == null)
            {
                    System.Func<TagSystem.CompoundTagBehaviour, System.Boolean> val_4 = null;
                val_16 = val_4;
                val_4 = new System.Func<TagSystem.CompoundTagBehaviour, System.Boolean>(object:  丝丌且丈丛丘丝不万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丌且丈丛丘丝不万.<>c::丛丝业丐七丆丆下下(TagSystem.CompoundTagBehaviour 三丟东丕丄丄下下丑));
                丝丌且丈丛丘丝不万.<>c.<>9__4_0 = val_16;
            }
            
            System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<TagSystem.CompoundTagBehaviour>(source:  System.Linq.Enumerable.Where<TagSystem.CompoundTagBehaviour>(source:  val_3, predicate:  val_4));
            if(val_6.Count == 0)
            {
                    return;
            }
            
            if(val_6.Count < 2)
            {
                    this.丕业丈业丒不丙东三 = true;
                this.丟一丑上万丌与万丗 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丛丑业万丗丝丒三丗.丅与丌专丟一丝业三(), parent:  val_6.Item[0].丌丟丄业且三丛丕丄(), worldPositionStays:  true);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Search game object with compound tag \"" + this.丏专丘丕丐丗丄丆丅 + "\". Found more than one. Cannot choose.");
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if(this.丟一丑上万丌与万丗 != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丟一丑上万丌与万丗);
            }
            
            this.丕业丈业丒不丙东三 = false;
        }
    
    }

}
