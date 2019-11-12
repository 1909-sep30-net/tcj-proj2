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
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
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
