using UnityEngine;
public class ClanCreateGui : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
{
    // Fields
    private const string 业丄丛且丝三丗丏丅 = "NguiWindows/Clan/ClanCreate";
    private static ClanCreateGui 丄丘七三上丕世丞业;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private UIButton backButton;
    private Rilisoft.BankShopViewGuiElement BankShopGUI;
    private static System.Collections.Generic.List<UnityEngine.Texture2D> 三丞丏丗不丈上业上;
    private LoadingButton createButton;
    private Rilisoft.TextGroup headerTextGroup;
    private bool 丞上丄一丁丝丈丒丐;
    private bool 丘不下丛丞不不下丕;
    private UnityEngine.GameObject loadingObject;
    private UITexture logoTexture;
    private UIInput nameInput;
    private PGCompany.PopupList chooseRegionPopup;
    private System.Action 三丁丕丈丅丏丅丕丌;
    private System.Action 七丑丞丏丞丞丝上丗;
    private ClanCreateGui.上三丘丏一一丆丅丈 七上世丝丈丕丛丑丒;
    private UnityEngine.GameObject priceCoinsSprite;
    private UnityEngine.GameObject priceGemsSprite;
    private UILabel priceLabel;
    private UnityEngine.GameObject priceObject;
    private LoadingButton saveButton;
    private int 上丙与丌上丁与东丘;
    private int 一丐丟七丘丕丗且万;
    private SkinEditorController 丒丄丐丘业东丏专且;
    private UIInput sloganInput;
    private int 丟丄业丁丟丌世东丙;
    private UIButton _nextTypeButton;
    private UIButton _prevTypeButton;
    private UIButton _nextEntryRankButton;
    private UIButton _prevEntryRankButton;
    private UISprite _entryRankSprite;
    private UILabel _entryRankNameLabel;
    private UnityEngine.GameObject _privateTypeGameObject;
    private UnityEngine.GameObject _publicTypeGameObject;
    private DialogWindowController _exitDialogWindowController;
    private PGCompany.Clans.ChooseLogoClanCreate _chooseLogoController;
    private UILabel _entryRankDescriptionLabel;
    
    // Properties
    internal static ClanCreateGui 丆丕丝丒不丙且丐丗 { get; }
    internal static System.Collections.Generic.List<UnityEngine.Texture2D> 丗东丂丘丗三丐丕丅 { get; }
    private bool 业三丛丂业世丁与丏 { get; set; }
    public bool 东且世与一东丂一丆 { get; }
    
