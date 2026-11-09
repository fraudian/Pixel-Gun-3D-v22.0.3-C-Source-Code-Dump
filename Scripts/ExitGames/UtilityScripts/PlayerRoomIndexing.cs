using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public class PlayerRoomIndexing : PunBehaviour
    {
        // Fields
        public static ExitGames.UtilityScripts.PlayerRoomIndexing instance;
        public ExitGames.UtilityScripts.PlayerRoomIndexing.RoomIndexingChanged OnRoomIndexingChanged;
        public const string RoomPlayerIndexedProp = "PlayerIndexes";
        private int[] _playerIds;
        private object _indexes;
        private System.Collections.Generic.Dictionary<int, int> _indexesLUT;
        private System.Collections.Generic.List<bool> _indexesPool;
        private 与丅丕丈丘东丝世丟 _p;
        
        // Properties
        public int[] PlayerIds { get; }
        
        // Methods
        public int[] get_PlayerIds()
        {
            return (System.Int32[])this._playerIds;
        }
        public void Awake()
        {
            if(ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp != 0)
            {
                    UnityEngine.Debug.LogError(message:  "Existing instance of PlayerRoomIndexing found. Only One instance is required at the most. Please correct and have only one at any time.");
            }
            
            ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp = this;
            if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
            {
                    return;
            }
            
            this.SanitizeIndexing(forceIndexing:  true);
        }
        public override void OnJoinedRoom()
        {
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
            {
                    this.AssignIndex(player:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
                return;
            }
            
            this.RefreshData();
        }
        public override void OnLeftRoom()
        {
            this.RefreshData();
        }
        public override void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 newPlayer)
        {
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                    return;
            }
            
            this.AssignIndex(player:  newPlayer);
        }
        public override void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 otherPlayer)
        {
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                    return;
            }
            
            this.UnAssignIndex(player:  otherPlayer);
        }
        public override void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
        {
            if((propertiesThatChanged.ContainsKey(key:  "PlayerIndexes")) == false)
            {
                    return;
            }
            
            this.RefreshData();
        }
        public override void OnMasterClientSwitched(与丅丕丈丘东丝世丟 newMasterClient)
        {
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                    return;
            }
            
            this.SanitizeIndexing(forceIndexing:  false);
        }
        public int GetRoomIndex(与丅丕丈丘东丝世丟 player)
        {
            if(this._indexesLUT == null)
            {
                    return 0;
            }
            
            if((this._indexesLUT.ContainsKey(key:  player.业丐丐三丕一丗丛丁())) == false)
            {
                    return 0;
            }
            
            if(this._indexesLUT != null)
            {
                    return this._indexesLUT.Item[player.业丐丐三丕一丗丛丁()];
            }
            
            return this._indexesLUT.Item[player.业丐丐三丕一丗丛丁()];
        }
        private void SanitizeIndexing(bool forceIndexing = False)
        {
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            if(forceIndexing != true)
            {
                    if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                    return;
            }
            
            }
            
            val_15 = 1152921505107111936;
            if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) == false)
            {
                goto label_12;
            }
            
            val_16 = mem[this._indexes];
            if(val_16 == 0)
            {
                goto label_16;
            }
            
            label_12:
            if(val_16 == 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_16:
            val_16 = 0;
            label_17:
            val_14 = val_16.Count;
            if(val_14 == 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒())
            {
                    return;
            }
            
            val_14 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
            val_17 = 0;
            goto label_24;
            label_30:
            与丅丕丈丘东丝世丟 val_14 = val_14[0];
            val_15 = val_14.业丐丐三丕一丗丛丁();
            if((val_16.ContainsKey(key:  val_15)) != true)
            {
                    this.AssignIndex(player:  val_14);
            }
            
            val_17 = 1;
            label_24:
            if(val_17 < val_11.Length)
            {
                goto label_30;
            }
        
        }
        private void RefreshData()
        {
            var val_10;
            int val_18;
            if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
            {
                goto label_27;
            }
            
            int val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
            this._playerIds = new int[0];
            val_18 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            if((val_18.TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) == false)
            {
                goto label_18;
            }
            
            this._indexesLUT = 0;
            Dictionary.Enumerator<TKey, TValue> val_9 = 0.GetEnumerator();
            goto label_13;
            label_17:
            this._p = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  val_10.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂());
            val_18 = this._p.业丐丐三丕一丗丛丁();
            this._playerIds[-1830249720] = val_18;
            label_13:
            if(((-1830249760) & 1) != 0)
            {
                goto label_17;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_18;
            label_27:
            this._playerIds = new int[0];
            label_18:
            if(this.OnRoomIndexingChanged == null)
            {
                    return;
            }
            
            this.OnRoomIndexingChanged.Invoke();
        }
        private void AssignIndex(与丅丕丈丘东丝世丟 player)
        {
            var val_13;
            var val_20;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().TryGetValue(key:  "PlayerIndexes", value: out  this._indexes)) != false)
            {
                    val_20 = 0;
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_5 = null;
                val_20 = val_5;
                val_5 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            }
            
            this._indexesLUT = ;
            int val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
            System.Collections.Generic.List<System.Boolean> val_10 = new System.Collections.Generic.List<System.Boolean>(collection:  new bool[0]);
            Dictionary.Enumerator<TKey, TValue> val_11 = this._indexesLUT.GetEnumerator();
            label_16:
            if(((-1830004640) & 1) == 0)
            {
                goto label_14;
            }
            
            string val_14 = val_13.丐丏七丌丕丗业且上();
            val_10.set_Item(index:  -1830004648, value:  true);
            goto label_16;
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._indexesLUT.set_Item(key:  player.业丐丐三丕一丗丛丁(), value:  UnityEngine.Mathf.Max(a:  0, b:  val_10.IndexOf(item:  false)));
            ExitGames.Client.Photon.Hashtable val_19 = new ExitGames.Client.Photon.Hashtable();
            val_19.Add(key:  "PlayerIndexes", value:  this._indexesLUT);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_19, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            this.RefreshData();
        }
        private void UnAssignIndex(与丅丕丈丘东丝世丟 player)
        {
            object val_10;
            var val_11;
            val_10 = this._indexes;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().TryGetValue(key:  "PlayerIndexes", value: out  val_10)) != false)
            {
                    val_11 = 0;
                this._indexesLUT = ;
                bool val_7 = Remove(key:  player.业丐丐三丕一丗丛丁());
                ExitGames.Client.Photon.Hashtable val_9 = null;
                val_10 = val_9;
                val_9 = new ExitGames.Client.Photon.Hashtable();
                val_9.Add(key:  "PlayerIndexes", value:  this._indexesLUT);
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            }
            
            this.RefreshData();
        }
        public PlayerRoomIndexing()
        {
        
        }
    
    }

}
