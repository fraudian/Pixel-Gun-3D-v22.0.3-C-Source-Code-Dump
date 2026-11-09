using UnityEngine;
private sealed class NetworkStartTableNGUIController.丝七丟丂丟不丞丒丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.丝七丟丂丟不丞丒丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NetworkStartTableNGUIController val_22;
        int val_23;
        var val_24;
        var val_25;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_26;
        var val_27;
        var val_28;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        val_22 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PGCompany.VeteranChest.丒专丛丒丄业丛业丁.丕三三丐一一丟丘丂() == false)
        {
            goto label_2;
        }
        
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_1:
        val_23 = 0;
        return (bool)val_23;
        label_2:
        val_24 = null;
        val_24 = null;
        GameController.onlineMode.丗三不丞丈业丑丘万 = true;
        if(val_22 != null)
        {
                this.丝且与丝丒丟万丁专.上丏丙东丁不丕丁丟 = false;
            this.丝且与丝丒丟万丁专.三与万丝丒一丏丝七 = false;
            this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = false;
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject.SetActive(value:  false);
        val_22.三东且三丈与丂丐丄(下丁丞丝丛一丘丐丒:  true);
        if(((GameConnect.业丛丛丂一丆丕丗丟() != true) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.与丂丝丟丟三丑丝万() != true))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 18)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 26)
        {
            goto label_27;
        }
        
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.startInterfacePanel != null)
        {
            goto label_63;
        }
        
        label_64:
        label_63:
        this.丝且与丝丒丟万丁专.startInterfacePanel.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.Continue_GoToLobbyButton_StartInterface, 丏业丟一东丂东丘丛:  (~PGCompany.丁东丌世与丕东丆上.且丏下丂专丞不丂丞()) & 1);
        val_25 = null;
        val_25 = null;
        val_26 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_26 != null)
        {
                val_26 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_26 == null)
        {
                val_26 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_11 = val_26.丌不丅不丞东万专专();
            if((val_11.HasValue.丙东专丂世丈丏丁丂() == 2) && ((660308728 & 1) != 0))
        {
                val_27 = null;
            val_27 = null;
            if((PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.上万世丒丁万下丌丛(丏丒丒丌一丌东丘丝:  GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七(), 万且丕业与丗丗丝七:  false)) != true)
        {
                val_28 = null;
            val_28 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_22.丑丗丌丆丘丂业丞下().丆丙丗三东专丐不上();
        }
        
        }
        
        }
        
        }
        
        if((val_22.一丈丛丘与丕丛丝东() != true) && (GameConnect.一与东丝万上三丆丏() != true))
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                val_22.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
        }
        
        }
        
        val_23 = 0;
        this.丝且与丝丒丟万丁专.丞丗丆万丆丗丘丕丙 = 0;
        return (bool)val_23;
        label_27:
        var val_21 = (GameConnect.丑丌丛丈丅丅与不业() != 27) ? 1 : 0;
        if(this.丝且与丝丒丟万丁专.startInterfacePanel != null)
        {
            goto label_63;
        }
        
        goto label_64;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
