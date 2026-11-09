using UnityEngine;

namespace PGCompany.Store.MainStore
{
    internal class 业一东丌丑丑丒丒丌 : 丟丌丛丁丑与丙世丟
    {
        // Fields
        internal static readonly System.Collections.Generic.List<BankView.BankViewTab> 丑丝专丐与与业丏丗;
        
        // Methods
        internal override void 丈丙且一万丟丕万下()
        {
            var val_9;
            string val_10;
            val_9 = this;
            if(97489 == 0)
            {
                    return;
            }
            
            val_10 = 0;
            TagSystem.三与下丘七丘丌丏丄 val_1 = 97489.与不丞丑七丘丁丂丛();
            if(val_1 != null)
            {
                    val_10 = "state.purchased";
                bool val_2 = val_1.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_10);
                if(val_2 == true)
            {
                    return;
            }
            
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            if((业东丅东丌上丗丑不() == 10015) || (业东丅东丌上丗丑不() == 11015))
            {
                goto label_11;
            }
            
            PGCompany.世东三上七丂丌下丑 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_5.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  X21, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_14;
            }
            
            label_11:
            this.丏丝丘七丕与世丅丆();
            return;
            label_14:
            this.万丞丌七丈丄丙东万(丄专万万丝丐三丆丄:  val_5.业上丙丞丐丄丆丅七());
        }
        private void 万丞丌七丈丄丙东万(string 丄专万万丝丐三丆丄)
        {
            var val_5 = null;
            BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.Store.MainStore.业一东丌丑丑丒丒丌.丑丝专丐与与业丏丗);
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Store.MainStore.业一东丌丑丑丒丒丌::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丄专万万丝丐三丆丄, 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  "");
        }
        private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Store.MainStore.业一东丌丑丑丒丒丌::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        public 业一东丌丑丑丒丒丌()
        {
        
        }
        private static 业一东丌丑丑丒丒丌()
        {
            System.Collections.Generic.List<BankViewTab> val_1 = new System.Collections.Generic.List<BankViewTab>();
            if(val_1 != null)
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  5);
                val_1.Add(item:  2);
            }
            else
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  5);
                val_1.Add(item:  2);
            }
            
            val_1.Add(item:  8);
            PGCompany.Store.MainStore.业一东丌丑丑丒丒丌.丑丝专丐与与业丏丗 = val_1;
        }
    
    }

}
