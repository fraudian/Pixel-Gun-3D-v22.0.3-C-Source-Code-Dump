using UnityEngine;
private sealed class BattlePassPremiumPackWindow.专与万上丛丝专丏万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassPremiumPackWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassPremiumPackWindow.专与万上丛丝专丏万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 == 0)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            this.丝且与丝丒丟万丁专._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BattlePassPremiumPackWindow::万丐丌丅丌丟丘丘丈()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BattlePassPremiumPackWindow::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
            if(this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 != false)
        {
                val_3 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_3;
            return (bool)val_3;
        }
        
        }
        
            val_3 = 0;
            return (bool)val_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._wrap.ResetCells();
        val_3 = 0;
        this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 = false;
        return (bool)val_3;
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
