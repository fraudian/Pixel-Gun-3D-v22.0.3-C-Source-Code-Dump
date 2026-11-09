using UnityEngine;
internal sealed class 丈且且世丏丟丅丒业
{
    // Fields
    internal System.Action<string> 丄不丗丂世丗七丁丐;
    internal System.Action 丘丂丗三东丟丟七七;
    internal 与丟丆一七丛丆且丟 丈丏业一不下与丄万;
    private 丈丏三丏丒专丐世丐 且丗丗上专东七丅业;
    
    // Methods
    internal void 丁不丁丌丆丂丛丁丞()
    {
        if(this.丈丏业一不下与丄万 != null)
        {
                this = this.丄不丗丂世丗七丁丐;
            if(this == null)
        {
                return;
        }
        
            this.Invoke(obj:  this.丈丏业一不下与丄万.且丁丙丑丄丁丄与丑());
            return;
        }
        
        if(this.丘丂丗三东丟丟七七 == null)
        {
                return;
        }
        
        this.丘丂丗三东丟丟七七.Invoke();
    }
    private void 世专丂丑丟丁业与丄()
    {
    
    }
    internal void 丈丕丄丅丛丐三一东()
    {
        var val_1;
        if(this.且丗丗上专东七丅业 != null)
        {
                this.且丗丗上专东七丅业.丈丕丄丅丛丐三一东();
        }
        
        val_1 = null;
        val_1 = null;
        GameConnect.一丅世丝万丁七丂丌 = false;
    }
    internal void 上丂丆丆且丏东丝且(System.Action 丌丁丅丌东丐丗丛丈)
    {
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6;
        var val_7;
        if(this.且丗丗上专东七丅业 == null)
        {
                return;
        }
        
        this.且丗丗上专东七丅业.世专丂丑丟丁业与丄 = new System.Action(object:  this, method:  System.Void 丈且且世丏丟丅丒业::世专丂丑丟丁业与丄());
        this.且丗丗上专东七丅业.三丞丐丐丆下且丐丑(七丁丑丗丐专丌丝丗:  this);
        val_7 = null;
        val_7 = null;
        GameConnect.一丅世丝万丁七丂丌 = true;
        System.Nullable<System.Int32> val_2 = this.丈丏业一不下与丄万.七七丈三丒丙丛丗丅();
        val_6 = 0;
        if(((-1987432920) & 1) != 0)
        {
                System.Nullable<System.Int32> val_4 = this.丈丏业一不下与丄万.七七丈三丒丙丛丗丅();
            val_6 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  -1987432920);
        }
        
        this.且丗丗上专东七丅业.万丈三丑丐丘丐丟七 = 丌丁丅丌东丐丗丛丈;
        this.且丗丗上专东七丅业.丈丝丂丐丟万丙丑丕 = val_6;
        this.且丗丗上专东七丅业.世东丛一且且丐丒丂 = 1;
        this.且丗丗上专东七丅业.丈丒不且丘与丙下七(丐且丘丑与万丞丑丅:  val_6);
    }
    public 丈且且世丏丟丅丒业()
    {
        this.且丗丗上专东七丅业 = new 丈丏三丏丒专丐世丐();
    }

}
