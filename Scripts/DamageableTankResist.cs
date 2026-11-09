using UnityEngine;
internal sealed class DamageableTankResist : DamageableObjectResist
{
    // Fields
    private float 丏丆丘丟丙专丆专东;
    
    // Methods
    internal void 丅丑丒丘丌业专丕丙(float 丛丏下万丛丌丟丛且)
    {
        this.丏丆丘丟丙专丆专东 = 丛丏下万丛丌丟丛且;
    }
    internal float 丄万丌丂且一丒万丅()
    {
        return (float)this.丏丆丘丟丙专丆专东;
    }
    internal override float 丈七三丙丅丆万下丞(丅丙上七上一丐不下 丒一丒万丆丌不一一)
    {
        return (float)this.丏丆丘丟丙专丆专东;
    }
    public DamageableTankResist()
    {
        this.丏丆丘丟丙专丆专东 = 1f;
        val_1 = new PGBehaviour();
    }

}
