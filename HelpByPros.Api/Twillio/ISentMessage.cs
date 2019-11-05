using System.Collections.Generic;

namespace HelpByPros.Api.Model
{
    public interface ISentMessage
    {
        public void SentMessageThruPhoneCreate(string x, IEnumerable<string> phoneList);

    }
}