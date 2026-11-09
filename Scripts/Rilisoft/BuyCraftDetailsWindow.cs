using UnityEngine;

namespace Rilisoft
{
    public class BuyCraftDetailsWindow : BuySpecialCurrenciesWindowBase
    {
        // Fields
        private static Rilisoft.BuyCraftDetailsWindow.丑业专丄七与与丕上 丛与万东丟丞专丆丙;
        private static Rilisoft.BuyCraftDetailsWindow.丟丗七丗丗丕丝丌三 丙丕业丕丛不丌丐丏;
        private static Rilisoft.BuyCraftDetailsWindow 且丌丑与丞丟丈丘丒;
        private System.Collections.Generic.List<DetailsIcons> _iconVariants;
        private System.Collections.Generic.List<Rilisoft.CraftDetailsView> _views;
        private UILabel header;
        private System.Collections.Generic.List<UILabel> _windowNameLabels;
        private string <世业丝不专丏丌丌丅>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.GameCurrencyData> 丅丏专丗业东丛不三;
        
        // Properties
        public System.Collections.Generic.List<Rilisoft.CraftDetailsView> 丏丞与丒丌丞丌丛丐 { get; }
        internal static Rilisoft.BuyCraftDetailsWindow 丄世七与不与丙丝丅 { get; }
        public string 七三七业丑下丞丕万 { get; set; }
        
