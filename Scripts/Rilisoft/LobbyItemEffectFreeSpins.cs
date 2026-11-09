using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemEffectFreeSpins : LobbyItemEffectPerInterval
    {
        // Fields
        private Rilisoft.丅丌丌丐丘丕丟丏丝 丁丏东专丐不三丛丗;
        
        // Properties
        protected override Rilisoft.丅丌丌丐丘丕丟丏丝 丟丞东丘丁丕丕七不 { get; }
        
        // Methods
        protected override Rilisoft.丅丌丌丐丘丕丟丏丝 丞丏丝世七不丐不业()
        {
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_3;
            if(this.丁丏东专丐不三丛丗.世三丞丅丑丌丈丈一() >= 1)
            {
                    val_3 = this.丁丏东专丐不三丛丗;
                return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞};
            }
            
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_2 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  128);
            this.丁丏东专丐不三丛丗 = val_2;
            mem[1152921543083612776] = val_2.丑丒丄下丁丐专丄丞;
            return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞};
        }
        protected override bool 三丛丁丆东世丁丏三(int 丑且下丁丏丕丕七丈)
        {
            MainMenuController val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Func<LobbyItemBuff, System.Boolean> val_21;
            var val_22;
            System.Func<LobbyItemBuff, System.Single> val_24;
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
            val_21 = LobbyItemEffectFreeSpins.<>c.<>9__3_0;
            if(val_21 == null)
            {
                    System.Func<LobbyItemBuff, System.Boolean> val_7 = null;
                val_21 = val_7;
                val_7 = new System.Func<LobbyItemBuff, System.Boolean>(object:  LobbyItemEffectFreeSpins.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemEffectFreeSpins.<>c::丅万与丄丆丕丗丗丁(丕专丟上与丄丈三丏.LobbyItemBuff 丌丗丏丏丛东专丁且));
                LobbyItemEffectFreeSpins.<>c.<>9__3_0 = val_21;
            }
            
            val_22 = null;
            val_22 = null;
            val_24 = LobbyItemEffectFreeSpins.<>c.<>9__3_1;
            if(val_24 == null)
            {
                    System.Func<LobbyItemBuff, System.Single> val_9 = null;
                val_24 = val_9;
                val_9 = new System.Func<LobbyItemBuff, System.Single>(object:  LobbyItemEffectFreeSpins.<>c.__il2cppRuntimeField_static_fields, method:  System.Single LobbyItemEffectFreeSpins.<>c::丈东世上三世丅丛丑(丕专丟上与丄丈三丏.LobbyItemBuff 东丝丄丝丙专丘三丏));
                LobbyItemEffectFreeSpins.<>c.<>9__3_1 = val_24;
            }
            
            val_25 = null;
            val_25 = null;
            val_15 = val_15 * ((int)System.Linq.Enumerable.Sum(source:  System.Linq.Enumerable.Select<LobbyItemBuff, System.Single>(source:  System.Linq.Enumerable.Where<LobbyItemBuff>(source:  val_15.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万(), predicate:  val_7), selector:  val_9)));
            int val_12 = GiftController.丆丕丝丒不丙且丐丗.IncrementFreeSpins(丏业下一丑丄丐丘三:  val_15);
            this.不丒丂丕丅丌世专三(上丒丆丆丞且丐丆七:  System.String.Format(format:  "{0} {1}", arg0:  val_15, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3807")));
            return false;
        }
        public LobbyItemEffectFreeSpins()
        {
            val_1 = new Rilisoft.LobbyItemEffectHandler();
        }
    
    }

}
