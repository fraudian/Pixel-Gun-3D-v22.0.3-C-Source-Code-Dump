using UnityEngine;
public class ItemPreviewInArmoryDrag : MonoBehaviour
{
    // Methods
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        ArmoryInfoScreenController.丄丞丁丈与业上丞丟.RotateSelectedItem(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    public ItemPreviewInArmoryDrag()
    {
    
    }

}
