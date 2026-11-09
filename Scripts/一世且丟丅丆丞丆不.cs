using UnityEngine;
private sealed class ObjectListEnabler.一世且丟丅丆丞丆不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ObjectListEnabler 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<ObjectListEnabler.ObjectListEntry> 与业丕业业业丌丟丐;
    private ObjectListEnabler.ObjectListEntry 丕丁丁丞丞东丘丕丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ObjectListEnabler.一世且丟丅丆丞丆不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_2;
        List.Enumerator<ObjectListEntry> val_3;
        List.Enumerator<ObjectListEntry> val_8;
        ObjectListEnabler.ObjectListEntry val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_36;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.Begin();
        goto label_36;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.objectList.GetEnumerator();
        val_8 = this.与业丕业业业丌丟丐;
        val_9 = this.丕丁丁丞丞东丘丕丗;
        mem[1152921538176555640] = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_3;
        goto label_8;
        label_2:
        val_9 = this;
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.丕丁丁丞丞东丘丕丗 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕丁丁丞丞东丘丕丗.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.丝且与丝丒丟万丁专.七东业丅丗下一丄丘 != null)
        {
                this.丝且与丝丒丟万丁专.七东业丅丗下一丄丘.Invoke();
        }
        
        val_8 = this.与业丕业业业丌丟丐;
        this.丕丁丁丞丞东丘丕丗 = 0;
        label_8:
        label_15:
        if((val_8 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_4 = val_8.丐丏七丌丕丗业且上();
        this.丕丁丁丞丞东丘丕丗 = val_4;
        if(val_4 == null)
        {
            goto label_15;
        }
        
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  val_4.m_stringLength);
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_14:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        if(this.丝且与丝丒丟万丁专.万万丗丛丏丐七丘丏 != null)
        {
                this.丝且与丝丒丟万丁专.万万丗丛丏丐七丘丏.Invoke();
        }
        
        if(this.丝且与丝丒丟万丁专.looped != false)
        {
                new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.loopDelay);
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
            this.丗丏丅丕丆世丁专丟 = 2;
            val_10 = 1;
            return (bool)val_10;
        }
        
        label_36:
        val_10 = 0;
        return (bool)val_10;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
