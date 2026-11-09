using UnityEngine;
public class EndlessScroll : MonoBehaviour
{
    // Fields
    private System.Action<EndlessScrollCell> 丆丄丟东专与且丂业;
    private System.Action<int> 丒丂与不上丙专丁丞;
    public MiniPoolMonoBehaviour miniPool;
    public EndlessScrollBar endlessScrollBar;
    public EndlessScrollCell cellExample;
    public UIPanel panel;
    public UIScrollView scroll;
    public UnityEngine.Transform topBoundGO;
    public UnityEngine.Transform bottomBoundGO;
    public int cellSize;
    public int cellCountInRow;
    public float scrollOnLastRowValue;
    public float boundsOffsetFactor;
    public int additionalRows;
    private int 丑丑丒丙丙丗丘丒万;
    private int 丏丌丞丅丅丟与丄丐;
    private int 业丞丕与丄东丞丞丆;
    private int 一丐不丕丈专丕丂七;
    public System.Collections.Generic.List<EndlessScrollCell> cellsList;
    public System.Collections.Generic.Dictionary<UnityEngine.Transform, EndlessScrollCell> cellsDictinary;
    private int 丞一一丄丆丄业丘专;
    public EndlessScroll.丞丆丐丒且丘三丂丁 canSelectDelegate;
    
    // Properties
    public int 丛丘丄丑丟七与丟七 { get; }
    public int 丅丐丗与东丁丝三丛 { get; }
    public int 业丂丝丈丐丟丅不丘 { get; }
    public int 丘丌丄与丛丏丑丛丟 { get; }
    
