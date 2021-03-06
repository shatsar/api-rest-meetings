/**
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansMeetingsRestApi) {
      root.BlueJeansMeetingsRestApi = {};
    }
    root.BlueJeansMeetingsRestApi.Endpoint = factory(root.BlueJeansMeetingsRestApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The Endpoint model module.
   * @module model/Endpoint
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Endpoint</code>.
   * @alias module:model/Endpoint
   * @class
   */
  var exports = function() {
    var _this = this;
















































































































  };

  /**
   * Constructs a <code>Endpoint</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Endpoint} obj Optional instance to populate.
   * @return {module:model/Endpoint} The populated <code>Endpoint</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('EcMode')) {
        obj['EcMode'] = ApiClient.convertToType(data['EcMode'], 'String');
      }
      if (data.hasOwnProperty('creationtime')) {
        obj['creationtime'] = ApiClient.convertToType(data['creationtime'], 'String');
      }
      if (data.hasOwnProperty('audio.remote.rtcpAddress')) {
        obj['audio.remote.rtcpAddress'] = ApiClient.convertToType(data['audio.remote.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('VideoSendCodec')) {
        obj['VideoSendCodec'] = ApiClient.convertToType(data['VideoSendCodec'], 'String');
      }
      if (data.hasOwnProperty('AudioPlayID')) {
        obj['AudioPlayID'] = ApiClient.convertToType(data['AudioPlayID'], 'String');
      }
      if (data.hasOwnProperty('CallQualityRecv')) {
        obj['CallQualityRecv'] = ApiClient.convertToType(data['CallQualityRecv'], 'String');
      }
      if (data.hasOwnProperty('SessionOut')) {
        obj['SessionOut'] = ApiClient.convertToType(data['SessionOut'], 'String');
      }
      if (data.hasOwnProperty('audio.local.address')) {
        obj['audio.local.address'] = ApiClient.convertToType(data['audio.local.address'], 'String');
      }
      if (data.hasOwnProperty('meetingid')) {
        obj['meetingid'] = ApiClient.convertToType(data['meetingid'], 'String');
      }
      if (data.hasOwnProperty('VideoSendWidth')) {
        obj['VideoSendWidth'] = ApiClient.convertToType(data['VideoSendWidth'], 'String');
      }
      if (data.hasOwnProperty('CallQualitySend')) {
        obj['CallQualitySend'] = ApiClient.convertToType(data['CallQualitySend'], 'String');
      }
      if (data.hasOwnProperty('mhaddress')) {
        obj['mhaddress'] = ApiClient.convertToType(data['mhaddress'], 'String');
      }
      if (data.hasOwnProperty('RDCControlleeCapable')) {
        obj['RDCControlleeCapable'] = ApiClient.convertToType(data['RDCControlleeCapable'], 'String');
      }
      if (data.hasOwnProperty('AudioCapName')) {
        obj['AudioCapName'] = ApiClient.convertToType(data['AudioCapName'], 'String');
      }
      if (data.hasOwnProperty('ProxyInfo')) {
        obj['ProxyInfo'] = ApiClient.convertToType(data['ProxyInfo'], 'String');
      }
      if (data.hasOwnProperty('AudioSendCodec')) {
        obj['AudioSendCodec'] = ApiClient.convertToType(data['AudioSendCodec'], 'String');
      }
      if (data.hasOwnProperty('vendor')) {
        obj['vendor'] = ApiClient.convertToType(data['vendor'], 'String');
      }
      if (data.hasOwnProperty('VideoRecvWidth')) {
        obj['VideoRecvWidth'] = ApiClient.convertToType(data['VideoRecvWidth'], 'String');
      }
      if (data.hasOwnProperty('conaddress')) {
        obj['conaddress'] = ApiClient.convertToType(data['conaddress'], 'String');
      }
      if (data.hasOwnProperty('TalkDetected')) {
        obj['TalkDetected'] = ApiClient.convertToType(data['TalkDetected'], 'String');
      }
      if (data.hasOwnProperty('SubLayout')) {
        obj['SubLayout'] = ApiClient.convertToType(data['SubLayout'], 'String');
      }
      if (data.hasOwnProperty('AudioRtcpRelay')) {
        obj['AudioRtcpRelay'] = ApiClient.convertToType(data['AudioRtcpRelay'], 'String');
      }
      if (data.hasOwnProperty('AudioRecvLocalMute')) {
        obj['AudioRecvLocalMute'] = ApiClient.convertToType(data['AudioRecvLocalMute'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('video.local.address')) {
        obj['video.local.address'] = ApiClient.convertToType(data['video.local.address'], 'String');
      }
      if (data.hasOwnProperty('audio.local.rtcpAddress')) {
        obj['audio.local.rtcpAddress'] = ApiClient.convertToType(data['audio.local.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('ContentRtpRelay')) {
        obj['ContentRtpRelay'] = ApiClient.convertToType(data['ContentRtpRelay'], 'String');
      }
      if (data.hasOwnProperty('content.local.rtcpAddress')) {
        obj['content.local.rtcpAddress'] = ApiClient.convertToType(data['content.local.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('RemoteConnectionCount')) {
        obj['RemoteConnectionCount'] = ApiClient.convertToType(data['RemoteConnectionCount'], 'String');
      }
      if (data.hasOwnProperty('callrate')) {
        obj['callrate'] = ApiClient.convertToType(data['callrate'], 'String');
      }
      if (data.hasOwnProperty('MixerGuid')) {
        obj['MixerGuid'] = ApiClient.convertToType(data['MixerGuid'], 'String');
      }
      if (data.hasOwnProperty('transport')) {
        obj['transport'] = ApiClient.convertToType(data['transport'], 'String');
      }
      if (data.hasOwnProperty('AudioCapSelectID')) {
        obj['AudioCapSelectID'] = ApiClient.convertToType(data['AudioCapSelectID'], 'String');
      }
      if (data.hasOwnProperty('CountryCode')) {
        obj['CountryCode'] = ApiClient.convertToType(data['CountryCode'], 'String');
      }
      if (data.hasOwnProperty('RDCControllerCapable')) {
        obj['RDCControllerCapable'] = ApiClient.convertToType(data['RDCControllerCapable'], 'String');
      }
      if (data.hasOwnProperty('pairedname')) {
        obj['pairedname'] = ApiClient.convertToType(data['pairedname'], 'String');
      }
      if (data.hasOwnProperty('VideoRtcpRelay')) {
        obj['VideoRtcpRelay'] = ApiClient.convertToType(data['VideoRtcpRelay'], 'String');
      }
      if (data.hasOwnProperty('EndpointCpuParams')) {
        obj['EndpointCpuParams'] = ApiClient.convertToType(data['EndpointCpuParams'], 'String');
      }
      if (data.hasOwnProperty('video.remote.address')) {
        obj['video.remote.address'] = ApiClient.convertToType(data['video.remote.address'], 'String');
      }
      if (data.hasOwnProperty('version')) {
        obj['version'] = ApiClient.convertToType(data['version'], 'String');
      }
      if (data.hasOwnProperty('ContentRecv')) {
        obj['ContentRecv'] = ApiClient.convertToType(data['ContentRecv'], 'String');
      }
      if (data.hasOwnProperty('localName')) {
        obj['localName'] = ApiClient.convertToType(data['localName'], 'String');
      }
      if (data.hasOwnProperty('BJNUserId')) {
        obj['BJNUserId'] = ApiClient.convertToType(data['BJNUserId'], 'String');
      }
      if (data.hasOwnProperty('content.remote.address')) {
        obj['content.remote.address'] = ApiClient.convertToType(data['content.remote.address'], 'String');
      }
      if (data.hasOwnProperty('AudioSend')) {
        obj['AudioSend'] = ApiClient.convertToType(data['AudioSend'], 'String');
      }
      if (data.hasOwnProperty('ParticipantDTMFMenus')) {
        obj['ParticipantDTMFMenus'] = ApiClient.convertToType(data['ParticipantDTMFMenus'], 'String');
      }
      if (data.hasOwnProperty('VideoRtcpTranspor')) {
        obj['VideoRtcpTranspor'] = ApiClient.convertToType(data['VideoRtcpTranspor'], 'String');
      }
      if (data.hasOwnProperty('AudioRtcpTransport')) {
        obj['AudioRtcpTransport'] = ApiClient.convertToType(data['AudioRtcpTransport'], 'String');
      }
      if (data.hasOwnProperty('RelayNodeId')) {
        obj['RelayNodeId'] = ApiClient.convertToType(data['RelayNodeId'], 'String');
      }
      if (data.hasOwnProperty('content.remote.rtcpAddress')) {
        obj['content.remote.rtcpAddress'] = ApiClient.convertToType(data['content.remote.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('AudioRtpRelay')) {
        obj['AudioRtpRelay'] = ApiClient.convertToType(data['AudioRtpRelay'], 'String');
      }
      if (data.hasOwnProperty('VideoRtpTransport')) {
        obj['VideoRtpTransport'] = ApiClient.convertToType(data['VideoRtpTransport'], 'String');
      }
      if (data.hasOwnProperty('ContentRecvLocalMute')) {
        obj['ContentRecvLocalMute'] = ApiClient.convertToType(data['ContentRecvLocalMute'], 'String');
      }
      if (data.hasOwnProperty('Layout')) {
        obj['Layout'] = ApiClient.convertToType(data['Layout'], 'String');
      }
      if (data.hasOwnProperty('ContentSend')) {
        obj['ContentSend'] = ApiClient.convertToType(data['ContentSend'], 'String');
      }
      if (data.hasOwnProperty('remoteaddress')) {
        obj['remoteaddress'] = ApiClient.convertToType(data['remoteaddress'], 'String');
      }
      if (data.hasOwnProperty('MeetingGuid')) {
        obj['MeetingGuid'] = ApiClient.convertToType(data['MeetingGuid'], 'String');
      }
      if (data.hasOwnProperty('connecttime')) {
        obj['connecttime'] = ApiClient.convertToType(data['connecttime'], 'String');
      }
      if (data.hasOwnProperty('localaddress')) {
        obj['localaddress'] = ApiClient.convertToType(data['localaddress'], 'String');
      }
      if (data.hasOwnProperty('audio.remote.address')) {
        obj['audio.remote.address'] = ApiClient.convertToType(data['audio.remote.address'], 'String');
      }
      if (data.hasOwnProperty('BondedAudioGuid')) {
        obj['BondedAudioGuid'] = ApiClient.convertToType(data['BondedAudioGuid'], 'String');
      }
      if (data.hasOwnProperty('AudioRecvRemoteMute')) {
        obj['AudioRecvRemoteMute'] = ApiClient.convertToType(data['AudioRecvRemoteMute'], 'String');
      }
      if (data.hasOwnProperty('SessionOutRelay')) {
        obj['SessionOutRelay'] = ApiClient.convertToType(data['SessionOutRelay'], 'String');
      }
      if (data.hasOwnProperty('Leader')) {
        obj['Leader'] = ApiClient.convertToType(data['Leader'], 'String');
      }
      if (data.hasOwnProperty('content.local.address')) {
        obj['content.local.address'] = ApiClient.convertToType(data['content.local.address'], 'String');
      }
      if (data.hasOwnProperty('MovieCapable')) {
        obj['MovieCapable'] = ApiClient.convertToType(data['MovieCapable'], 'String');
      }
      if (data.hasOwnProperty('VideoRecvLocalMute')) {
        obj['VideoRecvLocalMute'] = ApiClient.convertToType(data['VideoRecvLocalMute'], 'String');
      }
      if (data.hasOwnProperty('ContentRtpTransport')) {
        obj['ContentRtpTransport'] = ApiClient.convertToType(data['ContentRtpTransport'], 'String');
      }
      if (data.hasOwnProperty('RDCVersion')) {
        obj['RDCVersion'] = ApiClient.convertToType(data['RDCVersion'], 'String');
      }
      if (data.hasOwnProperty('AudioRecv')) {
        obj['AudioRecv'] = ApiClient.convertToType(data['AudioRecv'], 'String');
      }
      if (data.hasOwnProperty('ContentRelayServer')) {
        obj['ContentRelayServer'] = ApiClient.convertToType(data['ContentRelayServer'], 'String');
      }
      if (data.hasOwnProperty('VideoRecv')) {
        obj['VideoRecv'] = ApiClient.convertToType(data['VideoRecv'], 'String');
      }
      if (data.hasOwnProperty('visibility')) {
        obj['visibility'] = ApiClient.convertToType(data['visibility'], 'String');
      }
      if (data.hasOwnProperty('sessionid')) {
        obj['sessionid'] = ApiClient.convertToType(data['sessionid'], 'String');
      }
      if (data.hasOwnProperty('ContentRtcpRelay')) {
        obj['ContentRtcpRelay'] = ApiClient.convertToType(data['ContentRtcpRelay'], 'String');
      }
      if (data.hasOwnProperty('locales')) {
        obj['locales'] = ApiClient.convertToType(data['locales'], 'String');
      }
      if (data.hasOwnProperty('medaddress')) {
        obj['medaddress'] = ApiClient.convertToType(data['medaddress'], 'String');
      }
      if (data.hasOwnProperty('HtmlLayoutGuid')) {
        obj['HtmlLayoutGuid'] = ApiClient.convertToType(data['HtmlLayoutGuid'], 'String');
      }
      if (data.hasOwnProperty('endpoint')) {
        obj['endpoint'] = ApiClient.convertToType(data['endpoint'], 'String');
      }
      if (data.hasOwnProperty('VideoDrop')) {
        obj['VideoDrop'] = ApiClient.convertToType(data['VideoDrop'], 'String');
      }
      if (data.hasOwnProperty('ContentRtcpTransport')) {
        obj['ContentRtcpTransport'] = ApiClient.convertToType(data['ContentRtcpTransport'], 'String');
      }
      if (data.hasOwnProperty('video.remote.rtcpAddress')) {
        obj['video.remote.rtcpAddress'] = ApiClient.convertToType(data['video.remote.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('VideoRtpRelay')) {
        obj['VideoRtpRelay'] = ApiClient.convertToType(data['VideoRtpRelay'], 'String');
      }
      if (data.hasOwnProperty('mixaddress')) {
        obj['mixaddress'] = ApiClient.convertToType(data['mixaddress'], 'String');
      }
      if (data.hasOwnProperty('SIPHTTPProxyTransport')) {
        obj['SIPHTTPProxyTransport'] = ApiClient.convertToType(data['SIPHTTPProxyTransport'], 'String');
      }
      if (data.hasOwnProperty('VideoRecvCodec')) {
        obj['VideoRecvCodec'] = ApiClient.convertToType(data['VideoRecvCodec'], 'String');
      }
      if (data.hasOwnProperty('AudioRecvCodec')) {
        obj['AudioRecvCodec'] = ApiClient.convertToType(data['AudioRecvCodec'], 'String');
      }
      if (data.hasOwnProperty('SessionIn')) {
        obj['SessionIn'] = ApiClient.convertToType(data['SessionIn'], 'String');
      }
      if (data.hasOwnProperty('BondedVideoGuid')) {
        obj['BondedVideoGuid'] = ApiClient.convertToType(data['BondedVideoGuid'], 'String');
      }
      if (data.hasOwnProperty('CallQuality')) {
        obj['CallQuality'] = ApiClient.convertToType(data['CallQuality'], 'String');
      }
      if (data.hasOwnProperty('meetingjointime')) {
        obj['meetingjointime'] = ApiClient.convertToType(data['meetingjointime'], 'String');
      }
      if (data.hasOwnProperty('SessionInRelay')) {
        obj['SessionInRelay'] = ApiClient.convertToType(data['SessionInRelay'], 'String');
      }
      if (data.hasOwnProperty('pairedremoteaddress')) {
        obj['pairedremoteaddress'] = ApiClient.convertToType(data['pairedremoteaddress'], 'String');
      }
      if (data.hasOwnProperty('VideoSendHeight')) {
        obj['VideoSendHeight'] = ApiClient.convertToType(data['VideoSendHeight'], 'String');
      }
      if (data.hasOwnProperty('VideoRecvHeight')) {
        obj['VideoRecvHeight'] = ApiClient.convertToType(data['VideoRecvHeight'], 'String');
      }
      if (data.hasOwnProperty('SecureCall')) {
        obj['SecureCall'] = ApiClient.convertToType(data['SecureCall'], 'String');
      }
      if (data.hasOwnProperty('video.local.rtcpAddress')) {
        obj['video.local.rtcpAddress'] = ApiClient.convertToType(data['video.local.rtcpAddress'], 'String');
      }
      if (data.hasOwnProperty('AudioPlayName')) {
        obj['AudioPlayName'] = ApiClient.convertToType(data['AudioPlayName'], 'String');
      }
      if (data.hasOwnProperty('VideoCapID')) {
        obj['VideoCapID'] = ApiClient.convertToType(data['VideoCapID'], 'String');
      }
      if (data.hasOwnProperty('AudioRtpTransport')) {
        obj['AudioRtpTransport'] = ApiClient.convertToType(data['AudioRtpTransport'], 'String');
      }
      if (data.hasOwnProperty('MeetingInfoMode')) {
        obj['MeetingInfoMode'] = ApiClient.convertToType(data['MeetingInfoMode'], 'String');
      }
      if (data.hasOwnProperty('callhostname')) {
        obj['callhostname'] = ApiClient.convertToType(data['callhostname'], 'String');
      }
      if (data.hasOwnProperty('callguid')) {
        obj['callguid'] = ApiClient.convertToType(data['callguid'], 'String');
      }
      if (data.hasOwnProperty('AudioCapID')) {
        obj['AudioCapID'] = ApiClient.convertToType(data['AudioCapID'], 'String');
      }
      if (data.hasOwnProperty('VideoSend')) {
        obj['VideoSend'] = ApiClient.convertToType(data['VideoSend'], 'String');
      }
      if (data.hasOwnProperty('ContentRecvCodec')) {
        obj['ContentRecvCodec'] = ApiClient.convertToType(data['ContentRecvCodec'], 'String');
      }
      if (data.hasOwnProperty('SessionRelay')) {
        obj['SessionRelay'] = ApiClient.convertToType(data['SessionRelay'], 'String');
      }
      if (data.hasOwnProperty('VideoRecvRemoteMute')) {
        obj['VideoRecvRemoteMute'] = ApiClient.convertToType(data['VideoRecvRemoteMute'], 'String');
      }
      if (data.hasOwnProperty('Id')) {
        obj['Id'] = ApiClient.convertToType(data['Id'], 'String');
      }
      if (data.hasOwnProperty('BondedVideoName')) {
        obj['BondedVideoName'] = ApiClient.convertToType(data['BondedVideoName'], 'String');
      }
      if (data.hasOwnProperty('isInRoster')) {
        obj['isInRoster'] = ApiClient.convertToType(data['isInRoster'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {String} EcMode
   */
  exports.prototype['EcMode'] = undefined;
  /**
   * @member {String} creationtime
   */
  exports.prototype['creationtime'] = undefined;
  /**
   * @member {String} audio.remote.rtcpAddress
   */
  exports.prototype['audio.remote.rtcpAddress'] = undefined;
  /**
   * @member {String} VideoSendCodec
   */
  exports.prototype['VideoSendCodec'] = undefined;
  /**
   * @member {String} AudioPlayID
   */
  exports.prototype['AudioPlayID'] = undefined;
  /**
   * @member {String} CallQualityRecv
   */
  exports.prototype['CallQualityRecv'] = undefined;
  /**
   * @member {String} SessionOut
   */
  exports.prototype['SessionOut'] = undefined;
  /**
   * @member {String} audio.local.address
   */
  exports.prototype['audio.local.address'] = undefined;
  /**
   * @member {String} meetingid
   */
  exports.prototype['meetingid'] = undefined;
  /**
   * @member {String} VideoSendWidth
   */
  exports.prototype['VideoSendWidth'] = undefined;
  /**
   * @member {String} CallQualitySend
   */
  exports.prototype['CallQualitySend'] = undefined;
  /**
   * @member {String} mhaddress
   */
  exports.prototype['mhaddress'] = undefined;
  /**
   * @member {String} RDCControlleeCapable
   */
  exports.prototype['RDCControlleeCapable'] = undefined;
  /**
   * @member {String} AudioCapName
   */
  exports.prototype['AudioCapName'] = undefined;
  /**
   * @member {String} ProxyInfo
   */
  exports.prototype['ProxyInfo'] = undefined;
  /**
   * @member {String} AudioSendCodec
   */
  exports.prototype['AudioSendCodec'] = undefined;
  /**
   * @member {String} vendor
   */
  exports.prototype['vendor'] = undefined;
  /**
   * @member {String} VideoRecvWidth
   */
  exports.prototype['VideoRecvWidth'] = undefined;
  /**
   * @member {String} conaddress
   */
  exports.prototype['conaddress'] = undefined;
  /**
   * @member {String} TalkDetected
   */
  exports.prototype['TalkDetected'] = undefined;
  /**
   * @member {String} SubLayout
   */
  exports.prototype['SubLayout'] = undefined;
  /**
   * @member {String} AudioRtcpRelay
   */
  exports.prototype['AudioRtcpRelay'] = undefined;
  /**
   * @member {String} AudioRecvLocalMute
   */
  exports.prototype['AudioRecvLocalMute'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} video.local.address
   */
  exports.prototype['video.local.address'] = undefined;
  /**
   * @member {String} audio.local.rtcpAddress
   */
  exports.prototype['audio.local.rtcpAddress'] = undefined;
  /**
   * @member {String} ContentRtpRelay
   */
  exports.prototype['ContentRtpRelay'] = undefined;
  /**
   * @member {String} content.local.rtcpAddress
   */
  exports.prototype['content.local.rtcpAddress'] = undefined;
  /**
   * @member {String} RemoteConnectionCount
   */
  exports.prototype['RemoteConnectionCount'] = undefined;
  /**
   * @member {String} callrate
   */
  exports.prototype['callrate'] = undefined;
  /**
   * @member {String} MixerGuid
   */
  exports.prototype['MixerGuid'] = undefined;
  /**
   * @member {String} transport
   */
  exports.prototype['transport'] = undefined;
  /**
   * @member {String} AudioCapSelectID
   */
  exports.prototype['AudioCapSelectID'] = undefined;
  /**
   * @member {String} CountryCode
   */
  exports.prototype['CountryCode'] = undefined;
  /**
   * @member {String} RDCControllerCapable
   */
  exports.prototype['RDCControllerCapable'] = undefined;
  /**
   * @member {String} pairedname
   */
  exports.prototype['pairedname'] = undefined;
  /**
   * @member {String} VideoRtcpRelay
   */
  exports.prototype['VideoRtcpRelay'] = undefined;
  /**
   * @member {String} EndpointCpuParams
   */
  exports.prototype['EndpointCpuParams'] = undefined;
  /**
   * @member {String} video.remote.address
   */
  exports.prototype['video.remote.address'] = undefined;
  /**
   * @member {String} version
   */
  exports.prototype['version'] = undefined;
  /**
   * @member {String} ContentRecv
   */
  exports.prototype['ContentRecv'] = undefined;
  /**
   * @member {String} localName
   */
  exports.prototype['localName'] = undefined;
  /**
   * @member {String} BJNUserId
   */
  exports.prototype['BJNUserId'] = undefined;
  /**
   * @member {String} content.remote.address
   */
  exports.prototype['content.remote.address'] = undefined;
  /**
   * @member {String} AudioSend
   */
  exports.prototype['AudioSend'] = undefined;
  /**
   * @member {String} ParticipantDTMFMenus
   */
  exports.prototype['ParticipantDTMFMenus'] = undefined;
  /**
   * @member {String} VideoRtcpTranspor
   */
  exports.prototype['VideoRtcpTranspor'] = undefined;
  /**
   * @member {String} AudioRtcpTransport
   */
  exports.prototype['AudioRtcpTransport'] = undefined;
  /**
   * @member {String} RelayNodeId
   */
  exports.prototype['RelayNodeId'] = undefined;
  /**
   * @member {String} content.remote.rtcpAddress
   */
  exports.prototype['content.remote.rtcpAddress'] = undefined;
  /**
   * @member {String} AudioRtpRelay
   */
  exports.prototype['AudioRtpRelay'] = undefined;
  /**
   * @member {String} VideoRtpTransport
   */
  exports.prototype['VideoRtpTransport'] = undefined;
  /**
   * @member {String} ContentRecvLocalMute
   */
  exports.prototype['ContentRecvLocalMute'] = undefined;
  /**
   * @member {String} Layout
   */
  exports.prototype['Layout'] = undefined;
  /**
   * @member {String} ContentSend
   */
  exports.prototype['ContentSend'] = undefined;
  /**
   * @member {String} remoteaddress
   */
  exports.prototype['remoteaddress'] = undefined;
  /**
   * @member {String} MeetingGuid
   */
  exports.prototype['MeetingGuid'] = undefined;
  /**
   * @member {String} connecttime
   */
  exports.prototype['connecttime'] = undefined;
  /**
   * @member {String} localaddress
   */
  exports.prototype['localaddress'] = undefined;
  /**
   * @member {String} audio.remote.address
   */
  exports.prototype['audio.remote.address'] = undefined;
  /**
   * @member {String} BondedAudioGuid
   */
  exports.prototype['BondedAudioGuid'] = undefined;
  /**
   * @member {String} AudioRecvRemoteMute
   */
  exports.prototype['AudioRecvRemoteMute'] = undefined;
  /**
   * @member {String} SessionOutRelay
   */
  exports.prototype['SessionOutRelay'] = undefined;
  /**
   * @member {String} Leader
   */
  exports.prototype['Leader'] = undefined;
  /**
   * @member {String} content.local.address
   */
  exports.prototype['content.local.address'] = undefined;
  /**
   * @member {String} MovieCapable
   */
  exports.prototype['MovieCapable'] = undefined;
  /**
   * @member {String} VideoRecvLocalMute
   */
  exports.prototype['VideoRecvLocalMute'] = undefined;
  /**
   * @member {String} ContentRtpTransport
   */
  exports.prototype['ContentRtpTransport'] = undefined;
  /**
   * @member {String} RDCVersion
   */
  exports.prototype['RDCVersion'] = undefined;
  /**
   * @member {String} AudioRecv
   */
  exports.prototype['AudioRecv'] = undefined;
  /**
   * @member {String} ContentRelayServer
   */
  exports.prototype['ContentRelayServer'] = undefined;
  /**
   * @member {String} VideoRecv
   */
  exports.prototype['VideoRecv'] = undefined;
  /**
   * @member {String} visibility
   */
  exports.prototype['visibility'] = undefined;
  /**
   * @member {String} sessionid
   */
  exports.prototype['sessionid'] = undefined;
  /**
   * @member {String} ContentRtcpRelay
   */
  exports.prototype['ContentRtcpRelay'] = undefined;
  /**
   * @member {String} locales
   */
  exports.prototype['locales'] = undefined;
  /**
   * @member {String} medaddress
   */
  exports.prototype['medaddress'] = undefined;
  /**
   * @member {String} HtmlLayoutGuid
   */
  exports.prototype['HtmlLayoutGuid'] = undefined;
  /**
   * @member {String} endpoint
   */
  exports.prototype['endpoint'] = undefined;
  /**
   * @member {String} VideoDrop
   */
  exports.prototype['VideoDrop'] = undefined;
  /**
   * @member {String} ContentRtcpTransport
   */
  exports.prototype['ContentRtcpTransport'] = undefined;
  /**
   * @member {String} video.remote.rtcpAddress
   */
  exports.prototype['video.remote.rtcpAddress'] = undefined;
  /**
   * @member {String} VideoRtpRelay
   */
  exports.prototype['VideoRtpRelay'] = undefined;
  /**
   * @member {String} mixaddress
   */
  exports.prototype['mixaddress'] = undefined;
  /**
   * @member {String} SIPHTTPProxyTransport
   */
  exports.prototype['SIPHTTPProxyTransport'] = undefined;
  /**
   * @member {String} VideoRecvCodec
   */
  exports.prototype['VideoRecvCodec'] = undefined;
  /**
   * @member {String} AudioRecvCodec
   */
  exports.prototype['AudioRecvCodec'] = undefined;
  /**
   * @member {String} SessionIn
   */
  exports.prototype['SessionIn'] = undefined;
  /**
   * @member {String} BondedVideoGuid
   */
  exports.prototype['BondedVideoGuid'] = undefined;
  /**
   * @member {String} CallQuality
   */
  exports.prototype['CallQuality'] = undefined;
  /**
   * @member {String} meetingjointime
   */
  exports.prototype['meetingjointime'] = undefined;
  /**
   * @member {String} SessionInRelay
   */
  exports.prototype['SessionInRelay'] = undefined;
  /**
   * @member {String} pairedremoteaddress
   */
  exports.prototype['pairedremoteaddress'] = undefined;
  /**
   * @member {String} VideoSendHeight
   */
  exports.prototype['VideoSendHeight'] = undefined;
  /**
   * @member {String} VideoRecvHeight
   */
  exports.prototype['VideoRecvHeight'] = undefined;
  /**
   * @member {String} SecureCall
   */
  exports.prototype['SecureCall'] = undefined;
  /**
   * @member {String} video.local.rtcpAddress
   */
  exports.prototype['video.local.rtcpAddress'] = undefined;
  /**
   * @member {String} AudioPlayName
   */
  exports.prototype['AudioPlayName'] = undefined;
  /**
   * @member {String} VideoCapID
   */
  exports.prototype['VideoCapID'] = undefined;
  /**
   * @member {String} AudioRtpTransport
   */
  exports.prototype['AudioRtpTransport'] = undefined;
  /**
   * @member {String} MeetingInfoMode
   */
  exports.prototype['MeetingInfoMode'] = undefined;
  /**
   * @member {String} callhostname
   */
  exports.prototype['callhostname'] = undefined;
  /**
   * @member {String} callguid
   */
  exports.prototype['callguid'] = undefined;
  /**
   * @member {String} AudioCapID
   */
  exports.prototype['AudioCapID'] = undefined;
  /**
   * @member {String} VideoSend
   */
  exports.prototype['VideoSend'] = undefined;
  /**
   * @member {String} ContentRecvCodec
   */
  exports.prototype['ContentRecvCodec'] = undefined;
  /**
   * @member {String} SessionRelay
   */
  exports.prototype['SessionRelay'] = undefined;
  /**
   * @member {String} VideoRecvRemoteMute
   */
  exports.prototype['VideoRecvRemoteMute'] = undefined;
  /**
   * @member {String} Id
   */
  exports.prototype['Id'] = undefined;
  /**
   * @member {String} BondedVideoName
   */
  exports.prototype['BondedVideoName'] = undefined;
  /**
   * @member {Boolean} isInRoster
   */
  exports.prototype['isInRoster'] = undefined;



  return exports;
}));


