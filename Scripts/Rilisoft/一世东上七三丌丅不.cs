using UnityEngine;

namespace Rilisoft
{
    internal sealed class 一世东上七三丌丅不
    {
        // Fields
        private const string 丁丝丗丒丘专丈下与 = "AnimatedForLevel";
        private static readonly Rilisoft.一世东上七三丌丅不 世丒丞七专三与万丕;
        private static readonly Rilisoft.七丕丟丏三丈一丄世[] 丟七不一丌丈丞三丈;
        
        // Properties
        internal static Rilisoft.一世东上七三丌丅不 丆丕丝丒不丙且丐丗 { get; }
        public System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世> 丑丈丞丅丛丏一丒丙 { get; }
        
        // Methods
        private 一世东上七三丌丅不()
        {
        
        }
        internal static Rilisoft.一世东上七三丌丅不 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.一世东上七三丌丅不)Rilisoft.一世东上七三丌丅不.世丒丞七专三与万丕;
        }
        public System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世> 七不丈专丙世丅丕丝()
        {
            null = null;
            return (System.Collections.Generic.IEnumerable<Rilisoft.七丕丟丏三丈一丄世>)Rilisoft.一世东上七三丌丅不.丟七不一丌丈丞三丈;
        }
        public System.Collections.Generic.IList<Rilisoft.七丕丟丏三丈一丄世> 丏丙丐丕下三丗丁且()
        {
            null = null;
            return (System.Collections.Generic.IList<Rilisoft.七丕丟丏三丈一丄世>)Rilisoft.一世东上七三丌丅不.丟七不一丌丈丞三丈;
        }
        internal int 丞三丈丑丅东丈丟丄()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  "AnimatedForLevel", defaultValue:  2147483647);
        }
        internal void 丙丑与七丄下丑丅东(int 丈丘丝一丗下丈丐不)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "AnimatedForLevel", value:  丈丘丝一丗下丈丐不);
        }
        internal bool 业且万丝丛东丂丄丑(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            bool val_2 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  this.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌));
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        internal int 丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            string val_4;
            if(上且丗一丏丏万丅丌 == 35)
            {
                    val_4 = "feature.tournament";
                int val_1 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  val_4);
            }
            else
            {
                    val_4 = 上且丗一丏丏万丅丌;
                int val_2 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  val_4);
            }
            
            if(val_2 != 2147483647)
            {
                    return val_2;
            }
            
            return 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  BalanceController.三丛丕丆一丆丆业丂(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌));
        }
        private static 一世东上七三丌丅不()
        {
            Rilisoft.一世东上七三丌丅不.世丒丞七专三与万丕 = new Rilisoft.一世东上七三丌丅不();
            Rilisoft.一世东上七三丌丅不.丟七不一丌丈丞三丈 = new Rilisoft.七丕丟丏三丈一丄世[15];
        }
    
    }

}
