using UnityEngine;
private sealed class PhotonHandler.且七世世三与七一丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丛一丌世专业丟丗与;
    private UnityEngine.WaitForSeconds 丄丌丛丁七一丕且世;
    private 一一丘丆丗下丗下七 丛丅下丆丌丆且丏且;
    private UnityEngine.WaitForSeconds 上下丕丛丏丂丕丂不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PhotonHandler.且七世世三与七一丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ClientState val_9;
        var val_27;
        一一丘丆丗下丗下七 val_28;
        object val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.WaitForSeconds val_35;
        int val_36;
        var val_37;
        UnityEngine.WaitForSeconds val_38;
        val_27 = this;
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
            goto label_62;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丛丁七一丕且世 = 0;
        goto label_4;
        label_1:
        val_28 = this.丛丅下丆丌丆且丏且;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_29 = 1152921505107111936;
        val_30 = static_value_081D9CF0;
        val_30 = static_value_081D9CF0;
        val_31 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕()) == null)
        {
            goto label_9;
        }
        
        val_31 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕()) == null)
        {
            goto label_18;
        }
        
        val_32 = static_value_081D9CF0;
        val_32 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕().Count) == 0)
        {
            goto label_18;
        }
        
        一一丘丆丗下丗下七 val_5 = new 一一丘丆丗下丗下七();
        val_28 = val_27;
        this.丛丅下丆丌丆且丏且 = val_5;
        val_33 = static_value_081D9CF0;
        val_33 = static_value_081D9CF0;
        List.Enumerator<T> val_7 = static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕().GetEnumerator();
        label_28:
        if((873126720 & 1) == 0)
        {
            goto label_23;
        }
        
        val_34 = null;
        val_34 = null;
        UnityEngine.Coroutine val_12 = PhotonHandler.丁丏一丟丕万丕三丄.StartCoroutine(routine:  val_5.东且丙丘不世丟丛业(万丅丝丈上丅丘丈丘:  val_9.丐丏七丌丕丗业且上()));
        goto label_28;
        label_18:
        label_47:
        UnityEngine.Debug.LogError(message:  "No regions available. Are you sure your appid is valid and setup?");
        goto label_62;
        label_9:
        if(丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌() != 17)
        {
                if(丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌() != 18)
        {
            goto label_47;
        }
        
        }
        
        val_9 = 丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌();
        ServerConnection val_16 = 丅丒丗丑丒丙丛不丆.丙且丗丛一一专丂丕();
        val_29 = val_16;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Waiting for AvailableRegions. State: {0} Server: {1} PhotonNetwork.networkingPeer.AvailableRegions {2}", arg0:  val_9, arg1:  val_16, arg2:  ((static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕()) != 0) ? 1 : 0));
        val_35 = this.丄丌丛丁七一丕且世;
        if(val_35 == null)
        {
                UnityEngine.WaitForSeconds val_20 = null;
            val_35 = val_20;
            val_20 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
            this.丄丌丛丁七一丕且世 = val_35;
        }
        
        val_36 = 1;
        this.丒上七丌业七丟与丐 = val_35;
        this.丗丏丅丕丆世丁专丟 = val_36;
        return (bool)val_36;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.上下丕丛丏丂丕丂不 = 0;
        label_5:
        if(val_5.丏且丂丒丗丂且与丐() == false)
        {
            goto label_55;
        }
        
        丟丟且且丙丌下丅丗 val_22 = val_5.丘业丈丕万丆丗丒丁();
        PhotonHandler.丂上丞丁丁丘丈三丌(丙业与丙丗丝不丈东:  val_22.丂与丒不丄丛丏丟丆);
        val_9 = val_22.丂与丒不丄丛丏丟丆;
        val_29 = System.String.Format(format:  "Found best region: \'{0}\' ping: {1}. Calling ConnectToRegionMaster() is: {2}", arg0:  val_9, arg1:  val_22.丕丗丈丞丑丁下七丝, arg2:  this.丛一丌世专业丟丗与);
        UnityEngine.Debug.Log(message:  val_29);
        if(this.丛一丌世专业丟丗与 != false)
        {
                val_37 = static_value_081D9CF0;
            val_37 = static_value_081D9CF0;
            val_27 = mem[static_value_081D9CF0 + 184 + 16];
            val_27 = static_value_081D9CF0 + 184 + 16;
            bool val_24 = val_27.丒丂丈丙丛万丒世丂(万丅丝丈上丅丘丈丘:  val_22.丂与丒不丄丛丏丟丆);
        }
        
        label_62:
        val_36 = 0;
        return (bool)val_36;
        label_55:
        val_38 = this.上下丕丛丏丂丕丂不;
        if(val_38 == null)
        {
                UnityEngine.WaitForSeconds val_25 = null;
            val_38 = val_25;
            val_25 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
            this.上下丕丛丏丂丕丂不 = val_38;
        }
        
        this.丒上七丌业七丟与丐 = val_38;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_36 = 1;
        return (bool)val_36;
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
