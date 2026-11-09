using UnityEngine;
private sealed class PlayerTaskImposterModeController.丙丗丘丛七丅万丝丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerTaskImposterModeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerTaskImposterModeController.丙丗丘丛七丅万丝丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        var val_11;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.且丁丕丕丞且丗丝丙 = this.丝且与丝丒丟万丁专.三丞专丕丐东丅与丏;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                val_10 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_10;
            return (bool)val_10;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  InGameGUIPart_Imposter.__il2cppRuntimeField_parent, 丏业丟一东丂东丘丛:  true);
        val_11 = null;
        val_11 = null;
        bool val_2 = 丟东丘丏上世且上丕();
        if(null == 0)
        {
            goto label_19;
        }
        
        if(val_2 == false)
        {
            goto label_20;
        }
        
        label_22:
        丙丌丏丈丛万七丂丅();
        goto label_21;
        label_19:
        if(val_2 == true)
        {
            goto label_22;
        }
        
        label_20:
        丄丌丕东丒三丑七丙();
        label_21:
        val_9 = 1;
        goto label_23;
        label_45:
        PlayerTaskImposterMode val_3 = this.丝且与丝丒丟万丁专.万七丈业丝且下丞与.Item[612671488];
        if(val_3.dontFollow != true)
        {
                PlayerTaskImposterMode val_4 = this.丝且与丝丒丟万丁专.万七丈业丝且下丞与.Item[612671488];
            丁东世丌丑且丞丕世(丙丑上且且丝三丛不:  val_4.taskDescription);
            typeof(InGameGUIPart_Imposter).__il2cppRuntimeField_28.丛丘丗丆丌丏不丑专(万不且且丛丆东丒业:  this.丝且与丝丒丟万丁专.万七丈业丝且下丞与.Item[612671488].gameObject, 丁丅丈丌丟世丗丗丟:  20);
            PlayerTaskImposterMode val_7 = this.丝且与丝丒丟万丁专.万七丈业丝且下丞与.Item[612671488];
            if(val_7.丕丞丌万丞丄丘且丘 != false)
        {
                三丅丄不丂丝丕丐与(三专三丐丁世丑丁丅:  1);
        }
        
        }
        
        val_9 = 2;
        label_23:
        if((val_9 - 1) < this.丝且与丝丒丟万丁专.万七丈业丝且下丞与.Count)
        {
            goto label_45;
        }
        
        label_2:
        val_10 = 0;
        return (bool)val_10;
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
