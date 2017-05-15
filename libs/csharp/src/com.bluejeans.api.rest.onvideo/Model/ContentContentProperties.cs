/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\"). ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use one of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
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
    /// ContentContentProperties
    /// </summary>
    [DataContract]
    public partial class ContentContentProperties :  IEquatable<ContentContentProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentContentProperties" /> class.
        /// </summary>
        /// <param name="Duration">Duration.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="ThumbnailSprite">ThumbnailSprite.</param>
        /// <param name="HdsUrl">HdsUrl.</param>
        /// <param name="ThumbnailCount">ThumbnailCount.</param>
        /// <param name="ThumbnailWidth">ThumbnailWidth.</param>
        /// <param name="ThumbnailHeight">ThumbnailHeight.</param>
        /// <param name="ThumbnailInterval">ThumbnailInterval.</param>
        /// <param name="HlsUrl">HlsUrl.</param>
        /// <param name="Levels">Levels.</param>
        public ContentContentProperties(int? Duration = default(int?), string Thumbnail = default(string), string ThumbnailSprite = default(string), string HdsUrl = default(string), int? ThumbnailCount = default(int?), int? ThumbnailWidth = default(int?), int? ThumbnailHeight = default(int?), int? ThumbnailInterval = default(int?), string HlsUrl = default(string), List<ContentContentPropertiesLevels> Levels = default(List<ContentContentPropertiesLevels>))
        {
            this.Duration = Duration;
            this.Thumbnail = Thumbnail;
            this.ThumbnailSprite = ThumbnailSprite;
            this.HdsUrl = HdsUrl;
            this.ThumbnailCount = ThumbnailCount;
            this.ThumbnailWidth = ThumbnailWidth;
            this.ThumbnailHeight = ThumbnailHeight;
            this.ThumbnailInterval = ThumbnailInterval;
            this.HlsUrl = HlsUrl;
            this.Levels = Levels;
        }
        
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailSprite
        /// </summary>
        [DataMember(Name="thumbnailSprite", EmitDefaultValue=false)]
        public string ThumbnailSprite { get; set; }
        /// <summary>
        /// Gets or Sets HdsUrl
        /// </summary>
        [DataMember(Name="hdsUrl", EmitDefaultValue=false)]
        public string HdsUrl { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailCount
        /// </summary>
        [DataMember(Name="thumbnailCount", EmitDefaultValue=false)]
        public int? ThumbnailCount { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailWidth
        /// </summary>
        [DataMember(Name="thumbnailWidth", EmitDefaultValue=false)]
        public int? ThumbnailWidth { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailHeight
        /// </summary>
        [DataMember(Name="thumbnailHeight", EmitDefaultValue=false)]
        public int? ThumbnailHeight { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailInterval
        /// </summary>
        [DataMember(Name="thumbnailInterval", EmitDefaultValue=false)]
        public int? ThumbnailInterval { get; set; }
        /// <summary>
        /// Gets or Sets HlsUrl
        /// </summary>
        [DataMember(Name="hlsUrl", EmitDefaultValue=false)]
        public string HlsUrl { get; set; }
        /// <summary>
        /// Gets or Sets Levels
        /// </summary>
        [DataMember(Name="levels", EmitDefaultValue=false)]
        public List<ContentContentPropertiesLevels> Levels { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentContentProperties {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  ThumbnailSprite: ").Append(ThumbnailSprite).Append("\n");
            sb.Append("  HdsUrl: ").Append(HdsUrl).Append("\n");
            sb.Append("  ThumbnailCount: ").Append(ThumbnailCount).Append("\n");
            sb.Append("  ThumbnailWidth: ").Append(ThumbnailWidth).Append("\n");
            sb.Append("  ThumbnailHeight: ").Append(ThumbnailHeight).Append("\n");
            sb.Append("  ThumbnailInterval: ").Append(ThumbnailInterval).Append("\n");
            sb.Append("  HlsUrl: ").Append(HlsUrl).Append("\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
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
            return this.Equals(obj as ContentContentProperties);
        }

        /// <summary>
        /// Returns true if ContentContentProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentContentProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentContentProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.ThumbnailSprite == other.ThumbnailSprite ||
                    this.ThumbnailSprite != null &&
                    this.ThumbnailSprite.Equals(other.ThumbnailSprite)
                ) && 
                (
                    this.HdsUrl == other.HdsUrl ||
                    this.HdsUrl != null &&
                    this.HdsUrl.Equals(other.HdsUrl)
                ) && 
                (
                    this.ThumbnailCount == other.ThumbnailCount ||
                    this.ThumbnailCount != null &&
                    this.ThumbnailCount.Equals(other.ThumbnailCount)
                ) && 
                (
                    this.ThumbnailWidth == other.ThumbnailWidth ||
                    this.ThumbnailWidth != null &&
                    this.ThumbnailWidth.Equals(other.ThumbnailWidth)
                ) && 
                (
                    this.ThumbnailHeight == other.ThumbnailHeight ||
                    this.ThumbnailHeight != null &&
                    this.ThumbnailHeight.Equals(other.ThumbnailHeight)
                ) && 
                (
                    this.ThumbnailInterval == other.ThumbnailInterval ||
                    this.ThumbnailInterval != null &&
                    this.ThumbnailInterval.Equals(other.ThumbnailInterval)
                ) && 
                (
                    this.HlsUrl == other.HlsUrl ||
                    this.HlsUrl != null &&
                    this.HlsUrl.Equals(other.HlsUrl)
                ) && 
                (
                    this.Levels == other.Levels ||
                    this.Levels != null &&
                    this.Levels.SequenceEqual(other.Levels)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.ThumbnailSprite != null)
                    hash = hash * 59 + this.ThumbnailSprite.GetHashCode();
                if (this.HdsUrl != null)
                    hash = hash * 59 + this.HdsUrl.GetHashCode();
                if (this.ThumbnailCount != null)
                    hash = hash * 59 + this.ThumbnailCount.GetHashCode();
                if (this.ThumbnailWidth != null)
                    hash = hash * 59 + this.ThumbnailWidth.GetHashCode();
                if (this.ThumbnailHeight != null)
                    hash = hash * 59 + this.ThumbnailHeight.GetHashCode();
                if (this.ThumbnailInterval != null)
                    hash = hash * 59 + this.ThumbnailInterval.GetHashCode();
                if (this.HlsUrl != null)
                    hash = hash * 59 + this.HlsUrl.GetHashCode();
                if (this.Levels != null)
                    hash = hash * 59 + this.Levels.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}