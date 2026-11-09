using UnityEngine;
public class ClanWarMap : MonoBehaviour
{
    // Fields
    private static ClanWarMap <不丁丄七丛不丆丁丕>k__BackingField;
    public MiniPoolMonoBehaviour cellFlagsPool;
    private PGCompany.HexagonField _field;
    private System.Collections.Generic.List<UnityEngine.Transform> castelPoints;
    private readonly System.Collections.Generic.List<不上丌世万丁丝丏丆> 丙不丙世三丙且丗专;
    private readonly System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> 丒与丂业丆三丞上下;
    private readonly System.Collections.Generic.Dictionary<string, 丛与三东七专下丗丗> 业丁丕丐丐丏世丕世;
    private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> 万丂丌万世丏七上丗;
    private System.Action<不上丌世万丁丝丏丆> 丒丂与不上丙专丁丞;
    private System.Nullable<DiscreteVector2> <丗世世一丄东丆丘业>k__BackingField;
    internal System.Nullable<DiscreteVector2> 丄丈丞丝上丛丟丄七;
    private System.Collections.Generic.List<DiscreteVector2> 不丆专上丘丅三上万;
    private System.Collections.Generic.List<PGCompany.ClanWarMapCellConfig> 丟专业一丆丕丒丄下;
    private UnityEngine.GameObject 丝不丄丟与七万丈丆;
    private UnityEngine.GameObject 丂上丗丑丝下万丞与;
    private UnityEngine.GameObject 与丐三世与丙丗万丞;
    private UnityEngine.GameObject 万丝丘下丈且与不丞;
    private UnityEngine.GameObject 丟丏万专且丘丑丄东;
    private UnityEngine.Vector3[] 丗七万丒丞丂丘上丑;
    private UnityEngine.Vector2[] 丟且丏丞与东一不丟;
    private int[] 且丄丄七不丂下丅与;
    private ClanWarMap.丟丒下与下业业丗丄 丛丕丈丒丂且丛与下;
    private System.Collections.Generic.Dictionary<string, ClanWarMap.丟丒下与下业业丗丄> 丏丂丒世丛丑七丁世;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Material> 丛专丅丙专东东丂丌;
    private UnityEngine.Material 丑业与丙丞丑东丏丛;
    private UnityEngine.Material 世丌丛业丘且万七丗;
    private UIRect mapRect;
    private float cameraPosOffset;
    private float rightPanelWidth;
    
    // Properties
    internal static ClanWarMap 丆丕丝丒不丙且丐丗 { get; set; }
    internal PGCompany.HexagonField 丛业丛丑丈三丛丟业 { get; }
    internal System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> 丏丞东丙丒不丆丝万 { get; }
    internal System.Collections.Generic.Dictionary<string, 丛与三东七专下丗丗> 与丒丛丐丁世丗丁丁 { get; }
    internal System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> 丑丝世七下万丘丙丛 { get; }
    internal System.Nullable<DiscreteVector2> 世上丆下丆下丘业丘 { get; set; }
    internal 不上丌世万丁丝丏丆 丗丕丒下丐丁丞丛七 { get; }
    internal 不上丌世万丁丝丏丆 东丄丘丙专丝与丘丒 { get; }
    
