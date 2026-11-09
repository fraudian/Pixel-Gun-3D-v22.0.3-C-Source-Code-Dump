using UnityEngine;
private sealed class Player_move_c.丑业东丒一丗万丑丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 万丌万丅专丞业丈万;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丛丌丟丟丕丁丘丙丘;
    private float 丞三丄丑丅丘东丌丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丑业东丒一丗万丑丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_5;
        Player_move_c val_6;
        float val_7;
        float val_8;
        int val_9;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_6 = this.万丌万丅专丞业丈万;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6.丘七业丒丐世丂丅丒() <= 0f)
        {
            goto label_3;
        }
        
        val_7 = val_5;
        this.丞三丄丑丅丘东丌丗 = 0f;
        val_6 = this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.markingEnemyLabel;
        val_6.SetActive(value:  true);
        goto label_7;
        label_0:
        val_7 = this.丞三丄丑丅丘东丌丗;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        val_8 = 1f;
        if(val_7 <= val_8)
        {
            goto label_8;
        }
        
        val_5 = this.万丌万丅专丞业丈万;
        this.丝且与丝丒丟万丁专.不业丁七七丞丙丟丑(万丌万丅专丞业丈万:  val_5);
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_8:
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue.gameObject.SetActive(value:  true);
        val_6 = this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue;
        val_6.fillAmount = val_7;
        float val_3 = val_8 - val_7;
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_8 = this.丞三丄丑丅丘东丌丗;
        float val_4 = UnityEngine.Time.deltaTime;
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        val_4 = val_4 / this.丛丌丟丟丕丁丘丙丘;
        val_4 = val_8 + val_4;
        this.丞三丄丑丅丘东丌丗 = val_4;
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
