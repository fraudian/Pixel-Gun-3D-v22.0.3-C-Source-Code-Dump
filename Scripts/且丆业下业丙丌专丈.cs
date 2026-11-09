using UnityEngine;
private sealed class Rocket.且丆业下业丙丌专丈
{
    // Fields
    public UnityEngine.Vector3 丙七丝丄上七丞丅丐;
    
    // Methods
    public Rocket.且丆业下业丙丌专丈()
    {
    
    }
    internal int 下丄七东世三东丑三(UnityEngine.RaycastHit 丁下丗七丟丗丞丁丐, UnityEngine.RaycastHit 专丟丗丗丈丅丙七三)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = this.丙七丝丄上七丞丅丐, y = V11.16B, z = V10.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.丙七丝丄上七丞丅丐, y = V11.16B, z = V10.16B});
        val_2.x = val_1.x - val_2.x;
        return (int)(val_2.x <= 0f) ? ((val_2.x != 0f) ? -1 : 0) : (0 + 1);
    }

}
