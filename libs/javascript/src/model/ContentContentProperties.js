/**
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/ContentContentPropertiesLevels'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContentContentPropertiesLevels'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansOnVideoRestApi) {
      root.BlueJeansOnVideoRestApi = {};
    }
    root.BlueJeansOnVideoRestApi.ContentContentProperties = factory(root.BlueJeansOnVideoRestApi.ApiClient, root.BlueJeansOnVideoRestApi.ContentContentPropertiesLevels);
  }
}(this, function(ApiClient, ContentContentPropertiesLevels) {
  'use strict';




  /**
   * The ContentContentProperties model module.
   * @module model/ContentContentProperties
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>ContentContentProperties</code>.
   * @alias module:model/ContentContentProperties
   * @class
   */
  var exports = function() {
    var _this = this;











  };

  /**
   * Constructs a <code>ContentContentProperties</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContentContentProperties} obj Optional instance to populate.
   * @return {module:model/ContentContentProperties} The populated <code>ContentContentProperties</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'Number');
      }
      if (data.hasOwnProperty('thumbnail')) {
        obj['thumbnail'] = ApiClient.convertToType(data['thumbnail'], 'String');
      }
      if (data.hasOwnProperty('thumbnailSprite')) {
        obj['thumbnailSprite'] = ApiClient.convertToType(data['thumbnailSprite'], 'String');
      }
      if (data.hasOwnProperty('hdsUrl')) {
        obj['hdsUrl'] = ApiClient.convertToType(data['hdsUrl'], 'String');
      }
      if (data.hasOwnProperty('thumbnailCount')) {
        obj['thumbnailCount'] = ApiClient.convertToType(data['thumbnailCount'], 'Number');
      }
      if (data.hasOwnProperty('thumbnailWidth')) {
        obj['thumbnailWidth'] = ApiClient.convertToType(data['thumbnailWidth'], 'Number');
      }
      if (data.hasOwnProperty('thumbnailHeight')) {
        obj['thumbnailHeight'] = ApiClient.convertToType(data['thumbnailHeight'], 'Number');
      }
      if (data.hasOwnProperty('thumbnailInterval')) {
        obj['thumbnailInterval'] = ApiClient.convertToType(data['thumbnailInterval'], 'Number');
      }
      if (data.hasOwnProperty('hlsUrl')) {
        obj['hlsUrl'] = ApiClient.convertToType(data['hlsUrl'], 'String');
      }
      if (data.hasOwnProperty('levels')) {
        obj['levels'] = ApiClient.convertToType(data['levels'], [ContentContentPropertiesLevels]);
      }
    }
    return obj;
  }

  /**
   * @member {Number} duration
   */
  exports.prototype['duration'] = undefined;
  /**
   * @member {String} thumbnail
   */
  exports.prototype['thumbnail'] = undefined;
  /**
   * @member {String} thumbnailSprite
   */
  exports.prototype['thumbnailSprite'] = undefined;
  /**
   * @member {String} hdsUrl
   */
  exports.prototype['hdsUrl'] = undefined;
  /**
   * @member {Number} thumbnailCount
   */
  exports.prototype['thumbnailCount'] = undefined;
  /**
   * @member {Number} thumbnailWidth
   */
  exports.prototype['thumbnailWidth'] = undefined;
  /**
   * @member {Number} thumbnailHeight
   */
  exports.prototype['thumbnailHeight'] = undefined;
  /**
   * @member {Number} thumbnailInterval
   */
  exports.prototype['thumbnailInterval'] = undefined;
  /**
   * @member {String} hlsUrl
   */
  exports.prototype['hlsUrl'] = undefined;
  /**
   * @member {Array.<module:model/ContentContentPropertiesLevels>} levels
   */
  exports.prototype['levels'] = undefined;



  return exports;
}));


