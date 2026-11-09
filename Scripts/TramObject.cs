using UnityEngine;
public class TramObject : MonoBehaviour
{
    // Fields
    public float allPathProgress;
    public float wheelsSpeed;
    public float[] forwardSpeed;
    public float backwardSpeed;
    public float accelerationSpeed;
    public bool isMoving;
    public bool movingBackward;
    private int 丅七丌东丛丒丒不丅;
    public float startRotateDist;
    public PlatformController tramPlatform;
    public UnityEngine.Transform ramPoint;
    private float 业上一丏丕丝七丒丁;
    private float 三且丅七丂七万丗丌;
    public UnityEngine.Bounds detectBound;
    public UnityEngine.Animation _animation;
    public UnityEngine.AudioClip startMoveSound;
    public UnityEngine.AudioClip stopMoveSound;
    public UnityEngine.AudioClip startAttackSound;
    public UnityEngine.AudioClip attackSound;
    public UnityEngine.GameObject moveSoundGameObject;
    private UnityEngine.AudioSource 不丆丏丄丐且丗丆丟;
    private bool 丒丏丄东丞下丌丁丏;
    private float 丐上丁丛丞丘东三不;
    private bool 丐丁丛丗专丛丆丄丞;
    private float 丒丌丅丁不丏丅七下;
    private bool 下丈万东不丁丒丐世;
    private bool 丈万丝丁丞丙不万丘;
    private float 一三专东丞不上丅丟;
    private bool 且七丝丞丝下七丏丂;
    private bool 三丟不丑东丈且丝丑;
    private float 丞丂丄丁丅万业业下;
    private float 下丈丑三丂一丘万丈;
    
    // Properties
    public float 丑专丂下且丘丛丆丗 { get; }
    
