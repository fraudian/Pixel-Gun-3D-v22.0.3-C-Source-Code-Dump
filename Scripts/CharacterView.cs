using UnityEngine;
public class CharacterView : MonoBehaviour
{
    // Fields
    private AnimationCoroutineRunner 丐东万东与下丗丏业;
    private CharacterInterfaceV2 七丌与丁丙三丑丂丕;
    private UnityEngine.GameObject 丕丛丞上七丗丅专丂;
    public UnityEngine.Transform mech;
    public UnityEngine.Material[] mechBodyMaterials;
    public UnityEngine.SkinnedMeshRenderer mechBodyRenderer;
    public UnityEngine.Material[] mechGunMaterials;
    public UnityEngine.SkinnedMeshRenderer mechGunRenderer;
    public UnityEngine.SkinnedMeshRenderer mechHandRenderer;
    public UnityEngine.Transform turret;
    private bool <丈世业丒丈世一丕七>k__BackingField;
    
    // Properties
    internal bool 丁丐丄不三世万且丙 { get; set; }
    internal CharacterInterfaceV2 东不丄专丁与丌万丐 { get; }
    public UnityEngine.Transform 世丟丈丏丕万丝丆万 { get; }
    private AnimationCoroutineRunner 丘丑与丄丗专丙一世 { get; }
    
    // Methods
    internal bool 万业业且专丛丗世下()
    {
        return (bool)this.<丈世业丒丈世一丕七>k__BackingField;
    }
    internal void 丟一一专不丙丄丒东(bool 丙业与丙丗丝不丈东)
    {
        this.<丈世业丒丈世一丕七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal CharacterInterfaceV2 万丟一丙丙丅丗丒且()
    {
        if(this.七丌与丁丙三丑丂丕 != 0)
        {
                return (CharacterInterfaceV2)this.七丌与丁丙三丑丂丕;
        }
        
        this.业丘三一丘丂不东七();
        return (CharacterInterfaceV2)this.七丌与丁丙三丑丂丕;
    }
    public UnityEngine.Transform get_character()
    {
        CharacterInterfaceV2 val_1 = this.万丟一丙丙丅丗丒且();
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    private AnimationCoroutineRunner 丐丛丗丞丈一丑万丁()
    {
        AnimationCoroutineRunner val_3;
        if(this.丐东万东与下丗丏业 == 0)
        {
                this.丐东万东与下丗丏业 = this.GetComponent<AnimationCoroutineRunner>();
            return val_3;
        }
        
        val_3 = this.丐东万东与下丗丏业;
        return val_3;
    }
    private void 业丘三一丘丂不东七()
    {
        UnityEngine.GameObject val_13;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_13 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        CharacterInterfaceV2 val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_13).GetComponent<CharacterInterfaceV2>();
        this.七丌与丁丙三丑丂丕 = val_4;
        val_4.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.七丌与丁丙三丑丂丕, 丏业丟一东丂东丘丛:  true);
        if((this.<丈世业丒丈世一丕七>k__BackingField) != true)
        {
                this.七丌与丁丙三丑丂丕.业七不专丝丘且万丁(丙业与丙丗丝不丈东:  true);
            this.七丌与丁丙三丑丂丕.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏());
        }
        
