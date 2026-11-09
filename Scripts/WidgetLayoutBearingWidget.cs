using UnityEngine;
public class WidgetLayoutBearingWidget : PGBehaviour
{
    // Fields
    public 专万丛丘下丄丄丞丟 layoutType;
    public float spacing;
    public bool elementPivotAtCenter;
    public System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>> widgets;
    
    // Methods
    public void AddElement(UIWidget 丞丂三且三七丈丗丘, UnityEngine.GameObject 丅丆东丏丙丝丅丆丟)
    {
        UIWidget val_13;
        System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_14;
        UIWidget val_15;
        UnityEngine.Object val_16;
        UIWidget val_17;
        val_13 = 丞丂三且三七丈丗丘;
        val_14 = this;
        WidgetLayoutBearingWidget.世丞丒丅一专丌丐丏 val_1 = new WidgetLayoutBearingWidget.世丞丒丅一专丌丐丏();
        if(val_1 != null)
        {
                val_15 = val_1;
            .丞丂三且三七丈丗丘 = val_13;
            val_16 = 1152921538198142944;
            mem[1152921538198142952] = 丅丆东丏丙丝丅丆丟;
        }
        else
        {
                val_15 = 16;
            mem[16] = val_13;
            val_16 = 24;
            mem[24] = 丅丆东丏丙丝丅丆丟;
            val_13 = mem[16];
        }
        
        if(val_13 == 0)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        val_13 = this.widgets;
        if((System.Linq.Enumerable.Any<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(source:  val_13, predicate:  new System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean>(object:  val_1, method:  System.Boolean WidgetLayoutBearingWidget.世丞丒丅一专丌丐丏::上丆丞丏丐丑丈世丗(System.ValueTuple<UIWidget, UnityEngine.GameObject> 三丟东丕丄丄下下丑)))) == true)
        {
                return;
        }
        
        mem[24].transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        mem[24].transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_13 = mem[24].transform;
        UnityEngine.Vector3 val_11 = this.丘丛丝七丐丁七一丐(世丌丌丙丞丟下东丞:  val_15);
        val_13.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_14 = this.widgets;
        if(val_1 != null)
        {
                val_17 = mem[16];
        }
        else
        {
                val_17 = mem[16];
        }
        
        MoonSharp.Interpreter.TablePair val_12 = new MoonSharp.Interpreter.TablePair(key:  val_17, val:  mem[24]);
        val_14.Add(item:  new System.ValueTuple<UIWidget, UnityEngine.GameObject>() {Item2 = val_12.key});
    }
    public void RemoveElement(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟, bool 丏丞丙丌丆丙万丂丛)
    {
        UnityEngine.GameObject val_7;
        object val_8;
        System.Func<TSource, System.Boolean> val_9;
        val_7 = 丅丆东丏丙丝丅丆丟;
        WidgetLayoutBearingWidget.丞丂万丅不丒丘丟丗 val_1 = null;
        val_8 = val_1;
        val_1 = new WidgetLayoutBearingWidget.丞丂万丅不丒丘丟丗();
        if(val_8 != null)
        {
                .丅丆东丏丙丝丅丆丟 = val_7;
        }
        else
        {
                val_9 = 16;
            mem[16] = val_7;
            val_7 = mem[16];
        }
        
        if(val_7 == 0)
        {
                return;
        }
        
        System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean> val_3 = null;
        val_9 = val_3;
        val_3 = new System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean>(object:  val_1, method:  System.Boolean WidgetLayoutBearingWidget.丞丂万丅不丒丘丟丗::丟丏丙上东丕万东丑(System.ValueTuple<UIWidget, UnityEngine.GameObject> 三丟东丕丄丄下下丑));
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_4 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(source:  this.widgets, predicate:  val_3);
        val_8 = val_9;
        if(val_4.Item2 == 0)
        {
                if(val_3 == 0)
        {
                return;
        }
        
        }
        
        if(丏丞丙丌丆丙万丂丛 != false)
        {
                UnityEngine.Object.Destroy(obj:  val_3);
        }
        
        this.Reposition();
    }
    public void RemoveElement(UIWidget 丞丂三且三七丈丗丘, bool 丏丞丙丌丆丙万丂丛)
    {
        UIWidget val_7;
        object val_8;
        System.Func<TSource, System.Boolean> val_9;
        val_7 = 丞丂三且三七丈丗丘;
        WidgetLayoutBearingWidget.丘丞上世丗丘丏丐东 val_1 = null;
        val_8 = val_1;
        val_1 = new WidgetLayoutBearingWidget.丘丞上世丗丘丏丐东();
        if(val_8 != null)
        {
                .丞丂三且三七丈丗丘 = val_7;
        }
        else
        {
                val_9 = 16;
            mem[16] = val_7;
            val_7 = mem[16];
        }
        
        if(val_7 == 0)
        {
                return;
        }
        
        System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean> val_3 = null;
        val_9 = val_3;
        val_3 = new System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean>(object:  val_1, method:  System.Boolean WidgetLayoutBearingWidget.丘丞上世丗丘丏丐东::丟丏丙上东丕万东丑(System.ValueTuple<UIWidget, UnityEngine.GameObject> 三丟东丕丄丄下下丑));
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_4 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(source:  this.widgets, predicate:  val_3);
        val_8 = val_9;
        if(val_4.Item2 == 0)
        {
                if(val_3 == 0)
        {
                return;
        }
        
        }
        
        if(丏丞丙丌丆丙万丂丛 != false)
        {
                UnityEngine.Object.Destroy(obj:  val_3);
        }
        
        this.Reposition();
    }
    public void Reposition()
    {
        var val_3;
        var val_20;
        System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean> val_22;
        this.widgets.Clear();
        List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(source:  this.widgets).GetEnumerator();
        label_4:
        if(((-767994864) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        this.AddElement(丞丂三且三七丈丗丘:  val_5._value._obj, 丅丆东丏丙丝丅丆丟:  val_5._value._token);
        goto label_4;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_7 = this.GetSize() * 0.5f;
        if(this.layoutType == 5)
        {
            goto label_9;
        }
        
        if(this.layoutType != 4)
        {
                return;
        }
        
        if(this.elementPivotAtCenter != false)
        {
                if(this.widgets.Count >= 2)
        {
            goto label_13;
        }
        
        }
        
        var val_10 = (this.widgets.Count == 1) ? 0f : (val_7);
        goto label_15;
        label_9:
        if(this.elementPivotAtCenter != false)
        {
                if(this.widgets.Count >= 2)
        {
            goto label_18;
        }
        
        }
        
        var val_13 = (this.widgets.Count == 1) ? 0f : (val_7);
        goto label_20;
        label_13:
        val_20 = null;
        val_20 = null;
        val_22 = WidgetLayoutBearingWidget.<>c.<>9__7_0;
        if(val_22 == null)
        {
                System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean> val_14 = null;
            val_22 = val_14;
            val_14 = new System.Func<System.ValueTuple<UIWidget, UnityEngine.GameObject>, System.Boolean>(object:  WidgetLayoutBearingWidget.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WidgetLayoutBearingWidget.<>c::丄下东不一丆丝一丟(System.ValueTuple<UIWidget, UnityEngine.GameObject> 三丟东丕丄丄下下丑));
            WidgetLayoutBearingWidget.<>c.<>9__7_0 = val_22;
        }
        
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_15 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(source:  this.widgets, predicate:  val_14);
        if((UnityEngine.Object.op_Implicit(exists:  val_15.Item2)) == false)
        {
            goto label_15;
        }
        
        float val_20 = (float)val_15.Item2.width;
        val_20 = val_20 * (-0.5f);
        val_7 = val_7 + val_20;
        goto label_15;
        label_18:
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_18 = this.widgets.Item[0];
        float val_21 = (float)val_18.Item2.height;
        val_21 = val_21 * (-0.5f);
        val_21 = val_7 + val_21;
        label_20:
        label_15:
        this.丝丟世下且丂丏丏丞(丙业与丙丗丝不丈东:  val_21);
    }
    public void RemoveAll(bool 丏丞丙丌丆丙万丂丛)
    {
        var val_4;
        if(丏丞丙丌丆丙万丂丛 == false)
        {
            goto label_14;
        }
        
        List.Enumerator<T> val_1 = this.widgets.GetEnumerator();
        val_4 = 1152921538198539664;
        label_9:
        if(( & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        if(val_2._value._token == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2._value._token);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_14:
        this.widgets.Clear();
    }
    private UnityEngine.Vector3 丘丛丝七丐丁七一丐(UIWidget 世丌丌丙丞丟下东丞)
    {
        System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_35;
        float val_36;
        float val_37;
        float val_38;
        UnityEngine.Object val_39;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_35 = this.widgets;
        val_36 = val_1.x;
        val_37 = val_1.y;
        val_38 = val_1.z;
        if(val_35.Count < 1)
        {
                return new UnityEngine.Vector3() {y = val_37, z = val_38};
        }
        
        int val_32 = this.widgets.Count;
        label_10:
        val_32 = val_32 - 1;
        if((val_32 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_4 = this.widgets.Item[val_32];
        if(val_4.Item2.gameObject.activeSelf == false)
        {
            goto label_10;
        }
        
        System.ValueTuple<UIWidget, UnityEngine.GameObject> val_7 = this.widgets.Item[val_32];
        val_35 = val_7.Item2;
        val_39 = val_32;
        UnityEngine.Vector3 val_9 = val_39.transform.localPosition;
        val_36 = val_9.x;
        val_37 = val_9.y;
        val_38 = val_9.z;
        goto label_14;
        label_6:
        val_35 = 0;
        val_39 = 0;
        label_14:
        if(val_35 == 0)
        {
                if(val_39 == 0)
        {
                return new UnityEngine.Vector3() {y = val_37, z = val_38};
        }
        
        }
        
        if(this.layoutType > 5)
        {
                return new UnityEngine.Vector3() {y = val_37, z = val_38};
        }
        
        var val_33 = 106038280 + (this.layoutType) << 2;
        val_33 = val_33 + 106038280;
        goto (106038280 + (this.layoutType) << 2 + 106038280);
    }
    public void CollectWidgets()
    {
        UnityEngine.Debug.LogError(message:  "Not Implemented");
    }
    public float GetSize(UIWidget 世丌丌丙丞丟下东丞)
    {
        var val_3;
        专万丛丘下丄丄丞丟 val_3 = this.layoutType;
        if(val_3 > 5)
        {
                return (float)(float)val_3.width;
        }
        
        val_3 = 1 << val_3;
        val_3 = val_3 & 35;
        if(val_3 != 0)
        {
                val_3 = 世丌丌丙丞丟下东丞;
            int val_1 = val_3.height;
        }
        else
        {
                val_3 = 世丌丌丙丞丟下东丞;
        }
        
        return (float)(float)val_3.width;
    }
    public float GetSize()
    {
        float val_5;
        System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_6;
        IntPtr val_8;
        WidgetLayoutBearingWidget.丒丛丁与丅东丒不七 val_1 = new WidgetLayoutBearingWidget.丒丛丁与丅东丒不七();
        if(val_1 != null)
        {
                val_5 = val_1;
            .东且丁丆丛丁丏丘且 = 0f;
        }
        else
        {
                val_5 = 0f;
            mem[16] = 0;
        }
        
        .专不丕七丄东下丗丘 = 0;
        专万丛丘下丄丄丞丟 val_5 = this.layoutType;
        if(val_5 <= 5)
        {
                val_5 = 1 << val_5;
            val_5 = val_5 & 35;
            if(val_5 != 0)
        {
                val_6 = this.widgets;
            val_8 = 1152921538199298432;
        }
        else
        {
                val_6 = this.widgets;
            System.Action<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_2 = null;
            val_8 = 1152921538199307648;
        }
        
            val_2 = new System.Action<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(object:  val_1, method:  val_8);
            val_6.ForEach(action:  val_2);
        }
        
        float val_6 = (float)UnityEngine.Mathf.Max(a:  0, b:  (WidgetLayoutBearingWidget.丒丛丁与丅东丒不七)[1152921538199366720].专不丕七丄东下丗丘 - 1);
        val_6 = this.spacing * val_6;
        val_6 = val_5 + val_6;
        mem[16] = val_6;
        return val_6;
    }
    public int GetCount()
    {
        System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_3;
        IntPtr val_5;
        .专不丕七丄东下丗丘 = 0;
        专万丛丘下丄丄丞丟 val_3 = this.layoutType;
        if(val_3 > 5)
        {
                return (int)(WidgetLayoutBearingWidget.世东丒与丞七不不东)[1152921538199529920].专不丕七丄东下丗丘;
        }
        
        val_3 = 1 << val_3;
        val_3 = val_3 & 35;
        if(val_3 != 0)
        {
                val_3 = this.widgets;
            val_5 = 1152921538199463680;
        }
        else
        {
                val_3 = this.widgets;
            System.Action<System.ValueTuple<UIWidget, UnityEngine.GameObject>> val_2 = null;
            val_5 = 1152921538199472896;
        }
        
        val_2 = new System.Action<System.ValueTuple<UIWidget, UnityEngine.GameObject>>(object:  new WidgetLayoutBearingWidget.世东丒与丞七不不东(), method:  val_5);
        val_3.ForEach(action:  val_2);
        return (int)(WidgetLayoutBearingWidget.世东丒与丞七不不东)[1152921538199529920].专不丕七丄东下丗丘;
    }
    private void 丝丟世下且丂丏丏丞(float 丙业与丙丗丝不丈东)
    {
        var val_7;
        float val_8;
        float val_9;
        val_7 = this;
        List.Enumerator<T> val_1 = this.widgets.GetEnumerator();
        label_10:
        if(( & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        UnityEngine.Vector3 val_4 = val_2._value._token.transform.localPosition;
        val_8 = val_4.x;
        val_9 = val_4.y;
        if(this.layoutType != 4)
        {
            goto label_5;
        }
        
        val_8 = val_8 - 丙业与丙丗丝不丈东;
        if(val_2._value._token != 0)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_9 = (this.layoutType == 5) ? (val_9 + 丙业与丙丗丝不丈东) : (val_9);
        if(val_2._value._token != 0)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_2._value._token.transform.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_4.z};
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public WidgetLayoutBearingWidget()
    {
        this.elementPivotAtCenter = true;
        this.widgets = new System.Collections.Generic.List<System.ValueTuple<UIWidget, UnityEngine.GameObject>>();
    }

}