    // Methods
    public float get_tramDamage()
    {
        return BalanceController.专丏与下专且万上丛(丆万一不丌且东丐丐:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject));
    }
    private void Awake()
    {
        this.不丆丏丄丐且丗丆丟 = this.GetComponent<UnityEngine.AudioSource>();
    }
    private void Start()
    {
        if(PlatformsList.丄丘七三上丕世丞业 != 0)
        {
                PlatformController[] val_2 = new PlatformController[1];
            val_2[0] = this.tramPlatform;
            PlatformsList.丄丘七三上丕世丞业.platforms = val_2;
        }
        
        this.forwardSpeed = new float[3];
        string val_5 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        this.forwardSpeed[0] = BalanceController.丒丘三一与丆一一丙(丆万一不丌且东丐丐:  val_5);
        float val_7 = BalanceController.一丌丛丂丝丁不东三(丆万一不丌且东丐丐:  val_5);
        float val_11 = val_7;
        val_7 = val_11 + 1f;
        val_11 = val_7 * this.forwardSpeed[0];
        this.forwardSpeed[1] = val_11;
        float val_8 = BalanceController.一丌丛丂丝丁不东三(丆万一不丌且东丐丐:  val_5);
        float val_13 = val_8;
        val_8 = val_13 + 1f;
        val_13 = val_8 * this.forwardSpeed[1];
        this.forwardSpeed[2] = val_13;
        this.backwardSpeed = BalanceController.丞丟三下丟下丞世丟(丆万一不丌且东丐丐:  val_5);
    }
    public void SetMoving(bool 三丑丏世丂丆丕丈专, bool 丁业丈丄丐丒丏丅丙, int 丅七丌东丛丒丒不丅)
    {
        this.isMoving = 三丑丏世丂丆丕丈专;
        this.movingBackward = 丁业丈丄丐丒丏丅丙;
        this.丅七丌东丛丒丒不丅 = 丅七丌东丛丒丒不丅;
    }
    public void CorrectProgress(float 上丕丈丞丌丘丅不与)
    {
        float val_3 = System.Math.Abs(上丕丈丞丌丘丅不与 - this.allPathProgress);
        if(val_3 > 0.3f)
        {
                this.allPathProgress = 上丕丈丞丌丘丅不与;
            this.七丒下丂丝且丕丌东();
            return;
        }
        
        this.业上一丏丕丝七丒丁 = val_3;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_3 * val_2;
        this.三且丅七丂七万丗丌 = val_2;
    }
    public void SetProgress(float 上丕丈丞丌丘丅不与)
    {
        this.allPathProgress = 上丕丈丞丌丘丅不与;
        this.七丒下丂丝且丕丌东();
    }
    public void Reset()
    {
        this.丐上丁丛丞丘东三不 = 0f;
        this.isMoving = false;
        this.movingBackward = false;
        this.丐丁丛丗专丛丆丄丞 = false;
    }
    private void 七丒下丂丝且丕丌东()
    {
        float val_70;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        TramPath val_76;
        float val_80;
        float val_81;
        float val_82;
        TramPath val_83;
        TramPath val_84;
        float val_85;
        float val_86;
        float val_87;
        var val_89;
        float val_90;
        float val_91;
        float val_92;
        float val_93;
        float val_94;
        float val_95;
        float val_96;
        int val_1 = UnityEngine.Mathf.FloorToInt(f:  this.allPathProgress);
        val_70 = this.allPathProgress;
        TramPath val_2 = TramController.丄丘七三上丕世丞业.GetPathByIndex(丞世不丒下上上丝丑:  val_1);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        val_72 = val_4.x;
        val_73 = val_4.y;
        val_74 = val_4.z;
        val_75 = val_4.w;
        val_76 = UnityEngine.Object.op_Inequality(x:  val_2.next, y:  0);
        UnityEngine.Vector3 val_7 = val_2.transform.position;
        val_80 = val_7.x;
        val_81 = val_7.y;
        val_82 = val_7.z;
        if(val_76 == false)
        {
            goto label_12;
        }
        
        float val_67 = (float)val_1;
        val_67 = val_70 - val_67;
        UnityEngine.Vector3 val_9 = val_2.next.transform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_80, y = val_81, z = val_82}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, t:  val_67);
        val_80 = val_10.x;
        UnityEngine.Vector3 val_12 = val_2.next.transform.position;
        UnityEngine.Vector3 val_14 = val_2.transform.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_70 = val_15.z;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_70});
        val_72 = val_16.x;
        val_73 = val_16.y;
        val_74 = val_16.z;
        val_75 = val_16.w;
        if(val_67 < 0.5f)
        {
            goto label_22;
        }
        
        val_83 = val_2.next;
        val_84 = val_2;
        if(val_83 != null)
        {
            goto label_24;
        }
        
        val_84 = val_2;
        goto label_24;
        label_12:
        if(val_2.back == 0)
        {
            goto label_89;
        }
        
        UnityEngine.Vector3 val_19 = val_2.transform.position;
        UnityEngine.Vector3 val_21 = val_2.back.transform.position;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        val_70 = val_22.z;
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_70});
        val_72 = val_23.x;
        val_73 = val_23.y;
        val_74 = val_23.z;
        val_75 = val_23.w;
        goto label_35;
        label_22:
        val_84 = val_2.back;
        val_83 = val_2;
        label_24:
        val_76 = val_2.next;
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.identity;
        if(((val_84 == 0) || (val_83 == 0)) || (val_76 == 0))
        {
            goto label_46;
        }
        
        float val_28 = val_67 * val_2.distance;
        float val_30 = UnityEngine.Mathf.Min(a:  val_2.distance * 0.5f, b:  this.startRotateDist);
        if(val_67 < 0.5f)
        {
            goto label_49;
        }
        
        val_70 = this.startRotateDist;
        val_85 = UnityEngine.Mathf.Min(a:  val_30, b:  UnityEngine.Mathf.Min(a:  val_2.distance * 0.5f, b:  val_70));
        float val_68 = val_2.distance;
        val_68 = val_68 - val_28;
        if(val_68 > val_85)
        {
            goto label_53;
        }
        
        UnityEngine.Vector3 val_35 = val_76.transform.position;
        UnityEngine.Vector3 val_37 = val_83.transform.position;
        val_86 = val_37.x;
        val_86 = val_86;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_86, y = val_37.y, z = val_37.z});
        val_87 = val_38.z;
        UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_87});
        float val_69 = val_2.back.distance;
        val_89 = 0;
        val_69 = val_85 + val_69;
        val_90 = val_69 - val_28;
        val_91 = val_85 + val_85;
        val_92 = val_90 / val_91;
        goto label_77;
        label_49:
        val_70 = this.startRotateDist;
        val_85 = UnityEngine.Mathf.Min(a:  val_30, b:  UnityEngine.Mathf.Min(a:  val_2.back.distance * 0.5f, b:  val_70));
        if(val_28 <= val_85)
        {
            goto label_66;
        }
        
        label_53:
        val_80 = val_80;
        label_46:
        val_81 = val_10.y;
        label_35:
        val_82 = val_82;
        label_89:
        this.transform.position = new UnityEngine.Vector3() {x = val_80, y = val_81, z = val_82};
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_72, y = val_73, z = val_74, w = val_75};
        return;
        label_66:
        UnityEngine.Vector3 val_46 = val_83.transform.position;
        UnityEngine.Vector3 val_48 = val_84.transform.position;
        val_93 = val_48.x;
        val_93 = val_93;
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, b:  new UnityEngine.Vector3() {x = val_93, y = val_48.y, z = val_48.z});
        val_91 = val_49.y;
        val_87 = val_49.z;
        UnityEngine.Quaternion val_50 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_49.x, y = val_91, z = val_87});
        float val_70 = val_28;
        val_70 = val_70 + val_85;
        val_92 = val_70 / (val_85 + val_85);
        val_90 = 1f - val_92;
        if(val_83 != null)
        {
                val_89 = 0;
        }
        else
        {
                val_89 = 1;
        }
        
        label_77:
        UnityEngine.Vector3 val_53 = val_83.transform.position;
        UnityEngine.Vector3 val_55 = val_84.transform.position;
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, b:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, t:  val_85 / val_2.back.distance);
        val_94 = val_92;
        UnityEngine.Vector3 val_59 = val_83.transform.position;
        val_95 = val_59.x;
        UnityEngine.Vector3 val_61 = val_76.transform.position;
        val_96 = val_61.y;
        if(val_89 != 0)
        {
                val_96 = val_96;
            val_85 = val_85;
            val_94 = val_94;
            val_95 = val_95;
        }
        
        UnityEngine.Vector3 val_63 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_95, y = val_59.y, z = val_59.z}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_96, z = val_61.z}, t:  val_85 / val_2.distance);
        UnityEngine.Vector3 val_64 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z}, b:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, t:  val_90);
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, b:  new UnityEngine.Vector3() {x = val_80, y = val_10.y, z = val_82}, t:  val_94);
        UnityEngine.Quaternion val_66 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_50.x, y = val_50.y, z = val_50.z, w = val_50.w}, b:  new UnityEngine.Quaternion() {x = val_72, y = val_73, z = val_74, w = val_75}, t:  val_94);
        goto label_89;
    }
    private void 丛丏丕丂丆丙丅丏万()
    {
        float val_9;
        bool val_10;
        if(this.丐丁丛丗专丛丆丄丞 != false)
        {
                bool val_1 = this._animation.IsPlaying(name:  "attack");
            val_9 = this.丐上丁丛丞丘东三不;
        }
        else
        {
                val_9 = this;
            float val_8 = this.丐上丁丛丞丘东三不;
            val_8 = val_8 / this.wheelsSpeed;
            this._animation.Item["ride"].speed = val_8;
            if((this._animation.IsPlaying(name:  "ride")) != true)
        {
                bool val_4 = this._animation.Play(animation:  "ride");
        }
        
        }
        
        if(this.丐上丁丛丞丘东三不 != 0f)
        {
            goto label_9;
        }
        
        label_11:
        val_10 = 0;
        goto label_10;
        label_9:
        if(this.isMoving == false)
        {
            goto label_11;
        }
        
        bool val_9 = this.丐丁丛丗专丛丆丄丞;
        val_9 = val_9 ^ 1;
        val_10 = val_9 & 255;
        label_10:
        if(val_10 == this.丒丏丄东丞下丌丁丏)
        {
                return;
        }
        
        this.丒丏丄东丞下丌丁丏 = val_10;
        if(this.不丆丏丄丐且丗丆丟 == 0)
        {
            goto label_15;
        }
        
        if(val_10 == false)
        {
            goto label_16;
        }
        
        val_10 = this.startMoveSound;
        if(this.不丆丏丄丐且丗丆丟 != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        this.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  val_10);
        label_15:
        if(this.moveSoundGameObject == 0)
        {
                return;
        }
        
        this.moveSoundGameObject.SetActive(value:  (this.丒丏丄东丞下丌丁丏 == true) ? 1 : 0);
        return;
        label_16:
        if(this.不丆丏丄丐且丗丆丟 != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private void 七丅且丘不丝丄丁东()
    {
        var val_10;
        bool val_11;
        float val_12;
        bool val_13;
        var val_14;
        var val_15;
        var val_16;
        int val_17;
        string val_18;
        var val_19;
        var val_20;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(SiegeController.三三万丆下一丗万丛.isRoundEnding == true)
        {
                return;
        }
        
        val_11 = this.isMoving;
        if(val_11 != false)
        {
                if(this.movingBackward != false)
        {
                val_11 = 0;
        }
        else
        {
                if(this.丐丁丛丗专丛丆丄丞 != false)
        {
                val_11 = 1;
        }
        else
        {
                val_12 = this.丐上丁丛丞丘东三不;
            bool val_3 = (val_12 >= 0f) ? 1 : 0;
        }
        
        }
        
        }
        
        if(val_3 != this.下丈万东不丁丒丐世)
        {
                this.下丈万东不丁丒丐世 = val_3;
            this.一三专东丞不上丅丟 = 1.5f;
        }
        
        val_13 = this.movingBackward;
        if(val_13 != false)
        {
                if(this.丐丁丛丗专丛丆丄丞 != false)
        {
                val_13 = 0;
        }
        else
        {
                val_12 = this.丐上丁丛丞丘东三不;
            bool val_4 = (val_12 < 0) ? 1 : 0;
        }
        
        }
        
        if(val_4 != this.丈万丝丁丞丙不万丘)
        {
                this.丈万丝丁丞丙不万丘 = val_4;
            if(val_4 != 0)
        {
                val_14 = null;
            val_14 = null;
            SiegeController.三三万丆下一丗万丛.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4742"), 专业万丗丐丙丕丕下:  false);
        }
        
        }
        
        if(this.一三专东丞不上丅丟 <= 0f)
        {
                return;
        }
        
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = this.一三专东丞不上丅丟 - val_6;
        this.一三专东丞不上丅丟 = val_6;
        if(val_6 > 0f)
        {
                return;
        }
        
        if(((this.下丈万东不丁丒丐世 == true) ? 1 : 0) == ((this.且七丝丞丝下七丏丂 == true) ? 1 : 0))
        {
                return;
        }
        
        this.且七丝丞丝下七丏丂 = this.下丈万东不丁丒丐世;
        if(this.下丈万东不丁丒丐世 == false)
        {
            goto label_27;
        }
        
        val_15 = null;
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
            goto label_28;
        }
        
        val_16 = null;
        val_17 = SiegeController.三三万丆下一丗万丛;
        val_18 = "Key_4745";
        goto label_38;
        label_27:
        val_19 = null;
        val_19 = null;
        val_17 = SiegeController.三三万丆下一丗万丛;
        val_18 = "Key_4740";
        goto label_38;
        label_28:
        val_20 = null;
        val_17 = SiegeController.三三万丆下一丗万丛;
        val_18 = "Key_4741";
        label_38:
        val_17.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_18), 专业万丗丐丙丕丕下:  false);
    }
    private void 丑丆丕专丁丘且丏一()
    {
        var val_7;
        var val_8;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丒丌丅丁不丏丅七下 - val_2;
        this.丒丌丅丁不丏丅七下 = val_2;
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
                return;
        }
        
        if(this.isMoving == false)
        {
                return;
        }
        
        if(this.movingBackward == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(FortEquipmentController.丝丘丞不丂丆不丘且.IsGatesBroken() == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(SiegeController.三三万丆下一丗万丛.isRoundEnding == true)
        {
                return;
        }
        
        if(this.丒丌丅丁不丏丅七下 > 0f)
        {
                return;
        }
        
        TramController.丄丘七三上丕世丞业.SendGateAttack();
        this.丒丌丅丁不丏丅七下 = this._animation.Item["attack"].length;
    }
    public System.Collections.IEnumerator AttackGate(float 丄东丙丄丞三万世丂)
    {
        TramObject.七东万丂丂上丑丑丏 val_1 = new TramObject.七东万丂丂上丑丑丏();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丄东丙丄丞三万世丂 = 丄东丙丄丞三万世丂;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丏丞下丄一丟东丑丛()
    {
        this._animation.Stop();
        bool val_1 = this._animation.Play(animation:  "attack");
    }
    public bool IsMovingForward()
    {
        if(this.movingBackward == true)
        {
                return false;
        }
        
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
                return (bool)(this.丐上丁丛丞丘东三不 > 0f) ? 1 : 0;
        }
        
        return false;
    }
    public bool IsMovingBack()
    {
        if(this.movingBackward == false)
        {
                return false;
        }
        
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
                return (bool)(this.丐上丁丛丞丘东三不 < 0) ? 1 : 0;
        }
        
        return false;
    }
    private void Update()
    {
        float val_23;
        float val_24;
        int val_25;
        UnityEngine.Object val_26;
        System.Single[] val_27;
        var val_28;
        TramController val_29;
        float val_30;
        var val_31;
        float val_32;
        var val_33;
        Player_move_c val_34;
        float val_35;
        var val_36;
        float val_37;
        this.丑丆丕专丁丘且丏一();
        this.丛丏丕丂丆丙丅丏万();
        this.七丅且丘不丝丄丁东();
        this.三丑下丆丂丅丟丄丐();
        val_23 = this.allPathProgress;
        val_24 = val_23;
        val_25 = UnityEngine.Mathf.FloorToInt(f:  val_24);
        val_26 = TramController.丄丘七三上丕世丞业.GetPathByIndex(丞世不丒下上上丝丑:  val_25);
        if(val_26 == 0)
        {
                return;
        }
        
        if(this.isMoving == false)
        {
            goto label_7;
        }
        
        if(this.movingBackward == false)
        {
            goto label_8;
        }
        
        val_24 = this.backwardSpeed;
        val_23 = -val_24;
        goto label_10;
        label_7:
        val_23 = 0f;
        goto label_10;
        label_8:
        val_27 = this.forwardSpeed;
        val_23 = val_27[(long)(UnityEngine.Mathf.Min(a:  this.forwardSpeed.Length, b:  this.丅七丌东丛丒丒不丅)) - 1];
        label_10:
        float val_8 = UnityEngine.Mathf.MoveTowards(current:  this.丐上丁丛丞丘东三不, target:  val_23, maxDelta:  this.accelerationSpeed * UnityEngine.Time.deltaTime);
        this.丐上丁丛丞丘东三不 = val_8;
        if(val_8 == 0f)
        {
                return;
        }
        
        val_27 = 1152921505066536960;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_28 = null;
            val_28 = null;
            if(SiegeController.三三万丆下一丗万丛.isRoundEnding == true)
        {
                return;
        }
        
        }
        
        if(val_2.next != 0)
        {
            goto label_29;
        }
        
        if(this.丐上丁丛丞丘东三不 <= 0f)
        {
            goto label_30;
        }
        
        if(this.丐丁丛丗专丛丆丄丞 == true)
        {
                return;
        }
        
        val_29 = TramController.丄丘七三上丕世丞业;
        val_29.OnEndReached(丛丄业丕且丗下一万:  val_26);
        this.丐丁丛丗专丛丆丄丞 = true;
        return;
        label_29:
        this.丐丁丛丗专丛丆丄丞 = false;
        label_70:
        val_30 = (float)val_25;
        val_31 = 0f;
        if(this.业上一丏丕丝七丒丁 != 0f)
        {
                val_30 = this.业上一丏丕丝七丒丁;
            val_30 = this.业上一丏丕丝七丒丁;
            val_30 = this.业上一丏丕丝七丒丁;
            float val_22 = System.Math.Abs(this.业上一丏丕丝七丒丁);
            val_22 = val_22 - System.Math.Abs(this.三且丅七丂七万丗丌);
            this.业上一丏丕丝七丒丁 = (val_22 > 0f) ? (val_30 - this.三且丅七丂七万丗丌) : 0f;
        }
        
        float val_24 = this.丐上丁丛丞丘东三不;
        val_24 = val_24 * UnityEngine.Time.deltaTime;
        float val_17 = (this.allPathProgress - val_30) * val_2.distance;
        val_17 = val_24 + val_17;
        val_32 = ((val_22 > 0f) ? this.三且丅七丂七万丗丌 : (val_30)) + val_17;
        if((this.三丟不丑东丈且丝丑 != false) && (this.movingBackward != true))
        {
                val_33 = null;
            val_33 = null;
            val_34 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_34 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_34 != 0)
        {
                float val_19 = val_24 + this.丞丂丄丁丅万业业下;
            val_35 = val_24 + this.下丈丑三丂一丘万丈;
            this.丞丂丄丁丅万业业下 = val_19;
            this.下丈丑三丂一丘万丈 = val_35;
            if(val_19 >= 5f)
        {
                this.丞丂丄丁丅万业业下 = 0f;
            val_36 = null;
            val_36 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  112, 专上丝且丂世丛丝丒:  1f);
            val_35 = this.下丈丑三丂一丘万丈;
        }
        
            if(val_35 >= 1f)
        {
                val_35 = val_35 + (-1f);
            this.下丈丑三丂一丘万丈 = val_35;
            val_34 = GameConnect.丑丌丛丈丅丅与不业();
            Rilisoft.丞丛七上丕专丏丌丈.丟与丞丕下丌东三万(上且丗一丏丏万丅丌:  val_34);
        }
        
        }
        
        }
        
        if((val_32 <= val_2.distance) || (val_2.distance == 0f))
        {
            goto label_57;
        }
        
        val_26 = val_2.next;
        val_32 = val_32 - val_2.distance;
        if(val_2.next.isCheckpoint == false)
        {
            goto label_72;
        }
        
        val_34 = TramController.丄丘七三上丕世丞业;
        val_34.OnCheckpointReached(丛丄业丕且丗下一万:  val_26);
        goto label_72;
        label_57:
        if(val_32 < 0)
        {
                val_34 = val_2.back;
            if(val_34 != 0)
        {
                if(val_2.isCheckpoint == false)
        {
            goto label_66;
        }
        
        }
        
            this.丐上丁丛丞丘东三不 = 0f;
            val_32 = 0f;
        }
        
        label_72:
        if(val_2.distance != 0f)
        {
            goto label_67;
        }
        
        this.丐上丁丛丞丘东三不 = 0f;
        val_37 = 0f;
        goto label_68;
        label_30:
        if(this.丒丌丅丁不丏丅七下 > 0f)
        {
                return;
        }
        
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
            goto label_70;
        }
        
        return;
        label_67:
        val_37 = val_32 / val_2.distance;
        label_68:
        val_37 = val_37 + (float)val_2.myIndex;
        this.allPathProgress = val_37;
        this.七丒下丂丝且丕丌东();
        return;
        label_66:
        val_32 = val_32 + val_2.back.distance;
        goto label_72;
    }
    private void 三丑下丆丂丅丟丄丐()
    {
        TramController val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        bool val_14;
        val_9 = this;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
            goto label_13;
        }
        
        val_11 = null;
        val_11 = null;
        UnityEngine.Vector3 val_4 = transform.position;
        UnityEngine.Vector3 val_5 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if((this.detectBound.Contains(point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
        {
            goto label_13;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = val_9;
        if(((typeof(Player_move_c).__il2cppRuntimeField_56E != 1) ? 1 : 0) != ((this.三丟不丑东丈且丝丑 == true) ? 1 : 0))
        {
            goto label_18;
        }
        
        return;
        label_13:
        val_13 = val_9;
        if(this.三丟不丑东丈且丝丑 == false)
        {
                return;
        }
        
        val_14 = false;
        label_18:
        this.丞丂丄丁丅万业业下 = 0f;
        val_9 = TramController.丄丘七三上丕世丞业;
        val_9.RegisterMyPlayerInTram(东丝丁下丁东且丑业:  false);
        this.三丟不丑东丈且丝丑 = val_14;
    }
    public TramObject()
    {
        this.wheelsSpeed = 2f;
        this.backwardSpeed = 2f;
        this.accelerationSpeed = 0.1f;
        this.startRotateDist = 5f;
    }

}
