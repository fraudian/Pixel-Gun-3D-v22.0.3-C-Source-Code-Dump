using UnityEngine;

namespace Rilisoft
{
    public sealed class 丙专丈丛东下上丑丏 : EventArgs
    {
        // Fields
        private string <且丂东七丘不丑丆下>k__BackingField;
        private int <丛丒丝东丆万丁七上>k__BackingField;
        private int <上七丄丂丝下丛丗丁>k__BackingField;
        
        // Properties
        public string 丛丟东世万丒丐且世 { get; set; }
        public int 专不专丟丝丐三七专 { get; set; }
        public int 下世三丌七丟七与万 { get; set; }
        
        // Methods
        public string 东与三丌丅三丒丏业()
        {
            return (string)this.<且丂东七丘不丑丆下>k__BackingField;
        }
        public void 丆丏丌专丏丐丑丙丒(string 丙业与丙丗丝不丈东)
        {
            this.<且丂东七丘不丑丆下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int 丒与且不业丏丑且一()
        {
            return (int)this.<丛丒丝东丆万丁七上>k__BackingField;
        }
        public void 丒与丑上一万专下一(int 丙业与丙丗丝不丈东)
        {
            this.<丛丒丝东丆万丁七上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int 丛下丐且丘丘一且三()
        {
            return (int)this.<上七丄丂丝下丛丗丁>k__BackingField;
        }
        public void 丁丙丝一专丘上不七(int 丙业与丙丗丝不丈东)
        {
            this.<上七丄丂丝下丛丗丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "currency", value:  this.<且丂东七丘不丑丆下>k__BackingField);
            val_1.Add(key:  "newValue", value:  this.<丛丒丝东丆万丁七上>k__BackingField);
            val_1.Add(key:  "addedValue", value:  this.<上七丄丂丝下丛丗丁>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丙专丈丛东下上丑丏()
        {
        
        }
    
    }

}
