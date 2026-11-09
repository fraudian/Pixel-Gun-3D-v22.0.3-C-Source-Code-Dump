using UnityEngine;
internal class SlidesScrollController : MonoBehaviour
{
    // Fields
    private UIPanel _scrollViewPanel;
    private UIScrollView _scrollView;
    private UICenterOnChild _centerOnChild;
    private SlideDot _slideDotExample;
    private WidgetLayout _slideLayout;
    private bool _needReturnFirstSlide;
    private bool _blockSlideDots;
    private UnityEngine.GameObject _nextButtonGo;
    private UnityEngine.GameObject _okButtonGo;
    private System.Collections.Generic.List<UnityEngine.GameObject> _buttonsForEachSlide;
    internal int 丂丂七丗丘丏丏东丁;
    private SpringPanel.上丄丂丛专下丟万下 上丄丂丛专下丟万下;
    private System.Collections.Generic.List<SlideDot> 丛丏丞与丄丒丝丝丞;
    private System.Collections.Generic.List<UnityEngine.GameObject> 业丑丛丏与丐丐丘不;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丙一丐丁丒丁丞丐丐;
    private bool 上丛丏丙丙丁一丙业;
    public float maxDistance;
    public bool useAlpha;
    
    // Methods
    internal void 丝丘下业丟丌七丈丌(SpringPanel.上丄丂丛专下丟万下 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丄丂丛专下丟万下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丄丂丛专下丟万下 != 1152921539846218072);
    
    }
    internal void 上丂不丐丗东一上上(SpringPanel.上丄丂丛专下丟万下 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丄丂丛专下丟万下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丄丂丛专下丟万下 != 1152921539846354648);
    
    }
    private void Start()
    {
        且丐丁世专丝丕丆丁 val_8;
        七丁丌丒万丄专三三 val_9;
        七丁丌丒万丄专三三 val_10;
        val_8 = System.Delegate.Combine(a:  this._centerOnChild.onCenter, b:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SlidesScrollController::世丆下丈与丈丆七丑(UnityEngine.GameObject 下且专丒下丙丈丈丒)));
        if(this._centerOnChild == null)
        {
            goto label_2;
        }
        
        if(val_8 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_8 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_6:
        this._centerOnChild.onCenter = val_8;
        val_9 = System.Delegate.Combine(a:  this._scrollView.onDragStarted, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SlidesScrollController::七丑丂且丌下上七丞()));
        if(this._scrollView == null)
        {
            goto label_8;
        }
        
        if(val_9 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_9 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_12:
        this._scrollView.onDragStarted = val_9;
        val_10 = System.Delegate.Combine(a:  this._scrollView.onStoppedMoving, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SlidesScrollController::丅不丒丆三丙且三丘()));
        if(this._scrollView == null)
        {
            goto label_14;
        }
        
        if(val_10 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_10 == null)
        {
            goto label_18;
        }
        
        label_15:
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_18:
        this._scrollView.onStoppedMoving = val_10;
        this.丘上丐世丆丑且丞丒();
    }
    private void OnEnable()
    {
        this.一丕专三丛丘丞丐丅();
    }
    private void 一丕专三丛丘丞丐丅()
    {
        int val_2;
        if(this._needReturnFirstSlide != false)
        {
                if(this._scrollViewPanel != 0)
        {
            goto label_4;
        }
        
        }
        
        val_2 = this.丂丂七丗丘丏丏东丁;
        if(val_2 != 0)
        {
            goto label_5;
        }
        
        return;
        label_4:
        val_2 = this.丂丂七丗丘丏丏东丁;
        label_5:
        this.CenterOnByIndex(丞世不丒下上上丝丑:  val_2, 丌丝丌丁下丐丞丆一:  true);
        this.世丆下丈与丈丆七丑();
    }
    internal void 丘上丐世丆丑且丞丒()
    {
        var val_4;
        var val_41;
        var val_43;
        var val_45;
        var val_46;
        var val_49;
        System.Func<UnityEngine.Transform, System.Int32, 七丕丒丈世丌且万一<System.Int32, System.Boolean>> val_51;
        var val_52;
        System.Func<七丕丒丈世丌且万一<System.Int32, System.Boolean>, System.Boolean> val_54;
        var val_58;
        int val_60;
        var val_61;
        this._slideDotExample.gameObject.SetActive(value:  false);
        this._slideLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        List.Enumerator<T> val_2 = this.丛丏丞与丄丒丝丝丞.GetEnumerator();
        label_9:
        if((880520576 & 1) == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Object.Destroy(obj:  val_4.丐丏七丌丕丗业且上().gameObject);
        goto label_9;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛丏丞与丄丒丝丝丞.Clear();
        this.业丑丛丏与丐丐丘不.Clear();
        System.Collections.IEnumerator val_8 = this._scrollView.transform.GetEnumerator();
        val_41 = 1152921504686346240;
        goto label_37;
        label_44:
        var val_45 = 0;
        val_45 = val_45 + 1;
        object val_10 = val_8.Current;
        val_43 = 1;
        UIWidget val_12 = 0.GetComponent<UIWidget>();
        if(val_12 != 0)
        {
                val_41 = 1152921504686346240;
            if(val_12.gameObject.activeSelf != false)
        {
                this.业丑丛丏与丐丐丘不.Add(item:  0.gameObject);
            val_41 = 1152921504686346240;
            this._slideLayout.AddElement(世丌丌丙丞丟下东丞:  val_12);
        }
        
        }
        
        label_37:
        var val_46 = 0;
        val_46 = val_46 + 1;
        if(val_8.MoveNext() == true)
        {
            goto label_44;
        }
        
        val_45 = 0;
        val_46 = 0;
        if(val_8 != null)
        {
                var val_47 = 0;
            val_47 = val_47 + 1;
            val_8.Dispose();
        }
        
        if(( != 1) && (226 == 226))
        {
                val_45 = 0;
        }
        else
        {
                if( != false)
        {
                val_46 = 0;
        }
        
        }
        
        this.丙一丐丁丒丁丞丐丐.Clear();
        if(this._buttonsForEachSlide.Count != this._scrollView.transform.childCount)
        {
            goto label_146;
        }
        
        val_49 = null;
        val_49 = null;
        val_51 = SlidesScrollController.<>c.<>9__21_1;
        if(val_51 == null)
        {
                System.Func<UnityEngine.Transform, System.Int32, 七丕丒丈世丌且万一<System.Int32, System.Boolean>> val_25 = null;
            val_51 = val_25;
            val_25 = new System.Func<UnityEngine.Transform, System.Int32, 七丕丒丈世丌且万一<System.Int32, System.Boolean>>(object:  SlidesScrollController.<>c.__il2cppRuntimeField_static_fields, method:  七丕丒丈世丌且万一<System.Int32, System.Boolean> SlidesScrollController.<>c::丐丈一与万丝七丞丄(UnityEngine.Transform 三丟东丕丄丄下下丑, int 丞世不丒下上上丝丑));
            SlidesScrollController.<>c.<>9__21_1 = val_51;
        }
        
        val_52 = null;
        val_52 = null;
        val_54 = SlidesScrollController.<>c.<>9__21_2;
        if(val_54 == null)
        {
                System.Func<七丕丒丈世丌且万一<System.Int32, System.Boolean>, System.Boolean> val_27 = null;
            val_54 = val_27;
            val_27 = new System.Func<七丕丒丈世丌且万一<System.Int32, System.Boolean>, System.Boolean>(object:  SlidesScrollController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SlidesScrollController.<>c::丘丆丘七丕一上专丐(七丕丒丈世丌且万一<int, bool> 三丟东丕丄丄下下丑));
            SlidesScrollController.<>c.<>9__21_2 = val_54;
        }
        
        var val_48 = 0;
        val_48 = val_48 + 1;
        System.Collections.Generic.IEnumerator<T> val_30 = System.Linq.Enumerable.Where<七丕丒丈世丌且万一<System.Int32, System.Boolean>>(source:  System.Linq.Enumerable.Select<UnityEngine.Transform, 七丕丒丈世丌且万一<System.Int32, System.Boolean>>(source:  丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this._scrollView.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  false), selector:  val_25), predicate:  val_27).GetEnumerator();
        val_43 = 1152921504691191808;
        label_104:
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_30.MoveNext() == false)
        {
            goto label_95;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        this.丙一丐丁丒丁丞丐丐.Add(item:  this._buttonsForEachSlide.Item[val_30.Current.业东丅东丌上丗丑不()]);
        goto label_104;
        label_95:
        val_58 = 1152921504621703168;
        if(val_30 == null)
        {
            
        }
        else
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_30.Dispose();
        }
        
        if(1 == 1)
        {
            goto label_117;
        }
        
        if(( == false) || (429 == 429))
        {
            goto label_146;
        }
        
        label_145:
        label_146:
        val_60 = 0;
        goto label_120;
        label_133:
        SlideDot val_40 = UnityEngine.Object.Instantiate<SlideDot>(original:  this._slideDotExample, parent:  this._slideDotExample.transform.parent);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_40.transform);
        val_40.gameObject.SetActive(value:  true);
        val_40.丆丅丕丆七世丐丌丒 = this;
        val_40.丞世不丒下上上丝丑 = val_60;
        val_40.丘丅专丅专丘不丙丛 = this._blockSlideDots;
        val_40.世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  false);
        this.丛丏丞与丄丒丝丝丞.Add(item:  val_40);
        val_60 = 1;
        label_120:
        if(val_60 < this.业丑丛丏与丐丐丘不.Count)
        {
            goto label_133;
        }
        
        this._slideLayout.Reposition();
        this._scrollView.ResetPosition();
        this._centerOnChild.Recenter();
        val_61 = null;
        val_61 = null;
        if((SlidesScrollController.<>c.<>9__21_0) == null)
        {
            goto label_139;
        }
        
        label_144:
        this.丛丏丞与丄丒丝丝丞.ForEach(action:  SlidesScrollController.<>c.<>9__21_0);
        this.CenterOnByIndex(丞世不丒下上上丝丑:  this.丂丂七丗丘丏丏东丁, 丌丝丌丁下丐丞丆一:  true);
        return;
        label_139:
        SlidesScrollController.<>c.<>9__21_0 = new System.Action<SlideDot>(object:  SlidesScrollController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SlidesScrollController.<>c::下三丅且下丐丁丗万(SlideDot 三丟东丕丄丄下下丑));
        if(this.丛丏丞与丄丒丝丝丞 != null)
        {
            goto label_144;
        }
        
        goto label_144;
        label_117:
        if( == true)
        {
            goto label_145;
        }
        
        goto label_146;
    }
    public void NextSlide()
    {
        if(this.上丛丏丙丙丁一丙业 != true)
        {
                int val_2 = this.丆丑丕且下丒丟丏七() + 1;
            if(val_2 < this.业丑丛丏与丐丐丘不.Count)
        {
                this.CenterOnByIndex(丞世不丒下上上丝丑:  val_2, 丌丝丌丁下丐丞丆一:  false);
        }
        else
        {
                this.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.上丛丏丙丙丁一丙业 = false;
    }
    private void 七丑丂且丌下上七丞()
    {
        this.上丛丏丙丙丁一丙业 = true;
    }
    private void 丅不丒丆三丙且三丘()
    {
        this.上丛丏丙丙丁一丙业 = false;
    }
    public void CenterOnByIndex(int 丞世不丒下上上丝丑, bool 丌丝丌丁下丐丞丆一 = False)
    {
        if(this.业丑丛丏与丐丐丘不.Count <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        if(丌丝丌丁下丐丞丆一 != false)
        {
                this._centerOnChild.CenterOnInstant(丞下万上三丘上与专:  this.业丑丛丏与丐丐丘不.Item[丞世不丒下上上丝丑].transform);
            return;
        }
        
        this._centerOnChild.onFinished = this.上丄丂丛专下丟万下;
        this._centerOnChild.CenterOn(丞下万上三丘上与专:  this.业丑丛丏与丐丐丘不.Item[丞世不丒下上上丝丑].transform);
    }
    private int 丆丑丕且下丒丟丏七()
    {
        var val_5;
        UnityEngine.Object val_6;
        val_5 = 0;
        goto label_1;
        label_8:
        val_6 = this.业丑丛丏与丐丐丘不.Item[0];
        if(val_6 == this._centerOnChild.centeredObject)
        {
                return 0;
        }
        
        val_5 = 1;
        label_1:
        val_6 = this.业丑丛丏与丐丐丘不;
        if(val_5 < val_6.Count)
        {
            goto label_8;
        }
        
        return 0;
    }
    private void 世丆下丈与丈丆七丑(UnityEngine.GameObject 下且专丒下丙丈丈丒)
    {
        this.世丆下丈与丈丆七丑();
    }
    private void 世丆下丈与丈丆七丑()
    {
        var val_5;
        int val_1 = this.丆丑丕且下丒丟丏七();
        val_5 = 0;
        goto label_1;
        label_5:
        this.丛丏丞与丄丒丝丝丞.Item[0].世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  (val_1 == val_5) ? 1 : 0);
        val_5 = 1;
        label_1:
        if(val_5 < this.丛丏丞与丄丒丝丝丞.Count)
        {
            goto label_5;
        }
        
        this.丌万丛丒上与丑不上(丕丂丟丒业丑专丙业:  val_1);
    }
    private void 丌万丛丒上与丑不上(int 丕丂丟丒业丑专丙业)
    {
        int val_11;
        System.Collections.Generic.List<UnityEngine.GameObject> val_12;
        var val_13;
        UnityEngine.GameObject val_14;
        val_11 = 丕丂丟丒业丑专丙业;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextButtonGo, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._okButtonGo, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.丙一丐丁丒丁丞丐丐, 丏业丟一东丂东丘丛:  false);
        if(this.丙一丐丁丒丁丞丐丐.Count != this.业丑丛丏与丐丐丘不.Count)
        {
            goto label_7;
        }
        
        val_12 = this.丙一丐丁丒丁丞丐丐;
        if(val_12.Count < 1)
        {
            goto label_7;
        }
        
        val_11 = this.丙一丐丁丒丁丞丐丐.Item[val_11];
        val_13 = 1;
        val_14 = val_11;
        goto label_11;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextButtonGo, 丏业丟一东丂东丘丛:  ((this.丛丏丞与丄丒丝丝丞.Count - 1) != val_11) ? 1 : 0);
        val_12 = this.丛丏丞与丄丒丝丝丞;
        val_14 = this._okButtonGo;
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  ((val_12.Count - 1) == val_11) ? 1 : 0);
    }
    private void 世业丑丆丘与丝丝丆()
    {
        var val_3;
        List.Enumerator<T> val_1 = this._slideLayout.widgets.GetEnumerator();
        label_12:
        if((882005840 & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_6 = val_3.丐丏七丌丕丗业且上().transform.position;
        UnityEngine.Vector3 val_8 = this.transform.position;
        float val_10 = UnityEngine.Mathf.Min(a:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}), b:  this.maxDistance);
        val_10 = val_10 / this.maxDistance;
        val_10 = 1f - val_10;
        goto label_12;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Update()
    {
        if(this.useAlpha == false)
        {
                return;
        }
        
        this.世业丑丆丘与丝丝丆();
    }
    public SlidesScrollController()
    {
        this.丛丏丞与丄丒丝丝丞 = new System.Collections.Generic.List<SlideDot>();
        this.业丑丛丏与丐丐丘不 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丙一丐丁丒丁丞丐丐 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.maxDistance = 2f;
        this.useAlpha = true;
    }

}
