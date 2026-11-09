using UnityEngine;
public class GadgetRecipesUI : MonoBehaviour
{
    // Fields
    private UIScrollView scrollView;
    private WidgetLayout widgetLayout;
    private SelectableButtonController categories;
    private CaptionView captionViewExample;
    private GadgetRecipeView gadgetRecipeViewExample;
    private GadgetRecipesCategoryButton categoryButtonExample;
    private bool 丝与丆丞东丘丈东丘;
    public float delta;
    public float epsilon;
    
    // Properties
    private bool 丘丝丏世与丒丛丂不 { get; set; }
    
    // Methods
    private void OnEnable()
    {
        this.丘上丐世丆丑且丞丒();
    }
    private bool 东业万丕且丘丏丑丞()
    {
        return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "GadgetRecipesUI_AvailableGadgetsUnlocked", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
    }
    private void 丑不丌下丙上万丗丒(bool 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "GadgetRecipesUI_AvailableGadgetsUnlocked", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_10;
        string val_35;
        if(this.东业万丕且丘丏丑丞() != true)
        {
                PGCompany.ModulesController val_2 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            val_2.丝下丐丏丁丂万丟且();
            val_2.丑不丌下丙上万丗丒(丙业与丙丗丝不丈东:  false);
        }
        
        this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        this.captionViewExample.gameObject.SetActive(value:  false);
        this.gadgetRecipeViewExample.gameObject.SetActive(value:  false);
        this.categoryButtonExample.gameObject.SetActive(value:  false);
        List.Enumerator<T> val_8 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丙丄不专丐丑丘七丂().GetEnumerator();
        val_35 = 1152921505284374528;
        label_52:
        if((877943440 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_11 = val_10.丐丏七丌丕丗业且上();
        if((System.String.op_Inequality(a:  "", b:  val_11.丒万丕七专不丏丞丌())) != false)
        {
                string val_14 = val_11.丒万丕七专不丏丞丌();
            CaptionView val_16 = UnityEngine.Object.Instantiate<CaptionView>(original:  this.captionViewExample, parent:  this.widgetLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_16.transform);
            val_16.丈且东丑丂且万丒丅(万丑丞一丝丌丐丒丘:  "shop_icons_" + val_14.ToLower(), 丕丗丘丑丛与丑业丒:  PGCompany.万丞丘与丕丞下万丌.且丗一业下丄丛丈且(七丆丒与丗丌丄且丂:  val_14));
            this.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_16);
            val_16.gameObject.SetActive(value:  true);
            GadgetRecipesCategoryButton val_23 = UnityEngine.Object.Instantiate<GadgetRecipesCategoryButton>(original:  this.categoryButtonExample, parent:  this.categories.widgetLayout.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_23.transform);
            val_23.丈且东丑丂且万丒丅(丒上万丆万丁七与三:  val_16, 丛丐丌丙丈七丛丛东:  "shop_icons_" + val_14.ToLower(), 不丛丒世丙七丌业万:  this);
            val_23.Select(丛丁三七丅且丝丏丙:  false);
            val_35 = val_35;
            val_23.gameObject.SetActive(value:  true);
        }
        
        GadgetRecipeView val_29 = UnityEngine.Object.Instantiate<GadgetRecipeView>(original:  this.gadgetRecipeViewExample, parent:  this.widgetLayout.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_29.transform);
        val_29.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  ModulesSetGadgetsStorage.Instance.丄丝丒与丆丛丙专丅(丗丄万丄丌丕丈丈三:  val_35), 丑世丁七丆万丙三丁:  "", 三世丗丆丕万丐且三:  val_11.丟上丅丝丐业丟丌丌());
        this.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_29);
        val_29.gameObject.SetActive(value:  true);
        goto label_52;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.widgetLayout.Reposition();
        this.categories.widgetLayout.Reposition();
    }
    public void ScrollTo(float 下业丕七东丌丝下且)
    {
        this.scrollView.DisableSpring();
        float val_1 = this.delta + 下业丕七东丌丝下且;
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_5 = this.scrollView.panel.clipOffset;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  -下业丕七东丌丝下且);
        this.scrollView.panel.clipOffset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    private void Update()
    {
        var val_5;
        System.Collections.Generic.List<SelectableButton> val_14;
        var val_15;
        val_14 = this.categories.allButtons;
        if(val_14.Count < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = this.categories.allButtons.GetEnumerator();
        label_17:
        val_14 = this.categories.allButtons.Item[0];
        label_16:
        if((878462352 & 1) == 0)
        {
            goto label_8;
        }
        
        val_15 = val_5.丐丏七丌丕丗业且上();
        val_15 = 0;
        UnityEngine.Vector3 val_8 = 123372880.transform.localPosition;
        UnityEngine.Vector3 val_10 = this.scrollView.transform.localPosition;
        if((val_8.y + this.epsilon) < (-val_10.y))
        {
            goto label_16;
        }
        
        goto label_17;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_14 == 0)
        {
                return;
        }
    
    }
    public GadgetRecipesUI()
    {
        this.delta = 20f;
        this.epsilon = -200f;
    }

}