    // Methods
    internal static ClanWarMap 丑七不且上丗丁一世()
    {
        return (ClanWarMap)ClanWarMap.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ClanWarMap 丙业与丙丗丝不丈东)
    {
        ClanWarMap.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.HexagonField 丙丆丅丐丝丄与七丒()
    {
        return (PGCompany.HexagonField)this._field;
    }
    internal System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> 丟与丅东丁丗丆专一()
    {
        return (System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆>)this.丒与丂业丆三丞上下;
    }
    internal System.Collections.Generic.Dictionary<string, 丛与三东七专下丗丗> 不丆丁与丐丝丐丆丞()
    {
        return (System.Collections.Generic.Dictionary<System.String, 丛与三东七专下丗丗>)this.业丁丕丐丐丏世丕世;
    }
    internal System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> 丗一丘丄丁丆东上且()
    {
        return (System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>)this.万丂丌万世丏七上丗;
    }
    internal void 丐丕世万七丌丄丄丟(System.Action<不上丌世万丁丝丏丆> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒丂与不上丙专丁丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丂与不上丙专丁丞 != 1152921536777970624);
    
    }
    internal void 丒专一与丌丝丑世丞(System.Action<不上丌世万丁丝丏丆> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒丂与不上丙专丁丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒丂与不上丙专丁丞 != 1152921536778107200);
    
    }
    internal System.Nullable<DiscreteVector2> 且丏不不业丅丄业不()
    {
        return (System.Nullable<DiscreteVector2>)this.<丗世世一丄东丆丘业>k__BackingField;
    }
    private void 丙七丛与丗万一丌丕(System.Nullable<DiscreteVector2> 丙业与丙丗丝不丈东)
    {
        this.<丗世世一丄东丆丘业>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921536778343504] = ???;
    }
    internal 不上丌世万丁丝丏丆 丆丆丘且丑丅丝丟丙()
    {
        var val_3;
        var val_4;
        val_3 = this;
        if(( & 1) != 0)
        {
                if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = 2106841680, _y = 268435463})) != false)
        {
                val_3 = ;
            不上丌世万丁丝丏丆 val_2 = this.丒与丂业丆三丞上下.Item[new DiscreteVector2() {_x = 2106841680, _y = 268435463}];
            return (不上丌世万丁丝丏丆)val_4;
        }
        
        }
        
        val_4 = 0;
        return (不上丌世万丁丝丏丆)val_4;
    }
    internal 不上丌世万丁丝丏丆 丅上丝万丐七丝专丑()
    {
        System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆> val_3;
        var val_4;
        val_3 = this;
        if((this.丄丈丞丝上丛丟丄七 & 1) != 0)
        {
                if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = this.丄丈丞丝上丛丟丄七, _y = this.丄丈丞丝上丛丟丄七})) != false)
        {
                val_3 = this.丒与丂业丆三丞上下;
            不上丌世万丁丝丏丆 val_2 = val_3.Item[new DiscreteVector2() {_x = this.丄丈丞丝上丛丟丄七, _y = this.丄丈丞丝上丛丟丄七}];
            return (不上丌世万丁丝丏丆)val_4;
        }
        
        }
        
        val_4 = 0;
        return (不上丌世万丁丝丏丆)val_4;
    }
    private void Start()
    {
        this.Init();
        ClanWarMap.<不丁丄七丛不丆丁丕>k__BackingField = this;
    }
    private void OnEnable()
    {
        PGCompany.ClanWarProgressController.丗万一丌丂丄上丐七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanWarMap::Init()));
        PGCompany.ClanWarController.世与三丅丅丞专丘丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarMap::丐丒业且上丞丐丒与()));
        PGCompany.ClanWarProgressController.丝丅丐世丗丅丘丏丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanWarMap::Init()));
        PGCompany.ClanWarController.丌丈三丒丐丆七丆丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarMap::丐丒业且上丞丐丒与()));
    }
    private void OnDisable()
    {
        PGCompany.ClanWarProgressController.丗万一丌丂丄上丐七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanWarMap::Init()));
        PGCompany.ClanWarController.世与三丅丅丞专丘丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarMap::丐丒业且上丞丐丒与()));
    }
    private void OnDestroy()
    {
        ClanWarMap.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        PGCompany.ClanWarProgressController.丗万一丌丂丄上丐七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanWarMap::Init()));
        PGCompany.ClanWarController.世与三丅丅丞专丘丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarMap::丐丒业且上丞丐丒与()));
    }
    public void Init()
    {
        UnityEngine.Object val_3;
        var val_25;
        System.Func<PGCompany.ClanWarMapCellConfig, DiscreteVector2> val_27;
        UnityEngine.Object val_28;
        var val_29;
        var val_30;
        List.Enumerator<T> val_1 = this.丙不丙世三丙且丗专.GetEnumerator();
        label_4:
        if((2107752992 & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.丐丏七丌丕丗业且上().Dispose();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Dictionary.Enumerator<TKey, TValue> val_5 = this.业丁丕丐丐丏世丕世.GetEnumerator();
        label_12:
        if((2107752944 & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_3.GetAwaiter();
        val_7._value._obj.Dispose();
        goto label_12;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丙不丙世三丙且丗专.Clear();
        this.丒与丂业丆三丞上下.Clear();
        this.业丁丕丐丐丏世丕世.Clear();
        this.丛专丅丙专东东丂丌.Clear();
        System.Collections.Generic.List<PGCompany.ClanWarMapCellConfig> val_9 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.万不与丐丐丝丒下业();
        this.丟专业一丆丕丒丄下 = val_9;
        val_25 = null;
        val_25 = null;
        val_27 = ClanWarMap.<>c.<>9__51_0;
        if(val_27 == null)
        {
                System.Func<PGCompany.ClanWarMapCellConfig, DiscreteVector2> val_10 = null;
            val_27 = val_10;
            val_10 = new System.Func<PGCompany.ClanWarMapCellConfig, DiscreteVector2>(object:  ClanWarMap.<>c.__il2cppRuntimeField_static_fields, method:  DiscreteVector2 ClanWarMap.<>c::丛丙丅一丞丑丗与丟(PGCompany.ClanWarMapCellConfig 三丟东丕丄丄下下丑));
            ClanWarMap.<>c.<>9__51_0 = val_27;
        }
        
        this.不丆专上丘丅三上万 = System.Linq.Enumerable.ToList<DiscreteVector2>(source:  System.Linq.Enumerable.Select<PGCompany.ClanWarMapCellConfig, DiscreteVector2>(source:  val_9, selector:  val_10));
        this.丝不丄丟与七万丈丆 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\cw-tiles-big-mesh");
        this.丂上丗丑丝下万丞与 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\cw-tiles-outline-big-mesh");
        this.与丐三世与丙丗万丞 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\cw-tiles-outline2-big-mesh");
        this.丑业与丙丞丑东丏丛 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Clans\\War\\Materials\\cw_tile_outline");
        mem[1152921536779383392] = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Clans\\War\\Materials\\cw_tile_outline2");
        if(this.万丝丘下丈且与不丞 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.万丝丘下丈且与不丞);
        }
        
        if(this.丟丏万专且丘丑丄东 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丟丏万专且丘丑丄东);
        }
        
        this.万丝丘下丈且与不丞 = 0;
        this.丟丏万专且丘丑丄东 = 0;
        if(this.丛丕丈丒丂且丛与下 != null)
        {
                if(this.丛丕丈丒丂且丛与下.丑与丗丛丝丈丙丆丌 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丛丕丈丒丂且丛与下.丑与丗丛丝丈丙丆丌);
            this.丛丕丈丒丂且丛与下.丑与丗丛丝丈丙丆丌 = 0;
        }
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_21 = this.丏丂丒世丛丑七丁世.GetEnumerator();
        label_57:
        if((2107752880 & 1) == 0)
        {
            goto label_47;
        }
        
        ConfiguredValueTaskAwaiter val_22 = val_3.GetAwaiter();
        var val_23 = (2107752864 == 0) ? 0 : 2107752864;
        if(val_22._value._obj != 0)
        {
                val_28 = mem[0x100000077DA1C1A0 == 0x0 ? 0 : 1152921536779370912 + 16];
            val_28 = 0x100000077DA1C1A0 == 0x0 ? 0 : 1152921536779370912 + 16;
        }
        else
        {
                val_28 = 0;
        }
        
        if(val_28 == 0)
        {
            goto label_57;
        }
        
        UnityEngine.Object.Destroy(obj:  val_3);
        goto label_57;
        label_47:
        val_29 = 0;
        val_30 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_63;
        }
        
        if(( == 0) || (514 == 514))
        {
            goto label_68;
        }
        
        label_67:
        label_68:
        this.丏丂丒世丛丑七丁世.Clear();
        this.RefreshField();
        return;
        label_63:
        if( != 0)
        {
            goto label_67;
        }
        
        goto label_68;
    }
    private void 丐丒业且上丞丐丒与()
    {
        List.Enumerator<T> val_1 = this.丙不丙世三丙且丗专.GetEnumerator();
        label_4:
        if((2107983832 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().三丘世丕东丟丛丄丗();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.Generic.List<DiscreteVector2> 丏世丗丈丘三丟下丛(int 丟丒且一专丟丙下一)
    {
        System.Collections.Generic.List<DiscreteVector2> val_1 = new System.Collections.Generic.List<DiscreteVector2>();
        DiscreteVector2 val_2 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
        val_1.Add(item:  new DiscreteVector2() {_x = val_2._x, _y = val_2._x});
        DiscreteVector2 val_3 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
        val_1.AddRange(collection:  丝丙一上业丁且丄不.业丗丕丌丏丁丗丁万(下业丕七东丌丝下且:  new DiscreteVector2() {_x = val_3._x, _y = val_3._x}, 且丛上丕业丂丒与一:  丟丒且一专丟丙下一));
        return val_1;
    }
    private void 东丘下与丆且丈丝丏(UnityEngine.GameObject 丗丕丙七丂丏丕东丈, float 丟丒且一专丟丙下一, System.Predicate<不上丌世万丁丝丏丆> 世丏丌一丝七丘丕丅)
    {
        var val_18;
        var val_27;
        var val_28;
        var val_29;
        System.Collections.Generic.List<不上丌世万丁丝丏丆> val_30;
        var val_31;
        var val_32;
        var val_33;
        UnityEngine.Vector2[] val_34;
        float val_34 = 丟丒且一专丟丙下一;
        UnityEngine.Mesh val_2 = 丗丕丙七丂丏丕东丈.GetComponent<UnityEngine.MeshFilter>().mesh;
        UnityEngine.Mesh val_4 = this.丝不丄丟与七万丈丆.GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        int val_5 = this.丙不丙世三丙且丗专.Count;
        if(val_4 != null)
        {
                val_27 = val_4.vertexCount;
        }
        else
        {
                val_27 = 0.vertexCount;
        }
        
        if(this.丗七万丒丞丂丘上丑 != null)
        {
                if((val_27 * val_5) <= this.丗七万丒丞丂丘上丑.Length)
        {
            goto label_10;
        }
        
        }
        
        this.丗七万丒丞丂丘上丑 = new UnityEngine.Vector3[0];
        this.丟且丏丞与东一不丟 = new UnityEngine.Vector2[0];
        if(val_5 < 1)
        {
            goto label_10;
        }
        
        label_25:
        val_28 = 0;
        goto label_19;
        label_24:
        if(val_4.uv == null)
        {
            goto label_13;
        }
        
        label_21:
        int val_32 = val_12.Length;
        val_32 = val_28 + (0 * val_32);
        val_28 = 1;
        this.丟且丏丞与东一不丟[(long)val_32] = val_4.uv[0];
        this.丟且丏丞与东一不丟[(long)val_32] = val_4.uv[0];
        goto label_19;
        label_13:
        if(val_4 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_19:
        UnityEngine.Vector2[] val_14 = val_4.uv;
        if(val_28 < val_14.Length)
        {
            goto label_24;
        }
        
        val_29 = 0 + 1;
        if(val_29 != val_5)
        {
            goto label_25;
        }
        
        label_10:
        uint val_33 = val_4.GetIndexCount(submesh:  0);
        val_33 = val_33 * val_5;
        if(this.且丄丄七不丂下丅与 != null)
        {
                if(val_33 <= this.且丄丄七不丂下丅与.Length)
        {
            goto label_27;
        }
        
        }
        
        this.且丄丄七不丂下丅与 = new int[0];
        label_27:
        val_30 = this.丙不丙世三丙且丗专;
        List.Enumerator<T> val_16 = val_30.GetEnumerator();
        val_31 = 1152921536780109888;
        val_32 = 0;
        val_34 = val_34 * 12.5f;
        goto label_31;
        label_49:
        val_30 = val_18.丐丏七丌丕丗业且上();
        if((世丏丌一丝七丘丕丅.Invoke(obj:  val_30)) == false)
        {
            goto label_31;
        }
        
        UnityEngine.Vector3 val_21 = val_30.丄丒丕万七丂万世一();
        val_33 = 0;
        goto label_34;
        label_39:
        int val_36 = 0;
        val_33 = 1;
        val_36 = val_4.triangles[0] + val_36;
        this.且丄丄七不丂下丅与[0] = val_36;
        label_34:
        if(val_33 < val_22.Length)
        {
            goto label_39;
        }
        
        val_29 = val_4.vertices;
        val_30 = 0;
        goto label_41;
        label_48:
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f}, d:  val_34);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        var val_37 = (long)0 + val_30;
        val_37 = this.丗七万丒丞丂丘上丑 + (val_37 * 12);
        mem2[0] = val_26.x;
        mem2[0] = val_26.y;
        mem2[0] = val_26.z;
        val_30 = 1;
        label_41:
        if(val_30 < val_23.Length)
        {
            goto label_48;
        }
        
        int val_38 = 0;
        val_32 = val_32 + val_33;
        val_38 = val_38 + val_30;
        val_31 = 1152921536780109888;
        label_31:
        if((2108881536 & 1) != 0)
        {
            goto label_49;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_66;
        label_70:
        val_32 = val_32 + 1;
        this.且丄丄七不丂下丅与[(long)val_32] = 0;
        label_66:
        if(val_32 < this.且丄丄七不丂下丅与.Length)
        {
            goto label_70;
        }
        
        if(val_2 != 0)
        {
                val_2.vertices = this.丗七万丒丞丂丘上丑;
            val_34 = this.丟且丏丞与东一不丟;
        }
        else
        {
                0.vertices = this.丗七万丒丞丂丘上丑;
            val_34 = this.丟且丏丞与东一不丟;
        }
        
        val_2.uv = val_34;
        UnityEngine.MeshTopology val_29 = val_4.GetTopology(submesh:  0);
        if(val_2 != 0)
        {
                val_2.SetIndices(indices:  this.且丄丄七不丂下丅与, topology:  val_29, submesh:  0);
        }
        else
        {
                0.SetIndices(indices:  this.且丄丄七不丂下丅与, topology:  val_29, submesh:  0);
        }
        
        val_2.RecalculateBounds();
    }
    private void 丘丄与丈下业丐丏丁()
    {
        var val_10;
        System.Predicate<不上丌世万丁丝丏丆> val_12;
        if(this.万丝丘下丈且与不丞 == 0)
        {
                UnityEngine.Material val_3 = new UnityEngine.Material(source:  不上丌世万丁丝丏丆.专丙与七与三丝丏丈(丈丂丙丟且丅与万且:  "cw-tile-default"));
            UnityEngine.Color val_4 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "cw-tile-default");
            val_3.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝不丄丟与七万丈丆);
            this.万丝丘下丈且与不丞 = val_5;
            val_5.GetComponent<UnityEngine.MeshRenderer>().material = val_3;
            this.万丝丘下丈且与不丞.name = this.万丝丘下丈且与不丞.name + " fog";
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = ClanWarMap.<>c.<>9__55_0;
        if(val_12 == null)
        {
                System.Predicate<不上丌世万丁丝丏丆> val_9 = null;
            val_12 = val_9;
            val_9 = new System.Predicate<不上丌世万丁丝丏丆>(object:  ClanWarMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarMap.<>c::世丄丁丗丐世万下丝(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘));
            ClanWarMap.<>c.<>9__55_0 = val_12;
        }
        
        this.东丘下与丆且丈丝丏(丗丕丙七丂丏丕东丈:  this.万丝丘下丈且与不丞, 丟丒且一专丟丙下一:  1.4f, 世丏丌一丝七丘丕丅:  val_9);
    }
    private void 丏与一丈丄万东东丗()
    {
        UnityEngine.GameObject val_11;
        var val_12;
        System.Predicate<不上丌世万丁丝丏丆> val_14;
        UnityEngine.Material val_2 = new UnityEngine.Material(source:  不上丌世万丁丝丏丆.专丙与七与三丝丏丈(丈丂丙丟且丅与万且:  "cw_tile_your_or_available"));
        UnityEngine.Color val_4 = PGCompany.丂丘丞丂丏七丁丄不.丗丛世丌丕专丝丘丙(丄丝丏上丄丛丘丟丆:  PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂());
        val_2.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_2.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        if(this.丟丏万专且丘丑丄东 == 0)
        {
                val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝不丄丟与七万丈丆);
            this.丟丏万专且丘丑丄东 = val_11;
        }
        else
        {
                val_11 = this.丟丏万专且丘丑丄东;
        }
        
        val_11.name = " cw_mesh_big clan_" + PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛();
        this.丟丏万专且丘丑丄东.GetComponent<UnityEngine.MeshRenderer>().material = val_2;
        val_12 = null;
        val_12 = null;
        val_14 = ClanWarMap.<>c.<>9__56_0;
        if(val_14 == null)
        {
                System.Predicate<不上丌世万丁丝丏丆> val_10 = null;
            val_14 = val_10;
            val_10 = new System.Predicate<不上丌世万丁丝丏丆>(object:  ClanWarMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarMap.<>c::不丌丄丘业丘丕不丙(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘));
            ClanWarMap.<>c.<>9__56_0 = val_14;
        }
        
        this.东丘下与丆且丈丝丏(丗丕丙七丂丏丕东丈:  this.丟丏万专且丘丑丄东, 丟丒且一专丟丙下一:  1f, 世丏丌一丝七丘丕丅:  val_10);
    }
    private void 三业专丙一丌丐丟丐(UnityEngine.GameObject 丑且不丕与专丄业丙, ref UnityEngine.GameObject 丑与丗丛丝丈丙丆丌, ref UnityEngine.Vector3[] 丐业丕东丈丑丐丝丞, ref int[] 丄丆下与丏丈丆七丑, UnityEngine.Material 世丑丘丘丂专丅丆与, string 丘下丟专丌丅丝丘丅, string 业业丕丅七业丈丅上)
    {
        var val_71;
        string val_72;
        UnityEngine.GameObject val_73;
        var val_74;
        float val_75;
        float val_76;
        var val_77;
        float val_78;
        不上丌世万丁丝丏丆 val_79;
        不上丌世万丁丝丏丆 val_80;
        不上丌世万丁丝丏丆 val_81;
        System.Collections.Generic.List<DiscreteVector2> val_82;
        var val_83;
        不上丌世万丁丝丏丆 val_84;
        UnityEngine.Vector3 val_85;
        不上丌世万丁丝丏丆 val_86;
        float val_87;
        不上丌世万丁丝丏丆 val_88;
        float val_89;
        不上丌世万丁丝丏丆 val_90;
        float val_91;
        var val_92;
        var val_93;
        val_72 = 丘下丟专丌丅丝丘丅;
        val_73 = 丑且不丕与专丄业丙;
        if(val_72 != null)
        {
                if(val_72.Length == 0)
        {
                return;
        }
        
        }
        
        UnityEngine.Mesh val_3 = val_73.GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        if(val_3 != null)
        {
                val_74 = val_3.GetIndices(submesh:  0);
        }
        else
        {
                val_74 = 0.GetIndices(submesh:  0);
        }
        
        UnityEngine.Vector3[] val_6 = val_3.vertices;
        UnityEngine.Vector3 val_8 = val_73.transform.localScale;
        int val_11 = mem[1152921536781943840].Count * val_3.vertexCount;
        val_11 = val_11 + (val_11 << 1);
        var val_71 = mem[1152921536781943840].Count;
        int val_15 = val_71 * (val_3.GetIndexCount(submesh:  0));
        val_71 = val_15 + (val_15 << 1);
        if(丐业丕东丈丑丐丝丞 != 0)
        {
                if((val_11 << 1) <= (丐业丕东丈丑丐丝丞 + 24))
        {
            goto label_14;
        }
        
        }
        
        mem2[0] = new UnityEngine.Vector3[0];
        label_14:
        if(丄丆下与丏丈丆七丑 != 0)
        {
                if((val_71 << 1) <= (丄丆下与丏丈丆七丑 + 24))
        {
            goto label_16;
        }
        
        }
        
        mem2[0] = new int[0];
        label_16:
        if(val_72 != 0)
        {
                val_75 = 0.01f;
            val_76 = 0f;
        }
        else
        {
                val_76 = 0f;
            val_75 = 0f;
        }
        
        val_73 = 0;
        val_77 = 0;
        val_78 = 0f;
        goto label_19;
        label_66:
        不上丌世万丁丝丏丆 val_19 = mem[1152921536781943840].Item[0];
        if(val_19 == null)
        {
                val_79 = val_19;
        }
        
        if(val_79.丛七且专丗丒丟丞丈() == false)
        {
            goto label_26;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_72)) == true)
        {
            goto label_23;
        }
        
        val_80 = val_19;
        if(val_80 == 0)
        {
                val_80 = val_19;
        }
        
        if((System.String.op_Inequality(a:  val_72, b:  val_80.丑丂丅丐业丘下东丘().下丁丙一丄丈不不丁())) == true)
        {
            goto label_26;
        }
        
        label_23:
        val_81 = val_19;
        if(val_81 == 0)
        {
                val_81 = val_19;
        }
        
        DiscreteVector2 val_25 = val_81.丞丑丟下丘三下专不();
        val_82 = 丝丙一上业丁且丄不.业丗丕丌丏丁丗丁万(下业丕七东丌丝下且:  new DiscreteVector2() {_x = val_25._x, _y = val_25._y}, 且丛上丕业丂丒与一:  1);
        val_83 = 0;
        goto label_28;
        label_64:
        DiscreteVector2 val_27 = val_82.Item[0];
        if((mem[1152921536781943848].ContainsKey(key:  new DiscreteVector2() {_x = val_27._x, _y = val_27._y})) == false)
        {
            goto label_33;
        }
        
        不上丌世万丁丝丏丆 val_29 = mem[1152921536781943848].Item[new DiscreteVector2() {_x = val_27._x, _y = val_27._y}];
        if(val_29 == null)
        {
            goto label_33;
        }
        
        val_84 = val_19;
        if(val_84 == 0)
        {
                val_84 = val_19;
        }
        
        val_85 = val_84.丑丂丅丐业丘下东丘();
        if((System.String.op_Inequality(a:  val_29.丑丂丅丐业丘下东丘().下丁丙一丄丈不不丁(), b:  val_85.下丁丙一丄丈不不丁())) == false)
        {
            goto label_37;
        }
        
        label_33:
        val_86 = val_19;
        if(val_86 == 0)
        {
                val_86 = val_19;
        }
        
        DiscreteVector2 val_36 = val_86.业丑丁丆丕丆丂丅万().丝专与下丗丐东丛丐();
        var val_72 = 60;
        val_72 = 60 + ((丝丙一上业丁且丄不.万丅与丁丙丈丙东且(丈丗与丞一上且上上:  new DiscreteVector2() {_x = val_36._x, _y = val_36._y}, 专丂丕丗丗东世丞下:  new DiscreteVector2() {_x = val_27._x, _y = val_27._y})) * val_72);
        UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.Euler(x:  0f, y:  (float)val_72, z:  0f);
        val_87 = val_38.z;
        UnityEngine.Vector3 val_39 = val_19.丄丒丕万七丂万世一();
        val_88 = val_19;
        if(val_88 == 0)
        {
                val_88 = val_19;
        }
        
        DiscreteVector2 val_40 = val_88.丞丑丟下丘三下专不();
        DiscreteVector2 val_41 = DiscreteVector2.丗丏丙丈不丛丆七丂(与东丑丂丅丅丅丂上:  new DiscreteVector2() {_x = val_27._x, _y = val_27._y}, 不丐丒丑丈丁丒世丟:  new DiscreteVector2() {_x = val_40._x, _y = val_40._y});
        UnityEngine.Vector3 val_42 = 丝丙一上业丁且丄不.与一丅丙丛丈下万丌(丗丒且世丆专丄三专:  new DiscreteVector2() {_x = val_41._x, _y = val_41._y}, 丒丆一丄丛丒且万七:  1f, 上丘万且丁丏下丂与:  0f);
        val_89 = val_42.y;
        val_78 = val_39.x;
        val_76 = val_39.y;
        val_75 = val_39.z;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_78, y = val_76, z = val_75}, b:  new UnityEngine.Vector3() {x = val_42.x, y = val_89, z = val_42.z});
        val_90 = val_19;
        if(val_90 == 0)
        {
                val_90 = val_19;
        }
        
        UnityEngine.Vector3 val_44 = val_90.丄丒丕万七丂万世一();
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  0.5f);
        val_91 = val_46.x;
        val_92 = 0;
        goto label_47;
        label_52:
        int val_73 = val_74[0];
        val_85 = 0;
        val_73 = val_73 + val_77;
        var val_47 = 丄丆下与丏丈丆七丑 + 0;
        val_92 = 1;
        mem2[0] = val_73;
        label_47:
        if(val_92 < val_5.Length)
        {
            goto label_52;
        }
        
        val_93 = 0;
        val_73 = val_73 + val_92;
        goto label_53;
        label_62:
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_78});
        val_76 = val_38.y;
        val_78 = val_38.x;
        val_75 = val_87;
        UnityEngine.Vector3 val_51 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_78, y = val_76, z = val_75, w = val_38.w}, point:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
        UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, b:  new UnityEngine.Vector3() {x = val_91, y = val_46.y, z = val_46.z});
        val_89 = val_52.y;
        val_85 = 0;
        val_93 = 1;
        mem[32] = val_52.x;
        mem[36] = val_89;
        mem[40] = val_52.z;
        label_53:
        if(val_93 < val_6.Length)
        {
            goto label_62;
        }
        
        val_77 = val_77 + val_93;
        label_37:
        val_82 = val_82;
        val_83 = val_83 + 1;
        label_28:
        if(val_83 < val_82.Count)
        {
            goto label_64;
        }
        
        label_26:
        var val_74 = 0;
        val_74 = val_74 + 1;
        label_19:
        if(val_74 < mem[1152921536781943840].Count)
        {
            goto label_66;
        }
        
        if(丑与丗丛丝丈丙丆丌 == 0)
        {
                UnityEngine.GameObject val_56 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_73);
            丑与丗丛丝丈丙丆丌 = val_56;
            UnityEngine.Vector3 val_58 = UnityEngine.Vector3.one;
            val_87 = val_58.x;
            val_91 = val_58.z;
            val_56.transform.localScale = new UnityEngine.Vector3() {x = val_87, y = val_58.y, z = val_91};
            丑与丗丛丝丈丙丆丌.GetComponent<UnityEngine.MeshRenderer>().material = 世丑丘丘丂专丅丆与;
            丑与丗丛丝丈丙丆丌.name = 丑与丗丛丝丈丙丆丌.name + 业业丕丅七业丈丅上;
        }
        
        UnityEngine.MeshFilter val_62 = 丑与丗丛丝丈丙丆丌.GetComponent<UnityEngine.MeshFilter>();
        UnityEngine.Vector3[] val_63 = new UnityEngine.Vector3[0];
        if(val_77 >= 1)
        {
                var val_76 = 0;
            var val_75 = 0;
            do
        {
            var val_64 = 丐业丕东丈丑丐丝丞 + val_76;
            val_85 = mem[(丐业丕东丈丑丐丝丞 + 0) + 32];
            val_85 = (丐业丕东丈丑丐丝丞 + 0) + 32;
            val_75 = val_75 + 1;
            val_76 = val_76 + 12;
            val_63[val_76] = val_85;
            val_63[val_76] = (丐业丕东丈丑丐丝丞 + 0) + 32 + 4;
            val_63[val_76] = (丐业丕东丈丑丐丝丞 + 0) + 40;
        }
        while(val_77 != val_75);
        
        }
        
        val_62.mesh.vertices = val_63;
        int[] val_66 = new int[0];
        if(val_73 >= 1)
        {
                var val_77 = 0;
            do
        {
            var val_67 = 丄丆下与丏丈丆七丑 + 0;
            mem2[0] = (丄丆下与丏丈丆七丑 + 0) + 32;
            val_77 = val_77 + 1;
        }
        while(val_73 != val_77);
        
        }
        
        val_72 = val_62;
        val_62.mesh.SetIndices(indices:  val_66, topology:  val_3.GetTopology(submesh:  0), submesh:  0);
        val_71 = val_72.mesh;
        val_71.RecalculateBounds();
    }
    private void 丝丄七丞丐丅下丗丂()
    {
        var val_8;
        var val_20;
        UnityEngine.GameObject val_21;
        丟丒下与下业业丗丄 val_22;
        val_20 = this;
        if(this.丛丕丈丒丂且丛与下 == null)
        {
            goto label_1;
        }
        
        val_21 = this.丛丕丈丒丂且丛与下.丑与丗丛丝丈丙丆丌;
        val_22 = this.丛丕丈丒丂且丛与下;
        goto label_2;
        label_1:
        val_22 = this.丛丕丈丒丂且丛与下;
        val_21 = this.丛丕丈丒丂且丛与下.丑与丗丛丝丈丙丆丌;
        if(val_22 == null)
        {
            goto label_3;
        }
        
        label_2:
        label_19:
        this.三业专丙一丌丐丟丐(丑且不丕与专丄业丙:  this.与丐三世与丙丗万丞, 丑与丗丛丝丈丙丆丌: ref  val_21, 丐业丕东丈丑丐丝丞: ref  this.丛丕丈丒丂且丛与下.丐业丕东丈丑丐丝丞, 丄丆下与丏丈丆七丑: ref  this.丛丕丈丒丂且丛与下.丄丆下与丏丈丆七丑, 世丑丘丘丂专丅丆与:  new UnityEngine.Material(source:  this.世丌丛业丘且万七丗), 丘下丟专丌丅丝丘丅:  0, 业业丕丅七业丈丅上:  " outline2");
        List.Enumerator<T> val_6 = PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗.三丞与不丂万丈丏丛().GetEnumerator();
        label_17:
        if((2110766672 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if((this.丏丂丒世丛丑七丁世.ContainsKey(key:  val_9)) != true)
        {
                new UnityEngine.Material() = new UnityEngine.Material(source:  this.丑业与丙丞丑东丏丛);
            UnityEngine.Color val_12 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  val_9, 丏丆丗丂丟丘丈万万:  0);
            new UnityEngine.Material().SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
            new ClanWarMap.丟丒下与下业业丗丄() = new System.Object();
            this.丏丂丒世丛丑七丁世.Add(key:  val_9, value:  new ClanWarMap.丟丒下与下业业丗丄());
            this.丛专丅丙专东东丂丌.Add(key:  val_9, value:  new UnityEngine.Material());
        }
        
        丟丒下与下业业丗丄 val_14 = this.丏丂丒世丛丑七丁世.Item[val_9];
        this.三业专丙一丌丐丟丐(丑且不丕与专丄业丙:  this.丂上丗丑丝下万丞与, 丑与丗丛丝丈丙丆丌: ref  val_14.丑与丗丛丝丈丙丆丌, 丐业丕东丈丑丐丝丞: ref  val_14.丐业丕东丈丑丐丝丞, 丄丆下与丏丈丆七丑: ref  val_14.丄丆下与丏丈丆七丑, 世丑丘丘丂专丅丆与:  this.丛专丅丙专东东丂丌.Item[val_9], 丘下丟专丌丅丝丘丅:  val_9, 业业丕丅七业丈丅上:  " outline clan_" + val_9);
        goto label_17;
        label_3:
        if(this.丛丕丈丒丂且丛与下 != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丌丙丝万丒丛专业世()
    {
        object val_6;
        var val_20;
        System.Collections.Generic.Dictionary<System.String, 丛与三东七专下丗丗> val_22;
        var val_23;
        var val_24;
        var val_25;
        丛与三东七专下丗丗 val_26;
        var val_27;
        var val_33;
        val_22 = this;
        if(this.业丁丕丐丐丏世丕世.Count < 1)
        {
            goto label_2;
        }
        
        val_22 = this.业丁丕丐丐丏世丕世;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_22.GetEnumerator();
        val_23 = 1152921536779242672;
        label_6:
        if((2111027168 & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        val_3._value._obj.丅一丁上上世丄三丏(丝三丄专丗丞丄丄丌:  false);
        goto label_6;
        label_2:
        List.Enumerator<T> val_4 = this.丙不丙世三丙且丗专.GetEnumerator();
        val_24 = 0;
        val_25 = 0;
        label_41:
        if((2111027120 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7.丗丐东丑丕丞丅丞东() != 2)
        {
            goto label_41;
        }
        
        val_6 = 2;
        string val_10 = val_6 + "-"("-") + val_7.丛丆东上上丗丗业丕();
        if((this.业丁丕丐丐丏世丕世.ContainsKey(key:  val_10)) == true)
        {
            goto label_41;
        }
        
        val_26 = new 丛与三东七专下丗丗();
        val_26 = new 丛与三东七专下丗丗();
        System.Collections.Generic.List<不上丌世万丁丝丏丆> val_13 = new System.Collections.Generic.List<不上丌世万丁丝丏丆>();
        List.Enumerator<T> val_14 = this.丙不丙世三丙且丗专.GetEnumerator();
        label_24:
        if((2111027088 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_15 = val_6.丐丏七丌丕丗业且上();
        if(((val_15.丗丐东丑丕丞丅丞东() != 2) || (val_15.丛丆东上上丗丗业丕() < 1)) || (val_15.丛丆东上上丗丗业丕() != val_7.丛丆东上上丗丗业丕()))
        {
            goto label_24;
        }
        
        val_13.Add(item:  val_15);
        goto label_24;
        label_15:
        val_27 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (val_20 != 266))
        {
            goto label_33;
        }
        
        var val_21 = 0;
        val_21 = val_21 ^ 0;
         =  + val_21;
        if(val_26 != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_33:
        if( == 0)
        {
            goto label_36;
        }
        
        if(val_26 != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_36:
        if(val_26 != null)
        {
            goto label_39;
        }
        
        label_38:
        label_39:
        new 丛与三东七专下丗丗().丈且东丑丂且万丒丅(丞丅上丏丂且下丅与:  val_10, 丂丗丏丈万业丅丕且:  val_13);
        this.业丁丕丐丐丏世丕世.Add(key:  val_10, value:  new 丛与三东七专下丗丗());
        goto label_41;
        label_4:
        val_20 = 74;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_8:
        val_33 = 0 + 1;
        mem2[0] = 320;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_33 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921536782645056 + ((0 + 1)) << 2) != 320)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    public void RefreshField()
    {
        var val_4;
        this._field.世业丒万丘丆专丘丐();
        if(this.丙不丙世三丙且丗专.Count != 0)
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_2 = this.不丆专上丘丅三上万.GetEnumerator();
        label_11:
        if((2111250800 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(专丘丏丅且丆万东丈:  new DiscreteVector2() {_x = val_5, _y = val_5})) == null)
        {
            goto label_11;
        }
        
        new 不上丌世万丁丝丏丆() = new 不上丌世万丁丝丏丆();
        this.丙不丙世三丙且丗专.Add(item:  new 不上丌世万丁丝丏丆());
        this.丒与丂业丆三丞上下.Add(key:  new DiscreteVector2() {_x = val_5, _y = val_5}, value:  new 不上丌世万丁丝丏丆());
        new 不上丌世万丁丝丏丆().丈且东丑丂且万丒丅(三专丈丘一专丞不且:  this, 丗丒且世丆专丄三专:  new DiscreteVector2() {_x = val_5, _y = val_5});
        goto label_11;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_20:
        this.丌丙丝万丒丛专业世();
        this.丛丏丅丅丂世且且一();
        List.Enumerator<T> val_9 = this.丙不丙世三丙且丗专.GetEnumerator();
        label_24:
        if((2111250776 & 1) == 0)
        {
            goto label_22;
        }
        
        0.丐丏七丌丕丗业且上().业不不且丐且与不与();
        goto label_24;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丘丄与丈下业丐丏丁();
        this.丝丄七丞丐丅下丗丂();
        this.丏与一丈丄万东东丗();
    }
    internal bool 万丅上世丌不丞丙三(System.Nullable<DiscreteVector2> 业丄世世一世三与丝)
    {
        var val_4;
        var val_5;
        val_4 = this;
        不上丌世万丁丝丏丆 val_1 = 0;
        if((2111417152 & 1) != 0)
        {
                this.丄丈丞丝上丛丟丄七 = 业丄世世一世三与丝;
            mem[1152921536783047356] = ???;
            val_4;
            if((this.丒与丂业丆三丞上下.TryGetValue(key:  new DiscreteVector2() {_x = 2111417152, _y = 268435463}, value: out  val_1)) != false)
        {
                val_4 = val_1;
            val_4.业不不且丐且与不与();
        }
        
            val_5 = 1;
            return (bool)val_5;
        }
        
        不上丌世万丁丝丏丆 val_3 = this.丅上丝万丐七丝专丑();
        mem[1152921536783047356] = 0;
        this.丄丈丞丝上丛丟丄七 = 0;
        if(val_3 == null)
        {
                return (bool)val_5;
        }
        
        val_3.业不不且丐且与不与();
        val_5 = 0;
        return (bool)val_5;
    }
    internal bool 七丞万丅一丄丛丛丝(System.Nullable<DiscreteVector2> 业丄世世一世三与丝)
    {
        不上丌世万丁丝丏丆 val_9;
        var val_10;
        var val_11;
        if((2111587488 & 1) == 0)
        {
            goto label_1;
        }
        
        val_9;
        if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = 2111587488, _y = 268435463})) == false)
        {
            goto label_11;
        }
        
        if(( & 1) == 0)
        {
            goto label_6;
        }
        
        if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = 2111587472, _y = 268435463})) == false)
        {
            goto label_6;
        }
        
        val_10 = this.丒与丂业丆三丞上下.Item[new DiscreteVector2() {_x = 2111587472, _y = 268435463}];
        goto label_8;
        label_1:
        if(( & 1) == 0)
        {
            goto label_11;
        }
        
        val_9 = ;
        if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = 2111587472, _y = 268435463})) == false)
        {
            goto label_11;
        }
        
        val_9 = ;
        不上丌世万丁丝丏丆 val_5 = this.丒与丂业丆三丞上下.Item[new DiscreteVector2() {_x = 2111587472, _y = 268435463}];
        this.<丗世世一丄东丆丘业>k__BackingField = 0;
        mem[1152921536783217712] = 0;
        if(val_5 == null)
        {
            goto label_22;
        }
        
        val_5.业不不且丐且与不与();
        goto label_22;
        label_11:
        val_11 = 0;
        return (bool)val_11;
        label_6:
        val_10 = 0;
        label_8:
        if((this.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = 2111587488, _y = 268435463})) != false)
        {
                val_9 = this.丒与丂业丆三丞上下.Item[new DiscreteVector2() {_x = 2111587488, _y = 268435463}];
        }
        else
        {
                val_9 = 0;
        }
        
        this.<丗世世一丄东丆丘业>k__BackingField = 业丄世世一世三与丝;
        mem[1152921536783217712] = ???;
        if(val_10 != 0)
        {
                val_10.业不不且丐且与不与();
        }
        
        if(val_9 != 0)
        {
                val_9.业不不且丐且与不与();
        }
        
        this.一丄丂丘东丏丆丟丌(丌丝万上丅丒一丈丘:  val_9);
        if(this.丒丂与不上丙专丁丞 != null)
        {
                this.丒丂与不上丙专丁丞.Invoke(obj:  this.丆丆丘且丑丅丝丟丙());
        }
        
        label_22:
        val_11 = 1;
        return (bool)val_11;
    }
    private void 一丄丂丘东丏丆丟丌(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        业丆七世丟上下丌不 val_1 = 丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑();
        if(丌丝万上丅丒一丈丘 == null)
        {
                return;
        }
        
        if(val_1 == null)
        {
                return;
        }
        
        if(丌丝万上丅丒一丈丘.丑丕丞三三世丑丅丝() == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = 丌丝万上丅丒一丈丘.丑丕丞三三世丑丅丝().transform.position;
        if((专且丝丄丙丗丈不丞.三业专丟丈业业丁丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丁丄七万不专丅丗丝:  this.mapRect)) != false)
        {
                return;
        }
        
        float val_20 = this.rightPanelWidth;
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_20 = val_20 / (float)UnityEngine.Screen.width;
        val_20 = 1f - val_20;
        UnityEngine.Vector3 val_11 = val_1.CameraTransform.right;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.cameraPosOffset);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_20);
        UnityEngine.Vector3 val_16 = 丌丝万上丅丒一丈丘.丑丕丞三三世丑丅丝().transform.position;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_1.SmoothMove(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, 东丗上东丘丄东丘世:  10f);
    }
    internal 丛与三东七专下丗丗 七丆丛丗丙不丞丞丟(int 丙丐一丕丗万丁下一)
    {
        System.Collections.Generic.Dictionary<System.String, 丛与三东七专下丗丗> val_4;
        var val_5;
        val_4 = this;
        string val_1 = 2 + "-"("-") + 丙丐一丕丗万丁下一;
        if((this.业丁丕丐丐丏世丕世.ContainsKey(key:  val_1)) != false)
        {
                val_4 = this.业丁丕丐丐丏世丕世;
            丛与三东七专下丗丗 val_3 = val_4.Item[val_1];
            return (丛与三东七专下丗丗)val_5;
        }
        
        val_5 = 0;
        return (丛与三东七专下丗丗)val_5;
    }
    internal 不上丌世万丁丝丏丆 丞丆丂上万丅丒丞丙(int 丙丐一丕丗万丁下一)
    {
        .丙丐一丕丗万丁下一 = 丙丐一丕丗万丁下一;
        return System.Linq.Enumerable.FirstOrDefault<不上丌世万丁丝丏丆>(source:  this.丙不丙世三丙且丗专, predicate:  new System.Func<不上丌世万丁丝丏丆, System.Boolean>(object:  new ClanWarMap.丑丆丟丈上与丁丕下(), method:  System.Boolean ClanWarMap.丑丆丟丈上与丁丕下::万世丈业且七丗三下(不上丌世万丁丝丏丆 三丟东丕丄丄下下丑)));
    }
    private void 丛丏丅丅丂世且且一()
    {
        var val_4;
        var val_26;
        UnityEngine.Transform val_27;
        int val_28;
        var val_29;
        var val_30;
        string val_31;
        string val_32;
        UnityEngine.Object val_33;
        val_26 = this;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.万丂丌万世丏七上丗.GetEnumerator();
        val_27 = 1152921536783843408;
        val_28 = 1152921536783845456;
        val_29 = 1152921504848912384;
        label_5:
        if((2112304000 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        UnityEngine.Object.Destroy(obj:  val_5._value._obj);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.万丂丌万世丏七上丗.Clear();
        Dictionary.Enumerator<TKey, TValue> val_6 = this.业丁丕丐丐丏世丕世.GetEnumerator();
        val_30 = 1152921505580326912;
        label_43:
        if((2112303936 & 1) == 0)
        {
            goto label_36;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_4.GetAwaiter();
        val_31 = PGCompany.丂丘丞丂丏七丁丄不.丒不世丌业不一丆丏(丄丝丏上丄丛丘丟丆:  val_7._value._obj.丛丆东上上丗丗业丕());
        val_32 = PGCompany.丂丘丞丂丏七丁丄不.丐丅万丙丟东丑丐与(丄丒下业一不丈丝丘:  val_31);
        val_27 = this.castelPoints.Item[0];
        val_28;
        if((val_7._value._obj.丛丆东上上丗丗业丕() & 2147483648) == 0)
        {
                val_28 = val_7._value._obj.丛丆东上上丗丗业丕();
            val_30 = val_30;
            val_29 = val_29;
            val_26 = val_26;
            val_31 = val_31;
            val_27 = val_27;
            val_32 = val_32;
            if(val_28 < this.castelPoints.Count)
        {
                val_28 = val_7._value._obj.丛丆东上上丗丗业丕();
            val_27 = this.castelPoints.Item[val_28];
        }
        
        }
        
        if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_31)) == false) || ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_32)) == false))
        {
            goto label_43;
        }
        
        val_33 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MiniClanForts/"("MiniClanForts/") + val_32);
        if(val_33 != 0)
        {
            goto label_33;
        }
        
        val_33 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MiniClanForts/unknown_item");
        if(val_33 == 0)
        {
            goto label_36;
        }
        
        label_33:
        UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_33, parent:  val_27);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_24.transform);
        this.万丂丌万世丏七上丗.Add(key:  val_31, value:  val_24);
        goto label_43;
        label_36:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ClanWarMap()
    {
        this.丙不丙世三丙且丗专 = new System.Collections.Generic.List<不上丌世万丁丝丏丆>();
        this.丒与丂业丆三丞上下 = new System.Collections.Generic.Dictionary<DiscreteVector2, 不上丌世万丁丝丏丆>();
        this.业丁丕丐丐丏世丕世 = new System.Collections.Generic.Dictionary<System.String, 丛与三东七专下丗丗>();
        this.万丂丌万世丏七上丗 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
        this.丛丕丈丒丂且丛与下 = new ClanWarMap.丟丒下与下业业丗丄();
        this.丏丂丒世丛丑七丁世 = new System.Collections.Generic.Dictionary<System.String, 丟丒下与下业业丗丄>();
        this.丛专丅丙专东东丂丌 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Material>();
        this.cameraPosOffset = 1.75f;
        this.rightPanelWidth = 0f;
    }

}
