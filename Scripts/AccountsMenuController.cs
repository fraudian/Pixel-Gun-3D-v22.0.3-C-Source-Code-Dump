using UnityEngine;
public class AccountsMenuController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _iosAccountItem;
    private UnityEngine.GameObject _androidAccountItem;
    private UnityEngine.GameObject _amazonAccountItem;
    private UnityEngine.GameObject _huaweiAccountItem;
    private bool 丙丐丄丛东七丑万丙;
    
    // Methods
    private void OnEnable()
    {
        this.三丝七丆东三丝上丄();
    }
    private void 三丝七丆东三丝上丄()
    {
        var val_5;
        UnityEngine.GameObject val_6;
        if(this.丙丐丄丛东七丑万丙 == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._iosAccountItem, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._androidAccountItem, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._amazonAccountItem, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._huaweiAccountItem, 丏业丟一东丂东丘丛:  false);
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
            goto label_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_7;
        }
        
        val_5 = null;
        val_6 = this._amazonAccountItem;
        goto label_17;
        label_4:
        val_5 = null;
        val_6 = this._iosAccountItem;
        goto label_17;
        label_7:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
        {
            goto label_15;
        }
        
        val_6 = this._androidAccountItem;
        goto label_17;
        label_15:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 3)
        {
            goto label_20;
        }
        
        val_6 = this._huaweiAccountItem;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        label_20:
        this.丙丐丄丛东七丑万丙 = true;
    }
    public AccountsMenuController()
    {
    
    }

}
