using UnityEngine;
internal sealed class FreeplayCarsharingSpawnsController : MonoBehaviour
{
    // Fields
    private readonly System.Collections.Generic.Dictionary<TransportControllerBase, uint> 丈一业丑且世丛下丌;
    private readonly System.Collections.Generic.HashSet<TransportControllerBase> 丁下丒丁丆丟专世丗;
    private readonly System.Collections.Generic.HashSet<FreeplayVehicleSpawnPoint> 一丗三丛下丑丂丙丌;
    private System.Collections.Generic.List<FreeplayVehicleSpawnPoint> 丌丈上丟丏丄上丒丂;
    private bool 丝与丆丞东丘丈东丘;
    private int 丘丝丁七七丕丄上不;
    private readonly int 丂丏丝丆丘丒丗丛不;
    private readonly int 丄世东专丕丐丛丅丟;
    
    // Methods
    internal void 丞世丙且丂丄且与丄(FreeplayVehicleSpawnPoint[] 业丅丅与上丝丄且万)
    {
        var val_8;
        if(this.丌丈上丟丏丄上丒丂 != null)
        {
                return;
        }
        
        System.Collections.Generic.List<FreeplayVehicleSpawnPoint> val_1 = new System.Collections.Generic.List<FreeplayVehicleSpawnPoint>(collection:  业丅丅与上丝丄且万);
        this.丌丈上丟丏丄上丒丂 = val_1;
        val_1.Sort(comparison:  new System.Comparison<FreeplayVehicleSpawnPoint>(object:  this, method:  System.Int32 FreeplayCarsharingSpawnsController::丘一专丁丐丘世丅不(FreeplayVehicleSpawnPoint 三丟东丕丄丄下下丑, FreeplayVehicleSpawnPoint 丒丒丄丁且丄丆丂丌)));
        int val_3 = this.丌丈上丟丏丄上丒丂.Count;
        this.丝与丆丞东丘丈东丘 = (val_3 > 0) ? 1 : 0;
        if(val_3 < 1)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_8 = 0;
        goto label_8;
        label_11:
        this.东丛丁一丆且一与丘(丐一丅丑丕丈不丆丛:  this.丌丈上丟丏丄上丒丂.Item[0]);
        val_8 = 1;
        label_8:
        if(val_8 < this.丌丈上丟丏丄上丒丂.Count)
        {
            goto label_11;
        }
    
    }
    internal void 万专一丁下不且与且(FreeplayVehicleOwner 七三丁丄三一且丘上)
    {
        TransportControllerBase val_1 = 七三丁丄三一且丘上.GetComponent<TransportControllerBase>();
        if(this.丝与丆丞东丘丈东丘 == false)
        {
                return;
        }
        
        if((this.丁下丒丁丆丟专世丗.Contains(item:  val_1)) == false)
        {
                return;
        }
        
        bool val_3 = this.丁下丒丁丆丟专世丗.Remove(item:  val_1);
        bool val_5 = this.一丗三丛下丑丂丙丌.Add(item:  this.丌丈上丟丏丄上丒丂.Item[七三丁丄三一且丘上.ownerId]);
    }
    internal void 三丂世丄丝丟丅丂丗(FreeplayVehicleOwner 七三丁丄三一且丘上)
    {
        System.Collections.Generic.List<FreeplayVehicleSpawnPoint> val_9;
        System.Collections.Generic.HashSet<TransportControllerBase> val_10 = this;
        if(this.丝与丆丞东丘丈东丘 == false)
        {
                return;
        }
        
        if((七三丁丄三一且丘上.ownerId & 2147483648) != 0)
        {
                return;
        }
        
        val_9 = this.丌丈上丟丏丄上丒丂;
        if(七三丁丄三一且丘上.ownerId >= val_9.Count)
        {
                return;
        }
        
        val_9 = this.丌丈上丟丏丄上丒丂.Item[七三丁丄三一且丘上.ownerId];
        TransportControllerBase val_3 = 七三丁丄三一且丘上.GetComponent<TransportControllerBase>();
        if(val_3 != null)
        {
                val_3.与与丕丏专东丘下丝(丙业与丙丗丝不丈东:  val_9);
        }
        
        if((this.一丗三丛下丑丂丙丌.Contains(item:  val_9)) != false)
        {
                bool val_5 = this.一丗三丛下丑丂丙丌.Remove(item:  val_9);
        }
        
        val_10 = this.丁下丒丁丆丟专世丗;
        bool val_6 = val_10.Add(item:  val_3);
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_10 = val_2.transportSkinID;
        if(val_3 == null)
        {
                return;
        }
        
        var val_8 = (((TransportControllerBase.__il2cppRuntimeField_typeHierarchy + (VehicleController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
    }
    private void Update()
    {
        var val_8;
        var val_34;
        var val_35;
        var val_36;
        var val_38;
        var val_39;
        var val_40;
        float val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_34 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        int val_33 = this.丘丝丁七七丕丄上不;
        val_33 = val_33 + 1;
        this.丘丝丁七七丕丄上不 = val_33;
        if(val_33 < this.丂丏丝丆丘丒丗丛不)
        {
                return;
        }
        
        this.丘丝丁七七丕丄上不 = 0;
        if(this.一丗三丛下丑丂丙丌.Count < 1)
        {
            goto label_6;
        }
        
        int val_3 = this.一丗三丛下丑丂丙丌.Count;
        FreeplayVehicleSpawnPoint[] val_4 = new FreeplayVehicleSpawnPoint[0];
        this.一丗三丛下丑丂丙丌.CopyTo(array:  val_4);
        val_35 = 0;
        val_36 = 0;
        goto label_9;
        label_41:
        FreeplayVehicleSpawnPoint val_34 = val_4[0];
        HashSet.Enumerator<T> val_6 = this.丁下丒丁丆丟专世丗.GetEnumerator();
        label_16:
        if(((-1428567088) & 1) == 0)
        {
            goto label_13;
        }
        
        FreeplayVehicleOwner val_10 = val_8.丐丏七丌丕丗业且上().万东丂七东丁与业东();
        if(val_10.ownerId != (this.丌丈上丟丏丄上丒丂.IndexOf(item:  val_34)))
        {
            goto label_16;
        }
        
        val_36 = 1;
        val_38 = 1;
        goto label_18;
        label_13:
        val_38 = 0;
        val_36 = 1;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_36 != 1) && (194 == 194))
        {
                var val_35 = 0;
            val_35 = val_35 ^ 0;
            val_36 = val_36 + val_35;
            val_39 = val_8;
        }
        else
        {
                val_39 = 0;
        }
        
        if(val_34 != null)
        {
                val_40 = val_34.transform;
        }
        else
        {
                val_40 = 0.transform;
        }
        
        UnityEngine.Vector3 val_13 = val_40.position;
        UnityEngine.Quaternion val_14 = val_40.rotation;
        if(val_4[0x0][0].transportType == 2)
        {
                val_8 = 0;
            val_41 = val_13.x;
            val_42 = (UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = val_41, y = val_13.y, z = val_13.z}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, orientation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.z})) ^ 1;
        }
        else
        {
                val_42 = null;
            val_41 = val_13.x;
        }
        
