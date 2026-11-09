using UnityEngine;
[Serializable]
public class 丛且世丐丆上七业丁.FreeSpin : ISerializationCallbackReceiver
{
    // Fields
    private int _spinsCount;
    public int ChestId;
    private Rilisoft.丝丑丂丛万丐丈丘且 SpinsCountSalted;
    public Rilisoft.丛且世丐丆上七业丁.FreeSpin.七专丁东丘丈丄丐丐 Type;
    
    // Properties
    public int SpinsCount { get; set; }
    
    // Methods
    public int get_SpinsCount()
    {
    
    }
    public void set_SpinsCount(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.SpinsCountSalted = 0;
        mem[1152921542889559344] = 0;
    }
    public void OnBeforeSerialize()
    {
        this._spinsCount = this.SpinsCountSalted;
    }
    public void OnAfterDeserialize()
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.SpinsCountSalted = 0;
        mem[1152921542889783344] = 0;
    }
    public System.Collections.Generic.Dictionary<string, object> 丗丟丝丗丟专且丂业()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "i", value:  this.ChestId);
        val_1.Add(key:  "c", value:  this.SpinsCountSalted);
        val_1.Add(key:  "t", value:  this.Type);
        return val_1;
    }
    public static Rilisoft.丛且世丐丆上七业丁.FreeSpin 丌七丒七丕上丐三七(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "i", 丙业与丙丗丝不丈东: out  (丛且世丐丆上七业丁.FreeSpin)[1152921542890092560].ChestId);
        bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  0);
        int val_6 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        .SpinsCountSalted = 0;
        mem[1152921542890092592] = 0;
        int val_7 = 0;
        bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  val_7);
        .Type = val_7;
        return (FreeSpin)new 丛且世丐丆上七业丁.FreeSpin();
    }
    public static System.Collections.Generic.List<object> 东丈一丙一下丗下与(System.Collections.Generic.List<Rilisoft.丛且世丐丆上七业丁.FreeSpin> 丘丘下丟丙不丂三丘)
    {
        System.Collections.Generic.List<System.Object> val_1 = new System.Collections.Generic.List<System.Object>();
        List.Enumerator<T> val_2 = 丘丘下丟丙不丂三丘.GetEnumerator();
        label_5:
        if(((-371371688) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.Add(item:  0.丐丏七丌丕丗业且上().丗丟丝丗丟专且丂业());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public static System.Collections.Generic.List<Rilisoft.丛且世丐丆上七业丁.FreeSpin> 丅丏下丛世七上丑丏(System.Collections.Generic.List<object> 丐丏三丂丕世七丁丅)
    {
        var val_4;
        var val_8;
        System.Collections.Generic.List<FreeSpin> val_1 = new System.Collections.Generic.List<FreeSpin>();
        List.Enumerator<T> val_2 = 丐丏三丂丕世七丁丅.GetEnumerator();
        label_7:
        if(((-371226928) & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
                val_8 = 0;
        }
        
        val_1.Add(item:  丛且世丐丆上七业丁.FreeSpin.丌七丒七丕上丐三七(丏丂万业丙专丏丒丒:  null));
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public 丛且世丐丆上七业丁.FreeSpin()
    {
    
    }

}
