using UnityEngine;

namespace MTAssets.EasyMeshCombiner
{
    public class RuntimeMeshCombiner : MonoBehaviour
    {
        // Fields
        private int 丙丌丌丁丂与丞丄丏;
        private System.Collections.Generic.List<MTAssets.EasyMeshCombiner.RuntimeMeshCombiner.上丁丄一丛丈丕丐丆> 丗丁丑丝丐业三丈丒;
        private bool 丝不丗丘不丒丕丙不;
        public MTAssets.EasyMeshCombiner.RuntimeMeshCombiner.丕丘丘万不丙丕与丐 afterMerge;
        public bool addMeshColliderAfter;
        public bool combineMeshesAtStartUp;
        public bool combineInChildren;
        public bool combineInactives;
        public bool recalculateNormals;
        public bool recalculateTangents;
        public System.Collections.Generic.List<UnityEngine.GameObject> targetMeshes;
        public bool showDebugLogs;
        public bool garbageCollectorAfterUndo;
        public UnityEngine.Events.UnityEvent onDoneMerge;
        public UnityEngine.Events.UnityEvent onDoneUnmerge;
        
        // Methods
        private void Start()
        {
            if(this.combineMeshesAtStartUp == false)
            {
                    return;
            }
            
            if(this.showDebugLogs != false)
            {
                    UnityEngine.Debug.Log(message:  "The merge started in Runtime Combiner \"" + this.gameObject.name + "\".");
            }
            
            bool val_4 = this.CombineMeshes();
        }
        private MTAssets.EasyMeshCombiner.RuntimeMeshCombiner.丅丞万丑万丒不丞丕[] 丒丁下七下业丐丌万()
        {
            var val_87;
            var val_88;
            var val_89;
            T val_90;
            var val_91;
            var val_92;
            var val_93;
            System.Collections.Generic.List<T> val_94;
            System.Collections.Generic.List<UnityEngine.Transform> val_1 = null;
            val_87 = val_1;
            val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
            val_88 = 0;
            goto label_1;
            label_19:
            if(this.targetMeshes.Item[0] == 0)
            {
                goto label_14;
            }
            
            if(this.combineInChildren == false)
            {
                goto label_6;
            }
            
            val_89 = 0;
            goto label_9;
            label_13:
            val_90 = this.targetMeshes.Item[0].GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true)[0];
            val_1.Add(item:  val_90);
            val_89 = 1;
            label_9:
            if(val_89 < val_5.Length)
            {
                goto label_13;
            }
            
            if(this.combineInChildren == true)
            {
                goto label_14;
            }
            
            label_6:
            val_1.Add(item:  this.targetMeshes.Item[0].GetComponent<UnityEngine.Transform>());
            label_14:
            val_88 = 1;
            label_1:
            if(val_88 < this.targetMeshes.Count)
            {
                goto label_19;
            }
            
            System.Collections.Generic.List<丅丞万丑万丒不丞丕> val_9 = new System.Collections.Generic.List<丅丞万丑万丒不丞丕>();
            val_91 = 0;
            goto label_35;
            label_45:
            val_90 = val_1.Item[0].GetComponent<UnityEngine.MeshFilter>();
            UnityEngine.MeshRenderer val_13 = val_1.Item[0].GetComponent<UnityEngine.MeshRenderer>();
            if(val_90 == 0)
            {
                    if(val_13 == 0)
            {
                goto label_43;
            }
            
            }
            
            if(this.combineInactives == false)
            {
                goto label_31;
            }
            
            label_42:
            .下丐三丆丝与不丗丕 = val_1.Item[0].gameObject;
            .世丒丗丝丆丑不丐丒 = val_90;
            .下丆丙丅丅与丏丗下 = val_13;
            val_9.Add(item:  new RuntimeMeshCombiner.丅丞万丑万丒不丞丕());
            label_43:
            val_91 = 1;
            goto label_35;
            label_31:
            if(val_13.enabled == false)
            {
                goto label_43;
            }
            
