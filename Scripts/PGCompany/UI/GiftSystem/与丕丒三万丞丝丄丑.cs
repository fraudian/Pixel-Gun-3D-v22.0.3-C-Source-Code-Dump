using UnityEngine;

namespace PGCompany.UI.GiftSystem
{
    internal sealed class 与丕丒三万丞丝丄丑
    {
        // Fields
        private readonly PGCompany.UI.GiftSystem.ReceiveGiftView 世万丅丒三东下丂上;
        private readonly System.Collections.Generic.List<PGCompany.GiftSystem.丏下丙丂万且一丑丛> 七丅丈丁丌丘丑且丙;
        private int 一丕丟一万丗世丁丘;
        private bool 丕世专丘且业丗丛丒;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        public 与丕丒三万丞丝丄丑(PGCompany.UI.GiftSystem.ReceiveGiftView 丘世丟七不丏丙丞丏)
        {
            var val_9;
            System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_11;
            this.世万丅丒三东下丂上 = 丘世丟七不丏丙丞丏;
            丘世丟七不丏丙丞丏.giftUI.三万万万丁三丒丘丗 = new System.Action(object:  this, method:  System.Void PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑::丟丒丗丞三丒丄丕丁());
            this.世万丅丒三东下丂上.giftUI.上丈丏丈丄丛丕丛丏 = new System.Action(object:  this, method:  System.Void PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑::丈丙丝东丒一且丘丂());
            this.世万丅丒三东下丂上.giftUI.丗丒上丙丁七七业上 = new System.Action(object:  this, method:  System.Void PGCompany.UI.GiftSystem.与丕丒三万丞丝丄丑::丆世东不下东丗丞不());
            val_9 = null;
            val_9 = null;
            val_11 = 与丕丒三万丞丝丄丑.<>c.<>9__4_0;
            if(val_11 == null)
            {
                    System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_6 = null;
                val_11 = val_6;
                val_6 = new System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean>(object:  与丕丒三万丞丝丄丑.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丕丒三万丞丝丄丑.<>c::丁与丑三丗上丏丁丙(PGCompany.GiftSystem.丏下丙丂万且一丑丛 三丟东丕丄丄下下丑));
                与丕丒三万丞丝丄丑.<>c.<>9__4_0 = val_11;
            }
            
            this.七丅丈丁丌丘丑且丙 = System.Linq.Enumerable.ToList<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(source:  System.Linq.Enumerable.Where<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(source:  Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘(), predicate:  val_6));
            this.一丕丟一万丗世丁丘 = 0;
            this.丕世专丘且业丗丛丒 = false;
        }
        internal static bool 丂丙上且不丟业丛丒()
        {
            MainMenuController val_23;
            var val_24;
            var val_25;
            var val_26;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return false;
            }
            
            val_23 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
            if(val_23.下不丙丌丙丞丞万上() == false)
            {
                    return false;
            }
            
            val_24 = null;
            val_24 = null;
            val_23 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_23 == 0)
            {
                    return false;
            }
            
            val_25 = null;
            val_25 = null;
            val_23 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_23 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
            if(activeInHierarchy == false)
            {
                    return false;
            }
            
            val_23 = 0;
            goto label_18;
            label_42:
            PGCompany.GiftSystem.丏下丙丂万且一丑丛 val_8 = Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘().Item[0];
            val_26 = 0;
            goto label_23;
            label_37:
            if(val_8.丒丑丛丂丟丑丝丘丐().Item[0].不业丙丒丂丞下丆丙() != 1110)
            {
                    if(val_8.丒丑丛丂丟丑丝丘丐().Item[0].业东丅东丌上丗丑不() != 26015)
            {
                goto label_31;
            }
            
            }
            
            if((丂与专万与丐丌丏不.丑七不且上丗丁一世().三丐丁一且一丏三丞(丄丒且丙三丆丟与丏:  val_8.丕不业丟丕丘万世三())) != null)
            {
                    return false;
            }
            
            label_31:
            val_26 = 1;
            label_23:
            if(val_26 < val_8.丒丑丛丂丟丑丝丘丐().Count)
            {
                goto label_37;
            }
            
