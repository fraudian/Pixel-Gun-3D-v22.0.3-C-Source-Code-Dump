using UnityEngine;
internal sealed class PopUpOneWeaponUI : PGBehaviour
{
    // Fields
    private string _weaponName;
    private string _categoryName;
    private int _ammoInClip;
    private int _ammoInBackpack;
    private ItemRarity _rarity;
    private System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> _weaponEffects;
    private UITextureMasked _weaponIconMasked;
    private UILabel _weaponNameLabel;
    private UILabel _categoryNameLabel;
    private UILabel _ammoInWeaponLabel;
    private UISprite _raritySprite;
    private WidgetLayout _weaponPerksLayout;
    private System.Collections.Generic.List<UISprite> _weaponPerksSprites;
    private System.Collections.Generic.List<UILabel> _weaponPerksLabels;
    private UIButton getWeaponButton;
    private UnityEngine.GameObject autoEquipTweener;
    private 世丂丈世且万世丞上 丑丘丌与上丁七三丒;
    private bool 不丆上丟丈丟丟丑上;
    private float 与丕丌丒丗丄丘丙东;
    private float autoEquipTime;
    
    // Methods
    private void Start()
    {
        this.丘上丐世丆丑且丞丒();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.getWeaponButton.onClick.Clear();
        this.getWeaponButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PopUpOneWeaponUI::丞世丞丅丏业上丌丅())));
    }
    internal void 丝丈丞丂东丟东丘丌(世丂丈世且万世丞上 丌且丗丌丝丐下东丘)
    {
        世丂丈世且万世丞上 val_7;
        this.丑丘丌与上丁七三丒 = 丌且丗丌丝丐下东丘;
        var val_8 = 0;
        val_8 = val_8 + 1;
        string val_2 = 丌且丗丌丝丐下东丘.GetWeaponName();
        val_7 = this.丑丘丌与上丁七三丒;
        var val_9 = 0;
        val_9 = val_9 + 1;
        if(val_7.IsGadget() != false)
        {
                val_7 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
            this.丗丏不丛三不三上丝(丁且丌丁丆丝丙丘丝:  val_7.Item[val_2]);
        }
        else
        {
                this.一丗丐丐丏丑三丏丞(三与世丈丂丕丏三上:  丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_2));
        }
        
        this._weaponPerksLayout.Reposition();
    }
    private void 一丗丐丐丏丑三丏丞(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上)
    {
        string val_21;
        string val_26;
        丈不三丛七丑丈丑丆 val_28;
        string val_29;
        int val_30;
        var val_31;
        var val_32;
        if(三与世丈丂丕丏三上 != null)
        {
                this._weaponName = 三与世丈丂丕丏三上.丟丄丞丅丑七丞丄丞();
        }
        else
        {
                this._weaponName = 0.丟丄丞丅丑七丞丄丞();
        }
        
        this._categoryName = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.与丅丙专且世丂丝丈(七丆丒与丗丌丄且丂:  三与世丈丂丕丏三上.丒万丕七专不丏丞丌()));
        if(三与世丈丂丕丏三上 != null)
        {
                val_28 = this;
            this._rarity = 三与世丈丂丕丏三上.丆丙专丆丅丟丙与丈();
        }
        else
        {
                val_28 = this;
            this._rarity = 0.丆丙专丆丅丟丙与丈();
        }
        
        this._weaponEffects = 三与世丈丂丕丏三上.丞丁下丅上不且丐丄();
        this._weaponNameLabel.text = this._weaponName;
        this._categoryNameLabel.text = this._categoryName;
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._raritySprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity]});
        if(三与世丈丂丕丏三上 != null)
        {
                val_29 = 三与世丈丂丕丏三上.与不丞丑七丘丁丂丛();
        }
        else
        {
                val_29 = 0.与不丞丑七丘丁丂丛();
        }
        
        UnityEngine.Texture val_13 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_29, 七丆丒与丗丌丄且丂:  三与世丈丂丕丏三上.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_30 = this._weaponEffects.Count;
        goto label_21;
        label_26:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._weaponPerksLabels.Item[val_30], 丏业丟一东丂东丘丛:  false);
        val_30 = val_30 + 1;
        label_21:
        if(val_30 < this._weaponPerksLabels.Count)
        {
            goto label_26;
        }
        
        val_31 = 0;
        goto label_27;
        label_43:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._weaponPerksLabels.Item[0], 丏业丟一东丂东丘丛:  true);
        val_32 = null;
        val_32 = null;
        System.ValueTuple<System.String, System.String, System.String> val_20 = WeaponSounds.三丘丒万丛丞与一不.Item[this._weaponEffects.Item[0]];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponPerksLabels.Item[0], 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_21));
        val_28 = this._weaponEffects.Item[0];
        System.ValueTuple<System.String, System.String, System.String> val_25 = WeaponSounds.三丘丒万丛丞与一不.Item[val_28];
        this._weaponPerksSprites.Item[0].spriteName = val_26;
        val_31 = 1;
        label_27:
        if(val_31 < this._weaponEffects.Count)
        {
            goto label_43;
        }
    
    }
    private void 丗丏不丛三不三上丝(丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝)
    {
        string val_17;
        string val_22;
        string val_24;
        int val_25;
        var val_26;
        var val_27;
        this._weaponName = 丁且丌丁丆丝丙丘丝.丒万丁丌一丙专丐丞();
        this._categoryName = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2197");
        this._rarity = 丁且丌丁丆丝丙丘丝.七东与丄丕丁丛世三();
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._raritySprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[this._rarity]});
        this._weaponEffects = 丁且丌丁丆丝丙丘丝.丑丐丗世业丙丗丘不();
        this._weaponNameLabel.text = this._weaponName;
        this._categoryNameLabel.text = this._categoryName;
        if(丁且丌丁丆丝丙丘丝 != null)
        {
                val_24 = 丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_24 = 0.业上丙丞丐丄丆丅七();
        }
        
        UnityEngine.Texture val_9 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_24, 七丆丒与丗丌丄且丂:  丁且丌丁丆丝丙丘丝.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_25 = this._weaponEffects.Count;
        goto label_18;
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._weaponPerksLabels.Item[val_25], 丏业丟一东丂东丘丛:  false);
        val_25 = val_25 + 1;
        label_18:
        if(val_25 < this._weaponPerksLabels.Count)
        {
            goto label_23;
        }
        
        val_26 = 0;
        goto label_24;
        label_40:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._weaponPerksLabels.Item[0], 丏业丟一东丂东丘丛:  true);
        val_27 = null;
        val_27 = null;
        System.ValueTuple<System.String, System.String, System.String> val_16 = WeaponSounds.三丘丒万丛丞与一不.Item[this._weaponEffects.Item[0]];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponPerksLabels.Item[0], 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17));
        System.ValueTuple<System.String, System.String, System.String> val_21 = WeaponSounds.三丘丒万丛丞与一不.Item[this._weaponEffects.Item[0]];
        this._weaponPerksSprites.Item[0].spriteName = val_22;
        val_26 = 1;
        label_24:
        if(val_26 < this._weaponEffects.Count)
        {
            goto label_40;
        }
    
    }
    public void InitAmmoAmount(int 丅丕丟丙七下丘丏丁, int 万东丕丈一专三上丁, bool 丐丙东丏丂业与业丂)
    {
        var val_5;
        this._ammoInClip = 丅丕丟丙七下丘丏丁;
        mem[1152921536410689292] = 万东丕丈一专三上丁;
        if(丅丕丟丙七下丘丏丁 != 1)
        {
                val_5 = ((万东丕丈一专三上丁 != 1) ? 1 : 0) | 丐丙东丏丂业与业丂;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._ammoInWeaponLabel, 丏业丟一东丂东丘丛:  val_5 & 1);
        if(丐丙东丏丂业与业丂 != false)
        {
                this._ammoInWeaponLabel.text = this._ammoInClip.ToString();
            return;
        }
        
        this._ammoInWeaponLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  this._ammoInClip, arg1:  this._ammoInBackpack);
    }
    private void 丞世丞丅丏业上丌丅()
    {
        this.StopAutoEquipped();
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丑丘丌与上丁七三丒.AddWeaponToPlayer();
    }
    public void StartAutoEquipped()
    {
        if(this.不丆上丟丈丟丟丑上 != false)
        {
                return;
        }
        
        this.与丕丌丒丗丄丘丙东 = UnityEngine.Time.time;
        this.不丆上丟丈丟丟丑上 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.autoEquipTweener, 丏业丟一东丂东丘丛:  true);
    }
    public void StopAutoEquipped()
    {
        this.不丆上丟丈丟丟丑上 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.autoEquipTweener, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        世丂丈世且万世丞上 val_7;
        if(this._ammoInClip == 1)
        {
            goto label_1;
        }
        
        if(this._ammoInBackpack != 1)
        {
                return;
        }
        
        val_7 = this;
        var val_11 = 0;
        val_11 = val_11 + 1;
        goto label_7;
        label_1:
        val_7 = this.丑丘丌与上丁七三丒;
        goto label_8;
        label_7:
        if(this.丑丘丌与上丁七三丒.IsGadget() == true)
        {
                return;
        }
        
        label_8:
        var val_12 = 0;
        val_12 = val_12 + 1;
        int val_4 = this.丑丘丌与上丁七三丒.GetCurrentAmmoInClip();
        var val_13 = 0;
        val_13 = val_13 + 1;
        int val_6 = this.丑丘丌与上丁七三丒.GetCurrentAmmoInBackpack();
        var val_14 = 0;
        val_14 = val_14 + 1;
        bool val_8 = this.丑丘丌与上丁七三丒.IsGadget();
        var val_9 = (val_6 != 1) ? 1 : 0;
        if(val_4 == 1)
        {
                return;
        }
        
        val_9 = val_9 | val_8;
        if(val_9 == false)
        {
                return;
        }
        
        this.InitAmmoAmount(丅丕丟丙七下丘丏丁:  val_4, 万东丕丈一专三上丁:  val_6, 丐丙东丏丂业与业丂:  val_8);
    }
    private void LateUpdate()
    {
        this.丞一一东丛且丐丁与();
    }
    private void 丞一一东丛且丐丁与()
    {
        var val_7;
        if(this.不丆上丟丈丟丟丑上 == false)
        {
                return;
        }
        
        if((System.Math.Abs(UnityEngine.Time.time - this.与丕丌丒丗丄丘丙东)) < this.autoEquipTime)
        {
                return;
        }
        
        this.StopAutoEquipped();
        val_7 = null;
        val_7 = null;
        int val_8 = WeaponManager.丂丐丛业世丝丁丛丕;
        val_8 = val_8 - (typeof(Player_move_c).__il2cppRuntimeField_538.Count + WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count);
        if(val_8 < 1)
        {
                return;
        }
        
        this.丞世丞丅丏业上丌丅();
    }
    public PopUpOneWeaponUI()
    {
        this.autoEquipTime = 1f;
    }

}
