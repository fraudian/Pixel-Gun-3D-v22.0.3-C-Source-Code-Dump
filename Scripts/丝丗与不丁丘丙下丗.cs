using UnityEngine;
private sealed class BPParticles.丝丗与不丁丘丙下丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPParticles 丝且与丝丒丟万丁专;
    public int 丂丁东一丕与下丟不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPParticles.丝丗与不丁丘丙下丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丐丟业丕且且三且丁 == 0)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丘下且世业三丄丒三, 丏业丟一东丂东丘丛:  true);
        this.丝且与丝丒丟万丁专.丐丟业丕且且三且丁.GiveReward(丌丒丝东丌下丕丁丅:  this.丂丁东一丕与下丟不);
        if(this.丝且与丝丒丟万丁专._type == 1)
        {
            goto label_10;
        }
        
        val_5 = 0f;
        if(this.丝且与丝丒丟万丁专._type != 0)
        {
            goto label_11;
        }
        
        float val_2 = PGCompany.BattlePass.BattlePassSettings.不丈丑丑丆丁上下丛();
        goto label_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_13:
        this.丝且与丝丒丟万丁专.丌丄丏下七丁专丂世();
        return false;
        label_10:
        label_12:
        val_5 = PGCompany.BattlePass.BattlePassSettings.丌下丌丂东下业丄丆();
        label_11:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_5);
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
