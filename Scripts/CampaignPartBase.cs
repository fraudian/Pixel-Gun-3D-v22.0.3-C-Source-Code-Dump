using UnityEngine;
internal class CampaignPartBase : MonoBehaviour, 丅丙上七上一丐不下
{
    // Fields
    internal CampaignBase 且丗丕丆丂丆丁丄下;
    private BotChangeDamageMaterial[] 丒东丕丙且上不一丆;
    private int <专业丞不丟专专丐与>k__BackingField;
    private UnityEngine.Coroutine 丈七丗丙丕三万丗丌;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    
    // Methods
    private void Start()
    {
        this.丒东丕丙且上不一丆 = this.GetComponentsInChildren<BotChangeDamageMaterial>();
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
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
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专)
    {
        this.且丗丕丆丂丆丁丄下.丌丐万丛三上一与东(丞丈专下丈专业三丞:  丞丈专下丈专业三丞);
        if(this.丈七丗丙丕三万丗丌 != null)
        {
                this.StopCoroutine(routine:  this.丈七丗丙丕三万丗丌);
        }
        
        this.丈七丗丙丕三万丗丌 = this.StartCoroutine(routine:  this.丛丕丝且丘丕万丑万());
    }
    private System.Collections.IEnumerator 丛丕丝且丘丕万丑万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CampaignPartBase.丕世丒世不丏丏不业();
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.ApplyDamage(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒, 丐丟丘世丁三丕专专:  专不丑且不丏东丟丅);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return false;
    }
    public bool IsDead()
    {
        return (bool)(this.且丗丕丆丂丆丁丄下.世丙丟上丘上七万万 <= 0f) ? 1 : 0;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public float get_maxHealth()
    {
        if(this.且丗丕丆丂丆丁丄下 != null)
        {
                return (float)this.且丗丕丆丂丆丁丄下.maxHealth;
        }
        
        return (float)this.且丗丕丆丂丆丁丄下.maxHealth;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public CampaignPartBase()
    {
    
    }

}
