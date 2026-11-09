using UnityEngine;

namespace Rilisoft
{
    internal class FortBuildingReadyWindow : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.东且东丒丐世丐丞丒 丗上专下七丂丐丙专;
        private System.Action<Rilisoft.东且东丒丐世丐丞丒> 专七一丑七丗业丝丝;
        private Rilisoft.TextGroup _itemName;
        private Rilisoft.TextGroup _expCount;
        
        // Methods
        public void add_OnWindowClose(System.Action<Rilisoft.东且东丒丐世丐丞丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专七一丑七丗业丝丝, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专七一丑七丗业丝丝 != 1152921542620260872);
        
        }
        public void remove_OnWindowClose(System.Action<Rilisoft.东且东丒丐世丐丞丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专七一丑七丗业丝丝, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专七一丑七丗业丝丝 != 1152921542620397448);
        
        }
        public void Show(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            string val_13;
            if(三丐业七丘丂丐下丘 == null)
            {
                    this.Hide();
            }
            
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_13 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            this.丐丆七且丞丏下三丙 = val_13.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.FortBuildingReadyWindow::U_ClickOnGetReward()), 与且专丈不万东一万:  "fort craft");
            this.丗上专下七丂丐丙专 = 三丐业七丘丂丐下丘;
            if(三丐业七丘丂丐下丘 != null)
            {
                    this._itemName.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().丆与丘丕世丘东丕一());
                val_13 = this.丗上专下七丂丐丙专.丙丕丞且丕不丘丙丑().三丌专三东世丆东专().ToString();
                this._expCount.Text = val_13;
            }
            
            this.gameObject.SetActive(value:  true);
        }
        public void Hide()
        {
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
                this.丐丆七且丞丏下三丙 = 0;
            }
            
            this.丗上专下七丂丐丙专 = 0;
        }
        public void U_ClickOnGetReward()
        {
            var val_2;
            var val_3;
            this.Hide();
            if(this.专七一丑七丗业丝丝 != null)
            {
                    this.专七一丑七丗业丝丝.Invoke(obj:  this.丗上专下七丂丐丙专);
            }
            
            val_2 = null;
            val_2 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.OnZoomOut();
        }
        public FortBuildingReadyWindow()
        {
        
        }
    
    }

}
