using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Extensions.Configuration;
using System;
using System.Text.RegularExpressions;

namespace HelpByPros.Api.Model
{
    public class TwillioAPICalls: ISentMessage
    {
        /// new stuff trying to revert thi
        /// <summary>
        /// Our project Twillio is a trail so function is very limited 
        /// and only verified phone number can recieve calls
        /// </summary>
        /// <param name="x"></param>
        /// <param name="phoneList"></param>
        /// 
        public TwillioAPICalls(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private static bool IsPhoneNumber(string number)
        {
          
                if (string.IsNullOrEmpty(number))
                    return false;
                var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                return r.IsMatch(number);

          
        }
        public IConfiguration Configuration { get; }

        public void SentMessageThruPhoneCreate(string x, IEnumerable<string> phoneList )
        {

            foreach (string phone in phoneList)
            {
                
                    if (IsPhoneNumber(phone))
                    {
                        TwilioClient.Init(Configuration.GetConnectionString("AccountSid"), Configuration.GetConnectionString("AuthToken"));
                        var message = MessageResource.Create(
                          body: x,
                          from: new Twilio.Types.PhoneNumber("+12565768348"),
                          to: new Twilio.Types.PhoneNumber(phone)
                        );
                    }
                    
             
            }



        }

    }
}
