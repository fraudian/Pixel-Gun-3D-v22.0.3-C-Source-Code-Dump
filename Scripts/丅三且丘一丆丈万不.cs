using UnityEngine;
internal class 丅三且丘一丆丈万不 : 不丘丄丝丗丒丙一丌
{
    // Fields
    private Rocket 丈丐丌丟不丞丆丄丑;
    
    // Methods
    internal 丅三且丘一丆丈万不(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
    
    }
    internal void 东与一三丁七丕丑丁(Rocket 丁丂丏与丗上丗一丆)
    {
        this.丈丐丌丟不丞丆丄丑 = 丁丂丏与丗上丗一丆;
        丁丂丏与丗上丗一丆.丛丈丁丄东东东丏一 = new System.Action(object:  this, method:  System.Void 丅三且丘一丆丈万不::丅丕世丄万与且丂丅());
    }
    protected void 丈丛下丌丗丑下万丆()
    {
        if(this.丈丐丌丟不丞丆丄丑 == 0)
        {
                return;
        }
        
        this.丈丐丌丟不丞丆丄丑.丄丕万丄丐万七丅丈();
    }
    private void 丅丕世丄万与且丂丅()
    {
        this.丈丐丌丟不丞丆丄丑 = 0;
    }
    internal override void 丛三丒丄且丘万丟丘()
    {
        this.丛三丒丄且丘万丟丘();
        this.丈丛下丌丗丑下万丆();
    }
    internal virtual void 上东业丛丏丗丑万万(float 丂三丟丂丈丐丆丗丟)
    {
    
    }
    internal virtual void 丞专一丙丁丒万三丏(WeaponSounds 丌丝下丄业一丄不三)
    {
    
    }
    internal virtual void 万丒一万丌丆丏丈不()
    {
    
    }
    internal UnityEngine.Vector3 丁丁丏七丂丛丂丟丅()
    {
        float val_9;
        var val_15;
        var val_16;
        float val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = null;
        val_15 = null;
        val_16 = UnityEngine.Screen.height;
        float val_5 = (float)UnityEngine.Screen.width * 0.5f;
        val_17 = 0f;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_16 = 1152921505074044928;
            val_18 = null;
            val_18 = null;
            float val_16 = (float)UnityEngine.Screen.height;
            float val_15 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_15 = 1f - val_15;
            val_15 = val_15 * val_16;
            val_17 = val_15 * 0.5f;
        }
        
        val_16 = ((float)val_16 * 0.5f) + val_17;
        UnityEngine.Ray val_7 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_19 = null;
        val_19 = null;
        val_20 = null;
        val_20 = null;
        UnityEngine.Vector3 val_12 = 东丟丕下丏下丝且丁().position;
        UnityEngine.Vector3 val_13 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9, y = 0f, z = 0f}, d:  val_13.z);
        return new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }

}
