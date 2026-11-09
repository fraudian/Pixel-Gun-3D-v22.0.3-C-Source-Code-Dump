using UnityEngine;
public class ActiveStateRepeater : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _target;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丄丄丘丈专丅下丘丌;
    
    // Properties
    public UnityEngine.GameObject 丘与丈丘丒丂丁丛丟 { get; set; }
    
    // Methods
    public UnityEngine.GameObject get_Target()
    {
        return (UnityEngine.GameObject)this._target;
    }
    public void set_Target(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        this._target = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_14;
        var val_15;
        this.丄丄丘丈专丅下丘丌 = new System.Collections.Generic.List<UnityEngine.GameObject>(capacity:  this.丌丟丄业且三丛丕丄().childCount);
        System.Collections.IEnumerator val_5 = this.丌丟丄业且三丛丕丄().GetEnumerator();
        goto label_13;
        label_20:
        var val_14 = 0;
        val_14 = val_14 + 1;
        object val_7 = val_5.Current;
        this.丄丄丘丈专丅下丘丌.Add(item:  0.gameObject);
        label_13:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_5.MoveNext() == true)
        {
            goto label_20;
        }
        
        val_14 = 0;
        val_15 = 0;
        if(val_5 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_5.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void Update()
    {
        var val_10;
        if(this._target == 0)
        {
                return;
        }
        
        val_10 = 0;
        goto label_4;
        label_13:
        if(this.丄丄丘丈专丅下丘丌.Item[0].activeSelf ^ this._target.activeSelf != false)
        {
                this.丄丄丘丈专丅下丘丌.Item[0].SetActive(value:  this._target.activeSelf);
        }
        
        val_10 = 1;
        label_4:
        if(val_10 < this.丄丄丘丈专丅下丘丌.Count)
        {
            goto label_13;
        }
    
    }
    public ActiveStateRepeater()
    {
    
    }

}
