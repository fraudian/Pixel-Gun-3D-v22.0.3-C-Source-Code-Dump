using UnityEngine;

namespace PGCompany
{
    internal class BaseDebugWindow : PGBehaviour
    {
        // Methods
        internal void 丙七业丂丒且丞丂丁(System.Action<BestHTTP.SocketIO.SocketManager.States> 丗丙丅世丒与丒丗丂)
        {
            var val_6;
            System.Func<Rilisoft.WebSocket.WebSocketManager, BestHTTP.SocketIO.SocketManager> val_8;
            var val_9;
            System.Func<BestHTTP.SocketIO.SocketManager, States> val_11;
            val_6 = null;
            val_6 = null;
            val_8 = BaseDebugWindow.<>c.<>9__0_0;
            if(val_8 == null)
            {
                    System.Func<Rilisoft.WebSocket.WebSocketManager, BestHTTP.SocketIO.SocketManager> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<Rilisoft.WebSocket.WebSocketManager, BestHTTP.SocketIO.SocketManager>(object:  BaseDebugWindow.<>c.__il2cppRuntimeField_static_fields, method:  BestHTTP.SocketIO.SocketManager BaseDebugWindow.<>c::丗丈丄丞丘丆与上丅(Rilisoft.WebSocket.WebSocketManager 三丟东丕丄丄下下丑));
                BaseDebugWindow.<>c.<>9__0_0 = val_8;
            }
            
            val_9 = null;
            val_9 = null;
            val_11 = BaseDebugWindow.<>c.<>9__0_1;
            if(val_11 == null)
            {
                    System.Func<BestHTTP.SocketIO.SocketManager, States> val_4 = null;
                val_11 = val_4;
                val_4 = new System.Func<BestHTTP.SocketIO.SocketManager, States>(object:  BaseDebugWindow.<>c.__il2cppRuntimeField_static_fields, method:  States BaseDebugWindow.<>c::丛丝上万世丞丘丐东(BestHTTP.SocketIO.SocketManager 三丟东丕丄丄下下丑));
                BaseDebugWindow.<>c.<>9__0_1 = val_11;
            }
            
            if(丗丙丅世丒与丒丗丂 == null)
            {
                    return;
            }
            
            丗丙丅世丒与丒丗丂.Invoke(obj:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<States, BestHTTP.SocketIO.SocketManager>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<BestHTTP.SocketIO.SocketManager, Rilisoft.WebSocket.WebSocketManager>(丞下万上三丘上与专:  Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance, 丏丅丁丛一业丈专专:  val_2), 丏丅丁丛一业丈专专:  val_4));
        }
        public BaseDebugWindow()
        {
        
        }
    
    }

}
