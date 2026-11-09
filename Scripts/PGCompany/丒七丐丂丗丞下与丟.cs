using UnityEngine;

namespace PGCompany
{
    internal sealed class 丒七丐丂丗丞下与丟
    {
        // Fields
        private System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且> 丕丏丏与丙丁业业丛;
        
        // Methods
        internal PGCompany.丒七丐丂丗丞下与丟 丌丌丄丂丟丐与丅且(int 丝丌不东丕丒与丒丅, int 下丝丘丁专丐丅丛丝)
        {
            var val_4;
            if((this.丕丏丏与丙丁业业丛.TryGetValue(key:  丝丌不东丕丒与丒丅, value: out  new Rilisoft.丝丑丂丛万丐丈丘且())) != false)
            {
                    val_4;
            }
            else
            {
                    val_4 = 0;
            }
            
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            int val_3 = val_4 + 下丝丘丁专丐丅丛丝;
            this.丕丏丏与丙丁业业丛.set_Item(key:  丝丌不东丕丒与丒丅, value:  new Rilisoft.丝丑丂丛万丐丈丘且());
            return (PGCompany.丒七丐丂丗丞下与丟)this;
        }
        internal int 七丘丅丆三不上七丆(int 丝丌不东丕丒与丒丅)
        {
            var val_3;
            if((this.丕丏丏与丙丁业业丛.ContainsKey(key:  丝丌不东丕丒与丒丅)) != false)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_2 = this.丕丏丏与丙丁业业丛.Item[丝丌不东丕丒与丒丅];
                val_3;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        internal void 丈丂丑丒三一下丏七()
        {
            System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且> val_9;
            var val_10;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_12;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_14;
            var val_15;
            val_9 = this;
            if(this.丕丏丏与丙丁业业丛.Count == 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_10 = null;
            val_10 = null;
            val_12 = 丒七丐丂丗丞下与丟.<>c.<>9__3_0;
            if(val_12 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_3 = null;
                val_12 = val_3;
                val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32>(object:  丒七丐丂丗丞下与丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒七丐丂丗丞下与丟.<>c::且且业丙丝不万丝一(System.Collections.Generic.KeyValuePair<int, Rilisoft.丝丑丂丛万丐丈丘且> 丐丏东世不丅丌且万));
                val_10 = null;
                丒七丐丂丗丞下与丟.<>c.<>9__3_0 = val_12;
            }
            
            val_10 = null;
            val_14 = 丒七丐丂丗丞下与丟.<>c.<>9__3_1;
            if(val_14 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_4 = null;
                val_14 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32>(object:  丒七丐丂丗丞下与丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒七丐丂丗丞下与丟.<>c::东丅丄东丐丌丂与丐(System.Collections.Generic.KeyValuePair<int, Rilisoft.丝丑丂丛万丐丈丘且> 丐丏东世不丅丌且万));
                丒七丐丂丗丞下与丟.<>c.<>9__3_1 = val_14;
            }
            
            val_2.set_Item(key:  "cells", value:  System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32, System.Int32>(source:  this.丕丏丏与丙丁业业丛, keySelector:  val_3, elementSelector:  val_4));
            val_2.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_15 = null;
            val_15 = null;
            new Rilisoft.WebSocket.丘七丝且东丙丁丅专(丝丏业丅丈东业丝丒:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙一丑丛丂丕丒丘丒, 一丐丗丁丞丆丅丟丄:  val_2).丈丂丑丒三一下丏七();
            val_9 = this.丕丏丏与丙丁业业丛;
            val_9.Clear();
        }
        public 丒七丐丂丗丞下与丟()
        {
            this.丕丏丏与丙丁业业丛 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>();
        }
    
    }

}
