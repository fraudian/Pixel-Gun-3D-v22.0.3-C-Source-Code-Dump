using UnityEngine;
internal class MinigameScoreTable : MonoBehaviour
{
    // Fields
    internal static MinigameScoreTable 丄丘七三上丕世丞业;
    public System.Collections.Generic.List<MinigameScoreTableItem> listRecords;
    public UnityEngine.GameObject tableHolder;
    private int 丑丞丐丕东丘丙业丗;
    private UnityEngine.Coroutine 丛丁业丘丘且一丝下;
    private UnityEngine.Coroutine 不丏丌丑七丛丁丟且;
    
    // Methods
    private void Awake()
    {
        null = null;
        MinigameScoreTable.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        var val_3;
        if(this.丛丁业丘丘且一丝下 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丛丁业丘丘且一丝下);
            this.丛丁业丘丘且一丝下 = 0;
        }
        
        if(this.不丏丌丑七丛丁丟且 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.不丏丌丑七丛丁丟且);
            this.不丏丌丑七丛丁丟且 = 0;
        }
        
        val_3 = null;
        val_3 = null;
        MinigameScoreTable.丄丘七三上丕世丞业 = 0;
    }
    internal void 七丏丆与丞丏丟七丁(bool 丛与丙丒丒下丌丟且)
    {
        丛与丙丒丒下丌丟且 = 丛与丙丒丒下丌丟且;
        this.tableHolder.SetActive(value:  丛与丙丒丒下丌丟且);
    }
    internal void 上丙上丈三丐丞丛专(NetworkStartTable 不且上一上丐三万丛)
    {
        NetworkStartTable val_3;
        System.Collections.Generic.List<MinigameScoreTableItem> val_4;
        val_3 = 不且上一上丐三万丛;
        val_4 = this.listRecords;
        this.丑丞丐丕东丘丙业丗 = 0;
        List.Enumerator<T> val_1 = val_4.GetEnumerator();
        label_4:
        if((1256518936 & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        int val_3 = this.丑丞丐丕东丘丙业丗;
        val_3 = val_3 + 1;
        this.丑丞丐丕东丘丙业丗 = val_3;
        if(val_3 != 0)
        {
            goto label_4;
        }
        
        val_4.世丏丟世丈丒丏业丑(不且上一上丐三万丛:  val_3);
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丒下丝下丒丟丞丆丞(NetworkStartTable 不且上一上丐三万丛)
    {
        List.Enumerator<T> val_1 = this.listRecords.GetEnumerator();
        label_5:
        if((1256659608 & 1) == 0)
        {
            goto label_2;
        }
        
        if((System.String.op_Equality(a:  static_value_082C4000, b:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == false)
        {
            goto label_5;
        }
        
        0.丐丏七丌丕丗业且上().世丏丟世丈丒丏业丑(不且上一上丐三万丛:  0);
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 专且世丘且丗万丄丁(bool 专下丞下七丏丁丐一)
    {
        if(专下丞下七丏丁丐一 != false)
        {
                if(this.丛丁业丘丘且一丝下 != null)
        {
                return;
        }
        
            this.丛丁业丘丘且一丝下 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丟丒丘丂丅丅万丝丅());
            return;
        }
        
        if(this.丛丁业丘丘且一丝下 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丛丁业丘丘且一丝下);
        this.丛丁业丘丘且一丝下 = 0;
    }
    private System.Collections.IEnumerator 丟丒丘丂丅丅万丝丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MinigameScoreTable.七丄丐三万丟七丈丞();
    }
    private void 丄丄与丗专七丐丒东(int 丟丅丕万万丛丗丞丆, int 丐丒丗与丝丑丛七丝)
    {
        MinigameScoreTableItem val_1 = this.listRecords.Item[丟丅丕万万丛丗丞丆];
        MinigameScoreTableItem val_3 = this.listRecords.Item[丐丒丗与丝丑丛七丝];
        this.listRecords.Item[丟丅丕万万丛丗丞丆].世丏丟世丈丒丏业丑(不且上一上丐三万丛:  val_3.业丒丅上世丂世一丁);
        this.listRecords.Item[丐丒丗与丝丑丛七丝].世丏丟世丈丒丏业丑(不且上一上丐三万丛:  val_1.业丒丅上世丂世一丁);
    }
    internal void 下丞丈丒丁丄世世与(bool 专下丞下七丏丁丐一)
    {
        if(专下丞下七丏丁丐一 != false)
        {
                if(this.不丏丌丑七丛丁丟且 != null)
        {
                return;
        }
        
            this.不丏丌丑七丛丁丟且 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丗丞丟丒丕丆万丒丛());
            return;
        }
        
        if(this.不丏丌丑七丛丁丟且 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.不丏丌丑七丛丁丟且);
        this.不丏丌丑七丛丁丟且 = 0;
    }
    internal void 三丂且丂丌丌丒丞丐()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_6 = 0;
        goto label_6;
        label_17:
        val_7 = null;
        val_7 = null;
        this.listRecords.Item[0].丅专丅丐且丒丟丌万(东一丁世丑丞业丄丐:  Item[0]);
        val_6 = 1;
        label_6:
        val_8 = null;
        val_8 = null;
        if(val_6 < Count)
        {
            goto label_17;
        }
    
    }
    private System.Collections.IEnumerator 丗丞丟丒丕丆万丒丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MinigameScoreTable.丑丗万丛丆丂丙不下();
    }
    private bool 一一丏东丙丒丘丟丁(int 丟丅丕万万丛丗丞丆, int 丐丒丗与丝丑丛七丝)
    {
        int val_7;
        int val_8;
        var val_9;
        val_7 = 丐丒丗与丝丑丛七丝;
        val_8 = 丟丅丕万万丛丗丞丆;
        MinigameScoreTableItem val_1 = this.listRecords.Item[val_7];
        if((val_1.<丞丁丙丏七丆与世丅>k__BackingField) == false)
        {
            goto label_3;
        }
        
        MinigameScoreTableItem val_2 = this.listRecords.Item[val_8];
        if((val_2.<丞丁丙丏七丆与世丅>k__BackingField) == false)
        {
            goto label_6;
        }
        
        label_3:
        MinigameScoreTableItem val_3 = this.listRecords.Item[val_8];
        val_7 = this.listRecords.Item[val_7];
        if((val_3.<下业丛丑丅丛与丙丂>k__BackingField) < (val_4.<下业丛丑丅丛与丙丂>k__BackingField))
        {
                val_8 = this.listRecords.Item[val_8];
            var val_6 = ((val_5.<丞丁丙丏七丆与世丅>k__BackingField) == false) ? 1 : 0;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
        label_6:
        val_9 = 1;
        return (bool)val_9;
    }
    private void 业一丐丏七万一世三(int 丟丅丕万万丛丗丞丆, int 丐丒丗与丝丑丛七丝)
    {
        MinigameScoreTableItem val_1 = this.listRecords.Item[丟丅丕万万丛丗丞丆];
        MinigameScoreTableItem val_3 = this.listRecords.Item[丐丒丗与丝丑丛七丝];
        this.listRecords.Item[丟丅丕万万丛丗丞丆].丁丒下且丗丈丑丛丂(不且上一上丐三万丛:  val_3.业丒丅上世丂世一丁);
        this.listRecords.Item[丐丒丗与丝丑丛七丝].丁丒下且丗丈丑丛丂(不且上一上丐三万丛:  val_1.业丒丅上世丂世一丁);
    }
    public MinigameScoreTable()
    {
        this.listRecords = new System.Collections.Generic.List<MinigameScoreTableItem>();
    }
    private static MinigameScoreTable()
    {
    
    }

}
