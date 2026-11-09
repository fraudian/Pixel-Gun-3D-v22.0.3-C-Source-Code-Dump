using UnityEngine;

namespace Rilisoft
{
    public class AchievementView : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 丁丕丆三三丁丏丗丝;
        private Rilisoft.丞专七丛丛丌世丈丕 专丅丐万下上不丛丐;
        private UISprite _spriteIcon;
        private UISprite _spriteProgress;
        private UILabel _textName;
        private UILabel _textProgress;
        private UITexture _textureBackground;
        private static System.Action<Rilisoft.AchievementView> 丌不丂丌丁丛丆丟与;
        
        // Properties
        public Rilisoft.丞专七丛丛丌世丈丕 丞专七丛丛丌世丈丕 { get; set; }
        
        // Methods
        public Rilisoft.丞专七丛丛丌世丈丕 get_Achievement()
        {
            return (Rilisoft.丞专七丛丛丌世丈丕)this.专丅丐万下上不丛丐;
        }
        public void set_Achievement(Rilisoft.丞专七丛丛丌世丈丕 丙业与丙丗丝不丈东)
        {
            if(this.专丅丐万下上不丛丐 != null)
            {
                    this.专丅丐万下上不丛丐.丌丛丙业一世丅丁上(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, System.Boolean>(object:  this, method:  System.Void Rilisoft.AchievementView::东丒不七丝万丌丄三(bool 丟丞上万丄万丛专不, bool 丝丑丂万且丁且丐上)));
            }
            
            if(丙业与丙丗丝不丈东 != null)
            {
                    this.专丅丐万下上不丛丐 = 丙业与丙丗丝不丈东;
                this._textName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丙业与丙丗丝不丈东.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙());
                if((System.String.op_Equality(a:  this._textName.text, b:  this.专丅丐万下上不丛丐.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙())) != false)
            {
                    this._textName.text = System.String.Format(format:  "[{0}]", arg0:  this.专丅丐万下上不丛丐.GetType().Replace(oldValue:  "Achievement", newValue:  ""));
            }
            
                this.东丒不七丝万丌丄三(丟丞上万丄万丛专不:  false, 丝丑丂万且丁且丐上:  false);
                this.专丅丐万下上不丛丐.专丝丕专丆丛丂丄专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, System.Boolean>(object:  this, method:  System.Void Rilisoft.AchievementView::东丒不七丝万丌丄三(bool 丟丞上万丄万丛专不, bool 丝丑丂万且丁且丐上)));
                return;
            }
            
            Rilisoft.丞专七丛丛丌世丈丕.丐东丒丌丞丌丄丏丗(丌一一七丗丗七下七:  "achievement is null");
        }
        internal static UnityEngine.Texture 丑一东丏专丙丟丌丝(Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)
        {
            string val_13;
            var val_14;
            var val_15;
            UnityEngine.Object val_16;
            var val_17;
            var val_18;
            var val_19;
            Rilisoft.AchievementType val_1 = 世丞丞万丞丙一丟专.不业丙丒丂丞下丆丙();
            if(val_1 == 3)
            {
                goto label_2;
            }
            
            if(val_1 == 2)
            {
                goto label_3;
            }
            
            if(val_1 != 1)
            {
                goto label_4;
            }
            
            int val_2 = 世丞丞万丞丙一丟专.丙万丙丂一丝丁丂下();
            val_13 = "Achievements/Achievment_base_common_{0}";
            goto label_6;
            label_2:
            val_13 = "Achievements/Achievment_base_openable_{0}";
            label_6:
            val_14 = System.String.Format(format:  val_13, arg0:  世丞丞万丞丙一丟专.丙万丙丂一丝丁丂下());
            goto label_8;
            label_3:
            val_15 = "Achievements/Achievment_base_hidden_1";
            goto label_9;
            label_4:
            label_9:
            label_8:
            val_16 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  System.String.__il2cppRuntimeField_static_fields)) == true)
            {
                    return (UnityEngine.Texture)val_16;
            }
            
            val_17 = null;
            val_17 = null;
            if((Rilisoft.AchievementView.丁丕丆三三丁丏丗丝.ContainsKey(key:  System.String.__il2cppRuntimeField_static_fields)) != false)
            {
                    val_18 = null;
                val_18 = null;
                val_16 = Rilisoft.AchievementView.丁丕丆三三丁丏丗丝.Item[System.String.__il2cppRuntimeField_static_fields];
                return (UnityEngine.Texture)val_16;
            }
            
            bool val_8 = UnityEngine.Debug.isDebugBuild;
            val_16 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.__il2cppRuntimeField_static_fields);
            bool val_10 = UnityEngine.Debug.isDebugBuild;
            if(val_16 == 0)
            {
                    return (UnityEngine.Texture)val_16;
            }
            
            val_19 = null;
            val_19 = null;
            Rilisoft.AchievementView.丁丕丆三三丁丏丗丝.Add(key:  System.String.__il2cppRuntimeField_static_fields, value:  val_16);
            return (UnityEngine.Texture)val_16;
        }
        internal static void 万万且丞与万业丈丌(System.Action<Rilisoft.AchievementView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.AchievementView.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.AchievementView.丌不丂丌丁丛丆丟与 != 1152921505426391048);
        
        }
        internal static void 丂东东丌世与与上丛(System.Action<Rilisoft.AchievementView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.AchievementView.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.AchievementView.丌不丂丌丁丛丆丟与 != 1152921505426391048);
        
        }
        private void Awake()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.AchievementView::丅万且下丄丗万丐且()));
        }
        private void 丅万且下丄丗万丐且()
        {
            this._textName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.专丅丐万下上不丛丐.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙());
        }
        private void 东丒不七丝万丌丄三(bool 丟丞上万丄万丛专不, bool 丝丑丂万且丁且丐上)
        {
            UnityEngine.Texture val_1 = Rilisoft.AchievementView.丑一东丏专丙丟丌丝(世丞丞万丞丙一丟专:  this.专丅丐万下上不丛丐);
            this._textureBackground.fixedAspect = true;
            this._spriteIcon.spriteName = this.专丅丐万下上不丛丐.丁专丗万三上丟三丆().丑一丆丑且丟上业丛();
            if(this.专丅丐万下上不丛丐.世丑丐丅丆丂丘不丁() != true)
            {
                    if(this.专丅丐万下上不丛丐.万不东不上且东丑万() > 0)
            {
                    this._textProgress.gameObject.SetActive(value:  true);
                this._spriteProgress.gameObject.SetActive(value:  true);
                this._textProgress.text = System.String.Format(format:  "{0}/{1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.专丅丐万下上不丛丐.且专丂丐丟一不丌丟()), arg1:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.专丅丐万下上不丛丐.万不东不上且东丑万()));
                float val_21 = (float)this.专丅丐万下上不丛丐.且专丂丐丟一不丌丟();
                val_21 = val_21 / (float)this.专丅丐万下上不丛丐.万不东不上且东丑万();
                this._spriteProgress.fillAmount = val_21;
                return;
            }
            
            }
            
            this._spriteProgress.gameObject.SetActive(value:  false);
            UnityEngine.GameObject val_17 = this._textProgress.gameObject;
            if(this.专丅丐万下上不丛丐.不业丙丒丂丞下丆丙() == 1)
            {
                    val_17.SetActive(value:  true);
                this._textProgress.text = System.String.Format(format:  "{0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.专丅丐万下上不丛丐.且专丂丐丟一不丌丟()));
                return;
            }
            
            val_17.SetActive(value:  false);
        }
        private void OnClick()
        {
            var val_1;
            System.Action<Rilisoft.AchievementView> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.AchievementView.丌不丂丌丁丛丆丟与;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.AchievementView.丌不丂丌丁丛丆丟与;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  this);
        }
        private void OnDestroy()
        {
            this.专丅丐万下上不丛丐.丌丛丙业一世丅丁上(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, System.Boolean>(object:  this, method:  System.Void Rilisoft.AchievementView::东丒不七丝万丌丄三(bool 丟丞上万丄万丛专不, bool 丝丑丂万且丁且丐上)));
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.AchievementView::丅万且下丄丗万丐且()));
        }
        public AchievementView()
        {
        
        }
        private static AchievementView()
        {
            Rilisoft.AchievementView.丁丕丆三三丁丏丗丝 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        }
    
    }

}
