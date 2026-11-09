using UnityEngine;

namespace NJG
{
    public class NJGMapBase : MonoBehaviour
    {
        // Fields
        public NJG.UIMiniMapBase miniMap;
        public NJG.UIWorldMapBase worldMap;
        private static NJG.NJGMapBase 丄丈丂丅上专万丞丏;
        private static UnityEngine.GameObject 业业万七丞丆丄丙不;
        public System.Action<string> onWorldNameChanged;
        public UnityEngine.Color zoneColor;
        public System.Collections.Generic.List<NJG.NJGMapBase.MapItemType> mapItems;
        public System.Collections.Generic.List<NJG.NJGMapBase.MapLevel> levels;
        public NJG.NJGMapBase.业丆丟丄三不丂一且 renderMode;
        public bool persistOnLevelLoad;
        public bool renderOnLevelLoad;
        public bool dontDestroy;
        public float dynamicRenderTime;
        public NJG.NJGMapBase.世丄丆丐丂丏专丐丟 orientation;
        public NJG.NJGMapBase.丝丈丙丗丞丟一丕万 screen;
        public UnityEngine.LayerMask renderLayers;
        public UnityEngine.LayerMask boundLayers;
        public int iconSize;
        public int borderSize;
        public int arrowSize;
        public float updateListFrequency;
        public float updatePositionFrequency;
        public float updateMapPositionFrequency;
        public UnityEngine.Vector3 customBounds;
        public UnityEngine.Vector3 customBoundsCenter;
        public UnityEngine.Bounds bounds;
        public float miniMapZoom;
        public float worldMapZoom;
        public float miniMapTextMultiplier;
        public float pixelSize;
        public bool typesFolded;
        public bool zonesFolded;
        public UnityEngine.Texture2D mapTexture;
        public UnityEngine.Texture2D userMapTexture;
        public bool runtimeGeneration;
        public bool generateAtStart;
        public UnityEngine.Camera cameraFrustum;
        public UnityEngine.Color cameraFrustumColor;
        public bool useTextureGenerated;
        public UnityEngine.FilterMode mapFilterMode;
        public UnityEngine.TextureWrapMode mapWrapMode;
        public NJG.NJGMapBase.丗与丅东丑万丑丟丕 textureFormat;
        public NJG.NJGMapBase.世丕三上丟上不丆世 cameraClearFlags;
        public UnityEngine.Color cameraBackgroundColor;
        public bool transparentTexture;
        public bool optimize;
        public bool generateMipmaps;
        public int boundsOffset;
        public int layer;
        public System.Collections.Generic.List<System.Action> queue;
        public const string VERSION = "1.5.6";
        public UnityEngine.Camera mCam;
        private UnityEngine.Vector2 丕不丆丝丝业七丁丏;
        private UnityEngine.Bounds 业丛丟三丌丈下不丄;
        private string mWorldName;
        private string 不且丞丐东东业一丗;
        private UnityEngine.Vector3 下丘一丕丕丐不丞世;
        private UnityEngine.Vector3 世丅且下东丙丂七丏;
        private float 丟丘丛丒不丁万七丟;
        private float 与与专业丄与丘丈丞;
        private System.Threading.Thread 专东丛与万丏丆专丘;
        private float 上七丆东三业丁丆丅;
        private UnityEngine.Terrain[] 丕丗丐丅丞丄丁丑丈;
        
        // Properties
        public static NJG.NJGMapBase 丄丘七三上丕世丞业 { get; }
        public static UnityEngine.GameObject 丛丝丑专三丏丛丈下 { get; set; }
        public string worldName { get; set; }
        public virtual bool 丆丌丌一丙世上丆丞 { get; }
        public UnityEngine.Vector3 mapOrigin { get; }
        public UnityEngine.Vector3 mapEulers { get; }
        public float ortoSize { get; }
        public float aspect { get; }
        public UnityEngine.Vector2 mapSize { get; set; }
        public float 三东丕丈丆丌丑万丞 { get; }
        public string[] mapItemTypes { get; }
        
