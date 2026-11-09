using UnityEngine;
public class PunTurnManager : PunBehaviour
{
    // Fields
    public float TurnDuration;
    public 丈一业丘丝丛不丙专 TurnManagerListener;
    private readonly System.Collections.Generic.HashSet<与丅丕丈丘东丝世丟> 不不丝丆丕且一丛丒;
    public const byte TurnManagerEventOffset = 0;
    public const byte EvMove = 1;
    public const byte EvFinalMove = 2;
    private bool 丑且丄丗专丅世不丒;
    
    // Properties
    public int 业一丏丏丐丅且与丅 { get; set; }
    public float 专丏业丅丛三不丟不 { get; }
    public float 丗丆丈丘丙业且万丕 { get; }
    public bool 上丕丒丒且丄专丕丟 { get; }
    public bool 与世世丄丝丂上专丂 { get; }
    public bool 丟世东丁丑丐丑丙丌 { get; }
    
    // Methods
    public int get_Turn()
    {
        return 专业下丏丂丞丝丝东.下上丒丛七不丛一不(丛下丄业丈东丆一丄:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且());
    }
    private void 丕丗丝业业业与丄丘(int 丙业与丙丗丝不丈东)
    {
        this.丑且丄丗专丅世不丒 = false;
        专业下丏丂丞丝丝东.丐七丕丞丒丁上世丅(丛下丄业丈东丆一丄:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且(), 丁丕上丕与丟丌丛上:  丙业与丙丗丝不丈东, 丄一丅丌丗业下丄不:  true);
    }
    public float get_ElapsedTimeInTurn()
    {
        float val_5 = 1000f;
        val_5 = ((float)丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕() - (专业下丏丂丞丝丝东.丄丞丒丂丙丈世丒丝(丛下丄业丈东丆一丄:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且()))) / val_5;
        return (float)val_5;
    }
    public float get_RemainingSecondsInTurn()
    {
        return UnityEngine.Mathf.Max(a:  0f, b:  this.TurnDuration - this.ElapsedTimeInTurn);
    }
    public bool get_IsCompletedByAll()
    {
        var val_7;
        var val_8;
        val_7 = this;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
                return (bool)val_8;
        }
        
