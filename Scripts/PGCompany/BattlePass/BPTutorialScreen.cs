using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialScreen : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Methods
        private void OnEnable()
        {
            var val_7;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_7 = null;
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
            {
                    return;
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPTutorialScreen::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  0);
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
        private void 丝东丐丝东三丈世丝()
        {
        
        }
        public BPTutorialScreen()
        {
        
        }
    
    }

}
