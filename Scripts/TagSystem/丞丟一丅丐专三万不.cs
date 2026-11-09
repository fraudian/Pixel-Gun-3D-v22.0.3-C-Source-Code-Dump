using UnityEngine;

namespace TagSystem
{
    internal class 丞丟一丅丐专三万不
    {
        // Fields
        private TagSystem.三与下丘七丘丌丏丄 <丙丝万丈丟丕丛丑丗>k__BackingField;
        private TagSystem.下万上丅丗丂丄七上 <丐丂丌丙且丌丕下上>k__BackingField;
        
        // Properties
        internal TagSystem.三与下丘七丘丌丏丄 一丟丘万世一下不下 { get; set; }
        internal TagSystem.下万上丅丗丂丄七上 丙丛上世丅丆专与丟 { get; set; }
        
        // Methods
        internal TagSystem.三与下丘七丘丌丏丄 与不丞丑七丘丁丂丛()
        {
            return (TagSystem.三与下丘七丘丌丏丄)this.<丙丝万丈丟丕丛丑丗>k__BackingField;
        }
        private void 东上丄丅下一丛丘丁(TagSystem.三与下丘七丘丌丏丄 丙业与丙丗丝不丈东)
        {
            this.<丙丝万丈丟丕丛丑丗>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal TagSystem.下万上丅丗丂丄七上 上丒丗且丒业七七三()
        {
            return (TagSystem.下万上丅丗丂丄七上)this.<丐丂丌丙且丌丕下上>k__BackingField;
        }
        private void 丁与丗丕丅丏丑丆丅(TagSystem.下万上丅丗丂丄七上 丙业与丙丗丝不丈东)
        {
            this.<丐丂丌丙且丌丕下上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丞丟一丅丐专三万不(TagSystem.三与下丘七丘丌丏丄 东丌丕上丞万丌丙丑, TagSystem.下万上丅丗丂丄七上 丟且丒专下丈七丗丕)
        {
            this.<丙丝万丈丟丕丛丑丗>k__BackingField = 东丌丕上丞万丌丙丑;
            this.<丐丂丌丙且丌丕下上>k__BackingField = 丟且丒专下丈七丗丕;
        }
        internal 丞丟一丅丐专三万不(string 东丌丕上丞万丌丙丑, TagSystem.下万上丅丗丂丄七上 丟且丒专下丈七丗丕)
        {
            TagSystem.三与下丘七丘丌丏丄 val_1 = new TagSystem.三与下丘七丘丌丏丄();
            bool val_2 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  东丌丕上丞万丌丙丑);
            this.<丙丝万丈丟丕丛丑丗>k__BackingField = val_1;
            this.<丐丂丌丙且丌丕下上>k__BackingField = 丟且丒专下丈七丗丕;
        }
        internal bool 丞丐丂与下与上且丆(TagSystem.三与下丘七丘丌丏丄 专丛丐上丈丙丏丛丂)
        {
            if((this.<丙丝万丈丟丕丛丑丗>k__BackingField) == null)
            {
                    return false;
            }
            
            if((this.<丙丝万丈丟丕丛丑丗>k__BackingField.不丈丅万不下丙丄丅()) == false)
            {
                    return false;
            }
            
            if(专丛丐上丈丙丏丛丂 != null)
            {
                    return 专丛丐上丈丙丏丛丂.丂丆世世丕丅丕丅上(丘丛丏丘丝七世七丅:  this.<丙丝万丈丟丕丛丑丗>k__BackingField, 丟且丒专下丈七丗丕:  this.<丐丂丌丙且丌丕下上>k__BackingField);
            }
            
            return 专丛丐上丈丙丏丛丂.丂丆世世丕丅丕丅上(丘丛丏丘丝七世七丅:  this.<丙丝万丈丟丕丛丑丗>k__BackingField, 丟且丒专下丈七丗丕:  this.<丐丂丌丙且丌丕下上>k__BackingField);
        }
        internal bool 丞丐丂与下与上且丆(string 专丛丐上丈丙丏丛丂)
        {
            TagSystem.三与下丘七丘丌丏丄 val_1 = new TagSystem.三与下丘七丘丌丏丄();
            bool val_2 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  专丛丐上丈丙丏丛丂);
            return this.丞丐丂与下与上且丆(专丛丐上丈丙丏丛丂:  val_1);
        }
        internal bool 专丐万三丑不丄东业(System.Collections.Generic.IList<TagSystem.三与下丘七丘丌丏丄> 丅东世丄丙七不丙业)
        {
            var val_5;
            var val_6;
            if(丅东世丄丙七不丙业 == null)
            {
                goto label_1;
            }
            
            val_5 = 0;
            val_6 = 0;
            goto label_2;
            label_12:
            var val_8 = 0;
            val_8 = val_8 + 1;
            TagSystem.三与下丘七丘丌丏丄 val_9 = 丅东世丄丙七不丙业.Item[0];
            if(val_9 != 0)
            {
                    val_9 = (this.丞丐丂与下与上且丆(专丛丐上丈丙丏丛丂:  val_9)) ^ 1;
                val_5 = val_5 - val_9;
                val_6 = val_6 | val_9;
            }
            
            val_5 = val_5 + 1;
            label_2:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_5 < 丅东世丄丙七不丙业.Count)
            {
                goto label_12;
            }
            
            return (bool)val_6 & 1;
            label_1:
            val_6 = 0;
            return (bool)val_6 & 1;
        }
    
    }

}
