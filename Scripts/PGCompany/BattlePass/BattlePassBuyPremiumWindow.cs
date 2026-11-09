using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassBuyPremiumWindow : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丄丘业与丈丛丛丝世;
        private static PGCompany.BattlePass.BattlePassBuyPremiumWindow <不丁丄七丛不丆丁丕>k__BackingField;
        private static System.Action 丛丄业丘不丆丄三丞;
        private UnityEngine.GameObject _guiHandler;
        private UILabel _plusLevelsLabel;
        private UILabel _priceLabel;
        private UILabel _priceLevelsLabel;
        private UILabel _basePriceLabel;
        private UILabel _saleLabel;
        private UILabel _timeLeftLabel;
        private WidgetLayout _buyPremiumWidgetLayout;
        private UnityEngine.GameObject _premiumWithLevelGO;
        private UnityEngine.GameObject _premiumOrGO;
        
        // Properties
        internal static PGCompany.BattlePass.BattlePassBuyPremiumWindow 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        internal static PGCompany.BattlePass.BattlePassBuyPremiumWindow 丑七不且上丗丁一世()
        {
            return (PGCompany.BattlePass.BattlePassBuyPremiumWindow)PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BattlePassBuyPremiumWindow 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞 != 1152921505680011272);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞 != 1152921505680011272);
        
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            UnityEngine.Transform val_11 = 丆丏七丟不丒与七专;
            if(val_11 == 0)
            {
                    return;
            }
            
            if((PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return;
            }
            
            string val_3 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPBuyPremium");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_3);
            if(val_5 == 0)
            {
                    return;
            }
            
            int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            val_11 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_5, 丈东丘丏与丌东东下:  val_11 = 丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField = val_11.GetComponent<PGCompany.BattlePass.BattlePassBuyPremiumWindow>();
            if((PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_11);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private void OnEnable()
        {
            if(this.丄丘业与丈丛丛丝世 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                this.丄丘业与丈丛丛丝世.Dispose();
            }
            
            this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassBuyPremiumWindow::Hide()), 与且专丈不万东一万:  0);
            this.丝一丅丆三东丂丞七();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
        }
        private void OnDisable()
        {
            if(this.丄丘业与丈丛丛丝世 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        private void 丝一丅丆三东丂丞七()
        {
            WidgetLayout val_24;
            string val_25;
            val_24 = this;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            val_25 = 1152921504848912384;
            if(this._plusLevelsLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._plusLevelsLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[BattlePass \n + {0} levels]", arg0:  val_2.专世丙七东与丘东丒()));
            }
            
            if(this._priceLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._priceLabel, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.不世丆丒丛七丘与丅()));
            }
            
            if(this._priceLevelsLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._priceLevelsLabel, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.三丒丅世业三丈丙丕()));
            }
            
            if(this._basePriceLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._basePriceLabel, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.丒丝丒东万丅与东丄()));
            }
            
            if(this._saleLabel != 0)
            {
                    float val_24 = (float)val_2.丒丝丒东万丅与东丄();
                val_24 = val_24 / (float)val_2.三丒丅世业三丈丙丕();
                float val_26 = 100f;
                float val_25 = 1f;
                val_25 = val_25 - (val_25 / val_24);
                val_26 = val_25 * val_26;
                decimal val_19 = System.Decimal.op_Explicit(value:  val_26);
                decimal val_20 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_19.flags, hi = val_19.hi, lo = val_19.lo, mid = val_19.mid}, 专丂丕丗丗东世丞下:  5);
                val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5995");
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._saleLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_25, arg0:  val_20));
            }
            
            bool val_27 = val_2.丐丞上丒七丞丁丙丕();
            val_27 = (~val_27) & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._premiumWithLevelGO, 丏业丟一东丂东丘丛:  val_27);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._premiumOrGO, 丏业丟一东丂东丘丛:  val_27);
            val_24 = this._buyPremiumWidgetLayout;
            val_24.Reposition();
        }
        public void Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.丛丄业丘不丆丄三丞.Invoke();
        }
        public void U_Back()
        {
            this.Hide();
        }
        public void U_BuyPremium()
        {
            bool val_1 = this.BuyPremiumCore(丏七丗丝七丘一丙丗:  false);
        }
        public void U_BuyPremiumAndLevels()
        {
            bool val_1 = this.BuyPremiumCore(丏七丗丝七丘一丙丗:  true);
        }
        public bool BuyPremiumCore(bool 丏七丗丝七丘一丙丗)
        {
            var val_12;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_13 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_13 == null)
            {
                    return (bool)val_12;
            }
            
            if(val_13.专丟专一丒且丘与丌() != 100)
            {
                    if(丏七丗丝七丘一丙丗 != false)
            {
                    int val_4 = val_13.三丒丅世业三丈丙丕();
            }
            
                int val_6 = val_13.东与三丌丅三丒丏业();
                if(val_6 < val_13.不世丆丒丛七丘与丅())
            {
                    val_6.BuyCurrency();
            }
            else
            {
                    if((val_13.丌丞丟上丕与丂丆丞(专三丟丁专三上丂世:  丏七丗丝七丘一丙丗)) != false)
            {
                    val_13 = 1152921505138155520;
                if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI val_11 = BattlePassRootUI.丑七不且上丗丁一世();
                val_11.ResetRememberedParametersState();
            }
            
                val_11.东世丁丞丌丌丂丕丁();
                this.Hide();
                val_12 = 1;
                return (bool)val_12;
            }
            
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        private void 东世丁丞丌丌丂丕丁()
        {
            string val_11;
            var val_12;
            UnityEngine.Transform val_13;
            var val_14;
            val_11 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPPassUpgrade");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true)
            {
                    return;
            }
            
            val_11 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_11);
            if(val_11 == 0)
            {
                    return;
            }
            
            val_12 = 1152921505138155520;
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    val_13 = BattlePassRootUI.丑七不且上丗丁一世().七丒丈世丟三与丂与();
                val_14 = null;
            }
            else
            {
                    if((PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
                val_14 = null;
                val_13 = mem[PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField + 32];
                val_13 = PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField._subWindowsPlacePoint;
            }
            
            UnityEngine.GameObject val_10 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_11, 丈东丘丏与丌东东下:  val_13, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public void BuyCurrency()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI.丑七不且上丗丁一世().ShowBuyCurrencyWindow();
                return;
            }
            
            if((PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField.ShowBuyCurrencyWindow();
        }
        public void U_ShowInfoBasic()
        {
            this.与丈不丟丄三七丗上(丏业丟一东丂东丘丛:  0);
        }
        public void U_ShowInfoPremium()
        {
            this.与丈不丟丄三七丗上(丏业丟一东丂东丘丛:  1);
        }
        private void 与丈不丟丄三七丗上(int 丏业丟一东丂东丘丛)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._guiHandler, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.BattlePassPremiumPackWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyPremiumWindow::丕丆丄丁七三与丏万()));
            PGCompany.BattlePass.BattlePassPremiumPackWindow.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyPremiumWindow::丕丆丄丁七三与丏万()));
            PGCompany.BattlePass.BattlePassPremiumPackWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        private void 丕丆丄丁七三与丏万()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._guiHandler, 丏业丟一东丂东丘丛:  true);
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassBuyPremiumWindow.且三业下丅丈丁七丌();
        }
        public BattlePassBuyPremiumWindow()
        {
        
        }
    
    }

}
