using UnityEngine;
private sealed class BotHpIndicator.上东丙丌丞丈七丝丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.BotHpIndicator 丝且与丝丒丟万丁专;
    private bool 下丏三丞丝丘七七专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BotHpIndicator.上东丙丌丞丈七丝丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.BotHpIndicator val_50;
        var val_51;
        int val_52;
        BotHpIndicator.不且丅丙上丕与丂下 val_54;
        UnityEngine.Object val_57;
        UnityEngine.Object val_58;
        UnityEngine.Object val_59;
        RilisoftBot.BotHpIndicator val_60;
        不且丅丙上丕与丂下 val_61;
        var val_62;
        float val_63;
        float val_64;
        val_50 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_51 = this;
        this.下丏三丞丝丘七七专 = false;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_1:
        val_51 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.下丏三丞丝丘七七专 == false)
        {
            goto label_4;
        }
        
        label_2:
        val_52 = 0;
        return (bool)val_52;
        label_4:
        var val_53 = 0;
        val_53 = val_53 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = Unity.Linq.丅丆万丟丐丏丏下丄.丄下丝万与丕七世丒(丈丆上丅丘世专丑丕:  val_50.gameObject).GetEnumerator();
        val_54 = 1152921504691191808;
        label_40:
        var val_54 = 0;
        val_54 = val_54 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_78;
        }
        
        var val_55 = 0;
        val_55 = val_55 + 1;
        T val_8 = val_4.Current;
        new BotHpIndicator.丈业丗丞丁七下一不() = new System.Object();
        RilisoftBot.BaseBot val_10 = val_8.GetComponent<RilisoftBot.BaseBot>();
        if(new BotHpIndicator.丈业丗丞丁七下一不() != null)
        {
                val_57 = new BotHpIndicator.丈业丗丞丁七下一不();
            .业丘东且七丕丞东不 = val_10;
        }
        else
        {
                mem[16] = val_10;
            val_57 = 16;
        }
        
        if(val_57 != 0)
        {
            goto label_28;
        }
        
        Rilisoft.TrainingEnemy val_12 = val_8.GetComponent<Rilisoft.TrainingEnemy>();
        if(new BotHpIndicator.丈业丗丞丁七下一不() != null)
        {
                val_58 = new BotHpIndicator.丈业丗丞丁七下一不();
            .丁丙专专丕丈丝丞万 = val_12;
        }
        else
        {
                mem[24] = val_12;
            val_58 = 24;
        }
        
        if(val_58 != 0)
        {
            goto label_34;
        }
        
        SkinName val_14 = val_8.GetComponent<SkinName>();
        if(new BotHpIndicator.丈业丗丞丁七下一不() != null)
        {
                val_59 = new BotHpIndicator.丈业丗丞丁七下一不();
            .丝丘丅与丌丗丅丈下 = val_14;
        }
        else
        {
                mem[32] = val_14;
            val_59 = 32;
        }
        
        if(val_59 == 0)
        {
            goto label_40;
        }
        
        val_60 = val_50;
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_43;
        }
        
        val_61 = 0.丞丆丑丞与丆七且丒(丝丘丅与丌丗丅丈下:  mem[32]);
        val_50 = 0;
        val_62 = 0;
        mem2[0] = val_61;
        goto label_47;
        label_28:
        mem2[0] = val_50;
        if(mem[16].丙丕丁丅丁与丗丑丘() != 0)
        {
                IconModuleMob val_20 = UnityEngine.Object.Instantiate<IconModuleMob>(original:  UnityEngine.Resources.Load<IconModuleMob>(path:  this.丝且与丝丒丟万丁专 + 96));
            mem2[0] = val_20;
            if(val_20 != 0)
        {
                UnityEngine.Transform val_22 = this.丝且与丝丒丟万丁专 + 72.transform;
            val_22.SetParent(p:  this.丝且与丝丒丟万丁专 + 32.transform);
            UnityEngine.Vector3 val_25 = this.丝且与丝丒丟万丁专 + 56.transform.localPosition;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  0.01f);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_22.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
            val_63 = val_29.x;
            val_64 = val_29.z;
            val_22.localScale = new UnityEngine.Vector3() {x = val_63, y = val_29.y, z = val_64};
            this.丝且与丝丒丟万丁专 + 72.丈丛丘丟丟丛丈下丆(丗与丟上上丑专世丗:  mem[16].丙丕丁丅丁与丗丑丘());
        }
        
        }
        
        val_61 = null;
        val_54 = 1152921537532065728;
        val_61 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::丄丙世东丏丛丞七三());
        System.Func<System.Single> val_32 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::丛丌丙世丑丞丂丙东());
        new BotHpIndicator.不且丅丙上丕与丂下() = new BotHpIndicator.不且丅丙上丕与丂下(丑丆三丑丒丌丌丁丟:  null, 不丛丄丕丑专三七业:  null);
        if(val_50 == 0)
        {
            goto label_69;
        }
        
        mem2[0] = new BotHpIndicator.不且丅丙上丕与丂下();
        this.下丏三丞丝丘七七专 = true;
        goto label_70;
        label_34:
        val_61 = null;
        val_61 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::丙丏丗丝丝世不三丕());
        val_60 = val_50;
        System.Func<System.Single> val_35 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::且丐专世不且世丗一());
        val_54 = new BotHpIndicator.不且丅丙上丕与丂下();
        val_54 = new BotHpIndicator.不且丅丙上丕与丂下(丑丆三丑丒丌丌丁丟:  null, 不丛丄丕丑专三七业:  null);
        if(val_60 != 0)
        {
            goto label_73;
        }
        
        goto label_73;
        label_43:
        val_61 = null;
        val_61 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::丏丆丙丞与专丝丒丄());
        System.Func<System.Single> val_38 = new System.Func<System.Single>(object:  new BotHpIndicator.丈业丗丞丁七下一不(), method:  System.Single BotHpIndicator.丈业丗丞丁七下一不::三且丙丗丐万丑丐丛());
        val_54 = new BotHpIndicator.不且丅丙上丕与丂下();
        val_54 = new BotHpIndicator.不且丅丙上丕与丂下(丑丆三丑丒丌丌丁丟:  null, 不丛丄丕丑专三七业:  null);
        label_73:
        val_50 = 0;
        val_62 = 0;
        mem2[0] = val_54;
        label_47:
        this.下丏三丞丝丘七七专 = true;
        if(val_4 != null)
        {
            goto label_92;
        }
        
        goto label_167;
        label_69:
        mem[64] = new BotHpIndicator.不且丅丙上丕与丂下();
        this.下丏三丞丝丘七七专 = true;
        label_70:
        UnityEngine.GameObject val_41 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丝且与丝丒丟万丁专 + 104));
        mem2[0] = val_41;
        if(val_41 != 0)
        {
                UnityEngine.Transform val_43 = this.丝且与丝丒丟万丁专 + 88.transform;
            val_43.SetParent(p:  this.丝且与丝丒丟万丁专 + 32.transform);
            val_61 = this.丝且与丝丒丟万丁专 + 56.transform;
            UnityEngine.Vector3 val_46 = val_61.localPosition;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, d:  0.1f);
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, b:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
            val_43.localPosition = new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z};
            UnityEngine.Quaternion val_50 = UnityEngine.Quaternion.identity;
            val_43.localRotation = new UnityEngine.Quaternion() {x = val_50.x, y = val_50.y, z = val_50.z, w = val_50.w};
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.one;
            val_63 = val_51.x;
            val_64 = val_51.z;
            val_43.localScale = new UnityEngine.Vector3() {x = val_63, y = val_51.y, z = val_64};
            this.丝且与丝丒丟万丁专 + 88.SetActive(value:  false);
        }
        
        label_78:
        val_50 = 0;
        val_62 = 0;
        if(val_4 != null)
        {
            goto label_92;
        }
        
        goto label_167;
        label_92:
        var val_56 = 0;
        val_56 = val_56 + 1;
        val_4.Dispose();
        label_167:
        if( == 1)
        {
            goto label_172;
        }
        
        if(( == 0) || (681 == 681))
        {
            goto label_176;
        }
        
        label_175:
        label_176:
        val_52 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_52;
        return (bool)val_52;
        label_172:
        if( != 0)
        {
            goto label_175;
        }
        
        goto label_176;
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
