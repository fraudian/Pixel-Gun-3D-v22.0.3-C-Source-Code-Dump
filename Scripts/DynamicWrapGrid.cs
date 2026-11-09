using UnityEngine;
public class DynamicWrapGrid : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject baseViewItem;
    private bool 丟丌丛一下丁世万不;
    private System.Collections.Generic.List<object> 丂上丁丑丈上丛七专;
    private float 丐丂七丞丗丅丁丙丈;
    private bool 七丅丞丆丒丏且丆专;
    public int itemIndexToCenterFromContextMenu;
    public float scrollByValueFromTop;
    private int itemsCount;
    private bool 丟东不丅丙丆专丝丟;
    public bool allowNegativeIndices;
    private float 丒丅业丈丒丗丆丆丁;
    private int 世丈丞丒七丗一三丕;
    internal bool scaleWidth;
    private float scalingWidthValue;
    public bool disableDragIfFits;
    public bool unlimitedContent;
    private float 世丕丞三一丞世与万;
    private UIScrollView scrollView;
    private System.Collections.Generic.List<DynamicWrapGridItem> <专丐不丛丝丁上丝专>k__BackingField;
    private UnityEngine.Coroutine 丟丝业丛七丟上一三;
    public float smoothScrollSpeed;
    private bool 丆丌丏丅丏丑丂丈丌;
    private UIWrapContent <业丐丈三不东丑专丈>k__BackingField;
    private bool 丕丄世丗丌丄丌三且;
    
    // Properties
    public System.Collections.Generic.List<DynamicWrapGridItem> 丒丅丗丕专一丂东丆 { get; set; }
    public UIScrollView 上丛不专丂丐丝丛一 { get; }
    public int 世一丑上三丈丁一丗 { get; }
    public int 丕丝七不丒丞丈丑万 { get; }
    public System.Collections.Generic.List<object> 丂七万东丐丆丌丗丐 { get; }
    public UIWrapContent 七丘丑丝丅三丞与丟 { get; set; }
    public bool 七丘不丗上丈丆丕与 { get; }
    
    // Methods
    public System.Collections.Generic.List<DynamicWrapGridItem> get_GridItems()
    {
        return (System.Collections.Generic.List<DynamicWrapGridItem>)this.<专丐不丛丝丁上丝专>k__BackingField;
    }
    private void 丑三且一丒丑不丄丙(System.Collections.Generic.List<DynamicWrapGridItem> 丙业与丙丗丝不丈东)
    {
        this.<专丐不丛丝丁上丝专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UIScrollView get_ScrollView()
    {
        return (UIScrollView)this.scrollView;
    }
    public int get_ScaledItemWidth()
    {
        return (int)this.世丈丞丒七丗一三丕;
    }
    public int get_ContentCount()
    {
        if(this.丂上丁丑丈上丛七专 == null)
        {
                return (int)this.丂上丁丑丈上丛七专;
        }
        
        return this.丂上丁丑丈上丛七专.Count;
    }
    public System.Collections.Generic.List<object> get_ContentList()
    {
        return (System.Collections.Generic.List<System.Object>)this.丂上丁丑丈上丛七专;
    }
    public UIWrapContent get_wrapContent()
    {
        return (UIWrapContent)this.<业丐丈三不东丑专丈>k__BackingField;
    }
    private void 丌丞业丗丗不专丗丑(UIWrapContent 丙业与丙丗丝不丈东)
    {
        this.<业丐丈三不东丑专丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_isScrollingSmoothNow()
    {
        return (bool)(this.丟丝业丛七丟上一三 != 0) ? 1 : 0;
    }
    private void Awake()
    {
        if(this.丕丄世丗丌丄丌三且 == true)
        {
                return;
        }
        
        this.丒丅业丈丒丗丆丆丁 = 0f;
        this.<业丐丈三不东丑专丈>k__BackingField = this.gameObject.GetComponent<UIWrapContent>();
        this.baseViewItem.SetActive(value:  false);
        this.丕丄世丗丌丄丌三且 = true;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        float val_13;
        var val_14;
        float val_15;
        float val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        if(this.丕丄世丗丌丄丌三且 != true)
        {
                this.Awake();
        }
        
        this.<业丐丈三不东丑专丈>k__BackingField.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void DynamicWrapGrid::丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        val_13 = this.丐丂七丞丗丅丁丙丈;
        if(val_13 < 0)
        {
                int val_3 = UnityEngine.Screen.width;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_14 = null;
            val_14 = null;
            val_15 = IphoneXCameraScaler.不丅七丘丈不丌丝丏 * (float)val_3;
            val_16 = IphoneXCameraScaler.且下丒丘丙丒丈丏万 * (float)UnityEngine.Screen.height;
        }
        else
        {
                val_15 = (float)val_3;
            val_16 = (float)UnityEngine.Screen.height;
        }
        
            val_16 = val_16 / 768f;
            val_13 = val_15 / val_16;
            this.丐丂七丞丗丅丁丙丈 = val_13;
        }
        
        if(this.世丈丞丒七丗一三丕 != 1)
        {
            goto label_15;
        }
        
        if((this.scalingWidthValue <= 0f) || (this.scalingWidthValue < 1f))
        {
            goto label_12;
        }
        
        val_17 = val_13 - this.scalingWidthValue;
        goto label_13;
        label_12:
        if((this.scalingWidthValue <= 0f) || (this.scalingWidthValue >= 0))
        {
            goto label_15;
        }
        
        val_17 = this.scalingWidthValue * val_13;
        label_13:
        this.世丈丞丒七丗一三丕 = (int)val_17;
        label_15:
        this.<专丐不丛丝丁上丝专>k__BackingField = new System.Collections.Generic.List<DynamicWrapGridItem>(capacity:  this.itemsCount);
        if(this.itemsCount >= 1)
        {
                val_18 = 1152921504622075904;
            val_19 = 1152921505284374528;
            val_20 = 1152921537139089584;
            val_21 = 1152921537139090608;
            object val_13 = 0;
            do
        {
            UnityEngine.GameObject val_8 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.baseViewItem);
            val_8.name = System.String.Format(format:  "{0}_{1:000}", arg0:  val_8.name, arg1:  val_13);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            if((this.世丈丞丒七丗一三丕 >= 1) && (this.scaleWidth != false))
        {
                val_8.GetComponent<UIWidget>().width = this.世丈丞丒七丗一三丕;
            val_18 = val_18;
            val_19 = val_19;
            val_20 = val_20;
            val_21 = 1152921537139090608;
        }
        
            this.<专丐不丛丝丁上丝专>k__BackingField.Add(item:  val_8.GetComponent<DynamicWrapGridItem>());
            val_13 = val_13 + 1;
        }
        while(val_13 < this.itemsCount);
        
        }
        
        this.<业丐丈三不东丑专丈>k__BackingField.cullContent = false;
        this.scrollView.disableDragIfFits = this.disableDragIfFits;
        this.七丅丞丆丒丏且丆专 = true;
    }
    private void 丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        DynamicWrapGridItem val_1 = 丝三丁东丈丒世丅业.GetComponent<DynamicWrapGridItem>();
        if(this.allowNegativeIndices == false)
        {
            goto label_2;
        }
        
        label_7:
        val_1.wrapIndex = 一丁丂丈下世丗丟丛;
        this.UpdateViewItem(丘不丈与丆七丛丞七:  val_1);
        return;
        label_2:
        var val_2 = (一丁丂丈下世丗丟丛 < 0) ? (-一丁丂丈下世丗丟丛) : 一丁丂丈下世丗丟丛;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public void UpdateViewItem(DynamicWrapGridItem 丘不丈与丆七丛丞七)
    {
        bool val_17;
        var val_18;
        int val_19;
        int val_20;
        var val_21;
        if(丘不丈与丆七丛丞七 == 0)
        {
                return;
        }
        
        if(this.丂上丁丑丈上丛七专.Count == 0)
        {
            goto label_5;
        }
        
        val_17 = this.unlimitedContent;
        if(丘不丈与丆七丛丞七 == null)
        {
            goto label_6;
        }
        
        if(val_17 == false)
        {
            goto label_7;
        }
        
        label_16:
        丘不丈与丆七丛丞七.gameObject.SetActive(value:  true);
        if(this.丟丌丛一下丁世万不 == false)
        {
                return;
        }
        
        if(丘不丈与丆七丛丞七 == null)
        {
            goto label_10;
        }
        
        val_18 = 丘不丈与丆七丛丞七;
        val_19 = 丘不丈与丆七丛丞七.wrapIndex;
        if((val_19 & 2147483648) != 0)
        {
            goto label_11;
        }
        
        label_25:
        int val_4 = this.丂上丁丑丈上丛七专.Count;
        val_20 = val_19 - ((val_19 / val_4) * val_4);
        goto label_13;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丘不丈与丆七丛丞七, 丏业丟一东丂东丘丛:  false);
        return;
        label_6:
        if(val_17 == true)
        {
            goto label_16;
        }
        
        label_7:
        if((丘不丈与丆七丛丞七.wrapIndex & 2147483648) != 0)
        {
            goto label_19;
        }
        
        val_17 = this.丂上丁丑丈上丛七专;
        if(丘不丈与丆七丛丞七.wrapIndex >= val_17.Count)
        {
            goto label_19;
        }
        
        丘不丈与丆七丛丞七.gameObject.SetActive(value:  true);
        if(this.丟丌丛一下丁世万不 == false)
        {
                return;
        }
        
        val_20 = 丘不丈与丆七丛丞七.wrapIndex;
        val_21 = public System.Object System.Collections.Generic.List<System.Object>::get_Item(int index);
        object val_8 = this.丂上丁丑丈上丛七专.Item[val_20];
        goto typeof(DynamicWrapGridItem).__il2cppRuntimeField_178;
        label_19:
        丘不丈与丆七丛丞七.gameObject.SetActive(value:  false);
        return;
        label_10:
        val_18 = 24;
        val_19 = 28563616;
        if((28563616 & 2147483648) == 0)
        {
            goto label_25;
        }
        
        label_11:
        var val_10 = (val_19 < 0) ? (-val_19) : (val_19);
        var val_17 = this.丂上丁丑丈上丛七专.Count;
        val_17 = val_10 / val_17;
        val_10 = val_17 + 1;
        int val_13 = this.丂上丁丑丈上丛七专.Count;
        int val_14 = val_18 + (this.丂上丁丑丈上丛七专.Count * val_10);
        val_20 = val_14 - ((val_14 / val_13) * val_13);
        label_13:
        val_21 = public System.Object System.Collections.Generic.List<System.Object>::get_Item(int index);
        object val_16 = this.丂上丁丑丈上丛七专.Item[val_20];
        goto typeof(DynamicWrapGridItem).__il2cppRuntimeField_178;
    }
    public void SetContent(System.Collections.Generic.List<object> 三丏丑不业丏不丂丈, bool 业丛丛世上丈丘丄东 = False)
    {
        T val_4;
        var val_5;
        if(三丏丑不业丏不丂丈 == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this.丂上丁丑丈上丛七专 = 三丏丑不业丏不丂丈;
        if(this.七丅丞丆丒丏且丆专 != true)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if(this.unlimitedContent == false)
        {
            goto label_4;
        }
        
        if((this.<业丐丈三不东丑专丈>k__BackingField) != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        this.<业丐丈三不东丑专丈>k__BackingField.minIndex = 0;
        bool val_4 = ~业丛丛世上丈丘丄东;
        val_4 = val_4 & 1;
        this.丟丌丛一下丁世万不 = val_4;
        val_4 = 1;
        val_5 = 0;
        goto label_8;
        label_11:
        val_4 = this.<业丐丈三不东丑专丈>k__BackingField.GetComponentsInChildren<DynamicWrapGridItem>(includeInactive:  true)[0];
        this.UpdateViewItem(丘不丈与丆七丛丞七:  val_4);
        val_5 = 1;
        label_8:
        if(val_5 < val_1.Length)
        {
            goto label_11;
        }
        
        this.scrollView.ResetPosition();
        this.丒丅业丈丒丗丆丆丁 = 0f;
        return;
        label_1:
        System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
        if(this != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_4:
        System.Collections.Generic.List<System.Object> val_5 = this.丂上丁丑丈上丛七专;
        val_5 = 1 - val_5.Count;
        if((this.<业丐丈三不东丑专丈>k__BackingField) != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    public int GetItemContentIndex(object 下丛丅一丌丏丏丕丐)
    {
        if(this.丂上丁丑丈上丛七专 == null)
        {
                return 0;
        }
        
        return this.丂上丁丑丈上丛七专.IndexOf(item:  下丛丅一丌丏丏丕丐);
    }
    public void ScrollFromStart(float 丙业与丙丗丝不丈东, bool 且丈丌丅业丅下万三)
    {
        if(this.丟丝业丛七丟上一三 != null)
        {
                this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
        }
        
        this.scrollView.ResetPosition();
        this.丒丅业丈丒丗丆丆丁 = 0f;
        this.世丕丞三一丞世与万 = 丙业与丙丗丝不丈东;
        this.丟东不丅丙丆专丝丟 = true;
        this.丆丌丏丅丏丑丂丈丌 = 且丈丌丅业丅下万三;
    }
    private float 丌丕世丞世丏万丌东(float 丌丈丒丞七七丟丄业, int 世万专丛与丐丌专不)
    {
        var val_27;
        float val_28;
        UIWrapContent val_29;
        UIScrollView val_30;
        float val_32;
        UIScrollView val_33;
        UIWrapContent val_34;
        UIWrapContent val_35;
        val_28 = 丌丈丒丞七七丟丄业;
        val_29 = this;
        if(this.丂上丁丑丈上丛七专 == null)
        {
            goto label_1;
        }
        
        val_27 = 世万专丛与丐丌专不 & (~(世万专丛与丐丌专不 >> 31));
        if(val_27 > (this.丂上丁丑丈上丛七专.Count - 1))
        {
                val_27 = this.丂上丁丑丈上丛七专.Count - 1;
        }
        
        val_30 = this.scrollView;
        if(val_30 == null)
        {
            goto label_4;
        }
        
        var val_4 = (this.scrollView.movement == 0) ? 1 : 0;
        goto label_7;
        label_1:
        val_32 = 0f;
        return (float)val_32;
        label_4:
        val_30 = this.scrollView;
        label_7:
        UnityEngine.Vector2 val_7 = val_30.panel.GetViewSize();
        val_33 = this.scrollView;
        float val_8 = (((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_7.x : val_7.y;
        if(val_33 != null)
        {
                var val_9 = (this.scrollView.movement == 0) ? 1 : 0;
        }
        else
        {
                val_33 = this.scrollView;
        }
        
        UnityEngine.Vector2 val_12 = val_33.panel.clipSoftness;
        float val_13 = (((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_12.x : val_12.y;
        if(this.unlimitedContent != false)
        {
                val_29 = this.<业丐丈三不东丑专丈>k__BackingField;
            float val_24 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_24 = val_24 * 0.5f;
            val_8 = (val_8 - val_13) * 0.5f;
            val_28 = val_8 - (val_24 + ((float)(this.<业丐丈三不东丑专丈>k__BackingField.itemSize) * val_27));
            val_32 = System.Math.Abs(val_28) * ((float)System.Math.Sign(value:  val_28));
            return (float)val_32;
        }
        
        val_34 = this.<业丐丈三不东丑专丈>k__BackingField;
        val_35 = val_34;
        if(val_34 != null)
        {
            goto label_19;
        }
        
        val_35 = this.<业丐丈三不东丑专丈>k__BackingField;
        if(val_35 == null)
        {
            goto label_20;
        }
        
        label_19:
        float val_26 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        val_26 = val_26 * 0.5f;
        float val_20 = (val_8 * 0.5f) - val_26;
        val_8 = ((float)(this.<业丐丈三不东丑专丈>k__BackingField.itemSize) * val_27) - val_20;
        float val_27 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        val_8 = val_8 - val_28;
        val_27 = val_27 * 0.5f;
        int val_29 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        var val_28 = ~val_27;
        val_28 = this.丂上丁丑丈上丛七专.Count + val_28;
        val_32 = val_8 + val_27;
        val_29 = val_29 * val_28;
        if(val_20 > (float)val_29)
        {
                val_29 = this.<业丐丈三不东丑专丈>k__BackingField;
            float val_30 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_30 = val_30 * 0.5f;
            val_30 = (val_20 - (float)val_29) + val_30;
            val_30 = val_32 - val_30;
            val_32 = (val_13 + val_13) + val_30;
        }
        
        val_30 = val_32 + val_28;
        if(val_30 >= 0)
        {
                return (float)val_32;
        }
        
        val_32 = 0f - val_28;
        return (float)val_32;
        label_20:
    }
    public void ScrollToCenterOnItem(int 世万专丛与丐丌专不)
    {
        this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  世万专丛与丐丌专不), 且丈丌丅业丅下万三:  true);
        this.丒丅业丈丒丗丆丆丁 = 0f;
    }
    public void ScrollToCenterOnItem(object 丙丈下丕丑专上丕丛)
    {
        if(this.丂上丁丑丈上丛七专 == null)
        {
                return;
        }
        
        this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  this.丂上丁丑丈上丛七专.IndexOf(item:  丙丈下丕丑专上丕丛)), 且丈丌丅业丅下万三:  true);
        this.丒丅业丈丒丗丆丆丁 = 0f;
    }
    public void ScrollToCenterOnItemSmoothBySpeed(int 世万专丛与丐丌专不, float 丗丒丛下与万丗丙丝)
    {
        if(this.丟丝业丛七丟上一三 != null)
        {
                this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
        }
        
        this.丟丝业丛七丟上一三 = this.StartCoroutine(routine:  this.业丝下世丑丌丅专与(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  this.丒丅业丈丒丗丆丆丁, 世万专丛与丐丌专不:  世万专丛与丐丌专不), 丗丒丛下与万丗丙丝:  丗丒丛下与万丗丙丝));
    }
    public void ScrollToCenterOnItemSmoothByTime(int 世万专丛与丐丌专不, float 七不丞世丁丝业丌专)
    {
        if(this.丟丝业丛七丟上一三 != null)
        {
                this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
        }
        
        float val_1 = this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  this.丒丅业丈丒丗丆丆丁, 世万专丛与丐丌专不:  世万专丛与丐丌专不);
        float val_6 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        val_6 = System.Math.Abs(val_1) / val_6;
        this.丟丝业丛七丟上一三 = this.StartCoroutine(routine:  this.业丝下世丑丌丅专与(丙业与丙丗丝不丈东:  val_1, 丗丒丛下与万丗丙丝:  val_6 / 七不丞世丁丝业丌专));
    }
    private System.Collections.IEnumerator 业丝下世丑丌丅专与(float 丙业与丙丗丝不丈东, float 丗丒丛下与万丗丙丝)
    {
        DynamicWrapGrid.世七上与丗且下一且 val_1 = new DynamicWrapGrid.世七上与丗且下一且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丙业与丙丗丝不丈东;
        }
        
        .丗丒丛下与万丗丙丝 = 丗丒丛下与万丗丙丝;
        return (System.Collections.IEnumerator)val_1;
    }
    private void LateUpdate()
    {
        float val_8;
        var val_10;
        float val_11;
        int val_12;
        UIScrollView val_13;
        var val_14;
        if(this.丟东不丅丙丆专丝丟 == false)
        {
                return;
        }
        
        float val_8 = this.丒丅业丈丒丗丆丆丁;
        val_8 = this.世丕丞三一丞世与万;
        val_8 = val_8 + val_8;
        this.丒丅业丈丒丗丆丆丁 = val_8;
        if(val_8 == 0f)
        {
            goto label_22;
        }
        
        float val_9 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        val_9 = val_8 / val_9;
        int val_1 = UnityEngine.Mathf.Abs(value:  (int)val_9);
        val_10 = 0;
        float val_3 = (UnityEngine.Mathf.Sign(f:  this.世丕丞三一丞世与万)) * ((float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize);
        if(this.scrollView.movement == 0)
        {
                float val_10 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_10 = (UnityEngine.Mathf.Sign(f:  this.世丕丞三一丞世与万)) * val_10;
            val_10 = 0;
        }
        
        if(val_1 >= 1)
        {
                var val_11 = val_1;
            do
        {
            val_11 = val_11 - 1;
        }
        while(val_11 != 0);
        
        }
        
        val_11 = this.世丕丞三一丞世与万;
        if((this.<业丐丈三不东丑专丈>k__BackingField) == null)
        {
                val_11 = this.世丕丞三一丞世与万;
        }
        
        val_12 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
        val_11 = (UnityEngine.Mathf.Sign(f:  val_11)) * ((float)val_12 * val_1);
        val_13 = this.scrollView;
        if(this.scrollView == null)
        {
                val_13 = this.scrollView;
        }
        
        val_8 = this.世丕丞三一丞世与万 - val_11;
        if(this.scrollView.movement != 1)
        {
            goto label_19;
        }
        
        val_14 = val_8;
        goto label_20;
        label_19:
        if(this.scrollView.movement != 0)
        {
            goto label_22;
        }
        
        val_13 = this.scrollView;
        val_14 = 0f;
        label_20:
        label_22:
        if(this.丆丌丏丅丏丑丂丈丌 == false)
        {
            goto label_24;
        }
        
        this.丟丌丛一下丁世万不 = true;
        val_12 = 0;
        goto label_26;
        label_29:
        this.UpdateViewItem(丘不丈与丆七丛丞七:  this.<业丐丈三不东丑专丈>k__BackingField.GetComponentsInChildren<DynamicWrapGridItem>(includeInactive:  true)[0]);
        val_12 = 1;
        label_26:
        if(val_12 < val_7.Length)
        {
            goto label_29;
        }
        
        label_24:
        this.丟东不丅丙丆专丝丟 = false;
        this.世丕丞三一丞世与万 = 0f;
    }
    public void UpdateContent(System.Collections.Generic.List<object> 三丏丑不业丏不丂丈)
    {
        var val_4;
        var val_5;
        this.丟丌丛一下丁世万不 = true;
        if((三丏丑不业丏不丂丈 == null) || (this.丂上丁丑丈上丛七专 == null))
        {
            goto label_3;
        }
        
        val_4 = this.丂上丁丑丈上丛七专.Count;
        if(val_4 != 三丏丑不业丏不丂丈.Count)
        {
            goto label_3;
        }
        
        this.丂上丁丑丈上丛七专 = 三丏丑不业丏不丂丈;
        val_5 = 0;
        goto label_5;
        label_8:
        this.UpdateViewItem(丘不丈与丆七丛丞七:  this.<业丐丈三不东丑专丈>k__BackingField.GetComponentsInChildren<DynamicWrapGridItem>(includeInactive:  true)[0]);
        val_5 = 1;
        label_5:
        if(val_5 < val_3.Length)
        {
            goto label_8;
        }
        
        return;
        label_3:
        this.SetContent(三丏丑不业丏不丂丈:  三丏丑不业丏不丂丈, 业丛丛世上丈丘丄东:  false);
    }
    public void CenterOnItemContext()
    {
        this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  this.itemIndexToCenterFromContextMenu), 且丈丌丅业丅下万三:  true);
        this.丒丅业丈丒丗丆丆丁 = 0f;
    }
    public void CenterOnItemSmoothRelativeContext()
    {
        this.ScrollToCenterOnItemSmoothBySpeed(世万专丛与丐丌专不:  this.itemIndexToCenterFromContextMenu, 丗丒丛下与万丗丙丝:  this.smoothScrollSpeed);
    }
    public void ScrollByValue()
    {
        this.ScrollFromStart(丙业与丙丗丝不丈东:  this.scrollByValueFromTop, 且丈丌丅业丅下万三:  true);
    }
    public DynamicWrapGrid()
    {
        this.丐丂七丞丗丅丁丙丈 = -1f;
        this.itemIndexToCenterFromContextMenu = 15;
        this.itemsCount = 10;
        this.世丈丞丒七丗一三丕 = 0;
        this.scalingWidthValue = 20f;
        this.丟丌丛一下丁世万不 = true;
        this.scaleWidth = true;
        this.disableDragIfFits = true;
        this.smoothScrollSpeed = 10f;
    }

}
