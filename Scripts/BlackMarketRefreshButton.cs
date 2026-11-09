using UnityEngine;
internal sealed class BlackMarketRefreshButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject state_None;
    private UnityEngine.GameObject state_Free;
    private UnityEngine.GameObject state_Paid;
    private BuyButtonUI buyButtonUI;
    private UILabel freeCount;
    private BlackMarketRefreshButton.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    private BlackMarketRefreshButton.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        this.不东丈丕不丝一东丙();
        if(this.且上丘丄丘业丐丅业 == 2)
        {
            goto label_1;
        }
        
        if(this.且上丘丄丘业丐丅业 == 1)
        {
            goto label_2;
        }
        
        if(this.且上丘丄丘业丐丅业 != 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_None, 丏业丟一东丂东丘丛:  true);
        return;
        label_1:
        this.上丙丟丗丅丌丁不上();
        return;
        label_2:
        this.且丞丆七丁丐业与下();
    }
    private BlackMarketRefreshButton.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        if(PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().不下上三专丟丅一与() == null)
        {
                return (丙丙世七丆丝七丗丐)(PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().不下上三专丟丅一与().业东丅东丌上丗丑不() != 11015) ? (1 + 1) : 1;
        }
        
        return (丙丙世七丆丝七丗丐)(PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().不下上三专丟丅一与().业东丅东丌上丗丑不() != 11015) ? (1 + 1) : 1;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_None, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Free, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Paid, 丏业丟一东丂东丘丛:  false);
    }
    private void 且丞丆七丁丐业与下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Free, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.freeCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9134"), arg0:  PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().丄上丅与丟丅丈不丂()));
    }
    private void 上丙丟丗丅丌丁不上()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Paid, 丏业丟一东丂东丘丛:  true);
        this.buyButtonUI.Setup(丒世丘丘上丆丝东丞:  PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().不下上三专丟丅一与());
    }
    public BlackMarketRefreshButton()
    {
    
    }

}
