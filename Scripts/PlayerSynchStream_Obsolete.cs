using UnityEngine;
internal sealed class PlayerSynchStream_Obsolete : VTableHolder
{
    // Fields
    private bool 下与丆丂丐丏七丟丆;
    private bool 丝丐丄丌丞且下下丘;
    internal int 丞丐丕东丅丗丟丌丆;
    internal float 东丌专三丄丌丗且丏;
    internal bool 东丆不丄与丑丝世三;
    private UnityEngine.Vector3 丞上业丐丞丝不丐专;
    private double 丌丟丗下专丙丕不丘;
    private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
    private UnityEngine.Quaternion 不专丐丝三丟一与丆;
    internal Player_move_c playerMovec;
    internal bool 世丂丁丗下世丘丄业;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    private double 下丟丒丁下丄丕丂专;
    public FirstPersonControlSharp personController;
    private PlayerSynchStream_Obsolete.丝丙丒丌东下丕丘丘[] 东专业丑与丐丆丐丟;
    private int 三与丅业上丏与与丛;
    private 世丐万七丄丟丅丑东 丅一丒丆丐东丝丕丐;
    private bool 丌丂丗且丙专业丁业;
    internal SkinName skinName;
    internal bool 专丞世丒丞丞不丝东;
    internal bool 丕不丛丕丛丘丙丑丂;
    internal bool 业丂万丏丒丛丒万且;
    internal bool 丘丟丄丗丞丝丘东七;
    private bool 上丅丝世且与与下丄;
    private bool 丌且下丕下下丌万丞;
    private bool 一一丆丌专丑丏丕丗;
    private UnityEngine.Transform 下三专不丘业丂丌丛;
    private UnityEngine.Vector3 丕丂丐世丌丗丙丙丅;
    private bool 丞丄上不丄七丟丏上;
    
    // Properties
    private bool 一与丙业丈一丙丙丙 { get; }
    
    // Methods
    private bool 丙丁丄与丑丅丝丟世()
    {
        if(this.丞丐丕东丅丗丟丌丆 <= 0)
        {
                return (bool)(this.东丌专三丄丌丗且丏 > UnityEngine.Time.realtimeSinceStartup) ? 1 : 0;
        }
        
        return true;
    }
    private void Awake()
    {
        var val_3;
        丝丙丒丌东下丕丘丘[] val_4;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                this.enabled = false;
        }
        
        this.万东万丆专丌丕丐丗 = this.transform;
        this.丞上业丐丞丝不丐专 = 0;
        mem[1152921535950272784] = 0;
        val_4 = new 丝丙丒丌东下丕丘丘[0];
        this.东专业丑与丐丆丐丟 = val_4;
        if(this.三与丅业上丏与与丛 < 1)
        {
            goto label_4;
        }
        
        var val_4 = 0;
        goto label_5;
        label_8:
        val_4 = this.东专业丑与丐丆丐丟;
        label_5:
        var val_3 = val_4 + (0 * 88);
        mem2[0] = 0;
        val_4 = val_4 + 1;
        if(val_4 < this.三与丅业上丏与与丛)
        {
            goto label_8;
        }
        
