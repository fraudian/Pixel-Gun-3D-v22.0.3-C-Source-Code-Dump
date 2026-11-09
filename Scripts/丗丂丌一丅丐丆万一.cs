using UnityEngine;
private sealed class ExperienceController.丗丂丌一丅丐丆万一 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private float 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public ExperienceController 丝且与丝丒丟万丁专;
    
    // Properties
    private float System.Collections.Generic.IEnumerator<System.Single>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExperienceController.丗丂丌一丅丐丆万一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.丝且与丝丒丟万丁专.gameObject);
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                0.与一丅丘丁三丆丟且();
        }
        
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void ExperienceController::与一丅丘丁三丆丟且()));
        0.Refresh();
        val_8 = null;
        if(ExperienceController.丞丞丘业东丙丏七丌() <= 64)
        {
                val_9 = null;
            if(ExperienceController.万丏丙丈东东万丝丞() >= (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌())))
        {
                0.丘丌三丏丆专丑丙下();
        }
        
        }
        
        this.丝且与丝丒丟万丁专.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        this.丝且与丝丒丟万丁专.丙丐丄丛东七丑万丙 = true;
        if(0 != 1)
        {
                if(146 == 146)
        {
                return false;
        }
        
            if(0 == 0)
        {
                return false;
        }
        
            if(146 != 148)
        {
                return false;
        }
        
            return false;
        }
        
        if(0 == 0)
        {
                return false;
        }
        
        return false;
    }
    private float System.Collections.Generic.IEnumerator<System.Single>.get_Current()
    {
        return (float)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Single>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new ExperienceController.丗丂丌一丅丐丆万一();
        return (System.Collections.Generic.IEnumerator<System.Single>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator();
    }

}
