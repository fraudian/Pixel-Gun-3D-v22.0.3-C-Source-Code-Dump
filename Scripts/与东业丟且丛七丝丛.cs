using UnityEngine;
internal sealed class 与东业丟且丛七丝丛
{
    // Fields
    private System.Collections.Generic.Dictionary<string, object> 上世丏丁世丟世丆业;
    
    // Methods
    internal 与东业丟且丛七丝丛(string 丄丁丛丌丂丑丆丏丕)
    {
        var val_4;
        this.上世丏丁世丟世丆业 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丄丁丛丌丂丑丆丏丕);
        val_4 = 0;
        this.上世丏丁世丟世丆业 = ;
    }
    internal void 丟丟与丒丒与丞七丈(System.Collections.Generic.List<ShareButtonMailbox> 丙丗丘丗丗丏业丝丟)
    {
        string val_9;
        var val_10;
        var val_11;
        var val_12;
        val_10 = 丙丗丘丗丗丏业丝丟;
        if(this.上世丏丁世丟世丆业 == null)
        {
                return;
        }
        
        val_9 = "share_buttons";
        if((this.上世丏丁世丟世丆业.ContainsKey(key:  "share_buttons")) == false)
        {
            goto label_22;
        }
        
        object val_2 = this.上世丏丁世丟世丆业.Item["share_buttons"];
        val_11 = 0;
        val_9 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
        if((ContainsKey(key:  val_9)) == false)
        {
            goto label_22;
        }
        
        object val_5 = Item[val_9];
        if(val_5 != null)
        {
                val_12 = null;
            val_12 = null;
            var val_6 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_12) ? (val_5) : 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = 0.GetEnumerator();
        val_9 = 1152921516595684768;
        label_18:
        if(((-687378504) & 1) == 0)
        {
            goto label_17;
        }
        
        ConfiguredValueTaskAwaiter val_8 = 0.GetAwaiter();
        val_8._value._obj.丗业上万上丏丗丘东(丟丒丞丐丐丘丒丄东:  new System.Collections.Generic.KeyValuePair<System.String, System.Object>() {Value = val_8._value._obj}, 丙丗丘丗丗丏业丝丟:  val_8._value._token);
        goto label_18;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_22:
        this.丙丐丅且丗七丈丕业();
    }
    private void 丙丐丅且丗七丈丕业()
    {
        var val_3;
        System.Collections.Generic.List<ShareButtonMailbox> val_4;
        val_3 = null;
        val_3 = null;
        val_4 = mem[PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟 + 232];
        val_4 = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.ShareButtons;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_8:
        if(((-687233704) & 1) == 0)
        {
            goto label_5;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_8;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丗业上万上丏丗丘东(System.Collections.Generic.KeyValuePair<string, object> 丟丒丞丐丐丘丒丄东, System.Collections.Generic.List<ShareButtonMailbox> 丙丗丘丗丗丏业丝丟)
    {
        var val_8;
        string val_9;
        val_8 = X3;
        专一东丂不丌不丛丏 val_2 = 0;
        if((System.Enum.TryParse<专一东丂不丌不丛丏>(value:  丟丒丞丐丐丘丒丄东.Value.丐丏七丌丕丗业且上(), result: out  val_2)) == false)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = val_8.GetEnumerator();
        label_13:
        if(((-687100248) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        if(val_5.丙丗丕丒下专专上丑() != val_2)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        if(丟丒丞丐丐丘丒丄东.Value != 0)
        {
                var val_7 = (丟丒丞丐丐丘丒丄东.Value == null) ? () : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        val_5.丅丐丈丗丂丘丁丂丁(七丙不丅丛丘丗万与:  val_9);
        goto label_13;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}
