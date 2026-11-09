using UnityEngine;
internal sealed class PlayerScoreUi : PGBehaviour
{
    // Fields
    private UIWidget _widget;
    private UILabel _placeLabel;
    private UILabel _nickLabel;
    private UILabel _scoreLabel;
    private UnityEngine.GameObject _defaultBgGo;
    private UnityEngine.GameObject _myPlayerBgGo;
    internal bool 上世丄不丐丁丟丅丒;
    
    // Methods
    internal int 丝丌且丄不世三业上()
    {
        UIWidget val_3;
        if(this._widget == 0)
        {
                val_3 = this.GetComponent<UIWidget>();
            this._widget = val_3;
            if(val_3 != null)
        {
                return val_3.height;
        }
        
            return val_3.height;
        }
        
        val_3 = this._widget;
        if(val_3 != null)
        {
                return val_3.height;
        }
        
        return val_3.height;
    }
    internal void 丂下不丘丑与业东与(string 不丆业丏上丐与丌业)
    {
        if(this._nickLabel == 0)
        {
                return;
        }
        
        this._nickLabel.text = 不丆业丏上丐与丌业;
    }
    internal void 丈且东丑丂且万丒丅(int 且丒丛与丞世丙丕丌, string 丞丅上丏丂且下丅与, string 不丆业丏上丐与丌业, int 万且丒下丕丝专丟上)
    {
        string val_11;
        UnityEngine.GameObject val_12;
        val_11 = 不丆业丏上丐与丌业;
        bool val_2 = 丞丅上丏丂且下丅与.Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙());
        if(this._placeLabel != 0)
        {
                this._placeLabel.text = 且丒丛与丞世丙丕丌.ToString();
        }
        
        if(this._nickLabel != 0)
        {
                if(val_2 != false)
        {
                val_11 = ProfileController.丆三丂丂丆上丆丕专();
        }
        
            this._nickLabel.text = val_11;
        }
        
        if(this._scoreLabel != 0)
        {
                this._scoreLabel.text = 万且丒下丕丝专丟上.ToString();
        }
        
        val_12 = this._myPlayerBgGo;
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = this._defaultBgGo;
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = this._myPlayerBgGo;
        if(val_12 == null)
        {
            goto label_25;
        }
        
        if(val_2 == false)
        {
            goto label_26;
        }
        
        label_29:
        val_12.SetActive(value:  true);
        this._defaultBgGo.SetActive(value:  false);
        this.上世丄不丐丁丟丅丒 = true;
        return;
        label_25:
        if(val_2 == true)
        {
            goto label_29;
        }
        
        label_26:
        val_12.SetActive(value:  false);
        this._defaultBgGo.SetActive(value:  true);
        this.上世丄不丐丁丟丅丒 = false;
    }
    public PlayerScoreUi()
    {
    
    }

}
