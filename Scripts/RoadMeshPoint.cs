using UnityEngine;
public class RoadMeshPoint : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3[] vertices;
    public UnityEngine.Vector3[] hillVertices;
    public float width;
    
    // Methods
    public void GetPoints()
    {
        float val_78;
        float val_79;
        UnityEngine.Vector3 val_80;
        var val_81;
        float val_78 = this.width;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[2];
        this.vertices = val_1;
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        val_78 = val_78 * 0.5f;
        UnityEngine.Vector3 val_5 = this.transform.right;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_78);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_9 = this.transform.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_1[0] = val_10;
        val_1[0] = val_10.y;
        val_1[1] = val_10.z;
        UnityEngine.Vector3 val_12 = this.transform.localPosition;
        UnityEngine.Vector3 val_14 = this.transform.right;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_78);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_18 = this.transform.up;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        this.vertices[1] = val_19;
        this.vertices[1] = val_19.y;
        this.vertices[1] = val_19.z;
        UnityEngine.Vector3[] val_20 = new UnityEngine.Vector3[6];
        this.hillVertices = val_20;
        UnityEngine.Vector3 val_22 = this.transform.localPosition;
        UnityEngine.Vector3 val_24 = this.transform.right;
        float val_25 = val_78 + 4f;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  val_25);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_29 = this.transform.up;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  2f);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        val_20[0] = val_31;
        val_20[0] = val_31.y;
        val_20[1] = val_31.z;
        UnityEngine.Vector3 val_33 = this.transform.localPosition;
        UnityEngine.Vector3 val_35 = this.transform.right;
        float val_36 = val_78 + 1f;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  val_36);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        UnityEngine.Vector3 val_40 = this.transform.up;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  0.05f);
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
        this.hillVertices[1] = val_42;
        this.hillVertices[1] = val_42.y;
        this.hillVertices[1] = val_42.z;
        UnityEngine.Vector3 val_44 = this.transform.localPosition;
        UnityEngine.Vector3 val_46 = this.transform.right;
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  val_78);
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        this.hillVertices[2] = val_48;
        this.hillVertices[2] = val_48.y;
        this.hillVertices[2] = val_48.z;
        UnityEngine.Vector3 val_50 = this.transform.localPosition;
        UnityEngine.Vector3 val_52 = this.transform.right;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, d:  val_78);
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, b:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
        this.hillVertices[3] = val_54;
        this.hillVertices[3] = val_54.y;
        this.hillVertices[3] = val_54.z;
        UnityEngine.Vector3 val_56 = this.transform.localPosition;
        UnityEngine.Vector3 val_58 = this.transform.right;
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, d:  val_36);
        UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, b:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
        val_78 = val_60.z;
        UnityEngine.Vector3 val_62 = this.transform.up;
        UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, d:  0.05f);
        UnityEngine.Vector3 val_64 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_78}, b:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
        this.hillVertices[4] = val_64;
        this.hillVertices[4] = val_64.y;
        this.hillVertices[4] = val_64.z;
        UnityEngine.Vector3 val_66 = this.transform.localPosition;
        UnityEngine.Vector3 val_68 = this.transform.right;
        UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z}, d:  val_25);
        UnityEngine.Vector3 val_70 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z});
        UnityEngine.Vector3 val_72 = this.transform.up;
        UnityEngine.Vector3 val_73 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, d:  2f);
        UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z}, b:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z});
        val_79 = val_74.x;
        val_80 = val_74.z;
        val_81 = 0;
        this.hillVertices[5] = val_74;
        this.hillVertices[5] = val_74.y;
        this.hillVertices[5] = val_80;
        goto label_41;
        label_48:
        val_79 = 8.96831E-44f;
        val_80 = 0f;
        UnityEngine.Vector3 val_76 = this.transform.up;
        val_78 = val_76.y;
        UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = val_76.x, y = val_78, z = val_76.z});
        val_81 = 1;
        mem[32] = val_77.x;
        mem[36] = val_77.y;
        mem[40] = val_77.z;
        label_41:
        if(val_81 < this.hillVertices.Length)
        {
            goto label_48;
        }
    
    }
    public RoadMeshPoint()
    {
        this.width = 4f;
    }

}
