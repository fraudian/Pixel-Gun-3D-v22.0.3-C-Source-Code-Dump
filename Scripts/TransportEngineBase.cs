using UnityEngine;
public abstract class TransportEngineBase : PGBehaviour
{
    // Fields
    public bool extrapolationSync;
    public float TouchDeadZone;
    public float TouchLerpV;
    public float TouchLerpH;
    protected int 下丅世丞丝丛丄一丞;
    protected float 上与丝不上丑上丛业;
    protected PhotonView 丅丏三七丁丑丞丄丏;
    
    // Properties
    internal virtual float 丕丟一东三丏丝丞丞 { get; }
    internal abstract float 上丛丕丏东不丝丛三 { get; }
    
    // Methods
    internal virtual float 东万丝丞丄丐丕丌万()
    {
        if(UnityEngine.Time.frameCount == this.下丅世丞丝丛丄一丞)
        {
                return (float)val_4.x;
        }
        
        this.下丅世丞丝丛丄一丞 = UnityEngine.Time.frameCount;
        UnityEngine.Vector3 val_4 = this.七上不且且丑丂丟东().velocity;
        this.上与丝不上丑上丛业 = val_4.x;
        return (float)val_4.x;
    }
    internal abstract float 丟不丑丈丆丏一丐丁(); // 0
    protected virtual void Awake()
    {
        this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
    }
    protected TransportEngineBase()
    {
        this.TouchDeadZone = 0.4f;
        this.TouchLerpV = 5.510186E-41f;
        this.TouchLerpH = 0.3f;
    }

}
