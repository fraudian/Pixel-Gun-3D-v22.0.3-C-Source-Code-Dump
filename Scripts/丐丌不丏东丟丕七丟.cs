using UnityEngine;
internal class 丐丌不丏东丟丕七丟
{
    // Fields
    private static 丐丌不丏东丟丕七丟 世丒丞七专三与万丕;
    private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 不丙丂丏丏丆专不丈;
    private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 丙丐三丒三七三七丅;
    private readonly System.Collections.Generic.HashSet<string> 与丆丌丙且丏丛丆七;
    private 丆丁丛世丏丂上丙丐 丐万丐丆三丞丏不丛;
    private static System.Action 丛专万丄三不与丛上;
    
    // Properties
    internal static 丐丌不丏东丟丕七丟 丆丕丝丒不丙且丐丗 { get; }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 世上七丙丈丙丅丛丞 { get; }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 丄丟上丛丙万下下丌 { get; }
    
    // Methods
    internal 丐丌不丏东丟丕七丟()
    {
        var val_16;
        System.Action val_17;
        var val_18;
        var val_19;
        System.Action val_20;
        var val_21;
        this.不丙丂丏丏丆专不丈 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
        this.丙丐三丒三七三七丅 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
        this.与丆丌丙且丏丛丆七 = new System.Collections.Generic.HashSet<System.String>();
        this.不丙丂丏丏丆专不丈.Clear();
        this.丙丐三丒三七三七丅.Clear();
        this.丐万丐丆三丞丏不丛 = new 丆丁丛世丏丂上丙丐();
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丐丌不丏东丟丕七丟::下丅东丏与丛与三丌()));
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() != false)
        {
                this.下丅东丏与丛与三丌();
        }
        
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  this, method:  System.Void 丐丌不丏东丟丕七丟::丂丛丏丒世且丒丄业(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.Scene 丛丆东与丑丞丅丝专)));
        val_16 = null;
        val_16 = null;
        val_18 = null;
        val_19 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void 丐丌不丏东丟丕七丟::下丛丕丑丌丕丁专丆()))) != null) && (null != val_19))
        {
                val_18 = null;
            val_19 = null;
            val_17 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_17;
        if(((System.Delegate.Combine(a:  GameConnect.丄丛丐不丒下三丟丂, b:  new System.Action(object:  this, method:  System.Void 丐丌不丏东丟丕七丟::下丛丕丑丌丕丁专丆()))) != null) && (null != null))
        {
                val_20 = 0;
        }
        
        GameConnect.丄丛丐不丒下三丟丂 = val_20;
        val_21 = null;
        val_21 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丆丘与丛不七丘丟, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丐丌不丏东丟丕七丟::丄丒丝丈上七且业丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.七丏丙丁丒且丟丏不, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丐丌不丏东丟丕七丟::丛丒不丘丛丅七丕丅(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal static 丐丌不丏东丟丕七丟 丑七不且上丗丁一世()
    {
        丐丌不丏东丟丕七丟 val_2;
        丐丌不丏东丟丕七丟 val_3 = 丐丌不丏东丟丕七丟.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        丐丌不丏东丟丕七丟 val_1 = null;
        val_2 = val_1;
        val_1 = new 丐丌不丏东丟丕七丟();
        丐丌不丏东丟丕七丟.世丒丞七专三与万丕 = val_2;
        val_3 = 丐丌不丏东丟丕七丟.世丒丞七专三与万丕;
        return val_3;
    }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 丂丅丘丄下丏上丆丆()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>)this.不丙丂丏丏丆专不丈;
    }
    internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 万丄丘与丒丅丒下世()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>)this.丙丐三丒三七三七丅;
    }
    internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  丐丌不丏东丟丕七丟.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丐丌不丏东丟丕七丟.丛专万丄三不与丛上 != 1152921505247051784);
    
    }
    internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  丐丌不丏东丟丕七丟.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丐丌不丏东丟丕七丟.丛专万丄三不与丛上 != 1152921505247051784);
    
    }
    internal void 下丛丕丑丌丕丁专丆()
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) != false)
        {
                System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = this.丐万丐丆三丞丏不丛.三七上丘与七一丏丐();
            if(val_3.Count == 0)
        {
                return;
        }
        
            this.世丞且丆丌业一丘丄(与丂丞丅丂一下丈与:  val_3);
            return;
        }
        
        this.丐万丐丆三丞丏不丛 = new 丆丁丛世丏丂上丙丐();
    }
    internal void 下丘丈丅丗丝丙且丌()
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) != false)
        {
                this.世丞且丆丌业一丘丄(与丂丞丅丂一下丈与:  this.七丞丘万七专丒丁丝());
            return;
        }
        
        this.丐万丐丆三丞丏不丛 = new 丆丁丛世丏丂上丙丐();
    }
    internal System.Collections.Generic.Dictionary<object, object> 七丞丘万七专丒丁丝()
    {
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        且丈丕丑丅丗丄丒业 val_31;
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
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        val_26 = static_value_081D9CF0;
        val_26 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16.丄丙丂丝丄丌丗丂丅()) != 14)
        {
            goto label_7;
        }
        
        label_3:
        val_27 = null;
        val_27 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_28 = null;
            val_28 = null;
            bool val_4 = FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂();
        }
        
        val_29 = null;
        val_29 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_24;
        }
        
        val_30 = null;
        val_30 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
            goto label_24;
        }
        
        val_31 = 0;
        val_32 = 7;
        goto label_74;
        label_24:
        val_33 = null;
        val_33 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_30;
        }
        
        val_34 = null;
        val_34 = null;
        val_31 = 0;
        var val_9 = (Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != true) ? (6 + 1) : 6;
        goto label_74;
        label_7:
        val_35 = null;
        val_35 = null;
        val_36 = null;
        val_31 = GameConnect.丅丕专丗东东丏专世;
        val_36 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_45;
        }
        
        val_37 = null;
        val_37 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == false)
        {
            goto label_45;
        }
        
        val_38 = null;
        val_38 = null;
        if(SquadController.丄丘七三上丕世丞业.IsClanSquad == false)
        {
            goto label_49;
        }
        
        val_32 = 18;
        goto label_74;
        label_30:
        val_31 = 0;
        val_32 = 6;
        goto label_74;
        label_45:
        val_32 = GameConnect.丑丌丛丈丅丅与不业();
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌() == null)
        {
            goto label_74;
        }
        
        val_39 = null;
        val_39 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  GameConnect.丗三丅丞丏七与上七)) == false)
        {
            goto label_74;
        }
        
        val_40 = null;
        val_40 = null;
        var val_23 = ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七])) != true) ? 3 : (val_31);
        goto label_74;
        label_49:
        val_41 = null;
        val_41 = null;
        label_74:
        val_42 = null;
        val_42 = null;
        return 七丞丘万七专丒丁丝(丐丑万与丏丄丒三丄:  val_31, 业万上丆丐丞且丒七:  GameConnect.丒丙丛世丁丐丛三专, 丂丛丑东不丅丈一东:  (SquadController.丄丘七三上丕世丞业.isSquadLeader != true) ? 15 : 6);
    }
    private System.Collections.Generic.Dictionary<object, object> 七丞丘万七专丒丁丝(int 丐丑万与丏丄丒三丄, int 业万上丆丐丞且丒七, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_87;
        int val_88;
        var val_89;
        var val_90;
        string val_91;
        var val_92;
        var val_93;
        string val_94;
        string val_95;
        string val_96;
        var val_97;
        var val_98;
        object val_99;
        object val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        object val_105;
        object val_106;
        var val_107;
        var val_108;
        int val_48 = 0;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        int val_3 = (业万上丆丐丞且丒七 * 100) + (丐丑万与丏丄丒三丄 * 10000);
        val_3 = val_3 + 丂丛丑东不丅丈一东;
        val_3 = val_3 + 100000;
        val_1.set_Item(key:  "game_mode", value:  val_3.ToString(format:  "D6"));
        val_87 = null;
        val_87 = null;
        val_1.set_Item(key:  "version", value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        val_1.set_Item(key:  "app_version_registration", value:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  Rilisoft.丈丁丅丁东业丞业丑.丐丕丏丂不丅世丑丅()));
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业() == null))
        {
            goto label_14;
        }
        
        val_88 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        if(val_1 != null)
        {
            goto label_20;
        }
        
        goto label_19;
        label_14:
        val_88 = System.String.alignConst;
        if(val_1 != null)
        {
            goto label_20;
        }
        
        label_19:
        label_20:
        val_1.set_Item(key:  "room_name", value:  val_88);
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌() == null))
        {
            goto label_34;
        }
        
        val_89 = null;
        val_89 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  GameConnect.七丟丞不丆万上业丆)) == false)
        {
            goto label_34;
        }
        
        val_90 = null;
        val_90 = null;
        val_91 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆];
        goto label_42;
        label_34:
        val_91 = "-1";
        label_42:
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌() == null))
        {
            goto label_56;
        }
        
        val_92 = null;
        val_92 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  GameConnect.丑丕下丑下丏丛丛丙)) == false)
        {
            goto label_56;
        }
        
        val_93 = null;
        val_93 = null;
        val_94 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丑丕下丑下丏丛丛丙];
        val_95 = "0";
        goto label_64;
        label_56:
        val_95 = "0";
        val_94 = val_95;
        label_64:
        if((System.String.op_Equality(a:  val_94, b:  val_95)) != false)
        {
                val_96 = "";
        }
        else
        {
                val_96 = "_" + val_94;
        }
        
        val_1.set_Item(key:  "map", value:  val_91 + val_96);
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌() == null))
        {
            goto label_81;
        }
        
        val_97 = null;
        val_97 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  GameConnect.万与丅且专丕丐丑且)) == false)
        {
            goto label_81;
        }
        
        val_98 = null;
        val_98 = null;
        val_99 = System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且]);
        goto label_90;
        label_81:
        val_99 = 1;
        label_90:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_46 = BattleRoyaleController.丑七不且上丗丁一世();
            val_99 = (val_46.squadMode == true) ? (val_99) : (val_99 + 100);
        }
        
        }
        
        val_1.set_Item(key:  "group", value:  val_99);
        val_100 = 0;
        if((val_48 != 1) && ((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_91, 丙业与丙丗丝不丈东: out  val_48)) != false))
        {
                if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_101 = null;
            val_101 = null;
        }
        
            val_100 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丏专丆丞七东且丕丘(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丛且丞与丕业下丏丞:  10000);
            if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_102 = null;
            val_102 = null;
            val_100 = (GameConnect.丙丙东七丙丞专丛不 == true) ? (val_100) : (val_100 + 100);
        }
        
        }
        
        val_1.set_Item(key:  "mmrank", value:  val_100);
        val_1.set_Item(key:  "protocol", value:  丟丌丁且且世丈丈丟.不丛丁且丘丑上丕七(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东));
        val_1.set_Item(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑().ToString());
        val_103 = null;
        val_103 = null;
        val_1.set_Item(key:  "type_device", value:  (东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false) ? (1 + 1) : 1);
        val_1.set_Item(key:  "tier", value:  ExpController.万上一丝丆且七丅丅());
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丕丕丙丐七丅丑丒万(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东)) != true)
        {
                if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丟东专丅丑一丑丄丂(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东, 丞丁丑丏丄丏七丂不:  10000)) == false)
        {
            goto label_133;
        }
        
        }
        
        val_1.set_Item(key:  "tier_mm", value:  丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东));
        label_133:
        val_104 = null;
        val_104 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_105 = 0;
            int val_67 = ExperienceController.丞丞丘业东丙丏七丌();
        }
        else
        {
                val_105 = 1;
        }
        
        val_1.set_Item(key:  "rank", value:  val_105);
        val_106 = "paying";
        val_1.set_Item(key:  val_106, value:  与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专().ToString());
        if(丂丛丑东不丅丈一东 == 18)
        {
                val_106 = 1152921524404748272;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_1.set_Item(key:  "clan_id", value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.东丏丕丁专丕万丆丑() != 0)
        {
                if(与丂丏丛丞丞丒丟丄.东丏丕丁专丕万丆丑() != 3)
        {
                val_1.set_Item(key:  "cohortName", value:  与丂丏丛丞丞丒丟丄.丏七三万不丘下丆丄());
        }
        
        }
        
        val_107 = null;
        val_107 = null;
        List.Enumerator<T> val_79 = ABTestController.丂丆丝丘丕丁东下丌.GetEnumerator();
        label_173:
        if(((-257643360) & 1) == 0)
        {
            goto label_166;
        }
        
        string val_81 = val_105.丐丏七丌丕丗业且上();
        val_108 = 0;
        if(val_81.与丄丞业不下世丄上() == 1)
        {
            goto label_168;
        }
        
        val_108 = 0;
        if(val_81.与丄丞业不下世丄上() != 2)
        {
            goto label_173;
        }
        
        label_168:
        val_1.set_Item(key:  val_81, value:  val_81.东丌业丕丙丕七丆丁());
        goto label_173;
        label_166:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_1.set_Item(key:  "char_key", value:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丗丕丟丞专丄丂万东());
        return val_1;
    }
    private void 世丞且丆丌业一丘丄(System.Collections.Generic.Dictionary<object, object> 与丂丞丅丂一下丈与)
    {
        var val_3 = null;
        int val_2 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.七丏丙丁丒且丟丏不, 一丐丗丁丞丆丅丟丄:  与丂丞丅丂一下丈与);
        if(val_2 == 1)
        {
                return;
        }
        
        this.丐万丐丆三丞丏不丛.东丛丈不丌下丐丁丄(丟丒业世三与丝丞业:  与丂丞丅丂一下丈与, 丌世世且丟万丗万东:  val_2);
    }
    private void 丛丒不丘丛丅七丕丅(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if(丑与丂丌世丕丆一丗 == null)
        {
                return;
        }
        
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == false)
        {
                return;
        }
        
        this.丐万丐丆三丞丏不丛 = new 丆丁丛世丏丂上丙丐();
    }
    private void 丄丒丝丈上七且业丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        this.丑丒丙丗不一世七丒(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗);
        if(丐丌不丏东丟丕七丟.丛专万丄三不与丛上 == null)
        {
                return;
        }
        
        丐丌不丏东丟丕七丟.丛专万丄三不与丛上.Invoke();
    }
    private void 下丅东丏与丛与三丌()
    {
        this.丐万丐丆三丞丏不丛 = new 丆丁丛世丏丂上丙丐();
        if(MainMenuController.丈一丏一丂丟三且丌() != false)
        {
                this.下丘丈丅丗丝丙且丌();
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                return;
        }
        
        this.丛丗丁万丟丏丘三丏();
    }
    private void 丛丗丁万丟丏丘三丏()
    {
        if(this.与丆丌丙且丏丛丆七.Count == 0)
        {
                return;
        }
        
        this.与丆丌丙且丏丛丆七.Clear();
        this.丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  System.Linq.Enumerable.ToList<System.String>(source:  this.与丆丌丙且丏丛丆七));
    }
    internal void 丑丒丙丗不一世七丒(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_4;
        if(丏丂万业丙专丏丒丒 == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = 丏丂万业丙专丏丒丒.GetEnumerator();
        label_11:
        if(((-256552560) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        string val_6 = val_5._value._obj.丐丏七丌丕丗业且上();
        System.Collections.Generic.Dictionary<System.String, System.String> val_7 = val_5._value._obj.不丕专丗丒丕七丟丙(一丐丗丁丞丆丅丟丄:  val_5._value._obj);
        if(val_7 == null)
        {
            goto label_3;
        }
        
        this.丝丅丌丁丒丟三丏上(丆世丑丌与且且且丗:  val_7, 下上丐丆丝丟丝丒不:  val_6);
        goto label_11;
        label_3:
        bool val_8 = this.不丙丂丏丏丆专不丈.Remove(key:  val_6);
        bool val_9 = this.丙丐三丒三七三七丅.Remove(key:  val_6);
        PGCompany.Clans.世丝丒东且丙一丞一.丘世一丐丌不且一七(丛七丑丈上丄丙丐且:  val_6, 丂三丟丂丈丐丆丗丟:  PixelTime.丝丗专上三不丄丑丑());
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.Generic.Dictionary<string, string> 不丕专丗丒丕七丟丙(object 一丐丗丁丞丆丅丟丄)
    {
        var val_9 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.String>);
        label_13:
        if(((-256403688) & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_6 = 0.GetAwaiter();
        set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToString(value:  val_6._value._obj));
        goto label_13;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.Dictionary<System.String, System.String>);
    }
    private void 丝丅丌丁丒丟三丏上(System.Collections.Generic.Dictionary<string, string> 丆世丑丌与且且且丗, string 下上丐丆丝丟丝丒不)
    {
        string val_32;
        var val_33;
        int val_34;
        string val_35;
        int val_36;
        int val_37;
        bool val_38;
        var val_39;
        string val_40;
        var val_41;
        var val_42;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> val_43;
        string val_44;
        string val_45;
        var val_46;
        val_32 = 下上丐丆丝丟丝丒不;
        val_33 = this;
        if((丆世丑丌与且且且丗.ContainsKey(key:  "game_mode")) == false)
        {
            goto label_2;
        }
        
        val_34 = 丆世丑丌与且且且丗.Item["game_mode"];
        if(丆世丑丌与且且且丗 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_34 = System.String.alignConst;
        if(丆世丑丌与且且且丗 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_35 = "map";
        if((丆世丑丌与且且且丗.ContainsKey(key:  "map")) == false)
        {
            goto label_7;
        }
        
        val_36 = 丆世丑丌与且且且丗.Item["map"];
        if(丆世丑丌与且且且丗 != null)
        {
            goto label_11;
        }
        
        goto label_10;
        label_7:
        val_36 = System.String.alignConst;
        if(丆世丑丌与且且且丗 != null)
        {
            goto label_11;
        }
        
        label_10:
        label_11:
        if((丆世丑丌与且且且丗.ContainsKey(key:  "rank")) != false)
        {
                val_37 = 丆世丑丌与且且且丗.Item["rank"];
        }
        else
        {
                val_37 = System.String.alignConst;
        }
        
        val_38 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_36);
        val_39 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_37);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_34)) == false)
        {
            goto label_17;
        }
        
        int val_10 = System.Int32.Parse(s:  val_34);
        if(0 < 19)
        {
                if((0 & 1) != 0)
        {
            goto label_19;
        }
        
        }
        
        val_40 = "game_mode";
        var val_11 = (0 == 31) ? 1 : 0;
        goto label_20;
        label_17:
        if(val_39 == false)
        {
            goto label_21;
        }
        
        val_42 = 0;
        val_43 = this.丙丐三丒三七三七丅;
        goto label_30;
        label_21:
        val_42 = 0;
        if(val_38 == false)
        {
            goto label_49;
        }
        
        goto label_31;
        label_19:
        val_40 = "game_mode";
        val_41 = 1;
        label_20:
        val_43 = val_33;
        if((this.丙丐三丒三七三七丅.ContainsKey(key:  val_32)) != true)
        {
                null.set_Item(key:  val_32, value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
            val_33 = val_33;
            val_35 = "map";
        }
        
        null.Item[val_32].set_Item(key:  val_40, value:  val_34);
        val_38 = val_38;
        if(val_39 == true)
        {
            goto label_30;
        }
        
        if(val_38 == true)
        {
            goto label_31;
        }
        
        label_49:
        if((((val_41 != 0) ? 1 : 0) & 1) == 0)
        {
            goto label_32;
        }
        
        label_55:
        if((丆世丑丌与且且且丗.ContainsKey(key:  val_35)) == false)
        {
            goto label_41;
        }
        
        char[] val_18 = new char[1];
        val_34 = val_18;
        val_34[0] = '_';
        System.String[] val_19 = 丆世丑丌与且且且丗.Item["map"].Split(separator:  val_18);
        if(val_19.Length == 2)
        {
            goto label_40;
        }
        
        if(val_19.Length != 1)
        {
            goto label_41;
        }
        
        val_44 = "eventMap";
        val_45 = "";
        val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
        goto label_43;
        label_30:
        if((this.丙丐三丒三七三七丅.SyncRoot.ContainsKey(key:  val_32)) != true)
        {
                this.丙丐三丒三七三七丅.SyncRoot.set_Item(key:  val_32, value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
        }
        
        val_39 = this.丙丐三丒三七三七丅.SyncRoot.Item[val_32];
        val_39.set_Item(key:  "rank", value:  val_34);
        if(val_38 == false)
        {
            goto label_49;
        }
        
        label_31:
        if((this.丙丐三丒三七三七丅.ContainsKey(key:  val_32)) != true)
        {
                this.丙丐三丒三七三七丅.set_Item(key:  val_32, value:  new System.Collections.Generic.Dictionary<System.String, System.String>());
        }
        
        val_34 = this.丙丐三丒三七三七丅.Item[val_32];
        val_34.set_Item(key:  "map", value:  val_36);
        if((val_42 & 1) != 0)
        {
            goto label_55;
        }
        
        label_32:
        bool val_26 = this.不丙丂丏丏丆专不丈.Remove(key:  val_32);
        return;
        label_40:
        val_34 = val_19[0];
        if(丆世丑丌与且且且丗 != null)
        {
                丆世丑丌与且且且丗.set_Item(key:  "map", value:  val_34);
        }
        else
        {
                丆世丑丌与且且且丗.set_Item(key:  "map", value:  val_34);
        }
        
        val_45 = val_19[1];
        val_44 = "eventMap";
        val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
        label_43:
        丆世丑丌与且且且丗.set_Item(key:  val_44, value:  val_45);
        label_41:
        if((this.不丙丂丏丏丆专不丈.ContainsKey(key:  val_32)) == false)
        {
            goto label_61;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_28 = 丆世丑丌与且且且丗.GetEnumerator();
        val_39 = 1152921526105915760;
        label_66:
        if(((-256135000) & 1) == 0)
        {
            goto label_63;
        }
        
        ConfiguredValueTaskAwaiter val_29 = 0.GetAwaiter();
        this.不丙丂丏丏丆专不丈.Item[val_32].set_Item(key:  val_29._value._obj.丐丏七丌丕丗业且上(), value:  val_29._value._obj);
        goto label_66;
        label_61:
        this.不丙丂丏丏丆专不丈.set_Item(key:  val_32, value:  丆世丑丌与且且且丗);
        return;
        label_63:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丈且丑万丌专丗世世(System.Collections.Generic.IEnumerable<string> 丅下丏丙丞东丒丕丁)
    {
        object val_15;
        var val_16;
        var val_20;
        var val_22;
        val_16 = this;
        if(丅下丏丙丞东丒丕丁 == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<System.String>(source:  丅下丏丙丞东丒丕丁)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_2 = null;
        val_15 = val_2;
        val_2 = new System.Collections.Generic.List<System.String>();
        var val_18 = 0;
        val_18 = val_18 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = 丅下丏丙丞东丒丕丁.GetEnumerator();
        label_23:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        T val_8 = val_4.Current;
        if(((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_8)) == true) || ((this.与丆丌丙且丏丛丆七.Contains(item:  val_8)) == true))
        {
            goto label_23;
        }
        
        bool val_12 = this.与丆丌丙且丏丛丆七.Add(item:  val_8);
        val_2.Add(item:  val_8);
        goto label_23;
        label_12:
        val_20 = 0;
        val_16 = 0;
        if(val_4 == null)
        {
            
        }
        else
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_4.Dispose();
        }
        
        if(val_2.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_15 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_15.set_Item(key:  "list", value:  val_2);
        val_22 = null;
        val_22 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_17 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丆丘与丛不七丘丟, 一丐丗丁丞丆丅丟丄:  val_15);
    }
    internal void 丅丌丁专专东世丌丕(System.Collections.Generic.List<string> 丅下丏丙丞东丒丕丁)
    {
        var val_9;
        if(丅下丏丙丞东丒丕丁 == null)
        {
                return;
        }
        
        if(丅下丏丙丞东丒丕丁.Count == 0)
        {
                return;
        }
        
        if(丅下丏丙丞东丒丕丁.Count >= 1)
        {
                var val_9 = 0;
            do
        {
            bool val_4 = this.与丆丌丙且丏丛丆七.Remove(item:  丅下丏丙丞东丒丕丁.Item[0]);
            val_9 = val_9 + 1;
        }
        while(val_9 < 丅下丏丙丞东丒丕丁.Count);
        
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_6.set_Item(key:  "list", value:  丅下丏丙丞东丒丕丁);
        val_9 = null;
        val_9 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_8 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丆丘与丛不七丘丟, 一丐丗丁丞丆丅丟丄:  val_6);
    }
    internal void 丝丑丛万丟丝三上世()
    {
        var val_5;
        this.与丆丌丙且丏丛丆七.Clear();
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
        val_2.Add(item:  "-1");
        val_1.set_Item(key:  "list", value:  val_2);
        val_5 = null;
        val_5 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_4 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丆丘与丛不七丘丟, 一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 丂丛丏丒世且丒丄业(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.Scene 丛丆东与丑丞丅丝专)
    {
        this.下丛丕丑丌丕丁专丆();
    }

}
