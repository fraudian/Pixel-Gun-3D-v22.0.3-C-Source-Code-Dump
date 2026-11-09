using UnityEngine;

namespace Rilisoft
{
    public class EggsMigrationView : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private float 且业丁丝丐丅且上丝;
        private UIPanel _hatchingPanel;
        private UIScrollView _scroll;
        private UIWrapContent _wrap;
        private PetCardController _cell;
        
        // Methods
        public void Setup()
        {
        
        }
        private void 丝丈丆世且三与丝东(PetCardController 丌丝万上丅丒一丈丘)
        {
        
        }
        private void OnEnable()
        {
            this.且业丁丝丐丅且上丝 = UnityEngine.Time.realtimeSinceStartup;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.EggsMigrationView::U_Hide()), 与且专丈不万东一万:  0);
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
        private void OnDestroy()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public void U_Hide()
        {
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 + (-1f);
            if(val_1 < 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public EggsMigrationView()
        {
        
        }
    
    }

}
