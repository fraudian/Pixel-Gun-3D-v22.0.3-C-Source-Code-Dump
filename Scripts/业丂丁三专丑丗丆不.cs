using UnityEngine;
private sealed class Player_move_c.业丂丁三专丑丗丆不 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.业丂丁三专丑丗丆不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_85;
        Player_move_c.业丂丁三专丑丗丆不 val_327;
        int val_328;
        var val_329;
        var val_330;
        FirstPersonControlSharp val_331;
        System.Collections.Generic.List<Player_move_c> val_332;
        float val_333;
        float val_334;
        float val_335;
        var val_336;
        var val_337;
        var val_339;
        float val_340;
        float val_343;
        float val_344;
        float val_345;
        int val_346;
        var val_347;
        var val_348;
        var val_349;
        var val_350;
        var val_351;
        var val_352;
        var val_354;
        var val_355;
        var val_357;
        var val_358;
        var val_359;
        var val_360;
        var val_361;
        var val_362;
        var val_363;
        var val_364;
        var val_365;
        float val_366;
        var val_367;
        var val_368;
        var val_369;
        var val_370;
        var val_371;
        var val_372;
        val_327 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_328 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_328;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        string val_3 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}.StartSteps()", arg0:  this.丝且与丝丒丟万丁专.GetType());
        val_329 = 1152921505066536960;
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_17;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.mySkinName.丛丞七丏丑业丂丕丟 == 0)
        {
            goto label_17;
        }
        
        if(this.丝且与丝丒丟万丁专.mySkinName.丛丞七丏丑业丂丕丟 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_26:
        this.丝且与丝丒丟万丁专.mySkinName.丛丞七丏丑业丂丕丟.playerRenderers[0].sharedMaterial = this.丝且与丝丒丟万丁专.三丗专丒丌丂丈丌上[0];
        label_20:
        if(1 < this.丝且与丝丒丟万丁专.mySkinName.丛丞七丏丑业丂丕丟.playerRenderers.Length)
        {
            goto label_26;
        }
        
        label_17:
        if((GameConnect.东且三丆丑世世丘丟() == false) || (this.丝且与丝丒丟万丁专.mechBearBodyRenderer == 0))
        {
            goto label_33;
        }
        
        UnityEngine.Material[] val_10 = new UnityEngine.Material[1];
        val_10[0] = new UnityEngine.Material(source:  this.丝且与丝丒丟万丁专.mechBearBodyRenderer.material);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_40;
        }
        
        this.丝且与丝丒丟万丁专.丞丑与不丟东丙七丆 = val_10;
        UnityEngine.SkinnedMeshRenderer val_14 = this.丝且与丝丒丟万丁专.mechBearBodyRenderer;
        goto label_41;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.世丝丞丂丐三丒丒丘() != false)
        {
                PotionsController.丄丞丁丈与业上丞丟.不东丂丈丝丆丌丄丛(丘丒且与丁丑丐上与:  this.丝且与丝丒丟万丁专, 丗丅七业丝不三丄三:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
            string val_17 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
            if((System.String.op_Inequality(a:  val_17, b:  System.String.alignConst)) != false)
        {
                if((七丌丞万七万丁丐丙.不丑丕丞丛丆丝下业().ContainsKey(key:  val_17)) != false)
        {
                System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_22 = 七丌丞万七万丁丐丙.不丑丕丞丛丆丝下业().Item[val_17];
            System.Collections.Generic.Dictionary<System.String, System.Object> val_24 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_22.Value.丐丏七丌丕丗业且上().Invoke(arg1:  this.丝且与丝丒丟万丁专, arg2:  null);
        }
        
        }
        
            string val_25 = 七丌丞万七万丁丐丙.一万丌东丄世上丕丟();
            val_330 = 1152921505171275776;
            if((val_25.Equals(value:  与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业())) != true)
        {
                if((七丌丞万七万丁丐丙.丗丈丟上世万丞世丒().ContainsKey(key:  val_25)) != false)
        {
                System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_31 = 七丌丞万七万丁丐丙.丗丈丟上世万丞世丒().Item[val_25];
            val_31.Value.丐丏七丌丕丗业且上().Invoke(arg1:  this.丝且与丝丒丟万丁专, arg2:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        
        }
        
            string val_34 = 七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐();
            if((val_34.Equals(value:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟())) != true)
        {
                if((七丌丞万七万丁丐丙.丌丌世丐世上丏丟与().ContainsKey(key:  val_34)) != false)
        {
                System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_40 = 七丌丞万七万丁丐丙.丌丌世丐世上丏丟与().Item[val_34];
            val_40.Value.丐丏七丌丕丗业且上().Invoke(arg1:  this.丝且与丝丒丟万丁专, arg2:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        
        }
        
            if(JoystickController.丗三丄与丂丟丌专东 != 0)
        {
                JoystickController.丗三丄与丂丟丌专东.SetJoystickActive(丈下上丅与丒丁丆下:  true);
        }
        
            if(JoystickController.丘万丏三丏丑世丐丏 != 0)
        {
                JoystickController.丘万丏三丏丑世丐丏.MakeActive();
        }
        
            if(JoystickController.世万丁丆业业丘丘丌 != 0)
        {
                JoystickController.世万丁丆业业丘丘丌.SetJoystickActive(丛丅丘一丏丙且丌上:  true);
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false) || (this.丝且与丝丒丟万丁专.业丐上东丅丞丛万上 == 0))
        {
            goto label_112;
        }
        
        this.丝且与丝丒丟万丁专.丑丄丅丟丙丛丒丑丅 = this.丝且与丝丒丟万丁专.丟三丏丅世一丟丟上.丌丏丞丆丗与东丗业;
        if(this.丝且与丝丒丟万丁专.丟三丏丅世一丟丟上.丌丏丞丆丗与东丗业 == 0)
        {
            goto label_117;
        }
        
        this.丝且与丝丒丟万丁专.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  0);
        goto label_117;
        label_112:
        this.丝且与丝丒丟万丁专.丙丘丙不丟东且丌丏();
        label_117:
        val_331 = 1152921525487174064;
        goto label_118;
        label_126:
        丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].万业丐丞业丝世东丕();
        label_118:
        val_332 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(1 < val_332.Count)
        {
            goto label_126;
        }
        
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                val_332 = 1152921505217175552;
            if(((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  200)) != false) && (东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200] != null))
        {
                if(东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200].丄不与丁丗东专且丈() != false)
        {
                东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200].丒世丞丂专东东业与();
        }
        
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false) && (Player_move_c.丒与丒不丏丆七且丁 != null))
        {
                0.Invoke();
        }
        
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true)
        {
                val_332 = 1152921505219145728;
            if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.丙丁不东不丅三丛世 != 0)
        {
                万丘三世丛丅与一丗(专丞上七七且丝七丗:  this.丝且与丝丒丟万丁专);
        }
        
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.一丝丌丏万丐丌丆东() != false)
        {
                this.丝且与丝丒丟万丁专.业丌东七七丒世丞万.下丂专且万七丐丁三(专丞上七七且丝七丗:  this.丝且与丝丒丟万丁专);
        }
        
        if((this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == true) || (this.丝且与丝丒丟万丁专.一丝丌丏万丐丌丆东() == true))
        {
            goto label_180;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_180;
        }
        
        }
        
        UnityEngine.Object val_69 = UnityEngine.Resources.Load(path:  "TeamMateHealthbar");
        UnityEngine.Vector3 val_70 = UnityEngine.Vector3.zero;
        val_333 = val_70.x;
        val_334 = val_70.z;
        UnityEngine.Quaternion val_71 = UnityEngine.Quaternion.identity;
        val_335 = val_71.y;
        if(val_69 == null)
        {
            goto label_187;
        }
        
        var val_72 = (null == null) ? (val_69) : 0;
        goto label_188;
        label_40:
        label_41:
        0.mechBearBodyRenderer.sharedMaterials = static_value_00000458;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                UnityEngine.SkinnedMeshRenderer val_74 = this.丝且与丝丒丟万丁专.mechBearHandRenderer;
        }
        
        0.mechBearHandRenderer.sharedMaterials = static_value_00000458;
        label_33:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.cursedMark, 丏业丟一东丂东丘丛:  false);
        this.丝且与丝丒丟万丁专.丂与业丈东丝丒丑丗();
        this.丝且与丝丒丟万丁专.丟丝丝七丑丝丄东丛 = ExpController.万上一丝丆且七丅丅() + 1;
        this.丝且与丝丒丟万丁专.一与丞与丈专丌丄与.Clear();
        this.丝且与丝丒丟万丁专.下丏万丏上上丄丅丟.Clear();
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                this.丝且与丝丒丟万丁专.东丌丟丄丒丙丗丙专(丙业与丙丗丝不丈东:  false);
            this.丝且与丝丒丟万丁专.丘与丒丆丛丂专丌万 = 0f;
        }
        
        val_336 = 1152921505286238208;
        val_330 = 1152921504848912384;
        if((WeaponManager.丟丗丄业丘丗业丗七 == 0) || (WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与() == null))
        {
            goto label_323;
        }
        
        List.Enumerator<T> val_83 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
        label_232:
        if((1184820944 & 1) == 0)
        {
            goto label_215;
        }
        
        string val_86 = val_85.丐丏七丌丕丗业且上();
        if(val_86.七丝丈东丈丕丐与丗() == false)
        {
            goto label_232;
        }
        
        object[] val_88 = new object[3];
        val_88[0] = 1.业上丙丞丐丄丆丅七();
        val_85 = val_86.下世万丆丛专丒丑丙();
        val_88[1] = val_85;
        val_88[2] = 3;
        this.丝且与丝丒丟万丁专.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  154, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_88);
        goto label_232;
        label_187:
        label_188:
        val_332 = this.丝且与丝丒丟万丁专.myPlayerTransform;
        UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, position:  new UnityEngine.Vector3() {x = val_333, y = val_70.y, z = val_334}, rotation:  new UnityEngine.Quaternion() {x = val_71.x, y = val_335, z = val_71.z, w = val_71.w}).transform.SetParent(parent:  val_332, worldPositionStays:  false);
        label_180:
        if((this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false) && (this.丝且与丝丒丟万丁专.一丝丌丏万丐丌丆东() != true))
        {
                UnityEngine.SceneManagement.Scene val_95 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((val_95.m_Handle.name.Equals(value:  "Christmas_Town_Night2")) != false)
        {
                UnityEngine.Object val_98 = UnityEngine.Resources.Load(path:  "AroundPlayerSnow");
            UnityEngine.Vector3 val_99 = UnityEngine.Vector3.zero;
            val_333 = val_99.x;
            val_334 = val_99.z;
            UnityEngine.Quaternion val_100 = UnityEngine.Quaternion.identity;
            val_335 = val_100.y;
            if(val_98 != null)
        {
                var val_101 = (null == null) ? (val_98) : 0;
        }
        
            val_332 = this.丝且与丝丒丟万丁专.myPlayerTransform;
            UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, position:  new UnityEngine.Vector3() {x = val_333, y = val_99.y, z = val_334}, rotation:  new UnityEngine.Quaternion() {x = val_100.x, y = val_335, z = val_100.z, w = val_100.w}).transform.SetParent(parent:  val_332, worldPositionStays:  false);
        }
        
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_263;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true)
        {
                this.丝且与丝丒丟万丁专.一与丌丌丆一丙丈丞();
        }
        
        }
        
        label_263:
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true))
        {
                val_332 = 1152921505286238208;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                this.丝且与丝丒丟万丁专.东世丌丄世业丞丛丐(丛丅丘一丏丙且丌上:  true);
        }
        
        }
        
        val_328 = 0;
        return (bool)val_328;
        label_215:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_329 = val_329;
        val_327 = val_327;
        val_330 = 1152921504848912384;
        val_336 = 1152921505286238208;
        label_323:
        bool val_111 = GameConnect.东且三丆丑世世丘丟();
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丄且丈业上丕七丂丛 = val_111;
        }
        else
        {
                bool val_113 = val_111;
        }
        
        this.丝且与丝丒丟万丁专.丏丕一丞丘丗万丒丏.且七丙丄丘一丄上不();
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专, 专丐丛丆与专世丆丂:  0);
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC = this.丝且与丝丒丟万丁专;
            WeaponManager.丟丗丄业丘丗业丗七.myPlayer = this.丝且与丝丒丟万丁专.mySkinName.gameObject;
        }
        
        if(GameConnect.丘丐丅丌上与丒丞万() == false)
        {
            goto label_341;
        }
        
        if(GameController.mode == null)
        {
            goto label_346;
        }
        
        this.丝且与丝丒丟万丁专.丐万与丞上丒丛丁丕 = GameController.mode + 528;
        this.丝且与丝丒丟万丁专.不丄万丑丟万世专世 = GameController.mode + 536;
        label_341:
        this.丝且与丝丒丟万丁专.东丄丐一下世丙丘丕 = this.丝且与丝丒丟万丁专.万丙业丄丆丒世丙且();
        val_331 = 1152921505311105024;
        this.丝且与丝丒丟万丁专.丆丞丂世丞一丅七丝 = 丘丐丘万丌丟丞下丝.一丂万丏丗世丁丂且();
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                WeaponManager.丟丗丄业丘丗业丗七.myPlayer = this.丝且与丝丒丟万丁专.mySkinName.gameObject;
            WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC = this.丝且与丝丒丟万丁专;
            FpsManager.Reset(丕丕世且下一与丝与:  3f);
        }
        
            this.丝且与丝丒丟万丁专.上丅丅下丅万一丘丄();
        }
        
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                丅丒丗丑丒丙丛不丆.丘丟丕丈一下且万丆(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.下丂业丗东且一丄一);
            丅丒丗丑丒丙丛不丆.丝丈丆丝丒丛丏丄东(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.下丂业丗东且一丄一);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                System.DateTime val_123 = System.DateTime.UtcNow;
            上丘七丆七丑丑丕丞.丑七不且上丗丁一世().丁上三东丝丞万专丟(丙业与丙丗丝不丈东:  val_123.dateData);
            this.丝且与丝丒丟万丁专._aimCollider.gameObject.SetActive(value:  false);
        }
        
        if(((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  200)) == false) || (东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200] == null))
        {
            goto label_399;
        }
        
        var val_131 = (((不丘丄丝丗丒丙一丌.__il2cppRuntimeField_typeHierarchy + (丆万丗下丞丒丐丙丛.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200] : 0;
        if(this.丝且与丝丒丟万丁专.丆丝丟丕丝业世专与() == 0)
        {
            goto label_399;
        }
        
        UnityEngine.Transform val_136 = this.丝且与丝丒丟万丁专.丆丝丟丕丝业世专与().transform.GetChild(index:  0);
        if(val_136 == 0)
        {
            goto label_399;
        }
        
        UnityEngine.GameObject val_138 = val_136.gameObject;
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_401;
        }
        
        if(val_138 != null)
        {
            goto label_636;
        }
        
        label_637:
        label_636:
        val_138.SetActive(value:  (~this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑()) & 1);
        label_399:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_423;
        }
        
        }
        
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
                System.IDisposable val_146 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Player Move C");
            if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丐丆七且丞丏下三丙 = val_146;
        }
        else
        {
                this.丝且与丝丒丟万丁专.丐丆七且丞丏下三丙 = val_146;
        }
        
            this.丝且与丝丒丟万丁专.丟丆丄丏万下业丞丏(丙业与丙丗丝不丈东:  false);
            东丟丟万下丛丆丛丟.丌丟七世丗万丒东丆(丙业与丙丗丝不丈东:  new System.Action<ModuleGadgetRecord>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丁且不丑丝下丙丅丕(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)));
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_148 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  null);
        if(val_148 != null)
        {
                if((val_148.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 100)
        {
                this.丝且与丝丒丟万丁专.丌不东七丆万专三下 = true;
        }
        
        }
        
        label_423:
        val_339 = 1152921505171275776;
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_430;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丙丙丟世丌且丑丅丘() != 0)
        {
                this.丝且与丝丒丟万丁专.丙丙丟世丌且丑丅丘().spatialBlend = 0f;
        }
        
        label_430:
        if((UnityEngine.Object.op_Implicit(exists:  this.丝且与丝丒丟万丁专.photonView)) != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_439;
        }
        
        }
        
        if(((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false) && (GameConnect.东且三丆丑世世丘丟() != false))
        {
                if((下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  "LikeID")) <= 0)
        {
                下专世丏丈丞三丗不.丆丕丈丈丝丒丑上丁(丞丅上丏丂且下丅与:  "LikeID", 丌世丄七丐一上丒丂:  1);
        }
        
        }
        
        丘丐丘万丌丟丞下丝.丒丏三七丌丁丏丞上(丙业与丙丗丝不丈东:  1f);
        丘丐丘万丌丟丞下丝.三业丏丈丒且世七丞(丙业与丙丗丝不丈东:  false);
        UnityEngine.Vector3 val_162 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_163 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_162.x, y = val_162.y, z = val_162.z}, d:  10000f);
        val_333 = val_163.x;
        val_340 = val_163.y;
        val_334 = val_163.z;
        UnityEngine.Quaternion val_164 = UnityEngine.Quaternion.identity;
        val_335 = val_164.y;
        val_343 = val_340;
        val_344 = val_334;
        val_345 = val_164.x;
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "InGameGUI/InGameGUI"), position:  new UnityEngine.Vector3() {x = val_333, y = val_343, z = val_344}, rotation:  new UnityEngine.Quaternion() {x = val_345, y = val_335, z = val_164.z, w = val_164.w}).GetComponent<InGameGUI>();
        if((GameConnect.万不丒丌丙万丗东不() != false) && (null != 0))
        {
                if(null != 0)
        {
            goto label_470;
        }
        
        }
        
        label_470:
        if((GameConnect.丛专丌且丕不专丈下() != true) && (GameConnect.丆丕丒与丂七与下上() != true))
        {
                if(GameConnect.一业上七丟业且业丙() != true)
        {
                if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.且丆丅丏丌丗丛丄丌 == false)
        {
            goto label_483;
        }
        
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.aimPanel != null)
        {
            goto label_634;
        }
        
        label_635:
        label_634:
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.aimPanel.SetActive(value:  (0 != 0) ? 1 : 0);
        val_331 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.且丆丅丏丌丗丛丄丌 == false)
        {
            goto label_488;
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.battleEmojiButton != null)
        {
            goto label_538;
        }
        
        label_539:
        label_538:
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.battleEmojiButton.SetActive(value:  (0 != 0) ? 1 : 0);
        this.丝且与丝丒丟万丁专.丟丑且丗丗东一丘上();
        与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 = false;
        与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 = false;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "KilledPlayerCharactersCount")) != false)
        {
                int val_174 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "KilledPlayerCharactersCount", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        
        this.丝且与丝丒丟万丁专.且万丏丆东下丙丘专 = 0;
        label_439:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != true)
        {
                this.丝且与丝丒丟万丁专.丑丄丅丟丙丛丒丑丅 = SkinsController.丌与世丂丘且下丒丑;
            SkinsController.丌与世丂丘且下丒丑.filterMode = 0;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::世丆丂丗丑下丒东丙(string 丞丅上丏丂且下丅与));
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                this.丝且与丝丒丟万丁专.且丁丝丛与一丏丝七 = TrainingController.丄丞丁丈与业上丞丟;
        }
        
        this.丝且与丝丒丟万丁专.丁世万丙丞丅丆丌业 = ExperienceController.sharedController;
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_526;
        }
        
        if(this.丝且与丝丒丟万丁专.丝丙七丒且丂丝与丏 != false)
        {
                NetworkStartTable val_177 = this.丝且与丝丒丟万丁专.丑丘下下丛世丝丐上();
            if(val_177 != 0)
        {
                UnityEngine.GameObject val_179 = val_177.gameObject;
            this.丝且与丝丒丟万丁专.业丐上东丅丞丛万上 = val_179;
            this.丝且与丝丒丟万丁专.丄丆丆三丞下丈丑不(丄丝丆丈丘丅上上东:  val_179);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_526;
        }
        
        if(this.丝且与丝丒丟万丁专.丝丙七丒且丂丝与丏 == false)
        {
            goto label_524;
        }
        
        this.丝且与丝丒丟万丁专.一丈丞丐与下且三专 = this.丝且与丝丒丟万丁专.photonView.viewID;
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_526;
        }
        
        label_524:
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_527;
        }
        
        label_526:
        this.丝且与丝丒丟万丁专.东与且不上不东且上();
        丆丟七丌丞东丆丕丌.专丕丕七丆万东世丏(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::且丁下丅丕上丛丞丏(string 一丕且丌业下丂丏且)));
        丆丟七丌丞东丆丕丌.万世丅丟丈丅世丒丄(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::世丝且万丈丝丁丁丕()));
        System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String> val_184 = null;
        val_331 = 1152921535710816480;
        val_184 = new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丘七丐丌业丆丗丌丟(PGCompany.丗丟丅七东丄丙丟上 丕上业丕丘上丘七一, PGCompany.丏丂一丗丙世丏丐三 下丅丙一丂丗丅丝七, string 丞丅上丏丂且下丅与));
        丆丟七丌丞东丆丕丌.丐丅万万丕专丒丑丙(丙业与丙丗丝不丈东:  val_184);
        丆丟七丌丞东丆丕丌.丕丏丐七东且丒上丐(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丘七丐丌业丆丗丌丟(PGCompany.丗丟丅七东丄丙丟上 丕上业丕丘上丘七一, PGCompany.丏丂一丗丙世丏丐三 下丅丙一丂丗丅丝七, string 丞丅上丏丂且下丅与)));
        val_339 = 1152921505171275776;
        label_527:
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_530;
        }
        
        val_331 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
        System.Delegate val_188 = System.Delegate.Combine(a:  this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.不丐丝丕上世上与丌, b:  new System.Action<FirstPersonControlSharp, System.Single>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丙丅三丁丈丁不丞丑(FirstPersonControlSharp 七不丈丆一丒世丛丁, float 丘下丑丑丕下三丝上)));
        if(val_331 == null)
        {
            goto label_533;
        }
        
        if(val_188 != null)
        {
            goto label_534;
        }
        
        goto label_541;
        label_488:
        var val_189 = (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丑丞丒丟丞丟丆丁一 == true) ? 0 : 1;
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.battleEmojiButton != null)
        {
            goto label_538;
        }
        
        goto label_539;
        label_533:
        if(val_188 == null)
        {
            goto label_541;
        }
        
        label_534:
        if(null == null)
        {
            goto label_541;
        }
        
        val_339 = 1152921505171275776;
        goto label_542;
        label_541:
        val_339 = 1152921505171275776;
        label_542:
        this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.不丐丝丕上世上与丌 = val_188;
        label_530:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_543;
        }
        
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_550;
        }
        
        }
        
            if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true)
        {
                if(this.丝且与丝丒丟万丁专.七丕丞丞丗专上丝丘 == true)
        {
            goto label_550;
        }
        
        }
        
            if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丄丕丗丗七上丕丒万() != false)
        {
                label_550:
        }
        
            val_85 = 0;
            val_343 = 0f;
            val_344 = 0f;
            this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = val_343, z = val_344};
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == true)
        {
            goto label_555;
        }
        
        label_543:
        丅丌丝丘丐不丒丄专.丂丐东丂丗世与丘丟();
        丅丌丝丘丐不丒丄专.丝丆与上丑丗丝万丄 = UnityEngine.Time.time;
        ZombieCreator.丂专一万丛业与一丅(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丄丆丒业且专丝专丆()));
        label_555:
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丁不丒且丈东丞业丑(丂丛丑东不丅丈一东:  "Campaign");
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丛丛世丑万东丗万专 != false)
        {
                this.丝且与丝丒丟万丁专.丌万丙万专丑丆三丆 = ZombiManager.丟丗丄业丘丗业丗七;
        }
        
            if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                this.丝且与丝丒丟万丁专.且丑丝丂丁丙丂三丗 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        }
        
            if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                bool val_200 = this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑();
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_572;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丏丏丄丘七与七丝丛 = StoreKitEventListener.丆丕丝丒不丙且丐丗;
        label_572:
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.HOTween.EnableOverwriteManager(logWarnings:  true);
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                this.丝且与丝丒丟万丁专.七丆丂专丁丈丒东丐 = this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑();
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_580;
        }
        
        val_332 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance;
        goto label_587;
        label_580:
        System.Action<Prime31.GooglePurchase> val_207 = null;
        val_332 = val_207;
        val_207 = new System.Action<Prime31.GooglePurchase>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丝丅丛丗丆业丝丈与(Prime31.GooglePurchase 丛上丌丂业七不三世));
        Prime31.GoogleIABManager.add_purchaseSucceededEvent(value:  val_207);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_592;
        }
        
        goto label_591;
        label_587:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_592;
        }
        
        label_591:
        label_592:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_594;
        }
        
        }
        
        val_332 = this.丝且与丝丒丟万丁专.myPlayerTransform;
        label_594:
        this.丝且与丝丒丟万丁专.丒一丄丗丞丗丄丐丂 = val_332.gameObject;
        this.丝且与丝丒丟万丁专.一业丝丗上丛丅且丕(丙业与丙丗丝不丈东:  WeaponManager.丟丗丄业丘丗业丗七);
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_651;
        }
        
        }
        
        val_332 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丅下三且万丟东不下();
        List.Enumerator<T> val_214 = val_332.GetEnumerator();
        val_331 = 1152921525778334208;
        label_629:
        if((1184820944 & 1) == 0)
        {
            goto label_604;
        }
        
        string val_215 = val_85.丐丏七丌丕丗业且上();
        new com.amazon.device.iap.cpt.PurchaseResponseDelegate(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丂丟业下丗丟丙丞不(com.amazon.device.iap.cpt.PurchaseResponse 丑与丂丌世丕丆一丗)).丆丛丄丙七丏且东业();
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)) || (null != 0))
        {
            goto label_629;
        }
        
        if((GameConnect.东丒七专丂世丝丏丗() != false) && (GameController.onlineMode.丒万丕七专不丏丞丌() != 0))
        {
                val_215.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  0);
        }
        else
        {
                val_215.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  GameController.onlineMode.下世下丂丂丌丑丝世());
        }
        
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_626;
        }
        
        val_215.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  0);
        goto label_629;
        label_626:
        val_215.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  GameController.onlineMode.丟七下专丈丏丕丈上());
        goto label_629;
        label_604:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_330 = 1152921504848912384;
        val_336 = 1152921505286238208;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_652;
        }
        
        goto label_631;
        label_483:
        var val_221 = (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丑丞丒丟丞丟丆丁一 == true) ? 0 : 1;
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.aimPanel != null)
        {
            goto label_634;
        }
        
        goto label_635;
        label_401:
        if(val_138 != null)
        {
            goto label_636;
        }
        
        goto label_637;
        label_346:
        this.丝且与丝丒丟万丁专.丐万与丞上丒丛丁丕 = 293;
        val_337 = 0;
        goto label_650;
        label_651:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_652;
        }
        
        label_631:
        label_652:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_659;
        }
        
        }
        
        val_332 = Pauser.且三丝三七七丐丁丁;
        this.丝且与丝丒丟万丁专.丕不业丙一业丟丈丞 = val_332;
        if(val_332 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "Start(): _pauser is null.");
        }
        
        label_659:
        if(this.丝且与丝丒丟万丁专.世丝丞丂丐三丒丒丘() == false)
        {
            goto label_700;
        }
        
        if(((GameConnect.世丐丄三三上丅七三() != true) && ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)) && (GameConnect.东且三丆丑世世丘丟() != false))
        {
                int val_229 = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  "LikeID");
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_674;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_677;
        }
        
        val_346 = 0;
        goto label_678;
        label_674:
        Rilisoft.丝丑丂丛万丐丈丘且 val_233 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丈丄丙丙丈丗业丆万());
        this.丝且与丝丒丟万丁专.下东与一丗与丌丈丄 = val_233;
        mem2[0] = val_233.上万三丆专丏丒丗业;
        val_347 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒();
        int val_235 = val_347.丈丄丙丙丈丗业丆万();
        goto label_681;
        label_677:
        val_347 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒();
        label_681:
        val_346 = val_347.七丅丒万万丅一丄专();
        label_678:
        this.丝且与丝丒丟万丁专.东丙丂丕世一与丙丆(丟且丒丁丞万专丙三:  val_346, 丟业下东与东专专业:  false);
        WeaponManager val_238 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒();
        val_238.myGun = this.丝且与丝丒丟万丁专.gameObject;
        if(this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗() != 0)
        {
                UnityEngine.Animation val_246 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗().丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
            val_331 = "Reload";
            if((val_246.GetClip(name:  "Reload")) != 0)
        {
                val_246.Item["Reload"].layer = 1;
        }
        
            val_246.Stop();
        }
        
        val_332 = 1152921505111851008;
        val_348 = null;
        val_348 = null;
        Player_move_c.一丕丗丆三不丘丐丟 = false;
        Player_move_c.一丕丗丆三不丘丐丟 = true;
        if(this.丝且与丝丒丟万丁专.丏下丙丞丕丕丏丕丞() != false)
        {
                val_332 = "gfts";
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "gfts", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) | 128, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        label_700:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                val_332 = ProfileController.丆三丂丂丆上丆丕专();
            val_331 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_332);
            if(this.丝且与丝丒丟万丁专.丝丙七丒且丂丝与丏 != false)
        {
                val_332 = this.丝且与丝丒丟万丁专.photonView;
            object[] val_256 = new object[1];
            val_256[0] = val_331;
            val_332.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  81, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_256);
        }
        
            if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_332 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅();
            if((val_332.ContainsKey(key:  200)) != false)
        {
                val_332 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[200];
        }
        
        }
        
            if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                val_332 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅();
            if((val_332.ContainsKey(key:  212)) != false)
        {
                val_332 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[212];
        }
        
        }
        
        }
        
            if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_738;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.上上丘一丁下丕上与(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.专一丟丏且丆丕丝七());
        val_332 = this.丝且与丝丒丟万丁专.与丙丕丛一丌丛丆丈;
        val_332.且七丙丄丘一丄上不();
        this.丝且与丝丒丟万丁专.丅丐丒丌丑三丆下业();
        label_738:
        if(this.丝且与丝丒丟万丁专.世丝丞丂丐三丒丒丘() != false)
        {
                UnityEngine.Coroutine val_271 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丝丆上丁丈与且丟一());
            this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.armor = new InGameGUI.丝与丑业世丘丘丑丂(三一丄丗专丌丛丘丅:  this.丝且与丝丒丟万丁专, 丛丌丙世专世东丕下:  System.Single Player_move_c::丂丏世丅万丄丛丙丏());
            this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.killsToMaxKills = new InGameGUI.丒丙丝丆丄丆丄且专(三一丄丗专丌丛丘丅:  this.丝且与丝丒丟万丁专, 丛丌丙世专世东丕下:  System.String Player_move_c::不与丙万与丌丒丐丌());
            this.丝且与丝丒丟万丁专.丟丞不丟丛丈且且丟();
            丆丟七丌丞东丆丕丌.丂下下丒丘丙丘丟一(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)));
            丆丟七丌丞东丆丕丌.丝丏不丝丕丒一三丗(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)));
            丆丟七丌丞东丆丕丌.不丕丘业专丐丙万丑(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)));
            丆丟七丌丞东丆丕丌.丒专丑丅丐丂且丌丐(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)));
            val_331 = 1152921504615686144;
            ShopNGUIController.丛丄上上丟万东世丂(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丏丑七与东三丑丙万(string 丞丅上丏丂且下丅与)));
            ShopNGUIController.上丝与丂一丌丛丞专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丏丑七与东三丑丙万(string 丞丅上丏丂且下丅与)));
            WeaponManager.不万且专丕且丘丛世(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丗丏一三丞丛丘丐丗(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且)));
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_349 = null;
            val_349 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丐万下丄东丗丈丂丟());
        }
        
            丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
            丛且丗丌丏下七下丈.丕丞东上丗丄丞东丈(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
            丛且丗丌丏下七下丈.上丛丗丐下丅专东丟(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丒一丛丈七丂一与世(string 与丟丅七丞且且丛丕)));
            丛且丗丌丏下七下丈.丑丌下丟且丒三丝丙(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丒一丛丈七丂一与世(string 与丟丅七丞且且丛丕)));
            Progress.丌丆丈丛丁不丁万丒.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  new System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::万丗丄丝丈万业丌七(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)));
            Progress.丌丆丈丛丁不丁万丒.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丒丙上丕上世丟一专(int 丛丆东与丑丞丅丝专)));
            三丐下丁丒丆丘下丄.下丛丌下丈丒丟七七(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丆丟且不丟东万丏与()));
            三丐下丁丒丆丘下丄.七丏丄丝业丟世业丅(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丁丗世上下七丄丂万()));
            WeaponManager.丏丂丐丅丘丛丏丏丗(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丁专丏业丒丑丄上东(三丅丁丗丗丝丂万且 下丅丙一丂丗丅丝七)));
            val_330 = 1152921504848912384;
            val_339 = 1152921505171275776;
            上丑三丁丄丛丁万丑.丑一丈丛专丈且业丅(丙业与丙丗丝不丈东:  new System.Action<System.String, CategoryNames, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丂丗上专丘丌丙丛丏(string 下业七不丑丂丏丟东, CategoryNames 丙丑丕丂下丏一丁专, string 丙三丅丛万七丒丏丙)));
            上丑三丁丄丛丁万丑.一万不业丛七三丞东(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丗丞丏丅且东丂丛丑(CategoryNames 丙丑丕丂下丏一丁专, string 下业七不丑丂丏丟东)));
            Progress.丟丕丒丑东丗丑丏丑.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  new System.Action<System.String, PGCompany.丟丝世万东万丆丟上>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::丞且丑业丄下七丛七(string 丝三丛且丘不丌丙下, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)));
            Progress.丟丕丒丑东丗丑丏丑.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::东且东丟丄三世丂且(string 丝三丛且丘不丌丙下)));
            System.Action<System.String, System.String, GadgetCategory, FilterMaps> val_296 = null;
            val_332 = val_296;
            val_296 = new System.Action<System.String, System.String, GadgetCategory, FilterMaps>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Player_move_c::与业丑下上丆丟与三(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不, GadgetCategory 丌丙专丟丆丘上一丒, FilterMaps 专丆丌丛东一不丑丙));
            val_329 = ;
            val_336 = 1152921505286238208;
            丆丟七丌丞东丆丕丌.丆专丙丛与丗东下不(丙业与丙丗丝不丈东:  val_296);
            val_327 = ;
        }
        
        val_350 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (GameConnect.与丂丝丟丟三丑丝万() != false))
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                val_351 = null;
            val_332 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_332 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            this.丝且与丝丒丟万丁专.丑丛一丌专丞七丞与(丙业与丙丗丝不丈东:  丑丛丆三丆丄七丐万());
        }
        
        }
        
        val_352 = null;
        val_352 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                val_332 = 1152921505336610816;
            val_354 = null;
            val_354 = null;
            VehicleController.recoverCarAfterDisconnect = 0f;
        }
        
        }
        
        val_355 = null;
        val_355 = null;
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)) || (this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false))
        {
            goto label_889;
        }
        
        val_331 = 1152921505189646336;
        val_357 = null;
        val_357 = null;
        val_332 = GameController.onlineMode;
        if(null == 0)
        {
            goto label_889;
        }
        
        val_358 = null;
        val_358 = null;
        this.丝且与丝丒丟万丁专.丑丛一丌专丞七丞与(丙业与丙丗丝不丈东:  GameController.mode.七丒丘丏业丟丌丄七());
        if((this.丝且与丝丒丟万丁专.丂丑丕丛万丛业丞丆() & 2147483648) != 0)
        {
                this.丝且与丝丒丟万丁专.丑丛一丌专丞七丞与(丙业与丙丗丝不丈东:  0);
        }
        
        val_359 = null;
        val_359 = null;
        this.丝且与丝丒丟万丁专.丘世东东丈丏丏丒丒 = 丟丌丁且且世丈丈丟.且丘丝丒丌丕丏丟丁;
        if(丟丌丁且且世丈丈丟.且丘丝丒丌丕丏丟丁 != 0)
        {
                UnityEngine.Transform val_305 = this.丝且与丝丒丟万丁专.丘世东东丈丏丏丒丒.transform;
            if(val_305.childCount >= 1)
        {
                this.丝且与丝丒丟万丁专.丑丅世世丛丙万丌丈 = true;
        }
        
            UnityEngine.Vector3 val_307 = val_305.position;
            this.丝且与丝丒丟万丁专.丒万丘丈丁世下丐上(上业万丅不丛丗丈不:  new UnityEngine.Vector3() {x = val_307.x, y = val_307.y, z = val_307.z}, 丞万且一丄丈丛丗与:  false, 专丞上七七且丝七丗:  0);
        }
        
        val_360 = null;
        val_360 = null;
        val_332 = mem[GameController.onlineMode + 432];
        val_332 = GameController.onlineMode.丞丑丕与万丂丝丂丅;
        if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_838;
        }
        
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_361 = null;
            val_361 = null;
            val_362 = null;
            val_362 = null;
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_363 = null;
            val_363 = null;
            val_364 = null;
            val_364 = null;
            val_343 = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_2C;
            val_344 = 丕丁丕上与丅不丙丄.__il2cppRuntimeField_this_arg;
            this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.七丌七丈丝专丘丘丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28, y = val_343, z = val_344});
        }
        
            val_365 = null;
            val_365 = null;
            this.丝且与丝丒丟万丁专.上上丘一丁下丕上与(丙业与丙丗丝不丈东:  typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_38);
            if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                val_367 = null;
            val_367 = null;
            this.丝且与丝丒丟万丁专.myPlayerTransform.position = new UnityEngine.Vector3() {x = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28, y = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_2C, z = 丕丁丕上与丅不丙丄.__il2cppRuntimeField_this_arg};
            UnityEngine.Quaternion val_315 = UnityEngine.Quaternion.Euler(x:  0f, y:  typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_34, z:  0f);
            val_366 = val_315.x;
            val_343 = val_315.y;
            val_344 = val_315.z;
            val_345 = val_315.w;
            this.丝且与丝丒丟万丁专.myPlayerTransform.rotation = new UnityEngine.Quaternion() {x = val_366, y = val_343, z = val_344, w = val_345};
        }
        
            BaseCamera val_316 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
            UnityEngine.Quaternion val_317 = this.丝且与丝丒丟万丁专.myPlayerTransform.rotation;
            val_334 = val_317.z;
            val_368 = null;
            val_332 = this.丝且与丝丒丟万丁专.与丙丕丛一丌丛丆丈;
            val_368 = null;
            val_332.丌丂一丆丅一业丗与(下丝丘丁专丐丅丛丝:  丕丁丕上与丅不丙丄.__il2cppRuntimeField_element_class, 丙丅世丒丝且丙专专:  (typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_3C != 0) ? 1 : 0);
        }
        
        label_838:
        if(GameConnect.丆丕丒与丂七与下上() != false)
        {
                val_369 = null;
            val_369 = null;
            val_332 = mem[GameController.onlineMode + 432];
            val_332 = GameController.onlineMode.丞丑丕与万丂丝丂丅;
            this.丝且与丝丒丟万丁专.丕丛专丆丝丛丆丌丐();
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_370 = null;
            val_370 = null;
            val_371 = null;
            val_371 = null;
            VehicleController.recoverCarAfterDisconnect = 丕丁丕上与丅不丙丄.__il2cppRuntimeField_declaringType;
        }
        
        label_889:
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false)
        {
                this.丝且与丝丒丟万丁专.丁七东丂丟与且且丗(专丞上七七且丝七丗:  0);
            this.丝且与丝丒丟万丁专.丈丆一且丐丐丏丒丞(专丞上七七且丝七丗:  0);
        }
        
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() == true)
        {
            goto label_900;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_905;
        }
        
        val_332 = TeamDuelController.丅丌丛丏丞上万丛丕;
        if((TeamDuelController.丅丌丛丏丞上万丛丕 + 144) < 1)
        {
            goto label_905;
        }
        
        label_900:
        val_372 = null;
        val_372 = null;
        val_332 = GameController.mode.七丒丘丏业丟丌丄七();
        this.丝且与丝丒丟万丁专.丑丛一丌专丞七丞与(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  0, b:  val_332));
        label_905:
        val_328 = 1;
        mem[1152921535856451208] = 0;
        this.丗丏丅丕丆世丁专丟 = val_328;
        return (bool)val_328;
        label_650:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Player_move_c.业丂丁三专丑丗丆不();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
