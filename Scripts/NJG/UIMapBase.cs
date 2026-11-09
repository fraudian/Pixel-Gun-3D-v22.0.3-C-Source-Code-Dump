using UnityEngine;

namespace NJG
{
    public abstract class UIMapBase : MonoBehaviour
    {
        // Fields
        public NJG.UIMapBase.丘丄丞且上丙上专丕 iconsUpdated;
        public NJG.NJGMapBase.丑丁丒丗丘丞丄丞且 shaderType;
        public UnityEngine.Texture maskTexture;
        public float mapBorderRadius;
        public UnityEngine.Vector2 margin;
        public NJG.UIMapBase.七丐与七丌不丂丞且 pivot;
        protected float mBaseZoom;
        protected float 三丏丐丗丒七丟丈丄;
        public float complexZoom;
        public float scaleOnMovingFactor;
        public float zoomAmount;
        public UnityEngine.Transform target;
        public string targetTag;
        public UnityEngine.Transform iconRootParent;
        public float minZoom;
        public float maxZoom;
        public float zoomSpeed;
        public UnityEngine.KeyCode zoomInKey;
        public UnityEngine.KeyCode zoomOutKey;
        public bool limitBounds;
        public bool rotateWithPlayer;
        public bool mouseWheelEnabled;
        public bool panning;
        public 丆丟上丝且三上丂丆 panningEasing;
        public float panningSpeed;
        public float panningSensitivity;
        public bool panningMoveBack;
        public UnityEngine.KeyCode[] keysInUse;
        public UnityEngine.Vector2 panningPosition;
        public float mapAngle;
        public UnityEngine.Vector2 scrollPosition;
        public bool drawDirectionalLines;
        public UnityEngine.Shader linesShader;
        public int linePoints;
        public UnityEngine.Color lineColor;
        public float lineWidth;
        public System.Collections.Generic.List<UnityEngine.Transform> controlPoints;
        public bool calculateBorder;
        public bool tapOnMap;
        protected bool 丙丒丄丅丝三丙丛三;
        private bool <不丘三东下丞丑丏一>k__BackingField;
        protected UnityEngine.Transform mMapTrans;
        protected UnityEngine.Vector3 mZoom;
        protected System.Collections.Generic.List<NJG.UIMapIconBase> mList;
        protected UnityEngine.Transform mIconRoot;
        protected UnityEngine.Transform mTrans;
        protected UnityEngine.Vector2 mMapScale;
        protected UnityEngine.Vector2 mMapHalfScale;
        protected UnityEngine.Vector2 mIconScale;
        protected UnityEngine.Matrix4x4 mMatrix;
        protected UnityEngine.Matrix4x4 rMatrix;
        protected bool mMapScaleChanged;
        protected int mDepth;
        protected UnityEngine.Vector3 丑一丞丁丗丏丛下万;
        protected UnityEngine.Vector3 且专丄丞丙丙丛丙丆;
        protected int 专业丁丆不东丙丞不;
        private float 丑不丈丝丞丞上丙丅;
        private float 丛丌丙东业丛丐丌丟;
        private float 上业上专丌丄三丌丞;
        protected UnityEngine.Texture 丗丑且且丌丛专丝丈;
        protected System.Collections.Generic.List<NJG.UIMapIconBase> 丄东丄丕与丈丅丛万;
        protected int 与丌万丛丒丏丘东丝;
        protected NJG.NJGMapBase 丞丁丑丏丄丏七丂不;
        protected bool 丄丁丑丞丅一三丌丆;
        protected UnityEngine.Renderer mRenderer;
        protected UnityEngine.Color mColor;
        protected UnityEngine.Quaternion 与三丐丛不东业专丈;
        protected UnityEngine.Vector3 丘丛专世万万丁丙一;
        private 丆丟上丝且三上丂丆 mZoomEasing;
        private UnityEngine.Vector2 丙丕专丏丆丄世丈丁;
        private bool 专丛丌丄一丞丕丘丑;
        protected UnityEngine.Vector3 业丘丁且丛且丞东专;
        private int 东丅一与丒丑丛丛丟;
        private UnityEngine.Vector3 mArrScale;
        private UnityEngine.Camera 三世丘与业丏丄丏丙;
        private bool 东一与专丛三丗万世;
        private UnityEngine.Transform 万丛丛丆一丏丌与万;
        private UnityEngine.LineRenderer 丄丆三丐丛丒丆下东;
        protected UnityEngine.Vector2 mMapScaleSize;
        protected bool 丟七丞丈丞丁业专业;
        protected UnityEngine.Vector3 丙丟丟东丂万丘一不;
        private UnityEngine.Vector3 与丂不丐丘三丄丞丗;
        protected UnityEngine.Vector2 丗三丆丏业与下丛东;
        private UnityEngine.GameObject 下丐丗丁三丘丗丒丈;
        private UnityEngine.Mesh 丙丌丟世丛丂丗丟丈;
        private UnityEngine.Material 丞丏与世丄三上专业;
        private int 专丐丅丂丗丒丕三丆;
        private int 不业丄丛丕一丂三丅;
        private UnityEngine.Color 丒下丈丞七下丁世上;
        private float 丒丘丞丏丙丒上与下;
        private UnityEngine.Vector3 业且丂且下一丆丆丌;
        private UnityEngine.Vector3 丘丈丈丁不丕丝丂丁;
        private UnityEngine.Vector2 专专丒丝丟专业丞丕;
        protected UnityEngine.Vector2 不与丈与七丗丗丛丐;
        protected UnityEngine.Transform 丙专万丙丏业下丛丛;
        private UnityEngine.Animation 三上下丁丅丅下上丑;
        private bool 丒万丞丒丙万丌丂七;
        private bool 下专丐丗专万不丏且;
        
        // Properties
        public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
        public virtual UnityEngine.Color 且丙七丝丕东丕丑上 { get; set; }
        public float 上世东专丅丙一世与 { get; set; }
        public float 丁上万丝丛不东与且 { get; set; }
        protected virtual UnityEngine.Vector3 丛丗下丆专丛丆丏三 { get; }
        public 丆丟上丝且三上丂丆 zoomEasing { get; set; }
        protected bool 丟丘下丕丒且丝且丈 { get; set; }
        public UnityEngine.Transform 下丒丕丒丟丆丟丒丄 { get; }
        public virtual bool 丆丌丌一丙世上丆丞 { get; set; }
        public virtual UnityEngine.Transform 下世丝三东下东万业 { get; }
        public virtual UnityEngine.Renderer 丕三丗丛丝丛下丁一 { get; set; }
        public virtual UnityEngine.Vector2 丌一丛丛丁三丂丝上 { get; set; }
        public virtual UnityEngine.Vector2 且丅丘丑丆丞丘不丄 { get; }
        public virtual UnityEngine.Material material { get; set; }
        public int 丟丕丞丁丝丂上丄上 { get; set; }
        public virtual UnityEngine.Vector3 丙三丄丄丙丐下专不 { get; }
        public bool 不与万丌一丈下丑丈 { get; }
        public bool 丙丐专七丗丝丟东丗 { get; }
        public bool 且丟丙丙丈万丌丁丏 { get; }
        
