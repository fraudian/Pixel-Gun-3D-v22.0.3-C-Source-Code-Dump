using UnityEngine;

namespace Rilisoft
{
    public class 丛且世丐丆上七业丁 : IDisposable
    {
        // Fields
        private static System.Action<int> 万世上丘东丟丝丅东;
        internal const string 丑上丏丄丞丑东丞丟 = "pg_birthday";
        internal const string 丆业丐丝丕丆专丒丏 = "4july";
        internal const string 丄丏丘丟丗下丟丗丘 = "multi_chests";
        internal const string 且一丌丝丞且丂业丙 = "homecoming";
        internal const string 丒丐丄东丕七下业丂 = "halloween";
        internal const string 丐三丞万丕三与丐七 = "super_lottery_basic";
        internal const string 丘丘丛丌一业世上上 = "sets";
        internal const string 七丘且一丑丈丂世三 = "exoskeletons_v3";
        internal const string 万世丞丝丗丆丞丙丗 = "roulette";
        internal const string 丕东丈丕一丁下丘业 = "christmas2";
        internal const string 东丑世万丙三丏丄专 = "new_year2";
        internal const string 丟专七丐万七丝七万 = "oriental_lottery_v3";
        internal const string 丛东丞不丂且丕一丗 = "sniper_tournament";
        internal const string 丘丘丄上丏丞丟不丘 = "sniper2_roulette";
        internal const string 丅与丑三丂丁丒一专 = "BTroulette";
        internal const string 万丂且丐丕丏丗丅丛 = "BTchests";
        internal const string 丙下丑丌世丆丅丕丏 = "Roulette_time_traveller2";
        internal const string 丛专一丐业丞丕丅上 = "halloween_roulette";
        internal const string 丐丘丄万丁丒丒丒丅 = "thanksgiving_roulette";
        internal const string 丝专丌三业丑万丄世 = "eco_roulette";
        internal const string 丆丒一丌丒世丞不世 = "thanksgiving_chests";
        internal const string 业三万丛丛丙丈丟丂 = "new_year_roulette";
        internal const string 丒与丗丘不丆丕丗丛 = "Alien_Santa_roulette";
        internal const string 与丁丘丌丛丂且丂丒 = "super_soldier_roulette";
        internal const string 万下万一专业三世不 = "big_b_roulette";
        internal const string 业丁业丄丅世丄丅丕 = "magic_chests";
        internal const string 下一丅上下丑丅丂丁 = "super_villain_roulette";
        internal const string 丛丆丏丂东丐三丅一 = "hero_lottery";
        internal const string 丛丕一东一七丗丞三 = "Zombie";
        internal const string 丒丁丏丒世丕三丗三 = "Infected";
        internal const string 七丐业丕七丘东丞不 = "toystory";
        internal const string 且丌三业三丗上业世 = "toystory_lottery";
        internal const string 丈七丂丂一七丌丑丒 = "summer_roulette";
        internal const string 丌与且丐下丂丟专丞 = "summer_lottery";
        internal const string 一三丙丒丑丈丆专下 = "champion_roulette";
        internal const string 丄与丙丗丏专一七丙 = "knight_lottery";
        internal const string 且丒丆东丕与丏丝上 = "digital_hero_roulette";
        internal const string 一丕不丟万丏东一业 = "fighters_lottery";
        internal const string 丆专丏丞丏万专专丙 = "mouseking_roulette";
        internal const string 丑丟不丈丙丄专丅一 = "crampus_lottery";
        internal const string 东丛业上丙丗万世丑 = "master_roulette";
        internal const string 上丈丞且丐一丏且下 = "rubus_lottery";
        internal const string 丒丆业东丆三丁专一 = "alien_general_roulette";
        internal const string 丏丄丏与下丑丐丟丂 = "alien_lottery";
        internal const string 与丞丏丒丆专专业丕 = "humpty_dumpty_roulette";
        internal const string 丆丅丂丛丝丟七与丝 = "egg_easter_lottery";
        internal const string 丛下丘丐丈丁不世东 = "arcane_summoner_roulette";
        internal const string 丒丞丆丐下丒丁丛丂 = "mechanist_lottery";
        internal const string 丝且丒丒丅丞一专万 = "giant_scuba_diver_roulette";
        internal const string 世丂丘丗世七丄丒世 = "deep_dive_lottery";
        internal const string 丈丝三丅丐丏丕专三 = "insidious_hades_roulette";
        internal const string 丛万丁三丛丕三丒丗 = "titanic_lottery";
        internal const string 东丐丑丛丛丒世东与 = "project_manager_roulette";
        internal const string 丁上丗丗三万世丁丟 = "art_dept_lottery";
        internal const string 且丗丞丄上丟丆万丘 = "summer_spirit_roulette";
        internal const string 业丕丁丛丏丛专专不 = "waterpark_old_lottery";
        internal const string 丁丆三丅一丛丑世一 = "exosceletons_lottery";
        internal const string 丏丈上丘丂丕丟丗丆 = "subject_1013_roulette";
        internal const string 丞东七丝丌万丅丁丝 = "foundation_archive_lottery";
        internal const string 东丆丞不丝丗专七专 = "bloq_director_roulette";
        internal const string 与一丂丅丅专丙三丞 = "gangs_union_lottery";
        internal const string 丞丅专丈丈丁丝丈丌 = "ice_dragon_shaman";
        internal const string 丕丌丏丒丅丟丐丗丘 = "elven_specops_lottery";
        internal const string 上丅丒丐上丄丄丅丁 = "krampus_roulette";
        internal const string 丏丅丆七丁东丗丟专 = "loki_lottery";
        internal const string 丘丒万丐三与丏专丟 = "odin_god_set";
        internal const string 丑不业丈万丞专丅一 = "fan_art_lottery";
        internal const string 丂专丞丛丒丌丞丏三 = "ultimatum_adept_set";
        internal const string 丌丘专丕丐一丒丁万 = "developer_lottery";
        internal const string 不丗丟丌且丞与丝万 = "user_choice_lottery";
        internal const string 丒丆丁丄丌不丟与丐 = "general_bullet_set";
        internal const string 丒万与三三丟业丂丐 = "mafia_lottery";
        internal const string 丄丄不丁丕丂业丌丝 = "pg_birthday_2021_lottery";
        internal const string 东丙丂丏丝业丆丂上 = "dino_lottery";
        internal const string 丆上万且业丑丁丑丘 = "super_portalius_set";
        internal const string 丌业丕世业七丈丝丈 = "cartoon_lottery";
        internal const string 丏丌下丒丆丕丅不业 = "author_set";
        internal const string 万万丂与丗丁丂丝丙 = "4th_july_lottery";
        internal const string 不丁丟丝三三丏丁丅 = "Anime_lottery";
        internal const string 与丑丕丘丙丏丝丘丙 = "default_resources";
        internal const string 丑一丁丆不丄丄世一 = "tube_legends_lottery";
        internal const string 一专丁丏丐上丏丟且 = "pursued_set";
        internal const string 丙三世丌业东丁不万 = "manager_lottery";
        internal const string 丁三万世七三不上丞 = "new_developer_lottery";
        internal const string 丄丙丐丕丙丁丕丅万 = "sacred_tomb_lottery";
        internal const string 丒丛一七丐万丛七不 = "shiny_ra_set";
        internal const string 丕丝且三丂世世三丒 = "21_6_olympus_lottery";
        internal const string 下业丗丄与且丁丈下 = "21_6_waterpark_lottery";
        internal const string 丌下丆丆丙与与丒万 = "military_supply_lottery";
        internal const string 上业业与丄专三丅丅 = "secret_prototype_set";
        internal const string 丘专丙丑丌丄丗丁丌 = "police_drone_roulette";
        internal const string 一七丑丅丁丕丅丂上 = "21_7_halloween_lottery";
        internal const string 世丆丞三丝丒丕丁丐 = "space_parasites_lottery";
        internal const string 丂丌不丐丐丂万丞丝 = "goliath_set";
        internal const string 东专且丟三丌丈丐七 = "survivors_lottery";
        internal const string 丄丒丅丌丐丙世丁下 = "agent_x_roulette";
        internal const string 且上丈丙万下丘丈万 = "christmas_bandits_lottery";
        internal const string 丟丄一世丘丌不丅万 = "mirrored_santa_set";
        internal const string 丈东丒丝丙丐与东丙 = "fulfillment_of_desires_lottery";
        internal const string 丁万丝丙丒丙丈且丌 = "summoned_wish_set";
        internal const string 丁丐丏丂一万丛丂丈 = "ice_dragon_shaman_lottery";
        internal const string 丒丆丛丘丏丆业与丅 = "menu_music_event_";
        internal const int 丏丐丑专丈丒丑丁丈 = 10;
        private Rilisoft.丝丑丂丛万丐丈丘且 下丂丆丒三丑丌东丒;
        private System.Collections.Generic.List<Rilisoft.与专丒丞丐一丒丂东> 与丌与七丕七丆丘且;
        private System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 业丂且丁丅专丙丁丝;
        private System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丙丗丝一丏丅专丁不;
        public string 丈丏上丏业丑不丌七;
        private string 东丛万丘丂丗丘丗且;
        private string 丞世下业丈上丞丅下;
        private string 上丄丑丙丘世上万丗;
        private Rilisoft.且丈丞一丞丟与上七 丌丟且万上丑丁丄业;
        private Rilisoft.且丈丞一丞丟与上七 丕丐与丆丙丌丙丑上;
        private Rilisoft.且丈丞一丞丟与上七 七丁东丁丙世丑丅丏;
        private Rilisoft.且丈丞一丞丟与上七 丂丆丅丁丙一丞丗丏;
        private float 丄专丗不万丙丑业丅;
        private string 丗世且丅丒专上丛不;
        private System.Nullable<System.DateTime> 与下丒丙丟丟丛不丈;
        private int 三一丙不业丛丙业七;
        private UnityEngine.Coroutine 丛丘丒丛丟世万与世;
        public bool 专丛丄东丝丕丌一东;
        public static System.Action<Rilisoft.GameEventType> 专丕东不东丟丂丅丒;
        private Rilisoft.GameEventData <丅不丙丌丟业一业丂>k__BackingField;
        private Rilisoft.万一丐业丒丆丈世丅 <丞一世丒上丂下丁丅>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> <丙丌丅丝丘与三丗丑>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> <专丄丌丑丘世丐专丟>k__BackingField;
        private static System.Action 丞丝业丁下丛丕一丒;
        private System.Action 丄丐丛万丐丏且丝不;
        private System.Action 万丏东且丈丕专丝且;
        private System.Action 与丕丕七不丝专专丛;
        private static System.Action<Rilisoft.GameEventType, PGCompany.三东丏不丗世丅丌丄> 丁丑丈丐不七三专丒;
        private static System.Action 七丂丙专丙丟东专世;
        
        // Properties
        private string 丆业丗丏丑下业丘一 { get; }
        public int 丄七丈丙七上不且丙 { get; }
        public string 下丄丈不与世丐业专 { get; }
        public int 不丌七丆丏丂丐万丂 { get; }
        public Rilisoft.GameEventType 丒三丝一上丙专丗丒 { get; }
        public Rilisoft.GameEventData 丞丑且东丌与丏丏丁 { get; set; }
        public System.Collections.Generic.List<Rilisoft.GameEventRewardData> 丆丏业丈与丈丅专世 { get; }
        public System.Collections.Generic.List<Rilisoft.GameCurrencyData> 专专丂丈丐丅丛丐下 { get; }
        public string 丛丒丁丗丆丏下丐七 { get; }
        public System.Nullable<System.TimeSpan> 丞东丁丝下万丒上丆 { get; }
        public System.Nullable<System.TimeSpan> 丌与丁不下丅丆丘丞 { get; }
        private System.Collections.Generic.List<Rilisoft.与专丒丞丐一丒丂东> 丑上与丏丑丑丗上丗 { get; }
        internal int 丒丂七丆专万丏丅丕 { get; }
        internal bool 丅业东万丌丕上丌丄 { get; }
        internal bool 丟丌丅丟丑丛丈丑丅 { get; }
        private System.Nullable<System.DateTime> 不丟上丈丝业丒万与 { get; }
        public bool 且丗万丐丌业上丙下 { get; }
        public Rilisoft.上专业三丟丁丞专下 专专世丙不专丕丝丁 { get; }
        public bool 丌不丗丙丛万不丐丈 { get; }
        public bool 一且丑丟上丗七丞专 { get; }
        public Rilisoft.万一丐业丒丆丈世丅 丈丙丌丄丘丛丘丟一 { get; set; }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丟七丘三丗丛万丝且 { get; set; }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 专丕丛丕丗万丈丁丛 { get; set; }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 下不万三丘丝丆丂一 { get; }
        public int 丘丈丂万丝丅丈丕丙 { get; set; }
        internal bool 专丁三丘业丗一与丄 { get; set; }
        public string 丘上七东世世一丞丏 { get; }
        public string 丙与丏东丄丅与丙丈 { get; }
        public string 丏丑丘丈专专丘三丘 { get; }
        public string 丈丄丕丗丑专下丁专 { get; }
        public string 丁上丐万丗丐业业三 { get; }
        public string 丐丏业丟丄丘丛丌丂 { get; }
        public string 丏丑世三万丐丝丟丌 { get; }
        public Rilisoft.上专业三丟丁丞专下 世下丟丞万东丞丌丆 { get; set; }
        
        // Methods
        internal static void 丒七与丟丗丞丂丒丌(System.Action<int> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丞丟丌不下丂丑丒丟(System.Action<int> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal void 丏丐丄丟丂丏丕一丒()
        {
            int val_2 = Progress.七七世万专丕丁上业.不世丗丞丙丅丐丙丁().丕丂丄丙丌丒丝丑丆(丅且三万丘丙业丙丗:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId);
        }
        public 丛且世丐丆上七业丁(Rilisoft.GameEventData 一丐丗丁丞丆丅丟丄)
        {
            this.下丂丆丒三丑丌东丒 = 0;
            mem[1152921542871579832] = 0;
            this.丙丗丝一丏丅专丁不 = new System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>();
            this.丌丟且万上丑丁丄业 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "event_last_drop_item_type");
            this.专丛丄东丝丕丌一东 = true;
            this.丑七丂丌世与七丏与(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
            this.丕丐与丆丙丌丙丑上 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  System.String.Format(format:  "{0}-need-drop-unique-item", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId));
            this.七丁东丁丙世丑丅丏 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  System.String.Format(format:  "{0}-need-drop-unique-item-mylty-spin", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId));
            this.丂丆丅丁丙一丞丗丏 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  System.String.Format(format:  "{0}_bloggerRewardIsGetted", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId));
            this.<丞一世丒上丂下丁丅>k__BackingField = new Rilisoft.万一丐业丒丆丈世丅(丅东专与不三丂丁丝:  this);
            if((Progress.七七世万专丕丁上业.不世丗丞丙丅丐丙丁().丁丒世上不专不丗丞(丟丟丄专上丟丁丐丝:  一丐丗丁丞丆丅丟丄.EventId)) != true)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丟丈丂世且七丆丆(丞且丅三三东不丄且:  0, 丟丟丄专上丟丁丐丝:  一丐丗丁丞丆丅丟丄.EventId, 世丁丙世丄一万丆三:  0);
            }
            
