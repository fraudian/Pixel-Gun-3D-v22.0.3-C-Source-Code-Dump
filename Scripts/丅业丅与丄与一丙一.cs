using UnityEngine;
public class 丅业丅与丄与一丙一
{
    // Fields
    private 丅丝不专世七丏丕七 丕丂专丂丌万丗东丈;
    private readonly UnityEngine.MonoBehaviour 丝丄丝丟万丌业一万;
    private readonly System.Func<System.Collections.IEnumerator, UnityEngine.Coroutine> 丙上丈丄丑下丛丞一;
    private readonly System.Collections.Generic.Queue<System.Collections.IEnumerator>[] 丄丆丈丆丕专不七七;
    private readonly 专丌七丑丙丛专七丕[] 丁丅丘丁万万丗丅一;
    private readonly UnityEngine.Coroutine[] 三丒丘三丟三万丄丄;
    private readonly System.Collections.IEnumerator 丙丈世丁丒三丙丄三;
    private readonly System.Collections.IEnumerator 丝丏丐丂丅丁丛一丕;
    private readonly UnityEngine.WaitForEndOfFrame 丅下丈专丕丅丑业下;
    private System.Collections.IEnumerator 丒丄丅丅丝丏丗且万;
    private UnityEngine.Coroutine 专丐业丗且且丘丟业;
    
