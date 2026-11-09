using UnityEngine;
private sealed class BattlePassChallengesDailyView.丈丛丕专丙与东丂丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassChallengesDailyView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 丞丐下东且丛不丆专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassChallengesDailyView.丈丛丕专丙与东丂丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UILabel val_17;
        int val_18;
        UnityEngine.WaitForSeconds val_20;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丞丐下东且丛不丆专 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_11;
        }
        
        val_17 = this.丝且与丝丒丟万丁专;
        if(val_17.Count < 1)
        {
            goto label_11;
        }
        
        val_17 = this.丝且与丝丒丟万丁专._timeLeftLabel;
        if(val_17 == 0)
        {
            goto label_11;
        }
        
        val_17 = System.String.alignConst;
        System.Nullable<System.DateTime> val_6 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-386965664) & 1) == 0)
        {
            goto label_16;
        }
        
        System.Nullable<System.DateTime> val_7 = this.丝且与丝丒丟万丁专.Item[this.丝且与丝丒丟万丁专.Count - 1].丒万丐不丆且丒与丒();
        if(((-386965680) & 1) == 0)
        {
            goto label_18;
        }
        
        if((( & 1) == 0) || (((-386965728) & 1) == 0))
        {
            goto label_20;
        }
        
        System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7.HasValue.丐丏七丌丕丗业且上()}, d2:  new System.DateTime() {dateData = val_6.HasValue.丐丏七丌丕丗业且上()});
        goto label_23;
        label_2:
        val_18 = 0;
        return (bool)val_18;
        label_16:
        string val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
        goto label_27;
        label_20:
        label_23:
        label_27:
        val_17 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5973"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        label_18:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._timeLeftLabel, 丕丗丘丑丛与丑业丒:  val_17);
        label_11:
        val_20 = this.丞丐下东且丛不丆专;
        if(val_20 == null)
        {
                UnityEngine.WaitForSeconds val_15 = null;
            val_20 = val_15;
            val_15 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.丞丐下东且丛不丆专 = val_20;
        }
        
        val_18 = 1;
        this.丒上七丌业七丟与丐 = val_20;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
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
