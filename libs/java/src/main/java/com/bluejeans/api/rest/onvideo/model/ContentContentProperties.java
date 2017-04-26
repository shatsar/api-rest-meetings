/*
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.onvideo.model;

import java.util.Objects;
import com.bluejeans.api.rest.onvideo.model.ContentContentPropertiesLevels;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * ContentContentProperties
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-04-26T17:15:49.025-06:00")
public class ContentContentProperties {
  @SerializedName("duration")
  private Integer duration = null;

  @SerializedName("thumbnail")
  private String thumbnail = null;

  @SerializedName("thumbnailSprite")
  private String thumbnailSprite = null;

  @SerializedName("hdsUrl")
  private String hdsUrl = null;

  @SerializedName("thumbnailCount")
  private Integer thumbnailCount = null;

  @SerializedName("thumbnailWidth")
  private Integer thumbnailWidth = null;

  @SerializedName("thumbnailHeight")
  private Integer thumbnailHeight = null;

  @SerializedName("thumbnailInterval")
  private Integer thumbnailInterval = null;

  @SerializedName("hlsUrl")
  private String hlsUrl = null;

  @SerializedName("levels")
  private List<ContentContentPropertiesLevels> levels = new ArrayList<ContentContentPropertiesLevels>();

  public ContentContentProperties duration(Integer duration) {
    this.duration = duration;
    return this;
  }

   /**
   * Get duration
   * @return duration
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getDuration() {
    return duration;
  }

  public void setDuration(Integer duration) {
    this.duration = duration;
  }

  public ContentContentProperties thumbnail(String thumbnail) {
    this.thumbnail = thumbnail;
    return this;
  }

   /**
   * Get thumbnail
   * @return thumbnail
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getThumbnail() {
    return thumbnail;
  }

  public void setThumbnail(String thumbnail) {
    this.thumbnail = thumbnail;
  }

  public ContentContentProperties thumbnailSprite(String thumbnailSprite) {
    this.thumbnailSprite = thumbnailSprite;
    return this;
  }

   /**
   * Get thumbnailSprite
   * @return thumbnailSprite
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getThumbnailSprite() {
    return thumbnailSprite;
  }

  public void setThumbnailSprite(String thumbnailSprite) {
    this.thumbnailSprite = thumbnailSprite;
  }

  public ContentContentProperties hdsUrl(String hdsUrl) {
    this.hdsUrl = hdsUrl;
    return this;
  }

   /**
   * Get hdsUrl
   * @return hdsUrl
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getHdsUrl() {
    return hdsUrl;
  }

  public void setHdsUrl(String hdsUrl) {
    this.hdsUrl = hdsUrl;
  }

  public ContentContentProperties thumbnailCount(Integer thumbnailCount) {
    this.thumbnailCount = thumbnailCount;
    return this;
  }

   /**
   * Get thumbnailCount
   * @return thumbnailCount
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getThumbnailCount() {
    return thumbnailCount;
  }

  public void setThumbnailCount(Integer thumbnailCount) {
    this.thumbnailCount = thumbnailCount;
  }

  public ContentContentProperties thumbnailWidth(Integer thumbnailWidth) {
    this.thumbnailWidth = thumbnailWidth;
    return this;
  }

   /**
   * Get thumbnailWidth
   * @return thumbnailWidth
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getThumbnailWidth() {
    return thumbnailWidth;
  }

  public void setThumbnailWidth(Integer thumbnailWidth) {
    this.thumbnailWidth = thumbnailWidth;
  }

  public ContentContentProperties thumbnailHeight(Integer thumbnailHeight) {
    this.thumbnailHeight = thumbnailHeight;
    return this;
  }

   /**
   * Get thumbnailHeight
   * @return thumbnailHeight
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getThumbnailHeight() {
    return thumbnailHeight;
  }

  public void setThumbnailHeight(Integer thumbnailHeight) {
    this.thumbnailHeight = thumbnailHeight;
  }

  public ContentContentProperties thumbnailInterval(Integer thumbnailInterval) {
    this.thumbnailInterval = thumbnailInterval;
    return this;
  }

   /**
   * Get thumbnailInterval
   * @return thumbnailInterval
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getThumbnailInterval() {
    return thumbnailInterval;
  }

  public void setThumbnailInterval(Integer thumbnailInterval) {
    this.thumbnailInterval = thumbnailInterval;
  }

  public ContentContentProperties hlsUrl(String hlsUrl) {
    this.hlsUrl = hlsUrl;
    return this;
  }

   /**
   * Get hlsUrl
   * @return hlsUrl
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getHlsUrl() {
    return hlsUrl;
  }

  public void setHlsUrl(String hlsUrl) {
    this.hlsUrl = hlsUrl;
  }

  public ContentContentProperties levels(List<ContentContentPropertiesLevels> levels) {
    this.levels = levels;
    return this;
  }

  public ContentContentProperties addLevelsItem(ContentContentPropertiesLevels levelsItem) {
    this.levels.add(levelsItem);
    return this;
  }

   /**
   * Get levels
   * @return levels
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<ContentContentPropertiesLevels> getLevels() {
    return levels;
  }

  public void setLevels(List<ContentContentPropertiesLevels> levels) {
    this.levels = levels;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContentContentProperties contentContentProperties = (ContentContentProperties) o;
    return Objects.equals(this.duration, contentContentProperties.duration) &&
        Objects.equals(this.thumbnail, contentContentProperties.thumbnail) &&
        Objects.equals(this.thumbnailSprite, contentContentProperties.thumbnailSprite) &&
        Objects.equals(this.hdsUrl, contentContentProperties.hdsUrl) &&
        Objects.equals(this.thumbnailCount, contentContentProperties.thumbnailCount) &&
        Objects.equals(this.thumbnailWidth, contentContentProperties.thumbnailWidth) &&
        Objects.equals(this.thumbnailHeight, contentContentProperties.thumbnailHeight) &&
        Objects.equals(this.thumbnailInterval, contentContentProperties.thumbnailInterval) &&
        Objects.equals(this.hlsUrl, contentContentProperties.hlsUrl) &&
        Objects.equals(this.levels, contentContentProperties.levels);
  }

  @Override
  public int hashCode() {
    return Objects.hash(duration, thumbnail, thumbnailSprite, hdsUrl, thumbnailCount, thumbnailWidth, thumbnailHeight, thumbnailInterval, hlsUrl, levels);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContentContentProperties {\n");
    
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
    sb.append("    thumbnail: ").append(toIndentedString(thumbnail)).append("\n");
    sb.append("    thumbnailSprite: ").append(toIndentedString(thumbnailSprite)).append("\n");
    sb.append("    hdsUrl: ").append(toIndentedString(hdsUrl)).append("\n");
    sb.append("    thumbnailCount: ").append(toIndentedString(thumbnailCount)).append("\n");
    sb.append("    thumbnailWidth: ").append(toIndentedString(thumbnailWidth)).append("\n");
    sb.append("    thumbnailHeight: ").append(toIndentedString(thumbnailHeight)).append("\n");
    sb.append("    thumbnailInterval: ").append(toIndentedString(thumbnailInterval)).append("\n");
    sb.append("    hlsUrl: ").append(toIndentedString(hlsUrl)).append("\n");
    sb.append("    levels: ").append(toIndentedString(levels)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

