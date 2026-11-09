using UnityEngine;
public class BattleRoyaleSquadUI : MonoBehaviour
{
    // Fields
    public BattleRoyaleSquadItemUI[] items;
    public UnityEngine.Color[] squadColors;
    public static UnityEngine.Color[] squadColorsStatic;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丌不专丝丂丛丛丕丂 = this;
        if(BattleRoyaleController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_3.squadMode != false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        this.丑丁不万丈丟万且业();
    }
    private void 丑丁不万丈丟万且业()
    {
        object val_13;
        var val_14;
        var val_15;
        System.Collections.Generic.List<万丅世丈丕丕丌丅丗> val_16;
        var val_17;
        万丅世丈丕丕丌丅丗 val_18;
        val_13 = 1152921505039699968;
        if(BattleRoyaleController.丑七不且上丗丁一世() == 0)
        {
                val_14 = null;
            val_14 = null;
            if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_15 = null;
            val_15 = null;
            DungeonsController.丄丘七三上丕世丞业.squadInfo
        }
        else
        {
                BattleRoyaleController val_7 = BattleRoyaleController.丑七不且上丗丁一世();
            val_16 = val_7.squadInfo;
        }
        
        val_13 = mem[val_7.squadInfo];
        val_13 = val_7.squadInfo.SyncRoot;
        val_17 = 0;
        goto label_27;
        label_46:
        if((val_17 < val_13.Count) && (val_13.Item[0] != null))
        {
                this.items[0].gameObject.SetActive(value:  true);
            val_18 = val_13.Item[0];
            this.items[0].丗上丘丁丁且丂七丅(东一丁世丑丞业丄丐:  val_18);
        }
        else
        {
                val_18 = 0;
            this.items[val_18].gameObject.SetActive(value:  false);
        }
        
        val_17 = 1;
        label_27:
        if(val_17 < this.items.Length)
        {
            goto label_46;
        }
    
    }
    public BattleRoyaleSquadUI()
    {
    
    }
    private static BattleRoyaleSquadUI()
    {
        UnityEngine.Color[] val_1 = new UnityEngine.Color[3];
        UnityEngine.Color val_2 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  16756479);
        val_1[0] = val_2;
        val_1[0] = val_2.g;
        val_1[0] = val_2.b;
        val_1[0] = val_2.a;
        UnityEngine.Color val_3 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  -5743617);
        val_1[1] = val_3;
        val_1[1] = val_3.g;
        val_1[1] = val_3.b;
        val_1[1] = val_3.a;
        UnityEngine.Color val_4 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  967049216);
        val_1[2] = val_4;
        val_1[2] = val_4.g;
        val_1[2] = val_4.b;
        val_1[2] = val_4.a;
        BattleRoyaleSquadUI.squadColorsStatic = val_1;
    }

}