        // Methods
        public static NJG.NJGMapBase get_instance()
        {
            string val_5;
            var val_6;
            val_5 = NJG.NJGMapBase.VERSION;
            if(val_5 != 0)
            {
                    return (NJG.NJGMapBase)NJG.NJGMapBase.VERSION;
            }
            
            val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_5);
            val_6 = 0;
            NJG.NJGMapBase.VERSION = ;
            return (NJG.NJGMapBase)NJG.NJGMapBase.VERSION;
        }
        public static UnityEngine.GameObject get_zonesRoot()
        {
            var val_3;
            if(NJG.NJGMapBase.业业万七丞丆丄丙不 == 0)
            {
                    val_3 = null;
                NJG.NJGMapBase.业业万七丞丆丄丙不 = UnityEngine.GameObject.Find(name:  "_MapZones");
                return (UnityEngine.GameObject)NJG.NJGMapBase.业业万七丞丆丄丙不;
            }
            
            val_3 = null;
            return (UnityEngine.GameObject)NJG.NJGMapBase.业业万七丞丆丄丙不;
        }
        public static void set_zonesRoot(UnityEngine.GameObject 丙业与丙丗丝不丈东)
        {
            NJG.NJGMapBase.业业万七丞丆丄丙不 = 丙业与丙丗丝不丈东;
        }
        public string get_worldName()
        {
            return (string)this.mWorldName;
        }
        public void set_worldName(string 丙业与丙丗丝不丈东)
        {
            this.mWorldName = 丙业与丙丗丝不丈东;
            if((System.String.op_Inequality(a:  this.不且丞丐东东业一丗, b:  丙业与丙丗丝不丈东)) == false)
            {
                    return;
            }
            
            this.不且丞丐东东业一丗 = this.mWorldName;
            if(this.onWorldNameChanged == null)
            {
                    return;
            }
            
            this.onWorldNameChanged.Invoke(obj:  this.mWorldName);
        }
        public virtual bool get_isMouseOver()
        {
            NJG.UIMiniMapBase val_6 = NJG.UIMiniMapBase.inst;
            if(val_6 == 0)
            {
                    return true;
            }
            
            val_6 = NJG.UIMiniMapBase.inst;
            if(val_6.isMouseOver == true)
            {
                    return true;
            }
            
            val_6 = NJG.UIWorldMapBase.inst;
            if(val_6 == 0)
            {
                    return true;
            }
            
            NJG.UIWorldMapBase val_5 = NJG.UIWorldMapBase.inst;
            if(val_5 != null)
            {
                    return val_5.isMouseOver;
            }
            
            return val_5.isMouseOver;
        }
        public UnityEngine.Vector3 get_mapOrigin()
        {
            if(NJGMapRenderer.instance == 0)
            {
                    return new UnityEngine.Vector3() {x = this.下丘一丕丕丐不丞世};
            }
            
            UnityEngine.Vector3 val_5 = NJGMapRenderer.instance.cachedTransform.position;
            this.下丘一丕丕丐不丞世 = val_5;
            mem[1152921541451797116] = val_5.y;
            mem[1152921541451797120] = val_5.z;
            return new UnityEngine.Vector3() {x = this.下丘一丕丕丐不丞世};
        }
        public UnityEngine.Vector3 get_mapEulers()
        {
            if(NJGMapRenderer.instance == 0)
            {
                    return new UnityEngine.Vector3() {x = this.世丅且下东丙丂七丏};
            }
            
            UnityEngine.Vector3 val_5 = NJGMapRenderer.instance.cachedTransform.eulerAngles;
            this.世丅且下东丙丂七丏 = val_5;
            mem[1152921541451933704] = val_5.y;
            mem[1152921541451933708] = val_5.z;
            return new UnityEngine.Vector3() {x = this.世丅且下东丙丂七丏};
        }
        public float get_ortoSize()
        {
            if(NJGMapRenderer.instance == 0)
            {
                    return (float)this.丟丘丛丒不丁万七丟;
            }
            
            this.丟丘丛丒不丁万七丟 = NJGMapRenderer.instance.GetComponent<UnityEngine.Camera>().orthographicSize;
            return (float)this.丟丘丛丒不丁万七丟;
        }
        public float get_aspect()
        {
            if(NJGMapRenderer.instance == 0)
            {
                    return (float)this.与与专业丄与丘丈丞;
            }
            
            this.与与专业丄与丘丈丞 = NJGMapRenderer.instance.GetComponent<UnityEngine.Camera>().aspect;
            return (float)this.与与专业丄与丘丈丞;
        }
        public void set_mapSize(UnityEngine.Vector2 丙业与丙丗丝不丈东)
        {
            this.丕不丆丝丝业七丁丏 = 丙业与丙丗丝不丈东;
            mem[1152921541452331084] = 丙业与丙丗丝不丈东.y;
        }
        public UnityEngine.Vector2 get_mapSize()
        {
            UnityEngine.Vector2 val_4;
            if(UnityEngine.Application.isPlaying != false)
            {
                    val_4 = this.丕不丆丝丝业七丁丏;
                this.丕不丆丝丝业七丁丏 = (float)UnityEngine.Screen.width;
                mem[1152921541452443084] = (float)UnityEngine.Screen.height;
                return new UnityEngine.Vector2() {x = this.丕不丆丝丝业七丁丏.x};
            }
            
            val_4 = this.丕不丆丝丝业七丁丏;
            return new UnityEngine.Vector2() {x = this.丕不丆丝丝业七丁丏.x};
        }
        public float get_elapsed()
        {
            return (float)this.上七丆东三业丁丆丅;
        }
        public string[] get_mapItemTypes()
        {
            var val_7;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            int val_2 = this.mapItems.Count;
            if(val_2 >= 1)
            {
                    var val_7 = 0;
                do
            {
                MapItemType val_3 = this.mapItems.Item[0];
                val_1.Add(item:  val_3.type);
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            }
            
            if(val_1.Count != 0)
            {
                    val_7 = val_1.ToArray();
                return (System.String[])val_7;
            }
            
            val_7 = new string[1];
            val_7[0] = "No types defined";
            return (System.String[])val_7;
        }
        private void Awake()
        {
            var val_11;
            var val_12;
            if(this.miniMap == 0)
            {
                    UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
                val_11 = 0;
                this.miniMap = ;
            }
            
            if(this.worldMap == 0)
            {
                    UnityEngine.Object val_7 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
                val_12 = 0;
                this.worldMap = ;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.mapTexture != 0)
            {
                    丁丒丐丂万三丌万业.Destroy(万且万且丑丗且丌丆:  this.mapTexture);
            }
            
            if(this.generateAtStart == false)
            {
                    return;
            }
            
            this.GenerateMap();
        }
        public void GenerateMap()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    if(this.runtimeGeneration == true)
            {
                goto label_3;
            }
            
            }
            
