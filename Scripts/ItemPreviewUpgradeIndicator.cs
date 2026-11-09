using UnityEngine;
public class ItemPreviewUpgradeIndicator : MonoBehaviour
{
    // Fields
    public int UpgradeNumber;
    public ItemPreviewInArmoryInfoScreen ItemInfo;
    
    // Methods
    private void OnClick()
    {
        if(this.ItemInfo == 0)
        {
                return;
        }
        
        this.ItemInfo.Select();
    }
    public ItemPreviewUpgradeIndicator()
    {
    
    }

}
