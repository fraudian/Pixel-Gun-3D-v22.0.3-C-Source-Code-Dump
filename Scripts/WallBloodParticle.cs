using UnityEngine;
public class WallBloodParticle : MonoBehaviour
{
    // Fields
    private float 丑丅三丗丌丞三丘丂;
    private float 丒且丑丝丝丑业丕世;
    public bool isUseMine;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.ParticleSystem myParticleSystem;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.万东万丆专丌丕丐丗 = val_1;
        val_1.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.myParticleSystem.enableEmission = false;
        this.gameObject.SetActive(value:  false);
    }
    public void StartShowParticle(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, bool 丁丈丄不且专丘与世)
    {
        this.isUseMine = 丁丈丄不且专丘与世;
        this.丑丅三丗丌丞三丘丂 = this.丒且丑丝丝丑业丕世;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w};
        this.myParticleSystem.enableEmission = true;
        this.gameObject.SetActive(value:  true);
    }
    private void Update()
    {
        if(this.丑丅三丗丌丞三丘丂 < 0)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丑丅三丗丌丞三丘丂 - val_1;
        this.丑丅三丗丌丞三丘丂 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.myParticleSystem.enableEmission = false;
        this.isUseMine = false;
        this = this.gameObject;
        this.SetActive(value:  false);
    }
    public WallBloodParticle()
    {
        this.丑丅三丗丌丞三丘丂 = -1f;
        this.丒且丑丝丝丑业丕世 = 7.346868E-41f;
    }

}