            if(UnityEngine.Application.isPlaying == true)
            {
                    return;
            }
            
            if(this.runtimeGeneration != false)
            {
                    return;
            }
            
            label_3:
            NJGMapRenderer.instance.Render();
        }
        private void Start()
        {
            if(this.onWorldNameChanged != null)
            {
                    this.onWorldNameChanged.Invoke(obj:  this.mWorldName);
            }
            
            this.UpdateBounds();
            bool val_1 = UnityEngine.Application.isPlaying;
        }
        private void 东丏丙丟丕东下世丏()
        {
            var val_4;
            System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
            if(val_1 == null)
            {
                goto label_14;
            }
            
            label_13:
            val_1.Reset();
            goto label_2;
            label_14:
            val_1.Reset();
            label_2:
            val_1.Start();
            val_4 = null;
            val_4 = null;
            if((NJGMapBase.<>c.<>9__99_0) == null)
            {
                goto label_5;
            }
            
            label_12:
            this.queue.ForEach(action:  NJGMapBase.<>c.<>9__99_0);
            if(val_1 == null)
            {
                goto label_7;
            }
            
            val_1.Stop();
            goto label_8;
            label_5:
            NJGMapBase.<>c.<>9__99_0 = new System.Action<System.Action>(object:  NJGMapBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NJGMapBase.<>c::丏万东七丂一丕丆不(System.Action 丆丛丑世下一丐且丕));
            if(this.queue != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_7:
            val_1.Stop();
            label_8:
            float val_4 = (float)val_1.ElapsedMilliseconds;
            val_4 = val_4 * 0.001f;
            this.上七丆东三业丁丆丅 = val_4;
            System.Threading.Thread.Sleep(millisecondsTimeout:  1);
            if(val_1 != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        public void SetTexture(UnityEngine.Texture2D 丟三丟三丅专丂丄丂)
        {
            if(NJG.UIMiniMapBase.inst != 0)
            {
                    NJG.UIMiniMapBase.inst.material.mainTexture = 丟三丟三丅专丂丄丂;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(NJG.UIWorldMapBase.inst == 0)
            {
                    return;
            }
            
            NJG.UIWorldMapBase.inst.material.mainTexture = 丟三丟三丅专丂丄丂;
        }
        public static bool IsInRenderLayers(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.LayerMask 丟世丟丐且丐丟七上)
        {
            int val_3 = 万且万且丑丗且丌丆.layer & 31;
            val_3 = 1 << val_3;
            return (bool)(val_3 > 丟世丟丐且丐丟七上.m_Mask.GetHashCode()) ? 1 : 0;
        }
        public void UpdateBounds()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((UnityEngine.Resources.Load<ScenMapBounds>(path:  "MiniMaps/"("MiniMaps/") + val_1.m_Handle.name)) != null)
            {
                    mem[1152921541453756236] = 1152921541453726944;
                this.bounds = val_4.bounds;
                this.miniMapZoom = val_4.miniMapZoom;
                this.worldMapZoom = val_4.worldMapZoom;
            }
            else
            {
                    mem[1152921541453756236] = 1152921541453726944;
                this.bounds = val_4.bounds;
                this.miniMapZoom = 0f;
                this.worldMapZoom = val_4.worldMapZoom;
            }
            
            this.miniMapTextMultiplier = val_4.miniMapTextMultiplier;
        }
        public void CalcBounds()
        {
            var val_12;
            float val_13;
            float val_21;
            float val_49;
            float val_50;
            int val_51;
            var val_52;
            float val_53;
            UnityEngine.Object val_54;
            float val_57;
            UnityEngine.Bounds val_60;
            UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if((val_2 == null) || (val_2.Length < 1))
            {
                goto label_6;
            }
            
            val_49 = -1000000f;
            val_50 = -10000f;
            val_51 = val_2.Length & 4294967295;
            val_52 = 0;
            val_53 = 1f;
            goto label_7;
            label_47:
            val_51 = val_2.Length;
            val_52 = 1;
            label_7:
            val_54 = X22.layer;
            if((val_54 == this.gameObject.layer) || ((NJG.NJGMapBase.IsInRenderLayers(万且万且丑丗且丌丆:  X22, 丟世丟丐且丐丟七上:  new UnityEngine.LayerMask() {m_Mask = this.boundLayers})) == false))
            {
                goto label_43;
            }
            
            if((0 & 255) == 0)
            {
                goto label_13;
            }
            
            label_23:
            val_54 = X22.GetComponent<UnityEngine.Renderer>();
            if(val_54 == 0)
            {
                goto label_43;
            }
            
            if(val_54 == null)
            {
                goto label_18;
            }
            
            UnityEngine.Bounds val_11 = val_54.bounds;
            goto label_19;
            label_13:
            UnityEngine.Vector3 val_15 = X22.transform.position;
            val_12 = 0;
            val_13 = 0f;
            mem2[0] = val_12;
            mem2[0] = val_13;
            if(X22 != 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_18:
            UnityEngine.Bounds val_16 = val_54.bounds;
            label_19:
            UnityEngine.Bounds val_17 = val_54.bounds;
            UnityEngine.Bounds val_19 = val_54.bounds;
            float val_48 = val_21;
            val_48 = 0f - val_48;
            if(val_48 < 0)
            {
                    UnityEngine.Bounds val_22 = val_54.bounds;
                UnityEngine.Bounds val_23 = val_54.bounds;
                val_57 = 0f;
                float val_24 = val_13 - val_57;
                string val_25 = X22.name;
            }
            
            UnityEngine.Bounds val_26 = val_54.bounds;
            UnityEngine.Bounds val_27 = val_54.bounds;
            float val_49 = 0f;
            val_49 = val_13 + val_49;
            if(val_49 > val_50)
            {
                    UnityEngine.Bounds val_28 = val_54.bounds;
                UnityEngine.Bounds val_29 = val_54.bounds;
                val_57 = 0f;
                val_50 = val_13 + val_57;
                string val_30 = X22.name;
            }
            
            UnityEngine.Bounds val_31 = val_54.bounds;
            UnityEngine.Bounds val_32 = val_54.bounds;
            if((V1.16B - S1) < 0)
            {
                    UnityEngine.Bounds val_34 = val_54.bounds;
                UnityEngine.Bounds val_35 = val_54.bounds;
                val_57 = V1.16B;
                float val_36 = V1.16B - val_57;
                string val_37 = X22.name;
            }
            
            UnityEngine.Bounds val_38 = val_54.bounds;
            UnityEngine.Bounds val_39 = val_54.bounds;
            if((V1.16B + S1) > val_49)
            {
                    UnityEngine.Bounds val_41 = val_54.bounds;
                UnityEngine.Bounds val_42 = val_54.bounds;
                val_57 = V1.16B;
                val_49 = V1.16B + val_57;
                string val_43 = X22.name;
            }
            
            label_43:
            if((val_51 - 1) != val_52)
            {
                goto label_47;
            }
            
            if((0 & 1) != 0)
            {
                goto label_48;
            }
            
            label_6:
            UnityEngine.Vector3 val_47 = this.gameObject.transform.position;
            val_53 = val_47.x;
            val_57 = val_47.z;
            val_12 = 0;
            val_13 = 0;
            val_60 = this.业丛丟三丌丈下不丄;
            mem[1152921541454031664] = val_12;
            this.业丛丟三丌丈下不丄 = val_13;
            goto label_51;
            label_48:
            val_60 = this.业丛丟三丌丈下不丄;
            label_51:
            val_13 = 0;
        }
        public static T CreateAsset<T>(string 丘丙丟丟丁丄丄丕丑)
        {
            return 0;
        }
        public void UpdateRenderSize()
        {
            float val_4 = this.pixelSize;
            val_4 = ((this.orientation == 0) ? (S2) : (S1)) / val_4;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  S0 / val_4, y:  val_4);
            this.丕不丆丝丝业七丁丏 = val_3.x;
            mem[1152921541454418908] = val_3.y;
        }
        public string[] GetZones(string 丈丘丝一丗下丈丐不)
        {
            var val_12;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(this.levels != null)
            {
                    int val_2 = this.levels.Count;
                if(val_2 >= 1)
            {
                    var val_13 = 0;
                do
            {
                MapLevel val_3 = this.levels.Item[0];
                if((System.String.op_Equality(a:  val_3.level, b:  丈丘丝一丗下丈丐不)) != false)
            {
                    MapLevel val_5 = this.levels.Item[0];
                int val_6 = val_5.zones.Count;
                if(val_6 >= 1)
            {
                    var val_12 = 0;
                do
            {
                MapLevel val_7 = this.levels.Item[0];
                MapZone val_8 = val_7.zones.Item[0];
                val_1.Add(item:  val_8.type);
                val_12 = val_12 + 1;
            }
            while(val_6 != val_12);
            
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 != val_2);
            
            }
            
            }
            
            if(val_1.Count != 0)
            {
                    val_12 = val_1.ToArray();
                return (System.String[])val_12;
            }
            
            val_12 = new string[1];
            val_12[0] = "No Zones defined";
            return (System.String[])val_12;
        }
        public string[] GetLevels()
        {
            var val_7;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(this.levels != null)
            {
                    int val_2 = this.levels.Count;
                if(val_2 >= 1)
            {
                    var val_7 = 0;
                do
            {
                MapLevel val_3 = this.levels.Item[0];
                val_1.Add(item:  val_3.level);
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            }
            
            }
            
            if(val_1.Count != 0)
            {
                    val_7 = val_1.ToArray();
                return (System.String[])val_7;
            }
            
            val_7 = new string[1];
            val_7[0] = "No Levels defined";
            return (System.String[])val_7;
        }
        public UnityEngine.Color GetZoneColor(string 丈丘丝一丗下丈丐不, string 业丂万丈丝七一与专)
        {
            string val_12;
            UnityEngine.Color val_13;
            float val_14;
            float val_15;
            float val_16;
            val_12 = 业丂万丈丝七一与专;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_13 = val_1.r;
            val_14 = val_1.g;
            val_15 = val_1.b;
            val_16 = val_1.a;
            int val_2 = this.levels.Count;
            if(val_2 < 1)
            {
                    return new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = val_16};
            }
            
            var val_13 = 0;
            label_17:
            MapLevel val_3 = this.levels.Item[0];
            if((System.String.op_Equality(a:  val_3.level, b:  丈丘丝一丗下丈丐不)) == false)
            {
                goto label_9;
            }
            
            MapLevel val_5 = this.levels.Item[0];
            int val_6 = val_5.zones.Count;
            if(val_6 < 1)
            {
                goto label_9;
            }
            
            var val_12 = 0;
            label_16:
            MapLevel val_7 = this.levels.Item[0];
            MapZone val_8 = val_7.zones.Item[0];
            if((val_8.type.Equals(value:  val_12)) == true)
            {
                goto label_15;
            }
            
            val_12 = val_12 + 1;
            if(val_12 < val_6)
            {
                goto label_16;
            }
            
            label_9:
            val_13 = val_13 + 1;
            if(val_13 < val_2)
            {
                goto label_17;
            }
            
            return new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = val_16};
            label_15:
            MapLevel val_10 = this.levels.Item[0];
            val_12 = val_10.zones.Item[0];
            val_13 = val_11.color;
            return new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = val_16};
        }
        public bool GetInteraction(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.enableInteraction == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.enableInteraction == true) ? 1 : 0;
        }
        public UnityEngine.Color GetColor(int 丁丅丈丌丟世丗丗丟)
        {
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return UnityEngine.Color.white;
            }
            
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) != null)
            {
                    return new UnityEngine.Color() {r = val_2.color};
            }
            
            return new UnityEngine.Color() {r = val_2.color};
        }
        public bool GetAnimateOnVisible(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.animateOnVisible == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.animateOnVisible == true) ? 1 : 0;
        }
        public bool GetAnimateOnAction(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.showOnAction == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.showOnAction == true) ? 1 : 0;
        }
        public bool GetLoopAnimation(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.loopAnimation == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.loopAnimation == true) ? 1 : 0;
        }
        public bool GetHaveArrow(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.haveArrow == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.haveArrow == true) ? 1 : 0;
        }
        public float GetFadeOutAfter(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) != null)
            {
                    val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3 = 丁丅丈丌丟世丗丗丟);
                if(val_3 != null)
            {
                    return 0f;
            }
            
                return 0f;
            }
            
            return 0f;
        }
        public bool GetRotate(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.rotate == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.rotate == true) ? 1 : 0;
        }
        public bool GetUpdatePosition(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.updatePosition == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.updatePosition == true) ? 1 : 0;
        }
        public int GetSize(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3;
            int val_4;
            val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return val_4;
            }
            
            val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3);
            val_4 = val_2.size;
            return val_4;
        }
        public int GetArrowSize(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3;
            int val_4;
            val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return val_4;
            }
            
            val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3);
            val_4 = val_2.sizeArrow;
            return val_4;
        }
        public int GetBorderSize(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3;
            int val_4;
            val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return val_4;
            }
            
            val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3);
            val_4 = val_2.borderSize;
            return val_4;
        }
        public bool GetCustom(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.useCustomSize == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.useCustomSize == true) ? 1 : 0;
        }
        public bool GetCustomArrow(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.useCustomArrowSize == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.useCustomArrowSize == true) ? 1 : 0;
        }
        public bool GetCustomBorder(int 丁丅丈丌丟世丗丗丟)
        {
            int val_4 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (bool)(val_2.useCustomBorderSize == true) ? 1 : 0;
            }
            
            val_4 = this.Get(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟);
            return (bool)(val_2.useCustomBorderSize == true) ? 1 : 0;
        }
        public int GetDepth(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3;
            int val_4;
            val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return val_4;
            }
            
            val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3);
            val_4 = val_2.depth;
            return val_4;
        }
        public int GetArrowDepth(int 丁丅丈丌丟世丗丗丟)
        {
            int val_3;
            int val_4;
            val_3 = 丁丅丈丌丟世丗丗丟;
            if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return val_4;
            }
            
            val_3 = this.Get(丁丅丈丌丟世丗丗丟:  val_3);
            val_4 = val_2.arrowDepth;
            return val_4;
        }
        public NJG.NJGMapBase.MapItemType Get(int 丁丅丈丌丟世丗丗丟)
        {
            if(丁丅丈丌丟世丗丗丟 == 1)
            {
                    return 0;
            }
            
            if(this.mapItems.Count < 丁丅丈丌丟世丗丗丟)
            {
                    return 0;
            }
            
            if(this.mapItems != null)
            {
                    return this.mapItems.Item[丁丅丈丌丟世丗丗丟];
            }
            
            return this.mapItems.Item[丁丅丈丌丟世丗丗丟];
        }
        public NJG.NJGMapBase.MapItemType Get(string 丁丅丈丌丟世丗丗丟)
        {
            string val_5;
            System.Collections.Generic.List<MapItemType> val_6;
            var val_7;
            val_5 = 丁丅丈丌丟世丗丗丟;
            val_6 = this.mapItems;
            int val_1 = val_6.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_6 = 0;
            label_7:
            MapItemType val_2 = this.mapItems.Item[0];
            if((val_2.type.Equals(value:  val_5)) == true)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < val_1)
            {
                goto label_7;
            }
            
            label_2:
            val_7 = 0;
            return (MapItemType)val_5.Item[0];
            label_6:
            val_5 = this.mapItems;
            return (MapItemType)val_5.Item[0];
        }
        public int GetMapItemTypeIndex(string 丁丅丈丌丟世丗丗丟)
        {
            string val_5;
            var val_6;
            val_5 = 丁丅丈丌丟世丗丗丟;
            int val_1 = this.mapItems.Count;
            if(val_1 >= 1)
            {
                    val_6 = 0;
                do
            {
                MapItemType val_2 = this.mapItems.Item[0];
                if((val_2.type.Equals(value:  val_5)) == true)
            {
                    return (int)val_6;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_1);
            
            }
            
            val_5 = "Type: "("Type: ") + val_5 + " not found!"(" not found!");
            UnityEngine.Debug.LogError(message:  val_5);
            val_6 = 0;
            return (int)val_6;
        }
        public NJGMapBase()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.zoneColor = val_1;
            mem[1152921541458010388] = val_1.g;
            mem[1152921541458010392] = val_1.b;
            mem[1152921541458010396] = val_1.a;
            MapItemType[] val_2 = new MapItemType[1];
            .type = "None";
            val_2[0] = new NJGMapBase.MapItemType();
            this.mapItems = new System.Collections.Generic.List<MapItemType>(collection:  val_2);
            this.levels = new System.Collections.Generic.List<MapLevel>();
            this.dynamicRenderTime = 1f;
            UnityEngine.LayerMask val_6 = UnityEngine.LayerMask.op_Implicit(intVal:  1);
            this.renderLayers = val_6;
            UnityEngine.LayerMask val_7 = UnityEngine.LayerMask.op_Implicit(intVal:  1);
            this.boundLayers = val_7;
            this.iconSize = 68719476752;
            this.borderSize = 16;
            this.arrowSize = 16;
            this.updateListFrequency = 5.510186E-41f;
            this.updatePositionFrequency = 0.01f;
            this.updateMapPositionFrequency = 7.714148E-41f;
            this.customBounds = 0;
            mem[1152921541458010476] = 0;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.customBoundsCenter = val_8;
            mem[1152921541458010484] = val_8.y;
            this.miniMapZoom = 1;
            mem[1152921541458010488] = val_8.z;
            this.generateAtStart = true;
            this.cameraFrustumColor = 0;
            mem[1152921541458010572] = 0;
            mem[1152921541458010580] = 0;
            this.mapFilterMode = ;
            UnityEngine.Color val_9 = UnityEngine.Color.red;
            this.cameraBackgroundColor = val_9;
            mem[1152921541458010608] = val_9.g;
            mem[1152921541458010612] = val_9.b;
            mem[1152921541458010616] = val_9.a;
            this.boundsOffset = 10;
            this.queue = new System.Collections.Generic.List<System.Action>();
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  1024f, y:  1024f);
            this.丕不丆丝丝业七丁丏 = val_11.x;
            mem[1152921541458010652] = val_11.y;
            this.mWorldName = "My Epic World";
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            this.下丘一丕丕丐不丞世 = val_13;
            mem[1152921541458010700] = val_13.y;
            mem[1152921541458010704] = val_13.z;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            this.世丅且下东丙丂七丏 = val_15;
            mem[1152921541458010712] = val_15.y;
            mem[1152921541458010716] = val_15.z;
        }
    
    }

}
