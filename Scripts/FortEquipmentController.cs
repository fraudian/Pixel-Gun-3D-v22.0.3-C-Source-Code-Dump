using UnityEngine;
internal class FortEquipmentController : BaseEquipmentController, 东丁丆一业丈万丆丐
{
    // Fields
    internal static FortEquipmentController 丄丘七三上丕世丞业;
    public bool equipInitialized;
    private System.Collections.Generic.List<float> 且丕七丘丝丗下丒且;
    private System.Collections.Generic.List<float> 丝丘世下专丂七与丁;
    public float gateHealthMax;
    private float 丙丁丈丐万丆丟与下;
    internal const string 丝丘丞不丂丆不丘且 = "items";
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 东丑丞下且一七丏丕;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 丐与一三丞丝丞丗丂;
    
    // Methods
    private void Awake()
    {
        var val_5;
        var val_6;
        System.Action<与丅丕丈丘东丝世丟> val_7;
        val_5 = null;
        val_5 = null;
        FortEquipmentController.丝丘丞不丂丆不丘且 = this;
        mem[1152921526035174056] = this.GetComponent<PhotonView>();
        val_6 = null;
        val_6 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FortEquipmentController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_7 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_7;
        this.丙丁丈丐万丆丟与下 = this.gateHealthMax;
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FortEquipmentController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    private void Start()
    {
        this.不丌上丁丙东上丟东();
    }
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 丈专上丁世七丕专丞(int 与丁丟东丞丙丗丌丈)
    {
        var val_15;
        var val_16;
        var val_17;
        object val_18;
        var val_19;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>();
        val_1.set_Item(key:  "items", value:  new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>());
        val_15 = 1152921505066536960;
        val_16 = null;
        if(与丁丟东丞丙丗丌丈 == 1)
        {
                val_17 = null;
            val_18 = 1152921505066541424;
        }
        else
        {
                val_19 = null;
            val_18 = 1152921505066541432;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return val_1;
        }
        
        val_15 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        if((val_15.ContainsKey(key:  val_18)) == false)
        {
                return val_1;
        }
        
        val_15 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        string val_15 = val_15.Item[val_18];
        object val_10 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_15);
        if(val_10 == null)
        {
                return val_1;
        }
        
        val_15 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_10) : 0;
        Dictionary.Enumerator<TKey, TValue> val_11 = val_15.GetEnumerator();
        label_31:
        if(((-46107656) & 1) == 0)
        {
            goto label_25;
        }
        
        ConfiguredValueTaskAwaiter val_12 = 0.GetAwaiter();
        if(val_12._value._obj == 0)
        {
            goto label_31;
        }
        
