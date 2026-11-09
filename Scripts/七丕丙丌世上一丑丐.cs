using UnityEngine;
private sealed class TaskUIImposterModeExploreSample.七丕丙丌世上一丑丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIImposterModeExploreSample 丝且与丝丒丟万丁专;
    private long 丘万丆丁丛下丒丞上;
    private System.Collections.Generic.List.Enumerator<TaskUIImposterNumButton> 业东东下丘丒丝业专;
    private TaskUIImposterNumButton 丁业丌业丈丕下一三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIImposterModeExploreSample.七丕丙丌世上一丑丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 97;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_5;
        var val_9;
        List.Enumerator<TaskUIImposterNumButton> val_10;
        UnityEngine.Vector3 val_33;
        TaskUIImposterNumButton val_36;
        var val_37;
        var val_38;
        var val_39;
        long val_40;
        int val_42;
        int val_43;
        var val_45;
        var val_46;
        long val_49;
        var val_50;
        if(this.丗丏丅丕丆世丁专丟 > 7)
        {
            goto label_168;
        }
        
        var val_30 = 106038048 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_30 = val_30 + 106038048;
        goto (106038048 + (this.丗丏丅丕丆世丁专丟) << 2 + 106038048);
        label_14:
        if(((-1381632608) & 1) == 0)
        {
            goto label_11;
        }
        
        val_5.丐丏七丌丕丗业且上().color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.exploreSample, g = V9.16B, b = V10.16B, a = V11.16B};
        goto label_14;
        label_136:
        val_33 = this.丝且与丝丒丟万丁专.upPosition;
        val_36 = 0;
        if((this.丝且与丝丒丟万丁专.丏丁丕与丞且丈丈丑(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {y = V9.16B, z = V10.16B})) == false)
        {
            goto label_31;
        }
        
        this.丝且与丝丒丟万丁专.世丕丐丂丕丅一丅七();
        List.Enumerator<T> val_8 = this.丝且与丝丒丟万丁专.丌丏上东丞丏丙丆丌.GetEnumerator();
        val_36 = this.业东东下丘丒丝业专;
        mem[1152921537584964928] = val_9;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.业东东下丘丒丝业专 = val_10;
        if((val_36 & 1) == 0)
        {
            goto label_35;
        }
        
        val_36 = val_36.丐丏七丌丕丗业且上();
        val_37 = 0;
        this.丁业丌业丈丕下一三 = val_36;
        goto label_36;
        label_35:
        this.一世丕丕业且且丅丌();
        val_38 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        goto label_37;
        label_31:
        val_42 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_42;
        return (bool)val_42;
        label_36:
        if((this.丝且与丝丒丟万丁专.丁丈丙丂丟世丆丁丞(丞丘一丐不丏世丅丘:  null)) == false)
        {
            goto label_39;
        }
        
        if( == 0)
        {
            goto label_40;
        }
        
        val_36 = 4;
        goto label_41;
        label_39:
        val_43 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_109;
        label_40:
        val_36 = this.丝且与丝丒丟万丁专.audioSource;
        label_41:
        val_36.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.fillerClip);
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  0.25f);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        val_43 = 3;
        goto label_109;
        label_37:
        if((this.丝且与丝丒丟万丁专.丁丈丙丂丟世丆丁丞(丞丘一丐不丏世丅丘:  0)) == false)
        {
            goto label_45;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_46;
        }
        
        val_33 = this.丝且与丝丒丟万丁专.downPosition;
        goto label_47;
        label_45:
        if( == 0)
        {
            goto label_48;
        }
        
        val_33 = this.丝且与丝丒丟万丁专.downPosition;
        goto label_49;
        label_46:
        val_33 = this.丝且与丝丒丟万丁专.downPosition;
        label_47:
        if((this.丝且与丝丒丟万丁专.丏丁丕与丞且丈丈丑(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_33, y = V9.16B, z = V10.16B})) == false)
        {
            goto label_50;
        }
        
        this.丝且与丝丒丟万丁专.丂丗丐且丑丅丂专丈 = true;
        this.丝且与丝丒丟万丁专.业丑丆丘三三丈丝丗 = PixelTime.丝丗专上三不丄丑丑();
        goto label_54;
        label_50:
        this.丒上七丌业七丟与丐 = 0;
        val_43 = 5;
        goto label_109;
        label_48:
        val_33 = this.丝且与丝丒丟万丁专.downPosition;
        label_49:
        bool val_17 = this.丝且与丝丒丟万丁专.丏丁丕与丞且丈丈丑(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_33, y = V9.16B, z = V10.16B});
        this.丒上七丌业七丟与丐 = 0;
        val_43 = 4;
        goto label_109;
        label_11:
        val_45 = 0;
        val_46 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_93;
        }
        
        if( == 0)
        {
            goto label_97;
        }
        
        if(210 != 210)
        {
            goto label_95;
        }
        
        goto label_97;
        label_93:
        if( == 0)
        {
            goto label_97;
        }
        
        label_95:
        label_97:
        if(this.丝且与丝丒丟万丁专.丂丗丐且丑丅丂专丈 == false)
        {
            goto label_98;
        }
        
        val_5 = this.丝且与丝丒丟万丁专.丟专三一丂三东世丛;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Continue Explore bad index: "("Continue Explore bad index: ") + val_5);
        label_54:
        val_39 = this;
        val_40 = this.丝且与丝丒丟万丁专.业丑丆丘三三丈丝丗 + this.丝且与丝丒丟万丁专.exploreTime;
        this.丘万丆丁丛下丒丞上 = val_40;
        if(val_40 <= PixelTime.丝丗专上三不丄丑丑())
        {
            goto label_101;
        }
        
        val_49 = this.丘万丆丁丛下丒丞上;
        val_5 = val_49 - PixelTime.丝丗专上三不丄丑丑();
        val_36 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10175"), arg0:  val_5);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.timerLabel, 丕丗丘丑丛与丑业丒:  val_36);
        this.丒上七丌业七丟与丐 = 0;
        val_43 = 6;
        goto label_109;
        label_101:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.timerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10176"));
        val_49 = 1152921537583641728;
        val_50 = 0;
        goto label_115;
        label_125:
        if(val_50 == this.丝且与丝丒丟万丁专.丟专三一丂三东世丛)
        {
                TaskUIImposterNumButton val_25 = this.丝且与丝丒丟万丁专.丌丏上东丞丏丙丆丌.Item[0];
            val_25.widget.color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.badSample, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        else
        {
                TaskUIImposterNumButton val_26 = this.丝且与丝丒丟万丁专.丌丏上东丞丏丙丆丌.Item[0];
            val_26.widget.color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.goodSample, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        
        val_50 = 1;
        label_115:
        if(val_50 < this.丝且与丝丒丟万丁专.丌丏上东丞丏丙丆丌.Count)
        {
            goto label_125;
        }
        
        val_33 = this.丝且与丝丒丟万丁专.upPosition;
        val_36 = 0;
        if((this.丝且与丝丒丟万丁专.丏丁丕与丞且丈丈丑(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_33, y = V9.16B, z = V10.16B})) != false)
        {
                this.丝且与丝丒丟万丁专.inputBlocker.SetActive(value:  false);
            val_42 = 0;
            return (bool)val_42;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        val_43 = 7;
        label_109:
        this.丗丏丅丕丆世丁专丟 = val_43;
        val_42 = 1;
        return (bool)val_42;
        label_98:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Start Explore");
        if(this.丝且与丝丒丟万丁专.audioSource.isPlaying == true)
        {
            goto label_136;
        }
        
        this.丝且与丝丒丟万丁专.audioSource.clip = this.丝且与丝丒丟万丁专.moveUpClip;
        this.丝且与丝丒丟万丁专.audioSource.loop = true;
        this.丝且与丝丒丟万丁专.audioSource.Play();
        goto label_136;
        label_168:
        val_42 = 0;
        return (bool)val_42;
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
