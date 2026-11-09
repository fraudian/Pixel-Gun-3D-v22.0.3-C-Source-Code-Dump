using UnityEngine;
internal class 世丛丝上丒丈丑东丟
{
    // Fields
    private const string 丛业丐丈三丏丘世丆 = "clan.fort-cells";
    private readonly System.Collections.Generic.List<SquareFieldCellData> 丝一丙丟丐与下丄丟;
    private readonly System.Collections.Generic.List<SquareFieldCellData> 丌业丒丌丏与不丒东;
    
    // Methods
    internal 世丛丝上丒丈丑东丟()
    {
        this.丝一丙丟丐与下丄丟 = new System.Collections.Generic.List<SquareFieldCellData>();
        this.丌业丒丌丏与不丒东 = new System.Collections.Generic.List<SquareFieldCellData>();
    }
    internal void 下丞丏一丁丒丞下丏(string 一丐丗丁丞丆丅丟丄)
    {
        var val_6;
        var val_32;
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_31 = 0;
        val_31 = val_31 + 1;
        System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> val_3 = new System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>();
        List.Enumerator<T> val_4 = val_1.GetEnumerator();
        label_23:
        if((1844902208 & 1) == 0)
        {
            goto label_9;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        PGCompany.三东丏不丗世丅丌丄 val_10 = val_7.ItemSettings.丝丆丂丆不丟丌丕丝().丑丐丙丄丅世世丑丒();
        new PGCompany.一不丆三丛与上上下() = new PGCompany.一不丆三丛与上上下();
        new PGCompany.一不丆三丛与上上下().丗丘万丛与万丘丗下(丙业与丙丗丝不丈东:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
        new PGCompany.一不丆三丛与上上下().东三七丟一不丑东丕(丙业与丙丗丝不丈东:  val_10.业东丅东丌上丗丑不());
        new PGCompany.一不丆三丛与上上下().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_10.丂丁丏一丙丛业且丌());
        new PGCompany.一不丆三丛与上上下().东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  val_7);
        val_3.Add(item:  new PGCompany.一不丆三丛与上上下());
        goto label_23;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_32 = 1152921524404748272;
        List.Enumerator<T> val_17 = val_3.GetEnumerator();
        label_57:
        if((1844902176 & 1) == 0)
        {
            goto label_45;
        }
        
        string val_18 = val_6.丐丏七丌丕丗业且上();
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_18.业东丅东丌上丗丑不());
        new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_18.丂丁丏一丙丛业且丌());
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丌与丏丂东业业上().丁上丟上不丘七不万(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄());
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_18.业东丅东丌上丗丑不());
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丌与丏丂东业业上().丝世世丙业丅丅东三(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄(), 丈丘丝一丗下丈丐不:  val_18.丈一下下丞世三丑丄());
        goto label_57;
        label_45:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝一丙丟丐与下丄丟.Clear();
        this.丝一丙丟丐与下丄丟.AddRange(collection:  val_1);
        this.丂丞丕下丐丕下不丙(丂丗丏丈万业丅丕且:  this.丝一丙丟丐与下丄丟);
    }
    internal void 业丕丘丁丏丗专丕丁()
    {
        this.丝一丙丟丐与下丄丟.Clear();
        string val_2 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "clan.fort-cells", 丞丌丑丛上丕丙丕下:  "[]");
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.丝一丙丟丐与下丄丟.AddRange(collection:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝());
    }
    internal void 上丟与与七丈丛丝丒(System.Collections.Generic.List<SquareFieldCellData> 世丂七与丙与丞丐东, bool 东丕丞世丘丛上世丏 = False)
    {
        System.Collections.Generic.List<SquareFieldCellData> val_1;
        if(东丕丞世丘丛上世丏 != false)
        {
                this.丌业丒丌丏与不丒东.Clear();
            if(世丂七与丙与丞丐东 == null)
        {
                return;
        }
        
            this.丌业丒丌丏与不丒东.AddRange(collection:  世丂七与丙与丞丐东);
            return;
        }
        
        val_1 = this.丝一丙丟丐与下丄丟;
        val_1.Clear();
        if(世丂七与丙与丞丐东 != null)
        {
                val_1 = this.丝一丙丟丐与下丄丟;
            val_1.AddRange(collection:  世丂七与丙与丞丐东);
        }
        
        val_1.丆七丘丌东上丌下丞(一丐丗丁丞丆丅丟丄:  this.丝一丙丟丐与下丄丟);
    }
    private void 丂丞丕下丐丕下不丙(System.Collections.Generic.List<SquareFieldCellData> 丂丗丏丈万业丅丕且)
    {
        System.Collections.Generic.List<SquareFieldCellData> val_24;
        string val_25;
        val_24 = 丂丗丏丈万业丅丕且;
        val_25 = 1152921530862937872;
        if((Rilisoft.Singleton<ClansVisitController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) == true)
        {
                return;
        }
        
        }
        
        }
        
        if(val_24 == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        if(val_24.Count == 0)
        {
                return;
        }
        
        val_25 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((Rilisoft.Singleton<ClansController>.Instance.丞一不下一丁丞东一(丄丒且丙三丆丟与丏:  val_25, 丕万丐东与一丈万与:  0)) == true)
        {
                return;
        }
        
        val_24 = 世丛丝上丒丈丑东丟.与丏专三丈丒丐东丈(丏业丅一丝与世上丘:  val_24);
        if((世丛丝上丒丈丑东丟.丅万丛丒与丒丙丝丒(丐丕丆丟丗丑三丙业:  val_24, 丁丅丞丆丏丂业丁丆:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丌丂专不丁七一丙丗())) != false)
        {
                return;
        }
        
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丌丂专不丁七一丙丗().Clear();
        System.Collections.Generic.List<SquareFieldCellData> val_23 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丌丂专不丁七一丙丗();
        val_23.AddRange(collection:  val_24);
        val_23.七下且上与丄丘不万(一丐丗丁丞丆丅丟丄:  val_24);
        val_23.丆七丘丌东上丌下丞(一丐丗丁丞丆丅丟丄:  val_24);
    }
    internal void 丐专丞一丏丅丐下丆(SquareField 上丘丕与丌且七万丟)
    {
        this.业丐丑丂丞丈与丁丘(上丘丕与丌且七万丟:  上丘丕与丌且七万丟);
        this.丂丞丕下丐丕下不丙(丂丗丏丈万业丅丕且:  this.丝一丙丟丐与下丄丟);
    }
    internal void 业丐丑丂丞丈与丁丘(SquareField 上丘丕与丌且七万丟)
    {
        var val_5;
        this.丝一丙丟丐与下丄丟.Clear();
        if(上丘丕与丌且七万丟 == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = 上丘丕与丌且七万丟.丌丆丘丟丛丝丙丌丘<SquareFieldCell>().GetEnumerator();
        label_16:
        if((1845841184 & 1) == 0)
        {
            goto label_7;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        new SquareFieldCellData() = new SquareFieldCellData();
        UnityEngine.Vector3 val_8 = val_6.丝专与下丗丐东丛丐();
        .Position = val_8;
        mem[1152921536517519780] = val_8.y;
        mem[1152921536517519784] = val_8.z;
        .Rotation = val_6.丘丄丈上与丕三丅丑();
        .CellSize = val_6.专业专专丏丆一万丝();
        .itemSettingsId = X26 + 88;
        .ServerLevel = val_6.Upgrade;
        this.丝一丙丟丐与下丄丟.Add(item:  new SquareFieldCellData());
        goto label_16;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 七下且上与丄丘不万(System.Collections.Generic.List<SquareFieldCellData> 一丐丗丁丞丆丅丟丄)
    {
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丈丌丘三世不丄三丟().一丟丈丘丏丆东丏丙(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 七且丌丘业丒丟不丆:  一丐丗丁丞丆丅丟丄, 上丁丅东与与与丏丒:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上上三七丟丝与丆与());
    }
    private void 丆七丘丌东上丌下丞(System.Collections.Generic.List<SquareFieldCellData> 一丐丗丁丞丆丅丟丄)
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "clan.fort-cells", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄));
    }
    internal string 不丆丗丘丞不上下丅()
    {
        return 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "clan.fort-cells", 丞丌丑丛上丕丙丕下:  "[]");
    }
    internal static string 与丏专三丈丒丐东丈(string 丏业丅一丝与世上丘)
    {
        var val_13;
        var val_15;
        System.Collections.Generic.List<SquareFieldCellData> val_16;
        val_13 = public System.Collections.Generic.List<SquareFieldCellData> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<SquareFieldCellData>>(string 丞丕丒专一下丙业上);
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_15 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof(public System.Collections.Generic.List<SquareFieldCellData> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<SquareFieldCellData>>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
        val_16 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_16.Count == 0)
        {
                return "";
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = 0;
        val_13 = ???;
        return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  世丛丝上丒丈丑东丟.与丏专三丈丒丐东丈(丏业丅一丝与世上丘:  val_16));
    }
    internal static System.Collections.Generic.List<SquareFieldCellData> 与丏专三丈丒丐东丈(System.Collections.Generic.List<SquareFieldCellData> 丏业丅一丝与世上丘)
    {
        var val_9;
        SquareFieldCellData val_10;
        System.Collections.Generic.List<SquareFieldCellData> val_1 = new System.Collections.Generic.List<SquareFieldCellData>();
        if(丏业丅一丝与世上丘.Count == 0)
        {
                return val_1;
        }
        
        val_1.Add(item:  丏业丅一丝与世上丘.Item[0]);
        val_9 = 1;
        goto label_5;
        label_18:
        var val_9 = 0;
        label_14:
        val_10 = 丏业丅一丝与世上丘.Item[1];
        if(val_9 >= val_1.Count)
        {
            goto label_8;
        }
        
        val_10 = val_1.Item[0];
        val_9 = val_9 + 1;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.Position, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_6.Position, y = V11.16B, z = V12.16B})) >= 0)
        {
            goto label_14;
        }
        
        goto label_15;
        label_8:
        val_1.Add(item:  val_10);
        label_15:
        val_9 = 2;
        label_5:
        if(val_9 < 丏业丅一丝与世上丘.Count)
        {
            goto label_18;
        }
        
        return val_1;
    }
    internal void 专丐丝丗丐世上万专(SquareField 上丘丕与丌且七万丟)
    {
        var val_6;
        var val_10;
        System.Collections.Generic.List<SquareFieldCellData> val_11;
        int val_12;
        char val_13;
        var val_16;
        var val_17;
        if(上丘丕与丌且七万丟 == 0)
        {
                return;
        }
        
        上丘丕与丌且七万丟.丏丛不下一丝专丕丙();
        val_11 = this.丝一丙丟丐与下丄丟;
        ClansVisitController val_2 = Rilisoft.Singleton<ClansVisitController>.Instance;
        if(val_2.IsVisitClan != false)
        {
                val_11 = this.丌业丒丌丏与不丒东;
        }
        
        List.Enumerator<T> val_4 = val_11.GetEnumerator();
        label_12:
        if((1846723168 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7 != null)
        {
                val_12 = val_7.m_stringLength;
            val_13 = val_7.m_firstChar;
        }
        else
        {
                val_12 = val_7.m_stringLength;
            val_13 = val_7.m_firstChar;
            val_16 = 64;
        }
        
        上丘丕与丌且七万丟.业东丘丅上丙上专丝(丑丕专万丝七丄丞且:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = V10.16B}, 与丆丆东丌丈丏世丄:  val_2, 七丅丗丆丒丌丑丝不:  64, 业世丟丐丘丐专与不:  val_7.ItemSettings);
        goto label_12;
        label_8:
        val_17 = 0;
        val_10 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_21;
        }
        
        if( == 0)
        {
            goto label_25;
        }
        
        if(115 != 115)
        {
            goto label_23;
        }
        
        goto label_25;
        label_21:
        if( == 0)
        {
            goto label_25;
        }
        
        label_23:
        label_25:
        if(上丘丕与丌且七万丟.丂上世丂下万与丟丁 != false)
        {
                this.业丐丑丂丞丈与丁丘(上丘丕与丌且七万丟:  上丘丕与丌且七万丟);
            this.丂丞丕下丐丕下不丙(丂丗丏丈万业丅丕且:  this.丝一丙丟丐与下丄丟);
        }
        
        上丘丕与丌且七万丟.丈丂丒下不丘丄丄七();
    }
    internal static System.Collections.Generic.List<SquareFieldCellData> 业丌上丄丞东且丕丆(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄)
    {
        var val_4;
        var val_17;
        float val_18;
        float val_19;
        var val_20;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = 0;
        int val_9 = 0;
        int val_12 = 0;
        System.Collections.Generic.List<SquareFieldCellData> val_1 = new System.Collections.Generic.List<SquareFieldCellData>();
        List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
        label_21:
        if((1846897760 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == null)
        {
            goto label_21;
        }
        
        val_17 = 0f;
        val_18 = 0f;
        val_19 = 0f;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  val_6)) != false)
        {
                UnityEngine.Vector3 val_8 = PGCompany.Vector3Extensions.丈下丒东丕丐丐不业.丙不专丒丆丌一丑丞(万丝且丘不丑丝下丑:  val_6);
            val_17 = val_8.x;
            val_18 = val_8.y;
            val_19 = val_8.z;
        }
        
        bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  val_9);
        bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "r", 丙业与丙丗丝不丈东: out  val_9);
        bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "i", 丙业与丙丗丝不丈东: out  val_12);
        if((丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  0)) == null)
        {
            goto label_13;
        }
        
        new SquareFieldCellData() = new SquareFieldCellData();
        .Position = val_8;
        mem[1152921536518576372] = val_18;
        mem[1152921536518576376] = val_19;
        if(new SquareFieldCellData() == null)
        {
            goto label_15;
        }
        
        .CellSize = 0;
        val_20 = 0;
        goto label_16;
        label_13:
        val_4 = val_12;
        UnityEngine.Debug.LogError(message:  "No PlaceableItemSettings with index: "("No PlaceableItemSettings with index: ") + 0);
        goto label_21;
        label_15:
        .CellSize = 0;
        val_20 = 0;
        label_16:
        .Rotation = 0;
        .itemSettingsId = val_14.name;
        val_1.Add(item:  new SquareFieldCellData());
        goto label_21;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal static bool 丅万丛丒与丒丙丝丒(System.Collections.Generic.IEnumerable<SquareFieldCellData> 丐丕丆丟丗丑三丙业, System.Collections.Generic.IEnumerable<SquareFieldCellData> 丁丅丞丆丏丂业丁丆)
    {
        var val_13;
        System.Func<SquareFieldCellData, System.Boolean> val_15;
        var val_16;
        System.Func<SquareFieldCellData, System.Boolean> val_18;
        var val_20;
        System.Func<SquareFieldCellData, System.Boolean> val_22;
        var val_23;
        System.Func<SquareFieldCellData, System.Boolean> val_25;
        val_13 = null;
        val_13 = null;
        val_15 = 世丛丝上丒丈丑东丟.<>c.<>9__17_0;
        if(val_15 == null)
        {
                System.Func<SquareFieldCellData, System.Boolean> val_1 = null;
            val_15 = val_1;
            val_1 = new System.Func<SquareFieldCellData, System.Boolean>(object:  世丛丝上丒丈丑东丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 世丛丝上丒丈丑东丟.<>c::丏万丘丞下专丝丘不(SquareFieldCellData 三丟东丕丄丄下下丑));
            世丛丝上丒丈丑东丟.<>c.<>9__17_0 = val_15;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = 世丛丝上丒丈丑东丟.<>c.<>9__17_1;
        if(val_18 == null)
        {
                System.Func<SquareFieldCellData, System.Boolean> val_3 = null;
            val_18 = val_3;
            val_3 = new System.Func<SquareFieldCellData, System.Boolean>(object:  世丛丝上丒丈丑东丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 世丛丝上丒丈丑东丟.<>c::七东丈丝且东丅七丗(SquareFieldCellData 三丟东丕丄丄下下丑));
            世丛丝上丒丈丑东丟.<>c.<>9__17_1 = val_18;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = 世丛丝上丒丈丑东丟.<>c.<>9__17_2;
        if(val_22 == null)
        {
                System.Func<SquareFieldCellData, System.Boolean> val_6 = null;
            val_22 = val_6;
            val_6 = new System.Func<SquareFieldCellData, System.Boolean>(object:  世丛丝上丒丈丑东丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 世丛丝上丒丈丑东丟.<>c::三丘丄不不丙丄不丁(SquareFieldCellData 三丟东丕丄丄下下丑));
            世丛丝上丒丈丑东丟.<>c.<>9__17_2 = val_22;
        }
        
        val_23 = null;
        val_23 = null;
        val_25 = 世丛丝上丒丈丑东丟.<>c.<>9__17_3;
        if(val_25 == null)
        {
                System.Func<SquareFieldCellData, System.Boolean> val_8 = null;
            val_25 = val_8;
            val_8 = new System.Func<SquareFieldCellData, System.Boolean>(object:  世丛丝上丒丈丑东丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 世丛丝上丒丈丑东丟.<>c::东丄七丂世东不丈丒(SquareFieldCellData 三丟东丕丄丄下下丑));
            世丛丝上丒丈丑东丟.<>c.<>9__17_3 = val_25;
        }
        
        bool val_11 = 丞东丑专丛丆丄丝世.丂丆世世丕丅丕丅上<SquareFieldCellData>(丏丆丑丗七丄丙丝与:  System.Linq.Enumerable.Where<SquareFieldCellData>(source:  丐丕丆丟丗丑三丙业, predicate:  val_6), 丒丈丙丐丏丕丆万丗:  System.Linq.Enumerable.Where<SquareFieldCellData>(source:  丁丅丞丆丏丂业丁丆, predicate:  val_8), 丈丕丛与丏丏不丆七:  new 世丝丛丕下业业丗丛());
        val_11 = (世丛丝上丒丈丑东丟.丁上丞世丐丂丌丕丆(丐丕丆丟丗丑三丙业:  System.Linq.Enumerable.Where<SquareFieldCellData>(source:  丐丕丆丟丗丑三丙业, predicate:  val_1), 丁丅丞丆丏丂业丁丆:  System.Linq.Enumerable.Where<SquareFieldCellData>(source:  丁丅丞丆丏丂业丁丆, predicate:  val_3))) & val_11;
        return (bool)val_11;
    }
    private static bool 丁上丞世丐丂丌丕丆(System.Collections.Generic.IEnumerable<SquareFieldCellData> 丐丕丆丟丗丑三丙业, System.Collections.Generic.IEnumerable<SquareFieldCellData> 丁丅丞丆丏丂业丁丆)
    {
        var val_38;
        int val_39;
        var val_40;
        var val_42;
        var val_45;
        var val_46;
        var val_48;
        var val_52;
        var val_53;
        var val_55;
        var val_56;
        var val_57;
        int val_42 = 0;
        if(丐丕丆丟丗丑三丙业 == null)
        {
            goto label_1;
        }
        
        if(丁丅丞丆丏丂业丁丆 != null)
        {
            goto label_2;
        }
        
        return false;
        label_1:
        if(丁丅丞丆丏丂业丁丆 != null)
        {
                return false;
        }
        
        label_2:
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = null;
        val_39 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        var val_44 = 0;
        val_44 = val_44 + 1;
        System.Collections.Generic.IEnumerator<T> val_3 = 丐丕丆丟丗丑三丙业.GetEnumerator();
        val_42 = 1152921524297562704;
        label_33:
        var val_45 = 0;
        val_45 = val_45 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_15;
        }
        
        var val_46 = 0;
        val_46 = val_46 + 1;
        T val_7 = val_3.Current;
        if((val_1.ContainsKey(key:  val_7.ItemSettings.Index)) == false)
        {
            goto label_24;
        }
        
        int val_12 = val_7.ItemSettings.Index;
        val_1.set_Item(key:  val_12, value:  val_1.Item[val_12] + 1);
        goto label_33;
        label_24:
        val_1.set_Item(key:  val_7.ItemSettings.Index, value:  0);
        goto label_33;
        label_15:
        val_45 = 0;
        val_46 = 0;
        if(val_3 != null)
        {
                var val_47 = 0;
            val_47 = val_47 + 1;
            val_3.Dispose();
        }
        
        if(( != 1) && (130 == 130))
        {
                val_48 = 1152921504689381376;
            val_45 = 0;
        }
        else
        {
                val_48 = 1152921504689381376;
            if( != false)
        {
                val_46 = 0;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_18 = null;
        val_40 = val_18;
        val_18 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        var val_48 = 0;
        val_48 = val_48 + 1;
        System.Collections.Generic.IEnumerator<T> val_20 = 丁丅丞丆丏丂业丁丆.GetEnumerator();
        label_84:
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_20.MoveNext() == false)
        {
            goto label_66;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        T val_24 = val_20.Current;
        if((val_18.ContainsKey(key:  val_24.ItemSettings.Index)) == false)
        {
            goto label_75;
        }
        
        int val_29 = val_24.ItemSettings.Index;
        val_18.set_Item(key:  val_29, value:  val_18.Item[val_29] + 1);
        goto label_84;
        label_75:
        val_18.set_Item(key:  val_24.ItemSettings.Index, value:  0);
        goto label_84;
        label_66:
        val_52 = 1847298976;
        val_53 = 1;
        if(val_20 == null)
        {
            
        }
        else
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_20.Dispose();
        }
        
        if((val_53 == 1) || (250 != 250))
        {
            goto label_105;
        }
        
        var val_52 = 0;
        val_52 = val_52 ^ 0;
        val_53 = val_53 + val_52;
        if(val_39 != null)
        {
            goto label_109;
        }
        
        goto label_107;
        label_105:
        if( != false)
        {
                val_46 = 0;
        }
        
        if(val_39 != null)
        {
            goto label_109;
        }
        
        label_107:
        label_109:
        val_55 = 1152921525753940704;
        if(val_1.Count != val_18.Count)
        {
                return false;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_37 = val_1.GetEnumerator();
        val_55 = 1152921525508387872;
        val_42 = 1152921525508397088;
        label_116:
        if((1847299072 & 1) != 0)
        {
                val_39 = val_38.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂();
            if((val_18.TryGetValue(key:  val_39, value: out  val_42)) != false)
        {
                if(1847299064 == val_42)
        {
            goto label_116;
        }
        
        }
        
            val_56 = val_53 + 1;
            val_57 = 350;
        }
        else
        {
                val_56 = val_53 + 1;
            val_57 = 348;
        }
        
        mem2[0] = 348;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_56 == 1)
        {
            goto label_122;
        }
        
        if((val_52 + ((val_53 + 1)) << 2) != 350)
        {
            goto label_123;
        }
        
        return false;
        label_122:
        if( != 0)
        {
                return false;
        }
        
        return false;
        label_123:
        if( == 0)
        {
                return false;
        }
        
        if((val_52 + ((val_53 + 1)) << 2) == 348)
        {
                return false;
        }
        
        return false;
    }

}