        val_1.Item["items"].set_Item(key:  val_12._value._obj.丐丏七丌丕丗业且上(), value:  val_12._value._obj);
        goto label_31;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public void ResetForNewMatch(bool 且与丘丄丟丄丟丏丝)
    {
        this.丙丁丈丐万丆丟与下 = this.gateHealthMax;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_3 = this.丈专上丁世七丕专丞(与丁丟东丞丙丗丌丈:  ((且与丘丄丟丄丟丏丝 & true) != 0) ? (true + 1) : true);
        this.ResetFortItems(丞与丁丒下业丙东丟:  val_3, 业业下丗三不万业丙:  val_3.丈专上丁世七丕专丞(与丁丟东丞丙丗丌丈:  (且与丘丄丟丄丟丏丝 != true) ? (true + 1) : true), 丟丏丆丒丐万不且业:  false);
        this.equipInitialized = true;
    }
    public void SetEquipForFortDefence(System.Collections.Generic.List<FortEquipObject> 一东丟丈丐丟丂丆上)
    {
        this.丙丁丈丐万丆丟与下 = this.gateHealthMax;
        mem[1152921526035915392] = 一东丟丈丐丟丂丆上.ToArray();
        this.不丌上丁丙东上丟东();
        this.equipInitialized = true;
    }
    public FortEquipObject GetEquipmentByID(byte 丞丅上丏丂且下丅与)
    {
        var val_3;
        var val_4;
        val_3 = 丞丅上丏丂且下丅与;
        if((val_3 & 255) < (X22 + 24))
        {
                val_3 = val_3 & 255;
            FortEquipmentController val_2 = this + (((丞丅上丏丂且下丅与 & 255)) << 3);
            return (FortEquipObject)val_4;
        }
        
        val_4 = 0;
        return (FortEquipObject)val_4;
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_6;
        var val_7;
        if(this.equipInitialized == false)
        {
                return;
        }
        
        this.且丕七丘丝丗下丒且.Clear();
        this.丝丘世下专丂七与丁.Clear();
        val_6 = 0;
        goto label_4;
        label_15:
        if(this.equipInitialized != false)
        {
                var val_1 = X23 + 0;
            if(((X23 + 0) + 32 + 72) != 0)
        {
                this.且丕七丘丝丗下丒且.Add(item:  (X23 + 0) + 32 + 112);
            val_7 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        }
        else
        {
                this.且丕七丘丝丗下丒且.Add(item:  0f);
            val_7 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        }
        
            this.丝丘世下专丂七与丁.Add(item:  (float)(X23 + 0) + 32 + 120);
        }
        
        val_6 = 1;
        label_4:
        if(val_6 < (X23 + 24))
        {
            goto label_15;
        }
        
        object[] val_2 = new object[3];
        val_2[0] = this.丙丁丈丐万丆丟与下;
        val_2[1] = this.且丕七丘丝丗下丒且.ToArray();
        val_2[2] = this.丝丘世下专丂七与丁.ToArray();
        this.丝丘世下专丂七与丁.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  128, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
    }
    protected override void 丑丂业且下上丝丈世(float 丙丁丈丐万丆丟与下, float[] 世丙丟上丘上七万万, float[] 丈且上丆东丞丏万且)
    {
        float val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<System.Single> val_13;
        var val_14;
        var val_15;
        val_10 = 丙丁丈丐万丆丟与下;
        this.且丕七丘丝丗下丒且.Clear();
        this.且丕七丘丝丗下丒且.AddRange(collection:  世丙丟上丘上七万万);
        this.丝丘世下专丂七与丁.Clear();
        this.丝丘世下专丂七与丁.AddRange(collection:  丈且上丆东丞丏万且);
        val_11 = 1152921504838422528;
        val_12 = 0;
        goto label_5;
        label_13:
        this.且丕七丘丝丗下丒且.set_Item(index:  0, value:  UnityEngine.Mathf.Min(a:  this.且丕七丘丝丗下丒且.Item[0], b:  世丙丟上丘上七万万[0]));
        val_12 = 1;
        label_5:
        if(val_12 < this.且丕七丘丝丗下丒且.Count)
        {
            goto label_13;
        }
        
        val_13 = 1152921504622448640;
        val_14 = 0;
        goto label_14;
        label_22:
        val_11 = 0;
        this.丝丘世下专丂七与丁.set_Item(index:  0, value:  System.Math.Min(val1:  this.丝丘世下专丂七与丁.Item[0], val2:  丈且上丆东丞丏万且[val_11]));
        val_14 = 1;
        label_14:
        if(val_14 < this.丝丘世下专丂七与丁.Count)
        {
            goto label_22;
        }
        
        this.丙丁丈丐万丆丟与下 = val_10;
        val_15 = 0;
        this.equipInitialized = true;
    }
    public float CheckGateHealth(float 丞丈专下丈专业三丞)
    {
        return UnityEngine.Mathf.Max(a:  0f, b:  this.丙丁丈丐万丆丟与下 - 丞丈专下丈专业三丞);
    }
    public void UpdateGateHealth(float 丄东丙丄丞三万世丂)
    {
        string val_8;
        var val_9;
        UnityEngine.Object val_10;
        var val_11;
        if(this.丙丁丈丐万丆丟与下 == 丄东丙丄丞三万世丂)
        {
                return;
        }
        
        if(丄东丙丄丞三万世丂 > 0f)
        {
                val_8 = "Explosion67";
        }
        else
        {
                this.OnGateBroken();
            val_8 = "Explosion698";
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = mem[SiegeController.三三万丆下一丗万丛 + 136];
        val_10 = SiegeController.三三万丆下一丗万丛 + 136;
        if(val_10 != 0)
        {
                val_10 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟;
            UnityEngine.GameObject val_3 = val_10.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  val_8));
            if(val_3 != 0)
        {
                val_11 = null;
            val_11 = null;
            val_10 = SiegeController.三三万丆下一丗万丛 + 136.transform;
            UnityEngine.Vector3 val_7 = val_10.position;
            val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        }
        
        this.丙丁丈丐万丆丟与下 = 丄东丙丄丞三万世丂;
    }
    public void OnGateBroken()
    {
        var val_4;
        Player_move_c val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = SiegeController.三三万丆下一丗万丛;
        if(val_5.inAttackTeam == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  108, 专上丝且丂世丛丝丒:  1f);
        Rilisoft.丞丛七上丕专丏丌丈.万丞丞丝丘下丆三丞(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
    }
    public bool IsGatesBroken()
    {
        return (bool)(this.丙丁丈丐万丆丟与下 <= 0f) ? 1 : 0;
    }
    public void ResetFortItems(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 丞与丁丒下业丙东丟, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>>> 业业下丗三不万业丙, bool 丟丏丆丒丐万不且业)
    {
        int val_11;
        FortEquipmentController val_87;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_88;
        System.Object[] val_89;
        string val_90;
        var val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_96;
        var val_97;
        System.Func<T, TResult> val_98;
        var val_99;
        System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean> val_101;
        var val_102;
        System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐> val_104;
        System.Collections.Generic.List<TSource> val_105;
        var val_106;
        System.Collections.Generic.IEnumerable<TSource> val_107;
        var val_109;
        System.Func<UnityEngine.Transform, System.String> val_111;
        var val_112;
        System.Collections.Generic.List<T> val_113;
        T[] val_114;
        var val_115;
        var val_116;
        System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.String> val_118;
        val_87 = this;
        if((丞与丁丒下业丙东丟 == null) || (业业下丗三不万业丙 == null))
        {
            goto label_2;
        }
        
        if(((业业下丗三不万业丙.ContainsKey(key:  "items")) == false) || ((丞与丁丒下业丙东丟.ContainsKey(key:  "items")) == false))
        {
            goto label_4;
        }
        
        val_88 = 业业下丗三不万业丙.Item["items"];
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = 丞与丁丒下业丙东丟.Item["items"];
        if((val_88 == null) || (val_4 == null))
        {
            goto label_6;
        }
        
        System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, UnityEngine.Transform> val_5 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, UnityEngine.Transform>();
        Rilisoft.FortCraftController.业丌且专一下世丐丟(丗专世丅一丏丟下丅:  val_5, 且丏丟丏下七丂业与:  CraftFortPlacePoints.instance.gameObject);
        Dictionary.Enumerator<TKey, TValue> val_8 = val_5.GetEnumerator();
        goto label_11;
        label_2:
        val_89 = System.Array.Empty<System.Object>();
        val_90 = "ResetFortItems attackers == null || defenders == null";
        goto label_19;
        label_4:
        val_89 = System.Array.Empty<System.Object>();
        val_90 = "ResetFortItems ! defenders.ContainsKey(ITEMS_KEY) || ! attackers.ContainsKey(ITEMS_KEY)";
        label_19:
        UnityEngine.Debug.LogErrorFormat(format:  val_90, args:  val_89);
        return;
        label_6:
        T[] val_14 = System.Array.Empty<System.Object>();
        goto label_19;
        label_44:
        ConfiguredValueTaskAwaiter val_15 = val_11.GetAwaiter();
        val_91 = Rilisoft.FortCraftController.丕丐下丙丏丕丘丈世(与丄不丌一世东丁丙:  val_15._value._obj.丙东专丂世丈丏丁丂(), 与丄丙丌上丅丑世丛:  val_15._value._obj);
        val_87 = val_87;
        if(val_91 == null)
        {
                val_91 = new UnityEngine.Transform[0];
        }
        
        val_92 = 0;
        goto label_23;
        label_43:
        UnityEngine.Transform val_87 = val_91[0];
        System.Collections.Generic.List<UnityEngine.GameObject> val_19 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        val_93 = 0;
        goto label_25;
        label_35:
        if((val_87.GetChild(index:  0).GetComponent<ClanFortnessItemMaterials>()) == 0)
        {
                null.Add(item:  val_87.GetChild(index:  0).gameObject);
        }
        
        val_93 = 1;
        label_25:
        if(val_93 < val_87.childCount)
        {
            goto label_35;
        }
        
        val_94 = 0;
        goto label_36;
        label_41:
        UnityEngine.Object.Destroy(obj:  null.Item[0]);
        val_94 = 1;
        label_36:
        if(val_94 < null.Count)
        {
            goto label_41;
        }
        
        val_87 = val_87;
        val_88 = val_88;
        val_92 = 1;
        label_23:
        if(val_92 < val_18.Length)
        {
            goto label_43;
        }
        
        label_11:
        if(((-43830048) & 1) != 0)
        {
            goto label_44;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(TramController.丄丘七三上丕世丞业.tramObject != 0)
        {
                transform.parent = 0;
            UnityEngine.Object.Destroy(obj:  gameObject);
        }
        
        mem[1152921526037865616] = new FortEquipObject[0];
        TramController.丄丘七三上丕世丞业.tramObject = 0;
        System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String> val_32 = FortEquipmentController.丆业丈七丙丛丐丌万(丆丟丞丅丘丛七丛丙:  null);
        val_96 = null;
        val_96 = 1152921505062809600;
        val_97 = null;
        System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean> val_34 = null;
        val_98 = val_34;
        val_34 = new System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortEquipmentController.<>c::丝且东丐且丄丄一且(System.Collections.Generic.KeyValuePair<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丏万丄丒业丅丒一));
        FortEquipmentController.<>c.<>9__20_0 = val_98;
        val_99 = null;
        val_99 = null;
        val_101 = FortEquipmentController.<>c.<>9__20_1;
        if(val_101 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean> val_36 = null;
            val_101 = val_36;
            val_36 = new System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortEquipmentController.<>c::丅丕业专世丄东丅丌(System.Collections.Generic.KeyValuePair<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丏万丄丒业丅丒一));
            FortEquipmentController.<>c.<>9__20_1 = val_101;
        }
        
        val_102 = null;
        val_102 = null;
        val_104 = FortEquipmentController.<>c.<>9__20_2;
        if(val_104 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐> val_39 = null;
            val_104 = val_39;
            val_39 = new System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  丗丞丏丙七丑丕且丐 FortEquipmentController.<>c::丙丞丘三丒丁丄丐丆(System.Collections.Generic.KeyValuePair<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丏万丄丒业丅丒一));
            FortEquipmentController.<>c.<>9__20_2 = val_104;
        }
        
