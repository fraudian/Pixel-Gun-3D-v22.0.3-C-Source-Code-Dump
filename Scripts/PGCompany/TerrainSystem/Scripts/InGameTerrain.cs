using UnityEngine;

namespace PGCompany.TerrainSystem.Scripts
{
    public class InGameTerrain : MonoBehaviour
    {
        // Fields
        public TerrainData terrainData;
        public bool showPreview;
        private bool 丝丕丈三丐且下丌丌;
        public PGCompany.TerrainSystem.Scripts.InGameTerrain.MeshInstance[] hiMeshes;
        public PGCompany.TerrainSystem.Scripts.InGameTerrain.MeshInstance[] midMeshes;
        public UnityEngine.MeshRenderer[] lowMeshes;
        private bool 丐丗专丙丄不丑丑丆;
        public UnityEngine.Transform playerTransform;
        public UnityEngine.Vector3 lastPlayerPosition;
        private UnityEngine.Vector2 丏丝丏业丁万丛上上;
        private UnityEngine.Vector2 业专丆丅世东三丏与;
        private int 三丗丄下七东下丂丗;
        public PGCompany.TerrainSystem.Scripts.RecalculateHiMeshEvent recalculateHiMeshEvent;
        private UnityEngine.Coroutine 丈丈丆丆专丟丘一丌;
        private UnityEngine.Vector3 丒丕丅丅丛七专专丟;
        private 丅业丅与丄与一丙一 丈下业专七丞专丟丂;
        private UnityEngine.WaitForEndOfFrame 丕丄不与丒上丟下三;
        private PGCompany.TerrainSystem.Scripts.InGameTerrain.丝与丐与丌丞丕丗丁[] 丆下丅丘丟丈丒丞东;
        private PGCompany.TerrainSystem.Scripts.InGameTerrain.丝与丐与丌丞丕丗丁[] 且专上丗丗丙丄上上;
        private UnityEngine.Vector2Int[] 丟丅丐与丈丐丅丈丏;
        private UnityEngine.Vector2Int[] 丗丈丗七且世丙七丆;
        private int 丂丅万上丝不丈三三;
        private float 万丝一丈不下丛丗专;
        private float 丏丈三丕不丝丅不不;
        private UnityEngine.Coroutine 东丞专丌丞丈丅丂业;
        
