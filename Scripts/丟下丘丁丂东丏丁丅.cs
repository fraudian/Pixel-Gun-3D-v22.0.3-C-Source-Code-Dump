using UnityEngine;
private sealed class BattlePassChallengesCommonView.丟下丘丁丂东丏丁丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassChallengesCommonView 丝且与丝丒丟万丁专;
    private bool 业丟上丅丌专丝丂丗;
    private UnityEngine.WaitForSeconds 丒七丞下丁七丐业丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassChallengesCommonView.丟下丘丁丂东丏丁丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.业丟上丅丌专丝丂丗 = (FriendsController.丝丗专上三不丄丑丑() < 1) ? 1 : 0;
        this.丒七丞下丁七丐业丘 = 0;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        long val_3 = FriendsController.丝丗专上三不丄丑丑();
        if(((val_3 > 0) ? 1 : 0) != ((this.业丟上丅丌专丝丂丗 == true) ? 1 : 0))
        {
                this.业丟上丅丌专丝丂丗 = (val_3 > 0) ? 1 : 0;
        }
        
        val_8 = this.丒七丞下丁七丐业丘;
        if(val_8 == null)
        {
                UnityEngine.WaitForSeconds val_7 = null;
            val_8 = val_7;
            val_7 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.丒七丞下丁七丐业丘 = val_8;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = val_8;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
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
