using UnityEngine;
public class QuestsGSMAnager : MonoBehaviour
{
    // Fields
    private const string 丈丏三丏丄丁丏丐不 = "QUESTS_TASKS_APRIL_2018_KEY";
    private const string 世丂上丌丞且丁七丏 = "[\n{ \"questId\": \"combat_1\" , \"quest_type\": \"finish_match\" , \"map\" : \"NuclearCity\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5242\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_2\" , \"quest_type\": \"finish_match\" , \"map\" : \"Heaven\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5243\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_3\" , \"quest_type\": \"finish_match\" , \"map\" : \"Pool\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5244\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_4\" , \"quest_type\": \"finish_match\" , \"map\" : \"\" , \"count_matches\" : 1 , \"should_win\" : true , \"place\" : -1 , \"descr_lkey\" : \"Key_5245\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_5\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 3 , \"kills_in_seriya\" : 1 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5246\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_6\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 2 , \"kills_in_seriya\" : 1 , \"is_headshot\" : true , \"descr_lkey\" : \"Key_5247\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_7\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 1 , \"kills_in_seriya\" : 2 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5248\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_8\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 5 , \"kills_in_seriya\" : 1 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5249\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_9\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 3 , \"kills_in_seriya\" : 1 , \"is_headshot\" : true , \"descr_lkey\" : \"Key_5250\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_10\" , \"quest_type\": \"finish_match\" , \"map\" : \"\" , \"count_matches\" : 1 , \"should_win\" : true , \"place\" : 0 , \"descr_lkey\" : \"Key_5251\" , \"teacher_emotion\" : \"\" }\n    ]";
    internal const string 丝丘丕一丁丛丏丙丘 = "questId";
    internal const string 丅不丅与专丌丕丞丕 = "descr_lkey";
    internal const string 七丟且三丁世丌丟丁 = "teacher_emotion";
    internal const string 丂丈丛与丈丏且丑下 = "QuestsGSMAnager.STARS_GS_KEY";
    internal const string 丑丈丐丝下丝三丙丌 = "quest_type";
    internal const string 且上丝丒丈丌一万七 = "finish_match";
    internal const string 丝丗丞丄万专业丛一 = "map";
    internal const string 一丛专丈丁丅专下丁 = "count_matches";
    internal const string 丈丐丈丑万丄丁万丏 = "should_win";
    internal const string 丆丈丛下与丄丁丐东 = "place";
    internal const string 丆丌丙万丌丙专丆丘 = "kill_enemies";
    internal const string 丅丄丌丘与丞业丏丞 = "num_kills";
    internal const string 一业业丙与不东丁万 = "kills_in_seriya";
    internal const string 不且丆丞不丅丈丆东 = "is_headshot";
    private static QuestsGSMAnager 世丒丞七专三与万丕;
    private 丏下丒东丅丏丌一丛 丏且七丑丒丑三丐丕;
    private 丈万丆丒上丅且上丛 丑丂丒不且丝丘丑万;
    private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 东丘与下丂丗丐丂且;
    private QuestsAndTasksState 丝丙丌且专丅东丞业;
    internal const string 业上丒丙丂丌丞不丙 = "Shtab";
    internal const string 丒丗丅丁丁丅一上丈 = "budka";
    internal const string 三且上丙世专上且东 = "inkubators";
    internal const string 丗丂丌世三丂下东丈 = "gacha";
    internal const string 丏丅丘丈三且丌下七 = "newsbox";
    internal const string 丅丄丞丗七不万丄专 = "ad_chest";
    internal const string 丐丏七下且一丐东东 = "flag_piedestal";
    internal const string 丏上丗丞丐且一丏不 = "igrovoy_avtomat";
    internal const string 丛不专丝丌丏世丅丟 = "landscape";
    internal const string 上不三且七丑丞业世 = "radar";
    internal static 丈万丆丒上丅且上丛[] 丌七丅且丕丗丒丈丆;
    
