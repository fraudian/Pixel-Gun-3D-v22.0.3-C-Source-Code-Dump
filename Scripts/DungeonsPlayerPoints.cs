using UnityEngine;
public class DungeonsPlayerPoints : MonoBehaviour
{
    // Fields
    public SiegeCharacterPoint[] points;
    
    // Methods
    internal void 专丑丗丆丌丛丌丐丆(System.Collections.Generic.List<NetworkStartTable> 丁丟丌专三上丐丕丙, System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丘丐丙丟万丁专丆丈)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 1152921504838422528;
        val_10 = 0;
        goto label_6;
        label_13:
        this.points[0].上东与丛丞下丈专丈(不且上一上丐三万丛:  丁丟丌专三上丐丕丙.Item[0]);
        val_10 = 1;
        goto label_6;
        label_9:
        if(丁丟丌专三上丐丕丙 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        if(this.points == null)
        {
            goto label_9;
        }
        
        label_8:
        if(val_10 < (UnityEngine.Mathf.Min(a:  this.points.Length, b:  丁丟丌专三上丐丕丙.Count)))
        {
            goto label_13;
        }
        
        val_11 = 丁丟丌专三上丐丕丙.Count;
        goto label_15;
        label_26:
        val_9 = 丘丐丙丟万丁专丆丈.Count;
        int val_7 = val_11 - 丁丟丌专三上丐丕丙.Count;
        SiegeCharacterPoint val_10 = this.points[(long)val_11];
        if(val_7 < val_9)
        {
                val_10.FillFromPlayerSettings(专丞上七七且丝七丗:  丘丐丙丟万丁专丆丈.Item[val_7]);
        }
        else
        {
                val_10.SetEmpty();
        }
        
        val_11 = val_11 + 1;
        label_15:
        if(val_11 < this.points.Length)
        {
            goto label_26;
        }
    
    }
    public void Clear()
    {
        goto label_0;
        label_5:
        this.points[0].SetEmpty();
        0 = 1;
        label_0:
        if(0 < this.points.Length)
        {
            goto label_5;
        }
    
    }
    public DungeonsPlayerPoints()
    {
    
    }

}
