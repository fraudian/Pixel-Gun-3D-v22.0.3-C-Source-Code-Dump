using UnityEngine;
public sealed class HoleScript : MonoBehaviour
{
    // Fields
    public float liveTime;
    public float maxliveTime;
    public bool isUseMine;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.ParticleSystem fireParticle;
    
    // Methods
    public void Init()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.万东万丆专丌丕丐丗 = val_1;
        val_1.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.gameObject.SetActive(value:  false);
    }
    public void StartShowHole(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, bool 丁丈丄不且专丘与世)
    {
        this.isUseMine = 丁丈丄不且专丘与世;
        this.liveTime = this.maxliveTime;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w};
        this.gameObject.SetActive(value:  true);
        this.fireParticle.Play();
    }
    private void Update()
    {
        if(this.liveTime < 0)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.liveTime - val_1;
        this.liveTime = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.万东万丆专丌丕丐丗)) == false)
        {
                return;
        }
        
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.isUseMine = false;
        this.fireParticle.Stop();
        this = this.gameObject;
        this.SetActive(value:  false);
    }
    public HoleScript()
    {
        this.liveTime = -1f;
        this.maxliveTime = 3f;
    }

}
