using UnityEngine;
public sealed class DamageTakesRotator : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    public InGameGUI inGameGUI;
    private bool 丏丕丟且丞丐一丝丗;
    private UnityEngine.GameObject 丌三丐不丄丆丘丄七;
    
    // Properties
    private UnityEngine.GameObject 丗丁丒三丐丞丏万下 { get; }
    
    // Methods
    private UnityEngine.GameObject 丏丟不三且丝丛丆丌()
    {
        var val_2;
        var val_3;
        if(this.丏丕丟且丞丐一丝丗 == true)
        {
                return (UnityEngine.GameObject)this.丌三丐不丄丆丘丄七;
        }
        
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return (UnityEngine.GameObject)this.丌三丐不丄丆丘丄七;
        }
        
        val_3 = null;
        val_3 = null;
        this.丏丕丟且丞丐一丝丗 = true;
        this.丌三丐不丄丆丘丄七 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        return (UnityEngine.GameObject)this.丌三丐不丄丆丘丄七;
    }
    private void Start()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
    }
    private void Update()
    {
        this.丁上专万丕万丛且丞();
    }
    private void 丁上专万丕万丛且丞()
    {
        UnityEngine.GameObject val_7 = this.丏丟不三且丝丛丆丌();
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = this.万一丂丐丄丁上与丟;
        UnityEngine.Quaternion val_5 = this.丏丟不三且丝丛丆丌().transform.localRotation;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_7.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public DamageTakesRotator()
    {
    
    }

}
