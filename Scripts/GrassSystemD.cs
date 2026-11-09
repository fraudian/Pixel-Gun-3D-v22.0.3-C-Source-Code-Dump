using UnityEngine;
public class GrassSystemD : MonoBehaviour
{
    // Fields
    private string TerrainName;
    private UnityEngine.Texture2D terrainTex;
    private UnityEngine.GameObject grassObj;
    public bool rotate;
    public bool RandomRotation;
    private System.Collections.Generic.List<CustomLod> grassPull;
    private System.Collections.Generic.List<bool> 丑丒丑丁丘东丕丝丒;
    private int pullSize;
    private int startPullSize;
    private int maxPullSize;
    private UnityEngine.Transform player;
    private GrassSystemD.Node[] nodes;
    private GrassSystemD.Node[] adjacentNodes;
    private GrassSystemD.Node[] 万丒世丒丘丏丑且丗;
    private float width;
    private int gridWidth;
    private int grassDensity;
    private int X;
    private int Y;
    private UnityEngine.Vector2 minPos;
    private UnityEngine.Vector2 maxPos;
    private UnityEngine.Vector3 丑丏与上不丐丘丕丐;
    private bool 下上丐万丅丘丏不丂;
    private float cullingDistance;
    private int 上专丅七上丆丂丌且;
    private int 丐丘万丄专丆丕世世;
    private float 丐东丘上丂丛丟丂丕;
    private UnityEngine.Vector3 丙丏专世丞七专七丗;
    private float trashHold;
    private bool debug;
    
    // Properties
    private bool 丕丕且丄且丟丛丑丐 { get; }
    
    // Methods
    private bool 丝丝丒与三丙丂东丞(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌)
    {
        int val_2 = 丒丒丄丁且丄丆丂丌 >> 31;
        val_2 = val_2 ^ 1;
        return (bool)((this.gridWidth <= 三丟东丕丄丄下下丑) ? 0 : (!(三丟东丕丄丄下下丑 >> 31))) & ((this.gridWidth > 丒丒丄丁且丄丆丂丌) ? (val_2) : 0);
    }
    private int 丙一业万下东三万丆(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌)
    {
        return (int)三丟东丕丄丄下下丑 + (this.gridWidth * 丒丒丄丁且丄丆丂丌);
    }
    private void Start()
    {
        this.丝丁丅丑万七丟世三();
        this.一丙丟丁丕万不七丝();
    }
    private void 丝丁丅丑万七丟世三()
    {
        System.Collections.Generic.List<System.Boolean> val_5;
        int val_6;
        this.grassPull = new System.Collections.Generic.List<CustomLod>(capacity:  this.maxPullSize);
        System.Collections.Generic.List<System.Boolean> val_2 = null;
        val_5 = val_2;
        val_2 = new System.Collections.Generic.List<System.Boolean>(capacity:  this.maxPullSize);
        val_6 = this.startPullSize;
        this.丑丒丑丁丘东丕丝丒 = val_5;
        if(val_6 >= 1)
        {
                var val_5 = 0;
            do
        {
            val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.grassObj).GetComponent<CustomLod>();
            this.grassPull.Add(item:  val_5);
            val_6 = this.startPullSize;
            val_5 = val_5 + 1;
        }
        while(val_5 < val_6);
        
        }
        
        if(this.maxPullSize >= 1)
        {
                do
        {
            this.丑丒丑丁丘东丕丝丒.Add(item:  true);
            val_5 = 0 + 1;
        }
        while(val_5 < this.maxPullSize);
        
            val_6 = this.startPullSize;
        }
        
