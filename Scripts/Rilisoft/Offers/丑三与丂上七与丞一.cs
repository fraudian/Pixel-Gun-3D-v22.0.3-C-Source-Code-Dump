using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丑三与丂上七与丞一 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
        
        // Methods
        public 丑三与丂上七与丞一(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, Rilisoft.业丙丘丆东丈丕丂丄 丙丌丛丗丙东丟专丟)
        {
            this.丂丅七与丘丞丟万丕 = 且丘丏丁丑与丙与丁;
        }
        public override bool 东一三一万且丕世不()
        {
            if(this.丂丅七与丘丞丟万丕.不业丙丒丂丞下丆丙() != 13)
            {
                    return false;
            }
            
            System.Collections.Generic.List<PGCompany.丞丞丒下三三丘丈丗> val_3 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().丗不丞一且丟丈丈丗();
            if(val_3 != null)
            {
                    return val_3.Exists(match:  new System.Predicate<PGCompany.丞丞丒下三三丘丈丗>(object:  this, method:  System.Boolean Rilisoft.Offers.丑三与丂上七与丞一::丆三丄东丌丞且丗丐(PGCompany.丞丞丒下三三丘丈丗 七丏丄丅丌业与且丙)));
            }
            
            return val_3.Exists(match:  new System.Predicate<PGCompany.丞丞丒下三三丘丈丗>(object:  this, method:  System.Boolean Rilisoft.Offers.丑三与丂上七与丞一::丆三丄东丌丞且丗丐(PGCompany.丞丞丒下三三丘丈丗 七丏丄丅丌业与且丙)));
        }
        private bool 丆三丄东丌丞且丗丐(PGCompany.丞丞丒下三三丘丈丗 七丏丄丅丌业与且丙)
        {
            PGCompany.专丟专世丅丂丁且专 val_2 = this.丂丅七与丘丞丟万丕.七丈丒丒下下且万与();
            var val_4 = 0;
            val_4 = val_4 + 1;
            return 七丏丄丅丌业与且丙.七丈丒丒下下且万与().Equals(other:  null);
        }
    
    }

}
