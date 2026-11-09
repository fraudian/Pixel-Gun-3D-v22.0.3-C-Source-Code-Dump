using UnityEngine;
public class SetScalePreviews : MonoBehaviour
{
    // Fields
    public UIPanel myScrollPanel;
    public bool useCustompWidth;
    public float customWidth;
    private float 丑丅丒丕丗下丌丌丁;
    
    // Methods
    private void Start()
    {
        float val_2;
        var val_3;
        if(this.useCustompWidth != false)
        {
                val_2 = this.customWidth;
        }
        else
        {
                val_3 = static_value_081DACA8;
            val_3 = static_value_081DACA8;
            val_2 = (static_value_081DACA8 + 184 + 16) + 144;
        }
        
        this.丑丅丒丕丗下丌丌丁 = val_2;
    }
    private void LateUpdate()
    {
        UIPanel val_20;
        float val_21;
        var val_22;
        float val_23;
        float val_24;
        var val_25;
        if(this.useCustompWidth != false)
        {
                val_20 = 0;
            val_21 = this.customWidth;
        }
        else
        {
                val_22 = static_value_081DACA8;
            val_22 = static_value_081DACA8;
            val_21 = (static_value_081DACA8 + 184 + 16) + 144;
            var val_1 = (this.useCustompWidth == false) ? 1 : 0;
        }
        
        this.丑丅丒丕丗下丌丌丁 = val_21;
        UnityEngine.Transform val_2 = this.transform;
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(val_1 == 0)
        {
            goto label_7;
        }
        
        label_21:
        T[] val_3 = val_2.GetComponentsInChildren<MapPreviewController>();
        if(val_3 == null)
        {
                return;
        }
        
        val_20 = this.myScrollPanel;
        UnityEngine.Vector2 val_4 = val_20.clipOffset;
        val_23 = val_4.x;
        if(val_3.Length < 1)
        {
                return;
        }
        
        val_24 = 0.1f;
        do
        {
            val_25 = 0;
            UnityEngine.Vector3 val_6 = val_3[val_25].transform.localPosition;
            float val_24 = val_6.x;
            float val_23 = this.丑丅丒丕丗下丌丌丁;
            val_23 = (System.Math.Abs(val_24 - val_23)) / val_23;
            val_23 = val_23 * val_24;
            val_23 = 1f - val_23;
            val_24 = (val_23 > 0f) ? (val_23) : (val_24);
            val_20 = val_3[0x0] + 32.transform;
            val_20.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        while((val_25 + 1) < val_3.Length);
        
        return;
        label_6:
        if(val_1 != 0)
        {
            goto label_21;
        }
        
        label_7:
        T[] val_10 = val_2.GetComponentsInChildren<UIButton>();
        if(val_10 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_12 = this.myScrollPanel.transform.lossyScale;
        val_23 = val_12.x;
        UnityEngine.Vector3 val_14 = this.myScrollPanel.transform.position;
        val_20 = this.myScrollPanel;
        UnityEngine.Vector2 val_15 = val_20.clipOffset;
        if(val_10.Length < 1)
        {
                return;
        }
        
        val_24 = -0.2f;
        val_15.x = val_23 * val_15.x;
        do
        {
            val_25 = 0;
            UnityEngine.Vector3 val_18 = val_10[val_25].transform.position;
            float val_27 = val_18.x;
            val_18.x = val_27 - (val_14.x + val_15.x);
            float val_26 = System.Math.Abs(val_18.x);
            val_26 = val_26 / val_23;
            val_26 = val_26 / this.丑丅丒丕丗下丌丌丁;
            val_26 = val_26 * val_24;
            val_26 = val_26 + 1f;
            val_27 = (val_26 > 0f) ? (val_26) : 0.1f;
            val_20 = val_10[0x0] + 32.transform;
            val_20.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        while((val_25 + 1) < val_10.Length);
    
    }
    public SetScalePreviews()
    {
        this.customWidth = 200f;
    }

}
