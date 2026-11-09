using UnityEngine;
public sealed class TimeLabel : MonoBehaviour
{
    // Fields
    private UILabel 一丙且丛丟丈丙且与;
    public UnityEngine.AudioSource timerSound;
    public UnityEngine.ParticleSystem timerParticles;
    private UnityEngine.Vector3 丈丅上上三丑丝丅丑;
    private bool 丅与丅丝丈世丑丐丗;
    private float 与丕丌丒丗丄丘丙东;
    private float 东丌丆一专与丝丕丝;
    
    // Methods
    private void Start()
    {
        var val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        val_1.SetActive(value:  true);
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
        return;
        label_3:
        bool val_4 = GameConnect.丛专丌且丕不专丈下();
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    private void Update()
    {
        var val_24;
        UILabel val_71;
        var val_73;
        float val_75;
        var val_76;
        var val_77;
        double val_78;
        var val_79;
        var val_80;
        float val_81;
        float val_82;
        float val_85;
        double val_86;
        var val_87;
        float val_88;
        float val_90;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        var val_101;
        val_71 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.一丙且丛丟丈丙且与)) == false)
        {
                return;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_6;
        }
        
        val_71 = this.一丙且丛丟丈丙且与;
        string val_4 = SpeedrunTrackController.丛专与丅下丌丆世丒 + 160.ToString(format:  "F1");
        goto label_8;
        label_6:
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_11;
        }
        
        val_73 = null;
        val_73 = null;
        val_75 = DuelController.丄丘七三上丕世丞业.timeLeft;
        goto label_177;
        label_11:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_18;
        }
        
        val_75 = TeamDuelController.丅丌丛丏丞上万丛丕.timeLeft;
        goto label_177;
        label_18:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_23;
        }
        
        val_76 = null;
        val_76 = null;
        val_75 = SiegeController.三三万丆下一丗万丛.timeLeft;
        goto label_177;
        label_23:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_30;
        }
        
        val_77 = 1152921505244278784;
        val_75 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.timeLeft;
        if(val_75 <= (float)PlantTheBombController.丆丕丝丒不丙且丐丗.世七丈丕丑上丟丘丟)
        {
            goto label_177;
        }
        
        label_176:
        val_78 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 48];
        val_78 = PlantTheBombController.丆丕丝丒不丙且丐丗.世七丈丕丑上丟丘丟;
        goto label_47;
        label_30:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_38;
        }
        
        val_77 = 1152921505233256448;
        val_79 = null;
        val_79 = null;
        val_75 = MutationController.丆丕丝丒不丙且丐丗.丙世丑丅丒丑业与不();
        if(val_75 <= (float)MutationController.丆丕丝丒不丙且丐丗.丛丙专一七上下三丐)
        {
            goto label_177;
        }
        
        val_80 = null;
        val_80 = null;
        val_78 = mem[MutationController.丆丕丝丒不丙且丐丗 + 88];
        val_78 = MutationController.丆丕丝丒不丙且丐丗.丛丙专一七上下三丐;
        goto label_47;
        label_38:
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_50;
        }
        
        val_77 = 1152921505252212736;
        val_75 = RedLightController.Instance.丙世丑丅丒丑业与不();
        if(val_75 <= (float)RedLightController.Instance.matchTime)
        {
            goto label_177;
        }
        
        val_78 = mem[RedLightController.Instance + 72];
        val_78 = RedLightController.Instance.matchTime;
        label_47:
        val_75 = (float)val_78;
        label_177:
        val_81 = 0f;
        float val_17 = UnityEngine.Mathf.Max(a:  val_81, b:  val_75);
        if(val_17 > this.与丕丌丒丗丄丘丙东)
        {
            goto label_57;
        }
        
        val_81 = this.东丌丆一专与丝丕丝;
        if(val_81 != val_17)
        {
            goto label_58;
        }
        
        label_57:
        this.timerParticles.gameObject.SetActive(value:  false);
        this.timerSound.enabled = false;
        UnityEngine.Color val_19 = UnityEngine.Color.white;
        val_82 = val_19.a;
        this.一丙且丛丟丈丙且与.color = new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_82};
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        val_85 = val_21.y;
        this.一丙且丛丟丈丙且与.transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_85, z = val_21.z};
        TweenRotation val_22 = this.一丙且丛丟丈丙且与.GetComponentInChildren<TweenRotation>();
        if(val_22 == 0)
        {
            goto label_145;
        }
        
        if(val_22 == null)
        {
            goto label_71;
        }
        
        val_22.ResetToBeginning();
        goto label_72;
        label_58:
        this.东丌丆一专与丝丕丝 = val_17;
        if(val_17 >= 0f)
        {
            goto label_75;
        }
        
        val_86 = -0.5;
        if((double)val_17 != val_86)
        {
            goto label_76;
        }
        
        val_87 = val_24;
        val_88 = -1f;
        goto label_77;
        label_71:
        0.ResetToBeginning();
        label_72:
        val_22.enabled = false;
        label_145:
        if(GameConnect.丒丗丁丙丗丄丙不丐() != false)
        {
                val_77 = 1152921505244278784;
            if(PlantTheBombController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(PlantTheBombController.丆丕丝丒不丙且丐丗.丟不丏丈丗丘丕丐丒() != false)
        {
                UnityEngine.Color val_28 = UnityEngine.Color.red;
            val_85 = val_28.g;
            val_82 = val_28.a;
            this.一丙且丛丟丈丙且与.color = new UnityEngine.Color() {r = val_28.r, g = val_85, b = val_28.b, a = val_82};
        }
        
        }
        
        }
        
        val_71 = this.一丙且丛丟丈丙且与;
        label_8:
        val_71.text = Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  UnityEngine.Mathf.Max(a:  0f, b:  val_75));
        return;
        label_75:
        val_86 = 0.5;
        if((double)val_17 != val_86)
        {
            goto label_92;
        }
        
        val_87 = val_24;
        val_88 = 1f;
        label_77:
        float val_71 = (float)val_87;
        val_86 = val_71 + val_88;
        val_71 = (((long)val_87 & 1) != 0) ? (val_71) : (val_86);
        goto label_94;
        label_76:
        float val_72 = -0.5f;
        val_72 = val_17 + val_72;
        goto label_94;
        label_92:
        float val_73 = 0.5f;
        val_73 = val_17 + val_73;
        label_94:
        val_90 = val_73 - val_17;
        this.丅与丅丝丈世丑丐丗 = (val_90 > 0f) ? 1 : 0;
        UnityEngine.Vector3 val_34 = this.一丙且丛丟丈丙且与.transform.localScale;
        if(this.丅与丅丝丈世丑丐丗 != false)
        {
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.one;
            float val_74 = 1.4f;
            float val_36 = this.与丕丌丒丗丄丘丙东 - val_17;
            val_36 = val_36 / 20f;
            val_74 = val_36 + val_74;
            val_90 = val_35.x;
            val_86 = val_35.y;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_90, y = val_86, z = val_35.z}, d:  UnityEngine.Mathf.Min(a:  val_74, b:  2f));
        }
        else
        {
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.one;
        }
        
        float val_40 = (this.丅与丅丝丈世丑丐丗 == true) ? 12f : 2.4f;
        val_40 = UnityEngine.Time.deltaTime * val_40;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, target:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, maxDistanceDelta:  val_40);
        this.一丙且丛丟丈丙且与.transform.localScale = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
        if(this.丅与丅丝丈世丑丐丗 != false)
        {
                UnityEngine.Color val_43 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_44 = UnityEngine.Color.white;
        }
        
        this.一丙且丛丟丈丙且与.color = new UnityEngine.Color() {r = val_44.r, g = val_44.g, b = val_44.b, a = val_44.a};
        TweenRotation val_45 = this.一丙且丛丟丈丙且与.GetComponentInChildren<TweenRotation>();
        if(val_45 != 0)
        {
                if(val_45 != null)
        {
                val_45.enabled = true;
        }
        else
        {
                0.enabled = true;
        }
        
            val_45.PlayForward();
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.timerSound.playOnAwake = true;
            val_97 = 1;
        }
        else
        {
                this.timerSound.playOnAwake = false;
            val_97 = 0;
        }
        
        this.timerSound.enabled = false;
        this.timerSound.loop = true;
        if(PauseGUIController.丑七不且上丗丁一世() != 0)
        {
                if(PauseGUIController.丑七不且上丗丁一世().IsPaused == true)
        {
            goto label_135;
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.不东七三丂专丐丆丈() == false)
        {
            goto label_135;
        }
        
        }
        
        val_98 = val_71;
        UnityEngine.GameObject val_54 = this.timerParticles.gameObject;
        val_99 = 1;
        goto label_138;
        label_135:
        val_98 = val_71;
        val_99 = 0;
        label_138:
        this.timerParticles.gameObject.SetActive(value:  false);
        TextureSheetAnimationModule val_56 = this.timerParticles.textureSheetAnimation;
        int val_58 = val_24.丙东专丂世丈丏丁丂();
        float val_59 = val_17 + (-1f);
        val_59 = val_59 / 9f;
        if(val_17 >= 0)
        {
            goto label_145;
        }
        
        this.timerParticles.gameObject.SetActive(value:  false);
        goto label_145;
        label_50:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_148;
        }
        
        val_100 = null;
        val_100 = null;
        float val_62 = DungeonsController.丄丘七三上丕世丞业.timeLeft;
        goto label_177;
        label_148:
        if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_155;
        }
        
        if((MiniGamesController.丑七不且上丗丁一世() == 0) || (MiniGamesController.丑七不且上丗丁一世() != null))
        {
            goto label_177;
        }
        
        goto label_177;
        label_155:
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_167;
        }
        
        val_101 = null;
        val_101 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_171;
        }
        
        }
        
        label_171:
        var val_68 = (null == null) ? GameController.onlineMode : 0;
        float val_69 = onlineMode == null ? GameController.onlineMode : 0 + 512.东下七上专丞一七万();
        goto label_177;
        label_167:
        if(TimeGameController.丄丞丁丈与业上丞丟 != 0)
        {
            goto label_176;
        }
        
        goto label_177;
    }
    public TimeLabel()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.丈丅上上三丑丝丅丑 = val_1;
        mem[1152921540535593300] = val_1.y;
        mem[1152921540535593304] = val_1.z;
        this.与丕丌丒丗丄丘丙东 = 11f;
    }

}
