using UnityEngine;
public class ReversScale : PGBehaviour
{
    // Fields
    public bool x;
    public bool y;
    public bool z;
    
    // Methods
    private void Update()
    {
        var val_28;
        var val_29;
        float val_30;
        float val_31;
        float val_32;
        val_28 = this;
        if(this.x != false)
        {
                UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().lossyScale;
            if(val_2.x < 0)
        {
                UnityEngine.Vector3 val_5 = this.transform.localScale;
            val_29 = val_5.x;
            UnityEngine.Vector3 val_7 = this.丌丟丄业且三丛丕丄().localScale;
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().localScale;
            val_30 = 0f;
            val_31 = 0f;
            val_32 = 0f;
            this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
        }
        
        }
        
        if(this.y != false)
        {
                UnityEngine.Vector3 val_11 = this.transform.lossyScale;
            if(val_11.y < 0)
        {
                UnityEngine.Vector3 val_14 = this.transform.localScale;
            val_29 = val_14.x;
            UnityEngine.Vector3 val_16 = this.丌丟丄业且三丛丕丄().localScale;
            UnityEngine.Vector3 val_18 = this.丌丟丄业且三丛丕丄().localScale;
            val_30 = 0f;
            val_31 = 0f;
            val_32 = 0f;
            this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
        }
        
        }
        
        if(this.z == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_20 = this.transform.lossyScale;
        if(val_20.z >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_23 = this.transform.localScale;
        val_29 = val_23.x;
        UnityEngine.Vector3 val_25 = this.丌丟丄业且三丛丕丄().localScale;
        val_28 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_27 = val_28.localScale;
        this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ReversScale()
    {
    
    }

}
