using UnityEngine;
public class TrainObject : MonoBehaviour
{
    // Fields
    public float allPathProgress;
    public float wheelsSpeed;
    public float[] forwardSpeed;
    internal float 丘丄东丝东丄三万丆;
    public float backwardSpeed;
    public float accelerationSpeed;
    public bool isMoving;
    public bool movingBackward;
    private int 一丅世丙东三丆专东;
    public float startRotateDist;
    public PlatformController tramPlatform;
    public UnityEngine.Transform ramPoint;
    private float 业上一丏丕丝七丒丁;
    private float 三且丅七丂七万丗丌;
    public float detectRaduis;
    public UnityEngine.Animation _animation;
    public UnityEngine.AudioClip startMoveSound;
    public UnityEngine.AudioClip stopMoveSound;
    public UnityEngine.AudioClip startAttackSound;
    public UnityEngine.AudioClip attackSound;
    public UnityEngine.GameObject moveSoundGameObject;
    private UnityEngine.AudioSource 不丆丏丄丐且丗丆丟;
    private bool 丒丏丄东丞下丌丁丏;
    internal TrainPathController 丌丌丞上丛业丝丗丗;
    protected float 丐上丁丛丞丘东三不;
    protected bool 丐丁丛丗专丛丆丄丞;
    
