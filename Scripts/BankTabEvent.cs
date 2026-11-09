using UnityEngine;
internal class BankTabEvent : MonoBehaviour
{
    // Fields
    private UISprite _icon;
    private UILabel _text;
    
    // Methods
    private void OnEnable()
    {
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 != null)
        {
                this._text.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2.丟万丏且上业丐丈一());
            this._icon.spriteName = val_2.专且丝与上下万与丅();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "fail set BankTabEvent: nullable active event");
    }
    public BankTabEvent()
    {
    
    }

}
