using UnityEngine;
public class CharacterManagementButtonConstraints : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _enabledButton;
    private UnityEngine.GameObject _disabledButton;
    private UnityEngine.GameObject _buttonGlow;
    
    // Methods
    private void OnEnable()
    {
        this.丆丐丅下丟上上七丄();
    }
    private void Update()
    {
        this.丆丐丅下丟上上七丄();
    }
    private void 丆丐丅下丟上上七丄()
    {
        System.Nullable<System.Boolean> val_1 = Progress.七上上丟丗丏一不与.丛丑丅上且业世不丆();
        if(((-433115252) & 1) != 0)
        {
                System.Nullable<System.Boolean> val_2 = Progress.七上上丟丗丏一不与.丛丑丅上且业世不丆();
            if(((-433115252) & 1) != 0)
        {
                label_18:
            this.丌丄不七三丘丏丆与();
            return;
        }
        
        }
        
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() != null)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_13;
        }
        
        }
        
        label_29:
        this.丅丁丝丁丈丛丐且丑(丝三丄专丗丞丄丄丌:  false);
        return;
        label_13:
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
            goto label_18;
        }
        
        }
        
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一().丄且东且丕丛与丆丒() < 丑丝丞丒丅丄万丒三.万上丘丙丗丛丛丅丈())
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() < 丑丝丞丒丅丄万丒三.万上丘丙丗丛丛丅丈())
        {
            goto label_29;
        }
        
        }
        
        this.丅丁丝丁丈丛丐且丑(丝三丄专丗丞丄丄丌:  true);
        this.丒丄丌丒上东丘丘东(丝三丄专丗丞丄丄丌:  Rilisoft.七不丑丑下与丛丝丝.不丆丕丁万专东东且());
    }
    private void 丅丁丝丁丈丛丐且丑(bool 丝三丄专丗丞丄丄丌)
    {
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enabledButton, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._disabledButton, 丏业丟一东丂东丘丛:  (~丝三丄专丗丞丄丄丌) & 1);
    }
    private void 丒丄丌丒上东丘丘东(bool 丝三丄专丗丞丄丄丌)
    {
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonGlow, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
    }
    private void 丌丄不七三丘丏丆与()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enabledButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._disabledButton, 丏业丟一东丂东丘丛:  false);
    }
    public CharacterManagementButtonConstraints()
    {
    
    }

}
