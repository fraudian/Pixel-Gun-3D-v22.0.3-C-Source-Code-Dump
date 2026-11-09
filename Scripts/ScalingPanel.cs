using UnityEngine;
public class ScalingPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 newScale;
    private UnityEngine.Vector3 且业七丗丙上丆专丑;
    private float 与丂丕不丛丆丌丁丛;
    
    // Methods
    private void OnEnable()
    {
        double val_9 = (double)UnityEngine.Screen.width;
        val_9 = val_9 / (double)UnityEngine.Screen.height;
        this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = (this.与丂丕不丛丆丌丁丛 < ((float)System.Math.Round(value:  val_9, digits:  1))) ? this.且业七丗丙上丆专丑 : this.newScale, y = (this.与丂丕不丛丆丌丁丛 < ((float)System.Math.Round(value:  val_9, digits:  1))) ? 1152921538961752376 : 1152921538961752364, z = (this.与丂丕不丛丆丌丁丛 < ((float)System.Math.Round(value:  val_9, digits:  1))) ? 1152921538961752380 : 1152921538961752368};
    }
    public ScalingPanel()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.且业七丗丙上丆专丑 = val_1;
        mem[1152921538961872568] = val_1.y;
        mem[1152921538961872572] = val_1.z;
        this.与丂丕不丛丆丌丁丛 = (float)System.Math.Round(value:  1.33333333333333, digits:  1);
    }

}
