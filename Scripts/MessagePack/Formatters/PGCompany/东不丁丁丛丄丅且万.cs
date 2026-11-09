using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 东不丁丁丛丄丅且万 : IMessagePackFormatter<PGCompany.丌七丒万丝丄东且七.上丅且且万丅丞三丗>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丌七丒万丝丄东且七.上丅且且万丅丞三丗 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_27;
            var val_28;
            MessagePack.MessagePackWriter val_29;
            bool val_30;
            MessagePack.IFormatterResolver val_31;
            var val_32;
            Rilisoft.丝丑丂丛万丐丈丘且 val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_27 = 丆与丛丅丂三万一丑;
            val_28 = 丙业与丙丗丝不丈东;
            val_29 = 1152921541930106784;
            val_30 = true;
            if(val_28 != null)
            {
                    val_31 = val_27.Resolver;
                val_32 = 1152921541903703776;
                val_33 = 丙业与丙丗丝不丈东.Id;
                val_35 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_31);
                val_36 = 1152921504968347648;
                var val_26 = 0;
                val_26 = val_26 + 1;
            }
            else
            {
                    val_29 = ???;
                val_27 = ???;
                val_31 = ???;
                val_28 = ???;
                val_34 = ???;
                val_33 = ???;
                val_32 = ???;
                val_35 = ???;
                val_36 = ???;
                val_30 = val_30 + ((X11) << 4);
                val_37 = val_30 + 296;
            }
            
            val_35.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<RatingLeague>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_28 = 0;
            val_28 = val_28 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_7 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_31);
            var val_29 = 0;
            val_29 = val_29 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_31);
            var val_30 = 0;
            val_30 = val_30 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_31);
            var val_31 = 0;
            val_31 = val_31 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_31);
            var val_32 = 0;
            val_32 = val_32 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_13, typeof(), slot: 0);
        }
        public PGCompany.丌七丒万丝丄东且七.上丅且且万丅丞三丗 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_18;
            var val_19;
            RatingLeague val_20;
            string val_21;
            Rilisoft.丝丑丂丛万丐丈丘且 val_22;
            val_19 = 0;
            if((1152921541930337696 & 1) != 0)
            {
                    return (上丅且且万丅丞三丗)val_19;
            }
            
            val_18 = 丆与丛丅丂三万一丑.Security;
            val_18.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541930337696 < 1)
            {
                goto label_5;
            }
            
            val_20 = 0;
            val_21 = 0;
            var val_33 = 0;
            val_22 = 0;
            label_63:
            if(val_33 > 6)
            {
                goto label_62;
            }
            
            var val_25 = -18973244;
            val_25 = val_25 + 106070220;
            goto (-18973244 + 106070220);
            label_62:
            val_33 = val_33 + 1;
            if(val_33 != 1152921541930337696)
            {
                goto label_63;
            }
            
            goto label_64;
            label_5:
            val_22 = 0;
            val_21 = 0;
            val_20 = 0;
            label_64:
            丌七丒万丝丄东且七.上丅且且万丅丞三丗 val_24 = null;
            val_19 = val_24;
            val_24 = new 丌七丒万丝丄东且七.上丅且且万丅丞三丗();
            if(val_19 != null)
            {
                    .Id = val_22;
                .Rating = val_20;
                .Info = val_21;
                mem[1152921541930386936] = 0;
                .TotalPlayer = 0;
                mem[1152921541930386968] = 0;
                .DropScore = 0;
                mem[1152921541930386984] = 0;
                .DropThreshold = 0;
                mem[1152921541930387000] = 0;
            }
            else
            {
                    mem[16] = val_22;
                mem[24] = 0;
                mem[32] = val_20;
                mem[40] = val_21;
                mem[48] = 0;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                mem[88] = 0;
            }
            
            .LiftThreshold = 0;
            mem[1152921541930387016] = 0;
            return (上丅且且万丅丞三丗)val_19;
        }
        public 东不丁丁丛丄丅且万()
        {
        
        }
    
    }

}
