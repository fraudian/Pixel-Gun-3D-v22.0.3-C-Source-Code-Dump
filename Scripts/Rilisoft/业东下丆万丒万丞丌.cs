using UnityEngine;

namespace Rilisoft
{
    public sealed class 业东下丆万丒万丞丌 : EventArgs
    {
        // Fields
        private bool <丁丘上上丞万丕丅丕>k__BackingField;
        private Rilisoft.七丕丟丏三丈一丄世 <世丗丁且丄丄丆七丏>k__BackingField;
        
        // Properties
        public bool 世世与丁丏丑丐丕业 { get; set; }
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; set; }
        
        // Methods
        public bool 丕世丅三丅七丙丅三()
        {
            return (bool)this.<丁丘上上丞万丕丅丕>k__BackingField;
        }
        public void 万丆与不丒丌万丏丛(bool 丙业与丙丗丝不丈东)
        {
            this.<丁丘上上丞万丕丅丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.七丕丟丏三丈一丄世 丘丛丆丕且丂业世丌()
        {
            return (Rilisoft.七丕丟丏三丈一丄世)this.<世丗丁且丄丄丆七丏>k__BackingField;
        }
        internal void 丞万丈丌三丑丙丁丈(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
        {
            this.<世丗丁且丄丄丆七丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "IsSquadWinner", value:  this.<丁丘上上丞万丕丅丕>k__BackingField);
            val_1.Add(key:  "Mode", value:  this.<世丗丁且丄丄丆七丏>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 业东下丆万丒万丞丌()
        {
        
        }
    
    }

}
