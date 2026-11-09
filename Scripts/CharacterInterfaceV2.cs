using UnityEngine;
internal class CharacterInterfaceV2 : MonoBehaviour
{
    // Fields
    private bool 丌七丞丛东一不七丏;
    private bool 一丕丗丁丘丈丆丄一;
    private bool 丌丕丁丞丏丒丝三丘;
    private bool 丐丟丛丒丁不三东丟;
    private bool 丙万业丈丈东丁一业;
    private UnityEngine.Mesh 专世丐丂丒上丄三丌;
    private UnityEngine.Transform[] 丅万且丒丙三丗不丑;
    private bool 不业丑丄丝丕上且丗;
    private bool 丏专丌且丘丗丅丟丑;
    private bool 万丑丟且丏且丏东一;
    private bool 与丒丕丕七丁丟与不;
    private bool 上与万丙丙且丙丕三;
    private bool 且与丐丐丄丄下丐丟;
    private bool 与丂丒丆丏上专业丗;
    private bool 业丅丅丟丛一万丑东;
    private bool <下丅上丈丗丛三丗丏>k__BackingField;
    private bool <丐丑丛丁丏丛东丏丝>k__BackingField;
    private bool <丕业丅丂上丄且丌丘>k__BackingField;
    private bool <丗丕丕七丒业万丑上>k__BackingField;
    private bool <丁下丆与业丄丂丂丞>k__BackingField;
    private CharacterInterfaceV2.丂丗专上丁丐且丝丆 <丆三丅丈丈丂丗丙丒>k__BackingField;
    internal const string 丗丝丏丑丏丄丞丏万 = "DaterArmsCar";
    internal const string 下丏上一不且下丛且 = "CarShopAnimationClip";
    internal const string 七丑世丕丏七丗丙丛 = "Fly_Shop";
    public float ScaleShop;
    public int ShopTier;
    public UnityEngine.Vector3 PositionShop;
    public UnityEngine.Vector3 RotationShop;
    private UnityEngine.Coroutine 上上丈丟且万上丟丛;
    private float NewGroundPetOffset;
    private float NewFlyingPetOffset;
    private UnityEngine.GameObject graffitiWall;
    private UnityEngine.Transform _graffitiPoint;
    private UnityEngine.Transform armorPoint;
    private UnityEngine.Transform leftBootPoint;
    private UnityEngine.Transform rightBootPoint;
    private UnityEngine.Transform capePoint;
    private UnityEngine.Transform hatPoint;
    private UnityEngine.Transform maskPoint;
    private UnityEngine.Transform gunPoint;
    private UnityEngine.Transform pointArmRight;
    private UnityEngine.Transform pointArmLeft;
    private UnityEngine.Transform carPoint;
    private UnityEngine.Transform _gliderPointTypeOnBack;
    private UnityEngine.Transform _gliderPointTypeStaying;
    private UnityEngine.Transform _gliderPointTypeFlying;
    private UnityEngine.Transform _gliderPointTypeSitting;
    private UnityEngine.Transform[] _royalTrailPoints;
    private UnityEngine.Transform _hugeGadgetPoint;
    private UnityEngine.Transform pointFlyingPet;
    private UnityEngine.Transform pointFlyingPetArmory;
    private UnityEngine.Transform pointFlyingPetProfile;
    private UnityEngine.Transform flyPointDuelLeft;
    private UnityEngine.Transform flyPointDuelRight;
    private UnityEngine.Transform pointGroundPet;
    private UnityEngine.Transform pointGroundPetArmory;
    private UnityEngine.Transform pointGroundPetProfile;
    private UnityEngine.Transform groundPointDuelLeft;
    private UnityEngine.Transform groundPointDuelRight;
    internal UnityEngine.Transform petPoint;
    internal bool usePetPointPosition;
    private UnityEngine.GameObject _skinCharacter;
    private UnityEngine.GameObject _simpleCharacter;
    private UnityEngine.GameObject _leftHand;
    private UnityEngine.GameObject _rightHand;
    private UnityEngine.Animation _animation;
    internal UnityEngine.SkinnedMeshRenderer playerBodyRenderer;
    internal UnityEngine.SkinnedMeshRenderer playerHeadRenderer;
    internal UnityEngine.SkinnedMeshRenderer playerRightLegRenderer;
    internal UnityEngine.SkinnedMeshRenderer playerLeftLegRenderer;
    internal UnityEngine.MeshRenderer playerSelfLeftArmRenderer;
    internal UnityEngine.MeshRenderer playerSelfRightArmRenderer;
    internal UnityEngine.SkinnedMeshRenderer royaleAvatarBodyRenderer;
    internal UnityEngine.SkinnedMeshRenderer royaleAvatarHeadRenderer;
    internal UnityEngine.SkinnedMeshRenderer royaleAvatarArmsRenderer;
    internal UnityEngine.SkinnedMeshRenderer royaleAvatarLegsRenderer;
    private UnityEngine.Transform[] royaleAvatarBodyBones;
    private UnityEngine.Transform[] royaleAvatarHeadBones;
    private UnityEngine.Transform[] royaleAvatarArmsBones;
    private UnityEngine.Transform[] royaleAvatarLegsBones;
    internal System.Collections.Generic.List<EffectBones> effectObjects;
    private UnityEngine.Material _shopMaterial;
    private UnityEngine.Renderer[] _renderers;
    private UnityEngine.BoxCollider[] _colliders;
    private UnityEngine.GameObject[] 丕丏丌丂丙世一不丄;
    private System.Collections.Generic.Dictionary<CharacterInterfaceV2.与丕丁丏世七丝丆丛, string> 丞世丂上丏不世丒丅;
    private System.Collections.Generic.Dictionary<CharacterInterfaceV2.与丕丁丏世七丝丆丛, System.Collections.Generic.List<UnityEngine.Object>> 丌丘丗丐丘丅上丂丐;
    private UnityEngine.GameObject 丐丄丅丂与丗丑三丑;
    private string 丐专一丗上下丒丐丆;
    private PGCompany.丟丝世万东万丆丟上 一业东三三且丙丐丘;
    private string 万丝丂一万丐丗三专;
    private string 丁七丒一世丟丕世东;
    private System.Collections.Generic.List<UnityEngine.Object> 丛丕与一且上丛丛且;
    private System.Collections.Generic.List<CharacterInterfaceV2.与丕丁丏世七丝丆丛> 丅丂丄丈丂丁丏丛丐;
    private UnityEngine.Mesh 丑三丗丙丑世丆不丕;
    private UnityEngine.Mesh 丑丛上丒不丒下丒丞;
    private UnityEngine.Mesh 丐丝七丈上丏七东丅;
    private UnityEngine.Material[] 万丄丗不丞丕丘且不;
    private UnityEngine.Material[] 东丗丐上七丑丑丟不;
    private UnityEngine.Material[] 三下丗丙丞丛东三丌;
    private UnityEngine.Material[] 丒丅与与丅丛世丒三;
    private UnityEngine.Material[] 丒丆丛丕丌业丘世丞;
    private bool 丙丐丄丛东七丑万丙;
    private AnimationCoroutineRunner 丙业东丗七丅专丏丆;
    private UnityEngine.Vector3 丈与丈上丛丑丛丘三;
    private UnityEngine.Vector3 万丗丄万上丟丄丑丘;
    private UnityEngine.Vector3 一丐丝丌丙丁万下丘;
    private UnityEngine.Vector3 丆东丈丝上丘万丂丂;
    private UnityEngine.Vector3 丏丆不丕不东丟东三;
    private UnityEngine.Vector3 且丟丕丆且与且丞丄;
    private UnityEngine.Quaternion 世丕丁丆丆丂丄丘三;
    private UnityEngine.Quaternion 丁丂丐一世丝丒丆丘;
    private UnityEngine.Quaternion 丅一下三丕一万丆世;
    private UnityEngine.Quaternion 万丅丆万且三且世一;
    private UnityEngine.Quaternion 丝上东丁且丑丘世丘;
    private UnityEngine.Quaternion 丕且一丞丟丌且丑丟;
    private bool 丒丛丒专丒丐丂丝万;
    private UnityEngine.Vector3 七万上丌丅不丙丆丒;
    private UnityEngine.SkinnedMeshRenderer _defaultArmsRenderer;
    private System.Nullable<UnityEngine.Color> 丂丄一丗业丗丐万丏;
    
    // Properties
    internal bool 与丅丕丑丒丆丙一丗 { get; set; }
    internal bool 丑丐丆丗丙世丈丞丝 { get; set; }
    internal bool 丛业万丗丙下业丒东 { get; set; }
    internal bool 专丟丗三东丂丟丟业 { get; set; }
    internal bool 丅丝上丐丑三丆世且 { get; set; }
    internal bool 下丌丘丒丌七丐丙七 { set; }
    internal bool 东丌不丁万丙丞丌丛 { set; }
    internal bool 七丝丒丙与世丆丌丝 { set; }
    internal bool 丗不业业丁丟丒丙东 { set; }
    internal bool 丂与丈丅丐丈丁上业 { set; }
    internal bool 丛丝丕业下下东丄丞 { set; }
    internal bool 丅丂专丏丞东丝上丗 { set; }
    internal bool 丁丕丑丁专世丐丘丒 { get; }
    internal bool 业丏丏上上丞丅七丌 { get; }
    internal bool 丁丘丗丈七世三丘与 { get; set; }
    internal UnityEngine.GameObject 丘丂与丗丈丄丛丙与 { get; }
    internal UnityEngine.Transform 三丙丂丕七丞世上丏 { get; }
    internal CarShop 丝世丟丐丄丗丘不丄 { get; }
    internal GliderShop 且与上与丕丅丝丈丈 { get; }
    internal UnityEngine.GameObject 上丞与丁丁丟丁业丑 { get; }
    internal UnityEngine.GameObject 丟丈三丛丙丙丘丌丐 { get; }
    internal RoyaleAvatar 万丐丒丝下丑万丞不 { get; }
    internal UnityEngine.GameObject 丒丕丏东丘丙丄丛丘 { get; }
    internal UnityEngine.GameObject 三丅三丌丑上三丂且 { get; }
    internal GadgetArmoryItem 世丂一丝丞与丑丞丏 { get; }
    internal WeaponSounds 丕万业丙七不业三下 { get; }
    internal bool 丙丛下丒丆与丒丕与 { get; set; }
    internal bool 丛下丙丂丂丗万且丐 { get; set; }
    internal bool 丒丑丈丛丞一世专下 { get; set; }
    internal bool 丌业丟丈且丘业七丄 { get; set; }
    internal bool 一丂七业与丆丑丞丏 { get; set; }
    internal UnityEngine.Animation 下丗不丞丄业与世下 { get; }
    internal string 丕七业丕丟丑丑不七 { get; }
    internal CharacterInterfaceV2.丂丗专上丁丐且丝丆 业且丝与丗丘丟丂上 { get; set; }
    
