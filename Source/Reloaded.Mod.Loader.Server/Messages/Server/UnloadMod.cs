﻿using Reloaded.Messaging.Compression;
using Reloaded.Messaging.Messages;
using Reloaded.Messaging.Serialization;
using Reloaded.Messaging.Serializer.MessagePack;

namespace Reloaded.Mod.Loader.Server.Messages.Server
{
    public struct UnloadMod : IMessage<MessageType>
    {
        public MessageType GetMessageType() => MessageType.UnloadMod;
        public ISerializer GetSerializer() => new MsgPackSerializer(true);
        public ICompressor GetCompressor() => null;

        public string ModId { get; set; }
    }
}