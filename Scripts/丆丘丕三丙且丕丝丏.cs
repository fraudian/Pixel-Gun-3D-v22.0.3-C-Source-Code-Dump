using UnityEngine;
internal sealed class 丆丘丕三丙且丕丝丏 : 丛且丘丘万丐世专丆
{
    // Methods
    public override 下丘丞丁丛七一万三 丙丁丈七丟丗三丄丗(System.Collections.Generic.List<string> 三上不丘与丟丞三丈)
    {
        下丘丞丁丛七一万三 val_0;
        val_0.丑与丂丌世丕丆一丗 = 0;
        val_0.丑丞丈丗丄丙丟万丄.b = 0;
        val_0.丑丞丈丗丄丙丟万丄.a = 0f;
        val_0.东丏丂丙丑丁丞丞万 = false;
        mem[1152921539968906793] = 0;
        return val_0;
    }
    public override 下丘丞丁丛七一万三 丙丁丈七丟丗三丄丗(System.Collections.Generic.List<string> 三上不丘与丟丞三丈, bool 不与万丌一丈下丑丈)
    {
        下丘丞丁丛七一万三 val_0;
        val_0.丑与丂丌世丕丆一丗 = 0;
        val_0.丑丞丈丗丄丙丟万丄.b = 0;
        val_0.丑丞丈丗丄丙丟万丄.a = 0f;
        val_0.东丏丂丙丑丁丞丞万 = false;
        mem[1152921539969043177] = 0;
        return val_0;
    }
    private void 下不丁上不上世世丗(UnityEngine.GameObject 世丟不丕丙业东丗东, bool 丑丒业丘丑东丕世丅)
    {
        var val_11;
        UnityEngine.GameObject val_12;
        val_11 = 丑丒业丘丑东丕世丅;
        val_12 = 世丟不丕丙业东丗东;
        if((val_12.GetComponent<UIPanel>()) != 0)
        {
                var val_3 = (val_11 != true) ? 1f : 0.004f;
            val_12 = ???;
            val_11 = ???;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  val_11 & 1);
        }
    
    }
    private 下丘丞丁丛七一万三 丏丁丟不七三一丆丁(下丘丞丁丛七一万三 丑与丂丌世丕丆一丗)
    {
        InGameGUI val_7;
        bool val_8;
        下丘丞丁丛七一万三 val_0;
        val_7 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_7 != 0)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.green;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.r = val_2.r;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.g = val_2.g;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.b = val_2.b;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.a = val_2.a;
            val_7 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 1008];
            val_7 = InGameGUI.丙丞专丌丁丞与不丐.一丝万丂丏丏且万丌;
            val_8 = true;
            丑与丂丌世丕丆一丗.东丏丂丙丑丁丞丞万 = val_8;
            丑与丂丌世丕丆一丗.丑与丂丌世丕丆一丗 = "Верхний левый угол " + (Count > 0) ? "выключен" : "включен"((Count > 0) ? "выключен" : "включен");
        }
        else
        {
                UnityEngine.Color val_6 = UnityEngine.Color.red;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.r = val_6.r;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.g = val_6.g;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.b = val_6.b;
            丑与丂丌世丕丆一丗.丑丞丈丗丄丙丟万丄.a = val_6.a;
            val_8 = "Нету игрового интерфейса";
            丑与丂丌世丕丆一丗.东丏丂丙丑丁丞丞万 = false;
            丑与丂丌世丕丆一丗.丑与丂丌世丕丆一丗 = val_8;
        }
        
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
        return "Левая верхняя панель";
    }
    public 丆丘丕三丙且丕丝丏()
    {
    
    }

}
