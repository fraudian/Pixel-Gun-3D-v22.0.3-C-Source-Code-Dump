using UnityEngine;

namespace PlatformSupport.Collections.Specialized
{
    public class 丗下上丌丄万丝丗丛 : EventArgs
    {
        // Fields
        private PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 丄丐且丂上丒丑专丂;
        private System.Collections.IList 业一丒三丆丑丅业东;
        private System.Collections.IList 丞丟丝下下丂丑下三;
        private int 丞丏下丙丑丛丛世丄;
        private int 一丑丂丐丙与丄下丙;
        
        // Properties
        public PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 丞丐丗丞丑丁丅丘七 { get; }
        public System.Collections.IList 丁丝丒七一一下不丆 { get; }
        public System.Collections.IList 万与上业丕不一七丂 { get; }
        public int 丂万丈丅丏丆丄与三 { get; }
        public int 丝与丙且世业丑丘丟 { get; }
        
        // Methods
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆)
        {
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 == 4)
            {
                    this.业一丒三丆丑丅业东 = 0;
                this.丄丐且丂上丒丑专丂 = 4;
                this.丞丏下丙丑丛丛世丄 = 0;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "action");
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, object 一丄三东丝一丒上丅)
        {
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 < 2)
            {
                    object[] val_1 = new object[1];
                val_1[0] = 一丄三东丝一丒上丅;
                this.丗与丌丘丈专丈丁丙(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丄业丅丐不丄业丁丟:  val_1, 丐万丕丅丏丘丛丗丙:  0);
                return;
            }
            
            if((七丐丅专且专七三丆 == 4) && (一丄三东丝一丒上丅 == null))
            {
                    this.业一丒三丆丑丅业东 = 0;
                this.丄丐且丂上丒丑专丂 = 4;
                this.丞丏下丙丑丛丛世丄 = 0;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "action");
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, object 一丄三东丝一丒上丅, int 丞世不丒下上上丝丑)
        {
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 < 2)
            {
                    object[] val_1 = new object[1];
                val_1[0] = 一丄三东丝一丒上丅;
                this.丗与丌丘丈专丈丁丙(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丄业丅丐不丄业丁丟:  val_1, 丐万丕丅丏丘丛丗丙:  丞世不丒下上上丝丑);
                return;
            }
            
            if(((七丐丅专且专七三丆 == 4) && (一丄三东丝一丒上丅 == null)) && (丞世不丒下上上丝丑 == 1))
            {
                    this.业一丒三丆丑丅业东 = 0;
                this.丄丐且丂上丒丑专丂 = 4;
                this.丞丏下丙丑丛丛世丄 = 0;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "action");
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丄业丅丐不丄业丁丟)
        {
            var val_3;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 > 4)
            {
                goto label_6;
            }
            
            var val_3 = 1;
            val_3 = val_3 << 七丐丅专且专七三丆;
            val_3 = val_3 & 19;
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            if(七丐丅专且专七三丆 != 4)
            {
                goto label_5;
            }
            
            if(丄业丅丐不丄业丁丟 != null)
            {
                goto label_6;
            }
            
            this.业一丒三丆丑丅业东 = 0;
            this.丄丐且丂上丒丑专丂 = 4;
            this.丞丏下丙丑丛丛世丄 = 0;
            return;
            label_5:
            if(丄业丅丐不丄业丁丟 == null)
            {
                goto label_8;
            }
            
            this.丗与丌丘丈专丈丁丙(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丄业丅丐不丄业丁丟:  丄业丅丐不丄业丁丟, 丐万丕丅丏丘丛丗丙:  0);
            return;
            label_6:
            System.ArgumentException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentException(message:  "action");
            goto label_9;
            label_8:
            System.ArgumentNullException val_2 = null;
            val_3 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "changedItems");
            label_9:
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丄业丅丐不丄业丁丟, int 丐万丕丅丏丘丛丗丙)
        {
            string val_4;
            var val_5;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 > 4)
            {
                goto label_7;
            }
            
            var val_3 = 1;
            val_3 = val_3 << 七丐丅专且专七三丆;
            val_3 = val_3 & 19;
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            if(七丐丅专且专七三丆 != 4)
            {
                goto label_5;
            }
            
            if((丄业丅丐不丄业丁丟 != null) || (丐万丕丅丏丘丛丗丙 != 1))
            {
                goto label_7;
            }
            
            this.业一丒三丆丑丅业东 = 0;
            this.丄丐且丂上丒丑专丂 = 4;
            this.丞丏下丙丑丛丛世丄 = 0;
            return;
            label_5:
            if(丄业丅丐不丄业丁丟 == null)
            {
                goto label_9;
            }
            
            if(丐万丕丅丏丘丛丗丙 <= 2)
            {
                goto label_10;
            }
            
            this.丗与丌丘丈专丈丁丙(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丄业丅丐不丄业丁丟:  丄业丅丐不丄业丁丟, 丐万丕丅丏丘丛丗丙:  丐万丕丅丏丘丛丗丙);
            return;
            label_7:
            val_4 = "action";
            goto label_11;
            label_9:
            System.ArgumentNullException val_1 = null;
            val_5 = val_1;
            val_1 = new System.ArgumentNullException(paramName:  "changedItems");
            goto label_12;
            label_10:
            System.ArgumentException val_2 = null;
            val_4 = "startingIndex";
            label_11:
            val_5 = val_2;
            val_2 = new System.ArgumentException(message:  val_4);
            label_12:
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, object 丏一丕东丙丆与丒丄, object 丌丏丗与丕丈丄三丈)
        {
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 == 2)
            {
                    object[] val_1 = new object[1];
                val_1[0] = 丏一丕东丙丆与丒丄;
                object[] val_2 = new object[1];
                val_2[0] = 丌丏丗与丕丈丄三丈;
                this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  2, 丙丙与丕不丞丛丐业:  val_1, 丟上且东丙业且业丑:  0);
                this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  2, 丏三下一七业丆与下:  val_2, 业一丘丏丟上丕与丒:  0);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "action");
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, object 丏一丕东丙丆与丒丄, object 丌丏丗与丕丈丄三丈, int 丞世不丒下上上丝丑)
        {
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 == 2)
            {
                    object[] val_1 = new object[1];
                val_1[0] = 丏一丕东丙丆与丒丄;
                object[] val_2 = new object[1];
                val_2[0] = 丌丏丗与丕丈丄三丈;
                this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  2, 丙丙与丕不丞丛丐业:  val_1, 丟上且东丙业且业丑:  丞世不丒下上上丝丑);
                this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  2, 丏三下一七业丆与下:  val_2, 业一丘丏丟上丕与丒:  丞世不丒下上上丝丑);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "action");
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业, System.Collections.IList 丏三下一七业丆与下)
        {
            var val_3;
            string val_5;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 != 2)
            {
                goto label_3;
            }
            
            if(丙丙与丕不丞丛丐业 == null)
            {
                goto label_4;
            }
            
            if(丏三下一七业丆与下 == null)
            {
                goto label_5;
            }
            
            this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  2, 丙丙与丕不丞丛丐业:  丙丙与丕不丞丛丐业, 丟上且东丙业且业丑:  0);
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  2, 丏三下一七业丆与下:  丏三下一七业丆与下, 业一丘丏丟上丕与丒:  0);
            return;
            label_3:
            System.ArgumentException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentException(message:  "action");
            goto label_6;
            label_4:
            val_5 = "newItems";
            goto label_7;
            label_5:
            System.ArgumentNullException val_2 = null;
            val_5 = "oldItems";
            label_7:
            val_3 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  val_5);
            label_6:
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业, System.Collections.IList 丏三下一七业丆与下, int 丐万丕丅丏丘丛丗丙)
        {
            var val_3;
            string val_5;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 != 2)
            {
                goto label_3;
            }
            
            if(丙丙与丕不丞丛丐业 == null)
            {
                goto label_4;
            }
            
            if(丏三下一七业丆与下 == null)
            {
                goto label_5;
            }
            
            this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  2, 丙丙与丕不丞丛丐业:  丙丙与丕不丞丛丐业, 丟上且东丙业且业丑:  丐万丕丅丏丘丛丗丙);
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  2, 丏三下一七业丆与下:  丏三下一七业丆与下, 业一丘丏丟上丕与丒:  丐万丕丅丏丘丛丗丙);
            return;
            label_3:
            System.ArgumentException val_1 = null;
            val_3 = val_1;
            val_1 = new System.ArgumentException(message:  "action");
            goto label_6;
            label_4:
            val_5 = "newItems";
            goto label_7;
            label_5:
            System.ArgumentNullException val_2 = null;
            val_5 = "oldItems";
            label_7:
            val_3 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  val_5);
            label_6:
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, object 一丄三东丝一丒上丅, int 丞世不丒下上上丝丑, int 专三丌与丄丗业丌丈)
        {
            string val_4;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 != 3)
            {
                goto label_3;
            }
            
            if((丞世不丒下上上丝丑 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = 一丄三东丝一丒上丅;
            this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  3, 丙丙与丕不丞丛丐业:  val_1, 丟上且东丙业且业丑:  丞世不丒下上上丝丑);
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  3, 丏三下一七业丆与下:  val_1, 业一丘丏丟上丕与丒:  专三丌与丄丗业丌丈);
            return;
            label_3:
            val_4 = "action";
            goto label_9;
            label_4:
            val_4 = "index";
            label_9:
            null = new System.ArgumentException(message:  val_4);
        }
        public 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丄业丅丐不丄业丁丟, int 丞世不丒下上上丝丑, int 专三丌与丄丗业丌丈)
        {
            string val_3;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            if(七丐丅专且专七三丆 != 3)
            {
                goto label_3;
            }
            
            if((丞世不丒下上上丝丑 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  3, 丙丙与丕不丞丛丐业:  丄业丅丐不丄业丁丟, 丟上且东丙业且业丑:  丞世不丒下上上丝丑);
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  3, 丏三下一七业丆与下:  丄业丅丐不丄业丁丟, 业一丘丏丟上丕与丒:  专三丌与丄丗业丌丈);
            return;
            label_3:
            val_3 = "action";
            goto label_5;
            label_4:
            val_3 = "index";
            label_5:
            null = new System.ArgumentException(message:  val_3);
        }
        internal 丗下上丌丄万丝丗丛(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业, System.Collections.IList 丏三下一七业丆与下, int 上丏丐丒丘丝世丐世, int 专三丌与丄丗业丌丈)
        {
            System.Collections.IList val_3;
            System.Collections.IList val_4;
            this.丞丏下丙丑丛丛世丄 = 0;
            this.一丑丂丐丙与丄下丙 = 0;
            this.丄丐且丂上丒丑专丂 = 七丐丅专且专七三丆;
            if(丙丙与丕不丞丛丐业 != null)
            {
                    PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑 val_1 = null;
                val_3 = val_1;
                val_1 = new PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑();
                .丄丅不七丝三不丒东 = 丙丙与丕不丞丛丐业;
            }
            else
            {
                    val_3 = 0;
            }
            
            this.业一丒三丆丑丅业东 = val_3;
            if(丏三下一七业丆与下 != null)
            {
                    PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑 val_2 = null;
                val_4 = val_2;
                val_2 = new PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑();
                .丄丅不七丝三不丒东 = 丏三下一七业丆与下;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.丞丟丝下下丂丑下三 = val_4;
            this.丞丏下丙丑丛丛世丄 = 上丏丐丒丘丝世丐世;
            this.一丑丂丐丙与丄下丙 = 专三丌与丄丗业丌丈;
        }
        private void 丗与丌丘丈专丈丁丙(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丄业丅丐不丄业丁丟, int 丐万丕丅丏丘丛丗丙)
        {
            if(七丐丅专且专七三丆 != 1)
            {
                    if(七丐丅专且专七三丆 != 0)
            {
                    return;
            }
            
                this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丙丙与丕不丞丛丐业:  丄业丅丐不丄业丁丟, 丟上且东丙业且业丑:  丐万丕丅丏丘丛丗丙);
                return;
            }
            
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丏三下一七业丆与下:  丄业丅丐不丄业丁丟, 业一丘丏丟上丕与丒:  丐万丕丅丏丘丛丗丙);
        }
        private void 丏七上丈丈丏丕丈丂(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业, int 丟上且东丙业且业丑)
        {
            System.Collections.IList val_2;
            this.丄丐且丂上丒丑专丂 = 七丐丅专且专七三丆;
            if(丙丙与丕不丞丛丐业 != null)
            {
                    PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑 val_1 = null;
                val_2 = val_1;
                val_1 = new PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑();
                .丄丅不七丝三不丒东 = 丙丙与丕不丞丛丐业;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.业一丒三丆丑丅业东 = val_2;
            this.丞丏下丙丑丛丛世丄 = 丟上且东丙业且业丑;
        }
        private void 丗丘万专丙丁丂丏世(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丏三下一七业丆与下, int 业一丘丏丟上丕与丒)
        {
            System.Collections.IList val_2;
            this.丄丐且丂上丒丑专丂 = 七丐丅专且专七三丆;
            if(丏三下一七业丆与下 != null)
            {
                    PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑 val_1 = null;
                val_2 = val_1;
                val_1 = new PlatformSupport.Collections.Specialized.丒丅且下丘丙一丒丑();
                .丄丅不七丝三不丒东 = 丏三下一七业丆与下;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.丞丟丝下下丂丑下三 = val_2;
            this.一丑丂丐丙与丄下丙 = 业一丘丏丟上丕与丒;
        }
        private void 丛业世丛丅丐三丂业(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业, System.Collections.IList 丏三下一七业丆与下, int 丐万丕丅丏丘丛丗丙, int 业一丘丏丟上丕与丒)
        {
            this.丏七上丈丈丏丕丈丂(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丙丙与丕不丞丛丐业:  丙丙与丕不丞丛丐业, 丟上且东丙业且业丑:  丐万丕丅丏丘丛丗丙);
            this.丗丘万专丙丁丂丏世(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丏三下一七业丆与下:  丏三下一七业丆与下, 业一丘丏丟上丕与丒:  业一丘丏丟上丕与丒);
        }
        public PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 三丁世与三七三丈专()
        {
            return (PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction)this.丄丐且丂上丒丑专丂;
        }
        public System.Collections.IList 丟专七丛万丕世不且()
        {
            return (System.Collections.IList)this.业一丒三丆丑丅业东;
        }
        public System.Collections.IList 与丏丄下丑不与丂丝()
        {
            return (System.Collections.IList)this.丞丟丝下下丂丑下三;
        }
        public int 丄丐丐丆丁专丁丌丝()
        {
            return (int)this.丞丏下丙丑丛丛世丄;
        }
        public int 丛与丁且且丄且业丁()
        {
            return (int)this.一丑丂丐丙与丄下丙;
        }
    
    }

}
