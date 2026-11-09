using UnityEngine;

namespace PGCompany
{
    internal sealed class 与丐业一丂丗与七丟 : 丟与丞丗丌丂万丕丝
    {
        // Fields
        private PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙;
        
        // Properties
        internal PGCompany.世丐下丕专东丘丏且 万下世三丘丏丑上三 { get; }
        internal int 丅七丐三与丌丞丝丝 { get; }
        internal float 丟丅丏丄丂丁丈七丙 { get; }
        
        // Methods
        internal PGCompany.世丐下丕专东丘丏且 下三下东业丘且丟业()
        {
            int val_9;
            string val_12;
            PGCompany.世丐下丕专东丘丏且 val_14;
            if(this.与世七丑丂专专丌丙 == null)
            {
                goto label_1;
            }
            
            label_12:
            if(this.与世七丑丂专专丌丙.世丈丁业丛上丘丗丐().东且丟万下万世丟东() != this.业丏东业丟丒丅丄不())
            {
                goto label_3;
            }
            
            val_14 = this.与世七丑丂专专丌丙;
            return val_14;
            label_1:
            if(this.业丏东业丟丒丅丄不() <= 0)
            {
                goto label_5;
            }
            
            label_3:
            if(this.与世七丑丂专专丌丙 != null)
            {
                    this.与世七丑丂专专丌丙.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
            }
            
            PGCompany.GameTaskActionSettings val_5 = new PGCompany.GameTaskActionSettings();
            if(val_5 != null)
            {
                    .Type = 23;
                .GameMode = 26;
            }
            else
            {
                    mem[16] = 23;
                mem[136] = 26;
            }
            
            val_5.ShouldWin = true;
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.业丏东业丟丒丅丄不());
            .NeededCount = val_7;
            mem[1152921554161332816] = val_7.上万三丆专丏丒丗业;
            PGCompany.ClanWarEventConfig val_8 = this.世丈丁业丛上丘丗丐();
            .丈丝丄不丈万丁丁下 = 4;
            PGCompany.ClanWarEventConfig val_11 = this.世丈丁业丛上丘丗丐();
            .丛东下丌一丕丌一丁 = val_12;
            PGCompany.世丐下丕专东丘丏且 val_13 = null;
            val_14 = val_13;
            val_13 = new PGCompany.世丐下丕专东丘丏且(上世丏丁世丟世丆业:  new PGCompany.丟丒丅丐万丈七且万(丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  val_9, 丗七丗丒丌三世丌丁:  val_5));
            this.与世七丑丂专专丌丙 = val_14;
            return val_14;
            label_5:
            if(this.与世七丑丂专专丌丙 != null)
            {
                goto label_12;
            }
            
