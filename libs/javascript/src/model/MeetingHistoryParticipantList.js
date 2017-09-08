/**
 * BlueJeans onVideo REST API
 *  Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you should be able to quickly integrate **BlueJeans** video administration into your applications.   ## Getting Started Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact [BlueJeans Support](mailto:Support@BlueJeans.com) for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br /> ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. ## About onVideo Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. 
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
    if (!root.BlueJeansOnVideoRestApi) {
      root.BlueJeansOnVideoRestApi = {};
    }
    root.BlueJeansOnVideoRestApi.MeetingHistoryParticipantList = factory(root.BlueJeansOnVideoRestApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The MeetingHistoryParticipantList model module.
   * @module model/MeetingHistoryParticipantList
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>MeetingHistoryParticipantList</code>.
   * @alias module:model/MeetingHistoryParticipantList
   * @class
   */
  var exports = function() {
    var _this = this;













  };

  /**
   * Constructs a <code>MeetingHistoryParticipantList</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MeetingHistoryParticipantList} obj Optional instance to populate.
   * @return {module:model/MeetingHistoryParticipantList} The populated <code>MeetingHistoryParticipantList</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('endpointName')) {
        obj['endpointName'] = ApiClient.convertToType(data['endpointName'], 'String');
      }
      if (data.hasOwnProperty('joinTime')) {
        obj['joinTime'] = ApiClient.convertToType(data['joinTime'], 'Number');
      }
      if (data.hasOwnProperty('minutes')) {
        obj['minutes'] = ApiClient.convertToType(data['minutes'], 'Number');
      }
      if (data.hasOwnProperty('deviceType')) {
        obj['deviceType'] = ApiClient.convertToType(data['deviceType'], 'String');
      }
      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
      if (data.hasOwnProperty('remoteAddress')) {
        obj['remoteAddress'] = ApiClient.convertToType(data['remoteAddress'], 'String');
      }
      if (data.hasOwnProperty('isEncrypted')) {
        obj['isEncrypted'] = ApiClient.convertToType(data['isEncrypted'], 'Boolean');
      }
      if (data.hasOwnProperty('disconnectTime')) {
        obj['disconnectTime'] = ApiClient.convertToType(data['disconnectTime'], 'Number');
      }
      if (data.hasOwnProperty('isModerator')) {
        obj['isModerator'] = ApiClient.convertToType(data['isModerator'], 'Boolean');
      }
      if (data.hasOwnProperty('userId')) {
        obj['userId'] = ApiClient.convertToType(data['userId'], 'Number');
      }
      if (data.hasOwnProperty('tags')) {
        obj['tags'] = ApiClient.convertToType(data['tags'], 'String');
      }
      if (data.hasOwnProperty('participantGuid')) {
        obj['participantGuid'] = ApiClient.convertToType(data['participantGuid'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} endpointName
   */
  exports.prototype['endpointName'] = undefined;
  /**
   * @member {Number} joinTime
   */
  exports.prototype['joinTime'] = undefined;
  /**
   * @member {Number} minutes
   */
  exports.prototype['minutes'] = undefined;
  /**
   * @member {module:model/MeetingHistoryParticipantList.DeviceTypeEnum} deviceType
   */
  exports.prototype['deviceType'] = undefined;
  /**
   * @member {String} email
   */
  exports.prototype['email'] = undefined;
  /**
   * @member {String} remoteAddress
   */
  exports.prototype['remoteAddress'] = undefined;
  /**
   * @member {Boolean} isEncrypted
   */
  exports.prototype['isEncrypted'] = undefined;
  /**
   * @member {Number} disconnectTime
   */
  exports.prototype['disconnectTime'] = undefined;
  /**
   * @member {Boolean} isModerator
   */
  exports.prototype['isModerator'] = undefined;
  /**
   * @member {Number} userId
   */
  exports.prototype['userId'] = undefined;
  /**
   * @member {String} tags
   */
  exports.prototype['tags'] = undefined;
  /**
   * @member {String} participantGuid
   */
  exports.prototype['participantGuid'] = undefined;


  /**
   * Allowed values for the <code>deviceType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.DeviceTypeEnum = {
    /**
     * value: "Carmel"
     * @const
     */
    "Carmel": "Carmel",
    /**
     * value: "WebRTC"
     * @const
     */
    "WebRTC": "WebRTC"  };


  return exports;
}));


