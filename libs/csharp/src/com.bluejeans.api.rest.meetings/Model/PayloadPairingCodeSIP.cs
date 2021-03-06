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
    /// PayloadPairingCodeSIP
    /// </summary>
    [DataContract]
    public partial class PayloadPairingCodeSIP :  IEquatable<PayloadPairingCodeSIP>, IValidatableObject
    {
        /// <summary>
        /// Optional language code
        /// </summary>
        /// <value>Optional language code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageCodeEnum
        {
            
            /// <summary>
            /// Enum En for "en"
            /// </summary>
            [EnumMember(Value = "en")]
            En,
            
            /// <summary>
            /// Enum Enus for "en-us"
            /// </summary>
            [EnumMember(Value = "en-us")]
            Enus,
            
            /// <summary>
            /// Enum Engb for "en-gb"
            /// </summary>
            [EnumMember(Value = "en-gb")]
            Engb,
            
            /// <summary>
            /// Enum De for "de"
            /// </summary>
            [EnumMember(Value = "de")]
            De
        }

        /// <summary>
        /// Optional language code
        /// </summary>
        /// <value>Optional language code</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadPairingCodeSIP" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayloadPairingCodeSIP() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadPairingCodeSIP" /> class.
        /// </summary>
        /// <param name="EndpointType">1:GENERIC 2:LYNC 3:JABBER 4:BluejeansBrowser 5:BluejeansMobile (required).</param>
        /// <param name="UserId">Optional database id of user associated with endpoint.</param>
        /// <param name="LanguageCode">Optional language code (default to LanguageCodeEnum.En).</param>
        /// <param name="EndpointName">Optional name of endpoint (default to &quot;My Test Endpoint&quot;).</param>
        public PayloadPairingCodeSIP(int? EndpointType = default(int?), int? UserId = default(int?), LanguageCodeEnum? LanguageCode = LanguageCodeEnum.En, string EndpointName = "My Test Endpoint")
        {
            // to ensure "EndpointType" is required (not null)
            if (EndpointType == null)
            {
                throw new InvalidDataException("EndpointType is a required property for PayloadPairingCodeSIP and cannot be null");
            }
            else
            {
                this.EndpointType = EndpointType;
            }
            this.UserId = UserId;
            // use default value if no "LanguageCode" provided
            if (LanguageCode == null)
            {
                this.LanguageCode = LanguageCodeEnum.En;
            }
            else
            {
                this.LanguageCode = LanguageCode;
            }
            // use default value if no "EndpointName" provided
            if (EndpointName == null)
            {
                this.EndpointName = "My Test Endpoint";
            }
            else
            {
                this.EndpointName = EndpointName;
            }
        }
        
        /// <summary>
        /// 1:GENERIC 2:LYNC 3:JABBER 4:BluejeansBrowser 5:BluejeansMobile
        /// </summary>
        /// <value>1:GENERIC 2:LYNC 3:JABBER 4:BluejeansBrowser 5:BluejeansMobile</value>
        [DataMember(Name="endpointType", EmitDefaultValue=false)]
        public int? EndpointType { get; set; }

        /// <summary>
        /// Optional database id of user associated with endpoint
        /// </summary>
        /// <value>Optional database id of user associated with endpoint</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }


        /// <summary>
        /// Optional name of endpoint
        /// </summary>
        /// <value>Optional name of endpoint</value>
        [DataMember(Name="endpointName", EmitDefaultValue=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayloadPairingCodeSIP {\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
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
            return this.Equals(obj as PayloadPairingCodeSIP);
        }

        /// <summary>
        /// Returns true if PayloadPairingCodeSIP instances are equal
        /// </summary>
        /// <param name="other">Instance of PayloadPairingCodeSIP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayloadPairingCodeSIP other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndpointType == other.EndpointType ||
                    this.EndpointType != null &&
                    this.EndpointType.Equals(other.EndpointType)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) && 
                (
                    this.EndpointName == other.EndpointName ||
                    this.EndpointName != null &&
                    this.EndpointName.Equals(other.EndpointName)
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
                if (this.EndpointType != null)
                    hash = hash * 59 + this.EndpointType.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                if (this.EndpointName != null)
                    hash = hash * 59 + this.EndpointName.GetHashCode();
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
