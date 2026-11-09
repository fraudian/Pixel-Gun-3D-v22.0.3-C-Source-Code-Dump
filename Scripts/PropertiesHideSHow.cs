using UnityEngine;
public class PropertiesHideSHow : MonoBehaviour
{
    // Fields
    public bool isHidden;
    public float yAxysDelta;
    public float animTime;
    public UnityEngine.Transform target;
    public UnityEngine.Transform arrow;
    private bool _inArmory;
    public CachedChildWidgets cachedWidgets;
    private float 丌丒下丙丏不丆丏丑;
    private float 不上丕丗丁与万丌与;
    private float 丐东丟丄丗丞丐丕丐;
    private UnityEngine.Vector3 丐丝专丈世三丆丅丑;
    private bool 上一下丂丛专丙三丌;
    private bool 丁丒上三一丈与丐东;
    private const float 专丈丛世下与万丄丞 = -90;
    private const float 业七万三丂且专丛丈 = 278;
    
    // Properties
    private UnityEngine.Vector3 七下丒丆且丄七丙丌 { get; }
    private UnityEngine.Vector3 丈万丏丈上丑不丅上 { get; }
    
    // Methods
    private void Update()
    {
        float val_8;
        float val_9;
        float val_10;
        if(this.丁丒上三一丈与丐东 == false)
        {
                return;
        }
        
        if(this.丐东丟丄丗丞丐丕丐 <= 0f)
        {
            goto label_2;
        }
        
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.丐东丟丄丗丞丐丕丐 - val_1;
        this.丐东丟丄丗丞丐丕丐 = val_1;
        if(this.isHidden == false)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_2 = this.专丆三与丗世丆不丗();
        val_8 = val_2.x;
        val_9 = val_2.y;
        val_10 = val_2.z;
        UnityEngine.Vector3 val_3 = this.丈丈专丌业丂丑丞万();
        goto label_4;
        label_2:
        this.丁丒上三一丈与丐东 = false;
        return;
        label_3:
        UnityEngine.Vector3 val_4 = this.丈丈专丌业丂丑丞万();
        val_8 = val_4.x;
        val_9 = val_4.y;
        val_10 = val_4.z;
        UnityEngine.Vector3 val_5 = this.专丆三与丗世丆不丗();
        label_4:
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  this.丐东丟丄丗丞丐丕丐 / this.animTime);
        this.target.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public void OnHideClick()
    {
        bool val_1 = this.isHidden;
        this.丁丒上三一丈与丐东 = true;
        val_1 = val_1 ^ 1;
        this.isHidden = val_1;
        this.丐东丟丄丗丞丐丕丐 = this.animTime;
        this.且丐丛丒丕丆丞丕上();
    }
    public void SetState(bool 丁丞三七丌且丐丁丝)
    {
        bool val_3 = ~丁丞三七丌且丐丁丝;
        val_3 = val_3 & 1;
        this.isHidden = val_3;
        this.丁丒上三一丈与丐东 = false;
        if((val_3 & 1) == 0)
        {
                UnityEngine.Vector3 val_1 = this.丈丈专丌业丂丑丞万();
        }
        else
        {
                UnityEngine.Vector3 val_2 = this.专丆三与丗世丆不丗();
        }
        
        this.target.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.且丐丛丒丕丆丞丕上();
    }
    private UnityEngine.Vector3 专丆三与丗世丆不丗()
    {
        UnityEngine.Vector3 val_1 = this.丈丈专丌业丂丑丞万();
        UnityEngine.Vector3 val_2 = this.丈丈专丌业丂丑丞万();
        float val_3 = this.不上丕丗丁与万丌与 - this.yAxysDelta;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 且丐丛丒丕丆丞丕上()
    {
        if(this.isHidden != false)
        {
            
        }
        
        this.arrow.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private UnityEngine.Vector3 丈丈专丌业丂丑丞万()
    {
        if(this.上一下丂丛专丙三丌 != false)
        {
                return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this._inArmory != false)
        {
                this.丌丒下丙丏不丆丏丑 = -90f;
        }
        else
        {
                UnityEngine.Vector3 val_1 = this.target.localPosition;
            this.丌丒下丙丏不丆丏丑 = val_1.x;
            UnityEngine.Vector3 val_2 = this.target.localPosition;
        }
        
        this.不上丕丗丁与万丌与 = val_2.y;
        this.上一下丂丛专丙三丌 = true;
        this.丐丝专丈世三丆丅丑 = 0;
        mem[1152921536021924840] = 0;
        mem[1152921536021924844] = 0;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public PropertiesHideSHow()
    {
        this._inArmory = true;
    }

}
