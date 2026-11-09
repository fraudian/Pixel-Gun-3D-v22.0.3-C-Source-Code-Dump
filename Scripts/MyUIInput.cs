using UnityEngine;
public class MyUIInput : UIInput
{
    // Fields
    public float heightKeyboard;
    public System.Action onKeyboardInter;
    public System.Action onKeyboardCancel;
    public System.Action onKeyboardVisible;
    public System.Action onKeyboardHide;
    private bool 且且下丕丕下世与丑;
    private float 丕业丅世丟上专东丘;
    private bool 三丐丕丘不万业丗不;
    
    // Methods
    private void Awake()
    {
        mem[1152921530956774092] = 0;
    }
    protected override void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(丞丈丌且东丆丅丗万 != false)
        {
                this.与不三丑业丟丏与丘();
            return;
        }
        
        if(W8 != 0)
        {
                return;
        }
        
        this.万丗丞丟下且不丛丕();
    }
    public void DeselectInput()
    {
        this.丛业丙丟丈丅丂与丌();
    }
    protected void 丛业丙丟丈丅丂与丌()
    {
        var val_4;
        UnityEngine.TouchScreenKeyboard val_5;
        var val_6;
        if(true != 0)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = UIInput.丗丏一丛丄七丞万与;
        if(val_5 != null)
        {
                val_5 = UIInput.丗丏一丛丄七丞万与;
            if(val_5 == null)
        {
                val_5 = 0;
        }
        
            val_5.active = false;
            UIInput.丗丏一丛丄七丞万与 = 0;
        }
        
        if(137101312 != 0)
        {
                string val_2 = this.value;
            mem[1152921530957114288] = val_2;
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                text = X21;
            color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        else
        {
                text = X21;
        }
        
            UnityEngine.Input.imeCompositionMode = 0;
            alignment = W21;
        }
        
        this.isSelected = false;
        val_6 = null;
        val_6 = null;
        UIInput.selection = 0;
        this.UpdateLabel();
    }
    private void Update()
    {
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_7;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  15)) != true)
        {
                if((UnityEngine.Input.GetKeyDown(name:  "enter")) == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.onKeyboardInter != null)
        {
                this.onKeyboardInter.Invoke();
        }
        
        label_4:
        if(((UnityEngine.Input.GetKeyDown(key:  14)) != false) && (this.onKeyboardVisible != null))
        {
                this.onKeyboardVisible.Invoke();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  13)) != false)
        {
                if(this.onKeyboardHide != null)
        {
                this.onKeyboardHide.Invoke();
        }
        
            this.丛业丙丟丈丅丂与丌();
        }
        
        label_7:
        this.Update();
    }
    public float GetKeyboardHeight()
    {
        return (float)this.heightKeyboard;
    }
    private void 丞丟丈东业丈丘业丑()
    {
        var val_23;
        UnityEngine.AndroidJavaObject val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_29;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_23 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        val_24 = new UnityEngine.AndroidJavaObject();
        val_24 = new UnityEngine.AndroidJavaObject(className:  "android.graphics.Rect", args:  System.Array.Empty<System.Object>());
        object[] val_8 = new object[1];
        val_8[0] = val_24;
        val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Get<UnityEngine.AndroidJavaObject>(fieldName:  "mUnityPlayer").Call<UnityEngine.AndroidJavaObject>(methodName:  "getView", args:  System.Array.Empty<System.Object>()).Call(methodName:  "getWindowVisibleDisplayFrame", args:  val_8);
        val_25 = UnityEngine.Screen.height;
        val_26 = 0;
        val_27 = 0;
        this.heightKeyboard = (float)val_25 - (new UnityEngine.AndroidJavaObject().Call<System.Int32>(methodName:  "height", args:  System.Array.Empty<System.Object>()));
        if(val_24 != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
        }
        
        if(val_26 == 1)
        {
            goto label_15;
        }
        
        val_29 = val_27;
        if(val_23 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_27 != 0)
        {
                val_27 = 0;
        }
        
        val_29 = 0;
        val_26 = 0;
        if(val_23 == null)
        {
            goto label_19;
        }
        
        label_16:
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_1.Dispose();
        label_19:
        if(val_26 != 1)
        {
                return;
        }
        
        if(val_29 == 0)
        {
                return;
        }
        
        val_23 = ???;
        val_24 = ???;
        val_25 = ???;
    }
    private void OnDestroy()
    {
        this.OnSelect(丞丈丌且东丆丅丗万:  false);
        this.丛业丙丟丈丅丂与丌();
    }
    private void OnEnable()
    {
        DeviceOrientationMonitor.丟丈东丑丒业丞业丌(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.DeviceOrientation>(object:  this, method:  System.Void MyUIInput::丆丝丞丐丌丌丟不三(UnityEngine.DeviceOrientation 丒丒丙世丑丑丒万丗)));
    }
    private void OnDisable()
    {
        DeviceOrientationMonitor.丕丆丁丆丟丈上万丝(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.DeviceOrientation>(object:  this, method:  System.Void MyUIInput::丆丝丞丐丌丌丟不三(UnityEngine.DeviceOrientation 丒丒丙世丑丑丒万丗)));
        this.OnSelect(丞丈丌且东丆丅丗万:  false);
        this.丛业丙丟丈丅丂与丌();
        this.丈丏丅丌七丕上业丟();
    }
    private void 丆丝丞丐丌丌丟不三(UnityEngine.DeviceOrientation 丒丒丙世丑丑丒万丗)
    {
        if(this.isSelected == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丐丛丁业丝丞丝丟东());
    }
    private System.Collections.IEnumerator 丐丛丁业丝丞丝丟东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MyUIInput.丑万丈世丟丄丆一业();
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 != false)
        {
                this.三丐丕丘不万业丗不 = this.isSelected;
            if(this.isSelected == false)
        {
                return;
        }
        
            this.isSelected = false;
            return;
        }
        
        if(this.三丐丕丘不万业丗不 != false)
        {
                this.isSelected = true;
        }
        
        this.三丐丕丘不万业丗不 = false;
    }
    public MyUIInput()
    {
        this.丕业丅世丟上专东丘 = 0.3f;
    }

}
