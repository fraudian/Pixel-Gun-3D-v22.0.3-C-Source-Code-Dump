using UnityEngine;

namespace Progress
{
    internal static class 业丏且下丕一丄丝丆
    {
        // Fields
        private static BestHTTP.Decompression.Crc.CRC32 丛丄东丄丘不七丏下;
        
        // Properties
        private static BestHTTP.Decompression.Crc.CRC32 丑且丝丂一丆三且丞 { get; }
        
        // Methods
        private static BestHTTP.Decompression.Crc.CRC32 专东丒丕丏丗且丘丑()
        {
            BestHTTP.Decompression.Crc.CRC32 val_2;
            BestHTTP.Decompression.Crc.CRC32 val_3 = Progress.业丏且下丕一丄丝丆.丛丄东丄丘不七丏下;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            BestHTTP.Decompression.Crc.CRC32 val_1 = null;
            val_2 = val_1;
            val_1 = new BestHTTP.Decompression.Crc.CRC32();
            Progress.业丏且下丕一丄丝丆.丛丄东丄丘不七丏下 = val_2;
            val_3 = Progress.业丏且下丕一丄丝丆.丛丄东丄丘不七丏下;
            return val_3;
        }
        internal static int 丞丂丗下丌丁丒不丁(string 丑东与丅丐丅丂丞业)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            BestHTTP.Decompression.Crc.CRC32 val_2 = Progress.业丏且下丕一丄丝丆.专东丒丕丏丗且丘丑();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            label_6:
            val_2.SlurpBlock(block:  val_1, offset:  0, count:  val_1.dataItem);
            Progress.业丏且下丕一丄丝丆.专东丒丕丏丗且丘丑().Reset();
            return (int)Progress.业丏且下丕一丄丝丆.专东丒丕丏丗且丘丑().Crc32Result;
            label_1:
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        internal static string 且丁上一丞丅丐丞丘(string 丑东与丅丐丅丂丞业)
        {
            return (string)Progress.业丏且下丕一丄丝丆.丞丂丗下丌丁丒不丁(丑东与丅丐丅丂丞业:  丑东与丅丐丅丂丞业).ToString(format:  "x8").ToLowerInvariant();
        }
    
    }

}
