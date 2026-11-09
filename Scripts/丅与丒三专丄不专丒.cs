using UnityEngine;
private sealed class BattlePassBuyLevelWindow.丅与丒三专丄不专丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassBuyLevelWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassBuyLevelWindow.丅与丒三专丄不专丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.BattlePass.BPReward val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  this.丝且与丝丒丟万丁专.丑丘七丄万丐三下世);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.丟七丐丝东且丟七丘 = val_6;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._wrap.ResetCells();
        this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 = false;
        if(this.丝且与丝丒丟万丁专._widgetLayout == null)
        {
            goto label_18;
        }
        
        this.丝且与丝丒丟万丁专._widgetLayout.Reposition();
        goto label_18;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        mem[56] = val_6;
        val_6 = mem[56];
        label_5:
        PGCompany.BattlePass.BPRewardView val_2 = this.丝且与丝丒丟万丁专.三不丞丈丆丟丅丆丌(丗七丟丈三不丕一三:  val_6);
        if(val_2 != 0)
        {
                val_2.IsSelected = true;
        }
        
        this.丝且与丝丒丟万丁专._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BattlePassBuyLevelWindow::丁与下丁丗业一丘世()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BattlePassBuyLevelWindow::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
        this.丝且与丝丒丟万丁专._wrap.UpdateVisibleCells();
        if(this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        label_18:
        this.丝且与丝丒丟万丁专._wrap.ScrollTo(丘丒丌下丕专且七专:  0, 与丑丑丑丂丛一丝一:  false);
        val_7 = 0;
        this.丝且与丝丒丟万丁专.上万万丘丅丕专丄丟 = 0;
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
