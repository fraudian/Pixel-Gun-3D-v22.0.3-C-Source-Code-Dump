using UnityEngine;
internal sealed class FortFieldSetupUtility : PGBehaviour
{
    // Fields
    private UnityEngine.Transform fieldCameraTransform;
    internal static FortFieldSetupUtility 丄丘七三上丕世丞业;
    private UnityEngine.GameObject buttonUtility;
    internal UnityEngine.Transform placeForTurretInfo;
    
    // Methods
    private void Awake()
    {
        FortFieldSetupUtility.丄丘七三上丕世丞业 = this;
    }
    private void Start()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonUtility, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_4 = this.fieldCameraTransform.forward;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.丌丟丄业且三丛丕丄().LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    internal void 丌丄丛丒丙丄丟丞丘(UnityEngine.Transform 七丁万不丐丂上世万)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonUtility, 丏业丟一东丂东丘丛:  true);
        if(this == 0)
        {
                return;
        }
        
        this.丌丟丄业且三丛丕丄().parent = 七丁万不丐丂上世万;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    internal void 丛丁丗一丛万东下东()
    {
        this.丌丟丄业且三丛丕丄().parent = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonUtility, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDestroy()
    {
        FortFieldSetupUtility.丄丘七三上丕世丞业 = 0;
    }
    public FortFieldSetupUtility()
    {
    
    }

}
