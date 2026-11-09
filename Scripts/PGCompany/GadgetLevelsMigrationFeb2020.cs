using UnityEngine;

namespace PGCompany
{
    public class GadgetLevelsMigrationFeb2020 : BannerWindow
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丂丙上且不丟业丛丒()
        {
            if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == true)
            {
                    return false;
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return false;
            }
            
            1152921505171275776 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if((1152921505171275776.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  48)) != false)
            {
                    return false;
            }
            
            Progress.东丐世上丛丌丛丛丝 val_5 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_5 != null)
            {
                    return val_5.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  50);
            }
            
            return val_5.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  50);
        }
        public void HideWindow()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.丑丂丒上东丙丟丕三();
            new System.Action() = new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf());
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  48);
        }
        protected override void OnDisable()
        {
            this.丑丂丒上东丙丟丕三();
            this.OnDisable();
        }
        private void 丑丂丒上东丙丟丕三()
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
        public GadgetLevelsMigrationFeb2020()
        {
        
        }
    
    }

}
