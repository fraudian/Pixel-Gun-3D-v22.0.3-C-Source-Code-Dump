using UnityEngine;
internal class 丏不一丏丗丗丗丈丞
{
    // Fields
    internal readonly int id;
    internal readonly System.Collections.Generic.Dictionary<string, object> HeaderPreview;
    internal readonly System.Collections.Generic.Dictionary<string, object> Header;
    internal readonly 下丙丟上丂与东丂专 TypeNews;
    internal readonly System.Collections.Generic.Dictionary<string, object> ShortDescription;
    internal readonly System.Collections.Generic.Dictionary<string, object> Message;
    internal readonly long Date;
    internal readonly string toId;
    internal readonly bool 丂丄万业丝丆丐丆丂;
    private readonly System.Collections.Generic.List<Rilisoft.OfferItem> _items;
    internal bool isReaded;
    internal readonly int lastChangedTime;
    internal readonly Rilisoft.丝丑丂丛万丐丈丘且 idReward;
    internal readonly string FullPicture;
    internal readonly string SquareFullPicture;
    internal readonly string subscribedUrl;
    internal readonly string urlLink;
    internal readonly bool isYoutube;
    internal readonly bool isBigRewardMessage;
    internal string TextButtonReward;
    internal bool 丂东下丌丐丟丏不丕;
    
    // Properties
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丝丈不丗丐不丙丟丁 { get; }
    internal bool 世丝且万丑丟丛丟丟 { get; }
    internal bool 丑丐丐丏不丘丕一三 { get; }
    internal bool 丑丂下丗下一下下丏 { get; }
    internal bool 丆丅专丆不丌东与丛 { get; }
    
