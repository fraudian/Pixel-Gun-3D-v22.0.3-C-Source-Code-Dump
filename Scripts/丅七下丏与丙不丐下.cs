using UnityEngine;
internal class 丅七下丏与丙不丐下
{
    // Fields
    internal const string 丞不丁丙丒丈丄三东 = "LOOT_BOX_REWARD_HISTORY";
    private static System.Collections.Generic.Dictionary<string, Progress.与丄东丄丘丐丙丅业> 不与丆丛丒且七丒世;
    private 丅七下丏与丙不丐下.丒丛丏丂业丐丏丗丑 丏丐丑丕丌专丐下下;
    private string 丅丘丄东丅丗世丗业;
    private int 丅且世丆丄丅丕丙业;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丟丈丙丟丅丟丑七;
    private System.Collections.Generic.List<丅七下丏与丙不丐下.丕业业丟专丒丛丕不> 丑与丏专丂丗丅丟丐;
    
    // Properties
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 三东丏不丗世丅丌丄 { get; }
    private System.Collections.Generic.List<丅七下丏与丙不丐下.丕业业丟专丒丛丕不> 三专丒丞丑丁丗丛丝 { get; }
    
    // Methods
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丝上三丌丙七三七丏()
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3;
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_4;
        val_3 = this.丕丟丈丙丟丅丟丑七;
        if(val_3 != null)
        {
                return val_2;
        }
        
