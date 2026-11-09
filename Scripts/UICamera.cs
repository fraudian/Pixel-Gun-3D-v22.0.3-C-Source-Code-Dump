using UnityEngine;
public class UICamera : MonoBehaviour
{
    // Fields
    internal static System.Collections.Generic.HashSet<UnityEngine.GameObject> 丅丒世丆业丑丏丁丈;
    private bool 世专七一丝三丑丙一;
    public static 丒丞丕丕七丁丗丟丛<UICamera> list;
    public static UICamera.丘丒三丐丌丑丑丘世 GetKeyDown;
    public static UICamera.丘丒三丐丌丑丑丘世 GetKeyUp;
    public static UICamera.丘丒三丐丌丑丑丘世 GetKey;
    public static UICamera.丅丝丒丆丌专丗丂业 GetAxis;
    public static UICamera.丏丝丗业三丌丏与世 GetAnyKeyDown;
    public static UICamera.万一丆与下丈丐丌丙 onScreenResize;
    public UICamera.丗丄丐丈丛丛三丗丏 eventType;
    public bool eventsGoToColliders;
    public UnityEngine.LayerMask forcedEventReceiverMask;
    public UnityEngine.LayerMask eventReceiverMask;
    public bool debug;
    public bool useMouse;
    public bool useTouch;
    public bool allowMultiTouch;
    public bool useKeyboard;
    public bool useController;
    public bool stickyTooltip;
    private float 丗丙业丁丗丏丛一丅;
    public bool longPressTooltip;
    public float mouseDragThreshold;
    public float mouseClickThreshold;
    public float touchDragThreshold;
    public float touchClickThreshold;
    public float rangeDistance;
    public string horizontalAxisName;
    public string verticalAxisName;
    public string horizontalPanAxisName;
    public string verticalPanAxisName;
    public string scrollAxisName;
    public bool commandClick;
    public UnityEngine.KeyCode submitKey0;
    public UnityEngine.KeyCode submitKey1;
    public UnityEngine.KeyCode cancelKey0;
    public UnityEngine.KeyCode cancelKey1;
    public bool autoHideCursor;
    public static UICamera.丘丛专一上丞丑七丞 onCustomInput;
    public static bool showTooltips;
    private static bool 东东上丈丗丑丄东丕;
    private static UnityEngine.Vector2 专丟丆丛丁七下三丝;
    public static UnityEngine.Vector3 lastWorldPosition;
    public static UnityEngine.RaycastHit lastHit;
    public static int lastHitFrame;
    public static UICamera current;
    public static UnityEngine.Camera currentCamera;
    public static UICamera.丏丄丈丗丌丘不不一 onSchemeChange;
    private static UICamera.三下七东不东丈丈丞 丆丝丌丙丂丛与丆七;
    public static int currentTouchID;
    private static UnityEngine.KeyCode 东七丅且且下丁丛丁;
    public static UICamera.丞上且下专丞东专世 currentTouch;
    private static bool 三丑丞丈与丐且上丅;
    private static UnityEngine.GameObject 七业丈丐上丁万专上;
    public static UnityEngine.GameObject fallThrough;
    public static UICamera.丅三丝丙丝万上丝业 onClick;
    public static UICamera.丅三丝丙丝万上丝业 onDoubleClick;
    public static UICamera.下丈业丑世丟丘丅下 onHover;
    public static UICamera.下丈业丑世丟丘丅下 onPress;
    public static UICamera.下丈业丑世丟丘丅下 onSelect;
    public static UICamera.丗万七丒东与与专七 onScroll;
    public static UICamera.一丑下丄丝不丆三三 onDrag;
    public static UICamera.一丑下丄丝不丆三三 onMovedThumb;
    public static UICamera.丅三丝丙丝万上丝业 onDragStart;
    public static UICamera.丁丏丒不丛丝丞丒业 onDragOver;
    public static UICamera.丁丏丒不丛丝丞丒业 onDragOut;
    public static UICamera.丅三丝丙丝万上丝业 onDragEnd;
    public static UICamera.丁丏丒不丛丝丞丒业 onDrop;
    public static UICamera.丏丆丈丄丑丛丄业丅 onKey;
    public static UICamera.丏丆丈丄丑丛丄业丅 onNavigate;
    public static UICamera.一丑下丄丝不丆三三 onPan;
    public static UICamera.下丈业丑世丟丘丅下 onTooltip;
    public static UICamera.丈世丗丄丟丒下丗丁 onMouseMove;
    private static UICamera.丞上且下专丞东专世[] 丟万丒丛东丟丏一东;
    public static UICamera.丞上且下专丞东专世 controller;
    public static System.Collections.Generic.List<UICamera.丞上且下专丞东专世> activeTouches;
    private static System.Collections.Generic.List<int> 丐丄与上丂丒丂东世;
    private static int 业丆世丄丏丕丕七不;
    private static int 丙万且丝丐世下世且;
    private static UnityEngine.GameObject 丘丘丕丄丟一丞与且;
    private UnityEngine.Camera 丟丕东万丐丁丁专一;
    private static float 丙丄上丁不丏一丂丐;
    private float 丏世下丏丂丕丙丐世;
    public static bool isDragging;
    private static UnityEngine.GameObject 世万丐丟专下万丂下;
    private static UnityEngine.GameObject 丑丁丞丑丗丏专世七;
    private static UnityEngine.GameObject 东一且三丑丑丏丗七;
    private static UICamera.丞业丐世丐世一丁丁 世七下丒丏且丝丕世;
    private static 丒丞丕丕七丁丗丟丛<UICamera.丞业丐世丐世一丁丁> 丌丙丞下一下东不丏;
    private static UnityEngine.Plane 丛丏七丆丄丆丝与丄;
    private static float 丄东且丟东业丆丆丘;
    private static int 丛丒丙丞且丟与丈丕;
    private static UnityEngine.RaycastHit[] 丒万与丝东丏丆上且;
    private static bool 丞丅丟下万万丟与七;
    public static UICamera.丕丗丐丄上一丙丙丘 GetInputTouchCount;
    public static UICamera.丕丘丄丈丛丟上三不 GetInputTouch;
    
    // Properties
    public bool 丌七丞专丗业丙丛丁 { get; }
    public static bool 丅三万且丗上上上万 { get; set; }
    public static UnityEngine.Vector2 丆三丈丛丗与丂丑丏 { get; set; }
    public static UnityEngine.Vector2 且丂上三丙丂丛丄业 { get; set; }
    public static UICamera 丏丆丑丗七丄丙丝与 { get; }
    public static UICamera.三下七东不东丈丈丞 三丈丁丗丌上上上万 { get; set; }
    public static UnityEngine.KeyCode 丙丙丄丏且丛与丟丙 { get; set; }
    public static UnityEngine.Ray 三业上丈丞丕丒东丘 { get; }
    public static bool 丝丅丁丈丝三世丗上 { get; }
    public static UnityEngine.GameObject 丌世丂丘丒丅丒丗丌 { get; set; }
    private bool 专丂丅下丕丟东专丄 { get; }
    public UnityEngine.Camera 丘丐下不丐下丘丞丗 { get; }
    public static UnityEngine.GameObject 上丒丑丕丑万丑丈丛 { get; }
    public static bool 丆不不东丒丑丗丅丙 { get; }
    public static UnityEngine.GameObject 丛丑一与世丌丞七一 { get; set; }
    public static UnityEngine.GameObject 一丕丝业万丙丟不不 { get; set; }
    public static UnityEngine.GameObject 七丁万不丐丂上世万 { get; set; }
    public static int 东丑业丛上丌上丆丑 { get; }
    public static int 丝专下丒丘三丑上且 { get; }
    public static UnityEngine.Camera 丙与丝丘世上东且丁 { get; }
    public static UICamera 丐下丛上与丄丘丒丝 { get; }
    
