/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
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
using SwaggerDateConverter = com.bluejeans.api.rest.meetings.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.meetings.Model
{
    /// <summary>
    /// MeetingState
    /// </summary>
    [DataContract]
    public partial class MeetingState :  IEquatable<MeetingState>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets _MeetingState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeetingStateEnum
        {
            
            /// <summary>
            /// Enum MeetingStarted for "MeetingStarted"
            /// </summary>
            [EnumMember(Value = "MeetingStarted")]
            MeetingStarted
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active
        }

        /// <summary>
        /// Gets or Sets _MeetingState
        /// </summary>
        [DataMember(Name="meetingState", EmitDefaultValue=false)]
        public MeetingStateEnum? _MeetingState { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingState" /> class.
        /// </summary>
        /// <param name="MeetingId">MeetingId.</param>
        /// <param name="MeetingGuid">MeetingGuid.</param>
        /// <param name="_MeetingState">_MeetingState.</param>
        /// <param name="Status">Status.</param>
        /// <param name="IsContentSharingActive">IsContentSharingActive.</param>
        /// <param name="Bridged">Bridged.</param>
        /// <param name="Locked">Locked.</param>
        /// <param name="AudioMuteOnEntry">AudioMuteOnEntry.</param>
        /// <param name="VideoMuteOnEntry">VideoMuteOnEntry.</param>
        /// <param name="ModeratorLess">ModeratorLess.</param>
        /// <param name="Title">Title.</param>
        /// <param name="ChatEnabled">ChatEnabled.</param>
        /// <param name="PinnedEndpointGuid">PinnedEndpointGuid.</param>
        /// <param name="AudioEndpointCount">AudioEndpointCount.</param>
        /// <param name="VideoEndpointCount">VideoEndpointCount.</param>
        /// <param name="RecordingEnabled">RecordingEnabled.</param>
        /// <param name="ParticipantWebJoinURL">ParticipantWebJoinURL.</param>
        /// <param name="IsLargeMeeting">IsLargeMeeting.</param>
        /// <param name="Features">Features.</param>
        /// <param name="DelayedMeetingEndTime">DelayedMeetingEndTime.</param>
        /// <param name="SmStreams">SmStreams.</param>
        /// <param name="InactiveMeetingStatus">InactiveMeetingStatus.</param>
        /// <param name="MeetingMarkedForDelayedTermination">MeetingMarkedForDelayedTermination.</param>
        /// <param name="Recordinginfo">Recordinginfo.</param>
        public MeetingState(string MeetingId = default(string), string MeetingGuid = default(string), MeetingStateEnum? _MeetingState = default(MeetingStateEnum?), StatusEnum? Status = default(StatusEnum?), bool? IsContentSharingActive = default(bool?), bool? Bridged = default(bool?), bool? Locked = default(bool?), bool? AudioMuteOnEntry = default(bool?), bool? VideoMuteOnEntry = default(bool?), bool? ModeratorLess = default(bool?), string Title = default(string), bool? ChatEnabled = default(bool?), string PinnedEndpointGuid = default(string), int? AudioEndpointCount = default(int?), int? VideoEndpointCount = default(int?), bool? RecordingEnabled = default(bool?), string ParticipantWebJoinURL = default(string), string IsLargeMeeting = default(string), List<string> Features = default(List<string>), int? DelayedMeetingEndTime = default(int?), string SmStreams = default(string), string InactiveMeetingStatus = default(string), bool? MeetingMarkedForDelayedTermination = default(bool?), MeetingStateRecordinginfo Recordinginfo = default(MeetingStateRecordinginfo))
        {
            this.MeetingId = MeetingId;
            this.MeetingGuid = MeetingGuid;
            this._MeetingState = _MeetingState;
            this.Status = Status;
            this.IsContentSharingActive = IsContentSharingActive;
            this.Bridged = Bridged;
            this.Locked = Locked;
            this.AudioMuteOnEntry = AudioMuteOnEntry;
            this.VideoMuteOnEntry = VideoMuteOnEntry;
            this.ModeratorLess = ModeratorLess;
            this.Title = Title;
            this.ChatEnabled = ChatEnabled;
            this.PinnedEndpointGuid = PinnedEndpointGuid;
            this.AudioEndpointCount = AudioEndpointCount;
            this.VideoEndpointCount = VideoEndpointCount;
            this.RecordingEnabled = RecordingEnabled;
            this.ParticipantWebJoinURL = ParticipantWebJoinURL;
            this.IsLargeMeeting = IsLargeMeeting;
            this.Features = Features;
            this.DelayedMeetingEndTime = DelayedMeetingEndTime;
            this.SmStreams = SmStreams;
            this.InactiveMeetingStatus = InactiveMeetingStatus;
            this.MeetingMarkedForDelayedTermination = MeetingMarkedForDelayedTermination;
            this.Recordinginfo = Recordinginfo;
        }
        
        /// <summary>
        /// Gets or Sets MeetingId
        /// </summary>
        [DataMember(Name="meetingId", EmitDefaultValue=false)]
        public string MeetingId { get; set; }

        /// <summary>
        /// Gets or Sets MeetingGuid
        /// </summary>
        [DataMember(Name="meetingGuid", EmitDefaultValue=false)]
        public string MeetingGuid { get; set; }



        /// <summary>
        /// Gets or Sets IsContentSharingActive
        /// </summary>
        [DataMember(Name="isContentSharingActive", EmitDefaultValue=false)]
        public bool? IsContentSharingActive { get; set; }

        /// <summary>
        /// Gets or Sets Bridged
        /// </summary>
        [DataMember(Name="bridged", EmitDefaultValue=false)]
        public bool? Bridged { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Gets or Sets AudioMuteOnEntry
        /// </summary>
        [DataMember(Name="audioMuteOnEntry", EmitDefaultValue=false)]
        public bool? AudioMuteOnEntry { get; set; }

        /// <summary>
        /// Gets or Sets VideoMuteOnEntry
        /// </summary>
        [DataMember(Name="videoMuteOnEntry", EmitDefaultValue=false)]
        public bool? VideoMuteOnEntry { get; set; }

        /// <summary>
        /// Gets or Sets ModeratorLess
        /// </summary>
        [DataMember(Name="moderatorLess", EmitDefaultValue=false)]
        public bool? ModeratorLess { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ChatEnabled
        /// </summary>
        [DataMember(Name="chatEnabled", EmitDefaultValue=false)]
        public bool? ChatEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PinnedEndpointGuid
        /// </summary>
        [DataMember(Name="pinnedEndpointGuid", EmitDefaultValue=false)]
        public string PinnedEndpointGuid { get; set; }

        /// <summary>
        /// Gets or Sets AudioEndpointCount
        /// </summary>
        [DataMember(Name="audioEndpointCount", EmitDefaultValue=false)]
        public int? AudioEndpointCount { get; set; }

        /// <summary>
        /// Gets or Sets VideoEndpointCount
        /// </summary>
        [DataMember(Name="videoEndpointCount", EmitDefaultValue=false)]
        public int? VideoEndpointCount { get; set; }

        /// <summary>
        /// Gets or Sets RecordingEnabled
        /// </summary>
        [DataMember(Name="recordingEnabled", EmitDefaultValue=false)]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantWebJoinURL
        /// </summary>
        [DataMember(Name="participantWebJoinURL", EmitDefaultValue=false)]
        public string ParticipantWebJoinURL { get; set; }

        /// <summary>
        /// Gets or Sets IsLargeMeeting
        /// </summary>
        [DataMember(Name="isLargeMeeting", EmitDefaultValue=false)]
        public string IsLargeMeeting { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or Sets DelayedMeetingEndTime
        /// </summary>
        [DataMember(Name="delayedMeetingEndTime", EmitDefaultValue=false)]
        public int? DelayedMeetingEndTime { get; set; }

        /// <summary>
        /// Gets or Sets SmStreams
        /// </summary>
        [DataMember(Name="smStreams", EmitDefaultValue=false)]
        public string SmStreams { get; set; }

        /// <summary>
        /// Gets or Sets InactiveMeetingStatus
        /// </summary>
        [DataMember(Name="inactiveMeetingStatus", EmitDefaultValue=false)]
        public string InactiveMeetingStatus { get; set; }

        /// <summary>
        /// Gets or Sets MeetingMarkedForDelayedTermination
        /// </summary>
        [DataMember(Name="meetingMarkedForDelayedTermination", EmitDefaultValue=false)]
        public bool? MeetingMarkedForDelayedTermination { get; set; }

        /// <summary>
        /// Gets or Sets Recordinginfo
        /// </summary>
        [DataMember(Name="recordinginfo", EmitDefaultValue=false)]
        public MeetingStateRecordinginfo Recordinginfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingState {\n");
            sb.Append("  MeetingId: ").Append(MeetingId).Append("\n");
            sb.Append("  MeetingGuid: ").Append(MeetingGuid).Append("\n");
            sb.Append("  _MeetingState: ").Append(_MeetingState).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsContentSharingActive: ").Append(IsContentSharingActive).Append("\n");
            sb.Append("  Bridged: ").Append(Bridged).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  AudioMuteOnEntry: ").Append(AudioMuteOnEntry).Append("\n");
            sb.Append("  VideoMuteOnEntry: ").Append(VideoMuteOnEntry).Append("\n");
            sb.Append("  ModeratorLess: ").Append(ModeratorLess).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
            sb.Append("  PinnedEndpointGuid: ").Append(PinnedEndpointGuid).Append("\n");
            sb.Append("  AudioEndpointCount: ").Append(AudioEndpointCount).Append("\n");
            sb.Append("  VideoEndpointCount: ").Append(VideoEndpointCount).Append("\n");
            sb.Append("  RecordingEnabled: ").Append(RecordingEnabled).Append("\n");
            sb.Append("  ParticipantWebJoinURL: ").Append(ParticipantWebJoinURL).Append("\n");
            sb.Append("  IsLargeMeeting: ").Append(IsLargeMeeting).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  DelayedMeetingEndTime: ").Append(DelayedMeetingEndTime).Append("\n");
            sb.Append("  SmStreams: ").Append(SmStreams).Append("\n");
            sb.Append("  InactiveMeetingStatus: ").Append(InactiveMeetingStatus).Append("\n");
            sb.Append("  MeetingMarkedForDelayedTermination: ").Append(MeetingMarkedForDelayedTermination).Append("\n");
            sb.Append("  Recordinginfo: ").Append(Recordinginfo).Append("\n");
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
            return this.Equals(obj as MeetingState);
        }

        /// <summary>
        /// Returns true if MeetingState instances are equal
        /// </summary>
        /// <param name="other">Instance of MeetingState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MeetingId == other.MeetingId ||
                    this.MeetingId != null &&
                    this.MeetingId.Equals(other.MeetingId)
                ) && 
                (
                    this.MeetingGuid == other.MeetingGuid ||
                    this.MeetingGuid != null &&
                    this.MeetingGuid.Equals(other.MeetingGuid)
                ) && 
                (
                    this._MeetingState == other._MeetingState ||
                    this._MeetingState != null &&
                    this._MeetingState.Equals(other._MeetingState)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IsContentSharingActive == other.IsContentSharingActive ||
                    this.IsContentSharingActive != null &&
                    this.IsContentSharingActive.Equals(other.IsContentSharingActive)
                ) && 
                (
                    this.Bridged == other.Bridged ||
                    this.Bridged != null &&
                    this.Bridged.Equals(other.Bridged)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.AudioMuteOnEntry == other.AudioMuteOnEntry ||
                    this.AudioMuteOnEntry != null &&
                    this.AudioMuteOnEntry.Equals(other.AudioMuteOnEntry)
                ) && 
                (
                    this.VideoMuteOnEntry == other.VideoMuteOnEntry ||
                    this.VideoMuteOnEntry != null &&
                    this.VideoMuteOnEntry.Equals(other.VideoMuteOnEntry)
                ) && 
                (
                    this.ModeratorLess == other.ModeratorLess ||
                    this.ModeratorLess != null &&
                    this.ModeratorLess.Equals(other.ModeratorLess)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.ChatEnabled == other.ChatEnabled ||
                    this.ChatEnabled != null &&
                    this.ChatEnabled.Equals(other.ChatEnabled)
                ) && 
                (
                    this.PinnedEndpointGuid == other.PinnedEndpointGuid ||
                    this.PinnedEndpointGuid != null &&
                    this.PinnedEndpointGuid.Equals(other.PinnedEndpointGuid)
                ) && 
                (
                    this.AudioEndpointCount == other.AudioEndpointCount ||
                    this.AudioEndpointCount != null &&
                    this.AudioEndpointCount.Equals(other.AudioEndpointCount)
                ) && 
                (
                    this.VideoEndpointCount == other.VideoEndpointCount ||
                    this.VideoEndpointCount != null &&
                    this.VideoEndpointCount.Equals(other.VideoEndpointCount)
                ) && 
                (
                    this.RecordingEnabled == other.RecordingEnabled ||
                    this.RecordingEnabled != null &&
                    this.RecordingEnabled.Equals(other.RecordingEnabled)
                ) && 
                (
                    this.ParticipantWebJoinURL == other.ParticipantWebJoinURL ||
                    this.ParticipantWebJoinURL != null &&
                    this.ParticipantWebJoinURL.Equals(other.ParticipantWebJoinURL)
                ) && 
                (
                    this.IsLargeMeeting == other.IsLargeMeeting ||
                    this.IsLargeMeeting != null &&
                    this.IsLargeMeeting.Equals(other.IsLargeMeeting)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.DelayedMeetingEndTime == other.DelayedMeetingEndTime ||
                    this.DelayedMeetingEndTime != null &&
                    this.DelayedMeetingEndTime.Equals(other.DelayedMeetingEndTime)
                ) && 
                (
                    this.SmStreams == other.SmStreams ||
                    this.SmStreams != null &&
                    this.SmStreams.Equals(other.SmStreams)
                ) && 
                (
                    this.InactiveMeetingStatus == other.InactiveMeetingStatus ||
                    this.InactiveMeetingStatus != null &&
                    this.InactiveMeetingStatus.Equals(other.InactiveMeetingStatus)
                ) && 
                (
                    this.MeetingMarkedForDelayedTermination == other.MeetingMarkedForDelayedTermination ||
                    this.MeetingMarkedForDelayedTermination != null &&
                    this.MeetingMarkedForDelayedTermination.Equals(other.MeetingMarkedForDelayedTermination)
                ) && 
                (
                    this.Recordinginfo == other.Recordinginfo ||
                    this.Recordinginfo != null &&
                    this.Recordinginfo.Equals(other.Recordinginfo)
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
                if (this.MeetingId != null)
                    hash = hash * 59 + this.MeetingId.GetHashCode();
                if (this.MeetingGuid != null)
                    hash = hash * 59 + this.MeetingGuid.GetHashCode();
                if (this._MeetingState != null)
                    hash = hash * 59 + this._MeetingState.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.IsContentSharingActive != null)
                    hash = hash * 59 + this.IsContentSharingActive.GetHashCode();
                if (this.Bridged != null)
                    hash = hash * 59 + this.Bridged.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.AudioMuteOnEntry != null)
                    hash = hash * 59 + this.AudioMuteOnEntry.GetHashCode();
                if (this.VideoMuteOnEntry != null)
                    hash = hash * 59 + this.VideoMuteOnEntry.GetHashCode();
                if (this.ModeratorLess != null)
                    hash = hash * 59 + this.ModeratorLess.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.ChatEnabled != null)
                    hash = hash * 59 + this.ChatEnabled.GetHashCode();
                if (this.PinnedEndpointGuid != null)
                    hash = hash * 59 + this.PinnedEndpointGuid.GetHashCode();
                if (this.AudioEndpointCount != null)
                    hash = hash * 59 + this.AudioEndpointCount.GetHashCode();
                if (this.VideoEndpointCount != null)
                    hash = hash * 59 + this.VideoEndpointCount.GetHashCode();
                if (this.RecordingEnabled != null)
                    hash = hash * 59 + this.RecordingEnabled.GetHashCode();
                if (this.ParticipantWebJoinURL != null)
                    hash = hash * 59 + this.ParticipantWebJoinURL.GetHashCode();
                if (this.IsLargeMeeting != null)
                    hash = hash * 59 + this.IsLargeMeeting.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.DelayedMeetingEndTime != null)
                    hash = hash * 59 + this.DelayedMeetingEndTime.GetHashCode();
                if (this.SmStreams != null)
                    hash = hash * 59 + this.SmStreams.GetHashCode();
                if (this.InactiveMeetingStatus != null)
                    hash = hash * 59 + this.InactiveMeetingStatus.GetHashCode();
                if (this.MeetingMarkedForDelayedTermination != null)
                    hash = hash * 59 + this.MeetingMarkedForDelayedTermination.GetHashCode();
                if (this.Recordinginfo != null)
                    hash = hash * 59 + this.Recordinginfo.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
