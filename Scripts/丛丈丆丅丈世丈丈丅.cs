using UnityEngine;
private sealed class ProgressRoadPointInfoView.丛丈丆丅丈世丈丈丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业;
    public ProgressRoadPointInfoView 丝且与丝丒丟万丁专;
    public bool 且丁丐丑丞丐七丙与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProgressRoadPointInfoView.丛丈丆丅丈世丈丈丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        ProgressRoadPointInfoView val_19;
        UILabel val_20;
        int val_21;
        var val_22;
        int val_23;
        ProgressRoadPointRewardsView val_24;
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_25;
        var val_26;
        string val_27;
        System.Collections.Generic.List<ScaleSettings> val_28;
        UnityEngine.Transform val_29;
        var val_30;
        val_20 = this;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = this.丝且与丝丒丟万丁专;
        if(UniversalRewardView.丅业东万丌丕上丌丄 == false)
        {
            goto label_2;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_21 = 1;
        return (bool)val_21;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_40;
        }
        
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_2:
        List.Enumerator<T> val_2 = this.三丒不不一七东丕业.GetEnumerator();
        val_22 = 0;
        val_23 = 0;
        val_24 = 0;
        goto label_11;
        label_12:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(0 != 0)
        {
                int val_6 = 0.Count;
            val_24 = val_6 + val_24;
        }
        
        if(val_6 != 0)
        {
                int val_7 = val_6.Count;
            val_23 = val_7 + val_23;
        }
        
        if(val_7 != 0)
        {
                val_22 = val_7.Count + val_22;
        }
        
        label_11:
        if(((-188837296) & 1) != 0)
        {
            goto label_12;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专.itemsView.丈且东丑丂且万丒丅(三丒不不一七东丕业:  this.三丒不不一七东丕业);
        val_25 = this.三丒不不一七东丕业;
        this.丝且与丝丒丟万丁专.contentView.丈且东丑丂且万丒丅(三丒不不一七东丕业:  val_25, 丕丕世且下一与丝与:  0f);
        if(this.且丁丐丑丞丐七丙与 != false)
        {
                val_25 = this.三丒不不一七东丕业;
            this.丝且与丝丒丟万丁专.rewardsView.丈且东丑丂且万丒丅(三丒不不一七东丕业:  val_25);
        }
        else
        {
                val_22 = 0;
        }
        
        this.丝且与丝丒丟万丁专.contentViewsLayout.Reposition();
        ProgressRoad.丅丂丅丕下丑丘万一 val_9 = this.三丒不不一七东丕业.Item[0];
        val_20 = this.丝且与丝丒丟万丁专.headerLabel;
        if((ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) < val_9.丈丄丂下丒专丌丛丄)
        {
                val_26 = null;
            val_27 = this.丝且与丝丒丟万丁专.lockedHeaderKey;
        }
        else
        {
                val_26 = null;
            val_27 = this.丝且与丝丒丟万丁专.unlockedHeaderKey;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_20, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27));
        if(val_22 == (val_24 + val_23))
        {
                val_19.Hide();
        }
        else
        {
                if((val_24 >= 1) && ((val_22 | val_23) == 0))
        {
                val_19 = this.丝且与丝丒丟万丁专.scaleSettings;
            val_28 = val_19;
            val_29 = this.丝且与丝丒丟万丁专.itemsView.transform;
            val_30 = val_24;
        }
        else
        {
                if(((val_22 | val_24) == 0) && (val_23 >= 1))
        {
                val_20 = this.丝且与丝丒丟万丁专.scaleSettingsModes;
            UnityEngine.Transform val_15 = this.丝且与丝丒丟万丁专.contentView.transform;
            val_15.丟丟下东东业一丒丐(丒丙丒丈上丌三与一:  val_20, 万一专丐丄丐丗丒丏:  val_15, 丌丒丝东丌下丕丁丅:  val_23);
        }
        
            val_21 = 0;
            if((val_24 | val_23) != 0)
        {
                return (bool)val_21;
        }
        
            if(val_22 < 1)
        {
                return (bool)val_21;
        }
        
            val_24 = this.丝且与丝丒丟万丁专.rewardsView;
            val_19 = this.丝且与丝丒丟万丁专.scaleSettings;
            UnityEngine.Transform val_17 = val_24.transform;
            val_28 = val_19;
            val_29 = val_17;
            val_30 = val_22;
        }
        
            val_17.丟丟下东东业一丒丐(丒丙丒丈上丌三与一:  val_28, 万一专丐丄丐丗丒丏:  val_29, 丌丒丝东丌下丕丁丅:  0);
        }
        
        label_40:
        val_21 = 0;
        return (bool)val_21;
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
