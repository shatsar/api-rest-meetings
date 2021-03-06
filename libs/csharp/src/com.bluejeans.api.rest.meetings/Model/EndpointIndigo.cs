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
    /// EndpointIndigo
    /// </summary>
    [DataContract]
    public partial class EndpointIndigo :  IEquatable<EndpointIndigo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointIndigo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Callguid">Callguid.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Endpoint">Endpoint.</param>
        /// <param name="Vendor">Vendor.</param>
        /// <param name="Version">Version.</param>
        /// <param name="UniqId">UniqId.</param>
        /// <param name="RemoteAddress">RemoteAddress.</param>
        /// <param name="Leader">Leader.</param>
        /// <param name="SecureCall">SecureCall.</param>
        /// <param name="NatDetected">NatDetected.</param>
        /// <param name="Proxy">Proxy.</param>
        /// <param name="RoiDistance">RoiDistance.</param>
        /// <param name="Mpls">Mpls.</param>
        /// <param name="VideoShare">VideoShare.</param>
        /// <param name="Recording">Recording.</param>
        /// <param name="CreationTime">CreationTime.</param>
        /// <param name="MeetingJoinTime">MeetingJoinTime.</param>
        /// <param name="MeetingLeaveTime">MeetingLeaveTime.</param>
        /// <param name="DidNumber">DidNumber.</param>
        /// <param name="Location">Location.</param>
        /// <param name="SummaryStats">SummaryStats.</param>
        /// <param name="EndpointAttributes1">EndpointAttributes1.</param>
        /// <param name="Traceroute">Traceroute.</param>
        /// <param name="MhtaskStopped">MhtaskStopped.</param>
        public EndpointIndigo(int? Id = default(int?), string Callguid = default(string), string Name = default(string), string Endpoint = default(string), string Vendor = default(string), string Version = default(string), string UniqId = default(string), string RemoteAddress = default(string), bool? Leader = default(bool?), bool? SecureCall = default(bool?), bool? NatDetected = default(bool?), bool? Proxy = default(bool?), float? RoiDistance = default(float?), bool? Mpls = default(bool?), bool? VideoShare = default(bool?), bool? Recording = default(bool?), long? CreationTime = default(long?), long? MeetingJoinTime = default(long?), long? MeetingLeaveTime = default(long?), string DidNumber = default(string), EndpointIndigoLocation Location = default(EndpointIndigoLocation), EndpointIndigoSummaryStats SummaryStats = default(EndpointIndigoSummaryStats), EndpointIndigoEndpointAttributes1 EndpointAttributes1 = default(EndpointIndigoEndpointAttributes1), EndpointIndigoTraceroute Traceroute = default(EndpointIndigoTraceroute), bool? MhtaskStopped = default(bool?))
        {
            this.Id = Id;
            this.Callguid = Callguid;
            this.Name = Name;
            this.Endpoint = Endpoint;
            this.Vendor = Vendor;
            this.Version = Version;
            this.UniqId = UniqId;
            this.RemoteAddress = RemoteAddress;
            this.Leader = Leader;
            this.SecureCall = SecureCall;
            this.NatDetected = NatDetected;
            this.Proxy = Proxy;
            this.RoiDistance = RoiDistance;
            this.Mpls = Mpls;
            this.VideoShare = VideoShare;
            this.Recording = Recording;
            this.CreationTime = CreationTime;
            this.MeetingJoinTime = MeetingJoinTime;
            this.MeetingLeaveTime = MeetingLeaveTime;
            this.DidNumber = DidNumber;
            this.Location = Location;
            this.SummaryStats = SummaryStats;
            this.EndpointAttributes1 = EndpointAttributes1;
            this.Traceroute = Traceroute;
            this.MhtaskStopped = MhtaskStopped;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Callguid
        /// </summary>
        [DataMember(Name="callguid", EmitDefaultValue=false)]
        public string Callguid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets UniqId
        /// </summary>
        [DataMember(Name="uniqId", EmitDefaultValue=false)]
        public string UniqId { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddress
        /// </summary>
        [DataMember(Name="remoteAddress", EmitDefaultValue=false)]
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets Leader
        /// </summary>
        [DataMember(Name="leader", EmitDefaultValue=false)]
        public bool? Leader { get; set; }

        /// <summary>
        /// Gets or Sets SecureCall
        /// </summary>
        [DataMember(Name="secureCall", EmitDefaultValue=false)]
        public bool? SecureCall { get; set; }

        /// <summary>
        /// Gets or Sets NatDetected
        /// </summary>
        [DataMember(Name="natDetected", EmitDefaultValue=false)]
        public bool? NatDetected { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name="proxy", EmitDefaultValue=false)]
        public bool? Proxy { get; set; }

        /// <summary>
        /// Gets or Sets RoiDistance
        /// </summary>
        [DataMember(Name="roiDistance", EmitDefaultValue=false)]
        public float? RoiDistance { get; set; }

        /// <summary>
        /// Gets or Sets Mpls
        /// </summary>
        [DataMember(Name="mpls", EmitDefaultValue=false)]
        public bool? Mpls { get; set; }

        /// <summary>
        /// Gets or Sets VideoShare
        /// </summary>
        [DataMember(Name="videoShare", EmitDefaultValue=false)]
        public bool? VideoShare { get; set; }

        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }

        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets MeetingJoinTime
        /// </summary>
        [DataMember(Name="meetingJoinTime", EmitDefaultValue=false)]
        public long? MeetingJoinTime { get; set; }

        /// <summary>
        /// Gets or Sets MeetingLeaveTime
        /// </summary>
        [DataMember(Name="meetingLeaveTime", EmitDefaultValue=false)]
        public long? MeetingLeaveTime { get; set; }

        /// <summary>
        /// Gets or Sets DidNumber
        /// </summary>
        [DataMember(Name="didNumber", EmitDefaultValue=false)]
        public string DidNumber { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public EndpointIndigoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets SummaryStats
        /// </summary>
        [DataMember(Name="summaryStats", EmitDefaultValue=false)]
        public EndpointIndigoSummaryStats SummaryStats { get; set; }

        /// <summary>
        /// Gets or Sets EndpointAttributes1
        /// </summary>
        [DataMember(Name="endpointAttributes1", EmitDefaultValue=false)]
        public EndpointIndigoEndpointAttributes1 EndpointAttributes1 { get; set; }

        /// <summary>
        /// Gets or Sets Traceroute
        /// </summary>
        [DataMember(Name="traceroute", EmitDefaultValue=false)]
        public EndpointIndigoTraceroute Traceroute { get; set; }

        /// <summary>
        /// Gets or Sets MhtaskStopped
        /// </summary>
        [DataMember(Name="mhtaskStopped", EmitDefaultValue=false)]
        public bool? MhtaskStopped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointIndigo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Callguid: ").Append(Callguid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  UniqId: ").Append(UniqId).Append("\n");
            sb.Append("  RemoteAddress: ").Append(RemoteAddress).Append("\n");
            sb.Append("  Leader: ").Append(Leader).Append("\n");
            sb.Append("  SecureCall: ").Append(SecureCall).Append("\n");
            sb.Append("  NatDetected: ").Append(NatDetected).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  RoiDistance: ").Append(RoiDistance).Append("\n");
            sb.Append("  Mpls: ").Append(Mpls).Append("\n");
            sb.Append("  VideoShare: ").Append(VideoShare).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  MeetingJoinTime: ").Append(MeetingJoinTime).Append("\n");
            sb.Append("  MeetingLeaveTime: ").Append(MeetingLeaveTime).Append("\n");
            sb.Append("  DidNumber: ").Append(DidNumber).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  SummaryStats: ").Append(SummaryStats).Append("\n");
            sb.Append("  EndpointAttributes1: ").Append(EndpointAttributes1).Append("\n");
            sb.Append("  Traceroute: ").Append(Traceroute).Append("\n");
            sb.Append("  MhtaskStopped: ").Append(MhtaskStopped).Append("\n");
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
            return this.Equals(obj as EndpointIndigo);
        }

        /// <summary>
        /// Returns true if EndpointIndigo instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointIndigo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointIndigo other)
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
                    this.Callguid == other.Callguid ||
                    this.Callguid != null &&
                    this.Callguid.Equals(other.Callguid)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Endpoint == other.Endpoint ||
                    this.Endpoint != null &&
                    this.Endpoint.Equals(other.Endpoint)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.UniqId == other.UniqId ||
                    this.UniqId != null &&
                    this.UniqId.Equals(other.UniqId)
                ) && 
                (
                    this.RemoteAddress == other.RemoteAddress ||
                    this.RemoteAddress != null &&
                    this.RemoteAddress.Equals(other.RemoteAddress)
                ) && 
                (
                    this.Leader == other.Leader ||
                    this.Leader != null &&
                    this.Leader.Equals(other.Leader)
                ) && 
                (
                    this.SecureCall == other.SecureCall ||
                    this.SecureCall != null &&
                    this.SecureCall.Equals(other.SecureCall)
                ) && 
                (
                    this.NatDetected == other.NatDetected ||
                    this.NatDetected != null &&
                    this.NatDetected.Equals(other.NatDetected)
                ) && 
                (
                    this.Proxy == other.Proxy ||
                    this.Proxy != null &&
                    this.Proxy.Equals(other.Proxy)
                ) && 
                (
                    this.RoiDistance == other.RoiDistance ||
                    this.RoiDistance != null &&
                    this.RoiDistance.Equals(other.RoiDistance)
                ) && 
                (
                    this.Mpls == other.Mpls ||
                    this.Mpls != null &&
                    this.Mpls.Equals(other.Mpls)
                ) && 
                (
                    this.VideoShare == other.VideoShare ||
                    this.VideoShare != null &&
                    this.VideoShare.Equals(other.VideoShare)
                ) && 
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.MeetingJoinTime == other.MeetingJoinTime ||
                    this.MeetingJoinTime != null &&
                    this.MeetingJoinTime.Equals(other.MeetingJoinTime)
                ) && 
                (
                    this.MeetingLeaveTime == other.MeetingLeaveTime ||
                    this.MeetingLeaveTime != null &&
                    this.MeetingLeaveTime.Equals(other.MeetingLeaveTime)
                ) && 
                (
                    this.DidNumber == other.DidNumber ||
                    this.DidNumber != null &&
                    this.DidNumber.Equals(other.DidNumber)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.SummaryStats == other.SummaryStats ||
                    this.SummaryStats != null &&
                    this.SummaryStats.Equals(other.SummaryStats)
                ) && 
                (
                    this.EndpointAttributes1 == other.EndpointAttributes1 ||
                    this.EndpointAttributes1 != null &&
                    this.EndpointAttributes1.Equals(other.EndpointAttributes1)
                ) && 
                (
                    this.Traceroute == other.Traceroute ||
                    this.Traceroute != null &&
                    this.Traceroute.Equals(other.Traceroute)
                ) && 
                (
                    this.MhtaskStopped == other.MhtaskStopped ||
                    this.MhtaskStopped != null &&
                    this.MhtaskStopped.Equals(other.MhtaskStopped)
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
                if (this.Callguid != null)
                    hash = hash * 59 + this.Callguid.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Endpoint != null)
                    hash = hash * 59 + this.Endpoint.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.UniqId != null)
                    hash = hash * 59 + this.UniqId.GetHashCode();
                if (this.RemoteAddress != null)
                    hash = hash * 59 + this.RemoteAddress.GetHashCode();
                if (this.Leader != null)
                    hash = hash * 59 + this.Leader.GetHashCode();
                if (this.SecureCall != null)
                    hash = hash * 59 + this.SecureCall.GetHashCode();
                if (this.NatDetected != null)
                    hash = hash * 59 + this.NatDetected.GetHashCode();
                if (this.Proxy != null)
                    hash = hash * 59 + this.Proxy.GetHashCode();
                if (this.RoiDistance != null)
                    hash = hash * 59 + this.RoiDistance.GetHashCode();
                if (this.Mpls != null)
                    hash = hash * 59 + this.Mpls.GetHashCode();
                if (this.VideoShare != null)
                    hash = hash * 59 + this.VideoShare.GetHashCode();
                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                if (this.MeetingJoinTime != null)
                    hash = hash * 59 + this.MeetingJoinTime.GetHashCode();
                if (this.MeetingLeaveTime != null)
                    hash = hash * 59 + this.MeetingLeaveTime.GetHashCode();
                if (this.DidNumber != null)
                    hash = hash * 59 + this.DidNumber.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.SummaryStats != null)
                    hash = hash * 59 + this.SummaryStats.GetHashCode();
                if (this.EndpointAttributes1 != null)
                    hash = hash * 59 + this.EndpointAttributes1.GetHashCode();
                if (this.Traceroute != null)
                    hash = hash * 59 + this.Traceroute.GetHashCode();
                if (this.MhtaskStopped != null)
                    hash = hash * 59 + this.MhtaskStopped.GetHashCode();
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
