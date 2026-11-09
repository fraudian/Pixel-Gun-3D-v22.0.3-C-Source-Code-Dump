using UnityEngine;
private sealed class ClanWarChallangeView.上丄丌与丄丄下丂丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanWarChallangeView 丝且与丝丒丟万丁专;
    private float 丗丑丑丝上业丄丁丟;
    private float 丒与不上与丙丈东丐;
    private float 且丄下丘丝丑东丄丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarChallangeView.上丄丌与丄丄下丂丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        int val_9;
        float val_10;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丗丑丑丝上业丄丁丟 = this.丝且与丝丒丟万丁专.丕丆丏丆丈丙东与丗;
        this.丒与不上与丙丈东丐 = 0f;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丆与一东丌不世丘丂 == false)
        {
            goto label_7;
        }
        
        val_8 = 3;
        this.丒上七丌业七丟与丐 = 0;
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_7:
        val_9 = 0;
        this.丝且与丝丒丟万丁专.专下七丌丙丂丟万丐 = true;
        return (bool)val_9;
        label_4:
        this.丗丑丑丝上业丄丁丟 = 5.142877E-39f;
        this.丒与不上与丙丈东丐 = 0f;
        val_7 = 0;
        label_5:
        float val_7 = (float)this.丝且与丝丒丟万丁专.totalPoints;
        val_7 = 0f / val_7;
        val_7 = val_7 * 100f;
        this.丒与不上与丙丈东丐 = val_7;
        this.且丄下丘丝丑东丄丕 = 0f;
        label_10:
        if(this.丝且与丝丒丟万丁专.丕丆丏丆丈丙东与丗 < 0)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专.丆与一东丌不世丘丂 = true;
        this.丝且与丝丒丟万丁专.丌上世不丗丁丐业丕.SetTrigger(name:  "Inpact");
        val_10 = this.丝且与丝丒丟万丁专.timeDelayOnEndAnimation;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        val_8 = 2;
        label_8:
        this.丗丏丅丕丆世丁专丟 = val_8;
        val_9 = 1;
        return (bool)val_9;
        label_13:
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丝且与丝丒丟万丁专.timeForInpactAnimation * val_3;
        val_10 = this.且丄下丘丝丑东丄丕 + val_3;
        this.且丄下丘丝丑东丄丕 = val_10;
        float val_4 = UnityEngine.Mathf.Lerp(a:  this.丗丑丑丝上业丄丁丟, b:  this.丒与不上与丙丈东丐, t:  val_10);
        this.丝且与丝丒丟万丁专.丕丆丏丆丈丙东与丗 = val_4;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._percentImpact, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_4)));
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
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
