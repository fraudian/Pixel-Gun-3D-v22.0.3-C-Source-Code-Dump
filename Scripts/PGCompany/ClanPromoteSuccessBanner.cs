using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanPromoteSuccessBanner : BannerWindow
    {
        // Fields
        private System.IDisposable 东三世丝丒三一丈丛;
        private UILabel _bodyLabel;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.东三世丝丒三一丈丛 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.东三世丝丒三一丈丛.Dispose();
            }
            
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanPromoteSuccessBanner::U_Hide()), 与且专丈不万东一万:  0);
            this.丒丁丅一下丂专万不();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.东三世丝丒三一丈丛 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        public void U_Hide()
        {
            this.HideSelf();
        }
        private void 丒丁丅一下丂专万不()
        {
            var val_2;
            UILabel val_5;
            string val_6;
            val_5 = this;
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_2 == 1)
            {
                    val_5 = this._bodyLabel;
                val_6 = "Key_10189";
            }
            else
            {
                    PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
                if(val_2 != 0)
            {
                    return;
            }
            
                val_5 = this._bodyLabel;
                val_6 = "Key_10187";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6));
        }
        public ClanPromoteSuccessBanner()
        {
        
        }
    
    }

}
