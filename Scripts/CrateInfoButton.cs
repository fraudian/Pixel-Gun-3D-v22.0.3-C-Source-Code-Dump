using UnityEngine;
public class CrateInfoButton : MonoBehaviour
{
    // Fields
    private System.EventHandler 丅丕丌丛万丂丈七与;
    public UnityEngine.Transform objectToRotate;
    private float 丞丌丈东下丛丕专丘;
    private UnityEngine.Quaternion 东业丗下万三丆丝上;
    private UnityEngine.Vector2 下丏业丏三一且万丝;
    private bool 且三丝万丅丈丘丁丂;
    private bool 专丕丒丄下上丅且丑;
    private float 业不丞东丞丗七丗丒;
    private float 丅万且万丗丒七丙丁;
    internal static bool 丙丒丘丐丙一丒东业;
    
    // Methods
    public void add_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525854015800);
    
    }
    public void remove_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525854152376);
    
    }
    private void 万丟专丏丏丆丒丟专()
    {
        var val_1;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    public void OnPress(bool 丙与丈丛丑丘丞三七)
    {
        this.且三丝万丅丈丘丁丂 = 丙与丈丛丑丘丞三七;
        this.专丕丒丄下上丅且丑 = true;
    }
    public void RotateToDefault()
    {
        this.丞丌丈东下丛丕专丘 = 0f;
    }
    private void Awake()
    {
        UnityEngine.Quaternion val_1 = this.objectToRotate.rotation;
        this.东业丗下万三丆丝上 = val_1;
        mem[1152921525854624976] = val_1.y;
        mem[1152921525854624980] = val_1.z;
        mem[1152921525854624984] = val_1.w;
    }
    private void 且丟上丅丞丝丌丁丒()
    {
        var val_2;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.下丏业丏三一且万丝 = val_1;
        mem[1152921525854741088] = val_1.y;
        this.专丕丒丄下上丅且丑 = false;
        val_2 = null;
        val_2 = null;
        CrateInfoButton.丙丒丘丐丙一丒东业 = false;
        this.丅万且万丗丒七丙丁 = 0f;
    }
    private void OnDisable()
    {
        this.且丟上丅丞丝丌丁丒();
    }
    public void Update()
    {
        var val_17;
        float val_18;
        var val_19;
        UnityEngine.Vector2 val_20;
        float val_21;
        var val_22;
        if(this.专丕丒丄下上丅且丑 == false)
        {
            goto label_1;
        }
        
        val_17 = null;
        val_17 = null;
        CrateInfoButton.丙丒丘丐丙一丒东业 = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        val_18 = this;
        this.丞丌丈东下丛丕专丘 = UnityEngine.Time.time;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.下丏业丏三一且万丝, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y})) == false)
        {
            goto label_8;
        }
        
        val_19 = val_2.y;
        val_20 = val_2.x;
        this.下丏业丏三一且万丝 = val_2;
        mem[1152921525854973280] = val_2.y;
        goto label_9;
        label_1:
        val_18 = this.丞丌丈东下丛丕专丘;
        goto label_18;
        label_8:
        val_20 = this.下丏业丏三一且万丝;
        label_9:
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_20, y = this.下丏业丏三一且万丝});
        this.下丏业丏三一且万丝 = val_2;
        mem[1152921525854973280] = val_2.y;
        float val_17 = val_6.x;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        float val_8 = UnityEngine.Time.deltaTime;
        this.objectToRotate.Rotate(axis:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, angle:  (val_17 * val_8) * (-60f));
        val_21 = val_17 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_17 = this.丅万且万丗丒七丙丁 + val_21;
        this.丅万且万丗丒七丙丁 = val_17;
        if(this.且三丝万丅丈丘丁丂 != true)
        {
                val_21 = this.业不丞东丞丗七丗丒;
            if(System.Math.Abs(val_17) < 0)
        {
                this.万丟专丏丏丆丒丟专();
        }
        
            this.且丟上丅丞丝丌丁丒();
        }
        
        label_18:
        val_22 = null;
        val_22 = null;
        if((UnityEngine.Time.time - this.丞丌丈东下丛丕专丘) <= ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                return;
        }
        
        UnityEngine.Quaternion val_14 = this.objectToRotate.rotation;
        float val_19 = 300f;
        val_19 = UnityEngine.Time.deltaTime * val_19;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, to:  new UnityEngine.Quaternion() {x = this.东业丗下万三丆丝上, y = val_8, z = V13.16B, w = V14.16B}, maxDegreesDelta:  val_19);
        this.objectToRotate.rotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
    }
    public CrateInfoButton()
    {
        this.业不丞东丞丗七丗丒 = 10f;
    }
    private static CrateInfoButton()
    {
    
    }

}
