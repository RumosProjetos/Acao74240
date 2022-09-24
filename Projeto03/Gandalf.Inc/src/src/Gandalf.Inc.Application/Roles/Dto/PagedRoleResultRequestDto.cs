using Abp.Application.Services.Dto;

namespace Gandalf.Inc.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

