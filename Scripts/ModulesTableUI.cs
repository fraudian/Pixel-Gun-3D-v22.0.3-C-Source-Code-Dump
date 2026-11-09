using UnityEngine;
public class ModulesTableUI : MonoBehaviour
{
    // Fields
    public UITable monsterTypeTable;
    public UITexture[] monsterTypes;
    public UILabel[] monsterTypesLevels;
    public UnityEngine.Texture[] mobModuleTypeIcons;
    private bool 丆丛丅丞七七丞丘丞;
    
    // Methods
    public void UpdateModules(丐七不丝丆丐丂丐下 丞丒丌丄丄丏下下专, int 下丞七丒业丂丈丘下)
    {
        var val_4;
        var val_12;
        var val_13;
        val_12 = null;
        val_12 = null;
        万丗且专万丟丌丂丐 val_1 = DungeonWindowUI.dungeonsInfo.Item[下丞七丒业丂丈丘下];
        val_13 = 0;
        goto label_4;
        label_36:
        if(val_13 >= (val_4 + 24))
        {
            goto label_6;
        }
        
        var val_6 = val_4 + 0;
        if(((val_4 + 0) + 32) <= 丞丒丌丄丄丏下下专)
        {
            goto label_9;
        }
        
        label_6:
        this.monsterTypes[0].gameObject.SetActive(value:  false);
        goto label_14;
        label_9:
        this.monsterTypes[0].gameObject.SetActive(value:  true);
        UITexture val_14 = this.monsterTypes[0];
        var val_9 = val_4 + 0;
        UnityEngine.Texture val_15 = this.mobModuleTypeIcons[(val_4 + 0) + 36];
        this.monsterTypesLevels[0].gameObject.SetActive(value:  true);
        this.monsterTypesLevels[0].text = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  567540304);
        label_14:
        val_13 = 1;
        label_4:
        if(val_13 < this.monsterTypes.Length)
        {
            goto label_36;
        }
        
        this.丆丛丅丞七七丞丘丞 = true;
    }
    internal void 丙不丑丆丂三三丞下(bool 丐丐丄丞丏丗专丏与)
    {
        int val_11 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_11.丞丗丑丈一丅丗丌丟() == null)
        {
                return;
        }
        
        val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛();
        if(val_11 == 1)
        {
                return;
        }
        
        val_11 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丐丆三丞下业丘丞一().Item[val_11];
        var val_9 = ((丐丐丄丞丏丗专丏与 & true) != 0) ? this.monsterTypes.Length : (0 + 1);
        if(val_9 >= 1)
        {
                var val_16 = 0;
            var val_17 = 32;
            do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.monsterTypes[0], 丏业丟一东丂东丘丛:  true);
            if(丐丐丄丞丏丗专丏与 != false)
        {
            
        }
        else
        {
                var val_10 = val_16 + 1;
        }
        
            UITexture val_13 = this.monsterTypes[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.monsterTypesLevels[0], 丏业丟一东丂东丘丛:  true);
            this.monsterTypesLevels[0].text = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  val_11);
            val_16 = val_16 + 1;
            val_17 = val_17 + 8;
        }
        while(val_9 != val_16);
        
        }
        
        this.丆丛丅丞七七丞丘丞 = true;
    }
    private void LateUpdate()
    {
        if(this.丆丛丅丞七七丞丘丞 == false)
        {
                return;
        }
        
        this.丆丛丅丞七七丞丘丞 = false;
        if(this.monsterTypeTable == null)
        {
            
        }
    
    }
    public ModulesTableUI()
    {
    
    }

}
