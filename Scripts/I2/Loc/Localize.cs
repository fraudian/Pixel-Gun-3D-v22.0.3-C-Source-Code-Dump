using UnityEngine;

namespace I2.Loc
{
    public class Localize : MonoBehaviour
    {
        // Fields
        public I2.Loc.专丞下三丒东专与且 TypeActionLocalizationLabel;
        public string mTerm;
        public string mTermSecondary;
        public string FinalTerm;
        public string FinalSecondaryTerm;
        public I2.Loc.Localize.丈三与业上上丏丑与 PrimaryTermModifier;
        public I2.Loc.Localize.丈三与业上上丏丑与 SecondaryTermModifier;
        public UnityEngine.Object mTarget;
        public UnityEngine.Events.UnityEvent EventFindTarget;
        public I2.Loc.Localize.丑丑丕丟业一上丐丂 EventSetFinalTerms;
        public I2.Loc.Localize.丂七丒万不业下丒丝 EventDoLocalize;
        public bool CanUseSecondaryTerm;
        public bool AllowMainTermToBeRTL;
        public bool AllowSecondTermToBeRTL;
        public bool IgnoreRTL;
        public UnityEngine.Object[] TranslatedObjects;
        public I2.Loc.EventCallback LocalizeCallBack;
        public static string MainTranslation;
        public static string SecondaryTranslation;
        private UILabel 丐与丘丙与丌丝与丆;
        private UISprite 七专丄万不丑丕丙一;
        private UITexture 丙丝东不丄丙丄上一;
        private UIInput 丕丐丄上专丂丛东丆;
        private bool 世下丙七世丝丘不丅;
        private UnityEngine.UI.Text 丁丒且丒七且七且丟;
        private UnityEngine.UI.Image 万丕七专丅丗丏上丕;
        private UnityEngine.UI.RawImage 下丟七丗丏丏丞丙且;
        private UnityEngine.GUIText 丆丅一专且七丂七世;
        private UnityEngine.TextMesh 丆丂世丘丟丞丄丞与;
        private UnityEngine.AudioSource 丄业世丗不丒丄万丄;
        private UnityEngine.GUITexture 丄且丄丂下丝东丕业;
        private UnityEngine.GameObject 丆丆丒丗丌下丛丘丝;
        
        // Properties
        public string 丝丐丟三业丟丏万且 { get; set; }
        public string 丘万与业丘万一丐且 { get; set; }
        private UIInput 业丝与丟丙三下专丑 { get; }
        
