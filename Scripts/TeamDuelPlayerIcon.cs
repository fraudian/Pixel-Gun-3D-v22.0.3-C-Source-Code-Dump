using UnityEngine;
public class TeamDuelPlayerIcon : MonoBehaviour
{
    // Fields
    public UITexture icon;
    public UITexture secondIcon;
    public UnityEngine.GameObject deadIcon;
    public UnityEngine.GameObject killAnim;
    public UnityEngine.Transform emojiPoint;
    private bool 上丟丏世丁丂丄丟专;
    private bool 不丑不且丆丛上丈丘;
    public string pixelbookID;
    
    // Methods
    private void Start()
    {
        this.killAnim.SetActive(value:  false);
    }
    internal void 丑七下业与丕丛丅丕(NetworkStartTable 不且上一上丐三万丛)
    {
        bool val_6;
        Player_move_c val_7;
        if(不且上一上丐三万丛 != null)
        {
                this.pixelbookID = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        }
        else
        {
                this.pixelbookID = 36;
        }
        
        if(不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != 0)
        {
                val_6 = 不且上一上丐三万丛.丄世一丞万一丁丙丁;
        }
        else
        {
                val_6 = false;
        }
        
        this.不丑不且丆丛上丈丘 = val_6;
        val_7 = 不且上一上丐三万丛.丌丑丛业丈丘世丞丕;
        if(val_7 == 0)
        {
                return;
        }
        
        if(不且上一上丐三万丛.丄世一丞万一丁丙丁 == true)
        {
                return;
        }
        
        this.icon.enabled = true;
        var val_4 = (不且上一上丐三万丛.万丛丏万丟丕丒丛与 == 0) ? (不且上一上丐三万丛 + 200) : 不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        val_7 = this.icon;
        if((UnityEngine.Object.op_Implicit(exists:  this.secondIcon)) != false)
        {
                val_7 = mem[不且上一上丐三万丛.丌丏丞丆丗与东丗业];
        }
        
        this.deadIcon.SetActive(value:  false);
        this.上丟丏世丁丂丄丟专 = true;
    }
    public void UpdateState()
    {
        if(this.上丟丏世丁丂丄丟专 != false)
        {
                this.上丟丏世丁丂丄丟专 = false;
            return;
        }
        
        this.icon.enabled = false;
        if(this.deadIcon.activeSelf == true)
        {
                return;
        }
        
        this.deadIcon.SetActive(value:  true);
        if(this.不丑不且丆丛上丈丘 == false)
        {
                return;
        }
        
        this.killAnim.SetActive(value:  true);
    }
    public TeamDuelPlayerIcon()
    {
    
    }

}
