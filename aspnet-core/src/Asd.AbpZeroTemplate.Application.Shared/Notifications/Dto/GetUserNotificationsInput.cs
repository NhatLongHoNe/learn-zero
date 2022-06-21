using System;
using Abp.Notifications;
using Asd.AbpZeroTemplate.Dto;

namespace Asd.AbpZeroTemplate.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}