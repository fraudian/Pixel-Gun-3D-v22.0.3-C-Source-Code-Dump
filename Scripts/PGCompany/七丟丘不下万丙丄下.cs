using UnityEngine;

namespace PGCompany
{
    internal sealed class 七丟丘不下万丙丄下 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private System.Lazy<PGCompany.丗丟丄丈东丝丕丄世> 丌丘丏万三丒下一七;
        
        // Properties
        internal PGCompany.丗丟丄丈东丝丕丄世 不丂丅丅丝丄一丆丟 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        
        // Methods
        internal PGCompany.丗丟丄丈东丝丕丄世 不一丆丑业且丆丙三()
        {
            if(this.丌丘丏万三丒下一七 != null)
            {
                    return this.丌丘丏万三丒下一七.Value;
            }
            
            return this.丌丘丏万三丒下一七.Value;
        }
        public 七丟丘不下万丙丄下(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丌丘丏万三丒下一七 = new System.Lazy<PGCompany.丗丟丄丈东丝丕丄世>(valueFactory:  new System.Func<PGCompany.丗丟丄丈东丝丕丄世>(object:  this, method:  PGCompany.丗丟丄丈东丝丕丄世 PGCompany.七丟丘不下万丙丄下::世丒三专丞丒丘丌下()));
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_1 = this.不一丆丑业且丆丙三();
            if(val_1 == null)
            {
                    return (ItemRarity)val_1;
            }
            
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_178;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            if(this.不一丆丑业且丆丙三() == null)
            {
                    return (string)System.String.alignConst;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = this.不一丆丑业且丆丙三();
            this = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_1E8;
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            if(this.不一丆丑业且丆丙三() == null)
            {
                    return (string)System.String.alignConst;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = this.不一丆丑业且丆丙三();
            this = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_1F8;
        }
        internal override string 东且丏丆万与东丙万()
        {
            if(this.不一丆丑业且丆丙三() == null)
            {
                    return (string)System.String.alignConst;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = this.不一丆丑业且丆丙三();
            this = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_218;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            var val_6;
            if(this.不一丆丑业且丆丙三() == null)
            {
                    return (UnityEngine.Texture)val_6;
            }
            
            val_6 = this.不一丆丑业且丆丙三();
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_1C8;
        }
        internal override string 丟七万东万七丙丘丌()
        {
            if(this.不一丆丑业且丆丙三() == null)
            {
                
            }
        
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/gears");
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.七丟丘不下万丙丄下(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private PGCompany.丗丟丄丈东丝丕丄世 世丒三专丞丒丘丌下()
        {
            PGCompany.丄丂丌丞丁丙七丆三 val_1 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丐丆丅丝丂丄下业业(上七下丘一下三世丏:  this.丑丐丙丄丅世世丑丒());
            }
            
            return val_1.丐丆丅丝丂丄下业业(上七下丘一下三世丏:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
