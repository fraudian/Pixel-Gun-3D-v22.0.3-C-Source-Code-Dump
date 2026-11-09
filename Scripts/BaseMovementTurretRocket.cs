using UnityEngine;
internal class BaseMovementTurretRocket : PGBehaviour
{
    // Fields
    private bool rotateToMoveDirection;
    protected UnityEngine.Rigidbody 丛三万上丌丈丟丛丑;
    protected UnityEngine.Transform target;
    protected float speed;
    
    // Methods
    private void Awake()
    {
        this.丛三万上丌丈丟丛丑 = this.GetComponent<UnityEngine.Rigidbody>();
    }
    internal virtual void SetTarget(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.target = 丞下万上三丘上与专;
    }
    private void Update()
    {
        goto typeof(BaseMovementTurretRocket).__il2cppRuntimeField_178;
    }
    protected virtual void 世丙丟丗丆丂东且三()
    {
        this.专丄下丑上丂东丛丐();
    }
    private void 专丄下丑上丂东丛丐()
    {
        if(this.rotateToMoveDirection == false)
        {
                return;
        }
        
        if(this.丛三万上丌丈丟丛丑 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.丛三万上丌丈丟丛丑.velocity;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    internal virtual void 丐且丞丕丞三丏丌丄(UnityEngine.Vector3 丞下万上三丘上与专, float 丟丞一专丕三东丗一, float 丌七丒世丄上丞丞丁)
    {
    
    }
    internal virtual void 丐且丞丕丞三丏丌丄(UnityEngine.Transform 丞下万上三丘上与专, float 丟丞一专丕三东丗一)
    {
    
    }
    internal virtual void 丐且丞丕丞三丏丌丄(UnityEngine.Transform 丞下万上三丘上与专, float 丟丞一专丕三东丗一, UnityEngine.Vector3 丏丄业丆业丅且丏丗)
    {
    
    }
    internal virtual void 丝丏丗丘丞丄丘丅且(float 丟丞一专丕三东丗一)
    {
        this.speed = 丟丞一专丕三东丗一;
    }
    public BaseMovementTurretRocket()
    {
    
    }

}