        label_4:
        this.下丟丒丁下丄丕丂专 = 1;
    }
    internal PlayerSynchStream_Obsolete()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.丘丐丐不丐丁丛且丝 = val_1;
        mem[1152921535950439076] = val_1.y;
        mem[1152921535950439080] = val_1.z;
        mem[1152921535950439084] = val_1.w;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.不专丐丝三丟一与丆 = val_2;
        mem[1152921535950439092] = val_2.y;
        mem[1152921535950439096] = val_2.z;
        mem[1152921535950439100] = val_2.w;
        this.三与丅业上丏与与丛 = 5;
        this.丌丂丗且丙专业丁业 = true;
        this.业丂万丏丒丛丒万且 = true;
        this.上丅丝世且与与下丄 = true;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void PlayerSynchStream_Obsolete::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Start()
    {
        var val_4;
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                this.三与丅业上丏与与丛 = 3;
        }
        
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        this.丌且下丕下下丌万丞 = true;
    }
    internal void 丅丏丕丟且丛丅丛丞()
    {
        Player_move_c val_46;
        var val_47;
        float val_48;
        float val_49;
        float val_50;
        UnityEngine.Transform val_51;
        bool val_52;
        bool val_53;
        bool val_54;
        FirstPersonControlSharp val_55;
        val_46 = this.playerMovec;
        if(val_46 != null)
        {
                val_47 = this;
            this.下与丆丂丐丏七丟丆 = this.playerMovec.万丝一万丐且丌业丛;
        }
        else
        {
                val_47 = this;
            this.下与丆丂丐丏七丟丆 = this.playerMovec.万丝一万丐且丌业丛;
            val_46 = val_46;
        }
        
        if(val_46.丘七业丒丐世丂丅丒() <= 0f)
        {
                if(this.playerMovec.丐下丘丟丁丆丟丆丈() <= 0f)
        {
                mem[1152921535950908792] = 1;
        }
        
        }
        
        if(this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗 != false)
        {
                PlatformController[] val_4 = PlatformsList.丄丘七三上丕世丞业.platforms + ((this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙) << 3);
            UnityEngine.Vector3 val_6 = this.万东万丆专丌丕丐丗.position;
            val_48 = val_6.x;
            val_49 = val_6.y;
            val_50 = val_6.z;
            UnityEngine.Vector3 val_7 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙) << 3) + 32].transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50});
        }
        else
        {
                UnityEngine.Vector3 val_8 = this.万东万丆专丌丕丐丗.position;
            val_48 = val_8.x;
            val_49 = val_8.y;
            val_50 = val_8.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50}, b:  new UnityEngine.Vector3() {x = this.playerMovec.丈丄丑东业丌七东丄, y = V11.16B, z = V12.16B});
        }
        
        .业丒丝丗与丐丛丟丏 = val_9;
        mem[1152921535950940772] = val_9.y;
        mem[1152921535950940776] = val_9.z;
        if(((GameConnect.万不丒丌丙万丗东不() == false) || (this.playerMovec.与丏下丝万上三丛不() == false)) || (this.playerMovec.东三上专丅东业丛丐() == 0))
        {
            goto label_34;
        }
        
        val_51 = this.playerMovec.东三上专丅东业丛丐().transform;
        if(val_51 != null)
        {
            goto label_43;
        }
        
        goto label_43;
        label_34:
        val_51 = this.万东万丆专丌丕丐丗;
        if(val_51 == null)
        {
            goto label_42;
        }
        
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_43;
        }
        
        label_45:
        UnityEngine.Quaternion val_16 = val_51.localRotation;
        goto label_44;
        label_42:
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_45;
        }
        
        label_43:
        UnityEngine.Quaternion val_17 = val_51.rotation;
        label_44:
        .丌丘丘丞丈一丙与丐 = (int)val_17.y * 10f;
        UnityEngine.Quaternion val_20 = this.playerMovec.myTransform.localRotation;
        float val_46 = this.playerMovec.mySkinName.playerAnimation.丗丞万不上丁丘丄丑;
        val_46 = (val_20.x - this.playerMovec.mySkinName.firstPersonControl.万丗丈丗三不丌不丆) - val_46;
        val_46 = val_46 * 10f;
        .丘业与丐丅丘丕丄丙 = (int)val_46;
        .丘丞且丌丑下丘世丐 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        .丆不丝丝上一丞七业 = this.skinName.playerAnimation.丄丙丂丝丄丌丗丂丅();
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_52 = this.playerMovec.mySkinName.firstPersonControl.丑丞丒丟丞丟丆丁一;
        }
        else
        {
                val_52 = false;
        }
        
        .世专丆丈丅七万下丌 = val_52;
        int val_47 = System.Convert.ToInt32(value:  (mem[1152921535950908792] != 0) ? 1 : 0);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                var val_28 = (this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true) ? 1 : 0;
        }
        else
        {
                val_53 = 丘丐丘万丌丟丞下丝.不丐且丞世业不丆丝();
        }
        
        if(this.丕不丛丕丛丘丙丑丂 != false)
        {
                val_54 = 1;
        }
        else
        {
                val_54 = this.playerMovec.一专丑丗丝七丗丑丕();
        }
        
        val_47 = val_47 | ((System.Convert.ToInt32(value:  val_53)) << 1);
        int val_42 = (val_47 | ((System.Convert.ToInt32(value:  this.playerMovec.丏下丙丞丕丕丏丕丞())) << 2)) | ((System.Convert.ToInt32(value:  val_54)) << 3);
        val_42 = val_42 | ((System.Convert.ToInt32(value:  this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗)) << 4);
        val_42 = val_42 | ((System.Convert.ToInt32(value:  (世丐万七丄丟丅丑东)[1152921535950940752].世专丆丈丅七万下丌)) << 5);
        val_42 = val_42 | ((System.Convert.ToInt32(value:  this.业丂万丏丒丛丒万且)) << 6);
        val_42 = val_42 | ((System.Convert.ToInt32(value:  this.丘丟丄丗丞丝丘东七)) << 7);
        .丄丒丗丟世丘万丙丟 = val_42;
        if(this.丘丟丄丗丞丝丘东七 != false)
        {
                this.丘丟丄丗丞丝丘东七 = false;
        }
        
        val_55 = this.playerMovec.mySkinName.firstPersonControl;
        .丝丞丆丐不丞三丑与 = this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗;
        if(this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗 != false)
        {
                val_55 = this.playerMovec.mySkinName.firstPersonControl;
            .丐丑万与丏丄丒三丄 = this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙;
        }
        
        if((世丐万七丄丟丅丑东)[1152921535950940752].世专丆丈丅七万下丌 != false)
        {
                val_55 = this.playerMovec.mySkinName.FPSplayerObject.transform.parent;
            UnityEngine.Quaternion val_45 = val_55.localRotation;
            .丝业丁业一丛丈丄丄 = val_45.x;
            mem[1152921535950940804] = val_45.y;
            mem[1152921535950940808] = val_45.z;
        }
        
        this.丕不丛丕丛丘丙丑丂 = false;
        this.丅一丒丆丐东丝丕丐 = new 世丐万七丄丟丅丑东();
    }
    private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        FirstPersonControlSharp val_39;
        string val_40;
        世丐万七丄丟丅丑东 val_41;
        bool val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        double val_47;
        var val_49;
        val_40 = this;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() == false)
        {
            goto label_2;
        }
        
        if(this.personController != 0)
        {
                val_39 = this.personController;
            if(this.personController.且丆丅丏丌丗丛丄丌 == true)
        {
                return;
        }
        
        }
        
        if(this.playerMovec.丘七业丒丐世丂丅丒() <= 0f)
        {
                if(this.playerMovec.丐下丘丟丁丆丟丆丈() <= 0f)
        {
                this.下与丆丂丐丏七丟丆 = true;
        }
        
        }
        
        val_41 = this.丅一丒丆丐东丝丕丐;
        if(val_41 != null)
        {
            goto label_12;
        }
        
        this.丅丏丕丟且丛丅丛丞();
        val_41 = this.丅一丒丆丐东丝丕丐;
        if(val_41 == null)
        {
            goto label_13;
        }
        
        label_12:
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.业丒丝丗与丐丛丟丏);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丌丘丘丞丈一丙与丐);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丘业与丐丅丘丕丄丙);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丘丞且丌丑下丘世丐);
        val_42 = 1152921504617762816;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丆不丝丝上一丞七业);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丄丒丗丟世丘万丙丟);
        if(this.丅一丒丆丐东丝丕丐.丝丞丆丐不丞三丑与 != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丐丑万与丏丄丒三丄);
        }
        
        val_39 = this.丅一丒丆丐东丝丕丐;
        if(this.丅一丒丆丐东丝丕丐.世专丆丈丅七万下丌 != false)
        {
                val_39 = this.丅一丒丆丐东丝丕丐.丝业丁业一丛丈丄丄;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅一丒丆丐东丝丕丐.丝业丁业一丛丈丄丄);
        }
        
        this.丅一丒丆丐东丝丕丐 = 0;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        val_40 = "Stream " + this.GetType();
        丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  val_40, 丗丟上上丒丐丗丞丙:  东业丄丅丅且世七丄.东与上丗与丏下丂丘());
        return;
        label_2:
        if(this.上丅丝世且与与下丄 != false)
        {
                this.上丅丝世且与与下丄 = false;
            return;
        }
        
        object val_9 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丞上业丐丞丝不丐专 = new UnityEngine.Vector3();
        mem[1152921535951483616] = ???;
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_43 = 10f;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Euler(x:  0f, y:  (1.152922E+18f) / val_43, z:  0f);
        this.丘丐丐不丐丁丛且丝 = val_12;
        mem[1152921535951483636] = val_12.y;
        mem[1152921535951483640] = val_12.z;
        mem[1152921535951483644] = val_12.w;
        object val_13 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_44 = 0f;
        val_45 = 0f;
        val_46 = (1.152922E+18f) / val_43;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(x:  val_46, y:  val_44, z:  val_45);
        this.不专丐丝三丟一与丆 = val_14;
        mem[1152921535951483652] = val_14.y;
        mem[1152921535951483656] = val_14.z;
        mem[1152921535951483660] = val_14.w;
        object val_15 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丌丟丗下专丙丕不丘 = null;
        object val_16 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_17 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丝丐丄丌丞且下下丘 = this.下与丆丂丐丏七丟丆;
        bool val_19 = System.Convert.ToBoolean(value:  0);
        this.下与丆丂丐丏七丟丆 = val_19;
        this.playerMovec.万丝一万丐且丌业丛 = val_19;
        if(this.下与丆丂丐丏七丟丆 == true)
        {
            goto label_52;
        }
        
        val_47 = this.下丟丒丁下丄丕丂专;
        val_43 = this.丌丟丗下专丙丕不丘;
        val_44 = 1000f;
        float val_46 = (float)val_47;
        val_45 = (float)val_43;
        val_46 = val_46 - val_45;
        val_46 = System.Math.Abs(val_46);
        if(val_46 <= val_44)
        {
            goto label_55;
        }
        
        label_52:
        this.丌丂丗且丙专业丁业 = true;
        this.下丟丒丁下丄丕丂专 = this.丌丟丗下专丙丕不丘;
        label_55:
        bool val_21 = System.Convert.ToBoolean(value:  1152921504628731904 & 2);
        this.playerMovec.东丌丟丄丒丙丗丙专(丙业与丙丗丝不丈东:  System.Convert.ToBoolean(value:  1152921504628731904 & 4));
        bool val_27 = System.Convert.ToBoolean(value:  1152921504628731904 & 8);
        this.丕不丛丕丛丘丙丑丂 = val_27;
        if(val_27 != true)
        {
                if(this.丞丄上不丄七丟丏上 == false)
        {
            goto label_77;
        }
        
        }
        
        this.丌丂丗且丙专业丁业 = true;
        this.丞丄上不丄七丟丏上 = false;
        this.下丟丒丁下丄丕丂专 = this.丌丟丗下专丙丕不丘;
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 != true)
        {
                val_43 = this.丞上业丐丞丝不丐专;
            val_46 = val_43;
            val_44 = val_47;
            val_45 = V10.16B;
            this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_46, y = val_44, z = val_45};
        }
        
        if((val_21 & GameConnect.万不丒丌丙万丗东不()) != false)
        {
                val_43 = this.丘丐丐不丐丁丛且丝;
            val_46 = val_43;
            val_44 = val_47;
            val_45 = V10.16B;
            this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = val_46, y = val_44, z = val_45, w = V11.16B};
        }
        else
        {
                if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_77;
        }
        
        }
        
            val_43 = this.丘丐丐不丐丁丛且丝;
            val_46 = val_43;
            val_44 = val_47;
            val_45 = V10.16B;
            this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_46, y = val_44, z = val_45, w = V11.16B};
        }
        
        label_77:
        val_42 = System.Convert.ToBoolean(value:  1152921504628731904 & 16);
        if(val_42 != false)
        {
                object val_33 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        else
        {
                val_49 = 0;
        }
        
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.zero;
        if((System.Convert.ToBoolean(value:  1152921504628731904 & 32)) != false)
        {
                object val_41 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        
        this.专丘丐丐世专丆丗上(丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = this.丞上业丐丞丝不丐专, y = V7.16B, z = V16.16B}, 丝丏丏东丘丐丝下不:  new UnityEngine.Quaternion() {x = this.丘丐丐不丐丁丛且丝}, 与三专东丝七世丄丆:  new UnityEngine.Quaternion() {x = this.不专丐丝三丟一与丆, y = 2.524355E-29f, z = this.丌丟丗下专丙丕不丘}, 丄丆万一丙丂丕不丐:  val_40.z, 丆丄七丙丅丈上丞一:  21884928, 丈丙丟上丁丗丕丐七:  val_21, 业七丄丌丏丁丑不下:  val_42, 七丛丌丞丐丆丐专丛:  0, 丌丘丐丟丆且三丄丙:  new UnityEngine.Vector3() {x = this.丅一丒丆丐东丝丕丐.丄丒丗丟世丘万丙丟, y = this.丅一丒丆丐东丝丕丐.丘丞且丌丑下丘世丐, z = this.丅一丒丆丐东丝丕丐.丘业与丐丅丘丕丄丙}, 丈不丁万且丐丂丐下:  System.Convert.ToBoolean(value:  1152921504628731904 & 64), 不东一丏丟丕丆一一:  System.Convert.ToBoolean(value:  1152921504628731904 & 128));
        return;
        label_13:
    }
    internal void 世丐丄万丆丂丂丄世()
    {
        this.世丂丁丗下世丘丄业 = true;
    }
    private void LateUpdate()
    {
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        if(this.下与丆丂丐丏七丟丆 == true)
        {
                return;
        }
        
        if(this.世丂丁丗下世丘丄业 == true)
        {
                return;
        }
        
        if(this.下三专不丘业丂丌丛 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.下三专不丘业丂丌丛.TransformPoint(position:  new UnityEngine.Vector3() {x = this.丕丂丐世丌丗丙丙丅, y = V9.16B, z = V10.16B});
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    private void Update()
    {
        UnityEngine.Transform val_92;
        float val_96;
        ScopeViewGameEventsController val_100;
        float val_101;
        UnityEngine.Quaternion val_105;
        float val_106;
        double val_107;
        double val_109;
        var val_110;
        丝丙丒丌东下丕丘丘[] val_111;
        float val_115;
        float val_116;
        float val_117;
        float val_118;
        float val_122;
        var val_123;
        float val_124;
        var val_125;
        float val_126;
        float val_127;
        float val_131;
        var val_132;
        float val_133;
        float val_134;
        float val_138;
        var val_139;
        var val_141;
        float val_142;
        float val_143;
        float val_144;
        val_92 = this;
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.万东万丆专丌丕丐丗.position;
        if(this.playerMovec.丙丌丅丆丅世世七丛 != true)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_8;
        }
        
        }
        
        if(this.playerMovec.丞丕丗丟丗丛丐与三 == false)
        {
            goto label_10;
        }
        
        if(this.下与丆丂丐丏七丟丆 == false)
        {
            goto label_11;
        }
        
        this.下三专不丘业丂丌丛 = 0;
        if(this.丝丐丄丌丞且下下丘 != true)
        {
                this.丝丐丄丌丞且下下丘 = this.下与丆丂丐丏七丟丆;
            this.世丂丁丗下世丘丄业 = false;
        }
        
        UnityEngine.Vector3 val_2 = this.万东万丆专丌丕丐丗.position;
        if(val_2.y <= (-8000f))
        {
            goto label_273;
        }
        
        val_96 = 0f;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 0f, y = val_96, z = 0f};
        goto label_273;
        label_10:
        UnityEngine.Vector3 val_3 = this.万东万丆专丌丕丐丗.position;
        if(val_3.y > (-8000f))
        {
            goto label_60;
        }
        
        goto label_65;
        label_11:
        val_100 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        val_101 = 0f;
        if(val_100 != 0)
        {
                val_100 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
            if((val_100.GetEventSettings(且下丕七丙丗丄不七:  2)) != null)
        {
                val_100 = ScopeViewGameEventsController.丄丘七三上丕世丞业.GetEventSettings(且下丕七丙丗丄不七:  2);
            val_101 = val_6.maxTargetDistance * val_6.maxTargetDistance;
        }
        
        }
        
        if(this.丝丐丄丌丞且下下丘 == false)
        {
            goto label_36;
        }
        
        label_358:
        if(this.丌丂丗且丙专业丁业 == true)
        {
            goto label_273;
        }
        
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_41;
        }
        
        var val_121 = -4294967296;
        val_121 = val_121 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_8 = this.东专业丑与丐丆丐丟 + ((val_121 >> 32) * 88);
        if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 96) == 0)
        {
            goto label_44;
        }
        
        var val_122 = -4294967296;
        val_122 = val_122 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_10 = this.东专业丑与丐丆丐丟 + ((val_122 >> 32) * 88);
        PlatformController[] val_11 = PlatformsList.丄丘七三上丕世丞业.platforms + (((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3);
        UnityEngine.Vector3 val_12 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48.position;
        goto label_52;
        label_8:
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(this.playerMovec.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
            goto label_60;
        }
        
        }
        
        if(this.playerMovec.丁三三丒丌与丄丑丁 == false)
        {
            goto label_60;
        }
        
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = this.playerMovec.丄丈丐世丄丁与三不, y = V9.16B, z = V10.16B};
        val_100 = this.playerMovec;
        val_105 = this.playerMovec.业丞丛丌丘丝丗三丙;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_105, y = V9.16B, z = V10.16B, w = V11.16B};
        goto label_65;
        label_60:
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_65:
        this.丞丄上不丄七丟丏上 = true;
        return;
        label_36:
        if(this.丌丂丗且丙专业丁业 == true)
        {
            goto label_273;
        }
        
        if(this.丞丐丕东丅丗丟丌丆 <= 0)
        {
                if((this.东丌专三丄丌丗且丏 <= UnityEngine.Time.realtimeSinceStartup) && (this.东丆不丄与丑丝世三 != true))
        {
                if(this.playerMovec.万万一与丝业七专下 == false)
        {
            goto label_73;
        }
        
        }
        
        }
        
        label_359:
        float val_124 = UnityEngine.Time.deltaTime;
        var val_123 = -4294967296;
        val_123 = val_123 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_17 = this.东专业丑与丐丆丐丟 + ((val_123 >> 32) * 88);
        val_107 = this.下丟丒丁下丄丕丂专;
        val_124 = this.下丟丒丁下丄丕丂专 + (double)val_124;
        float val_18 = UnityEngine.Time.deltaTime;
        float val_125 = 1.5f;
        val_125 = val_18 * val_125;
        val_18 = (val_124 < 0) ? (val_125) : (val_18);
        val_109 = val_107 + (double)val_18;
        label_80:
        if(0 >= this.东专业丑与丐丆丐丟.Length)
        {
            goto label_77;
        }
        
        var val_19 = this.东专业丑与丐丆丐丟 + (0 * 88);
        var val_20 = 0 + 1;
        if(((0 * 88) + this.东专业丑与丐丆丐丟 + 88) > this.下丟丒丁下丄丕丂专)
        {
            goto label_80;
        }
        
        label_77:
        if(0 == 0)
        {
                this.丌丂丗且丙专业丁业 = true;
        }
        
        double val_127 = this.下丟丒丁下丄丕丂专;
        val_110 = 0 - 1;
        val_111 = 0;
        if(0 < this.东专业丑与丐丆丐丟.Length)
        {
            goto label_85;
        }
        
        double val_126 = 0;
        val_126 = val_126 - val_127;
        if(val_126 <= 4)
        {
            goto label_85;
        }
        
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_89;
        }
        
        var val_21 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        if((((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 96) == 0)
        {
            goto label_92;
        }
        
        var val_22 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        PlatformController[] val_23 = PlatformsList.丄丘七三上丕世丞业.platforms + ((((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3);
        UnityEngine.Vector3 val_24 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48.position;
        goto label_100;
        label_85:
        var val_25 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_115 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 88];
        val_115 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 88;
        val_127 = val_109 - val_127;
        val_116 = val_115 - this.下丟丒丁下丄丕丂专;
        val_117 = val_127 / val_116;
        var val_26 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_118 = (float)val_117;
        if(((val_111 * 88) + this.东专业丑与丐丆丐丟 + 96) == 0)
        {
            goto label_105;
        }
        
        var val_27 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        PlatformController[] val_28 = PlatformsList.丄丘七三上丕世丞业.platforms + (((val_111 * 88) + this.东专业丑与丐丆丐丟 + 97) << 3);
        if(this.下三专不丘业丂丌丛 == (mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((val_111 * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48))
        {
            goto label_114;
        }
        
        this.下三专不丘业丂丌丛 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((val_111 * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48;
        UnityEngine.Vector3 val_30 = this.万东万丆专丌丕丐丗.position;
        val_117 = val_30.x;
        UnityEngine.Vector3 val_31 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((val_111 * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_117, y = val_30.y, z = val_30.z});
        val_122 = val_31.z;
        val_123 = val_92;
        mem[1152921535954117576] = val_122;
        val_116 = val_31.x;
        val_124 = val_31.y;
        val_125 = 1152921535954117576;
        val_110 = 1152921535954117576;
        mem[1152921535954117568] = val_116;
        mem[1152921535954117572] = val_124;
        goto label_117;
        label_44:
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
        label_52:
        var val_128 = -4294967296;
        val_128 = val_128 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_34 = this.东专业丑与丐丆丐丟 + ((val_128 >> 32) * 88);
        val_126 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4];
        val_126 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4;
        val_127 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_127 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 40;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32, y = val_126, z = val_127});
        val_131 = val_35.y;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_35.x, y = val_131, z = val_35.z};
        label_41:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_130;
        }
        
        var val_129 = -4294967296;
        val_129 = val_129 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_38 = this.东专业丑与丐丆丐丟 + ((val_129 >> 32) * 88);
        if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_130;
        }
        
        var val_130 = -4294967296;
        val_130 = val_130 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_40 = this.东专业丑与丐丆丐丟 + ((val_130 >> 32) * 88);
        val_131 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_131 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_126 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_126 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_131, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_126};
        goto label_141;
        label_130:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_141;
        }
        
        }
        
        var val_131 = -4294967296;
        val_131 = val_131 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_43 = this.东专业丑与丐丆丐丟 + ((val_131 >> 32) * 88);
        val_131 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_131 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_126 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_126 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_131, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_126};
        label_141:
        var val_132 = -4294967296;
        val_132 = val_132 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_111 = val_132 >> 32;
        var val_45 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_105 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_105 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_106 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68];
        val_106 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68;
        val_96 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        this.playerMovec.myTransform.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_106, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4};
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                var val_133 = -4294967296;
            val_133 = val_133 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_50 = this.东专业丑与丐丆丐丟 + ((val_133 >> 32) * 88);
            val_105 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100];
            val_105 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100;
            val_106 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108];
            val_106 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108;
            val_96 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100 + 4;
            this.playerMovec.mySkinName.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_106, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108 + 4};
        }
        
        var val_134 = -4294967296;
        val_134 = val_134 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_100 = val_134 >> 32;
        val_132 = this.东专业丑与丐丆丐丟 + (val_100 * 88);
        goto label_161;
        label_105:
        this.下三专不丘业丂丌丛 = 0;
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_172;
        }
        
        UnityEngine.Vector3 val_51 = this.万东万丆专丌丕丐丗.position;
        val_122 = val_51.z;
        var val_52 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 32];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 32;
        val_127 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_127 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 40;
        val_134 = val_133;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_122}, b:  new UnityEngine.Vector3() {x = val_134, y = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 32 + 4, z = val_127}, t:  val_118);
        val_116 = val_53.y;
        val_118 = val_53.x;
        val_115 = val_116;
        val_138 = val_53.z;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_118, y = val_115, z = val_138};
        goto label_172;
        label_114:
        val_125 = val_92;
        val_116 = this.丕丂丐世丌丗丙丙丅;
        val_110 = 1152921535954117568;
        val_123 = 1152921535954117568;
        val_124 = mem[1152921535954117572];
        val_122 = mem[1152921535954117576];
        label_117:
        var val_54 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 32];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 32;
        val_127 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_127 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 40;
        val_118 = val_116;
        val_115 = val_124;
        val_138 = val_122;
        val_134 = val_133;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_118, y = val_115, z = val_138}, b:  new UnityEngine.Vector3() {x = val_134, y = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 32 + 4, z = val_127}, t:  val_118);
        this.丕丂丐世丌丗丙丙丅 = val_55.x;
        mem[1152921535954117572] = val_55.y;
        mem[1152921535954117576] = val_55.z;
        label_172:
        val_139 = null;
        val_139 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                if(this.东丆不丄与丑丝世三 == false)
        {
            goto label_180;
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_186;
        }
        
        var val_57 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(((val_111 * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_186;
        }
        
        UnityEngine.Quaternion val_58 = this.万东万丆专丌丕丐丗.localRotation;
        val_127 = val_58.w;
        var val_59 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_101 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_101 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        UnityEngine.Quaternion val_60 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_58.x, y = val_58.y, z = val_58.z, w = val_127}, b:  new UnityEngine.Quaternion() {x = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_101, z = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_133}, t:  val_118);
        val_116 = val_60.y;
        val_122 = val_60.w;
        if(this.万东万丆专丌丕丐丗 != null)
        {
            goto label_282;
        }
        
        label_283:
        label_282:
        val_118 = val_60.x;
        val_115 = val_116;
        val_138 = val_60.z;
        val_134 = val_122;
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = val_118, y = val_115, z = val_138, w = val_134};
        goto label_295;
        label_186:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_295;
        }
        
        }
        
        UnityEngine.Quaternion val_62 = this.万东万丆专丌丕丐丗.rotation;
        val_127 = val_62.w;
        var val_63 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_101 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_101 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        UnityEngine.Quaternion val_64 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_62.x, y = val_62.y, z = val_62.z, w = val_127}, b:  new UnityEngine.Quaternion() {x = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_101, z = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_133}, t:  val_118);
        val_116 = val_64.y;
        val_122 = val_64.w;
        if(this.万东万丆专丌丕丐丗 != null)
        {
            goto label_298;
        }
        
        label_299:
        label_298:
        val_118 = val_64.x;
        val_115 = val_116;
        val_138 = val_64.z;
        val_134 = val_122;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_118, y = val_115, z = val_138, w = val_134};
        label_295:
        if(this.东丆不丄与丑丝世三 == false)
        {
            goto label_208;
        }
        
        if(this.skinName.playerAnimation == 0)
        {
            goto label_211;
        }
        
        UnityEngine.Quaternion val_67 = this.playerMovec.myTransform.localRotation;
        var val_68 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_105 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_105 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_101 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 60 + 4];
        val_101 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 68 + 4];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        UnityEngine.Quaternion val_69 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_67.x, y = val_67.y, z = val_67.z, w = val_67.w}, b:  new UnityEngine.Quaternion() {x = val_105, y = val_101, z = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68, w = val_133}, t:  val_118);
        val_106 = val_69.y;
        val_127 = val_69.w;
        val_141 = 1;
        val_96 = val_106;
        val_142 = val_69.z;
        val_143 = val_127;
        goto label_220;
        label_208:
        if(this.skinName.playerAnimation == 0)
        {
            goto label_223;
        }
        
        var val_71 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_105 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_105 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_106 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 68];
        val_106 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68;
        val_96 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_142 = val_106;
        val_143 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        val_141 = 0;
        label_220:
        this.skinName.playerAnimation.下丞且东三三丂丒下(丘丒丒丙丆不丝丂丂:  new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_142, w = val_143}, 丞丆业与丄丟丂三丈:  false);
        goto label_228;
        label_211:
        UnityEngine.Transform val_72 = this.playerMovec.myTransform;
        UnityEngine.Quaternion val_74 = this.playerMovec.myTransform.localRotation;
        val_127 = val_74.w;
        var val_75 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_101 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 60 + 4];
        val_101 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_133 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 68 + 4];
        val_133 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        UnityEngine.Quaternion val_76 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_74.x, y = val_74.y, z = val_74.z, w = val_127}, b:  new UnityEngine.Quaternion() {x = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 60, y = val_101, z = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 68, w = val_133}, t:  val_118);
        val_105 = val_76.x;
        val_106 = val_76.z;
        if(val_72 != null)
        {
            goto label_287;
        }
        
        label_288:
        label_287:
        val_96 = val_76.y;
        val_142 = val_106;
        val_143 = val_76.w;
        val_72.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_142, w = val_143};
        label_228:
        this.下丟丒丁下丄丕丂专 = val_109;
        var val_77 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        this.skinName.playerAnimation.丌七丗东三丏东丅丕(丙业与丙丗丝不丈东:  (val_111 * 88) + this.东专业丑与丐丆丐丟 + 76);
        var val_78 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        this.skinName.playerAnimation.一丙世丐且东与丁丘(丙业与丙丗丝不丈东:  (((val_111 * 88) + this.东专业丑与丐丆丐丟 + 116) != 0) ? 1 : 0);
        var val_80 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        var val_81 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        val_100 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 97];
        val_100 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 97;
        this.skinName.playerAnimation.丌万下世丟丅丁七丐(丂丛不丐丏丂丕丙丞:  (((val_111 * 88) + this.东专业丑与丐丆丐丟 + 96) != 0) ? 1 : 0, 丘丒丌下丕专且七专:  val_100);
        var val_83 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(((val_111 * 88) + this.东专业丑与丐丆丐丟 + 117) != 0)
        {
                var val_84 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
            mem2[0] = 0;
            this.skinName.playerAnimation.丌业丈丏东上丕丟世();
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_273;
        }
        
        UnityEngine.Quaternion val_90 = this.skinName.FPSplayerObject.transform.parent.localRotation;
        val_100 = this.东专业丑与丐丆丐丟;
        val_127 = val_90.w;
        var val_91 = val_100 + (val_111 * 88);
        val_101 = mem[(val_111 * 88) + this.东专业丑与丐丆丐丟 + 100 + 4];
        val_101 = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 100 + 4;
        UnityEngine.Quaternion val_92 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_90.x, y = val_90.y, z = val_90.z, w = val_127}, b:  new UnityEngine.Quaternion() {x = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 100, y = val_101, z = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 108, w = (val_111 * 88) + this.东专业丑与丐丆丐丟 + 108 + 4}, t:  val_118);
        val_105 = val_92.x;
        val_106 = val_92.z;
        val_96 = val_92.y;
        this.skinName.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_106, w = val_92.w};
        goto label_273;
        label_180:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_279;
        }
        
        var val_94 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(((val_111 * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_279;
        }
        
        var val_95 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(this.万东万丆专丌丕丐丗 != null)
        {
            goto label_282;
        }
        
        goto label_283;
        label_223:
        var val_97 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(this.playerMovec.myTransform != null)
        {
            goto label_287;
        }
        
        goto label_288;
        label_279:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_295;
        }
        
        }
        
        var val_99 = this.东专业丑与丐丆丐丟 + (val_111 * 88);
        if(this.万东万丆专丌丕丐丗 != null)
        {
            goto label_298;
        }
        
        goto label_299;
        label_92:
        UnityEngine.Vector3 val_100 = UnityEngine.Vector3.zero;
        label_100:
        var val_101 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        val_144 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4];
        val_144 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4;
        val_127 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_127 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 40;
        UnityEngine.Vector3 val_102 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_100.x, y = val_100.y, z = val_100.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 32, y = val_144, z = val_127});
        val_109 = val_102.y;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_102.x, y = val_109, z = val_102.z};
        label_89:
        val_100 = 1152921505066536960;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_312;
        }
        
        var val_104 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        if((((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_312;
        }
        
        var val_105 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        val_109 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_109 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_144 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_144 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_109, z = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_144};
        goto label_323;
        label_312:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_323;
        }
        
        }
        
        var val_107 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        val_109 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_109 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_144 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_144 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_109, z = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_144};
        label_323:
        val_111 = this.东专业丑与丐丆丐丟;
        var val_109 = val_111 + ((long)val_110 * 88);
        val_105 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_105 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_106 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 68];
        val_106 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 68;
        val_96 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        this.playerMovec.myTransform.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_106, w = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4};
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_100 = this.东专业丑与丐丆丐丟;
            var val_113 = val_100 + ((long)val_110 * 88);
            val_105 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 100];
            val_105 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 100;
            val_106 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 108];
            val_106 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 108;
            val_96 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 100 + 4;
            this.playerMovec.mySkinName.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_105, y = val_96, z = val_106, w = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 108 + 4};
        }
        
        val_132 = this.东专业丑与丐丆丐丟 + ((long)val_110 * 88);
        label_161:
        this.下丟丒丁下丄丕丂专 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 88;
        label_273:
        if(this.世丂丁丗下世丘丄业 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_114 = this.万东万丆专丌丕丐丗.position;
        if(val_114.y <= (-8000f))
        {
                return;
        }
        
        val_92 = this.万东万丆专丌丕丐丗;
        val_92.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_73:
        if((GameConnect.万不丒丌丙万丗东不() == false) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0))
        {
            goto label_358;
        }
        
        UnityEngine.Vector3 val_118 = transform.position;
        UnityEngine.Vector3 val_119 = this.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_120 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_118.x, y = val_118.y, z = val_118.z}, b:  new UnityEngine.Vector3() {x = val_119.x, y = val_119.y, z = val_119.z});
        if(val_120.x >= 0)
        {
            goto label_358;
        }
        
        goto label_359;
    }
    private void 专丘丐丐世专丆丗上(UnityEngine.Vector3 丑丏与上不丐丘丕丐, UnityEngine.Quaternion 丝丏丏东丘丐丝下不, UnityEngine.Quaternion 与三专东丝七世丄丆, double 丄丆万一丙丂丕不丐, int 丆丄七丙丅丈上丞一, bool 丈丙丟上丁丗丕丐七, bool 业七丄丌丏丁丑不下, byte 七丛丌丞丐丆丐专丛, UnityEngine.Vector3 丌丘丐丟丆且三丄丙, bool 丈不丁万且丐丂丐下, bool 不东一丏丟丕丆一一)
    {
        丝丙丒丌东下丕丘丘 val_6;
        丝丙丒丌东下丕丘丘 val_7;
        float val_13;
        丝丙丒丌东下丕丘丘 val_44;
        丝丙丒丌东下丕丘丘[] val_45;
        丝丙丒丌东下丕丘丘 val_47;
        丝丙丒丌东下丕丘丘 val_48;
        float val_49;
        float val_50;
        丝丙丒丌东下丕丘丘 val_51;
        float val_52;
        var val_56;
        val_44 = 丑丏与上不丐丘丕丐.z;
        val_45 = this.东专业丑与丐丆丐丟;
        if(this.东专业丑与丐丆丐丟 == null)
        {
                val_45 = this.东专业丑与丐丆丐丟;
        }
        
        int val_41 = this.东专业丑与丐丆丐丟.Length;
        var val_1 = (val_45 == null) ? 1 : 0;
        int val_2 = val_41 - 1;
        if(val_2 >= 1)
        {
                val_41 = val_41 - 2;
            var val_42 = (long)val_2;
            var val_3 = X11 + 32;
            int val_4 = val_41 + 32;
            do
        {
            val_2 = val_2 - 1;
            val_45 = this.东专业丑与丐丆丐丟;
            val_42 = val_42 - 1;
            val_3 = val_3 - 88;
            val_4 = val_4 - 88;
            var val_5 = (val_45 == null) ? 1 : 0;
        }
        while(val_2 > 0);
        
        }
        
        val_47 = 不东一丏丟丕丆一一;
        val_45[0] = 丑丏与上不丐丘丕丐.x;
        val_45[0] = 丑丏与上不丐丘丕丐.y;
        val_45[1] = val_44;
        val_48 = 七丛丌丞丐丆丐专丛;
        this.东专业丑与丐丆丐丟[1] = 丝丏丏东丘丐丝下不.x;
        this.东专业丑与丐丆丐丟[2] = 丝丏丏东丘丐丝下不.y;
        this.东专业丑与丐丆丐丟[2] = 丝丏丏东丘丐丝下不.z;
        this.东专业丑与丐丆丐丟[3] = 丝丏丏东丘丐丝下不.w;
        val_49 = 与三专东丝七世丄丆.y;
        val_50 = 与三专东丝七世丄丆.x;
        val_51 = val_7;
        this.东专业丑与丐丆丐丟[3] = val_50;
        this.东专业丑与丐丆丐丟[4] = val_51;
        this.东专业丑与丐丆丐丟[4] = val_49;
        this.东专业丑与丐丆丐丟[5] = val_6;
        val_52 = 与三专东丝七世丄丆.z;
        this.东专业丑与丐丆丐丟[7] = val_52;
        this.东专业丑与丐丆丐丟[5] = 丆丄七丙丅丈上丞一;
        bool val_8 = 丈丙丟上丁丗丕丐七;
        this.东专业丑与丐丆丐丟[6] = val_8;
        this.东专业丑与丐丆丐丟[8] = 业七丄丌丏丁丑不下;
        this.东专业丑与丐丆丐丟[8] = val_48;
        this.东专业丑与丐丆丐丟[10] = 丈不丁万且丐丂丐下;
        this.东专业丑与丐丆丐丟[10] = val_47;
        this.专丞世丒丞丞不丝东 = val_8;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 与三专东丝七世丄丆.w, y = val_13, z = 丄丆万一丙丂丕不丐});
            val_52 = val_14.x;
            val_49 = val_14.y;
            val_51 = val_14.z;
            val_50 = val_14.w;
            this.东专业丑与丐丆丐丟[8] = val_52;
            this.东专业丑与丐丆丐丟[9] = val_49;
            this.东专业丑与丐丆丐丟[9] = val_51;
            this.东专业丑与丐丆丐丟[10] = val_50;
        }
        
        if(this.丌丂丗且丙专业丁业 == false)
        {
                return;
        }
        
        if(this.一一丆丌专丑丏丕丗 != false)
        {
                val_56 = 1;
        }
        else
        {
                val_56 = this.东专业丑与丐丆丐丟.Length - 1;
        }
        
        val_47 = (long)val_56;
        var val_15 = this.东专业丑与丐丆丐丟 + (val_47 * 88);
        if((((long)(int)((this.东专业丑与丐丆丐丟.Length - 1)) * 88) + this.东专业丑与丐丆丐丟 + 88) <= this.下丟丒丁下丄丕丂专)
        {
                return;
        }
        
        this.丌丂丗且丙专业丁业 = false;
        if(this.一一丆丌专丑丏丕丗 == true)
        {
                return;
        }
        
        var val_43 = -4294967296;
        val_43 = val_43 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_17 = this.东专业丑与丐丆丐丟 + ((val_43 >> 32) * 88);
        this.下丟丒丁下丄丕丂专 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 88;
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 != true)
        {
                var val_44 = -4294967296;
            val_44 = val_44 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_19 = this.东专业丑与丐丆丐丟 + ((val_44 >> 32) * 88);
            if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 96) != 0)
        {
                var val_45 = -4294967296;
            val_45 = val_45 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_21 = this.东专业丑与丐丆丐丟 + ((val_45 >> 32) * 88);
            PlatformController[] val_22 = PlatformsList.丄丘七三上丕世丞业.platforms + (((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3);
            UnityEngine.Vector3 val_23 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48.position;
        }
        else
        {
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
        }
        
            var val_46 = -4294967296;
            val_46 = val_46 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            val_48 = val_46 >> 32;
            var val_25 = this.东专业丑与丐丆丐丟 + (val_48 * 88);
            val_50 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4];
            val_50 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4;
            val_44 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 40];
            val_44 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 40;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 32, y = val_50, z = val_44});
            val_49 = val_26.y;
            this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_26.x, y = val_49, z = val_26.z};
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_71;
        }
        
        var val_47 = -4294967296;
        val_47 = val_47 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_29 = this.东专业丑与丐丆丐丟 + ((val_47 >> 32) * 88);
        if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_71;
        }
        
        var val_48 = -4294967296;
        val_48 = val_48 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_48 = val_48 >> 32;
        var val_30 = this.东专业丑与丐丆丐丟 + (val_48 * 88);
        val_49 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_49 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_50 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_50 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_49, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_50};
        goto label_82;
        label_71:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_82;
        }
        
        }
        
        var val_49 = -4294967296;
        val_49 = val_49 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_48 = val_49 >> 32;
        var val_32 = this.东专业丑与丐丆丐丟 + (val_48 * 88);
        val_49 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_49 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_50 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_50 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_49, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_50};
        label_82:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                var val_50 = -4294967296;
            val_50 = val_50 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_37 = this.东专业丑与丐丆丐丟 + ((val_50 >> 32) * 88);
            val_49 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100 + 4];
            val_49 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100 + 4;
            val_50 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108 + 4];
            val_50 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108 + 4;
            this.playerMovec.mySkinName.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 100, y = val_49, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 108, w = val_50};
        }
        
        val_47 = this.东专业丑与丐丆丐丟;
        var val_51 = -4294967296;
        val_51 = val_51 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_40 = val_47 + ((val_51 >> 32) * 88);
        val_52 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_52 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_51 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68];
        val_51 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68;
        this.playerMovec.myTransform.rotation = new UnityEngine.Quaternion() {x = val_52, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4, z = val_51, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4};
        this.一一丆丌专丑丏丕丗 = true;
    }

}
