using UnityEngine;

namespace Rilisoft
{
    public class ClanBuyCurrencyWindow : BuySpecialCurrenciesWindowBase
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.ClanCurrencyView> _views;
        
        // Methods
        public void Show()
        {
            var val_13;
            var val_14;
            var val_15;
            Rilisoft.GameCurrencyData val_16;
            if(this._views == null)
            {
                goto label_2;
            }
            
            val_13 = 1152921542381202080;
            if(this._views.Count == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_2 = BalanceController.丌东丏丘丞丄丝世且();
            if(val_2 == null)
            {
                goto label_27;
            }
            
            val_14 = 1152921524457754624;
            if(val_2.Count != 3)
            {
                    UnityEngine.Debug.LogError(message:  "currency datas count not equals to 3");
            }
            
            val_15 = 0;
            goto label_9;
            label_20:
            Rilisoft.ClanCurrencyView val_4 = this._views.Item[0];
            if((val_2.Count - 1) >= val_15)
            {
                    val_16 = val_2.Item[0];
                if(val_16 != null)
            {
                    if(val_4 != 0)
            {
                    val_4.Set(一下世丆丙万丞东丆:  val_16);
                val_4.remove_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.ClanCurrencyView>(object:  this, method:  System.Void Rilisoft.ClanBuyCurrencyWindow::三丛丅丛不丗与丂且(Rilisoft.ClanCurrencyView 丁世丛业丟下丕三丟)));
                System.Action<Rilisoft.ClanCurrencyView> val_10 = null;
                val_16 = val_10;
                val_10 = new System.Action<Rilisoft.ClanCurrencyView>(object:  this, method:  System.Void Rilisoft.ClanBuyCurrencyWindow::三丛丅丛不丗与丂且(Rilisoft.ClanCurrencyView 丁世丛业丟下丕三丟));
                val_4.add_Click(丙业与丙丗丝不丈东:  val_10);
                val_13 = 1152921542381202080;
                val_14 = 1152921524457754624;
            }
            
            }
            
            }
            
            val_15 = 1;
            label_9:
            if(val_15 < this._views.Count)
            {
                goto label_20;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
            label_2:
            label_27:
            UnityEngine.Debug.LogError(message:  "currency views not setted");
        }
        private void 三丛丅丛不丗与丂且(Rilisoft.ClanCurrencyView 丁世丛业丟下丕三丟)
        {
            ClanBuyCurrencyWindow.丛与丒丞丁丛上丄丆 val_1 = new ClanBuyCurrencyWindow.丛与丒丞丁丛上丄丆();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丝且与丝丒丟万丁专 = this;
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            if(丁世丛业丟下丕三丟 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            if((丁世丛业丟下丕三丟.<不丑丂上丘丒丙与丅>k__BackingField) == null)
            {
                goto label_3;
            }
            
            StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void ClanBuyCurrencyWindow.丛与丒丞丁丛上丄丆::丞丘丙上丈且丆业丏()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_1:
            mem[16] = this;
            mem[24] = 丁世丛业丟下丕三丟;
            if(mem[24] != 0)
            {
                goto label_8;
            }
            
            goto label_9;
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
            val_7.Add(key:  "Key", value:  "ClanCurrency");
            val_7.Add(key:  "action", value:  "ClanCurrency");
            val_7.Add(key:  "ClanCurrency", value:  val_8.CurrencyCount);
            val_18 = null;
            val_18 = null;
            val_8 = coinsShop.专丆专上丗万世丒七;
            val_8.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_15, 丈上上丟丟丏万丐且:  val_7);
        }
        public ClanBuyCurrencyWindow()
        {
        
        }
    
    }

}
