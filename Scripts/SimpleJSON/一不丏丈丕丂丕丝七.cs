using UnityEngine;

namespace SimpleJSON
{
    public class 一不丏丈丕丂丕丝七 : 且丐上一丝业不专上
    {
        // Fields
        private string 丄专下业世丒万丐丘;
        
        // Properties
        public override string 不丑一丙东丙丆丁七 { get; set; }
        
        // Methods
        public override string 世三丞丅丑丌丈丈一()
        {
            return (string)this.丄专下业世丒万丐丘;
        }
        public override void 丙丏不三丗三丙丈与(string 丙业与丙丗丝不丈东)
        {
            this.丄专下业世丒万丐丘 = 丙业与丙丗丝不丈东;
        }
        public 一不丏丈丕丂丕丝七(string 丈丏丟丏丕丅丏七丛)
        {
            val_1 = new System.Object();
            this.丄专下业世丒万丐丘 = 丈丏丟丏丕丅丏七丛;
        }
        public 一不丏丈丕丂丕丝七(float 丈丏丟丏丕丅丏七丛)
        {
            val_1 = new System.Object();
            val_1.丌不不丌丄丞丁与丕(丙业与丙丗丝不丈东:  丈丏丟丏丕丅丏七丛);
        }
        public 一不丏丈丕丂丕丝七(double 丈丏丟丏丕丅丏七丛)
        {
            val_1 = new System.Object();
            val_1.丑丟丘不丏丟丞与丒(丙业与丙丗丝不丈东:  丈丏丟丏丕丅丏七丛);
        }
        public 一不丏丈丕丂丕丝七(bool 丈丏丟丏丕丅丏七丛)
        {
            val_1 = new System.Object();
            val_1.丕专下不丁丄不丒东(丙业与丙丗丝不丈东:  丈丏丟丏丕丅丏七丛);
        }
        public 一不丏丈丕丂丕丝七(int 丈丏丟丏丕丅丏七丛)
        {
            val_1 = new System.Object();
            val_1.丘东丗三丕不下世与(丙业与丙丗丝不丈东:  丈丏丟丏丕丅丏七丛);
        }
        public override string ToString()
        {
            return "\"" + SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  this.丄专下业世丒万丐丘)(SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  this.丄专下业世丒万丐丘)) + "\"";
        }
        public override string 一丁与丙世与东丆丆(string 三丁丞且丌万丛丝专)
        {
            return "\"" + SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  this.丄专下业世丒万丐丘)(SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  this.丄专下业世丒万丐丘)) + "\"";
        }
        public override void 丙业不丝丗丌丗世下(System.IO.BinaryWriter 丕丅丕丘万专丟丆丞)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_11;
            var val_15;
            var val_16;
            var val_17;
            var val_19;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_31 = 丕丅丕丘万专丟丆丞;
            val_32 = this;
            SimpleJSON.一不丏丈丕丂丕丝七 val_1 = null;
            val_33 = val_1;
            val_1 = new SimpleJSON.一不丏丈丕丂丕丝七();
            .丄专下业世丒万丐丘 = "";
            val_1.丘东丗三丕不下世与(丙业与丙丗丝不丈东:  this.丗一丁上丗上丒业丏());
            if((System.String.op_Equality(a:  (SimpleJSON.一不丏丈丕丂丕丝七)[1152921541565252544].丄专下业世丒万丐丘, b:  this.丄专下业世丒万丐丘)) == false)
            {
                goto label_3;
            }
            
            int val_4 = this.丗一丁上丗上丒业丏();
            label_14:
            val_34 = ???;
            val_32 = ???;
            val_31 = ???;
            val_33 = ???;
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_248;
            label_3:
            if((System.String.op_Equality(a:  val_33 + 16, b:  val_32 + 16)) == false)
            {
                goto label_6;
            }
            
            val_34 = val_7;
            val_32 = val_8;
            val_31 = val_9;
            val_33 = val_11;
            goto val_31 + 648;
            label_6:
            if((System.String.op_Equality(a:  val_11 + 16, b:  val_8 + 16)) == false)
            {
                goto label_9;
            }
            
            val_34 = val_15;
            val_32 = val_16;
            val_31 = val_17;
            val_33 = val_19;
            goto val_9 + 536;
            label_9:
            var val_21 = val_32 & 1;
            if((System.String.op_Equality(a:  val_19 + 16, b:  val_16 + 16)) == false)
            {
                goto val_17 + 664;
            }
            
            var val_23 = val_32 & 1;
            goto label_14;
        }
    
    }

}
