using UnityEngine;

namespace PGCompany.GameModeEvents
{
    internal sealed class 东不丈下丏丂丂丏丆 : 丝一七万丗不丄丒上
    {
        // Fields
        private System.Nullable<int> 丗丒专丘世丘丄专专;
        private System.Nullable<int> 丘丌专上不三七丆世;
        private Rilisoft.丝丑丂丛万丐丈丘且 丐丂丂丁丏丘业丏丅;
        
        // Properties
        internal override string 丒三丝一上丙专丗丒 { get; }
        internal int 世且丌丞丘丒三下万 { get; }
        internal int 下东下丆三丄万且丆 { get; }
        
        // Methods
        internal override string 不业丙丒丂丞下丆丙()
        {
            return "win";
        }
        internal int 丑丛丈丂世丕丌丅与()
        {
            System.Nullable<System.Int32> val_5 = this.丗丒专丘世丘丄专专;
            if((val_5 & 1) == 0)
            {
                    return 0;
            }
            
            val_5 = ???;
            return 0;
        }
        internal int 丑丅丁丌丗丌业丂丁()
        {
            System.Nullable<System.Int32> val_5 = this.丘丌专上不三七丆世;
            if((val_5 & 1) == 0)
            {
                    return 0;
            }
            
            val_5 = ???;
            return 0;
        }
        public override void 丈且东丑丂且万丒丅()
        {
            System.Nullable<System.Int32> val_23 = 1152921516934571616;
            if(Count >= 1)
            {
                    string val_2 = Item[0];
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_2, 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    this.丗丒专丘世丘丄专专 = 0;
                Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
                mem[1152921559719458976] = val_5.七丄不丐丗三丝丑一;
                mem[1152921559719458980] = val_5.丑丒丄下丁丐专丄丞;
                mem[1152921559719458984] = val_5.上万三丆专丏丒丗业;
            }
            
            }
            
            if(val_2.Count >= 2)
            {
                    string val_7 = val_2.Item[1];
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_7, 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    this.丘丌专上不三七丆世 = 0;
            }
            
            }
            
            if(val_7.CompleteResult != 0)
            {
                    return;
            }
            
            val_23 = this.丗丒专丘世丘丄专专;
            if(((val_23 & 1) == 0) || ((this.丘丌专上不三七丆世 & 1) == 0))
            {
                goto label_38;
            }
            
