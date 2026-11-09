using UnityEngine;
private sealed class OnOpenModuleChestUI.丟丄丛丐丂上丒世东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public OnOpenModuleChestUI 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private System.Collections.Generic.List.Enumerator<PGCompany.InventoryItemView> 业东东下丘丒丝业专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OnOpenModuleChestUI.丟丄丛丐丂上丒世东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_2;
        List.Enumerator<PGCompany.InventoryItemView> val_3;
        List.Enumerator<PGCompany.InventoryItemView> val_21;
        float val_22;
        int val_23;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_63;
        }
        
        val_21 = this.业东东下丘丒丝业专;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.丟丟且丄丑丝丑丒丅.GetEnumerator();
        val_21 = this.业东东下丘丒丝业专;
        mem[1152921538179980016] = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.业东东下丘丒丝业专 = val_3;
        label_3:
        if((val_21 & 1) != 0)
        {
                string val_4 = val_21.丐丏七丌丕丗业且上();
            PGTweenerPosition val_5 = val_4.GetComponentInChildren<PGTweenerPosition>(includeInactive:  true);
            PGTweenerRotation val_6 = val_4.GetComponentInChildren<PGTweenerRotation>(includeInactive:  true);
            PGTweenerScale val_7 = val_4.GetComponentInChildren<PGTweenerScale>(includeInactive:  true);
            val_5.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_9 = this.丝且与丝丒丟万丁专.rewardAnimationStartPoint.position;
            val_22 = val_9.x;
            UnityEngine.Vector3 val_11 = val_4.transform.position;
            val_5.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_22, y = val_9.y, z = val_9.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            if(val_6 != 0)
        {
                val_6.丗万丞丒东万丂丛三();
        }
        
            if(val_7 != 0)
        {
                val_7.丗万丞丒东万丂丛三();
        }
        
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(val_5.gameObject.activeInHierarchy != false)
        {
                UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专.丂丅东丕丘万与七丒());
        }
        
        }
        
            val_21 = this.三丛与七下专丅丕东;
            if(val_21 == null)
        {
                val_22 = this.丝且与丝丒丟万丁专.animateRewardDelay;
            val_21 = new UnityEngine.WaitForSeconds();
            val_21 = new UnityEngine.WaitForSeconds(seconds:  val_22);
            this.三丛与七下专丅丕东 = val_21;
        }
        
            val_23 = 1;
            this.丒上七丌业七丟与丐 = val_21;
            this.丗丏丅丕丆世丁专丟 = val_23;
            return (bool)val_23;
        }
        
        this.一世丕丕业且且丅丌();
        val_23 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_23;
        label_63:
        val_23 = 0;
        return (bool)val_23;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.业东东下丘丒丝业专);
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
