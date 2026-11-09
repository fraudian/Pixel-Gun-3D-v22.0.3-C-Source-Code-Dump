using UnityEngine;
internal sealed class FreePlayTaskProgressView : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _taskCompleteContainer;
    private UnityEngine.GameObject _taskNotCompleteContainer;
    private System.Collections.Generic.List<UILabel> _descriptionLabels;
    private UILabel _progressLabel;
    private UISprite _progressSprite;
    
    // Methods
    internal void 三七万不七下不丏万(string 丞丟丂丄下万丈万东)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._taskCompleteContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._taskNotCompleteContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._descriptionLabels, 丕丗丘丑丛与丑业丒:  丞丟丂丄下万丈万东);
    }
    internal void 上不丕丌丄世丆丘丘(string 丞丟丂丄下万丈万东, int 丐丑丟丞三丐丂丛三, int 丗丛万下丙丕上专丌)
    {
        float val_3;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._taskCompleteContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._taskNotCompleteContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._descriptionLabels, 丕丗丘丑丛与丑业丒:  丞丟丂丄下万丈万东);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  丗丛万下丙丕上专丌, arg1:  丐丑丟丞三丐丂丛三));
        if(丐丑丟丞三丐丂丛三 != 0)
        {
                val_3 = (float)丗丛万下丙丕上专丌 / (float)丐丑丟丞三丐丂丛三;
        }
        else
        {
                val_3 = 0f;
        }
        
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._progressSprite, 丙业与丙丗丝不丈东:  val_3);
    }
    public void U_OnClick()
    {
        InfoWindowController.丑七不且上丗丁一世().不七东丘丙丌世丏丒();
    }
    public FreePlayTaskProgressView()
    {
    
    }

}