        if(val_1.Turn >= 1)
        {
                val_7 = this.不不丝丆丕且一丛丒.Count;
            var val_6 = (val_7 == 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒()) ? 1 : 0;
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public bool get_IsFinishedByMe()
    {
        if(this.不不丝丆丕且一丛丒 != null)
        {
                return this.不不丝丆丕且一丛丒.Contains(item:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        }
        
        return this.不不丝丆丕且一丛丒.Contains(item:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
    }
    public bool get_IsOver()
    {
        return (bool)(this.RemainingSecondsInTurn <= 0f) ? 1 : 0;
    }
    private void Start()
    {
        丅丒丗丑丒丙丛不丆.丈丘丝丁上丄且七丛(丙业与丙丗丝不丈东:  new 丅丒丗丑丒丙丛不丆.且专丆下丆丐丏东丂(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void PunTurnManager::OnEvent(byte 丏不丅一丈丅万丗一, object 三丏丑不业丏不丂丈, int 万丕丅下丒丗丐丐丘)));
    }
    private void Update()
    {
        if(this.Turn < 1)
        {
                return;
        }
        
        if(this.RemainingSecondsInTurn > 0f)
        {
                return;
        }
        
        if(this.丑且丄丗专丅世不丒 != false)
        {
                return;
        }
        
        this.丑且丄丗专丅世不丒 = true;
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.TurnManagerListener.万丄丑丑七七丗丞丕(丁丕上丕与丟丌丛上:  this.Turn);
    }
    public void BeginTurn()
    {
        this.丕丗丝业业业与丄丘(丙业与丙丗丝不丈东:  this.Turn + 1);
    }
    public void SendMove(object 三丑丏世丂丆丕丈专, bool 丄三专丕丛丘世丆专)
    {
        丗业三丆丅丐丗不丏 val_11;
        if(this.IsFinishedByMe != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Can\'t SendMove. Turn is finished by this player.");
            return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        int val_3 = val_2.Turn;
        if(val_2 != null)
        {
                val_2.Add(key:  "turn", value:  val_3);
        }
        else
        {
                0.Add(key:  "turn", value:  val_3);
        }
        
        0.Add(key:  "move", value:  三丑丏世丂丆丕丈专);
        byte val_4 = (丄三专丕丛丘世丆专 != true) ? (1 + 1) : 1;
        丗业三丆丅丐丗不丏 val_5 = null;
        val_11 = val_5;
        val_5 = new 丗业三丆丅丐丗不丏();
        .三三丞丗专丄不不世 = 4;
        bool val_6 = 丅丒丗丑丒丙丛不丆.一丗丁东丑下丛丟丟(丏不丅一丈丅万丗一:  val_4, 不丙丒丌专丄丂丑专:  val_2, 不三七丈丕丘丐丝与:  true, 丆与丛丅丂三万一丑:  val_5);
        if(丄三专丕丛丘世丆专 != false)
        {
                与丅丕丈丘东丝世丟 val_7 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            val_11 = val_7.Turn;
            专业下丏丂丞丝丝东.丘丈丈上丗丛丛东丟(专丞上七七且丝七丗:  val_7, 丁丕上丕与丟丌丛上:  val_11);
        }
        
        this.OnEvent(丏不丅一丈丅万丗一:  val_4, 三丏丑不业丏不丂丈:  val_2, 万丕丅下丒丗丐丐丘:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
    }
    public bool GetPlayerFinishedTurn(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_2;
        if((专丞上七七且丝七丗 != null) && (this.不不丝丆丕且一丛丒 != null))
        {
                if((this.不不丝丆丕且一丛丒.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public void OnEvent(byte 丏不丅一丈丅万丗一, object 三丏丑不业丏不丂丈, int 万丕丅下丒丗丐丐丘)
    {
        object val_21;
        var val_22;
        与丅丕丈丘东丝世丟 val_23;
        var val_24;
        var val_27;
        var val_28;
        丈一业丘丝丛不丙专 val_29;
        val_21 = 三丏丑不业丏不丂丈;
        val_22 = this;
        byte val_2 = 丏不丅一丈丅万丗一 & 255;
        val_23 = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  万丕丅下丒丗丐丐丘);
        if(val_2 == 2)
        {
            goto label_1;
        }
        
        if(val_2 != 1)
        {
                return;
        }
        
        object val_3 = 0.Item["turn"];
        var val_13 = 0;
        val_24 = 1152921505111035912;
        val_13 = val_13 + 1;
        val_24 = 1152921505111035928;
        goto label_11;
        label_1:
        object val_5 = 0.Item["turn"];
        val_28 = 0;
        object val_6 = 0.Item["move"];
        val_21 = val_6;
        if(null != val_6.Turn)
        {
            goto label_16;
        }
        
        bool val_8 = this.不不丝丆丕且一丛丒.Add(item:  val_23);
        val_29 = this.TurnManagerListener;
        var val_14 = 0;
        val_24 = 1152921505111035912;
        val_14 = val_14 + 1;
        goto label_22;
        label_11:
        val_22 = ???;
        val_23 = ???;
        val_27 = ???;
        val_21 = ???;
        val_29 = ???;
        this.TurnManagerListener.丞丌万不专丆丑丌丈(专丞上七七且丝七丗:  val_23, 丁丕上丕与丟丌丛上:  21884928, 三丑丏世丂丆丕丈专:  0.Item["move"]);
        return;
        label_22:
        val_28 = 1152921504628731904;
        val_29.丒万丞丁业丟丙丂丄(专丞上七七且丝七丗:  val_23, 丁丕上丕与丟丌丛上:  21884928, 三丑丏世丂丆丕丈专:  val_21);
        label_16:
        bool val_10 = this.IsCompletedByAll;
        if(val_10 == false)
        {
                return;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_28 = 1;
        this.TurnManagerListener.丕丄丁下专上丗丈与(丁丕上丕与丟丌丛上:  val_10.Turn);
    }
    public override void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        if((业上上东丑东丞丗不.ContainsKey(key:  "Turn")) == false)
        {
                return;
        }
        
        this.丑且丄丗专丅世不丒 = false;
        this.不不丝丆丕且一丛丒.Clear();
        var val_4 = 0;
        val_4 = val_4 + 1;
        public System.Boolean System.Collections.Generic.Dictionary<System.Object, System.Object>::ContainsKey(System.Object key) = 0;
        this.TurnManagerListener.下业丐一丑且丟丛丞(丁丕上丕与丟丌丛上:  this.不不丝丆丕且一丛丒.Turn);
    }
    public PunTurnManager()
    {
        this.TurnDuration = 20f;
        this.不不丝丆丕且一丛丒 = new System.Collections.Generic.HashSet<与丅丕丈丘东丝世丟>();
    }

}
