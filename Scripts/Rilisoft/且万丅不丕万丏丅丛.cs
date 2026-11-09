using UnityEngine;

namespace Rilisoft
{
    internal static class 且万丅不丕万丏丅丛
    {
        // Fields
        internal static readonly string 丑专丑专与丐且丒丒;
        internal static readonly string 丙三丌与丆丄丁与丅;
        internal static readonly string 业丛丁丏业丙业下丏;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Rilisoft.LobbyItemPlayerLockerInfo 丟不丏丙丘且东丂丟)
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_2 = null;
            val_2 = null;
            val_1.Add(key:  Rilisoft.且万丅不丕万丏丅丛.丑专丑专与丐且丒丒, value:  丟不丏丙丘且东丂丟.IsComplete);
            val_1.Add(key:  Rilisoft.且万丅不丕万丏丅丛.丙三丌与丆丄丁与丅, value:  丟不丏丙丘且东丂丟.PointsGained);
            val_1.Add(key:  Rilisoft.且万丅不丕万丏丅丛.业丛丁丏业丙业下丏, value:  丟不丏丙丘且东丂丟.Type);
            return val_1;
        }
        internal static Rilisoft.LobbyItemPlayerLockerInfo 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_8 = null;
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Boolean>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.且万丅不丕万丏丅丛.丑专丑专与丐且丒丒, 丙业与丙丗丝不丈东: out  (Rilisoft.LobbyItemPlayerLockerInfo)[1152921543075634384].IsComplete);
            bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.且万丅不丕万丏丅丛.丙三丌与丆丄丁与丅, 丙业与丙丗丝不丈东: out  (Rilisoft.LobbyItemPlayerLockerInfo)[1152921543075634384].PointsGained);
            bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<下专丕丐丌丂丑丄丒>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.且万丅不丕万丏丅丛.业丛丁丏业丙业下丏, 丙业与丙丗丝不丈东: out  (Rilisoft.LobbyItemPlayerLockerInfo)[1152921543075634384].Type);
            return (Rilisoft.LobbyItemPlayerLockerInfo)new Rilisoft.LobbyItemPlayerLockerInfo();
        }
        private static 且万丅不丕万丏丅丛()
        {
            Rilisoft.且万丅不丕万丏丅丛.丑专丑专与丐且丒丒 = "c";
            Rilisoft.且万丅不丕万丏丅丛.丙三丌与丆丄丁与丅 = "pg";
            Rilisoft.且万丅不丕万丏丅丛.业丛丁丏业丙业下丏 = "t";
        }
    
    }

}
