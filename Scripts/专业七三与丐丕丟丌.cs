using UnityEngine;
private sealed class BattlePassChallengesPhoenixView.专业七三与丐丕丟丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassChallengesPhoenixView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassChallengesPhoenixView.专业七三与丐丕丟丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.BetterWrapContent val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = this.丝且与丝丒丟万丁专._wrap;
        if(val_4 != 0)
        {
                this.丝且与丝丒丟万丁专._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BattlePassChallengesPhoenixView::丐丏专不丗世丝丂丙()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BattlePassChallengesPhoenixView::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
            val_4 = this.丝且与丝丒丟万丁专._wrap;
            val_4.UpdateVisibleCells();
        }
        
        if(this.丝且与丝丒丟万丁专.三丟七丑世丆且且万 == false)
        {
            goto label_9;
        }
        
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._wrap.ResetCells();
        this.丝且与丝丒丟万丁专.三丟七丑世丆且且万 = false;
        label_9:
        val_5 = 0;
        this.丝且与丝丒丟万丁专.上万丕丆专丌业与丁 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