            val_23 = 1;
            label_18:
            if(val_23 < Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘().Count)
            {
                goto label_42;
            }
            
            return false;
        }
        private void 丈丙丝东丒一且丘丂()
        {
            if(this.一丕丟一万丗世丁丘 < this.七丅丈丁丌丘丑且丙.Count)
            {
                    PGCompany.GiftSystem.丏下丙丂万且一丑丛 val_2 = this.七丅丈丁丌丘丑且丙.Item[this.一丕丟一万丗世丁丘];
                if(val_2 != null)
            {
                    this.世万丅丒三东下丂上.giftUI.丈且东丑丂且万丒丅(丄丒丞专丐丌东丒业:  val_2);
                this.丕世专丘且业丗丛丒 = false;
                return;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "Cannot find battle pass currency gift to show");
            this.世万丅丒三东下丂上.HideSelf();
        }
        private void 丟丒丗丞三丒丄丕丁()
        {
            int val_18;
            var val_19;
            var val_20;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_22;
            var val_23;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_25;
            if(this.丕世专丘且业丗丛丒 != false)
            {
                    return;
            }
            
            val_18 = this.一丕丟一万丗世丁丘;
            if(val_18 >= this.七丅丈丁丌丘丑且丙.Count)
            {
                goto label_5;
            }
            
            val_18 = this.一丕丟一万丗世丁丘;
            PGCompany.GiftSystem.丏下丙丂万且一丑丛 val_2 = this.七丅丈丁丌丘丑且丙.Item[val_18];
            if(val_2 == null)
            {
                goto label_5;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  27);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().上丆丂丆上世三与丘(且丌丒丝不丛上三丆:  val_2);
            if((val_5 == null) || (val_5.Count < 1))
            {
                goto label_11;
            }
            
            if(val_2.丂丒丞丂丘一不东且() == false)
            {
                goto label_12;
            }
            
            val_19 = "clan";
            goto label_23;
            label_5:
            UnityEngine.Debug.LogError(message:  "Cannot find battle pass currency gift to open");
            this.世万丅丒三东下丂上.HideSelf();
            return;
            label_12:
            val_20 = null;
            val_20 = null;
            val_22 = 与丕丒三万丞丝丄丑.<>c.<>9__8_0;
            if(val_22 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_9 = null;
                val_22 = val_9;
                val_9 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  与丕丒三万丞丝丄丑.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丕丒三万丞丝丄丑.<>c::丗丞且东丛一丛业丛(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                与丕丒三万丞丝丄丑.<>c.<>9__8_0 = val_22;
            }
            
            if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_2.丒丑丛丂丟丑丝丘丐(), predicate:  val_9)) != false)
            {
                    val_19 = "bp";
            }
            else
            {
                    val_23 = null;
                val_23 = null;
                val_25 = 与丕丒三万丞丝丄丑.<>c.<>9__8_1;
                if(val_25 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_12 = null;
                val_25 = val_12;
                val_12 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  与丕丒三万丞丝丄丑.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丕丒三万丞丝丄丑.<>c::丑丄丙上上丌丙丏专(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                与丕丒三万丞丝丄丑.<>c.<>9__8_1 = val_25;
            }
            
            }
            
            label_23:
            PGCompany.Analytics.一业丗丆世世上丁且.与丙业丑与东上下不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐丅专且专七三丆:  0, 丝七丌丘丅丄七丅丟:  val_2.丕不业丟丕丘万世三(), 丑七不与丛丆一丂丞:  val_5, 丐丌丟丕丅且丙三与:  ((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_2.丒丑丛丂丟丑丝丘丐(), predicate:  val_12)) != true) ? "pp" : System.String.alignConst, 丒世丘丘上丆丝东丞:  0);
            label_11:
            int val_18 = this.一丕丟一万丗世丁丘;
            this.丕世专丘且业丗丛丒 = true;
            val_18 = val_18 + 1;
            this.一丕丟一万丗世丁丘 = val_18;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 丆世东不下东丗丞不()
        {
            if(this.一丕丟一万丗世丁丘 < this.七丅丈丁丌丘丑且丙.Count)
            {
                    return;
            }
            
            this.世万丅丒三东下丂上.HideSelf();
        }
    
    }

}