        // Methods
        public string get_Term()
        {
            return (string)this.mTerm;
        }
        public void set_Term(string 丙业与丙丗丝不丈东)
        {
            this.mTerm = 丙业与丙丗丝不丈东;
        }
        public string get_SecondaryTerm()
        {
            return (string)this.mTermSecondary;
        }
        public void set_SecondaryTerm(string 丙业与丙丗丝不丈东)
        {
            this.mTermSecondary = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            this.丟丗丌丈丟下丅业丁();
            this.EventFindTarget.Invoke();
        }
        private void 丟丗丌丈丟下丅业丁()
        {
            if(this.EventFindTarget.GetPersistentEventCount() != 0)
            {
                    return;
            }
            
            this.RegisterEvents_NGUI();
            this.RegisterEvents_UGUI();
            this.RegisterEvents_UnityStandard();
        }
        private void OnEnable()
        {
            this.OnLocalize();
        }
        public void OnLocalize()
        {
            var val_24;
            var val_27;
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业())) != false)
            {
                    return;
            }
            
            if(this.EventDoLocalize == null)
            {
                    bool val_6 = this.FindTarget();
                if(this.EventDoLocalize == null)
            {
                    return;
            }
            
            }
            
            bool val_9 = this.GetFinalTerms(丞三一丟丟丟丟丁上: out  this.FinalTerm, 丘万与业丘万一丐且: out  this.FinalSecondaryTerm);
            if((System.String.IsNullOrEmpty(value:  this.FinalTerm)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  mem[this.FinalSecondaryTerm])) == true)
            {
                    return;
            }
            
            }
            
            I2.Loc.Localize.MainTranslation = I2.Loc.丗丈下丕丟丟丙七丞.万丘丈丌丛丐下且一(丝丐丟三业丟丏万且:  mem[this.FinalTerm]);
            I2.Loc.Localize.SecondaryTranslation = I2.Loc.丗丈下丕丟丟丙七丞.万丘丈丌丛丐下且一(丝丐丟三业丟丏万且:  mem[this.FinalSecondaryTerm]);
            if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.SecondaryTranslation)) == true)
            {
                    return;
            }
            
            }
            
            this.LocalizeCallBack.丞丙东丌一三专丏不(丒丗丒丞万万丗丟丂:  this);
            val_24 = null;
            val_24 = null;
            if(I2.Loc.丗丈下丕丟丟丙七丞.丐丏一万丙下丐与丈 != false)
            {
                    if(this.IgnoreRTL == false)
            {
                goto label_19;
            }
            
            }
            
            label_36:
            if(this.PrimaryTermModifier == 2)
            {
                goto label_20;
            }
            
            if(this.PrimaryTermModifier != 1)
            {
                goto label_21;
            }
            
            string val_16 = I2.Loc.Localize.MainTranslation.ToUpper();
            goto label_23;
            label_20:
            label_23:
            I2.Loc.Localize.MainTranslation = I2.Loc.Localize.MainTranslation.ToLower();
            label_21:
            if(this.SecondaryTermModifier == 1)
            {
                goto label_25;
            }
            
            if(this.SecondaryTermModifier != 2)
            {
                goto label_26;
            }
            
            string val_18 = I2.Loc.Localize.SecondaryTranslation.ToLower();
            goto label_28;
            label_25:
            label_28:
            val_27 = null;
            I2.Loc.Localize.SecondaryTranslation = I2.Loc.Localize.SecondaryTranslation.ToUpper();
            goto label_30;
            label_26:
            val_27 = null;
            label_30:
            this.EventDoLocalize.Invoke(丝丁且丑丒丅东丂丏:  I2.Loc.Localize.MainTranslation, 丞丌丕丑三丐七丐丂:  I2.Loc.Localize.SecondaryTranslation);
            return;
            label_19:
            if(this.AllowMainTermToBeRTL != false)
            {
                    if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) != true)
            {
                    I2.Loc.Localize.MainTranslation = ArabicSupport.ArabicFixer.Fix(str:  I2.Loc.Localize.MainTranslation);
            }
            
            }
            
            if((this.AllowSecondTermToBeRTL == false) || ((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.SecondaryTranslation)) == true))
            {
                goto label_36;
            }
            
            I2.Loc.Localize.SecondaryTranslation = ArabicSupport.ArabicFixer.Fix(str:  I2.Loc.Localize.SecondaryTranslation);
            goto label_36;
        }
        public bool FindTarget()
        {
            if(this.EventFindTarget.GetPersistentEventCount() == 0)
            {
                    this.丟丗丌丈丟下丅业丁();
            }
            
            this.EventFindTarget.Invoke();
            return (bool)(this.EventDoLocalize != 0) ? 1 : 0;
        }
        public void FindAndCacheTarget<T>(ref T 一丙且丝丝七丘丟业, I2.Loc.Localize.丑丑丕丟业一上丐丂 丅丏丘丄且七丝与与, I2.Loc.Localize.丂七丒万不业下丒丝 万丘万三业丙丗世丌, bool 丟七丛三丗万丟且丈, bool 丑丟不下丝一专丌丈, bool 丈丁七丛与丞丘丑丝)
        {
            bool val_7;
            bool val_8;
            bool val_9;
            丂七丒万不业下丒丝 val_10;
            丑丑丕丟业一上丐丂 val_11;
            var val_12;
            object val_13;
            val_7 = 丈丁七丛与丞丘丑丝;
            val_8 = 丑丟不下丝一专丌丈;
            val_9 = 丟七丛三丗万丟且丈;
            val_10 = 万丘万三业丙丗世丌;
            val_11 = 丅丏丘丄且七丝与与;
            val_12 = 1152921504848912384;
            if(this.mTarget == 0)
            {
                goto label_3;
            }
            
            if(this.mTarget == null)
            {
                goto label_6;
            }
            
            val_13 = this.mTarget;
            if(val_13 != null)
            {
                goto label_7;
            }
            
            label_6:
            val_13 = 0;
            label_7:
            一丙且丝丝七丘丟业 = val_13;
            val_12 = 1152921504848912384;
            val_7 = val_7;
            val_8 = val_8;
            val_9 = val_9;
            val_10 = val_10;
            val_11 = val_11;
            if((this.mTarget == null) || (this.mTarget != null))
            {
                goto label_12;
            }
            
            goto label_12;
            label_3:
            一丙且丝丝七丘丟业 = this;
            this.mTarget = this;
            label_12:
            if(this == 0)
            {
                    return;
            }
            
            this.EventSetFinalTerms = val_11;
            this.EventDoLocalize = val_10;
            this.CanUseSecondaryTerm = val_9;
            this.AllowMainTermToBeRTL = val_8;
            this.AllowSecondTermToBeRTL = val_7;
        }
        private void 丏丑世七丄东丟丟丝(ref UnityEngine.GameObject 一丙且丝丝七丘丟业, I2.Loc.Localize.丑丑丕丟业一上丐丂 丅丏丘丄且七丝与与, I2.Loc.Localize.丂七丒万不业下丒丝 万丘万三业丙丗世丌, bool 丟七丛三丗万丟且丈, bool 丑丟不下丝一专丌丈, bool 丈丁七丛与丞丘丑丝)
        {
            UnityEngine.GameObject val_13;
            UnityEngine.GameObject val_14;
            if(this.mTarget != 一丙且丝丝七丘丟业)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  一丙且丝丝七丘丟业)) != false)
            {
                    UnityEngine.Object.Destroy(obj:  一丙且丝丝七丘丟业);
            }
            
            }
            
            if(this.mTarget == 0)
            {
                goto label_11;
            }
            
            if(this.mTarget == null)
            {
                goto label_12;
            }
            
            一丙且丝丝七丘丟业 = (null == null) ? this.mTarget : 0;
            goto label_19;
            label_11:
            UnityEngine.Transform val_5 = this.transform;
            if(val_5.childCount < 1)
            {
                goto label_15;
            }
            
            UnityEngine.GameObject val_8 = val_5.GetChild(index:  0).gameObject;
            goto label_18;
            label_12:
            val_13 = 0;
            一丙且丝丝七丘丟业 = 0;
            goto label_19;
            label_15:
            val_14 = 0;
            label_18:
            一丙且丝丝七丘丟业 = val_14;
            this.mTarget = val_14;
            val_13 = 一丙且丝丝七丘丟业;
            label_19:
            if(val_13 == 0)
            {
                    return;
            }
            
            this.EventSetFinalTerms = 丅丏丘丄且七丝与与;
            this.EventDoLocalize = 万丘万三业丙丗世丌;
            this.CanUseSecondaryTerm = 丟七丛三丗万丟且丈;
            this.AllowMainTermToBeRTL = 丑丟不下丝一专丌丈;
            this.AllowSecondTermToBeRTL = 丈丁七丛与丞丘丑丝;
        }
        private bool 一丗丏丐专一业丙世()
        {
            return (bool)(this.EventDoLocalize != 0) ? 1 : 0;
        }
        public bool GetFinalTerms(out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            string val_7;
            string val_8;
            if(((UnityEngine.Object.op_Implicit(exists:  this.mTarget)) != true) && (this.EventDoLocalize == null))
            {
                    bool val_2 = this.FindTarget();
            }
            
            if((System.String.IsNullOrEmpty(value:  this.mTerm)) == false)
            {
                goto label_5;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.FinalTerm)) == false)
            {
                goto label_6;
            }
            
            if(this.EventSetFinalTerms == null)
            {
                goto label_7;
            }
            
            return this.EventSetFinalTerms.Invoke(丅下丂三上不丕丒丕:  this.mTerm, 一东丙丑丛丟上一丅:  this.mTermSecondary, 丝丁且丑丒丅东丂丏: out  string val_5 = 丞三一丟丟丟丟丁上, 丞丌丕丑三丐七丐丂: out  string val_6 = 丘万与业丘万一丐且);
            label_5:
            val_7 = this.mTerm;
            val_8 = this.mTermSecondary;
            goto label_8;
            label_6:
            val_7 = this.FinalTerm;
            val_8 = this.FinalSecondaryTerm;
            label_8:
            丞三一丟丟丟丟丁上 = val_7;
            丘万与业丘万一丐且 = val_8;
            return true;
            label_7:
            丞三一丟丟丟丟丁上 = System.String.alignConst;
            丘万与业丘万一丐且 = System.String.alignConst;
            return true;
        }
        private bool 丌业丑与与上三且丟(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            丞三一丟丟丟丟丁上 = 丅下丂三上不丕丒丕;
            丘万与业丘万一丐且 = 一东丙丑丛丟上一丅;
            return true;
        }
        public void SetTerm(string 丂专丟专丕丈丘丘丌, string 丟丛不丞丞丏丏丁丕)
        {
            if((System.String.IsNullOrEmpty(value:  丂专丟专丕丈丘丘丌)) != true)
            {
                    this.mTerm = 丂专丟专丕丈丘丘丌;
            }
            
            if((System.String.IsNullOrEmpty(value:  丟丛不丞丞丏丏丁丕)) != true)
            {
                    this.mTermSecondary = 丟丛不丞丞丏丏丁丕;
            }
            
            this.OnLocalize();
        }
        internal void 丙一东丟丏业世丙专(I2.Loc.专丞下三丒东专与且 丙丑丒万丟丈世丈丑)
        {
            this.TypeActionLocalizationLabel = 丙丑丒万丟丈世丈丑;
        }
        private T 丕东世丙丙不丈丙丏<T>(ref string 丑万丈丝丂丄丆丈下, ref string 丈丐丐业上丈丝丟丐)
        {
            string val_9;
            UnityEngine.Object val_10;
            string val_2 = 0;
            this.与丁丕丈丌七且丆丆(丑丘且世丞丒丟丛与:  string val_1 = 丑万丈丝丂丄丆丈下, 丙业与丙丗丝不丈东: out  val_1, 丟丛不丞丞丏丏丁丕: out  val_2);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    val_9 = 丈丐丐业上丈丝丟丐;
            }
            else
            {
                    val_9 = val_9;
            }
            
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                    return (object)val_10;
            }
            
            val_10 = this;
            if(this != 0)
            {
                    return (object)val_10;
            }
            
            System.Char[] val_9 = ToCharArray();
            int val_7 = val_9.LastIndexOfAny(anyOf:  val_9);
            if((val_7 & 2147483648) != 0)
            {
                    return (object)val_10;
            }
            
            val_9 = val_7 + 1;
            string val_8 = val_9.Substring(startIndex:  val_9);
            val_10 = this;
            return (object)val_10;
        }
        private T 丂丟丆丙丑丞丅丈丌<T>(string 世丑丙丙东且丙下丟)
        {
            if(this == null)
            {
                
            }
        
        }
        private void 与丁丕丈丌七且丆丆(string 丑丘且世丞丒丟丛与, out string 丙业与丙丗丝不丈东, out string 丟丛不丞丞丏丏丁丕)
        {
            if(((System.String.IsNullOrEmpty(value:  丑丘且世丞丒丟丛与)) == true) || (丑丘且世丞丒丟丛与.Length < 2))
            {
                goto label_7;
            }
            
            char val_4 = 丑丘且世丞丒丟丛与.Chars[0] & 65535;
            if(val_4 != '[')
            {
                goto label_7;
            }
            
            int val_5 = 丑丘且世丞丒丟丛与.IndexOf(value:  ']');
            int val_6 = val_5 - 1;
            if(val_4 < '[')
            {
                goto label_7;
            }
            
            if(丑丘且世丞丒丟丛与 == null)
            {
                goto label_8;
            }
            
            丟丛不丞丞丏丏丁丕 = 丑丘且世丞丒丟丛与.Substring(startIndex:  1, length:  val_6);
            goto label_9;
            label_7:
            丙业与丙丗丝不丈东 = 丑丘且世丞丒丟丛与;
            label_10:
            丟丛不丞丞丏丏丁丕 = System.String.alignConst;
            return;
            label_8:
            丟丛不丞丞丏丏丁丕 = 0.Substring(startIndex:  1, length:  val_6);
            label_9:
            string val_10 = 丑丘且世丞丒丟丛与.Substring(startIndex:  val_5 + 1);
            goto label_10;
        }
        public T FindTranslatedObject<T>(string 丙业与丙丗丝不丈东)
        {
            var val_9;
            UnityEngine.Object val_10;
            UnityEngine.Object[] val_11;
            var val_12;
            UnityEngine.Object val_13;
            val_9 = this;
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  丙业与丙丗丝不丈东)) == true)
            {
                    return (object)val_10;
            }
            
            val_11 = this.TranslatedObjects;
            if((val_11 == null) || (this.TranslatedObjects.Length < 1))
            {
                goto label_3;
            }
            
            val_12 = 4;
            goto label_4;
            label_18:
            val_11 = this.TranslatedObjects;
            val_12 = 5;
            label_4:
            UnityEngine.Object val_10 = val_11[1];
            if(val_10 == null)
            {
                goto label_11;
            }
            
            val_13 = val_10;
            if(val_13 != null)
            {
                goto label_12;
            }
            
            label_11:
            val_13 = 0;
            label_12:
            if(val_13 != 0)
            {
                    if((System.String.op_Equality(a:  丙业与丙丗丝不丈东, b:  this.TranslatedObjects[1].name)) == true)
            {
                goto label_17;
            }
            
            }
            
            if((val_12 - 3) < (long)this.TranslatedObjects.Length)
            {
                goto label_18;
            }
            
            label_3:
            UnityEngine.Object val_7 = I2.Loc.丗丈下丕丟丟丙七丞.业丛丟万东丘丏丗东(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            val_9 = mem[__RuntimeMethodHiddenParam + 48];
            val_9 = __RuntimeMethodHiddenParam + 48;
            if(val_7 == null)
            {
                goto label_23;
            }
            
            val_10 = val_7;
            if(val_10 != null)
            {
                goto label_24;
            }
            
            label_23:
            val_10 = 0;
            label_24:
            if((UnityEngine.Object.op_Implicit(exists:  val_10)) == true)
            {
                    return (object)val_10;
            }
            
            val_9 = I2.Loc.ResourceManager.pInstance;
            val_10 = val_9;
            return (object)val_10;
            label_17:
            UnityEngine.Object val_12 = this.TranslatedObjects[1];
            if(val_12 == null)
            {
                    return (object)val_10;
            }
            
            if(val_12 != null)
            {
                    return (object)val_10;
            }
            
            return (object)val_10;
        }
        private bool 丞丛下丌上丆丗万丑(UnityEngine.Object 世丂丑下下下丕业专)
        {
            if(((System.Array.IndexOf<UnityEngine.Object>(array:  this.TranslatedObjects, value:  世丂丑下下下丕业专)) & 2147483648) == 0)
            {
                    return true;
            }
            
            I2.Loc.ResourceManager val_2 = I2.Loc.ResourceManager.pInstance;
            if(val_2 != null)
            {
                    return val_2.HasAsset(世丂丑下下下丕业专:  世丂丑下下下丕业专);
            }
            
            return val_2.HasAsset(世丂丑下下下丕业专:  世丂丑下下下丕业专);
        }
        public void SetGlobalLanguage(string 不世丏东丄丟世与不)
        {
            I2.Loc.丗丈下丕丟丟丙七丞.下且丘丒丗丑不丕丌(丙业与丙丗丝不丈东:  不世丏东丄丟世与不);
        }
        public static void RegisterEvents_2DToolKit()
        {
        
        }
        public static void RegisterEvents_DFGUI()
        {
        
        }
        private UIInput 且丞上丆世丙三下丏()
        {
            UIInput val_3;
            if(this.世下丙七世丝丘不丅 != false)
            {
                    val_3 = this.丕丐丄上专丂丛东丆;
                return val_2;
            }
            
            UIInput val_2 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIInput>(丝三丁东丈丒世丅业:  this.丐与丘丙与丌丝与丆.gameObject, 丕丗丆丕丈丑东丆丈:  3);
            this.丕丐丄上专丂丛东丆 = val_2;
            this.世下丙七世丝丘不丅 = true;
            return val_2;
        }
        public void RegisterEvents_NGUI()
        {
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丝丌丕丐七丈丂丑不()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丂且丘一七业丘不丟()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丂丌上丙一不丗丆丞()));
        }
        private void 丝丌丕丐七丈丂丑不()
        {
            mem[1152921541588926064] = this;
            mem[1152921541588926072] = System.Boolean I2.Loc.Localize::丛丐丄与丒丟业丂丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541588926048] = System.Boolean I2.Loc.Localize::丛丐丄与丒丟业丂丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541588930160] = this;
            mem[1152921541588930168] = public System.Void I2.Loc.Localize::DoLocalize_UILabel(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541588930144] = public System.Void I2.Loc.Localize::DoLocalize_UILabel(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UILabel>(一丙且丝丝七丘丟业: ref  this.丐与丘丙与丌丝与丆, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  true, 丑丟不下丝一专丌丈:  true, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丂且丘一七业丘不丟()
        {
            mem[1152921541589057520] = this;
            mem[1152921541589057528] = public System.Boolean I2.Loc.Localize::SetFinalTerms_UISprite(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541589057504] = public System.Boolean I2.Loc.Localize::SetFinalTerms_UISprite(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541589061616] = this;
            mem[1152921541589061624] = public System.Void I2.Loc.Localize::DoLocalize_UISprite(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541589061600] = public System.Void I2.Loc.Localize::DoLocalize_UISprite(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UISprite>(一丙且丝丝七丘丟业: ref  this.七专丄万不丑丕丙一, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  true, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丂丌上丙一不丗丆丞()
        {
            mem[1152921541589188976] = this;
            mem[1152921541589188984] = public System.Boolean I2.Loc.Localize::SetFinalTerms_UITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541589188960] = public System.Boolean I2.Loc.Localize::SetFinalTerms_UITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541589193072] = this;
            mem[1152921541589193080] = public System.Void I2.Loc.Localize::DoLocalize_UITexture(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541589193056] = public System.Void I2.Loc.Localize::DoLocalize_UITexture(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UITexture>(一丙且丝丝七丘丟业: ref  this.丙丝东不丄丙丄上一, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private bool 丛丐丄与丒丟业丂丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            int val_6;
            if(this.丐与丘丙与丌丝与丆.ambigiousFont != 0)
            {
                    val_6 = this.丐与丘丙与丌丝与丆.ambigiousFont.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            丝丁且丑丒丅东丂丏 = this.丐与丘丙与丌丝与丆.text;
            丞丌丕丑三丐七丐丂 = val_6;
            return true;
        }
        public bool SetFinalTerms_UISprite(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            int val_6;
            if(this.七专丄万不丑丕丙一.atlas != 0)
            {
                    val_6 = this.七专丄万不丑丕丙一.atlas.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            丝丁且丑丒丅东丂丏 = this.七专丄万不丑丕丙一.spriteName;
            丞丌丕丑三丐七丐丂 = val_6;
            return true;
        }
        public bool SetFinalTerms_UITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            丝丁且丑丒丅东丂丏 = this.丙丝东不丄丙丄上一.name;
            丞丌丕丑三丐七丐丂 = 0;
            return true;
        }
        public void DoLocalize_UILabel(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            UnityEngine.Object val_17;
            UILabel val_18;
            string val_1 = 丑万丈丝丂丄丆丈下;
            string val_2 = 丈丐丐业上丈丝丟丐;
            val_17 = this.丕东世丙丙不丈丙丏<UnityEngine.Font>(丑万丈丝丂丄丆丈下: ref  val_1, 丈丐丐业上丈丝丟丐: ref  val_2);
            if(val_17 != 0)
            {
                goto label_3;
            }
            
            val_17 = this.丕东世丙丙不丈丙丏<UIFont>(丑万丈丝丂丄丆丈下: ref  val_1, 丈丐丐业上丈丝丟丐: ref  val_2);
            if(val_17 == 0)
            {
                goto label_6;
            }
            
            label_3:
            this.丐与丘丙与丌丝与丆.ambigiousFont = val_17;
            return;
            label_6:
            if(this.且丞上丆世丙三下丏() == 0)
            {
                goto label_10;
            }
            
            UIInput val_9 = this.且丞上丆世丙三下丏();
            val_18 = this;
            if(val_9.label != this.丐与丘丙与丌丝与丆)
            {
                goto label_14;
            }
            
            if((System.String.op_Equality(a:  this.且丞上丆世丙三下丏().defaultText, b:  val_1)) == true)
            {
                    return;
            }
            
            this.且丞上丆世丙三下丏().defaultText = val_1;
            return;
            label_10:
            val_18 = this.丐与丘丙与丌丝与丆;
            label_14:
            if((System.String.op_Equality(a:  mem[this.丐与丘丙与丌丝与丆].text, b:  val_1)) == true)
            {
                    return;
            }
            
            mem[this.丐与丘丙与丌丝与丆].text = val_1;
        }
        public void DoLocalize_UISprite(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            string val_3 = 丑万丈丝丂丄丆丈下;
            if((System.String.op_Equality(a:  this.七专丄万不丑丕丙一.spriteName, b:  丑万丈丝丂丄丆丈下)) == true)
            {
                    return;
            }
            
            UIAtlas val_5 = this.丕东世丙丙不丈丙丏<UIAtlas>(丑万丈丝丂丄丆丈下: ref  val_3, 丈丐丐业上丈丝丟丐: ref  丈丐丐业上丈丝丟丐);
            if(val_5 != 0)
            {
                    this.七专丄万不丑丕丙一.atlas = val_5;
            }
            
            this.七专丄万不丑丕丙一.spriteName = val_3;
            this = this.七专丄万不丑丕丙一;
        }
        public void DoLocalize_UITexture(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.丙丝东不丄丙丄上一)) != false)
            {
                    if((System.String.op_Equality(a:  this.丙丝东不丄丙丄上一.name, b:  丑万丈丝丂丄丆丈下)) != false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Texture val_4 = this.FindTranslatedObject<UnityEngine.Texture>(丙业与丙丗丝不丈东:  丑万丈丝丂丄丆丈下);
            if(this.丙丝东不丄丙丄上一 == null)
            {
                
            }
        
        }
        public static void RegisterEvents_TextMeshPro()
        {
        
        }
        public void RegisterEvents_UGUI()
        {
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丝专丈丒世一丁丝丌()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丒丄丆丟丞丛丙丑丂()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::专丕丒丈且下丟丌丄()));
        }
        private void 丝专丈丒世一丁丝丌()
        {
            mem[1152921541590722544] = this;
            mem[1152921541590722552] = System.Boolean I2.Loc.Localize::丂专丗丆业丂丁丗丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590722528] = System.Boolean I2.Loc.Localize::丂专丗丆业丂丁丗丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590726640] = this;
            mem[1152921541590726648] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_Text(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541590726624] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_Text(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.UI.Text>(一丙且丝丝七丘丟业: ref  this.丁丒且丒七且七且丟, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  true, 丑丟不下丝一专丌丈:  true, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丒丄丆丟丞丛丙丑丂()
        {
            mem[1152921541590854000] = this;
            mem[1152921541590854008] = public System.Boolean I2.Loc.Localize::SetFinalTerms_uGUI_Image(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590853984] = public System.Boolean I2.Loc.Localize::SetFinalTerms_uGUI_Image(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590858096] = this;
            mem[1152921541590858104] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_Image(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541590858080] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_Image(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.UI.Image>(一丙且丝丝七丘丟业: ref  this.万丕七专丅丗丏上丕, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 专丕丒丈且下丟丌丄()
        {
            mem[1152921541590985456] = this;
            mem[1152921541590985464] = public System.Boolean I2.Loc.Localize::SetFinalTerms_uGUI_RawImage(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590985440] = public System.Boolean I2.Loc.Localize::SetFinalTerms_uGUI_RawImage(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂);
            mem[1152921541590989552] = this;
            mem[1152921541590989560] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_RawImage(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541590989536] = public System.Void I2.Loc.Localize::DoLocalize_uGUI_RawImage(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.UI.RawImage>(一丙且丝丝七丘丟业: ref  this.下丟七丗丏丏丞丙且, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private bool 丂专丗丆业丂丁丗丒(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            int val_5;
            if(this.丁丒且丒七且七且丟.font != 0)
            {
                    val_5 = this.丁丒且丒七且七且丟.font.name;
            }
            else
            {
                    val_5 = System.String.alignConst;
            }
            
            丝丁且丑丒丅东丂丏 = this.丁丒且丒七且七且丟;
            丞丌丕丑三丐七丐丂 = val_5;
            return true;
        }
        public bool SetFinalTerms_uGUI_Image(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            丝丁且丑丒丅东丂丏 = this.万丕七专丅丗丏上丕.name;
            丞丌丕丑三丐七丐丂 = 0;
            return true;
        }
        public bool SetFinalTerms_uGUI_RawImage(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
        {
            丝丁且丑丒丅东丂丏 = this.下丟七丗丏丏丞丙且.texture.name;
            丞丌丕丑三丐七丐丂 = 0;
            return true;
        }
        public static T FindInParents<T>(UnityEngine.Transform 丆丐三三丏丘丈专丆)
        {
            UnityEngine.Object val_5;
            UnityEngine.Object val_6;
            val_5 = 丆丐三三丏丘丈专丆;
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                    return (object)val_6;
            }
            
            val_6 = val_5;
            goto label_5;
            label_13:
            val_6 = val_5;
            val_5 = val_5.parent;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  val_6)) == true)
            {
                    return (object)val_6;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == true)
            {
                goto label_13;
            }
            
            return (object)val_6;
        }
        public void DoLocalize_uGUI_Text(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            if((System.String.op_Equality(a:  this.丁丒且丒七且七且丟, b:  丑万丈丝丂丄丆丈下)) == true)
            {
                    return;
            }
            
            UnityEngine.Font val_4 = this.丕东世丙丙不丈丙丏<UnityEngine.Font>(丑万丈丝丂丄丆丈下: ref  丑万丈丝丂丄丆丈下, 丈丐丐业上丈丝丟丐: ref  丈丐丐业上丈丝丟丐);
            if(val_4 == 0)
            {
                    return;
            }
            
            this = this.丁丒且丒七且七且丟;
            this.font = val_4;
        }
        public void DoLocalize_uGUI_Image(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            UnityEngine.Sprite val_1 = this.万丕七专丅丗丏上丕.sprite;
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
            {
                    if((System.String.op_Equality(a:  val_1.name, b:  丑万丈丝丂丄丆丈下)) != false)
            {
                    return;
            }
            
            }
            
            this.万丕七专丅丗丏上丕.sprite = this.FindTranslatedObject<UnityEngine.Sprite>(丙业与丙丗丝不丈东:  丑万丈丝丂丄丆丈下);
        }
        public void DoLocalize_uGUI_RawImage(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            UnityEngine.Texture val_1 = this.下丟七丗丏丏丞丙且.texture;
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
            {
                    if((System.String.op_Equality(a:  val_1.name, b:  丑万丈丝丂丄丆丈下)) != false)
            {
                    return;
            }
            
            }
            
            this.下丟七丗丏丏丞丙且.texture = this.FindTranslatedObject<UnityEngine.Texture>(丙业与丙丗丝不丈东:  丑万丈丝丂丄丆丈下);
        }
        public void RegisterEvents_UnityStandard()
        {
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丙不丌丄丁丙且东丄()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丏丈下万丝一下丛万()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丟丄丑丝丈万丟三丝()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::东万且世丅七上丌丝()));
            this.EventFindTarget.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void I2.Loc.Localize::丏丁不不专丏世上丏()));
        }
        private void 丙不丌丄丁丙且东丄()
        {
            mem[1152921541592468848] = this;
            mem[1152921541592468856] = public System.Boolean I2.Loc.Localize::SetFinalTerms_GUIText(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592468832] = public System.Boolean I2.Loc.Localize::SetFinalTerms_GUIText(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592472944] = this;
            mem[1152921541592472952] = System.Void I2.Loc.Localize::丌丐丆丏丁丄专不丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541592472928] = System.Void I2.Loc.Localize::丌丐丆丏丁丄专不丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.GUIText>(一丙且丝丝七丘丟业: ref  this.丆丅一专且七丂七世, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  true, 丑丟不下丝一专丌丈:  true, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丏丈下万丝一下丛万()
        {
            mem[1152921541592600304] = this;
            mem[1152921541592600312] = public System.Boolean I2.Loc.Localize::SetFinalTerms_TextMesh(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592600288] = public System.Boolean I2.Loc.Localize::SetFinalTerms_TextMesh(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592604400] = this;
            mem[1152921541592604408] = System.Void I2.Loc.Localize::丅世业丑丟丙丅世丑(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541592604384] = System.Void I2.Loc.Localize::丅世业丑丟丙丅世丑(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.TextMesh>(一丙且丝丝七丘丟业: ref  this.丆丂世丘丟丞丄丞与, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  true, 丑丟不下丝一专丌丈:  true, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丟丄丑丝丈万丟三丝()
        {
            mem[1152921541592731760] = this;
            mem[1152921541592731768] = public System.Boolean I2.Loc.Localize::SetFinalTerms_AudioSource(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592731744] = public System.Boolean I2.Loc.Localize::SetFinalTerms_AudioSource(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592735856] = this;
            mem[1152921541592735864] = System.Void I2.Loc.Localize::丞丂七丅世丗丐丟丕(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541592735840] = System.Void I2.Loc.Localize::丞丂七丅世丗丐丟丕(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.AudioSource>(一丙且丝丝七丘丟业: ref  this.丄业世丗不丒丄万丄, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 东万且世丅七上丌丝()
        {
            mem[1152921541592863216] = this;
            mem[1152921541592863224] = public System.Boolean I2.Loc.Localize::SetFinalTerms_GUITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592863200] = public System.Boolean I2.Loc.Localize::SetFinalTerms_GUITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592867312] = this;
            mem[1152921541592867320] = System.Void I2.Loc.Localize::丞丛万且丅丒世丅世(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541592867296] = System.Void I2.Loc.Localize::丞丛万且丅丒世丅世(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.FindAndCacheTarget<UnityEngine.GUITexture>(一丙且丝丝七丘丟业: ref  this.丄且丄丂下丝东丕业, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        private void 丏丁不不专丏世上丏()
        {
            mem[1152921541592993648] = this;
            mem[1152921541592993656] = public System.Boolean I2.Loc.Localize::SetFinalTerms_Child(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592993632] = public System.Boolean I2.Loc.Localize::SetFinalTerms_Child(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且);
            mem[1152921541592997744] = this;
            mem[1152921541592997752] = System.Void I2.Loc.Localize::万丏丆丛与丌丕业丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            mem[1152921541592997728] = System.Void I2.Loc.Localize::万丏丆丛与丌丕业丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐);
            this.丏丑世七丄东丟丟丝(一丙且丝丝七丘丟业: ref  this.丆丆丒丗丌下丛丘丝, 丅丏丘丄且七丝与与:  new Localize.丑丑丕丟业一上丐丂(), 万丘万三业丙丗世丌:  new Localize.丂七丒万不业下丒丝(), 丟七丛三丗万丟且丈:  false, 丑丟不下丝一专丌丈:  false, 丈丁七丛与丞丘丑丝:  false);
        }
        public bool SetFinalTerms_GUIText(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            int val_6;
            if(this.丆丅一专且七丂七世.font != 0)
            {
                    val_6 = this.丆丅一专且七丂七世.font.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            丞三一丟丟丟丟丁上 = this.丆丅一专且七丂七世.text;
            丘万与业丘万一丐且 = val_6;
            return true;
        }
        public bool SetFinalTerms_TextMesh(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            int val_6;
            if(this.丆丂世丘丟丞丄丞与.font != 0)
            {
                    val_6 = this.丆丂世丘丟丞丄丞与.font.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            丞三一丟丟丟丟丁上 = this.丆丂世丘丟丞丄丞与.text;
            丘万与业丘万一丐且 = val_6;
            return true;
        }
        public bool SetFinalTerms_GUITexture(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            var val_6;
            int val_7;
            var val_8;
            val_6 = this;
            if(((UnityEngine.Object.op_Implicit(exists:  this.丄且丄丂下丝东丕业)) != false) && ((UnityEngine.Object.op_Implicit(exists:  this.丄且丄丂下丝东丕业.texture)) != false))
            {
                    val_6 = this.丄且丄丂下丝东丕业.texture;
                val_7 = System.String.alignConst;
                丞三一丟丟丟丟丁上 = val_6.name;
                val_8 = 1;
            }
            else
            {
                    val_8 = 0;
                val_7 = System.String.alignConst;
                丞三一丟丟丟丟丁上 = val_7;
            }
            
            丘万与业丘万一丐且 = val_7;
            return (bool)val_8;
        }
        public bool SetFinalTerms_AudioSource(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            var val_6;
            int val_7;
            var val_8;
            val_6 = this;
            if(((UnityEngine.Object.op_Implicit(exists:  this.丄业世丗不丒丄万丄)) != false) && ((UnityEngine.Object.op_Implicit(exists:  this.丄业世丗不丒丄万丄.clip)) != false))
            {
                    val_6 = this.丄业世丗不丒丄万丄.clip;
                val_7 = System.String.alignConst;
                丞三一丟丟丟丟丁上 = val_6.name;
                val_8 = 1;
            }
            else
            {
                    val_8 = 0;
                val_7 = System.String.alignConst;
                丞三一丟丟丟丟丁上 = val_7;
            }
            
            丘万与业丘万一丐且 = val_7;
            return (bool)val_8;
        }
        public bool SetFinalTerms_Child(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丞三一丟丟丟丟丁上, out string 丘万与业丘万一丐且)
        {
            丞三一丟丟丟丟丁上 = this.丆丆丒丗丌下丛丘丝.name;
            丘万与业丘万一丐且 = System.String.alignConst;
            return true;
        }
        private void 丌丐丆丏丁丄专不丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            string val_3 = 丑万丈丝丂丄丆丈下;
            if((System.String.op_Equality(a:  this.丆丅一专且七丂七世.text, b:  丑万丈丝丂丄丆丈下)) == true)
            {
                    return;
            }
            
            UnityEngine.Font val_5 = this.丕东世丙丙不丈丙丏<UnityEngine.Font>(丑万丈丝丂丄丆丈下: ref  val_3, 丈丐丐业上丈丝丟丐: ref  丈丐丐业上丈丝丟丐);
            if(val_5 != 0)
            {
                    this.丆丅一专且七丂七世.font = val_5;
            }
            
            this = this.丆丅一专且七丂七世;
            this.text = val_3;
        }
        private void 丅世业丑丟丙丅世丑(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            string val_3 = 丑万丈丝丂丄丆丈下;
            if((System.String.op_Equality(a:  this.丆丂世丘丟丞丄丞与.text, b:  丑万丈丝丂丄丆丈下)) == true)
            {
                    return;
            }
            
            UnityEngine.Font val_5 = this.丕东世丙丙不丈丙丏<UnityEngine.Font>(丑万丈丝丂丄丆丈下: ref  val_3, 丈丐丐业上丈丝丟丐: ref  丈丐丐业上丈丝丟丐);
            if(val_5 != 0)
            {
                    this.丆丂世丘丟丞丄丞与.font = val_5;
                this.GetComponent<UnityEngine.Renderer>().sharedMaterial = val_5.material;
            }
            
            this = this.丆丂世丘丟丞丄丞与;
            this.text = val_3;
        }
        private void 丞丂七丅世丗丐丟丕(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            UnityEngine.AudioClip val_3 = this.FindTranslatedObject<UnityEngine.AudioClip>(丙业与丙丗丝不丈东:  丑万丈丝丂丄丆丈下);
            if(this.丄业世丗不丒丄万丄.clip == val_3)
            {
                    return;
            }
            
            this.丄业世丗不丒丄万丄.clip = val_3;
            if(this.丄业世丗不丒丄万丄.isPlaying == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.丄业世丗不丒丄万丄.clip)) == false)
            {
                    return;
            }
            
            this.丄业世丗不丒丄万丄.Play();
        }
        private void 丞丛万且丅丒世丅世(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            UnityEngine.Texture val_1 = this.丄且丄丂下丝东丕业.texture;
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
            {
                    if((System.String.op_Equality(a:  val_1.name, b:  丑万丈丝丂丄丆丈下)) != false)
            {
                    return;
            }
            
            }
            
            this.丄且丄丂下丝东丕业.texture = this.FindTranslatedObject<UnityEngine.Texture>(丙业与丙丗丝不丈东:  丑万丈丝丂丄丆丈下);
        }
        private void 万丏丆丛与丌丕业丂(string 丑万丈丝丂丄丆丈下, string 丈丐丐业上丈丝丟丐)
        {
            string val_15;
            UnityEngine.GameObject val_16;
            val_15 = 丑万丈丝丂丄丆丈下;
            if((UnityEngine.Object.op_Implicit(exists:  this.丆丆丒丗丌下丛丘丝)) != false)
            {
                    val_16 = this.丆丆丒丗丌下丛丘丝;
                if((System.String.op_Equality(a:  val_16.name, b:  val_15)) == true)
            {
                    return;
            }
            
            }
            
            val_16 = this.丆丆丒丗丌下丛丘丝;
            UnityEngine.GameObject val_4 = this.FindTranslatedObject<UnityEngine.GameObject>(丙业与丙丗丝不丈东:  val_15);
            if((UnityEngine.Object.op_Implicit(exists:  val_4)) == false)
            {
                goto label_8;
            }
            
            UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_4);
            this.丆丆丒丗丌下丛丘丝 = val_6;
            val_15 = val_6.transform;
            if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
            {
                goto label_12;
            }
            
            if(val_16 != null)
            {
                goto label_26;
            }
            
            label_27:
            label_26:
            UnityEngine.Transform val_9 = val_16.transform;
            val_15.parent = this.transform;
            UnityEngine.Vector3 val_11 = val_9.localScale;
            val_15.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Quaternion val_12 = val_9.localRotation;
            val_15.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            UnityEngine.Vector3 val_13 = val_9.localPosition;
            val_15.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            label_8:
            if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  val_16);
            return;
            label_12:
            if(val_4 != null)
            {
                goto label_26;
            }
            
            goto label_27;
        }
        public Localize()
        {
            this.EventFindTarget = new UnityEngine.Events.UnityEvent();
            this.LocalizeCallBack = new I2.Loc.EventCallback();
        }
    
    }

}
