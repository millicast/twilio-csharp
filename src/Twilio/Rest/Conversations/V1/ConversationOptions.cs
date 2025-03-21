/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
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




namespace Twilio.Rest.Conversations.V1
{

    /// <summary> Create a new conversation in your account's default service </summary>
    public class CreateConversationOptions : IOptions<ConversationResource>
    {
        
        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        public string UniqueName { get; set; }

        ///<summary> The date that this resource was created. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date that this resource was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this conversation belongs to. </summary> 
        public string MessagingServiceSid { get; set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </summary> 
        public string Attributes { get; set; }

        
        public ConversationResource.StateEnum State { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string TimersInactive { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string TimersClosed { get; set; }

        ///<summary> The default email address that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailAddress { get; set; }

        ///<summary> The default name that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailName { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (TimersInactive != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Inactive", TimersInactive));
            }
            if (TimersClosed != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Closed", TimersClosed));
            }
            if (BindingsEmailAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Address", BindingsEmailAddress));
            }
            if (BindingsEmailName != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Name", BindingsEmailName));
            }
            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }
    /// <summary> Remove a conversation from your account's default service </summary>
    public class DeleteConversationOptions : IOptions<ConversationResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }



        /// <summary> Construct a new DeleteConversationOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public DeleteConversationOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


    /// <summary> Fetch a conversation from your account's default service </summary>
    public class FetchConversationOptions : IOptions<ConversationResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchConversationOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public FetchConversationOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

    

    }


    /// <summary> Retrieve a list of conversations in your account's default service </summary>
    public class ReadConversationOptions : ReadOptions<ConversationResource>
    {
    
        ///<summary> Specifies the beginning of the date range for filtering Conversations based on their creation date. Conversations that were created on or after this date will be included in the results. The date must be in ISO8601 format, specifically starting at the beginning of the specified date (YYYY-MM-DDT00:00:00Z), for precise filtering. This parameter can be combined with other filters. If this filter is used, the returned list is sorted by latest conversation creation date in descending order. </summary> 
        public string StartDate { get; set; }

        ///<summary> Defines the end of the date range for filtering conversations by their creation date. Only conversations that were created on or before this date will appear in the results.  The date must be in ISO8601 format, specifically capturing up to the end of the specified date (YYYY-MM-DDT23:59:59Z), to ensure that conversations from the entire end day are included. This parameter can be combined with other filters. If this filter is used, the returned list is sorted by latest conversation creation date in descending order. </summary> 
        public string EndDate { get; set; }

        ///<summary> State for sorting and filtering list of Conversations. Can be `active`, `inactive` or `closed` </summary> 
        public ConversationResource.StateEnum State { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

    

    }

    /// <summary> Update an existing conversation in your account's default service </summary>
    public class UpdateConversationOptions : IOptions<ConversationResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The date that this resource was created. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date that this resource was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </summary> 
        public string Attributes { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this conversation belongs to. </summary> 
        public string MessagingServiceSid { get; set; }

        
        public ConversationResource.StateEnum State { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string TimersInactive { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string TimersClosed { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        public string UniqueName { get; set; }

        ///<summary> The default email address that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailAddress { get; set; }

        ///<summary> The default name that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailName { get; set; }



        /// <summary> Construct a new UpdateConversationOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public UpdateConversationOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (TimersInactive != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Inactive", TimersInactive));
            }
            if (TimersClosed != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Closed", TimersClosed));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (BindingsEmailAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Address", BindingsEmailAddress));
            }
            if (BindingsEmailName != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Name", BindingsEmailName));
            }
            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


}

