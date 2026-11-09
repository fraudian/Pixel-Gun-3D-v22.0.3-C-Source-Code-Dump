using UnityEngine;
public class ScoresLabel : MonoBehaviour
{
    // Fields
    private UILabel 一丙且丛丟丈丙且与;
    private bool 且下万业七三丅丈且;
    private string 丞万东丏丝与丛丛三;
    
    // Methods
    private void Start()
    {
        this.且下万业七三丅丈且 = GameConnect.世丐丄三三上丅七三();
        UnityEngine.GameObject val_3 = this.gameObject;
        if((GameConnect.丌专丌万一下丕专上() != true) && (GameConnect.万七丄丛丈丟专一丑() != true))
        {
                if(GameConnect.丙丘不世专且万丄丐() != true)
        {
                if(this.且下万业七三丅丈且 == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        if(val_3 != null)
        {
            goto label_20;
        }
        
        label_21:
        label_20:
        val_3.SetActive(value:  true);
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
        if(this.且下万业七三丅丈且 != false)
        {
                string val_8 = 丟丏下丂七三下丗丕.不丒业丒三丐丙丞下();
        }
        
        this.丞万东丏丝与丛丛三 = 丟丏下丂七三下丗丕.丘专丒丝丌专上丙世();
        return;
        label_10:
        bool val_11 = GameConnect.丛专丌且丕不专丈下();
        if(val_3 != null)
        {
            goto label_20;
        }
        
        goto label_21;
    }
    private void Update()
    {
        var val_6;
        System.Collections.Generic.List<Player_move_c> val_7;
        object val_8;
        var val_9;
        if(this.且下万业七三丅丈且 == false)
        {
            goto label_1;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_7 == null)
        {
            goto label_4;
        }
        
        val_7 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_7 == null)
        {
                val_7 = 0;
        }
        
        val_8 = val_7;
        int val_1 = val_8.Count;
        goto label_8;
        label_1:
        val_9 = null;
        val_9 = null;
        this.一丙且丛丟丈丙且与.text = System.String.Format(format:  "{0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  GameController.mode.丞丏丕丑丞丑丏丏丄()));
        return;
        label_4:
        val_8 = 0;
        label_8:
        this.一丙且丛丟丈丙且与.text = System.String.Format(format:  "{0}", arg0:  val_8);
    }
    public ScoresLabel()
    {
    
    }

}