            if((this.combineInactives == true) || (val_1.Item[0].gameObject.activeSelf == true))
            {
                goto label_42;
            }
            
            goto label_43;
            label_35:
            if(val_91 < val_1.Count)
            {
                goto label_45;
            }
            
            System.Collections.Generic.List<丅丞万丑万丒不丞丕> val_24 = new System.Collections.Generic.List<丅丞万丑万丒不丞丕>();
            val_92 = 0;
            goto label_46;
            label_207:
            丅丞万丑万丒不丞丕 val_25 = val_9.Item[0];
            if(val_25.世丒丗丝丆丑不丐丒 != 0)
            {
                goto label_51;
            }
            
            if(this.showDebugLogs != false)
            {
                    丅丞万丑万丒不丞丕 val_27 = val_9.Item[0];
                UnityEngine.Debug.LogError(message:  "GameObject \"" + val_27.下丐三丆丝与不丗丕.name + "\" does not have the Mesh Filter component, so it is not a valid mesh and will be ignored in the merge process.");
            }
            
            val_87 = 0;
            if(val_9 != null)
            {
                goto label_60;
            }
            
            goto label_59;
            label_51:
            val_87 = 1;
            if(val_9 != null)
            {
                goto label_60;
            }
            
            label_59:
            label_60:
            丅丞万丑万丒不丞丕 val_30 = val_9.Item[0];
            if(val_30.下丆丙丅丅与丏丗下 == 0)
            {
                    if(this.showDebugLogs != false)
            {
                    丅丞万丑万丒不丞丕 val_32 = val_9.Item[0];
                UnityEngine.Debug.LogError(message:  "GameObject \"" + val_32.下丐三丆丝与不丗丕.name + "\" does not have the Mesh Renderer component, so it is not a valid mesh and will be ignored in the merge process.");
            }
            
                val_87 = 0;
            }
            
            丅丞万丑万丒不丞丕 val_35 = val_9.Item[0];
            if(val_35.世丒丗丝丆丑不丐丒 != 0)
            {
                    丅丞万丑万丒不丞丕 val_37 = val_9.Item[0];
                if(val_37.世丒丗丝丆丑不丐丒.sharedMesh == 0)
            {
                    if(this.showDebugLogs != false)
            {
                    丅丞万丑万丒不丞丕 val_40 = val_9.Item[0];
                UnityEngine.Debug.LogError(message:  "GameObject \"" + val_40.下丐三丆丝与不丗丕.name + "\" does not have a Mesh in Mesh Filter component, so it is not a valid mesh and will be ignored in the merge process.");
            }
            
                val_87 = 0;
            }
            
            }
            
            丅丞万丑万丒不丞丕 val_43 = val_9.Item[0];
            if(val_43.世丒丗丝丆丑不丐丒 != 0)
            {
                    丅丞万丑万丒不丞丕 val_45 = val_9.Item[0];
                if(val_45.下丆丙丅丅与丏丗下 != 0)
            {
                    丅丞万丑万丒不丞丕 val_47 = val_9.Item[0];
                if(val_47.世丒丗丝丆丑不丐丒.sharedMesh != 0)
            {
                    丅丞万丑万丒不丞丕 val_50 = val_9.Item[0];
                丅丞万丑万丒不丞丕 val_53 = val_9.Item[0];
                UnityEngine.Material[] val_54 = val_53.下丆丙丅丅与丏丗下.sharedMaterials;
                if(val_50.世丒丗丝丆丑不丐丒.sharedMesh.subMeshCount != val_54.Length)
            {
                    if(this.showDebugLogs != false)
            {
                    string[] val_55 = new string[7];
                val_55[0] = "The Mesh Renderer component found in GameObject \"";
                丅丞万丑万丒不丞丕 val_56 = val_9.Item[0];
                val_55[1] = val_56.下丐三丆丝与不丗丕.name;
                val_55[2] = "\" has more or less material needed. The mesh that is in this GameObject has ";
                丅丞万丑万丒不丞丕 val_58 = val_9.Item[0];
                val_55[3] = val_58.世丒丗丝丆丑不丐丒.sharedMesh.subMeshCount.ToString();
                val_55[4] = " submeshes, but has a number of ";
                丅丞万丑万丒不丞丕 val_62 = val_9.Item[0];
                UnityEngine.Material[] val_63 = val_62.下丆丙丅丅与丏丗下.sharedMaterials;
                val_55[5] = val_63.Length.ToString();
                val_55[6] = " materials. This mesh will be ignored during the merge process.";
                UnityEngine.Debug.LogError(message:  +val_55);
            }
            
                val_87 = 0;
            }
            
            }
            
            }
            
            }
            
