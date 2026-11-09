using UnityEngine;
[Serializable]
internal class 丈专丂丁丁东丌丁丅.GMEEventPlayerState
{
    // Fields
    internal int EventId;
    internal bool Completed;
    internal System.Collections.Generic.List<string> GettedRewards;
    internal int GettedTime;
    
    // Methods
    internal 丈专丂丁丁东丌丁丅.GMEEventPlayerState()
    {
        this.GettedRewards = new System.Collections.Generic.List<System.String>();
    }
    internal 丈专丂丁丁东丌丁丅.GMEEventPlayerState(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState 专丞丅业丆丐丕不七)
    {
        this.丌丅丛万丝东七丝专(专丞丅业丆丐丕不七:  专丞丅业丆丐丕不七);
    }
    internal void 丌丅丛万丝东七丝专(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMEEventPlayerState 专丞丅业丆丐丕不七)
    {
        if(专丞丅业丆丐丕不七 != null)
        {
                this.EventId = 专丞丅业丆丐丕不七.EventId;
            this.Completed = 专丞丅业丆丐丕不七.Completed;
            this.GettedRewards = 专丞丅业丆丐丕不七.GettedRewards;
        }
        else
        {
                this.EventId = 11993091;
            this.Completed = true;
            this.GettedRewards = 28563616;
        }
        
        this.GettedTime = 专丞丅业丆丐丕不七.GettedTime;
    }

}
