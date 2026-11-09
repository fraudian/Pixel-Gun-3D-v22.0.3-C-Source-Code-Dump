using UnityEngine;
[Serializable]
public class NJGMapBase.MapZone
{
    // Fields
    public string type;
    public UnityEngine.Color color;
    public float fadeOutAfterDelay;
    public bool folded;
    public int depth;
    public bool deleteRequest;
    
    // Methods
    public NJGMapBase.MapZone()
    {
        this.type = "New Zone";
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921541458736844] = val_1.g;
        mem[1152921541458736848] = val_1.b;
        mem[1152921541458736852] = val_1.a;
        this.fadeOutAfterDelay = 3f;
        this.folded = true;
    }

}
