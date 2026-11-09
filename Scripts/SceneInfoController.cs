using UnityEngine;
public sealed class SceneInfoController : MonoBehaviour
{
    // Fields
    private const float 业丑丑业丗丗丟丂丞 = 870;
    internal static readonly string 丁丑丈与丌丂丕世世;
    internal static readonly string 丝且专东丘丛丈丙丑;
    internal static SceneInfoController 丄丘七三上丕世丞业;
    private static readonly System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, int> 丂丏丕丛丑丂一丗业;
    public System.Collections.Generic.List<SceneInfo> allScenes;
    private System.Collections.Generic.List<SceneInfo> 丞不丐丒七丐丅丏且;
    private System.Collections.Generic.List<AllScenesForMode> 丝丏丈丑丟下上七丁;
    public string jsonConfig;
    public System.Collections.Generic.List<AllScenesForMode> modeInfo;
    private static System.Action 丄东丏三丟丂丄且丌;
    
    // Methods
    internal static void 丕丁丆丂丕七丁丕丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  SceneInfoController.丄东丏三丟丂丄且丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(SceneInfoController.丄东丏三丟丂丄且丌 != 1152921505254400032);
    
    }
    internal static void 三丐万丑与三丟专丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  SceneInfoController.丄东丏三丟丂丄且丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(SceneInfoController.丄东丏三丟丂丄且丌 != 1152921505254400032);
    
    }
    private void Awake()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        SceneInfoController.丄丘七三上丕世丞业 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SceneInfoController::上丐不丌万上与不且()));
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SceneInfoController::专丂丐丝三丁丂与且()));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void SceneInfoController::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        this.丐丕世丄业丝丑丌一();
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  SceneInfoController.丝且专东丘丛丈丙丑)) != true)
        {
                val_9 = null;
            val_9 = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  SceneInfoController.丝且专东丘丛丈丙丑, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        val_10 = null;
        val_10 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  SceneInfoController.丁丑丈与丌丂丕世世)) != false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  SceneInfoController.丁丑丈与丌丂丕世世, 下下丏一丙不丘丌丞:  System.String.alignConst);
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 35)
        {
                return;
        }
        
        this.丐丕世丄业丝丑丌一();
    }
    private void OnDestroy()
    {
        var val_2;
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SceneInfoController::上丐不丌万上与不且()));
        val_2 = null;
        val_2 = null;
        SceneInfoController.丄丘七三上丕世丞业 = 0;
    }
    internal void 上丐不丌万上与不且()
    {
        this.丐丕世丄业丝丑丌一();
    }
    internal SceneInfo 丝丅丈丁且丐不丂丝(string 丆丕丁专丘三丄与七)
    {
        System.Collections.Generic.List<SceneInfo> val_7;
        var val_8;
        var val_9;
        val_7 = 丆丕丁专丘三丄与七;
        val_8 = 0;
        goto label_1;
        label_10:
        string val_4 = this.allScenes.Item[0].gameObject.name;
        if((System.StringComparer.OrdinalIgnoreCase & 1) != 0)
        {
            goto label_8;
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < this.allScenes.Count)
        {
            goto label_10;
        }
        
        val_9 = 0;
        return (SceneInfo)val_7.Item[0];
        label_8:
        val_7 = this.allScenes;
        return (SceneInfo)val_7.Item[0];
    }
    internal SceneInfo 丝丅丈丁且丐不丂丝(string 丆丕丁专丘三丄与七, System.Collections.Generic.List<SceneInfo> 丞丟万万丑且且七丏)
    {
        var val_8;
        if(丞丟万万丑且且七丏 == null)
        {
                return 0;
        }
        
        if(丞丟万万丑且且七丏.Count < 1)
        {
                return 0;
        }
        
        label_9:
        string val_5 = 丞丟万万丑且且七丏.Item[0].gameObject.name;
        if((System.StringComparer.OrdinalIgnoreCase & 1) != 0)
        {
            goto label_8;
        }
        
        val_8 = 0 + 1;
        if(val_8 < 丞丟万万丑且且七丏.Count)
        {
            goto label_9;
        }
        
        return 0;
        label_8:
        SceneInfo val_7 = 丞丟万万丑且且七丏.Item[0];
        return 0;
    }
    internal SceneInfo 丝丅丈丁且丐不丂丝(Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万, int 丈东丅万丟丞丒不丒)
    {
        SceneInfo val_4 = this.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  丈东丅万丟丞丒不丒);
        if(val_4 != 0)
        {
                if((val_4.七丗与三丝丑丈一专(世专丝一丙业丅丌上:  丐丝丟丙丛下专丐万)) == true)
        {
                return (SceneInfo)val_4;
        }
        
        }
        
        val_4 = 0;
        return (SceneInfo)val_4;
    }
    internal SceneInfo 丝丅丈丁且丐不丂丝(int 丈东丅万丟丞丒不丒)
    {
        System.Collections.Generic.List<SceneInfo> val_4;
        var val_5;
        var val_6;
        val_4 = 丈东丅万丟丞丒不丒;
        val_5 = 0;
        goto label_1;
        label_6:
        SceneInfo val_1 = this.allScenes.Item[0];
        if(val_1.indexMap == val_4)
        {
            goto label_4;
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < this.allScenes.Count)
        {
            goto label_6;
        }
        
        val_6 = 0;
        return (SceneInfo)val_4.Item[0];
        label_4:
        val_4 = this.allScenes;
        return (SceneInfo)val_4.Item[0];
    }
    internal bool 丌且丏世丌丗丕丄丟(string 专万丟三世业丙丈且, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        string val_13;
        var val_14;
        System.Collections.Generic.List<SceneInfo> val_15;
        var val_16;
        val_13 = 专万丟三世业丙丈且;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_13 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "IsMapAvailableInMode sceneName.IsNullOrEmpty()", args:  val_13);
            return false;
        }
        
        if(丂丛丑东不丅丈一东 == 1)
        {
                return this.丗丏丅业与专上上丄(专万丟三世业丙丈且:  val_13);
        }
        
        val_14 = 0;
        goto label_8;
        label_15:
        if(this.modeInfo.Item[0] == null)
        {
            goto label_10;
        }
        
        AllScenesForMode val_4 = this.modeInfo.Item[0];
        if(val_4.mode == 丂丛丑东不丅丈一东)
        {
            goto label_13;
        }
        
        label_10:
        val_14 = 1;
        label_8:
        if(val_14 < this.modeInfo.Count)
        {
            goto label_15;
        }
        
        return false;
        label_13:
        if(this.modeInfo.Item[0] == null)
        {
                return false;
        }
        
        val_15 = val_6.avaliableScenes;
        if(val_15 == null)
        {
                return false;
        }
        
        val_16 = 0;
        goto label_19;
        label_28:
        if(val_6.avaliableScenes.Item[0] != 0)
        {
                if((System.String.Equals(a:  val_6.avaliableScenes.Item[0].丙且上丒不下丑下丞(), b:  val_13, comparisonType:  5)) == true)
        {
                return false;
        }
        
        }
        
        val_15 = val_6.avaliableScenes;
        val_16 = 1;
        label_19:
        if(val_16 < val_15.Count)
        {
            goto label_28;
        }
        
        return false;
    }
    private bool 丗丏丅业与专上上丄(string 专万丟三世业丙丈且)
    {
        var val_5;
        var val_12;
        var val_13;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专万丟三世业丙丈且)) == false)
        {
            goto label_3;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "IsMapAvailable sceneName.IsNullOrEmpty()", args:  System.Array.Empty<System.Object>());
        goto label_6;
        label_3:
        List.Enumerator<T> val_3 = this.modeInfo.GetEnumerator();
        label_11:
        if(((-70901200) & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        label_14:
        if(0 >= val_6.m_stringLength.Count)
        {
            goto label_11;
        }
        
        val_12 = 0 + 1;
        if((System.String.op_Equality(a:  val_6.m_stringLength.Item[0].丙且上丒不下丑下丞(), b:  专万丟三世业丙丈且)) == false)
        {
            goto label_14;
        }
        
        val_13 = 1;
        goto label_15;
        label_8:
        val_13 = 0;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_13;
        label_6:
        val_13 = 0;
        return (bool)val_13;
    }
    internal int 丕三与丌丂业丄世上()
    {
        List.Enumerator<T> val_1 = this.modeInfo.GetEnumerator();
        label_7:
        label_5:
        if(((-70723640) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2.m_stringLength.Count <= 0)
        {
            goto label_5;
        }
        
        int val_4 = val_2.m_stringLength.Count;
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return 0;
    }
    internal SceneInfo 上不丄丐丁丌丘丝世(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, string 七丆丂丂下丈且丟世)
    {
        string val_6;
        var val_7;
        var val_8;
        val_6 = 七丆丂丂下丈且丟世;
        val_7 = this;
        if(((this.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  丂丛丑东不丅丈一东)) == null) || (val_1.avaliableScenes == null))
        {
            goto label_12;
        }
        
        List.Enumerator<T> val_2 = val_1.avaliableScenes.GetEnumerator();
        label_6:
        if(((-70578872) & 1) == 0)
        {
            goto label_3;
        }
        
        val_8 = 0.丐丏七丌丕丗业且上();
        val_7 = val_8.丙且上丒不下丑下丞();
        if((val_7.Equals(value:  val_6)) == false)
        {
            goto label_6;
        }
        
        goto label_7;
        label_3:
        val_8 = 0;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (SceneInfo)val_8;
        label_12:
        val_8 = 0;
        return (SceneInfo)val_8;
    }
    internal AllScenesForMode 丒业东下专丐七与三(Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万)
    {
        .丐丝丟丙丛下专丐万 = 丐丝丟丙丛下专丐万;
        if(this.modeInfo != null)
        {
                return this.modeInfo.Find(match:  new System.Predicate<AllScenesForMode>(object:  new SceneInfoController.丄丆丌丌丕丈丆丆业(), method:  System.Boolean SceneInfoController.丄丆丌丌丕丈丆丆业::一丛丅丙七丑丂丂丟(AllScenesForMode 丛丄丂丞业丙丑丂万)));
        }
        
        return this.modeInfo.Find(match:  new System.Predicate<AllScenesForMode>(object:  new SceneInfoController.丄丆丌丌丕丈丆丆业(), method:  System.Boolean SceneInfoController.丄丆丌丌丕丈丆丆业::一丛丅丙七丑丂丂丟(AllScenesForMode 丛丄丂丞业丙丑丂万)));
    }
    internal AllScenesForMode 丒业东下专丐七与三(Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万, System.Collections.Generic.List<AllScenesForMode> 丞丟万万丑且且七丏)
    {
        var val_4;
        .丐丝丟丙丛下专丐万 = 丐丝丟丙丛下专丐万;
        if(丞丟万万丑且且七丏 != null)
        {
                AllScenesForMode val_3 = 丞丟万万丑且且七丏.Find(match:  new System.Predicate<AllScenesForMode>(object:  new SceneInfoController.丒丂万丒丂一上丞一(), method:  System.Boolean SceneInfoController.丒丂万丒丂一上丞一::一丛丅丙七丑丂丂丟(AllScenesForMode 丛丄丂丞业丙丑丂万)));
            return (AllScenesForMode)val_4;
        }
        
        val_4 = 0;
        return (AllScenesForMode)val_4;
    }
    internal int 业丕不丘丒丈丒丏丆(Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万)
    {
        .丐丝丟丙丛下专丐万 = 丐丝丟丙丛下专丐万;
        AllScenesForMode val_3 = this.modeInfo.Find(match:  new System.Predicate<AllScenesForMode>(object:  new SceneInfoController.丘丞三且东万丕丙丂(), method:  System.Boolean SceneInfoController.丘丞三且东万丕丙丂::丑专丒丕世丙丏丗丂(AllScenesForMode 上一丝业不下丞世丗)));
        if(val_3 == null)
        {
                return (int)val_3;
        }
        
        if(val_3.avaliableScenes != null)
        {
                return val_3.avaliableScenes.Count;
        }
        
        return val_3.avaliableScenes.Count;
    }
    private void 上丘一下下业丄丑丟(string 丆丕丁专丘三丄与七, string 世业丞丞世丑丌丙丙, string 丒丏丛不下丘业下业)
    {
        SceneInfo val_23 = this.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  丆丕丁专丘三丄与七, 丞丟万万丑且且七丏:  this.丞不丐丒七丐丅丏且);
        if(val_23 != 0)
        {
                return;
        }
        
        val_23 = 丟丌丁且且世丈丈丟.丕不七与丘东丞丕业();
        if(丒丏丛不下丘业下业 != null)
        {
                new System.Version() = new System.Version(version:  丒丏丛不下丘业下业);
        }
        else
        {
                new System.Version() = new System.Version(major:  100, minor:  0, build:  0);
        }
        
        System.Version val_6 = null;
        if(世业丞丞世丑丌丙丙 != null)
        {
                val_6 = new System.Version(version:  世业丞丞世丑丌丙丙);
        }
        else
        {
                val_6 = new System.Version(major:  0, minor:  0, build:  0);
        }
        
        if((System.Version.op_GreaterThanOrEqual(v1:  val_23, v2:  val_6)) == false)
        {
                return;
        }
        
        if((System.Version.op_LessThanOrEqual(v1:  val_23, v2:  new System.Version())) == false)
        {
                return;
        }
        
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  "SceneInfo/"("SceneInfo/") + 丆丕丁专丘三丄与七);
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        if(val_23 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_23.GetComponent<SceneInfo>().gameObject);
        val_15.transform.SetParent(p:  this.transform);
        val_15.gameObject.name = 丆丕丁专丘三丄与七;
        SceneInfo val_19 = val_15.GetComponent<SceneInfo>();
        string val_20 = (世业丞丞世丑丌丙丙 != null) ? 世业丞丞世丑丌丙丙 : "0.0.0";
        if(val_19 != null)
        {
                val_19.minAvaliableVersion = val_20;
            val_19.maxAvaliableVersion = (丒丏丛不下丘业下业 != null) ? 丒丏丛不下丘业下业 : "100.0.0";
        }
        else
        {
                val_19.minAvaliableVersion = val_20;
            val_19.maxAvaliableVersion = (丒丏丛不下丘业下业 != null) ? 丒丏丛不下丘业下业 : "100.0.0";
        }
        
        bool val_23 = val_19.isPreloading;
        val_23 = val_23 ^ 1;
        val_19.丆东且下丈丕丒一万 = val_23;
        this.丞不丐丒七丐丅丏且.Add(item:  val_19);
    }
    internal bool 不七丕下东丙丟丆业(string 丆丕丁专丘三丄与七)
    {
        return true;
    }
    internal int 丝上专丂且东丏丄丌(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, SceneInfo 东下丌丝且七丛丘丒, bool 丁丏丗且上丗下与下 = False)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_8;
        if(((this.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  丂丛丑东不丅丈一东)) == null) || (东下丌丝且七丛丘丒 == 0))
        {
            goto label_4;
        }
        
        val_8 = 丂丛丑东不丅丈一东;
        if((丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  val_8, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 丁丏丗且上丗下与下:  丁丏丗且上丗下与下)) != 2147483647)
        {
                return (int)val_8;
        }
        
        if((val_1.unlockedAtLevel.ContainsKey(key:  东下丌丝且七丛丘丒)) == false)
        {
            goto label_7;
        }
        
        return 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  val_1.unlockedAtLevel.Item[东下丌丝且七丛丘丒]);
        label_4:
        Rilisoft.一世东上七三丌丅不 val_7 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if(val_7 != null)
        {
                return val_7.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东);
        }
        
        return val_7.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东);
        label_7:
        val_8 = 0;
        return (int)val_8;
    }
    private void 东丌不丌专东七丝七(string 丆丕丁专丘三丄与七, Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万, int 上丝丆丕不丑业且丙)
    {
        System.Collections.Generic.List<AllScenesForMode> val_10;
        AllScenesForMode val_11;
        val_10 = this;
        SceneInfo val_1 = this.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  丆丕丁专丘三丄与七, 丞丟万万丑且且七丏:  this.丞不丐丒七丐丅丏且);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                val_1.丗丐专世丛丄丑丐丛(世专丝一丙业丅丌上:  丐丝丟丙丛下专丐万);
        }
        else
        {
                0.丗丐专世丛丄丑丐丛(世专丝一丙业丅丌上:  丐丝丟丙丛下专丐万);
        }
        
        if(val_1.丆东且下丈丕丒一万 != true)
        {
                val_1.丆东且下丈丕丒一万 = val_1.isPreloading ^ 1;
            if(val_1.isPreloading == true)
        {
                return;
        }
        
        }
        
        val_11 = this.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  丐丝丟丙丛下专丐万, 丞丟万万丑且且七丏:  this.丝丏丈丑丟下上七丁);
        if(val_11 == null)
        {
                AllScenesForMode val_5 = null;
            val_11 = val_5;
            val_5 = new AllScenesForMode();
            .mode = 丐丝丟丙丛下专丐万;
            val_10 = this.丝丏丈丑丟下上七丁;
            val_10.Add(item:  val_5);
        }
        
        val_5.丟丑上丗三丞东丙丞(丒丁不世七世丛丒三:  val_1, 上丝丆丕不丑业且丙:  上丝丆丕不丑业且丙);
        if((丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  丐丝丟丙丛下专丐万, 专万丟三世业丙丈且:  丆丕丁专丘三丄与七)) != 2147483647)
        {
            goto label_11;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() < 上丝丆丕不丑业且丙)
        {
            goto label_14;
        }
        
        label_15:
        val_5.专东且与丅东丛不上(丒丁不世七世丛丒三:  val_1);
        return;
        label_11:
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  丐丝丟丙丛下专丐万, 专万丟三世业丙丈且:  丆丕丁专丘三丄与七, 丁丏丗且上丗下与下:  false))) == true)
        {
            goto label_15;
        }
        
        label_14:
        val_5.一丗丗且丝丝丑丂丝(丒丁不世七世丛丒三:  val_1);
    }
    private void 东丌不丌专东七丝七(string 丆丕丁专丘三丄与七, Rilisoft.七丕丟丏三丈一丄世 丐丝丟丙丛下专丐万)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        AllScenesForMode val_7;
        val_6 = 丐丝丟丙丛下专丐万;
        SceneInfo val_1 = this.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  丆丕丁专丘三丄与七, 丞丟万万丑且且七丏:  this.丞不丐丒七丐丅丏且);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                val_1.丗丐专世丛丄丑丐丛(世专丝一丙业丅丌上:  val_6);
        }
        else
        {
                0.丗丐专世丛丄丑丐丛(世专丝一丙业丅丌上:  val_6);
        }
        
        if(val_1.丆东且下丈丕丒一万 != true)
        {
                val_1.丆东且下丈丕丒一万 = val_1.isPreloading ^ 1;
            if(val_1.isPreloading == true)
        {
                return;
        }
        
        }
        
        val_7 = this.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_6, 丞丟万万丑且且七丏:  this.丝丏丈丑丟下上七丁);
        if(val_7 == null)
        {
                AllScenesForMode val_5 = null;
            val_7 = val_5;
            val_5 = new AllScenesForMode();
            .mode = val_6;
            val_6 = this.丝丏丈丑丟下上七丁;
            val_6.Add(item:  val_5);
        }
        
        val_5.专东且与丅东丛不上(丒丁不世七世丛丒三:  val_1);
    }
    private void 专与丐丟业东丛丛三(string 丆丕丁专丘三丄与七, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        AllScenesForMode val_7;
        val_6 = 丂丛丑东不丅丈一东;
        SceneInfo val_1 = this.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  丆丕丁专丘三丄与七, 丞丟万万丑且且七丏:  this.丞不丐丒七丐丅丏且);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.丆东且下丈丕丒一万 != true)
        {
                val_1.丆东且下丈丕丒一万 = val_1.isPreloading ^ 1;
            if(val_1.isPreloading == true)
        {
                return;
        }
        
        }
        
        val_7 = this.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_6, 丞丟万万丑且且七丏:  this.丝丏丈丑丟下上七丁);
        if(val_7 == null)
        {
                AllScenesForMode val_5 = null;
            val_7 = val_5;
            val_5 = new AllScenesForMode();
            .mode = val_6;
            val_6 = this.丝丏丈丑丟下上七丁;
            val_6.Add(item:  val_5);
        }
        
        val_5.丆上专丞丈下丈丂丒(丒丁不世七世丛丒三:  val_1);
    }
    private void 丐丕世丄业丝丑丌一()
    {
        var val_11;
        var val_38;
        var val_47;
        string val_49;
        string val_50;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  35));
        if(val_3 != null)
        {
                val_47 = 1152921504689381376;
        }
        
        UnityEngine.Debug.LogError(message:  "Not parse map list config");
        return;
        label_25:
        if(((-68805056) & 1) == 0)
        {
            goto label_15;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_11.GetAwaiter();
        if(val_13._value._obj == 0)
        {
            goto label_25;
        }
        
        if((val_13._value._obj.ContainsKey(key:  "L")) != false)
        {
                val_49 = val_13._value._obj.Item["L"];
        }
        else
        {
                val_49 = 0;
        }
        
        if((val_13._value._obj.ContainsKey(key:  "H")) != false)
        {
                val_50 = val_13._value._obj.Item["H"];
        }
        else
        {
                val_50 = 0;
        }
        
        this.上丘一下下业丄丑丟(丆丕丁专丘三丄与七:  val_13._value._obj.丐丏七丌丕丗业且上(), 世业丞丞世丑丌丙丙:  val_49, 丒丏丛不下丘业下业:  val_50);
        goto label_25;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_3.ContainsKey(key:  "modes")) == false)
        {
            goto label_138;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_22 = GetEnumerator();
        label_123:
        if(((-68805056) & 1) == 0)
        {
            goto label_45;
        }
        
        ConfiguredValueTaskAwaiter val_23 = val_11.GetAwaiter();
        if(val_23._value._obj == 0)
        {
            goto label_123;
        }
        
        object val_26 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_23._value._obj.丐丏七丌丕丗业且上());
        if(val_23._value._obj != 0)
        {
                val_52 = null;
        }
        
        if(val_23._value._obj != 0)
        {
                val_52 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_28 = GetEnumerator();
        label_98:
        if(((-68805136) & 1) == 0)
        {
            goto label_59;
        }
        
        ConfiguredValueTaskAwaiter val_29 = val_11.GetAwaiter();
        if((0.ContainsKey(key:  "L")) != false)
        {
                val_53 = System.Convert.ToInt32(value:  0.Item["L"]);
        }
        else
        {
                val_53 = 0;
        }
        
        val_54 = null;
        val_54 = null;
        val_55 = (0.ContainsKey(key:  "C")) ^ 1;
        if(MapVoteController.丛丆丂丐丛不不丟万 == 0)
        {
            goto label_73;
        }
        
        val_56 = null;
        val_56 = null;
        System.Collections.Generic.List<SceneInfo> val_35 = MapVoteController.丛丆丂丐丛不不丟万.丄丙丕与三丅丅丈丝(丂丛丑东不丅丈一东:  null);
        if(val_35 == null)
        {
            goto label_93;
        }
        
        List.Enumerator<T> val_36 = val_35.GetEnumerator();
        do
        {
            if(((-68805184) & 1) == 0)
        {
            goto label_81;
        }
        
        }
        while((System.String.op_Equality(a:  val_29._value._obj.丐丏七丌丕丗业且上(), b:  val_38.丐丏七丌丕丗业且上().丙且上丒不下丑下丞())) == false);
        
        val_55 = 0;
        goto label_81;
        label_73:
        if(val_55 == true)
        {
            goto label_94;
        }
        
        label_97:
        if(val_53 < 1)
        {
            goto label_83;
        }
        
        this.东丌不丌专东七丝七(丆丕丁专丘三丄与七:  val_29._value._obj.丐丏七丌丕丗业且上(), 丐丝丟丙丛下专丐万:  null, 上丝丆丕不丑业且丙:  0);
        goto label_98;
        label_83:
        this.东丌不丌专东七丝七(丆丕丁专丘三丄与七:  val_29._value._obj.丐丏七丌丕丗业且上(), 丐丝丟丙丛下专丐万:  null);
        goto label_98;
        label_81:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 == 1) || (566 != 566))
        {
            goto label_92;
        }
        
        if((1 & 2147483648) != 0)
        {
            goto label_93;
        }
        
        if(( & 1) != 0)
        {
            goto label_94;
        }
        
        goto label_97;
        label_92:
        label_93:
        if(( & 1) == 0)
        {
            goto label_97;
        }
        
        label_94:
        this.专与丐丟业东丛丛三(丆丕丁专丘三丄与七:  val_29._value._obj.丐丏七丌丕丗业且上(), 丂丛丑东不丅丈一东:  null);
        goto label_98;
        label_59:
        val_57 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 == 1) || (654 != 654))
        {
            goto label_117;
        }
        
        goto label_123;
        label_117:
        if( == 0)
        {
            goto label_123;
        }
        
        goto label_123;
        label_45:
        val_59 = 0;
        val_60 = 0;
        val_58 = 0 + 1;
        mem2[0] = 682;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_133;
        }
        
        if(( == 0) || (654 == 682))
        {
            goto label_138;
        }
        
        label_137:
        label_138:
        this.丆丕丄七丑丑丂丒丒();
        return;
        label_133:
        if( != 0)
        {
            goto label_137;
        }
        
        goto label_138;
    }
    public static Rilisoft.七丕丟丏三丈一丄世 ConvertModeToEnum(string 万丌丝丝丌丟丕上丗)
    {
        object val_2 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  万丌丝丝丌丟丕上丗);
        return (Rilisoft.七丕丟丏三丈一丄世)null;
    }
    internal static System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世> 丞万丟东丘丒丆丒丙(int 丈丘丝一丗下丈丐不)
    {
        var val_6;
        System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世> val_1 = new System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>();
        val_6 = null;
        val_6 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = SceneInfoController.丂丏丕丛丑丂一丗业.GetEnumerator();
        label_7:
        if(((-68456096) & 1) == 0)
        {
            goto label_4;
        }
        
        if((-68456104) > 丈丘丝一丗下丈丐不)
        {
            goto label_7;
        }
        
        bool val_5 = val_1.Add(item:  0.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂());
        goto label_7;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 丆丕丄七丑丑丂丒丒()
    {
        var val_1;
        System.Action val_2;
        this.allScenes = this.丞不丐丒七丐丅丏且;
        this.modeInfo = this.丝丏丈丑丟下上七丁;
        this.专丂丐丝三丁丂与且();
        val_1 = null;
        val_1 = null;
        val_2 = SceneInfoController.丄东丏三丟丂丄且丌;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = SceneInfoController.丄东丏三丟丂丄且丌;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    private void 专丂丐丝三丁丂与且()
    {
        goto label_1;
        label_5:
        this.allScenes.Item[0].丆丟丁丈丅丕丆丝专();
        0 = 1;
        label_1:
        if(0 < this.allScenes.Count)
        {
            goto label_5;
        }
    
    }
    public SceneInfoController()
    {
        this.allScenes = new System.Collections.Generic.List<SceneInfo>();
        this.modeInfo = new System.Collections.Generic.List<AllScenesForMode>();
    }
    private static SceneInfoController()
    {
        SceneInfoController.丁丑丈与丌丂丕世世 = "mapListKey";
        SceneInfoController.丝且专东丘丛丈丙丑 = "mapListVersionKey";
        SceneInfoController.丄丘七三上丕世丞业 = 0;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32> val_2 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(comparer:  Rilisoft.专丝世与丈丈丞丙丟.丑七不且上丗丁一世());
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  1);
            val_2.Add(key:  2, value:  2);
            val_2.Add(key:  1, value:  3);
            val_2.Add(key:  4, value:  4);
            val_2.Add(key:  3, value:  5);
        }
        else
        {
                val_2.Add(key:  0, value:  1);
            val_2.Add(key:  2, value:  2);
            val_2.Add(key:  1, value:  3);
            val_2.Add(key:  4, value:  4);
            val_2.Add(key:  3, value:  5);
        }
        
        val_2.Add(key:  5, value:  6);
        SceneInfoController.丂丏丕丛丑丂一丗业 = val_2;
    }

}
