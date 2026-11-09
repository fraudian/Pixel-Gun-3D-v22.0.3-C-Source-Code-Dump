using UnityEngine;
public class TeamDuelInGameEmojiController : EmojiController
{
    // Fields
    public TeamDuelPlayerIcons teamDuelIcons;
    
    // Methods
    protected override void Awake()
    {
        this.teamDuelIcons = this.GetComponent<TeamDuelPlayerIcons>();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丕丐丞丟与丙丌丛上());
    }
    private System.Collections.IEnumerator 丕丐丞丟与丙丌丛上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TeamDuelInGameEmojiController.东业丌丝东丌丏丆丌();
    }
    protected override void Update()
    {
        var val_3;
        this.Update();
        val_3 = 0;
        goto label_1;
        label_4:
        EmojiChat val_1 = X21.Item[0];
        val_3 = 1;
        label_1:
        if(val_3 < X21.Count)
        {
            goto label_4;
        }
    
    }
    protected override void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
        var val_7;
        string val_8;
        var val_9;
        float val_10;
        var val_11;
        val_7 = 0;
        goto label_0;
        label_11:
        TeamDuelPlayerIcon val_8 = this.teamDuelIcons.teamDuelBluePlayerIcons[0];
        val_8 = 丟丗丙万丙且丐丏丗.owner.丈三世丞丕万丄七丂;
        if((this.teamDuelIcons.teamDuelBluePlayerIcons[0x0][0].pixelbookID.Equals(value:  val_8)) == true)
        {
            goto label_8;
        }
        
        val_7 = 1;
        label_0:
        if(val_7 < this.teamDuelIcons.teamDuelBluePlayerIcons.Length)
        {
            goto label_11;
        }
        
        val_9 = 3;
        goto label_12;
        label_23:
        TeamDuelPlayerIcon val_9 = this.teamDuelIcons.teamDuelRedPlayerIcons[0];
        val_8 = 丟丗丙万丙且丐丏丗.owner.丈三世丞丕万丄七丂;
        if((this.teamDuelIcons.teamDuelRedPlayerIcons[0x0][0].pixelbookID.Equals(value:  val_8)) == true)
        {
            goto label_20;
        }
        
        val_9 = 4;
        label_12:
        if((val_9 - 3) < this.teamDuelIcons.teamDuelRedPlayerIcons.Length)
        {
            goto label_23;
        }
        
        return;
        label_8:
        TeamDuelPlayerIcon val_10 = this.teamDuelIcons.teamDuelBluePlayerIcons[0];
        UnityEngine.Vector3 val_5 = this.teamDuelIcons.teamDuelBluePlayerIcons[0x0][0].emojiPoint.position;
        val_10 = val_5.x;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_10, y = val_5.y, z = val_5.z};
        val_11 = val_7;
        goto label_30;
        label_20:
        TeamDuelPlayerIcon val_11 = this.teamDuelIcons.teamDuelRedPlayerIcons[0];
        UnityEngine.Vector3 val_7 = this.teamDuelIcons.teamDuelRedPlayerIcons[0x0][0].emojiPoint.position;
        val_10 = val_7.x;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_10, y = val_7.y, z = val_7.z};
        val_11 = val_9;
        label_30:
        丟丗丙万丙且丐丏丗.SetEmojiSlot(与丄不丌一世东丁丙:  3);
    }
    public TeamDuelInGameEmojiController()
    {
    
    }

}
