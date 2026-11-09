using UnityEngine;
private sealed class GameEventProgressBar.一不丞三业丝东丑丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventProgressBar 丝且与丝丒丟万丁专;
    private UnityEngine.Vector3 丗世下世上丞上且丅;
    private float 且一丂世且丂专东七;
    private float 东上丞丄七丙丒与下;
    private bool 丐丌丗世世丂丅且丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventProgressBar.一不丞三业丝东丑丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        UnityEngine.Vector3 val_25;
        var val_26;
        var val_27;
        UnityEngine.Vector3 val_28;
        var val_29;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_24 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_1 = this.丝且与丝丒丟万丁专.丛丝业丂丒丙丛丆丙(七丄且丘丏与丟丂世:  0, 丌丆上丌三丗一上丒:  false);
        this.丗世下世上丞上且丅 = val_1;
        mem[1152921542735641500] = val_1.y;
        mem[1152921542735641504] = val_1.z;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.丒业丅丆丌丆丕丐丂(丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = this.丗世下世上丞上且丅, y = V9.16B, z = V8.16B});
        this.丝且与丝丒丟万丁专.业丙丐与丝丞七东三();
        goto label_7;
        label_2:
        val_26 = this;
        var val_2 = (this.丐丌丗世世丂丅且丕 == false) ? 1 : 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_4:
        UnityEngine.Vector3 val_3 = 0.丛丝业丂丒丙丛丆丙(七丄且丘丏与丟丂世:  0, 丌丆上丌三丗一上丒:  false);
        this.丗世下世上丞上且丅 = val_3;
        mem[1152921542735641500] = val_3.y;
        mem[1152921542735641504] = val_3.z;
        label_5:
        UnityEngine.Vector3 val_6 = this.丝且与丝丒丟万丁专._fillBackWidget.gameObject.transform.localScale;
        val_28 = this.丗世下世上丞上且丅;
        val_28 = this.丗世下世上丞上且丅;
        val_28 = this.丗世下世上丞上且丅;
        val_6.x = val_6.x - this.丗世下世上丞上且丅;
        this.且一丂世且丂专东七 = System.Math.Abs(val_6.x);
        UnityEngine.Vector3 val_9 = this.丝且与丝丒丟万丁专._fillBackWidget.gameObject.transform.localScale;
        val_26 = this;
        this.丐丌丗世世丂丅且丕 = true;
        val_27 = 0;
        mem[1152921542735641512] = (val_28 > val_9.x) ? 1f : -1f;
        label_9:
        val_29 = this.丝且与丝丒丟万丁专._fillBackWidget.gameObject.transform;
        if(val_27 != 0)
        {
                val_25 = this.丗世下世上丞上且丅;
            val_29.localScale = new UnityEngine.Vector3() {x = val_25, y = val_28, z = this.丗世下世上丞上且丅};
            this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  0.1f);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_24 = 1;
            return (bool)val_24;
        }
        
        UnityEngine.Vector3 val_14 = val_29.localScale;
        float val_15 = UnityEngine.Time.deltaTime;
        float val_25 = this.且一丂世且丂专东七;
        val_15 = val_15 * this.东上丞丄七丙丒与下;
        val_25 = this.丝且与丝丒丟万丁专._fillSpeed * val_25;
        val_15 = val_15 * val_25;
        val_15 = val_14.x + val_15;
        val_29 = this.丝且与丝丒丟万丁专._fillBackWidget.gameObject.transform;
        val_29.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_25 = this.东上丞丄七丙丒与下;
        UnityEngine.Vector3 val_20 = this.丝且与丝丒丟万丁专._fillBackWidget.gameObject.transform.localScale;
        val_24 = 1;
        val_20.x = val_20.x - this.丗世下世上丞上且丅;
        this.丐丌丗世世丂丅且丕 = (val_25 > 0f) ? ((val_20.x < 0) ? 1 : 0) : ((val_20.x > 0f) ? 1 : 0);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_6:
        0.丒业丅丆丌丆丕丐丂(丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = this.丗世下世上丞上且丅, y = V9.16B, z = V8.16B});
        0.业丙丐与丝丞七东三();
        label_7:
        val_24 = this.丝且与丝丒丟万丁专.下丛丄丐丕丘丒下丞;
        if(val_24 == null)
        {
                return (bool)val_24;
        }
        
        val_24.Invoke();
        val_24 = 0;
        return (bool)val_24;
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
