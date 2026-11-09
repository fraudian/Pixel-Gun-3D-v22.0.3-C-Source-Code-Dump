using UnityEngine;
private sealed class JoinToFriendRoomController.丝业丞丕丟万万丝丙
{
    // Fields
    public string 丂一丏丙下丝丘丆丗;
    public System.Action 一丗与与丌七丆丂不;
    public UnlockPremiumMapView 专三世丆丏万丄上丏;
    
    // Methods
    public JoinToFriendRoomController.丝业丞丕丟万万丝丙()
    {
    
    }
    internal void 世丄下丄丁丟上不丗()
    {
        var val_5;
        var val_6;
        丌丝世丞世丛丆丅丟.东丌丟三丞世一一丑(丌丘不丆丈丈世万上:  this.丂一丏丙下丝丘丆丗 + "Key", 丕万不丌世丟三丛丈:  false);
        if(UnityEngine.Application.platform != 8)
        {
                UnityEngine.PlayerPrefs.Save();
        }
        
        val_5 = null;
        val_5 = null;
        if(coinsPlashka.专丆专上丗万世丒七 != 0)
        {
                val_6 = null;
            val_6 = null;
            coinsPlashka.专丆专上丗万世丒七.enabled = false;
        }
        
        this.一丗与与丌七丆丂不.Invoke();
        UnityEngine.Object.Destroy(obj:  this.专三世丆丏万丄上丏.gameObject);
    }

}
