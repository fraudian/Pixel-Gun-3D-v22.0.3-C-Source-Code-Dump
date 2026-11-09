using UnityEngine;
internal class PoolManager : MonoBehaviour
{
    // Fields
    internal static PoolManager 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<PoolManager.PoolEntry> records;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PoolManager.丒丄丑丌丘丆专丘丝>> 丅上丄丌业丂丄与丐;
    private bool 一专世丏丞丑三丘七;
    
    // Methods
    private void Awake()
    {
        null = null;
        PoolManager.丄丘七三上丕世丞业 = this;
        this.丟丐丛丙丘丂专东丛();
    }
    private void OnDestroy()
    {
        null = null;
        PoolManager.丄丘七三上丕世丞业 = 0;
    }
    internal System.Collections.Generic.List<PoolManager.丒丄丑丌丘丆专丘丝> 丌丒丝七丞丄上丁丆(string 不丏与丏丂丙丝丗与)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<丒丄丑丌丘丆专丘丝>> val_3 = this.丅上丄丌业丂丄与丐;
        if((val_3.ContainsKey(key:  不丏与丏丂丙丝丗与)) != true)
        {
                val_3 = this.丅上丄丌业丂丄与丐;
            val_3.Add(key:  不丏与丏丂丙丝丗与, value:  new System.Collections.Generic.List<丒丄丑丌丘丆专丘丝>());
        }
        
        if(this.丅上丄丌业丂丄与丐 != null)
        {
                return this.丅上丄丌业丂丄与丐.Item[不丏与丏丂丙丝丗与];
        }
        
