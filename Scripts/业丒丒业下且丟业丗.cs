using UnityEngine;
private sealed class MonsterHunterModeController.业丒丒业下且丟业丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MonsterHunterModeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonsterHunterModeController.业丒丒业下且丟业丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_7;
        int val_8;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                val_8 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_8;
            return (bool)val_8;
        }
        
            if(this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 == 0)
        {
                this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        }
        
            val_7 = this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.gameObject;
            if(this.丝且与丝丒丟万丁专.万七丗万丁丝下下丘.丟丌下三七丁与丟丑() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
            this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专.万七丗万丁丝下下丘.transform, 丒专丌万丄一丒万丏:  this.丝且与丝丒丟万丁专.丅三丂一丟且上专丆);
            val_7 = this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝;
            val_7.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  0);
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
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
