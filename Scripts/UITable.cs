using UnityEngine;
public class UITable : UIWidgetContainer
{
    // Fields
    public int columns;
    public UITable.丟世丆丕丌且七下丂 direction;
    public UITable.丞丝丑业与下丏丅下 sorting;
    public UIWidget.七丐与七丌不丂丞且 pivot;
    public UIWidget.七丐与七丌不丂丞且 cellAlignment;
    public bool hideInactive;
    public bool keepWithinPanel;
    public bool centerLastLine;
    public UnityEngine.Vector2 padding;
    public UITable.下一丒下丂丙万丁丞 onReposition;
    public System.Comparison<UnityEngine.Transform> onCustomSort;
    protected UIPanel 与业丌丄且丁丛与丁;
    protected bool 丕丞且丐丙万丆业丟;
    protected bool 丙丐万东不丛丗丄丂;
    
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
        System.Comparison<UnityEngine.Transform> val_9;
        var val_10;
        var val_11;
        var val_14;
        System.Comparison<T> val_15;
        val_9 = this.transform;
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_10 = 0;
        goto label_1;
        label_13:
        val_11 = 0;
        UnityEngine.Transform val_3 = val_9.GetChild(index:  0);
        if(this.hideInactive != false)
        {
                if(((UnityEngine.Object.op_Implicit(exists:  val_3)) == false) || ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_3.gameObject)) == false))
        {
            goto label_10;
        }
        
        }
        
        val_11 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        val_2.Add(item:  val_3);
        label_10:
        val_10 = 1;
        label_1:
        if(val_10 < val_9.childCount)
        {
            goto label_13;
        }
        
        if(this.sorting <= 3)
        {
                var val_9 = 106066132 + (this.sorting) << 2;
            val_9 = val_9 + 106066132;
        }
        else
        {
                val_9 = this.onCustomSort;
            if(val_9 == null)
        {
                return val_2;
        }
        
            val_14 = 1152921531093977680;
            val_15 = val_9;
            val_2.Sort(comparison:  null);
            return val_2;
        }
    
    }
    protected virtual void 万万丘丙丗丈丘丙丁(System.Collections.Generic.List<UnityEngine.Transform> 丝丘丑业丛万丞丌丝)
    {
        丝丘丑业丛万丞丌丝.Sort(comparison:  new System.Comparison<UnityEngine.Transform>(object:  0, method:  public static System.Int32 UIGrid::SortByName(UnityEngine.Transform 丆丛丑世下一丐且丕, UnityEngine.Transform 丌丗丏丏丛东专丁且)));
    }
    protected virtual void Start()
    {
        this.enabled = false;
    }
    protected virtual void 丘上丐世丆丑且丞丒()
    {
        this.丕丞且丐丙万丆业丟 = true;
        this.与业丌丄且丁丛与丁 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
    }
    protected virtual void LateUpdate()
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
        goto typeof(UITable).__il2cppRuntimeField_1A8;
    }
    protected void 丌丘丛丄丈丕上丝丕(System.Collections.Generic.List<UnityEngine.Transform> 丄丄丘丈专丅下丘丌)
    {
        var val_11;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        UnityEngine.Bounds[] val_53;
        var val_54;
        var val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        var val_63;
        float val_65;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        float val_71;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        var val_76;
        UnityEngine.Object val_77;
        val_49 = 丄丄丘丈专丅下丘丌;
        val_50 = this;
        if(this.columns < 1)
        {
            goto label_1;
        }
        
        val_51 = this.columns;
        if(val_51 > 0)
        {
            goto label_3;
        }
        
        label_64:
        val_51 = val_49.Count;
        label_3:
        UnityEngine.Bounds[] val_5 = new UnityEngine.Bounds[0];
        UnityEngine.Bounds[] val_6 = new UnityEngine.Bounds[0];
        val_52 = val_49;
        int val_7 = val_52.Count;
        val_53 = val_5;
        val_54 = null;
        if(val_7 >= 1)
        {
                var val_48 = 0;
            val_55 = 0;
            do
        {
            UnityEngine.Transform val_8 = val_52.Item[0];
            UnityEngine.Bounds val_10 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_8, 三世与丌丈丈丅丒三:  (this.hideInactive == false) ? 1 : 0);
            UnityEngine.Vector3 val_12 = val_8.localScale;
            val_56 = val_12.x;
            val_57 = val_12.z;
            val_58 = val_12.y;
            val_59 = val_12.x;
            val_60 = val_58;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_59, y = val_60, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_56, y = val_12.y, z = val_57});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_56, y = val_12.y, z = val_57});
            val_49 = val_52;
            val_54 = null;
            mem2[0] = val_11;
            mem2[0] = (long)(val_49.Count / val_51) + 1;
            var val_46 = 24;
            val_46 = val_53 + (0 * val_46);
            var val_17 = val_46 + 32;
            val_52 = val_49;
            var val_47 = 24;
            val_47 = val_6 + (0 * val_47);
            var val_18 = val_47 + 32;
            val_48 = val_48 + 1;
            if(val_48 >= this.columns)
        {
                var val_19 = (this.columns > 0) ? (val_55 + 1) : (val_55);
            var val_20 = (this.columns < 1) ? (val_48) : 0;
        }
        
            val_63 = 0 + 1;
        }
        while(val_7 != val_63);
        
        }
        
        UnityEngine.Vector2 val_21 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.cellAlignment);
        int val_22 = val_52.Count;
        if(val_22 < 1)
        {
            goto label_21;
        }
        
        float val_52 = 0f;
        label_46:
        UnityEngine.Transform val_23 = val_52.Item[0];
        val_53 = val_52;
        var val_49 = 24;
        val_49 = val_5 + (0 * val_49);
        val_49 = 1152921504838422528;
        var val_50 = 24;
        val_50 = val_6 + (0 * val_50);
        val_50 = val_50;
        UnityEngine.Vector3 val_26 = val_23.localPosition;
        if((this.centerLastLine == false) || (0 == 0))
        {
            goto label_33;
        }
        
        int val_51 = this.columns;
        val_51 = val_22 / val_51;
        if(0 != val_51)
        {
            goto label_33;
        }
        
        val_65 = val_26.x;
        val_66 = val_26.x + val_26.x;
        goto label_34;
        label_33:
        val_66 = val_26.x;
        val_65 = val_26.x;
        label_34:
        val_26.x = val_26.x - val_26.x;
        val_26.x = val_26.x - val_26.x;
        val_67 = (0f + val_66) - val_65;
        UnityEngine.Vector2 val_53 = this.padding;
        val_68 = (UnityEngine.Mathf.Lerp(a:  0f, b:  val_26.x + val_26.x, t:  val_21.x)) - val_53;
        if(this.direction != 0)
        {
                val_52 = (val_52 + val_53) - val_53;
            val_69 = val_53;
            float val_31 = val_53 - val_53;
            val_31 = val_31 - val_53;
            val_53 = val_31 + val_69;
            val_71 = val_26.z;
            val_72 = (UnityEngine.Mathf.Lerp(a:  0f, b:  val_53, t:  val_21.y)) - val_53;
            val_73 = val_52 - val_72;
            val_74 = val_52;
            val_75 = 0f;
            val_67 = val_67;
            val_68 = val_68;
        }
        else
        {
                float val_54 = -val_52;
            val_54 = val_54 - val_53;
            val_52 = val_54 - val_53;
            val_69 = val_53;
            float val_33 = val_53 - val_53;
            val_33 = val_33 - val_53;
            val_33 = val_33 + val_69;
            val_71 = val_26.z;
            val_72 = (UnityEngine.Mathf.Lerp(a:  val_33, b:  0f, t:  val_21.y)) - 0f;
            val_73 = val_52 + val_72;
            val_74 = val_52;
            val_75 = 0f;
        }
        
        val_58 = val_67 - val_68;
        UnityEngine.Vector2 val_55 = this.padding;
        val_55 = val_55 + val_55;
        val_56 = val_72 + val_55;
        val_59 = val_58;
        val_60 = val_73;
        val_57 = val_75 + val_56;
        val_23.localPosition = new UnityEngine.Vector3() {x = val_59, y = val_60, z = val_71};
        val_55 = 0 + 1;
        if((val_55 >= this.columns) && (this.columns >= 1))
        {
                val_55 = 0;
            val_57 = 0f;
            val_59 = val_59 + val_59;
            val_59 = val_60 + val_59;
            val_74 = val_74 + val_59;
        }
        
        val_63 = 0 + 1;
        if(val_22 != val_63)
        {
            goto label_46;
        }
        
        label_21:
        if(this.pivot == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_35 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.pivot);
        UnityEngine.Transform val_36 = this.transform;
        val_50 = val_36;
        UnityEngine.Bounds val_37 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_36);
        val_57 = (long)(val_49.Count / val_51) + 1;
        val_56 = UnityEngine.Mathf.Lerp(a:  0f, b:  val_57, t:  val_35.x);
        float val_39 = UnityEngine.Mathf.Lerp(a:  -val_57, b:  0f, t:  val_35.y);
        val_53 = 1152921531083270528;
        val_76 = 0;
        val_63 = 24;
        goto label_50;
        label_62:
        val_49 = val_50.GetChild(index:  0);
        val_77 = val_49.GetComponent<SpringPosition>();
        if(val_77 == 0)
        {
            goto label_55;
        }
        
        if(val_77 == null)
        {
            goto label_56;
        }
        
        UnityEngine.Vector3 val_56 = val_41.target;
        val_56 = val_56 - val_56;
        mem2[0] = val_56;
        goto label_57;
        label_55:
        UnityEngine.Vector3 val_43 = val_49.localPosition;
        val_57 = val_43.z;
        val_58 = val_43.y - val_39;
        val_49.localPosition = new UnityEngine.Vector3() {x = val_43.x - val_56, y = val_58, z = val_57};
        goto label_60;
        label_56:
        float val_57 = 6.606506E-38f;
        val_57 = val_57 - val_56;
        mem[24] = val_57;
        val_77 = 24;
        label_57:
        float val_58 = 0f;
        val_58 = val_58 - val_39;
        mem[28] = val_58;
        label_60:
        val_76 = 1;
        label_50:
        if(val_76 < val_50.childCount)
        {
            goto label_62;
        }
        
        return;
        label_1:
        if(val_49 != null)
        {
            goto label_64;
        }
        
        goto label_64;
    }
    public virtual void Reposition()
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_10;
        if((UnityEngine.Application.isPlaying != false) && (this.丕丞且丐丙万丆业丟 != true))
        {
                bool val_2 = 不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this);
        }
        
        this.丙丐万东不丛丗丄丂 = false;
        val_10 = this.GetChildList();
        if(val_10.Count >= 1)
        {
                this.丌丘丛丄丈丕上丝丕(丄丄丘丈专丅下丘丌:  val_10);
        }
        
        if(this.keepWithinPanel != false)
        {
                val_10 = this.与业丌丄且丁丛与丁;
            if(val_10 != 0)
        {
                val_10 = this.与业丌丄且丁丛与丁;
            bool val_7 = val_10.ConstrainTargetToBounds(丞下万上三丘上与专:  this.transform, 丌丄丗七丝丘与丆与:  true);
            bool val_9 = UnityEngine.Object.op_Inequality(x:  this.与业丌丄且丁丛与丁.GetComponent<UIScrollView>(), y:  0);
        }
        
        }
        
        if(this.onReposition == null)
        {
                return;
        }
        
        this.onReposition.Invoke();
    }
    public UITable()
    {
        this.hideInactive = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.padding = val_1;
        mem[1152921531136392084] = val_1.y;
    }

}
