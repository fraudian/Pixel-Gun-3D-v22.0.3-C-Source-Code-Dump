using UnityEngine;
internal class BattleEmojiButtonSideSwapper : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_16;
        var val_17;
        float val_18;
        float val_19;
        var val_20;
        var val_21;
        val_16 = this;
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
                val_17 = null;
            val_17 = null;
            val_18 = 768f;
            float val_15 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_15 = val_18 / val_15;
            val_19 = (float)UnityEngine.Screen.height / val_15;
        }
        else
        {
                val_19 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        }
        
        val_19 = (float)UnityEngine.Screen.width / val_19;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_20 = null;
            val_20 = null;
            val_18 = 10f;
            float val_16 = IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            val_16 = val_19 * val_16;
            val_21 = val_16 + val_18;
        }
        else
        {
                val_21 = val_19 + (-10f);
        }
        
        UnityEngine.Vector3 val_12 = this.transform.localPosition;
        val_16 = this.transform;
        UnityEngine.Vector3 val_14 = val_16.localPosition;
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public BattleEmojiButtonSideSwapper()
    {
    
    }

}
