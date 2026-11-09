using UnityEngine;
public class ScaleForRatio : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform[] objectsForScale;
    public float multipler;
    private UnityEngine.Vector3[] 丅与丌丘丞丏东丑丑;
    
    // Methods
    private void Awake()
    {
        var val_4;
        this.丅与丌丘丞丏东丑丑 = new UnityEngine.Vector3[0];
        val_4 = 0;
        goto label_2;
        label_14:
        if(this.objectsForScale[0] != 0)
        {
                UnityEngine.Vector3 val_3 = this.objectsForScale[0].localScale;
            var val_4 = this.丅与丌丘丞丏东丑丑 + (0 * 12);
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
        }
        
        val_4 = 1;
        label_2:
        if(val_4 < this.objectsForScale.Length)
        {
            goto label_14;
        }
    
    }
    private void OnEnable()
    {
        var val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        var val_18;
        val_12 = 0;
        goto label_1;
        label_30:
        if(this.objectsForScale[0] != 0)
        {
                float val_4 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
            val_4 = (-1.333333f) / val_4;
            val_4 = val_4 + 1f;
            val_4 = val_4 + 1f;
            var val_5 = this.丅与丌丘丞丏东丑丑 + (0 * 12);
            if(val_4 > 1.05f)
        {
                val_13 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 32;
            val_14 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 32 + 4;
            val_15 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 40;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, d:  val_4);
        }
        else
        {
                val_13 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 32;
            val_14 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 32 + 4;
            val_15 = (0 * 12) + this.丅与丌丘丞丏东丑丑 + 40;
        }
        
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, d:  val_4);
            val_16 = val_7.x;
            val_17 = val_7.z;
            this.objectsForScale[0].localScale = new UnityEngine.Vector3() {x = val_16, y = val_7.y, z = val_17};
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                UnityEngine.Transform val_15 = this.objectsForScale[0];
            UnityEngine.Vector3 val_9 = val_15.localScale;
            val_18 = null;
            val_18 = null;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  IphoneXCameraScaler.不丅七丘丈不丌丝丏);
            val_16 = val_10.x;
            val_17 = val_10.z;
            val_15.localScale = new UnityEngine.Vector3() {x = val_16, y = val_10.y, z = val_17};
        }
        
        }
        
        val_12 = 1;
        label_1:
        if(val_12 < this.objectsForScale.Length)
        {
            goto label_30;
        }
        
        UIScrollView val_11 = this.GetComponent<UIScrollView>();
        if(val_11 == 0)
        {
                return;
        }
        
        val_11.ResetPosition();
    }
    public ScaleForRatio()
    {
        this.multipler = 0.9f;
    }

}
