using UnityEngine;

namespace PGCompany.GameModeEvents
{
    internal sealed class 丞丙丏专丘丄丕丑丗 : 丝一七万丗不丄丒上
    {
        // Fields
        private int 丙三丌一丕丙专东万;
        private int 丄下丑丛七丈且丐丆;
        private bool 丁丗不丒丐东三且丗;
        
        // Properties
        internal override string 丒三丝一上丙专丗丒 { get; }
        internal int 丟丄丂丑丞三丆丄丟 { get; }
        internal bool 丂与东丈下丐丏专丏 { get; }
        
        // Methods
        internal override string 不业丙丒丂丞下丆丙()
        {
            return "kill";
        }
        internal int 一专东丗丁丏丈丏丑()
        {
            return (int)this.丄下丑丛七丈且丐丆;
        }
        internal bool 丂专丈丅丕世丞且万()
        {
            return (bool)this.丁丗不丒丐东三且丗;
        }
        public override void 丈且东丑丂且万丒丅()
        {
            if(Count >= 1)
            {
                    if((System.Int32.TryParse(s:  Item[0], result: out  0)) != false)
            {
                    this.丄下丑丛七丈且丐丆 = 0;
                Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
                mem[1152921559713614016] = val_5.七丄不丐丗三丝丑一;
                mem[1152921559713614020] = val_5.丑丒丄下丁丐专丄丞;
                mem[1152921559713614024] = val_5.上万三丆专丏丒丗业;
            }
            
            }
            
            if(Count >= 2)
            {
                    if((System.Int32.TryParse(s:  Item[1], result: out  0)) != false)
            {
                    this.丁丗不丒丐东三且丗 = 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  0);
            }
            
            }
            
            if(val_8.CompleteResult != 0)
            {
                    return;
            }
            
            if(val_8.Points >= this.丄下丑丛七丈且丐丆)
            {
                    Progress.下丁下丂七丆丙七一 val_14 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_14.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
                if(val_14.CompleteResult != 1)
            {
                    1152921516934571616 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  1152921516934571616.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_14));
            }
            
                val_14.CompleteResult = 1;
                this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  false);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            
            if(this.丑丑丏丁丗丏丘七一() != 0)
            {
                    mem[1152921559713614032] = 0;
                return;
            }
            
            this.丈丙与丘不丛与三与(丝三丄专丗丞丄丄丌:  true);
        }
        public 丞丙丏专丘丄丕丑丗(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<string> 丗丟上上丒丐丗丞丙, PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
        
        }
        private void 丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丙三丌一丕丙专东万 = 0;
        }
        private void 丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            int val_12;
            var val_13;
            if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() == 20)
            {
                    if(丗丛不丁丑专专丂且.丙东专丂世丈丏丁丂() > 5)
            {
                    return;
            }
            
            }
            
            if(丗丛不丁丑专专丂且 != null)
            {
                    val_12 = this.丙三丌一丕丙专东万;
                val_13 = 丗丛不丁丑专专丂且.Points;
            }
            else
            {
                    val_12 = this.丙三丌一丕丙专东万;
                val_13 = 0.Points;
            }
            
            丗丛不丁丑专专丂且.Points = val_13 + val_12;
            this.丙三丌一丕丙专东万 = 0;
            if(丗丛不丁丑专专丂且.Points >= this.丄下丑丛七丈且丐丆)
            {
                    Progress.下丁下丂七丆丙七一 val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_7.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
                if(val_7.CompleteResult != 1)
            {
                    val_13 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  val_13.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_7));
            }
            
                val_7.CompleteResult = 1;
                mem[1152921559714036048] = 0;
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            
            this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  true);
        }
        private void 丁丅丒丟丗丁业丞丗(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丈不丘丑万业丁三不)
        {
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_10 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  W21);
            if(val_10 == null)
            {
                    return;
            }
            
            if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈() == null)
            {
                    return;
            }
            
            val_10 = val_10.业上丙丞丐丄丆丅七();
            if(val_10 != PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈().业上丙丞丐丄丆丅七())
            {
                    return;
            }
            
            if(丈不丘丑万业丁三不 == null)
            {
                    return;
            }
            
            if(W8 == 0)
            {
                    return;
            }
            
            if(this.丁丗不丒丐东三且丗 != false)
            {
                    if(丈不丘丑万业丁三不.业世丌丞丟丛上丐丁() == false)
            {
                    return;
            }
            
            }
            
            int val_10 = this.丙三丌一丕丙专东万;
            val_10 = val_10 + 1;
            this.丙三丌一丕丙专东万 = val_10;
        }
        public override void Dispose()
        {
            mem[1152921559714354216] = 1;
            this.丈丙与丘不丛与三与(丝三丄专丗丞丄丄丌:  false);
        }
        private void 丈丙与丘不丛与三与(bool 丝三丄专丗丞丄丄丌)
        {
            if(丝三丄专丗丞丄丄丌 != false)
            {
                    if(true == 0)
            {
                goto label_2;
            }
            
            }
            
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丁丅丒丟丗丁业丞丗(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丈不丘丑万业丁三不)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            return;
            label_2:
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丁丅丒丟丗丁业丞丗(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丈不丘丑万业丁三不)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丁丅丒丟丗丁业丞丗(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丈不丘丑万业丁三不)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌上与丙一业丑东丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丞丙丏专丘丄丕丑丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        }
        public override string 丙丄上丆丝丂丘专丒()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7780"), arg0:  X21.Points + "/"("/") + this);
        }
        public override string 与丏丞丟丆七丈丐上()
        {
            string val_5;
            var val_6;
            int val_1 = CompleteResult;
            if(this.丁丗不丒丐东三且丗 != false)
            {
                    if(val_1 == 2)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6508");
            }
            
                val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7766");
                val_6 = 1152921504622075904;
                return (string)System.String.Format(format:  val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7765"), arg0:  this);
            }
            
            if(val_1 == 2)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6508");
            }
            
            val_6 = 1152921504622075904;
            return (string)System.String.Format(format:  val_5, arg0:  this);
        }
        public override string 丂丌丐丕丝不且丏丅()
        {
            string val_5;
            var val_6;
            int val_1 = CompleteResult;
            if(this.丁丗不丒丐东三且丗 != false)
            {
                    if(val_1 == 2)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_6508");
            }
            
                val_5 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_7766");
                val_6 = 1152921504622075904;
                return (string)System.String.Format(format:  val_5 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_7765"), arg0:  this);
            }
            
            if(val_1 == 2)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_6508");
            }
            
            val_6 = 1152921504622075904;
            return (string)System.String.Format(format:  val_5, arg0:  this);
        }
        public override int 丘且丘下丁丑丗且丒()
        {
            return (int)this.丄下丑丛七丈且丐丆;
        }
        public override bool 万且丏丂下丘丄不丑()
        {
            return false;
        }
    
    }

}
