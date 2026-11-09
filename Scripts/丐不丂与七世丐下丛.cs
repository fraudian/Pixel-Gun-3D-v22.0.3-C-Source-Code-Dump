using UnityEngine;
private sealed class ClanWarChallangeView.丐不丂与七世丐下丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanWarChallangeView 丝且与丝丒丟万丁专;
    private float 丐丕丂万丛且东丆丂;
    private float 世丞上丝丛丟丁下万;
    private float 丘三丟世丆丛丝万世;
    private float 丙丈且丗不丈不丑丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarChallangeView.丐不丂与七世丐下丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ClanWarChallangeView val_8;
        UILabel val_9;
        float val_10;
        float val_11;
        float val_12;
        System.Collections.IEnumerator val_13;
        int val_14;
        val_8 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_8 == null)
        {
            goto label_3;
        }
        
        val_9 = this;
        this.丐丕丂万丛且东丆丂 = (float)this.丝且与丝丒丟万丁专.currentPointsWithoutMyInpact;
        goto label_4;
        label_1:
        val_10 = this;
        val_11 = this.丘三丟世丆丛丝万世;
        val_12 = this.世丞上丝丛丟丁下万;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_3:
        val_9 = this;
        this.丐丕丂万丛且东丆丂 = 0f;
        label_4:
        val_10 = this.丘三丟世丆丛丝万世;
        val_12 = (float)this.丝且与丝丒丟万丁专.currentPoints;
        this.世丞上丝丛丟丁下万 = val_12;
        this.丘三丟世丆丛丝万世 = this.丐丕丂万丛且东丆丂;
        this.丙丈且丗不丈不丑丛 = 0f;
        val_11 = 0f;
        label_5:
        if(val_11 < 0)
        {
            goto label_6;
        }
        
        if(val_8 == null)
        {
            goto label_7;
        }
        
        val_8.丆丝且下专下业丑丝();
        val_13 = val_8.上万一万一丒业东世();
        goto label_8;
        label_6:
        float val_8 = this.丙丈且丗不丈不丑丛;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丝且与丝丒丟万丁专.timeForProgressBarAnimation * val_2;
        val_8 = val_8 + val_2;
        this.丙丈且丗不丈不丑丛 = val_8;
        float val_3 = UnityEngine.Mathf.Lerp(a:  this.丐丕丂万丛且东丆丂, b:  this.世丞上丝丛丟丁下万, t:  val_8);
        mem2[0] = val_3;
        float val_9 = (float)this.丝且与丝丒丟万丁专.totalPoints;
        val_9 = val_3 / val_9;
        this.丝且与丝丒丟万丁专._progressSprite.fillAmount = val_9;
        val_9 = this.丝且与丝丒丟万丁专._pointsLabel;
        val_8 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_10), arg1:  this.丝且与丝丒丟万丁专.totalPoints);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  val_8);
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_7:
        0.丆丝且下专下业丑丝();
        val_13 = 0.上万一万一丒业东世();
        label_8:
        UnityEngine.Coroutine val_7 = val_8.StartCoroutine(routine:  val_13);
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
