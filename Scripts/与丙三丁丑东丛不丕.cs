using UnityEngine;
private sealed class GameModeController.与丙三丁丑东丛不丕 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public GameModeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameModeController.与丙三丁丑东丛不丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GameModeController val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        System.Action val_17;
        val_11 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_35;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_11 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_12 = 1;
        this.丒上七丌业七丟与丐 = val_11;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_13 = null;
        val_13 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
            goto label_16;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() != true)
        {
                if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_16;
        }
        
        }
        
        }
        
        val_14 = 0;
        goto label_17;
        label_25:
        CoinBonus val_6 = UnityEngine.GameObject.FindGameObjectsWithTag(tag:  "CoinBonus")[0].GetComponent<CoinBonus>();
        if(val_6 != 0)
        {
                val_6.SetPlayer();
        }
        
        val_14 = 1;
        label_17:
        if(val_14 != val_5.Length)
        {
            goto label_25;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
        {
                val_15 = null;
            val_15 = null;
            ZombieCreator.丞丈丟丒丂丞丏不丑.丙丙丟丄丘万丟上不();
        }
        
        val_11.GetComponent<BonusCreator>().丕下不东丌下丈丏下();
        label_16:
        val_11 = 1152921505189752832;
        val_16 = null;
        val_16 = null;
        val_17 = GameModeController.与丙丆不丞与且丆上;
        if(val_17 != null)
        {
                val_17 = GameModeController.与丙丆不丞与且丆上;
            if(val_17 == null)
        {
                val_17 = 0;
        }
        
            val_17.Invoke();
        }
        
        label_35:
        val_12 = 0;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                GameModeController.与丙三丁丑东丛不丕 val_2 = null;
            val_4 = val_2;
            val_2 = new GameModeController.与丙三丁丑东丛不丕();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
