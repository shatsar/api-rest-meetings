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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.BlueJeansOnVideoRestApi);
  }
}(this, function(expect, BlueJeansOnVideoRestApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('RecordingRecordingSessions', function() {
    it('should create an instance of RecordingRecordingSessions', function() {
      // uncomment below and update the code to test RecordingRecordingSessions
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be.a(BlueJeansOnVideoRestApi.RecordingRecordingSessions);
    });

    it('should have the property id (base name: "id")', function() {
      // uncomment below and update the code to test the property id
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property contentStatus (base name: "contentStatus")', function() {
      // uncomment below and update the code to test the property contentStatus
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property recordingType (base name: "recordingType")', function() {
      // uncomment below and update the code to test the property recordingType
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property contentId (base name: "contentId")', function() {
      // uncomment below and update the code to test the property contentId
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property thumbnailUrl (base name: "thumbnailUrl")', function() {
      // uncomment below and update the code to test the property thumbnailUrl
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property startTimeOffset (base name: "startTimeOffset")', function() {
      // uncomment below and update the code to test the property startTimeOffset
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property endTimeOffset (base name: "endTimeOffset")', function() {
      // uncomment below and update the code to test the property endTimeOffset
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property duration (base name: "duration")', function() {
      // uncomment below and update the code to test the property duration
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property startedBy (base name: "startedBy")', function() {
      // uncomment below and update the code to test the property startedBy
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

    it('should have the property stoppedBy (base name: "stoppedBy")', function() {
      // uncomment below and update the code to test the property stoppedBy
      //var instane = new BlueJeansOnVideoRestApi.RecordingRecordingSessions();
      //expect(instance).to.be();
    });

  });

}));
