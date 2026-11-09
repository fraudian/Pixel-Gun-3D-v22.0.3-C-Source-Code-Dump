using UnityEngine;
private sealed class AppsMenu.丗丘丗丐丄丈丐丙丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AppsMenu 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AppsMenu.丗丘丗丐丄丈丐丙丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_19;
        int val_20;
        object val_21;
        string val_22;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_20 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[A_ppsM_enu.WaitForObbResolved] ApplicationBinarySplitted: "("[A_ppsM_enu.WaitForObbResolved] ApplicationBinarySplitted: ") + 1.ToString(provider:  AppsMenu.丙专丝世不业下丂丈())(1.ToString(provider:  AppsMenu.丙专丝世不业下丂丈())));
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
            goto label_16;
        }
        
        val_21 = AppsMenu.丆丏丒丙世三丘丛下();
        if(val_21 == null)
        {
            goto label_16;
        }
        
        val_19 = new object[1];
        val_19[0] = val_21;
        val_22 = "[A_ppsM_enu] W_aitForObbResolved => Breaking... OBB already exists: \'{0}\'";
        goto label_22;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_23;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == true)
        {
            goto label_24;
        }
        
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu.WaitForObbResolved] Fetching OBB...");
        丏一丌丆业专丑丂丛 val_9 = 且丞丑下丈丞丘一丌.丏丞且与丒丕丗不丄();
        val_21 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAoTzMTaqsFhaywvCFKawFwL5KM+djLJfOCT/rbGQRfHmHYmOY2sBMgDWsA/67Szx6EVTZPVlFzHMgkAq1TwdL/A5aYGpGzaCX7o96cyp8R6wSF+xCuj++LAkTaDnLW0veI2bke3EVHu3At9xgM46e+VDucRUqQLvf6SQRb15nuflY5i08xKnewgX7I4U2H0RvAZDyoip+qZPmI4ZvaufAfc0jwZbw7XGiV41zibY3LU0N57mYKk51Wx+tOaJ7Tkc9Rl1qVCTjb+bwXshTqhVXVP6r4kabLWw/8OJUh0Sm69lbps6amP7vPy571XjscCTMLfXQan1959rHbNgkb2mLLQIDAQAB";
        var val_19 = 0;
        val_19 = val_19 + 1;
        goto label_33;
        label_16:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  2);
        if(this.丝且与丝丒丟万丁专 != null)
        {
                2.下业丒丛下丌丟一业(丑丞东万丁丂丏万丙:  "WaitForObbResolved");
            val_21 = 2.七上丒丐丌三丅丑丏();
        }
        else
        {
                0.下业丒丛下丌丟一业(丑丞东万丁丂丏万丙:  "WaitForObbResolved");
            val_21 = 0.七上丒丐丌三丅丑丏();
        }
        
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_21);
        val_20 = 1;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_33:
        val_9.丘丌丆丘丁丑三丈上(丙业与丙丗丝不丈东:  val_21);
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_9.东下万丅丞且不丂丟();
        label_24:
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu] W_aitForObbResolved => Waiting for mainPath...");
        label_23:
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_46;
        }
        
        if(System.String.alignConst == 0)
        {
            goto label_47;
        }
        
        label_56:
        object[] val_16 = new object[1];
        val_19 = val_16;
        val_19[0] = System.String.alignConst;
        val_22 = "[A_ppsM_enu] W_aitForObbResolved => Breaking... mainPath: \'{0}\'";
        label_22:
        UnityEngine.Debug.LogFormat(format:  val_22, args:  val_16);
        val_20 = 0;
        return (bool)val_20;
        label_46:
        if(AppsMenu.丆丏丒丙世三丘丛下() != null)
        {
            goto label_56;
        }
        
        label_47:
        val_20 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  0.5f);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_20;
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
