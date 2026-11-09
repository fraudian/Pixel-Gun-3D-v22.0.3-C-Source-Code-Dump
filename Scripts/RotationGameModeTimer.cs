using UnityEngine;
public class RotationGameModeTimer : MonoBehaviour
{
    // Fields
    internal UILabel rotationGameModeTimer;
    internal UnityEngine.GameObject rotationGameModeTimerSprite;
    
    // Methods
    private void Update()
    {
        UnityEngine.GameObject val_20;
        var val_21;
        UILabel val_22;
        val_20 = this;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().一丝丈丈三一丒丒丅();
        if(val_2 == null)
        {
            goto label_13;
        }
        
        val_21 = null;
        val_21 = null;
        System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_3 = val_2.业丄丄且丕丕不一万();
        SceneInfo val_5 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_2.丕丆丞丂业东与上丅());
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  val_3.HasValue, 丈东丅万丟丞丒不丒:  val_5.indexMap)) == 0)
        {
            goto label_13;
        }
        
        System.Nullable<System.DateTime> val_8 = FriendsController.业丈丏丏丞丘丛丈丛();
        if((1471011736 & 1) == 0)
        {
            goto label_13;
        }
        
        if(val_2.七丂丌丈丄专丄三世() == false)
        {
            goto label_14;
        }
        
        System.Nullable<System.TimeSpan> val_10 = val_2.丙世丑丅丒丑业与不();
        this.rotationGameModeTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_22 = this.rotationGameModeTimer;
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        goto label_18;
        label_13:
        this.rotationGameModeTimer.text = System.String.alignConst;
        if(this.rotationGameModeTimerSprite == 0)
        {
                return;
        }
        
        val_20 = this.rotationGameModeTimerSprite;
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_20, 丏业丟一东丂东丘丛:  false);
        return;
        label_14:
        System.Nullable<System.DateTime> val_14 = val_2.东丗丝丙丈丒丛丐丛();
        System.Nullable<System.DateTime> val_15 = FriendsController.业丈丏丏丞丘丛丈丛();
        System.TimeSpan val_16 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {});
        this.rotationGameModeTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_16._ticks}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_22 = this.rotationGameModeTimer;
        UnityEngine.Color val_18 = UnityEngine.Color.cyan;
        label_18:
        val_22.color = new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a};
        if(this.rotationGameModeTimerSprite == 0)
        {
                return;
        }
        
        goto label_38;
    }
    public RotationGameModeTimer()
    {
    
    }

}
