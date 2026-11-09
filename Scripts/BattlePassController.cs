using UnityEngine;
public sealed class BattlePassController : Singleton<BattlePassController>
{
    // Fields
    private static System.Action 丘丛丛丞上世一且丁;
    private static System.Action 七下七七丏七丗丞丛;
    internal static readonly string 世丞丝不丂丕且且丆;
    private static readonly string 丏丈东上丛东丝丐七;
    internal static readonly string 丈丛丙七丂丙东与一;
    private const int 丗丈丄三上丂与丞丞 = 9;
    private PGCompany.BattlePass.上丕丁专三丗丝万丆 丘丞世丒世七丆且东;
    private PGCompany.BattlePass.上丕丁专三丗丝万丆 丌丂丑世丆丏万丌上;
    private PGCompany.BattlePass.BPDataContainer 丏丐与丞丑丁丑万世;
    private Rilisoft.丅丟丒丟丑丈丒三丆 七与丏丟丌丘丒丗下;
    private Rilisoft.且丈丞一丞丟与上七 丌丒丝万三丛不丁丟;
    private System.Collections.Generic.List<string> 丟业丆丐一东丞丞丂;
    private System.Collections.Generic.Dictionary<string, bool> 丁丛专七丈丝七下丌;
    private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> 下丁不丐丈丌丟丂丝;
    private UnityEngine.WaitForSeconds 万丄丒丐东丂丁七丙;
    
    // Properties
    private static int 丑丆丘与丌丗丑三三 { get; }
    internal PGCompany.BattlePass.上丕丁专三丗丝万丆 上丕丁专三丗丝万丆 { get; }
    internal bool 丑一业丗上不丟一丏 { get; }
    private static bool 丂丘丈丏业丝丏丝丅 { get; }
    