    // Methods
    public 丅业丅与丄与一丙一(int 不丅丛专丘丅专丘丕, UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)
    {
        int val_9 = 不丅丛专丘丅专丘丕;
        this.丝丄丝丟万丌业一万 = 不丗上三丛丒上东丑;
        this.丙上丈丄丑下丛丞一 = new System.Func<System.Collections.IEnumerator, UnityEngine.Coroutine>(object:  不丗上三丛丒上东丑, method:  public UnityEngine.Coroutine UnityEngine.MonoBehaviour::StartCoroutine(System.Collections.IEnumerator routine));
        this.丅下丈专丕丅丑业下 = new UnityEngine.WaitForEndOfFrame();
        this.丄丆丈丆丕专不七七 = new System.Collections.Generic.Queue<System.Collections.IEnumerator>[0];
        this.丁丅丘丁万万丗丅一 = new 专丌七丑丙丛专七丕[0];
        this.三丒丘三丟三万丄丄 = new UnityEngine.Coroutine[0];
        if(val_9 < 1)
        {
            goto label_1;
        }
        
        var val_9 = 0;
        label_10:
        System.Collections.Generic.Queue<System.Collections.IEnumerator> val_6 = new System.Collections.Generic.Queue<System.Collections.IEnumerator>();
        if(this.丄丆丈丆丕专不七七 == null)
        {
            goto label_2;
        }
        
        if(val_6 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        this.丄丆丈丆丕专不七七[val_9] = val_6;
        val_9 = this.丁丅丘丁万万丗丅一;
        val_9 = val_9 + 1;
        val_9[0] = 0;
        if(val_9 != val_9)
        {
            goto label_10;
        }
        
        label_1:
        this.丙丈世丁丒三丙丄三 = this.丈丌业万且丙丝丌东();
        this.丝丏丐丂丅丁丛一丕 = this.丌丄丏下七丁专丂世();
    }
    public void 丐不上业三丁丏丐世(System.Collections.IEnumerator[] 七丛丏七丏丘业丞一)
    {
        var val_1;
        System.Collections.Generic.Queue<System.Collections.IEnumerator> val_2;
        val_1 = 0;
        goto label_1;
        label_15:
        val_2 = this.丄丆丈丆丕专不七七[val_1];
        if(七丛丏七丏丘业丞一.Length > val_1)
        {
                val_2.Enqueue(item:  七丛丏七丏丘业丞一[val_1]);
            val_2 = this.丄丆丈丆丕专不七七[val_1];
        }
        
        val_2.Enqueue(item:  this.丙丈世丁丒三丙丄三);
        this.丄丆丈丆丕专不七七[val_1].Enqueue(item:  this.丝丏丐丂丅丁丛一丕);
        val_1 = 1;
        label_1:
        if(this.丄丆丈丆丕专不七七.Length > val_1)
        {
            goto label_15;
        }
    
    }
    public void 业丁丝丟丌丂丛丄三()
    {
        var val_5;
        if(this.专丐业丗且且丘丟业 != null)
        {
                this.专丐业丗且且丘丟业 = this.丙上丈丄丑下丛丞一.Invoke(arg:  this.丌丌丕丝丑且丗丕万());
        }
        
        val_5 = 0;
        goto label_3;
        label_15:
        if(this.丁丅丘丁万万丗丅一[0] == 2)
        {
            goto label_6;
        }
        
        UnityEngine.Coroutine val_4 = this.丙上丈丄丑下丛丞一.Invoke(arg:  this.丅东世且业世丞丘专(七丞丙丒三丕且丌丟:  0));
        if(this.三丒丘三丟三万丄丄 == null)
        {
            goto label_8;
        }
        
        if(val_4 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_4 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        this.三丒丘三丟三万丄丄[val_5] = val_4;
        label_6:
        val_5 = 1;
        label_3:
        if(this.丄丆丈丆丕专不七七.Length > val_5)
        {
            goto label_15;
        }
        
        this.丕丂专丂丌万丗东丈 = 2;
    }
    public void 丙世丑东丕丙丙丛丝()
    {
        var val_1 = 0;
        goto label_1;
        label_16:
        this.丄丆丈丆丕专不七七[val_1].Clear();
        this.丁丅丘丁万万丗丅一[0] = 0;
        if(this.三丒丘三丟三万丄丄[val_1] != null)
        {
                this.丝丄丝丟万丌业一万.StopCoroutine(routine:  this.三丒丘三丟三万丄丄[val_1]);
            this.三丒丘三丟三万丄丄[val_1] = 0;
        }
        
        val_1 = 1;
        label_1:
        if(this.丄丆丈丆丕专不七七.Length > val_1)
        {
            goto label_16;
        }
    
    }
    private System.Collections.IEnumerator 丅东世且业世丞丘专(uint 七丞丙丒三丕且丌丟)
    {
        丅业丅与丄与一丙一.丂东丏世丒丛丒专下 val_1 = new 丅业丅与丄与一丙一.丂东丏世丒丛丒专下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丞丙丒三丕且丌丟 = 七丞丙丒三丕且丌丟;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丌丌丕丝丑且丗丕万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 丅业丅与丄与一丙一.东丄丑丆丘丂丛丆丅();
    }
    private bool 不三丏不丒丅东丂与()
    {
        System.Collections.Generic.Queue<System.Collections.IEnumerator>[] val_1;
        var val_2;
        var val_2 = 0;
        label_4:
        val_1 = this.丄丆丈丆丕专不七七;
        if(val_2 >= this.丄丆丈丆丕专不七七.Length)
        {
            goto label_1;
        }
        
        val_1 = this.丁丅丘丁万万丗丅一;
        val_2 = val_2 + 1;
        if(val_1[0] != 2)
        {
            goto label_4;
        }
        
        val_2 = 1;
        return (bool)val_2;
        label_1:
        val_2 = 0;
        return (bool)val_2;
    }
    private System.Collections.IEnumerator 丈丌业万且丙丝丌东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 丅业丅与丄与一丙一.业专丅丁丁东下丂丝();
    }
    private System.Collections.IEnumerator 丌丄丏下七丁专丂世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 丅业丅与丄与一丙一.丒丁一丛丒专丌丐东();
    }
    public bool 上上丈东丈七丘丏三()
    {
        return (bool)(this.丕丂专丂丌万丗东丈 == 1) ? 1 : 0;
    }
    public System.Collections.IEnumerator 世上专丐丂业世世丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 丅业丅与丄与一丙一.不丑丁丑丑东丏丄丁();
    }

}
