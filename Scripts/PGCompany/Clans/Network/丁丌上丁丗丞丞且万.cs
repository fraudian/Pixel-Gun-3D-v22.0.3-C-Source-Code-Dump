using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 丁丌上丁丗丞丞且万
    {
        // Fields
        internal static Rilisoft.丝丑丂丛万丐丈丘且 丆与丙上丂且上丗且;
        
        // Methods
        internal 丁丌上丁丗丞丞且万()
        {
            ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Clans.Network.丁丌上丁丗丞丞且万::丂七下丂丂七丈万不()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Clans.Network.丁丌上丁丗丞丞且万::丄且丞专一丆丕丏丝()));
            if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
            {
                    return;
            }
            
            this.丌丁丝丂东丞三丟丛();
        }
        private void 丂七下丂丂七丈万不()
        {
            this.丌丁丝丂东丞三丟丛();
        }
        private void 丄且丞专一丆丕丏丝()
        {
            this.丌丁丝丂东丞三丟丛();
        }
        private void 丌丁丝丂东丞三丟丛()
        {
            string val_11;
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  138)) == false)
            {
                    return;
            }
            
            丞丂丘丒丟丞丑下丄 val_4 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_4 != null)
            {
                    val_11 = val_4.业丐丐三丕一丗丛丁();
            }
            else
            {
                    val_11 = 0;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) != false)
            {
                    return;
            }
            
            string val_8 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  138);
            if((System.String.op_Inequality(a:  val_8, b:  val_11)) != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丗丄万东上丙丁丈(下上丐丆丝丟丝丒不:  138, 丙业与丙丗丝不丈东:  0);
                return;
            }
            
            this.丞丂丝世丈东东丝三(丄丒下业一不丈丝丘:  val_8);
        }
        internal void 丞丂丝世丈东东丝三(string 丄丒下业一不丈丝丘)
        {
            var val_5;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丒下业一不丈丝丘)) != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            int val_4 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丑世上专丒下丗丘与, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.丁丌上丁丗丞丞且万::业下上丏丒丝一丘专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private void 业下上丏丒丝一丘专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            var val_14;
            var val_15;
            ClansWindowGUI val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            int val_1 = 0;
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_1);
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "player_id", 丙业与丙丗丝不丈东: out  val_1);
            val_14 = 0;
            val_15 = 0;
            if((val_14 == 1730) && (0 != 0))
            {
                    val_14 = 0;
            }
            
            if((val_14 != 1400) && (((0 != 专丈专业丆且且业下.丈不丄丛丛丘东丁丙()) ? 1 : 0) == 0))
            {
                    val_16 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_16.丒丗丄万东上丙丁丈(下上丐丆丝丟丝丒不:  138, 丙业与丙丗丝不丈东:  0);
                if(val_14 != 0)
            {
                    return;
            }
            
            }
            else
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  69);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丗丄万东上丙丁丈(下上丐丆丝丟丝丒不:  138, 丙业与丙丗丝不丈东:  0);
                val_17 = null;
                val_17 = null;
                val_18 = null;
                val_18 = null;
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  1063313408, 世丁丙世丄一万丆三:  81, 丛丞万三下丘七丌丅:  true);
                val_16 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_16.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                if(val_14 != 0)
            {
                    return;
            }
            
            }
            
            val_19 = null;
            val_19 = null;
            val_16 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_16 == 0)
            {
                    return;
            }
            
            val_20 = null;
            val_20 = null;
            val_16 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_16.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_16 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_16.ForceShowBanner(丌丅丕一丛丛丄一万:  89, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丘丙丅丌丛丆东丐不 = 1, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private static 丁丌上丁丗丞丞且万()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  80);
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且 = val_1.七丄不丐丗三丝丑一;
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且.__il2cppRuntimeField_3 = val_1.丑丒丄下丁丐专丄丞;
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且.__il2cppRuntimeField_8 = val_1.上万三丆专丏丒丗业;
        }
    
    }

}
