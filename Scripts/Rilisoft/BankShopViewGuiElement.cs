using UnityEngine;

namespace Rilisoft
{
    public class BankShopViewGuiElement : GuiElementBase
    {
        // Fields
        private bool _openBankByClick;
        private Rilisoft.PrefabHandler _prefabHandler;
        private Rilisoft.BankShopViewGuiElement.专丑上丑不丌丈丂丐 _viewType;
        public bool HideButtons;
        public bool InteractionEnabled;
        public bool ShowCoins;
        public bool ShowPixelBucks;
        public bool ShowEventCurrency;
        public bool ShowOnlyEventCurrency;
        public bool ShowTickets;
        public bool X3Enabled;
        public string desiredCurrency;
        private Rilisoft.BankShopView <丝丟丆丐业丘丏丝上>k__BackingField;
        private bool <东七丕丙东丙丑丅丌>k__BackingField;
        private System.EventHandler 丛三丌丛丒下三丝一;
        
        // Properties
        internal Rilisoft.BankShopViewGuiElement.专丑上丑不丌丈丂丐 丄丂丏世丛丏万三丆 { get; set; }
        internal Rilisoft.BankShopView 丅上丗丌丄丏丅丆三 { get; set; }
        public override bool 七七业丒丟丝丘不丞 { get; }
        private bool 丏与丁三丞丞三丄上 { get; set; }
        
        // Methods
        internal Rilisoft.BankShopViewGuiElement.专丑上丑不丌丈丂丐 丌三不七丌丗丞丌专()
        {
            return (专丑上丑不丌丈丂丐)this._viewType;
        }
        internal void 且不丄丂上专丗三七(Rilisoft.BankShopViewGuiElement.专丑上丑不丌丈丂丐 丙业与丙丗丝不丈东)
        {
            this._viewType = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.BankShopView 丄世下丟三与丛世丅()
        {
            return (Rilisoft.BankShopView)this.<丝丟丆丐业丘丏丝上>k__BackingField;
        }
        private void 丄丆东与丕丄丟丅上(Rilisoft.BankShopView 丙业与丙丗丝不丈东)
        {
            this.<丝丟丆丐业丘丏丝上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        private bool 与上东丝七东上丞丕()
        {
            return (bool)this.<东七丕丙东丙丑丅丌>k__BackingField;
        }
        private void 丙七丗世丄丌七丝专(bool 丙业与丙丗丝不丈东)
        {
            this.<东七丕丙东丙丑丅丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丄下与业丏丂丞不世(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛三丌丛丒下三丝一, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛三丌丛丒下三丝一 != 1152921542134344216);
        
        }
        internal void 丆世丅三下丗丆丝丕(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛三丌丛丒下三丝一, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛三丌丛丒下三丝一 != 1152921542134480792);
        
        }
        protected override void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    return;
            }
            
            this.业下丛七业丆丛万丂();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_117;
            UnityEngine.GameObject val_118;
            float val_119;
            float val_120;
            float val_121;
            Rilisoft.BankShopView val_122;
            bool val_123;
            var val_124;
            System.Action<UISprite> val_126;
            Rilisoft.BankShopView val_127;
            UnityEngine.Transform val_128;
            var val_132;
            Rilisoft.BankShopView val_133;
            Rilisoft.BankShopView val_134;
            UnityEngine.GameObject val_135;
            Rilisoft.BankShopView val_136;
            var val_137;
            var val_138;
            var val_139;
            var val_140;
            var val_141;
            var val_142;
            var val_143;
            bool val_144;
            var val_145;
            var val_146;
            var val_147;
            var val_148;
            float val_149;
            float val_150;
            var val_151;
            var val_152;
            val_117 = 1152921504848912384;
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField = this.GetComponentInChildren<Rilisoft.BankShopView>();
            }
            
            if(this._prefabHandler.Prefab == 0)
            {
                    if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    return;
            }
            
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    if((丞东丑专丛丆丄丝世.丏丆专业丞丗东丙丏<Rilisoft.BankShopView>(丝三丁东丈丒世丅业:  this._prefabHandler.Prefab)) == false)
            {
                    return;
            }
            
                UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefabHandler.Prefab);
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_10, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
                val_118 = val_10.transform;
                val_118.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
                val_118.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
                val_119 = val_16.x;
                val_120 = val_16.z;
                val_121 = val_16.y;
                val_118.localScale = new UnityEngine.Vector3() {x = val_119, y = val_121, z = val_120};
                val_122 = val_10.GetComponent<Rilisoft.BankShopView>();
                this.<丝丟丆丐业丘丏丝上>k__BackingField = val_122;
            }
            else
            {
                    val_122 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            }
            
            if(val_122 == 0)
            {
                    return;
            }
            
            System.Action<Rilisoft.ButtonHandler> val_20 = null;
            val_123 = 1152921530799863648;
            val_20 = new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丏丄且丝丁且业世丘(Rilisoft.ButtonHandler 一丗世三专三万丞丞));
            Rilisoft.ButtonHandler val_21 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButton.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  val_20);
            Rilisoft.ButtonHandler val_24 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButton.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丂丟丈与丈丒丄业万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
            val_124 = null;
            val_124 = null;
            val_126 = BankShopViewGuiElement.<>c.<>9__29_2;
            if(val_126 == null)
            {
                    System.Action<UISprite> val_25 = null;
                val_126 = val_25;
                val_25 = new System.Action<UISprite>(object:  BankShopViewGuiElement.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BankShopViewGuiElement.<>c::丅丝丆三与丑世三丝(UISprite 丏丛与丅丛丌万专丌));
                BankShopViewGuiElement.<>c.<>9__29_2 = val_126;
            }
            
            UISprite val_26 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UISprite>(丄三丅七丆丛与与上:  this.<丝丟丆丐业丘丏丝上>k__BackingField.eventIconSprite, 七丐丅专且专七三丆:  val_25);
            UIButton val_27 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript;
            if(this.InteractionEnabled == false)
            {
                goto label_46;
            }
            
            if(val_27 != 0)
            {
                    if((this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.enabled) != true)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.enabled = true;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.enabled = true;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.state = 0;
            }
            
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript) != 0)
            {
                    if((this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.enabled) != true)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.enabled = true;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.enabled = true;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.state = 0;
            }
            
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript) == 0)
            {
                goto label_98;
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                goto label_78;
            }
            
            goto label_98;
            label_46:
            if(val_27 != 0)
            {
                    if((this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.enabled) != false)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.enabled = false;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.enabled = false;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonScript.state = 3;
            }
            
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript) == 0)
            {
                goto label_98;
            }
            
            label_78:
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.enabled) != false)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.enabled = false;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.enabled = false;
                this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonScript.state = 3;
            }
            
            label_98:
            if(this.HideButtons == false)
            {
                goto label_105;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButton, 丏业丟一东丂东丘丛:  false);
            val_127 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) != null)
            {
                goto label_110;
            }
            
            val_127 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            if(val_127 == null)
            {
                goto label_130;
            }
            
            label_110:
            val_128 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter;
            UnityEngine.Vector3 val_57 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter.localPosition;
            UnityEngine.Vector3 val_58 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter.localPosition;
            val_132 = val_57.y;
            goto label_115;
            label_105:
            if(this._viewType == 1)
            {
                goto label_116;
            }
            
            if(this._viewType != 0)
            {
                goto label_117;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButton, 丏业丟一东丂东丘丛:  false);
            val_133 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            val_134 = val_133;
            if(val_133 != null)
            {
                goto label_122;
            }
            
            val_134 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            if(val_134 == null)
            {
                goto label_130;
            }
            
            label_122:
            val_135 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButton;
            goto label_124;
            label_116:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButton, 丏业丟一东丂东丘丛:  true);
            val_133 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            val_136 = val_133;
            if(val_133 != null)
            {
                goto label_129;
            }
            
            val_136 = this.<丝丟丆丐业丘丏丝上>k__BackingField;
            if(val_136 == null)
            {
                goto label_130;
            }
            
            label_129:
            val_135 = this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButton;
            label_124:
            val_128 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter;
            UnityEngine.Vector3 val_60 = val_135.transform.localPosition;
            UnityEngine.Vector3 val_61 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter.localPosition;
            UnityEngine.Vector3 val_62 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ObjectForCenter.localPosition;
            val_132 = val_61.y;
            label_115:
            val_121 = 0f;
            val_128.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_121, z = 0f};
            label_117:
            if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null)
            {
                    this.X3Enabled = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌();
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BgSimple, 丏业丟一东丂东丘丛:  (this.X3Enabled == false) ? 1 : 0);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.BgX3, 丏业丟一东丂东丘丛:  this.X3Enabled);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.FrameX3Shop, 丏业丟一东丂东丘丛:  this.X3Enabled);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.FrameX3Bank, 丏业丟一东丂东丘丛:  this.X3Enabled);
            val_137 = 0;
            goto label_151;
            label_158:
            if(this.ShowTickets != false)
            {
                    bool val_116 = this.ShowEventCurrency;
                val_116 = val_116 ^ 1;
                val_138 = val_116 & 255;
            }
            else
            {
                    val_138 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.ticketObjects[0], 丏业丟一东丂东丘丛:  (val_138 != 0) ? 1 : 0);
            val_137 = 1;
            label_151:
            if(val_137 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.ticketObjects.Length))
            {
                goto label_158;
            }
            
            val_139 = 0;
            goto label_160;
            label_165:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.coinsObjects[0], 丏业丟一东丂东丘丛:  (this.ShowCoins == true) ? 1 : 0);
            val_139 = 1;
            label_160:
            if(val_139 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.coinsObjects.Length))
            {
                goto label_165;
            }
            
            val_140 = 0;
            goto label_167;
            label_174:
            if(this.ShowOnlyEventCurrency != false)
            {
                    val_141 = 0;
            }
            else
            {
                    bool val_119 = this.ShowPixelBucks;
                val_119 = val_119 ^ 1;
                val_141 = val_119 & 255;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.gemsObjects[0], 丏业丟一东丂东丘丛:  (val_141 == true) ? 1 : 0);
            val_140 = 1;
            label_167:
            if(val_140 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.gemsObjects.Length))
            {
                goto label_174;
            }
            
            val_142 = 0;
            goto label_176;
            label_181:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.pixelBucksObjects[0], 丏业丟一东丂东丘丛:  (this.ShowPixelBucks == true) ? 1 : 0);
            val_142 = 1;
            label_176:
            if(val_142 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.pixelBucksObjects.Length))
            {
                goto label_181;
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects) == null)
            {
                goto label_183;
            }
            
            val_143 = 0;
            goto label_185;
            label_192:
            if(this.ShowTickets != false)
            {
                    val_144 = this.ShowEventCurrency;
            }
            else
            {
                    val_144 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects[0], 丏业丟一东丂东丘丛:  (val_144 != 0) ? 1 : 0);
            val_143 = 1;
            label_185:
            if(val_143 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects.Length))
            {
                goto label_192;
            }
            
            label_183:
            if((this.ShowCoins == true) || ((this.<东七丕丙东丙丑丅丌>k__BackingField) == true))
            {
                goto label_194;
            }
            
            val_145 = 0;
            goto label_196;
            label_204:
            UnityEngine.Transform val_73 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ticketObjects[0].transform;
            UnityEngine.Vector3 val_74 = val_73.localPosition;
            if(val_73 != null)
            {
                    UnityEngine.Vector3 val_77 = val_73.localPosition;
                val_146 = val_77.y;
            }
            else
            {
                    UnityEngine.Vector3 val_78 = 0.localPosition;
                val_146 = val_78.y;
            }
            
            UnityEngine.Vector3 val_79 = val_73.localPosition;
            float val_80 = (val_74.x + 112f) + ((this.ShowOnlyEventCurrency == true) ? 112f : 0f);
            val_121 = 0f;
            val_73.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_121, z = 0f};
            val_145 = 1;
            label_196:
            if(val_145 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.ticketObjects.Length))
            {
                goto label_204;
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects) == null)
            {
                goto label_206;
            }
            
            val_147 = 0;
            goto label_208;
            label_216:
            UnityEngine.Transform val_81 = this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects[0].transform;
            UnityEngine.Vector3 val_82 = val_81.localPosition;
            if(val_81 != null)
            {
                    UnityEngine.Vector3 val_85 = val_81.localPosition;
                val_148 = val_85.y;
            }
            else
            {
                    UnityEngine.Vector3 val_86 = 0.localPosition;
                val_148 = val_86.y;
            }
            
            UnityEngine.Vector3 val_87 = val_81.localPosition;
            float val_88 = (val_82.x + 112f) + ((this.ShowOnlyEventCurrency == true) ? 112f : 0f);
            val_121 = 0f;
            val_81.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_121, z = 0f};
            val_147 = 1;
            label_208:
            if(val_147 < (this.<丝丟丆丐业丘丏丝上>k__BackingField.eventObjects.Length))
            {
                goto label_216;
            }
            
            label_206:
            this.<东七丕丙东丙丑丅丌>k__BackingField = true;
            label_194:
            UnityEngine.Vector3 val_91 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.center;
            UnityEngine.Vector3 val_93 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.center;
            this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_96 = this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.size;
            UnityEngine.Vector2 val_97 = new UnityEngine.Vector2(x:  118f, y:  val_96.y);
            UnityEngine.Vector3 val_98 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_97.x, y = val_97.y});
            this.<丝丟丆丐业丘丏丝上>k__BackingField.ShopButtonCollider.size = new UnityEngine.Vector3() {x = val_98.x, y = val_98.y, z = val_98.z};
            if(this.ShowTickets != false)
            {
                    val_149 = mem[106040220 + (this.ShowCoins) << 2];
                val_149 = 106040220 + (this.ShowCoins) << 2;
            }
            else
            {
                    val_149 = -155f;
            }
            
            UnityEngine.Vector3 val_101 = this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.center;
            UnityEngine.Vector3 val_103 = this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.center;
            this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.ShowTickets != false)
            {
                    val_150 = mem[106040228 + (this.ShowCoins) << 2];
                val_150 = 106040228 + (this.ShowCoins) << 2;
            }
            else
            {
                    val_150 = 320f;
            }
            
            UnityEngine.Vector3 val_106 = this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.size;
            UnityEngine.Vector2 val_107 = new UnityEngine.Vector2(x:  val_150, y:  val_106.y);
            UnityEngine.Vector3 val_108 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_107.x, y = val_107.y});
            val_119 = val_108.x;
            val_120 = val_108.z;
            this.<丝丟丆丐业丘丏丝上>k__BackingField.BankButtonCollider.size = new UnityEngine.Vector3() {x = val_119, y = val_108.y, z = val_120};
            val_151 = 230;
            this.<丝丟丆丐业丘丏丝上>k__BackingField.frameX3Indicators.width = (this.ShowCoins == true) ? 344 : 230;
            if(this.ShowOnlyEventCurrency == false)
            {
                goto label_249;
            }
            
            label_265:
            val_118 = 118;
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.frameX3Indicators) != null)
            {
                goto label_268;
            }
            
            label_269:
            label_268:
            this.<丝丟丆丐业丘丏丝上>k__BackingField.frameX3Indicators.width = 118;
            val_117 = 0;
            goto label_252;
            label_263:
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.GetComponentsInChildren<CoinsAddIndic>()[0]) != 0)
            {
                    val_152 = mem[val_110[0x0][0] + 89];
                val_152 = val_110[0x0][0] + 89;
            }
            else
            {
                    val_152 = 0;
            }
            
            val_118 = 0.gameObject;
            if(val_152 != 0)
            {
                    val_123 = this.ShowOnlyEventCurrency;
                var val_112 = (val_123 == false) ? 1 : 0;
            }
            else
            {
                    val_123 = this.ShowCoins;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_118, 丏业丟一东丂东丘丛:  (val_123 == true) ? 1 : 0);
            val_117 = 1;
            label_252:
            if(val_117 < val_110.Length)
            {
                goto label_263;
            }
            
            return;
            label_249:
            if(this.ShowTickets != true)
            {
                    if(this.ShowCoins == false)
            {
                goto label_265;
            }
            
            }
            
            int val_114 = this.<丝丟丆丐业丘丏丝上>k__BackingField.frameX3Indicators.width;
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField.frameX3Indicators) != null)
            {
                goto label_268;
            }
            
            goto label_269;
            label_130:
        }
        private void 丏丟丆丌丙业丒丘东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
        {
            var val_3;
            var val_4;
            string val_5;
            var val_6;
            if(this.丛三丌丛丒下三丝一 != null)
            {
                    val_3 = null;
                val_3 = null;
                this.丛三丌丛丒下三丝一.Invoke(sender:  this, e:  System.EventArgs.Empty);
                return;
            }
            
            if(this._openBankByClick == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_5 = 0;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.desiredCurrency)) != false)
            {
                    val_5 = this.desiredCurrency;
            }
            
            val_6 = null;
            val_6 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  false, 丆丟七丝丏业丅上丄:  val_5, 世丁丙世丄一万丆三:  "", 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
        }
        protected override void 东丟丘世丕丆下不万()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丝一丅丆三东丂丞七();
        }
        protected override void 丙丝七丅丑三丞丂且()
        {
            this.<丝丟丆丐业丘丏丝上>k__BackingField.gameObject.gameObject.SetActive(value:  false);
        }
        protected override void OnDisable()
        {
            if(this.专三三上东丆丒丂丘() == false)
            {
                    return;
            }
            
            this.专丌丅下万丐三丗丗();
        }
        public BankShopViewGuiElement()
        {
            this._prefabHandler = new Rilisoft.PrefabHandler();
            this.InteractionEnabled = true;
            this.ShowCoins = true;
            this.desiredCurrency = "";
        }
        private void 丏丄且丝丁且业世丘(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
        {
            一丗世三专三万丞丞.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丏丟丆丌丙业丒丘东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
            一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丏丟丆丌丙业丒丘东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        private void 丂丟丈与丈丒丄业万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
        {
            一丗世三专三万丞丞.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丏丟丆丌丙业丒丘东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
            一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BankShopViewGuiElement::丏丟丆丌丙业丒丘东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
    
    }

}
