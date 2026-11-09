using UnityEngine;
public class RoyaleSquadNotificationsController : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<string> 丁丈业丆不丏丕丑丆;
    internal static RoyaleSquadNotificationsController 丄丘七三上丕世丞业;
    private UILabel notificationLabel;
    private float showTimeot;
    private float 专三丌万丂丏丕不丐;
    private const string 业丈丝丂丄丙业丟业 = "00FFAE";
    private const string 下下丝丘丌丛丘丟丁 = "FFA85B";
    private const string 专七万世丕专丌丈丅 = "AC00AE";
    private const string 丒不与丌丝丈与世丘 = "FFFFFF";
    private const string 业丝丈专丆上三丐丁 = "FF0000";
    private const string 丟丗丅下不七七丝丂 = "0000FF";
    
    // Methods
    private void Awake()
    {
        RoyaleSquadNotificationsController.丟丗丅下不七七丝丂 = this;
    }
    private void OnDestroy()
    {
        RoyaleSquadNotificationsController.丟丗丅下不七七丝丂 = 0;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.专三丌万丂丏丕不丐;
        if(val_1 <= this.showTimeot)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.notificationLabel.gameObject;
        if(this.丁丈业丆不丏丕丑丆.Count >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            this.notificationLabel.text = this.丁丈业丆不丏丕丑丆.Item[0];
            this.丁丈业丆不丏丕丑丆.RemoveAt(index:  0);
            this.专三丌万丂丏丕不丐 = UnityEngine.Time.realtimeSinceStartup;
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
    }
    private bool 丏丙上丕丛丝东丘丙(Player_move_c 专丞上七七且丝七丗)
    {
        Player_move_c val_4;
        var val_5;
        val_4 = 专丞上七七且丝七丗;
        if((this.丒丐不丆丌丟丁世专(专丞上七七且丝七丗:  val_4)) == false)
        {
            goto label_1;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_4;
        }
        
        val_4 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        var val_3 = (专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true) ? 1 : 0;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        val_5 = 1;
        return (bool)val_5;
    }
    private bool 丒丐不丆丌丟丁世专(Player_move_c 专丞上七七且丝七丗)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return false;
        }
        
        val_6 = null;
        val_6 = null;
        if(专丞上七七且丝七丗 == 0)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  专丞上七七且丝七丗.丟三丏丅世一丟丟上, y:  0);
    }
    private string 与东丟丙专丟丐丁丆(Player_move_c 专丞上七七且丝七丗)
    {
        var val_6;
        if(专丞上七七且丝七丗 == 0)
        {
                label_14:
            val_6 = "FFFFFF";
            return (string)val_6;
        }
        
        val_6 = "FFFFFF";
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上 == 0)
        {
                return (string)val_6;
        }
        
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 != false)
        {
                if(((专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 & 2147483648) != 0) || (专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 > 2))
        {
            goto label_14;
        }
        
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_20;
        }
        
        }
        
        val_6 = "0000FF";
        return (string)val_6;
        label_20:
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
                return (string)val_6;
        }
        
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 == 0)
        {
                return (string)val_6;
        }
        
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 == 1)
        {
                return (string)val_6;
        }
        
        var val_5 = (专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 == 2) ? "AC00AE" : (val_6);
        return (string)val_6;
    }
    private void 丟且丄丗丞丌丐不丈(string 丕丗丘丑丛与丑业丒)
    {
        System.Collections.Generic.List<System.String> val_4 = this.丁丈业丆不丏丕丑丆;
        if(val_4.Count > 2)
        {
                val_4 = this.丁丈业丆不丏丕丑丆.Count;
            this.丁丈业丆不丏丕丑丆.set_Item(index:  val_4 - 1, value:  丕丗丘丑丛与丑业丒);
            return;
        }
        
        this.丁丈业丆不丏丕丑丆.Add(item:  丕丗丘丑丛与丑业丒);
    }
    private string 丅丘丁世七一丄与丄(Player_move_c 专丞上七七且丝七丗)
    {
        object[] val_1 = new object[5];
        val_1[0] = "[";
        val_1[1] = 与东丟丙专丟丐丁丆(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        val_1[2] = "]";
        val_1[3] = 专丞上七七且丝七丗.丟三丏丅世一丟丟上.丂丈丐不丏万三七丐;
        val_1[4] = "[-]";
        return System.String.Format(format:  "{0}{1}{2}{3}{4}", args:  val_1);
    }
    internal void 丒下东丈丏丙丐丑与(Player_move_c 丆上丙一下丞丙丙且)
    {
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丆上丙一下丞丙丙且)) == false)
        {
                return;
        }
        
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6053");
        this.丟且丄丗丞丌丐不丈(丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_2, arg0:  val_2.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丆上丙一下丞丙丙且)));
    }
    internal void 丟丆丄上且丏与丁与(Player_move_c 丛三世丁不三丘丙丙, Player_move_c 丙丅一丁丞与丗且一)
    {
        var val_8;
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丛三世丁不三丘丙丙)) == false)
        {
                return;
        }
        
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丙丅一丁丞与丗且一)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(丛三世丁不三丘丙丙 == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                return;
        }
        
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6054");
        string val_5 = val_4.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丛三世丁不三丘丙丙);
        this.丟且丄丗丞丌丐不丈(丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_4, arg0:  val_5, arg1:  val_5.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丙丅一丁丞与丗且一)));
    }
    internal void 丟丐丝下丑丄丈与丞(Player_move_c 丙丗不丌与下丁三丞)
    {
        var val_6;
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丙丗不丌与下丁三丞)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(丙丗不丌与下丁三丞 == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                return;
        }
        
        string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6055");
        this.丟且丄丗丞丌丐不丈(丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_3, arg0:  val_3.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丙丗不丌与下丁三丞)));
    }
    internal void 丘丆下丑且丅丄丛万(Player_move_c 丙丗不丌与下丁三丞, Player_move_c 丆丝专专丟丟丈丏丐)
    {
        var val_8;
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丙丗不丌与下丁三丞)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  丙丗不丌与下丁三丞, y:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
        if(val_2 == false)
        {
                return;
        }
        
        if((val_2.丒丐不丆丌丟丁世专(专丞上七七且丝七丗:  丆丝专专丟丟丈丏丐)) == false)
        {
                return;
        }
        
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6198");
        string val_5 = val_4.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丆丝专专丟丟丈丏丐);
        this.丟且丄丗丞丌丐不丈(丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_4, arg0:  val_5, arg1:  val_5.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丙丗不丌与下丁三丞)));
    }
    internal void 一专丑与丁丞丄且三(Player_move_c 丙丗不丌与下丁三丞, Player_move_c 丆丝专专丟丟丈丏丐)
    {
        var val_8;
        if((this.丏丙上丕丛丝东丘丙(专丞上七七且丝七丗:  丙丗不丌与下丁三丞)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  丙丗不丌与下丁三丞, y:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
        if(val_2 == false)
        {
                return;
        }
        
        if((val_2.丒丐不丆丌丟丁世专(专丞上七七且丝七丗:  丆丝专专丟丟丈丏丐)) == false)
        {
                return;
        }
        
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6141");
        string val_5 = val_4.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丙丗不丌与下丁三丞);
        this.丟且丄丗丞丌丐不丈(丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_4, arg0:  val_5, arg1:  val_5.丅丘丁世七一丄与丄(专丞上七七且丝七丗:  丆丝专专丟丟丈丏丐)));
    }
    public RoyaleSquadNotificationsController()
    {
        this.丁丈业丆不丏丕丑丆 = new System.Collections.Generic.List<System.String>();
        this.showTimeot = 3f;
    }

}