    // Methods
    internal static void 万且丟丘丐丑丏且专(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  BattlePassController.丗丈丄三上丂与丞丞, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 下丟丐丙丌世丆丌丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  BattlePassController.丗丈丄三上丂与丞丞, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丙七一丄下专丏不丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BattlePassController.七下七七丏七丗丞丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BattlePassController.七下七七丏七丗丞丛 != 1152921505136402440);
    
    }
    internal static void 业丏专与丝不东丁一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BattlePassController.七下七七丏七丗丞丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BattlePassController.七下七七丏七丗丞丛 != 1152921505136402440);
    
    }
    private void 丈丁下与丞丆丝与丝()
    {
        var val_4;
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂();
        val_4 = null;
        val_4 = null;
        if((BattlePassController.<>c.<>9__15_0) == null)
        {
            goto label_6;
        }
        
        label_11:
        val_2.ForEach(action:  BattlePassController.<>c.<>9__15_0);
        this.丌丂丑世丆丏万丌上 = 0;
        this.丏丐与丞丑丁丑万世 = 0;
        this.丘丞世丒世七丆且东 = 0;
        this.UpdateConfigManagement();
        return;
        label_6:
        BattlePassController.<>c.<>9__15_0 = new System.Action<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  BattlePassController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BattlePassController.<>c::丕丒三业三与丝下万(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        if(val_2 != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    private static int 丂且一丄丒丈下不丄()
    {
        return 900;
    }
    internal PGCompany.BattlePass.上丕丁专三丗丝万丆 丛东丛丕东丟丂丈丝()
    {
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3;
        if(this.丌丂丑世丆丏万丌上 != null)
        {
                if(this.丌丂丑世丆丏万丌上.丌丈一丘上丕丏东丛() == false)
        {
            goto label_1;
        }
        
        }
        
        val_3 = this.丘丞世丒世七丆且东;
        if(val_3 == null)
        {
                return val_3;
        }
        
        val_3 = 0;
        if(val_3.丑丙丆东丁丌一一下() == false)
        {
                return val_3;
        }
        
        val_3 = this.丘丞世丒世七丆且东;
        return val_3;
        label_1:
        val_3 = this.丌丂丑世丆丏万丌上;
        return val_3;
    }
    internal bool 专丁丟丏丁丏不丗三()
    {
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_1 = this.丛东丛丕东丟丂丈丝();
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return val_1.专丁丟丏丁丏不丗三();
    }
    private static bool 丝丈不丙丂丙丝丂丄()
    {
        return false;
    }
    private void OnInstanceCreated()
    {
        this.UpdateConfigManagement();
    }
    public void UpdateConfigManagement()
    {
        this.丟丛专丛不七万一万(上世丏丁世丟世丆业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  3));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void BattlePassController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void BattlePassController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
    }
    private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 3)
        {
                return;
        }
        
        this.丟丛专丛不七万一万(上世丏丁世丟世丆业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  3));
    }
    private void 丟丛专丛不七万一万(string 上世丏丁世丟世丆业)
    {
        if(上世丏丁世丟世丆业 == null)
        {
                return;
        }
        
        this.丟业丆丐一东丞丞丂.Add(item:  上世丏丁世丟世丆业);
    }
    internal UnityEngine.GameObject 丟丒且丙丝三世三丝(string 业丑丐丞丅丌丈丐丆)
    {
        System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject> val_5;
        var val_6;
        val_5 = this.下丁不丐丈丌丟丂丝;
        if((val_5.ContainsKey(key:  业丑丐丞丅丌丈丐丆)) != true)
        {
                this.下丁不丐丈丌丟丂丝.set_Item(key:  业丑丐丞丅丌丈丐丆, value:  0);
            val_6 = null;
            val_6 = null;
            val_5 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  BattlePassController.丏丈东上丛东丝丐七);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != true)
        {
                val_5 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_5);
            this.下丁不丐丈丌丟丂丝.set_Item(key:  业丑丐丞丅丌丈丐丆, value:  val_5);
        }
        
        }
        
        if(this.下丁不丐丈丌丟丂丝 != null)
        {
                return this.下丁不丐丈丌丟丂丝.Item[业丑丐丞丅丌丈丐丆];
        }
        
        return this.下丁不丐丈丌丟丂丝.Item[业丑丐丞丅丌丈丐丆];
    }
    private System.Collections.IEnumerator 专三世业与丁且丒丗(PGCompany.BattlePass.上丕丁专三丗丝万丆 丅丑丈丂三业丆三万)
    {
        BattlePassController.业万丌丏丙丘丗七丁 val_1 = new BattlePassController.业万丌丏丙丘丗七丁();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丅丑丈丂三业丆三万 = 丅丑丈丂三业丆三万;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 七丞丝丈三丛世上丏(string 丅业丙丞且丐一丙丆)
    {
        object val_9;
        var val_11;
        var val_12;
        val_9 = this;
        if((BattlePassController.丐丕世丄业丝丑丌一(丛七丅东丒丅丘不业:  丅业丙丞且丐一丙丆)) != null)
        {
                val_1.bpDataContainers.ForEach(action:  new System.Action<PGCompany.BattlePass.BPDataContainer>(object:  this, method:  System.Void BattlePassController::丐丒丂丄丕七且丆东(PGCompany.BattlePass.BPDataContainer 三丟东丕丄丄下下丑)));
            return;
        }
        
        val_11 = mem[???];
        val_11 = ???;
        if((((val_11 + 295) & 2) != 0) && ((val_11 + 216) == 0))
        {
                val_11 = mem[???];
            val_11 = ???;
        }
        
        val_12 = mem[val_11 + 184];
        val_12 = val_11 + 184;
        if(val_12 == 0)
        {
                return;
        }
        
        if((((val_11 + 295) & 2) != 0) && ((val_11 + 216) == 0))
        {
                val_12 = mem[??? + 184];
            val_12 = ??? + 184;
            if(val_12 == 0)
        {
                val_12 = 0;
        }
        
        }
        
        val_12.Invoke();
    }
    private void 七丞丝丈三丛世上丏(PGCompany.BattlePass.BPDataContainer 丒上专丐丈丅世下丐)
    {
        var val_39;
        Rilisoft.丅丟丒丟丑丈丒三丆 val_40;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        int val_47;
        val_39 = this;
        if(this.丌丒丝万三丛不丁丟.世三丞丅丑丌丈丈一() < 丒上专丐丈丅世下丐.mainData.Id)
        {
                this.丌丒丝万三丛不丁丟.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丒上专丐丈丅世下丐.mainData.Id);
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.上丕丁专三丗丝万丆(丞丙丕不丕丆丁下万:  false, 丆且丁丒丒丆丁三丆:  "Levels Earned", 丙业与丙丗丝不丈东:  "level_earned_1");
        }
        
        }
        
        if(this.丘丞世丒世七丆且东 == null)
        {
            goto label_37;
        }
        
        val_40 = this.丘丞世丒世七丆且东.万上丁一丞业业万东();
        if(val_40 > 丒上专丐丈丅世下丐.mainData.Id)
        {
                return;
        }
        
        if(this.丘丞世丒世七丆且东 == null)
        {
            goto label_37;
        }
        
        if(this.丘丞世丒世七丆且东.万上丁一丞业业万东() != 丒上专丐丈丅世下丐.mainData.Id)
        {
            goto label_17;
        }
        
        this.丘丞世丒世七丆且东.丑七丂丌世与七丏与(一丐丗丁丞丆丅丟丄:  丒上专丐丈丅世下丐.mainData);
        goto label_19;
        label_17:
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                if(this.丌丂丑世丆丏万丌上 != null)
        {
                if(this.丌丂丑世丆丏万丌上.丌丈一丘上丕丏东丛() == false)
        {
            goto label_37;
        }
        
        }
        
            this.七与丏丟丌丘丒丗下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.丏丐与丞丑丁丑万世));
            this.丌丂丑世丆丏万丌上 = this.丘丞世丒世七丆且东;
            if(this.丘丞世丒世七丆且东.与丁丂三下丛丘丁丅() != false)
        {
                this.丌丂丑世丆丏万丌上.丗丘丒丅丄不丕不丏();
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != true)
        {
                PGCompany.BattlePass.BPTutorialController.SkipTutorial();
        }
        
        }
        
            if(this.丌丂丑世丆丏万丌上.丌丈一丘上丕丏东丛() != false)
        {
                this.七与丏丟丌丘丒丗下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
            this.丌丂丑世丆丏万丌上 = 0;
        }
        
        }
        
        label_37:
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_11 = new PGCompany.BattlePass.上丕丁专三丗丝万丆(一丐丗丁丞丆丅丟丄:  丒上专丐丈丅世下丐.mainData);
        this.丘丞世丒世七丆且东 = val_11;
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.专三世业与丁且丒丗(丅丑丈丂三业丆三万:  val_11));
        label_19:
        val_41 = 丒上专丐丈丅世下丐.challengesData;
        BPChallengesController.丑七不且上丗丁一世().不一丘丅且丆不七上(世不下丟世一丝丐丗:  丒上专丐丈丅世下丐.mainData.Id, 丂东丞丕丛丘且业丝:  val_41);
        if((((丒上专丐丈丅世下丐.mainData.Id == 18) && (this.丘丞世丒世七丆且东 != null)) && (this.丘丞世丒世七丆且东.万上丁一丞业业万东() == 18)) && (this.丘丞世丒世七丆且东.丗丄上丑丑丅丐丒丌() != false))
        {
                System.Nullable<System.DateTime> val_17 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) != 0)
        {
                System.TimeSpan val_18 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 丒上专丐丈丅世下丐.mainData.EndDate}, d2:  new System.DateTime() {});
            if(val_18._ticks.TotalSeconds > 0f)
        {
                this.丘丞世丒世七丆且东.七丞丈不丛七丟丑丙();
        }
        
        }
        
        }
        
        val_40 = this.七与丏丟丌丘丒丗下;
        this.丏丐与丞丑丁丑万世 = 丒上专丐丈丅世下丐;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_40.世三丞丅丑丌丈丈一())) != false)
        {
                val_40 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.丏丐与丞丑丁丑万世);
            this.七与丏丟丌丘丒丗下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_40);
        }
        
        this.丌丗丛丙专业丞丐下();
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
        {
                val_42 = null;
            val_42 = null;
            val_41 = 1152921504848912384;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_76;
        }
        
        }
        
            if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
                label_76:
            if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() != true)
        {
                val_43 = null;
            val_43 = null;
            bool val_31 = ShopNGUIController.丛世丛与丌不丈丐丐();
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  val_31, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
            val_40 = WeaponManager.丟丗丄业丘丗业丗七;
            val_40.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万());
            if(val_31 != false)
        {
                val_44 = null;
            val_44 = null;
            if(ShopNGUIController.丛丐丛专丟丞万三七() != WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐())
        {
                val_45 = null;
            val_45 = null;
            WeaponManager.丟丗丄业丘丗业丗七.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
        {
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_39 = 1152921505136398336;
        val_46 = null;
        val_46 = null;
        val_47 = BattlePassController.丗丈丄三上丂与丞丞;
        if(val_47 == 0)
        {
                return;
        }
        
        val_47 = BattlePassController.丗丈丄三上丂与丞丞;
        if(val_47 == 0)
        {
                val_47 = 0;
        }
        
        val_47.Invoke();
    }
    private void 丌丗丛丙专业丞丐下()
    {
        var val_10;
        int val_11;
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
        {
                return;
        }
        
        if(this.丌丂丑世丆丏万丌上 != null)
        {
                return;
        }
        
        if(((BattlePassController.丐丕世丄业丝丑丌一(丛七丅东丒丅丘不业:  this.七与丏丟丌丘丒丗下.世三丞丅丑丌丈丈一())) != null) && (val_3.bpDataContainers.Count != 0))
        {
                PGCompany.BattlePass.BPDataContainer val_5 = val_3.bpDataContainers.Item[0];
            if(val_5.mainData.Id == this.丘丞世丒世七丆且东.万上丁一丞业业万东())
        {
                return;
        }
        
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_7 = new PGCompany.BattlePass.上丕丁专三丗丝万丆(一丐丗丁丞丆丅丟丄:  val_5.mainData);
            this.丌丂丑世丆丏万丌上 = val_7;
            if(val_7.与丁丂三下丛丘丁丅() != false)
        {
                this.丌丂丑世丆丏万丌上.丗丘丒丅丄不丕不丏();
        }
        
            BPChallengesController.丑七不且上丗丁一世().不一丘丅且丆不七上(世不下丟世一丝丐丗:  val_5.mainData.Id, 丂东丞丕丛丘且业丝:  val_5.challengesData);
            return;
        }
        
        this.七与丏丟丌丘丒丗下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
        val_10 = null;
        val_10 = null;
        val_11 = BattlePassController.丗丈丄三上丂与丞丞;
        if(val_11 == 0)
        {
                return;
        }
        
        val_11 = BattlePassController.丗丈丄三上丂与丞丞;
        if(val_11 == 0)
        {
                val_11 = 0;
        }
        
        val_11.Invoke();
    }
    internal void 万丈丐万丂丐丛东东(PGCompany.BattlePass.上丕丁专三丗丝万丆 丅丑丈丂三业丆三万)
    {
        var val_3;
        var val_4;
        System.Action val_5;
        val_3 = this;
        if(丅丑丈丂三业丆三万 == null)
        {
                return;
        }
        
        if(this.丌丂丑世丆丏万丌上 != null)
        {
                if(丅丑丈丂三业丆三万.万上丁一丞业业万东() == this.丌丂丑世丆丏万丌上.万上丁一丞业业万东())
        {
                this.丌丂丑世丆丏万丌上 = 0;
            this.七与丏丟丌丘丒丗下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
        }
        
        }
        
        val_3 = 1152921505136398336;
        val_4 = null;
        val_4 = null;
        val_5 = BattlePassController.七下七七丏七丗丞丛;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = BattlePassController.七下七七丏七丗丞丛;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke();
    }
    internal static PGCompany.BattlePass.BPDataContainerList 丐丕世丄业丝丑丌一(string 丛七丅东丒丅丘不业)
    {
        var val_22;
        int val_24;
        PGCompany.BattlePass.BPDataContainer val_27;
        var val_28;
        var val_29;
        val_22 = 0;
        if((System.String.IsNullOrEmpty(value:  丛七丅东丒丅丘不业)) == true)
        {
                return (PGCompany.BattlePass.BPDataContainerList)val_22;
        }
        
        PGCompany.BattlePass.BPDataContainerList val_2 = null;
        val_22 = val_2;
        val_2 = new PGCompany.BattlePass.BPDataContainerList();
        if((丛七丅东丒丅丘不业.Chars[0] & 65535) != '[')
        {
            goto label_3;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        .bpDataContainers = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        goto label_12;
        label_3:
        if(val_22 == null)
        {
            goto label_19;
        }
        
        val_24 = 1;
        label_12:
        if((PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.Count != 0)
        {
            goto label_56;
        }
        
        goto label_22;
        label_19:
        val_24 = 0;
        label_22:
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_27 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        (PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.Add(item:  val_27);
        label_56:
        if(val_24 == 0)
        {
                return (PGCompany.BattlePass.BPDataContainerList)val_22;
        }
        
        val_28 = 0;
        goto label_33;
        label_48:
        val_29 = 0;
        goto label_34;
        label_45:
        PGCompany.BattlePass.BPDataContainer val_11 = (PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.SyncRoot.Item[0];
        PGCompany.BattlePass.BPChallangeDO val_12 = val_11.challengesData.Item[0];
        PGCompany.BattlePass.BPDataContainer val_13 = (PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.SyncRoot.Item[0];
        val_24 = val_13.mainData.Id;
        val_29 = 1;
        val_12.BattlePassSeasonId = val_24;
        label_34:
        PGCompany.BattlePass.BPDataContainer val_14 = (PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.SyncRoot.Item[0];
        if(val_29 < val_14.challengesData.Count)
        {
            goto label_45;
        }
        
        val_28 = 1;
        label_33:
        val_27 = mem[(PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers];
        val_27 = (PGCompany.BattlePass.BPDataContainerList)[1152921536367871920].bpDataContainers.SyncRoot;
        if(val_28 < val_27.Count)
        {
            goto label_48;
        }
        
        return (PGCompany.BattlePass.BPDataContainerList)val_22;
    }
    internal static bool 丐丕世丄业丝丑丌一(string 丛七丅东丒丅丘不业, out PGCompany.BattlePass.BPData 丏丞丝业且专万丙丌, out System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> 丅一丂专丌万丐三世, out int 丗丙上业下丆业下丝)
    {
        PGCompany.BattlePass.BPDataContainer val_6;
        BattlePassController.与丙丌丟一七下丏与 val_1 = new BattlePassController.与丙丌丟一七下丏与();
        丏丞丝业且专万丙丌 = 0;
        丅一丂专丌万丐三世 = 0;
        丗丙上业下丆业下丝 = 0;
        .丒上专丐丈丅世下丐 = 0;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_6 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_1 == null)
        {
            goto label_9;
        }
        
        .丒上专丐丈丅世下丐 = val_6;
        if(val_6 != null)
        {
            goto label_12;
        }
        
        goto label_11;
        label_9:
        .丒上专丐丈丅世下丐 = val_6;
        val_6 = (BattlePassController.与丙丌丟一七下丏与)[1152921536368113584].丒上专丐丈丅世下丐;
        if(val_6 != null)
        {
            goto label_12;
        }
        
        label_11:
        label_12:
        System.Action<PGCompany.BattlePass.BPChallangeDO> val_4 = new System.Action<PGCompany.BattlePass.BPChallangeDO>(object:  val_1, method:  System.Void BattlePassController.与丙丌丟一七下丏与::丘业丈且三丞一丙万(PGCompany.BattlePass.BPChallangeDO 三丟东丕丄丄下下丑));
        (BattlePassController.与丙丌丟一七下丏与)[1152921536368113584].丒上专丐丈丅世下丐.challengesData.ForEach(action:  null);
        丏丞丝业且专万丙丌 = (BattlePassController.与丙丌丟一七下丏与)[1152921536368113584].丒上专丐丈丅世下丐.mainData;
        丅一丂专丌万丐三世 = (BattlePassController.与丙丌丟一七下丏与)[1152921536368113584].丒上专丐丈丅世下丐.challengesData;
        return true;
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
    }
    private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BattlePassController.丄且丏丗丁丈丗世丅();
    }
    internal void 丞七丆丐丏丝丗七丁()
    {
    
    }
    public BattlePassController()
    {
        this.七与丏丟丌丘丒丗下 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  "_bpPreviousSeasonData");
        this.丌丒丝万三丛不丁丟 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "_bpLastKnownSeason");
        this.丟业丆丐一东丞丞丂 = new System.Collections.Generic.List<System.String>();
        this.丁丛专七丈丝七下丌 = new System.Collections.Generic.Dictionary<System.String, System.Boolean>();
        this.下丁不丐丈丌丟丂丝 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
    }
    private static BattlePassController()
    {
        BattlePassController.世丞丝不丂丕且且丆 = "BattlePassController.ConfigStoragerKey";
        BattlePassController.丏丈东上丛东丝丐七 = "BPMainUI";
        BattlePassController.丈丛丙七丂丙东与一 = "BPWelcomeScreenUI";
    }
    private void 丐丒丂丄丕七且丆东(PGCompany.BattlePass.BPDataContainer 三丟东丕丄丄下下丑)
    {
        this.七丞丝丈三丛世上丏(丒上专丐丈丅世下丐:  三丟东丕丄丄下下丑);
    }

}
