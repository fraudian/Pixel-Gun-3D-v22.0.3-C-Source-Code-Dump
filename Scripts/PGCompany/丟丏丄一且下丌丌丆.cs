using UnityEngine;

namespace PGCompany
{
    public sealed class 丟丏丄一且下丌丌丆
    {
        // Fields
        private static System.Action 丅丐丅专一下东丅上;
        
        // Methods
        internal static void 丄不丌且三上业丂三(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.丟丏丄一且下丌丌丆.丅丐丅专一下东丅上, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 不丌丄丟丌丁丄丐丞(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.丟丏丄一且下丌丌丆.丅丐丅专一下东丅上, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static bool 丑丘东且与不丅丗世(int 丞丏上业丞与丂三上, out string 丒丄丝不丄专丕与丕)
        {
            var val_7;
            string val_8;
            .丞丏上业丞与丂三上 = 丞丏上业丞与丂三上;
            丒丄丝不丄专丕与丕 = System.String.alignConst;
            PGCompany.与万丝丞下丒丗丏丙 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.与万丝丞下丒丗丏丙>(source:  PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().下下丐一不丅不丒下(), predicate:  new System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Boolean>(object:  new 丟丏丄一且下丌丌丆.上丌专丄丘丂东且丒(), method:  System.Boolean 丟丏丄一且下丌丌丆.上丌专丄丘丂东且丒::丟一丛丁丑丞三一丐(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
            if(val_5 == null)
            {
                goto label_3;
            }
            
            if(val_5.丅业东万丌丕上丌丄() == false)
            {
                goto label_4;
            }
            
            val_8 = "promotion just active";
            val_7 = 0;
            goto label_5;
            label_3:
            val_8 = "promotion not found";
            label_5:
            丒丄丝不丄专丕与丕 = val_8;
            return (bool)val_7;
            label_4:
            val_5.丟上且且上业丂丐丈();
            if(PGCompany.丟丏丄一且下丌丌丆.丅丐丅专一下东丅上 != null)
            {
                    PGCompany.丟丏丄一且下丌丌丆.丅丐丅专一下东丅上.Invoke();
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        public 丟丏丄一且下丌丌丆()
        {
        
        }
    
    }

}
