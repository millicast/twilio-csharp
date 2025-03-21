/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.IpMessaging.V1.Service.Channel
{

    /// <summary> create </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string Body { get; }

        
        public string From { get; set; }

        
        public string Attributes { get; set; }


        /// <summary> Construct a new CreateMessageOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="body">  </param>
        public CreateMessageOptions(string pathServiceSid, string pathChannelSid, string body)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Body = body;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteMessageOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> fetch </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchMessageOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> read </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public MessageResource.OrderTypeEnum Order { get; set; }



        /// <summary> Construct a new ListMessageOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        public ReadMessageOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

    

    }

    /// <summary> update </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string PathSid { get; }

        
        public string Body { get; set; }

        
        public string Attributes { get; set; }



        /// <summary> Construct a new UpdateMessageOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        public UpdateMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            return p;
        }

        

    }


}

