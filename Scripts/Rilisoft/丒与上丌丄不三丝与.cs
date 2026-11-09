using UnityEngine;

namespace Rilisoft
{
    internal class 丒与上丌丄不三丝与
    {
        // Fields
        private const string 丛丂专丂丝丗世世丛 = "minigames-player-scores";
        private static Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丒与上丌丄不三丝与> 丝业丆丁业三丈丟东;
        private System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, int> 七丒丂丘业丝丑丆丞;
        
        // Properties
        internal static Rilisoft.丒与上丌丄不三丝与 丆丕丝丒不丙且丐丗 { get; }
        private System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, int> 丞丂专丒与与七万与 { get; }
        
        // Methods
        internal static Rilisoft.丒与上丌丄不三丝与 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.丒与上丌丄不三丝与.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.丒与上丌丄不三丝与.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.丒与上丌丄不三丝与.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        private System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, int> 丑一三丙丐丕丕三丕()
        {
            int val_5;
            if(this.七丒丂丘业丝丑丆丞 != null)
            {
                    return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32>)this.七丒丂丘业丝丑丆丞;
            }
            
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32>();
            this.七丒丂丘业丝丑丆丞 = val_1;
            List.Enumerator<T> val_3 = val_1.专丕丗业丄丘专业丆().GetEnumerator();
            label_7:
            if(((-50344760) & 1) == 0)
            {
                goto label_3;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                    val_5 = val_4.m_stringLength;
            }
            else
            {
                    val_5 = 11993091;
            }
            
            this.七丒丂丘业丝丑丆丞.Add(key:  val_5, value:  val_4.m_firstChar);
            goto label_7;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32>)this.七丒丂丘业丝丑丆丞;
        }
        public void 专三七丞丂三丏丄东(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 万且丒下丕丝专丟上)
        {
            var val_7;
            Progress.BestScoreType val_8;
            if(上且丗一丏丏万丅丌 == 12)
            {
                goto label_1;
            }
            
            if(上且丗一丏丏万丅丌 != 13)
            {
                goto label_2;
            }
            
            val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_8 = 2;
            goto label_6;
            label_1:
            val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_8 = 1;
            label_6:
            val_7.万丒不丒与丏与且丅(丞与丙丞丌业一万丄:  万且丒下丕丝专丟上, 丕丛丂万丂专丈一不:  val_8);
            return;
            label_2:
            if((this.丑一三丙丐丕丕三丕().ContainsKey(key:  上且丗一丏丏万丅丌)) != true)
            {
                    this.丑一三丙丐丕丕三丕().Add(key:  上且丗一丏丏万丅丌, value:  0);
            }
            
            this.丑一三丙丐丕丕三丕().set_Item(key:  上且丗一丏丏万丅丌, value:  万且丒下丕丝专丟上);
            this.万且丅丆丞丅丗丄专();
        }
        public void 丑丝下丟丈上丄丒不(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 万且丒下丕丝专丟上)
        {
            var val_8;
            if((this.丑一三丙丐丕丕三丕().ContainsKey(key:  上且丗一丏丏万丅丌)) != true)
            {
                    this.丑一三丙丐丕丕三丕().Add(key:  上且丗一丏丏万丅丌, value:  0);
            }
            
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32> val_4 = this.丑一三丙丐丕丕三丕();
            if(val_4 != null)
            {
                    val_8 = val_4.Item[上且丗一丏丏万丅丌];
            }
            else
            {
                    val_8 = 0.Item[上且丗一丏丏万丅丌];
            }
            
            val_4.set_Item(key:  上且丗一丏丏万丅丌, value:  val_8 + 万且丒下丕丝专丟上);
            this.万且丅丆丞丅丗丄专();
        }
        public int 丛丗七三丄丑丂丗丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            var val_9;
            var val_10;
            if(上且丗一丏丏万丅丌 == 12)
            {
                goto label_1;
            }
            
            if(上且丗一丏丏万丅丌 != 13)
            {
                goto label_2;
            }
            
            val_9 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
            val_10 = val_9;
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = val_10.丅丏丄专丄丑丏三丛();
            goto label_6;
            label_1:
            val_9 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
            val_10 = val_9;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = val_10.丐丐三七丆丂丄三丘();
            label_6:
            return (int);
            label_2:
            if((this.丑一三丙丐丕丕三丕().ContainsKey(key:  上且丗一丏丏万丅丌)) == false)
            {
                    return (int);
            }
            
            int val_8 = this.丑一三丙丐丕丕三丕().Item[上且丗一丏丏万丅丌];
            return (int);
        }
        public int 丘丙丌丕丄丕丏丅七(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            if((this.丑一三丙丐丕丕三丕().ContainsKey(key:  上且丗一丏丏万丅丌)) == false)
            {
                    return 0;
            }
            
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32> val_3 = this.丑一三丙丐丕丕三丕();
            if(val_3 != null)
            {
                    return val_3.Item[上且丗一丏丏万丅丌];
            }
            
            return val_3.Item[上且丗一丏丏万丅丌];
        }
        private System.Collections.Generic.List<Rilisoft.丒与上丌丄不三丝与.GameScores> 专丕丗业丄丘专业丆()
        {
            System.Collections.Generic.List<GameScores> val_5;
            string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "minigames-player-scores");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true)
            {
                    if((UnityEngine.JsonUtility.FromJson<ScoresContainer>(json:  val_1)) != null)
            {
                    val_5 = val_3.Scores;
                if(val_5 != null)
            {
                    return (System.Collections.Generic.List<GameScores>)val_5;
            }
            
            }
            
            }
            
            System.Collections.Generic.List<GameScores> val_4 = null;
            val_5 = val_4;
            val_4 = new System.Collections.Generic.List<GameScores>();
            return (System.Collections.Generic.List<GameScores>)val_5;
        }
        private void 万且丅丆丞丅丗丄专()
        {
            System.Collections.Generic.List<GameScores> val_1 = new System.Collections.Generic.List<GameScores>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丑一三丙丐丕丕三丕().GetEnumerator();
            label_5:
            if(( & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            new 丒与上丌丄不三丝与.GameScores() = new System.Object();
            .GameMode = val_4.丙东专丂世丈丏丁丂();
            .Scores = val_4;
            val_1.Add(item:  new 丒与上丌丄不三丝与.GameScores());
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            .Scores = val_1;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "minigames-player-scores", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new 丒与上丌丄不三丝与.ScoresContainer()));
        }
        public 丒与上丌丄不三丝与()
        {
        
        }
        private static 丒与上丌丄不三丝与()
        {
            null = null;
            Rilisoft.丒与上丌丄不三丝与.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丒与上丌丄不三丝与>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丒与上丌丄不三丝与>(object:  丒与上丌丄不三丝与.<>c.<>9, method:  Rilisoft.丒与上丌丄不三丝与 丒与上丌丄不三丝与.<>c::丞丞专丂丂丞七丅丄()));
        }
    
    }

}
