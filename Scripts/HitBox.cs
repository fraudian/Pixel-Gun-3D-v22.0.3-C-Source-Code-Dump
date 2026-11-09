using UnityEngine;
public class HitBox : MonoBehaviour
{
    // Fields
    internal HitBox.七丂丞丛不丗丑与丞 bodyPart;
    internal UnityEngine.MonoBehaviour owner;
    private bool isTargetingCollider;
    private 丅丙上七上一丐不下 <丟丟且丄丅丈丕业七>k__BackingField;
    
    // Properties
    internal 丅丙上七上一丐不下 丂且丁一七七丆专东 { get; set; }
    
    // Methods
    internal 丅丙上七上一丐不下 业丒丁与世丘丕专丝()
    {
        return (丅丙上七上一丐不下)this.<丟丟且丄丅丈丕业七>k__BackingField;
    }
    private void 丒丒一专丞丗丙丅上(丅丙上七上一丐不下 丙业与丙丗丝不丈东)
    {
        this.<丟丟且丄丅丈丕业七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        if(this.owner == 0)
        {
            goto label_3;
        }
        
        this.<丟丟且丄丅丈丕业七>k__BackingField = this.owner;
        if(this.owner == null)
        {
            goto label_4;
        }
        
        丘丛丞且一丅丁丏丐.上丌丈丌丘万东世丐(不丂丅丁且丆东东丂:  this.transform, 万丗且且丒且丏丙世:  this);
        if(this.isTargetingCollider == false)
        {
                return;
        }
        
        丘丛丞且一丅丁丏丐.丗丂丈三丑丟三与三(丞下万上三丘上与专:  this.owner.transform, 且丙与丏下丅丐世丑:  this.GetComponent<UnityEngine.Collider>());
        return;
        label_3:
        this.<丟丟且丄丅丈丕业七>k__BackingField = 0;
        label_4:
        UnityEngine.Debug.LogError(message:  "HitBox: Owner Damageable is NULL!", context:  this.gameObject);
    }
    private void OnDestroy()
    {
        if((this.<丟丟且丄丅丈丕业七>k__BackingField) == null)
        {
                return;
        }
        
        丘丛丞且一丅丁丏丐.专丝且丐上东且业丙(上丛丂三上与丂丕丑:  this.transform);
    }
    internal static 丅丙上七上一丐不下 丁且丑丏一丈丛丑一(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        丅丙上七上一丐不下 val_24;
        UnityEngine.Object val_25;
        val_24 = 0;
        if(且丙与丏下丅丐世丑 == 0)
        {
                return val_24;
        }
        
        if((丘丛丞且一丅丁丏丐.丂丅丐世上不丐丏丙(且丙与丏下丅丐世丑:  且丙与丏下丅丐世丑)) != null)
        {
                return val_24;
        }
        
        if((丘丛丞且一丅丁丏丐.业下专丂丌丄七丆丞(上丛丂三上与丂丕丑:  且丙与丏下丅丐世丑.transform)) != 0)
        {
                val_24 = val_4.<丟丟且丄丅丈丕业七>k__BackingField;
            return val_24;
        }
        
        if((且丙与丏下丅丐世丑.transform.parent == 0) || ((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  且丙与丏下丅丐世丑.transform.parent)) == null))
        {
            goto label_23;
        }
        
        if(且丙与丏下丅丐世丑.transform.parent != null)
        {
            goto label_35;
        }
        
        goto label_27;
        label_23:
        if((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  且丙与丏下丅丐世丑.transform.root)) == null)
        {
            goto label_32;
        }
        
        if(且丙与丏下丅丐世丑.transform.root != null)
        {
            goto label_35;
        }
        
        label_27:
        label_35:
        val_25 = 0.gameObject;
        goto label_36;
        label_32:
        val_25 = 0;
        label_36:
        if(val_25 != 0)
        {
                return 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_25.transform);
        }
        
        val_25 = 且丙与丏下丅丐世丑.transform.gameObject;
        return 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_25.transform);
    }
    internal static HitBox.七丂丞丛不丗丑与丞 丁丞与丗不丈丟下丏(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        七丂丞丛不丗丑与丞 val_7;
        if(且丙与丏下丅丐世丑 == 0)
        {
                val_7 = 0;
            return (七丂丞丛不丗丑与丞)val_7;
        }
        
        if((丘丛丞且一丅丁丏丐.业下专丂丌丄七丆丞(上丛丂三上与丂丕丑:  且丙与丏下丅丐世丑.transform)) != 0)
        {
                val_7 = val_3.bodyPart;
            return (七丂丞丛不丗丑与丞)val_7;
        }
        
        if((System.String.op_Equality(a:  且丙与丏下丅丐世丑.name, b:  "HeadCollider")) != false)
        {
                val_7 = 2;
            return (七丂丞丛不丗丑与丞)val_7;
        }
        
        val_7 = 1;
        return (七丂丞丛不丗丑与丞)val_7;
    }
    public HitBox()
    {
        this.bodyPart = 1;
    }

}
