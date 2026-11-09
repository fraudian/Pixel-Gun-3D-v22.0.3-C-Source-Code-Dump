using UnityEngine;
public class InGameScoreContainerController : MonoBehaviour
{
    // Fields
    private UILabel placeLabel;
    private UnityEngine.GameObject firstPlaceMarker;
    private UnityEngine.GameObject winningBlue;
    private UnityEngine.GameObject winningRed;
    private bool 丝丑丒丐丒丏丑丝丆;
    private bool 下丗丒丛专丝丂与不;
    private bool 丘与丂丁上丆丂丁世;
    private System.Collections.Generic.KeyValuePair<int, string> 丛丗不丗丒万一三丌;
    
    // Methods
    private void Awake()
    {
        bool val_11;
        if(PolygonController.一下一万丄丅丘且丑 != 0)
        {
                if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
        {
            goto label_5;
        }
        
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() == 0)
        {
                label_5:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丝丑丒丐丒丏丑丝丆 = UnityEngine.Object.op_Inequality(x:  this.placeLabel, y:  0);
        this.下丗丒丛专丝丂与不 = UnityEngine.Object.op_Inequality(x:  this.firstPlaceMarker, y:  0);
        if(this.winningBlue != 0)
        {
                val_11 = UnityEngine.Object.op_Inequality(x:  this.winningRed, y:  0);
        }
        else
        {
                val_11 = false;
        }
        
        this.丘与丂丁上丆丂丁世 = val_11;
    }
    private void Update()
    {
        var val_12;
        var val_13;
        UILabel val_14;
        var val_15;
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        if(this.丝丑丒丐丒丏丑丝丆 != false)
        {
                val_13 = null;
            val_13 = null;
            int val_2 = 业七业丅丅丝万丕丝();
            val_14 = this.placeLabel;
            val_14.text = this.丌丘丁丁七丂东丞丏(专世专丟丝丌与丘上:  val_2);
            if(this.下丗丒丛专丝丂与不 != false)
        {
                val_14 = this.firstPlaceMarker;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  (val_2 == 0) ? 1 : 0);
        }
        
        }
        
        if(this.丘与丂丁上丆丂丁世 == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        int val_5 = 丒一不且丂下丅丗丂();
        int val_6 = 丘丑丅三丆丑丌且丝();
        var val_9 = (val_5 != 0) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.winningBlue, 丏业丟一东丂东丘丛:  val_9 & ((val_6 == val_5) ? 1 : 0));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.winningRed, 丏业丟一东丂东丘丛:  val_9 & ((val_6 != val_5) ? 1 : 0));
    }
    private string 丌丘丁丁七丂东丞丏(int 专世专丟丝丌与丘上)
    {
        if(this.丛丗不丗丒万一三丌.丙东专丂世丈丏丁丂() == 专世专丟丝丌与丘上)
        {
                return (string)this.丛丗不丗丒万一三丌;
        }
        
        string val_3 = 专世专丟丝丌与丘上 + 1.ToString();
        this.丛丗不丗丒万一三丌 = 0;
        mem[1152921538123252072] = 0;
        return (string)this.丛丗不丗丒万一三丌;
    }
    public InGameScoreContainerController()
    {
        this.丛丗不丗丒万一三丌 = 0;
        mem[1152921538123368168] = 0;
    }

}
