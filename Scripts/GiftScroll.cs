using UnityEngine;
public class GiftScroll : MonoBehaviour
{
    // Fields
    internal static bool 丌一丆丛世业专三丑;
    public GiftHUDItem exampleBut;
    public System.Collections.Generic.List<GiftHUDItem> listButton;
    public UnityEngine.GameObject parentButton;
    public UnityEngine.BoxCollider scrollAreaCollider;
    public UIScrollView scrollView;
    public UIWrapContent wrapScript;
    public UnityEngine.AudioClip SpinSound;
    public float offsetNoviceGift;
    internal static bool 下上丐万丅丘丏不丂;
    private bool 专七丘丞不专丗丕丒;
    private bool 丙丙丌丌丈丞不丏丕;
    private int 丈世与三丒丞丌丂丁;
    private bool 与丌丁上丆东三丗丞;
    private UnityEngine.Collider[] 业丄不东丅丒丟世丕;
    private bool 且丙丑七丝专丐丑丐;
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_7;
        if((UnityEngine.Object.op_Implicit(exists:  this.exampleBut)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.exampleBut.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.scrollView = this.GetComponentInParent<UIScrollView>();
        GiftController.丕丝丐丗不不世丌丂(丙业与丙丗丝不丈东:  new System.Action<SlotInfo>(object:  this, method:  System.Void GiftScroll::丛丌上专丘三丌丙丄(SlotInfo 与丄不丌一世东丁丙)));
        val_6 = null;
        val_6 = null;
        GiftScroll.下上丐万丅丘丏不丂 = true;
        if(null == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        this.丈世与三丒丞丌丂丁 = PositionInScroll;
    }
    private void OnEnable()
    {
        七丁丌丒万丄专三三 val_10;
        七丁丌丒万丄专三三 val_11;
        GiftController.不丂一三丈业一丁丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void GiftScroll::UpdateListButton()));
        GiftController.丈三丗世丑丂七丛上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftScroll::丙下与世丕丌与丑丟()));
        GiftController.三丘三上丄丗万丑上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftScroll::丟上不业丛世丂世丅()));
        GiftController.下丅丕丈丗丅上不一(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftScroll::丌丒东丄丐丆且不且(GiftSettingType 上丕与丆丙丆丈丄丁, GiftSettingType 丗丕下东丅丏丕上丏)));
        GiftController.丆丕丝丒不丙且丐丗.ReCreateSlotsIfPossible();
        val_10 = System.Delegate.Combine(a:  this.scrollView.onMomentumMove, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GiftScroll::万丆丂东丗丏与与丙()));
        if(this.scrollView == null)
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
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_9:
        this.scrollView.onMomentumMove = val_10;
        val_11 = System.Delegate.Combine(a:  this.scrollView.onStoppedMoving, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GiftScroll::丟丏丏丂丝专丁三丄()));
        if(this.scrollView == null)
        {
            goto label_11;
        }
        
        if(val_11 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_11 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_15:
        this.scrollView.onStoppedMoving = val_11;
    }
    private void OnDisable()
    {
        七丁丌丒万丄专三三 val_11;
        七丁丌丒万丄专三三 val_12;
        GiftController.丟丆丏丕丞不上丞丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void GiftScroll::UpdateListButton()));
        GiftController.东业丅丏与七上丄且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftScroll::丙下与世丕丌与丑丟()));
        GiftController.世不丘不丑丑丟上下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftScroll::丟上不业丛世丂世丅()));
        GiftController.丘丏丂专业丙上丒丗(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftScroll::丌丒东丄丐丆且不且(GiftSettingType 上丕与丆丙丆丈丄丁, GiftSettingType 丗丕下东丅丏丕上丏)));
        if((this.scrollView != 0) && (this.且丙丑七丝专丐丑丐 != false))
        {
                this.scrollView.StopMomentumForce();
        }
        
        val_11 = System.Delegate.Remove(source:  this.scrollView.onMomentumMove, value:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GiftScroll::万丆丂东丗丏与与丙()));
        if(this.scrollView == null)
        {
            goto label_9;
        }
        
        if(val_11 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_11 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_13:
        this.scrollView.onMomentumMove = val_11;
        val_12 = System.Delegate.Remove(source:  this.scrollView.onStoppedMoving, value:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GiftScroll::丟丏丏丂丝专丁三丄()));
        if(this.scrollView == null)
        {
            goto label_15;
        }
        
        if(val_12 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_12 == null)
        {
            goto label_19;
        }
        
        label_16:
        if(null != null)
        {
                val_12 = 0;
        }
        
        label_19:
        this.scrollView.onStoppedMoving = val_12;
    }
    private void OnDestroy()
    {
        GiftController.丝丐丘东丈业万三丅(丙业与丙丗丝不丈东:  new System.Action<SlotInfo>(object:  this, method:  System.Void GiftScroll::丛丌上专丘三丌丙丄(SlotInfo 与丄不丌一世东丁丙)));
    }
    private void 万丆丂东丗丏与与丙()
    {
        if(this.且丙丑七丝专丐丑丐 != false)
        {
                return;
        }
        
        this.且丙丑七丝专丐丑丐 = true;
    }
    private void 丟丏丏丂丝专丁三丄()
    {
        if(this.且丙丑七丝专丐丑丐 == false)
        {
                return;
        }
        
        this.且丙丑七丝专丐丑丐 = false;
    }
    public void UpdateListButton()
    {
        null = null;
        if(GiftScroll.丌一丆丛世业专三丑 == false)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丕丅丙丆丁丟丏丐丕());
    }
    private void 丌丒东丄丐丆且不且(GiftSettingType 上丕与丆丙丆丈丄丁, GiftSettingType 丗丕下东丅丏丕上丏)
    {
        this.丈世与三丒丞丌丂丁 = 0;
        this.与丌丁上丆东三丗丞 = true;
    }
    private void 丟上不业丛世丂世丅()
    {
        var val_6 = null;
        if(GiftScroll.丌一丆丛世业专三丑 == false)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丛专专丑业不丅业东().GetEnumerator());
    }
    internal void 丙下与世丕丌与丑丟()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(GiftScroll.丌一丆丛世业专三丑 == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_4;
        label_8:
        this.listButton.Item[0].业丞丆丏丆不三专与();
        val_4 = 1;
        label_4:
        if(val_4 < this.listButton.Count)
        {
            goto label_8;
        }
    
    }
    private void 丛丌上专丘三丌丙丄(SlotInfo 与丄不丌一世东丁丙)
    {
        int val_2;
        if(与丄不丌一世东丁丙 != null)
        {
                val_2 = 与丄不丌一世东丁丙;
            int val_1 = val_2.PositionInScroll;
        }
        else
        {
                val_2 = 0;
        }
        
        this.丈世与三丒丞丌丂丁 = val_2;
    }
    private System.Collections.IEnumerable 丛专专丑业不丅业东()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new GiftScroll.丞下丒专丄且丁丕七();
    }
    private System.Collections.IEnumerator 丕丅丙丆丁丟丏丐丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftScroll.世东且世万业丟丂丄();
    }
    public void Sort(bool 三丅万丒与丑且世业 = False)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((GiftScroll.丌一丆丛世业专三丑 != false) && (三丅万丒与丑且世业 != true))
        {
                return;
        }
        
        this.与丌丁上丆东三丗丞 = false;
        val_5 = null;
        val_5 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.UpdateSizeScroll();
        UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丞下丅丐且丑七上与());
    }
    private System.Collections.IEnumerator 丞下丅丐且丑七上与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftScroll.丌丅丅丙世不不七丈();
    }
    private void 下下丝世与世丒丂万(System.Collections.Generic.List<SlotInfo> 三不专丕丞丄丁丛东)
    {
        System.Collections.Generic.IEqualityComparer<TSource> val_59;
        var val_60;
        var val_61;
        var val_63;
        int val_64;
        var val_65;
        System.Func<GiftHUDItem, GiftCategoryType> val_67;
        var val_68;
        System.Func<SlotInfo, GiftCategoryType> val_70;
        System.Func<SlotInfo, System.Boolean> val_73;
        var val_75;
        var val_76;
        var val_78;
        var val_79;
        this.丙丙丌丌丈丞不丏丕 = ((UnityEngine.Mathf.Abs(value:  this.listButton.Count - 三不专丕丞丄丁丛东.Count)) > 0) ? 1 : 0;
        PGCompany.东丑丒丗一丞下丙丙<T> val_6 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
        PGCompany.东丑丒丗一丞下丙丙<T> val_8 = PGCompany.东丑丒丗一丞下丙丙<丙专丒丄丅一丘上丌>.万世丅七一专丕丞不();
        val_59 = this.listButton.Count;
        if(val_59 >= 三不专丕丞丄丁丛东.Count)
        {
            goto label_14;
        }
        
        丙万丝丙与下丄丑丗 val_13 = null;
        val_59 = val_13;
        val_13 = new 丙万丝丙与下丄丑丗();
        val_8.AddRange(collection:  System.Linq.Enumerable.Except<丙专丒丄丅一丘上丌>(first:  System.Linq.Enumerable.Cast<丙专丒丄丅一丘上丌>(source:  三不专丕丞丄丁丛东), second:  System.Linq.Enumerable.Cast<丙专丒丄丅一丘上丌>(source:  this.listButton), comparer:  val_13));
        val_60 = 0;
        goto label_16;
        label_31:
        val_61 = null;
        val_61 = null;
        var val_63 = 0;
        val_63 = val_63 + 1;
        GiftHUDItem val_19 = this.丗丈丄丞丗丐丏丒与(与丄不丌一世东丁丙:  GiftController.丆丕丝丒不丙且丐丗.世上丞不三丐丅丐不(丁丅丈丌丟世丗丗丟:  val_8.Item[0].GiftCategoryType));
        val_59 = this.listButton;
        val_59.Add(item:  val_19);
        if(this.listButton.Count != 0)
        {
                int val_64 = this.丈世与三丒丞丌丂丁;
            if(val_19.PositionInScroll >= val_64)
        {
                val_64 = val_64 + 1;
            this.丈世与三丒丞丌丂丁 = val_64;
        }
        
        }
        
        val_60 = 1;
        label_16:
        if(val_60 < val_8.Count)
        {
            goto label_31;
        }
        
        goto label_108;
        label_14:
        if(this.listButton.Count <= 三不专丕丞丄丁丛东.Count)
        {
            goto label_35;
        }
        
        val_8.AddRange(collection:  System.Linq.Enumerable.Except<丙专丒丄丅一丘上丌>(first:  System.Linq.Enumerable.Cast<丙专丒丄丅一丘上丌>(source:  this.listButton), second:  System.Linq.Enumerable.Cast<丙专丒丄丅一丘上丌>(source:  三不专丕丞丄丁丛东), comparer:  new 丙万丝丙与下丄丑丗()));
        val_59 = 1152921537830324224;
        val_63 = 0;
        goto label_50;
        label_53:
        丙专丒丄丅一丘上丌 val_28 = val_8.Item[0];
        if(0.PositionInScroll >= this.丈世与三丒丞丌丂丁)
        {
            goto label_42;
        }
        
        val_64 = this.丈世与三丒丞丌丂丁 - 1;
        goto label_43;
        label_42:
        if(0.PositionInScroll != this.丈世与三丒丞丌丂丁)
        {
            goto label_45;
        }
        
        val_64 = 0;
        label_43:
        this.丈世与三丒丞丌丂丁 = val_64;
        label_45:
        bool val_31 = this.listButton.Remove(item:  0);
        UnityEngine.Object.Destroy(obj:  0.gameObject);
        val_63 = 1;
        label_50:
        if(val_63 < val_8.Count)
        {
            goto label_53;
        }
        
        goto label_108;
        label_35:
        val_65 = null;
        val_65 = null;
        val_67 = GiftScroll.<>c.<>9__31_0;
        if(val_67 == null)
        {
                System.Func<GiftHUDItem, GiftCategoryType> val_34 = null;
            val_67 = val_34;
            val_34 = new System.Func<GiftHUDItem, GiftCategoryType>(object:  GiftScroll.<>c.__il2cppRuntimeField_static_fields, method:  GiftCategoryType GiftScroll.<>c::一丄丌一专与且丘丒(GiftHUDItem 丐三丞七丝丅不万丛));
            GiftScroll.<>c.<>9__31_0 = val_67;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_35 = System.Linq.Enumerable.Select<GiftHUDItem, GiftCategoryType>(source:  this.listButton, selector:  val_34);
        val_68 = null;
        val_68 = null;
        val_70 = GiftScroll.<>c.<>9__31_1;
        if(val_70 == null)
        {
                System.Func<SlotInfo, GiftCategoryType> val_36 = null;
            val_70 = val_36;
            val_36 = new System.Func<SlotInfo, GiftCategoryType>(object:  GiftScroll.<>c.__il2cppRuntimeField_static_fields, method:  GiftCategoryType GiftScroll.<>c::丑与不东上上丙下不(SlotInfo 丏丟万且丝丒丝丅东));
            GiftScroll.<>c.<>9__31_1 = val_70;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_37 = System.Linq.Enumerable.Select<SlotInfo, GiftCategoryType>(source:  三不专丕丞丄丁丛东, selector:  val_36);
        if((System.Linq.Enumerable.SequenceEqual<GiftCategoryType>(first:  val_35, second:  val_37)) == true)
        {
            goto label_108;
        }
        
        GiftScroll.与三丆丞业丝丙丄丏 val_39 = new GiftScroll.与三丆丞业丝丙丄丏();
        val_59 = System.Linq.Enumerable.Except<GiftCategoryType>(first:  val_35, second:  val_37);
        TSource[] val_42 = System.Linq.Enumerable.ToArray<GiftCategoryType>(source:  System.Linq.Enumerable.Except<GiftCategoryType>(first:  val_37, second:  val_35));
        if(val_39 != null)
        {
                .丘丆丟丂世丅七丑上 = val_42;
        }
        else
        {
                mem[16] = val_42;
        }
        
        .七丞丙丒三丕且丌丟 = 0;
        var val_65 = 0;
        val_65 = val_65 + 1;
        System.Collections.Generic.IEnumerator<T> val_44 = val_59.GetEnumerator();
        goto label_73;
        label_88:
        new GiftScroll.丅丄不专丞丏丝丛与() = new System.Object();
        var val_66 = 0;
        val_66 = val_66 + 1;
        .丄三丅七丆丛与与上 = val_44.Current;
        System.Func<GiftHUDItem, System.Boolean> val_48 = new System.Func<GiftHUDItem, System.Boolean>(object:  new GiftScroll.丅丄不专丞丏丝丛与(), method:  System.Boolean GiftScroll.丅丄不专丞丏丝丛与::且下一丐丛丘丕丘一(GiftHUDItem 丌丗丏丏丛东专丁且));
        val_59 = System.Linq.Enumerable.Single<GiftHUDItem>(source:  this.listButton, predicate:  null);
        val_73 = (GiftScroll.与三丆丞业丝丙丄丏)[1152921537830694688].世丆丅专丂丗丛丕丂;
        if(val_73 == null)
        {
                val_73 = null;
            val_73 = new System.Func<SlotInfo, System.Boolean>(object:  val_39, method:  System.Boolean GiftScroll.与三丆丞业丝丙丄丏::七下上丌丙丄丗丏上(SlotInfo 丏丛与丅丛丌万专丌));
            .世丆丅专丂丗丛丕丂 = val_73;
        }
        
        val_59.丑丕一丙丗丈一丈丆(与丄不丌一世东丁丙:  System.Linq.Enumerable.Single<SlotInfo>(source:  三不专丕丞丄丁丛东, predicate:  null));
        int val_67 = (GiftScroll.与三丆丞业丝丙丄丏)[1152921537830694688].七丞丙丒三丕且丌丟;
        val_67 = val_67 + 1;
        .七丞丙丒三丕且丌丟 = val_67;
        label_73:
        var val_68 = 0;
        val_68 = val_68 + 1;
        if(val_44.MoveNext() == true)
        {
            goto label_88;
        }
        
        val_75 = 0;
        val_76 = 0;
        if(val_44 == null)
        {
            
        }
        else
        {
                var val_69 = 0;
            val_69 = val_69 + 1;
            val_44.Dispose();
        }
        
        label_108:
        val_78 = 0;
        goto label_109;
        label_118:
        val_79 = null;
        val_79 = null;
        val_59 = this.listButton.Item[0].GiftCategoryType;
        val_44.Item[0].丑丕一丙丗丈一丈丆(与丄不丌一世东丁丙:  GiftController.丆丕丝丒不丙且丐丗.世上丞不三丐丅丐不(丁丅丈丌丟世丗丗丟:  val_59));
        val_78 = 1;
        label_109:
        if(val_78 < this.listButton.Count)
        {
            goto label_118;
        }
        
        this.listButton.Sort(comparer:  new 七与丗不丝丞业一万());
        PGCompany.东丑丒丗一丞下丙丙<T> val_61 = PGCompany.东丑丒丗一丞下丙丙<丙专丒丄丅一丘上丌>.万世丅七一专丕丞不();
        if((PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不()) == null)
        {
            
        }
    
    }
    private GiftHUDItem 丗丈丄丞丗丐丏丒与(SlotInfo 与丄不丌一世东丁丙)
    {
        var val_10;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.exampleBut.gameObject, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        if(val_4 != null)
        {
                val_10 = val_4.GetComponent<GiftHUDItem>();
        }
        else
        {
                val_10 = val_4.GetComponent<GiftHUDItem>();
        }
        
        val_4.transform.parent = this.parentButton.transform;
        val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_10.丑丕一丙丗丈一丈丆(与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
        return (GiftHUDItem)val_10;
    }
    public void AnimScrollGift(int 丙丐一丕丗万丁下一)
    {
        goto label_1;
        label_7:
        GiftHUDItem val_1 = X22.Item[0];
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_1.UpgradeCellAnimationParticles, 丏业丟一东丂东丘丛:  false);
        0 = 1;
        label_1:
        if(0 < this.listButton.Count)
        {
            goto label_7;
        }
        
        if(this.listButton.Count <= 丙丐一丕丗万丁下一)
        {
                return;
        }
        
        this.丈世与三丒丞丌丂丁 = 丙丐一丕丗万丁下一;
        this.丂专丗且万七丂三丈(丆专且丕专丗与一丏:  丙丐一丕丗万丁下一, 丐丐七专三且世三七:  true, 万下业业丘业丙丄七:  this.listButton.Count, 东世丑世丛丞不专丕:  this.SpinSound);
    }
    public void SetCanDraggable(bool 下下丏一丙不丘丌丞)
    {
        UnityEngine.Collider[] val_6;
        var val_7;
        if((UnityEngine.Object.op_Implicit(exists:  this.scrollAreaCollider)) != false)
        {
                this.scrollAreaCollider.enabled = 下下丏一丙不丘丌丞;
        }
        
        val_6 = this.业丄不东丅丒丟世丕;
        if((val_6 != null) && (this.业丄不东丅丒丟世丕.Length != 0))
        {
                if(this.丙丙丌丌丈丞不丏丕 == false)
        {
            goto label_7;
        }
        
        }
        
        val_6 = this.parentButton.GetComponentsInChildren<UnityEngine.Collider>();
        this.业丄不东丅丒丟世丕 = val_6;
        label_7:
        val_7 = 0;
        goto label_9;
        label_19:
        if(this.业丄不东丅丒丟世丕[0] != 0)
        {
                this.业丄不东丅丒丟世丕[0].enabled = 下下丏一丙不丘丌丞;
        }
        
        val_6 = this.业丄不东丅丒丟世丕;
        val_7 = 1;
        label_9:
        if(val_7 < this.业丄不东丅丒丟世丕.Length)
        {
            goto label_19;
        }
    
    }
    private void 丂专丗且万七丂三丈(int 丆专且丕专丗与一丏, bool 丐丐七专三且世三七 = False, int 万下业业丘业丙丄七 = 1, UnityEngine.AudioClip 东世丑世丛丞不专丕)
    {
        if(this.listButton.Count <= 丆专且丕专丗与一丏)
        {
                return;
        }
        
        this.丂专丗且万七丂三丈(下丅丙一丂丗丅丝七:  this.listButton.Item[丆专且丕专丗与一丏], 丐丐七专三且世三七:  丐丐七专三且世三七, 万下业业丘业丙丄七:  万下业业丘业丙丄七, 东世丑世丛丞不专丕:  东世丑世丛丞不专丕);
    }
    private void 丂专丗且万七丂三丈(GiftHUDItem 下丅丙一丂丗丅丝七, bool 丐丐七专三且世三七 = False, int 万下业业丘业丙丄七 = 1, UnityEngine.AudioClip 东世丑世丛丞不专丕)
    {
        var val_54;
        var val_55;
        var val_56;
        UIScrollView val_57;
        UnityEngine.Object val_58;
        float val_60;
        float val_61;
        float val_62;
        float val_66;
        GiftInfo val_67;
        float val_68;
        float val_69;
        float val_70;
        val_54 = 万下业业丘业丙丄七;
        val_55 = 丐丐七专三且世三七;
        val_56 = this;
        if(this.scrollView == 0)
        {
                val_57 = this.GetComponent<UIScrollView>();
            this.scrollView = val_57;
        }
        else
        {
                val_57 = this.scrollView;
        }
        
        if(val_57 == 0)
        {
                return;
        }
        
        val_58 = 下丅丙一丂丗丅丝七.transform;
        UIPanel val_5 = this.scrollView.panel;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.5f);
        val_61 = val_7.x;
        val_62 = val_7.z;
        if(val_58 == 0)
        {
                return;
        }
        
        if(this.scrollView == 0)
        {
                return;
        }
        
        if(this.scrollView.panel == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_13 = this.scrollView.panel.cachedTransform;
        UnityEngine.Vector3 val_14 = val_58.position;
        UnityEngine.Vector3 val_15 = val_13.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = val_13.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_61, y = val_7.y, z = val_62});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        val_58 = this.scrollView;
        float val_19 = (this.scrollView.canMoveHorizontally != true) ? val_17.x : 0f;
        float val_21 = (val_58.canMoveVertically != true) ? val_17.y : 0f;
        if(val_55 == false)
        {
            goto label_35;
        }
        
        UnityEngine.Vector3 val_22 = val_13.localPosition;
        val_60 = val_22.z;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_60}, b:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = 0f});
        val_62 = val_23.x;
        val_61 = val_23.y;
        val_66 = val_23.z;
        if(下丅丙一丂丗丅丝七.丕丟丘且丕与丆东丅() == null)
        {
            goto label_42;
        }
        
        val_67 = val_24.gift;
        if(val_67 == null)
        {
            goto label_43;
        }
        
        if(val_24.gift.itemParams == null)
        {
            goto label_42;
        }
        
        int val_25 = val_24.gift.itemParams.业东丅东丌上丗丑不();
        val_67 = 0;
        goto label_43;
        label_35:
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
        val_68 = val_26.x;
        val_69 = val_26.y;
        val_70 = val_26.z;
        UnityEngine.Vector3 val_28 = this.scrollView.transform.localPosition;
        UnityEngine.Vector3 val_29 = val_13.localPosition;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = 0f});
        if(((-1134525872) & 1) != 0)
        {
                val_68 = val_68;
            val_69 = val_69;
            val_70 = val_70;
        }
        
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = val_21, z = 0f}, b:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70});
        val_61 = val_31.x;
        UnityEngine.Vector3 val_32 = val_13.localPosition;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_61, y = val_31.y, z = val_31.z});
        val_60 = val_33.z;
        val_13.localPosition = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_60};
        UnityEngine.Vector2 val_36 = this.scrollView.panel.clipOffset;
        val_62 = val_36.x;
        val_54 = this.scrollView.panel;
        UnityEngine.Vector2 val_38 = val_54.clipOffset;
        val_38.y = val_31.y + val_38.y;
        UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  val_61 + val_62, y:  val_38.y);
        this.scrollView.panel.clipOffset = new UnityEngine.Vector2() {x = val_40.x, y = val_40.y};
        this.scrollView.panel.SetDirty();
        val_56 = this.scrollView.panel;
        val_56.Refresh();
        return;
        label_42:
        val_67 = 0;
        label_43:
        val_55 = val_67.丙东专丂世丈丏丁丂();
        if((val_55 == Progress.七七世万专丕丁上业.丐丐上丟丑丆丐专丗().丝一丙丘专七丕不上()) && (((-1134525784) & 1) != 0))
        {
                UnityEngine.Vector3 val_46 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  this.offsetNoviceGift);
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_62, y = val_61, z = val_66}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
            val_62 = val_48.x;
            val_61 = val_48.y;
            val_66 = val_48.z;
        }
        
        int val_51 = val_54 + (val_54 << 6);
        val_51 = val_51 << 1;
        UnityEngine.Coroutine val_53 = this.StartCoroutine(routine:  this.丕丕上不上丕且东世(万且万且丑丗且丌丆:  this.scrollView.panel.cachedGameObject, 丛上丙丄丄七丈且丅:  new UnityEngine.Vector3() {x = val_62, y = val_61, z = val_66}, 业与三万七丝不万东:  (float)val_51, 东世丑世丛丞不专丕:  东世丑世丛丞不专丕));
    }
    private System.Collections.IEnumerator 丕丕上不上丕且东世(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Vector3 丛上丙丄丄七丈且丅, float 业与三万七丝不万东, UnityEngine.AudioClip 东世丑世丛丞不专丕)
    {
        GiftScroll.丙丛与丒丄七三丘丕 val_1 = new GiftScroll.丙丛与丒丄七三丘丕();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
        }
        else
        {
                mem[32] = this;
            mem[56] = 万且万且丑丗且丌丆;
        }
        
        .丛上丙丄丄七丈且丅 = 丛上丙丄丄七丈且丅;
        mem[1152921537832387728] = 丛上丙丄丄七丈且丅.y;
        mem[1152921537832387732] = 丛上丙丄丄七丈且丅.z;
        if(val_1 != null)
        {
                .业与三万七丝不万东 = 业与三万七丝不万东;
        }
        else
        {
                mem[40] = 业与三万七丝不万东;
        }
        
        .东世丑世丛丞不专丕 = 东世丑世丛丞不专丕;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丗三丝万丂丂丞七丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftScroll.丂一丅且与丁上丟丂();
    }
    private void 七丒丈丂丌丅一丛专()
    {
        this.Sort(三丅万丒与丑且世业:  false);
    }
    private void 丏一丕丄丏丈业丟丕()
    {
        if(this.listButton.Count < 7)
        {
                return;
        }
        
        this.丂专丗且万七丂三丈(丆专且丕专丗与一丏:  0, 丐丐七专三且世三七:  false, 万下业业丘业丙丄七:  1, 东世丑世丛丞不专丕:  0);
    }
    public GiftScroll()
    {
        this.listButton = new System.Collections.Generic.List<GiftHUDItem>();
        this.offsetNoviceGift = 45f;
    }
    private static GiftScroll()
    {
        GiftScroll.丌一丆丛世业专三丑 = true;
        GiftScroll.下上丐万丅丘丏不丂 = false;
    }

}
