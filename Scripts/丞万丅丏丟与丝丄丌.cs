using UnityEngine;
private sealed class AchievementsGUIController.丞万丅丏丟与丝丄丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.AchievementsGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AchievementsGUIController.丞万丅丏丟与丝丄丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        Rilisoft.AchievementsGUIController val_13;
        System.Action<System.Int32, T> val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = this.丝且与丝丒丟万丁专;
        val_14 = Rilisoft.AchievementsManager.Instance;
        if((val_1.<世丌万丈三丐丑丗丅>k__BackingField) == false)
        {
            goto label_5;
        }
        
        Rilisoft.AchievementsManager val_2 = Rilisoft.AchievementsManager.Instance;
        List.Enumerator<T> val_3 = val_2.世上丞丙且丘丄且七.GetEnumerator();
        label_12:
        if(((-1056831232) & 1) == 0)
        {
            goto label_10;
        }
        
        Rilisoft.AchievementView val_7 = val_13.专丄丞丈世一丒丅东(世丞丞万丞丙一丟专:  val_5.丐丏七丌丕丗业且上());
        goto label_12;
        label_5:
        val_15 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        this.丝且与丝丒丟万丁专._scrollView.ResetPosition();
        this.丝且与丝丒丟万丁专._grid.repositionNow = true;
        Rilisoft.AchievementsManager val_8 = Rilisoft.AchievementsManager.Instance;
        val_8.世上丞丙且丘丄且七.丗丕丟下丂丑丈丟丗(丙业与丙丗丝不丈东:  new System.Action<System.Int32, Rilisoft.丞专七丛丛丌世丈丕>(object:  val_13, method:  System.Void Rilisoft.AchievementsGUIController::丅丛三丛丂丑丑丐七(int 下业丕七东丌丝下且, Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)));
        Rilisoft.AchievementsManager val_10 = Rilisoft.AchievementsManager.Instance;
        System.Action<System.Int32, Rilisoft.丞专七丛丛丌世丈丕> val_11 = null;
        val_14 = val_11;
        val_11 = new System.Action<System.Int32, Rilisoft.丞专七丛丛丌世丈丕>(object:  val_13, method:  System.Void Rilisoft.AchievementsGUIController::七且丌专丒上丛丄丕(int 下业丕七东丌丝下且, Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专));
        val_10.世上丞丙且丘丄且七.丛世不丂丁世三三丕(丙业与丙丗丝不丈东:  val_11);
        label_1:
        val_15 = 0;
        return (bool)val_15;
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