    // Methods
    public void add_onUpdateCell(System.Action<EndlessScrollCell> 丙业与丙丗丝不丈东)
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
        while(this.丆丄丟东专与且丂业 != 1152921524347054712);
    
    }
    public void remove_onUpdateCell(System.Action<EndlessScrollCell> 丙业与丙丗丝不丈东)
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
        while(this.丆丄丟东专与且丂业 != 1152921524347191288);
    
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
        while(this.丒丂与不上丙专丁丞 != 1152921524347327872);
    
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
        while(this.丒丂与不上丙专丁丞 != 1152921524347464448);
    
    }
    public int get_visibleRows()
    {
        if(this.scroll.movement != 0)
        {
                if(this.scroll.movement != 1)
        {
                return 0;
        }
        
            float val_1 = this.panel.height;
        }
        
        float val_3 = (float)this.cellSize;
        val_3 = this.panel.width / val_3;
        return UnityEngine.Mathf.CeilToInt(f:  val_3);
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
    private int 且世丄丏丕丟下丌丈(int 丞世不丒下上上丝丑)
    {
        float val_1 = (float)丞世不丒下上上丝丑;
        val_1 = val_1 / (float)this.cellCountInRow;
        return UnityEngine.Mathf.CeilToInt(f:  val_1);
    }
    private int 丝丛七丂专不丝丙丒(int 丞世不丒下上上丝丑)
    {
        float val_1 = (float)丞世不丒下上上丝丑;
        val_1 = val_1 / (float)this.cellCountInRow;
        return UnityEngine.Mathf.FloorToInt(f:  val_1);
    }
    public void Init(int 上专丅业三丏丈丈丗, int 丏丑丝万下与丁丞业 = 0, bool 世万丐专世丕业丟东 = True)
    {
        this.丏丌丞丅丅丟与丄丐 = 上专丅业三丏丈丈丗;
        this.cellExample.gameObject.SetActive(value:  false);
        UIPanel val_2 = this.scroll.GetComponent<UIPanel>();
        UIPanel.上丟丟且丁且丅丏丆 val_3 = 1152921505098911744;
        val_3 = new UIPanel.上丟丟且丁且丅丏丆(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void EndlessScroll::业丟业丆丒业丆丒三(UIPanel 丛丘下丗业丂一且业));
        val_2.onClipMove = val_3;
        this.scroll.disableDragIfFits = false;
        this.业丌丘一丐丕专丆丞(丏丑丝万下与丁丞业:  丏丑丝万下与丁丞业, 万丁丕专七丌丐丄丕:  世万丐专世丕业丟东);
        if(this.endlessScrollBar == 0)
        {
                return;
        }
        
        this.endlessScrollBar.Init(丅七丙丑丂丕丟丗不:  this);
    }
    public void SetBounds(float 世东丞丆专与丌世丞)
    {
        float val_12;
        float val_13;
        float val_14;
        this.topBoundGO.position = new UnityEngine.Vector3() {x = V9.16B, y = V10.16B, z = V11.16B};
        UnityEngine.Transform val_1 = this.topBoundGO.transform;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        float val_12 = (float)this.cellSize;
        val_12 = val_12 * 世东丞丆专与丌世丞;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.bottomBoundGO.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = this.bottomBoundGO.localPosition;
        float val_13 = (float)this.cellSize;
        val_13 = val_13 * 世东丞丆专与丌世丞;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.bottomBoundGO.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Transform val_6 = this.cellExample.transform;
        if(val_6 != null)
        {
                val_12 = val_5.z;
            val_13 = val_5.y;
            val_14 = val_5.x;
            val_6.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
        }
        else
        {
                val_12 = val_5.z;
            val_13 = val_5.y;
            val_14 = val_5.x;
            0.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
        }
        
        UnityEngine.Vector3 val_7 = val_6.localPosition;
        UnityEngine.Vector2 val_8 = this.panel.clipSoftness;
        UnityEngine.Vector2 val_9 = this.panel.clipSoftness;
        float val_14 = (float)this.cellSize;
        val_14 = val_14 * 0.5f;
        val_14 = val_14 + val_8.x;
        val_9.y = ((float)this.cellSize * (-0.5f)) - val_9.y;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_6.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    private EndlessScrollCell 丄丐丒一丟丕下专不()
    {
        MiniPoolMonoBehaviour val_6;
        if(this.miniPool != 0)
        {
                val_6 = this.miniPool;
            EndlessScrollCell val_2 = val_6.Get<EndlessScrollCell>();
            return (EndlessScrollCell)UnityEngine.Object.Instantiate<EndlessScrollCell>(original:  val_6 = this.cellExample, parent:  val_6.transform.parent);
        }
        
        return (EndlessScrollCell)UnityEngine.Object.Instantiate<EndlessScrollCell>(original:  val_6, parent:  val_6.transform.parent);
    }
    public void Clear()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_12:
        if(((-1732818304) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(this.miniPool == 0)
        {
            goto label_5;
        }
        
        bool val_6 = val_4.SetIndex(丞世不丒下上上丝丑:  0);
        this.miniPool.Return(万且万且丑丗且丌丆:  val_4);
        goto label_12;
        label_5:
        UnityEngine.Object.Destroy(obj:  val_4.gameObject);
        goto label_12;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.cellsList.Clear();
        this.cellsDictinary.Clear();
        this.panel.Refresh();
        this.scroll.ResetPosition();
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        丞东丑专丛丆丄丝世.万丗丞丂丒世丁丟丟(丄丑三东丘丆丂丟丙:  this.scroll, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 七丙不一下丞与丞一:  0f);
    }
    private void 业丌丘一丐丕专丆丞(int 丏丑丝万下与丁丞业 = 0, bool 万丁丕专七丌丐丄丕 = True)
    {
        int val_14 = this.且世丄丏丕丟下丌丈(丞世不丒下上上丝丑:  this.丏丌丞丅丅丟与丄丐);
        int val_2 = 丏丑丝万下与丁丞业 + 1;
        int val_3 = this.且世丄丏丕丟下丌丈(丞世不丒下上上丝丑:  val_2);
        int val_5 = val_14 - this.visibleRows;
        int val_13 = this.additionalRows;
        val_13 = val_13 + this.visibleRows;
        this.丑丑丒丙丙丗丘丒万 = val_13;
        if(val_14 < this.丑丑丒丙丙丗丘丒万)
        {
                this.丑丑丒丙丙丗丘丒万 = val_14;
        }
        
        val_2 = ((val_3 <= (val_5 + 1)) ? (val_3) : (val_5 + 1)) - 1;
        val_14 = ((val_3 >= val_14) ? 1 : 0) & ((val_14 >= this.visibleRows) ? 1 : 0);
        val_2 = this.cellCountInRow * (UnityEngine.Mathf.Max(a:  0, b:  val_2));
        this.丟丞世万丕丏丐下丂(丑东丁一丏丑专丟专:  val_2, 丌丗丆一丈丐丁一万:  this.丑丑丒丙丙丗丘丒万);
        if(万丁丕专七丌丐丄丕 != false)
        {
                this.SetSelected(丞世不丒下上上丝丑:  丏丑丝万下与丁丞业);
        }
        
        if(val_14 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.万丗丞丂丒世丁丟丟(丄丑三东丘丆丂丟丙:  this.scroll, 下业丕七东丌丝下且:  this.scrollOnLastRowValue, 七丙不一下丞与丞一:  0f);
    }
    private void 丟丞世万丕丏丐下丂(int 丑东丁一丏丑专丟专, int 丌丗丆一丈丐丁一万)
    {
        int val_23;
        float val_25;
        float val_26;
        float val_27;
        UIScrollView val_28;
        int val_29;
        float val_30;
        var val_33;
        var val_34;
        val_23 = 丑东丁一丏丑专丟专;
        丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this.scroll);
        this.scroll.restrictWithinPanel = true;
        this.scroll.disableDragIfFits = true;
        this.Clear();
        this.SetBounds(世东丞丆专与丌世丞:  0.51f);
        this.业丞丕与丄东丞丞丆 = val_23;
        if(丌丗丆一丈丐丁一万 <= 0)
        {
            goto label_5;
        }
        
        var val_22 = 0;
        label_26:
        if(this.cellCountInRow < 1)
        {
            goto label_6;
        }
        
        var val_21 = 0;
        label_25:
        EndlessScrollCell val_1 = this.丄丐丒一丟丕下专不();
        UnityEngine.Transform val_2 = val_1.transform;
        UnityEngine.Vector3 val_4 = this.cellExample.transform.position;
        val_25 = val_4.z;
        if(val_2 != null)
        {
                val_26 = val_4.x;
            val_27 = val_4.y;
            val_2.position = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_25};
        }
        else
        {
                val_26 = val_4.x;
            val_27 = val_4.y;
            0.position = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_25};
        }
        
        val_2.SetAsLastSibling();
        val_1.丅七丙丑丂丕丟丗不 = this;
        this.cellsList.Add(item:  val_1);
        this.cellsDictinary.Add(key:  val_2, value:  val_1);
        val_1.gameObject.SetActive(value:  true);
        val_28 = this.scroll;
        if(this.scroll.movement == 0)
        {
            goto label_17;
        }
        
        if(this.scroll.movement != 1)
        {
            goto label_18;
        }
        
        if(val_2 == null)
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_7 = val_2.localPosition;
        val_28 = this.cellSize;
        val_25 = val_7.x;
        UnityEngine.Vector3 val_8 = val_2.localPosition;
        val_29 = this.cellSize;
        val_30 = val_8.y;
        goto label_20;
        label_17:
        if(val_2 == null)
        {
            goto label_21;
        }
        
        UnityEngine.Vector3 val_9 = val_2.localPosition;
        val_28 = this.cellSize;
        val_25 = val_9.x;
        UnityEngine.Vector3 val_10 = val_2.localPosition;
        val_29 = this.cellSize;
        val_30 = val_10.y;
        goto label_22;
        label_19:
        UnityEngine.Vector3 val_11 = val_2.localPosition;
        val_28 = this.cellSize;
        val_25 = val_11.x;
        UnityEngine.Vector3 val_12 = 0.localPosition;
        val_29 = this.cellSize;
        val_30 = val_12.y;
        label_20:
        UnityEngine.Vector3 val_13 = val_2.localPosition;
        val_33 = val_28 * val_21;
        val_34 = val_29 * val_22;
        goto label_23;
        label_21:
        UnityEngine.Vector3 val_14 = val_2.localPosition;
        val_28 = this.cellSize;
        val_25 = val_14.x;
        UnityEngine.Vector3 val_15 = 0.localPosition;
        val_29 = this.cellSize;
        val_30 = val_15.y;
        label_22:
        UnityEngine.Vector3 val_16 = val_2.localPosition;
        val_33 = val_28 * val_22;
        val_34 = val_29 * val_21;
        label_23:
        float val_19 = (float)val_33;
        float val_20 = (float)val_34;
        val_19 = val_25 + val_19;
        val_20 = val_30 - val_20;
        val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_18:
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  val_1, 业丌丆业丘丟丆丁丛:  val_23 + val_21);
        val_21 = val_21 + 1;
        if(val_21 < this.cellCountInRow)
        {
            goto label_25;
        }
        
        val_23 = val_23 + val_21;
        label_6:
        val_22 = val_22 + 1;
        if(val_22 != 丌丗丆一丈丐丁一万)
        {
            goto label_26;
        }
        
        val_23 = this.业丞丕与丄东丞丞丆;
        label_5:
        this.一丐不丕丈专丕丂七 = this.cellsList.Count + val_23;
        this.丗丁丞丒丗丁七且丐();
        this.SetBounds(世东丞丆专与丌世丞:  this.boundsOffsetFactor);
    }
    internal void 三丅不丘丏丛丑专丅()
    {
        var val_3 = this;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_4:
        if(((-1732315352) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().与丘不丏丟世丙丅上(丟丒且一专丟丙下一:  this.cellSize);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 业丟业丆丒业丆丒三(UIPanel 丛丘下丗业丂一且业)
    {
        if(this.scroll.movement == 0)
        {
            goto label_1;
        }
        
        if(this.scroll.movement != 1)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.scroll.currentMomentum;
        if(val_1.y > 0f)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_2 = this.scroll.currentMomentum;
        if(val_2.y >= 0)
        {
                return;
        }
        
        label_10:
        this.丗丁丞丒丗丁七且丐();
        return;
        label_1:
        UnityEngine.Vector3 val_3 = this.scroll.currentMomentum;
        if(val_3.x >= 0)
        {
            goto label_8;
        }
        
        label_4:
        this.七与丕丞世专丆万丙();
        return;
        label_8:
        UnityEngine.Vector3 val_4 = this.scroll.currentMomentum;
        if(val_4.x > 0f)
        {
            goto label_10;
        }
    
    }
    private void 七与丕丞世专丆万丙()
    {
        var val_5;
        var val_20;
        var val_21;
        val_20 = this;
        if(this.scroll.movement == 1)
        {
            goto label_2;
        }
        
        if(this.scroll.movement == 0)
        {
            goto label_22;
        }
        
        return;
        label_2:
        List.Enumerator<T> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_21 = 1152921524349664160;
        label_15:
        if(((-1731954160) & 1) == 0)
        {
            goto label_26;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_6)) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_8 = val_6.position;
        UnityEngine.Vector3 val_9 = this.topBoundGO.position;
        if(val_8.y <= val_9.y)
        {
            goto label_15;
        }
        
        this.丂且世丒丄丝一与丙(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_6]);
        goto label_15;
        label_22:
        List.Enumerator<T> val_13 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_21 = 1152921524349664160;
        label_33:
        if(((-1731954160) & 1) == 0)
        {
            goto label_26;
        }
        
        string val_14 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_14)) == false)
        {
            goto label_33;
        }
        
        UnityEngine.Vector3 val_16 = val_14.position;
        UnityEngine.Vector3 val_17 = this.bottomBoundGO.position;
        if(val_16.x >= 0)
        {
            goto label_33;
        }
        
        this.丂且世丒丄丝一与丙(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_14]);
        goto label_33;
        label_26:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丗丁丞丒丗丁七且丐()
    {
        var val_5;
        var val_20;
        var val_21;
        val_20 = this;
        if(this.scroll.movement == 1)
        {
            goto label_2;
        }
        
        if(this.scroll.movement == 0)
        {
            goto label_22;
        }
        
        return;
        label_2:
        List.Enumerator<T> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  true, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_21 = 1152921524349664160;
        label_15:
        if(((-1731711088) & 1) == 0)
        {
            goto label_26;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_6)) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_8 = val_6.position;
        UnityEngine.Vector3 val_9 = this.bottomBoundGO.position;
        if(val_8.y >= 0)
        {
            goto label_15;
        }
        
        this.丏七丝丒七不丝丆丏(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_6]);
        goto label_15;
        label_22:
        List.Enumerator<T> val_13 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  true, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_21 = 1152921524349664160;
        label_33:
        if(((-1731711088) & 1) == 0)
        {
            goto label_26;
        }
        
        string val_14 = val_5.丐丏七丌丕丗业且上();
        if((this.cellsDictinary.ContainsKey(key:  val_14)) == false)
        {
            goto label_33;
        }
        
        UnityEngine.Vector3 val_16 = val_14.position;
        UnityEngine.Vector3 val_17 = this.topBoundGO.position;
        if(val_16.x <= val_17.x)
        {
            goto label_33;
        }
        
        this.丏七丝丒七不丝丆丏(丌丝万上丅丒一丈丘:  this.cellsDictinary.Item[val_14]);
        goto label_33;
        label_26:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丂且世丒丄丝一与丙(EndlessScrollCell 丌丝万上丅丒一丈丘)
    {
        float val_9;
        float val_10;
        System.Collections.Generic.List<EndlessScrollCell> val_9 = this.cellsList;
        val_9 = val_9.Count + 丌丝万上丅丒一丈丘.东七丛丝丑专世丏三;
        if((this.且世丄丏丕丟下丌丈(丞世不丒下上上丝丑:  val_9 + 1)) > (this.且世丄丏丕丟下丌丈(丞世不丒下上上丝丑:  this.丏丌丞丅丅丟与丄丐)))
        {
                if(this.scroll.restrictWithinPanel != true)
        {
                this.scroll.InvalidateBounds();
        }
        
            this.scroll.restrictWithinPanel = true;
            this.scroll.disableDragIfFits = true;
            return;
        }
        
        this.scroll.restrictWithinPanel = false;
        UnityEngine.Transform val_5 = 丌丝万上丅丒一丈丘.transform;
        UnityEngine.Vector3 val_6 = val_5.localPosition;
        val_9 = val_6.x;
        val_10 = val_6.y;
        if(this.scroll.movement == 0)
        {
            goto label_11;
        }
        
        if(this.scroll.movement == 1)
        {
                int val_10 = this.丑丑丒丙丙丗丘丒万;
            val_10 = this.cellSize * val_10;
            val_10 = val_10 - (float)val_10;
        }
        
        if(val_5 == null)
        {
            goto label_13;
        }
        
        label_15:
        val_5.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_6.z};
        goto label_14;
        label_11:
        int val_11 = this.丑丑丒丙丙丗丘丒万;
        val_11 = this.cellSize * val_11;
        val_9 = val_9 + (float)val_11;
        if(val_5 != null)
        {
            goto label_15;
        }
        
        label_13:
        0.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_6.z};
        label_14:
        val_5.SetAsLastSibling();
        this.一丐不丕丈专丕丂七 = val_9;
        this.业丞丕与丄东丞丞丆 = val_9 - this.cellsList.Count;
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 业丌丆业丘丟丆丁丛:  val_9);
    }
    private void 丏七丝丒七不丝丆丏(EndlessScrollCell 丌丝万上丅丒一丈丘)
    {
        float val_6;
        float val_7;
        System.Collections.Generic.List<EndlessScrollCell> val_6 = this.cellsList;
        val_6 = 丌丝万上丅丒一丈丘.东七丛丝丑专世丏三 - val_6.Count;
        if(this.scroll == null)
        {
            goto label_3;
        }
        
        if((val_6 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        label_11:
        this.scroll.restrictWithinPanel = false;
        UnityEngine.Transform val_2 = 丌丝万上丅丒一丈丘.transform;
        UnityEngine.Vector3 val_3 = val_2.localPosition;
        val_6 = val_3.x;
        val_7 = val_3.y;
        if(this.scroll.movement == 0)
        {
            goto label_7;
        }
        
        if(this.scroll.movement == 1)
        {
                int val_7 = this.丑丑丒丙丙丗丘丒万;
            val_7 = this.cellSize * val_7;
            val_7 = val_7 + (float)val_7;
        }
        
        if(val_2 == null)
        {
            goto label_9;
        }
        
        label_16:
        val_2.localPosition = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_3.z};
        goto label_10;
        label_3:
        if((val_6 & 2147483648) == 0)
        {
            goto label_11;
        }
        
        label_4:
        if(this.scroll.restrictWithinPanel != true)
        {
                this.scroll.InvalidateBounds();
        }
        
        this.scroll.restrictWithinPanel = true;
        this.scroll.disableDragIfFits = true;
        return;
        label_7:
        int val_8 = this.丑丑丒丙丙丗丘丒万;
        val_8 = this.cellSize * val_8;
        val_6 = val_6 - (float)val_8;
        if(val_2 != null)
        {
            goto label_16;
        }
        
        label_9:
        0.localPosition = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_3.z};
        label_10:
        val_2.SetAsFirstSibling();
        this.业丞丕与丄东丞丞丆 = val_6;
        this.一丐不丕丈专丕丂七 = this.cellsList.Count + val_6;
        this.东专丑七与丟丁上丗(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 业丌丆业丘丟丆丁丛:  val_6);
    }
    public void UpdateCells()
    {
        var val_3 = this;
        List.Enumerator<T> val_1 = this.cellsList.GetEnumerator();
        label_4:
        if(((-1731132376) & 1) == 0)
        {
            goto label_2;
        }
        
        this.丆丄丟东专与且丂业.Invoke(obj:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东专丑七与丟丁上丗(EndlessScrollCell 丌丝万上丅丒一丈丘, int 业丌丆业丘丟丆丁丛)
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
    public int GetSelectedIndex()
    {
        return (int)this.丞一一丄丆丄业丘专;
    }
    public EndlessScrollCell GetSelectedCell()
    {
        if(this.cellsList != null)
        {
                return this.cellsList.Find(match:  new System.Predicate<EndlessScrollCell>(object:  this, method:  System.Boolean EndlessScroll::万丗丑世七专丟丒丌(EndlessScrollCell 三丟东丕丄丄下下丑)));
        }
        
        return this.cellsList.Find(match:  new System.Predicate<EndlessScrollCell>(object:  this, method:  System.Boolean EndlessScroll::万丗丑世七专丟丒丌(EndlessScrollCell 三丟东丕丄丄下下丑)));
    }
    public void SetSelected(int 丞世不丒下上上丝丑)
    {
        int val_10;
        int val_11;
        System.Predicate<T> val_12;
        val_10 = 丞世不丒下上上丝丑;
        EndlessScroll.丞丘世丐丏丟业丕丒 val_1 = new EndlessScroll.丞丘世丐丏丟业丕丒();
        if(val_1 != null)
        {
                val_11 = val_1;
            .丞世不丒下上上丝丑 = val_10;
            mem[1152921524351131256] = this;
        }
        else
        {
                val_11 = 16;
            mem[16] = val_10;
            mem[24] = this;
            val_10 = mem[16];
        }
        
        if(val_10 < this.丏丌丞丅丅丟与丄丐)
        {
                val_12 = 1152921504616751104;
            EndlessScrollCell val_3 = this.cellsList.Find(match:  new System.Predicate<EndlessScrollCell>(object:  val_1, method:  System.Boolean EndlessScroll.丞丘世丐丏丟业丕丒::业丒丄丘东丈丑一丄(EndlessScrollCell 三丟东丕丄丄下下丑)));
            if(val_3 != 0)
        {
                if((val_3.<与丏三丒一丆丝丁与>k__BackingField) == true)
        {
                return;
        }
        
        }
        
            if(this.canSelectDelegate != null)
        {
                if((this.canSelectDelegate.Invoke(丌丝万上丅丒一丈丘:  val_3)) == false)
        {
                return;
        }
        
        }
        
            System.Predicate<EndlessScrollCell> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Predicate<EndlessScrollCell>(object:  val_1, method:  System.Boolean EndlessScroll.丞丘世丐丏丟业丕丒::丅七丕上丒下万丝东(EndlessScrollCell 三丟东丕丄丄下下丑));
            this.丞一一丄丆丄业丘专 = val_11;
            bool val_8 = UnityEngine.Object.op_Inequality(x:  this.cellsList.Find(match:  val_6), y:  0);
            bool val_9 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            if(this.丒丂与不上丙专丁丞 == null)
        {
                return;
        }
        
            this.丒丂与不上丙专丁丞.Invoke(obj:  this.丞一一丄丆丄业丘专);
            return;
        }
        
        mem[16] = 0;
    }
    public void ToCell(int 丞世不丒下上上丝丑)
    {
        this.业丌丘一丐丕专丆丞(丏丑丝万下与丁丞业:  丞世不丒下上上丝丑, 万丁丕专七丌丐丄丕:  false);
    }
    public void ToStart()
    {
        this.业丌丘一丐丕专丆丞(丏丑丝万下与丁丞业:  0, 万丁丕专七丌丐丄丕:  false);
    }
    public void ToEnd()
    {
        this.业丌丘一丐丕专丆丞(丏丑丝万下与丁丞业:  System.Math.Max(val1:  0, val2:  this.丏丌丞丅丅丟与丄丐 - 1), 万丁丕专七丌丐丄丕:  false);
    }
    public EndlessScroll()
    {
        this.cellSize = 200;
        this.cellCountInRow = 5;
        this.boundsOffsetFactor = 1.5f;
        this.additionalRows = 2;
        this.cellsList = new System.Collections.Generic.List<EndlessScrollCell>();
        this.cellsDictinary = new System.Collections.Generic.Dictionary<UnityEngine.Transform, EndlessScrollCell>();
        this.丞一一丄丆丄业丘专 = 0;
    }
    private bool 万丗丑世七专丟丒丌(EndlessScrollCell 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.东七丛丝丑专世丏三 == this.丞一一丄丆丄业丘专) ? 1 : 0;
    }

}
