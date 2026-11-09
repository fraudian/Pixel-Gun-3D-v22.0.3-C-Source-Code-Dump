using UnityEngine;
internal class 丘丐丏丆丗上丕丒丟 : 业丒与上丄丟与一丘
{
    // Methods
    internal override void 丛丗上丝业下不丈丟(System.Action<bool> 万万丗丛丏丐七丘丏)
    {
        var val_5;
        IntPtr val_6;
        val_5 = this;
        .万万丗丛丏丐七丘丏 = 万万丗丛丏丐七丘丏;
        if((val_5 & 1) != 0)
        {
                return;
        }
        
        val_5 = UnityEngine.Social.localUser;
        val_6 = System.Void 丘丐丏丆丗上丕丒丟.丞上丕丈丒丘丆三丈::丌七与丅专丌丟下丑(bool 东且丁丆丛丁丏丘且, string 丂七东不不丈一丐不);
        System.Action<System.Boolean, System.String> val_3 = new System.Action<System.Boolean, System.String>(object:  new 丘丐丏丆丗上丕丒丟.丞上丕丈丒丘丆三丈(), method:  val_6);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_6 = 1;
        val_5.Authenticate(callback:  null);
    }
    internal override void 丘丙丛东丁与丒七上(System.Action<bool> 万万丗丛丏丐七丘丏)
    {
        goto typeof(丘丐丏丆丗上丕丒丟).__il2cppRuntimeField_168;
    }
    internal override bool 下丏丗与七丑丅与丅()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        return (bool)UnityEngine.Social.localUser.authenticated;
    }
    internal override string 丘与下下丘丕丆业丒()
    {
        var val_4;
        int val_6;
        val_4 = this;
        if((val_4 & 1) != 0)
        {
                val_4 = UnityEngine.Social.localUser;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = val_4;
            string val_3 = val_6.id;
            return (string)val_6;
        }
        
        val_6 = System.String.alignConst;
        return (string)val_6;
    }
    internal override string 一丅上且丆七业丁且()
    {
        return "ios";
    }
    public 丘丐丏丆丗上丕丒丟()
    {
    
    }

}
