using UnityEngine;
private sealed class AndroidSavedGameClient.<>c__DisplayClass11_1
{
    // Fields
    public GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver;
    public GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original;
    public byte[] originalData;
    public GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged;
    public byte[] unmergedData;
    public GooglePlayGames.Android.AndroidSavedGameClient.<>c__DisplayClass11_0 CS$<>8__locals1;
    
    // Methods
    public AndroidSavedGameClient.<>c__DisplayClass11_1()
    {
    
    }
    internal void <ToOnGameThread>b__1()
    {
        this.CS$<>8__locals1.conflictCallback.Invoke(resolver:  this.resolver, original:  this.original, originalData:  this.originalData, unmerged:  this.unmerged, unmergedData:  this.unmergedData);
    }

}
