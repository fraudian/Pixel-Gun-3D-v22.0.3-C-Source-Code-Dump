using UnityEngine;
public class DuelPlayersPosition : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform firstPlayer;
    public UnityEngine.Transform secondPlayer;
    public float multipler;
    private UnityEngine.Vector3 丛丌且不业丙丟七世;
    private UnityEngine.Vector3 丈丝丆一丞丕下丗上;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_1 = this.firstPlayer.localPosition;
        this.丛丌且不业丙丟七世 = val_1;
        mem[1152921525939520640] = val_1.y;
        mem[1152921525939520644] = val_1.z;
        UnityEngine.Vector3 val_2 = this.secondPlayer.localPosition;
        this.丈丝丆一丞丕下丗上 = val_2;
        mem[1152921525939520652] = val_2.y;
        mem[1152921525939520656] = val_2.z;
    }
    private void Update()
    {
        float val_10 = (float)UnityEngine.Screen.width;
        val_10 = val_10 / (float)UnityEngine.Screen.height;
        val_10 = val_10 + (-1.333333f);
        float val_3 = this.multipler * val_10;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_3);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丛丌且不业丙丟七世, y = V11.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.firstPlayer.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_3);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丈丝丆一丞丕下丗上, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        this.secondPlayer.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    public DuelPlayersPosition()
    {
        this.multipler = 2f;
    }

}
