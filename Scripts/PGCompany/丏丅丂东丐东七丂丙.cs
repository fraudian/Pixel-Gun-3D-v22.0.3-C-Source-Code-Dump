using UnityEngine;

namespace PGCompany
{
    internal class 丏丅丂东丐东七丂丙 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private PGCompany.丟丝东丈丐丙三下丛 丕丛丞上七丗丅专丂;
        private 三丅丁丗丗丝丂万且 丅丗世丝丌与与丕下;
        
        // Properties
        internal PGCompany.丟丝东丈丐丙三下丛 丟丞丏丘丘丙且专不 { get; }
        private 三丅丁丗丗丝丂万且 三丅丁丗丗丝丂万且 { get; }
        internal ItemRarity 丟丞丞丌丟丝业丑世 { get; }
        
        // Methods
        public 丏丅丂东丐东七丂丙(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丏丅丂东丐东七丂丙(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        internal PGCompany.丟丝东丈丐丙三下丛 业丒三丟丈丁世丕一()
        {
            if(this.丕丛丞上七丗丅专丂 != null)
            {
                    return val_3;
            }
            
            PGCompany.丟丝东丈丐丙三下丛 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝东丈丐丙三下丛>(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七());
            this.丕丛丞上七丗丅专丂 = val_3;
            return val_3;
        }
        private 三丅丁丗丗丝丂万且 丌与丑丘丞且专东丐()
        {
            if(this.丅丗世丝丌与与丕下 != null)
            {
                    return val_2;
            }
            
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七());
            this.丅丗世丝丌与与丕下 = val_2;
            return val_2;
        }
        internal int 三丌上丒丆三一万丁()
        {
            丕丑丙丑丙东丌丘丕 val_12 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.业上丙丞丐丄丆丅七());
            if(val_12 == null)
            {
                    丕丑丙丑丙东丌丘丕 val_6 = null;
                val_12 = val_6;
                val_6 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  this.丌与丑丘丞且专东丐(), 丏丆丐丑专与丄丘丞:  this.业丒三丟丈丁世丕一());
            }
            
            int val_11 = BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_6);
            val_11 = (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_6.丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  this.专丂万上丄丌丝丙与()))) - val_11;
            return (int)val_11;
        }
        internal int 丑丁丙丁丕丄丂业万()
        {
            丕丑丙丑丙东丌丘丕 val_10 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.业上丙丞丐丄丆丅七());
            if(val_10 != null)
            {
                    return BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_6.丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  this.专丂万上丄丌丝丙与()));
            }
            
            丕丑丙丑丙东丌丘丕 val_6 = null;
            val_10 = val_6;
            val_6 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  this.丌与丑丘丞且专东丐(), 丏丆丐丑专与丄丘丞:  this.业丒三丟丈丁世丕一());
            return BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_6.丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  this.专丂万上丄丌丝丙与()));
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10471"), arg0:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.专丂万上丄丌丝丙与()));
        }
        internal override string 东且丏丆万与东丙万()
        {
            object val_5;
            PGCompany.丟丝东丈丐丙三下丛 val_2 = this.业丒三丟丈丁世丕一();
            if(val_2 != null)
            {
                    val_5 = val_2;
                return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10472"), arg0:  val_5 = 0, arg1:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.专丂万上丄丌丝丙与()));
            }
            
            return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10472"), arg0:  val_5, arg1:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.专丂万上丄丌丝丙与()));
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            if(this.业丒三丟丈丁世丕一() == null)
            {
                
            }
        
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/efficience");
        }
        internal ItemRarity 专丂万上丄丌丝丙与()
        {
            return UnityEngine.Mathf.Min(a:  5, b:  this.丂丁丏一丙丛业且丌() + this.业丒三丟丈丁世丕一());
        }
    
    }

}