            return val_14;
        }
        public 与丐业一丂丗与七丟(PGCompany.ClanWarEventConfig 上世丏丁世丟世丆业, System.DateTime 专丛不上丙上业东丅, int 丝业丌丑丌丘世下丒)
        {
            mem[1152921554161564832] = "LevelLoadingsPreview/Hi/Loading_FortDefence";
        }
        internal bool 下下丟丛万丟下上丟()
        {
            return (bool)(this.下三下东业丘且丟业() != 0) ? 1 : 0;
        }
        internal bool 丕七丙丏丒专丝丄丝()
        {
            PGCompany.世丐下丕专东丘丏且 val_1 = this.下三下东业丘且丟业();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            PGCompany.世丐下丕专东丘丏且 val_2 = this.下三下东业丘且丟业();
            if(val_2 != null)
            {
                    return val_2.丞专丅丁丁三丄上专();
            }
            
            return val_2.丞专丅丁丁三丄上专();
        }
        internal bool 世丁丅丗世丄丅丁三()
        {
            return (bool)(this.丒丝丄丆东丘三上丝() > 0) ? 1 : 0;
        }
        internal int 丒丝丄丆东丘三上丝()
        {
            PGCompany.丐世与丟丄丈丘业业 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丘丅丞丈丒世丕(丟丟丄专上丟丁丐丝:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    return val_3.丑丞丝丘丏丁丕不丌();
            }
            
            return val_3.丑丞丝丘丏丁丕不丌();
        }
        internal float 下丕丘丟三丞丘上万()
        {
            if(this.下三下东业丘且丟业() == null)
            {
                    return 0f;
            }
            
            float val_5 = (float)this.丒丝丄丆东丘三上丝();
            val_5 = val_5 / (float)this.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
            return 0f;
        }
        internal override 丌丈不下下丘丏丌一 丛丆丌东丆丕丞丄丙()
        {
            var val_3;
            if((this & 1) != 0)
            {
                    var val_2 = ((this.丕七丙丏丒专丝丄丝() & true) != 0) ? (1 + 1) : 1;
                return (丌丈不下下丘丏丌一)val_3;
            }
            
            val_3 = 2;
            return (丌丈不下下丘丏丌一)val_3;
        }
        internal int 上专东且丛不上丕丒()
        {
            PGCompany.丐世与丟丄丈丘业业 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丘丅丞丈丒世丕(丟丟丄专上丟丁丐丝:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    return val_3.丑丟丒业专与世丆丞();
            }
            
            return val_3.丑丟丒业专与世丆丞();
        }
        internal override void 丛上且不与业专丘丘()
        {
            PGCompany.世丐下丕专东丘丏且 val_1 = this.下三下东业丘且丟业();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  this.丅业东万丌丕上丌丄());
        }
        internal override void 不与丞下业丑丒丙万()
        {
            PGCompany.世丐下丕专东丘丏且 val_1 = this.下三下东业丘且丟业();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        }
        internal override bool 丞专丅丁丁三丄上专()
        {
            if(this.丕七丙丏丒专丝丄丝() == false)
            {
                    return this.丞专丅丁丁三丄上专();
            }
            
            return true;
        }
        internal override bool 丝丑专业丕三丒与万()
        {
            var val_4;
            if((this & 1) != 0)
            {
                    if(this.丕七丙丏丒专丝丄丝() != false)
            {
                    var val_3 = (this.丒丝丄丆东丘三上丝() > 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        internal override bool 东丏丟不丒世且业世()
        {
            PGCompany.丐世与丟丄丈丘业业 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丘丅丞丈丒世丕(丟丟丄专上丟丁丐丝:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    return val_3.丈丗东丏专丐丅专丄();
            }
            
            return val_3.丈丗东丏专丐丅专丄();
        }
        internal override bool 丛丘丞丕丙丁下不丟()
        {
            PGCompany.丐世与丟丄丈丘业业 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丘丅丞丈丒世丕(丟丟丄专上丟丁丐丝:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    return val_3.东丘丌丕世世丕丄三();
            }
            
            return val_3.东丘丌丕世世丕丄三();
        }
        private int 业丏东业丟丒丅丄不()
        {
            var val_6;
            var val_7;
            val_6 = this;
            val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丘丅丞丈丒世丕(丟丟丄专上丟丁丐丝:  this.业上丙丞丐丄丆丅七());
            if(val_7.东且丟万下万世丟东() > 0)
            {
                    return -1983112608;
            }
            
            PGCompany.ClanWarEventConfig val_5 = this.世丈丁业丛上丘丗丐();
            return -1983112608;
        }
        public override string ToString()
        {
            var val_10;
            object[] val_1 = new object[7];
            string val_2 = this.七业丑不七丐业丟丂();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            System.DateTime val_3 = this.上丟丄与丁三丌丘专();
            val_1[1] = val_3;
            System.DateTime val_4 = this.下丒丗丄丌丘不丑丘();
            if((val_4 != 0) && (val_4 == 0))
            {
                    val_10 = 0;
            }
            
            if(val_1.Length <= 2)
            {
                    val_10 = 0;
            }
            
            val_1[2] = val_4;
            System.Nullable<System.DateTime> val_5 = FriendsController.业丈丏丏丞丘丛丈丛();
            val_1[3] = val_5.HasValue;
            val_1[4] = this.上专东且丛不上丕丒();
            val_1[5] = this.丒丝丄丆东丘三上丝();
            val_1[6] = this.业丏东业丟丒丅丄不();
            return (string)System.String.Format(format:  "{0}: {1} - {2} [{3}] clanProgress={4} MyContribution={5} neededCount={6}", args:  val_1);
        }
    
    }

}
