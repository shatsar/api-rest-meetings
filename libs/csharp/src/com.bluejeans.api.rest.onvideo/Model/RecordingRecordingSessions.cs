/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace com.bluejeans.api.rest.onvideo.Model
{
    /// <summary>
    /// RecordingRecordingSessions
    /// </summary>
    [DataContract]
    public partial class RecordingRecordingSessions :  IEquatable<RecordingRecordingSessions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingRecordingSessions" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ContentStatus">ContentStatus.</param>
        /// <param name="RecordingType">RecordingType.</param>
        /// <param name="ContentId">ContentId.</param>
        /// <param name="ThumbnailUrl">ThumbnailUrl.</param>
        /// <param name="StartTimeOffset">StartTimeOffset.</param>
        /// <param name="EndTimeOffset">EndTimeOffset.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="StartedBy">StartedBy.</param>
        /// <param name="StoppedBy">StoppedBy.</param>
        public RecordingRecordingSessions(int? Id = default(int?), string ContentStatus = default(string), string RecordingType = default(string), int? ContentId = default(int?), string ThumbnailUrl = default(string), int? StartTimeOffset = default(int?), int? EndTimeOffset = default(int?), int? Duration = default(int?), RecordingStartedBy StartedBy = default(RecordingStartedBy), RecordingStartedBy StoppedBy = default(RecordingStartedBy))
        {
            this.Id = Id;
            this.ContentStatus = ContentStatus;
            this.RecordingType = RecordingType;
            this.ContentId = ContentId;
            this.ThumbnailUrl = ThumbnailUrl;
            this.StartTimeOffset = StartTimeOffset;
            this.EndTimeOffset = EndTimeOffset;
            this.Duration = Duration;
            this.StartedBy = StartedBy;
            this.StoppedBy = StoppedBy;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets ContentStatus
        /// </summary>
        [DataMember(Name="contentStatus", EmitDefaultValue=false)]
        public string ContentStatus { get; set; }
        /// <summary>
        /// Gets or Sets RecordingType
        /// </summary>
        [DataMember(Name="recordingType", EmitDefaultValue=false)]
        public string RecordingType { get; set; }
        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        [DataMember(Name="contentId", EmitDefaultValue=false)]
        public int? ContentId { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Gets or Sets StartTimeOffset
        /// </summary>
        [DataMember(Name="startTimeOffset", EmitDefaultValue=false)]
        public int? StartTimeOffset { get; set; }
        /// <summary>
        /// Gets or Sets EndTimeOffset
        /// </summary>
        [DataMember(Name="endTimeOffset", EmitDefaultValue=false)]
        public int? EndTimeOffset { get; set; }
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// Gets or Sets StartedBy
        /// </summary>
        [DataMember(Name="startedBy", EmitDefaultValue=false)]
        public RecordingStartedBy StartedBy { get; set; }
        /// <summary>
        /// Gets or Sets StoppedBy
        /// </summary>
        [DataMember(Name="stoppedBy", EmitDefaultValue=false)]
        public RecordingStartedBy StoppedBy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingRecordingSessions {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentStatus: ").Append(ContentStatus).Append("\n");
            sb.Append("  RecordingType: ").Append(RecordingType).Append("\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  StartTimeOffset: ").Append(StartTimeOffset).Append("\n");
            sb.Append("  EndTimeOffset: ").Append(EndTimeOffset).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  StartedBy: ").Append(StartedBy).Append("\n");
            sb.Append("  StoppedBy: ").Append(StoppedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecordingRecordingSessions);
        }

        /// <summary>
        /// Returns true if RecordingRecordingSessions instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingRecordingSessions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingRecordingSessions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ContentStatus == other.ContentStatus ||
                    this.ContentStatus != null &&
                    this.ContentStatus.Equals(other.ContentStatus)
                ) && 
                (
                    this.RecordingType == other.RecordingType ||
                    this.RecordingType != null &&
                    this.RecordingType.Equals(other.RecordingType)
                ) && 
                (
                    this.ContentId == other.ContentId ||
                    this.ContentId != null &&
                    this.ContentId.Equals(other.ContentId)
                ) && 
                (
                    this.ThumbnailUrl == other.ThumbnailUrl ||
                    this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(other.ThumbnailUrl)
                ) && 
                (
                    this.StartTimeOffset == other.StartTimeOffset ||
                    this.StartTimeOffset != null &&
                    this.StartTimeOffset.Equals(other.StartTimeOffset)
                ) && 
                (
                    this.EndTimeOffset == other.EndTimeOffset ||
                    this.EndTimeOffset != null &&
                    this.EndTimeOffset.Equals(other.EndTimeOffset)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.StartedBy == other.StartedBy ||
                    this.StartedBy != null &&
                    this.StartedBy.Equals(other.StartedBy)
                ) && 
                (
                    this.StoppedBy == other.StoppedBy ||
                    this.StoppedBy != null &&
                    this.StoppedBy.Equals(other.StoppedBy)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ContentStatus != null)
                    hash = hash * 59 + this.ContentStatus.GetHashCode();
                if (this.RecordingType != null)
                    hash = hash * 59 + this.RecordingType.GetHashCode();
                if (this.ContentId != null)
                    hash = hash * 59 + this.ContentId.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hash = hash * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.StartTimeOffset != null)
                    hash = hash * 59 + this.StartTimeOffset.GetHashCode();
                if (this.EndTimeOffset != null)
                    hash = hash * 59 + this.EndTimeOffset.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.StartedBy != null)
                    hash = hash * 59 + this.StartedBy.GetHashCode();
                if (this.StoppedBy != null)
                    hash = hash * 59 + this.StoppedBy.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
