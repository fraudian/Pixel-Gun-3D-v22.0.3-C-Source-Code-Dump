using UnityEngine;
public class UIMiniMap : UIMiniMapBase
{
    // Fields
    private static UIMiniMap 丄丈丂丅上专万丞丏;
    public UIWidget miniMapWidget;
    private UIPanel 世丒丕丅丈一丆七丂;
    protected int 丙上万东丆七丞万丒;
    public static System.Action<UnityEngine.Vector3> onMapDoubleClick;
    private UnityEngine.Vector3 丏丒丆不丐丙丏丁丝;
    
    // Properties
    public static UIMiniMap 丄丘七三上丕世丞业 { get; }
    private UIPanel 丏丂不丗丈东丅三下 { get; }
    
    // Methods
    public static UIMiniMap get_instance()
    {
        UIMiniMap val_5;
        var val_6;
        val_5 = UIMiniMap.丄丈丂丅上专万丞丏;
        if(val_5 != 0)
        {
                return (UIMiniMap)UIMiniMap.丄丈丂丅上专万丞丏;
        }
        
        val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_5);
        val_6 = 0;
        UIMiniMap.丄丈丂丅上专万丞丏 = ;
        return (UIMiniMap)UIMiniMap.丄丈丂丅上专万丞丏;
    }
    private UIPanel 丐与丄丑不丘丁丄丕()
    {
        UIPanel val_3;
        if(this.世丒丕丅丈一丆七丂 == 0)
        {
                this.世丒丕丅丈一丆七丂 = this.GetComponentInChildren<UIPanel>();
            return val_3;
        }
        
        val_3 = this.世丒丕丅丈一丆七丂;
        return val_3;
    }
    protected override void Awake()
    {
        this.Awake();
        UIMiniMap.丄丈丂丅上专万丞丏 = this;
    }
    protected override void Start()
    {
        if(137121792 == 0)
        {
                return;
        }
        
        this.Start();
        goto typeof(UIMiniMap).__il2cppRuntimeField_3B8;
    }
    public override NJG.UIMapIconBase GetEntry(NJGMapItem 下丅丙一丂丗丅丝七)
    {
        object val_4;
        UnityEngine.Object val_25;
        var val_26;
        var val_27;
        NJG.UIMapIconBase val_28;
        var val_29;
        UnityEngine.Object val_30;
        var val_31;
        var val_32;
        val_25 = this;
        int val_1 = Count;
        if(val_1 < 1)
        {
            goto label_2;
        }
        
        val_26 = 0;
        label_9:
        val_27 = public NJG.UIMapIconBase System.Collections.Generic.List<NJG.UIMapIconBase>::get_Item(int index);
        val_28 = Item[0];
        if(val_28 != null)
        {
                val_27 = 0;
        }
        
        val_28 = 0;
        if((28563616 & 1) != 0)
        {
            goto label_8;
        }
        
        val_26 = val_26 + 1;
        if(val_26 < val_1)
        {
            goto label_9;
        }
        
        label_2:
        if(val_28.Count < 1)
        {
            goto label_11;
        }
        
        if(val_28 == 0)
        {
            goto label_12;
        }
        
        val_29 = val_28.Count;
        goto label_13;
        label_11:
        if(下丅丙一丂丗丅丝七.type != 1)
        {
                val_28 = 0;
            if(UnityEngine.Time.frameCount == this.丙上万东丆七丞万丒)
        {
                return val_28;
        }
        
        }
        
        this.丙上万东丆七丞万丒 = UnityEngine.Time.frameCount;
        UnityEngine.GameObject val_11 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.iconRoot.gameObject);
        val_4 = null;
        string val_12 = "Icon_" + val_4;
        if(val_11 == null)
        {
            goto label_20;
        }
        
        val_11.name = val_12;
        val_30 = val_11;
        goto label_21;
        label_8:
        val_25 = 1;
        if(1 == 下丅丙一丂丗丅丝七.type)
        {
                return val_28;
        }
        
        val_28.Reset();
        return val_28;
        label_12:
        val_29 = 0.Count;
        label_13:
        NJG.UIMapIconBase val_15 = val_28.Item[val_29 - 1];
        mem[24] = 下丅丙一丂丗丅丝七;
        val_28 = 0;
        val_26 = 1;
        0.Reset();
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_31 = 下丅丙一丂丗丅丝七.Count;
        }
        else
        {
                val_31 = 0.Count;
        }
        
        下丅丙一丂丗丅丝七.RemoveAt(index:  val_31 - 1);
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_28.gameObject, 丏业丟一东丂东丘丛:  true);
        label_52:
        this.Add(item:  val_28);
        return val_28;
        label_20:
        0.name = val_12;
        val_30 = 0;
        label_21:
        UIMapIcon val_21 = val_11.AddComponent<UIMapIcon>();
        if(val_21 == 0)
        {
            goto label_36;
        }
        
        UISprite val_23 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UISprite>(丝三丁东丈丒世丅业:  val_11, 丟丕丞丁丝丂上丄上:  2147483647);
        if(val_21 == null)
        {
            goto label_39;
        }
        
        val_32 = val_21;
        val_21.sprite = val_23;
        goto label_40;
        label_36:
        UnityEngine.Debug.LogError(message:  "Expected to find a Game Map Icon on the prefab to work with", context:  this);
        UnityEngine.Object.Destroy(obj:  val_30);
        return val_28;
        label_39:
        val_32 = 80;
        mem[80] = val_23;
        label_40:
        NJGMap val_24 = NJGMap.instance;
        mem[80].atlas = val_24.atlas;
        if(val_21 != null)
        {
                mem2[0] = 下丅丙一丂丗丅丝七;
        }
        else
        {
                mem[24] = 下丅丙一丂丗丅丝七;
        }
        
        val_21.Reset();
        mem[1152921535449481040] = 25;
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_52;
        }
        
        goto label_52;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        if(true != 0)
        {
                if(this == 0)
        {
                return;
        }
        
            NJG.NJGMapBase val_2 = NJG.NJGMapBase.instance;
            this.SetColor(name:  "_MaskColor", value:  new UnityEngine.Color() {r = val_2.cameraBackgroundColor, g = V9.16B, b = V10.16B, a = V11.16B});
            return;
        }
        
        if(137121792 == X21)
        {
                return;
        }
        
        mem[1152921535449650464] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        if(this == 0)
        {
                return;
        }
        
        this.SetTexture(name:  "_Mask", value:  this);
    }
    public override void UpdateAlignment()
    {
        if(this.miniMapWidget != 0)
        {
                this.miniMapWidget.onChange = new UIWidget.丒万丟丆丝丐丟下且(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(UIMiniMap).__il2cppRuntimeField_3C0);
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  (float)this.miniMapWidget.width, y:  (float)this.miniMapWidget.height);
            UnityEngine.Vector3 val_8 = this.miniMapWidget.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UIPanel val_9 = this.丐与丄丑不丘丁丄丕();
        }
        
        this.UpdateAlignment();
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public void OnDoubleClick()
    {
        var val_8;
        float val_9;
        val_8 = null;
        val_8 = null;
        UnityEngine.Vector3 val_2 = this.cachedTransform.position;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_9 = UICamera.currentTouch + 20 + 4;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = UICamera.currentTouch.下业丕七东丌丝下且, y = val_9}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.丏丒丆不丐丙丏丁丝 = val_5;
        mem[1152921535449965144] = val_5.y;
        mem[1152921535449965148] = val_5.z;
        this.丏丒丆不丐丙丏丁丝 = val_5;
        mem[1152921535449965144] = -System.Math.Abs(val_5.y);
        if(UIMiniMap.onMapDoubleClick == null)
        {
                return;
        }
        
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = System.Math.Abs(val_5.x), y = -System.Math.Abs(val_5.y), z = val_2.x});
        UnityEngine.Vector3 val_7 = this.MapToWorld(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UIMiniMap.onMapDoubleClick.Invoke(obj:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
    }
    public void OnHoverOver()
    {
        goto typeof(UIMiniMap).__il2cppRuntimeField_1B8;
    }
    public void OnHoverOut()
    {
        goto typeof(UIMiniMap).__il2cppRuntimeField_1B8;
    }
    protected override NJG.UIMapArrow 不业不不三丛不丂万(UnityEngine.Object 丄三丅七丆丛与与上)
    {
        UnityEngine.Object val_64;
        var val_65;
        var val_66;
        UnityEngine.Object val_67;
        UnityEngine.Object val_68;
        var val_69;
        UnityEngine.Object val_70;
        UISprite val_71;
        var val_72;
        float val_73;
        float val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        UnityEngine.Transform val_79;
        val_64 = 丄三丅七丆丛与与上;
        val_65 = this;
        if(val_64 != null)
        {
                val_64 = 0;
        }
        
        val_66 = 1152921535450284288;
        int val_3 = Count;
        if(val_3 < 1)
        {
            goto label_5;
        }
        
        val_67 = 0;
        label_11:
        val_68 = X23.Item[0].item;
        if(val_68 == val_64)
        {
            goto label_10;
        }
        
        val_67 = val_67 + 1;
        if(val_67 < val_3)
        {
            goto label_11;
        }
        
        label_5:
        if(val_67.Count < 1)
        {
            goto label_13;
        }
        
        if(val_67 == 0)
        {
            goto label_14;
        }
        
        val_69 = val_67.Count;
        goto label_15;
        label_10:
        val_70 = this.Item[0];
        return (NJG.UIMapArrow)val_70;
        label_13:
        UnityEngine.GameObject val_12 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.parent.gameObject);
        string val_13 = "Arrow" + null;
        if(val_12 == null)
        {
            goto label_22;
        }
        
        val_12.name = val_13;
        val_67 = val_12;
        goto label_23;
        label_14:
        val_69 = 0.Count;
        label_15:
        val_70 = val_67.Item[val_69 - 1];
        if(val_70 != null)
        {
                val_70.item = val_64;
        }
        else
        {
                val_70.item = val_64;
        }
        
        val_16.child = val_16.sprite.cachedTransform;
        NJGMap val_18 = NJGMap.instance;
        if(val_18 == null)
        {
            goto label_29;
        }
        
        if(7 == 0)
        {
            goto label_30;
        }
        
        label_36:
        UISpriteData val_19 = val_18.GetSprite(丁丅丈丌丟世丗丗丟:  135970152);
        val_16.sprite.spriteName = val_19.name;
        val_16.sprite.depth = val_64.depth + 1;
        val_16.sprite.width = val_64.size;
        val_71 = val_16.sprite;
        val_72 = val_64;
        int val_23 = val_72.size;
        goto label_35;
        label_29:
        if(7 != 0)
        {
            goto label_36;
        }
        
        label_30:
        UISpriteData val_24 = val_18.GetArrowSprite(丁丅丈丌丟世丗丗丟:  135970152);
        val_16.sprite.spriteName = val_24.name;
        val_16.sprite.depth = val_64.arrowDepth + 1;
        if(val_64.customArrowSize == false)
        {
            goto label_40;
        }
        
        val_16.sprite.width = val_64.sizeArrow;
        val_71 = val_16.sprite;
        val_72 = val_64;
        label_35:
        val_68 = val_72.sizeArrow;
        label_102:
        val_71.height = val_68;
        val_16.sprite.color = new UnityEngine.Color() {r = 2.479598E-39f, g = 1.401298E-45f, b = 7.006492E-45f, a = 0f};
        UnityEngine.Transform val_30 = val_16.sprite.cachedTransform;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
        val_73 = val_31.x;
        val_74 = val_31.z;
        val_30.localPosition = new UnityEngine.Vector3() {x = val_73, y = val_31.y, z = val_74};
        if(val_30 != null)
        {
                val_67 = val_30.Count;
        }
        else
        {
                val_67 = 0.Count;
        }
        
        val_30.RemoveAt(index:  val_67 - 1);
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_70.gameObject, 丏业丟一东丂东丘丛:  true);
        goto label_52;
        label_22:
        0.name = val_13;
        val_67 = 0;
        label_23:
        UnityEngine.Transform val_36 = val_12.transform;
        val_36.parent = UIMiniMap.instance.arrowRoot.transform;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.zero;
        val_36.localPosition = new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z};
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.one;
        val_36.localScale = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
        UISprite val_42 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UISprite>(丝三丁东丈丒世丅业:  val_12, 丟丕丞丁丝丂上丄上:  2147483647);
        NJGMap val_43 = NJGMap.instance;
        val_42.atlas = val_43.atlas;
        if(7 == 0)
        {
            goto label_63;
        }
        
        val_66 = NJGMap.instance;
        UISpriteData val_45 = val_66.GetSprite(丁丅丈丌丟世丗丗丟:  135970152);
        val_42.spriteName = val_45.name;
        val_42.depth = val_64.depth + 1;
        val_42.width = val_64.size;
        val_75 = val_64;
        int val_49 = val_75.size;
        goto label_69;
        label_63:
        val_42.depth = val_64.arrowDepth + 1;
        NJGMap val_52 = NJGMap.instance;
        val_42.atlas = val_52.atlas;
        val_66 = NJGMap.instance;
        UISpriteData val_54 = val_66.GetArrowSprite(丁丅丈丌丟世丗丗丟:  135970152);
        val_42.spriteName = val_54.name;
        if(val_64.customArrowSize == false)
        {
            goto label_76;
        }
        
        val_42.width = val_64.sizeArrow;
        val_75 = val_64;
        label_69:
        label_105:
        val_42.height = val_75.sizeArrow;
        if(val_42 != null)
        {
                val_76 = 2.479598E-39f;
            val_77 = 1.401298E-45f;
            val_78 = 7.006492E-45f;
            val_42.color = new UnityEngine.Color() {r = 2.479598E-39f, g = 1.401298E-45f, b = 7.006492E-45f, a = 0f};
        }
        else
        {
                val_76 = 2.479598E-39f;
            val_77 = 1.401298E-45f;
            val_78 = 7.006492E-45f;
            0.color = new UnityEngine.Color() {r = 2.479598E-39f, g = 1.401298E-45f, b = 7.006492E-45f, a = 0f};
        }
        
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.zero;
        val_42.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z};
        val_70 = val_12.AddComponent<NJG.UIMapArrow>();
        val_79 = val_42.cachedTransform;
        if(val_70 != null)
        {
                val_60.child = val_79;
        }
        else
        {
                val_66 = 32;
            mem[32] = val_79;
            val_79 = mem[32];
        }
        
        UnityEngine.Vector3 val_62 = UnityEngine.Vector3.zero;
        val_73 = val_62.x;
        val_74 = val_62.z;
        val_79.localEulerAngles = new UnityEngine.Vector3() {x = val_73, y = val_62.y, z = val_74};
        if(val_70 != null)
        {
                val_70.item = val_64;
        }
        else
        {
                val_70.item = val_64;
        }
        
        val_60.sprite = val_42;
        val_68 = 1152921504848912384;
        if(val_70 == 0)
        {
                UnityEngine.Debug.LogError(message:  "Expected to find a UIMapArrowBase on the prefab to work with");
            UnityEngine.Object.Destroy(obj:  val_67);
            return (NJG.UIMapArrow)val_70;
        }
        
        mem[1152921535450503016] = (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 1);
        val_70.item = val_64;
        label_52:
        this.Add(item:  val_70);
        return (NJG.UIMapArrow)val_70;
        label_40:
        val_16.sprite.width = (int)V0.16B;
        if(val_16.sprite != null)
        {
            goto label_102;
        }
        
        goto label_102;
        label_76:
        val_42.width = (int)val_41.x;
        if(val_42 != null)
        {
            goto label_105;
        }
        
        goto label_105;
    }
    public UIMiniMap()
    {
    
    }

}
