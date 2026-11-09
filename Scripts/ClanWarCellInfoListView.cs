using UnityEngine;
public class ClanWarCellInfoListView : MonoBehaviour
{
    // Fields
    internal ClanWarMap clanWarMap;
    private WidgetLayout cellInfoLayout;
    private ClanWarCellInfoView cellInfoExample;
    private MiniPoolMonoBehaviour cellsPool;
    private System.Collections.Generic.Dictionary<DiscreteVector2, ClanWarCellInfoView> 一丁丌且丞丄七丗丈;
    private System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> 丆丘业上下丙丏万与;
    public ScrollViewHelper scrollViewHelper;
    internal System.Nullable<DiscreteVector2> 不丝丏下万万丟业三;
    private UnityEngine.Transform scrollTop;
    public float scrollMomentumEpsilon;
    private bool 丕丘下丈一丘丟世丗;
    
    // Properties
    public ClanWarCellInfoView 不丆业丄万丁专与东 { get; }
    
    // Methods
    public ClanWarCellInfoView get_SelectedInfoView()
    {
        System.Collections.Generic.Dictionary<DiscreteVector2, ClanWarCellInfoView> val_3;
        var val_4;
        val_3 = this;
        if((this.不丝丏下万万丟业三 & 1) != 0)
        {
                if((this.一丁丌且丞丄七丗丈.ContainsKey(key:  new DiscreteVector2() {_x = this.不丝丏下万万丟业三, _y = this.不丝丏下万万丟业三})) != false)
        {
                val_3 = this.一丁丌且丞丄七丗丈;
            ClanWarCellInfoView val_2 = val_3.Item[new DiscreteVector2() {_x = this.不丝丏下万万丟业三, _y = this.不丝丏下万万丟业三}];
            return (ClanWarCellInfoView)val_4;
        }
        
        }
        
        val_4 = 0;
        return (ClanWarCellInfoView)val_4;
    }
    private void Awake()
    {
        七丁丌丒万丄专三三 val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.cellInfoExample, 丏业丟一东丂东丘丛:  false);
        val_4 = System.Delegate.Combine(a:  this.scrollViewHelper.scrollView.onDragStarted, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClanWarCellInfoListView::丆丌丕上与丄丒三丂()));
        if(this.scrollViewHelper.scrollView == null)
        {
            goto label_5;
        }
        
        if(val_4 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_4 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_9:
        this.scrollViewHelper.scrollView.onDragStarted = val_4;
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> 丆丘业上下丙丏万与)
    {
        var val_6;
        System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, System.Int32> val_8;
        var val_9;
        System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, DiscreteVector2> val_11;
        System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, 不上丌世万丁丝丏丆> val_13;
        val_6 = null;
        val_6 = null;
        val_8 = ClanWarCellInfoListView.<>c.<>9__11_0;
        if(val_8 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, System.Int32> val_1 = null;
            val_8 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, System.Int32>(object:  ClanWarCellInfoListView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanWarCellInfoListView.<>c::丈丌七丒专丄上丌丏(System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆> 三丟东丕丄丄下下丑));
            ClanWarCellInfoListView.<>c.<>9__11_0 = val_8;
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = ClanWarCellInfoListView.<>c.<>9__11_1;
        if(val_11 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, DiscreteVector2> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, DiscreteVector2>(object:  ClanWarCellInfoListView.<>c.__il2cppRuntimeField_static_fields, method:  DiscreteVector2 ClanWarCellInfoListView.<>c::不七丛丘与世一与丆(System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆> 丐丏东世不丅丌且万));
            val_9 = null;
            ClanWarCellInfoListView.<>c.<>9__11_1 = val_11;
        }
        
        val_9 = null;
        val_13 = ClanWarCellInfoListView.<>c.<>9__11_2;
        if(val_13 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, 不上丌世万丁丝丏丆> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, 不上丌世万丁丝丏丆>(object:  ClanWarCellInfoListView.<>c.__il2cppRuntimeField_static_fields, method:  不上丌世万丁丝丏丆 ClanWarCellInfoListView.<>c::不丏三丐东业万丕一(System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆> 丐丏东世不丅丌且万));
            ClanWarCellInfoListView.<>c.<>9__11_2 = val_13;
        }
        
        this.丆丘业上下丙丏万与 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, DiscreteVector2, 不上丌世万丁丝丏丆>(source:  System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<DiscreteVector2, 不上丌世万丁丝丏丆>, System.Int32>(source:  丆丘业上下丙丏万与, keySelector:  val_1), keySelector:  val_3, elementSelector:  val_4);
        this.下万丞丄世万三万且();
        this.ChekSelection();
    }
    private void 下万丞丄世万三万且()
    {
        var val_4;
        bool val_7;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.一丁丌且丞丄七丗丈.Values.GetEnumerator();
        label_5:
        if((2137026448 & 1) == 0)
        {
            goto label_3;
        }
        
        this.cellsPool.Return(万且万且丑丗且丌丆:  val_4.丐丏七丌丕丗业且上());
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.cellInfoLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.一丁丌且丞丄七丗丈.Clear();
        Dictionary.Enumerator<TKey, TValue> val_6 = this.丆丘业上下丙丏万与.GetEnumerator();
        label_31:
        if((2137026400 & 1) == 0)
        {
            goto label_13;
        }
        
        ConfiguredValueTaskAwaiter val_8 = val_4.GetAwaiter();
        if((val_8._value._obj.丑业丕且万丂上丒丌(丌丝万上丅丒一丈丘:  val_8._value._obj)) == false)
        {
            goto label_31;
        }
        
        ClanWarCellInfoView val_10 = this.cellsPool.Get<ClanWarCellInfoView>();
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_10.transform);
        this.一丁丌且丞丄七丗丈.Add(key:  new DiscreteVector2() {_x = val_8._value._obj.丐丏七丌丕丗业且上(), _y = val_8._value._obj.丐丏七丌丕丗业且上()}, value:  val_10);
        if((2137026368 & 1) != 0)
        {
                if((2137026368 & 1) != 0)
        {
                string val_20 = val_8._value._obj.丐丏七丌丕丗业且上();
            val_20 = DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = this.不丝丏下万万丟业三.丐丏七丌丕丗业且上(), _y = this.不丝丏下万万丟业三.丐丏七丌丕丗业且上()}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = val_20, _y = val_20});
        }
        
        }
        
        val_4 = 0;
        bool val_21 = val_7;
        val_21 = (val_21 & (-65536)) | val_4;
        val_10.业不丝丄丙丌丌丈丄(丟丏丄一世丛丌上七:  this, 且丝丑一丐丄丁一与:  val_8._value._obj, 丞丈丌且东丆丅丗万:  new System.Nullable<System.Boolean>() {HasValue = val_21});
        this.cellInfoLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_10);
        if((this.不丝丏下万万丟业三 & 1) != 0)
        {
                var val_18 = ((DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = val_10.专丘丏丅且丆万东丈, _y = val_10.专丘丏丅且丆万东丈}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = this.不丝丏下万万丟业三, _y = this.不丝丏下万万丟业三})) != true) ? (val_10) : 0;
        }
        
        val_10.gameObject.SetActive(value:  true);
        goto label_31;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.cellInfoLayout.Reposition();
        this.丞下丆丂丑业丆专丙(丞三七世万不不丞七:  0, 世世丗一丗东与上丏:  false);
    }
    private bool 丑业丕且万丂上丒丌(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        var val_15;
        var val_16;
        val_15 = 丌丝万上丅丒一丈丘;
        PGCompany.丝丂丒专丞与丙丏一 val_1 = val_15.丗丐东丑丕丞丅丞东();
        if(val_1 == 3)
        {
            goto label_2;
        }
        
        if(val_1 == 2)
        {
            goto label_3;
        }
        
        if(val_1 != 1)
        {
            goto label_15;
        }
        
        var val_3 = (val_15.业丝丙下七下七下专() != 0) ? 1 : 0;
        return (bool)val_16;
        label_2:
        val_15 = val_15.丛丆东上上丗丗业丕();
        if(val_15 != PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂())
        {
            goto label_15;
        }
        
        PGCompany.ClanWarController val_6 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_6 != null)
        {
                return val_6.丝丌丄丘丞东丕世且(且下丕七丙丗丄不七:  1);
        }
        
        return val_6.丝丌丄丘丞东丕世且(且下丕七丙丗丄不七:  1);
        label_3:
        PGCompany.一丏不三且丆专东东 val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.一丏不三且丆专东东>(且下丕七丙丗丄不七:  2);
        if(val_8 == null)
        {
                return (bool)val_16;
        }
        
        if(val_8.专东丏与万下丑丂丅() == val_15.丛丆东上上丗丗业丕())
        {
                var val_14 = ((System.Linq.Enumerable.First<不上丌世万丁丝丏丆>(source:  val_15.丂丕丘丌专丗丞丘丘().丂丘业丐丕三上七且())) == val_15) ? 1 : 0;
            return (bool)val_16;
        }
        
        label_15:
        val_16 = 0;
        return (bool)val_16;
    }
    internal void 丘一丒丞上万上且丈(不上丌世万丁丝丏丆 世丕丅丄丕专丑丑丆)
    {
        System.Collections.Generic.Dictionary<DiscreteVector2, ClanWarCellInfoView> val_5;
        var val_6;
        ClanWarCellInfoView val_7;
        val_5 = this.一丁丌且丞丄七丗丈;
        DiscreteVector2 val_1 = 世丕丅丄丕专丑丑丆.丞丑丟下丘三下专不();
        if((val_5.ContainsKey(key:  new DiscreteVector2() {_x = val_1._x, _y = val_1._y})) != false)
        {
                val_5 = this.一丁丌且丞丄七丗丈;
            DiscreteVector2 val_3 = 世丕丅丄丕专丑丑丆.丞丑丟下丘三下专不();
            val_6 = 1;
            val_7 = val_5.Item[new DiscreteVector2() {_x = val_3._x, _y = val_3._y}];
        }
        else
        {
                val_7 = 0;
            val_6 = 0;
        }
        
        this.丞下丆丂丑业丆专丙(丞三七世万不不丞七:  val_7, 世世丗一丗东与上丏:  false);
    }
    internal void 丞下丆丂丑业丆专丙(ClanWarCellInfoView 丞三七世万不不丞七, bool 世世丗一丗东与上丏)
    {
        ClanWarCellInfoView val_13 = 丞三七世万不不丞七;
        if(this.SelectedInfoView == val_13)
        {
                return;
        }
        
        if(this.SelectedInfoView != 0)
        {
                ClanWarCellInfoView val_5 = this.SelectedInfoView;
            val_5.<丞丛丏丛丛不丟业一>k__BackingField = false;
            this.SelectedInfoView.丝一丅丆三东丂丞七();
        }
        
        if(val_13 == 0)
        {
                mem[1152921536809212872] = 0;
            this.不丝丏下万万丟业三 = 0;
            return;
        }
        
        this.不丝丏下万万丟业三 = 0;
        mem[1152921536809212872] = 0;
        if(this.SelectedInfoView != 0)
        {
                ClanWarCellInfoView val_10 = this.SelectedInfoView;
            val_10.<丞丛丏丛丛不丟业一>k__BackingField = true;
            this.SelectedInfoView.丝一丅丆三东丂丞七();
        }
        
        if(世世丗一丗东与上丏 == false)
        {
                return;
        }
        
        val_13 = val_13.transform;
        this.scrollViewHelper.ScrollTo(不七丘丘丒万七丄丒:  val_13, 丌与丟丁万丝丞丄丏:  true);
    }
    private void Update()
    {
        if(this.scrollViewHelper.scrollView.isDragging == true)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_2 = this.scrollViewHelper.scrollView.currentMomentum;
        if(val_2.x <= this.scrollMomentumEpsilon)
        {
            goto label_5;
        }
        
        label_2:
        this.一丆丟丐丏万丛与丏();
        return;
        label_5:
        if(this.丕丘下丈一丘丟世丗 == false)
        {
                return;
        }
        
        this.丗丈丆丅业一丂丂丛();
        this.丕丘下丈一丘丟世丗 = false;
    }
    private void 丆丌丕上与丄丒三丂()
    {
        this.丕丘下丈一丘丟世丗 = true;
    }
    private void 丗丈丆丅业一丂丂丛()
    {
        if(this.SelectedInfoView == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.scrollViewHelper.scrollView.currentMomentum = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.scrollViewHelper.ScrollTo(不七丘丘丒万七丄丒:  this.SelectedInfoView.transform, 丌与丟丁万丝丞丄丏:  true);
    }
    private void 一丆丟丐丏万丛与丏()
    {
        var val_4;
        ClanWarMap val_14;
        UnityEngine.Object val_15;
        UnityEngine.Object val_16;
        val_14 = this;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.一丁丌且丞丄七丗丈.GetEnumerator();
        val_15 = 0;
        goto label_8;
        label_9:
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        UnityEngine.Vector3 val_7 = val_5._value._obj.transform.position;
        UnityEngine.Vector3 val_8 = this.scrollTop.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) < 0)
        {
                val_15;
        }
        
        label_8:
        if((2138179040 & 1) != 0)
        {
            goto label_9;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_16 = 1152921504848912384;
        if(val_5._value._obj == 0)
        {
                return;
        }
        
        val_16 = this.SelectedInfoView;
        if(val_5._value._obj == val_16)
        {
                return;
        }
        
        this.丞下丆丂丑业丆专丙(丞三七世万不不丞七:  val_5._value._obj, 世世丗一丗东与上丏:  false);
        val_14 = this.clanWarMap;
        val_4 = 0;
        bool val_13 = val_14.七丞万丅一丄丛丛丝(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
    }
    public void ChekSelection()
    {
        if((this.不丝丏下万万丟业三 & 1) != 0)
        {
                return;
        }
        
        this.一丆丟丐丏万丛与丏();
    }
    public void ResetScroll()
    {
        this.scrollViewHelper.scrollView.ResetPosition();
        mem[1152921536810062024] = 0;
        this.不丝丏下万万丟业三 = 0;
    }
    internal void 丅丘丝丗丂丑丈丂丐()
    {
        this.ResetScroll();
        this.下万丞丄世万三万且();
        this.ChekSelection();
    }
    internal bool 与丁且丝丆丝与万上(不上丌世万丁丝丏丆 世丕丅丄丕专丑丑丆)
    {
        DiscreteVector2 val_1 = 世丕丅丄丕专丑丑丆.丞丑丟下丘三下专不();
        if(this.一丁丌且丞丄七丗丈 != null)
        {
                return this.一丁丌且丞丄七丗丈.ContainsKey(key:  new DiscreteVector2() {_x = val_1._x, _y = val_1._y});
        }
        
        return this.一丁丌且丞丄七丗丈.ContainsKey(key:  new DiscreteVector2() {_x = val_1._x, _y = val_1._y});
    }
    public ClanWarCellInfoListView()
    {
        this.一丁丌且丞丄七丗丈 = new System.Collections.Generic.Dictionary<DiscreteVector2, ClanWarCellInfoView>();
        this.丆丘业上下丙丏万与 = new System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆>();
        this.scrollMomentumEpsilon = 0.007f;
    }

}
