using UnityEngine;

namespace Rilisoft
{
    public sealed class 丄丂丐丐丏丙丈且丆 : EventArgs
    {
        // Fields
        private CategoryNames <丌丒丁且东专上丝不>k__BackingField;
        private bool <丞丕东丆丁丅丌七丂>k__BackingField;
        private Rilisoft.七丕丟丏三丈一丄世 <世丗丁且丄丄丆七丏>k__BackingField;
        private string <丛丐万世与丗丆丐一>k__BackingField;
        private int <一万丂丟不丛丟下世>k__BackingField;
        private int <丞一七七丆丒与业丐>k__BackingField;
        
        // Properties
        public CategoryNames 丞丏万丏一下上丁丝 { get; set; }
        public bool 丟与丗丒丅万东丞丛 { get; set; }
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; set; }
        internal string 一丘东丌丑且丏一丙 { get; set; }
        internal int 三丌上丁一丟丐丟丈 { get; set; }
        internal int 丁且上万且丝丟且丏 { get; set; }
        
        // Methods
        public CategoryNames 丄丄世七三业丝丛丘()
        {
            return (CategoryNames)this.<丌丒丁且东专上丝不>k__BackingField;
        }
        public void 丛丒丌世万丒上七一(CategoryNames 丙业与丙丗丝不丈东)
        {
            this.<丌丒丁且东专上丝不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool 丞万丑丝丙上与世丛()
        {
            return (bool)this.<丞丕东丆丁丅丌七丂>k__BackingField;
        }
        public void 丝丁专丝丙丞业丈丑(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丕东丆丁丅丌七丂>k__BackingField = 丙业与丙丗丝不丈东;
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
        internal int 丝一丙丘专七丕不上()
        {
            return (int)this.<一万丂丟不丛丟下世>k__BackingField;
        }
        internal void 丂丙丗丗三与丌丙世(int 丙业与丙丗丝不丈东)
        {
            this.<一万丂丟不丛丟下世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 专丗丕丁丆三不丙丌()
        {
            return (int)this.<丞一七七丆丒与业丐>k__BackingField;
        }
        internal void 丒东一世丅且七丏丝(int 丙业与丙丗丝不丈东)
        {
            this.<丞一七七丆丒与业丐>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "weaponSlot", value:  this.<丌丒丁且东专上丝不>k__BackingField);
            val_1.Add(key:  "campaign", value:  this.<丞丕东丆丁丅丌七丂>k__BackingField);
            val_1.Add(key:  "mode", value:  this.<世丗丁且丄丄丆七丏>k__BackingField);
            val_1.Add(key:  "itemIndex", value:  this.<一万丂丟不丛丟下世>k__BackingField);
            val_1.Add(key:  "mobRole", value:  this.<丞一七七丆丒与业丐>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丄丂丐丐丏丙丈且丆()
        {
        
        }
    
    }

}
