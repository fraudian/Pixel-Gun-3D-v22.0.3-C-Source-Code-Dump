using UnityEngine;
public class QuestTasksGSCraftController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject variantsContainer;
    public UnityEngine.GameObject noVariantsContainer;
    public UnityEngine.GameObject[] bg;
    public UIBasicSprite[] itemIcons;
    public UILabel[] itemNames;
    public UISprite[] arrows;
    public UISprite chooseButtonArrow;
    private string 东丏丗丑丗丑丐丆丅;
    private string[] 三丘丂丆丏东下与丗;
    private string 不丁丄不一且丘与专;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    private UIBasicSprite[] 丐且七与三上丏丝丆 { get; }
    public string 丒丁世丂业下丄业上 { get; }
    
    // Methods
    private UIBasicSprite[] 丕丐丕丕且且世与上()
    {
        var val_2;
        UIBasicSprite[] val_3;
        val_2 = 0;
        goto label_1;
        label_10:
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  static_value_082C7020);
        val_2 = 1;
        label_1:
        val_3 = this.itemIcons;
        if(this.itemIcons == null)
        {
                val_3 = this.itemIcons;
        }
        
        if(val_2 < this.itemIcons.Length)
        {
            goto label_10;
        }
        
        return val_3;
    }
    public string get_TaskId()
    {
        return (string)this.东丏丗丑丗丑丐丆丅;
    }
    public void ShowNoVariants(string 东一七丟与丗三丐不, string 丏世丁丄业丏丏一七)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noVariantsContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.variantsContainer, 丏业丟一东丂东丘丛:  false);
        this.东丏丗丑丗丑丐丆丅 = 东一七丟与丗三丐不;
        this.不丁丄不一且丘与专 = 丏世丁丄业丏丏一七;
        this.丟丌丈不专丑世万专();
    }
    public void ShowNoVariants(string 东一七丟与丗三丐不)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noVariantsContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.variantsContainer, 丏业丟一东丂东丘丛:  false);
        this.东丏丗丑丗丑丐丆丅 = 东一七丟与丗三丐不;
    }
    public void HandleOk()
    {
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "gacha")) != false)
        {
                val_12 = null;
            val_12 = null;
            PlayCloseGift();
        }
        
        val_13 = "newsbox";
        if((((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "newsbox")) != true) && ((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "ad_chest")) != true)) && ((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "flag_piedestal")) != true))
        {
                if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "igrovoy_avtomat")) != true)
        {
                if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "radar")) == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        PlayFromItem();
        label_10:
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "newsbox")) != false)
        {
                val_15 = null;
            val_15 = null;
            val_13 = this.东丏丗丑丗丑丐丆丅;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  val_13);
        }
        
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "ad_chest")) != false)
        {
                val_16 = null;
            val_16 = null;
            val_13 = this.东丏丗丑丗丑丐丆丅;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  val_13);
        }
        
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "flag_piedestal")) != false)
        {
                val_17 = null;
            val_17 = null;
            val_13 = this.东丏丗丑丗丑丐丆丅;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  val_13);
        }
        
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "igrovoy_avtomat")) != false)
        {
                val_18 = null;
            val_18 = null;
            val_13 = this.东丏丗丑丗丑丐丆丅;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  val_13);
        }
        
        if((System.String.op_Equality(a:  this.东丏丗丑丗丑丐丆丅, b:  "radar")) != false)
        {
                val_19 = null;
            val_19 = null;
            val_13 = this.东丏丗丑丗丑丐丆丅;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  val_13);
            MainMenuController.丄丞丁丈与业上丞丟.丆七丌三丈丕丅丗专();
        }
        
        this.丆世与丑丆丅丐万且();
    }
    public void Show(string 东一七丟与丗三丐不, string[] 下丈下业丝上丟上丅)
    {
        string val_13 = 东一七丟与丗三丐不;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noVariantsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.variantsContainer, 丏业丟一东丂东丘丛:  true);
        this.东丏丗丑丗丑丐丆丅 = val_13;
        this.三丘丂丆丏东下与丗 = 下丈下业丝上丟上丅;
        this.不丁丄不一且丘与专 = 下丈下业丝上丟上丅[1];
        if(下丈下业丝上丟上丅.Length >= 1)
        {
                do
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  下丈下业丝上丟上丅[0]);
            UIBasicSprite val_16 = this.丕丐丕丕且且世与上()[0];
            UnityEngine.Texture val_5 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_2.丙三专万丛丟万丝丘());
            val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            this.itemNames[0].text = val_13;
        }
        while((0 + 1) < 下丈下业丝上丟上丅.Length);
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[0].gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[1].gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[2].gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseButtonArrow.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[0], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[1], 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[2], 丏业丟一东丂东丘丛:  false);
        this.丟丌丈不专丑世万专();
    }
    public void HandleChoose()
    {
        var val_7;
        Rilisoft.丏丘七丞丄丙丌丞丁 val_1 = this.丌世丁丞不丑世且丆();
        bool val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_1, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
        System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_5 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_1, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
        val_7 = null;
        val_7 = null;
        PlayFromItem();
        MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  this.东丏丗丑丗丑丐丆丅);
        QuestsGSMAnager.丑七不且上丗丁一世().CompleteActiveTask();
        this.丆世与丑丆丅丐万且();
    }
    public void HandleFirstTrigger()
    {
        this.不丁丄不一且丘与专 = this.三丘丂丆丏东下与丗[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[0].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[1].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[2].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseButtonArrow.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[0], 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[1], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[2], 丏业丟一东丂东丘丛:  false);
        this.丟丌丈不专丑世万专();
    }
    public void HandleSecondTrigger()
    {
        this.不丁丄不一且丘与专 = this.三丘丂丆丏东下与丗[1];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[0].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[1].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[2].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseButtonArrow.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[0], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[1], 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[2], 丏业丟一东丂东丘丛:  false);
        this.丟丌丈不专丑世万专();
    }
    public void HandleThirdTrigger()
    {
        this.不丁丄不一且丘与专 = this.三丘丂丆丏东下与丗[2];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[0].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[1].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrows[2].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseButtonArrow.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[0], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[1], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bg[2], 丏业丟一东丂东丘丛:  true);
        this.丟丌丈不专丑世万专();
    }
    private void 丟丌丈不专丑世万专()
    {
        Rilisoft.丏丘七丞丄丙丌丞丁 val_8;
        System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丑七丆丄一三不下丁();
        .丑丘丕且丆东丏丘丙 = this.丌世丁丞不丑世且丆();
        System.Predicate<Rilisoft.丏丘七丞丄丙丌丞丁> val_5 = new System.Predicate<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  new QuestTasksGSCraftController.业丂七丏丟丕丌丂世(), method:  System.Boolean QuestTasksGSCraftController.业丂七丏丟丕丌丂世::万专丞丒丝丐三业三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
        if(val_3 != null)
        {
                int val_6 = val_3.RemoveAll(match:  val_5);
            val_8 = (QuestTasksGSCraftController.业丂七丏丟丕丌丂世)[1152921536030421040].丑丘丕且丆东丏丘丙;
        }
        else
        {
                int val_7 = 0.RemoveAll(match:  val_5);
            val_8 = (QuestTasksGSCraftController.业丂七丏丟丕丌丂世)[1152921536030421040].丑丘丕且丆东丏丘丙;
        }
        
        0.Add(item:  val_8);
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.与丅丒丝七丛丑丅丞(丑七不与丛丆一丂丞:  val_3, 丒丞丐丘且不且丟东:  true, 丆且丌丟丅一丙东丁:  false);
    }
    private Rilisoft.丏丘七丞丄丙丌丞丁 丌世丁丞不丑世且丆()
    {
        return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean QuestTasksGSCraftController::三丗丂万与丈丑且不(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
    }
    private void Awake()
    {
        var val_4;
        this.东三世丙丁丒丝世丕();
        Rilisoft.BackSystem val_1 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        val_4 = null;
        val_4 = null;
        if((QuestTasksGSCraftController.<>c.<>9__21_0) == null)
        {
            goto label_5;
        }
        
        label_11:
        this.丐丆七且丞丏下三丙 = val_1.Register(业丏丈世世世丞丒世:  QuestTasksGSCraftController.<>c.<>9__21_0, 与且专丈不万东一万:  "QuestTasksGSCraftController");
        return;
        label_5:
        QuestTasksGSCraftController.<>c.<>9__21_0 = new System.Action(object:  QuestTasksGSCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void QuestTasksGSCraftController.<>c::丏与七东丒丙东不丞());
        if(val_1 != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    private void 丆世与丑丆丅丐万且()
    {
        null = null;
        HideSmallHint();
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public QuestTasksGSCraftController()
    {
    
    }
    private bool 三丗丂万与丈丑且不(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
    {
        return System.String.op_Equality(a:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七(), b:  this.不丁丄不一且丘与专);
    }

}