    // Methods
    internal bool 世东丝丟上丅丞丛上()
    {
        return (bool)this.丌七丞丛东一不七丏;
    }
    internal void 丄丌丏三专丏丄丒丌(bool 丙业与丙丗丝不丈东)
    {
        this.丌七丞丛东一不七丏 = 丙业与丙丗丝不丈东;
        this.丒七丑一专丄丂世丈();
        this.三三丝丑丕丏丘业丒();
        this.三丑丐丅七丏丕不丒();
        this.丈丑三且丄丈丈与七();
        this.丌三业丞丛丞丛三丝();
    }
    internal bool 丆丝三丐丄丟三丈丙()
    {
        return (bool)this.一丕丗丁丘丈丆丄一;
    }
    internal void 不丑丂丏丐丟下万丑(bool 丙业与丙丗丝不丈东)
    {
        this.一丕丗丁丘丈丆丄一 = 丙业与丙丗丝不丈东;
        this.丞丙与丂丈丐丕专丛();
        this.丞七丑丗丄丐丐丞丒();
    }
    internal bool 丑丒丆且丈一丑且丑()
    {
        return (bool)this.丌丕丁丞丏丒丝三丘;
    }
    internal void 业丙丆七上业丈丕丐(bool 丙业与丙丗丝不丈东)
    {
        this.丌丕丁丞丏丒丝三丘 = 丙业与丙丗丝不丈东;
        this.上专丗丏业丘万一丈();
        this.专丅万丈丟丙丐丞上();
    }
    internal bool 丟上丑丁且丅不丈上()
    {
        return (bool)this.丐丟丛丒丁不三东丟;
    }
    internal void 丒三丞上专丌丟丞与(bool 丙业与丙丗丝不丈东)
    {
        this.丐丟丛丒丁不三东丟 = 丙业与丙丗丝不丈东;
        this.万丙丈世不丞万丗三();
    }
    internal bool 丆丝丘丆丑丞下业丞()
    {
        return (bool)this.丙万业丈丈东丁一业;
    }
    internal void 丘上丗丗且七丈一丕(bool 丙业与丙丗丝不丈东)
    {
        this.丙万业丈丈东丁一业 = 丙业与丙丗丝不丈东;
        this.丗丝万专丟三万三不();
        this.丞七丑丗丄丐丐丞丒();
    }
    internal void 丕不丙一丝丆下丗东(bool 丙业与丙丗丝不丈东)
    {
        this.不业丑丄丝丕上且丗 = 丙业与丙丗丝不丈东;
        this.不上七丗丄丂丆与业();
    }
    internal void 丟业不七丝七丐一丗(bool 丙业与丙丗丝不丈东)
    {
        this.丏专丌且丘丗丅丟丑 = 丙业与丙丗丝不丈东;
        this.且丕丞三业丕丁丒丘();
    }
    internal void 七丛下专丙丈万丈不(bool 丙业与丙丗丝不丈东)
    {
        this.万丑丟且丏且丏东一 = 丙业与丙丗丝不丈东;
        this.丛一七上丞三东丝业();
    }
    internal void 丁与世丕丑业丒丗业(bool 丙业与丙丗丝不丈东)
    {
        this.与丒丕丕七丁丟与不 = 丙业与丙丗丝不丈东;
        this.丁丅上且万业丕丈丘();
    }
    internal void 丟丌七上业丕丈东丌(bool 丙业与丙丗丝不丈东)
    {
        this.上与万丙丙且丙丕三 = 丙业与丙丗丝不丈东;
        this.下上丈丈专丟世丌丄();
    }
    internal void 不与不丗世丂丌丆丒(bool 丙业与丙丗丝不丈东)
    {
        this.且与丐丐丄丄下丐丟 = 丙业与丙丗丝不丈东;
        this.东丄一一下丏不万一();
    }
    internal void 丐上七丒丂丁丏丆丑(bool 丙业与丙丗丝不丈东)
    {
        this.与丂丒丆丏上专业丗 = 丙业与丙丗丝不丈东;
        this.丂万丏丏丈丕不丑与();
    }
    internal bool 丌丐丑三丒丞丗丛丝()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) == 0)
        {
                val_7 = 0;
            return (bool)(val_4.isExoskelet == true) ? 1 : 0;
        }
        
        val_6 = this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>();
        return (bool)(val_4.isExoskelet == true) ? 1 : 0;
    }
    internal bool 专丕丞丙上丙丐丁东()
    {
        var val_4;
        if(this.且业丛三世丞丂丛不() != 0)
        {
                return (bool)(val_1.useLowBodyByWeapon == true) ? 1 : 0;
        }
        
        val_4 = 0;
        return (bool)(val_1.useLowBodyByWeapon == true) ? 1 : 0;
    }
    internal bool 丅丂业丗三丁下丏七()
    {
        return (bool)this.业丅丅丟丛一万丑东;
    }
    internal void 业七不专丝丘且万丁(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                this.一丂丂丈丝一丟丞一();
        }
        
        this.业丅丅丟丛一万丑东 = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.GameObject 丐丌丐一上丛上丙丒()
    {
        return (UnityEngine.GameObject)this._simpleCharacter;
    }
    internal UnityEngine.Transform 丁丝一下丁不七丗一()
    {
        return (UnityEngine.Transform)this.hatPoint;
    }
    internal CarShop 丂丈丐且不世七丒丒()
    {
        var val_6;
        var val_7;
        val_6 = this;
        val_7 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  10)) == 0)
        {
                return (CarShop)0.GetComponent<CarShop>();
        }
        
        val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  10);
        if(val_6 != null)
        {
                var val_4 = (null == null) ? (val_6) : 0;
            return (CarShop)0.GetComponent<CarShop>();
        }
        
        return (CarShop)0.GetComponent<CarShop>();
    }
    internal GliderShop 丏业丛丘与丈业丁业()
    {
        var val_6;
        var val_7;
        val_6 = this;
        val_7 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8)) == 0)
        {
                return (GliderShop)0.GetComponent<GliderShop>();
        }
        
        val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8);
        if(val_6 != null)
        {
                var val_4 = (null == null) ? (val_6) : 0;
            return (GliderShop)0.GetComponent<GliderShop>();
        }
        
        return (GliderShop)0.GetComponent<GliderShop>();
    }
    internal UnityEngine.GameObject 丛业丈丙不丆丌丅丗()
    {
        var val_5 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3)) == 0)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3);
        if(val_3 == null)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
    }
    internal UnityEngine.GameObject 丐丁丟丏丄东不丘丒()
    {
        var val_5 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  13)) == 0)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  13);
        if(val_3 == null)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
    }
    internal RoyaleAvatar 且业丛三世丞丂丛不()
    {
        var val_6;
        var val_7;
        val_6 = this;
        val_7 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12)) == 0)
        {
                return (RoyaleAvatar)0.GetComponent<RoyaleAvatar>();
        }
        
        val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_6 != null)
        {
                var val_4 = (null == null) ? (val_6) : 0;
            return (RoyaleAvatar)0.GetComponent<RoyaleAvatar>();
        }
        
        return (RoyaleAvatar)0.GetComponent<RoyaleAvatar>();
    }
    internal UnityEngine.GameObject 七三丂万上丞万丞丆()
    {
        var val_5 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) == 0)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
        if(val_3 == null)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
    }
    internal UnityEngine.GameObject 丝丑万专丕丕丒七一()
    {
        var val_5 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) == 0)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1);
        if(val_3 == null)
        {
                return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
        }
        
        return (UnityEngine.GameObject)(null == null) ? (val_3) : 0;
    }
    internal GadgetArmoryItem 万丌丗三且丗丟丑丟()
    {
        var val_6;
        var val_7;
        val_6 = this;
        val_7 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9)) == 0)
        {
                return (GadgetArmoryItem)0.GetComponent<GadgetArmoryItem>();
        }
        
        val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9);
        if(val_6 != null)
        {
                var val_4 = (null == null) ? (val_6) : 0;
            return (GadgetArmoryItem)0.GetComponent<GadgetArmoryItem>();
        }
        
        return (GadgetArmoryItem)0.GetComponent<GadgetArmoryItem>();
    }
    internal WeaponSounds 且万丘丈上丏丟且业()
    {
        var val_4;
        UnityEngine.GameObject val_1 = this.丝丑万专丕丕丒七一();
        val_4 = 0;
        if(val_1 == 0)
        {
                return (WeaponSounds)val_1.GetComponent<WeaponSounds>();
        }
        
        return (WeaponSounds)val_1.GetComponent<WeaponSounds>();
    }
    internal bool 丄与业且丆丄一丕丘()
    {
        return (bool)this.<下丅上丈丗丛三丗丏>k__BackingField;
    }
    internal void 丗丂不丟七丐丈七业(bool 丙业与丙丗丝不丈东)
    {
        this.<下丅上丈丗丛三丗丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丝万丙丞丈丏七丐丝()
    {
        return (bool)this.<丐丑丛丁丏丛东丏丝>k__BackingField;
    }
    internal void 上东丐三业丙丙丒丕(bool 丙业与丙丗丝不丈东)
    {
        this.<丐丑丛丁丏丛东丏丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丞丁业下与丅一丌丄()
    {
        return (bool)this.<丕业丅丂上丄且丌丘>k__BackingField;
    }
    internal void 丆七万丂丛丛一业丒(bool 丙业与丙丗丝不丈东)
    {
        this.<丕业丅丂上丄且丌丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丘丄七丏丐一丞世丕()
    {
        return (bool)this.<丗丕丕七丒业万丑上>k__BackingField;
    }
    internal void 世丅三丈丐丒万丈万(bool 丙业与丙丗丝不丈东)
    {
        this.<丗丕丕七丒业万丑上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丏世丄丙丗丑三丂丘()
    {
        return (bool)this.<丁下丆与业丄丂丂丞>k__BackingField;
    }
    internal void 七丄且一丟丄丄丝丟(bool 丙业与丙丗丝不丈东)
    {
        this.<丁下丆与业丄丂丂丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Animation 丁丗丐丘丝不且与丞()
    {
        return (UnityEngine.Animation)this._animation;
    }
    internal string 世不业丂三七丗与丟()
    {
        return (string)this.丐专一丗上下丒丐丆;
    }
    internal static string 且丑丈东丅丐且与丕(丝东丗丞且不且上丙 丁丅丈丌丟世丗丗丟)
    {
        var val_2;
        if((丁丅丈丌丟世丗丗丟 - 1) <= 3)
        {
                val_2 = mem[130691072 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3];
            val_2 = 130691072 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3;
            return (string)val_2;
        }
        
        val_2 = "Glider_1";
        return (string)val_2;
    }
    internal CharacterInterfaceV2.丂丗专上丁丐且丝丆 丟丑七丂业丏丕与丁()
    {
        return (丂丗专上丁丐且丝丆)this.<丆三丅丈丈丂丗丙丒>k__BackingField;
    }
    internal void 丅丑世七丙东东丒丁(CharacterInterfaceV2.丂丗专上丁丐且丝丆 丙业与丙丗丝不丈东)
    {
        this.<丆三丅丈丈丂丗丙丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.上丛丌丆丑上七世三();
    }
    private void OnEnable()
    {
        this.丞丐丕丟世丕业丒丒();
        if(this.业丅丅丟丛一万丑东 != false)
        {
                this.一丂丂丈丝一丟丞一();
            this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏(), 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
        }
        
        this.世丗丁上丁东一东一();
        this.上东丘东丁丟东丕专();
        this.丒丁丒且专上丟业丈();
        this.业不丛不丞七丕东世(七不丐下丟专业万丅:  this.丐专一丗上下丒丐丆);
        this.东丆丆丛丞万丛丌丑();
    }
    private void Update()
    {
        this.丞丐丕丟世丕业丒丒();
        this.世丗丁上丁东一东一();
        this.上东丘东丁丟东丕专();
        this.丒丁丒且专上丟业丈();
        this.丌丕下业丂东丗丗一();
    }
    private void OnDisable()
    {
        Rilisoft.PetsManager.丝丅丑丆三与丛丟丞(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void CharacterInterfaceV2::三丞丟七丞与丘丘丞(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)));
        Rilisoft.PetsManager.与丄丐东丈丘下丐三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterInterfaceV2::一三丌丘丄丞专丏丏()));
    }
    private void OnDestroy()
    {
        丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<与丕丁丏世七丝丆丛>(七丐丅专且专七三丆:  new System.Action<与丕丁丏世七丝丆丛>(object:  this, method:  System.Void CharacterInterfaceV2::丗丁且丒万三丛丑丝(CharacterInterfaceV2.与丕丁丏世七丝丆丛 三丟东丕丄丄下下丑)));
    }
    private void 上丛丌丆丑上七世三()
    {
        if(this.丙丐丄丛东七丑万丙 != false)
        {
                return;
        }
        
        this.丛丐三不七丆七丈世(丙业与丙丗丝不丈东:  false);
        this.一丗世丄丟丆丁丑不();
        this.三世丕丝丐东丟一与();
        this.世万业丟丈丂丅下一();
        UnityEngine.Material[] val_1 = this.playerBodyRenderer.materials;
        this.万丄丗不丞丕丘且不 = val_1;
        this.丌丘上丌丘专丏丘丅(丑丆丙丐不七丙七下:  val_1);
        this.丙丐丄丛东七丑万丙 = true;
        this.专世丐丂丒上丄三丌 = this.playerBodyRenderer.sharedMesh;
        this.丅万且丒丙三丗不丑 = this.playerBodyRenderer.bones;
        this.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  this.playerBodyRenderer.material.mainTexture);
    }
    private void 一丗世丄丟丆丁丑不()
    {
        var val_6;
        System.Func<UnityEngine.Transform, UnityEngine.GameObject> val_8;
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_1.Add(item:  this.armorPoint);
        val_1.Add(item:  this.leftBootPoint);
        val_1.Add(item:  this.rightBootPoint);
        val_1.Add(item:  this.capePoint);
        val_1.Add(item:  this.hatPoint);
        val_1.Add(item:  this.maskPoint);
        val_1.Add(item:  this.gunPoint);
        val_1.Add(item:  this.pointArmRight);
        val_1.Add(item:  this.pointArmLeft);
        val_1.Add(item:  this.pointFlyingPet);
        val_1.Add(item:  this.pointGroundPet);
        val_1.Add(item:  this.pointFlyingPetArmory);
        val_1.Add(item:  this.pointGroundPetArmory);
        val_1.Add(item:  this.pointFlyingPetProfile);
        val_1.Add(item:  this.pointGroundPetProfile);
        val_1.Add(item:  this.flyPointDuelLeft);
        val_1.Add(item:  this.groundPointDuelLeft);
        val_1.Add(item:  this.flyPointDuelRight);
        val_1.Add(item:  this.groundPointDuelRight);
        val_1.Add(item:  this.carPoint);
        val_1.Add(item:  this._gliderPointTypeOnBack);
        val_1.Add(item:  this._gliderPointTypeStaying);
        val_1.Add(item:  this._gliderPointTypeFlying);
        val_1.Add(item:  this._gliderPointTypeSitting);
        val_1.Add(item:  this._hugeGadgetPoint);
        val_6 = null;
        val_6 = null;
        val_8 = CharacterInterfaceV2.<>c.<>9__117_0;
        if(val_8 == null)
        {
                System.Func<UnityEngine.Transform, UnityEngine.GameObject> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Func<UnityEngine.Transform, UnityEngine.GameObject>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject CharacterInterfaceV2.<>c::丘专下丘丏丘丈丆丆(UnityEngine.Transform 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__117_0 = val_8;
        }
        
        this.丕丏丌丂丙世一不丄 = System.Linq.Enumerable.ToArray<UnityEngine.GameObject>(source:  System.Linq.Enumerable.Select<UnityEngine.Transform, UnityEngine.GameObject>(source:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  val_1, second:  this._royalTrailPoints), selector:  val_3));
    }
    private void 三世丕丝丐东丟一与()
    {
        this.丌丘丗丐丘丅上丂丐 = new System.Collections.Generic.Dictionary<与丕丁丏世七丝丆丛, System.Collections.Generic.List<UnityEngine.Object>>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<与丕丁丏世七丝丆丛>());
        this.丞世丂上丏不世丒丅 = new System.Collections.Generic.Dictionary<与丕丁丏世七丝丆丛, System.String>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<与丕丁丏世七丝丆丛>());
        丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<与丕丁丏世七丝丆丛>(七丐丅专且专七三丆:  new System.Action<与丕丁丏世七丝丆丛>(object:  this, method:  System.Void CharacterInterfaceV2::不一下且不丌丌专丏(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑)));
    }
    private void 不一下且不丌丌专丏(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑)
    {
        this.丞世丂上丏不世丒丅.set_Item(key:  下丗丁丒丘东丂不丑, value:  System.String.alignConst);
        this.丌丘丗丐丘丅上丂丐.set_Item(key:  下丗丁丒丘东丂不丑, value:  new System.Collections.Generic.List<UnityEngine.Object>());
    }
    internal void 上丈一万东三东世东(UnityEngine.Texture 丂丒丘丅专丗丂世丛)
    {
        UnityEngine.Texture val_10;
        var val_11;
        与丕丁丏世七丝丆丛 val_12;
        val_10 = 丂丒丘丅专丗丂世丛;
        CharacterInterfaceV2.丘丒丘世万丁且下丈 val_1 = new CharacterInterfaceV2.丘丒丘世万丁且下丈();
        if(val_1 != null)
        {
                val_11 = val_1;
            .丂丒丘丅专丗丂世丛 = val_10;
        }
        else
        {
                val_11 = 16;
            mem[16] = val_10;
            val_10 = mem[16];
        }
        
        if(val_10 == 0)
        {
                val_12 = 2;
        }
        else
        {
                this.丆丑丟世丟丒业丛东();
            this.丌丘上丌丘专丏丘丅(丑丆丙丐不七丙七下:  this.万丄丗不丞丕丘且不);
            this.playerBodyRenderer.enabled = true;
            this.playerHeadRenderer.enabled = true;
            this.playerRightLegRenderer.enabled = true;
            this.playerLeftLegRenderer.enabled = true;
            this.royaleAvatarBodyRenderer.enabled = false;
            this.royaleAvatarHeadRenderer.enabled = false;
            this.royaleAvatarLegsRenderer.enabled = false;
            this.royaleAvatarArmsRenderer.enabled = false;
            val_11.filterMode = 0;
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.Material>(丌丛丏业世丄丞三丌:  this.万丄丗不丞丕丘且不, 七丐丅专且专七三丆:  new System.Action<UnityEngine.Material>(object:  val_1, method:  System.Void CharacterInterfaceV2.丘丒丘世万丁且下丈::丙上七丁丒业丐七丁(UnityEngine.Material 东丝丄丝丙专丘三丏)));
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  mem[16].name)) != false)
        {
                string val_6 = mem[16].name;
        }
        
            val_10 = UnityEngine.Random.Range(min:  0, max:  2147483647).ToString()(UnityEngine.Random.Range(min:  0, max:  2147483647).ToString()) + "s";
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  2, 丕丁下丌不万丅丞丛:  val_10, 丝丙丌七丑且丐丄上:  mem[16]);
            this.下七丝一专丒丂丛丅();
            this.一丂世丏丞七丆丁万();
            this.丙丞丒一上丞下丐丁();
            val_12 = 12;
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  val_12);
    }
    internal void 三丞丕丝业东上丅且(string 丕丁下丌不万丅丞丛)
    {
        PGCompany.丘三丏丌丗丒万丏丈 val_2 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞丅上丏丂且下丅与:  丕丁下丌不万丅丞丛);
        if(val_2 == null)
        {
            goto label_2;
        }
        
        string val_4 = val_2.上丄丂丄丙丗丛丌丟().一丄专三丒上丆万世();
        if((System.String.op_Equality(a:  val_4, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  14))) == false)
        {
            goto label_4;
        }
        
        return;
        label_2:
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  14))) != false)
        {
                this.丝一下丌下丆丂丘不();
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  14);
        this._skinCharacter.SetActive(value:  true);
        return;
        label_4:
        this._skinCharacter.SetActive(value:  false);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  14, 丕丁下丌不万丅丞丛:  val_4, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_10 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丅七丐且丕下东丏与(丒丘丏上丙丟丑丕丈:  val_4));
    }
    private System.Collections.IEnumerator 丅七丐且丕下东丏与(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丄丐七丌丐与专丝丟 val_1 = new CharacterInterfaceV2.丄丐七丌丐与专丝丟();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丟丐丈丅且一丒与丝(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        this.丝一下丌下丆丂丘不();
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        this.丗丟不上丕不三丛丗();
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        GraffitiInLobby val_3 = val_2.GetComponent<GraffitiInLobby>();
        if(val_3 != 0)
        {
                val_3.Deactivate();
        }
        
        val_2.transform.parent = this._graffitiPoint;
        UnityEngine.Vector3 val_7 = this._graffitiPoint.position;
        val_2.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  14, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_2);
        this._skinCharacter.SetActive(value:  false);
    }
    internal void 丟且丏业丈七七三与(string 丕丁下丌不万丅丞丛)
    {
        string val_2 = this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  9);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_2)) != false)
        {
                this.丝一下丌下丆丂丘不();
        }
        
            this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
            this._skinCharacter.SetActive(value:  true);
            this.丐丝七丈上丏七东丅 = 0;
            return;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  val_2)) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_6 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.与丄一世专丝丒丐丝(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    internal void 丛丐三不七丆七丈世(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.graffitiWall, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    private System.Collections.IEnumerator 与丄一世专丝丒丐丝(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丞丅丄专丅丝丌丂上 val_1 = new CharacterInterfaceV2.丞丅丄专丅丝丌丂上(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 三三万专丅与丘三丏(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.GameObject val_43;
        UnityEngine.Animation val_44;
        float val_49;
        float val_50;
        bool val_51;
        var val_52;
        System.Action<UnityEngine.Animation> val_54;
        var val_55;
        var val_56;
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
        this._skinCharacter.SetActive(value:  true);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        this.丗丟不上丕不三丛丗();
        val_43 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        GadgetArmoryItem val_3 = val_43.GetComponent<GadgetArmoryItem>();
        if(this.丐丄丅丂与丗丑三丑 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丐丄丅丂与丗丑三丑);
            this.丐丄丅丂与丗丑三丑 = 0;
        }
        
        if(val_3.isReplaceOnlyHands != false)
        {
                this._skinCharacter.SetActive(value:  true);
            val_43.transform.parent = this.gunPoint;
            UnityEngine.Vector3 val_7 = this.gunPoint.position;
            val_43.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            val_43.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_43.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_44 = val_43.transform;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            val_49 = val_13.x;
            val_50 = val_13.z;
            val_44.localRotation = new UnityEngine.Quaternion() {x = val_49, y = val_13.y, z = val_50, w = val_13.w};
            val_51 = val_3.isReplaceOnlyMask;
        }
        else
        {
                val_51 = val_3;
            if(val_3.isReplaceOnlyMask != false)
        {
                val_43.transform.parent = this.maskPoint;
            UnityEngine.Vector3 val_16 = this.maskPoint.position;
            val_43.transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            val_43.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            val_43.transform.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            val_44 = val_43.transform;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
            val_49 = val_22.x;
            val_50 = val_22.z;
            val_44.localRotation = new UnityEngine.Quaternion() {x = val_49, y = val_22.y, z = val_50, w = val_22.w};
        }
        else
        {
                this._skinCharacter.SetActive(value:  false);
            val_43.transform.parent = this._hugeGadgetPoint;
            UnityEngine.Vector3 val_25 = this._hugeGadgetPoint.position;
            val_43.transform.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
            val_43.transform.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.zero;
            val_43.transform.localPosition = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            val_44 = val_43.transform;
            UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.identity;
            val_49 = val_31.x;
            val_50 = val_31.z;
            val_44.localRotation = new UnityEngine.Quaternion() {x = val_49, y = val_31.y, z = val_50, w = val_31.w};
            this.丐丄丅丂与丗丑三丑 = val_43;
        }
        
        }
        
        if((val_3 + 25) == 0)
        {
                val_44 = val_3.GetComponent<UnityEngine.Animation>();
            val_52 = null;
            val_52 = null;
            val_54 = CharacterInterfaceV2.<>c.<>9__127_0;
            if(val_54 == null)
        {
                System.Action<UnityEngine.Animation> val_33 = null;
            val_54 = val_33;
            val_33 = new System.Action<UnityEngine.Animation>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CharacterInterfaceV2.<>c::丂丂丘丂丙丁丗丞一(UnityEngine.Animation 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__127_0 = val_54;
        }
        
            UnityEngine.Animation val_34 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<UnityEngine.Animation>(丞下万上三丘上与专:  val_44, 丌专业且丛丏丞丝且:  val_33);
            val_3.上万世丟丙丈东下丂();
            this.丐丝七丈上丏七东丅 = val_3.renderArms.sharedMesh;
        }
        
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_43, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_43);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_43);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12))) != false)
        {
                this.丈丑三且丄丈丈与七();
        }
        else
        {
                this.下七丝一专丒丂丛丅();
        }
        
        this.且丕丞三业丕丁丒丘();
        this.业丘丝丁丐丙丕一丐();
        if((val_3 + 25) != 0)
        {
                val_55 = null;
            val_55 = null;
            this.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        
        if(this.丂丄一丗业丗丐万丏.HasValue != false)
        {
                this.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_49, g = val_31.y, b = val_50, a = val_31.w});
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
        if((val_3 + 25) == 0)
        {
            goto label_84;
        }
        
        val_43 = 1152921505286238208;
        val_56 = null;
        val_56 = null;
        if((System.String.op_Equality(a:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1), b:  WeaponManager.业丝丛丂三丄丁与丁)) == true)
        {
            goto label_87;
        }
        
        label_84:
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
        label_87:
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "Idle", 丆下丈丗不丄万丄丏:  false);
    }
    private void 且丕丞三业丕丁丒丘()
    {
        if(this.丏专丌且丘丗丅丟丑 == false)
        {
                return;
        }
        
        if(this.万丌丗三且丗丟丑丟() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丅丝丅三丅与专专丒(丑丁丆丆专且丝不丙:  this.万丌丗三且丗丟丑丟());
        this.丏专丌且丘丗丅丟丑 = false;
    }
    internal void 世丕丈丑丌丕丁世不(string 丕丁下丌不万丅丞丛)
    {
        string val_4;
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  "ShopStubForClanWeaponsLockedByDivision")) == false)
        {
            goto label_1;
        }
        
        val_4 = 丕丁下丌不万丅丞丛;
        goto label_2;
        label_1:
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛);
        if(val_2 == null)
        {
            goto label_5;
        }
        
        val_4 = val_2.三与丛丑且丐丈业丌();
        label_2:
        this.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_4);
        return;
        label_5:
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
        this.丑丛上丒不丒下丒丞 = 0;
        this.丐专一丗上下丒丐丆 = System.String.alignConst;
    }
    internal void 丟丞丙一丄世专丟丐(string 丟丈一下东业一丝丆)
    {
        string val_2 = this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丟丈一下东业一丝丆)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_2)) != false)
        {
                this.丝一下丌下丆丂丘不();
        }
        
            this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
            this.丑丛上丒不丒下丒丞 = 0;
            this.丐专一丗上下丒丐丆 = System.String.alignConst;
            return;
        }
        
        if((System.String.op_Equality(a:  丟丈一下东业一丝丆, b:  val_2)) != false)
        {
                this.丒丝且丝丙丅与丘丑();
            return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  1, 丕丁下丌不万丅丞丛:  丟丈一下东业一丝丆, 丝丙丌七丑且丐丄上:  0);
        this.丐专一丗上下丒丐丆 = System.String.alignConst;
        UnityEngine.Coroutine val_6 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丂专丈丏丗丄丐七与(丒丘丏上丙丟丑丕丈:  丟丈一下东业一丝丆));
    }
    private System.Collections.IEnumerator 丂专丈丏丗丄丐七与(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丘下丝丆与丆丝专世 val_1 = new CharacterInterfaceV2.丘下丝丆与丆丝专世(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丂丂丏世丕一丟丘丙(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        string val_39;
        var val_40;
        System.Action<UnityEngine.GameObject> val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        val_39 = 丒丘丏上丙丟丑丕丈;
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        this.丗丟不上丕不三丛丗();
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_2.transform.parent = this.gunPoint;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_7 = this.gunPoint.position;
        val_2.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        WeaponSounds val_12 = val_2.GetComponent<WeaponSounds>();
        var val_13 = (val_12.isExoskelet == true) ? 0f : 0.04f;
        this.gunPoint.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12._innerPars.FindArms();
        InnerWeaponPars val_15 = val_12._innerPars;
        if(val_15.renderArms != 0)
        {
                InnerWeaponPars val_17 = val_12._innerPars;
            this.丑丛上丒不丒下丒丞 = val_17.renderArms.sharedMesh;
        }
        
        if((this.<丁下丆与业丄丂丂丞>k__BackingField) != false)
        {
                val_40 = null;
            val_40 = null;
            val_42 = CharacterInterfaceV2.<>c.<>9__132_0;
            if(val_42 == null)
        {
                System.Action<UnityEngine.GameObject> val_21 = null;
            val_42 = val_21;
            val_21 = new System.Action<UnityEngine.GameObject>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CharacterInterfaceV2.<>c::丌上丙上丘丂丕东丁(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__132_0 = val_42;
        }
        
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "GunFlash"), 七丐丅专且专七三丆:  val_21);
        }
        
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  1, 丕丁下丌不万丅丞丛:  val_39, 丝丙丌七丑且丐丄上:  val_2);
        this.万丙丈世不丞万丗三();
        this.丒丝且丝丙丅与丘丑();
        this.业不丛不丞七丕东世(七不丐下丟专业万丅:  this.丐专一丗上下丒丐丆);
        this.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  this.一业东三三且丙丐丘);
        this.不上七丗丄丂丆与业();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12))) != false)
        {
                this.三丑丐丅七丏丕不丒();
        }
        else
        {
                this.丙丞丒一上丞下丐丁();
        }
        
        val_43 = null;
        val_43 = null;
        if((System.String.op_Inequality(a:  val_12.Tag, b:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与)) == false)
        {
            goto label_49;
        }
        
        label_59:
        if(GameConnect.业丗与丈丁东下一丛() == false)
        {
            goto label_52;
        }
        
        val_44 = 1;
        goto label_53;
        label_49:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11))) == false)
        {
            goto label_60;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) == true)
        {
            goto label_59;
        }
        
        goto label_60;
        label_52:
        val_44 = 0;
        label_53:
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "Idle", 丆下丈丗不丄万丄丏:  false);
        label_60:
        if(this.丂丄一丗业丗丐万丏.HasValue != false)
        {
                this.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = val_11.w});
        }
        
        val_45 = null;
        val_45 = null;
        if((System.String.op_Inequality(a:  val_12.Tag, b:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与)) != false)
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
        }
        
        val_46 = null;
        val_46 = null;
        if((System.String.op_Inequality(a:  val_12.Tag, b:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与)) != false)
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
        }
        
        val_39 = this.万丌丗三且丗丟丑丟();
        if(val_39 == 0)
        {
            goto label_72;
        }
        
        val_39 = this.万丌丗三且丗丟丑丟();
        if(val_37.isReplaceOnlyMask == false)
        {
            goto label_72;
        }
        
        val_47 = null;
        val_47 = null;
        if((System.String.op_Equality(a:  val_12.Tag, b:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与)) == true)
        {
            goto label_75;
        }
        
        label_72:
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
        label_75:
        if((this.<丐丑丛丁丏丛东丏丝>k__BackingField) != false)
        {
                this.<丐丑丛丁丏丛东丏丝>k__BackingField = false;
        }
        else
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
        }
        
        this._skinCharacter.SetActive(value:  true);
        this.丌三业丞丛丞丛三丝();
    }
    private System.Collections.IEnumerator 丈不丆丁丕丘丟一专(float 丑丗丘与丈不七东丛)
    {
        CharacterInterfaceV2.丑业丑丙业三一上丄 val_1 = new CharacterInterfaceV2.丑业丑丙业三一上丄(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丑丗丘与丈不七东丛 = 丑丗丘与丈不七东丛;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 不上七丗丄丂丆与业()
    {
        if(this.不业丑丄丝丕上且丗 == false)
        {
                return;
        }
        
        if(this.丝丑万专丕丕丒七一() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.东丕三丞丌丐专丗丝(且丄下不丑丁丂三丗:  this.丝丑万专丕丕丒七一());
        this.不业丑丄丝丕上且丗 = false;
    }
    internal void 业不丛不丞七丕东世(string 七不丐下丟专业万丅)
    {
        this.丐专一丗上下丒丐丆 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  七不丐下丟专业万丅)) != true) ? "Profile" : 七不丐下丟专业万丅;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) == 0)
        {
                return;
        }
        
        UnityEngine.Animation val_9 = this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>().GetComponent<WeaponSounds>().丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        if(UnityEngine.Time.timeScale != 0f)
        {
            goto label_10;
        }
        
        if(this.丙业东丗七丅专丏丆 != 0)
        {
            goto label_13;
        }
        
        UnityEngine.Debug.LogError(message:  "Animation runner is not setted for character interface");
        return;
        label_10:
        if(val_9 == null)
        {
            goto label_16;
        }
        
        bool val_12 = val_9.Play(animation:  this.丐专一丗上下丒丐丆);
        goto label_17;
        label_13:
        this.丙业东丗七丅专丏丆.StopAllCoroutines();
        if(this.丙业东丗七丅专丏丆.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丙业东丗七丅专丏丆.StartPlay(丆不丝丝上一丞七业:  val_9, 七不丐下丟专业万丅:  this.丐专一丗上下丒丐丆, 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  0);
        return;
        label_16:
        bool val_15 = val_9.Play(animation:  this.丐专一丗上下丒丐丆);
        label_17:
        val_9.Sample();
    }
    internal void 且一丞丗三一丄万丝(PGCompany.丟丝世万东万丆丟上 三丕上下丗丘丌专丒)
    {
        this.一业东三三且丙丐丘 = 三丕上下丗丘丌专丒;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) == 0)
        {
                return;
        }
        
        this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>().上丈一万东三东世东(三丕上下丗丘丌专丒:  三丕上下丗丘丌专丒);
        this.一业东三三且丙丐丘 = 0;
    }
    internal void 上丛与丅丏丌上丁丞(string 丙丄不丈专丕与万万)
    {
        var val_12;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙丄不丈专丕与万万)) != true)
        {
                if((System.String.op_Equality(a:  丙丄不丈专丕与万万, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == false)
        {
            goto label_6;
        }
        
        }
        
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  7);
        this.三三丝丑丕丏丘业丒();
        this.三丑丐丅七丏丕不丒();
        this.丈丑三且丄丈丈与七();
        return;
        label_6:
        if((System.String.op_Equality(a:  丙丄不丈专丕与万万, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  7))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  7, 丕丁下丌不万丅丞丛:  丙丄不丈专丕与万万, 丝丙丌七丑且丐丄上:  0);
        val_12 = null;
        val_12 = null;
        UnityEngine.Coroutine val_11 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丆世一与丏丟丆丑丅(丙丄不丈专丕与万万:  丙丄不丈专丕与万万, 丒丌丆三与丐三七丑:  (东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true) ? "Armor_Low" : (((System.String.op_Equality(a:  丙丄不丈专丕与万万, b:  "ShopStubForClanArmorLockedByDivision")) != true) ? "ShopStubForClanArmorLockedByDivision" : System.IO.Path.Combine(path1:  "Armor", path2:  丙丄不丈专丕与万万))));
    }
    private System.Collections.IEnumerator 丆世一与丏丟丆丑丅(string 丙丄不丈专丕与万万, string 丒丌丆三与丐三七丑)
    {
        CharacterInterfaceV2.丑丝丈下下丄丌丞下 val_1 = new CharacterInterfaceV2.丑丝丈下下丄丌丞下(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丙丄不丈专丕与万万 = 丙丄不丈专丕与万万;
        }
        else
        {
                mem[48] = this;
            mem[56] = 丙丄不丈专丕与万万;
        }
        
        .丒丌丆三与丐三七丑 = 丒丌丆三与丐三七丑;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丘东丑三丞丈丄丂丘(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丙丄不丈专丕与万万)
    {
        var val_17;
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  7);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_17 = null;
        val_17 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                UnityEngine.SkinnedMeshRenderer val_3 = val_2.GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>();
            if(val_3 != 0)
        {
                val_3.material = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "LowPolyArmorMaterials/"("LowPolyArmorMaterials/") + 丙丄不丈专丕与万万 + "_low");
        }
        
        }
        
        val_2.transform.parent = this.armorPoint.transform;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  7, 丕丁下丌不万丅丞丛:  丙丄不丈专丕与万万, 丝丙丌七丑且丐丄上:  val_2);
        this.丒丝且丝丙丅与丘丑();
        this.业丘丝丁丐丙丕一丐();
        this.三丑丐丅七丏丕不丒();
        this.丈丑三且丄丈丈与七();
        this.三三丝丑丕丏丘业丒();
        this.丒七丑一专丄丂世丈();
        this.东丄一一下丏不万一();
        this.丌三业丞丛丞丛三丝();
    }
    private void 东丄一一下丏不万一()
    {
        if(this.且与丐丐丄丄下丐丟 == false)
        {
                return;
        }
        
        if(this.七三丂万上丞万丞丆() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丝丑东与丑丕丂丑丝(丝三丁东丈丒世丅业:  this.七三丂万上丞万丞丆());
        this.且与丐丐丄丄下丐丟 = false;
    }
    private void 丒七丑一专丄丂世丈()
    {
        var val_5;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                var val_3 = (null == null) ? (val_1) : 0;
        }
        
        if(this.丌七丞丛东一不七丏 != false)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = 1;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  0.transform, 丈七与世丏丕业世丙:  true);
    }
    internal void 三三丝丑丕丏丘业丒()
    {
        UnityEngine.Object val_20;
        UnityEngine.Object val_21;
        UnityEngine.Object val_22;
        var val_23;
        if((System.String.op_Equality(a:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12), b:  "ShopStubForClanAvatarLockedByDivision")) != false)
        {
                this.royaleAvatarBodyRenderer.enabled = true;
            this.playerBodyRenderer.enabled = false;
            return;
        }
        
        val_20 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) != 0)
        {
                UnityEngine.Object val_5 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
            if(val_5 != null)
        {
                var val_6 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        }
        
        UnityEngine.Object val_7 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        val_22 = 0;
        if(val_21 != 0)
        {
                val_22 = val_21.GetComponent<RoyaleAvatar>();
        }
        
        if((val_22 != 0) && ((this.且万丘丈上丏丟且业() != 0) && (val_10.useLowBodyByWeapon != false)))
        {
                val_23 = this.且万丘丈上丏丟且业().丙七丟丕且丒丅丟丅() ^ 1;
        }
        else
        {
                val_23 = 1;
        }
        
        if(val_22 == 0)
        {
            goto label_34;
        }
        
        if(val_20 != 0)
        {
            goto label_30;
        }
        
        if((val_23 & 1) != 0)
        {
            goto label_31;
        }
        
        goto label_34;
        label_30:
        if((this.丌七丞丛东一不七丏 == false) || ((val_23 ^ 1 & 1) != 0))
        {
            goto label_34;
        }
        
        label_31:
        this.royaleAvatarBodyRenderer.enabled = true;
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  true, 丑丅世丏与丁丝丒丏:  this.royaleAvatarBodyRenderer.bones);
        this.playerBodyRenderer.enabled = false;
        goto label_38;
        label_34:
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  false, 丑丅世丏与丁丝丒丏:  this.royaleAvatarBodyRenderer.bones);
        this.royaleAvatarBodyRenderer.enabled = false;
        this.playerBodyRenderer.enabled = true;
        this.playerBodyRenderer.sharedMesh = this.专世丐丂丒上丄三丌;
        val_22 = this.丅万且丒丙三丗不丑;
        this.playerBodyRenderer.bones = val_22;
        label_38:
        this.万丙丈世不丞万丗三();
    }
    private void 丞七丑丗丄丐丐丞丒()
    {
        UnityEngine.Object val_20;
        UnityEngine.Object val_21;
        UnityEngine.Object val_22;
        UnityEngine.Object val_23;
        UnityEngine.SkinnedMeshRenderer val_24;
        var val_25;
        if((System.String.op_Equality(a:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12), b:  "ShopStubForClanAvatarLockedByDivision")) == false)
        {
            goto label_1;
        }
        
        this.royaleAvatarHeadRenderer.enabled = true;
        goto label_3;
        label_1:
        val_20 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  4)) != 0)
        {
                UnityEngine.Object val_5 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  4);
            if(val_5 != null)
        {
                var val_6 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        }
        
        val_21 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3)) != 0)
        {
                UnityEngine.Object val_9 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3);
            if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
        UnityEngine.Object val_11 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_11 != null)
        {
                var val_12 = (null == 1152921504834002944) ? (val_11) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        val_23 = 0;
        if(val_22 != 0)
        {
                val_23 = val_22.GetComponent<RoyaleAvatar>();
        }
        
        if(val_23 == 0)
        {
            goto label_30;
        }
        
        if(val_20 != 0)
        {
                if(this.丙万业丈丈东丁一业 == false)
        {
            goto label_30;
        }
        
        }
        
        if(val_21 != 0)
        {
                if(this.一丕丗丁丘丈丆丄一 == false)
        {
            goto label_30;
        }
        
        }
        
        this.royaleAvatarHeadRenderer.enabled = true;
        UnityEngine.Transform[] val_18 = this.royaleAvatarHeadRenderer.bones;
        this.专丗万丙且丁丞东业(三业丂业不丐世上丛:  0);
        label_3:
        val_24 = this.playerHeadRenderer;
        val_25 = 0;
        goto label_34;
        label_30:
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  false, 丑丅世丏与丁丝丒丏:  this.royaleAvatarHeadRenderer.bones);
        this.royaleAvatarHeadRenderer.enabled = false;
        val_24 = this.playerHeadRenderer;
        val_25 = 1;
        label_34:
        val_24.enabled = true;
    }
    internal void 专丗万丙且丁丞东业(UnityEngine.Transform[] 三业丂业不丐世上丛)
    {
        UnityEngine.Object val_14;
        UnityEngine.Object val_15;
        bool val_16;
        val_14 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  4)) != 0)
        {
                UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  4);
            if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        }
        
        val_15 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3)) != 0)
        {
                UnityEngine.Object val_7 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3);
            if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        }
        
        if(val_14 != 0)
        {
                var val_10 = (this.丙万业丈丈东丁一业 == true) ? 1 : 0;
        }
        else
        {
                val_16 = 1;
        }
        
        if(val_15 != 0)
        {
                val_16 = val_16 & ((this.一丕丗丁丘丈丆丄一 == true) ? 1 : 0);
        }
        
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  val_16, 丑丅世丏与丁丝丒丏:  this.royaleAvatarHeadRenderer.bones);
    }
    private void 丂七丒与丄丏丟业丂(bool 丙业与丙丗丝不丈东, UnityEngine.Transform[] 丑丅世丏与丁丝丒丏)
    {
        var val_3;
        var val_4;
        UnityEngine.Object val_6;
        var val_20;
        var val_21;
        val_20 = 丑丅世丏与丁丝丒丏;
        List.Enumerator<T> val_1 = this.effectObjects.GetEnumerator();
        label_31:
        if(((-471952992) & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
        val_21 = 0;
        goto label_3;
        label_25:
        val_21 = 1;
        label_3:
        if(val_21 >= 丑丅世丏与丁丝丒丏.Length)
        {
            goto label_31;
        }
        
        UnityEngine.Transform val_20 = val_20[1];
        if((val_3 & 255) == false)
        {
            goto label_7;
        }
        
        if((val_6 == 0) || ((RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_6.parent.name, 丙丁不上丐丏丁一丏:  false).Equals(value:  RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_20.name, 丙丁不上丐丏丁一丏:  false))) == false))
        {
            goto label_25;
        }
        
        goto label_18;
        label_7:
        if((val_6 == 0) || (val_6.parent != val_20))
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_6, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        goto label_31;
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_6, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        goto label_31;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丐丘万丆丂万丛丂万(bool 丙业与丙丗丝不丈东)
    {
        var val_4;
        UnityEngine.Object val_6;
        bool val_9;
        List.Enumerator<T> val_1 = this.effectObjects.GetEnumerator();
        val_9 = 丙业与丙丗丝不丈东;
        label_8:
        if(((-471734592) & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_5 = val_4.RemoteEndpoint;
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_6, 丏业丟一东丂东丘丛:  val_9);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 专丅万丈丟丙丐丞上()
    {
        UnityEngine.Object val_15;
        UnityEngine.Object val_16;
        UnityEngine.Object val_17;
        UnityEngine.SkinnedMeshRenderer val_18;
        var val_19;
        if((System.String.op_Equality(a:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12), b:  "ShopStubForClanAvatarLockedByDivision")) == false)
        {
            goto label_1;
        }
        
        this.royaleAvatarLegsRenderer.enabled = true;
        goto label_3;
        label_1:
        val_15 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  5)) != 0)
        {
                UnityEngine.Object val_5 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  5);
            if(val_5 != null)
        {
                var val_6 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        }
        
        UnityEngine.Object val_7 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
        val_17 = 0;
        if(val_16 != 0)
        {
                val_17 = val_16.GetComponent<RoyaleAvatar>();
        }
        
        if(val_17 == 0)
        {
            goto label_21;
        }
        
        if(val_15 != 0)
        {
                if(this.丌丕丁丞丏丒丝三丘 == false)
        {
            goto label_21;
        }
        
        }
        
        this.royaleAvatarLegsRenderer.enabled = true;
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  true, 丑丅世丏与丁丝丒丏:  this.royaleAvatarLegsRenderer.bones);
        label_3:
        this.playerLeftLegRenderer.enabled = false;
        val_18 = this.playerRightLegRenderer;
        val_19 = 0;
        goto label_26;
        label_21:
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  false, 丑丅世丏与丁丝丒丏:  this.royaleAvatarLegsRenderer.bones);
        this.royaleAvatarLegsRenderer.enabled = false;
        this.playerLeftLegRenderer.enabled = true;
        val_18 = this.playerRightLegRenderer;
        val_19 = 1;
        label_26:
        val_18.enabled = true;
    }
    private void 丒丝且丝丙丅与丘丑()
    {
        UnityEngine.Object val_9;
        UnityEngine.Transform val_10;
        UnityEngine.Transform val_11;
        val_9 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) != 0)
        {
                val_9 = this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>();
        }
        
        if(val_9 != 0)
        {
                val_10 = val_9.丛丑丂丌与丗东下专();
        }
        else
        {
                val_10 = this.pointArmLeft;
        }
        
        if(val_9 != 0)
        {
                val_11 = val_9.丘万专丌丕与上丅丁();
        }
        else
        {
                val_11 = this.pointArmRight;
        }
        
        this.丑丌丑丗丛丂丈三丁(丈丂丕下丏丈丞丗业:  val_10, 丂丌丌丛丆丆丙丌丈:  val_11);
    }
    private void 业丘丝丁丐丙丕一丐()
    {
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9)) != 0)
        {
                UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9);
            if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        
            0 = 0.GetComponent<GadgetArmoryItem>();
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if(val_5.isReplaceOnlyHands == false)
        {
                return;
        }
        
        this.丑丌丑丗丛丂丈三丁(丈丂丕下丏丈丞丗业:  (0 == 0) ? val_5.LeftArmorHand : this.pointArmLeft, 丂丌丌丛丆丆丙丌丈:  (0 == 0) ? val_5.RightArmorHand : this.pointArmRight);
    }
    private void 丑丌丑丗丛丂丈三丁(UnityEngine.Transform 丈丂丕下丏丈丞丗业, UnityEngine.Transform 丂丌丌丛丆丆丙丌丈)
    {
        UnityEngine.Object val_20;
        UnityEngine.Object val_21;
        val_20 = 丈丂丕下丏丈丞丗业;
        val_21 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) != 0)
        {
                UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
            if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        }
        
        if(val_21 == 0)
        {
                return;
        }
        
        if((val_21.transform.GetChild(index:  0).GetComponent<ArmorRefs>()) == 0)
        {
                return;
        }
        
        if(val_8.leftBone != 0)
        {
                if(val_20 != 0)
        {
                val_8.leftBone.parent = val_20;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_8.leftBone.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            val_8.leftBone.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_8.leftBone.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        }
        
        }
        
        val_20 = val_8.rightBone;
        if(val_20 == 0)
        {
                return;
        }
        
        if(丂丌丌丛丆丆丙丌丈 == 0)
        {
                return;
        }
        
        val_8.rightBone.parent = 丂丌丌丛丆丆丙丌丈;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        val_8.rightBone.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.identity;
        val_8.rightBone.localRotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        val_8.rightBone.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    private void 丝一下丌下丆丂丘不()
    {
        if(this.armorPoint.childCount < 1)
        {
                return;
        }
        
        if((this.armorPoint.GetChild(index:  0).GetChild(index:  0).GetComponent<ArmorRefs>()) == 0)
        {
                return;
        }
        
        if(val_4.leftBone != 0)
        {
                val_4.leftBone.SetParent(parent:  this.armorPoint.GetChild(index:  0).GetChild(index:  0), worldPositionStays:  true);
        }
        
        if(val_4.rightBone == 0)
        {
                return;
        }
        
        val_4.rightBone.SetParent(parent:  this.armorPoint.GetChild(index:  0).GetChild(index:  0), worldPositionStays:  true);
    }
    internal void 丘丄丏世丒上东丘丒(string 丕丁下丌不万丅丞丛)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑())) == false)
        {
            goto label_6;
        }
        
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  3);
        this.丞七丑丗丄丐丐丞丒();
        return;
        label_6:
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  3))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  3, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_7 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丈丂万丙丘丛世丄业(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丈丂万丙丘丛世丄业(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丁七七丂上三丂丐丛 val_1 = new CharacterInterfaceV2.丁七七丂上三丂丐丛();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丏专丛且丗丐丂丒丕(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  3);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_2.transform.parent = this.hatPoint.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        if(this.transform.parent != 0)
        {
                Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer);
        }
        
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  3, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_2);
        this.丞七丑丗丄丐丐丞丒();
        this.丞丙与丂丈丐丕专丛();
        this.下上丈丈专丟世丌丄();
    }
    private void 丞丙与丂丈丐丕专丛()
    {
        var val_5;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  3);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                var val_3 = (null == null) ? (val_1) : 0;
        }
        
        if(this.一丕丗丁丘丈丆丄一 != false)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = 1;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.下丈三丙丙一不世丌(丅万专世丈丕丑丗丘:  0.transform, 丈七与世丏丕业世丙:  true);
    }
    private void 下上丈丈专丟世丌丄()
    {
        if(this.上与万丙丙且丙丕三 == false)
        {
                return;
        }
        
        if(this.丛业丈丙不丆丌丅丗() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丝丑东与丑丕丂丑丝(丝三丁东丈丒世丅业:  this.丛业丈丙不丆丌丅丗());
        this.上与万丙丙且丙丕三 = false;
    }
    internal void 丑丞丟丁东丂三与丁(string 丕丁下丌不万丅丞丛)
    {
        this.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 三丆业丘丑万丘世下:  0);
    }
    internal void 丑丞丟丁东丂三与丁(string 丕丁下丌不万丅丞丛, UnityEngine.Texture 三丆业丘丑万丘世下)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业())) == false)
        {
            goto label_6;
        }
        
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  6);
        return;
        label_6:
        if((this.<下丅上丈丗丛三丗丏>k__BackingField) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  6))) != false)
        {
                return;
        }
        
        }
        
        this.<下丅上丈丗丛三丗丏>k__BackingField = false;
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  6, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_7 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丐与丑七业丗专丝丘(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛, 三丆业丘丑万丘世下:  三丆业丘丑万丘世下));
    }
    private System.Collections.IEnumerator 丐与丑七业丗专丝丘(string 丒丘丏上丙丟丑丕丈, UnityEngine.Texture 三丆业丘丑万丘世下)
    {
        CharacterInterfaceV2.三上上且丐一丂丝丐 val_1 = new CharacterInterfaceV2.三上上且丐一丂丝丐();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[48] = this;
            mem[32] = 丒丘丏上丙丟丑丕丈;
        }
        
        .三丆业丘丑万丘世下 = 三丆业丘丑万丘世下;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 一丗丒七丆丈丒丙上(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈, UnityEngine.Texture 三丆业丘丑万丘世下)
    {
        int val_17;
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  6);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_2.transform.parent = this.capePoint.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  -0.8f);
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_17 = this.gameObject.layer;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  val_17);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        if(三丆业丘丑万丘世下 != 0)
        {
                CustomCapePicker val_15 = val_2.GetComponent<CustomCapePicker>();
            val_15.shouldLoadTexture = false;
            UnityEngine.GameObject[] val_16 = new UnityEngine.GameObject[0];
            val_17 = val_16;
            Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_2, 丐丅丁丂丐下丘世丄:  三丆业丘丑万丘世下, 丕丂丝丗丈三与东专:  val_16);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  6, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_2);
        this.万丙丈世不丞万丗三();
    }
    private void 万丙丈世不丞万丗三()
    {
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  6);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                var val_3 = (null == null) ? (val_1) : 0;
        }
        
        if((this.丐丟丛丒丁不三东丟 == true) || (this.丌丐丑三丒丞丗丛丝() == true))
        {
            goto label_10;
        }
        
        if(this.丌丐丑三丒丞丗丛丝() != false)
        {
                if(this.专丕丞丙上丙丐丁东() == true)
        {
            goto label_10;
        }
        
        }
        
        this = this.丏业丛丘与丈业丁业();
        if(this == 0)
        {
            goto label_14;
        }
        
        label_10:
        label_14:
        Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  0.transform, 丈七与世丏丕业世丙:  false);
    }
    internal void 上丒丈世丗丆丗丛下(string 丕丁下丌不万丅丞丛)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟())) == false)
        {
            goto label_6;
        }
        
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  5);
        this.专丅万丈丟丙丐丞上();
        return;
        label_6:
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  5))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  5, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_7 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丅丆丏丒丞丗七且一(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丅丆丏丒丞丗七且一(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丙丄七丂七业丒下丐 val_1 = new CharacterInterfaceV2.丙丄七丂七业丒下丐(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 世且丕丟丟万上丟世(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.GameObject val_16 = 丑且不丕与专丄业丙;
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  5);
        if(val_16 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_16 = 丑且不丕与专丄业丙);
        val_16 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_16);
        val_2.transform.SetParent(parent:  this.leftBootPoint.transform, worldPositionStays:  false);
        val_16.transform.SetParent(parent:  this.rightBootPoint.transform, worldPositionStays:  false);
        val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_16, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_16);
        }
        
        string val_13 = 七丌丞万七万丁丐丙.与不丏一丐专丑丆下(丝丘丛业丁上丕丏丅:  丒丘丏上丙丟丑丕丈);
        val_2.GetComponent<BootsMaterial>().SetBootsMaterial(丟东丕丗丑丏丐丟丅:  val_13);
        val_16.GetComponent<BootsMaterial>().SetBootsMaterial(丟东丕丗丑丏丐丟丅:  val_13);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  5, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_2);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  5, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_16);
        this.专丅万丈丟丙丐丞上();
        this.上专丗丏业丘万一丈();
    }
    private void 上专丗丏业丘万一丈()
    {
        var val_13;
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.List<UnityEngine.Object> val_1 = this.下世丂丄七七上丟丞(下丗丁丒丘东丂不丑:  5);
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = new System.Collections.Generic.List<UnityEngine.Transform>(capacity:  2);
        val_13 = 0;
        goto label_1;
        label_12:
        val_14 = val_1.Item[0];
        if(val_14 != 0)
        {
                UnityEngine.Object val_5 = val_1.Item[0];
            if(val_5 != null)
        {
                var val_6 = (null == null) ? (val_5) : 0;
        }
        
            val_14 = 0.transform;
            val_2.Add(item:  val_14);
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < val_1.Count)
        {
            goto label_12;
        }
        
        if(this.丌丕丁丞丏丒丝三丘 == false)
        {
            goto label_13;
        }
        
        val_15 = 1152921519067102480;
        val_16 = 0;
        goto label_14;
        label_17:
        Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  val_2.Item[0], 丈七与世丏丕业世丙:  false);
        val_16 = 1;
        label_14:
        if(val_16 < val_2.Count)
        {
            goto label_17;
        }
        
        return;
        label_13:
        val_15 = 1152921519067102480;
        val_17 = 0;
        goto label_19;
        label_22:
        Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  val_2.Item[0], 丈七与世丏丕业世丙:  true);
        val_17 = 1;
        label_19:
        if(val_17 < val_2.Count)
        {
            goto label_22;
        }
    
    }
    internal void 不一丙东七下不丕丑(string 丕丁下丌不万丅丞丛)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  "MaskNoneEquipped")) == false)
        {
            goto label_4;
        }
        
        }
        
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  4);
        this.丞七丑丗丄丐丐丞丒();
        return;
        label_4:
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  4))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  4, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_6 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丂专专丞丟丐丕丟丘(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丂专专丞丟丐丕丟丘(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丈丙丐丒丛丂丂丆丘 val_1 = new CharacterInterfaceV2.丈丙丐丒丛丂丂丆丘();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丝丝七下丆万丙丈丘(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  4);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        val_2.transform.parent = this.maskPoint.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_2);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  4, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_2);
        this.丞七丑丗丄丐丐丞丒();
        this.丗丝万专丟三万三不();
    }
    private void 丗丝万专丟三万三不()
    {
        var val_5;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  4);
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                var val_3 = (null == null) ? (val_1) : 0;
        }
        
        if(this.丙万业丈丈东丁一业 != false)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = 1;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  0.transform, 丈七与世丏丕业世丙:  true);
    }
    internal void 一一丝专东丘丅一丌(string 丕丁下丌不万丅丞丛)
    {
        string val_2 = this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  8);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_2)) != false)
        {
                this.丝一下丌下丆丂丘不();
        }
        
            this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
            this.丑三丗丙丑世丆不丕 = 0;
            return;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  val_2)) != false)
        {
                this.<丐丑丛丁丏丛东丏丝>k__BackingField = false;
            return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_6 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丞丁丄业丘且丗世万(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丞丁丄业丘且丗世万(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.东东丏丁世不丐丕丐 val_1 = new CharacterInterfaceV2.东东丏丁世不丐丕丐(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丏丐丟万且丞丗丒世(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        var val_23;
        var val_24;
        UnityEngine.Transform val_25;
        string val_26;
        string val_27;
        this.丝一下丌下丆丂丘不();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        this.丗丟不上丕不三丛丗();
        GliderShop val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙).GetComponent<GliderShop>();
        if(val_3 != null)
        {
                val_23 = val_3.transform;
            val_24 = val_3;
        }
        else
        {
                val_23 = 0.transform;
            val_24 = 0;
        }
        
        丝东丗丞且不且上丙 val_23 = val_3.GliderType;
        val_23 = val_23 - 1;
        if(val_23 > 3)
        {
            goto label_9;
        }
        
        var val_24 = 106041356 + ((val_3.GliderType - 1)) << 2;
        val_24 = val_24 + 106041356;
        goto (106041356 + ((val_3.GliderType - 1)) << 2 + 106041356);
        label_9:
        val_25 = this._gliderPointTypeFlying;
        val_23.parent = mem[this._gliderPointTypeSitting];
        val_23.localRotation = new UnityEngine.Quaternion() {x = val_3.InitialRotation, y = V9.16B, z = V10.16B, w = V11.16B};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_23.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_23.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_24.gameObject);
        }
        
        if(this.transform.parent != 0)
        {
                Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_24.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer);
        }
        
        this.丑三丗丙丑世丆不丕 = val_3.Arms.sharedMesh;
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_24.gameObject);
        this.丛一七上丞三东丝业();
        this.上丟下上七七不丞丏();
        if((System.String.IsNullOrEmpty(value:  val_3.customNameShopPersAnimation)) == false)
        {
            goto label_30;
        }
        
        if((val_3.GliderType - 1) > 3)
        {
            goto label_32;
        }
        
        val_26 = mem[130691072 + ((val_3.GliderType - 1)) << 3];
        val_26 = 130691072 + ((val_3.GliderType - 1)) << 3;
        goto label_33;
        label_30:
        val_27 = val_3.customNameShopPersAnimation;
        goto label_34;
        label_32:
        val_26 = "Glider_1";
        label_33:
        label_34:
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  val_26, 丆下丈丗不丄万丄丏:  false);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12))) != false)
        {
                this.丛一世丑三万丈丒七();
        }
        else
        {
                this.一丂世丏丞七丆丁万();
        }
        
        this.万丙丈世不丞万丗三();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
        this.<丐丑丛丁丏丛东丏丝>k__BackingField = false;
        this._skinCharacter.SetActive(value:  true);
    }
    private void 丛一七上丞三东丝业()
    {
        if(this.万丑丟且丏且丏东一 == false)
        {
                return;
        }
        
        if(this.丏业丛丘与丈业丁业() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丄丒一丁丄丄且丙万(与丝丐丏上丄丂与丂:  this.丏业丛丘与丈业丁业());
        this.万丑丟且丏且丏东一 = false;
    }
    private void 上丟下上七七不丞丏()
    {
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8)) == 0)
        {
                return;
        }
        
        UnityEngine.Object val_3 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8);
        if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        
        this = 0.GetComponent<GliderShop>();
        if(val_5.Animation == 0)
        {
                return;
        }
        
        bool val_7 = val_5.Animation.Play(animation:  val_5.ShopAnimationClipName);
    }
    internal void 专世丐丝丑丒专下丑(string 丕丁下丌不万丅丞丛)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != false)
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
            return;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_5 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝一丘丌丈丂丙一丐(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丝一丘丌丈丂丙一丐(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丐丄与丂丈七专世丕 val_1 = new CharacterInterfaceV2.丐丄与丂丈七专世丕(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丞丛丘丒丒丞三下上(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Transform val_26;
        var val_30;
        var val_31;
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        CarShop val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙).GetComponent<CarShop>();
        UnityEngine.Transform val_4 = val_3.transform;
        val_26 = this.carPoint;
        val_4.parent = val_26;
        if(val_3.PlayerPoint != 0)
        {
                val_26 = val_3.transform;
            UnityEngine.Vector3 val_7 = val_3.PlayerPoint.position;
            UnityEngine.Vector3 val_8 = val_26.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        else
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        }
        
        val_4.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        val_4.localRotation = new UnityEngine.Quaternion() {x = val_3.InitialRotation, y = val_10.y, z = val_10.z, w = V11.16B};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_4.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_3.gameObject);
        }
        
        if(this.transform.parent != 0)
        {
                val_26 = this.transform.parent.gameObject.layer;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_3.gameObject, 不东丛三丂丌丑专丆:  val_26);
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_3.gameObject);
        this.丂万丏丏丈丕不丑与();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
        this._skinCharacter.SetActive(value:  true);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
        val_30 = null;
        val_30 = null;
        if((System.String.op_Inequality(a:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1), b:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌())) != false)
        {
                val_31 = null;
            val_31 = null;
            this.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        
        this.业不丛不丞七丕东世(七不丐下丟专业万丅:  "DaterArmsCar");
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "CarShopAnimationClip", 丆下丈丗不丄万丄丏:  false);
    }
    private void 丂万丏丏丈丕不丑与()
    {
        if(this.与丂丒丆丏上专业丗 == false)
        {
                return;
        }
        
        if(this.丂丈丐且不世七丒丒() == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丝丑东与丑丕丂丑丝(丝三丁东丈丒世丅业:  this.丂丈丐且不世七丒丒().gameObject);
        this.与丂丒丆丏上专业丗 = false;
    }
    internal void 丐丕丌一丆丛丆丘万(string 丕丁下丌不万丅丞丛)
    {
        if(this.上上丈丟且万上丟丛 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.上上丈丟且万上丟丛);
            this.上上丈丟且万上丟丛 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != false)
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
            return;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11))) == true)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        this.上上丈丟且万上丟丛 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丄且丙丒业一丂丝世(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丄且丙丒业一丂丝世(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丑丒丁不丌丑不丐丏 val_1 = new CharacterInterfaceV2.丑丒丁不丌丑不丐丏(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 与丄丌一专与丁丛一(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Transform[] val_22;
        var val_23;
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  11);
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.丝丑万专丕丕丒七一();
        UnityEngine.GameObject val_4 = this.丝丑万专丕丕丒七一();
        var val_22 = -4294967296;
        val_22 = val_22 + ((this._royalTrailPoints.Length) << 32);
        this._royalTrailPoints[val_22 >> 32] = val_2.万一丐丁不丕七丒丑(丌丝下丄业一丄不三:  val_2, 不不专东丆专丗丟丅:  true);
        val_22 = this._royalTrailPoints;
        var val_23 = -8589934592;
        val_23 = val_23 + ((this._royalTrailPoints.Length) << 32);
        val_23 = 0;
        val_22[val_23 >> 32] = val_4.万一丐丁不丕七丒丑(丌丝下丄业一丄不三:  val_4, 不不专东丆专丗丟丅:  false);
        goto label_12;
        label_40:
        val_22 = 0;
        UnityEngine.Transform val_24 = this._royalTrailPoints[val_22];
        if(val_24 != 0)
        {
                UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
            UnityEngine.Transform val_10 = val_9.transform;
            val_10.parent = val_24;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_10.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_10.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_10.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_9);
        }
        
            val_22 = this.transform.parent;
            if(val_22 != 0)
        {
                val_22 = this.transform.parent.gameObject.layer;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_9, 不东丛三丂丌丑专丆:  val_22);
        }
        
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  val_9);
        }
        
        val_23 = 1;
        label_12:
        if(val_23 < this._royalTrailPoints.Length)
        {
            goto label_40;
        }
        
        this.丁丅上且万业丕丈丘();
        this.丒丝且丝丙丅与丘丑();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  10);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  9);
        this._skinCharacter.SetActive(value:  true);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  8);
        this.业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "Fly_Shop", 丆下丈丗不丄万丄丏:  false);
    }
    private void 丁丅上且万业丕丈丘()
    {
        var val_7;
        if(this.与丒丕丕七丁丟与不 == false)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Object> val_1 = this.下世丂丄七七上丟丞(下丗丁丒丘东丂不丑:  11);
        val_7 = 0;
        goto label_2;
        label_10:
        if(val_1.Item[0] != 0)
        {
                UnityEngine.Object val_4 = val_1.Item[0];
            丁业丁丞丆七丄丟丐.三丏一丐丒丏丁丑丞(丝三丁东丈丒世丅业:  (null == null) ? (val_4) : 0);
            this.与丒丕丕七丁丟与不 = false;
        }
        
        val_7 = 1;
        label_2:
        if(val_7 < val_1.Count)
        {
            goto label_10;
        }
    
    }
    private UnityEngine.Transform 万一丐丁不丕七丒丑(UnityEngine.GameObject 丌丝下丄业一丄不三, bool 不不专东丆专丗丟丅)
    {
        UnityEngine.Transform val_5 = 0;
        if(丌丝下丄业一丄不三 == 0)
        {
                return val_5;
        }
        
        InnerWeaponPars val_3 = 丌丝下丄业一丄不三.GetComponent<WeaponSounds>()._innerPars;
        val_5 = 0;
        if(val_3 == 0)
        {
                return val_5;
        }
        
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if(不不专东丆专丗丟丅 == false)
        {
            goto label_10;
        }
        
        label_12:
        val_5 = val_3.LeftWrist;
        return val_5;
        label_9:
        if(不不专东丆专丗丟丅 == true)
        {
            goto label_12;
        }
        
        label_10:
        val_5 = val_3.RightWrist;
        return val_5;
    }
    private void 七东丈丒丆七丏丁丞()
    {
        if(this.丝丑万专丕丕丒七一() == 0)
        {
                return;
        }
        
        WeaponSounds val_4 = this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>();
        val_4._innerPars.FindArms();
        InnerWeaponPars val_6 = val_4._innerPars;
        if(val_6.renderArms == 0)
        {
                return;
        }
        
        InnerWeaponPars val_8 = val_4._innerPars;
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  val_8.renderArms, 丈丈三丕丘业丐丁丌:  this._defaultArmsRenderer, 丆丕东三丒丟三三三:  0);
    }
    internal void 丈丑丅上七丑丅一丒(string 丕丁下丌不万丅丞丛)
    {
        var val_11;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) != true)
        {
                if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  "EMPTY_ROYALE_AVATAR")) == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.且业丛三世丞丂丛不() != 0)
        {
                this.丝一下丌下丆丂丘不();
            this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  1);
            this.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1));
        }
        
        this.丆丑丟世丟丒业丛东();
        UnityEngine.Object val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  2);
        val_11 = 0;
        goto label_10;
        label_4:
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12))) == false)
        {
            goto label_11;
        }
        
        this.丌三业丞丛丞丛三丝();
        return;
        label_10:
        this.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  null);
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  12);
        return;
        label_11:
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  12, 丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_10 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丄专丙世世丛上丞丈(丒丘丏上丙丟丑丕丈:  丕丁下丌不万丅丞丛));
    }
    private System.Collections.IEnumerator 丄专丙世世丛上丞丈(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.不丝丄世丅丟丅不不 val_1 = new CharacterInterfaceV2.不丝丄世丅丟丅不不();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丐下三丆七丗下与且(UnityEngine.GameObject 丑且不丕与专丄业丙, string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Material[] val_20;
        UnityEngine.Material[] val_21;
        UnityEngine.Material val_22;
        UnityEngine.Material[] val_23;
        var val_24;
        UnityEngine.Material val_25;
        var val_26;
        UnityEngine.Material val_27;
        CharacterInterfaceV2.三丗丙业丂专专丙丑 val_1 = new CharacterInterfaceV2.三丗丙业丂专专丙丑();
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  12);
        val_20 = 1152921504848912384;
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        .东东七丝丞与丄东东 = 丑且不丕与专丄业丙.GetComponent<RoyaleAvatar>();
        this.playerBodyRenderer.enabled = false;
        this.playerHeadRenderer.enabled = false;
        this.playerRightLegRenderer.enabled = false;
        this.playerLeftLegRenderer.enabled = false;
        this.royaleAvatarBodyRenderer.enabled = true;
        this.royaleAvatarHeadRenderer.enabled = true;
        this.royaleAvatarLegsRenderer.enabled = true;
        this.royaleAvatarArmsRenderer.enabled = true;
        UnityEngine.Material[] val_4 = (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.bodyMeshRenderer.sharedMaterials;
        val_21 = new UnityEngine.Material[0];
        this.东丗丐上七丑丑丟不 = val_21;
        if(val_4.Length < 1)
        {
            goto label_17;
        }
        
        goto label_18;
        label_26:
        val_21 = this.东丗丐上七丑丑丟不;
        label_18:
        val_22 = val_4[0];
        UnityEngine.Material val_6 = new UnityEngine.Material(source:  val_22);
        if(val_21 == null)
        {
            goto label_20;
        }
        
        if(val_6 != null)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        if(val_6 == null)
        {
            goto label_24;
        }
        
        label_21:
        label_24:
        val_21[0] = val_6;
        if((0 + 1) < val_4.Length)
        {
            goto label_26;
        }
        
        label_17:
        if((CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.lowMaterial != 0)
        {
            goto label_31;
        }
        
        val_23 = new UnityEngine.Material[0];
        this.丒丆丛丕丌业丘世丞 = val_23;
        if(val_4.Length < 1)
        {
            goto label_32;
        }
        
        val_20 = 1152921504835174400;
        goto label_33;
        label_41:
        val_23 = this.丒丆丛丕丌业丘世丞;
        label_33:
        val_22 = val_4[0];
        UnityEngine.Material val_10 = new UnityEngine.Material(source:  val_22);
        if(val_23 == null)
        {
            goto label_35;
        }
        
        if(val_10 != null)
        {
            goto label_36;
        }
        
        goto label_39;
        label_35:
        if(val_10 == null)
        {
            goto label_39;
        }
        
        label_36:
        label_39:
        val_23[0] = val_10;
        if((0 + 1) < val_4.Length)
        {
            goto label_41;
        }
        
        label_32:
        label_103:
        this.三下丗丙丞丛东三丌 = new UnityEngine.Material[0];
        if(val_12.Length < 1)
        {
            goto label_46;
        }
        
        val_20 = 1152921504835174400;
        label_64:
        if(0 == 0)
        {
            goto label_47;
        }
        
        val_24 = 0;
        UnityEngine.Material val_14 = null;
        val_25 = val_14;
        val_14 = new UnityEngine.Material(source:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.headMeshRenderer.sharedMaterials[val_24]);
        if(this.三下丗丙丞丛东三丌 == null)
        {
            goto label_49;
        }
        
        if(val_25 != null)
        {
            goto label_50;
        }
        
        goto label_58;
        label_47:
        val_25 = this.东丗丐上七丑丑丟不[0];
        if(this.三下丗丙丞丛东三丌 == null)
        {
            goto label_54;
        }
        
        if(val_25 != null)
        {
            goto label_55;
        }
        
        goto label_62;
        label_49:
        if(val_25 == null)
        {
            goto label_58;
        }
        
        label_50:
        label_58:
        if(0 < this.三下丗丙丞丛东三丌.Length)
        {
            goto label_60;
        }
        
        goto label_60;
        label_54:
        if(val_25 == null)
        {
            goto label_62;
        }
        
        label_55:
        label_62:
        val_24 = 0;
        label_60:
        this.三下丗丙丞丛东三丌[val_24] = val_25;
        val_22 = 0 + 1;
        if(val_22 < val_12.Length)
        {
            goto label_64;
        }
        
        label_46:
        this.丒丅与与丅丛世丒三 = new UnityEngine.Material[0];
        if(val_15.Length < 1)
        {
            goto label_69;
        }
        
        label_87:
        val_20 = this.丒丅与与丅丛世丒三;
        if(0 == 0)
        {
            goto label_70;
        }
        
        val_26 = 0;
        UnityEngine.Material val_17 = null;
        val_27 = val_17;
        val_17 = new UnityEngine.Material(source:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.legsMeshRenderer.sharedMaterials[val_26]);
        if(val_20 == null)
        {
            goto label_72;
        }
        
        if(val_27 != null)
        {
            goto label_73;
        }
        
        goto label_81;
        label_70:
        val_27 = this.东丗丐上七丑丑丟不[0];
        if(val_20 == null)
        {
            goto label_77;
        }
        
        if(val_27 != null)
        {
            goto label_78;
        }
        
        goto label_85;
        label_72:
        if(val_27 == null)
        {
            goto label_81;
        }
        
        label_73:
        label_81:
        if(0 < this.丒丅与与丅丛世丒三.Length)
        {
            goto label_83;
        }
        
        goto label_83;
        label_77:
        if(val_27 == null)
        {
            goto label_85;
        }
        
        label_78:
        label_85:
        val_26 = 0;
        label_83:
        val_20[val_26] = val_27;
        val_22 = 0 + 1;
        if(val_22 < val_15.Length)
        {
            goto label_87;
        }
        
        label_69:
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.Material>(丌丛丏业世丄丞三丌:  this.丒丆丛丕丌业丘世丞, 七丐丅专且专七三丆:  new System.Action<UnityEngine.Material>(object:  val_1, method:  System.Void CharacterInterfaceV2.三丗丙业丂专专丙丑::一丏下下丘丝丑且丂(UnityEngine.Material 东丝丄丝丙专丘三丏)));
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarBodyRenderer, 丈丈三丕丘业丐丁丌:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.bodyMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarBodyBones);
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarHeadRenderer, 丈丈三丕丘业丐丁丌:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.headMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarHeadBones);
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarLegsRenderer, 丈丈三丕丘业丐丁丌:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.legsMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarLegsBones);
        this.丆丆丟丁不且丐且业(东东七丝丞与丄东东:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东);
        this.丌丘上丌丘专丏丘丅(丑丆丙丐不七丙七下:  this.丒丆丛丕丌业丘世丞);
        this.丘丙东且三丂专丆丞(丑丆丙丐不七丙七下:  this.东丗丐上七丑丑丟不, 专丄专丅专丕丛丟丁:  this.三下丗丙丞丛东三丌, 丙不丆丁世丏丄丘丙:  this.丒丅与与丅丛世丒三);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  12, 丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈, 丝丙丌七丑且丐丄上:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.gameObject);
        this.丛一世丑三万丈丒七();
        this.三丑丐丅七丏丕不丒();
        this.丈丑三且丄丈丈与七();
        this.三三丝丑丕丏丘业丒();
        this.丞七丑丗丄丐丐丞丒();
        this.专丅万丈丟丙丐丞上();
        this.丌三业丞丛丞丛三丝();
        return;
        label_31:
        UnityEngine.Material[] val_20 = new UnityEngine.Material[1];
        val_20[0] = new UnityEngine.Material(source:  (CharacterInterfaceV2.三丗丙业丂专专丙丑)[1152921525618101760].东东七丝丞与丄东东.lowMaterial);
        this.丒丆丛丕丌业丘世丞 = val_20;
        if(val_1 != null)
        {
            goto label_103;
        }
        
        goto label_103;
    }
    private void 丆丆丟丁不且丐且业(RoyaleAvatar 东东七丝丞与丄东东)
    {
        if(东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() != false)
        {
                if(东东七丝丞与丄东东.useEffectsOnLowDevices == false)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_2.AddRange(collection:  this.royaleAvatarBodyRenderer.bones);
        val_2.AddRange(collection:  this.royaleAvatarHeadRenderer.bones);
        val_2.AddRange(collection:  this.royaleAvatarLegsRenderer.bones);
        this.丟丟万一丒三丐与丐(东东七丝丞与丄东东:  东东七丝丞与丄东东, 丑一丑丏丐丅丞丞丂:  val_2);
    }
    private void 丒丐丁丈丏一丗七丟(RoyaleAvatar 东东七丝丞与丄东东, WeaponSounds 丄丏丅与丙丆丞丒丏)
    {
        if(东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() != false)
        {
                if(东东七丝丞与丄东东.useEffectsOnLowDevices == false)
        {
                return;
        }
        
        }
        
        if(丄丏丅与丙丆丞丒丏 == 0)
        {
                return;
        }
        
        if(东东七丝丞与丄东东 == 0)
        {
                return;
        }
        
        if(丄丏丅与丙丆丞丒丏.IsWeaponInsideHands == true)
        {
                return;
        }
        
        丄丏丅与丙丆丞丒丏._innerPars.FindArms();
        if(丄丏丅与丙丆丞丒丏._innerPars == 0)
        {
                return;
        }
        
        InnerWeaponPars val_8 = 丄丏丅与丙丆丞丒丏._innerPars;
        if(val_8.renderArms == 0)
        {
                return;
        }
        
        InnerWeaponPars val_10 = 丄丏丅与丙丆丞丒丏._innerPars;
        this.东丕东丕万丒丁丛七(东东七丝丞与丄东东:  东东七丝丞与丄东东, 丑一丑丏丐丅丞丞丂:  val_10.renderArms.bones);
    }
    private void 丌三业丞丛丞丛三丝()
    {
        UnityEngine.Object val_22;
        var val_23;
        bool val_24;
        UnityEngine.Object val_25;
        UnityEngine.GameObject val_1 = this.丝丑万专丕丕丒七一();
        if(val_1 == 0)
        {
                return;
        }
        
        WeaponSounds val_3 = val_1.GetComponent<WeaponSounds>();
        if(val_3 == 0)
        {
                return;
        }
        
        val_3._innerPars.FindArms();
        val_22 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) != 0)
        {
                UnityEngine.Object val_9 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
            if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        }
        
        val_23 = val_3.IsWeaponInsideHands ^ 1;
        if(val_22 != 0)
        {
                val_23 = ((this.丌七丞丛东一不七丏 == true) ? 1 : 0) & val_23;
        }
        
        if(val_3 != null)
        {
                val_24 = val_3.useLowAvatarArms;
        }
        else
        {
                val_24 = val_3.useLowAvatarArms;
        }
        
        val_25 = val_3._innerPars;
        if(val_25 == 0)
        {
                return;
        }
        
        InnerWeaponPars val_16 = val_3._innerPars;
        val_25 = val_16.renderArms;
        if(val_25 == 0)
        {
                return;
        }
        
        InnerWeaponPars val_19 = val_3._innerPars;
        this.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  val_23 & ((val_24 == false) ? 1 : 0), 丑丅世丏与丁丝丒丏:  val_19.renderArms.bones);
    }
    private void 丆丑丟世丟丒业丛东()
    {
        bool val_4;
        UnityEngine.Transform val_5;
        UnityEngine.Transform val_7;
        UnityEngine.Object val_8;
        bool val_9;
        List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<EffectBones>(source:  this.effectObjects).GetEnumerator();
        label_10:
        if(((-461757600) & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_6 = val_5.RemoteEndpoint;
        if(val_8 == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Object.Destroy(obj:  val_8.gameObject);
        val_5 = val_7;
        val_4 = val_9;
        bool val_12 = this.effectObjects.Remove(item:  new EffectBones() {rootBone = val_5, effectTransform = val_8, isArm = val_4});
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 东丕东丕万丒丁丛七(RoyaleAvatar 东东七丝丞与丄东东, UnityEngine.Transform[] 丑一丑丏丐丅丞丞丂)
    {
        bool val_4;
        UnityEngine.Transform val_5;
        UnityEngine.Transform val_7;
        UnityEngine.Object val_8;
        bool val_9;
        UnityEngine.Object val_35;
        var val_36;
        var val_38;
        UnityEngine.GameObject val_39;
        var val_40;
        val_35 = 东东七丝丞与丄东东;
        val_36 = System.Linq.Enumerable.ToList<EffectBones>(source:  mem[1152921525620248112]);
        List.Enumerator<T> val_2 = val_36.GetEnumerator();
        val_38 = 1152921525619888464;
        label_11:
        if(((-461448064) & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_6 = val_5.RemoteEndpoint;
        if(((val_9 & 255) == 0) || (((UnityEngine.Object.op_Inequality(x:  val_8, y:  0)) ^ 1) == true))
        {
            goto label_11;
        }
        
        UnityEngine.Object.Destroy(obj:  val_8.gameObject);
        val_5 = val_7;
        val_4 = val_9;
        bool val_14 = mem[1152921525620248112].Remove(item:  new EffectBones() {rootBone = val_5, effectTransform = val_8, isArm = val_4});
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_35 == 0)
        {
                return;
        }
        
        val_35 = 东东七丝丞与丄东东.effects;
        if(val_35 == null)
        {
                return;
        }
        
        if(东东七丝丞与丄东东.effects.Length < 1)
        {
                return;
        }
        
        label_62:
        var val_36 = 24;
        val_36 = val_35 + (0 * val_36);
        if(((0 * 24) + 东东七丝丞与丄东东.effects + 48) == 0)
        {
            goto label_29;
        }
        
        val_39 = mem[(0 * 24) + 东东七丝丞与丄东东.effects + 32];
        val_39 = (0 * 24) + 东东七丝丞与丄东东.effects + 32;
        val_40 = 0;
        goto label_27;
        label_40:
        val_40 = 1;
        label_27:
        if(val_40 >= 丑一丑丏丐丅丞丞丂.Length)
        {
            goto label_29;
        }
        
        UnityEngine.Transform val_37 = 丑一丑丏丐丅丞丞丂[1];
        if(val_37 == 0)
        {
            goto label_40;
        }
        
        val_38 = RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_37.name, 丙丁不上丐丏丁一丏:  false);
        if((System.String.op_Equality(a:  val_39.name.ToLower(), b:  val_38.ToLower())) == false)
        {
            goto label_40;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[BONE] " + val_39.name + " " + RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_37.name, 丙丁不上丐丏丁一丏:  false)(RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_37.name, 丙丁不上丐丏丁一丏:  false)));
        }
        
        val_39 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (0 * 24) + 东东七丝丞与丄东东.effects + 32 + 8.gameObject, parent:  val_37);
        UnityEngine.Vector3 val_31 = (0 * 24) + 东东七丝丞与丄东东.effects + 32 + 8.localPosition;
        val_39.transform.localPosition = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_39, 不东丛三丂丌丑专丆:  val_37.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        UnityEngine.Transform val_34 = val_39.transform;
        mem[1152921525620248112].Add(item:  new EffectBones() {isArm = false});
        label_29:
        val_35 = val_35;
        if((0 + 1) < (东东七丝丞与丄东东.effects + 24))
        {
            goto label_62;
        }
    
    }
    internal void 丟丟万一丒三丐与丐(RoyaleAvatar 东东七丝丞与丄东东, System.Collections.Generic.List<UnityEngine.Transform> 丑一丑丏丐丅丞丞丂)
    {
        bool val_4;
        UnityEngine.Transform val_5;
        UnityEngine.Transform val_7;
        UnityEngine.Object val_8;
        bool val_9;
        var val_17;
        var val_18;
        UnityEngine.Object val_35;
        var val_36;
        string val_37;
        var val_40;
        val_35 = 东东七丝丞与丄东东;
        List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<EffectBones>(source:  this.effectObjects).GetEnumerator();
        val_37 = 1152921525619888464;
        label_10:
        if(((-461037168) & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_6 = val_5.RemoteEndpoint;
        var val_11 = ((val_9 & 255) != 0) ? 1 : 0;
        val_11 = val_11 & (UnityEngine.Object.op_Inequality(x:  val_8, y:  0));
        if(val_11 != true)
        {
            goto label_10;
        }
        
        UnityEngine.Object.Destroy(obj:  val_8.gameObject);
        val_5 = val_7;
        val_4 = val_9;
        bool val_13 = this.effectObjects.Remove(item:  new EffectBones() {rootBone = val_5, effectTransform = val_8, isArm = val_4});
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_35 == 0)
        {
                return;
        }
        
        if(东东七丝丞与丄东东.effects == null)
        {
                return;
        }
        
        if(东东七丝丞与丄东东.effects.Length < 1)
        {
                return;
        }
        
        val_35 = 0;
        val_40 = 0;
        label_78:
        var val_15 = 东东七丝丞与丄东东.effects + (0 * 24);
        if(((0 * 24) + 东东七丝丞与丄东东.effects + 48) != 0)
        {
            goto label_77;
        }
        
        val_36 = mem[(0 * 24) + 东东七丝丞与丄东东.effects + 32 + 8];
        val_36 = (0 * 24) + 东东七丝丞与丄东东.effects + 32 + 8;
        List.Enumerator<T> val_16 = 丑一丑丏丐丅丞丞丂.GetEnumerator();
        label_34:
        if(((-461037200) & 1) == 0)
        {
            goto label_27;
        }
        
        string val_19 = val_18.丐丏七丌丕丗业且上();
        val_37 = (0 * 24) + 东东七丝丞与丄东东.effects + 32.name.ToLower();
        if((System.String.op_Equality(a:  val_37, b:  RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_19.name, 丙丁不上丐丏丁一丏:  false).ToLower())) == false)
        {
            goto label_34;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_37 = val_19.name;
            UnityEngine.Debug.Log(message:  "[BONE] " + (0 * 24) + 东东七丝丞与丄东东.effects + 32.name((0 * 24) + 东东七丝丞与丄东东.effects + 32.name) + " " + RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_37, 丙丁不上丐丏丁一丏:  false)(RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_37, 丙丁不上丐丏丁一丏:  false)));
        }
        
        UnityEngine.GameObject val_32 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_36.gameObject, parent:  val_19);
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_32, 不东丛三丂丌丑专丆:  val_19.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        UnityEngine.Transform val_35 = val_32.transform;
        val_17 = 0;
        val_18 = 0;
        this.effectObjects.Add(item:  new EffectBones() {isArm = false});
        label_27:
        val_40 = val_40 + 1;
        mem2[0] = 381;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_40 != 1) && ((-461037328 + ((val_40 + 1)) << 2) == 381))
        {
                var val_37 = 0;
            val_37 = val_37 ^ (val_40 >> 31);
            val_40 = val_40 + val_37;
        }
        else
        {
                if(null != null)
        {
                val_35 = 0;
        }
        
        }
        
        label_77:
        if((0 + 1) < 东东七丝丞与丄东东.effects.Length)
        {
            goto label_78;
        }
    
    }
    private void 丌丘上丌丘专丏丘丅(UnityEngine.Material[] 丑丆丙丐不七丙七下)
    {
        this.playerBodyRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.playerHeadRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.playerRightLegRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.playerLeftLegRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.playerSelfLeftArmRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.playerSelfRightArmRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
    }
    private void 丘丙东且三丂专丆丞(UnityEngine.Material[] 丑丆丙丐不七丙七下, UnityEngine.Material[] 专丄专丅专丕丛丟丁, UnityEngine.Material[] 丙不丆丁世丏丄丘丙)
    {
        this.royaleAvatarBodyRenderer.sharedMaterials = 丑丆丙丐不七丙七下;
        this.royaleAvatarHeadRenderer.sharedMaterials = 专丄专丅专丕丛丟丁;
        this.royaleAvatarLegsRenderer.sharedMaterials = 丙不丆丁世丏丄丘丙;
    }
    private void 三丑丐丅七丏丕不丒()
    {
        UnityEngine.Object val_20;
        UnityEngine.Object val_21;
        UnityEngine.Material[] val_22;
        var val_23;
        UnityEngine.Material[] val_24;
        UnityEngine.GameObject val_1 = this.丝丑万专丕丕丒七一();
        if(val_1 == 0)
        {
                return;
        }
        
        WeaponSounds val_3 = val_1.GetComponent<WeaponSounds>();
        if(val_3 == 0)
        {
                return;
        }
        
        val_3._innerPars.FindArms();
        UnityEngine.Object val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        if(val_20 == 0)
        {
                return;
        }
        
        RoyaleAvatar val_9 = val_20.GetComponent<RoyaleAvatar>();
        if(val_9 == 0)
        {
                return;
        }
        
        val_21 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) == 0)
        {
            goto label_21;
        }
        
        UnityEngine.Object val_13 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
        if(val_13 == null)
        {
            goto label_22;
        }
        
        var val_14 = (null == null) ? (val_13) : 0;
        if(val_3 != null)
        {
            goto label_25;
        }
        
        goto label_24;
        label_22:
        val_21 = 0;
        label_21:
        if(val_3 != null)
        {
            goto label_25;
        }
        
        label_24:
        label_25:
        if(val_3.IsWeaponInsideHands == false)
        {
            goto label_26;
        }
        
        InnerWeaponPars val_16 = val_3._innerPars;
        val_22 = this.丒丆丛丕丌业丘世丞;
        val_23 = 1;
        val_24 = val_22;
        goto label_29;
        label_26:
        if(val_21 != 0)
        {
                if(this.丌七丞丛东一不七丏 == false)
        {
            goto label_33;
        }
        
        }
        
        if(val_3.useLowAvatarArms == false)
        {
            goto label_35;
        }
        
        label_33:
        RoyaleAvatar.丘一丒丙世丅东丗七(三东丒丁且下丄七丛:  val_1, 丑业丄专丟业丆与且:  this._defaultArmsRenderer);
        val_22 = this.丒丆丛丕丌业丘世丞;
        val_24 = val_22;
        val_23 = 0;
        label_29:
        val_3._innerPars.三且七丙丞丑丟与三(不七七丒丆丁丗丅丂:  val_24, 丒专丞丅丐丝丛不丄:  false);
        return;
        label_35:
        RoyaleAvatar.丘一丒丙世丅东丗七(三东丒丁且下丄七丛:  val_1, 丑业丄专丟业丆与且:  val_9.armsMeshRenderer);
        val_3._innerPars.三且七丙丞丑丟与三(不七七丒丆丁丗丅丂:  this.东丗丐上七丑丑丟不, 丒专丞丅丐丝丛不丄:  false);
        this.丒丐丁丈丏一丗七丟(东东七丝丞与丄东东:  val_9, 丄丏丅与丙丆丞丒丏:  val_3);
    }
    private void 丈丑三且丄丈丈与七()
    {
        UnityEngine.Object val_18;
        UnityEngine.Object val_19;
        UnityEngine.Object val_20;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9);
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_18 = 0;
        }
        
        if(val_18 == 0)
        {
                return;
        }
        
        GadgetArmoryItem val_4 = val_18.GetComponent<GadgetArmoryItem>();
        if(val_4 == 0)
        {
                return;
        }
        
        if(val_4.isReplaceOnlyHands == false)
        {
                return;
        }
        
        UnityEngine.Object val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_19 = 0;
        }
        
        if(val_19 == 0)
        {
                return;
        }
        
        if((val_19.GetComponent<RoyaleAvatar>()) == 0)
        {
                return;
        }
        
        val_20 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7)) != 0)
        {
                UnityEngine.Object val_13 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  7);
            if(val_13 != null)
        {
                var val_14 = (null == null) ? (val_13) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        }
        
        if(val_20 != 0)
        {
                if(this.丌七丞丛东一不七丏 == false)
        {
            goto label_29;
        }
        
        }
        
        RoyaleAvatar.丘一丒丙世丅东丗七(三东丒丁且下丄七丛:  val_18, 丑业丄专丟业丆与且:  val_9.armsMeshRenderer);
        val_4.上万世丟丙丈东下丂();
        val_18 = val_4.renderArms;
        if(val_18 == 0)
        {
                return;
        }
        
        if(val_4.renderArms != null)
        {
            goto label_42;
        }
        
        label_43:
        label_42:
        val_4.renderArms.sharedMaterials = this.东丗丐上七丑丑丟不;
        return;
        label_29:
        RoyaleAvatar.丘一丒丙世丅东丗七(三东丒丁且下丄七丛:  val_18, 丑业丄专丟业丆与且:  this._defaultArmsRenderer);
        val_18 = val_4.renderArms;
        if(val_18 == 0)
        {
                return;
        }
        
        if(val_4.renderArms != null)
        {
            goto label_42;
        }
        
        goto label_43;
    }
    private void 丛一世丑三万丈丒七()
    {
        UnityEngine.Object val_13;
        UnityEngine.Object val_14;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8);
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_13 = 0;
        }
        
        if(val_13 == 0)
        {
                return;
        }
        
        if((val_13.GetComponent<GliderShop>()) == 0)
        {
                return;
        }
        
        UnityEngine.Object val_6 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  12);
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = val_14.GetComponent<RoyaleAvatar>();
        if(val_14 == 0)
        {
                return;
        }
        
        if(val_4.Arms == 0)
        {
                return;
        }
        
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  val_4.Arms, 丈丈三丕丘业丐丁丌:  val_9.armsMeshRenderer, 丆丕东三丒丟三三三:  0);
        val_4.Arms.sharedMaterials = this.东丗丐上七丑丑丟不;
        this.东丕东丕万丒丁丛七(东东七丝丞与丄东东:  val_14, 丑一丑丏丐丅丞丞丂:  val_4.Arms.bones);
    }
    internal string 上上丆丕丑丘丌丛万(CharacterInterfaceV2.与丕丁丏世七丝丆丛 丏丅三丑专丌世丂丏)
    {
        int val_3;
        this.上丛丌丆丑上七世三();
        if((this.丞世丂上丏不世丒丅.ContainsKey(key:  丏丅三丑专丌世丂丏)) != false)
        {
                string val_2 = this.丞世丂上丏不世丒丅.Item[丏丅三丑专丌世丂丏];
            return (string)val_3;
        }
        
        val_3 = System.String.alignConst;
        return (string)val_3;
    }
    internal bool 丘丂丆丕丂丆丌丙丝(CharacterInterfaceV2.与丕丁丏世七丝丆丛 丏丅三丑专丌世丂丏)
    {
        return 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  丏丅三丑专丌世丂丏));
    }
    internal UnityEngine.Object 丞丑丈且世丛东丝东(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑)
    {
        与丕丁丏世七丝丆丛 val_5;
        var val_6;
        val_5 = 下丗丁丒丘东丂不丑;
        this.上丛丌丆丑上七世三();
        if(this.丌丘丗丐丘丅上丂丐.Item[val_5].Count >= 1)
        {
                val_5 = this.丌丘丗丐丘丅上丂丐.Item[val_5];
            UnityEngine.Object val_4 = val_5.Item[0];
            return (UnityEngine.Object)val_6;
        }
        
        val_6 = 0;
        return (UnityEngine.Object)val_6;
    }
    internal System.Collections.Generic.List<UnityEngine.Object> 下世丂丄七七上丟丞(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑)
    {
        this.上丛丌丆丑上七世三();
        if(this.丌丘丗丐丘丅上丂丐 != null)
        {
                return this.丌丘丗丐丘丅上丂丐.Item[下丗丁丒丘东丂不丑];
        }
        
        return this.丌丘丗丐丘丅上丂丐.Item[下丗丁丒丘东丂不丑];
    }
    private void 七丒丏丙东不上七丐(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑)
    {
        if(下丗丁丒丘东丂不丑 != 8)
        {
                if(下丗丁丒丘东丂不丑 != 1)
        {
            goto label_2;
        }
        
        }
        
        this.万丙丈世不丞万丗三();
        label_2:
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  下丗丁丒丘东丂不丑, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丛七丁丂一丂上三丛(丁丅丈丌丟世丗丗丟:  下丗丁丒丘东丂不丑);
    }
    private void 丌丅三世丌丟下丄上(CharacterInterfaceV2.与丕丁丏世七丝丆丛 下丗丁丒丘东丂不丑, string 丕丁下丌不万丅丞丛, UnityEngine.Object 丝丙丌七丑且丐丄上)
    {
        int val_10;
        var val_11;
        val_10 = 丕丁下丌不万丅丞丛;
        this.上丛丌丆丑上七世三();
        if(val_10 == null)
        {
                val_10 = System.String.alignConst;
        }
        
        if((System.String.op_Inequality(a:  this.丞世丂上丏不世丒丅.Item[下丗丁丒丘东丂不丑], b:  val_10)) != true)
        {
                if((System.String.op_Equality(a:  val_10, b:  System.String.alignConst)) == false)
        {
            goto label_4;
        }
        
        }
        
        if((下丗丁丒丘东丂不丑 == 2) || (下丗丁丒丘东丂不丑 == 12))
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<UnityEngine.Object> val_4 = this.下世丂丄七七上丟丞(下丗丁丒丘东丂不丑:  下丗丁丒丘东丂不丑);
        val_11 = 0;
        goto label_7;
        label_10:
        this.丛万丈东丞且专下一(万且万且丑丗且丌丆:  val_4.Item[0], 丁丅丈丌丟世丗丗丟:  下丗丁丒丘东丂不丑);
        val_11 = 1;
        label_7:
        if(val_11 < val_4.Count)
        {
            goto label_10;
        }
        
        label_6:
        this.丌丘丗丐丘丅上丂丐.Item[下丗丁丒丘东丂不丑].Clear();
        this.丌丘丗丐丘丅上丂丐.Item[下丗丁丒丘东丂不丑].Add(item:  丝丙丌七丑且丐丄上);
        this.丞世丂上丏不世丒丅.set_Item(key:  下丗丁丒丘东丂不丑, value:  val_10);
        return;
        label_4:
        this.丌丘丗丐丘丅上丂丐.Item[下丗丁丒丘东丂不丑].Add(item:  丝丙丌七丑且丐丄上);
    }
    private void 世万业丟丈丂丅下一()
    {
        this.丛丕与一且上丛丛且 = new System.Collections.Generic.List<UnityEngine.Object>();
        this.丅丂丄丈丂丁丏丛丐 = new System.Collections.Generic.List<与丕丁丏世七丝丆丛>();
    }
    private void 丛万丈东丞且专下一(UnityEngine.Object 万且万且丑丗且丌丆, CharacterInterfaceV2.与丕丁丏世七丝丆丛 丁丅丈丌丟世丗丗丟)
    {
        var val_5;
        this.上丛丌丆丑上七世三();
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        val_5 = 0;
        goto label_4;
        label_10:
        if(X23.Item[0] == 0)
        {
            goto label_7;
        }
        
        val_5 = 1;
        label_4:
        if(val_5 < this.丛丕与一且上丛丛且.Count)
        {
            goto label_10;
        }
        
        this.丛丕与一且上丛丛且.Add(item:  万且万且丑丗且丌丆);
        this.丅丂丄丈丂丁丏丛丐.Add(item:  丁丅丈丌丟世丗丗丟);
        return;
        label_7:
        this.丛丕与一且上丛丛且.set_Item(index:  0, value:  万且万且丑丗且丌丆);
        this.丅丂丄丈丂丁丏丛丐.set_Item(index:  0, value:  丁丅丈丌丟世丗丗丟);
    }
    private bool 丏且专丌丛丟上与丈(CharacterInterfaceV2.与丕丁丏世七丝丆丛 丁丅丈丌丟世丗丗丟)
    {
        var val_8 = this.丅丂丄丈丂丁丏丛丐.Count;
        if(val_8 != this.丛丕与一且上丛丛且.Count)
        {
                return false;
        }
        
        val_8 = 0;
        goto label_4;
        label_15:
        if(this.丅丂丄丈丂丁丏丛丐.Item[0] == 丁丅丈丌丟世丗丗丟)
        {
                UnityEngine.Object val_4 = this.丛丕与一且上丛丛且.Item[0];
            if(((val_4 != null) && (val_4 != 0)) && (null == null))
        {
                if(val_4.activeInHierarchy == true)
        {
                return false;
        }
        
        }
        
        }
        
        val_8 = 1;
        label_4:
        if(val_8 < this.丅丂丄丈丂丁丏丛丐.Count)
        {
            goto label_15;
        }
        
        return false;
    }
    private void 丛七丁丂一丂上三丛(CharacterInterfaceV2.与丕丁丏世七丝丆丛 丁丅丈丌丟世丗丗丟)
    {
        var val_8;
        this.上丛丌丆丑上七世三();
        val_8 = 0;
        goto label_17;
        label_20:
        if(this.丛丕与一且上丛丛且.Item[0] != 0)
        {
                if(this.丅丂丄丈丂丁丏丛丐.Item[0] == 丁丅丈丌丟世丗丗丟)
        {
                UnityEngine.Object val_4 = this.丛丕与一且上丛丛且.Item[0];
            UnityEngine.Object.Destroy(obj:  this.丛丕与一且上丛丛且.Item[0]);
            this.丛丕与一且上丛丛且.set_Item(index:  0, value:  0);
            this.丅丂丄丈丂丁丏丛丐.set_Item(index:  0, value:  0);
        }
        
        }
        
        val_8 = 1;
        label_17:
        if(val_8 < this.丛丕与一且上丛丛且.Count)
        {
            goto label_20;
        }
        
        this.丐专世万与下丅丞丘();
        this.丘丗丁丗丑丞丂业丄();
    }
    private void 丙丞丒一上丞下丐丁()
    {
        UnityEngine.GameObject val_13 = this.丝丑万专丕丕丒七一();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = val_13.GetComponent<WeaponSounds>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13._innerPars.FindArms();
        InnerWeaponPars val_6 = val_13._innerPars;
        if(val_6.renderArms == 0)
        {
                return;
        }
        
        InnerWeaponPars val_8 = val_13._innerPars;
        val_8.renderArms.sharedMesh = this.丑丛上丒不丒下丒丞;
        UnityEngine.Material[] val_10 = new UnityEngine.Material[1];
        val_10[0] = this.万丄丗不丞丕丘且不[0];
        val_13._innerPars.三且七丙丞丑丟与三(不七七丒丆丁丗丅丂:  val_10, 丒专丞丅丐丝丛不丄:  val_13.IsWeaponInsideHands);
    }
    private void 一丂世丏丞七丆丁万()
    {
        UnityEngine.Object val_6;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8);
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_6 = 0;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        if((val_6.GetComponent<GliderShop>()) == 0)
        {
                return;
        }
        
        val_4.Arms.sharedMesh = this.丑三丗丙丑世丆不丕;
        val_4.Arms.sharedMaterials = this.万丄丗不丞丕丘且不;
    }
    private void 下七丝一专丒丂丛丅()
    {
        UnityEngine.Object val_7;
        UnityEngine.SkinnedMeshRenderer val_8;
        UnityEngine.Object val_1 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9);
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        val_8 = 1152921504848912384;
        if(val_7 == 0)
        {
                return;
        }
        
        GadgetArmoryItem val_4 = val_7.GetComponent<GadgetArmoryItem>();
        if(val_4 == 0)
        {
                return;
        }
        
        if(val_4.isReplaceOnlyHands == false)
        {
                return;
        }
        
        val_4.上万世丟丙丈东下丂();
        val_8 = val_4.renderArms;
        if(val_8 == 0)
        {
                return;
        }
        
        val_4.renderArms.sharedMesh = this.丐丝七丈上丏七东丅;
        val_4.renderArms.sharedMaterials = this.万丄丗不丞丕丘且不;
    }
    private void 丗丟不上丕不三丛丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftHand, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightHand, 丏业丟一东丂东丘丛:  false);
    }
    private void 业丞三且丄丕世与丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftHand, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightHand, 丏业丟一东丂东丘丛:  true);
    }
    private UnityEngine.Transform 三三丝三与丈上丐东(丝东丗丞且不且上丙 丁丅丈丌丟世丗丗丟)
    {
        UnityEngine.Transform val_2;
        if((丁丅丈丌丟世丗丗丟 - 1) <= 3)
        {
                var val_2 = 106041372 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2;
            val_2 = val_2 + 106041372;
        }
        else
        {
                val_2 = this._gliderPointTypeFlying;
            return (UnityEngine.Transform)mem[this._gliderPointTypeSitting];
        }
    
    }
    internal void 丟且丟七丌丞专七丁()
    {
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "Idle", 丆下丈丗不丄万丄丏:  false);
        this.丁七丒一世丟丕世东 = "Idle";
        this.丗丟不上丕不三丛丗();
        this.丐专世万与下丅丞丘();
    }
    internal void 丒不丆丙丙不与丞世()
    {
        this.丗丟不上丕不三丛丗();
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "default", 丆下丈丗不丄万丄丏:  false);
        this.丁七丒一世丟丕世东 = "default";
    }
    internal void 丘丑东丁与丕丆业丛()
    {
        this.业丞三且丄丕世与丗();
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "default", 丆下丈丗不丄万丄丏:  false);
        this.丁七丒一世丟丕世东 = "default";
    }
    internal void 丅丈丅丟万丄丙丅丒()
    {
        this.三万丛丟万丏万丌丐();
        this.丘丛丆丈世丌且万丟();
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "default", 丆下丈丗不丄万丄丏:  false);
        this.丁七丒一世丟丕世东 = "default";
    }
    private void 三万丛丟万丏万丌丐()
    {
        goto label_0;
        label_4:
        this._renderers[0].material = this._shopMaterial;
        0 = 1;
        label_0:
        if(0 < this._renderers.Length)
        {
            goto label_4;
        }
    
    }
    private void 丘丛丆丈世丌且万丟()
    {
        goto label_0;
        label_4:
        this._colliders[0].enabled = true;
        0 = 1;
        label_0:
        if(0 < this._colliders.Length)
        {
            goto label_4;
        }
    
    }
    internal void 不丕与丛三丛业丙不(string 东丐丛丁一东丑丒专)
    {
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  东丐丛丁一东丑丒专, 丆下丈丗不丄万丄丏:  false);
    }
    internal void 丌丐丛丛且万万丕丂(string 东丐丛丁一东丑丒专)
    {
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  东丐丛丁一东丑丒专, 丆下丈丗不丄万丄丏:  true);
    }
    private void 丟七专丏丈七丈丂丗(string 东丐丛丁一东丑丒专, bool 丆下丈丗不丄万丄丏)
    {
        UnityEngine.Animation val_9;
        UnityEngine.AnimationClip val_10;
        val_9 = 丆下丈丗不丄万丄丏;
        this.万丝丂一万丐丗三专 = 东丐丛丁一东丑丒专;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  东丐丛丁一东丑丒专)) != false)
        {
                return;
        }
        
        if(this._animation != null)
        {
                val_10 = this._animation.GetClip(name:  东丐丛丁一东丑丒专);
        }
        else
        {
                val_10 = 0.GetClip(name:  东丐丛丁一东丑丒专);
        }
        
        this._animation.clip = val_10;
        if(val_9 != false)
        {
                val_9 = this._animation;
            val_9.Item[东丐丛丁一东丑丒专].time = UnityEngine.Random.Range(min:  0f, max:  this._animation.clip.length);
        }
        
        bool val_8 = this._animation.Play();
        this._animation.Sample();
    }
    private void 东丆丆丛丞万丛丌丑()
    {
        if(this.丂丈丐且不世七丒丒() == 0)
        {
            goto label_3;
        }
        
        label_15:
        label_16:
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  "CarShopAnimationClip", 丆下丈丗不丄万丄丏:  false);
        return;
        label_3:
        if(this.丏业丛丘与丈业丁业() == 0)
        {
            goto label_6;
        }
        
        GliderShop val_5 = this.丏业丛丘与丈业丁业();
        if((val_5.GliderType - 1) > 3)
        {
            goto label_15;
        }
        
        goto label_15;
        label_6:
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  11)) == 0)
        {
            goto label_16;
        }
        
        goto label_15;
    }
    internal void 丛丟三东丈丐丈丁东()
    {
        this._simpleCharacter.SetActive(value:  true);
        this._skinCharacter.SetActive(value:  false);
    }
    private void 一丂丂丈丝一丟丞一()
    {
        Rilisoft.PetsManager.丝丅丑丆三与丛丟丞(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void CharacterInterfaceV2::三丞丟七丞与丘丘丞(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)));
        Rilisoft.PetsManager.与丄丐东丈丘下丐三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterInterfaceV2::一三丌丘丄丞专丏丏()));
        Rilisoft.PetsManager.且丛七丟丄丈丑丏丐(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void CharacterInterfaceV2::三丞丟七丞与丘丘丞(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)));
        Rilisoft.PetsManager.丁丂丕丒丗一丗丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterInterfaceV2::一三丌丘丄丞专丏丏()));
    }
    private void 三丞丟七丞与丘丘丞(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)
    {
        this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  一丕且丌业下丂丏且, 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
    }
    private void 一三丌丘丄丞专丏丏()
    {
        this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏(), 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
    }
    internal void 丌下丅七丅丟丏且丄(string 世丐丗专丅三丝丑丆)
    {
        this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
    }
    internal void 丌下丅七丅丟丏且丄(string 世丐丗专丅三丝丑丆, CharacterInterfaceV2.丂丗专上丁丐且丝丆 丐丕与丈丘丌东不丈)
    {
        this.<丆三丅丈丈丂丗丙丒>k__BackingField = 丐丕与丈丘丌东不丈;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆)) != false)
        {
                this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  13);
            return;
        }
        
        if((System.String.op_Equality(a:  世丐丗专丅三丝丑丆, b:  this.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  13))) != false)
        {
                return;
        }
        
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  13, 丕丁下丌不万丅丞丛:  世丐丗专丅三丝丑丆, 丝丙丌七丑且丐丄上:  0);
        UnityEngine.Coroutine val_5 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.七上丑业丈丝专丑丌(丒丘丏上丙丟丑丕丈:  世丐丗专丅三丝丑丆));
    }
    private System.Collections.IEnumerator 七上丑业丈丝专丑丌(string 丒丘丏上丙丟丑丕丈)
    {
        CharacterInterfaceV2.丒丄丆丘上上丆丌丕 val_1 = new CharacterInterfaceV2.丒丄丆丘上上丆丌丕(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丕专与丏丕丐丝上丆(UnityEngine.GameObject 丁丆丂丏丟丗七丒丘, string 世丐丗专丅三丝丑丆)
    {
        string val_42;
        UnityEngine.Object val_43;
        var val_45;
        IntPtr val_46;
        var val_47;
        System.Func<UnityEngine.GameObject, System.Boolean> val_49;
        string val_50;
        UnityEngine.GameObject val_51;
        string val_52;
        float val_53;
        val_42 = 世丐丗专丅三丝丑丆;
        val_43 = 丁丆丂丏丟丗七丒丘;
        this.七丒丏丙东不上七丐(下丗丁丒丘东丂不丑:  13);
        if(val_43 == 0)
        {
                return;
        }
        
        if(this.petPoint == 0)
        {
                UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_43);
        }
        
        val_43 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_43, parent:  this.petPoint);
        val_45 = 0;
        goto label_13;
        label_21:
        T val_42 = val_43.GetComponents<UnityEngine.Behaviour>()[0];
        val_46 = null;
        if((System.Type.op_Inequality(left:  val_42.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_46}))) != false)
        {
                val_42.enabled = false;
        }
        
        val_45 = 1;
        label_13:
        if(val_45 < val_5.Length)
        {
            goto label_21;
        }
        
        Rilisoft.PetClickHandler val_9 = val_43.GetComponent<Rilisoft.PetClickHandler>();
        if(val_9 != 0)
        {
            goto label_25;
        }
        
        Rilisoft.PetClickHandler val_11 = val_43.AddComponent<Rilisoft.PetClickHandler>();
        if(val_43 != null)
        {
            goto label_30;
        }
        
        goto label_28;
        label_25:
        val_9.enabled = true;
        if(val_43 != null)
        {
            goto label_30;
        }
        
        label_28:
        label_30:
        Rilisoft.PetEngine val_12 = val_43.GetComponent<Rilisoft.PetEngine>();
        val_47 = null;
        val_47 = null;
        val_49 = CharacterInterfaceV2.<>c.<>9__233_0;
        if(val_49 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_15 = null;
            val_49 = val_15;
            val_15 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterInterfaceV2.<>c::丟专七丒七丒与丄下(UnityEngine.GameObject 丐丆丂丒丁万丈丛丅));
            CharacterInterfaceV2.<>c.<>9__233_0 = val_49;
        }
        
        if((System.Linq.Enumerable.Any<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  this.gameObject), predicate:  val_15)) == false)
        {
            goto label_36;
        }
        
        val_50 = val_42;
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_50)) == null)
        {
            goto label_38;
        }
        
        Rilisoft.PetIndicationController val_19 = val_43.GetComponent<Rilisoft.PetIndicationController>();
        if(val_19 == null)
        {
            goto label_40;
        }
        
        val_19.enabled = true;
        val_19.isUpdateNameFromInfo = true;
        goto label_41;
        label_36:
        Rilisoft.PetIndicationController val_20 = val_43.GetComponent<Rilisoft.PetIndicationController>();
        val_50 = val_42;
        val_20.IconObject.SetActive(value:  false);
        val_20.LabelObj.SetActive(value:  false);
        label_38:
        if(val_12 != null)
        {
            goto label_83;
        }
        
        label_84:
        label_83:
        val_12.世与东丗世三丞丞不(丞丅上丏丂且下丅与:  val_50);
        UnityEngine.Vector3 val_22 = this.东丅丕万下不上丑丒(丙丂不业且丄丏丞万:  val_12, 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
        val_43.transform.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        UnityEngine.Quaternion val_24 = this.七与丘业东丐丟丈丞(丙丂不业且丄丏丞万:  val_12, 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
        val_43.transform.rotation = new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w};
        val_51 = this.gameObject;
        if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.transform.root.gameObject), b:  "ShopNGUI")) == false)
        {
            goto label_55;
        }
        
        if((不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<KeepLayer>(丝三丁东丈丒世丅业:  val_51, 丕丗丆丕丈丑东丆丈:  5)) != 0)
        {
            goto label_60;
        }
        
        val_51 = this.gameObject;
        if(val_51 != null)
        {
            goto label_63;
        }
        
        goto label_62;
        label_55:
        if(val_51 != null)
        {
            goto label_63;
        }
        
        label_62:
        label_63:
        val_52 = val_51;
        int val_34 = val_52.layer;
        goto label_64;
        label_60:
        val_52 = val_31.layer;
        label_64:
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_43, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  val_52));
        if((this.<丗丕丕七丒业万丑上>k__BackingField) != true)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_43);
        }
        
        val_42 = this.enabled;
        val_43.SetActive(value:  val_42);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  13, 丕丁下丌不万丅丞丛:  val_50, 丝丙丌七丑且丐丄上:  val_43);
        if(this.usePetPointPosition == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.zero;
        val_53 = this.NewFlyingPetOffset;
        if(val_12 != null)
        {
                val_53 = this.NewGroundPetOffset;
        }
        
        val_43.transform.localPosition = new UnityEngine.Vector3() {x = val_38.x, y = val_53, z = val_38.z};
        UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.identity;
        val_43.transform.localRotation = new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w};
        return;
        label_40:
        0.enabled = true;
        mem[128] = 1;
        label_41:
        val_19.IconObject.SetActive(value:  false);
        val_12.丂七三丐一万丈业丒(丙业与丙丗丝不丈东:  true);
        val_19.LabelObj.SetActive(value:  true);
        val_19.丑上七丈丘东丐丝丈(丙业与丙丗丝不丈东:  val_18.专丕与丒丗丁丘专丟);
        val_19.下丟丐丌三丒丅丈不();
        if(val_12 != null)
        {
            goto label_83;
        }
        
        goto label_84;
    }
    private UnityEngine.Vector3 东丅丕万下不上丑丒(Rilisoft.PetEngine 丙丂不业且丄丏丞万, CharacterInterfaceV2.丂丗专上丁丐且丝丆 丐丕与丈丘丌东不丈)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        bool val_2 = UnityEngine.Object.op_Equality(x:  丙丂不业且丄丏丞万, y:  0);
        UnityEngine.Vector3 val_5 = this.transform.position;
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丈与丈上丛丑丛丘三.x, y = 3.335864E-23f, z = 3.335864E-23f}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    private UnityEngine.Quaternion 七与丘业东丐丟丈丞(Rilisoft.PetEngine 丙丂不业且丄丏丞万, CharacterInterfaceV2.丂丗专上丁丐且丝丆 丐丕与丈丘丌东不丈)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        bool val_2 = UnityEngine.Object.op_Equality(x:  丙丂不业且丄丏丞万, y:  0);
        return new UnityEngine.Quaternion() {x = this.万丅丆万且三且世一.x, y = 3.335864E-23f, z = 3.335864E-23f, w = 3.335864E-23f};
    }
    private void 丞丐丕丟世丕业丒丒()
    {
        if(this.丒丛丒专丒丐丂丝万 == false)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        bool val_4 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.七万上丌丅不丙丆丒, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.丒丛丒专丒丐丂丝万 = val_4;
        if(val_4 == false)
        {
            goto label_5;
        }
        
        return;
        label_1:
        this.丒丛丒专丒丐丂丝万 = false;
        label_5:
        this.丅业万丙丞东业丘世();
        this.丁丑丅丏丂丏业丂丛();
        UnityEngine.Vector3 val_6 = this.transform.position;
        this.七万上丌丅不丙丆丒 = val_6;
        mem[1152921525628525536] = val_6.y;
        mem[1152921525628525540] = val_6.z;
        this.丒丛丒专丒丐丂丝万 = true;
    }
    private void 丅业万丙丞东业丘世()
    {
        UnityEngine.Vector3 val_1 = this.pointFlyingPet.position;
        UnityEngine.Vector3 val_3 = this.transform.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.丆东丈丝上丘万丂丂 = val_4;
        mem[1152921525628694744] = val_4.y;
        mem[1152921525628694748] = val_4.z;
        UnityEngine.Vector3 val_5 = this.pointFlyingPetArmory.position;
        UnityEngine.Vector3 val_7 = this.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.丏丆不丕不东丟东三 = val_8;
        mem[1152921525628694756] = val_8.y;
        mem[1152921525628694760] = val_8.z;
        UnityEngine.Vector3 val_9 = this.pointFlyingPetProfile.position;
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        this.且丟丕丆且与且丞丄 = val_12;
        mem[1152921525628694768] = val_12.y;
        mem[1152921525628694772] = val_12.z;
        UnityEngine.Vector3 val_13 = this.pointGroundPet.position;
        UnityEngine.Vector3 val_15 = this.transform.position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        this.丈与丈上丛丑丛丘三 = val_16;
        mem[1152921525628694708] = val_16.y;
        mem[1152921525628694712] = val_16.z;
        UnityEngine.Vector3 val_17 = this.pointGroundPetArmory.position;
        UnityEngine.Vector3 val_19 = this.transform.position;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        this.万丗丄万上丟丄丑丘 = val_20;
        mem[1152921525628694720] = val_20.y;
        mem[1152921525628694724] = val_20.z;
        UnityEngine.Vector3 val_21 = this.pointGroundPetProfile.position;
        UnityEngine.Vector3 val_23 = this.transform.position;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        this.一丐丝丌丙丁万下丘 = val_24;
        mem[1152921525628694732] = val_24.y;
        mem[1152921525628694736] = val_24.z;
    }
    private void 丁丑丅丏丂丏业丂丛()
    {
        UnityEngine.Quaternion val_1 = this.pointFlyingPet.rotation;
        this.万丅丆万且三且世一 = val_1;
        mem[1152921525628880556] = val_1.y;
        mem[1152921525628880560] = val_1.z;
        mem[1152921525628880564] = val_1.w;
        UnityEngine.Quaternion val_2 = this.pointFlyingPetArmory.rotation;
        this.丝上东丁且丑丘世丘 = val_2;
        mem[1152921525628880572] = val_2.y;
        mem[1152921525628880576] = val_2.z;
        mem[1152921525628880580] = val_2.w;
        UnityEngine.Quaternion val_3 = this.pointFlyingPetProfile.rotation;
        this.丕且一丞丟丌且丑丟 = val_3;
        mem[1152921525628880588] = val_3.y;
        mem[1152921525628880592] = val_3.z;
        mem[1152921525628880596] = val_3.w;
        UnityEngine.Quaternion val_4 = this.pointGroundPet.rotation;
        this.世丕丁丆丆丂丄丘三 = val_4;
        mem[1152921525628880508] = val_4.y;
        mem[1152921525628880512] = val_4.z;
        mem[1152921525628880516] = val_4.w;
        UnityEngine.Quaternion val_5 = this.pointGroundPetArmory.rotation;
        this.丁丂丐一世丝丒丆丘 = val_5;
        mem[1152921525628880524] = val_5.y;
        mem[1152921525628880528] = val_5.z;
        mem[1152921525628880532] = val_5.w;
        UnityEngine.Quaternion val_6 = this.pointGroundPetProfile.rotation;
        this.丅一下三丕一万丆世 = val_6;
        mem[1152921525628880540] = val_6.y;
        mem[1152921525628880544] = val_6.z;
        mem[1152921525628880548] = val_6.w;
    }
    private void 丌丕下业丂东丗丗一()
    {
        var val_10;
        UnityEngine.Object val_11;
        System.Collections.Generic.List<UnityEngine.Object> val_1 = this.下世丂丄七七上丟丞(下丗丁丒丘东丂不丑:  11);
        val_10 = 0;
        goto label_1;
        label_16:
        val_11 = val_1.Item[0];
        if(val_11 != 0)
        {
                UnityEngine.Object val_4 = val_1.Item[0];
            if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        
            val_11 = 0.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_11.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        
        val_10 = 1;
        label_1:
        if(val_10 < val_1.Count)
        {
            goto label_16;
        }
    
    }
    private void 世丗丁上丁东一东一()
    {
        float val_18;
        if(this.丐丁丟丏丄东不丘丒() == 0)
        {
                return;
        }
        
        丂丗专上丁丐且丝丆 val_18 = this.<丆三丅丈丈丂丗丙丒>k__BackingField;
        val_18 = val_18 - 1;
        if(val_18 <= 1)
        {
                UnityEngine.Vector3 val_7 = this.东丅丕万下不上丑丒(丙丂不业且丄丏丞万:  this.丐丁丟丏丄东不丘丒().GetComponent<Rilisoft.PetEngine>(), 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
            this.丐丁丟丏丄东不丘丒().transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        if(this.usePetPointPosition == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_18 = this.NewFlyingPetOffset;
        if((this.丐丁丟丏丄东不丘丒().GetComponent<Rilisoft.PetEngine>()) != null)
        {
                val_18 = this.NewGroundPetOffset;
        }
        
        this.丐丁丟丏丄东不丘丒().transform.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_18, z = val_8.z};
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
        this.丐丁丟丏丄东不丘丒().transform.transform.localRotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
    }
    private void 上东丘东丁丟东丕专()
    {
        if(this.丐丁丟丏丄东不丘丒() == 0)
        {
                return;
        }
        
        丂丗专上丁丐且丝丆 val_8 = this.<丆三丅丈丈丂丗丙丒>k__BackingField;
        val_8 = val_8 - 1;
        if(val_8 > 1)
        {
                return;
        }
        
        UnityEngine.Quaternion val_7 = this.七与丘业东丐丟丈丞(丙丂不业且丄丏丞万:  this.丐丁丟丏丄东不丘丒().GetComponent<Rilisoft.PetEngine>(), 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
        this.丐丁丟丏丄东不丘丒().transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    private void 丒丁丒且专上丟业丈()
    {
        if(this.丐丁丟丏丄东不丘丒() == 0)
        {
                return;
        }
        
        if(this.丐丁丟丏丄东不丘丒().layer == this.gameObject.layer)
        {
                return;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丐丁丟丏丄东不丘丒(), 不东丛三丂丌丑专丆:  this.gameObject.layer);
    }
    private void 丐专世万与下丅丞丘()
    {
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1)) != 0)
        {
                return;
        }
        
        if((this.丏且专丌丛丟上与丈(丁丅丈丌丟世丗丗丟:  1)) == true)
        {
                return;
        }
        
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9)) != 0)
        {
                return;
        }
        
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8)) != 0)
        {
                return;
        }
        
        this.业丞三且丄丕世与丗();
    }
    private void 丘丗丁丗丑丞丂业丄()
    {
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  8)) != 0)
        {
                return;
        }
        
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  11)) != 0)
        {
                return;
        }
        
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  10)) != 0)
        {
                return;
        }
        
        this.丟七专丏丈七丈丂丗(东丐丛丁一东丑丒专:  this.丁七丒一世丟丕世东, 丆下丈丗不丄万丄丏:  false);
    }
    internal void 世丙丆下丝业丈三丒(AnimationCoroutineRunner 丄上丐不专丁丄丏丐)
    {
        this.丙业东丗七丅专丏丆 = 丄上丐不专丁丄丏丐;
    }
    internal void 丐丟专万与专与丑丛()
    {
        this.royaleAvatarBodyRenderer.updateWhenOffscreen = true;
        this.royaleAvatarHeadRenderer.updateWhenOffscreen = true;
        this.royaleAvatarLegsRenderer.updateWhenOffscreen = true;
    }
    internal void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        UnityEngine.Object val_54;
        var val_55;
        System.Func<WeaponSounds, UnityEngine.GameObject> val_57;
        var val_58;
        System.Func<UnityEngine.GameObject, InnerWeaponPars> val_60;
        var val_61;
        System.Func<InnerWeaponPars, UnityEngine.GameObject> val_63;
        var val_64;
        System.Func<BulletSpawnPoint, UnityEngine.GameObject> val_66;
        UnityEngine.Object val_67;
        var val_68;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, rhs:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a})) == true)
        {
                return;
        }
        
        mem[1152921525630483584] = 0;
        this.丂丄一丗业丗丐万丏 = 0;
        System.Collections.Generic.List<UnityEngine.GameObject> val_3 = new System.Collections.Generic.List<UnityEngine.GameObject>(capacity:  30);
        val_3.Add(item:  this.capePoint.gameObject);
        val_3.Add(item:  this.hatPoint.gameObject);
        val_3.Add(item:  this.maskPoint.gameObject);
        val_3.Add(item:  this.leftBootPoint.gameObject);
        val_3.Add(item:  this.rightBootPoint.gameObject);
        val_3.Add(item:  this.armorPoint.gameObject);
        val_54 = 0;
        if(this.丝丑万专丕丕丒七一() != 0)
        {
                val_54 = this.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>();
        }
        
        if(val_54 != 0)
        {
                if(val_54.丛丑丂丌与丗东下专() != 0)
        {
                val_3.Add(item:  val_54.丛丑丂丌与丗东下专().gameObject);
        }
        
            if(val_54.丘万专丌丕与上丅丁() != 0)
        {
                val_3.Add(item:  val_54.丘万专丌丕与上丅丁().gameObject);
        }
        
            if(val_54.丞丗丒丒丗丘东丗丝() != 0)
        {
                val_3.Add(item:  val_54.丞丗丒丒丗丘东丗丝().gameObject);
        }
        
            if(val_54.业丑丂业东丁一丝丁() != 0)
        {
                if(val_54.IsWeaponInsideHands != false)
        {
                val_3.Add(item:  val_54.业丑丂业东丁一丝丁());
        }
        
        }
        
            val_55 = null;
            val_55 = null;
            val_57 = CharacterInterfaceV2.<>c.<>9__249_0;
            if(val_57 == null)
        {
                System.Func<WeaponSounds, UnityEngine.GameObject> val_31 = null;
            val_57 = val_31;
            val_31 = new System.Func<WeaponSounds, UnityEngine.GameObject>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject CharacterInterfaceV2.<>c::丕丁丛丌丙丛丝专业(WeaponSounds 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__249_0 = val_57;
        }
        
            val_58 = null;
            val_58 = null;
            val_60 = CharacterInterfaceV2.<>c.<>9__249_1;
            if(val_60 == null)
        {
                System.Func<UnityEngine.GameObject, InnerWeaponPars> val_33 = null;
            val_60 = val_33;
            val_33 = new System.Func<UnityEngine.GameObject, InnerWeaponPars>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  InnerWeaponPars CharacterInterfaceV2.<>c::丌丞丌丘七一丈丁与(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__249_1 = val_60;
        }
        
            val_61 = null;
            val_61 = null;
            val_63 = CharacterInterfaceV2.<>c.<>9__249_2;
            if(val_63 == null)
        {
                System.Func<InnerWeaponPars, UnityEngine.GameObject> val_35 = null;
            val_63 = val_35;
            val_35 = new System.Func<InnerWeaponPars, UnityEngine.GameObject>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject CharacterInterfaceV2.<>c::丈不丌专丏丌世与丟(InnerWeaponPars 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__249_2 = val_63;
        }
        
            UnityEngine.GameObject val_36 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<UnityEngine.GameObject, InnerWeaponPars>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<InnerWeaponPars, UnityEngine.GameObject>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<UnityEngine.GameObject, WeaponSounds>(丞下万上三丘上与专:  val_54, 丏丅丁丛一业丈专专:  val_31), 丏丅丁丛一业丈专专:  val_33), 丏丅丁丛一业丈专专:  val_35);
            if(val_36 != 0)
        {
                val_3.Add(item:  val_36);
        }
        
            System.Collections.Generic.List<UnityEngine.GameObject> val_38 = val_54.与东七万丘东丙丄丟();
            if(val_38 != null)
        {
                val_3.AddRange(collection:  val_38);
        }
        
            val_64 = null;
            val_64 = null;
            val_66 = CharacterInterfaceV2.<>c.<>9__249_3;
            if(val_66 == null)
        {
                System.Func<BulletSpawnPoint, UnityEngine.GameObject> val_39 = null;
            val_66 = val_39;
            val_39 = new System.Func<BulletSpawnPoint, UnityEngine.GameObject>(object:  CharacterInterfaceV2.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject CharacterInterfaceV2.<>c::七丈且丛三丙丟一下(BulletSpawnPoint 三丟东丕丄丄下下丑));
            CharacterInterfaceV2.<>c.<>9__249_3 = val_66;
        }
        
            val_3.AddRange(collection:  System.Linq.Enumerable.Select<BulletSpawnPoint, UnityEngine.GameObject>(source:  val_13.bulletSpawnPoints, selector:  val_39));
        }
        
        if((this.<丕业丅丂上丄且丌丘>k__BackingField) != false)
        {
                val_3.Add(item:  this.gunPoint.gameObject);
        }
        
        val_67 = 0;
        if((this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9)) == 0)
        {
            goto label_90;
        }
        
        val_68 = this.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  9);
        if(val_68 == null)
        {
            goto label_91;
        }
        
        if(null == null)
        {
            goto label_94;
        }
        
        val_68 = 0;
        goto label_94;
        label_91:
        label_94:
        val_67 = val_68.GetComponent<GadgetArmoryItem>();
        label_90:
        if(val_67 != 0)
        {
                if(val_45.gadgetPoint != 0)
        {
                val_3.Add(item:  val_45.gadgetPoint);
        }
        
            if(val_45.noFillPersSkinObjects != null)
        {
                val_3.AddRange(collection:  val_45.noFillPersSkinObjects);
        }
        
            if(val_45.LeftArmorHand != 0)
        {
                val_3.Add(item:  val_45.LeftArmorHand.gameObject);
        }
        
            if(val_45.RightArmorHand != 0)
        {
                val_67 = val_45.RightArmorHand.gameObject;
            val_3.Add(item:  val_67);
        }
        
        }
        
        CharacterInterfaceV2.丐三丁丆丑世且丐丟(丄专丏上丅且不丄丆:  this, 万且万且丑丗且丌丆:  this.gameObject, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, 丕上丁丞下丑上丁一:  val_3);
    }
    internal static void 丐三丁丆丑世且丐丟(CharacterInterfaceV2 丄专丏上丅且不丄丆, UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Color 丑丞丈丗丄丙丟万丄, System.Collections.Generic.List<UnityEngine.GameObject> 丕上丁丞下丑上丁一)
    {
        var val_23;
        UnityEngine.Renderer val_24;
        UnityEngine.Object val_25;
        UnityEngine.Object val_26;
        CharacterInterfaceV2 val_27;
        if(万且万且丑丗且丌丆 != null)
        {
                val_23 = 万且万且丑丗且丌丆.transform;
        }
        else
        {
                val_23 = 0.transform;
        }
        
        int val_4 = 万且万且丑丗且丌丆.transform.childCount;
        UnityEngine.Shader val_5 = UnityEngine.Shader.Find(name:  "Mobile/Diffuse-Color");
        if(val_4 < 1)
        {
                return;
        }
        
        var val_24 = 0;
        label_42:
        CharacterInterfaceV2.丗丒下丅丗不丗上且 val_6 = new CharacterInterfaceV2.丗丒下丅丗不丗上且();
        UnityEngine.Transform val_7 = val_23.GetChild(index:  0);
        label_11:
        if(0 >= 丕上丁丞下丑上丁一.Count)
        {
            goto label_7;
        }
        
        UnityEngine.GameObject val_9 = 丕上丁丞下丑上丁一.Item[0];
        val_24 = val_7.gameObject;
        val_25 = 0 + 1;
        if((val_24 & 1) == 0)
        {
            goto label_11;
        }
        
        goto label_39;
        label_7:
        val_24 = val_7.gameObject.GetComponent<UnityEngine.Renderer>();
        if(val_6 != null)
        {
                val_26 = val_6;
            .三丑丛丘与丛丟世东 = val_24;
        }
        else
        {
                mem[16] = val_24;
            val_26 = 16;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_26)) != false)
        {
                val_24 = mem[16];
            val_25 = val_24.material;
            if((UnityEngine.Object.op_Implicit(exists:  val_25)) != false)
        {
                val_27 = 丄专丏上丅且不丄丆;
            if(val_27 == 0)
        {
                val_27 = 丄专丏上丅且不丄丆;
        }
        
            val_24 = mem[丄专丏上丅且不丄丆 + 512];
            val_24 = 丄专丏上丅且不丄丆 + 512;
            System.Func<EffectBones, System.Boolean> val_16 = null;
            val_25 = val_16;
            val_16 = new System.Func<EffectBones, System.Boolean>(object:  val_6, method:  System.Boolean CharacterInterfaceV2.丗丒下丅丗不丗上且::丐与七丐丗丅与丙丙(EffectBones 三丟东丕丄丄下下丑));
            if((System.Linq.Enumerable.Any<EffectBones>(source:  val_24, predicate:  val_16)) != true)
        {
                val_25 = mem[16].material;
            val_24 = mem[16];
            val_24.sharedMaterial = val_25;
            if(val_25 != null)
        {
                val_25.shader = val_5;
        }
        else
        {
                0.shader = val_5;
        }
        
            val_25.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        }
        
        }
        
        }
        
        var val_23 = 0;
        label_38:
        if(val_23 >= 丕上丁丞下丑上丁一.Count)
        {
            goto label_34;
        }
        
        val_25 = 丕上丁丞下丑上丁一.Item[0];
        val_24 = val_7.gameObject;
        val_23 = val_23 + 1;
        if((val_24 & 1) == 0)
        {
            goto label_38;
        }
        
        goto label_39;
        label_34:
        UnityEngine.GameObject val_22 = val_7.gameObject;
        label_39:
        val_24 = val_24 + 1;
        if(val_24 != val_4)
        {
            goto label_42;
        }
    
    }
    internal void 七一丝七专上丘丆丘(bool 丑丒业丘丑东丕世丅)
    {
        T val_4;
        goto label_2;
        label_6:
        val_4 = this.gameObject.GetComponentsInChildren<UnityEngine.Renderer>()[0];
        val_4.lightProbeUsage = 丑丒业丘丑东丕世丅;
        0 = 1;
        label_2:
        if(0 < val_2.Length)
        {
            goto label_6;
        }
    
    }
    internal void 专丌丁七丆三下丈丑(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 七丅丞丗丁与不专丙)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D> val_64;
        var val_65;
        int val_66;
        与丕丁丏世七丝丆丛 val_67;
        与丕丁丏世七丝丆丛 val_68;
        var val_69;
        与丕丁丏世七丝丆丛 val_70;
        与丕丁丏世七丝丆丛 val_71;
        var val_72;
        var val_73;
        var val_75;
        var val_76;
        val_64 = 七丅丞丗丁与不专丙;
        UnityEngine.Texture2D val_44 = 0;
        UnityEngine.Texture2D val_55 = 0;
        System.Collections.Generic.HashSet<与丕丁丏世七丝丆丛> val_2 = new System.Collections.Generic.HashSet<与丕丁丏世七丝丆丛>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<与丕丁丏世七丝丆丛>());
        List.Enumerator<T> val_3 = val_64.GetEnumerator();
        label_54:
        if(((-450308384) & 1) == 0)
        {
            goto label_2;
        }
        
        val_65 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_5.丐丏七丌丕丗业且上());
        val_66 = val_65.业东丅东丌上丗丑不();
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_66)) != false)
        {
                val_66 = val_65.丑丐丙丄丅世世丑丒();
            val_65 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(上七下丘一下三世丏:  val_66);
        }
        
        if(val_65 == null)
        {
            goto label_54;
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        if(null == null)
        {
            goto label_11;
        }
        
        if(null == null)
        {
            goto label_12;
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  val_65.业上丙丞丐丄丆丅七(), 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
        bool val_18 = val_2.Add(item:  13);
        goto label_54;
        label_10:
        this.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
        this.业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
        bool val_20 = val_2.Add(item:  1);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        goto label_54;
        label_11:
        this.丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
        bool val_22 = val_2.Add(item:  9);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  1, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        goto label_54;
        label_12:
        if(val_65 == 12)
        {
                this.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
            val_67 = 4;
            bool val_24 = val_2.Add(item:  val_67);
        }
        
        if(val_65 == 9)
        {
                this.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七(), 三丆业丘丑万丘世下:  0);
            val_68 = 6;
            bool val_26 = val_2.Add(item:  val_68);
        }
        
        if(val_65 == 10)
        {
                this.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
            val_69 = 5;
            bool val_28 = val_2.Add(item:  5);
        }
        
        if(val_65 != 6)
        {
            goto label_54;
        }
        
        this.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
        bool val_30 = val_2.Add(item:  3);
        goto label_54;
        label_13:
        if(val_65 == 190000)
        {
                this.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
            val_70 = 12;
            bool val_32 = val_2.Add(item:  val_70);
        }
        
        if((val_65 != 6) && (val_65 != 180000))
        {
                if(val_65 != 2100)
        {
            goto label_39;
        }
        
        }
        
        this.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
        val_71 = 3;
        bool val_34 = val_2.Add(item:  val_71);
        label_39:
        if(val_65 == 160000)
        {
                this.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
            bool val_36 = val_2.Add(item:  8);
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  1, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
            val_72 = 9;
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        }
        
        if(val_65 == 200000)
        {
                this.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
            bool val_38 = val_2.Add(item:  11);
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
            val_73 = 9;
            this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        }
        
        if(val_65 != 210000)
        {
            goto label_54;
        }
        
        this.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  val_65.业上丙丞丐丄丆丅七());
        bool val_40 = val_2.Add(item:  10);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  8, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  11, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        this.丌丅三世丌丟下丄上(下丗丁丒丘东丂不丑:  9, 丕丁下丌不万丅丞丛:  System.String.alignConst, 丝丙丌七丑且丐丄上:  0);
        goto label_54;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(((((val_2.Contains(item:  1)) != true) && ((val_2.Contains(item:  8)) != true)) && ((val_2.Contains(item:  11)) != true)) && ((val_2.Contains(item:  10)) != true))
        {
                if((val_2.Contains(item:  9)) != true)
        {
                val_64 = 1152921505322766336;
            val_75 = null;
            val_75 = null;
            this.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
            this.业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
            bool val_52 = val_2.Add(item:  1);
            this.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        }
        
        if((val_2.Contains(item:  2)) != true)
        {
                if((val_2.Contains(item:  12)) != true)
        {
                val_76 = null;
            val_76 = null;
            val_64 = SkinsController.与业七丙三三万丕上;
            bool val_56 = val_64.TryGetValue(key:  SkinsController.丂下丅丑丗一不东丘, value: out  val_55);
            this.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  val_55);
            bool val_57 = val_2.Add(item:  2);
        }
        
        }
        
        if((val_2.Contains(item:  3)) != true)
        {
                this.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        if((val_2.Contains(item:  4)) != true)
        {
                this.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        if((val_2.Contains(item:  6)) != true)
        {
                this.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  System.String.alignConst, 三丆业丘丑万丘世下:  0);
        }
        
        if((val_2.Contains(item:  5)) != true)
        {
                this.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        if((val_2.Contains(item:  7)) != true)
        {
                this.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
        }
        
        if((val_2.Contains(item:  13)) == true)
        {
                return;
        }
        
        this.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  System.String.alignConst, 丐丕与丈丘丌东不丈:  this.<丆三丅丈丈丂丗丙丒>k__BackingField);
    }
    public CharacterInterfaceV2()
    {
        this.ScaleShop = 150f;
        this.ShopTier = 10;
        this.NewFlyingPetOffset = 1.5f;
        this.effectObjects = new System.Collections.Generic.List<EffectBones>();
    }
    private void 丗丁且丒万三丛丑丝(CharacterInterfaceV2.与丕丁丏世七丝丆丛 三丟东丕丄丄下下丑)
    {
        this.丞世丂上丏不世丒丅.set_Item(key:  三丟东丕丄丄下下丑, value:  System.String.alignConst);
    }

}
