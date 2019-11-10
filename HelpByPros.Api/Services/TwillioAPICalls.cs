using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Extensions.Configuration;
using System;

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
        public IConfiguration Configuration { get; }

        public void SentMessageThruPhoneCreate(string x, IEnumerable<string> phoneList )
        {

            foreach (string phone in phoneList)
            {
                try
                {
                    TwilioClient.Init(Configuration.GetConnectionString("AccountSid"), Configuration.GetConnectionString("AuthToken"));
                    var message = MessageResource.Create(
                      body: x,
                      from: new Twilio.Types.PhoneNumber("+12565768348"),
                      to: new Twilio.Types.PhoneNumber(phone)
                    );
                }
                catch
                {
                    throw new NullReferenceException("There is no phone number or in incorrect format");
                }
               
            }


        }
    }
}
