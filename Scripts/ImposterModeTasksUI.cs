using UnityEngine;
public sealed class ImposterModeTasksUI : PGBehaviour
{
    // Fields
    private int 丂丅丆业且丏丏丞且;
    private System.Collections.Generic.List<PlayerTaskUI> taskLabels;
    private System.Collections.Generic.List<PlayerTaskUI> 万丙东且七丄下业丌;
    private readonly string 专丐丟丒万东七丟三;
    private readonly string 丝丞万丐七丛丅丒丑;
    private UnityEngine.Color imposterColor;
    private UnityEngine.Color crewmanColor;
    private UnityEngine.Color sabotageColor;
    private WidgetLayout _widgetLayout;
    internal TasksToggleUI tasksToggleUI;
    
    // Methods
    internal void 丁东世丌丑且丞丕世(string 丙丑上且且丝三丛不)
    {
        PlayerTaskUI val_1 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        val_1.taskLabel.text = 丙丑上且且丝三丛不;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskLabels.Item[this.丂丅丆业且丏丏丞且], 丏业丟一东丂东丘丛:  true);
        PlayerTaskUI val_3 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.timerLabel, 丏业丟一东丂东丘丛:  false);
        int val_4 = this.丂丅丆业且丏丏丞且;
        val_4 = val_4 + 1;
        this.丂丅丆业且丏丏丞且 = val_4;
        this.万丌丏丘丑不且丐万();
    }
    internal void 丙丌丏丈丛万七丂丅()
    {
        PlayerTaskUI val_1 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        val_1.taskLabel.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.专丐丟丒万东七丟三);
        PlayerTaskUI val_3 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_3.taskLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.imposterColor, g = V9.16B, b = V10.16B, a = V8.16B});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskLabels.Item[this.丂丅丆业且丏丏丞且], 丏业丟一东丂东丘丛:  true);
        PlayerTaskUI val_5 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5.timerLabel, 丏业丟一东丂东丘丛:  false);
        int val_6 = this.丂丅丆业且丏丏丞且;
        val_6 = val_6 + 1;
        this.丂丅丆业且丏丏丞且 = val_6;
        this.万丌丏丘丑不且丐万();
    }
    internal void 丄丌丕东丒三丑七丙()
    {
        PlayerTaskUI val_1 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        val_1.taskLabel.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丝丞万丐七丛丅丒丑);
        PlayerTaskUI val_3 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_3.taskLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.crewmanColor, g = V9.16B, b = V10.16B, a = V8.16B});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskLabels.Item[this.丂丅丆业且丏丏丞且], 丏业丟一东丂东丘丛:  true);
        PlayerTaskUI val_5 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5.timerLabel, 丏业丟一东丂东丘丛:  false);
        int val_6 = this.丂丅丆业且丏丏丞且;
        val_6 = val_6 + 1;
        this.丂丅丆业且丏丏丞且 = val_6;
        this.万丌丏丘丑不且丐万();
    }
    internal void 丑丟丒一东与与一丆(string 丞上丛丑丕万丕丑丗, int 丑丟丞丗丂丌且一丆, int 丐七丟丘专丅万丂世, int 丞丁不丗丙丌三丝丙)
    {
        PlayerTaskUI val_1 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        val_1.taskLabel.text = System.String.Format(format:  丞上丛丑丕万丕丑丗, arg0:  丐七丟丘专丅万丂世, arg1:  丞丁不丗丙丌三丝丙);
        PlayerTaskUI val_3 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        val_3.timerLabel.text = 丑丟丞丗丂丌且一丆.ToString();
        PlayerTaskUI val_5 = this.taskLabels.Item[this.丂丅丆业且丏丏丞且];
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_5.taskLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.sabotageColor, g = V9.16B, b = V10.16B, a = V8.16B});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskLabels.Item[this.丂丅丆业且丏丏丞且], 丏业丟一东丂东丘丛:  true);
        this.万丌丏丘丑不且丐万();
    }
    internal void 丒丌丆丁丞七万丟丘()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskLabels.Item[this.丂丅丆业且丏丏丞且], 丏业丟一东丂东丘丛:  false);
        this.万丌丏丘丑不且丐万();
    }
    internal void 三丅丄不丂丝丕丐与(int 三专三丐丁世丑丁丅)
    {
        System.Collections.Generic.List<PlayerTaskUI> val_7;
        if((三专三丐丁世丑丁丅 & 2147483648) != 0)
        {
                return;
        }
        
        val_7 = this.taskLabels;
        if(val_7.Count <= 三专三丐丁世丑丁丅)
        {
                return;
        }
        
        this.万丙东且七丄下业丌.Add(item:  this.taskLabels.Item[三专三丐丁世丑丁丅]);
        PlayerTaskUI val_3 = this.taskLabels.Item[三专三丐丁世丑丁丅];
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_3.taskLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        PlayerTaskUI val_4 = this.taskLabels.Item[三专三丐丁世丑丁丅];
        UnityEngine.Color val_5 = val_4.backgroundSprite.color;
        val_7 = this.taskLabels;
        PlayerTaskUI val_6 = val_7.Item[三专三丐丁世丑丁丅];
        val_6.backgroundSprite.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.万丌丏丘丑不且丐万();
    }
    private void 万丌丏丘丑不且丐万()
    {
        this._widgetLayout.万万丘丙丗丈丘丙丁(业丁一且丄丂丗七丈:  new System.Func<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Int32 ImposterModeTasksUI::丈丕世丞丁丘丞丕丐(UnityEngine.GameObject 三丟东丕丄丄下下丑)));
        this._widgetLayout.Reposition();
    }
    public ImposterModeTasksUI()
    {
        this.万丙东且七丄下业丌 = new System.Collections.Generic.List<PlayerTaskUI>();
        this.专丐丟丒万东七丟三 = "Key_10068";
        this.丝丞万丐七丛丅丒丑 = "Key_10066";
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        this.imposterColor = val_2;
        mem[1152921537571451780] = val_2.g;
        mem[1152921537571451784] = val_2.b;
        mem[1152921537571451788] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.green;
        this.crewmanColor = val_3;
        mem[1152921537571451796] = val_3.g;
        mem[1152921537571451800] = val_3.b;
        mem[1152921537571451804] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color.yellow;
        this.sabotageColor = val_4;
        mem[1152921537571451812] = val_4.g;
        mem[1152921537571451816] = val_4.b;
        mem[1152921537571451820] = val_4.a;
    }
    private int 丈丕世丞丁丘丞丕丐(UnityEngine.GameObject 三丟东丕丄丄下下丑)
    {
        System.Collections.Generic.List<PlayerTaskUI> val_8;
        var val_9;
        val_8 = this;
        ImposterModeTasksUI.丞丆丌万丛不且七丐 val_1 = new ImposterModeTasksUI.丞丆丌万丛不且七丐();
        .三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        int val_3 = this.taskLabels.FindIndex(match:  new System.Predicate<PlayerTaskUI>(object:  val_1, method:  System.Boolean ImposterModeTasksUI.丞丆丌万丛不且七丐::丕三丁丛三下一丄丂(PlayerTaskUI 丒丒丄丁且丄丆丂丌)));
        if((val_3 & 2147483648) == 0)
        {
                val_8 = this.万丙东且七丄下业丌;
            var val_7 = ((val_8.FindIndex(match:  new System.Predicate<PlayerTaskUI>(object:  val_1, method:  System.Boolean ImposterModeTasksUI.丞丆丌万丛不且七丐::一业丝丕世丕丞丌丛(PlayerTaskUI 丒丒丄丁且丄丆丂丌)))) >= 0) ? (val_3 + 100) : (val_3);
            return (int)val_9;
        }
        
        val_9 = val_3;
        return (int)val_9;
    }

}
