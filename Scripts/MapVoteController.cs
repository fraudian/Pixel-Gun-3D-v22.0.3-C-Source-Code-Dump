using UnityEngine;
public class MapVoteController : MonoBehaviour
{
    // Fields
    internal static MapVoteController 丄丘七三上丕世丞业;
    private const float 丞七世丞丈丈万丕上 = 870;
    private const float 丒丞一七丒世丂下业 = 870;
    private const int 丛丆丂丐丛不不丟万 = 5;
    internal static string 七七业世丐专一丒与;
    internal static string 丗与丕丛丐丑上丗不;
    internal static string 丒丙丄东丁下东丟丘;
    internal static string 丄一丝七丏丛万丄丟;
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<int>> 丗三丛丛丝与与丈丙;
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<int, int>> 三与丄且下丌丑丕丑;
    internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<SceneInfo>> 上世专丆丈上丒丅东;
    internal long 丈丒丑一丑丕东丗且;
    internal long 三一丁丐专七丙丝与;
    internal System.Action 丅且业丒专专丘世丂;
    private bool 丝与丆丞东丘丈东丘;
    private bool 丑万丗丑与世不丗丅;
    private bool 丙丌不丟丞三东丄下;
    
    // Properties
    internal static string 丒不丛丅专丙一丌七 { get; }
    internal static string 与丁万丈丒丌一专丟 { get; }
    
