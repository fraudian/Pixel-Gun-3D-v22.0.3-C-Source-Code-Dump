using UnityEngine;
public class ScaleReset : MonoBehaviour
{
    // Methods
    private void Reset()
    {
        var val_9;
        object val_10;
        var val_11;
        val_9 = 0;
        val_10 = 0;
        goto label_3;
        label_29:
        UnityEngine.Vector3 val_2 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Transform>()[0].localScale;
        if(val_2.x > 1.01f)
        {
            goto label_6;
        }
        
        UnityEngine.Vector3 val_3 = val_1[0x0] + 32.localScale;
        if(val_3.x >= 0)
        {
            goto label_9;
        }
        
        label_6:
        val_11 = 0;
        goto label_10;
        label_9:
        val_11 = 1;
        label_10:
        UnityEngine.Vector3 val_4 = val_1[0x0] + 32.localScale;
        if(val_4.y > 1.01f)
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_5 = val_1[0x0] + 32.localScale;
        if(val_5.y >= 0)
        {
            goto label_16;
        }
        
        label_13:
        val_11 = 0;
        label_16:
        UnityEngine.Vector3 val_6 = val_1[0x0] + 32.localScale;
        if(val_6.z <= 1.01f)
        {
                UnityEngine.Vector3 val_7 = val_1[0x0] + 32.localScale;
            if(val_7.z >= 0)
        {
                if((val_11 ^ 1 & 1) == 0)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            val_1[0x0] + 32.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            val_10 = 1;
        }
        
        }
        
        }
        
        val_9 = 1;
        label_3:
        if(val_9 < val_1.Length)
        {
            goto label_29;
        }
        
        UnityEngine.Debug.Log(message:  val_10);
    }
    public ScaleReset()
    {
    
    }

}
