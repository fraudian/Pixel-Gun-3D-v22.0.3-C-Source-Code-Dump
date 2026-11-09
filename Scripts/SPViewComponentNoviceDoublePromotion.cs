using UnityEngine;
internal sealed class SPViewComponentNoviceDoublePromotion : SPViewComponentBase
{
    // Fields
    private ItemListUI _itemList;
    private UILabel _discount;
    private UILabel _title;
    private UILabel _description;
    private UnityEngine.GameObject _viewButton;
    private UnityEngine.GameObject _purchased;
    private UnityEngine.GameObject _blockCollider;
    private UnityEngine.GameObject _tagNew;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UILabel val_20;
        PGCompany.丙一丟与且丞丏丈一 val_21;
        ItemListUI val_22;
        val_20 = this;
        string val_20 = "state.purchased";
        bool val_2 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_20);
        val_20 = (~val_2) & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._viewButton, 丏业丟一东丂东丘丛:  val_20);
        bool val_3 = val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchased, 丏业丟一东丂东丘丛:  val_3);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blockCollider, 丏业丟一东丂东丘丛:  val_3);
        string val_21 = "new";
        val_21 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_21);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tagNew, 丏业丟一东丂东丘丛:  val_21);
        if(且丘丏丁丑与丙与丁.七丈丒丒下下且万与() != null)
        {
                val_21 = 0;
        }
        
        val_22 = PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丟丌业丝丝丈一一下(丗丟丁丐与下丙丕丛:  PGCompany.且丝丑上丛丁丕东丕.上丑丕丅与丟上丘业(一丗与一专丙丙丅丄:  val_21));
        if(val_22 != null)
        {
                PGCompany.东丑丆丗丏丐丟下丄 val_13 = System.Linq.Enumerable.LastOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_22.与丐七上丝丛上下丁());
            if(val_13 == null)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._title, 丕丗丘丑丛与丑业丒:  val_22.世丁万丗三丈丑丅世());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._description, 丕丗丘丑丛与丑业丒:  val_22.丌丕且丒丞丂七丞一());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemList, 丏业丟一东丂东丘丛:  true);
            val_22 = this._itemList;
            val_22.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  PGCompany.万丞丘与丕丞下万丌.丄丆丛丙且丅丘七与(一丏七丐丏丐丞丏丙:  val_13).GetRange(index:  0, count:  2));
            val_20 = this._discount;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_20, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  val_13.丆丞上丛丂一业丟丕()));
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._viewButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blockCollider, 丏业丟一东丂东丘丛:  true);
    }
    public SPViewComponentNoviceDoublePromotion()
    {
        val_1 = new PGBehaviour();
    }

}