    // Methods
    internal static string 丁丒丈丄丝丞丆丝丁()
    {
        return "https://secure.pixelgunserver.com/pixelgun3d-config/rating-maps/rating-map-all.json";
    }
    internal static string 丛丅丝丟东业一丟丁()
    {
        return "https://secure.pixelgunserver.com/pixelgun3d-config/rating-maps/rating-map-top.json";
    }
    private void Awake()
    {
        null = null;
        MapVoteController.丛丆丂丐丛不不丟万 = this;
        this.上丛丌丆丑上七世三();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.不丒丛世且丏丄丞丘());
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.专丁丕专丏七三且丘());
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MapVoteController::丆丒三丂丂东丆一丏()));
    }
    private void OnDestroy()
    {
    
    }
    private void 上丛丌丆丑上七世三()
    {
        this.丗三丛丛丝与与丈丙 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<System.Int32>>();
        this.三与丄且下丌丑丕丑 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<System.Int32, System.Int32>>();
        this.上世专丆丈上丒丅东 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<SceneInfo>>();
        this.下丏丛且一上丞丄东();
        this.丞丒上丙丄上丈丏世();
        this.丆业三万丂不丅丟与();
        this.丝与丆丞东丘丈东丘 = true;
    }
    internal void 丆业三万丂不丅丟与()
    {
        var val_7;
        string val_8;
        string val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_7 = null;
        val_8 = "-1";
        val_7 = null;
        val_9 = MapVoteController.丗与丕丛丐丑上丗不;
        val_10 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_9)) != false)
        {
                val_11 = null;
            val_8 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  MapVoteController.丗与丕丛丐丑上丗不);
        }
        else
        {
                val_12 = null;
            val_9 = MapVoteController.丗与丕丛丐丑上丗不;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_9, 下下丏一丙不丘丌丞:  "-1");
        }
        
        long val_4 = 0;
        if((Equals(value:  "-1")) != false)
        {
                val_13 = 0;
        }
        else
        {
                bool val_5 = System.Int64.TryParse(s:  val_8, result: out  val_4);
            val_13 = val_4;
        }
        
        this.丈丒丑一丑丕东丗且 = 0;
        if(this.丂一丒万丈不丒一万() != false)
        {
                if(this.三一丁丐专七丙丝与 != 0)
        {
            goto label_19;
        }
        
        }
        
        this.七丆七丆丑下与丄丙();
        label_19:
        this.丆丒三丂丂东丆一丏();
    }
    private void 七丆七丆丑下与丄丙()
    {
        var val_6;
        MapVoteController val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_23;
        var val_24;
        val_16 = this;
        this.丗三丛丛丝与与丈丙.Clear();
        val_18 = null;
        val_18 = null;
        string val_15 = MapVoteController.七七业世丐专一丒与;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_15));
        if(val_2 == null)
        {
                return;
        }
        
        val_15 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_15.GetEnumerator();
        label_37:
        if((544682832 & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
        System.Nullable<T> val_10 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_7._value._obj.丐丏七丌丕丗业且上(), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
        if((544682808 & 1) == 0)
        {
            goto label_37;
        }
        
        this.丗三丛丛丝与与丈丙.Add(key:  val_10.HasValue, value:  null);
        if(val_7._value._obj == 0)
        {
            goto label_37;
        }
        
        if(val_7._value._obj != 0)
        {
                val_19 = null;
        }
        
        if(val_7._value._obj != 0)
        {
                val_19 = null;
        }
        
        List.Enumerator<T> val_12 = GetEnumerator();
        label_28:
        if((544682784 & 1) == 0)
        {
            goto label_24;
        }
        
        null.Add(item:  System.Convert.ToInt32(value:  val_6.丐丏七丌丕丗业且上()));
        goto label_28;
        label_24:
        var val_16 = 0;
        val_20 = 0;
        val_16 = val_16 + 1;
        mem2[0] = 199;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_18 = val_16;
        if((val_18 == 1) || ((544682688 + ((0 + 1)) << 2) != 199))
        {
            goto label_34;
        }
        
        var val_17 = 0;
        val_17 = val_17 ^ (val_18 >> 31);
        val_18 = val_18 + val_17;
        goto label_37;
        label_34:
        if( == 0)
        {
            goto label_37;
        }
        
        goto label_37;
        label_10:
        val_17 = 544682688;
        val_23 = 0;
        val_24 = 0;
        val_16 = val_18 + 1;
        mem2[0] = 227;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((val_17 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) == 227)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private bool 丗一丗丐专一丕上丈(long 丂三丟丂丈丐丆丗丟)
    {
        var val_3;
        if(this.丂一丒万丈不丒一万() != false)
        {
                var val_2 = (this.三一丁丐专七丙丝与 != 丂三丟丂丈丐丆丗丟) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal void 丆丒三丂丂东丆一丏()
    {
        if(this.丂一丒万丈不丒一万() == false)
        {
                return;
        }
        
        if(this.三一丁丐专七丙丝与 == this.丈丒丑一丑丕东丗且)
        {
                return;
        }
        
        this.丗三丛丛丝与与丈丙.Clear();
        this.三与丄且下丌丑丕丑.Clear();
        this.丈丒丑一丑丕东丗且 = this.三一丁丐专七丙丝与;
    }
    internal bool 丂一丒万丈不丒一万()
    {
        var val_4;
        if((ExperienceController.丞丞丘业东丙丏七丌() >= 2) && (this.三一丁丐专七丙丝与 != 1))
        {
                var val_3 = (FriendsController.丝丗专上三不丄丑丑() != 1) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal int 丙七万丅万丞下一丕(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        if((this.丗三丛丛丝与与丈丙.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return 5;
        }
        
        return UnityEngine.Mathf.Max(a:  0, b:  5 - this.丗三丛丛丝与与丈丙.Item[丂丛丑东不丅丈一东].Count);
    }
    internal int 七丛与丅丞丝丁丐专(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 不万丈丟上丙丟万世)
    {
        if((this.三与丄且下丌丑丕丑.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return 0;
        }
        
        if((this.三与丄且下丌丑丕丑.Item[丂丛丑东不丅丈一东].ContainsKey(key:  不万丈丟上丙丟万世)) == false)
        {
                return 0;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = this.三与丄且下丌丑丕丑.Item[丂丛丑东不丅丈一东];
        if(val_4 != null)
        {
                return val_4.Item[不万丈丟上丙丟万世];
        }
        
        return val_4.Item[不万丈丟上丙丟万世];
    }
    internal bool 下丘丙丌万上与丏七(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 下丞七丒业丂丈丘下)
    {
        if((this.丗三丛丛丝与与丈丙.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.List<System.Int32> val_2 = this.丗三丛丛丝与与丈丙.Item[丂丛丑东不丅丈一东];
        if(val_2 != null)
        {
                return val_2.Contains(item:  下丞七丒业丂丈丘下);
        }
        
        return val_2.Contains(item:  下丞七丒业丂丈丘下);
    }
    internal void 丐丑业丑丂东丘与丈(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 下丞七丒业丂丈丘下)
    {
        var val_9;
        if(this.丂一丒万丈不丒一万() == false)
        {
                return;
        }
        
        if((this.下丘丙丌万上与丏七(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 下丞七丒业丂丈丘下:  下丞七丒业丂丈丘下)) == true)
        {
                return;
        }
        
        if((this.丙七万丅万丞下一丕(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东)) == 0)
        {
                return;
        }
        
        if((this.丗三丛丛丝与与丈丙.ContainsKey(key:  丂丛丑东不丅丈一东)) != true)
        {
                this.丗三丛丛丝与与丈丙.Add(key:  丂丛丑东不丅丈一东, value:  new System.Collections.Generic.List<System.Int32>());
        }
        
        this.丗三丛丛丝与与丈丙.Item[丂丛丑东不丅丈一东].Add(item:  下丞七丒业丂丈丘下);
        val_9 = null;
        val_9 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  MapVoteController.丗与丕丛丐丑上丗不, 下下丏一丙不丘丌丞:  this.丈丒丑一丑丕东丗且.ToString());
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  MapVoteController.七七业世丐专一丒与, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丗三丛丛丝与与丈丙));
    }
    private System.Collections.IEnumerator 不丒丛世且丏丄丞丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MapVoteController.世业丙丟世不丂万三();
    }
    private System.Collections.IEnumerator 丗丌业一丟万丑丒丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MapVoteController.三丐丏一丅万丟丕与();
    }
    private void 下丏丛且一上丞丄东()
    {
        var val_6;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_18 = this;
        this.三与丄且下丌丑丕丑.Clear();
        val_19 = null;
        val_19 = null;
        string val_17 = MapVoteController.丒丙丄东丁下东丟丘;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_17));
        if(val_2 == null)
        {
                return;
        }
        
        val_17 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_17.GetEnumerator();
        val_20 = 0;
        val_21 = 0;
        label_39:
        if((546083392 & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_8 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.三与丄且下丌丑丕丑.Add(key:  System.Convert.ToInt32(value:  val_7._value._obj.丐丏七丌丕丗业且上()), value:  null);
        if(val_7._value._obj == 0)
        {
            goto label_39;
        }
        
        if(val_7._value._obj != 0)
        {
                val_22 = null;
        }
        
        if(val_7._value._obj != 0)
        {
                val_22 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        label_27:
        if((546083328 & 1) == 0)
        {
            goto label_23;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_6.GetAwaiter();
        null.Add(key:  System.Int32.Parse(s:  val_13._value._obj.丐丏七丌丕丗业且上()), value:  System.Convert.ToInt32(value:  val_13._value._obj));
        goto label_27;
        label_23:
        val_23 = val_21;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((1 == 1) || (199 != 199))
        {
            goto label_36;
        }
        
        goto label_39;
        label_36:
        if( == 0)
        {
            goto label_39;
        }
        
        goto label_39;
        label_10:
        val_18 = 2;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(199 == 227)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator 专丁丕专丏七三且丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MapVoteController.丅世丒七丗丈丄丘丙();
    }
    private System.Collections.IEnumerator 丐丈丁丘东七世丄且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MapVoteController.丘丌丟与丟丒丅丅且();
    }
    internal System.Collections.Generic.List<SceneInfo> 丄丙丕与三丅丅丈丝(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_3;
        if((this.上世专丆丈上丒丅东.ContainsKey(key:  丂丛丑东不丅丈一东)) != false)
        {
                System.Collections.Generic.List<SceneInfo> val_2 = this.上世专丆丈上丒丅东.Item[丂丛丑东不丅丈一东];
            return (System.Collections.Generic.List<SceneInfo>)val_3;
        }
        
        val_3 = 0;
        return (System.Collections.Generic.List<SceneInfo>)val_3;
    }
    internal bool 丄丗专万不丌丝丟且(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, SceneInfo 东一丁世丑丞业丄丐)
    {
        var val_5;
        var val_6;
        val_5 = this;
        if((this.上世专丆丈上丒丅东.ContainsKey(key:  丂丛丑东不丅丈一东)) == false)
        {
            goto label_5;
        }
        
        System.Collections.Generic.List<SceneInfo> val_2 = this.上世专丆丈上丒丅东.Item[丂丛丑东不丅丈一东];
        val_5 = 0;
        label_9:
        if(val_5 >= val_2.Count)
        {
            goto label_5;
        }
        
        SceneInfo val_4 = val_2.Item[0];
        val_5 = val_5 + 1;
        if(val_4.indexMap != 东一丁世丑丞业丄丐.indexMap)
        {
            goto label_9;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_5:
        val_6 = 0;
        return (bool)val_6;
    }
    internal long 且丝丞丆专丑下专业()
    {
        if(this.丂一丒万丈不丒一万() == false)
        {
                return 0;
        }
        
        return System.Math.Max(val1:  0, val2:  this.三一丁丐专七丙丝与 - FriendsController.丝丗专上三不丄丑丑());
    }
    private void 丞丒上丙丄上丈丏世()
    {
        var val_8;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_34;
        var val_35;
        this.上世专丆丈上丒丅东.Clear();
        val_24 = null;
        val_24 = null;
        string val_23 = MapVoteController.丄一丝七丏丛万丄丟;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_23));
        if(val_2 == null)
        {
                return;
        }
        
        val_25 = 1152921504689381376;
        val_23 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        if((val_23.ContainsKey(key:  "data")) == false)
        {
            goto label_75;
        }
        
        object val_4 = val_23.Item["data"];
        if(val_4 == null)
        {
            goto label_75;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_5 = val_4.GetEnumerator();
        val_26 = 0;
        val_27 = 0;
        label_50:
        if((546931536 & 1) == 0)
        {
            goto label_15;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        System.Collections.Generic.List<SceneInfo> val_10 = new System.Collections.Generic.List<SceneInfo>();
        this.上世专丆丈上丒丅东.Add(key:  System.Convert.ToInt32(value:  val_9._value._obj.丐丏七丌丕丗业且上()), value:  null);
        if(val_9._value._obj == 0)
        {
            goto label_50;
        }
        
        if(val_9._value._obj != 0)
        {
                val_29 = null;
        }
        
        val_28 = ;
        if(val_9._value._obj != 0)
        {
                val_29 = null;
        }
        
        List.Enumerator<T> val_14 = GetEnumerator();
        label_38:
        if((546931488 & 1) == 0)
        {
            goto label_28;
        }
        
        val_30 = null;
        val_30 = null;
        SceneInfo val_17 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Convert.ToInt32(value:  val_8.丐丏七丌丕丗业且上()));
        if(val_17 == 0)
        {
            goto label_38;
        }
        
        null.Add(item:  val_17);
        goto label_38;
        label_28:
        var val_24 = 0;
        val_31 = val_27;
        val_24 = val_24 + 1;
        mem2[0] = 238;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_26 = val_24;
        if((val_26 == 1) || ((1152921530923582176 + ((0 + 1)) << 2) != 238))
        {
            goto label_47;
        }
        
        var val_25 = 0;
        val_25 = val_25 ^ (val_26 >> 31);
        val_26 = val_26 + val_25;
        goto label_50;
        label_47:
        if( == 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_15:
        val_34 = val_26 + 1;
        mem2[0] = 266;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_60;
        }
        
        if(( == 0) || ((1152921530923582176 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) == 266))
        {
            goto label_75;
        }
        
        label_74:
        label_75:
        val_25 = "time";
        if((val_23.ContainsKey(key:  "time")) != false)
        {
                this.三一丁丐专七丙丝与 = System.Convert.ToInt64(value:  val_23.Item["time"]);
        }
        
        if(this.丂一丒万丈不丒一万() == false)
        {
                return;
        }
        
        if(this.三一丁丐专七丙丝与 == this.丈丒丑一丑丕东丗且)
        {
                return;
        }
        
        this.丆丒三丂丂东丆一丏();
        val_35 = null;
        val_35 = null;
        SceneInfoController.丄丘七三上丕世丞业.上丐不丌万上与不且();
        if(this.丅且业丒专专丘世丂 == null)
        {
                return;
        }
        
        this.丅且业丒专专丘世丂.Invoke();
        return;
        label_60:
        if( != 0)
        {
            goto label_74;
        }
        
        goto label_75;
    }
    public MapVoteController()
    {
        this.丈丒丑一丑丕东丗且 = 0;
        this.三一丁丐专七丙丝与 = 0;
    }
    private static MapVoteController()
    {
        MapVoteController.七七业世丐专一丒与 = "MapVotesKey";
        MapVoteController.丗与丕丛丐丑上丗不 = "MapVotesTimeKey";
        MapVoteController.丒丙丄东丁下东丟丘 = "MapVotesServerKey";
        MapVoteController.丄一丝七丏丛万丄丟 = "MapVotesTopServerKey";
    }

}
