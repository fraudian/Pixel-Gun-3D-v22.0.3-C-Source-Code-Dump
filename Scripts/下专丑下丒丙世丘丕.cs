using UnityEngine;
private sealed class Player_move_c.下专丑下丒丙世丘丕 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private string 丘丘丘专业丁丙丘丁;
    public string 丕七丙丞万丕丄专丏;
    public Player_move_c 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.下专丑下丒丙世丘丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_51;
        int val_52;
        var val_53;
        string val_54;
        System.Object[] val_55;
        string val_56;
        UnityEngine.GameObject val_57;
        var val_58;
        val_51 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_2 = UnityEngine.Resources.LoadAsync(path:  "Gliders/"("Gliders/") + this.丘丘丘专业丁丙丘丁);
        this.丅丒丑丄丞丑下丈丕 = val_2;
        this.丒上七丌业七丟与丐 = val_2;
        val_52 = 1;
        this.丗丏丅丕丆世丁专丟 = val_52;
        return (bool)val_52;
        label_2:
        val_53 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_26;
        }
        
        }
        
        object[] val_6 = new object[2];
        val_51 = val_6;
        val_51[0] = this.丘丘丘专业丁丙丘丁;
        val_54 = "Hang_glider";
        val_51[1] = "Hang_glider";
        UnityEngine.Debug.LogWarningFormat(format:  "Replacing glider: \'{0}\' by \'{1}\'", args:  val_6);
        this.丘丘丘专业丁丙丘丁 = "Hang_glider";
        UnityEngine.ResourceRequest val_8 = UnityEngine.Resources.LoadAsync(path:  "Gliders/"("Gliders/") + "Hang_glider");
        this.丅丒丑丄丞丑下丈丕 = val_8;
        this.丒上七丌业七丟与丐 = val_8;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_52 = 1;
        return (bool)val_52;
        label_1:
        val_53 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_26;
        }
        
        }
        
        val_54 = this.丘丘丘专业丁丙丘丁;
        val_55 = new object[1];
        val_55[0] = val_54;
        val_56 = "Can\'t load glider: {0}!";
        goto label_33;
        label_3:
        val_52 = 0;
        return (bool)val_52;
        label_26:
        if(this.丅丒丑丄丞丑下丈丕.asset != null)
        {
                if(null == null)
        {
            goto label_37;
        }
        
        }
        
        object[] val_14 = new object[1];
        val_54 = this.丘丘丘专业丁丙丘丁;
        val_55 = val_14;
        val_55[0] = val_54;
        val_56 = "Wrong glider asset {0}! Must be a GameObject!";
        label_33:
        UnityEngine.Debug.LogErrorFormat(format:  val_56, args:  val_14);
        if(val_51 != null)
        {
            goto label_126;
        }
        
        label_127:
        label_126:
        val_52 = 0;
        this.丝且与丝丒丟万丁专.丌东东丕丗丗一三丞 = 0;
        return (bool)val_52;
        label_37:
        val_57 = this.丅丒丑丄丞丑下丈丕.asset;
        if((val_57 != null) && (null != null))
        {
                val_57 = 0;
        }
        
        UnityEngine.GameObject val_17 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_57);
        GliderSettings val_18 = val_17.GetComponent<GliderSettings>();
        if(val_51 != null)
        {
                val_51.世丈七且丛三丕丈丕(丙业与丙丗丝不丈东:  val_18);
        }
        else
        {
                0.世丈七且丛三丕丈丕(丙业与丙丗丝不丈东:  val_18);
        }
        
        if(val_51.丒丘不丞丗丞丌不丏() != 0)
        {
            goto label_53;
        }
        
        object[] val_21 = new object[1];
        val_21[0] = this.丘丘丘专业丁丙丘丁;
        UnityEngine.Debug.LogErrorFormat(format:  "Wrong glider asset {0}! Must have GliderSettings component", args:  val_21);
        UnityEngine.Object.Destroy(obj:  val_17);
        if(val_51 != null)
        {
            goto label_126;
        }
        
        goto label_127;
        label_53:
        if(val_51 != null)
        {
                val_58 = val_51.丒丘不丞丗丞丌不丏();
        }
        else
        {
                val_58 = 0.丒丘不丞丗丞丌不丏();
        }
        
        GliderSettings val_24 = val_51.丒丘不丞丗丞丌不丏();
        val_23.上七丑丗世丛万不丑 = val_51.丁东世且不丏三丞丁(上七一一丆丐三丆丙:  val_24.gliderType);
        GliderSettings val_26 = val_51.丒丘不丞丗丞丌不丏();
        if(val_26.上七丑丗世丛万不丑 == null)
        {
            goto label_71;
        }
        
        GliderSettings val_29 = val_51.丒丘不丞丗丞丌不丏();
        val_51.丒丘不丞丗丞丌不丏().transform.parent = val_29.上七丑丗世丛万不丑.rootTransformPoint;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
        val_51.丒丘不丞丗丞丌不丏().transform.localPosition = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
        UnityEngine.Quaternion val_35 = UnityEngine.Quaternion.identity;
        val_51.丒丘不丞丗丞丌不丏().transform.localRotation = new UnityEngine.Quaternion() {x = val_35.x, y = val_35.y, z = val_35.z, w = val_35.w};
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
        val_51.丒丘不丞丗丞丌不丏().transform.localScale = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
        GliderSettings val_39 = val_51.丒丘不丞丗丞丌不丏();
        if(val_39.上七丑丗世丛万不丑.gliderAnimator != 0)
        {
                GliderSettings val_41 = val_51.丒丘不丞丗丞丌不丏();
            this.丝且与丝丒丟万丁专.mySkinName.playerAnimation.animator.runtimeAnimatorController = val_41.上七丑丗世丛万不丑.gliderAnimator;
        }
        
        val_51.丒丘不丞丗丞丌不丏().gameObject.SetActive(value:  (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丛丗丑丝丕丌七与丆 == true) ? 1 : 0);
        if(val_51.世丈丝丞专且七七下() == false)
        {
            goto label_126;
        }
        
        val_51.TrySetLandingTrails();
        goto label_126;
        label_71:
        object[] val_46 = new object[1];
        GliderSettings val_47 = val_51.丒丘不丞丗丞丌不丏();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        val_46[0] = val_47.gliderType.ToString();
        UnityEngine.Debug.LogErrorFormat(format:  "Can\'t find settings for GliderType \"{0}\"", args:  val_46);
        UnityEngine.Object.Destroy(obj:  val_51.丒丘不丞丗丞丌不丏().gameObject);
        UnityEngine.Debug.LogError(message:  "Remove glider 1");
        if(val_51 == null)
        {
            goto label_125;
        }
        
        val_51.世丈七且丛三丕丈丕(丙业与丙丗丝不丈东:  0);
        goto label_126;
        label_125:
        0.世丈七且丛三丕丈丕(丙业与丙丗丝不丈东:  0);
        goto label_127;
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
                Player_move_c.下专丑下丒丙世丘丕 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.下专丑下丒丙世丘丕();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丘丘丘专业丁丙丘丁 = this.丕七丙丞万丕丄专丏;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
