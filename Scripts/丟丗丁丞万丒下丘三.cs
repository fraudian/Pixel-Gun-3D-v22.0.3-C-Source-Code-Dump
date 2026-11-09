using UnityEngine;
private sealed class ClansLobbyGui.丟丗丁丞万丒下丘三
{
    // Fields
    public System.Action 丞丒业万东专上丒丛;
    public Rilisoft.ClansLobbyGui 丝且与丝丒丟万丁专;
    
    // Methods
    public ClansLobbyGui.丟丗丁丞万丒下丘三()
    {
    
    }
    internal void 丟且不业丗丗丆丐七()
    {
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 != 0)
        {
                ClansWindowInfoViewController.丄丘七三上丕世丞业.remove_OnClose(丙业与丙丗丝不丈东:  this.丞丒业万东专上丒丛);
            this.丝且与丝丒丟万丁专.gameObject.SetActive(value:  true);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "No ClansWindowInstance");
    }

}
