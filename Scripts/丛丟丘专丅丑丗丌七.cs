using UnityEngine;
internal class 丛丟丘专丅丑丗丌七
{
    // Fields
    private static 丛丟丘专丅丑丗丌七 世丒丞七专三与万丕;
    private string 丗丁丆丞丁丐上东丄;
    private string 一丙丙丅三专丟万不;
    private bool 丗专丅下丁丈丑丝三;
    private bool 丄丑丑世丂不丕三丒;
    
    // Properties
    internal static 丛丟丘专丅丑丗丌七 丆丕丝丒不丙且丐丗 { get; }
    internal string 专丏丟丆七与丙丁世 { get; }
    internal string 不下丟丅一丌丞丞丝 { get; }
    
    // Methods
    internal static 丛丟丘专丅丑丗丌七 丑七不且上丗丁一世()
    {
        丛丟丘专丅丑丗丌七 val_2;
        丛丟丘专丅丑丗丌七 val_3 = 丛丟丘专丅丑丗丌七.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        丛丟丘专丅丑丗丌七 val_1 = null;
        val_2 = val_1;
        val_1 = new 丛丟丘专丅丑丗丌七();
        丛丟丘专丅丑丗丌七.世丒丞七专三与万丕 = val_2;
        val_3 = 丛丟丘专丅丑丗丌七.世丒丞七专三与万丕;
        return val_3;
    }
    internal string 丈与上丕丆东丆丏丈()
    {
        string val_1 = this.丗丁丆丞丁丐上东丄;
        if(val_1 != null)
        {
                return (string)val_1;
        }
        
        val_1 = System.String.alignConst;
        return (string)val_1;
    }
    internal string 丘丙三万东丗七丁丅()
    {
        string val_1 = this.一丙丙丅三专丟万不;
        if(val_1 != null)
        {
                return (string)val_1;
        }
        
        val_1 = System.String.alignConst;
        return (string)val_1;
    }
    internal void 丅东丅一丛丐丒丅丏()
    {
        if(this.丗专丅下丁丈丑丝三 != false)
        {
                return;
        }
        
        this.丗专丅下丁丈丑丝三 = true;
        CoroutineRunner.丈与丅丆丘丟丆丆丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丛丟丘专丅丑丗丌七::丈丙丑丝三与丁与且()));
    }
    internal void 丁三丒丆丛丏丂丅丐()
    {
        this.丗专丅下丁丈丑丝三 = false;
        CoroutineRunner.东丁丗三丌丆丝丘丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丛丟丘专丅丑丗丌七::丈丙丑丝三与丁与且()));
    }
    private void 丐丁上下上丈丞丟且()
    {
        bool val_1 = 上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅();
        var val_2 = (this.丄丑丑世丂不丕三丒 == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        if(val_1 != false)
        {
                this.丗丁丆丞丁丐上东丄 = 上丞丑上丙丈丄丗丐.下丄丈不与世丐业专();
            this.一丙丙丅三专丟万不 = AccountsMenuItem.与与丆丞世丒丐丁上();
        }
        
        this.丄丑丑世丂不丕三丒 = val_1;
    }
    private void 丈丙丑丝三与丁与且()
    {
        this.丐丁上下上丈丞丟且();
    }
    public 丛丟丘专丅丑丗丌七()
    {
    
    }

}
