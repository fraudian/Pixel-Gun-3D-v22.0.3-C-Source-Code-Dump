using UnityEngine;
internal sealed class HoldPositionsPoint : MonoBehaviour
{
    // Fields
    public int index;
    private int 与丝丙专与丁丈丟与;
    public static string[] pointLetterNames;
    private double 不丛一丟不丄世丕丐;
    private double 丞丕丑不丒万丞下丐;
    public HoldPositionsPoint.丅丅丒丆丂丕丒丙丅 myPointType;
    private float 丘丌丌万丕不丁丙一;
    private const float 七与丞世七且丁丗丁 = 100;
    private float 丂东七专不下丂丏丗;
    private float rawCounter;
    private bool 万丂一万丙丌不丘一;
    internal int ownerCommand;
    internal int previousCommand;
    private int captureCommand;
    private int 丁丞丗业丆丒上丈丞;
    private readonly int 丞世丏东丝东上业丞;
    private System.Collections.Generic.List<int> 丛丌三丝丐丈丝七业;
    public System.Collections.Generic.List<Player_move_c> capturePlayers;
    private bool 丙丞丛丕丅世下丅丒;
    private bool 丞一业不丟万世三且;
    private HoldPositionsController 丅丆三上丈专丒丂丒;
    private HoldPositionsPlayerDetector 丂不丐世丟丒与丏万;
    internal HoldPositionsPointVisual 上丁丕丐丂丌丐丗丟;
    private bool 丛丛七上不一三丞丌;
    private float 丌与丈丟丝丄下丌一;
    private UnityEngine.Collider 三丄丂万下丈丟丟丈;
    
    // Properties
    public int 丟世丝丈丈万丅丗丆 { get; set; }
    public double 丏东丈上丒七一下丟 { get; set; }
    public double 三丄丐不一上且下丐 { get; set; }
    public string 世丑丘七丅三丘世下 { get; }
    public bool 丁丈丟丙丌丝丙丗丞 { get; }
    internal bool 上丘专且丝丈丗不丒 { get; }
    internal bool 丈丗丗七与上丕丄一 { get; }
    internal bool 专丞丗丌丗丌丏且且 { get; }
    public bool 业七丈万丌东且丒上 { get; }
    internal bool 丌丛丁丂丒上丁丗不 { get; }
    internal bool 专丕丝七专丒丘丟与 { get; }
    internal bool 下丕丄丒业丙丞丌丐 { get; }
    internal bool 丑丏丆丘上丒丄三丙 { get; }
    internal bool 丐丛丄三丌万丙丘丕 { get; }
    internal bool 三丏丛不丏不且丈丆 { get; }
    internal bool 丝丂一丝丒丝丈丅丆 { get; }
    internal bool 万丗一丑丆丟丅丈丟 { get; }
    internal bool 丑不与东下下丁万丐 { get; }
    
