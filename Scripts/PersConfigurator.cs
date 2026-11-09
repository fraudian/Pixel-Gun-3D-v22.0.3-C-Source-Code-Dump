using UnityEngine;
public sealed class PersConfigurator : MonoBehaviour
{
    // Fields
    private static PersConfigurator <世且丙与丕上丒丝一>k__BackingField;
    private CharacterInterfaceV2 <三丞丁丅丅一一不丒>k__BackingField;
    private UnityEngine.Transform petHolder;
    private UnityEngine.MeshRenderer _shadowRenderer;
    
    // Properties
    internal static PersConfigurator 业丝丏丑丏丏丐丙丆 { get; set; }
    internal CharacterInterfaceV2 东丗丏世丑与丌丒丄 { get; set; }
    internal static string 丐丛丈不丂与丆不业 { get; }
    
    // Methods
    internal static PersConfigurator 下一丁七丅丕七万丑()
    {
        return (PersConfigurator)PersConfigurator.<世且丙与丕上丒丝一>k__BackingField;
    }
    private static void 丄三丏业三丛三东与(PersConfigurator 丙业与丙丗丝不丈东)
    {
        PersConfigurator.<世且丙与丕上丒丝一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal CharacterInterfaceV2 丗丛丄丁丛丅与丘丐()
    {
        return (CharacterInterfaceV2)this.<三丞丁丅丅一一不丒>k__BackingField;
    }
    private void 世丐专丈与且丘丌丆(CharacterInterfaceV2 丙业与丙丗丝不丈东)
    {
        this.<三丞丁丅丅一一不丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.GameObject val_11;
        PersConfigurator.<世且丙与丕上丒丝一>k__BackingField = this;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
        CharacterInterfaceV2 val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_11).GetComponent<CharacterInterfaceV2>();
        this.<三丞丁丅丅一一不丒>k__BackingField = val_4;
        val_4.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
        this.<三丞丁丅丅一一不丒>k__BackingField.petPoint = this.petHolder;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<三丞丁丅丅一一不丒>k__BackingField.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        this.<三丞丁丅丅一一不丒>k__BackingField.七丄且一丟丄丄丝丟(丙业与丙丗丝不丈东:  true);
        this.<三丞丁丅丅一一不丒>k__BackingField.丟且丟七丌丞专七丁();
        this.<三丞丁丅丅一一不丒>k__BackingField.业七不专丝丘且万丁(丙业与丙丗丝不丈东:  true);
        this.<三丞丁丅丅一一不丒>k__BackingField.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏());
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.<三丞丁丅丅一一不丒>k__BackingField.gameObject);
    }
    private void 下丂丂丙丘不东丟丄(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三, string 与丏七丞三与丐丆业)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  丁丂专业丁丅丅丈丙);
    }
    private void 专丕丒丘业丘专下一(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  丁丂专业丁丅丅丈丙);
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PersConfigurator.东且丞丗万与丌丞丑();
    }
    private void 且丄世丒丄且丙丗丝(int 万且万且丑丗且丌丆)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  万且万且丑丗且丌丆);
    }
    private void 且丟丙且丑三专丌丘(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  丛丆东与丑丞丅丝专);
    }
    private void 丑丐丙上丆丕丗丙丐(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)
    {
        this.UpdateWeaponSkin(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘);
    }
    private void 上丏上丞丐丕丆三世(string 丅丐丞丞丐丘东丘丘)
    {
        this.UpdateWeaponSkin(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘);
    }
    public void UpdateWeaponSkin(string 丅丐丞丞丐丘东丘丘)
    {
        CharacterInterfaceV2 val_8 = this.<三丞丁丅丅一一不丒>k__BackingField;
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = this.<三丞丁丅丅一一不丒>k__BackingField.且万丘丈上丏丟且业();
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = this.<三丞丁丅丅一一不丒>k__BackingField.且万丘丈上丏丟且业();
        if((System.String.op_Equality(a:  val_8.三与丛丑且丐丈业丌(), b:  丅丐丞丞丐丘东丘丘)) == false)
        {
                return;
        }
        
        this.<三丞丁丅丅一一不丒>k__BackingField.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘));
    }
    private void 与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  且丆丏丛东下上丄丟);
    }
    private void OnEnable()
    {
        this.<三丞丁丅丅一一不丒>k__BackingField.业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
    }
    private void 专丞丛东专且丟东丌()
    {
        string val_1 = Rilisoft.万丂丕丁三一丒三丞.丘上丑丕下丘丛专丞();
        Rilisoft.万丂丕丁三一丒三丞.丂丒世下丟丐丁上丕(丙业与丙丗丝不丈东:  val_1);
        this.<三丞丁丅丅一一不丒>k__BackingField.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_1);
        this.<三丞丁丅丅一一不丒>k__BackingField.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  val_1));
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.<三丞丁丅丅一一不丒>k__BackingField.gameObject);
    }
    private void 七万专七下丌丄丛一(string 丞丅上丏丂且下丅与)
    {
        string val_1 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_1)) != false)
        {
                if((System.String.op_Inequality(a:  val_1, b:  "EMPTY_ROYALE_AVATAR")) != false)
        {
                this.<三丞丁丅丅一一不丒>k__BackingField.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈());
            return;
        }
        
        }
        
        this.丙丘与万业丒丁丆丛();
    }
    internal void 七万专七下丌丄丛一()
    {
        this.七万专七下丌丄丛一(丞丅上丏丂且下丅与:  null);
    }
    private void 丙丘与万业丒丁丆丛()
    {
        null = null;
        this.<三丞丁丅丅一一不丒>k__BackingField.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  SkinsController.丌与世丂丘且下丒丑);
    }
    internal void 上丛丆丛丐丕一一丏(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丛丆丒业丑丁丄丆丞)
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  丛丆丒业丑丁丄丆丞.一与丆丐丟上丆丅丐);
    }
    public void UpdateWear()
    {
        this.UpdateWear(丛丂丁丒丟且世上东:  null);
    }
    public void UpdateWear(string 丛丂丁丒丟且世上东)
    {
        string val_22;
        var val_23;
        this.<三丞丁丅丅一一不丒>k__BackingField.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  七丌丞万七万丁丐丙.一万丌东丄世上丕丟());
        this.<三丞丁丅丅一一不丒>k__BackingField.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七()) & 1);
        this.<三丞丁丅丅一一不丒>k__BackingField.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝());
        this.<三丞丁丅丅一一不丒>k__BackingField.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅()) & 1);
        val_22 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
        val_23 = null;
        val_23 = null;
        string val_8 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丈丂下丕丝丝丆丅下);
        this.<三丞丁丅丅一一不丒>k__BackingField.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  ((七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_22)) < (七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_8))) ? (val_8) : (val_22));
        this.<三丞丁丅丅一一不丒>k__BackingField.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丟万三丁丙丅东三三()) & 1);
        this.<三丞丁丅丅一一不丒>k__BackingField.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐());
        this.<三丞丁丅丅一一不丒>k__BackingField.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏()) & 1);
        this.专丞丛东专且丟东丌();
        this.丞丈丛丅丗丒丟七七();
        this.七万专七下丌丄丛一();
    }
    private void 丞丈丛丅丗丒丟七七()
    {
        string val_4 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
        PGCompany.丙丕丑丑丆丂丗丗丟 val_2 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_4);
        if(val_2 != null)
        {
                string val_3 = val_2.业上丙丞丐丄丆丅七();
        }
        
        val_4 = (val_3 == null) ? (val_4) : (val_3);
        this.<三丞丁丅丅一一不丒>k__BackingField.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  val_4);
        ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  this.<三丞丁丅丅一一不丒>k__BackingField, 下丈丝丁丟下世丐丒:  false);
    }
    private void Update()
    {
        float val_10;
        float val_11;
        UnityEngine.Object val_20 = UnityEngine.Camera.main;
        if(val_20 == 0)
        {
                return;
        }
        
        int val_4 = UnityEngine.Screen.width;
        int val_5 = UnityEngine.Screen.height;
        var val_6 = (val_4 < 0) ? (val_4 + 1) : (val_4);
        val_6 = val_6 >> 1;
        var val_8 = ((val_5 < 0) ? (val_5 + 1) : (val_5)) >> 1;
        UnityEngine.Ray val_9 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_20 = UnityEngine.Input.touchCount;
        if(val_20 < 1)
        {
                return;
        }
        
        var val_19 = 0;
        label_12:
        UnityEngine.Touch val_13 = UnityEngine.Input.GetTouch(index:  0);
        if(专三三与三且一且一() != 0)
        {
            goto label_7;
        }
        
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_11, y = val_11, z = val_11}, m_Direction = new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_10}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1000f, layerMask:  -5)) == false)
        {
            goto label_7;
        }
        
        if((0.gameObject.name.Equals(value:  "MainMenu_Pers")) == true)
        {
            goto label_11;
        }
        
        label_7:
        val_19 = val_19 + 1;
        if(val_19 < val_20)
        {
            goto label_12;
        }
        
        return;
        label_11:
        ConnectScene.与丄丅丁丂丏东下丝();
    }
    private void OnDestroy()
    {
        var val_11;
        var val_12;
        丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PersConfigurator::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        丆丟七丌丞东丆丕丌.丂下下丒丘丙丘丟一(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this, method:  System.Void PersConfigurator::下丂丂丙丘不东丟丄(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三, string 与丏七丞三与丐丆业)));
        丆丟七丌丞东丆丕丌.不丕丘业专丐丙万丑(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this, method:  System.Void PersConfigurator::专丕丒丘业丘专下一(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三)));
        val_11 = null;
        val_11 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_12 = null;
            val_12 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = 0;
        }
        
        三丐下丁丒丆丘下丄.丝且丁丌丟丑业且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void PersConfigurator::UpdateWear()));
        三丐下丁丒丆丘下丄.万丒丐丕丈丏上业丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void PersConfigurator::UpdateWear()));
        PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PersConfigurator::上丛丆丛丐丕一一丏(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丛丆丒业丑丁丄丆丞)));
        Progress.丌丆丈丛丁不丁万丒.丂专丑东丂丏与与丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟>(object:  this, method:  System.Void PersConfigurator::且丟丙且丑三专丌丘(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不)));
        Progress.丌丆丈丛丁不丁万丒.丘丑且下丁丈专丝三(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PersConfigurator::且丄世丒丄且丙丗丝(int 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.上丛丗丐下丅专东丟(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  public System.Void PersConfigurator::UpdateWear(string 丛丂丁丒丟且世上东)));
        PersConfigurator.<世且丙与丕上丒丝一>k__BackingField = 0;
    }
    public void EnableShadow(bool 丑丒业丘丑东丕世丅)
    {
        if(this._shadowRenderer == 0)
        {
                return;
        }
        
        this._shadowRenderer.enabled = 丑丒业丘丑东丕世丅;
    }
    internal static void 与与丑丂丛上七上丗()
    {
        PersConfigurator val_2 = PersConfigurator.<世且丙与丕上丒丝一>k__BackingField;
        if(val_2 == 0)
        {
                return;
        }
        
        val_2 = PersConfigurator.<世且丙与丕上丒丝一>k__BackingField;
        val_2.UpdateWear(丛丂丁丒丟且世上东:  0);
    }
    internal static string 不下万丄丏丁万丗万()
    {
        return "ƦƘΆƝ";
    }
    public PersConfigurator()
    {
    
    }

}
