using UnityEngine;
internal sealed class 丏丌丗丙丑世丝丏丞
{
    // Fields
    private static string 不世丈一丄丞丒丒三;
    private ClanLeaderBunner 丞七业上丏下三专丌;
    
    // Methods
    internal 丏丌丗丙丑世丝丏丞()
    {
        this.丟丕上丕丑丌三丞下();
    }
    private void 丟丕上丕丑丌三丞下()
    {
        var val_8;
        string val_9;
        var val_10;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丌万丑下丁丅丄与, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丏丌丗丙丑世丝丏丞::丗丞丆丙与且丅专上(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        val_9 = "0";
        if(this.丝一世世丁丆丐丞丐() != false)
        {
                val_9 = this.丞七业上丏下三专丌.id;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_5.Add(key:  "clan_id", value:  val_9);
        val_10 = null;
        val_10 = null;
        int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丌万丑下丁丅丄与, 一丐丗丁丞丆丅丟丄:  val_5);
    }
    internal System.ValueTuple<string, UnityEngine.Texture2D> 且丙丙丛丞不丝丆丆()
    {
        UnityEngine.Object val_14;
        string val_15;
        if(this.丞七业上丏下三专丌 != null)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丞七业上丏下三专丌.id)) == false)
        {
            goto label_4;
        }
        
        }
        
        this.丟丕上丕丑丌三丞下();
        label_4:
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null) && (this.丞七业上丏下三专丌 != null))
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丞七业上丏下三专丌.id)) == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        val_14 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "clans_notlogo_icon");
        if(val_14 == 0)
        {
                val_14 = UnityEngine.Texture2D.whiteTexture;
        }
        
        label_28:
        MoonSharp.Interpreter.TablePair val_11 = new MoonSharp.Interpreter.TablePair(key:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9000"), val:  val_14);
        return (System.ValueTuple<System.String, UnityEngine.Texture2D>)val_11.key;
        label_13:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丞七业上丏下三专丌.id)) != false)
        {
            
        }
        else
        {
                val_15 = this.丞七业上丏下三专丌.name;
        }
        
        string val_13 = System.Text.RegularExpressions.Regex.Unescape(str:  mem[this.丞七业上丏下三专丌.name]);
        if(this.丞七业上丏下三专丌 != null)
        {
            goto label_28;
        }
        
        goto label_28;
    }
    private void 丗丞丆丙与且丅专上(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        string val_17;
        ClanLeaderBunner val_18;
        string val_19;
        string val_20;
        string val_21;
        string val_22;
        val_17 = "id";
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "id")) == false)
        {
            goto label_4;
        }
        
        val_18 = 1152921516622706448;
        if(丑与丂丌世丕丆一丗.Item["id"] == null)
        {
            goto label_4;
        }
        
        val_17 = 丑与丂丌世丕丆一丗.Item["id"];
        if((val_17.Equals(value:  this.丞七业上丏下三专丌.id, comparisonType:  5)) == false)
        {
            goto label_9;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_19;
        }
        
        val_19 = "[ClanBunner] id already saved:";
        val_20 = val_17;
        goto label_13;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_19;
        }
        
        val_19 = "[ClanBunner] response from server not have id:";
        val_20 = 0;
        label_13:
        UnityEngine.Debug.Log(message:  val_19 + val_20);
        goto label_19;
        label_9:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[ClanBunner] id:"("[ClanBunner] id:") + val_17);
        }
        
        if(((丑与丂丌世丕丆一丗.ContainsKey(key:  "name")) == false) || (丑与丂丌世丕丆一丗.Item["name"] == null))
        {
            goto label_28;
        }
        
        val_21 = 丑与丂丌世丕丆一丗.Item["name"];
        if(丑与丂丌世丕丆一丗 != null)
        {
            goto label_33;
        }
        
        goto label_32;
        label_28:
        val_21 = 0;
        if(丑与丂丌世丕丆一丗 != null)
        {
            goto label_33;
        }
        
        label_32:
        label_33:
        if(((丑与丂丌世丕丆一丗.ContainsKey(key:  "logo")) != false) && (丑与丂丌世丕丆一丗.Item["logo"] != null))
        {
                val_22 = 丑与丂丌世丕丆一丗.Item["logo"];
        }
        else
        {
                val_22 = 0;
        }
        
        ClanLeaderBunner val_16 = null;
        val_18 = val_16;
        val_16 = new ClanLeaderBunner(丞丅上丏丂且下丅与:  val_17, 丒丘丏上丙丟丑丕丈:  val_21, 丁且专丑万万丘丟七:  val_22);
        this.丞七业上丏下三专丌 = val_18;
        this.三丒丂万丝丒下丌三();
        label_19:
        this.丟万业丘上一丛一丌();
    }
    internal void 三丒丂万丝丒下丌三()
    {
        string val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_10;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三)) != true)
        {
                val_7 = null;
            val_7 = null;
            val_8 = 0;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        if(this.丞七业上丏下三专丌 == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_8 = 0;
        val_5 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丞七业上丏下三专丌);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三, 下下丏一丙不丘丌丞:  val_5);
    }
    internal bool 丝一世世丁丆丐丞丐()
    {
        ClanLeaderBunner val_7;
        var val_8;
        var val_9;
        int val_10;
        var val_11;
        var val_12;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三)) != true)
        {
                val_9 = null;
            val_9 = null;
            val_10 = System.String.alignConst;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三, 下下丏一丙不丘丌丞:  val_10);
        }
        
        val_11 = null;
        val_11 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三))) != false)
        {
                val_7 = this.丞七业上丏下三专丌;
            val_12 = 0;
            mem2[0] = new ClanLeaderBunner();
            return (bool)val_12;
        }
        
        val_10 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_7 = 0;
        val_7 = val_7 + 1;
        this.丞七业上丏下三专丌 = val_10;
        val_10.上一上丆万丏丘丞万();
        val_12 = 1;
        return (bool)val_12;
    }
    private static 丏丌丗丙丑世丝丏丞()
    {
        丏丌丗丙丑世丝丏丞.不世丈一丄丞丒丒三 = "C_W_in_Id";
    }
    private void 丟万业丘上一丛一丌()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丌万丑下丁丅丄与, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丏丌丗丙丑世丝丏丞::丗丞丆丙与且丅专上(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }

}