            丅丞万丑万丒不丞丕 val_66 = val_9.Item[0];
            if(val_66.下丆丙丅丅与丏丗下 == 0)
            {
                goto label_153;
            }
            
            val_93 = 0;
            goto label_154;
            label_189:
            丅丞万丑万丒不丞丕 val_68 = val_9.Item[0];
            if(val_68.下丆丙丅丅与丏丗下.sharedMaterials[0] == 0)
            {
                    if(this.showDebugLogs != false)
            {
                    string[] val_71 = new string[5];
                val_71[0] = "Material ";
                val_71[1] = 0.ToString();
                val_71[2] = " in Mesh Renderer present in component \"";
                丅丞万丑万丒不丞丕 val_73 = val_9.Item[0];
                val_71[3] = val_73.下丐三丆丝与不丗丕.name;
                val_71[4] = "\" is null. For the merge process to work well, all materials must be completed. This GameObject will be ignored in the merge process.";
                UnityEngine.Debug.LogError(message:  +val_71);
            }
            
                val_87 = 0;
            }
            
            val_93 = 0 + 1;
            label_154:
            丅丞万丑万丒不丞丕 val_76 = val_9.Item[0];
            UnityEngine.Material[] val_77 = val_76.下丆丙丅丅与丏丗下.sharedMaterials;
            if(val_93 < val_77.Length)
            {
                goto label_189;
            }
            
            label_153:
            丅丞万丑万丒不丞丕 val_78 = val_9.Item[0];
            val_90 = val_78.下丐三丆丝与不丗丕.GetComponent<MTAssets.EasyMeshCombiner.CombinedMeshesManager>();
            if(val_90 == 0)
            {
                goto label_195;
            }
            
            if(this.showDebugLogs == false)
            {
                goto label_203;
            }
            
            丅丞万丑万丒不丞丕 val_81 = val_9.Item[0];
            val_90 = "GameObject \"" + val_81.下丐三丆丝与不丗丕.name + "\" is the result of a previous merge, so it will be ignored by this merge.";
            UnityEngine.Debug.LogError(message:  val_90);
            goto label_203;
            label_195:
            if((val_87 & 1) != 0)
            {
                    val_94 = val_24;
                val_90 = val_9.Item[0];
                if(val_94 == 0)
            {
                    val_94 = val_24;
            }
            
                val_24.Add(item:  val_90);
            }
            
            label_203:
            val_92 = 1;
            label_46:
            if(val_92 < val_9.Count)
            {
                goto label_207;
            }
            
