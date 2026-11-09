using UnityEngine;
internal class 东丐丅世七不丙丏丆 : PhotonPeer
{
    // Fields
    private readonly System.Collections.Generic.Dictionary<byte, object> 下下东丆丞丙丐丅万;
    
    // Properties
    internal bool 丞丟专下丕丁丏上丆 { get; }
    
    // Methods
    internal bool 七万与一三七且且业()
    {
        return (bool)((this.UsedProtocol & 255) == 5) ? 1 : 0;
    }
    public 东丐丅世七不丙丏丆(ExitGames.Client.Photon.ConnectionProtocol 丐丕东东上丝丂一万)
    {
        this.下下东丆丞丙丐丅万 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
    }
    public 东丐丅世七不丙丏丆(ExitGames.Client.Photon.IPhotonPeerListener 三丙丌七丑丘丂与专, ExitGames.Client.Photon.ConnectionProtocol 丐丕东东上丝丂一万)
    {
        this.Listener = 三丙丌七丑丘丂与专;
    }
    public virtual bool 丕丏丟丒且丏不不丝(string 丗万丟万七专丗下丕)
    {
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        val_1.set_Item(key:  224, value:  丗万丟万七专丗下丕);
        return this.OpCustom(customOpCode:  220, customOpParameters:  val_1, sendReliable:  true, channelId:  0, encrypt:  true);
    }
    public virtual bool 七丘专丂丗丝且丄世(万丑丅丆东三万不丒 丅下丕不丑丁三上丅)
    {
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_8;
        if(true >= 3)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpJoinLobby()");
        }
        
        if(丅下丕不丑丁三上丅 != null)
        {
                val_8 = 0;
            if(丅下丕不丑丁三上丅.上丕东丐东不丅丘且() == true)
        {
                return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_8 = 0, sendReliable:  true);
        }
        
