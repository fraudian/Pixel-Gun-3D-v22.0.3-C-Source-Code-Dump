using UnityEngine;
public abstract class 丏下丒东丅丏丌一丛
{
    // Fields
    private string 丗世东丄业万一下丈;
    private string 丏世丑万世一七丟丞;
    private string 东丟专三丐丟丑丂丅;
    private System.Action 业丁专丝不丟丂丏下;
    
    // Properties
    public abstract string 丛世丗丒丕东丕丌与 { get; }
    public string 下丄丈不与世丐业专 { get; }
    public string 一丌丐业丂不丗不丁 { get; }
    public string 丆丛下专丐一丆丂丂 { get; }
    
    // Methods
    protected 丏下丒东丅丏丌一丛(string 丞丅上丏丂且下丅与, string 丆丕下丄万丞丁世丛, string 丑丞丐丐不不与丘业)
    {
        val_1 = new System.Object();
        this.丗世东丄业万一下丈 = val_1;
        this.丏世丑万世一七丟丞 = 丞丅上丏丂且下丅与;
        this.东丟专三丐丟丑丂丅 = 丑丞丐丐不不与丘业;
    }
    public abstract string 万东丄丅丙东丐东丏(); // 0
    public string 业上丙丞丐丄丆丅七()
    {
        return (string)this.丏世丑万世一七丟丞;
    }
    public string 丄东且丘丄丑下丑东()
    {
        return (string)this.丗世东丄业万一下丈;
    }
    public string 上丄业丙丑丄丌丑丂()
    {
        return (string)this.东丟专三丐丟丑丂丅;
    }
    public void 丘丏业丟丅上上东与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.业丁专丝不丟丂丏下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丁专丝不丟丂丏下 != 1152921538809740888);
    
    }
    public void 且七下丒专世丌业丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.业丁专丝不丟丂丏下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丁专丝不丟丂丏下 != 1152921538809877464);
    
    }
    public abstract void 丄丌专丂丕丌丕丒三(bool 世丕与丙丄丙不丄丝); // 0
    public abstract void 丝丌东七且丞且丛丟(int 与丙丘丗丕一上丙丐); // 0
    public abstract bool 丑不丞丁丟与丅丄专(string 丞丁丑丏丄丏七丂不, bool 丘七与丂丑丕丙丙丘, int 且丒丛与丞世丙丕丌); // 0
    public abstract void 丝三丂万世上丛丛丄(); // 0
    protected void 万丏丛东下丝下丟丕()
    {
        if(this.业丁专丝不丟丂丏下 == null)
        {
                return;
        }
        
        this.业丁专丝不丟丂丏下.Invoke();
    }

}
