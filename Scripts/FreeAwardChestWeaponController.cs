using UnityEngine;
internal sealed class FreeAwardChestWeaponController : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _chest;
    private UnityEngine.Animation _weaponAnimation;
    private UnityEngine.Transform _weaponParent;
    private static System.Action<bool> 丛丙丘丞丅业下丘丆;
    private const float 三与丏七万专与丟一 = 0.33;
    private float 且三业丙世丁丑丘七;
    private bool 三丂丙万专丅下与丂;
    private bool 与与七丙业不业与不;
    private UnityEngine.Coroutine 丗丝三不丂东丏丕上;
    
    // Properties
    internal static bool 丒丂东丕丄三与专东 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    internal static void 丆丏丝丐世丗丘三丛(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  FreeAwardChestWeaponController.三与丏七万专与丟一, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 东丘丞丏丐丅丞专一(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  FreeAwardChestWeaponController.三与丏七万专与丟一, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static bool 丑丞七一七丈丄七与()
    {
        var val_11;
        if((业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() != false) && ((PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  0, 丏丞专丏业丗丝七丝: out  0)) != false))
        {
                if(val_4.不业丙丒丂丞下丆丙() == 10)
        {
                var val_10 = ((丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_4.业东丅东丌上丗丑不())) != 0) ? 1 : 0;
            return (bool)val_11;
        }
        
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private void Update()
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.且三业丙世丁丑丘七;
        if(val_1 < 0.33f)
        {
                return;
        }
        
        this.且三业丙世丁丑丘七 = UnityEngine.Time.realtimeSinceStartup;
        val_9 = null;
        bool val_3 = FreeAwardChestWeaponController.丑丞七一七丈丄七与();
        bool val_4 = this._chest.activeSelf;
        val_10 = this.三丂丙万专丅下与丂;
        bool val_5 = val_3 & val_4;
        if(val_10 != false)
        {
                val_10 = this.与与七丙业不业与不;
        }
        
        if(val_10 != val_5)
        {
                this.丄丄丏丑丟丘三且丈();
            if(val_5 != false)
        {
                this.丑丂丁七丛与丈世不();
            val_11 = null;
            val_11 = null;
            val_12 = 1152921516635255488;
            val_13 = 1;
        }
        else
        {
                val_14 = null;
            val_14 = null;
            val_12 = 1152921516635255488;
            val_13 = 0;
        }
        
            FreeAwardChestWeaponController.三与丏七万专与丟一.Invoke(obj:  false);
        }
        
        this.三丂丙万专丅下与丂 = val_3;
        this.与与七丙业不业与不 = val_4;
    }
    private void 丑丂丁七丛与丈世不()
    {
        FreeAwardChestWeaponController val_17;
        var val_18;
        var val_19;
        val_17 = this;
        string val_6 = 0;
        new FreeAwardChestWeaponController.丗丛丘丑丐不丌丑丙() = new System.Object();
        .丝且与丝丒丟万丁专 = val_17;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
            goto label_5;
        }
        
        if((PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  0, 丏丞专丏业丗丝七丝: out  val_6)) == false)
        {
            goto label_7;
        }
        
        if(val_5.不业丙丒丂丞下丆丙() != 10)
        {
                return;
        }
        
        三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_5.业东丅东丌上丗丑不());
        .丆丐七世世且丏丐业 = val_10;
        if(val_10 == null)
        {
                return;
        }
        
        this.丗丝三不丂东丏丕上 = CoroutineRunner.Instance.StartCoroutine(routine:  new FreeAwardChestWeaponController.丗丛丘丑丐不丌丑丙().与下丌丕万与不丆上());
        return;
        label_5:
        val_18 = null;
        if(FreeAwardChestWeaponController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[FreeAwardChestWeaponController.ShowWeapon] IsAuthorized: false");
        return;
        label_7:
        val_19 = null;
        if(FreeAwardChestWeaponController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_17 = "[FreeAwardChestWeaponController.ShowWeapon] TryGetLastReward: false. "("[FreeAwardChestWeaponController.ShowWeapon] TryGetLastReward: false. ") + val_6;
        UnityEngine.Debug.Log(message:  val_17);
    }
    private void 丄丄丏丑丟丘三且丈()
    {
        if(this._weaponAnimation != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponAnimation.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丁丝丌一世且丕丘与();
        if(this._weaponParent == null)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._weaponParent);
    }
    private void 丁丝丌一世且丕丘与()
    {
        if(this.丗丝三不丂东丏丕上 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丗丝三不丂东丏丕上);
        this.丗丝三不丂东丏丕上 = 0;
    }
    private void OnDestroy()
    {
        this.丄丄丏丑丟丘三且丈();
    }
    public FreeAwardChestWeaponController()
    {
    
    }
    private static FreeAwardChestWeaponController()
    {
        null = null;
        FreeAwardChestWeaponController.三与丏七万专与丟一 = new System.Action<System.Boolean>(object:  FreeAwardChestWeaponController.<>c.<>9, method:  System.Void FreeAwardChestWeaponController.<>c::丌丒七丘上业上三三(bool 世丗丈丗丂业丙一不));
    }

}
