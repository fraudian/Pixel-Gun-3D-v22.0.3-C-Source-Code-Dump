using UnityEngine;
public class EndlessScrollCellDynamic : MonoBehaviour
{
    // Fields
    protected EndlessScrollDynamic 丅七丙丑丂丕丟丗不;
    public string id;
    public UIWidget widget;
    public System.Collections.Generic.List<UIRect> rectsToUpdate;
    public bool selectOnClick;
    private int 东七丛丝丑专世丏三;
    
    // Properties
    public int 丐丒且丝丛丁丕丟丅 { get; }
    public bool 与丆与丂丄丞丒丏丑 { get; }
    public int 丐丌下丛丄丏业丘且 { get; }
    public float 丕不丏丝丅三丐业丗 { get; }
    public int 丟世东丗丞丈且万丗 { get; }
    public float 丞世丏丟丒世世丗万 { get; }
    
    // Methods
    public void UpdateRects()
    {
        List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
        label_7:
        if(((-1726609224) & 1) == 0)
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
    public int get_Height()
    {
        if(this.widget != null)
        {
                return this.widget.height;
        }
        
        return this.widget.height;
    }
    public float get_HalfHeight()
    {
        float val_2 = (float)this.widget.height;
        val_2 = val_2 * 0.5f;
        return (float)val_2;
    }
    public int get_Width()
    {
        if(this.widget != null)
        {
                return this.widget.width;
        }
        
        return this.widget.width;
    }
    public float get_HalfWidth()
    {
        float val_2 = (float)this.widget.width;
        val_2 = val_2 * 0.5f;
        return (float)val_2;
    }
    private void OnClick()
    {
        if(this.selectOnClick == false)
        {
                return;
        }
        
        this.Select(丛丁三七丅且丝丏丙:  true);
    }
    public void Init(EndlessScrollDynamic 丅七丙丑丂丕丟丗不)
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
        var val_1;
        if(丛丁三七丅且丝丏丙 != false)
        {
                val_1 = this.东七丛丝丑专世丏三;
        }
        else
        {
                if(this.丅七丙丑丂丕丟丗不.丞一一丄丆丄业丘专 != this.东七丛丝丑专世丏三)
        {
            goto typeof(EndlessScrollCellDynamic).__il2cppRuntimeField_168;
        }
        
            val_1 = 0;
        }
        
        this.丅七丙丑丂丕丟丗不.SetSelected(丞世不丒下上上丝丑:  0);
        goto typeof(EndlessScrollCellDynamic).__il2cppRuntimeField_168;
    }
    public virtual void OnSelectStateUpdate()
    {
    
    }
    public EndlessScrollCellDynamic()
    {
        this.selectOnClick = true;
        this.东七丛丝丑专世丏三 = 0;
    }

}
