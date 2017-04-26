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
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * AnalyticsEndpointDistributionDistribution
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-04-26T17:15:49.025-06:00")
public class AnalyticsEndpointDistributionDistribution {
  @SerializedName("Google")
  private Integer google = null;

  @SerializedName("Telepresence")
  private Integer telepresence = null;

  @SerializedName("Lync")
  private Integer lync = null;

  @SerializedName("iOS")
  private Integer iOS = null;

  @SerializedName("H323")
  private Integer h323 = null;

  @SerializedName("InterCall")
  private Integer interCall = null;

  @SerializedName("Jabber")
  private Integer jabber = null;

  @SerializedName("Android")
  private Integer android = null;

  @SerializedName("Skype")
  private Integer skype = null;

  @SerializedName("ISDN")
  private Integer ISDN = null;

  @SerializedName("PSTN")
  private Integer PSTN = null;

  @SerializedName("Level3")
  private Integer level3 = null;

  @SerializedName("SIP")
  private Integer SIP = null;

  @SerializedName("BlueJeansApp")
  private Integer blueJeansApp = null;

  @SerializedName("Browser")
  private Integer browser = null;

  @SerializedName("WebRTC")
  private Integer webRTC = null;

  public AnalyticsEndpointDistributionDistribution google(Integer google) {
    this.google = google;
    return this;
  }