    // Methods
    public bool get_stickyPress()
    {
        return true;
    }
    public static bool get_disableController()
    {
        var val_3;
        bool val_4;
        val_3 = null;
        val_3 = null;
        val_4 = UICamera.东东上丈丗丑丄东丕;
        if(val_4 != false)
        {
                bool val_1 = UIPopupList.isOpen;
            val_4 = val_1 ^ 1;
        }
        
        val_1 = val_4;
        return (bool)val_1;
    }
    public static void set_disableController(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        UICamera.东东上丈丗丑丄东丕 = 丙业与丙丗丝不丈东;
    }
    public static UnityEngine.Vector2 get_lastTouchPosition()
    {
        null = null;
        return new UnityEngine.Vector2() {x = UICamera.专丟丆丛丁七下三丝, y = UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50};
    }
    public static void set_lastTouchPosition(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        null = null;
        UICamera.专丟丆丛丁七下三丝 = 丙业与丙丗丝不丈东.x;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = 丙业与丙丗丝不丈东.y;
    }
    public static UnityEngine.Vector2 get_lastEventPosition()
    {
        float val_7;
        UnityEngine.Object val_13;
        var val_14;
        if(UICamera.currentScheme == 2)
        {
                val_13 = UICamera.hoveredObject;
            if(val_13 != 0)
        {
                UnityEngine.Bounds val_5 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  val_13.transform, 一丐丂丘专丅丟丞七:  true);
            val_13 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  val_13.layer);
            UnityEngine.Vector3 val_10 = val_13.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_7, y = V1.16B, z = V2.16B});
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            return new UnityEngine.Vector2() {x = UICamera.专丟丆丛丁七下三丝, y = UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50};
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        return new UnityEngine.Vector2() {x = UICamera.专丟丆丛丁七下三丝, y = UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50};
    }
    public static void set_lastEventPosition(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        null = null;
        UICamera.专丟丆丛丁七下三丝 = 丙业与丙丗丝不丈东.x;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = 丙业与丙丗丝不丈东.y;
    }
    public static UICamera get_first()
    {
        var val_2;
        丒丞丕丕七丁丗丟丛<UICamera> val_3;
        var val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        val_3 = UICamera.list;
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_3 = UICamera.list;
        if(val_3 == null)
        {
            goto label_6;
        }
        
        if((UICamera.list + 24) != 0)
        {
                val_4 = null;
            val_4 = null;
            UICamera val_1 = UICamera.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
            return (UICamera)val_5;
        }
        
        label_7:
        val_5 = 0;
        return (UICamera)val_5;
        label_6:
    }
    public static UICamera.三下七东不东丈丈丞 get_currentScheme()
    {
        UICamera val_2;
        var val_3;
        UnityEngine.KeyCode val_5;
        var val_6;
        var val_7;
        var val_9;
        val_3 = null;
        val_3 = null;
        val_5 = UICamera.东七丅且且下丁丛丁;
        if(val_5 == 0)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_5 = UICamera.东七丅且且下丁丛丁;
        if(val_5 <= 329)
        {
            goto label_6;
        }
        
        label_24:
        val_6 = 2;
        return (三下七东不东丈丈丞)val_6;
        label_3:
        val_6 = 1;
        return (三下七东不东丈丈丞)val_6;
        label_6:
        val_2 = UICamera.current;
        if(val_2 == 0)
        {
            goto label_16;
        }
        
        val_7 = null;
        val_7 = null;
        if(UICamera.丆丝丌丙丂丛与丆七 != 2)
        {
            goto label_16;
        }
        
        if(UICamera.东七丅且且下丁丛丁 == UICamera.current.submitKey0)
        {
            goto label_24;
        }
        
        val_9 = null;
        val_9 = null;
        val_2 = UICamera.东七丅且且下丁丛丁;
        if(val_2 == UICamera.current.submitKey1)
        {
            goto label_24;
        }
        
        label_16:
        val_6 = 0;
        return (三下七东不东丈丈丞)val_6;
    }
    public static void set_currentScheme(UICamera.三下七东不东丈丈丞 丙业与丙丗丝不丈东)
    {
        UnityEngine.KeyCode val_1;
        var val_2;
        if(丙业与丙丗丝不丈东 == 2)
        {
            goto label_1;
        }
        
        if(丙业与丙丗丝不丈东 != 0)
        {
            goto label_2;
        }
        
        val_1 = 323;
        goto label_12;
        label_1:
        val_1 = 330;
        goto label_12;
        label_2:
        if(丙业与丙丗丝不丈东 == 1)
        {
                val_1 = 0;
        }
        else
        {
                val_1 = 48;
        }
        
        label_12:
        UICamera.currentKey = val_1;
        val_2 = null;
        val_2 = null;
        UICamera.丆丝丌丙丂丛与丆七 = 丙业与丙丗丝不丈东;
    }
    public static UnityEngine.KeyCode get_currentKey()
    {
        null = null;
        return (UnityEngine.KeyCode)UICamera.东七丅且且下丁丛丁;
    }
    public static void set_currentKey(UnityEngine.KeyCode 丙业与丙丗丝不丈东)
    {
        UnityEngine.KeyCode val_4;
        var val_5;
        var val_8;
        var val_9;
        var val_10;
        丏丄丈丗丌丘不不一 val_11;
        val_4 = 丙业与丙丗丝不丈东;
        val_5 = null;
        val_5 = null;
        if(UICamera.东七丅且且下丁丛丁 == val_4)
        {
                return;
        }
        
        UICamera.东七丅且且下丁丛丁 = val_4;
        UICamera.丆丝丌丙丂丛与丆七 = UICamera.currentScheme;
        if(UICamera.丆丝丌丙丂丛与丆七 == UICamera.丆丝丌丙丂丛与丆七)
        {
                return;
        }
        
        bool val_2 = UICamera.HideTooltip();
        if(UICamera.丆丝丌丙丂丛与丆七 == 0)
        {
            goto label_9;
        }
        
        val_4 = UICamera.current;
        if(val_4 == 0)
        {
            goto label_24;
        }
        
        val_8 = null;
        val_8 = null;
        val_4 = UICamera.current;
        if(UICamera.current.autoHideCursor == false)
        {
            goto label_24;
        }
        
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = 1;
        val_9 = null;
        val_9 = null;
        val_4 = mem[UICamera.丟万丒丛东丟丏一东 + 32];
        val_4 = UICamera.丟万丒丛东丟丏一东 + 32;
        mem2[0] = 2;
        goto label_24;
        label_9:
        UnityEngine.Cursor.lockState = 0;
        UnityEngine.Cursor.visible = true;
        label_24:
        val_10 = null;
        val_10 = null;
        val_11 = UICamera.onSchemeChange;
        if(val_11 == null)
        {
                return;
        }
        
        val_11 = UICamera.onSchemeChange;
        if(val_11 == null)
        {
                val_11 = 0;
        }
        
        val_11.Invoke();
    }
    public static UnityEngine.Ray get_currentRay()
    {
        var val_3;
        var val_4;
        var val_5;
        丞上且下专丞东专世 val_7;
        UnityEngine.Ray val_0;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if(UICamera.currentCamera == 0)
        {
            goto label_8;
        }
        
        val_5 = null;
        val_5 = null;
        val_7 = UICamera.currentTouch;
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_7 = UICamera.currentTouch;
        if(val_7 == null)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UICamera.currentTouch.下业丕七东丌丝下且, y = UICamera.currentTouch + 20 + 4});
        if(UICamera.currentCamera != null)
        {
                return UICamera.currentCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        
        return UICamera.currentCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        label_8:
        val_0.m_Origin.z = 0f;
        val_0.m_Direction.x = 0f;
        val_0.m_Direction.y = 0f;
        val_0.m_Direction.z = 0f;
        val_0.m_Origin.x = 0f;
        val_0.m_Origin.y = 0f;
        return val_0;
        label_11:
    }
    public static bool get_inputHasFocus()
    {
        UnityEngine.GameObject val_3;
        var val_4;
        var val_6;
        var val_7;
        var val_8;
        val_4 = null;
        val_4 = null;
        if(UICamera.三丑丞丈与丐且上丅 != false)
        {
                val_3 = UICamera.东一且三丑丑丏丗七;
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                val_6 = null;
            val_6 = null;
            val_3 = UICamera.东一且三丑丑丏丗七;
            if(val_3.activeInHierarchy != false)
        {
                val_7 = 1;
            return (bool)val_7;
        }
        
        }
        
            val_8 = null;
            val_8 = null;
            val_7 = 0;
            UICamera.三丑丞丈与丐且上丅 = false;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public static UnityEngine.GameObject get_genericEventHandler()
    {
        null = null;
        return (UnityEngine.GameObject)UICamera.七业丈丐上丁万专上;
    }
    public static void set_genericEventHandler(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        null = null;
        UICamera.七业丈丐上丁万专上 = 丙业与丙丗丝不丈东;
    }
    private bool 三丑丏一丟与丐丕不()
    {
        return UnityEngine.Object.op_Equality(x:  UICamera.eventHandler, y:  this);
    }
    public UnityEngine.Camera get_cachedCamera()
    {
        UnityEngine.Camera val_3;
        if(this.丟丕东万丐丁丁专一 == 0)
        {
                val_3 = this.GetComponent<UnityEngine.Camera>();
            this.丟丕东万丐丁丁专一 = val_3;
        }
        else
        {
                val_3 = this.丟丕东万丐丁丁专一;
        }
        
        IphoneXCameraScaler.丅业丄丞丞丛不东七(丛且丏丟丂下丐丅丄:  val_3);
        return (UnityEngine.Camera)this.丟丕东万丐丁丁专一;
    }
    public static UnityEngine.GameObject get_tooltipObject()
    {
        null = null;
        return (UnityEngine.GameObject)UICamera.丘丘丕丄丟一丞与且;
    }
    public static bool get_isOverUI()
    {
        var val_15;
        丞上且下专丞东专世 val_18;
        var val_19;
        UnityEngine.Object val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.Object val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_31;
        var val_32;
        val_15 = null;
        val_15 = null;
        val_18 = UICamera.currentTouch;
        if(val_18 != null)
        {
                val_18 = UICamera.currentTouch;
            if(val_18 != null)
        {
                return val_18.丒三且一丂丁一专上();
        }
        
            val_18 = 0;
            return val_18.丒三且一丂丁一专上();
        }
        
        val_19 = null;
        val_20 = UICamera.activeTouches.Count;
        val_21 = (uint)(((uint)((UICamera.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if(val_20 < 1)
        {
            goto label_10;
        }
        
        var val_15 = 0;
        label_28:
        val_22 = null;
        丞上且下专丞东专世 val_2 = UICamera.activeTouches.Item[0];
        if(val_2.万东丂丒且丅丛丑丕 == 0)
        {
            goto label_22;
        }
        
        val_23 = null;
        val_23 = null;
        if(val_2.万东丂丒且丅丛丑丕 == UICamera.fallThrough)
        {
            goto label_22;
        }
        
        val_24 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  val_2.万东丂丒且丅丛丑丕, 丕丗丆丕丈丑东丆丈:  0);
        if(val_24 != 0)
        {
            goto label_54;
        }
        
        label_22:
        val_25 = null;
        val_15 = val_15 + 1;
        val_21 = (uint)(((uint)((UICamera.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if(val_15 < val_20)
        {
            goto label_28;
        }
        
        label_10:
        val_25 = null;
        val_24 = 1152921504848912384;
        if((UICamera.丟万丒丛东丟丏一东 + 32 + 72) == 0)
        {
            goto label_44;
        }
        
        val_26 = null;
        val_26 = null;
        if((UICamera.丟万丒丛东丟丏一东 + 32 + 72) == UICamera.fallThrough)
        {
            goto label_44;
        }
        
        val_27 = null;
        val_27 = null;
        val_20 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  UICamera.丟万丒丛东丟丏一东 + 32 + 72, 丕丗丆丕丈丑东丆丈:  0);
        if(val_20 != 0)
        {
            goto label_54;
        }
        
        label_44:
        val_28 = null;
        val_28 = null;
        val_20 = mem[UICamera.controller + 80];
        val_20 = UICamera.controller.万东丂丒且丅丛丑丕;
        if(val_20 == 0)
        {
            goto label_74;
        }
        
        val_29 = null;
        val_29 = null;
        val_20 = mem[UICamera.controller + 80];
        val_20 = UICamera.controller.万东丂丒且丅丛丑丕;
        if(val_20 == UICamera.fallThrough)
        {
            goto label_74;
        }
        
        val_31 = null;
        val_31 = null;
        val_20 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  UICamera.controller.万东丂丒且丅丛丑丕, 丕丗丆丕丈丑东丆丈:  0);
        if(val_20 == 0)
        {
            goto label_74;
        }
        
        label_54:
        val_32 = 1;
        return (bool)val_32;
        label_74:
        val_32 = 0;
        return (bool)val_32;
    }
    public static UnityEngine.GameObject get_hoveredObject()
    {
        var val_3;
        丞上且下专丞东专世 val_4;
        var val_5;
        var val_6;
        丞上且下专丞东专世 val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        var val_10;
        var val_11;
        val_3 = null;
        val_3 = null;
        val_4 = UICamera.currentTouch;
        if(val_4 == null)
        {
            goto label_7;
        }
        
        val_4 = UICamera.currentTouch;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_5 = null;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 != false)
        {
                val_6 = null;
            val_7 = UICamera.currentTouch;
            val_8 = mem[UICamera.currentTouch + 72];
            val_8 = UICamera.currentTouch.上丞丕专丈业丁世专;
            return (UnityEngine.GameObject)val_8;
        }
        
        label_7:
        val_3 = null;
        val_7 = UICamera.丑丁丞丑丗丏专世七;
        if((UnityEngine.Object.op_Implicit(exists:  val_7)) != false)
        {
                val_9 = null;
            val_9 = null;
            val_7 = UICamera.丑丁丞丑丗丏专世七;
            if(val_7.activeInHierarchy != false)
        {
                val_10 = null;
            val_10 = null;
            val_8 = UICamera.丑丁丞丑丗丏专世七;
            return (UnityEngine.GameObject)val_8;
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = 0;
        UICamera.丑丁丞丑丗丏专世七 = 0;
        return (UnityEngine.GameObject)val_8;
        label_6:
    }
    public static void set_hoveredObject(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        var val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        UnityEngine.GameObject val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        UnityEngine.Camera val_40;
        var val_41;
        val_18 = null;
        val_18 = null;
        val_19 = UICamera.丑丁丞丑丗丏专世七;
        if(val_19 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_19 = UICamera.current;
        if(UICamera.currentTouch != null)
        {
                val_22 = 0;
        }
        else
        {
                val_20 = null;
            UICamera.currentTouchID = 99;
            val_22 = 1;
            UICamera.currentTouch = UICamera.controller;
        }
        
        bool val_2 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        if(((UnityEngine.Object.op_Implicit(exists:  UICamera.东一且三丑丑丏丗七)) != false) && (UICamera.currentScheme == 2))
        {
                val_23 = null;
            val_23 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 且丁三丙丄一世不七:  "OnSelect", 万且万且丑丗且丌丆:  null);
            val_24 = null;
            if(UICamera.onSelect != null)
        {
                UICamera.onSelect.Invoke(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 丏业丟一东丂东丘丛:  false);
            val_24 = null;
        }
        
            val_24 = null;
            UICamera.东一且三丑丑丏丗七 = 0;
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = UICamera.丑丁丞丑丗丏专世七;
        if((UnityEngine.Object.op_Implicit(exists:  val_26)) != false)
        {
                val_27 = null;
            val_27 = null;
            val_26 = UICamera.丑丁丞丑丗丏专世七;
            UICamera.Notify(丝三丁东丈丒世丅业:  val_26, 且丁三丙丄一世不七:  "OnHover", 万且万且丑丗且丌丆:  null);
            if(UICamera.onHover != null)
        {
                val_26 = UICamera.丑丁丞丑丗丏专世七;
            UICamera.onHover.Invoke(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        UICamera.丑丁丞丑丗丏专世七 = 丙业与丙丗丝不丈东;
        if(UICamera.currentTouch == null)
        {
                val_28 = null;
        }
        
        丌下丐上丛丘丗万丅 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.丑丁丞丑丗丏专世七)) != false)
        {
                val_29 = null;
            val_29 = null;
            val_26 = mem[UICamera.controller + 72];
            val_26 = UICamera.controller.上丞丕专丈业丁世专;
            if(UICamera.丑丁丞丑丗丏专世七 != val_26)
        {
                val_30 = null;
            val_30 = null;
            if((UICamera.丑丁丞丑丗丏专世七.GetComponent<UIKeyNavigation>()) != 0)
        {
                val_31 = null;
            val_31 = null;
            val_26 = UICamera.丑丁丞丑丗丏专世七;
            UICamera.controller.上丞丕专丈业丁世专 = val_26;
        }
        
        }
        
            if(val_22 != 0)
        {
                val_32 = null;
            val_32 = null;
            val_33 = null;
            if(UICamera.丑丁丞丑丗丏专世七 != 0)
        {
                val_34 = null;
            UICamera val_12 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  UICamera.丑丁丞丑丗丏专世七.layer);
        }
        else
        {
                val_36 = null;
            UICamera val_13 = UICamera.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        }
        
            if(val_13 != 0)
        {
                val_37 = null;
            val_37 = null;
            UICamera.current = val_13;
            UICamera.currentCamera = val_13.cachedCamera;
        }
        
        }
        
            val_38 = null;
            val_38 = null;
            if(UICamera.onHover != null)
        {
                UICamera.onHover.Invoke(丝三丁东丈丒世丅业:  UICamera.丑丁丞丑丗丏专世七, 丏业丟一东丂东丘丛:  true);
            val_38 = null;
        }
        
            val_38 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.丑丁丞丑丗丏专世七, 且丁三丙丄一世不七:  "OnHover", 万且万且丑丗且丌丆:  true);
        }
        
        if(val_22 == 0)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        UICamera.current = val_19;
        val_40 = 0;
        if(val_19 != 0)
        {
                val_40 = val_19.cachedCamera;
        }
        
        val_41 = null;
        val_41 = null;
        UICamera.currentCamera = val_40;
        UICamera.currentTouch = 0;
        UICamera.currentTouchID = 99;
    }
    public static UnityEngine.GameObject get_controllerNavigationObject()
    {
        var val_11;
        var val_12;
        var val_13;
        丞上且下专丞东专世 val_14;
        UnityEngine.GameObject val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.Object val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_11 = null;
        val_11 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.controller.上丞丕专丈业丁世专)) != false)
        {
                val_12 = null;
            val_12 = null;
            if(activeInHierarchy != false)
        {
                val_13 = null;
            val_13 = null;
            val_14 = UICamera.controller;
            val_15 = mem[UICamera.controller + 72];
            val_15 = UICamera.controller.上丞丕专丈业丁世专;
            return (UnityEngine.GameObject)val_15;
        }
        
        }
        
        if(UICamera.currentScheme != 2)
        {
            goto label_50;
        }
        
        val_16 = null;
        val_16 = null;
        if(UICamera.current == 0)
        {
            goto label_50;
        }
        
        val_17 = null;
        val_17 = null;
        if(UICamera.current.useController == false)
        {
            goto label_50;
        }
        
        val_18 = null;
        val_18 = null;
        if((UIKeyNavigation.list + 24) < 1)
        {
            goto label_50;
        }
        
        val_19 = 0;
        goto label_32;
        label_45:
        val_20 = null;
        val_20 = null;
        val_21 = UIKeyNavigation.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        if(((UnityEngine.Object.op_Implicit(exists:  val_21)) != false) && (val_5.constraint != 3))
        {
                if(val_5.startsSelected == true)
        {
            goto label_59;
        }
        
        }
        
        val_19 = 1;
        label_32:
        val_22 = null;
        val_22 = null;
        if(val_19 < (UIKeyNavigation.list + 24))
        {
            goto label_45;
        }
        
        val_23 = null;
        val_23 = null;
        if(UICamera.丑丁丞丑丗丏专世七 != 0)
        {
            goto label_50;
        }
        
        val_24 = 0;
        goto label_51;
        label_63:
        val_25 = null;
        val_25 = null;
        val_21 = UIKeyNavigation.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        if((UnityEngine.Object.op_Implicit(exists:  val_21)) != false)
        {
                if(val_8.constraint != 3)
        {
            goto label_59;
        }
        
        }
        
        val_24 = 1;
        label_51:
        val_26 = null;
        val_26 = null;
        if(val_24 < (UIKeyNavigation.list + 24))
        {
            goto label_63;
        }
        
        label_50:
        val_27 = null;
        val_27 = null;
        val_14 = UICamera.controller;
        val_15 = 0;
        UICamera.controller.上丞丕专丈业丁世专 = 0;
        return (UnityEngine.GameObject)val_15;
        label_59:
        UICamera.hoveredObject = val_21.gameObject;
        val_28 = null;
        if(UICamera.controller == null)
        {
                val_28 = null;
        }
        
        UICamera.controller.上丞丕专丈业丁世专 = UICamera.丑丁丞丑丗丏专世七;
        return (UnityEngine.GameObject)val_15;
    }
    public static void set_controllerNavigationObject(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        var val_3;
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        var val_7;
        下丈业丑世丟丘丅下 val_9;
        val_3 = null;
        val_3 = null;
        val_4 = 1152921504848912384;
        if(UICamera.controller.上丞丕专丈业丁世专 != 丙业与丙丗丝不丈东)
        {
                val_5 = null;
            val_5 = null;
            if((UnityEngine.Object.op_Implicit(exists:  UICamera.controller.上丞丕专丈业丁世专)) != false)
        {
                val_6 = null;
            val_6 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnHover", 万且万且丑丗且丌丆:  null);
            val_7 = null;
            val_9 = UICamera.onHover;
            if(val_9 != null)
        {
                val_9 = UICamera.onHover;
            val_4 = mem[UICamera.controller + 72];
            val_4 = UICamera.controller.上丞丕专丈业丁世专;
            val_9.Invoke(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
            val_7 = null;
        }
        
            val_7 = null;
            UICamera.controller.上丞丕专丈业丁世专 = 0;
        }
        
        }
        
        UICamera.hoveredObject = 丙业与丙丗丝不丈东;
    }
    public static UnityEngine.GameObject get_selectedObject()
    {
        var val_3;
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        UnityEngine.GameObject val_7;
        var val_8;
        val_3 = null;
        val_3 = null;
        val_4 = UICamera.东一且三丑丑丏丗七;
        if((UnityEngine.Object.op_Implicit(exists:  val_4)) != false)
        {
                val_5 = null;
            val_5 = null;
            val_4 = UICamera.东一且三丑丑丏丗七;
            if(val_4.activeInHierarchy != false)
        {
                val_6 = null;
            val_6 = null;
            val_7 = UICamera.东一且三丑丑丏丗七;
            return (UnityEngine.GameObject)val_7;
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = 0;
        UICamera.东一且三丑丑丏丗七 = 0;
        return (UnityEngine.GameObject)val_7;
    }
    public static void set_selectedObject(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        var val_21;
        丞上且下专丞东专世 val_22;
        var val_23;
        var val_25;
        var val_26;
        var val_27;
        丞上且下专丞东专世 val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        bool val_40;
        var val_41;
        var val_42;
        UnityEngine.Camera val_43;
        var val_44;
        val_21 = null;
        val_21 = null;
        if(UICamera.东一且三丑丑丏丗七 == 丙业与丙丗丝不丈东)
        {
                UICamera.hoveredObject = 丙业与丙丗丝不丈东;
            val_22 = UICamera.controller;
            UICamera.controller.上丞丕专丈业丁世专 = 丙业与丙丗丝不丈东;
            return;
        }
        
        bool val_2 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        val_23 = null;
        val_22 = UICamera.current;
        if(UICamera.currentTouch != null)
        {
                val_25 = 0;
        }
        else
        {
                val_23 = null;
            UICamera.currentTouchID = 99;
            val_25 = 1;
            UICamera.currentTouch = UICamera.controller;
        }
        
        val_23 = null;
        UICamera.三丑丞丈与丐且上丅 = false;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.东一且三丑丑丏丗七)) != false)
        {
                val_26 = null;
            val_26 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 且丁三丙丄一世不七:  "OnSelect", 万且万且丑丗且丌丆:  null);
            if(UICamera.onSelect != null)
        {
                UICamera.onSelect.Invoke(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_27 = null;
        val_27 = null;
        UICamera.东一且三丑丑丏丗七 = 丙业与丙丗丝不丈东;
        val_28 = UICamera.currentTouch;
        丌下丐上丛丘丗万丅 = 0;
        if(丙业与丙丗丝不丈东 != 0)
        {
                val_28 = 丙业与丙丗丝不丈东.GetComponent<UIKeyNavigation>();
            if(val_28 != 0)
        {
                val_29 = null;
            val_29 = null;
            val_28 = UICamera.controller;
            UICamera.controller.上丞丕专丈业丁世专 = 丙业与丙丗丝不丈东;
        }
        
        }
        
        val_30 = null;
        val_30 = null;
        if((val_25 & (UnityEngine.Object.op_Implicit(exists:  UICamera.东一且三丑丑丏丗七))) == true)
        {
                val_31 = null;
            val_31 = null;
            val_32 = null;
            if(UICamera.东一且三丑丑丏丗七 != 0)
        {
                val_33 = null;
            UICamera val_11 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  UICamera.东一且三丑丑丏丗七.layer);
        }
        else
        {
                val_35 = null;
            UICamera val_12 = UICamera.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        }
        
            if(val_12 != 0)
        {
                val_36 = null;
            val_36 = null;
            UICamera.current = val_12;
            UICamera.currentCamera = val_12.cachedCamera;
        }
        
        }
        
        val_37 = null;
        val_37 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.东一且三丑丑丏丗七)) != false)
        {
                val_38 = null;
            val_38 = null;
            if(UICamera.东一且三丑丑丏丗七.activeInHierarchy != false)
        {
                val_39 = null;
            val_39 = null;
            val_40 = UnityEngine.Object.op_Inequality(x:  UICamera.东一且三丑丑丏丗七.GetComponent<UIInput>(), y:  0);
        }
        else
        {
                val_40 = false;
        }
        
            val_41 = null;
            val_41 = null;
            UICamera.三丑丞丈与丐且上丅 = val_40;
            if(UICamera.onSelect != null)
        {
                UICamera.onSelect.Invoke(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 丏业丟一东丂东丘丛:  true);
            val_41 = null;
        }
        
            val_41 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 且丁三丙丄一世不七:  "OnSelect", 万且万且丑丗且丌丆:  true);
        }
        
        if(val_25 == 0)
        {
                return;
        }
        
        val_42 = null;
        val_42 = null;
        UICamera.current = val_22;
        val_43 = 0;
        if(val_22 != 0)
        {
                val_43 = val_22.cachedCamera;
        }
        
        val_44 = null;
        val_44 = null;
        UICamera.currentCamera = val_43;
        UICamera.currentTouch = 0;
        UICamera.currentTouchID = 99;
    }
    public static bool IsPressed(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_7 = 0;
        val_8 = null;
        var val_1 = ((UICamera.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
        do
        {
            val_8 = null;
            if((UICamera.丟万丒丛东丟丏一东.Length + 32 + 80) == 丝三丁东丈丒世丅业)
        {
                return true;
        }
        
            val_9 = null;
            var val_3 = ((UICamera.__il2cppRuntimeField_126 & 512) != 0) ? 1 : 0;
            val_10 = val_7 + 1;
        }
        while(val_7 < 2);
        
        val_9 = null;
        int val_4 = UICamera.activeTouches.Count;
        val_11 = null;
        val_12 = (uint)(((uint)((UICamera.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if(val_4 >= 1)
        {
                val_7 = 0;
            do
        {
            val_13 = null;
            丞上且下专丞东专世 val_5 = UICamera.activeTouches.Item[0];
            if(val_5.万东丂丒且丅丛丑丕 == 丝三丁东丈丒世丅业)
        {
                return true;
        }
        
            val_14 = null;
            val_10 = val_7 + 1;
            val_12 = (uint)(((uint)((UICamera.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        }
        while(val_10 < val_4);
        
        }
        
        val_14 = null;
        return UnityEngine.Object.op_Equality(x:  UICamera.controller.万东丂丒且丅丛丑丕, y:  丝三丁东丈丒世丅业);
    }
    public static int get_touchCount()
    {
        return UICamera.CountInputSources();
    }
    public static int CountInputSources()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        int val_1 = UICamera.activeTouches.Count;
        if(val_1 >= 1)
        {
                var val_9 = 0;
            do
        {
            val_10 = null;
            val_10 = null;
            丞上且下专丞东专世 val_2 = UICamera.activeTouches.Item[0];
            val_9 = val_9 + 1;
            val_11 = 0 + (UnityEngine.Object.op_Inequality(x:  val_2.万东丂丒且丅丛丑丕, y:  0));
        }
        while(val_1 != val_9);
        
        }
        else
        {
                val_11 = 0;
        }
        
        val_12 = 0;
        goto label_13;
        label_24:
        val_11 = val_11 + (UnityEngine.Object.op_Inequality(x:  UICamera.丟万丒丛东丟丏一东.Length + 32 + 80, y:  0));
        val_12 = 1;
        label_13:
        val_13 = null;
        val_13 = null;
        if(UICamera.丟万丒丛东丟丏一东 == null)
        {
                val_13 = null;
        }
        
        if(val_12 < UICamera.丟万丒丛东丟丏一东.Length)
        {
            goto label_24;
        }
        
        val_13 = null;
        bool val_7 = UnityEngine.Object.op_Inequality(x:  UICamera.controller.万东丂丒且丅丛丑丕, y:  0);
        val_7 = val_11 + val_7;
        return (int)val_7;
    }
    public static int get_dragCount()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        int val_1 = UICamera.activeTouches.Count;
        if(val_1 >= 1)
        {
                var val_9 = 0;
            do
        {
            val_10 = null;
            val_10 = null;
            丞上且下专丞东专世 val_2 = UICamera.activeTouches.Item[0];
            val_9 = val_9 + 1;
            val_11 = 0 + (UnityEngine.Object.op_Inequality(x:  val_2.丆丝东丞下丁丛丝与, y:  0));
        }
        while(val_1 != val_9);
        
        }
        else
        {
                val_11 = 0;
        }
        
        val_12 = 0;
        goto label_13;
        label_24:
        val_11 = val_11 + (UnityEngine.Object.op_Inequality(x:  UICamera.丟万丒丛东丟丏一东.Length + 32 + 88, y:  0));
        val_12 = 1;
        label_13:
        val_13 = null;
        val_13 = null;
        if(UICamera.丟万丒丛东丟丏一东 == null)
        {
                val_13 = null;
        }
        
        if(val_12 < UICamera.丟万丒丛东丟丏一东.Length)
        {
            goto label_24;
        }
        
        val_13 = null;
        bool val_7 = UnityEngine.Object.op_Inequality(x:  UICamera.controller.丆丝东丞下丁丛丝与, y:  0);
        val_7 = val_11 + val_7;
        return (int)val_7;
    }
    public static UnityEngine.Camera get_mainCamera()
    {
        UICamera val_1 = UICamera.eventHandler;
        if(val_1 == 0)
        {
                return 0;
        }
        
        if(val_1 != null)
        {
                return val_1.cachedCamera;
        }
        
        return val_1.cachedCamera;
    }
    public static UICamera get_eventHandler()
    {
        var val_6;
        var val_7;
        UnityEngine.Object val_8;
        var val_9;
        val_6 = 0;
        goto label_1;
        label_19:
        val_7 = null;
        val_7 = null;
        var val_1 = (UICamera.list + 16) + 0;
        val_8 = mem[(UICamera.list + 16 + 0) + 32];
        val_8 = (UICamera.list + 16 + 0) + 32;
        if(val_8 != 0)
        {
                if(val_8.enabled != false)
        {
                if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_8.gameObject)) == true)
        {
                return (UICamera)val_8;
        }
        
        }
        
        }
        
        val_6 = 1;
        label_1:
        val_9 = null;
        val_9 = null;
        if(val_6 < (UICamera.list + 24))
        {
            goto label_19;
        }
        
        val_8 = 0;
        return (UICamera)val_8;
    }
    private static int 丙丝丕下业业丄且丈(UICamera 丆丛丑世下一丐且丕, UICamera 丌丗丏丏丛东专丁且)
    {
        var val_10;
        var val_11;
        val_10 = 丌丗丏丏丛东专丁且;
        float val_4 = val_10.cachedCamera.depth;
        if(丆丛丑世下一丐且丕.cachedCamera.depth < 0)
        {
                val_11 = 1;
            return (int)(丆丛丑世下一丐且丕.cachedCamera.depth > val_10.depth) ? -1 : 0;
        }
        
        val_10 = val_10.cachedCamera;
        return (int)(丆丛丑世下一丐且丕.cachedCamera.depth > val_10.depth) ? -1 : 0;
    }
    private static UnityEngine.Rigidbody 东下丄丝上丝丝丅七(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        UnityEngine.Object val_7;
        UnityEngine.Object val_8;
        val_7 = 丄上七丟不丗丕下丟;
        goto label_1;
        label_13:
        if((val_7.GetComponent<UIPanel>()) != 0)
        {
            goto label_5;
        }
        
        val_8 = val_7.GetComponent<UnityEngine.Rigidbody>();
        if(val_8 != 0)
        {
                return (UnityEngine.Rigidbody)val_8;
        }
        
        val_7 = val_7.parent;
        label_1:
        if(val_7 != 0)
        {
            goto label_13;
        }
        
        label_5:
        val_8 = 0;
        return (UnityEngine.Rigidbody)val_8;
    }
    private static UnityEngine.Rigidbody2D 丅丒丁丂丁丕丈丞丂(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        UnityEngine.Object val_7;
        UnityEngine.Object val_8;
        val_7 = 丄上七丟不丗丕下丟;
        goto label_1;
        label_13:
        if((val_7.GetComponent<UIPanel>()) != 0)
        {
            goto label_5;
        }
        
        val_8 = val_7.GetComponent<UnityEngine.Rigidbody2D>();
        if(val_8 != 0)
        {
                return (UnityEngine.Rigidbody2D)val_8;
        }
        
        val_7 = val_7.parent;
        label_1:
        if(val_7 != 0)
        {
            goto label_13;
        }
        
        label_5:
        val_8 = 0;
        return (UnityEngine.Rigidbody2D)val_8;
    }
    public static void Raycast(UICamera.丞上且下专丞东专世 丟下丙丆不东一与丅)
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        var val_7;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.下业丕七东丌丝下且, y = V8.16B});
        val_4 = null;
        val_5 = null;
        if((UICamera.Raycast(丛东丘下丂丌丑上丙:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != true)
        {
                val_5 = null;
            val_6 = UICamera.fallThrough;
            UICamera.世万丐丟专下万丂下 = val_6;
        }
        
        val_5 = null;
        val_7 = null;
        if(UICamera.世万丐丟专下万丂下 == 0)
        {
                val_7 = null;
            val_6 = UICamera.七业丈丐上丁万专上;
            UICamera.世万丐丟专下万丂下 = val_6;
        }
        
        丟下丙丆不东一与丅.丙丕丛丒丁丐丒丕丕 = 丟下丙丆不东一与丅.上丞丕专丈业丁世专;
        val_7 = null;
        丟下丙丆不东一与丅.上丞丕专丈业丁世专 = UICamera.世万丐丟专下万丂下;
        UICamera.专丟丆丛丁七下三丝 = 丟下丙丆不东一与丅.下业丕七东丌丝下且;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = val_6;
    }
    public static bool Raycast(UnityEngine.Vector3 丛东丘下丂丌丑上丙)
    {
        var val_71;
        UnityEngine.GameObject val_74;
        UnityEngine.Vector3 val_76;
        var val_77;
        UnityEngine.GameObject val_79;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        var val_93;
        float val_94;
        var val_105;
        var val_106;
        float val_107;
        var val_109;
        var val_110;
        var val_111;
        var val_113;
        var val_114;
        var val_115;
        丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁> val_117;
        var val_118;
        var val_119;
        丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁> val_124;
        var val_125;
        var val_129;
        var val_130;
        var val_131;
        var val_91 = 0;
        val_88 = 106047252;
        label_21:
        val_89 = null;
        val_89 = null;
        if(val_91 >= (UICamera.list + 24))
        {
                return false;
        }
        
        val_90 = null;
        val_90 = null;
        var val_1 = (UICamera.list + 16) + 0;
        if((((UICamera.list + 16 + 0) + 32.enabled) == false) || ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  (UICamera.list + 16 + 0) + 32.gameObject)) == false))
        {
            goto label_234;
        }
        
        val_91 = null;
        val_91 = null;
        UICamera.currentCamera = (UICamera.list + 16 + 0) + 32.cachedCamera;
        UnityEngine.Vector3 val_6 = UICamera.currentCamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = 丛东丘下丂丌丑上丙.x, y = 丛东丘下丂丌丑上丙.y, z = 丛东丘下丂丌丑上丙.z});
        if((System.Single.IsNaN(f:  val_6.x)) == false)
        {
            goto label_20;
        }
        
        label_234:
        val_91 = val_91 + 1;
        goto label_21;
        label_20:
        if(((((val_6.y > 1f) || (val_6.y < 0)) || (val_6.x > 1f)) || (val_6.x < 0)) || ((System.Single.IsNaN(f:  val_6.y)) == true))
        {
            goto label_234;
        }
        
        val_93 = null;
        val_93 = null;
        UnityEngine.Ray val_9 = UICamera.currentCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 丛东丘下丂丌丑上丙.x, y = 丛东丘下丂丌丑上丙.y, z = 丛东丘下丂丌丑上丙.z});
        int val_92 = UICamera.currentCamera.cullingMask;
        val_94 = mem[(UICamera.list + 16 + 0) + 32 + 76];
        val_94 = (UICamera.list + 16 + 0) + 32 + 76;
        if(val_94 <= 0f)
        {
                val_94 = UICamera.currentCamera.farClipPlane - UICamera.currentCamera.nearClipPlane;
            val_88 = val_88;
        }
        
        if(((UICamera.list + 16 + 0) + 32 + 28) > 3)
        {
            goto label_234;
        }
        
        var val_93 = val_88 + ((UICamera.list + 16 + 0) + 32 + 28) << 2;
        val_92 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = (UICamera.list + 16 + 0) + 32 + 36})) | ((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = (UICamera.list + 16 + 0) + 32 + 40})) & val_92);
        val_93 = val_93 + val_88;
        goto (val_88 + ((UICamera.list + 16 + 0) + 32 + 28) << 2 + val_88);
        label_134:
        val_105 = null;
        UnityEngine.GameObject val_37 = 0.gameObject;
        UIWidget val_39 = 0;
        val_106 = null;
        val_106 = null;
        bool val_40 = UIRoot.上万丞丂丕丂丕丐万.TryGetValue(key:  val_37.transform, value: out  val_39);
        if(val_39 == 0)
        {
            goto label_108;
        }
        
        if(val_39.isVisible == true)
        {
            goto label_116;
        }
        
        goto label_123;
        label_108:
        if((不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRect>(丝三丁东丈丒世丅业:  val_37, 丕丗丆丕丈丑东丆丈:  0)) == 0)
        {
            goto label_116;
        }
        
        val_107 = val_43.finalAlpha;
        if(val_107 < 0)
        {
            goto label_123;
        }
        
        label_116:
        UICamera.世七下丒丏且丝丕世 = 不丌丂丁丄一与丆丙.丛丘世丟丝上丙与丕(丝三丁东丈丒世丅业:  val_37);
        if(UICamera.世七下丒丏且丝丕世 != 2147483647)
        {
                mem[1152921505096626648] = UICamera.丒万与丝东丏丆上且.Length + 16;
            mem[1152921505096626636] = UICamera.丒万与丝东丏丆上且.Length + 16;
            mem[1152921505096626620] = UICamera.丒万与丝东丏丆上且.Length;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1E8 = UICamera.丒万与丝东丏丆上且.Length;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1EC = UICamera.丒万与丝东丏丆上且.Length + 16;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1F0 = 丛东丘下丂丌丑上丙.z;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1F8 = 0.gameObject;
            UICamera.丌丙丞下一下东不丏.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new 丞业丐世丐世一丁丁() {丁丂丝不丟丛丟一丂 = new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {}, m_Normal = new UnityEngine.Vector3() {}, m_UV = new UnityEngine.Vector2()}, 丅专与丒丈丗丒丘丌 = new UnityEngine.Vector3()});
        }
        
        label_123:
        val_109 = null;
         =  + 1;
         =  + 44;
        if( != )
        {
            goto label_134;
        }
        
        val_109 = null;
        goto label_137;
        label_166:
        UnityEngine.GameObject val_47 = [0].gameObject;
        UIWidget val_49 = 0;
        val_110 = null;
        val_110 = null;
        bool val_50 = UIRoot.上万丞丂丕丂丕丐万.TryGetValue(key:  val_47.transform, value: out  val_49);
        if(val_49 == 0)
        {
            goto label_147;
        }
        
        if(val_49.isVisible == true)
        {
            goto label_155;
        }
        
        goto label_162;
        label_147:
        if((不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRect>(丝三丁东丈丒世丅业:  val_47, 丕丗丆丕丈丑东丆丈:  0)) != 0)
        {
                if(val_53.finalAlpha < 0)
        {
            goto label_162;
        }
        
        }
        
        label_155:
        val_111 = null;
        UICamera.世七下丒丏且丝丕世 = 不丌丂丁丄一与丆丙.丛丘世丟丝上丙与丕(丝三丁东丈丒世丅业:  val_47);
        if(UICamera.世七下丒丏且丝丕世 != 2147483647)
        {
                val_111 = null;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1F8 = val_47;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1E8 = ;
            UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_1F0 = ;
            UICamera.丌丙丞下一下东不丏.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new 丞业丐世丐世一丁丁() {丁丂丝不丟丛丟一丂 = new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {}, m_Normal = new UnityEngine.Vector3() {}, m_UV = new UnityEngine.Vector2()}, 丅专与丒丈丗丒丘丌 = new UnityEngine.Vector3()});
        }
        
        label_162:
        if((0 + 1) < val_30.Length)
        {
            goto label_166;
        }
        
        val_113 = null;
        val_113 = null;
        val_114 = null;
        goto label_205;
        label_137:
        val_115 = null;
        val_115 = null;
        val_117 = UICamera.<>c.<>9__164_0;
        if(val_117 == null)
        {
                丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁> val_57 = null;
            val_117 = val_57;
            val_57 = new 丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁>(三一丄丗专丌丛丘丅:  UICamera.<>c.__il2cppRuntimeField_static_fields, 丛丌丙世专世东丕下:  System.Int32 UICamera.<>c::丅丄丑丛丕七丝七与(UICamera.丞业丐世丐世一丁丁 与丄丑丗且丗东丗一, UICamera.丞业丐世丐世一丁丁 丕丏丌丕下丁丂丁丆));
            UICamera.<>c.<>9__164_0 = val_117;
        }
        
        UICamera.丌丙丞下一下东不丏.万万丘丙丗丈丘丙丁(业丌丆丝东不丑上丗:  val_57);
        val_118 = 0;
        goto label_177;
        label_187:
        丞业丐世丐世一丁丁 val_58 = 0 + 32;
        if((UICamera.七七业丒丟丝丘不丞(万丆丟丕下丛专业与: ref  new 丞业丐世丐世一丁丁() {丟丕丞丁丝丂上丄上 = val_58, 丁丂丝不丟丛丟一丂 = new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_58, y = val_58, z = val_58}, m_Normal = new UnityEngine.Vector3() {x = val_58, y = val_58, z = val_58}, m_FaceID = val_58, m_Distance = val_58, m_UV = new UnityEngine.Vector2() {x = val_58, y = val_58}, m_Collider = val_58}, 丅专与丒丈丗丒丘丌 = new UnityEngine.Vector3() {x = val_58, y = val_58, z = val_58}, 丝三丁东丈丒世丅业 = val_58})) == true)
        {
            goto label_183;
        }
        
        val_118 = 1;
        label_177:
        val_119 = null;
        val_119 = null;
        if(UICamera.丌丙丞下一下东不丏 == null)
        {
                val_119 = null;
        }
        
        if(val_118 < (UICamera.丌丙丞下一下东不丏 + 24))
        {
            goto label_187;
        }
        
        goto label_188;
        label_205:
        val_124 = UICamera.<>c.<>9__164_1;
        if(val_124 == null)
        {
                丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁> val_64 = null;
            val_124 = val_64;
            val_64 = new 丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<丞业丐世丐世一丁丁>(三一丄丗专丌丛丘丅:  UICamera.<>c.__il2cppRuntimeField_static_fields, 丛丌丙世专世东丕下:  System.Int32 UICamera.<>c::丗丑七丌丙不丑业业(UICamera.丞业丐世丐世一丁丁 与丄丑丗且丗东丗一, UICamera.丞业丐世丐世一丁丁 丕丏丌丕下丁丂丁丆));
            UICamera.<>c.<>9__164_1 = val_124;
        }
        
        UICamera.丌丙丞下一下东不丏.万万丘丙丗丈丘丙丁(业丌丆丝东不丑上丗:  val_64);
        val_125 = 0;
        goto label_210;
        label_220:
        丞业丐世丐世一丁丁 val_65 = 0 + 32;
        if((UICamera.七七业丒丟丝丘不丞(万丆丟丕下丛专业与: ref  new 丞业丐世丐世一丁丁() {丟丕丞丁丝丂上丄上 = val_65, 丁丂丝不丟丛丟一丂 = new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_65, y = val_65, z = val_65}, m_Normal = new UnityEngine.Vector3() {x = val_65, y = val_65, z = val_65}, m_FaceID = val_65, m_Distance = val_65, m_UV = new UnityEngine.Vector2() {x = val_65, y = val_65}, m_Collider = val_65}, 丅专与丒丈丗丒丘丌 = new UnityEngine.Vector3() {x = val_65, y = val_65, z = val_65}, 丝三丁东丈丒世丅业 = val_65})) == true)
        {
            goto label_216;
        }
        
        val_125 = 1;
        label_210:
        val_119 = null;
        val_119 = null;
        if(UICamera.丌丙丞下一下东不丏 == null)
        {
                val_119 = null;
        }
        
        if(val_125 < (UICamera.丌丙丞下一下东不丏 + 24))
        {
            goto label_220;
        }
        
        label_188:
        val_119 = null;
        UICamera.丌丙丞下一下东不丏.世业丒万丘丆专丘丐();
        goto label_234;
        label_183:
        val_129 = null;
        val_129 = null;
        丞业丐世丐世一丁丁 val_70 = UICamera.丌丙丞下一下东不丏.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_7C = val_71;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_70 = ;
        UICamera.lastHit = ;
        UICamera.lastHitFrame = UnityEngine.Time.frameCount;
        丞业丐世丐世一丁丁 val_73 = UICamera.丌丙丞下一下东不丏.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        UICamera.世万丐丟专下万丂下 = val_74;
        丞业丐世丐世一丁丁 val_75 = UICamera.丌丙丞下一下东不丏.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        val_130 = null;
        UICamera.lastWorldPosition = val_76;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_5C = val_77;
        goto label_243;
        label_216:
        val_131 = null;
        val_131 = null;
        丞业丐世丐世一丁丁 val_78 = UICamera.丌丙丞下一下东不丏.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        val_130 = null;
        UICamera.世万丐丟专下万丂下 = val_79;
        label_243:
        UICamera.丌丙丞下一下东不丏.世业丒万丘丆专丘丐();
        return false;
    }
    private static bool 七七业丒丟丝丘不丞(UnityEngine.Vector3 丝丟丙不丁下专一丞, UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.Transform val_9;
        var val_10;
        UIPanel val_11;
        var val_12;
        UIPanel val_2 = 0;
        val_9 = 丝三丁东丈丒世丅业.transform;
        goto label_2;
        label_10:
        val_10 = null;
        val_10 = null;
        if((UIRoot.丅丘丝不七丝丝三丘.TryGetValue(key:  val_9, value: out  val_2)) == true)
        {
            goto label_6;
        }
        
        val_9 = val_9.parent;
        label_2:
        if(val_9 != 0)
        {
            goto label_10;
        }
        
        label_6:
        val_11 = val_2;
        goto label_11;
        label_17:
        val_11 = val_2.parentPanel;
        label_11:
        if(val_11 == 0)
        {
            goto label_15;
        }
        
        val_11 = val_11;
        if((val_11.IsVisible(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 丝丟丙不丁下专一丞.x, y = 丝丟丙不丁下专一丞.y, z = 丝丟丙不丁下专一丞.z})) == true)
        {
            goto label_17;
        }
        
        val_12 = 0;
        return (bool)val_12;
        label_15:
        val_12 = 1;
        return (bool)val_12;
    }
    private static bool 七七业丒丟丝丘不丞(ref UICamera.丞业丐世丐世一丁丁 万丆丟丕下丛专业与)
    {
        UnityEngine.Transform val_9;
        var val_10;
        UIPanel val_11;
        var val_12;
        UIPanel val_2 = 0;
        val_9 = 万丆丟丕下丛专业与.丝三丁东丈丒世丅业.transform;
        goto label_2;
        label_10:
        val_10 = null;
        val_10 = null;
        if((UIRoot.丅丘丝不七丝丝三丘.TryGetValue(key:  val_9, value: out  val_2)) == true)
        {
            goto label_6;
        }
        
        val_9 = val_9.parent;
        label_2:
        if(val_9 != 0)
        {
            goto label_10;
        }
        
        label_6:
        val_11 = val_2;
        goto label_11;
        label_17:
        val_11 = val_2.parentPanel;
        label_11:
        if(val_11 == 0)
        {
            goto label_15;
        }
        
        if((val_11.IsVisible(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 万丆丟丕下丛专业与.丅专与丒丈丗丒丘丌.x, y = 万丆丟丕下丛专业与.丅专与丒丈丗丒丘丌.y, z = 万丆丟丕下丛专业与.丅专与丒丈丗丒丘丌.z})) == true)
        {
            goto label_17;
        }
        
        val_12 = 0;
        return (bool)val_12;
        label_15:
        val_12 = 1;
        return (bool)val_12;
    }
    public static bool IsHighlighted(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        return UnityEngine.Object.op_Equality(x:  UICamera.hoveredObject, y:  丝三丁东丈丒世丅业);
    }
    public static UICamera FindCameraForLayer(int 且丅丟丛丛万丝下上)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = 0;
        goto label_1;
        label_16:
        val_9 = null;
        val_9 = null;
        var val_3 = (UICamera.list + 16) + 0;
        val_10 = mem[(UICamera.list + 16 + 0) + 32];
        val_10 = (UICamera.list + 16 + 0) + 32;
        UnityEngine.Camera val_4 = val_10.cachedCamera;
        if(val_4 != 0)
        {
                if((val_4.cullingMask & (1 << (且丅丟丛丛万丝下上 & 31))) != 0)
        {
                return (UICamera)val_10;
        }
        
        }
        
        val_8 = 1;
        label_1:
        val_11 = null;
        val_11 = null;
        if(val_8 < (UICamera.list + 24))
        {
            goto label_16;
        }
        
        val_10 = 0;
        return (UICamera)val_10;
    }
    private static int 丈七业丄万丞丞丙万(UnityEngine.KeyCode 丞丌东丟且丒丐丑丂, UnityEngine.KeyCode 丙与丈丛丑丘丞三七)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  丞丌东丟且丒丐丑丂)) != false)
        {
                UICamera.currentKey = 丞丌东丟且丒丐丑丂;
            val_5 = 1;
            return (int)val_5;
        }
        
        val_4 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  丙与丈丛丑丘丞三七)) != false)
        {
                UICamera.currentKey = 丙与丈丛丑丘丞三七;
            val_5 = 0;
            return (int)val_5;
        }
        
        val_5 = 0;
        return (int)val_5;
    }
    private static int 丈七业丄万丞丞丙万(UnityEngine.KeyCode 三丐丕丒上业丄丏三, UnityEngine.KeyCode 丏丑丌专丆丟丕丗下, UnityEngine.KeyCode 丂丁丘丟三下上丆丁, UnityEngine.KeyCode 七业一不丙丘丘丗丟)
    {
        var val_5;
        var val_6;
        UnityEngine.KeyCode val_7;
        var val_8;
        var val_9;
        UnityEngine.KeyCode val_10;
        val_5 = null;
        val_5 = null;
        val_6 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  三丐丕丒上业丄丏三)) == false)
        {
            goto label_4;
        }
        
        val_7 = 三丐丕丒上业丄丏三;
        goto label_7;
        label_4:
        val_6 = null;
        val_8 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  丏丑丌专丆丟丕丗下)) == false)
        {
            goto label_11;
        }
        
        val_7 = 丏丑丌专丆丟丕丗下;
        label_7:
        UICamera.currentKey = val_7;
        return 1;
        label_11:
        val_8 = null;
        val_9 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  丂丁丘丟三下上丆丁)) != false)
        {
                val_10 = 丂丁丘丟三下上丆丁;
        }
        else
        {
                val_9 = null;
            if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  七业一不丙丘丘丗丟)) == false)
        {
                return 1;
        }
        
            val_10 = 七业一不丙丘丘丗丟;
        }
        
        UICamera.currentKey = val_10;
        return 1;
    }
    private static int 丈七业丄万丞丞丙万(string 世丐世丄不不丈丗丏)
    {
        var val_4;
        var val_5;
        var val_6;
        float val_7;
        float val_1 = RealTime.time;
        val_4 = null;
        val_4 = null;
        if(UICamera.丄东且丟东业丆丆丘 >= 0)
        {
                return 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  世丐世丄不不丈丗丏)) != false)
        {
                return 0;
        }
        
        val_5 = null;
        val_5 = null;
        float val_3 = UICamera.GetAxis.Invoke(丒丘丏上丙丟丑丕丈:  世丐世丄不不丈丗丏);
        if(val_3 > 0.75f)
        {
                UICamera.currentKey = 74;
            val_6 = null;
            val_7 = val_1 + 0.25f;
        }
        else
        {
                if(val_3 >= 0)
        {
                return 0;
        }
        
            UICamera.currentKey = 74;
            val_6 = null;
            val_7 = val_1 + 0.25f;
        }
        
        UICamera.丄东且丟东业丆丆丘 = val_7;
        return 0;
    }
    public static void Notify(UnityEngine.GameObject 丝三丁东丈丒世丅业, string 且丁三丙丄一世不七, object 万且万且丑丗且丌丆)
    {
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_14 = 丝三丁东丈丒世丅业;
        val_15 = null;
        val_15 = null;
        if(UICamera.丛丒丙丞且丟与丈丕 > 10)
        {
                return;
        }
        
        if((UICamera.currentScheme == 2) && (UIPopupList.isOpen != false))
        {
                val_16 = null;
            val_16 = null;
            if((UIPopupList.专三丆三与下丕丆不 + 296) == val_14)
        {
                if(UIPopupList.isOpen != false)
        {
                val_17 = null;
            val_17 = null;
            val_14 = UIPopupList.专三丆三与下丕丆不.gameObject;
        }
        
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        if(val_14.activeInHierarchy == false)
        {
                return;
        }
        
        if(丈东丛丗上业不丒三.丌丟三三丘丛一专一() >= 1)
        {
                val_18 = null;
            val_18 = null;
            if((丈东丛丗上业不丒三.与三丙且丙丄东三丆.Contains(item:  且丁三丙丄一世不七)) != false)
        {
                if((不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<ContextMenuBase>(丝三丁东丈丒世丅业:  val_14, 丕丗丆丕丈丑东丆丈:  10)) == 0)
        {
                丈东丛丗上业不丒三.丒专上丁且丑丙丗世();
        }
        
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        int val_14 = UICamera.丛丒丙丞且丟与丈丕;
        val_14 = val_14 + 1;
        UICamera.丛丒丙丞且丟与丈丕 = val_14;
        val_14.SendMessage(methodName:  且丁三丙丄一世不七, value:  万且万且丑丗且丌丆, options:  1);
        if(UICamera.七业丈丐上丁万专上 != 0)
        {
                val_20 = null;
            val_20 = null;
            if(UICamera.七业丈丐上丁万专上 != val_14)
        {
                val_21 = null;
            val_21 = null;
            val_14 = UICamera.七业丈丐上丁万专上;
            val_14.SendMessage(methodName:  且丁三丙丄一世不七, value:  万且万且丑丗且丌丆, options:  1);
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        int val_15 = UICamera.丛丒丙丞且丟与丈丕;
        val_15 = val_15 - 1;
        UICamera.丛丒丙丞且丟与丈丕 = val_15;
    }
    public static UICamera.丞上且下专丞东专世 GetMouse(int 丟丒丞丐丐丘丒丄东)
    {
        null = null;
        丞上且下专丞东专世[] val_1 = UICamera.丟万丒丛东丟丏一东 + (((long)(int)(丟丒丞丐丐丘丒丄东)) << 3);
        return (丞上且下专丞东专世)(UICamera.丟万丒丛东丟丏一东 + ((long)(int)(丟丒丞丐丐丘丒丄东)) << 3) + 32;
    }
    public static UICamera.丞上且下专丞东专世 GetTouch(int 丞丅上丏丂且下丅与, bool 丐丗丏东丘东丘丈且 = False)
    {
        System.Collections.Generic.List<丞上且下专丞东专世> val_6;
        var val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        丞上且下专丞东专世 val_10;
        var val_11;
        var val_12;
        val_6 = 丞丅上丏丂且下丅与;
        val_7 = null;
        if((val_6 & 2147483648) != 0)
        {
                return UICamera.GetMouse(丟丒丞丐丐丘丒丄东:  ~val_6);
        }
        
        val_7 = null;
        int val_1 = UICamera.丐丄与上丂丒丂东世.Count;
        if(val_1 < 1)
        {
            goto label_5;
        }
        
        val_8 = 0;
        label_10:
        val_9 = null;
        val_9 = null;
        if(UICamera.丐丄与上丂丒丂东世.Item[0] == val_6)
        {
            goto label_9;
        }
        
        val_8 = val_8 + 1;
        if(val_8 < val_1)
        {
            goto label_10;
        }
        
        label_5:
        if(丐丗丏东丘东丘丈且 == false)
        {
            goto label_11;
        }
        
        UICamera.丞上且下专丞东专世 val_3 = null;
        val_10 = val_3;
        val_3 = new UICamera.丞上且下专丞东专世();
        float val_4 = RealTime.time;
        if(val_10 == null)
        {
            goto label_12;
        }
        
        .丏丅下世上丈下丈丛 = val_4;
        goto label_13;
        label_11:
        val_10 = 0;
        return val_10;
        label_9:
        val_11 = null;
        val_11 = null;
        val_6 = UICamera.activeTouches;
        val_10 = val_6.Item[0];
        return val_10;
        label_12:
        .丏丅下世上丈下丈丛 = val_4;
        label_13:
        .丂丅丙丏丂七不丝丅 = true;
        val_12 = null;
        val_12 = null;
        UICamera.activeTouches.Add(item:  val_3);
        val_8 = UICamera.丐丄与上丂丒丂东世;
        val_8.Add(item:  val_6);
        return val_10;
    }
    public static void RemoveTouch(int 丞丅上丏丂且下丅与)
    {
        var val_3;
        System.Collections.Generic.List<System.Int32> val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = UICamera.丐丄与上丂丒丂东世;
        int val_1 = val_4.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        label_9:
        val_5 = null;
        val_5 = null;
        if(UICamera.丐丄与上丂丒丂东世.Item[0] == 丞丅上丏丂且下丅与)
        {
            goto label_8;
        }
        
        val_4 = 0 + 1;
        if(val_4 < val_1)
        {
            goto label_9;
        }
        
        return;
        label_8:
        val_6 = null;
        val_6 = null;
        UICamera.丐丄与上丂丒丂东世.RemoveAt(index:  0);
        UICamera.activeTouches.RemoveAt(index:  0);
    }
    private void Awake()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        UICamera.业丆世丄丏丕丕七不 = UnityEngine.Screen.width;
        UICamera.丙万且丝丐世下世且 = UnityEngine.Screen.height;
        UICamera.currentScheme = 1;
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        mem2[0] = val_4.x;
        mem2[0] = val_4.y;
        val_6 = null;
        do
        {
            val_6 = null;
            var val_5 = 5 - 4;
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32 + 20;
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4;
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32 + 20;
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4;
            val_7 = null;
        }
        while((5 + 1) != 7);
        
        val_7 = null;
        UICamera.专丟丆丛丁七下三丝 = UICamera.丟万丒丛东丟丏一东 + 32 + 20;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4;
    }
    private void OnEnable()
    {
        null = null;
        UICamera.list.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
        UICamera.list.万万丘丙丗丈丘丙丁(业丌丆丝东不丑上丗:  new 丒丞丕丕七丁丗丟丛.丙丝丕下业业丄且丈<UICamera>(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Int32 UICamera::丙丝丕下业业丄且丈(UICamera 丆丛丑世下一丐且丕, UICamera 丌丗丏丏丛东专丁且)));
    }
    private void OnDisable()
    {
        null = null;
        bool val_1 = UICamera.list.Remove(下丅丙一丂丗丅丝七:  this);
    }
    private void Start()
    {
        var val_15;
        var val_16;
        if(this.eventType != 0)
        {
                if(this.cachedCamera.transparencySortMode != 2)
        {
                this.cachedCamera.transparencySortMode = 2;
        }
        
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = 1152921504848912384;
        if(UICamera.fallThrough != 0)
        {
            goto label_10;
        }
        
        UIRoot val_7 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if(val_7 == 0)
        {
            goto label_15;
        }
        
        if(val_7 != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_15:
        UnityEngine.Transform val_9 = this.transform;
        val_16 = this;
        if(val_9.parent != 0)
        {
                val_16 = val_9.parent;
        }
        
        label_17:
        UICamera.fallThrough = val_16.gameObject;
        label_10:
        this.cachedCamera.eventMask = 0;
    }
    private void Update()
    {
        UICamera val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        丘丛专一上丞丑七丞 val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        val_28 = this;
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_32;
        }
        
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_32;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_32;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_32;
        }
        
        val_31 = null;
        val_31 = null;
        if(Pauser.且三丝三七七丐丁丁 == 0)
        {
            goto label_28;
        }
        
        val_32 = null;
        val_32 = null;
        if(Pauser.且三丝三七七丐丁丁.丟三东与三丒丛下东() == true)
        {
            goto label_32;
        }
        
        label_28:
        val_33 = null;
        val_33 = null;
        if(ChatViewrController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_37;
        }
        
        label_32:
        if(this != null)
        {
            goto label_126;
        }
        
        label_127:
        label_126:
        this.allowMultiTouch = false;
        if(this.三丑丏一丟与丐丕不() == false)
        {
                return;
        }
        
        val_34 = null;
        val_34 = null;
        UICamera.current = val_28;
        NGUIDebug.debugRaycast = (this.debug == true) ? 1 : 0;
        if(this.useTouch != false)
        {
                this.ProcessTouches();
        }
        else
        {
                if(this.useMouse != false)
        {
                this.ProcessMouse();
        }
        
        }
        
        val_35 = null;
        val_35 = null;
        val_36 = UICamera.onCustomInput;
        if(val_36 != null)
        {
                val_36 = UICamera.onCustomInput;
            if(val_36 == null)
        {
                val_36 = 0;
        }
        
            val_36.Invoke();
        }
        
        if(this.useKeyboard != true)
        {
                if(this.useController == false)
        {
            goto label_57;
        }
        
        }
        
        val_37 = null;
        if(UICamera.disableController != true)
        {
                this.ProcessOthers();
        }
        
        label_57:
        if(this.useMouse == false)
        {
            goto label_103;
        }
        
        val_38 = null;
        val_38 = null;
        if(UICamera.丑丁丞丑丗丏专世七 == 0)
        {
            goto label_103;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.scrollAxisName)) != true)
        {
                val_39 = null;
            val_39 = null;
            float val_16 = UICamera.GetAxis.Invoke(丒丘丏上丙丟丑丕丈:  this.scrollAxisName);
            if(val_16 != 0f)
        {
                val_40 = null;
            val_40 = null;
            if(UICamera.onScroll != null)
        {
                UICamera.onScroll.Invoke(丝三丁东丈丒世丅业:  UICamera.丑丁丞丑丗丏专世七, 丞且丅三三东不丄且:  val_16);
            val_40 = null;
        }
        
            val_40 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.丑丁丞丑丗丏专世七, 且丁三丙丄一世不七:  "OnScroll", 万且万且丑丗且丌丆:  val_16);
        }
        
        }
        
        val_41 = null;
        val_41 = null;
        if(((UICamera.showTooltips == false) || (UICamera.丙丄上丁不丏一丂丐 == 0f)) || (UIPopupList.isOpen == true))
        {
            goto label_103;
        }
        
        val_43 = null;
        val_43 = null;
        if((UICamera.丟万丒丛东丟丏一东 + 32 + 88) != 0)
        {
            goto label_103;
        }
        
        val_44 = null;
        val_44 = null;
        float val_19 = RealTime.time;
        if(UICamera.丙丄上丁不丏一丂丐 < 0)
        {
            goto label_99;
        }
        
        val_45 = null;
        val_45 = null;
        if((UICamera.GetKey.Invoke(下上丐丆丝丟丝丒不:  48)) == true)
        {
            goto label_99;
        }
        
        val_46 = null;
        val_46 = null;
        if((UICamera.GetKey.Invoke(下上丐丆丝丟丝丒不:  47)) == false)
        {
            goto label_103;
        }
        
        label_99:
        val_47 = null;
        val_47 = null;
        UICamera.currentTouch = UICamera.丟万丒丛东丟丏一东 + 32;
        UICamera.currentTouchID = 0;
        bool val_22 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  UICamera.丑丁丞丑丗丏专世七);
        label_103:
        val_48 = null;
        val_48 = null;
        val_28 = UICamera.丘丘丕丄丟一丞与且;
        if(val_28 != 0)
        {
                val_49 = null;
            val_49 = null;
            val_28 = UICamera.丘丘丕丄丟一丞与且;
            if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_28)) != true)
        {
                bool val_25 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        }
        
        }
        
        val_50 = null;
        val_50 = null;
        UICamera.current = 0;
        UICamera.currentTouchID = 99;
        return;
        label_37:
        val_51 = null;
        val_51 = null;
        if(this != null)
        {
            goto label_126;
        }
        
        goto label_127;
    }
    private void LateUpdate()
    {
        int val_4;
        var val_5;
        val_4 = this;
        if(this.三丑丏一丟与丐丕不() == false)
        {
                return;
        }
        
        if(this.世专七一丝三丑丙一 == false)
        {
                return;
        }
        
        val_4 = UnityEngine.Screen.width;
        int val_3 = UnityEngine.Screen.height;
        val_5 = null;
        val_5 = null;
        if(val_4 == UICamera.业丆世丄丏丕丕七不)
        {
                val_5 = null;
            if(val_3 == UICamera.丙万且丝丐世下世且)
        {
                return;
        }
        
        }
        
        val_5 = null;
        UICamera.业丆世丄丏丕丕七不 = val_4;
        UICamera.丙万且丝丐世下世且 = val_3;
        UIRoot.Broadcast(且丁三丙丄一世不七:  "UpdateAnchors");
        if(UICamera.onScreenResize == null)
        {
                return;
        }
        
        0.Invoke();
    }
    private void OnApplicationPause(bool 世下丐丌一丗一丞丌)
    {
        if(世下丐丌一丗一丞丌 != false)
        {
                this.世专七一丝三丑丙一 = false;
            return;
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "ReturnAccesToScreenSize");
    }
    private System.Collections.IEnumerator ReturnAccesToScreenSize()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UICamera.丈丟丟与丂专丘业世(丗丏丅丕丆世丁专丟:  0);
    }
    public void ProcessMouse()
    {
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        float val_29;
        var val_31;
        float val_32;
        float val_33;
        var val_34;
        丞上且下专丞东专世 val_35;
        int val_36;
        var val_37;
        丞上且下专丞东专世 val_38;
        float val_39;
        var val_40;
        var val_41;
        float val_42;
        var val_43;
        var val_44;
        var val_46;
        var val_47;
        var val_48;
        丞上且下专丞东专世 val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_54;
        var val_55;
        丈世丗丄丟丒下丗丁 val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_64;
        var val_65;
        var val_66;
        val_25 = this;
        val_26 = 0;
        val_27 = 0;
        var val_34 = 0;
        label_8:
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_1;
        }
        
        UICamera.currentKey = val_34 + 323;
        val_27 = 1;
        goto label_4;
        label_1:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_5;
        }
        
        UICamera.currentKey = val_34 + 323;
        label_4:
        val_26 = 1;
        label_5:
        val_34 = val_34 + 1;
        if(val_34 != 3)
        {
            goto label_8;
        }
        
        if(UICamera.currentScheme == 1)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        UICamera.currentTouch = UICamera.丟万丒丛东丟丏一东 + 32;
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        val_29 = val_6.x;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29, y = val_6.y, z = val_6.z});
        val_31 = null;
        val_32 = val_7.x;
        val_33 = val_7.y;
        if(UICamera.currentTouch == null)
        {
                val_31 = null;
        }
        
        if((UICamera.丟万丒丛东丟丏一东 + 32.七丄丟丙世东丁下丒) == 0)
        {
            goto label_19;
        }
        
        val_34 = null;
        val_35 = UICamera.currentTouch;
        if(val_35 == null)
        {
            goto label_22;
        }
        
        val_36 = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 116];
        val_36 = UICamera.丟万丒丛东丟丏一东 + 32.七丄丟丙世东丁下丒;
        goto label_23;
        label_19:
        val_37 = null;
        val_38 = UICamera.currentTouch;
        val_29 = val_32;
        val_39 = val_33;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_29, y = val_39}, b:  new UnityEngine.Vector2() {x = UICamera.丟万丒丛东丟丏一东 + 32.下业丕七东丌丝下且, y = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4]});
        丞且丅三三东不丄且 = val_8;
        goto label_29;
        label_22:
        val_35 = 116;
        val_36 = 0;
        val_34 = null;
        label_23:
        mem[116] = -1;
        if(UICamera.currentTouch == null)
        {
                val_34 = null;
        }
        
        丞且丅三三东不丄且 = 0;
        val_38 = UICamera.currentTouch;
        if(val_38 == null)
        {
            goto label_68;
        }
        
        val_39 = 0f;
        label_29:
        mem2[0] = val_39;
        val_40 = null;
        val_40 = null;
        float val_9 = new UnityEngine.Vector2().sqrMagnitude;
        val_41 = null;
        if(UICamera.currentTouch == null)
        {
                val_41 = null;
        }
        
        下业丕七东丌丝下且 = val_7;
        mem2[0] = val_33;
        UICamera.专丟丆丛丁七下三丝 = val_32;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = val_33;
        val_42 = 0.001f;
        if(UICamera.currentScheme == 0)
        {
            goto label_36;
        }
        
        if(val_9 < 0)
        {
                return;
        }
        
        UICamera.currentKey = 67;
        goto label_40;
        label_36:
        if(val_9 <= val_42)
        {
            goto label_41;
        }
        
        label_40:
        val_43 = 1;
        goto label_42;
        label_41:
        val_43 = 0;
        label_42:
        do
        {
            val_44 = null;
            val_44 = null;
            var val_11 = 5 - 4;
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32.下业丕七东丌丝下且;
            mem2[0] = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4];
            mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32.丞且丅三三东不丄且;
            mem2[0] = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 36 + 4];
        }
        while((5 + 1) != 7);
        
        if(((val_26 | val_43) & 1) != 0)
        {
            goto label_54;
        }
        
        val_32 = this.丏世下丏丂丕丙丐世;
        float val_14 = RealTime.time;
        if(val_32 >= 0)
        {
            goto label_55;
        }
        
        label_54:
        val_42 = RealTime.time + 0.02f;
        this.丏世下丏丂丕丙丐世 = val_42;
        val_46 = null;
        val_46 = null;
        UICamera.Raycast(丟下丙丆不东一与丅:  UICamera.currentTouch);
        var val_35 = 0;
        do
        {
            val_47 = null;
            val_47 = null;
            val_35 = val_35 + 1;
            UICamera.GetKey.__unknownFiledOffset_48 = UICamera.丟万丒丛东丟丏一东 + 32.上丞丕专丈业丁世专;
        }
        while(val_35 != 3);
        
        label_55:
        val_48 = null;
        val_48 = null;
        val_49 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_67;
        }
        
        val_49 = UICamera.currentTouch;
        if(val_49 == null)
        {
            goto label_68;
        }
        
        label_67:
        bool val_16 = UnityEngine.Object.op_Inequality(x:  UICamera.丟万丒丛东丟丏一东 + 32.丙丕丛丒丁丐丒丕丕, y:  UICamera.丟万丒丛东丟丏一东 + 32.上丞丕专丈业丁世专);
        bool val_17 = UnityEngine.Object.op_Inequality(x:  UICamera.丟万丒丛东丟丏一东 + 32.万东丂丒且丅丛丑丕, y:  0);
        if(val_17 != true)
        {
                val_50 = null;
            val_50 = null;
            UICamera.hoveredObject = UICamera.丟万丒丛东丟丏一东 + 32.上丞丕专丈业丁世专;
        }
        
        val_51 = null;
        val_51 = null;
        UICamera.currentTouchID = 0;
        if(val_16 != false)
        {
                UICamera.currentKey = 67;
        }
        
        var val_18 = val_26 ^ 1;
        val_18 = val_43 & val_18;
        if(val_18 != 1)
        {
            goto label_90;
        }
        
        var val_19 = (this.stickyTooltip == false) ? 1 : 0;
        val_19 = val_16 | val_19;
        if(val_19 == false)
        {
            goto label_90;
        }
        
        val_52 = null;
        val_52 = null;
        val_42 = UICamera.丙丄上丁不丏一丂丐;
        if(val_42 != 0f)
        {
            goto label_85;
        }
        
        if(UICamera.丘丘丕丄丟一丞与且 == 0)
        {
            goto label_90;
        }
        
        bool val_21 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        if(val_43 != 0)
        {
            goto label_93;
        }
        
        goto label_100;
        label_85:
        val_54 = null;
        val_33 = this.丗丙业丁丗丏丛一丅;
        val_32 = UnityEngine.Time.unscaledTime;
        val_54 = null;
        val_42 = val_32 + val_33;
        UICamera.丙丄上丁不丏一丂丐 = val_42;
        label_90:
        if(val_43 == 0)
        {
            goto label_100;
        }
        
        label_93:
        val_55 = null;
        val_55 = null;
        val_57 = UICamera.onMouseMove;
        if(val_57 != null)
        {
                val_57 = UICamera.onMouseMove;
            val_32 = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 36];
            val_32 = UICamera.丟万丒丛东丟丏一东 + 32.丞且丅三三东不丄且;
            val_42 = val_32;
            val_57.Invoke(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_42, y = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 36 + 4]});
            UICamera.currentTouch = 0;
        }
        
        label_100:
        if(val_16 != false)
        {
                if((val_26 | (~val_17)) != false)
        {
                if((val_27 ^ 1 & 1) != 0)
        {
            goto label_107;
        }
        
        }
        
            UICamera.hoveredObject = 0;
        }
        
        label_107:
        UnityEngine.KeyCode val_36 = 0;
        int val_37 = 0;
        label_133:
        bool val_25 = UnityEngine.Input.GetMouseButtonDown(button:  0);
        bool val_26 = UnityEngine.Input.GetMouseButtonUp(button:  0);
        if(val_25 != true)
        {
                if(val_26 == false)
        {
            goto label_111;
        }
        
        }
        
        UICamera.currentKey = val_36 + 323;
        label_111:
        val_58 = null;
        val_58 = null;
        val_36 = val_36 + 323;
        UICamera.currentTouch = UICamera.__il2cppRuntimeField_cctor_finished + 32;
        UICamera.currentTouchID = val_37;
        UICamera.currentKey = val_36;
        val_59 = null;
        if(val_25 != false)
        {
                val_60 = null;
            val_60 = null;
            丗丗世丂丌丆东下丄 = UICamera.currentCamera;
            val_32 = RealTime.time;
            丏丅下世上丈下丈丛 = val_32;
        }
        else
        {
                val_61 = null;
            if((UICamera.__il2cppRuntimeField_cctor_finished + 32.万东丂丒且丅丛丑丕) != 0)
        {
                val_62 = null;
            val_62 = null;
            UICamera.currentCamera = UICamera.__il2cppRuntimeField_cctor_finished + 32.丗丗世丂丌丆东下丄;
        }
        
        }
        
        this.ProcessTouch(万东丂丒且丅丛丑丕:  val_25, 丗丏丐世专七与三上:  val_26);
        val_27 = val_36 - 322;
        val_37 = val_37 - 1;
        if(val_27 != 3)
        {
            goto label_133;
        }
        
        var val_38 = val_18;
        val_38 = val_16 & val_38;
        if(val_38 != false)
        {
                val_64 = null;
            val_64 = null;
            UICamera.currentTouch = UICamera.丟万丒丛东丟丏一东 + 32;
            float val_32 = RealTime.time;
            val_32 = val_32 + this.丗丙业丁丗丏丛一丅;
            UICamera.丙丄上丁不丏一丂丐 = val_32;
            UICamera.currentTouchID = 0;
            UICamera.currentKey = 67;
            UICamera.hoveredObject = UICamera.丟万丒丛东丟丏一东 + 32.上丞丕专丈业丁世专;
        }
        
        val_65 = null;
        val_65 = null;
        UICamera.currentTouch = 0;
        mem2[0] = UICamera.丟万丒丛东丟丏一东 + 32 + 72;
        do
        {
            val_66 = null;
            val_66 = null;
            var val_33 = 5 - 4;
            val_38 = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 64];
            val_38 = UICamera.丟万丒丛东丟丏一东 + 32 + 64;
            val_25 = 5 + 1;
            mem2[0] = val_38;
        }
        while(val_25 != 7);
        
        return;
        label_68:
    }
    public void GamepadClickProcess()
    {
        丞上且下专丞东专世 val_29;
        GamepadCursorController val_30;
        var val_31;
        var val_32;
        var val_33;
        float val_34;
        float val_36;
        float val_37;
        var val_38;
        var val_39;
        丞上且下专丞东专世 val_40;
        int val_41;
        var val_42;
        丞上且下专丞东专世 val_43;
        float val_44;
        var val_45;
        var val_46;
        float val_47;
        var val_48;
        var val_49;
        var val_51;
        var val_52;
        丞上且下专丞东专世 val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_58;
        var val_59;
        丈世丗丄丟丒下丗丁 val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_68;
        var val_69;
        UnityEngine.GameObject val_70;
        val_29 = this;
        if(GamepadCursorController.丂业丗业世世丛丟七() == false)
        {
                return;
        }
        
        val_30 = GamepadCursorController.丆丕丝丒不丙且丐丗;
        bool val_2 = val_30.世丆且丌下丌丟世丌();
        if(val_2 == false)
        {
            goto label_3;
        }
        
        UICamera.currentKey = 73;
        val_31 = 0;
        goto label_6;
        label_3:
        if(val_30.丌丘丙丒丅丆三不东() == false)
        {
            goto label_8;
        }
        
        UICamera.currentKey = 73;
        val_31 = 1;
        label_6:
        val_32 = 1;
        goto label_11;
        label_8:
        val_32 = 0;
        val_31 = 1;
        label_11:
        if(UICamera.currentScheme == 1)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        UICamera.currentTouch = UICamera.controller;
        UnityEngine.Vector3 val_6 = 丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_7 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_34 = val_7.x;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_34, y = val_7.y, z = val_7.z});
        val_36 = val_8.x;
        val_37 = val_8.y;
        UICamera.currentScheme = 2;
        val_38 = null;
        if(UICamera.currentTouch == null)
        {
                val_38 = null;
        }
        
        if(UICamera.controller.七丄丟丙世东丁下丒 == 0)
        {
            goto label_25;
        }
        
        val_39 = null;
        val_40 = UICamera.currentTouch;
        if(val_40 == null)
        {
            goto label_28;
        }
        
        val_41 = mem[UICamera.controller + 116];
        val_41 = UICamera.controller.七丄丟丙世东丁下丒;
        goto label_29;
        label_25:
        val_42 = null;
        val_43 = UICamera.currentTouch;
        val_34 = val_36;
        val_44 = val_37;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_34, y = val_44}, b:  new UnityEngine.Vector2() {x = UICamera.controller.下业丕七东丌丝下且, y = mem[UICamera.controller + 20 + 4]});
        丞且丅三三东不丄且 = val_9;
        goto label_35;
        label_28:
        val_40 = 116;
        val_41 = 0;
        val_39 = null;
        label_29:
        mem[116] = -1;
        if(UICamera.currentTouch == null)
        {
                val_39 = null;
        }
        
        丞且丅三三东不丄且 = 0;
        val_43 = UICamera.currentTouch;
        if(val_43 == null)
        {
            goto label_63;
        }
        
        val_44 = 0f;
        label_35:
        mem2[0] = val_44;
        val_45 = null;
        val_45 = null;
        float val_10 = new UnityEngine.Vector2().sqrMagnitude;
        val_46 = null;
        if(UICamera.currentTouch == null)
        {
                val_46 = null;
        }
        
        下业丕七东丌丝下且 = val_8;
        mem2[0] = val_37;
        UICamera.专丟丆丛丁七下三丝 = val_36;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = val_37;
        val_47 = 0.001f;
        if(UICamera.currentScheme != 2)
        {
            goto label_42;
        }
        
        if(val_10 > val_47)
        {
            goto label_43;
        }
        
        val_48 = 0;
        goto label_44;
        label_42:
        if(val_10 < 0)
        {
                return;
        }
        
        UICamera.currentKey = 73;
        label_43:
        val_48 = 1;
        label_44:
        val_49 = null;
        val_49 = null;
        UICamera.controller.下业丕七东丌丝下且 = UICamera.controller.下业丕七东丌丝下且;
        UICamera.controller.__unknownFiledOffset_18 = mem[UICamera.controller + 20 + 4];
        UICamera.controller.丞且丅三三东不丄且 = UICamera.controller.丞且丅三三东不丄且;
        UICamera.controller.__unknownFiledOffset_28 = mem[UICamera.controller + 36 + 4];
        if(((val_32 | val_48) & 1) != 0)
        {
            goto label_54;
        }
        
        val_36 = this.丏世下丏丂丕丙丐世;
        float val_13 = RealTime.time;
        if(val_36 >= 0)
        {
            goto label_55;
        }
        
        label_54:
        val_47 = RealTime.time + 0.02f;
        this.丏世下丏丂丕丙丐世 = val_47;
        val_51 = null;
        val_51 = null;
        UICamera.Raycast(丟下丙丆不东一与丅:  UICamera.currentTouch);
        UICamera.controller.上丞丕专丈业丁世专 = UICamera.controller.上丞丕专丈业丁世专;
        label_55:
        val_52 = null;
        val_52 = null;
        val_53 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_62;
        }
        
        val_53 = UICamera.currentTouch;
        if(val_53 == null)
        {
            goto label_63;
        }
        
        label_62:
        bool val_15 = UnityEngine.Object.op_Inequality(x:  UICamera.controller.丙丕丛丒丁丐丒丕丕, y:  UICamera.controller.上丞丕专丈业丁世专);
        bool val_16 = UnityEngine.Object.op_Inequality(x:  UICamera.controller.万东丂丒且丅丛丑丕, y:  0);
        if(val_16 != true)
        {
                val_54 = null;
            val_54 = null;
            UICamera.hoveredObject = UICamera.controller.上丞丕专丈业丁世专;
        }
        
        val_55 = null;
        val_55 = null;
        UICamera.currentTouchID = 542;
        if(val_15 != false)
        {
                UICamera.currentKey = 73;
        }
        
        val_32 = val_32 ^ 1;
        if((val_48 & val_32) != 1)
        {
            goto label_85;
        }
        
        var val_18 = (this.stickyTooltip == false) ? 1 : 0;
        val_18 = val_15 | val_18;
        if(val_18 == false)
        {
            goto label_85;
        }
        
        val_56 = null;
        val_56 = null;
        val_47 = UICamera.丙丄上丁不丏一丂丐;
        if(val_47 != 0f)
        {
            goto label_80;
        }
        
        if(UICamera.丘丘丕丄丟一丞与且 == 0)
        {
            goto label_85;
        }
        
        bool val_20 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        if(val_48 != 0)
        {
            goto label_88;
        }
        
        goto label_95;
        label_80:
        val_58 = null;
        val_37 = this.丗丙业丁丗丏丛一丅;
        val_36 = UnityEngine.Time.unscaledTime;
        val_58 = null;
        val_47 = val_36 + val_37;
        UICamera.丙丄上丁不丏一丂丐 = val_47;
        label_85:
        if(val_48 == 0)
        {
            goto label_95;
        }
        
        label_88:
        val_59 = null;
        val_59 = null;
        val_61 = UICamera.onMouseMove;
        if(val_61 != null)
        {
                val_61 = UICamera.onMouseMove;
            val_36 = mem[UICamera.controller + 36];
            val_36 = UICamera.controller.丞且丅三三东不丄且;
            val_47 = val_36;
            val_61.Invoke(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_47, y = mem[UICamera.controller + 36 + 4]});
            UICamera.currentTouch = 0;
        }
        
        label_95:
        if(val_15 != false)
        {
                bool val_22 = val_16 ^ 1;
            val_22 = val_32 | val_22;
            val_22 = val_31 & val_22;
            if(val_22 != true)
        {
                UICamera.hoveredObject = 0;
        }
        
        }
        
        val_30 = val_30.丈丅丗丕上丏丂丛丟();
        if((val_2 | val_30) != false)
        {
                UICamera.currentKey = 73;
        }
        
        val_62 = null;
        val_62 = null;
        UICamera.currentTouch = UICamera.controller;
        UICamera.currentTouchID = 542;
        UICamera.currentKey = 73;
        val_63 = null;
        if(val_2 != false)
        {
                val_64 = null;
            if(UICamera.currentTouch == null)
        {
                val_64 = null;
        }
        
            丗丗世丂丌丆东下丄 = UICamera.currentCamera;
            val_43 = UICamera.currentTouch;
            val_36 = RealTime.time;
            丏丅下世上丈下丈丛 = val_36;
        }
        else
        {
                val_65 = null;
            val_43 = mem[UICamera.controller + 80];
            val_43 = UICamera.controller.万东丂丒且丅丛丑丕;
            if(val_43 != 0)
        {
                val_66 = null;
            val_66 = null;
            val_43 = UICamera.currentTouch;
            UICamera.currentCamera = UICamera.controller.丗丗世丂丌丆东下丄;
        }
        
        }
        
        this.ProcessTouch(万东丂丒且丅丛丑丕:  val_2, 丗丏丐世专七与三上:  val_30);
        if((val_15 & val_32) == true)
        {
                val_68 = null;
            val_68 = null;
            UICamera.currentTouch = UICamera.controller;
            float val_30 = RealTime.time;
            val_30 = val_30 + this.丗丙业丁丗丏丛一丅;
            UICamera.丙丄上丁不丏一丂丐 = val_30;
            UICamera.currentTouchID = 542;
            UICamera.currentKey = 73;
            UICamera.hoveredObject = UICamera.controller.上丞丕专丈业丁世专;
        }
        
        val_69 = null;
        val_69 = null;
        UICamera.currentTouch = 0;
        val_29 = UICamera.controller;
        if(val_29 != null)
        {
                val_70 = mem[UICamera.controller + 72];
            val_70 = UICamera.controller.上丞丕专丈业丁世专;
        }
        else
        {
                val_70 = 0;
        }
        
        UICamera.controller.丙丕丛丒丁丐丒丕丕 = val_70;
        return;
        label_63:
    }
    public void ProcessTouches()
    {
        UICamera val_22;
        var val_23;
        丕丗丐丄上一丙丙丘 val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        丕丘丄丈丛丟上三不 val_30;
        int val_31;
        UnityEngine.TouchPhase val_32;
        UnityEngine.Vector2 val_33;
        float val_34;
        int val_35;
        float val_36;
        float val_37;
        var val_38;
        bool val_39;
        var val_40;
        float val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        丞上且下专丞东专世 val_46;
        var val_47;
        var val_48;
        UnityEngine.Camera val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        val_22 = this;
        val_23 = null;
        val_23 = null;
        val_24 = UICamera.GetInputTouchCount;
        if(val_24 != null)
        {
                val_24 = UICamera.GetInputTouchCount;
            if(val_24 == null)
        {
                val_24 = 0;
        }
        
            val_25 = val_24;
            int val_1 = val_25.Invoke();
        }
        else
        {
                val_25 = 0;
        }
        
        val_26 = UnityEngine.Input.touchCount;
        if(val_26 <= 0)
        {
            goto label_8;
        }
        
        val_27 = null;
        val_28 = 1152921504850403328;
        val_29 = 0;
        label_83:
        val_27 = null;
        val_30 = UICamera.GetInputTouch;
        if(val_30 == null)
        {
            goto label_11;
        }
        
        val_30 = UICamera.GetInputTouch;
        if(val_30 == null)
        {
                val_30 = 0;
        }
        
        if((val_30.Invoke(丞世不丒下上上丝丑:  0)) == null)
        {
            goto label_15;
        }
        
        val_31 = val_3.上丕且丅丝业丏丗丐;
        val_32 = val_3.丕丙丒丟业与万丆丂;
        val_33 = val_3.业丒丝丗与丐丛丟丏;
        goto label_16;
        label_11:
        UnityEngine.Touch val_4 = UnityEngine.Input.GetTouch(index:  0);
        val_32 = 专三三与三且一且一();
        val_31 = 丙东专丂世丈丏丁丂();
        val_33 = V0.16B;
        val_34 = V1.16B;
        val_35 = 丏丘丑丈专丈丁丏世();
        float val_8 = distance;
        val_36 = val_8;
        val_37 = val_8;
        goto label_17;
        label_15:
        val_32 = 1;
        val_31 = 11993091;
        val_33 = 6.606506E-38f;
        val_34 = 0f;
        label_16:
        val_35 = val_3.且下且丁丑下丌上丘;
        val_36 = 0f;
        val_37 = 1f;
        label_17:
        val_38 = null;
        val_38 = null;
        val_39 = 1;
        UICamera.currentTouchID = (this.allowMultiTouch == true) ? (val_31) : (0 + 1);
        val_40 = null;
        UICamera.currentTouch = UICamera.GetTouch(丞丅上丏丂且下丅与:  UICamera.currentTouchID, 丐丗丏东丘东丘丈且:  true);
        if(val_32 != 0)
        {
                val_40 = null;
            if(UICamera.currentTouch == null)
        {
                val_40 = null;
        }
        
            val_39 = mem[val_10 + 112];
            val_39 = val_10.丂丅丙丏丂七不丝丅;
        }
        
        val_40 = null;
        if(UICamera.currentTouch == null)
        {
                val_40 = null;
        }
        
        丂丅丙丏丂七不丝丅 = false;
        val_41 = val_33;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_33, y = val_34}, b:  new UnityEngine.Vector2() {x = val_10.下业丕七东丌丝下且, y = mem[val_10 + 20 + 4]});
        丞且丅三三东不丄且 = val_11;
        mem2[0] = val_11.y;
        下业丕七东丌丝下且 = val_33;
        mem2[0] = val_34;
        UICamera.currentKey = 0;
        val_42 = null;
        if(UICamera.currentTouch == null)
        {
                val_42 = null;
        }
        
        丐丒不丅下丒丑丒丟 = val_36;
        if(UICamera.currentTouch == null)
        {
                val_42 = null;
        }
        
        丗与丟丘七丈丒丆丑 = val_37;
        UICamera.Raycast(丟下丙丆不东一与丅:  UICamera.currentTouch);
        var val_12 = val_32 - 3;
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() == false)
        {
            goto label_47;
        }
        
        if(与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌() != true)
        {
                if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == false)
        {
            goto label_47;
        }
        
        }
        
        val_43 = null;
        val_43 = null;
        if(val_10.上丞丕专丈业丁世专 == 0)
        {
            goto label_47;
        }
        
        val_44 = null;
        val_44 = null;
        val_41 = 0f;
        if(val_12 < 2)
        {
            goto label_51;
        }
        
        val_45 = null;
        val_45 = null;
        val_46 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_54;
        }
        
        val_46 = UICamera.currentTouch;
        if(val_46 == null)
        {
            goto label_55;
        }
        
        label_54:
        val_41 = val_10.丐丒不丅下丒丑丒丟 / val_10.丗与丟丘七丈丒丆丑;
        label_51:
        UICamera.Notify(丝三丁东丈丒世丅业:  val_10.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnPressure", 万且万且丑丗且丌丆:  val_41);
        val_28 = val_28;
        val_26 = val_26;
        val_22 = val_22;
        label_47:
        val_47 = null;
        if(val_39 == false)
        {
            goto label_58;
        }
        
        val_48 = null;
        val_49 = UICamera.currentCamera;
        if(UICamera.currentTouch != null)
        {
            goto label_62;
        }
        
        goto label_62;
        label_58:
        val_51 = null;
        val_49 = mem[val_10 + 80];
        val_49 = val_10.万东丂丒且丅丛丑丕;
        if(val_49 == 0)
        {
            goto label_68;
        }
        
        val_52 = null;
        val_52 = null;
        val_49 = mem[val_10 + 56];
        val_49 = val_10.丗丗世丂丌丆东下丄;
        val_50 = 1152921505096626328;
        label_62:
        UICamera.currentCamera = val_49;
        label_68:
        if(val_35 >= 2)
        {
                val_54 = null;
            val_54 = null;
            val_33 = RealTime.time;
            业三丂丌丅丘且不世 = val_33;
        }
        
        this.ProcessTouch(万东丂丒且丅丛丑丕:  (val_39 == true) ? 1 : 0, 丗丏丐世专七与三上:  (val_12 < 2) ? 1 : 0);
        if(val_12 <= 1)
        {
                val_55 = null;
            val_55 = null;
            UICamera.RemoveTouch(丞丅上丏丂且下丅与:  UICamera.currentTouchID);
        }
        
        val_56 = null;
        val_56 = null;
        if(UICamera.currentTouch == null)
        {
                val_56 = null;
        }
        
        丙丕丛丒丁丐丒丕丕 = 0;
        UICamera.currentTouch = 0;
        if(this.allowMultiTouch == false)
        {
            goto label_84;
        }
        
        val_29 = val_29 + 1;
        if(val_29 < val_26)
        {
            goto label_83;
        }
        
        goto label_84;
        label_8:
        val_56 = null;
        label_84:
        if(val_26 != 0)
        {
                val_57 = null;
            UICamera.丞丅丟下万万丟与七 = true;
            return;
        }
        
        val_58 = null;
        if(UICamera.丞丅丟下万万丟与七 != false)
        {
                UICamera.丞丅丟下万万丟与七 = false;
            return;
        }
        
        if(GamepadCursorController.丂业丗业世世丛丟七() != false)
        {
                if(GamepadCursorController.丂业丗业世世丛丟七() == false)
        {
                return;
        }
        
            this.GamepadClickProcess();
            return;
        }
        
        if(this.useMouse == false)
        {
                return;
        }
        
        this.ProcessMouse();
        return;
        label_55:
    }
    private void 丌丞丄丂丘丘丅丛丕()
    {
        丞上且下专丞东专世 val_13;
        var val_14;
        var val_15;
        丞上且下专丞东专世 val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.Camera val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        val_13 = this;
        bool val_1 = UnityEngine.Input.GetMouseButtonDown(button:  0);
        bool val_2 = UnityEngine.Input.GetMouseButtonUp(button:  0);
        if((val_1 != true) && (val_2 != true))
        {
                if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        UICamera.currentTouchID = 1;
        UICamera.currentTouch = UICamera.丟万丒丛东丟丏一东 + 32;
        丂丅丙丏丂七不丝丅 = val_1;
        if(val_1 != false)
        {
                val_15 = null;
            val_15 = null;
            丏丅下世上丈下丈丛 = RealTime.time;
            val_16 = UICamera.currentTouch;
            UICamera.activeTouches.Add(item:  val_16);
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_17 = null;
        val_17 = null;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = UICamera.丟万丒丛东丟丏一东 + 32.下业丕七东丌丝下且, y = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 20 + 4]});
        丞且丅三三东不丄且 = val_8;
        mem2[0] = val_8.y;
        val_18 = null;
        if(UICamera.currentTouch == null)
        {
                val_18 = null;
        }
        
        下业丕七东丌丝下且 = val_7;
        mem2[0] = val_7.y;
        UICamera.Raycast(丟下丙丆不东一与丅:  UICamera.currentTouch);
        val_19 = null;
        if(val_1 == false)
        {
            goto label_21;
        }
        
        val_20 = null;
        val_16 = UICamera.currentTouch;
        val_21 = UICamera.currentCamera;
        if(val_16 != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_21:
        val_23 = null;
        if((UICamera.丟万丒丛东丟丏一东 + 32.万东丂丒且丅丛丑丕) == 0)
        {
            goto label_31;
        }
        
        val_24 = null;
        val_24 = null;
        val_21 = mem[UICamera.丟万丒丛东丟丏一东 + 32 + 56];
        val_21 = UICamera.丟万丒丛东丟丏一东 + 32.丗丗世丂丌丆东下丄;
        val_22 = 1152921505096626328;
        label_25:
        UICamera.currentCamera = val_21;
        label_31:
        UICamera.currentKey = 0;
        this.ProcessTouch(万东丂丒且丅丛丑丕:  val_1, 丗丏丐世专七与三上:  val_2);
        if(val_2 != false)
        {
                val_26 = null;
            val_26 = null;
            bool val_12 = UICamera.activeTouches.Remove(item:  UICamera.currentTouch);
        }
        
        val_27 = null;
        val_27 = null;
        val_13 = UICamera.currentTouch;
        if(val_13 == null)
        {
                val_27 = null;
        }
        
        丙丕丛丒丁丐丒丕丕 = 0;
        UICamera.currentTouch = 0;
    }
    public void ProcessOthers()
    {
        var val_41;
        UnityEngine.KeyCode val_42;
        UnityEngine.KeyCode val_43;
        var val_44;
        var val_45;
        UnityEngine.KeyCode val_46;
        var val_47;
        var val_48;
        UnityEngine.KeyCode val_49;
        var val_50;
        UnityEngine.KeyCode val_51;
        var val_52;
        var val_53;
        UnityEngine.KeyCode val_54;
        var val_55;
        UnityEngine.GameObject val_56;
        var val_57;
        float val_59;
        var val_60;
        丞上且下专丞东专世 val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        丏丆丈丄丑丛丄业丅 val_69;
        var val_70;
        丏丆丈丄丑丛丄业丅 val_72;
        float val_73;
        var val_74;
        var val_75;
        var val_76;
        一丑下丄丝不丆三三 val_78;
        var val_79;
        丏丝丗业三丌丏与世 val_80;
        var val_81;
        string val_82;
        var val_83;
        var val_84;
        var val_85;
        丏丆丈丄丑丛丄业丅 val_87;
        var val_88;
        var val_89;
        val_41 = null;
        val_41 = null;
        UICamera.currentTouchID = 99;
        UICamera.currentTouch = UICamera.controller;
        val_42 = this.submitKey0;
        if(val_42 == 0)
        {
            goto label_3;
        }
        
        val_41 = null;
        val_42 = this.submitKey0;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  val_42)) == true)
        {
            goto label_7;
        }
        
        label_3:
        val_43 = this.submitKey1;
        if(val_43 == 0)
        {
            goto label_12;
        }
        
        val_44 = null;
        val_44 = null;
        val_43 = this.submitKey1;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  val_43)) == false)
        {
            goto label_12;
        }
        
        val_45 = null;
        val_46 = this.submitKey1;
        goto label_22;
        label_12:
        if(this.submitKey0 != 13)
        {
                if(this.submitKey1 != 13)
        {
            goto label_16;
        }
        
        }
        
        val_47 = null;
        val_47 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  15)) == false)
        {
            goto label_20;
        }
        
        label_7:
        val_45 = null;
        val_46 = this.submitKey0;
        label_22:
        UICamera.currentKey = val_46;
        val_48 = 1;
        goto label_23;
        label_20:
        val_48 = 0;
        label_23:
        val_49 = this.submitKey0;
        if(val_49 == 0)
        {
            goto label_195;
        }
        
        label_194:
        val_50 = null;
        val_50 = null;
        val_49 = this.submitKey0;
        if((UICamera.GetKeyUp.Invoke(下上丐丆丝丟丝丒不:  val_49)) == true)
        {
            goto label_28;
        }
        
        label_195:
        val_51 = this.submitKey1;
        if(val_51 == 0)
        {
            goto label_33;
        }
        
        val_52 = null;
        val_52 = null;
        val_51 = this.submitKey1;
        if((UICamera.GetKeyUp.Invoke(下上丐丆丝丟丝丒不:  val_51)) == false)
        {
            goto label_33;
        }
        
        val_53 = null;
        val_54 = this.submitKey1;
        goto label_43;
        label_33:
        if(this.submitKey0 != 13)
        {
                if(this.submitKey1 != 13)
        {
            goto label_41;
        }
        
        }
        
        val_55 = null;
        val_55 = null;
        if((UICamera.GetKeyUp.Invoke(下上丐丆丝丟丝丒不:  15)) == false)
        {
            goto label_41;
        }
        
        label_28:
        val_53 = null;
        val_54 = this.submitKey0;
        label_43:
        UICamera.currentKey = val_54;
        val_56 = 1;
        if(val_48 == 0)
        {
            goto label_44;
        }
        
        label_49:
        val_57 = null;
        val_57 = null;
        val_59 = RealTime.time;
        丏丅下世上丈下丈丛 = val_59;
        goto label_48;
        label_41:
        val_56 = 0;
        if(val_48 != 0)
        {
            goto label_49;
        }
        
        label_44:
        if(val_56 == 0)
        {
            goto label_53;
        }
        
        label_48:
        if(UICamera.currentScheme == 2)
        {
                val_60 = null;
            val_60 = null;
            val_61 = UICamera.currentTouch;
            上丞丕专丈业丁世专 = UICamera.controllerNavigationObject;
            this.ProcessTouch(万东丂丒且丅丛丑丕:  false, 丗丏丐世专七与三上:  false);
            if(UICamera.currentTouch != null)
        {
                val_56 = mem[UICamera.controller + 72];
            val_56 = UICamera.controller.上丞丕专丈业丁世专;
        }
        else
        {
                val_56 = 0;
        }
        
            丙丕丛丒丁丐丒丕丕 = val_56;
        }
        
        label_53:
        if(this.useController == false)
        {
            goto label_59;
        }
        
        val_62 = null;
        if((UICamera.disableController == true) || (UICamera.currentScheme != 2))
        {
            goto label_76;
        }
        
        val_63 = null;
        val_63 = null;
        if(UICamera.controller.上丞丕专丈业丁世专 == 0)
        {
            goto label_71;
        }
        
        val_64 = null;
        val_64 = null;
        if(UICamera.controller.上丞丕专丈业丁世专.activeInHierarchy == true)
        {
            goto label_76;
        }
        
        label_71:
        val_65 = null;
        val_65 = null;
        val_56 = UICamera.currentTouch;
        上丞丕专丈业丁世专 = UICamera.controllerNavigationObject;
        label_76:
        if((System.String.IsNullOrEmpty(value:  this.verticalAxisName)) == true)
        {
            goto label_90;
        }
        
        val_66 = UICamera.丈七业丄万丞丞丙万(世丐世丄不不丈丗丏:  this.verticalAxisName);
        if(val_66 == 0)
        {
            goto label_101;
        }
        
        bool val_17 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        UICamera.currentScheme = 2;
        上丞丕专丈业丁世专 = UICamera.controllerNavigationObject;
        val_56 = mem[UICamera.controller + 72];
        val_56 = UICamera.controller.上丞丕专丈业丁世专;
        if(val_56 == 0)
        {
            goto label_90;
        }
        
        val_67 = null;
        UnityEngine.KeyCode val_20 = (val_66 <= 0) ? (273 + 1) : 273;
        val_67 = null;
        val_69 = UICamera.onNavigate;
        if(val_69 != null)
        {
                val_69 = UICamera.onNavigate;
            val_69.Invoke(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 下上丐丆丝丟丝丒不:  val_20);
            val_67 = null;
        }
        
        val_67 = null;
        val_56 = mem[UICamera.controller + 72];
        val_56 = UICamera.controller.上丞丕专丈业丁世专;
        UICamera.Notify(丝三丁东丈丒世丅业:  val_56, 且丁三丙丄一世不七:  "OnNavigate", 万且万且丑丗且丌丆:  val_20);
        goto label_101;
        label_90:
        val_66 = 0;
        label_101:
        if((System.String.IsNullOrEmpty(value:  this.horizontalAxisName)) != true)
        {
                val_56 = UICamera.丈七业丄万丞丞丙万(世丐世丄不不丈丗丏:  this.horizontalAxisName);
            if(val_56 != 0)
        {
                bool val_23 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
            UICamera.currentScheme = 2;
            val_61 = UICamera.currentTouch;
            上丞丕专丈业丁世专 = UICamera.controllerNavigationObject;
            if(UICamera.controller.上丞丕专丈业丁世专 != 0)
        {
                val_70 = null;
            UnityEngine.KeyCode val_26 = (val_56 <= 0) ? (275 + 1) : 275;
            val_70 = null;
            val_72 = UICamera.onNavigate;
            if(val_72 != null)
        {
                val_72 = UICamera.onNavigate;
            val_72.Invoke(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 下上丐丆丝丟丝丒不:  val_26);
            val_70 = null;
        }
        
            val_70 = null;
            val_56 = mem[UICamera.controller + 72];
            val_56 = UICamera.controller.上丞丕专丈业丁世专;
            UICamera.Notify(丝三丁东丈丒世丅业:  val_56, 且丁三丙丄一世不七:  "OnNavigate", 万且万且丑丗且丌丆:  val_26);
        }
        
        }
        
        }
        
        val_59 = 0f;
        val_73 = 0f;
        if((System.String.IsNullOrEmpty(value:  this.horizontalPanAxisName)) != true)
        {
                val_74 = null;
            val_74 = null;
            val_56 = UICamera.GetAxis;
            val_73 = val_56.Invoke(丒丘丏上丙丟丑丕丈:  this.horizontalPanAxisName);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.verticalPanAxisName)) != true)
        {
                val_75 = null;
            val_75 = null;
            val_56 = UICamera.GetAxis;
            val_59 = val_56.Invoke(丒丘丏上丙丟丑丕丈:  this.verticalPanAxisName);
        }
        
        if(val_73 == 0f)
        {
                if(val_59 == 0f)
        {
            goto label_152;
        }
        
        }
        
        bool val_31 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        UICamera.currentScheme = 2;
        上丞丕专丈业丁世专 = UICamera.controllerNavigationObject;
        val_56 = mem[UICamera.controller + 72];
        val_56 = UICamera.controller.上丞丕专丈业丁世专;
        if(val_56 == 0)
        {
            goto label_152;
        }
        
        UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_73, y:  val_59);
        val_59 = val_34.x;
        val_61 = 1152921504850403328;
        UnityEngine.Vector2 val_36 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_59, y = val_34.y}, d:  UnityEngine.Time.unscaledDeltaTime);
        val_76 = null;
        val_76 = null;
        val_78 = UICamera.onPan;
        if(val_78 != null)
        {
                val_78 = UICamera.onPan;
            val_59 = val_36.x;
            val_78.Invoke(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_59, y = val_36.y});
            val_76 = null;
        }
        
        val_76 = null;
        val_56 = mem[UICamera.controller + 72];
        val_56 = UICamera.controller.上丞丕专丈业丁世专;
        UICamera.Notify(丝三丁东丈丒世丅业:  val_56, 且丁三丙丄一世不七:  "OnPan", 万且万且丑丗且丌丆:  val_36);
        goto label_152;
        label_59:
        val_66 = 0;
        label_152:
        val_79 = null;
        val_79 = null;
        val_80 = UICamera.GetAnyKeyDown;
        if(val_80 == null)
        {
            goto label_155;
        }
        
        val_80 = UICamera.GetAnyKeyDown;
        if(val_80 == null)
        {
                val_80 = 0;
        }
        
        if(val_80.Invoke() == true)
        {
            goto label_159;
        }
        
        goto label_165;
        label_155:
        if(UnityEngine.Input.anyKeyDown == false)
        {
            goto label_165;
        }
        
        label_159:
        val_81 = null;
        val_81 = null;
        val_56 = 不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑;
        if(不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑.Length < 1)
        {
            goto label_165;
        }
        
        val_61 = 1152921504837943296;
        val_82 = "OnKey";
        var val_41 = 0;
        label_191:
        val_83 = null;
        val_83 = null;
        val_56 = mem[不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑.Length + 32];
        val_56 = 不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑.Length + 32;
        if(val_66 != val_56)
        {
                val_84 = null;
            val_84 = null;
            if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  val_56)) != false)
        {
                if(val_56 <= 322)
        {
                if(this.useKeyboard == false)
        {
            goto label_179;
        }
        
        }
        
            if(val_56 >= 330)
        {
                if(this.useController == false)
        {
            goto label_179;
        }
        
        }
        
            if(this.useMouse != false)
        {
                UICamera.currentKey = val_56;
            val_85 = null;
            val_87 = UICamera.onKey;
            if(val_87 != null)
        {
                val_88 = val_61;
            Invoke(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 下上丐丆丝丟丝丒不:  val_56);
            val_61 = ;
            val_85 = null;
            val_82 = "OnKey";
        }
        
            val_85 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.controller.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  val_82, 万且万且丑丗且丌丆:  val_56);
        }
        
        }
        
        }
        
        label_179:
        val_41 = val_41 + 1;
        if((不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑.Length & 4294967295) != val_41)
        {
            goto label_191;
        }
        
        label_165:
        val_89 = null;
        val_89 = null;
        UICamera.currentTouch = 0;
        return;
        label_16:
        if(this.submitKey0 != 0)
        {
            goto label_194;
        }
        
        goto label_195;
    }
    private void 下三东丁三七东丛丘(bool 万东丂丒且丅丛丑丕, float 三丅东丙专业东丟丙, float 世与丕丙不丟东东下)
    {
        UnityEngine.Vector2 val_34;
        float val_35;
        var val_36;
        var val_37;
        UnityEngine.GameObject val_38;
        var val_39;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        UnityEngine.GameObject val_47;
        var val_48;
        UnityEngine.GameObject val_49;
        var val_50;
        var val_51;
        丞上且下专丞东专世 val_52;
        var val_53;
        丞上且下专丞东专世 val_54;
        UnityEngine.Vector2 val_55;
        float val_56;
        var val_57;
        丞上且下专丞东专世 val_58;
        var val_59;
        UnityEngine.GameObject val_60;
        var val_61;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        丞上且下专丞东专世 val_68;
        bool val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        bool val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        string val_87;
        丅三丝丙丝万上丝业 val_89;
        var val_90;
        丁丏丒不丛丝丞丒业 val_92;
        丞上且下专丞东专世 val_93;
        丞上且下专丞东专世 val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        丅三丝丙丝万上丝业 val_101;
        UnityEngine.GameObject val_102;
        string val_103;
        UnityEngine.GameObject val_104;
        var val_105;
        丞上且下专丞东专世 val_106;
        var val_107;
        丁丏丒不丛丝丞丒业 val_109;
        丞上且下专丞东专世 val_110;
        丞上且下专丞东专世 val_111;
        var val_112;
        丁丏丒不丛丝丞丒业 val_114;
        丞上且下专丞东专世 val_115;
        丞上且下专丞东专世 val_116;
        var val_117;
        一丑下丄丝不丆三三 val_119;
        丞上且下专丞东专世 val_120;
        丞上且下专丞东专世 val_121;
        var val_122;
        UnityEngine.GameObject val_123;
        var val_124;
        var val_125;
        var val_126;
        var val_127;
        var val_128;
        var val_129;
        var val_130;
        一丑下丄丝不丆三三 val_132;
        丞上且下专丞东专世 val_133;
        丞上且下专丞东专世 val_134;
        val_34 = 世与丕丙不丟东东下;
        val_35 = 三丅东丙专业东丟丙;
        val_36 = null;
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_1;
        }
        
        val_37 = null;
        val_38 = 1152921504848912384;
        if(UICamera.丘丘丕丄丟一丞与且 != 0)
        {
                bool val_2 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        }
        
        val_39 = null;
        val_39 = null;
        if(UICamera.currentTouch == null)
        {
                val_39 = null;
        }
        
        UICamera.currentTouch.丅七丞业丁丐三丑丒 = true;
        if(UICamera.onPress != null)
        {
                if((UnityEngine.Object.op_Implicit(exists:  UICamera.currentTouch.万东丂丒且丅丛丑丕)) != false)
        {
                val_41 = null;
            val_41 = null;
            UICamera.onPress.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_42 = null;
        val_42 = null;
        val_43 = 1152921504617656320;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 且丁三丙丄一世不七:  "OnPress", 万且万且丑丗且丌丆:  null);
        if((UICamera.currentScheme == 0) && (UICamera.hoveredObject == 0))
        {
                val_44 = null;
            val_44 = null;
            if(UICamera.currentTouch.上丞丕专丈业丁世专 != 0)
        {
                val_45 = null;
            val_45 = null;
            UICamera.hoveredObject = UICamera.currentTouch.上丞丕专丈业丁世专;
        }
        
        }
        
        val_46 = null;
        val_46 = null;
        if(UICamera.currentTouch == null)
        {
            goto label_43;
        }
        
        val_47 = mem[UICamera.currentTouch + 72];
        val_47 = UICamera.currentTouch.上丞丕专丈业丁世专;
        goto label_44;
        label_1:
        val_48 = null;
        val_49 = mem[UICamera.currentTouch + 80];
        val_49 = UICamera.currentTouch.万东丂丒且丅丛丑丕;
        if(val_49 == 0)
        {
                return;
        }
        
        val_50 = null;
        val_50 = null;
        UICamera.currentTouch.丞且丅三三东不丄且
        if(UICamera.currentTouch.丞且丅三三东不丄且.sqrMagnitude != 0f)
        {
            goto label_54;
        }
        
        val_51 = null;
        val_51 = null;
        val_52 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_57;
        }
        
        val_52 = UICamera.currentTouch;
        if(val_52 == null)
        {
            goto label_324;
        }
        
        label_57:
        val_49 = mem[UICamera.currentTouch + 72];
        val_49 = UICamera.currentTouch.上丞丕专丈业丁世专;
        if(val_49 == UICamera.currentTouch.丙丕丛丒丁丐丒丕丕)
        {
                return;
        }
        
        label_54:
        val_53 = null;
        val_53 = null;
        val_54 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_64;
        }
        
        val_54 = UICamera.currentTouch;
        if(val_54 == null)
        {
            goto label_324;
        }
        
        label_64:
        val_43 = 1152921504850403328;
        val_55 = mem[UICamera.currentTouch + 36];
        val_55 = UICamera.currentTouch.丞且丅三三东不丄且;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = UICamera.currentTouch.东丞不不丙丁丄下且, y = UICamera.currentTouch + 44 + 4}, b:  new UnityEngine.Vector2() {x = val_55, y = UICamera.currentTouch + 36 + 4});
        UICamera.currentTouch.东丞不不丙丁丄下且 = val_11;
        UICamera.currentTouch.__unknownFiledOffset_30 = val_11.y;
        UICamera.currentTouch.东丞不不丙丁丄下且
        val_56 = UICamera.currentTouch.东丞不不丙丁丄下且.sqrMagnitude;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 == true)
        {
            goto label_77;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_73;
        }
        
        val_58 = UICamera.currentTouch;
        if(val_58 == null)
        {
            goto label_324;
        }
        
        label_73:
        if(UICamera.currentTouch.丙丕丛丒丁丐丒丕丕 == UICamera.currentTouch.上丞丕专丈业丁世专)
        {
            goto label_77;
        }
        
        val_59 = null;
        val_59 = null;
        if(UICamera.currentTouch == null)
        {
                val_59 = null;
        }
        
        UICamera.currentTouch.丞丁丈丛世一丑丄丄 = true;
        if(UICamera.currentTouch == null)
        {
            goto label_81;
        }
        
        val_34 = mem[UICamera.currentTouch + 44];
        val_34 = UICamera.currentTouch.东丞不不丙丁丄下且;
        val_55 = mem[UICamera.currentTouch + 44 + 4];
        val_55 = UICamera.currentTouch + 44 + 4;
        goto label_82;
        label_43:
        val_47 = 0;
        val_46 = null;
        label_44:
        UICamera.currentTouch.万东丂丒且丅丛丑丕 = val_47;
        if(UICamera.currentTouch != null)
        {
                val_60 = mem[UICamera.currentTouch + 72];
            val_60 = UICamera.currentTouch.上丞丕专丈业丁世专;
        }
        else
        {
                val_60 = 0;
            val_46 = null;
        }
        
        UICamera.currentTouch.丆丝东丞下丁丛丝与 = val_60;
        if(UICamera.currentTouch == null)
        {
                val_46 = null;
        }
        
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 2;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
        val_35 = val_14.x;
        UICamera.currentTouch.东丞不不丙丁丄下且 = val_14;
        UICamera.currentTouch.__unknownFiledOffset_30 = val_14.y;
        val_61 = null;
        if(UICamera.currentTouch == null)
        {
                val_61 = null;
        }
        
        UICamera.currentTouch.丞丁丈丛世一丑丄丄 = false;
        if(UICamera.currentTouch == null)
        {
                val_61 = null;
        }
        
        UICamera.currentTouch.丁丛丗丘丒丕世七丄 = false;
        if(UICamera.onPress != null)
        {
                if((UnityEngine.Object.op_Implicit(exists:  UICamera.currentTouch.万东丂丒且丅丛丑丕)) != false)
        {
                val_63 = null;
            val_63 = null;
            UICamera.onPress.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        val_64 = null;
        val_64 = null;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 且丁三丙丄一世不七:  "OnPress", 万且万且丑丗且丌丆:  true);
        if(UICamera.丘丘丕丄丟一丞与且 != 0)
        {
                bool val_17 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        }
        
        val_65 = null;
        val_65 = null;
        val_66 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.currentTouch.万东丂丒且丅丛丑丕)) == false)
        {
            goto label_115;
        }
        
        val_67 = null;
        val_68 = UICamera.currentTouch;
        var val_20 = (UICamera.丅丒世丆业丑丏丁丈.Count > 0) ? 1 : 0;
        goto label_120;
        label_115:
        val_70 = null;
        val_68 = UICamera.currentTouch;
        if(val_68 == null)
        {
            goto label_324;
        }
        
        val_69 = false;
        label_120:
        UICamera.currentTouch.丌丏丐丘丁丒丄丅丝 = val_69;
        val_71 = null;
        val_71 = null;
        val_49 = UICamera.东一且三丑丑丏丗七;
        if(val_49 == UICamera.currentTouch.万东丂丒且丅丛丑丕)
        {
                return;
        }
        
        val_72 = null;
        val_72 = null;
        UICamera.三丑丞丈与丐且上丅 = false;
        if((UnityEngine.Object.op_Implicit(exists:  UICamera.东一且三丑丑丏丗七)) != false)
        {
                val_73 = null;
            val_73 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 且丁三丙丄一世不七:  "OnSelect", 万且万且丑丗且丌丆:  null);
            if(UICamera.onSelect != null)
        {
                UICamera.onSelect.Invoke(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_74 = null;
        val_74 = null;
        if(UICamera.currentTouch == null)
        {
                val_74 = null;
        }
        
        UICamera.东一且三丑丑丏丗七 = UICamera.currentTouch.万东丂丒且丅丛丑丕;
        if(UICamera.currentTouch.万东丂丒且丅丛丑丕 != 0)
        {
                val_76 = null;
            val_76 = null;
            if((GetComponent<UIKeyNavigation>()) != 0)
        {
                val_77 = null;
            val_77 = null;
            UICamera.controller.上丞丕专丈业丁世专 = UICamera.currentTouch.万东丂丒且丅丛丑丕;
        }
        
        }
        
        val_78 = null;
        val_78 = null;
        val_49 = UICamera.东一且三丑丑丏丗七;
        if((UnityEngine.Object.op_Implicit(exists:  val_49)) == false)
        {
                return;
        }
        
        val_79 = null;
        val_79 = null;
        if(activeInHierarchy == false)
        {
            goto label_166;
        }
        
        val_80 = null;
        val_80 = null;
        val_81 = UnityEngine.Object.op_Inequality(x:  GetComponent<UIInput>(), y:  0);
        goto label_172;
        label_77:
        val_82 = null;
        val_82 = null;
        val_83 = 0;
        if((val_56 <= val_34) || (UICamera.currentTouch.丞丁丈丛世一丑丄丄 == true))
        {
            goto label_191;
        }
        
        val_84 = null;
        val_84 = null;
        if(UICamera.currentTouch == null)
        {
                val_84 = null;
        }
        
        UICamera.currentTouch.丞丁丈丛世一丑丄丄 = true;
        if(UICamera.currentTouch == null)
        {
            goto label_181;
        }
        
        val_34 = mem[UICamera.currentTouch + 44];
        val_34 = UICamera.currentTouch.东丞不不丙丁丄下且;
        val_55 = mem[UICamera.currentTouch + 44 + 4];
        val_55 = UICamera.currentTouch + 44 + 4;
        goto label_182;
        label_166:
        val_81 = false;
        label_172:
        val_85 = null;
        val_85 = null;
        UICamera.三丑丞丈与丐且上丅 = val_81;
        if(UICamera.onSelect != null)
        {
                UICamera.onSelect.Invoke(丝三丁东丈丒世丅业:  UICamera.东一且三丑丑丏丗七, 丏业丟一东丂东丘丛:  true);
            val_85 = null;
        }
        
        val_85 = null;
        val_49 = UICamera.东一且三丑丑丏丗七;
        val_87 = "OnSelect";
        goto label_190;
        label_181:
        val_34 = 0f;
        val_55 = 0f;
        label_182:
        val_83 = 1;
        UICamera.currentTouch.丞且丅三三东不丄且 = val_34;
        UICamera.currentTouch.__unknownFiledOffset_28 = val_55;
        goto label_191;
        label_81:
        val_34 = 0f;
        val_55 = 0f;
        val_59 = null;
        label_82:
        UICamera.currentTouch.丞且丅三三东不丄且 = val_34;
        UICamera.currentTouch.__unknownFiledOffset_28 = val_55;
        UICamera.isDragging = true;
        val_89 = UICamera.onDragStart;
        if(val_89 != null)
        {
                val_89 = UICamera.onDragStart;
            val_89.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
            val_59 = null;
        }
        
        val_59 = null;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与, 且丁三丙丄一世不七:  "OnDragStart", 万且万且丑丗且丌丆:  0);
        val_90 = null;
        val_92 = UICamera.onDragOver;
        if(val_92 == null)
        {
            goto label_204;
        }
        
        val_92 = UICamera.onDragOver;
        val_93 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_207;
        }
        
        val_93 = UICamera.currentTouch;
        if(val_93 == null)
        {
            goto label_324;
        }
        
        label_207:
        val_38 = mem[UICamera.currentTouch + 88];
        val_38 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_92.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 万且万且丑丗且丌丆:  val_38);
        val_90 = null;
        label_204:
        val_90 = null;
        val_94 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_212;
        }
        
        val_94 = UICamera.currentTouch;
        if(val_94 == null)
        {
            goto label_324;
        }
        
        label_212:
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 且丁三丙丄一世不七:  "OnDragOver", 万且万且丑丗且丌丆:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
        val_83 = 0;
        UICamera.isDragging = false;
        label_191:
        val_95 = null;
        val_95 = null;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 == false)
        {
            goto label_297;
        }
        
        val_96 = null;
        val_96 = null;
        if(UICamera.丘丘丕丄丟一丞与且 != 0)
        {
                bool val_31 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        }
        
        val_97 = null;
        val_97 = null;
        UICamera.isDragging = true;
        if(UICamera.currentTouch == null)
        {
                val_97 = null;
        }
        
        val_38 = val_83 ^ 1;
        if((val_38 & 1) != 0)
        {
            goto label_228;
        }
        
        val_99 = null;
        val_101 = UICamera.onDragStart;
        if(val_101 != null)
        {
                val_101 = UICamera.onDragStart;
            val_101.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
            val_99 = null;
        }
        
        val_99 = null;
        val_102 = mem[UICamera.currentTouch + 88];
        val_102 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_103 = "OnDragStart";
        val_104 = 0;
        goto label_239;
        label_228:
        val_105 = null;
        val_106 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_242;
        }
        
        val_106 = UICamera.currentTouch;
        if(val_106 == null)
        {
            goto label_324;
        }
        
        label_242:
        val_38 = ((UICamera.currentTouch.丌下丐上丛丘丗万丅 == 0) ? 1 : 0) & val_38;
        if(UICamera.currentTouch.丙丕丛丒丁丐丒丕丕 == UICamera.currentTouch.上丞丕专丈业丁世专)
        {
            goto label_246;
        }
        
        val_107 = null;
        val_107 = null;
        val_109 = UICamera.onDragOut;
        if(val_109 == null)
        {
            goto label_249;
        }
        
        val_109 = UICamera.onDragOut;
        val_110 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_252;
        }
        
        val_110 = UICamera.currentTouch;
        if(val_110 == null)
        {
            goto label_324;
        }
        
        label_252:
        val_38 = mem[UICamera.currentTouch + 88];
        val_38 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_109.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 万且万且丑丗且丌丆:  val_38);
        val_107 = null;
        goto label_255;
        label_246:
        val_98 = val_38;
        goto label_256;
        label_249:
        val_98 = val_38;
        label_255:
        val_107 = null;
        val_111 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_259;
        }
        
        val_111 = UICamera.currentTouch;
        if(val_111 == null)
        {
            goto label_324;
        }
        
        label_259:
        val_104 = mem[UICamera.currentTouch + 88];
        val_104 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_102 = mem[UICamera.currentTouch + 64];
        val_102 = UICamera.currentTouch.丙丕丛丒丁丐丒丕丕;
        val_103 = "OnDragOut";
        label_239:
        UICamera.Notify(丝三丁东丈丒世丅业:  val_102, 且丁三丙丄一世不七:  val_103, 万且万且丑丗且丌丆:  val_104);
        val_112 = null;
        val_114 = UICamera.onDragOver;
        if(val_114 == null)
        {
            goto label_261;
        }
        
        val_114 = UICamera.onDragOver;
        val_115 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_264;
        }
        
        val_115 = UICamera.currentTouch;
        if(val_115 == null)
        {
            goto label_324;
        }
        
        label_264:
        val_38 = mem[UICamera.currentTouch + 88];
        val_38 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_114.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 万且万且丑丗且丌丆:  val_38);
        val_112 = null;
        label_261:
        val_112 = null;
        val_116 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_269;
        }
        
        val_116 = UICamera.currentTouch;
        if(val_116 == null)
        {
            goto label_324;
        }
        
        label_269:
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnDragOver", 万且万且丑丗且丌丆:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
        label_256:
        val_117 = null;
        val_117 = null;
        val_119 = UICamera.onDrag;
        if(val_119 == null)
        {
            goto label_273;
        }
        
        val_119 = UICamera.onDrag;
        val_120 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_276;
        }
        
        val_120 = UICamera.currentTouch;
        if(val_120 == null)
        {
            goto label_324;
        }
        
        label_276:
        val_34 = mem[UICamera.currentTouch + 36];
        val_34 = UICamera.currentTouch.丞且丅三三东不丄且;
        val_119.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_34, y = UICamera.currentTouch + 36 + 4});
        val_117 = null;
        label_273:
        val_117 = null;
        val_121 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_281;
        }
        
        val_121 = UICamera.currentTouch;
        if(val_121 == null)
        {
            goto label_324;
        }
        
        label_281:
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与, 且丁三丙丄一世不七:  "OnDrag", 万且万且丑丗且丌丆:  UICamera.currentTouch.丞且丅三三东不丄且);
        val_122 = null;
        if(UICamera.currentTouch != null)
        {
                val_123 = mem[UICamera.currentTouch + 72];
            val_123 = UICamera.currentTouch.上丞丕专丈业丁世专;
        }
        else
        {
                val_123 = 0;
            val_122 = null;
        }
        
        UICamera.currentTouch.丙丕丛丒丁丐丒丕丕 = val_123;
        UICamera.isDragging = false;
        if(val_98 == 0)
        {
            goto label_285;
        }
        
        val_124 = null;
        goto label_288;
        label_285:
        val_125 = null;
        if((val_56 <= val_35) || (UICamera.currentTouch.丌下丐上丛丘丗万丅 != 2))
        {
            goto label_297;
        }
        
        val_126 = null;
        val_126 = null;
        if(UICamera.currentTouch.丌丏丐丘丁丒丄丅丝 == false)
        {
            goto label_297;
        }
        
        val_124 = null;
        label_288:
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 0;
        label_297:
        val_127 = null;
        val_127 = null;
        if(UICamera.currentTouch.丁丛丗丘丒丕世七丄 != true)
        {
                val_128 = null;
            val_128 = null;
            if(UICamera.currentTouch == null)
        {
                val_128 = null;
        }
        
            UICamera.currentTouch.丁丛丗丘丒丕世七丄 = true;
            if(UICamera.currentTouch != null)
        {
                val_35 = mem[UICamera.currentTouch + 44];
            val_35 = UICamera.currentTouch.东丞不不丙丁丄下且;
            val_56 = mem[UICamera.currentTouch + 44 + 4];
            val_56 = UICamera.currentTouch + 44 + 4;
        }
        else
        {
                val_35 = 0f;
            val_56 = 0f;
        }
        
            UICamera.currentTouch.丞且丅三三东不丄且 = val_35;
            UICamera.currentTouch.__unknownFiledOffset_28 = val_56;
        }
        
        val_129 = null;
        val_129 = null;
        val_49 = UICamera.currentTouch;
        if(UICamera.currentTouch.丁丛丗丘丒丕世七丄 == false)
        {
                return;
        }
        
        val_130 = null;
        val_130 = null;
        val_132 = UICamera.onMovedThumb;
        if(val_132 == null)
        {
            goto label_315;
        }
        
        val_132 = UICamera.onMovedThumb;
        val_133 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_318;
        }
        
        val_133 = UICamera.currentTouch;
        if(val_133 == null)
        {
            goto label_324;
        }
        
        label_318:
        val_35 = mem[UICamera.currentTouch + 36];
        val_35 = UICamera.currentTouch.丞且丅三三东不丄且;
        val_132.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_35, y = UICamera.currentTouch + 36 + 4});
        val_130 = null;
        label_315:
        val_130 = null;
        val_134 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_323;
        }
        
        val_134 = UICamera.currentTouch;
        if(val_134 == null)
        {
            goto label_324;
        }
        
        label_323:
        val_49 = mem[UICamera.currentTouch + 88];
        val_49 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_87 = "OnMovedThumb";
        label_190:
        UICamera.Notify(丝三丁东丈丒世丅业:  val_49, 且丁三丙丄一世不七:  val_87, 万且万且丑丗且丌丆:  UICamera.currentTouch.丞且丅三三东不丄且);
        return;
        label_324:
    }
    private void 丗丁丗丐三丏丂且丑(bool 丞丅丄上丞上丌万与, float 世与丕丙不丟东东下)
    {
        丞上且下专丞东专世 val_10;
        var val_11;
        丞上且下专丞东专世 val_12;
        var val_13;
        var val_14;
        丁丏丒不丛丝丞丒业 val_16;
        丞上且下专丞东专世 val_17;
        丞上且下专丞东专世 val_18;
        var val_19;
        丅三丝丙丝万上丝业 val_21;
        var val_22;
        下丈业丑世丟丘丅下 val_24;
        UnityEngine.GameObject val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        下丈业丑世丟丘丅下 val_31;
        var val_32;
        var val_33;
        var val_34;
        丞上且下专丞东专世 val_35;
        var val_36;
        var val_37;
        丞上且下专丞东专世 val_38;
        var val_39;
        丅三丝丙丝万上丝业 val_41;
        var val_42;
        丅三丝丙丝万上丝业 val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        丁丏丒不丛丝丞丒业 val_51;
        丞上且下专丞东专世 val_52;
        丞上且下专丞东专世 val_53;
        var val_54;
        val_10 = 丞丅丄上丞上丌万与;
        val_11 = null;
        val_11 = null;
        val_12 = UICamera.currentTouch;
        if(val_12 == null)
        {
                return;
        }
        
        val_11 = null;
        val_12 = UICamera.currentTouch;
        if(val_12 == null)
        {
            goto label_144;
        }
        
        UICamera.currentTouch.丅七丞业丁丐三丑丒 = false;
        if(UICamera.currentTouch.万东丂丒且丅丛丑丕 == 0)
        {
            goto label_132;
        }
        
        val_13 = null;
        val_13 = null;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 == false)
        {
            goto label_14;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = UICamera.onDragOut;
        if(val_16 == null)
        {
            goto label_17;
        }
        
        val_16 = UICamera.onDragOut;
        val_17 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_20;
        }
        
        val_17 = UICamera.currentTouch;
        if(val_17 == null)
        {
            goto label_144;
        }
        
        label_20:
        val_16.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 万且万且丑丗且丌丆:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
        val_14 = null;
        label_17:
        val_14 = null;
        val_18 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_25;
        }
        
        val_18 = UICamera.currentTouch;
        if(val_18 == null)
        {
            goto label_144;
        }
        
        label_25:
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.丙丕丛丒丁丐丒丕丕, 且丁三丙丄一世不七:  "OnDragOut", 万且万且丑丗且丌丆:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
        val_19 = null;
        val_21 = UICamera.onDragEnd;
        if(val_21 != null)
        {
                val_21 = UICamera.onDragEnd;
            val_21.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
            val_19 = null;
        }
        
        val_19 = null;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.丆丝东丞下丁丛丝与, 且丁三丙丄一世不七:  "OnDragEnd", 万且万且丑丗且丌丆:  0);
        label_14:
        val_22 = null;
        val_22 = null;
        val_24 = UICamera.onPress;
        if(val_24 != null)
        {
                val_24 = UICamera.onPress;
            val_24.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 丏业丟一东丂东丘丛:  false);
            val_22 = null;
        }
        
        val_22 = null;
        val_25 = 1152921504617656320;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 且丁三丙丄一世不七:  "OnPress", 万且万且丑丗且丌丆:  null);
        if(val_10 != false)
        {
                val_26 = null;
            val_26 = null;
            if(UICamera.currentTouch == null)
        {
                val_26 = 0;
        }
        
            if((this.丑三下丞丁丝丞一下(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕)) != false)
        {
                val_27 = null;
            val_27 = null;
            val_28 = null;
            if(UICamera.丑丁丞丑丗丏专世七 == UICamera.currentTouch.上丞丕专丈业丁世专)
        {
                val_29 = null;
            val_31 = UICamera.onHover;
            if(val_31 != null)
        {
                val_31 = UICamera.onHover;
            val_31.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 丏业丟一东丂东丘丛:  true);
            val_29 = null;
        }
        
            val_29 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnHover", 万且万且丑丗且丌丆:  true);
        }
        else
        {
                val_32 = null;
            UICamera.hoveredObject = UICamera.currentTouch.上丞丕专丈业丁世专;
        }
        
        }
        
        }
        
        val_33 = null;
        val_33 = null;
        if(UICamera.currentTouch.丌丏丐丘丁丒丄丅丝 == false)
        {
            goto label_128;
        }
        
        val_34 = null;
        val_34 = null;
        val_35 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_76;
        }
        
        val_35 = UICamera.currentTouch;
        if(val_35 == null)
        {
            goto label_144;
        }
        
        label_76:
        if(UICamera.currentTouch.丆丝东丞下丁丛丝与 != UICamera.currentTouch.上丞丕专丈业丁世专)
        {
            goto label_80;
        }
        
        label_128:
        val_36 = null;
        val_36 = null;
        if( == 0)
        {
            goto label_132;
        }
        
        val_37 = null;
        val_37 = null;
        val_38 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_87;
        }
        
        val_38 = UICamera.currentTouch;
        if(val_38 == null)
        {
            goto label_144;
        }
        
        label_87:
        if(UICamera.currentTouch.万东丂丒且丅丛丑丕 != UICamera.currentTouch.上丞丕专丈业丁世专)
        {
            goto label_132;
        }
        
        bool val_6 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
        float val_7 = RealTime.time;
        val_39 = null;
        val_41 = UICamera.onClick;
        if(val_41 != null)
        {
                val_41 = UICamera.onClick;
            val_41.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕);
            val_39 = null;
        }
        
        val_39 = null;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 且丁三丙丄一世不七:  "OnClick", 万且万且丑丗且丌丆:  0);
        float val_10 = UICamera.currentTouch.业三丂丌丅丘且不世;
        val_10 = val_10 + 0.35f;
        if(val_10 > val_7)
        {
                val_42 = null;
            val_42 = null;
            val_44 = UICamera.onDoubleClick;
            if(val_44 != null)
        {
                val_44 = UICamera.onDoubleClick;
            val_44.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕);
            val_42 = null;
        }
        
            val_42 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕, 且丁三丙丄一世不七:  "OnDoubleClick", 万且万且丑丗且丌丆:  0);
        }
        
        val_45 = null;
        val_45 = null;
        UICamera.currentTouch.业三丂丌丅丘且不世 = val_7;
        goto label_132;
        label_80:
        if(UICamera.currentScheme == 2)
        {
            goto label_124;
        }
        
        val_46 = null;
        val_46 = null;
        if( == 0)
        {
            goto label_124;
        }
        
        val_47 = null;
        val_47 = null;
        UICamera.currentTouch.东丞不不丙丁丄下且
        if(UICamera.currentTouch.东丞不不丙丁丄下且.sqrMagnitude < 0)
        {
            goto label_128;
        }
        
        label_124:
        val_48 = null;
        val_48 = null;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 == false)
        {
            goto label_132;
        }
        
        val_49 = null;
        val_49 = null;
        val_51 = UICamera.onDrop;
        if(val_51 == null)
        {
            goto label_135;
        }
        
        val_51 = UICamera.onDrop;
        val_52 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_138;
        }
        
        val_52 = UICamera.currentTouch;
        if(val_52 == null)
        {
            goto label_144;
        }
        
        label_138:
        val_25 = mem[UICamera.currentTouch + 88];
        val_25 = UICamera.currentTouch.丆丝东丞下丁丛丝与;
        val_51.Invoke(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 万且万且丑丗且丌丆:  val_25);
        val_49 = null;
        label_135:
        val_49 = null;
        val_53 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_143;
        }
        
        val_53 = UICamera.currentTouch;
        if(val_53 == null)
        {
            goto label_144;
        }
        
        label_143:
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnDrop", 万且万且丑丗且丌丆:  UICamera.currentTouch.丆丝东丞下丁丛丝与);
        label_132:
        val_54 = null;
        val_54 = null;
        if(UICamera.currentTouch == null)
        {
                val_54 = null;
        }
        
        UICamera.currentTouch.丞丁丈丛世一丑丄丄 = false;
        if(UICamera.currentTouch == null)
        {
                val_54 = null;
        }
        
        UICamera.currentTouch.丁丛丗丘丒丕世七丄 = false;
        if(UICamera.currentTouch == null)
        {
                val_54 = null;
        }
        
        UICamera.currentTouch.万东丂丒且丅丛丑丕 = 0;
        val_10 = UICamera.currentTouch;
        UICamera.currentTouch.丆丝东丞下丁丛丝与 = 0;
        return;
        label_144:
    }
    private bool 丑三下丞丁丝丞一下(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 == 0)
        {
                return false;
        }
        
        UnityEngine.Collider val_2 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Collider>();
        if(val_2 != 0)
        {
                if(val_2 != null)
        {
                return val_2.enabled;
        }
        
            return val_2.enabled;
        }
        
        UnityEngine.Collider2D val_4 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Collider2D>();
        if(val_4 == 0)
        {
                return false;
        }
        
        if(val_4 != null)
        {
                return val_4.enabled;
        }
        
        return val_4.enabled;
    }
    public void ProcessTouch(bool 万东丂丒且丅丛丑丕, bool 丗丏丐世专七与三上)
    {
        UnityEngine.GameObject val_12;
        var val_13;
        var val_14;
        var val_15;
        丞上且下专丞东专世 val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_12 = 丗丏丐世专七与三上;
        if(万东丂丒且丅丛丑丕 != false)
        {
                float val_1 = UnityEngine.Time.unscaledTime;
            val_13 = null;
            val_13 = null;
            val_1 = val_1 + this.丗丙业丁丗丏丛一丅;
            UICamera.丙丄上丁不丏一丂丐 = val_1;
        }
        else
        {
                val_13 = null;
        }
        
        三下七东不东丈丈丞 val_2 = UICamera.currentScheme;
        val_14 = null;
        float val_12 = (val_2 == 0) ? this.mouseClickThreshold : this.touchClickThreshold;
        val_14 = null;
        val_12 = val_12 * val_12;
        bool val_4 = UnityEngine.Object.op_Inequality(x:  UICamera.currentTouch.万东丂丒且丅丛丑丕, y:  0);
        if(val_4 == false)
        {
            goto label_12;
        }
        
        if(val_12 != false)
        {
                this.丗丁丗丐三丏丂且丑(丞丅丄上丞上丌万与:  (val_2 == 0) ? 1 : 0, 世与丕丙不丟东东下:  900f);
        }
        
        this.下三东丁三七东丛丘(万东丂丒且丅丛丑丕:  万东丂丒且丅丛丑丕, 三丅东丙专业东丟丙:  val_12, 世与丕丙不丟东东下:  900f);
        val_15 = null;
        val_15 = null;
        val_16 = UICamera.currentTouch;
        if(UICamera.currentTouch != null)
        {
            goto label_16;
        }
        
        val_16 = UICamera.currentTouch;
        if(val_16 == null)
        {
            goto label_17;
        }
        
        label_16:
        val_12 = mem[UICamera.currentTouch + 72];
        val_12 = UICamera.currentTouch.上丞丕专丈业丁世专;
        if(UICamera.currentTouch.万东丂丒且丅丛丑丕 != val_12)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(UICamera.丙丄上丁不丏一丂丐 == 0f)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        if(UICamera.currentTouch.丞丁丈丛世一丑丄丄 == true)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(UICamera.currentTouch.业丅三丙丒专一丏丑() <= this.丗丙业丁丗丏丛一丅)
        {
                return;
        }
        
        if(this.丗丙业丁丗丏丛一丅 <= 0f)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        UICamera.丙丄上丁不丏一丂丐 = 0f;
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 0;
        if(this.longPressTooltip != false)
        {
                val_22 = null;
            val_22 = null;
            bool val_9 = UICamera.ShowTooltip(丝三丁东丈丒世丅业:  UICamera.currentTouch.万东丂丒且丅丛丑丕);
        }
        
        val_23 = null;
        val_23 = null;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.currentTouch.上丞丕专丈业丁世专, 且丁三丙丄一世不七:  "OnLongPress", 万且万且丑丗且丌丆:  0);
        return;
        label_12:
        if((val_2 != 0) && (万东丂丒且丅丛丑丕 != true))
        {
                if(val_12 == false)
        {
                return;
        }
        
        }
        
        val_4.下三东丁三七东丛丘(万东丂丒且丅丛丑丕:  万东丂丒且丅丛丑丕, 三丅东丙专业东丟丙:  val_12, 世与丕丙不丟东东下:  900f);
        if(val_12 == false)
        {
                return;
        }
        
        this.丗丁丗丐三丏丂且丑(丞丅丄上丞上丌万与:  (val_2 == 0) ? 1 : 0, 世与丕丙不丟东东下:  900f);
        return;
        label_17:
    }
    public static bool ShowTooltip(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        bool val_9;
        val_4 = null;
        val_4 = null;
        if(UICamera.丘丘丕丄丟一丞与且 == 丝三丁东丈丒世丅业)
        {
            goto label_5;
        }
        
        val_5 = null;
        val_5 = null;
        if(UICamera.丘丘丕丄丟一丞与且 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(UICamera.onTooltip != null)
        {
                UICamera.onTooltip.Invoke(丝三丁东丈丒世丅业:  UICamera.丘丘丕丄丟一丞与且, 丏业丟一东丂东丘丛:  false);
            val_6 = null;
        }
        
            val_6 = null;
            UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.丘丘丕丄丟一丞与且, 且丁三丙丄一世不七:  "OnTooltip", 万且万且丑丗且丌丆:  null);
        }
        
        val_7 = null;
        val_7 = null;
        UICamera.丘丘丕丄丟一丞与且 = 丝三丁东丈丒世丅业;
        UICamera.丙丄上丁不丏一丂丐 = 0f;
        if(UICamera.丘丘丕丄丟一丞与且 == 0)
        {
            goto label_22;
        }
        
        val_8 = null;
        val_8 = null;
        if(UICamera.onTooltip != null)
        {
                UICamera.onTooltip.Invoke(丝三丁东丈丒世丅业:  UICamera.丘丘丕丄丟一丞与且, 丏业丟一东丂东丘丛:  true);
            val_8 = null;
        }
        
        val_8 = null;
        val_9 = true;
        UICamera.Notify(丝三丁东丈丒世丅业:  UICamera.丘丘丕丄丟一丞与且, 且丁三丙丄一世不七:  "OnTooltip", 万且万且丑丗且丌丆:  val_9);
        return (bool)val_9;
        label_5:
        val_9 = 0;
        return (bool)val_9;
        label_22:
        val_9 = 1;
        return (bool)val_9;
    }
    public static bool HideTooltip()
    {
        return UICamera.ShowTooltip(丝三丁东丈丒世丅业:  0);
    }
    public UICamera()
    {
        this.世专七一丝三丑丙一 = true;
        this.eventType = true;
        UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.forcedEventReceiverMask = val_1;
        UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.useController = true;
        this.stickyTooltip = true;
        this.eventReceiverMask = val_2;
        this.useMouse = true;
        this.useTouch = true;
        this.allowMultiTouch = true;
        this.useKeyboard = true;
        this.丗丙业丁丗丏丛一丅 = -1f;
        this.rangeDistance = -1f;
        this.mouseDragThreshold = ;
        this.mouseClickThreshold = ;
        this.touchDragThreshold = 40f;
        this.touchClickThreshold = 40f;
        this.horizontalAxisName = "Horizontal";
        this.verticalAxisName = "Vertical";
        this.submitKey0 = 13;
        this.commandClick = true;
        this.cancelKey0 = 27;
        this.scrollAxisName = "Mouse ScrollWheel";
        this.autoHideCursor = true;
    }
    private static UICamera()
    {
        UICamera.丅丒世丆业丑丏丁丈 = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        UICamera.list = new 丒丞丕丕七丁丗丟丛<UICamera>();
        UICamera.GetKeyDown = new UICamera.丘丒三丐丌丑丑丘世(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  public static System.Boolean UnityEngine.Input::GetKeyDown(UnityEngine.KeyCode key));
        UICamera.GetKeyUp = new UICamera.丘丒三丐丌丑丑丘世(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  public static System.Boolean UnityEngine.Input::GetKeyUp(UnityEngine.KeyCode key));
        UICamera.GetKey = new UICamera.丘丒三丐丌丑丑丘世(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  public static System.Boolean UnityEngine.Input::GetKey(UnityEngine.KeyCode key));
        UICamera.GetAxis = new UICamera.丅丝丒丆丌专丗丂业(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  public static System.Single UnityEngine.Input::GetAxis(string axisName));
        UICamera.showTooltips = true;
        UICamera.东东上丈丗丑丄东丕 = false;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        UICamera.专丟丆丛丁七下三丝 = val_7.x;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_50 = val_7.y;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        UICamera.lastWorldPosition = val_8.x;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_58 = val_8.y;
        UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_5C = val_8.z;
        UICamera.current = 0;
        UICamera.currentCamera = 0;
        UICamera.丆丝丌丙丂丛与丆七 = 0;
        UICamera.currentTouchID = 99;
        UICamera.东七丅且且下丁丛丁 = 48;
        UICamera.currentTouch = 0;
        UICamera.三丑丞丈与丐且上丅 = false;
        丞上且下专丞东专世[] val_9 = new 丞上且下专丞东专世[3];
        UICamera.丞上且下专丞东专世 val_10 = new UICamera.丞上且下专丞东专世();
        if(val_9 == null)
        {
            goto label_5;
        }
        
        if(val_10 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_10 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_9[0] = val_10;
        val_9[1] = new UICamera.丞上且下专丞东专世();
        val_9[2] = new UICamera.丞上且下专丞东专世();
        UICamera.丟万丒丛东丟丏一东 = val_9;
        UICamera.controller = new UICamera.丞上且下专丞东专世();
        UICamera.activeTouches = new System.Collections.Generic.List<丞上且下专丞东专世>();
        UICamera.丐丄与上丂丒丂东世 = new System.Collections.Generic.List<System.Int32>();
        UICamera.业丆世丄丏丕丕七不 = 0;
        UICamera.丙万且丝丐世下世且 = 0;
        UICamera.丘丘丕丄丟一丞与且 = 0;
        UICamera.丙丄上丁不丏一丂丐 = 0f;
        UICamera.isDragging = false;
        UICamera.丌丙丞下一下东不丏 = new 丒丞丕丕七丁丗丟丛<丞业丐世丐世一丁丁>();
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.back;
        UICamera.丛丏七丆丄丆丝与丄 = 0;
        UICamera.丄东且丟东业丆丆丘 = 0f;
        UICamera.丛丒丙丞且丟与丈丕 = 0;
        UICamera.丒万与丝东丏丆上且 = new UnityEngine.RaycastHit[50];
        UICamera.丞丅丟下万万丟与七 = true;
    }

}
