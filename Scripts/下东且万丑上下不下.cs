using UnityEngine;
private class 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下
{
    // Methods
    internal System.Threading.Tasks.Task<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 丑丝专丌一丒丂丅丛(PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丘丙业丕不上丙丏丄, System.Threading.CancellationToken 不丒三业下丑不丞业)
    {
        System.Threading.Tasks.TaskCompletionSource<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> val_1 = new System.Threading.Tasks.TaskCompletionSource<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不>();
        if(丘丙业丕不上丙丏丄 != null)
        {
                UnityEngine.Coroutine val_3 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_1.丆七一丂且丝业丒丌(丘丙业丕不上丙丏丄:  丘丙业丕不上丙丏丄, 三丈丅丕丕丘丈丐丞:  val_1, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = 不丒三业下丑不丞业.m_source}));
            if(val_1 != null)
        {
                return val_1.Task;
        }
        
            return val_1.Task;
        }
        
        if(val_1 != null)
        {
                val_1.SetCanceled();
            return val_1.Task;
        }
        
        val_1.SetCanceled();
        return val_1.Task;
    }
    private System.Collections.IEnumerator 丆七一丂且丝业丒丌(PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丘丙业丕不上丙丏丄, System.Threading.Tasks.TaskCompletionSource<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 三丈丅丕丕丘丈丐丞, System.Threading.CancellationToken 不丒三业下丑不丞业)
    {
        丟丘丈丄丟丙丐丞丈.下东且万丑上下不下.丛丘专丙三丑世丑上 val_1 = new 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下.丛丘专丙三丑世丑上();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丘丙业丕不上丙丏丄 = 丘丙业丕不上丙丏丄;
            .三丈丅丕丕丘丈丐丞 = 三丈丅丕丕丘丈丐丞;
        }
        else
        {
                mem[32] = 丘丙业丕不上丙丏丄;
            mem[48] = 三丈丅丕丕丘丈丐丞;
        }
        
        .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
        return (System.Collections.IEnumerator)val_1;
    }
    public 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下()
    {
    
    }

}
