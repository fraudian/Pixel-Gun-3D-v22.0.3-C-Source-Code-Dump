using UnityEngine;

namespace HexTiles
{
    public class HexTileMap : MonoBehaviour
    {
        // Fields
        public float tileDiameter;
        private bool drawHexPositionGizmos;
        private int chunkSize;
        private UnityEngine.GameObject _tilePrefab;
        private bool drawWireframeWhenSelected;
        private HexTiles.HexTileMap.丞丛不丄三丕丌丆丑 <丂不丑世世丙业丄丙>k__BackingField;
        private System.Collections.Generic.IList<HexTiles.HexChunk> 不丕三世丏七丑世丌;
        private UnityEngine.Material currentMaterial;
        private HexTiles.HexCoords 与七丅丛丂丅下与三;
        private System.Collections.Generic.IEnumerable<HexTiles.HexPosition> <下世丞不三下且丘丈>k__BackingField;
        private System.Collections.Generic.IEnumerable<HexTiles.HexPosition> <丗丐丂丞七丘专七三>k__BackingField;
        
        // Properties
        public int 丕万万丅丏丄一丅万 { get; set; }
        public UnityEngine.GameObject 丄不丏丙与丄一七丂 { get; set; }
        public bool 万丑丌丅上丗丙丕与 { get; set; }
        public bool 丗丈业丛东上上丐丙 { get; set; }
        public HexTiles.HexTileMap.丞丛不丄三丕丌丆丑 与东下丝丞专丏丐丄 { get; set; }
        private System.Collections.Generic.IEnumerable<HexTiles.HexTileData> 丌下东三丒丗丝丗不 { get; }
        private System.Collections.Generic.IList<HexTiles.HexChunk> 丒丕丐丛七丛丘东世 { get; }
        public UnityEngine.Material 丟丆丁下万丑东丟上 { get; set; }
        public HexTiles.HexCoords 东丕与上丌上丑丐丄 { get; set; }
        public System.Collections.Generic.IEnumerable<HexTiles.HexPosition> 不丘丗丑丞丒丏丗丒 { get; set; }
        public System.Collections.Generic.IEnumerable<HexTiles.HexPosition> 与丕一东与丕丆丗丙 { get; set; }
        