    // Methods
    internal static ClanCreateGui 丑七不且上丗丁一世()
    {
        null = null;
        return (ClanCreateGui)ClanCreateGui.丄丘七三上丕世丞业;
    }
    internal static System.Collections.Generic.List<UnityEngine.Texture2D> 三丗不丙丘丂业丝三()
    {
        object val_7;
        var val_8;
        System.Collections.Generic.IEnumerable<T> val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(ClanCreateGui.三丞丏丗不丈上业上 == null)
        {
                ClanCreateGui.下丌丛三下专丘丐丕 val_1 = null;
            val_7 = val_1;
            val_1 = new ClanCreateGui.下丌丛三下专丘丐丕();
            val_9 = UnityEngine.Resources.LoadAll<UnityEngine.Texture2D>(path:  "Clan_Previews/");
            if(val_9 == null)
        {
                UnityEngine.Texture2D[] val_3 = new UnityEngine.Texture2D[0];
            val_9 = val_3;
        }
        
            System.Collections.Generic.List<UnityEngine.Texture2D> val_4 = new System.Collections.Generic.List<UnityEngine.Texture2D>(collection:  val_3);
            val_10 = null;
            val_10 = null;
            ClanCreateGui.三丞丏丗不丈上业上 = val_4;
            .且丛下丆且万丏不与 = System.StringComparer.OrdinalIgnoreCase;
            val_4.Sort(comparison:  new System.Comparison<UnityEngine.Texture2D>(object:  val_1, method:  System.Int32 ClanCreateGui.下丌丛三下专丘丐丕::不上下丁且丛丆丛丑(UnityEngine.Texture2D 丆丛丑世下一丐且丕, UnityEngine.Texture2D 丌丗丏丏丛东专丁且)));
            val_8 = null;
        }
        
        val_8 = null;
        return (System.Collections.Generic.List<UnityEngine.Texture2D>)ClanCreateGui.三丞丏丗不丈上业上;
    }
    private bool 丁丆一丑丗东下业丛()
    {
        return (bool)this.丘不下丛丞不不下丕;
    }
    private void 丑专且不丞丝一丑万(bool 丙业与丙丗丝不丈东)
    {
        this.丘不下丛丞不不下丕 = 丙业与丙丗丝不丈东;
        丙业与丙丗丝不丈东 = (~丙业与丙丗丝不丈东) & 1;
        var val_3 = (丙业与丙丗丝不丈东 != true) ? 3 : 0;
        bool val_4 = 丙业与丙丗丝不丈东;
        (this.七上世丝丈丕丛丑丒 == 0) ? this.createButton : this.saveButton.Pressed = val_4;
        if(val_4 != false)
        {
                return;
        }
        
        this.东万东丗且丕业丒东();
    }
    public bool get___InterfaceEnabled()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    public void ShowWindow()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void HideWindow()
    {
        var val_9;
        var val_10;
        this.gameObject.SetActive(value:  false);
        if(this.丒丄丐丘业东丏专且 == 0)
        {
                return;
        }
        
        if(this.丒丄丐丘业东丏专且.gameObject == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丐丞丛丗丈丐丆丂丛(丞下上且一上丙不丏:  SkinEditorController.丄丞丁丈与业上丞丟.gameObject.GetComponent<UnityEngine.AudioSource>());
        SkinEditorController.丄七丌丄专东东七丑(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanCreateGui::与三且丐上丞丙东丌(string 丝丘丅与丌丗丅丈下)));
        UnityEngine.Object.Destroy(obj:  this.丒丄丐丘业东丏专且.gameObject);
    }
    private bool 万七丟丞丛不东不下()
    {
        int val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        val_23 = this;
        if(this.七上世丝丈丕丛丑丒 != 0)
        {
                if((this.七上世丝丈丕丛丑丒 == 1) && (this.丘不下丛丞不不下丕 != false))
        {
                val_24 = 0;
            return (bool)val_24;
        }
        
            val_25 = 1152921524404748272;
            if(((Rilisoft.Singleton<ClansController>.Instance) != 0) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null))
        {
                丞丂丘丒丟丞丑下丄 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            val_25 = this._publicTypeGameObject;
            val_24 = 1;
            if(this.丟丄业丁丟丌世东丙 != this.上丙与丌上丁与东丘)
        {
                return (bool)val_24;
        }
        
            val_25 = this.nameInput.value;
            if((System.String.op_Inequality(a:  val_25, b:  val_6.东丙上东业丆不丟丘())) != true)
        {
                val_25 = this.sloganInput.value;
            if((System.String.op_Inequality(a:  val_25, b:  val_6.丆不与丕世丏三丅一())) != true)
        {
                val_25 = this.chooseRegionPopup.丕丟丐丈丐丄丌三丐();
            if(val_25 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = val_25.GetStringValue();
        }
        
            if((System.String.op_Inequality(a:  val_25, b:  val_6.且丞东丑丟业丑丌万())) != true)
        {
                val_23 = this.一丐丟七丘丕丗且万;
            if(val_23 == val_6.丘丗丏丁丂丑一丌丙())
        {
                if(val_6.七东丏不与与丗丂丅() != false)
        {
                var val_23 = ((((val_25.activeSelf & true) != 0) ? (val_24 + 1) : (val_24)) != val_6.不业丙丒丂丞下丆丙()) ? 1 : 0;
            return (bool)val_24;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_24 = 1;
        return (bool)val_24;
    }
    private void 东万东丗且丕业丒东()
    {
        if(this.七上世丝丈丕丛丑丒 != 1)
        {
                return;
        }
        
        UIButton val_1 = this.saveButton.button;
        bool val_3 = this.万七丟丞丛不东不下();
        this = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 万七丄东丞丅丆三东()
    {
        var val_70;
        int val_71;
        UITexture val_72;
        var val_73;
        UnityEngine.GameObject val_74;
        var val_75;
        string val_76;
        var val_77;
        this.丞上丄一丁丝丈丒丐 = false;
        this.gameObject.SetActive(value:  true);
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  false);
        val_70 = null;
        val_70 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.HideBlockMessage();
        this._exitDialogWindowController.CloseWindow();
        if(ClanCreateGui.三丗不丙丘丂业丝三().Count >= 1)
        {
                this.上丙与丌上丁与东丘 = 0;
            UnityEngine.Texture2D val_5 = ClanCreateGui.三丗不丙丘丂业丝三().Item[this.上丙与丌上丁与东丘];
        }
        
        this._chooseLogoController.Clear();
        this._chooseLogoController.AddLogoItems(不丏业丛丟丒丕丑丘:  ClanCreateGui.三丗不丙丘丂业丝三());
        if(this.七上世丝丈丕丛丑丒 == 0)
        {
            goto label_18;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.BankShopGUI, 丏业丟一东丂东丘丛:  false);
        this.headerTextGroup.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4163");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.createButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.saveButton, 丏业丟一东丂东丘丛:  true);
        this.nameInput.value = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘();
        this.sloganInput.value = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丆不与丕世丏三丅一();
        val_71 = 0;
        goto label_30;
        label_42:
        if((System.String.op_Equality(a:  System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  ClanCreateGui.三丗不丙丘丂业丝三().Item[0])), b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丝丈三专丟丌丄丝())) == true)
        {
            goto label_38;
        }
        
        val_71 = 1;
        label_30:
        var val_70 = ClanCreateGui.三丗不丙丘丂业丝三().Count;
        val_70 = val_70 - 1;
        if(val_71 < val_70)
        {
            goto label_42;
        }
        
        ClanCreateGui.三丗不丙丘丂业丝三().Add(item:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌());
        this._chooseLogoController.AddLogoItem(丁且专丑万万丘丟七:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌());
        val_72 = this.logoTexture;
        this.上丙与丌上丁与东丘 = ClanCreateGui.三丗不丙丘丂业丝三().Count - 1;
        goto label_73;
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.BankShopGUI, 丏业丟一东丂东丘丛:  true);
        this.headerTextGroup.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4112");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.createButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.saveButton, 丏业丟一东丂东丘丛:  false);
        this.nameInput.value = System.String.alignConst;
        this.sloganInput.value = System.String.alignConst;
        if(ClansController.七丕业不七丄丗丏与() == null)
        {
            goto label_62;
        }
        
        val_73 = null;
        val_73 = null;
        if((System.String.op_Equality(a:  ClansController.七丕业不七丄丗丏与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_68;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceCoinsSprite, 丏业丟一东丂东丘丛:  true);
        val_74 = this.priceGemsSprite;
        val_75 = 0;
        goto label_71;
        label_38:
        this.上丙与丌上丁与东丘 = val_71;
        val_72 = this.logoTexture;
        label_73:
        UnityEngine.Texture2D val_40 = ClanCreateGui.三丗不丙丘丂业丝三().Item[this.上丙与丌上丁与东丘];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._publicTypeGameObject, 丏业丟一东丂东丘丛:  ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().不业丙丒丂丞下丆丙()) == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._privateTypeGameObject, 丏业丟一东丂东丘丛:  ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().不业丙丒丂丞下丆丙()) == 2) ? 1 : 0);
        this._entryRankSprite.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘丗丏丁丂丑一丌丙());
        val_76 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._entryRankNameLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  val_76.丘丗丏丁丂丑一丌丙()));
        this.一丐丟七丘丕丗且万 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘丗丏丁丂丑一丌丙();
        UIButton val_60 = this.saveButton.button;
        UIButton val_61 = this.saveButton.button;
        this.三丂丐七东上丌丅与();
        goto label_95;
        label_68:
        val_77 = null;
        val_77 = null;
        if((System.String.op_Equality(a:  ClansController.七丕业不七丄丗丏与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_101;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceCoinsSprite, 丏业丟一东丂东丘丛:  false);
        val_74 = this.priceGemsSprite;
        val_75 = 1;
        label_71:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_74, 丏业丟一东丂东丘丛:  true);
        label_101:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.priceLabel, 丕丗丘丑丛与丑业丒:  ClansController.七丕业不七丄丗丏与().丟丂丞不专丆万丒世().ToString());
        label_62:
        this.业且丒丏丝一丄业丂();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._publicTypeGameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._privateTypeGameObject, 丏业丟一东丂东丘丛:  false);
        val_76 = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  1);
        this._entryRankSprite.spriteName = val_76;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._entryRankNameLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  1));
        this.一丐丟七丘丕丗且万 = 1;
        label_95:
        this.丘丑丄丛不丝一下不();
        this.丟丄业丁丟丌世东丙 = this.上丙与丌上丁与东丘;
        this.东万东丗且丕业丒东();
        this.丞上丄一丁丝丈丒丐 = true;
    }
    private void 丘丑丄丛不丝一下不()
    {
        UILabel val_9;
        string val_10;
        bool val_1 = this._publicTypeGameObject.activeSelf;
        string val_5 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_1 != true) ? "Key_9215" : "Key_9214"), arg0:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  this.一丐丟七丘丕丗且万));
        if(val_1 != false)
        {
                val_9 = this._entryRankDescriptionLabel;
            val_10 = val_5;
        }
        else
        {
                val_9 = this._entryRankDescriptionLabel;
            val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9213")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9213")) + System.Environment.NewLine + val_5;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  val_10);
    }
    private void 业且丒丏丝一丄业丂()
    {
        var val_3;
        PGCompany.PopupList val_9;
        var val_10;
        string val_11;
        val_9 = this;
        this.chooseRegionPopup.Clear();
        val_10 = null;
        val_10 = null;
        List.Enumerator<T> val_1 = PGCompany.不东丏三丞丞东丕丙.丞一丌丙不丄丝且丐.GetEnumerator();
        label_7:
        if((1910372544 & 1) == 0)
        {
            goto label_5;
        }
        
        this.chooseRegionPopup.AddItemWithValue(丙业与丙丗丝不丈东:  val_3.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_11 = PGCompany.不东丏三丞丞东丕丙.丅丗丘三丒丝东丅万();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) != false)
        {
                val_11 = PGCompany.不东丏三丞丞东丕丙.丟与丄丒丝丗万丟丁();
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_11)) == false)
        {
                return;
        }
        
        val_9 = this.chooseRegionPopup;
        val_9.SelectItemWithValue(丙业与丙丗丝不丈东:  val_11);
    }
    private void 三丂丐七东上丌丅与()
    {
        PGCompany.PopupList val_10;
        var val_11;
        val_10 = this;
        this.chooseRegionPopup.Clear();
        val_11 = null;
        val_11 = null;
        List.Enumerator<T> val_1 = PGCompany.不东丏三丞丞东丕丙.丞一丌丙不丄丝且丐.GetEnumerator();
        label_7:
        if((1910550088 & 1) == 0)
        {
            goto label_5;
        }
        
        this.chooseRegionPopup.AddItemWithValue(丙业与丙丗丝不丈东:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().且丞东丑丟业丑丌万())) == false)
        {
                return;
        }
        
        val_10 = this.chooseRegionPopup;
        val_10.SelectItemWithValue(丙业与丙丗丝不丈东:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().且丞东丑丟业丑丌万());
    }
    internal static void 丌万丗与七丄丕不丁(ClanCreateGui.上三丘丏一一丆丅丈 丂丛丑东不丅丈一东, System.Action 丛丝与丂世丌丌丝丂, System.Action 不丘丘丝丅丁且丞丝)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                if((丂丛丑东不丅丈一东 != 1) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null))
        {
            goto label_6;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Can\'t open ClanCreateGUI: Something is bad!");
        if(丛丝与丂世丌丌丝丂 == null)
        {
                return;
        }
        
        丛丝与丂世丌丌丝丂.Invoke();
        return;
        label_6:
        val_9 = null;
        val_9 = null;
        if(ClanCreateGui.丄丘七三上丕世丞业 == 0)
        {
                val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            ClanCreateGui.丄丘七三上丕世丞业 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "NguiWindows/Clan/ClanCreate", 七万上丐一丈丏丏专:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<ClanCreateGui>();
        }
        else
        {
                val_12 = null;
            val_12 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ClanCreateGui.丄丘七三上丕世丞业, 丏业丟一东丂东丘丛:  true);
        }
        
        val_13 = null;
        val_13 = null;
        if(ClanCreateGui.丄丘七三上丕世丞业 == null)
        {
                val_13 = null;
        }
        
        七上世丝丈丕丛丑丒 = 丂丛丑东不丅丈一东;
        if(ClanCreateGui.丄丘七三上丕世丞业 == null)
        {
                val_13 = null;
        }
        
        三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        if(ClanCreateGui.丄丘七三上丕世丞业 == null)
        {
                val_13 = null;
        }
        
        七丑丞丏丞丞丝上丗 = 不丘丘丝丅丁且丞丝;
        ClanCreateGui.丄丘七三上丕世丞业.万七丄东丞丅丆三东();
    }
    private void 丝与东丝不三世下丘()
    {
        var val_3;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowInterface(丄丐丙丏业丐世丐丛:  0);
    }
    private void 丁下丑专丞丏与丄丘()
    {
        var val_15;
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  true);
        val_15 = this.logoTexture;
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.万丛丄丅三与上丈丞(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanCreateGui::丄丕世丛丛一丂丛丐(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.丛丗三业下丑丑丈与(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void ClanCreateGui::丐丁丕万东丁与下世(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        var val_16 = 0;
        val_16 = val_16 + 1;
        string val_8 = this.chooseRegionPopup.丕丟丐丈丐丄丌三丐().GetStringValue();
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丈丏丆丙丌丞万丑丄().丂丅丅丘丈丘丌丈与(丒丘丏上丙丟丑丕丈:  this.nameInput.value, 专丛丙丛下一丟丗万:  System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  (null == null) ? (val_15) : 0)), 丗一丈丟丌且与丂丏:  this.sloganInput.value, 三不业东丂丅丕丒丗:  this._privateTypeGameObject.activeSelf, 万丅丝丈上丅丘丈丘:  val_8, 万丂不丁丟丄世专下:  this.一丐丟七丘丕丗且万);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_8)) == false)
        {
                return;
        }
        
        PGCompany.不东丏三丞丞东丕丙.丐丒丑丗丛三不丒三(上丏万丕丆七不与万:  val_8);
    }
    private void 上上丝丕丁丆业丈一()
    {
        var val_15;
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  true);
        val_15 = this.logoTexture;
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.丟专丝一丗丐世丒上(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanCreateGui::世上不丕万三丏丟东(bool 丗万且丌世不丗不专)));
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.世丘丐丄丗下万丏丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanCreateGui::专万万丝丌与丌丛与(int 丂七东不不丈一丐不)));
        var val_16 = 0;
        val_16 = val_16 + 1;
        string val_8 = this.chooseRegionPopup.丕丟丐丈丐丄丌三丐().GetStringValue();
        var val_14 = (this._privateTypeGameObject.activeSelf != true) ? (1 + 1) : 1;
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丁丌一丄三业丗东丘().丟丈世与丌丝丒业七(专丐下丙丐七丑丑丂:  this.nameInput.value, 下丂丏丘丈不丘丙丞:  this.sloganInput.value, 丘业丘不丝一丁丄丙:  System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  (null == null) ? (val_15) : 0)), 下丞业丂丂丟且丘丆:  new System.Nullable<丏丆丘丌且丒丏丄丏>() {HasValue = false}, 一丟丛丆丛业丗丘丆:  new System.Nullable<System.Int32>() {HasValue = false}, 丟丟不丌丄丟丈丂丙:  0, 一东丐一东丄一万丙:  val_8, 万丂不丁丟丄世专下:  new System.Nullable<System.Int32>() {HasValue = false});
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_8)) == false)
        {
                return;
        }
        
        PGCompany.不东丏三丞丞东丕丙.丐丒丑丗丛三不丒三(上丏万丕丆七不与万:  val_8);
    }
    private void 丄丏丒一丅丝上丄三()
    {
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.世丗与上东丞三丈一(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanCreateGui::丄丕世丛丛一丂丛丐(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)));
        PGCompany.Clans.Network.丂丏万丙丟世与丄丟.不专丑丛丌丕一丘丏(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void ClanCreateGui::丐丁丕万东丁与下世(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  false);
    }
    private void 丄丕世丛丛一丂丛丐(int 丂七东不不丈一丐不, string 一丐丗丁丞丆丅丟丄)
    {
        var val_6;
        ClansWindowGUI val_7;
        string val_8;
        var val_9;
        this.丄丏丒一丅丝上丄三();
        if(丂七东不不丈一丐不 == 1710)
        {
            goto label_1;
        }
        
        if(丂七东不不丈一丐不 != 1708)
        {
            goto label_2;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_8 = "Key_0268";
        goto label_7;
        label_1:
        val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938");
        InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  val_7, 丂三丟丂丈丐丆丗丟:  ((System.Int32.TryParse(s:  一丐丗丁丞丆丅丟丄, result: out  0)) != true) ? 0f : 1200f);
        return;
        label_2:
        val_9 = null;
        val_9 = null;
        val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_8 = "Key_1528";
        label_7:
        val_7.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
    }
    private void 丐丁丕万东丁与下世(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)
    {
        var val_6;
        this.丄丏丒一丅丝上丄三();
        val_6 = null;
        val_6 = null;
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不, textureFormat:  5, mipChain:  false);
        bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  System.Convert.FromBase64String(s:  丅丈丛丅丝东七丂且));
        val_2.filterMode = 0;
        InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1441"), 世丙丁丗业丝世丕丈:  0, 不且丁丐不丌丟上丌:  val_2, 不上丏上丝丆一丛丑:  0);
        this.gameObject.SetActive(value:  false);
        if(this.七丑丞丏丞丞丝上丗 == null)
        {
                return;
        }
        
        this.七丑丞丏丞丞丝上丗.Invoke();
    }
    private void 上一一丏丑丛丗丛丟()
    {
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.三丐万万丂一丁丙业(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanCreateGui::世上不丕万三丏丟东(bool 丗万且丌世不丗不专)));
        PGCompany.Clans.Network.上丞丞丐下丐丕丝一.丄一丁丕丌丂丛东七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanCreateGui::专万万丝丌与丌丛与(int 丂七东不不丈一丐不)));
        this.丑专且不丞丝一丑万(丙业与丙丗丝不丈东:  false);
    }
    private void 专万万丝丌与丌丛与(int 丂七东不不丈一丐不)
    {
        var val_2;
        var val_3;
        ClansWindowGUI val_4;
        string val_5;
        var val_6;
        this.上一一丏丑丛丗丛丟();
        val_2 = null;
        if(丂七东不不丈一丐不 == 1708)
        {
                val_3 = null;
            val_4 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_5 = "Key_0268";
        }
        else
        {
                val_6 = null;
            val_4 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_5 = "Key_1528";
        }
        
        val_4.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
    }
    private void 世上不丕万三丏丟东(bool 丗万且丌世不丗不专)
    {
        this.上一一丏丑丛丗丛丟();
        this.gameObject.SetActive(value:  false);
        if(this.七丑丞丏丞丞丝上丗 == null)
        {
                return;
        }
        
        this.七丑丞丏丞丞丝上丗.Invoke();
    }
    private void 与三且丐上丞丙东丌(string 丝丘丅与丌丗丅丈下)
    {
        var val_12;
        var val_13;
        System.Action<System.String> val_14;
        var val_15;
        UnityEngine.Texture2D val_16;
        val_12 = null;
        val_12 = null;
        val_13 = null;
        val_13 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丐丞丛丗丈丐丆丂丛(丞下上且一上丙不丏:  SkinEditorController.丄丞丁丈与业上丞丟.gameObject.GetComponent<UnityEngine.AudioSource>());
        System.Action<System.String> val_3 = null;
        val_14 = val_3;
        val_3 = new System.Action<System.String>(object:  this, method:  System.Void ClanCreateGui::与三且丐上丞丙东丌(string 丝丘丅与丌丗丅丈下));
        SkinEditorController.丄七丌丄专东东七丑(丙业与丙丗丝不丈东:  val_3);
        if((System.String.IsNullOrEmpty(value:  丝丘丅与丌丗丅丈下)) == true)
        {
            goto label_8;
        }
        
        val_15 = null;
        val_15 = null;
        UnityEngine.Texture2D val_5 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  SkinsController.丄丞上丟专丘丒丝不);
        System.Collections.Generic.List<UnityEngine.Texture2D> val_6 = ClanCreateGui.三丗不丙丘丂业丝三();
        if(val_6 == null)
        {
            goto label_15;
        }
        
        if(this.logoTexture == null)
        {
            goto label_16;
        }
        
        label_18:
        var val_7 = (null == null) ? this.logoTexture : 0;
        goto label_17;
        label_15:
        if(this.logoTexture != null)
        {
            goto label_18;
        }
        
        label_16:
        val_16 = 0;
        label_17:
        val_6.Add(item:  val_16);
        val_14 = this.logoTexture;
        this._chooseLogoController.AddLogoItem(丁且专丑万万丘丟七:  val_14);
        this.上丙与丌上丁与东丘 = ClanCreateGui.三丗不丙丘丂业丝三().Count - 1;
        label_8:
        this.gameObject.SetActive(value:  true);
        this.东万东丗且丕业丒东();
    }
    public void OnNameInputChanged()
    {
        if(this.丞上丄一丁丝丈丒丐 == false)
        {
                return;
        }
        
        this.东万东丗且丕业丒东();
    }
    public void OnSloganIputChanged()
    {
        if(this.丞上丄一丁丝丈丒丐 == false)
        {
                return;
        }
        
        this.东万东丗且丕业丒东();
    }
    public void U_LogoCLick()
    {
        object val_10;
        UnityEngine.Texture2D val_11;
        val_10 = this;
        if(this.logoTexture == 0)
        {
                return;
        }
        
        this.丒丄丐丘业东丏专且 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "SkinEditorController")).GetComponent<SkinEditorController>();
        SkinEditorController.丒丛七丘丙一东丛东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanCreateGui::与三且丐上丞丙东丌(string 丝丘丅与丌丗丅丈下)));
        SkinEditorController.丐丁世与三丅丗不一 = 2;
        val_11 = this.logoTexture;
        if((val_11 != null) && (null != null))
        {
                val_11 = 0;
        }
        
        SkinEditorController.东业丕三且丁与上丂 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_11);
        this.丒丄丐丘业东丏专且.transform.parent = 0;
        val_10 = this.gameObject;
        val_10.SetActive(value:  false);
    }
    public void U_ConfirmButtonClick()
    {
        object val_19;
        var val_20;
        丈丞丕丘丕丗与上一 val_21;
        var val_22;
        var val_23;
        val_19 = this;
        if(this.万七丟丞丛不东不下() == false)
        {
            goto label_1;
        }
        
        if((System.String.op_Equality(a:  this.nameInput.value, b:  System.String.alignConst)) == false)
        {
            goto label_3;
        }
        
        val_20 = null;
        val_20 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1490"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
        return;
        label_1:
        this.U_BackRequest();
        return;
        label_3:
        if(this.七上世丝丈丕丛丑丒 != 0)
        {
                this.上上丝丕丁丆业丈一();
            return;
        }
        
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  ClansController.七丕业不七丄丗丏与().与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_16;
        }
        
        }
        
        val_21 = ClansController.七丕业不七丄丗丏与();
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_21, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void ClanCreateGui::丁下丑专丞丏与丄丘()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  this, method:  System.Void ClanCreateGui::丝与东丝不三世下丘()), 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  true, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  77);
        return;
        label_16:
        UnityEngine.Debug.LogError(message:  "Create clan (not enough currency) -> GoToMainStore");
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丙丂丒丌且丝一丘专;
        val_19 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_21 = ClansController.七丕业不七丄丗丏与().东与三丌丅三丒丏业();
        val_19.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_21, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丙丂丒丌且丝一丘专, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public void U_BackRequest()
    {
        if(this.丘不下丛丞不不下丕 != false)
        {
                return;
        }
        
        if((this.七上世丝丈丕丛丑丒 == 1) && (this.万七丟丞丛不东不下() != false))
        {
                this._exitDialogWindowController.add_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanCreateGui::丝东丐丝东三丈世丝()));
            this._exitDialogWindowController.add_OnCancelAction(丙业与丙丗丝不丈东:  new System.Action(object:  this._exitDialogWindowController, method:  public System.Void DialogWindowController::CloseWindow()));
            this = ???;
        }
        else
        {
                this.丝东丐丝东三丈世丝();
        }
    
    }
    private void 丝东丐丝东三丈世丝()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this.三丁丕丈丅丏丅丕丌 == null)
        {
                return;
        }
        
        this.三丁丕丈丅丏丅丕丌.Invoke();
    }
    private void 丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        var val_12;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                UnityEngine.Debug.LogError(message:  "Create clan -> GoToMainStore");
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  0, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "create-clan", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
            return;
        }
        
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_10;
        }
        
        ClanCreateGui.丂一七世业一不丞专 val_6 = new ClanCreateGui.丂一七世业一不丞专();
        if(val_6 == null)
        {
            goto label_11;
        }
        
        .丝且与丝丒丟万丁专 = this;
        goto label_12;
        label_10:
        UnityEngine.Debug.LogWarning(message:  "BankController.Instance == null");
        return;
        label_11:
        mem[24] = this;
        label_12:
        .丛丟丌丝丈丞上丕丈 = 0;
        .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  val_6, method:  System.Void ClanCreateGui.丂一七世业一不丞专::世且丝丄不且下丙专(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ClanCreateGui.丂一七世业一不丞专)[1152921536585389568].丛丟丌丝丈丞上丕丈);
        this.gameObject.SetActive(value:  false);
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_12 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丕世世下上丌丞丘;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丕世世下上丌丞丘);
    }
    private void OnEnable()
    {
        this.BankShopGUI.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanCreateGui::丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.chooseRegionPopup.下丅东丏不丒丐上东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丂丈丘三丒丈不专丘>(object:  this, method:  System.Void ClanCreateGui::丟丁丌丌丆丐专丆丌(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)));
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                return;
        }
        
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanCreateGui::U_BackRequest()), 与且专丈不万东一万:  "ClanCreate");
    }
    private void 丟丁丌丌丆丐专丆丌(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)
    {
        this.东万东丗且丕业丒东();
    }
    private void OnDisable()
    {
        this.BankShopGUI.丆世丅三下丗丆丝丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanCreateGui::丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.chooseRegionPopup.上丟丘不丘丝丅丞业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丂丈丘三丒丈不专丘>(object:  this, method:  System.Void ClanCreateGui::丟丁丌丌丆丐专丆丌(PGCompany.丂丈丘三丒丈不专丘 万且万且丑丗且丌丆)));
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    private void Start()
    {
        this.BankShopGUI.且不丄丂上专丗三七(丙业与丙丗丝不丈东:  1);
        this.BankShopGUI.ShowTickets = false;
        this.BankShopGUI.丝一丅丆三东丂丞七();
    }
    public void U_NextType()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._publicTypeGameObject, 丏业丟一东丂东丘丛:  (~this._publicTypeGameObject.activeSelf) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._privateTypeGameObject, 丏业丟一东丂东丘丛:  (~this._privateTypeGameObject.activeSelf) & 1);
        this.丘丑丄丛不丝一下不();
        this.东万东丗且丕业丒东();
    }
    public void U_PrevType()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._publicTypeGameObject, 丏业丟一东丂东丘丛:  (~this._publicTypeGameObject.activeSelf) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._privateTypeGameObject, 丏业丟一东丂东丘丛:  (~this._privateTypeGameObject.activeSelf) & 1);
        this.丘丑丄丛不丝一下不();
        this.东万东丗且丕业丒东();
    }
    public void U_NextRank()
    {
        int val_5;
        int val_1 = this.一丐丟七丘丕丗且万 + 1;
        this.一丐丟七丘丕丗且万 = val_1;
        if(val_1 > 丌丅且丗七丘丅丛丑.丅不不丝不不丒下丂())
        {
                val_5 = 1;
            this.一丐丟七丘丕丗且万 = val_5;
        }
        else
        {
                val_5 = this.一丐丟七丘丕丗且万;
        }
        
        this._entryRankSprite.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_5);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._entryRankNameLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  this.一丐丟七丘丕丗且万));
        this.丘丑丄丛不丝一下不();
        this.东万东丗且丕业丒东();
    }
    public void U_PrevRank()
    {
        int val_5 = this.一丐丟七丘丕丗且万 - 1;
        this.一丐丟七丘丕丗且万 = val_5;
        if(val_5 <= 0)
        {
                val_5 = 丌丅且丗七丘丅丛丑.丅不不丝不不丒下丂();
            this.一丐丟七丘丕丗且万 = val_5;
        }
        
        this._entryRankSprite.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_5);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._entryRankNameLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  this.一丐丟七丘丕丗且万));
        this.丘丑丄丛不丝一下不();
        this.东万东丗且丕业丒东();
    }
    public void U_ChooseLogo()
    {
        this._chooseLogoController.Open(丄丂万丄上丁丑下丝:  new System.Action<PGCompany.Clans.ChooseLogoItem, System.Int32>(object:  this, method:  System.Void ClanCreateGui::丘丘丘丕丏丆三丙且(PGCompany.Clans.ChooseLogoItem 丅上丁三丄丕丆丒东, int 丆专且丕专丗与一丏)));
    }
    private void 丘丘丘丕丏丆三丙且(PGCompany.Clans.ChooseLogoItem 丅上丁三丄丕丆丒东, int 丆专且丕专丗与一丏)
    {
        this.上丙与丌上丁与东丘 = 丆专且丕专丗与一丏;
        UnityEngine.Texture val_1 = 丅上丁三丄丕丆丒东.GetTexture();
        this.东万东丗且丕业丒东();
    }
    public ClanCreateGui()
    {
        this.上丙与丌上丁与东丘 = 8589934591;
        this.一丐丟七丘丕丗且万 = 1;
        this.丟丄业丁丟丌世东丙 = 0;
    }
    private static ClanCreateGui()
    {
    
    }

}
