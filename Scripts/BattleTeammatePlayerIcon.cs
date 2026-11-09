using UnityEngine;
internal class BattleTeammatePlayerIcon : MonoBehaviour
{
    // Fields
    public UITexture icon;
    public UnityEngine.Transform emojiPoint;
    internal bool 丄世不下专七丂丘丝;
    internal string 丆世丘丒丒丏上且丗;
    private EmojiChat 丝专丟丑世丅不丏万;
    private readonly float 下丟丁丅丏下丆世丛;
    private float 专东丞业万丈与万丏;
    
    // Methods
    internal UnityEngine.Transform 上丄丐丅三丄三丈丘(NetworkStartTable 不且上一上丐三万丛, EmojiChat 丂丄世东丌下七丐一)
    {
        Player_move_c val_3;
        this.丝专丟丑世丅不丏万 = 丂丄世东丌下七丐一;
        this.丄世不下专七丂丘丝 = false;
        this.gameObject.SetActive(value:  true);
        if(不且上一上丐三万丛 != null)
        {
                this.丆世丘丒丒丏上且丗 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        }
        else
        {
                this.丆世丘丒丒丏上且丗 = 36;
        }
        
        val_3 = 不且上一上丐三万丛.丌丑丛业丈丘世丞丕;
        if((val_3 != 0) && (不且上一上丐三万丛.丄世一丞万一丁丙丁 != true))
        {
                val_3 = this.icon;
        }
        
        this.专东丞业万丈与万丏 = this.下丟丁丅丏下丆世丛;
        return (UnityEngine.Transform)this.emojiPoint;
    }
    private void Update()
    {
        float val_2 = this.专东丞业万丈与万丏;
        if(val_2 <= 0f)
        {
                this.丁丕上一与丟丞与世();
            val_2 = this.专东丞业万丈与万丏;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_2 - val_1;
        this.专东丞业万丈与万丏 = val_1;
    }
    internal void 丁丕上一与丟丞与世()
    {
        var val_4;
        var val_5;
        this.gameObject.SetActive(value:  false);
        this.丄世不下专七丂丘丝 = true;
        this.丆世丘丒丒丏上且丗 = "";
        val_4 = null;
        val_4 = null;
        if(BattleTeammatesEmojiShower.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(this.丝专丟丑世丅不丏万 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        Add(item:  this.丝专丟丑世丅不丏万);
    }
    public BattleTeammatePlayerIcon()
    {
        this.丄世不下专七丂丘丝 = true;
        this.下丟丁丅丏下丆世丛 = 2f;
    }

}
