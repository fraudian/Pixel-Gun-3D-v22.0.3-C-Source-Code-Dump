using UnityEngine;
public class AnimatedAlpha : MonoBehaviour
{
    // Fields
    public float alpha;
    public bool animateMaterial;
    private UIWidget 丆不下丄丄且丞一丈;
    private UIPanel 与业丌丄且丁丛与丁;
    private UnityEngine.Material 丘上专不丂万业不一;
    
    // Methods
    private void OnEnable()
    {
        if(this.animateMaterial == false)
        {
            goto label_1;
        }
        
        if(this.丘上专不丂万业不一 != 0)
        {
            goto label_6;
        }
        
        this.丘上专不丂万业不一 = this.GetComponentInChildren<UnityEngine.MeshRenderer>().sharedMaterial;
        goto label_6;
        label_1:
        this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
        this.与业丌丄且丁丛与丁 = this.GetComponent<UIPanel>();
        label_6:
        this.LateUpdate();
    }
    private void LateUpdate()
    {
        var val_19;
        float val_20;
        val_19 = this;
        if(this.animateMaterial != false)
        {
                if(this.丘上专不丂万业不一 == 0)
        {
                return;
        }
        
            UnityEngine.Color val_2 = this.丘上专不丂万业不一.color;
            if(val_2.a == this.alpha)
        {
                return;
        }
        
            UnityEngine.Color val_3 = this.丘上专不丂万业不一.color;
            val_20 = val_3.r;
            UnityEngine.Color val_4 = this.丘上专不丂万业不一.color;
            UnityEngine.Color val_5 = this.丘上专不丂万业不一.color;
            this.丘上专不丂万业不一.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            return;
        }
        
        if(this.丆不下丄丄且丞一丈 == 0)
        {
                if(this.与业丌丄且丁丛与丁 == 0)
        {
                this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
        }
        
        }
        
        if(this.丆不下丄丄且丞一丈 != 0)
        {
                val_20 = this.alpha;
        }
        
        if(this.与业丌丄且丁丛与丁 == 0)
        {
                return;
        }
        
        val_19 = ???;
        val_20 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
    }
    public AnimatedAlpha()
    {
        this.alpha = 1f;
    }

}
