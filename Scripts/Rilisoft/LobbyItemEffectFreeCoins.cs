using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemEffectFreeCoins : LobbyItemEffectPerInterval
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
            mem[1152921543081684328] = val_2.丑丒丄下丁丐专丄丞;
            return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞};
        }
        protected override bool 三丛丁丆东世丁丏三(int 丑且下丁丏丕丕七丈)
        {
            MainMenuController val_13;
            var val_14;
            var val_15;
            var val_16;
            System.Func<LobbyItemBuff, System.Boolean> val_18;
            var val_20;
            System.Func<LobbyItemBuff, System.Single> val_22;
            var val_23;
            if(true != 0)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_13 != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_13 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_13 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    int val_13 = UnityEngine.Mathf.Min(a:  丑且下丁丏丕丕七丈, b:  3);
                val_16 = null;
                val_16 = null;
                val_18 = LobbyItemEffectFreeCoins.<>c.<>9__3_0;
                if(val_18 == null)
            {
                    System.Func<LobbyItemBuff, System.Boolean> val_6 = null;
                val_18 = val_6;
                val_6 = new System.Func<LobbyItemBuff, System.Boolean>(object:  LobbyItemEffectFreeCoins.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemEffectFreeCoins.<>c::丅万与丄丆丕丗丗丁(丕专丟上与丄丈三丏.LobbyItemBuff 丌丗丏丏丛东专丁且));
                LobbyItemEffectFreeCoins.<>c.<>9__3_0 = val_18;
            }
            
                val_20 = null;
                val_20 = null;
                val_22 = LobbyItemEffectFreeCoins.<>c.<>9__3_1;
                if(val_22 == null)
            {
                    System.Func<LobbyItemBuff, System.Single> val_8 = null;
                val_22 = val_8;
                val_8 = new System.Func<LobbyItemBuff, System.Single>(object:  LobbyItemEffectFreeCoins.<>c.__il2cppRuntimeField_static_fields, method:  System.Single LobbyItemEffectFreeCoins.<>c::丈东世上三世丅丛丑(丕专丟上与丄丈三丏.LobbyItemBuff 东丝丄丝丙专丘三丏));
                LobbyItemEffectFreeCoins.<>c.<>9__3_1 = val_22;
            }
            
                val_13 = val_13 * ((int)System.Linq.Enumerable.Sum(source:  System.Linq.Enumerable.Select<LobbyItemBuff, System.Single>(source:  System.Linq.Enumerable.Where<LobbyItemBuff>(source:  丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万(), predicate:  val_6), selector:  val_8)));
                BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  val_13, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  6, 丟世且丕丂丁万丒万:  0);
                val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3002");
                this.不丒丂丕丅丌世专三(上丒丆丆丞且丐丆七:  System.String.Format(format:  val_13, arg0:  val_13));
                val_23 = 1;
                return (bool)val_23;
            }
            
            }
            
            }
            
            val_23 = 0;
            return (bool)val_23;
        }
        public LobbyItemEffectFreeCoins()
        {
            val_1 = new Rilisoft.LobbyItemEffectHandler();
        }
    
    }

}
