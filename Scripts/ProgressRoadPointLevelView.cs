using UnityEngine;
internal sealed class ProgressRoadPointLevelView : PGBehaviour
{
    // Fields
    private UILabel levelLabel;
    private UILabel xpLabel;
    private ProgressRoad.丅丂丅丕下丑丘万一 丘三丌丐丒丒七丑东;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        this.丘三丌丐丒丒七丑东 = 东东丗丅与一下丄丈;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  东东丗丅与一下丄丈.丘丈不不下丙万丌专));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.xpLabel, 丕丗丘丑丛与丑业丒:  this.丘三丌丐丒丒七丑东.一万丏丂丅丄丑且丂);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (this.丘三丌丐丒丒七丑东.一万丏丂丅丄丑且丂 == 0) ? 1 : 0);
    }
    public ProgressRoadPointLevelView()
    {
    
    }

}
