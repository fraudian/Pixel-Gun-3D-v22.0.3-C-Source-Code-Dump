using UnityEngine;
internal sealed class GoToMainNeuFromFriends : MonoBehaviour
{
    // Fields
    private bool 与世丄七丌丅丆丕下;
    
    // Methods
    private void 丛丑与丟丑丈丏丑丘()
    {
        var val_3;
        var val_4;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_3 = null;
        val_3 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_4 = null;
        val_4 = null;
        LoadConnectScene.上三丕下一丅丘上丝 = 0;
        LoadConnectScene.丞丗专丝丙专丂上丗 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟);
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        if(丆且上丘世下丅且丞 != false)
        {
                this.与世丄七丌丅丆丕下 = false;
            return;
        }
        
        if(this.与世丄七丌丅丆丕下 != false)
        {
                return;
        }
        
        this.丛丑与丟丑丈丏丑丘();
    }
    public GoToMainNeuFromFriends()
    {
        this.与世丄七丌丅丆丕下 = true;
    }

}