   /**
   * Get google
   * @return google
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getGoogle() {
    return google;
  }

  public void setGoogle(Integer google) {
    this.google = google;
  }

  public AnalyticsEndpointDistributionDistribution telepresence(Integer telepresence) {
    this.telepresence = telepresence;
    return this;
  }

   /**
   * Get telepresence
   * @return telepresence
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getTelepresence() {
    return telepresence;
  }

  public void setTelepresence(Integer telepresence) {
    this.telepresence = telepresence;
  }

  public AnalyticsEndpointDistributionDistribution lync(Integer lync) {
    this.lync = lync;
    return this;
  }

   /**
   * Get lync
   * @return lync
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getLync() {
    return lync;
  }

  public void setLync(Integer lync) {
    this.lync = lync;
  }

  public AnalyticsEndpointDistributionDistribution iOS(Integer iOS) {
    this.iOS = iOS;
    return this;
  }

   /**
   * Get iOS
   * @return iOS
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getIOS() {
    return iOS;
  }

  public void setIOS(Integer iOS) {
    this.iOS = iOS;
  }

  public AnalyticsEndpointDistributionDistribution h323(Integer h323) {
    this.h323 = h323;
    return this;
  }

   /**
   * Get h323
   * @return h323
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getH323() {
    return h323;
  }

  public void setH323(Integer h323) {
    this.h323 = h323;
  }

  public AnalyticsEndpointDistributionDistribution interCall(Integer interCall) {
    this.interCall = interCall;
    return this;
  }

   /**
   * Get interCall
   * @return interCall
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getInterCall() {
    return interCall;
  }

  public void setInterCall(Integer interCall) {
    this.interCall = interCall;
  }

  public AnalyticsEndpointDistributionDistribution jabber(Integer jabber) {
    this.jabber = jabber;
    return this;
  }

   /**
   * Get jabber
   * @return jabber
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getJabber() {
    return jabber;
  }

  public void setJabber(Integer jabber) {
    this.jabber = jabber;
  }

  public AnalyticsEndpointDistributionDistribution android(Integer android) {
    this.android = android;
    return this;
  }

   /**
   * Get android
   * @return android
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getAndroid() {
    return android;
  }

  public void setAndroid(Integer android) {
    this.android = android;
  }

  public AnalyticsEndpointDistributionDistribution skype(Integer skype) {
    this.skype = skype;
    return this;
  }

   /**
   * Get skype
   * @return skype
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getSkype() {
    return skype;
  }

  public void setSkype(Integer skype) {
    this.skype = skype;
  }

  public AnalyticsEndpointDistributionDistribution ISDN(Integer ISDN) {
    this.ISDN = ISDN;
    return this;
  }

   /**
   * Get ISDN
   * @return ISDN
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getISDN() {
    return ISDN;
  }

  public void setISDN(Integer ISDN) {
    this.ISDN = ISDN;
  }

  public AnalyticsEndpointDistributionDistribution PSTN(Integer PSTN) {
    this.PSTN = PSTN;
    return this;
  }

   /**
   * Get PSTN
   * @return PSTN
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getPSTN() {
    return PSTN;
  }

  public void setPSTN(Integer PSTN) {
    this.PSTN = PSTN;
  }

  public AnalyticsEndpointDistributionDistribution level3(Integer level3) {
    this.level3 = level3;
    return this;
  }

   /**
   * Get level3
   * @return level3
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getLevel3() {
    return level3;
  }

  public void setLevel3(Integer level3) {
    this.level3 = level3;
  }

  public AnalyticsEndpointDistributionDistribution SIP(Integer SIP) {
    this.SIP = SIP;
    return this;
  }

   /**
   * Get SIP
   * @return SIP
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getSIP() {
    return SIP;
  }

  public void setSIP(Integer SIP) {
    this.SIP = SIP;
  }

  public AnalyticsEndpointDistributionDistribution blueJeansApp(Integer blueJeansApp) {
    this.blueJeansApp = blueJeansApp;
    return this;
  }

   /**
   * Get blueJeansApp
   * @return blueJeansApp
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getBlueJeansApp() {
    return blueJeansApp;
  }

  public void setBlueJeansApp(Integer blueJeansApp) {
    this.blueJeansApp = blueJeansApp;
  }

  public AnalyticsEndpointDistributionDistribution browser(Integer browser) {
    this.browser = browser;
    return this;
  }

   /**
   * Get browser
   * @return browser
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getBrowser() {
    return browser;
  }

  public void setBrowser(Integer browser) {
    this.browser = browser;
  }

  public AnalyticsEndpointDistributionDistribution webRTC(Integer webRTC) {
    this.webRTC = webRTC;
    return this;
  }

   /**
   * Get webRTC
   * @return webRTC
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getWebRTC() {
    return webRTC;
  }

  public void setWebRTC(Integer webRTC) {
    this.webRTC = webRTC;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AnalyticsEndpointDistributionDistribution analyticsEndpointDistributionDistribution = (AnalyticsEndpointDistributionDistribution) o;
    return Objects.equals(this.google, analyticsEndpointDistributionDistribution.google) &&
        Objects.equals(this.telepresence, analyticsEndpointDistributionDistribution.telepresence) &&
        Objects.equals(this.lync, analyticsEndpointDistributionDistribution.lync) &&
        Objects.equals(this.iOS, analyticsEndpointDistributionDistribution.iOS) &&
        Objects.equals(this.h323, analyticsEndpointDistributionDistribution.h323) &&
        Objects.equals(this.interCall, analyticsEndpointDistributionDistribution.interCall) &&
        Objects.equals(this.jabber, analyticsEndpointDistributionDistribution.jabber) &&
        Objects.equals(this.android, analyticsEndpointDistributionDistribution.android) &&
        Objects.equals(this.skype, analyticsEndpointDistributionDistribution.skype) &&
        Objects.equals(this.ISDN, analyticsEndpointDistributionDistribution.ISDN) &&
        Objects.equals(this.PSTN, analyticsEndpointDistributionDistribution.PSTN) &&
        Objects.equals(this.level3, analyticsEndpointDistributionDistribution.level3) &&
        Objects.equals(this.SIP, analyticsEndpointDistributionDistribution.SIP) &&
        Objects.equals(this.blueJeansApp, analyticsEndpointDistributionDistribution.blueJeansApp) &&
        Objects.equals(this.browser, analyticsEndpointDistributionDistribution.browser) &&
        Objects.equals(this.webRTC, analyticsEndpointDistributionDistribution.webRTC);
  }

  @Override
  public int hashCode() {
    return Objects.hash(google, telepresence, lync, iOS, h323, interCall, jabber, android, skype, ISDN, PSTN, level3, SIP, blueJeansApp, browser, webRTC);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AnalyticsEndpointDistributionDistribution {\n");
    
    sb.append("    google: ").append(toIndentedString(google)).append("\n");
    sb.append("    telepresence: ").append(toIndentedString(telepresence)).append("\n");
    sb.append("    lync: ").append(toIndentedString(lync)).append("\n");
    sb.append("    iOS: ").append(toIndentedString(iOS)).append("\n");
    sb.append("    h323: ").append(toIndentedString(h323)).append("\n");
    sb.append("    interCall: ").append(toIndentedString(interCall)).append("\n");
    sb.append("    jabber: ").append(toIndentedString(jabber)).append("\n");
    sb.append("    android: ").append(toIndentedString(android)).append("\n");
    sb.append("    skype: ").append(toIndentedString(skype)).append("\n");
    sb.append("    ISDN: ").append(toIndentedString(ISDN)).append("\n");
    sb.append("    PSTN: ").append(toIndentedString(PSTN)).append("\n");
    sb.append("    level3: ").append(toIndentedString(level3)).append("\n");
    sb.append("    SIP: ").append(toIndentedString(SIP)).append("\n");
    sb.append("    blueJeansApp: ").append(toIndentedString(blueJeansApp)).append("\n");
    sb.append("    browser: ").append(toIndentedString(browser)).append("\n");
    sb.append("    webRTC: ").append(toIndentedString(webRTC)).append("\n");
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

