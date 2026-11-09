using UnityEngine;

namespace Rilisoft
{
    internal class CraftBuildingReadyWindow : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丏丘七丞丄丙丌丞丁 世丒丂且与三丁丙世;
        private Rilisoft.TextGroup _itemName;
        private Rilisoft.TextGroup _expCount;
        
        // Methods
        public void Show(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            string val_14;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_14 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            this.丐丆七且丞丏下三丙 = val_14.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.CraftBuildingReadyWindow::U_ClickOnGetReward()), 与且专丈不万东一万:  "lobby craft");
            this.世丒丂且与三丁丙世 = 丑丘丕且丆东丏丘丙;
            if(丑丘丕且丆东丏丘丙 != null)
            {
                    this._itemName.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
                val_14 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3003"), arg0:  this.世丒丂且与三丁丙世.丙丕丞且丕不丘丙丑().三丌专三东世丆东专());
                this._expCount.Text = val_14;
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
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
                this.丐丆七且丞丏下三丙 = 0;
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丄业万万丄丕丗与丑(下丅丙一丂丗丅丝七:  this.世丒丂且与三丁丙世);
            }
            else
            {
                    this = this.世丒丂且与三丁丙世;
            }
            
            mem2[0] = 0;
        }
        public void U_ClickOnGetReward()
        {
            this.Hide();
        }
        public CraftBuildingReadyWindow()
        {
        
        }
    
    }

}
