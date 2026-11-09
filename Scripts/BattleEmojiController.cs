using UnityEngine;
internal class BattleEmojiController : EmojiController
{
    // Fields
    public bool testEmoji;
    private EmojiChat 丅与与七上下三丑丒;
    public EmojiPanel emojiPanel;
    public UISprite bgForRect;
    public UISprite bgForLeftRect;
    private UnityEngine.Vector3 丏丘不下丛专丞丌丂;
    private UnityEngine.Vector3 与丈业万丄丒一专上;
    private bool 不与专丞一丕丒世世;
    private UnityEngine.Camera 丝丘丑下七丁丘一丐;
    
    // Methods
    internal bool 且丏丈丈丆丘丈丝丆(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        UnityEngine.Camera val_16;
        var val_17;
        if(this.不与专丞一丕丒世世 == false)
        {
            goto label_1;
        }
        
        val_16 = this.丝丘丑下七丁丘一丐;
        goto label_2;
        label_1:
        val_16 = this;
        this.丝丘丑下七丁丘一丐 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>();
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_17;
        }
        
        }
        
        }
        
        val_17 = public UnityEngine.Vector3[] UIWidget::get_worldCorners();
        UnityEngine.Vector3[] val_10 = this.bgForRect.worldCorners;
        if(val_10.Length == 0)
        {
                val_17 = 0;
        }
        
        label_34:
        this.丏丘不下丛专丞丌丂 = val_10[0];
        mem[1152921537153455824] = val_10[1];
        UnityEngine.Vector3[] val_11 = this.bgForRect.worldCorners;
        this.不与专丞一丕丒世世 = true;
        this.与丈业万丄丒一专上 = val_11[3];
        mem[1152921537153455836] = val_11[4];
        label_2:
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.x, y = 丟下丙丆不东一与丅.y});
        UnityEngine.Vector3 val_13 = this.丝丘丑下七丁丘一丐.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        if((val_13.x > this.与丈业万丄丒一专上) || (val_13.x < this.丏丘不下丛专丞丌丂))
        {
                return false;
        }
        
        if(val_13.y < val_13.x)
        {
                return false;
        }
        
        var val_14 = (val_13.y <= val_13.x) ? 1 : 0;
        return false;
        label_17:
        UnityEngine.Vector3[] val_15 = this.bgForLeftRect.worldCorners;
        UnityEngine.Vector3 val_20 = val_15[0];
        UnityEngine.Vector3 val_21 = val_15[1];
        goto label_34;
    }
    protected override void Awake()
    {
        var val_5;
        EmojiPanel val_6;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Emoji/ChatBattleEmoji");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        mem[1152921537153740936] = val_5;
        if(this.emojiPanel != 0)
        {
            goto label_5;
        }
        
        val_6 = this.GetComponent<EmojiPanel>();
        this.emojiPanel = val_6;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_6 = this.emojiPanel;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.emojiPanel.且丁丛丈七下且万丁 = true;
        this.emojiPanel.丆丕万业丈一丛丆丒 = true;
    }
    protected override void OnEnable()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if((丟丌丁且且世丈丈丟.且三丏上七业丙丅丆() != false) && (丟丌丁且且世丈丈丟.业丁丏且业万丄丝丘() != false))
        {
                val_8 = null;
            val_8 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                this.OnEnable();
            return;
        }
        
            val_9 = null;
            val_9 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
        }
        
        }
        
        this.transform.parent.gameObject.SetActive(value:  false);
    }
    protected override void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
        EmojiChat val_22;
        if(this.丅与与七上下三丑丒 != 0)
        {
            goto label_3;
        }
        
        val_22 = this;
        this.丅与与七上下三丑丒 = val_22;
        if(this != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_22 = this.丅与与七上下三丑丒;
        if(val_22 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(this.丅与与七上下三丑丒.owner != 0)
        {
                if(this.丅与与七上下三丑丒.owner.丌丑丛业丈丘世丞丕.丟丌下三七丁与丟丑() == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Transform val_7 = 丟丗丙万丙且丐丏丗.transform;
        UnityEngine.Vector3 val_8 = val_7.localPosition;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_44;
        }
        
        }
        
        }
        
        label_44:
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  100f);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  20f);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        val_7.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_38;
        }
        
        }
        
        if(丟丗丙万丙且丐丏丗 != null)
        {
            goto label_42;
        }
        
        label_43:
        label_42:
        丟丗丙万丙且丐丏丗.SetEmojiAlign(专世丌丆丝丈丟丛丁:  true);
        return;
        label_38:
        bool val_21 = GameConnect.且丞丁东丝丗上丈业();
        if(丟丗丙万丙且丐丏丗 != null)
        {
            goto label_42;
        }
        
        goto label_43;
    }
    protected override EmojiChat 丒丑东七丟丗上丟丅()
    {
        if(this.丅与与七上下三丑丒 != 0)
        {
                return (EmojiChat)this.丅与与七上下三丑丒;
        }
        
        if(this.丅与与七上下三丑丒.Count != 0)
        {
                this.丅与与七上下三丑丒 = this.丅与与七上下三丑丒.Item[0];
            this.丅与与七上下三丑丒.RemoveAt(index:  0);
            return (EmojiChat)this.丅与与七上下三丑丒;
        }
        
        this.丅与与七上下三丑丒 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.丅与与七上下三丑丒).GetComponent<EmojiChat>();
        return (EmojiChat)this.丅与与七上下三丑丒;
    }
    internal override void 下丞丆业丘东丁下且(NetworkStartTable 丈丗与丞一上且上上, string 丛丆丆世下丛不丏东)
    {
        var val_4;
        System.Collections.Generic.List<Player_move_c> val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_14 = this;
        if((val_14 & 1) == 0)
        {
                return;
        }
        
        if(丈丗与丞一上且上上.丌丑丛业丈丘世丞丕.丟丌下三七丁与丟丑() == false)
        {
            goto label_20;
        }
        
        this.下丞丆业丘东丁下且(丈丗与丞一上且上上:  丈丗与丞一上且上上, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
        if(this.testEmoji == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        List.Enumerator<T> val_2 = val_14.GetEnumerator();
        val_16 = 1152921525761786080;
        label_14:
        if(((-1812207840) & 1) == 0)
        {
            goto label_9;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5.丟丌下三七丁与丟丑() == true)
        {
            goto label_14;
        }
        
        val_5.下丞丆业丘东丁下且(丈丗与丞一上且上上:  丈丗与丞一上且上上, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
        goto label_14;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_20:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                val_17 = null;
            val_17 = null;
            if(BattleTeammatesEmojiShower.丄丘七三上丕世丞业 != 0)
        {
                val_16 = 1152921505286238208;
            val_18 = null;
            val_18 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_19 = null;
            val_19 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_20 = null;
            val_20 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_618.丘丑丅三丆丑丌且丝() == 丈丗与丞一上且上上.丘丑丅三丆丑丌且丝())
        {
                val_21 = null;
            val_21 = null;
            BattleTeammatesEmojiShower.丄丘七三上丕世丞业.上丄丐丅三丄三丈丘(不且上一上丐三万丛:  丈丗与丞一上且上上, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
        }
        
        }
        
        }
        
        }
        
        }
        
        val_14 = 丈丗与丞一上且上上.丌丑丛业丈丘世丞丕.battleEmojiHolder;
        val_14.下丞丆业丘东丁下且(丈丗与丞一上且上上:  丈丗与丞一上且上上, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
    }
    internal override bool 丟东丗丂东专丅丑丑(NetworkStartTable 不且上一上丐三万丛)
    {
        if(丟丌丁且且世丈丈丟.且三丏上七业丙丅丆() == false)
        {
                return false;
        }
        
        if(丟丌丁且且世丈丈丟.业丁丏且业万丄丝丘() == false)
        {
                return false;
        }
        
        if(不且上一上丐三万丛 == 0)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  不且上一上丐三万丛.丌丑丛业丈丘世丞丕, y:  0);
    }
    public override void SendEmoji(string 丛丆丆世下丛不丏东)
    {
        null = null;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(丛丆丆世下丛不丏东 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(丛丆丆世下丛不丏东 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_1[0] = 丛丆丆世下丛不丏东;
        val_1[1] = 124105336;
        NetworkStartTable.__il2cppRuntimeField_flags.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  194, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public BattleEmojiController()
    {
    
    }

}
