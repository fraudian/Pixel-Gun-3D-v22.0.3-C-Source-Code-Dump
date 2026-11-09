using UnityEngine;
public class 丑丄一丐丁丕世下丕
{
    // Fields
    internal const int 丝下与丐丐与丞丕丞 = 100;
    private System.Collections.Generic.Dictionary<string, object> 一丗丗不丞丟丌丂丘;
    private bool 丁丌丆丛业专丄丗万;
    internal Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东;
    internal int 与丐上丈与丑一丌丏;
    internal bool 丘一丟三三丌丅丁三;
    internal bool 下丛丘万丟世业丞一;
    internal System.Collections.Generic.List<int> 丆丐万丑上丄上丂三;
    
    // Properties
    internal bool 下丅东丟丄且专丌丅 { get; }
    internal bool 东丐世与丘丁下丛丒 { get; }
    
    // Methods
    public 丑丄一丐丁丕世下丕(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, int 与丐上丈与丑一丌丏 = -1, System.Collections.Generic.List<int> 丆丐万丑上丄上丂三)
    {
        System.Collections.Generic.List<System.Int32> val_4 = val_2;
        this.一丗丗不丞丟丌丂丘 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  3);
        val_2 = new System.Object();
        this.丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
        if(与丐上丈与丑一丌丏 != 1)
        {
                this.下丛丘万丟世业丞一 = true;
            this.与丐上丈与丑一丌丏 = 与丐上丈与丑一丌丏;
        }
        
        if(val_4 == null)
        {
                System.Collections.Generic.List<System.Int32> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.List<System.Int32>(capacity:  100);
        }
        
