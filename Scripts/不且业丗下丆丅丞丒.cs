using UnityEngine;
private sealed class CurrencySpecificWatchPanel.不且业丗下丆丅丞丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.CurrencySpecificWatchPanel 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    private UnityEngine.WaitForSecondsRealtime 丐丁丄上丛专丙丞下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CurrencySpecificWatchPanel.不且业丗下丆丅丞丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_40;
        int val_42;
        int val_43;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_10;
        }
        
        var val_38 = 106029152 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_38 = val_38 + 106029152;
        goto (106029152 + (this.丗丏丅丕丆世丁专丟) << 2 + 106029152);
        label_36:
        if(((-718369248) & 1) == 0)
        {
            goto label_34;
        }
        
        丐丏七丌丕丗业且上().text = "+ Damage "("+ Damage ") + ZombiKillController.丑七不且上丗丁一世().GetCurrentDamage(丂三丟丂丈丐丆丗丟:  new System.Nullable<System.DateTime>() {HasValue = val_21.HasValue})(ZombiKillController.丑七不且上丗丁一世().GetCurrentDamage(丂三丟丂丈丐丆丗丟:  new System.Nullable<System.DateTime>() {HasValue = val_21.HasValue}));
        goto label_36;
        label_10:
        val_40 = 0;
        return (bool)val_40;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝且与丝丒丟万丁专._progressBarHP != 0)
        {
                float val_39 = (float);
            val_39 = val_39 / (float);
            this.丝且与丝丒丟万丁专._progressBarHP.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this.丝且与丝丒丟万丁专._progressBarOldHP != 0)
        {
                float val_40 = (float);
            val_40 = val_40 / (float);
            this.丝且与丝丒丟万丁专._progressBarOldHP.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_42 = ZombiKillController.丑七不且上丗丁一世().GetCurrentZombieHP();
        ZombiKillController.丑七不且上丗丁一世().SetOldZombieHP(丙业与丙丗丝不丈东:  val_42);
        val_43 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_65;
        label_74:
        if(this.丝且与丝丒丟万丁专._progressBarOldHP != 0)
        {
                val_40 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._progressBarOldHP.gameObject, 丏业丟一东丂东丘丛:  true);
            UnityEngine.WaitForSecondsRealtime val_37 = null;
            double val_42 = 0.1;
            double val_41 = (double);
            val_42 = val_37;
            val_41 = val_41 * val_42;
            val_42 = val_41 + val_42;
            val_37 = new UnityEngine.WaitForSecondsRealtime(time:  (float)val_42);
            this.丐丁丄上丛专丙丞下 = val_42;
            this.丒上七丌业七丟与丐 = val_42;
            this.丗丏丅丕丆世丁专丟 = val_40;
            return (bool)val_40;
        }
        
        val_43 = this.丙不丅丌丗上丂丕一 + 1;
        mem2[0] = val_43;
        label_65:
        if(val_43 < 6)
        {
            goto label_74;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 3;
        val_40 = 1;
        return (bool)val_40;
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
