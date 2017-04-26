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
    /// EndpointsInnerConnections
    /// </summary>
    [DataContract]
    public partial class EndpointsInnerConnections :  IEquatable<EndpointsInnerConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsInnerConnections" /> class.
        /// </summary>
        /// <param name="ConnectionGuid">ConnectionGuid.</param>
        /// <param name="Capabilities">Capabilities.</param>
        /// <param name="Endpoint">Endpoint.</param>
        /// <param name="CallGuid">CallGuid.</param>
        public EndpointsInnerConnections(string ConnectionGuid = default(string), List<string> Capabilities = default(List<string>), string Endpoint = default(string), string CallGuid = default(string))
        {
            this.ConnectionGuid = ConnectionGuid;
            this.Capabilities = Capabilities;
            this.Endpoint = Endpoint;
            this.CallGuid = CallGuid;
        }
        
        /// <summary>
        /// Gets or Sets ConnectionGuid
        /// </summary>
        [DataMember(Name="connectionGuid", EmitDefaultValue=false)]
        public string ConnectionGuid { get; set; }
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<string> Capabilities { get; set; }
        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }
        /// <summary>
        /// Gets or Sets CallGuid
        /// </summary>
        [DataMember(Name="callGuid", EmitDefaultValue=false)]
        public string CallGuid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointsInnerConnections {\n");
            sb.Append("  ConnectionGuid: ").Append(ConnectionGuid).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  CallGuid: ").Append(CallGuid).Append("\n");
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
            return this.Equals(obj as EndpointsInnerConnections);
        }

        /// <summary>
        /// Returns true if EndpointsInnerConnections instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointsInnerConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointsInnerConnections other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectionGuid == other.ConnectionGuid ||
                    this.ConnectionGuid != null &&
                    this.ConnectionGuid.Equals(other.ConnectionGuid)
                ) && 
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
                ) && 
                (
                    this.Endpoint == other.Endpoint ||
                    this.Endpoint != null &&
                    this.Endpoint.Equals(other.Endpoint)
                ) && 
                (
                    this.CallGuid == other.CallGuid ||
                    this.CallGuid != null &&
                    this.CallGuid.Equals(other.CallGuid)
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
                if (this.ConnectionGuid != null)
                    hash = hash * 59 + this.ConnectionGuid.GetHashCode();
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                if (this.Endpoint != null)
                    hash = hash * 59 + this.Endpoint.GetHashCode();
                if (this.CallGuid != null)
                    hash = hash * 59 + this.CallGuid.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
