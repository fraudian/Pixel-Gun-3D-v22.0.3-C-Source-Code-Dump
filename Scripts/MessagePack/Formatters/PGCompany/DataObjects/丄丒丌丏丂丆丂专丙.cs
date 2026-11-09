using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丄丒丌丏丂丆丂专丙 : IMessagePackFormatter<PGCompany.DataObjects.IntInterval>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.IntInterval 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    MessagePack.IFormatterResolver val_1 = 丆与丛丅丂三万一丑.Resolver;
                int val_2 = 丙业与丙丗丝不丈东.From;
                int val_3 = 丙业与丙丗丝不丈东.To;
                1152921541956392880 = ???;
            }
        
        }
        public PGCompany.DataObjects.IntInterval Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_4;
            var val_5;
            var val_6;
            val_5 = 0;
            if((1152921541956566288 & 1) != 0)
            {
                    return (PGCompany.DataObjects.IntInterval)val_5;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541956566288 < 1)
            {
                goto label_5;
            }
            
            val_4 = 0;
            val_6 = 0;
            var val_4 = 0;
            label_10:
            if(val_4 == 1)
            {
                goto label_6;
            }
            
            if(val_4 != 0)
            {
                goto label_7;
            }
            
            val_4 = 1152921541956566288;
            goto label_9;
            label_6:
            val_6 = 1152921541956566288;
            goto label_9;
            label_7:
            label_9:
            val_4 = val_4 + 1;
            if(1152921541956566288 != val_4)
            {
                goto label_10;
            }
            
            goto label_11;
            label_5:
            val_6 = 0;
            val_4 = 0;
            label_11:
            PGCompany.DataObjects.IntInterval val_3 = null;
            val_5 = val_3;
            val_3 = new PGCompany.DataObjects.IntInterval(丈丗与丞一上且上上:  0, 专丂丕丗丗东世丞下:  0);
            if(val_5 != null)
            {
                    val_3.From = 0;
            }
            else
            {
                    val_3.From = 0;
            }
            
            val_3.To = 0;
            return (PGCompany.DataObjects.IntInterval)val_5;
        }
        public 丄丒丌丏丂丆丂专丙()
        {
        
        }
    
    }

}
