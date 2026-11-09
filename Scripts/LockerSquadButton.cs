using UnityEngine;
public class LockerSquadButton : MonoBehaviour
{
    // Fields
    public UILabel lockerLabel;
    public UnityEngine.GameObject lockerObject;
    public UnityEngine.GameObject duelLockerObject;
    public UILabel duelLockerLabel;
    public UnityEngine.Collider squadButton;
    public bool CanDisableCkicks;
    internal int 丗丗丑丑与东丗丅三;
    internal bool 且业一丕且丒丅丁七;
    private bool <丄丐与丕七丞丝业丌>k__BackingField;
    
    // Properties
    public bool 业且万丝丛东丂丄丑 { get; set; }
    
    // Methods
    public bool get_IsLocked()
    {
        return (bool)this.<丄丐与丕七丞丝业丌>k__BackingField;
    }
    private void 七丄丐丙一业丐丒专(bool 丙业与丙丗丝不丈东)
    {
        this.<丄丐与丕七丞丝业丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void SetUnlockProgress(int 丗丗丑丑与东丗丅三, bool 且业一丕且丒丅丁七 = False)
    {
        this.丗丗丑丑与东丗丅三 = 丗丗丑丑与东丗丅三;
        this.且业一丕且丒丅丁七 = 且业一丕且丒丅丁七;
    }
    private void Awake()
    {
        this.<丄丐与丕七丞丝业丌>k__BackingField = false;
        this.UpdateState();
        I2.Loc.丗丈下丕丟丟丙七丞.三世丅丁丝丟丛丄丝(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LockerSquadButton::丞万专丒丁丒丅丙丆()));
    }
    private void OnEnable()
    {
        this.<丄丐与丕七丞丝业丌>k__BackingField = false;
        this.UpdateState();
    }
    private void OnDestroy()
    {
        I2.Loc.丗丈下丕丟丟丙七丞.丑丘丆丘世丕丌专七(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LockerSquadButton::丞万专丒丁丒丅丙丆()));
    }
    private void Update()
    {
        this.UpdateState();
    }
    public void UpdateState()
    {
        var val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        bool val_26;
        if(this.且业一丕且丒丅丁七 != false)
        {
                val_23 = 1;
            val_24 = 1;
        }
        else
        {
                val_23 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  this.丗丗丑丑与东丗丅三);
            val_24 = val_23;
            if(this.且业一丕且丒丅丁七 == false)
        {
            goto label_44;
        }
        
        }
        
        Rilisoft.一世东上七三丌丅不 val_21 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        bool val_22 = ~(val_21.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  8));
        var val_4 = val_22 & 1;
        label_44:
        val_21 = val_4 & val_24;
        val_22 = val_21 ^ 1;
        this.<丄丐与丕七丞丝业丌>k__BackingField = val_22;
        UIToggle val_5 = this.GetComponent<UIToggle>();
        if(val_5 == 0)
        {
            goto label_9;
        }
        
        if(val_21 == false)
        {
            goto label_10;
        }
        
        label_43:
        val_5.enabled = val_21;
        label_9:
        if((val_21 != this.squadButton.enabled) && (this.CanDisableCkicks != false))
        {
                this.squadButton.enabled = val_21;
        }
        
        val_25 = this.lockerLabel.gameObject;
        if(val_24 != val_25.activeSelf)
        {
            goto label_28;
        }
        
        UnityEngine.GameObject val_12 = this.lockerLabel.gameObject;
        if(val_23 == false)
        {
            goto label_20;
        }
        
        val_26 = 0;
        if(val_12 != null)
        {
            goto label_25;
        }
        
        goto label_22;
        label_20:
        val_26 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        if(val_12 != null)
        {
            goto label_25;
        }
        
        label_22:
        label_25:
        val_12.SetActive(value:  val_26);
        val_25 = this.lockerObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  false);
        if(val_23 != true)
        {
                this.且丌一三业丐世三丅();
        }
        
        label_28:
        if(this.duelLockerObject == 0)
        {
                return;
        }
        
        if(val_4 != this.duelLockerObject.gameObject.activeSelf)
        {
                return;
        }
        
        UnityEngine.GameObject val_18 = this.duelLockerObject.gameObject;
        if(val_4 == 0)
        {
            goto label_36;
        }
        
        val_25 = 0;
        if(val_18 != null)
        {
            goto label_47;
        }
        
        label_48:
        label_47:
        val_18.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockerObject, 丏业丟一东丂东丘丛:  false);
        if(val_4 == 0)
        {
            goto label_40;
        }
        
        return;
        label_10:
        val_5.Set(丏业丟一东丂东丘丛:  false);
        if(val_5 != null)
        {
            goto label_43;
        }
        
        goto label_43;
        label_36:
        var val_20 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        if(val_18 != null)
        {
            goto label_47;
        }
        
        goto label_48;
        label_40:
        this.且丌一三业丐世三丅();
    }
    private void 且丌一三业丐世三丅()
    {
        UILabel val_6;
        if(this.且业一丕且丒丅丁七 != false)
        {
                val_6 = this.duelLockerLabel;
            string val_3 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  8).ToString();
        }
        else
        {
                val_6 = this.lockerLabel;
        }
        
        val_6.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  this.丗丗丑丑与东丗丅三);
    }
    private void 丞万专丒丁丒丅丙丆()
    {
        this.且丌一三业丐世三丅();
    }
    public LockerSquadButton()
    {
        this.CanDisableCkicks = true;
        this.丗丗丑丑与东丗丅三 = 0;
    }

}