    // Properties
    internal static QuestsGSMAnager 丆丕丝丒不丙且丐丗 { get; }
    public 丏下丒东丅丏丌一丛 上丙不业丛丟丁丐下 { get; }
    public 丈万丆丒上丅且上丛 万丕丘丛丞丂丆七丌 { get; }
    public int 东下万丆丐且七一丑 { get; }
    
    // Methods
    internal static QuestsGSMAnager 丑七不且上丗丁一世()
    {
        var val_4;
        string val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = QuestsGSMAnager.上不三且七丑丞业世;
        if(val_5 == 0)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "QuestsGSMAnager");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_6 = null;
            val_5 = val_2.AddComponent<QuestsGSMAnager>();
            val_6 = null;
            QuestsGSMAnager.上不三且七丑丞业世 = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (QuestsGSMAnager)QuestsGSMAnager.上不三且七丑丞业世;
    }
    public 丏下丒东丅丏丌一丛 get_ActiveQuest()
    {
        return (丏下丒东丅丏丌一丛)this.丏且七丑丒丑三丐丕;
    }
    public 丈万丆丒上丅且上丛 get_ActiveTask()
    {
        丈万丆丒上丅且上丛 val_5;
        var val_6;
        this.丝与且丆上三与丐丙();
        val_5 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丝丙丌且专丅东丞业.CurrentTask)) == true)
        {
                return val_5;
        }
        
        if(this.丑丂丒不且丝丘丑万 != null)
        {
                if((System.String.op_Inequality(a:  this.丑丂丒不且丝丘丑万.下丄丈不与世丐业专, b:  this.丝丙丌且专丅东丞业.CurrentTask)) == false)
        {
            goto label_7;
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        this.丑丂丒不且丝丘丑万 = System.Linq.Enumerable.FirstOrDefault<丈万丆丒上丅且上丛>(source:  QuestsGSMAnager.丌七丅且丕丗丒丈丆, predicate:  new System.Func<丈万丆丒上丅且上丛, System.Boolean>(object:  this, method:  System.Boolean QuestsGSMAnager::世世东丙丗丝丈丝上(丈万丆丒上丅且上丛 丙丒七丄上与丏丙丙)));
        return val_5;
        label_7:
        val_5 = this.丑丂丒不且丝丘丑万;
        return val_5;
    }
    public int get_NumCompletedTasks()
    {
        if(this.丝丙丌且专丅东丞业.CompletedTasks == null)
        {
                return 0;
        }
        
        if(this.丝丙丌且专丅东丞业.CompletedTasks != null)
        {
                return this.丝丙丌且专丅东丞业.CompletedTasks.Count;
        }
        
        return this.丝丙丌且专丅东丞业.CompletedTasks.Count;
    }
    public int QuestsMinusTasks()
    {
        System.Collections.Generic.List<System.String> val_3;
        var val_4;
        var val_5;
        val_3 = this;
        this.丝与且丆上三与丐丙();
        if(this.丝丙丌且专丅东丞业.CompletedQuests != null)
        {
                val_4 = this.丝丙丌且专丅东丞业.CompletedQuests.Count;
        }
        else
        {
                val_4 = 0;
        }
        
        if(this.丝丙丌且专丅东丞业.CompletedTasks != null)
        {
                val_3 = this.丝丙丌且专丅东丞业.CompletedTasks;
            val_5 = val_3;
            int val_2 = val_5.Count;
        }
        else
        {
                val_5 = 0;
        }
        
        val_5 = val_4 - val_5;
        return (int)val_5;
    }
    public void CompleteActiveTask()
    {
        QuestsAndTasksState val_11;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "QuestsGSMAnager.STARS_GS_KEY", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "QuestsGSMAnager.STARS_GS_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) - 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        if(this.丝丙丌且专丅东丞业.CompletedTasks == null)
        {
                this.丝丙丌且专丅东丞业.CompletedTasks = new System.Collections.Generic.List<System.String>();
        }
        
        val_11 = this.丝丙丌且专丅东丞业;
        if(this.丝丙丌且专丅东丞业 != null)
        {
            goto label_6;
        }
        
        val_11 = this.丝丙丌且专丅东丞业;
        if(val_11 == null)
        {
            goto label_7;
        }
        
        label_6:
        this.丝丙丌且专丅东丞业.CompletedTasks.Add(item:  this.丝丙丌且专丅东丞业.CurrentTask);
        this.丝丙丌且专丅东丞业.CurrentTask = 0;
        this.三丏三三万丛业丙丒();
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "Shtab")) != false)
        {
                this.Check_Budka_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "budka")) != false)
        {
                this.Check_Incubators_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "inkubators")) != false)
        {
                this.Check_Gacha_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "newsbox")) != false)
        {
                this.Check_AdChest_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "ad_chest")) != false)
        {
                this.Check_FlagPiedestal_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "igrovoy_avtomat")) != false)
        {
                this.Check_Landscape_Task();
        }
        
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "landscape")) == false)
        {
                return;
        }
        
        this.Check_Radar_Task();
        return;
        label_7:
    }
    private void Awake()
    {
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == false)
        {
                return;
        }
        
        this.丅丐与东丗丙与万三();
        this.丝与且丆上三与丐丙();
        if(this.丝丙丌且专丅东丞业.CompletedQuests != null)
        {
                if(this.丝丙丌且专丅东丞业.CompletedQuests.Count >= this.东丘与下丂丗丐丂且.Count)
        {
                return;
        }
        
        }
        
        丏下丒东丅丏丌一丛 val_6 = 丐丄丘万一万丅万丅.业业业丈丙上业丗丞(三且丑东与丝丛丐丏:  System.Linq.Enumerable.First<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.东丘与下丂丗丐丂且, predicate:  new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  this, method:  System.Boolean QuestsGSMAnager::丞丂丝丕丅丈一三丄(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏))));
        this.丏且七丑丒丑三丐丕 = val_6;
        val_6.丘丏业丟丅上上东与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuestsGSMAnager::丂世不丂东丌业丅丄()));
    }
    private void 丂世不丂东丌业丅丄()
    {
        if(this.丝丙丌且专丅东丞业.CompletedQuests == null)
        {
                this.丝丙丌且专丅东丞业.CompletedQuests = new System.Collections.Generic.List<System.String>();
        }
        
        this.丝丙丌且专丅东丞业.CompletedQuests.Add(item:  this.丏且七丑丒丑三丐丕.业上丙丞丐丄丆丅七());
        this.三丏三三万丛业丙丒();
        bool val_4 = System.String.op_Equality(a:  this.丏且七丑丒丑三丐丕.业上丙丞丐丄丆丅七(), b:  "combat_3");
        this.丏且七丑丒丑三丐丕.且七下丒专世丌业丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuestsGSMAnager::丂世不丂东丌业丅丄()));
        if(this.丝丙丌且专丅东丞业.CompletedQuests.Count < this.东丘与下丂丗丐丂且.Count)
        {
                丏下丒东丅丏丌一丛 val_10 = 丐丄丘万一万丅万丅.业业业丈丙上业丗丞(三且丑东与丝丛丐丏:  System.Linq.Enumerable.First<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.东丘与下丂丗丐丂且, predicate:  new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  this, method:  System.Boolean QuestsGSMAnager::不丕丈丏丟七丅丆七(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏))));
            this.丏且七丑丒丑三丐丕 = val_10;
            val_10.丘丏业丟丅上上东与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuestsGSMAnager::丂世不丂东丌业丅丄()));
            return;
        }
        
        this.丏且七丑丒丑三丐丕 = 0;
    }
    internal void 丂万丁七丐丙丑丁七()
    {
    
    }
    internal void 丒丝世一丞七下且丁()
    {
    
    }
    internal void 丝万丌丌世丟丂七三()
    {
    
    }
    internal void 上且丙丅丗丈丏丅下()
    {
    
    }
    private void 丝与且丆上三与丐丙()
    {
        if(this.丝丙丌且专丅东丞业 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "QUESTS_TASKS_APRIL_2018_KEY")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "QUESTS_TASKS_APRIL_2018_KEY", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new QuestsAndTasksState()));
        }
        
        this.丝丙丌且专丅东丞业 = UnityEngine.JsonUtility.FromJson<QuestsAndTasksState>(json:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "QUESTS_TASKS_APRIL_2018_KEY"));
    }
    private void 三丏三三万丛业丙丒()
    {
        if(this.丝丙丌且专丅东丞业 == null)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "QUESTS_TASKS_APRIL_2018_KEY", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  this.丝丙丌且专丅东丞业));
    }
    private void 丅丐与东丗丙与万三()
    {
        var val_5;
        if(this.东丘与下丂丗丐丂且 != null)
        {
                return;
        }
        
        if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  "[\n{ \"questId\": \"combat_1\" , \"quest_type\": \"finish_match\" , \"map\" : \"NuclearCity\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5242\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_2\" , \"quest_type\": \"finish_match\" , \"map\" : \"Heaven\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5243\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_3\" , \"quest_type\": \"finish_match\" , \"map\" : \"Pool\" , \"count_matches\" : 1 , \"should_win\" : false , \"place\" : -1 , \"descr_lkey\" : \"Key_5244\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_4\" , \"quest_type\": \"finish_match\" , \"map\" : \"\" , \"count_matches\" : 1 , \"should_win\" : true , \"place\" : -1 , \"descr_lkey\" : \"Key_5245\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_5\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 3 , \"kills_in_seriya\" : 1 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5246\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_6\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 2 , \"kills_in_seriya\" : 1 , \"is_headshot\" : true , \"descr_lkey\" : \"Key_5247\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_7\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 1 , \"kills_in_seriya\" : 2 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5248\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_8\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 5 , \"kills_in_seriya\" : 1 , \"is_headshot\" : false , \"descr_lkey\" : \"Key_5249\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_9\" , \"quest_type\": \"kill_enemies\" , \"num_kills\" : 3 , \"kills_in_seriya\" : 1 , \"is_headshot\" : true , \"descr_lkey\" : \"Key_5250\" , \"teacher_emotion\" : \"\" },\n{ \"questId\": \"combat_10\" , \"quest_type\": \"finish_match\" , \"map\" : \"\" , \"count_matches\" : 1 , \"should_win\" : true , \"place\" : 0 , \"descr_lkey\" : \"Key_5251\" , \"teacher_emotion\" : \"\" }\n    ]")) != null)
        {
                val_5 = 0;
        }
        
        this.东丘与下丂丗丐丂且 = System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.OfType<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  null));
    }
    public void Check_Shtab_Task()
    {
        this.丝与且丆上三与丐丙();
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  "Shtab")) == true)
        {
                return;
        }
        
        if(this.丝丙丌且专丅东丞业.CompletedTasks != null)
        {
                if((this.丝丙丌且专丅东丞业.CompletedTasks.Contains(item:  "Shtab")) == true)
        {
                return;
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        this.丝丙丌且专丅东丞业.CurrentTask = "Shtab";
        this.三丏三三万丛业丙丒();
    }
    public void Check_Budka_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "budka");
    }
    public void Check_Incubators_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "inkubators");
    }
    public void Check_Gacha_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "gacha");
    }
    public void Check_NewsBox_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "newsbox");
    }
    public void Check_AdChest_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "ad_chest");
    }
    public void Check_FlagPiedestal_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "flag_piedestal");
    }
    public void Check_IgrovoyAvtomat_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "igrovoy_avtomat");
    }
    public void Check_Landscape_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "landscape");
    }
    public void Check_Radar_Task()
    {
        this.一丛一丘与一丞丞且(东一七丟与丗三丐不:  "radar");
    }
    private void 一丛一丘与一丞丞且(string 东一七丟与丗三丐不)
    {
        this.丝与且丆上三与丐丙();
        if((System.String.op_Equality(a:  this.丝丙丌且专丅东丞业.CurrentTask, b:  东一七丟与丗三丐不)) == true)
        {
                return;
        }
        
        if(this.丝丙丌且专丅东丞业.CompletedTasks == null)
        {
                return;
        }
        
        if((this.丝丙丌且专丅东丞业.CompletedTasks.Contains(item:  东一七丟与丗三丐不)) == true)
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        this.丝丙丌且专丅东丞业.CurrentTask = 东一七丟与丗三丐不;
        this.三丏三三万丛业丙丒();
    }
    public QuestsGSMAnager()
    {
    
    }
    private static QuestsGSMAnager()
    {
        QuestsGSMAnager.上不三且七丑丞业世 = 0;
        丈万丆丒上丅且上丛[] val_1 = new 丈万丆丒上丅且上丛[10];
        丈万丆丒上丅且上丛 val_2 = new 丈万丆丒上丅且上丛();
        if(val_2 != null)
        {
                .下丄丈不与世丐业专 = "Shtab";
            .一丌丐业丂不丗不丁 = "Key_5252";
        }
        else
        {
                mem[32] = "Shtab";
            mem[16] = "Key_5252";
        }
        
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        val_1[0] = val_2;
        丈万丆丒上丅且上丛 val_3 = new 丈万丆丒上丅且上丛();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        .下丄丈不与世丐业专 = "budka";
        .一丌丐业丂不丗不丁 = "Key_5253";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_3 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        mem[32] = "budka";
        mem[16] = "Key_5253";
        mem[24] = "first_Shtab";
        label_8:
        val_1[1] = val_3;
        丈万丆丒上丅且上丛 val_4 = new 丈万丆丒上丅且上丛();
        if(val_4 == null)
        {
            goto label_10;
        }
        
        .下丄丈不与世丐业专 = "inkubators";
        .一丌丐业丂不丗不丁 = "Key_5254";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_4 != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_10:
        mem[32] = "inkubators";
        mem[16] = "Key_5254";
        mem[24] = "first_Shtab";
        label_12:
        val_1[2] = val_4;
        丈万丆丒上丅且上丛 val_5 = new 丈万丆丒上丅且上丛();
        if(val_5 == null)
        {
            goto label_14;
        }
        
        .下丄丈不与世丐业专 = "gacha";
        .一丌丐业丂不丗不丁 = "Key_5255";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_5 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_14:
        mem[32] = "gacha";
        mem[16] = "Key_5255";
        mem[24] = "first_Shtab";
        label_16:
        val_1[3] = val_5;
        丈万丆丒上丅且上丛 val_6 = new 丈万丆丒上丅且上丛();
        if(val_6 == null)
        {
            goto label_18;
        }
        
        .下丄丈不与世丐业专 = "newsbox";
        .一丌丐业丂不丗不丁 = "Key_5256";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_6 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_18:
        mem[32] = "newsbox";
        mem[16] = "Key_5256";
        mem[24] = "first_Shtab";
        label_20:
        val_1[4] = val_6;
        丈万丆丒上丅且上丛 val_7 = new 丈万丆丒上丅且上丛();
        if(val_7 == null)
        {
            goto label_22;
        }
        
        .下丄丈不与世丐业专 = "ad_chest";
        .一丌丐业丂不丗不丁 = "Key_5257";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_7 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_22:
        mem[32] = "ad_chest";
        mem[16] = "Key_5257";
        mem[24] = "first_Shtab";
        label_24:
        val_1[5] = val_7;
        丈万丆丒上丅且上丛 val_8 = new 丈万丆丒上丅且上丛();
        if(val_8 == null)
        {
            goto label_26;
        }
        
        .下丄丈不与世丐业专 = "flag_piedestal";
        .一丌丐业丂不丗不丁 = "Key_5258";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_8 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_26:
        mem[32] = "flag_piedestal";
        mem[16] = "Key_5258";
        mem[24] = "first_Shtab";
        label_28:
        val_1[6] = val_8;
        丈万丆丒上丅且上丛 val_9 = new 丈万丆丒上丅且上丛();
        if(val_9 == null)
        {
            goto label_30;
        }
        
        .下丄丈不与世丐业专 = "igrovoy_avtomat";
        .一丌丐业丂不丗不丁 = "Key_5259";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_9 != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_30:
        mem[32] = "igrovoy_avtomat";
        mem[16] = "Key_5259";
        mem[24] = "first_Shtab";
        label_32:
        val_1[7] = val_9;
        丈万丆丒上丅且上丛 val_10 = new 丈万丆丒上丅且上丛();
        if(val_10 == null)
        {
            goto label_34;
        }
        
        .下丄丈不与世丐业专 = "landscape";
        .一丌丐业丂不丗不丁 = "Key_5260";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_10 != null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_34:
        mem[32] = "landscape";
        mem[16] = "Key_5260";
        mem[24] = "first_Shtab";
        label_36:
        val_1[8] = val_10;
        丈万丆丒上丅且上丛 val_11 = new 丈万丆丒上丅且上丛();
        if(val_11 == null)
        {
            goto label_38;
        }
        
        .下丄丈不与世丐业专 = "radar";
        .一丌丐业丂不丗不丁 = "Key_5261";
        .不丁丙丑丙丈丒丗上 = "first_Shtab";
        if(val_11 != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_38:
        mem[32] = "radar";
        mem[16] = "Key_5261";
        mem[24] = "first_Shtab";
        label_40:
        val_1[9] = val_11;
        QuestsGSMAnager.丌七丅且丕丗丒丈丆 = val_1;
    }
    private bool 世世东丙丗丝丈丝上(丈万丆丒上丅且上丛 丙丒七丄上与丏丙丙)
    {
        if(this.丝丙丌且专丅东丞业 != null)
        {
                return System.String.op_Equality(a:  丙丒七丄上与丏丙丙.下丄丈不与世丐业专, b:  this.丝丙丌且专丅东丞业.CurrentTask);
        }
        
        return System.String.op_Equality(a:  丙丒七丄上与丏丙丙.下丄丈不与世丐业专, b:  this.丝丙丌且专丅东丞业.CurrentTask);
    }
    private bool 丞丂丝丕丅丈一三丄(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏)
    {
        System.Collections.Generic.List<System.String> val_5;
        string val_6;
        var val_7;
        val_5 = this;
        if(this.丝丙丌且专丅东丞业.CompletedQuests == null)
        {
            goto label_2;
        }
        
        val_5 = this.丝丙丌且专丅东丞业.CompletedQuests;
        val_6 = 三且丑东与丝丛丐丏.Item["questId"];
        if(val_5 == null)
        {
            goto label_5;
        }
        
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_10;
        label_2:
        val_7 = 1;
        goto label_8;
        label_5:
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_6:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_10:
        bool val_3 = val_5.Contains(item:  val_6);
        val_7 = val_3 ^ 1;
        label_8:
        val_3 = val_7;
        return (bool)val_3;
    }
    private bool 不丕丈丏丟七丅丆七(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏)
    {
        System.Collections.Generic.List<System.String> val_5;
        string val_6;
        var val_7;
        val_5 = this;
        if(this.丝丙丌且专丅东丞业.CompletedQuests == null)
        {
            goto label_2;
        }
        
        val_5 = this.丝丙丌且专丅东丞业.CompletedQuests;
        val_6 = 三且丑东与丝丛丐丏.Item["questId"];
        if(val_5 == null)
        {
            goto label_5;
        }
        
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_10;
        label_2:
        val_7 = 1;
        goto label_8;
        label_5:
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_6:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_10:
        bool val_3 = val_5.Contains(item:  val_6);
        val_7 = val_3 ^ 1;
        label_8:
        val_3 = val_7;
        return (bool)val_3;
    }

}
