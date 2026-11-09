using UnityEngine;
public class OffsetFromCurve : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 七丝丑丐东丅丒丁丂;
    public float timeSpeed;
    public float randomSpeedMin;
    public float randomSpeedMax;
    public UnityEngine.AnimationCurve offsetX;
    public UnityEngine.AnimationCurve offsetY;
    public UnityEngine.AnimationCurve offsetZ;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.七丝丑丐东丅丒丁丂 = val_2;
        mem[1152921535463493212] = val_2.y;
        mem[1152921535463493216] = val_2.z;
        float val_3 = UnityEngine.Random.Range(min:  this.randomSpeedMin, max:  this.randomSpeedMax);
        val_3 = this.timeSpeed + val_3;
        this.timeSpeed = val_3;
    }
    private void Update()
    {
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 * this.timeSpeed;
        float val_4 = UnityEngine.Time.time;
        val_4 = val_4 * this.timeSpeed;
        float val_6 = UnityEngine.Time.time;
        val_6 = val_6 * this.timeSpeed;
        float val_8 = this.七丝丑丐东丅丒丁丂 + (this.offsetX.Evaluate(time:  val_2));
        float val_9 = S12 + (this.offsetY.Evaluate(time:  val_4));
        float val_10 = S13 + (this.offsetZ.Evaluate(time:  val_6));
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public OffsetFromCurve()
    {
        this.七丝丑丐东丅丒丁丂 = 0;
        mem[1152921535463754080] = 0;
        this.timeSpeed = 0.1f;
        this.randomSpeedMax = 0.1f;
    }

}
