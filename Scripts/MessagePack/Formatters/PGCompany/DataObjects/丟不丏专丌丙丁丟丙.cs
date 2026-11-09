using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丟不丏专丌丙丁丟丙 : IMessagePackFormatter<PGCompany.DataObjects.丒丆丂丂丞丝丐下丄.下丛丄且丕丁丐一不>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丒丆丂丂丞丝丐下丄.下丛丄且丕丁丐一不 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    MessagePack.IFormatterResolver val_1 = 丆与丛丅丂三万一丑.Resolver;
                1152921541955433136 = ???;
            }
        
        }
        public PGCompany.DataObjects.丒丆丂丂丞丝丐下丄.下丛丄且丕丁丐一不 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_4;
            var val_5;
            int val_6;
            int val_7;
            var val_8;
            int val_9;
            int val_10;
            float val_11;
            float val_12;
            float val_13;
            val_5 = 0;
            if((1152921541955606544 & 1) != 0)
            {
                    return (下丛丄且丕丁丐一不)val_5;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541955606544 < 1)
            {
                goto label_5;
            }
            
            val_6 = 0;
            val_7 = 0;
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            val_4 = 0;
            var val_7 = 0;
            val_11 = 0f;
            val_12 = 0f;
            val_13 = 0f;
            label_26:
            if(val_7 > 18)
            {
                goto label_25;
            }
            
            var val_6 = -21429196;
            val_6 = val_6 + 106067440;
            goto (-21429196 + 106067440);
            label_25:
            val_7 = val_7 + 1;
            if(1152921541955606544 != val_7)
            {
                goto label_26;
            }
            
            goto label_27;
            label_5:
            val_4 = 0;
            val_10 = 0;
            val_9 = 0;
            val_8 = 0;
            val_7 = 0;
            val_6 = 0;
            val_13 = 0f;
            val_12 = 0f;
            val_11 = 0f;
            label_27:
            丒丆丂丂丞丝丐下丄.下丛丄且丕丁丐一不 val_3 = null;
            val_5 = val_3;
            val_3 = new 丒丆丂丂丞丝丐下丄.下丛丄且丕丁丐一不();
            if(val_5 != null)
            {
                    .spotLimit = val_6;
                .spotLifetime = val_7;
                .teamLoseDifference = val_9;
                .spotSpawDelay = val_10;
                .spotCaptureTime = val_4;
                .spotCaptureSpeed = val_11;
                .spotCaptureCoeff = val_12;
                .enemySpotRollbackCoeff = val_13;
                .spotProgressCancelTime = 0;
                .spotAntiCaptureTime = 0;
                .spotAntiCaptureDelay = 0;
                .spotComebackSpawn = val_8 & 1;
                .enemySpotRollback = false;
                .playerOnSpot = false;
                .spotsPoint = 0;
                .oneTimeCapture = false;
                .spotProgressCancel = false;
                .winPointLimit = 0;
            }
            else
            {
                    mem[16] = val_6;
                .spotLifetime = val_7;
                mem[24] = val_8 & 1;
                .teamLoseDifference = val_9;
                mem[32] = val_10;
                .spotCaptureTime = val_4;
                mem[40] = val_11;
                .spotCaptureCoeff = val_12;
                mem[48] = 0;
                .enemySpotRollbackCoeff = val_13;
                mem[56] = 0;
                .oneTimeCapture = false;
                .spotProgressCancel = false;
                .spotProgressCancelTime = 0;
                mem[64] = 0;
                .spotAntiCaptureDelay = 0;
                mem[72] = 0;
                .winPointLimit = 0;
            }
            
            .matchTime = 0;
            return (下丛丄且丕丁丐一不)val_5;
        }
        public 丟不丏专丌丙丁丟丙()
        {
        
        }
    
    }

}
