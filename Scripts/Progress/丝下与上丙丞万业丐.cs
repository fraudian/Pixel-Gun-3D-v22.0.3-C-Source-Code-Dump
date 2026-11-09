using UnityEngine;

namespace Progress
{
    internal static class 丝下与上丙丞万业丐
    {
        // Fields
        private static System.Threading.Tasks.TaskCompletionSource<bool> 东东三三丞不丌丄丕;
        
        // Methods
        internal static System.Threading.Tasks.Task<bool> 专专丞丁丁下丈专专(System.Collections.Generic.Dictionary<string, object> 万丈与万丑丛与一且)
        {
            var val_6;
            System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_1 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
            Progress.丝下与上丙丞万业丐.东东三三丞不丌丄丕 = val_1;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_2.set_Item(key:  "slots", value:  万丈与万丑丛与一且);
            val_6 = null;
            val_6 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丙丞与丞丝丂丑丝, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void Progress.丝下与上丙丞万业丐::丆万东下丗与下丙丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
            int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丙丞与丞丝丂丑丝, 一丐丗丁丞丆丅丟丄:  val_2);
            if(Progress.丝下与上丙丞万业丐.东东三三丞不丌丄丕 != null)
            {
                    return val_1.Task;
            }
            
            return val_1.Task;
        }
        private static void 丆万东下丗与下丙丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
                UnityEngine.Debug.LogError(message:  "Create slots socket event was failed. See socket logs for details.");
                return;
            }
            
            if(Progress.丝下与上丙丞万业丐.东东三三丞不丌丄丕 == null)
            {
                    return;
            }
            
            bool val_3 = Progress.丝下与上丙丞万业丐.东东三三丞不丌丄丕.TrySetResult(result:  true);
        }
    
    }

}
