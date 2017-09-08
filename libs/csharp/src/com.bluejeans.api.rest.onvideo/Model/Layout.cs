/* 
 * BlueJeans onVideo REST API
 *
 *  Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you should be able to quickly integrate **BlueJeans** video administration into your applications.   ## Getting Started Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact [BlueJeans Support](mailto:Support@BlueJeans.com) for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br /> ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. ## About onVideo Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. 
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
using SwaggerDateConverter = com.bluejeans.api.rest.onvideo.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.onvideo.Model
{
    /// <summary>
    /// Layout
    /// </summary>
    [DataContract]
    public partial class Layout :  IEquatable<Layout>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LayoutMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutModeEnum
        {
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video
        }

        /// <summary>
        /// Misspelling in value.
        /// </summary>
        /// <value>Misspelling in value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubLayoutModeEnum
        {
            
            /// <summary>
            /// Enum VideoContiniousPresence for "VideoContiniousPresence"
            /// </summary>
            [EnumMember(Value = "VideoContiniousPresence")]
            VideoContiniousPresence
        }

        /// <summary>
        /// Gets or Sets LayoutMode
        /// </summary>
        [DataMember(Name="layoutMode", EmitDefaultValue=false)]
        public LayoutModeEnum? LayoutMode { get; set; }
        /// <summary>
        /// Misspelling in value.
        /// </summary>
        /// <value>Misspelling in value.</value>
        [DataMember(Name="subLayoutMode", EmitDefaultValue=false)]
        public SubLayoutModeEnum? SubLayoutMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Layout" /> class.
        /// </summary>
        /// <param name="LayoutMode">LayoutMode.</param>
        /// <param name="SubLayoutMode">Misspelling in value..</param>
        public Layout(LayoutModeEnum? LayoutMode = default(LayoutModeEnum?), SubLayoutModeEnum? SubLayoutMode = default(SubLayoutModeEnum?))
        {
            this.LayoutMode = LayoutMode;
            this.SubLayoutMode = SubLayoutMode;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Layout {\n");
            sb.Append("  LayoutMode: ").Append(LayoutMode).Append("\n");
            sb.Append("  SubLayoutMode: ").Append(SubLayoutMode).Append("\n");
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
            return this.Equals(obj as Layout);
        }

        /// <summary>
        /// Returns true if Layout instances are equal
        /// </summary>
        /// <param name="other">Instance of Layout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Layout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LayoutMode == other.LayoutMode ||
                    this.LayoutMode != null &&
                    this.LayoutMode.Equals(other.LayoutMode)
                ) && 
                (
                    this.SubLayoutMode == other.SubLayoutMode ||
                    this.SubLayoutMode != null &&
                    this.SubLayoutMode.Equals(other.SubLayoutMode)
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
                if (this.LayoutMode != null)
                    hash = hash * 59 + this.LayoutMode.GetHashCode();
                if (this.SubLayoutMode != null)
                    hash = hash * 59 + this.SubLayoutMode.GetHashCode();
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
