using UnityEngine;
public class PlayerBotPathsManager : MonoBehaviour
{
    // Fields
    internal System.Collections.Generic.List<PlayerBotPathWayPoint> wayPoints;
    private bool isNewWayPointsSystem;
    internal static bool 世丒丆丑丑丕丏丙万;
    private static PlayerBotPathsManager 丝业丆丁业三丈丟东;
    
    // Properties
    private static string 专丝丞丞不上万丒七 { get; }
    internal static PlayerBotPathsManager 丄丘七三上丕世丞业 { get; }
    internal bool 丁业丘丘丛东下丏丆 { get; }
    
    // Methods
    private static string 丌下业不丐丅丑丈与()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[4];
            val_2[0] = "[PathsManager] Name prefab: PlayerBotPaths_";
            val_2[1] = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
            val_2[2] = "_";
            val_2[3] = GameConnect.丑丌丛丈丅丅与不业();
            UnityEngine.Debug.Log(message:  +val_2);
        }
        
        object[] val_6 = new object[4];
        val_6[0] = "PlayerBotPaths_";
        val_6[1] = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
        val_6[2] = "_";
        val_6[3] = GameConnect.丑丌丛丈丅丅与不业();
        return (string)+val_6;
    }
    internal static PlayerBotPathsManager 与一丅丝不丈业与丙()
    {
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        UnityEngine.Object val_17;
        var val_18;
        val_14 = null;
        val_14 = null;
        if(PlayerBotPathsManager.丝业丆丁业三丈丟东 == 0)
        {
            goto label_5;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = PlayerBotPathsManager.丝业丆丁业三丈丟东.gameObject;
        if(val_16 != 0)
        {
            goto label_24;
        }
        
        label_5:
        UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  "PlayerBot/"("PlayerBot/") + PlayerBotPathsManager.丌下业不丐丅丑丈与());
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        if(val_17 != 0)
        {
                val_16 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_17);
            val_16.name = PlayerBotPathsManager.丌下业不丐丅丑丈与();
        }
        else
        {
                UnityEngine.GameObject val_12 = null;
            val_16 = val_12;
            val_12 = new UnityEngine.GameObject(name:  PlayerBotPathsManager.丌下业不丐丅丑丈与());
            PlayerBotPathsManager val_13 = val_12.AddComponent<PlayerBotPathsManager>();
        }
        
        label_24:
        val_18 = null;
        val_18 = null;
        return (PlayerBotPathsManager)PlayerBotPathsManager.丝业丆丁业三丈丟东;
    }
    private void Awake()
    {
        null = null;
        PlayerBotPathsManager.丝业丆丁业三丈丟东 = this;
    }
    internal bool 丈业三一东丄下上丆()
    {
        return (bool)this.isNewWayPointsSystem;
    }
    public PlayerBotPathsManager()
    {
        this.wayPoints = new System.Collections.Generic.List<PlayerBotPathWayPoint>();
    }
    private static PlayerBotPathsManager()
    {
    
    }

}
