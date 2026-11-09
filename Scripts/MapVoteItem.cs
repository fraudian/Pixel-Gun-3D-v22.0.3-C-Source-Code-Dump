using UnityEngine;
public class MapVoteItem : MonoBehaviour
{
    // Fields
    public SceneInfo curSceneInfo;
    public UILabel NameMapLbl;
    public UITexture mapPreviewTexture;
    public UnityEngine.Animator animator;
    public UILabel likesCount;
    private bool 下东丂丄一下丛丌且;
    private bool 专丏丏一七三下不丝;
    private bool 上丈丟丂万丈丝丆丗;
    
    // Methods
    private void OnEnable()
    {
        this.上丈丟丂万丈丝丆丗 = true;
    }
    private void LateUpdate()
    {
        UnityEngine.Animator val_1;
        string val_2;
        if(this.上丈丟丂万丈丝丆丗 == false)
        {
                return;
        }
        
        this.上丈丟丂万丈丝丆丗 = false;
        if(this.下东丂丄一下丛丌且 != false)
        {
                val_1 = this.animator;
            val_2 = "liked";
        }
        else
        {
                if(this.专丏丏一七三下不丝 == false)
        {
                return;
        }
        
            val_1 = this.animator;
            val_2 = "showvotes";
        }
        
        val_1.SetTrigger(name:  val_2);
    }
    public void SetLiked(bool 丙业与丙丗丝不丈东)
    {
        this.下东丂丄一下丛丌且 = 丙业与丙丗丝不丈东;
        this.专丏丏一七三下不丝 = true;
        this.上丈丟丂万丈丝丆丗 = true;
    }
    public void SetShowVotes()
    {
        if(this.下东丂丄一下丛丌且 != false)
        {
                return;
        }
        
        this.专丏丏一七三下不丝 = true;
        this.上丈丟丂万丈丝丆丗 = true;
    }
    internal void 丙丂不丘丗丙且专三(int 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != 0)
        {
                float val_3 = 1000f;
            val_3 = (float)丙业与丙丗丝不丈东 / val_3;
            this.likesCount.text = System.String.Format(format:  "{0}k", arg0:  UnityEngine.Mathf.CeilToInt(f:  val_3));
            return;
        }
        
        this.likesCount.text = "0";
    }
    private void OnClick()
    {
        var val_7;
        var val_8;
        Rilisoft.七丕丟丏三丈一丄世 val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.下东丂丄一下丛丌且 == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(MapVoteController.丛丆丂丐丛不不丟万.丂一丒万丈不丒一万() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = GameConnect.丑丌丛丈丅丅与不业();
        if((MapVoteController.丛丆丂丐丛不不丟万.下丘丙丌万上与丏七(丂丛丑东不丅丈一东:  val_9, 下丞七丒业丂丈丘下:  this.curSceneInfo.indexMap)) == true)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = GameConnect.丑丌丛丈丅丅与不业();
        if((MapVoteController.丛丆丂丐丛不不丟万.丙七万丅万丞下一丕(丂丛丑东不丅丈一东:  val_9)) == 0)
        {
                return;
        }
        
        this.下东丂丄一下丛丌且 = true;
        this.animator.SetTrigger(name:  "like");
        val_11 = null;
        val_11 = null;
        MapVoteController.丛丆丂丐丛不不丟万.丐丑业丑丂东丘与丈(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 下丞七丒业丂丈丘下:  this.curSceneInfo.indexMap);
        val_12 = static_value_081DACA8;
        val_12 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丄三一丑不丏丙业业();
    }
    public void SetMapPreviewTitle()
    {
        if(this.curSceneInfo == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.curSceneInfo.七丛一丛专七丈丅专())) != false)
        {
                return;
        }
        
        this.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  this.curSceneInfo.七丛一丛专七丈丅专());
    }
    public MapVoteItem()
    {
    
    }

}
