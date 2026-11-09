using UnityEngine;
public class SetPosInArmor : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform 丛丌丕丐世丑丂七丂;
    private ScaleArmor 上且丞丂丕业专不丛;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    
    // Properties
    public UnityEngine.Transform 丘与丈丘丒丂丁丛丟 { get; set; }
    
    // Methods
    public UnityEngine.Transform get_Target()
    {
        return (UnityEngine.Transform)this.丛丌丕丐世丑丂七丂;
    }
    public void set_Target(UnityEngine.Transform 丙业与丙丗丝不丈东)
    {
        this.丛丌丕丐世丑丂七丂 = 丙业与丙丗丝不丈东;
        this.上且丞丂丕业专不丛 = 丙业与丙丗丝不丈东.GetComponent<ScaleArmor>();
    }
    public void SetPosition()
    {
        if(this.丛丌丕丐世丑丂七丂 == 0)
        {
                return;
        }
        
        if(this.transform == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.丛丌丕丐世丑丂七丂.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_7 = this.丛丌丕丐世丑丂七丂.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        UnityEngine.Transform val_9 = this.transform;
        if(this.上且丞丂丕业专不丛 == 0)
        {
            goto label_13;
        }
        
        if(val_9 != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        val_9.localScale = new UnityEngine.Vector3() {x = this.上且丞丂丕业专不丛.scale, y = val_7.y, z = val_7.z};
        return;
        label_13:
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        if(val_9 != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    private void Start()
    {
        this.万东万丆专丌丕丐丗 = this.transform;
    }
    internal void 业丐丌丅丒丆丟丟丄()
    {
        if(this.丛丌丕丐世丑丂七丂 != 0)
        {
                this.SetPosition();
            return;
        }
        
        if((this.万东万丆专丌丕丐丗.root.GetComponent<SkinName>()) == 0)
        {
                return;
        }
        
        if(val_3.playerMoveC.transform.childCount < 1)
        {
                return;
        }
        
        WeaponSounds val_9 = val_3.playerMoveC.transform.GetChild(index:  0).GetComponent<WeaponSounds>();
        if(val_9 == 0)
        {
                return;
        }
        
        bool val_13 = this.gameObject.name.Equals(value:  "Armor_Arm_Left");
        if(val_9 == null)
        {
            goto label_21;
        }
        
        if(val_13 == false)
        {
            goto label_22;
        }
        
        label_24:
        UnityEngine.Transform val_14 = val_9.丛丑丂丌与丗东下专();
        goto label_23;
        label_21:
        if(val_13 == true)
        {
            goto label_24;
        }
        
        label_22:
        label_23:
        this.Target = val_9.丘万专丌丕与上丅丁();
    }
    public SetPosInArmor()
    {
    
    }

}
