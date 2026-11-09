using UnityEngine;
public class UIWrapContent : MonoBehaviour
{
    // Fields
    public int itemSize;
    public bool cullContent;
    public bool CanOverrideRestrictWithingPanel;
    public int minIndex;
    public int maxIndex;
    public UIWrapContent.丙丏丒丐丑三丆丝世 onInitializeItem;
    public UIWrapContent.专丅七丘一丄丅丞丟 onStarted;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected UIPanel 与业丌丄且丁丛与丁;
    protected UIScrollView 丈世丙业业七丟不丒;
    protected bool 世丕丕丝丌一丞世三;
    protected bool 丈且丌业万丙丏丆不;
    protected System.Collections.Generic.List<UnityEngine.Transform> 与不丆业丌下丞丙与;
    
    // Methods
    protected virtual void Start()
    {
        if(this.丈世丙业业七丟不丒 != 0)
        {
                UIPanel val_2 = this.丈世丙业业七丟不丒.GetComponent<UIPanel>();
            val_2.onClipMove = new UIPanel.上丟丟且丁且丅丏丆(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(UIWrapContent).__il2cppRuntimeField_180);
        }
        
        this.丈且丌业万丙丏丆不 = false;
        if(this.onStarted == null)
        {
                return;
        }
        
        this.onStarted.Invoke();
    }
    protected virtual void 丞三三丆丁丗丈专丞(UIPanel 丛丘下丗业丂一且业)
    {
        goto typeof(UIWrapContent).__il2cppRuntimeField_1C8;
    }
    public virtual void SortBasedOnScrollMovement()
    {
        var val_5;
        IntPtr val_6;
        if(this.与丕一丝丟丟丐丈与() == false)
        {
                return;
        }
        
        this.与不丆业丌下丞丙与.Clear();
        val_5 = 0;
        goto label_3;
        label_7:
        this.与不丆业丌下丞丙与.Add(item:  this.丐一丗丛丕世丘东丁.GetChild(index:  0));
        val_5 = 1;
        label_3:
        if(val_5 < this.丐一丗丛丕世丘东丁.childCount)
        {
            goto label_7;
        }
        
        if(this.世丕丕丝丌一丞世三 != false)
        {
                val_6 = 1152921531093976656;
        }
        else
        {
                val_6 = 1152921531093971536;
        }
        
        System.Comparison<UnityEngine.Transform> val_4 = new System.Comparison<UnityEngine.Transform>(object:  0, method:  val_6);
        this.与不丆业丌下丞丙与.Sort(comparison:  null);
        goto typeof(UIWrapContent).__il2cppRuntimeField_1B8;
    }
    public virtual void SortAlphabetically()
    {
        var val_12;
        var val_13;
        val_12 = this;
        if(this.与丕一丝丟丟丐丈与() == false)
        {
                return;
        }
        
        this.与不丆业丌下丞丙与.Clear();
        val_13 = 0;
        goto label_3;
        label_7:
        X21.Add(item:  this.丐一丗丛丕世丘东丁.GetChild(index:  0));
        val_13 = 1;
        label_3:
        if(val_13 < this.丐一丗丛丕世丘东丁.childCount)
        {
            goto label_7;
        }
        
        this.与不丆业丌下丞丙与.Sort(comparison:  new System.Comparison<UnityEngine.Transform>(object:  0, method:  public static System.Int32 UIGrid::SortByName(UnityEngine.Transform 丆丛丑世下一丐且丕, UnityEngine.Transform 丌丗丏丏丛东专丁且)));
        val_12 = ???;
        goto typeof(UIWrapContent).__il2cppRuntimeField_1B8;
    }
    public virtual void SortByPositions()
    {
        var val_11;
        var val_12;
        val_11 = this;
        if(this.与丕一丝丟丟丐丈与() == false)
        {
                return;
        }
        
        this.与不丆业丌下丞丙与.Clear();
        val_12 = 0;
        goto label_3;
        label_7:
        this.与不丆业丌下丞丙与.Add(item:  this.丐一丗丛丕世丘东丁.GetChild(index:  0));
        val_12 = 1;
        label_3:
        if(val_12 < this.丐一丗丛丕世丘东丁.childCount)
        {
            goto label_7;
        }
        
        val_11 = ???;
        goto typeof(UIWrapContent).__il2cppRuntimeField_1B8;
    }
    protected bool 与丕一丝丟丟丐丈与()
    {
        bool val_6;
        this.丐一丗丛丕世丘东丁 = this.transform;
        UIPanel val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        this.与业丌丄且丁丛与丁 = val_3;
        UIScrollView val_4 = val_3.GetComponent<UIScrollView>();
        this.丈世丙业业七丟不丒 = val_4;
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        if(this.丈世丙业业七丟不丒.movement == 0)
        {
            goto label_8;
        }
        
        if(this.丈世丙业业七丟不丒.movement == 1)
        {
                val_6 = 1;
            this.世丕丕丝丌一丞世三 = false;
            return val_6;
        }
        
        label_10:
        val_6 = 0;
        return val_6;
        label_8:
        val_6 = true;
        this.世丕丕丝丌一丞世三 = val_6;
        return val_6;
    }
    protected virtual void 上丆上不丁一丗不世()
    {
        int val_1 = this.与不丆业丌下丞丙与.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            int val_3 = this.itemSize;
            if(this.世丕丕丝丌一丞世三 != false)
        {
                val_3 = val_3 * val_4;
        }
        else
        {
                val_3 = -(val_4 * val_3);
        }
        
            this.与不丆业丌下丞丙与.Item[0].localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_4 = val_4 + 1;
        }
        while(val_4 != val_1);
    
    }
    public virtual void WrapContent()
    {
        UIScrollView val_48;
        float val_49;
        var val_50;
        int val_51;
        var val_52;
        float val_54;
        int val_55;
        System.Collections.Generic.List<UnityEngine.Transform> val_56;
        float val_57;
        var val_58;
        float val_59;
        float val_60;
        var val_64;
        float val_65;
        float val_67;
        bool val_68;
        int val_69;
        float val_70;
        float val_71;
        var val_75;
        float val_77;
        val_48 = this;
        if(this.与业丌丄且丁丛与丁 == 0)
        {
                return;
        }
        
        val_49 = 0.5f;
        float val_4 = ((float)this.与不丆业丌下丞丙与.Count * this.itemSize) * val_49;
        val_50 = 0;
        val_51 = 12;
        goto label_6;
        label_11:
        val_52 = 32;
        UnityEngine.Vector3 val_5 = this.丐一丗丛丕世丘东丁.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f});
        val_49 = val_5.y;
        val_50 = 1;
        mem[32] = val_5.x;
        mem[36] = val_49;
        mem[40] = val_5.z;
        label_6:
        if(val_50 < 4)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_49, z = val_5.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
        val_54 = val_6.x;
        float val_7 = val_4 + val_4;
        if(this.世丕丕丝丌一丞世三 == false)
        {
            goto label_17;
        }
        
        val_55 = this.itemSize;
        val_51 = val_55;
        val_51 = this.itemSize;
        val_56 = this.与不丆业丌下丞丙与;
        int val_8 = val_56.Count;
        if(val_8 < 1)
        {
            goto label_55;
        }
        
        val_51 = 1152921519067103504;
        val_52 = 1152921505096622080;
        float val_37 = (float)val_55;
        val_37 = val_6.y - val_37;
        val_58 = 1;
        val_59 = val_5.z + (float)val_51;
        label_51:
        UnityEngine.Transform val_9 = this.与不丆业丌下丞丙与.Item[0];
        if(val_9 == 0)
        {
            goto label_47;
        }
        
        UnityEngine.Vector3 val_11 = val_9.localPosition;
        val_60 = val_11.x - val_54;
        if(val_60 >= 0)
        {
            goto label_26;
        }
        
        UnityEngine.Vector3 val_12 = val_9.localPosition;
        val_64 = null;
        val_55 = this.itemSize;
        val_65 = val_12.y;
        val_57 = val_12.z;
        val_67 = val_7 + val_12.x;
        goto label_33;
        label_26:
        if(val_60 <= val_4)
        {
            goto label_30;
        }
        
        UnityEngine.Vector3 val_13 = val_9.localPosition;
        val_64 = null;
        val_55 = this.itemSize;
        val_65 = val_13.y;
        val_57 = val_13.z;
        val_67 = val_13.x - val_7;
        label_33:
        val_59 = val_67 / (float)val_55;
        val_60 = val_67 - val_54;
        int val_14 = UnityEngine.Mathf.RoundToInt(f:  val_59);
        if(this.minIndex != this.maxIndex)
        {
                if((this.minIndex > val_14) || (val_14 > this.maxIndex))
        {
            goto label_36;
        }
        
        }
        
        val_59 = val_67;
        val_9.localPosition = new UnityEngine.Vector3() {x = val_59, y = val_65, z = val_57};
        goto label_40;
        label_30:
        if(this.丈且丌业万丙丏丆不 == false)
        {
            goto label_40;
        }
        
        goto label_40;
        label_36:
        val_58 = 0;
        label_40:
        if(this.cullContent != false)
        {
                UnityEngine.Vector2 val_15 = this.与业丌丄且丁丛与丁.clipOffset;
            float val_38 = val_15.x;
            UnityEngine.Vector3 val_16 = this.丐一丗丛丕世丘东丁.localPosition;
            val_57 = val_16.x;
            val_55 = val_9.gameObject;
            if((UICamera.IsPressed(丝三丁东丈丒世丅业:  val_55)) != true)
        {
                val_16.x = val_38 - val_57;
            val_38 = val_60 + val_16.x;
            val_55 = ((val_38 > val_37) ? 1 : 0) & ((val_38 < 0) ? 1 : 0);
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_9.gameObject, 丏业丟一东丂东丘丛:  val_55, 与丟丗下丌丐丕丛丁:  false);
        }
        
        }
        
        label_47:
        val_56 = 0 + 1;
        if(val_8 != val_56)
        {
            goto label_51;
        }
        
        val_68 = val_58 & 1;
        goto label_84;
        label_17:
        val_55 = this.itemSize;
        val_69 = val_55;
        val_69 = this.itemSize;
        val_56 = this.与不丆业丌下丞丙与;
        int val_22 = val_56.Count;
        if(val_22 < 1)
        {
            goto label_55;
        }
        
        float val_39 = (float)val_55;
        val_70 = (float)val_69;
        val_39 = val_54 - val_39;
        val_51 = 1152921519067103504;
        val_52 = 1152921505096622080;
        float val_23 = val_5.z + val_70;
        val_68 = 1;
        label_83:
        UnityEngine.Transform val_24 = this.与不丆业丌下丞丙与.Item[0];
        UnityEngine.Vector3 val_25 = val_24.localPosition;
        val_71 = val_25.y - val_6.y;
        if(val_71 >= 0)
        {
            goto label_58;
        }
        
        UnityEngine.Vector3 val_26 = val_24.localPosition;
        val_75 = null;
        val_55 = this.itemSize;
        val_54 = val_26.x;
        val_57 = val_26.z;
        val_77 = val_7 + val_26.y;
        goto label_65;
        label_58:
        if(val_71 <= val_4)
        {
            goto label_62;
        }
        
        UnityEngine.Vector3 val_27 = val_24.localPosition;
        val_75 = null;
        val_55 = this.itemSize;
        val_54 = val_27.x;
        val_57 = val_27.z;
        val_77 = val_27.y - val_7;
        label_65:
        float val_40 = (float)val_55;
        val_40 = val_77 / val_40;
        val_71 = val_77 - val_6.y;
        int val_28 = UnityEngine.Mathf.RoundToInt(f:  val_40);
        if(this.minIndex != this.maxIndex)
        {
                if((this.minIndex > val_28) || (val_28 > this.maxIndex))
        {
            goto label_68;
        }
        
        }
        
        val_70 = val_77;
        val_24.localPosition = new UnityEngine.Vector3() {x = val_54, y = val_70, z = val_57};
        goto label_72;
        label_62:
        if(this.丈且丌业万丙丏丆不 == false)
        {
            goto label_72;
        }
        
        goto label_72;
        label_68:
        val_68 = 0;
        label_72:
        if(this.cullContent != false)
        {
                UnityEngine.Vector2 val_29 = this.与业丌丄且丁丛与丁.clipOffset;
            val_54 = val_29.y;
            UnityEngine.Vector3 val_30 = this.丐一丗丛丕世丘东丁.localPosition;
            val_57 = val_30.y;
            val_55 = val_24.gameObject;
            if((UICamera.IsPressed(丝三丁东丈丒世丅业:  val_55)) != true)
        {
                val_54 = val_71 + (val_54 - val_57);
            val_55 = ((val_54 > val_39) ? 1 : 0) & ((val_54 < 0) ? 1 : 0);
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_24.gameObject, 丏业丟一东丂东丘丛:  val_55, 与丟丗下丌丐丕丛丁:  false);
        }
        
        }
        
        val_56 = 0 + 1;
        if(val_22 != val_56)
        {
            goto label_83;
        }
        
        goto label_84;
        label_55:
        val_68 = true;
        label_84:
        if(this.CanOverrideRestrictWithingPanel == false)
        {
                return;
        }
        
        val_48 = this.丈世丙业业七丟不丒;
        bool val_41 = val_68;
        val_41 = val_41 & 1;
        this.丈世丙业业七丟不丒.restrictWithinPanel = val_41;
    }
    private void OnValidate()
    {
        int val_1 = this.maxIndex;
        if(val_1 < this.minIndex)
        {
                val_1 = this.minIndex;
            this.maxIndex = this.minIndex;
        }
        
        if(this.minIndex <= val_1)
        {
                return;
        }
        
        this.maxIndex = this.minIndex;
    }
    protected virtual void 丕下不与与不丞丟丙(UnityEngine.Transform 下丅丙一丂丗丅丝七, int 丞世不丒下上上丝丑)
    {
        float val_4;
        var val_5;
        int val_6;
        if(this.onInitializeItem == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = 下丅丙一丂丗丅丝七.localPosition;
        val_4 = val_1.x;
        if(this.丈世丙业业七丟不丒.movement == 1)
        {
                val_5 = null;
            val_6 = this.itemSize;
            val_4 = val_1.y;
        }
        else
        {
                val_5 = null;
            val_6 = this.itemSize;
        }
        
        float val_4 = (float)val_6;
        val_4 = val_4 / val_4;
        this.onInitializeItem.Invoke(丝三丁东丈丒世丅业:  下丅丙一丂丗丅丝七.gameObject, 丆丘丝丟丑丘丂丘专:  丞世不丒下上上丝丑, 丞丂业丅丟丙丏七丗:  UnityEngine.Mathf.RoundToInt(f:  val_4));
    }
    public UIWrapContent()
    {
        this.itemSize = 100;
        this.cullContent = true;
        this.CanOverrideRestrictWithingPanel = true;
        this.丈且丌业万丙丏丆不 = true;
        this.与不丆业丌下丞丙与 = new System.Collections.Generic.List<UnityEngine.Transform>();
    }

}
