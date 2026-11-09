using UnityEngine;
public class PropertiesPopupController : MonoBehaviour
{
    // Fields
    private UIGrid grid;
    private System.Collections.Generic.List<PropertyUI> properties;
    private UIWidget heightRegulator;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(string 丒东业不丐丑丕丄丆, int 丟丕丞丁丝丂上丄上)
    {
        this.GetComponent<UIPanel>().depth = 丟丕丞丁丝丂上丄上;
        this.丈且东丑丂且万丒丅(丒东业不丐丑丕丄丆:  丒东业不丐丑丕丄丆);
    }
    internal void 丈且东丑丂且万丒丅(string 丒东业不丐丑丕丄丆)
    {
        string val_13;
        string val_16;
        string val_19;
        object val_25;
        UIWidget val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        UIWidget val_34;
        var val_35;
        UIGrid val_36;
        val_25 = this;
        this.丌下丄丌七丕丞业东();
        val_26 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        this.丐丆七且丞丏下三丙 = val_26.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PropertiesPopupController::Hide()), 与且专丈不万东一万:  "PropertiesPopupController");
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_4 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_5 = val_4.丞丁下丅上不且丐丄();
        val_27 = 1152921538189204720;
        val_28 = 1152921524342359424;
        val_29 = 1152921505284374528;
        val_30 = 0;
        goto label_7;
        label_25:
        val_31 = val_5.Count;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.properties.Item[0], 丏业丟一东丂东丘丛:  (val_30 < val_31) ? 1 : 0);
        if(val_30 < val_5.Count)
        {
                val_32 = null;
            val_32 = null;
            System.ValueTuple<System.String, System.String, System.String> val_12 = WeaponSounds.三丘丒万丛丞与一不.Item[val_5.Item[0]];
            val_31 = val_13;
            System.ValueTuple<System.String, System.String, System.String> val_15 = WeaponSounds.三丘丒万丛丞与一不.Item[val_5.Item[0]];
            System.ValueTuple<System.String, System.String, System.String> val_18 = WeaponSounds.三丘丒万丛丞与一不.Item[val_5.Item[0]];
            this.properties.Item[0].世与东丗世三丞丞不(世丒丟丂丟丟丈丄丙:  val_31, 丟丕丞丁丝丂上丄上:  102, 丛丐丌丙丈七丛丛东:  val_16, 丟丒丏丛三丟丑丗丝:  val_19, 丌丒丝东丌下丕丁丅:  "1", 丙丝与丆三丝不且丑:  0f, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            val_28 = val_28;
            val_33 = val_25;
            val_29 = 1152921505284374528;
            val_27 = 1152921538189204720;
        }
        
        val_30 = 1;
        label_7:
        if(val_30 < this.properties.Count)
        {
            goto label_25;
        }
        
        val_26 = this.heightRegulator;
        if(val_26 == 0)
        {
            goto label_28;
        }
        
        int val_22 = val_5.Count;
        if(val_22 == 2)
        {
            goto label_30;
        }
        
        if(val_22 != 1)
        {
            goto label_31;
        }
        
        val_34 = this.heightRegulator;
        val_35 = 204;
        goto label_35;
        label_30:
        val_34 = this.heightRegulator;
        val_35 = 324;
        goto label_35;
        label_31:
        val_34 = this.heightRegulator;
        val_35 = 444;
        label_35:
        val_34.height = 188;
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        val_36 = this.grid;
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丌下丄丌七丕丞业东();
    }
    private void 丌下丄丌七丕丞业东()
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
    public PropertiesPopupController()
    {
    
    }

}
