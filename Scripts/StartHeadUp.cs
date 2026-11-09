using UnityEngine;
public class StartHeadUp : MonoBehaviour
{
    // Methods
    private void Start()
    {
        int val_18;
        string val_19;
        var val_20;
        var val_21;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_3;
        }
        
        UILabel val_2 = this.GetComponent<UILabel>();
        val_18 = System.String.alignConst;
        val_19 = val_18;
        goto label_5;
        label_3:
        val_20 = null;
        val_20 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_22;
        }
        
        if((与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_14;
        }
        
        val_21 = null;
        val_21 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七] & 1) == 0)
        {
            goto label_22;
        }
        
        label_14:
        if(GameConnect.丑丌丛丈丅丅与不业() != 2)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 4)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
            goto label_31;
        }
        
        }
        
        }
        
        val_18 = this.GetComponent<UILabel>();
        string val_11 = 丟丏下丂七三下丗丕.丕丄东丅丌上丑丞世();
        goto label_46;
        label_22:
        val_18 = this.GetComponent<UILabel>();
        label_46:
        val_19 = 丟丏下丂七三下丗丕.一七东丒业丌上丑上();
        label_5:
        val_18.text = val_19;
        return;
        label_31:
        UILabel val_15 = this.GetComponent<UILabel>();
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_40;
        }
        
        string val_16 = 丟丏下丂七三下丗丕.三不三丛丆丐下丅丆();
        goto label_46;
        label_40:
        string val_17 = 丟丏下丂七三下丗丕.丕丌丐丏丆万上丆与();
        goto label_46;
    }
    public StartHeadUp()
    {
    
    }

}
