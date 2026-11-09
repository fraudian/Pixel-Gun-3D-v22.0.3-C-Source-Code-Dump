using UnityEngine;

namespace PGCompany
{
    internal sealed class 丝丟丅丏丟丞不丌七 : 丐三丛丑丛丟七丕丛
    {
        // Fields
        private System.Lazy<PGCompany.ModulePointData> 丁丘丄丕下专东七不;
        private System.Lazy<PGCompany.丏丂一丗丙世丏丐三> 丙丄七万三丁丆丅丅;
        
        // Properties
        internal PGCompany.ModulePointData 丞丑且东丌与丏丏丁 { get; }
        internal PGCompany.ModuleData.ModuleType 丗丑不丁丐丄丑丑东 { get; }
        internal PGCompany.ModuleData.ModuleCategory 一上世与丅丕丅丞丏 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal PGCompany.丏丂一丗丙世丏丐三 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal PGCompany.ModulePointData 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return this.丁丘丄丕下专东七不.Value;
            }
            
            return this.丁丘丄丕下专东七不.Value;
        }
        internal PGCompany.ModuleData.ModuleType 与丝丅丘且丐上丅世()
        {
            PGCompany.丏丂一丗丙世丏丐三 val_1 = this.丑且一丐东三不丈丝();
            if(val_1 == null)
            {
                    return (ModuleType)val_1;
            }
            
            return val_1.与丝丅丘且丐上丅世();
        }
        internal PGCompany.ModuleData.ModuleCategory 万丕丅下上丄丗万丞()
        {
            PGCompany.丏丂一丗丙世丏丐三 val_1 = this.丑且一丐东三不丈丝();
            if(val_1 == null)
            {
                    return (ModuleCategory)val_1;
            }
            
            return val_1.万丕丅下上丄丗万丞();
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            PGCompany.丏丂一丗丙世丏丐三 val_1 = this.丑且一丐东三不丈丝();
            if(val_1 == null)
            {
                    return (ItemRarity)val_1;
            }
            
            return val_1.七东与丄丕丁丛世三();
        }
        internal PGCompany.丏丂一丗丙世丏丐三 丑且一丐东三不丈丝()
        {
            if(this.丙丄七万三丁丆丅丅 != null)
            {
                    return this.丙丄七万三丁丆丅丅.Value;
            }
            
            return this.丙丄七万三丁丆丅丅.Value;
        }
        public 丝丟丅丏丟丞不丌七(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            丝丟丅丏丟丞不丌七.丒丛丁与丅东丒不七 val_1 = new 丝丟丅丏丟丞不丌七.丒丛丁与丅东丒不七();
            if(val_1 != null)
            {
                    .丈丄不七三万丄丁不 = 丈丄不七三万丄丁不;
            }
            else
            {
                    mem[16] = 丈丄不七三万丄丁不;
            }
            
            .丝且与丝丒丟万丁专 = this;
            this.丁丘丄丕下专东七不 = new System.Lazy<PGCompany.ModulePointData>(valueFactory:  new System.Func<PGCompany.ModulePointData>(object:  val_1, method:  PGCompany.ModulePointData 丝丟丅丏丟丞不丌七.丒丛丁与丅东丒不七::下不丕丈万丑不丛下()));
            this.丙丄七万三丁丆丅丅 = new System.Lazy<PGCompany.丏丂一丗丙世丏丐三>(valueFactory:  new System.Func<PGCompany.丏丂一丗丙世丏丐三>(object:  val_1, method:  PGCompany.丏丂一丗丙世丏丐三 丝丟丅丏丟丞不丌七.丒丛丁与丅东丒不七::上丌与丟东丂专万万()));
        }
        internal override PGCompany.业丞且丞丁丅丏丏丐 丞不丑丕丕丛丆世且()
        {
            PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丌世丑丄东丞丘三<PGCompany.业丞且丞丁丅丏丏丐>(丞世不丒下上上丝丑:  this.丁专丗万三上丟三丆().IndexItemModule);
            }
            
            return val_1.一丌世丑丄东丞丘三<PGCompany.业丞且丞丁丅丏丏丐>(丞世不丒下上上丝丑:  this.丁专丗万三上丟三丆().IndexItemModule);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丝丟丅丏丟丞不丌七(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
