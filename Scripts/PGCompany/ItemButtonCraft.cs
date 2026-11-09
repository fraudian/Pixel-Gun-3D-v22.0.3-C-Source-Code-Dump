using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemButtonCraft : ItemButtonAbstract
    {
        // Fields
        private UnityEngine.Transform craftWindowPoint;
        private CraftNewItemWindowController 专丐与东下专丄与世;
        
        // Methods
        protected override void 丞丙东丌一三专丏不()
        {
            var val_52;
            int val_53;
            int val_54;
            var val_55;
            val_52 = this;
            if(丁丐丅丈丑业丒三上() == false)
            {
                    return;
            }
            
            PGCompany.StoreItemSettings val_3 = X21.丏丘下丞丘不丑万丏();
            val_53 = val_3.ItemParams.业东丅东丌上丗丑不();
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_53)) == false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  193);
            PGCompany.世东三上七丂丌下丑 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.StoreItemSettings val_8 = val_53.丏丘下丞丘不丑万丏();
            PGCompany.丗丟丄丈东丝丕丄世 val_9 = val_7.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_8.ItemParams, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            PGCompany.StoreItemSettings val_10 = val_7.丏丘下丞丘不丑万丏();
            if(val_10.ItemParams.不业丙丒丂丞下丆丙() == 70)
            {
                    PGCompany.StoreItemSettings val_13 = val_8.ItemParams.丏丘下丞丘不丑万丏();
                丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  val_13.ItemParams);
            }
            
            if(this.专丐与东下专丄与世 == 0)
            {
                    this.专丐与东下专丄与世 = CraftNewItemWindowController.下与丞三丅丛丄七丕(丞丘丞丏业且丛丏丘:  this.专丐与东下专丄与世.丒丅丙丄丞丟下丏业(), 丈东丘丏与丌东东下:  this.craftWindowPoint, 且丅丟丛丛万丝下上:  "Banners", 丒丛丞丙丙丄丛丗一:  100500);
            }
            else
            {
                    this.专丐与东下专丄与世.丈且东丑丂且万丒丅(丞丘丞丏业且丛丏丘:  val_13.ItemParams.丒丅丙丄丞丟下丏业());
            }
            
            val_53 = 1152921505577185280;
            if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() != 0)
            {
                    PGCompany.StoreListItemView val_21 = PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().丛且专丑业丆东东丝();
                val_21.丏丛不丄丑上专丐丝();
            }
            
            PGCompany.StoreItemSettings val_22 = val_21.丏丘下丞丘不丑万丏();
            三丅丁丗丗丝丂万且 val_24 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_22.ItemParams.业东丅东丌上丗丑不());
            if(val_24 == null)
            {
                goto label_42;
            }
            
            WeaponManager.丛世丝万丌丄上丒丅(丒东业不丐丑丕丄丆:  val_24.与不丞丑七丘丁丂丛());
            if((((val_24.丒万丕七专不丏丞丌() != 0) && (val_24.丒万丕七专不丏丞丌() != 1)) && (val_24.丒万丕七专不丏丞丌() != 4)) && (val_24.丒万丕七专不丏丞丌() != 5))
            {
                    if(val_24.丒万丕七专不丏丞丌() != 2)
            {
                    if(val_24.丒万丕七专不丏丞丌() != 3)
            {
                goto label_50;
            }
            
            }
            
            }
            
            Rilisoft.丞丛七上丕专丏丌丈.丌万丒丌丁上业东三();
            label_50:
            val_53 = val_24.业东丅东丌上丗丑不();
            val_54 = val_24;
            CategoryNames val_38 = val_24.丒万丕七专不丏丞丌();
            val_55 = val_38;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.Analytics.一业丗丆世世上丁且.丑东下上丏丄万丈上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞一丁业丄一一业且:  val_53, 下丒专丅丝丄丑不丏:  val_24.七丑丌专丒上丒丙七().丈一下下丞世三丑丄(), 丙丒世丂下三丑丛丝:  val_54, 丟下丟丈万一丙东丄:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_24.丗丗与丅丈且与丟丏()), 丑东与丅丐丅丂丞业:  "", 下丗丁丒丘东丂不丑:  val_38.ToString());
            goto label_70;
            label_42:
            PGCompany.StoreItemSettings val_40 = val_24.丏丘下丞丘不丑万丏();
            if(val_40.ItemParams.不业丙丒丂丞下丆丙() == 70)
            {
                    PGCompany.StoreItemSettings val_43 = this.丏丘下丞丘不丑万丏();
                PGCompany.世业业丝三丘业三下 val_45 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.世业业丝三丘业三下>(丞世不丒下上上丝丑:  val_43.ItemParams.业东丅东丌上丗丑不());
                if(val_45 != null)
            {
                    val_53 = val_45.三三三东丑丁且与万();
                val_54 = val_45.专专三世丘丙丗丂丝();
                val_55 = val_45;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                PGCompany.Analytics.一业丗丆世世上丁且.丑东下上丏丄万丈上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞一丁业丄一一业且:  val_45.业东丅东丌上丗丑不(), 下丒专丅丝丄丑不丏:  val_53, 丙丒世丂下三丑丛丝:  val_45, 丟下丟丈万一丙东丄:  val_54, 丑东与丅丐丅丂丞业:  "", 下丗丁丒丘东丂不丑:  val_45.ToString());
            }
            
            }
            
            label_70:
            val_52 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_52.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public ItemButtonCraft()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
