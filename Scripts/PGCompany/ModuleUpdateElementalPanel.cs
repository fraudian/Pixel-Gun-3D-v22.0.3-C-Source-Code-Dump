using UnityEngine;

namespace PGCompany
{
    internal class ModuleUpdateElementalPanel : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _containerInfo;
        private UnityEngine.GameObject _containerReward;
        private UILabel _buttonInfoLabel;
        private UnityEngine.BoxCollider _buttonInfoBoxCollider;
        private UISprite _buttonDarkenSprite;
        private PGCompany.InventoryItemView _itemView;
        private int _blockSeconds;
        private Rilisoft.OfferItemType _itemType;
        private string _itemId;
        private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
        private PGCompany.丗丟丄丈东丝丕丄世 丐丙丒丈丄不一丈与;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Methods
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleUpdateElementalPanel::丐丐七丄丅一丌丐世()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        private System.Collections.IEnumerator Start()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ModuleUpdateElementalPanel.不万丅丟丒丟丁丘丒();
        }
        public void U_ChangeContainer()
        {
            if(this.丐丙丒丈丄不一丈与 != null)
            {
                    this._itemView.Setup(与且专丈不万东一万:  this.丐丙丒丈丄不一丈与);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._containerInfo, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._containerReward, 丏业丟一东丂东丘丛:  true);
                return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this.丕丟丈丙丟丅丟丑七;
            UnityEngine.Debug.LogErrorFormat(format:  "Reward in null for {0}", args:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public void U_GiveReward()
        {
            this.三丛丁丆东世丁丏三();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        private void 丐丐七丄丅一丌丐世()
        {
        
        }
        private void 三丛丁丆东世丁丏三()
        {
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  32)) == true)
            {
                    return;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  this._itemType, 丞丅上丏丂且下丅与:  this._itemId), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            this.世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  32);
        }
        public ModuleUpdateElementalPanel()
        {
            this._blockSeconds = 5;
        }
    
    }

}
