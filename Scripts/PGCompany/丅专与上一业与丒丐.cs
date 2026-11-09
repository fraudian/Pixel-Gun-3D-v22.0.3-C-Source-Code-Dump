using UnityEngine;

namespace PGCompany
{
    internal sealed class 丅专与上一业与丒丐 : 丌与世世丆丄丞丌世
    {
        // Methods
        internal override void 东丞丐业丂丞不丕丈<T>(T 丞万丕丏东与丑下丕)
        {
            int val_24;
            PGCompany.三东丏不丗世丅丌丄 val_25;
            string val_26;
            var val_28;
            var val_29;
            val_24 = System.String.alignConst;
            val_25 = mem[__RuntimeMethodHiddenParam + 48];
            val_25 = __RuntimeMethodHiddenParam + 48;
            if(丞万丕丏东与丑下丕 == 0)
            {
                goto label_2;
            }
            
            val_26 = 丞万丕丏东与丑下丕.业丄丁丘丝东丗业与();
            丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_4;
            }
            
            string val_4 = val_3.业丐丐三丕一丗丛丁();
            goto label_5;
            label_2:
            if(丞万丕丏东与丑下丕 == 0)
            {
                goto label_7;
            }
            
            val_26 = 丞万丕丏东与丑下丕.业丄丁丘丝东丗业与();
            if(丞万丕丏东与丑下丕.上丌丆且世专不世丝() == false)
            {
                goto label_10;
            }
            
            label_5:
            val_24 = 丞万丕丏东与丑下丕.丁丏业丄丏丞丟万且();
            goto label_10;
            label_4:
            val_24 = 0;
            goto label_10;
            label_7:
            val_26 = val_24;
            label_10:
            if((System.String.IsNullOrEmpty(value:  val_26)) == true)
            {
                    return;
            }
            
            val_25 = val_25.与丂三丟业丘与丅三();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_25, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> val_12 = new System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛>();
            List.Enumerator<T> val_13 = val_25.GetEnumerator();
            label_26:
            if(((-203559808) & 1) == 0)
            {
                goto label_17;
            }
            
            new PGCompany.GiftSystem.丏下丙丂万且一丑丛() = new PGCompany.GiftSystem.丏下丙丂万且一丑丛();
            new PGCompany.GiftSystem.丏下丙丂万且一丑丛().业业丙丁东一上东丑(丙业与丙丗丝不丈东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            new PGCompany.GiftSystem.丏下丙丂万且一丑丛().丑丛丑丝丗丆丑且丙(丙业与丙丗丝不丈东:  val_26);
            new PGCompany.GiftSystem.丏下丙丂万且一丑丛().丗丘万丛与万丘丗下(丙业与丙丗丝不丈东:  val_24);
            new PGCompany.GiftSystem.丏下丙丂万且一丑丛().万丅世世丐东丙丒丙().Add(item:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  0.丐丏七丌丕丗业且上()));
            val_12.Add(item:  new PGCompany.GiftSystem.丏下丙丂万且一丑丛());
            goto label_26;
            label_17:
            val_28 = 0;
            val_29 = 0;
            var val_22 = 0;
            val_22 = val_22 + 1;
            null.Dispose();
            PGCompany.GiftSystem.业三东上与丁丁专三 val_19 = PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世();
            val_19.丞丈丞三上丆上丌丆(与专丁丈七丞三与丕:  val_12, 丈丗下七且丏三专丛:  val_28.与丂三丟业丘与丅三());
            this.丆丌丄业丙丘丅七世(且丘丏丁丑与丙与丁:  val_12.七丈丒丒下下且万与(), 丛丐与丌丑专丑七丄:  val_19, 一丐丗丁丞丆丅丟丄:  0);
        }
        public override void Dispose()
        {
        
        }
        public 丅专与上一业与丒丐()
        {
        
        }
    
    }

}
