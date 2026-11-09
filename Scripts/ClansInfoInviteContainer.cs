using UnityEngine;
public class ClansInfoInviteContainer : MonoBehaviour
{
    // Fields
    public UILabel _name;
    public UILabel cups;
    public UISprite spriteRank;
    protected string 丞丅上丏丂且下丅与;
    protected UnityEngine.GameObject parentPanel;
    public UILabel place;
    public int wrapIndex;
    
    // Methods
    public void UpdateView(ClansInviteGuiController.万丕上东丅与丙丏丕 东丛下丗且东丄业下)
    {
        UILabel val_11;
        var val_12;
        var val_13;
        if(东丛下丗且东丄业下 != null)
        {
                this._name.text = 东丛下丗且东丄业下.丞丞下东且丗丄丒丏;
            this.place.text = 东丛下丗且东丄业下.专世专丟丝丌与丘上.ToString();
            val_11 = this.cups;
            val_11.text = 东丛下丗且东丄业下.东丝世世丗专丟丏丘.ToString();
            this.丞丅上丏丂且下丅与 = 东丛下丗且东丄业下.丄丏丆丝世丙业下丌;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.spriteRank, 丏业丟一东丂东丘丛:  false);
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                if(丂与专万与丐丌丏不.丑七不且上丗丁一世() != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.spriteRank, 丏业丟一东丂东丘丛:  true);
            val_11 = this.spriteRank;
            val_11.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  丂与专万与丐丌丏不.丑七不且上丗丁一世().丛丁丝下丌丝且东世(丄丒且丙三丆丟与丏:  this.丞丅上丏丂且下丅与));
        }
        
        }
        
            val_12 = this.gameObject;
            val_13 = 1;
        }
        else
        {
                val_12 = this.gameObject;
            val_13 = 0;
        }
        
        val_12.SetActive(value:  false);
    }
    public void OnClick()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        this.parentPanel.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.丞丅上丏丂且下丅与, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClansInfoInviteContainer::丛丒专丛世丞丝上丟(bool 丕丁丗丘丟丆一丟丆)));
    }
    public ClansInfoInviteContainer()
    {
    
    }
    private void 丛丒专丛世丞丝上丟(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentPanel.SetActive(value:  true);
    }

}
