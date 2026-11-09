using UnityEngine;
public class CullArea : MonoBehaviour
{
    // Fields
    private const int 三万丆不丅丐丕丂下 = 250;
    public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;
    public readonly byte FIRST_GROUP_ID;
    public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER;
    public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER;
    public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER;
    public UnityEngine.Vector2 Center;
    public UnityEngine.Vector2 Size;
    public UnityEngine.Vector2[] Subdivisions;
    public int NumberOfSubdivisions;
    private int <且丐上丘丛丙丂世丄>k__BackingField;
    private 丗且一下丌下专丆七 <丘丅世丏一丕东专丕>k__BackingField;
    private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> <丛丐万世与丗丆丐一>k__BackingField;
    public bool YIsUpAxis;
    public bool RecreateCellHierarchy;
    private byte 万世上丁丌丞丂丅东;
    
    // Properties
    public int 丏一丏世专丞丅丒专 { get; set; }
    public 丗且一下丌下专丆七 丗且一下丌下专丆七 { get; set; }
    public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> 一丘东丌丑且丏一丙 { get; set; }
    
    // Methods
    public int get_CellCount()
    {
        return (int)this.<且丐上丘丛丙丂世丄>k__BackingField;
    }
    private void 丂且丅业丟丄丄丆丂(int 丙业与丙丗丝不丈东)
    {
        this.<且丐上丘丛丙丂世丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public 丗且一下丌下专丆七 get_CellTree()
    {
        return (丗且一下丌下专丆七)this.<丘丅世丏一丕东专丕>k__BackingField;
    }
    private void 三丈丆上丐丗丞丞丅(丗且一下丌下专丆七 丙业与丙丗丝不丈东)
    {
        this.<丘丅世丏一丕东专丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> get_Map()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>)this.<丛丐万世与丗丆丐一>k__BackingField;
    }
    private void 下东丅世丅专丝专丌(System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> 丙业与丙丗丝不丈东)
    {
        this.<丛丐万世与丗丆丐一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.万世上丁丌丞丂丅东 = this.FIRST_GROUP_ID;
        this.丘丁丁三丙丒万下丂();
    }
    public void OnDrawGizmos()
    {
        this.万世上丁丌丞丂丅东 = this.FIRST_GROUP_ID;
        if(this.RecreateCellHierarchy != false)
        {
                this.丘丁丁三丙丒万下丂();
        }
        
        this.丅上丟丘丆丁业不丞();
    }
    private void 丘丁丁三丙丒万下丂()
    {
        object val_25;
        float val_26;
        object val_27;
        float val_28;
        var val_29;
        val_25 = this;
        if(this.上且丝不丐东丐下三() == false)
        {
            goto label_1;
        }
        
        this.万世上丁丌丞丂丅东 = this.万世上丁丌丞丂丅东 + 1;
        丗丑丄丝丞丌丌业丂 val_3 = new 丗丑丄丝丞丌丌业丂(丞丅上丏丂且下丅与:  this.万世上丁丌丞丂丅东, 丆丑丅万丝丞丘业与:  0, 丈东丘丏与丌东东下:  0);
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = val_4.position;
        if(this.YIsUpAxis == false)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_6 = val_4.position;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_5.x, y:  val_6.y);
        this.Center = val_7.x;
        mem[1152921535607834028] = val_7.y;
        if(val_4 == null)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_8 = val_4.localScale;
        val_26 = val_8.x;
        goto label_6;
        label_1:
        object[] val_9 = new object[5];
        val_9[0] = "There are too many cells created by your subdivision options. Maximum allowed number of cells is ";
        byte val_25 = this.FIRST_GROUP_ID;
        val_25 = 250 - val_25;
        val_9[1] = val_25;
        val_27 = ". Current number of cells is ";
        val_9[2] = val_27;
        val_9[3] = this.<且丐上丘丛丙丂世丄>k__BackingField;
        val_9[4] = ".";
        val_25 = +val_9;
        UnityEngine.Debug.LogError(message:  val_25);
        return;
        label_3:
        UnityEngine.Vector3 val_11 = val_4.position;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_5.x, y:  val_11.z);
        this.Center = val_12.x;
        mem[1152921535607834028] = val_12.y;
        if(val_4 == null)
        {
            goto label_27;
        }
        
        UnityEngine.Vector3 val_13 = val_4.localScale;
        val_28 = val_13.x;
        goto label_28;
        label_5:
        UnityEngine.Vector3 val_14 = 0.localScale;
        val_26 = val_14.x;
        label_6:
        UnityEngine.Vector3 val_15 = val_4.localScale;
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_26, y:  val_15.y);
        this.Size = val_16.x;
        mem[1152921535607834036] = val_16.y;
        .丒丁与不一上丛专丒 = 0;
        mem[1152921535607865992] = 0;
        mem[1152921535607865996] = 0;
        .丁业丛且一丂一丟丁 = 0;
        mem[1152921535607866008] = 0;
        UnityEngine.Vector2 val_26 = this.Size;
        UnityEngine.Vector2 val_27 = this.Center;
        val_26 = val_26 * 0.5f;
        float val_17 = S3 * 0.5f;
        val_27 = val_27 - val_26;
        val_15.y = val_15.y - val_17;
        val_29 = 0;
        .丛七丟丗丝丏专专与 = 0;
        mem[1152921535607866020] = val_29;
        UnityEngine.Vector2 val_28 = this.Size;
        UnityEngine.Vector2 val_29 = this.Center;
        val_28 = val_28 * 0.5f;
        val_17 = val_17 * 0.5f;
        val_29 = val_29 + val_28;
        val_15.y = val_15.y + val_17;
        goto label_32;
        label_27:
        UnityEngine.Vector3 val_18 = 0.localScale;
        val_28 = val_18.x;
        label_28:
        UnityEngine.Vector3 val_19 = val_4.localScale;
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_28, y:  val_19.z);
        this.Size = val_20.x;
        mem[1152921535607834036] = val_20.y;
        .丒丁与不一上丛专丒 = 0;
        mem[1152921535607865992] = 0;
        mem[1152921535607865996] = 0;
        .丁业丛且一丂一丟丁 = 0;
        mem[1152921535607866008] = 0;
        UnityEngine.Vector2 val_30 = this.Size;
        UnityEngine.Vector2 val_31 = this.Center;
        val_30 = val_30 * 0.5f;
        float val_21 = S3 * 0.5f;
        val_31 = val_31 - val_30;
        float val_22 = 0f - val_21;
        val_29 = 0;
        .丛七丟丗丝丏专专与 = 0;
        mem[1152921535607866020] = val_29;
        UnityEngine.Vector2 val_32 = this.Size;
        UnityEngine.Vector2 val_33 = this.Center;
        val_32 = val_32 * 0.5f;
        val_21 = val_21 * 0.5f;
        val_33 = val_33 + val_32;
        float val_23 = 0f + val_21;
        label_32:
        .丑与东丅丘丌业丟业 = 0;
        mem[1152921535607866028] = 0;
        mem[1152921535607866032] = 0;
        this.丈专专丏丈丙东丌丅(丈东丘丏与丌东东下:  val_3, 丅不丙一三丗丂七丟:  1);
        丗且一下丌下专丆七 val_24 = null;
        val_27 = val_24;
        val_24 = new 丗且一下丌下专丆七(七万上丐一丈丏丏专:  val_3);
        this.<丘丅世丏一丕东专丕>k__BackingField = val_27;
        this.RecreateCellHierarchy = false;
    }
    private void 丈专专丏丈丙东丌丅(丗丑丄丝丞丌丌业丂 丈东丘丏与丌东东下, int 丅不丙一三丗丂七丟)
    {
        var val_19;
        UnityEngine.Vector2[] val_20;
        UnityEngine.Vector2 val_21;
        UnityEngine.Vector3 val_22;
        var val_24;
        var val_26;
        float val_27;
        var val_28;
        if(this.NumberOfSubdivisions < 丅不丙一三丗丂七丟)
        {
                return;
        }
        
        val_19 = 丅不丙一三丗丂七丟 - 1;
        val_20 = this.Subdivisions;
        val_21 = val_20[(long)val_19];
        if(丈东丘丏与丌东东下 != null)
        {
                val_22 = 丈东丘丏与丌东东下.丁业丛且一丂一丟丁;
            UnityEngine.Vector3 val_17 = 丈东丘丏与丌东东下.丒丁与不一上丛专丒;
            float val_16 = -0.5f;
            val_16 = val_22 * val_16;
            val_17 = val_17 + val_16;
        }
        else
        {
                float val_20 = 1.401298E-45f;
            float val_18 = 8.96831E-44f;
            val_18 = val_18 * (-0.5f);
            val_18 = val_20 + val_18;
            val_22 = 8.96831E-44f;
        }
        
        if((int)this.Subdivisions[(long)val_19] < 1)
        {
                return;
        }
        
        val_21 = val_22 / (float)(int)this.Subdivisions[(long)val_19];
        val_22 = val_21 * 0.5f;
        int val_1 = 丅不丙一三丗丂七丟 + 1;
        label_28:
        if((int)val_21 < 1)
        {
            goto label_9;
        }
        
        var val_25 = 0;
        float val_19 = 0f;
        val_19 = val_21 * val_19;
        val_19 = val_18 + val_19;
        val_20 = val_22 + val_19;
        float val_2 = val_20 - val_22;
        float val_3 = val_22 + val_20;
        label_27:
        this.万世上丁丌丞丂丅东 = this.万世上丁丌丞丂丅东 + 1;
        丗丑丄丝丞丌丌业丂 val_6 = null;
        val_20 = val_6;
        val_6 = new 丗丑丄丝丞丌丌业丂(丞丅上丏丂且下丅与:  this.万世上丁丌丞丂丅东, 丆丑丅万丝丞丘业与:  (this.NumberOfSubdivisions == 丅不丙一三丗丂七丟) ? (1 + 1) : 1, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(丈东丘丏与丌东东下 == null)
        {
            goto label_10;
        }
        
        if(this.YIsUpAxis == false)
        {
            goto label_11;
        }
        
        label_14:
        if(丈东丘丏与丌东东下 == null)
        {
            goto label_12;
        }
        
        val_24 = val_19;
        goto label_13;
        label_10:
        if(this.YIsUpAxis == true)
        {
            goto label_14;
        }
        
        label_11:
        if(丈东丘丏与丌东东下 == null)
        {
            goto label_15;
        }
        
        val_26 = val_19;
        goto label_16;
        label_12:
        label_13:
        float val_7 = val_19 / (float)(int)val_21;
        float val_21 = 0.5f;
        val_21 = S15 * val_21;
        float val_22 = 0f;
        val_21 = S12 - val_21;
        val_22 = val_7 * val_22;
        float val_8 = val_7 * val_21;
        val_21 = val_21 + val_22;
        val_27 = val_8 + val_21;
        .丒丁与不一上丛专丒 = 0;
        mem[1152921535608166456] = 0;
        mem[1152921535608166460] = 0;
        float val_9 = val_27 - val_8;
        .丁业丛且一丂一丟丁 = 0;
        mem[1152921535608166472] = 0;
        val_28 = 0;
        float val_10 = val_8 + val_27;
        .丛七丟丗丝丏专专与 = 0;
        mem[1152921535608166484] = val_28;
        goto label_20;
        label_15:
        label_16:
        float val_11 = val_19 / (float)(int)val_21;
        float val_23 = 0.5f;
        val_23 = S15 * val_23;
        float val_24 = 0f;
        val_23 = S12 - val_23;
        val_24 = val_11 * val_24;
        float val_12 = val_11 * val_23;
        val_23 = val_23 + val_24;
        val_27 = val_12 + val_23;
        .丒丁与不一上丛专丒 = 0;
        mem[1152921535608166456] = 0;
        mem[1152921535608166460] = 0;
        float val_13 = val_27 - val_12;
        .丁业丛且一丂一丟丁 = 0;
        mem[1152921535608166472] = 0;
        val_28 = 0;
        float val_14 = val_12 + val_27;
        .丛七丟丗丝丏专专与 = 0;
        mem[1152921535608166484] = val_28;
        label_20:
        val_19 = 0;
        .丑与东丅丘丌业丟业 = 0;
        mem[1152921535608166492] = val_19;
        mem[1152921535608166496] = 0;
        丈东丘丏与丌东东下.丗上世丑丘业丆七一(不七丘丘丒万七丄丒:  val_6);
        val_25 = val_25 + 1;
        if((int)val_21 != val_25)
        {
            goto label_27;
        }
        
        label_9:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_26 != (int)this.Subdivisions[(long)val_19])
        {
            goto label_28;
        }
    
    }
    private void 丅上丟丘丆丁业不丞()
    {
        if((this.<丘丅世丏一丕东专丕>k__BackingField) != null)
        {
                if((this.<丘丅世丏一丕东专丕>k__BackingField.丘丁丐丅万且下丄专()) != null)
        {
                this.<丘丅世丏一丕东专丕>k__BackingField.丘丁丐丅万且下丄专().丈业丑丂一丕丂丏丗();
            return;
        }
        
        }
        
        this.RecreateCellHierarchy = true;
    }
    private bool 上且丝不丐东丐下三()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 0;
        val_3 = 1;
        val_4 = 1;
        goto label_0;
        label_3:
        val_2 = 1;
        int val_4 = (int)this.Subdivisions[0];
        val_4 = val_4 * (int)this.Subdivisions[0];
        val_3 = val_3 * val_4;
        label_0:
        if(val_2 < this.Subdivisions.Length)
        {
            goto label_3;
        }
        
        byte val_5 = this.FIRST_GROUP_ID;
        val_4 = val_4 * val_3;
        this.<且丐上丘丛丙丂世丄>k__BackingField = val_4;
        val_5 = 250 - val_5;
        return (bool)(val_4 <= val_5) ? 1 : 0;
    }
    public System.Collections.Generic.List<byte> GetActiveCells(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        this.<丘丅世丏一丕东专丕>k__BackingField.丘丁丐丅万且下丄专().丛丒丅丌不丟七丆且(三丈丕丝世丝专下东:  val_1, 丐丆三丝七丏不丌丕:  (this.YIsUpAxis == true) ? 1 : 0, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        return val_1;
    }
    public CullArea()
    {
        this.FIRST_GROUP_ID = 1;
        this.SUBDIVISION_FIRST_LEVEL_ORDER = new int[4] {0, 1, 1, 1};
        this.SUBDIVISION_SECOND_LEVEL_ORDER = new int[8] {0, 2, 1, 2, 0, 2, 1, 2};
        this.SUBDIVISION_THIRD_LEVEL_ORDER = new int[12] {0, 3, 2, 3, 1, 3, 2, 3, 1, 3, 2, 3};
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  25f, y:  25f);
        this.Size = val_4.x;
        mem[1152921535608747684] = val_4.y;
        this.Subdivisions = new UnityEngine.Vector2[3];
    }

}
