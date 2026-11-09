using UnityEngine;
public class HoleBulletStackController : MonoBehaviour
{
    // Fields
    internal static HoleBulletStackController 丄丞丁丈与业上丞丟;
    public HoleScript[] holes;
    private int 丞丞不丏且与丝丆万;
    private int _holesNeededCount;
    private UnityEngine.GameObject _holePrefab;
    
    // Methods
    private void Start()
    {
        var val_7;
        HoleScript[] val_8;
        HoleScript[] val_9;
        HoleScript val_10;
        val_7 = null;
        val_7 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        HoleBulletStackController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        val_8 = new HoleScript[0];
        this.holes = val_8;
        if(val_5.Length < 1)
        {
                return;
        }
        
        goto label_12;
        label_23:
        val_9 = this.holes;
        label_12:
        T val_8 = this.transform.GetComponentsInChildren<HoleScript>(includeInactive:  true)[0];
        if(val_9 == null)
        {
            goto label_14;
        }
        
        if(val_8 != 0)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_8 == 0)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_9[0] = val_8;
        val_10 = this.holes[0];
        val_10.Init();
        if((0 + 1) < val_5.Length)
        {
            goto label_23;
        }
    
    }
    public HoleScript GetCurrentHole(bool 丁丈丄不且专丘与世)
    {
        var val_2;
        int val_3;
        HoleScript val_4;
        val_2 = 1;
        label_8:
        int val_1 = this.丞丞不丏且与丝丆万 + 1;
        this.丞丞不丏且与丝丆万 = val_1;
        if(val_1 >= this.holes.Length)
        {
            goto label_1;
        }
        
        val_3 = this.丞丞不丏且与丝丆万;
        goto label_2;
        label_1:
        if((val_2 & 1) == 0)
        {
            goto label_3;
        }
        
        val_3 = 0;
        val_2 = 0;
        this.丞丞不丏且与丝丆万 = 0;
        label_2:
        HoleScript val_2 = this.holes[0];
        if(this.holes[0x0][0].isUseMine != false)
        {
                if(丁丈丄不且专丘与世 == false)
        {
            goto label_8;
        }
        
        }
        
        val_4 = this.holes[this.丞丞不丏且与丝丆万];
        return (HoleScript)val_4;
        label_3:
        val_4 = 0;
        return (HoleScript)val_4;
    }
    private void OnDestroy()
    {
        HoleBulletStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public HoleBulletStackController()
    {
    
    }

}
