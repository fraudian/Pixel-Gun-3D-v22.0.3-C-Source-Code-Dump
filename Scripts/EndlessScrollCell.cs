using UnityEngine;
public class EndlessScrollCell : MonoBehaviour
{
    // Fields
    private UIWidget _widget;
    private int _spaceBetweenCells;
    private EndlessScroll 丅七丙丑丂丕丟丗不;
    public string id;
    public System.Collections.Generic.List<UIRect> rectsToUpdate;
    private int 东七丛丝丑专世丏三;
    private bool <与丏三丒一丆丝丁与>k__BackingField;
    
    // Properties
    public int 丐丒且丝丛丁丕丟丅 { get; }
    public bool 与丆与丂丄丞丒丏丑 { get; }
    internal bool 专与业丐丄与丅世东 { get; set; }
    
    // Methods
    public void UpdateRects()
    {
        List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
        label_7:
        if(((-1728043336) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public int get_Index()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    public bool get_Selected()
    {
        return (bool)(this.丅七丙丑丂丕丟丗不.丞一一丄丆丄业丘专 == this.东七丛丝丑专世丏三) ? 1 : 0;
    }
    internal bool 丐与丅七不丁丕丗丏()
    {
        return (bool)this.<与丏三丒一丆丝丁与>k__BackingField;
    }
    internal void 世七七且专丌上专丘(bool 丙业与丙丗丝不丈东)
    {
        this.<与丏三丒一丆丝丁与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnClick()
    {
        this.Select(丛丁三七丅且丝丏丙:  true);
    }
    public void Init(EndlessScroll 丅七丙丑丂丕丟丗不)
    {
        this.丅七丙丑丂丕丟丗不 = 丅七丙丑丂丕丟丗不;
    }
    public bool SetIndex(int 丞世不丒下上上丝丑)
    {
        var val_2;
        if(this.东七丛丝丑专世丏三 == 丞世不丒下上上丝丑)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.东七丛丝丑专世丏三 = 丞世不丒下上上丝丑;
        this.name = 丞世不丒下上上丝丑.ToString();
        val_2 = 1;
        return (bool)val_2;
    }
    public void Select(bool 丛丁三七丅且丝丏丙)
    {
        var val_11;
        EndlessScroll val_12;
        int val_13;
        var val_14;
        var val_15;
        val_11 = this;
        bool val_10 = 丛丁三七丅且丝丏丙;
        val_12 = this.丅七丙丑丂丕丟丗不;
        if(this.丅七丙丑丂丕丟丗不 == null)
        {
                val_12 = this.丅七丙丑丂丕丟丗不;
        }
        
        val_13 = this.东七丛丝丑专世丏三;
        bool val_1 = val_10 ^ 1;
        var val_2 = (this.丅七丙丑丂丕丟丗不.丞一一丄丆丄业丘专 == val_13) ? 1 : 0;
        val_2 = val_2 ^ val_10;
        val_10 = val_2;
        if(val_1 == true)
        {
            goto label_1;
        }
        
        val_14 = val_13;
        goto label_3;
        label_1:
        val_2 = val_2 & val_1;
        val_15 = val_2;
        if(val_12 == null)
        {
                val_13 = this.东七丛丝丑专世丏三;
        }
        
        if(this.丅七丙丑丂丕丟丗不.丞一一丄丆丄业丘专 != val_13)
        {
            goto label_5;
        }
        
        val_14 = 0;
        label_3:
        this.丅七丙丑丂丕丟丗不.SetSelected(丞世不丒下上上丝丑:  0);
        val_15 = val_10;
        label_5:
        if(val_15 == false)
        {
                return;
        }
        
        val_11 = ???;
        val_13 = ???;
        goto typeof(EndlessScrollCell).__il2cppRuntimeField_168;
    }
    internal void 与丘不丏丟世丙丅上(int 丟丒且一专丟丙下一)
    {
        if(this._widget == 0)
        {
                return;
        }
        
        this._widget.width = 丟丒且一专丟丙下一 - this._spaceBetweenCells;
        this._widget.height = 丟丒且一专丟丙下一 - this._spaceBetweenCells;
    }
    public virtual void OnSelectStateUpdate()
    {
    
    }
    public EndlessScrollCell()
    {
        this._spaceBetweenCells = 10;
        this.东七丛丝丑专世丏三 = 0;
    }

}
