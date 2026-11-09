using UnityEngine;
public class MiniMapController : MonoBehaviour
{
    // Fields
    private NJGMap mapInstance;
    private UIWidget miniMapWidget;
    private UISprite miniMapSpriteRenderQueue;
    private UISprite miniMapSafePathSpriteRenderQueue;
    private UISprite miniMapDangerPathSpriteRenderQueue;
    private UISprite miniMapShuttlePathSpriteRenderQueue;
    private UIWidget worldMapWidget;
    private UISprite worldMapSpriteRenderQueue;
    private UISprite worldMapSafePathSpriteRenderQueue;
    private UISprite worldMapDangerPathSpriteRenderQueue;
    private UISprite worldMapShuttlePathSpriteRenderQueue;
    private UnityEngine.LineRenderer miniMapSafePathRenderer;
    private UnityEngine.LineRenderer worldMapSafePathRenderer;
    private UnityEngine.LineRenderer miniMapDangerPathRenderer;
    private UnityEngine.LineRenderer worldMapDangerPathRenderer;
    private UnityEngine.LineRenderer miniMapShuttlePathRenderer;
    private UnityEngine.LineRenderer worldMapShuttlePathRenderer;
    private UILabel miniMapTextLabelBase;
    private UIPanel miniMapTextsPanel;
    private UnityEngine.Transform miniMapTextsRoot;
    private UILabel worldMapTextLabelBase;
    private UIPanel worldMapTextsPanel;
    private UnityEngine.Transform worldMapTextsRoot;
    private bool TextsUnderIcons;
    private UnityEngine.AnimationCurve safeZoneBorderWidth;
    private UnityEngine.AudioClip setMarkerSound;
    private const float 世丗丛丝一丄丝丒丛 = 1.098;
    private const float 丑专丏丛下丒上丑丄 = 1.55;
    private const float 下丐丟丁丙丕丛丆业 = -0.07;
    private const float 专丐业丝丝丘丛丕东 = 0.77;
    private static readonly int 三丟丘下丅三下专业;
    private static readonly int 丛东丗专且丙丒丙丂;
    private static readonly int 与丛丈不丑业下三丛;
    private System.IDisposable 三专丛丒丑丞丝丑丈;
    private UIPanel 丁与丈下丑与世不丟;
    private UnityEngine.Vector4 不上丐丁上丂丒丝丄;
    private UnityEngine.Vector4 丐不丄上专七下丅丞;
    private UnityEngine.Vector3 丙丑丝丆丅与丌丁丘;
    private UnityEngine.Vector3 丗丄三专三丝专丁丙;
    private int 丙丌不丙丂丆丏丛丙;
    private bool 与丑不丘一丒丏丘上;
    private UnityEngine.Coroutine 世世丕与丁丌丆业七;
    
    // Properties
    public bool 丅世丞丂一与一丛不 { get; }
    private float 东丟下且丏东一丟与 { get; }
    
