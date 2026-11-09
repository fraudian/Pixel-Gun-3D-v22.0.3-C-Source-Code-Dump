using UnityEngine;
internal class PlayerDetector : MonoBehaviour
{
    // Fields
    public float radius;
    public float height;
    private bool 三丟不丑东丈且丝丑;
    private System.Action<bool> 专丈下丐不业万七丗;
    
    // Properties
    public bool 三三丂丌丙业三丝丈 { get; }
    
    // Methods
    internal void 丐丅下丛丙不丐丂丏(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专丈下丐不业万七丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丈下丐不业万七丗 != 1152921538713349576);
    
    }
    internal void 东下丗丘七丞丟与不(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专丈下丐不业万七丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丈下丐不业万七丗 != 1152921538713486152);
    
    }
    internal void Reset()
    {
        this.三丟不丑东丈且丝丑 = false;
    }
    private void Update()
    {
        goto typeof(PlayerDetector).__il2cppRuntimeField_168;
    }
    public bool get_isPlayerInDetectZone()
    {
        var val_15;
        var val_16;
        var val_17;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                val_16 = null;
            val_16 = null;
            UnityEngine.Vector3 val_3 = transform.position;
            float val_15 = val_3.y;
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_5.x, y:  val_7.z);
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.z);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            UnityEngine.Vector3 val_12 = this.transform.position;
            val_15 = val_15 - val_12.y;
            val_17 = 0;
            if(val_15 < 0f)
        {
                return (bool)val_17;
        }
        
            float val_16 = this.radius;
            val_16 = val_16 * val_16;
            if(val_10.x.sqrMagnitude > val_16)
        {
                return (bool)val_17;
        }
        
            var val_14 = (val_15 <= this.height) ? 1 : 0;
            return (bool)val_17;
        }
        
        val_17 = 0;
        return (bool)val_17;
    }
    protected virtual void 三丑下丆丂丅丟丄丐()
    {
        bool val_1 = this.isPlayerInDetectZone;
        var val_2 = (this.三丟不丑东丈且丝丑 == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        bool val_3 = val_1;
        this.三丟不丑东丈且丝丑 = val_3;
        if(this.专丈下丐不业万七丗 == null)
        {
                return;
        }
        
        this.专丈下丐不业万七丗.Invoke(obj:  val_3);
    }
    public PlayerDetector()
    {
        this.radius = 1.5f;
        this.height = 0f;
    }

}
