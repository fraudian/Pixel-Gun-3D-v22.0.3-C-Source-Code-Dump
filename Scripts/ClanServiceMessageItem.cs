using UnityEngine;
public class ClanServiceMessageItem : AbstractMessageItem
{
    // Fields
    private bool 不丝丈丒丒丝与丑不;
    public UnityEngine.GameObject parentObject;
    public UISprite background;
    public UILabel executorNick;
    public UILabel targetNick;
    public UILabel messageLabel;
    public UILabel timeLabel;
    public UIWidget widget;
    public UnityEngine.GameObject yourFonSprite;
    public UILabel yourMessageLabel;
    public UILabel yourTimeLabel;
    public UISprite yourSmileSprite;
    public UIWidget yourWidget;
    public UnityEngine.GameObject otherFonSprite;
    public UILabel otherMessageLabel;
    public UILabel otherTimeLabel;
    public UISprite otherSmileSprite;
    public UIWidget otherWidget;
    
    // Methods
    private void Awake()
    {
        mem[1152921525734364608] = this.transform;
    }
    private void Start()
    {
        if(parent == 0)
        {
                return;
        }
        
        mem[1152921525734501176] = this.transform.parent.parent.GetComponent<UIPanel>();
    }
    private void 丞不丏三七万专丞业(bool 丛丅丘一丏丙且丌上)
    {
        bool val_1 = 丛丅丘一丏丙且丌上;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.parentObject, 丏业丟一东丂东丘丛:  val_1);
        this.不丝丈丒丒丝与丑不 = val_1;
    }
    private void 丐丈丙丄下丂丂丏丈(bool 丛丅丘一丏丙且丌上)
    {
        丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.yourFonSprite, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
    }
    private void 东专丅丐丟丞七万丂(bool 丛丅丘一丏丙且丌上)
    {
        丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.otherFonSprite, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
    }
    public void SetServiceMessage()
    {
        this.丞不丏三七万专丞业(丛丅丘一丏丙且丌上:  true);
        this.丐丈丙丄下丂丂丏丈(丛丅丘一丏丙且丌上:  false);
        this.东专丅丐丟丞七万丂(丛丅丘一丏丙且丌上:  false);
    }
    public void SetMyMessage()
    {
        this.丞不丏三七万专丞业(丛丅丘一丏丙且丌上:  false);
        this.丐丈丙丄下丂丂丏丈(丛丅丘一丏丙且丌上:  true);
        this.东专丅丐丟丞七万丂(丛丅丘一丏丙且丌上:  false);
    }
    public void SetOtherMessage()
    {
        this.丞不丏三七万专丞业(丛丅丘一丏丙且丌上:  false);
        this.丐丈丙丄下丂丂丏丈(丛丅丘一丏丙且丌上:  false);
        this.东专丅丐丟丞七万丂(丛丅丘一丏丙且丌上:  true);
    }
    public override void SetFon(bool 丌且下丕下下丌万丞)
    {
        if(this.不丝丈丒丒丝与丑不 != false)
        {
                return;
        }
        
        this.yourWidget.transform.parent.gameObject.SetActive(value:  丌且下丕下下丌万丞);
        this.otherWidget.transform.parent.gameObject.SetActive(value:  (~丌且下丕下下丌万丞) & 1);
    }
    public override void SetBackground(东业专世丟不专不丕.丏丙丘丕丙且上不东 七丐丅专且专七三丆)
    {
        if(this.不丝丈丒丒丝与丑不 == false)
        {
                return;
        }
        
        this.widget.transform.parent.gameObject.SetActive(value:  true);
        if((七丐丅专且专七三丆 - 1) <= 16)
        {
                var val_6 = 106033052 + ((七丐丅专且专七三丆 - 1)) << 2;
            val_6 = val_6 + 106033052;
        }
        else
        {
                UnityEngine.Color val_5 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "005BA178");
            this.background.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        }
    
    }
    public override void SetWidth(int 业与三万七丝不万东)
    {
        this.widget.width = 业与三万七丝不万东;
        this.otherWidget.width = 业与三万七丝不万东;
        this.yourWidget.width = 业与三万七丝不万东;
    }
    private void Update()
    {
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        System.Collections.Generic.List<东业专世丟不专不丕> val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        if(true != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = localPosition;
        val_24 = val_1.y;
        UnityEngine.Vector2 val_2 = clipOffset;
        UnityEngine.Vector4 val_3 = baseClipRegion;
        UnityEngine.Vector4 val_4 = baseClipRegion;
        float val_24 = -0.5f;
        val_24 = val_3.w * val_24;
        val_24 = val_2.y + val_24;
        val_24 = val_24 + val_4.y;
        if(val_24 < val_24)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = localPosition;
        val_24 = val_5.y;
        UnityEngine.Vector2 val_6 = clipOffset;
        UnityEngine.Vector4 val_7 = baseClipRegion;
        UnityEngine.Vector4 val_8 = baseClipRegion;
        float val_25 = 0.5f;
        val_25 = val_7.w * val_25;
        val_25 = val_6.y + val_25;
        val_25 = val_25 + val_8.y;
        if(val_24 > val_25)
        {
                return;
        }
        
        if(this.不丝丈丒丒丝与丑不 == false)
        {
            goto label_12;
        }
        
        val_25 = 1152921525656054080;
        val_26 = 1152921525657072960;
        val_27 = 0;
        goto label_13;
        label_30:
        val_28 = null;
        val_28 = null;
        string val_26 = ChatController.下丗不丒世丑丁丒专.Item[0];
        val_26 = val_26 + 16;
        if((val_26.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture).Equals(value:  val_26)) == false)
        {
            goto label_21;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = ChatController.下丗不丒世丑丁丒专.Item[0];
        if(val_13.丞丛业丆三七且丄下 == false)
        {
            goto label_26;
        }
        
        label_21:
        val_27 = 1;
        label_13:
        val_31 = null;
        val_31 = null;
        val_32 = ChatController.下丗不丒世丑丁丒专;
        if(val_27 < val_32.Count)
        {
            goto label_30;
        }
        
        return;
        label_12:
        val_25 = 1152921525653313184;
        val_26 = 1152921525653314208;
        val_33 = 0;
        goto label_32;
        label_49:
        val_34 = null;
        val_34 = null;
        string val_27 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        val_27 = val_27 + 16;
        if((val_27.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture).Equals(value:  val_27)) == false)
        {
            goto label_40;
        }
        
        val_35 = null;
        val_35 = null;
        val_30 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        if(val_19.丑丈专丙丛专丁与一 == false)
        {
            goto label_45;
        }
        
        label_40:
        val_33 = 1;
        label_32:
        val_36 = null;
        val_36 = null;
        val_32 = ChatController.丑丈万一下丗丘丄丘;
        if(val_33 < val_32.Count)
        {
            goto label_49;
        }
        
        return;
        label_26:
        mem[1152921525735855112] = 1;
        val_37 = null;
        val_37 = null;
        val_38 = ChatController.下丗不丒世丑丁丒专.Item[0];
        val_21.丞丛业丆三七且丄下 = true;
        goto label_54;
        label_45:
        mem[1152921525735855112] = 1;
        val_39 = null;
        val_39 = null;
        val_38 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        val_22.丑丈专丙丛专丁与一 = true;
        int val_23 = ChatController.丗丟三丙丆丝三万丂();
        val_23 = val_23 - 1;
        ChatController.不与丒东丐丄丞下丁(丙业与丙丗丝不丈东:  val_23);
        label_54:
        ChatController.下七丆丈且丝丝丈一();
    }
    public ClanServiceMessageItem()
    {
    
    }

}
