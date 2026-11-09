using UnityEngine;

namespace Rilisoft
{
    public class FortItemEffectFreeCoins : FortItemEffectPerInterval
    {
        // Properties
        protected override long 丟丞东丘丁丕丕七不 { get; }
        
        // Methods
        protected override long 丞丏丝世七不丐不业()
        {
            return 86400;
        }
        protected override bool 三丛丁丆东世丁丏三(int 丑且下丁丏丕丕七丈)
        {
            MainMenuController val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Func<FortItemBuff, System.Boolean> val_19;
            var val_20;
            System.Func<FortItemBuff, System.Single> val_22;
            var val_23;
            var val_24;
            if(true != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_14 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_14 != 0)
            {
                    val_16 = null;
                val_16 = null;
                val_14 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_14 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    int val_14 = UnityEngine.Mathf.Min(a:  丑且下丁丏丕丕七丈, b:  3);
                val_17 = null;
                val_17 = null;
                val_19 = FortItemEffectFreeCoins.<>c.<>9__2_0;
                if(val_19 == null)
            {
                    System.Func<FortItemBuff, System.Boolean> val_6 = null;
                val_19 = val_6;
                val_6 = new System.Func<FortItemBuff, System.Boolean>(object:  FortItemEffectFreeCoins.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortItemEffectFreeCoins.<>c::且一与丝丞世丈不丅(丞东丌丟与丅丅万丝.FortItemBuff 丌丗丏丏丛东专丁且));
                FortItemEffectFreeCoins.<>c.<>9__2_0 = val_19;
            }
            
                val_20 = null;
                val_20 = null;
                val_22 = FortItemEffectFreeCoins.<>c.<>9__2_1;
                if(val_22 == null)
            {
                    System.Func<FortItemBuff, System.Single> val_8 = null;
                val_22 = val_8;
                val_8 = new System.Func<FortItemBuff, System.Single>(object:  FortItemEffectFreeCoins.<>c.__il2cppRuntimeField_static_fields, method:  System.Single FortItemEffectFreeCoins.<>c::丟丈业丘万下丞下丟(丞东丌丟与丅丅万丝.FortItemBuff 东丝丄丝丙专丘三丏));
                FortItemEffectFreeCoins.<>c.<>9__2_1 = val_22;
            }
            
                val_23 = null;
                val_23 = null;
                val_14 = val_14 * ((int)System.Linq.Enumerable.Sum(source:  System.Linq.Enumerable.Select<FortItemBuff, System.Single>(source:  System.Linq.Enumerable.Where<FortItemBuff>(source:  丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万(), predicate:  val_6), selector:  val_8)));
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丗世丈丂丒丞专上丟:  val_14, 世丁丙世丄一万丆三:  3, 丛丞万三下丘七丌丅:  true);
                val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3002");
                this.不丒丂丕丅丌世专三(上丒丆丆丞且丐丆七:  System.String.Format(format:  val_14, arg0:  val_14));
                val_24 = 1;
                return (bool)val_24;
            }
            
            }
            
            }
            
            val_24 = 0;
            return (bool)val_24;
        }
        public FortItemEffectFreeCoins()
        {
            val_1 = new Rilisoft.FortItemEffectHandler();
        }
    
    }

}
