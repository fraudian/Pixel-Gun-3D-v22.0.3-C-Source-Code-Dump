using UnityEngine;
internal sealed class Caterpillar : PGBehaviour
{
    // Fields
    private UnityEngine.Transform[] wheels;
    private UnityEngine.Transform[] bones;
    private UnityEngine.Vector3[] 丒丂万业上丒丐万丗;
    private UnityEngine.Renderer caterpillarObjectRenderer;
    private string caterpillarSpeedParamName;
    private int caterpillarMaterialIndex;
    private float caterpillarVisualRotationSpeedIndex;
    private float minDeltaWheelsForVisual;
    private float tempFloat;
    private VehicleView 丂丌一丙七丐不丝丈;
    private float 与万丑丕三丁丑丄业;
    
    // Methods
    private void Start()
    {
    
    }
    private void Awake()
    {
        UnityEngine.Vector3[] val_10;
        var val_11;
        val_10 = new UnityEngine.Vector3[0];
        this.丒丂万业上丒丐万丗 = val_10;
        val_11 = 0;
        goto label_2;
        label_14:
        UnityEngine.Vector3 val_2 = this.wheels[0].position;
        UnityEngine.Vector3 val_3 = this.bones[0].position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        var val_5 = this.丒丂万业上丒丐万丗 + (0 * 12);
        mem2[0] = val_4.x;
        mem2[0] = val_4.y;
        mem2[0] = val_4.z;
        val_10 = this.丒丂万业上丒丐万丗;
        val_11 = 1;
        label_2:
        if(val_11 < this.丒丂万业上丒丐万丗.Length)
        {
            goto label_14;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.gameObject.GetComponent<VehicleView>())) == false)
        {
                return;
        }
        
        this.丂丌一丙七丐不丝丈 = this.gameObject.GetComponent<VehicleView>();
    }
    private void Update()
    {
    
    }
    private void LateUpdate()
    {
        var val_7;
        UnityEngine.Transform val_8;
        float val_9;
        float val_11;
        val_7 = 0;
        goto label_1;
        label_9:
        val_8 = this.wheels[0];
        UnityEngine.Vector3 val_1 = val_8.position;
        val_9 = val_1.x;
        this.bones[0].position = new UnityEngine.Vector3() {x = val_9, y = val_1.y, z = val_1.z};
        val_7 = 1;
        label_1:
        if(val_7 < this.丒丂万业上丒丐万丗.Length)
        {
            goto label_9;
        }
        
        if(this.丂丌一丙七丐不丝丈 == 0)
        {
                return;
        }
        
        this.tempFloat = 0f;
        val_9 = this.丂丌一丙七丐不丝丈.deltaWheelPos;
        val_11 = this.minDeltaWheelsForVisual;
        if(System.Math.Abs(val_9) < val_11)
        {
                val_11 = this.tempFloat;
        }
        else
        {
                float val_4 = this.丂丌一丙七丐不丝丈.deltaWheelPos;
            this.tempFloat = val_4;
        }
        
        val_4 = val_4 * this.caterpillarVisualRotationSpeedIndex;
        val_4 = this.与万丑丕三丁丑丄业 + val_4;
        this.与万丑丕三丁丑丄业 = val_4;
        this.与万丑丕三丁丑丄业 = val_4;
        val_8 = this.caterpillarMaterialIndex;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.与万丑丕三丁丑丄业, y:  0f);
        this.caterpillarObjectRenderer.materials[val_8].mainTextureOffset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    public Caterpillar()
    {
        this.caterpillarVisualRotationSpeedIndex = -Infinityf;
        this.minDeltaWheelsForVisual = 1f;
    }

}
