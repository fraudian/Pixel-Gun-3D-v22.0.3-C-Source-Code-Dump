using UnityEngine;
public class TerrainObjectsPull : MonoBehaviour
{
    // Fields
    public int minInstances;
    public UnityEngine.Vector3 terrainMinBounds;
    public UnityEngine.Vector3 terrainMaxBounds;
    public bool CheckOnly;
    public TerrainObjectsPull.MyDictionaryOfPoolObjects pool;
    public TerrainObjectsPull.MyDictionaryOfInts poolUseCounter;
    private System.Collections.Generic.List<int> 丌丈丕七专丏丌七丞;
    private System.Collections.Generic.List<int> 丄丑丅丟七丅丛下丑;
    private System.Collections.Generic.List<string> 丁丅丌丏世三丅丈三;
    private System.Collections.Generic.List<TerrainObjectsPull.PoolObj> 丆丌丛丅七丂丄丞丈;
    private UnityEngine.WaitForEndOfFrame 丕丄不与丒上丟下三;
    public int Grid;
    public float size;
    public TerrainObjectsPull.Chunk[] chunks;
    public System.Collections.Generic.List<string> Names;
    
    // Methods
    private void 丝丕丟丑专丟丁三与()
    {
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Collections.Generic.List<System.String> val_41;
        var val_42;
        object val_43;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        val_36 = 0;
        goto label_1;
        label_46:
        val_2.Clear();
        PoolObjListHolder val_4 = this.pool.Item[this.Names.Item[0]];
        val_37 = 0;
        val_38 = 0;
        val_39 = 0;
        goto label_24;
        label_28:
        PoolObj val_5 = val_4.entityList.Item[0];
        if(val_5.obj != 0)
        {
            goto label_12;
        }
        
        val_2.Add(item:  0);
        val_38 = 1;
        goto label_14;
        label_12:
        if(val_4.entityList != null)
        {
                PoolObj val_7 = val_4.entityList.Item[0];
        }
        else
        {
                PoolObj val_8 = val_4.entityList.Item[0];
        }
        
        val_4.entityList.Item[0].丝丕丟丑专丟丁三与();
        if(val_10._inUse == false)
        {
            goto label_20;
        }
        
        label_26:
        if(val_11._inUse != false)
        {
                val_11._inUse = false;
            val_4.entityList.Item[0].不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        }
        
        val_39 = 1;
        label_14:
        val_37 = 1;
        goto label_24;
        label_20:
        val_10._inUse = true;
        val_4.entityList.Item[0].不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
        if(val_4.entityList != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_24:
        if(val_37 < val_4.entityList.Count)
        {
            goto label_28;
        }
        
        if((val_39 | (val_1.Contains(item:  this.Names.Item[0]))) != true)
        {
                UnityEngine.Debug.Log(message:  "remove " + this.Names.Item[0]);
            val_1.Add(item:  this.Names.Item[0]);
        }
        
        if(((val_38 & val_39) & 1) == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Debug.Log(message:  "КОСТЯ ЕБАНЫЙ В РОТ НЕ ЛОМАЙ ИГРУ / восстановлен префаб :"("КОСТЯ ЕБАНЫЙ В РОТ НЕ ЛОМАЙ ИГРУ / восстановлен префаб :") + this.Names.Item[0]);
        val_40 = 0;
        goto label_41;
        label_44:
        int val_22 = val_2.Item[0];
        val_40 = 1;
        label_41:
        if(val_40 < val_2.Count)
        {
            goto label_44;
        }
        
        label_37:
        val_36 = val_36 + 1;
        label_1:
        val_41 = this.Names;
        if(val_36 < val_41.Count)
        {
            goto label_46;
        }
        
        val_42 = 0;
        goto label_47;
        label_84:
        bool val_26 = this.Names.Remove(item:  val_1.Item[0]);
        val_41 = val_1.Item[0];
        bool val_28 = this.pool.Remove(key:  val_41);
        val_43 = 0;
        goto label_53;
        label_82:
        Chunk val_37 = this.chunks[0];
        val_41 = val_1.Item[0];
        if((this.chunks[0x0][0].objectsInChunk.Contains(item:  val_41)) != false)
        {
                object[] val_31 = new object[4];
            val_31[0] = "Remove ";
            val_31[1] = val_1.Item[0];
            val_31[2] = " in chunk number ";
            val_31[3] = val_43;
            UnityEngine.Debug.Log(message:  +val_31);
            Chunk val_38 = this.chunks[0];
            val_41 = val_1.Item[0];
            bool val_35 = this.chunks[0x0][0].objectsInChunk.Remove(item:  val_41);
        }
        
        val_43 = 1;
        label_53:
        if(val_43 < this.chunks.Length)
        {
            goto label_82;
        }
        
        val_42 = 1;
        label_47:
        if(val_42 < val_1.Count)
        {
            goto label_84;
        }
    
    }
    private void 一丙一丈丁丑丝丈丈()
    {
        int val_17;
        int val_1 = this.Grid * this.Grid;
        this.chunks = new Chunk[0];
        float val_3 = this.size / (float)this.Grid;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3, y:  val_3);
        val_17 = this.Grid;
        if(val_17 < 1)
        {
                return;
        }
        
        var val_21 = 0;
        do
        {
            if(val_17 >= 1)
        {
                var val_20 = 0;
            do
        {
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector3 val_9 = this.transform.position;
            float val_11 = val_3 * 0f;
            val_11 = val_11 + val_9.z;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  (val_3 * 0f) + val_7.x, y:  val_11);
            int val_17 = this.Grid;
            val_17 = val_21 + (val_17 * val_20);
            this.chunks[(long)val_17] = new TerrainObjectsPull.Chunk();
            Chunk val_18 = this.chunks[(long)val_21 + (this.Grid * val_20)];
            this.chunks[(long)(int)((this.Grid * 0) + 0)][0].rect = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            Chunk val_19 = this.chunks[(long)val_21 + (this.Grid * val_20)];
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_20 = val_20 + 1;
            this.chunks[(long)(int)((this.Grid * 0) + 0)][0].id = val_16.x;
            mem2[0] = val_16.y;
            val_17 = this.Grid;
        }
        while(val_20 < val_17);
        
        }
        
            val_21 = val_21 + 1;
        }
        while(val_21 < val_17);
    
    }
    private int 世丂丙七丏万丞丑丐(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        UnityEngine.Vector3 val_5 = this.terrainMinBounds;
        UnityEngine.Vector3 val_4 = this.terrainMaxBounds;
        val_4 = val_4 - val_5;
        float val_1 = S3 - 下业丕七东丌丝下且.y;
        val_4 = 1f / val_4;
        val_1 = 1f / val_1;
        val_5 = val_5 * val_4;
        下业丕七东丌丝下且.y = 下业丕七东丌丝下且.y * val_1;
        val_4 = 下业丕七东丌丝下且.x * val_4;
        val_1 = 下业丕七东丌丝下且.z * val_1;
        val_5 = 0f - val_5;
        下业丕七东丌丝下且.y = 0f - 下业丕七东丌丝下且.y;
        val_5 = val_4 + val_5;
        下业丕七东丌丝下且.y = val_1 + 下业丕七东丌丝下且.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        return (int)this.下七丙丅且丂一不丞(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
    }
    private int 下七丙丅且丂一不丞(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
    {
        float val_6 = 丞丟丆一丄七与丝丒.x;
        float val_5 = (float)this.Grid;
        float val_1 = val_5 * 0f;
        val_1 = 0f - val_1;
        val_5 = val_6 * val_5;
        val_6 = val_5 + val_1;
        float val_7 = (float)this.Grid;
        float val_3 = val_7 * 0f;
        val_3 = 0f - val_3;
        val_7 = 丞丟丆一丄七与丝丒.y * val_7;
        val_7 = val_7 + val_3;
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_7);
        val_4 = (UnityEngine.Mathf.FloorToInt(f:  val_6)) + (this.Grid * val_4);
        return (int)val_4;
    }
    private int 丐上丒丟丂丕丛上丑(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌, int 与丘东下丈东丛丂万)
    {
        return (int)三丟东丕丄丄下下丑 + (与丘东下丈东丛丂万 * 丒丒丄丁且丄丆丂丌);
    }
    private float 一三且不丙专丘丄七(float 三丟东丕丄丄下下丑, float 丄丌三丈丈丞万丌丅, float 丕三丛七丕丐世专丆, float 丛七上丟丘丗丈万专, float 丘丗三业丌丕丙丌丛)
    {
        丘丗三业丌丕丙丌丛 = 丘丗三业丌丕丙丌丛 - 丛七上丟丘丗丈万专;
        丕三丛七丕丐世专丆 = 丕三丛七丕丐世专丆 - 丄丌三丈丈丞万丌丅;
        丕三丛七丕丐世专丆 = 丘丗三业丌丕丙丌丛 / 丕三丛七丕丐世专丆;
        丄丌三丈丈丞万丌丅 = 丕三丛七丕丐世专丆 * 丄丌三丈丈丞万丌丅;
        丄丌三丈丈丞万丌丅 = 丛七上丟丘丗丈万专 - 丄丌三丈丈丞万丌丅;
        三丟东丕丄丄下下丑 = 丕三丛七丕丐世专丆 * 三丟东丕丄丄下下丑;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 + 丄丌三丈丈丞万丌丅;
        return (float)三丟东丕丄丄下下丑;
    }
    public void PlaceObjects(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌)
    {
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        int val_30 = 丒丒丄丁且丄丆丂丌;
        int val_32 = 三丟东丕丄丄下下丑;
        this.丄丑丅丟七丅丛下丑.set_Item(index:  0, value:  val_32 + (this.Grid * val_30));
        if(val_32 >= 1)
        {
                int val_25 = this.Grid;
            val_25 = val_32 + (val_25 * val_30);
            val_24 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_25 = 1;
            val_26 = val_25 - 1;
        }
        else
        {
                val_24 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_25 = 1;
            val_26 = 0;
        }
        
        this.丄丑丅丟七丅丛下丑.set_Item(index:  1, value:  0);
        int val_26 = this.Grid;
        if((val_26 - 1) > val_32)
        {
                val_26 = val_32 + (val_26 * val_30);
            val_27 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_28 = 2;
            val_29 = val_26 + 1;
        }
        else
        {
                val_27 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_28 = 2;
            val_29 = 0;
        }
        
        this.丄丑丅丟七丅丛下丑.set_Item(index:  2, value:  0);
        if((this.Grid - 1) > val_30)
        {
                val_30 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_31 = 3;
            val_32 = val_32 + (this.Grid * (val_30 + 1));
        }
        else
        {
                val_30 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_31 = 3;
            val_32 = 0;
        }
        
        this.丄丑丅丟七丅丛下丑.set_Item(index:  3, value:  0);
        int val_27 = this.Grid;
        int val_8 = val_27 - 1;
        if((val_8 > val_32) && (val_8 > val_30))
        {
                val_27 = val_32 + (val_27 * (val_30 + 1));
            val_33 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_34 = 4;
            val_35 = val_27 + 1;
        }
        else
        {
                val_33 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
            val_34 = 4;
            val_35 = 0;
        }
        
        this.丄丑丅丟七丅丛下丑.set_Item(index:  4, value:  0);
        if(val_32 < 1)
        {
            goto label_20;
        }
        
        int val_28 = this.Grid;
        if((val_28 - 1) <= val_30)
        {
            goto label_20;
        }
        
        val_28 = val_32 + (val_28 * (val_30 + 1));
        val_36 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        val_37 = 5;
        val_38 = val_28 - 1;
        goto label_22;
        label_20:
        val_36 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        val_37 = 5;
        val_38 = 0;
        label_22:
        this.丄丑丅丟七丅丛下丑.set_Item(index:  5, value:  0);
        int val_14 = val_30 - 1;
        if(val_32 < 1)
        {
            goto label_24;
        }
        
        this.丄丑丅丟七丅丛下丑.set_Item(index:  6, value:  val_32 + (this.Grid * val_14));
        if(val_32 < 1)
        {
            goto label_26;
        }
        
        int val_29 = this.Grid;
        val_29 = val_32 + (val_29 * val_14);
        val_30 = val_29 - 1;
        this.丄丑丅丟七丅丛下丑.set_Item(index:  7, value:  val_30);
        goto label_28;
        label_24:
        this.丄丑丅丟七丅丛下丑.set_Item(index:  6, value:  0);
        label_26:
        this.丄丑丅丟七丅丛下丑.set_Item(index:  7, value:  0);
        if(val_30 < 1)
        {
            goto label_32;
        }
        
        label_28:
        int val_31 = this.Grid;
        if((val_31 - 1) <= val_32)
        {
            goto label_32;
        }
        
        val_31 = val_32 + (val_31 * val_14);
        val_32 = val_31 + 1;
        val_39 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        val_40 = 8;
        val_41 = val_32;
        goto label_34;
        label_32:
        val_39 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        val_40 = 8;
        val_41 = 0;
        label_34:
        this.丄丑丅丟七丅丛下丑.set_Item(index:  8, value:  0);
        this.丕不丐专丗丁七丁与();
        val_42 = 1;
        goto label_36;
        label_42:
        int val_17 = this.丄丑丅丟七丅丛下丑.Item[this.丄丑丅丟七丅丛下丑];
        if(val_17 != 1)
        {
                if((this.丌丈丕七专丏丌七丞.Contains(item:  val_17)) != true)
        {
                UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  this.业丑上丄丐丈丕丌下(业丈丐丐与丕丕业下:  val_17, 丕丄丝丄丞不丘丅丏:  1f));
        }
        
        }
        
        val_42 = 2;
        label_36:
        if((val_42 - 1) < this.丄丑丅丟七丅丛下丑.Count)
        {
            goto label_42;
        }
        
        val_43 = 0;
        goto label_43;
        label_47:
        this.丌丈丕七专丏丌七丞.set_Item(index:  0, value:  this.丄丑丅丟七丅丛下丑.Item[0]);
        val_43 = 1;
        label_43:
        if(val_43 < this.丄丑丅丟七丅丛下丑.Count)
        {
            goto label_47;
        }
    
    }
    private void 丕不丐专丗丁七丁与()
    {
        goto label_1;
        label_9:
        if(this.丌丈丕七专丏丌七丞.Item[0] != 1)
        {
                if((this.丄丑丅丟七丅丛下丑.Contains(item:  this.丌丈丕七专丏丌七丞.Item[0])) != true)
        {
                this.丛丞丁丕丕丘丝丅丞(业丈丐丐与丕丕业下:  this.丌丈丕七专丏丌七丞.Item[0]);
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.丄丑丅丟七丅丛下丑.Count)
        {
            goto label_9;
        }
    
    }
    private int 且丝世丒丅丏不下与(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌, string 万丄七三丕丛丗丆丆)
    {
        var val_20;
        int val_21;
        int val_21 = 丒丒丄丁且丄丆丂丌;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 - 1;
        val_20 = this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  丒丒丄丁且丄丆丂丌, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆);
        if()
        {
                val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  val_21, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        val_21 = this.Grid;
        if((val_21 - 1) > 三丟东丕丄丄下下丑)
        {
                val_21 = this.Grid;
            val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑 + 1, 丒丒丄丁且丄丆丂丌:  val_21, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        if((val_21 - 1) > val_21)
        {
                val_21 = this.Grid;
            val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  val_21 + 1, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        val_21 = val_21 - 1;
        if((val_21 > 三丟东丕丄丄下下丑) && (val_21 > val_21))
        {
                val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑 + 1, 丒丒丄丁且丄丆丂丌:  val_21 + 1, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        if(val_21 >= val_21)
        {
                int val_20 = this.Grid;
            val_20 = val_20 - 1;
            if(val_20 > val_21)
        {
                val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑 - 1, 丒丒丄丁且丄丆丂丌:  val_21 + 1, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        }
        
        val_21 = val_21 - 1;
        if(val_20 < val_21)
        {
                return (int)val_20;
        }
        
        val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  val_21, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        if(val_20 >= val_21)
        {
                val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑 - 1, 丒丒丄丁且丄丆丂丌:  val_21, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        }
        
        int val_22 = this.Grid;
        val_22 = val_22 - 1;
        if(val_22 <= 三丟东丕丄丄下下丑)
        {
                return (int)val_20;
        }
        
        val_20 = (this.一丒丞丕不丆丄丆丗(三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑 + 1, 丒丒丄丁且丄丆丂丌:  val_21, 万丄七三丕丛丗丆丆:  万丄七三丕丛丗丆丆)) + val_20;
        return (int)val_20;
    }
    private int 一丒丞丕不丆丄丆丗(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌, string 万丄七三丕丛丗丆丆)
    {
        int val_3 = 丒丒丄丁且丄丆丂丌;
        val_3 = 三丟东丕丄丄下下丑 + (this.Grid * val_3);
        Chunk val_4 = this.chunks[(long)val_3];
        if((this.chunks[(long)(int)((this.Grid * 丒丒丄丁且丄丆丂丌) + 三丟东丕丄丄下下丑)][0].positions.ContainsKey(key:  万丄七三丕丛丗丆丆)) == false)
        {
                return 0;
        }
        
        Vector3ListHolder val_2 = this.chunks[(long)(int)((this.Grid * 丒丒丄丁且丄丆丂丌) + 三丟东丕丄丄下下丑)][0].positions.Item[万丄七三丕丛丗丆丆];
        if(val_2.entityList != null)
        {
                return val_2.entityList.Count;
        }
        
        return val_2.entityList.Count;
    }
    private System.Collections.IEnumerator 业丑上丄丐丈丕丌下(int 业丈丐丐与丕丕业下, float 丕丄丝丄丞不丘丅丏)
    {
        TerrainObjectsPull.丈丈丌一不丞丕不丄 val_1 = new TerrainObjectsPull.丈丈丌一不丞丕不丄();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .业丈丐丐与丕丕业下 = 业丈丐丐与丕丕业下;
        }
        else
        {
                mem[32] = this;
            .业丈丐丐与丕丕业下 = 业丈丐丐与丕丕业下;
        }
        
        .丕丄丝丄丞不丘丅丏 = 丕丄丝丄丞不丘丅丏;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丙丌丄万丛三丗丞丁(int 业丈丐丐与丕丕业下)
    {
        TerrainObjectsPull val_18;
        var val_19;
        Chunk val_20;
        var val_21;
        int val_22;
        var val_23;
        val_18 = this;
        val_19 = 1152921526370507600;
        val_20 = this.chunks[(long)业丈丐丐与丕丕业下];
        val_21 = 0;
        goto label_3;
        label_41:
        string val_1 = this.chunks[(long)(int)(业丈丐丐与丕丕业下)][0].objectsInChunk.Item[0];
        val_22 = this.pool.Item[val_1].Item[val_1];
        Vector3ListHolder val_6 = this.chunks[(long)(int)(业丈丐丐与丕丕业下)][0].positions.Item[val_1].Item[val_1].Item[val_1];
        int val_18 = val_2.entityList.Count;
        val_18 = (val_18 - val_22) - val_4.entityList.Count;
        if((val_18 & 2147483648) != 0)
        {
                int val_10 = UnityEngine.Mathf.Abs(value:  val_18);
            val_10.丕丅丕丂丒一丒一丘(万上万丛丌丟丗上丂:  val_2.entityList, 丌丒丝东丌下丕丁丅:  val_10 + 1);
        }
        
        val_23 = 0;
        goto label_24;
        label_36:
        if(val_12._inUse != false)
        {
            
        }
        else
        {
                val_12.currentChunk = 业丈丐丐与丕丕业下;
            val_12._inUse = true;
            val_2.entityList.Item[0].不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
            UnityEngine.Vector3 val_13 = val_4.entityList.Item[0];
            val_12.obj.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Quaternion val_14 = val_5.entityList.Item[0];
            val_12.obj.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
            val_22 = val_22 + 1;
            UnityEngine.Vector3 val_15 = val_6.entityList.Item[0];
            val_12.obj.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        }
        
        val_23 = val_23 + 1;
        label_24:
        if(val_23 < val_4.entityList.Count)
        {
            goto label_36;
        }
        
        val_18 = val_18;
        val_19 = 1152921526370507600;
        val_20 = val_20;
        this.poolUseCounter.set_Item(key:  val_1, value:  val_22);
        val_21 = val_21 + 1;
        label_3:
        if(val_21 < (this.chunks[(long)(int)(业丈丐丐与丕丕业下)][0] + 16.Count))
        {
            goto label_41;
        }
    
    }
    private void 丛丞丁丕丕丘丝丅丞(int 业丈丐丐与丕丕业下)
    {
        var val_7;
        Chunk val_8;
        var val_9;
        int val_10;
        var val_11;
        val_7 = this;
        val_8 = this.chunks[(long)业丈丐丐与丕丕业下];
        val_9 = 0;
        goto label_3;
        label_21:
        string val_1 = this.chunks[(long)(int)(业丈丐丐与丕丕业下)][0].objectsInChunk.Item[0];
        PoolObjListHolder val_2 = this.pool.Item[val_1];
        val_10 = this.poolUseCounter.Item[val_1];
        val_11 = 0;
        goto label_10;
        label_16:
        if((val_4._inUse != false) && (val_4.currentChunk == 业丈丐丐与丕丕业下))
        {
                val_4.currentChunk = 0;
            val_10 = val_10 - 1;
            val_4._inUse = false;
            val_2.entityList.Item[0].不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        }
        
        val_11 = 1;
        label_10:
        if(val_11 < val_2.entityList.Count)
        {
            goto label_16;
        }
        
        val_7 = val_7;
        this.poolUseCounter.set_Item(key:  val_1, value:  val_10);
        val_8 = val_8;
        val_9 = val_9 + 1;
        label_3:
        if(val_9 < (this.chunks[(long)(int)(业丈丐丐与丕丕业下)][0] + 16.Count))
        {
            goto label_21;
        }
    
    }
    private void 丕丅丕丂丒一丒一丘(System.Collections.Generic.List<TerrainObjectsPull.PoolObj> 万上万丛丌丟丗上丂, int 丌丒丝东丌下丕丁丅)
    {
        PoolObj val_1 = 万上万丛丌丟丗上丂.Item[0];
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                int val_6 = 丌丒丝东丌下丕丁丅;
            do
        {
            TerrainObjectsPull.PoolObj val_4 = new TerrainObjectsPull.PoolObj();
            .obj = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_1.obj, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            if((TerrainObjectsPull.PoolObj)[1152921526371524736]._inUse != false)
        {
                ._inUse = false;
            val_4.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        }
        
            .currentChunk = 0;
            万上万丛丌丟丗上丂.Add(item:  val_4);
            val_6 = val_6 - 1;
        }
        while(val_6 != 0);
        
        }
        
        UnityEngine.Debug.Log(message:  "Pool expanded on " + 丌丒丝东丌下丕丁丅);
    }
    private void OnDrawGizmosSelected()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    public TerrainObjectsPull()
    {
        this.minInstances = 5;
        this.pool = new TerrainObjectsPull.MyDictionaryOfPoolObjects();
        this.poolUseCounter = new TerrainObjectsPull.MyDictionaryOfInts();
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>(capacity:  9);
        if(val_3 != null)
        {
                val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
        }
        else
        {
                val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
            val_3.Add(item:  0);
        }
        
        val_3.Add(item:  0);
        this.丌丈丕七专丏丌七丞 = val_3;
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>(capacity:  9);
        if(val_4 != null)
        {
                val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
        }
        else
        {
                val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
            val_4.Add(item:  0);
        }
        
        val_4.Add(item:  0);
        this.丄丑丅丟七丅丛下丑 = val_4;
        this.丁丅丌丏世三丅丈三 = new System.Collections.Generic.List<System.String>();
        this.丆丌丛丅七丂丄丞丈 = new System.Collections.Generic.List<PoolObj>();
        this.丕丄不与丒上丟下三 = new UnityEngine.WaitForEndOfFrame();
    }

}