        // Methods
        private void Start()
        {
            TerrainData val_45;
            TerrainData val_46;
            TerrainData val_47;
            var val_48;
            TerrainData val_49;
            val_45 = 1152921504848912384;
            if(this.terrainData == 0)
            {
                    return;
            }
            
            if(this.playerTransform == 0)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "TerrainPlayerPosition");
                val_3.transform.parent = this.transform;
                this.playerTransform = val_3.transform;
            }
            
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.业世丕丅丞丙三东东(丕丕世且下一与丝与:  1f));
            this.midMeshes = this.万且丄业业丗与下三(丌丒丝东丌下丕丁丅:  16, 丂丐丞一一丏丅丌丟:  true, 丂业丕业丂丅丙一丛:  "Mid_");
            this.hiMeshes = this.万且丄业业丗与下三(丌丒丝东丌下丕丁丅:  9, 丂丐丞一一丏丅丌丟:  false, 丂业丕业丂丅丙一丛:  "Hi_");
            this.丈下业专七丞专丟丂 = new 丅业丅与丄与一丙一(不丅丛专丘丅专丘丕:  1, 不丗上三丛丒上东丑:  this);
            val_46 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_10;
            }
            
            val_46 = this.terrainData;
            if(val_46 == null)
            {
                goto label_74;
            }
            
            label_10:
            int val_12 = this.terrainData.grid * this.terrainData.grid;
            this.丆下丅丘丟丈丒丞东 = new 丝与丐与丌丞丕丗丁[0];
            val_47 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_12;
            }
            
            val_47 = this.terrainData;
            if(val_47 == null)
            {
                goto label_74;
            }
            
            label_12:
            int val_14 = this.terrainData.grid * this.terrainData.grid;
            val_48 = 0;
            this.且专上丗丗丙丄上上 = new 丝与丐与丌丞丕丗丁[0];
            goto label_14;
            label_20:
            this.丆下丅丘丟丈丒丞东[0] = 0;
            val_48 = 1;
            this.且专上丗丗丙丄上上[0] = 0;
            label_14:
            if(val_48 < this.丆下丅丘丟丈丒丞东.Length)
            {
                goto label_20;
            }
            
            UnityEngine.Vector2Int[] val_16 = new UnityEngine.Vector2Int[9];
            this.丟丅丐与丈丐丅丈丏 = val_16;
            DiscreteVector2 val_17 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
            val_16[0] = val_17._x;
            DiscreteVector2 val_18 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
            this.丟丅丐与丈丐丅丈丏[1] = val_18._x;
            DiscreteVector2 val_19 = new DiscreteVector2(三丟东丕丄丄下下丑:  1, 丒丒丄丁且丄丆丂丌:  0);
            this.丟丅丐与丈丐丅丈丏[2] = val_19._x;
            DiscreteVector2 val_20 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
            this.丟丅丐与丈丐丅丈丏[3] = val_20._x;
            DiscreteVector2 val_21 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  1);
            this.丟丅丐与丈丐丅丈丏[4] = val_21._x;
            DiscreteVector2 val_22 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
            this.丟丅丐与丈丐丅丈丏[5] = val_22._x;
            DiscreteVector2 val_23 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  1);
            this.丟丅丐与丈丐丅丈丏[6] = val_23._x;
            DiscreteVector2 val_24 = new DiscreteVector2(三丟东丕丄丄下下丑:  1, 丒丒丄丁且丄丆丂丌:  0);
            this.丟丅丐与丈丐丅丈丏[7] = val_24._x;
            DiscreteVector2 val_25 = new DiscreteVector2(三丟东丕丄丄下下丑:  1, 丒丒丄丁且丄丆丂丌:  1);
            this.丟丅丐与丈丐丅丈丏[8] = val_25._x;
            UnityEngine.Vector2Int[] val_26 = new UnityEngine.Vector2Int[16];
            this.丗丈丗七且世丙七丆 = val_26;
            DiscreteVector2 val_27 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  2);
            val_26[0] = val_27._x;
            DiscreteVector2 val_28 = new DiscreteVector2(三丟东丕丄丄下下丑:  1, 丒丒丄丁且丄丆丂丌:  2);
            this.丗丈丗七且世丙七丆[1] = val_28._x;
            DiscreteVector2 val_29 = new DiscreteVector2(三丟东丕丄丄下下丑:  2, 丒丒丄丁且丄丆丂丌:  2);
            this.丗丈丗七且世丙七丆[2] = val_29._x;
            DiscreteVector2 val_30 = new DiscreteVector2(三丟东丕丄丄下下丑:  2, 丒丒丄丁且丄丆丂丌:  1);
            this.丗丈丗七且世丙七丆[3] = val_30._x;
            DiscreteVector2 val_31 = new DiscreteVector2(三丟东丕丄丄下下丑:  2, 丒丒丄丁且丄丆丂丌:  0);
            this.丗丈丗七且世丙七丆[4] = val_31._x;
            DiscreteVector2 val_32 = new DiscreteVector2(三丟东丕丄丄下下丑:  2, 丒丒丄丁且丄丆丂丌:  0);
            this.丗丈丗七且世丙七丆[5] = val_32._x;
            DiscreteVector2 val_33 = new DiscreteVector2(三丟东丕丄丄下下丑:  2, 丒丒丄丁且丄丆丂丌:  -2);
            this.丗丈丗七且世丙七丆[6] = val_33._x;
            DiscreteVector2 val_34 = new DiscreteVector2(三丟东丕丄丄下下丑:  1, 丒丒丄丁且丄丆丂丌:  -2);
            this.丗丈丗七且世丙七丆[7] = val_34._x;
            DiscreteVector2 val_35 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  -2);
            this.丗丈丗七且世丙七丆[8] = val_35._x;
            DiscreteVector2 val_36 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  -2);
            this.丗丈丗七且世丙七丆[9] = val_36._x;
            DiscreteVector2 val_37 = new DiscreteVector2(三丟东丕丄丄下下丑:  -2, 丒丒丄丁且丄丆丂丌:  -2);
            this.丗丈丗七且世丙七丆[10] = val_37._x;
            DiscreteVector2 val_38 = new DiscreteVector2(三丟东丕丄丄下下丑:  -2, 丒丒丄丁且丄丆丂丌:  0);
            this.丗丈丗七且世丙七丆[11] = val_38._x;
            DiscreteVector2 val_39 = new DiscreteVector2(三丟东丕丄丄下下丑:  -2, 丒丒丄丁且丄丆丂丌:  0);
            this.丗丈丗七且世丙七丆[12] = val_39._x;
            DiscreteVector2 val_40 = new DiscreteVector2(三丟东丕丄丄下下丑:  -2, 丒丒丄丁且丄丆丂丌:  1);
            this.丗丈丗七且世丙七丆[13] = val_40._x;
            DiscreteVector2 val_41 = new DiscreteVector2(三丟东丕丄丄下下丑:  -2, 丒丒丄丁且丄丆丂丌:  2);
            this.丗丈丗七且世丙七丆[14] = val_41._x;
            DiscreteVector2 val_42 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  2);
            this.丗丈丗七且世丙七丆[15] = val_42._x;
            val_49 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_71;
            }
            
            val_49 = this.terrainData;
            if(val_49 == null)
            {
                goto label_74;
            }
            
            label_71:
            int val_45 = this.terrainData.minitexWidth;
            val_45 = val_49;
            val_45 = val_45 - 1;
            val_45 = val_45 / this.terrainData.grid;
            this.丂丅万上丝不丈三三 = val_45;
            if(val_49 != null)
            {
                goto label_73;
            }
            
            val_45 = this.terrainData;
            if(val_45 == null)
            {
                goto label_74;
            }
            
            label_73:
            float val_46 = (float)this.terrainData.grid;
            val_46 = this.terrainData.size / val_46;
            this.万丝一丈不下丛丗专 = val_46;
            float val_47 = this.terrainData.MaxHeight;
            val_47 = val_47 / 255f;
            this.丏丈三丕不丝丅不不 = val_47;
            UnityEngine.Coroutine val_44 = this.StartCoroutine(routine:  this.业丒与丝七丄世丝且());
            return;
            label_74:
        }
        private int 万万且丛上丘丄七丝(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            float val_4 = (float)this.terrainData.grid;
            val_4 = 丞丟丆一丄七与丝丒.x * val_4;
            float val_5 = (float)this.terrainData.grid;
            val_5 = 丞丟丆一丄七与丝丒.y * val_5;
            return (int)(UnityEngine.Mathf.FloorToInt(f:  val_4)) + (this.terrainData.grid * (UnityEngine.Mathf.FloorToInt(f:  val_5)));
        }
        private int 丙丆丑业专万丟丐一(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌, int 与丘东下丈东丛丂万)
        {
            return (int)三丟东丕丄丄下下丑 + (与丘东下丈东丛丂万 * 丒丒丄丁且丄丆丂丌);
        }
        private System.Collections.IEnumerator 业世丕丅丞丙三东东(float 丕丕世且下一与丝与)
        {
            InGameTerrain.且上丄专丛丌丈专丆 val_1 = new InGameTerrain.且上丄专丛丌丈专丆(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        private PGCompany.TerrainSystem.Scripts.InGameTerrain.MeshInstance[] 万且丄业业丗与下三(int 丌丒丝东丌下丕丁丅, bool 丂丐丞一一丏丅丌丟, string 丂业丕业丂丅丙一丛 = "")
        {
            UnityEngine.Transform val_14;
            UnityEngine.MeshRenderer val_15;
            UnityEngine.MeshFilter val_16;
            val_14 = 丂丐丞一一丏丅丌丟;
            MeshInstance[] val_1 = new MeshInstance[0];
            if(丌丒丝东丌下丕丁丅 < 1)
            {
                    return val_1;
            }
            
            object val_13 = 0;
            do
            {
                UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  System.String.Format(format:  "{0}MeshInstance_{1}", arg0:  丂业丕业丂丅丙一丛, arg1:  val_13));
                val_4.transform.parent = this.transform;
                if(val_4 != null)
            {
                    val_4.hideFlags = 8;
                val_15 = val_4.AddComponent<UnityEngine.MeshRenderer>();
                val_16 = val_4.AddComponent<UnityEngine.MeshFilter>();
            }
            else
            {
                    0.hideFlags = 8;
                val_15 = val_4.AddComponent<UnityEngine.MeshRenderer>();
                val_16 = val_4.AddComponent<UnityEngine.MeshFilter>();
            }
            
                val_14 = val_4.transform;
                UnityEngine.Mesh val_12 = new UnityEngine.Mesh();
                val_12.MarkDynamic();
                val_16.sharedMesh = val_12;
                mem2[0] = val_13;
                val_13 = val_13 + 1;
                mem2[0] = val_15;
                mem2[0] = val_16;
                mem2[0] = val_12;
                mem2[0] = val_14;
                val_1[0x28].Length = val_14;
                mem2[0] = 1;
                mem2[0] = 0;
            }
            while(丌丒丝东丌下丕丁丅 != val_13);
            
            return val_1;
        }
        private void Update()
        {
            int val_1 = this.NeedUpdate();
            UnityEngine.Vector3 val_2 = this.playerTransform.position;
            if(val_2.y >= 0)
            {
                goto label_2;
            }
            
            if(val_1 == 2)
            {
                goto label_3;
            }
            
            if(val_1 != 1)
            {
                    return;
            }
            
            this.丟丛丛丛丞专三丅丟(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上, y = val_2.y});
            this.UpdateTerrain();
            return;
            label_2:
            if(val_1 == 0)
            {
                    return;
            }
            
            this.丟丛丛丛丞专三丅丟(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上, y = val_2.y});
            return;
            label_3:
            this.丟丛丛丛丞专三丅丟(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上, y = val_2.y});
            this.UpdateTerrainForce();
        }
        public int NeedUpdate()
        {
            var val_18;
            UnityEngine.Vector3 val_19;
            float val_20;
            float val_21;
            var val_22;
            if(this.丐丗专丙丄不丑丑丆 == false)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = this.playerTransform.position;
            val_18 = 1152921504838316032;
            val_19 = this.lastPlayerPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_19, y = V11.16B, z = V10.16B});
            val_21 = val_2.x;
            UnityEngine.Vector3 val_3 = this.playerTransform.position;
            this.lastPlayerPosition = val_3;
            mem[1152921556182498532] = val_3.y;
            mem[1152921556182498536] = val_3.z;
            if(val_21 > 50f)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_4 = this.playerTransform.position;
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_19 = val_6.y;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_19, z = val_6.z});
            val_20 = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_20}, d:  this.terrainData.size);
            this.丒丕丅丅丛七专专丟 = val_8;
            mem[1152921556182498580] = val_8.y;
            mem[1152921556182498584] = val_8.z;
            this.丏丝丏业丁万丛上上 = UnityEngine.Mathf.Clamp01(value:  val_8.x);
            mem[1152921556182498544] = UnityEngine.Mathf.Clamp01(value:  val_8.y);
            float val_18 = (float)this.terrainData.grid;
            val_18 = this.丏丝丏业丁万丛上上 * val_18;
            val_18 = UnityEngine.Mathf.FloorToInt(f:  val_18);
            float val_19 = (float)this.terrainData.grid;
            val_19 = this.丏丝丏业丁万丛上上 * val_19;
            int val_13 = this.万万且丛上丘丄七丝(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上, y = val_8.y});
            if(val_13 != this.三丗丄下七东下丂丗)
            {
                goto label_16;
            }
            
            label_1:
            val_22 = 0;
            return (int)val_22;
            label_16:
            this.三丗丄下七东下丂丗 = val_13;
            val_21 = (float)val_18;
            if((System.Math.Abs(this.业专丆丅世东三丏与 - val_21)) <= 1f)
            {
                goto label_20;
            }
            
            val_18 = 1152921556182498552;
            goto label_21;
            label_20:
            val_18 = this;
            if((System.Math.Abs(val_20 - ((float)UnityEngine.Mathf.FloorToInt(f:  val_19)))) <= 1f)
            {
                goto label_24;
            }
            
            label_21:
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_21, y:  (float)UnityEngine.Mathf.FloorToInt(f:  val_19));
            this.业专丆丅世东三丏与 = val_16.x;
            mem[1152921556182498552] = val_16.y;
            label_6:
            val_22 = 2;
            return (int)val_22;
            label_24:
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_21, y:  (float)UnityEngine.Mathf.FloorToInt(f:  val_19));
            this.业专丆丅世东三丏与 = val_17.x;
            mem[1152921556182498552] = val_17.y;
            return (int)val_22;
        }
        public void UpdateTerrain()
        {
            System.Collections.IEnumerator[] val_1 = new System.Collections.IEnumerator[1];
            System.Collections.IEnumerator val_2 = this.丗下业与丗丒丅一丘(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上});
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this.丈下业专七丞专丟丂.丐不上业三丁丏丐世(七丛丏七丏丘业丞一:  val_1);
            System.Collections.IEnumerator[] val_3 = new System.Collections.IEnumerator[1];
            System.Collections.IEnumerator val_4 = this.丐业丆丁丘丛与与丂(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上});
            if(val_3 == null)
            {
                goto label_8;
            }
            
            if(val_4 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_4 == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_3[0] = val_4;
            this.丈下业专七丞专丟丂.丐不上业三丁丏丐世(七丛丏七丏丘业丞一:  val_3);
            System.Collections.IEnumerator[] val_5 = new System.Collections.IEnumerator[1];
            System.Collections.IEnumerator val_6 = this.上丝丈丞丒丘万丌万(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = this.丏丝丏业丁万丛上上});
            if(val_5 == null)
            {
                goto label_15;
            }
            
            if(val_6 != null)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            if(val_6 == null)
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            val_5[0] = val_6;
            this.丈下业专七丞专丟丂.丐不上业三丁丏丐世(七丛丏七丏丘业丞一:  val_5);
            System.Collections.IEnumerator[] val_7 = new System.Collections.IEnumerator[1];
            System.Collections.IEnumerator val_8 = this.丌丑东业三丛丞丙丗();
            if(val_7 == null)
            {
                goto label_22;
            }
            
            if(val_8 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_8 == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            val_7[0] = val_8;
            this.丈下业专七丞专丟丂.丐不上业三丁丏丐世(七丛丏七丏丘业丞一:  val_7);
            System.Collections.IEnumerator[] val_9 = new System.Collections.IEnumerator[1];
            System.Collections.IEnumerator val_10 = this.丙与不丁丟丅丄丁丙();
            if(val_9 == null)
            {
                goto label_29;
            }
            
            if(val_10 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(val_10 == null)
            {
                goto label_33;
            }
            
            label_30:
            label_33:
            val_9[0] = val_10;
            this.丈下业专七丞专丟丂.丐不上业三丁丏丐世(七丛丏七丏丘业丞一:  val_9);
            this.丈下业专七丞专丟丂.业丁丝丟丌丂丛丄三();
        }
        public void UpdateTerrainForce()
        {
            if(this.东丞专丌丞丈丅丂业 != null)
            {
                    return;
            }
            
            this.东丞专丌丞丈丅丂业 = this.StartCoroutine(routine:  this.丗丙东上丞丑上丆丞());
        }
        private System.Collections.IEnumerator 丗丙东上丞丑上丆丞()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InGameTerrain.丗丁且世东上下与万(丗丏丅丕丆世丁专丟:  0);
        }
        private System.Collections.IEnumerator 丙与不丁丟丅丄丁丙()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InGameTerrain.丞世万丛三丄丅万丛(丗丏丅丕丆世丁专丟:  0);
        }
        private void 丁丛丂一丙三上丕与()
        {
            goto label_0;
            label_6:
            0 = 1;
            this.丆下丅丘丟丈丒丞东[0] = this.且专上丗丗丙丄上上[0];
            label_0:
            if(0 < this.且专上丗丗丙丄上上.Length)
            {
                goto label_6;
            }
        
        }
        private System.Collections.IEnumerator 丗下业与丗丒丅一丘(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            InGameTerrain.七上且七丏丟丂一丘 val_1 = new InGameTerrain.七上且七丏丟丂一丘();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丞丟丆一丄七与丝丒 = 丞丟丆一丄七与丝丒;
            mem[1152921556183628636] = 丞丟丆一丄七与丝丒.y;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 业丏丅丛丞一丞东丟(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            TerrainData val_27;
            var val_28;
            TerrainData val_29;
            var val_30;
            var val_31;
            TerrainData val_32;
            val_23 = 0;
            goto label_1;
            label_5:
            val_23 = 1;
            this.且专上丗丗丙丄上上[0] = 0;
            label_1:
            if(val_23 < this.且专上丗丗丙丄上上.Length)
            {
                goto label_5;
            }
            
            val_24 = 0;
            goto label_6;
            label_10:
            val_24 = 1;
            mem[65] = 1;
            label_6:
            if(val_24 < (mem[this.hiMeshes] + 24))
            {
                goto label_10;
            }
            
            val_25 = 0;
            goto label_11;
            label_15:
            val_25 = 1;
            mem[65] = 1;
            label_11:
            if(val_25 < (mem[this.midMeshes] + 24))
            {
                goto label_15;
            }
            
            float val_23 = (float)this.terrainData.grid;
            val_23 = 丞丟丆一丄七与丝丒.x * val_23;
            int val_3 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_23), min:  0, max:  this.terrainData.grid - 1);
            float val_24 = (float)this.terrainData.grid;
            val_24 = 丞丟丆一丄七与丝丒.y * val_24;
            int val_6 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_24), min:  0, max:  this.terrainData.grid - 1);
            val_26 = 0;
            goto label_22;
            label_57:
            this.丟丅丐与丈丐丅丈丏[0] = this.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂() + val_3;
            if((this.丟丅丐与丈丐丅丈丏[0] & 2147483648) != 0)
            {
                goto label_53;
            }
            
            val_27 = this.terrainData;
            if((this.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂() + val_3) >= this.terrainData.grid)
            {
                goto label_53;
            }
            
            if((this.丟丅丐与丈丐丅丈丏[0][32][val_6] & 2147483648) != 0)
            {
                goto label_53;
            }
            
            val_27 = this.terrainData;
            if(this.丟丅丐与丈丐丅丈丏[0][32][val_6] >= this.terrainData.grid)
            {
                goto label_53;
            }
            
            int val_27 = this.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂();
            val_27 = this.terrainData;
            if(val_27 == null)
            {
                    val_28 = 0;
            }
            
            val_27 = (val_27 + val_3) + (this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0][32][val_6]);
            if((val_27 & 2147483648) != 0)
            {
                goto label_53;
            }
            
            val_29 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_43;
            }
            
            val_28 = 0;
            val_29 = this.terrainData;
            if(val_29 == null)
            {
                goto label_80;
            }
            
            label_43:
            int val_28 = this.terrainData.grid;
            val_28 = val_28 * this.terrainData.grid;
            if(val_27 < val_28)
            {
                    if(this.且专上丗丗丙丄上上 == null)
            {
                    val_28 = 0;
            }
            
                this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2] = 2;
                if(this.且专上丗丗丙丄上上 == null)
            {
                    val_28 = 0;
            }
            
                val_27 = this.丆下丅丘丟丈丒丞东;
                if(val_27 == null)
            {
                    val_28 = 0;
            }
            
                if((this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2]) == (val_27[((long)(int)((this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2]))
            {
                    int val_13 = this.丁一万上丛专丗丘丑(丆丌丕七丘丛世世丒: ref  this.hiMeshes, 丏万丝丕不丏丐丝丞:  val_27);
                if(val_13 != 1)
            {
                    var val_14 = mem[this.hiMeshes] + ((long)val_13 * 40);
                mem2[0] = 0;
            }
            
            }
            
            }
            
            label_53:
            val_26 = 1;
            label_22:
            if(val_26 < this.丟丅丐与丈丐丅丈丏.Length)
            {
                goto label_57;
            }
            
            val_30 = 0;
            goto label_58;
            label_93:
            this.丗丈丗七且世丙七丆[0] = this.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂() + val_3;
            if((this.丗丈丗七且世丙七丆[0] & 2147483648) != 0)
            {
                goto label_89;
            }
            
            val_27 = this.terrainData;
            if((this.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂() + val_3) >= this.terrainData.grid)
            {
                goto label_89;
            }
            
            if((this.丗丈丗七且世丙七丆[0][32][val_6] & 2147483648) != 0)
            {
                goto label_89;
            }
            
            val_27 = this.terrainData;
            if(this.丗丈丗七且世丙七丆[0][32][val_6] >= this.terrainData.grid)
            {
                goto label_89;
            }
            
            int val_33 = this.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂();
            val_27 = this.terrainData;
            if(val_27 == null)
            {
                    val_31 = 0;
            }
            
            val_33 = (val_33 + val_3) + (this.terrainData.grid * this.丗丈丗七且世丙七丆[0][32][val_6]);
            if((val_33 & 2147483648) != 0)
            {
                goto label_89;
            }
            
            val_32 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_79;
            }
            
            val_31 = 0;
            val_32 = this.terrainData;
            if(val_32 == null)
            {
                goto label_80;
            }
            
            label_79:
            int val_34 = this.terrainData.grid;
            val_34 = val_34 * this.terrainData.grid;
            if(val_33 < val_34)
            {
                    if(this.且专上丗丗丙丄上上 == null)
            {
                    val_31 = 0;
            }
            
                this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2] = 1;
                if(this.且专上丗丗丙丄上上 == null)
            {
                    val_31 = 0;
            }
            
                val_27 = this.丆下丅丘丟丈丒丞东;
                if(val_27 == null)
            {
                    val_31 = 0;
            }
            
                if((this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2]) == (val_27[((long)(int)((this.terrainData.grid * this.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2]))
            {
                    int val_21 = this.丁一万上丛专丗丘丑(丆丌丕七丘丛世世丒: ref  this.midMeshes, 丏万丝丕不丏丐丝丞:  val_33);
                if(val_21 != 1)
            {
                    var val_22 = mem[this.midMeshes] + ((long)val_21 * 40);
                mem2[0] = 0;
            }
            
            }
            
            }
            
            label_89:
            val_30 = 1;
            label_58:
            if(val_30 < this.丗丈丗七且世丙七丆.Length)
            {
                goto label_93;
            }
            
            return;
            label_80:
        }
        private System.Collections.IEnumerator 丌丑东业三丛丞丙丗()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InGameTerrain.七上七丗上一世七丂();
        }
        private System.Collections.IEnumerator 业丒与丝七丄世丝且()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InGameTerrain.三业万万丗东不丛丙(丗丏丅丕丆世丁专丟:  0);
        }
        private int 丁一万上丛专丗丘丑(ref PGCompany.TerrainSystem.Scripts.InGameTerrain.MeshInstance[] 丆丌丕七丘丛世世丒, int 丏万丝丕不丏丐丝丞)
        {
            MeshInstance[] val_3;
            var val_4;
            MeshInstance[] val_5;
            T[] val_6;
            val_3 = 丏万丝丕不丏丐丝丞;
            val_4 = 0;
            goto label_1;
            label_6:
            val_5 = 0;
            if(5 == val_3)
            {
                goto label_4;
            }
            
            val_4 = 1;
            label_1:
            val_5 = 丆丌丕七丘丛世世丒;
            if(val_4 < 丆丌丕七丘丛世世丒.Length)
            {
                goto label_6;
            }
            
            val_6 = 0;
            return (int)System.Array.IndexOf<MeshInstance>(array:  val_6 = val_3, value:  new MeshInstance() {mr = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 32, mf = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 32, mesh = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 48, trans = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 48, usePreviewMaterial = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64, canMove = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64, gridi = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64});
            label_4:
            val_3 = 丆丌丕七丘丛世世丒;
            var val_1 = val_3 + (val_5 * 40);
            return (int)System.Array.IndexOf<MeshInstance>(array:  val_6, value:  new MeshInstance() {mr = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 32, mf = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 32, mesh = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 48, trans = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 48, usePreviewMaterial = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64, canMove = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64, gridi = (val_5 * 40) + 丆丌丕七丘丛世世丒 + 64});
        }
        private int 一丗丗丌万东丏丗丄(ref PGCompany.TerrainSystem.Scripts.InGameTerrain.MeshInstance[] 丆丌丕七丘丛世世丒)
        {
            MeshInstance[] val_3;
            var val_4;
            T[] val_5;
            val_3 = 1152921556185958848;
            val_4 = 0;
            goto label_1;
            label_6:
            if(0 != 0)
            {
                goto label_4;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < 丆丌丕七丘丛世世丒.Length)
            {
                goto label_6;
            }
            
            val_5 = 0;
            return (int)System.Array.IndexOf<MeshInstance>(array:  val_5 = val_3, value:  new MeshInstance() {mr = (0 * 40) + 丆丌丕七丘丛世世丒 + 32, mf = (0 * 40) + 丆丌丕七丘丛世世丒 + 32, mesh = (0 * 40) + 丆丌丕七丘丛世世丒 + 48, trans = (0 * 40) + 丆丌丕七丘丛世世丒 + 48, usePreviewMaterial = (0 * 40) + 丆丌丕七丘丛世世丒 + 64, canMove = (0 * 40) + 丆丌丕七丘丛世世丒 + 64, gridi = (0 * 40) + 丆丌丕七丘丛世世丒 + 64});
            label_4:
            val_3 = 丆丌丕七丘丛世世丒;
            var val_1 = val_3 + (0 * 40);
            return (int)System.Array.IndexOf<MeshInstance>(array:  val_5, value:  new MeshInstance() {mr = (0 * 40) + 丆丌丕七丘丛世世丒 + 32, mf = (0 * 40) + 丆丌丕七丘丛世世丒 + 32, mesh = (0 * 40) + 丆丌丕七丘丛世世丒 + 48, trans = (0 * 40) + 丆丌丕七丘丛世世丒 + 48, usePreviewMaterial = (0 * 40) + 丆丌丕七丘丛世世丒 + 64, canMove = (0 * 40) + 丆丌丕七丘丛世世丒 + 64, gridi = (0 * 40) + 丆丌丕七丘丛世世丒 + 64});
        }
        private void 丟丛丛丛丞专三丅丟(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            if(this.丈丈丆丆专丟丘一丌 != null)
            {
                    return;
            }
            
            this.丈丈丆丆专丟丘一丌 = this.StartCoroutine(routine:  this.专丞丙丄不一丟丛丗(丞丟丆一丄七与丝丒:  new UnityEngine.Vector2() {x = 丞丟丆一丄七与丝丒.x, y = 丞丟丆一丄七与丝丒.y}));
        }
        private System.Collections.IEnumerator 专丞丙丄不一丟丛丗(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            InGameTerrain.万丐丑丁上不丌一丈 val_1 = new InGameTerrain.万丐丑丁上不丌一丈();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丞丟丆一丄七与丝丒 = 丞丟丆一丄七与丝丒;
            mem[1152921556186215580] = 丞丟丆一丄七与丝丒.y;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丐业丆丁丘丛与与丂(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            InGameTerrain.业丒东三丗丄七下丝 val_1 = new InGameTerrain.业丒东三丗丄七下丝(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丞丟丆一丄七与丝丒 = 丞丟丆一丄七与丝丒;
            mem[1152921556186335764] = 丞丟丆一丄七与丝丒.y;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丑丙上丐专丗丑丌丌(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            int val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            TerrainData val_37;
            var val_38;
            System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_39;
            UnityEngine.Material val_40;
            TerrainData val_41;
            float val_42;
            float val_31 = (float)this.terrainData.grid;
            val_31 = 丞丟丆一丄七与丝丒.x * val_31;
            float val_32 = (float)this.terrainData.grid;
            val_32 = 丞丟丆一丄七与丝丒.y * val_32;
            val_32 = UnityEngine.Mathf.FloorToInt(f:  val_32);
            val_33 = 0;
            goto label_89;
            label_93:
            val_34 = this.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂();
            int val_8 = val_34 + (UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_31), min:  0, max:  this.terrainData.grid - 1));
            if(this.terrainData == null)
            {
                    val_35 = 0;
            }
            
            val_32 = val_8 + (this.terrainData.grid * (this.丟丅丐与丈丐丅丈丏[0][32][UnityEngine.Mathf.Clamp(value:  val_32, min:  0, max:  this.terrainData.grid - 1)]));
            if((val_32 & 2147483648) != 0)
            {
                goto label_21;
            }
            
            val_37 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_14;
            }
            
            val_35 = 0;
            val_37 = this.terrainData;
            if(val_37 == null)
            {
                goto label_90;
            }
            
            label_14:
            int val_33 = this.terrainData.grid;
            val_33 = val_33 * this.terrainData.grid;
            if(val_32 >= val_33)
            {
                goto label_21;
            }
            
            if(this.且专上丗丗丙丄上上 == null)
            {
                    val_35 = 0;
            }
            
            val_34 = (long)val_32;
            if(this.丆下丅丘丟丈丒丞东 == null)
            {
                    val_35 = 0;
            }
            
            if((this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_7 + val_3))) << 2]) == (this.丆下丅丘丟丈丒丞东[((long)(int)((this.terrainData.grid * this.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_7 + val_3))) << 2]))
            {
                goto label_21;
            }
            
            var val_11 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            if((this.且专上丗丗丙丄上上[(((long)(int)(val_10) * 40) + this.hiMeshes + 68) << 2]) != 2)
            {
                    var val_12 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
                this.lowMeshes[((long)(int)(val_10) * 40) + this.hiMeshes + 68].enabled = true;
            }
            
            System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_13 = this.丕丆丗丏丒东丝丄丒(万丘丞丈丛丟丐丛丐:  val_8, 丒丌丝与与丟丘丄业:  this.丟丅丐与丈丐丅丈丏[0][32][UnityEngine.Mathf.Clamp(value:  val_32, min:  0, max:  this.terrainData.grid - 1)], 丁与丞丞万丄丐丝一:  1, 丛七丄世上丘丅七丝:  this.terrainData, 不一丅丟丐一丐东丘:  this.丂丅万上丝不丈三三, 丘丕丝上下丄丈丏丒:  this.万丝一丈不下丛丗专);
            val_38 = 0;
            goto label_32;
            label_37:
            if(5 == val_32)
            {
                    64.enabled = false;
            }
            
            val_38 = 1;
            label_32:
            if(val_38 < this.midMeshes.Length)
            {
                goto label_37;
            }
            
            var val_14 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.hiMeshes + 32.enabled = true;
            var val_15 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            var val_16 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            if(this.terrainData == null)
            {
                goto label_45;
            }
            
            if((((long)(int)(val_10) * 40) + this.hiMeshes + 64) == 0)
            {
                goto label_46;
            }
            
            label_48:
            val_39 = val_13;
            val_40 = this.terrainData.previewTerrainMaterialLow;
            goto label_47;
            label_45:
            if((((long)(int)(val_10) * 40) + this.hiMeshes + 64) != 0)
            {
                goto label_48;
            }
            
            label_46:
            val_39 = val_13;
            label_47:
            ((long)(int)(val_10) * 40) + this.hiMeshes + 32.sharedMaterial = 1152921508815298768;
            var val_17 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            UnityEngine.Vector3 val_19 = this.lowMeshes[val_34].transform.position;
            ((long)(int)(val_10) * 40) + this.hiMeshes + 56.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            var val_20 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            mem2[0] = val_32;
            var val_21 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            mem2[0] = 0;
            this.lowMeshes[val_34].enabled = false;
            var val_22 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.hiMeshes + 48.vertices = val_39.Item2;
            var val_24 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.hiMeshes + 48.uv = val_39.Item3;
            val_41 = this.terrainData;
            if(val_41 == null)
            {
                goto label_74;
            }
            
            val_42 = this.terrainData.size;
            goto label_75;
            label_74:
            val_42 = this.terrainData.size;
            if(this.terrainData == null)
            {
                goto label_76;
            }
            
            val_41 = this.terrainData;
            label_75:
            label_91:
            float val_41 = (float)this.terrainData.grid;
            val_41 = val_42 / val_41;
            var val_26 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
            ((long)(int)(val_10) * 40) + this.hiMeshes + 48.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
            var val_28 = this.hiMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            val_36 = mem[((long)(int)(val_10) * 40) + this.hiMeshes + 48];
            val_36 = ((long)(int)(val_10) * 40) + this.hiMeshes + 48;
            val_36.SetIndices(indices:  val_39.Item1, topology:  0, submesh:  0);
            val_32 = mem[this.hiMeshes];
            val_32 = this.hiMeshes;
            var val_30 = val_32 + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.hiMeshes)) * 40);
            val_34 = mem[((long)(int)(val_10) * 40) + this.hiMeshes + 48];
            val_34 = ((long)(int)(val_10) * 40) + this.hiMeshes + 48;
            val_34.RecalculateNormals();
            label_21:
            val_33 = 1;
            goto label_89;
            label_76:
            if(this.terrainData == null)
            {
                goto label_90;
            }
            
            goto label_91;
            label_89:
            if(val_33 < this.丟丅丐与丈丐丅丈丏.Length)
            {
                goto label_93;
            }
            
            return;
            label_90:
        }
        private System.Collections.IEnumerator 上丝丈丞丒丘万丌万(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            InGameTerrain.一万丅丂丘上七不丛 val_1 = new InGameTerrain.一万丅丂丘上七不丛();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丞丟丆一丄七与丝丒 = 丞丟丆一丄七与丝丒;
            mem[1152921556187889940] = 丞丟丆一丄七与丝丒.y;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丘业丗丄专专一一与(UnityEngine.Vector2 丞丟丆一丄七与丝丒)
        {
            int val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            TerrainData val_36;
            var val_37;
            System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_38;
            UnityEngine.Material val_39;
            TerrainData val_40;
            float val_41;
            float val_30 = (float)this.terrainData.grid;
            val_30 = 丞丟丆一丄七与丝丒.x * val_30;
            float val_31 = (float)this.terrainData.grid;
            val_31 = 丞丟丆一丄七与丝丒.y * val_31;
            val_31 = UnityEngine.Mathf.FloorToInt(f:  val_31);
            val_32 = 0;
            goto label_86;
            label_90:
            val_33 = this.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂();
            int val_8 = val_33 + (UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_30), min:  0, max:  this.terrainData.grid - 1));
            if(this.terrainData == null)
            {
                    val_34 = 0;
            }
            
            val_31 = val_8 + (this.terrainData.grid * (this.丗丈丗七且世丙七丆[0][32][UnityEngine.Mathf.Clamp(value:  val_31, min:  0, max:  this.terrainData.grid - 1)]));
            if((val_31 & 2147483648) != 0)
            {
                goto label_21;
            }
            
            val_36 = this.terrainData;
            if(this.terrainData != null)
            {
                goto label_14;
            }
            
            val_34 = 0;
            val_36 = this.terrainData;
            if(val_36 == null)
            {
                goto label_87;
            }
            
            label_14:
            int val_32 = this.terrainData.grid;
            val_32 = val_32 * this.terrainData.grid;
            if(val_31 >= val_32)
            {
                goto label_21;
            }
            
            if(this.且专上丗丗丙丄上上 == null)
            {
                    val_34 = 0;
            }
            
            val_33 = (long)val_31;
            if(this.丆下丅丘丟丈丒丞东 == null)
            {
                    val_34 = 0;
            }
            
            if((this.且专上丗丗丙丄上上[((long)(int)((this.terrainData.grid * this.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_7 + val_3))) << 2]) == (this.丆下丅丘丟丈丒丞东[((long)(int)((this.terrainData.grid * this.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_7 + val_3))) << 2]))
            {
                goto label_21;
            }
            
            var val_11 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            if((this.且专上丗丗丙丄上上[(((long)(int)(val_10) * 40) + this.midMeshes + 68) << 2]) == 0)
            {
                    var val_12 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
                this.lowMeshes[((long)(int)(val_10) * 40) + this.midMeshes + 68].enabled = true;
            }
            
            System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_13 = this.丕丆丗丏丒东丝丄丒(万丘丞丈丛丟丐丛丐:  val_8, 丒丌丝与与丟丘丄业:  this.丗丈丗七且世丙七丆[0][32][UnityEngine.Mathf.Clamp(value:  val_31, min:  0, max:  this.terrainData.grid - 1)], 丁与丞丞万丄丐丝一:  2, 丛七丄世上丘丅七丝:  this.terrainData, 不一丅丟丐一丐东丘:  this.丂丅万上丝不丈三三, 丘丕丝上下丄丈丏丒:  this.万丝一丈不下丛丗专);
            val_37 = 0;
            goto label_32;
            label_37:
            if(5 == val_31)
            {
                    64.enabled = false;
            }
            
            val_37 = 1;
            label_32:
            if(val_37 < this.hiMeshes.Length)
            {
                goto label_37;
            }
            
            var val_14 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.midMeshes + 32.enabled = true;
            var val_15 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            var val_16 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            if(this.terrainData == null)
            {
                goto label_45;
            }
            
            if((((long)(int)(val_10) * 40) + this.midMeshes + 64) == 0)
            {
                goto label_46;
            }
            
            label_48:
            val_38 = val_13;
            val_39 = this.terrainData.previewTerrainMaterialMid;
            goto label_47;
            label_45:
            if((((long)(int)(val_10) * 40) + this.midMeshes + 64) != 0)
            {
                goto label_48;
            }
            
            label_46:
            val_38 = val_13;
            label_47:
            ((long)(int)(val_10) * 40) + this.midMeshes + 32.sharedMaterial = 1152921508815298768;
            var val_17 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            UnityEngine.Vector3 val_19 = this.lowMeshes[val_33].transform.position;
            ((long)(int)(val_10) * 40) + this.midMeshes + 56.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            var val_20 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            mem2[0] = val_31;
            var val_21 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            mem2[0] = 0;
            this.lowMeshes[val_33].enabled = false;
            var val_22 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.midMeshes + 48.vertices = val_38.Item2;
            var val_24 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            ((long)(int)(val_10) * 40) + this.midMeshes + 48.uv = val_38.Item3;
            val_40 = this.terrainData;
            if(val_40 == null)
            {
                goto label_74;
            }
            
            val_41 = this.terrainData.size;
            goto label_75;
            label_74:
            val_41 = this.terrainData.size;
            if(this.terrainData == null)
            {
                goto label_76;
            }
            
            val_40 = this.terrainData;
            label_75:
            label_88:
            float val_40 = (float)this.terrainData.grid;
            val_40 = val_41 / val_40;
            var val_26 = this.midMeshes + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            val_35 = mem[((long)(int)(val_10) * 40) + this.midMeshes + 48];
            val_35 = ((long)(int)(val_10) * 40) + this.midMeshes + 48;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
            val_35.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
            val_31 = mem[this.midMeshes];
            val_31 = this.midMeshes;
            var val_28 = val_31 + (((long)this.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.midMeshes)) * 40);
            val_33 = mem[((long)(int)(val_10) * 40) + this.midMeshes + 48];
            val_33 = ((long)(int)(val_10) * 40) + this.midMeshes + 48;
            val_33.SetIndices(indices:  val_38.Item1, topology:  0, submesh:  0);
            label_21:
            val_32 = 1;
            goto label_86;
            label_76:
            if(this.terrainData == null)
            {
                goto label_87;
            }
            
            goto label_88;
            label_86:
            if(val_32 < this.丗丈丗七且世丙七丆.Length)
            {
                goto label_90;
            }
            
            return;
            label_87:
        }
        private System.Tuple<int[], UnityEngine.Vector3[], UnityEngine.Vector2[]> 丕丆丗丏丒东丝丄丒(int 万丘丞丈丛丟丐丛丐, int 丒丌丝与与丟丘丄业, int 丁与丞丞万丄丐丝一, TerrainData 丛七丄世上丘丅七丝, int 不一丅丟丐一丐东丘, float 丘丕丝上下丄丈丏丒)
        {
            float val_30;
            int val_31;
            TerrainData val_32;
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
            float val_44;
            float val_45;
            var val_46;
            var val_47;
            UnityEngine.Vector2[] val_48;
            var val_49;
            val_30 = 丘丕丝上下丄丈丏丒;
            val_31 = 不一丅丟丐一丐东丘;
            val_32 = 丁与丞丞万丄丐丝一;
            val_33 = 丒丌丝与与丟丘丄业;
            if(val_32 == 4)
            {
                goto label_1;
            }
            
            if(val_32 == 2)
            {
                goto label_2;
            }
            
            if(val_32 != 1)
            {
                goto label_3;
            }
            
            if(丛七丄世上丘丅七丝 == 0)
            {
                goto label_4;
            }
            
            val_34 = mem[丛七丄世上丘丅七丝 + 60];
            val_34 = 丛七丄世上丘丅七丝 + 60;
            val_35 = val_34;
            goto label_12;
            label_1:
            if(丛七丄世上丘丅七丝 == 0)
            {
                goto label_6;
            }
            
            val_36 = mem[丛七丄世上丘丅七丝 + 60];
            val_36 = 丛七丄世上丘丅七丝 + 60;
            val_37 = val_36;
            goto label_7;
            label_2:
            if(丛七丄世上丘丅七丝 == 0)
            {
                goto label_8;
            }
            
            val_38 = mem[丛七丄世上丘丅七丝 + 60];
            val_38 = 丛七丄世上丘丅七丝 + 60;
            val_39 = val_38;
            goto label_9;
            label_3:
            val_40 = 0;
            return (System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>)val_40;
            label_4:
            val_35 = 1769500;
            val_34 = 1769500;
            goto label_12;
            label_6:
            val_37 = 1769500;
            val_36 = 1769500;
            label_7:
            val_36 = (val_36 < 0) ? (val_36 + 3) : (val_36);
            val_35 = ((val_37 < 0) ? 1769503 : (val_37)) >> 2;
            val_34 = val_36 >> 2;
            goto label_12;
            label_8:
            val_39 = 1769500;
            val_38 = 1769500;
            label_9:
            var val_3 = (val_39 < 0) ? (val_39 + 1) : (val_39);
            val_35 = val_3 >> 1;
            val_34 = ((val_38 < 0) ? (val_38 + 1) : (val_38)) >> 1;
            label_12:
            val_3 = val_35 + 1;
            val_34 = 6 + (val_34 * 6);
            var val_5 = val_34 * val_3;
            int[] val_6 = new int[0];
            if(丛七丄世上丘丅七丝 != 0)
            {
                    val_41 = 丛七丄世上丘丅七丝;
                val_42 = mem[丛七丄世上丘丅七丝 + 60];
                val_42 = 丛七丄世上丘丅七丝 + 60;
                val_43 = val_42;
            }
            else
            {
                    val_41 = 60;
                val_43 = 1769500;
                val_42 = 1769500;
            }
            
            float val_33 = (float)val_31;
            val_33 = val_33 / 1769500f;
            val_44 = (float)val_32;
            val_33 = val_33 * val_44;
            int val_7 = UnityEngine.Mathf.RoundToInt(f:  val_33);
            if(丛七丄世上丘丅七丝 != 0)
            {
                    val_45 = mem[丛七丄世上丘丅七丝 + 72];
                val_45 = 丛七丄世上丘丅七丝 + 72;
                val_46 = 丛七丄世上丘丅七丝 + 72 + -20;
            }
            else
            {
                    val_45 = 0f;
                val_46 = 3670080;
            }
            
            int val_8 = val_43 / val_32;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_47 = val_8 + 1;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
            val_32 = 丛七丄世上丘丅七丝;
            UnityEngine.Vector3[] val_11 = new UnityEngine.Vector3[102630217];
            UnityEngine.Vector2[] val_12 = new UnityEngine.Vector2[102630217];
            val_48 = val_12;
            if(val_47 < 1)
            {
                goto label_24;
            }
            
            int val_35 = 万丘丞丈丛丟丐丛丐;
            float val_34 = 3670080f;
            val_34 = val_45 / val_34;
            val_35 = val_31 * val_35;
            val_34 = val_34 / 1769500f;
            val_33 = 0;
            val_30 = (float)val_33 * val_30;
            val_44 = val_34 * val_44;
            label_47:
            int val_36 = val_7;
            float val_15 = val_44 * 0f;
            val_36 = val_35 + (0 * val_36);
            var val_16 = 0 + 1;
            label_45:
            int val_19 = val_36 + ((丛七丄世上丘丅七丝 + 48) * ((val_31 * val_33) + (val_7 * 0)));
            if(((val_19 & 2147483648) != 0) || (val_19 >= (丛七丄世上丘丅七丝 + 160 + 24)))
            {
                goto label_28;
            }
            
            val_47 = val_47 * 0;
            var val_20 = (丛七丄世上丘丅七丝 + 160) + (long)val_19;
            int val_21 = val_47 + 0;
            float val_37 = 0f;
            float val_38 = mem[1152921557831510104];
            val_37 = val_44 * val_37;
            val_38 = val_38 * ((float)(丛七丄世上丘丅七丝 + 160 + (long)(int)((丛七丄世上丘丅七丝 + 48 * (val_7 * 0) + (不一丅丟丐一丐东丘 * 丒丌丝与与丟丘丄业)) + (0 * val_7) + (不一丅丟丐一丐东丘 * 万丘丞丈丛丟丐丛丐))) + 32);
            val_31 = (long)val_21;
            var val_39 = 12;
            val_39 = val_11 + (val_31 * val_39);
            mem2[0] = val_15;
            mem2[0] = val_38;
            mem2[0] = val_37;
            val_48 = val_48;
            float val_40 = 0f;
            val_40 = (val_30 + val_37) / val_40;
            UnityEngine.Vector2[] val_24 = val_48 + (((long)(int)(((((val_43 / 丁与丞丞万丄丐丝一) + 1) * 0) + 0))) << 3);
            mem2[0] = (((float)val_35 * val_30) + val_15) / val_40;
            mem2[0] = val_40;
            if((0 < val_8) && (0 < (long)val_8))
            {
                    val_6[0] = val_21;
                val_49 = 0 + 1;
                var val_25 = val_33 + 1;
                int val_26 = val_47 * val_49;
                val_6[((long)(int)((val_33 + 1))) << 2] = val_26 + 0;
                var val_28 = val_33 + 2;
                val_26 = val_26 + val_16;
                val_6[((long)(int)((val_33 + 2))) << 2] = val_26;
                val_32 = 丛七丄世上丘丅七丝;
                var val_29 = val_33 + 3;
                val_6[((long)(int)((val_33 + 3))) << 2] = val_21;
                var val_30 = val_33 + 4;
                val_6[((long)(int)((val_33 + 4))) << 2] = val_26;
                var val_31 = val_33 + 5;
                val_31 = val_47 + val_16;
                val_6[((long)(int)((val_33 + 5))) << 2] = val_31;
                val_48 = val_48;
                val_33 = val_33 + 6;
            }
            else
            {
                    val_49 = 0 + 1;
            }
            
            val_47 = val_47;
            if(val_49 < (long)val_47)
            {
                goto label_45;
            }
            
            goto label_46;
            label_28:
            val_48 = val_48;
            label_46:
            if(val_16 != val_47)
            {
                goto label_47;
            }
            
            label_24:
            System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_32 = null;
            val_40 = val_32;
            val_32 = new System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>(item1:  val_6, item2:  val_11, item3:  val_12);
            return (System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>)val_40;
        }
        private void OnDestroy()
        {
            this.丈下业专七丞专丟丂.丙世丑东丕丙丙丛丝();
            this.丈下业专七丞专丟丂 = 0;
        }
        public InGameTerrain()
        {
            this.hiMeshes = new MeshInstance[9];
            this.midMeshes = new MeshInstance[16];
            this.三丗丄下七东下丂丗 = 0;
            this.丕丄不与丒上丟下三 = new UnityEngine.WaitForEndOfFrame();
        }
    
    }

}
