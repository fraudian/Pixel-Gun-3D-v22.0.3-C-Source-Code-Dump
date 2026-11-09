using UnityEngine;

namespace Rilisoft
{
    internal class FortItemEffectFreeSpins : FortItemEffectPerInterval
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
            MainMenuController val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Func<FortItemBuff, System.Boolean> val_21;
            var val_22;
            System.Func<FortItemBuff, System.Single> val_24;
            var val_25;
            if(true == 0)
            {
                    return false;
            }
            
            val_16 = null;
            val_16 = null;
            val_15 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_15 == 0)
            {
                    return false;
            }
            
            val_17 = null;
            val_17 = null;
            val_15 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_15 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
            if(activeInHierarchy == false)
            {
                    return false;
            }
            
            val_18 = null;
            val_18 = null;
            val_15 = GiftController.丆丕丝丒不丙且丐丗;
            if(val_15 == 0)
            {
                    return false;
            }
            
            int val_15 = UnityEngine.Mathf.Min(a:  丑且下丁丏丕丕七丈, b:  3);
            val_19 = null;
            val_19 = null;
            val_21 = FortItemEffectFreeSpins.<>c.<>9__2_0;
            if(val_21 == null)
            {
                    System.Func<FortItemBuff, System.Boolean> val_7 = null;
                val_21 = val_7;
                val_7 = new System.Func<FortItemBuff, System.Boolean>(object:  FortItemEffectFreeSpins.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortItemEffectFreeSpins.<>c::且一与丝丞世丈不丅(丞东丌丟与丅丅万丝.FortItemBuff 丌丗丏丏丛东专丁且));
                FortItemEffectFreeSpins.<>c.<>9__2_0 = val_21;
            }
            
            val_22 = null;
            val_22 = null;
            val_24 = FortItemEffectFreeSpins.<>c.<>9__2_1;
            if(val_24 == null)
            {
                    System.Func<FortItemBuff, System.Single> val_9 = null;
                val_24 = val_9;
                val_9 = new System.Func<FortItemBuff, System.Single>(object:  FortItemEffectFreeSpins.<>c.__il2cppRuntimeField_static_fields, method:  System.Single FortItemEffectFreeSpins.<>c::丟丈业丘万下丞下丟(丞东丌丟与丅丅万丝.FortItemBuff 东丝丄丝丙专丘三丏));
                FortItemEffectFreeSpins.<>c.<>9__2_1 = val_24;
            }
            
            val_25 = null;
            val_25 = null;
            val_15 = val_15 * ((int)System.Linq.Enumerable.Sum(source:  System.Linq.Enumerable.Select<FortItemBuff, System.Single>(source:  System.Linq.Enumerable.Where<FortItemBuff>(source:  val_15.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万(), predicate:  val_7), selector:  val_9)));
            int val_12 = GiftController.丆丕丝丒不丙且丐丗.IncrementFreeSpins(丏业下一丑丄丐丘三:  val_15);
            this.不丒丂丕丅丌世专三(上丒丆丆丞且丐丆七:  System.String.Format(format:  "{0} {1}", arg0:  val_15, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3807")));
            return false;
        }
        public FortItemEffectFreeSpins()
        {
            val_1 = new Rilisoft.FortItemEffectHandler();
        }
    
    }

}
