using UnityEngine;

namespace HexTiles
{
    public class HexChunk : MonoBehaviour
    {
        // Fields
        public HexTiles.HexCoords upperBounds;
        public HexTiles.HexCoords lowerBounds;
        private float tileDiameter;
        private UnityEngine.MeshFilter 世丒丗丝丆丑不丐丒;
        private UnityEngine.MeshCollider 丅丁丄丅丅丌三丛丘;
        private System.Collections.Generic.List<HexTiles.HexChunk.SidePieceInfo> sidePieces;
        private System.Collections.Generic.List<HexTiles.HexPosition> tiles;
        private bool <丄丑丑丐丒且丘且专>k__BackingField;
        
        // Properties
        public float 与业不丝丁丛丆丄与 { get; set; }
        public UnityEngine.Material 丄业丁丁不丐不七丙 { get; set; }
        public UnityEngine.MeshFilter 东丆七东与上东丘不 { get; }
        public UnityEngine.MeshCollider 丟丕丅丕丟丁丘不丈 { get; }
        public System.Collections.Generic.IList<HexTiles.HexPosition> 丌下东三丒丗丝丗不 { get; }
        public bool 下丅丙丁丈不丟下丛 { get; set; }
        
        // Methods
        public float get_TileDiameter()
        {
            return (float)this.tileDiameter;
        }
        public void set_TileDiameter(float 丙业与丙丗丝不丈东)
        {
            this.tileDiameter = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Material get_Material()
        {
            UnityEngine.MeshRenderer val_1 = this.GetComponent<UnityEngine.MeshRenderer>();
            if(val_1 != null)
            {
                    return val_1.sharedMaterial;
            }
            
            return val_1.sharedMaterial;
        }
        public void set_Material(UnityEngine.Material 丙业与丙丗丝不丈东)
        {
            this.GetComponent<UnityEngine.MeshRenderer>().sharedMaterial = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.MeshFilter get_MeshFilter()
        {
            UnityEngine.MeshFilter val_3;
            if(this.世丒丗丝丆丑不丐丒 == 0)
            {
                    this.世丒丗丝丆丑不丐丒 = this.GetComponent<UnityEngine.MeshFilter>();
                return val_3;
            }
            
            val_3 = this.世丒丗丝丆丑不丐丒;
            return val_3;
        }
        public UnityEngine.MeshCollider get_MeshCollider()
        {
            UnityEngine.MeshCollider val_3;
            if(this.丅丁丄丅丅丌三丛丘 == 0)
            {
                    this.丅丁丄丅丅丌三丛丘 = this.GetComponent<UnityEngine.MeshCollider>();
                return val_3;
            }
            
            val_3 = this.丅丁丄丅丅丌三丛丘;
            return val_3;
        }
        public System.Collections.Generic.IList<HexTiles.HexPosition> get_Tiles()
        {
            return (System.Collections.Generic.IList<HexTiles.HexPosition>)this.tiles;
        }
        internal void 丄丞丗丁丏丐丟专丐(HexTiles.HexPosition 业丒丝丗与丐丛丟丏)
        {
            this.tiles.Add(item:  业丒丝丗与丐丛丟丏);
            this.<丄丑丑丐丒且丘且专>k__BackingField = true;
        }
        internal void 丛丑且丁丁丆一丏不(HexTiles.HexCoords 一丛下丁不丘世下上)
        {
            .一丛下丁不丘世下上 = 一丛下丁不丘世下上;
            int val_3 = this.tiles.RemoveAll(match:  new System.Predicate<HexTiles.HexPosition>(object:  new HexChunk.丒业丛丟专丛丒与东(), method:  System.Boolean HexChunk.丒业丛丟专丛丒与东::上丅丟且下丑丆丈丌(HexTiles.HexPosition 丝丝丕丐丘业三丅丕)));
            this.<丄丑丑丐丒且丘且专>k__BackingField = true;
        }
        public bool get_Dirty()
        {
            return (bool)this.<丄丑丑丐丒且丘且专>k__BackingField;
        }
        private void 丈东丂丝丏业丕丙丕(bool 丙业与丙丗丝不丈东)
        {
            this.<丄丑丑丐丒且丘且专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void GenerateMesh(UnityEngine.GameObject 丄丌丙七一丏下万丙)
        {
            System.Collections.Generic.IEnumerable<T> val_15;
            System.Collections.Generic.IEnumerable<TSource> val_16;
            System.Collections.Generic.IEnumerable<TSource> val_26;
            var val_48;
            float val_49;
            var val_51;
            var val_52;
            System.Func<SidePieceInfo, HexTiles.SidePiece> val_54;
            System.Collections.Generic.IEnumerable<TSource> val_55;
            System.Collections.Generic.List<T> val_56;
            System.Collections.Generic.List<T> val_57;
            System.Collections.Generic.List<T> val_58;
            System.Collections.Generic.List<HexTiles.HexPosition> val_59;
            val_48 = 1152921504848912384;
            if(丄丌丙七一丏下万丙 != 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            val_49 = val_7.x;
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_49, y = val_7.y, z = val_7.z, w = val_7.w};
            this.gameObject.isStatic = true;
            UnityEngine.Mesh val_10 = new UnityEngine.Mesh();
            this.MeshFilter.mesh = val_10;
            val_10.name = "Chunk";
            System.Collections.Generic.List<UnityEngine.Vector3> val_11 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.Generic.List<System.Int32> val_12 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<UnityEngine.Vector2> val_13 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            List.Enumerator<T> val_14 = this.tiles.GetEnumerator();
            val_51 = 1152921541655085120;
            goto label_15;
            label_30:
            new HexChunk.丄丆丌丌丕丈丆丆业() = new System.Object();
            .丝且与丝丒丟万丁专 = this;
            .丝丝丕丐丘业三丅丕 = val_16.丐丏七丌丕丗业且上();
            new HexChunk.一丛丕万丞丗丈上丒() = new System.Object();
            .且丄丅丝丌丏上专三 = val_11.Count;
            val_49 = this.tileDiameter;
            System.Func<SidePieceInfo, System.Boolean> val_21 = new System.Func<SidePieceInfo, System.Boolean>(object:  new HexChunk.丄丆丌丌丕丈丆丆业(), method:  System.Boolean HexChunk.丄丆丌丌丕丈丆丆业::丏一下且丌丙丄丒东(HexTiles.HexChunk.SidePieceInfo 丞世丈丂丙丕丄七不));
            val_52 = null;
            val_52 = null;
            val_54 = HexChunk.<>c.<>9__25_1;
            if(val_54 == null)
            {
                    val_54 = null;
                val_54 = new System.Func<SidePieceInfo, HexTiles.SidePiece>(object:  HexChunk.<>c.__il2cppRuntimeField_static_fields, method:  HexTiles.SidePiece HexChunk.<>c::丄丈丙下丏丆丅上东(HexTiles.HexChunk.SidePieceInfo 丞世丈丂丙丕丄七不));
                HexChunk.<>c.<>9__25_1 = val_54;
            }
            
            专业万不丟丝一丞七 val_25 = HexTiles.丅上专丝丙丗万上丙.万丁丂下下丈丙丘丑(业丒丝丗与丐丛丟丏:  (HexChunk.丄丆丌丌丕丈丆丆业)[1152921541655429824].丝丝丕丐丘业三丅丕.Coordinates, 丟丏东下丄丑丈万丟:  val_49, 丙世丁丈上丟丒丛丆:  System.Linq.Enumerable.Select<SidePieceInfo, HexTiles.SidePiece>(source:  System.Linq.Enumerable.Where<SidePieceInfo>(source:  this.sidePieces, predicate:  null), selector:  null));
            val_55 = val_26;
            System.Func<UnityEngine.Vector3, UnityEngine.Vector3> val_27 = new System.Func<UnityEngine.Vector3, UnityEngine.Vector3>(object:  new HexChunk.丄丆丌丌丕丈丆丆业(), method:  UnityEngine.Vector3 HexChunk.丄丆丌丌丕丈丆丆业::七丅世丏丙且丈上丁(UnityEngine.Vector3 丝丞世且下丁三世三));
            val_56 = val_12;
            val_11.AddRange(collection:  System.Linq.Enumerable.Select<UnityEngine.Vector3, UnityEngine.Vector3>(source:  val_16, selector:  null));
            System.Func<System.Int32, System.Int32> val_29 = new System.Func<System.Int32, System.Int32>(object:  new HexChunk.一丛丕万丞丗丈上丒(), method:  System.Int32 HexChunk.一丛丕万丞丗丈上丒::丅与丐丝丕丕专丈丑(int 丞世不丒下上上丝丑));
            val_12.AddRange(collection:  System.Linq.Enumerable.Select<System.Int32, System.Int32>(source:  val_55, selector:  null));
            val_13.AddRange(collection:  val_15);
            val_51 = val_12;
            label_15:
            if(((-1606212032) & 1) != 0)
            {
                goto label_30;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_58 = val_13;
            val_57 = val_12;
            if(val_11 != null)
            {
                goto label_92;
            }
            
            goto label_32;
            label_3:
            val_59 = this.tiles;
            List.Enumerator<T> val_31 = val_59.GetEnumerator();
            val_55 = 1152921541655090240;
            label_50:
            if(((-1606212032) & 1) == 0)
            {
                goto label_34;
            }
            
            UnityEngine.GameObject val_33 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丄丌丙七一丏下万丙);
            val_33.transform.SetParent(p:  this.transform);
            UnityEngine.Vector3 val_36 = val_16.丐丏七丌丕丗业且上().丌丛不丟丈丛丑丒丅(丒丆一丄丛丒且万七:  this.tileDiameter);
            val_33.transform.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
            UnityEngine.Quaternion val_40 = 丄丌丙七一丏下万丙.transform.localRotation;
            val_33.transform.localRotation = new UnityEngine.Quaternion() {x = val_40.x, y = val_40.y, z = val_40.z, w = val_40.w};
            UnityEngine.Vector3 val_43 = 丄丌丙七一丏下万丙.transform.localScale;
            val_33.transform.localScale = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
            goto label_50;
            label_34:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_89;
            label_32:
            label_92:
            丄丌丙七一丏下万丙.vertices = X23.ToArray();
            丄丌丙七一丏下万丙.triangles = val_12.ToArray();
            T[] val_46 = val_13.ToArray();
            if(丄丌丙七一丏下万丙 != null)
            {
                    丄丌丙七一丏下万丙.uv = val_46;
            }
            else
            {
                    丄丌丙七一丏下万丙.uv = val_46;
            }
            
            丄丌丙七一丏下万丙.RecalculateNormals();
            val_59 = this.MeshCollider;
            val_59.sharedMesh = 丄丌丙七一丏下万丙;
            label_89:
            this.<丄丑丑丐丒且丘且专>k__BackingField = false;
        }
        internal void 万不丑丆七且上下一(HexTiles.HexCoords 丝丝丕丐丘业三丅丕, HexTiles.HexCoords 下丛丂一一丛七丒不, float 丟丌丐丘丆丙丑丑一)
        {
            null = null;
            int val_1 = System.Array.IndexOf<HexTiles.HexCoords>(array:  HexTiles.下丈上丆七丅丑与丗.东丈丁丒丛业与丅七, value:  下丛丂一一丛七丒不);
            if((val_1 & 2147483648) == 0)
            {
                    this.sidePieces.Add(item:  new SidePieceInfo() {side = new HexTiles.SidePiece() {direction = val_1, elevationDelta = 丟丌丐丘丆丙丑丑一}, hex = 丝丝丕丐丘业三丅丕});
                this.<丄丑丑丐丒且丘且专>k__BackingField = true;
                return;
            }
            
            System.ApplicationException val_3 = new System.ApplicationException(message:  "Hex tile " + 下丛丂一一丛七丒不 + " is not a valid adjacent tile.");
        }
        internal void 不丆丛丆丝丛丏上丑(HexTiles.HexCoords 丝丝丕丐丘业三丅丕, HexTiles.HexCoords 下丛丂一一丛七丒不)
        {
            var val_11;
            System.Collections.Generic.List<SidePieceInfo> val_12;
            System.Collections.Generic.IEnumerable<TSource> val_13;
            var val_14;
            HexChunk.丘丞三且东万丕丙丂 val_1 = new HexChunk.丘丞三且东万丕丙丂();
            .丝丝丕丐丘业三丅丕 = 丝丝丕丐丘业三丅丕;
            val_11 = null;
            val_11 = null;
            int val_2 = System.Array.IndexOf<HexTiles.HexCoords>(array:  HexTiles.下丈上丆七丅丑与丗.东丈丁丒丛业与丅七, value:  下丛丂一一丛七丒不);
            .丘丙东丞丌与丁丗上 = val_2;
            if((val_2 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_12 = 1152921504616005632;
            val_13 = System.Linq.Enumerable.Where<SidePieceInfo>(source:  this.sidePieces, predicate:  new System.Func<SidePieceInfo, System.Boolean>(object:  val_1, method:  System.Boolean HexChunk.丘丞三且东万丕丙丂::下与世丗三丞丙丒与(HexTiles.HexChunk.SidePieceInfo 东丁丘专与上与丗下)));
            val_14 = 0;
            goto label_5;
            label_9:
            val_12 = this.sidePieces;
            val_13 = System.Linq.Enumerable.ToArray<SidePieceInfo>(source:  System.Linq.Enumerable.Where<SidePieceInfo>(source:  val_13, predicate:  new System.Func<SidePieceInfo, System.Boolean>(object:  val_1, method:  System.Boolean HexChunk.丘丞三且东万丕丙丂::七丑丂丞且丆丛丆丙(HexTiles.HexChunk.SidePieceInfo 东丁丘专与上与丗下))))[0];
            bool val_8 = val_12.Remove(item:  new SidePieceInfo() {side = new HexTiles.SidePiece() {direction = System.Linq.Enumerable.ToArray<SidePieceInfo>(source:  System.Linq.Enumerable.Where<SidePieceInfo>(source:  val_13, predicate:  new System.Func<SidePieceInfo, System.Boolean>(object:  val_1, method:  System.Boolean HexChunk.丘丞三且东万丕丙丂::七丑丂丞且丆丛丆丙(HexTiles.HexChunk.SidePieceInfo 东丁丘专与上与丗下))))[0], elevationDelta = System.Linq.Enumerable.ToArray<SidePieceInfo>(source:  System.Linq.Enumerable.Where<SidePieceInfo>(source:  val_13, predicate:  new System.Func<SidePieceInfo, System.Boolean>(object:  val_1, method:  System.Boolean HexChunk.丘丞三且东万丕丙丂::七丑丂丞且丆丛丆丙(HexTiles.HexChunk.SidePieceInfo 东丁丘专与上与丗下))))[0]}, hex = val_13});
            val_14 = 1;
            label_5:
            if(val_14 < val_7.Length)
            {
                goto label_9;
            }
            
            this.<丄丑丑丐丒且丘且专>k__BackingField = true;
            return;
            label_4:
            System.ApplicationException val_10 = new System.ApplicationException(message:  "Hex tile " + 下丛丂一一丛七丒不 + " is not a valid adjacent tile.");
        }
        internal void 不上世丕丂丈丗丅一()
        {
            this.sidePieces.Clear();
        }
        public HexChunk()
        {
            this.tileDiameter = 1f;
            this.sidePieces = new System.Collections.Generic.List<SidePieceInfo>();
            this.tiles = new System.Collections.Generic.List<HexTiles.HexPosition>();
        }
    
    }

}
