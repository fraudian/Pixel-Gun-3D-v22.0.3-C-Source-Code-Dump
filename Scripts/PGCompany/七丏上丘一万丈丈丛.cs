using UnityEngine;

namespace PGCompany
{
    internal static class 七丏上丘一万丈丈丛
    {
        // Methods
        internal static bool 业丒丅丘一丞丆万丆(PGCompany.下丄丄丞三且丒下业 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄.Type == 0)
            {
                    return true;
            }
            
            return PGCompany.ItemSystem.丈丒丕丂七丄不世丕.丂丆世世丕丅丕丅上(三丏丅下专丛七丒丂:  一丐丗丁丞丆丅丟丄.Type, 丟业丅下下不不丐丄:  一丐丗丁丞丆丅丟丄.ItemParams);
        }
        internal static PGCompany.丙一丟与且丞丏丈一 下丛丌丐丗丒且且业(int 丞世不丒下上上丝丑, int 与丕丌丒丗丄丘丙东)
        {
            return (PGCompany.丙一丟与且丞丏丈一)new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  System.String.Format(format:  "universal-{0}_{1}", arg0:  丞世不丒下上上丝丑, arg1:  与丕丌丒丗丄丘丙东));
        }
        internal static int 与上丞业丁丗丒业世(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            string val_7;
            object val_8;
            char[] val_3 = new char[1];
            val_3[0] = '_';
            val_7 = 一丗与一专丙丙丅丄.七万丅丆且丁世丏丈().Replace(oldValue:  "universal-", newValue:  "").Split(separator:  val_3);
            if(val_4.Length >= 1)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_5 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_7[0]);
                if(((ulong)(val_5.Item2 >> 32) & 255) != 0)
            {
                    val_7 = val_7[0];
                val_8 = val_7;
                System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8);
                return (int)val_8;
            }
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        internal static void 世世与丁与业丞与世(System.Collections.Generic.List<PGCompany.Attributes.丒丏丆且丕三丘丘丐> 一七下东一万丂世与, PGCompany.丏业且丛丌一专丝世 一丑丑丝丏且丂丏丘)
        {
            var val_11;
            var val_19;
            .一丑丑丝丏且丂丏丘 = 一丑丑丝丏且丂丏丘;
            System.Predicate<PGCompany.Attributes.丒丏丆且丕三丘丘丐> val_2 = new System.Predicate<PGCompany.Attributes.丒丏丆且丕三丘丘丐>(object:  new 七丏上丘一万丈丈丛.上丌专丄丘丂东且丒(), method:  System.Boolean 七丏上丘一万丈丈丛.上丌专丄丘丂东且丒::丑下与一七七丗丌丐(PGCompany.Attributes.丒丏丆且丕三丘丘丐 一丐丗丁丞丆丅丟丄));
            if(一七下东一万丂世与 != null)
            {
                    val_19 = 一七下东一万丂世与.FindAll(match:  val_2);
            }
            else
            {
                    val_19 = 0.FindAll(match:  val_2);
            }
            
            if(一七下东一万丂世与.Count == 0)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  158);
            if(val_19 != null)
            {
                    int val_7 = val_19.Count;
            }
            else
            {
                    int val_8 = 0.Count;
            }
            
            List.Enumerator<T> val_9 = val_19.GetEnumerator();
            label_18:
            if(((-15445456) & 1) == 0)
            {
                goto label_10;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_16 = PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丈丄专丙丝丑丒丗丈<System.Int32>(世三三丁丕丐丘丐丟:  val_12, 上丄业丑且一万丁丞:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  val_12.万东丏一且丛东丐丛(), 丙业与丙丗丝不丈东:  val_12 + 40), 专丒丌丆下丐丞丟丞:  0, 一丗丈丛万丄世一丘:  "UniversalPromotion");
            goto label_18;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_19 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_19.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
    
    }

}
