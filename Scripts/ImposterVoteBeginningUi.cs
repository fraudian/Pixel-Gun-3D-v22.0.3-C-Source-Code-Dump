using UnityEngine;
public class ImposterVoteBeginningUi : PGBehaviour
{
    // Fields
    private static readonly int 世丞专丐丅丆下与万;
    private UILabel[] _topTextLabel;
    private UITextureMasked[] _leftTexture;
    private UITextureMasked _rightTexture;
    private UnityEngine.GameObject _bodyFoundContainer;
    private UnityEngine.GameObject _buttonPressedContainer;
    private UnityEngine.Animator _animator;
    private ImposterVoteController 丑丒且丆丌一丌下七;
    
    // Methods
    internal void 丂丁丈丟丟丘与丑万(ImposterVoteController 东丌与与且丝三丟业)
    {
        this.丑丒且丆丌一丌下七 = 东丌与与且丝三丟业;
        this.丗丂万丙丌一丁万丏();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bodyFoundContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonPressedContainer, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.下且东丛专丒丅七丑());
    }
    private System.Collections.IEnumerator 下且东丛专丒丅七丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ImposterVoteBeginningUi.下下三专丞丄丕下不();
    }
    private void 丗丂万丙丌一丁万丏()
    {
        null = null;
        this._animator.ResetTrigger(id:  ImposterVoteBeginningUi.世丞专丐丅丆下与万);
    }
    public void OnStartIdleAnimationEvent()
    {
        this.下且丑丆丈丘丅丗丈();
    }
    public void OnStartOutroAnimationEvent()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bodyFoundContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonPressedContainer, 丏业丟一东丂东丘丛:  false);
    }
    private void 下且丑丆丈丘丅丗丈()
    {
        var val_24;
        var val_25;
        UnityEngine.Object val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        string val_32;
        string val_33;
        UnityEngine.Texture val_34;
        UITextureMasked val_35;
        string val_36;
        var val_37;
        UnityEngine.Texture val_38;
        val_24 = 43609;
        if(this.丑丒且丆丌一丌下七 == null)
        {
                val_24 = 0;
        }
        
        if(this.丑丒且丆丌一丌下七.imposterMode == null)
        {
                val_24 = 0;
        }
        
        int val_1 = val_24.丕丆丄丗与丟丞丅专();
        val_25 = 0;
        val_26 = 0;
        goto label_3;
        label_29:
        val_27 = null;
        val_27 = null;
        NetworkStartTable val_2 = Item[0];
        if(val_2.丄丈丑丐丆丞丘与丗.owner != null)
        {
                val_28 = null;
            val_28 = null;
            NetworkStartTable val_4 = Item[0];
            val_29 = val_4.丄丈丑丐丆丞丘与丗.owner;
            if(this.丑丒且丆丌一丌下七 == null)
        {
                val_29 = 0;
        }
        
            if(this.丑丒且丆丌一丌下七.imposterMode == null)
        {
                val_29 = 0;
        }
        
            if(val_29.业丐丐三丕一丗丛丁() == val_29.东丂丙七丌世业上丅())
        {
                val_30 = null;
            val_30 = null;
            val_26 = Item[0];
        }
        
        }
        
        val_25 = 1;
        label_3:
        val_31 = null;
        val_31 = null;
        if(val_25 < Count)
        {
            goto label_29;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bodyFoundContainer, 丏业丟一东丂东丘丛:  (val_1 == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonPressedContainer, 丏业丟一东丂东丘丛:  (val_1 != 1) ? 1 : 0);
        if(val_1 != 1)
        {
            goto label_32;
        }
        
        if(val_26 == 0)
        {
            goto label_37;
        }
        
        val_32 = val_8.丂丈丐不丏万三七丐;
        goto label_39;
        label_32:
        if(val_26 == 0)
        {
            goto label_44;
        }
        
        val_33 = val_8.丂丈丐不丏万三七丐;
        goto label_46;
        label_37:
        label_39:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._topTextLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10074"), arg0:  System.String.__il2cppRuntimeField_static_fields));
        val_34 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  0.丒丐丕专专世丟丘丛());
        val_35 = this._rightTexture;
        goto label_53;
        label_44:
        label_46:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._topTextLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10073"), arg0:  System.String.__il2cppRuntimeField_static_fields));
        val_35 = this._rightTexture;
        val_34 = 0;
        label_53:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_35, 与万丆丛丒万丝丙丑:  val_34);
        if(val_26 == 0)
        {
            goto label_58;
        }
        
        val_36 = val_8.三丆丛丁丞丘丂三丞;
        if(val_36 != null)
        {
            goto label_60;
        }
        
        label_58:
        val_36 = System.String.alignConst;
        label_60:
        PGCompany.丌丙丈丕丛丆丝丗丟 val_23 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  val_36);
        val_37 = 0;
        goto label_62;
        label_70:
        if(val_23 != null)
        {
                val_38 = val_23;
        }
        else
        {
                val_38 = 0;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._leftTexture[0], 与万丆丛丒万丝丙丑:  val_38);
        val_37 = 1;
        label_62:
        if(val_37 < this._leftTexture.Length)
        {
            goto label_70;
        }
    
    }
    public void OnEndOutroAnimationEvent()
    {
        if(this.丑丒且丆丌一丌下七 != null)
        {
                this.丑丒且丆丌一丌下七.下丆丐三专丂丕丝三();
            return;
        }
        
        0.下丆丐三专丂丕丝三();
    }
    public ImposterVoteBeginningUi()
    {
    
    }
    private static ImposterVoteBeginningUi()
    {
        ImposterVoteBeginningUi.世丞专丐丅丆下与万 = UnityEngine.Animator.StringToHash(name:  "Outro");
    }
    private bool 丌一丐七丑下业丌丟()
    {
        if(this.丑丒且丆丌一丌下七 != null)
        {
                return this.丑丒且丆丌一丌下七.丕一丁七丈丟丆丂上();
        }
        
        return this.丑丒且丆丌一丌下七.丕一丁七丈丟丆丂上();
    }

}
