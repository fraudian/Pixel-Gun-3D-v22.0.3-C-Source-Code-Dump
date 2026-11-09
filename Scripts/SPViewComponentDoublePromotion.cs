using UnityEngine;
internal sealed class SPViewComponentDoublePromotion : SPViewComponentBase
{
    // Fields
    private ItemListUI _itemList;
    private UILabel _discount;
    private UnityEngine.GameObject _viewButton;
    private UnityEngine.GameObject _purchased;
    private UnityEngine.GameObject _tagNew;
    private UILabel _titleLabel;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UILabel val_13;
        var val_14;
        val_13 = this;
        string val_13 = "state.purchased";
        bool val_2 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_13);
        val_13 = (~val_2) & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._viewButton, 丏业丟一东丂东丘丛:  val_13);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchased, 丏业丟一东丂东丘丛:  val_2);
        string val_14 = "new";
        val_14 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_14);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tagNew, 丏业丟一东丂东丘丛:  val_14);
        val_14 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世();
        PGCompany.不万丑丗丕与丐丒丏 val_7 = val_14.丙与丞上丅上且且业();
        if(val_7 == null)
        {
                return;
        }
        
        val_14 = System.Linq.Enumerable.LastOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_7.与丐七上丝丛上下丁());
        if(val_14 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemList, 丏业丟一东丂东丘丛:  true);
        this._itemList.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_14.GetRange(index:  0, count:  2));
        val_13 = this._discount;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_13, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  val_14.丆丞上丛丂一业丟丕()));
    }
    public SPViewComponentDoublePromotion()
    {
        val_1 = new PGBehaviour();
    }

}
