using UnityEngine;

namespace Rilisoft
{
    public class 七丙专丝东丟业丘东
    {
        // Fields
        internal const string 且丟丟丆上丘三与不 = "bundle_government";
        internal const string 丅丁丑丘东丗丑丄丙 = "recommend-lobby-bundles";
        private static Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.七丙专丝东丟业丘东> 丝业丆丁业三丈丟东;
        private Rilisoft.且丈丞一丞丟与上七 下丂三丈丞且丌丏丏;
        private System.DateTime 丕丌丄丁丏丆一丐丕;
        
        // Properties
        internal static Rilisoft.七丙专丝东丟业丘东 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static Rilisoft.七丙专丝东丟业丘东 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.七丙专丝东丟业丘东.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.七丙专丝东丟业丘东.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.七丙专丝东丟业丘东.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        public bool 丛丌丌丒三丕丒丐丘()
        {
            System.DateTime val_8;
            var val_9;
            val_8 = this;
            if((Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝() != false) && (FriendsController.丝丗专上三不丄丑丑() >= 1))
            {
                    System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
                val_8 = this.丕丌丄丁丏丆一丐丕;
                if((System.DateTime.op_LessThan(t1:  new System.DateTime() {}, t2:  new System.DateTime() {dateData = val_8})) != false)
            {
                    val_8 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                val_9 = (val_8.丕丌丈丏丙丁丟东丘(丞一丁业丄一一业且:  "bundle_government")) ^ 1;
                return (bool)val_9 & 1;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        public 七丙专丝东丟业丘东()
        {
            this.下丂三丈丞且丌丏丏 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "LobbyBundlesRecommender-_showStartTime");
            this.丕丌丄丁丏丆一丐丕 = 0;
        }
        private static 七丙专丝东丟业丘东()
        {
            null = null;
            Rilisoft.七丙专丝东丟业丘东.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.七丙专丝东丟业丘东>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.七丙专丝东丟业丘东>(object:  七丙专丝东丟业丘东.<>c.<>9, method:  Rilisoft.七丙专丝东丟业丘东 七丙专丝东丟业丘东.<>c::丈丘丒不丐丅丒与专()));
        }
    
    }

}
