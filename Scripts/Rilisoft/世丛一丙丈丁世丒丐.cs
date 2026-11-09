using UnityEngine;

namespace Rilisoft
{
    public sealed class 世丛一丙丈丁世丒丐 : EventArgs
    {
        // Fields
        private string <丘一丏三丂丗三不与>k__BackingField;
        private string <丛丐万世与丗丆丐一>k__BackingField;
        private Rilisoft.七丕丟丏三丈一丄世 <世丗丁且丄丄丆七丏>k__BackingField;
        private CategoryNames <东丝丏丆三下一七万>k__BackingField;
        
        // Properties
        public string 丛丛丁丗且丑丏丕上 { get; set; }
        public string 一丘东丌丑且丏一丙 { get; set; }
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; set; }
        internal CategoryNames 丙丕丈一一丝丑七丈 { get; set; }
        
        // Methods
        public string 丂一丙丑丈万丟丝丕()
        {
            return (string)this.<丘一丏三丂丗三不与>k__BackingField;
        }
        public void 丕一不丝且一丌丝丘(string 丙业与丙丗丝不丈东)
        {
            this.<丘一丏三丂丗三不与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string 丕丆丞丂业东与上丅()
        {
            return (string)this.<丛丐万世与丗丆丐一>k__BackingField;
        }
        public void 下东丅世丅专丝专丌(string 丙业与丙丗丝不丈东)
        {
            this.<丛丐万世与丗丆丐一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.七丕丟丏三丈一丄世 丘丛丆丕且丂业世丌()
        {
            return (Rilisoft.七丕丟丏三丈一丄世)this.<世丗丁且丄丄丆七丏>k__BackingField;
        }
        internal void 丞万丈丌三丑丙丁丈(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
        {
            this.<世丗丁且丄丄丆七丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal CategoryNames 丘专上世与丟丝丟丛()
        {
            return (CategoryNames)this.<东丝丏丆三下一七万>k__BackingField;
        }
        internal void 丅丞专下丌丕一丘业(CategoryNames 丙业与丙丗丝不丈东)
        {
            this.<东丝丏丆三下一七万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "kind", value:  this.<丘一丏三丂丗三不与>k__BackingField);
            val_1.Add(key:  "map", value:  this.<丛丐万世与丗丆丐一>k__BackingField);
            val_1.Add(key:  "mode", value:  this.<世丗丁且丄丄丆七丏>k__BackingField);
            val_1.Add(key:  "slot", value:  this.<东丝丏丆三下一七万>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 世丛一丙丈丁世丒丐()
        {
        
        }
    
    }

}
