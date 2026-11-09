using UnityEngine;
private sealed class ClanWarRewardsUI.丘丟不不一丐丑丞丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanWarRewardsUI 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarRewardsUI.丘丟不不一丐丑丞丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.ClanWarRewardsUI val_8;
        int val_9;
        val_8 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.silverBuffAnimationDelay);
        val_9 = 1;
        this.丒上七丌业七丟与丐 = val_8;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.totalSilverTwinner.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  new System.Action(object:  val_8, method:  System.Void PGCompany.ClanWarRewardsUI::东业丑下丒且下业丈()));
        this.丝且与丝丒丟万丁专.totalSilverTwinner.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  this.丝且与丝丒丟万丁专.三丑东世丐丒一丒丝.丂丁丏一丙丛业且丌(), 专丂丕丗丗东世丞下:  this.丝且与丝丒丟万丁专.与丒丑七专丘万东专.丂丁丏一丙丛业且丌() + this.丝且与丝丒丟万丁专.三丑东世丐丒一丒丝.丂丁丏一丙丛业且丌());
        val_8 = this.丝且与丝丒丟万丁专.buffedSilverTwinner;
        val_8.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  this.丝且与丝丒丟万丁专.与丒丑七专丘万东专.丂丁丏一丙丛业且丌(), 专丂丕丗丗东世丞下:  0);
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
