using UnityEngine;
internal class PortalChainManager : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.Dictionary<PortalChainManager.业一丐专丞东世丞七, System.Collections.Generic.List<Portal>> 东丂业丙专丈下丆丈;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<PortalChainManager.业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>> 丒丗丏丏世下丌丙一;
    internal static PortalChainManager 丄丘七三上丕世丞业;
    internal int 丐丗上丌世与下七专;
    private int 丁万万丅丂丛丗丁丆;
    public float radiusImpulse;
    public float impulceForce;
    
    // Properties
    private int 丅丙丄丁与丅丒丄专 { get; }
    
    // Methods
    private int 丘业七与七丛丟丈丏()
    {
        int val_3 = this.丐丗上丌世与下七专;
        val_3 = val_3 - 1;
        this.丁万万丅丂丛丗丁丆 = ((this.丁万万丅丂丛丗丁丆 + 1) > val_3) ? 0 : (this.丁万万丅丂丛丗丁丆 + 1);
        return (int)this.丁万万丅丂丛丗丁丆;
    }
    private void Awake()
    {
        null = null;
        PortalChainManager.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        null = null;
        PortalChainManager.丄丘七三上丕世丞业 = 0;
    }
    public void TrySetPortal(PortalChainManager.业一丐专丞东世丞七 业东万丁丏丅丛三丄, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丏与三业丈丕专且丑, UnityEngine.GameObject 丅且丟业丝专与丈万, UnityEngine.Vector3 与专七丑丁上丛东丟, UnityEngine.Gradient 丈三丂且丗丆丛七一, Rocket 丁丂丏与丗上丗一丆)
    {
        UnityEngine.GameObject val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        var val_17;
        float val_18;
        float val_19;
        var val_20;
        val_12 = 丅且丟业丝专与丈万;
        val_13 = 丏与三业丈丕专且丑.z;
        val_14 = 丏与三业丈丕专且丑.y;
        val_15 = 丏与三业丈丕专且丑.x;
        val_16 = 业丒丝丗与丐丛丟丏.z;
        val_17 = this;
        val_13 = val_13;
        val_14 = val_14;
        val_15 = val_15;
        val_18 = 业丒丝丗与丐丛丟丏.y;
        val_19 = 业丒丝丗与丐丛丟丏.x;
        if((this.丕业与丑丛丌三丛下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = val_16}, 丏与三业丈丕专且丑:  new UnityEngine.Vector3() {x = val_15, y = val_14, z = val_13}, 丅且丟业丝专与丈万:  val_12, 与专七丑丁上丛东丟:  new UnityEngine.Vector3() {x = 与专七丑丁上丛东丟.x, y = 与专七丑丁上丛东丟.y})) == false)
        {
                return;
        }
        
        int val_12 = this.丐丗上丌世与下七专;
        val_12 = this.丁万万丅丂丛丗丁丆;
        val_12 = val_12 - 1;
        this.丁万万丅丂丛丗丁丆 = ((val_12 + 1) > val_12) ? 0 : (val_12 + 1);
        val_17 = this.东丂业丙专丈下丆丈.Item[业东万丁丏丅丛三丄].Item[val_12];
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15, y = val_14, z = val_13}, d:  0.1f);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = val_18, z = val_16}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_17.SetPortal(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丏与三业丈丕专且丑:  new UnityEngine.Vector3() {x = val_15, y = val_14, z = val_13}, 三丞丞不丟丕丛下万: out  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f}, 丈三丂且丗丆丛七一:  丈三丂且丗丆丛七一, 丁丂丏与丗上丗一丆:  丁丂丏与丗上丗一丆);
        val_20 = null;
        val_20 = null;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15, y = val_14, z = val_13}, d:  0.1f);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = val_18, z = val_16}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_16 = 0f;
        val_13 = 0f;
        val_19 = val_10.x;
        val_18 = val_10.z;
        SendPortalOnline(万丅七丞丑一丞专丘:  val_12, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_19, y = val_10.y, z = val_18}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_16, y = 0f, z = val_13, w = 0f}, 业东万丁丏丅丛三丄:  业东万丁丏丅丛三丄, 丆且丙三丐丂丒东丆:  (丁丂丏与丗上丗一丆.丈丛丕下丙三丒与丈 == true) ? 1 : 0);
    }
    public void InstantiateMyPlayerPortals(PortalChainManager.业一丐专丞东世丞七 业东万丁丏丅丛三丄)
    {
        if((this.东丂业丙专丈下丆丈.ContainsKey(key:  业东万丁丏丅丛三丄)) != false)
        {
                return;
        }
        
        this.东丂业丙专丈下丆丈.Add(key:  业东万丁丏丅丛三丄, value:  this.丁丆专丗三下一一万(业东万丁丏丅丛三丄:  业东万丁丏丅丛三丄, 丗丅万三丄三世丙丒:  true));
    }
    private bool 丕业与丑丛丌三丛下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丏与三业丈丕专且丑, UnityEngine.GameObject 丅且丟业丝专与丈万, UnityEngine.Vector3 与专七丑丁上丛东丟)
    {
        float val_4;
        float val_14;
        UnityEngine.Object val_15;
        float val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = 丏与三业丈丕专且丑.y;
        val_15 = 1152921504838316032;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_14, z = 丏与三业丈丕专且丑.z});
        val_16 = val_1.y;
        UnityEngine.Collider[] val_3 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_16, z = val_1.z}, radius:  0.9f, layerMask:  Portal.丗专东丂上丄下丝丄());
        if(val_3 == null)
        {
            goto label_3;
        }
        
        val_17 = val_3;
        val_18 = val_3.Length;
        if(val_3.Length != 0)
        {
            goto label_4;
        }
        
        goto label_6;
        label_3:
        val_17 = 24;
        val_18 = 28563616;
        if(28563616 == 0)
        {
            goto label_6;
        }
        
        label_4:
        val_16 = 与专七丑丁上丛东丟.y;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_14, z = 丏与三业丈丕专且丑.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 与专七丑丁上丛东丟.x, y = val_4, z = val_16}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_14 = val_6.x;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 与专七丑丁上丛东丟.x, y = val_4, z = val_16}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 与专七丑丁上丛东丟.x, y = val_4, z = val_16}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        if(((val_14 - val_7.x) <= 0.6f) || (val_8.x <= 0.05f))
        {
            goto label_10;
        }
        
        label_6:
        val_19 = 0;
        return (bool)(val_18 == false) ? 1 : 0;
        label_10:
        val_20 = 0;
        goto label_12;
        label_19:
        val_15 = val_3[0].gameObject;
        val_18 = val_18 - (UnityEngine.Object.op_Equality(x:  val_15, y:  丅且丟业丝专与丈万));
        val_20 = 1;
        label_12:
        if(val_20 < val_17)
        {
            goto label_19;
        }
        
        return (bool)(val_18 == false) ? 1 : 0;
    }
    private System.Collections.Generic.List<Portal> 丁丆专丗三下一一万(PortalChainManager.业一丐专丞东世丞七 业东万丁丏丅丛三丄, bool 丗丅万三丄三世丙丒)
    {
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = this;
        System.Collections.Generic.List<Portal> val_1 = new System.Collections.Generic.List<Portal>();
        if(this.丐丗上丌世与下七专 >= 1)
        {
                val_16 = 1152921540244500064;
            var val_14 = 0;
            do
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_17 = UnityEngine.Resources.Load(path:  "BattlePrefabs/"("BattlePrefabs/") + 业东万丁丏丅丛三丄.ToString());
            if(val_17 != null)
        {
                var val_6 = (null == null) ? (val_17) : 0;
        }
        else
        {
                val_18 = 0;
        }
        
            val_1.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18, parent:  this.transform).GetComponent<Portal>());
            val_14 = val_14 + 1;
        }
        while(val_14 < this.丐丗上丌世与下七专);
        
        }
        
        if(丗丅万三丄三世丙丒 == false)
        {
                return val_1;
        }
        
        val_17 = 1152921540244529760;
        val_19 = 1;
        goto label_13;
        label_21:
        val_16 = val_1.Count - 1;
        if(val_1 != null)
        {
                val_20 = val_1.Item[1277981728];
        }
        else
        {
                val_20 = val_1.Item[1277981728];
        }
        
        if(val_15 == val_16)
        {
                val_21 = public Portal System.Collections.Generic.List<Portal>::get_Item(int index);
            val_22 = 0;
        }
        else
        {
                val_21 = public Portal System.Collections.Generic.List<Portal>::get_Item(int index);
            val_22 = val_19;
        }
        
        val_19 = 2;
        val_11.connectedPortal = val_1.Item[1];
        label_13:
        val_15 = val_19 - 1;
        if(val_15 < val_1.Count)
        {
            goto label_21;
        }
        
        return val_1;
    }
    public void SetEnemyPortal(int 丞丈丐丄一丏上与丑, int 万丅七丞丑一丞专丘, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, PortalChainManager.业一丐专丞东世丞七 业东万丁丏丅丛三丄 = 0, bool 丆且丙三丐丂丒东丆 = False)
    {
        System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>> val_11;
        if((this.丒丗丏丏世下丌丙一.ContainsKey(key:  丞丈丐丄一丏上与丑)) != true)
        {
                System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>();
            this.丒丗丏丏世下丌丙一.Add(key:  丞丈丐丄一丏上与丑, value:  val_2);
        }
        
        if((this.丒丗丏丏世下丌丙一.Item[丞丈丐丄一丏上与丑].ContainsKey(key:  业东万丁丏丅丛三丄)) != true)
        {
                val_11 = this.丒丗丏丏世下丌丙一.Item[丞丈丐丄一丏上与丑];
            val_11.Add(key:  业东万丁丏丅丛三丄, value:  this.丁丆专丗三下一一万(业东万丁丏丅丛三丄:  业东万丁丏丅丛三丄, 丗丅万三丄三世丙丒:  false));
        }
        
        this.丒丗丏丏世下丌丙一.Item[丞丈丐丄一丏上与丑].Item[业东万丁丏丅丛三丄].Item[万丅七丞丑一丞专丘].SetEnemyPortal(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w}, 丆且丙三丐丂丒东丆:  丆且丙三丐丂丒东丆);
    }
    public void UnsetEnemyPortal(int 丞丈丐丄一丏上与丑, int 万丅七丞丑一丞专丘, PortalChainManager.业一丐专丞东世丞七 业东万丁丏丅丛三丄)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>> val_7 = this.丒丗丏丏世下丌丙一;
        if((val_7.ContainsKey(key:  丞丈丐丄一丏上与丑)) == false)
        {
                return;
        }
        
        val_7 = this.丒丗丏丏世下丌丙一.Item[丞丈丐丄一丏上与丑];
        if((val_7.ContainsKey(key:  业东万丁丏丅丛三丄)) == false)
        {
                return;
        }
        
        this.丒丗丏丏世下丌丙一.Item[丞丈丐丄一丏上与丑].Item[业东万丁丏丅丛三丄].Item[万丅七丞丑一丞专丘].DeactivateEnemyPortal();
    }
    internal bool 三专世丐业丏丁丟丟(UnityEngine.Vector3 一丞不丒世上丕丐丈, UnityEngine.Vector3 且丘丝且丕丂万丞专, float 丐七业丛丒丆七且丏)
    {
        var val_5;
        var val_9;
        var val_21;
        var val_27;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>> val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
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
        val_27;
        val_28 = this;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = 一丞不丒世上丕丐丈.x, y = 一丞不丒世上丕丐丈.y, z = 一丞不丒世上丕丐丈.z}, direction:  new UnityEngine.Vector3() {x = 且丘丝且丕丂万丞专.x, y = 且丘丝且丕丂万丞专.y, z = 且丘丝且丕丂万丞专.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  丐七业丛丒丆七且丏)) == false)
        {
            goto label_89;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = this.东丂业丙专丈下丆丈.GetEnumerator();
        val_29 = 0;
        val_30 = 0;
        val_31 = 0;
        goto label_26;
        label_27:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        List.Enumerator<T> val_7 = val_6._value._obj.GetEnumerator();
        label_13:
        if((1278577808 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_10 = val_9.丐丏七丌丕丗业且上();
        if(val_10 == 0)
        {
            goto label_13;
        }
        
        if(val_10.gameObject != 0.gameObject)
        {
            goto label_13;
        }
        
        val_32 = 1278577600;
        val_33 = 1;
        val_34 = 351;
        goto label_14;
        label_5:
        val_32 = 1278577600;
        val_33 = 1;
        val_34 = 130;
        label_14:
        val_35 = val_30;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_33 == 1)
        {
            goto label_22;
        }
        
        if(130 == 130)
        {
            goto label_23;
        }
        
        if(130 == 351)
        {
            goto label_24;
        }
        
        label_22:
        val_29 = 0;
        val_30 = 0;
        if( == 0)
        {
            goto label_26;
        }
        
        val_29 = 0;
        val_30 = 0;
        goto label_26;
        label_23:
        var val_28 = 0;
        val_28 = val_28 ^ 0;
        val_31 = val_33 + val_28;
        val_30 = ;
        label_26:
        if((1278577856 & 1) != 0)
        {
            goto label_27;
        }
        
        val_36 = val_31 + 1;
        mem2[0] = 155;
        goto label_28;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_80;
        label_28:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_33 == 1)
        {
            goto label_36;
        }
        
        if(130 == 351)
        {
            goto label_80;
        }
        
        if(130 != 155)
        {
            goto label_36;
        }
        
        var val_29 = 0;
        val_29 = val_29 ^ 0;
        val_37 = val_33 + val_29;
        goto label_38;
        label_36:
        if( != 0)
        {
                val_30 = 0;
        }
        
        label_38:
        val_28 = this.丒丗丏丏世下丌丙一;
        Dictionary.Enumerator<TKey, TValue> val_15 = val_28.GetEnumerator();
        goto label_77;
        label_78:
        ConfiguredValueTaskAwaiter val_16 = val_5.GetAwaiter();
        Dictionary.Enumerator<TKey, TValue> val_17 = val_16._value._obj.GetEnumerator();
        goto label_44;
        label_66:
        val_38 = 0;
        if(val_16._value._obj == 0)
        {
            goto label_44;
        }
        
        val_38 = 0;
        goto label_44;
        label_65:
        val_33 = val_33 + 0;
        val_38 = ;
        label_44:
        if((1278577856 & 1) == 0)
        {
            goto label_45;
        }
        
        ConfiguredValueTaskAwaiter val_18 = val_5.GetAwaiter();
        List.Enumerator<T> val_19 = val_18._value._obj.GetEnumerator();
        label_55:
        if((1278577808 & 1) == 0)
        {
            goto label_47;
        }
        
        string val_22 = val_21.丐丏七丌丕丗业且上();
        if(val_22 == 0)
        {
            goto label_55;
        }
        
        if(val_22.gameObject != 0.gameObject)
        {
            goto label_55;
        }
        
        val_39 = 1278577600;
        val_36 = val_33 + 1;
        val_40 = 351;
        goto label_56;
        label_47:
        val_39 = 1278577600;
        val_36 = val_33 + 1;
        val_40 = 296;
        label_56:
        mem2[0] = 296;
        val_28 = val_38;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_36 == 1)
        {
            goto label_66;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) == 296)
        {
            goto label_65;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) != 351)
        {
            goto label_66;
        }
        
        goto label_68;
        label_45:
        val_36 = val_33 + 1;
        val_28 = val_38;
        mem2[0] = 321;
        label_68:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_36 == 1)
        {
            goto label_73;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) == 321)
        {
            goto label_74;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) == 351)
        {
            goto label_75;
        }
        
        label_73:
        val_30 = 0;
        if( == 0)
        {
            goto label_77;
        }
        
        val_30 = 0;
        goto label_77;
        label_74:
        val_37 = val_36 + (0 ^ (val_36 >> 31));
        val_30 = ;
        label_77:
        if((1278577760 & 1) != 0)
        {
            goto label_78;
        }
        
        val_41 = val_37 + 1;
        mem2[0] = 349;
        goto label_79;
        label_75:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_80;
        label_79:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_36 == 1)
        {
            goto label_87;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) == 349)
        {
            goto label_89;
        }
        
        if((1278577600 + (((val_33 + 0) + 1)) << 2) != 351)
        {
            goto label_87;
        }
        
        label_80:
        val_42 = 0;
        return (bool)val_42;
        label_87:
        label_89:
        val_42 = 1;
        return (bool)val_42;
    }
    public PortalChainManager()
    {
        this.东丂业丙专丈下丆丈 = new System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>();
        this.丒丗丏丏世下丌丙一 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<业一丐专丞东世丞七, System.Collections.Generic.List<Portal>>>();
        this.丐丗上丌世与下七专 = 2;
        this.radiusImpulse = 1f;
        this.impulceForce = 0f;
    }
    private static PortalChainManager()
    {
    
    }

}
