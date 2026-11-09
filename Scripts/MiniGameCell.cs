using UnityEngine;
public class MiniGameCell : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject newModeIndicator;
    public System.Collections.Generic.List<UILabel> price;
    public UnityEngine.GameObject openState;
    public UnityEngine.GameObject lockedState;
    public UnityEngine.GameObject offlineHolder;
    public System.Collections.Generic.List<UISprite> ratingSprites;
    public System.Collections.Generic.List<UILabel> levelRequiredLabels;
    internal Rilisoft.七丕丟丏三丈一丄世 type;
    private 丌丑丕丏丝丆上东丄 <七丗丟丄丅且丐丟东>k__BackingField;
    private float 丗与下丑丟世丆丕丈;
    
    // Properties
    public 丌丑丕丏丝丆上东丄 丄丗丒专丆与丈上丁 { get; set; }
    
    // Methods
    public void Setup(丌丑丕丏丝丆上东丄 丗丅七业丝不三丄三)
    {
        丌丑丕丏丝丆上东丄 val_21;
        var val_22;
        var val_23;
        UnityEngine.GameObject val_24;
        var val_25;
        var val_26;
        var val_27;
        MiniGameCell.业东下丕世丗丏万丏 val_1 = new MiniGameCell.业东下丕世丗丏万丏();
        if(val_1 != null)
        {
                val_21 = val_1;
            .丗丅七业丝不三丄三 = 丗丅七业丝不三丄三;
        }
        else
        {
                val_21 = 16;
            mem[16] = 丗丅七业丝不三丄三;
        }
        
        this.<七丗丟丄丅且丐丟东>k__BackingField = val_21;
        if(this.type == 11)
        {
                val_22 = 1;
        }
        else
        {
                val_23 = null;
            val_23 = null;
            if(ExperienceController.sharedController != 0)
        {
                var val_4 = (ExperienceController.丞丞丘业东丙丏七丌() >= (丗丅七业丝不三丄三 + 16)) ? 1 : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        }
        
        bool val_5 = OfflineModController.丂东丏丒丆下与丈业(与丝丛东上丆丁丘丕:  this.type);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offlineHolder, 丏业丟一东丂东丘丛:  val_5);
        if(val_5 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  (val_22 == 0) ? 1 : 0);
            val_24 = this.offlineHolder;
            val_25 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  false);
            val_24 = this.offlineHolder;
            val_25 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  true);
        UnityEngine.GameObject val_9 = this.price.Item[0].gameObject;
        if(val_9 == null)
        {
            goto label_29;
        }
        
        if((丗丅七业丝不三丄三 + 20) == 0)
        {
            goto label_30;
        }
        
        label_36:
        val_9.SetActive(value:  true);
        this.price.Item[0].text = mem[16] + 20.ToString();
        goto label_35;
        label_29:
        if((丗丅七业丝不三丄三 + 20) != 0)
        {
            goto label_36;
        }
        
        label_30:
        val_9.SetActive(value:  false);
        label_35:
        this.levelRequiredLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void MiniGameCell.业东下丕世丗丏万丏::丆一且世上丗上一丗(UILabel 七丐丞丑丑丕世丙七)));
        val_26 = 0;
        三业丌且丄丐丐一专 val_15 = Rilisoft.七丐丛专丞东一不世.丑七不且上丗丁一世().丒丙万丁丝下丏下与(上且丗一丏丏万丅丌:  this.type);
        val_27 = 0;
        goto label_41;
        label_47:
        val_26 = public UISprite System.Collections.Generic.List<UISprite>::get_Item(int index);
        float val_21 = 0f;
        val_21 = (float)val_15.丈丐世下丞与丂专丏 - val_21;
        this.ratingSprites.Item[0].fillAmount = UnityEngine.Mathf.Clamp01(value:  val_21);
        val_27 = 1;
        label_41:
        if(val_27 < this.ratingSprites.Count)
        {
            goto label_47;
        }
        
        UIButton val_19 = this.GetComponent<UIButton>();
        bool val_20 = val_22 & val_5;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public 丌丑丕丏丝丆上东丄 get_Parameters()
    {
        return (丌丑丕丏丝丆上东丄)this.<七丗丟丄丅且丐丟东>k__BackingField;
    }
    public void set_Parameters(丌丑丕丏丝丆上东丄 丙业与丙丗丝不丈东)
    {
        this.<七丗丟丄丅且丐丟东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Update()
    {
        var val_7;
        if(this.newModeIndicator == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = val_3 - this.丗与下丑丟世丆丕丈;
        if(val_3 < 1f)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        Rilisoft.七丕丟丏三丈一丄世 val_7 = this.type;
        val_7 = MainMenuController.丄丞丁丈与业上丞丟.丞丅东丄丁丝丕丘三().Contains(item:  val_7);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newModeIndicator, 丏业丟一东丂东丘丛:  val_7);
        this.丗与下丑丟世丆丕丈 = UnityEngine.Time.realtimeSinceStartup;
    }
    public MiniGameCell()
    {
        this.丗与下丑丟世丆丕丈 = -3.402823E+38f;
    }

}
