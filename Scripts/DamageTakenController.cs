using UnityEngine;
public class DamageTakenController : MonoBehaviour
{
    // Fields
    private float 丂三丟丂丈丐丆丗丟;
    private const float 丅丐一丛丒不丑一丒 = 0.3;
    private const float 丛丒三丅丗一丆丗丝 = 1.75;
    private readonly UnityEngine.Color 丛丁丗上丕丟丆丗丙;
    public UIBasicSprite mySprite;
    
    // Methods
    public void Reset(float 与专丌丅丙上丌一丄)
    {
        float val_4;
        var val_5;
        val_4 = 与专丌丅丙上丌一丄;
        val_5 = this;
        if((System.Single.IsNaN(f:  val_4)) == true)
        {
                return;
        }
        
        this.丂三丟丂丈丐丆丗丟 = 1.75f;
        val_5 = this.transform;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_4 = val_3.x;
        val_5.localRotation = new UnityEngine.Quaternion() {x = val_4, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    private void Start()
    {
        this.mySprite.color = new UnityEngine.Color() {r = this.丛丁丗上丕丟丆丗丙, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    public void Remove()
    {
        this.丂三丟丂丈丐丆丗丟 = -1f;
        this.mySprite.color = new UnityEngine.Color() {r = this.丛丁丗上丕丟丆丗丙, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    private void Update()
    {
        float val_3 = this.丂三丟丂丈丐丆丗丟;
        if(val_3 <= 0f)
        {
                return;
        }
        
        float val_4 = 1.75f;
        val_3 = val_3 / val_4;
        val_4 = val_3 / 0.3f;
        float val_1 = (val_3 < 0) ? (val_4) : 1f;
        this.mySprite.color = new UnityEngine.Color() {r = this.丛丁丗上丕丟丆丗丙, g = V9.16B, b = V10.16B, a = val_1};
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丂三丟丂丈丐丆丗丟 - val_2;
        this.丂三丟丂丈丐丆丗丟 = val_2;
        if(val_2 >= 0)
        {
                return;
        }
        
        this.mySprite.color = new UnityEngine.Color() {r = this.丛丁丗上丕丟丆丗丙, g = V9.16B, b = V10.16B, a = val_1};
    }
    public DamageTakenController()
    {
        this.丛丁丗上丕丟丆丗丙 = 0;
        mem[1152921525881310800] = 0;
        mem[1152921525881310808] = 0;
    }

}
