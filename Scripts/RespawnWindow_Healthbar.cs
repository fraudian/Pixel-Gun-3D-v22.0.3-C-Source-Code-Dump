using UnityEngine;
public class RespawnWindow_Healthbar : MonoBehaviour
{
    // Fields
    public UILabel armorCountLabel;
    public UILabel healthCountLabel;
    public UISprite armorCountSprite;
    public UISprite healthCountSprite;
    public UnityEngine.GameObject armorObj;
    public UnityEngine.GameObject healthbarObj;
    public UnityEngine.GameObject healthIcon;
    public UITable healthTable;
    
    // Methods
    internal void 丞不七丒业丂丅丛三(Player_move_c 专丞上七七且丝七丗)
    {
        int val_3;
        int val_5;
        float val_6;
        if(专丞上七七且丝七丗 != null)
        {
                val_3 = 专丞上七七且丝七丗.丄丞丘不下七一丘丘;
            val_5 = 专丞上七七且丝七丗.丅三业丆丄丝丝丕东;
            val_6 = 专丞上七七且丝七丗.丘七业丒丐世丂丅丒();
        }
        else
        {
                val_3 = 0;
            val_6 = 0.丘七业丒丐世丂丅丒();
            val_5 = 0;
        }
        
        this.上东与丛丞下丈专丈(丆丄万丙丛万七东丕:  0f, 丈丝业丛丙东丄丝七:  val_6, 万丝丕丐世七专丛丆:  0f, 丁丛丒丌丟一丕七丈:  专丞上七七且丝七丗.三丕丘下业丑丞下丘);
    }
    internal void 丄丗世万世丛丒七丝(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        int val_1;
        int val_2;
        int val_3;
        if(丝丞丛七且一丅丐丄 != null)
        {
                val_1 = 丝丞丛七且一丅丐丄.丌三一专与一丕丗丗;
            val_2 = 丝丞丛七且一丅丐丄.与三丐丆万不丝万丒;
            val_3 = 丝丞丛七且一丅丐丄.丐专丕丕丒丏丁丁丑;
        }
        else
        {
                val_2 = 496;
            val_1 = 130718704;
            val_3 = 0;
        }
        
        this.上东与丛丞下丈专丈(丆丄万丙丛万七东丕:  496f, 丈丝业丛丙东丄丝七:  1.307187E+08f, 万丝丕丐世七专丛丆:  0f, 丁丛丒丌丟一丕七丈:  (float)丝丞丛七且一丅丐丄.丅丞丕与丁丂三丌丙);
    }
    internal void 上东与丛丞下丈专丈(float 丆丄万丙丛万七东丕, float 丈丝业丛丙东丄丝七, float 万丝丕丐世七专丛丆, float 丁丛丒丌丟一丕七丈)
    {
        float val_21;
        var val_23;
        var val_26;
        val_21 = 万丝丕丐世七专丛丆;
        var val_3 = ((val_21 > 0f) ? 1 : 0) | ((丁丛丒丌丟一丕七丈 > 0f) ? 1 : 0);
        if(this.armorObj == null)
        {
            goto label_1;
        }
        
        if(val_3 == 0)
        {
            goto label_2;
        }
        
        label_10:
        this.armorObj.SetActive(value:  true);
        if(val_21 <= 0f)
        {
            goto label_3;
        }
        
        float val_4 = UnityEngine.Mathf.Min(a:  val_21, b:  丁丛丒丌丟一丕七丈);
        val_23 = null;
        val_23 = null;
        if(BalanceController.世七丌不丘业丑丟一 == false)
        {
            goto label_8;
        }
        
        string val_5 = System.String.Format(format:  "{0}/{1}", arg0:  val_4, arg1:  val_21);
        goto label_9;
        label_1:
        if(val_3 != 0)
        {
            goto label_10;
        }
        
        label_2:
        this.armorObj.SetActive(value:  false);
        goto label_11;
        label_3:
        this.armorCountLabel.text = System.String.Format(format:  "{0}", arg0:  丁丛丒丌丟一丕七丈, arg1:  val_21);
        if(this.armorCountSprite != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_8:
        val_4 = val_4 / val_21;
        float val_7 = UnityEngine.Mathf.Clamp01(value:  val_4);
        val_7 = val_7 * 100f;
        label_9:
        this.armorCountLabel.text = System.String.Format(format:  "{0} %", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_7));
        val_21 = UnityEngine.Mathf.Clamp(value:  val_4 / val_21, min:  0f, max:  1f);
        label_14:
        this.armorCountSprite.fillAmount = val_21;
        label_11:
        if(this.healthTable != 0)
        {
                this.healthTable.repositionNow = true;
        }
        
        if(this.healthIcon != 0)
        {
                this.healthIcon.SetActive(value:  true);
        }
        
        val_26 = null;
        val_26 = null;
        if(BalanceController.世七丌不丘业丑丟一 != false)
        {
                string val_14 = System.String.Format(format:  "{0}/{1}", arg0:  丈丝业丛丙东丄丝七, arg1:  丆丄万丙丛万七东丕);
        }
        else
        {
                float val_16 = UnityEngine.Mathf.Clamp01(value:  丈丝业丛丙东丄丝七 / 丆丄万丙丛万七东丕);
            val_16 = val_16 * 100f;
        }
        
        this.healthCountLabel.text = System.String.Format(format:  "{0} %", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_16));
        this.healthCountSprite.fillAmount = UnityEngine.Mathf.Clamp(value:  丈丝业丛丙东丄丝七 / 丆丄万丙丛万七东丕, min:  0f, max:  1f);
    }
    public RespawnWindow_Healthbar()
    {
    
    }

}
