using UnityEngine;
internal sealed class CapturePointsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static CapturePointsController 丄丘七三上丕世丞业;
    private PhotonView photonView;
    private bool 丙丞丛丕丅世下丅丒;
    private float 下丅丑业丗一丌且丛;
    private float 丝一且丞丛下丟丞世;
    internal System.Collections.Generic.List<BaseCapturePoint> baseCapturePoints;
    private int 丁丞丗业丆丒上丈丞;
    private float 且丒丘丝丏丈且丂七;
    private float 丂丄丕丟专丗丕丛丆;
    private bool 丘丕丄与丈七与下三;
    private TeamController 丛万丅上丂丝丂丙丒;
    private static System.Action<float, float> 丛且下丕丄下丌丌丐;
    
    // Methods
    private void Awake()
    {
        CapturePointsController.丄丘七三上丕世丞业 = this;
        this.丘丕丄与丈七与下三 = false;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        this.丈下丒丟丘丝丂东丝();
    }
    private void 丈下丒丟丘丝丂东丝()
    {
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void CapturePointsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.下世丁丄且丘一丁下 = new System.Action(object:  this, method:  System.Void CapturePointsController::OnDisconnectedFromPhoton());
    }
    internal void 丘上丐世丆丑且丞丒(TeamController 丛万丅上丂丝丂丙丒)
    {
        var val_3;
        var val_4;
        this.丛万丅上丂丝丂丙丒 = 丛万丅上丂丝丂丙丒;
        this.丘丕丄与丈七与下三 = true;
        val_3 = 0;
        goto label_1;
        label_5:
        this.baseCapturePoints.Item[0].丘上丐世丆丑且丞丒(专七万不丐丆丟东丈:  0);
        val_3 = 1;
        label_1:
        if(val_3 < this.baseCapturePoints.Count)
        {
            goto label_5;
        }
        
        val_4 = null;
        val_4 = null;
        typeof(TeamController).__il2cppRuntimeField_38 = 0;
        typeof(TeamController).__il2cppRuntimeField_3C = 0;
        typeof(TeamController).__il2cppRuntimeField_40 = 0;
        typeof(TeamController).__il2cppRuntimeField_44 = 0;
    }
    private void Start()
    {
        var val_18;
        var val_21;
        var val_22;
        string val_23;
        var val_27;
        float val_28;
        if(GameConnect.丞丂丑一丕丑丙三丐() == false)
        {
            goto label_6;
        }
        
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        this.baseCapturePoints = new System.Collections.Generic.List<BaseCapturePoint>();
        System.Collections.IEnumerator val_4 = this.transform.GetEnumerator();
        label_30:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_21 = val_4.Current;
        if(val_21 != null)
        {
            
        }
        
        if(val_21 != null)
        {
                val_21 = 0;
        }
        
        BaseCapturePoint val_13 = val_21.GetComponent<BaseCapturePoint>();
        this.baseCapturePoints.Add(item:  val_13);
        if(val_13 != null)
        {
                val_13.isBasePointActive = false;
        }
        else
        {
                mem[80] = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13.basePointRender, 丏业丟一东丂东丘丛:  false);
        goto label_30;
        label_6:
        this.gameObject.SetActive(value:  false);
        return;
        label_13:
        val_22 = 0;
        val_23 = 0;
        if(val_4 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_4.Dispose();
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        val_23 = GameConnect.丟下丗丙丕丁丞丞丛;
        object val_19 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_23];
        if(null == 7)
        {
            goto label_60;
        }
        
        if(null == 5)
        {
            goto label_61;
        }
        
        if(null != 3)
        {
                return;
        }
        
        val_28 = 1077936128;
        goto label_64;
        label_60:
        val_28 = 1069547520;
        goto label_64;
        label_61:
        val_28 = 2f;
        label_64:
        this.且丒丘丝丏丈且丂七 = val_28;
    }
    private void Update()
    {
        var val_5;
        if(this.丘丕丄与丈七与下三 == false)
        {
                return;
        }
        
        if(this.丙丞丛丕丅世下丅丒 != false)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != true)
        {
                this.OnDisconnectedFromPhoton();
        }
        
        }
        
        val_5 = null;
        val_5 = null;
        this.丁丞丗业丆丒上丈丞 = 丘丑丅三丆丑丌且丝();
        bool val_3 = this.丛万丅上丂丝丂丙丒.业业丝丘七丗丗丈丏();
        this.丁世丁丈丒丗丙丌不(丗上丑丄丑丈丙丂丆:  (~val_3) & 1);
        if(val_3 != false)
        {
                return;
        }
        
        this.丐专不丈丘丘业上专();
        this.三与东丈上一东丗丒();
        this.丛丅业丙丑丙丑丆丄();
    }
    private void 丁世丁丈丒丗丙丌不(bool 丗上丑丄丑丈丙丂丆)
    {
        InGameGUI val_10 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_10 != 0)
        {
                typeof(InGameGUIPart_CapturePoints).__il2cppRuntimeField_28.SetActive(value:  (~丗上丑丄丑丈丙丂丆) & 1);
        }
        
        if(this.丘丕丄与丈七与下三 == false)
        {
                return;
        }
        
        val_10 = 0;
        goto label_8;
        label_21:
        BaseCapturePoint val_4 = this.baseCapturePoints.Item[0];
        val_4.isBasePointActive = 丗上丑丄丑丈丙丂丆;
        BaseCapturePoint val_5 = this.baseCapturePoints.Item[0];
        if(val_5.basePointRender != 0)
        {
                BaseCapturePoint val_7 = this.baseCapturePoints.Item[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7.basePointRender, 丏业丟一东丂东丘丛:  丗上丑丄丑丈丙丂丆);
        }
        
        val_10 = 1;
        label_8:
        if(val_10 < this.baseCapturePoints.Count)
        {
            goto label_21;
        }
    
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        bool val_6;
        object val_7;
        int val_8;
        int val_10;
        int val_11;
        int val_12;
        System.Single[] val_13;
        val_6 = 丞世不丒下上上丝丑;
        val_7 = this;
        byte val_1 = val_6 & 255;
        if(val_1 == 106)
        {
            goto label_1;
        }
        
        if(val_1 == 114)
        {
            goto label_2;
        }
        
        if(val_1 != 113)
        {
            goto label_3;
        }
        
        val_8 = 专丒丌丆下丐丞丟丞.Length;
        val_6 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[0]);
        if(val_8 <= 1)
        {
                val_8 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[1];
        if(val_8 <= 2)
        {
                val_8 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[2];
        if(this.丙丞丛丕丅世下丅丒 == true)
        {
                return true;
        }
        
        专丒丌丆下丐丞丟丞[3].丟一世丂丟三不东丙(丁下丄上与丒上丛业:  3.782474E-38f, 丗上世丛丏丌丂上丅:  3.782474E-38f, 下丄丁丑三丏丗丛七:  15228928);
        this.丙丞丛丕丅世下丅丒 = val_6;
        return true;
        label_2:
        val_10 = 专丒丌丆下丐丞丟丞.Length;
        if(val_10 == 0)
        {
                val_10 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_7 = 专丒丌丆下丐丞丟丞[0];
        if(val_10 <= 1)
        {
                val_10 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[1];
        专丒丌丆下丐丞丟丞[2].丟一世丂丟三不东丙(丁下丄上与丒上丛业:  3.782474E-38f, 丗上世丛丏丌丂上丅:  3.782474E-38f, 下丄丁丑三丏丗丛七:  15228928);
        return true;
        label_1:
        this.丂东东丅丅东东丄丑(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        return true;
        label_3:
        if(this.丘丕丄与丈七与下三 == false)
        {
                return true;
        }
        
        byte val_4 = val_6 & 255;
        if(val_4 != 105)
        {
                if(val_4 != 51)
        {
                if(val_4 != 5)
        {
                return true;
        }
        
            val_11 = 专丒丌丆下丐丞丟丞.Length;
            if(val_11 == 0)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_11 = 专丒丌丆下丐丞丟丞[0];
            object val_12 = 专丒丌丆下丐丞丟丞[1];
            this.丕丞丙丈丞丞丂丏丞(专七万不丐丆丟东丈:  21884928, 丂东丄丏丕丕丅上一:  21884928);
            return true;
        }
        
            val_12 = 专丒丌丆下丐丞丟丞.Length;
            if(val_12 == 0)
        {
                val_12 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_13 = 专丒丌丆下丐丞丟丞[0];
            object val_14 = 专丒丌丆下丐丞丟丞[1];
            this.丝三丘丙万三与丙丛(专七万不丐丆丟东丈:  21884928, 丂东丄丏丕丕丅上一:  21884928);
            return true;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        if(val_6 == null)
        {
            goto label_33;
        }
        
        val_13 = val_6;
        if(val_13 != null)
        {
            goto label_34;
        }
        
        label_33:
        val_13 = 0;
        label_34:
        this.世与丑不丝东丐万丟(专业丞丘东丘丟丞专:  val_13);
        return true;
    }
    internal void 七东丐丐七丅丛丟不(bool 专丗丛丝丗丞下丑丄, float 丁下丄上与丒上丛业, float 丗上世丛丏丌丂上丅, int 下丄丁丑三丏丗丛七)
    {
        if(this.丙丞丛丕丅世下丅丒 == true)
        {
                return;
        }
        
        this.丟一世丂丟三不东丙(丁下丄上与丒上丛业:  丁下丄上与丒上丛业, 丗上世丛丏丌丂上丅:  丗上世丛丏丌丂上丅, 下丄丁丑三丏丗丛七:  专丗丛丝丗丞下丑丄);
        this.丙丞丛丕丅世下丅丒 = 专丗丛丝丗丞下丑丄;
    }
    internal void 丟一世丂丟三不东丙(float 丁下丄上与丒上丛业, float 丗上世丛丏丌丂上丅, int 下丄丁丑三丏丗丛七)
    {
        null = null;
        typeof(TeamController).__il2cppRuntimeField_40 = 丁下丄上与丒上丛业;
        typeof(TeamController).__il2cppRuntimeField_44 = 丗上世丛丏丌丂上丅;
        typeof(TeamController).__il2cppRuntimeField_38 = (int)丁下丄上与丒上丛业;
        typeof(TeamController).__il2cppRuntimeField_3C = (int)丗上世丛丏丌丂上丅;
    }
    internal static void 丂且丅丂丏丌丝丘丂(System.Action<float, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  CapturePointsController.丛且下丕丄下丌丌丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(CapturePointsController.丛且下丕丄下丌丌丐 != 1152921505187467272);
    
    }
    internal static void 丘丗丑丌丐七下东东(System.Action<float, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  CapturePointsController.丛且下丕丄下丌丌丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(CapturePointsController.丛且下丕丄下丌丌丐 != 1152921505187467272);
    
    }
    private void 丐专不丈丘丘业上专()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        int val_1 = 丘丑丅三丆丑丌且丝();
        val_12 = 0;
        val_13 = 0;
        val_14 = 0;
        goto label_5;
        label_14:
        BaseCapturePoint val_2 = this.baseCapturePoints.Item[0];
        if(val_2.ownerCommand >= 1)
        {
                BaseCapturePoint val_3 = this.baseCapturePoints.Item[0];
            BaseCapturePoint val_5 = this.baseCapturePoints.Item[0];
        }
        
        val_12 = 1;
        label_5:
        if(val_12 < this.baseCapturePoints.Count)
        {
            goto label_14;
        }
        
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_8 * this.且丒丘丝丏丈且丂七;
        float val_10 = UnityEngine.Time.deltaTime;
        float val_11 = this.且丒丘丝丏丈且丂七;
        val_10 = val_10 * val_11;
        val_11 = val_10 * ((float)(val_5.ownerCommand != val_1) ? (val_13 + 1) : (val_13));
        if(val_1 != 2)
        {
                if(val_1 != 1)
        {
                return;
        }
        
            if(CapturePointsController.丛且下丕丄下丌丌丐 == null)
        {
                return;
        }
        
            val_15 = 1152921537441076032;
        }
        else
        {
                if(CapturePointsController.丛且下丕丄下丌丌丐 == null)
        {
                return;
        }
        
            val_15 = 1152921537441076032;
        }
        
        CapturePointsController.丛且下丕丄下丌丌丐.Invoke(arg1:  val_11, arg2:  val_8 * ((float)(val_3.ownerCommand == val_1) ? (val_14 + 1) : (val_14)));
    }
    private void 三与东丈上一东丗丒()
    {
        object val_4;
        var val_5;
        val_4 = this;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丝一且丞丛下丟丞世 - val_2;
        this.丝一且丞丛下丟丞世 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        this.丝一且丞丛下丟丞世 = this.下丅丑业丗一丌且丛;
        val_5 = null;
        val_5 = null;
        object[] val_3 = new object[3];
        val_3[0] = TeamController.__il2cppRuntimeField_element_class;
        val_3[1] = typeof(TeamController).__il2cppRuntimeField_44;
        val_4 = this.丁丞丗业丆丒上丈丞;
        val_3[2] = val_4;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  114, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void OnDestroy()
    {
        System.Action<与丅丕丈丘东丝世丟> val_8;
        System.Action val_9;
        CapturePointsController.丄丘七三上丕世丞业 = 0;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        val_8 = System.Delegate.Remove(source:  val_1.专不丐一丈丌丛丁丕, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void CapturePointsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        if(this.与丑丌丌丌丁丌不丕() == null)
        {
            goto label_4;
        }
        
        if(val_8 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_8 == null)
        {
            goto label_8;
        }
        
        label_5:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_8:
        val_1.专不丐一丈丌丛丁丕 = val_8;
        val_9 = System.Delegate.Remove(source:  val_5.下世丁丄且丘一丁下, value:  new System.Action(object:  this, method:  System.Void CapturePointsController::OnDisconnectedFromPhoton()));
        if(this.与丑丌丌丌丁丌不丕() == null)
        {
            goto label_10;
        }
        
        if(val_9 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_9 == null)
        {
            goto label_14;
        }
        
        label_11:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_14:
        val_5.下世丁丄且丘一丁下 = val_9;
    }
    internal void 丟下三下丈丆丝东丁(int 专七万不丐丆丟东丈, int 丂东丄丏丕丕丅上一)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(专七万不丐丆丟东丈 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(专七万不丐丆丟东丈 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 专七万不丐丆丟东丈;
        val_1[1] = 丂东丄丏丕丕丅上一;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  5, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丕丞丙丈丞丞丂丏丞(int 专七万不丐丆丟东丈, int 丂东丄丏丕丕丅上一)
    {
        var val_8;
        var val_9;
        var val_10;
        System.Collections.Generic.List<Player_move_c> val_11;
        var val_12;
        var val_13;
        val_8 = 0;
        goto label_1;
        label_11:
        val_9 = null;
        val_9 = null;
        Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_1.photonView.ownerId == 丂东丄丏丕丕丅上一)
        {
            goto label_7;
        }
        
        val_8 = 1;
        label_1:
        val_10 = null;
        val_10 = null;
        val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_8 < val_11.Count)
        {
            goto label_11;
        }
        
        return;
        label_7:
        BaseCapturePoint val_3 = this.baseCapturePoints.Item[专七万不丐丆丟东丈];
        val_12 = null;
        val_12 = null;
        val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if((val_3.capturePlayers.Contains(item:  val_11)) != false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        this.baseCapturePoints.Item[专七万不丐丆丟东丈].丕丞丙丈丞丞丂丏丞(上下丗丌丑业丌三与:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0]);
    }
    internal void 丁世丄不丈丗丕丘上(int 专七万不丐丆丟东丈, int 丂东丄丏丕丕丅上一)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(专七万不丐丆丟东丈 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(专七万不丐丆丟东丈 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 专七万不丐丆丟东丈;
        val_1[1] = 丂东丄丏丕丕丅上一;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  51, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丝三丘丙万三与丙丛(int 专七万不丐丆丟东丈, int 丂东丄丏丕丕丅上一)
    {
        var val_8;
        var val_9;
        var val_10;
        System.Collections.Generic.List<Player_move_c> val_11;
        var val_12;
        var val_13;
        val_8 = 0;
        goto label_1;
        label_11:
        val_9 = null;
        val_9 = null;
        Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_1.photonView.ownerId == 丂东丄丏丕丕丅上一)
        {
            goto label_7;
        }
        
        val_8 = 1;
        label_1:
        val_10 = null;
        val_10 = null;
        val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_8 < val_11.Count)
        {
            goto label_11;
        }
        
        return;
        label_7:
        BaseCapturePoint val_3 = this.baseCapturePoints.Item[专七万不丐丆丟东丈];
        val_12 = null;
        val_12 = null;
        val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if((val_3.capturePlayers.Contains(item:  val_11)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        this.baseCapturePoints.Item[专七万不丐丆丟东丈].丝三丘丙万三与丙丛(丕丌丛丗三丁丟丛东:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0]);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        PhotonView val_18;
        var val_19;
        var val_20;
        System.Func<BaseCapturePoint, System.Single> val_22;
        var val_23;
        System.Func<BaseCapturePoint, System.Int32> val_25;
        var val_26;
        System.Func<BaseCapturePoint, System.Int32> val_28;
        var val_29;
        System.Func<BaseCapturePoint, System.Int32> val_31;
        val_18 = this;
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = CapturePointsController.<>c.<>9__30_0;
        if(val_22 == null)
        {
                System.Func<BaseCapturePoint, System.Single> val_2 = null;
            val_22 = val_2;
            val_2 = new System.Func<BaseCapturePoint, System.Single>(object:  CapturePointsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Single CapturePointsController.<>c::业丏下不丐丞上专丝(BaseCapturePoint 三丟东丕丄丄下下丑));
            CapturePointsController.<>c.<>9__30_0 = val_22;
        }
        
        val_23 = null;
        val_23 = null;
        val_25 = CapturePointsController.<>c.<>9__30_1;
        if(val_25 == null)
        {
                System.Func<BaseCapturePoint, System.Int32> val_5 = null;
            val_25 = val_5;
            val_5 = new System.Func<BaseCapturePoint, System.Int32>(object:  CapturePointsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CapturePointsController.<>c::丌丑丒丒东七上丆三(BaseCapturePoint 三丟东丕丄丄下下丑));
            CapturePointsController.<>c.<>9__30_1 = val_25;
        }
        
        val_26 = null;
        val_26 = null;
        val_28 = CapturePointsController.<>c.<>9__30_2;
        if(val_28 == null)
        {
                System.Func<BaseCapturePoint, System.Int32> val_8 = null;
            val_28 = val_8;
            val_8 = new System.Func<BaseCapturePoint, System.Int32>(object:  CapturePointsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CapturePointsController.<>c::三丙丞一丟业三且丑(BaseCapturePoint 三丟东丕丄丄下下丑));
            CapturePointsController.<>c.<>9__30_2 = val_28;
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = CapturePointsController.<>c.<>9__30_3;
        if(val_31 == null)
        {
                System.Func<BaseCapturePoint, System.Int32> val_11 = null;
            val_31 = val_11;
            val_11 = new System.Func<BaseCapturePoint, System.Int32>(object:  CapturePointsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CapturePointsController.<>c::丆丆丁与丁丂丐丑丟(BaseCapturePoint 三丟东丕丄丄下下丑));
            CapturePointsController.<>c.<>9__30_3 = val_31;
        }
        
        val_18 = this.photonView;
        object[] val_14 = new object[6];
        val_14[0] = 专丞上七七且丝七丗.业丐丐三丕一丗丛丁();
        val_14[1] = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        val_14[2] = System.Linq.Enumerable.ToArray<System.Single>(source:  System.Linq.Enumerable.Select<BaseCapturePoint, System.Single>(source:  this.baseCapturePoints, selector:  val_2));
        val_14[3] = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<BaseCapturePoint, System.Int32>(source:  this.baseCapturePoints, selector:  val_5));
        val_14[4] = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<BaseCapturePoint, System.Int32>(source:  this.baseCapturePoints, selector:  val_8));
        val_14[5] = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<BaseCapturePoint, System.Int32>(source:  this.baseCapturePoints, selector:  val_11));
        val_18.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  106, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_14);
    }
    private void 丂东东丅丅东东丄丑(object[] 专丒丌丆下丐丞丟丞)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        if(mem[1152921537442857488] == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != null)
        {
                return;
        }
        
        bool val_3 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[1]);
        int val_4 = mem[1152921537442857504].Count;
        object val_14 = 专丒丌丆下丐丞丟丞[2];
        if(val_14 == null)
        {
            goto label_13;
        }
        
        val_10 = val_14;
        if(val_10 != null)
        {
            goto label_14;
        }
        
        label_13:
        val_10 = 0;
        label_14:
        object val_15 = 专丒丌丆下丐丞丟丞[3];
        val_9 = 1152921505725111792;
        if(val_15 == null)
        {
            goto label_16;
        }
        
        val_11 = val_15;
        if(val_11 != null)
        {
            goto label_17;
        }
        
        label_16:
        val_11 = 0;
        label_17:
        object val_16 = 专丒丌丆下丐丞丟丞[4];
        if(val_16 == null)
        {
            goto label_19;
        }
        
        val_12 = val_16;
        if(val_12 != null)
        {
            goto label_20;
        }
        
        label_19:
        val_12 = 0;
        label_20:
        object val_17 = 专丒丌丆下丐丞丟丞[5];
        if(val_17 == null)
        {
            goto label_22;
        }
        
        val_13 = val_17;
        if(val_13 != null)
        {
            goto label_23;
        }
        
        label_22:
        val_13 = 0;
        label_23:
        if(val_4 >= 1)
        {
                var val_6 = val_10 + 32;
            var val_7 = val_11 + 32;
            var val_18 = 0;
            var val_8 = val_12 + 32;
            val_9 = val_13 + 32;
            do
        {
            mem[1152921537442857504].Item[0].七丁丞丌下丏丌丁丟(丝丝丝丛上丈丅丕不:  (val_10 + 32) + 0, 丙一丆丕丑丟丑三丘:  (val_11 + 32) + 0, 与丂一三世丑丕丈丂:  (val_12 + 32) + 0, 丝丑丏业七不丆丁且:  (val_13 + 32) + 0, 专丗丛丝丗丞下丑丄:  val_3);
            val_18 = val_18 + 1;
        }
        while(val_4 != val_18);
        
        }
        
        mem[1152921537442857488] = val_3;
    }
    private void 丛丅业丙丑丙丑丆丄()
    {
        var val_7;
        System.Func<BaseCapturePoint, System.Single> val_9;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丝一且丞丛下丟丞世 - val_2;
        this.丝一且丞丛下丟丞世 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = CapturePointsController.<>c.<>9__32_0;
        if(val_9 == null)
        {
                System.Func<BaseCapturePoint, System.Single> val_3 = null;
            val_9 = val_3;
            val_3 = new System.Func<BaseCapturePoint, System.Single>(object:  CapturePointsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Single CapturePointsController.<>c::丗丕丐丐三丏与丏丕(BaseCapturePoint 三丟东丕丄丄下下丑));
            CapturePointsController.<>c.<>9__32_0 = val_9;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = System.Linq.Enumerable.ToArray<System.Single>(source:  System.Linq.Enumerable.Select<BaseCapturePoint, System.Single>(source:  this.baseCapturePoints, selector:  val_3));
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  105, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_6);
    }
    private void 世与丑不丝东丐万丟(float[] 专业丞丘东丘丟丞专)
    {
        goto label_1;
        label_7:
        this.baseCapturePoints.Item[0].且不丙丟丘不丌丆丌(丝丝丝丛上丈丅丕不:  专业丞丘东丘丟丞专[0]);
        0 = 1;
        label_1:
        if(0 < this.baseCapturePoints.Count)
        {
            goto label_7;
        }
    
    }
    internal void 丛业丑丁七下专丌上()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        typeof(TeamController).__il2cppRuntimeField_38 = 0;
        typeof(TeamController).__il2cppRuntimeField_3C = 0;
        typeof(TeamController).__il2cppRuntimeField_40 = 0;
        typeof(TeamController).__il2cppRuntimeField_44 = 0;
        this.丘丕丄与丈七与下三 = false;
        val_4 = 0;
        goto label_11;
        label_15:
        this.baseCapturePoints.Item[0].Reset();
        val_4 = 1;
        label_11:
        if(val_4 < this.baseCapturePoints.Count)
        {
            goto label_15;
        }
    
    }
    private void OnDisconnectedFromPhoton()
    {
        var val_3;
        this.丙丞丛丕丅世下丅丒 = false;
        val_3 = 0;
        goto label_1;
        label_5:
        this.baseCapturePoints.Item[0].丛丕七丈丂丏丐丂丌();
        val_3 = 1;
        label_1:
        if(val_3 < this.baseCapturePoints.Count)
        {
            goto label_5;
        }
    
    }
    public CapturePointsController()
    {
        this.下丅丑业丗一丌且丛 = 1f;
        this.且丒丘丝丏丈且丂七 = 3f;
        this.丂丄丕丟专丗丕丛丆 = 1000f;
    }

}
