using UnityEngine;
public class MapEventRewardItem : MonoBehaviour
{
    // Fields
    public UILabel description;
    public UnityEngine.GameObject rewardIconPanel;
    public UILabel rewardValue;
    public UnityEngine.GameObject[] rewardIcons;
    public UITexture eventRewardIcon;
    private UnityEngine.GameObject 丅丈三上三丄丝丆专;
    
    // Methods
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 丗七丟丈三不丕一三)
    {
        UILabel val_46;
        object val_47;
        float val_48;
        UILabel val_49;
        val_46 = this;
        if(丗七丟丈三不丕一三 != null)
        {
                val_47 = 丗七丟丈三不丕一三.东且丏丆万与东丙万();
        }
        else
        {
                val_47 = 0.东且丏丆万与东丙万();
        }
        
        if(((((丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 1) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 2)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 3)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 4)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 5))
        {
                if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 6)
        {
                if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 18)
        {
            goto label_15;
        }
        
        }
        
        }
        
        if(丗七丟丈三不丕一三 != null)
        {
            goto label_72;
        }
        
        label_73:
        label_72:
        if((((((丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 9) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 10)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 11)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 12)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 13)) && (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 15))
        {
                if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 16)
        {
                if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 17)
        {
            goto label_31;
        }
        
        }
        
        }
        
        var val_46 = 1;
        label_75:
        val_46 = val_46 | 1;
        UnityEngine.GameObject val_18 = this.rewardValue.gameObject;
        if(val_18 == null)
        {
            goto label_33;
        }
        
        if(val_46 == 0)
        {
            goto label_34;
        }
        
        label_37:
        val_18.SetActive(value:  true);
        if(丗七丟丈三不丕一三 == null)
        {
            goto label_35;
        }
        
        val_48 = 丗七丟丈三不丕一三.东丙万丌丅丙丝丕业();
        goto label_36;
        label_33:
        if(val_46 != 0)
        {
            goto label_37;
        }
        
        label_34:
        val_18.SetActive(value:  false);
        if(丗七丟丈三不丕一三 != null)
        {
            goto label_47;
        }
        
        goto label_39;
        label_35:
        val_48 = 0.东丙万丌丅丙丝丕业();
        label_36:
        string val_22 = (丗七丟丈三不丕一三.东丏丕东万丘丞丑与() != true) ? "Key_6428" : "Key_6429";
        if(1 != 0)
        {
                val_49 = this.rewardValue;
            val_47 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_22), arg0:  "x" + val_48.ToString(), arg1:  val_47);
            string val_28 = "x" + val_48.ToString();
        }
        else
        {
                val_49 = this.rewardValue;
            val_47 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_22), arg0:  val_48, arg1:  val_47);
        }
        
        val_49.text = val_48.ToString();
        if(丗七丟丈三不丕一三 != null)
        {
            goto label_47;
        }
        
        label_39:
        label_47:
        if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 12)
        {
                if(丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() != 3)
        {
            goto label_50;
        }
        
        }
        
        UnityEngine.Texture2D val_37 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().丐与丄世三丐不丁丛());
        label_50:
        if(this.丅丈三上三丄丝丆专 != 0)
        {
                this.丅丈三上三丄丝丆专.SetActive(value:  false);
            this.丅丈三上三丄丝丆专 = 0;
        }
        
        UnityEngine.GameObject val_47 = this.rewardIcons[(long)丗七丟丈三不丕一三.不业丙丒丂丞下丆丙()];
        if(val_47 != 0)
        {
                val_47.SetActive(value:  true);
            this.丅丈三上三丄丝丆专 = val_47;
        }
        
        if(this.description == 0)
        {
                return;
        }
        
        val_46 = this.description;
        val_46.text = val_47;
        return;
        label_15:
        var val_43 = (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() == 20) ? 1 : 0;
        if(丗七丟丈三不丕一三 != null)
        {
            goto label_72;
        }
        
        goto label_73;
        label_31:
        var val_45 = (丗七丟丈三不丕一三.不业丙丒丂丞下丆丙() == 19) ? 1 : 0;
        goto label_75;
    }
    public MapEventRewardItem()
    {
    
    }

}
