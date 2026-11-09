using UnityEngine;
private sealed class GoblinAutoCollectorController.丅丗丏与丈丛丁丅丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.三东丏不丗世丅丌丄 万丛且上丅丁丗七世;
    public PGCompany.丗丟丄丈东丝丕丄世 与丙丄丈丝且业且与;
    public PGCompany.GoblinAutoCollectorController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoblinAutoCollectorController.丅丗丏与丈丛丁丅丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.GoblinAutoCollectorController val_9;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝丗专上三不丄丑丑() >= 1)
        {
                if(this.万丛且上丅丁丗七世.业东丅东丌上丗丑不() != 一丅三东丑丗丅丗丝.丂东丛丆丈丝丏丄丌().业东丅东丌上丗丑不())
        {
                return false;
        }
        
            if(this.与丙丄丈丝且业且与 == null)
        {
                this.丝且与丝丒丟万丁专.丘丕且三与业不七万 = PixelTime.丝丗专上三不丄丑丑();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丗丗丛丆专丛丏东且();
        }
        
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专世东丌丑丐与与业()) != false)
        {
                PGCompany.丐丁七一丒三东万丌.丐丒下丈丈三丟丕丙();
        }
        
            val_9.丝丝丞丟丕丛丙丘丘();
            return false;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
