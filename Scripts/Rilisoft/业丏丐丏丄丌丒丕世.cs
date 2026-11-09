using UnityEngine;

namespace Rilisoft
{
    internal class 业丏丐丏丄丌丒丕世
    {
        // Fields
        private static Rilisoft.业丏丐丏丄丌丒丕世 丝业丆丁业三丈丟东;
        private System.Collections.Generic.Dictionary<string, Rilisoft.不丗上万丟丏不丄下> 丅上丈上丝丛上下一;
        
        // Properties
        internal static Rilisoft.业丏丐丏丄丌丒丕世 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static Rilisoft.业丏丐丏丄丌丒丕世 丑七不且上丗丁一世()
        {
            Rilisoft.业丏丐丏丄丌丒丕世 val_2 = Rilisoft.业丏丐丏丄丌丒丕世.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Rilisoft.业丏丐丏丄丌丒丕世 val_1 = null;
            val_2 = val_1;
            val_1 = new Rilisoft.业丏丐丏丄丌丒丕世();
            Rilisoft.业丏丐丏丄丌丒丕世.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal Rilisoft.不丗上万丟丏不丄下 专一上不三丒上七丏(string 丞丕丒专一下丙业上)
        {
            System.Collections.Generic.Dictionary<System.String, Rilisoft.不丗上万丟丏不丄下> val_6;
            var val_7;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) != false)
            {
                    Rilisoft.不丗上万丟丏不丄下 val_2 = null;
                val_7 = val_2;
                val_2 = new Rilisoft.不丗上万丟丏不丄下(丞丕丒专一下丙业上:  丞丕丒专一下丙业上);
                return (Rilisoft.不丗上万丟丏不丄下)val_7;
            }
            
            val_6 = this.丅上丈上丝丛上下一;
            if((val_6.ContainsKey(key:  丞丕丒专一下丙业上)) != true)
            {
                    val_6 = this.丅上丈上丝丛上下一;
                val_6.Add(key:  丞丕丒专一下丙业上, value:  new Rilisoft.不丗上万丟丏不丄下(丞丕丒专一下丙业上:  丞丕丒专一下丙业上));
            }
            
            val_7 = this.丅上丈上丝丛上下一.Item[丞丕丒专一下丙业上];
            return (Rilisoft.不丗上万丟丏不丄下)val_7;
        }
        public 业丏丐丏丄丌丒丕世()
        {
            this.丅上丈上丝丛上下一 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.不丗上万丟丏不丄下>();
        }
    
    }

}
