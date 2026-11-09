using UnityEngine;
private sealed class ClanLootBoxRewardUI.丏与丙东丝下一丑丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanLootBoxRewardUI 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private System.Collections.Generic.List.Enumerator<PGCompany.InventoryItemView> 业东东下丘丒丝业专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanLootBoxRewardUI.丏与丙东丝下一丑丛(int 丗丏丅丕丆世丁专丟)
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
        List.Enumerator<PGCompany.InventoryItemView> val_30;
        float val_32;
        int val_33;
        float val_34;
        float val_36;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_87;
        }
        
        val_30 = this.业东东下丘丒丝业专;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.丞上丈丁丙丙丟东万.GetEnumerator();
        val_30 = this.业东东下丘丒丝业专;
        mem[1152921554110886192] = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.业东东下丘丒丝业专 = val_3;
        label_3:
        if((val_30 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_4 = val_30.丐丏七丌丕丗业且上();
        PGTweenerPosition val_5 = val_4.GetComponentInChildren<PGTweenerPosition>(includeInactive:  true);
        PGTweenerRotation val_6 = val_4.GetComponentInChildren<PGTweenerRotation>(includeInactive:  true);
        PGTweenerScale val_7 = val_4.GetComponentInChildren<PGTweenerScale>(includeInactive:  true);
        val_5.gameObject.SetActive(value:  true);
        if(this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 == false)
        {
            goto label_13;
        }
        
        val_32 = val_5.丌丛丟丙丘丝丂一不() / this.丝且与丝丒丟万丁专.multiOpenSpeedScale;
        if(val_5 != null)
        {
            goto label_19;
        }
        
        goto label_16;
        label_6:
        this.一世丕丕业且且丅丌();
        val_33 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_33;
        label_13:
        val_32 = val_5.丌丛丟丙丘丝丂一不();
        if(val_5 != null)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        val_5.与丂丑一丙丆丕一上(丁万丐丌专丛丐世丌:  val_32);
        UnityEngine.Vector3 val_11 = this.丝且与丝丒丟万丁专.rewardAnimationStartPoint.position;
        val_34 = val_11.x;
        UnityEngine.Vector3 val_13 = val_4.transform.position;
        val_36 = val_34;
        val_5.丗万丞丒东万丂丛三(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_36, y = val_11.y, z = val_11.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        if(val_6 == 0)
        {
            goto label_26;
        }
        
        if(this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 == false)
        {
            goto label_27;
        }
        
        val_34 = val_5.丌丛丟丙丘丝丂一不() / this.丝且与丝丒丟万丁专.multiOpenSpeedScale;
        if(val_6 != null)
        {
            goto label_32;
        }
        
        goto label_30;
        label_27:
        val_34 = val_5.丌丛丟丙丘丝丂一不();
        if(val_6 != null)
        {
            goto label_32;
        }
        
        label_30:
        label_32:
        val_36 = val_34;
        val_6.与丂丑一丙丆丕一上(丁万丐丌专丛丐世丌:  val_36);
        val_6.丗万丞丒东万丂丛三();
        label_26:
        if(val_7 == 0)
        {
            goto label_36;
        }
        
        if(this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 == false)
        {
            goto label_37;
        }
        
        val_34 = val_5.丌丛丟丙丘丝丂一不() / this.丝且与丝丒丟万丁专.multiOpenSpeedScale;
        if(val_7 != null)
        {
            goto label_42;
        }
        
        goto label_40;
        label_37:
        val_34 = val_5.丌丛丟丙丘丝丂一不();
        if(val_7 != null)
        {
            goto label_42;
        }
        
        label_40:
        label_42:
        val_7.与丂丑一丙丆丕一上(丁万丐丌专丛丐世丌:  val_34);
        val_7.丗万丞丒东万丂丛三();
        label_36:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(val_5.gameObject.activeInHierarchy != false)
        {
                UnityEngine.AudioSource val_24 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专.丈丕丂丅万丝七一丙());
        }
        
        }
        
        val_30 = this.三丛与七下专丅丕东;
        if(val_30 == null)
        {
                val_34 = this.丝且与丝丒丟万丁专.animateRewardDelay;
            if(this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 != false)
        {
                val_34 = val_34 / this.丝且与丝丒丟万丁专.multiOpenSpeedScale;
        }
        
            val_30 = new UnityEngine.WaitForSeconds();
            val_30 = new UnityEngine.WaitForSeconds(seconds:  val_34);
            this.三丛与七下专丅丕东 = val_30;
        }
        
        val_33 = 1;
        this.丒上七丌业七丟与丐 = val_30;
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_87:
        val_33 = 0;
        return (bool)val_33;
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
