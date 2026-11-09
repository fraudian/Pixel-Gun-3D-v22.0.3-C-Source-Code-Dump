using UnityEngine;
public class ConnectSceneSelectMap : MonoBehaviour
{
    // Fields
    private static ConnectSceneSelectMap 丝业丆丁业三丈丟东;
    public UIGrid customButtonsGrid;
    public UnityEngine.GameObject customButtonsContainer;
    public UnityEngine.GameObject mapPreviewTexture;
    public UnityEngine.GameObject mapVoteObject;
    public UnityEngine.GameObject grid;
    public UIGrid voteGrid;
    public UIWidget votePanelWidget;
    public UnityEngine.GameObject votesLeftGO;
    public UnityEngine.GameObject voteTimeLeftGO;
    public UILabel votePanelVotesCount;
    public UILabel votePanelVoteTimeLeft;
    public TweenScale votePanelVotesCountTween;
    public UnityEngine.Transform ScrollTransform;
    public UnityEngine.Transform scrollViewSelectMapTransform;
    public MapPreviewController selectMap;
    public UISprite fonMapPreview;
    public UISprite fonMapPreviewPrivate;
    public UnityEngine.GameObject localBtn;
    public UnityEngine.GameObject alternativPanel;
    public UnityEngine.GameObject customBtn;
    public UnityEngine.GameObject randomBtn;
    public UnityEngine.GameObject alternativeWaysContainer;
    public UnityEngine.GameObject customDuelBtn;
    public UnityEngine.GameObject customTeamDuelBtn;
    public LockerSquadButton squadBtn;
    public UnityEngine.Transform hintMapPoint;
    public SelectMapPanel FreePlayMapPanel;
    public SelectMapPanel ArmRaceMapPanel;
    public UnityEngine.GameObject armRaceContainer;
    
    // Properties
    internal static ConnectSceneSelectMap 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static ConnectSceneSelectMap 丑七不且上丗丁一世()
    {
        var val_13;
        ConnectSceneSelectMap val_14;
        var val_15;
        UnityEngine.GameObject val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = null;
        val_13 = null;
        val_14 = ConnectSceneSelectMap.丝业丆丁业三丈丟东;
        if(val_14 == 0)
        {
                val_15 = static_value_081DACA8;
            val_15 = static_value_081DACA8;
            val_14 = mem[static_value_081DACA8 + 184 + 16];
            val_14 = static_value_081DACA8 + 184 + 16;
            if(val_14 != 0)
        {
                UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  "ConnectScene/SelectMap");
            if(val_3 != null)
        {
                val_3 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
            val_17 = null;
            val_17 = null;
            ConnectSceneSelectMap.丝业丆丁业三丈丟东 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_16).GetComponent<ConnectSceneSelectMap>();
            val_18 = static_value_081DACA8;
            val_18 = static_value_081DACA8;
            ConnectSceneSelectMap.丝业丆丁业三丈丟东.transform.parent = static_value_081DACA8 + 184 + 16.transform.GetChild(index:  0);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            ConnectSceneSelectMap.丝业丆丁业三丈丟东.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_14 = ConnectSceneSelectMap.丝业丆丁业三丈丟东.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_14.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        return (ConnectSceneSelectMap)ConnectSceneSelectMap.丝业丆丁业三丈丟东;
    }
    public UnityEngine.Transform GetMapCell(int 丛且丞与丕业下丏丞)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Collections.IEnumerator val_2 = this.grid.transform.GetEnumerator();
        label_28:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = val_2.Current;
        val_15 = 0;
        if((val_15.GetComponent<MapPreviewController>()) == 0)
        {
            goto label_28;
        }
        
        var val_12 = (丛且丞与丕业下丏丞 == 1) ? 1 : 0;
        val_12 = val_12 & (UnityEngine.Object.op_Equality(x:  val_9.curSceneInfo, y:  0));
        if(val_12 != true)
        {
                if((val_9.curSceneInfo == 0) || (val_9.curSceneInfo.indexMap != 丛且丞与丕业下丏丞))
        {
            goto label_28;
        }
        
        }
        
        val_16 = 0;
        val_17 = 0;
        val_18 = 133;
        goto label_30;
        label_8:
        val_16 = 0;
        val_17 = 0;
        val_15 = 0;
        val_18 = 131;
        label_30:
        if(val_2 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
        }
        
        if( == 1)
        {
            goto label_47;
        }
        
        if(131 == 133)
        {
                return (UnityEngine.Transform)val_15;
        }
        
        val_15 = 0;
        if( == false)
        {
                return (UnityEngine.Transform)val_15;
        }
        
        if(131 != 131)
        {
            goto label_50;
        }
        
        return (UnityEngine.Transform)val_15;
        label_47:
        if( == false)
        {
            goto label_52;
        }
        
        label_50:
        label_52:
        val_15 = 0;
        return (UnityEngine.Transform)val_15;
    }
    public void SetWideBg(bool 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑 = (~三丟东丕丄丄下下丑) & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.fonMapPreview, 丏业丟一东丂东丘丛:  三丟东丕丄丄下下丑);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.fonMapPreviewPrivate, 丏业丟一东丂东丘丛:  三丟东丕丄丄下下丑);
    }
    private void OnEnable()
    {
        null = null;
        this.SetWideBg(三丟东丕丄丄下下丑:  GameConnect.丛丑世丕丌上丑丂丈);
    }
    public ConnectSceneSelectMap()
    {
    
    }
    private static ConnectSceneSelectMap()
    {
    
    }

}
