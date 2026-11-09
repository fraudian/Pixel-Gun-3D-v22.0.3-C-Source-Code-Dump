using UnityEngine;
private sealed class AppsMenu.丑丕丄且丙丛丝东丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private System.Threading.Tasks.Task<bool> 丗丁丂七丑丟丟丑丞;
    private System.Threading.Tasks.Task<bool> 丆与丂世丟丞丙丆丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AppsMenu.丑丕丄且丙丛丝东丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_34;
        object val_35;
        System.Threading.Tasks.Task<System.Boolean> val_36;
        int val_37;
        var val_38;
        var val_39;
        var val_40;
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
            goto label_73;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested");
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
            goto label_73;
        }
        
        val_34 = Prime31.EtceteraAndroid.checkSelfPermission(permission:  "android.permission.WRITE_EXTERNAL_STORAGE");
        object[] val_5 = new object[1];
        val_35 = val_34;
        val_5[0] = val_35;
        UnityEngine.Debug.LogFormat(format:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested => externalStoragePermissionCheck: {0}", args:  val_5);
        if(val_34 == true)
        {
            goto label_73;
        }
        
        val_34 = StorageExplanation.Instance;
        if(val_34 != 0)
        {
            goto label_18;
        }
        
        UnityEngine.Debug.LogError(message:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested => StorageExplanation.Instance: null");
        PGCompany.七丞丝丏业丞丂丆上.一丐丛专下丞七丌万();
        goto label_73;
        label_1:
        val_36 = this.丆与丂世丟丞丙丆丒;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_22;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丗丁丂七丑丟丟丑丞 != null)
        {
            goto label_60;
        }
        
        label_61:
        label_60:
        if(this.丗丁丂七丑丟丟丑丞.IsCompleted == false)
        {
            goto label_24;
        }
        
        object[] val_9 = new object[1];
        val_35 = 1152921524381809552;
        val_34 = this.丗丁丂七丑丟丟丑丞.Result;
        val_9[0] = val_34;
        UnityEngine.Debug.LogFormat(format:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested => firstRequestFuture.Result: {0}", args:  val_9);
        if(this.丗丁丂七丑丟丟丑丞.Result == true)
        {
            goto label_73;
        }
        
        goto label_74;
        label_24:
        val_37 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_37;
        return (bool)val_37;
        label_18:
        if(UnityEngine.Application.isEditor != false)
        {
                val_34 = 23;
        }
        else
        {
                val_38 = null;
            val_34 = AppsMenu.丏丞丆丞一丝丟丙下();
        }
        
        object[] val_15 = new object[1];
        val_35 = val_34;
        val_15[0] = val_35;
        UnityEngine.Debug.LogFormat(format:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested => androidSdkVersion: {0}", args:  val_15);
        if(val_34 < 23)
        {
            goto label_73;
        }
        
        .丈丞世丏业丒丂不丑 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
        System.Action<System.Boolean> val_17 = new System.Action<System.Boolean>(object:  new AppsMenu.且不丘丝丕业下万一(), method:  System.Void AppsMenu.且不丘丝丕业下万一::且业丝丅一丞丆丆一(bool 业上丘下丗丂丝不上));
        if(UnityEngine.Application.isEditor != false)
        {
                val_17.Invoke(obj:  false);
        }
        else
        {
                object[] val_19 = new object[1];
            val_19[0] = 0;
            UnityEngine.Debug.LogFormat(format:  "[A_ppsM_enu] W_aitForS_torageP_ermissionR_equested => Calling G_rantP_ermission(permission: {0})", args:  val_19);
            val_39 = null;
            val_39 = null;
            NoodlePermissionGranter.专且万丏一与丌东丅 = val_17;
            NoodlePermissionGranter.GrantPermission(丂丐东七专不丁丝专:  0);
        }
        
        System.Threading.Tasks.Task<TResult> val_20 = (AppsMenu.且不丘丝丕业下万一)[1152921524381941072].丈丞世丏业丒丂不丑.Task;
        this.丗丁丂七丑丟丟丑丞 = val_20;
        if(val_20 != null)
        {
            goto label_60;
        }
        
        goto label_61;
        label_73:
        val_37 = 0;
        return (bool)val_37;
        label_74:
        AppsMenu.万丝东丄业东丝丁东 val_21 = new AppsMenu.万丝东丄业东丝丁东();
        System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_22 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
        if(val_21 != null)
        {
                val_40 = val_21;
            .世丅丒丆三下专丘丆 = val_22;
        }
        else
        {
                val_40 = 16;
            mem[16] = val_22;
        }
        
        val_36 = this;
        this.丆与丂世丟丞丙丆丒 = val_22.Task;
        System.Action val_26 = null;
        val_35 = val_26;
        val_26 = new System.Action(object:  val_21, method:  System.Void AppsMenu.万丝东丄业东丝丁东::三丁丅丏丅丘丈丑三());
        bool val_34 = Prime31.EtceteraAndroid.shouldShowRequestPermissionRationale(permission:  "android.permission.WRITE_EXTERNAL_STORAGE");
        val_34 = (UnityEngine.Application.isEditor != true) ? (new System.Action(object:  val_21, method:  System.Void AppsMenu.万丝东丄业东丝丁东::下业丏丅一且丌世丒())) : ((val_34 != true) ? (new System.Action(object:  val_21, method:  System.Void AppsMenu.万丝东丄业东丝丁东::丄丁丟东下丞业丟东())) : (val_35));
        val_34 = StorageExplanation.Instance;
        val_34.SetContinueCallback(丁世丏丁丁且丌丞万:  val_34);
        StorageExplanation.Instance.SetVisibiliity(丗丞丑丌丂东丑丅丙:  true);
        label_22:
        if(this.丆与丂世丟丞丙丆丒.IsCompleted == false)
        {
            goto label_71;
        }
        
        if(this.丆与丂世丟丞丙丆丒.Result == true)
        {
            goto label_73;
        }
        
        this.丆与丂世丟丞丙丆丒 = 0;
        goto label_74;
        label_71:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_37 = 1;
        return (bool)val_37;
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