        if(( | (~(FreeplayVehicleSpawnSelector.且丞丂世丈丂东丌丒(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_41, y = val_13.y, z = val_13.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w})))) == false)
        {
            goto label_36;
        }
        
        if( == 0)
        {
            goto label_39;
        }
        
        bool val_18 = this.一丗三丛下丑丂丙丌.Remove(item:  val_34);
        goto label_39;
        label_36:
        this.东丛丁一丆且一与丘(丐一丅丑丕丈不丆丛:  val_34);
        label_39:
        val_35 = 1;
        label_9:
        if(val_35 < val_4.Length)
        {
            goto label_41;
        }
        
        val_34 = 1152921505107111936;
        goto label_42;
        label_6:
        val_36 = 0;
        label_42:
        double val_19 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        HashSet.Enumerator<T> val_20 = this.丁下丒丁丆丟专世丗.GetEnumerator();
        label_52:
        if(((-1428567088) & 1) == 0)
        {
            goto label_46;
        }
        
        string val_21 = val_8.丐丏七丌丕丗业且上();
        if(((val_21 & 1) == 0) || ((this.丈一业丑且世丛下丌.ContainsKey(key:  val_21)) == true))
        {
            goto label_52;
        }
        
        double val_36 = (double)this.丄世东专丕丐丛丅丟;
        val_36 = val_19 + val_36;
        this.丈一业丑且世丛下丌.Add(key:  val_21, value:  (int)val_36);
        goto label_52;
        label_46:
        val_43 = val_36 + 1;
        mem2[0] = 434;
        val_44 = public System.Void HashSet.Enumerator<TransportControllerBase>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_43 != 1) && ((-1428567200 + ((val_36 + 1)) << 2) == 434))
        {
                var val_37 = 0;
            val_37 = val_37 ^ (val_43 >> 31);
            val_43 = val_43 + val_37;
        }
        else
        {
                if(val_8 != 0)
        {
                val_44 = 0;
        }
        
        }
        
        System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘> val_23 = new System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘>();
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_25 = this.丈一业丑且世丛下丌.Keys.GetEnumerator();
        label_68:
        if(((-1428567120) & 1) == 0)
        {
            goto label_64;
        }
        
        string val_26 = val_8.丐丏七丌丕丗业且上();
        if(val_19 <= (double)this.丈一业丑且世丛下丌.Item[val_26])
        {
            goto label_68;
        }
        
        bool val_28 = val_23.Add(item:  val_26);
        goto label_68;
        label_64:
        val_45 = val_43 + 1;
        mem2[0] = 521;
        val_46 = 1152921537537910192;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_45 == 1) || ((-1428567200 + (((val_36 + 1) + 1)) << 2) != 521))
        {
            goto label_74;
        }
        
        var val_38 = 0;
        val_38 = val_38 ^ (val_45 >> 31);
        val_45 = val_45 + val_38;
        if(val_23 != null)
        {
            goto label_78;
        }
        
        goto label_76;
        label_74:
        if(val_23 != null)
        {
            goto label_78;
        }
        
        label_76:
        label_78:
        HashSet.Enumerator<T> val_29 = val_23.GetEnumerator();
        label_84:
        if(((-1428567088) & 1) == 0)
        {
            goto label_79;
        }
        
        string val_30 = val_8.丐丏七丌丕丗业且上();
        bool val_31 = this.丈一业丑且世丛下丌.Remove(key:  val_30);
        if(val_30 == null)
        {
            goto label_84;
        }
        
        goto label_84;
        label_79:
        val_45 = val_45 + 1;
        mem2[0] = 598;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_45 != 1)
        {
                if(val_8 == 0)
        {
                return;
        }
        
            if((-1428567200 + ((((val_36 + 1) + 1) + 1)) << 2) == 598)
        {
                return;
        }
        
            return;
        }
        
        if(val_8 != 0)
        {
                return;
        }
    
    }
    private int 丘一专丁丐丘世丅不(FreeplayVehicleSpawnPoint 三丟东丕丄丄下下丑, FreeplayVehicleSpawnPoint 丒丒丄丁且丄丆丂丌)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_4 = 三丟东丕丄丄下下丑.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_8 = 丒丒丄丁且丄丆丂丌.transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        float val_10 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        return -1428336212;
    }
    private void 东丛丁一丆且一与丘(FreeplayVehicleSpawnPoint 丐一丅丑丕丈不丆丛)
    {
        System.Object[] val_6;
        FreeplayVehicleSpawnPoint val_7 = 丐一丅丑丕丈不丆丛;
        int val_1 = this.丌丈上丟丏丄上丒丂.IndexOf(item:  val_7 = 丐一丅丑丕丈不丆丛);
        UnityEngine.Transform val_2 = val_7.transform;
        if(val_1 == 1)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        object[] val_4 = new object[2];
        val_6 = val_4;
        val_6[0] = val_1;
        val_6[1] = true;
        val_7 = 丐一丅丑丕丈不丆丛.transportType;
        UnityEngine.GameObject val_5 = 业丛丙丛丗世丑丑丂.丄七丝丏丈丗业世业(丁丅丈丌丟世丗丗丟:  val_7, 丂丁万丞万丆三一丒:  val_2, 丂东丄丏丕丕丅上一:  0, 一丐丗丁丞丆丅丟丄:  val_4);
    }
    public FreeplayCarsharingSpawnsController()
    {
        this.丈一业丑且世丛下丌 = new System.Collections.Generic.Dictionary<TransportControllerBase, System.UInt32>();
        this.丁下丒丁丆丟专世丗 = new System.Collections.Generic.HashSet<TransportControllerBase>();
        this.一丗三丛下丑丂丙丌 = new System.Collections.Generic.HashSet<FreeplayVehicleSpawnPoint>();
        this.丂丏丝丆丘丒丗丛不 = 30;
        this.丄世东专丕丐丛丅丟 = 10;
    }

}