    // Methods
    public int get_createOrder()
    {
        return (int)this.与丝丙专与丁丈丟与;
    }
    public void set_createOrder(int 丙业与丙丗丝不丈东)
    {
        this.与丝丙专与丁丈丟与 = 丙业与丙丗丝不丈东;
    }
    public double get_nextPointTime()
    {
        return (double)this.不丛一丟不丄世丕丐;
    }
    public void set_nextPointTime(double 丙业与丙丗丝不丈东)
    {
        this.不丛一丟不丄世丕丐 = 丙业与丙丗丝不丈东;
    }
    public double get_unlockTime()
    {
        return (double)this.丞丕丑不丒万丞下丐;
    }
    public void set_unlockTime(double 丙业与丙丗丝不丈东)
    {
        this.丞丕丑不丒万丞下丐 = 丙业与丙丗丝不丈东;
    }
    public string get_myLetterName()
    {
        return HoldPositionsPoint.NumToLetterName(丙丐一丕丗万丁下一:  this.与丝丙专与丁丈丟与);
    }
    public bool get_isTimeOfActionPassed()
    {
        var val_3 = null;
        double val_3 = (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotSpawnDelay;
        val_3 = this.不丛一丟不丄世丕丐 - val_3;
        return (bool)(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > val_3) ? 1 : 0;
    }
    internal float 万三丐且丏丁丐丝丝()
    {
        return (float)this.rawCounter;
    }
    internal bool 丁三专一丒世丕丕丛()
    {
        null = null;
        bool val_1 = 丗丌丆丙丗上丁丌丁();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal bool 丅与世丒丑上专丆丙()
    {
        return (bool)this.万丂一万丙丌不丘一;
    }
    internal bool 丁丅丐世下丑上丞世()
    {
        return (bool)this.丞一业不丟万世三且;
    }
    private void Awake()
    {
        System.Action<System.Boolean> val_7;
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
                return;
        }
        
        if(this.丞世丏东丝东上业丞 >= 1)
        {
                do
        {
            this.丛丌三丝丐丈丝七业.Add(item:  0);
            val_7 = 0 + 1;
        }
        while(val_7 < this.丞世丏东丝东上业丞);
        
        }
        
        this.丅丆三上丈专丒丂丒 = this.GetComponentInParent<HoldPositionsController>();
        this.丂不丐世丟丒与丏万 = this.GetComponent<HoldPositionsPlayerDetector>();
        this.上丁丕丐丂丌丐丗丟 = this.GetComponentInChildren<HoldPositionsPointVisual>();
        if(this.丂不丐世丟丒与丏万 != 0)
        {
                System.Action<System.Boolean> val_6 = null;
            val_7 = val_6;
            val_6 = new System.Action<System.Boolean>(object:  this, method:  System.Void HoldPositionsPoint::三三丒且丙丏丏业丐(bool 丂丛与丕丟世与东万));
            this.丂不丐世丟丒与丏万.丐丅下丛丙不丐丂丏(丙业与丙丗丝不丈东:  val_6);
        }
        
        this.万丂一万丙丌不丘一 = false;
        this.rawCounter = 0f;
        this.丘丌丌万丕不丁丙一 = 0f;
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.captureCommand = 0;
        this.丞丛丝丒三世丏丂丐();
    }
    public static string NumToLetterName(int 丙丐一丕丗万丁下一)
    {
        var val_4;
        float val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = HoldPositionsPoint.七与丞世七且丁丗丁;
        if(val_5 != 0)
        {
                val_6 = 丙丐一丕丗万丁下一 - ((丙丐一丕丗万丁下一 / (HoldPositionsPoint.七与丞世七且丁丗丁 + 24)) * (HoldPositionsPoint.七与丞世七且丁丗丁 + 24));
        }
        else
        {
                val_5 = HoldPositionsPoint.七与丞世七且丁丗丁;
            val_6 = 丙丐一丕丗万丁下一 - ((丙丐一丕丗万丁下一 / (HoldPositionsPoint.七与丞世七且丁丗丁 + 24)) * (HoldPositionsPoint.七与丞世七且丁丗丁 + 24));
        }
        
        float val_3 = val_5 + (((long)(int)(丙丐一丕丗万丁下一 - ((丙丐一丕丗万丁下一 / HoldPositionsPoint.七与丞世七且丁丗丁 + 24) * HoldPositionsPoint.七与丞世七且丁丗丁 + 24))) << 3);
        return (string)(HoldPositionsPoint.七与丞世七且丁丗丁 + ((long)(int)(丙丐一丕丗万丁下一 - ((丙丐一丕丗万丁下一 / HoldPositionsPoint.七与丞世七且丁丗丁 + 24) * HoldPositionsPoint.七与丞世七且丁丗丁 + 24))) << 3) + 32;
    }
    public bool get_isLocked()
    {
        var val_3;
        HoldPositionsController val_4;
        val_3 = null;
        val_3 = null;
        val_4 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_5;
        }
        
        val_4 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_5:
        double val_3 = HoldPositionsController.丆丕丝丒不丙且丐丗.spotLifeTime;
        val_3 = this.不丛一丟不丄世丕丐 - val_3;
        val_3 = val_3 - (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotSpawnDelay;
        return (bool)(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() < 0) ? 1 : 0;
        label_6:
    }
    internal void 丕与一丄丅三丏业丆()
    {
        this.丞丛丝丒三世丏丂丐();
        this.万丂一万丙丌不丘一 = true;
        this.丌与丈丟丝丄下丌一 = 0f;
        if(this.上丁丕丐丂丌丐丗丟 == null)
        {
                return;
        }
        
        this.上丁丕丐丂丌丐丗丟.东与丂丏丐丞三丘丁(丙业与丙丗丝不丈东:  this.myLetterName);
    }
    internal void 丑丟丂丈丌一不丛专()
    {
        this.万丂一万丙丌不丘一 = false;
        this.rawCounter = 0f;
        this.丘丌丌万丕不丁丙一 = 0f;
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.captureCommand = 0;
        this.丞丛丝丒三世丏丂丐();
    }
    internal void 丏丁丘上专七丟上丑(Player_move_c 专丞上七七且丝七丗)
    {
        bool val_1 = this.丛三丐丘丂丈专丏专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
    }
    private void 三三丒且丙丏丏业丐(bool 丂丛与丕丟世与东万)
    {
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        if(this.万丂一万丙丌不丘一 == false)
        {
                return;
        }
        
        if(this.isLocked == true)
        {
                return;
        }
        
        val_8 = 1152921505286238208;
        val_9 = null;
        if(丂丛与丕丟世与东万 != false)
        {
                val_10 = null;
            if((this.丙丆丐一三丌丝丕丌(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != false)
        {
                val_8 = this.index;
            this.丅丆三上丈专丒丂丒.丘专上丅且下丕七丗(专七万不丐丆丟东丈:  val_8, 丄丒且丙三丆丟与丏:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁(), 丂丛与丕丟世与东万:  true);
        }
        
            this.丞一业不丟万世三且 = true;
            return;
        }
        
        val_11 = null;
        if((this.丛三丐丘丂丈专丏专(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != false)
        {
                val_8 = this.丅丆三上丈专丒丂丒;
            val_8.丘专上丅且下丕七丗(专七万不丐丆丟东丈:  this.index, 丄丒且丙三丆丟与丏:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁(), 丂丛与丕丟世与东万:  false);
        }
        
        this.丞一业不丟万世三且 = false;
    }
    private bool 丛三丐丘丂丈专丏专(Player_move_c 专丞上七七且丝七丗)
    {
        var val_3;
        if((this.capturePlayers.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                bool val_2 = this.capturePlayers.Remove(item:  专丞上七七且丝七丗);
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private bool 丙丆丐一三丌丝丕丌(Player_move_c 专丞上七七且丝七丗)
    {
        var val_2;
        if((this.capturePlayers.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.capturePlayers.Add(item:  专丞上七七且丝七丗);
        val_2 = 1;
        return (bool)val_2;
    }
    internal void 万丄东七丒专丕丒丛(int 业上上丏丄不上丅丈)
    {
        int val_6;
        var val_7;
        val_6 = 业上上丏丄不上丅丈;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_8:
        if(((-1081068632) & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_6})) == false)
        {
            goto label_8;
        }
        
        bool val_5 = this.丙丆丐一三丌丝丕丌(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丝三上东一丂丑万丂(int 业上上丏丄不上丅丈)
    {
        int val_6;
        var val_7;
        val_6 = 业上上丏丄不上丅丈;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_8:
        if(((-1080948440) & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_6})) == false)
        {
            goto label_8;
        }
        
        bool val_5 = this.丛三丐丘丂丈专丏专(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞丛丝丒三世丏丂丐()
    {
        this.capturePlayers.Clear();
        this.丞一业不丟万世三且 = false;
        this.丂不丐世丟丒与丏万.Reset();
    }
    internal void Reset()
    {
        this.rawCounter = 0f;
        this.丘丌丌万丕不丁丙一 = 0f;
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.captureCommand = 0;
        this.丞丛丝丒三世丏丂丐();
    }
    internal void 丗丅不且与与丑丐丐()
    {
        this.万丂一万丙丌不丘一 = false;
        this.rawCounter = 0f;
        this.丘丌丌万丕不丁丙一 = 0f;
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.captureCommand = 0;
        mem[1152921537886005516] = 0;
        mem[1152921537886005508] = 0;
        this.与丝丙专与丁丈丟与 = 0;
        this.不丛一丟不丄世丕丐 = 0;
        this.丞丛丝丒三世丏丂丐();
    }
    internal void 且不丙丟丘不丌丆丌(float 一丅丌三丁万丑且万)
    {
        if(this.丁丞丗业丆丒上丈丞 < 1)
        {
                return;
        }
        
        if(this.丅丆三上丈专丒丂丒.丘丕丄与丈七与下三 == false)
        {
                return;
        }
        
        if(this.丅丆三上丈专丒丂丒.丆丁丆丟丄丛丁万丛 == false)
        {
                return;
        }
        
        if(this.丙丞丛丕丅世下丅丒 == false)
        {
                return;
        }
        
        if(this.isLocked == true)
        {
                return;
        }
        
        float val_2 = this.rawCounter;
        this.rawCounter = 一丅丌三丁万丑且万;
        val_2 = val_2 - this.丌与丈丟丝丄下丌一;
        val_2 = 一丅丌三丁万丑且万 - val_2;
        this.丌与丈丟丝丄下丌一 = val_2;
    }
    private void 丈东丌丟丒丄丏丆与()
    {
        this.丞一业不丟万世三且 = false;
    }
    private void Update()
    {
        bool val_48;
        var val_49;
        var val_50;
        HoldPositionsPointVisual val_51;
        int val_52;
        var val_53;
        var val_57;
        bool val_58;
        bool val_59;
        var val_60;
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
                return;
        }
        
        if(this.丌与丈丟丝丄下丌一 != 0f)
        {
                float val_44 = 0.05f;
            val_44 = UnityEngine.Time.deltaTime * val_44;
            this.丌与丈丟丝丄下丌一 = UnityEngine.Mathf.MoveTowards(current:  this.丌与丈丟丝丄下丌一, target:  0f, maxDelta:  val_44 * 100f);
        }
        
        if(this.上丁丕丐丂丌丐丗丟 != 0)
        {
                this.上丁丕丐丂丌丐丗丟.SetCircleActive(三丟东丕丄丄下下丑:  (~this.丂不丐世丟丒与丏万.isPlayerInDetectZone) & 1);
            val_48 = this.isLocked;
            this.上丁丕丐丂丌丐丗丟.SetLocked(丐三丞七丝丅不万丛:  val_48);
        }
        
        val_49 = null;
        val_49 = null;
        bool val_10 = 丗丌丆丙丗上丁丌丁();
        if(val_10 != false)
        {
                if(this.上丁丕丐丂丌丐丗丟 == null)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.上丁丕丐丂丌丐丗丟, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        if(this.上丁丕丐丂丌丐丗丟 != null)
        {
                if(this.万丂一万丙丌不丘一 != false)
        {
                val_48 = val_10.丁三专一丒世丕丕丛();
        }
        else
        {
                val_48 = 0;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.上丁丕丐丂丌丐丗丟, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.万丂一万丙丌不丘一 == false)
        {
                return;
        }
        
        this.丈丝丂业丑丅丗上东();
        if(this.上丁丕丐丂丌丐丗丟 == 0)
        {
                return;
        }
        
        if(this.ownerCommand == 0)
        {
            goto label_30;
        }
        
        if(this.丅丆三上丈专丒丂丒.世丛丞丗丈丘丘东丅 == false)
        {
            goto label_32;
        }
        
        if(this.ownerCommand == 0)
        {
            goto label_33;
        }
        
        val_50 = ((this.captureCommand != 0) ? 1 : 0) & ((this.captureCommand != this.ownerCommand) ? 1 : 0);
        goto label_34;
        label_30:
        val_51 = this.上丁丕丐丂丌丐丗丟;
        val_52 = 0;
        label_36:
        val_53 = 0;
        goto label_35;
        label_32:
        val_52 = this.ownerCommand;
        val_51 = this.上丁丕丐丂丌丐丗丟;
        if(val_52 == 0)
        {
            goto label_36;
        }
        
        val_53 = ((this.captureCommand != 0) ? 1 : 0) & ((this.captureCommand != val_52) ? 1 : 0);
        label_35:
        var val_20 = (val_52 == 0) ? 1 : 0;
        var val_21 = (this.captureCommand == this.丁丞丗业丆丒上丈丞) ? 1 : 0;
        var val_22 = (val_52 == this.丁丞丗业丆丒上丈丞) ? 1 : 0;
        val_57 = val_53;
        val_58 = ((val_52 != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0);
        val_59 = 0;
        goto label_38;
        label_33:
        val_50 = 0;
        label_34:
        val_59 = (~this.丘丕丐不与丂业丝丁()) & 1;
        val_57 = val_50;
        val_58 = ((this.ownerCommand != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0);
        label_38:
        this.上丁丕丐丂丌丐丗丟.下与三丅丂专丘业丗(丒丄丂不丝丝丛丁东:  false, 与丝丂丁丗丗丑丟专:  val_58, 丙丟丘丌三丌丌世七:  (this.captureCommand == this.丁丞丗业丆丒上丈丞) ? 1 : 0, 丙丒世丂丝一丏不丆:  (this.ownerCommand == 0) ? 1 : 0, 七世丕丅丛且上丛三:  (this.ownerCommand == this.丁丞丗业丆丒上丈丞) ? 1 : 0, 丟下丑三丒与丘世东:  val_59);
        bool val_32 = ((this.ownerCommand != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0);
        if((this.丁丞丗业丆丒上丈丞 == 1) && (this.rawCounter > 0f))
        {
                val_60 = 1;
        }
        else
        {
                if(this.rawCounter < 0)
        {
                var val_33 = (this.丁丞丗业丆丒上丈丞 == 2) ? 1 : 0;
        }
        else
        {
                val_60 = 0;
        }
        
        }
        
        this.上丁丕丐丂丌丐丗丟.丐专丒丁专丌丑丘丙(丙东丏丕丞丁丈丈万:  (this.ownerCommand != 0) ? 1 : 0, 专七世丕且丐丙丕东:  val_32, 七丟丁下且不丟丌丏:  (this.captureCommand == this.丁丞丗业丆丒上丈丞) ? 1 : 0, 丒丌丘不世丁丑丟丂:  false, 下且下丄专下丝丞丟:  val_32 & ((this.ownerCommand != 0) ? 1 : 0), 丆丅丐三一不丕世三:  this.业七业与三东三丆丐(), 丑丁丐一三东丟业丝:  this.业丟东丛且下一丕丘(), 上不世不七丒上不东:  this.丒上丝丐丐丒丂丐下());
        this.上丁丕丐丂丌丐丗丟.东与丂丏丐丞三丘丁(丙业与丙丗丝不丈东:  this.myLetterName);
    }
    private void LateUpdate()
    {
        if(this.万丂一万丙丌不丘一 == false)
        {
                return;
        }
        
        this.丘丌丌万丕不丁丙一 = this.rawCounter;
    }
    private void 丂下丝丌丂丐丛丗丆()
    {
        this.丘丌丌万丕不丁丙一 = this.rawCounter;
    }
    private void 丈丝丂业丑丅丗上东()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        bool val_2 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        if(val_2 == true)
        {
                return;
        }
        
        if(val_2.丁三专一丒世丕丕丛() == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        this.丁丞丗业丆丒上丈丞 = 丘丑丅三丆丑丌且丝();
        this.一丞下业万丄世丂丛();
        int val_6 = this.东丛丗东丕丐丛丟专();
        this.captureCommand = val_6 + 1;
        this.丄丐与丁世丘上丏丅(丐丟丅丘七丝下下业:  val_6);
        this.丘东丏丕丟丛且丛三();
        this.丌与丟世丑万丙丑一();
    }
    internal float 业丟东丛且下一丕丘()
    {
        float val_3 = 100f;
        val_3 = (System.Math.Abs(this.rawCounter - this.丌与丈丟丝丄下丌一)) / val_3;
        return UnityEngine.Mathf.Clamp01(value:  val_3);
    }
    internal bool 不东丞丌丂专丂丟东()
    {
        return (bool)(this.captureCommand == this.丁丞丗业丆丒上丈丞) ? 1 : 0;
    }
    internal bool 丛七且专丗丒丟丞丈()
    {
        return (bool)(this.ownerCommand != 0) ? 1 : 0;
    }
    internal bool 万业丕丁丒专丈丅三()
    {
        if((this.rawCounter > 0f) && (this.丁丞丗业丆丒上丈丞 == 1))
        {
                return true;
        }
        
        if(this.rawCounter >= 0)
        {
                return false;
        }
        
        return (bool)(this.丁丞丗业丆丒上丈丞 == 2) ? 1 : 0;
    }
    internal bool 丒上丝丐丐丒丂丐下()
    {
        var val_4;
        if(this.ownerCommand != 0)
        {
                if((this.丛丌三丝丐丈丝七业.Item[this.ownerCommand - 1]) == 0)
        {
                return (bool)(this.丂东七专不下丂丏丗 >= this.丅丆三上丈专丒丂丒.下丈下三丛上丌丌丄) ? 1 : 0;
        }
        
        }
        
        val_4 = 0;
        return (bool)(this.丂东七专不下丂丏丗 >= this.丅丆三上丈专丒丂丒.下丈下三丛上丌丌丄) ? 1 : 0;
    }
    internal bool 丅丅世不丝丝丝丄万()
    {
        if(this.ownerCommand == 0)
        {
                return false;
        }
        
        return (bool)((this.captureCommand != 0) ? 1 : 0) & ((this.captureCommand != this.ownerCommand) ? 1 : 0);
    }
    internal bool 且丈万七丗东丕业且()
    {
        if(this.captureCommand == 0)
        {
                return false;
        }
        
        return (bool)(this.ownerCommand != this.captureCommand) ? 1 : 0;
    }
    internal bool 丘丕丐不与丂业丝丁()
    {
        System.Collections.Generic.List<System.Int32> val_3;
        var val_4;
        val_3 = this;
        if(this.ownerCommand != 0)
        {
                val_3 = this.丛丌三丝丐丈丝七业;
            if((val_3.Item[this.ownerCommand - 1]) > 0)
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal bool 丑丄丌丅丆丗东丞丌()
    {
        var val_4;
        if(this.万丂一万丙丌不丘一 == false)
        {
                return true;
        }
        
        if(this.业七业与三东三丆丐() != true)
        {
                if(this.isLocked == false)
        {
            goto label_3;
        }
        
        }
        
        return true;
        label_3:
        val_4 = null;
        val_4 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.世丛丞丗丈丘丘东丅 == false)
        {
                return true;
        }
        
        var val_3 = (System.Math.Abs(this.rawCounter) < 0) ? 1 : 0;
        return true;
    }
    internal bool 业七业与三东三丆丐()
    {
        var val_4;
        System.Func<System.Int32, System.Boolean> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = HoldPositionsPoint.<>c.<>9__86_0;
        if(val_6 != null)
        {
                return (bool)((System.Linq.Enumerable.Count<System.Int32>(source:  this.丛丌三丝丐丈丝七业, predicate:  System.Func<System.Int32, System.Boolean> val_1 = null)) > 1) ? 1 : 0;
        }
        
        val_6 = val_1;
        val_1 = new System.Func<System.Int32, System.Boolean>(object:  HoldPositionsPoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HoldPositionsPoint.<>c::丁丕丆丟丌丗万丅丟(int 丁丟丌专三上丐丕丙));
        HoldPositionsPoint.<>c.<>9__86_0 = val_6;
        return (bool)((System.Linq.Enumerable.Count<System.Int32>(source:  this.丛丌三丝丐丈丝七业, predicate:  val_1)) > 1) ? 1 : 0;
    }
    private void 一丞下业万丄世丂丛()
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = 0;
        goto label_1;
        label_4:
        this.丛丌三丝丐丈丝七业.set_Item(index:  0, value:  0);
        val_11 = 1;
        label_1:
        if(val_11 < this.丛丌三丝丐丈丝七业.Count)
        {
            goto label_4;
        }
        
        val_12 = 0;
        goto label_5;
        label_16:
        Player_move_c val_2 = this.capturePlayers.Item[0];
        if(val_2.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() >= 1)
        {
                Player_move_c val_4 = this.capturePlayers.Item[0];
            NetworkStartTable val_11 = val_4.丟三丏丅世一丟丟上;
            val_11 = val_11.丘丑丅三丆丑丌且丝() - 1;
            if(this.丛丌三丝丐丈丝七业 != null)
        {
                val_13 = this.丛丌三丝丐丈丝七业.Item[val_11];
        }
        else
        {
                val_13 = 0.Item[val_11];
        }
        
            this.丛丌三丝丐丈丝七业.set_Item(index:  val_11, value:  val_13 + 1);
        }
        
        val_12 = 1;
        label_5:
        if(val_12 < this.capturePlayers.Count)
        {
            goto label_16;
        }
        
        if(this.ownerCommand == 0)
        {
                return;
        }
        
        if(this.丘丕丐不与丂业丝丁() == false)
        {
                return;
        }
        
        this.丂东七专不下丂丏丗 = 0f;
    }
    private int 东丛丗东丕丐丛丟专()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_4:
        val_5 = 1;
        label_1:
        if(val_5 < this.丛丌三丝丐丈丝七业.Count)
        {
            goto label_4;
        }
        
        if(((this.丛丌三丝丐丈丝七业.Item[0] > 0) ? (val_6 + 1) : (val_6)) != 1)
        {
                return 0;
        }
        
        val_7 = null;
        val_7 = null;
        if((HoldPositionsPoint.<>c.<>9__88_0) != null)
        {
                if(this.丛丌三丝丐丈丝七业 == null)
        {
                return this.丛丌三丝丐丈丝七业.FindIndex(match:  HoldPositionsPoint.<>c.<>9__88_0);
        }
        
            return this.丛丌三丝丐丈丝七业.FindIndex(match:  HoldPositionsPoint.<>c.<>9__88_0);
        }
        
        HoldPositionsPoint.<>c.<>9__88_0 = new System.Predicate<System.Int32>(object:  HoldPositionsPoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HoldPositionsPoint.<>c::丅丕丌不专丈丅丌丙(int 三丟东丕丄丄下下丑));
        if(this.丛丌三丝丐丈丝七业 != null)
        {
                return this.丛丌三丝丐丈丝七业.FindIndex(match:  HoldPositionsPoint.<>c.<>9__88_0);
        }
        
        return this.丛丌三丝丐丈丝七业.FindIndex(match:  HoldPositionsPoint.<>c.<>9__88_0);
    }
    private void 丟世丐三下丞丂与丘(int 丐丟丅丘七丝下下业)
    {
        this.captureCommand = 丐丟丅丘七丝下下业 + 1;
    }
    private void 丐一不三丘丐丁业丏(float 丙业与丙丗丝不丈东, float 东丞丅丕丌丑丗丞下)
    {
        if(this.isLocked == true)
        {
                return;
        }
        
        float val_3 = this.rawCounter;
        val_3 = (丙业与丙丗丝不丈东 * 东丞丅丕丌丑丗丞下) + val_3;
        this.rawCounter = val_3;
    }
    private void 丄丐与丁世丘上丏丅(int 丐丟丅丘七丝下下业)
    {
        int val_19;
        int val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        val_20 = this.ownerCommand;
        this.丛丛七上不一三丞丌 = false;
        if(丐丟丅丘七丝下下业 != 1)
        {
                val_20 = ((val_20 != 0) ? 1 : 0) & (((val_20 - 1) != 丐丟丅丘七丝下下业) ? 1 : 0);
            val_21 = this.丅丆三上丈专丒丂丒.上与业与且业丒丝丁;
            val_22 = 1f;
            if((val_20 != 0) && (this.丅丆三上丈专丒丂丒.丅丁东三丝业且与丙 != false))
        {
                val_22 = this.丅丆三上丈专丒丂丒.丅丂丗丒下丄丆丞三;
        }
        
            val_19 = this.captureCommand;
            val_23 = UnityEngine.Time.deltaTime;
            if(this.isLocked == true)
        {
                return;
        }
        
            float val_19 = (float)this.丛丌三丝丐丈丝七业.Item[丐丟丅丘七丝下下业] - 1;
            val_19 = this.丅丆三上丈专丒丂丒.与丕七东丒一不东七 * val_19;
            val_19 = val_21 + val_19;
            float val_8 = 100f / this.丅丆三上丈专丒丂丒.万七丞丙丑与一丑丁;
            val_19 = val_19 * val_22;
            val_19 = val_19 * val_23;
            val_8 = (val_19 == 1) ? (val_8) : (-val_8);
            val_19 = val_19 * val_8;
            val_19 = val_19 + this.rawCounter;
            this.rawCounter = val_19;
            return;
        }
        
        if(val_20 == 0)
        {
            goto label_9;
        }
        
        if((this.丛丌三丝丐丈丝七业.Item[val_20 - 1]) != 0)
        {
                return;
        }
        
        if(this.丂东七专不下丂丏丗 >= 0)
        {
            goto label_13;
        }
        
        val_23 = this.丂东七专不下丂丏丗;
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = val_23 + val_11;
        this.丂东七专不下丂丏丗 = val_11;
        return;
        label_9:
        if(this.capturePlayers.Count != 0)
        {
                return;
        }
        
        if(this.丅丆三上丈专丒丂丒.丌上且东丐丁丐专与 == false)
        {
                return;
        }
        
        val_23 = this.rawCounter;
        if(System.Math.Abs(val_23) <= 0.1f)
        {
                return;
        }
        
        val_21 = this.rawCounter;
        val_23 = UnityEngine.Time.deltaTime;
        if(this.isLocked == true)
        {
            goto label_26;
        }
        
        val_24 = 100f;
        val_25 = this.rawCounter;
        float val_15 = val_24 / this.丅丆三上丈专丒丂丒.下丞丂三万丁丄丄上;
        val_15 = (val_21 > 0f) ? (-val_15) : (val_15);
        goto label_24;
        label_13:
        val_23 = UnityEngine.Time.deltaTime;
        if(this.isLocked == true)
        {
            goto label_26;
        }
        
        val_24 = 100f;
        val_25 = this.rawCounter;
        float val_18 = val_24 / this.丅丆三上丈专丒丂丒.丆不丕三丅丑丑丑丐;
        val_18 = (this.ownerCommand == 1) ? (-val_18) : (val_18);
        label_24:
        val_18 = val_23 * val_18;
        val_25 = val_18 + val_25;
        this.rawCounter = val_24;
        label_26:
        this.丛丛七上不一三丞丌 = true;
    }
    private void 丘东丏丕丟丛且丛三()
    {
        float val_2 = this.rawCounter;
        val_2 = val_2 * this.丘丌丌万丕不丁丙一;
        if(val_2 >= 0)
        {
                return;
        }
        
        if(((this.captureCommand != 0) && (this.previousCommand != 0)) && (this.previousCommand != this.captureCommand))
        {
                if(this.丅丆三上丈专丒丂丒.丅丁东三丝业且与丙 == false)
        {
            goto label_5;
        }
        
        }
        
        if(this.丛丛七上不一三丞丌 != false)
        {
                this.rawCounter = 0f;
        }
        
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.丅丆三上丈专丒丂丒.专丈丝丄丑丅丌丙丕(专七万不丐丆丟东丈:  this.index);
        return;
        label_5:
        var val_1 = (this.captureCommand == 1) ? 1 : 0;
        this.rawCounter = 106026528 + this.captureCommand == 1 ? 1 : 0;
    }
    private void 丌与丟世丑万丙丑一()
    {
        if(System.Math.Abs(this.rawCounter) <= 99.99f)
        {
                return;
        }
        
        if(this.captureCommand < 1)
        {
                return;
        }
        
        if(this.丁丞丗业丆丒上丈丞 < 1)
        {
                return;
        }
        
        if(this.previousCommand == this.captureCommand)
        {
                return;
        }
        
        if(this.captureCommand == 1)
        {
                if(this.rawCounter > 99.99f)
        {
            goto label_8;
        }
        
        }
        
        if(this.rawCounter >= 0)
        {
                return;
        }
        
        if(this.captureCommand != 2)
        {
                return;
        }
        
        label_8:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.丌丅下丕专丈丑下三(丈丞与上丒丘丕丞三:  this.captureCommand);
    }
    internal void 世不丏一丈丄丁七丂()
    {
        this.ownerCommand = 0;
        this.previousCommand = 0;
    }
    internal void 丙一上丟丁世业丑丄(int 丈丞与上丒丘丕丞三, int[] 且专丆与丂丐丏丙丏)
    {
        var val_1 = (丈丞与上丒丘丕丞三 == 1) ? 1 : 0;
        this.丌与丈丟丝丄下丌一 = 0f;
        this.ownerCommand = 丈丞与上丒丘丕丞三;
        this.previousCommand = 丈丞与上丒丘丕丞三;
        this.rawCounter = 106026528 + 丈丞与上丒丘丕丞三 == 1 ? 1 : 0;
        this.丌业万上丑丑丘丈丅(且专丆与丂丐丏丙丏:  且专丆与丂丐丏丙丏);
    }
    private void 丌业万上丑丑丘丈丅(int[] 且专丆与丂丐丏丙丏)
    {
        Player_move_c val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(this.丁丞丗业丆丒上丈丞 == this.ownerCommand)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            丗丄万丟专丈丌丙丈(下丘与业丗丙且业丑:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1781")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1781")) + " " + this.myLetterName);
        }
        
        if((万上丈专丐专丞丛丛.丟不下下且业丛丄丏(丞下万上三丘上与专:  且专丆与丂丐丏丙丏, 丏东丁丂七丟不丒丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())) == false)
        {
                return;
        }
        
        val_9 = null;
        if(且专丆与丂丐丏丙丏.Length == 1)
        {
                val_10 = null;
            丅丛丈丕下下丘丁丐();
            return;
        }
        
        val_11 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  62, 专上丝且丂世丛丝丒:  1f);
    }
    private void 丌丅下丕专丈丑下三(int 丈丞与上丒丘丕丞三)
    {
        var val_7;
        HoldPositionsController val_14;
        var val_15;
        var val_16;
        var val_17;
        this.丌与丈丟丝丄下丌一 = 0f;
        val_14 = 1152921505208709120;
        val_15 = null;
        val_15 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.oneTimeCapture != false)
        {
                val_16 = null;
            val_16 = null;
            double val_13 = (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotSpawnDelay;
            val_13 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_13;
            this.不丛一丟不丄世丕丐 = val_13;
            val_14 = HoldPositionsController.丆丕丝丒不丙且丐丗;
            double val_14 = (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotAllowCaptureDelay;
            val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_14;
            this.丞丕丑不丒万丞下丐 = val_14;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.ownerCommand = 丈丞与上丒丘丕丞三;
        this.previousCommand = 丈丞与上丒丘丕丞三;
        System.Collections.Generic.List<Player_move_c> val_4 = new System.Collections.Generic.List<Player_move_c>();
        List.Enumerator<T> val_5 = this.capturePlayers.GetEnumerator();
        label_20:
        if(((-1076961776) & 1) == 0)
        {
            goto label_15;
        }
        
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.丘丑丅三丆丑丌且丝() != this.ownerCommand)
        {
            goto label_20;
        }
        
        val_4.Add(item:  val_7.丐丏七丌丕丗业且上());
        goto label_20;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_17 = null;
        val_17 = null;
        val_14 = HoldPositionsPoint.<>c.<>9__97_0;
        if(val_14 == null)
        {
                System.Func<Player_move_c, System.Int32> val_10 = null;
            val_14 = val_10;
            val_10 = new System.Func<Player_move_c, System.Int32>(object:  HoldPositionsPoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 HoldPositionsPoint.<>c::丑丝丄丌丝丒丂上丛(Player_move_c 专丞上七七且丝七丗));
            HoldPositionsPoint.<>c.<>9__97_0 = val_14;
        }
        
        TSource[] val_12 = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<Player_move_c, System.Int32>(source:  val_4, selector:  val_10));
        if(this.丅丆三上丈专丒丂丒 != null)
        {
                this.丅丆三上丈专丒丂丒.丈专专丑丈丌丆丙丐(丏丌上与丕业世上丘:  this, 且专丆与丂丐丏丙丏:  val_12);
        }
        
        this.丌业万上丑丑丘丈丅(且专丆与丂丐丏丙丏:  val_12);
    }
    internal void 七丁丞丌下丏丌丁丟(float 丝丝丝丛上丈丅丕不, int 丙一丆丕丑丟丑三丘, int 与丂一三世丑丕丈丂, bool 专丗丛丝丗丞下丑丄)
    {
        if(this.丙丞丛丕丅世下丅丒 == true)
        {
                return;
        }
        
        if(专丗丛丝丗丞下丑丄 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈丗丑专丁丂业丛世(丝丝丝丛上丈丅丕不:  丝丝丝丛上丈丅丕不, 丙一丆丕丑丟丑三丘:  丙一丆丕丑丟丑三丘, 与丂一三世丑丕丈丂:  与丂一三世丑丕丈丂));
    }
    private System.Collections.IEnumerator 丈丗丑专丁丂业丛世(float 丝丝丝丛上丈丅丕不, int 丙一丆丕丑丟丑三丘, int 与丂一三世丑丕丈丂)
    {
        HoldPositionsPoint.七丘三丗一万与丒万 val_1 = new HoldPositionsPoint.七丘三丗一万与丒万(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丝丝丝丛上丈丅丕不 = 丝丝丝丛上丈丅丕不;
            .丙一丆丕丑丟丑三丘 = 丙一丆丕丑丟丑三丘;
        }
        else
        {
                mem[32] = this;
            mem[48] = 丝丝丝丛上丈丅丕不;
            .丙一丆丕丑丟丑三丘 = 丙一丆丕丑丟丑三丘;
        }
        
        .与丂一三世丑丕丈丂 = 与丂一三世丑丕丈丂;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丛丕七丈丂丏丐丂丌()
    {
        this.丙丞丛丕丅世下丅丒 = false;
    }
    public HoldPositionsPoint()
    {
        this.丞世丏东丝东上业丞 = 2;
        this.丛丌三丝丐丈丝七业 = new System.Collections.Generic.List<System.Int32>();
        this.capturePlayers = new System.Collections.Generic.List<Player_move_c>();
    }
    private static HoldPositionsPoint()
    {
        string[] val_1 = new string[26];
        val_1[0] = "A";
        val_1[1] = "B";
        val_1[2] = "C";
        val_1[3] = "D";
        val_1[4] = "E";
        val_1[5] = "F";
        val_1[6] = "G";
        val_1[7] = "H";
        val_1[8] = "I";
        val_1[9] = "J";
        val_1[10] = "K";
        val_1[11] = "L";
        val_1[12] = "M";
        val_1[13] = "N";
        val_1[14] = "O";
        val_1[15] = "P";
        val_1[16] = "Q";
        val_1[17] = "R";
        val_1[18] = "S";
        val_1[19] = "T";
        val_1[20] = "U";
        val_1[21] = "V";
        val_1[22] = "W";
        val_1[23] = "X";
        val_1[24] = "Y";
        val_1[25] = "Z";
        HoldPositionsPoint.七与丞世七且丁丗丁 = val_1;
    }

}