        // Methods
        public int get_ChunkSize()
        {
            return 1;
        }
        public void set_ChunkSize(int 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 > 0)
            {
                    this.chunkSize = 丙业与丙丗丝不丈东;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  "value", message:  "ChunkSize must be at least 1");
        }
        public UnityEngine.GameObject get_TilePrefab()
        {
            return (UnityEngine.GameObject)this._tilePrefab;
        }
        public void set_TilePrefab(UnityEngine.GameObject 丙业与丙丗丝不丈东)
        {
            this._tilePrefab = 丙业与丙丗丝不丈东;
        }
        public bool get_DrawHexPositionHandles()
        {
            return (bool)this.drawHexPositionGizmos;
        }
        public void set_DrawHexPositionHandles(bool 丙业与丙丗丝不丈东)
        {
            this.drawHexPositionGizmos = 丙业与丙丗丝不丈东;
        }
        public bool get_DrawWireframeWhenSelected()
        {
            return (bool)this.drawWireframeWhenSelected;
        }
        public void set_DrawWireframeWhenSelected(bool 丙业与丙丗丝不丈东)
        {
            this.drawWireframeWhenSelected = 丙业与丙丗丝不丈东;
        }
        public HexTiles.HexTileMap.丞丛不丄三丕丌丆丑 get_HexPositionHandleFormat()
        {
            return (丞丛不丄三丕丌丆丑)this.<丂不丑世世丙业丄丙>k__BackingField;
        }
        public void set_HexPositionHandleFormat(HexTiles.HexTileMap.丞丛不丄三丕丌丆丑 丙业与丙丗丝不丈东)
        {
            this.<丂不丑世世丙业丄丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private System.Collections.Generic.IEnumerable<HexTiles.HexTileData> 业丝东丑丅丞东丄丞()
        {
            var val_3;
            System.Func<HexTiles.HexChunk, System.Collections.Generic.IEnumerable<HexTiles.HexTileData>> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = HexTileMap.<>c.<>9__23_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.SelectMany<HexTiles.HexChunk, HexTiles.HexTileData>(source:  this.丘丘丝丛丟不丒丏丟(), selector:  System.Func<HexTiles.HexChunk, System.Collections.Generic.IEnumerable<HexTiles.HexTileData>> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<HexTiles.HexChunk, System.Collections.Generic.IEnumerable<HexTiles.HexTileData>>(object:  HexTileMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<HexTiles.HexTileData> HexTileMap.<>c::下下七一万丈丞业业(HexTiles.HexChunk 世世不东丗不业丆业));
            HexTileMap.<>c.<>9__23_0 = val_5;
            return System.Linq.Enumerable.SelectMany<HexTiles.HexChunk, HexTiles.HexTileData>(source:  this.丘丘丝丛丟不丒丏丟(), selector:  val_2);
        }
        private System.Collections.Generic.IList<HexTiles.HexChunk> 丘丘丝丛丟不丒丏丟()
        {
            System.Collections.Generic.IList<HexTiles.HexChunk> val_4;
            var val_5;
            var val_6;
            val_4 = this.不丕三世丏七丑世丌;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            this.不丕三世丏七丑世丌 = new System.Collections.Generic.List<HexTiles.HexChunk>();
            val_5 = 0;
            goto label_2;
            label_10:
            if(val_5 >= 1152921541663485744)
            {
                    val_6 = 0;
            }
            
            T val_4 = this.GetComponentsInChildren<HexTiles.HexChunk>()[0];
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = 2;
            this.不丕三世丏七丑世丌.Add(item:  ???);
            val_5 = 1;
            label_2:
            if(val_5 < val_2.Length)
            {
                goto label_10;
            }
            
            val_4 = this.不丕三世丏七丑世丌;
            return val_4;
        }
        public UnityEngine.Material get_CurrentMaterial()
        {
            return (UnityEngine.Material)this.currentMaterial;
        }
        public void set_CurrentMaterial(UnityEngine.Material 丙业与丙丗丝不丈东)
        {
            this.currentMaterial = 丙业与丙丗丝不丈东;
        }
        public HexTiles.HexCoords get_SelectedTile()
        {
            return (HexTiles.HexCoords)this.与七丅丛丂丅下与三;
        }
        public void set_SelectedTile(HexTiles.HexCoords 丙业与丙丗丝不丈东)
        {
            this.与七丅丛丂丅下与三 = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.IEnumerable<HexTiles.HexPosition> get_HighlightedTiles()
        {
            return (System.Collections.Generic.IEnumerable<HexTiles.HexPosition>)this.<下世丞不三下且丘丈>k__BackingField;
        }
        public void set_HighlightedTiles(System.Collections.Generic.IEnumerable<HexTiles.HexPosition> 丙业与丙丗丝不丈东)
        {
            this.<下世丞不三下且丘丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.IEnumerable<HexTiles.HexPosition> get_NextTilePositions()
        {
            return (System.Collections.Generic.IEnumerable<HexTiles.HexPosition>)this.<丗丐丂丞七丘专七三>k__BackingField;
        }
        public void set_NextTilePositions(System.Collections.Generic.IEnumerable<HexTiles.HexPosition> 丙业与丙丗丝不丈东)
        {
            this.<丗丐丂丞七丘专七三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void OnDrawGizmosSelected()
        {
            System.Collections.Generic.IEnumerable<HexTiles.HexPosition> val_16;
            var val_20;
            System.Collections.Generic.IEnumerable<HexTiles.HexPosition> val_22;
            val_16 = this.<下世丞不三下且丘丈>k__BackingField;
            if(val_16 == null)
            {
                goto label_1;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = val_16.GetEnumerator();
            label_17:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            UnityEngine.Vector3 val_7 = this.HexPositionToWorldPosition(业丒丝丗与丐丛丟丏:  val_2.Current);
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            this.且下世与且丙丕丌丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            goto label_17;
            label_11:
            val_20 = 0;
            val_16 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_2.Dispose();
            }
            
            if(( == 1) || (67 != 67))
            {
                goto label_31;
            }
            
            label_1:
            val_20 = 0;
            goto label_33;
            label_31:
            if( != false)
            {
                    val_16 = 0;
            }
            
            label_33:
            val_22 = this.<丗丐丂丞七丘专七三>k__BackingField;
            if(val_22 == null)
            {
                goto label_69;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_22 = val_22.GetEnumerator();
            label_50:
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(val_22.MoveNext() == false)
            {
                goto label_44;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            UnityEngine.Vector3 val_16 = this.HexPositionToWorldPosition(业丒丝丗与丐丛丟丏:  val_22.Current);
            UnityEngine.Color val_17 = UnityEngine.Color.cyan;
            this.且下世与且丙丕丌丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
            goto label_50;
            label_44:
            val_20 = 0 + 1;
            mem2[0] = 134;
            if(val_22 == null)
            {
                
            }
            else
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_22.Dispose();
            }
            
            if(val_20 == 1)
            {
                goto label_63;
            }
            
            if(( == false) || ((1152921541664691136 + ((0 + 1)) << 2) == 134))
            {
                goto label_69;
            }
            
            label_68:
            label_69:
            if(this.与七丅丛丂丅下与三 == null)
            {
                    return;
            }
            
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  this.与七丅丛丂丅下与三)) == null)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_20 = this.HexPositionToWorldPosition(业丒丝丗与丐丛丟丏:  val_19.<Position>k__BackingField);
            UnityEngine.Color val_21 = UnityEngine.Color.green;
            this.且下世与且丙丕丌丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a});
            return;
            label_63:
            if( == true)
            {
                goto label_68;
            }
            
            goto label_69;
        }
        private HexTiles.HexTileData 丅丘丝丙丆丙丂丕丙(HexTiles.HexCoords 一丛下丁不丘世下上)
        {
            .一丛下丁不丘世下上 = 一丛下丁不丘世下上;
            return System.Linq.Enumerable.FirstOrDefault<HexTiles.HexTileData>(source:  System.Linq.Enumerable.Where<HexTiles.HexTileData>(source:  this.业丝东丑丅丞东丄丞(), predicate:  new System.Func<HexTiles.HexTileData, System.Boolean>(object:  new HexTileMap.丅三丈世丝丑专丂世(), method:  System.Boolean HexTileMap.丅三丈世丝丑专丂世::丘一且丆一丕丛上东(HexTiles.HexTileData 丙丒七丄上与丏丙丙))));
        }
        private void 且下世与且丙丕丌丘(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            float val_9;
            float val_10;
            var val_11;
            val_9 = 丑丞丈丗丄丙丟万丄.g;
            HexTileMap.丈丞丕丘丄丐且丈丂 val_1 = new HexTileMap.丈丞丕丘丄丐且丈丂();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .业丒丝丗与丐丛丟丏 = 业丒丝丗与丐丛丟丏;
            mem[1152921541665127340] = 业丒丝丗与丐丛丟丏.y;
            mem[1152921541665127344] = 业丒丝丗与丐丛丟丏.z;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = val_9, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
            val_10 = this.tileDiameter;
            TSource[] val_5 = System.Linq.Enumerable.ToArray<UnityEngine.Vector4>(source:  System.Linq.Enumerable.Select<UnityEngine.Vector3, UnityEngine.Vector4>(source:  HexTiles.下丈上丆七丅丑与丗.丟下丘丆不丏丁丒万(丟丒且一专丟丙下一:  val_10), selector:  new System.Func<UnityEngine.Vector3, UnityEngine.Vector4>(object:  val_1, method:  UnityEngine.Vector4 HexTileMap.丈丞丕丘丄丐且丈丂::世世万世丘世丘丑一(UnityEngine.Vector3 业下丌下三丕丙丌下))));
            val_11 = 1;
            goto label_5;
            label_11:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_5[((long)(int)(W22)) << 4], y = val_5[((long)(int)(W22)) << 4], z = val_5[((long)(int)(W22)) << 4], w = val_5[((long)(int)(W22)) << 4]});
            val_10 = val_6.x;
            val_9 = val_6.z;
            int val_7 = val_11 / val_5.Length;
            val_7 = val_11 - (val_7 * val_5.Length);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_5[((long)(int)(val_11 - ((val_11 / val_5.Length) * val_5.Length))) << 4], y = val_5[((long)(int)(val_11 - ((val_11 / val_5.Length) * val_5.Length))) << 4], z = val_5[((long)(int)(val_11 - ((val_11 / val_5.Length) * val_5.Length))) << 4], w = val_5[((long)(int)(val_11 - ((val_11 / val_5.Length) * val_5.Length))) << 4]});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10, y = val_6.y, z = val_9}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_11 = 2;
            label_5:
            if(1 < val_5.Length)
            {
                goto label_11;
            }
        
        }
        public HexTiles.HexCoords QuantizeVector3ToHexCoords(UnityEngine.Vector3 丗丈丞丌丙丈丝丟丏)
        {
            float val_10;
            UnityEngine.Vector3 val_2 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丗丈丞丌丙丈丝丟丏.x, y = 丗丈丞丌丙丈丝丟丏.y, z = 丗丈丞丌丙丈丝丟丏.z});
            float val_12 = val_2.z;
            val_10 = this.tileDiameter;
            val_10 = this.tileDiameter;
            val_10 = this.tileDiameter;
            float val_10 = 3f;
            float val_11 = 0.5f;
            val_10 = (val_2.x + val_2.x) / val_10;
            float val_5 = val_12 * 0.5773503f;
            val_10 = val_10 * val_11;
            val_11 = this.tileDiameter * val_11;
            val_5 = val_5 - (val_2.x / val_10);
            val_12 = val_5 / val_10;
            .Q = UnityEngine.Mathf.RoundToInt(f:  val_10 / val_11);
            .R = UnityEngine.Mathf.RoundToInt(f:  val_12);
            return (HexTiles.HexCoords)new HexTiles.HexCoords();
        }
        public UnityEngine.Vector3 HexPositionToWorldPosition(HexTiles.HexPosition 业丒丝丗与丐丛丟丏)
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = 业丒丝丗与丐丛丟丏.丌丛不丟丈丛丑丒丅(丒丆一丄丛丒且万七:  this.tileDiameter);
            if(val_1 != null)
            {
                    return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            }
            
            return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public UnityEngine.Vector3 QuantizePositionToHexGrid(UnityEngine.Vector3 丗丈丞丌丙丈丝丟丏)
        {
            .Coordinates = this.QuantizeVector3ToHexCoords(丗丈丞丌丙丈丝丟丏:  new UnityEngine.Vector3() {x = 丗丈丞丌丙丈丝丟丏.x, y = 丗丈丞丌丙丈丝丟丏.y, z = 丗丈丞丌丙丈丝丟丏.z});
            .Elevation = 丗丈丞丌丙丈丝丟丏.y;
            return this.HexPositionToWorldPosition(业丒丝丗与丐丛丟丏:  new HexTiles.HexPosition());
        }
        public System.Collections.Generic.IEnumerable<HexTiles.丈丕丙丆业丘与丏丁> RegenerateAllTiles()
        {
            var val_20;
            var val_21;
            var val_24;
            System.Collections.Generic.List<HexTiles.HexTileData> val_1 = new System.Collections.Generic.List<HexTiles.HexTileData>();
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = this.业丝东丑丅丞东丄丞().GetEnumerator();
            label_18:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_1.Add(item:  val_4.Current);
            goto label_18;
            label_11:
            val_20 = 0;
            val_21 = 0;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_4.Dispose();
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            this.丘丘丝丛丟不丒丏丟().Clear();
            val_24 = 0;
            goto label_36;
            label_46:
            val_20 = UnityEngine.Application.isEditor;
            UnityEngine.GameObject val_14 = this.GetComponentsInChildren<HexTiles.HexChunk>()[0].gameObject;
            if(val_20 != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  val_14);
            }
            else
            {
                    UnityEngine.Object.Destroy(obj:  val_14);
            }
            
            val_24 = 1;
            label_36:
            if(val_24 < val_12.Length)
            {
                goto label_46;
            }
            
            bool val_19 = this.UpdateTileChunks();
            return (System.Collections.Generic.IEnumerable<HexTiles.丈丕丙丆业丘与丏丁>)System.Linq.Enumerable.ToArray<HexTiles.丈丕丙丆业丘与丏丁>(source:  System.Linq.Enumerable.Distinct<HexTiles.丈丕丙丆业丘与丏丁>(source:  System.Linq.Enumerable.Select<HexTiles.HexTileData, HexTiles.丈丕丙丆业丘与丏丁>(source:  val_1, selector:  new System.Func<HexTiles.HexTileData, HexTiles.丈丕丙丆业丘与丏丁>(object:  this, method:  HexTiles.丈丕丙丆业丘与丏丁 HexTiles.HexTileMap::丑丅丐丆七一丟丅丛(HexTiles.HexTileData 丝丝丕丐丘业三丅丕)))));
        }
        public bool UpdateTileChunks()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = 0;
            val_8 = 0;
            goto label_1;
            label_28:
            if(val_7 >= 1152921541665990896)
            {
                    val_9 = 0;
            }
            
            TSource val_9 = System.Linq.Enumerable.ToArray<HexTiles.HexChunk>(source:  this.丘丘丝丛丟不丒丏丟())[0];
            var val_12 = val_2[0x0][0] + 72;
            if((val_2[0x0][0] + 72 + 286) == 0)
            {
                goto label_5;
            }
            
            var val_10 = val_2[0x0][0] + 72 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_7:
            if(((val_2[0x0][0] + 72 + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (val_2[0x0][0] + 72 + 286))
            {
                goto label_7;
            }
            
            label_5:
            val_9 = 0;
            goto label_8;
            label_6:
            val_12 = val_12 + (((val_2[0x0][0] + 72 + 176 + 8)) << 4);
            val_10 = val_12 + 296;
            label_8:
            if((val_2[0x0][0] + 72.Count) <= 0)
            {
                goto label_9;
            }
            
            val_11 = mem[val_2[0x0] + 32];
            val_11 = val_2[0x0] + 32;
            if((val_2[0x0] + 32 + 80) == 0)
            {
                goto label_13;
            }
            
            val_11 = mem[val_2[0x0] + 32];
            val_11 = val_2[0x0] + 32;
            val_11.GenerateMesh(丄丌丙七一丏下万丙:  this._tilePrefab);
            goto label_16;
            label_9:
            if(val_7 >= val_2.Length)
            {
                    val_9 = 0;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_9 = 6;
            bool val_6 = this.丘丘丝丛丟不丒丏丟().Remove(item:  ???);
            val_11 = mem[val_2[0x0] + 32];
            val_11 = val_2[0x0] + 32;
            HexTiles.一丈业丝丗且丟丂一.Destroy(丗业丈丈三丙与七丂:  val_11.gameObject);
            label_16:
            val_8 = 1;
            label_13:
            val_7 = 1;
            label_1:
            if(val_7 < val_2.Length)
            {
                goto label_28;
            }
            
            return (bool)val_8 & 1;
        }
        public HexTiles.丈丕丙丆业丘与丏丁 CreateAndAddTile(HexTiles.HexPosition 业丒丝丗与丐丛丟丏, UnityEngine.Material 丘上专不丂万业不一)
        {
            HexTiles.HexPosition val_10;
            HexTiles.HexCoords val_11;
            HexTiles.HexCoords val_12;
            UnityEngine.Object val_13;
            丞丄丕丘丈丘丈专丌 val_14;
            UnityEngine.Material val_15;
            var val_16;
            val_10 = 业丒丝丗与丐丛丟丏;
            if(val_10 != null)
            {
                    val_11 = val_10;
                val_12 = 业丒丝丗与丐丛丟丏.Coordinates;
            }
            else
            {
                    val_11 = 16;
                val_12 = 11993091;
            }
            
            val_13 = this.FindChunkForCoordinatesAndMaterial(业丄世世一世三与丝:  val_12, 丘上专不丂万业不一:  丘上专不丂万业不一);
            if(val_13 == 0)
            {
                    val_13 = this.丗且丝与丅丁丙万丛(业丄世世一世三与丝:  val_11, 丘上专不丂万业不一:  丘上专不丂万业不一);
                val_14 = 0;
            }
            else
            {
                    val_14 = 1;
            }
            
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  val_12)) != null)
            {
                    if((val_4.<Position>k__BackingField.Elevation) == 业丒丝丗与丐丛丟丏.Elevation)
            {
                    val_15 = val_4.<Material>k__BackingField;
                if(val_15 == 丘上专不丂万业不一)
            {
                    return new HexTiles.丈丕丙丆业丘与丏丁() {<丞丘丝万且丑一一丒>k__BackingField = val_13, <与丕丄丕丏三上上丅>k__BackingField = val_14};
            }
            
            }
            
                bool val_6 = this.TryRemovingTile(业丒丝丗与丐丛丟丏:  val_12);
            }
            
            val_13.丄丞丗丁丏丐丟专丐(业丒丝丗与丐丛丟丏:  val_10);
            val_10 = 1152921505380593664;
            val_16 = null;
            val_16 = null;
            val_15 = 0;
            goto label_16;
            label_20:
            val_10 = HexTiles.HexCoords.七万丘且丅世丝丈东(丆丛丑世下一丐且丕:  val_12, 丌丗丏丏丛东专丁且:  HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗.__il2cppRuntimeField_20);
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  val_10)) != null)
            {
                    this.丅一丞不与丝东丅丌(业丒丝丗与丐丛丟丏:  val_10, 世丕丗不一不丂下丂:  this.FindChunkForCoordinatesAndMaterial(业丄世世一世三与丝:  val_10, 丘上专不丂万业不一:  val_8.<Material>k__BackingField));
            }
            
            val_15 = 1;
            label_16:
            if(val_15 < HexTiles.下丈上丆七丅丑与丗.东丈丁丒丛业与丅七.Length)
            {
                goto label_20;
            }
            
            this.丅一丞不与丝东丅丌(业丒丝丗与丐丛丟丏:  val_12, 世丕丗不一不丂下丂:  val_13);
            return new HexTiles.丈丕丙丆业丘与丏丁() {<丞丘丝万且丑一一丒>k__BackingField = val_13, <与丕丄丕丏三上上丅>k__BackingField = val_14};
        }
        private HexTiles.HexChunk 丗且丝与丅丁丙万丛(HexTiles.HexCoords 业丄世世一世三与丝, UnityEngine.Material 丘上专不丂万业不一)
        {
            int val_6;
            int val_7;
            if(业丄世世一世三与丝 != null)
            {
                    val_6 = HexTiles.HexTileMap.一丐丘丞世丝丟丞与(丗丄下丈丑七丗丞专:  业丄世世一世三与丝.Q, 七丌丄丑专且丐丙丂:  1);
            }
            else
            {
                    val_6 = HexTiles.HexTileMap.一丐丘丞世丝丟丞与(丗丄下丈丑七丗丞专:  11993091, 七丌丄丑专且丐丙丂:  1);
            }
            
            val_7 = HexTiles.HexTileMap.一丐丘丞世丝丟丞与(丗丄下丈丑七丗丞专:  业丄世世一世三与丝.R, 七丌丄丑专且丐丙丂:  1);
            HexTiles.HexCoords val_4 = new HexTiles.HexCoords();
            .Q = val_6;
            .R = val_7;
            if(val_4 == null)
            {
                    val_6 = (HexTiles.HexCoords)[1152921541666497264].Q;
                val_7 = (HexTiles.HexCoords)[1152921541666497264].R;
            }
            
            HexTiles.HexCoords val_5 = null;
            val_6 = val_6 + 1;
            val_7 = val_7 + 1;
            val_5 = new HexTiles.HexCoords();
            .Q = val_6;
            .R = val_7;
            return this.丈上上三丘丘丝七丙(上东丘丑不上丅且丘:  val_4, 丛丕丛丅丐七丆丂丘:  val_5, 丘上专不丂万业不一:  丘上专不丂万业不一);
        }
        public HexTiles.HexChunk FindChunkForCoordinates(HexTiles.HexCoords 业丄世世一世三与丝)
        {
            .业丄世世一世三与丝 = 业丄世世一世三与丝;
            return System.Linq.Enumerable.FirstOrDefault<HexTiles.HexChunk>(source:  System.Linq.Enumerable.Where<HexTiles.HexChunk>(source:  this.丘丘丝丛丟不丒丏丟(), predicate:  new System.Func<HexTiles.HexChunk, System.Boolean>(object:  new HexTileMap.丞丘世丐丏丟业丕丒(), method:  System.Boolean HexTileMap.丞丘世丐丏丟业丕丒::丌丈丆丈不七七丐丄(HexTiles.HexChunk 丁丂专业丁丅丅丈丙))));
        }
        public HexTiles.HexChunk FindChunkForCoordinatesAndMaterial(HexTiles.HexCoords 业丄世世一世三与丝, UnityEngine.Material 丘上专不丂万业不一)
        {
            object val_9;
            HexTileMap.丛丄丁业且世丝丂丅 val_1 = new HexTileMap.丛丄丁业且世丝丂丅();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .业丄世世一世三与丝 = 业丄世世一世三与丝;
            }
            else
            {
                    val_9 = 16;
                mem[16] = 业丄世世一世三与丝;
            }
            
            .丘上专不丂万业不一 = 丘上专不丂万业不一;
            System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Where<HexTiles.HexChunk>(source:  System.Linq.Enumerable.Where<HexTiles.HexChunk>(source:  this.丘丘丝丛丟不丒丏丟(), predicate:  new System.Func<HexTiles.HexChunk, System.Boolean>(object:  val_1, method:  System.Boolean HexTileMap.丛丄丁业且世丝丂丅::丝东专丁上丑世世丄(HexTiles.HexChunk 丁丂专业丁丅丅丈丙))), predicate:  new System.Func<HexTiles.HexChunk, System.Boolean>(object:  val_1, method:  System.Boolean HexTileMap.丛丄丁业且世丝丂丅::丆专丕丌专丏丈丂丈(HexTiles.HexChunk 丁丂专业丁丅丅丈丙)));
            if((System.Linq.Enumerable.Count<HexTiles.HexChunk>(source:  val_6)) < 2)
            {
                    return System.Linq.Enumerable.FirstOrDefault<HexTiles.HexChunk>(source:  val_6);
            }
            
            UnityEngine.Debug.LogWarning(message:  "Overlapping chunks detected for coordinates " + val_9 + ". Taking first.");
            return System.Linq.Enumerable.FirstOrDefault<HexTiles.HexChunk>(source:  val_6);
        }
        private HexTiles.HexChunk 丈上上三丘丘丝七丙(HexTiles.HexCoords 上东丘丑不上丅且丘, HexTiles.HexCoords 丛丕丛丅丐七丆丂丘, UnityEngine.Material 丘上专不丂万业不一)
        {
            var val_8;
            float val_9;
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  System.String.Format(format:  "Chunk {0} - {1}", arg0:  上东丘丑不上丅且丘, arg1:  丛丕丛丅丐七丆丂丘));
            val_8 = 0;
            val_2.transform.parent = this.transform;
            HexTiles.HexChunk val_5 = val_2.AddComponent<HexTiles.HexChunk>();
            if(val_5 != null)
            {
                    val_5.upperBounds = 丛丕丛丅丐七丆丂丘;
                val_5.lowerBounds = 上东丘丑不上丅且丘;
                val_5.Material = 丘上专不丂万业不一;
                val_9 = this.tileDiameter;
            }
            else
            {
                    mem[32] = 上东丘丑不上丅且丘;
                mem[24] = 丛丕丛丅丐七丆丂丘;
                val_5.Material = 丘上专不丂万业不一;
                val_9 = this.tileDiameter;
            }
            
            val_5.tileDiameter = val_9;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = 2;
            this.丘丘丝丛丟不丒丏丟().Add(item:  ???);
            return val_5;
        }
        private static int 一丐丘丞世丝丟丞与(int 丗丄下丈丑七丗丞专, int 七丌丄丑专且丐丙丂)
        {
            float val_2 = (float)丗丄下丈丑七丗丞专;
            val_2 = val_2 / (float)七丌丄丑专且丐丙丂;
            return (int)(System.Math.__il2cppRuntimeField_cctor_finished * 七丌丄丑专且丐丙丂);
        }
        private void 丅一丞不与丝东丅丌(HexTiles.HexCoords 业丒丝丗与丐丛丟丏, HexTiles.HexChunk 世丕丗不一不丂下丂)
        {
            var val_8;
            var val_9;
            var val_10;
            HexTiles.HexCoords val_11;
            HexTiles.HexPosition val_12;
            float val_13;
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  业丒丝丗与丐丛丟丏)) == null)
            {
                goto label_1;
            }
            
            val_8 = 1152921505380593664;
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            goto label_4;
            label_18:
            val_11 = HexTiles.HexCoords.七万丘且丅世丝丈东(丆丛丑世下一丐且丕:  业丒丝丗与丐丛丟丏, 丌丗丏丏丛东专丁且:  HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗.__il2cppRuntimeField_20);
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  val_11)) != null)
            {
                    val_11 = this.FindChunkForCoordinatesAndMaterial(业丄世世一世三与丝:  val_11, 丘上专不丂万业不一:  val_3.<Material>k__BackingField);
                if(val_11 != 0)
            {
                    val_11.不丆丛丆丝丛丏上丑(丝丝丕丐丘业三丅丕:  业丒丝丗与丐丛丟丏, 下丛丂一一丛七丒不:  HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗.__il2cppRuntimeField_20);
                val_11 = val_3.<Position>k__BackingField;
                val_12 = val_1.<Position>k__BackingField;
                val_13 = val_3.<Position>k__BackingField.Elevation;
                if(val_13 < 0)
            {
                    val_11 = val_1.<Position>k__BackingField;
                val_13 = val_1.<Position>k__BackingField.Elevation;
                val_12 = 世丕丗不一不丂下丂;
                val_12.万不丑丆七且上下一(丝丝丕丐丘业三丅丕:  业丒丝丗与丐丛丟丏, 下丛丂一一丛七丒不:  HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗.__il2cppRuntimeField_20, 丟丌丐丘丆丙丑丑一:  val_13 - (val_3.<Position>k__BackingField.Elevation));
            }
            
            }
            
            }
            
            val_10 = 1;
            label_4:
            if(val_10 < HexTiles.下丈上丆七丅丑与丗.东丈丁丒丛业与丅七.Length)
            {
                goto label_18;
            }
            
            return;
            label_1:
            System.ApplicationException val_7 = new System.ApplicationException(message:  "Tried to set up side pieces for non-existent tile.");
        }
        public bool TryRemovingTile(HexTiles.HexCoords 业丒丝丗与丐丛丟丏)
        {
            HexTiles.HexCoords val_11;
            object val_12;
            HexTiles.HexCoords val_13;
            var val_14;
            val_11 = 业丒丝丗与丐丛丟丏;
            HexTileMap.丑丌与七下丈丅一丐 val_1 = null;
            val_12 = val_1;
            val_1 = new HexTileMap.丑丌与七下丈丅一丐();
            if(val_12 != null)
            {
                    val_13 = val_12;
                .业丒丝丗与丐丛丟丏 = val_11;
            }
            else
            {
                    val_13 = 16;
                mem[16] = val_11;
                val_11 = mem[16];
            }
            
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  val_11)) == null)
            {
                    return (bool)val_14;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<HexTiles.HexChunk>(source:  this.丘丘丝丛丟不丒丏丟(), predicate:  new System.Func<HexTiles.HexChunk, System.Boolean>(object:  val_1, method:  System.Boolean HexTileMap.丑丌与七下丈丅一丐::丆丈丙丆丂丛丌丁世(HexTiles.HexChunk 丁丂专业丁丅丅丈丙)));
            if(val_5 != null)
            {
                    if((System.Linq.Enumerable.Count<HexTiles.HexChunk>(source:  val_5)) >= 1)
            {
                goto label_8;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "Tile found in internal tile collection but not in scene. Removing", context:  this);
            label_8:
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_8 = val_5.GetEnumerator();
            label_26:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_8.Current.丛丑且丁丁丆一丏不(一丛下丁不丘世下上:  val_13);
            goto label_26;
            label_18:
            val_11 = 0;
            val_12 = 0;
            if(val_8 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_8.Dispose();
            }
            
            val_14 = 1;
            if( != 1)
            {
                    return (bool)val_14;
            }
            
            if( == false)
            {
                    return (bool)val_14;
            }
            
            val_14 = 1;
            return (bool)val_14;
        }
        private UnityEngine.GameObject 丝丐与丄上下丒丆东(HexTiles.HexPosition 业丒丝丗与丐丛丟丏)
        {
            object[] val_1 = new object[5];
            val_1[0] = "Tile [";
            val_1[1] = 业丒丝丗与丐丛丟丏.Coordinates.Q;
            val_1[2] = ", ";
            val_1[3] = 业丒丝丗与丐丛丟丏.Coordinates.R;
            val_1[4] = "]";
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  +val_1);
            val_3.transform.parent = this.transform;
            UnityEngine.Vector3 val_7 = this.HexPositionToWorldPosition(业丒丝丗与丐丛丟丏:  业丒丝丗与丐丛丟丏);
            val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            return val_3;
        }
        public void ClearAllTiles()
        {
            var val_16;
            var val_17;
            var val_21;
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.丘丘丝丛丟不丒丏丟().Clear();
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            System.Collections.IEnumerator val_5 = this.transform.GetEnumerator();
            label_22:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            object val_9 = val_5.Current;
            val_3.Add(item:  0.gameObject);
            goto label_22;
            label_12:
            val_16 = 0;
            val_17 = 0;
            if(val_5 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_5.Dispose();
            }
            
            val_21 = null;
            val_21 = null;
            if((HexTileMap.<>c.<>9__60_0) == null)
            {
                goto label_40;
            }
            
            label_45:
            val_3.ForEach(action:  HexTileMap.<>c.<>9__60_0);
            return;
            label_40:
            HexTileMap.<>c.<>9__60_0 = new System.Action<UnityEngine.GameObject>(object:  HexTileMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void HexTileMap.<>c::丂丝丈丞丟业专丂丟(UnityEngine.GameObject 不七丘丘丒万七丄丒));
            if(val_3 != null)
            {
                goto label_45;
            }
            
            goto label_45;
        }
        public bool ContainsTile(HexTiles.HexCoords 业丈业丄世丕丈专专)
        {
            return (bool)((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  业丈业丄世丕丈专专)) != 0) ? 1 : 0;
        }
        public bool TryGetTile(HexTiles.HexCoords 业丈业丄世丕丈专专, out HexTiles.HexTileData 一丐丗丁丞丆丅丟丄)
        {
            HexTiles.HexTileData val_1 = this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  业丈业丄世丕丈专专);
            一丐丗丁丞丆丅丟丄 = val_1;
            return (bool)(val_1 != 0) ? 1 : 0;
        }
        public HexTiles.丈丕丙丆业丘与丏丁 ReplaceMaterialOnTile(HexTiles.HexCoords 业丈业丄世丕丈专专, UnityEngine.Material 丘上专不丂万业不一)
        {
            var val_9;
            if((this.丅丘丝丙丆丙丂丕丙(一丛下丁不丘世下上:  业丈业丄世丕丈专专)) != null)
            {
                    if((val_1.<Material>k__BackingField) == 丘上专不丂万业不一)
            {
                    HexTiles.HexChunk val_3 = this.FindChunkForCoordinatesAndMaterial(业丄世世一世三与丝:  业丈业丄世丕丈专专, 丘上专不丂万业不一:  丘上专不丂万业不一);
                val_9 = 1;
                return new HexTiles.丈丕丙丆业丘与丏丁() {<丞丘丝万且丑一一丒>k__BackingField = val_5.<丞丘丝万且丑一一丒>k__BackingField, <与丕丄丕丏三上上丅>k__BackingField = val_5.<与丕丄丕丏三上上丅>k__BackingField};
            }
            
                bool val_4 = this.TryRemovingTile(业丒丝丗与丐丛丟丏:  业丈业丄世丕丈专专);
                HexTiles.丈丕丙丆业丘与丏丁 val_5 = this.CreateAndAddTile(业丒丝丗与丐丛丟丏:  val_1.<Position>k__BackingField, 丘上专不丂万业不一:  丘上专不丂万业不一);
                return new HexTiles.丈丕丙丆业丘与丏丁() {<丞丘丝万且丑一一丒>k__BackingField = val_5.<丞丘丝万且丑一一丒>k__BackingField, <与丕丄丕丏三上上丅>k__BackingField = val_5.<与丕丄丕丏三上上丅>k__BackingField};
            }
            
            System.ArgumentOutOfRangeException val_7 = new System.ArgumentOutOfRangeException(paramName:  "Tried replacing material on tile but map contains no tile at position " + 业丈业丄世丕丈专专);
        }
        public System.Collections.Generic.IEnumerable<HexTiles.HexTileData> GetAllTiles()
        {
            return this.业丝东丑丅丞东丄丞();
        }
        public void ClearChunkCache()
        {
            this.不丕三世丏七丑世丌 = 0;
        }
        public HexTileMap()
        {
            this.tileDiameter = 1f;
            this.chunkSize = 10;
            this.drawWireframeWhenSelected = true;
        }
        private HexTiles.丈丕丙丆业丘与丏丁 丑丅丐丆七一丟丅丛(HexTiles.HexTileData 丝丝丕丐丘业三丅丕)
        {
            HexTiles.HexPosition val_1;
            if(丝丝丕丐丘业三丅丕 != null)
            {
                    val_1 = 丝丝丕丐丘业三丅丕.<Position>k__BackingField;
                return this.CreateAndAddTile(业丒丝丗与丐丛丟丏:  val_1 = 11993091, 丘上专不丂万业不一:  丝丝丕丐丘业三丅丕.<Material>k__BackingField);
            }
            
            return this.CreateAndAddTile(业丒丝丗与丐丛丟丏:  val_1, 丘上专不丂万业不一:  丝丝丕丐丘业三丅丕.<Material>k__BackingField);
        }
    
    }

}
