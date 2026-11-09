using UnityEngine;

namespace PGCompany
{
    internal sealed class 丈丐东丛丗上丏丟丏 : 丕丘一丐丕上不万丁
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 与三下东不丛丂丞丌;
        
        // Methods
        public 丈丐东丛丗上丏丟丏(int 丞世不丒下上上丝丑, PGCompany.与丂丈三三东丕七丕.丟不丒专丈丌丘丈专 丁丅丈丌丟世丗丗丟, PGCompany.世丞上丏丗不丛上东 丙业丞丑七丗下丟丌, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 万三丄业丂丕丆丝丑)
        {
            this.与三下东不丛丂丞丌 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            this.与三下东不丛丂丞丌 = 万三丄业丂丕丆丝丑;
            if((this & 1) != 0)
            {
                    return;
            }
            
            if(this.专丘丈丗丕与丙丕丆() != false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丛不下一七丆丌七(东丑丞丛丆丝丅不三:  this.丒丈与东丂丕一且丄().业东丅东丌上丗丑不(), 业丌丆业丘丟丆丁丛:  this.业东丅东丌上丗丑不(), 丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与三下东不丛丂丞丌));
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 0;
        }
        protected override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄东且丂一上丈与丈()
        {
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.与三下东不丛丂丞丌;
        }
        internal override bool 丈七专与丈丝一专丁()
        {
            return (bool)(this.与三下东不丛丂丞丌.Count > 1) ? 1 : 0;
        }
        public override string ToString()
        {
            return this.ToString() + " availableItems="(" availableItems=") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.与三下东不丛丂丞丌)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.与三下东不丛丂丞丌));
        }
    
    }

}
