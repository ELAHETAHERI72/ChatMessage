using System;
using System.Collections.Generic;

namespace MiladBass.Core.Domain
{
    public enum ParticipantRoleEnum
    {
        Member,
        Creator,
        Admin
    }


    public class MessageDomain 
    {
        public MessageEntity(string threadId, string body, string ownerId,
            bool hasReplay, bool seen, string replayMessageId, string thraedId)
        {
            ThreadId = threadId;
            Body = body;
            OwnerId = ownerId;
            HasReplay = hasReplay;
            Seen = seen;
            ReplayMessageId = replayMessageId;
            ThraedId = thraedId;
            Thread = null;
        }


        public string ThreadId { get; set; }
        public string Body { get; set; }
        public string OwnerId { get; set; }
        public bool HasReplay { get; set; }
        public bool Seen { get; set; }
        public string ReplayMessageId { get; set; }
      
        
        
        public string ThraedId { get; set; }
        public ThreadEntity Thread { get; set; }
    }
}