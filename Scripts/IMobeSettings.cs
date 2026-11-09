using UnityEngine;
public abstract class IMobeSettings : PGBehaviour
{
    // Fields
    public float speedWalk;
    public float speedChasing;
    public float health;
    public float agroZone;
    public float splash;
    public UnityEngine.Vector3 scale;
    protected float 丝丄丄东丅万丆一与;
    
    // Methods
    internal abstract float 业丂丛丟上且丂东丂(object[] 丗专丆万丏万丂丂丆); // 0
    internal abstract bool 七不一业丁丑专丝世(); // 0
    internal abstract void 丘上丐世丆丑且丞丒(string 丒丘丏上丙丟丑丕丈); // 0
    internal void 丘丛丞东丞丝丄丕丕(float 丏丑东丕丑丌丒丄且)
    {
        this.丝丄丄东丅万丆一与 = 丏丑东丕丑丌丒丄且;
    }
    protected IMobeSettings()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.scale = val_1;
        mem[1152921540126347440] = val_1.y;
        mem[1152921540126347444] = val_1.z;
        this.丝丄丄东丅万丆一与 = 1f;
    }

}
