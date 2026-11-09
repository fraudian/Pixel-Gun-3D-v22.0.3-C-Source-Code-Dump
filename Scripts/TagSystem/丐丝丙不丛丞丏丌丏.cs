using UnityEngine;

namespace TagSystem
{
    internal sealed class 丐丝丙不丛丞丏丌丏
    {
        // Fields
        private static TagSystem.丐丝丙不丛丞丏丌丏 丝业丆丁业三丈丟东;
        private System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> 且丑三丐丕丘业东丈;
        
        // Properties
        internal static TagSystem.丐丝丙不丛丞丏丌丏 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static TagSystem.丐丝丙不丛丞丏丌丏 丑七不且上丗丁一世()
        {
            TagSystem.丐丝丙不丛丞丏丌丏 val_2 = TagSystem.丐丝丙不丛丞丏丌丏.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            TagSystem.丐丝丙不丛丞丏丌丏 val_1 = null;
            val_2 = val_1;
            val_1 = new TagSystem.丐丝丙不丛丞丏丌丏();
            TagSystem.丐丝丙不丛丞丏丌丏.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal void 丅丗且万东东丝东一(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if((this.且丑三丐丕丘业东丈.Contains(item:  丛丑业万丗丝丒三丗)) != false)
            {
                    return;
            }
            
            this.且丑三丐丕丘业东丈.Add(item:  丛丑业万丗丝丒三丗);
        }
        internal void 一丒丝丂丑且丘不丛(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            bool val_1 = this.且丑三丐丕丘业东丈.Remove(item:  丛丑业万丗丝丒三丗);
        }
        internal System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> 不丄丑东丈丅上丌业(string 丆万一不丌且东丐丐)
        {
            .丆万一不丌且东丐丐 = 丆万一不丌且东丐丐;
            if(this.且丑三丐丕丘业东丈 != null)
            {
                    return this.且丑三丐丕丘业东丈.FindAll(match:  new System.Predicate<TagSystem.CompoundTagBehaviour>(object:  new 丐丝丙不丛丞丏丌丏.丘丞上世丗丘丏丐东(), method:  System.Boolean 丐丝丙不丛丞丏丌丏.丘丞上世丗丘丏丐东::丒丁丅丈专不丆上丐(TagSystem.CompoundTagBehaviour 丑丟丐丞三丞丁丙七)));
            }
            
            return this.且丑三丐丕丘业东丈.FindAll(match:  new System.Predicate<TagSystem.CompoundTagBehaviour>(object:  new 丐丝丙不丛丞丏丌丏.丘丞上世丗丘丏丐东(), method:  System.Boolean 丐丝丙不丛丞丏丌丏.丘丞上世丗丘丏丐东::丒丁丅丈专不丆上丐(TagSystem.CompoundTagBehaviour 丑丟丐丞三丞丁丙七)));
        }
        public 丐丝丙不丛丞丏丌丏()
        {
            this.且丑三丐丕丘业东丈 = new System.Collections.Generic.List<TagSystem.CompoundTagBehaviour>();
        }
    
    }

}