        this.七丌与丁丙三丑丂丕.丅丑世七丙东东丒丁(丙业与丙丗丝不丈东:  2);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.七丌与丁丙三丑丂丕.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.七丌与丁丙三丑丂丕.gameObject);
    }
    public void ShowCharacterType(CharacterView.上业丁七丝与丗丆丂 丞不丁丒丙与丐丏丁)
    {
        UnityEngine.Transform val_9;
        UnityEngine.Transform val_10;
        this.character.gameObject.SetActive(value:  false);
        if(this.mech != 0)
        {
                this.mech.gameObject.SetActive(value:  false);
        }
        
        val_9 = this.turret;
        if(val_9 != 0)
        {
                val_9 = this.turret.gameObject;
            val_9.SetActive(value:  false);
        }
        
        if(丞不丁丒丙与丐丏丁 == 2)
        {
            goto label_13;
        }
        
        if(丞不丁丒丙与丐丏丁 == 1)
        {
            goto label_14;
        }
        
        if(丞不丁丒丙与丐丏丁 != 0)
        {
                return;
        }
        
        val_10 = this.character;
        if(val_10 != null)
        {
            goto label_20;
        }
        
        goto label_17;
        label_13:
        val_10 = this.turret;
        if(val_10 != null)
        {
            goto label_20;
        }
        
        goto label_19;
        label_14:
        val_10 = this.mech;
        if(val_10 != null)
        {
            goto label_20;
        }
        
        label_19:
        label_17:
        label_20:
        val_10.gameObject.SetActive(value:  true);
    }
    public void ResetForRespawnWindow()
    {
        this.七丌与丁丙三丑丂丕.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.七丌与丁丙三丑丂丕.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
    }
    public void UpdateMech(int 丆丏丞丞万世世丏东)
    {
        this.mechBodyRenderer.material = this.mechBodyMaterials[(long)丆丏丞丞万世世丏东];
        this.mechHandRenderer.material = this.mechBodyMaterials[(long)丆丏丞丞万世世丏东];
        this.mechGunRenderer.material = this.mechGunMaterials[(long)丆丏丞丞万世世丏东];
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.mechBodyRenderer.material.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.mechHandRenderer.material.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
    }
    public void UpdateTurret(int 丕丅丂丏下丄丄丘丕)
    {
    
    }
    internal void 一三上三丆丂东丟三(string 三不三丟专丘东东丂, PGCompany.丟丝世万东万丆丟上 丅专丕三且丑丘专下, UnityEngine.Texture 丐万三丘东丌丝丗下, string 七一丐上丙丂丑丅丁, bool 下且丆且丂七丛与一)
    {
        PGCompany.丟丝世万东万丆丟上 val_13;
        var val_14;
        var val_15;
        val_13 = 丅专丕三且丑丘专下;
        this.丐丛丗丞丈一丑万丁().StopAllCoroutines();
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  三不三丟专丘东东丂);
        if(val_3 != null)
        {
                this.万丟一丙丙丅丗丒且().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_3.三与丛丑且丐丈业丌());
            this.万丟一丙丙丅丗丒且().且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  val_13);
        }
        else
        {
                object[] val_7 = new object[1];
            val_7[0] = 三不三丟专丘东东丂;
            UnityEngine.Debug.LogErrorFormat(format:  "Cannot get item record for weapon tag {0}", args:  val_7);
            val_15 = null;
            val_15 = null;
            val_13 = 与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与;
            this.万丟一丙丙丅丗丒且().世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  val_13);
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  七一丐上丙丂丑丅丁)) != false)
        {
                if((System.String.op_Inequality(a:  七一丐上丙丂丑丅丁, b:  "EMPTY_ROYALE_AVATAR")) != false)
        {
                this.万丟一丙丙丅丗丒且().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  七一丐上丙丂丑丅丁);
            return;
        }
        
        }
        
        this.万丟一丙丙丅丗丒且().上丈一万东三东世东(丂丒丘丅专丗丂世丛:  丐万三丘东丌丝丗下);
    }
    public void UpdateHat(string 上丈专丌万丕丙万丘, bool 丅丞七丟丘丆丟丘丞 = False)
    {
        string val_14;
        var val_15;
        var val_16;
        val_14 = 上丈专丌万丕丙万丘;
        val_15 = null;
        val_15 = null;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丈丂下丕丝丝丆丅下);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_16 = 七丌丞万七万丁丐丙.丗且且丁万丛丗与一();
            if(((val_16.IndexOf(item:  val_14)) & 2147483648) == 0)
        {
                val_16 = 七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_14);
        }
        
        }
        
        this.万丟一丙丙丅丗丒且().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  (val_16 < (七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_1))) ? (val_1) : (val_14));
        if(丅丞七丟丘丆丟丘丞 != false)
        {
                return;
        }
        
        this.万丟一丙丙丅丗丒且().不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丟万三丁丙丅东三三()) & 1);
    }
    public void RemoveHat()
    {
        this.万丟一丙丙丅丗丒且().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
    }
    public void UpdateCape(string 丈丐丕业下丟业丛一, UnityEngine.Texture 下万东丕丏丟丟丝丗, bool 丅丞七丟丘丆丟丘丞 = False)
    {
        this.万丟一丙丙丅丗丒且().丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一, 三丆业丘丑万丘世下:  下万东丕丏丟丟丝丗);
        if(丅丞七丟丘丆丟丘丞 != false)
        {
                return;
        }
        
        this.万丟一丙丙丅丗丒且().丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七()) & 1);
    }
    public void RemoveCape()
    {
        this.万丟一丙丙丅丗丒且().丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  System.String.alignConst);
    }
    public void UpdateMask(string 丟世丟丐且丐丟七上, bool 丅丞七丟丘丆丟丘丞 = False)
    {
        this.万丟一丙丙丅丗丒且().不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丟世丟丐且丐丟七上);
        if(丅丞七丟丘丆丟丘丞 != false)
        {
                return;
        }
        
        this.万丟一丙丙丅丗丒且().丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅()) & 1);
    }
    public void RemoveMask()
    {
        this.万丟一丙丙丅丗丒且().不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
    }
    public void UpdateBoots(string 上世丘丐东万丐丆不, bool 丅丞七丟丘丆丟丘丞 = False)
    {
        this.万丟一丙丙丅丗丒且().上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  上世丘丐东万丐丆不);
        if(丅丞七丟丘丆丟丘丞 != false)
        {
                return;
        }
        
        this.万丟一丙丙丅丗丒且().业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏()) & 1);
    }
    public void RemoveBoots()
    {
        this.万丟一丙丙丅丗丒且().上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  System.String.alignConst);
    }
    public void UpdatePet(string 上世丘丐东万丐丆不)
    {
        this.万丟一丙丙丅丗丒且().丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  上世丘丐东万丐丆不, 丐丕与丈丘丌东不丈:  2);
    }
    public void RemovePet()
    {
        this.万丟一丙丙丅丗丒且().丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  System.String.alignConst);
    }
    public void UpdateArmor(string 与丙丕丛一丌丛丆丈)
    {
        this.万丟一丙丙丅丗丒且().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  与丙丕丛一丌丛丆丈);
    }
    internal void 七丑世万东专丂与丏(string 与丙丕丛一丌丛丆丈, PGCompany.丙丕丑丑丆丂丗丗丟 丛丆世丂丒丁不世不)
    {
        var val_4;
        if(丛丆世丂丒丁不世不 != null)
        {
                string val_2 = 丛丆世丂丒丁不世不.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_4 = 0;
        }
        
        this.万丟一丙丙丅丗丒且().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  (val_4 == 0) ? 与丙丕丛一丌丛丆丈 : (val_4));
    }
    public void RemoveArmor()
    {
        this.万丟一丙丙丅丗丒且().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
    }
    internal static UnityEngine.Texture2D 丅丒丒丑东丑丅七业(string 一丘上丟丝丆丕丐丁)
    {
        string val_5;
        UnityEngine.Texture2D val_6;
        var val_7;
        val_5 = 一丘上丟丝丆丕丐丁;
        val_6 = 0;
        if((System.String.IsNullOrEmpty(value:  val_5)) == true)
        {
                return val_6;
        }
        
        val_5 = System.Convert.FromBase64String(s:  val_5);
        val_7 = null;
        val_7 = null;
        UnityEngine.Texture2D val_3 = null;
        val_6 = val_3;
        val_3 = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不, textureFormat:  5, mipChain:  false);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  val_3, data:  val_5, markNonReadable:  true);
        val_3.filterMode = 0;
        return val_6;
    }
    public CharacterView()
    {
    
    }

}
