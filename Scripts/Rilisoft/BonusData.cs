using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class BonusData
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.BonusData> _subBonuses;
        public string Action;
        public string Procreator;
        public int BattlePassCurrency;
        public string BonusId;
        public int Coins;
        public int DetailsCount;
        public string DetailsItemId;
        public long EndTime;
        public System.Collections.Generic.List<Rilisoft.BonusData.EventCurrencyData> EventCurrencies;
        public int FortItemDetails;
        public string FortItemDetailsTag;
        public int FullPack;
        public System.Collections.Generic.List<string> Gadgets;
        public Rilisoft.丛且世丐丆上七业丁 GameEvent;
        public int Gems;
        public bool IsGems;
        public bool IsTypePack;
        public string Key;
        public string LeprechaunCurrency;
        public int LeprechaunDays;
        public int LeprechaunPerDay;
        public System.Collections.Generic.List<string> LobbyItems;
        public Rilisoft.业丙丘丆东丈丕丂丄 Offer;
        public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule OfferModule;
        public string PetId;
        public decimal Profit;
        public int Quantity;
        public System.Collections.Generic.List<string> Royales;
        public int ShowedEnd;
        public int ShowedPack;
        public long StartTime;
        public Rilisoft.BonusData.不丕丟丐丒且与丛下 Type;
        public int VipSeconds;
        public int WeaponDetails;
        public string WeaponDetailsTag;
        public string WeaponId;
        public System.Collections.Generic.List<string> Wears;
        private System.Collections.Generic.Dictionary<string, object> <RawData>k__BackingField;
        
        // Properties
        public int End { get; }
        public int Pack { get; }
        public System.Collections.Generic.Dictionary<string, object> RawData { get; set; }
        public System.Collections.Generic.List<Rilisoft.BonusData> SubBonuses { get; set; }
        
        // Methods
        public BonusData()
        {
            this.EndTime = 0;
            this._subBonuses = new System.Collections.Generic.List<Rilisoft.BonusData>();
        }
        public BonusData(System.Collections.Generic.Dictionary<string, object> 丂丈丗丄不丅丅丙丒)
        {
            this.丅专下万丕丑丆丅丝(丛丝丙丄七一丁丅三:  丂丈丗丄不丅丅丙丒, 业丈丈丗丐丄三丞丈:  false);
        }
        public int get_End()
        {
            return System.Math.Max(val1:  0, val2:  this.EndTime - FriendsController.丝丗专上三不丄丑丑());
        }
        public int get_Pack()
        {
            return BalanceController.丌丄丂不丄七业丟三(丆丟丁丆万丂世丑丞:  this.Key, 丄且一丄丏丆丐丗与:  this.StartTime, 丅丏丅丂丝一丆丙丅:  FriendsController.丝丗专上三不丄丑丑(), 丈丝世且万世丈丌万:  this.EndTime, 丞丐丗丌丂上与丞丌:  this.FullPack);
        }
        public System.Collections.Generic.Dictionary<string, object> get_RawData()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.<RawData>k__BackingField;
        }
        private void set_RawData(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
        {
            this.<RawData>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<Rilisoft.BonusData> get_SubBonuses()
        {
            return (System.Collections.Generic.List<Rilisoft.BonusData>)this._subBonuses;
        }
        private void set_SubBonuses(System.Collections.Generic.List<Rilisoft.BonusData> 丙业与丙丗丝不丈东)
        {
            this._subBonuses = 丙业与丙丗丝不丈东;
        }
        public void 丅专下万丕丑丆丅丝(System.Collections.Generic.Dictionary<string, object> 丛丝丙丄七一丁丅三, bool 业丈丈丗丐丄三丞丈 = False)
        {
            var val_156;
            var val_157;
            string val_158;
            string val_159;
            string val_160;
            long val_161;
            long val_162;
            decimal val_163;
            bool val_164;
            bool val_165;
            var val_166;
            var val_167;
            int val_168;
            var val_169;
            var val_170;
            int val_171;
            OfferModule val_172;
            不丕丟丐丒且与丛下 val_173;
            System.Collections.Generic.List<EventCurrencyData> val_174;
            System.Func<TSource, System.Boolean> val_175;
            var val_176;
            var val_177;
            var val_178;
            val_156 = 业丈丈丗丐丄三丞丈;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_156 = 丛丝丙丄七一丁丅三;
            val_157 = this;
            if(val_156 != true)
            {
                    this.<RawData>k__BackingField = val_156;
                this.世业丒万丘丆专丘丐();
            }
            
            if(val_156 == null)
            {
                    return;
            }
            
            if(val_156 == true)
            {
                goto label_3;
            }
            
            if((val_156.ContainsKey(key:  "action")) != false)
            {
                    string val_3 = System.Convert.ToString(value:  val_156.Item["action"]);
            }
            
            this.Action = 0;
            if((val_156.ContainsKey(key:  "procreator")) != false)
            {
                    string val_6 = System.Convert.ToString(value:  val_156.Item["procreator"]);
            }
            else
            {
                    val_158 = 0;
            }
            
            this.Procreator = val_158;
            if((val_156.ContainsKey(key:  "Key")) != false)
            {
                    string val_9 = System.Convert.ToString(value:  val_156.Item["Key"]);
            }
            else
            {
                    val_159 = 0;
            }
            
            this.Key = val_159;
            if((val_156.ContainsKey(key:  "ID")) != false)
            {
                    string val_12 = System.Convert.ToString(value:  val_156.Item["ID"]);
            }
            else
            {
                    val_160 = 0;
            }
            
            this.BonusId = val_160;
            if((val_156.ContainsKey(key:  "StartTime")) != false)
            {
                    long val_15 = System.Convert.ToInt64(value:  val_156.Item["StartTime"]);
            }
            else
            {
                    val_161 = 0;
            }
            
            this.StartTime = val_161;
            if((val_156.ContainsKey(key:  "EndTime")) != false)
            {
                    val_162 = (long)System.Convert.ToInt32(value:  val_156.Item["EndTime"]);
            }
            else
            {
                    val_162 = 0;
            }
            
            this.EndTime = val_162;
            if((val_156.ContainsKey(key:  "Profit")) != false)
            {
                    val_163 = this.Profit;
                bool val_21 = 丞东丑专丛丆丄丝世.丛丐东丟丛丘丁世丁(丞丕丒专一下丙业上:  val_156.Item["Profit"], 丙业与丙丗丝不丈东: out  new System.Decimal() {flags = val_163, hi = val_163, lo = val_163, mid = val_163});
            }
            
            if((val_156.ContainsKey(key:  "Type")) != false)
            {
                    val_164 = System.String.op_Equality(a:  val_156.Item["Type"], b:  "packs");
            }
            else
            {
                    val_164 = false;
            }
            
            this.IsTypePack = val_164;
            if((val_156.ContainsKey(key:  "isGems")) != false)
            {
                    val_165 = System.Convert.ToBoolean(value:  val_156.Item["isGems"]);
            }
            else
            {
                    val_165 = false;
            }
            
            this.IsGems = val_165;
            val_166 = null;
            val_166 = null;
            if((val_156.ContainsKey(key:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    val_167 = null;
                val_167 = null;
                object val_29 = val_156.Item[与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄];
            }
            else
            {
                    val_168 = 0;
            }
            
            this.Coins = val_168;
            val_169 = null;
            val_169 = null;
            if((val_156.ContainsKey(key:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_170 = null;
                val_170 = null;
                object val_31 = val_156.Item[与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝];
            }
            else
            {
                    val_171 = 0;
            }
            
            this.Gems = val_171;
            if((val_156.ContainsKey(key:  "gameEvent")) != false)
            {
                    object val_33 = val_156.Item["gameEvent"];
            }
            
            this.GameEvent = 0;
            if((val_156.ContainsKey(key:  "offer-module")) != false)
            {
                    System.Nullable<T> val_36 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<OfferModule>(下业七不丑丂丏丟东:  val_156.Item["offer-module"], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
                if(((-295067992) & 1) != 0)
            {
                    int val_37 = val_36.HasValue.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_172 = 0;
            }
            
                this.OfferModule = val_172;
            }
            
            if((System.String.op_Equality(a:  this.Action, b:  "weapon")) != false)
            {
                    val_173 = 2;
            }
            else
            {
                    if((System.String.op_Equality(a:  this.Action, b:  "pet")) != false)
            {
                    val_173 = 3;
            }
            else
            {
                    if((System.String.op_Equality(a:  this.Action, b:  "leprechaun")) != true)
            {
                    if((System.String.op_Equality(a:  this.Action, b:  "leprechaun_one")) == false)
            {
                goto label_65;
            }
            
            }
            
                val_173 = 4;
            }
            
            }
            
            label_211:
            this.Type = val_173;
            label_3:
            if((val_156.ContainsKey(key:  "EventCurrency")) != false)
            {
                    BonusData.丛世且不丕丕东丒三 val_43 = null;
                val_163 = val_43;
                val_43 = new BonusData.丛世且不丕丕东丒三();
                int val_45 = 0;
                .且下丕七丙丗丄不七 = 0;
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["EventCurrency"], 丙业与丙丗丝不丈东: out  val_45)) != false)
            {
                    if((val_156.ContainsKey(key:  "EventType")) != false)
            {
                    System.Nullable<T> val_49 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.GameEventType>(下业七不丑丂丏丟东:  val_156.Item["EventType"], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
                mem[1152921542966618896] = val_49.HasValue;
            }
            
            }
            
                val_174 = this.EventCurrencies;
                if(val_174 == null)
            {
                    System.Collections.Generic.List<EventCurrencyData> val_50 = null;
                val_174 = val_50;
                val_50 = new System.Collections.Generic.List<EventCurrencyData>();
                this.EventCurrencies = val_174;
            }
            
                System.Func<EventCurrencyData, System.Boolean> val_51 = null;
                val_175 = val_51;
                val_51 = new System.Func<EventCurrencyData, System.Boolean>(object:  val_43, method:  System.Boolean BonusData.丛世且不丕丕东丒三::万丛丙丘下丂丟丈丑(Rilisoft.BonusData.EventCurrencyData 丐丆丂丒丁万丈丛丅));
                if((System.Linq.Enumerable.FirstOrDefault<EventCurrencyData>(source:  val_50, predicate:  val_51)) != null)
            {
                    val_52.Count = 0;
            }
            else
            {
                    BonusData.EventCurrencyData val_53 = null;
                val_163 = val_53;
                val_53 = new BonusData.EventCurrencyData();
                if(val_163 != null)
            {
                    .EventType = 1152921542966618896;
                val_176 = val_45;
            }
            else
            {
                    .EventType = 1152921542966618896;
                val_176 = val_45;
            }
            
                .Count = 0;
                this.EventCurrencies.Add(item:  val_53);
            }
            
            }
            
            if((val_156.ContainsKey(key:  "BattlePassCurrency")) != false)
            {
                    val_163 = this.BattlePassCurrency;
                bool val_58 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["BattlePassCurrency"], 丙业与丙丗丝不丈东: out  val_163);
            }
            
            if((val_156.ContainsKey(key:  "FullPack")) != false)
            {
                    this.FullPack = System.Convert.ToInt32(value:  val_156.Item["FullPack"]);
            }
            
            if((val_156.ContainsKey(key:  "Wears")) != false)
            {
                    val_163 = val_156.Item["Wears"];
                val_177 = 0;
                System.Collections.Generic.List<System.String> val_64 = new System.Collections.Generic.List<System.String>(collection:  null);
                this.Wears = null;
            }
            
            if((val_156.ContainsKey(key:  "LobbyItems")) != false)
            {
                    val_163 = val_156.Item["LobbyItems"];
                val_178 = 0;
                System.Collections.Generic.List<System.String> val_67 = new System.Collections.Generic.List<System.String>(collection:  null);
                this.LobbyItems = null;
            }
            
            if((val_156.ContainsKey(key:  "VIPseconds")) != false)
            {
                    val_163 = this.VipSeconds;
                bool val_71 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["VIPseconds"], 丙业与丙丗丝不丈东: out  val_163);
            }
            
            if((val_156.ContainsKey(key:  "WeaponDetailsTag")) != false)
            {
                    val_163 = "WeaponDetails";
                if((val_156.ContainsKey(key:  "WeaponDetails")) != false)
            {
                    this.WeaponDetailsTag = val_156.Item["WeaponDetailsTag"];
                val_163 = this.WeaponDetails;
                bool val_77 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["WeaponDetails"], 丙业与丙丗丝不丈东: out  val_163);
            }
            
            }
            
            if((val_156.ContainsKey(key:  "FortItemDetailsTag")) != false)
            {
                    val_163 = "FortItemDetails";
                if((val_156.ContainsKey(key:  "FortItemDetails")) != false)
            {
                    this.FortItemDetailsTag = val_156.Item["FortItemDetailsTag"];
                val_163 = this.FortItemDetails;
                bool val_83 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["FortItemDetails"], 丙业与丙丗丝不丈东: out  val_163);
            }
            
            }
            
            if((val_156.ContainsKey(key:  "DetailsItemId")) != false)
            {
                    val_163 = "DetailsCount";
                if((val_156.ContainsKey(key:  "DetailsCount")) != false)
            {
                    this.DetailsItemId = val_156.Item["DetailsItemId"];
                val_163 = this.DetailsCount;
                bool val_89 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_156.Item["DetailsCount"], 丙业与丙丗丝不丈东: out  val_163);
            }
            
            }
            
            if((val_156.ContainsKey(key:  "Weapon")) != false)
            {
                    this.WeaponId = System.Convert.ToString(value:  val_156.Item["Weapon"]);
            }
            
            if((val_156.ContainsKey(key:  "Pet")) != false)
            {
                    this.PetId = System.Convert.ToString(value:  val_156.Item["Pet"]);
            }
            
            if((val_156.ContainsKey(key:  "Quantity")) != false)
            {
                    this.Quantity = System.Convert.ToInt32(value:  val_156.Item["Quantity"]);
            }
            
            if((val_156.ContainsKey(key:  "CurrencyLeprechaun")) != false)
            {
                    this.LeprechaunCurrency = System.Convert.ToString(value:  val_156.Item["CurrencyLeprechaun"]);
            }
            
            if((val_156.ContainsKey(key:  "PerDayLeprechaun")) != false)
            {
                    this.LeprechaunPerDay = System.Convert.ToInt32(value:  val_156.Item["PerDayLeprechaun"]);
            }
            
            if((val_156.ContainsKey(key:  "DaysLeprechaun")) != false)
            {
                    this.LeprechaunDays = System.Convert.ToInt32(value:  val_156.Item["DaysLeprechaun"]);
            }
            
            if((val_156.ContainsKey(key:  "Gadgets")) != false)
            {
                    val_175 = 1152921504691564544;
                val_163 = val_156.Item["Gadgets"];
                if(val_163 != null)
            {
                    val_163 = 0;
            }
            
                System.Collections.Generic.List<System.String> val_111 = new System.Collections.Generic.List<System.String>(collection:  val_163);
                this.Gadgets = null;
            }
            
            if((val_156.ContainsKey(key:  "offer-id")) != false)
            {
                    val_163 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
                this.Offer = val_163.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_156.Item["offer-id"]);
            }
            
            if((val_156.ContainsKey(key:  "Weapon")) != false)
            {
                    this.WeaponId = System.Convert.ToString(value:  val_156.Item["Weapon"]);
            }
            
            if((val_156.ContainsKey(key:  "Royale")) != false)
            {
                    val_163 = val_156.Item["Royale"];
                if(val_163 != null)
            {
                    val_163 = 0;
            }
            
                System.Collections.Generic.List<System.String> val_122 = new System.Collections.Generic.List<System.String>(collection:  val_163);
                this.Royales = null;
            }
            
            if(val_156 == true)
            {
                    return;
            }
            
            val_156 = "bonuses";
            if((val_156.ContainsKey(key:  "bonuses")) == false)
            {
                    return;
            }
            
            object val_124 = val_156.Item["bonuses"];
            if(val_124 == null)
            {
                    return;
            }
            
            val_156 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_124) : 0;
            List.Enumerator<T> val_125 = val_156.GetEnumerator();
            val_156 = 1152921524494355360;
            label_162:
            if(((-295068024) & 1) == 0)
            {
                goto label_160;
            }
            
            string val_126 = 0.丐丏七丌丕丗业且上();
            goto label_162;
            label_65:
            if((System.String.op_Equality(a:  this.Action, b:  "gadget")) == false)
            {
                goto label_163;
            }
            
            goto label_211;
            label_163:
            if(this.GameEvent == null)
            {
                goto label_165;
            }
            
            goto label_211;
            label_160:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_165:
            if((System.String.op_Equality(a:  this.Action, b:  "offer")) == false)
            {
                goto label_168;
            }
            
            var val_130 = (this.OfferModule == 130) ? 28 : ((this.OfferModule == 140) ? 29 : 7);
            goto label_211;
            label_168:
            if((System.String.op_Equality(a:  this.Action, b:  "tryGun")) == false)
            {
                goto label_170;
            }
            
            goto label_211;
            label_170:
            if((System.String.op_Equality(a:  this.Action, b:  "update-info")) == false)
            {
                goto label_172;
            }
            
            goto label_211;
            label_172:
            if((System.String.op_Equality(a:  this.Action, b:  "recomendation")) == false)
            {
                goto label_174;
            }
            
            goto label_211;
            label_174:
            if((System.String.op_Equality(a:  this.Action, b:  "offerwall")) == false)
            {
                goto label_176;
            }
            
            goto label_211;
            label_176:
            if((System.String.op_Equality(a:  this.Action, b:  "vipInSeconds")) == false)
            {
                goto label_178;
            }
            
            goto label_211;
            label_178:
            if((System.String.op_Equality(a:  this.Action, b:  "recommend-clan")) == false)
            {
                goto label_180;
            }
            
            goto label_211;
            label_180:
            if((System.String.op_Equality(a:  this.Action, b:  "recommend-duel")) == false)
            {
                goto label_182;
            }
            
            goto label_211;
            label_182:
            if((System.String.op_Equality(a:  this.Action, b:  "recommend-characters")) == false)
            {
                goto label_184;
            }
            
            goto label_211;
            label_184:
            if((System.String.op_Equality(a:  this.Action, b:  "event_currence")) == false)
            {
                goto label_186;
            }
            
            goto label_211;
            label_186:
            if((System.String.op_Equality(a:  this.Action, b:  "wear")) == false)
            {
                goto label_188;
            }
            
            goto label_211;
            label_188:
            if((System.String.op_Equality(a:  this.Action, b:  "craft_lobby_items")) == false)
            {
                goto label_190;
            }
            
            goto label_211;
            label_190:
            if((System.String.op_Equality(a:  this.Action, b:  "WeaponDetails")) == true)
            {
                goto label_211;
            }
            
            if((System.String.op_Equality(a:  this.Action, b:  "parts")) == false)
            {
                goto label_193;
            }
            
            goto label_211;
            label_193:
            if((System.String.op_Equality(a:  this.Action, b:  "FortItemDetails")) == false)
            {
                goto label_195;
            }
            
            goto label_211;
            label_195:
            if((System.String.op_Equality(a:  this.Action, b:  "recommend-lobby-bundles")) == false)
            {
                goto label_197;
            }
            
            goto label_211;
            label_197:
            if((System.String.op_Equality(a:  this.Action, b:  "multiplier")) == false)
            {
                goto label_199;
            }
            
            goto label_211;
            label_199:
            if((System.String.op_Equality(a:  this.Action, b:  "mix")) == false)
            {
                goto label_201;
            }
            
            goto label_211;
            label_201:
            if((System.String.op_Equality(a:  this.Action, b:  "royale")) == false)
            {
                goto label_203;
            }
            
            goto label_211;
            label_203:
            if((System.String.op_Equality(a:  this.Action, b:  "battlepass")) == false)
            {
                goto label_205;
            }
            
            goto label_211;
            label_205:
            if((System.String.op_Equality(a:  this.Action, b:  "ChangeLog")) == false)
            {
                goto label_207;
            }
            
            goto label_211;
            label_207:
            if((System.String.op_Equality(a:  this.Action, b:  "battlePassCurrency")) == false)
            {
                goto label_209;
            }
            
            goto label_211;
            label_209:
            var val_153 = ((System.String.op_Equality(a:  this.Action, b:  "EventStore")) != true) ? 26 : (0 + 1);
            goto label_211;
        }
        private void 世业丒万丘丆专丘丐()
        {
            this.IsGems = false;
            this.IsTypePack = false;
            this.OfferModule = 0;
            this.ShowedEnd = 0;
            this.ShowedPack = 0;
            this.StartTime = 0;
            this.Action = 0;
            this.Procreator = 0;
            this.FullPack = 0;
            this.Gems = 0;
            this.Type = 0;
            this.WeaponDetails = 0;
            this.FortItemDetailsTag = 0;
            this.FortItemDetails = 0;
            this.BattlePassCurrency = 0;
            this.Offer = 0;
            this.BonusId = 0;
            this.Coins = 0;
            this.DetailsCount = 0;
            this.Key = 0;
            this.LeprechaunCurrency = 0;
            this.LeprechaunDays = 0;
            this.LeprechaunPerDay = 0;
            this.Quantity = 0;
            this.Profit = 0m;
            mem[1152921542966999112] = 0;
            this.DetailsItemId = 0;
            this.EndTime = 0;
            this.PetId = 0;
            this.WeaponDetailsTag = 0;
            this.WeaponId = 0;
            if(this.Gadgets != null)
            {
                    this.Gadgets.Clear();
            }
            
            if(this.Wears != null)
            {
                    this.Wears.Clear();
            }
            
            if(this.LobbyItems != null)
            {
                    this.LobbyItems.Clear();
            }
            
            if(this.EventCurrencies != null)
            {
                    this.EventCurrencies.Clear();
            }
            
            if(this.Royales == null)
            {
                    return;
            }
            
            this.Royales.Clear();
        }
        internal static T 七丅丆上丁丞丕业丐<T>(System.Collections.Generic.Dictionary<string, object> 丈丗与丞一上且上上, string 丂丐丄丁丆与丈丂上)
        {
            var val_7;
            var val_8;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            if(丈丗与丞一上且上上 == null)
            {
                goto label_8;
            }
            
            if((丈丗与丞一上且上上.ContainsKey(key:  丂丐丄丁丆与丈丂上)) == false)
            {
                goto label_2;
            }
            
            val_14 = 丈丗与丞一上且上上.Item[丂丐丄丁丆与丈丂上];
            if(val_14 == null)
            {
                goto label_8;
            }
            
            object val_3 = 丈丗与丞一上且上上.Item[丂丐丄丁丆与丈丂上];
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return (Rilisoft.GameEventType)val_15;
            }
            
            return (Rilisoft.GameEventType)val_15;
            label_2:
            val_14 = "bonuses";
            if((丈丗与丞一上且上上.ContainsKey(key:  "bonuses")) == false)
            {
                goto label_8;
            }
            
            object val_5 = 丈丗与丞一上且上上.Item["bonuses"];
            if(val_5 == null)
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_6 = val_5.GetEnumerator();
            label_11:
            if(((-294400576) & 1) == 0)
            {
                goto label_13;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if((val_9 == null) || ((val_9.ContainsKey(key:  丂丐丄丁丆与丈丂上)) == false))
            {
                goto label_11;
            }
            
            if(val_9.Item[丂丐丄丁丆与丈丂上] == null)
            {
                goto label_13;
            }
            
            object val_12 = val_9.Item[丂丐丄丁丆与丈丂上];
            val_16 = 0;
            goto label_15;
            label_8:
            val_15 = 0;
            return (Rilisoft.GameEventType)val_15;
            label_13:
            val_16 = 0;
            label_15:
            val_17 = 0;
            val_7 = val_8;
            val_8 = null;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_8.Dispose();
            if( != 1)
            {
                    if( == 0)
            {
                    return (Rilisoft.GameEventType)val_15;
            }
            
                if(183 != 183)
            {
                    return (Rilisoft.GameEventType)val_15;
            }
            
                return (Rilisoft.GameEventType)val_15;
            }
            
            if( == 0)
            {
                    return (Rilisoft.GameEventType)val_15;
            }
            
            return (Rilisoft.GameEventType)val_15;
        }
    
    }

}
