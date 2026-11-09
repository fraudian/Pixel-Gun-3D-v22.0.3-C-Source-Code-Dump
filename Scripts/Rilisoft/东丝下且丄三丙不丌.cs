using UnityEngine;

namespace Rilisoft
{
    public class 东丝下且丄三丙不丌 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private static readonly string[] 万丐不东丌东丄且万;
        
        // Methods
        public 东丝下且丄三丙不丌(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            if(this.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.东丝下且丄三丙不丌::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
        public static System.Collections.Generic.Dictionary<string, object> 丕不丒丌与丕丄丆丈(System.Collections.Generic.Dictionary<string, object> 丅丌丟丟七专业丗一)
        {
            var val_4;
            var val_5;
            var val_6;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(丅丌丟丟七专业丗一 == null)
            {
                    return val_1;
            }
            
            val_4 = 1152921505423937536;
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            goto label_4;
            label_9:
            if((丅丌丟丟七专业丗一.ContainsKey(key:  Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.__il2cppRuntimeField_20)) != false)
            {
                    val_1.set_Item(key:  Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.__il2cppRuntimeField_20, value:  丅丌丟丟七专业丗一.Item[Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.__il2cppRuntimeField_20]);
            }
            
            val_6 = 1;
            label_4:
            if(val_6 < Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.Length)
            {
                goto label_9;
            }
            
            return val_1;
        }
        private void 且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
        {
            string val_6;
            var val_7;
            var val_8;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            CategoryNames val_2 = 丗丛不丁丑专专丂且.丄丄世七三业丝丛丘();
            string val_3 = val_2.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_2.丑丕丁三不丛丏丂丞(下上丐丆丝丟丝丒不:  val_3)) == true)
            {
                    return;
            }
            
            val_2.丂丏一业丑丄丝丐丄(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  0);
            var val_6 = 0;
            do
            {
                val_7 = null;
                val_7 = null;
                if(val_6 >= Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.Length)
            {
                    return;
            }
            
                val_8 = null;
                val_8 = null;
                val_6 = mem[Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.Length + 32];
                val_6 = Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.Length + 32;
                val_6 = val_6 + 1;
            }
            while((Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万.丑丕丁三不丛丏丂丞(下上丐丆丝丟丝丒不:  val_6)) == false);
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.东丝下且丄三丙不丌::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
        private static 东丝下且丄三丙不丌()
        {
            string[] val_1 = new string[6];
            val_1[0] = "PrimaryCategory";
            val_1[1] = "BackupCategory";
            val_1[2] = "MeleeCategory";
            val_1[3] = "SpecilCategory";
            val_1[4] = "SniperCategory";
            val_1[5] = "PremiumCategory";
            Rilisoft.东丝下且丄三丙不丌.万丐不东丌东丄且万 = val_1;
        }
    
    }

}
