using UnityEngine;

namespace PGCompany
{
    internal class ModuleContextCluesScreen : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Methods
        private void OnEnable()
        {
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleContextCluesScreen::丌丅丏丈业丛万且专()), 与且专丈不万东一万:  "ModuleContextCluesScreen");
        }
        private void 丌丅丏丈业丛万且专()
        {
        
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
        public ModuleContextCluesScreen()
        {
        
        }
    
    }

}
