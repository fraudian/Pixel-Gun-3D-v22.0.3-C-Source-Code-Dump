using UnityEngine;
public class DamageWeaponCollider : MonoBehaviour
{
    // Fields
    public bool isExplosion;
    public bool isOwner;
    public UnityEngine.Animation currentAnim;
    private static string 上与丕专丄且丙丝专;
    private UnityEngine.Collider 东丂业不世丗东不丝;
    private float 不丆且不丆丗一丘不;
    public bool isChargeOrbital;
    private System.Collections.Generic.List<UnityEngine.GameObject> tempDamagingOwners;
    private System.Collections.Generic.List<UnityEngine.Coroutine> 东丟一丙东丕万万丘;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        this.东丂业不世丗东不丝 = val_1;
        if(this.isExplosion != false)
        {
                if(this.isChargeOrbital == false)
        {
                return;
        }
        
        }
        
        val_1.enabled = false;
    }
    private void Update()
    {
        var val_8;
        var val_9;
        if(this.isExplosion != false)
        {
                if(this.isChargeOrbital == false)
        {
                return;
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        if((this.transform.root.gameObject & 1) == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        bool val_4 = this.currentAnim.IsPlaying(name:  DamageWeaponCollider.上与丕专丄且丙丝专);
        if(val_4 ^ this.东丂业不世丗东不丝.enabled == false)
        {
                return;
        }
        
        this.东丂业不世丗东不丝.enabled = val_4;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        this.东丟一丙东丕万万丘.Add(item:  this.StartCoroutine(routine:  this.丟下丘三东三上且且(丐且丟丂且专丄丕三:  丘丛丏丘丝七世七丅)));
    }
    private void OnEnable()
    {
        this.东丂业不世丗东不丝.enabled = true;
        this.tempDamagingOwners.Clear();
        this.东丟一丙东丕万万丘.Clear();
    }
    private void OnDisable()
    {
        if(this.isExplosion != false)
        {
                this.isOwner = false;
        }
        
        if(this.东丟一丙东丕万万丘 == null)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_1 = this.东丟一丙东丕万万丘.GetEnumerator();
        label_5:
        if(((-199081464) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == null)
        {
            goto label_5;
        }
        
        this.StopCoroutine(routine:  val_2);
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.东丟一丙东丕万万丘 != null)
        {
            goto label_10;
        }
        
        label_2:
        label_10:
        0.Clear();
    }
    private System.Collections.IEnumerator 丟下丘三东三上且且(UnityEngine.Collider 丐且丟丂且专丄丕三)
    {
        DamageWeaponCollider.三丅丏丛七丒且专丟 val_1 = new DamageWeaponCollider.三丅丏丛七丒且专丟();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丐且丟丂且专丄丕三 = 丐且丟丂且专丄丕三;
        return (System.Collections.IEnumerator)val_1;
    }
    public DamageWeaponCollider()
    {
        this.不丆且不丆丗一丘不 = 0.2f;
        this.tempDamagingOwners = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.东丟一丙东丕万万丘 = new System.Collections.Generic.List<UnityEngine.Coroutine>();
    }
    private static DamageWeaponCollider()
    {
        DamageWeaponCollider.上与丕专丄且丙丝专 = "Shoot";
    }

}
