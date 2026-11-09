using UnityEngine;
internal sealed class PlantTheBombScoresPanel : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject teamsAmountPanel;
    private TeamAmounter redTeamAmounter;
    private TeamAmounter blueTeamAmounter;
    private UILabel myTeamWinsLabel;
    private UILabel enemyTeamWinsLabel;
    private UnityEngine.GameObject timeIcon;
    private UnityEngine.GameObject bombIcon;
    private UnityEngine.GameObject iconsCont;
    private UnityEngine.GameObject blueBombIcon;
    private UnityEngine.GameObject blueCuttersIcon;
    private UnityEngine.GameObject redBombIcon;
    private UnityEngine.GameObject redCuttersIcon;
    
    // Methods
    private void Start()
    {
    
    }
    private void 万丏业丂丐下丆丛与()
    {
        UnityEngine.Object val_33;
        var val_34;
        TeamAmounter val_35;
        var val_36;
        var val_37;
        var val_38;
        val_33 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(val_33 == 0)
        {
                return;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == null)
        {
                val_33 = 0;
        }
        
        val_34 = this.bombIcon;
        val_34.SetActive(value:  val_33.丟不丏丈丗丘丕丐丒());
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == null)
        {
                val_34 = 0;
        }
        
        this.timeIcon.SetActive(value:  (~val_34.丟不丏丈丗丘丕丐丒()) & 1);
        if(0.三丘三丈上丕丆丂一() != 2)
        {
                this.blueBombIcon.SetActive(value:  PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamWithBombIcon);
            this.blueCuttersIcon.SetActive(value:  PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamWithCuttersIcon);
            this.redBombIcon.SetActive(value:  PlantTheBombController.丆丕丝丒不丙且丐丗.isEnemyTeamWithBombIcon);
            this.redCuttersIcon.SetActive(value:  PlantTheBombController.丆丕丝丒不丙且丐丗.isEnemyTeamWithCuttersIcon);
        }
        
        this.teamsAmountPanel.SetActive(value:  (PlantTheBombController.丆丕丝丒不丙且丐丗.世丄东丄丕七丟不丗 == true) ? 1 : 0);
        val_35 = 1152921505286238208;
        val_36 = null;
        val_36 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_37 = null;
            val_37 = null;
            if((WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0) && (PlantTheBombController.丆丕丝丒不丙且丐丗.世丄东丄丕七丟不丗 != false))
        {
                val_38 = null;
            val_38 = null;
            int val_18 = 丘丑丅三丆丑丌且丝();
            if(val_18 == 1)
        {
                int val_19 = PlantTheBombController.teamOnePlayersAlive;
        }
        
            this.blueTeamAmounter.SetAmount(丌丒丝东丌下丕丁丅:  PlantTheBombController.teamTwoPlayersAlive);
            val_35 = this.redTeamAmounter;
            if(val_18 == 1)
        {
                int val_21 = PlantTheBombController.teamTwoPlayersAlive;
        }
        
            val_35.SetAmount(丌丒丝东丌下丕丁丅:  PlantTheBombController.teamOnePlayersAlive);
        }
        
        }
        
        if(0.三丘三丈上丕丆丂一() != 3)
        {
                if(0.三丘三丈上丕丆丂一() != 0)
        {
                return;
        }
        
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.七业丕且万丝丛丝与 != false)
        {
                return;
        }
        
        this.blueBombIcon.SetActive(value:  (~PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamWithBombIcon) & 1);
        this.blueCuttersIcon.SetActive(value:  (~PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamWithCuttersIcon) & 1);
        this.redBombIcon.SetActive(value:  (~PlantTheBombController.丆丕丝丒不丙且丐丗.isEnemyTeamWithBombIcon) & 1);
        this.redCuttersIcon.SetActive(value:  (~PlantTheBombController.丆丕丝丒不丙且丐丗.isEnemyTeamWithCuttersIcon) & 1);
    }
    private void Update()
    {
        this.丂丛丗下专丙丐七丁();
        this.万丏业丂丐下丆丛与();
    }
    private void 丂丛丗下专丙丐七丁()
    {
        UILabel val_23;
        var val_24;
        PlantTheBombController val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_23 = this;
        val_24 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_25 = 1152921505286238208;
        val_26 = null;
        val_26 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        int val_4 = 丘丑丅三丆丑丌且丝();
        val_29 = null;
        val_29 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丗丅上丅世与丐丅上)) != false)
        {
                val_30 = null;
            val_30 = null;
            int val_11 = System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅上丅世与丐丅上]);
        }
        
        val_31 = null;
        val_31 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.上专丁丕不丒丛丐专)) != false)
        {
                val_32 = null;
            val_32 = null;
            int val_18 = System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.上专丁丕不丒丛丐专]);
        }
        
        if(val_4 == 1)
        {
            
        }
        
        val_24 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myTeamWinsLabel, 丕丗丘丑丛与丑业丒:  val_18.ToString() + "/"("/") + PlantTheBombController.丆丕丝丒不丙且丐丗.丞一七丐东世丌专丐);
        val_23 = this.enemyTeamWinsLabel;
        if(val_4 == 2)
        {
            
        }
        
        val_25 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_23, 丕丗丘丑丛与丑业丒:  val_18.ToString() + "/"("/") + PlantTheBombController.丆丕丝丒不丙且丐丗.丞一七丐东世丌专丐);
    }
    public PlantTheBombScoresPanel()
    {
    
    }

}
