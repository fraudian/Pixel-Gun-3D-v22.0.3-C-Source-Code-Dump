using UnityEngine;
public class AnimatedColor : MonoBehaviour
{
    // Fields
    public UnityEngine.Color color;
    public bool animateMaterial;
    private UIWidget 丆不下丄丄且丞一丈;
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
        
        this.丘上专不丂万业不一 = this.GetComponentInChildren<UnityEngine.MeshRenderer>().material;
        goto label_6;
        label_1:
        this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
        label_6:
        this.LateUpdate();
    }
    private void LateUpdate()
    {
        if(this.animateMaterial != false)
        {
                if(this.丘上专不丂万业不一 == 0)
        {
                return;
        }
        
            this.丘上专不丂万业不一.color = new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B};
            return;
        }
        
        if(this.丆不下丄丄且丞一丈 == 0)
        {
                return;
        }
        
        this.丆不下丄丄且丞一丈.color = new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    public AnimatedColor()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535258942684] = val_1.g;
        mem[1152921535258942688] = val_1.b;
        mem[1152921535258942692] = val_1.a;
    }

}
