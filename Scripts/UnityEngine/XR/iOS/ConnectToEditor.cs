using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class ConnectToEditor : MonoBehaviour
    {
        // Fields
        private UnityEngine.Networking.PlayerConnection.PlayerConnection 丑丕丅世上丂世丟业;
        private UnityEngine.XR.iOS.丐七丆七丑丞丄丘上 万一丘丁且丅丈丞东;
        private int 丆丙丒丞不东万且上;
        private UnityEngine.Texture2D 一业丘丝丝丒七丘世;
        
        // Methods
        private void Start()
        {
            UnityEngine.Debug.Log(message:  "STARTING ConnectToEditor");
            this.丆丙丒丞不东万且上 = 0;
            UnityEngine.Networking.PlayerConnection.PlayerConnection val_1 = UnityEngine.Networking.PlayerConnection.PlayerConnection.instance;
            this.丑丕丅世上丂世丟业 = val_1;
            val_1.RegisterConnection(callback:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void UnityEngine.XR.iOS.ConnectToEditor::业丐丙丐丁万丈丄专(int 业上上丏丄不上丅丈)));
            UnityEngine.Events.UnityAction<System.Int32> val_3 = new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void UnityEngine.XR.iOS.ConnectToEditor::业丌丙专七上业丑丟(int 业上上丏丄不上丅丈));
            this.丑丕丅世上丂世丟业.RegisterDisconnection(callback:  val_3);
            System.Guid val_4 = UnityEngine.XR.iOS.东丂东上三丄七丕上.丌丞丟丟丂丈丟丅与();
            UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>(object:  this, method:  System.Void UnityEngine.XR.iOS.ConnectToEditor::世且不世丟丑丏一丅(UnityEngine.Networking.PlayerConnection.MessageEventArgs 丁丌万丂丝下丄丁丝));
            this.丑丕丅世上丂世丟业.Register(messageId:  new System.Guid(), callback:  val_3);
            this.万一丘丁且丅丈丞东 = 0;
        }
        private void OnGUI()
        {
            if(this.万一丘丁且丅丈丞东 != null)
            {
                    return;
            }
            
            this = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (this < 0) ? (this + 1) : (this);
            val_3 = val_3 >> 1;
            var val_4 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_3 = val_3 - 200;
            val_4 = val_4 >> 1;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Waiting for editor connection...");
        }
        private void 世且不世丟丑丏一丅(UnityEngine.Networking.PlayerConnection.MessageEventArgs 丁丌万丂丝下丄丁丝)
        {
            System.Guid val_4;
            if((ARKitPlugin.Utils.丆丙下与丛专丙丒丁.丂东专丙丒丏且丛丁<ARKitPlugin.Utils.serializableFromEditorMessage>(与丏丝丅专世丘且且:  丁丌万丂丝下丄丁丝.data)) == null)
            {
                    return;
            }
            
            val_4 = val_1.subMessageId;
            System.Guid val_2 = UnityEngine.XR.iOS.丅丙丗丐三丘丘丘丗.万专丟丐专丘万丞世();
            if((System.Guid.op_Equality(a:  new System.Guid(), b:  new System.Guid())) == false)
            {
                    return;
            }
            
            this.业丈丗三丞万丘丂业(世世世丂丏丅丆不业:  val_1.arkitConfigMsg);
        }
        private void 业丈丗三丞万丘丂业(ARKitPlugin.Utils.serializableARKitInit 世世世丂丏丅丆不业)
        {
            UnityEngine.Application.targetFrameRate = 30;
            this.万一丘丁且丅丈丞东 = UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丕丕下丐丟丏三万丄();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕 val_2 = ARKitPlugin.Utils.serializableARSessionConfiguration.万丒丌丕万丏不丈世(丛不与三丌且丄丑且:  世世世丂丏丅丆不业.config);
            this.万一丘丁且丅丈丞东.世丞业不且上丒下丅(上世丏丁世丟世丆业:  new UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕() {世丕七丑丑丟不丙丏 = 世世世丂丏丅丆不业.config, 丂一且丟与丗丗丂丟 = 世世世丂丏丅丆不业.config, 上丆丑丞丄上丘丗下 = 世世世丂丏丅丆不业.config, 七丝专丆丐丗世下一 = 世世世丂丏丅丆不业.config}, 万丙丄丘万丄丅世且:  0 & 4294967295);
            mem[1152921540744977808] = this;
            mem[1152921540744977816] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARFrameUpdated(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈);
            mem[1152921540744977792] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARFrameUpdated(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.世上一丆丗丛东丗七(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.三丐丘丟丅丌丏三专());
            mem[1152921540744981904] = this;
            mem[1152921540744981912] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorAdded(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            mem[1152921540744981888] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorAdded(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丙业丝与丌与丑丙丑(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.丅不业丛丈丅东丄丕());
            mem[1152921540744986000] = this;
            mem[1152921540744986008] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorUpdated(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            mem[1152921540744985984] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorUpdated(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丈东世丄万且下东世(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.与专丏丙丂丛丗专丗());
            mem[1152921540744990096] = this;
            mem[1152921540744990104] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorRemoved(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            mem[1152921540744990080] = public System.Void UnityEngine.XR.iOS.ConnectToEditor::ARAnchorRemoved(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅);
            UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丈丑丕丕丙丝三丁丘(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.与丈世与丝与丄专万());
        }
        public void ARFrameUpdated(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈)
        {
            System.Guid val_2 = UnityEngine.XR.iOS.东丂东上三丄七丕上.丏丗上丌丑丛与丕三();
            System.Byte[] val_3 = ARKitPlugin.Utils.丆丙下与丛专丙丒丁.且一且丗业万丛上丑(万且万且丑丗且丌丆:  ARKitPlugin.Utils.serializableUnityARCamera.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.丂与与丞丈三专丈丅() {三丏丅丒丛丕下且万 = new UnityEngine.XR.iOS.上丆上丕丞专丙丛丆() {丟世上丝下丏丛丆丁 = new UnityEngine.Vector4(), 七且丞丈万丌万丙下 = new UnityEngine.Vector4(), 一丛万丕与丌丞丝东 = new UnityEngine.Vector4(), 下且丂丐东世世丑下 = new UnityEngine.Vector4()}, 上东丏丐业丂丛业业 = new UnityEngine.XR.iOS.上丆上丕丞专丙丛丆() {丟世上丝下丏丛丆丁 = new UnityEngine.Vector4(), 七且丞丈万丌万丙下 = new UnityEngine.Vector4(), 一丛万丕与丌丞丝东 = new UnityEngine.Vector4(), 下且丂丐东世世丑下 = new UnityEngine.Vector4()}, 丄丄七上上丟丑丝丟 = new UnityEngine.XR.iOS.UnityVideoParams(), 丟世七丆一七丛丁下 = new UnityEngine.XR.iOS.UnityARLightEstimate(), 丐丟世上丙丟一三丏 = ???}));
            this.SendToEditor(丈与世世丙丙世丆丟:  new System.Guid(), 一丐丗丁丞丆丅丟丄:  0);
        }
        public void ARAnchorAdded(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅)
        {
            System.Guid val_2 = UnityEngine.XR.iOS.东丂东上三丄七丕上.丂丞丅丈业丞业丐丅();
            System.Byte[] val_3 = ARKitPlugin.Utils.丆丙下与丛专丙丒丁.且一且丗业万丛上丑(万且万且丑丗且丌丆:  ARKitPlugin.Utils.serializableUnityARPlaneAnchor.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.丆丂下丒丐丘上丄万() {不丂丅丁且丆东东丂 = new UnityEngine.Matrix4x4(), 丙丂丂业丂丁丌丂下 = new UnityEngine.Vector3(), 不东丈丟丅丂丝下下 = new UnityEngine.Vector3()}));
            this.SendToEditor(丈与世世丙丙世丆丟:  new System.Guid(), 一丐丗丁丞丆丅丟丄:  0);
        }
        public void ARAnchorUpdated(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅)
        {
            System.Guid val_2 = UnityEngine.XR.iOS.东丂东上三丄七丕上.万一丐丆丁三东丛且();
            System.Byte[] val_3 = ARKitPlugin.Utils.丆丙下与丛专丙丒丁.且一且丗业万丛上丑(万且万且丑丗且丌丆:  ARKitPlugin.Utils.serializableUnityARPlaneAnchor.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.丆丂下丒丐丘上丄万() {不丂丅丁且丆东东丂 = new UnityEngine.Matrix4x4(), 丙丂丂业丂丁丌丂下 = new UnityEngine.Vector3(), 不东丈丟丅丂丝下下 = new UnityEngine.Vector3()}));
            this.SendToEditor(丈与世世丙丙世丆丟:  new System.Guid(), 一丐丗丁丞丆丅丟丄:  0);
        }
        public void ARAnchorRemoved(UnityEngine.XR.iOS.丆丂下丒丐丘上丄万 丞东业丟专下上丏丅)
        {
            System.Guid val_2 = UnityEngine.XR.iOS.东丂东上三丄七丕上.丕专丘丁一丛丏丆一();
            System.Byte[] val_3 = ARKitPlugin.Utils.丆丙下与丛专丙丒丁.且一且丗业万丛上丑(万且万且丑丗且丌丆:  ARKitPlugin.Utils.serializableUnityARPlaneAnchor.万丒丌丕万丏不丈世(上下且万丌下丆丞丅:  new UnityEngine.XR.iOS.丆丂下丒丐丘上丄万() {不丂丅丁且丆东东丂 = new UnityEngine.Matrix4x4(), 丙丂丂业丂丁丌丂下 = new UnityEngine.Vector3(), 不东丈丟丅丂丝下下 = new UnityEngine.Vector3()}));
            this.SendToEditor(丈与世世丙丙世丆丟:  new System.Guid(), 一丐丗丁丞丆丅丟丄:  0);
        }
        private void 业丐丙丐丁万丈丄专(int 业上上丏丄不上丅丈)
        {
            UnityEngine.Debug.Log(message:  "connected");
            this.丆丙丒丞不东万且上 = 业上上丏丄不上丅丈;
        }
        private void 业丌丙专七上业丑丟(int 业上上丏丄不上丅丈)
        {
            if(this.丆丙丒丞不东万且上 == 业上上丏丄不上丅丈)
            {
                    this.丆丙丒丞不东万且上 = 0;
            }
            
            this.DisconnectFromEditor();
            if(this.万一丘丁且丅丈丞东 == null)
            {
                    return;
            }
            
            this.万一丘丁且丅丈丞东.世上专丐丂业世世丂();
            this.万一丘丁且丅丈丞东 = 0;
        }
        public void SendToEditor(System.Guid 丈与世世丙丙世丆丟, object 丌丅东业丑丏丟丙七)
        {
            System.Byte[] val_1 = ARKitPlugin.Utils.丆丙下与丛专丙丒丁.且一且丗业万丛上丑(万且万且丑丗且丌丆:  X3);
            this.SendToEditor(丈与世世丙丙世丆丟:  new System.Guid(), 一丐丗丁丞丆丅丟丄:  丌丅东业丑丏丟丙七);
        }
        public void SendToEditor(System.Guid 丈与世世丙丙世丆丟, byte[] 一丐丗丁丞丆丅丟丄)
        {
            if(this.丑丕丅世上丂世丟业.isConnected == false)
            {
                    return;
            }
            
            this.丑丕丅世上丂世丟业.Send(messageId:  new System.Guid(), data:  一丐丗丁丞丆丅丟丄);
        }
        public void DisconnectFromEditor()
        {
            this.丑丕丅世上丂世丟业.DisconnectAll();
        }
        public ConnectToEditor()
        {
        
        }
    
    }

}