    // Methods
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丑丒丏三丆丗专丞丗()
    {
        return (System.Collections.Generic.List<Rilisoft.OfferItem>)this._items;
    }
    internal bool 七下业丈业丙丆上丌()
    {
        return (bool)(this.TypeNews == 1) ? 1 : 0;
    }
    internal bool 丙丄与世丁丛丞业不()
    {
        System.Collections.Generic.List<Rilisoft.OfferItem> val_2 = this._items;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        if(val_2.Count >= 1)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    internal bool 丝丆丆丗丞丒丒丝业()
    {
        var val_4;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_5;
        val_4 = this;
        val_5 = this._items;
        if(val_5 == null)
        {
                return (bool)丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  -678951312);
        }
        
        if(val_5.Count == 1)
        {
                if(this.TypeNews != 1)
        {
            goto label_3;
        }
        
        }
        
        val_5 = 0;
        return (bool)丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  -678951312);
        label_3:
        val_4 = ;
        val_5 = val_4;
        return (bool)丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  -678951312);
    }
    internal bool 三丐丑丛业丅东丕东()
    {
        var val_3;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_4;
        val_3 = this;
        val_4 = this._items;
        if(val_4 != null)
        {
                if((val_4.Count >= 1) && (this.TypeNews == 1))
        {
                val_3 = ;
            val_4 = val_3;
            bool val_2 = 丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  -678822928);
        }
        else
        {
                val_4 = 0;
        }
        
        }
        
        val_4 = val_4 & 1;
        return (bool)val_4;
    }
    internal 丏不一丏丗丗丗丈丞(object 丄丙下丝丛丒七丂丘, int 丏三丐丙与丝丁丄丑)
    {
        int val_73;
        var val_74;
        var val_76;
        var val_77;
        int val_78;
        var val_79;
        var val_80;
        string val_81;
        string val_82;
        var val_83;
        val_73 = 丏三丐丙与丝丁丄丑;
        object val_52 = 0;
        this.id = 0;
        this.toId = System.String.alignConst;
        this._items = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.idReward = val_2;
        mem[1152921538288024112] = val_2.上万三丆专丏丒丗业;
        this.FullPicture = System.String.alignConst;
        this.SquareFullPicture = System.String.alignConst;
        this.subscribedUrl = System.String.alignConst;
        this.urlLink = System.String.alignConst;
        this.TextButtonReward = System.String.alignConst;
        if(丄丙下丝丛丒七丂丘 == null)
        {
                return;
        }
        
        val_74 = 1152921504689381376;
        System.Collections.Generic.IDictionary<System.String, System.Object> val_3 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丄丙下丝丛丒七丂丘 : 0;
        this.id = val_73;
        if((val_3.ContainsKey(key:  "toId")) == false)
        {
            goto label_5;
        }
        
        object val_5 = val_3.Item["toId"];
        if(val_5 == null)
        {
            goto label_8;
        }
        
        var val_6 = (null == null) ? (val_5) : 0;
        goto label_8;
        label_5:
        label_8:
        this.toId = FriendsController.不丝丕丒丂丆丘丙丙();
        if((val_3.ContainsKey(key:  "short_header")) != false)
        {
                object val_9 = val_3.Item["short_header"];
            val_76 = 0;
            this.HeaderPreview = ;
        }
        
        if((val_3.ContainsKey(key:  "r_message")) != false)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_3.Item["r_message"]);
            this.isBigRewardMessage = null;
        }
        
        if((val_3.ContainsKey(key:  "ctime_change")) != false)
        {
                this.lastChangedTime = System.Convert.ToInt32(value:  val_3.Item["ctime_change"]);
        }
        
        if((val_3.ContainsKey(key:  "header")) != false)
        {
                object val_17 = val_3.Item["header"];
            val_77 = 0;
            this.Header = ;
        }
        
        val_78 = System.String.alignConst;
        if((val_3.ContainsKey(key:  "type")) != false)
        {
                object val_20 = val_3.Item["type"];
            if(val_20 == null)
        {
            goto label_44;
        }
        
        }
        
        label_44:
        if((val_3.ContainsKey(key:  "short_description")) != false)
        {
                object val_23 = val_3.Item["short_description"];
            val_79 = 0;
            this.ShortDescription = ;
        }
        
        bool val_26 = System.Enum.TryParse<下丙丟上丂与东丂专>(value:  (null == null) ? (val_20) : 0, result: out  this.TypeNews);
        if((this.isBigRewardMessage != false) && (this.TypeNews == 2))
        {
                mem2[0] = 1;
        }
        
        if((val_3.ContainsKey(key:  "description")) != false)
        {
                object val_28 = val_3.Item["description"];
            val_80 = 0;
            this.Message = ;
        }
        
        if((val_3.ContainsKey(key:  "id_reward")) != false)
        {
                if((System.Convert.ToInt32(value:  val_3.Item["id_reward"])) != 0)
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_35 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  System.Convert.ToInt32(value:  val_3.Item["id_reward"]));
            this.idReward = val_35;
            mem[1152921538288024112] = val_35.上万三丆专丏丒丗业;
        }
        
        }
        
        if((val_3.ContainsKey(key:  "url_button")) != false)
        {
                this.urlLink = val_3.Item["url_button"];
        }
        
        if((val_3.ContainsKey(key:  "url_subscribe")) != false)
        {
                this.subscribedUrl = val_3.Item["url_subscribe"];
        }
        
        if((val_3.ContainsKey(key:  "is_youtube")) != false)
        {
                this.isYoutube = ((System.Convert.ToInt32(value:  val_3.Item["is_youtube"])) == 1) ? 1 : 0;
        }
        
        if((val_3.ContainsKey(key:  "fullpicture")) != false)
        {
                val_81 = val_3.Item["fullpicture"];
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_81)) != true)
        {
                val_81 = System.String.alignConst;
        }
        
            this.FullPicture = val_81;
        }
        
        if((val_3.ContainsKey(key:  "fullpicture_1")) != false)
        {
                val_82 = val_3.Item["fullpicture_1"];
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_82)) != true)
        {
                val_82 = System.String.alignConst;
        }
        
            this.SquareFullPicture = val_82;
        }
        
        if((val_3.ContainsKey(key:  "reward_text")) != false)
        {
                this.TextButtonReward = val_3.Item["reward_text"];
        }
        
        bool val_53 = val_3.TryGetValue(key:  "date", value: out  val_52);
        this.Date = System.Convert.ToInt64(value:  val_52);
        System.Collections.Generic.List<System.Object> val_55 = new System.Collections.Generic.List<System.Object>();
        bool val_56 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  val_3, 下上丐丆丝丟丝丒不:  "items", 丙业与丙丗丝不丈东: out  val_55);
        if((val_55 == 0) || (val_55.Count < 1))
        {
            goto label_101;
        }
        
        val_83 = 0;
        goto label_102;
        label_111:
        object val_58 = val_55.Item[0];
        if((val_58 != null) && (null == null))
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_58)) != false)
        {
                this._items.Add(item:  new Rilisoft.OfferItem(丞丕丒专一下丙业上:  val_58.Replace(oldValue:  " ", newValue:  System.String.alignConst)));
        }
        
        }
        
        val_83 = 1;
        label_102:
        if(val_83 < val_55.Count)
        {
            goto label_111;
        }
        
        label_101:
        val_73 = "reward_type";
        val_74 = 1152921516630043280;
        if(((val_3.ContainsKey(key:  "reward_type")) != false) && ((val_3.ContainsKey(key:  "reward_cnt")) != false))
        {
                val_74 = 1152921516622706448;
            val_73 = val_3.Item["reward_type"];
            object val_66 = val_3.Item["reward_cnt"];
            if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_73)) != false) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_66)) != false))
        {
                if(this._items == null)
        {
                this._items = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        }
        
            Rilisoft.OfferItem val_71 = null;
            val_73 = val_71;
            val_71 = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  val_73 + "::"("::") + val_66);
            if(val_73 != null)
        {
                this._items.Add(item:  val_71);
        }
        
        }
        
        }
        
        this.丂丄万业丝丆丐丆丂 = true;
    }
    public 丏不一丏丗丗丗丈丞(System.Collections.Generic.Dictionary<string, object> 上一丄与丙三丄丝三, System.Collections.Generic.Dictionary<string, object> 且丂丅业丞三丆丗丌, 下丙丟上丂与东丂专 一不丁丈东丅丄丟世, System.Collections.Generic.Dictionary<string, object> 丞丕七三丛三丑万万, System.Collections.Generic.Dictionary<string, object> 丄丙下丝丛丒七丂丘, long 丑丙万一丏丅丁专丏, System.Collections.Generic.List<Rilisoft.OfferItem> 丑七不与丛丆一丂丞, bool 丈丞上丌丌丘丂且丛, string 丏丄世丛丆丂丗丅丅)
    {
        this.id = 0;
        this.toId = System.String.alignConst;
        this._items = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.idReward = val_2;
        mem[1152921538288295856] = val_2.上万三丆专丏丒丗业;
        this.FullPicture = System.String.alignConst;
        this.SquareFullPicture = System.String.alignConst;
        this.subscribedUrl = System.String.alignConst;
        this.urlLink = System.String.alignConst;
        this.TextButtonReward = System.String.alignConst;
        val_3 = new System.Object();
        this.HeaderPreview = 上一丄与丙三丄丝三;
        this.Header = val_3;
        this.TypeNews = 一不丁丈东丅丄丟世;
        this.ShortDescription = 丞丕七三丛三丑万万;
        this.Message = 丄丙下丝丛丒七丂丘;
        this._items = 丑七不与丛丆一丂丞;
        this.isReaded = 丈丞上丌丌丘丂且丛;
        this.Date = 丑丙万一丏丅丁专丏;
        this.toId = 丏丄世丛丆丂丗丅丅;
        this.丂丄万业丝丆丐丆丂 = true;
    }
    internal bool 东业东丆丂丝万丑下()
    {
        var val_5;
        var val_7;
        val_5 = this;
        if((丞东丑专丛丆丄丝世.丂七丗丐世业丘丏不(丞丅上丏丂且下丅与:  -678152784)) != false)
        {
                val_7 = 0;
            return (bool)val_7.万万丞丄丗丐丄丄三(三丐三丞丘丕不丒专:  -678152784);
        }
        
        val_5 = ;
        val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        return (bool)val_7.万万丞丄丗丐丄丄三(三丐三丞丘丕不丒专:  -678152784);
    }

}
