using UnityEngine;

namespace Rilisoft
{
    internal class FortCraftButton : MonoBehaviour
    {
        // Fields
        internal const string 万三不与丅丁下丁专 = "craft";
        private UnityEngine.GameObject _craftedItemExists;
        private UILabel _levelRequiredLabel;
        private UILabel _newItemsCountLabel;
        private UnityEngine.GameObject _unlockAnimationObject;
        private UILabel _craftTimeLeftLabel;
        
        // Properties
        private bool 世丝与丛丏丗丘上丏 { get; set; }
        private bool 丑丞丌丒丌丕丘丝丆 { get; set; }
        
        // Methods
        private bool 丝丛丕业丏丛丐丁七()
        {
            Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  18);
            }
            
            return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  18);
        }
        private void 丒不不丙丙丟丌丝业(bool 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  18);
                return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  18);
        }
        private bool 东丂业专不丗世且三()
        {
            Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  19);
            }
            
            return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  19);
        }
        private void 丄东丅丅且丌专专东(bool 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  19);
                return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  19);
        }
        private void Awake()
        {
            Rilisoft.丐丌丝七下丈丒丅丗.丛丑丌丅东上丘丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftButton::丑不丆丅丌丐丌与丘()));
        }
        private void OnDestroy()
        {
            Rilisoft.丐丌丝七下丈丒丅丗.丅丗丟丟丘丆专一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftButton::丑不丆丅丌丐丌与丘()));
        }
        private void 丑不丆丅丌丐丌与丘()
        {
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丈业与丑万丑丄与专());
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈业与丑万丑丄与专());
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.一丁且丛世丏业丏丟());
            bool val_5 = Rilisoft.FortsManager.丑丆丏丟丗丌丄丟丝();
            if(val_5 != false)
            {
                    val_5.丒不不丙丙丟丌丝业(丙业与丙丗丝不丈东:  true);
            }
            
            bool val_6 = val_5.丝丛丕业丏丛丐丁七();
            if(val_6 != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  val_6.且丁业三且丄丛丞丏());
        }
        private void OnClick()
        {
            bool val_1 = this.丝丛丕业丏丛丐丁七();
            if(val_1 != false)
            {
                    return;
            }
            
            val_1.丒不不丙丙丟丌丝业(丙业与丙丗丝不丈东:  true);
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "craft");
        }
        private System.Collections.IEnumerator 且丁业三且丄丛丞丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new FortCraftButton.东且丅丐与业丏丅丝();
        }
        private System.Collections.IEnumerator 丈业与丑万丑丄与专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortCraftButton.丈业下丐丅丄东丈业();
        }
        private System.Collections.IEnumerator 一丁且丛世丏业丏丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortCraftButton.丙丕万丅三丕丑丌丞();
        }
        public FortCraftButton()
        {
        
        }
    
    }

}
