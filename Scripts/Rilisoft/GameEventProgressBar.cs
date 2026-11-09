using UnityEngine;

namespace Rilisoft
{
    public class GameEventProgressBar : MonoBehaviour
    {
        // Fields
        private System.Action 下丛丄丐丕丘丒下丞;
        private Rilisoft.丛且世丐丆上七业丁 <丅且七三丕专丌丏业>k__BackingField;
        private UIWidget _backgroundWidget;
        private UIWidget _fillWidget;
        private UIWidget _fillBackWidget;
        private UnityEngine.GameObject _delimerObject;
        private UILabel _progressLabel;
        private UILabel _headerLabel;
        private string _headerLocalizationKey;
        private float _fillSpeed;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丛且世丐丆上七业丁 { get; set; }
        private int 丁一上丌不七三丂下 { get; }
        private int 丘丈丂万丝丅丈丕丙 { get; }
        
        // Methods
        public Rilisoft.丛且世丐丆上七业丁 get_GameEvent()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅且七三丕专丌丏业>k__BackingField;
        }
        private void 上不上丝专丘丁三专(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅且七三丕专丌丏业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private int 丂丙丐丆丝上万业世()
        {
            if((this.<丅且七三丕专丌丏业>k__BackingField.下一三万丝丟丐丒丆()) == false)
            {
                    return 0;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_2 = this.<丅且七三丕专丌丏业>k__BackingField.不七丘丙不三丗业上();
            if(val_2 != null)
            {
                    return val_2.丂丙丐丆丝上万业世();
            }
            
            return val_2.丂丙丐丆丝上万业世();
        }
        private int 丂世上东丞且丏丝丗()
        {
            if((this.<丅且七三丕专丌丏业>k__BackingField) != null)
            {
                    return this.<丅且七三丕专丌丏业>k__BackingField.丂世上东丞且丏丝丗();
            }
            
            return this.<丅且七三丕专丌丏业>k__BackingField.丂世上东丞且丏丝丗();
        }
        public void SetPossibleProgress(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, bool 丌丙丆丐丂东下丘不 = True)
        {
            int val_17;
            int val_18;
            Rilisoft.GameEventChestData val_2 = 丐下丝丘丑丟丟丗丌.丁专丗万三上丟三丆();
            Rilisoft.丛且世丐丆上七业丁 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  val_2.EventId);
            this.<丅且七三丕专丌丏业>k__BackingField = val_3;
            if(val_3.下一三万丝丟丐丒丆() == false)
            {
                goto label_7;
            }
            
            if(丌丙丆丐丂东下丘不 == false)
            {
                goto label_9;
            }
            
            val_17 = 丐下丝丘丑丟丟丗丌.丁丒丝世下丟丑七丐();
            goto label_11;
            label_7:
            val_18 = this;
            int val_7 = this.丂丙丐丆丝上万业世();
            goto label_12;
            label_9:
            val_17 = 0;
            label_11:
            val_17 = val_17 + (this.<丅且七三丕专丌丏业>k__BackingField.丂世上东丞且丏丝丗());
            val_18 = this.<丅且七三丕专丌丏业>k__BackingField.不七丘丙不三丗业上().丂丙丐丆丝上万业世();
            int val_10 = UnityEngine.Mathf.Min(a:  val_18, b:  val_17);
            label_12:
            this._progressLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_10, arg1:  this.丂丙丐丆丝上万业世());
            UnityEngine.Vector3 val_13 = this.丛丝业丂丒丙丛丆丙(七丄且丘丏与丟丂世:  0, 丌丆上丌三丗一上丒:  true);
            this.丒业丅丆丌丆丕丐丂(丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_16 = this.丛丝业丂丒丙丛丆丙(七丄且丘丏与丟丂世:  val_10, 丌丆上丌三丗一上丒:  true);
            this._fillBackWidget.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        private void 丒业丅丆丌丆丕丐丂(UnityEngine.Vector3 丝丕丁丏丏上丅丏且)
        {
            var val_5 = 0;
            if(( != 0) && ( == 3))
            {
                    fillAmount = 丝丕丁丏丏上丅丏且.x;
                return;
            }
            
            this._fillWidget.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z};
        }
        public void UpdateView(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 七丆丟丗世丟且丒丆 = False)
        {
            var val_11;
            string val_12;
            val_11 = this;
            this.<丅且七三丕专丌丏业>k__BackingField = 丅东专与不三丂丁丝;
            if(丅东专与不三丂丁丝 == null)
            {
                    this.gameObject.SetActive(value:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.业丙丐与丝丞七东三();
            val_12 = this.<丅且七三丕专丌丏业>k__BackingField.下一三万丝丟丐丒丆();
            UnityEngine.GameObject val_4 = this._headerLabel.gameObject;
            if(val_12 != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
                val_12 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._headerLocalizationKey), arg0:  this.丂丙丐丆丝上万业世());
                this._headerLabel.text = val_12;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
            }
            
            if((this.<丅且七三丕专丌丏业>k__BackingField) == 丅东专与不三丂丁丝)
            {
                    if(七丆丟丗世丟且丒丆 == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_8 = this.丛丝业丂丒丙丛丆丙(七丄且丘丏与丟丂世:  0, 丌丆上丌三丗一上丒:  false);
            this.丒业丅丆丌丆丕丐丂(丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_11 = this._fillBackWidget.gameObject.transform;
            val_11.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private void 业丙丐与丝丞七东三()
        {
            this._progressLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  this.丂世上东丞且丏丝丗(), arg1:  this.丂丙丐丆丝上万业世());
        }
        public void UpdateFill(System.Action 丞与与丝不业丐一丆)
        {
            this.下丛丄丐丕丘丒下丞 = 丞与与丝不业丐一丆;
            this.StopCoroutine(routine:  this.下丛丞丛丒下不丛上());
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.下丛丞丛丒下不丛上());
        }
        private System.Collections.IEnumerator 下丛丞丛丒下不丛上()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventProgressBar.一不丞三业丝东丑丗();
        }
        private UnityEngine.Vector3 丛丝业丂丒丙丛丆丙(int 七丄且丘丏与丟丂世 = 0, bool 丌丆上丌三丗一上丒 = False)
        {
            var val_10;
            float val_11;
            val_10 = 七丄且丘丏与丟丂世;
            if((this.<丅且七三丕专丌丏业>k__BackingField.下一三万丝丟丐丒丆()) == false)
            {
                goto label_2;
            }
            
            val_11 = 0f;
            if((this.<丅且七三丕专丌丏业>k__BackingField.不七丘丙不三丗业上().丂丙丐丆丝上万业世()) < 1)
            {
                goto label_13;
            }
            
            if((this.<丅且七三丕专丌丏业>k__BackingField.丂世上东丞且丏丝丗()) <= 0)
            {
                    if(丌丆上丌三丗一上丒 == false)
            {
                goto label_13;
            }
            
            }
            
            if(val_10 <= 0)
            {
                    val_10 = this.<丅且七三丕专丌丏业>k__BackingField.丂世上东丞且丏丝丗();
            }
            
            val_11 = (float)val_10 / ((float)this.<丅且七三丕专丌丏业>k__BackingField.不七丘丙不三丗业上().丂丙丐丆丝上万业世());
            goto label_13;
            label_2:
            val_11 = 1f;
            label_13:
            float val_8 = UnityEngine.Mathf.Min(a:  1f, b:  val_11);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public GameEventProgressBar()
        {
            this._fillSpeed = 1f;
            this._headerLocalizationKey = "Key_3435";
        }
    
    }

}
