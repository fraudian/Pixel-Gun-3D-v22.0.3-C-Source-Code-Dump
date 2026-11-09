using UnityEngine;
internal class ServerMessageBox : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UILabel> _messageLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> _technicalWork;
    private System.Collections.Generic.List<UnityEngine.GameObject> _technicalWorkNoButton;
    private System.Collections.Generic.List<UnityEngine.GameObject> _notAuthorized;
    private System.Collections.Generic.List<UnityEngine.GameObject> _notConnected;
    private System.Collections.Generic.Dictionary<UISprite, string> 丌丁丐东七丅丙丌下;
    public float TimeToHide;
    private Rilisoft.WebSocket.下丈丈丆丙万丝丁业 丌下丏丐丕丏不丗一;
    private float 下丐丟上丛丄丝丞丌;
    private static System.Action 专七专一丙丄丞丛丌;
    
    // Methods
    internal static void 上东丙丌丒丏丒三与(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ServerMessageBox.专七专一丙丄丞丛丌, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 且丝三丙东与与与丄(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ServerMessageBox.专七专一丙丄丞丛丌, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal void 丅专下万丕丑丆丅丝(Rilisoft.WebSocket.下丈丈丆丙万丝丁业 丁丅丈丌丟世丗丗丟)
    {
        var val_6;
        var val_8;
        var val_10;
        var val_12;
        this.丌下丏丐丕丏不丗一 = 丁丅丈丌丟世丗丗丟;
        this.下丐丟上丛丄丝丞丌 = this.TimeToHide;
        val_6 = null;
        val_6 = null;
        if((ServerMessageBox.<>c.<>9__12_0) == null)
        {
            goto label_3;
        }
        
        label_21:
        this._technicalWork.ForEach(action:  ServerMessageBox.<>c.<>9__12_0);
        val_8 = null;
        val_8 = null;
        if((ServerMessageBox.<>c.<>9__12_1) == null)
        {
            goto label_7;
        }
        
        label_25:
        this._notAuthorized.ForEach(action:  ServerMessageBox.<>c.<>9__12_1);
        val_10 = null;
        val_10 = null;
        if((ServerMessageBox.<>c.<>9__12_2) == null)
        {
            goto label_11;
        }
        
        label_29:
        this._notConnected.ForEach(action:  ServerMessageBox.<>c.<>9__12_2);
        val_12 = null;
        val_12 = null;
        if((ServerMessageBox.<>c.<>9__12_3) == null)
        {
            goto label_15;
        }
        
        label_33:
        this._technicalWorkNoButton.ForEach(action:  ServerMessageBox.<>c.<>9__12_3);
        if((丁丅丈丌丟世丗丗丟 - 1) > 4)
        {
            goto label_17;
        }
        
        var val_6 = 106027204 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2;
        val_6 = val_6 + 106027204;
        goto (106027204 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2 + 106027204);
        label_3:
        ServerMessageBox.<>c.<>9__12_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::丑丄世下丗上且万丈(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._technicalWork != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_7:
        ServerMessageBox.<>c.<>9__12_1 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::三丌丞七丄业丞丐一(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._notAuthorized != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_11:
        ServerMessageBox.<>c.<>9__12_2 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::上与丐三丑丆下丙丏(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._notConnected != null)
        {
            goto label_29;
        }
        
        goto label_29;
        label_15:
        ServerMessageBox.<>c.<>9__12_3 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::丐丗不丕丆丛不与丕(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._technicalWorkNoButton != null)
        {
            goto label_33;
        }
        
        goto label_33;
        label_17:
        this.下丐丟上丛丄丝丞丌 = 0f;
    }
    private void 丆丘丄不世丆丙丐业()
    {
        var val_3 = null;
        if((ServerMessageBox.<>c.<>9__13_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        this._notConnected.ForEach(action:  ServerMessageBox.<>c.<>9__13_0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0075"));
        return;
        label_3:
        ServerMessageBox.<>c.<>9__13_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::七丗东世一业丑业丅(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._notConnected != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void 丏三丌丘丝世丗万丄()
    {
        var val_3 = null;
        if((ServerMessageBox.<>c.<>9__14_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        this._notAuthorized.ForEach(action:  ServerMessageBox.<>c.<>9__14_0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6347"));
        return;
        label_3:
        ServerMessageBox.<>c.<>9__14_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::世丘丟丙丕东世不丅(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._notAuthorized != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void 世业丏丅丏丄丟丗且()
    {
        var val_3 = null;
        if((ServerMessageBox.<>c.<>9__15_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        this._technicalWork.ForEach(action:  ServerMessageBox.<>c.<>9__15_0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7153"));
        return;
        label_3:
        ServerMessageBox.<>c.<>9__15_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::且与丝丟丗丝七丄丁(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._technicalWork != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void 丁丐丟下丑丄业与丒()
    {
        var val_4 = null;
        if((ServerMessageBox.<>c.<>9__16_0) == null)
        {
            goto label_3;
        }
        
        label_15:
        this._technicalWork.ForEach(action:  ServerMessageBox.<>c.<>9__16_0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7153"));
        this.下丐丟上丛丄丝丞丌 = -1.175494E-38f;
        if(OfflineModController.丂丁丌丘丗丅专专丛() != false)
        {
                this.丙丅丙丟三七丞丈丆(上丄丂丅丝丛丟丑丟:  this._technicalWork);
            return;
        }
        
        this.丂业丄丝丑丑丙三一(上丄丂丅丝丛丟丑丟:  this._technicalWork);
        return;
        label_3:
        ServerMessageBox.<>c.<>9__16_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::丘七丞下业丐一专丞(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._technicalWork != null)
        {
            goto label_15;
        }
        
        goto label_15;
    }
    private void 世丂东丁专不上丘三()
    {
        var val_3 = null;
        if((ServerMessageBox.<>c.<>9__17_0) == null)
        {
            goto label_3;
        }
        
        label_12:
        this._technicalWorkNoButton.ForEach(action:  ServerMessageBox.<>c.<>9__17_0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6348"));
        return;
        label_3:
        ServerMessageBox.<>c.<>9__17_0 = new System.Action<UnityEngine.GameObject>(object:  ServerMessageBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ServerMessageBox.<>c::丟丙丂丗丏丐丁丄世(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this._technicalWorkNoButton != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.下丐丟上丛丄丝丞丌 - val_1;
        this.下丐丟上丛丄丝丞丌 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.U_Hide();
    }
    public void U_Hide()
    {
        if(this.丌下丏丐丕丏不丗一 == 4)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().HideServerMessageBox();
    }
    public void U_GoOfflineClicked()
    {
        if(ServerMessageBox.专七专一丙丄丞丛丌 == null)
        {
                return;
        }
        
        ServerMessageBox.专七专一丙丄丞丛丌.Invoke();
        InfoWindowController.丑七不且上丗丁一世().HideServerMessageBox();
    }
    private void 丙丅丙丟三七丞丈丆(System.Collections.Generic.List<UnityEngine.GameObject> 上丄丂丅丝丛丟丑丟)
    {
        var val_3;
        this.一上丙丈且丂丏丕一(上丄丂丅丝丛丟丑丟:  上丄丂丅丝丛丟丑丟);
        List.Enumerator<T> val_1 = 上丄丂丅丝丛丟丑丟.GetEnumerator();
        label_17:
        if(((-901720864) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        UIButton val_5 = val_4.GetComponent<UIButton>();
        if(val_5 == 0)
        {
            goto label_17;
        }
        
        UISprite val_7 = val_4.GetComponent<UISprite>();
        if(val_7 != 0)
        {
                val_7.spriteName = this.丌丁丐东七丅丙丌下.Item[val_7];
        }
        
        if(val_5 == 0)
        {
            goto label_17;
        }
        
        val_5.enabled = true;
        goto label_17;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丂业丄丝丑丑丙三一(System.Collections.Generic.List<UnityEngine.GameObject> 上丄丂丅丝丛丟丑丟)
    {
        var val_3;
        this.一上丙丈且丂丏丕一(上丄丂丅丝丛丟丑丟:  上丄丂丅丝丛丟丑丟 = 上丄丂丅丝丛丟丑丟);
        List.Enumerator<T> val_1 = 上丄丂丅丝丛丟丑丟.GetEnumerator();
        label_16:
        if(((-901567792) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        UIButton val_5 = val_4.GetComponent<UIButton>();
        if(val_5 == 0)
        {
            goto label_16;
        }
        
        UISprite val_7 = val_4.GetComponent<UISprite>();
        if(val_7 != 0)
        {
                val_7.spriteName = "grey_btn";
        }
        
        if(val_5 == 0)
        {
            goto label_16;
        }
        
        val_5.enabled = false;
        goto label_16;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 一上丙丈且丂丏丕一(System.Collections.Generic.List<UnityEngine.GameObject> 上丄丂丅丝丛丟丑丟)
    {
        var val_3;
        if(this.丌丁丐东七丅丙丌下 == null)
        {
            goto label_1;
        }
        
        label_18:
        List.Enumerator<T> val_1 = 上丄丂丅丝丛丟丑丟.GetEnumerator();
        label_16:
        if(((-901399488) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((val_4.GetComponent<UIButton>()) == 0)
        {
            goto label_16;
        }
        
        UISprite val_7 = val_4.GetComponent<UISprite>();
        if((val_7 == 0) || ((this.丌丁丐东七丅丙丌下.ContainsKey(key:  val_7)) == true))
        {
            goto label_16;
        }
        
        this.丌丁丐东七丅丙丌下.set_Item(key:  val_7, value:  val_7.spriteName);
        goto label_16;
        label_1:
        this.丌丁丐东七丅丙丌下 = new System.Collections.Generic.Dictionary<UISprite, System.String>();
        if(上丄丂丅丝丛丟丑丟 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ServerMessageBox()
    {
    
    }

}
