/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.model;

import java.util.Objects;
import com.bluejeans.api.rest.meetings.model.EndpointsInnerConnections;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * EndpointsInner
 */

public class EndpointsInner {
  @SerializedName("meetingid")
  private String meetingid = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("CallQuality")
  private String callQuality = null;

  @SerializedName("Leader")
  private String leader = null;

  @SerializedName("callguid")
  private String callguid = null;

  @SerializedName("endpoint")
  private String endpoint = null;

  @SerializedName("TalkDetected")
  private String talkDetected = null;

  @SerializedName("SecureCall")
  private String secureCall = null;

  @SerializedName("Layout")
  private String layout = null;

  @SerializedName("SubLayout")
  private String subLayout = null;

  @SerializedName("VideoRecv")
  private String videoRecv = null;

  @SerializedName("VideoRecvLocalMute")
  private String videoRecvLocalMute = null;

  @SerializedName("VideoRecvRemoteMute")
  private String videoRecvRemoteMute = null;

  @SerializedName("AudioRecv")
  private String audioRecv = null;

  @SerializedName("AudioRecvLocalMute")
  private String audioRecvLocalMute = null;

  @SerializedName("AudioRecvRemoteMute")
  private String audioRecvRemoteMute = null;

  @SerializedName("AudioRecvCodec")
  private String audioRecvCodec = null;

  @SerializedName("AudioSendCodec")
  private String audioSendCodec = null;

  @SerializedName("VideoRecvCodec")
  private String videoRecvCodec = null;

  @SerializedName("VideoRecvHeight")
  private String videoRecvHeight = null;

  @SerializedName("VideoRecvWidth")
  private String videoRecvWidth = null;

  @SerializedName("VideoSendCodec")
  private String videoSendCodec = null;

  @SerializedName("VideoSendHeight")
  private String videoSendHeight = null;

  @SerializedName("VideoSendWidth")
  private String videoSendWidth = null;

  @SerializedName("visibility")
  private String visibility = null;

  @SerializedName("chatEndpointGuid")
  private String chatEndpointGuid = null;

  @SerializedName("endpointGuid")
  private String endpointGuid = null;

  @SerializedName("RDCVersion")
  private String rdCVersion = null;

  @SerializedName("RDCControllerCapable")
  private String rdCControllerCapable = null;

  @SerializedName("RDCControlleeCapable")
  private String rdCControlleeCapable = null;

  @SerializedName("connections")
  private List<EndpointsInnerConnections> connections = null;

  public EndpointsInner meetingid(String meetingid) {
    this.meetingid = meetingid;
    return this;
  }

   /**
   * Get meetingid
   * @return meetingid
  **/
  @ApiModelProperty(value = "")
  public String getMeetingid() {
    return meetingid;
  }

  public void setMeetingid(String meetingid) {
    this.meetingid = meetingid;
  }

