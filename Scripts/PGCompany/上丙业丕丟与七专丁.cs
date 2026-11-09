using UnityEngine;

namespace PGCompany
{
    internal sealed class 上丙业丕丟与七专丁 : 丌丐下丌丘下丝丞业
    {
        // Fields
        private System.Lazy<PGCompany.BuffData> 丂丛丏丝万丕与丐丐;
        
        // Properties
        internal PGCompany.BuffData 丞丑且东丌与丏丏丁 { get; }
        
        // Methods
        internal PGCompany.BuffData 丁专丗万三上丟三丆()
        {
            if(this.丂丛丏丝万丕与丐丐 != null)
            {
                    return this.丂丛丏丝万丕与丐丐.Value;
            }
            
            return this.丂丛丏丝万丕与丐丐.Value;
        }
        public 上丙业丕丟与七专丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丂丛丏丝万丕与丐丐 = new System.Lazy<PGCompany.BuffData>(valueFactory:  new System.Func<PGCompany.BuffData>(object:  this, method:  PGCompany.BuffData PGCompany.上丙业丕丟与七专丁::世丒三专丞丒丘丌下()));
        }
        internal System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与> 世丙万丞上与一丌丅()
        {
            System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与> val_5;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    PGCompany.BuffData val_2 = this.丁专丗万三上丟三丆();
                if(val_2.Properties != null)
            {
                    PGCompany.BuffData val_3 = this.丁专丗万三上丟三丆();
                val_5 = val_3.Properties;
                return (System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与>)val_5;
            }
            
            }
            
            System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与> val_4 = null;
            val_5 = val_4;
            val_4 = new System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与>();
            return (System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与>)val_5;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Buffs/"("OfferIcons/Buffs/") + this.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Buffs/"("OfferIcons/Buffs/") + this.业上丙丞丐丄丆丅七() + "_mini");
        }
        internal override string 东且丏丆万与东丙万()
        {
            return (string)this.东且丏丆万与东丙万(不丗丆专业丈丞东七:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "{0}_Description_{1}", arg0:  this.不业丙丒丂丞下丆丙(), arg1:  this.业上丙丞丐丄丆丅七())));
        }
        internal string 东且丏丆万与东丙万(string 不丗丆专业丈丞东七)
        {
            string val_12 = 不丗丆专业丈丞东七;
            System.Collections.Generic.List<PGCompany.三丏不丆丈且丐东与> val_1 = this.世丙万丞上与一丌丅();
            int val_2 = val_1.Count;
            if(val_2 < 1)
            {
                    return (string)val_12;
            }
            
            do
            {
                int val_9 = val_1.Item[0].世三丞丅丑丌丈丈一();
                val_12 = val_12.Replace(oldValue:  new System.Text.StringBuilder().Append(value:  "{").Append(value:  0.ToString()).Append(value:  "}"), newValue:  8388608f.ToString());
            }
            while(1 < val_2);
            
            return (string)val_12;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.上丙业丕丟与七专丁(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private PGCompany.BuffData 世丒三专丞丒丘丌下()
        {
            PGCompany.BuffController val_1 = PGCompany.BuffController.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丁丈丑丝丟丞一丌不(丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不());
            }
            
            return val_1.丁丈丑丝丟丞一丌不(丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不());
        }
    
    }

}
