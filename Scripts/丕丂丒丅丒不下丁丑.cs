using UnityEngine;
private sealed class ShopNGUIController.丕丂丒丅丒不下丁丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PropertiesHideSHow 丐丒丌丘丒且丑丞丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopNGUIController.丕丂丒丅丒不下丁丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_6;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            .丐丒丌丘丒且丑丞丘 = this.丐丒丌丘丒且丑丞丘;
            float val_6 = 1.1f;
            val_6 = (ShopNGUIController.下丈丏与业上丒丄与)[1152921539124920368].丐丒丌丘丒且丑丞丘.animTime * val_6;
            this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  CoroutineRunner.丞丗丟与不丌万丛丒(七且丆丞丌丘下世丑:  val_6, 七丐丅专且专七三丆:  new System.Action(object:  new ShopNGUIController.下丈丏与业上丒丄与(), method:  System.Void ShopNGUIController.下丈丏与业上丒丄与::丞丆三丘一一丘七丑()), 丏丏下丛丆丐丈三丏:  3));
            val_7 = 1;
            val_6 = 1;
        }
        else
        {
                val_7 = 0;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_7;
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
