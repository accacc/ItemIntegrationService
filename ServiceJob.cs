using ItemIntegrationService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemIntegrationService
{
    public  class ServiceJob: ServiceExecuter
    {
        
        public ServiceJob(string Content):base(Content)
        {
                
        }
        public override async Task<ServiceResult> ExecuteAsync()
        {
            await Task.Delay(2000);
            //Console.WriteLine($"İçeriğe sahip öğe '{this.Content}' kaydedildi.");
            return new ServiceResult { IsSuccess = true, Message = $"Öğe '{this.Content}' işlendi." };
        }
    }
}