            int val_12 = this.丗丒专丘世丘丄专专.HasValue.丙东专丂世丈丏丁丂();
            if((X22.Points >= val_12) && (((-721974984) & 1) != 0))
            {
                    Progress.下丁下丂七丆丙七一 val_13 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_13.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
                if(val_13.CompleteResult != 1)
            {
                    PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_13));
            }
            
                val_13.CompleteResult = 1;
                this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  false);
                val_23 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_23.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            else
            {
                    val_23 = val_12.Points1;
                if((val_23 >= this.丘丌专上不三七丆世.HasValue.丙东专丂世丈丏丁丂()) && (((-721974984) & 1) != 0))
            {
                    val_23.CompleteResult = 2;
                this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  false);
            }
            
            }
            
            if(this.丑丑丏丁丗丏丘七一() == 0)
            {
                goto label_35;
            }
            
            label_38:
            mem[1152921559719458992] = 0;
            return;
            label_35:
            if((val_23.Points1 >= this.丘丌专上不三七丆世.HasValue.丙东专丂世丈丏丁丂()) || (((-721974984) & 1) == 0))
            {
                goto label_38;
            }
            
            this.丈丙与丘不丛与三与(丝三丄专丗丞丄丄丌:  true);
        }
        public 东不丈下丏丂丂丏丆(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<string> 丗丟上上丒丐丗丞丙, PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
        
        }
        private void 丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_16;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  137138176);
            if(val_2 == null)
            {
                    return;
            }
            
            if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈() == null)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_7 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈();
            if(val_2.业上丙丞丐丄丆丅七() != val_7.业上丙丞丐丄丆丅七())
            {
                    return;
            }
            
            if(true != 0)
            {
                    if(this.丑丑丏丁丗丏丘七一() == 0)
            {
                goto label_9;
            }
            
            }
            
            mem[1152921559719756720] = 0;
            this.丈丙与丘不丛与三与(丝三丄专丗丞丄丄丌:  false);
            return;
            label_9:
            int val_10 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            int val_11 = val_7.Points;
            this.丐丂丂丁丏丘业丏丅 = 0;
            mem[1152921559719756768] = 0;
            if(val_10 != 0)
            {
                    val_16 = val_10.Points1;
            }
            else
            {
                    val_16 = 0.Points1;
            }
            
            val_10.Points1 = val_16 + 1;
            val_10.Points = 0;
            int val_15 = val_10.Points1;
            if(val_15 >= this.丘丌专上不三七丆世)
            {
                    val_15.CompleteResult = 2;
            }
            
            this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  false);
        }
        private void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_37;
            var val_38;
            var val_39;
            var val_41;
            var val_42;
            var val_43;
            val_37 = 丗丛不丁丑专专丂且;
            val_38 = this;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  137138176);
            if(val_2 == null)
            {
                    return;
            }
            
            if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈() == null)
            {
                    return;
            }
            
            val_39 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈();
            if(val_2.业上丙丞丐丄丆丅七() != val_39.业上丙丞丐丄丆丅七())
            {
                    return;
            }
            
            if(val_37 == null)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  35);
            if(val_37.且专丂丐丟一不丌丟() < 50)
            {
                goto label_13;
            }
            
            goto label_14;
            label_13:
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_11 = val_2.业丄丄且丕丕不一万();
            if((val_11.HasValue.丙东专丂世丈丏丁丂() != 20) || (((-721491512) & 1) == 0))
            {
                goto label_16;
            }
            
            label_14:
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_13 = val_2.业丄丄且丕丕不一万();
            val_39 = val_13.HasValue.丙东专丂世丈丏丁丂();
            if((val_39 != 20) || (( & 1) == 0))
            {
                goto label_18;
            }
            
            if(val_39 == 0)
            {
                goto label_19;
            }
            
            val_41 = val_39.Points1;
            goto label_20;
            label_18:
            if(val_37.东丐三一业与丘丂丕() != true)
            {
                    if(val_37.丂丏丁丆丝东丗丂丈() == false)
            {
                goto label_22;
            }
            
            }
            
            if(val_13.HasValue == false)
            {
                goto label_23;
            }
            
            val_42 = val_13.HasValue.Points1;
            goto label_24;
            label_16:
            if(val_37 == null)
            {
                goto label_25;
            }
            
            val_43 = val_37.Points1;
            goto label_26;
            label_19:
            val_41 = 0.Points1;
            label_20:
            val_39.Points1 = val_41 - 1;
            if(val_37 != null)
            {
                goto label_47;
            }
            
            label_48:
            label_47:
            val_37.Points = (val_37.丙东专丂世丈丏丁丂() < 6) ? (this.丐丂丂丁丏丘业丏丅 + 1) : this.丐丂丂丁丏丘业丏丅;
            var val_37 = val_37.Points;
            val_39 = this.丗丒专丘世丘丄专专.丙东专丂世丈丏丁丂();
            val_37 = ((val_37 >= val_39) ? 1 : 0) & 1152921559719930296;
            if(val_37 == null)
            {
                goto label_29;
            }
            
            if(val_37 == 0)
            {
                goto label_30;
            }
            
            label_34:
            if(val_37.CompleteResult != 1)
            {
                    PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丒丛丐丐丑丈世专丑(下丟丝世世丆且丞三:  val_2);
            }
            
            val_2.CompleteResult = 1;
            mem[1152921559719942448] = 0;
            goto label_37;
            label_29:
            if(val_37 != 0)
            {
                goto label_34;
            }
            
            label_30:
            int val_28 = val_37.Points1;
            if(val_28 >= this.丘丌专上不三七丆世)
            {
                goto label_37;
            }
            
            val_28.CompleteResult = 0;
            goto label_37;
            label_23:
            val_42 = 0.Points1;
            label_24:
            val_13.HasValue.Points1 = val_42 - 1;
            Rilisoft.丝丑丂丛万丐丈丘且 val_38 = this.丐丂丂丁丏丘业丏丅;
            val_38 = val_38 + val_37.东丐三一业与丘丂丕();
            if(val_37 != null)
            {
                goto label_47;
            }
            
            goto label_48;
            label_22:
            int val_33 = val_2.Points1;
            if(val_33 >= this.丘丌专上不三七丆世)
            {
                    val_33.CompleteResult = 2;
                mem[1152921559719942448] = 0;
            }
            
            val_33.Points = 0;
            label_37:
            this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  true);
            val_38 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_38.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_25:
            val_43 = 0.Points1;
            label_26:
            val_37.Points1 = val_43 - 1;
            if(val_37 != null)
            {
                goto label_47;
            }
            
            goto label_48;
        }
        public override void Dispose()
        {
            mem[1152921559720095368] = 1;
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
            
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            return;
            label_2:
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌上与丙一业丑东丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丟一丆丁丕丘丟上不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.GameModeEvents.东不丈下丏丂丂丏丆::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        }
        public override string 丙丄上丆丝丂丘专丒()
        {
            if(CompleteResult != 2)
            {
                    return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6490"), arg0:  this.丘丌专上不三七丆世 - X21.Points1);
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6508");
        }
        public override string 与丏丞丟丆七丈丐上()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6793"), arg0:  this);
        }
        public override string 丂丌丐丕丝不且丏丅()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_6793"), arg0:  this);
        }
        public override int 丘且丘下丁丑丗且丒()
        {
        
        }
        public override bool 万且丏丂下丘丄不丑()
        {
            return true;
        }
    
    }

}