        // Methods
        public System.Collections.Generic.List<Rilisoft.CraftDetailsView> get_Views()
        {
            return (System.Collections.Generic.List<Rilisoft.CraftDetailsView>)this._views;
        }
        internal static Rilisoft.BuyCraftDetailsWindow 万丕丞丝七东不丟丟()
        {
            null = null;
            return (Rilisoft.BuyCraftDetailsWindow)Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒;
        }
        public string get_ItemTag()
        {
            return (string)this.<世业丝不专丏丌丌丅>k__BackingField;
        }
        private void 不丛丙丂东丗丛丒丗(string 丙业与丙丗丝不丈东)
        {
            this.<世业丝不专丏丌丌丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 下与丞三丅丛丄七丕(UnityEngine.Transform 一丟丄丞不丕丟丌丟, string 丕丁下丌不万丅丞丛, System.Collections.Generic.List<Rilisoft.GameCurrencyData> 丕丌专世丌丂上丒丆, Rilisoft.BuyCraftDetailsWindow.丟丗七丗丗丕丝丌三 与丄不丌一世东丁丙, Rilisoft.BuyCraftDetailsWindow.丑业专丄七与与丕上 下丗丁丒丘东丂不丑)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = null;
            val_12 = null;
            if(Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒 == 0)
            {
                    val_13 = null;
                val_13 = null;
                Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<Rilisoft.BuyCraftDetailsWindow>(丑与丞三且丛与丟业:  "NguiWindows/Clan/BuyCraftDetailsWindow", 七万上丐一丈丏丏专:  一丟丄丞不丕丟丌丟.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            else
            {
                    val_14 = null;
                val_14 = null;
                UnityEngine.Transform val_4 = Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒.transform;
                val_4.SetParent(p:  一丟丄丞不丕丟丌丟);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                val_4.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
                val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
                val_4.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒.gameObject, 不东丛三丂丌丑专丆:  一丟丄丞不丕丟丌丟.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
                val_13 = null;
            }
            
            val_13 = null;
            if(Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒 == 0)
            {
                    return false;
            }
            
            val_15 = null;
            val_15 = null;
            Rilisoft.BuyCraftDetailsWindow.丙丕业丕丛不丌丐丏 = 与丄不丌一世东丁丙;
            Rilisoft.BuyCraftDetailsWindow.丛与万东丟丞专丆丙 = 下丗丁丒丘东丂不丑;
            if(Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒 != null)
            {
                    return Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒.下与丞三丅丛丄七丕(丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丕丌专世丌丂上丒丆:  丕丌专世丌丂上丒丆);
            }
            
            return Rilisoft.BuyCraftDetailsWindow.且丌丑与丞丟丈丘丒.下与丞三丅丛丄七丕(丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丕丌专世丌丂上丒丆:  丕丌专世丌丂上丒丆);
        }
        private bool 下与丞三丅丛丄七丕(string 丕丁下丌不万丅丞丛, System.Collections.Generic.List<Rilisoft.GameCurrencyData> 丕丌专世丌丂上丒丆)
        {
            UnityEngine.GameObject val_3;
            var val_4;
            val_3 = this;
            this.<世业丝不专丏丌丌丅>k__BackingField = 丕丁下丌不万丅丞丛;
            this.丅丏专丗业东丛不三 = 丕丌专世丌丂上丒丆;
            if(this.UpdateView() != false)
            {
                    val_3 = this.gameObject;
                val_4 = 1;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public bool UpdateView()
        {
            var val_18;
            var val_19;
            Rilisoft.GameCurrencyData val_20;
            Rilisoft.GameCurrencyData val_21;
            var val_22;
            var val_23;
            System.Action<DetailsIcons> val_25;
            var val_27;
            var val_28;
            if((this._views == null) || (this._views.Count == 0))
            {
                goto label_2;
            }
            
            if(this.丅丏专丗业东丛不三 == null)
            {
                goto label_66;
            }
            
            val_18 = 1152921504615686144;
            val_19 = 0;
            goto label_44;
            label_58:
            Rilisoft.CraftDetailsView val_2 = this._views.Item[0];
            if((this.丅丏专丗业东丛不三.Count - 1) < val_19)
            {
                    val_20 = 0;
            }
            else
            {
                    val_20 = this.丅丏专丗业东丛不三.Item[0];
            }
            
            if(val_2 == 0)
            {
                goto label_56;
            }
            
            if(val_20 == null)
            {
                goto label_13;
            }
            
            if((val_19 != 0) && (this.丅丏专丗业东丛不三.Count > (-1)))
            {
                    val_21 = this.丅丏专丗业东丛不三.Item[-1];
            }
            else
            {
                    val_21 = 0;
            }
            
            val_22 = null;
            val_22 = null;
            UnityEngine.GameObject val_11 = val_2.gameObject;
            if((this.且三丒丒与丑丁东丑(与丄不丌一世东丁丙:  Rilisoft.BuyCraftDetailsWindow.丙丕业丕丛不丌丐丏).Invoke(arg1:  val_21, arg2:  val_20)) == false)
            {
                goto label_23;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            val_18 = val_18;
            goto label_56;
            label_13:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_56;
            label_23:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
            val_2.Set(一下世丆丙万丞东丆:  val_20, 丞一丁业丄一一业且:  this.<世业丝不专丏丌丌丅>k__BackingField);
            val_18 = val_18;
            val_2.remove_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.CraftDetailsView>(object:  this, method:  System.Void Rilisoft.BuyCraftDetailsWindow::三丛丅丛不丗与丂且(Rilisoft.CraftDetailsView 丁世丛业丟下丕三丟)));
            val_2.add_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.CraftDetailsView>(object:  this, method:  System.Void Rilisoft.BuyCraftDetailsWindow::三丛丅丛不丗与丂且(Rilisoft.CraftDetailsView 丁世丛业丟下丕三丟)));
            val_23 = null;
            val_23 = null;
            val_25 = BuyCraftDetailsWindow.<>c.<>9__20_0;
            if(val_25 == null)
            {
                goto label_38;
            }
            
            if(this._iconVariants != null)
            {
                goto label_43;
            }
            
            goto label_40;
            label_38:
            val_25 = null;
            val_25 = new System.Action<DetailsIcons>(object:  BuyCraftDetailsWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BuyCraftDetailsWindow.<>c::丘丂丏丕一东丙一上(DetailsIcons 三丟东丕丄丄下下丑));
            val_18 = val_18;
            BuyCraftDetailsWindow.<>c.<>9__20_0 = val_25;
            if(this._iconVariants != null)
            {
                goto label_43;
            }
            
            label_40:
            label_43:
            this._iconVariants.ForEach(action:  null);
            label_56:
            val_19 = 1;
            label_44:
            if(val_19 < this._views.Count)
            {
                goto label_58;
            }
            
            val_27 = null;
            val_27 = null;
            this.丙丅专业丌与一上下(下丗丁丒丘东丂不丑:  Rilisoft.BuyCraftDetailsWindow.丛与万东丟丞专丆丙);
            val_28 = 1;
            return (bool)val_28;
            label_2:
            label_66:
            UnityEngine.Debug.LogError(message:  "currency views not setted");
            val_28 = 0;
            return (bool)val_28;
        }
        private void 三丛丅丛不丗与丂且(Rilisoft.CraftDetailsView 丁世丛业丟下丕三丟)
        {
            Rilisoft.CraftDetailsView val_4;
            Rilisoft.BuyCraftDetailsWindow val_5;
            val_4 = 丁世丛业丟下丕三丟;
            val_5 = this;
            BuyCraftDetailsWindow.丈业丗丞丁七下一不 val_1 = new BuyCraftDetailsWindow.丈业丗丞丁七下一不();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丝且与丝丒丟万丁专 = val_5;
            .丁世丛业丟下丕三丟 = val_4;
            if(val_4 != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            if(val_4.CurrencyData == null)
            {
                goto label_3;
            }
            
            StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void BuyCraftDetailsWindow.丈业丗丞丁七下一不::丞丘丙上丈且丆业丏()));
            val_5 = ???;
            val_4 = ???;
            goto typeof(Rilisoft.BuyCraftDetailsWindow).__il2cppRuntimeField_1A8;
            label_1:
            mem[16] = val_5;
            mem[24] = val_4;
            if(mem[24] != 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            UnityEngine.Debug.LogError(message:  "view without currency data");
        }
        private void 丏丝丘七丕与世丅丆(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆, string 丞一丁业丄一一业且)
        {
            var val_21;
            object val_22;
            var val_23;
            int val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_31;
            var val_32;
            var val_33;
            val_21 = 丞一丁业丄一一业且;
            val_22 = 一下世丆丙万丞东丆;
            val_23 = null;
            val_24 = System.String.alignConst;
            val_23 = null;
            if(coinsShop.专丆专上丗万世丒七 == 0)
            {
                    return;
            }
            
            val_25 = 0;
            goto label_6;
            label_16:
            val_26 = null;
            val_26 = null;
            if(val_25 >= StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                    val_27 = 0;
            }
            
            if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == val_22.RealPrice)
            {
                goto label_12;
            }
            
            val_25 = 1;
            label_6:
            val_28 = null;
            val_28 = null;
            if(val_25 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                goto label_16;
            }
            
            val_29 = 0;
            goto label_17;
            label_12:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_27 = 0;
            val_31 = null;
            val_29 = AbstractBankView.丒丁丞丝世三与七东().Item[0];
            val_31 = null;
            val_24 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_24 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_17:
            if((val_29 != 0) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_24)) != true))
            {
                    val_32 = 1152921505432616960;
                val_33 = null;
                val_33 = null;
                if(Rilisoft.BuyCraftDetailsWindow.丙丕业丕丛不丌丐丏 > 3)
            {
                    return;
            }
            
                var val_23 = 106040288 + (Rilisoft.BuyCraftDetailsWindow.丙丕业丕丛不丌丐丏) << 2;
                val_23 = val_23 + 106040288;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "prepare purchase information error");
            }
        
        }
        private System.Func<Rilisoft.GameCurrencyData, Rilisoft.GameCurrencyData, bool> 且三丒丒与丑丁东丑(Rilisoft.BuyCraftDetailsWindow.丟丗七丗丗丕丝丌三 与丄不丌一世东丁丙)
        {
            IntPtr val_5;
            var val_6;
            if((与丄不丌一世东丁丙 - 1) < 2)
            {
                goto label_1;
            }
            
            if(与丄不丌一世东丁丙 == 0)
            {
                goto label_2;
            }
            
            if(与丄不丌一世东丁丙 != 3)
            {
                goto label_3;
            }
            
            val_5 = 1152921542356151312;
            goto label_5;
            label_1:
            val_5 = 1152921542356156432;
            goto label_5;
            label_2:
            System.Func<Rilisoft.GameCurrencyData, Rilisoft.GameCurrencyData, System.Boolean> val_2 = null;
            val_5 = 1152921542356161552;
            label_5:
            val_2 = new System.Func<Rilisoft.GameCurrencyData, Rilisoft.GameCurrencyData, System.Boolean>(object:  this, method:  val_5);
            return val_2;
            label_3:
            val_6 = null;
            val_6 = null;
            if((BuyCraftDetailsWindow.<>c.<>9__23_0) != null)
            {
                    return val_2;
            }
            
            BuyCraftDetailsWindow.<>c.<>9__23_0 = new System.Func<Rilisoft.GameCurrencyData, Rilisoft.GameCurrencyData, System.Boolean>(object:  BuyCraftDetailsWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BuyCraftDetailsWindow.<>c::丘丌上万丐丆丌不丌(Rilisoft.GameCurrencyData 丞七三七丏下上不丌, Rilisoft.GameCurrencyData 且丌丘丙一世丁丆丙));
            return val_2;
        }
        private bool 与丌丗丅一丙丘丁不(Rilisoft.GameCurrencyData 与东丕一丗丙万丝上, Rilisoft.GameCurrencyData 七丌丐不专丐丙东丌)
        {
            if((this.丗丒三丁丒东万丈世(一丐丗丁丞丆丅丟丄:  与东丕一丗丙万丝上)) == false)
            {
                    return false;
            }
            
            return this.丗丒三丁丒东万丈世(一丐丗丁丞丆丅丟丄:  七丌丐不专丐丙东丌);
        }
        private bool 丅上丕万丕丌丒不丂(Rilisoft.GameCurrencyData 与东丕一丗丙万丝上, Rilisoft.GameCurrencyData 七丌丐不专丐丙东丌)
        {
            var val_4;
            var val_9;
            Rilisoft.丞丟丙丅丗且丈丞丏 val_1 = Rilisoft.丞丟丙丅丗且丈丞丏.丐下下丅与上东丙丑(三不三丟专丘东东丂:  this.<世业丝不专丏丌丌丅>k__BackingField);
            if(val_4.IsCoverImageUpdated != false)
            {
                    if(val_4.专丐丈丙上七丑一丘() == true)
            {
                goto label_2;
            }
            
            }
            
            if((this.东丐东丐丛丂七丂且(一丐丗丁丞丆丅丟丄:  与东丕一丗丙万丝上)) != false)
            {
                    val_9 = this;
                bool val_8 = this.东丐东丐丛丂七丂且(一丐丗丁丞丆丅丟丄:  七丌丐不专丐丙东丌);
            }
            else
            {
                    label_2:
                val_9 = 0;
            }
            
            val_9 = val_9 & 1;
            return (bool)val_9;
        }
        private bool 丅丝业丙且业丄三丝(Rilisoft.GameCurrencyData 与东丕一丗丙万丝上, Rilisoft.GameCurrencyData 七丌丐不专丐丙东丌)
        {
            return false;
        }
        private bool 东丐东丐丛丂七丂且(Rilisoft.GameCurrencyData 一丐丗丁丞丆丅丟丄)
        {
            var val_10;
            var val_11;
            string val_12;
            var val_13;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                goto label_1;
            }
            
            三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<世业丝不专丏丌丌丅>k__BackingField);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_10 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_1.三与丛丑且丐丈业丌());
            val_11 = 1152921505442041856;
            val_12 = val_1.与不丞丑七丘丁丂丛();
            return (bool)(val_10 <= (一丐丗丁丞丆丅丟丄.CurrencyCount + (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_12 = this.<世业丝不专丏丌丌丅>k__BackingField)))) ? 1 : 0;
            label_1:
            val_13 = 0;
            return (bool)(val_10 <= (一丐丗丁丞丆丅丟丄.CurrencyCount + (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_12)))) ? 1 : 0;
            label_4:
            val_11 = 1152921505442041856;
            val_10 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this.<世业丝不专丏丌丌丅>k__BackingField);
            return (bool)(val_10 <= (一丐丗丁丞丆丅丟丄.CurrencyCount + (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_12)))) ? 1 : 0;
        }
        private bool 丗丒三丁丒东万丈世(Rilisoft.GameCurrencyData 一丐丗丁丞丆丅丟丄)
        {
            string val_17;
            var val_18;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                goto label_4;
            }
            
            val_17 = this.<世业丝不专丏丌丌丅>k__BackingField;
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_17)) == false)
            {
                goto label_4;
            }
            
            val_17 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  this.<世业丝不专丏丌丌丅>k__BackingField);
            if(val_17 == null)
            {
                    return (bool)(val_17.三丐丟丒业丞东三丕() <= (一丐丗丁丞丆丅丟丄.CurrencyCount + val_17)) ? 1 : 0;
            }
            
            if((val_17.丄且丞且且且世丂丅() * val_17.三丐丟丒业丞东三丕()) >= val_17.丗三三丐丁东丘丌一())
            {
                goto label_7;
            }
            
            val_17 = val_17.丄且丞且且且世丂丅() * val_17.三丐丟丒业丞东三丕();
            return (bool)(val_17.三丐丟丒业丞东三丕() <= (一丐丗丁丞丆丅丟丄.CurrencyCount + val_17)) ? 1 : 0;
            label_4:
            val_18 = 0;
            return (bool)(val_17.三丐丟丒业丞东三丕() <= (一丐丗丁丞丆丅丟丄.CurrencyCount + val_17)) ? 1 : 0;
            label_7:
            val_17 = val_17.丗三三丐丁东丘丌一() - (val_17.丝丗丑万万丗不丙丁() * val_17.三丐丟丒业丞东三丕());
            return (bool)(val_17.三丐丟丒业丞东三丕() <= (一丐丗丁丞丆丅丟丄.CurrencyCount + val_17)) ? 1 : 0;
        }
        private void 丙丅专业丌与一上下(Rilisoft.BuyCraftDetailsWindow.丑业专丄七与与丕上 下丗丁丒丘东丂不丑)
        {
            UILabel val_8;
            string val_9;
            string val_10;
            val_8 = this.header;
            if(val_8 == 0)
            {
                goto label_6;
            }
            
            val_8 = System.String.alignConst;
            this.header.text = val_8;
            if((下丗丁丒丘东丂不丑 - 1) < 2)
            {
                goto label_5;
            }
            
            if((下丗丁丒丘东丂不丑 - 3) > 1)
            {
                goto label_6;
            }
            
            val_8 = this.header;
            val_9 = "Key_4925";
            goto label_9;
            label_5:
            val_8 = this.header;
            val_9 = "Key_4772";
            label_9:
            val_8.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9);
            label_6:
            if(this._windowNameLabels == null)
            {
                    return;
            }
            
            if(this._windowNameLabels.Count < 1)
            {
                    return;
            }
            
            if(下丗丁丒丘东丂不丑 == 5)
            {
                    val_10 = "Key_6497";
            }
            else
            {
                    val_10 = "Key_4585";
            }
            
            string val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10);
            val_8 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._windowNameLabels, 丕丗丘丑丛与丑业丒:  val_6);
        }
        public override void U_Hide()
        {
            丙且上东下丏丏丟下 val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = 1152921505035919360;
            if((ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0) && (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != false))
            {
                    ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
                val_8 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三();
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_8, 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                if(Rilisoft.BuyCraftDetailsWindow.丛与万东丟丞专丆丙 == 4)
            {
                    val_8 = 1152921505261211648;
                val_10 = null;
                val_10 = null;
                if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_8 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
                ShopNGUIController.丏丙丅丕一丑丕丑丑.丆与丅世下一丟不丏(下丅丙一丂丗丅丝七:  val_8, 丕丝丟下丗丛一丕业:  false, 丙丑丄丟万上丙丈丘:  false);
            }
            
            }
            
            }
            
            this.U_Hide();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public BuyCraftDetailsWindow()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static BuyCraftDetailsWindow()
        {
            Rilisoft.BuyCraftDetailsWindow.丛与万东丟丞专丆丙 = 0;
            Rilisoft.BuyCraftDetailsWindow.丙丕业丕丛不丌丐丏 = 1;
        }
    
    }

}
