using UnityEngine;
private sealed class PlayerLikeController.丕丕东专丘丆丄丝不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerLikeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerLikeController.丕丕东专丘丆丄丝不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_7;
        string val_24;
        var val_25;
        var val_26;
        var val_27;
        object val_28;
        int val_29;
        var val_30;
        var val_31;
        var val_32;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_55;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_24 = 1152921505065418752;
        if(FriendsController.丝丗专上三不丄丑丑() == 1)
        {
            goto label_8;
        }
        
        this.丝且与丝丒丟万丁专.丂丏丐丅丁业丘且不.Clear();
        Dictionary.Enumerator<TKey, TValue> val_4 = this.丝且与丝丒丟万丁专.LikeStory.GetEnumerator();
        val_25 = 1152921538705724160;
        goto label_21;
        label_27:
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        if(val_6 == 1)
        {
            goto label_14;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < val_6)
        {
            goto label_21;
        }
        
        this.丝且与丝丒丟万丁专.丂丏丐丅丁业丘且不.Add(item:  val_8._value._obj.丐丏七丌丕丗业且上());
        goto label_21;
        label_14:
        val_26 = null;
        val_26 = null;
        long val_12 = FriendsController.丝丗专上三不丄丑丑() + PlayerLikeController.丌上业下丁丁丝七丏;
        label_21:
        if(((-259766496) & 1) != 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_44;
        }
        
        goto label_29;
        label_3:
        val_27 = 0;
        return (bool)val_27;
        label_8:
        val_28 = 0;
        val_29 = 3;
        goto label_60;
        label_29:
        label_44:
        val_30 = 1;
        if(val_30.Count < 1)
        {
            goto label_55;
        }
        
        val_25 = 1152921516223708000;
        val_31 = 0;
        goto label_47;
        label_51:
        val_24 = 1.Item[0];
        bool val_16 = val_28.LikeStory.Remove(key:  val_24);
        val_31 = 1;
        label_47:
        if(val_31 < 1.Count)
        {
            goto label_51;
        }
        
        val_30 = 0;
        val_30.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_28.LikeStory));
        if(val_28 != 0)
        {
            goto label_55;
        }
        
        label_5:
        label_55:
        if(val_28.LikeStory.Count >= 1)
        {
                val_32 = null;
            val_32 = null;
            UnityEngine.WaitForSeconds val_22 = null;
            val_28 = val_22;
            val_22 = new UnityEngine.WaitForSeconds(seconds:  (float)PlayerLikeController.丛丟丙三丆不与丘丒);
            val_29 = 2;
        }
        else
        {
                val_28 = 0;
            val_29 = 1;
        }
        
        label_60:
        val_27 = 1;
        this.丒上七丌业七丟与丐 = val_28;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_27;
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
