using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemEffectFreeGems : LobbyItemEffectPerInterval
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
            mem[1152921543082646504] = val_2.丑丒丄下丁丐专丄丞;
            return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞};
        }
        protected override bool 三丛丁丆东世丁丏三(int 丑且下丁丏丕丕七丈)
        {
            MainMenuController val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Func<LobbyItemBuff, System.Boolean> val_19;
            var val_20;
            System.Func<LobbyItemBuff, System.Single> val_22;
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
                val_19 = LobbyItemEffectFreeGems.<>c.<>9__3_0;
                if(val_19 == null)
            {
                    System.Func<LobbyItemBuff, System.Boolean> val_6 = null;
                val_19 = val_6;
                val_6 = new System.Func<LobbyItemBuff, System.Boolean>(object:  LobbyItemEffectFreeGems.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemEffectFreeGems.<>c::丅万与丄丆丕丗丗丁(丕专丟上与丄丈三丏.LobbyItemBuff 丌丗丏丏丛东专丁且));
                LobbyItemEffectFreeGems.<>c.<>9__3_0 = val_19;
            }
            
                val_20 = null;
                val_20 = null;
                val_22 = LobbyItemEffectFreeGems.<>c.<>9__3_1;
                if(val_22 == null)
            {
                    System.Func<LobbyItemBuff, System.Single> val_8 = null;
                val_22 = val_8;
                val_8 = new System.Func<LobbyItemBuff, System.Single>(object:  LobbyItemEffectFreeGems.<>c.__il2cppRuntimeField_static_fields, method:  System.Single LobbyItemEffectFreeGems.<>c::丈东世上三世丅丛丑(丕专丟上与丄丈三丏.LobbyItemBuff 东丝丄丝丙专丘三丏));
                LobbyItemEffectFreeGems.<>c.<>9__3_1 = val_22;
            }
            
                val_23 = null;
                val_23 = null;
                val_14 = val_14 * ((int)System.Linq.Enumerable.Sum(source:  System.Linq.Enumerable.Select<LobbyItemBuff, System.Single>(source:  System.Linq.Enumerable.Where<LobbyItemBuff>(source:  丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万(), predicate:  val_6), selector:  val_8)));
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  val_14, 世丁丙世丄一万丆三:  6, 丛丞万三下丘七丌丅:  true);
                val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3001");
                this.不丒丂丕丅丌世专三(上丒丆丆丞且丐丆七:  System.String.Format(format:  val_14, arg0:  val_14));
                val_24 = 1;
                return (bool)val_24;
            }
            
            }
            
            }
            
            val_24 = 0;
            return (bool)val_24;
        }
        public LobbyItemEffectFreeGems()
        {
            val_1 = new Rilisoft.LobbyItemEffectHandler();
        }
    
    }

}
