using UnityEngine;
private sealed class LeaderboardEventController.不与三三上且业丕丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丟丟丄专上丟丁丐丝;
    public LeaderboardEventController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.不与三三上且业丕丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        object val_10;
        int val_11;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_1 = UnityEngine.Random.Range(min:  30, max:  120);
        object[] val_2 = new object[2];
        val_2[0] = this.丟丟丄专上丟丁丐丝;
        val_2[1] = val_1;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- EndedEventTournamentCoroutine eventId: {0} seconds: {1}", args:  val_2);
        UnityEngine.WaitForSeconds val_3 = null;
        val_10 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  (float)val_1);
        val_11 = 1;
        this.丒上七丌业七丟与丐 = val_10;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = this.丝且与丝丒丟万丁专.丐丏世与三丒业丆丏;
        if((val_10.ContainsKey(key:  this.丟丟丄专上丟丁丐丝)) != false)
        {
                val_9 = this.丟丟丄专上丟丁丐丝;
            bool val_5 = this.丝且与丝丒丟万丁专.丐丏世与三丒业丆丏.Remove(key:  val_9);
        }
        
        label_16:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_10.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丟三丂丒丏不丌丝与(丟丟丄专上丟丁丐丝:  this.丟丟丄专上丟丁丐丝, 丛专下丞丒丛下下与:  false));
        this.丗丏丅丕丆世丁专丟 = 2;
        val_11 = 1;
        return (bool)val_11;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