        val_4 = this.丑与丏专丂丗丅丟丐;
        if(val_4 == null)
        {
                System.Collections.Generic.List<丕业业丟专丒丛丕不> val_1 = this.丄一丙丅丕不三丁丕();
            val_4 = val_1;
            this.丑与丏专丂丗丅丟丐 = val_4;
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = val_1.丘丏世业丕东七丁丘(丄丄丆不丂丗丛丙专:  val_4);
        this.丕丟丈丙丟丅丟丑七 = val_2;
        return val_2;
    }
    private System.Collections.Generic.List<丅七下丏与丙不丐下.丕业业丟专丒丛丕不> 不丂且东丐丙三丐丞()
    {
        if(this.丑与丏专丂丗丅丟丐 != null)
        {
                return val_1;
        }
        
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_1 = this.丄一丙丅丕不三丁丕();
        this.丑与丏专丂丗丅丟丐 = val_1;
        return val_1;
    }
    internal 丅七下丏与丙不丐下(丅七下丏与丙不丐下.丒丛丏丂业丐丏丗丑 丐三业丘不丘丟三丅, string 专丅下与三丗丝丆丙, int 一下丒丞丑丞七丙且)
    {
        val_1 = new System.Object();
        this.丏丐丑丕丌专丐下下 = 丐三业丘不丘丟三丅;
        this.丅丘丄东丅丗世丗业 = val_1;
        this.丅且世丆丄丅丕丙业 = 一下丒丞丑丞七丙且;
    }
    internal int 三丆万丁丕丄不丏业()
    {
        if(this.丑与丏专丂丗丅丟丐 != null)
        {
                return 0.Count;
        }
        
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_1 = this.丄一丙丅丕不三丁丕();
        this.丑与丏专丂丗丅丟丐 = val_1;
        if(val_1 != null)
        {
                return 0.Count;
        }
        
        return 0.Count;
    }
    internal bool 丘七丙丅丄丆丅七一()
    {
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_4 = this.丑与丏专丂丗丅丟丐;
        if(val_4 != null)
        {
                return (bool)(val_4.Count == this.丅且世丆丄丅丕丙业) ? 1 : 0;
        }
        
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_1 = this.丄一丙丅丕不三丁丕();
        this.丑与丏专丂丗丅丟丐 = val_1;
        if(val_1 != null)
        {
                return (bool)(val_4.Count == this.丅且世丆丄丅丕丙业) ? 1 : 0;
        }
        
        val_4 = 0;
        return (bool)(val_4.Count == this.丅且世丆丄丅丕丙业) ? 1 : 0;
    }
    internal void 丁且丒丙丛一丅东世(System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 东且丟万专丌丌丝丒)
    {
        var val_7;
        var val_8;
        if(东且丟万专丌丌丝丒.Count == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = 东且丟万专丌丌丝丒.GetEnumerator();
        val_7 = 0;
        goto label_4;
        label_7:
        if((val_7 & 1) != 0)
        {
                val_8 = 1;
        }
        else
        {
                val_8 = this.丁且丒丙丛一丅东世(丄丄丆不丂丗丛丙专:  0.丐丏七丌丕丗业且上(), 业丟丏丈丄丙万一下:  false);
        }
        
        label_4:
        if(((-756417944) & 1) != 0)
        {
            goto label_7;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((((val_8 == true) ? 1 : 0) & 1) == 0)
        {
                return;
        }
        
        this.七丑一丑一丗丐丕丂();
    }
    internal bool 丁且丒丙丛一丅东世(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丆丌丙丛丄丂丘丟丟, bool 业丟丏丈丄丙万一下 = True)
    {
        int val_4;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "-----------history-----------");
        List.Enumerator<T> val_2 = 丆丌丙丛丄丂丘丟丟.GetEnumerator();
        label_8:
        if(((-756264912) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        val_1.Add(item:  val_5.m_stringLength);
        val_4 = val_5.m_stringLength.丂丁丏一丙丛业且丌();
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_5.m_stringLength), arg1:  val_4));
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)this.丁且丒丙丛一丅东世(丄丄丆不丂丗丛丙专:  val_1, 业丟丏丈丄丙万一下:  true);
    }
    internal bool 丁且丒丙丛一丅东世(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丄丆不丂丗丛丙专, bool 业丟丏丈丄丙万一下 = True)
    {
        System.Collections.Generic.IEnumerable<T> val_14;
        var val_15;
        System.Collections.Generic.List<丕业业丟专丒丛丕不> val_16;
        var val_17;
        val_14 = 丄丄丆不丂丗丛丙专;
        val_15 = val_14;
        if(val_15.Count == 0)
        {
                return (bool)val_15;
        }
        
        val_16 = this.丑与丏专丂丗丅丟丐;
        if(val_16 == null)
        {
                System.Collections.Generic.List<丕业业丟专丒丛丕不> val_2 = this.丄一丙丅丕不三丁丕();
            this.丑与丏专丂丗丅丟丐 = val_2;
            if(val_2 == null)
        {
                val_16 = 0;
        }
        
        }
        
        if(val_16.Count != this.丅且世丆丄丅丕丙业)
        {
            goto label_5;
        }
        
        val_17 = 0;
        goto label_6;
        label_12:
        this.丝上三丌丙七三七丏().RemoveAt(index:  0);
        val_17 = 1;
        label_6:
        if(this.丑与丏专丂丗丅丟丐 == null)
        {
                this.丑与丏专丂丗丅丟丐 = this.丄一丙丅丕不三丁丕();
        }
        
        丕业业丟专丒丛丕不 val_6 = 0.Item[0];
        if(val_17 < val_6.ItemParameters.Count)
        {
            goto label_12;
        }
        
        if(this.丑与丏专丂丗丅丟丐 == null)
        {
                this.丑与丏专丂丗丅丟丐 = this.丄一丙丅丕不三丁丕();
        }
        
        0.RemoveAt(index:  0);
        label_5:
        this.丝上三丌丙七三七丏().AddRange(collection:  val_14);
        List.Enumerator<T> val_11 = val_14.GetEnumerator();
        label_20:
        if(((-756054584) & 1) == 0)
        {
            goto label_17;
        }
        
        (丅七下丏与丙不丐下.丕业业丟专丒丛丕不)[1152921538210619920].ItemParameters.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_20;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丑与丏专丂丗丅丟丐 == null)
        {
                this.丑与丏专丂丗丅丟丐 = this.丄一丙丅丕不三丁丕();
        }
        
        0.Add(item:  new 丅七下丏与丙不丐下.丕业业丟专丒丛丕不());
        if(业丟丏丈丄丙万一下 != false)
        {
                this.七丑一丑一丗丐丕丂();
        }
        
        val_15 = 1;
        return (bool)val_15;
    }
    internal void 丕丌且丄丘一万专丒()
    {
        this.丝上三丌丙七三七丏().Clear();
        if(this.丑与丏专丂丗丅丟丐 == null)
        {
                this.丑与丏专丂丗丅丟丐 = this.丄一丙丅丕不三丁丕();
        }
        
        0.Clear();
        this.七丑一丑一丗丐丕丂();
    }
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丘丏世业丕东七丁丘(System.Collections.Generic.List<丅七下丏与丙不丐下.丕业业丟专丒丛丕不> 丄丄丆不丂丗丛丙专)
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_2 = 丄丄丆不丂丗丛丙专.GetEnumerator();
        label_5:
        if(((-755722024) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        val_1.AddRange(collection:  val_3.m_stringLength);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private System.Collections.Generic.List<丅七下丏与丙不丐下.丕业业丟专丒丛丕不> 丄一丙丅丕不三丁丕()
    {
        if((System.String.IsNullOrEmpty(value:  this.业业丟丞世丐万丐丏())) != false)
        {
                return (System.Collections.Generic.List<丕业业丟专丒丛丕不>)new System.Collections.Generic.List<丕业业丟专丒丛丕不>();
        }
        
        DataSystem.丈且丈上不下且丝丒 val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_6 = 0;
        val_6 = val_6 + 1;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_4, typeof(public System.Collections.Generic.List<丕业业丟专丒丛丕不> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<丕业业丟专丒丛丕不>>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
    }
    private void 七丑一丑一丗丐丕丂()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.丁丁丐丒丙东丛丂丂(丌且专不丙丕专丅万:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丑与丏专丂丗丅丟丐));
    }
    private void 丁丁丐丒丙东丛丂丂(string 丌且专不丙丕专丅万)
    {
        if(this.丏丐丑丕丌专丐下下 == 2)
        {
            goto label_1;
        }
        
        if(this.丏丐丑丕丌专丐下下 != 1)
        {
            goto label_2;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  this.丅丘丄东丅丗世丗业, arg1:  FriendsController.不丝丕丒丂丆丘丙丙()), 下下丏一丙不丘丌丞:  丌且专不丙丕专丅万);
        return;
        label_1:
        this.丝三不上丙丛丞一丑(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
        return;
        label_2:
        object[] val_3 = new object[1];
        val_3[0] = this.丏丐丑丕丌专丐下下;
        UnityEngine.Debug.LogErrorFormat(format:  "Not have realization for _typeStorage: {0} !!", args:  val_3);
    }
    private string 业业丟丞世丐万丐丏()
    {
        if(this.丏丐丑丕丌专丐下下 == 2)
        {
                return this.丑丆丁丗与丙与东丙();
        }
        
        if(this.丏丐丑丕丌专丐下下 == 1)
        {
                return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  this.丅丘丄东丅丗世丗业, arg1:  FriendsController.不丝丕丒丂丆丘丙丙()));
        }
        
        object[] val_3 = new object[1];
        val_3[0] = this.丏丐丑丕丌专丐下下;
        UnityEngine.Debug.LogErrorFormat(format:  "Not have realization for _typeStorage: {0} !!", args:  val_3);
        return "";
    }
    private void 丝三不上丙丛丞一丑(string 丌且专不丙丕专丅万)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if((丅七下丏与丙不丐下.不与丆丛丒且七丒世.ContainsKey(key:  this.丅丘丄东丅丗世丗业)) != false)
        {
                val_6 = null;
            val_6 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  丅七下丏与丙不丐下.不与丆丛丒且七丒世.Item[this.丅丘丄东丅丗世丗业], 丙业与丙丗丝不丈东:  丌且专不丙丕专丅万);
            return;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = this.丏丐丑丕丌专丐下下;
        UnityEngine.Debug.LogErrorFormat(format:  "Key: {0} not contains in _configUtilityKeys!!", args:  val_4);
    }
    private string 丑丆丁丗与丙与东丙()
    {
        var val_6;
        string val_7;
        var val_8;
        object val_9;
        val_6 = null;
        val_6 = null;
        val_7 = this.丅丘丄东丅丗世丗业;
        if((丅七下丏与丙不丐下.不与丆丛丒且七丒世.ContainsKey(key:  val_7)) != false)
        {
                val_8 = null;
            val_8 = null;
            val_7 = 丅七下丏与丙不丐下.不与丆丛丒且七丒世;
            val_9 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  val_7.Item[this.丅丘丄东丅丗世丗业]);
            if(val_9 == null)
        {
                return "";
        }
        
            return System.Convert.ToString(value:  val_9);
        }
        
        object[] val_5 = new object[1];
        val_9 = this.丏丐丑丕丌专丐下下;
        val_5[0] = val_9;
        UnityEngine.Debug.LogErrorFormat(format:  "Key: {0} not contains in _configUtilityKeys!!", args:  val_5);
        return "";
    }
    private static 丅七下丏与丙不丐下()
    {
        System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业> val_1 = new System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业>();
        val_1.Add(key:  "LOOT_BOX_REWARD_HISTORY", value:  90);
        丅七下丏与丙不丐下.不与丆丛丒且七丒世 = val_1;
    }

}
