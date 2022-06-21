using System.Collections.Generic;

namespace Asd.AbpZeroTemplate.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}