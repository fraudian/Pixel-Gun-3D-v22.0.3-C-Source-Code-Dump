using UnityEngine;
public class GridElement : MonoBehaviour
{
    // Fields
    public UIGrid grid;
    
    // Properties
    private UIGrid 世一三业丈下丙且丟 { get; }
    
    // Methods
    private UIGrid 丙专丙业丘丁与七下()
    {
        UIGrid val_4;
        if(this.grid == 0)
        {
                this.grid = this.gameObject.GetComponentInParent<UIGrid>();
            return val_4;
        }
        
        val_4 = this.grid;
        return val_4;
    }
    private void OnEnable()
    {
        this.丙专丙业丘丁与七下().repositionNow = true;
    }
    private void OnDisable()
    {
        this.丙专丙业丘丁与七下().repositionNow = true;
    }
    public GridElement()
    {
    
    }

}
