using UnityEngine;
private sealed class ShopNGUIController.丈丁丑万丂专且丏丆
{
    // Fields
    public ShopNGUIController 丝且与丝丒丟万丁专;
    public CategoryNames 专下丅万丁丒丕丂七;
    public bool 不丟丞丑丛丆丁东与;
    
    // Methods
    public ShopNGUIController.丈丁丑万丂专且丏丆()
    {
    
    }
    internal void 丆不且丙丕丝一丈丝(string 下丅丙一丂丗丅丝七)
    {
        this.丝且与丝丒丟万丁专.三上丅丕上丈丐且丁(丒东业不丐丑丕丄丆:  下丅丙一丂丗丅丝七);
    }
    internal void 且丈丝万一与丗丅丂(string 下丅丙一丂丗丅丝七)
    {
        string val_7;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.专下丅万丁丒丕丂七)) != false)
        {
                ShopNGUIController.三丟不东丆万七三与(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        
        .丏丆下丐丙丕万世世 = System.String.alignConst;
        if(this.不丟丞丑丛丆丁东与 != false)
        {
                var val_4 = ((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  this.专下丅万丁丒丕丂七)) != true) ? "Key_2991" : "Key_2992";
        }
        else
        {
                val_7 = "Key_0445";
        }
        
        .丏丆下丐丙丕万世世 = val_7;
        this.丝且与丝丒丟万丁专.purchaseSuccessfulLabels.ForEach(action:  new System.Action<UILabel>(object:  new ShopNGUIController.丞丈丑不丙丒三丅丕(), method:  System.Void ShopNGUIController.丞丈丑不丙丒三丅丕::丒丒三丆一七一一下(UILabel 七丐丞丑丑丕世丙七)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.purchaseSuccessful, 丏业丟一东丂东丘丛:  true);
        this.丝且与丝丒丟万丁专.丙丘丙丆万丘上丘丌 = UnityEngine.Time.realtimeSinceStartup;
    }

}
