using UnityEngine;
internal sealed class UIPanelRemover : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    
    // Methods
    public void RemoveUIPanels()
    {
        UnityEngine.GameObject val_7;
        var val_8;
        if(this.target != 0)
        {
            goto label_3;
        }
        
        val_7 = this.gameObject;
        this.target = val_7;
        if(val_7 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_7 = this.target;
        if(val_7 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UIPanel>(source:  val_7.GetComponents<UIPanel>());
        val_8 = 0;
        goto label_7;
        label_13:
        if(val_8 >= 1)
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_4.Item[0]);
        }
        
        val_8 = 1;
        label_7:
        if(val_8 < val_4.Count)
        {
            goto label_13;
        }
    
    }
    public UIPanelRemover()
    {
    
    }

}
