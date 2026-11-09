using UnityEngine;

namespace PGCompany
{
    internal class ClanWarCellHeader : BindedUI, 世丙丘下丝丗上下丏<不上丌世万丁丝丏丆>
    {
        // Fields
        private 不上丌世万丁丝丏丆 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private UIWidget widget;
        private UILabel headerText;
        private UILabel timer;
        private UILabel clanName;
        private UITexture clanIcon;
        private PGCompany.ProgressBarView myClanProgress;
        private PGCompany.ProgressBarView otherClansProgress;
        private UnityEngine.GameObject enableIfTaskCell;
        private UnityEngine.GameObject enableIfVandalsCell;
        private UnityEngine.GameObject enableIfFortCell;
        public float zoomAlphaFactor;
        private UnityEngine.Coroutine 丕丆上下丕与东丈业;
        
        // Properties
        public 不上丌世万丁丝丏丆 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public 不上丌世万丁丝丏丆 get_Context()
        {
            return (不上丌世万丁丝丏丆)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(不上丌世万丁丝丏丆 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(不上丌世万丁丝丏丆 与且专丈不万东一万)
        {
            不上丌世万丁丝丏丆 val_29;
            UnityEngine.GameObject val_31;
            int val_32;
            UnityEngine.Texture val_33;
            var val_34;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            if(与且专丈不万东一万 == null)
            {
                goto label_1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfTaskCell, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfVandalsCell, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfFortCell, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myClanProgress, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timer, 丏业丟一东丂东丘丛:  false);
            val_29 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            mem[1152921554230674216] = val_29.丑丕丞三三世丑丅丝().gameObject;
            PGCompany.丝丂丒专丞与丙丏一 val_3 = 与且专丈不万东一万.丗丐东丑丕丞丅丞东();
            if(val_3 == 3)
            {
                goto label_6;
            }
            
            if(val_3 == 2)
            {
                goto label_7;
            }
            
            if(val_3 != 1)
            {
                goto label_8;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerText, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.下三下东业丘且丟业());
            val_29 = this.myClanProgress;
            UnityEngine.Color val_9 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
            val_29.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)this.<丅丝丌丝丁丏丙东丞>k__BackingField.业丝丙下七下七下专().且丆丟业丞丕丑上且(), 七丝东丛东丝且丆不:  (float)与且专丈不万东一万.业丝丙下七下七下专().丁丝丞与丟与丟丌三(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myClanProgress, 丏业丟一东丂东丘丛:  true);
            val_31 = this.enableIfTaskCell;
            goto label_19;
            label_1:
            this.gameObject.SetActive(value:  false);
            return;
            label_6:
            PGCompany.与丐业一丂丗与七丟 val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.与丐业一丂丗与七丟>(且下丕七丙丗丄不七:  1);
            if(val_12 == null)
            {
                goto label_22;
            }
            
            val_29 = val_12.下三下东业丘且丟业().且丆丟业丞丕丑上且();
            this.myClanProgress.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_29, 七丝东丛东丝且丆不:  (float)val_12.下三下东业丘且丟业().丁丝丞与丟与丟丌三(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myClanProgress, 丏业丟一东丂东丘丛:  true);
            goto label_28;
            label_7:
            丞丂丘丒丟丞丑下丄 val_20 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  与且专丈不万东一万.丙丗丏丂业且不东丞());
            if(val_20 == null)
            {
                goto label_31;
            }
            
            val_32 = val_20.东丙上东业丆不丟丘();
            if(val_32 != null)
            {
                goto label_32;
            }
            
            label_31:
            val_32 = System.String.alignConst;
            label_32:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanName, 丕丗丘丑丛与丑业丒:  val_32);
            val_29 = this.clanIcon;
            丞丂丘丒丟丞丑下丄 val_25 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  与且专丈不万东一万.丙丗丏丂业且不东丞());
            if(val_25 == null)
            {
                goto label_37;
            }
            
            val_33 = val_25.世丐专丂世丄世丂丌();
            goto label_38;
            label_22:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timer, 丏业丟一东丂东丘丛:  true);
            this.且丒不丙丌丅丑丂丄();
            label_28:
            val_34 = 1;
            val_31 = this.enableIfVandalsCell;
            goto label_43;
            label_37:
            val_33 = 0;
            label_38:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_29, 与万丆丛丒万丝丙丑:  val_33);
            val_31 = this.enableIfFortCell;
            label_19:
            val_34 = 1;
            label_43:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  true);
            label_8:
            this.gameObject.SetActive(value:  true);
        }
        public override void Dispose()
        {
            this.Dispose();
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 0;
            mem[1152921554230958248] = 0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.widget == null)
            {
                
            }
        
        }
        protected override void LateUpdate()
        {
            this.LateUpdate();
            float val_1 = GestureCamera.ZoomValue01;
            val_1 = val_1 * this.zoomAlphaFactor;
            val_1 = 1f - val_1;
            goto typeof(UIWidget).__il2cppRuntimeField_1A8;
        }
        protected override UnityEngine.Vector3 与万丞万丁丞丗丗上()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return this.与万丞万丁丞丗丗上();
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丂丕丘丌专丗丞丘丘()) == null)
            {
                    return this.与万丞万丁丞丗丗上();
            }
            
            丛与三东七专下丗丗 val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丂丕丘丌专丗丞丘丘();
            if(val_2 != null)
            {
                    return val_2.丌丆业专三万丁丒丒();
            }
            
            return val_2.丌丆业专三万丁丒丒();
        }
        private void 且丒不丙丌丅丑丂丄()
        {
            if(this.丕丆上下丕与东丈业 != null)
            {
                    this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
                this.丕丆上下丕与东丈业 = 0;
            }
            
            this.丕丆上下丕与东丈业 = this.StartCoroutine(routine:  this.与东丆丟丞丈一丕上());
        }
        private void 一丛丄七一且东三七()
        {
            if(this.丕丆上下丕与东丈业 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
            this.丕丆上下丕与东丈业 = 0;
        }
        private System.Collections.IEnumerator 与东丆丟丞丈一丕上()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanWarCellHeader.东且丞丏丌丙丙丗丌();
        }
        private void 丝丂丕东专世丅丝丁()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timer, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  1), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        public ClanWarCellHeader()
        {
            this.zoomAlphaFactor = 2f;
        }
    
    }

}
