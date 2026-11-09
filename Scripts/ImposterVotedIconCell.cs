using UnityEngine;
public class ImposterVotedIconCell : MonoBehaviour
{
    // Fields
    public UITextureMasked playerTexture;
    public UnityEngine.GameObject mineObject;
    private string 丞三丗丕七丄不丞业;
    
    // Methods
    internal void 业业专丌不业世一丞(NetworkStartTable 不且上一上丐三万丛)
    {
        bool val_7;
        if((System.String.op_Inequality(a:  this.丞三丗丕七丄不丞业, b:  不且上一上丐三万丛.三丆丛丁丞丘丂三丞)) != false)
        {
                this.丞三丗丕七丄不丞业 = 不且上一上丐三万丛.三丆丛丁丞丘丂三丞;
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.playerTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  不且上一上丐三万丛.三丆丛丁丞丘丂三丞)));
        }
        
        if(this.mineObject == 0)
        {
                return;
        }
        
        if(不且上一上丐三万丛 == 0)
        {
            goto label_10;
        }
        
        val_7 = 不且上一上丐三万丛.丌且下丕下下丌万丞;
        if(this.mineObject != null)
        {
            goto label_13;
        }
        
        goto label_12;
        label_10:
        val_7 = 0;
        if(this.mineObject != null)
        {
            goto label_13;
        }
        
        label_12:
        label_13:
        this.mineObject.SetActive(value:  (val_7 != 0) ? 1 : 0);
    }
    public ImposterVotedIconCell()
    {
        this.丞三丗丕七丄不丞业 = System.String.alignConst;
    }

}
