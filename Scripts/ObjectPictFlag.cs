using UnityEngine;
internal sealed class ObjectPictFlag : PGBehaviour
{
    // Fields
    public UnityEngine.Camera cameraToUse;
    public UnityEngine.Camera cam;
    public UnityEngine.Transform target;
    public UnityEngine.Vector3 posLabel;
    private UnityEngine.Transform 丝丈不丁丝上业丅丄;
    public bool isBaza;
    public FlagController myFlagController;
    
    // Methods
    private void LateUpdate()
    {
        var val_19 = null;
        this.cam = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 != 0)
        {
                this.丝丈不丁丝上业丅丄 = this.cam.transform;
        }
        
        if(this.target != 0)
        {
                if(this.cam != 0)
        {
            goto label_12;
        }
        
        }
        
        int val_5 = UnityEngine.Time.frameCount;
        var val_19 = 0;
        val_19 = val_19 + val_5;
        val_19 = (val_19 >> 5) + (val_19 >> 31);
        val_19 = val_5 - (val_19 * 60);
        if(val_19 == 0)
        {
                UnityEngine.Debug.Log(message:  "target == null");
        }
        
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_12:
        UnityEngine.Vector3 val_8 = this.target.position;
        this.posLabel = val_8;
        mem[1152921535460858148] = val_8.y;
        mem[1152921535460858152] = val_8.z;
        if(val_8.z >= 0f)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_21;
        }
        
        }
        
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_23;
        label_21:
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = this.posLabel, y = V9.16B, z = V10.16B};
        label_23:
        if((this.isBaza != false) && (this.myFlagController.isBaza != false))
        {
                if(this.myFlagController.flagModel.activeInHierarchy != false)
        {
                this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        if(this.isBaza == true)
        {
                return;
        }
        
        FlagController val_15 = this.target.parent.GetComponent<FlagController>();
        if(val_15.flagModel.activeInHierarchy == true)
        {
                return;
        }
        
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ObjectPictFlag()
    {
    
    }

}
