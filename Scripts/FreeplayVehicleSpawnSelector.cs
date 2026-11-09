using UnityEngine;
internal sealed class FreeplayVehicleSpawnSelector : MonoBehaviour
{
    // Fields
    public FreeplayVehicleSpawnPoint[] points;
    public FreeplayVehicleSpawnPoint[] freeCarPoints;
    private static readonly UnityEngine.Vector3 且丙下上东世丏丝专;
    
    // Methods
    private void Start()
    {
        var val_7;
        UnityEngine.Object val_8;
        if(UnityEngine.Application.isEditor != false)
        {
                if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if(GameController.mode != null)
        {
                var val_3 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_8 = 0;
        }
        
        if(val_8 == 0)
        {
                return;
        }
        
        val_8.丕丞丛不丝一七丒下(丙业与丙丗丝不丈东:  this);
        FreeplayCarsharingSpawnsController val_5 = this.GetComponent<FreeplayCarsharingSpawnsController>();
        if(val_5 == 0)
        {
                return;
        }
        
        val_5.丞世丙且丂丄且与丄(业丅丅与上丝丄且万:  this.freeCarPoints);
    }
    private void Update()
    {
        var val_14;
        var val_15;
        var val_16;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        System.Collections.Generic.List<FreeplayVehicleSpawnPoint> val_3 = new System.Collections.Generic.List<FreeplayVehicleSpawnPoint>();
        val_14 = 0;
        goto label_3;
        label_18:
        val_15 = 0;
        goto label_7;
        label_15:
        if((val_8[0x0][0] + 72) != 0)
        {
                val_16 = public System.Void System.Collections.Generic.List<FreeplayVehicleSpawnPoint>::Add(FreeplayVehicleSpawnPoint item);
        }
        else
        {
                val_16 = public System.Void System.Collections.Generic.List<FreeplayVehicleSpawnPoint>::Add(FreeplayVehicleSpawnPoint item);
        }
        
        val_3.Add(item:  this.gameObject.transform.GetChild(index:  0).GetComponentsInChildren<FreeplayVehicleSpawnPoint>()[0]);
        val_15 = 1;
        label_7:
        if(val_15 < val_8.Length)
        {
            goto label_15;
        }
        
        val_14 = 1;
        label_3:
        if(val_14 < this.gameObject.transform.childCount)
        {
            goto label_18;
        }
        
        this.points = val_3.ToArray();
        this.freeCarPoints = new System.Collections.Generic.List<FreeplayVehicleSpawnPoint>().ToArray();
    }
    internal static bool 且丞丂世丈丂东丌丒(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        null = null;
        bool val_1 = UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, halfExtents:  new UnityEngine.Vector3() {x = FreeplayVehicleSpawnSelector.且丙下上东世丏丝专, y = FreeplayVehicleSpawnSelector.且丙下上东世丏丝专.__il2cppRuntimeField_4, z = FreeplayVehicleSpawnSelector.且丙下上东世丏丝专.__il2cppRuntimeField_8}, orientation:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.z, z = ???, w = ???});
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal static bool 且丞丂世丈丂东丌丒(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, UnityEngine.Vector3 一丌丕丅东上丛专丌)
    {
        float val_1;
        bool val_2 = UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, halfExtents:  new UnityEngine.Vector3() {x = 一丌丕丅东上丛专丌.x, y = val_1, z = 一丌丕丅东上丛专丌.y}, orientation:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.z, z = ???, w = ???});
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    internal UnityEngine.Transform 丆三业丏丕丏且丆丒(UnityEngine.Vector3 丈七丅上丟丑专丅丝)
    {
        var val_11;
        .丈七丅上丟丑专丅丝 = 丈七丅上丟丑专丅丝;
        mem[1152921537552625828] = 丈七丅上丟丑专丅丝.y;
        mem[1152921537552625832] = 丈七丅上丟丑专丅丝.z;
        System.Collections.Generic.List<FreeplayVehicleSpawnPoint> val_2 = new System.Collections.Generic.List<FreeplayVehicleSpawnPoint>(collection:  this.points);
        val_2.Sort(comparison:  new System.Comparison<FreeplayVehicleSpawnPoint>(object:  new FreeplayVehicleSpawnSelector.丒丑万一丁丕东一丗(), method:  System.Int32 FreeplayVehicleSpawnSelector.丒丑万一丁丕东一丗::东丗世丕一上丗且七(FreeplayVehicleSpawnPoint 三丑丝丗不丈丐丞与, FreeplayVehicleSpawnPoint 丕七业丏专业上与丅)));
        var val_11 = 0;
        do
        {
            if(val_11 >= val_2.Count)
        {
                return 0;
        }
        
            FreeplayVehicleSpawnPoint val_5 = val_2.Item[0];
            UnityEngine.Vector3 val_7 = val_5.transform.position;
            UnityEngine.Quaternion val_9 = val_5.transform.rotation;
            val_11 = null;
            val_11 = val_11 + 1;
        }
        while((FreeplayVehicleSpawnSelector.且丞丂世丈丂东丌丒(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w})) == false);
        
        if(val_5 != null)
        {
                return val_5.transform;
        }
        
        return val_5.transform;
    }
    internal UnityEngine.Transform 丆三业丏丕丏且丆丒()
    {
        null = null;
        UnityEngine.Vector3 val_2 = transform.position;
        return this.丆三业丏丕丏且丆丒(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public FreeplayVehicleSpawnSelector()
    {
    
    }
    private static FreeplayVehicleSpawnSelector()
    {
        FreeplayVehicleSpawnSelector.且丙下上东世丏丝专 = 0;
        FreeplayVehicleSpawnSelector.且丙下上东世丏丝专.__il2cppRuntimeField_8 = 0;
    }

}
