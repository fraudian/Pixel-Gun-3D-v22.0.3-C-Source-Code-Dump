using UnityEngine;
public class ClansClicked : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        var val_3;
        var val_4;
        var val_5;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_3 = null;
        val_3 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_4 = null;
        val_4 = null;
        LoadConnectScene.上三丕下一丅丘上丝 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Friends_Loading");
        LoadConnectScene.丞丗专丝丙专丂上丗 = "Clans";
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_5 = null;
        val_5 = null;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟);
    }
    public ClansClicked()
    {
    
    }

}
