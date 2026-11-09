using UnityEngine;

namespace PGCompany.MatchmakingRequest
{
    internal class 丟丘丈丄丟丙丐丞丈
    {
        // Fields
        private static PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 世丒丞七专三与万丕;
        private System.Threading.Tasks.Task<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 万丗丞专三丑且丅三;
        private System.Threading.CancellationTokenSource 东丛三丟丝不丒丈丅;
        private const int 丂世丄丏世丟丏丄丈 = 2600;
        private 与丟丆一七丛丆且丟 下丅丒丛三且不丆丙;
        
        // Properties
        internal static PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 丆丕丝丒不丙且丐丗 { get; }
        internal 与丟丆一七丛丆且丟 与丟丆一七丛丆且丟 { get; }
        
        // Methods
        internal static PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 丑七不且上丗丁一世()
        {
            int val_2 = PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丂世丄丏世丟丏丄丈;
            if(val_2 != 0)
            {
                    return val_2;
            }
            
            PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈();
            PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丂世丄丏世丟丏丄丈 = val_2;
            return val_2;
        }
        internal 与丟丆一七丛丆且丟 业丄丑七上专万七丘()
        {
            与丟丆一七丛丆且丟 val_4 = this.下丅丒丛三且不丆丙;
            if(val_4 == null)
            {
                    return val_4;
            }
            
            int val_4 = val_4.丘丝丄丁丑丙不不丅();
            val_4 = val_4 - PixelTime.丙丅丅业丟丁世丁丗();
            Rilisoft.七丕丟丏三丈一丄世 val_3 = this.下丅丒丛三且不丆丙.丘丛丆丕且丂业世丌();
            if(val_3 > 5)
            {
                goto label_6;
            }
            
            var val_5 = 1;
            val_5 = val_5 << val_3;
            val_5 = val_5 & 53;
            if(val_5 == 0)
            {
                goto label_6;
            }
            
            if(val_4 > 29)
            {
                goto label_7;
            }
            
            label_9:
            val_4 = 0;
            return val_4;
            label_6:
            if((val_4 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            label_7:
            val_4 = this.下丅丒丛三且不丆丙;
            return val_4;
        }
        internal 丟丘丈丄丟丙丐丞丈()
        {
            var val_5;
            业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈::下丅东丏与丛与三丌()));
            val_5 = null;
            val_5 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丛七下丗丞万丞丌且, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈::世七世丆东丕万下且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
            if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
            {
                    return;
            }
            
            this.下丅东丏与丛与三丌();
        }
        internal static void 东丝七业丄丑丒世七()
        {
            PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 val_2;
            if(PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丂世丄丏世丟丏丄丈 != 0)
            {
                    return;
            }
            
            PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈();
            PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丂世丄丏世丟丏丄丈 = val_2;
        }
        internal System.Threading.Tasks.Task<与丟丆一七丛丆且丟> 丆不丘上丐丗东丁丘()
        {
            System.Threading.Tasks.TaskCompletionSource<与丟丆一七丛丆且丟> val_1 = new System.Threading.Tasks.TaskCompletionSource<与丟丆一七丛丆且丟>();
            UnityEngine.Coroutine val_3 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_1.丈世业丑丏丟专丌一(专丒丅丗不丟丕业丞:  val_1));
            if(val_1 != null)
            {
                    return val_1.Task;
            }
            
            return val_1.Task;
        }
        private System.Collections.IEnumerator 丈世业丑丏丟专丌一(System.Threading.Tasks.TaskCompletionSource<与丟丆一七丛丆且丟> 专丒丅丗不丟丕业丞)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .专丒丅丗不丟丕业丞 = 专丒丅丗不丟丕业丞;
            return (System.Collections.IEnumerator)new 丟丘丈丄丟丙丐丞丈.一万丅下世且世丅丆();
        }
        internal System.Threading.Tasks.Task<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 丑丝专丌一丒丂丅丛(PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丘丙业丕不上丙丏丄)
        {
            if(this.东丛三丟丝不丒丈丅 != null)
            {
                    this.东丛三丟丝不丒丈丅.Cancel();
            }
            
            this.东丛三丟丝不丒丈丅 = new System.Threading.CancellationTokenSource();
            System.Threading.CancellationToken val_3 = this.东丛三丟丝不丒丈丅.Token;
            System.Threading.Tasks.Task<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> val_4 = new 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下().丑丝专丌一丒丂丅丛(丘丙业丕不上丙丏丄:  丘丙业丕不上丙丏丄, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_3.m_source});
            this.万丗丞专三丑且丅三 = val_4;
            return val_4;
        }
        internal void 丙世丙丙东丆丙丁丅()
        {
            var val_4 = null;
            int val_3 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙丈万不丛下丅丑世, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈::业丒丐下丗业一且专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private void 业丒丐下丗业一且专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            int val_1 = 0;
            if(丑与丂丌世丕丆一丗 == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_1)) == false)
            {
                    return;
            }
            
            if(val_1 != 2600)
            {
                    return;
            }
            
            PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.丙丂东丝丝丁丏丑丐(丝三丄专丗丞丄丄丌:  new System.Nullable<System.Boolean>() {HasValue = false}, 丒丐丌丒丞丐丗七业:  0);
        }
        private void 下丅东丏与丛与三丌()
        {
            var val_4 = null;
            Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丛七下丗丞万丞丌且);
            UnityEngine.Coroutine val_3 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丕一且丒七丛丐丑业());
        }
        private System.Collections.IEnumerator 丕一且丒七丛丐丑业()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丟丘丈丄丟丙丐丞丈.丂丅丅丐丆专丆丞丏();
        }
        private void 世七世丆东丕万下且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            var val_8;
            var val_9;
            int val_1 = 0;
            int val_3 = 0;
            int val_5 = 0;
            if(((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_1)) != false) && (val_1 == 2600))
            {
                    val_8 = 0;
                val_9 = 0;
            }
            else
            {
                    bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "mm_state", 丙业与丙丗丝不丈东: out  val_3);
                bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "sync_id", 丙业与丙丗丝不丈东: out  val_5);
                var val_7 = (val_3 != 0) ? 1 : 0;
                val_9 = val_5;
                val_8 = 0;
            }
            
            PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.丙丂东丝丝丁丏丑丐(丝三丄专丗丞丄丄丌:  new System.Nullable<System.Boolean>() {HasValue = false}, 丒丐丌丒丞丐丗七业:  0);
        }
    
    }

}