        this.丆丐万丑上丄上丂三 = val_4;
        this.丁丌丆丛业专丄丗万 = true;
    }
    public 丑丄一丐丁丕世下丕(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_31;
        var val_32;
        System.Func<System.Object, System.Int32> val_34;
        var val_35;
        object val_36;
        int val_37;
        this.一丗丗不丞丟丌丂丘 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  3);
        this.丂丛丑东不丅丈一东 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["mode"]);
        object val_4 = 丏丂万业丙专丏丒丒.Item["in"];
        val_31 = 0;
        val_32 = null;
        val_32 = null;
        val_34 = 丑丄一丐丁丕世下丕.<>c.<>9__2_0;
        if(val_34 == null)
        {
                System.Func<System.Object, System.Int32> val_6 = null;
            val_34 = val_6;
            val_6 = new System.Func<System.Object, System.Int32>(object:  丑丄一丐丁丕世下丕.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丑丄一丐丁丕世下丕.<>c::业丏丒丌丌东丕丐业(object 丄三丅七丆丛与与上));
            丑丄一丐丁丕世下丕.<>c.<>9__2_0 = val_34;
        }
        
        this.丆丐万丑上丄上丂三 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  null, selector:  val_6));
        val_35 = "map";
        if((丏丂万业丙专丏丒丒.ContainsKey(key:  "map")) != false)
        {
                this.丘一丟三三丌丅丁三 = true;
        }
        
        val_36 = "mapGroup";
        if((丏丂万业丙专丏丒丒.ContainsKey(key:  "mapGroup")) != false)
        {
                this.下丛丘万丟世业丞一 = true;
            val_36 = 丏丂万业丙专丏丒丒.Item["mapGroup"];
            this.与丐上丈与丑一丌丏 = System.Convert.ToInt32(value:  val_36);
        }
        
        if((this.丘一丟三三丌丅丁三 == true) || (this.下丛丘万丟世业丞一 == true))
        {
            goto label_21;
        }
        
        val_36 = this.丂丛丑东不丅丈一东;
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  val_36)) == false)
        {
            goto label_34;
        }
        
        label_21:
        if((((丏丂万业丙专丏丒丒.ContainsKey(key:  "rank")) == true) || (this.丘一丟三三丌丅丁三 == false)) || ((丏丂万业丙专丏丒丒.ContainsKey(key:  "gr")) == false))
        {
            goto label_34;
        }
        
        int val_31 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["gr"]);
        val_35 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        val_36 = val_35.丙丏三业万丕丕丅业(丂丛丑东不丅丈一东:  this.丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["map"]));
        if(val_36 == null)
        {
            goto label_34;
        }
        
        this.丘一丟三三丌丅丁三 = true;
        this.下丛丘万丟世业丞一 = true;
        val_31 = val_31 + 1;
        this.与丐上丈与丑一丌丏 = val_22.丞丅上丏丂且下丅与;
        val_36 = val_22.丝三业丒万丛丝丁丅.丄专丙丝万丌业丑丘();
        if((val_36.ContainsKey(key:  val_31)) == false)
        {
            goto label_40;
        }
        
        System.Collections.Generic.List<System.Int32[]> val_26 = val_36.Item[val_31];
        val_35 = 1152921535228462144;
        val_36 = 0;
        label_46:
        if(val_36 >= val_26.Count)
        {
            goto label_40;
        }
        
        System.Int32[] val_28 = val_26.Item[0];
        val_37 = val_28.Length;
        if(val_37 == 0)
        {
            goto label_43;
        }
        
        if(val_37 != 1)
        {
            goto label_44;
        }
        
        goto label_45;
        label_43:
        label_44:
        int val_32 = val_28[0];
        val_36 = val_36 + 1;
        if((this.丐专丞丂丟丂丟万丅(万不世丒与丏业丌丆:  100)) >= 0)
        {
            goto label_46;
        }
        
        val_37 = val_28.Length;
        label_45:
        UnityEngine.Debug.LogError(message:  "Migrated rank: "("Migrated rank: ") + val_28[0]);
        label_40:
        this.丆丐万丑上丄上丂三 = new System.Collections.Generic.List<System.Int32>(capacity:  100);
        label_34:
        this.丁丌丆丛业专丄丗万 = true;
    }
    internal System.Collections.Generic.Dictionary<string, object> 丄三丛业丗丝丟丅丗()
    {
        if(this.丁丌丆丛业专丄丗万 == false)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.一丗丗不丞丟丌丂丘;
        }
        
        this.一丗丗不丞丟丌丂丘.Clear();
        this.一丗丗不丞丟丌丂丘.set_Item(key:  "mode", value:  this.丂丛丑东不丅丈一东);
        if(this.下丛丘万丟世业丞一 != false)
        {
                this.一丗丗不丞丟丌丂丘.set_Item(key:  "mapGroup", value:  this.与丐上丈与丑一丌丏);
        }
        
        this.一丗丗不丞丟丌丂丘.set_Item(key:  "in", value:  this.丆丐万丑上丄上丂三);
        this.丁丌丆丛业专丄丗万 = false;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.一丗丗不丞丟丌丂丘;
    }
    internal bool 丅丁丟丏丟上业丐丞()
    {
        return (bool)this.下丛丘万丟世业丞一;
    }
    internal bool 东不丌与且上丒丌丏()
    {
        return (bool)this.丘一丟三三丌丅丁三;
    }
    internal void 与世万丁丂丐丂万丟(丑丄一丐丁丕世下丕.丏丞一丂丕一丌业丛 丁丛丅丌一丌丝丌东)
    {
        this.丁丌丆丛业专丄丗万 = true;
        if(this.丆丐万丑上丄上丂三.Count >= 100)
        {
                this.丆丐万丑上丄上丂三.RemoveAt(index:  0);
        }
        
        this.丆丐万丑上丄上丂三.Add(item:  丁丛丅丌一丌丝丌东);
    }
    internal float 丐专丞丂丟丂丟万丅()
    {
        return this.丐专丞丂丟丂丟万丅(万不世丒与丏业丌丆:  100);
    }
    internal int 与丐丝丒丑丂丆丆丟()
    {
        if(this.丆丐万丑上丄上丂三 != null)
        {
                return this.丆丐万丑上丄上丂三.Count;
        }
        
        return this.丆丐万丑上丄上丂三.Count;
    }
    internal bool 丄丐丅七不丕丙一丘(int 万不世丒与丏业丌丆)
    {
        return (bool)(this.丆丐万丑上丄上丂三.Count >= 万不世丒与丏业丌丆) ? 1 : 0;
    }
    internal void 下与丗七东丒丞丙丘()
    {
        this.丁丌丆丛业专丄丗万 = true;
        this.丆丐万丑上丄上丂三.Clear();
    }
    internal float 丐专丞丂丟丂丟万丅(int 万不世丒与丏业丌丆)
    {
        var val_12;
        float val_13;
        int val_12 = UnityEngine.Mathf.Max(a:  0, b:  this.丆丐万丑上丄上丂三.Count - 万不世丒与丏业丌丆);
        int val_6 = UnityEngine.Mathf.Min(a:  this.丆丐万丑上丄上丂三.Count, b:  val_12 + 万不世丒与丏业丌丆);
        if(val_12 < val_6)
        {
                do
        {
            val_12 = val_12 + 1;
            var val_10 = (this.丆丐万丑上丄上丂三.Item[val_12] == 2) ? (0 + 1) : 0;
        }
        while(val_6 != val_12);
        
            val_13 = (float)(this.丆丐万丑上丄上丂三.Item[val_12] == 1) ? (0 + 1) : 0;
        }
        else
        {
                val_12 = 0;
            val_13 = 0f;
        }
        
        val_13 = val_13 / ((val_12 == 0) ? 1f : 0f);
        return (float)val_13;
    }
    internal void 丒丒丆丅业不下丞丄(int 专世专丟丝丌与丘上)
    {
        if(this.下丛丘万丟世业丞一 != true)
        {
                if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  this.丂丛丑东不丅丈一东)) == false)
        {
                return;
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专且万丁丆且七下丝(上且丗一丏丏万丅丌:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏, 专世专丟丝丌与丘上:  专世专丟丝丌与丘上);
        this.丁丌丆丛业专丄丗万 = true;
        丁一业专丈三丄丘专.与一丅丝不丈业与丙().丒不七东丙丒丞业丛();
    }
    internal int 丑上丒丑丟三上丙丄()
    {
        if(this.丂丛丑东不丅丈一东 == 17)
        {
                return 0;
        }
        
        if(this.丂丛丑东不丅丈一东 == 20)
        {
                return 0;
        }
        
        丐丟丙不丗万三丈丆 val_1 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if((val_1.下业丙丈丝万丂丐东.ContainsKey(key:  this.丂丛丑东不丅丈一东)) != true)
        {
                丐丟丙不丗万三丈丆 val_3 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
            if((val_3.与丈七丕丙三丆上上.ContainsKey(key:  this.丂丛丑东不丅丈一东)) == false)
        {
                return 0;
        }
        
        }
        
        与与丌丑丑丞丗丐丂 val_7 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丘丘七丑丙丈世丌丗(上且丗一丏丏万丅丌:  this.丂丛丑东不丅丈一东).Item[this.丂丛丑东不丅丈一东];
        if(val_7.丂丛丑东不丅丈一东 != null)
        {
                return val_7.丂丛丑东不丅丈一东.业三丕丏不丅七丁三(丈丘丝一丗下丈丐不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂());
        }
        
        return val_7.丂丛丑东不丅丈一东.业三丕丏不丅七丁三(丈丘丝一丗下丈丐不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂());
    }
    internal void 丑世丑丕丈下丄下丞()
    {
        if((Progress.七七世万专丕丁上业.丏丛丅丑丑丁一丁丞().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏)) == false)
        {
                return;
        }
        
        this.丁丌丆丛业专丄丗万 = true;
    }
    internal void 万万丐丟丏丘丞丞丆()
    {
        if((Progress.七七世万专丕丁上业.丏丛丅丑丑丁一丁丞().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏)) != false)
        {
                return;
        }
        
        this.丒丒丆丅业不下丞丄(专世专丟丝丌与丘上:  this.丑上丒丑丟三上丙丄());
    }
    internal int 丏专丆丞七东且丕丘()
    {
        if((Progress.七七世万专丕丁上业.丏丛丅丑丑丁一丁丞().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏)) == false)
        {
                return this.丑上丒丑丟三上丙丄();
        }
        
        Progress.七丗丈三丈业一丆下 val_3 = Progress.七七世万专丕丁上业.丏丛丅丑丑丁一丁丞();
        if(val_3 != null)
        {
                return val_3.东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏);
        }
        
        return val_3.东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  this.丂丛丑东不丅丈一东, 丏丌不丂一丁丆万一:  this.与丐上丈与丑一丌丏);
    }

}
