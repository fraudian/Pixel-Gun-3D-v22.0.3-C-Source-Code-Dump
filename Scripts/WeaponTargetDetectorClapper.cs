using UnityEngine;
internal class WeaponTargetDetectorClapper : WeaponTargetDetectorBase
{
    // Fields
    public System.Collections.Generic.List<TweenRotation> listActiveTwins;
    public float minDuaration;
    public float maxDuaration;
    private float 丗丟七与丅万万不丐;
    private bool 丟业丄丐丌丝丅丘丟;
    
    // Properties
    private float 与丕丁丞丞三丁专万 { get; }
    
    // Methods
    private float 丟上且七万丈不丗丗()
    {
        float val_1 = S0 * S0;
        val_1 = this.maxDuaration / val_1;
        this.丗丟七与丅万万不丐 = val_1;
        return val_1;
    }
    internal override void 不上丆东丘丌丄丛且(UnityEngine.Transform 丞下万上三丘上与专, float 专世丂丆专业丌丈丈)
    {
        System.Collections.Generic.List<TweenRotation> val_12;
        var val_13;
        var val_14;
        var val_15;
        if(丞下万上三丘上与专 == 0)
        {
            goto label_3;
        }
        
        val_13 = 1152921540326770816;
        val_14 = 0;
        goto label_4;
        label_14:
        TweenRotation val_2 = this.listActiveTwins.Item[0];
        mem2[0] = 2;
        TweenRotation val_3 = this.listActiveTwins.Item[0];
        专世丂丆专业丌丈丈 = 专世丂丆专业丌丈丈 * 专世丂丆专业丌丈丈;
        float val_4 = this.maxDuaration / 专世丂丆专业丌丈丈;
        this.丗丟七与丅万万不丐 = val_4;
        专世丂丆专业丌丈丈 = val_4 * 专世丂丆专业丌丈丈;
        mem2[0] = UnityEngine.Mathf.Clamp(value:  专世丂丆专业丌丈丈, min:  this.minDuaration, max:  this.maxDuaration);
        this.listActiveTwins.Item[0].enabled = true;
        val_14 = 1;
        this.丟业丄丐丌丝丅丘丟 = false;
        label_4:
        val_12 = this.listActiveTwins;
        if(val_14 < val_12.Count)
        {
            goto label_14;
        }
        
        return;
        label_3:
        if(this.丟业丄丐丌丝丅丘丟 == true)
        {
                return;
        }
        
        val_13 = 1152921540326770816;
        val_15 = 0;
        goto label_17;
        label_25:
        TweenRotation val_8 = this.listActiveTwins.Item[0];
        mem2[0] = this.maxDuaration;
        TweenRotation val_9 = this.listActiveTwins.Item[0];
        mem2[0] = 0;
        this.listActiveTwins.Item[0].PlayReverse();
        val_15 = 1;
        this.丟业丄丐丌丝丅丘丟 = true;
        label_17:
        val_12 = this.listActiveTwins;
        if(val_15 < val_12.Count)
        {
            goto label_25;
        }
    
    }
    public WeaponTargetDetectorClapper()
    {
        this.listActiveTwins = new System.Collections.Generic.List<TweenRotation>();
        this.minDuaration = 1.701412E+38f;
        this.maxDuaration = 2f;
        this.丗丟七与丅万万不丐 = -1f;
        mem[1152921540327031768] = 1;
        this = new UnityEngine.MonoBehaviour();
    }

}
