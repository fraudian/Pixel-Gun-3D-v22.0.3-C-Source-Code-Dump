using UnityEngine;
private sealed class 丛丅丘业丏丕下业丏.上下一丌七丏丁丕丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丛丅丘业丏丕下业丏 丝且与丝丒丟万丁专;
    public bool 七丆丟丗世丟且丒丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丛丅丘业丏丕下业丏.上下一丌七丏丁丕丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_5;
        int val_6;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(MainMenuHeroCamera.丑七不且上丗丁一世() == 0)
        {
                val_6 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_6;
            return (bool)val_6;
        }
        
            val_5 = this.七丆丟丗世丟且丒丆;
            bool val_4 = this.丝且与丝丒丟万丁专.丐一七东丏不丅丗丘(七丆丟丗世丟且丒丆:  (val_5 == true) ? 1 : 0);
        }
        
        val_6 = 0;
        return (bool)val_6;
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
