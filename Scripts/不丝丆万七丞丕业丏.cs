using UnityEngine;
private sealed class SkinName.不丝丆万七丞丕业丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SkinName 丝且与丝丒丟万丁专;
    public bool 且且与丛七丗上丛三;
    private UnityEngine.Transform 世丂丒丘丂三世七与;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 专上业三丗万丙丗一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkinName.不丝丆万七丞丕业丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_39;
        var val_40;
        UnityEngine.Object val_41;
        UnityEngine.Object val_42;
        int val_43;
        var val_44;
        ArmorRefs val_45;
        val_39 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_40 = null;
        val_40 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_6;
        }
        
        if(((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.丟东丞丂丗丘七丗丛)) == true) || ((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.丟东丞丂丗丘七丗丛, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == false))
        {
            goto label_58;
        }
        
        val_41 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Armor_Low");
        goto label_12;
        label_2:
        val_42 = val_39;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.专上业三丗万丙丗一 != null)
        {
            goto label_61;
        }
        
        label_62:
        label_61:
        if(this.专上业三丗万丙丗一.下丑万三且丟丒丌丕() == false)
        {
            goto label_14;
        }
        
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_39 = this.专上业三丗万丙丗一;
        UnityEngine.Object val_6 = val_39.丂丑且与丐七丟丝下();
        if(val_6 == null)
        {
            goto label_16;
        }
        
        val_39 = (null == null) ? (val_6) : 0;
        goto label_17;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_116:
        if(this.丝且与丝丒丟万丁专.playerMoveC.丙不丅丕三丂业东丕() != 0)
        {
            goto label_22;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_43 = 1;
        return (bool)val_43;
        label_3:
        val_43 = 0;
        return (bool)val_43;
        label_14:
        val_43 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_43;
        return (bool)val_43;
        label_22:
        SetPosInArmor val_9 = this.丝且与丝丒丟万丁专.丈丈丒且丕丕东丙丞.leftBone.GetComponent<SetPosInArmor>();
        val_42 = this.丝且与丝丒丟万丁专.丈丈丒且丕丕东丙丞.rightBone.GetComponent<SetPosInArmor>();
        if(val_9 != 0)
        {
                val_9.Target = this.丝且与丝丒丟万丁专.playerMoveC.丙不丅丕三丂业东丕().丛丑丂丌与丗东下专();
        }
        
        if(val_42 != 0)
        {
                val_42.Target = this.丝且与丝丒丟万丁专.playerMoveC.丙不丅丕三丂业东丕().丘万专丌丕与上丅丁();
        }
        
        this.丝且与丝丒丟万丁专.playerMoveC.东丄丑丈七丛丁丄丝.Clear();
        this.丝且与丝丒丟万丁专.playerMoveC.东丄丑丈七丛丁丄丝.Add(item:  val_9);
        this.丝且与丝丒丟万丁专.playerMoveC.东丄丑丈七丛丁丄丝.Add(item:  val_42);
        label_117:
        mem[this.世丂丒丘丂三世七与].parent = this.丝且与丝丒丟万丁专.armorPoint.transform;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        mem[this.世丂丒丘丂三世七与].localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        mem[this.世丂丒丘丂三世七与].localRotation = new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w};
        val_39 = mem[this.世丂丒丘丂三世七与];
        val_39.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_118;
        label_6:
        label_58:
        东丕与不丟丈与丄丟 val_21 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  "Armor/"("Armor/") + this.丝且与丝丒丟万丁专.丟东丞丂丗丘七丗丛, 不丌丞专丈丙丛东丏:  false);
        this.专上业三丗万丙丗一 = val_21;
        if(val_21 != null)
        {
            goto label_61;
        }
        
        goto label_62;
        label_16:
        val_41 = 0;
        label_17:
        this.专上业三丗万丙丗一 = 0;
        label_12:
        if(val_41 != 0)
        {
            goto label_65;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_66;
        }
        
        this.丝且与丝丒丟万丁专.丈丈丒且丕丕东丙丞 = 0;
        goto label_118;
        label_65:
        this.世丂丒丘丂三世七与 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_41).transform;
        val_44 = null;
        val_44 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                this.世丂丒丘丂三世七与.GetChild(index:  0).GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>().material = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "LowPolyArmorMaterials/"("LowPolyArmorMaterials/") + this.丝且与丝丒丟万丁专.丟东丞丂丗丘七丗丛 + "_low");
        }
        
        if(this.且且与丛七丗上丛三 != false)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  this.世丂丒丘丂三世七与, 丈七与世丏丕业世丙:  false);
        }
        
        val_45 = this.世丂丒丘丂三世七与.GetChild(index:  0).GetComponent<ArmorRefs>();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_81;
        }
        
        val_42 = this.丝且与丝丒丟万丁专.丈丈丒且丕丕东丙丞;
        this.丝且与丝丒丟万丁专.丈丈丒且丕丕东丙丞 = val_45;
        goto label_82;
        label_66:
        mem[352] = 0;
        goto label_83;
        label_81:
        val_42 = 352;
        mem[352] = val_45;
        val_45 = mem[352];
        label_82:
        if(val_45 == 0)
        {
            goto label_86;
        }
        
        if(((val_30 + 48) == 0) || ((val_30 + 48 + 24) != this.丝且与丝丒丟万丁专.playerAnimation.spineBones.Length))
        {
            goto label_96;
        }
        
        var val_40 = 0;
        label_103:
        if(val_40 >= (val_30 + 48 + 24))
        {
            goto label_99;
        }
        
        var val_32 = (val_30 + 48) + 0;
        val_40 = val_40 + 1;
        if(((val_30 + 48 + 0) + 32) != 0)
        {
            goto label_103;
        }
        
        label_96:
        UnityEngine.Debug.LogError(message:  "Incorrect armor spine bones in: "("Incorrect armor spine bones in: ") + this.丝且与丝丒丟万丁专.丟东丞丂丗丘七丗丛);
        label_99:
        if(this.丝且与丝丒丟万丁专.playerMoveC != 0)
        {
                if(this.丝且与丝丒丟万丁专.playerMoveC.transform.childCount > 0)
        {
            goto label_116;
        }
        
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == true)
        {
            goto label_116;
        }
        
        goto label_117;
        label_86:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_118;
        }
        
        label_83:
        label_118:
        val_43 = 0;
        this.丝且与丝丒丟万丁专.丝丅丈丆东丞专丘三 = 0;
        return (bool)val_43;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
