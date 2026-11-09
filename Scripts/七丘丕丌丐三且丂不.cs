using UnityEngine;
private sealed class ZombieCreator.七丘丕丌丐三且丂不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ZombieCreator.七丘丕丌丐三且丂不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        string val_11;
        int val_12;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_22;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
            goto label_6;
        }
        
        goto label_22;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = gameObject;
        val_10.SetActive(value:  false);
        goto label_22;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        val_11 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                val_12 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_12;
            return (bool)val_12;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.Wave1_And_Counter != 0)
        {
                gameObject.SetActive(value:  true);
            val_11 = System.String.Format(format:  "{0} 1", arg0:  丟丏下丂七三下丗丕.丘丛丄丄丈且丑丁丞());
            text = val_11;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  2f);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_12 = 1;
            return (bool)val_12;
        }
        
        }
        
        label_22:
        val_12 = 0;
        return (bool)val_12;
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
