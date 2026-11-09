using UnityEngine;
internal sealed class PixelPassTaskListView : PGBehaviour
{
    // Fields
    private EndlessScrollDynamic _pageScroll;
    internal ScrollViewHelper scrollHelper;
    private System.Collections.Generic.List<UIRect> _rectsToUpdate;
    private StoreCharacterHelper character;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPremium;
    private UnityEngine.GameObject headerHolder;
    private UILabel headerLabel;
    private UIBasicSprite headertexture;
    private PGCompany.TimerUI headerTimer;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    private System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈> 丌业丂丝丙丝世万丟;
    private PGCompany.丅与丝丆丞东丈丗丒 丙丛下业丗专丝与丞;
    private 丕丐丟丒丆丒丟丅丈 丙丐丁不与丕且丄丆;
    private int 万丌专丒东丞丅与丕;
    private EndlessScrollCellDynamic 丄专上专上下丝专业;
    private UnityEngine.GameObject 丗七东丈丈丅与业丄;
    private UnityEngine.GameObject headerTargetRight;
    private UnityEngine.GameObject headerTargetLeft;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    private PGCompany.丅与丝丆丞东丈丗丒 丗丄丁与专专一丝万 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private PGCompany.丅与丝丆丞东丈丗丒 丞丐专丐且一丝丑三()
    {
        PGCompany.丅与丝丆丞东丈丗丒 val_5 = this.丙丛下业丗专丝与丞;
        if(val_5 != null)
        {
                return val_5;
        }
        
        if(((PGCompany.世专三丑丘丗丂丅丞.丑七不且上丗丁一世().丝丒专丙世与三丌丞(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 25, 丏丟丑丙七东专丌丏 = false, 丒丂丌丑丟东东丒专 = false})) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        this.丙丛下业丗专丝与丞 = val_5;
        return val_5;
    }
    private void Awake()
    {
        this._pageScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PixelPassTaskListView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this._pageScroll.add_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskListView::丒下丁业不丟丂丝一()));
        this._pageScroll.add_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PixelPassTaskListView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
        PixelPassBuyPremium.丙七不丗东丞丘专不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskListView::丝丑丏下三丂丌丛下()));
    }
    private void OnDestroy()
    {
        this._pageScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PixelPassTaskListView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this._pageScroll.remove_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskListView::丒下丁业不丟丂丝一()));
        this._pageScroll.remove_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PixelPassTaskListView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
        PixelPassBuyPremium.丞丕丂丏丌丈专业丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassTaskListView::丝丑丏下三丂丌丛下()));
    }
    private void OnEnable()
    {
        if(this.丞丐专丐且一丝丑三() == null)
        {
                return;
        }
        
        goto typeof(PGCompany.丅与丝丆丞东丈丗丒).__il2cppRuntimeField_198;
    }
    private void OnDisable()
    {
        PGCompany.丅与丝丆丞东丈丗丒 val_1 = this.丞丐专丐且一丝丑三();
        this.scrollHelper.StopScroll();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 三专三丐丁世丑丁丅)
    {
        丕丐丟丒丆丒丟丅丈 val_8;
        .三专三丐丁世丑丁丅 = 三专三丐丁世丑丁丅;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this._pageScroll.scroll.currentMomentum = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈> val_3 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.专丕不丆丆丆丒丘东(丈丂七世丟丞丂丗丒:  丈丂七世丟丞丂丗丒);
        this.丌业丂丝丙丝世万丟 = val_3;
        if(((PixelPassTaskListView.丈业丗丞丁七下一不)[1152921538584569296].三专三丐丁世丑丁丅 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        val_8 = System.Linq.Enumerable.FirstOrDefault<丕丐丟丒丆丒丟丅丈>(source:  val_3, predicate:  new System.Func<丕丐丟丒丆丒丟丅丈, System.Boolean>(object:  new PixelPassTaskListView.丈业丗丞丁七下一不(), method:  System.Boolean PixelPassTaskListView.丈业丗丞丁七下一不::丆一且世上丗上一丗(丕丐丟丒丆丒丟丅丈 三丟东丕丄丄下下丑)));
        if(val_8 == null)
        {
            goto label_9;
        }
        
        val_8 = this.丌业丂丝丙丝世万丟.IndexOf(item:  val_8);
        goto label_9;
        label_6:
        val_8 = 0;
        label_9:
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this._rectsToUpdate);
        this._pageScroll.Init(上专丅业三丏丈丈丗:  this.丌业丂丝丙丝世万丟.Count, 丏丑丝万下与丁丞业:  0);
        UIPanel.RefreshAllPanels();
        this.丝丑丏下三丂丌丛下();
        this.丝一丅丆三东丂丞七();
    }
    private void 丝丑丏下三丂丌丛下()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        if(this.character == null)
        {
                return;
        }
        
        this.character.丌丄丘丅万丑丆丈丅(丈丄不七三万丄丁不:  this.丑与万三丐丒丏一专.丆丑丛丟与丝业丕丑());
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.丙丐丁不与丕且丄丆 = 0;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
    }
    private void 丒下丁业不丟丂丝一()
    {
    
    }
    private void 丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        if(丌丝万上丅丒一丈丘 != null)
        {
                UnityEngine.Object val_1 = (null == null) ? (丌丝万上丅丒一丈丘) : 0;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        if(this.丌业丂丝丙丝世万丟.Count > val_1.Index)
        {
                mem2[0] = this.丌业丂丝丙丝世万丟.Item[val_1.Index];
        }
        else
        {
                mem2[0] = 0;
        }
        
        val_1.丝一丅丆三东丂丞七();
    }
    private void 丅上丛丁丆丛丝丏丐()
    {
    
    }
    private void 下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)
    {
    
    }
    private float 丘丞丄丒丞东三业一()
    {
        EndlessScrollCellDynamic val_18;
        var val_19;
        System.Func<丕丐丟丒丆丒丟丅丈, System.Boolean> val_21;
        if(this.丙丐丁不与丕且丄丆 == null)
        {
            goto label_1;
        }
        
        label_20:
        if((this.万丌专丒东丞丅与丕 & 2147483648) != 0)
        {
            goto label_2;
        }
        
        val_18 = System.Linq.Enumerable.FirstOrDefault<EndlessScrollCellDynamic>(source:  this._pageScroll.cellsList, predicate:  new System.Func<EndlessScrollCellDynamic, System.Boolean>(object:  this, method:  System.Boolean PixelPassTaskListView::丁万丗丂丄东丈且丅(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)));
        goto label_4;
        label_1:
        val_19 = null;
        val_19 = null;
        val_21 = PixelPassTaskListView.<>c.<>9__34_0;
        if(val_21 == null)
        {
                System.Func<丕丐丟丒丆丒丟丅丈, System.Boolean> val_3 = null;
            val_21 = val_3;
            val_3 = new System.Func<丕丐丟丒丆丒丟丅丈, System.Boolean>(object:  PixelPassTaskListView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTaskListView.<>c::丕丗丝丟业丄丂丙丄(丕丐丟丒丆丒丟丅丈 三丟东丕丄丄下下丑));
            PixelPassTaskListView.<>c.<>9__34_0 = val_21;
        }
        
        丕丐丟丒丆丒丟丅丈 val_4 = System.Linq.Enumerable.FirstOrDefault<丕丐丟丒丆丒丟丅丈>(source:  this.丌业丂丝丙丝世万丟, predicate:  val_3);
        this.丙丐丁不与丕且丄丆 = val_4;
        this.万丌专丒东丞丅与丕 = this.丌业丂丝丙丝世万丟.IndexOf(item:  val_4);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.headertexture, 与万丆丛丒万丝丙丑:  this.丙丐丁不与丕且丄丆.三丗一丄不丆不丏三());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerLabel, 丕丗丘丑丛与丑业丒:  this.丙丐丁不与丕且丄丆.丘丄业丞丏与与丅丐());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.headerTimer, 丏业丟一东丂东丘丛:  (this.丙丐丁不与丕且丄丆.丝且丁丌丂七丟且丙() > 0) ? 1 : 0);
        if((this.丙丐丁不与丕且丄丆.丝且丁丌丂七丟且丙() < 1) || (this.headerTimer == null))
        {
            goto label_20;
        }
        
        this.headerTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.丙丐丁不与丕且丄丆.丝且丁丌丂七丟且丙(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        goto label_20;
        label_2:
        val_18 = 0;
        label_4:
        this.丄专上专上下丝专业 = val_18;
        if(val_18 != 0)
        {
                UnityEngine.Vector3 val_14 = this.丄专上专上下丝专业.transform.position;
            UnityEngine.Vector3 val_16 = this.headerTargetLeft.transform.position;
            return UnityEngine.Mathf.Max(a:  val_14.x, b:  val_16.x);
        }
        
        UnityEngine.Transform val_17 = this.headerTargetLeft.transform;
        if(val_17 != null)
        {
                return val_17.position;
        }
        
        return val_17.position;
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3 val_2 = this.headerHolder.transform.position;
        this.headerHolder.transform.position = new UnityEngine.Vector3() {x = this.丘丞丄丒丞东三业一(), y = val_2.y, z = val_2.z};
    }
    internal void 万丗丞丂丒世丁丟丟(PixelPassTaskCellView 丟丄丛专丏丆与丑一)
    {
        float val_17;
        float val_18;
        ScrollViewHelper val_19;
        var val_20;
        float val_13 = this.scrollHelper.Panel.width;
        UnityEngine.Vector3 val_4 = 丟丄丛专丏丆与丑一.transform.localPosition;
        val_17 = val_4.x;
        val_18 = val_4.z;
        val_13 = val_13 * 0.5f;
        if(丟丄丛专丏丆与丑一.Index > 1)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_7 = 丟丄丛专丏丆与丑一.transform.localPosition;
        if(val_7.x >= 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_9 = 丟丄丛专丏丆与丑一.transform.localPosition;
        val_17 = val_9.y;
        val_19 = this.scrollHelper;
        val_18 = val_9.x + (-573f);
        val_20 = 1;
        goto label_12;
        label_8:
        if((this._pageScroll.CurrentMaxIndex + 1) >= this._pageScroll.ItemsCount)
        {
                return;
        }
        
        val_19 = this.scrollHelper;
        val_20 = 1;
        label_12:
        val_19.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_17, y = val_4.y, z = val_18}, 七丙不一下丞与丞一:  val_13, 丌与丟丁万丝丞丄丏:  true);
    }
    public PixelPassTaskListView()
    {
        this.丌业丂丝丙丝世万丟 = new System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈>();
        this.万丌专丒东丞丅与丕 = 0;
    }
    private bool 丁万丗丂丄东丈且丅(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.Index == this.万丌专丒东丞丅与丕) ? 1 : 0;
    }

}
