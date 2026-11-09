using UnityEngine;
[Serializable]
public class ClanWarCameraSettings
{
    // Fields
    public UnityEngine.Vector3 position;
    public UnityEngine.Vector3 angles;
    public float zoom;
    
    // Methods
    public void 三业丒丑丂三丕上丛(float 丟丞一专丕三东丗一, UnityEngine.Vector3 三专万丗三丈丈丄丏)
    {
        float val_7;
        float val_8;
        float val_9;
        var val_11;
        var val_12;
        val_7 = 三专万丗三丈丈丄丏.z;
        val_8 = 三专万丗三丈丈丄丏.y;
        val_9 = 三专万丗三丈丈丄丏.x;
        业丆七世丟上下丌不 val_1 = 丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑();
        if(val_1 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
        {
                val_11 = null;
            var val_7 = 0;
            val_12 = 1152921505162579976;
            val_7 = val_7 + 1;
        }
        else
        {
                val_9 = this.position;
            val_11 = null;
            var val_8 = 0;
            val_12 = 1152921505162579976;
            val_8 = val_8 + 1;
        }
        
        val_1.SmoothMove(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7}, 东丗上东丘丄东丘世:  丟丞一专丕三东丗一);
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_1.SmoothRotateY(丟世丁世丏丅业下七:  new UnityEngine.Vector3() {x = this.angles, y = val_8, z = val_7}, 丅丅三与三七与丐上:  丟丞一专丕三东丗一);
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_1.SmoothZoom(上世东专丅丙一世与:  this.zoom, 丟丞一专丕三东丗一:  丟丞一专丕三东丗一);
    }
    public ClanWarCameraSettings()
    {
    
    }

}
