using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassWellcomeWindow : MonoBehaviour
    {
        // Fields
        private static Rilisoft.且丈丞一丞丟与上七 丅丂三不且世专丅丛;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private int 一三丆丘丕丝丛丌丒;
        private System.Collections.Generic.List<UnityEngine.GameObject> _tabs;
        private static System.Action 丛丄业丘不丆丄三丞;
        
        // Properties
        internal static bool 丕世一与业丅万专丑 { get; }
        
        // Methods
        internal static bool 丌七丘七丗下丐七丞()
        {
            null = null;
            return (bool)(PGCompany.BattlePass.BattlePassWellcomeWindow.丅丂三不且世专丅丛.世三丞丅丑丌丈丈一() != 1) ? 1 : 0;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassWellcomeWindow.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BattlePassWellcomeWindow.丛丄业丘不丆丄三丞 != 1152921505683791880);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassWellcomeWindow.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BattlePassWellcomeWindow.丛丄业丘不丆丄三丞 != 1152921505683791880);
        
        }
        public void Show()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassWellcomeWindow::U_Next()), 与且专丈不万东一万:  0);
            this.一三丆丘丕丝丛丌丒 = 0;
            this.三丄丅丄丌丈丈丑下();
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        private void 三丄丅丄丌丈丈丑下()
        {
            var val_8;
            System.Collections.Generic.List<UnityEngine.GameObject> val_9;
            var val_10;
            int val_1 = this.一三丆丘丕丝丛丌丒 + 1;
            if(val_1 >= this._tabs.Count)
            {
                goto label_2;
            }
            
            val_8 = 0;
            goto label_3;
            label_8:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tabs.Item[0], 丏业丟一东丂东丘丛:  (val_1 == val_8) ? 1 : 0);
            val_8 = 1;
            label_3:
            val_9 = this._tabs;
            if(val_8 < val_9.Count)
            {
                goto label_8;
            }
            
            this.一三丆丘丕丝丛丌丒 = val_1;
            return;
            label_2:
            val_9 = 1152921505683787776;
            val_10 = null;
            val_10 = null;
            PGCompany.BattlePass.BattlePassWellcomeWindow.丅丂三不且世专丅丛.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(PGCompany.BattlePass.BattlePassWellcomeWindow.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            0.Invoke();
        }
        public void U_Next()
        {
            this.三丄丅丄丌丈丈丑下();
        }
        public BattlePassWellcomeWindow()
        {
            this.一三丆丘丕丝丛丌丒 = 0;
        }
        private static BattlePassWellcomeWindow()
        {
            PGCompany.BattlePass.BattlePassWellcomeWindow.丅丂三不且世专丅丛 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "BattlePassWellcomeWindow-_bannerViewed");
        }
    
    }

}
