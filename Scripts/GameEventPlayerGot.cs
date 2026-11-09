using UnityEngine;
internal sealed class GameEventPlayerGot : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>
{
    // Fields
    private const float 丗丑丝与丒不与东丂 = 10;
    private const float 丆丐专丅一丕七丞丑 = 15;
    private static int 丕不丗东丂上丛丌且;
    public AchieveBox box;
    public UnityEngine.GameObject container;
    private bool 丑丑丄丆丝不东丌世;
    private Rilisoft.InAppBonusLobbyViewBase 丄丝七丝丏东丏丝丟;
    public bool inLobby;
    public GameEventItemGui itemGui;
    private float 丝专丅丟万丂丆丆三;
    public UILabel playerGotLabel;
    private bool 与三不丁丈东三七丙;
    private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
    
    // Properties
    private bool 东丌丒丂专丝万丈丙 { get; }
    public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    private bool 丘丈七上丑丑丑丆专()
    {
        var val_14;
        Rilisoft.丛且世丐丆上七业丁 val_15;
        val_14 = this;
        if(this.inLobby != false)
        {
                if(this.丄丝七丝丏东丏丝丟 != 0)
        {
                if(this.丄丝七丝丏东丏丝丟.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_5 = this.丄丝七丝丏东丏丝丟.transform.position;
            val_14 = this.container.transform;
            UnityEngine.Vector3 val_7 = val_14.position;
            var val_9 = ((System.Math.Abs(val_5.x - val_7.x)) < 0) ? 1 : 0;
            return (bool)(val_11 != 0) ? 1 : 0;
        }
        
        }
        
            val_15 = 0;
            return (bool)(val_11 != 0) ? 1 : 0;
        }
        
        val_15 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        if(val_15 == null)
        {
                return (bool)(val_11 != 0) ? 1 : 0;
        }
        
        val_14 = val_15.不业丙丒丂丞下丆丙();
        Rilisoft.上专业三丟丁丞专下 val_11 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丌三丙丙与与丝世();
        if(val_14 != 100)
        {
                return (bool)(val_11 != 0) ? 1 : 0;
        }
        
        var val_12 = (val_11 == 0) ? 1 : 0;
        return (bool)(val_11 != 0) ? 1 : 0;
    }
    public Rilisoft.丛且世丐丆上七业丁 get_Context()
    {
        return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private System.Collections.IEnumerator 丑万不丈世丈丙业不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GameEventPlayerGot.丙世丈丐万丘丆丛业();
    }
    private System.Collections.IEnumerator 万与上丗不丞世丑丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GameEventPlayerGot.丐丏与丌丆下丅丅丏();
    }
    private void 不与与东下业丟不丏()
    {
        var val_8;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        Rilisoft.GameEventData val_4 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁专丗万三上丟三丆();
        val_3.Add(key:  "id_event", value:  val_4.EventId);
        val_8 = null;
        val_8 = null;
        int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.世三与下业丝丐专不, 一丐丗丁丞丆丅丟丄:  val_3, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void GameEventPlayerGot::丄业丕丄七丕丂丏专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        this.丑丑丄丆丝不东丌世 = true;
    }
    private void 丄业丕丄七丕丂丏专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        string val_4 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 0;
        string val_8 = 0;
        string val_15 = 0;
        string val_13 = 0;
        int val_17 = 0;
        this.丑丑丄丆丝不东丌世 = false;
        if(this.与三不丁丈东三七丙 != false)
        {
                return;
        }
        
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == true)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "data", 丙业与丙丗丝不丈东: out  val_2)) == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "id_event", 丙业与丙丗丝不丈东: out  val_4)) == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  val_4, b:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "nick", 丙业与丙丗丝不丈东: out  val_8)) == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "id_player", 丙业与丙丗丝不丈东: out  0)) == true)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        if(0 == GameEventPlayerGot.丕不丗东丂上丛丌且)
        {
                return;
        }
        
        if(0 == 专丈专业丆且且业下.丈不丄丛丛丘东丁丙())
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        GameEventPlayerGot.丕不丗东丂上丛丌且 = 0;
        bool val_14 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "id_item", 丙业与丙丗丝不丈东: out  val_13);
        bool val_16 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "category", 丙业与丙丗丝不丈东: out  val_15);
        bool val_18 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "sub_type", 丙业与丙丗丝不丈东: out  val_17);
        bool val_19 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "count", 丙业与丙丗丝不丈东: out  val_17);
        val_33 = val_15;
        if(val_33 == 0)
        {
                val_33 = System.String.alignConst;
        }
        
        object val_21 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_33);
        PGCompany.三东丏不丗世丅丌丄 val_24 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  PGCompany.专丏丐丄丛丈丄丂丂.丈丏丆丛一丂丐丕丈(丁世万丟不丘不且丏:  1152921504628731904), 丞丅上丏丂且下丅与:  val_13, 丂丕丂丏专丂丄丕且:  0);
        if(new Rilisoft.GameEventItemData() != null)
        {
                .ItemParams = val_24;
            val_34 = 0;
        }
        else
        {
                mem[40] = val_24;
            val_34 = 0;
        }
        
        .SubType = 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.playerGotLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3917"), arg0:  val_8));
        if(this.box != 0)
        {
                System.Collections.IEnumerator val_28 = this.丑万不丈世丈丙业不();
        }
        
        UnityEngine.Coroutine val_30 = this.StartCoroutine(routine:  this.万与上丗不丞世丑丁());
    }
    private void Awake()
    {
        this.container.SetActive(value:  false);
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GameEventPlayerGot::丆与丂且丐与丝且丅()));
    }
    private void 丆与丂且丐与丝且丅()
    {
        this.丑丑丄丆丝不东丌世 = false;
    }
    private void Update()
    {
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) != null)
        {
                if(this.inLobby != false)
        {
                if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世() != 0)
        {
                this.丄丝七丝丏东丏丝丟 = Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世().GetScrollViewForEvent(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        
        }
        
            if(this.丘丈七上丑丑丑丆专() != false)
        {
                if(this.inLobby != false)
        {
                if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
            if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世().CanShowEventNotification == false)
        {
                return;
        }
        
        }
        
            if(this.丑丑丄丆丝不东丌世 == true)
        {
                return;
        }
        
            float val_10 = UnityEngine.Time.time;
            if(this.丝专丅丟万丂丆丆三 >= 0)
        {
                return;
        }
        
            this.不与与东下业丟不丏();
            float val_12 = UnityEngine.Random.Range(min:  10f, max:  15f);
            val_12 = UnityEngine.Time.time + val_12;
            this.丝专丅丟万丂丆丆三 = val_12;
            return;
        }
        
        }
        
        if(this.与三不丁丈东三七丙 == false)
        {
                return;
        }
        
        this.三七丁丄丈丏三业万();
    }
    internal static System.Collections.IEnumerator 丙丟丐世丕下丑上下(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄, int 丌丒丝东丌下丕丁丅, Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
    {
        GameEventPlayerGot.与业丌万丄丕丌万丝 val_1 = new GameEventPlayerGot.与业丌万丄丕丌万丝();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .一丐丗丁丞丆丅丟丄 = 一丐丗丁丞丆丅丟丄;
            .丌丒丝东丌下丕丁丅 = 丌丒丝东丌下丕丁丅;
        }
        else
        {
                mem[40] = 一丐丗丁丞丆丅丟丄;
            mem[48] = 丌丒丝东丌下丕丁丅;
        }
        
        .丅东专与不三丂丁丝 = 丅东专与不三丂丁丝;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnDisable()
    {
        this.三七丁丄丈丏三业万();
    }
    private void OnDestroy()
    {
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GameEventPlayerGot::丆与丂且丐与丝且丅()));
    }
    private void 三七丁丄丈丏三业万()
    {
        this.与三不丁丈东三七丙 = false;
        this.container.SetActive(value:  false);
    }
    public void OnButtonClick()
    {
        if(this.丄丝七丝丏东丏丝丟 == 0)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丄丝七丝丏东丏丝丟 == null)
        {
            
        }
    
    }
    public GameEventPlayerGot()
    {
    
    }
    private static GameEventPlayerGot()
    {
        GameEventPlayerGot.丕不丗东丂上丛丌且 = 0;
    }

}
