using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemButtonEquip : ItemButtonAbstract
    {
        // Methods
        protected override void 丞丙东丌一三专丏不()
        {
            丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  丒丅丙丄丞丟下丏业());
            if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().丛且专丑业丆东东丝().丏丛不丄丑上专丐丝();
        }
        public ItemButtonEquip()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
