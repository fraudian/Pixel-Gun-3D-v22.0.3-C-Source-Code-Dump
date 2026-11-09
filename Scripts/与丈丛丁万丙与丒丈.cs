using UnityEngine;
private sealed class CubeBossAnimationController.与丈丛丁万丙与丒丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.CubeBossAnimationController 丝且与丝丒丟万丁专;
    public RilisoftBot.CubeBossAnimationController.丄丞丂丑东上丝丁丛 丈丙七丕丘丟丌业丛;
    private bool 专丘丗丙丕丏东丆七;
    private string 丘东丄丏丕丆专丁丝;
    private string 世专丕丂且专专业丏;
    private string 丄世七丕丛丏业丘七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CubeBossAnimationController.与丈丛丁万丙与丒丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.BotAiController val_33;
        var val_40;
        val_33 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_33 = 106018456 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_33 = val_33 + 106018456;
        }
        else
        {
                val_40 = 0;
            return (bool);
        }
    
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
