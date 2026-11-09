using UnityEngine;
internal class ShaderTestCubeController : MonoBehaviour, 丅丙上七上一丐不下
{
    // Fields
    private UnityEngine.TextMesh text;
    private UnityEngine.Shader[] shaders;
    private int 丁不丗丄丗东且专丘;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    
    // Methods
    private void Awake()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void Update()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        UnityEngine.Quaternion val_4 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.rotation;
        this.text.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    private void 丆丕丐丁丝丝不丒万(int 丁下东三丞东丐一丑)
    {
        UnityEngine.TextMesh val_6;
        if((丁下东三丞东丐一丑 & 2147483648) != 0)
        {
                return;
        }
        
        if(this.shaders == null)
        {
                return;
        }
        
        if(this.shaders.Length <= 丁下东三丞东丐一丑)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.Renderer>().material.shader = this.shaders[(long)丁下东三丞东丐一丑];
        val_6 = this.text;
        this = System.String.Format(format:  "{0} ({1}/{2})", arg0:  this.shaders[(long)丁下东三丞东丐一丑].name, arg1:  丁下东三丞东丐一丑 + 1, arg2:  this.shaders.Length);
        val_6.text = this;
    }
    private void 丌七丑七丒丕丕东上()
    {
        int val_2;
        int val_1 = this.丁不丗丄丗东且专丘 + 1;
        this.丁不丗丄丗东且专丘 = val_1;
        if(val_1 < this.shaders.Length)
        {
                val_2 = this.丁不丗丄丗东且专丘;
        }
        else
        {
                val_2 = 0;
            this.丁不丗丄丗东且专丘 = 0;
        }
        
        this.丆丕丐丁丝丝不丒万(丁下东三丞东丐一丑:  0);
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public UnityEngine.Transform get_transform()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    public float get_maxHealth()
    {
        return 100f;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.丌七丑七丒丕丕东上();
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
    }
    public bool IsDead()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public ShaderTestCubeController()
    {
        this.丁不丗丄丗东且专丘 = 0;
    }

}
