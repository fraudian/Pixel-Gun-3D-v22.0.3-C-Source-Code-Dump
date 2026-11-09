using UnityEngine;

namespace Rilisoft
{
    public class GameEventInfoView : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒;
        private System.Action 下东专丟丘丒丒丐丒;
        
        // Methods
        public void add_OnCloseRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下东专丟丘丒丒丐丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下东专丟丘丒丒丐丒 != 1152921542836289976);
        
        }
        public void remove_OnCloseRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下东专丟丘丒丒丐丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下东专丟丘丒丒丐丒 != 1152921542836426552);
        
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventInfoView::Hide()), 与且专丈不万东一万:  0);
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
            this.丐丆七且丞丏下三丙 = 0;
        }
        public void Show(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            this.且丞丂丐不丐不丂丒 = 丅东专与不三丂丁丝;
            this.gameObject.SetActive(value:  true);
        }
        public void Hide()
        {
            if(this.下东专丟丘丒丒丐丒 == null)
            {
                    return;
            }
            
            this.下东专丟丘丒丒丐丒.Invoke();
        }
        public GameEventInfoView()
        {
        
        }
    
    }

}
