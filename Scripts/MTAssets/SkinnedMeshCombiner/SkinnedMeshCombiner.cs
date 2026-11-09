using UnityEngine;

namespace MTAssets.SkinnedMeshCombiner
{
    public class SkinnedMeshCombiner : MonoBehaviour
    {
        // Fields
        private const int 丙丌丌丁丂与丞丄丏 = 50000;
        public UnityEngine.GameObject[] resultMergeOriginalGameObjects;
        public UnityEngine.GameObject resultMergeGameObject;
        public string resultMergeTextStats;
        public System.Collections.Generic.List<MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.LogOfMerge> resultMergeLogs;
        public System.Collections.Generic.List<string> resultMergeAssetsSaved;
        public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丞不丌丈丘丛丘与丆 mergeMethod;
        public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.OneMeshPerMaterialParams oneMeshPerMaterialParams;
        public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.JustMaterialColorsParams justMaterialColorsParams;
        public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.AllInOneParams allInOneParams;
        public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.OnlyAnima2dMeshes onlyAnima2dMeshes;
        public bool compatibilityMode;
        public bool combineInactives;
        public bool combineOnStart;
        public bool convertCombinedMeshToStaticOnStart;
        public bool ignoreBlendshapes;
        public string nameOfThisMerge;
        public System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToIgnore;
        public bool saveDataInAssets;
        public bool savePrefabOfMerge;
        public string nameOfPrefabOfMerge;
        public bool launchConsoleLogs;
        public bool highlightUvVertices;
        public UnityEngine.Events.UnityEvent onCombineMeshs;
        public UnityEngine.Events.UnityEvent onUndoCombineMeshs;
        
        // Methods
        private void Start()
        {
            this.三丙专丁上世丁丂丁();
            if(this.combineOnStart == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying != false)
            {
                    this.CombineMeshes();
            }
            
            if(this.combineOnStart == false)
            {
                    return;
            }
            
            if(this.convertCombinedMeshToStaticOnStart == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.ConvertCombinedMeshToStaticMesh();
        }
        public bool isMeshesCombined()
        {
            return UnityEngine.Object.op_Inequality(x:  this.resultMergeGameObject, y:  0);
        }
        public void CombineMeshes()
        {
            if(this.mergeMethod == 2)
            {
                goto label_0;
            }
            
            if(this.mergeMethod == 1)
            {
                goto label_1;
            }
            
            if(this.mergeMethod != 0)
            {
                    return;
            }
            
            this.专丛丞丌丗丘丌丂丕();
            return;
            label_0:
            this.丂丙万丝专丅三丏丗();
            return;
            label_1:
            this.下万七丙丕丆专丈丅();
        }
        public void UndoCombineMeshes(bool 丌丛丘业丑且丌不丝, bool 丕专丌丙万丆不丑丙)
        {
            if(this.isCombiendMeshesConvertedToStatic() != false)
            {
                    UnityEngine.Debug.LogError(message:  "Before undoing the meshes merge, please undo the conversion to static mesh by calling the \"UndoConvertCombinedMeshToStaticMesh()\" method.");
                return;
            }
            
            this.丞丅丝业丁丈丙丟丕(丕专丌丙万丆不丑丙:  丕专丌丙万丆不丑丙, 丌丛丘业丑且丌不丝:  丌丛丘业丑且丌不丝, 万三丅业丐三丘东上:  false);
        }
        public UnityEngine.SkinnedMeshRenderer GetCombinedMeshSkinnedMeshRenderer()
        {
            if(this.isMeshesCombined() != true)
            {
                    this.CombineMeshes();
            }
            
            if(this.resultMergeGameObject != null)
            {
                    return this.resultMergeGameObject.GetComponent<UnityEngine.SkinnedMeshRenderer>();
            }
            
            return this.resultMergeGameObject.GetComponent<UnityEngine.SkinnedMeshRenderer>();
        }
        public bool isCombiendMeshesConvertedToStatic()
        {
            if(this.resultMergeGameObject == 0)
            {
                    return false;
            }
            
            this = this.resultMergeGameObject.GetComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>();
            if(val_2.resultOfConversionToStaticMesh != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  val_2.resultOfConversionToStaticMesh, y:  0);
            }
            
            return false;
        }
        public UnityEngine.GameObject ConvertCombinedMeshToStaticMesh()
        {
            UnityEngine.GameObject val_18;
            object val_19;
            UnityEngine.GameObject val_20;
            var val_21;
            val_18 = 1152921504848912384;
            if(this.resultMergeGameObject != 0)
            {
                goto label_3;
            }
            
            val_19 = "Could not convert the combined mesh from \"" + this.gameObject.name + "\" to static. It is necessary that the meshes of this model are merged by the Skinned Mesh Combiner, before converting the combined mesh to a static mesh. Please combine the stitches first.";
            label_20:
            UnityEngine.Debug.LogWarning(message:  val_19);
            val_20 = 0;
            return val_20;
            label_3:
            val_19 = this.GetCombinedMeshSkinnedMeshRenderer();
            MTAssets.SkinnedMeshCombiner.CombinedMeshesManager val_7 = val_19.gameObject.GetComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>();
            val_18 = val_7.resultOfConversionToStaticMesh;
            if(val_18 != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "The combined mesh has already been converted to a static mesh.");
                val_20 = val_7.resultOfConversionToStaticMesh;
                return val_20;
            }
            
            if(val_7.mergeMethodUsed != 3)
            {
                goto label_17;
            }
            
            goto label_20;
            label_17:
            UnityEngine.Mesh val_9 = new UnityEngine.Mesh();
            if(val_9 != null)
            {
                    val_9.name = "Static Mesh";
            }
            else
            {
                    0.name = "Static Mesh";
            }
            
            val_9.indexFormat = 1;
            val_19.BakeMesh(mesh:  val_9);
            UnityEngine.GameObject val_10 = null;
            val_20 = val_10;
            val_10 = new UnityEngine.GameObject(name:  "Static Mesh");
            val_10.transform.SetParent(p:  val_19.gameObject.transform);
            val_7.resultOfConversionToStaticMesh = val_20;
            if(val_20 != null)
            {
                    val_21 = val_10.AddComponent<UnityEngine.MeshRenderer>();
            }
            else
            {
                    val_21 = val_10.AddComponent<UnityEngine.MeshRenderer>();
            }
            
            val_10.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_9;
            val_18 = val_19.sharedMaterials;
            val_21.sharedMaterials = val_18;
            val_19.enabled = false;
            return val_20;
        }
        public void UndoConvertCombinedMeshToStaticMesh()
        {
            var val_9;
            object val_10;
            if(this.resultMergeGameObject != 0)
            {
                goto label_3;
            }
            
            val_9 = "It is not possible to undo the conversion to static mesh, because the meshes of the \"" + this.gameObject.name + "\" model have not yet been combined.";
            val_10 = val_9;
            goto label_7;
            label_3:
            val_9 = this.GetCombinedMeshSkinnedMeshRenderer();
            MTAssets.SkinnedMeshCombiner.CombinedMeshesManager val_7 = val_9.gameObject.GetComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>();
            if(val_7.resultOfConversionToStaticMesh != 0)
            {
                goto label_13;
            }
            
            val_10 = "It is not possible to undo the conversion to static mesh, as no conversion to static mesh has been done yet.";
            label_7:
            UnityEngine.Debug.LogWarning(message:  val_10);
            return;
            label_13:
            UnityEngine.Object.Destroy(obj:  val_7.resultOfConversionToStaticMesh);
            val_9.enabled = true;
        }
        public UnityEngine.GameObject GetCombinedMeshConvertedToStatic()
        {
            if((this.resultMergeGameObject.GetComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>()) != null)
            {
                    return (UnityEngine.GameObject)val_1.resultOfConversionToStaticMesh;
            }
            
            return (UnityEngine.GameObject)val_1.resultOfConversionToStaticMesh;
        }
        private void 专丛丞丌丗丘丌丂丕()
        {
            System.Exception val_30;
            var val_39;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_58;
            float val_59;
            float val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            float val_67;
            float val_68;
            float val_69;
            float val_70;
            var val_77;
            float val_91;
            float val_92;
            float val_93;
            float val_94;
            var val_102;
            var val_127;
            UnityEngine.GameObject val_128;
            UnityEngine.AnimatorCullingMode val_129;
            UnityEngine.GameObject[] val_130;
            UnityEngine.SkinnedMeshRenderer[] val_131;
            var val_132;
            var val_133;
            System.Collections.Generic.List<一丞丄世丟丟丆丁业> val_134;
            var val_136;
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_137;
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_138;
            var val_139;
            var val_140;
            var val_142;
            UnityEngine.SkinnedMeshRenderer val_143;
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_144;
            var val_145;
            var val_151;
            var val_152;
            var val_153;
            var val_154;
            var val_155;
            var val_156;
            val_127;
            val_128 = this.resultMergeGameObject;
            if(val_128 != 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "Currently, this character\'s meshes are already merged. Please, before making a new merge, undo the merge previously done.", 世丗丕东丄三丕丂丒:  4);
                return;
            }
            
            val_128 = this.resultMergeLogs;
            val_128.Clear();
            this.三丙专丁上世丁丂丁();
            UnityEngine.Animator val_2 = this.GetComponent<UnityEngine.Animator>();
            val_129 = val_2.cullingMode;
            val_2.cullingMode = 0;
            System.DateTime val_4 = System.DateTime.Now;
            val_130 = this.丟专且丏丌丅万下与(丄一七丈丌专丘丆丗:  false, 七与丄东业业业丘丞:  true);
            val_131 = this.丄丒丁丝下丆丒东丁(世东专丂丙丂且丕七:  val_130);
            if((val_131 == null) || (val_6.Length <= 0))
            {
                goto label_11;
            }
            
            val_132 = this;
            bool val_7 = this.丘丐丅丗丟世三丙丌(不一且丟丁与丐世丞:  val_131, 七与丄东业业业丘丞:  true);
            if(val_7 == false)
            {
                goto label_14;
            }
            
            val_128 = this.oneMeshPerMaterialParams;
            if(val_128 == null)
            {
                    val_132 = 0;
            }
            
            if(this.oneMeshPerMaterialParams.mergeOnlyEqualRootBones == false)
            {
                goto label_14;
            }
            
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_11:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merge has been canceled. There may not be enough meshes to be combined. At least 1 valid mesh is required for the merge process to be possible. Also, there is the possibility that all the meshes found, are invalid or have been ignored during the merge process.", 世丗丕东丄三丕丂丒:  4);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_14:
            int val_8 = val_7.丏三丈丒下专丞万丂(不一且丟丁与丐世丞:  val_131);
            System.Collections.Generic.Dictionary<UnityEngine.Material, System.Collections.Generic.List<三丌丗丑丐业世丌丁>> val_9 = new System.Collections.Generic.Dictionary<UnityEngine.Material, System.Collections.Generic.List<三丌丗丑丐业世丌丁>>();
            if(val_6.Length < 1)
            {
                goto label_17;
            }
            
            label_45:
            UnityEngine.SkinnedMeshRenderer val_127 = val_131[0];
            val_133 = 0;
            goto label_19;
            label_44:
            if((null.ContainsKey(key:  val_127.sharedMaterials[0])) != false)
            {
                    new SkinnedMeshCombiner.三丌丗丑丐业世丌丁() = new SkinnedMeshCombiner.三丌丗丑丐业世丌丁(不丂丅丁且丆东东丂:  val_127.transform, 下下丏下且丒东一丗:  val_127, 丛丄丏与丙丅丐丅一:  0);
                null.Item[val_127.sharedMaterials[0]].Add(item:  new SkinnedMeshCombiner.三丌丗丑丐业世丌丁());
            }
            
            if((null.ContainsKey(key:  val_127.sharedMaterials[0])) != true)
            {
                    System.Collections.Generic.List<三丌丗丑丐业世丌丁> val_19 = new System.Collections.Generic.List<三丌丗丑丐业世丌丁>();
                new SkinnedMeshCombiner.三丌丗丑丐业世丌丁() = new SkinnedMeshCombiner.三丌丗丑丐业世丌丁(不丂丅丁且丆东东丂:  val_127.transform, 下下丏下且丒东一丗:  val_127, 丛丄丏与丙丅丐丅一:  0);
                null.Add(item:  new SkinnedMeshCombiner.三丌丗丑丐业世丌丁());
                null.Add(key:  val_127.sharedMaterials[0], value:  null);
            }
            
            val_131 = val_131;
            val_133 = 1;
            label_19:
            if(val_133 < val_127.sharedMesh.subMeshCount)
            {
                goto label_44;
            }
            
            if(1 < (val_6 + 24))
            {
                goto label_45;
            }
            
