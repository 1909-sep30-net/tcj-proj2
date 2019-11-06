using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HelpByPros.Api.Model
{
    public class TwillioAPICalls: ISentMessage
    {
        const string accountSid = "ACb2f0a2d1f5f829ece5396990ac998d02";
        const string authToken = "bb8d54f67dfdd6ca7ce96aa5b4e4259c";

        /// <summary>
        /// Our project Twillio is a trail so function is very limited 
        /// and only verified phone number can recieve calls
        /// </summary>
        /// <param name="x"></param>
        /// <param name="phoneList"></param>

        public void SentMessageThruPhoneCreate(string x, IEnumerable<string> phoneList )
        {
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
              body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
              from: new Twilio.Types.PhoneNumber("+12565405918"),
              to: new Twilio.Types.PhoneNumber("+19166128983")
            );



        }
    }
}
