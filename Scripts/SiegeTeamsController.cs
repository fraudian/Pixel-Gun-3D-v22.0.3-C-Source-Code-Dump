using UnityEngine;
public class SiegeTeamsController : MonoBehaviour
{
    // Fields
    public SiegeCharacterPoint[] blueTeamPoints;
    public SiegeCharacterPoint[] redTeamPoints;
    
    // Methods
    private void Awake()
    {
    
    }
    internal void 专丑丗丆丌丛丌丐丆(System.Collections.Generic.List<NetworkStartTable> 丒七丈丏丏与丛丌丘, System.Collections.Generic.List<NetworkStartTable> 丐且丈丝丕丕一丒与, System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丒专丛上丁丗与与丞, System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丈丏丟丅丕业丆丏业)
    {
        SiegeCharacterPoint val_11;
        var val_12;
        SiegeCharacterPoint val_13;
        var val_14;
        var val_15;
        if(丒七丈丏丏与丛丌丘 == null)
        {
            goto label_1;
        }
        
        val_11 = 丒七丈丏丏与丛丌丘.Count;
        if(丐且丈丝丕丕一丒与 == null)
        {
            goto label_2;
        }
        
        label_4:
        int val_2 = 丐且丈丝丕丕一丒与.Count;
        goto label_3;
        label_1:
        val_11 = 0;
        if(丐且丈丝丕丕一丒与 != null)
        {
            goto label_4;
        }
        
        label_2:
        label_3:
        val_12 = 0;
        goto label_5;
        label_13:
        this.blueTeamPoints[0].上东与丛丞下丈专丈(不且上一上丐三万丛:  丒七丈丏丏与丛丌丘.Item[0]);
        val_12 = 1;
        label_5:
        if(val_12 < (UnityEngine.Mathf.Min(a:  this.blueTeamPoints.Length, b:  0)))
        {
            goto label_13;
        }
        
        val_13 = 0;
        goto label_14;
        label_22:
        this.redTeamPoints[0].上东与丛丞下丈专丈(不且上一上丐三万丛:  丐且丈丝丕丕一丒与.Item[0]);
        val_13 = 1;
        label_14:
        if(val_13 < (UnityEngine.Mathf.Min(a:  this.redTeamPoints.Length, b:  0)))
        {
            goto label_22;
        }
        
        val_14 = 0;
        goto label_23;
        label_34:
        if((丒专丛上丁丗与与丞 != null) && (val_14 < 丒专丛上丁丗与与丞.Count))
        {
                val_13 = this.blueTeamPoints[136135488];
            val_13.FillFromPlayerSettings(专丞上七七且丝七丗:  丒专丛上丁丗与与丞.Item[0]);
        }
        else
        {
                val_13 = this.blueTeamPoints[136135488];
            val_13.SetEmpty();
        }
        
        val_14 = 1;
        label_23:
        var val_9 = val_11 + val_14;
        if(val_9 < this.blueTeamPoints.Length)
        {
            goto label_34;
        }
        
        val_15 = 0;
        goto label_35;
        label_46:
        if((丈丏丟丅丕业丆丏业 != 0) && (val_15 < 丈丏丟丅丕业丆丏业.Count))
        {
                val_11 = this.redTeamPoints[(long)val_9];
            val_11.FillFromPlayerSettings(专丞上七七且丝七丗:  丈丏丟丅丕业丆丏业.Item[0]);
        }
        else
        {
                val_11 = this.redTeamPoints[(long)val_9];
            val_11.SetEmpty();
        }
        
        val_15 = 1;
        label_35:
        if((0 + val_15) < this.redTeamPoints.Length)
        {
            goto label_46;
        }
    
    }
    internal void 丘东东丐万丁丆万丈()
    {
    
    }
    public void Clear()
    {
        var val_1;
        var val_2;
        val_1 = 0;
        goto label_0;
        label_5:
        this.blueTeamPoints[0].SetEmpty();
        val_1 = 1;
        label_0:
        if(val_1 < this.blueTeamPoints.Length)
        {
            goto label_5;
        }
        
        val_2 = 0;
        goto label_6;
        label_11:
        this.redTeamPoints[0].SetEmpty();
        val_2 = 1;
        label_6:
        if(val_2 < this.redTeamPoints.Length)
        {
            goto label_11;
        }
    
    }
    public SiegeTeamsController()
    {
    
    }

}