        // Methods
        public UnityEngine.Transform get_cachedTransform()
        {
            UnityEngine.Transform val_3;
            if(this.mTrans == 0)
            {
                    this.mTrans = this.transform;
                return val_3;
            }
            
            val_3 = this.mTrans;
            return val_3;
        }
        public virtual UnityEngine.Color get_mapColor()
        {
            return new UnityEngine.Color() {r = this.mColor};
        }
        public virtual void set_mapColor(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            this.mColor = 丙业与丙丗丝不丈东;
            mem[1152921541460092228] = 丙业与丙丗丝不丈东.g;
            mem[1152921541460092232] = 丙业与丙丗丝不丈东.b;
            mem[1152921541460092236] = 丙业与丙丗丝不丈东.a;
            this.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
        }
        public float get_zoom()
        {
            return (float)this.mBaseZoom;
        }
        public void set_zoom(float 丙业与丙丗丝不丈东)
        {
            if(this.mBaseZoom != 丙业与丙丗丝不丈东)
            {
                    this.丙丒丄丅丝三丙丛三 = true;
            }
            
            this.mBaseZoom = 丙业与丙丗丝不丈东;
            丙业与丙丗丝不丈东 = this.三丏丐丗丒七丟丈丄 * 丙业与丙丗丝不丈东;
            this.complexZoom = 丙业与丙丗丝不丈东;
        }
        public float get_scaleOnMoving()
        {
            return (float)this.三丏丐丗丒七丟丈丄;
        }
        public void set_scaleOnMoving(float 丙业与丙丗丝不丈东)
        {
            float val_1 = this.mBaseZoom;
            val_1 = val_1 * 丙业与丙丗丝不丈东;
            this.三丏丐丗丒七丟丈丄 = 丙业与丙丗丝不丈东;
            this.complexZoom = val_1;
        }
        protected virtual UnityEngine.Vector3 丟丏一一万丝下丟丑()
        {
            if(this.target != null)
            {
                    return this.target.forward;
            }
            
            return this.target.forward;
        }
        public void set_zoomEasing(丆丟上丝且三上丂丆 丙业与丙丗丝不丈东)
        {
            this.mZoomEasing = 丙业与丙丗丝不丈东;
        }
        public 丆丟上丝且三上丂丆 get_zoomEasing()
        {
            return (丆丟上丝且三上丂丆)this.mZoomEasing;
        }
        protected bool 丝且丐东不丘丞且丂()
        {
            return (bool)this.丙丒丄丅丝三丙丛三;
        }
        protected void 丛业专丒丘丏丁七丗(bool 丙业与丙丗丝不丈东)
        {
            this.丙丒丄丅丝三丙丛三 = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Transform get_iconRoot()
        {
            if(this.mIconRoot != 0)
            {
                    return (UnityEngine.Transform)this.mIconRoot;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (UnityEngine.Transform)this.mIconRoot;
            }
            
            this.mIconRoot = this;
            return (UnityEngine.Transform)this.mIconRoot;
        }
        protected virtual UnityEngine.Transform 丕丏一七专三丘丁丒()
        {
            UnityEngine.Transform val_3 = 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject).transform;
            if(this != 0)
            {
                    val_3.parent = this.parent;
                UnityEngine.Vector3 val_6 = this.localPosition;
                UnityEngine.Vector3 val_7 = this.localPosition;
                val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_8 = this.localEulerAngles;
                val_3.localEulerAngles = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            }
            
            if(val_3 != null)
            {
                    val_3.name = "_MapIcons";
            }
            else
            {
                    0.name = "_MapIcons";
            }
            
            UIPanel val_10 = val_3.gameObject.AddComponent<UIPanel>();
            if(val_10 != null)
            {
                    val_10.depth = 30;
            }
            else
            {
                    val_10.depth = 30;
            }
            
            val_10.renderQueue = 0;
            return val_3;
        }
        public virtual bool get_isMouseOver()
        {
            return (bool)this.<不丘三东下丞丑丏一>k__BackingField;
        }
        public virtual void set_isMouseOver(bool 丙业与丙丗丝不丈东)
        {
            this.<不丘三东下丞丑丏一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual UnityEngine.Transform get_rendererTransform()
        {
            UnityEngine.Object val_5 = 0;
            if(this != val_5)
            {
                    val_5 = 0;
                if(this.mMapTrans == val_5)
            {
                    val_5 = 0;
                this.mMapTrans = this.transform;
            }
            
            }
            
            if(this != 0)
            {
                    return (UnityEngine.Transform)this.mMapTrans;
            }
            
            return this.transform;
        }
        public virtual UnityEngine.Renderer get_planeRenderer()
        {
            UnityEngine.Renderer val_7;
            UnityEngine.Renderer val_8;
            if(this.mRenderer == 0)
            {
                    val_7 = this.gameObject.GetComponent<UnityEngine.Renderer>();
                this.mRenderer = val_7;
            }
            else
            {
                    val_7 = this.mRenderer;
            }
            
            if(val_7 == 0)
            {
                    this.mRenderer = this.gameObject.GetComponentInChildren<UnityEngine.Renderer>();
                return val_8;
            }
            
            val_8 = this.mRenderer;
            return val_8;
        }
        public virtual void set_planeRenderer(UnityEngine.Renderer 丙业与丙丗丝不丈东)
        {
            this.mRenderer = 丙业与丙丗丝不丈东;
        }
        public virtual UnityEngine.Vector2 get_mapScale()
        {
            UnityEngine.Vector3 val_1 = this.localScale;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public virtual void set_mapScale(UnityEngine.Vector2 丙业与丙丗丝不丈东)
        {
            this.mMapScaleChanged = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y});
            this.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public virtual UnityEngine.Vector2 get_mapHalfScale()
        {
            if(this.mMapScaleChanged == false)
            {
                    return new UnityEngine.Vector2() {x = this.mMapHalfScale};
            }
            
            this.mMapScaleChanged = false;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, d:  0.5f);
            this.mMapHalfScale = val_1;
            mem[1152921541462400308] = val_1.y;
            return new UnityEngine.Vector2() {x = this.mMapHalfScale};
        }
        public virtual UnityEngine.Material get_material()
        {
            bool val_1 = UnityEngine.Application.isPlaying;
            if(this != null)
            {
                    if(val_1 == false)
            {
                    return this.sharedMaterial;
            }
            
                return this.material;
            }
            
            if(val_1 == true)
            {
                    return this.material;
            }
            
            return this.sharedMaterial;
        }
        public virtual void set_material(UnityEngine.Material 丙业与丙丗丝不丈东)
        {
            this.material = 丙业与丙丗丝不丈东;
        }
        public int get_depth()
        {
            this.renderQueue = this.mDepth + 3000;
            return (int)this.mDepth;
        }
        public void set_depth(int 丙业与丙丗丝不丈东)
        {
            if(this.mDepth == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this.mDepth = 丙业与丙丗丝不丈东;
            this.renderQueue = this.mDepth + 3000;
        }
        public virtual UnityEngine.Vector3 get_arrowScale()
        {
            NJG.NJGMapBase val_1;
            if(this.东丅一与丒丑丛丛丟 == this.丞丁丑丏丄丏七丂不.arrowSize)
            {
                    return new UnityEngine.Vector3() {x = (float)this.丞丁丑丏丄丏七丂不.arrowSize, y = (float)this.丞丁丑丏丄丏七丂不.arrowSize};
            }
            
            val_1 = this.丞丁丑丏丄丏七丂不;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            this.东丅一与丒丑丛丛丟 = this.丞丁丑丏丄丏七丂不.arrowSize;
            goto label_4;
            label_3:
            val_1 = this.丞丁丑丏丄丏七丂不;
            this.东丅一与丒丑丛丛丟 = this.丞丁丑丏丄丏七丂不.arrowSize;
            if(this.丞丁丑丏丄丏七丂不 == null)
            {
                goto label_5;
            }
            
            label_4:
            mem[1152921541462981104] = (float)this.丞丁丑丏丄丏七丂不.arrowSize;
            this.mArrScale = (float)this.丞丁丑丏丄丏七丂不.arrowSize;
            return new UnityEngine.Vector3() {x = (float)this.丞丁丑丏丄丏七丂不.arrowSize, y = (float)this.丞丁丑丏丄丏七丂不.arrowSize};
            label_5:
        }
        public bool get_isVisible()
        {
            UnityEngine.Transform val_5;
            if(this.丙专万丙丏业下丛丛 != 0)
            {
                goto label_3;
            }
            
            val_5 = this.cachedTransform.GetChild(index:  0);
            this.丙专万丙丏业下丛丛 = val_5;
            if(val_5 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_3:
            val_5 = this.丙专万丙丏业下丛丛;
            if(val_5 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            UnityEngine.GameObject val_4 = val_5.gameObject;
            if(val_4 != null)
            {
                    return val_4.activeInHierarchy;
            }
            
            return val_4.activeInHierarchy;
        }
        public bool get_isMouseOut()
        {
            var val_7;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            if(val_1.x <= (float)UnityEngine.Screen.width)
            {
                    if(val_1.y <= (float)UnityEngine.Screen.height)
            {
                    val_7 = ((val_1.y < 0) ? 1 : 0) | ((val_1.x < 0) ? 1 : 0);
                return (bool)val_7;
            }
            
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        protected virtual void 丌业丄专丙东丟丙专()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            int val_2 = this.mList.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            int val_3 = val_2 + 1;
            do
            {
                NJG.UIMapIconBase val_5 = this.mList.Item[val_3 - 2];
                val_3 = val_3 - 1;
            }
            while(val_3 > 1);
        
        }
        public virtual NJG.UIMapIconBase GetEntry(NJGMapItem 业业丙且东丒业世丟)
        {
            return 0;
        }
        protected virtual void 丂丞丏丒万丟丁且七(NJG.UIMapIconBase 丕丏丑丁东丄丂与东)
        {
            bool val_1 = this.mList.Remove(item:  丕丏丑丁东丄丂与东);
            this.丄东丄丕与丈丅丛万.Add(item:  丕丏丑丁东丄丂与东);
            丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丕丏丑丁东丄丂与东.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        protected virtual void OnEnable()
        {
            System.Action val_8;
            if(UnityEngine.Application.isPlaying != false)
            {
                    if(this.丞丁丑丏丄丏七丂不 == 0)
            {
                    return;
            }
            
                this.renderQueue = this.depth + 3000;
                System.Action val_5 = null;
                val_8 = val_5;
                val_5 = new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0);
                if((this.丞丁丑丏丄丏七丂不.queue.Contains(item:  val_5)) != true)
            {
                    System.Action val_7 = null;
                val_8 = val_7;
                val_7 = new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0);
                this.丞丁丑丏丄丏七丂不.queue.Add(item:  val_7);
            }
            
            }
            
            this.丙丒丄丅丝三丙丛三 = true;
            goto typeof(NJG.UIMapBase).__il2cppRuntimeField_318;
        }
        protected virtual void OnDisable()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if((this.丞丁丑丏丄丏七丂不.queue.Contains(item:  new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0))) == false)
            {
                    return;
            }
            
            bool val_5 = this.丞丁丑丏丄丏七丂不.queue.Remove(item:  new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0));
        }
        protected virtual void OnDestroy()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if((this.丞丁丑丏丄丏七丂不.queue.Contains(item:  new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0))) == false)
            {
                    return;
            }
            
