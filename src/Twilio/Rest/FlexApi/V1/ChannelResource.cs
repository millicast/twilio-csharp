/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.FlexApi.V1
{
    public class ChannelResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateChannelOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Channels";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Create(CreateChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ChannelResource> CreateAsync(CreateChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="flexFlowSid"> The SID of the Flex Flow. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's chat User. </param>
        /// <param name="chatUserFriendlyName"> The chat participant's friendly name. </param>
        /// <param name="chatFriendlyName"> The chat channel's friendly name. </param>
        /// <param name="target"> The Target Contact Identity, for example the phone number of an SMS. </param>
        /// <param name="chatUniqueName"> The chat channel's unique name. </param>
        /// <param name="preEngagementData"> The pre-engagement data. </param>
        /// <param name="taskSid"> The SID of the TaskRouter Task. Only valid when integration type is `task`. `null` for integration types `studio` & `external` </param>
        /// <param name="taskAttributes"> The Task attributes to be added for the TaskRouter Task. </param>
        /// <param name="longLived"> Whether to create the channel as long-lived. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Create(
                                          string flexFlowSid,
                                          string identity,
                                          string chatUserFriendlyName,
                                          string chatFriendlyName,
                                          string target = null,
                                          string chatUniqueName = null,
                                          string preEngagementData = null,
                                          string taskSid = null,
                                          string taskAttributes = null,
                                          bool? longLived = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateChannelOptions(flexFlowSid, identity, chatUserFriendlyName, chatFriendlyName){  Target = target, ChatUniqueName = chatUniqueName, PreEngagementData = preEngagementData, TaskSid = taskSid, TaskAttributes = taskAttributes, LongLived = longLived };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="flexFlowSid"> The SID of the Flex Flow. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's chat User. </param>
        /// <param name="chatUserFriendlyName"> The chat participant's friendly name. </param>
        /// <param name="chatFriendlyName"> The chat channel's friendly name. </param>
        /// <param name="target"> The Target Contact Identity, for example the phone number of an SMS. </param>
        /// <param name="chatUniqueName"> The chat channel's unique name. </param>
        /// <param name="preEngagementData"> The pre-engagement data. </param>
        /// <param name="taskSid"> The SID of the TaskRouter Task. Only valid when integration type is `task`. `null` for integration types `studio` & `external` </param>
        /// <param name="taskAttributes"> The Task attributes to be added for the TaskRouter Task. </param>
        /// <param name="longLived"> Whether to create the channel as long-lived. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ChannelResource> CreateAsync(
                                                                                  string flexFlowSid,
                                                                                  string identity,
                                                                                  string chatUserFriendlyName,
                                                                                  string chatFriendlyName,
                                                                                  string target = null,
                                                                                  string chatUniqueName = null,
                                                                                  string preEngagementData = null,
                                                                                  string taskSid = null,
                                                                                  string taskAttributes = null,
                                                                                  bool? longLived = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateChannelOptions(flexFlowSid, identity, chatUserFriendlyName, chatFriendlyName){  Target = target, ChatUniqueName = chatUniqueName, PreEngagementData = preEngagementData, TaskSid = taskSid, TaskAttributes = taskAttributes, LongLived = longLived };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        private static Request BuildDeleteRequest(DeleteChannelOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Channels/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static bool Delete(DeleteChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteChannelOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The SID of the Flex chat channel resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteChannelOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The SID of the Flex chat channel resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteChannelOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchChannelOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Channels/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Fetch(FetchChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ChannelResource> FetchAsync(FetchChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex chat channel resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Fetch(
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchChannelOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex chat channel resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ChannelResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchChannelOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadChannelOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Channels";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ResourceSet<ChannelResource> Read(ReadChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ChannelResource>.FromJson("flex_chat_channels", response.Content);
            return new ResourceSet<ChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ChannelResource>> ReadAsync(ReadChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ChannelResource>.FromJson("flex_chat_channels", response.Content);
            return new ResourceSet<ChannelResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ResourceSet<ChannelResource> Read(
                                                     long? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadChannelOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ChannelResource>> ReadAsync(
                                                                                             long? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadChannelOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ChannelResource> NextPage(Page<ChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ChannelResource> PreviousPage(Page<ChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a ChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ChannelResource object represented by the provided JSON </returns>
        public static ChannelResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Channel resource and owns this Workflow. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Flex Flow. </summary> 
        [JsonProperty("flex_flow_sid")]
        public string FlexFlowSid { get; private set; }

        ///<summary> The unique string that we created to identify the Channel resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the chat user. </summary> 
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }

        ///<summary> The SID of the TaskRouter Task. Only valid when integration type is `task`. `null` for integration types `studio` & `external` </summary> 
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }

        ///<summary> The absolute URL of the Flex chat channel resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The date and time in GMT when the Flex chat channel was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Flex chat channel was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private ChannelResource() {

        }
    }
}

