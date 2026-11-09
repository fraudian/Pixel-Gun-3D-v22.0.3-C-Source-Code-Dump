using UnityEngine;
public class HitParticle : MonoBehaviour
{
    // Fields
    private float 丑丅三丗丌丞三丘丂;
    public float maxliveTime;
    public bool isUseMine;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.ParticleSystem myParticleSystem;
    internal const float 东七丕世万丒业与丌 = 1.75;
    private static readonly UnityEngine.Color 丅丆万下上丏业不丂;
    private static readonly UnityEngine.Color 丒专不丁一丑与丆丂;
    private static readonly UnityEngine.Color 丄世丛丙丌丑三丆专;
    
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
        this.gameObject.SetActive(value:  true);
        this.isUseMine = 丁丈丄不且专丘与世;
        this.丑丅三丗丌丞三丘丂 = this.maxliveTime;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w};
        this.myParticleSystem.enableEmission = true;
    }
    public void StartShowParticle(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, bool 丁丈丄不且专丘与世, UnityEngine.Vector3 丙且一丛且东丛丗丟)
    {
        float val_1;
        this.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w}, 丁丈丄不且专丘与世:  丁丈丄不且专丘与世);
        if(this.万东万丆专丌丕丐丗.childCount < 1)
        {
                return;
        }
        
        this.myParticleSystem.transform.position = new UnityEngine.Vector3() {x = 丙且一丛且东丛丗丟.x, y = val_1, z = 丙且一丛且东丛丗丟.y};
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
    internal void 下七丙世上丄下丆丄(int 丗与丟上上丑专世丗)
    {
        MainModule val_1 = this.myParticleSystem.main;
        if(丗与丟上上丑专世丗 > 3)
        {
                return;
        }
        
        var val_3 = 106026512 + (丗与丟上上丑专世丗) << 2;
        val_3 = val_3 + 106026512;
        goto (106026512 + (丗与丟上上丑专世丗) << 2 + 106026512);
    }
    public HitParticle()
    {
        this.丑丅三丗丌丞三丘丂 = -1f;
        this.maxliveTime = 5.510186E-41f;
    }
    private static HitParticle()
    {
        HitParticle.丅丆万下上丏业不丂 = 0;
        HitParticle.丒专不丁一丑与丆丂 = 0;
        HitParticle.丅丆万下上丏业不丂.__il2cppRuntimeField_14 = 0;
        HitParticle.丅丆万下上丏业不丂.__il2cppRuntimeField_1C = 0;
        HitParticle.丄世丛丙丌丑三丆专 = 0;
        HitParticle.丅丆万下上丏业不丂.__il2cppRuntimeField_24 = 0;
        HitParticle.丅丆万下上丏业不丂.__il2cppRuntimeField_2C = 0;
    }

}
