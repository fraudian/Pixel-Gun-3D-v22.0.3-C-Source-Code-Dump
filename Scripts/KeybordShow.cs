using UnityEngine;
public class KeybordShow : MonoBehaviour
{
    // Fields
    public UILabel _Uil;
    public UnityEngine.GameObject CF;
    public int maxChars;
    private UnityEngine.TouchScreenKeyboard 丗丏一丛丄七丞万与;
    public bool mKeybordHold;
    private string 丟万世丞丑三丟三一;
    
    // Methods
    private void Start()
    {
        this._Uil = this.CF.GetComponent<UILabel>();
        UnityEngine.Vector3 val_3 = this.CF.transform.position;
        float val_5 = posNGUI.丆丗丞丗上一业丄专(丐丗丌丞丂世丙丏丅:  0f);
        float val_6 = posNGUI.丒世丁万丏丅丌不丛(丅丘丏丆丟丗与丅不:  0f);
        this.CF.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this._Uil.lineWidth = UnityEngine.Screen.width;
        this.丗丏一丛丄七丞万与 = UnityEngine.TouchScreenKeyboard.Open(text:  "", keyboardType:  0, autocorrection:  false, multiline:  false);
    }
    private void Update()
    {
        var val_17;
        string val_18;
        if(this.丗丏一丛丄七丞万与 == null)
        {
                return;
        }
        
        string val_1 = this.丗丏一丛丄七丞万与.text;
        if((System.String.op_Inequality(a:  this.丟万世丞丑三丟三一, b:  val_1)) == false)
        {
            goto label_2;
        }
        
        val_17 = 0;
        this.丟万世丞丑三丟三一 = "";
        goto label_3;
        label_7:
        char val_3 = val_1.Chars[0];
        if((val_3 & 65535) != 0)
        {
                this.丟万世丞丑三丟三一 = this.丟万世丞丑三丟三一 + val_3;
        }
        
        val_17 = 1;
        label_3:
        if(val_17 < val_1.Length)
        {
            goto label_7;
        }
        
        if(this.maxChars >= 1)
        {
                if(this.丗丏一丛丄七丞万与.text.Length > this.maxChars)
        {
                this.丗丏一丛丄七丞万与.text = this.丗丏一丛丄七丞万与.text.Substring(startIndex:  0, length:  this.maxChars);
        }
        
        }
        
        if((System.String.op_Inequality(a:  this.丟万世丞丑三丟三一, b:  val_1)) != false)
        {
                this.丗丏一丛丄七丞万与.text = this.丟万世丞丑三丟三一;
        }
        
        this.SendMessage(methodName:  "OnInputChanged", value:  this, options:  1);
        label_2:
        this.丗丏一丛丄七丞万与.active = true;
        val_18 = this.丗丏一丛丄七丞万与.done;
        if(this.丗丏一丛丄七丞万与 == null)
        {
            goto label_19;
        }
        
        if(val_18 == false)
        {
            goto label_20;
        }
        
        label_26:
        this.丗丏一丛丄七丞万与.active = true;
        if((System.String.IsNullOrEmpty(value:  this.丟万世丞丑三丟三一)) != false)
        {
                val_18 = System.String.Format(format:  "{0}{1}{2}", arg0:  this.丟万世丞丑三丟三一, arg1:  10, arg2:  this._Uil.text);
            this._Uil.text = val_18;
            this.丟万世丞丑三丟三一 = "";
        }
        
        if(this.mKeybordHold == true)
        {
                return;
        }
        
        goto label_25;
        label_19:
        if(val_18 == true)
        {
            goto label_26;
        }
        
        label_20:
        if(this.丗丏一丛丄七丞万与.wasCanceled == false)
        {
                return;
        }
        
        label_25:
        this.丗丏一丛丄七丞万与.active = false;
        this.丗丏一丛丄七丞万与 = 0;
    }
    private void OnClick()
    {
        this.丗丏一丛丄七丞万与 = UnityEngine.TouchScreenKeyboard.Open(text:  this.丟万世丞丑三丟三一, keyboardType:  0, autocorrection:  false);
    }
    public KeybordShow()
    {
        this.maxChars = 20;
        this.mKeybordHold = true;
        this.丟万世丞丑三丟三一 = "";
    }

}
