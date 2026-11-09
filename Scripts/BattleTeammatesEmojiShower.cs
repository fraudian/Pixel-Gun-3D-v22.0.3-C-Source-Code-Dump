using UnityEngine;
internal class BattleTeammatesEmojiShower : MonoBehaviour
{
    // Fields
    internal static BattleTeammatesEmojiShower 丄丘七三上丕世丞业;
    private EmojiChat 不丂丛丙万丆与丅上;
    private UnityEngine.GameObject 世丕与丆丞丒七丑丕;
    internal System.Collections.Generic.List<EmojiChat> 丟丟丄一不丂丏丐东;
    public System.Collections.Generic.List<BattleTeammatePlayerIcon> listTeammatesIcons;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Emoji/ChatBattleTeammateEmoji");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_4 = 0;
        }
        
        this.世丕与丆丞丒七丑丕 = val_4;
        val_5 = null;
        val_5 = null;
        BattleTeammatesEmojiShower.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        null = null;
        BattleTeammatesEmojiShower.丄丘七三上丕世丞业 = 0;
    }
    private void 与丟且不与丅三丟丆()
    {
        if(this.丟丟丄一不丂丏丐东.Count != 0)
        {
                this.不丂丛丙万丆与丅上 = this.丟丟丄一不丂丏丐东.Item[0];
            this.丟丟丄一不丂丏丐东.RemoveAt(index:  0);
            return;
        }
        
        this.不丂丛丙万丆与丅上 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.世丕与丆丞丒七丑丕).GetComponent<EmojiChat>();
    }
    internal void 上丄丐丅三丄三丈丘(NetworkStartTable 不且上一上丐三万丛, string 丛丆丆世下丛不丏东)
    {
        var val_15;
        var val_16;
        string val_17;
        var val_18;
        float val_19;
        EmojiChat val_20;
        var val_21;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_15 = 1152921505219145728;
            val_16 = 0;
            val_17 = mem[InGameGUIPart_TeamDuel.__il2cppRuntimeField_byval_arg + 32];
            val_17 = InGameGUIPart_TeamDuel.__il2cppRuntimeField_byval_arg + 32;
            return;
        }
        
        val_15 = 1152921537155842496;
        val_18 = 0;
        goto label_20;
        label_29:
        BattleTeammatePlayerIcon val_4 = this.listTeammatesIcons.Item[0];
        if(val_4.丄世不下专七丂丘丝 == true)
        {
            goto label_23;
        }
        
        BattleTeammatePlayerIcon val_5 = this.listTeammatesIcons.Item[0];
        val_17 = val_5.丆世丘丒丒丏上且丗;
        if((System.String.op_Equality(a:  val_17, b:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == true)
        {
                return;
        }
        
        val_18 = 1;
        label_20:
        val_17 = this.listTeammatesIcons;
        if(val_18 < val_17.Count)
        {
            goto label_29;
        }
        
        return;
        label_23:
        this.与丟且不与丅三丟丆();
        UnityEngine.Vector3 val_14 = this.listTeammatesIcons.Item[0].上丄丐丅三丄三丈丘(不且上一上丐三万丛:  不且上一上丐三万丛, 丂丄世东丌下七丐一:  this.不丂丛丙万丆与丅上).position;
        val_19 = val_14.x;
        this.不丂丛丙万丆与丅上.transform.position = new UnityEngine.Vector3() {x = val_19, y = val_14.y, z = val_14.z};
        val_20 = this.不丂丛丙万丆与丅上;
        val_21 = val_18;
        val_20.SetEmojiSlot(与丄不丌一世东丁丙:  0);
        this.不丂丛丙万丆与丅上.下丞丆业丘东丁下且(丈丗与丞一上且上上:  不且上一上丐三万丛, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
    }
    public BattleTeammatesEmojiShower()
    {
        this.丟丟丄一不丂丏丐东 = new System.Collections.Generic.List<EmojiChat>();
        this.listTeammatesIcons = new System.Collections.Generic.List<BattleTeammatePlayerIcon>();
    }
    private static BattleTeammatesEmojiShower()
    {
    
    }

}
