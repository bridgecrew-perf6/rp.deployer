using System.Collections.Generic;

namespace RP.Deployer.Commons.Model.Dto
{
    public class StepConfigDto
    {
        public string Title { get; set; }
        public string TimeExecution { get; set; }
        public List<StepDto> Steps { get; set; }
        public List<MailDto> MailNotification { get; set; }
    }
}