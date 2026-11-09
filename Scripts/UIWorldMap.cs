using UnityEngine;
public class UIWorldMap : UIWorldMapBase
{
    // Fields
    private static UIWorldMap 丄丈丂丅上专万丞丏;
    public UnityEngine.GameObject marker;
    public System.Collections.Generic.List<UISprite> worldmapSprites;
    private UnityEngine.GameObject 丒且下世丗丂丕丕不;
    private UISlider 丆且丞丟丛丗万一世;
    protected int 丙上万东丆七丞万丒;
    private NJGMapItem 世上丟不不上三丝且;
    
    // Properties
    public static UIWorldMap 丄丘七三上丕世丞业 { get; }
    
    // Methods
    public static UIWorldMap get_instance()
    {
        UIWorldMap val_5;
        var val_6;
        val_5 = UIWorldMap.丄丈丂丅上专万丞丏;
        if(val_5 != 0)
        {
                return (UIWorldMap)UIWorldMap.丄丈丂丅上专万丞丏;
        }
        
        val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_5);
        val_6 = 0;
        UIWorldMap.丄丈丂丅上专万丞丏 = ;
        return (UIWorldMap)UIWorldMap.丄丈丂丅上专万丞丏;
    }
    public void OnHoverOver()
    {
        goto typeof(UIWorldMap).__il2cppRuntimeField_1B8;
    }
    public void OnHoverOut()
    {
        goto typeof(UIWorldMap).__il2cppRuntimeField_1B8;
    }
    public void OnPress(bool 万与丘丅丟世丅丄上)
    {
        mem[1152921535451271217] = 万与丘丅丟世丅丄上;
    }
    public void OnDoubleClick()
    {
    
    }
    protected override void 丁业三上丛丐且专东()
    {
        UIWorldMap val_13;
        bool val_14;
        UnityEngine.Object val_15;
        UnityEngine.Object val_16;
        val_13 = this;
        val_14 = 1152921504848912384;
        if(NJGMap.instance == 0)
        {
                return;
        }
        
        if(UIWorldMap.丄丈丂丅上专万丞丏 == 0)
        {
                UIWorldMap.丄丈丂丅上专万丞丏 = val_13;
        }
        
        this.丁业三上丛丐且专东();
        if(this == 0)
        {
                return;
        }
        
        val_15 = 0;
        if((this.GetComponent<UnityEngine.BoxCollider>()) == val_15)
        {
                val_15 = 0;
            不丌丂丁丄一与丆丙.世丞业且三丗丘三丑(丝三丁东丈丒世丅业:  this.gameObject);
        }
        
        val_16 = this.GetComponent<UIForwardEvents>();
        if(val_16 == 0)
        {
                val_16 = this.gameObject.AddComponent<UIForwardEvents>();
        }
        
        if(val_16 != null)
        {
                val_11.onClick = true;
            val_11.onHover = true;
        }
        else
        {
                val_14 = true;
            val_11.onClick = val_14;
            mem[32] = val_14;
        }
        
        val_11.onDoubleClick = true;
        val_13 = this.gameObject;
        val_11.target = val_13;
    }
    protected override void Update()
    {
        this.Update();
        this.且丝丙三一东世丆且();
    }
    private void 且丝丙三一东世丆且()
    {
        if(UnityEngine.Input.touchCount != 2)
        {
                return;
        }
        
        UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
        UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  1);
        UnityEngine.Vector2 val_4 = position;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        UnityEngine.Vector2 val_6 = position;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
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
        mem[1152921535451993472] = 25;
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_52;
        }
        
        goto label_52;
    }
    public void OnClick()
    {
        var val_18;
        float val_19;
        bool val_23;
        val_18 = null;
        val_18 = null;
        UnityEngine.Vector3 val_2 = this.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_4 = this.cachedTransform.position;
        val_19 = val_4.y;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_19, z = val_4.z});
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = this.MapToWorld(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        if(this.丒且下世丗丂丕丕不 == 0)
        {
                val_23 = 1;
        }
        else
        {
                val_23 = (~this.丒且下世丗丂丕丕不.activeSelf) & 1;
        }
        
        if(this.丒且下世丗丂丕丕不 == 0)
        {
                UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            val_19 = val_11.y;
            UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.marker, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_19, z = val_11.z, w = val_11.w});
            this.丒且下世丗丂丕丕不 = val_12;
            val_12.name = "Marker";
            this.世上丟不不上三丝且 = this.丒且下世丗丂丕丕不.GetComponent<NJGMapItem>();
            this.丒且下世丗丂丕丕不.transform.SetParent(p:  this.gameObject.transform);
        }
        
        if(val_23 != 0)
        {
                this.丒且下世丗丂丕丕不.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.世上丟不不上三丝且.AddToList();
            this.世上丟不不上三丝且.isCustomColor = true;
            this.世上丟不不上三丝且.type = 6;
        }
        
        this.丒且下世丗丂丕丕不.SetActive(value:  val_23);
        this.丛业专丒丘丏丁七丗(丙业与丙丗丝不丈东:  true);
    }
    public UIWorldMap()
    {
        this.worldmapSprites = new System.Collections.Generic.List<UISprite>();
    }

}