    // Methods
    private void Awake()
    {
        this.不丆丏丄丐且丗丆丟 = this.GetComponent<UnityEngine.AudioSource>();
        goto typeof(TrainObject).__il2cppRuntimeField_168;
    }
    private void Start()
    {
        if(PlatformsList.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        this = new PlatformController[1];
        this[0] = this.tramPlatform;
        PlatformsList.丄丘七三上丕世丞业.platforms = this;
    }
    protected virtual void 丐丕丏专丐不丘三不()
    {
    
    }
    internal void 上丛丌丆丑上七世三(TrainPathController 丌丌丞上丛业丝丗丗)
    {
        System.Single[] val_16;
        System.Single[] val_17;
        float val_18;
        val_16 = this;
        this.丌丌丞上丛业丝丗丗 = 丌丌丞上丛业丝丗丗;
        val_17 = 1152921505066536960;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                this.forwardSpeed = new float[3];
            string val_4 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
            this.forwardSpeed[0] = BalanceController.丒丘三一与丆一一丙(丆万一不丌且东丐丐:  val_4);
            float val_6 = BalanceController.一丌丛丂丝丁不东三(丆万一不丌且东丐丐:  val_4);
            float val_17 = val_6;
            val_6 = val_17 + 1f;
            val_17 = val_6 * this.forwardSpeed[0];
            this.forwardSpeed[1] = val_17;
            float val_7 = BalanceController.一丌丛丂丝丁不东三(丆万一不丌且东丐丐:  val_4);
            val_7 = val_7 + 1f;
            val_18 = val_7 * this.forwardSpeed[1];
            this.forwardSpeed[2] = val_18;
            this.backwardSpeed = BalanceController.丞丟三下丟下丞世丟(丆万一不丌且东丐丐:  val_4);
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        丕丝丕丝丑丐专丁三 val_11 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().一丗与专专丆东丕丈(与丐与不丁丗丂一东:  3);
        if(val_11 == null)
        {
                return;
        }
        
        float[] val_12 = new float[3];
        this.forwardSpeed = val_12;
        val_12[0] = val_11.丄丗丟丒三丝与丁七();
        val_17 = this.forwardSpeed;
        val_17[1] = val_11.丄与丙丙与丁丐丗丛();
        val_16 = this.forwardSpeed;
        val_18 = val_11.丝与丙下七三丘不丟();
        val_16[2] = val_18;
    }
    public void SetMoving(bool 三丑丏世丂丆丕丈专, bool 丁业丈丄丐丒丏丅丙, int 一丅世丙东三丆专东)
    {
        this.isMoving = 三丑丏世丂丆丕丈专;
        this.movingBackward = 丁业丈丄丐丒丏丅丙;
        this.一丅世丙东三丆专东 = 一丅世丙东三丆专东;
    }
    public void CorrectProgress(float 上丕丈丞丌丘丅不与)
    {
        float val_1 = 上丕丈丞丌丘丅不与 - this.allPathProgress;
        if(System.Math.Abs(val_1) > 1f)
        {
                this.allPathProgress = 上丕丈丞丌丘丅不与;
            this.七丒下丂丝且丕丌东();
            return;
        }
        
        this.业上一丏丕丝七丒丁 = val_1;
        this.三且丅七丂七万丗丌 = val_1;
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
        TramPath val_2 = this.丌丌丞上丛业丝丗丗.GetPathByIndex(丞世不丒下上上丝丑:  val_1);
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
        bool val_10;
        if(this._animation != 0)
        {
                if(this.丐丁丛丗专丛丆丄丞 != false)
        {
                bool val_2 = this._animation.IsPlaying(name:  "attack");
        }
        else
        {
                float val_9 = this.丐上丁丛丞丘东三不;
            val_9 = val_9 / this.wheelsSpeed;
            this._animation.Item["ride"].speed = val_9;
            if((this._animation.IsPlaying(name:  "ride")) != true)
        {
                bool val_5 = this._animation.Play(animation:  "ride");
        }
        
        }
        
        }
        
        if(this.丐上丁丛丞丘东三不 != 0f)
        {
            goto label_12;
        }
        
        label_14:
        val_10 = 0;
        goto label_13;
        label_12:
        if(this.isMoving == false)
        {
            goto label_14;
        }
        
        bool val_10 = this.丐丁丛丗专丛丆丄丞;
        val_10 = val_10 ^ 1;
        val_10 = val_10 & 255;
        label_13:
        if(val_10 == this.丒丏丄东丞下丌丁丏)
        {
                return;
        }
        
        this.丒丏丄东丞下丌丁丏 = val_10;
        if(this.不丆丏丄丐且丗丆丟 == 0)
        {
            goto label_18;
        }
        
        if(val_10 == false)
        {
            goto label_19;
        }
        
        val_10 = this.startMoveSound;
        if(this.不丆丏丄丐且丗丆丟 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        this.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  val_10);
        label_18:
        if(this.moveSoundGameObject == 0)
        {
                return;
        }
        
        this.moveSoundGameObject.SetActive(value:  (this.丒丏丄东丞下丌丁丏 == true) ? 1 : 0);
        return;
        label_19:
        if(this.不丆丏丄丐且丗丆丟 != null)
        {
            goto label_25;
        }
        
        goto label_26;
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
        this.丛丏丕丂丆丙丅丏万();
        this.丙七丅与丕丈丒丕丟();
    }
    private void LateUpdate()
    {
        goto typeof(TrainObject).__il2cppRuntimeField_188;
    }
    protected virtual void 丗丙下且上下与丛丈()
    {
    
    }
    protected virtual void 丟丁丛丏与业万丟且()
    {
    
    }
    protected virtual void 丘丟丛一万下七丁丁(float 丒且丆丘丞丑业丅不)
    {
    
    }
    protected virtual void 丄丙丝万丌丞丑丈丐(TramPath 丅专与丒丈丗丒丘丌)
    {
    
    }
    protected virtual void 丐丕丆丈丙万丝丛丒(TramPath 丅专与丒丈丗丒丘丌)
    {
    
    }
    private void 丙七丅与丕丈丒丕丟()
    {
        float val_18;
        float val_19;
        int val_20;
        UnityEngine.Object val_21;
        float val_22;
        var val_23;
        float val_24;
        float val_25;
        val_18 = this.allPathProgress;
        val_19 = val_18;
        val_20 = UnityEngine.Mathf.FloorToInt(f:  val_19);
        val_21 = this.丌丌丞上丛业丝丗丗.GetPathByIndex(丞世不丒下上上丝丑:  val_20);
        if(val_21 == 0)
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
        
        val_19 = -this.backwardSpeed;
        goto label_9;
        label_7:
        val_18 = 0f;
        goto label_10;
        label_8:
        val_19 = this.forwardSpeed[(long)(UnityEngine.Mathf.Min(a:  this.forwardSpeed.Length, b:  this.一丅世丙东三丆专东)) - 1];
        label_9:
        val_18 = val_19 * this.丘丄东丝东丄三万丆;
        label_10:
        float val_8 = UnityEngine.Mathf.MoveTowards(current:  this.丐上丁丛丞丘东三不, target:  val_18, maxDelta:  this.accelerationSpeed * UnityEngine.Time.deltaTime);
        this.丐上丁丛丞丘东三不 = val_8;
        if(val_8 == 0f)
        {
                return;
        }
        
        if(val_2.next != 0)
        {
            goto label_22;
        }
        
        if(this.丐上丁丛丞丘东三不 <= 0f)
        {
            goto label_23;
        }
        
        if(this.丐丁丛丗专丛丆丄丞 == true)
        {
                return;
        }
        
        this.丐丁丛丗专丛丆丄丞 = true;
        return;
        label_22:
        this.丐丁丛丗专丛丆丄丞 = false;
        label_41:
        val_22 = this.业上一丏丕丝七丒丁;
        val_23 = 0f;
        if(val_22 != 0f)
        {
                float val_17 = this.三且丅七丂七万丗丌;
            val_17 = val_17 * UnityEngine.Time.deltaTime;
            val_22 = this.业上一丏丕丝七丒丁;
            val_22 = this.业上一丏丕丝七丒丁;
            val_22 = this.业上一丏丕丝七丒丁;
            float val_18 = System.Math.Abs(this.业上一丏丕丝七丒丁);
            val_18 = val_18 - System.Math.Abs(val_17);
            this.业上一丏丕丝七丒丁 = (val_18 > 0f) ? (val_22 - val_17) : 0f;
        }
        
        float val_15 = UnityEngine.Time.deltaTime;
        float val_20 = val_2.distance;
        val_15 = this.丐上丁丛丞丘东三不 * val_15;
        val_20 = (this.allPathProgress - (float)val_20) * val_20;
        val_20 = val_15 + val_20;
        val_24 = ((val_18 > 0f) ? (val_17) : (val_22)) + val_20;
        if((val_24 <= val_2.distance) || (val_2.distance == 0f))
        {
            goto label_30;
        }
        
        val_21 = val_2.next;
        val_24 = val_24 - val_2.distance;
        if(val_2.next.isCheckpoint == false)
        {
            goto label_43;
        }
        
        goto label_43;
        label_30:
        if(val_24 < 0)
        {
                val_20 = val_2.back;
            if(val_20 != 0)
        {
                if(val_2.isCheckpoint == false)
        {
            goto label_38;
        }
        
        }
        
            this.丐上丁丛丞丘东三不 = 0f;
            val_24 = 0f;
        }
        
        label_43:
        if(val_2.distance != 0f)
        {
            goto label_39;
        }
        
        this.丐上丁丛丞丘东三不 = 0f;
        val_25 = 0f;
        goto label_40;
        label_23:
        if(this.丐丁丛丗专丛丆丄丞 == false)
        {
            goto label_41;
        }
        
        return;
        label_39:
        val_25 = val_24 / val_2.distance;
        label_40:
        val_25 = val_25 + (float)val_2.myIndex;
        this.allPathProgress = val_25;
        this.七丒下丂丝且丕丌东();
        return;
        label_38:
        val_24 = val_24 + val_2.back.distance;
        goto label_43;
    }
    public TrainObject()
    {
        this.wheelsSpeed = 2f;
        this.forwardSpeed = new float[3];
        this.丘丄东丝东丄三万丆 = Infinityf;
        this.backwardSpeed = 2f;
        this.accelerationSpeed = 0.1f;
        this.startRotateDist = 5f;
        this.detectRaduis = 10f;
    }

}
