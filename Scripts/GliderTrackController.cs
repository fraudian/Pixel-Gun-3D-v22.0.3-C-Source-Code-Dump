using UnityEngine;
public class GliderTrackController : MonoBehaviour
{
    // Fields
    internal static GliderTrackController 丄丘七三上丕世丞业;
    public static float trackWidth;
    public static float trackMinHeight;
    public static float trackMaxHeight;
    public static int checkpointScore;
    public static int hardCheckpointScore;
    public static int penaltyScore;
    public int trackLength;
    public int visiblePartsCount;
    public UnityEngine.GameObject followPlayerGO;
    public GliderTrackPart[] startParts;
    public GliderTrackPart[] parts;
    public UnityEngine.Transform startTrackPoint;
    private System.Collections.Generic.List<GliderTrackPart>[] 东丙丏丑丞丕上丏不;
    private System.Collections.Generic.List<GliderTrackPart> 丛丒丌七丟丞丏丗且;
    private int 丙世三丞业下丑万丁;
    private int 且丏与丄三与丟丌丛;
    private bool 一丕丏三丂丆丏七丑;
    private int 丁业万丒世与世七专;
    private int[] 万业业东三一不丈丝;
    private GliderTrackPart 丈与下丁一上丏七丙;
    internal GliderTrackCheckpoint 丆且且世丛丗三丁丌;
    private int 丄七丆丗东不丅丆丌;
    private float 丄丒世丝丘世丌丗丁;
    private Rilisoft.丝丑丂丛万丐丈丘且 下丄丕丕世万专业丑;
    private Rilisoft.丒且丐三丁丅丕一业 下丝丏三三丛丛丑业;
    
    // Properties
    private int 万且丒下丕丝专丟上 { get; set; }
    private float 丝上七万上丄专丟丘 { get; set; }
    internal static int 丆丕丌业丗专七世丒 { get; }
    
