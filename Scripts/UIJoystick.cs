using UnityEngine;
public class UIJoystick : MonoBehaviour
{
    // Fields
    internal const int 丈且七丟一丑丗万丌 = -1;
    private System.Nullable<float> 丞丕一万世万丑丏世;
    private UIWidget 七丈东丒世丘丒上且;
    private int 且丛一丞且万下下丝;
    private UnityEngine.Vector2 丄丟丈丆下丘且与丂;
    private UnityEngine.Vector2 上丛丗丙丈专丏丆丄;
    private UnityEngine.Vector2 东东丘三七丞丐世丅;
    private bool 丕丆丑丑丛三上丟业;
    private UnityEngine.Vector3 丕万丈东与丈与三丆;
    private bool 丌丏下丄不丟一七丆;
    public bool IsInitPos;
    public bool isLock;
    private bool 东三丌丛专丅丛丞东;
    private bool 世丁丕丈丂丐一七与;
    public UnityEngine.GameObject lockSprite;
    private UnityEngine.Rect <丝丒丘丐丄世七丌丝>k__BackingField;
    public float radius;
    private StateHolder 丑丒且上业一与丛丝;
    private UnityEngine.Rect 丞丈丄丏丅丆丘丙丑;
    public UnityEngine.Transform target;
    private float 丁万丁七丟丄不下丁;
    private float 丛丒丝不丞世专与丕;
    private float 丒丂万丈丐七下与丗;
    private TouchPadInJoystick 专与丒丘万不东三丟;
    private UnityEngine.Camera 丆丗与丌丞丏丙丗丂;
    public UnityEngine.Vector2 value;
    private UnityEngine.GameObject AutorunButtonSprite;
    private UITexture AutorunButtonIndication;
    public UnityEngine.Color autorunInactiveColor;
    public UnityEngine.Color autorunActiveColor;
    private float 丙不丁丝且且丄丆不;
    private UnityEngine.Vector2 丛丂世丁万丏一丙且;
    private bool 丄丆万不丏世丆丛丕;
    private bool 丁三七业丄丐丁丆丙;
    private float 丕丞丞丟丗丝丅丗丈;
    private float 丟不三丁丆丙丐三世;
    private float 丙不丂丁丕世丙世丐;
    private readonly float 丑丕丌不上丂丂丕一;
    internal float 丅七上丂七丆一丞丂;
    private bool 七丞不与丕丈万丞下;
    
    // Properties
    internal bool 丏丑不东万丟丙丞丌 { get; }
    internal UnityEngine.Rect 丄世丙丞七丒丅丑丒 { get; set; }
    public float 一丘丏丁万丂业丄丞 { get; set; }
    public float 万万七丝丝万丕万丙 { get; }
    public int 丙丘且丄与丆丒不丑 { get; }
    public bool 下丂且丏与丆丏不专 { get; }
    public bool 丂丕丏丒且上不一且 { get; }
    private bool 专上不丌丂丅丛与下 { get; }
    public bool 万丑且丏丅丞丕丕丂 { get; }
    private bool 丏一丅丕丞丒东丟丗 { get; }
    
