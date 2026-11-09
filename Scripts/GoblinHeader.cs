using UnityEngine;
internal sealed class GoblinHeader : PGBehaviour
{
    // Fields
    private TextMeshBounds _textMeshBounds;
    private System.Func<int, string> 丆不丝丂下与丙丆丌;
    
    // Properties
    public System.Func<int, string> 丅丌丞万丅丗且丒与 { get; set; }
    
    // Methods
    public System.Func<int, string> get_TimeFormatter()
    {
        System.Func<System.Int32, System.String> val_2;
        var val_3;
        val_2 = this.丆不丝丂下与丙丆丌;
        if(val_2 != null)
        {
                return (System.Func<System.Int32, System.String>)val_2;
        }
        
        val_3 = null;
        val_3 = null;
        val_2 = GoblinHeader.<>c.<>9__3_0;
        if(val_2 == null)
        {
                System.Func<System.Int32, System.String> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Func<System.Int32, System.String>(object:  GoblinHeader.<>c.__il2cppRuntimeField_static_fields, method:  System.String GoblinHeader.<>c::丐且丆丏丈丘丑专丄(int 三丟东丕丄丄下下丑));
            GoblinHeader.<>c.<>9__3_0 = val_2;
        }
        
        this.丆不丝丂下与丙丆丌 = val_2;
        return (System.Func<System.Int32, System.String>)val_2;
    }
    public void set_TimeFormatter(System.Func<int, string> 丙业与丙丗丝不丈东)
    {
        this.丆不丝丂下与丙丆丌 = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(int 丂三丟丂丈丐丆丗丟)
    {
        this.gameObject.SetActive(value:  false);
        if(丂三丟丂丈丐丆丗丟 < 1)
        {
                return;
        }
        
        if(this._textMeshBounds == 0)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  true);
        this._textMeshBounds.Text = this.TimeFormatter.Invoke(arg:  丂三丟丂丈丐丆丗丟);
    }
    public GoblinHeader()
    {
    
    }

}
