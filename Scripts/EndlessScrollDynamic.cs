using UnityEngine;
public class EndlessScrollDynamic : MonoBehaviour
{
    // Fields
    private System.Action<EndlessScrollCellDynamic> 丆丄丟东专与且丂业;
    private System.Action<int> 丒丂与不上丙专丁丞;
    private System.Action 丑丙丝丌丟丑丈不丄;
    private System.Action 丁东丂丞丏不丝丗丕;
    private System.Action 丅丄丗专丟丌丄一丐;
    public MiniPoolMonoBehaviour miniPool;
    public UnityEngine.Transform cellHolder;
    public UnityEngine.Transform poolHolder;
    public EndlessScrollBar endlessScrollBar;
    public EndlessScrollCellDynamic cellExample;
    public UIPanel panel;
    public UIScrollView scroll;
    public UnityEngine.Transform topBoundGO;
    public UnityEngine.Transform bottomBoundGO;
    public float boundOffset;
    public int spacing;
    public System.Collections.Generic.List<EndlessScrollCellDynamic> cellsList;
    public System.Collections.Generic.Dictionary<UnityEngine.Transform, EndlessScrollCellDynamic> cellsDictinary;
    private int 丏丌丞丅丅丟与丄丐;
    public int cellsCount;
    private int 业丞丕与丄东丞丞丆;
    private int 一丐不丕丈专丕丂七;
    private UnityEngine.Vector3 不东且丟丗丛丗下东;
    private int 丞一一丄丆丄业丘专;
    public int scrollToTest;
    
    // Properties
    public int 丅丐丗与东丁丝三丛 { get; }
    public int 业丂丝丈丐丟丅不丘 { get; }
    public int 丘丌丄与丛丏丑丛丟 { get; }
    
