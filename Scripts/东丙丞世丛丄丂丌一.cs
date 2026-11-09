using UnityEngine;
private sealed class FacebookController.东丙丞世丛丄丂丌一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private FacebookController.与丙丌丟一七下丏与 丄丌丂东丘丗一万且;
    private float 万丟丆东一下丑丆丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FacebookController.东丙丞世丛丄丂丌一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        int val_9;
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
            goto label_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new FacebookController.与丙丌丟一七下丏与();
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
            goto label_6;
        }
        
        goto label_19;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        val_8 = null;
        val_8 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 != 0)
        {
            goto label_12;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_4 = UnityEngine.Time.realtimeSinceStartup;
        val_4 = val_4 - this.万丟丆东一下丑丆丐;
        if(val_4 >= 0)
        {
            goto label_14;
        }
        
        goto label_15;
        label_12:
        this.丄丌丂东丘丗一万且.丐万丗丒下七丟丁三 = false;
        label_14:
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                if(this.丄丌丂东丘丗一万且.丐万丗丒下七丟丁三 == false)
        {
            goto label_21;
        }
        
        }
        
        label_19:
        val_9 = 0;
        return (bool)val_9;
        label_21:
        System.Action<System.Collections.Generic.IDictionary<System.String, System.Object>> val_6 = new System.Action<System.Collections.Generic.IDictionary<System.String, System.Object>>(object:  this.丄丌丂东丘丗一万且, method:  System.Void FacebookController.与丙丌丟一七下丏与::丂丝三丑丝东丏专一(System.Collections.Generic.IDictionary<string, object> 丏丂万业丙专丏丒丒));
        FacebookController.丞丄丕东万世丈丁丈(丞三丒丒且东与丑丙:  "/me", 丌专业且丛丏丞丝且:  null, 不万丒东万丛三丐丕:  0);
        this.万丟丆东一下丑丆丐 = UnityEngine.Time.realtimeSinceStartup;
        label_15:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
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
