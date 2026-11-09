using UnityEngine;

namespace PGCompany.GameModeEvents
{
    internal class 丁下下丌万丄不丙丗 : 丝一七万丗不丄丒上
    {
        // Fields
        private int 丙三丌一丕丙专东万;
        private int 丕丘丄丂三丛丁丘丁;
        
        // Properties
        internal override string 丒三丝一上丙专丗丒 { get; }
        internal int 丌丛丁丈与丆与丅丕 { get; }
        
        // Methods
        internal override string 不业丙丒丂丞下丆丙()
        {
            return "points";
        }
        internal int 丏丌且丗丟专丟丏丌()
        {
            return (int)this.丕丘丄丂三丛丁丘丁;
        }
        public override void 丈且东丑丂且万丒丅()
        {
            this.丈且东丑丂且万丒丅();
            if(Count >= 1)
            {
                    if((System.Int32.TryParse(s:  Item[0], result: out  0)) != false)
            {
                    this.丕丘丄丂三丛丁丘丁 = 0;
                Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
                this.丅丐下丌丅丛且丁丛(丙业与丙丗丝不丈东:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_5.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_5.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_5.上万三丆专丏丒丗业});
            }
            
            }
            
            if(CompleteResult != 0)
            {
                    return;
            }
            
            if(Points >= this.丕丘丄丂三丛丁丘丁)
            {
                    Progress.下丁下丂七丆丙七一 val_8 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_8.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
                if(val_8.CompleteResult != 1)
            {
                    PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_10 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  val_10.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  this.丅东丄丛上丁丐万丏()));
            }
            
                val_10.CompleteResult = 1;
                this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  false);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            
            if(this.丑丑丏丁丗丏丘七一() != 0)
            {
                    mem[1152921559715640048] = 0;
                return;
            }
            
            this.丈丙与丘不丛与三与(丝三丄专丗丞丄丄丌:  true);
        }
        public 丁下下丌万丄不丙丗(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<string> 丗丟上上丒丐丗丞丙, PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
        
        }
        private void 丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丙三丌一丕丙专东万 = 0;
        }
        private void 丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            int val_13;
            int val_14;
            if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() == 20)
            {
                    if(丗丛不丁丑专专丂且.丙东专丂世丈丏丁丂() > 5)
            {
                    return;
            }
            
            }
            
            if(丗丛不丁丑专专丂且 != null)
            {
                    val_13 = this.丙三丌一丕丙专东万;
                val_14 = 丗丛不丁丑专专丂且.Points;
            }
            else
            {
                    val_13 = this.丙三丌一丕丙专东万;
                val_14 = 0.Points;
            }
            
            丗丛不丁丑专专丂且.Points = val_14 + val_13;
            this.丙三丌一丕丙专东万 = 0;
            if(丗丛不丁丑专专丂且.Points >= this.丕丘丄丂三丛丁丘丁)
            {
                    Progress.下丁下丂七丆丙七一 val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_7.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
                if(val_7.CompleteResult != 1)
            {
                    PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_9 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
                val_14 = this.丅东丄丛上丁丐万丏();
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  val_9.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_14));
            }
            
                val_9.CompleteResult = 1;
                mem[1152921559716057968] = 0;
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            
            this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  true);
        }
        private void 丆与丘丂丌丌丑专且(object 不丟丗丏丛丕不丁丌, Rilisoft.下丙与丂下世丐与世 下丄丁世丄万丑世丛)
        {
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  this.丅东丄丛上丁丐万丏());
            if(val_6 == null)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_4 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
            if(val_4.世丒丑专丕与下丂东 == null)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_5 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
            val_6 = val_5.世丒丑专丕与下丂东;
            if((val_3.<上七东下丏不丕丐丑>k__BackingField) != (val_5.世丒丑专丕与下丂东.<上七东下丏不丕丐丑>k__BackingField))
            {
                    return;
            }
            
            if(下丄丁世丄万丑世丛 == null)
            {
                    return;
            }
            
            if((val_5.世丒丑专丕与下丂东.<上七东下丏不丕丐丑>k__BackingField) == 0)
            {
                    return;
            }
            
            int val_6 = this.丙三丌一丕丙专东万;
            val_6 = 下丄丁世丄万丑世丛.丅专与丒丈丗丒丘丌 + val_6;
            this.丙三丌一丕丙专东万 = val_6;
        }
        public override void Dispose()
        {
            this.Dispose();
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
            
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().专丞丅丛丛丌七一丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丙与丂下世丐与世>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丆与丘丂丌丌丑专且(object 不丟丗丏丛丕不丁丌, Rilisoft.下丙与丂下世丐与世 下丄丁世丄万丑世丛)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            return;
            label_2:
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().专丞丅丛丛丌七一丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丙与丂下世丐与世>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丆与丘丂丌丌丑专且(object 不丟丗丏丛丕不丁丌, Rilisoft.下丙与丂下世丐与世 下丄丁世丄万丑世丛)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丛专丘丒丅丞丄且不(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丙与丂下世丐与世>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丆与丘丂丌丌丑专且(object 不丟丗丏丛丕不丁丌, Rilisoft.下丙与丂下世丐与世 下丄丁世丄万丑世丛)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌上与丙一业丑东丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.丁下下丌万丄不丙丗::丒丅丄且丕丌丂丏东(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        }
        public override string 丙丄上丆丝丂丘专丒()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7781"), arg0:  X21.Points + "/"("/") + this);
        }
        public override string 与丏丞丟丆七丈丐上()
        {
            if(CompleteResult != 2)
            {
                    return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7767"), arg0:  this);
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6508");
        }
        public override string 丂丌丐丕丝不且丏丅()
        {
            if(CompleteResult != 2)
            {
                    return (string)System.String.Format(format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_7767"), arg0:  this);
            }
            
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_6508");
        }
        public override int 丘且丘下丁丑丗且丒()
        {
            return (int)this.丕丘丄丂三丛丁丘丁;
        }
        public override bool 万且丏丂下丘丄不丑()
        {
            return false;
        }
    
    }

}
