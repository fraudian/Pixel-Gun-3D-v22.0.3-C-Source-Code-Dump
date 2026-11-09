using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 专不万丐丑丑丟丕东
    {
        // Fields
        private static System.Action<string> 丟丁丟丕且不下世一;
        private static System.Action<int> 东上丟丂丕丈上丄丘;
        
        // Methods
        internal static void 丘与丏不万丙丝丟业(System.Action<string> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.Clans.Network.专不万丐丑丑丟丕东.丟丁丟丕且不下世一, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丞三丕丈世丅丘丛与(System.Action<string> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.Clans.Network.专不万丐丑丑丟丕东.丟丁丟丕且不下世一, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丘下丌丐丆专丙丙丐(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘 != 1152921505671118856);
        
        }
        internal static void 专丞丁丌下与丞丁丐(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘 != 1152921505671118856);
        
        }
        internal 专不万丐丑丑丟丕东()
        {
            null = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丒丑丛丏丏丟丐丄, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.专不万丐丑丑丟丕东::丂丞丙且下七业丛丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        internal void 丂丒丑丛丏丏丟丐丄(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世, string 下东东业专丑七专丄)
        {
            var val_7;
            if((且丟丅丄丒丑丂丁世 == null) || ((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false))
            {
                goto label_3;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            string val_4 = 且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁();
            if(val_3 == null)
            {
                goto label_4;
            }
            
            val_3.set_Item(key:  "clan_id", value:  val_4);
            goto label_5;
            label_3:
            this.丒上丗不丐丒丅丙丘(丞丐丟三丌与丞上一:  1);
            return;
            label_4:
            val_3.set_Item(key:  "clan_id", value:  val_4);
            label_5:
            val_3.set_Item(key:  "receiver_id", value:  下东东业专丑七专丄);
            val_7 = null;
            val_7 = null;
            int val_6 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丒丑丛丏丏丟丐丄, 一丐丗丁丞丆丅丟丄:  val_3);
        }
        private void 丂丞丙且下七业丛丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            string val_5;
            if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
            {
                    int val_3 = System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["err_code"]);
                val_3.丒上丗不丐丒丅丙丘(丞丐丟三丌与丞上一:  val_3);
                return;
            }
            
            string val_5 = "receiver_id";
            object val_4 = 东丞丒丙世丏三下丟.Item[val_5];
            if(val_4 != null)
            {
                    val_5 = (null == null) ? (val_4) : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            val_4.业丈丂丏丄且丙丕三(丏丕丈业丝三丁丈丘:  val_5);
        }
        private void 丒上丗不丐丒丅丙丘(int 丞丐丟三丌与丞上一)
        {
            if(PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘 == null)
            {
                    return;
            }
            
            PGCompany.Clans.Network.专不万丐丑丑丟丕东.东上丟丂丕丈上丄丘.Invoke(obj:  丞丐丟三丌与丞上一);
        }
        private void 业丈丂丏丄且丙丕三(string 丏丕丈业丝三丁丈丘)
        {
            if(PGCompany.Clans.Network.专不万丐丑丑丟丕东.丟丁丟丕且不下世一 == null)
            {
                    return;
            }
            
            PGCompany.Clans.Network.专不万丐丑丑丟丕东.丟丁丟丕且不下世一.Invoke(obj:  丏丕丈业丝三丁丈丘);
        }
    
    }

}
