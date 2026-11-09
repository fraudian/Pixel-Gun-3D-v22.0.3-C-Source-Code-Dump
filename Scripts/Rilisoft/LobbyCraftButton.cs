using UnityEngine;

namespace Rilisoft
{
    internal class LobbyCraftButton : MonoBehaviour
    {
        // Fields
        internal static Rilisoft.LobbyCraftButton 丆丕丝丒不丙且丐丗;
        private UnityEngine.GameObject holder;
        private UnityEngine.GameObject _craftedItemExists;
        private UILabel _newItemsCountLabel;
        private UILabel _craftTimeLeftLabel;
        
        // Methods
        private void Awake()
        {
            null = null;
            Rilisoft.LobbyCraftButton.丆丕丝丒不丙且丐丗 = this;
            Rilisoft.丐丌丝七下丈丒丅丗.丛丑丌丅东上丘丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftButton::丑不丆丅丌丐丌与丘()));
        }
        private void OnDestroy()
        {
            var val_2;
            Rilisoft.丐丌丝七下丈丒丅丗.丅丗丟丟丘丆专一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftButton::丑不丆丅丌丐丌与丘()));
            val_2 = null;
            val_2 = null;
            Rilisoft.LobbyCraftButton.丆丕丝丒不丙且丐丗 = 0;
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
            var val_9;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈业与丑万丑丄与专());
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.一丁且丛世丏业丏丟());
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
            {
                    val_9 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.craft");
            }
            else
            {
                    val_9 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        }
        private System.Collections.IEnumerator 丈业与丑万丑丄与专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyCraftButton.丌专下业丌丅与七丁();
        }
        private System.Collections.IEnumerator 一丁且丛世丏业丏丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyCraftButton.丆丄三丆万丒丙丑丗();
        }
        public LobbyCraftButton()
        {
        
        }
        private static LobbyCraftButton()
        {
        
        }
    
    }

}
