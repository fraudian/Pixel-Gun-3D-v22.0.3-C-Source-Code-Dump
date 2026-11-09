using UnityEngine;
private sealed class coinsShop.丘下丕丆丝东丁万七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public coinsShop 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public coinsShop.丘下丕丆丝东丁万七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_5 = null;
            var val_2 = (this.丝且与丝丒丟万丁专.三东丗丂丁下丞丒下 == true) ? 1 : 0;
            val_2 = coinsShop.七三丗丏丑丗三丆世() ^ val_2;
            if(val_2 != false)
        {
                val_6 = null;
            this.丝且与丝丒丟万丁专.三东丗丂丁下丞丒下 = coinsShop.七三丗丏丑丗三丆世();
            if(coinsShop.与丒丘丅丙丌七丂丑 != null)
        {
                coinsShop.与丒丘丅丙丌七丂丑.Invoke();
        }
        
        }
        
            val_7 = 1;
            this.丗丏丅丕丆世丁专丟 = val_7;
            this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.上丏三下专万专东与;
            return (bool)val_7;
        }
        
        val_7 = 0;
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