    // Methods
    public bool get_isWorldMapOpened()
    {
        return (bool)this.与丑不丘一丒丏丘上;
    }
    private float 丌丞丂丏丂丌丗丕七()
    {
        if(this.mapInstance == 0)
        {
                return 1f;
        }
        
        this = this.worldMapWidget.height;
        float val_5 = (float)this;
        val_5 = val_5 / (float)this.miniMapWidget.height;
        val_5 = this.mapInstance.zoom / val_5;
        return 1f;
    }
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七 = this;
    }
    private void Start()
    {
        UnityEngine.GameObject val_50;
        var val_51;
        var val_53;
        NJGMap val_54;
        var val_55;
        var val_56;
        UnityEngine.Transform val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        val_50 = this;
        val_51 = 1152921505066536960;
        this.丙丌不丙丂丆丏丛丙 = (GameConnect.丙丌丒丈东七丒上丌() != true) ? 3037 : 3000;
        bool val_3 = GameConnect.万不丒丌丙万丗东不();
        if(this.miniMapWidget == null)
        {
            goto label_6;
        }
        
        if(val_3 == false)
        {
            goto label_7;
        }
        
        label_15:
        mem2[0] = 11;
        mem2[0] = 211;
        mem2[0] = 11;
        if(11 == 0)
        {
            goto label_21;
        }
        
        val_53 = 211;
        goto label_14;
        label_6:
        if(val_3 == true)
        {
            goto label_15;
        }
        
        label_7:
        mem2[0] = 69;
        mem2[0] = 215;
        mem2[0] = -16;
        if((-16) == 0)
        {
            goto label_21;
        }
        
        val_53 = 161;
        label_14:
        mem[12] = val_53;
        UIMiniMap val_4 = this.mapInstance.GetComponent<UIMiniMap>();
        val_4.miniMapWidget = this.miniMapWidget;
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.Texture2D val_8 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "MiniMaps/"("MiniMaps/") + val_5.m_Handle.name);
        bool val_9 = UnityEngine.Object.op_Equality(x:  val_8, y:  0);
        val_54 = this.mapInstance;
        if(val_54 == null)
        {
            goto label_29;
        }
        
        if(val_9 == false)
        {
            goto label_30;
        }
        
        label_35:
        val_54.gameObject.SetActive(value:  false);
        val_50 = this.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_50, 丏业丟一东丂东丘丛:  false);
        return;
        label_29:
        if(val_9 == true)
        {
            goto label_35;
        }
        
        label_30:
        mem2[0] = val_8;
        this.mapInstance.wrapMode = 1;
        this.mapInstance.gameObject.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapInstance.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapInstance.gameObject, 丏业丟一东丂东丘丛:  true);
        this.mapInstance.UpdateBounds();
        this.世丕丝丛丟丁丝一与();
        this.mapInstance.GetComponentInChildren<UIPanel>().depth = ((this.TextsUnderIcons == false) ? (-1) : 1) + this.miniMapTextsPanel.depth;
        this.mapInstance.iconRoot.GetComponent<UIPanel>().depth = ((this.TextsUnderIcons == false) ? (-1) : 1) + this.worldMapTextsPanel.depth;
        val_55 = null;
        val_55 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_61;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_71;
        }
        
        val_56 = null;
        val_56 = null;
        BattleRoyaleController val_26 = BattleRoyaleController.丑七不且上丗丁一世();
        NJGMapItem val_28 = this.AddMiniMapIcon(业丟丏上丛与不一丝:  val_26.shutle.gameObject, 下丗丁丒丘东丂不丑:  2);
        BattleRoyaleController val_29 = BattleRoyaleController.丑七不且上丗丁一世();
        val_57 = val_29.shutle;
        if(val_57 != null)
        {
            goto label_88;
        }
        
        goto label_78;
        label_71:
        val_58 = null;
        val_58 = null;
        NJGMapItem val_33 = this.AddMiniMapIcon(业丟丏上丛与不一丝:  transform.root.gameObject, 下丗丁丒丘东丂不丑:  1);
        val_57 = transform.root;
        if(val_57 != null)
        {
            goto label_88;
        }
        
        label_78:
        label_88:
        this.SetMiniMapTarget(业丟丏上丛与不一丝:  val_57.gameObject);
        label_61:
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.zero;
        this.丌专丈丞东业世丙上(丈丘丁丐丛丕丌专丘:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, 三丙与且下丏丒丂专:  0f, 丏上丛丛丒与与丕与:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, 不丂丑七丐丌且丗丝:  0f);
        float val_50 = (float)this.worldMapWidget.height;
        val_50 = val_50 / (float)this.miniMapWidget.height;
        val_50 = val_50 * val_37.x;
        this.mapInstance.zoom = val_50;
        this.mapInstance.gameObject.SetActive(value:  true);
        mem2[0] = new UIMapBase.丘丄丞且上丙上专丕(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MiniMapController::不一丂且丑世万世丂());
        mem2[0] = new UIMapBase.丘丄丞且上丙上专丕(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MiniMapController::不一丂且丑世万世丂());
        UIPanel val_44 = this.GetComponent<UIPanel>();
        val_44.onRenderQueueUpdated = new UIPanel.世一不世丗丞丅丑丐(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MiniMapController::丐丌世丆丙丕丏世七());
        if(null == null)
        {
                val_59 = 0;
        }
        
        if(null == null)
        {
                val_60 = 0;
        }
        
        if(null <= 2)
        {
                val_61 = 0;
        }
        
        this.不上丐丁上丂丒丝丄 = 0;
        mem[1152921538124610172] = 0;
        mem[1152921538124610180] = 0;
        UnityEngine.Vector3 val_47 = this.miniMapWidget.transform.position;
        this.丙丑丝丆丅与丌丁丘 = val_47;
        mem[1152921538124610204] = val_47.y;
        mem[1152921538124610208] = val_47.z;
        if(null == null)
        {
                val_62 = 0;
        }
        
        if(null == null)
        {
                val_63 = 0;
        }
        
        if(null <= 2)
        {
                val_64 = 0;
        }
        
        val_54 = this.worldMapWidget;
        this.丐不丄上专七下丅丞 = 0;
        mem[1152921538124610188] = 0;
        mem[1152921538124610196] = 0;
        UnityEngine.Vector3 val_49 = this.worldMapWidget.transform.position;
        this.丗丄三专三丝专丁丙 = val_49;
        mem[1152921538124610216] = val_49.y;
        mem[1152921538124610220] = val_49.z;
        this.ShowWorldMap(丛与丙丒丒下丌丟且:  false, 丞三业丕世丂丁丐专:  false);
        this.与丑不丘一丒丏丘上 = false;
        return;
        label_21:
    }
    private void Update()
    {
    
    }
    private void 丐丌世丆丙丕丏世七()
    {
        int val_28;
        if(this.mapInstance == 0)
        {
                return;
        }
        
        if(this.mapInstance != 0)
        {
                if(this.worldMapSpriteRenderQueue != 0)
        {
                val_28 = this.worldMapSpriteRenderQueue.renderQueue;
            this.mapInstance.depth = val_28 - this.丙丌不丙丂丆丏丛丙;
        }
        
            if(this.worldMapSafePathSpriteRenderQueue != 0)
        {
                val_28 = this.worldMapSafePathSpriteRenderQueue.renderQueue;
            this.worldMapSafePathRenderer.material.renderQueue = val_28;
        }
        
            if(this.worldMapDangerPathSpriteRenderQueue != 0)
        {
                val_28 = this.worldMapDangerPathSpriteRenderQueue.renderQueue;
            this.worldMapDangerPathRenderer.material.renderQueue = val_28;
        }
        
            if(this.worldMapShuttlePathSpriteRenderQueue != 0)
        {
                val_28 = this.worldMapShuttlePathSpriteRenderQueue.renderQueue;
            this.worldMapShuttlePathRenderer.material.renderQueue = val_28;
        }
        
        }
        
        if(this.mapInstance == 0)
        {
                return;
        }
        
        if(this.miniMapSpriteRenderQueue != 0)
        {
                val_28 = this.miniMapSpriteRenderQueue.renderQueue;
            this.mapInstance.depth = val_28 - this.丙丌不丙丂丆丏丛丙;
        }
        
        if(this.miniMapSafePathSpriteRenderQueue != 0)
        {
                val_28 = this.miniMapSafePathSpriteRenderQueue.renderQueue;
            this.miniMapSafePathRenderer.material.renderQueue = val_28;
        }
        
        if(this.miniMapDangerPathSpriteRenderQueue != 0)
        {
                val_28 = this.miniMapDangerPathSpriteRenderQueue.renderQueue;
            this.miniMapDangerPathRenderer.material.renderQueue = val_28;
        }
        
        if(this.miniMapShuttlePathSpriteRenderQueue == 0)
        {
                return;
        }
        
        this.miniMapShuttlePathRenderer.material.renderQueue = this.miniMapShuttlePathSpriteRenderQueue.renderQueue;
    }
    public NJGMapItem AddMiniMapIcon(UnityEngine.GameObject 业丟丏上丛与不一丝, int 下丗丁丒丘东丂不丑)
    {
        if(this.mapInstance == 0)
        {
                return 0;
        }
        
        if(下丗丁丒丘东丂不丑 < 1)
        {
                return 0;
        }
        
        if(业丟丏上丛与不一丝 == 0)
        {
                return 0;
        }
        
        System.String[] val_3 = this.mapInstance.mapItemTypes;
        if(val_3.Length < 下丗丁丒丘东丂不丑)
        {
                return 0;
        }
        
        if(业丟丏上丛与不一丝 != null)
        {
                NJGMapItem val_4 = 业丟丏上丛与不一丝.AddComponent<NJGMapItem>();
        }
        else
        {
                NJGMapItem val_5 = 0.AddComponent<NJGMapItem>();
        }
        
        NJGMapItem val_6 = 业丟丏上丛与不一丝.GetComponent<NJGMapItem>();
        val_6.type = 下丗丁丒丘东丂不丑;
        return 0;
    }
    public void RemoveMiniMapIcon(UnityEngine.GameObject 业丟丏上丛与不一丝)
    {
        UnityEngine.GameObject val_5 = 业丟丏上丛与不一丝;
        if(this.mapInstance == 0)
        {
                return;
        }
        
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = val_5.GetComponent<NJGMapItem>();
        if(val_5 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_5);
    }
    public void SetMiniMapTarget(UnityEngine.GameObject 业丟丏上丛与不一丝)
    {
        UnityEngine.Object val_5;
        NJGMap val_6;
        val_5 = 业丟丏上丛与不一丝;
        val_6 = this.mapInstance;
        if(val_6 == 0)
        {
                return;
        }
        
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = val_5.transform;
        val_5 = val_5.transform;
        mem2[0] = val_5;
    }
    private void 世丕丝丛丟丁丝一与()
    {
        UILabel val_25;
        var val_26;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.miniMapTextLabelBase, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.worldMapTextLabelBase, 丏业丟一东丂东丘丛:  false);
        val_25 = 1152921505102266368;
        if(WorldTextsForMapContainer.instance == 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_26 = 0;
    }
    private void 万世东与丈丈丛丗丂()
    {
        UnityEngine.Object val_27;
        var val_28;
        if(this.mapInstance == 0)
        {
                return;
        }
        
        val_27 = 1152921505102266368;
        if(WorldTextsForMapContainer.instance == 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_28 = 0;
    }
    private void 不一丂且丑世万世丂()
    {
        var val_44;
        float val_45;
        float val_46;
        float val_47;
        var val_48;
        var val_49;
        var val_50;
        UIWidget val_51;
        UnityEngine.Vector3 val_52;
        float val_53;
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        val_44 = this;
        if(this.mapInstance == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.miniMapWidget.transform.position;
        val_45 = this.丙丑丝丆丅与丌丁丘;
        val_46 = V9.16B;
        val_47 = V10.16B;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) != false)
        {
                if(null == null)
        {
                val_48 = 0;
        }
        
            if(null == null)
        {
                val_49 = 0;
        }
        
            if(null <= 2)
        {
                val_50 = 0;
        }
        
            val_51 = this.miniMapWidget;
            val_45 = this.丙丑丝丆丅与丌丁丘;
            val_46 = V9.16B;
            val_47 = V10.16B;
            this.不上丐丁上丂丒丝丄 = 0;
            mem[1152921538126822012] = 0;
            mem[1152921538126822020] = 0;
            UnityEngine.Vector3 val_6 = this.miniMapWidget.transform.position;
            this.丙丑丝丆丅与丌丁丘 = val_6;
            mem[1152921538126822044] = val_6.y;
            mem[1152921538126822048] = val_6.z;
        }
        
        val_52 = this.丗丄三专三丝专丁丙;
        UnityEngine.Vector3 val_8 = this.worldMapWidget.transform.position;
        val_57 = val_8.y;
        val_58 = val_52;
        val_59 = V9.16B;
        val_60 = V10.16B;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_60}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_57, z = val_8.z})) != false)
        {
                if(null == null)
        {
                val_61 = 0;
        }
        
            if(null == null)
        {
                val_62 = 0;
        }
        
            if(null <= 2)
        {
                val_63 = 0;
        }
        
            val_51 = this.worldMapWidget;
            val_58 = val_52;
            val_59 = V9.16B;
            val_60 = V10.16B;
            this.丐不丄上专七下丅丞 = 0;
            mem[1152921538126822028] = 0;
            mem[1152921538126822036] = 0;
            UnityEngine.Vector3 val_11 = this.worldMapWidget.transform.position;
            this.丗丄三专三丝专丁丙 = val_11;
            mem[1152921538126822056] = val_11.y;
            mem[1152921538126822060] = val_11.z;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_51 = 1152921505039699968;
            if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_15 = BattleRoyaleController.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_16 = val_15.safeZones.currentZonePosition;
            BattleRoyaleController val_17 = BattleRoyaleController.丑七不且上丗丁一世();
            float val_18 = val_17.safeZones.currentZoneRadius;
            BattleRoyaleController val_19 = BattleRoyaleController.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_20 = val_19.safeZones.safeZonePosition;
            val_57 = val_20.x;
            BattleRoyaleController val_21 = BattleRoyaleController.丑七不且上丗丁一世();
            this.丌专丈丞东业世丙上(丈丘丁丐丛丕丌专丘:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 三丙与且下丏丒丂专:  val_18, 丏上丛丛丒与与丕与:  new UnityEngine.Vector3() {x = val_57, y = val_20.y, z = val_20.z}, 不丂丑七丐丌且丗丝:  val_21.safeZones.safeZoneRadius);
            this.世丕丁一丐丂丈丌且(丙丆丗七专丞万丁专:  this.miniMapSafePathRenderer, 丞丁丑丏丄丏七丂不:  0);
            this.世丕丁一丐丂丈丌且(丙丆丗七专丞万丁专:  this.worldMapSafePathRenderer, 丞丁丑丏丄丏七丂不:  0);
            this.丆三丆东丝业丛丝丆(丙丆丗七专丞万丁专:  this.miniMapDangerPathRenderer, 丞丁丑丏丄丏七丂不:  0);
            this.丆三丆东丝业丛丝丆(丙丆丗七专丞万丁专:  this.worldMapDangerPathRenderer, 丞丁丑丏丄丏七丂不:  0);
            this.丈世丆丂丁上丈专下(丙丆丗七专丞万丁专:  this.miniMapShuttlePathRenderer, 丞丁丑丏丄丏七丂不:  0);
            this.丈世丆丂丁上丈专下(丙丆丗七专丞万丁专:  this.worldMapShuttlePathRenderer, 丞丁丑丏丄丏七丂不:  0);
            val_64 = null;
            val_64 = null;
            this.miniMapSafePathRenderer.material.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = this.不上丐丁上丂丒丝丄, y = val_16.y, z = val_16.z, w = val_18});
            this.miniMapDangerPathRenderer.material.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = this.不上丐丁上丂丒丝丄, y = val_16.y, z = val_16.z, w = val_18});
            this.miniMapShuttlePathRenderer.material.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = this.不上丐丁上丂丒丝丄, y = val_16.y, z = val_16.z, w = val_18});
            this.worldMapSafePathRenderer.material.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = this.丐不丄上专七下丅丞, y = val_16.y, z = val_16.z, w = val_18});
            this.worldMapDangerPathRenderer.material.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = this.丐不丄上专七下丅丞, y = val_16.y, z = val_16.z, w = val_18});
            val_52 = this.丐不丄上专七下丅丞;
            val_51 = this.worldMapShuttlePathRenderer.material;
            val_51.SetVector(nameID:  MiniMapController.与丛丈不丑业下三丛, value:  new UnityEngine.Vector4() {x = val_52, y = val_16.y, z = val_16.z, w = val_18});
        }
        
        }
        
        if(this.mapInstance != 0)
        {
                val_51 = this.worldMapWidget.height;
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1152921504848912384.__il2cppRuntimeField_AC}, d:  (float)val_51);
            UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, d:  this.丌丞丂丏丂丌丗丕七());
            UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y}, d:  -1f);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35.x, y = val_35.y});
            val_52 = val_36.x;
            val_53 = val_36.z;
            this.miniMapTextsRoot.transform.localPosition = new UnityEngine.Vector3() {x = val_52, y = val_36.y, z = val_53};
        }
        
        if(this.与丑不丘一丒丏丘上 == false)
        {
                return;
        }
        
        val_51 = this.worldMapWidget.height;
        UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1152921504848912384.__il2cppRuntimeField_AC}, d:  (float)val_51);
        UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y}, d:  this.mapInstance.zoom);
        UnityEngine.Vector2 val_42 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y}, d:  -1f);
        UnityEngine.Vector3 val_43 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
        val_52 = val_43.x;
        val_53 = val_43.z;
        this.worldMapTextsRoot.transform.localPosition = new UnityEngine.Vector3() {x = val_52, y = val_43.y, z = val_53};
    }
    internal NJG.UIMapIconBase[] 丈丁不丘业一世丘丌(int[] 一丕丅一丕丘世丑丆)
    {
        var val_7;
        var val_10;
        System.Predicate<T> val_11;
        MiniMapController.丙丟与业不万丈丄丈 val_1 = new MiniMapController.丙丟与业不万丈丄丈();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .一丕丅一丕丘世丑丆 = 一丕丅一丕丘世丑丆;
        if(一丕丅一丕丘世丑丆 != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        val_10 = null;
        val_10 = null;
        System.Predicate<NJGMapItem> val_3 = null;
        val_11 = val_3;
        val_3 = new System.Predicate<NJGMapItem>(object:  val_1, method:  System.Boolean MiniMapController.丙丟与业不万丈丄丈::丁东丕一丂丑不丘上(NJGMapItem 不丄丗丁丕丈专下世));
        List.Enumerator<T> val_5 = NJGMapItem.list.FindAll(match:  val_3).GetEnumerator();
        goto label_7;
        label_16:
        string val_8 = val_7.丐丏七丌丕丗业且上();
        val_11 = this.mapInstance;
        new NJG.UIMapIconBase[0][(long)System.Array.IndexOf<System.Int32>(array:  .一丕丅一丕丘世丑丆, value:  -839371456)] = val_11;
        label_7:
        if(((-839349344) & 1) != 0)
        {
            goto label_16;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (NJG.UIMapIconBase[])mem[16];
        label_1:
        mem[16] = 一丕丅一丕丘世丑丆;
        if(mem[16] != 0)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    private NJG.UIMapIconBase 东且与七一丐丂与丂(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        System.Collections.Generic.List<NJGMapItem> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = NJGMapItem.list;
        List.Enumerator<T> val_1 = val_4.GetEnumerator();
        label_6:
        if(((-839167672) & 1) == 0)
        {
            goto label_4;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        if((-839167672) != 丙业与丙丗丝不丈东)
        {
            goto label_6;
        }
        
        val_5 = this.mapInstance;
        goto label_9;
        label_4:
        val_5 = 0;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (NJG.UIMapIconBase)val_5;
    }
    public void ShowWorldMap(bool 丛与丙丒丒下丌丟且, bool 丞三业丕世丂丁丐专 = False)
    {
        object val_38;
        NJGMap val_39;
        UIPanel val_41;
        NJGMap val_42;
        UnityEngine.Object val_44;
        var val_45;
        PGCompany.业丐与丕丒下丑下丈 val_46;
        val_38 = this;
        if(this.mapInstance == 0)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                ShowWorldMap(丛与丙丒丒下丌丟且:  丛与丙丒丒下丌丟且);
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                ShowMapLegend(丛与丙丒丒下丌丟且:  丛与丙丒丒下丌丟且);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                ShowMapLegend(丛与丙丒丒下丌丟且:  丛与丙丒丒下丌丟且);
        }
        
        if(丛与丙丒丒下丌丟且 == false)
        {
            goto label_20;
        }
        
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  (float)this.worldMapWidget.width, y:  (float)this.worldMapWidget.height);
        UnityEngine.Vector3 val_13 = this.worldMapWidget.transform.position;
        this.mapInstance.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        val_39 = this.mapInstance;
        if(this.mapInstance != null)
        {
            goto label_29;
        }
        
        val_39 = this.mapInstance;
        if(val_39 == null)
        {
            goto label_44;
        }
        
        label_29:
        this.mapInstance.zoom = val_13.x;
        this.mapInstance.UpdateScrollPosition(丆丁与丆丏专丏不东:  true);
        if(this.丁与丈下丑与世不丟 != 0)
        {
            goto label_36;
        }
        
        val_41 = this.mapInstance.GetComponentInChildren<UIPanel>();
        this.丁与丈下丑与世不丟 = val_41;
        goto label_39;
        label_20:
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
        mem2[0] = val_16.x;
        mem2[0] = val_16.y;
        val_42 = this.mapInstance;
        if(this.mapInstance != null)
        {
            goto label_43;
        }
        
        val_42 = this.mapInstance;
        if(val_42 == null)
        {
            goto label_44;
        }
        
        label_43:
        this.mapInstance.zoom = val_16.x;
        this.mapInstance.UpdateScrollPosition(丆丁与丆丏专丏不东:  false);
        this.万世东与丈丈丛丗丂();
        if(this.三专丛丒丑丞丝丑丈 == null)
        {
            goto label_70;
        }
        
        var val_38 = 0;
        val_38 = val_38 + 1;
        goto label_52;
        label_36:
        val_41 = this.丁与丈下丑与世不丟;
        label_39:
        if(val_41 != 0)
        {
                this.丁与丈下丑与世不丟.clipping = 3;
            int val_18 = this.worldMapWidget.width;
            int val_19 = this.worldMapWidget.height;
        }
        
        if(this.三专丛丒丑丞丝丑丈 == null)
        {
                this.三专丛丒丑丞丝丑丈 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void MiniMapController::U_WorlMapCloseClick()), 与且专丈不万东一万:  "InGameGUI.WorldMap");
        }
        
        if(this.世世丕与丁丌丆业七 != null)
        {
                this.StopCoroutine(routine:  this.世世丕与丁丌丆业七);
        }
        
        NJG.UIMapIconBase val_23 = this.东且与七一丐丂与丂(丙业与丙丗丝不丈东:  1);
        if(val_23 != null)
        {
                val_44 = val_23.transform;
        }
        else
        {
                val_44 = 0;
        }
        
        if(val_44 == 0)
        {
            goto label_70;
        }
        
        this.世世丕与丁丌丆业七 = this.StartCoroutine(routine:  this.丒七丆不丕丂丞丂一(不万且三丏丆丑丕且:  val_44, 丝业丏丄且丌业世丛:  2.5f, 丞丏业丂丏七丛丝专:  5f));
        goto label_70;
        label_52:
        this.三专丛丒丑丞丝丑丈.Dispose();
        this.三专丛丒丑丞丝丑丈 = 0;
        label_70:
        bool val_29 = 丛与丙丒丒下丌丟且 ^ 1;
        bool val_30 = val_29;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.miniMapWidget, 丏业丟一东丂东丘丛:  val_30);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0, 丏业丟一东丂东丘丛:  val_30);
        bool val_31 = 丛与丙丒丒下丌丟且;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.worldMapWidget, 丏业丟一东丂东丘丛:  val_31);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0, 丏业丟一东丂东丘丛:  val_31);
        this.与丑不丘一丒丏丘上 = val_31;
        if(InGameGUI.丙丞专丌丁丞与不丐.丙丁不东不丅三丛世 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  InGameGUI.丙丞专丌丁丞与不丐.丙丁不东不丅三丛世, 丏业丟一东丂东丘丛:  val_29);
        }
        
        this.不一丂且丑世万世丂();
        if(this.与丑不丘一丒丏丘上 != false)
        {
                val_45 = 1;
            val_46 = 7;
        }
        else
        {
                if(this.与丑不丘一丒丏丘上 != true)
        {
                if(丞三业丕世丂丁丐专 == true)
        {
                return;
        }
        
        }
        
            val_38 = PGCompany.GamepadCoreController.Instance.三丝丂丏一世丛丌东();
            val_45 = 0;
            val_46 = val_38;
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  val_46);
        GamepadCursorController.丆丕丝丒不丙且丐丗.丏丁丄丝与世世丕业();
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.一且丐丆三丟丝丟丁(丞七丛与丝下一一丆:  丛与丙丒丒下丌丟且);
        return;
        label_44:
    }
    private void 丌专丈丞东业世丙上(UnityEngine.Vector3 丈丘丁丐丛丕丌专丘, float 三丙与且下丏丒丂专, UnityEngine.Vector3 丏上丛丛丒与与丕与, float 不丂丑七丐丌且丗丝)
    {
        float val_25;
        float val_26;
        float val_27;
        NJGMap val_28;
        var val_29;
        val_25 = 丏上丛丛丒与与丕与.z;
        val_26 = 三丙与且下丏丒丂专;
        val_27 = 丈丘丁丐丛丕丌专丘.z;
        val_28 = this.mapInstance;
        if(val_28 == 0)
        {
                return;
        }
        
        val_28 = this.mapInstance;
        NJGMap val_4 = this.mapInstance + 156;
        NJGMap val_5 = this.mapInstance + 156;
        NJGMap val_6 = this.mapInstance + 156;
        NJGMap val_7 = this.mapInstance + 156;
        float val_8 = 丈丘丁丐丛丕丌专丘.x * 0.5f;
        NJGMap val_9 = this.mapInstance + 156;
        float val_25 = val_27;
        丈丘丁丐丛丕丌专丘.x = 丈丘丁丐丛丕丌专丘.x + val_8;
        float val_10 = 丏上丛丛丒与与丕与.x + val_8;
        float val_11 = val_25 + val_8;
        val_25 = val_25 + val_8;
        丈丘丁丐丛丕丌专丘.x = 丈丘丁丐丛丕丌专丘.x - 丈丘丁丐丛丕丌专丘.x;
        val_25 = val_25 - 丈丘丁丐丛丕丌专丘.z;
        val_10 = val_10 - 丈丘丁丐丛丕丌专丘.x;
        丈丘丁丐丛丕丌专丘.z = val_11 - 丈丘丁丐丛丕丌专丘.z;
        丈丘丁丐丛丕丌专丘.x = 丈丘丁丐丛丕丌专丘.x / 丈丘丁丐丛丕丌专丘.x;
        val_25 = val_25 / 丈丘丁丐丛丕丌专丘.x;
        val_10 = val_10 / 丈丘丁丐丛丕丌专丘.x;
        val_11 = 丈丘丁丐丛丕丌专丘.z / 丈丘丁丐丛丕丌专丘.x;
        丈丘丁丐丛丕丌专丘.x = 1f - 丈丘丁丐丛丕丌专丘.x;
        val_25 = 1f - val_25;
        float val_12 = 1f - val_10;
        float val_13 = 1f - val_11;
        val_29 = null;
        val_29 = null;
        val_28.SetVector(nameID:  MiniMapController.三丟丘下丅三下专业, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.mapInstance.SetVector(nameID:  MiniMapController.三丟丘下丅三下专业, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_15 = (不丂丑七丐丌且丗丝 + 不丂丑七丐丌且丗丝) / 丈丘丁丐丛丕丌专丘.x;
        float val_16 = this.mapInstance.zoom;
        val_16 = val_15 * val_16;
        float val_18 = this.safeZoneBorderWidth.Evaluate(time:  val_16);
        val_18 = val_18 + (-0.07f);
        float val_19 = UnityEngine.Mathf.Clamp(value:  val_18, min:  -0.07f, max:  0.77f);
        float val_26 = val_26;
        val_26 = val_26 + val_26;
        float val_20 = ((((val_26 == 0f) ? 1 : 0) | ((不丂丑七丐丌且丗丝 == 0f) ? 1 : 0)) != 0) ? 20000f : (val_26);
        val_20 = val_20 / 丈丘丁丐丛丕丌专丘.x;
        val_20 = val_20 * 1.098f;
        float val_21 = val_15 * 1.55f;
        float val_22 = this.丌丞丂丏丂丌丗丕七();
        val_27 = val_22;
        val_22 = val_15 * val_27;
        float val_23 = this.safeZoneBorderWidth.Evaluate(time:  val_22);
        val_23 = val_23 + (-0.07f);
        float val_24 = UnityEngine.Mathf.Clamp(value:  val_23, min:  -0.07f, max:  0.77f);
        this.mapInstance.SetVector(nameID:  MiniMapController.丛东丗专且丙丒丙丂, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_26 = 0f;
        val_25 = 0f;
        val_28.SetVector(nameID:  MiniMapController.丛东丗专且丙丒丙丂, value:  new UnityEngine.Vector4() {x = val_26, y = 0f, z = val_25, w = 0f});
    }
    private void 世丕丁一丐丂丈丌且(UnityEngine.LineRenderer 丙丆丗七专丞万丁专, NJG.UIMapBase 丞丁丑丏丄丏七丂不)
    {
        UnityEngine.GameObject val_53;
        UnityEngine.Object val_54;
        var val_55;
        NJGMap val_56;
        float val_57;
        val_54 = 丙丆丗七专丞万丁专;
        if(val_54 == 0)
        {
                return;
        }
        
        val_55 = null;
        val_55 = null;
        val_53 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_53 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        BattleRoyaleController val_2 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_3 = val_2.safeZones.safeZonePosition;
        BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_5 = val_4.safeZones.currentZonePosition;
        val_56 = this.mapInstance;
        if(((val_56 == 0) || (丞丁丑丏丄丏七丂不 == 0)) || (val_53 == 0))
        {
            goto label_51;
        }
        
        if(丞丁丑丏丄丏七丂不 != this.mapInstance)
        {
            goto label_25;
        }
        
        val_56 = this.miniMapWidget.gameObject;
        if(val_56.activeSelf == false)
        {
            goto label_51;
        }
        
        label_25:
        if(丞丁丑丏丄丏七丂不 == this.mapInstance)
        {
                if(this.worldMapWidget.gameObject.activeSelf == false)
        {
            goto label_51;
        }
        
        }
        
        BattleRoyaleController val_15 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_15.safeZones.safeZoneRadius == 0f)
        {
            goto label_51;
        }
        
        BattleRoyaleController val_17 = BattleRoyaleController.丑七不且上丗丁一世();
        val_57 = val_17.safeZones.safeZoneRadius;
        UnityEngine.Vector3 val_20 = transform.position;
        UnityEngine.Vector3 val_22 = transform.position;
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_20.x, y:  val_22.z);
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.z);
        val_56 = 1152921504850403328;
        if(val_57 >= (UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y})))
        {
            goto label_51;
        }
        
        BattleRoyaleController val_26 = BattleRoyaleController.丑七不且上丗丁一世();
        val_57 = val_26.safeZones.currentZoneRadius;
        UnityEngine.Vector3 val_29 = transform.position;
        UnityEngine.Vector3 val_31 = transform.position;
        UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_29.x, y:  val_31.z);
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.z);
        float val_34 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_33.x, y = val_33.y});
        if(val_57 >= 0)
        {
            goto label_62;
        }
        
        label_51:
        val_54 = val_54.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_54, 丏业丟一东丂东丘丛:  false);
        return;
        label_62:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_54.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_38 = transform.position;
        UnityEngine.Vector3 val_40 = transform.position;
        UnityEngine.Vector3 val_42 = transform.position;
        UnityEngine.Vector2 val_43 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
        UnityEngine.Vector3 val_44 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_43.x, y = val_43.y});
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_53 = 0f;
        BattleRoyaleController val_47 = BattleRoyaleController.丑七不且上丗丁一世();
        val_53 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_53, y = 0f, z = 0f})) - val_47.safeZones.safeZoneRadius;
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  val_53);
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
        UnityEngine.Vector2 val_51 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
        UnityEngine.Vector3 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_51.x, y = val_51.y});
        if(val_54 != null)
        {
                val_54.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
        }
        else
        {
                0.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
        }
        
        val_54.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
    }
    private void 丆三丆东丝业丛丝丆(UnityEngine.LineRenderer 丙丆丗七专丞万丁专, NJG.UIMapBase 丞丁丑丏丄丏七丂不)
    {
        UnityEngine.GameObject val_42;
        UnityEngine.Object val_43;
        var val_44;
        NJGMap val_45;
        val_43 = 丙丆丗七专丞万丁专;
        if(val_43 == 0)
        {
                return;
        }
        
        val_44 = null;
        val_44 = null;
        val_42 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_42 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        BattleRoyaleController val_2 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_3 = val_2.safeZones.currentZonePosition;
        val_45 = this.mapInstance;
        if(((val_45 == 0) || (丞丁丑丏丄丏七丂不 == 0)) || (val_42 == 0))
        {
            goto label_49;
        }
        
        if(丞丁丑丏丄丏七丂不 != this.mapInstance)
        {
            goto label_23;
        }
        
        val_45 = this.miniMapWidget.gameObject;
        if(val_45.activeSelf == false)
        {
            goto label_49;
        }
        
        label_23:
        if(丞丁丑丏丄丏七丂不 == this.mapInstance)
        {
                if(this.worldMapWidget.gameObject.activeSelf == false)
        {
            goto label_49;
        }
        
        }
        
        BattleRoyaleController val_13 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_13.safeZones.currentZoneRadius == 0f)
        {
            goto label_49;
        }
        
        BattleRoyaleController val_15 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_18 = transform.position;
        UnityEngine.Vector3 val_20 = transform.position;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_18.x, y:  val_20.z);
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.z);
        val_45 = 1152921504850403328;
        if(val_15.safeZones.currentZoneRadius >= (UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y})))
        {
            goto label_49;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_26 = transform.position;
        UnityEngine.Vector3 val_28 = transform.position;
        UnityEngine.Vector3 val_30 = transform.position;
        UnityEngine.Vector2 val_31 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        UnityEngine.Vector3 val_32 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y});
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_42 = 0f;
        BattleRoyaleController val_35 = BattleRoyaleController.丑七不且上丗丁一世();
        val_42 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_42, y = 0f, z = 0f})) - val_35.safeZones.currentZoneRadius;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_42);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        UnityEngine.Vector2 val_39 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
        UnityEngine.Vector3 val_40 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
        if(val_43 == null)
        {
            goto label_69;
        }
        
        val_43.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        goto label_70;
        label_49:
        val_43 = val_43.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  false);
        return;
        label_69:
        0.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        label_70:
        val_43.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
    }
    private void 丈世丆丂丁上丈专下(UnityEngine.LineRenderer 丙丆丗七专丞万丁专, NJG.UIMapBase 丞丁丑丏丄丏七丂不)
    {
        var val_10;
        Player_move_c val_11;
        var val_12;
        val_10 = null;
        val_10 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_11 == 0)
        {
            goto label_13;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_11 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丙丆丗七专丞万丁专.gameObject, 丏业丟一东丂东丘丛:  true);
        BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_4 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_3.startPathPoint, y = V9.16B, z = V10.16B});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        BattleRoyaleController val_6 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_7 = 丞丁丑丏丄丏七丂不.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_6.endPathPoint, y = V12.16B, z = V13.16B});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        if(丙丆丗七专丞万丁专 == null)
        {
            goto label_25;
        }
        
        丙丆丗七专丞万丁专.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        goto label_26;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丙丆丗七专丞万丁专.gameObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_25:
        0.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        label_26:
        丙丆丗七专丞万丁专.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
    }
    private bool 丕东业丁与丆丙丕丗(UnityEngine.Vector2 丙一与世丈专丅三三, UnityEngine.Vector2 世丗不且且丅丁丝丝)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        float val_6 = (float)UnityEngine.Screen.height;
        val_6 = val_6 / (float)this.worldMapWidget.height;
        float val_7 = WorldMapClicksHandle.fingerPixelsDeadZone;
        val_7 = 0;
        val_7 = val_6 * val_7;
        float val_8 = 0.5f;
        val_7 = val_7 * val_8;
        val_8 = 丙一与世丈专丅三三.x + val_7;
        if(世丗不且且丅丁丝丝.x >= 0)
        {
                return (bool)(世丗不且且丅丁丝丝.y < 0) ? 1 : 0;
        }
        
        if(世丗不且且丅丁丝丝.x <= (丙一与世丈专丅三三.x - val_7))
        {
                return (bool)(世丗不且且丅丁丝丝.y < 0) ? 1 : 0;
        }
        
        if(世丗不且且丅丁丝丝.y <= (丙一与世丈专丅三三.y - val_7))
        {
                return (bool)(世丗不且且丅丁丝丝.y < 0) ? 1 : 0;
        }
        
        val_7 = 丙一与世丈专丅三三.y + val_7;
        return (bool)(世丗不且且丅丁丝丝.y < 0) ? 1 : 0;
    }
    public void OnWorldMapTap(UnityEngine.Vector2 丙一与世丈专丅三三)
    {
        float val_22;
        Player_move_c val_23;
        var val_24;
        var val_25;
        NJGMap val_26;
        float val_27;
        var val_28;
        var val_29;
        val_22 = 丙一与世丈专丅三三.y;
        val_23 = this;
        val_24 = null;
        val_24 = null;
        val_25 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(Player_move_c.__il2cppRuntimeField_generic_class != 0)
        {
                val_26 = this.mapInstance;
            val_25 = Player_move_c.__il2cppRuntimeField_generic_class.transform;
            UnityEngine.Vector3 val_4 = val_25.position;
            val_27 = val_4.x;
            UnityEngine.Vector2 val_5 = WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_27, y = val_4.y, z = val_4.z});
            if((this.丕东业丁与丆丙丕丗(丙一与世丈专丅三三:  new UnityEngine.Vector2() {x = 丙一与世丈专丅三三.x, y = val_22}, 世丗不且且丅丁丝丝:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) != false)
        {
                val_28 = null;
            val_28 = null;
            val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            且丑丑丂东丁业三三(专丞上七七且丝七丗:  0);
            return;
        }
        
        }
        
        UnityEngine.Vector3 val_7 = this.mapInstance.MapToWorld(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = 丙一与世丈专丅三三.x, y = val_22});
        val_22 = val_7.x;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
        val_23 = UnityEngine.Physics.RaycastAll(origin:  new UnityEngine.Vector3() {x = val_22, y = 500f, z = val_7.z}, direction:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, maxDistance:  1000f);
        if(val_23 == null)
        {
                return;
        }
        
        if(val_9.Length < 1)
        {
                return;
        }
        
        val_26 = "Marker_plane";
        val_25 = 44;
        label_43:
        var val_10 = val_23 + (0 * 44);
        if((System.String.op_Equality(a:  (0 * 44) + val_9 + 32.gameObject.name, b:  "Marker_plane")) == true)
        {
            goto label_42;
        }
        
        if(((0 * 44) + val_9 + 32.gameObject.name.Contains(value:  "Part_")) == true)
        {
            goto label_42;
        }
        
        if(((0 * 44) + val_9 + 32.gameObject.name.Contains(value:  "ter_lod_")) == true)
        {
            goto label_42;
        }
        
        if(((0 * 44) + val_9 + 32.gameObject.name.Contains(value:  "LowMesh")) == true)
        {
            goto label_42;
        }
        
        if((0 + 1) < val_9.Length)
        {
            goto label_43;
        }
        
        return;
        label_42:
        val_29 = null;
        val_29 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_22 = (0 * 44) + val_9 + 32 + 16;
        val_27 = val_7.z;
        丒万丘丈丁世下丐上(上业万丅不丛丗丈不:  new UnityEngine.Vector3() {x = val_22, y = (0 * 44) + val_9 + 32, z = val_27}, 丞万且一丄丈丛丗与:  true, 专丞上七七且丝七丗:  0);
    }
    public void ScrollWorldMap(UnityEngine.Vector2 世丕丞三一丞世与万)
    {
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = 世丕丞三一丞世与万.x, y = 世丕丞三一丞世与万.y}, d:  this.mapInstance.zoom);
        val_3.x = val_3.x + val_3.x;
        mem2[0] = val_3.x;
        val_3.x = val_3.y + val_3.x;
        mem2[0] = val_3.x;
        this.mapInstance.UpdateScrollPosition(丆丁与丆丏专丏不东:  false);
        this.不一丂且丑世万世丂();
    }
    public void ZoomWorldMap(float 业丈不业丂丙下丅下)
    {
        NJGMap val_4;
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                return;
        }
        
        val_4 = this.mapInstance;
        if(this.mapInstance != null)
        {
            goto label_4;
        }
        
        val_4 = this.mapInstance;
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_4:
        float val_2 = X21.zoom;
        val_2 = val_2 * 业丈不业丂丙下丅下;
        this.mapInstance.zoom = UnityEngine.Mathf.Clamp(value:  val_2, min:  1f, max:  V10.16B);
        this.万世东与丈丈丛丗丂();
        return;
        label_5:
    }
    public void PlayMapMarkerTapSound()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.setMarkerSound);
    }
    private void 丅七且东丟专世丁丐(UnityEngine.Transform 丆丐三三丏丘丈专丆, float 丝丕丁丏丏上丅丏且)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  丝丕丁丏丏上丅丏且);
        丆丐三三丏丘丈专丆.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    private System.Collections.IEnumerator 丒七丆不丕丂丞丂一(UnityEngine.Transform 不万且三丏丆丑丕且, float 丝业丏丄且丌业世丛, float 丞丏业丂丏七丛丝专)
    {
        MiniMapController.丄丟与丌上丅丂丌东 val_1 = new MiniMapController.丄丟与丌上丅丂丌东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .不万且三丏丆丑丕且 = 不万且三丏丆丑丕且;
            .丝业丏丄且丌业世丛 = 丝业丏丄且丌业世丛;
        }
        else
        {
                mem[32] = this;
            mem[40] = 不万且三丏丆丑丕且;
            .丝业丏丄且丌业世丛 = 丝业丏丄且丌业世丛;
        }
        
        .丞丏业丂丏七丛丝专 = 丞丏业丂丏七丛丝专;
        return (System.Collections.IEnumerator)val_1;
    }
    public void U_MiniMapClick()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_4 = null;
            val_4 = null;
            if(丆丗丂三丐不东且丏() != false)
        {
                return;
        }
        
        }
        
        this.ShowWorldMap(丛与丙丒丒下丌丟且:  true, 丞三业丕世丂丁丐专:  false);
    }
    public void U_WorlMapCloseClick()
    {
        this.ShowWorldMap(丛与丙丒丒下丌丟且:  false, 丞三业丕世丂丁丐专:  false);
    }
    internal void 丛丘丗丆丌丏不丑专(UnityEngine.GameObject 万不且且丛丆东丒业, int 丁丅丈丌丟世丗丗丟)
    {
        NJGMapItem val_1 = this.AddMiniMapIcon(业丟丏上丛与不一丝:  万不且且丛丆东丒业, 下丗丁丒丘东丂不丑:  丁丅丈丌丟世丗丗丟);
    }
    public MiniMapController()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丙丑丝丆丅与丌丁丘 = val_1;
        mem[1152921538130411420] = val_1.y;
        mem[1152921538130411424] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丗丄三专三丝专丁丙 = val_2;
        mem[1152921538130411432] = val_2.y;
        mem[1152921538130411436] = val_2.z;
    }
    private static MiniMapController()
    {
        MiniMapController.三丟丘下丅三下专业 = UnityEngine.Shader.PropertyToID(name:  "_CirclesOfst");
        MiniMapController.丛东丗专且丙丒丙丂 = UnityEngine.Shader.PropertyToID(name:  "_CirclesScl");
        MiniMapController.与丛丈不丑业下三丛 = UnityEngine.Shader.PropertyToID(name:  "_ClipRange");
    }

}
