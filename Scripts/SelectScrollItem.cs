using UnityEngine;
public class SelectScrollItem : MonoBehaviour
{
    // Fields
    public EndlessScrollCell endlessScrollCell;
    public EndlessScrollCellDynamic endlessScrollCellDynamic;
    
    // Methods
    private void OnClick()
    {
        if(this.endlessScrollCell != 0)
        {
                this.endlessScrollCell.Select(丛丁三七丅且丝丏丙:  true);
        }
        
        if(this.endlessScrollCellDynamic == 0)
        {
                return;
        }
        
        this.endlessScrollCellDynamic.Select(丛丁三七丅且丝丏丙:  true);
    }
    public SelectScrollItem()
    {
    
    }

}