    // Methods
    internal bool 一丁与与丆丑丈丘丌()
    {
        return (bool)this.世丁丕丈丂丐一七与;
    }
    internal UnityEngine.Rect 丝丕且丗专世丈丘丂()
    {
        return new UnityEngine.Rect() {m_XMin = this.<丝丒丘丐丄世七丌丝>k__BackingField};
    }
    private void 丗丐与专丟丝下上一(UnityEngine.Rect 丙业与丙丗丝不丈东)
    {
        this.<丝丒丘丐丄世七丌丝>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921540296327196] = 丙业与丙丗丝不丈东.m_YMin;
        mem[1152921540296327200] = 丙业与丙丗丝不丈东.m_Width;
        mem[1152921540296327204] = 丙业与丙丗丝不丈东.m_Height;
    }
    public float get_ActualRadius()
    {
        if((this.丞丕一万世万丑丏世 & 1) == 0)
        {
                return (float)val_5 + 120;
        }
        
        this = ???;
        return (float)val_5 + 120;
    }
    public void set_ActualRadius(float 丙业与丙丗丝不丈东)
    {
        this.丞丕一万世万丑丏世 = 0;
    }
    public float get_ActualRadiusSq()
    {
        float val_1 = this.ActualRadius;
        val_1 = val_1 * val_1;
        return (float)val_1;
    }
    public int get_TouchFingerID()
    {
        return (int)this.且丛一丞且万下下丝;
    }
    public bool get_isAdaptivePos()
    {
        var val_4;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_6;
        }
        
        }
        
        var val_3 = (this.丕丆丑丑丛三上丟业 == false) ? 1 : 0;
        return (bool)val_4;
        label_6:
        val_4 = 0;
        return (bool)val_4;
    }
    public bool get_isDeltaMoving()
    {
        return false;
    }
    private bool 七丈丂世丑丐丕一丁()
    {
        var val_2;
        if(EmojiController.丘丆专丕丏且不丏丑 != null)
        {
                if((EmojiController.丘丆专丕丏且不丏丑 + 64.三丗丟下丘世三上三()) != false)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    private bool 丗且丂丒丙丁丞丆丛(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        if(EmojiController.丘丆专丕丏且不丏丑 != null)
        {
                val_4 = 1152921505173245952;
            if(this.七丈丂世丑丐丕一丁() != false)
        {
                if(EmojiController.丘丆专丕丏且不丏丑 != null)
        {
                val_5 = null;
            val_5 = null;
            var val_2 = (((EmojiController.__il2cppRuntimeField_typeHierarchy + (BattleEmojiController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_5) ? EmojiController.丘丆专丕丏且不丏丑 : 0;
        }
        else
        {
                val_6 = 0;
        }
        
            if((val_6.且丏丈丈丆丘丈丝丆(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.x, y = 丟下丙丆不东一与丅.y})) != false)
        {
                val_7 = 1;
            return (bool)val_7;
        }
        
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private bool 丄丕丂丌丕丕丝丑东(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        InGameGUI.丙丞专丌丁丞与不丐.丒丅下丌丞丁丕丝丙
    }
    private bool 丞世东丈丄丐丈丗丗(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return false;
        }
        
        if(InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class == 0)
        {
                return false;
        }
        
        if(InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丐丗与丁七下丕世丈() == false)
        {
                return false;
        }
        
        return InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.下下世丙丟丅丐丞丒(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.x, y = 丟下丙丆不东一与丅.y});
    }
    public bool get_isDoubleTapLock()
    {
        return false;
    }
    private bool 与丌丛不下七丑不丁()
    {
        var val_4;
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_6;
        }
        
        }
        
        var val_3 = (this.丕丆丑丑丛三上丟业 == false) ? 1 : 0;
        return (bool)val_4;
        label_6:
        val_4 = 0;
        return (bool)val_4;
    }
    internal void 丘丟七丕丏丑丆三一(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        float val_4 = 0.5f;
        val_4 = val_3.y * val_4;
        this.丙不丂丁丕世丙世丐 = val_3.y;
        this.丟不三丁丆丙丐三世 = val_4;
    }
    private void Awake()
    {
        this.七丈东丒世丘丒上且 = this.GetComponent<UIWidget>();
        this.专与丒丘万不东三丟 = this.GetComponentInParent<TouchPadInJoystick>();
        this.丆丗与丌丞丏丙丗丂 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>();
        this.丑丒且上业一与丛丝 = this.GetComponent<StateHolder>();
        if(this.AutorunButtonSprite == null)
        {
                return;
        }
        
        this.AutorunButtonSprite.SetActive(value:  false);
    }
    private void Start()
    {
        this.七丛丄业业与上丁丂();
        PauseNGUIController.丒一世七业丙东丒丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UIJoystick::七丛丄业业与上丁丂()));
        this.七万丞丛七丕上下七();
        this.Reset();
    }
    private void OnDestroy()
    {
        PauseNGUIController.丈一丞丘世丌丄上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UIJoystick::七丛丄业业与上丁丂()));
    }
    private void Update()
    {
        this.七万丞丛七丕上下七();
        this.七丅丁丄丘丆世丁丐();
        this.丑丒且上业一与丛丝.state = (this.且丛一丞且万下下丝 != 1) ? 1 : 0;
    }
    private UnityEngine.Vector2 丟丂三万且丅丈丁下()
    {
        var val_12;
        WeaponManager val_13;
        var val_14;
        var val_15;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  ((UnityEngine.Input.GetKey(name:  "d")) != true) ? 1f : ((float)(int)((UnityEngine.Input.GetKey(name:  "a")) >> 0) & 1), y:  ((UnityEngine.Input.GetKey(name:  "s")) != true) ? -1f : ((float)UnityEngine.Input.GetKey(name:  "w")));
        val_12 = null;
        val_12 = null;
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_13 != 0)
        {
                val_14 = null;
            val_14 = null;
            val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_13 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_13 != 0)
        {
                val_15 = null;
            val_15 = null;
            val_13 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_13 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            return new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        }
        
        }
        
        UnityEngine.Vector2 val_11 = val_8.x.normalized;
        return new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
    }
    private void 七丅丁丄丘丆世丁丐()
    {
        if(this.世丁丕丈丂丐一七与 != false)
        {
                this.丄与丐丑丐丄三丁一();
            return;
        }
        
        this.Reset();
    }
    public void CalculateMoveRect()
    {
        var val_24;
        float val_25;
        var val_26;
        float val_27;
        UISprite val_28;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_4;
        }
        
        val_24 = width;
        val_25 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_26 = width;
        val_27 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_28 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 488];
        val_28 = InGameGUI.丙丞专丌丁丞与不丐.fonSmallDater;
        if(null != 0)
        {
            goto label_19;
        }
        
        goto label_12;
        label_4:
        val_24 = width;
        val_25 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_26 = width;
        val_27 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_28 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 480];
        val_28 = InGameGUI.丙丞专丌丁丞与不丐.fonSmall;
        if(null != 0)
        {
            goto label_19;
        }
        
        label_12:
        label_19:
        float val_24 = (float)UnityEngine.Screen.width;
        float val_14 = (float)val_24 * 0.5f;
        val_24 = val_24 * 0.5f;
        float val_15 = val_27 * (float)val_26;
        val_14 = val_24 - (val_14 * val_25);
        float val_17 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (float)height;
        float val_25 = (float)UnityEngine.Screen.width;
        this.丞丈丄丏丅丆丘丙丑 = 0;
        mem[1152921540298684988] = 0;
        mem[1152921540298684996] = 0;
        val_25 = val_25 * 0.5f;
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                float val_20 = (float)UnityEngine.Screen.height * 0.75f;
        }
        else
        {
                float val_26 = (float)UnityEngine.Screen.width;
            val_26 = val_26 - val_25;
            float val_23 = (float)UnityEngine.Screen.height * 0.75f;
        }
        
        this.<丝丒丘丐丄世七丌丝>k__BackingField = 0;
        mem[1152921540298684956] = 0;
        mem[1152921540298684964] = 0;
    }
    private void OnEnable()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void UIJoystick::下东丗七丘业一业丅(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丒丙丐一丈一三一丆)));
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void UIJoystick::下东丗七丘业一业丅(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丒丙丐一丈一三一丆)));
    }
    private void 下东丗七丘业一业丅(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丒丙丐一丈一三一丆)
    {
        if(丒丙丐一丈一三一丆 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丒丙丐一丈一三一丆);
        if(七丐丅专且专七三丆 == 1)
        {
            goto label_3;
        }
        
        if(七丐丅专且专七三丆 != 34)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.value = val_1;
        mem[1152921540299046644] = val_1.y;
        goto label_7;
        label_3:
        this.value = new UnityEngine.Vector2();
        mem[1152921540299046644] = ???;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = 3.782474E-38f, y = V8.16B}, rhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) == false)
        {
            goto label_10;
        }
        
        label_7:
        this.七丞不与丕丈万丞下 = false;
        return;
        label_10:
        this.七丞不与丕丈万丞下 = true;
    }
    private void 丄与丐丑丐丄三丁一()
    {
        var val_90;
        LeftFireTouchButton val_91;
        InGameGUIPart_Freeplay val_92;
        var val_93;
        float val_94;
        float val_95;
        float val_96;
        float val_97;
        var val_101;
        float val_102;
        float val_103;
        float val_104;
        UITexture val_105;
        UnityEngine.Color val_106;
        var val_107;
        var val_108;
        var val_109;
        val_90 = this;
        if(this.七丞不与丕丈万丞下 == true)
        {
                return;
        }
        
        int val_1 = UnityEngine.Input.touchCount;
        val_91 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                bool val_4 = InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                bool val_7 = WindowEnabled;
        }
        
        val_92 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_92 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(val_92 != 0)
        {
                val_92 = 丅与丌专丟一丝业三();
            bool val_11 = val_92.activeInHierarchy;
        }
        
        if((val_1 < 1) || (0 != 0))
        {
            goto label_25;
        }
        
        if(this.且丛一丞且万下下丝 != 1)
        {
            goto label_52;
        }
        
        val_92 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_92 == 0)
        {
            goto label_52;
        }
        
        val_92 = UICamera.selectedObject;
        if(val_92 == 0)
        {
            goto label_52;
        }
        
        val_92 = UICamera.selectedObject;
        UnityEngine.GameObject val_16 = gameObject;
        if((val_92 & 1) != 0)
        {
            goto label_52;
        }
        
        val_92 = UICamera.selectedObject;
        UnityEngine.GameObject val_18 = gameObject;
        if(((val_92 & 1) != 0) || ((val_1 < 1) || ((System.Linq.Enumerable.Contains<UnityEngine.GameObject>(source:  WeaponTogglesController.__il2cppRuntimeField_byval_arg, value:  UICamera.selectedObject)) == true)))
        {
            goto label_52;
        }
        
        val_93 = 1152921505286238208;
        val_94 = 0.5f;
        goto label_135;
        label_25:
        this.Reset();
        goto label_136;
        label_134:
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        UnityEngine.Vector3 val_22 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = this.target.position;
        val_95 = val_22.x;
        val_96 = val_22.y;
        val_97 = val_22.z;
        UnityEngine.Vector3 val_24 = this.target.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = val_97});
        if(((X27 + 184 + 544 + 72) != 0) && ((X27 + 184 + 544 + 72 + 1405) != 0))
        {
                var val_90 = X27 + 184 + 544 + 72 + 1400;
            val_90 = val_90 ^ 1;
            var val_26 = val_90 & 255;
        }
        
        val_91 = this.专与丒丘万不东三丟.fireTouch;
        if((0 == 0) || ((val_91 & 1) == 0))
        {
            goto label_79;
        }
        
        val_95 = this.ActualRadius * this.ActualRadius;
        if(val_24.x >= 0)
        {
            goto label_133;
        }
        
        label_79:
        if((((((1332818984 & 1) == 0) || ((0 & 1) != 0)) || ((丗且丂丒丙丁丞丆丛(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = this.<丝丒丘丐丄世七丌丝>k__BackingField, y = val_24.y})) == true)) || ((丞世东丈丄丐丈丗丗(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = this.<丝丒丘丐丄世七丌丝>k__BackingField, y = val_24.y})) == true)) || ((丄丕丂丌丕丕丝丑东(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = this.<丝丒丘丐丄世七丌丝>k__BackingField, y = val_24.y})) == true))
        {
            goto label_133;
        }
        
        if((this.专与丒丘万不东三丟.fireTouch & 1) == 0)
        {
            goto label_88;
        }
        
        val_91 = this.专与丒丘万不东三丟.fireTouch + 24;
        if((val_91 & 1) != 0)
        {
            goto label_133;
        }
        
        label_88:
        if((this.专与丒丘万不东三丟.vehicleSpawnTouch & 1) == 0)
        {
            goto label_94;
        }
        
        val_91 = this.专与丒丘万不东三丟.vehicleSpawnTouch + 24;
        if((val_91 & 1) != 0)
        {
            goto label_133;
        }
        
        label_94:
        val_91 = mem[X28 + 184 + 8];
        val_91 = X28 + 184 + 8;
        val_95 = this.<丝丒丘丐丄世七丌丝>k__BackingField;
        val_96 = val_24.y;
        if((val_91.丛丁丏丌七不丘上丌(上下丁丕与上业丅丄:  new UnityEngine.Vector2() {x = val_95, y = val_96})) == true)
        {
            goto label_133;
        }
        
        this.且丛一丞且万下下丝 = GetHashCode();
        if(this.与丌丛不下七丑不丁() != false)
        {
                this.isLock = false;
            this.丌丏下丄不丟一七丆 = this.isLock;
            if(this.lockSprite != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.lockSprite, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        if(this.isAdaptivePos != false)
        {
                if(this.IsInitPos != true)
        {
                UnityEngine.Vector3 val_37 = this.transform.localPosition;
            this.丕万丈东与丈与三丆 = val_37;
            mem[1152921540299416668] = val_37.y;
            mem[1152921540299416672] = val_37.z;
        }
        
            this.IsInitPos = true;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
            UnityEngine.Vector3 val_40 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            this.transform.position = new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z};
        }
        
        UnityEngine.Vector3 val_41 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
        UnityEngine.Vector3 val_42 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
        this.target.position = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
        this.上丛丗丙丈专丏丆丄 = val_42.x;
        mem[1152921540299416648] = val_42.y;
        this.丄丆万不丏世丆丛丕 = true;
        this.丙不丁丝且且丄丆不 = 0f;
        UnityEngine.Vector3 val_44 = this.target.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
        this.丛丂世丁万丏一丙且 = val_45;
        mem[1152921540299416848] = val_45.y;
        int val_46 = this.丆丗与丌丞丏丙丗丂.pixelHeight;
        UnityEngine.Vector3 val_48 = this.transform.position;
        UnityEngine.Vector3 val_50 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_52 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
        float val_91 = this.丕丞丞丟丗丝丅丗丈;
        val_52.y = val_52.y + S11;
        float val_53 = val_52.y - val_91;
        if((val_45.y + this.丙不丂丁丕世丙世丐) <= val_53)
        {
            goto label_125;
        }
        
        float val_92 = this.丅七上丂七丆一丞丂;
        val_91 = val_53 - val_91;
        val_92 = val_92 * S12;
        if(val_91 >= 0)
        {
            goto label_126;
        }
        
        this.丄丆万不丏世丆丛丕 = false;
        goto label_127;
        label_125:
        float val_93 = this.丙不丂丁丕世丙世丐;
        val_93 = val_93 * S12;
        goto label_128;
        label_126:
        label_128:
        this.丟不三丁丆丙丐三世 = val_53 * S12;
        label_127:
        val_91 = this.AutorunButtonSprite.transform;
        UnityEngine.Vector3 val_57 = this.AutorunButtonSprite.transform.localPosition;
        val_95 = 0f;
        val_96 = 0f;
        val_97 = 0f;
        val_91.localPosition = new UnityEngine.Vector3() {x = val_95, y = val_96, z = val_97};
        goto label_133;
        label_135:
        UnityEngine.Touch val_58 = UnityEngine.Input.GetTouch(index:  0);
        if(专三三与三且一且一() == 0)
        {
            goto label_134;
        }
        
        label_133:
        val_92 = 1;
        if(val_1 != val_92)
        {
            goto label_135;
        }
        
        label_52:
        int val_60 = UnityEngine.Input.touchCount;
        if(val_60 < 1)
        {
            goto label_136;
        }
        
        val_91 = 1152921504838316032;
        val_93 = 1152921504622448640;
        val_101 = 0;
        label_165:
        UnityEngine.Touch val_61 = UnityEngine.Input.GetTouch(index:  0);
        if(GetHashCode() != this.且丛一丞且万下下丝)
        {
            goto label_164;
        }
        
        UnityEngine.Vector3 val_63 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        UnityEngine.Vector3 val_64 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
        val_102 = val_64.y;
        UnityEngine.Vector3 val_65 = this.target.position;
        val_103 = val_64.x;
        val_104 = val_102;
        if(((this.与丌丛不下七丑不丁() != false) && (this.丄丆万不丏世丆丛丕 != false)) && (this.丁三七业丄丐丁丆丙 != false))
        {
                UnityEngine.Vector3 val_68 = this.target.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_64.x, y = val_102, z = val_64.z});
            val_102 = val_68.y;
            UnityEngine.Vector3 val_70 = this.AutorunButtonSprite.transform.localPosition;
            val_94 = val_70.y;
            val_104 = val_102;
            UnityEngine.Vector3 val_71 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_68.x, y = val_104, z = val_68.z}, b:  new UnityEngine.Vector3() {x = val_70.x, y = val_94, z = val_70.z});
            val_103 = val_71.y + this.丕丞丞丟丗丝丅丗丈;
            if(val_103 >= 0f)
        {
                val_101 = 1;
        }
        
        }
        
        if(专三三与三且一且一() == 3)
        {
            goto label_152;
        }
        
        this.丄丟丈丆下丘且与丂 = val_103;
        mem[1152921540299416640] = val_71.y;
        if(this.丄丆万不丏世丆丛丕 != false)
        {
                UnityEngine.Vector3 val_74 = this.target.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_64.x, y = val_102, z = val_64.z});
            UnityEngine.Vector2 val_75 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector2 val_76 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_75.x, y = val_75.y}, b:  new UnityEngine.Vector2() {x = this.丛丂世丁万丏一丙且, y = val_70.x});
            UnityEngine.Vector2 val_77 = val_76.x.normalized;
            UnityEngine.Vector2 val_78 = UnityEngine.Vector2.up;
            val_103 = this.丑丕丌不上丂丂丕一;
            val_104 = System.Math.Abs(UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_77.x, y = val_77.y}, to:  new UnityEngine.Vector2() {x = val_78.x, y = val_78.y}));
            if(val_104 <= val_103)
        {
                this.丙不丁丝且且丄丆不 = val_103;
        }
        
        }
        
        this.丌丟丛世丆下专丑丐();
        this.上丛丗丙丈专丏丆丄 = val_103;
        mem[1152921540299416648] = val_104;
        if((this.专与丒丘万不东三丟.fireTouch.isPressed != false) && (this.isLock != true))
        {
                this.Reset();
        }
        
        label_164:
        val_92 = 0 + 1;
        if(val_92 < val_60)
        {
            goto label_165;
        }
        
        val_105 = this.AutorunButtonIndication;
        if((val_101 & 1) == 0)
        {
            goto label_166;
        }
        
        val_106 = this.autorunActiveColor;
        val_107 = 1152921540299416828;
        val_108 = 1152921540299416832;
        val_109 = 1152921540299416836;
        goto label_167;
        label_136:
        val_105 = this.AutorunButtonIndication;
        label_166:
        val_106 = this.autorunInactiveColor;
        val_107 = 1152921540299416812;
        val_108 = 1152921540299416816;
        val_109 = 1152921540299416820;
        label_167:
        val_105.color = new UnityEngine.Color() {r = this.autorunInactiveColor.r, g = 2.695622E-13f, b = 2.695622E-13f, a = 2.695622E-13f};
        return;
        label_152:
        if(((this.与丌丛不下七丑不丁() != false) && (this.丄丆万不丏世丆丛丕 != false)) && (this.丁三七业丄丐丁丆丙 != false))
        {
                UnityEngine.Vector3 val_83 = this.target.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_64.x, y = val_102, z = val_64.z});
            UnityEngine.Vector3 val_85 = this.AutorunButtonSprite.transform.localPosition;
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_83.x, y = val_83.y, z = val_83.z}, b:  new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z});
            float val_94 = this.丕丞丞丟丗丝丅丗丈;
            val_94 = val_86.y + val_94;
            if(val_94 >= 0f)
        {
                this.isLock = true;
            this.丛丒丝不丞世专与丕 = -1f;
            UnityEngine.Vector2 val_87 = new UnityEngine.Vector2(x:  0f, y:  1f);
            this.value = val_87.x;
            mem[1152921540299416788] = val_87.y;
            float val_88 = this.ActualRadius;
            this.target.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.lockSprite != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.lockSprite, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        }
        
        this.Reset();
    }
    public void SetJoystickActive(bool 丈下上丅与丒丁丆下)
    {
        bool val_1 = 丈下上丅与丒丁丆下;
        this.enabled = val_1;
        if(val_1 != false)
        {
                return;
        }
        
        this.Reset();
    }
    private void 七万丞丛七丕上下七()
    {
        var val_23;
        var val_24;
        var val_25;
        bool val_26;
        var val_27;
        UnityEngine.Object val_28;
        var val_29;
        bool val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        bool val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        UnityEngine.GameObject val_40;
        var val_41;
        bool val_42;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == true)
        {
            goto label_2;
        }
        
        val_23 = null;
        val_23 = null;
        if(TrainingController.七专业一丂万丛丝上 < 2)
        {
            goto label_5;
        }
        
        label_2:
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_18;
        }
        
        val_25 = null;
        val_25 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_668 == 0)
        {
            goto label_18;
        }
        
        label_5:
        val_26 = 0;
        if(this != null)
        {
            goto label_23;
        }
        
        goto label_20;
        label_18:
        val_26 = (~GameConnect.丟丆丏上丌一丝丟业()) & 1;
        if(this != null)
        {
            goto label_23;
        }
        
        label_20:
        label_23:
        this.世丁丕丈丂丐一七与 = val_26;
        val_27 = null;
        val_27 = null;
        val_28 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_28)
        {
                val_29 = null;
            val_29 = null;
            val_30 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266];
            val_30 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 266;
        }
        else
        {
                val_30 = false;
        }
        
        this.丕丆丑丑丛三上丟业 = val_30;
        if(val_30 != 0)
        {
                val_31 = null;
            val_31 = null;
            val_28 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_30 = this.丕丆丑丑丛三上丟业;
        }
        else
        {
                val_32 = 0;
        }
        
        val_30 = val_32 & val_30;
        if(val_30 != 0)
        {
                val_33 = null;
            val_33 = null;
            if(丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不() == false)
        {
            goto label_132;
        }
        
            val_34 = null;
            val_34 = null;
            var val_8 = ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) == 2) ? 1 : 0;
        }
        else
        {
                val_35 = 0;
        }
        
        label_132:
        val_36 = null;
        val_36 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_37 = null;
            val_37 = null;
        }
        
        if(val_35 == 0)
        {
                if(this.丕丆丑丑丛三上丟业 == true)
        {
            goto label_103;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        val_39 = null;
        val_39 = null;
        val_35 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened == true)
        {
            goto label_103;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                if(丅与丌专丟一丝业三().activeInHierarchy == true)
        {
            goto label_103;
        }
        
        }
        
        if((InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0) || (WindowEnabled == false))
        {
            goto label_111;
        }
        
        label_103:
        this.世丁丕丈丂丐一七与 = false;
        label_111:
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_117;
        }
        
        }
        
        val_40 = this.专与丒丘万不东三丟.joystickSprite;
        val_41 = 0;
        goto label_121;
        label_117:
        val_35 = this.世丁丕丈丂丐一七与;
        val_40 = this.专与丒丘万不东三丟.joystickSprite;
        label_121:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_40, 丏业丟一东丂东丘丛:  (val_35 == true) ? 1 : 0);
        if(this.与丌丛不下七丑不丁() == false)
        {
            goto label_125;
        }
        
        if(this.丙不丁丝且且丄丆不 <= this.丟不三丁丆丙丐三世)
        {
            goto label_126;
        }
        
        val_42 = this.丄丆万不丏世丆丛丕;
        goto label_127;
        label_125:
        if(this.丁三七业丄丐丁丆丙 == false)
        {
            goto label_128;
        }
        
        val_42 = 0;
        this.丁三七业丄丐丁丆丙 = false;
        goto label_130;
        label_126:
        val_42 = false;
        label_127:
        this.丁三七业丄丐丁丆丙 = val_42;
        goto label_130;
        label_128:
        val_42 = 0;
        label_130:
        this.AutorunButtonSprite.SetActive(value:  (val_42 != 0) ? 1 : 0);
    }
    private void 七丛丄业业与上丁丂()
    {
        UIAnchor val_3 = this.transform.parent.GetComponent<UIAnchor>();
        val_3.side = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 0 : 6;
        this.CalculateMoveRect();
        this.Reset();
    }
    internal void 且丑一丄下三东七专()
    {
        if(this.与丌丛不下七丑不丁() == false)
        {
                return;
        }
        
        if(this.isLock == false)
        {
                return;
        }
        
        this.isLock = false;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.value = val_2;
        mem[1152921540300208948] = val_2.y;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.target.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丄丟丈丆下丘且与丂 = val_4;
        mem[1152921540300208800] = val_4.y;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.上丛丗丙丈专丏丆丄 = val_6;
        mem[1152921540300208808] = val_6.y;
        this.丄丆万不丏世丆丛丕 = false;
        this.丁三七业丄丐丁丆丙 = false;
        if(this.lockSprite == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.lockSprite, 丏业丟一东丂东丘丛:  false);
    }
    public void Reset()
    {
        float val_8;
        this.且丛一丞且万下下丝 = 0;
        if(this.isLock != true)
        {
                UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.value = val_1;
            mem[1152921540300341428] = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_8 = val_2.x;
            this.target.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.丄丟丈丆下丘且与丂 = val_3;
            mem[1152921540300341280] = val_3.y;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.上丛丗丙丈专丏丆丄 = val_5;
            mem[1152921540300341288] = val_5.y;
        }
        
        if((this.isAdaptivePos != false) && (this.IsInitPos != false))
        {
                val_8 = this.丕万丈东与丈与三丆;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_2.y, z = val_2.z};
        }
        
        if(this.丄丆万不丏世丆丛丕 == false)
        {
                return;
        }
        
        this.丄丆万不丏世丆丛丕 = false;
    }
    private void 丌丟丛世丆下专丑丐()
    {
        float val_17;
        float val_18;
        float val_19;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.丄丟丈丆下丘且与丂, y = V8.16B});
        UnityEngine.Vector3 val_2 = this.丆丗与丌丞丏丙丗丂.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this.target.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_3 = this.target.localPosition;
        UnityEngine.Vector3 val_4 = this.target.localPosition;
        val_17 = 0f;
        val_18 = 0f;
        val_19 = 0f;
        this.target.localPosition = new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19};
        UnityEngine.Vector3 val_5 = this.target.localPosition;
        if(val_5.x > this.ActualRadius)
        {
                UnityEngine.Vector3 val_7 = this.target.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, maxLength:  this.ActualRadius);
            val_17 = val_9.x;
            val_18 = val_9.y;
            val_19 = val_9.z;
            this.target.localPosition = new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19};
        }
        
        UnityEngine.Vector3 val_10 = this.target.localPosition;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        this.value = val_11;
        mem[1152921540300490292] = val_11.y;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, d:  this.ActualRadius);
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, d:  UnityEngine.Mathf.InverseLerp(a:  this.ActualRadius, b:  2f, value:  1f));
        this.value = val_16;
        mem[1152921540300490292] = val_16.y;
    }
    public UIJoystick()
    {
        var val_4;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this.东东丘三七丞丐世丅 = val_2;
        mem[1152921540300630832] = val_2.y;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.丕万丈东与丈与三丆 = val_3;
        mem[1152921540300630844] = val_3.y;
        mem[1152921540300630848] = val_3.z;
        this.丁万丁七丟丄不下丁 = 0.35f;
        this.丛丒丝不丞世专与丕 = -1f;
        this.丒丂万丈丐七下与丗 = 0.05f;
        val_4 = null;
        val_4 = null;
        this.丟不三丁丆丙丐三世 = 20f;
        this.丑丕丌不上丂丂丕一 = 89f;
        float val_4 = (float)AutorunButtonAdjust.专丛三且丛上丛业丈;
        val_4 = val_4 * 1.1f;
        this.丕丞丞丟丗丝丅丗丈 = val_4;
    }

}
