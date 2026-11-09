using UnityEngine;
private sealed class VehicleController.丘丒下丏业东业三且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VehicleController 丝且与丝丒丟万丁专;
    public string 丏丆丕丏丘业东万下;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VehicleController.丘丒下丏业东业三且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        VehicleController val_27;
        string val_28;
        var val_29;
        int val_30;
        VehicleView val_31;
        float val_32;
        float val_33;
        val_27 = this.丝且与丝丒丟万丁专;
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
        
        val_28 = this.丏丆丕丏丘业东万下;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_27 == null)
        {
            goto label_4;
        }
        
        mem2[0] = val_28;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.currentView.gameObject);
        label_80:
        UnityEngine.Object val_3 = UnityEngine.Object.Instantiate(original:  mem[this.丅丒丑丄丞丑下丈丕].asset);
        if(val_3 == null)
        {
            goto label_13;
        }
        
        var val_4 = (null == null) ? (val_3) : 0;
        goto label_15;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone == false)
        {
            goto label_17;
        }
        
        UnityEngine.Object val_6 = null.asset;
        val_29 = 1152921504848912384;
        if(val_6 != 0)
        {
            goto label_21;
        }
        
        label_17:
        object[] val_8 = new object[1];
        val_8[0] = val_6;
        UnityEngine.Debug.LogWarningFormat(format:  "Can\'t load vehicle: {0}", args:  val_8);
        val_27.世下下万丏一丂丂丗(丂东丄丏丕丕丅上一:  val_27);
        goto label_29;
        label_3:
        val_30 = 0;
        return (bool)val_30;
        label_13:
        label_15:
        val_31 = 0.GetComponent<VehicleView>();
        this.丝且与丝丒丟万丁专.currentView = val_31;
        if(this.丝且与丝丒丟万丁专.engine == null)
        {
                val_31 = this.丝且与丝丒丟万丁专.currentView;
        }
        
        UnityEngine.Transform val_10 = val_31.transform;
        if(this.丝且与丝丒丟万丁专.engine != null)
        {
                val_10.parent = 0;
            val_27.万与丝丄丅丅一丛丅();
        }
        else
        {
                val_10.parent = val_27.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            this.丝且与丝丒丟万丁专.currentView.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
            val_32 = val_15.x;
            val_33 = val_15.z;
            this.丝且与丝丒丟万丁专.currentView.transform.localRotation = new UnityEngine.Quaternion() {x = val_32, y = val_15.y, z = val_33, w = val_15.w};
        }
        
        val_29 = 0;
        this.丝且与丝丒丟万丁专.engine.view = this.丝且与丝丒丟万丁专.currentView;
        goto label_46;
        label_61:
        if(this.丝且与丝丒丟万丁专.places[0] != 0)
        {
                Player_move_c val_28 = this.丝且与丝丒丟万丁专.places[0];
            UnityEngine.Vector3 val_17 = VehicleView.__il2cppRuntimeField_byval_arg.localPosition;
            val_32 = val_17.x;
            val_33 = val_17.z;
            this.丝且与丝丒丟万丁专.places[0x0][0].myPlayerTransform.localPosition = new UnityEngine.Vector3() {x = val_32, y = val_17.y, z = val_33};
        }
        
        val_29 = 1;
        label_46:
        if(val_29 < this.丝且与丝丒丟万丁专.places.Length)
        {
            goto label_61;
        }
        
        val_27.丞丑丅丆丐丛丏丏丌();
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_74;
        }
        
        if(val_27.photonView.isMine == false)
        {
            goto label_66;
        }
        
        this.丝且与丝丒丟万丁专.currentView.丗丕万丅三丕丌丞丒();
        object[] val_22 = new object[1];
        val_22[0] = this.丝且与丝丒丟万丁专.currentView.不丗丘丘一丕丑专一;
        val_27.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  195, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_22);
        goto label_74;
        label_4:
        val_27 = 144;
        mem[144] = val_28;
        val_28 = mem[144];
        label_5:
        UnityEngine.ResourceRequest val_24 = UnityEngine.Resources.LoadAsync(path:  "VehicleBattleRoyale/Vehicle_Battle/"("VehicleBattleRoyale/Vehicle_Battle/") + val_28);
        val_30 = 1;
        this.丅丒丑丄丞丑下丈丕 = val_24;
        this.丒上七丌业七丟与丐 = val_24;
        this.丗丏丅丕丆世丁专丟 = val_30;
        return (bool)val_30;
        label_66:
        this.丝且与丝丒丟万丁专.currentView.东丏三丆丅三且丛丁(丗丂丛丝丝丌且丐丅:  this.丝且与丝丒丟万丁专.不丗丘丘一丕丑专一);
        label_74:
        val_27.东丟世丞丈世丞下七();
        label_29:
        val_30 = 0;
        mem2[0] = 0;
        return (bool)val_30;
        label_21:
        if(this.丝且与丝丒丟万丁专.currentView == 0)
        {
            goto label_80;
        }
        
        this.丝且与丝丒丟万丁专.currentView.ChangeSkin();
        this.丝且与丝丒丟万丁专.setViewParticle.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.setViewParticle.SetActive(value:  true);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.33f);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_30;
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
