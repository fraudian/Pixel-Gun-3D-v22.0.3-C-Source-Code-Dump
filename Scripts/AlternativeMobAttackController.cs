using UnityEngine;
public class AlternativeMobAttackController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private UnityEngine.Animation _animation;
    private RilisoftBot.BotAiController _botController;
    public Rilisoft.AnimationHandler animationHandler;
    private PhotonView 丅丏三七丁丑丞丄丏;
    private bool _isAlternativeAttackActivate;
    private System.Collections.Generic.List<AlternativeAttackCommonSetting> _listAlternativeAttacks;
    private System.Collections.Generic.List<AlternativeMobAttackController.三丝东专丘丅一三丘> 丟丟丌专且丄不丘一;
    private UnityEngine.Coroutine 丞丅且不丂上万丒丁;
    
    // Properties
    internal UnityEngine.Animation 下丗不丞丄业与世下 { get; }
    internal RilisoftBot.BotAiController 东不上丁丕世丂业专 { get; }
    internal bool 丒丙丂下东丕下丁世 { get; set; }
    
    // Methods
    internal UnityEngine.Animation 丁丗丐丘丝不且与丞()
    {
        return (UnityEngine.Animation)this._animation;
    }
    internal RilisoftBot.BotAiController 七与世丄丞丒一七三()
    {
        return (RilisoftBot.BotAiController)this._botController;
    }
    internal void 专丒丆七丗丕下丁丙(bool 丙业与丙丗丝不丈东)
    {
        this._isAlternativeAttackActivate = 丙业与丙丗丝不丈东;
    }
    internal bool 与上丂丗万上丄丙丅()
    {
        return (bool)this._isAlternativeAttackActivate;
    }
    private void Awake()
    {
        this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
        this._botController.世万不丘丗专上丞业 = this;
        this.丌上丏且专丁不不下();
        if(this._animation == 0)
        {
                return;
        }
        
        this.animationHandler = this._animation.gameObject.AddComponent<Rilisoft.AnimationHandler>();
    }
    private void 丌上丏且专丁不不下()
    {
        一上不上一丅专专丐 val_2;
        string val_3;
        object val_12;
        var val_13;
        var val_14;
        var val_15;
        int val_16;
        val_12 = this;
        List.Enumerator<T> val_1 = this._listAlternativeAttacks.GetEnumerator();
        val_13 = 1152921539882116144;
        val_14 = 1152921539882117168;
        val_15 = 1152921516266839504;
        goto label_2;
        label_14:
        if(val_3.丐丏七丌丕丗业且上() != null)
        {
                val_16 = val_4.m_stringLength;
        }
        else
        {
                val_16 = 11993091;
        }
        
        T[] val_5 = System.Array.Empty<System.Object>();
        BaseTriggerAlternativeAttack val_6 = 且一丝丅丑丘丛且丗.下丙丗丟丂下丏不丟(丘世丐不丈丐丟上业:  this._listAlternativeAttacks, 专丒丌丆下丐丞丟丞:  val_5);
        T[] val_7 = System.Array.Empty<System.Object>();
        一上不上一丅专专丐 val_8 = AlternativeAttackFactory.GetHandler(丘世丐不丈丐丟上业:  val_5, 专丒丌丆下丐丞丟丞:  val_5);
        new System.Action() = new System.Action(object:  val_8, method:  typeof(一上不上一丅专专丐).__il2cppRuntimeField_180);
        val_6.丄丅丏世丘丂丏丈下(业丏丈世世世丞丒世:  new System.Action());
        System.Action<一上不上一丅专专丐> val_10 = new System.Action<一上不上一丅专专丐>(object:  this, method:  System.Void AlternativeMobAttackController::丁七丝专七丕丝七下(一上不上一丅专专丐 丝丏一丌丐丁下丘万));
        val_8.三七丁专丞丝丂丅丕(丙业与丙丗丝不丈东:  null);
        System.Action<一上不上一丅专专丐> val_11 = new System.Action<一上不上一丅专专丐>(object:  this, method:  System.Void AlternativeMobAttackController::三不万上丐世不丞上(一上不上一丅专专丐 丝丏一丌丐丁下丘万));
        val_8.丟东一下丌丏且丄上(丙业与丙丗丝不丈东:  null);
        val_3 = val_16;
        val_2 = val_8;
        this.丟丟丌专且丄不丘一.Add(item:  new 三丝东专丘丅一三丘() {丈丗丂丌丆与丕丆丟 = val_3, 不丆丘丆丌专丑东丈 = val_6, 世万不丘丗专上丞业 = val_2});
        val_14 = val_14;
        val_13 = val_13;
        val_15 = 1152921516266839504;
        label_2:
        if(( & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丁七丝专七丕丝七下(一上不上一丅专专丐 丝丏一丌丐丁下丘万)
    {
        var val_3;
        string val_4;
        string val_9;
        PhotonView val_10;
        this._botController.丝丄丏上与丟世东七(丙业与丙丗丝不丈东:  true);
        this._isAlternativeAttackActivate = true;
        val_9 = "";
        List.Enumerator<T> val_1 = this.丟丟丌专且丄不丘一.GetEnumerator();
        label_4:
        if((915915760 & 1) == 0)
        {
            goto label_3;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
        if(val_3 != 丝丏一丌丐丁下丘万)
        {
            goto label_4;
        }
        
        val_9 = val_4;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_10 = this.丅丏三七丁丑丞丄丏;
        if(val_10.isMine == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_9)) == true)
        {
                return;
        }
        
        object[] val_8 = new object[1];
        val_10 = val_8;
        val_10[0] = val_9;
        this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  211, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_8);
    }
    private void 三不万上丐世不丞上(一上不上一丅专专丐 丝丏一丌丐丁下丘万)
    {
        this._botController.丝丄丏上与丟世东七(丙业与丙丗丝不丈东:  false);
        this._isAlternativeAttackActivate = false;
    }
    private void Update()
    {
        var val_9;
        var val_11;
        if(this._botController.七与世丄丞丒一七三().IsDeath == true)
        {
                return;
        }
        
        RilisoftBot.BaseBot val_3 = this._botController.七与世丄丞丒一七三();
        if(val_3.health <= 0f)
        {
                return;
        }
        
        if(this._botController.丆东三丕世丟丝丐丄() == false)
        {
                return;
        }
        
        if(this.丅丏三七丁丑丞丄丏.isMine == false)
        {
                return;
        }
        
        this = this.丟丟丌专且丄不丘一;
        List.Enumerator<T> val_6 = this.GetEnumerator();
        label_14:
        if((916242064 & 1) == 0)
        {
            goto label_12;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_10 = val_9.RemoteEndpoint;
        if(val_11 != 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丈七世丅与世丗七业(string 丈丗丂丌丆与丕丆丟)
    {
        if((this.丗七丌丝三丌丕丂万(丈丗丂丌丆与丕丆丟:  丈丗丂丌丆与丕丆丟)) == null)
        {
                return;
        }
        
        goto typeof(一上不上一丅专专丐).__il2cppRuntimeField_178;
    }
    private void 七丗专不丂业丗且丙(string 丈丗丂丌丆与丕丆丟, UnityEngine.Vector3 丙东与上丂丈丗丕下)
    {
        if((this.丗七丌丝三丌丕丂万(丈丗丂丌丆与丕丆丟:  丈丗丂丌丆与丕丆丟)) == null)
        {
                return;
        }
    
    }
    internal 一上不上一丅专专丐 丗七丌丝三丌丕丂万(string 丈丗丂丌丆与丕丆丟)
    {
        var val_3;
        string val_4;
        string val_7;
        var val_8;
        val_7 = 丈丗丂丌丆与丕丆丟;
        List.Enumerator<T> val_1 = this.丟丟丌专且丄不丘一.GetEnumerator();
        label_3:
        if((916680336 & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
        val_8 = val_3;
        if((System.String.op_Equality(a:  val_4, b:  val_7)) == false)
        {
            goto label_3;
        }
        
        goto label_4;
        label_2:
        val_8 = 0;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (一上不上一丅专专丐);
    }
    internal string 上丆东与丙丗丌七丛(一上不上一丅专专丐 世万不丘丗专上丞业)
    {
        var val_3;
        var val_4;
        var val_6;
        List.Enumerator<T> val_1 = this.丟丟丌专且丄不丘一.GetEnumerator();
        label_3:
        if((916841360 & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
        if(val_3 != 世万不丘丗专上丞业)
        {
            goto label_3;
        }
        
        val_6 = val_4;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)val_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_6 = "";
        return (string)val_6;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_4;
        object val_5;
        var val_6;
        val_4 = 丞世不丒下上上丝丑;
        byte val_1 = val_4 & 255;
        if(val_1 == 212)
        {
            goto label_1;
        }
        
        if(val_1 != 211)
        {
            goto label_2;
        }
        
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_11;
        }
        
        val_5 = 专丒丌丆下丐丞丟丞[0];
        if((val_5 != null) && (null != null))
        {
                val_5 = 0;
        }
        
        if((this.丗七丌丝三丌丕丂万(丈丗丂丌丆与丕丆丟:  val_5)) == null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        if(专丒丌丆下丐丞丟丞.Length >= 2)
        {
                val_4 = 专丒丌丆下丐丞丟丞[0];
            object val_4 = 专丒丌丆下丐丞丟丞[1];
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            this.七丗专不丂业丗且丙(丈丗丂丌丆与丕丆丟:  val_4, 丙东与上丂丈丗丕下:  new UnityEngine.Vector3() {x = 3.782474E-38f});
        }
        
        label_11:
        val_6 = 1;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
    }
    internal void 丞七丗不丏丁丏丒丐(float 丕丕世且下一与丝与)
    {
        if(this.丞丅且不丂上万丒丁 != null)
        {
                this.StopCoroutine(routine:  this.丞丅且不丂上万丒丁);
        }
        
        this.丞丅且不丂上万丒丁 = this.StartCoroutine(routine:  this.丙丕万丅一七一丙丅(丕丕世且下一与丝与:  丕丕世且下一与丝与));
    }
    internal void 丗东专丈丆世下丌丞()
    {
        if(this.丞丅且不丂上万丒丁 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丞丅且不丂上万丒丁);
    }
    private System.Collections.IEnumerator 丙丕万丅一七一丙丅(float 丕丕世且下一与丝与)
    {
        AlternativeMobAttackController.丒丙丑丐丌丅三七且 val_1 = new AlternativeMobAttackController.丒丙丑丐丌丅三七且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public AlternativeMobAttackController()
    {
        this._listAlternativeAttacks = new System.Collections.Generic.List<AlternativeAttackCommonSetting>();
        this.丟丟丌专且丄不丘一 = new System.Collections.Generic.List<三丝东专丘丅一三丘>();
    }

}
