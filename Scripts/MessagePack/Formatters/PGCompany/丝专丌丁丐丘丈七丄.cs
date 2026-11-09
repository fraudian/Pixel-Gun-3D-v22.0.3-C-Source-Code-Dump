using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丝专丌丁丐丘丈七丄 : IMessagePackFormatter<PGCompany.StorePromotionSettings>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.StorePromotionSettings 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_92;
            var val_93;
            MessagePack.MessagePackWriter val_94;
            MessagePack.IFormatterResolver val_95;
            var val_96;
            var val_97;
            val_92 = 丆与丛丅丂三万一丑;
            val_93 = 丙业与丙丗丝不丈东;
            val_94 = 1152921541928624208;
            bool val_92 = true;
            if(val_93 != null)
            {
                    val_95 = val_92.Resolver;
                val_96 = 1152921541903713024;
                MessagePack.Formatters.IMessagePackFormatter<T> val_2 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_95);
                val_97 = 1152921504968347648;
            }
            else
            {
                    val_94 = ???;
                val_92 = ???;
                val_95 = ???;
                val_93 = ???;
                val_96 = ???;
                val_97 = ???;
                val_92 = val_92 + ((X11) << 4);
                var val_3 = val_92 + 296;
            }
            
            MessagePack.Formatters.IMessagePackFormatter<T> val_4 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_6 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_8 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_10 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.丑丘丂丝丐上丆丆世>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_12 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_14 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_16 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_18 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_20 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.StorePromotionPurchaseSettings>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_24 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.丝且七万丄一丏丌丙>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_26 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<丌丟丐丞三丘三丏丈>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_28 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<万丆且丁业且丕七丈>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_30 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_32 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_34 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_95);
            MessagePack.Formatters.IMessagePackFormatter<T> val_36 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Decimal>(resolver:  val_95);
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<TagSystem.三与下丘七丘丌丏丄>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            var val_93 = 0;
            val_93 = val_93 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.DataObjects.IntInterval>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_42 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_94 = 0;
            val_94 = val_94 + 1;
            var val_95 = 0;
            val_95 = val_95 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<丈下专丂丑不丑丗丁>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            var val_96 = 0;
            val_96 = val_96 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            var val_97 = 0;
            val_97 = val_97 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            var val_98 = 0;
            val_98 = val_98 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            var val_99 = 0;
            val_99 = val_99 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<七专丁丕世丏丁丘丛>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_54 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_100 = 0;
            val_100 = val_100 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_56 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_101 = 0;
            val_101 = val_101 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_58 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_102 = 0;
            val_102 = val_102 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_60 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_103 = 0;
            val_103 = val_103 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_62 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_104 = 0;
            val_104 = val_104 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_64 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_105 = 0;
            val_105 = val_105 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_66 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_106 = 0;
            val_106 = val_106 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_68 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_107 = 0;
            val_107 = val_107 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_70 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_108 = 0;
            val_108 = val_108 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_72 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_109 = 0;
            val_109 = val_109 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_74 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_110 = 0;
            val_110 = val_110 + 1;
            var val_111 = 0;
            val_111 = val_111 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.三东丏不丗世丅丌丄>(resolver:  val_95).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_94, _span = new System.Span<System.Byte>() {_length = val_94}, _segment = new System.ArraySegment<System.Byte>() {_count = val_94}, _buffered = val_94, _bytesCommitted = val_94, _sequencePool = val_94, _rental = new Rental() {owner = val_94, <Value>k__BackingField = val_94}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_94}, <OldSpec>k__BackingField = val_94}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_78 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_95);
            var val_112 = 0;
            val_112 = val_112 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_78, typeof(), slot: 0);
        }
        public PGCompany.StorePromotionSettings Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_82;
            string val_83;
            string val_84;
            string val_85;
            string val_86;
            PGCompany.丑丘丂丝丐上丆丆世 val_87;
            val_82 = 0;
            if((1152921541929122112 & 1) != 0)
            {
                    return (PGCompany.StorePromotionSettings)val_82;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541929122112 >= 1)
            {
                    val_83 = 0;
                val_84 = 0;
                val_85 = 0;
                val_86 = 0;
                val_87 = 0;
                do
            {
                if(0 <= 38)
            {
                    val_83 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  丆与丛丅丂三万一丑.Resolver);
            }
            
            }
            while(1 != 1152921541929122112);
            
            }
            else
            {
                    val_87 = 0;
                val_86 = 0;
                val_85 = 0;
                val_84 = 0;
                val_83 = 0;
            }
            
            PGCompany.StorePromotionSettings val_81 = null;
            val_82 = val_81;
            val_81 = new PGCompany.StorePromotionSettings();
            if(val_82 != null)
            {
                    .TitleLocKey = val_83;
                .DescriptionLocKey = val_84;
                .AditionalDescriptionLocKey = val_85;
                .TexturePath = val_86;
                .DescriptionHandlerType = val_87;
                .MainPrefabName = 0;
                .InfoPrefabName = 0;
                .BannerPrefabName = 0;
                .ExtendPrefabName = 0;
                .RewardPrefabName = 0;
                .PurchaseSettings = 0;
                .CountStorageType = 0;
                .ObtainCurrencyCause = 0;
                .SpendCurrencyCause = 0;
                .ItemsParams = 0;
                .StartTime = 0;
                mem[1152921541929303048] = 0;
                .EndTime = 0;
                mem[1152921541929303064] = 0;
                .ContentPrice = 0m;
                mem[1152921541929303080] = 0;
                .Tag = 0;
                .CollectProgress = 0;
                .InfoPrefabNameAlternative = 0;
                .ItemObtainPlace = 0;
                .Level = 0;
                mem[1152921541929303128] = 0;
                .ItemRewards = 0;
                .PresentationTime = 0;
                mem[1152921541929303152] = 0;
                .ObtainWeaponCause = 0;
                .GuiStyleMain = 0;
                .BackgroundTexture = 0;
                .IconFullBanner = 0;
                .IconMiniBannerLobby = 0;
                .IconBankCell = 0;
                .TimerLocKey = 0;
                .ButtonBuyLocKey = 0;
                .PriceLocKey = 0;
                .SaleLocKey = 0;
                .OldPriceLocKey = 0;
                .SaleStringValue = 0;
                .OldPrice = 0;
            }
            else
            {
                    mem[16] = val_83;
                mem[24] = val_84;
                mem[32] = val_85;
                mem[40] = val_86;
                mem[48] = val_87;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                mem[88] = 0;
                mem[96] = 0;
                mem[104] = 0;
                .ObtainCurrencyCause = 0;
                mem[112] = 0;
                mem[120] = 0;
                mem[128] = 0;
                mem[136] = 0;
                mem[144] = 0;
                mem[152] = 0;
                mem[160] = 0m;
                mem[168] = 0;
                mem[176] = 0;
                mem[184] = 0;
                mem[192] = 0;
                mem[200] = 0;
                mem[208] = 0;
                mem[216] = 0;
                mem[224] = 0;
                mem[232] = 0;
                mem[240] = 0;
                mem[248] = 0;
                mem[256] = 0;
                mem[264] = 0;
                mem[272] = 0;
                mem[280] = 0;
                mem[288] = 0;
                mem[296] = 0;
                mem[304] = 0;
                mem[312] = 0;
                mem[320] = 0;
                mem[328] = 0;
                mem[336] = 0;
                mem[344] = 0;
            }
            
            .MiniBannerPrefabName = 0;
            return (PGCompany.StorePromotionSettings)val_82;
        }
        public 丝专丌丁丐丘丈七丄()
        {
        
        }
    
    }

}
