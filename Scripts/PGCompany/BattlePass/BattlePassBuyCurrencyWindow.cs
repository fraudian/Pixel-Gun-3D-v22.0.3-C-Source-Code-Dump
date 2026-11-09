using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassBuyCurrencyWindow : BuySpecialCurrenciesWindowBase
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.BPCurrencyView> 丈丗丈丛三丗专丌且;
        private WidgetLayout _widgetLayout;
        private Rilisoft.BPCurrencyView _currencyView;
        
        // Methods
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._currencyView, 丏业丟一东丂东丘丛:  false);
        }
        internal static UnityEngine.GameObject 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            if(丆丏七丟不丒与七专 == 0)
            {
                    return 0;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_3 == null)
            {
                    return 0;
            }
            
            if(val_3.丁丙丞下丅丘丛丈且() == null)
            {
                    return 0;
            }
            
            if(val_3.丁丙丞下丅丘丛丈且().Count == 0)
            {
                    return 0;
            }
            
            string val_7 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPBuyCurrency");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == true)
            {
                    return 0;
            }
            
            UnityEngine.GameObject val_9 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_7);
            if(val_9 != 0)
            {
                    return 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_9, 丈东丘丏与丌东东下:  丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            return 0;
        }
        protected override void OnEnable()
        {
            UnityEngine.Transform val_29;
            var val_30;
            Rilisoft.GameCurrencyData val_31;
            var val_32;
            var val_33;
            this.OnEnable();
            this._widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.丁丙丞下丅丘丛丈且() == null)
            {
                    return;
            }
            
            if(val_2.丁丙丞下丅丘丛丈且().Count == 0)
            {
                    return;
            }
            
            val_29 = this._widgetLayout.transform;
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<Rilisoft.BPCurrencyView>(专下丐丒丈万丗丟丝:  this.丈丗丈丛三丗专丌且, 专丑业丁丗丏丌不丛:  this._currencyView.gameObject, 丈东丘丏与丌东东下:  val_29, 与业丄丂丂丆下上丞:  val_2.丁丙丞下丅丘丛丈且().Count, 丏东下下一丗专下丏:  0);
            val_30 = 0;
            goto label_12;
            label_37:
            if((val_2.丁丙丞下丅丘丛丈且().Count - 1) < val_30)
            {
                    val_31 = 0;
            }
            else
            {
                    val_31 = val_2.丁丙丞下丅丘丛丈且().Item[0];
            }
            
            Rilisoft.BPCurrencyView val_15 = this.丈丗丈丛三丗专丌且.Item[0];
            if((val_31 != null) && (val_15 != 0))
            {
                    bool val_17 = 0 & 1;
                val_15.Set(一下世丆丙万丞东丆:  val_31, 且丆东丌丅三丂丂七:  val_17, 丘与丐丕丟丕丒丄丁:  false);
                if((val_17 & 1) != 0)
            {
                    val_32 = 1;
            }
            else
            {
                    val_32 = val_15.与丟丂丙丙丝丁下业();
            }
            
                var val_19 = (val_32 == true) ? 1 : 0;
                if((0 & 1) != 0)
            {
                    val_33 = 1;
            }
            else
            {
                    val_33 = val_15.下业丝丞丟上丙丝七();
            }
            
                var val_21 = (val_33 == true) ? 1 : 0;
                val_15.remove_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.BPCurrencyView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyCurrencyWindow::三丛丅丛不丗与丂且(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)));
                val_15.add_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.BPCurrencyView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyCurrencyWindow::三丛丅丛不丗与丂且(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)));
                val_15.remove_GiftClick(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.BPCurrencyView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyCurrencyWindow::下丌丈七丑专丄丕丂(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)));
                val_15.add_GiftClick(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.BPCurrencyView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyCurrencyWindow::下丌丈七丑专丄丕丂(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  true);
            val_29 = this._widgetLayout;
            val_29.AddElement(丅丆东丏丙丝丅丆丟:  val_15);
            val_30 = 1;
            label_12:
            if(val_30 < val_2.丁丙丞下丅丘丛丈且().Count)
            {
                goto label_37;
            }
            
            this._widgetLayout.Reposition();
        }
        public override void U_Hide()
        {
            this.U_Hide();
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
        }
        private void 三丛丅丛不丗与丂且(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)
        {
            BattlePassBuyCurrencyWindow.丒丑万一丁丕东一丗 val_1 = new BattlePassBuyCurrencyWindow.丒丑万一丁丕东一丗();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丝且与丝丒丟万丁专 = this;
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            if(丁世丛业丟下丕三丟 != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            if(丁世丛业丟下丕三丟.CurrencyData == null)
            {
                goto label_3;
            }
            
            StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void BattlePassBuyCurrencyWindow.丒丑万一丁丕东一丗::丞丘丙上丈且丆业丏()));
            this.HideWindow();
            return;
            label_1:
            mem[16] = this;
            mem[24] = 丁世丛业丟下丕三丟;
            if(mem[24] != 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            UnityEngine.Debug.LogError(message:  "view without currency data");
        }
        private void 下丌丈七丑专丄丕丂(Rilisoft.BPCurrencyView 丁世丛业丟下丕三丟)
        {
            BattlePassBuyCurrencyWindow.业东下丕世丗丏万丏 val_1 = new BattlePassBuyCurrencyWindow.业东下丕世丗丏万丏();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丝且与丝丒丟万丁专 = this;
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            if(丁世丛业丟下丕三丟 != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            if(丁世丛业丟下丕三丟.CurrencyData == null)
            {
                goto label_3;
            }
            
            StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void BattlePassBuyCurrencyWindow.业东下丕世丗丏万丏::丒丑丕丌丁三丘丝专()));
            return;
            label_1:
            mem[16] = this;
            mem[24] = 丁世丛业丟下丕三丟;
            if(mem[24] != 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            UnityEngine.Debug.LogError(message:  "view without currency data");
        }
        private void 丏丝丘七丕与世丅丆(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            coinsShop val_8;
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            丘丝丑丐丆丑七不丙 val_15;
            var val_17;
            var val_18;
            val_8 = 一下世丆丙万丞东丆;
            val_9 = null;
            val_10 = System.String.alignConst;
            val_9 = null;
            if(coinsShop.专丆专上丗万世丒七 == 0)
            {
                    return;
            }
            
            val_11 = 0;
            goto label_6;
            label_16:
            val_12 = null;
            val_12 = null;
            if(val_11 >= StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                    val_13 = 0;
            }
            
            if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == val_8.RealPrice)
            {
                goto label_12;
            }
            
            val_11 = 1;
            label_6:
            val_14 = null;
            val_14 = null;
            if(val_11 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                goto label_16;
            }
            
            val_15 = 0;
            goto label_17;
            label_12:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = 0;
            val_17 = null;
            val_15 = AbstractBankView.丒丁丞丝世三与七东().Item[0];
            val_17 = null;
            val_10 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_10 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_17:
            if((val_15 == 0) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) == true))
            {
                goto label_32;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_7 == null)
            {
                goto label_33;
            }
            
            val_7.Add(key:  "ID", value:  val_10);
            goto label_34;
            label_32:
            UnityEngine.Debug.LogError(message:  "prepare purchase information error");
            return;
            label_33:
            val_7.Add(key:  "ID", value:  val_10);
            label_34:
            val_7.Add(key:  "Key", value:  "BattlePassCurrency");
            val_7.Add(key:  "action", value:  "BattlePassCurrency");
            val_7.Add(key:  "fromBattlePass", value:  true);
            val_7.Add(key:  "BattlePassCurrency", value:  val_8.CurrencyCount);
            val_18 = null;
            val_18 = null;
            val_8 = coinsShop.专丆专上丗万世丒七;
            val_8.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_15, 丈上上丟丟丏万丐且:  val_7);
        }
        private void 丌不丁丄丅丌丌丕且(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  86, 丞丅上丏丂且下丅与:  "BattlePassCurrency");
            val_1.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  一下世丆丙万丞东丆.CurrencyCount);
            PGCompany.三东丏不丗世丅丌丄 val_3 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  31);
            val_3.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  一下世丆丙万丞东丆.RealPrice);
            ClanGiftRecipientsView.下与丞三丅丛丄七丕(丈东丘丏与丌东东下:  this.transform.parent.gameObject, 且丘丏丁丑与丙与丁:  val_3.丝与丘丘丅业一业丘(丈丄不七三万丄丁不:  val_1, 丒世丘丘上丆丝东丞:  val_3, 万丏丗丗丅丄丌业一:  1), 东东丂丑丙丞专东与:  new PGCompany.GiftSystem.丝不丄丂世丐业七丈()).丝一丅丆三东丂丞七(丛丅丈一一丟丂业万:  丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上());
        }
        private PGCompany.东丑丆丗丏丐丟下丄 丝与丘丘丅业一业丘(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, int 万丏丗丗丅丄丌业一)
        {
            PGCompany.StorePromotionPurchaseSettings val_1 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 6;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_2.Add(item:  丒世丘丘上丆丝东丞);
            val_1.Price = val_2;
            PGCompany.StorePromotionSettings val_3 = new PGCompany.StorePromotionSettings();
            if(val_3 != null)
            {
                    .PurchaseSettings = val_1;
            }
            else
            {
                    mem[96] = val_1;
            }
            
            (PGCompany.StorePromotionSettings)[1152921560028903936].ItemsParams.Add(item:  丈丄不七三万丄丁不);
            return (PGCompany.东丑丆丗丏丐丟下丄)new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  4, 与不丕丆丈不丙丟丛:  val_3, 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  万丏丗丗丅丄丌业一)));
        }
        public BattlePassBuyCurrencyWindow()
        {
            this.丈丗丈丛三丗专丌且 = new System.Collections.Generic.List<Rilisoft.BPCurrencyView>();
        }
    
    }

}