            System.Collections.Generic.Dictionary<System.Byte, System.Object> val_4 = null;
            val_8 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_4.set_Item(key:  213, value:  丅下丕不丑丁三上丅.专丕与丒丗丁丘专丟);
            val_4.set_Item(key:  212, value:  丅下丕不丑丁三上丅.丒三丝一上丙专丗丒);
            return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_8, sendReliable:  true);
        }
        
        return (bool)this.OpCustom(customOpCode:  229, customOpParameters:  val_8, sendReliable:  true);
    }
    public virtual bool 三丛不不七三丟丙丙()
    {
        if(true < 3)
        {
                return this.OpCustom(customOpCode:  228, customOpParameters:  0, sendReliable:  true);
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.Listener.DebugReturn(level:  3, message:  "OpLeaveLobby()");
        return this.OpCustom(customOpCode:  228, customOpParameters:  0, sendReliable:  true);
    }
    private void 丅丅丗丅世上业丁丈(System.Collections.Generic.Dictionary<byte, object> 丌万业且丟三丘丝万, 万丄丆七丏丛丅丑与 丙下丌丝丂专丝万且)
    {
        var val_15;
        System.String[] val_16;
        var val_17;
        System.String[] val_18;
        val_15 = 丙下丌丝丂专丝万且;
        if(val_15 == null)
        {
                万丄丆七丏丛丅丑与 val_1 = null;
            val_15 = val_1;
            val_1 = new 万丄丆七丏丛丅丑与();
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_2.set_Item(key:  253, value:  val_1.业丆丛丁丈丌丘丛丅());
        val_2.set_Item(key:  254, value:  val_1.丛丏不与丆丅业东丗());
        val_16 = (万丄丆七丏丛丅丑与)[1152921535494236800].丘七丅下上丘丏不丐;
        if(val_16 == null)
        {
            goto label_7;
        }
        
        label_31:
        val_2.set_Item(key:  250, value:  val_16);
        万上丈专丐专丞丛丛.丗不三三丁丕七且上(丞下万上三丘上与专:  val_2, 丆丟丏丗下丘丌丛一:  (万丄丆七丏丛丅丑与)[1152921535494236800].三丞不丗丙不丟丒专);
        if((万丄丆七丏丛丅丑与)[1152921535494236800].与世丐下丈丑不东丈 != 0)
        {
                val_16 = (万丄丆七丏丛丅丑与)[1152921535494236800].与世丐下丈丑不东丈;
            val_2.set_Item(key:  255, value:  (万丄丆七丏丛丅丑与)[1152921535494236800].与世丐下丈丑不东丈);
        }
        
        丌万业且丟三丘丝万.set_Item(key:  248, value:  val_2);
        丌万业且丟三丘丝万.set_Item(key:  241, value:  val_1.丅与一一一丟丑丌万());
        val_17 = 1;
        if(val_1.丅与一一一丟丑丌万() != false)
        {
                val_16 = true;
            val_2.set_Item(key:  249, value:  true);
            val_17 = 3;
        }
        
        丌万业且丟三丘丝万.set_Item(key:  232, value:  true);
        if((万丄丆七丏丛丅丑与)[1152921535494236800].丑丐丁丈专丁且不下 <= 0)
        {
                if((万丄丆七丏丛丅丑与)[1152921535494236800].丑丐丁丈专丁且不下 != 1)
        {
            goto label_19;
        }
        
        }
        
        丌万业且丟三丘丝万.set_Item(key:  235, value:  (万丄丆七丏丛丅丑与)[1152921535494236800].丑丐丁丈专丁且不下);
        label_19:
        if((万丄丆七丏丛丅丑与)[1152921535494236800].且不丅且一三丈专丐 >= 1)
        {
                丌万业且丟三丘丝万.set_Item(key:  236, value:  (万丄丆七丏丛丅丑与)[1152921535494236800].且不丅且一三丈专丐);
        }
        
        if(val_1.丂专下一丁丟丑与三() != false)
        {
                val_17 = val_17 | 4;
            丌万业且丟三丘丝万.set_Item(key:  237, value:  true);
        }
        
        val_18 = (万丄丆七丏丛丅丑与)[1152921535494236800].专专七三丁世一丈丘;
        if(val_18 != null)
        {
                丌万业且丟三丘丝万.set_Item(key:  204, value:  val_18);
        }
        
        if(val_1.丆业丝丛丕一东上丈() != false)
        {
                val_17 = val_17 | 8;
            val_18 = true;
            丌万业且丟三丘丝万.set_Item(key:  239, value:  true);
        }
        
        丌万业且丟三丘丝万.set_Item(key:  191, value:  (val_1.专与丞业且丛世七不() != true) ? (val_17 | 16) : (val_17));
        return;
        label_7:
        string[] val_15 = new string[0];
        if(val_2 != null)
        {
            goto label_31;
        }
        
        goto label_31;
    }
    public virtual bool 丂与东丄丙丐不七专(丂东丂下丙丂丑丂丂 丅七上东丏丄与丝丗)
    {
        if(true >= 3)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpCreateRoom()");
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if((System.String.IsNullOrEmpty(value:  丅七上东丏丄与丝丗.丁丅下东丅与丘丂丆)) != true)
        {
                val_3.set_Item(key:  255, value:  丅七上东丏丄与丝丗.丁丅下东丅与丘丂丆);
        }
        
        if(丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒 != null)
        {
                if((System.String.IsNullOrEmpty(value:  丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒.专丕与丒丗丁丘专丟)) != true)
        {
                val_3.set_Item(key:  213, value:  丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒.专丕与丒丗丁丘专丟);
            val_3.set_Item(key:  212, value:  丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒.丒三丝一上丙专丗丒);
        }
        
        }
        
        if((丅七上东丏丄与丝丗.上丕七丄丁且丁下丗 != null) && (丅七上东丏丄与丝丗.上丕七丄丁且丁下丗.Length != 0))
        {
                val_3.set_Item(key:  238, value:  丅七上东丏丄与丝丗.上丕七丄丁且丁下丗);
        }
        
        if(丅七上东丏丄与丝丗.丁专丌丁东丟丗丙专 == false)
        {
                return (bool)this.OpCustom(customOpCode:  227, customOpParameters:  val_3, sendReliable:  true);
        }
        
        if(丅七上东丏丄与丝丗.上丑丁丝上下丘上丐 != null)
        {
                if(丅七上东丏丄与丝丗.上丑丁丝上下丘上丐.Count >= 1)
        {
                val_3.set_Item(key:  249, value:  丅七上东丏丄与丝丗.上丑丁丝上下丘上丐);
            val_3.set_Item(key:  250, value:  true);
        }
        
        }
        
        val_3.丅丅丗丅世上业丁丈(丌万业且丟三丘丝万:  val_3, 丙下丌丝丂专丝万且:  丅七上东丏丄与丝丗.万丄丆七丏丛丅丑与);
        return (bool)this.OpCustom(customOpCode:  227, customOpParameters:  val_3, sendReliable:  true);
    }
    public virtual bool 业丙丕丄丕丑丁丆丕(丂东丂下丙丂丑丂丂 丅七上东丏丄与丝丗)
    {
        var val_9;
        if(true >= 3)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpJoinRoom()");
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if((System.String.IsNullOrEmpty(value:  丅七上东丏丄与丝丗.丁丅下东丅与丘丂丆)) != true)
        {
                val_3.set_Item(key:  255, value:  丅七上东丏丄与丝丗.丁丅下东丅与丘丂丆);
        }
        
        if(丅七上东丏丄与丝丗.东丕专且丈专不丕东 != false)
        {
                val_9 = 1152921504617762816;
            val_3.set_Item(key:  215, value:  1);
            if(丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒 != null)
        {
                val_3.set_Item(key:  213, value:  丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒.专丕与丒丗丁丘专丟);
            val_3.set_Item(key:  212, value:  丅七上东丏丄与丝丗.三东丆丟丙丌丂与丒.丒三丝一上丙专丗丒);
        }
        
        }
        
        if(丅七上东丏丄与丝丗.东丌专与丝不下下业 != false)
        {
                val_3.set_Item(key:  215, value:  3);
        }
        
        if((丅七上东丏丄与丝丗.上丕七丄丁且丁下丗 != null) && (丅七上东丏丄与丝丗.上丕七丄丁且丁下丗.Length != 0))
        {
                val_3.set_Item(key:  238, value:  丅七上东丏丄与丝丗.上丕七丄丁且丁下丗);
        }
        
        if(丅七上东丏丄与丝丗.丁专丌丁东丟丗丙专 == false)
        {
                return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
        }
        
        if(丅七上东丏丄与丝丗.上丑丁丝上下丘上丐 != null)
        {
                if(丅七上东丏丄与丝丗.上丑丁丝上下丘上丐.Count >= 1)
        {
                val_9 = 1152921518958054128;
            val_3.set_Item(key:  249, value:  丅七上东丏丄与丝丗.上丑丁丝上下丘上丐);
            val_3.set_Item(key:  250, value:  true);
        }
        
        }
        
        if(丅七上东丏丄与丝丗.东丕专且丈专不丕东 == false)
        {
                return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
        }
        
        val_3.丅丅丗丅世上业丁丈(丌万业且丟三丘丝万:  val_3, 丙下丌丝丂专丝万且:  丅七上东丏丄与丝丗.万丄丆七丏丛丅丑与);
        return (bool)this.OpCustom(customOpCode:  226, customOpParameters:  val_3, sendReliable:  true);
    }
    public virtual bool 七丙丑丙丕万上丛世(OpJoinRandomRoomParams 业丗丌不丑世丗三世)
    {
        if(true >= 3)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpJoinRandomRoom()");
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        万上丈专丐专丞丛丛.丗不三三丁丕七且上(丞下万上三丘上与专:  val_3, 丆丟丏丗下丘丌丛一:  业丗丌不丑世丗三世.ExpectedCustomRoomProperties);
        if(业丗丌不丑世丗三世.ExpectedMaxPlayers != 0)
        {
                val_3.set_Item(key:  255, value:  业丗丌不丑世丗三世.ExpectedMaxPlayers);
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(val_3.Count >= 1)
        {
                val_4.set_Item(key:  248, value:  val_3);
        }
        
        if(业丗丌不丑世丗三世.MatchingType != 0)
        {
                val_4.set_Item(key:  223, value:  业丗丌不丑世丗三世.MatchingType);
        }
        
        if(业丗丌不丑世丗三世.TypedLobby != null)
        {
                if((System.String.IsNullOrEmpty(value:  业丗丌不丑世丗三世.TypedLobby.专丕与丒丗丁丘专丟)) != true)
        {
                val_4.set_Item(key:  213, value:  业丗丌不丑世丗三世.TypedLobby.专丕与丒丗丁丘专丟);
            val_4.set_Item(key:  212, value:  业丗丌不丑世丗三世.TypedLobby.丒三丝一上丙专丗丒);
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  业丗丌不丑世丗三世.SqlLobbyFilter)) != true)
        {
                val_4.set_Item(key:  245, value:  业丗丌不丑世丗三世.SqlLobbyFilter);
        }
        
        if((业丗丌不丑世丗三世.ExpectedUsers == null) || (业丗丌不丑世丗三世.ExpectedUsers.Length == 0))
        {
                return (bool)this.OpCustom(customOpCode:  225, customOpParameters:  val_4, sendReliable:  true);
        }
        
        val_4.set_Item(key:  238, value:  业丗丌不丑世丗三世.ExpectedUsers);
        return (bool)this.OpCustom(customOpCode:  225, customOpParameters:  val_4, sendReliable:  true);
    }
    public virtual bool 丗丙一上不且丗七丕(bool 一丝且七丙丆丄丌丅)
    {
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_5;
        if(一丝且七丙丆丄丌丅 != false)
        {
                val_5 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_2.set_Item(key:  233, value:  一丝且七丙丆丄丌丅);
            return (bool)val_2.OpCustom(customOpCode:  254, customOpParameters:  val_5 = 0, sendReliable:  true);
        }
        
        return (bool)val_2.OpCustom(customOpCode:  254, customOpParameters:  val_5, sendReliable:  true);
    }
    public virtual bool 业与三七丅丒丗丏世(万丑丅丆东三万不丒 丅下丕不丑丁三上丅, string 一丗一专丞丟丗丛丆)
    {
        object val_8;
        var val_9;
        string val_10;
        var val_13;
        string val_14;
        var val_15;
        var val_17;
        val_8 = 丅下丕不丑丁三上丅;
        val_9 = this;
        if(true >= 3)
        {
                val_10 = "OpGetGameList()";
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.Listener.DebugReturn(level:  3, message:  val_10);
        }
        
        if(val_8 == null)
        {
            goto label_7;
        }
        
        if(丅下丕不丑丁三上丅.丒三丝一上丙专丗丒 != 2)
        {
            goto label_8;
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        val_10 = 丅下丕不丑丁三上丅.专丕与丒丗丁丘专丟;
        val_3.set_Item(key:  213, value:  val_10);
        val_8 = 丅下丕不丑丁三上丅.丒三丝一上丙专丗丒;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_3.set_Item(key:  212, value:  丅下丕不丑丁三上丅.丒三丝一上丙专丗丒);
        goto label_11;
        label_7:
        if((public System.Void ExitGames.Client.Photon.IPhotonPeerListener::DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)) < 3)
        {
            goto label_18;
        }
        
        val_9 = this.Listener;
        val_13 = null;
        val_14 = "OpGetGameList not sent. Lobby cannot be null.";
        var val_9 = 0;
        val_15 = 1152921504975147016;
        val_9 = val_9 + 1;
        goto label_23;
        label_8:
        if(丅下丕不丑丁三上丅.丒三丝一上丙专丗丒 < 3)
        {
            goto label_18;
        }
        
        val_9 = this.Listener;
        val_13 = null;
        val_14 = "OpGetGameList not sent. LobbyType must be SqlLobby.";
        var val_10 = 0;
        val_15 = 1152921504975147016;
        val_10 = val_10 + 1;
        goto label_23;
        label_10:
        val_3.set_Item(key:  212, value:  丅下丕不丑丁三上丅.丒三丝一上丙专丗丒);
        label_11:
        val_3.set_Item(key:  245, value:  一丗一专丞丟丗丛丆);
        val_17 = val_9;
        bool val_6 = this.OpCustom(customOpCode:  217, customOpParameters:  val_3, sendReliable:  true);
        goto label_24;
        label_23:
        val_9.DebugReturn(level:  3, message:  val_14);
        label_18:
        val_17 = 0;
        label_24:
        val_17 = val_17 & 1;
        return (bool)val_17;
    }
    public virtual bool 专丝下一丒丐丂丝丆(string[] 丁丈丈丗与丑丌丄专)
    {
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(丁丈丈丗与丑丌丄专 == null)
        {
                return this.OpCustom(customOpCode:  222, customOpParameters:  val_1, sendReliable:  true);
        }
        
        if(丁丈丈丗与丑丌丄专.Length == 0)
        {
                return this.OpCustom(customOpCode:  222, customOpParameters:  val_1, sendReliable:  true);
        }
        
        val_1.set_Item(key:  1, value:  丁丈丈丗与丑丌丄专);
        return this.OpCustom(customOpCode:  222, customOpParameters:  val_1, sendReliable:  true);
    }
    public bool 丄与丐丐丐丞下专七(int 丙丈三丁世丄丝东世, ExitGames.Client.Photon.Hashtable 世丞丒丒丏丆丁丛业)
    {
        return this.丁一三七丐三三丌丞(丙丈三丁世丄丝东世:  丙丈三丁世丄丝东世, 世丞丒丒丏丆丁丛业:  万上丈专丐专丞丛丛.万丈丏丁上下丁丕业(专丑业丁丗丏丌不丛:  世丞丒丒丏丆丁丛业), 丄七丝丐丟丘业丈丅:  0, 丅丞丏丈且专丆不丟:  false);
    }
    protected internal bool 丁一三七丐三三丌丞(int 丙丈三丁世丄丝东世, ExitGames.Client.Photon.Hashtable 世丞丒丒丏丆丁丛业, ExitGames.Client.Photon.Hashtable 丄七丝丐丟丘业丈丅, bool 丅丞丏丈且专丆不丟 = False)
    {
        int val_8;
        var val_9;
        var val_11;
        val_8 = 丙丈三丁世丄丝东世;
        val_9 = this;
        if(true >= 3)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpSetPropertiesOfActor()");
        }
        
        if((val_8 >= 1) && (世丞丒丒丏丆丁丛业 != null))
        {
                System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
            val_3.Add(key:  251, value:  世丞丒丒丏丆丁丛业);
            val_3.Add(key:  254, value:  val_8);
            val_8 = true;
            val_3.Add(key:  250, value:  true);
            if(丄七丝丐丟丘业丈丅 != null)
        {
                if(丄七丝丐丟丘业丈丅.Count != 0)
        {
                val_3.Add(key:  231, value:  丄七丝丐丟丘业丈丅);
        }
        
        }
        
            if(丅丞丏丈且专丆不丟 != false)
        {
                val_3.set_Item(key:  234, value:  true);
        }
        
            val_11 = val_9;
            bool val_5 = this.OpCustom(customOpCode:  252, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
        }
        else
        {
                if((public System.Void ExitGames.Client.Photon.IPhotonPeerListener::DebugReturn(ExitGames.Client.Photon.DebugLevel level, string message)) >= 3)
        {
                val_9 = this.Listener;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9.DebugReturn(level:  3, message:  "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
        }
        
            val_11 = 0;
        }
        
        val_11 = val_11 & 1;
        return (bool)val_11;
    }
    protected internal void 万丛丁丘不东丈东丈(byte 丞下丕丗丘丐丄丂丝, object 丙业与丙丗丝不丈东)
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_1.set_Item(key:  丞下丕丗丘丐丄丂丝, value:  丙业与丙丗丝不丈东);
        bool val_2 = this.丒丗丘万上丈丌丑丞(丒丙丅世七业丂丞不:  val_1, 丄七丝丐丟丘业丈丅:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public bool 下丟丁业丁下丑丐万(ExitGames.Client.Photon.Hashtable 丒丙丅世七业丂丞不, bool 丙不丆丌一丁丕丒丂, byte 世丞业丏丕一丞下丒)
    {
        return this.丒丗丘万上丈丌丑丞(丒丙丅世七业丂丞不:  万上丈专丐专丞丛丛.万丈丏丁上下丁丕业(专丑业丁丗丏丌不丛:  丒丙丅世七业丂丞不), 丄七丝丐丟丘业丈丅:  0, 丅丞丏丈且专丆不丟:  false);
    }
    protected internal bool 丒丗丘万上丈丌丑丞(ExitGames.Client.Photon.Hashtable 丒丙丅世七业丂丞不, ExitGames.Client.Photon.Hashtable 丄七丝丐丟丘业丈丅, bool 丅丞丏丈且专丆不丟 = False)
    {
        if(true >= 3)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpSetPropertiesOfRoom()");
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        val_3.Add(key:  251, value:  丒丙丅世七业丂丞不);
        val_3.Add(key:  250, value:  true);
        if(丄七丝丐丟丘业丈丅 != null)
        {
                if(丄七丝丐丟丘业丈丅.Count != 0)
        {
                val_3.Add(key:  231, value:  丄七丝丐丟丘业丈丅);
        }
        
        }
        
        if(丅丞丏丈且专丆不丟 == false)
        {
                return (bool)this.OpCustom(customOpCode:  252, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
        }
        
        val_3.set_Item(key:  234, value:  true);
        return (bool)this.OpCustom(customOpCode:  252, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
    }
    public virtual bool 丕世丛丏万丒丘东丘(string 丗万丟万七专丗下丕, string 专丙下丗丄丒三业丂, 七丈丙万丄不丞专三 丝与丏丞不世三丌与, string 上丏万丕丆七不与万, bool 万丂七丕丄与不丅丆)
    {
        object val_30;
        var val_31;
        var val_33;
        var val_34;
        object val_35;
        var val_36;
        var val_37;
        string val_39;
        var val_40;
        val_30 = 万丂七丕丄与不丅丆;
        val_31 = this;
        if(true >= 3)
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            this.Listener.DebugReturn(level:  3, message:  "OpAuthenticate()");
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(val_30 != false)
        {
                val_30 = true;
            val_3.set_Item(key:  211, value:  true);
        }
        
        if(丝与丏丞不世三丌与 != null)
        {
                if(丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂() != null)
        {
                val_3.set_Item(key:  221, value:  丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂());
            val_33 = this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  false);
            return false;
        }
        
        }
        
        if(val_3 != null)
        {
                val_3.set_Item(key:  220, value:  专丙下丗丄丒三业丂);
        }
        else
        {
                val_3.set_Item(key:  220, value:  专丙下丗丄丒三业丂);
        }
        
        val_34 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_3.set_Item(key:  224, value:  丗万丟万七专丗下丕);
        if((System.String.IsNullOrEmpty(value:  上丏万丕丆七不与万)) != true)
        {
                val_34 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            val_3.set_Item(key:  210, value:  上丏万丕丆七不与万);
        }
        
        if(丝与丏丞不世三丌与 == null)
        {
            goto label_27;
        }
        
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丞丈业东专丅丆与七())) != true)
        {
                val_34 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
            val_3.set_Item(key:  225, value:  丝与丏丞不世三丌与.丞丈业东专丅丆与七());
        }
        
        var val_31 = ~丝与丏丞不世三丌与.丝丞丗世丅东万丘且();
        val_31 = val_31 & 255;
        if(val_31 == 0)
        {
            goto label_27;
        }
        
        if((this.UsedProtocol & 255) != 5)
        {
                if(this.IsEncryptionAvailable == false)
        {
            goto label_22;
        }
        
        }
        
        val_3.set_Item(key:  217, value:  丝与丏丞不世三丌与.丝丞丗世丅东万丘且());
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂())) == false)
        {
            goto label_24;
        }
        
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丄万不丁丈丗上业丞())) != true)
        {
                val_3.set_Item(key:  216, value:  丝与丏丞不世三丌与.丄万不丁丈丗上业丞());
        }
        
        if(丝与丏丞不世三丌与.丝丆丒丏丆丄丐丟丒() == null)
        {
            goto label_27;
        }
        
        val_35 = 丝与丏丞不世三丌与.丝丆丒丏丆丄丐丟丒();
        val_36 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_37 = 214;
        goto label_29;
        label_24:
        val_35 = 丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂();
        val_36 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_37 = 221;
        label_29:
        val_3.set_Item(key:  221, value:  val_35);
        label_27:
        val_34 = 1;
        val_33 = 1;
        if((this.OpCustom(customOpCode:  230, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable)) == true)
        {
                return false;
        }
        
        val_31 = this.Listener;
        val_39 = "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you\'re connected.";
        var val_32 = 0;
        val_40 = 1152921504975147016;
        val_32 = val_32 + 1;
        goto label_36;
        label_22:
        val_31 = this.Listener;
        val_39 = "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.";
        var val_33 = 0;
        val_40 = 1152921504975147016;
        val_33 = val_33 + 1;
        label_36:
        val_31.DebugReturn(level:  1, message:  val_39);
        val_33 = 0;
        return false;
    }
    public virtual bool 且丅丙丘丂丄东丅丏(string 丗万丟万七专丗下丕, string 专丙下丗丄丒三业丂, 七丈丙万丄不丞专三 丝与丏丞不世三丌与, string 上丏万丕丆七不与万, EncryptionMode 与丄下丒丐丐业丆丟, ExitGames.Client.Photon.ConnectionProtocol 丒丂丒东丆丁不丁丕)
    {
        object val_26;
        EncryptionMode val_27;
        string val_28;
        var val_30;
        var val_31;
        object val_32;
        var val_33;
        var val_34;
        val_26 = 丒丂丒东丆丁不丁丕;
        val_27 = 与丄下丒丐丐业丆丟;
        if(true >= 3)
        {
                val_28 = "OpAuthenticate()";
            var val_26 = 0;
            val_26 = val_26 + 1;
            this.Listener.DebugReturn(level:  3, message:  val_28);
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(丝与丏丞不世三丌与 != null)
        {
                if(丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂() != null)
        {
                val_3.set_Item(key:  221, value:  丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂());
            val_30 = 0;
            return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
        }
        
        }
        
        if(val_27 == 10)
        {
                if((val_26 & 255) != 0)
        {
                val_31 = static_value_081D9CF0;
            val_31 = static_value_081D9CF0;
            UnityEngine.Debug.LogWarning(message:  "Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: "("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ") + static_value_081D9CF0 + 184 + 32 + 60(static_value_081D9CF0 + 184 + 32 + 60));
            val_26 = 0;
            mem2[0] = 0;
        }
        
        }
        
        val_28 = 1152921518958054128;
        val_3.set_Item(key:  195, value:  val_26);
        val_27 = val_27;
        if(val_3 != null)
        {
                val_3.set_Item(key:  193, value:  val_27);
            val_3.set_Item(key:  220, value:  专丙下丗丄丒三业丂);
        }
        else
        {
                val_3.set_Item(key:  193, value:  val_27);
            val_3.set_Item(key:  220, value:  专丙下丗丄丒三业丂);
        }
        
        val_3.set_Item(key:  224, value:  丗万丟万七专丗下丕);
        if((System.String.IsNullOrEmpty(value:  上丏万丕丆七不与万)) != true)
        {
                val_3.set_Item(key:  210, value:  上丏万丕丆七不与万);
        }
        
        if(丝与丏丞不世三丌与 == null)
        {
            goto label_32;
        }
        
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丞丈业东专丅丆与七())) != true)
        {
                val_3.set_Item(key:  225, value:  丝与丏丞不世三丌与.丞丈业东专丅丆与七());
        }
        
        var val_27 = ~丝与丏丞不世三丌与.丝丞丗世丅东万丘且();
        val_27 = val_27 & 255;
        if(val_27 == 0)
        {
            goto label_32;
        }
        
        val_3.set_Item(key:  217, value:  丝与丏丞不世三丌与.丝丞丗世丅东万丘且());
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂())) == false)
        {
            goto label_29;
        }
        
        if((System.String.IsNullOrEmpty(value:  丝与丏丞不世三丌与.丄万不丁丈丗上业丞())) != true)
        {
                val_3.set_Item(key:  216, value:  丝与丏丞不世三丌与.丄万不丁丈丗上业丞());
        }
        
        if(丝与丏丞不世三丌与.丝丆丒丏丆丄丐丟丒() == null)
        {
            goto label_32;
        }
        
        val_32 = 丝与丏丞不世三丌与.丝丆丒丏丆丄丐丟丒();
        val_33 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_34 = 214;
        goto label_34;
        label_29:
        val_32 = 丝与丏丞不世三丌与.丄丗丅丕上丆丛丆丂();
        val_33 = public System.Void System.Collections.Generic.Dictionary<System.Byte, System.Object>::set_Item(System.Byte key, System.Object value);
        val_34 = 221;
        label_34:
        val_3.set_Item(key:  221, value:  val_32);
        label_32:
        val_30 = this;
        return (bool)this.OpCustom(customOpCode:  231, customOpParameters:  val_3, sendReliable:  true, channelId:  0, encrypt:  this.IsEncryptionAvailable);
    }
    public virtual bool 与东丒丘丁一丟七丗(byte[] 七且业丆三丒丐丞丒, byte[] 丄专三丆七丁丂七万)
    {
        if(true >= 5)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.Listener.DebugReturn(level:  5, message:  "OpChangeGroups()");
        }
        
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Byte, System.Object>();
        if(七且业丆三丒丐丞丒 != null)
        {
                val_3.set_Item(key:  239, value:  七且业丆三丒丐丞丒);
        }
        
        if(丄专三丆七丁丂七万 == null)
        {
                return this.OpCustom(customOpCode:  248, customOpParameters:  val_3, sendReliable:  true, channelId:  0);
        }
        
        val_3.set_Item(key:  238, value:  丄专三丆七丁丂七万);
        return this.OpCustom(customOpCode:  248, customOpParameters:  val_3, sendReliable:  true, channelId:  0);
    }
    public virtual bool 上丏丑上丞世丆丘丐(byte 丏不丅一丈丅万丗一, object 三丏丈三万丟七下与, bool 不三七丈丕丘丐丝与, 丗业三丆丅丐丗不丏 丕一丐丆且丄三丄与)
    {
        丗业三丆丅丐丗不丏 val_4;
        object val_5;
        var val_6;
        val_4 = 丕一丐丆且丄三丄与;
        this.下下东丆丞丙丐丅万.Clear();
        val_5 = 丏不丅一丈丅万丗一;
        this.下下东丆丞丙丐丅万.set_Item(key:  244, value:  丏不丅一丈丅万丗一);
        if(三丏丈三万丟七下与 != null)
        {
                val_5 = this.下下东丆丞丙丐丅万;
            val_5.set_Item(key:  245, value:  三丏丈三万丟七下与);
        }
        
        if(val_4 != null)
        {
                if(丕一丐丆且丄三丄与.三三丞丗专丄不不世 != 0)
        {
                val_5 = 丕一丐丆且丄三丄与.三三丞丗专丄不不世;
            this.下下东丆丞丙丐丅万.set_Item(key:  247, value:  丕一丐丆且丄三丄与.三三丞丗专丄不不世);
        }
        
            if(丕一丐丆且丄三丄与.丟丄丆东业且万上三 != 0)
        {
                val_5 = 丕一丐丆且丄三丄与.丟丄丆东业且万上三;
            this.下下东丆丞丙丐丅万.set_Item(key:  246, value:  丕一丐丆且丄三丄与.丟丄丆东业且万上三);
        }
        
            if(丕一丐丆且丄三丄与.上与丕七丆丙丐三丏 != 0)
        {
                val_5 = 丕一丐丆且丄三丄与.上与丕七丆丙丐三丏;
            this.下下东丆丞丙丐丅万.set_Item(key:  240, value:  丕一丐丆且丄三丄与.上与丕七丆丙丐三丏);
        }
        
            if(丕一丐丆且丄三丄与.丅丆丁专丛世丗丑一 != null)
        {
                val_5 = this.下下东丆丞丙丐丅万;
            val_5.set_Item(key:  252, value:  丕一丐丆且丄三丄与.丅丆丁专丛世丗丑一);
        }
        
            if(丕一丐丆且丄三丄与.与东三丈上专上丌专 == false)
        {
                return (bool)this.OpCustom(customOpCode:  253, customOpParameters:  this.下下东丆丞丙丐丅万, sendReliable:  不三七丈丕丘丐丝与, channelId:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.丞上丛丌丏且七丄丞, encrypt:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.三丙业业世丙丏丝丝);
        }
        
            val_5 = true;
            this.下下东丆丞丙丐丅万.set_Item(key:  234, value:  true);
            return (bool)this.OpCustom(customOpCode:  253, customOpParameters:  this.下下东丆丞丙丐丅万, sendReliable:  不三七丈丕丘丐丝与, channelId:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.丞上丛丌丏且七丄丞, encrypt:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.三丙业业世丙丏丝丝);
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = 丗业三丆丅丐丗不丏.万丝上三丈下丌业与;
        if(val_4 != null)
        {
                return (bool)this.OpCustom(customOpCode:  253, customOpParameters:  this.下下东丆丞丙丐丅万, sendReliable:  不三七丈丕丘丐丝与, channelId:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.丞上丛丌丏且七丄丞, encrypt:  丗业三丆丅丐丗不丏.万丝上三丈下丌业与.三丙业业世丙丏丝丝);
        }
    
    }
    public virtual bool 丟丑一世业业丙丈丑(bool 丌与业万不丂丂与与)
    {
        System.Collections.Generic.Dictionary<System.Byte, System.Object> val_7;
        var val_8;
        if(true >= 5)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.Listener.DebugReturn(level:  5, message:  "OpSettings()");
        }
        
        val_7 = this.下下东丆丞丙丐丅万;
        val_7.Clear();
        if(丌与业万不丂丂与与 != false)
        {
                val_7 = this.下下东丆丞丙丐丅万;
            val_7.set_Item(key:  0, value:  丌与业万不丂丂与与);
        }
        
        if(this.下下东丆丞丙丐丅万.Count != 0)
        {
                val_8 = this;
            bool val_5 = this.OpCustom(customOpCode:  218, customOpParameters:  this.下下东丆丞丙丐丅万, sendReliable:  true);
        }
        else
        {
                val_8 = 1;
        }
        
        val_8 = val_8 & 1;
        return (bool)val_8;
    }

}