        return this.丅上丄丌业丂丄与丐.Item[不丏与丏丂丙丝丗与];
    }
    internal UnityEngine.GameObject 丁丄三下七丝丐丞七(string 不丏与丏丂丙丝丗与, UnityEngine.Transform 专丏丕丌世一专丒且)
    {
        var val_3;
        var val_4;
        UnityEngine.Transform val_17;
        string val_18;
        var val_19;
        var val_21;
        int val_22;
        val_17 = 专丏丕丌世一专丒且;
        val_18 = 不丏与丏丂丙丝丗与;
        val_19 = this.丌丒丝七丞丄上丁丆(不丏与丏丂丙丝丗与:  val_18);
        List.Enumerator<T> val_2 = val_19.GetEnumerator();
        val_21 = 0;
        label_5:
        if((1270858608 & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
                var val_6 = (val_3 != 0) ? 1 : 0;
        }
        else
        {
                var val_7 = (val_3 != 0) ? 1 : 0;
        }
        
        if(val_3 == 0)
        {
            goto label_5;
        }
        
        mem2[0] = 0;
        val_5.m_stringLength.transform.SetParent(p:  val_17);
        val_22 = val_5.m_stringLength;
        mem2[0] = UnityEngine.Time.frameCount;
        goto label_8;
        label_2:
        val_22 = 0;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 0)
        {
                return val_22;
        }
        
        if((val_21 & 1) == 0)
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_11 = val_19.GetEnumerator();
        val_19 = 0;
        goto label_24;
        label_27:
        val_18 = val_4.丐丏七丌丕丗业且上();
        if(val_3 < 1000000)
        {
                val_12.m_stringLength.transform.SetParent(p:  val_17);
            val_22 = val_12.m_stringLength;
            val_19 = val_18;
        }
        
        label_24:
        if((1270858608 & 1) != 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_38;
        label_20:
        if((this.且丁万丕丂丁丑七不(不丏与丏丂丙丝丗与:  val_18)) != null)
        {
                val_14.丄世不下专七丂丘丝 = false;
        }
        else
        {
                mem[24] = 0;
        }
        
        val_18 = val_14.丝三丁东丈丒世丅业.transform;
        val_18.SetParent(p:  val_17);
        val_22 = val_14.丝三丁东丈丒世丅业;
        return val_22;
        label_38:
        val_17 = UnityEngine.Time.frameCount;
        mem2[0] = val_17;
        return val_22;
    }
    internal T 丁丄三下七丝丐丞七<T>(string 不丏与丏丂丙丝丗与, UnityEngine.Transform 专丏丕丌世一专丒且)
    {
        if((this.丁丄三下七丝丐丞七(不丏与丏丂丙丝丗与:  不丏与丏丂丙丝丗与, 专丏丕丌世一专丒且:  专丏丕丌世一专丒且)) == null)
        {
            
        }
    
    }
    internal void 下一丟丆丅万丏丅丁(string 不丏与丏丂丙丝丗与, UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_4;
        string val_16;
        var val_17;
        val_16 = 不丏与丏丂丙丝丗与;
        val_17 = this;
        List.Enumerator<T> val_2 = this.丌丒丝七丞丄上丁丆(不丏与丏丂丙丝丗与:  val_16).GetEnumerator();
        label_6:
        if((1271193488 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5.m_stringLength != 丝三丁东丈丒世丅业)
        {
            goto label_6;
        }
        
        mem2[0] = 1;
        丝三丁东丈丒世丅业.SetActive(value:  false);
        val_5.m_stringLength.transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  1000f);
        丝三丁东丈丒世丅业.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_17 = 丝三丁东丈丒世丅业.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        val_17.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_16 = System.String.Format(format:  "<<<<<<<<<<<<<<<<<<<<<<< ошибка возврата элемента в пул. poolName={0} gameObject={1} #5431 >>>>>>>>>>>>>>>>>>>>>>", arg0:  val_16, arg1:  丝三丁东丈丒世丅业.name);
        UnityEngine.Debug.LogError(message:  val_16);
    }
    private void 丟丐丛丙丘丂专东丛()
    {
        if(this.一专世丏丞丑三丘七 == true)
        {
                return;
        }
        
        this.丅上丄丌业丂丄与丐 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<丒丄丑丌丘丆专丘丝>>();
        this.丘上丑世一丆丘丘三(丈丁三专业与丂丛与: ref  this.丅上丄丌业丂丄与丐, 丐丒专丅丆丐丕专丑: ref  this.records);
        this.一专世丏丞丑三丘七 = true;
    }
    private void 丘上丑世一丆丘丘三(ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PoolManager.丒丄丑丌丘丆专丘丝>> 丈丁三专业与丂丛与, ref System.Collections.Generic.List<PoolManager.PoolEntry> 丐丒专丅丆丐丕专丑)
    {
        var val_3;
        var val_16;
        var val_17;
        UnityEngine.GameObject val_18;
        List.Enumerator<T> val_1 = 丐丒专丅丆丐丕专丑.GetEnumerator();
        val_16 = 1152921505171808256;
        label_30:
        if((1271514592 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        System.Collections.Generic.List<丒丄丑丌丘丆专丘丝> val_5 = new System.Collections.Generic.List<丒丄丑丌丘丆专丘丝>();
        if(东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() == true)
        {
            goto label_30;
        }
        
        val_17 = 0;
        goto label_6;
        label_28:
        if((X23 != 0) && (东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() != false))
        {
                val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  X23);
        }
        else
        {
                val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  X23);
        }
        
        val_18.transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        val_18.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        .丄世不下专七丂丘丝 = true;
        new PoolManager.丒丄丑丌丘丆专丘丝() = new System.Object();
        .丝三丁东丈丒世丅业 = val_18;
        .丄世不下专七丂丘丝 = true;
        .丝上业专丙下不丌丘 = 1152921505319571456;
        val_18.SetActive(value:  false);
        val_18.name = val_4.m_stringLength;
        null.Add(item:  new PoolManager.丒丄丑丌丘丆专丘丝());
        val_17 = 1;
        label_6:
        if(val_17 < 1152921540238085024)
        {
            goto label_28;
        }
        
        丈丁三专业与丂丛与.set_Item(key:  val_4.m_stringLength, value:  null);
        goto label_30;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private PoolManager.丒丄丑丌丘丆专丘丝 且丁万丕丂丁丑七不(string 不丏与丏丂丙丝丗与)
    {
        var val_4;
        string val_17;
        bool val_18;
        UnityEngine.GameObject val_19;
        object val_20;
        val_17 = 不丏与丏丂丙丝丗与;
        System.Collections.Generic.List<丒丄丑丌丘丆专丘丝> val_1 = this.丌丒丝七丞丄上丁丆(不丏与丏丂丙丝丗与:  val_17);
        List.Enumerator<T> val_2 = this.records.GetEnumerator();
        val_18 = 1152921540238050208;
        label_7:
        if((1271712464 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((X23 == 0) || ((System.String.op_Equality(a:  val_5.m_stringLength, b:  val_17)) == false))
        {
            goto label_7;
        }
        
        if((X23 == 0) || (东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() == false))
        {
            goto label_13;
        }
        
        val_19 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  X23);
        goto label_16;
        label_2:
        val_20 = 0;
        goto label_17;
        label_13:
        val_19 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  X23);
        label_16:
        val_19.transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        val_19.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        val_20 = new PoolManager.丒丄丑丌丘丆专丘丝();
        val_18 = true;
        .丄世不下专七丂丘丝 = val_18;
        val_20 = new System.Object();
        .丝三丁东丈丒世丅业 = val_19;
        .丄世不下专七丂丘丝 = val_18;
        val_19.SetActive(value:  false);
        val_19.name = val_5.m_stringLength;
        val_1.Add(item:  new PoolManager.丒丄丑丌丘丆专丘丝());
        this.丅上丄丌业丂丄与丐.set_Item(key:  val_17, value:  val_1);
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丒丄丑丌丘丆专丘丝)val_20;
    }
    public PoolManager()
    {
        this.records = new System.Collections.Generic.List<PoolEntry>();
        this.丅上丄丌业丂丄与丐 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<丒丄丑丌丘丆专丘丝>>();
    }
    private static PoolManager()
    {
    
    }

}
