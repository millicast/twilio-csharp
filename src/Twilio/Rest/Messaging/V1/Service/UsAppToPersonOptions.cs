/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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
using System.Linq;



namespace Twilio.Rest.Messaging.V1.Service
{

    /// <summary> create </summary>
    public class CreateUsAppToPersonOptions : IOptions<UsAppToPersonResource>
    {
        
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to create the resources from. </summary> 
        public string PathMessagingServiceSid { get; }

        ///<summary> A2P Brand Registration SID </summary> 
        public string BrandRegistrationSid { get; }

        ///<summary> A short description of what this SMS campaign does. Min length: 40 characters. Max length: 4096 characters. </summary> 
        public string Description { get; }

        ///<summary> Required for all Campaigns. Details around how a consumer opts-in to their campaign, therefore giving consent to receive their messages. If multiple opt-in methods can be used for the same campaign, they must all be listed. 40 character minimum. 2048 character maximum. </summary> 
        public string MessageFlow { get; }

        ///<summary> An array of sample message strings, min two and max five. Min length for each sample: 20 chars. Max length for each sample: 1024 chars. </summary> 
        public List<string> MessageSamples { get; }

        ///<summary> A2P Campaign Use Case. Examples: [ 2FA, EMERGENCY, MARKETING..] </summary> 
        public string UsAppToPersonUsecase { get; }

        ///<summary> Indicates that this SMS campaign will send messages that contain links. </summary> 
        public bool? HasEmbeddedLinks { get; }

        ///<summary> Indicates that this SMS campaign will send messages that contain phone numbers. </summary> 
        public bool? HasEmbeddedPhone { get; }

        ///<summary> If end users can text in a keyword to start receiving messages from this campaign, the auto-reply messages sent to the end users must be provided. The opt-in response should include the Brand name, confirmation of opt-in enrollment to a recurring message campaign, how to get help, and clear description of how to opt-out. This field is required if end users can text in a keyword to start receiving messages from this campaign. 20 character minimum. 320 character maximum. </summary> 
        public string OptInMessage { get; set; }

        ///<summary> Upon receiving the opt-out keywords from the end users, Twilio customers are expected to send back an auto-generated response, which must provide acknowledgment of the opt-out request and confirmation that no further messages will be sent. It is also recommended that these opt-out messages include the brand name. This field is required if managing opt out keywords yourself (i.e. not using Twilio's Default or Advanced Opt Out features). 20 character minimum. 320 character maximum. </summary> 
        public string OptOutMessage { get; set; }

        ///<summary> When customers receive the help keywords from their end users, Twilio customers are expected to send back an auto-generated response; this may include the brand name and additional support contact information. This field is required if managing help keywords yourself (i.e. not using Twilio's Default or Advanced Opt Out features). 20 character minimum. 320 character maximum. </summary> 
        public string HelpMessage { get; set; }

        ///<summary> If end users can text in a keyword to start receiving messages from this campaign, those keywords must be provided. This field is required if end users can text in a keyword to start receiving messages from this campaign. Values must be alphanumeric. 255 character maximum. </summary> 
        public List<string> OptInKeywords { get; set; }

        ///<summary> End users should be able to text in a keyword to stop receiving messages from this campaign. Those keywords must be provided. This field is required if managing opt out keywords yourself (i.e. not using Twilio's Default or Advanced Opt Out features). Values must be alphanumeric. 255 character maximum. </summary> 
        public List<string> OptOutKeywords { get; set; }

        ///<summary> End users should be able to text in a keyword to receive help. Those keywords must be provided as part of the campaign registration request. This field is required if managing help keywords yourself (i.e. not using Twilio's Default or Advanced Opt Out features). Values must be alphanumeric. 255 character maximum. </summary> 
        public List<string> HelpKeywords { get; set; }

        ///<summary> A boolean that specifies whether campaign has Subscriber Optin or not. </summary> 
        public bool? SubscriberOptIn { get; set; }

        ///<summary> A boolean that specifies whether campaign is age gated or not. </summary> 
        public bool? AgeGated { get; set; }

        ///<summary> A boolean that specifies whether campaign allows direct lending or not. </summary> 
        public bool? DirectLending { get; set; }


