using UnityEngine;

namespace PGCompany
{
    internal class FreePlayTaskInstanceView : MonoBehaviour
    {
        // Fields
        private PGCompany.FreePlayTasksViewWindow 丒东丙下丏丅且丏且;
        private UnityEngine.GameObject _normalState;
        private UnityEngine.GameObject _readyToCollectState;
        private SimpleTweenePlayer _effectAfterCollectReward;
        private PGCompany.世丐下丕专东丘丏且 <丅丝丌丝丁丏丙东丞>k__BackingField;
        internal UILabel taskDescription;
        internal UILabel taskCount;
        internal UIBasicSprite progressSprite;
        private System.Collections.Generic.List<ItemView> rewardItemViews;
        private UnityEngine.GameObject _devButton;
        private UnityEngine.GameObject _devUi;
        
        // Properties
        private PGCompany.世丐下丕专东丘丏且 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        private PGCompany.世丐下丕专东丘丏且 丄丌一七丈万万丌丐()
        {
            return (PGCompany.世丐下丕专东丘丏且)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.世丐下丕专东丘丏且 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.世丐下丕专东丘丏且 与且专丈不万东一万, PGCompany.FreePlayTasksViewWindow 不丌不世且丄不三丝)
        {
            this.丒东丙下丏丅且丏且 = 不丌不世且丄不三丝;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  与且专丈不万东一万);
        }
        private void OnEnable()
        {
            PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTaskInstanceView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTaskInstanceView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._devUi, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._devButton, 丏业丟一东丂东丘丛:  false);
        }
        private void 丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            PGCompany.世丐下丕专东丘丏且 val_18;
            string val_19;
            UILabel val_20;
            var val_21;
            UnityEngine.GameObject val_22;
            var val_23;
            var val_24;
            val_19 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(万不且且丛丆东丒业 != null)
            {
                    val_18 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                if((System.String.op_Inequality(a:  万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒(), b:  val_18.丅丙丛丑丌丆丌丕丒())) == true)
            {
                    return;
            }
            
            }
            
            val_20 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._normalState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._readyToCollectState, 丏业丟一东丂东丘丛:  false);
            this._effectAfterCollectReward.SetFinal();
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丞专丅丁丁三丄上专()) != false)
            {
                    val_21 = null;
                val_22 = this._readyToCollectState;
            }
            else
            {
                    val_21 = null;
                val_22 = this._normalState;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_22, 丏业丟一东丂东丘丛:  true);
            int val_5 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丆丟业丞丕丑上且();
            int val_6 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丝丞与丟与丟丌三();
            if(this.taskCount != 0)
            {
                    val_23 = 1152921504622075904;
                val_20 = this.taskCount;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_20, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_5, arg1:  val_6));
            }
            
            if(this.progressSprite != 0)
            {
                    this.progressSprite.fillAmount = (float)val_5 / (float)val_6;
            }
            
            val_18 = this.rewardItemViews;
            if(val_18 == null)
            {
                goto label_32;
            }
            
            val_20 = 1152921538212866624;
            val_23 = 1152921538212867648;
            val_24 = 0;
            goto label_26;
            label_37:
            val_18 = this.rewardItemViews.Item[0];
            if(val_18 == 0)
            {
                goto label_30;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_14 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈丏丁东上与东丙丕());
            if(val_14 == null)
            {
                goto label_32;
            }
            
            val_18.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  PGCompany.丁丑上丞业丞丟丛上.丞丆三丙业丅丙丕丘(不丕三丌万丈丟丆世:  val_14));
            label_30:
            val_18 = this.rewardItemViews;
            val_24 = 1;
            label_26:
            if(val_24 < val_18.Count)
            {
                goto label_37;
            }
            
            label_32:
            if(this.taskDescription == 0)
            {
                    return;
            }
            
            val_19 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            this.taskDescription.text = val_19;
        }
        internal void 丄三丙丄丞东丕丒丝(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            if(万不且且丛丆东丒业 == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒(), b:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅丙丛丑丌丆丌丕丒())) != false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  万不且且丛丆东丒业);
        }
        private void OnDisable()
        {
            PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTaskInstanceView::丝一丅丆三东丂丞七(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
        }
        public void U_DevUI()
        {
        
        }
        public void U_DevNextTask()
        {
        
        }
        public void U_DevPrevoiusTask()
        {
        
        }
        public void U_DevIncrement()
        {
        
        }
        public void U_DevAlmostComplete()
        {
        
        }
        public void U_DevComplete()
        {
        
        }
        public void U_CollectReward()
        {
            this.丒东丙下丏丅且丏且.且丞丅丘七三万丐东(丈丅与与东丅下丞丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丐丞丆东下业丙丛三:  null);
            this.PlayEffectCollectReward();
        }
        public void PlayEffectCollectReward()
        {
            this._effectAfterCollectReward.Play();
        }
        public FreePlayTaskInstanceView()
        {
        
        }
    
    }

}
