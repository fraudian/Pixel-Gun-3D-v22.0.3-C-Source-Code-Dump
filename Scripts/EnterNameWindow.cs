using UnityEngine;
public class EnterNameWindow : MonoBehaviour
{
    // Fields
    private const string 万丌丑一世三万专丟 = "UserCharactersGUI/AskNamePlayer";
    private UIInput _nameInput;
    public UnityEngine.GameObject characterError;
    public UnityEngine.GameObject tapToEditNickLabel;
    public UIInput inputField;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private string 丛丟丒且丌丂丗丑丞;
    private System.Threading.Tasks.TaskCompletionSource<string> <不且丗丁不丄丝丒丂>k__BackingField;
    
    // Properties
    private System.Threading.Tasks.TaskCompletionSource<string> 业丒丐丑专一万世丌 { get; set; }
    internal System.Threading.Tasks.Task<string> 丌不丈万上世丞丈丈 { get; }
    
    // Methods
    private System.Threading.Tasks.TaskCompletionSource<string> 万丄丈丛丒丑丌丗丌()
    {
        return (System.Threading.Tasks.TaskCompletionSource<System.String>)this.<不且丗丁不丄丝丒丂>k__BackingField;
    }
    private void 丅丏丅丒丁丁丗东丗(System.Threading.Tasks.TaskCompletionSource<string> 丙业与丙丗丝不丈东)
    {
        this.<不且丗丁不丄丝丒丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Threading.Tasks.Task<string> 丛三一与丙万七丝不()
    {
        System.Threading.Tasks.TaskCompletionSource<System.String> val_2 = this.<不且丗丁不丄丝丒丂>k__BackingField;
        if(val_2 != null)
        {
                return val_1.Task;
        }
        
        System.Threading.Tasks.TaskCompletionSource<System.String> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Threading.Tasks.TaskCompletionSource<System.String>();
        this.<不且丗丁不丄丝丒丂>k__BackingField = val_2;
        if(val_2 != null)
        {
                return val_1.Task;
        }
        
        return val_1.Task;
    }
    internal static EnterNameWindow 下与丞三丅丛丄七丕(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        val_2.<不且丗丁不丄丝丒丂>k__BackingField = new System.Threading.Tasks.TaskCompletionSource<System.String>();
        return (EnterNameWindow)丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<EnterNameWindow>(丑与丞三且丛与丟业:  "UserCharactersGUI/AskNamePlayer", 七万上丐一丈丏丏专:  丈东丘丏与丌东东下.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void EnterNameWindow::U_Hide()), 与且专丈不万东一万:  "Enter Name Window");
        this.inputField.value = ProfileController.专不业业下东丆不世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  true);
    }
    private void OnDisable()
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
    internal void 万丟丏与丞丈七丂丕()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丛丟丒且丌丂丗丑丞.Trim())) != false)
        {
                return;
        }
        
        bool val_4 = this.<不且丗丁不丄丝丒丂>k__BackingField.TrySetResult(result:  this.丛丟丒且丌丂丗丑丞.Trim());
        this.丗丟万丂丘丈专丄丂();
    }
    internal void 丕丑专丈上丟丟业不()
    {
        bool val_1 = this.<不且丗丁不丄丝丒丂>k__BackingField.TrySetCanceled();
        this.丗丟万丂丘丈专丄丂();
    }
    private void 丗丟万丂丘丈专丄丂()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void OnChangeName()
    {
        this.丛丟丒且丌丂丗丑丞 = this._nameInput.value;
    }
    public void U_Accept()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  false);
        if((this.inputField.value.Length >= 3) && ((NickNameValidator.instance.ValidateNickName(丕丗丘丑丛与丑业丒:  this.inputField.value)) != false))
        {
                this.万丟丏与丞丈七丂丕();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  true);
        this.inputField.value = ProfileController.专不业业下东丆不世();
    }
    public void U_Hide()
    {
        this.丕丑专丈上丟丟业不();
    }
    public EnterNameWindow()
    {
        this.丛丟丒且丌丂丗丑丞 = System.String.alignConst;
    }

}