  public EndpointsInner name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(value = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public EndpointsInner callQuality(String callQuality) {
    this.callQuality = callQuality;
    return this;
  }

   /**
   * Get callQuality
   * @return callQuality
  **/
  @ApiModelProperty(value = "")
  public String getCallQuality() {
    return callQuality;
  }

  public void setCallQuality(String callQuality) {
    this.callQuality = callQuality;
  }

  public EndpointsInner leader(String leader) {
    this.leader = leader;
    return this;
  }

   /**
   * Get leader
   * @return leader
  **/
  @ApiModelProperty(value = "")
  public String getLeader() {
    return leader;
  }

  public void setLeader(String leader) {
    this.leader = leader;
  }

  public EndpointsInner callguid(String callguid) {
    this.callguid = callguid;
    return this;
  }

   /**
   * Get callguid
   * @return callguid
  **/
  @ApiModelProperty(value = "")
  public String getCallguid() {
    return callguid;
  }

  public void setCallguid(String callguid) {
    this.callguid = callguid;
  }

  public EndpointsInner endpoint(String endpoint) {
    this.endpoint = endpoint;
    return this;
  }

   /**
   * Get endpoint
   * @return endpoint
  **/
  @ApiModelProperty(value = "")
  public String getEndpoint() {
    return endpoint;
  }

  public void setEndpoint(String endpoint) {
    this.endpoint = endpoint;
  }

  public EndpointsInner talkDetected(String talkDetected) {
    this.talkDetected = talkDetected;
    return this;
  }

   /**
   * Get talkDetected
   * @return talkDetected
  **/
  @ApiModelProperty(value = "")
  public String getTalkDetected() {
    return talkDetected;
  }

  public void setTalkDetected(String talkDetected) {
    this.talkDetected = talkDetected;
  }

  public EndpointsInner secureCall(String secureCall) {
    this.secureCall = secureCall;
    return this;
  }

   /**
   * Get secureCall
   * @return secureCall
  **/
  @ApiModelProperty(value = "")
  public String getSecureCall() {
    return secureCall;
  }

  public void setSecureCall(String secureCall) {
    this.secureCall = secureCall;
  }

  public EndpointsInner layout(String layout) {
    this.layout = layout;
    return this;
  }

   /**
   * Get layout
   * @return layout
  **/
  @ApiModelProperty(value = "")
  public String getLayout() {
    return layout;
  }

  public void setLayout(String layout) {
    this.layout = layout;
  }

  public EndpointsInner subLayout(String subLayout) {
    this.subLayout = subLayout;
    return this;
  }

   /**
   * Get subLayout
   * @return subLayout
  **/
  @ApiModelProperty(value = "")
  public String getSubLayout() {
    return subLayout;
  }

  public void setSubLayout(String subLayout) {
    this.subLayout = subLayout;
  }

  public EndpointsInner videoRecv(String videoRecv) {
    this.videoRecv = videoRecv;
    return this;
  }

   /**
   * Get videoRecv
   * @return videoRecv
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecv() {
    return videoRecv;
  }

  public void setVideoRecv(String videoRecv) {
    this.videoRecv = videoRecv;
  }

  public EndpointsInner videoRecvLocalMute(String videoRecvLocalMute) {
    this.videoRecvLocalMute = videoRecvLocalMute;
    return this;
  }

   /**
   * Get videoRecvLocalMute
   * @return videoRecvLocalMute
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecvLocalMute() {
    return videoRecvLocalMute;
  }

  public void setVideoRecvLocalMute(String videoRecvLocalMute) {
    this.videoRecvLocalMute = videoRecvLocalMute;
  }

  public EndpointsInner videoRecvRemoteMute(String videoRecvRemoteMute) {
    this.videoRecvRemoteMute = videoRecvRemoteMute;
    return this;
  }

   /**
   * Get videoRecvRemoteMute
   * @return videoRecvRemoteMute
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecvRemoteMute() {
    return videoRecvRemoteMute;
  }

  public void setVideoRecvRemoteMute(String videoRecvRemoteMute) {
    this.videoRecvRemoteMute = videoRecvRemoteMute;
  }

  public EndpointsInner audioRecv(String audioRecv) {
    this.audioRecv = audioRecv;
    return this;
  }

   /**
   * Get audioRecv
   * @return audioRecv
  **/
  @ApiModelProperty(value = "")
  public String getAudioRecv() {
    return audioRecv;
  }

  public void setAudioRecv(String audioRecv) {
    this.audioRecv = audioRecv;
  }

  public EndpointsInner audioRecvLocalMute(String audioRecvLocalMute) {
    this.audioRecvLocalMute = audioRecvLocalMute;
    return this;
  }

   /**
   * Get audioRecvLocalMute
   * @return audioRecvLocalMute
  **/
  @ApiModelProperty(value = "")
  public String getAudioRecvLocalMute() {
    return audioRecvLocalMute;
  }

  public void setAudioRecvLocalMute(String audioRecvLocalMute) {
    this.audioRecvLocalMute = audioRecvLocalMute;
  }

  public EndpointsInner audioRecvRemoteMute(String audioRecvRemoteMute) {
    this.audioRecvRemoteMute = audioRecvRemoteMute;
    return this;
  }

   /**
   * Get audioRecvRemoteMute
   * @return audioRecvRemoteMute
  **/
  @ApiModelProperty(value = "")
  public String getAudioRecvRemoteMute() {
    return audioRecvRemoteMute;
  }

  public void setAudioRecvRemoteMute(String audioRecvRemoteMute) {
    this.audioRecvRemoteMute = audioRecvRemoteMute;
  }

  public EndpointsInner audioRecvCodec(String audioRecvCodec) {
    this.audioRecvCodec = audioRecvCodec;
    return this;
  }

   /**
   * Get audioRecvCodec
   * @return audioRecvCodec
  **/
  @ApiModelProperty(value = "")
  public String getAudioRecvCodec() {
    return audioRecvCodec;
  }

  public void setAudioRecvCodec(String audioRecvCodec) {
    this.audioRecvCodec = audioRecvCodec;
  }

  public EndpointsInner audioSendCodec(String audioSendCodec) {
    this.audioSendCodec = audioSendCodec;
    return this;
  }

   /**
   * Get audioSendCodec
   * @return audioSendCodec
  **/
  @ApiModelProperty(value = "")
  public String getAudioSendCodec() {
    return audioSendCodec;
  }

  public void setAudioSendCodec(String audioSendCodec) {
    this.audioSendCodec = audioSendCodec;
  }

  public EndpointsInner videoRecvCodec(String videoRecvCodec) {
    this.videoRecvCodec = videoRecvCodec;
    return this;
  }

   /**
   * Get videoRecvCodec
   * @return videoRecvCodec
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecvCodec() {
    return videoRecvCodec;
  }

  public void setVideoRecvCodec(String videoRecvCodec) {
    this.videoRecvCodec = videoRecvCodec;
  }

  public EndpointsInner videoRecvHeight(String videoRecvHeight) {
    this.videoRecvHeight = videoRecvHeight;
    return this;
  }

   /**
   * Get videoRecvHeight
   * @return videoRecvHeight
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecvHeight() {
    return videoRecvHeight;
  }

  public void setVideoRecvHeight(String videoRecvHeight) {
    this.videoRecvHeight = videoRecvHeight;
  }

  public EndpointsInner videoRecvWidth(String videoRecvWidth) {
    this.videoRecvWidth = videoRecvWidth;
    return this;
  }

   /**
   * Get videoRecvWidth
   * @return videoRecvWidth
  **/
  @ApiModelProperty(value = "")
  public String getVideoRecvWidth() {
    return videoRecvWidth;
  }

  public void setVideoRecvWidth(String videoRecvWidth) {
    this.videoRecvWidth = videoRecvWidth;
  }

  public EndpointsInner videoSendCodec(String videoSendCodec) {
    this.videoSendCodec = videoSendCodec;
    return this;
  }

   /**
   * Get videoSendCodec
   * @return videoSendCodec
  **/
  @ApiModelProperty(value = "")
  public String getVideoSendCodec() {
    return videoSendCodec;
  }

  public void setVideoSendCodec(String videoSendCodec) {
    this.videoSendCodec = videoSendCodec;
  }

  public EndpointsInner videoSendHeight(String videoSendHeight) {
    this.videoSendHeight = videoSendHeight;
    return this;
  }

   /**
   * Get videoSendHeight
   * @return videoSendHeight
  **/
  @ApiModelProperty(value = "")
  public String getVideoSendHeight() {
    return videoSendHeight;
  }

  public void setVideoSendHeight(String videoSendHeight) {
    this.videoSendHeight = videoSendHeight;
  }

  public EndpointsInner videoSendWidth(String videoSendWidth) {
    this.videoSendWidth = videoSendWidth;
    return this;
  }

   /**
   * Get videoSendWidth
   * @return videoSendWidth
  **/
  @ApiModelProperty(value = "")
  public String getVideoSendWidth() {
    return videoSendWidth;
  }

  public void setVideoSendWidth(String videoSendWidth) {
    this.videoSendWidth = videoSendWidth;
  }

  public EndpointsInner visibility(String visibility) {
    this.visibility = visibility;
    return this;
  }

   /**
   * Get visibility
   * @return visibility
  **/
  @ApiModelProperty(value = "")
  public String getVisibility() {
    return visibility;
  }

  public void setVisibility(String visibility) {
    this.visibility = visibility;
  }

  public EndpointsInner chatEndpointGuid(String chatEndpointGuid) {
    this.chatEndpointGuid = chatEndpointGuid;
    return this;
  }

   /**
   * Get chatEndpointGuid
   * @return chatEndpointGuid
  **/
  @ApiModelProperty(value = "")
  public String getChatEndpointGuid() {
    return chatEndpointGuid;
  }

  public void setChatEndpointGuid(String chatEndpointGuid) {
    this.chatEndpointGuid = chatEndpointGuid;
  }

  public EndpointsInner endpointGuid(String endpointGuid) {
    this.endpointGuid = endpointGuid;
    return this;
  }

   /**
   * Get endpointGuid
   * @return endpointGuid
  **/
  @ApiModelProperty(value = "")
  public String getEndpointGuid() {
    return endpointGuid;
  }

  public void setEndpointGuid(String endpointGuid) {
    this.endpointGuid = endpointGuid;
  }

  public EndpointsInner rdCVersion(String rdCVersion) {
    this.rdCVersion = rdCVersion;
    return this;
  }

   /**
   * Get rdCVersion
   * @return rdCVersion
  **/
  @ApiModelProperty(value = "")
  public String getRdCVersion() {
    return rdCVersion;
  }

  public void setRdCVersion(String rdCVersion) {
    this.rdCVersion = rdCVersion;
  }

  public EndpointsInner rdCControllerCapable(String rdCControllerCapable) {
    this.rdCControllerCapable = rdCControllerCapable;
    return this;
  }

   /**
   * Get rdCControllerCapable
   * @return rdCControllerCapable
  **/
  @ApiModelProperty(value = "")
  public String getRdCControllerCapable() {
    return rdCControllerCapable;
  }

  public void setRdCControllerCapable(String rdCControllerCapable) {
    this.rdCControllerCapable = rdCControllerCapable;
  }

  public EndpointsInner rdCControlleeCapable(String rdCControlleeCapable) {
    this.rdCControlleeCapable = rdCControlleeCapable;
    return this;
  }

   /**
   * Get rdCControlleeCapable
   * @return rdCControlleeCapable
  **/
  @ApiModelProperty(value = "")
  public String getRdCControlleeCapable() {
    return rdCControlleeCapable;
  }

  public void setRdCControlleeCapable(String rdCControlleeCapable) {
    this.rdCControlleeCapable = rdCControlleeCapable;
  }

  public EndpointsInner connections(List<EndpointsInnerConnections> connections) {
    this.connections = connections;
    return this;
  }

  public EndpointsInner addConnectionsItem(EndpointsInnerConnections connectionsItem) {
    if (this.connections == null) {
      this.connections = new ArrayList<EndpointsInnerConnections>();
    }
    this.connections.add(connectionsItem);
    return this;
  }

   /**
   * Get connections
   * @return connections
  **/
  @ApiModelProperty(value = "")
  public List<EndpointsInnerConnections> getConnections() {
    return connections;
  }

  public void setConnections(List<EndpointsInnerConnections> connections) {
    this.connections = connections;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EndpointsInner endpointsInner = (EndpointsInner) o;
    return Objects.equals(this.meetingid, endpointsInner.meetingid) &&
        Objects.equals(this.name, endpointsInner.name) &&
        Objects.equals(this.callQuality, endpointsInner.callQuality) &&
        Objects.equals(this.leader, endpointsInner.leader) &&
        Objects.equals(this.callguid, endpointsInner.callguid) &&
        Objects.equals(this.endpoint, endpointsInner.endpoint) &&
        Objects.equals(this.talkDetected, endpointsInner.talkDetected) &&
        Objects.equals(this.secureCall, endpointsInner.secureCall) &&
        Objects.equals(this.layout, endpointsInner.layout) &&
        Objects.equals(this.subLayout, endpointsInner.subLayout) &&
        Objects.equals(this.videoRecv, endpointsInner.videoRecv) &&
        Objects.equals(this.videoRecvLocalMute, endpointsInner.videoRecvLocalMute) &&
        Objects.equals(this.videoRecvRemoteMute, endpointsInner.videoRecvRemoteMute) &&
        Objects.equals(this.audioRecv, endpointsInner.audioRecv) &&
        Objects.equals(this.audioRecvLocalMute, endpointsInner.audioRecvLocalMute) &&
        Objects.equals(this.audioRecvRemoteMute, endpointsInner.audioRecvRemoteMute) &&
        Objects.equals(this.audioRecvCodec, endpointsInner.audioRecvCodec) &&
        Objects.equals(this.audioSendCodec, endpointsInner.audioSendCodec) &&
        Objects.equals(this.videoRecvCodec, endpointsInner.videoRecvCodec) &&
        Objects.equals(this.videoRecvHeight, endpointsInner.videoRecvHeight) &&
        Objects.equals(this.videoRecvWidth, endpointsInner.videoRecvWidth) &&
        Objects.equals(this.videoSendCodec, endpointsInner.videoSendCodec) &&
        Objects.equals(this.videoSendHeight, endpointsInner.videoSendHeight) &&
        Objects.equals(this.videoSendWidth, endpointsInner.videoSendWidth) &&
        Objects.equals(this.visibility, endpointsInner.visibility) &&
        Objects.equals(this.chatEndpointGuid, endpointsInner.chatEndpointGuid) &&
        Objects.equals(this.endpointGuid, endpointsInner.endpointGuid) &&
        Objects.equals(this.rdCVersion, endpointsInner.rdCVersion) &&
        Objects.equals(this.rdCControllerCapable, endpointsInner.rdCControllerCapable) &&
        Objects.equals(this.rdCControlleeCapable, endpointsInner.rdCControlleeCapable) &&
        Objects.equals(this.connections, endpointsInner.connections);
  }

  @Override
  public int hashCode() {
    return Objects.hash(meetingid, name, callQuality, leader, callguid, endpoint, talkDetected, secureCall, layout, subLayout, videoRecv, videoRecvLocalMute, videoRecvRemoteMute, audioRecv, audioRecvLocalMute, audioRecvRemoteMute, audioRecvCodec, audioSendCodec, videoRecvCodec, videoRecvHeight, videoRecvWidth, videoSendCodec, videoSendHeight, videoSendWidth, visibility, chatEndpointGuid, endpointGuid, rdCVersion, rdCControllerCapable, rdCControlleeCapable, connections);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EndpointsInner {\n");
    
    sb.append("    meetingid: ").append(toIndentedString(meetingid)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    callQuality: ").append(toIndentedString(callQuality)).append("\n");
    sb.append("    leader: ").append(toIndentedString(leader)).append("\n");
    sb.append("    callguid: ").append(toIndentedString(callguid)).append("\n");
    sb.append("    endpoint: ").append(toIndentedString(endpoint)).append("\n");
    sb.append("    talkDetected: ").append(toIndentedString(talkDetected)).append("\n");
    sb.append("    secureCall: ").append(toIndentedString(secureCall)).append("\n");
    sb.append("    layout: ").append(toIndentedString(layout)).append("\n");
    sb.append("    subLayout: ").append(toIndentedString(subLayout)).append("\n");
    sb.append("    videoRecv: ").append(toIndentedString(videoRecv)).append("\n");
    sb.append("    videoRecvLocalMute: ").append(toIndentedString(videoRecvLocalMute)).append("\n");
    sb.append("    videoRecvRemoteMute: ").append(toIndentedString(videoRecvRemoteMute)).append("\n");
    sb.append("    audioRecv: ").append(toIndentedString(audioRecv)).append("\n");
    sb.append("    audioRecvLocalMute: ").append(toIndentedString(audioRecvLocalMute)).append("\n");
    sb.append("    audioRecvRemoteMute: ").append(toIndentedString(audioRecvRemoteMute)).append("\n");
    sb.append("    audioRecvCodec: ").append(toIndentedString(audioRecvCodec)).append("\n");
    sb.append("    audioSendCodec: ").append(toIndentedString(audioSendCodec)).append("\n");
    sb.append("    videoRecvCodec: ").append(toIndentedString(videoRecvCodec)).append("\n");
    sb.append("    videoRecvHeight: ").append(toIndentedString(videoRecvHeight)).append("\n");
    sb.append("    videoRecvWidth: ").append(toIndentedString(videoRecvWidth)).append("\n");
    sb.append("    videoSendCodec: ").append(toIndentedString(videoSendCodec)).append("\n");
    sb.append("    videoSendHeight: ").append(toIndentedString(videoSendHeight)).append("\n");
    sb.append("    videoSendWidth: ").append(toIndentedString(videoSendWidth)).append("\n");
    sb.append("    visibility: ").append(toIndentedString(visibility)).append("\n");
    sb.append("    chatEndpointGuid: ").append(toIndentedString(chatEndpointGuid)).append("\n");
    sb.append("    endpointGuid: ").append(toIndentedString(endpointGuid)).append("\n");
    sb.append("    rdCVersion: ").append(toIndentedString(rdCVersion)).append("\n");
    sb.append("    rdCControllerCapable: ").append(toIndentedString(rdCControllerCapable)).append("\n");
    sb.append("    rdCControlleeCapable: ").append(toIndentedString(rdCControlleeCapable)).append("\n");
    sb.append("    connections: ").append(toIndentedString(connections)).append("\n");
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

