using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class 丙上七且上丆丞丞丒 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private PGCompany.GameModeHub.且世专丝丞丞丅丛且 丈丄丂下丒专丌丛丄;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            return "gmh_rewards";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            return "gmh_rewards_slot";
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 75;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            string val_1 = Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "slot {0}({1}) strHash: {2}", arg0:  "GameModeHub", arg1:  this, arg2:  val_1));
            return val_1;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.丈丄丂下丒专丌丛丄 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_3;
            if(this.丈丄丂下丒专丌丛丄 != null)
            {
                    val_3 = Progress.上专丙七丒七丏丘上.丆丆且与下不三丟丄(万且万且丑丗且丌丆:  this.丈丄丂下丒专丌丛丄);
                return (object)val_3;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            return (object)val_3;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丈丄丂下丒专丌丛丄 = new PGCompany.GameModeHub.且世专丝丞丞丅丛且();
        }
        internal void 上不丕丌丄世丆丘丘(System.Collections.Generic.List<string> 业丑专丙下七业丄上, int 丁不七丈与丐丌丅世)
        {
            PGCompany.GameModeHub.且世专丝丞丞丅丛且 val_1 = new PGCompany.GameModeHub.且世专丝丞丞丅丛且();
            if(val_1 != null)
            {
                    .GainedCategories = 业丑专丙下七业丄上;
            }
            else
            {
                    mem[16] = 业丑专丙下七业丄上;
            }
            
            .LastResetDay = 丁不七丈与丐丌丅世;
            this.丈丄丂下丒专丌丛丄 = val_1;
        }
        internal int 上丒丟丈丈丌世一丑()
        {
            if(this.丈丄丂下丒专丌丛丄 == null)
            {
                    return 0;
            }
            
            return (int)this.丈丄丂下丒专丌丛丄.LastResetDay;
        }
        internal void 且丁上一丑丝万丂丏(int 丁不七丈与丐丌丅世)
        {
            PGCompany.GameModeHub.且世专丝丞丞丅丛且 val_2 = this.丈丄丂下丒专丌丛丄;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            PGCompany.GameModeHub.且世专丝丞丞丅丛且 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.GameModeHub.且世专丝丞丞丅丛且();
            this.丈丄丂下丒专丌丛丄 = val_2;
            if(val_2 == null)
            {
                goto label_2;
            }
            
            label_1:
            .LastResetDay = 丁不七丈与丐丌丅世;
            return;
            label_2:
        }
        internal System.Collections.Generic.List<string> 上一丑一丒三丝东不()
        {
            var val_3;
            if((this.丈丄丂下丒专丌丛丄 != null) && (this.丈丄丂下丒专丌丛丄.GainedCategories != null))
            {
                    val_3 = System.Linq.Enumerable.ToList<System.String>(source:  this.丈丄丂下丒专丌丛丄.GainedCategories);
                if(val_3 != null)
            {
                    return (System.Collections.Generic.List<System.String>)val_3;
            }
            
            }
            
            System.Collections.Generic.List<System.String> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Collections.Generic.List<System.String>();
            return (System.Collections.Generic.List<System.String>)val_3;
        }
        internal void 丒业丆专一丑丌丏丝(System.Collections.Generic.List<string> 业丑专丙下七业丄上)
        {
            System.Collections.Generic.List<System.String> val_3 = 业丑专丙下七业丄上;
            if(this.丈丄丂下丒专丌丛丄 == null)
            {
                goto label_1;
            }
            
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_4:
            val_3 = System.Linq.Enumerable.ToList<System.String>(source:  val_3 = 业丑专丙下七业丄上);
            label_5:
            this.丈丄丂下丒专丌丛丄.GainedCategories = val_3;
            return;
            label_1:
            this.丈丄丂下丒专丌丛丄 = new PGCompany.GameModeHub.且世专丝丞丞丅丛且();
            if(val_3 != null)
            {
                goto label_4;
            }
            
            goto label_5;
        }
        internal bool 七丆业丞丑业丐丟三(string 七丆丒与丗丌丄且丂)
        {
            PGCompany.GameModeHub.且世专丝丞丞丅丛且 val_3;
            var val_4;
            val_3 = this.丈丄丂下丒专丌丛丄;
            if(val_3 != null)
            {
                    if(this.丈丄丂下丒专丌丛丄.GainedCategories != null)
            {
                    string val_3 = 七丆丒与丗丌丄且丂;
                val_3 = this.丈丄丂下丒专丌丛丄.GainedCategories.Contains(item:  val_3);
                val_3 = 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            }
            
            if((39849964 & 1) != 0)
            {
                    bool val_2 = val_3.GetValueOrDefault();
            }
            else
            {
                    val_4 = 0;
            }
            
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public 丙上七且上丆丞丞丒()
        {
        
        }
    
    }

}
