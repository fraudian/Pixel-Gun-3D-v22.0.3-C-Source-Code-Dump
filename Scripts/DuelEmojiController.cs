using UnityEngine;
public class DuelEmojiController : EmojiController
{
    // Fields
    public UIPanel panel;
    
    // Methods
    internal override bool 丟东丗丂东专丅丑丑(NetworkStartTable 不且上一上丐三万丛)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        DuelUIController val_1 = DuelController.丄丘七三上丕世丞业.duelUI;
        if(val_1.changeArea.activeSelf == true)
        {
            goto label_12;
        }
        
        val_7 = null;
        val_7 = null;
        DuelUIController val_3 = DuelController.丄丘七三上丕世丞业.duelUI;
        if(val_3.emojiPanel.activeInHierarchy == false)
        {
            goto label_12;
        }
        
        val_8 = null;
        val_8 = null;
        if(DuelController.丄丘七三上丕世丞业.opponentNetworkTable != 不且上一上丐三万丛)
        {
            goto label_18;
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_12:
        val_9 = 0;
        return (bool)val_9;
        label_18:
        val_10 = null;
        val_10 = null;
        return UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  不且上一上丐三万丛);
    }
    protected override void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
        var val_24;
        DuelController val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        float val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        val_24 = null;
        val_24 = null;
        val_25 = DuelController.丄丘七三上丕世丞业;
        if(val_25 == 0)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable & 1) != 0)
        {
                val_28 = null;
            val_25 = mem[DuelController.丄丘七三上丕世丞业 + 40];
            val_25 = DuelController.丄丘七三上丕世丞业.myCharacter;
            if(val_25 == 0)
        {
                return;
        }
        
            val_29 = null;
            val_29 = null;
            UnityEngine.Vector3 val_4 = 丁丝一下丁不七丗一().position;
            val_30 = null;
            val_30 = null;
            UnityEngine.Vector3 val_5 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_25 = 丟丗丙万丙且丐丏丗.transform;
            float val_26 = 768f;
            float val_24 = (float)UnityEngine.Screen.height;
            float val_25 = (float)UnityEngine.Screen.height;
            val_24 = val_5.x / val_24;
            val_25 = val_5.y / val_25;
            val_24 = val_24 * val_26;
            val_26 = val_25 * val_26;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  220f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_31 = val_12.x;
            val_25.localPosition = new UnityEngine.Vector3() {x = val_31, y = val_12.y, z = val_12.z};
            val_32 = 1;
        }
        else
        {
                val_33 = null;
            val_25 = mem[DuelController.丄丘七三上丕世丞业 + 128];
            val_25 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
            if((val_25 & 1) == 0)
        {
                return;
        }
        
            val_34 = null;
            val_34 = null;
            val_25 = mem[DuelController.丄丘七三上丕世丞业 + 48];
            val_25 = DuelController.丄丘七三上丕世丞业.enemyCharacter;
            if(val_25 == 0)
        {
                return;
        }
        
            val_35 = null;
            val_35 = null;
            UnityEngine.Vector3 val_15 = 丁丝一下丁不七丗一().position;
            val_36 = null;
            val_36 = null;
            UnityEngine.Vector3 val_16 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_25 = 丟丗丙万丙且丐丏丗.transform;
            float val_29 = 768f;
            float val_27 = (float)UnityEngine.Screen.height;
            float val_28 = (float)UnityEngine.Screen.height;
            val_27 = val_16.x / val_27;
            val_28 = val_16.y / val_28;
            val_27 = val_27 * val_29;
            val_29 = val_28 * val_29;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  220f);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_31 = val_23.x;
            val_25.localPosition = new UnityEngine.Vector3() {x = val_31, y = val_23.y, z = val_23.z};
            val_32 = 0;
        }
        
        丟丗丙万丙且丐丏丗.SetEmojiAlign(专世丌丆丝丈丟丛丁:  false);
    }
    public DuelEmojiController()
    {
    
    }

}
