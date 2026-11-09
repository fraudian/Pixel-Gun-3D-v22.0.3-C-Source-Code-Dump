using UnityEngine;
private sealed class FirstPersonControlSharp.丙三丙世丁上下丝上 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public FirstPersonControlSharp 丝且与丝丒丟万丁专;
    private FirstPersonControlSharp.万丙专丟丆专东丟丕 丆丝下丒上一丙丄丞;
    public FirstPersonControlSharp.万丙专丟丆专东丟丕 万且丅七丏且丑丞丒;
    private bool 丒丄丒丗万下丒东丐;
    private UnityEngine.Vector3 七丆丑丂三一七丌东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FirstPersonControlSharp.丙三丙世丁上下丝上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FirstPersonControlSharp val_44;
        float val_45;
        float val_46;
        UnityEngine.Vector3 val_50;
        BaseCamera val_51;
        万丙专丟丆专东丟丕 val_52;
        BaseCamera val_53;
        int val_54;
        float val_55;
        float val_56;
        UnityEngine.GameObject val_57;
        UnityEngine.GameObject val_58;
        FirstPersonCamera val_59;
        ThirdPersonCamera val_60;
        var val_61;
        val_44 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        万丙专丟丆专东丟丕 val_1 = val_44.丗丗世三丛万丆丞丗();
        this.丒丄丒丗万下丒东丐 = (val_1 == 0) ? 1 : 0;
        if((val_1 == 0) || (this.丆丝下丒上一丙丄丞 != 1))
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.enabled = false;
        UnityEngine.Vector3 val_5 = this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.transform.position;
        val_45 = val_5.z;
        val_46 = val_5.x;
        UnityEngine.Vector3 val_6 = this.丝且与丝丒丟万丁专.firstPersonCamera.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_46, y = val_5.y, z = val_45});
        this.七丆丑丂三一七丌东 = val_6;
        mem[1152921540429713744] = val_6.y;
        mem[1152921540429713748] = val_6.z;
        goto label_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_12:
        val_50 = this.七丆丑丂三一七丌东;
        if(S0 > 1f)
        {
            goto label_13;
        }
        
        z = 0f;
        mem2[0] = 0;
        label_5:
        if(val_44 == null)
        {
            goto label_14;
        }
        
        val_44.丒丂丟下丝万不丞不(丙业与丙丗丝不丈东:  this.丆丝下丒上一丙丄丞);
        val_51 = this.丝且与丝丒丟万丁专.playerCamera;
        val_52 = this.丆丝下丒上一丙丄丞;
        val_53 = this.丝且与丝丒丟万丁专.playerCamera;
        goto label_15;
        label_2:
        val_54 = 0;
        return (bool)val_54;
        label_13:
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_55 = val_9.y;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.七丆丑丂三一七丌东, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_55, z = val_9.z}, t:  UnityEngine.Time.deltaTime * 10f);
        UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.firstPersonCamera.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        val_52 = this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.transform;
        UnityEngine.Vector3 val_16 = val_52.position;
        val_45 = val_16.z;
        UnityEngine.Vector3 val_17 = this.丝且与丝丒丟万丁专.firstPersonCamera.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_45});
        this.七丆丑丂三一七丌东 = val_17;
        mem[1152921540429713744] = val_17.y;
        mem[1152921540429713748] = val_17.z;
        val_44 = this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄;
        val_56 = val_17.x;
        val_54 = 1;
        this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.lastDistance = val_56;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_54;
        return (bool)val_54;
        label_14:
        0.丒丂丟下丝万不丞不(丙业与丙丗丝不丈东:  this.丆丝下丒上一丙丄丞);
        val_53 = 400;
        val_51 = 1685382481;
        val_52 = this.丆丝下丒上一丙丄丞;
        label_15:
        if(val_52 != 1)
        {
            goto label_31;
        }
        
        if(this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟 != 0)
        {
            goto label_34;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_37;
        }
        
        val_44.丁东下丁三丏丈丁业(丝三丄专丗丞丄丄丌:  false);
        goto label_38;
        label_31:
        if(this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟 != 0)
        {
            goto label_41;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_44;
        }
        
        val_44.丁东下丁三丏丈丁业(丝三丄专丗丞丄丄丌:  true);
        goto label_45;
        label_34:
        val_57 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟.gameObject;
        if(val_57 != null)
        {
            goto label_55;
        }
        
        goto label_49;
        label_41:
        val_58 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟.gameObject;
        if(val_58 != null)
        {
            goto label_68;
        }
        
        goto label_53;
        label_37:
        val_57 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.FPSplayerObject;
        if(val_57 != null)
        {
            goto label_55;
        }
        
        label_49:
        label_55:
        val_57.SetActive(value:  false);
        label_38:
        this.丝且与丝丒丟万丁专.万丗丈丗三不丌不丆 = 0f;
        this.丝且与丝丒丟万丁专.下丝丝丈世丟丘丄专 = false;
        if(this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.playerMoveC.万丝一万丐且丌业丛 != true)
        {
                this.丝且与丝丒丟万丁专.firstPersonCamera.gameObject.SetActive(value:  true);
            if(this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄 != 0)
        {
                this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.gameObject.SetActive(value:  false);
        }
        
        }
        
        val_59 = this.丝且与丝丒丟万丁专.firstPersonCamera;
        goto label_66;
        label_44:
        val_58 = this.丝且与丝丒丟万丁专.丞丗丄丂丆业丈丑业.FPSplayerObject;
        if(val_58 != null)
        {
            goto label_68;
        }
        
        label_53:
        label_68:
        val_58.SetActive(value:  true);
        label_45:
        this.丝且与丝丒丟万丁专.firstPersonCamera.gameObject.SetActive(value:  false);
        if(this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄 != 0)
        {
            goto label_73;
        }
        
        UnityEngine.Vector3 val_30 = val_44.丟不丂丕业与七专三().position;
        val_45 = val_30.z;
        val_52 = val_44.丟不丂丕业与七专三();
        UnityEngine.Quaternion val_32 = val_52.rotation;
        val_55 = val_32.y;
        val_46 = val_30.x;
        val_60 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.thirdCameraPrefab, position:  new UnityEngine.Vector3() {x = val_46, y = val_30.y, z = val_45}, rotation:  new UnityEngine.Quaternion() {x = val_32.x, y = val_55, z = val_32.z, w = val_32.w}).GetComponent<ThirdPersonCamera>();
        this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄 = val_60;
        if(val_60 != null)
        {
            goto label_81;
        }
        
        goto label_80;
        label_73:
        val_60 = this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄;
        if(val_60 != null)
        {
            goto label_81;
        }
        
        label_80:
        label_81:
        val_60.gameObject.SetActive(value:  true);
        this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄.enabled = true;
        val_59 = this.丝且与丝丒丟万丁专.且丛丈丂丒丟丘丅丄;
        label_66:
        mem[400] = val_59;
        val_59.丝不三万世丛世七丗(丙业与丙丗丝不丈东:  val_44);
        val_44.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  mem[27455186369]);
        if(this.丒丄丒丗万下丒东丐 != true)
        {
                if(mem[400] != val_51)
        {
                UnityEngine.Vector3 val_38 = val_51.transform.eulerAngles;
            float val_44 = -360f;
            val_44 = val_38.x + val_44;
            mem2[0] = (val_38.x > 180f) ? (val_44) : val_38.x;
        }
        
        }
        
        val_50 = 1152921505207164928;
        val_61 = null;
        val_61 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = mem[400].camera;
        val_56 = Player_move_c.且丒丗丑万丐丗丅三();
        this.丝且与丝丒丟万丁专._moveC.世丛与丛丄丌世丝丏();
        val_54 = 0;
        this.丝且与丝丒丟万丁专.丅业上丙丗丂东与一 = 0;
        return (bool)val_54;
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
                FirstPersonControlSharp.丙三丙世丁上下丝上 val_2 = null;
            val_4 = val_2;
            val_2 = new FirstPersonControlSharp.丙三丙世丁上下丝上();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丆丝下丒上一丙丄丞 = this.万且丅七丏且丑丞丒;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
