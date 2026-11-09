using UnityEngine;
private sealed class BattlePassRootUI.丁且丅下丕丛万丟丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BattlePassRootUI 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 丞丐下东且丛不丆专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassRootUI.丁且丅下丕丛万丟丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BattlePassRootUI val_10;
        string val_11;
        int val_12;
        UnityEngine.WaitForSeconds val_13;
        val_10 = this.丝且与丝丒丟万丁专;
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
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
            goto label_5;
        }
        
        System.Nullable<System.TimeSpan> val_3 = val_2.丙世丑丅丒丑业与不();
        val_11 = 0;
        if(( & 1) == 0)
        {
            goto label_11;
        }
        
        val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5975"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        goto label_11;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_5:
        val_11 = 0;
        label_11:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) != false)
        {
                val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
        }
        
        val_10 = this.丝且与丝丒丟万丁专._timeLeftlLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_10, 丕丗丘丑丛与丑业丒:  val_11);
        val_13 = this.丞丐下东且丛不丆专;
        if(val_13 == null)
        {
                UnityEngine.WaitForSeconds val_9 = null;
            val_13 = val_9;
            val_9 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.丞丐下东且丛不丆专 = val_13;
        }
        
        val_12 = 1;
        this.丒上七丌业七丟与丐 = val_13;
        this.丗丏丅丕丆世丁专丟 = val_12;
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
