using UnityEngine;

namespace Competition
{
    internal class 与丝丆丝丘丕七丞丒
    {
        // Fields
        private static string 专丕七丈世丝丞一与;
        private System.Collections.Generic.List<string> 丌不丙丝东丝丟丈丈;
        private bool 丟丁丄万丅东丛丛丗;
        private static Competition.与丝丆丝丘丕七丞丒 丝业丆丁业三丈丟东;
        
        // Properties
        internal static Competition.与丝丆丝丘丕七丞丒 丆丕丝丒不丙且丐丗 { get; }
        private static string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal static Competition.与丝丆丝丘丕七丞丒 丑七不且上丗丁一世()
        {
            Competition.与丝丆丝丘丕七丞丒 val_2 = Competition.与丝丆丝丘丕七丞丒.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Competition.与丝丆丝丘丕七丞丒 val_1 = null;
            val_2 = val_1;
            val_1 = new Competition.与丝丆丝丘丕七丞丒();
            Competition.与丝丆丝丘丕七丞丒.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        protected 与丝丆丝丘丕七丞丒()
        {
            LifetimeEventsRaiser.丑七不且上丗丁一世().丈丒丒东下丆丙丄丌(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Competition.与丝丆丝丘丕七丞丒::上世世且丈七三丏丙(bool 世下丐丌一丗一丞丌)));
            LifetimeEventsRaiser.丑七不且上丗丁一世().丐业丆一业不丁一专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Competition.与丝丆丝丘丕七丞丒::不丏丒丏丄丕丕丞上()));
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Competition.与丝丆丝丘丕七丞丒::丝上七不丞下东丞丆()));
            this.不丘丝丑东丆东三丐();
        }
        private void 丝上七不丞下东丞丆()
        {
            this.三丒丂万丝丒下丌三();
            Competition.与丝丆丝丘丕七丞丒.丟七丛丑不丐上七丁();
            this.不丘丝丑东丆东三丐();
        }
        internal void 丒丝世专下上丞上丞(CategoryNames 七丆丒与丗丌丄且丂, string 丝三丛且丘不丌丙下)
        {
            string val_9 = 丝三丛且丘不丌丙下;
            if(七丆丒与丗丌丄且丂 >= 6)
            {
                goto label_1;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9 = 丝三丛且丘不丌丙下)) == false)
            {
                goto label_4;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = (val_9 == null) ? "null" : (val_9);
            UnityEngine.Debug.LogErrorFormat(format:  "Competition.CompetitionUn_equipWeaponHelper.SaveUnequ_ippedWeapon tag = {0}", args:  val_2);
            return;
            label_1:
            object[] val_4 = new object[1];
            val_9 = val_4;
            val_9[0] = 七丆丒与丗丌丄且丂;
            UnityEngine.Debug.LogErrorFormat(format:  "Competition.CompetitionUn_equipWeaponHelper.SaveUnequ_ippedWeapon cat = {0}", args:  val_4);
            return;
            label_4:
            int val_5 = this.丌不丙丝东丝丟丈丈.Count;
            if((val_5 - 1) < 七丆丒与丗丌丄且丂)
            {
                    CategoryNames val_8 = (七丆丒与丗丌丄且丂 + 1) - val_5;
                if(val_8 >= 1)
            {
                    do
            {
                this.丌不丙丝东丝丟丈丈.Add(item:  System.String.alignConst);
                val_8 = val_8 - 1;
            }
            while(val_8 != 0);
            
            }
            
            }
            
            this.丌不丙丝东丝丟丈丈.set_Item(index:  七丆丒与丗丌丄且丂, value:  val_9);
            this.丟丁丄万丅东丛丛丗 = true;
        }
        internal string 丑丟下不丒世丑丆七(CategoryNames 七丆丒与丗丌丄且丂)
        {
            int val_4;
            if((七丆丒与丗丌丄且丂 & 2147483648) == 0)
            {
                    if((this.丌不丙丝东丝丟丈丈.Count - 1) >= 七丆丒与丗丌丄且丂)
            {
                    return (string)this.丌不丙丝东丝丟丈丈.Item[七丆丒与丗丌丄且丂];
            }
            
            }
            
            val_4 = System.String.alignConst;
            return (string)this.丌不丙丝东丝丟丈丈.Item[七丆丒与丗丌丄且丂];
        }
        internal void 丁丂丟且丆七一业丑(CategoryNames 七丆丒与丗丌丄且丂)
        {
            System.Collections.Generic.List<System.String> val_3;
            if((七丆丒与丗丌丄且丂 & 2147483648) != 0)
            {
                    return;
            }
            
            val_3 = this.丌不丙丝东丝丟丈丈;
            if((val_3.Count - 1) < 七丆丒与丗丌丄且丂)
            {
                    return;
            }
            
            val_3 = System.String.alignConst;
            this.丌不丙丝东丝丟丈丈.set_Item(index:  七丆丒与丗丌丄且丂, value:  val_3);
            this.丟丁丄万丅东丛丛丗 = true;
        }
        private void 不丏丒丏丄丕丕丞上()
        {
            this.三丒丂万丝丒下丌三();
        }
        private void 上世世且丈七三丏丙(bool 世下丐丌一丗一丞丌)
        {
            if(世下丐丌一丗一丞丌 == false)
            {
                    return;
            }
            
            this.三丒丂万丝丒下丌三();
        }
        private void 不丘丝丑东丆东三丐()
        {
            var val_10;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  Competition.与丝丆丝丘丕七丞丒.三丄丈丞一专丝丛丛())) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  Competition.与丝丆丝丘丕七丞丒.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  "[]");
            }
            
            if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  Competition.与丝丆丝丘丕七丞丒.三丄丈丞一专丝丛丛()))) != null)
            {
                    val_10 = 0;
            }
            
            this.丌不丙丝东丝丟丈丈 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        private void 三丒丂万丝丒下丌三()
        {
            if(this.丟丁丄万丅东丛丛丗 == false)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  Competition.与丝丆丝丘丕七丞丒.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丌不丙丝东丝丟丈丈));
            this.丟丁丄万丅东丛丛丗 = false;
        }
        private static void 丟七丛丑不丐上七丁()
        {
            Competition.与丝丆丝丘丕七丞丒.专丕七丈世丝丞一与 = "CompetitionUnequipWeaponHelper.PreviousEquippedWeapons.v1." + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        }
        private static string 三丄丈丞一专丝丛丛()
        {
            string val_1 = Competition.与丝丆丝丘丕七丞丒.专丕七丈世丝丞一与;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            Competition.与丝丆丝丘丕七丞丒.丟七丛丑不丐上七丁();
            val_1 = Competition.与丝丆丝丘丕七丞丒.专丕七丈世丝丞一与;
            return val_1;
        }
    
    }

}