            return (丅丞万丑万丒不丞丕[])val_24.ToArray();
        }
        public bool CombineMeshes()
        {
            var val_29;
            var val_60;
            var val_83;
            MTAssets.EasyMeshCombiner.RuntimeMeshCombiner val_84;
            bool val_85;
            丅丞万丑万丒不丞丕[] val_86;
            var val_87;
            int val_88;
            丅丞万丑万丒不丞丕[] val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            UnityEngine.GameObject val_94;
            System.Collections.Generic.List<T> val_95;
            var val_98;
            丅丞万丑万丒不丞丕[] val_99;
            bool val_100;
            var val_101;
            var val_102;
            MTAssets.EasyMeshCombiner.RuntimeMeshCombiner val_103;
            var val_104;
            var val_105;
            var val_106;
            val_83;
            val_84 = this;
            if(this.丝不丗丘不丒丕丙不 != false)
            {
                    if(this.showDebugLogs != false)
            {
                    UnityEngine.Debug.Log(message:  "The Runtime Combiner \"" + this.gameObject.name + "\" meshes are already combined!"("\" meshes are already combined!"));
            }
            
                val_85 = 1;
                return val_85;
            }
            
            val_86 = this.丒丁下七下业丐丌万();
            if(val_4.Length == 0)
            {
                goto label_8;
            }
            
            System.Collections.Generic.Dictionary<UnityEngine.Material, System.Collections.Generic.List<三丌丗丑丐业世丌丁>> val_5 = new System.Collections.Generic.Dictionary<UnityEngine.Material, System.Collections.Generic.List<三丌丗丑丐业世丌丁>>();
            val_87 = 0;
            goto label_9;
            label_30:
            丅丞万丑万丒不丞丕 val_84 = val_86[0];
            val_88 = 0;
            goto label_11;
            label_28:
            UnityEngine.Material val_85 = val_4[0x0][0].下丆丙丅丅与丏丗下.sharedMaterials[0];
            if((val_5.ContainsKey(key:  val_85)) != false)
            {
                    .不丂丅丁且丆东东丂 = val_4[0x0][0].下丐三丆丝与不丗丕.transform;
                .世丒丗丝丆丑不丐丒 = val_4[0x0][0].世丒丗丝丆丑不丐丒;
                .下丆丙丅丅与丏丗下 = val_4[0x0][0].下丆丙丅丅与丏丗下;
                .丛丄丏与丙丅丐丅一 = val_88;
                val_5.Item[val_85].Add(item:  new RuntimeMeshCombiner.三丌丗丑丐业世丌丁());
            }
            
            if((val_5.ContainsKey(key:  val_85)) != true)
            {
                    System.Collections.Generic.List<三丌丗丑丐业世丌丁> val_12 = new System.Collections.Generic.List<三丌丗丑丐业世丌丁>();
                .不丂丅丁且丆东东丂 = val_4[0x0][0].下丐三丆丝与不丗丕.transform;
                .世丒丗丝丆丑不丐丒 = val_4[0x0][0].世丒丗丝丆丑不丐丒;
                .下丆丙丅丅与丏丗下 = val_4[0x0][0].下丆丙丅丅与丏丗下;
                .丛丄丏与丙丅丐丅一 = val_88;
                val_12.Add(item:  new RuntimeMeshCombiner.三丌丗丑丐业世丌丁());
                val_5.Add(key:  val_85, value:  val_12);
            }
            
            val_88 = 1;
            label_11:
            if(val_88 < val_4[0x0][0].世丒丗丝丆丑不丐丒.sharedMesh.subMeshCount)
            {
                goto label_28;
            }
            
            val_89 = val_86;
            val_87 = 1;
            label_9:
            if(val_87 < (val_4 + 24))
            {
                goto label_30;
            }
            
            val_90 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
            val_91 = 0;
            if((val_4 + 24) >= 1)
            {
                    do
            {
                丅丞万丑万丒不丞丕[] val_21 = val_86 + 0;
                val_91 = ((val_4 + 0) + 32 + 24.sharedMesh.vertexCount) + val_91;
            }
            while((0 + 1) < (val_4 + 24));
            
            }
            
            System.Collections.Generic.List<UnityEngine.Mesh> val_25 = new System.Collections.Generic.List<UnityEngine.Mesh>();
            Dictionary.Enumerator<TKey, TValue> val_26 = val_5.GetEnumerator();
            label_60:
            if(((-1754961088) & 1) == 0)
            {
                goto label_40;
            }
            
            ConfiguredValueTaskAwaiter val_30 = val_29.GetAwaiter();
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_31 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            val_92 = 0;
            goto label_41;
            label_52:
            三丌丗丑丐业世丌丁 val_32 = val_30._value._obj.Item[0];
            UnityEngine.Mesh val_33 = val_32.世丒丗丝丆丑不丐丒.sharedMesh;
            三丌丗丑丐业世丌丁 val_34 = val_30._value._obj.Item[0];
            三丌丗丑丐业世丌丁 val_35 = val_30._value._obj.Item[0];
            UnityEngine.Matrix4x4 val_36 = val_35.不丂丅丁且丆东东丂.localToWorldMatrix;
            null.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            val_92 = 1;
            label_41:
            if(val_92 < val_30._value._obj.Count)
            {
                goto label_52;
            }
            
            new UnityEngine.Mesh() = new UnityEngine.Mesh();
            val_93 = mem[1152921541506603928];
            if(val_91 <= val_93)
            {
                    new UnityEngine.Mesh().indexFormat = 0;
                val_93 = mem[1152921541506603928];
            }
            
            if(val_91 > val_93)
            {
                    new UnityEngine.Mesh().indexFormat = 1;
            }
            
            new UnityEngine.Mesh().CombineMeshes(combine:  null.ToArray(), mergeSubMeshes:  true, useMatrices:  true);
            val_25.Add(item:  new UnityEngine.Mesh());
            goto label_60;
            label_8:
            if(this.showDebugLogs != false)
            {
                    UnityEngine.Debug.LogError(message:  "No valid, meshed GameObjects were found in the target GameObjects list. Therefore the merge was interrupted.");
            }
            
            val_85 = 0;
            return val_85;
            label_40:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_94 = 1152921536163696832;
            val_95 = val_25;
            System.Collections.Generic.List<UnityEngine.CombineInstance> val_44 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
            List.Enumerator<T> val_45 = val_25.GetEnumerator();
            label_95:
            if(((-1754961232) & 1) == 0)
            {
                goto label_91;
            }
            
            string val_46 = val_29.丐丏七丌丕丗业且上();
            UnityEngine.Matrix4x4 val_47 = UnityEngine.Matrix4x4.identity;
            val_44.Add(item:  new UnityEngine.CombineInstance() {m_Transform = new UnityEngine.Matrix4x4(), m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
            goto label_95;
            label_91:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Mesh val_52 = new UnityEngine.Mesh();
            val_98 = mem[1152921541506603928];
            if(val_91 <= val_98)
            {
                    val_52.indexFormat = 0;
                val_98 = mem[1152921541506603928];
            }
            
            if(val_91 > val_98)
            {
                    val_52.indexFormat = 1;
            }
            
            val_52.name = this.gameObject.name + " (Temp Merge)";
            T[] val_56 = val_44.ToArray();
            val_99 = val_86;
            if(val_52 != null)
            {
                    val_52.CombineMeshes(combine:  val_56, mergeSubMeshes:  false);
            }
            else
            {
                    val_52.CombineMeshes(combine:  val_56, mergeSubMeshes:  false);
            }
            
            val_52.RecalculateBounds();
            if(mem[1152921541506603956] != false)
            {
                    val_52.RecalculateNormals();
            }
            
            if(mem[1152921541506603957] != false)
            {
                    val_52.RecalculateTangents();
            }
            
            this.gameObject.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_52;
            System.Collections.Generic.List<UnityEngine.Material> val_57 = new System.Collections.Generic.List<UnityEngine.Material>();
            Dictionary.Enumerator<TKey, TValue> val_58 = val_5.GetEnumerator();
            val_100 = 1152921541506347792;
            label_119:
            if(((-1754961088) & 1) == 0)
            {
                goto label_117;
            }
            
            ConfiguredValueTaskAwaiter val_62 = val_60.GetAwaiter();
            val_57.Add(item:  val_62._value._obj.丐丏七丌丕丗业且上());
            goto label_119;
            label_117:
            val_101 = 0;
            val_102 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_124;
            }
            
            if(( == 0) || (925 == 925))
            {
                goto label_173;
            }
            
            label_172:
            label_173:
            sharedMaterials = val_57.ToArray();
            val_103 = val_84;
            val_104 = mem[1152921541506603948];
            if(val_104 != 1)
            {
                goto label_129;
            }
            
            val_105 = 0;
            goto label_139;
            label_145:
            丅丞万丑万丒不丞丕[] val_65 = val_99 + 0;
            if(((val_4 + 0) + 32) == 0)
            {
                goto label_132;
            }
            
            val_94 = (val_4 + 0) + 32 + 16;
            if(((val_4 + 0) + 32 + 16) != 0)
            {
                goto label_140;
            }
            
            label_141:
            label_140:
            if(((val_4 + 0) + 32) == 0)
            {
                goto label_134;
            }
            
            if(((val_4 + 0) + 32 + 32) != 0)
            {
                goto label_142;
            }
            
            label_143:
            label_142:
            val_100 = (val_4 + 0) + 32 + 32.enabled;
            .下丐三丆丝与不丗丕 = val_94;
            .下丆丙丅丅与丏丗下 = (val_4 + 0) + 32 + 32;
            .三丂业丘丗丕丆丐世 = (val_4 + 0) + 32 + 16.activeSelf;
            .丑丕丆丅丁且丝丏不 = val_100;
            mem[1152921541506603936].Add(item:  new RuntimeMeshCombiner.上丁丄一丛丈丕丐丆());
            val_99 = val_86;
            (val_4 + 0) + 32 + 16.SetActive(value:  false);
            val_103 = val_84;
            val_105 = 1;
            goto label_139;
            label_132:
            if(11993091 != 0)
            {
                goto label_140;
            }
            
            goto label_141;
            label_134:
            if(64 != 0)
            {
                goto label_142;
            }
            
            goto label_143;
            label_139:
            if(val_105 < (val_4 + 24))
            {
                goto label_145;
            }
            
            if(mem[1152921541506603952] != false)
            {
                    UnityEngine.MeshCollider val_72 = this.gameObject.AddComponent<UnityEngine.MeshCollider>();
                val_103 = val_84;
            }
            
            val_104 = mem[1152921541506603948];
            label_129:
            if(val_104 != 0)
            {
                goto label_148;
            }
            
            val_106 = 0;
            goto label_158;
            label_164:
            丅丞万丑万丒不丞丕[] val_73 = val_99 + 0;
            if(((val_4 + 0) + 32) == 0)
            {
                goto label_151;
            }
            
            if(((val_4 + 0) + 32 + 16) != 0)
            {
                goto label_159;
            }
            
            label_160:
            label_159:
            if(((val_4 + 0) + 32) == 0)
            {
                goto label_153;
            }
            
            val_94 = (val_4 + 0) + 32;
            if(((val_4 + 0) + 32 + 32) != 0)
            {
                goto label_161;
            }
            
            label_162:
            label_161:
            val_100 = (val_4 + 0) + 32 + 32.enabled;
            .下丐三丆丝与不丗丕 = (val_4 + 0) + 32 + 16;
            .下丆丙丅丅与丏丗下 = (val_4 + 0) + 32 + 32;
            .三丂业丘丗丕丆丐世 = (val_4 + 0) + 32 + 16.activeSelf;
            .丑丕丆丅丁且丝丏不 = val_100;
            mem[1152921541506603936].Add(item:  new RuntimeMeshCombiner.上丁丄一丛丈丕丐丆());
            val_99 = val_86;
            (val_4 + 0) + 32 + 32.enabled = false;
            val_103 = val_84;
            val_106 = 1;
            goto label_158;
            label_151:
            if(11993091 != 0)
            {
                goto label_159;
            }
            
            goto label_160;
            label_153:
            if(64 != 0)
            {
                goto label_161;
            }
            
            goto label_162;
            label_158:
            if(val_106 < (val_4 + 24))
            {
                goto label_164;
            }
            
            label_148:
            val_84 = this.gameObject.transform;
            val_60 = 0;
            val_84.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.showDebugLogs != false)
            {
                    val_84 = "The merge has been successfully completed in Runtime Combiner \"" + this.gameObject.name + "\"!"("\"!");
                UnityEngine.Debug.Log(message:  val_84);
            }
            
            if(mem[1152921541506603976] != 0)
            {
                    mem[1152921541506603976].Invoke();
            }
            
            val_85 = true;
            this.丝不丗丘不丒丕丙不 = val_85;
            return val_85;
            label_124:
            if( != 0)
            {
                goto label_172;
            }
            
            goto label_173;
        }
        public bool UndoMerge()
        {
            var val_3;
            object val_23;
            丕丘丘万不丙丕与丐 val_24;
            var val_25;
            val_23 = this;
            if(this.丝不丗丘不丒丕丙不 == false)
            {
                goto label_1;
            }
            
            val_24 = this.afterMerge;
            if(val_24 != 0)
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_1 = this.丗丁丑丝丐业三丈丒.GetEnumerator();
            val_25 = 1152921541507107744;
            label_10:
            if(((-1754364096) & 1) == 0)
            {
                goto label_4;
            }
            
            if(X21 == 0)
            {
                goto label_10;
            }
            
            X21.enabled = (val_3.丐丏七丌丕丗业且上() != null) ? 1 : 0;
            goto label_10;
            label_1:
            if(this.showDebugLogs == false)
            {
                    return true;
            }
            
            val_23 = "The Runtime Combiner \"" + this.gameObject.name + "\" meshes are already uncombined!"("\" meshes are already uncombined!");
            UnityEngine.Debug.Log(message:  val_23);
            return true;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_24 = this.afterMerge;
            label_2:
            if(val_24 != 1)
            {
                goto label_40;
            }
            
            List.Enumerator<T> val_10 = this.丗丁丑丝丐业三丈丒.GetEnumerator();
            val_25 = 1152921541507106720;
            label_30:
            if(((-1754364096) & 1) == 0)
            {
                goto label_24;
            }
            
            if(val_11.m_stringLength == 0)
            {
                goto label_30;
            }
            
            val_11.m_stringLength.SetActive(value:  (val_3.丐丏七丌丕丗业且上() != null) ? 1 : 0);
            goto label_30;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.addMeshColliderAfter != false)
            {
                    UnityEngine.MeshCollider val_14 = this.GetComponent<UnityEngine.MeshCollider>();
                if(val_14 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  val_14);
            }
            
            }
            
            label_40:
            this.丗丁丑丝丐业三丈丒.Clear();
            UnityEngine.Object.Destroy(obj:  this.GetComponent<UnityEngine.MeshRenderer>());
            UnityEngine.Object.Destroy(obj:  this.GetComponent<UnityEngine.MeshFilter>());
            if(this.garbageCollectorAfterUndo != false)
            {
                    UnityEngine.AsyncOperation val_18 = UnityEngine.Resources.UnloadUnusedAssets();
                System.GC.Collect();
            }
            
            if(this.showDebugLogs != false)
            {
                    UnityEngine.Debug.Log(message:  "The Runtime Combiner \"" + this.gameObject.name + "\" merge was successfully undone!"("\" merge was successfully undone!"));
            }
            
            if(this.onDoneUnmerge != null)
            {
                    this.onDoneUnmerge.Invoke();
            }
            
            this.丝不丗丘不丒丕丙不 = false;
            return true;
        }
        public bool isTargetMeshesMerged()
        {
            return (bool)this.丝不丗丘不丒丕丙不;
        }
        public RuntimeMeshCombiner()
        {
            this.丙丌丌丁丂与丞丄丏 = 50000;
            this.丗丁丑丝丐业三丈丒 = new System.Collections.Generic.List<上丁丄一丛丈丕丐丆>();
            this.addMeshColliderAfter = true;
            this.recalculateNormals = true;
            this.recalculateTangents = true;
            this.targetMeshes = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this.showDebugLogs = true;
            this.garbageCollectorAfterUndo = true;
        }
    
    }

}