    // Methods
    public void add_onUpdateCell(System.Action<EndlessScrollCellDynamic> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丆丄丟东专与且丂业, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丆丄丟东专与且丂业 != 1152921524356636536);
    
    }
    public void remove_onUpdateCell(System.Action<EndlessScrollCellDynamic> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丆丄丟东专与且丂业, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丆丄丟东专与且丂业 != 1152921524356773112);
    
    }
    public void add_onSelectCell(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒丂与不上丙专丁丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丂与不上丙专丁丞 != 1152921524356909696);
    
    }
    public void remove_onSelectCell(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒丂与不上丙专丁丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丂与不上丙专丁丞 != 1152921524357046272);
    
    }
    public void add_onPanelMoving(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丑丙丝丌丟丑丈不丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丑丙丝丌丟丑丈不丄 != 1152921524357182856);
    
    }
    public void remove_onPanelMoving(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丑丙丝丌丟丑丈不丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丑丙丝丌丟丑丈不丄 != 1152921524357319432);
    
    }
    public void add_OnWrapForward(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丁东丂丞丏不丝丗丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁东丂丞丏不丝丗丕 != 1152921524357456016);
    
    }
    public void remove_OnWrapForward(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丁东丂丞丏不丝丗丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁东丂丞丏不丝丗丕 != 1152921524357592592);
    
    }
    public void add_OnWrapBack(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丄丗专丟丌丄一丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丄丗专丟丌丄一丐 != 1152921524357729176);
    
    }
    public void remove_OnWrapBack(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丄丗专丟丌丄一丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丄丗专丟丌丄一丐 != 1152921524357865752);
    
    }
    public int get_ItemsCount()
    {
        return (int)this.丏丌丞丅丅丟与丄丐;
    }
    public int get_CurrentMinIndex()
    {
        return (int)this.业丞丕与丄东丞丞丆;
    }
    public int get_CurrentMaxIndex()
    {
        return (int)this.一丐不丕丈专丕丂七;
    }
    public void Init(int 上专丅业三丏丈丈丗, int 丏丑丝万下与丁丞业 = 0)
    {
        this.丏丌丞丅丅丟与丄丐 = 上专丅业三丏丈丈丗;
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  丏丑丝万下与丁丞业);
        this.SetSelected(丞世不丒下上上丝丑:  丏丑丝万下与丁丞业);
        if(this.endlessScrollBar == 0)
        {
                return;
        }
        
        this.endlessScrollBar.Init(丞不丆丘东丁丝丏下:  this);
    }
    public void SetBounds()
    {
        UIPanel val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_20;
        float val_21;
        val_14 = this;
        this.topBoundGO.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
        UnityEngine.Transform val_1 = this.topBoundGO.transform;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.bottomBoundGO.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = this.bottomBoundGO.localPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.bottomBoundGO.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Transform val_6 = this.transform;
        if(val_6 != null)
        {
                val_15 = val_5.z;
            val_16 = val_5.y;
            val_17 = val_5.x;
            val_6.position = new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17};
        }
        else
        {
                val_15 = val_5.z;
            val_16 = val_5.y;
            val_17 = val_5.x;
            0.position = new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17};
        }
        
        UnityEngine.Vector3 val_7 = val_6.localPosition;
        val_20 = val_7.x;
        val_21 = val_7.y;
        if(this.scroll.movement == 0)
        {
            goto label_18;
        }
        
        if(this.scroll.movement == 1)
        {
                val_14 = this.panel;
            val_20 = val_20 + (this.panel.width * 0.5f);
            UnityEngine.Vector2 val_10 = val_14.clipSoftness;
            val_21 = val_21 - val_10.y;
        }
        
        if(val_6 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        val_6.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_7.z};
        return;
        label_18:
        val_21 = val_21 + (this.panel.height * (-0.5f));
        UnityEngine.Vector2 val_13 = this.panel.clipSoftness;
        val_20 = val_20 + val_13.x;
        if(val_6 != null)
        {
            goto label_25;
        }
        
        goto label_26;
    }
    internal void 业丌丘一丐丕专丆丞(int 丏丑丝万下与丁丞业 = 0, bool 万丁丕专七丌丐丄丕 = True)
    {
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  丏丑丝万下与丁丞业);
        if(万丁丕专七丌丐丄丕 == false)
        {
                return;
        }
        
        this.SetSelected(丞世不丒下上上丝丑:  丏丑丝万下与丁丞业);
    }
    private void 丟丞世万丕丏丐下丂(int 丑东丁一丏丑专丟专)
    {
        int val_13 = 丑东丁一丏丑专丟专;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cellExample.gameObject, 丏业丟一东丂东丘丛:  false);
        this.Clear();
        this.SetBounds();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        float val_14 = val_2.x;
        float val_13 = val_2.y;
        this.业丞丕与丄东丞丞丆 = val_13;
        if(this.cellsCount <= 0)
        {
            goto label_6;
        }
        
        var val_15 = 0;
        label_19:
        EndlessScrollCellDynamic val_3 = this.丄丐丒一丟丕下专不();
        UnityEngine.Transform val_4 = val_3.transform;
        val_4.SetAsLastSibling();
        val_3.丅七丙丑丂丕丟丗不 = this;
        this.cellsList.Add(item:  val_3);
        this.cellsDictinary.Add(key:  val_4, value:  val_3);
        val_3.gameObject.SetActive(value:  true);
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  val_3, 业丌丆业丘丟丆丁丛:  val_13 + val_15);
        if(this.scroll.movement == 0)
        {
            goto label_14;
        }
        
        if(this.scroll.movement != 1)
        {
            goto label_17;
        }
        
        val_13 = val_13 - val_3.HalfHeight;
        val_4.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_13, z = val_2.z};
        float val_8 = val_3.HalfHeight;
        val_8 = val_8 + (float)this.spacing;
        val_13 = val_13 - val_8;
        goto label_17;
        label_14:
        val_14 = val_14 + val_3.HalfWidth;
        val_4.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_13, z = val_2.z};
        float val_10 = val_3.HalfWidth;
        val_10 = val_10 + (float)this.spacing;
        val_14 = val_14 + val_10;
        label_17:
        val_15 = val_15 + 1;
        if(val_15 < this.cellsCount)
        {
            goto label_19;
        }
        
        val_13 = this.业丞丕与丄东丞丞丆;
        label_6:
        this.一丐不丕丈专丕丂七 = this.cellsList.Count + val_13;
    }
    private EndlessScrollCellDynamic 丄丐丒一丟丕下专不()
    {
        UnityEngine.Transform val_10;
        UnityEngine.Transform val_12;
        val_10 = this;
        if(this.miniPool != 0)
        {
                EndlessScrollCellDynamic val_2 = this.miniPool.Get<EndlessScrollCellDynamic>();
        }
        else
        {
                EndlessScrollCellDynamic val_5 = UnityEngine.Object.Instantiate<EndlessScrollCellDynamic>(original:  this.cellExample, parent:  this.cellExample.transform.parent);
        }
        
        val_12 = this.cellHolder;
        if(val_12 == 0)
        {
                return val_5;
        }
        
        if(val_5 == 0)
        {
                return val_5;
        }
        
        val_12 = val_5.transform;
        val_12.SetParent(p:  this.cellHolder);
        val_10 = val_5.transform;
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_10);
        return val_5;
    }
    public void Clear()
    {
        var val_3;
        var val_12;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_20:
        if(((-1722447120) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(this.miniPool == 0)
        {
            goto label_5;
        }
        
        bool val_6 = val_4.SetIndex(丞世不丒下上上丝丑:  0);
        if(this.poolHolder != 0)
        {
                val_4.transform.SetParent(p:  this.poolHolder);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_4.transform);
        }
        
        this.miniPool.Return(万且万且丑丗且丌丆:  val_4);
        goto label_20;
        label_5:
        UnityEngine.Object.Destroy(obj:  val_4.gameObject);
        goto label_20;
        label_2:
        val_12 = public System.Void List.Enumerator<EndlessScrollCellDynamic>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.cellsList.Clear();
        this.cellsDictinary.Clear();
        this.panel.Refresh();
        this.scroll.ResetPosition();
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        丞东丑专丛丆丄丝世.万丗丞丂丒世丁丟丟(丄丑三东丘丆丂丟丙:  this.scroll, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 七丙不一下丞与丞一:  0f);
    }
    private void LateUpdate()
    {
        float val_14;
        float val_15;
        UnityEngine.Vector3 val_2 = this.panel.transform.position;
        val_14 = this.不东且丟丗丛丗下东;
        val_15 = V9.16B;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
        {
            goto label_23;
        }
        
        if(this.scroll.movement == 0)
        {
            goto label_7;
        }
        
        if(this.scroll.movement != 1)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_5 = this.panel.transform.position;
        if(val_5.y > val_5.x)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_7 = this.panel.transform.position;
        if(val_7.y < 0)
        {
            goto label_14;
        }
        
        goto label_22;
        label_7:
        UnityEngine.Vector3 val_9 = this.panel.transform.position;
        val_15 = this.不东且丟丗丛丗下东;
        if(val_9.x >= 0)
        {
            goto label_18;
        }
        
        label_11:
        this.七与丕丞世专丆万丙();
        goto label_22;
        label_18:
        UnityEngine.Vector3 val_11 = this.panel.transform.position;
        val_15 = this.不东且丟丗丛丗下东;
        if(val_11.x <= val_15)
        {
            goto label_22;
        }
        
        label_14:
        this.丗丁丞丒丗丁七且丐();
        label_22:
        if(this.丑丙丝丌丟丑丈不丄 != null)
        {
                this.丑丙丝丌丟丑丈不丄.Invoke();
        }
        
        label_23:
        UnityEngine.Vector3 val_13 = this.panel.transform.position;
        this.不东且丟丗丛丗下东 = val_13;
        mem[1152921524359479444] = val_13.y;
        mem[1152921524359479448] = val_13.z;
    }
    internal void 七与丕丞世专丆万丙()
    {
        var val_5;
        var val_26;
        if(this.scroll.movement == 1)
        {
            goto label_2;
        }
        
        if(this.scroll.movement == 0)
        {
            goto label_27;
        }
        
        goto label_51;
        label_2:
        List.Enumerator<T> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_26 = 1152921524349664160;
        label_17:
        if(((-1721946624) & 1) == 0)
        {
            goto label_31;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_6)) == false)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_8 = val_6.position;
        EndlessScrollCellDynamic val_9 = this.cellsDictinary.Item[val_6];
        UnityEngine.Vector3 val_11 = this.topBoundGO.position;
        float val_12 = (this.GetWorldSize(世丌丌丙丞丟下东丞:  val_9.widget)) * 0.5f;
        val_12 = val_8.y - val_12;
        if(val_12 <= val_11.y)
        {
            goto label_17;
        }
        
        this.丂且世丒丄丝一与丙(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_6]);
        goto label_17;
        label_27:
        List.Enumerator<T> val_16 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_26 = 1152921524349664160;
        label_40:
        if(((-1721946624) & 1) == 0)
        {
            goto label_31;
        }
        
        string val_17 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_17)) == false)
        {
            goto label_40;
        }
        
        UnityEngine.Vector3 val_19 = val_17.position;
        EndlessScrollCellDynamic val_20 = this.cellsDictinary.Item[val_17];
        UnityEngine.Vector3 val_22 = this.bottomBoundGO.position;
        float val_23 = (this.GetWorldSize(世丌丌丙丞丟下东丞:  val_20.widget)) * 0.5f;
        val_23 = val_19.x + val_23;
        if(val_23 >= 0)
        {
            goto label_40;
        }
        
        this.丂且世丒丄丝一与丙(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_17]);
        goto label_40;
        label_31:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        label_51:
        if(this.丁东丂丞丏不丝丗丕 == null)
        {
                return;
        }
        
        this.丁东丂丞丏不丝丗丕.Invoke();
    }
    internal void 丗丁丞丒丗丁七且丐()
    {
        var val_5;
        var val_26;
        if(this.scroll.movement == 1)
        {
            goto label_2;
        }
        
        if(this.scroll.movement == 0)
        {
            goto label_27;
        }
        
        goto label_51;
        label_2:
        List.Enumerator<T> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  true, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_26 = 1152921524349664160;
        label_17:
        if(((-1721646208) & 1) == 0)
        {
            goto label_31;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_6)) == false)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_8 = val_6.position;
        EndlessScrollCellDynamic val_9 = this.cellsDictinary.Item[val_6];
        UnityEngine.Vector3 val_11 = this.bottomBoundGO.position;
        float val_12 = (this.GetWorldSize(世丌丌丙丞丟下东丞:  val_9.widget)) * 0.5f;
        val_12 = val_8.y + val_12;
        if(val_12 >= 0)
        {
            goto label_17;
        }
        
        this.丏七丝丒七不丝丆丏(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_6]);
        goto label_17;
        label_27:
        List.Enumerator<T> val_16 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  true, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_26 = 1152921524349664160;
        label_40:
        if(((-1721646208) & 1) == 0)
        {
            goto label_31;
        }
        
        string val_17 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_17)) == false)
        {
            goto label_40;
        }
        
        UnityEngine.Vector3 val_19 = val_17.position;
        EndlessScrollCellDynamic val_20 = this.cellsDictinary.Item[val_17];
        UnityEngine.Vector3 val_22 = this.topBoundGO.position;
        float val_23 = (this.GetWorldSize(世丌丌丙丞丟下东丞:  val_20.widget)) * 0.5f;
        val_23 = val_19.x - val_23;
        if(val_23 <= val_22.x)
        {
            goto label_40;
        }
        
        this.丏七丝丒七不丝丆丏(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_17]);
        goto label_40;
        label_31:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_51:
        if(this.丅丄丗专丟丌丄一丐 == null)
        {
                return;
        }
        
        this.丅丄丗专丟丌丄一丐.Invoke();
    }
    private void 丂且世丒丄丝一与丙(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        UIScrollView val_17;
        float val_19;
        float val_20;
        System.Collections.Generic.List<EndlessScrollCellDynamic> val_17 = this.cellsList;
        int val_18 = 丌丝万上丅丒一丈丘.东七丛丝丑专世丏三;
        val_17 = this.scroll;
        val_17 = val_17.Count + val_18;
        val_18 = val_17 + 1;
        if(val_18 > this.丏丌丞丅丅丟与丄丐)
        {
                this.scroll.restrictWithinPanel = true;
            return;
        }
        
        this.scroll.restrictWithinPanel = false;
        UnityEngine.Transform val_3 = 丞东丑专丛丆丄丝世.丆东丑丑世万东上且(丈东丘丏与丌东东下:  this.transform, 丛丅丘一丏丙且丌上:  true);
        if(val_3 == 0)
        {
                return;
        }
        
        val_17 = this.cellsDictinary;
        if((val_17.ContainsKey(key:  val_3)) == false)
        {
                return;
        }
        
        EndlessScrollCellDynamic val_6 = this.cellsDictinary.Item[val_3];
        this.一丐不丕丈专丕丂七 = val_17;
        this.业丞丕与丄东丞丞丆 = val_17 - this.cellsList.Count;
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 业丌丆业丘丟丆丁丛:  val_17);
        UnityEngine.Vector3 val_10 = val_6.transform.localPosition;
        val_19 = val_10.x;
        val_20 = val_10.y;
        if(this.scroll.movement == 0)
        {
            goto label_18;
        }
        
        if(this.scroll.movement != 1)
        {
            goto label_21;
        }
        
        float val_12 = 丌丝万上丅丒一丈丘.HalfHeight;
        val_12 = val_6.HalfHeight + val_12;
        val_12 = val_12 + (float)this.spacing;
        val_20 = val_20 - val_12;
        goto label_21;
        label_18:
        float val_14 = 丌丝万上丅丒一丈丘.HalfWidth;
        val_14 = val_6.HalfWidth + val_14;
        val_14 = val_14 + (float)this.spacing;
        val_19 = val_19 + val_14;
        label_21:
        UnityEngine.Transform val_15 = 丌丝万上丅丒一丈丘.transform;
        if(val_15 != null)
        {
                val_15.localPosition = new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_10.z};
        }
        else
        {
                0.localPosition = new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_10.z};
        }
        
        val_15.SetAsLastSibling();
        UnityEngine.GameObject val_16 = 丌丝万上丅丒一丈丘.gameObject;
        if(val_16 != null)
        {
                val_16.SetActive(value:  false);
        }
        else
        {
                0.SetActive(value:  false);
        }
        
        val_16.SetActive(value:  true);
    }
    private void 丏七丝丒七不丝丆丏(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        UIScrollView val_17;
        float val_19;
        float val_20;
        System.Collections.Generic.List<EndlessScrollCellDynamic> val_17 = this.cellsList;
        val_17 = this.scroll;
        val_17 = 丌丝万上丅丒一丈丘.东七丛丝丑专世丏三 - val_17.Count;
        if(val_17 == null)
        {
            goto label_3;
        }
        
        if((val_17 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        label_21:
        this.scroll.restrictWithinPanel = false;
        UnityEngine.Transform val_3 = 丞东丑专丛丆丄丝世.丆业丞丈丝丏丝丐丞(丈东丘丏与丌东东下:  this.transform, 丛丅丘一丏丙且丌上:  true);
        if(val_3 == 0)
        {
                return;
        }
        
        val_17 = this.cellsDictinary;
        if((val_17.ContainsKey(key:  val_3)) == false)
        {
                return;
        }
        
        EndlessScrollCellDynamic val_6 = this.cellsDictinary.Item[val_3];
        this.业丞丕与丄东丞丞丆 = val_17;
        this.一丐不丕丈专丕丂七 = this.cellsList.Count + val_17;
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 业丌丆业丘丟丆丁丛:  val_17);
        UnityEngine.Vector3 val_10 = val_6.transform.localPosition;
        val_19 = val_10.x;
        val_20 = val_10.y;
        if(this.scroll.movement == 0)
        {
            goto label_17;
        }
        
        if(this.scroll.movement != 1)
        {
            goto label_20;
        }
        
        float val_12 = 丌丝万上丅丒一丈丘.HalfHeight;
        val_12 = val_6.HalfHeight + val_12;
        val_12 = val_12 + (float)this.spacing;
        val_20 = val_20 + val_12;
        goto label_20;
        label_3:
        if((val_17 & 2147483648) == 0)
        {
            goto label_21;
        }
        
        label_4:
        this.scroll.restrictWithinPanel = true;
        return;
        label_17:
        float val_14 = 丌丝万上丅丒一丈丘.HalfWidth;
        val_14 = val_6.HalfWidth + val_14;
        val_14 = val_14 + (float)this.spacing;
        val_19 = val_19 - val_14;
        label_20:
        UnityEngine.Transform val_15 = 丌丝万上丅丒一丈丘.transform;
        if(val_15 != null)
        {
                val_15.localPosition = new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_10.z};
        }
        else
        {
                0.localPosition = new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_10.z};
        }
        
        val_15.SetAsFirstSibling();
        UnityEngine.GameObject val_16 = 丌丝万上丅丒一丈丘.gameObject;
        if(val_16 != null)
        {
                val_16.SetActive(value:  false);
        }
        else
        {
                0.SetActive(value:  false);
        }
        
        val_16.SetActive(value:  true);
    }
    public void UpdateCells()
    {
        var val_3 = this;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_4:
        if(((-1720973272) & 1) == 0)
        {
            goto label_2;
        }
        
        this.丆丄丟东专与且丂业.Invoke(obj:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东专丑七与丟丁上丗(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘, int 业丌丆业丘丟丆丁丛)
    {
        if((丌丝万上丅丒一丈丘.SetIndex(丞世不丒下上上丝丑:  业丌丆业丘丟丆丁丛)) == false)
        {
                return;
        }
        
        if(this.丆丄丟东专与且丂业 == null)
        {
                return;
        }
        
        this.丆丄丟东专与且丂业.Invoke(obj:  丌丝万上丅丒一丈丘);
    }
    public int GetSelected()
    {
        return (int)this.丞一一丄丆丄业丘专;
    }
    public void SetSelected(int 丞世不丒下上上丝丑)
    {
        this.丞一一丄丆丄业丘专 = (this.丏丌丞丅丅丟与丄丐 > 丞世不丒下上上丝丑) ? 丞世不丒下上上丝丑 : (!0);
        bool val_6 = UnityEngine.Object.op_Inequality(x:  this.cellsList.Find(match:  new System.Predicate<EndlessScrollCellDynamic>(object:  this, method:  System.Boolean EndlessScrollDynamic::丄下丝业丅与万丏丗(EndlessScrollCellDynamic 三丟东丕丄丄下下丑))), y:  0);
        bool val_7 = UnityEngine.Object.op_Inequality(x:  this.cellsList.Find(match:  new System.Predicate<EndlessScrollCellDynamic>(object:  this, method:  System.Boolean EndlessScrollDynamic::业丈不丕丗东世丆专(EndlessScrollCellDynamic 三丟东丕丄丄下下丑))), y:  0);
        if(this.丒丂与不上丙专丁丞 == null)
        {
                return;
        }
        
        this.丒丂与不上丙专丁丞.Invoke(obj:  this.丞一一丄丆丄业丘专);
    }
    public void ScrollToTest()
    {
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  this.scrollToTest);
    }
    public void ToCell(int 丞世不丒下上上丝丑)
    {
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  丞世不丒下上上丝丑);
    }
    public void ToStart()
    {
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  0);
    }
    public void ToEnd()
    {
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  System.Math.Max(val1:  0, val2:  this.丏丌丞丅丅丟与丄丐 - 2));
    }
    public float GetWorldSize(UIWidget 世丌丌丙丞丟下东丞)
    {
        var val_5;
        if(this.scroll.movement != 0)
        {
                if(this.scroll.movement != 1)
        {
                return 0f;
        }
        
            val_5 = 1152921504838316032;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V12.16B, y = V11.16B, z = V13.16B});
        }
        
        val_5 = 1152921504838316032;
        return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V12.16B, y = V11.16B, z = V13.16B});
    }
    public float GetWorldHalfSize(UIWidget 世丌丌丙丞丟下东丞)
    {
        float val_1 = this.GetWorldSize(世丌丌丙丞丟下东丞:  世丌丌丙丞丟下东丞);
        val_1 = val_1 * 0.5f;
        return (float)val_1;
    }
    public EndlessScrollCellDynamic GetCellByIndex(int 丞世不丒下上上丝丑)
    {
        var val_3;
        var val_4;
        val_3 = 丞世不丒下上上丝丑;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_4:
        if(((-1719722184) & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        if((-1719722184) != val_3)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (EndlessScrollCellDynamic);
    }
    public EndlessScrollDynamic()
    {
        this.spacing = 10;
        this.cellsList = new System.Collections.Generic.List<EndlessScrollCellDynamic>();
        this.cellsDictinary = new System.Collections.Generic.Dictionary<UnityEngine.Transform, EndlessScrollCellDynamic>();
        this.cellsCount = 4;
        this.丞一一丄丆丄业丘专 = 0;
        this.scrollToTest = 50;
    }
    private bool 丄下丝业丅与万丏丗(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.东七丛丝丑专世丏三 == this.丞一一丄丆丄业丘专) ? 1 : 0;
    }
    private bool 业丈不丕丗东世丆专(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.东七丛丝丑专世丏三 == this.丞一一丄丆丄业丘专) ? 1 : 0;
    }

}