            bool val_5 = this.丞丁丑丏丄丏七丂不.queue.Remove(item:  new System.Action(object:  this, method:  typeof(NJG.UIMapBase).__il2cppRuntimeField_2F0));
        }
        protected virtual void 世丐丕三丞一丂三且(NJGMapItem 下丅丙一丂丗丅丝七)
        {
        
        }
        protected virtual void Awake()
        {
            var val_25;
            string val_26;
            this.mMapScaleChanged = true;
            this.hasChanged = true;
            this.丞丁丑丏丄丏七丂不 = NJG.NJGMapBase.instance;
            this.mTrans = this.transform;
            this.三世丘与业丏丄丏丙 = 丁丒丐丂万三丌万业.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
            if(this == 0)
            {
                goto label_5;
            }
            
            if(this.shaderType == 1)
            {
                goto label_6;
            }
            
            if(this.shaderType != 0)
            {
                goto label_11;
            }
            
            val_25 = this;
            val_26 = "NinjutsuGames/Map TextureMask";
            goto label_8;
            label_5:
            UnityEngine.Debug.Log(message:  "material == null");
            goto label_11;
            label_6:
            val_25 = this;
            val_26 = "NinjutsuGames/Map ColorMask";
            label_8:
            this.shader = UnityEngine.Shader.Find(name:  val_26);
            label_11:
            if(this.maskTexture == 0)
            {
                    if(this != 0)
            {
                    this.maskTexture = this.GetTexture(name:  "_Mask");
            }
            
            }
            
            if(this.drawDirectionalLines == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.linesShader == 0)
            {
                    this.linesShader = UnityEngine.Shader.Find(name:  "Particles/Additive");
            }
            
            UnityEngine.GameObject val_15 = 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject);
            UnityEngine.Transform val_16 = val_15.transform;
            this.万丛丛丆一丏丌与万 = val_16;
            val_16.parent = this.iconRoot;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            this.万丛丛丆一丏丌与万.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            this.万丛丛丆一丏丌与万.localEulerAngles = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.LineRenderer val_20 = val_15.GetComponent<UnityEngine.LineRenderer>();
            this.丄丆三丐丛丒丆下东 = val_20;
            if(val_20 == 0)
            {
                    UnityEngine.LineRenderer val_22 = val_15.AddComponent<UnityEngine.LineRenderer>();
            }
            
            UnityEngine.LineRenderer val_23 = val_15.GetComponent<UnityEngine.LineRenderer>();
            this.丄丆三丐丛丒丆下东 = val_23;
            val_23.useWorldSpace = true;
            this.丄丆三丐丛丒丆下东.material = new UnityEngine.Material(shader:  this.linesShader);
            this.万丛丛丆一丏丌与万.name = "_Lines";
        }
        protected virtual void Start()
        {
            UnityEngine.Texture2D val_12;
            this.丞丁丑丏丄丏七丂不 = NJG.NJGMapBase.instance;
            if(this != 0)
            {
                goto label_3;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_7;
            }
            
            UnityEngine.Debug.LogWarning(message:  "The UITexture does not have a material assigned", context:  this);
            UnityEngine.Debug.Log(message:  "material == null");
            goto label_7;
            label_3:
            if(this.丞丁丑丏丄丏七丂不.runtimeGeneration == false)
            {
                goto label_9;
            }
            
            val_12 = this.丞丁丑丏丄丏七丂不.mapTexture;
            if(this != null)
            {
                goto label_26;
            }
            
            label_27:
            label_26:
            this.mainTexture = val_12;
            if(this.maskTexture != 0)
            {
                    val_12 = this;
                this.SetTexture(name:  "_Mask", value:  this.maskTexture);
            }
            
            this.color = new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B};
            label_7:
            if((UnityEngine.Application.isPlaying == false) || (this.丙专万丙丏业下丛丛 != 0))
            {
                goto typeof(NJG.UIMapBase).__il2cppRuntimeField_318;
            }
            
            UnityEngine.Transform val_9 = this.cachedTransform;
            if(this.cachedTransform.childCount < 1)
            {
                goto label_22;
            }
            
            this.丙专万丙丏业下丛丛 = val_9.GetChild(index:  0);
            goto typeof(NJG.UIMapBase).__il2cppRuntimeField_318;
            label_9:
            NJG.NJGMapBase val_11 = NJG.NJGMapBase.instance;
            if(this != null)
            {
                goto label_26;
            }
            
            goto label_27;
            label_22:
            this.丙专万丙丏业下丛丛 = val_9;
            goto typeof(NJG.UIMapBase).__il2cppRuntimeField_318;
        }
        protected virtual void 丕下且业与七下下丂()
        {
            UnityEngine.Debug.Log(message:  "UpdateCode ");
        }
        public void UpdateScrollPosition(bool 丆丁与丆丏专丏不东 = False)
        {
            UnityEngine.Transform val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            var val_35;
            float val_36;
            val_24 = this.target;
            if(val_24 == 0)
            {
                    if(this.丟七丞丈丞丁业专业 == true)
            {
                    return;
            }
            
                if(丆丁与丆丏专丏不东 == true)
            {
                    return;
            }
            
            }
            
            val_25 = this.complexZoom;
            if(this.丟七丞丈丞丁业专业 == true)
            {
                goto label_7;
            }
            
            val_27 = V8.16B;
            if(丆丁与丆丏专丏不东 == false)
            {
                goto label_8;
            }
            
            label_7:
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.scrollPosition = val_2;
            mem[1152921541465032448] = val_2.y;
            UnityEngine.Vector3 val_3 = this.target.position;
            val_26 = val_3.y;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_26, z = val_3.z});
            UnityEngine.Bounds val_20 = this.丞丁丑丏丄丏七丂不.bounds;
            float val_21 = 0.5f;
            val_20 = val_21 / val_20;
            val_21 = val_21 / V2.16B;
            val_4.x = val_4.x * val_20;
            this.与丂不丐丘三丄丞丗 = val_20;
            mem[1152921541465032948] = val_21 / V1.16B;
            mem[1152921541465032952] = val_21;
            this.scrollPosition = val_4.x;
            val_27 = ((this.丞丁丑丏丄丏七丂不.orientation == 0) ? 1152921541465032952 : 1152921541465032948) * ((this.丞丁丑丏丄丏七丂不.orientation == 0) ? val_4.z : val_4.y);
            mem[1152921541465032448] = val_27;
            val_25 = val_25;
            label_8:
            val_30 = 1f;
            if(this.panning != false)
            {
                    UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_27}, b:  new UnityEngine.Vector2() {x = this.panningPosition, y = val_26});
                val_27 = val_8.y;
                this.scrollPosition = val_8;
                mem[1152921541465032448] = val_27;
            }
            
            val_25 = val_30 / val_25;
            if(this.limitBounds == false)
            {
                goto label_18;
            }
            
            if(this.丟七丞丈丞丁业专业 == true)
            {
                goto label_19;
            }
            
            val_31 = 0f;
            if(丆丁与丆丏专丏不东 == false)
            {
                goto label_20;
            }
            
            label_19:
            float val_22 = -0.2f;
            val_22 = val_25 + val_22;
            val_31 = val_22 / 6f;
            label_20:
            float val_9 = val_30 - val_25;
            val_32 = val_9 * 0.5f;
            val_9 = val_9 * (-0.5f);
            val_26 = val_9 - val_31;
            float val_10 = UnityEngine.Mathf.Max(a:  val_26, b:  this.scrollPosition);
            val_31 = val_32 + val_31;
            this.scrollPosition = val_10;
            this.scrollPosition = UnityEngine.Mathf.Min(a:  val_31, b:  val_10);
            float val_23 = UnityEngine.Mathf.Max(a:  val_26, b:  val_10);
            mem[1152921541465032448] = val_23;
            val_30 = UnityEngine.Mathf.Min(a:  val_31, b:  val_23);
            mem[1152921541465032448] = val_30;
            if(this.panning == false)
            {
                goto label_23;
            }
            
            val_26 = this.panningPosition;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_27}, b:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_30});
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26, y = V2.16B}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            this.panningPosition = val_15;
            mem[1152921541465032436] = val_15.y;
            goto label_27;
            label_18:
            val_32 = (val_30 - val_25) * 0.5f;
            goto label_27;
            label_23:
            val_27 = val_30;
            label_27:
            UnityEngine.Vector2 val_24 = this.scrollPosition;
            val_23 = val_32 + val_27;
            val_24 = val_32 + val_24;
            mem[1152921541465032732] = 0;
            mem[1152921541465032516] = val_25;
            mem[1152921541465032520] = val_25;
            this.mZoom = val_25;
            mem[1152921541465032728] = val_23;
            this.且专丄丞丙丙丛丙丆 = val_24;
            val_33 = ???;
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_33}, b:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_26});
            val_24 = 1152921504838422528;
            val_34 = val_17.x;
            val_35 = null;
            val_35 = null;
            val_36 = UnityEngine.Mathf.Epsilon;
            if(val_34 > val_36)
            {
                    val_36 = this.scrollPosition;
                val_33 = ???;
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_36, y = val_33}, b:  new UnityEngine.Vector2() {x = this.scrollPosition, y = val_34});
            }
            else
            {
                    UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
            }
            
            this.丗三丆丏业与下丛东 = val_19;
            mem[1152921541465032960] = val_19.y;
        }
        protected virtual void 丂丟丘丐丕丝丙一丌(UnityEngine.Vector2 丟专丅丏专丒丐丘七)
        {
            UnityEngine.Vector2 val_11;
            float val_12;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if(((-1796375432) & 1) != 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_11 = this.不与丈与七丗丗丛丐;
            float val_11 = val_2.x;
            val_12 = val_2.z;
            int val_3 = this.mList.Count;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_2.x = 丟专丅丏专丒丐丘七.x * val_11;
            int val_5 = val_3 + 1;
            val_11 = val_11 * val_2.x;
            val_12 = S14 * (丟专丅丏专丒丐丘七.y * val_12);
            do
            {
                if(val_7.isValid != false)
            {
                    UnityEngine.Transform val_8 = this.mList.Item[val_5 - 2].cachedTransform;
                UnityEngine.Vector3 val_9 = val_8.localPosition;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_2.z});
                val_11 = val_10.y;
                val_8.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_11, z = val_10.z};
            }
            
                val_5 = val_5 - 1;
            }
            while(val_5 > 1);
        
        }
        protected virtual void 丝丌万丄丕下下丄丅()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            var val_40;
            var val_41;
            var val_42;
            UnityEngine.Matrix4x4 val_43;
            var val_58;
            UnityEngine.Vector3 val_59;
            UnityEngine.Vector3 val_60;
            float val_61;
            float val_62;
            float val_67;
            val_58 = this;
            val_59 = this.且专丄丞丙丙丛丙丆;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            val_61 = val_1.y;
            val_62 = val_1.w;
            UnityEngine.Matrix4x4 val_2 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_59, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_1.x, y = val_61, z = val_1.z, w = val_62}, s:  new UnityEngine.Vector3() {x = this.mZoom, y = ???});
            if(this.rotateWithPlayer == false)
            {
                goto label_5;
            }
            
            float val_58 = val_4;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.forward;
            val_58 = ((val_58 < 0) ? 1f : -1f) * (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_58, y = 0f, z = val_6}, to:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}));
            this.mapAngle = val_58;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_58);
            this.与三丐丛不东业专丈 = val_10;
            mem[1152921541465380132] = val_10.y;
            mem[1152921541465380136] = val_10.z;
            mem[1152921541465380140] = val_10.w;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = this.丘丛专世万万丁丙一, y = val_8.y, z = val_8.z});
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_14 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, q:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, s:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_17 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, q:  new UnityEngine.Quaternion() {x = this.与三丐丛不东业专丈, y = val_12.x, z = val_12.y, w = val_12.z}, s:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.z});
            val_60 = this.丘丛专世万万丁丙一;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
            val_61 = val_22.y;
            val_62 = val_22.w;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_24 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_60, y = val_15.y, z = this.与三丐丛不东业专丈}, q:  new UnityEngine.Quaternion() {x = val_22.x, y = val_61, z = val_22.z, w = val_62}, s:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.z});
            UnityEngine.Matrix4x4 val_29 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_27, m10 = val_27, m20 = val_27, m30 = val_27, m01 = val_28, m11 = val_28, m21 = val_28, m31 = val_28, m02 = val_25, m12 = val_25, m22 = val_25, m32 = val_25, m03 = val_26, m13 = val_26, m23 = val_26, m33 = val_26});
            UnityEngine.Matrix4x4 val_34 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_32, m10 = val_32, m20 = val_32, m30 = val_32, m01 = val_33, m11 = val_33, m21 = val_33, m31 = val_33, m02 = val_30, m12 = val_30, m22 = val_30, m32 = val_30, m03 = val_31, m13 = val_31, m23 = val_31, m33 = val_31}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_20, m10 = val_20, m20 = val_20, m30 = val_20, m01 = val_21, m11 = val_21, m21 = val_21, m31 = val_21, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_19, m13 = val_19, m23 = val_19, m33 = val_19});
            UnityEngine.Matrix4x4 val_39 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_37, m10 = val_37, m20 = val_37, m30 = val_37, m01 = val_38, m11 = val_38, m21 = val_38, m31 = val_38, m02 = val_35, m12 = val_35, m22 = val_35, m32 = val_35, m03 = val_36, m13 = val_36, m23 = val_36, m33 = val_36}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4});
            mem[1152921541465380000] = val_41;
            mem[1152921541465379984] = val_40;
            mem[1152921541465379968] = val_42;
            this.rMatrix = val_43;
            if((this.mMatrix & 1) == 0)
            {
                    m03 = this.rMatrix.m03;
                m02 = this.rMatrix.m02;
                m01 = this.rMatrix.m01;
                mem2[0] = this.rMatrix.m00;
                val_4 = this.rMatrix.m03;
                val_3 = this.rMatrix.m02;
                val_6 = this.rMatrix.m01;
                val_5 = this.rMatrix.m00;
                this.SetMatrix(name:  "_Matrix", value:  new UnityEngine.Matrix4x4() {m00 = val_5, m01 = val_6, m02 = val_3, m03 = val_4});
            }
            
            if(this.iconRoot == 0)
            {
                    return;
            }
            
            mem[1152921541465380180] = -this.mapAngle;
            UnityEngine.Vector3 val_47 = this.iconRoot.localEulerAngles;
            val_61 = this.业丘丁且丛且丞东专;
            val_60 = val_47.x;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_60, y = val_47.y, z = val_47.z}, rhs:  new UnityEngine.Vector3() {x = val_61, y = val_22.x, z = this.与三丐丛不东业专丈})) == false)
            {
                    return;
            }
            
            val_60 = this.业丘丁且丛且丞东专;
            val_58 = this.iconRoot;
            if(val_58 != null)
            {
                goto label_34;
            }
            
            goto label_22;
            label_5:
            if((this.mMatrix & 1) != 0)
            {
                    return;
            }
            
            m03 = val_4;
            m02 = val_3;
            m01 = val_6;
            mem2[0] = val_5;
            val_3 = val_3;
            val_4 = val_4;
            val_5 = val_5;
            val_6 = val_6;
            this.SetMatrix(name:  "_Matrix", value:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4});
            if(this.iconRoot == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_53 = this.iconRoot.localEulerAngles;
            val_60 = val_53.x;
            val_59 = val_53.z;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_60, y = val_53.y, z = val_59}, rhs:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z})) == false)
            {
                    return;
            }
            
            val_58 = this.iconRoot;
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.zero;
            val_60 = val_57.x;
            val_67 = val_57.y;
            val_59 = val_57.z;
            if(val_58 != null)
            {
                goto label_34;
            }
            
            label_22:
            label_34:
            val_58.localEulerAngles = new UnityEngine.Vector3() {x = val_60, y = val_67, z = val_59};
        }
        protected virtual void Update()
        {
            UnityEngine.Object val_23;
            UnityEngine.Object val_24;
            UnityEngine.Object val_25;
            float val_26;
            NJG.NJGMapBase val_27;
            float val_28;
            float val_29;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_23 = this.target;
            val_24 = 0;
            if(val_23 == val_24)
            {
                    val_23 = this.targetTag;
                val_24 = 0;
            }
            
            bool val_4 = System.String.IsNullOrEmpty(value:  val_23).isMouseOut;
            if((this.target != 0) && (this.controlPoints.Count == 0))
            {
                    if((this.controlPoints.Contains(item:  this.target)) != true)
            {
                    this.controlPoints.Add(item:  this.target);
            }
            
            }
            
            val_25 = 0;
            if((this.target == val_25) && (this.专丛丌丄一丞丕丘丑 != true))
            {
                    this.专丛丌丄一丞丕丘丑 = true;
            }
            
            if((this.mouseWheelEnabled != false) && ((this & 1) != 0))
            {
                    val_25 = 0;
                float val_9 = UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel");
                if(val_9 != 0f)
            {
                    if((double)val_9 > 0.1)
            {
                    val_26 = this.zoomAmount;
                this.ZoomIn(丛丁三世世丆七不业:  val_26);
            }
            else
            {
                    if((double)val_9 < 0)
            {
                    val_26 = this.zoomAmount;
                this.ZoomOut(丛丁三世世丆七不业:  val_26);
            }
            
            }
            
            }
            
            }
            
            if(this.panning != false)
            {
                    this.丝丗不丘万丞丑丝丏();
            }
            
            int val_10 = UnityEngine.Screen.height;
            val_27 = this;
            UnityEngine.Vector3 val_11 = this.localScale;
            val_28 = this.丑一丞丁丗丏丛下万;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_28, y = V9.16B, z = V8.16B}, rhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) != false)
            {
                    this.mMapScaleChanged = true;
                val_27 = this;
                UnityEngine.Vector3 val_13 = this.localScale;
                this.丑一丞丁丗丏丛下万 = val_13;
                mem[1152921541465611148] = val_13.y;
                mem[1152921541465611152] = val_13.z;
                if(this.calculateBorder != false)
            {
                    val_27 = this;
                UnityEngine.Vector3 val_14 = this.localScale;
                val_14.x = val_14.x * 0.5f;
                val_28 = val_14.x * 0.25f;
                this.mapBorderRadius = val_28;
            }
            
            }
            
            float val_15 = UnityEngine.Time.time;
            if(this.丑不丈丝丞丞上丙丅 >= 0)
            {
                    if(this.丙丒丄丅丝三丙丛三 == false)
            {
                goto label_34;
            }
            
            }
            
            this.专业丁丆不东丙丞不 = val_10;
            val_27 = this.丞丁丑丏丄丏七丂不;
            float val_23 = this.丞丁丑丏丄丏七丂不.updateListFrequency;
            val_23 = val_23 * this.三丏丐丗丒七丟丈丄;
            val_28 = UnityEngine.Time.time + val_23;
            this.丑不丈丝丞丞上丙丅 = val_28;
            label_34:
            float val_17 = UnityEngine.Time.time;
            if(this.上业上专丌丄三丌丞 >= 0)
            {
                    if(this.丙丒丄丅丝三丙丛三 == false)
            {
                goto label_39;
            }
            
            }
            
            val_27 = this.丞丁丑丏丄丏七丂不;
            float val_24 = this.丞丁丑丏丄丏七丂不.updateMapPositionFrequency;
            val_24 = val_24 * this.三丏丐丗丒七丟丈丄;
            val_24 = UnityEngine.Time.time + val_24;
            this.上业上专丌丄三丌丞 = val_24;
            this.UpdateScrollPosition(丆丁与丆丏专丏不东:  false);
            val_28 = this.丗三丆丏业与下丛东;
            this.ComputeWorldTransform();
            if(this.iconsUpdated != null)
            {
                    this.iconsUpdated.Invoke();
            }
            
            label_39:
            val_29 = this.丛丌丙东业丛丐丌丟;
            float val_19 = UnityEngine.Time.time;
            if(val_29 >= 0)
            {
                    if(this.丙丒丄丅丝三丙丛三 == false)
            {
                goto label_49;
            }
            
            }
            
            val_27 = this.丞丁丑丏丄丏七丂不;
            val_29 = UnityEngine.Time.time;
            float val_25 = this.丞丁丑丏丄丏七丂不.updatePositionFrequency;
            val_25 = val_25 * this.三丏丐丗丒七丟丈丄;
            val_25 = val_29 + val_25;
            this.丛丌丙东业丛丐丌丟 = val_25;
            this.丘丗丘东一丟下与三();
            if(this.drawDirectionalLines != false)
            {
                    this.丗丗丘丈三丞下丆丟();
            }
            
            if(this.专业丁丆不东丙丞不 == val_10)
            {
                    if((this & 1) == 0)
            {
                goto label_49;
            }
            
            }
            
            NJG.NJGMapBase val_21 = NJG.NJGMapBase.instance;
            if(val_21.renderMode != 0)
            {
                    NJG.NJGMapBase.instance.GenerateMap();
            }
            
            label_49:
            if(this.丙丒丄丅丝三丙丛三 == false)
            {
                    return;
            }
            
            this.丙丒丄丅丝三丙丛三 = false;
        }
        protected virtual void 丌丁丕丌专丅丑丄与()
        {
            if((UnityEngine.Input.GetKeyDown(key:  this.zoomInKey)) != false)
            {
                    this.ZoomIn(丛丁三世世丆七不业:  this.zoomAmount);
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  this.zoomOutKey)) == false)
            {
                    return;
            }
            
            this.ZoomOut(丛丁三世世丆七不业:  this.zoomAmount);
        }
        protected virtual void 丁业三上丛丐且专东()
        {
        
        }
        protected virtual bool 丑丈丆万丅上丞丗丐()
        {
            return false;
        }
        protected bool 七七业丒丟丝丘不丞(UnityEngine.Vector2 下业丕七东丌丝下且)
        {
            if((下业丕七东丌丝下且.x - this.mapBorderRadius) < (-下业丕七东丌丝下且.x))
            {
                    return false;
            }
            
            float val_2 = 下业丕七东丌丝下且.x + this.mapBorderRadius;
            if(val_2 > (-下业丕七东丌丝下且.x))
            {
                    return false;
            }
            
            if((下业丕七东丌丝下且.y - this.mapBorderRadius) < (-val_2))
            {
                    return false;
            }
            
            var val_5 = ((下业丕七东丌丝下且.y + this.mapBorderRadius) <= (-val_2)) ? 1 : 0;
            return false;
        }
        protected void 丘丗丘东一丟下与三()
        {
            int val_5;
            int val_1 = this.mList.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            int val_2 = val_1 + 1;
            do
            {
                val_5 = val_2 - 2;
                NJG.UIMapIconBase val_3 = this.mList.Item[val_5];
                if(val_3.isValid != false)
            {
                    val_5 = val_3.item;
                if(val_3.item.type > 0)
            {
                
            }
            else
            {
                    val_3.isValid = false;
            }
            
            }
            
                val_2 = val_2 - 1;
            }
            while(val_2 > 1);
        
        }
        protected virtual void 上丘且丙东下不丂万()
        {
            var val_18;
            var val_19;
            var val_20;
            int val_1 = this.mList.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            int val_2 = val_1 + 1;
            label_24:
            NJG.UIMapIconBase val_4 = this.mList.Item[val_2 - 2];
            val_4.isValid = false;
            if(this.drawDirectionalLines == false)
            {
                goto label_22;
            }
            
            if(val_4.item.cachedTransform == this.target)
            {
                goto label_9;
            }
            
            bool val_8 = this.controlPoints.Contains(item:  val_4.cachedTransform);
            if(val_4.item.drawDirection == false)
            {
                goto label_12;
            }
            
            if(val_8 == true)
            {
                goto label_22;
            }
            
            this.controlPoints.Add(item:  val_4.cachedTransform);
            goto label_22;
            label_9:
            if(this.controlPoints.Item[0] == val_4.cachedTransform)
            {
                goto label_22;
            }
            
            this.controlPoints.set_Item(index:  0, value:  val_4.cachedTransform);
            goto label_22;
            label_12:
            if(val_8 != false)
            {
                    bool val_15 = this.controlPoints.Remove(item:  val_4.cachedTransform);
            }
            
            label_22:
            val_2 = val_2 - 1;
            if(val_2 > 1)
            {
                goto label_24;
            }
            
            label_2:
            val_18 = 0;
            goto label_25;
            label_34:
            val_19 = null;
            val_19 = null;
            NJGMapItem val_16 = NJGMapItem.list.Item[0];
            val_18 = 1;
            label_25:
            val_20 = null;
            val_20 = null;
            if(val_18 < NJGMapItem.list.Count)
            {
                goto label_34;
            }
        
        }
        protected virtual void 且丈业丕一且丝下上(NJG.UIMapIconBase 丞丐丗丄下世丆丂丗)
        {
            var val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            var val_32;
            val_25 = this;
            if(丞丐丗丄下世丆丂丗.item == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = 丞丐丗丄下世丆丂丗.item.cachedTransform.position;
            UnityEngine.Vector2 val_4 = this.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_26 = 0f;
            val_25 = 丞丐丗丄下世丆丂丗.cachedTransform;
            if(丞丐丗丄下世丆丂丗.item.updatePosition != false)
            {
                    UnityEngine.Vector3 val_7 = val_25.localPosition;
                val_27 = 0f;
                val_28 = val_7.x;
                val_29 = val_7.y;
                val_26 = val_7.z;
                if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_26}, rhs:  new UnityEngine.Vector3() {x = val_27, y = 0f, z = 0f})) != false)
            {
                    val_28 = 0f;
                val_29 = 0f;
                val_26 = 0f;
                val_25.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            }
            
            if(丞丐丗丄下世丆丂丗.item.rotate == false)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_11 = 丞丐丗丄下世丆丂丗.item.cachedTransform.forward;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            val_27 = val_12.y;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_27, z = val_12.z}, rhs:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_18 = 丞丐丗丄下世丆丂丗.item.cachedTransform.forward;
            val_30 = val_18.z;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.forward;
            val_31 = (((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, rhs:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z})) > 0f) ? -1f : 1f) * (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_30}, to:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}));
            if(val_25 == null)
            {
                goto label_24;
            }
            
            UnityEngine.Vector3 val_21 = val_25.localEulerAngles;
            val_32 = val_21.x;
            goto label_25;
            label_15:
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
            val_31 = val_22.x;
            val_30 = val_22.z;
            val_25.localRotation = new UnityEngine.Quaternion() {x = val_31, y = val_22.y, z = val_30, w = val_22.w};
            return;
            label_24:
            UnityEngine.Vector3 val_23 = 0.localEulerAngles;
            val_32 = val_23.x;
            label_25:
            UnityEngine.Vector3 val_24 = val_25.localEulerAngles;
            val_25.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected virtual void 业丕丘专丂丌丟一丟()
        {
            UnityEngine.Material val_35;
            UnityEngine.Mesh val_36;
            UnityEngine.Mesh val_37;
            NJG.NJGMapBase val_38;
            float val_39;
            val_35 = this;
            val_36 = 1152921504848912384;
            if(this.丞丁丑丏丄丏七丂不.cameraFrustum == 0)
            {
                    return;
            }
            
            if(this.丞丁丑丏丄丏七丂不.orientation == 1)
            {
                    return;
            }
            
            if(this.丙丌丟世丛丂丗丟丈 != 0)
            {
                goto label_9;
            }
            
            this.下丐丗丁三丘丗丒丈 = new UnityEngine.GameObject();
            this.丞丏与世丄三上专业 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "NinjutsuGames/Map TextureMask"));
            this.下丐丗丁三丘丗丒丈.AddComponent<UnityEngine.MeshRenderer>().material = this.丞丏与世丄三上专业;
            this.下丐丗丁三丘丗丒丈.name = "_Frustum";
            UnityEngine.Transform val_7 = this.下丐丗丁三丘丗丒丈.transform;
            val_7.parent = this.iconRoot;
            val_7.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_7.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.下丐丗丁三丘丗丒丈.layer = this.gameObject.layer;
            val_37 = 丁丒丐丂万三丌万业.一丗东世专与丐丒一();
            this.下丐丗丁三丘丗丒丈.AddComponent<UnityEngine.MeshFilter>().mesh = val_37;
            this.丙丌丟世丛丂丗丟丈 = val_37;
            if(val_37 != null)
            {
                goto label_26;
            }
            
            goto label_25;
            label_9:
            val_37 = this.丙丌丟世丛丂丗丟丈;
            if(val_37 != null)
            {
                goto label_26;
            }
            
            label_25:
            label_26:
            UnityEngine.Vector3[] val_15 = val_37.vertices;
            int val_16 = UnityEngine.Screen.width;
            int val_17 = UnityEngine.Screen.height;
            float val_18 = this.丞丁丑丏丄丏七丂不.cameraFrustum.farClipPlane;
            var val_19 = (val_17 < 0) ? (val_17 + 1) : (val_17);
            val_19 = val_19 >> 1;
            UnityEngine.Vector3 val_20 = this.丞丁丑丏丄丏七丂不.cameraFrustum.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15[1] = val_20;
            val_15[2] = val_20.y;
            val_15[2] = val_20.z;
            int val_21 = UnityEngine.Screen.width;
            int val_22 = UnityEngine.Screen.height;
            float val_23 = this.丞丁丑丏丄丏七丂不.cameraFrustum.nearClipPlane;
            var val_24 = (val_22 < 0) ? (val_22 + 1) : (val_22);
            val_24 = val_24 >> 1;
            UnityEngine.Vector3 val_25 = this.丞丁丑丏丄丏七丂不.cameraFrustum.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15[3] = val_25;
            val_15[3] = val_25.y;
            val_15[4] = val_25.z;
            int val_26 = UnityEngine.Screen.height;
            float val_27 = this.丞丁丑丏丄丏七丂不.cameraFrustum.nearClipPlane;
            var val_28 = (val_26 < 0) ? (val_26 + 1) : (val_26);
            val_28 = val_28 >> 1;
            UnityEngine.Vector3 val_29 = this.丞丁丑丏丄丏七丂不.cameraFrustum.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15[4] = val_29;
            val_15[5] = val_29.y;
            val_15[5] = val_29.z;
            int val_30 = UnityEngine.Screen.height;
            float val_31 = this.丞丁丑丏丄丏七丂不.cameraFrustum.farClipPlane;
            var val_32 = (val_30 < 0) ? (val_30 + 1) : (val_30);
            val_32 = val_32 >> 1;
            UnityEngine.Vector3 val_33 = this.丞丁丑丏丄丏七丂不.cameraFrustum.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15[0] = val_33;
            val_15[0] = val_33.y;
            val_15[1] = val_33.z;
            val_38 = this.丞丁丑丏丄丏七丂不;
            if(this.丞丁丑丏丄丏七丂不 == null)
            {
                    val_38 = this.丞丁丑丏丄丏七丂不;
            }
            
            if(this.丞丁丑丏丄丏七丂不.orientation != 0)
            {
                    val_39 = val_33.z + 1f;
            }
            else
            {
                    val_39 = val_33.y + (-1f);
            }
            
            var val_36 = 0;
            do
            {
                val_36 = val_36 + 1;
                val_15[0] = val_39 + 0.1f;
                var val_35 = 36 + 12;
            }
            while(val_36 != 4);
            
            val_36 = this.丙丌丟世丛丂丗丟丈;
            val_36.vertices = val_15;
            this.丙丌丟世丛丂丗丟丈.RecalculateBounds();
            val_35 = this.丞丏与世丄三上专业;
            val_35.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.丞丁丑丏丄丏七丂不.cameraFrustumColor, g = val_33.y, b = val_33.z, a = V11.16B});
        }
        public bool get_isPanning()
        {
            if(this.panning == false)
            {
                    return false;
            }
            
            return (bool)(this.东一与专丛三丗万世 == true) ? 1 : 0;
        }
        private void 丝丗不丘万丞丑丝丏()
        {
            float val_35;
            if(this.panning == false)
            {
                goto label_1;
            }
            
            if((this.tapOnMap == false) || (UnityEngine.Input.touchCount < 1))
            {
                goto label_29;
            }
            
            UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
            int val_3 = 专三三与三且一且一();
            if(val_3 == 0)
            {
                    UnityEngine.Touch val_4 = UnityEngine.Input.GetTouch(index:  val_3);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
                val_35 = val_5.x;
                UnityEngine.Vector3 val_6 = this.三世丘与业丏丄丏丙.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_35, y = val_5.y, z = val_5.z});
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                this.丙丕专丏丆丄世丈丁 = val_7;
                mem[1152921541467631812] = val_7.y;
            }
            
            if(this.东一与专丛三丗万世 == false)
            {
                goto label_8;
            }
            
            label_29:
            if(this.panning == false)
            {
                    return;
            }
            
            if(this.东一与专丛三丗万世 == false)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchCount == 1)
            {
                    UnityEngine.Touch val_9 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
                UnityEngine.Vector3 val_11 = this.三世丘与业丏丄丏丙.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = this.丙丕专丏丆丄世丈丁});
                UnityEngine.Vector2 val_14 = this.GetDirection(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, d:  this.panningSensitivity);
                this.丙丒丄丅丝三丙丛三 = true;
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, d:  this.complexZoom);
                UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.panningPosition, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
                this.panningPosition = val_17;
                mem[1152921541467631396] = val_17.y;
                UnityEngine.Touch val_18 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
                val_35 = val_19.x;
                UnityEngine.Vector3 val_20 = this.三世丘与业丏丄丏丙.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_35, y = val_19.y, z = val_19.z});
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                this.丙丕专丏丆丄世丈丁 = val_21;
                mem[1152921541467631812] = val_21.y;
            }
            
            if(UnityEngine.Input.touchCount != 0)
            {
                    if(UnityEngine.Input.touchCount < 1)
            {
                    return;
            }
            
                UnityEngine.Touch val_24 = UnityEngine.Input.GetTouch(index:  0);
                if(专三三与三且一且一() != 3)
            {
                    UnityEngine.Touch val_26 = UnityEngine.Input.GetTouch(index:  0);
                if(专三三与三且一且一() != 4)
            {
                    return;
            }
            
            }
            
            }
            
            if(this.panningMoveBack == false)
            {
                goto label_20;
            }
            
            this.ResetPanning();
            return;
            label_1:
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
            this.panningPosition = val_28;
            mem[1152921541467631396] = val_28.y;
            return;
            label_8:
            if(UnityEngine.Input.touchCount < 1)
            {
                goto label_29;
            }
            
            UnityEngine.Touch val_30 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Vector3 val_31 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_32 = this.三世丘与业丏丄丏丙.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_33.x, y = val_33.y}, b:  new UnityEngine.Vector2() {x = this.丙丕专丏丆丄世丈丁})) <= 0.01f)
            {
                goto label_29;
            }
            
            this.东一与专丛三丗万世 = true;
            goto label_29;
            label_20:
            this.东一与专丛三丗万世 = false;
        }
        public void ResetPanning()
        {
            float val_10;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.panningPosition, y = V8.16B}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) != false)
            {
                    this.东一与专丛三丗万世 = false;
                return;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.panningPosition, y = V8.16B});
            val_10 = val_5.x;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            丛丙丆丌七丘丘且世 val_8 = LeanTween.value(下丐三丆丝与不丗丕:  this.gameObject, 丘丝一下一一丛丞东:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void NJG.UIMapBase::万七丁不丁一丆上七(UnityEngine.Vector3 下下丏一丙不丘丌丞)), 丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_10, y = val_5.y, z = val_5.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丂三丟丂丈丐丆丗丟:  this.panningSpeed).丞不丁丝丙上丗丈万(丙与丕丒丕丈上丗丂:  this.panningEasing);
            val_8.丟丘丙丄丅万丏与丗 = new System.Action(object:  this, method:  System.Void NJG.UIMapBase::且丛丒丒丕下丐丂下());
        }
        private void 万七丁不丁一丆上七(UnityEngine.Vector3 下下丏一丙不丘丌丞)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 下下丏一丙不丘丌丞.x, y = 下下丏一丙不丘丌丞.y, z = 下下丏一丙不丘丌丞.z});
            this.panningPosition = val_1;
            mem[1152921541468010356] = val_1.y;
        }
        private void 且丛丒丒丕下丐丂下()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.panningPosition = val_1;
            mem[1152921541468122356] = val_1.y;
            this.东一与专丛三丗万世 = false;
        }
        private void 丗丗丘丈三丞下丆丟()
        {
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            int val_66;
            System.Collections.Generic.List<UnityEngine.Transform> val_67;
            float val_68;
            float val_69;
            float val_70;
            float val_71;
            float val_72;
            float val_73;
            float val_74;
            if(0 == this.丄丆三丐丛丒丆下东)
            {
                    return;
            }
            
            if(this.controlPoints == null)
            {
                    return;
            }
            
            if(this.controlPoints.Count < 2)
            {
                    return;
            }
            
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.丒下丈丞七下丁世上}, rhs:  new UnityEngine.Color() {r = this.lineColor})) != false)
            {
                    val_63 = W10;
                this.丒下丈丞七下丁世上 = this.lineColor;
                mem[1152921541468378284] = ???;
                mem[1152921541468378288] = ???;
                mem[1152921541468378292] = ???;
                val_61 = W9;
                val_62 = val_63;
                this.丄丆三丐丛丒丆下东.SetColors(start:  new UnityEngine.Color() {r = this.lineColor, g = val_61, b = val_62, a = W11}, end:  new UnityEngine.Color() {r = this.lineColor, g = W9, b = val_63, a = W11});
            }
            
            val_64 = this.丒丘丞丏丙丒上与下;
            val_65 = this.lineWidth;
            if(val_64 != val_65)
            {
                    this.丒丘丞丏丙丒上与下 = val_65;
                val_64 = val_65 * 0.1f;
                val_61 = val_64;
                this.丄丆三丐丛丒丆下东.SetWidth(start:  val_64, end:  val_61);
            }
            
            val_66 = this.linePoints;
            if(val_66 <= 1)
            {
                    val_66 = 2;
                this.linePoints = val_66;
            }
            
            System.Collections.Generic.List<UnityEngine.Transform> val_62 = this.controlPoints;
            val_62 = (val_62.Count - 1) * val_66;
            this.专丐丅丂丗丒丕三丆 = val_62;
            if(this.不业丄丛丕一丂三丅 != val_62)
            {
                    val_66 = this.丄丆三丐丛丒丆下东;
                this.不业丄丛丕一丂三丅 = val_62;
                val_66.SetVertexCount(count:  val_62);
            }
            
            int val_7 = this.controlPoints.Count - 1;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                val_66 = this.controlPoints.Item[0];
                if(val_66 == 0)
            {
                    return;
            }
            
                val_66 = 0 + 1;
                if(this.controlPoints.Item[val_66] == 0)
            {
                    return;
            }
            
                if(val_7 >= 1)
            {
                    val_67 = this.controlPoints;
                if((val_67.Item[0 - 1]) == 0)
            {
                    return;
            }
            
            }
            
                int val_16 = this.controlPoints.Count - 2;
                if(0 < val_16)
            {
                    if((this.controlPoints.Item[0 + 2]) == 0)
            {
                    return;
            }
            
            }
            
                UnityEngine.Vector3 val_21 = this.controlPoints.Item[0].position;
                UnityEngine.Vector3 val_23 = this.controlPoints.Item[val_66].position;
                UnityEngine.Vector3 val_25 = this.controlPoints.Item[val_66].position;
                if(0 >= val_16)
            {
                    UnityEngine.Vector3 val_28 = this.controlPoints.Item[0 - 1].position;
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                val_68 = 0.5f;
                val_69 = val_29.x;
                val_70 = val_29.y;
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  val_68, a:  new UnityEngine.Vector3() {x = val_69, y = val_70, z = val_29.z});
            }
            else
            {
                    UnityEngine.Vector3 val_32 = this.controlPoints.Item[0].position;
                val_68 = val_25.x;
                val_69 = val_25.y;
                val_70 = val_25.z;
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            }
            
                val_67 = this.controlPoints.Count - 2;
                if(0 < val_67)
            {
                    UnityEngine.Vector3 val_37 = this.controlPoints.Item[0 + 2].position;
                val_71 = val_37.z;
                UnityEngine.Vector3 val_39 = this.controlPoints.Item[0].position;
                val_63 = val_39.x;
                UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_71}, b:  new UnityEngine.Vector3() {x = val_63, y = val_39.y, z = val_39.z});
                val_72 = 0.5f;
                val_73 = val_40.x;
                val_74 = val_40.y;
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(d:  val_72, a:  new UnityEngine.Vector3() {x = val_73, y = val_74, z = val_40.z});
            }
            else
            {
                    UnityEngine.Vector3 val_43 = this.controlPoints.Item[val_66].position;
                val_71 = val_43.z;
                UnityEngine.Vector3 val_45 = this.controlPoints.Item[0].position;
                val_63 = val_45.x;
                val_72 = val_43.x;
                val_73 = val_43.y;
                val_74 = val_71;
                UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_72, y = val_73, z = val_74}, b:  new UnityEngine.Vector3() {x = val_63, y = val_45.y, z = val_45.z});
            }
            
                val_65 = (float)this.linePoints;
                float val_63 = (float)this.linePoints;
                val_63 = val_63 + (-1f);
                float val_49 = (0 == (this.controlPoints.Count - 2)) ? (val_63) : (val_65);
                if(this.linePoints >= 1)
            {
                    val_49 = 1f / val_49;
                do
            {
                float val_64 = 0f;
                float val_50 = val_49 * val_64;
                val_64 = val_50 + val_50;
                float val_65 = 3f;
                val_65 = val_50 * val_65;
                val_63 = val_50 * val_64;
                val_64 = val_50 * val_63;
                float val_51 = val_50 * val_65;
                val_64 = val_64 - val_51;
                val_64 = val_64 + 1f;
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(d:  val_64, a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
                val_71 = val_50 * val_50;
                val_65 = val_50 * val_71;
                float val_53 = val_65 - val_63;
                val_53 = val_50 + val_53;
                UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(d:  val_53, a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
                UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
                float val_66 = -2f;
                val_66 = val_50 * val_66;
                val_66 = val_50 * val_66;
                val_66 = val_50 * val_66;
                val_66 = val_51 + val_66;
                UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(d:  val_66, a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
                UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
                UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Multiply(d:  val_65 - val_71, a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
                UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, b:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
                this.丄丆三丐丛丒丆下东.SetPosition(index:  0 + (0 * this.linePoints), position:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
                val_67 = 0 + 1;
            }
            while(val_67 < this.linePoints);
            
            }
            
            }
            while(val_66 < val_7);
        
        }
        private void 丌丙丂世丒不丑丂丛(float 上世东专丅丙一世与)
        {
            if(this.mBaseZoom != 上世东专丅丙一世与)
            {
                    this.丙丒丄丅丝三丙丛三 = true;
            }
            
            this.mBaseZoom = 上世东专丅丙一世与;
            上世东专丅丙一世与 = this.三丏丐丗丒七丟丈丄 * 上世东专丅丙一世与;
            this.complexZoom = 上世东专丅丙一世与;
        }
        public void ZoomIn(float 丛丁三世世丆七不业)
        {
            if(this.mBaseZoom == this.maxZoom)
            {
                    return;
            }
            
            if((LeanTween.isTweening(下丐三丆丝与不丗丕:  this.gameObject)) != false)
            {
                    LeanTween.cancel(下丐三丆丝与不丗丕:  this.gameObject);
            }
            
            丛丙丆丌七丘丘且世 val_9 = LeanTween.value(下丐三丆丝与不丗丕:  this.gameObject, 丘丝一下一一丛丞东:  new System.Action<System.Single>(object:  this, method:  System.Void NJG.UIMapBase::丌丙丂世丒不丑丂丛(float 上世东专丅丙一世与)), 丈丗与丞一上且上上:  this.mBaseZoom, 专丂丕丗丗东世丞下:  UnityEngine.Mathf.Clamp(value:  this.mBaseZoom + 丛丁三世世丆七不业, min:  (float)(int)this.minZoom, max:  (float)(int)this.maxZoom), 丂三丟丂丈丐丆丗丟:  this.zoomSpeed).丞不丁丝丙上丗丈万(丙与丕丒丕丈上丗丂:  this.mZoomEasing);
        }
        public void ZoomOut(float 丛丁三世世丆七不业)
        {
            if(this.mBaseZoom == this.minZoom)
            {
                    return;
            }
            
            if((LeanTween.isTweening(下丐三丆丝与不丗丕:  this.gameObject)) != false)
            {
                    LeanTween.cancel(下丐三丆丝与不丗丕:  this.gameObject);
            }
            
            丛丙丆丌七丘丘且世 val_9 = LeanTween.value(下丐三丆丝与不丗丕:  this.gameObject, 丘丝一下一一丛丞东:  new System.Action<System.Single>(object:  this, method:  System.Void NJG.UIMapBase::丌丙丂世丒不丑丂丛(float 上世东专丅丙一世与)), 丈丗与丞一上且上上:  this.mBaseZoom, 专丂丕丗丗东世丞下:  UnityEngine.Mathf.Clamp(value:  this.mBaseZoom - 丛丁三世世丆七不业, min:  (float)(int)this.minZoom, max:  (float)(int)this.maxZoom), 丂三丟丂丈丐丆丗丟:  this.zoomSpeed).丞不丁丝丙上丗丈万(丙与丕丒丕丈上丗丂:  this.mZoomEasing);
        }
        public UnityEngine.Vector3 MapToWorld(UnityEngine.Vector2 下业丕七东丌丝下且)
        {
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_3 = this.业且丂且下一丆丆丌;
            val_5 = val_1.y;
            val_6 = val_1.z;
            if(this.丞丁丑丏丄丏七丂不.orientation != 0)
            {
                    val_1.y = 下业丕七东丌丝下且.y / val_1.y;
                val_5 = val_1.y + val_1.z;
            }
            else
            {
                    val_1.y = 下业丕七东丌丝下且.y / val_1.y;
                val_6 = val_1.y + val_1.z;
            }
            
            val_3 = (下业丕七东丌丝下且.x / this.不与丈与七丗丗丛丐) + val_3;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3, y = val_5, z = val_6}, b:  new UnityEngine.Vector3() {x = this.丘丈丈丁不丕丝丂丁, y = 下业丕七东丌丝下且.x, z = 下业丕七东丌丝下且.y});
        }
        public UnityEngine.Vector2 WorldToMap(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z}, b:  new UnityEngine.Vector3() {x = this.丘丈丈丁不丕丝丂丁, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_6 = this.业且丂且下一丆丆丌;
            val_1.x = val_1.x - val_6;
            float val_5 = (this.丞丁丑丏丄丏七丂不.orientation == 0) ? 1152921541469221956 : 1152921541469221952;
            val_5 = ((this.丞丁丑丏丄丏七丂不.orientation == 0) ? val_1.z : val_1.y) - val_5;
            val_6 = val_6 * val_5;
            return new UnityEngine.Vector2() {x = val_1.x * this.不与丈与七丗丗丛丐, y = val_6};
        }
        public void ComputeWorldTransform()
        {
            NJG.NJGMapBase val_6;
            NJG.NJGMapBase val_7;
            if(this.丞丁丑丏丄丏七丂不 != 0)
            {
                goto label_3;
            }
            
            val_6 = NJG.NJGMapBase.instance;
            this.丞丁丑丏丄丏七丂不 = val_6;
            if(val_6 != null)
            {
                goto label_6;
            }
            
            goto label_5;
            label_3:
            val_6 = this.丞丁丑丏丄丏七丂不;
            if(val_6 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            this.专专丒丝丟专业丞丕 = S0 / V0.16B;
            val_7 = this.丞丁丑丏丄丏七丂不;
            if(this.丞丁丑丏丄丏七丂不 == null)
            {
                    val_7 = this.丞丁丑丏丄丏七丂不;
            }
            
            float val_4 = (this.丞丁丑丏丄丏七丂不.orientation == 0) ? (V2.16B) : (V1.16B);
            val_4 = V1.16B / val_4;
            mem[1152921541469366744] = val_4;
            this.丘丈丈丁不丕丝丂丁 = val_4;
            mem[1152921541469366732] = ???;
            mem[1152921541469366736] = ???;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.专专丒丝丟专业丞丕, y = V1.16B}, d:  this.complexZoom);
            this.不与丈与七丗丗丛丐 = val_5;
            mem[1152921541469366752] = val_5.y;
            this.WorldScrollPosition();
        }
        protected virtual void 丕丂与丗丕丈丑且丛()
        {
        
        }
        public void WorldScrollPosition()
        {
            this.业且丂且下一丆丆丌 = this.scrollPosition * S0;
            mem[1152921541469619392] = S1 * S4;
            mem[1152921541469619396] = S2 * S4;
        }
        public void Toggle()
        {
            if(this.下专丐丗专万不丏且 != false)
            {
                
            }
        
        }
        public virtual void Show()
        {
            UnityEngine.Transform val_21;
            UnityEngine.Transform val_22;
            if(this.下专丐丗专万不丏且 != false)
            {
                    return;
            }
            
            if(this.丙专万丙丏业下丛丛 == 0)
            {
                    val_21 = this.cachedTransform.GetChild(index:  0);
                this.丙专万丙丏业下丛丛 = val_21;
            }
            else
            {
                    val_21 = this.丙专万丙丏业下丛丛;
            }
            
            if(val_21 == 0)
            {
                    this.丙专万丙丏业下丛丛 = this.transform;
            }
            
            if((this.三上下丁丅丅下上丑 == 0) && (this.丒万丞丒丙万丌丂七 != true))
            {
                    UnityEngine.Animation val_7 = this.丙专万丙丏业下丛丛.GetComponent<UnityEngine.Animation>();
                this.三上下丁丅丅下上丑 = val_7;
                if(val_7 == 0)
            {
                    this.三上下丁丅丅下上丑 = this.丙专万丙丏业下丛丛.GetComponentInChildren<UnityEngine.Animation>();
            }
            
                this.丒万丞丒丙万丌丂七 = true;
            }
            
            val_22 = this.丙专万丙丏业下丛丛;
            丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_22.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this.三上下丁丅丅下上丑 != 0)
            {
                    this.三上下丁丅丅下上丑.Item[this.三上下丁丅丅下上丑.clip.name].speed = 1f;
                val_22 = this.三上下丁丅丅下上丑.clip.name;
                this.三上下丁丅丅下上丑.Item[val_22].time = 0f;
                if(this.三上下丁丅丅下上丑.clip != 0)
            {
                    bool val_20 = this.三上下丁丅丅下上丑.Play();
            }
            
            }
            
            this.下专丐丗专万不丏且 = true;
            this.enabled = true;
        }
        public virtual void Hide()
        {
            var val_26;
            UnityEngine.Transform val_27;
            if(this.下专丐丗专万不丏且 == false)
            {
                    return;
            }
            
            val_26 = 1152921504848912384;
            if(this.丙专万丙丏业下丛丛 == 0)
            {
                    val_27 = this.cachedTransform.GetChild(index:  0);
                this.丙专万丙丏业下丛丛 = val_27;
            }
            else
            {
                    val_27 = this.丙专万丙丏业下丛丛;
            }
            
            if(val_27 == 0)
            {
                    this.丙专万丙丏业下丛丛 = this.transform;
            }
            
            if((this.三上下丁丅丅下上丑 == 0) && (this.丒万丞丒丙万丌丂七 != true))
            {
                    this.三上下丁丅丅下上丑 = this.gameObject.GetComponentInChildren<UnityEngine.Animation>();
                this.丒万丞丒丙万丌丂七 = true;
            }
            
            if(this.三上下丁丅丅下上丑 == 0)
            {
                goto label_17;
            }
            
            if(this.三上下丁丅丅下上丑.clip == 0)
            {
                goto label_35;
            }
            
            this.三上下丁丅丅下上丑.Item[this.三上下丁丅丅下上丑.clip.name].speed = -1f;
            val_26 = this.三上下丁丅丅下上丑.Item[this.三上下丁丅丅下上丑.clip.name];
            this.三上下丁丅丅下上丑.Item[this.三上下丁丅丅下上丑.clip.name].time = val_26.length;
            bool val_22 = this.三上下丁丅丅下上丑.Play();
            UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  this.三丄丘下世丛丒丕下());
            goto label_35;
            label_17:
            丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.丙专万丙丏业下丛丛.gameObject, 丏业丟一东丂东丘丛:  false);
            label_35:
            this.下专丐丗专万不丏且 = false;
            this.enabled = false;
        }
        private System.Collections.IEnumerator 三丄丘下世丛丒丕下()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new UIMapBase.万丅丒且一七上丆丆();
        }
        public UnityEngine.Vector2 GetDirection(UnityEngine.Vector2 业丒丝丗与丐丛丟丏)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y});
            UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this.与三丐丛不东业专丈, y = V10.16B, z = V8.16B, w = V9.16B}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public UnityEngine.Vector3 GetDirection(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this.与三丐丛不东业专丈, y = V13.16B, z = V11.16B, w = V12.16B}, point:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        }
        protected UIMapBase()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.margin = val_1;
            mem[1152921541470859432] = val_1.y;
            this.pivot = 8;
            this.zoomAmount = 0.5f;
            this.mBaseZoom = ;
            this.三丏丐丗丒七丟丈丄 = ;
            this.complexZoom = 1f;
            this.scaleOnMovingFactor = 50f;
            this.minZoom = 1f;
            this.maxZoom = 0f;
            this.zoomSpeed = 0.5f;
            this.zoomInKey = 270;
            this.zoomOutKey = 269;
            this.mouseWheelEnabled = true;
            this.panning = true;
            this.panningEasing = 21;
            this.panningSpeed = 1f;
            this.panningSensitivity = 0f;
            this.limitBounds = true;
            this.panningMoveBack = true;
            this.targetTag = "Player";
            this.keysInUse = new UnityEngine.KeyCode[3];
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.panningPosition = val_3;
            mem[1152921541470859540] = val_3.y;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.scrollPosition = val_4;
            mem[1152921541470859552] = val_4.y;
            this.linePoints = 20;
            UnityEngine.Color val_5 = UnityEngine.Color.red;
            this.lineColor = val_5;
            mem[1152921541470859576] = val_5.g;
            mem[1152921541470859580] = val_5.b;
            mem[1152921541470859584] = val_5.a;
            this.lineWidth = 0.1f;
            this.controlPoints = new System.Collections.Generic.List<UnityEngine.Transform>();
            this.calculateBorder = true;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.mZoom = val_7;
            mem[1152921541470859620] = val_7.y;
            mem[1152921541470859624] = val_7.z;
            this.mList = new System.Collections.Generic.List<NJG.UIMapIconBase>();
            this.mMapScaleChanged = true;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.丑一丞丁丗丏丛下万 = val_9;
            mem[1152921541470859820] = val_9.y;
            mem[1152921541470859824] = val_9.z;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.且专丄丞丙丙丛丙丆 = val_10;
            mem[1152921541470859832] = val_10.y;
            mem[1152921541470859836] = val_10.z;
            this.丄东丄丕与丈丅丛万 = new System.Collections.Generic.List<NJG.UIMapIconBase>();
            UnityEngine.Color val_12 = UnityEngine.Color.white;
            this.mColor = val_12;
            mem[1152921541470859908] = val_12.g;
            mem[1152921541470859912] = val_12.b;
            mem[1152921541470859916] = val_12.a;
            this.丘丛专世万万丁丙一 = 0;
            mem[1152921541470859944] = 0;
            this.mZoomEasing = 18;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
            this.丙丕专丏丆丄世丈丁 = val_13;
            mem[1152921541470859956] = val_13.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            this.业丘丁且丛且丞东专 = val_14;
            mem[1152921541470859968] = val_14.y;
            mem[1152921541470859972] = val_14.z;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            this.mArrScale = val_15;
            mem[1152921541470859984] = val_15.y;
            mem[1152921541470859988] = val_15.z;
            this.丟七丞丈丞丁业专业 = true;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            this.丙丟丟东丂万丘一不 = val_16;
            mem[1152921541470860040] = val_16.y;
            mem[1152921541470860044] = val_16.z;
        }
    
    }

}
