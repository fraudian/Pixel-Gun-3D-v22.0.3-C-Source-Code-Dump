using UnityEngine;

namespace PGCompany
{
    internal sealed class 丆丅三丁七世一丑丝
    {
        // Fields
        private static PGCompany.丆丅三丁七世一丑丝 世丒丞七专三与万丕;
        
        // Properties
        internal static PGCompany.丆丅三丁七世一丑丝 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.丆丅三丁七世一丑丝 丑七不且上丗丁一世()
        {
            PGCompany.丆丅三丁七世一丑丝 val_2 = PGCompany.丆丅三丁七世一丑丝.世丒丞七专三与万丕;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.丆丅三丁七世一丑丝 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丆丅三丁七世一丑丝();
            PGCompany.丆丅三丁七世一丑丝.世丒丞七专三与万丕 = val_2;
            return val_2;
        }
        internal void 一丗上丝丛丕丌丕丙()
        {
            var val_7;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return;
            }
            
            val_7 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            if((val_7.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  80)) != 0)
            {
                    return;
            }
            
            val_7 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_7 < BalanceController.丄下丛丅丒丙丞不丙())
            {
                    return;
            }
            
            val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_7.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  80, 丙业与丙丗丝不丈东:  1);
        }
        private 丆丅三丁七世一丑丝()
        {
            MainStoreView.一与与一世丑丒与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丆丅三丁七世一丑丝::一丗上丝丛丕丌丕丙()));
        }
    
    }

}
