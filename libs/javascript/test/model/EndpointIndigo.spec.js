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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.BlueJeansMeetingsRestApi);
  }
}(this, function(expect, BlueJeansMeetingsRestApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new BlueJeansMeetingsRestApi.EndpointIndigo();
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

  describe('EndpointIndigo', function() {
    it('should create an instance of EndpointIndigo', function() {
      // uncomment below and update the code to test EndpointIndigo
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be.a(BlueJeansMeetingsRestApi.EndpointIndigo);
    });

    it('should have the property id (base name: "id")', function() {
      // uncomment below and update the code to test the property id
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property callguid (base name: "callguid")', function() {
      // uncomment below and update the code to test the property callguid
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property name (base name: "name")', function() {
      // uncomment below and update the code to test the property name
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property endpoint (base name: "endpoint")', function() {
      // uncomment below and update the code to test the property endpoint
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property vendor (base name: "vendor")', function() {
      // uncomment below and update the code to test the property vendor
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property version (base name: "version")', function() {
      // uncomment below and update the code to test the property version
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property uniqId (base name: "uniqId")', function() {
      // uncomment below and update the code to test the property uniqId
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property remoteAddress (base name: "remoteAddress")', function() {
      // uncomment below and update the code to test the property remoteAddress
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property leader (base name: "leader")', function() {
      // uncomment below and update the code to test the property leader
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property secureCall (base name: "secureCall")', function() {
      // uncomment below and update the code to test the property secureCall
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property natDetected (base name: "natDetected")', function() {
      // uncomment below and update the code to test the property natDetected
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property proxy (base name: "proxy")', function() {
      // uncomment below and update the code to test the property proxy
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property roiDistance (base name: "roiDistance")', function() {
      // uncomment below and update the code to test the property roiDistance
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property mpls (base name: "mpls")', function() {
      // uncomment below and update the code to test the property mpls
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property videoShare (base name: "videoShare")', function() {
      // uncomment below and update the code to test the property videoShare
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property recording (base name: "recording")', function() {
      // uncomment below and update the code to test the property recording
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property creationTime (base name: "creationTime")', function() {
      // uncomment below and update the code to test the property creationTime
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property meetingJoinTime (base name: "meetingJoinTime")', function() {
      // uncomment below and update the code to test the property meetingJoinTime
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property meetingLeaveTime (base name: "meetingLeaveTime")', function() {
      // uncomment below and update the code to test the property meetingLeaveTime
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property didNumber (base name: "didNumber")', function() {
      // uncomment below and update the code to test the property didNumber
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property location (base name: "location")', function() {
      // uncomment below and update the code to test the property location
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property summaryStats (base name: "summaryStats")', function() {
      // uncomment below and update the code to test the property summaryStats
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property endpointAttributes1 (base name: "endpointAttributes1")', function() {
      // uncomment below and update the code to test the property endpointAttributes1
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property traceroute (base name: "traceroute")', function() {
      // uncomment below and update the code to test the property traceroute
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

    it('should have the property mhtaskStopped (base name: "mhtaskStopped")', function() {
      // uncomment below and update the code to test the property mhtaskStopped
      //var instane = new BlueJeansMeetingsRestApi.EndpointIndigo();
      //expect(instance).to.be();
    });

  });

}));
