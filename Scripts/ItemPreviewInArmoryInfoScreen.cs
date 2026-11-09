using UnityEngine;
public class ItemPreviewInArmoryInfoScreen : MonoBehaviour
{
    // Fields
    private bool 丞丈丌且东丆丅丗万;
    private System.Action<ItemPreviewInArmoryInfoScreen, CategoryNames, 丙且上东下丏丏丟下, string, int, int> 丄丗东丕丕丑不东丕;
    public bool isEnableRotate;
    public bool isEnableScale;
    public bool isInstantScale;
    public string id;
    public CategoryNames category;
    public string headName;
    public int numUpgrade;
    public UnityEngine.Transform model;
    public UnityEngine.Vector3 baseRotation;
    internal static readonly float 丝业丏丄且丌业世丛;
    internal static readonly float 丕丏且且丘丙丞丏下;
    private float 上专丘丛世且丐下业;
    internal bool 丏不丐专丙丟下丌丕;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    private bool 丙三丆业且东丄丆万;
    private float 丗丁业丕丒丌七业丟;
    
    // Properties
    private UnityEngine.Transform 丞且不世世丗下丝专 { get; }
    
    // Methods
    public void add_OnSelect(System.Action<ItemPreviewInArmoryInfoScreen, CategoryNames, 丙且上东下丏丏丟下, string, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丗东丕丕丑不东丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丗东丕丕丑不东丕 != 1152921526351259472);
    
    }
    public void remove_OnSelect(System.Action<ItemPreviewInArmoryInfoScreen, CategoryNames, 丙且上东下丏丏丟下, string, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丗东丕丕丑不东丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丗东丕丕丑不东丕 != 1152921526351396048);
    
    }
    private UnityEngine.Transform 丘丄丐世专丌丞丝丑()
    {
        UnityEngine.Transform val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.专专丏下丐丂丂丅东)) != false)
        {
                val_3 = this.专专丏下丐丂丂丅东;
            return val_2;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        this.专专丏下丐丂丂丅东 = val_2;
        return val_2;
    }
    public void SetSelected(bool 丏丈丞丙七丛东七丌, bool 东丝三一丞下业丂丝 = False)
    {
        bool val_8;
        bool val_9;
        var val_10;
        var val_11;
        float val_12;
        var val_13;
        val_8 = 丏丈丞丙七丛东七丌;
        val_9 = val_8;
        this.丞丈丌且东丆丅丗万 = val_9;
        if(东丝三一丞下业丂丝 != false)
        {
                if(this.丘丄丐世专丌丞丝丑() != 0)
        {
                val_8 = 1152921505075269632;
            val_10 = null;
            if(this.丞丈丌且东丆丅丗万 != false)
        {
                val_11 = null;
            val_12 = ItemPreviewInArmoryInfoScreen.丝业丏丄且丌业世丛;
        }
        else
        {
                val_13 = null;
            val_12 = ItemPreviewInArmoryInfoScreen.丕丏且且丘丙丞丏下;
        }
        
            this.丘丄丐世专丌丞丝丑().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
            val_9 = this.丞丈丌且东丆丅丗万;
        }
        
        if(val_9 != true)
        {
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.baseRotation, y = V8.16B, z = V9.16B});
            this.model.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        
        this.gameObject.SetActive(value:  (this.丞丈丌且东丆丅丗万 == true) ? 1 : 0);
    }
    public void Select()
    {
        if(this.丞丈丌且东丆丅丗万 != false)
        {
                return;
        }
        
        if(this.丄丗东丕丕丑不东丕 == null)
        {
                return;
        }
        
        this.丄丗东丕丕丑不东丕.Invoke(arg1:  this, arg2:  this.category, arg3:  0, arg4:  0, arg5:  0, arg6:  0);
    }
    private void OnClick()
    {
        this.Select();
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        this.丙三丆业且东丄丆万 = true;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
        {
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.RotateSelectedItem(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
            return;
        }
        
        this.DragRotate(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    public void DragRotate(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.丏不丐专丙丟下丌丕 == false)
        {
                return;
        }
        
        if(this.丞丈丌且东丆丅丗万 == false)
        {
                return;
        }
        
        if(this.丙三丆业且东丄丆万 != false)
        {
                this.丙三丆业且东丄丆万 = false;
            return;
        }
        
        this.上专丘丛世且丐下业 = 0f;
        this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    private void 丗丗业丆三丐丈丕万(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_4;
        UnityEngine.Transform val_5;
        val_4 = 丞且丅三三东不丄且.x;
        val_5 = this;
        if(this.model == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_2 = this.model.localRotation;
        val_5 = this.model;
        val_2.y = val_2.y - val_4;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_4 = val_3.x;
        val_5.localRotation = new UnityEngine.Quaternion() {x = val_4, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    private void Update()
    {
        var val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        bool val_25;
        bool val_26;
        float val_27;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        val_20 = this;
        val_21 = 0.5f;
        val_22 = UnityEngine.Time.realtimeSinceStartup - this.丗丁业丕丒丌七业丟;
        val_23 = 0f;
        float val_2 = (val_22 > val_21) ? (val_23) : (val_22);
        val_24 = this.上专丘丛世且丐下业;
        this.丗丁业丕丒丌七业丟 = UnityEngine.Time.realtimeSinceStartup;
        if(val_24 >= 0)
        {
            goto label_1;
        }
        
        float val_4 = UnityEngine.Time.unscaledDeltaTime;
        val_25 = val_20;
        val_26 = this.isEnableRotate;
        val_4 = val_24 + val_4;
        this.上专丘丛世且丐下业 = val_4;
        if((val_4 < 2f) || (val_26 == true))
        {
            goto label_3;
        }
        
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.baseRotation, y = val_24, z = V9.16B});
        val_24 = val_5.x;
        val_27 = val_5.z;
        val_22 = val_24;
        val_23 = val_5.y;
        val_21 = val_27;
        this.model.localRotation = new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_21, w = val_5.w};
        goto label_7;
        label_1:
        val_25 = this.isEnableRotate;
        label_7:
        val_26 = mem[this.isEnableRotate];
        val_26 = val_25;
        label_3:
        if(val_26 != false)
        {
                val_22 = this.上专丘丛世且丐下业;
            if(val_22 >= 2f)
        {
                float val_6 = UnityEngine.Time.unscaledDeltaTime;
            val_6 = val_6 * 30f;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6, y:  0f);
            val_22 = val_7.x;
            val_23 = val_7.y;
            this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_22, y = val_23});
        }
        
        }
        
        if(this.isEnableScale == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = this.丘丄丐世专丌丞丝丑().localScale;
        val_24 = val_9.x;
        if(this.isInstantScale == false)
        {
            goto label_12;
        }
        
        if(this.丞丈丌且东丆丅丗万 != false)
        {
                val_31 = null;
            val_31 = null;
            if(val_24 < 0)
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_32 = null;
            val_32 = null;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  ItemPreviewInArmoryInfoScreen.丝业丏丄且丌业世丛);
            val_27 = val_12.y;
            val_23 = val_27;
            val_21 = val_12.z;
            this.丘丄丐世专丌丞丝丑().localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_23, z = val_21};
        }
        
        }
        
        if(this.丞丈丌且东丆丅丗万 == true)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        if(val_24 <= ItemPreviewInArmoryInfoScreen.丕丏且且丘丙丞丏下)
        {
                return;
        }
        
        val_20 = this.丘丄丐世专丌丞丝丑();
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        val_34 = null;
        val_34 = null;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  ItemPreviewInArmoryInfoScreen.丕丏且且丘丙丞丏下);
        val_24 = val_15.x;
        val_27 = val_15.z;
        if(val_20 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_12:
        if(this.丞丈丌且东丆丅丗万 != false)
        {
                val_35 = null;
            val_35 = null;
            if(val_24 < 0)
        {
                float val_17 = (val_2 + val_2) + val_24;
            this.丘丄丐世专丌丞丝丑().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        if(this.丞丈丌且东丆丅丗万 == true)
        {
                return;
        }
        
        val_36 = null;
        val_36 = null;
        if(val_24 <= ItemPreviewInArmoryInfoScreen.丕丏且且丘丙丞丏下)
        {
                return;
        }
        
        float val_20 = -2f;
        val_20 = val_2 * val_20;
        val_24 = val_24 + val_20;
        val_20 = this.丘丄丐世专丌丞丝丑();
        label_31:
        val_20.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void SetBaseRotation()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.baseRotation, y = V8.16B, z = V9.16B});
        this.model.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
    }
    public ItemPreviewInArmoryInfoScreen()
    {
        this.丞丈丌且东丆丅丗万 = true;
        this.isEnableRotate = true;
        this.isEnableScale = true;
        this.isInstantScale = true;
        this.上专丘丛世且丐下业 = 1000f;
        this.丏不丐专丙丟下丌丕 = true;
        this.丙三丆业且东丄丆万 = true;
    }
    private static ItemPreviewInArmoryInfoScreen()
    {
        ItemPreviewInArmoryInfoScreen.丝业丏丄且丌业世丛 = 1.34f;
        ItemPreviewInArmoryInfoScreen.丕丏且且丘丙丞丏下 = 0.84f;
    }

}
