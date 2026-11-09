using UnityEngine;
public class MapEventModifItem : MonoBehaviour
{
    // Fields
    public UILabel description;
    public UnityEngine.GameObject n1Icons;
    public UnityEngine.GameObject n2Icons;
    public UnityEngine.GameObject n3Icons;
    public UISprite n1_icon;
    public UISprite[] n2_icons;
    public UISprite[] n3_icons;
    public UILabel multiplierLabel;
    public UnityEngine.GameObject multiplier;
    private int 三丂丙不一丝不专一;
    
    // Methods
    private void 丐丛不丟万丐一丁东(int 丌丒丝东丌下丕丁丅)
    {
        UnityEngine.GameObject val_7;
        if(this.n1Icons != 0)
        {
                this.n1Icons.SetActive(value:  (丌丒丝东丌下丕丁丅 == 1) ? 1 : 0);
        }
        
        if(this.n2Icons != 0)
        {
                this.n2Icons.SetActive(value:  (丌丒丝东丌下丕丁丅 == 2) ? 1 : 0);
        }
        
        val_7 = this.n3Icons;
        if(val_7 != 0)
        {
                val_7 = this.n3Icons;
            val_7.SetActive(value:  (丌丒丝东丌下丕丁丅 == 3) ? 1 : 0);
        }
        
        this.三丂丙不一丝不专一 = 丌丒丝东丌下丕丁丅;
    }
    private void 丞业与下丛万丁下丙(int 丞世不丒下上上丝丑, string 万丑丞一丝丌丐丒丘)
    {
        if(this.三丂丙不一丝不专一 == 2)
        {
            goto label_0;
        }
        
        if(this.三丂丙不一丝不专一 != 3)
        {
            goto label_1;
        }
        
        if(this.n3_icons != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        UISprite val_1 = this.n3_icons[(long)丞世不丒下上上丝丑];
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        val_1.spriteName = 万丑丞一丝丌丐丒丘;
        return;
        label_0:
        if(this.n2_icons != null)
        {
            goto label_5;
        }
        
        goto label_6;
        label_1:
        if(this.n1_icon != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    internal void 七专丆世丆丑一丈丆(PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一, System.Collections.Generic.KeyValuePair<CategoryNames, float> 丙丑丕丂下丏一丁专)
    {
        UILabel val_13;
        var val_14;
        var val_15;
        UILabel val_16;
        var val_17;
        val_13 = this;
        this.丐丛不丟万丐一丁东(丌丒丝东丌下丕丁丅:  1);
        val_14 = null;
        val_14 = null;
        string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[???.丙东专丂世丈丏丁丂()]);
        val_15 = null;
        val_15 = null;
        int val_4 = ???.丙东专丂世丈丏丁丂();
        System.String[] val_5 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.与丘丁丑业丛丘丙丗 + (((long)(int)(val_4)) << 3);
        this.丞业与下丛万丁下丙(丞世不丒下上上丝丑:  0, 万丑丞一丝丌丐丒丘:  (PGCompany.GameModeEvents.下丑一丈与丝与丐丛.与丘丁丑业丛丘丙丗 + ((long)(int)(val_4)) << 3) + 32);
        this.multiplier.SetActive(value:  true);
        this.multiplierLabel.text = System.String.Format(format:  "x{0}", arg0:  丙丑丕丂下丏一丁专.Value);
        val_16 = this.description;
        if(val_16 == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[???.丙东专丂世丈丏丁丂()]);
        val_13 = this.description;
        val_13.text = System.String.Format(format:  一丙上不丌丆三丗一.东且丏丆万与东丙万(), arg0:  val_16);
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一)
    {
        var val_20;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_21;
        var val_22;
        string val_23;
        int val_24;
        var val_25;
        var val_26;
        string val_27;
        var val_28;
        string val_29;
        val_21 = 一丙上不丌丆三丗一;
        val_22 = this;
        val_23 = val_21.东且丏丆万与东丙万();
        val_24 = System.String.alignConst;
        if(val_21.不业丙丒丂丞下丆丙() != 7)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<CategoryNames> val_3 = val_21.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
        int val_4 = val_3.Count;
        val_20 = val_22;
        this.丐丛不丟万丐一丁东(丌丒丝东丌下丕丁丅:  UnityEngine.Mathf.Min(a:  3, b:  val_4));
        val_25 = 1;
        goto label_8;
        label_24:
        val_26 = null;
        val_26 = null;
        val_27 = 上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[val_3.Item[val_4]];
        val_24 = val_24 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27));
        if(val_25 < val_3.Count)
        {
                val_24 = val_24 + ", ";
        }
        
        if(val_4 < 3)
        {
                val_28 = null;
            val_28 = null;
            val_27 = (long)val_3.Item[val_4];
            System.String[] val_13 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.与丘丁丑业丛丘丙丗 + (((long)(int)(val_12)) << 3);
            this.丞业与下丛万丁下丙(丞世不丒下上上丝丑:  val_4, 万丑丞一丝丌丐丒丘:  (PGCompany.GameModeEvents.下丑一丈与丝与丐丛.与丘丁丑业丛丘丙丗 + ((long)(int)(val_12)) << 3) + 32);
        }
        
        val_25 = 2;
        label_8:
        if((val_25 - 1) < val_3.Count)
        {
            goto label_24;
        }
        
        val_23 = val_23;
        val_21 = val_21;
        val_22 = val_20;
        goto label_25;
        label_3:
        this.丐丛不丟万丐一丁东(丌丒丝东丌下丕丁丅:  1);
        this.丞业与下丛万丁下丙(丞世不丒下上上丝丑:  0, 万丑丞一丝丌丐丒丘:  val_21.丆丂丙丞一丛丞丄丘());
        label_25:
        this.multiplier.SetActive(value:  false);
        if(this.description == 0)
        {
                return;
        }
        
        if(val_21.不业丙丒丂丞下丆丙() == 7)
        {
                val_29 = System.String.Format(format:  val_23, arg0:  System.String.Format(format:  "[ffc901]{0}[-]", arg0:  val_24));
        }
        else
        {
                val_29 = val_23;
        }
        
        this.description.text = val_29;
    }
    public MapEventModifItem()
    {
    
    }

}
