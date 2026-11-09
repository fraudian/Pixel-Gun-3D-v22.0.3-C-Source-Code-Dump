using UnityEngine;
public class CableCar : PGBehaviour
{
    // Fields
    public CableCarStarter startCollider;
    public CableCarEnder endCollider;
    public float cableStartSpeed;
    public float cableAcceleration;
    public float cableTopSpeed;
    public UnityEngine.LineRenderer ropeLine;
    private UnityEngine.Vector3 专专世丌七丞万丑丘;
    
    // Properties
    public UnityEngine.Vector3 七丝丑丐东丅丒丁丂 { get; }
    public UnityEngine.Vector3 丂七丅一一丒且万丕 { get; }
    public float 丏上万丅丏一不不丕 { get; }
    public UnityEngine.Vector3 万丛丞丂丘且三丈丈 { get; }
    
    // Methods
    private void Start()
    {
        this.丙世丟七丂丒丌下丈();
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  122)) == false)
        {
                return;
        }
        
        this.丙世丟七丂丒丌下丈();
    }
    public UnityEngine.Vector3 get_startPos()
    {
        if(this.startCollider != null)
        {
                return this.startCollider.一专东丅丅丄一丁七();
        }
        
        return this.startCollider.一专东丅丅丄一丁七();
    }
    public UnityEngine.Vector3 get_endPos()
    {
        if(this.startCollider != null)
        {
                return this.startCollider.下丏丟丁丌丒丝丘丝();
        }
        
        return this.startCollider.下丏丟丁丌丒丝丘丝();
    }
    public float get_length()
    {
        UnityEngine.Vector3 val_1 = this.endPos;
        UnityEngine.Vector3 val_2 = this.startPos;
        return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public UnityEngine.Vector3 get_moveVector()
    {
        UnityEngine.Vector3 val_1 = this.endPos;
        UnityEngine.Vector3 val_2 = this.startPos;
        return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    private void 丙世丟七丂丒丌下丈()
    {
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[2];
        UnityEngine.Vector3 val_2 = this.startPos;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.专专世丌七丞万丑丘, y = V11.16B, z = V10.16B});
        val_1[0] = val_3;
        val_1[0] = val_3.y;
        val_1[1] = val_3.z;
        UnityEngine.Vector3 val_4 = this.endPos;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.专专世丌七丞万丑丘, y = V11.16B, z = V10.16B});
        val_1[1] = val_5;
        val_1[2] = val_5.y;
        val_1[2] = val_5.z;
        this.ropeLine.SetPositions(positions:  val_1);
    }
    public CableCar()
    {
        this.专专世丌七丞万丑丘 = 0;
        mem[1152921525570877720] = 0;
    }

}
