using UnityEngine;
public class PropertyBinding : MonoBehaviour
{
    // Fields
    public PropertyReference source;
    public PropertyReference target;
    public PropertyBinding.丟世丆丕丌且七下丂 direction;
    public PropertyBinding.丒丟与一专世丐世丂 update;
    public bool editMode;
    private object 且且三丄丈专丒丅丛;
    
    // Methods
    private void Start()
    {
        this.UpdateTarget();
        if(this.update != 0)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Update()
    {
        if(this.update != 1)
        {
                return;
        }
        
        this.UpdateTarget();
    }
    private void LateUpdate()
    {
        if(this.update != 2)
        {
                return;
        }
        
        this.UpdateTarget();
    }
    private void FixedUpdate()
    {
        if(this.update != 3)
        {
                return;
        }
        
        this.UpdateTarget();
    }
    private void OnValidate()
    {
        if(this.source != null)
        {
                this.source.mField = 0;
            this.source.mProperty = 0;
        }
        
        if(this.target == null)
        {
                return;
        }
        
        this.target.mField = 0;
        this.target.mProperty = 0;
    }
    public void UpdateTarget()
    {
        PropertyReference val_11;
        object val_12;
        object val_13;
        val_11 = this;
        if(this.source == null)
        {
                return;
        }
        
        if(this.target == null)
        {
                return;
        }
        
        if(this.source.isValid == false)
        {
                return;
        }
        
        if(this.target.isValid == false)
        {
                return;
        }
        
        if(this.direction == 0)
        {
            goto label_6;
        }
        
        if(this.direction != 1)
        {
            goto label_7;
        }
        
        val_11 = this.target.丐下下丅与上东丙丑();
        val_12 = val_11;
        goto label_10;
        label_6:
        val_11 = this.target;
        val_13 = this.source.丐下下丅与上东丙丑();
        if(val_11 != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_7:
        if((System.Type.op_Equality(left:  this.source.东丝丒与三丐丏丛丛(), right:  this.target.东丝丒与三丐丏丛丛())) == false)
        {
                return;
        }
        
        val_13 = this.source.丐下下丅与上东丙丑();
        if((this.且且三丄丈专丒丅丛 != null) && ((this.且且三丄丈专丒丅丛 & 1) != 0))
        {
                object val_9 = this.target.丐下下丅与上东丙丑();
            if((this.且且三丄丈专丒丅丛 & 1) == 0)
        {
            goto label_26;
        }
        
            return;
        }
        
        label_26:
        this.且且三丄丈专丒丅丛 = val_13;
        label_13:
        val_12 = val_13;
        label_10:
        bool val_10 = this.target.丅专下万丕丑丆丅丝(丙业与丙丗丝不丈东:  val_12);
    }
    public PropertyBinding()
    {
        this.update = 1;
        this.editMode = 1;
    }

}
