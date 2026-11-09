using UnityEngine;
internal interface 万丝丅丗且丒丝丌丟
{
    // Properties
    public abstract UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
    public abstract UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
    public abstract UnityEngine.Collider 丝且不七丂世丗下七 { get; }
    public abstract UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
    public abstract bool 丈丐丁不丙东世七丕 { get; }
    public abstract UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
    
    // Methods
    public abstract UnityEngine.Collider get_aimCollider(); // 0
    public abstract UnityEngine.Collider get_bodyAimCollider(); // 0
    public abstract UnityEngine.Collider get_headAimCollider(); // 0
    public abstract UnityEngine.Transform get_targetTransform(); // 0
    public abstract bool get_isTargetDead(); // 0
    public abstract UnityEngine.Vector3 get_currentTargetVelocity(); // 0

}
