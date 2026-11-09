using UnityEngine;

namespace Rilisoft
{
    public sealed class 丈丌丌东丄丑丗七丈 : EventArgs
    {
        // Fields
        private int <东丈丐丁上丝上世丐>k__BackingField;
        private Rilisoft.七丕丟丏三丈一丄世 <世丗丁且丄丄丆七丏>k__BackingField;
        private string <丛丐万世与丗丆丐一>k__BackingField;
        
        // Properties
        public int 万丙丛丂丌丞一三不 { get; set; }
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; set; }
        internal string 一丘东丌丑且丏一丙 { get; set; }
        
        // Methods
        public int 三丄丏丂丁下丐丛万()
        {
            return (int)this.<东丈丐丁上丝上世丐>k__BackingField;
        }
        public void 丁丗丗专丗与丗丗丌(int 丙业与丙丗丝不丈东)
        {
            this.<东丈丐丁上丝上世丐>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.七丕丟丏三丈一丄世 丘丛丆丕且丂业世丌()
        {
            return (Rilisoft.七丕丟丏三丈一丄世)this.<世丗丁且丄丄丆七丏>k__BackingField;
        }
        internal void 丞万丈丌三丑丙丁丈(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
        {
            this.<世丗丁且丄丄丆七丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 丕丆丞丂业东与上丅()
        {
            return (string)this.<丛丐万世与丗丆丐一>k__BackingField;
        }
        internal void 下东丅世丅专丝专丌(string 丙业与丙丗丝不丈东)
        {
            this.<丛丐万世与丗丆丐一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "Place", value:  this.<东丈丐丁上丝上世丐>k__BackingField);
            val_1.Add(key:  "Mode", value:  this.<世丗丁且丄丄丆七丏>k__BackingField);
            val_1.Add(key:  "Map", value:  this.<丛丐万世与丗丆丐一>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丈丌丌东丄丑丗七丈()
        {
        
        }
    
    }

}
