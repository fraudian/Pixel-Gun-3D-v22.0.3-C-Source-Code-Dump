using UnityEngine;

namespace Rilisoft
{
    public sealed class 业丙丞下七丏下专专 : EventArgs
    {
        // Fields
        private string <丛丐万世与丗丆丐一>k__BackingField;
        private Rilisoft.七丕丟丏三丈一丄世 <世丗丁且丄丄丆七丏>k__BackingField;
        private bool <丑与七丑丂丘下东世>k__BackingField;
        
        // Properties
        public string 一丘东丌丑且丏一丙 { get; set; }
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; set; }
        internal bool 上万丑丑与业丂三丗 { get; set; }
        
        // Methods
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
        internal bool 世专东专世世丛丒业()
        {
            return (bool)this.<丑与七丑丂丘下东世>k__BackingField;
        }
        internal void 上与丅三东丑丗世丙(bool 丙业与丙丗丝不丈东)
        {
            this.<丑与七丑丂丘下东世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "map", value:  this.<丛丐万世与丗丆丐一>k__BackingField);
            val_1.Add(key:  "mode", value:  this.<世丗丁且丄丄丆七丏>k__BackingField);
            val_1.Add(key:  "base", value:  this.<丑与七丑丂丘下东世>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 业丙丞下七丏下专专()
        {
        
        }
    
    }

}
