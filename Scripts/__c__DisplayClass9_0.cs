using UnityEngine;
private sealed class Logger.<>c__DisplayClass9_0
{
    // Fields
    public string msg;
    
    // Methods
    public Logger.<>c__DisplayClass9_0()
    {
    
    }
    internal void <w>b__0()
    {
        UnityEngine.Debug.LogWarning(message:  GooglePlayGames.OurUtils.Logger.ToLogMessage(prefix:  "!!!", logType:  "WARNING", msg:  this.msg));
    }

}
