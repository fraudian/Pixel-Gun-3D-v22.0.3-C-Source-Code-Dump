using UnityEngine;
internal sealed class 丐专与丙丛丞万丗丞 : 丛且丘丘万丐世专丆
{
    // Fields
    private int 丌丝不丕上丑丅丟丛;
    
    // Methods
    public override 下丘丞丁丛七一万三 丙丁丈七丟丗三丄丗(System.Collections.Generic.List<string> 三上不丘与丟丞三丈)
    {
        下丘丞丁丛七一万三 val_0;
        val_0.丑与丂丌世丕丆一丗 = 0;
        val_0.丑丞丈丗丄丙丟万丄.b = 0;
        val_0.丑丞丈丗丄丙丟万丄.a = 0f;
        val_0.东丏丂丙丑丁丞丞万 = false;
        mem[1152921539966187385] = 0;
        return val_0;
    }
    public override 下丘丞丁丛七一万三 丙丁丈七丟丗三丄丗(System.Collections.Generic.List<string> 三上不丘与丟丞三丈, bool 不与万丌一丈下丑丈)
    {
        下丘丞丁丛七一万三 val_0;
        val_0.丑与丂丌世丕丆一丗 = 0;
        val_0.丑丞丈丗丄丙丟万丄.b = 0;
        val_0.丑丞丈丗丄丙丟万丄.a = 0f;
        val_0.东丏丂丙丑丁丞丞万 = false;
        mem[1152921539966323769] = 0;
        return val_0;
    }
    private 下丘丞丁丛七一万三 丏丁丟不七三一丆丁(下丘丞丁丛七一万三 丑与丂丌世丕丆一丗)
    {
        UnityEngine.Object val_19;
        var val_20;
        UnityEngine.GameObject[] val_21;
        float val_22;
        string val_23;
        string val_24;
        下丘丞丁丛七一万三 val_0;
        val_19 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_3;
        }
        
        val_20 = "";
        UnityEngine.GameObject[] val_2 = InGameGUI.丙丞专丌丁丞与不丐.hidingElems + ((this.丌丝不丕上丑丅丟丛) << 3);
        val_21 = UnityEngine.Object.op_Implicit(exists:  mem[(InGameGUI.丙丞专丌丁丞与不丐.hidingElems + (this.丌丝不丕上丑丅丟丛) << 3) + 32].GetComponent<UIPanel>());
        UnityEngine.GameObject[] val_5 = InGameGUI.丙丞专丌丁丞与不丐.hidingElems + ((this.丌丝不丕上丑丅丟丛) << 3);
        if((mem[(InGameGUI.丙丞专丌丁丞与不丐.hidingElems + (this.丌丝不丕上丑丅丟丛) << 3) + 32]) == 0)
        {
            goto label_13;
        }
        
        if(val_21 == false)
        {
            goto label_14;
        }
        
        label_21:
        val_19 = mem[(InGameGUI.丙丞专丌丁丞与不丐.hidingElems + (this.丌丝不丕上丑丅丟丛) << 3) + 32].GetComponent<UIPanel>();
        if(val_19 == 0)
        {
            goto label_17;
        }
        
        val_22 = 1f;
        var val_8 = (S0 == val_22) ? "Включена" : "Выключена";
        goto label_33;
        label_3:
        UnityEngine.Color val_9 = UnityEngine.Color.red;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.r = val_9.r;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.g = val_9.g;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.b = val_9.b;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.a = val_9.a;
        val_24 = "Нету игрового интерфейса";
        丑与丂丌世丕丆一丗.东丏丂丙丑丁丞丞万 = false;
        丑与丂丌世丕丆一丗.丑与丂丌世丕丆一丗 = val_24;
        goto label_20;
        label_13:
        if(val_21 == true)
        {
            goto label_21;
        }
        
        label_14:
        bool val_11 = UnityEngine.Object.op_Implicit(exists:  mem[(InGameGUI.丙丞专丌丁丞与不丐.hidingElems + (this.丌丝不丕上丑丅丟丛) << 3) + 32].GetComponent<TouchButton>());
        val_21 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 992];
        val_21 = InGameGUI.丙丞专丌丁丞与不丐.hidingElems;
        UnityEngine.GameObject[] val_12 = val_21 + ((this.丌丝不丕上丑丅丟丛) << 3);
        val_19 = mem[(InGameGUI.丙丞专丌丁丞与不丐.hidingElems + (this.丌丝不丕上丑丅丟丛) << 3) + 32];
        if(val_19 == 0)
        {
            goto label_27;
        }
        
        if(val_11 == false)
        {
            goto label_28;
        }
        
        label_32:
        val_19 = val_19.GetComponent<UISprite>();
        val_22 = 1f;
        if(val_19.alpha != val_22)
        {
            goto label_30;
        }
        
        val_23 = "Включена";
        goto label_33;
        label_27:
        if(val_11 == true)
        {
            goto label_32;
        }
        
        label_28:
        var val_16 = (val_19.activeSelf != true) ? "Включена" : "Выключена";
        goto label_33;
        label_30:
        val_23 = "Выключена";
        label_33:
        label_17:
        UnityEngine.Color val_17 = UnityEngine.Color.green;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.r = val_17.r;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.g = val_17.g;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.b = val_17.b;
        丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.a = val_17.a;
        val_24 = true;
        丑与丂丌世丕丆一丗.东丏丂丙丑丁丞丞万 = val_24;
        丑与丂丌世丕丆一丗.丑与丂丌世丕丆一丗 = "Панель оружия " + val_23;
        label_20:
        val_0.丑丞丈丗丄丙丟万丄.b = 丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.b;
        val_0.丑与丂丌世丕丆一丗 = 丑与丂丌世丕丆一丗.丑与丂丌世丕丆一丗;
        return val_0;
    }
    public override string 丆业丝不一丒丞且丝()
    {
        return "Core";
    }
    public override string 上丆业业丅上丙专七()
    {
        return "Video";
    }
    public override string 丛东下丌一丕丌一丁()
    {
        return "Панель оружия";
    }
    public 丐专与丙丛丞万丗丞()
    {
        this.丌丝不丕上丑丅丟丛 = 6;
    }

}