            一下丛与丛丛万万丏.丁丘世丁丝七且一丁(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void Rilisoft.丛且世丐丆上七业丁::丏专丝丗与下丟三丛(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            一下丛与丛丛万万丏.丙且丝丕丙丟丁下丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void Rilisoft.丛且世丐丆上七业丁::丏专丝丗与下丟三丛(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        }
        private string 丕业下丑丆丘丘丐下()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return System.String.Format(format:  "{0}-spins-count", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
            }
            
            return System.String.Format(format:  "{0}-spins-count", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
        }
        public int 三丗万下丕丒专上丞()
        {
            null = null;
            if(Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万 != null)
            {
                    return Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万.Item[this.<丅不丙丌丟业一业丂>k__BackingField.EventId];
            }
            
            return Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万.Item[this.<丅不丙丌丟业一业丂>k__BackingField.EventId];
        }
        public string 业上丙丞丐丄丆丅七()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return (string)this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            }
            
            return (string)this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
        }
        public int 丅丙丛丑丌丆丌丕丒()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return (int)this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId;
            }
            
            return (int)this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId;
        }
        public Rilisoft.GameEventType 不业丙丒丂丞下丆丙()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return (Rilisoft.GameEventType)this.<丅不丙丌丟业一业丂>k__BackingField.Type;
            }
            
            return (Rilisoft.GameEventType)this.<丅不丙丌丟业一业丂>k__BackingField.Type;
        }
        public Rilisoft.GameEventData 丁专丗万三上丟三丆()
        {
            return (Rilisoft.GameEventData)this.<丅不丙丌丟业一业丂>k__BackingField;
        }
        private void 丏丝丈丗丄丛丐万丆(Rilisoft.GameEventData 丙业与丙丗丝不丈东)
        {
            this.<丅不丙丌丟业一业丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<Rilisoft.GameEventRewardData> 不丁专丁丂丆不丂丕()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventRewardData>)this.<丅不丙丌丟业一业丂>k__BackingField.Rewards;
            }
            
            return (System.Collections.Generic.List<Rilisoft.GameEventRewardData>)this.<丅不丙丌丟业一业丂>k__BackingField.Rewards;
        }
        public System.Collections.Generic.List<Rilisoft.GameCurrencyData> 业丈丂丏上丄丘丐丞()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameCurrencyData>)this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices;
            }
            
            return (System.Collections.Generic.List<Rilisoft.GameCurrencyData>)this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices;
        }
        public string 不与业上七丏业丐丛()
        {
            Rilisoft.GameEventData val_1;
            string val_2;
            val_1 = this;
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) == 200)
            {
                    val_1 = this.<丅不丙丌丟业一业丂>k__BackingField;
                val_2 = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
                return (string)val_2;
            }
            
            val_2 = 0;
            return (string)val_2;
        }
        public System.Nullable<System.TimeSpan> 丅下丄下业丌丑丆且()
        {
            ulong val_9;
            ulong val_10;
            val_9 = this;
            System.Nullable<System.DateTime> val_1 = this.丅丁丐与丗丅且专丒();
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((-388474384) & 1) == 0)
            {
                    return 0;
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((this.<丅不丙丌丟业一业丂>k__BackingField.StartDate) & 1) == 0)
            {
                    return 0;
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((this.<丅不丙丌丟业一业丂>k__BackingField.EndDate) & 1) == 0)
            {
                    return 0;
            }
            
            if((( & 1) != 0) && (( & 1) != 0))
            {
                    val_10 = this.<丅不丙丌丟业一业丂>k__BackingField.StartDate.丐丏七丌丕丗业且上();
                if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()}, t2:  new System.DateTime() {dateData = val_10})) == true)
            {
                    return 0;
            }
            
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            val_9 = ;
            if(((val_9 & 1) == 0) || (((-388474400) & 1) == 0))
            {
                    return 0;
            }
            
            val_9 = this.<丅不丙丌丟业一业丂>k__BackingField.StartDate.丐丏七丌丕丗业且上();
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_9}, d2:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()});
            val_10 = val_7._ticks;
            return 0;
        }
        public System.Nullable<System.TimeSpan> 丙世丑丅丒丑业与不()
        {
            ulong val_9;
            ulong val_10;
            val_9 = this;
            System.Nullable<System.DateTime> val_1 = this.丅丁丐与丗丅且专丒();
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((-388296848) & 1) == 0)
            {
                    return 0;
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((this.<丅不丙丌丟业一业丂>k__BackingField.StartDate) & 1) == 0)
            {
                    return 0;
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(((this.<丅不丙丌丟业一业丂>k__BackingField.EndDate) & 1) == 0)
            {
                    return 0;
            }
            
            if((( & 1) != 0) && (( & 1) != 0))
            {
                    val_10 = this.<丅不丙丌丟业一业丂>k__BackingField.EndDate.丐丏七丌丕丗业且上();
                if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()}, t2:  new System.DateTime() {dateData = val_10})) == true)
            {
                    return 0;
            }
            
            }
            
            val_10 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            val_9 = ;
            if(((val_9 & 1) == 0) || (((-388296864) & 1) == 0))
            {
                    return 0;
            }
            
            val_9 = this.<丅不丙丌丟业一业丂>k__BackingField.EndDate.丐丏七丌丕丗业且上();
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_9}, d2:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()});
            val_10 = val_7._ticks;
            return 0;
        }
        private System.Collections.Generic.List<Rilisoft.与专丒丞丐一丒丂东> 东丅丁上东下不东丌()
        {
            if(this.与丌与七丕七丆丘且 != null)
            {
                    return (System.Collections.Generic.List<Rilisoft.与专丒丞丐一丒丂东>)val_2;
            }
            
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<Rilisoft.与专丒丞丐一丒丂东>(source:  System.Linq.Enumerable.Cast<Rilisoft.与专丒丞丐一丒丂东>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField));
            this.与丌与七丕七丆丘且 = val_2;
            return (System.Collections.Generic.List<Rilisoft.与专丒丞丐一丒丂东>)val_2;
        }
        internal int 上丕丘丅上七业丈丂()
        {
            string val_2;
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) == 100)
            {
                    val_2 = "feature.threechests";
            }
            else
            {
                    if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 200)
            {
                    if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 300)
            {
                goto label_10;
            }
            
            }
            
                val_2 = "feature.roulette";
            }
            
            label_10:
            int val_1 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  val_2);
            if(val_1 != 2147483647)
            {
                    return val_1;
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  this.<丅不丙丌丟业一业丂>k__BackingField.MinimumLevel);
            }
            
            return 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  this.<丅不丙丌丟业一业丂>k__BackingField.MinimumLevel);
        }
        internal bool 丈丐丞丐上丑且丕万()
        {
            var val_12;
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  this.上丕丘丅上七业丈丂())) == false)
            {
                    return false;
            }
            
            if(this.专丞丁丝专丘七万丏() == false)
            {
                    return false;
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 200)
            {
                    if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 300)
            {
                    return false;
            }
            
            }
            
            val_12 = 0;
            goto label_7;
            label_15:
            if(this.东丅丁上东下不东丌().Item[0].丟丘不丙不丘丑上万() != false)
            {
                    if(this.东丅丁上东下不东丌().Item[0].七丝丝丈七三丝丘一() == false)
            {
                    return false;
            }
            
            }
            
            val_12 = 1;
            label_7:
            if(val_12 < this.东丅丁上东下不东丌().Count)
            {
                goto label_15;
            }
            
            return false;
        }
        internal bool 专丞丁丝专丘七万丏()
        {
            var val_14;
            var val_16;
            var val_17;
            var val_18;
            System.Nullable<System.DateTime> val_1 = this.丅丁丐与丗丅且专丒();
            if(((-387607200) & 1) == 0)
            {
                goto label_1;
            }
            
            if((((this.<丅不丙丌丟业一业丂>k__BackingField.StartDate) & 1) == 0) || (((this.<丅不丙丌丟业一业丂>k__BackingField.EndDate) & 1) == 0))
            {
                goto label_11;
            }
            
            val_14 = 0;
            if((( & 1) == 0) || (( & 1) == 0))
            {
                goto label_17;
            }
            
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = this.<丅不丙丌丟业一业丂>k__BackingField.StartDate.丐丏七丌丕丗业且上()}, t2:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()})) == false)
            {
                goto label_11;
            }
            
            val_14 = 0;
            if((( & 1) == 0) || (((-387607216) & 1) == 0))
            {
                goto label_17;
            }
            
            val_14 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_1.HasValue.丐丏七丌丕丗业且上()}, t2:  new System.DateTime() {dateData = this.<丅不丙丌丟业一业丂>k__BackingField.EndDate.丐丏七丌丕丗业且上()});
            goto label_17;
            label_1:
            val_16 = 0;
            return (bool)(val_14 != val_18) ? 1 : 0;
            label_11:
            val_14 = 0;
            label_17:
            val_17 = 0;
            val_18 = 0;
            goto label_19;
            label_23:
            val_18 = val_18 | this.丙丗丝一丏丅专丁不.Item[0].七丂丌丈丄专丄三世();
            val_17 = 1;
            label_19:
            if(val_17 < this.丙丗丝一丏丅专丁不.Count)
            {
                goto label_23;
            }
            
            return (bool)(val_14 != val_18) ? 1 : 0;
        }
        private System.Nullable<System.DateTime> 丅丁丐与丗丅且专丒()
        {
            var val_6;
            System.Nullable<System.DateTime> val_7;
            var val_8;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) == 0)
            {
                    val_6 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
                if((this.与下丒丙丟丟丛不丈 & 1) == 0)
            {
                    return 0;
            }
            
            }
            
            val_6 = public System.Boolean System.Nullable<System.DateTime>::get_HasValue();
            if(( & 1) != 0)
            {
                    this.与下丒丙丟丟丛不丈 = val_1;
                mem[1152921542874114736] = ???;
                val_7 = this.与下丒丙丟丟丛不丈;
                this.丄专丗不万丙丑业丅 = UnityEngine.Time.realtimeSinceStartup;
                return 0;
            }
            
            float val_4 = UnityEngine.Time.realtimeSinceStartup - this.丄专丗不万丙丑业丅;
            if(val_4 > 300f)
            {
                    val_8 = 0;
                val_7 = 0;
                mem2[0] = 0;
                mem2[0] = 0;
                return 0;
            }
            
            System.DateTime val_5 = this.与下丒丙丟丟丛不丈.AddSeconds(value:  (double)val_4);
            val_6 = val_5.dateData;
            return 0;
        }
        public bool 三且丈丂三专专业丟()
        {
            Rilisoft.上专业三丟丁丞专下 val_1 = this.且丌三丙丙与与丝世();
            if(val_1 == null)
            {
                    return (bool)(this <= (BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId))) ? 1 : 0;
            }
            
            this = val_1.丟丂丞不专丆万丒世();
            return (bool)(this <= (BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId))) ? 1 : 0;
        }
        public Rilisoft.上专业三丟丁丞专下 不七丘丙不三丗业上()
        {
            var val_3;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_5;
            var val_6;
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField) != null)
            {
                    val_3 = null;
                val_3 = null;
                val_5 = 丛且世丐丆上七业丁.<>c.<>9__164_0;
                if(val_5 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::下东丏丟丂万丗世且(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__164_0 = val_5;
            }
            
                Rilisoft.上专业三丟丁丞专下 val_2 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, predicate:  val_1);
                return (Rilisoft.上专业三丟丁丞专下)val_6;
            }
            
            val_6 = 0;
            return (Rilisoft.上专业三丟丁丞专下)val_6;
        }
        public bool 下一三万丝丟丐丒丆()
        {
            return (bool)(this.不七丘丙不三丗业上() != 0) ? 1 : 0;
        }
        public bool 丕丒丙七丘丈丙且丂()
        {
            var val_5;
            Rilisoft.上专业三丟丁丞专下 val_6 = this.不七丘丙不三丗业上();
            if(val_6 == null)
            {
                    return (bool)(val_6.Count > 0) ? 1 : 0;
            }
            
            if(this.下丂丆丒三丑丌东丒 < val_6.丂丙丐丆丝上万业世())
            {
                    val_5 = 0;
                return (bool)(val_6.Count > 0) ? 1 : 0;
            }
            
            val_6 = val_6;
            return (bool)(val_6.Count > 0) ? 1 : 0;
        }
        public Rilisoft.万一丐业丒丆丈世丅 丝丁丅丆丌丗丌丛丌()
        {
            return (Rilisoft.万一丐业丒丆丈世丅)this.<丞一世丒上丂下丁丅>k__BackingField;
        }
        private void 且七丒不七丄丈与丝(Rilisoft.万一丐业丒丆丈世丅 丙业与丙丗丝不丈东)
        {
            this.<丞一世丒上丂下丁丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丄三丐丟丗丄丟上丞()
        {
            return (System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>)this.<丙丌丅丝丘与三丗丑>k__BackingField;
        }
        private void 丁万下丐一业下与专(System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丙业与丙丗丝不丈东)
        {
            this.<丙丌丅丝丘与三丗丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丄与丟丅丐不丂专业()
        {
            return (System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>)this.<专丄丌丑丘世丐专丟>k__BackingField;
        }
        private void 不丅三丐业丁业丟丅(System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 丙业与丙丗丝不丈东)
        {
            this.<专丄丌丑丘世丐专丟>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> 专丌丙上东丙专丅丏()
        {
            return (System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>)this.丙丗丝一丏丅专丁不;
        }
        public int 丂世上东丞且丏丝丗()
        {
        
        }
        private void 丅三一专丐丗丏一下(int 丙业与丙丗丝不丈东)
        {
            int val_7 = 丙业与丙丗丝不丈东;
            Rilisoft.上专业三丟丁丞专下 val_1 = this.不七丘丙不三丗业上();
            if(this.不七丘丙不三丗业上() != null)
            {
                    val_7 = UnityEngine.Mathf.Min(a:  val_7 = 丙业与丙丗丝不丈东, b:  this.不七丘丙不三丗业上().丂丙丐丆丝上万业世());
            }
            
            int val_6 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.下丂丆丒三丑丌东丒 = 0;
            mem[1152921542875706808] = 0;
        }
        internal bool 丟丗一丟丒丄丄丆丂()
        {
            if(this.丂丆丅丁丙一丞丗丏.世三丞丅丑丌丈丈一() >= 1)
            {
                    Rilisoft.丛且世丐丆上七业丁.丏丙与专世丟丄丒丈(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId, 丁业丘三丈上且丐丈:  true);
                this.丂丆丅丁丙一丞丗丏.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return Rilisoft.丛且世丐丆上七业丁.丞丗丙万丛丟丂丆丄(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId);
            }
            
            return Rilisoft.丛且世丐丆上七业丁.丞丗丙万丛丟丂丆丄(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId);
        }
        internal void 丘丌不与丌丌不专丒(bool 丙业与丙丗丝不丈东)
        {
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            Rilisoft.丛且世丐丆上七业丁.丏丙与专世丟丄丒丈(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId, 丁业丘三丈上且丐丈:  丙业与丙丗丝不丈东);
        }
        private static void 丏丙与专世丟丄丒丈(int 丟丟丄专上丟丁丐丝, bool 丁业丘三丈上且丐丈)
        {
            int val_16;
            System.Collections.Generic.List<System.Int32> val_17;
            var val_19;
            var val_21;
            val_16 = 丟丟丄专上丟丁丐丝;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  100))) != false)
            {
                    val_17 = null;
                val_17 = new System.Collections.Generic.List<System.Int32>();
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_17 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            }
            
            if(丁业丘三丈上且丐丈 == false)
            {
                goto label_15;
            }
            
            if((val_17.Contains(item:  val_16)) == true)
            {
                    return;
            }
            
            val_19 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            val_17.Add(item:  val_16);
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_19 = 0;
            goto label_25;
            label_15:
            if((val_17.Contains(item:  val_16)) == false)
            {
                    return;
            }
            
            val_21 = public System.Boolean System.Collections.Generic.List<System.Int32>::Remove(System.Int32 item);
            bool val_10 = val_17.Remove(item:  val_16);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = 0;
            goto label_35;
            label_25:
            val_16 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_17);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  100, 丙业与丙丗丝不丈东:  val_16);
            return;
            label_35:
            val_16 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_17);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  100, 丙业与丙丗丝不丈东:  val_16);
        }
        private static bool 丞丗丙万丛丟丂丆丄(int 丟丟丄专上丟丁丐丝)
        {
            var val_8;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  100))) != false)
            {
                    val_8 = 0;
                return (bool)val_8.Contains(item:  丟丟丄专上丟丁丐丝);
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            return (bool)val_8.Contains(item:  丟丟丄专上丟丁丐丝);
        }
        public string 丑丐丏丌丑下一丑丒()
        {
            string val_32;
            string val_33;
            val_32 = this.丗世且丅丒专上丛不;
            if(val_32 != null)
            {
                    return val_33;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "pg_birthday")) == false)
            {
                goto label_3;
            }
            
            val_33 = "Key_3389";
            goto label_86;
            label_3:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "4july")) == false)
            {
                goto label_6;
            }
            
            val_33 = "Key_3535";
            goto label_86;
            label_6:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "multi_chests")) != true)
            {
                    if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "super_lottery_basic")) == false)
            {
                goto label_11;
            }
            
            }
            
            label_16:
            val_33 = "Key_3900";
            label_86:
            label_88:
            this.丗世且丅丒专上丛不 = val_33;
            return val_33;
            label_11:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "homecoming")) == false)
            {
                goto label_13;
            }
            
            goto label_86;
            label_13:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "halloween")) == true)
            {
                goto label_16;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "thanksgiving_chests")) == false)
            {
                goto label_18;
            }
            
            goto label_86;
            label_18:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "sets")) == false)
            {
                goto label_21;
            }
            
            goto label_86;
            label_21:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "christmas2")) == false)
            {
                goto label_24;
            }
            
            goto label_86;
            label_24:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "new_year2")) == false)
            {
                goto label_27;
            }
            
            goto label_86;
            label_27:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "oriental_lottery_v3")) == false)
            {
                goto label_30;
            }
            
            goto label_86;
            label_30:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "magic_chests")) == false)
            {
                goto label_33;
            }
            
            goto label_86;
            label_33:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "exoskeletons_v3")) == true)
            {
                goto label_86;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "roulette")) == false)
            {
                goto label_38;
            }
            
            goto label_86;
            label_38:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "sniper_tournament")) == false)
            {
                goto label_41;
            }
            
            goto label_86;
            label_41:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "sniper2_roulette")) == false)
            {
                goto label_44;
            }
            
            goto label_86;
            label_44:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "BTroulette")) == false)
            {
                goto label_47;
            }
            
            goto label_86;
            label_47:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "BTchests")) == false)
            {
                goto label_50;
            }
            
            goto label_86;
            label_50:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "Roulette_time_traveller2")) == false)
            {
                goto label_53;
            }
            
            goto label_86;
            label_53:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "halloween_roulette")) == false)
            {
                goto label_56;
            }
            
            goto label_86;
            label_56:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "eco_roulette")) == false)
            {
                goto label_59;
            }
            
            goto label_86;
            label_59:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "thanksgiving_chests")) == true)
            {
                goto label_86;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "thanksgiving_roulette")) == false)
            {
                goto label_64;
            }
            
            goto label_86;
            label_64:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "new_year_roulette")) == false)
            {
                goto label_67;
            }
            
            goto label_86;
            label_67:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "Alien_Santa_roulette")) == false)
            {
                goto label_70;
            }
            
            goto label_86;
            label_70:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "super_soldier_roulette")) == false)
            {
                goto label_73;
            }
            
            goto label_86;
            label_73:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "big_b_roulette")) == false)
            {
                goto label_76;
            }
            
            goto label_86;
            label_76:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "super_villain_roulette")) == false)
            {
                goto label_79;
            }
            
            goto label_86;
            label_79:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "Zombie")) == false)
            {
                goto label_82;
            }
            
            goto label_86;
            label_82:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "Infected")) == false)
            {
                goto label_85;
            }
            
            goto label_86;
            label_85:
            string val_31 = System.String.Format(format:  "GameEvent_{0}_Title", arg0:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
            goto label_88;
        }
        public string 七业丆且丅丘上丞丞()
        {
            string val_27;
            string val_28;
            val_27 = this.上丄丑丙丘世上万丗;
            if(val_27 != null)
            {
                    return val_28;
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "pg_birthday")) == 0)
            {
                goto label_4;
            }
            
            val_28 = "Key_3538";
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "4july")) == 0)
            {
                goto label_84;
            }
            
            if((((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "multi_chests")) == 0) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "super_lottery_basic")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "thanksgiving_chests")) == 0))
            {
                goto label_37;
            }
            
            if((((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "homecoming")) == 0) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "halloween")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sets")) == 0))
            {
                goto label_84;
            }
            
            if(((((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "christmas2")) == 0) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "new_year2")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "oriental_lottery_v3")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "magic_chests")) == 0))
            {
                goto label_37;
            }
            
            if((((((((((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "exoskeletons_v3")) == 0) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "roulette")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper_tournament")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper2_roulette")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "BTroulette")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "BTchests")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "Roulette_time_traveller2")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "eco_roulette")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "thanksgiving_roulette")) == 0))
            {
                goto label_84;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "new_year_roulette")) == false)
            {
                goto label_66;
            }
            
            val_28 = "Key_6548";
            goto label_84;
            label_4:
            val_28 = "Key_3393";
            goto label_84;
            label_37:
            val_28 = "Key_3938";
            label_84:
            this.上丄丑丙丘世上万丗 = val_28;
            return val_28;
            label_66:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "Alien_Santa_roulette")) == false)
            {
                goto label_78;
            }
            
            goto label_84;
            label_78:
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "super_soldier_roulette")) == false)
            {
                goto label_81;
            }
            
            goto label_84;
            label_81:
            var val_26 = ((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "big_b_roulette")) != true) ? "Key_6981" : (val_28);
            goto label_84;
        }
        public string 丟万丏且上业丐丈一()
        {
            string val_5;
            string val_6;
            val_5 = this.东丛万丘丂丗丘丗且;
            if(val_5 != null)
            {
                    return val_6;
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "4july")) == 0)
            {
                goto label_4;
            }
            
            val_6 = "Key_5073";
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper_tournament")) == 0)
            {
                goto label_10;
            }
            
            var val_4 = ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper2_roulette")) == 0) ? (val_6) : "Key_3411";
            goto label_10;
            label_4:
            val_6 = "Key_3537";
            label_10:
            this.东丛万丘丂丗丘丗且 = val_6;
            return val_6;
        }
        public string 不丅且万丐专丄丌丂()
        {
            string val_8;
            string val_9;
            val_8 = this.丈丏上丏业丑不丌七;
            if(val_8 != null)
            {
                    return val_9;
            }
            
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "4july")) == 0)
            {
                goto label_4;
            }
            
            if((((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "christmas2")) == 0) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "new_year2")) == 0)) || ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "oriental_lottery_v3")) == 0))
            {
                goto label_13;
            }
            
            val_9 = "Key_5089";
            if((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper_tournament")) == 0)
            {
                goto label_20;
            }
            
            var val_7 = ((this.<丅不丙丌丟业一业丂>k__BackingField.EventId.IndexOf(value:  "sniper2_roulette")) == 0) ? (val_9) : "Key_3432";
            goto label_20;
            label_13:
            val_9 = "Key_4770";
            goto label_20;
            label_4:
            val_9 = "Key_3536";
            label_20:
            this.丈丏上丏业丑不丌七 = val_9;
            return val_9;
        }
        public string 专且丝与上下万与丅()
        {
            return (string)((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "4july")) != true) ? "ribbon_bank_icon" : "key_icon1";
        }
        public string 东不上丑丞七丑丅丗()
        {
            if((this.<丅不丙丌丟业一业丂>k__BackingField) != null)
            {
                    return System.String.Format(format:  "{0}{1}", arg0:  "menu_music_event_", arg1:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
            }
            
            return System.String.Format(format:  "{0}{1}", arg0:  "menu_music_event_", arg1:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
        }
        public string 丐与丄世三丐不丁丛()
        {
            string val_3;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丞世下业丈上丞丅下)) != false)
            {
                    this.丞世下业丈上丞丅下 = Rilisoft.丛且世丐丆上七业丁.丆丆丏丄丈丝丝业不(丟丟丄专上丟丁丐丝:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId);
                return val_3;
            }
            
            val_3 = this.丞世下业丈上丞丅下;
            return val_3;
        }
        public static void 东东丞三专丏业万丑(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒 != 1152921505458446352);
        
        }
        public static void 丛业一万下不丈丑七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒 != 1152921505458446352);
        
        }
        public Rilisoft.上专业三丟丁丞专下 且丌三丙丙与与丝世()
        {
            var val_3;
            if(this.三一丙不业丛丙业七 >= 1)
            {
                    Rilisoft.上专业三丟丁丞专下 val_2 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丛且世丐丆上七业丁::七丐丞丁丘丝专丞万(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)));
                return (Rilisoft.上专业三丟丁丞专下)val_3;
            }
            
            val_3 = 0;
            return (Rilisoft.上专业三丟丁丞专下)val_3;
        }
        public void 不丌东丑丏丞丛丄一(Rilisoft.上专业三丟丁丞专下 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    Rilisoft.GameEventChestData val_1 = 丙业与丙丗丝不丈东.丁专丗万三上丟三丆();
                this.三一丙不业丛丙业七 = val_1.ChestId;
                if(this.三一丙不业丛丙业七 == val_1.ChestId)
            {
                    return;
            }
            
                if(Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒 == null)
            {
                    return;
            }
            
                Rilisoft.丛且世丐丆上七业丁.丞丝业丁下丛丕一丒.Invoke();
                return;
            }
            
            this.三一丙不业丛丙业七 = 0;
        }
        public void Dispose()
        {
            一下丛与丛丛万万丏.丁丘世丁丝七且一丁(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void Rilisoft.丛且世丐丆上七业丁::丏专丝丗与下丟三丛(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        }
        public void 丆丏专丘丌且丅三一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丐丛万丐丏且丝不, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丐丛万丐丏且丝不 != 1152921542879042544);
        
        }
        public void 下丕与一业丌且丝丗(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丐丛万丐丏且丝不, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丐丛万丐丏且丝不 != 1152921542879179120);
        
        }
        public void 丘万丒丕丙丗丄一丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.万丏东且丈丕专丝且, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丏东且丈丕专丝且 != 1152921542879315704);
        
        }
        public void 丟业丁丟丑专世丅丗(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.万丏东且丈丕专丝且, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丏东且丈丕专丝且 != 1152921542879452280);
        
        }
        public void 丅不丐一丗丐丞丟丄(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.与丕丕七不丝专专丛, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丕丕七不丝专专丛 != 1152921542879588864);
        
        }
        public void 丘世不丌业丞丄与丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.与丕丕七不丝专专丛, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丕丕七不丝专专丛 != 1152921542879725440);
        
        }
        public void 丑七丂丌世与七丏与(Rilisoft.GameEventData 一丐丗丁丞丆丅丟丄)
        {
            this.<丅不丙丌丟业一业丂>k__BackingField = 一丐丗丁丞丆丅丟丄;
            int val_2 = Progress.七七世万专丕丁上业.不世丗丞丙丅丐丙丁().丕丂丄丙丌丒丝丑丆(丅且三万丘丙业丙丗:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId);
            this.丄万丒下丝不专丄不();
            this.与丄丂且下丄丑丑丑();
            this.与丌与七丕七丆丘且 = 0;
        }
        internal void 万丛丄丝且上丐丗丕(int 丌丒丝东丌下丕丁丅)
        {
            var val_5;
            this.丅三一专丐丗丏一下(丙业与丙丗丝不丈东:  this.下丂丆丒三丑丌东丒 + 丌丒丝东丌下丕丁丅);
            val_5 = null;
            val_5 = null;
            if((丛且世丐丆上七业丁.<>c.<>9__222_0) == null)
            {
                goto label_5;
            }
            
            label_11:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丙丐三丗一丆不丙丙(丅东专与不三丂丁丝:  this, 丌且丐专七丏与丟丌:  this.<丙丌丅丝丘与三丗丑>k__BackingField.Find(match:  丛且世丐丆上七业丁.<>c.<>9__222_0));
            return;
            label_5:
            丛且世丐丆上七业丁.<>c.<>9__222_0 = new System.Predicate<Rilisoft.上专业三丟丁丞专下>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::与丂丞一丞丂万丙业(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌));
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField) != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        public void 世且丙丑丌万丁一万()
        {
            if(this.丛丘丒丛丟世万与世 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丛丘丒丛丟世万与世);
                this.丛丘丒丛丟世万与世 = 0;
            }
            
            this.丛丘丒丛丟世万与世 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丌与丙丕且丑丂下丝());
        }
        private System.Collections.IEnumerator 丌与丙丕且丑丂下丝()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丛且世丐丆上七业丁.专万不七丆丄不丕丙();
        }
        private void 丄万丒下丝不专丄不()
        {
            var val_3;
            Rilisoft.GameEventData val_26;
            string val_27;
            Rilisoft.与专丒丞丐一丒丂东 val_28;
            Rilisoft.GameEventData val_29;
            string val_30;
            var val_31;
            var val_32;
            var val_33;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_35;
            var val_36;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_38;
            List.Enumerator<T> val_1 = this.<丅不丙丌丟业一业丂>k__BackingField.Chests.GetEnumerator();
            label_30:
            if(((-380923200) & 1) == 0)
            {
                goto label_3;
            }
            
            new 丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑() = new System.Object();
            .丄丌丟东专业丗丟丆 = val_3.丐丏七丌丕丗业且上();
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 200)
            {
                    if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 300)
            {
                goto label_8;
            }
            
            }
            
            if((Rilisoft.丛且世丐丆上七业丁.丘丛与丏丈丑一丌丒(一丐丗丁丞丆丅丟丄:  (丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑)[1152921542880681760].丄丌丟东专业丗丟丆)) == false)
            {
                goto label_9;
            }
            
            label_8:
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_7 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new 丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑(), method:  System.Boolean 丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑::三丝世丝丟丅丟丄丑(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
            if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.丙丗丝一丏丅专丁不, predicate:  null)) == null)
            {
                goto label_10;
            }
            
            val_26 = this.<丅不丙丌丟业一业丂>k__BackingField;
            if(val_26 == null)
            {
                goto label_11;
            }
            
            val_27 = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            goto label_30;
            label_9:
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_9 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new 丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑(), method:  System.Boolean 丛且世丐丆上七业丁.丑丁上丘丛东丙丒丑::不三业一与丌一丆且(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
            Rilisoft.上专业三丟丁丞专下 val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.丙丗丝一丏丅专丁不, predicate:  null);
            if(val_10 == null)
            {
                goto label_30;
            }
            
            bool val_11 = this.丙丗丝一丏丅专丁不.Remove(item:  val_10);
            goto label_30;
            label_10:
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 200)
            {
                    if((this.<丅不丙丌丟业一业丂>k__BackingField.Type) != 300)
            {
                goto label_19;
            }
            
            }
            
            val_28 = new Rilisoft.与专丒丞丐一丒丂东();
            val_28 = new Rilisoft.与专丒丞丐一丒丂东();
            goto label_20;
            label_11:
            val_27 = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            if((this.<丅不丙丌丟业一业丂>k__BackingField) == null)
            {
                goto label_21;
            }
            
            val_26 = this.<丅不丙丌丟业一业丂>k__BackingField;
            goto label_30;
            label_19:
            val_28 = new Rilisoft.与丆且丘丗丝万丁丄();
            val_28 = new Rilisoft.与丆且丘丗丝万丁丄();
            label_20:
            val_29 = this.<丅不丙丌丟业一业丂>k__BackingField;
            if(val_29 == null)
            {
                goto label_23;
            }
            
            val_30 = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            goto label_26;
            label_23:
            val_30 = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            if((this.<丅不丙丌丟业一业丂>k__BackingField) == null)
            {
                goto label_25;
            }
            
            val_29 = this.<丅不丙丌丟业一业丂>k__BackingField;
            goto label_26;
            label_21:
            val_26 = 0;
            goto label_30;
            label_25:
            val_29 = 0;
            label_26:
            this.丙丗丝一丏丅专丁不.Add(item:  new Rilisoft.与丆且丘丗丝万丁丄());
            goto label_30;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_31 = 0;
            goto label_52;
            label_59:
            .丐下丝丘丑丟丟丗丌 = this.丙丗丝一丏丅专丁不.Item[0];
            if((System.Linq.Enumerable.Any<Rilisoft.GameEventChestData>(source:  this.<丅不丙丌丟业一业丂>k__BackingField.Chests, predicate:  new System.Func<Rilisoft.GameEventChestData, System.Boolean>(object:  new 丛且世丐丆上七业丁.不世丕一丞下业丟丆(), method:  System.Boolean 丛且世丐丆上七业丁.不世丕一丞下业丟丆::世丏一丞丏丟世东丌(Rilisoft.GameEventChestData 丁丂专业丁丅丅丈丙)))) != true)
            {
                    bool val_18 = this.丙丗丝一丏丅专丁不.Remove(item:  (丛且世丐丆上七业丁.不世丕一丞下业丟丆)[1152921542880808736].丐下丝丘丑丟丟丗丌);
            }
            
            val_31 = 1;
            label_52:
            if(val_31 < this.丙丗丝一丏丅专丁不.Count)
            {
                goto label_59;
            }
            
            val_32 = null;
            val_33 = 1152921542109800128;
            val_35 = 丛且世丐丆上七业丁.<>c.<>9__225_0;
            if(val_35 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_20 = null;
                val_35 = val_20;
                val_20 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丛且世丐丆上七业丁.<>c::丘丆丈丘丛上丈丑世(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__225_0 = val_35;
            }
            
            System.Collections.Generic.List<TSource> val_22 = System.Linq.Enumerable.ToList<Rilisoft.上专业三丟丁丞专下>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.上专业三丟丁丞专下, System.Int32>(source:  this.丙丗丝一丏丅专丁不, keySelector:  val_20));
            val_36 = null;
            val_36 = null;
            val_38 = 丛且世丐丆上七业丁.<>c.<>9__225_1;
            if(val_38 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_23 = null;
                val_38 = val_23;
                val_23 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丗丗七丑万七丞东三(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__225_1 = val_38;
            }
            
            this.业丂且丁丅专丙丁丝 = System.Linq.Enumerable.ToList<Rilisoft.上专业三丟丁丞专下>(source:  System.Linq.Enumerable.Where<Rilisoft.上专业三丟丁丞专下>(source:  this.丙丗丝一丏丅专丁不, predicate:  val_23));
            if(this.丄丐丛万丐丏且丝不 == null)
            {
                    return;
            }
            
            this.丄丐丛万丐丏且丝不.Invoke();
        }
        public void 与丄丂且下丄丑丑丑()
        {
            var val_5;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_41;
            var val_42;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_44;
            var val_45;
            var val_46;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_48;
            var val_49;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_51;
            Rilisoft.上专业三丟丁丞专下 val_52;
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField) == null)
            {
                    this.<丙丌丅丝丘与三丗丑>k__BackingField = new System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>();
            }
            
            System.Nullable<System.DateTime> val_2 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-380452784) & 1) == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this.丙丗丝一丏丅专丁不.GetEnumerator();
            val_36 = 1152921540871087376;
            val_37 = 1152921540871088400;
            val_38 = 0;
            label_17:
            label_13:
            if(((-380452816) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if((val_6 & 1) == 0)
            {
                goto label_8;
            }
            
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField.Contains(item:  val_6)) == true)
            {
                goto label_13;
            }
            
            goto label_11;
            label_8:
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField.Contains(item:  val_6)) == false)
            {
                goto label_13;
            }
            
            bool val_9 = this.<丙丌丅丝丘与三丗丑>k__BackingField.Remove(item:  val_6);
            goto label_17;
            label_11:
            this.<丙丌丅丝丘与三丗丑>k__BackingField.Add(item:  val_6);
            goto label_17;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_38 & 1) == 0)
            {
                    return;
            }
            
            val_39 = null;
            val_39 = null;
            val_41 = 丛且世丐丆上七业丁.<>c.<>9__226_0;
            if(val_41 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_10 = null;
                val_41 = val_10;
                val_10 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丛且世丐丆上七业丁.<>c::丛丅万丑世丐且丟丗(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__226_0 = val_41;
            }
            
            System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<Rilisoft.上专业三丟丁丞专下>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.上专业三丟丁丞专下, System.Int32>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, keySelector:  val_10));
            this.<丙丌丅丝丘与三丗丑>k__BackingField = val_12;
            if(val_12.Count < 5)
            {
                goto label_41;
            }
            
            goto label_35;
            label_44:
            val_42 = null;
            val_42 = null;
            val_44 = 丛且世丐丆上七业丁.<>c.<>9__226_3;
            if(val_44 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_14 = null;
                val_44 = val_14;
                val_14 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丛丂丕三不丆三丒一(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__226_3 = val_44;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_15 = System.Linq.Enumerable.Last<Rilisoft.上专业三丟丁丞专下>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, predicate:  val_14);
            if(val_15 == null)
            {
                goto label_41;
            }
            
            bool val_16 = this.<丙丌丅丝丘与三丗丑>k__BackingField.Remove(item:  val_15);
            label_35:
            if((this.<丙丌丅丝丘与三丗丑>k__BackingField.Count) > 4)
            {
                goto label_44;
            }
            
            label_41:
            val_45 = null;
            val_38 = 1152921542764797184;
            val_46 = 1152921540871087376;
            val_36 = 1152921540871086352;
            val_48 = 丛且世丐丆上七业丁.<>c.<>9__226_1;
            if(val_48 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_18 = null;
                val_48 = val_18;
                val_18 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丙七丄七丆丄丆丄与(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__226_1 = val_48;
            }
            
            this.<专丄丌丑丘世丐专丟>k__BackingField = System.Linq.Enumerable.ToList<Rilisoft.上专业三丟丁丞专下>(source:  System.Linq.Enumerable.Where<Rilisoft.上专业三丟丁丞专下>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, predicate:  val_18));
            val_37 = 1152921505459986432;
            System.Collections.Generic.IEnumerable<System.Int32> val_22 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂丂丕不丞下下丝丅(丞丕丟丁且丛三丕不:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId);
            if(val_22 == null)
            {
                goto label_73;
            }
            
            List.Enumerator<T> val_23 = this.丙丗丝一丏丅专丁不.GetEnumerator();
            label_65:
            if(((-380452816) & 1) == 0)
            {
                goto label_57;
            }
            
            string val_24 = val_5.丐丏七丌丕丗业且上();
            if(((System.Linq.Enumerable.Contains<System.Int32>(source:  val_22, value:  val_24.业上丙丞丐丄丆丅七())) == false) || ((this.<丙丌丅丝丘与三丗丑>k__BackingField.Contains(item:  val_24)) == true))
            {
                goto label_65;
            }
            
            var val_28 = (((System.String.__il2cppRuntimeField_typeHierarchy + (Rilisoft.与专丒丞丐一丒丂东.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_24) : 0;
            goto label_65;
            label_57:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_37 = 1152921505459986432;
            label_73:
            val_49 = null;
            val_49 = null;
            val_51 = 丛且世丐丆上七业丁.<>c.<>9__226_2;
            if(val_51 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32> val_29 = null;
                val_51 = val_29;
                val_29 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Int32>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丛且世丐丆上七业丁.<>c::一丑世丙丅丑丏丘丞(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__226_2 = val_51;
            }
            
            val_52 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            val_52.丁一丕丐东丑丗丄万(丞丕丟丁且丛三丕不:  this.<丅不丙丌丟业一业丂>k__BackingField.UniqueId, 丞丈丁与丏丌丌丆丂:  System.Linq.Enumerable.Select<Rilisoft.上专业三丟丁丞专下, System.Int32>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, selector:  val_29));
            if(this.且丌三丙丙与与丝世() != null)
            {
                    val_52 = this.且丌三丙丙与与丝世();
                if((this.<丙丌丅丝丘与三丗丑>k__BackingField.Contains(item:  val_52)) != true)
            {
                    this.三一丙不业丛丙业七 = 0;
            }
            
            }
            
            if(this.丄丐丛万丐丏且丝不 == null)
            {
                    return;
            }
            
            this.丄丐丛万丐丏且丝不.Invoke();
        }
        public void Remove()
        {
            if(this.丛丘丒丛丟世万与世 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丛丘丒丛丟世万与世);
                this.丛丘丒丛丟世万与世 = 0;
            }
            
            if(this.万丏东且丈丕专丝且 == null)
            {
                    return;
            }
            
            this.万丏东且丈丕专丝且.Invoke();
        }
        internal static void 丄与三与丌丏丈丕一(string 丟丟丄专上丟丁丐丝)
        {
            string val_1 = System.String.Format(format:  "{0}-spins-count", arg0:  丟丟丄专上丟丁丐丝);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_1)) == false)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_1, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        public bool 丞上世一丘丐业且一(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七, bool 丄丆丂下不丝东丂一)
        {
            object val_15;
            Rilisoft.GameEventItem val_16;
            System.Func<TSource, System.Boolean> val_17;
            Rilisoft.丝丑丂丛万丐丈丘且 val_18;
            丛且世丐丆上七业丁.上丆丛丒丄丑丈丄丄 val_1 = null;
            val_15 = val_1;
            val_1 = new 丛且世丐丆上七业丁.上丆丛丒丄丑丈丄丄();
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            UnityEngine.Debug.LogError(message:  " ************* GameEvent ************* MarkItemAsDropped ");
            val_16 = (丛且世丐丆上七业丁.上丆丛丒丄丑丈丄丄)[1152921542881736160].下丅丙一丂丗丅丝七;
            if(val_16 == null)
            {
                    return (bool)val_16;
            }
            
            if(val_16.AvailableToDrop == false)
            {
                goto label_5;
            }
            
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_3 = null;
            val_17 = val_3;
            val_3 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  val_1, method:  System.Boolean 丛且世丐丆上七业丁.上丆丛丒丄丑丈丄丄::七丁且专丄丟一丏上(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
            Rilisoft.上专业三丟丁丞专下 val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.<丙丌丅丝丘与三丗丑>k__BackingField, predicate:  val_3);
            if(val_4 == null)
            {
                    return (bool)val_16;
            }
            
            val_17 = val_4;
            Rilisoft.GameEventItemContainer val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_17, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  val_1, method:  System.Boolean 丛且世丐丆上七业丁.上丆丛丒丄丑丈丄丄::丗丄丞丑丄丆万丈丆(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)));
            if(val_6 == null)
            {
                    return (bool)val_16;
            }
            
            val_4.下三与丞不且丘丅丝(丒丁东世世丗丅丅丄:  val_6.Id);
            if(this.且丌三丙丙与与丝世() == null)
            {
                goto label_10;
            }
            
            val_15 = this.且丌三丙丙与与丝世().丁丒丝世下丟丑七丐();
            if(丄丆丂下不丝东丂一 == false)
            {
                goto label_12;
            }
            
            goto label_24;
            label_5:
            val_16 = 0;
            return (bool)val_16;
            label_10:
            val_15 = 1;
            if(丄丆丂下不丝东丂一 == true)
            {
                goto label_24;
            }
            
            label_12:
            Rilisoft.GameEventChestData val_11 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            if(val_11.FullDropQueueLength <= 0)
            {
                goto label_18;
            }
            
            Rilisoft.GameEventChestData val_12 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            val_18 = this.下丂丆丒三丑丌东丒;
            if((val_12.FullDropQueueLength - val_18) >= 2)
            {
                goto label_21;
            }
            
            val_15 = 0;
            goto label_22;
            label_18:
            val_18 = this.下丂丆丒三丑丌东丒;
            label_21:
            label_22:
            this.丅三一专丐丗丏一下(丙业与丙丗丝不丈东:  1);
            if((val_11.FullDropQueueLength > 0) && (Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈 != 0))
            {
                    Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈.Invoke(obj:  val_15 - val_18);
            }
            
            label_24:
            val_16 = 1;
            return (bool)val_16;
        }
        private System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 世丐不且专专丄七一(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, int 丄丒丌上丁丂不万东)
        {
            var val_5;
            var val_6;
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_8;
            var val_9;
            val_5 = null;
            if(丄丒丌上丁丂不万东 < 10)
            {
                    val_6 = null;
                val_8 = 丛且世丐丆上七业丁.<>c.<>9__230_1;
                if(val_8 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  丐下丝丘丑丟丟丗丌, predicate:  System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_2 = null));
            }
            
                System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_1 = null;
                val_8 = val_1;
                val_1 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::不下丁丑丞丕丏丕世(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__230_1 = val_8;
                return System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  丐下丝丘丑丟丟丗丌, predicate:  val_2));
            }
            
            val_9 = null;
            val_8 = 丛且世丐丆上七业丁.<>c.<>9__230_0;
            if(val_8 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  丐下丝丘丑丟丟丗丌, predicate:  val_2));
            }
            
            val_8 = val_2;
            val_2 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::不三丅丘且丈丛不丙(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            丛且世丐丆上七业丁.<>c.<>9__230_0 = val_8;
            return System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  丐下丝丘丑丟丟丗丌, predicate:  val_2));
        }
        public bool 丑丈且与丈上丑丂世(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, bool 丑万丌丂上业丏上世, bool 下不业丄一丐万丒世, System.Collections.Generic.List<Rilisoft.上业丝丟东下丏丗业> 丑丗丈丒丏上与三七, out Rilisoft.GameEventItem 下丅丙一丂丗丅丝七, out Rilisoft.GameEventItemContainer 丒丞丙丝与丕业丟不)
        {
            Rilisoft.丛且世丐丆上七业丁 val_107;
            System.Collections.Generic.List<Rilisoft.上业丝丟东下丏丗业> val_108;
            object val_109;
            Rilisoft.丛且世丐丆上七业丁 val_110;
            System.Collections.Generic.IEnumerable<TSource> val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            var val_117;
            System.Predicate<Rilisoft.GameEventItemContainer> val_119;
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_120;
            var val_121;
            var val_122;
            Rilisoft.且丈丞一丞丟与上七 val_124;
            var val_125;
            var val_126;
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_128;
            var val_129;
            var val_130;
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_132;
            string val_133;
            System.Object[] val_134;
            var val_135;
            int val_136;
            System.Collections.Generic.List<Rilisoft.上业丝丟东下丏丗业> val_137;
            var val_138;
            Rilisoft.丝丑丂丛万丐丈丘且 val_139;
            var val_140;
            var val_141;
            int val_142;
            var val_143;
            var val_144;
            var val_146;
            val_107 = 1152921542882388576;
            val_108 = 丑丗丈丒丏上与三七;
            val_109 = 丐下丝丘丑丟丟丗丌;
            val_110 = this;
            下丅丙一丂丗丅丝七 = 0;
            丒丞丙丝与丕业丟不 = 0;
            if(val_109 == null)
            {
                goto label_1;
            }
            
            val_111 = val_109;
            val_112 = 0;
            if(val_109.丐世丑丗且丙万上上() == 0)
            {
                goto label_4;
            }
            
            if(val_109.丐世丑丗且丙万上上() != 1)
            {
                goto label_5;
            }
            
            Rilisoft.GameEventItemContainer val_4 = 丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0);
            if(val_4 == null)
            {
                goto label_7;
            }
            
            val_113 = IndexOf(item:  val_4);
            val_114 = ;
            goto label_9;
            label_4:
            val_115 = null;
            val_115 = null;
            if((丛且世丐丆上七业丁.<>c.<>9__231_1) == null)
            {
                goto label_12;
            }
            
            label_74:
            if((val_111.Exists(match:  丛且世丐丆上七业丁.<>c.<>9__231_1)) == false)
            {
                goto label_14;
            }
            
            val_117 = null;
            val_117 = null;
            val_119 = 丛且世丐丆上七业丁.<>c.<>9__231_2;
            if(val_119 == null)
            {
                    System.Predicate<Rilisoft.GameEventItemContainer> val_7 = null;
                val_119 = val_7;
                val_7 = new System.Predicate<Rilisoft.GameEventItemContainer>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丞丕丑上丘丄丛东丒(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且));
                丛且世丐丆上七业丁.<>c.<>9__231_2 = val_119;
            }
            
            val_120 = val_111.FindAll(match:  val_7);
            if(val_120 != null)
            {
                goto label_21;
            }
            
            goto label_41;
            label_5:
            val_121 = new object[1];
            SpinRule val_10 = val_109.丐世丑丗且丙万上上();
            val_109 = val_10;
            val_121[0] = val_109;
            val_122 = "unsupported spin rule: \'{0}\'";
            goto label_29;
            label_14:
            if((下不业丄一丐万丒世 == false) || (this.七丁东丁丙世丑丅丏.世三丞丅丑丌丈丈一() < 1))
            {
                goto label_32;
            }
            
            int val_12 = this.七丁东丁丙世丑丅丏.世三丞丅丑丌丈丈一();
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_13 = val_12.世丐不且专专丄七一(丐下丝丘丑丟丟丗丌:  val_109, 丄丒丌上丁丂不万东:  val_12);
            val_124 = this.七丁东丁丙世丑丅丏;
            goto label_34;
            label_12:
            val_125 = val_107;
            goto label_72;
            label_32:
            if(this.丕丐与丆丙丌丙丑上.世三丞丅丑丌丈丈一() < 1)
            {
                goto label_41;
            }
            
            int val_15 = this.丕丐与丆丙丌丙丑上.世三丞丅丑丌丈丈一();
            val_124 = this.丕丐与丆丙丌丙丑上;
            label_34:
            val_120 = val_15.世丐不且专专丄七一(丐下丝丘丑丟丟丗丌:  val_109, 丄丒丌上丁丂不万东:  val_15);
            val_124.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
            if(val_120 == null)
            {
                goto label_41;
            }
            
            label_21:
            if(val_120.Count > 0)
            {
                goto label_42;
            }
            
            label_41:
            val_120 = val_111;
            if(this.不七丘丙不三丗业上() == null)
            {
                goto label_60;
            }
            
            Rilisoft.GameEventChestData val_19 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            val_120 = val_111;
            if(val_19.FullDropQueueLength < 1)
            {
                goto label_60;
            }
            
            val_126 = null;
            val_126 = null;
            val_128 = 丛且世丐丆上七业丁.<>c.<>9__231_3;
            if(val_128 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_20 = null;
                val_128 = val_20;
                val_20 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丞丞且丘丕丄专万丆(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__231_3 = val_128;
            }
            
            val_129 = 1152921542881859744;
            val_130 = null;
            val_120 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  val_111, predicate:  val_20));
            val_130 = null;
            val_132 = 丛且世丐丆上七业丁.<>c.<>9__231_4;
            if(val_132 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_23 = null;
                val_132 = val_23;
                val_23 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::丙丘丙丈丌且丂丟丟(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__231_4 = val_132;
                val_129 = 1152921542881859744;
            }
            
            Rilisoft.GameEventChestData val_26 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            int val_106 = val_26.FullDropQueueLength;
            val_106 = val_106 - this.下丂丆丒三丑丌东丒;
            int val_27 = val_120.Count;
            if(val_106 <= val_27)
            {
                goto label_60;
            }
            
            if(val_27 >= 2)
            {
                goto label_61;
            }
            
            goto label_62;
            label_29:
            val_134 = ;
            goto label_70;
            label_7:
            val_135 = 0;
            goto label_71;
            label_72:
            丛且世丐丆上七业丁.<>c.<>9__231_1 = new System.Predicate<Rilisoft.GameEventItemContainer>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛且世丐丆上七业丁.<>c::专且丞丝丂与丝一丂(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且));
            if(val_111 != null)
            {
                goto label_74;
            }
            
            goto label_74;
            label_9:
            var val_34 = ( >= (val_114.Count - 1)) ? 0 : ( + 1);
            label_71:
            val_136 = val_34 & (~(val_34 >> 31));
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_35 = null;
            val_120 = val_35;
            val_35 = new System.Collections.Generic.List<Rilisoft.GameEventItemContainer>();
            goto label_75;
            label_85:
            Rilisoft.GameEventItemContainer val_36 = Item[val_136];
            if(val_36 == null)
            {
                goto label_80;
            }
            
            if(丟丝与丙东世丗丞与() <= 0)
            {
                    if(val_36.ContentType == 3)
            {
                goto label_80;
            }
            
            }
            
            if((世不万丙丏丁丞丄三(万三丂且丆三且丝且:  val_36, 世一一丝三丞丅下业:  false)) == false)
            {
                goto label_80;
            }
            
            if(val_120 != null)
            {
                    val_35.Add(item:  val_36);
            }
            else
            {
                    val_35.Add(item:  val_36);
            }
            
            if(val_35.Count > 5)
            {
                goto label_83;
            }
            
            label_80:
            val_136 = val_136 + 1;
            label_75:
            if(val_136 < Count)
            {
                goto label_85;
            }
            
            label_83:
            val_110 = val_110;
            val_137 = val_108;
            if(val_35.Count != 0)
            {
                goto label_92;
            }
            
            val_35.Add(item:  val_111.Item[0]);
            goto label_92;
            label_61:
            label_62:
            var val_45 = (((UnityEngine.Random.Range(min:  0, max:  101)) & 1) != 0) ? (val_120) : System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  val_111, predicate:  val_23));
            label_60:
            if(val_45 == 0)
            {
                goto label_91;
            }
            
            label_42:
            val_137 = val_108;
            if(val_45.Count != 0)
            {
                goto label_92;
            }
            
            goto label_93;
            label_91:
            val_137 = val_108;
            label_93:
            val_120 = val_111;
            label_92:
            if(this.且丌三丙丙与与丝世() != null)
            {
                    val_138 = this.且丌三丙丙与与丝世().丁丒丝世下丟丑七丐();
            }
            else
            {
                    val_138 = 1;
            }
            
            if(丑万丌丂上业丏上世 == false)
            {
                goto label_106;
            }
            
            Rilisoft.GameEventChestData val_50 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            if(val_50.FullDropQueueLength <= 0)
            {
                goto label_100;
            }
            
            Rilisoft.GameEventChestData val_51 = this.<丅不丙丌丟业一业丂>k__BackingField.FirstChest;
            val_139 = this.下丂丆丒三丑丌东丒;
            if((val_51.FullDropQueueLength - val_139) >= 2)
            {
                goto label_103;
            }
            
            val_140 = 0;
            goto label_104;
            label_100:
            val_139 = this.下丂丆丒三丑丌东丒;
            label_103:
            label_104:
            this.丅三一专丐丗丏一下(丙业与丙丗丝不丈东:  1);
            if((val_50.FullDropQueueLength > 0) && (Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈 != 0))
            {
                    Rilisoft.丛且世丐丆上七业丁.丏丐丑专丈丒丑丁丈.Invoke(obj:  val_138 - val_139);
            }
            
            label_106:
            val_108 = val_110;
            PGCompany.丄丂丌丞丁丙七丆三 val_54 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            List.Enumerator<T> val_55 = val_137.GetEnumerator();
            val_111 = 1152921505458868224;
            goto label_158;
            label_163:
            val_110 = new 丛且世丐丆上七业丁.丅业丞万丕东丅丄与();
            val_110 = new System.Object();
            string val_58 = val_10.丐丏七丌丕丗业且上();
            if(val_110 != null)
            {
                    val_141 = val_110;
                .三且丙丒丄丝丌世丞 = val_58;
            }
            else
            {
                    mem[16] = val_58;
                val_141 = 16;
            }
            
            if(((val_141.不业丙丒丂丞下丆丙() != 100) && (mem[16].不业丙丒丂丞下丆丙() != 1300)) && (mem[16].不业丙丒丂丞下丆丙() != 200))
            {
                    if(mem[16].不业丙丒丂丞下丆丙() != 1000)
            {
                    if(mem[16].不业丙丒丂丞下丆丙() != 1500)
            {
                goto label_124;
            }
            
            }
            
            }
            
            label_162:
            System.Predicate<Rilisoft.GameEventItemContainer> val_64 = new System.Predicate<Rilisoft.GameEventItemContainer>(object:  new 丛且世丐丆上七业丁.丅业丞万丕东丅丄与(), method:  System.Boolean 丛且世丐丆上七业丁.丅业丞万丕东丅丄与::东丂东丝丏丆且丄丁(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且));
            int val_65 = val_120.RemoveAll(match:  null);
            goto label_158;
            label_124:
            if(mem[16].不业丙丒丂丞下丆丙() != 800)
            {
                goto label_140;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_69 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  46, 丞丅上丏丂且下丅与:  mem[16].业上丙丞丐丄丆丅七(), 丂丕丂丏专丂丄丕且:  mem[16].丂丁丏一丙丛业且丌());
            PGCompany.三东丏不丗世丅丌丄 val_70 = val_54.丛丈丏丅丂一不丒业(上七下丘一下三世丏:  val_69);
            if(((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_69)) == false) || ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_70)) == false))
            {
                goto label_140;
            }
            
            val_142 = val_70.业东丅东丌上丗丑不();
            if(val_54 == 0)
            {
                    val_142 = val_142;
            }
            
            int val_107 = val_54.丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_142);
            val_107 = val_69.丂丁丏一丙丛业且丌() + val_107;
            if(val_107 >= (val_54.七丏万丞且丛丌专丞(丞世不丒下上上丝丑:  val_70.业东丅东丌上丗丑不())))
            {
                goto label_162;
            }
            
            label_140:
            if(mem[16].不业丙丒丂丞下丆丙() == 1600)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_81 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  mem[16], 丞丅上丏丂且下丅与:  mem[16].业上丙丞丐丄丆丅七(), 丂丕丂丏专丂丄丕且:  mem[16].丂丁丏一丙丛业且丌());
                if(val_81.丕丐一丙专丛丒丑万() != false)
            {
                    int val_85 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下三东一丐下东与丂(且世丌丆三丙一上丟:  val_81.业东丅东丌上丗丑不());
                if(val_85 != 0)
            {
                    if(mem[16].丂丁丏一丙丛业且丌() >= (PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下丞丝丂万丙三丏上(世且丐丐丑丛东专丟:  val_85)))
            {
                goto label_162;
            }
            
            }
            
            }
            
            }
            
            label_158:
            if(((-379216384) & 1) != 0)
            {
                goto label_163;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            val_143 = 1152921542882392624;
            val_107 = val_108;
            if(val_120 == null)
            {
                
            }
            else
            {
                    if(val_120.Count != 0)
            {
                    PGCompany.丁七丛丑丄丄丂东世.丟丝丏丁三丒丛丒且(丅东专与不三丂丁丝:  this);
                PGCompany.丁七丛丑丄丄丂东世.东丅丅东一与丆与丙(与世丗且丟丁不专丏:  this.<丅不丙丌丟业一业丂>k__BackingField.Type);
                PGCompany.丁七丛丑丄丄丂东世.三丑丈与业上丈世丑();
                PGCompany.丁丁丒丁七丂专下丛 val_92 = null;
                val_110 = val_92;
                val_92 = new PGCompany.丁丁丒丁七丂专下丛(东丆一丝三不世万丙:  val_120, 丅东专与不三丂丁丝:  this, 丐下丝丘丑丟丟丗丌:  val_109, 丐丐万丕丛丑丗丏丁:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丒丝丅与丈七七七丙());
                val_144 = null;
                val_144 = null;
                val_107 = 丛且世丐丆上七业丁.<>c.<>9__231_0;
                if(val_107 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, System.Single> val_94 = null;
                val_107 = val_94;
                val_94 = new System.Func<Rilisoft.GameEventItemContainer, System.Single>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Single 丛且世丐丆上七业丁.<>c::丅丐下东丒丕丑一丁(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且));
                丛且世丐丆上七业丁.<>c.<>9__231_0 = val_107;
            }
            
                Rilisoft.GameEventItemContainer val_95 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<Rilisoft.GameEventItemContainer>(丑东与丅丐丅丂丞业:  val_92.丌丂七丕丕丈丂丑丟(), 丆万丒下万下业且丑:  val_94);
                丒丞丙丝与丕业丟不 = val_95;
                if(val_95 == null)
            {
                    return (bool)val_146;
            }
            
                val_107 = val_107;
                if(专且丌丁丙丂上丘丄() != (与丑世且万丝丈丌七(七不丛丁万丕且丙丞:  丒丞丙丝与丕业丟不)))
            {
                    bool val_98 = 丅丄与三丅丌万三且();
            }
            
                下丅丙一丂丗丅丝七 = 丒丞丙丝与丕业丟不.丙业丈专万下丄丙丏();
                if(val_92.不丐丗丝业丅下丆东() != false)
            {
                    val_107 = val_109.丐世丑丗且丙万上上();
                val_109 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                var val_104 = (val_107 == 1) ? 83 : 85;
                val_109.下且上丛丞一东不不(丈丄不七三万丄丁不:  val_92.丟丂丞不专丆万丒世(), 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
            }
            
                val_92.世丗丒丐丑丝丄丏丄();
                val_146 = 1;
                return (bool)val_146;
            }
            
            }
            
            object[] val_105 = new object[1];
            val_109 = val_105;
            val_109[0] = this.<丅不丙丌丟业一业丂>k__BackingField.EventId;
            val_134 = val_109;
            val_133 = "no containers setted in event \'{0}\'";
            label_70:
            UnityEngine.Debug.LogErrorFormat(format:  val_133, args:  val_105);
            label_1:
            val_146 = 0;
            return (bool)val_146;
        }
        public void 下丄专一下丂三业丆()
        {
            this.丅三一专丐丗丏一下(丙业与丙丗丝不丈东:  0);
        }
        public void 七丏丟丈丞丌一丆丒(System.Nullable<bool> 丏上一世一下丑丂三)
        {
            bool val_5;
            var val_6;
            val_5 = 丏上一世一下丑丂三.HasValue;
            val_6 = 0;
            goto label_1;
            label_5:
            val_5 = (val_5 & (-65536)) | (val_5 & 65535);
            this.丙丗丝一丏丅专丁不.Item[0].七丏丟丈丞丌一丆丒(丏上一世一下丑丂三:  new System.Nullable<System.Boolean>() {HasValue = val_5});
            val_6 = 1;
            label_1:
            if(val_6 < this.丙丗丝一丏丅专丁不.Count)
            {
                goto label_5;
            }
        
        }
        internal static void 丐丛下世下世丂丂丙(System.Action<Rilisoft.GameEventType, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒 != 1152921505458446360);
        
        }
        internal static void 丁丌丗三丗与且且丂(System.Action<Rilisoft.GameEventType, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒 != 1152921505458446360);
        
        }
        internal static void 东万丝一不丛丛丁七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世 != 1152921505458446368);
        
        }
        internal static void 三丁且一丝丟且丏万(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世 != 1152921505458446368);
        
        }
        public void 上丐上丐专丞丆丞丁(System.Collections.Generic.List<Rilisoft.GameEventItem> 丑七不与丛丆一丂丞, int 丐东业丕丕丂丗丅丙, bool 丄丆丂下不丝东丂一)
        {
            int val_6;
            int val_343;
            System.Collections.IEnumerator val_344;
            var val_345;
            var val_346;
            var val_347;
            七专丁丕世丏丁丘丛 val_348;
            var val_349;
            System.Collections.Generic.IEnumerable<TSource> val_350;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_351;
            Rilisoft.GameEventItemData val_352;
            var val_353;
            var val_354;
            var val_355;
            var val_360;
            var val_362;
            Rilisoft.GameEventItemData val_363;
            var val_364;
            int val_365;
            var val_366;
            val_343 = 丑七不与丛丆一丂丞;
            丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌 val_1 = new 丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌();
            .丐东业丕丕丂丗丅丙 = 丐东业丕丕丂丗丅丙;
            val_344 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_344.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  27);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_4 = val_343.GetEnumerator();
            label_742:
            if(((-376906752) & 1) == 0)
            {
                goto label_6;
            }
            
            val_345 = val_6.丐丏七丌丕丗业且上();
            if(val_345 == null)
            {
                goto label_7;
            }
            
            if(0 != 0)
            {
                goto label_16;
            }
            
            Rilisoft.GameEventItemData val_9 = val_345.Data;
            Rilisoft.丛且世丐丆上七业丁 val_10 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  val_9.EventId);
            var val_11 = (val_10 == 0) ? 0 : (val_10);
            if(val_10 == null)
            {
                goto label_13;
            }
            
            if((val_10 == null ? 0 : val_10 + 176) != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_7:
            UnityEngine.Debug.LogError(message:  "cannot get reward from nullable item");
            goto label_19;
            label_13:
            label_16:
            if(val_345.Data.Type != 500)
            {
                goto label_21;
            }
            
            if((System.String.op_Equality(a:  val_345.Data.Id, b:  "Coins")) == false)
            {
                goto label_23;
            }
            
            BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  val_345.Data.Count, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  27, 丟世且丕丂丁万丒万:  0);
            val_346 = null;
            val_346 = null;
            Rilisoft.与七且业丛丝丒丝三.业丟不一三上七丆丕(且丒丛与丞世丙丕丌:  2, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  val_345.Data.Count);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  247, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_21:
            if(val_345.Data.Type != 400)
            {
                goto label_36;
            }
            
            if((Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  val_345.Data.Id)) == null)
            {
                goto label_40;
            }
            
            val_347 = 0;
            goto label_41;
            label_49:
            if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丙丙万丒世丏世下丟(丈丕丁丘七丙丞不丙:  val_345.Data.Id)) != null)
            {
                    Rilisoft.一丟专且三万丞丁丂.丘丏丌丝万丂业三丛(丑东与丅丐丅丂丞业:  "event", 丈丕丁丘七丙丞不丙:  val_345.Data.Id);
            }
            
            val_347 = 1;
            label_41:
            if(val_347 < val_345.Data.Count)
            {
                goto label_49;
            }
            
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  83, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_36:
            if(val_345.Data.Type != 100)
            {
                goto label_55;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_47 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            if((mem[1152921542884658272] + 88) == 100)
            {
                goto label_59;
            }
            
            if((mem[1152921542884658272] + 88) != 200)
            {
                goto label_60;
            }
            
            val_348 = 3;
            if(val_47 != null)
            {
                goto label_130;
            }
            
            goto label_129;
            label_23:
            if((System.String.op_Equality(a:  val_345.Data.Id, b:  "Gems")) == false)
            {
                goto label_64;
            }
            
            BankController.丐丙东东不丛丂上丛(丌丒丝东丌下丕丁丅:  val_345.Data.Count, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  27, 丟世且丕丂丁万丒万:  0);
            val_349 = null;
            val_349 = null;
            Rilisoft.与七且业丛丝丒丝三.业丟不一三上七丆丕(且丒丛与丞世丙丕丌:  2, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  val_345.Data.Count);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  223, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_55:
            if(val_345.Data.Type != 1300)
            {
                goto label_77;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_62 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  1);
            PGCompany.丗丟丄丈东丝丕丄世 val_64 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_62, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            if(val_64 != null)
            {
                    if(val_64.丁丕丁三丁丗不三丟() < ExperienceController.丞丞丘业东丙丏七丌())
            {
                    bool val_68 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_64, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = true});
            }
            
            }
            
            val_3.Add(item:  val_62);
            goto label_359;
            label_64:
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_345.Data.Id)) == false)
            {
                goto label_90;
            }
            
            bool val_74 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  val_345.Data.Count, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  mem[1152921542884658272] + 40);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  127, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_40:
            object[] val_78 = new object[1];
            val_78[0] = val_345.Data.Id;
            UnityEngine.Debug.LogErrorFormat(format:  "egg with id \'{0}\' not found", args:  val_78);
            goto label_359;
            label_77:
            if(val_345.Data.Type != 200)
            {
                goto label_107;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_86 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_345.Data.Id);
            if(val_86 == null)
            {
                goto label_110;
            }
            
            bool val_88 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_86, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  false, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  85, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  1));
            goto label_359;
            label_90:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  val_345.Data.Id)) == false)
            {
                goto label_359;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_98 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            val_98.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_345.Data.Count);
            PGCompany.丗丟丄丈东丝丕丄世 val_102 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_98, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            val_3.Add(item:  val_98);
            goto label_359;
            label_59:
            var val_109 = (丄丆丂下不丝东丂一 != true) ? ((PGCompany.BattlePass.BattlePassGuiHandler.丈丐丞丐上丑且丕万() != true) ? 37 : ((VeteranChestBanner.丕三三丐一一丟丘丂() != true) ? 36 : ((Rilisoft.GameEventOpenChestBase.丈丐丞丐上丑且丕万() != true) ? 50 : 4))) : 41;
            if(val_47 != null)
            {
                goto label_130;
            }
            
            goto label_129;
            label_60:
            val_348 = 0;
            if(val_47 != null)
            {
                goto label_130;
            }
            
            label_129:
            label_130:
            WeaponManager.丟业丒丈万与业丞丝(丆不丁东不丄丗丄世:  val_47.业上丙丞丐丄丆丅七(), 丄下丁东丘业丆丝上:  WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  val_47), 丑东与丅丐丅丂丞业:  "Event", 不丐丅丁丂七丐丘丛:  val_348);
            丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  val_47.业上丙丞丐丄丆丅七(), 丁丅丈丌丟世丗丗丟:  2);
            int val_113 = val_47.业东丅东丌上丗丑不();
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_113, 丂丕丂丏专丂丄丕且:  1));
            label_237:
            label_359:
            val_3.丛上丑下丐丄丘丗七(丞世不丒下上上丝丑:  val_113);
            val_350 = mem[1152921542884658288];
            if(val_350 != 0)
            {
                    val_351 = (丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌)[1152921542884694192].上丌丘丑一且丆且丏;
                if(val_351 == null)
            {
                    val_351 = null;
                val_351 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  val_1, method:  System.Boolean 丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌::万丕丂丛丝丛一七丂(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                .上丌丘丑一且丆且丏 = val_351;
            }
            
                Rilisoft.上专业三丟丁丞专下 val_116 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_350, predicate:  null);
                if(val_116 != null)
            {
                    val_350 = mem[1152921542884658288].IndexOf(item:  val_116);
            }
            else
            {
                    val_350 = 0;
            }
            
            }
            
            Rilisoft.一丟专且三万丞丁丂.与丞业丈下一七下下(丞一丁业丄一一业且:  val_345.Data.Id, 丌丒丝东丌下丕丁丅:  val_345.Data.Count, 丏丌业丐丅上上丂丞:  0, 丝丅专丈七丅丟丛上:  ((丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌)[1152921542884694192].丐东业丕丕丂丗丅丙 == 1000) ? 1 : 0);
            val_352 = val_345.Data.Clone();
            if(val_352 != null)
            {
                    val_352 = 0;
            }
            
            mem[1152921542884658280].丝丅东东七三东丐万(一丐丗丁丞丆丅丟丄:  val_352);
            object[] val_127 = new object[3];
            val_127[0] = val_345.Data.Id;
            Rilisoft.GameEventItemData val_130 = val_345.Data;
            val_6 = val_130.EventId;
            val_127[1] = val_6;
            Rilisoft.GameEventItemData val_131 = val_345.Data;
            val_127[2] = val_131.ChestId;
            UnityEngine.Debug.LogFormat(format:  "item added => itemId: \'{0}\' eventId: \'{1}\' chestId: \'{2}\'", args:  val_127);
            goto label_742;
            label_107:
            if(val_345.Data.Type != 300)
            {
                goto label_170;
            }
            
            bool val_144 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丏专丟丒万丑丐不丞(世丐丗专丅三丝丑丆:  val_345.Data.Id, 丒七且一东丂丐丛丒:  UnityEngine.Mathf.Max(a:  val_345.Data.Count, b:  1));
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_345.Data.Id)) != null)
            {
                goto label_359;
            }
            
            丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  val_345.Data.Id, 丁丅丈丌丟世丗丗丟:  2);
            PGCompany.三东丏不丗世丅丌丄 val_149 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  1);
            PGCompany.世丒丗丅丛丕不万丂 val_151 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.世丒丗丅丛丕不万丂>(丈丄不七三万丄丁不:  val_149);
            if(val_151 != null)
            {
                    丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_151);
            }
            
            val_3.Add(item:  val_149);
            goto label_359;
            label_170:
            if(val_345.Data.Type != 600)
            {
                goto label_189;
            }
            
            if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_345.Data.Id)) == false)
            {
                goto label_359;
            }
            
            丁下万丟且丟丛下业.丅丕丆丒丒业丑世东(丗丑丐丕丟丝且下丕:  val_345.Data.Id, 丈丘丝一丗下丈丐不:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_345.Data.Id].专丂丏世且丗丏丌丝());
            丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  val_345.Data.Id, 丁丅丈丌丟世丗丗丟:  2);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  val_345.Data.Id));
            goto label_359;
            label_110:
            object[] val_171 = new object[1];
            val_171[0] = val_345.Data.Id;
            UnityEngine.Debug.LogErrorFormat(format:  "lobby item with id \'{0}\' not found", args:  val_171);
            goto label_359;
            label_189:
            if(val_345.Data.Type != 1000)
            {
                goto label_216;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_345.Data.Id)) == false)
            {
                goto label_359;
            }
            
            丛且丗丌丏下七下丈.丂七丗丒丅世丒丌下(丞一丁业丄一一业且:  val_345.Data.Id, 丌业丈丙丙丈且丕丞:  true);
            丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  val_345.Data.Id, 丁丅丈丌丟世丗丗丟:  2);
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_345.Data.Id)) == false)
            {
                goto label_359;
            }
            
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[val_345.Data.Id].业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  1));
            goto label_237;
            label_216:
            if(val_345.Data.Type != 800)
            {
                goto label_239;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_345.Data.Id)) == false)
            {
                goto label_243;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_200 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            null.Add(key:  val_345.Data.Id, value:  val_345.Data.Count);
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗且且丘丐三丙丆丁(丌丄万上丙万丄丒七:  null);
            goto label_463;
            label_239:
            if(val_345.Data.Type != 900)
            {
                goto label_250;
            }
            
            Rilisoft.Singleton<Rilisoft.VIPController>.Instance.丏与丑专下不下丗丁(与丈业丛丝丒丙一丏:  val_345.Data.Count);
            VIPNotificationController.丗丂一业且七世丄下(丆丐七丅丆丗丛上与:  val_345.Data.Count);
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  95, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_250:
            if(val_345.Data.Type != 1100)
            {
                goto label_258;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_221 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  val_345.Data.Count);
            PGCompany.丗丟丄丈东丝丕丄世 val_223 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_221, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            val_3.Add(item:  val_221);
            goto label_359;
            label_243:
            val_353 = null;
            val_353 = null;
            if(((((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_345.Data.Id)) == true) || ((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_345.Data.Id)) == true)) || ((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  val_345.Data.Id)) == true)) || ((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_345.Data.Id)) == true))
            {
                goto label_282;
            }
            
            val_354 = null;
            val_354 = null;
            if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_345.Data.Id)) == false)
            {
                goto label_463;
            }
            
            label_282:
            int val_243 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_345.Data.Id);
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  val_345.Data.Id, 丌丒丝东丌下丕丁丅:  val_345.Data.Count, 与丘万三东一丄丄丙:  true);
            int val_250 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_345.Data.Id);
            PGCompany.丝不丌三专丆世丟丄.丌东丅丞丏一万丆下(下丁丞不丄七丏东上:  val_243, 丁丌丝一丏丞丑业丑:  val_250, 丁丒一丘丆丞丑三丂:  val_345.Data.Id, 丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
            if((val_243 == 0) && (val_250 > val_243))
            {
                    丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  val_345.Data.Id, 丁丅丈丌丟世丗丗丟:  2);
            }
            
            label_463:
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioClip val_256 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/add_craft_details");
                if(val_256 != 0)
            {
                    UnityEngine.AudioSource val_258 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_256);
            }
            
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_263 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  46, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  val_345.Data.Count);
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_263)) == false)
            {
                goto label_359;
            }
            
            val_3.Add(item:  val_263);
            goto label_359;
            label_258:
            if(val_345.Data.Type != 1200)
            {
                goto label_316;
            }
            
            val_355 = 0;
            goto label_317;
            label_322:
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
            PGCompany.丗丟丄丈东丝丕丄世 val_271 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            val_355 = 1;
            label_317:
            if(val_355 < val_345.Data.Count)
            {
                goto label_322;
            }
            
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_345.Data.Id, 丂丕丂丏专丂丄丕且:  val_345.Data.Count));
            goto label_359;
            label_316:
            if(val_345.Data.Type != 1400)
            {
                goto label_328;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  170, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_345.Data.Count);
            PGCompany.丗丟丄丈东丝丕丄世 val_287 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            PGCompany.VIP20.丆专万丒丗丑丗丐丒.丑七不且上丗丁一世().万丘丄丟丞丐丐万丝(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 世丁丙世丄一万丆三:  2);
            val_3.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            goto label_359;
            label_328:
            if(val_345.Data.Type != 1500)
            {
                goto label_339;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_345.Data.Count);
            PGCompany.丗丟丄丈东丝丕丄世 val_297 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            PGCompany.VIP20.丆专万丒丗丑丗丐丒.丑七不且上丗丁一世().万丘丄丟丞丐丐万丝(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 世丁丙世丄一万丆三:  2);
            val_3.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            goto label_359;
            label_339:
            if(val_345.Data.Type != 1600)
            {
                goto label_359;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_345.Data.Id);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_345.Data.Count);
            PGCompany.丗丟丄丈东丝丕丄世 val_307 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            PGCompany.VIP20.丆专万丒丗丑丗丐丒.丑七不且上丗丁一世().万丘丄丟丞丐丐万丝(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 世丁丙世丄一万丆三:  2);
            val_3.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            goto label_359;
            label_6:
            val_360 = 3171;
            goto label_743;
            label_19:
            val_360 = 3485;
            label_743:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(3485 == 3485)
            {
                    return;
            }
            
            var val_317 = (3485 == 3171) ? -1 : 0;
            mem[1152921542884658280].上下一丛丏丈不丁三();
            if(val_343 != null)
            {
                    val_362 = val_343.Count;
            }
            else
            {
                    val_362 = val_343.Count;
            }
            
            Rilisoft.GameEventItem val_321 = val_343.Item[val_362 - 1];
            if(val_321 != null)
            {
                    val_363 = val_321.Data;
            }
            else
            {
                    val_363 = val_321.Data;
            }
            
            val_344 = GameEventPlayerGot.丙丟丐世丕下丑上下(一丐丗丁丞丆丅丟丄:  val_363, 丌丒丝东丌下丕丁丅:  val_321.Data.Count, 丅东专与不三丂丁丝:  this);
            UnityEngine.Coroutine val_328 = CoroutineRunner.Instance.StartCoroutine(routine:  val_344);
            val_345 = 1152921542706720640;
            val_364 = 0;
            goto label_774;
            label_779:
            val_344 = val_343.Item[0].Data;
            val_364 = 1;
            val_330.PresettedCount = 0;
            label_774:
            if(val_364 < val_343.Count)
            {
                goto label_779;
            }
            
            if((1 & 1) != 0)
            {
                    this.七丏丟丈丞丌一丆丒(丏上一世一下丑丂三:  new System.Nullable<System.Boolean>() {HasValue = false});
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒 == null)
            {
                goto label_815;
            }
            
            List.Enumerator<T> val_333 = val_3.GetEnumerator();
            val_364 = 1152921525631263872;
            label_788:
            if(((-376906848) & 1) == 0)
            {
                goto label_786;
            }
            
            Rilisoft.丛且世丐丆上七业丁.丁丑丈丐不七三专丒.Invoke(arg1:  0, arg2:  丐丏七丌丕丗业且上());
            goto label_788;
            label_786:
            val_365 = 0;
            val_366 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_798;
            }
            
            if(( == 0) || (3485 == 3378))
            {
                goto label_815;
            }
            
            label_814:
            label_815:
            if(Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世 == null)
            {
                    return;
            }
            
            if(val_343.Count < 1)
            {
                    return;
            }
            
            Rilisoft.GameEventItemData val_338 = val_343.Item[0].Data;
            val_343 = val_338.EventId;
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  val_343)) == null)
            {
                    return;
            }
            
            val_343 = val_339.丙丗丝一丏丅专丁不;
            Rilisoft.上专业三丟丁丞专下 val_341 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_343, predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  val_1, method:  System.Boolean 丛且世丐丆上七业丁.丅丌与丐丁与丆丐丌::丞丙业丕丒万下下下(Rilisoft.上专业三丟丁丞专下 丕上丙丝丅丛丐丏丑)));
            if(val_341 == null)
            {
                    return;
            }
            
            if(val_341.丐丏下丕三丒丗丅丛() == false)
            {
                    return;
            }
            
            Rilisoft.丛且世丐丆上七业丁.七丂丙专丙丟东专世.Invoke();
            return;
            label_798:
            if( != 0)
            {
                goto label_814;
            }
            
            goto label_815;
        }
        internal bool 丌丆不不东丅丟万东(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_3;
            var val_10;
            var val_17;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            List.Enumerator<T> val_1 = this.丙丗丝一丏丅专丁不.GetEnumerator();
            val_19 = 0;
            val_20 = 0;
            val_21 = 0;
            goto label_43;
            label_44:
            string val_4 = val_3.丐丏七丌丕丗业且上();
            List.Enumerator<T> val_5 = val_4.GetEnumerator();
            goto label_7;
            label_32:
            val_19 = 0;
            val_22 = 0;
            if(val_4 == null)
            {
                goto label_7;
            }
            
            val_19 = 0;
            val_22 = 0;
            goto label_7;
            label_31:
            var val_18 = 0;
            val_18 = val_18 ^ 0;
            val_21 = val_21 + val_18;
            val_22 = val_4;
            label_7:
            if(((-375635408) & 1) == 0)
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_8 = val_3.丐丏七丌丕丗业且上().AllItems.GetEnumerator();
            label_19:
            if(((-375635440) & 1) == 0)
            {
                goto label_11;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            if((val_11 == null) || (val_11.Data == null))
            {
                goto label_19;
            }
            
            Rilisoft.GameEventItemData val_13 = val_11.Data;
            if(val_13.ItemParams == null)
            {
                goto label_19;
            }
            
            Rilisoft.GameEventItemData val_14 = val_11.Data;
            if(val_14.ItemParams.业东丅东丌上丗丑不() != 丈丄不七三万丄丁不.业东丅东丌上丗丑不())
            {
                goto label_19;
            }
            
            val_23 = val_21 + 1;
            mem2[0] = 198;
            goto label_20;
            label_11:
            val_23 = val_21 + 1;
            mem2[0] = 143;
            label_20:
            val_17 = val_22;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_23 == 1)
            {
                goto label_32;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) == 143)
            {
                goto label_31;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) != 198)
            {
                goto label_32;
            }
            
            goto label_34;
            label_8:
            val_23 = val_21 + 1;
            val_17 = val_22;
            mem2[0] = 168;
            label_34:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_23 == 1)
            {
                goto label_39;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) == 168)
            {
                goto label_40;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) == 198)
            {
                goto label_41;
            }
            
            label_39:
            val_19 = 0;
            val_20 = 0;
            if( == 0)
            {
                goto label_43;
            }
            
            val_19 = 0;
            val_20 = 0;
            goto label_43;
            label_40:
            var val_19 = 0;
            val_19 = val_19 ^ (val_23 >> 31);
            val_21 = val_23 + val_19;
            val_20 = ;
            label_43:
            if(((-375635376) & 1) != 0)
            {
                goto label_44;
            }
            
            val_24 = val_21 + 1;
            mem2[0] = 196;
            goto label_45;
            label_41:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_25 = 1;
            return (bool)val_25 & 1;
            label_45:
            val_25 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_23 == 1)
            {
                goto label_51;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) == 196)
            {
                goto label_54;
            }
            
            if((1152921542885917120 + (((val_21 + (0 ^ 0)) + 1)) << 2) == 198)
            {
                    return (bool)val_25 & 1;
            }
            
            label_51:
            label_54:
            val_25 = 0;
            return (bool)val_25 & 1;
        }
        private void 丛上丑下丐丄丘丗七(int 丞世不丒下上上丝丑)
        {
            if((SkinsController.业丈东世丟丕与丞丙().ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑)) != false)
            {
                    上丑三丁丄丛丁万丑.丙丘丙不丟东且丌丏(丞丅上丏丂且下丅与:  SkinsController.业丈东世丟丕与丞丙().Item[丞世不丒下上上丝丑]);
                return;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            if((val_6 == null) || (val_6 != 190000))
            {
                goto label_12;
            }
            
            string val_7 = 丛且丗丌丏下七下丈.丒不七丛丝丕且业丁(上丛丛丞且东且丄丘:  丞世不丒下上上丝丑);
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                goto label_15;
            }
            
            label_12:
            丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丞世不丒下上上丝丑));
            return;
            label_15:
            上丑三丁丄丛丁万丑.上七一丆丝丂丝且东(丞丅上丏丂且下丅与:  val_7);
        }
        private void 且七丙丄丘一丄上不()
        {
            List.Enumerator<T> val_1 = this.<丙丌丅丝丘与三丗丑>k__BackingField.GetEnumerator();
            label_4:
            if(((-375288440) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.与丕丕七不丝专专丛 == null)
            {
                    return;
            }
            
            this.与丕丕七不丝专专丛.Invoke();
        }
        public string 丁七丐丒丄丏丞七且(int 世与丂且丘丐万丗丞 = 1)
        {
            object val_10;
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "4july")) != false)
            {
                    val_10 = "Textures/Bank/Event/Event_Currency_ribbons_";
                return (string)val_10 + 世与丂且丘丐万丗丞;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "homecoming")) != false)
            {
                    val_10 = "Textures/Bank/Event/Event_Currency_homecoming_";
                return (string)val_10 + 世与丂且丘丐万丗丞;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "halloween")) != false)
            {
                    val_10 = "Textures/Bank/Event/Event_Currency_halloween_";
                return (string)val_10 + 世与丂且丘丐万丗丞;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "christmas2")) != false)
            {
                    val_10 = "Textures/Bank/Event/Event_Currency_christmas_";
                return (string)val_10 + 世与丂且丘丐万丗丞;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "new_year2")) != false)
            {
                    val_10 = "Textures/Bank/Event/event_currency_new_year_";
                return (string)val_10 + 世与丂且丘丐万丗丞;
            }
            
            if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "sniper_tournament")) != true)
            {
                    if((System.String.op_Equality(a:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId, b:  "sniper2_roulette")) == false)
            {
                    return Rilisoft.丛且世丐丆上七业丁.丒丈一丏丆丅上丕丂(世与丂且丘丐万丗丞:  世与丂且丘丐万丗丞);
            }
            
            }
            
            val_10 = "Textures/Bank/Event/Event_Currency_sniper_tournament_";
            return (string)val_10 + 世与丂且丘丐万丗丞;
        }
        internal static string 丒丈一丏丆丅上丕丂(int 世与丂且丘丐万丗丞 = 1)
        {
            return (string)"Textures/Bank/Event/Event_Currency_"("Textures/Bank/Event/Event_Currency_") + 世与丂且丘丐万丗丞;
        }
        public string 丐丙丁一丅丞不丅丟(int 丑丏万丈丟丝丝丌丗)
        {
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_11;
            var val_12;
            System.Func<Rilisoft.GameCurrencyData, System.Int32> val_14;
            var val_18;
            var val_19;
            var val_20;
            val_11 = this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Rilisoft.GameCurrencyData>(丑东与丅丐丅丂丞业:  val_11)) == true)
            {
                    return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = 丛且世丐丆上七业丁.<>c.<>9__246_0;
            if(val_14 == null)
            {
                    System.Func<Rilisoft.GameCurrencyData, System.Int32> val_2 = null;
                val_14 = val_2;
                val_2 = new System.Func<Rilisoft.GameCurrencyData, System.Int32>(object:  丛且世丐丆上七业丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丛且世丐丆上七业丁.<>c::与丞丁丄七丈丈丅丘(Rilisoft.GameCurrencyData 丁丂专业丁丅丅丈丙));
                丛且世丐丆上七业丁.<>c.<>9__246_0 = val_14;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderByDescending<Rilisoft.GameCurrencyData, System.Int32>(source:  this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices, keySelector:  val_2);
            int val_16 = System.Linq.Enumerable.Count<Rilisoft.GameCurrencyData>(source:  val_3);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_11 = val_3.GetEnumerator();
            goto label_16;
            label_29:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_11.Current.CurrencyCount <= 丑丏万丈丟丝丝丌丗)
            {
                goto label_23;
            }
            
            val_16 = val_16 - 1;
            label_16:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_11.MoveNext() == true)
            {
                goto label_29;
            }
            
            val_18 = 0;
            val_19 = 0;
            val_20 = 0;
            if(val_11 != null)
            {
                goto label_32;
            }
            
            goto label_38;
            label_23:
            val_20 = this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  val_16);
            val_18 = 0;
            val_19 = 0;
            if(val_11 != null)
            {
                goto label_32;
            }
            
            goto label_38;
            label_32:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_11.Dispose();
            label_38:
            if( == 1)
            {
                goto label_43;
            }
            
            if(134 != 134)
            {
                goto label_44;
            }
            
            return (string);
            label_43:
            if(null != null)
            {
                    return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
            }
            
            return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
            label_44:
            if(null == null)
            {
                    return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
            }
            
            if(134 == 126)
            {
                    return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
            }
            
            return this.丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
        }
        internal static string 丆丆丏丄丈丝丝业不(string 丟丟丄专上丟丁丐丝)
        {
            var val_8;
            if((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "4july")) != false)
            {
                    val_8 = "Textures/ribbon_bank_icon";
                return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
            }
            
            if((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "halloween")) != false)
            {
                    val_8 = "Textures/halloween_key_bank";
                return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
            }
            
            if((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "christmas2")) != false)
            {
                    val_8 = "Textures/key_icon_christmas";
                return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
            }
            
            if((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "new_year2")) != false)
            {
                    val_8 = "Textures/new_year_key_bank";
                return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
            }
            
            val_8 = "Textures/sniper_tournament_key_bank";
            if((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper_tournament")) == true)
            {
                    return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
            }
            
            return (string)((System.String.op_Equality(a:  丟丟丄专上丟丁丐丝, b:  "sniper2_roulette")) != true) ? (val_8) : "Textures/key_icon1";
        }
        internal Rilisoft.GameEventRewardData 丏不东三专一且丝专(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            var val_4;
            .上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
            if((this.<丅不丙丌丟业一业丂>k__BackingField.Rewards) != null)
            {
                    Rilisoft.GameEventRewardData val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventRewardData>(source:  this.<丅不丙丌丟业一业丂>k__BackingField.Rewards, predicate:  new System.Func<Rilisoft.GameEventRewardData, System.Boolean>(object:  new 丛且世丐丆上七业丁.不丆世上且丂丛丟丅(), method:  System.Boolean 丛且世丐丆上七业丁.不丆世上且丂丛丟丅::专丈丆丒丄丞丐丐丛(Rilisoft.GameEventRewardData 东七上世万下丗丄丛)));
                return (Rilisoft.GameEventRewardData)val_4;
            }
            
            val_4 = 0;
            return (Rilisoft.GameEventRewardData)val_4;
        }
        private void 丏专丝丗与下丟三丛(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            InappRememberedBonus.EventCurrency val_11;
            var val_12;
            val_11 = 丂丈丗丄不丅丅丙丒;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            if(val_11 == null)
            {
                    return;
            }
            
            if(this.丕丒丙七丘丈丙且丂() == true)
            {
                    return;
            }
            
            if(丂丈丗丄不丅丅丙丒.EventCurrencies == null)
            {
                    return;
            }
            
            if(丂丈丗丄不丅丅丙丒.EventCurrencies.Count == 0)
            {
                    return;
            }
            
            if(丂丈丗丄不丅丅丙丒.IsEventCurrencyBonus == false)
            {
                    return;
            }
            
            丛且世丐丆上七业丁.丗丅且丘不专丏丂丝 val_4 = new 丛且世丐丆上七业丁.丗丅且丘不专丏丂丝();
            val_11 = System.Linq.Enumerable.FirstOrDefault<EventCurrency>(source:  丂丈丗丄不丅丅丙丒.EventCurrencies, predicate:  new System.Func<EventCurrency, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丛且世丐丆上七业丁::与丏丝丆不丏且丈丟(InappRememberedBonus.EventCurrency 丌丗丏丏丛东专丁且)));
            if(val_4 != null)
            {
                    val_12 = val_4;
                .且一专万丑丟丒且业 = val_11;
            }
            else
            {
                    val_12 = 16;
                mem[16] = val_11;
            }
            
            if(val_12 == 0)
            {
                    return;
            }
            
            val_11 = this.<丅不丙丌丟业一业丂>k__BackingField;
            if((this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices) == null)
            {
                    return;
            }
            
            val_11 = this.<丅不丙丌丟业一业丂>k__BackingField.СurrencyPrices;
            Rilisoft.GameCurrencyData val_8 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameCurrencyData>(source:  val_11, predicate:  new System.Func<Rilisoft.GameCurrencyData, System.Boolean>(object:  val_4, method:  System.Boolean 丛且世丐丆上七业丁.丗丅且丘不专丏丂丝::丑专丅丛丘业上丐丒(Rilisoft.GameCurrencyData 七丏丄丅丌业与且丙)));
            if(val_8 == null)
            {
                    return;
            }
            
            this.丕丐与丆丙丌丙丑上.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_8.RealPrice);
            this.七丁东丁丙世丑丅丏.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_8.RealPrice);
        }
        public int 丛丞上业东且与丗丁(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            var val_21;
            string val_22;
            var val_23;
            var val_24;
            int val_25;
            val_21 = 丐下丝丘丑丟丟丗丌;
            if(val_21 == null)
            {
                    return 0;
            }
            
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_21.东与三丌丅三丒丏业())) == false)
            {
                goto label_3;
            }
            
            val_22 = 0;
            int val_3 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  val_22);
            goto label_14;
            label_3:
            val_23 = null;
            val_23 = null;
            if((System.String.op_Equality(a:  val_21.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_10;
            }
            
            val_22 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
            int val_7 = val_22.世丄丂下丏丝丞丒且();
            goto label_14;
            label_10:
            val_24 = null;
            val_24 = null;
            if((System.String.op_Equality(a:  val_21.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_18;
            }
            
            val_22 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
            label_14:
            if(val_21 != null)
            {
                goto label_31;
            }
            
            label_32:
            label_31:
            int val_14 = UnityEngine.Mathf.FloorToInt(f:  (float)val_22.丗丞丝丅丈丑丗丂丌() / val_21.丟丂丞不专丆万丒世());
            val_25 = val_14;
            if(this.不七丘丙不三丗业上() == null)
            {
                    return UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  val_14, b:  val_25 = UnityEngine.Mathf.CeilToInt(f:  val_21 = val_21 / (float)val_21)), b:  10);
            }
            
            val_21 = val_21.丁丒丝世下丟丑七丐();
            float val_21 = (float)this.不七丘丙不三丗业上().丂丙丐丆丝上万业世();
            val_21 = val_21 - (float)this.下丂丆丒三丑丌东丒;
            return UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  val_14, b:  val_25), b:  10);
            label_18:
            if(val_21 != null)
            {
                goto label_31;
            }
            
            goto label_32;
        }
        internal static int 不丙丝下与丞业不丒(Rilisoft.GameEventItemContainer 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemContainer 丒丈丙丐丏丕丆万丗)
        {
            var val_5;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_0;
            }
            
            if(丒丈丙丐丏丕丆万丗 == null)
            {
                goto label_1;
            }
            
            var val_3 = (丒丈丙丐丏丕丆万丗.Id > 丏丆丑丗七丄丙丝与.Id) ? (-1) : 1;
            return (int)val_5;
            label_0:
            var val_4 = (丒丈丙丐丏丕丆万丗 != 0) ? (-1) : 1;
            return (int)val_5;
            label_1:
            val_5 = 1;
            return (int)val_5;
        }
        internal static int 丞东专丑与丞专丝丑(Rilisoft.GameEventItemContainer 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemContainer 丒丈丙丐丏丕丆万丗)
        {
            var val_4;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_0;
            }
            
            if(丒丈丙丐丏丕丆万丗 == null)
            {
                goto label_1;
            }
            
            return Rilisoft.丛且世丐丆上七业丁.七丄一专丑丟丙一丂(丏丆丑丗七丄丙丝与:  丏丆丑丗七丄丙丝与.丙业丈专万下丄丙丏(), 丒丈丙丐丏丕丆万丗:  丒丈丙丐丏丕丆万丗.丙业丈专万下丄丙丏());
            label_0:
            var val_3 = (丒丈丙丐丏丕丆万丗 != 0) ? (-1) : 1;
            return (int)val_4;
            label_1:
            val_4 = 1;
            return (int)val_4;
        }
        internal static int 丙上丏不丗与丒专与(Rilisoft.DroppedItemData 丏丆丑丗七丄丙丝与, Rilisoft.DroppedItemData 丒丈丙丐丏丕丆万丗)
        {
            if(丏丆丑丗七丄丙丝与 == null)
            {
                    return (int)(丒丈丙丐丏丕丆万丗 != 0) ? (-1) : 1;
            }
            
            if(丒丈丙丐丏丕丆万丗 == null)
            {
                    return 1;
            }
            
            return Rilisoft.丛且世丐丆上七业丁.丞世世丝七丄丄万专(丏丆丑丗七丄丙丝与:  丏丆丑丗七丄丙丝与.ItemData, 丒丈丙丐丏丕丆万丗:  丒丈丙丐丏丕丆万丗.ItemData);
        }
        internal static int 七丄一专丑丟丙一丂(Rilisoft.GameEventItem 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItem 丒丈丙丐丏丕丆万丗)
        {
            var val_4;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_0;
            }
            
            if(丒丈丙丐丏丕丆万丗 == null)
            {
                goto label_1;
            }
            
            return Rilisoft.丛且世丐丆上七业丁.丞世世丝七丄丄万专(丏丆丑丗七丄丙丝与:  丏丆丑丗七丄丙丝与.Data, 丒丈丙丐丏丕丆万丗:  丒丈丙丐丏丕丆万丗.Data);
            label_0:
            var val_3 = (丒丈丙丐丏丕丆万丗 != 0) ? (-1) : 1;
            return (int)val_4;
            label_1:
            val_4 = 1;
            return (int)val_4;
        }
        internal static int 丞世世丝七丄丄万专(Rilisoft.GameEventItemData 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemData 丒丈丙丐丏丕丆万丗)
        {
            var val_17;
            var val_18;
            var val_19;
            val_17 = 丒丈丙丐丏丕丆万丗;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_0;
            }
            
            if(val_17 == null)
            {
                goto label_1;
            }
            
            if(丏丆丑丗七丄丙丝与.Type != val_17.Type)
            {
                goto label_2;
            }
            
            if(丏丆丑丗七丄丙丝与.Type != 500)
            {
                goto label_3;
            }
            
            if((System.String.op_Equality(a:  丏丆丑丗七丄丙丝与.Id, b:  val_17.Id)) == false)
            {
                goto label_4;
            }
            
            val_17 = val_17.Count;
            val_18 = 丏丆丑丗七丄丙丝与;
            int val_8 = val_18.Count;
            goto label_5;
            label_0:
            var val_9 = (val_17 != 0) ? (-1) : 1;
            return (int)val_19;
            label_1:
            val_19 = 1;
            return (int)val_19;
            label_2:
            val_17 = val_17.Type;
            label_5:
            label_9:
            var val_12 = (val_17 <= 丏丆丑丗七丄丙丝与.Type) ? (-0) : 0;
            return (int)val_19;
            label_3:
            val_19 = 0;
            return (int)val_19;
            label_4:
            int val_14 = Rilisoft.丛且世丐丆上七业丁.丁丗不一丆业万丝丒(丏丂不专上丘丂不丅:  丏丆丑丗七丄丙丝与.Id);
            int val_16 = Rilisoft.丛且世丐丆上七业丁.丁丗不一丆业万丝丒(丏丂不专上丘丂不丅:  val_17.Id);
            goto label_9;
        }
        private static int 丁丗不一丆业万丝丒(string 丏丂不专上丘丂不丅)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_5 = 30;
                return (int)((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 20 : 0;
            }
            
            val_6 = null;
            val_6 = null;
            return (int)((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 20 : 0;
        }
        internal static bool 不丐七且丈丛丘下丄(string 丏丂不专上丘丂不丅)
        {
            return (bool)((丏丂不专上丘丂不丅.IndexOf(value:  "EventCurrency")) == 0) ? 1 : 0;
        }
        internal static string 丕万丑且上七世丛不(string 丟丟丄专上丟丁丐丝)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丟丟丄专上丟丁丐丝)) == false)
            {
                    return System.String.Format(format:  "{0}_{1}", arg0:  "EventCurrency", arg1:  丟丟丄专上丟丁丐丝);
            }
            
            return "EventCurrency";
        }
        internal static string 丁丂丈世丘丂丕丘东(string 丈上下与丌丘丅丙丒)
        {
            var val_6;
            var val_7;
            if((丈上下与丌丘丅丙丒.IndexOf(value:  "EventCurrency")) != 0)
            {
                    return 0;
            }
            
            val_6 = "EventCurrency";
            if("EventCurrency" == null)
            {
                    val_6 = "EventCurrency";
            }
            
            if(丈上下与丌丘丅丙丒.Length == Length)
            {
                    return 0;
            }
            
            val_7 = "EventCurrency";
            if("EventCurrency" != null)
            {
                    return 丈上下与丌丘丅丙丒.Substring(startIndex:  Length + 1);
            }
            
            val_7 = "EventCurrency";
            return 丈上下与丌丘丅丙丒.Substring(startIndex:  Length + 1);
        }
        private static bool 丘丛与丏丈丑一丌丒(Rilisoft.GameEventChestData 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            string val_20;
            var val_21;
            val_20 = 一丐丗丁丞丆丅丟丄;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  一丐丗丁丞丆丅丟丄.BindedItem)) != false)
            {
                    val_21 = 0;
                return (bool)val_21.ContainsKey(key:  val_20 = 一丐丗丁丞丆丅丟丄.BindedItem);
            }
            
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  一丐丗丁丞丆丅丟丄.BindedItem)) == false)
            {
                goto label_8;
            }
            
            label_30:
            val_21 = 1;
            return (bool)val_21.ContainsKey(key:  val_20);
            label_8:
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_5 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values.GetEnumerator();
            label_29:
            if(((-372559936) & 1) == 0)
            {
                goto label_14;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X21)) == true)
            {
                goto label_18;
            }
            
            bool val_10 = System.String.op_Equality(a:  X21, b:  一丐丗丁丞丆丅丟丄.BindedItem);
            if(val_10 == true)
            {
                goto label_26;
            }
            
            label_18:
            if(val_10 != false)
            {
                    if((System.Linq.Enumerable.Contains<System.String>(source:  val_10.Values, value:  一丐丗丁丞丆丅丟丄.BindedItem)) == true)
            {
                goto label_26;
            }
            
            }
            
            if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64, b:  一丐丗丁丞丆丅丟丄.BindedItem)) != true)
            {
                    if((System.Linq.Enumerable.Contains<System.String>(source:  val_7.丐丏七丌丕丗业且上().Values, value:  一丐丗丁丞丆丅丟丄.BindedItem)) == false)
            {
                goto label_29;
            }
            
            }
            
            label_26:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_30;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_21 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
            return (bool)val_21.ContainsKey(key:  val_20);
        }
        private bool 七丐丞丁丘丝专丞万(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)
        {
            Rilisoft.GameEventChestData val_1 = 丁丂专业丁丅丅丈丙.丁专丗万三上丟三丆();
            return (bool)(val_1.ChestId == this.三一丙不业丛丙业七) ? 1 : 0;
        }
        private bool 与丏丝丆不丏且丈丟(InappRememberedBonus.EventCurrency 丌丗丏丏丛东专丁且)
        {
            var val_3;
            if(丌丗丏丏丛东专丁且 != null)
            {
                    if((System.String.op_Equality(a:  丌丗丏丏丛东专丁且.EventId, b:  this.<丅不丙丌丟业一业丂>k__BackingField.EventId)) != false)
            {
                    var val_2 = (丌丗丏丏丛东专丁且.Count > 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}
