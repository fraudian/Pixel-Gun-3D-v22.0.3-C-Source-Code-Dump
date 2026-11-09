using UnityEngine;
public class WorldMapClicksHandle : MonoBehaviour
{
    // Fields
    private UnityEngine.Camera nguiCam;
    private UIWidget 世丌丌丙丞丟下东丞;
    private UnityEngine.Vector4 一且丙丈丕丏丂三丐;
    private bool 东丂丆丂上与丌专万;
    private UnityEngine.Vector3 丑丑丘三丅三丗丅丏;
    private int 万丝丁丌专下一丞丐;
    private UnityEngine.Vector2 东三丙丝丑丙业丙上;
    private float 丌丅丘丞业丕业丄七;
    private System.Nullable<UnityEngine.Touch> 丄丏不丆丞专七丞与;
    private System.Nullable<UnityEngine.Touch> 七丛丌专下世七丏丑;
    private float zoomSpeed;
    public static float fingerPixelsDeadZone;
    
    // Properties
    private UnityEngine.Vector4 世下丁丁丑丑业丂丞 { get; }
    
    // Methods
    private UnityEngine.Vector4 不丙丛万业丂下且丙()
    {
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Vector4 val_15;
        var val_16;
        var val_17;
        var val_18;
        if(this.东丂丆丂上与丌专万 == false)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.世丌丌丙丞丟下东丞.transform.position;
        val_11 = val_2.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_11, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.丑丑丘三丅三丗丅丏, y = V11.16B, z = V10.16B})) == false)
        {
            goto label_6;
        }
        
        label_1:
        if(null == null)
        {
                val_12 = 0;
        }
        
        if(null == null)
        {
                val_13 = 0;
        }
        
        if(null <= 2)
        {
                val_14 = 0;
        }
        
        val_15 = this;
        this.一且丙丈丕丏丂三丐 = 0;
        this.东丂丆丂上与丌专万 = true;
        val_16 = 1152921535452576908;
        val_17 = 1152921535452576912;
        val_18 = 1152921535452576916;
        UnityEngine.Vector3 val_5 = this.世丌丌丙丞丟下东丞.transform.position;
        this.丑丑丘三丅三丗丅丏 = val_5;
        mem[1152921535452576928] = val_5.y;
        mem[1152921535452576932] = val_5.z;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 3.543642E-21f, z = 3.543642E-21f, w = 3.543642E-21f};
        label_6:
        val_15 = this.一且丙丈丕丏丂三丐;
        val_16 = 1152921535452576908;
        val_17 = 1152921535452576912;
        val_18 = 1152921535452576916;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 3.543642E-21f, z = 3.543642E-21f, w = 3.543642E-21f};
    }
    private bool 丑丟上一且下丂与丙(UnityEngine.Vector3 上下丁丕与上业丅丄)
    {
        UnityEngine.Vector3 val_1 = this.nguiCam.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 上下丁丕与上业丅丄.x, y = 上下丁丕与上业丅丄.y, z = 上下丁丕与上业丅丄.z});
        UnityEngine.Vector4 val_2 = this.不丙丛万业丂下且丙();
        if(val_1.x < val_2.x)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_3 = this.不丙丛万业丂下且丙();
        if(val_1.y < val_3.y)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_4 = this.不丙丛万业丂下且丙();
        if(val_1.x > val_4.z)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_5 = this.不丙丛万业丂下且丙();
        var val_6 = (val_1.y <= val_5.w) ? 1 : 0;
        return false;
    }
    private UnityEngine.Vector2 专丐与丟丆丌丝丛丒(UnityEngine.Vector3 丙一与世丈专丅三三)
    {
        float val_13;
        float val_14;
        float val_15;
        UnityEngine.Vector3 val_1 = this.nguiCam.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z});
        UnityEngine.Transform val_2 = this.世丌丌丙丞丟下东丞.transform;
        if(val_2 != null)
        {
                UnityEngine.Vector3 val_3 = val_2.position;
            val_13 = val_3.x;
            UnityEngine.Vector3 val_4 = val_2.lossyScale;
            val_14 = val_4.x;
            UnityEngine.Vector3 val_5 = val_2.position;
            val_15 = val_5.y;
        }
        else
        {
                UnityEngine.Vector3 val_6 = 0.position;
            val_13 = val_6.x;
            UnityEngine.Vector3 val_7 = 0.lossyScale;
            val_14 = val_7.x;
            UnityEngine.Vector3 val_8 = 0.position;
            val_15 = val_8.y;
        }
        
        UnityEngine.Vector3 val_9 = val_2.lossyScale;
        float val_10 = val_1.x - val_13;
        val_10 = val_10 / val_14;
        val_9.y = (val_1.y - val_15) / val_9.y;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_10, y:  val_9.y);
        return new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
    }
    private void Awake()
    {
        var val_10;
        this.nguiCam = InGameGUI.丙丞专丌丁丞与不丐.丝丙与东丈不丙三丟();
        this.世丌丌丙丞丟下东丞 = this.GetComponent<UIWidget>();
        float val_3 = UnityEngine.Screen.dpi;
        val_10 = null;
        float val_4 = (val_3 < 0) ? 150f : (val_3);
        val_10 = null;
        float val_10 = 2.54f;
        val_10 = val_4 / val_10;
        val_10 = val_10 * 0.3f;
        WorldMapClicksHandle.fingerPixelsDeadZone = val_10;
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void WorldMapClicksHandle::丈专与下丈丅丄一一(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)));
        UnityEngine.Debug.Log(message:  "WorldMap Taps DeadZone Calculation...");
        UnityEngine.Debug.Log(message:  "Screen Height: "("Screen Height: ") + UnityEngine.Screen.height);
        UnityEngine.Debug.Log(message:  "Scree DPI: "("Scree DPI: ") + val_4);
        UnityEngine.Debug.Log(message:  "Dead zone in pixels: "("Dead zone in pixels: ") + WorldMapClicksHandle.fingerPixelsDeadZone);
    }
    private void 丟且下丏七不丞丗丄(UnityEngine.Vector3 丙一与世丈专丅三三, bool 丝一专丅丆丗丌专丈 = True)
    {
        float val_12;
        float val_13;
        InGameGUIPart_Imposter val_14;
        var val_15;
        val_12 = 丙一与世丈专丅三三.z;
        val_13 = 丙一与世丈专丅三三.x;
        val_14 = this;
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                UnityEngine.Vector3 val_2 = this.nguiCam.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_13, y = 丙一与世丈专丅三三.y, z = val_12});
            val_15 = 1152921505219145728;
            val_12 = val_2.x;
            val_13 = val_2.z;
            val_14 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 856];
            val_14 = InGameGUI.丙丞专丌丁丞与不丐.丙下丆与丁丘丙丕丙;
            if((CheckTapOnSabotageButton(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_12, y = val_2.y, z = val_13})) == true)
        {
                return;
        }
        
        }
        else
        {
                if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                UnityEngine.Vector3 val_5 = this.nguiCam.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_13, y = 丙一与世丈专丅三三.y, z = val_12});
            if((CheckTapOnTaskPanelOrWidgets(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == true)
        {
                return;
        }
        
        }
        
            if((this.丑丟上一且下丂与丙(上下丁丕与上业丅丄:  new UnityEngine.Vector3() {x = val_13, y = 丙一与世丈专丅三三.y, z = val_12})) != false)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            if(丝一专丅丆丗丌专丈 == false)
        {
                return;
        }
        
            UnityEngine.Vector2 val_9 = this.专丐与丟丆丌丝丛丒(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_13, y = 丙一与世丈专丅三三.y, z = val_12});
            OnWorldMapTap(丙一与世丈专丅三三:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            return;
        }
        
            val_15 = 1152921505219145728;
            if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_14 = public System.Boolean UnityEngine.Object::Equals(object other);
            return;
        }
        
        }
        
        }
        
        U_WorlMapCloseClick();
    }
    private void 丈专与下丈丅丄一一(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)
    {
        PGCompany.丆七丗丂世丞丗丙三 val_7 = 丝丘三万上世丑丑丂;
        if(GamepadCursorController.丂业丗业世世丛丟七() == false)
        {
                return;
        }
        
        if(val_7 != 33)
        {
                return;
        }
        
        if(PGCompany.GamepadCoreController.Instance.丈丛七丐丏丘丕下丕() != 7)
        {
                return;
        }
        
        val_7 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(null != 1)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.丟且下丏七不丞丗丄(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丝一专丅丆丗丌专丈:  true);
    }
    private void OnDestroy()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void WorldMapClicksHandle::丈专与下丈丅丄一一(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)));
    }
    private void Update()
    {
        var val_32;
        System.Nullable<UnityEngine.Touch> val_33;
        int val_34;
        MiniMapController val_35;
        float val_36;
        float val_37;
        float val_40;
        float val_41;
        var val_42;
        int val_1 = UnityEngine.Input.touchCount;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        if(UnityEngine.Input.touchCount != 1)
        {
            goto label_2;
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        val_32 = 0;
        val_33 = this.丄丏不丆丞专七丞与;
        val_34 = 0;
        goto label_3;
        label_32:
        val_35 = 0;
        var val_4 = 0 + 32;
        if(专三三与三且一且一() != 1)
        {
                this.东三丙丝丑丙业丙上 = new UnityEngine.Vector2();
            mem[1152921535453635840] = ???;
        }
        
        if(专三三与三且一且一() == 4)
        {
                this.万丝丁丌专下一丞丐 = val_34;
        }
        
        if(专三三与三且一且一() == 3)
        {
                if(((this.万丝丁丌专下一丞丐 == 1) && ((val_33 & 1) == 0)) && ((this.七丛丌专下世七丏丑 & 1) == 0))
        {
                val_36 = V0.16B;
            val_37 = V1.16B;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            this.丟且下丏七不丞丗丄(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丝一专丅丆丗丌专丈:  true);
        }
        
            this.万丝丁丌专下一丞丐 = val_34;
        }
        
        if(专三三与三且一且一() != 1)
        {
            goto label_24;
        }
        
        val_40 = this.丌丅丘丞业丕业丄七;
        if(val_40 != 0f)
        {
            goto label_14;
        }
        
        if(this.万丝丁丌专下一丞丐 == 1)
        {
                val_36 = val_40;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_36, y = val_8.y});
            if((this.丑丟上一且下丂与丙(上下丁丕与上业丅丄:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) != false)
        {
                val_41 = val_10.x;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.东三丙丝丑丙业丙上, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_41, y = val_10.y});
            val_36 = val_12.x.sqrMagnitude;
            val_42 = null;
            val_42 = null;
            float val_34 = WorldMapClicksHandle.fingerPixelsDeadZone;
            val_34 = val_34 * val_34;
            if(val_36 > val_34)
        {
                this.万丝丁丌专下一丞丐 = 丙东专丂世丈丏丁丂();
            this.东三丙丝丑丙业丙上 = val_34;
            mem[1152921535453635840] = val_12.y;
        }
        
        }
        
        }
        
        if(丙东专丂世丈丏丁丂() != this.万丝丁丌专下一丞丐)
        {
            goto label_24;
        }
        
        val_35 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 912];
        val_35 = InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.东三丙丝丑丙业丙上, y = val_36});
        UnityEngine.Vector2 val_17 = this.专丐与丟丆丌丝丛丒(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        UnityEngine.Vector2 val_19 = this.专丐与丟丆丌丝丛丒(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, d:  (float)this.世丌丌丙丞丟下东丞.height);
        val_36 = val_22.x;
        val_40 = val_36;
        val_37 = val_22.y;
        ScrollWorldMap(世丕丞三一丞世与万:  new UnityEngine.Vector2() {x = val_40, y = val_37});
        goto label_30;
        label_14:
        this.丌丅丘丞业丕业丄七 = 0f;
        label_30:
        this.东三丙丝丑丙业丙上 = val_40;
        mem[1152921535453635840] = val_8.y;
        label_24:
        val_32 = 1;
        label_3:
        if(val_32 < val_3.Length)
        {
            goto label_32;
        }
        
        return;
        label_1:
        this.丌丅丘丞业丕业丄七 = 0f;
        this.万丝丁丌专下一丞丐 = 0;
        return;
        label_2:
        if(val_1 != 2)
        {
                return;
        }
        
        this.万丝丁丌专下一丞丐 = 0;
        UnityEngine.Touch[] val_23 = UnityEngine.Input.touches;
        val_34 = 1152921535453609712;
        val_32 = 0;
        val_33 = this.丄丏不丆丞专七丞与;
        goto label_36;
        label_44:
        val_35 = 0;
        var val_24 = 0 + 32;
        if(专三三与三且一且一() != 0)
        {
                if(专三三与三且一且一() != 1)
        {
                if(专三三与三且一且一() != 2)
        {
            goto label_40;
        }
        
        }
        
        }
        
        if((val_33 & 1) != 0)
        {
                val_35 = public System.Void System.Nullable<UnityEngine.Touch>::.ctor(UnityEngine.Touch value);
        }
        else
        {
                val_35 = public System.Void System.Nullable<UnityEngine.Touch>::.ctor(UnityEngine.Touch value);
        }
        
        val_32 = 1;
        label_36:
        if(val_32 < val_23.Length)
        {
            goto label_44;
        }
        
        goto label_45;
        label_40:
        this.丌丅丘丞业丕业丄七 = 0f;
        label_45:
        if((val_33 & 1) == 0)
        {
                return;
        }
        
        if((this.七丛丌专下世七丏丑 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        UnityEngine.Vector2 val_29 = this.专丐与丟丆丌丝丛丒(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        UnityEngine.Vector2 val_31 = this.专丐与丟丆丌丝丛丒(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, b:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y});
        val_36 = val_32.x;
        if(this.丌丅丘丞业丕业丄七 <= 0f)
        {
            goto label_57;
        }
        
        float val_33 = val_36 - this.丌丅丘丞业丕业丄七;
        float val_36 = 0.001f;
        val_41 = 1f;
        val_36 = System.Math.Abs(val_33) * val_36;
        val_36 = val_36 * this.zoomSpeed;
        val_33 = val_36 + val_41;
        if(val_33 <= 0f)
        {
            goto label_53;
        }
        
        if(null != 0)
        {
            goto label_56;
        }
        
        goto label_56;
        label_53:
        if(val_33 >= 0)
        {
            goto label_57;
        }
        
        val_36 = val_41 / val_33;
        label_56:
        ZoomWorldMap(业丈不业丂丙下丅下:  val_36);
        label_57:
        this.丌丅丘丞业丕业丄七 = val_36;
    }
    public WorldMapClicksHandle()
    {
        this.万丝丁丌专下一丞丐 = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.东三丙丝丑丙业丙上 = val_1;
        mem[1152921535453825664] = val_1.y;
        this.zoomSpeed = 2f;
    }
    private static WorldMapClicksHandle()
    {
    
    }

}
