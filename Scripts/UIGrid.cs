using UnityEngine;
public class UIGrid : UIWidgetContainer
{
    // Fields
    public UIGrid.丕丄下丒丘七丁业丑 arrangement;
    public UIGrid.丞丝丑业与下丏丅下 sorting;
    public UIWidget.七丐与七丌不丂丞且 pivot;
    public int maxPerLine;
    public float cellWidth;
    public float cellHeight;
    public bool animateSmoothly;
    public bool hideInactive;
    public bool keepWithinPanel;
    public UIGrid.下一丒下丂丙万丁丞 onReposition;
    public System.Comparison<UnityEngine.Transform> onCustomSort;
    private bool sorted;
    protected bool 丙丐万东不丛丗丄丂;
    protected UIPanel 与业丌丄且丁丛与丁;
    protected bool 丕丞且丐丙万丆业丟;
    
    // Properties
    set; }
    
    // Methods
    public void set_repositionNow(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.丙丐万东不丛丗丄丂 = true;
        this.enabled = true;
    }
    public System.Collections.Generic.List<UnityEngine.Transform> GetChildList()
    {
        var val_9;
        var val_10;
        IntPtr val_12;
        UnityEngine.Transform val_1 = this.transform;
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_9 = 0;
        goto label_1;
        label_13:
        val_10 = 0;
        UnityEngine.Transform val_3 = val_1.GetChild(index:  0);
        if(this.hideInactive != false)
        {
                if(((UnityEngine.Object.op_Implicit(exists:  val_3)) == false) || ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_3.gameObject)) == false))
        {
            goto label_10;
        }
        
        }
        
        val_10 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        val_2.Add(item:  val_3);
        label_10:
        val_9 = 1;
        label_1:
        if(val_9 < val_1.childCount)
        {
            goto label_13;
        }
        
        if(this.sorting == 0)
        {
                return val_2;
        }
        
        if(this.arrangement == 2)
        {
                return val_2;
        }
        
        if(this.sorting == 3)
        {
            goto label_16;
        }
        
        if(this.sorting == 2)
        {
            goto label_17;
        }
        
        if(this.sorting != 1)
        {
            goto label_18;
        }
        
        val_12 = 1152921531093966416;
        goto label_20;
        label_16:
        val_12 = 1152921531093971536;
        goto label_20;
        label_17:
        System.Comparison<UnityEngine.Transform> val_8 = null;
        val_12 = 1152921531093976656;
        label_20:
        val_8 = new System.Comparison<UnityEngine.Transform>(object:  0, method:  val_12);
        label_24:
        val_2.Sort(comparison:  val_8);
        return val_2;
        label_18:
        if(this.onCustomSort == null)
        {
                return val_2;
        }
        
        if(val_2 != null)
        {
            goto label_24;
        }
        
        goto label_24;
    }
    public System.Collections.Generic.List<UnityEngine.Transform> GetChildList(string 丈丙丝丑丁丅上丏上)
    {
        var val_11;
        var val_12;
        IntPtr val_14;
        UnityEngine.Transform val_1 = this.transform;
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_11 = 0;
        goto label_1;
        label_15:
        val_12 = 0;
        UnityEngine.Transform val_3 = val_1.GetChild(index:  0);
        if(this.hideInactive != false)
        {
                if(((UnityEngine.Object.op_Implicit(exists:  val_3)) == false) || ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_3.gameObject)) == false))
        {
            goto label_12;
        }
        
        }
        
        val_12 = 0;
        if((System.String.op_Inequality(a:  val_3.tag, b:  丈丙丝丑丁丅上丏上)) != false)
        {
                val_12 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
            val_2.Add(item:  val_3);
        }
        
        label_12:
        val_11 = 1;
        label_1:
        if(val_11 < val_1.childCount)
        {
            goto label_15;
        }
        
        if(this.sorting == 0)
        {
                return val_2;
        }
        
        if(this.arrangement == 2)
        {
                return val_2;
        }
        
        if(this.sorting == 3)
        {
            goto label_18;
        }
        
        if(this.sorting == 2)
        {
            goto label_19;
        }
        
        if(this.sorting != 1)
        {
            goto label_20;
        }
        
        val_14 = 1152921531093966416;
        goto label_22;
        label_18:
        val_14 = 1152921531093971536;
        goto label_22;
        label_19:
        System.Comparison<UnityEngine.Transform> val_10 = null;
        val_14 = 1152921531093976656;
        label_22:
        val_10 = new System.Comparison<UnityEngine.Transform>(object:  0, method:  val_14);
        label_26:
        val_2.Sort(comparison:  val_10);
        return val_2;
        label_20:
        if(this.onCustomSort == null)
        {
                return val_2;
        }
        
        if(val_2 != null)
        {
            goto label_26;
        }
        
        goto label_26;
    }
    public UnityEngine.Transform GetChild(int 丞世不丒下上上丝丑)
    {
        var val_4;
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = this.GetChildList();
        if(val_1.Count > 丞世不丒下上上丝丑)
        {
                UnityEngine.Transform val_3 = val_1.Item[丞世不丒下上上丝丑];
            return (UnityEngine.Transform)val_4;
        }
        
        val_4 = 0;
        return (UnityEngine.Transform)val_4;
    }
    public int GetIndex(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = this.GetChildList();
        if(val_1 != null)
        {
                return val_1.IndexOf(item:  丄上七丟不丗丕下丟);
        }
        
        return val_1.IndexOf(item:  丄上七丟不丗丕下丟);
    }
    public void AddChild(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        this.AddChild(丄上七丟不丗丕下丟:  丄上七丟不丗丕下丟, 丙万丘丗丅万丐一世:  false);
    }
    public void AddChild(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 丙万丘丗丅万丐一世)
    {
        if(丄上七丟不丗丕下丟 == 0)
        {
                return;
        }
        
        丄上七丟不丗丕下丟.parent = this.transform;
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = this.GetChildList();
        this = ???;
        goto typeof(UIGrid).__il2cppRuntimeField_1B8;
    }
    public bool RemoveChild(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        var val_3;
        if((this.GetChildList().Remove(item:  丙丒七丄上与丏丙丙)) != false)
        {
                val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    protected virtual void 丘上丐世丆丑且丞丒()
    {
        this.丕丞且丐丙万丆业丟 = true;
        this.与业丌丄且丁丛与丁 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
    }
    protected virtual void Start()
    {
        this.animateSmoothly = false;
        this.animateSmoothly = this.animateSmoothly;
        this.enabled = false;
    }
    protected virtual void Update()
    {
        this.enabled = false;
    }
    private void OnValidate()
    {
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(UIGrid).__il2cppRuntimeField_1A8;
    }
    public static int SortByName(UnityEngine.Transform 丆丛丑世下一丐且丕, UnityEngine.Transform 丌丗丏丏丛东专丁且)
    {
        return System.String.Compare(strA:  丆丛丑世下一丐且丕.name, strB:  丌丗丏丏丛东专丁且.name);
    }
    public static int SortHorizontal(UnityEngine.Transform 丆丛丑世下一丐且丕, UnityEngine.Transform 丌丗丏丏丛东专丁且)
    {
        UnityEngine.Vector3 val_1 = 丆丛丑世下一丐且丕.localPosition;
        UnityEngine.Vector3 val_2 = 丌丗丏丏丛东专丁且.localPosition;
        return (int);
    }
    public static int SortVertical(UnityEngine.Transform 丆丛丑世下一丐且丕, UnityEngine.Transform 丌丗丏丏丛东专丁且)
    {
        UnityEngine.Vector3 val_1 = 丌丗丏丏丛东专丁且.localPosition;
        UnityEngine.Vector3 val_2 = 丆丛丑世下一丐且丕.localPosition;
        return (int);
    }
    protected virtual void 万万丘丙丗丈丘丙丁(System.Collections.Generic.List<UnityEngine.Transform> 丝丘丑业丛万丞丌丝)
    {
    
    }
    public virtual void Reposition()
    {
        if((UnityEngine.Application.isPlaying != false) && (this.丕丞且丐丙万丆业丟 != true))
        {
                bool val_3 = 不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject);
        }
        
        if(this.sorted != false)
        {
                this.sorted = false;
            if(this.sorting == 0)
        {
                this.sorting = 1;
        }
        
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_4 = this.GetChildList();
        if(this.keepWithinPanel != false)
        {
                this.ConstrainWithinPanel();
        }
        
        if(this.onReposition == null)
        {
                return;
        }
        
        this.onReposition.Invoke();
    }
    public void ConstrainWithinPanel()
    {
        UnityEngine.Object val_12;
        UnityEngine.Transform val_13;
        val_12 = this;
        if(this.与业丌丄且丁丛与丁 == 0)
        {
                return;
        }
        
        val_13 = this.transform;
        bool val_3 = this.与业丌丄且丁丛与丁.ConstrainTargetToBounds(丞下万上三丘上与专:  val_13, 丌丄丗七丝丘与丆与:  true);
        val_12 = this.与业丌丄且丁丛与丁.GetComponent<UIScrollView>();
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_13 = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1D8;
    }
    protected virtual void 上丌丈丂业专丑丕丈(System.Collections.Generic.List<UnityEngine.Transform> 丝丘丑业丛万丞丌丝)
    {
        var val_7;
        var val_28;
        double val_29;
        float val_30;
        float val_31;
        bool val_32;
        float val_36;
        float val_37;
        float val_38;
        double val_39;
        float val_40;
        float val_41;
        float val_42;
        var val_43;
        float val_44;
        float val_45;
        double val_46;
        float val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        UnityEngine.Object val_53;
        val_28 = 丝丘丑业丛万丞丌丝;
        this.丙丐万东不丛丗丄丂 = false;
        UnityEngine.Transform val_1 = this.transform;
        int val_2 = val_28.Count;
        if(val_2 < 1)
        {
            goto label_2;
        }
        
        var val_36 = 0;
        var val_34 = 0;
        val_29 = 0.5;
        goto label_41;
        label_37:
        val_30 = V10.16B;
        val_31 = V11.16B;
        if((SpringPosition.Begin(丝三丁东丈丒世丅业:  X28.gameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = V9.16B}, 丛上丟丌丄丗丁世与:  15f)) != null)
        {
                val_32 = true;
            val_4.updateScrollView = val_32;
        }
        else
        {
                mem[42] = 1;
            val_32 = true;
        }
        
        val_4.ignoreTimeScale = val_32;
        goto label_7;
        label_41:
        UnityEngine.Transform val_5 = val_28.Item[0];
        UnityEngine.Vector3 val_6 = val_5.localPosition;
        val_36 = val_6.x;
        val_37 = val_6.y;
        val_38 = val_6.z;
        if(this.arrangement != 2)
        {
            goto label_10;
        }
        
        if(this.cellWidth <= 0f)
        {
            goto label_11;
        }
        
        val_36 = val_36 / this.cellWidth;
        if(val_36 >= 0f)
        {
            goto label_14;
        }
        
        if((double)val_36 != (-0.5))
        {
            goto label_15;
        }
        
        val_39 = val_7;
        val_40 = -1f;
        goto label_16;
        label_10:
        if(this.arrangement != 0)
        {
                val_7 = 0;
            val_41 = 0f;
            val_42 = 0f;
        }
        else
        {
                val_41 = 0f;
            val_42 = 0f;
            val_7 = 0;
        }
        
        val_43 = this.cellWidth * val_41;
        val_44 = -(this.cellHeight * val_42);
        val_36 = 0f;
        val_37 = 0f;
        val_38 = 0f;
        goto label_23;
        label_14:
        if((double)val_36 != val_29)
        {
            goto label_20;
        }
        
        val_39 = val_7;
        val_40 = 1f;
        label_16:
        float val_28 = (float)val_39;
        val_40 = val_28 + val_40;
        val_28 = ((0 & (1.401298E-45f)) != 0) ? (val_28) : (val_40);
        goto label_22;
        label_15:
        float val_29 = -0.5f;
        val_29 = val_36 + val_29;
        goto label_22;
        label_20:
        float val_30 = 0.5f;
        val_30 = val_36 + val_30;
        label_22:
        val_44 = this.cellWidth;
        val_36 = val_30 * val_44;
        label_11:
        val_45 = this.cellHeight;
        if(val_45 <= 0f)
        {
            goto label_23;
        }
        
        val_37 = val_37 / val_45;
        if(val_37 >= 0f)
        {
            goto label_26;
        }
        
        if((double)val_37 != (-0.5))
        {
            goto label_27;
        }
        
        val_46 = val_7;
        val_47 = -1f;
        goto label_28;
        label_26:
        if((double)val_37 != val_29)
        {
            goto label_29;
        }
        
        val_46 = val_7;
        val_47 = 1f;
        label_28:
        float val_31 = (float)val_46;
        val_47 = val_31 + val_47;
        val_31 = ((0 & (1.401298E-45f)) != 0) ? (val_31) : (val_47);
        goto label_31;
        label_27:
        float val_32 = -0.5f;
        val_32 = val_37 + val_32;
        goto label_31;
        label_29:
        float val_33 = 0.5f;
        val_33 = val_37 + val_33;
        label_31:
        val_44 = this.cellHeight;
        val_37 = val_33 * val_44;
        label_23:
        if((this.animateSmoothly == false) || (UnityEngine.Application.isPlaying == false))
        {
            goto label_33;
        }
        
        UnityEngine.Vector3 val_9 = val_5.localPosition;
        val_45 = val_9.x;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) >= 0.0001f)
        {
            goto label_37;
        }
        
        label_33:
        val_30 = val_36;
        val_31 = val_37;
        val_5.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_38};
        label_7:
        val_48 = UnityEngine.Mathf.Max(a:  0, b:  0);
        int val_35 = this.maxPerLine;
        val_34 = val_34 + 1;
        val_49 = UnityEngine.Mathf.Max(a:  0, b:  0);
        val_35 = (((0 + 1) >= val_35) ? 1 : 0) & ((val_35 > 0) ? 1 : 0);
        var val_17 = (val_35 >= 1) ? 0 : (0 + 1);
        val_36 = val_36 + val_35;
        if(val_2 != val_34)
        {
            goto label_41;
        }
        
        goto label_42;
        label_2:
        val_49 = 0;
        val_48 = 0;
        label_42:
        if(this.pivot == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_18 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.pivot);
        val_36 = this.cellWidth;
        if(this.arrangement != 0)
        {
                val_51 = val_49;
            val_49 = val_48;
        }
        else
        {
                val_51 = val_48;
        }
        
        val_29 = UnityEngine.Mathf.Lerp(a:  0f, b:  val_36 * 0f, t:  val_18.x);
        float val_37 = this.cellHeight;
        val_37 = val_37 * 0f;
        float val_21 = UnityEngine.Mathf.Lerp(a:  val_37, b:  0f, t:  val_18.y);
        val_28 = 1152921531083270528;
        val_52 = 0;
        val_50 = 24;
        goto label_50;
        label_62:
        val_49 = val_1.GetChild(index:  0);
        val_53 = val_49.GetComponent<SpringPosition>();
        if(val_53 == 0)
        {
            goto label_55;
        }
        
        if(val_53 == null)
        {
            goto label_56;
        }
        
        UnityEngine.Vector3 val_38 = val_23.target;
        val_38 = val_38 - val_29;
        mem2[0] = val_38;
        goto label_57;
        label_55:
        UnityEngine.Vector3 val_25 = val_49.localPosition;
        val_36 = val_25.z;
        val_45 = val_25.y - val_21;
        val_49.localPosition = new UnityEngine.Vector3() {x = val_25.x - val_29, y = val_45, z = val_36};
        goto label_60;
        label_56:
        float val_39 = 6.606506E-38f;
        val_39 = val_39 - val_29;
        mem[24] = val_39;
        val_53 = 24;
        label_57:
        float val_40 = 0f;
        val_40 = val_40 - val_21;
        mem[28] = val_40;
        label_60:
        val_52 = 1;
        label_50:
        if(val_52 < val_1.childCount)
        {
            goto label_62;
        }
    
    }
    public UIGrid()
    {
        this.cellWidth = 200f;
        this.cellHeight = 200f;
    }

}
