using UnityEngine;

namespace PGCompany
{
    public class ClanWarCellInfoBigViewTouchDelegate : MonoBehaviour
    {
        // Fields
        private float 不专三丄一丙专丆东;
        
        // Methods
        private void OnClick()
        {
            if(this.不专三丄一丙专丆东 > 20f)
            {
                    return;
            }
            
            ClanWarUI.丑七不且上丗丁一世().丂丘一丐七且丕世丅();
        }
        private void OnPress(bool 丐且与丝且丕丏丕业)
        {
            if(丐且与丝且丕丏丕业 != false)
            {
                    this.不专三丄一丙专丆东 = 0f;
                ClanWarUI.丑七不且上丗丁一世().丅丌丅丝业七三三丑().丐且丞丕丞三丏丌丄();
                return;
            }
            
            ClanWarUI.丑七不且上丗丁一世().丅丌丅丝业七三三丑().世丛丗丛丂丌丒丑专();
        }
        private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            float val_3 = this.不专三丄一丙专丆东;
            val_3 = 丞且丅三三东不丄且.x + val_3;
            this.不专三丄一丙专丆东 = val_3;
            ClanWarUI.丑七不且上丗丁一世().丅丌丅丝业七三三丑().下丏且一三丐一丐不(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        }
        public ClanWarCellInfoBigViewTouchDelegate()
        {
        
        }
    
    }

}
