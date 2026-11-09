using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreBuffsUI : PGBehaviour
    {
        // Fields
        private ItemListUI _itemListUI;
        private System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> _ignoreIndexes;
        
        // Methods
        private void Awake()
        {
            if(this._itemListUI != 0)
            {
                    return;
            }
            
            this._itemListUI = this.GetComponent<ItemListUI>();
        }
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            PGCompany.BuffController.丅丕万丝世丒专下专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsUI::丝一丅丆三东丂丞七()));
        }
        private void 丝一丅丆三东丂丞七()
        {
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  40, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            int val_4 = val_2.RemoveAll(match:  new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  this, method:  System.Boolean PGCompany.ClanStoreBuffsUI::三丁丒三丗三七东丛(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)));
            this._itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_2);
        }
        private void OnDisable()
        {
            PGCompany.BuffController.一不丐丘业丘丐上丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreBuffsUI::丝一丅丆三东丂丞七()));
        }
        public ClanStoreBuffsUI()
        {
            this._ignoreIndexes = new System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈>();
        }
        private bool 三丁丒三丗三七东丛(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)
        {
            if(this._ignoreIndexes != null)
            {
                    return this._ignoreIndexes.Contains(item:  三丟东丕丄丄下下丑.业东丅东丌上丗丑不());
            }
            
            return this._ignoreIndexes.Contains(item:  三丟东丕丄丄下下丑.业东丅东丌上丗丑不());
        }
    
    }

}
