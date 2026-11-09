using UnityEngine;
private sealed class ShopNGUIController.丌丑且专丈丛丐专三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopNGUIController 丝且与丝丒丟万丁专;
    private UnityEngine.Vector3 丂丛世丞专丁丝专丂;
    private CategoryNames 丅丗丏不丟东丆丏丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopNGUIController.丌丑且专丈丛丐专三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_69;
        float val_70;
        var val_71;
        var val_72;
        CategoryNames val_73;
        UnityEngine.Transform val_74;
        float val_76;
        float val_77;
        float val_78;
        float val_79;
        float val_80;
        UnityEngine.Object val_81;
        float val_82;
        float val_83;
        float val_84;
        float val_85;
        float val_86;
        float val_87;
        float val_88;
        CategoryNames val_89;
        float val_90;
        float val_91;
        float val_92;
        float val_96;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_69 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_69;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_2 = Holoville.HOTween.HOTween.Kill(p_target:  this.丝且与丝丒丟万丁专.characterPoint.GetChild(index:  0));
        val_70 = 1f;
        val_71 = val_70;
        val_72 = val_70;
        this.丂丛世丞专丁丝专丂 = 0;
        mem[1152921539141546256] = 0;
        this.丝且与丝丒丟万丁专.丛丏专专世下丘丈上 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.丁丝世下一丟丅万东 = this.丂丛世丞专丁丝专丂;
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.与且丏丏丘丑与丕丟();
        this.丝且与丝丒丟万丁专.下且业专丆丕丝丛丙();
        if(this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() == null)
        {
            goto label_8;
        }
        
        CategoryNames val_5 = this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌();
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_58;
        }
        
        goto label_58;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_8:
        CategoryNames val_6 = this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且();
        label_10:
        this.丅丗丏不丟东丆丏丆 = val_6;
        if(val_6 != 210000)
        {
            goto label_15;
        }
        
        if(this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈 == 0)
        {
                UnityEngine.GameObject val_8 = new UnityEngine.GameObject();
            val_8.transform.parent = this.丝且与丝丒丟万丁专.characterPoint;
            UnityEngine.Vector3 val_11 = this.丝且与丝丒丟万丁专.characterPoint.position;
            val_8.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_74 = this.丝且与丝丒丟万丁专.characterPoint;
            UnityEngine.Quaternion val_13 = val_74.rotation;
            val_76 = val_13.x;
            val_77 = val_13.z;
            val_78 = val_76;
            val_79 = val_13.y;
            val_80 = val_77;
            val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_78, y = val_79, z = val_80, w = val_13.w};
            this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈 = val_8.transform;
        }
        
        label_18:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) == true)
        {
            goto label_31;
        }
        
        val_81 = this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒();
        if(val_81 == 0)
        {
            goto label_35;
        }
        
        label_31:
        val_82 = 0f;
        if(this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒() != 0)
        {
                CarShop val_21 = this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒();
            val_82 = val_21.ShopYOffsetRight;
        }
        
        val_83 = 0f;
        if(this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒() != 0)
        {
                CarShop val_24 = this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒();
            val_83 = val_24.ShopXOffsetUp;
        }
        
        UnityEngine.Vector3 val_25 = this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈.position;
        UnityEngine.Vector3 val_28 = this.丝且与丝丒丟万丁专.ourCameras.Item[1].transform.position;
        val_84 = val_28.y;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_84, z = val_28.z});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  3f);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.up;
        float val_69 = 1.2f;
        val_69 = val_82 + val_69;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  val_69);
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.right;
        float val_70 = 0.25f;
        val_70 = val_83 + val_70;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  val_70);
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
        val_76 = val_36.x;
        val_77 = val_36.z;
        this.丝且与丝丒丟万丁专.丝上丏丕丟与丑丆一 = val_36;
        mem2[0] = val_36.y;
        mem2[0] = val_77;
        val_85 = val_76;
        val_86 = val_36.y;
        val_87 = val_77;
        UnityEngine.Vector3 val_37 = this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_85, y = val_86, z = val_87});
        this.丝且与丝丒丟万丁专.丝上丏丕丟与丑丆一 = val_37;
        mem2[0] = val_37.y;
        mem2[0] = val_37.z;
        val_73 = this.丅丗丏不丟东丆丏丆;
        label_15:
        if(val_73 != 160000)
        {
            goto label_55;
        }
        
        if(this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈 == 0)
        {
                UnityEngine.GameObject val_39 = new UnityEngine.GameObject();
            val_39.transform.parent = this.丝且与丝丒丟万丁专.characterPoint;
            UnityEngine.Vector3 val_42 = this.丝且与丝丒丟万丁专.characterPoint.position;
            val_39.transform.position = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
            val_74 = this.丝且与丝丒丟万丁专.characterPoint;
            UnityEngine.Quaternion val_44 = val_74.rotation;
            val_76 = val_44.x;
            val_77 = val_44.z;
            val_85 = val_76;
            val_86 = val_44.y;
            val_87 = val_77;
            val_39.transform.rotation = new UnityEngine.Quaternion() {x = val_85, y = val_86, z = val_87, w = val_44.w};
            this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈 = val_39.transform;
        }
        
        label_58:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  8))) == true)
        {
            goto label_71;
        }
        
        val_81 = this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丏业丛丘与丈业丁业();
        if(val_81 == 0)
        {
            goto label_75;
        }
        
        label_71:
        if(this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丏业丛丘与丈业丁业() == 0)
        {
                val_88 = 0.5f;
        }
        else
        {
                GliderShop val_52 = this.丝且与丝丒丟万丁专.丘丌丞丑业丑丗上丟.丏业丛丘与丈业丁业();
            val_88 = val_52.ShopYOffset;
        }
        
        UnityEngine.Vector3 val_53 = this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈.position;
        UnityEngine.Vector3 val_56 = this.丝且与丝丒丟万丁专.ourCameras.Item[1].transform.position;
        val_84 = val_56.x;
        val_82 = val_56.z;
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, b:  new UnityEngine.Vector3() {x = val_84, y = val_56.y, z = val_82});
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, d:  3f);
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, d:  val_88);
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, b:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
        val_76 = val_61.x;
        val_77 = val_61.z;
        this.丝且与丝丒丟万丁专.丆下丒东丐丐丕丌丟 = val_61;
        mem2[0] = val_61.y;
        mem2[0] = val_77;
        UnityEngine.Vector3 val_62 = this.丝且与丝丒丟万丁专.专丟世一丟丐丞丙丈.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_76, y = val_61.y, z = val_77});
        this.丝且与丝丒丟万丁专.丆下丒东丐丐丕丌丟 = val_62;
        mem2[0] = val_62.y;
        mem2[0] = val_62.z;
        label_55:
        if(this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() != null)
        {
                val_81 = this;
            this.丅丗丏不丟东丆丏丆 = this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌();
        }
        else
        {
                val_81 = this;
            val_89 = this.丅丗丏不丟东丆丏丆;
        }
        
        if(val_89 <= 12)
        {
            goto label_93;
        }
        
        if(val_89 <= 180000)
        {
            goto label_94;
        }
        
        if(val_89 == 200000)
        {
            goto label_95;
        }
        
        if(val_89 != 210000)
        {
            goto label_109;
        }
        
        val_90 = 12.51859f;
        val_91 = 16.84686f;
        val_92 = 12.21673f;
        UnityEngine.Vector3 val_66 = UnityEngine.Vector3.one;
        goto label_99;
        label_93:
        if(((val_89 == 6) || (val_89 == 9)) || (val_89 != 12))
        {
            goto label_109;
        }
        
        goto label_109;
        label_94:
        if(val_89 == 160000)
        {
            goto label_104;
        }
        
        if(val_89 == 180000)
        {
            goto label_109;
        }
        
        goto label_109;
        label_75:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_69 = 1;
        return (bool)val_69;
        label_35:
        val_69 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_69;
        return (bool)val_69;
        label_95:
        val_96 = mem[this.丝且与丝丒丟万丁专.丐且且一三业东丛丛];
        val_96 = this.丝且与丝丒丟万丁专.丐且且一三业东丛丛.x;
        goto label_110;
        label_104:
        val_96 = this.丝且与丝丒丟万丁专.丆下丒东丐丐丕丌丟;
        label_110:
        val_91 = 0f;
        val_92 = 0f;
        val_90 = 0f;
        UnityEngine.Vector3 val_67 = UnityEngine.Vector3.one;
        label_99:
        UnityEngine.Vector3 val_68 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z}, d:  0.8f);
        this.丂丛世丞专丁丝专丂 = val_68;
        mem[1152921539141546252] = val_68.y;
        mem[1152921539141546256] = val_68.z;
        label_109:
        if(this.丅丗丏不丟东丆丏丆 != 210000)
        {
                this.丝且与丝丒丟万丁专.专三不丅丂丌一万七 = 0f;
        }
        
        this.丝且与丝丒丟万丁专.丛丏专专世下丘丈上 = val_96;
        mem2[0] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        mem2[0] = 0;
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.丁丝世下一丟丅万东 = this.丂丛世丞专丁丝专丂;
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.丂万丑东七业丁业丁();
        val_69 = 0;
        return (bool)val_69;
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
