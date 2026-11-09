using UnityEngine;
private sealed class ConnectScene.丛丁丛七一万丝丛东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    public bool 业丛丕丐丏世丞丈且;
    public string 与且专丈不万东一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.丛丁丛七一万丝丛东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 = false;
    }
    private bool MoveNext()
    {
        ConnectScene val_26;
        int val_27;
        var val_28;
        int val_29;
        val_26 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_104;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        label_33:
        if(PGCompany.GameModeHub.GMHMainView.丌丄一丒且下丅丁丏() == false)
        {
            goto label_4;
        }
        
        val_26 = 1152921505133842432;
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
            goto label_13;
        }
        
        BannerWindowController val_4 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_4.viewedBannersCountInConnectScene == 0)
        {
            goto label_13;
        }
        
        object[] val_5 = new object[1];
        BannerWindowController val_6 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_26 = val_6.viewedBannersCountInConnectScene;
        val_5[0] = val_26;
        UnityEngine.Debug.LogFormat(format:  "Cancel showing fake: {0}", args:  val_5);
        goto label_47;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        label_63:
        if((ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑() == 0) || (ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丗丅丗丐丐丈丞丝丞() == false))
        {
            goto label_32;
        }
        
        if(PGCompany.GameModeHub.GMHMainView.丌丄一丒且下丅丁丏() == true)
        {
            goto label_33;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_27 = 1;
        return (bool)val_27;
        label_32:
        if(ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丝世丆与丏一丘丌专() == false)
        {
            goto label_38;
        }
        
        val_27 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_27;
        return (bool)val_27;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 == false)
        {
            goto label_41;
        }
        
        label_104:
        val_27 = 0;
        return (bool)val_27;
        label_4:
        UnityEngine.Debug.Log(message:  "[ConnectScene.WaitLoadingAndShowReplaceAdmobPereliv] GMHMainView: false");
        goto label_47;
        label_38:
        this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 = false;
        goto label_47;
        label_13:
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_49;
        }
        
        label_47:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_77:
        val_27 = 0;
        this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 = false;
        return (bool)val_27;
        label_41:
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 = true;
        if(((this.业丛丕丐丏世丞丈且 == false) || (ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丝世丆与丏一丘丌专() == true)) || (ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丗丅丗丐丐丈丞丝丞() == true))
        {
            goto label_63;
        }
        
        ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().三丕世不与不丌丙丄();
        goto label_63;
        label_49:
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                val_28 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_28 != null)
        {
                val_29 = val_24.viewedBannersCountInConnectScene;
        }
        else
        {
                val_28 = 92;
            val_29 = 0;
        }
        
            mem[92] = 1;
        }
        
        ReplaceAdmobPerelivController.丝丘丑丒丌丈丒世丌(与且专丈不万东一万:  this.与且专丈不万东一万);
        ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丝下三丗业丁业丛丟();
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_77;
        }
        
        goto label_77;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.万不专丕丒东世三丘 = false;
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
