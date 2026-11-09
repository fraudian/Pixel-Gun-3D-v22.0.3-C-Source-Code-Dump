using UnityEngine;
internal sealed class 业丌下丛丟万专丌丏
{
    // Fields
    private System.Collections.Generic.Dictionary<int, int> 七三丗世世三丏三与;
    private static 业丌下丛丟万专丌丏 丝业丆丁业三丈丟东;
    
    // Properties
    internal static 业丌下丛丟万专丌丏 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static 业丌下丛丟万专丌丏 丑七不且上丗丁一世()
    {
        业丌下丛丟万专丌丏 val_2;
        业丌下丛丟万专丌丏 val_3 = 业丌下丛丟万专丌丏.丝业丆丁业三丈丟东;
        if(val_3 != null)
        {
                return val_3;
        }
        
        业丌下丛丟万专丌丏 val_1 = null;
        val_2 = val_1;
        val_1 = new 业丌下丛丟万专丌丏();
        业丌下丛丟万专丌丏.丝业丆丁业三丈丟东 = val_2;
        val_3 = 业丌下丛丟万专丌丏.丝业丆丁业三丈丟东;
        return val_3;
    }
    private 业丌下丛丟万专丌丏()
    {
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 业丌下丛丟万专丌丏::世丂丄丙七丂东丗与()));
    }
    internal int 丅专丕丁丟丏下丄丅(一一万丒与专丙丁丛 丅丅下丟丑专下与一)
    {
        var val_6;
        int val_3 = 0;
        if((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true) || (AuthSceneController.一不丆丏与丐丏丈丄() == false))
        {
            goto label_4;
        }
        
        this.下丕丆一丒丙丄丑丁();
        if((this.七三丗世世三丏三与.TryGetValue(key:  丅丅下丟丑专下与一, value: out  val_3)) == false)
        {
            goto label_6;
        }
        
        val_6 = val_3;
        return (int)val_6;
        label_4:
        val_6 = 1;
        return (int)val_6;
        label_6:
        int val_5 = ExperienceController.丞丞丘业东丙丏七丌();
        return (int)val_6;
    }
    private void 世丂丄丙七丂东丗与()
    {
        object val_8;
        object val_18;
        string val_19;
        System.Object[] val_20;
        var val_21;
        var val_22;
        val_18 = this;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_3;
        }
        
        val_18 = System.Array.Empty<System.Object>();
        val_19 = "updated clan data while in offline , division reach level manager";
        val_20 = val_18;
        goto label_6;
        label_3:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        this.下丕丆一丒丙丄丑丁();
        Dictionary.Enumerator<TKey, TValue> val_7 = this.七三丗世世三丏三与.GetEnumerator();
        label_13:
        label_12:
        if((2058300144 & 1) == 0)
        {
            goto label_11;
        }
        
        string val_10 = val_8.丐丏七丌丕丗业且上();
        if(val_10.丙东专丂世丈丏丁丂() <= 0)
        {
            goto label_12;
        }
        
        int val_12 = val_10.丙东专丂世丈丏丁丂();
        goto label_13;
        label_11:
        val_21 = 0;
        val_22 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_21;
        }
        
        if( == 0)
        {
            goto label_25;
        }
        
        if(121 != 121)
        {
            goto label_23;
        }
        
        goto label_25;
        label_21:
        if( == 0)
        {
            goto label_25;
        }
        
        label_23:
        label_25:
        int val_13 = 0 + 1;
        label_30:
        if(val_13 > (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛()))
        {
            goto label_26;
        }
        
        var val_15 = val_13 + 1;
        this.七三丗世世三丏三与.set_Item(key:  val_13, value:  ExperienceController.丞丞丘业东丙丏七丌());
        goto label_30;
        label_26:
        if((0 & 1) == 0)
        {
                return;
        }
        
        val_18 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.七三丗世世三丏三与);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  107, 丙业与丙丗丝不丈东:  val_18);
        return;
        label_6:
        UnityEngine.Debug.LogErrorFormat(format:  null, args:  null);
    }
    private void 下丕丆一丒丙丄丑丁()
    {
        string val_9;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_10;
        var val_11;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_13;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_15;
        if(this.七三丗世世三丏三与 != null)
        {
                return;
        }
        
        object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  107);
        if(val_2 != null)
        {
                string val_3 = System.Convert.ToString(value:  val_2);
        }
        else
        {
                val_9 = "{}";
        }
        
        val_10 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_9);
        val_10 = null;
        val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_11 = null;
        val_11 = null;
        val_13 = 业丌下丛丟万专丌丏.<>c.<>9__5_0;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  业丌下丛丟万专丌丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 业丌下丛丟万专丌丏.<>c::丞丙丟丟丘丏东世丅(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            val_11 = null;
            业丌下丛丟万专丌丏.<>c.<>9__5_0 = val_13;
        }
        
        val_11 = null;
        val_15 = 业丌下丛丟万专丌丏.<>c.<>9__5_1;
        if(val_15 == null)
        {
                val_15 = null;
            val_15 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  业丌下丛丟万专丌丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 业丌下丛丟万专丌丏.<>c::丁丝且三丂丟丘且丛(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            业丌下丛丟万专丌丏.<>c.<>9__5_1 = val_15;
        }
        
        this.七三丗世世三丏三与 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32, System.Int32>(source:  null, keySelector:  null, elementSelector:  null);
    }

}
