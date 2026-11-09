using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemButtonUpgrade : ItemButtonAbstract
    {
        // Methods
        protected override void 丞丙东丌一三专丏不()
        {
            if(万万万丑丘丈丘万丒() == false)
            {
                    return;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_2 = 丒丟丈专万丐丆丁丗();
            bool val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_2, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_4 != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  193);
                PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  val_2, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
                bool val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_2.丒丅丙丄丞丟下丏业(), 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = false});
                this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                this.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                return;
            }
            
            val_4.万丞丌七丈丄丙东万(丒世丘丘上丆丝东丞:  val_2);
        }
        public ItemButtonUpgrade()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
