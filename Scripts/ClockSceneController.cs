using UnityEngine;
public class ClockSceneController : MonoBehaviour
{
    // Fields
    public ClockSceneController.丞丏与丕且丕丘丁七 type;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    public DisableObjectFromTimer bats;
    private int 丙东专丗上不丂丆业;
    
    // Methods
    private void Start()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
        this.丕丌七丄丘丄万世上();
    }
    private void Update()
    {
        this.丕丌七丄丘丄万世上();
    }
    private void 丕丌七丄丘丄万世上()
    {
        UnityEngine.Transform val_14;
        int val_15;
        丞丏与丕且丕丘丁七 val_16;
        float val_17;
        val_14 = this;
        System.DateTime val_1 = System.DateTime.Now;
        if(this.type != 0)
        {
                val_15 = val_1.dateData.Minute + (val_1.dateData.Hour * 60);
        }
        else
        {
                val_15 = val_1.dateData.Minute;
        }
        
        if(val_15 == this.丙东专丗上不丂丆业)
        {
                return;
        }
        
        if(((this.bats != 0) && (val_15 == 0)) && (val_15 < this.丙东专丗上不丂丆业))
        {
                this.bats.timer = 10f;
            this.bats.gameObject.SetActive(value:  true);
            val_16 = this.type;
            this.丙东专丗上不丂丆业 = 0;
            val_17 = 0f;
        }
        else
        {
                this.丙东专丗上不丂丆业 = val_15;
            var val_7 = (this.type != 1) ? 1 : 0;
            val_7 = ((this.type < 1) ? 1 : 0) | val_7;
            val_17 = ((float)(val_7 != 0) ? (val_15) : (val_15 - 720)) * 360f;
        }
        
        var val_12 = (((val_7 != 0) ? this.type : (0 + 1)) == 0) ? 1 : 0;
        float val_14 = 106024200 + val_11 == 0x0 ? 1 : 0;
        val_14 = this.万一丂丐丄丁上与丟;
        val_14 = val_17 / val_14;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_14.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
    }
    public ClockSceneController()
    {
        this.丙东专丗上不丂丆业 = 999;
    }

}
