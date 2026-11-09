using UnityEngine;
private sealed class Player_move_c.丞丄丑且业东丁丈万 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private bool 丑丒业丘丑东丕世丅;
    public bool 业七丟丁丏专七一世;
    private bool 丛下且丛万丈丝万丂;
    public bool 丄七丙三丁与丁丐丞;
    private bool 丅丂丝与不万丑业丑;
    private UnityEngine.Vector3 丒丟丌东丟丘世一丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丞丄丑且业东丁丈万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_9;
        int val_42;
        bool val_43;
        UnityEngine.Vector3 val_44;
        var val_45;
        var val_46;
        var val_47;
        Player_move_c.下丏与丈丟丝七万一 val_48;
        var val_49;
        float val_50;
        float val_52;
        UnityEngine.Vector3 val_53;
        WeaponSounds val_54;
        var val_55;
        var val_56;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_42 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_42;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.gunCamera.fieldOfView = 75f;
        val_43 = this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆;
        if(val_43 == false)
        {
            goto label_10;
        }
        
        if(this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕() == 0)
        {
            goto label_8;
        }
        
        WeaponSounds val_3 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        val_43 = val_3.zoomXray;
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_59;
        }
        
        goto label_12;
        label_8:
        val_43 = false;
        label_10:
        this.丅丂丝与不万丑业丑 = val_43;
        if(this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType != 0)
        {
            goto label_21;
        }
        
        List.Enumerator<T> val_4 = this.丝且与丝丒丟万丁专.万万一丌丝丒丆丝专.GetEnumerator();
        goto label_17;
        label_18:
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_8 = val_7.RemoteEndpoint;
        if(val_9 == 12)
        {
                this.丅丂丝与不万丑业丑 = true;
        }
        
        label_17:
        if((1169092944 & 1) != 0)
        {
            goto label_18;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_21:
        if(this.丑丒业丘丑东丕世丅 != false)
        {
                val_44 = this.丝且与丝丒丟万丁专.sniperZoomWeaponPositionFPS;
            val_45 = this.丝且与丝丒丟万丁专 + 2604;
            val_46 = this.丝且与丝丒丟万丁专 + 2608;
        }
        else
        {
                val_47 = null;
            val_47 = null;
            val_44 = 1152921505111855504;
            val_45 = 1152921505111855508;
            val_46 = 1152921505111855512;
        }
        
        this.丒丟丌东丟丘世一丄 = val_44;
        mem[1152921535840723228] = mem[1152921505111855508];
        mem[1152921535840723232] = mem[1152921505111855512];
        if(this.丑丒业丘丑东丕世丅 == true)
        {
            goto label_27;
        }
        
        if(this.丅丂丝与不万丑业丑 == false)
        {
            goto label_28;
        }
        
        if(丘丐丘万丌丟丞下丝.丒三丘业七丟丑丅丒() != false)
        {
                if(this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType == 0)
        {
            goto label_34;
        }
        
        }
        
        val_48 = this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType;
        val_49 = 1;
        goto label_37;
        label_28:
        if(丘丐丘万丌丟丞下丝.丒三丘业七丟丑丅丒() == true)
        {
            goto label_40;
        }
        
        val_48 = this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType;
        val_49 = 0;
        label_37:
        this.丝且与丝丒丟万丁专.丑丑丐丄且丗下丈万(丐丝丄东丛丐不丒丅:  false, 丞丞丝丟丘东丆丕丙:  val_48);
        label_40:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_83;
        }
        
        label_84:
        label_83:
        this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform.localPosition = new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.sniperZoomWeaponPositionFPS, y = V9.16B, z = V10.16B};
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 != 0)
        {
                this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ResetScope();
        }
        
        BaseCamera val_14 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        val_52 = Player_move_c.且丒丗丑万丐丗丅三();
        this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.gunCamera.gameObject, 丏业丟一东丂东丘丛:  true);
        label_27:
        if(this.丛下且丛万丈丝万丂 == false)
        {
            goto label_58;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_59;
        }
        
        label_12:
        label_59:
        if(this.丝且与丝丒丟万丁专.sniperZoomMoveWeaponSpeedFPS <= 0f)
        {
            goto label_65;
        }
        
        UnityEngine.Vector3 val_18 = this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform.localPosition;
        val_53 = this.丒丟丌东丟丘世一丄;
        val_52 = val_18.x;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_52, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_53, y = V11.16B, z = V10.16B});
        if((double)val_19.x <= 0.001)
        {
            goto label_65;
        }
        
        val_54 = this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform;
        UnityEngine.Vector3 val_22 = this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform.localPosition;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, target:  new UnityEngine.Vector3() {x = this.丒丟丌东丟丘世一丄, y = V11.16B, z = val_53}, maxDistanceDelta:  this.丝且与丝丒丟万丁专.sniperZoomMoveWeaponSpeedFPS * UnityEngine.Time.deltaTime);
        val_52 = val_25.x;
        val_50 = val_25.z;
        val_54.localPosition = new UnityEngine.Vector3() {x = val_52, y = val_25.y, z = val_50};
        val_42 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_42;
        return (bool)val_42;
        label_58:
        val_52 = this.丒丟丌东丟丘世一丄;
        this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform.localPosition = new UnityEngine.Vector3() {x = val_52, y = V9.16B, z = V10.16B};
        label_65:
        val_54 = this.丝且与丝丒丟万丁专.丟上世丄与不丏且且;
        if(this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType != 0)
        {
            goto label_86;
        }
        
        List.Enumerator<T> val_27 = this.丝且与丝丒丟万丁专.万万一丌丝丒丆丝专.GetEnumerator();
        val_54 = 1152921535700378832;
        goto label_80;
        label_81:
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_28 = val_7.RemoteEndpoint;
        if(val_7 == 12)
        {
                this.丅丂丝与不万丑业丑 = true;
        }
        
        label_80:
        if((1169092944 & 1) != 0)
        {
            goto label_81;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_86;
        label_34:
        this.丝且与丝丒丟万丁专.丑丑丐丄且丗下丈万(丐丝丄东丛丐不丒丅:  true);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_83;
        }
        
        goto label_84;
        label_86:
        if(this.丑丒业丘丑东丕世丅 == false)
        {
            goto label_87;
        }
        
        if(this.丅丂丝与不万丑业丑 == false)
        {
            goto label_88;
        }
        
        if(丘丐丘万丌丟丞下丝.丒三丘业七丟丑丅丒() != false)
        {
                if(this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType == 0)
        {
            goto label_93;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丑丑丐丄且丗下丈万(丐丝丄东丛丐不丒丅:  true, 丞丞丝丟丘东丆丕丙:  this.丝且与丝丒丟万丁专.丟上世丄与不丏且且.xRayType);
        goto label_98;
        label_88:
        if(丘丐丘万丌丟丞下丝.丒三丘业七丟丑丅丒() == true)
        {
            goto label_98;
        }
        
        val_55 = 0;
        goto label_99;
        label_93:
        val_55 = 1;
        label_99:
        this.丝且与丝丒丟万丁专.丑丑丐丄且丗下丈万(丐丝丄东丛丐不丒丅:  true);
        label_98:
        val_56 = null;
        val_56 = null;
        this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒.transform.localPosition = new UnityEngine.Vector3() {x = Player_move_c.一与丆东丐丁七不东, y = Player_move_c.世且上一七下丈丕丑.__il2cppRuntimeField_194, z = Player_move_c.世且上一七下丈丕丑.__il2cppRuntimeField_198};
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 != 0)
        {
                WeaponSounds val_33 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
            this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.SetScopeForWeapon(丙丐一丕丗万丁下一:  val_33.scopeNum.ToString());
        }
        
        BaseCamera val_35 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        val_54 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        val_52 = val_54.ZoomFOV;
        this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.gunCamera.gameObject, 丏业丟一东丂东丘丛:  false);
        label_87:
        val_42 = 0;
        this.丝且与丝丒丟万丁专.一与丆东丂丏丟丁丏 = 0;
        return (bool)val_42;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丞丄丑且业东丁丈万 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丞丄丑且业东丁丈万();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丑丒业丘丑东丕世丅 = this.业七丟丁丏专七一世;
        .丛下且丛万丈丝万丂 = this.丄七丙三丁与丁丐丞;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
