using UnityEngine;
public class SiegeEmojiController : EmojiController
{
    // Fields
    private UIPanel panel;
    
    // Methods
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
    internal override bool 丟东丗丂东专丅丑丑(NetworkStartTable 不且上一上丐三万丛)
    {
        return (bool)(不且上一上丐三万丛.丘业丟丆丑丑丅丌上 != 0) ? 1 : 0;
    }
    protected override void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
        var val_33;
        var val_34;
        UnityEngine.Camera val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_45;
        var val_46;
        var val_47;
        var val_49;
        float val_50;
        var val_51;
        var val_52;
        var val_53;
        val_33 = null;
        val_33 = null;
        val_34 = 1152921504848912384;
        val_35 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
        if(val_35 == 0)
        {
                return;
        }
        
        val_36 = null;
        val_36 = null;
        if(SiegeController.三三万丆下一丗万丛 == 0)
        {
            goto label_10;
        }
        
        val_37 = 0;
        goto label_11;
        label_27:
        val_38 = null;
        val_38 = null;
        var val_3 = (SiegeController.三三万丆下一丗万丛 + 176 + 24) + 0;
        if((System.String.op_Equality(a:  (SiegeController.三三万丆下一丗万丛 + 176 + 24 + 0) + 32 + 72, b:  丟丗丙万丙且丐丏丗.owner.丈三世丞丕万丄七丂)) == true)
        {
            goto label_21;
        }
        
        val_37 = 1;
        label_11:
        val_39 = null;
        val_39 = null;
        if(val_37 < (SiegeController.三三万丆下一丗万丛 + 176 + 24 + 24))
        {
            goto label_27;
        }
        
        val_40 = 0;
        goto label_28;
        label_44:
        val_41 = null;
        val_41 = null;
        var val_5 = (SiegeController.三三万丆下一丗万丛 + 176 + 32) + 0;
        if((System.String.op_Equality(a:  (SiegeController.三三万丆下一丗万丛 + 176 + 32 + 0) + 32 + 72, b:  丟丗丙万丙且丐丏丗.owner.丈三世丞丕万丄七丂)) == true)
        {
            goto label_38;
        }
        
        val_40 = 1;
        label_28:
        val_42 = null;
        val_42 = null;
        if(val_40 < (SiegeController.三三万丆下一丗万丛 + 176 + 32 + 24))
        {
            goto label_44;
        }
        
        label_10:
        val_43 = null;
        val_43 = null;
        val_35 = DungeonsController.丄丘七三上丕世丞业;
        if(val_35 == 0)
        {
                return;
        }
        
        val_34 = 0;
        val_45 = null;
        val_45 = null;
        if( != null)
        {
                return;
        }
        
        return;
        label_21:
        val_46 = null;
        val_46 = null;
        val_47 = (SiegeController.三三万丆下一丗万丛 + 176 + 24) + 0;
        val_49 = null;
        val_49 = null;
        UnityEngine.Vector3 val_9 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = .__il2cppRuntimeField_20 + 80, y = .__il2cppRuntimeField_20 + 80 + 4, z = .__il2cppRuntimeField_20 + 88});
        val_35 = 丟丗丙万丙且丐丏丗.transform;
        float val_34 = 768f;
        float val_32 = (float)UnityEngine.Screen.height;
        float val_33 = (float)UnityEngine.Screen.height;
        val_32 = val_9.x / val_32;
        val_33 = val_9.y / val_33;
        val_32 = val_32 * val_34;
        val_34 = val_33 * val_34;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  120f);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  70f);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        val_50 = val_19.x;
        val_35.localPosition = new UnityEngine.Vector3() {x = val_50, y = val_19.y, z = val_19.z};
        val_51 = 1;
        goto label_91;
        label_38:
        val_52 = null;
        val_52 = null;
        var val_20 = (SiegeController.三三万丆下一丗万丛 + 176 + 32) + 0;
        val_53 = null;
        val_53 = null;
        UnityEngine.Vector3 val_21 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = (SiegeController.三三万丆下一丗万丛 + 176 + 32 + 0) + 32 + 80, y = (SiegeController.三三万丆下一丗万丛 + 176 + 32 + 0) + 32 + 80 + 4, z = (SiegeController.三三万丆下一丗万丛 + 176 + 32 + 0) + 32 + 88});
        val_35 = 丟丗丙万丙且丐丏丗.transform;
        float val_37 = 768f;
        float val_35 = (float)UnityEngine.Screen.height;
        float val_36 = (float)UnityEngine.Screen.height;
        val_35 = val_21.x / val_35;
        val_36 = val_21.y / val_36;
        val_35 = val_35 * val_37;
        val_37 = val_36 * val_37;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  120f);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  70f);
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        val_50 = val_31.x;
        val_35.localPosition = new UnityEngine.Vector3() {x = val_50, y = val_31.y, z = val_31.z};
        val_51 = 0;
        label_91:
        丟丗丙万丙且丐丏丗.SetEmojiAlign(专世丌丆丝丈丟丛丁:  false);
    }
    public SiegeEmojiController()
    {
    
    }

}
