using UnityEngine;

namespace Rilisoft
{
    public sealed class 业不丂丛丂丘丁丘丟 : EventArgs
    {
        // Fields
        private string <丆丆东丝三丕与专丄>k__BackingField;
        
        // Properties
        public string 丞丁万七上丐丌世业 { get; set; }
        
        // Methods
        public string 丒丅三且七业丐丌丌()
        {
            return (string)this.<丆丆东丝三丕与专丄>k__BackingField;
        }
        public void 下丗一万且下与丙七(string 丙业与丙丗丝不丈东)
        {
            this.<丆丆东丝三丕与专丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "point", value:  this.<丆丆东丝三丕与专丄>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 业不丂丛丂丘丁丘丟()
        {
        
        }
    
    }

}
