using UnityEngine;
public class UISavedOption : MonoBehaviour
{
    // Fields
    public string keyName;
    private UIPopupList 丟丂与东业专三丕丏;
    private UIToggle 三丐专丂下万丞丄丁;
    private UIProgressBar 丘业丐三七七三下下;
    
    // Properties
    private string 下上丐丆丝丟丝丒不 { get; }
    
    // Methods
    private string 丟三一万专专下上丘()
    {
        if((System.String.IsNullOrEmpty(value:  this.keyName)) == false)
        {
                return (string)this.keyName;
        }
        
        return "NGUI State: "("NGUI State: ") + this.name;
    }
    private void Awake()
    {
        this.丟丂与东业专三丕丏 = this.GetComponent<UIPopupList>();
        this.三丐专丂下万丞丄丁 = this.GetComponent<UIToggle>();
        this.丘业丐三七七三下下 = this.GetComponent<UIProgressBar>();
    }
    private void OnEnable()
    {
        object val_35;
        丒万业丛丏东专世丟 val_36;
        object val_37;
        var val_38;
        var val_39;
        int val_40;
        val_35 = this;
        val_36 = 1152921504848912384;
        if(this.丟丂与东业专三丕丏 == 0)
        {
            goto label_3;
        }
        
        EventDelegate.丒万业丛丏东专世丟 val_2 = null;
        val_36 = val_2;
        val_2 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void UISavedOption::SaveSelection());
        EventDelegate val_3 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.丟丂与东业专三丕丏.onChange, 业丏丈世世世丞丒世:  val_2);
        if((System.String.IsNullOrEmpty(value:  UnityEngine.PlayerPrefs.GetString(key:  this.丟三一万专专下上丘()))) == true)
        {
                return;
        }
        
        val_37 = ???;
        val_36 = ???;
        val_38 = ???;
        goto typeof(UIPopupList).__il2cppRuntimeField_178;
        label_3:
        if((val_37 + 40) != 0)
        {
                EventDelegate val_9 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_37 + 40 + 72, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_37, 丛丌丙世专世东丕下:  public System.Void UISavedOption::SaveState()));
            val_37 + 40.value = ((UnityEngine.PlayerPrefs.GetInt(key:  val_37.丟三一万专专下上丘(), defaultValue:  val_37 + 40 + 64)) != 0) ? 1 : 0;
            return;
        }
        
        if((val_37 + 48) != 0)
        {
                EventDelegate val_25 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_37 + 48 + 96, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_37, 丛丌丙世专世东丕下:  public System.Void UISavedOption::SaveProgress()));
            val_37 + 48.value = UnityEngine.PlayerPrefs.GetFloat(key:  val_37.丟三一万专专下上丘(), defaultValue:  val_37 + 48.value);
            return;
        }
        
        val_39 = val_37.GetComponentsInChildren<UIToggle>(includeInactive:  true);
        if(val_31.Length < 1)
        {
                return;
        }
        
        val_40 = val_31.Length & 4294967295;
        val_38 = 0;
        goto label_27;
        label_31:
        val_40 = val_31.Length;
        val_38 = 1;
        label_27:
        string val_35 = UnityEngine.PlayerPrefs.GetString(key:  val_37.丟三一万专专下上丘());
        val_35 = System.String.op_Equality(a:  val_36.name, b:  val_35);
        val_36.value = val_35;
        if((val_40 - 1) != val_38)
        {
            goto label_31;
        }
    
    }
    private void OnDisable()
    {
        System.Collections.Generic.List<EventDelegate> val_10;
        IntPtr val_12;
        int val_13;
        var val_14;
        if(this.三丐专丂下万丞丄丁 == 0)
        {
            goto label_3;
        }
        
        val_10 = this.三丐专丂下万丞丄丁.onChange;
        val_12 = 1152921531122823920;
        goto label_10;
        label_3:
        if(this.丟丂与东业专三丕丏 == 0)
        {
            goto label_8;
        }
        
        val_10 = this.丟丂与东业专三丕丏.onChange;
        val_12 = 1152921531122802416;
        goto label_10;
        label_8:
        if(this.丘业丐三七七三下下 == 0)
        {
            goto label_13;
        }
        
        val_10 = this.丘业丐三七七三下下.onChange;
        EventDelegate.丒万业丛丏东专世丟 val_4 = null;
        val_12 = 1152921531122837232;
        label_10:
        val_4 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  val_12);
        bool val_5 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  val_10, 业丏丈世世世丞丒世:  val_4);
        return;
        label_13:
        if(val_6.Length < 1)
        {
                return;
        }
        
        val_13 = val_6.Length & 4294967295;
        val_14 = 0;
        goto label_19;
        label_23:
        val_14 = 1;
        if(val_14 >= (long)val_13)
        {
                return;
        }
        
        val_13 = val_6.Length;
        label_19:
        if(value == false)
        {
            goto label_23;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  this.丟三一万专专下上丘(), value:  name);
    }
    public void SaveSelection()
    {
        var val_2 = null;
        UnityEngine.PlayerPrefs.SetString(key:  this.丟三一万专专下上丘(), value:  UIPopupList.专三丆三与下丕丆不);
    }
    public void SaveState()
    {
        var val_4 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  this.丟三一万专专下上丘(), value:  UIToggle.current.value);
    }
    public void SaveProgress()
    {
        UnityEngine.PlayerPrefs.SetFloat(key:  this.丟三一万专专下上丘(), value:  UIProgressBar.current.value);
    }
    public UISavedOption()
    {
    
    }

}
