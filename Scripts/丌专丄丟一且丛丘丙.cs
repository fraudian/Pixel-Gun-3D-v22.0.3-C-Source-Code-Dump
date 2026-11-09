using UnityEngine;
private sealed class TurretController_HologramProjector.丌专丄丟一且丛丘丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_HologramProjector 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_HologramProjector.丌专丄丟一且丛丘丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_1 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_1;
        return (bool)val_1;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerBodyRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerHeadRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerRightLegRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerLeftLegRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerSelfLeftArmRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.playerSelfRightArmRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.royaleAvatarBodyRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.royaleAvatarHeadRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.royaleAvatarArmsRenderer);
        this.丝且与丝丒丟万丁专.丆丕丐丁丝丝不丒万(丐丑丅丘丄丑丄丂与:  this.丝且与丝丒丟万丁专.characterInterface.royaleAvatarLegsRenderer);
        val_1 = 0;
        return (bool)val_1;
        label_1:
        val_1 = 0;
        return (bool)val_1;
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
