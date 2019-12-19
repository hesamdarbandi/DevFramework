using System;


namespace DevFramework.Domain.Config
{
    public class AppSetting
    {        
        public string ApiEndpoint { get; set; }
        public string DefaultPageSize { get; set; }
        public string DefaultPageIndex { get; set; }
        public string ValidSelledCoupon { get; set; }
        public string IdentityServer { get; set; }
        public string SellPeriod { get; set; }                
    }
}