        val_105 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐>(source:  System.Linq.Enumerable.Concat<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(first:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(source:  val_32, predicate:  val_34), second:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(source:  FortEquipmentController.丆业丈七丙丛丐丌万(丆丟丞丅丘丛七丛丙:  val_4), predicate:  val_36)), keySelector:  val_39));
        System.Collections.Generic.List<FortEquipObject> val_42 = new System.Collections.Generic.List<FortEquipObject>();
        val_106 = 0;
        goto label_94;
        label_142:
        System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String> val_43 = val_105.Item[0];
        if((val_39.ContainsKey(key:  val_43.Value.丙东专丂世丈丏丁丂())) == false)
        {
            goto label_97;
        }
        
        val_107 = Rilisoft.FortCraftController.丕丐下丙丏丕丘丈世(与丄不丌一世东丁丙:  val_43.Value.丙东专丂世丈丏丁丂(), 与丄丙丌上丅丑世丛:  val_39.Item[val_43.Value.丙东专丂世丈丏丁丂()]);
        if(val_107 == null)
        {
                UnityEngine.Transform[] val_50 = new UnityEngine.Transform[0];
            val_107 = val_50;
        }
        
        if(val_43.Value.丙东专丂世丈丏丁丂() != 1000)
        {
            goto label_102;
        }
        
        UnityEngine.Transform[] val_52 = new UnityEngine.Transform[1];
        goto label_103;
        label_97:
        object[] val_53 = new object[1];
        val_11 = val_43.Value.丙东专丂世丈丏丁丂();
        val_53[0] = val_11;
        UnityEngine.Debug.LogErrorFormat(format:  "ResetFortItems not found slot: {0}", args:  val_53);
        goto label_118;
        label_102:
        val_109 = null;
        val_109 = null;
        val_111 = FortEquipmentController.<>c.<>9__20_4;
        if(val_111 == null)
        {
                System.Func<UnityEngine.Transform, System.String> val_55 = null;
            val_111 = val_55;
            val_55 = new System.Func<UnityEngine.Transform, System.String>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.String FortEquipmentController.<>c::一专丕且丞东专丟世(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            FortEquipmentController.<>c.<>9__20_4 = val_111;
        }
        
        label_103:
        UnityEngine.Transform val_59 = UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "FortItemsContent/InGame/"("FortItemsContent/InGame/") + val_43.Value);
        if(val_59 == 0)
        {
            goto label_118;
        }
        
        val_112 = 0;
        goto label_119;
        label_140:
        UnityEngine.Transform val_61 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_59, parent:  System.Linq.Enumerable.ToArray<UnityEngine.Transform>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.Transform, System.String>(source:  val_50, keySelector:  val_55))[0]);
        UnityEngine.Vector3 val_62 = UnityEngine.Vector3.zero;
        val_61.localPosition = new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z};
        UnityEngine.Quaternion val_63 = UnityEngine.Quaternion.identity;
        val_61.localRotation = new UnityEngine.Quaternion() {x = val_63.x, y = val_63.y, z = val_63.z, w = val_63.w};
        UnityEngine.Vector3 val_64 = UnityEngine.Vector3.one;
        val_61.localScale = new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z};
        if(val_43.Value.丙东专丂世丈丏丁丂() == 1000)
        {
                TramController.丄丘七三上丕世丞业.RegisterTramObject(丌一丂专世上丆丁专:  val_61.GetComponent<TramObject>());
        }
        else
        {
                FortEquipObject val_67 = val_61.GetComponent<FortEquipObject>();
            if(val_67 != 0)
        {
                val_113 = val_42;
            if(val_113 == 0)
        {
                val_113 = val_42;
        }
        
            val_42.Add(item:  val_67);
        }
        
        }
        
        val_112 = 1;
        label_119:
        if(val_112 < val_57.Length)
        {
            goto label_140;
        }
        
        label_118:
        val_105 = val_105;
        val_106 = 1;
        label_94:
        if(val_106 < val_105.Count)
        {
            goto label_142;
        }
        
        val_114 = val_42.ToArray();
        val_115 = 0;
        mem[1152921526037865616] = val_114;
        goto label_144;
        label_151:
        T[] val_71 = mem[1152921526037865616] + 0;
        val_114 = mem[1152921526037865616];
        val_115 = 0 + 1;
        label_144:
        if((UnityEngine.Mathf.Min(a:  val_70 + 24, b:  255)) > val_115)
        {
            goto label_151;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_116 = null;
        val_116 = null;
        val_118 = FortEquipmentController.<>c.<>9__20_3;
        if(val_118 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.String> val_75 = null;
            val_118 = val_75;
            val_75 = new System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.String>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.String FortEquipmentController.<>c::万丕丕且万一丁丙丕(System.Collections.Generic.KeyValuePair<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丏万丄丒业丅丒一));
            FortEquipmentController.<>c.<>9__20_3 = val_118;
        }
        
        UnityEngine.Coroutine val_79 = CoroutineRunner.Instance.StartCoroutine(routine:  FortEquipmentController.业专业且专丈丘一与(丑七不与丛丆一丂丞:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.String>(source:  val_105, selector:  val_75))));
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Fort Status", 下下丏一丙不丘丌丞:  ((System.Linq.Enumerable.Any<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  val_32.Values, second:  Rilisoft.FortsManager.丈丕丗丕丆丛丄丆丘().Values))) != true) ? "Clan" : "Default");
    }
    public int GetItemsConfigForFortFillingAnalytics(int 七一丞丈万丛下丘上)
    {
        return FortEquipmentController.丐丘一丐丏丏上丙丝(丟丂世且不丁丝东且:  this.丈专上丁世七丕专丞(与丁丟东丞丙丗丌丈:  七一丞丈万丛下丘上).Item["items"]);
    }
    private static int 丐丘一丐丏丏上丙丝(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丟丂世且不丁丝东且)
    {
        if(丟丂世且不丁丝东且 == null)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<丗丞丏丙七丑丕且丐> val_3 = new System.Collections.Generic.List<丗丞丏丙七丑丕且丐>();
        if(val_3 == null)
        {
            goto label_4;
        }
        
        val_3.Add(item:  235);
        val_3.Add(item:  236);
        val_3.Add(item:  237);
        val_3.Add(item:  238);
        val_3.Add(item:  247);
        val_3.Add(item:  250);
        val_3.Add(item:  251);
        goto label_5;
        label_1:
        UnityEngine.Debug.LogErrorFormat(format:  "DefendersConfigForFortFillingAnalytics defendersConfig == null", args:  System.Array.Empty<System.Object>());
        return 0;
        label_4:
        val_3.Add(item:  235);
        val_3.Add(item:  236);
        val_3.Add(item:  237);
        val_3.Add(item:  238);
        val_3.Add(item:  247);
        val_3.Add(item:  250);
        val_3.Add(item:  251);
        label_5:
        val_3.Add(item:  1020);
        .专且丙丄业一业丒东 = val_3;
        return System.Linq.Enumerable.Count<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>>(source:  FortEquipmentController.丆业丈七丙丛丐丌万(丆丟丞丅丘丛七丛丙:  丟丂世且不丁丝东且), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, System.String>, System.Boolean>(object:  new FortEquipmentController.丌丐丝丐下上三丛丌(), method:  System.Boolean FortEquipmentController.丌丐丝丐下上三丛丌::丏丘一丟丗丛丄丟上(System.Collections.Generic.KeyValuePair<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丈丏万丄丒业丅丒一))));
    }
    private static System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 丆业丈七丙丛丐丌万(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丆丟丞丅丘丛七丛丙)
    {
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean> val_16;
        var val_17;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, 丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>> val_19;
        var val_20;
        System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐> val_22;
        System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, System.String> val_24;
        val_14 = null;
        val_14 = null;
        val_16 = FortEquipmentController.<>c.<>9__23_0;
        if(val_16 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean> val_1 = null;
            val_16 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortEquipmentController.<>c::丛与丗丌丅与丕东上(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 丈丏万丄丒业丅丒一));
            FortEquipmentController.<>c.<>9__23_0 = val_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = FortEquipmentController.<>c.<>9__23_1;
        if(val_19 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, 丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>> val_3 = null;
            val_19 = val_3;
            val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, 丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String> FortEquipmentController.<>c::丐丏丘丝丝丆丕丅丌(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 丈丏万丄丒业丅丒一));
            FortEquipmentController.<>c.<>9__23_1 = val_19;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = FortEquipmentController.<>c.<>9__23_2;
        if(val_22 == null)
        {
                System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐> val_5 = null;
            val_22 = val_5;
            val_5 = new System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  丗丞丏丙七丑丕且丐 FortEquipmentController.<>c::丕丂丙丂丕丙丑丘丕(丙丝世丛丂丘丝丂万<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 下丅丙一丂丗丅丝七));
            val_20 = null;
            FortEquipmentController.<>c.<>9__23_2 = val_22;
        }
        
        val_20 = null;
        val_24 = FortEquipmentController.<>c.<>9__23_3;
        if(val_24 == null)
        {
                System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, System.String> val_6 = null;
            val_24 = val_6;
            val_6 = new System.Func<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, System.String>(object:  FortEquipmentController.<>c.__il2cppRuntimeField_static_fields, method:  System.String FortEquipmentController.<>c::丆丟丗丝丏上一世丒(丙丝世丛丂丘丝丂万<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, string> 下丅丙一丂丗丅丝七));
            FortEquipmentController.<>c.<>9__23_3 = val_24;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_7 = System.Linq.Enumerable.ToDictionary<丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>, 丗丞丏丙七丑丕且丐, System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, 丙丝世丛丂丘丝丂万<丗丞丏丙七丑丕且丐, System.String>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  丆丟丞丅丘丛七丛丙, predicate:  val_1), selector:  val_3), keySelector:  val_5, elementSelector:  val_6);
        Dictionary.Enumerator<TKey, TValue> val_9 = Rilisoft.FortsManager.丈丕丗丕丆丛丄丆丘().GetEnumerator();
        label_28:
        if(((-42825096) & 1) == 0)
        {
            goto label_24;
        }
        
        ConfiguredValueTaskAwaiter val_10 = 0.GetAwaiter();
        if((val_7.ContainsKey(key:  val_10._value._obj.丙东专丂世丈丏丁丂())) == true)
        {
            goto label_28;
        }
        
        val_7.Add(key:  val_10._value._obj.丙东专丂世丈丏丁丂(), value:  val_10._value._obj);
        goto label_28;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String>)val_7;
    }
    private static System.Collections.IEnumerator 业专业且专丈丘一与(System.Collections.Generic.List<string> 丑七不与丛丆一丂丞)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丑七不与丛丆一丂丞 = 丑七不与丛丆一丂丞;
        return (System.Collections.IEnumerator)new FortEquipmentController.丕七下世丑丒丕丅一();
    }
    public FortEquipmentController()
    {
        this.且丕七丘丝丗下丒且 = new System.Collections.Generic.List<System.Single>();
        this.丝丘世下专丂七与丁 = new System.Collections.Generic.List<System.Single>();
        this.gateHealthMax = 1000f;
    }
    private static FortEquipmentController()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_3.Add(key:  "id", value:  "fort_artillery_satellite");
        val_2.Add(key:  "Artillery", value:  val_3);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_4.Add(key:  "id", value:  "fort_mines");
        val_2.Add(key:  "Traps", value:  val_4);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_5.Add(key:  "id", value:  "fort_machine_gun_turret");
        val_2.Add(key:  "TurretsNier1", value:  val_5);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_6.Add(key:  "id", value:  "fort_rocket_turret");
        val_2.Add(key:  "TurretsNier2", value:  val_6);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_7.Add(key:  "id", value:  "fort_firethrower_turret");
        val_2.Add(key:  "TurretsFar2", value:  val_7);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_8.Add(key:  "id", value:  "fort_zombie_horde");
        val_2.Add(key:  "Monsters", value:  val_8);
        val_1.Add(key:  "items", value:  val_2);
        FortEquipmentController.东丑丞下且一七丏丕 = val_1;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_10 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_11.Add(key:  "id", value:  "fort_artillery_catapult");
        val_10.Add(key:  "Artillery", value:  val_11);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_12.Add(key:  "id", value:  "fort_mines");
        val_10.Add(key:  "Traps", value:  val_12);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_13.Add(key:  "id", value:  "fort_firethrower_turret");
        val_10.Add(key:  "TurretsNier1", value:  val_13);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_14.Add(key:  "id", value:  "fort_rocket_turret");
        val_10.Add(key:  "TurretsFar1", value:  val_14);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_15.Add(key:  "id", value:  "fort_machine_gun_turret");
        val_10.Add(key:  "TurretsFar2", value:  val_15);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_16.Add(key:  "id", value:  "fort_flock_of_spiders");
        val_10.Add(key:  "Monsters", value:  val_16);
        val_9.Add(key:  "items", value:  val_10);
        FortEquipmentController.丐与一三丞丝丞丗丂 = val_9;
    }

}
