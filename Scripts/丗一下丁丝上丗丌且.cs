using UnityEngine;
internal class 丗一下丁丝上丗丌且
{
    // Fields
    private System.Collections.Generic.Dictionary<object, object> 丕上丈一丕七丑三丝;
    private int 万丏丏丏丘丒丁丛丈;
    
    // Methods
    internal 丗一下丁丝上丗丌且()
    {
        this.万丏丏丏丘丒丁丛丈 = 0;
        this.丕上丈一丕七丑三丝 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
    }
    internal void 且七丙丄丘一丄上不()
    {
        this.万丏丏丏丘丒丁丛丈 = 0;
        this.丕上丈一丕七丑三丝.Clear();
    }
    internal void 东丛丈不丌下丐丁丄(System.Collections.Generic.Dictionary<object, object> 丟丒业世三与丝丞业, int 丌世世且丟万丗万东)
    {
        if(this.万丏丏丏丘丒丁丛丈 >= 丌世世且丟万丗万东)
        {
                return;
        }
        
        this.东丛丈不丌下丐丁丄(丟丒业世三与丝丞业:  丟丒业世三与丝丞业);
    }
    internal System.Collections.Generic.Dictionary<object, object> 三七上丘与七一丏丐(System.Collections.Generic.Dictionary<object, object> 上丙丈上丅万专丞丈)
    {
        var val_5;
        var val_32;
        string val_33;
        int val_13 = 0;
        bool val_21 = false;
        int val_15 = 0;
        bool val_23 = false;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        Dictionary.Enumerator<TKey, TValue> val_2 = 上丙丈上丅万专丞丈.GetEnumerator();
        label_43:
        if(((-542578208) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if((this.丕上丈一丕七丑三丝.ContainsKey(key:  val_6._value._obj.丐丏七丌丕丗业且上())) == false)
        {
            goto label_4;
        }
        
        if(this.丕上丈一丕七丑三丝.Item[val_6._value._obj.丐丏七丌丕丗业且上()] != null)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  this.丕上丈一丕七丑三丝.Item[val_6._value._obj.丐丏七丌丕丗业且上()], 丙业与丙丗丝不丈东: out  val_13)) == false)
        {
            goto label_12;
        }
        
        if(((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj, 丙业与丙丗丝不丈东: out  val_15)) == false) || (val_15 == val_13))
        {
            goto label_43;
        }
        
        val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
        goto label_43;
        label_4:
        val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
        goto label_43;
        label_12:
        if((丞东丑专丛丆丄丝世.上丅丏丐丄丙且不七(丞丕丒专一下丙业上:  this.丕上丈一丕七丑三丝.Item[val_6._value._obj.丐丏七丌丕丗业且上()], 丙业与丙丗丝不丈东: out  val_21)) == false)
        {
            goto label_43;
        }
        
        if(((丞东丑专丛丆丄丝世.上丅丏丐丄丙且不七(丞丕丒专一下丙业上:  val_6._value._obj, 丙业与丙丗丝不丈东: out  val_23)) == false) || (val_23 == val_21))
        {
            goto label_43;
        }
        
        val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
        goto label_43;
        label_7:
        object val_27 = this.丕上丈一丕七丑三丝.Item[val_6._value._obj.丐丏七丌丕丗业且上()];
        if(val_27 != null)
        {
                if(null == null)
        {
            goto label_36;
        }
        
        }
        
        if(val_27 == null)
        {
            goto label_37;
        }
        
        label_36:
        var val_28 = (null == null) ? (val_27) : 0;
        if(val_6._value._obj == 0)
        {
            goto label_38;
        }
        
        label_40:
        var val_29 = (val_6._value._obj == null) ? () : 0;
        goto label_39;
        label_37:
        val_32 = 0;
        if(val_6._value._obj != 0)
        {
            goto label_40;
        }
        
        label_38:
        val_33 = 0;
        label_39:
        if((val_32.Equals(value:  val_33)) == true)
        {
            goto label_43;
        }
        
        val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
        goto label_43;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 东丛丈不丌下丐丁丄(System.Collections.Generic.Dictionary<object, object> 丟丒业世三与丝丞业)
    {
        var val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = 丟丒业世三与丝丞业.GetEnumerator();
        label_4:
        if(((-542372000) & 1) == 0)
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
