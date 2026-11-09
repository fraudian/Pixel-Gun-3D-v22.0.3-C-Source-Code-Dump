using UnityEngine;
internal class 丆丁丛世丏丂上丙丐
{
    // Fields
    private System.Collections.Generic.Dictionary<object, object> 丕上丈一丕七丑三丝;
    private int 万丏丏丏丘丒丁丛丈;
    
    // Methods
    internal 丆丁丛世丏丂上丙丐()
    {
        this.万丏丏丏丘丒丁丛丈 = 0;
        this.丕上丈一丕七丑三丝 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
    }
    internal void 东丛丈不丌下丐丁丄(System.Collections.Generic.Dictionary<object, object> 丟丒业世三与丝丞业, int 丌世世且丟万丗万东)
    {
        if(this.万丏丏丏丘丒丁丛丈 >= 丌世世且丟万丗万东)
        {
                return;
        }
        
        this.东丛丈不丌下丐丁丄(丟丒业世三与丝丞业:  丟丒业世三与丝丞业);
    }
    internal System.Collections.Generic.Dictionary<object, object> 三七上丘与七一丏丐()
    {
        var val_6;
        var val_28;
        string val_29;
        int val_17 = 0;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        Dictionary.Enumerator<TKey, TValue> val_4 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().七丞丘万七专丒丁丝().GetEnumerator();
        label_34:
        if(((-456523008) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_8 = val_6.GetAwaiter();
        if((this.丕上丈一丕七丑三丝.ContainsKey(key:  val_8._value._obj.丐丏七丌丕丗业且上())) == false)
        {
            goto label_5;
        }
        
        if(this.丕上丈一丕七丑三丝.Item[val_8._value._obj.丐丏七丌丕丗业且上()] == null)
        {
            goto label_34;
        }
        
        if(this.丕上丈一丕七丑三丝.Item[val_8._value._obj.丐丏七丌丕丗业且上()] != null)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  this.丕上丈一丕七丑三丝.Item[val_8._value._obj.丐丏七丌丕丗业且上()], 丙业与丙丗丝不丈东: out  val_17)) == false)
        {
            goto label_34;
        }
        
        if(((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8._value._obj, 丙业与丙丗丝不丈东: out  val_17)) == false) || (0 == 0))
        {
            goto label_34;
        }
        
        val_3.set_Item(key:  val_8._value._obj.丐丏七丌丕丗业且上(), value:  val_8._value._obj);
        goto label_34;
        label_5:
        val_3.set_Item(key:  val_8._value._obj.丐丏七丌丕丗业且上(), value:  val_8._value._obj);
        goto label_34;
        label_10:
        object val_23 = this.丕上丈一丕七丑三丝.Item[val_8._value._obj.丐丏七丌丕丗业且上()];
        if(val_23 != null)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        if(val_23 == null)
        {
            goto label_28;
        }
        
        label_27:
        var val_24 = (null == null) ? (val_23) : 0;
        if(val_8._value._obj == 0)
        {
            goto label_29;
        }
        
        label_31:
        var val_25 = (val_8._value._obj == null) ? () : 0;
        goto label_30;
        label_28:
        val_28 = 0;
        if(val_8._value._obj != 0)
        {
            goto label_31;
        }
        
        label_29:
        val_29 = 0;
        label_30:
        if((val_28.Equals(value:  val_29)) == true)
        {
            goto label_34;
        }
        
        val_3.set_Item(key:  val_8._value._obj.丐丏七丌丕丗业且上(), value:  val_8._value._obj);
        goto label_34;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        return val_3;
    }
    private void 东丛丈不丌下丐丁丄(System.Collections.Generic.Dictionary<object, object> 丟丒业世三与丝丞业)
    {
        var val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = 丟丒业世三与丝丞业.GetEnumerator();
        label_4:
        if(((-456316800) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        this.丕上丈一丕七丑三丝.set_Item(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  val_5._value._obj);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}
