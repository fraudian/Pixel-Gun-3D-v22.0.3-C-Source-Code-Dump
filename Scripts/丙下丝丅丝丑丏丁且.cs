using UnityEngine;
internal sealed class 丙下丝丅丝丑丏丁且
{
    // Fields
    private readonly ImposterVoteChatController 丛丁丄专丈丄丟世丟;
    private System.Action 丗万与三东下上专丕;
    
    // Methods
    internal void 丞一丙丈丘丕丐丑上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗万与三东下上专丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗万与三东下上专丕 != 1152921526262715976);
    
    }
    internal void 丌丆丄丁丑丑丗三万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗万与三东下上专丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗万与三东下上专丕 != 1152921526262852552);
    
    }
    internal 丙下丝丅丝丑丏丁且()
    {
        var val_4;
        UnityEngine.Object val_5;
        ImposterVoteChatController val_6;
        val_4 = null;
        val_4 = null;
        if(GameController.onlineMode != null)
        {
                var val_1 = (null == null) ? GameController.onlineMode : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        if(val_5 != 0)
        {
                val_6 = 616;
            this.丛丁丄专丈丄丟世丟 = val_6;
        }
        else
        {
                val_6 = this.丛丁丄专丈丄丟世丟;
        }
        
        val_6.丞一丙丈丘丕丐丑上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丙下丝丅丝丑丏丁且::丞专丈丌丅丛丙丑上()));
    }
    private void 丞专丈丌丅丛丙丑上()
    {
        if(this.丗万与三东下上专丕 == null)
        {
                return;
        }
        
        this.丗万与三东下上专丕.Invoke();
    }
    internal void 丆丘丟且一丕丏世丒(string 丕丗丘丑丛与丑业丒)
    {
        this.丛丁丄专丈丄丟世丟.丆丘丟且一丕丏世丒(不丟丗丏丛丕不丁丌:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上(), 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    internal void 不七丅丙丏上丛丒丗()
    {
        this.丛丁丄专丈丄丟世丟.丂且丕世万丅一丕七();
        this.丛丁丄专丈丄丟世丟.丌丆丄丁丑丑丗三万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丙下丝丅丝丑丏丁且::丞专丈丌丅丛丙丑上()));
    }
    internal System.Collections.Generic.List<丆与七世东不东丂丙> 丘丅与且丞专上万丝()
    {
        if(this.丛丁丄专丈丄丟世丟 != null)
        {
                return this.丛丁丄专丈丄丟世丟.丘丅与且丞专上万丝();
        }
        
        return this.丛丁丄专丈丄丟世丟.丘丅与且丞专上万丝();
    }
    protected override void Finalize()
    {
        new System.Action() = new System.Action(object:  this, method:  System.Void 丙下丝丅丝丑丏丁且::丞专丈丌丅丛丙丑上());
        this.丛丁丄专丈丄丟世丟.丌丆丄丁丑丑丗三万(丙业与丙丗丝不丈东:  new System.Action());
        this.Finalize();
    }

}
