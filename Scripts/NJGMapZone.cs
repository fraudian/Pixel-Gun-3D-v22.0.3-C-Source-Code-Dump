using UnityEngine;
public class NJGMapZone : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.List<NJGMapZone> list;
    public string triggerTag;
    public string zone;
    public string level;
    public int colliderRadius;
    public bool generateOnTrigger;
    private UnityEngine.SphereCollider mCollider;
    private NJG.NJGMapBase 丞丁丑丏丄丏七丂不;
    
    // Properties
    public UnityEngine.Color 丑丞丈丗丄丙丟万丄 { get; }
    public UnityEngine.SphereCollider 下丛与丑丏丈一且上 { get; }
    
    // Methods
    public UnityEngine.Color get_color()
    {
        if(this.丞丁丑丏丄丏七丂不 == 0)
        {
                return UnityEngine.Color.white;
        }
        
        if(this.丞丁丑丏丄丏七丂不 != null)
        {
                return this.丞丁丑丏丄丏七丂不.GetZoneColor(丈丘丝一丗下丈丐不:  this.level, 业丂万丈丝七一与专:  this.zone);
        }
        
        return this.丞丁丑丏丄丏七丂不.GetZoneColor(丈丘丝一丗下丈丐不:  this.level, 业丂万丈丝七一与专:  this.zone);
    }
    public UnityEngine.SphereCollider get_zoneCollider()
    {
        UnityEngine.SphereCollider val_6;
        UnityEngine.SphereCollider val_2 = this.gameObject.GetComponent<UnityEngine.SphereCollider>();
        this.mCollider = val_2;
        if(val_2 != 0)
        {
            goto label_4;
        }
        
        val_6 = this.gameObject.AddComponent<UnityEngine.SphereCollider>();
        this.mCollider = val_6;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_6 = this.mCollider;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_6.isTrigger = true;
        return (UnityEngine.SphereCollider)this.mCollider;
    }
    private void Awake()
    {
        this.丞丁丑丏丄丏七丂不 = NJG.NJGMapBase.instance;
        this.zoneCollider.radius = (float)this.colliderRadius;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        if((丆丛丂丝丄世且丛丕.CompareTag(tag:  this.triggerTag)) == false)
        {
                return;
        }
        
        if(this.丞丁丑丏丄丏七丂不 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_3 = this.color;
        this.丞丁丑丏丄丏七丂不.zoneColor = val_3;
        mem2[0] = val_3.g;
        mem2[0] = val_3.b;
        mem2[0] = val_3.a;
        this.丞丁丑丏丄丏七丂不.worldName = this.zone;
        if(this.generateOnTrigger == false)
        {
                return;
        }
        
        NJG.NJGMapBase.instance.GenerateMap();
    }
    private void OnEnable()
    {
        null = null;
        NJGMapZone.list.Add(item:  this);
    }
    private void OnDisable()
    {
        null = null;
        bool val_1 = NJGMapZone.list.Remove(item:  this);
    }
    public NJGMapZone()
    {
        this.colliderRadius = 10;
        this.triggerTag = "Player";
    }
    private static NJGMapZone()
    {
        NJGMapZone.list = new System.Collections.Generic.List<NJGMapZone>();
    }

}
