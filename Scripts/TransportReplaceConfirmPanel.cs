using UnityEngine;
public class TransportReplaceConfirmPanel : MonoBehaviour
{
    // Fields
    private UILabel label;
    private UnityEngine.Events.UnityAction 丞丅丅与丅丛丝丝丝;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    private UnityEngine.Vector3 一丙丘下下丂丅丛业;
    private UnityEngine.Vector3 与丆一丒丘下丑丈丁;
    
    // Properties
    internal bool 下三业丐不丆东三丄 { get; }
    
    // Methods
    internal bool 丒丗丐下丘丄丗东与()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    internal void 世一丛丞世丁专丘丐(string 丕丗丘丑丛与丑业丒, UnityEngine.Events.UnityAction 七丑丞丟东东一丞丁)
    {
        this.label.text = 丕丗丘丑丛与丑业丒;
        this.丞丅丅与丅丛丝丝丝 = 七丑丞丟东东一丞丁;
        this.gameObject.SetActive(value:  true);
    }
    internal void 丘不丁丘万丑丈丞世()
    {
        this.丞丅丅与丅丛丝丝丝 = 0;
        this.gameObject.SetActive(value:  false);
    }
    public void U_YesButtonClick()
    {
        if(this.丞丅丅与丅丛丝丝丝 != null)
        {
                this.丞丅丅与丅丛丝丝丝.Invoke();
        }
        
        this.丘不丁丘万丑丈丞世();
    }
    public void U_NoButtonClick()
    {
        this.丘不丁丘万丑丈丞世();
    }
    private void Awake()
    {
        this.上丛丂三上与丂丕丑 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.一丙丘下下丂丅丛业 = val_2;
        mem[1152921539413735844] = val_2.y;
        mem[1152921539413735848] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  70f);
        this.与丆一丒丘下丑丈丁 = val_4;
        mem[1152921539413735856] = val_4.y;
        mem[1152921539413735860] = val_4.z;
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3 val_8;
        InGameGUIPart_Freeplay val_11;
        val_8 = this.一丙丘下下丂丅丛业;
        val_11 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_11 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(null != 0)
        {
                bool val_2 = typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.下丄业丆丟丌丘丆丂();
            val_11 = 0;
        }
        
        if((447258556 & 1) != 0)
        {
                if(GetValueOrDefault() != false)
        {
                val_8 = this.与丆一丒丘下丑丈丁;
        }
        
        }
        
        UnityEngine.Vector3 val_4 = this.上丛丂三上与丂丕丑.localPosition;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_8, y = V9.16B, z = V10.16B}, t:  UnityEngine.Time.deltaTime * 5f);
        this.上丛丂三上与丂丕丑.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public TransportReplaceConfirmPanel()
    {
    
    }

}
