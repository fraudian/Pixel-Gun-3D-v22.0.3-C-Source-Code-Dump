using UnityEngine;
internal sealed class SniperShotBotComponent : DelayAttackBotComponent
{
    // Fields
    private UnityEngine.GameObject halo;
    private UnityEngine.Transform rayTransform;
    private UnityEngine.LineRenderer 业下丘七丂上丈丌丁;
    private UnityEngine.Vector3 不不七三丒丁丑丂业;
    private float laserRotateSpeed;
    
    // Methods
    internal override void 上丛丌丆丑上七世三()
    {
        this.上丛丌丆丑上七世三();
        this.业下丘七丂上丈丌丁 = this.rayTransform.GetComponent<UnityEngine.LineRenderer>();
    }
    internal override void 且丁丄丌丐丄东丁世()
    {
        this.且丁丄丌丐丄东丁世();
    }
    internal override void SetTarget(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.SetTarget(丞下万上三丘上与专:  丞下万上三丘上与专);
    }
    internal override void 专丅丟丏丂丅东丑万()
    {
        this.专丅丟丏丂丅东丑万();
        this.丟丕丂丝丈东万丁丏(丏业丟一东丂东丘丛:  true);
    }
    internal override void 丆丌丙万与丛万丝世()
    {
        this.丆丌丙万与丛万丝世();
        this.丟丕丂丝丈东万丁丏(丏业丟一东丂东丘丛:  false);
    }
    internal override void 与下且专丌业世丆丁()
    {
    
    }
    internal override void 丁丟丁世丐丅上丄万()
    {
        this.丁丟丁世丐丅上丄万();
    }
    private void Update()
    {
        if(this.rayTransform.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.上丘丂丑万且下与丟(不七丗丘丐丆丛与丟:  true);
    }
    private void 丟丕丂丝丈东万丁丏(bool 丏业丟一东丂东丘丛)
    {
        UnityEngine.Transform val_6;
        if(this.halo != 0)
        {
                this.halo.SetActive(value:  丏业丟一东丂东丘丛);
        }
        
        val_6 = this.rayTransform;
        if(val_6 != 0)
        {
            goto label_7;
        }
        
        if(丏业丟一东丂东丘丛 == false)
        {
                return;
        }
        
        label_11:
        this.上丘丂丑万且下与丟(不七丗丘丐丆丛与丟:  false);
        return;
        label_7:
        val_6 = this.rayTransform.gameObject;
        val_6.SetActive(value:  丏业丟一东丂东丘丛);
        if(丏业丟一东丂东丘丛 == true)
        {
            goto label_11;
        }
    
    }
    private void 上丘丂丑万且下与丟(bool 不七丗丘丐丆丛与丟 = True)
    {
        UnityEngine.LineRenderer val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        val_18 = this;
        UnityEngine.Vector3 val_1 = this.rayTransform.position;
        this.业下丘七丂上丈丌丁.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_2 = this.rayTransform.position;
        val_19 = val_2.x;
        val_20 = val_2.z;
        val_21 = val_19;
        val_22 = val_2.y;
        val_23 = val_20;
        this.业下丘七丂上丈丌丁.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
        if(this.业下丘七丂上丈丌丁 == 0)
        {
                return;
        }
        
        if(不七丗丘丐丆丛与丟 != false)
        {
                UnityEngine.Vector3 val_4 = 不七丗丘丐丆丛与丟.position;
            val_21 = this.不不七三丒丁丑丂业;
            val_22 = val_2.y;
            val_23 = val_20;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  this.laserRotateSpeed * UnityEngine.Time.deltaTime);
        }
        else
        {
                UnityEngine.Vector3 val_8 = 不七丗丘丐丆丛与丟.position;
        }
        
        this.不不七三丒丁丑丂业 = val_8;
        mem[1152921536456498204] = val_8.y;
        mem[1152921536456498208] = val_8.z;
        UnityEngine.Vector3 val_9 = this.rayTransform.position;
        val_24 = 1152921504838316032;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_19 = val_10.x;
        val_20 = val_10.z;
        UnityEngine.Vector3 val_11 = this.rayTransform.position;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, direction:  new UnityEngine.Vector3() {x = val_19, y = val_10.y, z = val_20}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
        {
                return;
        }
        
        val_19 = val_11.x;
        float val_13 = 0.targetValue;
        val_13 = val_19 - val_13;
        if(val_13 >= 0)
        {
                return;
        }
        
        val_18 = this.业下丘七丂上丈丌丁;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.65f);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = 0.5f, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        val_19 = val_17.x;
        val_20 = val_17.z;
        val_18.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_19, y = val_17.y, z = val_20});
    }
    public SniperShotBotComponent()
    {
        this.laserRotateSpeed = 10f;
    }

}
