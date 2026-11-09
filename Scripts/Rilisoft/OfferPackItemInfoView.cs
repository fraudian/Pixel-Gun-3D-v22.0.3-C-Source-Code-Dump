using UnityEngine;

namespace Rilisoft
{
    internal class OfferPackItemInfoView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color 万丞丞丄丄不丐丛丗;
        private UnityEngine.Color 丟且丐丂丂三下丒专;
        private UnityEngine.Color 丆丙丅丅东且万一丄;
        private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.OfferItem 业丙丕丁上万丑丑丂;
        private UnityEngine.GameObject _baseWindow;
        private UIBasicSprite _itemTexture;
        private Rilisoft.TextGroup _headerText;
        private Rilisoft.TextGroup _rewardText;
        private UILabel _rewardDescriptionLabel;
        private UnityEngine.GameObject _partsIndicator;
        private UILabel _partsCountLabel;
        
        // Properties
        private UIBasicSprite 下丝万丄丕世丝丝与 { get; }
        
        // Methods
        private UIBasicSprite 丑世丝世丈世丌丝七()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._itemTexture);
            this._itemTexture = val_1;
            return val_1;
        }
        public void Show(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
        {
            ArmoryInfoScreenController val_61;
            var val_62;
            var val_63;
            ShopNGUIController val_64;
            string val_65;
            Rilisoft.TextGroup val_66;
            string val_67;
            var val_68;
            System.Action<UIPanel> val_70;
            Rilisoft.TextGroup val_73;
            string val_74;
            val_61 = this;
            val_62 = null;
            val_62 = null;
            val_63 = 1152921504848912384;
            val_64 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(val_64 == 0)
            {
                    return;
            }
            
            val_64 = this.gameObject;
            val_64.SetActive(value:  true);
            this.业丙丕丁上万丑丑丂 = 丏且丕丄丁丟丆丏丁;
            if(丏且丕丄丁丟丆丏丁 == null)
            {
                    return;
            }
            
            if((丏且丕丄丁丟丆丏丁.<Type>k__BackingField) != 10)
            {
                goto label_9;
            }
            
            this._baseWindow.SetActive(value:  false);
            if(this._partsIndicator != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsIndicator, 丏业丟一东丂东丘丛:  false);
            }
            
            三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.业丙丕丁上万丑丑丂.<Id>k__BackingField);
            if(val_4 == null)
            {
                goto label_18;
            }
            
            val_65 = val_4.与不丞丑七丘丁丂丛();
            goto label_19;
            label_9:
            this._baseWindow.SetActive(value:  true);
            UIBasicSprite val_6 = this.丑世丝世丈世丌丝七();
            UnityEngine.Texture val_7 = this.业丙丕丁上万丑丑丂.Texture;
            val_64 = this.业丙丕丁上万丑丑丂.Name;
            this._rewardText.Text = val_64;
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 1000)
            {
                goto label_25;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 1060)
            {
                goto label_26;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 1080)
            {
                goto label_27;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1110)
            {
                goto label_28;
            }
            
            if(((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1310) || ((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1340))
            {
                goto label_72;
            }
            
            goto label_185;
            label_25:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 50)
            {
                goto label_32;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 70)
            {
                goto label_33;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 80)
            {
                goto label_34;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 85)
            {
                goto label_35;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 1000)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1836");
            val_66 = this._headerText;
            val_67 = "Key_0951";
            goto label_141;
            label_18:
            val_65 = 0.与不丞丑七丘丁丂丛();
            label_19:
            UnityEngine.Object val_15 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
            if(val_15 != null)
            {
                    var val_16 = (null == null) ? (val_15) : 0;
            }
            
            ArmoryInfoScreenController val_17 = 0.GetComponent<ArmoryInfoScreenController>();
            this.下丏丗且丅丟丄丂与 = val_17;
            val_17.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            val_68 = null;
            val_68 = null;
            val_70 = OfferPackItemInfoView.<>c.<>9__8_0;
            if(val_70 == null)
            {
                    System.Action<UIPanel> val_31 = null;
                val_70 = val_31;
                val_31 = new System.Action<UIPanel>(object:  OfferPackItemInfoView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void OfferPackItemInfoView.<>c::且丑专三三丂与且丕(UIPanel 七丏丄丅丌业与且丙));
                OfferPackItemInfoView.<>c.<>9__8_0 = val_70;
            }
            
            UIPanel val_32 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIPanel>(丄三丅七丆丛与与上:  this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>(), 七丐丅专且专七三丆:  val_31);
            val_64 = this.下丏丗且丅丟丄丂与;
            this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
            val_61 = this.下丏丗且丅丟丄丂与;
            val_61.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_65, 七丆丒与丗丌丄且丂:  val_4.万上丄下业丛丌不丈() - 1), 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
            return;
            label_26:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 1020)
            {
                goto label_71;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1030)
            {
                goto label_72;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1050)
            {
                goto label_73;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 1060)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4054");
            val_66 = this._headerText;
            val_67 = "Key_4053";
            goto label_141;
            label_32:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) <= 30)
            {
                goto label_79;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 40)
            {
                goto label_80;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 50)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1832");
            val_66 = this._headerText;
            val_67 = "Key_0425";
            goto label_141;
            label_27:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1070)
            {
                goto label_86;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 1080)
            {
                goto label_185;
            }
            
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.业丙丕丁上万丑丑丂.<Id>k__BackingField)) & 2147483648) != 0)
            {
                goto label_91;
            }
            
            goto label_92;
            label_33:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 60)
            {
                goto label_93;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 70)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2694");
            val_66 = this._headerText;
            val_67 = "Key_2197";
            goto label_141;
            label_71:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1010)
            {
                goto label_99;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 1020)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2899");
            val_66 = this._headerText;
            val_67 = "Key_1205";
            goto label_141;
            label_79:
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 20)
            {
                goto label_105;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) != 30)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2133");
            val_66 = this._headerText;
            val_67 = "Key_1857";
            goto label_141;
            label_72:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3805");
            val_66 = this._headerText;
            string val_41 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3804"), arg0:  System.String.alignConst);
            goto label_114;
            label_80:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1830");
            val_66 = this._headerText;
            val_67 = "Key_0429";
            goto label_141;
            label_86:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4575");
            val_66 = this._headerText;
            val_67 = "Key_4950";
            goto label_141;
            label_93:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1831");
            val_66 = this._headerText;
            val_67 = "Key_0426";
            goto label_141;
            label_99:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1835");
            val_66 = this._headerText;
            val_67 = "Key_0950";
            goto label_141;
            label_105:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1829");
            val_66 = this._headerText;
            val_67 = "Key_0428";
            goto label_141;
            label_28:
            val_73 = this._headerText;
            val_74 = "Key_5772";
            goto label_179;
            label_34:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3539");
            val_66 = this._headerText;
            val_67 = "Key_2595";
            goto label_141;
            label_35:
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3398");
            val_66 = this._headerText;
            val_67 = "Key_3502";
            label_141:
            label_114:
            val_64 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_67);
            label_169:
            val_66.Text = val_64;
            label_185:
            if(this._partsIndicator == 0)
            {
                    return;
            }
            
            if((this.业丙丕丁上万丑丑丂.<Type>k__BackingField) == 1070)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsIndicator, 丏业丟一东丂东丘丛:  true);
                if(this._partsCountLabel == 0)
            {
                    return;
            }
            
                val_61 = this._partsCountLabel;
                val_61.text = this.业丙丕丁上万丑丑丂._countContainer.ToString();
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsIndicator, 丏业丟一东丂东丘丛:  false);
            return;
            label_73:
            Rilisoft.丛且世丐丆上七业丁 val_54 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_54 == null)
            {
                goto label_185;
            }
            
            this._rewardDescriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_54.不丅且万丐专丄丌丂());
            string val_58 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_54.丟万丏且上业丐丈一());
            if(this._headerText != null)
            {
                goto label_169;
            }
            
            goto label_169;
            label_91:
            label_92:
            if(( & 1) == 0)
            {
                goto label_171;
            }
            
            if( != 210000)
            {
                goto label_171;
            }
            
            val_73 = this._headerText;
            val_74 = "Key_7580";
            goto label_179;
            label_171:
            if(( & 1) == 0)
            {
                goto label_176;
            }
            
            if( != 160000)
            {
                goto label_176;
            }
            
            val_73 = this._headerText;
            val_74 = "Key_7582";
            goto label_179;
            label_176:
            val_73 = this._headerText;
            val_74 = "Key_5555";
            label_179:
            val_73.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_74);
            this._rewardDescriptionLabel.text = this.业丙丕丁上万丑丑丂.Description;
            goto label_185;
        }
        public void Hide()
        {
            if(this.下丏丗且丅丟丄丂与 != 0)
            {
                    if(this.下丏丗且丅丟丄丂与.gameObject != 0)
            {
                    this.下丏丗且丅丟丄丂与.丞丏世丆丄上丆一七();
            }
            
            }
            
            this._baseWindow.SetActive(value:  false);
            this.gameObject.SetActive(value:  false);
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        protected void OnEnable()
        {
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.业三不丈丌丗丙丆丞();
            this.万丞丞丄丄不丐丛丗 = val_1;
            mem[1152921543294471548] = val_1.g;
            mem[1152921543294471552] = val_1.b;
            mem[1152921543294471556] = val_1.a;
            UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.丗丙丟丂且丂丗业世();
            this.丟且丐丂丂三下丒专 = val_2;
            mem[1152921543294471564] = val_2.g;
            mem[1152921543294471568] = val_2.b;
            mem[1152921543294471572] = val_2.a;
            UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
            this.丆丙丅丅东且万一丄 = val_3;
            mem[1152921543294471580] = val_3.g;
            mem[1152921543294471584] = val_3.b;
            mem[1152921543294471588] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.OfferPackItemInfoView::Hide()), 与且专丈不万东一万:  0);
        }
        protected void OnDisable()
        {
            PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.万丞丞丄丄不丐丛丗});
            PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丟且丐丂丂三下丒专});
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丆丙丅丅东且万一丄});
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public OfferPackItemInfoView()
        {
        
        }
    
    }

}
