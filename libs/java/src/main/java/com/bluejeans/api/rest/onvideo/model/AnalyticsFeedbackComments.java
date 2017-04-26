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
import com.bluejeans.api.rest.onvideo.model.AnalyticsFeedbackCommentsComments;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * AnalyticsFeedbackComments
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-04-26T17:15:49.025-06:00")
public class AnalyticsFeedbackComments {
  @SerializedName("comments")
  private List<AnalyticsFeedbackCommentsComments> comments = new ArrayList<AnalyticsFeedbackCommentsComments>();

  public AnalyticsFeedbackComments comments(List<AnalyticsFeedbackCommentsComments> comments) {
    this.comments = comments;
    return this;
  }

  public AnalyticsFeedbackComments addCommentsItem(AnalyticsFeedbackCommentsComments commentsItem) {
    this.comments.add(commentsItem);
    return this;
  }

   /**
   * Get comments
   * @return comments
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<AnalyticsFeedbackCommentsComments> getComments() {
    return comments;
  }

  public void setComments(List<AnalyticsFeedbackCommentsComments> comments) {
    this.comments = comments;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AnalyticsFeedbackComments analyticsFeedbackComments = (AnalyticsFeedbackComments) o;
    return Objects.equals(this.comments, analyticsFeedbackComments.comments);
  }

  @Override
  public int hashCode() {
    return Objects.hash(comments);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AnalyticsFeedbackComments {\n");
    
    sb.append("    comments: ").append(toIndentedString(comments)).append("\n");
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