        /// <summary> Construct a new CreateUsAppToPersonOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to create the resources from. </param>
        /// <param name="brandRegistrationSid"> A2P Brand Registration SID </param>
        /// <param name="description"> A short description of what this SMS campaign does. Min length: 40 characters. Max length: 4096 characters. </param>
        /// <param name="messageFlow"> Required for all Campaigns. Details around how a consumer opts-in to their campaign, therefore giving consent to receive their messages. If multiple opt-in methods can be used for the same campaign, they must all be listed. 40 character minimum. 2048 character maximum. </param>
        /// <param name="messageSamples"> An array of sample message strings, min two and max five. Min length for each sample: 20 chars. Max length for each sample: 1024 chars. </param>
        /// <param name="usAppToPersonUsecase"> A2P Campaign Use Case. Examples: [ 2FA, EMERGENCY, MARKETING..] </param>
        /// <param name="hasEmbeddedLinks"> Indicates that this SMS campaign will send messages that contain links. </param>
        /// <param name="hasEmbeddedPhone"> Indicates that this SMS campaign will send messages that contain phone numbers. </param>
        public CreateUsAppToPersonOptions(string pathMessagingServiceSid, string brandRegistrationSid, string description, string messageFlow, List<string> messageSamples, string usAppToPersonUsecase, bool? hasEmbeddedLinks, bool? hasEmbeddedPhone)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
            BrandRegistrationSid = brandRegistrationSid;
            Description = description;
            MessageFlow = messageFlow;
            MessageSamples = messageSamples;
            UsAppToPersonUsecase = usAppToPersonUsecase;
            HasEmbeddedLinks = hasEmbeddedLinks;
            HasEmbeddedPhone = hasEmbeddedPhone;
            OptInKeywords = new List<string>();
            OptOutKeywords = new List<string>();
            HelpKeywords = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BrandRegistrationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("BrandRegistrationSid", BrandRegistrationSid));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (MessageFlow != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageFlow", MessageFlow));
            }
            if (MessageSamples != null)
            {
                p.AddRange(MessageSamples.Select(MessageSamples => new KeyValuePair<string, string>("MessageSamples", MessageSamples)));
            }
            if (UsAppToPersonUsecase != null)
            {
                p.Add(new KeyValuePair<string, string>("UsAppToPersonUsecase", UsAppToPersonUsecase));
            }
            if (HasEmbeddedLinks != null)
            {
                p.Add(new KeyValuePair<string, string>("HasEmbeddedLinks", HasEmbeddedLinks.Value.ToString().ToLower()));
            }
            if (HasEmbeddedPhone != null)
            {
                p.Add(new KeyValuePair<string, string>("HasEmbeddedPhone", HasEmbeddedPhone.Value.ToString().ToLower()));
            }
            if (OptInMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("OptInMessage", OptInMessage));
            }
            if (OptOutMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("OptOutMessage", OptOutMessage));
            }
            if (HelpMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("HelpMessage", HelpMessage));
            }
            if (OptInKeywords != null)
            {
                p.AddRange(OptInKeywords.Select(OptInKeywords => new KeyValuePair<string, string>("OptInKeywords", OptInKeywords)));
            }
            if (OptOutKeywords != null)
            {
                p.AddRange(OptOutKeywords.Select(OptOutKeywords => new KeyValuePair<string, string>("OptOutKeywords", OptOutKeywords)));
            }
            if (HelpKeywords != null)
            {
                p.AddRange(HelpKeywords.Select(HelpKeywords => new KeyValuePair<string, string>("HelpKeywords", HelpKeywords)));
            }
            if (SubscriberOptIn != null)
            {
                p.Add(new KeyValuePair<string, string>("SubscriberOptIn", SubscriberOptIn.Value.ToString().ToLower()));
            }
            if (AgeGated != null)
            {
                p.Add(new KeyValuePair<string, string>("AgeGated", AgeGated.Value.ToString().ToLower()));
            }
            if (DirectLending != null)
            {
                p.Add(new KeyValuePair<string, string>("DirectLending", DirectLending.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteUsAppToPersonOptions : IOptions<UsAppToPersonResource>
    {
        
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to delete the resource from. </summary> 
        public string PathMessagingServiceSid { get; }

        ///<summary> The SID of the US A2P Compliance resource to delete `QE2c6890da8086d771620e9b13fadeba0b`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteUsAppToPersonOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The SID of the US A2P Compliance resource to delete `QE2c6890da8086d771620e9b13fadeba0b`. </param>
        public DeleteUsAppToPersonOptions(string pathMessagingServiceSid, string pathSid)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
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
    public class FetchUsAppToPersonOptions : IOptions<UsAppToPersonResource>
    {
    
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </summary> 
        public string PathMessagingServiceSid { get; }

        ///<summary> The SID of the US A2P Compliance resource to fetch `QE2c6890da8086d771620e9b13fadeba0b`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchUsAppToPersonOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The SID of the US A2P Compliance resource to fetch `QE2c6890da8086d771620e9b13fadeba0b`. </param>
        public FetchUsAppToPersonOptions(string pathMessagingServiceSid, string pathSid)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
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
    public class ReadUsAppToPersonOptions : ReadOptions<UsAppToPersonResource>
    {
    
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </summary> 
        public string PathMessagingServiceSid { get; }



        /// <summary> Construct a new ListUsAppToPersonOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </param>
        public ReadUsAppToPersonOptions(string pathMessagingServiceSid)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

    

    }

    /// <summary> update </summary>
    public class UpdateUsAppToPersonOptions : IOptions<UsAppToPersonResource>
    {
    
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) to update the resource from. </summary> 
        public string PathMessagingServiceSid { get; }

        ///<summary> The SID of the US A2P Compliance resource to update `QE2c6890da8086d771620e9b13fadeba0b`. </summary> 
        public string PathSid { get; }

        ///<summary> Indicates that this SMS campaign will send messages that contain links. </summary> 
        public bool? HasEmbeddedLinks { get; }

        ///<summary> Indicates that this SMS campaign will send messages that contain phone numbers. </summary> 
        public bool? HasEmbeddedPhone { get; }

        ///<summary> An array of sample message strings, min two and max five. Min length for each sample: 20 chars. Max length for each sample: 1024 chars. </summary> 
        public List<string> MessageSamples { get; }

        ///<summary> Required for all Campaigns. Details around how a consumer opts-in to their campaign, therefore giving consent to receive their messages. If multiple opt-in methods can be used for the same campaign, they must all be listed. 40 character minimum. 2048 character maximum. </summary> 
        public string MessageFlow { get; }

        ///<summary> A short description of what this SMS campaign does. Min length: 40 characters. Max length: 4096 characters. </summary> 
        public string Description { get; }

        ///<summary> A boolean that specifies whether campaign requires age gate for federally legal content. </summary> 
        public bool? AgeGated { get; }

        ///<summary> A boolean that specifies whether campaign allows direct lending or not. </summary> 
        public bool? DirectLending { get; }



        /// <summary> Construct a new UpdateUsAppToPersonOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) to update the resource from. </param>
        /// <param name="pathSid"> The SID of the US A2P Compliance resource to update `QE2c6890da8086d771620e9b13fadeba0b`. </param>
        /// <param name="hasEmbeddedLinks"> Indicates that this SMS campaign will send messages that contain links. </param>
        /// <param name="hasEmbeddedPhone"> Indicates that this SMS campaign will send messages that contain phone numbers. </param>
        /// <param name="messageSamples"> An array of sample message strings, min two and max five. Min length for each sample: 20 chars. Max length for each sample: 1024 chars. </param>
        /// <param name="messageFlow"> Required for all Campaigns. Details around how a consumer opts-in to their campaign, therefore giving consent to receive their messages. If multiple opt-in methods can be used for the same campaign, they must all be listed. 40 character minimum. 2048 character maximum. </param>
        /// <param name="description"> A short description of what this SMS campaign does. Min length: 40 characters. Max length: 4096 characters. </param>
        /// <param name="ageGated"> A boolean that specifies whether campaign requires age gate for federally legal content. </param>
        /// <param name="directLending"> A boolean that specifies whether campaign allows direct lending or not. </param>
        public UpdateUsAppToPersonOptions(string pathMessagingServiceSid, string pathSid, bool? hasEmbeddedLinks, bool? hasEmbeddedPhone, List<string> messageSamples, string messageFlow, string description, bool? ageGated, bool? directLending)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
            PathSid = pathSid;
            HasEmbeddedLinks = hasEmbeddedLinks;
            HasEmbeddedPhone = hasEmbeddedPhone;
            MessageSamples = messageSamples;
            MessageFlow = messageFlow;
            Description = description;
            AgeGated = ageGated;
            DirectLending = directLending;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (HasEmbeddedLinks != null)
            {
                p.Add(new KeyValuePair<string, string>("HasEmbeddedLinks", HasEmbeddedLinks.Value.ToString().ToLower()));
            }
            if (HasEmbeddedPhone != null)
            {
                p.Add(new KeyValuePair<string, string>("HasEmbeddedPhone", HasEmbeddedPhone.Value.ToString().ToLower()));
            }
            if (MessageSamples != null)
            {
                p.AddRange(MessageSamples.Select(MessageSamples => new KeyValuePair<string, string>("MessageSamples", MessageSamples)));
            }
            if (MessageFlow != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageFlow", MessageFlow));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (AgeGated != null)
            {
                p.Add(new KeyValuePair<string, string>("AgeGated", AgeGated.Value.ToString().ToLower()));
            }
            if (DirectLending != null)
            {
                p.Add(new KeyValuePair<string, string>("DirectLending", DirectLending.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }


}

