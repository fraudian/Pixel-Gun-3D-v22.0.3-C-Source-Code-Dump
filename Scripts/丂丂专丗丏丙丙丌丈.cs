using UnityEngine;
private sealed class TEMPShowUpgradeBanner.丂丂专丗丏丙丙丌丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.TEMPShowUpgradeBanner 丝且与丝丒丟万丁专;
    private UIButton 丝丘丄七丐丄七丗丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TEMPShowUpgradeBanner.丂丂专丗丏丙丙丌丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_6;
        int val_7;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丌三万世丕丈一丏丐 == true)
        {
            goto label_18;
        }
        
        UIButton val_1 = this.丝且与丝丒丟万丁专.GetComponent<UIButton>();
        this.丝丘丄七丐丄七丗丒 = val_1;
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<VersionChange>(丑东与丅丐丅丂丞业:  UpdatesChecker.丞世丁丕丌东丈丗丆())) != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        val_6 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_6 != 0)
        {
                val_6.ForceShowBanner(丌丅丕一丛丛丄一万:  10, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
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