            label_17:
            val_134 = null;
            val_134 = new System.Collections.Generic.List<一丞丄世丟丟丆丁业>();
            new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  "Cache Obj");
            Dictionary.Enumerator<TKey, TValue> val_27 = null.GetEnumerator();
            val_136 = 1152921541482056112;
            val_137 = 1152921504691564544;
            val_138 = 0;
            val_139 = 0;
            goto label_48;
            label_134:
            ConfiguredValueTaskAwaiter val_31 = val_30.GetAwaiter();
            int val_32 = val_31._value._obj.Count;
            int val_33 = val_31._value._obj.Count;
            System.Collections.Generic.List<UnityEngine.Transform> val_34 = new System.Collections.Generic.List<UnityEngine.Transform>();
            System.Collections.Generic.List<UnityEngine.Matrix4x4> val_35 = new System.Collections.Generic.List<UnityEngine.Matrix4x4>();
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_36 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            List.Enumerator<T> val_37 = val_31._value._obj.GetEnumerator();
            goto label_52;
            label_81:
            string val_40 = val_39.丐丏七丌丕丗业且上();
            val_140 = 0;
            goto label_55;
            label_77:
            UnityEngine.Transform val_132 = val_138.bones[0];
            null.Add(item:  val_132);
            if(this.compatibilityMode == false)
            {
                goto label_58;
            }
            
            UnityEngine.Mesh val_42 = val_132.sharedMesh;
            UnityEngine.Matrix4x4 val_45 = val_42.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_50 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_42.bindposes[0], m10 = val_42.bindposes[0], m20 = val_42.bindposes[0], m30 = val_42.bindposes[0], m01 = val_42.bindposes[0], m11 = val_42.bindposes[0], m21 = val_42.bindposes[0], m31 = val_42.bindposes[0], m02 = val_42.bindposes[0], m12 = val_42.bindposes[0], m22 = val_42.bindposes[0], m32 = val_42.bindposes[0], m03 = val_42.bindposes[0], m13 = val_42.bindposes[0], m23 = val_42.bindposes[0], m33 = val_42.bindposes[0]}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_49, m10 = val_49, m20 = val_49, m30 = val_49, m01 = val_48, m11 = val_48, m21 = val_48, m31 = val_48, m02 = val_47, m12 = val_47, m22 = val_47, m32 = val_47, m03 = val_46, m13 = val_46, m23 = val_46, m33 = val_46});
            val_35.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_54, m10 = val_54, m20 = val_54, m30 = val_54, m01 = val_53, m11 = val_53, m21 = val_53, m31 = val_53, m02 = val_52, m12 = val_52, m22 = val_52, m32 = val_52, m03 = val_51, m13 = val_51, m23 = val_51, m33 = val_51});
            if(this.compatibilityMode == true)
            {
                goto label_68;
            }
            
            label_58:
            UnityEngine.Matrix4x4 val_55 = val_41[0x0] + 32.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_57 = val_41[0x0] + 32.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_66 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_60, m10 = val_60, m20 = val_60, m30 = val_60, m01 = val_61, m11 = val_61, m21 = val_61, m31 = val_61, m02 = val_58, m12 = val_58, m22 = val_58, m32 = val_58, m03 = val_59, m13 = val_59, m23 = val_59, m33 = val_59}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_64, m10 = val_64, m20 = val_64, m30 = val_64, m01 = val_65, m11 = val_65, m21 = val_65, m31 = val_65, m02 = val_62, m12 = val_62, m22 = val_62, m32 = val_62, m03 = val_63, m13 = val_63, m23 = val_63, m33 = val_63});
            val_35.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_69, m10 = val_69, m20 = val_69, m30 = val_69, m01 = val_70, m11 = val_70, m21 = val_70, m31 = val_70, m02 = val_67, m12 = val_67, m22 = val_67, m32 = val_67, m03 = val_68, m13 = val_68, m23 = val_68, m33 = val_68});
            label_68:
            val_140 = 1;
            label_55:
            if(val_140 < val_41.Length)
            {
                goto label_77;
            }
            
            val_142 = 1152921504691564544;
            val_143 = new UnityEngine.GameObject().AddComponent<UnityEngine.SkinnedMeshRenderer>();
            UnityEngine.Mesh val_71 = val_41[0x0] + 32.sharedMesh;
            UnityEngine.Matrix4x4 val_72 = val_40.m_stringLength.localToWorldMatrix;
            val_36.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            val_144 = val_138;
            label_52:
            if(((-1778858592) & 1) != 0)
            {
                goto label_81;
            }
            
            val_145 = val_139 + 1;
            mem2[0] = 797;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (val_77 == 797))
            {
                    var val_137 = 0;
                val_137 = val_137 ^ 0;
                val_145 =  + val_137;
            }
            else
            {
                    if( != 0)
            {
                    val_144 = 0;
            }
            
            }
            
            new UnityEngine.Mesh() = new UnityEngine.Mesh();
            if(val_8 > 50000)
            {
                    new UnityEngine.Mesh().indexFormat = 1;
            }
            else
            {
                    new UnityEngine.Mesh().indexFormat = 0;
            }
            
            new UnityEngine.Mesh().CombineMeshes(combine:  val_36.ToArray(), mergeSubMeshes:  true, useMatrices:  true);
            sharedMesh = new UnityEngine.Mesh();
            sharedMesh.bindposes = val_35.ToArray();
            bones = null.ToArray();
            sharedMaterial = val_31._value._obj.丐丏七丌丕丗业且上();
            UnityEngine.Matrix4x4 val_85 = transform.worldToLocalMatrix;
            val_134 = val_134;
            new SkinnedMeshCombiner.一丞丄世丟丟丆丁业() = new SkinnedMeshCombiner.一丞丄世丟丟丆丁业(丗丄丕丙世专丂专三:  new UnityEngine.Matrix4x4() {m00 = val_93, m10 = val_93, m20 = val_93, m30 = val_93, m01 = val_94, m11 = val_94, m21 = val_94, m31 = val_94, m02 = val_91, m12 = val_91, m22 = val_91, m32 = val_91, m03 = val_92, m13 = val_92, m23 = val_92, m33 = val_92}, 七丕三丁丄下丒下丏:  sharedMesh, 七丂七七丗丕丗丒丒:  bones, 丐七丙丙上丒七丌丆:  sharedMesh.bindposes, 丄丘丁丁丞丞上丝丆:  sharedMaterial);
            null.Add(item:  new SkinnedMeshCombiner.一丞丄世丟丟丆丁业());
            val_136 = 1152921541482056112;
            val_139 = ;
            val_137 = ;
            val_138 = val_144;
            label_48:
            if(((-1778858544) & 1) != 0)
            {
                goto label_134;
            }
            
            val_151 = -1778860160;
            val_152 = 0;
            val_153 = val_139 + 1;
            mem2[0] = 993;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_154 = val_153;
            if((val_154 != 1) && ((val_151 + ((val_139 + 1)) << 2) == 993))
            {
                    var val_138 = 0;
                val_138 = val_138 ^ (val_154 >> 31);
                val_154 = val_154 + val_138;
            }
            else
            {
                    if( != 0)
            {
                    val_138 = 0;
            }
            
            }
            
            且丐丐七世丌丒丆丄(下丐三丆丝与不丗丕:  new UnityEngine.GameObject());
            System.Collections.Generic.List<UnityEngine.Transform> val_96 = new System.Collections.Generic.List<UnityEngine.Transform>();
            System.Collections.Generic.List<UnityEngine.Matrix4x4> val_97 = new System.Collections.Generic.List<UnityEngine.Matrix4x4>();
             = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            System.Collections.Generic.List<UnityEngine.Material> val_99 = new System.Collections.Generic.List<UnityEngine.Material>();
            List.Enumerator<T> val_100 = null.GetEnumerator();
            label_229:
            if(((-1778858720) & 1) == 0)
            {
                goto label_213;
            }
            
            val_137.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            val_155 = 0;
            goto label_216;
            label_220:
            null.Add(item:  public MailBoxChildFullContet List.Enumerator<MailBoxChildFullContet>::get_Current());
            val_155 = 1;
            label_216:
            if(val_155 < (public 丒丕丘丕丗丏业丐世 List.Enumerator<丒丕丘丕丗丏业丐世>::get_Current()))
            {
                goto label_220;
            }
            
            val_156 = 0;
            goto label_222;
            label_226:
            null.Add(item:  new UnityEngine.Matrix4x4() {m00 = -1.775915E+14f, m10 = 2.524357E-29f, m20 = -1.775915E+14f, m30 = 2.524357E-29f, m01 = 2.639845E-28f, m11 = 2.524357E-29f, m21 = 2.639845E-28f, m31 = 2.524357E-29f, m02 = 4.090956E+12f, m12 = 2.524357E-29f, m22 = 4.090956E+12f, m32 = 2.524357E-29f, m03 = 1.251471E-21f, m13 = 2.524357E-29f, m23 = 1.251471E-21f, m33 = 2.524357E-29f});
            val_156 = 1;
            label_222:
            if(val_156 < (public 丒丕丘丕丗丏业丐世 List.Enumerator<丒丕丘丕丗丏业丐世>::get_Current()))
            {
                goto label_226;
            }
            
            val_99.Add(item:  val_102.丐丏七丌丕丗业且上());
            goto label_229;
            label_213:
            var val_139 = val_154;
            val_139 = val_139 + 1;
            mem2[0] = 1239;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_139 == 1)
            {
                goto label_252;
            }
            
            if( == 0)
            {
                goto label_256;
            }
            
            if((val_151 + (((val_139 + 1) + 1)) << 2) != 1239)
            {
                goto label_254;
            }
            
            goto label_256;
            label_252:
            if( == 0)
            {
                goto label_256;
            }
            
            label_254:
            label_256:
            new UnityEngine.Mesh() = new UnityEngine.Mesh();
            if(val_8 > 50000)
            {
                    new UnityEngine.Mesh().indexFormat = 1;
            }
            else
            {
                    new UnityEngine.Mesh().indexFormat = 0;
            }
            
            new UnityEngine.Mesh().name = "Combined Meshes (One Mesh Per Material)";
            new UnityEngine.Mesh().CombineMeshes(combine:  val_137.ToArray(), mergeSubMeshes:  false);
            new UnityEngine.Mesh().RecalculateBounds();
            new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  this.nameOfThisMerge);
            this.resultMergeGameObject = new UnityEngine.GameObject();
            new UnityEngine.GameObject().transform.SetParent(p:  this.gameObject.transform);
            UnityEngine.SkinnedMeshRenderer val_110 = this.resultMergeGameObject.AddComponent<UnityEngine.SkinnedMeshRenderer>();
            val_110.sharedMesh = new UnityEngine.Mesh();
            val_110.bones = null.ToArray();
            val_110.sharedMesh.bindposes = null.ToArray();
            val_129 = val_129;
            val_130 = 1152921504618614784;
            val_110.sharedMaterials = val_99.ToArray();
            val_110.rootBone = val_6 + 32.rootBone;
            UnityEngine.GameObject val_117 = this.gameObject;
            if((this.resultMergeGameObject.AddComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>()) != null)
            {
                    val_116.rootGameObject = val_117;
                val_116.mergeMethodUsed = 0;
            }
            else
            {
                    mem[24] = val_117;
                mem[32] = 0;
            }
            
            val_116.sourceMeshes = val_131;
            this.resultMergeOriginalGameObjects = val_130;
            if((val_6 + 24) >= 1)
            {
                    do
            {
                long val_140 = 0;
                UnityEngine.SkinnedMeshRenderer[] val_118 = val_131 + 0;
                (val_6 + 0) + 32.gameObject.SetActive(value:  false);
                val_140 = val_140 + 1;
            }
            while(val_140 < (val_6 + 24));
            
            }
            
            val_128 = val_2;
            val_128.cullingMode = val_129;
            System.DateTime val_120 = System.DateTime.Now;
            if(this.saveDataInAssets != false)
            {
                    UnityEngine.Mesh val_121 = val_110.sharedMesh;
                val_128 = this.gameObject;
                string val_123 = val_128.name;
            }
            
            if(this.savePrefabOfMerge != false)
            {
                    UnityEngine.GameObject val_124 = this.gameObject;
            }
            
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merging of the meshes was completed successfully! The name of this merge is \""("The merging of the meshes was completed successfully! The name of this merge is \"") + this.nameOfThisMerge + "\"!"("\"!"), 世丗丕东丄三丕丂丒:  3);
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.onCombineMeshs == null)
            {
                    return;
            }
            
            this.onCombineMeshs.Invoke();
        }
        private void 丂丙万丝专丅三丏丗()
        {
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            System.Exception val_89;
            var val_173;
            UnityEngine.GameObject val_174;
            UnityEngine.GameObject[] val_175;
            UnityEngine.SkinnedMeshRenderer[] val_176;
            JustMaterialColorsParams val_177;
            var val_178;
            var val_179;
            SkinnedMeshCombiner.丈丟丞丆世丐上万七 val_180;
            float val_181;
            var val_182;
            var val_183;
            var val_184;
            float val_185;
            var val_186;
            var val_188;
            float val_189;
            var val_190;
            float val_192;
            float val_193;
            var val_194;
            UnityEngine.SkinnedMeshRenderer[] val_195;
            System.Collections.Generic.List<T> val_196;
            var val_197;
            万丅丐不且丌专与丐 val_200;
            var val_201;
            UnityEngine.AnimatorCullingMode val_202;
            System.Collections.Generic.List<T> val_203;
            val_173;
            val_174 = this.resultMergeGameObject;
            if(val_174 != 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "Currently, this character\'s meshes are already merged. Please, before making a new merge, undo the merge previously done.", 世丗丕东丄三丕丂丒:  4);
                return;
            }
            
            this.resultMergeLogs.Clear();
            this.三丙专丁上世丁丂丁();
            val_174 = this.GetComponent<UnityEngine.Animator>();
            UnityEngine.AnimatorCullingMode val_3 = val_174.cullingMode;
            val_174.cullingMode = 0;
            System.DateTime val_4 = System.DateTime.Now;
            val_175 = this.丟专且丏丌丅万下与(丄一七丈丌专丘丆丗:  false, 七与丄东业业业丘丞:  true);
            val_176 = this.丄丒丁丝下丆丒东丁(世东专丂丙丂且丕七:  val_175);
            val_177 = this.justMaterialColorsParams;
            if(this.justMaterialColorsParams.materialToUse == 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "You must provide a material to be used by the mesh resulting from the merge. This material will be a copy of the material you provide, and it will hold the merge atlas for example. Please provide a material for use, so that merge is possible.", 世丗丕东丄三丕丂丒:  1);
                this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
                return;
            }
            
            if((val_176 == null) || (val_6.Length <= 0))
            {
                goto label_16;
            }
            
            val_178 = this;
            bool val_8 = this.丘丐丅丗丟世三丙丌(不一且丟丁与丐世丞:  val_176, 七与丄东业业业丘丞:  true);
            if(val_8 == false)
            {
                goto label_19;
            }
            
            if(this.justMaterialColorsParams == null)
            {
                    val_178 = 0;
            }
            
            if(this.justMaterialColorsParams.mergeOnlyEqualsRootBones == false)
            {
                goto label_19;
            }
            
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_16:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merge has been canceled. There may not be enough meshes to be combined. At least 1 valid mesh is required for the merge process to be possible. Also, there is the possibility that all the meshes found, are invalid or have been ignored during the merge process.", 世丗丕东丄三丕丂丒:  4);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_19:
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_10 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            System.Collections.Generic.List<UnityEngine.Transform> val_11 = new System.Collections.Generic.List<UnityEngine.Transform>();
            System.Collections.Generic.List<UnityEngine.Matrix4x4> val_12 = new System.Collections.Generic.List<UnityEngine.Matrix4x4>();
            System.Collections.Generic.List<丈丟丞丆世丐上万七> val_13 = new System.Collections.Generic.List<丈丟丞丆世丐上万七>();
            if(val_6.Length < 1)
            {
                goto label_22;
            }
            
            label_66:
            UnityEngine.SkinnedMeshRenderer val_174 = val_176[0];
            goto label_24;
            label_65:
            val_179 = 0;
            goto label_26;
            label_48:
            null.Add(item:  val_174.bones[0]);
            if(this.compatibilityMode == false)
            {
                goto label_29;
            }
            
            UnityEngine.Matrix4x4 val_18 = val_174.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_23 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_174.sharedMesh.bindposes[0], m10 = val_174.sharedMesh.bindposes[0], m20 = val_174.sharedMesh.bindposes[0], m30 = val_174.sharedMesh.bindposes[0], m01 = val_174.sharedMesh.bindposes[0], m11 = val_174.sharedMesh.bindposes[0], m21 = val_174.sharedMesh.bindposes[0], m31 = val_174.sharedMesh.bindposes[0], m02 = val_174.sharedMesh.bindposes[0], m12 = val_174.sharedMesh.bindposes[0], m22 = val_174.sharedMesh.bindposes[0], m32 = val_174.sharedMesh.bindposes[0], m03 = val_174.sharedMesh.bindposes[0], m13 = val_174.sharedMesh.bindposes[0], m23 = val_174.sharedMesh.bindposes[0], m33 = val_174.sharedMesh.bindposes[0]}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_21, m10 = val_21, m20 = val_21, m30 = val_21, m01 = val_22, m11 = val_22, m21 = val_22, m31 = val_22, m02 = val_19, m12 = val_19, m22 = val_19, m32 = val_19, m03 = val_20, m13 = val_20, m23 = val_20, m33 = val_20});
            val_12.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_26, m10 = val_26, m20 = val_26, m30 = val_26, m01 = val_27, m11 = val_27, m21 = val_27, m31 = val_27, m02 = val_24, m12 = val_24, m22 = val_24, m32 = val_24, m03 = val_25, m13 = val_25, m23 = val_25, m33 = val_25});
            if(this.compatibilityMode == true)
            {
                goto label_39;
            }
            
            label_29:
            UnityEngine.Matrix4x4 val_28 = val_14[0x0] + 32.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_30 = val_174.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_39 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_33, m10 = val_33, m20 = val_33, m30 = val_33, m01 = val_34, m11 = val_34, m21 = val_34, m31 = val_34, m02 = val_31, m12 = val_31, m22 = val_31, m32 = val_31, m03 = val_32, m13 = val_32, m23 = val_32, m33 = val_32}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_38, m11 = val_38, m21 = val_38, m31 = val_38, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_36, m13 = val_36, m23 = val_36, m33 = val_36});
            val_12.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_42, m10 = val_42, m20 = val_42, m30 = val_42, m01 = val_43, m11 = val_43, m21 = val_43, m31 = val_43, m02 = val_40, m12 = val_40, m22 = val_40, m32 = val_40, m03 = val_41, m13 = val_41, m23 = val_41, m33 = val_41});
            label_39:
            val_179 = 1;
            label_26:
            if(val_179 < val_14.Length)
            {
                goto label_48;
            }
            
            UnityEngine.Mesh val_44 = val_174.sharedMesh;
            UnityEngine.Matrix4x4 val_46 = val_174.transform.localToWorldMatrix;
            val_10.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            new SkinnedMeshCombiner.丈丟丞丆世丐上万七() = new SkinnedMeshCombiner.丈丟丞丆世丐上万七();
            .与世丕与丟丏三业丗 = 0;
            .丘世不丐业丕与丞丂 = new UnityEngine.Vector2[0];
            val_176 = val_176;
            val_180 = new SkinnedMeshCombiner.丈丟丞丆世丐上万七();
            mem[1152921541485194736] = this.丘丕丅丗丅丑丘丒丁(丞一与丆丘丏世丏丕:  val_174.sharedMaterials[0], 丅丑丕业丁不丙与丟:  this.justMaterialColorsParams.colorPropertyToFind, 业与三万七丝不万东:  64, 丟丌丐丘丆丙丑丑一:  64);
            if(val_13 == 0)
            {
                    val_180 = new SkinnedMeshCombiner.丈丟丞丆世丐上万七();
            }
            
            val_13.Add(item:  new SkinnedMeshCombiner.丈丟丞丆世丐上万七());
            int val_58 = val_13.Count;
            UnityEngine.Vector2[] val_61 = MTAssets.SkinnedMeshCombiner.不下不丏三上万万丗.丙丏丁丆丈丗丝丘丏(不与丌丏不丘不丛丁:  mesh, 东专丅丄丐丐丗丟丅:  0).uv;
            int val_181 = 0;
            val_181 = (MTAssets.SkinnedMeshCombiner.不下不丏三上万万丗.丙丏丁丆丈丗丝丘丏(不与丌丏不丘不丛丁:  mesh, 东专丅丄丐丐丗丟丅:  0).vertexCount) + val_181;
            label_24:
            if(1 < val_174.sharedMesh.subMeshCount)
            {
                goto label_65;
            }
            
            if(1 < (val_6 + 24))
            {
                goto label_66;
            }
            
            label_22:
            new UnityEngine.Mesh() = new UnityEngine.Mesh();
            if((val_8.丏三丈丒下专丞万丂(不一且丟丁与丐世丞:  val_176)) > 50000)
            {
                    new UnityEngine.Mesh().indexFormat = 1;
            }
            else
            {
                    new UnityEngine.Mesh().indexFormat = 0;
            }
            
            new UnityEngine.Mesh().name = "Combined Meshes (Just Material Colors)";
            new UnityEngine.Mesh().CombineMeshes(combine:  val_10.ToArray(), mergeSubMeshes:  true, useMatrices:  true);
            new UnityEngine.Mesh().RecalculateBounds();
            new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  this.nameOfThisMerge);
            this.resultMergeGameObject = new UnityEngine.GameObject();
            new UnityEngine.GameObject().transform.SetParent(p:  this.gameObject.transform);
            UnityEngine.SkinnedMeshRenderer val_70 = this.resultMergeGameObject.AddComponent<UnityEngine.SkinnedMeshRenderer>();
            val_70.sharedMesh = new UnityEngine.Mesh();
            val_70.bones = null.ToArray();
            val_70.sharedMesh.bindposes = val_12.ToArray();
            val_70.rootBone = val_6 + 32.rootBone;
            UnityEngine.Material[] val_75 = new UnityEngine.Material[1];
            val_75[0] = this.丞丛丛下丛丅东专三(丞一与丆丘丏世丏丕:  this.justMaterialColorsParams.materialToUse, 丁丗下丏丛东丙业丆:  true, 丈业丆丄丟专丛丏丌:  true);
            val_70.sharedMaterials = val_75;
            val_70.sharedMaterials[0].name = "Combined Materials (Just Material Colors)";
            T[] val_78 = val_13.ToArray();
            万丅丐不且丌专与丐 val_183 = val_78.丘丟三一东业三世上(上丄丛丟丂三丘丘一:  val_78, 东丈七丑丅丛且且丄:  256, 万丛与丘世万丗丂东:  0, 丒专丒丝与三丈世丗:  true);
            UnityEngine.Vector2[] val_81 = val_70.sharedMesh.uv;
            if(val_81.Length == 0)
            {
                goto label_102;
            }
            
            UnityEngine.Vector2[] val_83 = val_70.sharedMesh.uv;
            if(val_70.sharedMesh.vertexCount != val_83.Length)
            {
                goto label_108;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_86 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            List.Enumerator<T> val_87 = val_13.GetEnumerator();
            val_181 = 0.8f;
            goto label_110;
            label_102:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "It was not possible to create a UV map for the combined mesh. Originally, this character\'s meshes do not have a UV mapping. Create a UV mapping for this character or try using a blending method that does not work with UV mapping, such as One Mesh Per Material.", 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_108:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "It was not possible to create a new UV map for the combianda mesh. The amount of vertices in the original UV map is different from the amount of vertices that the original meshes have, that is, not all vertices of this character are in the UV map. Make sure that all the vertices of this character are on the UV map or try using a blending method that does not work with UV mapping, such as One Mesh Per Material.", 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_201:
            string val_90 = val_89.丐丏七丌丕丗业且上();
            val_182 = 0;
            goto label_113;
            label_122:
            val_183 = val_182 + val_183;
            UnityEngine.Vector2 val_185 = val_70.sharedMesh.uv[(long)val_183];
            var val_93 = (val_14[0x0] + 32) + 0;
            val_182 = 1;
            mem2[0] = val_70.sharedMesh.uv[(long)val_183];
            mem2[0] = val_185;
            label_113:
            if(val_182 < (mem[val_92[(long)(int)((val_182 + val_79))][0] + 24]))
            {
                goto label_122;
            }
            
            val_183 = 0;
            goto label_123;
            label_139:
            if((val_92[(long)(int)((val_182 + val_79))][0].x + 32) < 0)
            {
                    val_184 = val_185;
                mem2[0] = -(val_92[(long)(int)((val_182 + val_79))][0].x + 32);
            }
            
            val_185 = mem[val_92[(long)(int)((val_182 + val_79))][0].x + 36];
            val_185 = val_92[(long)(int)((val_182 + val_79))][0].x + 36;
            if(val_185 < 0)
            {
                    val_186 = val_185;
                val_185 = -(val_92[(long)(int)((val_182 + val_79))][0].x + 36);
                mem2[0] = val_185;
            }
            
            val_183 = 1;
            label_123:
            if(val_183 < 28563616)
            {
                goto label_139;
            }
            
            UnityEngine.Vector2 val_94 = UnityEngine.Vector2.zero;
            val_188 = 0;
            goto label_142;
            label_150:
            val_189 = val_94.x;
            UnityEngine.Vector2 val_97 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Max(a:  val_92[(long)(int)((val_182 + val_79))][0].x + 32, b:  val_189), y:  UnityEngine.Mathf.Max(a:  val_92[(long)(int)((val_182 + val_79))][0].x + 36, b:  val_94.y));
            val_188 = 1;
            label_142:
            if(val_188 < 28563616)
            {
                goto label_150;
            }
            
            UnityEngine.Vector2 val_98 = new UnityEngine.Vector2(x:  V8.16B, y:  V8.16B);
            int val_99 = val_183.与丈丑万丕世世丑业(与万丆丛丒万丝丙丑:  val_90.m_stringLength);
            val_190 = 0;
            goto label_152;
            label_200:
            UnityEngine.Vector2 val_100 = UnityEngine.Vector2.zero;
            val_192 = val_100.x;
            val_189 = val_100.y;
            if(val_97.x <= S14)
            {
                    float val_103 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32.x;
                var val_105 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                val_193 = val_98.x;
                var val_106 = (val_79 + 24) + 0;
                val_192 = UnityEngine.Mathf.Lerp(a:  val_103, b:  val_103, t:  UnityEngine.Mathf.Lerp(a:  val_193, b:  S14 - val_193, t:  (val_79 + 24 + 0) + 32));
            }
            
            if(val_97.y <= S14)
            {
                    var val_111 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                var val_113 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                val_193 = val_98.y;
                var val_114 = (val_79 + 24) + 0;
                val_189 = UnityEngine.Mathf.Lerp(a:  val_97.y, b:  val_97.y, t:  UnityEngine.Mathf.Lerp(a:  val_193, b:  S14 - val_193, t:  (val_79 + 24 + 0) + 36));
            }
            
            if(val_97.x > S14)
            {
                    float val_120 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32.x;
                var val_122 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                val_193 = val_98.x;
                var val_123 = (val_79 + 24) + 0;
                val_192 = UnityEngine.Mathf.Lerp(a:  val_120, b:  val_120, t:  UnityEngine.Mathf.Lerp(a:  val_193, b:  S14 - val_193, t:  ((val_79 + 24 + 0) + 32) / val_97.x));
            }
            
            if(val_97.y > S14)
            {
                    var val_129 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                var val_131 = ((val_79 + 24) + (((long)(int)(val_99)) << 4)) + 32;
                val_193 = val_98.y;
                var val_132 = (val_79 + 24) + 0;
                val_189 = UnityEngine.Mathf.Lerp(a:  val_97.y, b:  val_97.y, t:  UnityEngine.Mathf.Lerp(a:  val_193, b:  S14 - val_193, t:  ((val_79 + 24 + 0) + 36) / val_97.y));
            }
            
            null.Add(item:  new UnityEngine.Vector2() {x = val_192, y = val_189});
            val_190 = 1;
            label_152:
            if(val_190 < (val_79 + 24 + 24))
            {
                goto label_200;
            }
            
            label_110:
            if(((-1776656624) & 1) != 0)
            {
                goto label_201;
            }
            
            val_194 = 0;
            val_175 = 1152921504618614784;
            val_195 = val_176;
            val_196 = null;
            val_197 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_342;
            }
            
            if( == 0)
            {
                goto label_346;
            }
            
            if(2025 != 2025)
            {
                goto label_344;
            }
            
            goto label_346;
            label_342:
            if( == 0)
            {
                goto label_346;
            }
            
            label_344:
            label_346:
            UnityEngine.Vector2[] val_138 = val_70.sharedMesh.uv;
            if((System.Linq.Enumerable.Count<UnityEngine.Vector2>(source:  null)) != val_138.Length)
            {
                goto label_350;
            }
            
            val_70.sharedMesh.uv = null.ToArray();
            val_200 = val_183;
            val_177 = this.justMaterialColorsParams;
            UnityEngine.Material val_186 = val_70.sharedMaterials[0];
            this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_186, 三丄专丅与且世七专:  this.justMaterialColorsParams.mainTexturePropertyToInsert, 丄上业丛丌丂丝丝丒:  val_79 + 16);
            if(this.highlightUvVertices == false)
            {
                goto label_359;
            }
            
            val_177 = 0;
            goto label_360;
            label_374:
            val_201 = 0;
            if(val_177 >= val_144.Length)
            {
                    val_201 = 0;
            }
            
            val_181 = val_70.sharedMesh.uv[0];
            UnityEngine.Color val_147 = UnityEngine.Color.yellow;
            float val_188 = (float)val_186;
            float val_189 = (float)val_79 + 16;
            val_188 = val_181 * val_188;
            val_189 = val_70.sharedMesh.uv[0] * val_189;
            val_186.SetPixel(x:  (int)val_188, y:  (int)val_189, color:  new UnityEngine.Color() {r = val_147.r, g = val_147.g, b = val_147.b, a = val_147.a});
            val_200 = val_183;
            val_175 = 1152921504618614784;
            val_195 = val_176;
            val_177 = 1;
            label_360:
            UnityEngine.Vector2[] val_149 = val_70.sharedMesh.uv;
            if(val_177 < val_149.Length)
            {
                goto label_374;
            }
            
            val_79 + 16.Apply();
            label_359:
            UnityEngine.GameObject val_151 = this.gameObject;
            if((this.resultMergeGameObject.AddComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>()) == null)
            {
                goto label_377;
            }
            
            val_150.rootGameObject = val_151;
            val_150.mergeMethodUsed = 2;
            val_202 = val_3;
            val_203 = null;
            goto label_378;
            label_350:
            object[] val_152 = new object[5];
            val_174 = val_152;
            val_174[0] = "Could not proceed with the merge. For some reason, the new UV mesh generated, does not match the UV mesh of this character... So the merging was interrupted, to avoid mapping errors. Please contact MT Assets support at mtassets@windsoft.xyz.\n\nThe new UV map have ";
            val_177 = 1152921504622075904;
            val_174[1] = null.Count;
            val_174[2] = " vertices and the original UV map have ";
            UnityEngine.Vector2[] val_155 = val_70.sharedMesh.uv;
            val_174[3] = val_155.Length;
            val_174[4] = " vertices.";
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  +val_152, 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_377:
            mem[24] = val_151;
            mem[32] = 2;
            val_202 = val_3;
            val_203 = null;
            label_378:
            val_150.sourceMeshes = val_195;
            this.resultMergeOriginalGameObjects = val_175;
            if((val_6 + 24) >= 1)
            {
                    do
            {
                val_177 = 0;
                UnityEngine.SkinnedMeshRenderer[] val_157 = val_195 + 0;
                (val_6 + 0) + 32.gameObject.SetActive(value:  false);
            }
            while((val_177 + 1) < (val_6 + 24));
            
            }
            
            val_174.cullingMode = val_202;
            System.DateTime val_160 = System.DateTime.Now;
            if(this.saveDataInAssets != false)
            {
                    UnityEngine.Mesh val_161 = val_70.sharedMesh;
                val_174 = this.gameObject;
                string val_163 = val_174.name;
                if(this.saveDataInAssets != false)
            {
                    val_174 = this.gameObject;
                string val_166 = val_174.name + " (ColorAtlas)";
                if(this.saveDataInAssets != false)
            {
                    UnityEngine.Material[] val_167 = val_70.sharedMaterials;
                val_174 = this.gameObject;
                val_203 = null;
                string val_169 = val_174.name;
            }
            
            }
            
            }
            
            if(this.savePrefabOfMerge != false)
            {
                    UnityEngine.GameObject val_170 = this.gameObject;
            }
            
            int val_171 = null.Count;
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merging of the meshes was completed successfully! The name of this merge is \""("The merging of the meshes was completed successfully! The name of this merge is \"") + this.nameOfThisMerge + "\"!"("\"!"), 世丗丕东丄三丕丂丒:  3);
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.onCombineMeshs == null)
            {
                    return;
            }
            
            this.onCombineMeshs.Invoke();
        }
        private void 下万七丙丕丆专丈丅()
        {
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            System.Exception val_170;
            var val_288;
            UnityEngine.Material val_289;
            UnityEngine.GameObject val_290;
            UnityEngine.AnimatorCullingMode val_291;
            UnityEngine.GameObject[] val_292;
            UnityEngine.SkinnedMeshRenderer[] val_293;
            System.Collections.Generic.List<UnityEngine.Matrix4x4> val_294;
            UnityEngine.SkinnedMeshRenderer val_295;
            var val_296;
            System.Collections.Generic.Dictionary<TKey, TValue> val_297;
            SkinnedMeshCombiner.丒丕丘丕丗丏业丐世 val_298;
            SkinnedMeshCombiner.丒丕丘丕丗丏业丐世 val_299;
            var val_300;
            var val_301;
            var val_302;
            var val_303;
            UnityEngine.Vector2 val_304;
            UnityEngine.Vector2 val_305;
            var val_306;
            var val_308;
            var val_309;
            float val_311;
            float val_312;
            float val_313;
            System.Collections.Generic.List<T> val_314;
            var val_315;
            var val_316;
            var val_319;
            val_288;
            val_289 = 1152921504848912384;
            val_290 = this.resultMergeGameObject;
            if(val_290 != 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "Currently, this character\'s meshes are already merged. Please, before making a new merge, undo the merge previously done.", 世丗丕东丄三丕丂丒:  4);
                return;
            }
            
            this.resultMergeLogs.Clear();
            this.三丙专丁上世丁丂丁();
            val_290 = this.GetComponent<UnityEngine.Animator>();
            val_291 = val_290.cullingMode;
            val_290.cullingMode = 0;
            System.DateTime val_4 = System.DateTime.Now;
            val_292 = this.丟专且丏丌丅万下与(丄一七丈丌专丘丆丗:  false, 七与丄东业业业丘丞:  true);
            val_293 = this.丄丒丁丝下丆丒东丁(世东专丂丙丂且丕七:  val_292);
            if(this.allInOneParams.materialToUse == 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "You must provide a material to be used by the mesh resulting from the merge. This material will be a copy of the material you provide, and it will hold the merge atlas for example. Please provide a material for use, so that merge is possible.", 世丗丕东丄三丕丂丒:  1);
                this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
                return;
            }
            
            if((val_293 == null) || (val_6.Length <= 0))
            {
                goto label_16;
            }
            
            bool val_8 = this.丘丐丅丗丟世三丙丌(不一且丟丁与丐世丞:  val_293, 七与丄东业业业丘丞:  true);
            if((val_8 == false) || (this.allInOneParams.mergeOnlyEqualsRootBones == false))
            {
                goto label_19;
            }
            
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_16:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merge has been canceled. There may not be enough meshes to be combined. At least 1 valid mesh is required for the merge process to be possible. Also, there is the possibility that all the meshes found, are invalid or have been ignored during the merge process.", 世丗丕东丄三丕丂丒:  4);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_19:
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_10 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            System.Collections.Generic.List<UnityEngine.Transform> val_11 = new System.Collections.Generic.List<UnityEngine.Transform>();
            val_294 = null;
            val_294 = new System.Collections.Generic.List<UnityEngine.Matrix4x4>();
            System.Collections.Generic.List<丒丕丘丕丗丏业丐世> val_13 = new System.Collections.Generic.List<丒丕丘丕丗丏业丐世>();
            System.Collections.Generic.Dictionary<UnityEngine.Material, 丞丛丒丒丅丈丙三上> val_14 = new System.Collections.Generic.Dictionary<UnityEngine.Material, 丞丛丒丒丅丈丙三上>();
            if(val_6.Length < 1)
            {
                goto label_22;
            }
            
            label_205:
            val_295 = val_293[0];
            goto label_24;
            label_48:
            val_11.Add(item:  val_295.bones[0]);
            if(this.compatibilityMode == false)
            {
                goto label_29;
            }
            
            UnityEngine.Matrix4x4 val_19 = val_295.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_24 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_295.sharedMesh.bindposes[0], m10 = val_295.sharedMesh.bindposes[0], m20 = val_295.sharedMesh.bindposes[0], m30 = val_295.sharedMesh.bindposes[0], m01 = val_295.sharedMesh.bindposes[0], m11 = val_295.sharedMesh.bindposes[0], m21 = val_295.sharedMesh.bindposes[0], m31 = val_295.sharedMesh.bindposes[0], m02 = val_295.sharedMesh.bindposes[0], m12 = val_295.sharedMesh.bindposes[0], m22 = val_295.sharedMesh.bindposes[0], m32 = val_295.sharedMesh.bindposes[0], m03 = val_295.sharedMesh.bindposes[0], m13 = val_295.sharedMesh.bindposes[0], m23 = val_295.sharedMesh.bindposes[0], m33 = val_295.sharedMesh.bindposes[0]}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_22, m10 = val_22, m20 = val_22, m30 = val_22, m01 = val_23, m11 = val_23, m21 = val_23, m31 = val_23, m02 = val_20, m12 = val_20, m22 = val_20, m32 = val_20, m03 = val_21, m13 = val_21, m23 = val_21, m33 = val_21});
            null.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_27, m10 = val_27, m20 = val_27, m30 = val_27, m01 = val_28, m11 = val_28, m21 = val_28, m31 = val_28, m02 = val_25, m12 = val_25, m22 = val_25, m32 = val_25, m03 = val_26, m13 = val_26, m23 = val_26, m33 = val_26});
            if(this.compatibilityMode == true)
            {
                goto label_39;
            }
            
            label_29:
            UnityEngine.Matrix4x4 val_29 = val_15[0x0] + 32.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_31 = val_295.transform.worldToLocalMatrix;
            UnityEngine.Matrix4x4 val_40 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_34, m10 = val_34, m20 = val_34, m30 = val_34, m01 = val_35, m11 = val_35, m21 = val_35, m31 = val_35, m02 = val_32, m12 = val_32, m22 = val_32, m32 = val_32, m03 = val_33, m13 = val_33, m23 = val_33, m33 = val_33}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_38, m10 = val_38, m20 = val_38, m30 = val_38, m01 = val_39, m11 = val_39, m21 = val_39, m31 = val_39, m02 = val_36, m12 = val_36, m22 = val_36, m32 = val_36, m03 = val_37, m13 = val_37, m23 = val_37, m33 = val_37});
            null.Add(item:  new UnityEngine.Matrix4x4() {m00 = val_43, m10 = val_43, m20 = val_43, m30 = val_43, m01 = val_44, m11 = val_44, m21 = val_44, m31 = val_44, m02 = val_41, m12 = val_41, m22 = val_41, m32 = val_41, m03 = val_42, m13 = val_42, m23 = val_42, m33 = val_42});
            label_39:
            label_26:
            if(1 < val_15.Length)
            {
                goto label_48;
            }
            
            val_294 = val_294;
            UnityEngine.Mesh val_45 = val_295.sharedMesh;
            UnityEngine.Matrix4x4 val_47 = val_295.transform.localToWorldMatrix;
            null.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            val_293 = val_293;
            if((val_14.ContainsKey(key:  val_295.sharedMaterials[0])) == false)
            {
                goto label_57;
            }
            
            label_173:
            int val_56 = MTAssets.SkinnedMeshCombiner.不下不丏三上万万丗.丙丏丁丆丈丗丝丘丏(不与丌丏不丘不丛丁:  mesh, 东专丅丄丐丐丗丟丅:  0).vertexCount;
            SkinnedMeshCombiner.丒丕丘丕丗丏业丐世 val_57 = new SkinnedMeshCombiner.丒丕丘丕丗丏业丐世();
            UnityEngine.Material val_295 = val_295.sharedMaterials[0];
            if(val_57 == 0)
            {
                goto label_62;
            }
            
            val_296 = val_57;
            mem[1152921541488720560] = val_295;
            goto label_63;
            label_57:
            UnityEngine.Material val_296 = val_295.sharedMaterials[0];
            new SkinnedMeshCombiner.丞丛丒丒丅丈丙三上() = new SkinnedMeshCombiner.丞丛丒丒丅丈丙三上();
            val_14.Add(key:  val_296, value:  new SkinnedMeshCombiner.丞丛丒丒丅丈丙三上());
            UnityEngine.Vector2Int val_61 = UnityEngine.Vector2Int.zero;
            if(val_296.mainTexture == 0)
            {
                    DiscreteVector2 val_64 = new DiscreteVector2(三丟东丕丄丄下下丑:  64, 丒丒丄丁且丄丆丂丌:  64);
            }
            
            if(val_296.mainTexture != 0)
            {
                    DiscreteVector2 val_69 = new DiscreteVector2(三丟东丕丄丄下下丑:  val_296.mainTexture, 丒丒丄丁且丄丆丂丌:  val_296.mainTexture);
            }
            
            丞丛丒丒丅丈丙三上 val_70 = val_14.Item[val_296];
            mem2[0] = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.mainTexturePropertyToFind, 一丙丒三与丒丘丏丘:  val_69._x.GetHashCode() + (this.丏丐丌世丏不与丝世() << 1), 丂下丌丌丛丑丝世丈:   + (this.丏丐丌世丏不与丝世() << 1), 丐且丕上万丌丁丕万:  0, 丒专丒丝与三丈世丗:  true);
            val_297 = val_14;
            if(this.allInOneParams.metallicMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_77 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_78 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_80 = val_14.Item[val_296];
                val_77.丈丗丅丛东丞东丄丛 = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.metallicMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_78.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_80.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  1, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.specularMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_83 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_84 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_86 = val_14.Item[val_296];
                mem2[0] = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.specularMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_84.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_86.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  2, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.normalMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_89 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_90 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_92 = val_14.Item[val_296];
                mem2[0] = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.normalMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_90.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_92.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  3, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.normalMap2Support != false)
            {
                    丞丛丒丒丅丈丙三上 val_95 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_96 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_98 = val_14.Item[val_296];
                mem2[0] = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.normalMap2PropertyFind, 一丙丒三与丒丘丏丘:  val_96.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_98.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  3, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.heightMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_101 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_102 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_104 = val_14.Item[val_296];
                val_101.丛丘丏丟业丕丙且专 = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.heightMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_102.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_104.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  4, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.occlusionMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_107 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_108 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_110 = val_14.Item[val_296];
                val_107.东不且与世丆丁丌东 = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.occlusionMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_108.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_110.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  5, 丒专丒丝与三丈世丗:  true);
                val_297 = val_14;
            }
            
            if(this.allInOneParams == null)
            {
                    val_297 = val_14;
            }
            
            if(this.allInOneParams.detailAlbedoMapSupport != false)
            {
                    丞丛丒丒丅丈丙三上 val_113 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_114 = val_14.Item[val_296];
                丞丛丒丒丅丈丙三上 val_116 = val_14.Item[val_296];
                val_113.下丅一丞丗丝丐丘丏 = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.detailMapPropertyToFind, 一丙丒三与丒丘丏丘:  val_114.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_116.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  6, 丒专丒丝与三丈世丗:  true);
            }
            
            if(this.allInOneParams.detailMaskSupport == false)
            {
                goto label_173;
            }
            
            丞丛丒丒丅丈丙三上 val_119 = val_14.Item[val_296];
            丞丛丒丒丅丈丙三上 val_120 = val_14.Item[val_296];
            丞丛丒丒丅丈丙三上 val_122 = val_14.Item[val_296];
            val_119.丌丐一丒丟丑丛专丝 = this.丅丗丕业下万丂丄丛(丒丗丐丌丘东丑不不:  val_296, 丏且不丏世专世丘丂:  this.allInOneParams.detailMaskPropertyToFind, 一丙丒三与丒丘丏丘:  val_120.丒丕世丏丆丗三专丑.width, 丂下丌丌丛丑丝世丈:  val_122.丒丕世丏丆丗三专丑.height, 丐且丕上万丌丁丕万:  7, 丒专丒丝与三丈世丗:  true);
            goto label_173;
            label_62:
            mem[16] = val_295;
            val_296 = 16;
            label_63:
            if(val_296.mainTexture == 0)
            {
                    DiscreteVector2 val_127 = new DiscreteVector2(三丟东丕丄丄下下丑:  64, 丒丒丄丁且丄丆丂丌:  64);
                mem[1152921541488720568] = val_127._x;
            }
            
            val_298 = val_57;
            if(mem[16].mainTexture != 0)
            {
                    DiscreteVector2 val_132 = new DiscreteVector2(三丟东丕丄丄下下丑:  mem[16].mainTexture, 丒丒丄丁且丄丆丂丌:  mem[16].mainTexture);
                val_298 = val_57;
                mem[1152921541488720568] = val_132._x;
                val_293 = val_293;
            }
            
            mem[1152921541488720584] = 0;
            val_291 = val_291;
            mem[1152921541488720592] = new UnityEngine.Vector2[0];
            val_299 = val_57;
            mem[1152921541488720576] = val_14.Item[val_295.sharedMaterials[0]];
            if(null == 0)
            {
                    val_299 = val_57;
            }
            
            null.Add(item:  val_57);
            int val_136 = null.Count;
            int val_138 = val_14.Keys.Count;
            UnityEngine.Vector2[] val_141 = MTAssets.SkinnedMeshCombiner.不下不丏三上万万丗.丙丏丁丆丈丗丝丘丏(不与丌丏不丘不丛丁:  mesh, 东专丅丄丐丐丗丟丅:  0).uv;
            UnityEngine.Material val_298 = 0;
            val_298 = val_296 + val_298;
            val_295 = val_295;
            label_24:
            if(1 < val_295.sharedMesh.subMeshCount)
            {
                goto label_26;
            }
            
            if(1 < (val_6 + 24))
            {
                goto label_205;
            }
            
            label_22:
            new UnityEngine.Mesh() = new UnityEngine.Mesh();
            if((val_8.丏三丈丒下专丞万丂(不一且丟丁与丐世丞:  val_293)) > 50000)
            {
                    new UnityEngine.Mesh().indexFormat = 1;
            }
            else
            {
                    new UnityEngine.Mesh().indexFormat = 0;
            }
            
            new UnityEngine.Mesh().name = "Combined Meshes (All In One)";
            new UnityEngine.Mesh().CombineMeshes(combine:  null.ToArray(), mergeSubMeshes:  true, useMatrices:  true);
            new UnityEngine.Mesh().RecalculateBounds();
            new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  this.nameOfThisMerge);
            this.resultMergeGameObject = new UnityEngine.GameObject();
            new UnityEngine.GameObject().transform.SetParent(p:  this.gameObject.transform);
            val_292 = this.resultMergeGameObject.AddComponent<UnityEngine.SkinnedMeshRenderer>();
            val_292.sharedMesh = new UnityEngine.Mesh();
            val_292.bones = val_11.ToArray();
            val_292.sharedMesh.bindposes = null.ToArray();
            val_292.rootBone = val_6 + 32.rootBone;
            UnityEngine.Material[] val_155 = new UnityEngine.Material[1];
            val_289 = this.丞丛丛下丛丅东专三(丞一与丆丘丏世丏丕:  this.allInOneParams.materialToUse, 丁丗下丏丛东丙业丆:  true, 丈业丆丄丟专丛丏丌:  true);
            val_155[0] = val_289;
            val_292.sharedMaterials = val_155;
            val_292.sharedMaterials[0].name = "Combined Materials (All In One)";
            丘上不丂丒丟丐东丕 val_160 = this.丁丄丙丙丗三丗丏一(丅丂东丛丕丆丗丅丐:  val_14, 东丈七丑丅丛且且丄:  this.专丒丈丒丝丑丐万丝(), 万丛与丘世万丗丂东:  this.丝丌与业丟丅上丝世(), 丒专丒丝与三丈世丗:  true);
            UnityEngine.Vector2[] val_162 = val_292.sharedMesh.uv;
            if(val_162.Length == 0)
            {
                goto label_240;
            }
            
            UnityEngine.Vector2[] val_164 = val_292.sharedMesh.uv;
            if(val_292.sharedMesh.vertexCount != val_164.Length)
            {
                goto label_246;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_167 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            List.Enumerator<T> val_168 = null.GetEnumerator();
            val_300 = 1152921541487309600;
            goto label_248;
            label_240:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "It was not possible to create a UV map for the combined mesh. Originally, this character\'s meshes do not have a UV mapping. Create a UV mapping for this character or try using a blending method that does not work with UV mapping, such as One Mesh Per Material.", 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_246:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "It was not possible to create a new UV map for the combianda mesh. The amount of vertices in the original UV map is different from the amount of vertices that the original meshes have, that is, not all vertices of this character are in the UV map. Make sure that all the vertices of this character are on the UV map or try using a blending method that does not work with UV mapping, such as One Mesh Per Material.", 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_344:
            val_301 = 0;
            goto label_251;
            label_260:
            var val_300 = val_292.sharedMesh;
            val_300 = val_301 + val_300;
            val_301 = 1;
            typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_20 = val_300.uv[(long)val_300];
            typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_24 = val_300.uv[(long)val_300];
            label_251:
            if(val_301 < (mem[val_173[(long)(int)((val_301 + val_172))][0] + 24]))
            {
                goto label_260;
            }
            
            val_302 = 0;
            goto label_261;
            label_277:
            val_303 = val_160;
            val_304 = typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_20;
            typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_20 = -val_304;
            val_305 = typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_24;
            if(val_305 < 0)
            {
                    val_306 = val_160;
                val_304 = typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_24;
                val_305 = -val_304;
                typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_24 = val_305;
            }
            
            val_302 = 1;
            label_261:
            if(val_302 < 28563616)
            {
                goto label_277;
            }
            
            UnityEngine.Vector2 val_174 = UnityEngine.Vector2.zero;
            val_308 = 0;
            goto label_280;
            label_288:
            val_304 = UnityEngine.Mathf.Max(a:  typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_20, b:  val_174.x);
            UnityEngine.Vector2 val_177 = new UnityEngine.Vector2(x:  val_304, y:  UnityEngine.Mathf.Max(a:  typeof(SkinnedMeshCombiner.丘上不丂丒丟丐东丕).__il2cppRuntimeField_24, b:  val_174.y));
            val_308 = 1;
            label_280:
            if(val_308 < 28563616)
            {
                goto label_288;
            }
            
            string val_178 = val_170.丐丏七丌丕丗业且上() + 24;
            float val_303 = (float)val_178.丙东专丂世丈丏丁丂();
            val_303 = val_303 / (float)mem[16];
            float val_180 = (float)val_178 / ((float)val_58[0x0][0] + 16);
            float val_304 = 0.5f;
            val_180 = S13 - val_180;
            val_304 = (S13 - val_303) * val_304;
            val_180 = val_180 * val_304;
            UnityEngine.Vector2 val_182 = new UnityEngine.Vector2(x:  val_304, y:  val_180);
            int val_183 = val_160.与丈丑万丕世世丑业(与万丆丛丒万丝丙丑:  val_58[0x0][0] + 16 + 16);
            val_309 = 0;
            goto label_295;
            label_343:
            UnityEngine.Vector2 val_184 = UnityEngine.Vector2.zero;
            val_304 = val_184.x;
            val_311 = val_184.y;
            if(val_177.x <= S13)
            {
                    float val_187 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32.x;
                var val_189 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                val_312 = val_187;
                var val_190 = (val_160 + 88) + 0;
                val_313 = mem[(val_160 + 88 + 0) + 32];
                val_313 = (val_160 + 88 + 0) + 32;
                val_304 = UnityEngine.Mathf.Lerp(a:  val_187, b:  val_312, t:  UnityEngine.Mathf.Lerp(a:  val_182.x, b:  S13 - val_182.x, t:  val_313));
            }
            
            if(val_177.y <= S13)
            {
                    var val_195 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                var val_197 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                val_312 = val_177.y;
                var val_198 = (val_160 + 88) + 0;
                val_313 = mem[(val_160 + 88 + 0) + 36];
                val_313 = (val_160 + 88 + 0) + 36;
                val_311 = UnityEngine.Mathf.Lerp(a:  val_177.y, b:  val_312, t:  UnityEngine.Mathf.Lerp(a:  val_182.y, b:  S13 - val_182.y, t:  val_313));
            }
            
            if(val_177.x > S13)
            {
                    float val_204 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32.x;
                var val_206 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                val_312 = val_204;
                var val_207 = (val_160 + 88) + 0;
                val_313 = mem[(val_160 + 88 + 0) + 32];
                val_313 = (val_160 + 88 + 0) + 32;
                val_304 = UnityEngine.Mathf.Lerp(a:  val_204, b:  val_312, t:  UnityEngine.Mathf.Lerp(a:  val_182.x, b:  S13 - val_182.x, t:  val_313 / val_177.x));
            }
            
            if(val_177.y > S13)
            {
                    var val_213 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                var val_215 = ((val_160 + 88) + (((long)(int)(val_183)) << 4)) + 32;
                val_312 = val_177.y;
                var val_216 = (val_160 + 88) + 0;
                val_313 = mem[(val_160 + 88 + 0) + 36];
                val_313 = (val_160 + 88 + 0) + 36;
                val_311 = UnityEngine.Mathf.Lerp(a:  val_177.y, b:  val_312, t:  UnityEngine.Mathf.Lerp(a:  val_182.y, b:  S13 - val_182.y, t:  val_313 / val_177.y));
            }
            
            null.Add(item:  new UnityEngine.Vector2() {x = val_304, y = val_311});
            val_309 = 1;
            label_295:
            val_300 = 1152921541487309600;
            if(val_309 < (val_160 + 88 + 24))
            {
                goto label_343;
            }
            
            label_248:
            if(((-1773175872) & 1) != 0)
            {
                goto label_344;
            }
            
            val_314 = null;
            val_289 = val_160;
            val_315 = 0;
            val_316 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_629;
            }
            
            if( == 0)
            {
                goto label_633;
            }
            
            if(3111 != 3111)
            {
                goto label_631;
            }
            
            goto label_633;
            label_629:
            if( == 0)
            {
                goto label_633;
            }
            
            label_631:
            label_633:
            UnityEngine.Vector2[] val_222 = val_292.sharedMesh.uv;
            if((System.Linq.Enumerable.Count<UnityEngine.Vector2>(source:  null)) != val_222.Length)
            {
                goto label_637;
            }
            
            val_292.sharedMesh.uv = null.ToArray();
            val_291 = this.allInOneParams;
            this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.mainTexturePropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 16);
            if(this.allInOneParams.metallicMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.metallicMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 24);
            }
            
            if(this.allInOneParams.specularMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.specularMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 32);
            }
            
            if(this.allInOneParams.normalMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.normalMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 40);
            }
            
            if(this.allInOneParams.normalMap2Support != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.normalMap2PropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 48);
            }
            
            if(this.allInOneParams.heightMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.heightMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 56);
            }
            
            if(this.allInOneParams.occlusionMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.occlusionMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 64);
            }
            
            if(this.allInOneParams.detailAlbedoMapSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.detailMapPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 72);
            }
            
            if(this.allInOneParams.detailMaskSupport != false)
            {
                    val_291 = this.allInOneParams;
                this.丅丑且丑丗丅东丆丘(丞一与丆丘丏世丏丕:  val_292.sharedMaterials[0], 三丄专丅与且世七专:  this.allInOneParams.detailMaskPropertyToInsert, 丄上业丛丌丂丝丝丒:  val_160 + 80);
            }
            
            if(this.highlightUvVertices == false)
            {
                goto label_694;
            }
            
            val_291 = 0;
            goto label_695;
            label_709:
            val_319 = 0;
            if(val_291 >= val_236.Length)
            {
                    val_319 = 0;
            }
            
            val_304 = val_292.sharedMesh.uv[0];
            UnityEngine.Color val_239 = UnityEngine.Color.yellow;
            float val_315 = 1.152922E+18f;
            float val_316 = (float)val_160 + 16;
            val_315 = val_304 * val_315;
            val_316 = val_292.sharedMesh.uv[0] * val_316;
            3111.SetPixel(x:  (int)val_315, y:  (int)val_316, color:  new UnityEngine.Color() {r = val_239.r, g = val_239.g, b = val_239.b, a = val_239.a});
            val_314 = null;
            val_289 = val_160;
            val_291 = 1;
            label_695:
            UnityEngine.Vector2[] val_241 = val_292.sharedMesh.uv;
            if(val_291 < val_241.Length)
            {
                goto label_709;
            }
            
            val_160 + 16.Apply();
            label_694:
            UnityEngine.GameObject val_243 = this.gameObject;
            if((this.resultMergeGameObject.AddComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>()) == null)
            {
                goto label_712;
            }
            
            val_242.rootGameObject = val_243;
            val_242.mergeMethodUsed = 1;
            goto label_713;
            label_637:
            object[] val_244 = new object[5];
            val_290 = val_244;
            val_290[0] = "Could not proceed with the merge. For some reason, the new UV mesh generated, does not match the UV mesh of this character... So the merging was interrupted, to avoid mapping errors. Please contact MT Assets support at mtassets@windsoft.xyz.\n\nThe new UV map have ";
            val_291 = 1152921504622075904;
            val_290[1] = null.Count;
            val_290[2] = " vertices and the original UV map have ";
            UnityEngine.Vector2[] val_247 = val_292.sharedMesh.uv;
            val_290[3] = val_247.Length;
            val_290[4] = " vertices.";
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  +val_244, 世丗丕东丄三丕丂丒:  1);
            this.上丁丙丅丝上丟丁丑(世丝丒丙下东丗丙上:  0);
            return;
            label_712:
            mem[24] = val_243;
            mem[32] = 1;
            label_713:
            val_242.sourceMeshes = val_293;
            this.resultMergeOriginalGameObjects = val_292;
            if((val_6 + 24) >= 1)
            {
                    do
            {
                UnityEngine.SkinnedMeshRenderer[] val_317 = val_293;
                val_291 = 0;
                val_317 = val_317 + 0;
                (val_6 + 0) + 32.gameObject.SetActive(value:  false);
            }
            while((val_291 + 1) < (val_6 + 24));
            
            }
            
            val_290.cullingMode = val_291;
            System.DateTime val_251 = System.DateTime.Now;
            if(this.saveDataInAssets == false)
            {
                goto label_789;
            }
            
            UnityEngine.Mesh val_252 = val_292.sharedMesh;
            val_290 = this.gameObject;
            string val_254 = val_290.name;
            if(this.saveDataInAssets != false)
            {
                    val_290 = this.gameObject;
                string val_257 = val_290.name + " (MainTexture)";
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.metallicMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_260 = val_290.name + " (MetallicMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.specularMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_263 = val_290.name + " (SpecularMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.normalMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_266 = val_290.name + " (NormalMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.normalMap2Support != false)
            {
                    val_290 = this.gameObject;
                string val_269 = val_290.name + " (NormalMap2x)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.heightMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_272 = val_290.name + " (HeightMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.occlusionMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_275 = val_290.name + " (OcclusionMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.detailAlbedoMapSupport != false)
            {
                    val_290 = this.gameObject;
                string val_278 = val_290.name + " (DetailMap)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    val_290 = this.allInOneParams;
                if(this.allInOneParams.detailMaskSupport != false)
            {
                    val_290 = this.gameObject;
                string val_281 = val_290.name + " (DetailMask)";
            }
            
                val_314 = null;
                if(this.saveDataInAssets != false)
            {
                    UnityEngine.Material[] val_282 = val_292.sharedMaterials;
                val_290 = this.gameObject;
                val_314 = null;
                string val_284 = val_290.name;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            label_789:
            if(this.savePrefabOfMerge != false)
            {
                    UnityEngine.GameObject val_285 = this.gameObject;
            }
            
            int val_286 = null.Count;
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "The merging of the meshes was completed successfully! The name of this merge is \""("The merging of the meshes was completed successfully! The name of this merge is \"") + this.nameOfThisMerge + "\"!"("\"!"), 世丗丕东丄三丕丂丒:  3);
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.onCombineMeshs == null)
            {
                    return;
            }
            
            this.onCombineMeshs.Invoke();
        }
        private void 丙丌七下万丁丘丂业()
        {
        
        }
        private void 丞丅丝业丁丈丙丟丕(bool 丕专丌丙万丆不丑丙, bool 丌丛丘业丑且丌不丝, bool 万三丅业丐三丘东上)
        {
            if(this.resultMergeGameObject == 0)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "Currently the character\'s meshes are not merged. To undo a merge, perform one first.", 世丗丕东丄三丕丂丒:  4);
                return;
            }
            
            if((this.resultMergeOriginalGameObjects != null) && (this.resultMergeOriginalGameObjects.Length >= 1))
            {
                    do
            {
                UnityEngine.GameObject val_6 = this.resultMergeOriginalGameObjects[0];
                if(val_6 != 0)
            {
                    val_6.SetActive(value:  true);
            }
            
            }
            while((0 + 1) < this.resultMergeOriginalGameObjects.Length);
            
            }
            
            val_6.且丐丐七世丌丒丆丄(下丐三丆丝与不丗丕:  this.resultMergeGameObject);
            this.resultMergeOriginalGameObjects = 0;
            this.resultMergeTextStats = "";
            this.resultMergeAssetsSaved.Clear();
            if(万三丅业丐三丘东上 == false)
            {
                goto label_13;
            }
            
            if(丕专丌丙万丆不丑丙 == true)
            {
                goto label_14;
            }
            
            label_19:
            if(丌丛丘业丑且丌不丝 == false)
            {
                goto label_23;
            }
            
            label_22:
            UnityEngine.AsyncOperation val_4 = UnityEngine.Resources.UnloadUnusedAssets();
            label_23:
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.onUndoCombineMeshs == null)
            {
                    return;
            }
            
            this.onUndoCombineMeshs.Invoke();
            return;
            label_13:
            this.resultMergeLogs.Clear();
            if(丕专丌丙万丆不丑丙 == false)
            {
                goto label_19;
            }
            
            label_14:
            System.GC.Collect();
            if(丌丛丘业丑且丌不丝 == true)
            {
                goto label_22;
            }
            
            goto label_23;
        }
        private void 东丐世丛丐万且丝万(string 三丏丑不业丏不丂丈, MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丒丈丟东丆丘丅丘上 世丗丕东丄三丕丂丒)
        {
            if(this.launchConsoleLogs == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(世丗丕东丄三丕丂丒 < 3)
            {
                    UnityEngine.Debug.LogError(message:  三丏丑不业丏不丂丈);
                return;
            }
            
            if(世丗丕东丄三丕丂丒 != 3)
            {
                    if(世丗丕东丄三丕丂丒 != 4)
            {
                    return;
            }
            
                UnityEngine.Debug.LogWarning(message:  三丏丑不业丏不丂丈);
                return;
            }
            
            UnityEngine.Debug.Log(message:  三丏丑不业丏不丂丈);
        }
        private void 三丙专丁上世丁丂丁()
        {
            JustMaterialColorsParams val_2;
            var val_3;
            AllInOneParams val_4;
            string val_5;
            var val_6;
            var val_7;
            string val_8;
            var val_9;
            val_2 = this;
            if(this.savePrefabOfMerge != false)
            {
                    this.saveDataInAssets = true;
            }
            
            if((this.allInOneParams.specularMapSupport != false) && (this.allInOneParams.metallicMapSupport != false))
            {
                    this.allInOneParams.metallicMapSupport = false;
                this.allInOneParams.specularMapSupport = false;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.nameOfThisMerge)) != false)
            {
                    this.nameOfThisMerge = "Combined Meshes";
            }
            
            val_3 = null;
            val_3 = null;
            if(MTAssets.SkinnedMeshCombiner.CurrentRP.haveAnotherSrpPackages != false)
            {
                    val_4 = this.allInOneParams;
                if(this.allInOneParams.useDefaultMainTextureProperty != false)
            {
                    val_5 = "_BaseMap";
                this.allInOneParams.mainTexturePropertyToFind = val_5;
                val_4 = this.allInOneParams;
                if(val_4 == null)
            {
                    val_5 = "_BaseMap";
            }
            
                this.allInOneParams.mainTexturePropertyToInsert = val_5;
            }
            
            }
            
            val_6 = null;
            val_6 = null;
            if(MTAssets.SkinnedMeshCombiner.CurrentRP.haveAnotherSrpPackages != false)
            {
                    val_4 = this.justMaterialColorsParams;
                if(this.justMaterialColorsParams.useDefaultColorProperty != false)
            {
                    this.justMaterialColorsParams.mainTexturePropertyToInsert = "_BaseMap";
                val_4 = this.justMaterialColorsParams;
                this.justMaterialColorsParams.colorPropertyToFind = "_BaseColor";
            }
            
            }
            
            val_7 = null;
            val_7 = null;
            if(MTAssets.SkinnedMeshCombiner.CurrentRP.haveAnotherSrpPackages != true)
            {
                    val_4 = this.allInOneParams;
                if(this.allInOneParams.useDefaultMainTextureProperty != false)
            {
                    val_8 = "_MainTex";
                this.allInOneParams.mainTexturePropertyToFind = val_8;
                val_4 = this.allInOneParams;
                if(val_4 == null)
            {
                    val_8 = "_MainTex";
            }
            
                this.allInOneParams.mainTexturePropertyToInsert = val_8;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            if(MTAssets.SkinnedMeshCombiner.CurrentRP.haveAnotherSrpPackages == true)
            {
                    return;
            }
            
            if(this.justMaterialColorsParams.useDefaultColorProperty == false)
            {
                    return;
            }
            
            this.justMaterialColorsParams.mainTexturePropertyToInsert = "_MainTex";
            val_2 = this.justMaterialColorsParams;
            this.justMaterialColorsParams.colorPropertyToFind = "_Color";
        }
        private UnityEngine.GameObject[] 丟专且丏丌丅万下与(bool 丄一七丈丌专丘丆丗, bool 七与丄东业业业丘丞)
        {
            var val_12;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Object val_28;
            var val_29;
            System.Collections.Generic.List<T> val_30;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = null;
            val_24 = val_1;
            val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            if(mem[1152921541491552560] == 3)
            {
                goto label_1;
            }
            
            val_25 = 1152921541480934496;
            val_23 = 1152921519068975536;
            val_26 = this.gameObject.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>(includeInactive:  (mem[1152921541491552601] == true) ? 1 : 0);
            val_27 = 0;
            goto label_3;
            label_13:
            T val_22 = val_26[0];
            val_28 = val_22.gameObject.GetComponent<MTAssets.SkinnedMeshCombiner.CombinedMeshesManager>();
            if(val_28 == 0)
            {
                    val_1.Add(item:  val_22.gameObject);
            }
            
            val_27 = 1;
            label_3:
            if(val_27 < val_4.Length)
            {
                goto label_13;
            }
            
            label_1:
            if(丄一七丈丌专丘丆丗 != false)
            {
                    if(val_24 != null)
            {
                    return (UnityEngine.GameObject[])val_9.ToArray();
            }
            
                return (UnityEngine.GameObject[])val_9.ToArray();
            }
            
            System.Collections.Generic.List<UnityEngine.GameObject> val_9 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            val_23 = 1152921519068955088;
            val_25 = 1152921519068956112;
            val_26 = 0;
            goto label_17;
            label_39:
            val_28 = mem[1152921541491552616];
            List.Enumerator<T> val_10 = val_28.GetEnumerator();
            val_29 = 0;
            goto label_19;
            label_23:
            val_28 = val_12.丐丏七丌丕丗业且上();
            val_29 = val_29 | (UnityEngine.Object.op_Equality(x:  val_28, y:  val_1.Item[0]));
            label_19:
            if(((-1770012272) & 1) != 0)
            {
                goto label_23;
            }
            
            var val_24 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_24 == 1)
            {
                goto label_28;
            }
            
            var val_23 = 0;
            val_23 = val_23 ^ 0;
            val_24 = val_24 + val_23;
            if(val_29 == false)
            {
                goto label_29;
            }
            
            label_35:
            if(七与丄东业业业丘丞 == false)
            {
                goto label_33;
            }
            
            val_28 = val_1.Item[0];
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "GameObject \"" + val_28.name + "\" was registered to be ignored during the merge, so it was not included in the merge processing.", 世丗丕东丄三丕丂丒:  4);
            goto label_33;
            label_28:
            if(val_29 == true)
            {
                goto label_35;
            }
            
            label_29:
            val_30 = val_9;
            val_28 = val_1.Item[0];
            if(val_30 == 0)
            {
                    val_30 = val_9;
            }
            
            val_9.Add(item:  val_28);
            label_33:
            val_26 = 1;
            label_17:
            if(val_26 < val_1.Count)
            {
                goto label_39;
            }
            
            val_24 = val_9;
            if(val_9 != 0)
            {
                    return (UnityEngine.GameObject[])val_9.ToArray();
            }
            
            val_24 = val_9;
            return (UnityEngine.GameObject[])val_9.ToArray();
        }
        private void 上丁丙丅丝上丟丁丑(System.Exception 世丝丒丙下东丗丙上)
        {
            if(世丝丒丙下东丗丙上 != null)
            {
                    this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "An error occurred while performing this merge. Read on for more details.\n\n" + 世丝丒丙下东丗丙上 + "\n\n" + 世丝丒丙下东丗丙上, 世丗丕东丄三丕丂丒:  1);
            }
            
            this.丞丅丝业丁丈丙丟丕(丕专丌丙万丆不丑丙:  true, 丌丛丘业丑且丌不丝:  true, 万三丅业丐三丘东上:  true);
        }
        private void 丞丌三丄世与三与东(string 丏不丄丑丝丁丘万不, string 丄丙下丝丛丒七丂丘, string 丌丈与丕专上一丈七)
        {
        
        }
        private void 丕丁上丙丆丕专丞丅()
        {
        
        }
        private void 丝丏丕丆丕丐下丆丒(string 丄丙下丝丛丒七丂丘, bool 丛与丙丒丒下丌丟且, float 上丕丈丞丌丘丅不与)
        {
        
        }
        private void 丆丌上丑丘东下丙丐(string 下七上不三丂一丂丑, UnityEngine.Object 与丒东与不东丒丕东, string 丝丈丝丆世丁丄专丂, string 丝上丈下丌下丗丟丛)
        {
        
        }
        private void 丒万下丄丙业七三丂(string 下七上不三丂一丂丑, string 丟丈一下东业一丝丆, UnityEngine.GameObject 专丟丆且丈丝业丂万)
        {
        
        }
        private void 丆丙万丏一与不丛丏(string 丘一丕丞丐丛丟丙世, string 下丛不丁丝丑丈丌且, int 丄丅丐丛丒东丛丌丆, System.DateTime 七丌丄丐丈不丛不世, System.DateTime 业世丕专与丞上三且, int 且丗三世三丏专丒丘, int 丂丙丂上丕丘丑丌丅, int 丑丗专专丁且丒丕丑, int 一且丌丙且丄丆丗与, int 七七丞丒丆丙上丕丌, int 丑丐丐丝丙世专丂丐)
        {
        
        }
        private UnityEngine.SkinnedMeshRenderer[] 丄丒丁丝下丆丒东丁(UnityEngine.GameObject[] 世东专丂丙丂且丕七)
        {
            var val_41;
            var val_42;
            var val_43;
            string val_45;
            string val_46;
            var val_47;
            var val_48;
            System.Collections.Generic.List<T> val_49;
            var val_50;
            var val_51;
            System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> val_1 = new System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer>();
            val_42 = 0;
            goto label_17;
            label_69:
            val_41 = 0;
            UnityEngine.SkinnedMeshRenderer val_2 = 世东专丂丙丂且丕七[val_41].GetComponent<UnityEngine.SkinnedMeshRenderer>();
            if(val_2 == 0)
            {
                goto label_67;
            }
            
            if(val_2 == null)
            {
                goto label_7;
            }
            
            val_43 = val_2;
            if(val_2.enabled == false)
            {
                goto label_8;
            }
            
            label_15:
            bool val_6 = UnityEngine.Object.op_Equality(x:  val_2.sharedMesh, y:  0);
            if(val_2 == null)
            {
                goto label_11;
            }
            
            if(val_6 == false)
            {
                goto label_12;
            }
            
            label_18:
            string val_8 = val_2.gameObject.name;
            val_45 = "The mesh present in GameObject ";
            val_46 = " was ignored during the merge process. Reason: The mesh is null.";
            goto label_65;
            label_7:
            val_43 = 0;
            if(0.enabled == true)
            {
                goto label_15;
            }
            
            label_8:
            val_45 = "The mesh present in GameObject ";
            val_46 = " was ignored during the merge process. Reason: The Skinned Mesh Renderer is disabled";
            label_65:
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  val_45 + val_2.gameObject.name + val_46, 世丗丕东丄三丕丂丒:  3);
            label_67:
            val_42 = 1;
            goto label_17;
            label_11:
            if(val_6 == true)
            {
                goto label_18;
            }
            
            label_12:
            if((val_2.sharedMesh.blendShapeCount < 1) || (this.ignoreBlendshapes == false))
            {
                goto label_21;
            }
            
            string val_16 = val_2.gameObject.name;
            goto label_65;
            label_21:
            if(val_2 == null)
            {
                goto label_25;
            }
            
            if(val_43.sharedMaterials == null)
            {
                goto label_26;
            }
            
            label_45:
            UnityEngine.Material[] val_18 = val_43.sharedMaterials;
            if(val_2 == null)
            {
                goto label_28;
            }
            
            if(val_18.Length == 0)
            {
                goto label_29;
            }
            
            label_48:
            UnityEngine.Material[] val_19 = val_43.sharedMaterials;
            if(val_2.sharedMesh.subMeshCount != val_19.Length)
            {
                goto label_34;
            }
            
            val_47 = 0;
            val_48 = 0;
            goto label_35;
            label_40:
            val_48 = val_48 | (UnityEngine.Object.op_Equality(x:  val_43.sharedMaterials[0], y:  0));
            val_47 = 1;
            label_35:
            if(val_47 < val_22.Length)
            {
                goto label_40;
            }
            
            if(val_48 == false)
            {
                goto label_41;
            }
            
            string val_25 = val_2.gameObject.name;
            goto label_65;
            label_25:
            if(val_43.sharedMaterials != null)
            {
                goto label_45;
            }
            
            label_26:
            string val_28 = val_2.gameObject.name;
            goto label_65;
            label_28:
            if(val_18.Length != 0)
            {
                goto label_48;
            }
            
            label_29:
            string val_30 = val_2.gameObject.name;
            goto label_65;
            label_34:
            string val_32 = val_2.gameObject.name;
            goto label_65;
            label_41:
            val_49 = val_1;
            if((this.mergeMethod != 1) || (this.allInOneParams.mergeTiledTextures == true))
            {
                goto label_62;
            }
            
            val_50 = 0;
            val_51 = 0;
            goto label_58;
            label_61:
            UnityEngine.Vector2 val_43 = val_2.sharedMesh.uv[0];
            UnityEngine.Vector2 val_44 = val_2.sharedMesh.uv[0];
            val_51 = 1;
            var val_35 = (val_43 > 1f) ? 1 : 0;
            val_35 = val_35 | ((val_44 > 1f) ? 1 : 0);
            var val_37 = (val_43 < 0) ? 1 : 0;
            val_35 = val_50 | val_35;
            val_37 = val_37 | ((val_44 < 0) ? 1 : 0);
            val_50 = val_37 | val_35;
            label_58:
            if(val_51 < val_34.Length)
            {
                goto label_61;
            }
            
            val_49 = val_1;
            if((val_50 & 1) == 0)
            {
                goto label_62;
            }
            
            string val_40 = val_2.transform.name;
            goto label_65;
            label_62:
            val_1.Add(item:  val_2);
            goto label_67;
            label_17:
            if(val_42 < 世东专丂丙丂且丕七.Length)
            {
                goto label_69;
            }
            
            if(val_1 != null)
            {
                    return val_1.ToArray();
            }
            
            return val_1.ToArray();
        }
        private bool 丘丐丅丗丟世三丙丌(UnityEngine.SkinnedMeshRenderer[] 不一且丟丁与丐世丞, bool 七与丄东业业业丘丞)
        {
            var val_4;
            if(不一且丟丁与丐世丞.Length < 1)
            {
                goto label_4;
            }
            
            label_10:
            if(不一且丟丁与丐世丞[0].rootBone != 不一且丟丁与丐世丞[0].rootBone)
            {
                goto label_9;
            }
            
            if((0 + 1) < 不一且丟丁与丐世丞.Length)
            {
                goto label_10;
            }
            
            label_4:
            val_4 = 0;
            return (bool)val_4;
            label_9:
            if(七与丄东业业业丘丞 != false)
            {
                    val_4 = 1;
                this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  "Different root bones were found in your character\'s meshes. This can cause blending problems and cause your character not to be as desired. If you still want to combine the meshes, disable the \"Only Equal Root Bones\" option, but be aware that the mesh resulting from the merge may not come out as expected, or contain artifacts or animation problems.", 世丗丕东丄三丕丂丒:  1);
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        private int 丏三丈丒下专丞万丂(UnityEngine.SkinnedMeshRenderer[] 不一且丟丁与丐世丞)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 0;
            goto label_0;
            label_5:
            val_4 = 不一且丟丁与丐世丞[0].sharedMesh.vertexCount + val_4;
            val_3 = 1;
            label_0:
            if(val_3 < 不一且丟丁与丐世丞.Length)
            {
                goto label_5;
            }
            
            return (int)val_4;
        }
        private void 且丐丐七世丌丒丆丄(UnityEngine.GameObject 下丐三丆丝与不丗丕)
        {
            UnityEngine.Object.Destroy(obj:  下丐三丆丝与不丗丕);
        }
        private UnityEngine.Material 丞丛丛下丛丅东专三(UnityEngine.Material 丞一与丆丘丏世丏丕, bool 丁丗下丏丛东丙业丆, bool 丈业丆丄丟专丛丏丌)
        {
            float val_17;
            float val_18;
            UnityEngine.Material val_2 = new UnityEngine.Material(shader:  丞一与丆丘丏世丏丕.shader);
            if(丁丗下丏丛东丙业丆 != false)
            {
                    val_2.CopyPropertiesFromMaterial(mat:  丞一与丆丘丏世丏丕);
            }
            
            if(丈业丆丄丟专丛丏丌 == false)
            {
                    return val_2;
            }
            
            if((val_2.HasProperty(name:  "_MainTex")) != false)
            {
                    val_2.SetTexture(name:  "_MainTex", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_BaseMap")) != false)
            {
                    val_2.SetTexture(name:  "_BaseMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_MetallicGlossMap")) != false)
            {
                    val_2.SetTexture(name:  "_MetallicGlossMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_SpecGlossMap")) != false)
            {
                    val_2.SetTexture(name:  "_SpecGlossMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_BumpMap")) != false)
            {
                    val_2.SetTexture(name:  "_BumpMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_DetailNormalMap")) != false)
            {
                    val_2.SetTexture(name:  "_DetailNormalMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_ParallaxMap")) != false)
            {
                    val_2.SetTexture(name:  "_ParallaxMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_OcclusionMap")) != false)
            {
                    val_2.SetTexture(name:  "_OcclusionMap", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_DetailMapSupport")) != false)
            {
                    val_2.SetTexture(name:  "_DetailMapSupport", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_DetailMask")) != false)
            {
                    val_2.SetTexture(name:  "_DetailMask", value:  0);
            }
            
            if((val_2.HasProperty(name:  "_Color")) != false)
            {
                    UnityEngine.Color val_14 = UnityEngine.Color.white;
                val_17 = val_14.r;
                val_18 = val_14.b;
                val_2.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_17, g = val_14.g, b = val_18, a = val_14.a});
            }
            
            if((val_2.HasProperty(name:  "_BaseColor")) == false)
            {
                    return val_2;
            }
            
            UnityEngine.Color val_16 = UnityEngine.Color.white;
            val_17 = val_16.r;
            val_18 = val_16.b;
            val_2.SetColor(name:  "_BaseColor", value:  new UnityEngine.Color() {r = val_17, g = val_16.g, b = val_18, a = val_16.a});
            return val_2;
        }
        private MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丐专丁丟丛三丁与丈 丘丏丁丌丙一丅下丞(MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.一丄业丈业一丟丒丆 丐且丕上万丌丁丕万)
        {
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            string val_15;
            var val_16;
            if(丐且丕上万丌丁丕万 <= 7)
            {
                    var val_6 = 106046500 + (丐且丕上万丌丁丕万) << 2;
                val_6 = val_6 + 106046500;
            }
            else
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.red;
                val_10 = val_3.r;
                val_11 = val_3.g;
                val_12 = val_3.b;
                val_13 = val_3.a;
                val_15 = "RED";
                val_16 = ;
                 = new SkinnedMeshCombiner.丐专丁丟丛三丁与丈(丗丕丕丄不三丐万且:  null, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {});
                return (丐专丁丟丛三丁与丈)val_16;
            }
        
        }
        private UnityEngine.Texture2D 丅丗丕业下万丂丄丛(UnityEngine.Material 丒丗丐丌丘东丑不不, string 丏且不丏世专世丘丂, int 一丙丒三与丒丘丏丘, int 丂下丌丌丛丑丝世丈, MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.一丄业丈业一丟丒丆 丐且丕上万丌丁丕万, bool 丒专丒丝与三丈世丗)
        {
            int val_6;
            一丄业丈业一丟丒丆 val_177;
            string val_178;
            UnityEngine.Object val_179;
            var val_180;
            UnityEngine.Color val_181;
            int val_182;
            UnityEngine.Texture2D val_183;
            var val_184;
            string val_185;
            var val_186;
            float val_187;
            float val_188;
            float val_189;
            int val_190;
            int val_191;
            string val_192;
            var val_193;
            var val_194;
            string val_195;
            var val_196;
            var val_197;
            var val_198;
            var val_199;
            var val_200;
            int val_201;
            var val_202;
            var val_203;
            int val_204;
            int val_205;
            var val_206;
            int val_207;
            int val_208;
            int val_209;
            int val_210;
            int val_211;
            val_177 = 丐且丕上万丌丁丕万;
            if(丒专丒丝与三丈世丗 != false)
            {
                    string val_1 = "Copying " + 丏且不丏世专世丘丂;
            }
            
            if(丒丗丐丌丘东丑不不 != null)
            {
                    丒丗丐丌丘东丑不不.EnableKeyword(keyword:  丏且不丏世专世丘丂);
            }
            else
            {
                    0.EnableKeyword(keyword:  丏且不丏世专世丘丂);
            }
            
            val_178 = 0;
            if((丒丗丐丌丘东丑不不.HasProperty(name:  丏且不丏世专世丘丂)) != false)
            {
                    val_178 = 0;
                if((丒丗丐丌丘东丑不不.GetTexture(name:  丏且不丏世专世丘丂)) != 0)
            {
                    val_178 = 丒丗丐丌丘东丑不不.GetTexture(name:  丏且不丏世专世丘丂);
                if((val_178 != null) && (null != null))
            {
                    val_178 = 0;
            }
            
            }
            
            }
            
            if((丒丗丐丌丘东丑不不.HasProperty(name:  丏且不丏世专世丘丂)) == false)
            {
                goto label_13;
            }
            
            val_179 = 0;
            bool val_9 = UnityEngine.Object.op_Equality(x:  丒丗丐丌丘东丑不不.GetTexture(name:  丏且不丏世专世丘丂), y:  val_179);
            if(val_9 == false)
            {
                goto label_17;
            }
            
            label_13:
            丐专丁丟丛三丁与丈 val_10 = val_9.丘丏丁丌丙一丅下丞(丐且丕上万丌丁丕万:  val_177);
            string[] val_11 = new string[7];
            val_11[0] = "It was not possible to find the texture stored in property \"";
            val_11[1] = 丏且不丏世专世丘丂;
            val_11[2] = "\" of material \"";
            val_11[3] = 丒丗丐丌丘东丑不不.name;
            val_11[4] = "\", so this Texture/Map was replaced by a ";
            val_11[5] = val_10.丗丕丕丄不三丐万且;
            val_11[6] = " texture. This can affect how the texture or effect maps (such as Normal Maps, etc.) are displayed in the combined model. This can result in some small differences in the combined mesh when compared to the separate original meshes.";
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  +val_11, 世丗丕东丄三丕丂丒:  4);
            UnityEngine.Texture2D val_14 = null;
            val_178 = val_14;
            val_14 = new UnityEngine.Texture2D(width:  一丙丒三与丒丘丏丘, height:  丂下丌丌丛丑丝世丈);
            int val_15 = 丂下丌丌丛丑丝世丈 * 一丙丒三与丒丘丏丘;
            UnityEngine.Color[] val_16 = new UnityEngine.Color[0];
            val_180 = 0;
            goto label_42;
            label_45:
            val_181 = val_10.丑丞丈丗丄丙丟万丄;
            val_180 = 1;
            val_16[0] = val_181;
            val_16[0] = new UnityEngine.Color();
            val_16[0] = 丏且不丏世专世丘丂;
            val_16[0] = new UnityEngine.Color();
            label_42:
            if(val_180 < val_16.Length)
            {
                goto label_45;
            }
            
            val_179 = 0;
            val_14.SetPixels(x:  0, y:  0, blockWidth:  一丙丒三与丒丘丏丘, blockHeight:  丂下丌丌丛丑丝世丈, colors:  val_16, miplevel:  0);
            val_177 = val_177;
            label_17:
            val_182 = this.丏丐丌世丏不与丝世();
            val_183 = new UnityEngine.Texture2D();
            val_183 = new UnityEngine.Texture2D(width:  val_14.width + (val_182 << 1), height:  val_14.height + (val_182 << 1), textureFormat:  5, mipChain:  false, linear:  false);
            val_184 = 0;
            UnityEngine.Color32[] val_23 = val_14.GetPixels32(miplevel:  0);
            val_185 = mem[1152921541494852280];
            if((val_177 != 3) || ((mem[1152921541494852280] + 248) == 0))
            {
                goto label_51;
            }
            
            val_184 = 0;
            if(val_14.format != 12)
            {
                goto label_51;
            }
            
            val_181 = 1152921504838422528;
            val_186 = 0;
            goto label_52;
            label_61:
            UnityEngine.Color val_25 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_23[0], g = val_23[0], b = val_23[0], a = val_23[0]});
            val_25.g = val_25.g + val_25.g;
            float val_27 = (val_25.a + val_25.a) + (-1f);
            val_187 = val_25.g + (-1f);
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_27, y:  val_187);
            float val_164 = val_28.y;
            float val_165 = val_28.y;
            val_188 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_28.x, y = val_164}, rhs:  new UnityEngine.Vector2() {x = val_28.x, y = val_165});
            float val_30 = UnityEngine.Mathf.Clamp01(value:  val_188);
            val_164 = 1f - val_30;
            if(val_30 >= _TYPE_MAX_)
            {
                    val_189 = val_164;
            }
            
            val_165 = val_189 * 0.5f;
            val_6 = 0;
            float val_33 = (val_27 * 0.5f) + 0.5f;
            float val_34 = (val_187 * 0.5f) + 0.5f;
            float val_35 = val_165 + 0.5f;
            val_184 = 0;
            UnityEngine.Color32 val_36 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            if(val_186 >= val_23.Length)
            {
                    val_184 = 0;
            }
            
            mem2[0] = val_36.r;
            mem[1] = val_36.g;
            mem[2] = val_36.b;
            mem[3] = val_36.a;
            val_186 = 1;
            label_52:
            if(val_186 < val_23.Length)
            {
                goto label_61;
            }
            
            label_51:
            val_190 = val_14.width;
            new UnityEngine.Texture2D().SetPixels32(x:  val_182, y:  val_182, blockWidth:  val_190, blockHeight:  val_14.height, colors:  val_23, miplevel:  0);
            val_191 = public System.Int32 UnityEngine.Texture::get_width();
            if(val_182 <= val_14.width)
            {
                    val_191 = public System.Int32 UnityEngine.Texture::get_height();
                if(val_182 <= val_14.height)
            {
                    new UnityEngine.Texture2D().SetPixels(x:  0, y:  val_182, blockWidth:  val_182, blockHeight:  val_14.height, colors:  val_14.GetPixels(x:  val_14.width - val_182, y:  0, blockWidth:  val_182, blockHeight:  val_14.height, miplevel:  0), miplevel:  0);
                new UnityEngine.Texture2D().SetPixels(x:  val_14.width + val_182, y:  val_182, blockWidth:  val_182, blockHeight:  val_14.height, colors:  val_14.GetPixels(x:  0, y:  0, blockWidth:  val_182, blockHeight:  val_14.height, miplevel:  0), miplevel:  0);
                new UnityEngine.Texture2D().SetPixels(x:  val_182, y:  val_14.height + val_182, blockWidth:  val_14.width, blockHeight:  val_182, colors:  val_14.GetPixels(x:  0, y:  0, blockWidth:  val_14.width, blockHeight:  val_182, miplevel:  0), miplevel:  0);
                new UnityEngine.Texture2D().SetPixels(x:  val_182, y:  0, blockWidth:  val_14.width, blockHeight:  val_182, colors:  val_14.GetPixels(x:  0, y:  val_14.height - val_182, blockWidth:  val_14.width, blockHeight:  val_182, miplevel:  0), miplevel:  0);
                val_190 = new UnityEngine.Texture2D().width;
                new UnityEngine.Texture2D().SetPixels(x:  val_190 - val_182, y:  new UnityEngine.Texture2D().height - val_182, blockWidth:  val_182, blockHeight:  val_182, colors:  val_14.GetPixels(x:  0, y:  0, blockWidth:  val_182, blockHeight:  val_182, miplevel:  0), miplevel:  0);
                new UnityEngine.Texture2D().SetPixels(x:  0, y:  0, blockWidth:  val_182, blockHeight:  val_182, colors:  val_14.GetPixels(x:  val_14.width - val_182, y:  val_14.height - val_182, blockWidth:  val_182, blockHeight:  val_182, miplevel:  0), miplevel:  0);
                new UnityEngine.Texture2D().SetPixels(x:  0, y:  new UnityEngine.Texture2D().height - val_182, blockWidth:  val_182, blockHeight:  val_182, colors:  val_14.GetPixels(x:  val_14.width - val_182, y:  0, blockWidth:  val_182, blockHeight:  val_182, miplevel:  0), miplevel:  0);
                val_191 = new UnityEngine.Texture2D().width - val_182;
                new UnityEngine.Texture2D().SetPixels(x:  val_191, y:  0, blockWidth:  val_182, blockHeight:  val_182, colors:  val_14.GetPixels(x:  0, y:  val_14.height - val_182, blockWidth:  val_182, blockHeight:  val_182, miplevel:  0), miplevel:  0);
            }
            
            }
            
            if(val_182 > val_14.width)
            {
                goto label_71;
            }
            
            val_192 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_182 <= val_14.height)
            {
                goto label_274;
            }
            
            label_71:
            object[] val_82 = new object[9];
            val_82[0] = "You have selected a texture border size (";
            val_6 = val_182;
            val_82[1] = val_6;
            val_82[2] = "px), where the border size is larger than this texture (\"";
            val_193 = 0;
            string val_83 = val_14.name;
            if((val_83 != null) && (val_83 == null))
            {
                    val_193 = 0;
            }
            
            if(val_82.Length <= 3)
            {
                    val_193 = 0;
            }
            
            val_82[3] = val_83;
            if("\" " == null)
            {
                    val_193 = 0;
            }
            
            if(val_82.Length <= 4)
            {
                    val_193 = 0;
            }
            
            val_82[4] = "\" ";
            int val_84 = val_14.width;
            if((val_84 != 0) && (val_84 == 0))
            {
                    val_194 = 0;
            }
            
            if(val_82.Length <= 5)
            {
                    val_194 = 0;
            }
            
            val_82[5] = val_84;
            if("x" == null)
            {
                    val_194 = 0;
            }
            
            if(val_82.Length <= 6)
            {
                    val_194 = 0;
            }
            
            val_82[6] = "x";
            val_190 = val_14.height;
            val_82[7] = val_190;
            val_82[8] = "px) size itself, causing this texture to repeat in the atlas. This increased the merging time due to the need for a new algorithm for creating the borders. It is recommended that the size of the edges of the textures in the atlas, does not exceed the size of the textures themselves.";
            val_195 = +val_82;
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  val_195, 世丗丕东丄三丕丂丒:  4);
            if(val_182 < 1)
            {
                goto label_101;
            }
            
            var val_166 = 0;
            label_105:
            val_190 = 0;
            goto label_102;
            label_104:
            UnityEngine.Color val_90 = val_14.GetPixel(x:  (val_166 - val_182) + val_14.width, y:  0);
            val_187 = val_90.r;
            val_188 = val_90.b;
            val_196 = val_166;
            new UnityEngine.Texture2D().SetPixel(x:  0, y:  val_182 + val_190, color:  new UnityEngine.Color() {r = val_187, g = val_90.g, b = val_188, a = val_90.a});
            val_190 = 1;
            label_102:
            val_197 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_190 < val_14.height)
            {
                goto label_104;
            }
            
            val_166 = val_166 + 1;
            if(val_166 < val_182)
            {
                goto label_105;
            }
            
            label_101:
            val_198 = public System.Int32 UnityEngine.Texture::get_width();
            val_199 = val_14.width - val_182;
            goto label_106;
            label_110:
            val_200 = 0;
            goto label_107;
            label_109:
            val_190 = new UnityEngine.Texture2D().width;
            UnityEngine.Color val_99 = val_14.GetPixel(x:  (val_199 + val_182) - val_14.width, y:  0);
            new UnityEngine.Texture2D().SetPixel(x:  (val_190 + val_199) - val_14.width, y:  val_182 + val_200, color:  new UnityEngine.Color() {r = val_99.r, g = val_99.g, b = val_99.b, a = val_99.a});
            val_200 = 1;
            label_107:
            val_198 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_200 < val_14.height)
            {
                goto label_109;
            }
            
            val_199 = val_199 + 1;
            label_106:
            val_201 = public System.Int32 UnityEngine.Texture::get_width();
            if(val_199 < val_14.width)
            {
                goto label_110;
            }
            
            val_202 = 0;
            goto label_111;
            label_116:
            if(val_182 >= 1)
            {
                    do
            {
                UnityEngine.Color val_109 = val_14.GetPixel(x:  0, y:  ((-val_182) + 0) + val_14.width);
                val_187 = val_109.r;
                val_188 = val_109.b;
                val_201 = val_202 + val_182;
                new UnityEngine.Texture2D().SetPixel(x:  val_201, y:  0, color:  new UnityEngine.Color() {r = val_187, g = val_109.g, b = val_188, a = val_109.a});
                val_190 = 0 + 1;
            }
            while(val_190 < val_182);
            
            }
            
            val_202 = 1;
            label_111:
            val_203 = public System.Int32 UnityEngine.Texture::get_width();
            if(val_202 < val_14.width)
            {
                goto label_116;
            }
            
            val_181 = 0;
            goto label_117;
            label_121:
            val_204 = public System.Int32 UnityEngine.Texture::get_height();
            val_190 = val_14.height;
            goto label_118;
            label_120:
            UnityEngine.Color val_117 = val_14.GetPixel(x:  0, y:  val_190 - val_14.height);
            val_204 = val_181 + val_182;
            new UnityEngine.Texture2D().SetPixel(x:  val_204, y:  ((-val_182) + val_190) + (new UnityEngine.Texture2D().height - val_14.height), color:  new UnityEngine.Color() {r = val_117.r, g = val_117.g, b = val_117.b, a = val_117.a});
            val_190 = val_190 + 1;
            label_118:
            val_203 = public System.Int32 UnityEngine.Texture::get_height();
            if(((-val_182) + val_190) < val_14.height)
            {
                goto label_120;
            }
            
            val_181 = 1;
            label_117:
            val_205 = public System.Int32 UnityEngine.Texture::get_width();
            if(val_181 < val_14.width)
            {
                goto label_121;
            }
            
            if(val_182 >= 1)
            {
                    var val_167 = 0;
                do
            {
                val_181 = val_167 - val_182;
                do
            {
                UnityEngine.Color val_126 = val_14.GetPixel(x:  0, y:  0);
                val_205 = val_181 + new UnityEngine.Texture2D().width;
                new UnityEngine.Texture2D().SetPixel(x:  val_205, y:  ((-val_182) + 0) + new UnityEngine.Texture2D().height, color:  new UnityEngine.Color() {r = val_126.r, g = val_126.g, b = val_126.b, a = val_126.a});
                val_190 = 0 + 1;
            }
            while(val_190 < val_182);
            
                val_167 = val_167 + 1;
            }
            while(val_167 < val_182);
            
            }
            
            val_206 = public System.Int32 UnityEngine.Texture::get_width();
            val_207 = val_14.width - val_182;
            goto label_128;
            label_132:
            val_208 = public System.Int32 UnityEngine.Texture::get_height();
            int val_130 = val_14.height;
            val_181 = val_207 + val_182;
            goto label_129;
            label_131:
            UnityEngine.Color val_133 = val_14.GetPixel(x:  val_207, y:  val_190);
            val_187 = val_133.r;
            val_188 = val_133.b;
            val_208 = val_181 - val_14.width;
            new UnityEngine.Texture2D().SetPixel(x:  val_208, y:  val_130 - val_14.height, color:  new UnityEngine.Color() {r = val_187, g = val_133.g, b = val_188, a = val_133.a});
            int val_168 = val_130;
            val_168 = val_168 + 1;
            label_129:
            val_206 = public System.Int32 UnityEngine.Texture::get_height();
            val_190 = (-val_182) + val_168;
            if(val_190 < val_14.height)
            {
                goto label_131;
            }
            
            val_207 = val_207 + 1;
            label_128:
            if(val_207 < val_14.width)
            {
                goto label_132;
            }
            
            val_209 = public System.Int32 UnityEngine.Texture::get_width();
            val_210 = val_14.width - val_182;
            val_185 = -val_182;
            goto label_133;
            label_138:
            if(val_182 >= 1)
            {
                    val_181 = val_210 + val_182;
                do
            {
                int val_138 = val_14.width;
                UnityEngine.Color val_140 = val_14.GetPixel(x:  val_210, y:  0);
                val_209 = val_181 - val_138;
                new UnityEngine.Texture2D().SetPixel(x:  val_209, y:  (val_185 + 0) + new UnityEngine.Texture2D().height, color:  new UnityEngine.Color() {r = val_140.r, g = val_140.g, b = val_140.b, a = val_140.a});
                val_190 = 0 + 1;
            }
            while(val_190 < val_182);
            
            }
            
            val_210 = val_210 + 1;
            label_133:
            val_192 = public System.Int32 UnityEngine.Texture::get_width();
            if(val_210 < val_14.width)
            {
                goto label_138;
            }
            
            if(val_182 < 1)
            {
                goto label_274;
            }
            
            var val_170 = 0;
            val_185 = -val_182;
            label_143:
            val_211 = public System.Int32 UnityEngine.Texture::get_height();
            int val_144 = val_14.height;
            val_181 = val_170 - val_182;
            goto label_140;
            label_142:
            val_190 = val_14.height;
            UnityEngine.Color val_147 = val_14.GetPixel(x:  0, y:  val_138);
            val_211 = val_181 + new UnityEngine.Texture2D().width;
            new UnityEngine.Texture2D().SetPixel(x:  val_211, y:  val_144 - val_190, color:  new UnityEngine.Color() {r = val_147.r, g = val_147.g, b = val_147.b, a = val_147.a});
            int val_169 = val_144;
            val_169 = val_169 + 1;
            label_140:
            val_192 = public System.Int32 UnityEngine.Texture::get_height();
            if((val_185 + val_169) < val_14.height)
            {
                goto label_142;
            }
            
            val_170 = val_170 + 1;
            if(val_170 < val_182)
            {
                goto label_143;
            }
            
            label_274:
            if(width == 一丙丒三与丒丘丏丘)
            {
                    if(height == 丂下丌丌丛丑丝世丈)
            {
                    return (UnityEngine.Texture2D);
            }
            
            }
            
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.业三丑上七上下三专(丟三丟三丅专丂丄丂:  null, 丙一丐丗专丙丆丒且:  一丙丒三与丒丘丏丘, 七下丙丏丌专丁丙不:  丂下丌丌丛丑丝世丈);
            return (UnityEngine.Texture2D);
        }
        private int 专丒丈丒丝丑丐万丝()
        {
            if(this.mergeMethod != 1)
            {
                    return 16;
            }
            
            if(this.allInOneParams.atlasResolution > 8)
            {
                    return 16;
            }
            
            return (int)106046576 + (this.allInOneParams.atlasResolution) << 2;
        }
        private MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丘上不丂丒丟丐东丕 丁丄丙丙丗三丗丏一(System.Collections.Generic.Dictionary<UnityEngine.Material, MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丞丛丒丒丅丈丙三上> 丅丂东丛丕丆丗丅丐, int 东丈七丑丅丛且且丄, int 万丛与丘世万丗丂东, bool 丒专丒丝与三丈世丗)
        {
            UnityEngine.Texture2D val_6;
            var val_43;
            SkinnedMeshCombiner.丘上不丂丒丟丐东丕 val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_49;
            val_43 = 丅丂东丛丕丆丗丅丐;
            SkinnedMeshCombiner.丘上不丂丒丟丐东丕 val_1 = null;
            val_44 = val_1;
            val_1 = new SkinnedMeshCombiner.丘上不丂丒丟丐东丕();
            System.Collections.Generic.List<UnityEngine.Texture2D> val_2 = new System.Collections.Generic.List<UnityEngine.Texture2D>();
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_3 = val_43.GetEnumerator();
            val_45 = 1152921541495551072;
            label_6:
            if(((-1765271904) & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_2.Add(item:  val_6);
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            T[] val_8 = val_2.ToArray();
            if(val_44 != null)
            {
                    .丁丘丌专丟丆业丑丄 = val_8;
            }
            else
            {
                    mem[96] = val_8;
            }
            
            .七丛丄丕丅万万丘丑 = (SkinnedMeshCombiner.丘上不丂丒丟丐东丕)[1152921541496328992].丏丞丄专丌不丞丄丞.PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            if((mem[1152921541496292984] + 56) == 0)
            {
                goto label_20;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_11 = val_43.GetEnumerator();
            label_26:
            if(((-1765271904) & 1) == 0)
            {
                goto label_23;
            }
            
            ConfiguredValueTaskAwaiter val_12 = val_6.GetAwaiter();
            val_2.Add(item:  val_7._value._token);
            goto label_26;
            label_23:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Rect[] val_14 = (SkinnedMeshCombiner.丘上不丂丒丟丐东丕)[1152921541496328992].一下丕世业万丏东一.PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            label_20:
            if((mem[1152921541496292984] + 80) == 0)
            {
                goto label_38;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_15 = val_43.GetEnumerator();
            label_44:
            if(((-1765271904) & 1) == 0)
            {
                goto label_41;
            }
            
            ConfiguredValueTaskAwaiter val_16 = val_6.GetAwaiter();
            val_2.Add(item:  val_7._value._obj);
            goto label_44;
            label_38:
            val_46 = 0;
            val_47 = 0;
            goto label_45;
            label_41:
            val_47 = 0;
            val_46 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (358 != 358))
            {
                goto label_52;
            }
            
            val_47 = 0;
            if(val_44 != null)
            {
                goto label_56;
            }
            
            goto label_54;
            label_52:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != null)
            {
                goto label_56;
            }
            
            label_54:
            label_56:
            UnityEngine.Rect[] val_18 = (SkinnedMeshCombiner.丘上不丂丒丟丐东丕)[1152921541496328992].丆丘丄丈丕业丂丘丟.PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_45:
            if((mem[1152921541496292984] + 104) == 0)
            {
                goto label_60;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_19 = val_43.GetEnumerator();
            label_66:
            if(((-1765271904) & 1) == 0)
            {
                goto label_63;
            }
            
            ConfiguredValueTaskAwaiter val_20 = val_6.GetAwaiter();
            val_2.Add(item:  val_12._value._token);
            goto label_66;
            label_63:
            val_47 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_47 == 1) || (479 != 479))
            {
                goto label_73;
            }
            
            val_47 = 1;
            if(val_44 != 0)
            {
                goto label_77;
            }
            
            goto label_75;
            label_73:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != 0)
            {
                goto label_77;
            }
            
            label_75:
            label_77:
            UnityEngine.Rect[] val_22 = mem[1152921541496329032].PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_60:
            if((mem[1152921541496292984] + 128) == 0)
            {
                goto label_81;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_23 = val_43.GetEnumerator();
            label_87:
            if(((-1765271904) & 1) == 0)
            {
                goto label_84;
            }
            
            ConfiguredValueTaskAwaiter val_24 = val_6.GetAwaiter();
            val_2.Add(item:  val_12._value._obj);
            goto label_87;
            label_84:
            val_47 = val_47 + 1;
            mem2[0] = 600;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_47 == 1) || ((-1765272176 + ((val_47 + 1)) << 2) != 600))
            {
                goto label_94;
            }
            
            var val_43 = 0;
            val_43 = val_43 ^ (val_47 >> 31);
            val_47 = val_47 + val_43;
            if(val_44 != 0)
            {
                goto label_98;
            }
            
            goto label_96;
            label_94:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != 0)
            {
                goto label_98;
            }
            
            label_96:
            label_98:
            UnityEngine.Rect[] val_26 = mem[1152921541496329040].PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_81:
            if((mem[1152921541496292984] + 152) == 0)
            {
                goto label_102;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_27 = val_43.GetEnumerator();
            label_108:
            if(((-1765271904) & 1) == 0)
            {
                goto label_105;
            }
            
            ConfiguredValueTaskAwaiter val_28 = val_6.GetAwaiter();
            val_2.Add(item:  val_16._value._token);
            goto label_108;
            label_105:
            val_47 = val_47 + 1;
            mem2[0] = 721;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_47 == 1) || ((-1765272176 + (((val_47 + 1) + 1)) << 2) != 721))
            {
                goto label_115;
            }
            
            var val_44 = 0;
            val_44 = val_44 ^ (val_47 >> 31);
            val_47 = val_47 + val_44;
            if(val_44 != 0)
            {
                goto label_119;
            }
            
            goto label_117;
            label_115:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != 0)
            {
                goto label_119;
            }
            
            label_117:
            label_119:
            UnityEngine.Rect[] val_30 = mem[1152921541496329048].PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_102:
            if((mem[1152921541496292984] + 176) == 0)
            {
                goto label_123;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_31 = val_43.GetEnumerator();
            label_129:
            if(((-1765271904) & 1) == 0)
            {
                goto label_126;
            }
            
            ConfiguredValueTaskAwaiter val_32 = val_6.GetAwaiter();
            val_2.Add(item:  val_16._value._obj);
            goto label_129;
            label_126:
            val_47 = val_47 + 1;
            mem2[0] = 842;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_47 == 1) || ((-1765272176 + ((((val_47 + 1) + 1) + 1)) << 2) != 842))
            {
                goto label_136;
            }
            
            var val_45 = 0;
            val_45 = val_45 ^ (val_47 >> 31);
            val_47 = val_47 + val_45;
            if(val_44 != 0)
            {
                goto label_140;
            }
            
            goto label_138;
            label_136:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != 0)
            {
                goto label_140;
            }
            
            label_138:
            label_140:
            UnityEngine.Rect[] val_34 = mem[1152921541496329056].PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_123:
            if((mem[1152921541496292984] + 200) == 0)
            {
                goto label_144;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_35 = val_43.GetEnumerator();
            label_150:
            if(((-1765271904) & 1) == 0)
            {
                goto label_147;
            }
            
            ConfiguredValueTaskAwaiter val_36 = val_6.GetAwaiter();
            val_2.Add(item:  val_20._value._token);
            goto label_150;
            label_147:
            val_47 = val_47 + 1;
            mem2[0] = 963;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_47 == 1) || ((-1765272176 + (((((val_47 + 1) + 1) + 1) + 1)) << 2) != 963))
            {
                goto label_157;
            }
            
            var val_46 = 0;
            val_46 = val_46 ^ (val_47 >> 31);
            val_47 = val_47 + val_46;
            if(val_44 != 0)
            {
                goto label_161;
            }
            
            goto label_159;
            label_157:
            if( != 0)
            {
                    val_46 = 0;
            }
            
            if(val_44 != 0)
            {
                goto label_161;
            }
            
            label_159:
            label_161:
            UnityEngine.Rect[] val_38 = mem[1152921541496329064].PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            val_44 = val_44;
            label_144:
            if((mem[1152921541496292984] + 224) == 0)
            {
                    return (丘上不丂丒丟丐东丕)val_44;
            }
            
            val_2.Clear();
            Dictionary.Enumerator<TKey, TValue> val_39 = val_43.GetEnumerator();
            label_171:
            if(((-1765271904) & 1) == 0)
            {
                goto label_168;
            }
            
            ConfiguredValueTaskAwaiter val_40 = val_6.GetAwaiter();
            val_2.Add(item:  val_20._value._obj);
            goto label_171;
            label_168:
            val_47 = val_47 + 1;
            mem2[0] = 1084;
            val_49 = public System.Void Dictionary.Enumerator<UnityEngine.Material, 丞丛丒丒丅丈丙三上>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_47 == 1)
            {
                goto label_177;
            }
            
            if(( == 0) || ((-1765272176 + ((((((val_47 + 1) + 1) + 1) + 1) + 1)) << 2) == 1084))
            {
                goto label_184;
            }
            
            label_183:
            val_49 = 0;
            label_184:
            val_43 = mem[1152921541496329072];
            UnityEngine.Rect[] val_42 = val_43.PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            return (丘上不丂丒丟丐东丕)val_44;
            label_177:
            if( != 0)
            {
                goto label_183;
            }
            
            goto label_184;
        }
        private void 丅丑且丑丗丅东丆丘(UnityEngine.Material 丞一与丆丘丏世丏丕, string 三丄专丅与且世七专, UnityEngine.Texture2D 丄上业丛丌丂丝丝丒)
        {
            if((丞一与丆丘丏世丏丕.HasProperty(name:  三丄专丅与且世七专)) != false)
            {
                    if((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  三丄专丅与且世七专)) != true)
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  三丄专丅与且世七专);
            }
            
                if(丞一与丆丘丏世丏丕 != null)
            {
                    丞一与丆丘丏世丏丕.SetTexture(name:  三丄专丅与且世七专, value:  丄上业丛丌丂丝丝丒);
            }
            else
            {
                    0.SetTexture(name:  三丄专丅与且世七专, value:  丄上业丛丌丂丝丝丒);
            }
            
                if((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  三丄专丅与且世七专)) != true)
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  三丄专丅与且世七专);
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_MetallicGlossMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_METALLICGLOSSMAP")) != true) && (this.allInOneParams.metallicMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_METALLICGLOSSMAP");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_SpecGlossMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_SPECGLOSSMAP")) != true) && (this.allInOneParams.specularMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_SPECGLOSSMAP");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_BumpMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_NORMALMAP")) != true) && (this.allInOneParams.normalMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_NORMALMAP");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_ParallaxMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_PARALLAXMAP")) != true) && (this.allInOneParams.heightMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_PARALLAXMAP");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_OcclusionMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_OcclusionMap")) != true) && (this.allInOneParams.occlusionMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_OcclusionMap");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_DetailAlbedoMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_DETAIL_MULX2")) != true) && (this.allInOneParams.detailAlbedoMapSupport != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_DETAIL_MULX2");
            }
            
            }
            
                if((System.String.op_Equality(a:  三丄专丅与且世七专, b:  "_DetailNormalMap")) != false)
            {
                    if(((丞一与丆丘丏世丏丕.IsKeywordEnabled(keyword:  "_DETAIL_MULX2")) != true) && (this.allInOneParams.normalMap2Support != false))
            {
                    丞一与丆丘丏世丏丕.EnableKeyword(keyword:  "_DETAIL_MULX2");
            }
            
            }
            
            }
            
            if((丞一与丆丘丏世丏丕.HasProperty(name:  三丄专丅与且世七专)) != false)
            {
                    return;
            }
            
            string[] val_19 = new string[5];
            val_19[0] = "It was not possible to find and apply the atlas on property \"";
            val_19[1] = 三丄专丅与且世七专;
            val_19[2] = "\" of the material to use (\"";
            val_19[3] = 丞一与丆丘丏世丏丕.name;
            val_19[4] = "\"). Therefore, no atlas was applied to this property.";
            this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  +val_19, 世丗丕东丄三丕丂丒:  1);
        }
        private int 丏丐丌世丏不与丝世()
        {
            if(this.mergeMethod != 1)
            {
                    return 2;
            }
            
            SkinnedMeshCombiner.丟世丆丄三丌丘丘丑 val_1 = this.allInOneParams.mipMapEdgesSize;
            val_1 = val_1 - 1;
            if(val_1 > 6)
            {
                    return 2;
            }
            
            return (int)106046544 + ((this.allInOneParams.mipMapEdgesSize - 1)) << 2;
        }
        private int 丝丌与业丟丅上丝世()
        {
            if(this.mergeMethod != 1)
            {
                    return 0;
            }
            
            SkinnedMeshCombiner.丑丌七丙丕丂丒专丈 val_1 = this.allInOneParams.atlasPadding;
            val_1 = val_1 - 1;
            if(val_1 > 3)
            {
                    return 0;
            }
            
            return (int)106046464 + ((this.allInOneParams.atlasPadding - 1)) << 2;
        }
        private UnityEngine.Texture2D 丘丕丅丗丅丑丘丒丁(UnityEngine.Material 丞一与丆丘丏世丏丕, string 丅丑丕业丁不丙与丟, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
        {
            string val_12;
            var val_13;
            UnityEngine.Color val_14;
            var val_15;
            val_12 = 丅丑丕业丁不丙与丟;
            UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  业与三万七丝不万东, height:  丟丌丐丘丆丙丑丑一, textureFormat:  5, mipChain:  false, linear:  false);
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            val_13 = val_2.r;
            val_14 = val_2.b;
            if((丞一与丆丘丏世丏丕.HasProperty(name:  val_12)) != false)
            {
                    UnityEngine.Color val_4 = 丞一与丆丘丏世丏丕.GetColor(name:  val_12);
                val_13 = val_4.r;
                val_14 = val_4.b;
            }
            
            if((丞一与丆丘丏世丏丕.HasProperty(name:  val_12)) != true)
            {
                    string[] val_6 = new string[5];
                val_6[0] = "It was not possible to find the color stored in property \"";
                val_6[1] = val_12;
                val_12 = "\" of material \"";
                val_6[2] = val_12;
                val_6[3] = 丞一与丆丘丏世丏丕.name;
                val_6[4] = "\", so this Color was replaced by a GRAY texture.";
                this.东丐世丛丐万且丝万(三丏丑不业丏不丂丈:  +val_6, 世丗丕东丄三丕丂丒:  4);
                UnityEngine.Color val_9 = UnityEngine.Color.gray;
                val_13 = val_9.r;
                val_14 = val_9.b;
            }
            
            int val_10 = 丟丌丐丘丆丙丑丑一 * 业与三万七丝不万东;
            UnityEngine.Color[] val_11 = new UnityEngine.Color[0];
            val_15 = 0;
            goto label_23;
            label_26:
            val_15 = 1;
            val_11[0] = val_9;
            val_11[0] = val_9.g;
            val_11[0] = val_14;
            val_11[0] = val_9.a;
            label_23:
            if(val_15 < val_11.Length)
            {
                goto label_26;
            }
            
            val_1.SetPixels(x:  0, y:  0, blockWidth:  业与三万七丝不万东, blockHeight:  丟丌丐丘丆丙丑丑一, colors:  val_11, miplevel:  0);
            return val_1;
        }
        private MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.万丅丐不且丌专与丐 丘丟三一东业三世上(MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丈丟丞丆世丐上万七[] 上丄丛丟丂三丘丘一, int 东丈七丑丅丛且且丄, int 万丛与丘世万丗丂东, bool 丒专丒丝与三丈世丗)
        {
            var val_6;
            SkinnedMeshCombiner.万丅丐不且丌专与丐 val_1 = new SkinnedMeshCombiner.万丅丐不且丌专与丐();
            System.Collections.Generic.List<UnityEngine.Texture2D> val_2 = new System.Collections.Generic.List<UnityEngine.Texture2D>();
            val_2.Clear();
            val_6 = 0;
            goto label_2;
            label_7:
            丈丟丞丆世丐上万七 val_6 = 上丄丛丟丂三丘丘一[0];
            val_2.Add(item:  上丄丛丟丂三丘丘一[0x0][0].丏丐丗与且三丌丌东);
            val_6 = 1;
            label_2:
            if(val_6 < 上丄丛丟丂三丘丘一.Length)
            {
                goto label_7;
            }
            
            T[] val_3 = val_2.ToArray();
            if(val_1 != null)
            {
                    .业丑世丏专世丐丟丐 = val_3;
            }
            else
            {
                    mem[32] = val_3;
            }
            
            .七丛丄丕丅万万丘丑 = (SkinnedMeshCombiner.万丅丐不且丌专与丐)[1152921541498029344].丌三丘丗下东丐东丑.PackTextures(textures:  val_2.ToArray(), padding:  万丛与丘世万丗丂东, maximumAtlasSize:  东丈七丑丅丛且且丄);
            return (万丅丐不且丌专与丐)val_1;
        }
        private int 且一丟万丘丌丂丑丐()
        {
            if(this.mergeMethod != 3)
            {
                    return 16;
            }
            
            if(this.onlyAnima2dMeshes.atlasResolution > 8)
            {
                    return 16;
            }
            
            return (int)106046576 + (this.onlyAnima2dMeshes.atlasResolution) << 2;
        }
        public SkinnedMeshCombiner()
        {
            this.resultMergeTextStats = "";
            this.resultMergeLogs = new System.Collections.Generic.List<LogOfMerge>();
            this.resultMergeAssetsSaved = new System.Collections.Generic.List<System.String>();
            this.oneMeshPerMaterialParams = new SkinnedMeshCombiner.OneMeshPerMaterialParams();
            this.justMaterialColorsParams = new SkinnedMeshCombiner.JustMaterialColorsParams();
            this.allInOneParams = new SkinnedMeshCombiner.AllInOneParams();
            this.onlyAnima2dMeshes = new SkinnedMeshCombiner.OnlyAnima2dMeshes();
            this.compatibilityMode = true;
            this.ignoreBlendshapes = true;
            this.nameOfThisMerge = "Combined Meshes";
            this.gameObjectsToIgnore = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this.saveDataInAssets = true;
            this.launchConsoleLogs = true;
            this.nameOfPrefabOfMerge = "";
        }
    
    }

}
