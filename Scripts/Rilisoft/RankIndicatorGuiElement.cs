using UnityEngine;

namespace Rilisoft
{
    internal sealed class RankIndicatorGuiElement : GuiElementBase
    {
        // Fields
        private UISprite _currentProgress;
        private UILabel _experienceLabel;
        private UISprite _newProgress;
        private UILabel _rankLable;
        private UnityEngine.GameObject _ratingPanel;
        
        // Properties
        public override bool 七七业丒丟丝丘不丞 { get; }
        private string 东万丄三一下丆丑丟 { get; set; }
        private float 丛丅七丂丕一丆丈万 { get; set; }
        private float 丌七丂丏且丕丅丅丟 { get; set; }
        
        // Methods
        public override bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        private string 丄丌丄与七一不丐丑()
        {
            if(this._experienceLabel == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            if(this._experienceLabel != null)
            {
                    return this._experienceLabel.text;
            }
            
            return this._experienceLabel.text;
        }
        private void 且东且与世下下丌一(string 丙业与丙丗丝不丈东)
        {
            if(this._experienceLabel == 0)
            {
                    return;
            }
            
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_4;
            }
            
            label_7:
            this._experienceLabel.text = 丙业与丙丗丝不丈东;
            return;
            label_4:
            if(this._experienceLabel != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        private float 丂丂下丑且下丌丝东()
        {
            if(this._currentProgress == 0)
            {
                    return (float)val_3.x;
            }
            
            this = this._currentProgress.transform;
            UnityEngine.Vector3 val_3 = this.localScale;
            return (float)val_3.x;
        }
        private void 丒丂且丌世丂丌七世(float 丙业与丙丗丝不丈东)
        {
            float val_8;
            var val_9;
            val_8 = 丙业与丙丗丝不丈东;
            val_9 = this;
            if(this._currentProgress == 0)
            {
                    return;
            }
            
            val_8 = UnityEngine.Mathf.Clamp(value:  val_8, min:  0f, max:  1f);
            UnityEngine.Vector3 val_5 = this.transform.localScale;
            val_9 = this.transform;
            UnityEngine.Vector3 val_7 = val_9.localScale;
            this._currentProgress.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private float 专丘丆丑专丗万丅丅()
        {
            if(this._newProgress == 0)
            {
                    return (float)val_3.x;
            }
            
            this = this._newProgress.transform;
            UnityEngine.Vector3 val_3 = this.localScale;
            return (float)val_3.x;
        }
        private void 丂丄丏丐丗丕丞上丒(float 丙业与丙丗丝不丈东)
        {
            float val_8;
            var val_9;
            val_8 = 丙业与丙丗丝不丈东;
            val_9 = this;
            if(this._newProgress == 0)
            {
                    return;
            }
            
            val_8 = UnityEngine.Mathf.Clamp(value:  val_8, min:  0f, max:  1f);
            UnityEngine.Vector3 val_5 = this.transform.localScale;
            val_9 = this.transform;
            UnityEngine.Vector3 val_7 = val_9.localScale;
            this._newProgress.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected override void 东丟丘世丕丆下不万()
        {
            this.东丟丘世丕丆下不万();
            this.gameObject.SetActive(value:  true);
        }
        protected override void 丙丝七丅丑三丞丂且()
        {
            this.丙丝七丅丑三丞丂且();
            this.gameObject.SetActive(value:  false);
        }
        protected override void Awake()
        {
            ExperienceController.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<且且世业丟丆与丄业>(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)));
            Rilisoft.丐丌丝七下丈丒丅丗.丛丑丌丅东上丘丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三三丟丆万丙且不丅()));
            Rilisoft.丐丌丝七下丈丒丅丗.丅丞丌业丏东丁丙丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三三丟丆万丙且不丅()));
        }
        private void 三三丟丆万丙且不丅()
        {
            this.东丝丕与丝丙下丙丏(丗丝丌丌业丗业丅丗:  true);
        }
        protected override void OnEnable()
        {
            this.东丝丕与丝丙下丙丏(丗丝丌丌业丗业丅丗:  false);
        }
        protected override void OnDisable()
        {
            this.StopAllCoroutines();
            this.东丝丕与丝丙下丙丏(丗丝丌丌业丗业丅丗:  false);
            if((Rilisoft.GuiElementBase.一三丄丕上丂专与丆(丅丆东丏丙丝丅丆丟:  this)) == false)
            {
                    return;
            }
            
            this.专丌丅下万丐三丗丗();
        }
        protected override void OnDestroy()
        {
            Rilisoft.丐丌丝七下丈丒丅丗.丆丅丛与世世与丂丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三三丟丆万丙且不丅()));
            Rilisoft.丐丌丝七下丈丒丅丗.丅丗丟丟丘丆专一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三三丟丆万丙且不丅()));
            ExperienceController.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<且且世业丟丆与丄业>(object:  this, method:  System.Void Rilisoft.RankIndicatorGuiElement::三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)));
        }
        private void 东丝丕与丝丙下丙丏(bool 丗丝丌丌业丗业丅丗)
        {
            var val_20;
            ExperienceController val_21;
            var val_22;
            var val_23;
            this._rankLable.text = ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂().ToString();
            val_20 = null;
            val_20 = null;
            val_21 = ExperienceController.sharedController;
            if(val_21 == 0)
            {
                    return;
            }
            
            val_22 = null;
            val_22 = null;
            val_21 = ExperienceController.sharedController;
            if(val_21.万丌丄丗丟业七下丕() == null)
            {
                    return;
            }
            
            val_21 = ExperienceController.万丏丙丈东东万丝丞();
            int val_8 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌());
            float val_11 = (ExperienceController.丞丞丘业东丙丏七丌() == 65) ? 1f : ((float)val_21 / (float)val_8);
            this.且东且与世下下丌一(丙业与丙丗丝不丈东:  ExpController.丆且丘丏丈丙丟万丏(丒东专一不与丐丐丁:  val_21, 业丄一世丆万丕丂丐:  val_8));
            this.丒丂且丌世丂丌七世(丙业与丙丗丝不丈东:  val_11);
            if(this.专丘丆丑专丗万丅丅() > this.丂丂下丑且下丌丝东())
            {
                    this.丂丄丏丐丗丕丞上丒(丙业与丙丗丝不丈东:  0f);
            }
            
            if(丗丝丌丌业丗业丅丗 != false)
            {
                    if(this.gameObject.activeInHierarchy != false)
            {
                    val_23 = null;
                val_23 = null;
                且且世业丟丆与丄业 val_17 = ExperienceController.sharedController.万丌丄丗丟业七下丕();
                UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  this.丑丟上且丕三丒丏丗(万不东上丄丞丕七万:  true, 东世丑世丛丞不专丕:  val_17.丕下丘丒丄一下专专));
                return;
            }
            
            }
            
            this.丂丄丏丐丗丕丞上丒(丙业与丙丗丝不丈东:  val_11);
        }
        private void 三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)
        {
            this.东丝丕与丝丙下丙丏(丗丝丌丌业丗业丅丗:  true);
        }
        private System.Collections.IEnumerator 丑丟上且丕三丒丏丗(bool 万不东上丄丞丕七万, UnityEngine.AudioClip 东世丑世丛丞不专丕)
        {
            RankIndicatorGuiElement.业丕丈七丘丘东专上 val_1 = new RankIndicatorGuiElement.业丕丈七丘丘东专上();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .万不东上丄丞丕七万 = 万不东上丄丞丕七万;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 万不东上丄丞丕七万;
            }
            
            .东世丑世丛丞不专丕 = 东世丑世丛丞不专丕;
            return (System.Collections.IEnumerator)val_1;
        }
        public RankIndicatorGuiElement()
        {
        
        }
    
    }

}
