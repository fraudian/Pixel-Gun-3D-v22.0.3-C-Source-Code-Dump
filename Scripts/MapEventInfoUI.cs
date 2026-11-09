using UnityEngine;
public class MapEventInfoUI : MonoBehaviour
{
    // Fields
    public UIWidget mainWidget;
    public MapEventModifItem[] modifItems;
    private int 丗丗万万七且丂不丌;
    private int 丏丗与三与三丄丙东;
    private int 丞丂业丗丄丄丄业丄;
    private int 专丕世丛丝丐丂丒万;
    private int 与七丒丁上丛丂丘丏;
    
    // Methods
    private void 丂丟丗丞丆丘与丕业(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一, float 丘上丑东丞东世丒七)
    {
        if(this.modifItems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.modifItems[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.modifItems[(long)丞世不丒下上上丝丑].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this = this.modifItems;
        this[(long)丞世不丒下上上丝丑].上东与丛丞下丈专丈(一丙上不丌丆三丗一:  一丙上不丌丆三丗一);
    }
    private void 丈三七专上丙丙业丗(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一, float 丘上丑东丞东世丒七, System.Collections.Generic.KeyValuePair<CategoryNames, float> 丙丑丕丂下丏一丁专)
    {
        MapEventModifItem[] val_3;
        MapEventModifItem val_4;
        val_3 = this.modifItems;
        val_4 = 丞世不丒下上上丝丑;
        if(this.modifItems.Length <= val_4)
        {
                return;
        }
        
        this.modifItems[(long)val_4].gameObject.SetActive(value:  true);
        val_3 = this.modifItems[(long)val_4].transform;
        val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_4 = this.modifItems[(long)val_4];
        val_4.七专丆世丆丑一丈丆(一丙上不丌丆三丗一:  一丙上不丌丆三丗一, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = 0f});
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        float val_8;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        MapEventModifItem[] val_19;
        val_15 = this.专丕世丛丝丐丂丒万;
        val_16 = 0;
        goto label_1;
        label_7:
        this.modifItems[0].gameObject.SetActive(value:  false);
        val_16 = 1;
        label_1:
        if(val_16 < this.modifItems.Length)
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_2 = 丐且丘丑与万丞丑丅.丑丛业丛东业且丒下();
        val_17 = 0;
        val_18 = 0;
        goto label_9;
        label_35:
        if(val_2.Count <= val_17)
        {
            goto label_28;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_4 = val_2.Item[0];
        if(val_4 == null)
        {
            goto label_28;
        }
        
        if(val_4.不业丙丒丂丞下丆丙() != 8)
        {
            goto label_14;
        }
        
        val_19 = val_4.丛丅下丆丗丏三丁丕<System.Collections.Generic.Dictionary<CategoryNames, System.Single>>(丒丑丂丐丕丒丕东与:  "custom");
        Dictionary.Enumerator<TKey, TValue> val_7 = val_19.GetEnumerator();
        goto label_16;
        label_21:
        string val_10 = val_8.丐丏七丌丕丗业且上();
        this.丈三七专上丙丙业丗(丞世不丒下上上丝丑:  0, 一丙上不丌丆三丗一:  val_4, 丘上丑东丞东世丒七:  (float)val_15, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = val_8});
        val_19 = this.modifItems;
        if(0 < this.modifItems.Length)
        {
                val_19 = this.modifItems;
            val_15 = this.丏丗与三与三丄丙东 + val_15;
            int val_15 = this.modifItems.Length;
            val_15 = val_15 - 1;
            if(0 < val_15)
        {
                val_15 = this.丞丂业丗丄丄丄业丄 + val_15;
        }
        
        }
        
        var val_18 = 1;
        label_16:
        if((510870192 & 1) != 0)
        {
            goto label_21;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1 == 1)
        {
            goto label_27;
        }
        
        var val_16 = 0;
        val_16 = val_16 ^ 0;
        val_18 = 1 + val_16;
        goto label_28;
        label_27:
        val_18 = 0;
        label_14:
        this.丂丟丗丞丆丘与丕业(丞世不丒下上上丝丑:  1, 一丙上不丌丆三丗一:  val_4, 丘上丑东丞东世丒七:  (float)val_15);
        if(val_18 < this.modifItems.Length)
        {
                val_15 = this.丏丗与三与三丄丙东 + val_15;
            int val_17 = this.modifItems.Length;
            val_17 = val_17 - 1;
            if(val_18 < val_17)
        {
                val_15 = this.丞丂业丗丄丄丄业丄 + val_15;
        }
        
        }
        
        val_18 = val_18 + 1;
        label_28:
        val_17 = 1;
        label_9:
        if(val_17 < val_2.Count)
        {
            goto label_35;
        }
        
        this.mainWidget.height = (this.与七丒丁上丛丂丘丏 + val_15) + this.丗丗万万七且丂不丌;
    }
    public MapEventInfoUI()
    {
        this.与七丒丁上丛丂丘丏 = 32;
        this.丗丗万万七且丂不丌 = ;
        this.丏丗与三与三丄丙东 = ;
        this.丞丂业丗丄丄丄业丄 = 94489280522;
        this.专丕世丛丝丐丂丒万 = 22;
    }

}
