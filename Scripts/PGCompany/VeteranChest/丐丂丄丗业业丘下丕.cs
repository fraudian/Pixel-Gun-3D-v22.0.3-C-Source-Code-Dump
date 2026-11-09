using UnityEngine;

namespace PGCompany.VeteranChest
{
    internal class 丐丂丄丗业业丘下丕
    {
        // Fields
        private static PGCompany.VeteranChest.丐丂丄丗业业丘下丕 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.VeteranChest.丐丂丄丗业业丘下丕 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.VeteranChest.丐丂丄丗业业丘下丕 丑七不且上丗丁一世()
        {
            PGCompany.VeteranChest.丐丂丄丗业业丘下丕 val_2 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.VeteranChest.丐丂丄丗业业丘下丕 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.VeteranChest.丐丂丄丗业业丘下丕();
            PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        private 丐丂丄丗业业丘下丕()
        {
        
        }
        internal int 且七丘丝且世丅上丏()
        {
            string val_6;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丐丕丅丘万丞七丐上();
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  val_2)) != false)
            {
                    return 0;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_4 = val_2.Item[0];
            if(val_4 != null)
            {
                    val_6 = val_4.业上丙丞丐丄丆丅七();
                return Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  val_6 = 0);
            }
            
            return Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  val_6);
        }
        internal PGCompany.三东丏不丗世丅丌丄 丝丁丝上丞丅三丑七()
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丐丕丅丘万丞七丐上();
            if(val_2 == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_5;
            }
            
            if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_2)) != false)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_4 = val_2.Item[0];
                return (PGCompany.三东丏不丗世丅丌丄)val_5;
            }
            
            val_5 = 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_5;
        }
        internal bool 三不专丗七丄且丝业()
        {
            var val_5;
            if(ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().且万丈下东下丙丘且() != false)
            {
                    var val_4 = (ExperienceController.丞丞丘业东丙丏七丌() > 64) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        internal bool 丄丛丒业丙万丅丏丌()
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = this.丝丁丝上丞丅三丑七();
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_1)) == false)
            {
                    return false;
            }
            
            if(val_1.不业丙丒丂丞下丆丙() == 1460)
            {
                    PGCompany.LootBoxSystem.七丈三丂且丗丈世一 val_4 = PGCompany.LootBoxSystem.七丈三丂且丗丈世一.丑七不且上丗丁一世();
                if(val_4 != null)
            {
                    return val_4.不与丛上丐与不丛丆(丆专且丕专丗与一丏:  val_1.业东丅东丌上丗丑不());
            }
            
                return val_4.不与丛上丐与不丛丆(丆专且丕专丗与一丏:  val_1.业东丅东丌上丗丑不());
            }
            
            Rilisoft.三一丈七且丄与丝东 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_6 != null)
            {
                    return val_6.丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  100);
            }
            
            return val_6.丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  100);
        }
        internal bool 世东丑丁上业专丏丙()
        {
            var val_3;
            bool val_1 = this.三不专丗七丄且丝业();
            if(val_1 == false)
            {
                goto label_0;
            }
            
            bool val_2 = val_1.下丆一丄丅丙与丟丙();
            if(val_2 == false)
            {
                goto label_1;
            }
            
            return val_2.丐下专丑丕一丁丛东();
            label_0:
            val_3 = 0;
            return (bool)val_3;
            label_1:
            val_3 = 1;
            return (bool)val_3;
        }
        internal bool 丐下专丑丕一丁丛东()
        {
            bool val_1 = this.三不专丗七丄且丝业();
            if(val_1 == false)
            {
                    return false;
            }
            
            if(val_1.丄丛丒业丙万丅丏丌() == false)
            {
                    return false;
            }
            
            ExpOpenSystem.丌下上业与且丁丄三 val_3 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世();
            if(val_3 != null)
            {
                    return val_3.专东七世且丘业丑丌();
            }
            
            return val_3.专东七世且丘业丑丌();
        }
        internal PGCompany.DataObjects.IntInterval 丄丟丒丁丙三丞丗丒()
        {
            return (PGCompany.DataObjects.IntInterval)new PGCompany.DataObjects.IntInterval(丈丗与丞一上且上上:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丅丂七上一业一丐三(), 专丂丕丗丗东世丞下:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丑一专与丝丏丂丆上());
        }
        internal bool 下丆一丄丅丙与丟丙()
        {
            Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  74);
            }
            
            return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  74);
        }
        internal void 业丏丅丟丟丕丑下三()
        {
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  74)) != false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  74);
        }
        internal void 七丏丞东丂丈不七丝(丝不丘丞丈万丈一上 世丁丙世丄一万丆三)
        {
            ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丅丁东丐丄丛丗东世(世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
        }
    
    }

}
