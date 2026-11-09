using UnityEngine;
private sealed class ControllerChangePhotonOwnerAndActivateBotMesh.丑丞下丅丞三三丄丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ControllerChangePhotonOwnerAndActivateBotMesh 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ControllerChangePhotonOwnerAndActivateBotMesh.丑丞下丅丞三三丄丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_23;
        var val_40;
        ControllerChangePhotonOwnerAndActivateBotMesh val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        UnityEngine.Object val_48;
        var val_49;
        int val_50;
        ControllerChangePhotonOwnerAndActivateBotMesh val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_56;
        var val_57;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_41 = this.丝且与丝丒丟万丁专;
        val_42 = null;
        val_42 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_8;
        }
        
        System.Collections.Generic.HashSet<RilisoftBot.BotAiController> val_3 = new System.Collections.Generic.HashSet<RilisoftBot.BotAiController>();
        System.Collections.Generic.HashSet<RilisoftBot.BotAiController> val_4 = new System.Collections.Generic.HashSet<RilisoftBot.BotAiController>();
        val_43 = null;
        val_43 = null;
        List.Enumerator<T> val_5 = ControllerChangePhotonOwnerAndActivateBotMesh.__il2cppRuntimeField_this_arg.GetEnumerator();
        val_44 = 0;
        val_45 = 0;
        var val_39 = 0;
        label_67:
        if((1051161968 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        val_46 = null;
        val_46 = null;
        List.Enumerator<T> val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_45:
        if((1051161936 & 1) == 0)
        {
            goto label_18;
        }
        
        if(val_8 == 0)
        {
            goto label_45;
        }
        
        UnityEngine.Transform val_12 = val_8.transform;
        UnityEngine.Vector3 val_13 = val_12.position;
        UnityEngine.Vector3 val_15 = val_12.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z})) >= 0)
        {
            goto label_45;
        }
        
        bool val_17 = val_3.Add(item:  val_8);
        val_47 = null;
        val_47 = null;
        val_48 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_48 == 0)
        {
            goto label_45;
        }
        
        if((((val_18 + 295) & 2) != 0) && ((val_18 + 216) == 0))
        {
                val_48 = null;
        }
        
        if(val_7.丐丏七丌丕丗业且上() != WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
            goto label_45;
        }
        
        val_8.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  true);
        bool val_20 = val_4.Add(item:  val_8);
        goto label_45;
        label_18:
        val_39 = val_39 + 1;
        val_49 = val_45;
        mem2[0] = 293;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_39 == 1) || ((1051161792 + ((0 + 1)) << 2) != 293))
        {
            goto label_64;
        }
        
        var val_40 = 0;
        val_40 = val_40 ^ (val_39 >> 31);
        val_39 = val_39 + val_40;
        goto label_67;
        label_64:
        if( == 0)
        {
            goto label_67;
        }
        
        goto label_67;
        label_2:
        val_50 = 0;
        return (bool)val_50;
        label_14:
        val_51 = val_41;
        val_52 = val_39 + 1;
        mem2[0] = 321;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_39 == 1) || ((1051161792 + ((0 + 1)) << 2) != 321))
        {
            goto label_75;
        }
        
        var val_41 = 0;
        val_41 = val_41 ^ (val_39 >> 31);
        val_52 = val_39 + val_41;
        if(val_3 != null)
        {
            goto label_79;
        }
        
        goto label_77;
        label_75:
        if( != 0)
        {
                val_45 = 0;
        }
        
        if(val_3 != null)
        {
            goto label_79;
        }
        
        label_77:
        label_79:
        HashSet.Enumerator<T> val_21 = val_3.GetEnumerator();
        label_97:
        if((1051161904 & 1) == 0)
        {
            goto label_80;
        }
        
        string val_24 = val_23.丐丏七丌丕丗业且上();
        if(val_24 == 0)
        {
            goto label_97;
        }
        
        val_24.丁业下丞万且丒丂下(世丁万下丗专世万丅:  true);
        val_53 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  null)) != true)
        {
                if(val_24.七与世丄丞丒一七三() == 0)
        {
            goto label_97;
        }
        
        }
        
        val_24.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  true);
        goto label_97;
        label_80:
        val_54 = val_39 + 1;
        mem2[0] = 425;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_54 == 1) || ((1051161792 + (((0 + 1) + 1)) << 2) != 425))
        {
            goto label_108;
        }
        
        var val_42 = 0;
        val_42 = val_42 ^ (val_54 >> 31);
        val_54 = val_54 + val_42;
        if( != 0)
        {
            goto label_112;
        }
        
        goto label_110;
        label_108:
        if( != 0)
        {
                val_45 = 0;
        }
        
        if( != 0)
        {
            goto label_112;
        }
        
        label_110:
        label_112:
        HashSet.Enumerator<T> val_30 = this.丝且与丝丒丟万丁专 + 80.GetEnumerator();
        label_121:
        if((1051161904 & 1) == 0)
        {
            goto label_114;
        }
        
        string val_31 = val_23.丐丏七丌丕丗业且上();
        if((val_3.Contains(item:  val_31)) == true)
        {
            goto label_121;
        }
        
        val_31.丁业下丞万且丒丂下(世丁万下丗专世万丅:  false);
        if((val_4.Contains(item:  val_31)) == true)
        {
            goto label_121;
        }
        
        val_31.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  false);
        goto label_121;
        label_114:
        val_40 = val_54 + 1;
        mem2[0] = 510;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_40 != 1) && ((1051161792 + ((((0 + 1) + 1) + 1)) << 2) == 510))
        {
                var val_43 = 0;
            val_43 = val_43 ^ (val_40 >> 31);
            val_40 = val_40 + val_43;
        }
        else
        {
                if( != 0)
        {
                val_45 = 0;
        }
        
        }
        
        val_56 = null;
        val_56 = null;
        val_41 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_41 == 0)
        {
            goto label_142;
        }
        
        val_57 = null;
        val_57 = null;
        val_41 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_41 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_41 == 0)
        {
            goto label_142;
        }
        
        val_41 = mem[this.丝且与丝丒丟万丁专 + 88];
        val_41 = this.丝且与丝丒丟万丁专 + 88;
        HashSet.Enumerator<T> val_36 = val_41.GetEnumerator();
        label_149:
        if((1051161904 & 1) == 0)
        {
            goto label_145;
        }
        
        string val_37 = val_23.丐丏七丌丕丗业且上();
        if((val_4.Contains(item:  val_37)) == true)
        {
            goto label_149;
        }
        
        val_37.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  false);
        goto label_149;
        label_145:
        val_40 = val_40 + 1;
        mem2[0] = 608;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_40 == 1)
        {
            goto label_154;
        }
        
        if(( == 0) || ((1051161792 + (((((0 + 1) + 1) + 1) + 1)) << 2) == 608))
        {
            goto label_160;
        }
        
        label_159:
        label_160:
        mem2[0] = val_4;
        label_142:
        mem2[0] = val_3;
        label_8:
        val_50 = 1;
        this.丗丏丅丕丆世丁专丟 = val_50;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_50;
        label_154:
        if( != 0)
        {
            goto label_159;
        }
        
        goto label_160;
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
