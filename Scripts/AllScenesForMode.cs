using UnityEngine;
[Serializable]
public class AllScenesForMode
{
    // Fields
    public readonly System.Collections.Generic.List<SceneInfo> avaliableScenes;
    public readonly System.Collections.Generic.List<SceneInfo> mapsForVote;
    public readonly System.Collections.Generic.Dictionary<SceneInfo, int> unlockedAtLevel;
    public readonly System.Collections.Generic.List<SceneInfo> lockedByLevel;
    internal Rilisoft.七丕丟丏三丈一丄世 mode;
    
    // Methods
    internal void 专东且与丅东丛不上(SceneInfo 丒丁不世七世丛丒三)
    {
        this.avaliableScenes.Add(item:  丒丁不世七世丛丒三);
    }
    internal void 丆上专丞丈下丈丂丒(SceneInfo 丒丁不世七世丛丒三)
    {
        this.mapsForVote.Add(item:  丒丁不世七世丛丒三);
    }
    internal void 一丗丗且丝丝丑丂丝(SceneInfo 丒丁不世七世丛丒三)
    {
        this.lockedByLevel.Add(item:  丒丁不世七世丛丒三);
    }
    internal void 丟丑上丗三丞东丙丞(SceneInfo 丒丁不世七世丛丒三, int 上丝丆丕不丑业且丙)
    {
        this.unlockedAtLevel.Add(key:  丒丁不世七世丛丒三, value:  上丝丆丕不丑业且丙);
    }
    public AllScenesForMode()
    {
        this.avaliableScenes = new System.Collections.Generic.List<SceneInfo>();
        this.mapsForVote = new System.Collections.Generic.List<SceneInfo>();
        this.unlockedAtLevel = new System.Collections.Generic.Dictionary<SceneInfo, System.Int32>();
        this.lockedByLevel = new System.Collections.Generic.List<SceneInfo>();
    }

}
