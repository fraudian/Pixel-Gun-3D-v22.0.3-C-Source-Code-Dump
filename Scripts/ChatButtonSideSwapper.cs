using UnityEngine;
public class ChatButtonSideSwapper : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_21;
        var val_22;
        float val_23;
        float val_24;
        var val_25;
        float val_26;
        float val_27;
        val_21 = this;
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == true)
        {
                return;
        }
        
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
                return;
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_22 = null;
            val_22 = null;
            val_23 = 768f;
            float val_19 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_19 = val_23 / val_19;
            val_24 = (float)UnityEngine.Screen.height / val_19;
        }
        else
        {
                val_24 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        }
        
        val_24 = (float)UnityEngine.Screen.width / val_24;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_25 = null;
            val_25 = null;
            UnityEngine.Vector3 val_11 = this.transform.localPosition;
            val_23 = val_24 * IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            val_26 = val_23 - val_11.x;
            val_27 = 10f;
        }
        else
        {
                UnityEngine.Vector3 val_13 = this.transform.localPosition;
            val_26 = val_24 - val_13.x;
            val_27 = 2f;
        }
        
        val_26 = val_27 + val_26;
        UnityEngine.Vector3 val_16 = this.transform.localPosition;
        val_21 = this.transform;
        UnityEngine.Vector3 val_18 = val_21.localPosition;
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ChatButtonSideSwapper()
    {
    
    }

}
