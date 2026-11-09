using UnityEngine;
public class TimeLeftInMatch : MonoBehaviour
{
    // Fields
    public UILabel timeLabel;
    public UnityEngine.GameObject waitLabel;
    public UnityEngine.GameObject waitOpponents;
    public UILabel timeToStartLabel;
    private float 丛丁丈与丛万一丝万;
    
    // Methods
    private void Start()
    {
        if(GameConnect.丑丌丛丈丅丅与不业() != 0)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 1)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = val_3.localPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  53f);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_3.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private void 丐七丑七丐丙丁一万()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.OnEnable();
    }
    private void OnDestroy()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(GameController.onlineMode == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        GameController.onlineMode.丅业且丁不丆业东丛();
    }
    private void OnEnable()
    {
        var val_29;
        var val_30;
        System.Action val_31;
        var val_32;
        SceneInfo val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_29 = null;
        val_29 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() == false)
        {
            goto label_6;
        }
        
        }
        
        val_30 = 0;
        goto label_7;
        label_6:
        val_31 = 1152921505189646336;
        val_32 = null;
        val_32 = null;
        val_33 = 0;
        if(GameController.丆丘丂丈世丏丟丑丏 != 0)
        {
                val_34 = null;
            val_34 = null;
            val_33 = mem[GameController.丆丘丂丈世丏丟丑丏 + 48];
            val_33 = GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上;
        }
        
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丏丈丗世丙万丆丐丅:  val_33)) != false)
        {
                val_35 = null;
            val_35 = null;
            System.Action val_5 = null;
            val_31 = val_5;
            val_5 = new System.Action(object:  this, method:  System.Void TimeLeftInMatch::丐七丑七丐丙丁一万());
            val_36 = GameController.onlineMode.丝丌丁丐万丌丛且丑(三世且世丂一丅丞丌:  val_5);
        }
        else
        {
                val_36 = 0;
        }
        
        label_7:
        val_37 = null;
        val_37 = null;
        var val_8 = (与丂丏丛丞丞丒丟丄.下万丏丁丙不丅三丄 < 0f) ? 1 : 0;
        val_8 = ((val_36 != 0) ? 1 : 0) | val_8;
        if((val_8 & 1) != 0)
        {
                return;
        }
        
        val_38 = null;
        val_38 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == true)
        {
                return;
        }
        
        if((((GameConnect.丑丌丛丈丅丅与不业() != 2) && (GameConnect.丑丌丛丈丅丅与不业() != 0)) && (GameConnect.丑丌丛丈丅丅与不业() != 1)) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                return;
        }
        
        }
        
        }
        
        if(NetworkStartTable.与一专丒东丏丘专丕() == true)
        {
                return;
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丙一丏东万七丐业丕() == false)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        val_31 = GameConnect.专丝下世丄业丕丑七;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_31] == null)
        {
                return;
        }
        
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= 0f)
        {
                return;
        }
        
        val_41 = null;
        val_41 = null;
        val_31 = GameConnect.专丝下世丄业丕丑七;
        double val_28 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_31]);
        val_28 = val_28 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_28 > 0f)
        {
                val_42 = null;
            val_42 = null;
            float val_29 = 与丂丏丛丞丞丒丟丄.下万丏丁丙不丅三丄;
            val_29 = val_29 + 16f;
            if(val_28 <= (double)val_29)
        {
                return;
        }
        
        }
        
        if(this.丛丁丈与丛万一丝万 != (-1f))
        {
                return;
        }
        
        val_43 = null;
        val_43 = null;
        this.丛丁丈与丛万一丝万 = 与丂丏丛丞丞丒丟丄.下万丏丁丙不丅三丄;
    }
    internal static bool 丐丈丗丕丞丈业丑丘()
    {
        var val_7;
        System.Collections.Generic.List<Player_move_c> val_8;
        val_7 = null;
        val_7 = null;
        val_8 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_8.Count < 1)
        {
                return false;
        }
        
        val_8 = 1152921505066536960;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return false;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return false;
        }
        
        if(GameConnect.不专专丂万丝上东丐() == true)
        {
                return false;
        }
        
        val_8 = TimeGameController.丄丞丁丈与业上丞丟;
        if(val_8 == 0)
        {
                return false;
        }
        
        val_8 = TimeGameController.丄丞丁丈与业上丞丟;
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 0f)
        {
                return false;
        }
        
        val_8 = TimeGameController.丄丞丁丈与业上丞丟;
        if(TimeGameController.丄丞丁丈与业上丞丟.不丏一一七专专丄丑 != false)
        {
                return false;
        }
        
        var val_6 = (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 < 0) ? 1 : 0;
        return false;
    }
    private void Update()
    {
        UILabel val_35;
        float val_36;
        double val_37;
        var val_38;
        var val_39;
        string val_40;
        var val_45;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        bool val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        ClickerDetector val_56;
        var val_57;
        val_35 = this;
        if(TimeLeftInMatch.丐丈丗丕丞丈业丑丘() == false)
        {
            goto label_1;
        }
        
        val_36 = this.丛丁丈与丛万一丝万;
        if(val_36 >= 0)
        {
            goto label_2;
        }
        
        val_37 = 16;
        val_38 = 1;
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 >= val_37)
        {
            goto label_4;
        }
        
        goto label_12;
        label_1:
        val_38 = 0;
        label_4:
        val_36 = this.丛丁丈与丛万一丝万;
        goto label_6;
        label_2:
        val_38 = 0;
        label_6:
        if((val_36 >= 0f) && (Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().IsRewardVideoShowing != true))
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(childCount == 0)
        {
            goto label_15;
        }
        
        }
        
        }
        
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeToStartLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        label_107:
        this.waitOpponents.SetActive(value:  false);
        val_39 = 0;
        if(val_38 != 0)
        {
                val_37 = 16;
        }
        
        this.waitLabel.SetActive(value:  (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 < 0) ? 1 : 0);
        this.timeLabel.gameObject.SetActive(value:  false);
        val_40 = this.timeLabel.transform.parent.gameObject;
        val_40.SetActive(value:  false);
        if(val_38 == 0)
        {
                return;
        }
        
        val_40 = Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  (float)TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞);
        this.timeLabel.text = val_40;
        val_35 = this.timeLabel;
        if(this.waitLabel.activeSelf != false)
        {
                UnityEngine.Color val_14 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_15 = UnityEngine.Color.white;
        }
        
        val_35.color = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a};
        return;
        label_15:
        if(下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄() != false)
        {
                this.丛丁丈与丛万一丝万 = -1f;
        }
        
        val_45 = null;
        val_45 = null;
        val_46 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_46 == null)
        {
            goto label_43;
        }
        
        val_46 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_46 == null)
        {
                val_46 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_17 = val_46.丌不丅不丞东万专专();
        val_47 = 0;
        if((val_17.HasValue.丙东专丂世丈丏丁丂() != 2) || ((1569918760 & 1) == 0))
        {
            goto label_58;
        }
        
        val_48 = null;
        val_48 = null;
        val_47 = 0;
        if((PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.上万世丒丁万下丌丛(丏丒丒丌一丌东丘丝:  GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七(), 万且丕业与丗丗丝七:  false)) == true)
        {
            goto label_58;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeToStartLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        val_47 = 1;
        this.丛丁丈与丛万一丝万 = -1f;
        goto label_58;
        label_43:
        val_47 = 0;
        label_58:
        if(PGCompany.VeteranChest.丒专丛丒丄业丛业丁.丕三三丐一一丟丘丂() != true)
        {
                float val_23 = UnityEngine.Time.deltaTime;
            val_23 = this.丛丁丈与丛万一丝万 - val_23;
            this.丛丁丈与丛万一丝万 = val_23;
        }
        
        if((val_47 & 1) == 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeToStartLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        this.timeToStartLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6509"), arg0:  Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  this.丛丁丈与丛万一丝万));
        if(this.丛丁丈与丛万一丝万 >= 0)
        {
            goto label_107;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_72;
        }
        
        val_49 = null;
        val_49 = null;
        if(丘丑丅三丆丑丌且丝() < 1)
        {
            goto label_103;
        }
        
        label_72:
        val_50 = null;
        val_50 = null;
        val_51 = mem[GameController.onlineMode + 416];
        val_51 = GameController.onlineMode.丅丅丌丞七东丂上丙;
        if(val_51 != false)
        {
                int val_36 = ExperienceController.丞丞丘业东丙丏七丌();
            val_52 = null;
            val_52 = null;
            int val_35 = BalanceController.业丌丁丞丆丆万业丘;
            val_35 = val_35 + 2;
        }
        
        val_36 = val_47 | ((val_36 > val_35) ? 1 : 0);
        if((val_36 | (~下丟世丏三东万丘丏.下不丙丌丙丞丞万上())) == true)
        {
            goto label_88;
        }
        
        val_53 = null;
        val_53 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 == 0)
        {
            goto label_97;
        }
        
        label_88:
        val_54 = null;
        val_54 = null;
        if(null == 0)
        {
            goto label_97;
        }
        
        val_55 = null;
        val_55 = null;
        val_56 = ClickerDetector.丄丘七三上丕世丞业;
        if(ClickerDetector.丄丘七三上丕世丞业 != null)
        {
            goto label_100;
        }
        
        val_56 = ClickerDetector.丄丘七三上丕世丞业;
        if(val_56 == null)
        {
            goto label_101;
        }
        
        label_100:
        if(ClickerDetector.丄丘七三上丕世丞业.丈丐世下丞与丂专丏 >= 0)
        {
            goto label_103;
        }
        
        label_97:
        val_57 = null;
        val_57 = null;
        GameController.onlineMode.丟丛专七不七丆三万();
        label_103:
        this.丛丁丈与丛万一丝万 = -1f;
        goto label_107;
        label_101:
    }
    public TimeLeftInMatch()
    {
        this.丛丁丈与丛万一丝万 = -1f;
    }

}
