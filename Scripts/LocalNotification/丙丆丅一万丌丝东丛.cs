using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丙丆丅一万丌丝东丛 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540878695976] = val_1;
            .下丄丈不与世丐业专 = "PixelPass_EndSeason";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丙丆丅一万丌丝东丛::丑丞丘丌丝丈三丐丈());
            val_1.set_Item(key:  "PixelPass_EndSeason", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "PixelPass_5dayEnd";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丙丆丅一万丌丝东丛::下丈丗丞丟丟丙丂万());
            val_1.set_Item(key:  "PixelPass_5dayEnd", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "PixelPass_newTask";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丙丆丅一万丌丝东丛::东丅丕丐且丒丌丞丆());
            val_1.set_Item(key:  "PixelPass_newTask", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丑丞丘丌丝丈三丐丈()
        {
            System.TimeSpan val_12;
            var val_13;
            if((((PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() != false) && (PixelTime.丙丅丅业丟丁世丁丗() > 0)) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丂与丐下一丟丆丌与() <= 43200)) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丂与丐下一丟丆丌与() > 0))
            {
                    System.TimeSpan val_10 = System.TimeSpan.FromHours(value:  12);
                val_12 = val_10._ticks;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_10._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_12;
            }
            
                val_13 = null;
            }
            else
            {
                    val_13 = null;
            }
            
            val_12 = System.TimeSpan.Zero;
            return val_12;
        }
        private System.TimeSpan 下丈丗丞丟丟丙丂万()
        {
            var val_14;
            System.TimeSpan val_15;
            System.TimeSpan val_1 = this.丑丞丘丌丝丈三丐丈();
            val_14 = null;
            val_14 = null;
            if(((((System.TimeSpan.op_Inequality(t1:  new System.TimeSpan() {_ticks = val_1._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != true) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() != false)) && (PixelTime.丙丅丅业丟丁世丁丗() > 0)) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丂与丐下一丟丆丌与() >= 1))
            {
                    if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().丂与丐下一丟丆丌与() < 432001)
            {
                    System.TimeSpan val_12 = System.TimeSpan.FromHours(value:  12);
                val_15 = val_12._ticks;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_12._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_15;
            }
            
            }
            
            }
            
            val_15 = System.TimeSpan.Zero;
            return val_15;
        }
        private System.TimeSpan 东丅丕丐且丒丌丞丆()
        {
            var val_16;
            var val_17;
            System.TimeSpan val_18;
            System.TimeSpan val_1 = this.丑丞丘丌丝丈三丐丈();
            val_16 = null;
            val_16 = null;
            bool val_2 = System.TimeSpan.op_Inequality(t1:  new System.TimeSpan() {_ticks = val_1._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero});
            if(val_2 != true)
            {
                    System.TimeSpan val_3 = val_2.下丈丗丞丟丟丙丂万();
                val_17 = null;
                val_17 = null;
                if(((((System.TimeSpan.op_Inequality(t1:  new System.TimeSpan() {_ticks = val_3._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != true) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() != false)) && (PixelTime.丙丅丅业丟丁世丁丗() > 0)) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().且丑丅丑丈丐丙丟丄() <= 43200))
            {
                    if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙().且丑丅丑丈丐丙丟丄() > 0)
            {
                    System.TimeSpan val_14 = System.TimeSpan.FromHours(value:  12);
                val_18 = val_14._ticks;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_14._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_18;
            }
            
            }
            
            }
            
            }
            
            val_18 = System.TimeSpan.Zero;
            return val_18;
        }
        public 丙丆丅一万丌丝东丛()
        {
            val_1 = new System.Object();
        }
    
    }

}
