/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Video
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



namespace Twilio.Rest.Video.V1
{

    /// <summary> create </summary>
    public class CreateCompositionOptions : IOptions<CompositionResource>
    {
        
        ///<summary> The SID of the Group Room with the media tracks to be used as composition sources. </summary> 
        public string RoomSid { get; }

        ///<summary> An object that describes the video layout of the composition in terms of regions. See [Specifying Video Layouts](https://www.twilio.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. Please, be aware that either video_layout or audio_sources have to be provided to get a valid creation request </summary> 
        public object VideoLayout { get; set; }

        ///<summary> An array of track names from the same group room to merge into the new composition. Can include zero or more track names. The new composition includes all audio sources specified in `audio_sources` except for those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which will match zero or more characters in a track name. For example, `student*` includes `student` as well as `studentTeam`. Please, be aware that either video_layout or audio_sources have to be provided to get a valid creation request </summary> 
        public List<string> AudioSources { get; set; }

        ///<summary> An array of track names to exclude. The new composition includes all audio sources specified in `audio_sources` except for those specified in `audio_sources_excluded`. The track names in this parameter can include an asterisk as a wild card character, which will match zero or more characters in a track name. For example, `student*` excludes `student` as well as `studentTeam`. This parameter can also be empty. </summary> 
        public List<string> AudioSourcesExcluded { get; set; }

        ///<summary> A string that describes the columns (width) and rows (height) of the generated composed video in pixels. Defaults to `640x480`.  The string's format is `{width}x{height}` where:   * 16 <= `{width}` <= 1280 * 16 <= `{height}` <= 1280 * `{width}` * `{height}` <= 921,600  Typical values are:   * HD = `1280x720` * PAL = `1024x576` * VGA = `640x480` * CIF = `320x240`  Note that the `resolution` imposes an aspect ratio to the resulting composition. When the original video tracks are constrained by the aspect ratio, they are scaled to fit. See [Specifying Video Layouts](https://www.twilio.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public string Resolution { get; set; }

        
        public CompositionResource.FormatEnum Format { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application on every composition event. If not provided, status callback events will not be dispatched. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `POST` or `GET` and the default is `POST`. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> Whether to clip the intervals where there is no active media in the composition. The default is `true`. Compositions with `trim` enabled are shorter when the Room is created and no Participant joins for a while as well as if all the Participants leave the room and join later, because those gaps will be removed. See [Specifying Video Layouts](https://www.twilio.com/docs/video/api/compositions-resource#specifying-video-layouts) for more info. </summary> 
        public bool? Trim { get; set; }


        /// <summary> Construct a new CreateCompositionOptions </summary>
        /// <param name="roomSid"> The SID of the Group Room with the media tracks to be used as composition sources. </param>
        public CreateCompositionOptions(string roomSid)
        {
            RoomSid = roomSid;
            AudioSources = new List<string>();
            AudioSourcesExcluded = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (RoomSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoomSid", RoomSid));
            }
            if (VideoLayout != null)
            {
                p.Add(new KeyValuePair<string, string>("VideoLayout", Serializers.JsonObject(VideoLayout)));
            }
            if (AudioSources != null)
            {
                p.AddRange(AudioSources.Select(AudioSources => new KeyValuePair<string, string>("AudioSources", AudioSources)));
            }
            if (AudioSourcesExcluded != null)
            {
                p.AddRange(AudioSourcesExcluded.Select(AudioSourcesExcluded => new KeyValuePair<string, string>("AudioSourcesExcluded", AudioSourcesExcluded)));
            }
            if (Resolution != null)
            {
                p.Add(new KeyValuePair<string, string>("Resolution", Resolution));
            }
            if (Format != null)
            {
                p.Add(new KeyValuePair<string, string>("Format", Format.ToString()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }
    /// <summary> Delete a Recording Composition resource identified by a Composition SID. </summary>
    public class DeleteCompositionOptions : IOptions<CompositionResource>
    {
        
        ///<summary> The SID of the Composition resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteCompositionOptions </summary>
        /// <param name="pathSid"> The SID of the Composition resource to delete. </param>
        public DeleteCompositionOptions(string pathSid)
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


    /// <summary> Returns a single Composition resource identified by a Composition SID. </summary>
    public class FetchCompositionOptions : IOptions<CompositionResource>
    {
    
        ///<summary> The SID of the Composition resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCompositionOptions </summary>
        /// <param name="pathSid"> The SID of the Composition resource to fetch. </param>
        public FetchCompositionOptions(string pathSid)
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


    /// <summary> List of all Recording compositions. </summary>
    public class ReadCompositionOptions : ReadOptions<CompositionResource>
    {
    
        ///<summary> Read only Composition resources with this status. Can be: `enqueued`, `processing`, `completed`, `deleted`, or `failed`. </summary> 
        public CompositionResource.StatusEnum Status { get; set; }

        ///<summary> Read only Composition resources created on or after this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone. </summary> 
        public DateTime? DateCreatedAfter { get; set; }

        ///<summary> Read only Composition resources created before this ISO 8601 date-time with time zone. </summary> 
        public DateTime? DateCreatedBefore { get; set; }

        ///<summary> Read only Composition resources with this Room SID. </summary> 
        public string RoomSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }
            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }
            if (RoomSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoomSid", RoomSid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

    

    }

}

