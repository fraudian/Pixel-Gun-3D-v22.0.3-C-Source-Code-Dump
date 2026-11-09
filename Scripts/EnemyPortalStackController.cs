using UnityEngine;
public class EnemyPortalStackController : MonoBehaviour
{
    // Fields
    internal static EnemyPortalStackController 丄丞丁丈与业上丞丟;
    private EnemyPortal[] _portals;
    private int 不丛三三专丛一万丝;
    
    // Methods
    private void Awake()
    {
        EnemyPortalStackController.丄丞丁丈与业上丞丟 = this;
    }
    private void Start()
    {
        null = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public EnemyPortal GetPortal()
    {
        EnemyPortal[] val_1;
        var val_2;
        int val_3;
        int val_4;
        val_1 = this._portals;
        if((val_1 == null) || (this._portals.Length == 0))
        {
            goto label_1;
        }
        
        val_2 = this;
        val_3 = this.不丛三三专丛一万丝 + 1;
        this.不丛三三专丛一万丝 = val_3;
        goto label_2;
        label_1:
        this.丘东下专丑丁七丟丌();
        val_2 = this;
        val_1 = val_1;
        val_3 = this.不丛三三专丛一万丝 + 1;
        this.不丛三三专丛一万丝 = val_3;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        label_2:
        if(val_3 < this._portals.Length)
        {
                val_4 = this.不丛三三专丛一万丝;
        }
        else
        {
                val_4 = 0;
            this.不丛三三专丛一万丝 = 0;
        }
        
        return (EnemyPortal)this._portals[0];
        label_3:
    }
    private void 丘东下专丑丁七丟丌()
    {
        var val_5;
        T[] val_1 = this.GetComponentsInChildren<EnemyPortal>(includeInactive:  true);
        val_5 = 0;
        this._portals = val_1;
        goto label_1;
        label_9:
        T val_5 = val_1[0];
        if(val_5.gameObject.activeInHierarchy != false)
        {
                val_5.gameObject.SetActive(value:  false);
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < val_1.Length)
        {
            goto label_9;
        }
    
    }
    public EnemyPortalStackController()
    {
    
    }

}
