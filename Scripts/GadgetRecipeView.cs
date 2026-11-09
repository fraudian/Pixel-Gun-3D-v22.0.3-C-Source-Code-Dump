using UnityEngine;
public class GadgetRecipeView : MonoBehaviour
{
    // Fields
    private PGCompany.ModuleGadgetView gadgetView;
    private WidgetLayout modulesLayout;
    private PGCompany.InventoryItemView itemViewExample;
    private UnityEngine.GameObject gadgetLocked;
    private UnityEngine.GameObject gadgetUnlocked;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专, string 丑世丁七丆万丙三丁, System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 三世丗丆丕万丐且三)
    {
        PGCompany.ModuleGadgetView val_9;
        UnityEngine.GameObject val_11;
        UnityEngine.GameObject val_12;
        val_9 = this.gadgetView;
        val_9.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  三丐三丞丘丕不丒专, 丑世丁七丆万丙三丁:  丑世丁七丆万丙三丁, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        bool val_1 = ModulesSetGadgetsStorage.下丗上丑丒与七专丆(丗丑丐丕丟丝且下丕:  三丐三丞丘丕不丒专.gadgetID);
        val_11 = this.gadgetLocked;
        if(val_11 == null)
        {
            goto label_5;
        }
        
        if(val_1 == false)
        {
            goto label_6;
        }
        
        label_24:
        val_11.SetActive(value:  false);
        this.gadgetUnlocked.SetActive(value:  true);
        this.modulesLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        val_11 = this.itemViewExample.gameObject;
        val_11.SetActive(value:  false);
        List.Enumerator<T> val_3 = 三世丗丆丕万丐且三.GetEnumerator();
        val_9 = 1152921525970025312;
        label_23:
        if((878813328 & 1) == 0)
        {
            goto label_12;
        }
        
        PGCompany.InventoryItemView val_6 = UnityEngine.Object.Instantiate<PGCompany.InventoryItemView>(original:  this.itemViewExample, parent:  this.modulesLayout.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_6.transform);
        val_6.Setup(与且专丈不万东一万:  0.丐丏七丌丕丗业且上());
        this.modulesLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_6);
        val_6.gameObject.SetActive(value:  true);
        goto label_23;
        label_5:
        if(val_1 == true)
        {
            goto label_24;
        }
        
        label_6:
        val_11.SetActive(value:  true);
        val_12 = this.gadgetUnlocked;
        val_12.SetActive(value:  false);
        return;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_12 = this.modulesLayout;
        val_12.Reposition();
    }
    public GadgetRecipeView()
    {
    
    }

}