    // Methods
    private int 丝丈丅一丆丗丝丝丘()
    {
    
    }
    private void 东且世丈丒丄世三丈(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921526169434472] = 0;
    }
    private float 业且丝丌丄丏丅丑丛()
    {
        if(this.下丝丏三三丛丛丑业 != null)
        {
                return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
        }
        
        return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
    }
    private void 丗丕与丁丟丟丗丏且(float 丙业与丙丗丝不丈东)
    {
        this.下丝丏三三丛丛丑业.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal static int 一一丕丏丈世丞世丟()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丝丕东丘丐丗不世]);
    }
    private void Awake()
    {
        var val_12;
        var val_13;
        System.Collections.Generic.List<GliderTrackPart>[] val_14;
        int val_15;
        var val_16;
        var val_17;
        this.万业业东三一不丈丝 = new int[0];
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        val_12 = null;
        val_12 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == true)
        {
            goto label_10;
        }
        
        label_3:
        UnityEngine.Debug.LogError(message:  "Generation seed is null");
        label_10:
        val_13 = null;
        System.Random val_7 = new System.Random(Seed:  GliderTrackController.一一丕丏丈世丞世丟());
        if(this.startParts == null)
        {
            goto label_15;
        }
        
        label_47:
        this.丁业万丒世与世七专 = val_7;
        if(this.trackLength >= 1)
        {
                var val_12 = 0;
            do
        {
            this.万业业东三一不丈丝[0] = val_7;
            val_12 = val_12 + 1;
        }
        while(val_12 < this.trackLength);
        
        }
        
        val_14 = new System.Collections.Generic.List<GliderTrackPart>[0];
        this.东丙丏丑丞丕上丏不 = val_14;
        val_15 = 0;
        goto label_23;
        label_36:
        System.Collections.Generic.List<GliderTrackPart> val_9 = new System.Collections.Generic.List<GliderTrackPart>(capacity:  this.visiblePartsCount);
        if(this.东丙丏丑丞丕上丏不 == null)
        {
            goto label_24;
        }
        
        if(val_9 != null)
        {
            goto label_25;
        }
        
        goto label_28;
        label_24:
        if(val_9 == null)
        {
            goto label_28;
        }
        
        label_25:
        label_28:
        this.东丙丏丑丞丕上丏不[0] = val_9;
        GliderTrackPart val_13 = this.parts[0];
        this.parts[0x0][0].丈丒丕与下丛丌东丄 = val_15;
        this.丅丟东上且专东上丈(东丅丁丆七下专丕与:  this.parts[0]);
        val_14 = this.东丙丏丑丞丕上丏不;
        val_15 = 1;
        label_23:
        if(val_15 < this.东丙丏丑丞丕上丏不.Length)
        {
            goto label_36;
        }
        
        val_16 = 0;
        goto label_37;
        label_43:
        val_15 = 0;
        this.startParts[val_15].gameObject.SetActive(value:  false);
        val_16 = 1;
        label_37:
        if(val_16 < this.startParts.Length)
        {
            goto label_43;
        }
        
        this.丛丒丌七丟丞丏丗且 = new System.Collections.Generic.List<GliderTrackPart>(capacity:  this.visiblePartsCount);
        val_17 = null;
        val_17 = null;
        GliderTrackController.丄丘七三上丕世丞业 = this;
        return;
        label_15:
        if(val_7 != null)
        {
            goto label_47;
        }
        
        goto label_47;
    }
    public UnityEngine.Vector3 GetMoveVector()
    {
        if(this.丈与下丁一上丏七丙 != 0)
        {
                UnityEngine.Vector3 val_2 = this.丈与下丁一上丏七丙.endPoint.position;
            this = this.丈与下丁一上丏七丙.transform;
            UnityEngine.Vector3 val_4 = this.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public float GetMaxHeightForPoint(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = 丅专与丒丈丗丒丘丌.z;
        if(this.丈与下丁一上丏七丙 != 0)
        {
                UnityEngine.Vector3 val_2 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_4 = this.丈与下丁一上丏七丙.transform.position;
            UnityEngine.Vector3 val_5 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_6 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_8 = this.丈与下丁一上丏七丙.transform.position;
            val_8.z = (val_5.z - val_12) / (val_6.z - val_8.z);
            val_13 = 1152921505068134400;
            val_12 = UnityEngine.Mathf.Lerp(a:  val_2.y, b:  val_4.y, t:  val_8.z);
            val_14 = null;
            val_14 = null;
            float val_12 = GliderTrackController.trackMaxHeight;
            val_12 = val_12 + val_12;
            return (float)GliderTrackController.trackMaxHeight;
        }
        
        val_13 = 1152921505068134400;
        val_15 = null;
        val_15 = null;
        return (float)GliderTrackController.trackMaxHeight;
    }
    public float GetMinHeightForPoint(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = 丅专与丒丈丗丒丘丌.z;
        if(this.丈与下丁一上丏七丙 != 0)
        {
                UnityEngine.Vector3 val_2 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_4 = this.丈与下丁一上丏七丙.transform.position;
            UnityEngine.Vector3 val_5 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_6 = this.丈与下丁一上丏七丙.endPoint.position;
            UnityEngine.Vector3 val_8 = this.丈与下丁一上丏七丙.transform.position;
            val_8.z = (val_5.z - val_12) / (val_6.z - val_8.z);
            val_13 = 1152921505068134400;
            val_12 = UnityEngine.Mathf.Lerp(a:  val_2.y, b:  val_4.y, t:  val_8.z);
            val_14 = null;
            val_14 = null;
            float val_12 = GliderTrackController.trackMinHeight;
            val_12 = val_12 + val_12;
            return (float)GliderTrackController.trackMinHeight;
        }
        
        val_13 = 1152921505068134400;
        val_15 = null;
        val_15 = null;
        return (float)GliderTrackController.trackMinHeight;
    }
    private void Update()
    {
        var val_59;
        float val_60;
        float val_61;
        float val_62;
        var val_63;
        UnityEngine.Transform val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        int val_71;
        var val_72;
        val_59 = null;
        val_59 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = transform.position;
        val_60 = val_4.x;
        val_61 = val_4.y;
        val_62 = val_4.z;
        this.followPlayerGO.transform.position = new UnityEngine.Vector3() {x = val_60, y = val_61, z = val_62};
        if(this.丛丒丌七丟丞丏丗且.Count >= this.visiblePartsCount)
        {
                GliderTrackPart val_6 = this.丛丒丌七丟丞丏丗且.Item[0];
            UnityEngine.Vector3 val_7 = val_6.endPoint.position;
            GliderTrackPart val_8 = this.丛丒丌七丟丞丏丗且.Item[0];
            UnityEngine.Vector3 val_9 = val_8.endPoint.position;
            UnityEngine.Vector3 val_12 = this.丛丒丌七丟丞丏丗且.Item[0].transform.position;
            UnityEngine.Vector3 val_14 = transform.position;
            val_60 = val_7.z + (val_9.z - val_12.z);
            if(val_60 < 0)
        {
                this.丅丟东上且专东上丈(东丅丁丆七下专丕与:  this.丛丒丌七丟丞丏丗且.Item[0]);
            this.丛丒丌七丟丞丏丗且.RemoveAt(index:  0);
            int val_58 = this.丙世三丞业下丑万丁;
            val_58 = val_58 + 1;
            this.丙世三丞业下丑万丁 = val_58;
        }
        
        }
        
        val_63 = this.visiblePartsCount - this.丛丒丌七丟丞丏丗且.Count;
        if(this.一丕丏三丂丆丏七丑 != true)
        {
                GliderTrackPart val_18 = this.不丙不且业且丐丐万();
            val_64 = this.startTrackPoint;
            UnityEngine.Vector3 val_20 = val_64.position;
            val_60 = val_20.x;
            val_61 = val_20.y;
            val_62 = val_20.z;
            val_18.transform.position = new UnityEngine.Vector3() {x = val_60, y = val_61, z = val_62};
            this.丛丒丌七丟丞丏丗且.Add(item:  val_18);
            this.一丕丏三丂丆丏七丑 = true;
        }
        
        if(val_63 >= 1)
        {
                do
        {
            GliderTrackPart val_21 = this.丞一丘专七专丝上与();
            if(this.丛丒丌七丟丞丏丗且 != null)
        {
                val_65 = this.丛丒丌七丟丞丏丗且.Count;
        }
        else
        {
                val_65 = 0.Count;
        }
        
            GliderTrackPart val_26 = this.丛丒丌七丟丞丏丗且.Item[val_65 - 1];
            val_64 = val_26.endPoint;
            UnityEngine.Vector3 val_27 = val_64.position;
            val_60 = val_27.x;
            val_61 = val_27.y;
            val_62 = val_27.z;
            val_21.transform.position = new UnityEngine.Vector3() {x = val_60, y = val_61, z = val_62};
            int val_59 = this.且丏与丄三与丟丌丛;
            val_59 = val_59 + 1;
            this.且丏与丄三与丟丌丛 = val_59;
            this.丛丒丌七丟丞丏丗且.Add(item:  val_21);
            val_63 = val_63 - 1;
        }
        while(val_63 != 0);
        
        }
        
        val_66 = 0;
        goto label_42;
        label_131:
        GliderTrackPart val_28 = this.丛丒丌七丟丞丏丗且.Item[0];
        UnityEngine.Vector3 val_30 = transform.position;
        UnityEngine.Vector3 val_32 = val_28.transform.position;
        if(val_30.z > val_32.z)
        {
                UnityEngine.Vector3 val_34 = transform.position;
            UnityEngine.Vector3 val_35 = val_28.endPoint.position;
            if(val_34.z <= val_35.z)
        {
                this.丈与下丁一上丏七丙 = val_28;
        }
        
        }
        
        val_67 = 0;
        goto label_54;
        label_129:
        val_63 = 0;
        UnityEngine.Vector3 val_37 = val_28.checkpoints[val_63].transform.position;
        UnityEngine.Vector3 val_39 = transform.position;
        GliderTrackCheckpoint val_61 = val_28.checkpoints[val_63];
        if(val_37.z >= 0)
        {
            goto label_64;
        }
        
        if(val_28.checkpoints[0x0][0].丒丛七丈不丌丕世丏 == true)
        {
            goto label_124;
        }
        
        UnityEngine.Vector3 val_41 = val_28.checkpoints[val_63].transform.position;
        UnityEngine.Vector3 val_43 = transform.position;
        val_61 = val_41.y;
        val_62 = val_41.z;
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_61, z = val_62}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
        GliderTrackCheckpoint val_63 = val_28.checkpoints[val_63];
        GliderTrackCheckpoint val_64 = val_28.checkpoints[val_63];
        val_60 = val_28.checkpoints[0x0][0].checkpointRadius * val_28.checkpoints[0x0][0].checkpointRadius;
        var val_45 = (val_44.x <= val_60) ? 1 : 0;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.LogError(message:  "Checkpoint passed " + val_45.ToString());
        }
        
        val_28.checkpoints[val_63].与三一不业丕丝七丗(丆七业丌东一万上丂:  (val_45 != 0) ? 1 : 0);
        if(val_45 == 0)
        {
            goto label_88;
        }
        
        val_68 = null;
        val_68 = null;
        GliderTrackCheckpoint val_66 = val_28.checkpoints[val_63];
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  (val_28.checkpoints[0x0][0].hardCheckpoint == true) ? (116 + 1) : 116, 专上丝且丂世丛丝丒:  1f);
        GliderTrackCheckpoint val_67 = val_28.checkpoints[val_63];
        val_69 = null;
        if(val_28.checkpoints[0x0][0].hardCheckpoint == false)
        {
            goto label_100;
        }
        
        val_70 = null;
        val_71 = 1152921505068138520;
        goto label_103;
        label_64:
        if(val_28.checkpoints[0x0][0].hardCheckpoint == false)
        {
            goto label_124;
        }
        
        GliderTrackCheckpoint val_68 = val_28.checkpoints[val_63];
        if(val_28.checkpoints[0x0][0].丒丛七丈不丌丕世丏 == false)
        {
            goto label_124;
        }
        
        GliderTrackCheckpoint val_69 = val_28.checkpoints[val_63];
        if(val_28.checkpoints[0x0][0].一丌东一丝丄且丙丈 == true)
        {
            goto label_124;
        }
        
        GliderTrackCheckpoint val_70 = val_28.checkpoints[val_63];
        val_28.checkpoints[0x0][0].丒丛七丈不丌丕世丏 = false;
        goto label_124;
        label_100:
        val_72 = null;
        val_71 = 1152921505068138516;
        label_103:
        this.三丅七专丌丆万三丑(丗丂丁丂丗丄七丏下:  val_71);
        val_60 = 0.5f;
        val_61 = 0.5f;
        FirstPersonControlSharp.上三丈世丟业一丘丘(丐不丁专业丌七东丕:  val_60, 丘丞丌丙上万丒上丁:  val_61);
        label_88:
        GliderTrackCheckpoint val_71 = val_28.checkpoints[val_63];
        if(val_28.checkpoints[0x0][0].hardCheckpoint != true)
        {
                this.丆且且世丛丗三丁丌 = val_28.checkpoints[val_63];
        }
        
        label_124:
        val_67 = 1;
        label_54:
        val_64 = val_28.checkpoints;
        if(val_67 < val_28.checkpoints.Length)
        {
            goto label_129;
        }
        
        val_66 = 1;
        label_42:
        if(val_66 < this.丛丒丌七丟丞丏丗且.Count)
        {
            goto label_131;
        }
        
        UnityEngine.Vector3 val_53 = transform.position;
        UnityEngine.Vector3 val_54 = this.startTrackPoint.position;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
        this.丗丕与丁丟丟丗丏且(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  val_55.x, b:  this.业且丝丌丄丏丅丑丛()));
        this.丂丆丄丛丂三丘业一();
    }
    private void 三丅七专丌丆万三丑(int 丗丂丁丂丗丄七丏下)
    {
        var val_4 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  0, b:  this.下丄丕丕世万专业丑 + 丗丂丁丂丗丄七丏下));
        int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921526173065176] = 0;
    }
    private void 丂丆丄丛丂三丘业一()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_7 = null;
        Rilisoft.丝丑丂丛万丐丈丘且 val_5 = this.下丄丕丕世万专业丑;
        val_7 = null;
        val_5 = val_5 + (UnityEngine.Mathf.RoundToInt(f:  this.业且丝丌丄丏丅丑丛()));
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  val_5);
        val_8 = null;
        val_8 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_5);
    }
    private GliderTrackPart 丞一丘专七专丝上与()
    {
        return this.丂东丐丆丈丆不业不(丞世不丒下上上丝丑:  this.万业业东三一不丈丝[this.且丏与丄三与丟丌丛]);
    }
    private GliderTrackPart 不丙不且业且丐丐万()
    {
        GliderTrackPart val_2 = this.startParts[this.丁业万丒世与世七专];
        val_2.gameObject.SetActive(value:  true);
        return val_2;
    }
    private GliderTrackPart 丂东丐丆丈丆不业不(int 丞世不丒下上上丝丑)
    {
        System.Collections.Generic.List<GliderTrackPart> val_7;
        var val_8;
        val_7 = this.东丙丏丑丞丕上丏不[(long)丞世不丒下上上丝丑];
        if(val_7.Count >= 2)
        {
            goto label_4;
        }
        
        val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.parts[(long)丞世不丒下上上丝丑].gameObject).GetComponent<GliderTrackPart>();
        if(val_8 != null)
        {
            goto label_19;
        }
        
        goto label_12;
        label_4:
        val_7 = this.东丙丏丑丞丕上丏不;
        val_8 = this.东丙丏丑丞丕上丏不[(long)丞世不丒下上上丝丑].Item[1];
        val_7[(long)丞世不丒下上上丝丑].RemoveAt(index:  1);
        if(val_8 != null)
        {
            goto label_19;
        }
        
        label_12:
        label_19:
        val_8.gameObject.SetActive(value:  true);
        return (GliderTrackPart)val_8;
    }
    private void 丅丟东上且专东上丈(GliderTrackPart 东丅丁丆七下专丕与)
    {
        东丅丁丆七下专丕与.gameObject.SetActive(value:  false);
        if(东丅丁丆七下专丕与 != null)
        {
                东丅丁丆七下专丕与.Reset();
        }
        else
        {
                0.Reset();
        }
        
        if(东丅丁丆七下专丕与.丈丒丕与下丛丌东丄 == 1)
        {
                return;
        }
        
        this.东丙丏丑丞丕上丏不[东丅丁丆七下专丕与.丈丒丕与下丛丌东丄].Add(item:  东丅丁丆七下专丕与);
    }
    public void OnPenaltyColliderHit()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  118, 专上丝且丂世丛丝丒:  1f);
        val_2 = null;
        val_2 = null;
        this.三丅七专丌丆万三丑(丗丂丁丂丗丄七丏下:  -GliderTrackController.penaltyScore);
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丕丛丞丙下丛丈丂丛();
        专丘七丅丄一七丕不(丂三丟丂丈丐丆丗丟:  2f);
    }
    public GliderTrackController()
    {
        this.trackLength = 86;
        this.visiblePartsCount = 6;
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921526174485080] = 0;
        this.下丝丏三三丛丛丑业 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
    }
    private static GliderTrackController()
    {
        GliderTrackController.trackWidth = 115f;
        GliderTrackController.trackMinHeight = 10f;
        GliderTrackController.trackMaxHeight = 70f;
        GliderTrackController.checkpointScore = 150;
        GliderTrackController.hardCheckpointScore = 300;
        GliderTrackController.penaltyScore = 150;
    }

}