        this.pullSize = val_6;
    }
    private void 一丙丟丁丕万不七丝()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        float val_11 = this.width;
        val_2.x = val_2.x + (val_11 * (-0.5f));
        val_11 = val_11 * (float)this.gridWidth;
        val_2.x = val_2.x + val_11;
        this.maxPos = val_2.x;
        UnityEngine.Vector3 val_5 = this.transform.position;
        float val_12 = this.width;
        val_12 = val_12 * (-0.5f);
        val_5.x = val_5.x + val_12;
        this.minPos = val_5.x;
        UnityEngine.Vector3 val_7 = this.transform.position;
        float val_13 = this.width;
        val_7.z = val_7.z + (val_13 * (-0.5f));
        val_13 = val_13 * (float)this.gridWidth;
        val_13 = val_7.z + val_13;
        mem[1152921526354882104] = val_13;
        UnityEngine.Vector3 val_10 = this.transform.position;
        float val_14 = this.width;
        val_14 = val_14 * (-0.5f);
        val_14 = val_10.z + val_14;
        mem[1152921526354882096] = val_14;
    }
    private void 下下丗下丈且业下三()
    {
        UnityEngine.Vector3 val_1 = this.player.position;
        this.丑丏与上不丐丘丕丐 = val_1;
        mem[1152921526355014592] = val_1.y;
        mem[1152921526355014596] = val_1.z;
        val_1.x = val_1.x - this.minPos;
        val_1.x = val_1.x - (this.width * 0.5f);
        val_1.x = val_1.x / (this.maxPos - this.minPos);
        float val_7 = (float)this.gridWidth;
        val_1.x = val_1.x * val_7;
        float val_6 = this.width;
        this.X = UnityEngine.Mathf.RoundToInt(f:  val_1.x);
        val_1.x = val_1.x - val_7;
        val_6 = val_6 * 0.5f;
        val_7 = S3 - val_7;
        val_1.x = val_1.x - val_6;
        val_1.x = val_1.x / val_7;
        val_1.x = val_1.x * (float)this.gridWidth;
        this.Y = UnityEngine.Mathf.RoundToInt(f:  val_1.x);
    }
    private void 丕丙丑七世丙丐丗丈()
    {
        Node val_46;
        int val_47;
        Node val_48;
        Node val_49;
        Node val_50;
        Node val_51;
        Node val_52;
        Node val_53;
        Node val_54;
        int val_2 = this.Y >> 31;
        var val_3 = (this.gridWidth <= this.X) ? 0 : (!(this.X >> 31));
        val_2 = val_2 ^ 1;
        val_3 = val_3 & ((this.gridWidth > this.Y) ? (val_2) : 0);
        if(val_3 == 0)
        {
                return;
        }
        
        this.adjacentNodes[0] = this.nodes[(long)this.X + (this.gridWidth * this.Y)];
        int val_47 = this.X;
        val_47 = val_47 - 1;
        int val_6 = this.Y >> 31;
        val_6 = val_6 ^ 1;
        var val_9 = (this.gridWidth > this.Y) ? (val_6) : 0;
        val_9 = ((this.gridWidth <= val_47) ? 0 : (!(val_47 >> 31))) & val_9;
        if(val_9 == 0)
        {
            goto label_7;
        }
        
        val_46 = this.nodes[(long)val_47 + (this.gridWidth * this.Y)];
        val_47 = this.adjacentNodes.Length;
        if(val_47 > 1)
        {
            goto label_14;
        }
        
        goto label_14;
        label_7:
        val_47 = this.adjacentNodes.Length;
        val_46 = 0;
        label_14:
        this.adjacentNodes[1] = val_46;
        int val_48 = this.X;
        val_48 = val_48 + 1;
        int val_11 = this.Y >> 31;
        val_11 = val_11 ^ 1;
        var val_14 = (this.gridWidth > this.Y) ? (val_11) : 0;
        val_14 = ((this.gridWidth <= val_48) ? 0 : (!(val_48 >> 31))) & val_14;
        if(val_14 == 0)
        {
            goto label_17;
        }
        
        val_48 = this.nodes[(long)val_48 + (this.gridWidth * this.Y)];
        if(this.adjacentNodes.Length > 2)
        {
            goto label_24;
        }
        
        goto label_24;
        label_17:
        val_48 = 0;
        label_24:
        this.adjacentNodes[2] = val_48;
        int val_49 = this.Y;
        int val_16 = this.X >> 31;
        val_49 = val_49 + 1;
        val_16 = val_16 ^ 1;
        var val_18 = (this.gridWidth > this.X) ? (val_16) : 0;
        val_18 = ((this.gridWidth <= val_49) ? 0 : (!(val_49 >> 31))) & val_18;
        if(val_18 == 0)
        {
            goto label_27;
        }
        
        val_49 = this.nodes[(long)this.X + (this.gridWidth * val_49)];
        if(this.adjacentNodes.Length > 3)
        {
            goto label_34;
        }
        
        goto label_34;
        label_27:
        val_49 = 0;
        label_34:
        this.adjacentNodes[3] = val_49;
        int val_50 = this.Y;
        int val_21 = this.X >> 31;
        val_50 = val_50 - 1;
        val_21 = val_21 ^ 1;
        var val_23 = (this.gridWidth > this.X) ? (val_21) : 0;
        val_23 = ((this.gridWidth <= val_50) ? 0 : (!(val_50 >> 31))) & val_23;
        if(val_23 == 0)
        {
            goto label_37;
        }
        
        val_50 = this.nodes[(long)this.X + (this.gridWidth * val_50)];
        if(this.adjacentNodes.Length > 4)
        {
            goto label_44;
        }
        
        goto label_44;
        label_37:
        val_50 = 0;
        label_44:
        this.adjacentNodes[4] = val_50;
        int val_51 = this.X;
        int val_52 = this.Y;
        val_51 = val_51 - 1;
        int val_26 = val_51 >> 31;
        val_52 = val_52 - 1;
        val_26 = val_26 ^ 1;
        var val_28 = (this.gridWidth > val_51) ? (val_26) : 0;
        val_28 = ((this.gridWidth <= val_52) ? 0 : (!(val_52 >> 31))) & val_28;
        if(val_28 == 0)
        {
            goto label_47;
        }
        
        val_51 = this.nodes[(long)val_51 + (this.gridWidth * val_52)];
        if(this.adjacentNodes.Length > 5)
        {
            goto label_54;
        }
        
        goto label_54;
        label_47:
        val_51 = 0;
        label_54:
        this.adjacentNodes[5] = val_51;
        int val_53 = this.X;
        int val_54 = this.Y;
        val_53 = val_53 - 1;
        int val_31 = val_53 >> 31;
        val_54 = val_54 + 1;
        val_31 = val_31 ^ 1;
        var val_33 = (this.gridWidth > val_53) ? (val_31) : 0;
        val_33 = ((this.gridWidth <= val_54) ? 0 : (!(val_54 >> 31))) & val_33;
        if(val_33 == 0)
        {
            goto label_57;
        }
        
        val_52 = this.nodes[(long)val_53 + (this.gridWidth * val_54)];
        if(this.adjacentNodes.Length > 6)
        {
            goto label_64;
        }
        
        goto label_64;
        label_57:
        val_52 = 0;
        label_64:
        this.adjacentNodes[6] = val_52;
        int val_55 = this.X;
        int val_56 = this.Y;
        val_55 = val_55 + 1;
        int val_36 = val_55 >> 31;
        val_56 = val_56 - 1;
        val_36 = val_36 ^ 1;
        var val_38 = (this.gridWidth > val_55) ? (val_36) : 0;
        val_38 = ((this.gridWidth <= val_56) ? 0 : (!(val_56 >> 31))) & val_38;
        if(val_38 == 0)
        {
            goto label_67;
        }
        
        val_53 = this.nodes[(long)val_55 + (this.gridWidth * val_56)];
        if(this.adjacentNodes.Length > 7)
        {
            goto label_74;
        }
        
        goto label_74;
        label_67:
        val_53 = 0;
        label_74:
        this.adjacentNodes[7] = val_53;
        int val_57 = this.X;
        int val_58 = this.Y;
        val_57 = val_57 + 1;
        int val_41 = val_57 >> 31;
        val_58 = val_58 + 1;
        val_41 = val_41 ^ 1;
        var val_43 = (this.gridWidth > val_57) ? (val_41) : 0;
        val_43 = ((this.gridWidth <= val_58) ? 0 : (!(val_58 >> 31))) & val_43;
        if(val_43 == 0)
        {
            goto label_77;
        }
        
        val_54 = this.nodes[(long)val_57 + (this.gridWidth * val_58)];
        if(this.adjacentNodes.Length > 8)
        {
            goto label_84;
        }
        
        goto label_84;
        label_77:
        val_54 = 0;
        label_84:
        var val_64 = 0;
        this.adjacentNodes[8] = val_54;
        label_98:
        var val_61 = 0;
        label_92:
        if(this.adjacentNodes[val_61] == this.万丒世丒丘丏丑且丗[val_64])
        {
            goto label_95;
        }
        
        val_61 = val_61 + 1;
        if(val_61 < 8)
        {
            goto label_92;
        }
        
        if(this.万丒世丒丘丏丑且丗[val_64] != null)
        {
                this.丏丁丛丙丑丈丑丏东(丒丏世专丆业一下丑:  this.万丒世丒丘丏丑且丗[val_64]);
        }
        
        label_95:
        val_64 = val_64 + 1;
        if(val_64 != 9)
        {
            goto label_98;
        }
        
        var val_70 = 0;
        label_119:
        if(this.adjacentNodes[val_70] != null)
        {
                Node val_66 = this.adjacentNodes[val_70];
            if(this.adjacentNodes[0x0][0].active != true)
        {
                Node val_67 = this.adjacentNodes[val_70];
            this.adjacentNodes[0x0][0].active = true;
            this.东一且丝世不丌上三(丒丏世专丆业一下丑:  this.adjacentNodes[val_70]);
        }
        
        }
        
        Node val_69 = this.adjacentNodes[val_70];
        if(this.万丒世丒丘丏丑且丗 == null)
        {
            goto label_113;
        }
        
        if(val_69 != null)
        {
            goto label_114;
        }
        
        goto label_117;
        label_113:
        if(val_69 == null)
        {
            goto label_117;
        }
        
        label_114:
        label_117:
        val_70 = val_70 + 1;
        this.万丒世丒丘丏丑且丗[val_70] = val_69;
        if(val_70 != 9)
        {
            goto label_119;
        }
    
    }
    private void 东一且丝世不丌上三(GrassSystemD.Node 丒丏世专丆业一下丑)
    {
        var val_13;
        UnityEngine.Vector3[] val_14;
        var val_15;
        float val_16;
        float val_17;
        float val_18;
        if(丒丏世专丆业一下丑.grassPoses == null)
        {
                return;
        }
        
        val_14 = 丒丏世专丆业一下丑.grassUp;
        val_13 = 0;
        val_15 = 0;
        goto label_3;
        label_33:
        if(丒丏世专丆业一下丑.grassPoses.Length == 0)
        {
                return;
        }
        
        if(this.丑丒丑丁丘东丕丝丒.Item[0] != false)
        {
                int val_13 = this.pullSize;
            if(val_13 >= val_13)
        {
                val_13 = val_13 + 1;
            this.pullSize = val_13;
            this.grassPull.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.grassObj).GetComponent<CustomLod>());
            val_14 = val_14;
        }
        
            var val_14 = 12;
            val_14 = 丒丏世专丆业一下丑.grassPoses + (0 * val_14);
            val_17 = mem[(0 * 12) + 丒丏世专丆业一下丑.grassPoses + 32];
            val_17 = (0 * 12) + 丒丏世专丆业一下丑.grassPoses + 32;
            val_16 = mem[(0 * 12) + 丒丏世专丆业一下丑.grassPoses + 32 + 4];
            val_16 = (0 * 12) + 丒丏世专丆业一下丑.grassPoses + 32 + 4;
            val_18 = mem[(0 * 12) + 丒丏世专丆业一下丑.grassPoses + 40];
            val_18 = (0 * 12) + 丒丏世专丆业一下丑.grassPoses + 40;
            this.grassPull.Item[0].transform.position = new UnityEngine.Vector3() {x = val_17, y = val_16, z = val_18};
            if(this.RandomRotation != false)
        {
                UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  0f, y:  (float)UnityEngine.Random.Range(min:  0, max:  104), z:  0f);
            val_17 = val_9.x;
            val_16 = val_9.y;
            val_18 = val_9.z;
            this.grassPull.Item[0].transform.rotation = new UnityEngine.Quaternion() {x = val_17, y = val_16, z = val_18, w = val_9.w};
            val_14 = val_14;
        }
        
            if(this.rotate != false)
        {
                var val_15 = 12;
            val_15 = val_14 + (0 * val_15);
            val_17 = mem[(0 * 12) + 丒丏世专丆业一下丑.grassUp + 32];
            val_17 = (0 * 12) + 丒丏世专丆业一下丑.grassUp + 32;
            val_18 = mem[(0 * 12) + 丒丏世专丆业一下丑.grassUp + 40];
            val_18 = (0 * 12) + 丒丏世专丆业一下丑.grassUp + 40;
            this.grassPull.Item[0].transform.forward = new UnityEngine.Vector3() {x = val_17, y = (0 * 12) + 丒丏世专丆业一下丑.grassUp + 32 + 4, z = val_18};
        }
        
            this.丑丒丑丁丘东丕丝丒.set_Item(index:  0, value:  false);
            丒丏世专丆业一下丑.Ids.Add(item:  0);
            val_15 = 1;
            if(val_15 == 丒丏世专丆业一下丑.grassPoses.Length)
        {
                return;
        }
        
        }
        
        val_13 = 1;
        label_3:
        if(val_13 < this.丑丒丑丁丘东丕丝丒.Count)
        {
            goto label_33;
        }
    
    }
    private void 丏丁丛丙丑丈丑丏东(GrassSystemD.Node 丒丏世专丆业一下丑)
    {
        int val_5;
        if(丒丏世专丆业一下丑 != null)
        {
                丒丏世专丆业一下丑.active = false;
        }
        else
        {
                mem[16] = 0;
        }
        
        val_5 = 丒丏世专丆业一下丑.Ids.Count - 1;
        if((val_5 & 2147483648) == 0)
        {
                do
        {
            this.grassPull.Item[丒丏世专丆业一下丑.Ids.Item[val_5]].active = false;
            this.丑丒丑丁丘东丕丝丒.set_Item(index:  丒丏世专丆业一下丑.Ids.Item[val_5], value:  true);
            val_5 = val_5 - 1;
        }
        while((val_5 & 2147483648) == 0);
        
        }
        
        丒丏世专丆业一下丑.Ids.Clear();
    }
    private void Update()
    {
        if(this.万丑丏丑上世丟世且() == false)
        {
                return;
        }
        
        this.业丛丆丏与丞七丝一();
    }
    private bool 万丑丏丑上世丟世且()
    {
        int val_3;
        UnityEngine.Vector3 val_4;
        float val_5;
        int val_6;
        int val_7;
        int val_8;
        this.下下丗下丈且业下三();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丙丏专世丞七专七丗, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.丑丏与上不丐丘丕丐, y = V9.16B, z = V10.16B});
        val_3 = this.X;
        val_4 = this.丑丏与上不丐丘丕丐;
        val_5 = this.丐东丘上丂丛丟丂丕 - val_1.x;
        this.丐东丘上丂丛丟丂丕 = val_5;
        this.丙丏专世丞七专七丗 = val_4;
        mem[1152921526358155108] = ???;
        if(val_3 != this.上专丅七上丆丂丌且)
        {
            goto label_3;
        }
        
        val_6 = this;
        val_7 = this.Y;
        if(val_7 != this.丐丘万丄专丆丕世世)
        {
            goto label_6;
        }
        
        if(this.下上丐万丅丘丏不丂 == true)
        {
            goto label_5;
        }
        
        goto label_6;
        label_3:
        val_6 = this.丐丘万丄专丆丕世世;
        label_6:
        this.下上丐万丅丘丏不丂 = true;
        this.丕丙丑七世丙丐丗丈();
        val_3 = this.X;
        val_8 = this.Y;
        val_5 = 0f;
        this.丐东丘上丂丛丟丂丕 = 0f;
        label_5:
        this.上专丅七上丆丂丌且 = val_3;
        mem2[0] = val_8;
        return (bool)(val_5 <= 0f) ? 1 : 0;
    }
    private void 业丛丆丏与丞七丝一()
    {
        var val_8;
        this.丐东丘上丂丛丟丂丕 = this.trashHold;
        this.pullSize = this.grassPull.Count;
        var val_14 = 0;
        float val_2 = this.cullingDistance * this.cullingDistance;
        label_23:
        if(this.adjacentNodes[val_14] == null)
        {
            goto label_8;
        }
        
        Node val_10 = this.adjacentNodes[val_14];
        if(this.adjacentNodes[0x0][0].grassPoses == null)
        {
            goto label_8;
        }
        
        Node val_11 = this.adjacentNodes[val_14];
        Node val_12 = this.adjacentNodes[val_14];
        val_8 = 0;
        goto label_14;
        label_22:
        float val_13 = 8.96831E-44f;
        var val_3 = this.adjacentNodes[0x0][0].grassPoses + (0 * 12);
        val_13 = val_13 - this.丑丏与上不丐丘丕丐;
        val_13 = val_13 * val_13;
        val_13 = val_13 + ((((0 * 12) + this.adjacentNodes[0x0][0].grassPoses + 40) - S11) * (((0 * 12) + this.adjacentNodes[0x0][0].grassPoses + 40) - S11));
        this.grassPull.Item[this.adjacentNodes[0x0][0].Ids.Item[0]].active = (val_13 < 0) ? 1 : 0;
        val_8 = 1;
        label_14:
        if(val_8 < this.adjacentNodes[0x0][0].grassPoses.Length)
        {
            goto label_22;
        }
        
        label_8:
        val_14 = val_14 + 1;
        if(val_14 != 9)
        {
            goto label_23;
        }
    
    }
    private void OnDrawGizmos()
    {
        int val_7;
        if(this.debug == false)
        {
                return;
        }
        
        if(this.nodes == null)
        {
                return;
        }
        
        val_7 = this.gridWidth;
        if((val_7 * val_7) != this.nodes.Length)
        {
                return;
        }
        
        if(val_7 < 1)
        {
                return;
        }
        
        var val_9 = 0;
        do
        {
            if(val_7 >= 1)
        {
                var val_8 = 0;
            do
        {
            Node val_7 = this.nodes[(long)val_9 + (val_7 * val_8)];
            if((this.nodes[(long)(int)((this.gridWidth * 0) + 0)][0].active) != false)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.green;
        }
        
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.width);
            UnityEngine.Gizmos.DrawWireCube(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, size:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_7 = this.gridWidth;
            val_8 = val_8 + 1;
        }
        while(val_8 < val_7);
        
        }
        
            val_9 = val_9 + 1;
        }
        while(val_9 < val_7);
    
    }
    public GrassSystemD()
    {
        this.TerrainName = "Terrain_2x2km_Base";
        this.grassPull = new System.Collections.Generic.List<CustomLod>();
        this.丑丒丑丁丘东丕丝丒 = new System.Collections.Generic.List<System.Boolean>();
        this.adjacentNodes = new Node[9];
        this.万丒世丒丘丏丑且丗 = new Node[9];
        this.width = 30f;
        this.gridWidth = 20;
        this.grassDensity = 5;
        this.cullingDistance = 30f;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.丙丏专世丞七专七丗 = val_5;
        mem[1152921526359178480] = val_5.y;
        mem[1152921526359178484] = val_5.z;
        this.trashHold = 5f;
    }

}
