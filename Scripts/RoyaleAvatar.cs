using UnityEngine;
public class RoyaleAvatar : MonoBehaviour
{
    // Fields
    public UnityEngine.SkinnedMeshRenderer armsMeshRenderer;
    public UnityEngine.SkinnedMeshRenderer bodyMeshRenderer;
    public UnityEngine.SkinnedMeshRenderer headMeshRenderer;
    public UnityEngine.SkinnedMeshRenderer legsMeshRenderer;
    public UnityEngine.Texture skinTexture;
    public UnityEngine.Material lowMaterial;
    public EffectBones[] effects;
    public EffectBones effectsForMutationMode;
    public static readonly string ARM_LEFT_BONE_NAME;
    public static readonly string ARM_RIGHT_BONE_NAME;
    private static readonly string 丟丆下世上丞丈万东;
    private static readonly string 丒丙丏丏丝专丆丈上;
    private static readonly string 一万丙丟丙下丁上丛;
    private static readonly string 丄丆丕丑丈丑丗丈东;
    private static System.Collections.Generic.Dictionary<string, UnityEngine.Transform> 丘丞丁丏丟万一丙丛;
    public bool useLowBodyByWeapon;
    public bool useEffectsOnLowDevices;
    
    // Methods
    internal static bool 丈上世万丞上丙丑丈(string 丛七丕丘丂七丅七丟, bool 丙丁不上丐丏丁一丏)
    {
        var val_5;
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = RoyaleAvatar.丟丆下世上丞丈万东;
        if((丛七丕丘丂七丅七丟.Contains(value:  val_6)) != false)
        {
                val_7 = null;
            val_7 = null;
            val_6 = RoyaleAvatar.一万丙丟丙下丁上丛;
            if((丛七丕丘丂七丅七丟.Contains(value:  val_6)) != false)
        {
                val_8 = null;
            val_8 = null;
            val_6 = RoyaleAvatar.丄丆丕丑丈丑丗丈东;
            val_9 = (~((丛七丕丘丂七丅七丟.Contains(value:  val_6)) & 丙丁不上丐丏丁一丏)) & 1;
            return (bool)val_9;
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    internal static bool 丆丂丟下丅东丘丐专(string 丛七丕丘丂七丅七丟, bool 丙丁不上丐丏丁一丏)
    {
        var val_5;
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = RoyaleAvatar.丟丆下世上丞丈万东;
        if((丛七丕丘丂七丅七丟.Contains(value:  val_6)) != false)
        {
                val_7 = null;
            val_7 = null;
            val_6 = RoyaleAvatar.丒丙丏丏丝专丆丈上;
            if((丛七丕丘丂七丅七丟.Contains(value:  val_6)) != false)
        {
                val_8 = null;
            val_8 = null;
            val_6 = RoyaleAvatar.丄丆丕丑丈丑丗丈东;
            val_9 = (~((丛七丕丘丂七丅七丟.Contains(value:  val_6)) & 丙丁不上丐丏丁一丏)) & 1;
            return (bool)val_9;
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    internal static string 东世三丘丒丁与万一(string 丒丙丗七业丕世丐一, bool 丙丁不上丐丏丁一丏 = False)
    {
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丒丙丗七业丕世丐一.ToUpper();
        val_7 = null;
        if((RoyaleAvatar.丆丂丟下丅东丘丐专(丛七丕丘丂七丅七丟:  val_6, 丙丁不上丐丏丁一丏:  丙丁不上丐丏丁一丏)) != false)
        {
                val_7 = null;
            return (string)val_8;
        }
        
        if((RoyaleAvatar.丈上世万丞上丙丑丈(丛七丕丘丂七丅七丟:  val_6, 丙丁不上丐丏丁一丏:  丙丁不上丐丏丁一丏)) == false)
        {
                return (string)val_8;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = 1152921505253814280;
        return (string)val_8;
    }
    internal static void 丞不且丆丒不丄专三(UnityEngine.SkinnedMeshRenderer 丑一丑丏丐丅丞丞丂, UnityEngine.SkinnedMeshRenderer 丈丈三丕丘业丐丁丌, UnityEngine.Transform[] 丆丕东三丒丟三三三)
    {
        var val_19;
        var val_29;
        UnityEngine.Object val_30;
        UnityEngine.SkinnedMeshRenderer val_31;
        UnityEngine.Object val_32;
        var val_33;
        var val_34;
        int val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        val_29 = 丆丕东三丒丟三三三;
        val_30 = 丑一丑丏丐丅丞丞丂.sharedMesh;
        val_31 = 1152921504848912384;
        val_32 = 丈丈三丕丘业丐丁丌.sharedMesh;
        if(val_30 == val_32)
        {
                return;
        }
        
        丑一丑丏丐丅丞丞丂.sharedMesh = 丈丈三丕丘业丐丁丌.sharedMesh;
        if(val_29 == null)
        {
                val_29 = 丑一丑丏丐丅丞丞丂.bones;
        }
        
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform> val_6 = null;
        val_30 = val_6;
        val_6 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform>();
        val_33 = 1152921504833470464;
        val_34 = 0;
        goto label_10;
        label_22:
        val_35 = val_5.Length;
        if(val_34 >= val_5.Length)
        {
            goto label_11;
        }
        
        label_23:
        UnityEngine.Transform val_27 = val_29[0];
        if(val_27 != 0)
        {
                val_6.Add(key:  val_27.name.ToUpper(), value:  val_27);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "Player\'s bone is NULL!");
        }
        
        val_34 = 1;
        label_10:
        if(val_29 == null)
        {
            goto label_22;
        }
        
        val_35 = val_5.Length & 4294967295;
        if(val_34 < val_5.Length)
        {
            goto label_23;
        }
        
        label_11:
        UnityEngine.Transform[] val_10 = new UnityEngine.Transform[0];
        val_32 = 1152921538880552176;
        val_36 = 0;
        val_37 = 0;
        goto label_24;
        label_76:
        string val_13 = 丈丈三丕丘业丐丁丌.bones[0].name.ToUpper();
        if((val_6.ContainsKey(key:  val_13)) == false)
        {
            goto label_31;
        }
        
        if(val_30 != null)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        UnityEngine.Transform val_15 = val_6.Item[val_13];
        if(val_10 == null)
        {
            goto label_33;
        }
        
        if(val_15 != null)
        {
            goto label_34;
        }
        
        goto label_48;
        label_31:
        if((val_37 & 1) != 0)
        {
            goto label_64;
        }
        
        val_38 = null;
        val_38 = null;
        RoyaleAvatar.丘丞丁丏丟万一丙丛.Clear();
        Dictionary.Enumerator<TKey, TValue> val_16 = val_6.GetEnumerator();
        label_46:
        if(((-85945344) & 1) == 0)
        {
            goto label_41;
        }
        
        ConfiguredValueTaskAwaiter val_20 = val_19.GetAwaiter();
        RoyaleAvatar.丘丞丁丏丟万一丙丛.Add(key:  RoyaleAvatar.东世三丘丒丁与万一(丒丙丗七业丕世丐一:  val_20._value._obj.丐丏七丌丕丗业且上(), 丙丁不上丐丏丁一丏:  (val_6.Count > 2) ? 1 : 0), value:  val_20._value._obj);
        goto label_46;
        label_33:
        if(val_15 == null)
        {
            goto label_48;
        }
        
        label_34:
        label_48:
        val_10[0] = val_15;
        goto label_50;
        label_41:
        val_39 = 0;
        val_40 = 0 + 1;
        val_33 = val_33;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_32 = 1152921538880552176;
        if( != 1)
        {
                var val_29 = 0;
            val_29 = val_29 ^ 0;
            val_41 =  + val_29;
        }
        else
        {
                if( != 0)
        {
                val_39 = 0;
        }
        
            val_41 = 0;
        }
        
        val_42 = null;
        val_42 = null;
        val_30 = RoyaleAvatar.丘丞丁丏丟万一丙丛;
        if((val_30.ContainsKey(key:  val_13)) == false)
        {
            goto label_64;
        }
        
        if(val_30 != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_64:
        object[] val_26 = new object[1];
        if(val_26 == null)
        {
            goto label_67;
        }
        
        if(val_13 != null)
        {
            goto label_68;
        }
        
        goto label_71;
        label_67:
        if(val_13 == null)
        {
            goto label_71;
        }
        
        label_68:
        label_71:
        val_26[0] = val_13;
        UnityEngine.Debug.LogErrorFormat(format:  "Can\'t find RoyalAvatar bone {0} in player\'s mesh", args:  val_26);
        val_37 = 1;
        label_50:
        val_36 = 1;
        label_24:
        if(val_36 < val_10.Length)
        {
            goto label_76;
        }
        
        val_31 = 丑一丑丏丐丅丞丞丂;
        val_31.bones = val_10;
    }
    internal static void 丘一丒丙世丅东丗七(UnityEngine.GameObject 三东丒丁且下丄七丛, UnityEngine.SkinnedMeshRenderer 丑业丄专丟业丆与且)
    {
        UnityEngine.SkinnedMeshRenderer val_10;
        UnityEngine.Object val_11;
        UnityEngine.SkinnedMeshRenderer val_12;
        UnityEngine.SkinnedMeshRenderer val_13;
        UnityEngine.Transform[] val_14;
        WeaponSounds val_1 = 三东丒丁且下丄七丛.GetComponent<WeaponSounds>();
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        val_1._innerPars.FindArms();
        InnerWeaponPars val_4 = val_1._innerPars;
        val_10 = val_4.renderArms;
        goto label_9;
        label_4:
        GadgetArmoryItem val_5 = 三东丒丁且下丄七丛.GetComponent<GadgetArmoryItem>();
        val_11 = 0;
        if(val_5 == 0)
        {
            goto label_13;
        }
        
        if(val_5 != null)
        {
                val_5.上万世丟丙丈东下丂();
        }
        else
        {
                val_5.上万世丟丙丈东下丂();
        }
        
        val_10 = val_5.renderArms;
        label_9:
        val_11 = mem[val_5.renderArms];
        label_13:
        if(val_11 == 0)
        {
                return;
        }
        
        if((三东丒丁且下丄七丛.GetComponent<RoyalAvatarArmsFix>()) != 0)
        {
                val_12 = val_11;
            val_13 = 丑业丄专丟业丆与且;
            val_14 = val_8.fixedBones;
        }
        else
        {
                val_12 = val_11;
            val_13 = 丑业丄专丟业丆与且;
            val_14 = 0;
        }
        
        RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  val_12, 丈丈三丕丘业丐丁丌:  val_13, 丆丕东三丒丟三三三:  val_14);
    }
    public RoyaleAvatar()
    {
    
    }
    private static RoyaleAvatar()
    {
        RoyaleAvatar.ARM_LEFT_BONE_NAME = "RP_L_ARM_BONE";
        RoyaleAvatar.ARM_RIGHT_BONE_NAME = "RP_R_ARM_BONE";
        RoyaleAvatar.丟丆下世上丞丈万东 = "ARM";
        RoyaleAvatar.丒丙丏丏丝专丆丈上 = "LEFT";
        RoyaleAvatar.一万丙丟丙下丁上丛 = "RIGHT";
        RoyaleAvatar.丄丆丕丑丈丑丗丈东 = "POINT";
        RoyaleAvatar.丘丞丁丏丟万一丙丛 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform>();
    }

}
