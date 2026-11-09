using UnityEngine;
internal sealed class PlayerArrowToPortalController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject ArrowToPortalPoint;
    internal float 丈三丐下丈不丆丆丒;
    internal float 丏丈丗丞丅且丞上丘;
    private UnityEngine.Texture greenTexture;
    private UnityEngine.Texture redTexture;
    private UnityEngine.Transform 丛丂丘丈丏丟下丆世;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Transform> 上丏丝丝丅丐丅专丒;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Camera> 上七世丄丌业丈丌世;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Camera> 世丁丅丄专且丈三丂;
    private UnityEngine.Transform 丂丈下丘丒丑丞丘丞;
    private UnityEngine.Vector3 三丑东丅丕丕万下不;
    private UnityEngine.Renderer[] 丘丒丑丗丑下丁三世;
    private UnityEngine.Coroutine 下丘丄上丘一丁三与;
    private static readonly System.Collections.Generic.Queue<UnityEngine.GameObject> 一丄丂丘丒且上丝丄;
    private static readonly Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Object> 丙丝且七丂丞丌且丕;
    
    // Properties
    internal UnityEngine.Camera 丒丁三丒下丌丛丆专 { get; }
    internal UnityEngine.Camera 与丌丑下丐丞丕丕丗 { get; }
    
    // Methods
    internal UnityEngine.Camera 七丒丝丗与东丆丞丂()
    {
        if(this.上七世丄丌业丈丌世 != null)
        {
                return this.上七世丄丌业丈丌世.世三丞丅丑丌丈丈一();
        }
        
        return this.上七世丄丌业丈丌世.世三丞丅丑丌丈丈一();
    }
    internal UnityEngine.Camera 丌专不万东丆业上丑()
    {
        if(this.世丁丅丄专且丈三丂 != null)
        {
                return this.世丁丅丄专且丈三丂.世三丞丅丑丌丈丈一();
        }
        
        return this.世丁丅丄专且丈三丂.世三丞丅丑丌丈丈一();
    }
    internal PlayerArrowToPortalController()
    {
        this.丈三丐下丈不丆丆丒 = 0f;
        this.丏丈丗丞丅且丞上丘 = 1.5f;
        this.上丏丝丝丅丐丅专丒 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Transform>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Transform>(object:  this, method:  UnityEngine.Transform PlayerArrowToPortalController::丄七世丄丁万七七一()));
        this.上七世丄丌业丈丌世 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Camera>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Camera>(object:  this, method:  UnityEngine.Camera PlayerArrowToPortalController::丌且丟丈七丈一丗丞()));
        this.世丁丅丄专且丈三丂 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Camera>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Camera>(object:  this, method:  UnityEngine.Camera PlayerArrowToPortalController::业丟万丈不丂上丐下()));
    }
    private void Update()
    {
        bool val_47;
        bool val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        val_47 = this;
        val_48 = 1152921504848912384;
        if(this.丂丈下丘丒丑丞丘丞 == 0)
        {
                return;
        }
        
        if(this.丛丂丘丈丏丟下丆世 == 0)
        {
                return;
        }
        
        float val_45 = 0.01745329f;
        val_45 = this.七丒丝丗与东丆丞丂().fieldOfView * val_45;
        val_45 = val_45 * 0.5f;
        float val_46 = val_45;
        UnityEngine.Vector3 val_7 = this.上丏丝丝丅丐丅专丒.世三丞丅丑丌丈丈一().localPosition;
        val_46 = (this.丏丈丗丞丅且丞上丘 + 0.3f) / val_46;
        this.上丏丝丝丅丐丅专丒.世三丞丅丑丌丈丈一().localPosition = new UnityEngine.Vector3() {x = val_7.x, y = this.丏丈丗丞丅且丞上丘, z = val_46};
        UnityEngine.Vector3 val_9 = this.丂丈下丘丒丑丞丘丞.TransformPoint(position:  new UnityEngine.Vector3() {x = this.三丑东丅丕丕万下不, y = this.丏丈丗丞丅且丞上丘, z = val_7.x});
        UnityEngine.Vector3 val_10 = this.丛丂丘丈丏丟下丆世.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_14 = this.七丒丝丗与东丆丞丂().transform.position;
        UnityEngine.Vector3 val_17 = this.丌专不万东丆业上丑().transform.position;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        this.丛丂丘丈丏丟下丆世.rotation = new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w};
        UnityEngine.Vector3 val_24 = this.七丒丝丗与东丆丞丂().gameObject.transform.position;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        float val_47 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        val_47 = val_47 * 0.25f;
        float val_31 = UnityEngine.Mathf.Max(a:  9f, b:  val_47);
        var val_34 = (((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z})) < 0) ? 1 : 0) | (((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z})) < 0) ? 1 : 0);
        val_49 = null;
        val_49 = null;
        val_50 = (SelectionControlMode.IsShowing | val_34) ^ 1;
        if(TrainingController.丄丞丁丈与业上丞丟 != 0)
        {
                val_51 = null;
            val_51 = null;
            val_52 = ((TrainingController.丄丞丁丈与业上丞丟.forceHideArrow == false) ? 1 : 0) & val_50;
        }
        
        if(val_34 != 0)
        {
                UnityEngine.Vector3 val_40 = this.七丒丝丗与东丆丞丂().WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            var val_41 = (val_40.x < 0) ? 1 : 0;
            val_41 = val_41 | ((val_40.x > 1f) ? 1 : 0);
            var val_43 = (val_40.y < 0) ? 1 : 0;
            val_41 = val_52 | val_41;
            val_43 = val_43 | ((val_40.y > 1f) ? 1 : 0);
            val_48 = val_43 | val_41;
        }
        
        val_53 = 0;
        val_47 = val_48;
        goto label_38;
        label_42:
        this.丘丒丑丗丑下丁三世[0].enabled = val_47;
        val_53 = 1;
        label_38:
        if(val_53 < this.丘丒丑丗丑下丁三世.Length)
        {
            goto label_42;
        }
    
    }
    internal void 丒丐丙业丘丄三丕丁(UnityEngine.Transform 丞上世与丈业丒丕不, UnityEngine.Vector3 三丙业丝丐上不丝丈)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        this.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  丞上世与丈业丒丕不, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = 三丙业丝丐上不丝丈.x, y = 三丙业丝丐上不丝丈.y, z = 三丙业丝丐上不丝丈.z}, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    internal void 丒丐丙业丘丄三丕丁(UnityEngine.Transform 丞上世与丈业丒丕不, UnityEngine.Vector3 三丙业丝丐上不丝丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        UnityEngine.Transform val_16;
        float val_17;
        UnityEngine.Object val_18;
        var val_19;
        val_17 = 三丙业丝丐上不丝丈.z;
        val_18 = this;
        this.丂丈下丘丒丑丞丘丞 = 丞上世与丈业丒丕不;
        this.三丑东丅丕丕万下不 = 三丙业丝丐上不丝丈;
        mem[1152921535908853348] = 三丙业丝丐上不丝丈.y;
        mem[1152921535908853352] = val_17;
        UnityEngine.GameObject val_1 = PlayerArrowToPortalController.丟七丒万与丒东且丅();
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                val_19 = val_18;
            this.丛丂丘丈丏丟下丆世 = val_1.transform;
        }
        else
        {
                val_19 = val_18;
            this.丛丂丘丈丏丟下丆世 = 0.transform;
        }
        
        this.丘丒丑丗丑下丁三世 = val_1.GetComponentsInChildren<UnityEngine.Renderer>();
        val_16 = this.上丏丝丝丅丐丅专丒.世三丞丅丑丌丈丈一();
        this.丛丂丘丈丏丟下丆世.parent = val_16;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_17 = val_7.x;
        this.丛丂丘丈丏丟下丆世.localPosition = new UnityEngine.Vector3() {x = val_17, y = val_7.y, z = val_7.z};
        if(this.丘丒丑丗丑下丁三世.Length == 0)
        {
                return;
        }
        
        UnityEngine.Renderer val_16 = this.丘丒丑丗丑下丁三世[0];
        if(val_16 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_9 = UnityEngine.Color.red;
        val_18 = mem[val_10 != true ? this.redTexture : this.greenTexture];
        val_18 = ((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, rhs:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a})) != true) ? this.redTexture : this.greenTexture;
        if(val_18 == 0)
        {
                return;
        }
        
        val_16 = val_16.material;
        if(val_18 == val_16.mainTexture)
        {
                return;
        }
        
        val_16.material.mainTexture = val_18;
    }
    internal void 一专丘东三丞东丁三()
    {
        if(this.丛丂丘丈丏丟下丆世 == 0)
        {
                return;
        }
        
        this.丂丈下丘丒丑丞丘丞 = 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.三丑东丅丕丕万下不 = val_2;
        mem[1152921535909137380] = val_2.y;
        mem[1152921535909137384] = val_2.z;
        PlayerArrowToPortalController.丐丗上七且丅丗东世(丌丈丙丞业丄且万业:  this.丛丂丘丈丏丟下丆世.gameObject);
        this.丛丂丘丈丏丟下丆世 = 0;
        this.丘丒丑丗丑下丁三世 = new UnityEngine.Renderer[0];
    }
    internal void 专丗丑上丝万丘丁丅(UnityEngine.Transform 丞上世与丈业丒丕不, UnityEngine.Vector3 三丙业丝丐上不丝丈)
    {
        UnityEngine.Transform val_9;
        UnityEngine.Transform val_10;
        var val_11;
        val_9 = 丞上世与丈业丒丕不;
        val_10 = this;
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(this.丛丂丘丈丏丟下丆世 != 0)
        {
            goto label_12;
        }
        
        this.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  val_9, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = 三丙业丝丐上不丝丈.x, y = 三丙业丝丐上不丝丈.y, z = 三丙业丝丐上不丝丈.z});
        if(null != 0)
        {
            goto label_15;
        }
        
        goto label_14;
        label_12:
        this.丂丈下丘丒丑丞丘丞 = val_9;
        this.三丑东丅丕丕万下不 = 三丙业丝丐上不丝丈;
        mem[1152921535909298532] = 三丙业丝丐上不丝丈.y;
        mem[1152921535909298536] = 三丙业丝丐上不丝丈.z;
        if(null != 0)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        val_9 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        if(val_9.丘丂三东丁且丙世七() == false)
        {
                return;
        }
        
        val_9 = this.丛丂丘丈丏丟下丆世.parent;
        if(val_9 == (typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 400.丌丟丄业且三丛丕丄()))
        {
                return;
        }
        
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 400.丌丟丄业且三丛丕丄();
        this.丛丂丘丈丏丟下丆世.parent = val_9;
        val_10 = this.丛丂丘丈丏丟下丆世;
        val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 丒丗三丗东丌丘丅东(UnityEngine.Color 丕丟上万上且一丑三)
    {
        if(this.下丘丄上丘一丁三与 != null)
        {
                this.StopCoroutine(routine:  this.下丘丄上丘一丁三与);
        }
        
        this.下丘丄上丘一丁三与 = this.StartCoroutine(routine:  this.丏丗丝东万丛丙丑三(丕丟上万上且一丑三:  new UnityEngine.Color() {r = 丕丟上万上且一丑三.r, g = 丕丟上万上且一丑三.g, b = 丕丟上万上且一丑三.b, a = 丕丟上万上且一丑三.a}));
    }
    private System.Collections.IEnumerator 丏丗丝东万丛丙丑三(UnityEngine.Color 丕丟上万上且一丑三)
    {
        PlayerArrowToPortalController.上丞丘业上丝丝丄丁 val_1 = new PlayerArrowToPortalController.上丞丘业上丝丝丄丁();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丕丟上万上且一丑三 = 丕丟上万上且一丑三;
        mem[1152921535909615916] = 丕丟上万上且一丑三.g;
        mem[1152921535909615920] = 丕丟上万上且一丑三.b;
        mem[1152921535909615924] = 丕丟上万上且一丑三.a;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static bool 不丟丟业丝丆下丘丁()
    {
        var val_9;
        System.Collections.Generic.Queue<UnityEngine.GameObject> val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        val_10 = PlayerArrowToPortalController.一丄丂丘丒且上丝丄;
        if(val_10.Count > 0)
        {
            goto label_4;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = PlayerArrowToPortalController.丙丝且七丂丞丌且丕.世三丞丅丑丌丈丈一();
        if(val_10 == 0)
        {
                val_12 = 0;
            return (bool)val_12;
        }
        
        val_13 = null;
        val_13 = null;
        val_10 = UnityEngine.Object.Instantiate(original:  PlayerArrowToPortalController.丙丝且七丂丞丌且丕.世三丞丅丑丌丈丈一());
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        0.SetActive(value:  false);
        val_10 = 0;
        goto label_19;
        label_18:
        val_10.SetActive(value:  false);
        label_19:
        UnityEngine.Transform val_7 = val_10.transform;
        val_7.parent = 0;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        PlayerArrowToPortalController.一丄丂丘丒且上丝丄.Enqueue(item:  val_10);
        label_4:
        val_12 = 1;
        return (bool)val_12;
    }
    internal static UnityEngine.GameObject 丟七丒万与丒东且丅()
    {
        UnityEngine.Object val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = 0;
        goto label_10;
        label_16:
        if(val_10 != 0)
        {
            goto label_4;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = PlayerArrowToPortalController.一丄丂丘丒且上丝丄.Dequeue();
        if(val_10 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Arrow pointer from pool is null.");
        }
        
        label_10:
        val_12 = null;
        val_12 = null;
        if(PlayerArrowToPortalController.一丄丂丘丒且上丝丄.Count >= 1)
        {
            goto label_16;
        }
        
        label_4:
        if(val_10 != 0)
        {
            goto label_19;
        }
        
        val_13 = null;
        if(PlayerArrowToPortalController.不丟丟业丝丆下丘丁() == false)
        {
            goto label_22;
        }
        
        val_14 = null;
        val_14 = null;
        val_10 = PlayerArrowToPortalController.一丄丂丘丒且上丝丄.Dequeue();
        label_19:
        UnityEngine.Transform val_8 = val_10.transform;
        val_8.parent = 0;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_8.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_10.SetActive(value:  true);
        return (UnityEngine.GameObject)val_10;
        label_22:
        val_10 = 0;
        return (UnityEngine.GameObject)val_10;
    }
    internal static void 丐丗上七且丅丗东世(UnityEngine.GameObject 丌丈丙丞业丄且万业)
    {
        var val_2;
        if(丌丈丙丞业丄且万业 == 0)
        {
                return;
        }
        
        丌丈丙丞业丄且万业.SetActive(value:  false);
        val_2 = null;
        val_2 = null;
        PlayerArrowToPortalController.一丄丂丘丒且上丝丄.Enqueue(item:  丌丈丙丞业丄且万业);
    }
    private static PlayerArrowToPortalController()
    {
        var val_4;
        PlayerArrowToPortalController.一丄丂丘丒且上丝丄 = new System.Collections.Generic.Queue<UnityEngine.GameObject>();
        val_4 = null;
        val_4 = null;
        PlayerArrowToPortalController.丙丝且七丂丞丌且丕 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Object>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Object>(object:  PlayerArrowToPortalController.<>c.<>9, method:  UnityEngine.Object PlayerArrowToPortalController.<>c::丒丂丕丆丐丁业丝上()));
    }
    private UnityEngine.Transform 丄七世丄丁万七七一()
    {
        if(this.ArrowToPortalPoint != null)
        {
                return this.ArrowToPortalPoint.transform;
        }
        
        return this.ArrowToPortalPoint.transform;
    }
    private UnityEngine.Camera 丌且丟丈七丈一丗丞()
    {
        return 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UnityEngine.Camera>(丝三丁东丈丒世丅业:  this.ArrowToPortalPoint);
    }
    private UnityEngine.Camera 业丟万丈不丂上丐下()
    {
        return 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UnityEngine.Camera>(丝三丁东丈丒世丅业:  this.七丒丝丗与东丆丞丂().transform.parent.gameObject);
    }

}
