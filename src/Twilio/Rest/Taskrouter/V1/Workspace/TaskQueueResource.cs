/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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
using Twilio.Types;


namespace Twilio.Rest.Taskrouter.V1.Workspace
{
    public class TaskQueueResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TaskOrderEnum : StringEnum
        {
            private TaskOrderEnum(string value) : base(value) {}
            public TaskOrderEnum() {}
            public static implicit operator TaskOrderEnum(string value)
            {
                return new TaskOrderEnum(value);
            }
            public static readonly TaskOrderEnum Fifo = new TaskOrderEnum("FIFO");
            public static readonly TaskOrderEnum Lifo = new TaskOrderEnum("LIFO");

        }

        
        private static Request BuildCreateRequest(CreateTaskQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Create(CreateTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<TaskQueueResource> CreateAsync(CreateTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new TaskQueue belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </param>
        /// <param name="targetWorkers"> A string that describes the Worker selection criteria for any Tasks that enter the TaskQueue. For example, `'\\\"language\\\" == \\\"spanish\\\"'`. The default value is `1==1`. If this value is empty, Tasks will wait in the TaskQueue until they are deleted or moved to another TaskQueue. For more information about Worker selection, see [Describing Worker selection criteria](https://www.twilio.com/docs/taskrouter/api/taskqueues#target-workers). </param>
        /// <param name="maxReservedWorkers"> The maximum number of Workers to reserve for the assignment of a Task in the queue. Can be an integer between 1 and 50, inclusive and defaults to 1. </param>
        /// <param name="taskOrder">  </param>
        /// <param name="reservationActivitySid"> The SID of the Activity to assign Workers when a task is reserved for them. </param>
        /// <param name="assignmentActivitySid"> The SID of the Activity to assign Workers when a task is assigned to them. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Create(
                                          string pathWorkspaceSid,
                                          string friendlyName,
                                          string targetWorkers = null,
                                          int? maxReservedWorkers = null,
                                          TaskQueueResource.TaskOrderEnum taskOrder = null,
                                          string reservationActivitySid = null,
                                          string assignmentActivitySid = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateTaskQueueOptions(pathWorkspaceSid, friendlyName){  TargetWorkers = targetWorkers, MaxReservedWorkers = maxReservedWorkers, TaskOrder = taskOrder, ReservationActivitySid = reservationActivitySid, AssignmentActivitySid = assignmentActivitySid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new TaskQueue belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </param>
        /// <param name="targetWorkers"> A string that describes the Worker selection criteria for any Tasks that enter the TaskQueue. For example, `'\\\"language\\\" == \\\"spanish\\\"'`. The default value is `1==1`. If this value is empty, Tasks will wait in the TaskQueue until they are deleted or moved to another TaskQueue. For more information about Worker selection, see [Describing Worker selection criteria](https://www.twilio.com/docs/taskrouter/api/taskqueues#target-workers). </param>
        /// <param name="maxReservedWorkers"> The maximum number of Workers to reserve for the assignment of a Task in the queue. Can be an integer between 1 and 50, inclusive and defaults to 1. </param>
        /// <param name="taskOrder">  </param>
        /// <param name="reservationActivitySid"> The SID of the Activity to assign Workers when a task is reserved for them. </param>
        /// <param name="assignmentActivitySid"> The SID of the Activity to assign Workers when a task is assigned to them. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<TaskQueueResource> CreateAsync(
                                                                                  string pathWorkspaceSid,
                                                                                  string friendlyName,
                                                                                  string targetWorkers = null,
                                                                                  int? maxReservedWorkers = null,
                                                                                  TaskQueueResource.TaskOrderEnum taskOrder = null,
                                                                                  string reservationActivitySid = null,
                                                                                  string assignmentActivitySid = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateTaskQueueOptions(pathWorkspaceSid, friendlyName){  TargetWorkers = targetWorkers, MaxReservedWorkers = maxReservedWorkers, TaskOrder = taskOrder, ReservationActivitySid = reservationActivitySid, AssignmentActivitySid = assignmentActivitySid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        private static Request BuildDeleteRequest(DeleteTaskQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static bool Delete(DeleteTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTaskQueueOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to delete. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static bool Delete(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTaskQueueOptions(pathWorkspaceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to delete. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTaskQueueOptions(pathWorkspaceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchTaskQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Fetch(FetchTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<TaskQueueResource> FetchAsync(FetchTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Fetch(
                                         string pathWorkspaceSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueOptions(pathWorkspaceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<TaskQueueResource> FetchAsync(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueOptions(pathWorkspaceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadTaskQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static ResourceSet<TaskQueueResource> Read(ReadTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TaskQueueResource>.FromJson("task_queues", response.Content);
            return new ResourceSet<TaskQueueResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TaskQueueResource>> ReadAsync(ReadTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TaskQueueResource>.FromJson("task_queues", response.Content);
            return new ResourceSet<TaskQueueResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the TaskQueue resources to read. </param>
        /// <param name="evaluateWorkerAttributes"> The attributes of the Workers to read. Returns the TaskQueues with Workers that match the attributes specified in this parameter. </param>
        /// <param name="workerSid"> The SID of the Worker with the TaskQueue resources to read. </param>
        /// <param name="ordering"> Sorting parameter for TaskQueues </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static ResourceSet<TaskQueueResource> Read(
                                                     string pathWorkspaceSid,
                                                     string friendlyName = null,
                                                     string evaluateWorkerAttributes = null,
                                                     string workerSid = null,
                                                     string ordering = null,
                                                     long? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadTaskQueueOptions(pathWorkspaceSid){ FriendlyName = friendlyName, EvaluateWorkerAttributes = evaluateWorkerAttributes, WorkerSid = workerSid, Ordering = ordering, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the TaskQueue resources to read. </param>
        /// <param name="evaluateWorkerAttributes"> The attributes of the Workers to read. Returns the TaskQueues with Workers that match the attributes specified in this parameter. </param>
        /// <param name="workerSid"> The SID of the Worker with the TaskQueue resources to read. </param>
        /// <param name="ordering"> Sorting parameter for TaskQueues </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TaskQueueResource>> ReadAsync(
                                                                                             string pathWorkspaceSid,
                                                                                             string friendlyName = null,
                                                                                             string evaluateWorkerAttributes = null,
                                                                                             string workerSid = null,
                                                                                             string ordering = null,
                                                                                             long? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadTaskQueueOptions(pathWorkspaceSid){ FriendlyName = friendlyName, EvaluateWorkerAttributes = evaluateWorkerAttributes, WorkerSid = workerSid, Ordering = ordering, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TaskQueueResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TaskQueueResource>.FromJson("task_queues", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TaskQueueResource> NextPage(Page<TaskQueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TaskQueueResource>.FromJson("task_queues", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TaskQueueResource> PreviousPage(Page<TaskQueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TaskQueueResource>.FromJson("task_queues", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateTaskQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Update(UpdateTaskQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update TaskQueue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<TaskQueueResource> UpdateAsync(UpdateTaskQueueOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to update. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </param>
        /// <param name="targetWorkers"> A string describing the Worker selection criteria for any Tasks that enter the TaskQueue. For example '\\\"language\\\" == \\\"spanish\\\"' If no TargetWorkers parameter is provided, Tasks will wait in the queue until they are either deleted or moved to another queue. Additional examples on how to describing Worker selection criteria below. </param>
        /// <param name="reservationActivitySid"> The SID of the Activity to assign Workers when a task is reserved for them. </param>
        /// <param name="assignmentActivitySid"> The SID of the Activity to assign Workers when a task is assigned for them. </param>
        /// <param name="maxReservedWorkers"> The maximum number of Workers to create reservations for the assignment of a task while in the queue. Maximum of 50. </param>
        /// <param name="taskOrder">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueue </returns>
        public static TaskQueueResource Update(
                                          string pathWorkspaceSid,
                                          string pathSid,
                                          string friendlyName = null,
                                          string targetWorkers = null,
                                          string reservationActivitySid = null,
                                          string assignmentActivitySid = null,
                                          int? maxReservedWorkers = null,
                                          TaskQueueResource.TaskOrderEnum taskOrder = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateTaskQueueOptions(pathWorkspaceSid, pathSid){ FriendlyName = friendlyName, TargetWorkers = targetWorkers, ReservationActivitySid = reservationActivitySid, AssignmentActivitySid = assignmentActivitySid, MaxReservedWorkers = maxReservedWorkers, TaskOrder = taskOrder };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to update. </param>
        /// <param name="pathSid"> The SID of the TaskQueue resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </param>
        /// <param name="targetWorkers"> A string describing the Worker selection criteria for any Tasks that enter the TaskQueue. For example '\\\"language\\\" == \\\"spanish\\\"' If no TargetWorkers parameter is provided, Tasks will wait in the queue until they are either deleted or moved to another queue. Additional examples on how to describing Worker selection criteria below. </param>
        /// <param name="reservationActivitySid"> The SID of the Activity to assign Workers when a task is reserved for them. </param>
        /// <param name="assignmentActivitySid"> The SID of the Activity to assign Workers when a task is assigned for them. </param>
        /// <param name="maxReservedWorkers"> The maximum number of Workers to create reservations for the assignment of a task while in the queue. Maximum of 50. </param>
        /// <param name="taskOrder">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueue </returns>
        public static async System.Threading.Tasks.Task<TaskQueueResource> UpdateAsync(
                                                                              string pathWorkspaceSid,
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string targetWorkers = null,
                                                                              string reservationActivitySid = null,
                                                                              string assignmentActivitySid = null,
                                                                              int? maxReservedWorkers = null,
                                                                              TaskQueueResource.TaskOrderEnum taskOrder = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateTaskQueueOptions(pathWorkspaceSid, pathSid){ FriendlyName = friendlyName, TargetWorkers = targetWorkers, ReservationActivitySid = reservationActivitySid, AssignmentActivitySid = assignmentActivitySid, MaxReservedWorkers = maxReservedWorkers, TaskOrder = taskOrder };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a TaskQueueResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueResource object represented by the provided JSON </returns>
        public static TaskQueueResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the TaskQueue resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Activity to assign Workers when a task is assigned for them. </summary> 
        [JsonProperty("assignment_activity_sid")]
        public string AssignmentActivitySid { get; private set; }

        ///<summary> The name of the Activity to assign Workers when a task is assigned for them. </summary> 
        [JsonProperty("assignment_activity_name")]
        public string AssignmentActivityName { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The maximum number of Workers to reserve for the assignment of a task in the queue. Can be an integer between 1 and 50, inclusive and defaults to 1. </summary> 
        [JsonProperty("max_reserved_workers")]
        public int? MaxReservedWorkers { get; private set; }

        ///<summary> The SID of the Activity to assign Workers once a task is reserved for them. </summary> 
        [JsonProperty("reservation_activity_sid")]
        public string ReservationActivitySid { get; private set; }

        ///<summary> The name of the Activity to assign Workers once a task is reserved for them. </summary> 
        [JsonProperty("reservation_activity_name")]
        public string ReservationActivityName { get; private set; }

        ///<summary> The unique string that we created to identify the TaskQueue resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A string describing the Worker selection criteria for any Tasks that enter the TaskQueue. For example `'\"language\" == \"spanish\"'` If no TargetWorkers parameter is provided, Tasks will wait in the TaskQueue until they are either deleted or moved to another TaskQueue. Additional examples on how to describing Worker selection criteria below. Defaults to 1==1. </summary> 
        [JsonProperty("target_workers")]
        public string TargetWorkers { get; private set; }

        
        [JsonProperty("task_order")]
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; private set; }

        ///<summary> The absolute URL of the TaskQueue resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The SID of the Workspace that contains the TaskQueue. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private TaskQueueResource() {

        }
    }
}

