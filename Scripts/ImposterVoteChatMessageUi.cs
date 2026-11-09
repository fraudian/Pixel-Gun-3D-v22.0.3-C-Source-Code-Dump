using UnityEngine;
public class ImposterVoteChatMessageUi : PGBehaviour
{
    // Fields
    private UILabel _text;
    private UISprite _smileSprite;
    private UILabel _senderName;
    private UITextureMasked _senderAvatar;
    private UnityEngine.GameObject _ghostBackground;
    private UnityEngine.GameObject _aliveBackground;
    private UIWidget _aliveBackgroundWidget;
    private UIWidget _ghostBackgroundWidget;
    
    // Methods
    internal UIWidget 丕不三丝专丐丁专与()
    {
        return (UIWidget)(this._aliveBackgroundWidget.gameObject.activeInHierarchy != true) ? (this._aliveBackgroundWidget) : this._ghostBackgroundWidget;
    }
    internal void 一丞一丝丘丕且丒丆(丆与七世东不东丂丙 丄丅七一丞丟丅丘世)
    {
        int val_21;
        var val_22;
        var val_23;
        UILabel val_24;
        int val_25;
        var val_26;
        var val_27;
        UILabel val_28;
        UnityEngine.Texture val_33;
        if(丄丅七一丞丟丅丘世 == null)
        {
                return;
        }
        
        val_21 = 1152921505171275776;
        val_22 = null;
        val_22 = null;
        if((丄丅七一丞丟丅丘世.七东一丅一丕世三丂().StartsWith(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._smileSprite, 丏业丟一东丂东丘丛:  true);
            val_23 = null;
            val_23 = null;
            val_21 = System.String.alignConst;
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._smileSprite, 万丑丞一丝丌丐丒丘:  丄丅七一丞丟丅丘世.七东一丅一丕世三丂().Replace(oldValue:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄, newValue:  val_21));
            val_24 = this._text;
            val_25 = System.String.alignConst;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._smileSprite, 丏业丟一东丂东丘丛:  false);
            val_25 = 丄丅七一丞丟丅丘世.七东一丅一丕世三丂();
            val_24 = this._text;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_24, 丕丗丘丑丛与丑业丒:  val_25);
        if(丄丅七一丞丟丅丘世.与丁丞丗丆下下专丝().丟东丘丏上世且上丕() == false)
        {
            goto label_20;
        }
        
        val_26 = null;
        val_26 = null;
        if(丟东丘丏上世且上丕() == false)
        {
            goto label_20;
        }
        
        val_27 = this;
        val_28 = this._senderName;
        UnityEngine.Color val_9 = UnityEngine.Color.red;
        goto label_24;
        label_20:
        NetworkStartTable val_10 = 丄丅七一丞丟丅丘世.与丁丞丗丆下下专丝();
        val_27 = this;
        val_28 = this._senderName;
        if(val_10.丌且下丕下下丌万丞 != false)
        {
                UnityEngine.Color val_11 = UnityEngine.Color.yellow;
        }
        else
        {
                UnityEngine.Color val_12 = UnityEngine.Color.white;
        }
        
        label_24:
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_28, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
        NetworkStartTable val_13 = 丄丅七一丞丟丅丘世.与丁丞丗丆下下专丝();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_28, 丕丗丘丑丛与丑业丒:  val_13.丂丈丐不丏万三七丐);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._ghostBackground, 丏业丟一东丂东丘丛:  (~丄丅七一丞丟丅丘世.下丗丘丙丗三丞下丆()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._aliveBackground, 丏业丟一东丂东丘丛:  丄丅七一丞丟丅丘世.下丗丘丙丗三丞下丆());
        PGCompany.世东三上七丂丌下丑 val_18 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        NetworkStartTable val_19 = 丄丅七一丞丟丅丘世.与丁丞丗丆下下专丝();
        if(val_19.三丆丛丁丞丘丂三丞 == null)
        {
            goto label_31;
        }
        
        label_36:
        PGCompany.丌丙丈丕丛丆丝丗丟 val_20 = val_18.一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  val_19.三丆丛丁丞丘丂三丞);
        if(val_20 == null)
        {
            goto label_33;
        }
        
        val_33 = val_20;
        goto label_34;
        label_31:
        if(val_18 != null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_33:
        val_33 = 0;
        label_34:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._senderAvatar, 与万丆丛丒万丝丙丑:  val_33);
    }
    public ImposterVoteChatMessageUi()
    {
    
    }

}
