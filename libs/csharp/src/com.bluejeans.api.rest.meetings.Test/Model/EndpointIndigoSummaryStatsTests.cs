/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.bluejeans.api.rest.meetings.Api;
using com.bluejeans.api.rest.meetings.Model;
using com.bluejeans.api.rest.meetings.Client;
using System.Reflection;

namespace com.bluejeans.api.rest.meetings.Test
{
    /// <summary>
    ///  Class for testing EndpointIndigoSummaryStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EndpointIndigoSummaryStatsTests
    {
        // TODO uncomment below to declare an instance variable for EndpointIndigoSummaryStats
        //private EndpointIndigoSummaryStats instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EndpointIndigoSummaryStats
            //instance = new EndpointIndigoSummaryStats();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EndpointIndigoSummaryStats
        /// </summary>
        [Test]
        public void EndpointIndigoSummaryStatsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EndpointIndigoSummaryStats
            //Assert.IsInstanceOfType<EndpointIndigoSummaryStats> (instance, "variable 'instance' is a EndpointIndigoSummaryStats");
        }

        /// <summary>
        /// Test the property 'AudioRecvCodec'
        /// </summary>
        [Test]
        public void AudioRecvCodecTest()
        {
            // TODO unit test for the property 'AudioRecvCodec'
        }
        /// <summary>
        /// Test the property 'AudioSendCodec'
        /// </summary>
        [Test]
        public void AudioSendCodecTest()
        {
            // TODO unit test for the property 'AudioSendCodec'
        }
        /// <summary>
        /// Test the property 'ContentRecv'
        /// </summary>
        [Test]
        public void ContentRecvTest()
        {
            // TODO unit test for the property 'ContentRecv'
        }
        /// <summary>
        /// Test the property 'ContentSend'
        /// </summary>
        [Test]
        public void ContentSendTest()
        {
            // TODO unit test for the property 'ContentSend'
        }
        /// <summary>
        /// Test the property 'TalkDetected'
        /// </summary>
        [Test]
        public void TalkDetectedTest()
        {
            // TODO unit test for the property 'TalkDetected'
        }
        /// <summary>
        /// Test the property 'SessionRelay'
        /// </summary>
        [Test]
        public void SessionRelayTest()
        {
            // TODO unit test for the property 'SessionRelay'
        }
        /// <summary>
        /// Test the property 'SessionInRelay'
        /// </summary>
        [Test]
        public void SessionInRelayTest()
        {
            // TODO unit test for the property 'SessionInRelay'
        }
        /// <summary>
        /// Test the property 'SessionOutRelay'
        /// </summary>
        [Test]
        public void SessionOutRelayTest()
        {
            // TODO unit test for the property 'SessionOutRelay'
        }
        /// <summary>
        /// Test the property 'AudioRtpRelay'
        /// </summary>
        [Test]
        public void AudioRtpRelayTest()
        {
            // TODO unit test for the property 'AudioRtpRelay'
        }
        /// <summary>
        /// Test the property 'CallRate'
        /// </summary>
        [Test]
        public void CallRateTest()
        {
            // TODO unit test for the property 'CallRate'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentAI'
        /// </summary>
        [Test]
        public void CumulLossPercentAITest()
        {
            // TODO unit test for the property 'CumulLossPercentAI'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentAO'
        /// </summary>
        [Test]
        public void CumulLossPercentAOTest()
        {
            // TODO unit test for the property 'CumulLossPercentAO'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentVI'
        /// </summary>
        [Test]
        public void CumulLossPercentVITest()
        {
            // TODO unit test for the property 'CumulLossPercentVI'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentVO'
        /// </summary>
        [Test]
        public void CumulLossPercentVOTest()
        {
            // TODO unit test for the property 'CumulLossPercentVO'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentVIC'
        /// </summary>
        [Test]
        public void CumulLossPercentVICTest()
        {
            // TODO unit test for the property 'CumulLossPercentVIC'
        }
        /// <summary>
        /// Test the property 'CumulLossPercentVOC'
        /// </summary>
        [Test]
        public void CumulLossPercentVOCTest()
        {
            // TODO unit test for the property 'CumulLossPercentVOC'
        }
        /// <summary>
        /// Test the property 'CumulLossAI'
        /// </summary>
        [Test]
        public void CumulLossAITest()
        {
            // TODO unit test for the property 'CumulLossAI'
        }
        /// <summary>
        /// Test the property 'CumulLossAO'
        /// </summary>
        [Test]
        public void CumulLossAOTest()
        {
            // TODO unit test for the property 'CumulLossAO'
        }
        /// <summary>
        /// Test the property 'CumulLossVI'
        /// </summary>
        [Test]
        public void CumulLossVITest()
        {
            // TODO unit test for the property 'CumulLossVI'
        }
        /// <summary>
        /// Test the property 'CumulLossVO'
        /// </summary>
        [Test]
        public void CumulLossVOTest()
        {
            // TODO unit test for the property 'CumulLossVO'
        }
        /// <summary>
        /// Test the property 'CumulLossVIC'
        /// </summary>
        [Test]
        public void CumulLossVICTest()
        {
            // TODO unit test for the property 'CumulLossVIC'
        }
        /// <summary>
        /// Test the property 'CumulLossVOC'
        /// </summary>
        [Test]
        public void CumulLossVOCTest()
        {
            // TODO unit test for the property 'CumulLossVOC'
        }
        /// <summary>
        /// Test the property 'DiscontinuityCount'
        /// </summary>
        [Test]
        public void DiscontinuityCountTest()
        {
            // TODO unit test for the property 'DiscontinuityCount'
        }
        /// <summary>
        /// Test the property 'DroppedPacketsAI'
        /// </summary>
        [Test]
        public void DroppedPacketsAITest()
        {
            // TODO unit test for the property 'DroppedPacketsAI'
        }
        /// <summary>
        /// Test the property 'DroppedPacketsVI'
        /// </summary>
        [Test]
        public void DroppedPacketsVITest()
        {
            // TODO unit test for the property 'DroppedPacketsVI'
        }
        /// <summary>
        /// Test the property 'DroppedPacketsVIC'
        /// </summary>
        [Test]
        public void DroppedPacketsVICTest()
        {
            // TODO unit test for the property 'DroppedPacketsVIC'
        }
        /// <summary>
        /// Test the property 'MixUnderRunsAI'
        /// </summary>
        [Test]
        public void MixUnderRunsAITest()
        {
            // TODO unit test for the property 'MixUnderRunsAI'
        }
        /// <summary>
        /// Test the property 'NetworkAvgLossAI'
        /// </summary>
        [Test]
        public void NetworkAvgLossAITest()
        {
            // TODO unit test for the property 'NetworkAvgLossAI'
        }
        /// <summary>
        /// Test the property 'NetworkAvgLossAO'
        /// </summary>
        [Test]
        public void NetworkAvgLossAOTest()
        {
            // TODO unit test for the property 'NetworkAvgLossAO'
        }
        /// <summary>
        /// Test the property 'NetworkAvgLossVI'
        /// </summary>
        [Test]
        public void NetworkAvgLossVITest()
        {
            // TODO unit test for the property 'NetworkAvgLossVI'
        }
        /// <summary>
        /// Test the property 'NetworkAvgLossVO'
        /// </summary>
        [Test]
        public void NetworkAvgLossVOTest()
        {
            // TODO unit test for the property 'NetworkAvgLossVO'
        }
        /// <summary>
        /// Test the property 'NetworkCumulLossAI'
        /// </summary>
        [Test]
        public void NetworkCumulLossAITest()
        {
            // TODO unit test for the property 'NetworkCumulLossAI'
        }
        /// <summary>
        /// Test the property 'NetworkCumulLossAO'
        /// </summary>
        [Test]
        public void NetworkCumulLossAOTest()
        {
            // TODO unit test for the property 'NetworkCumulLossAO'
        }
        /// <summary>
        /// Test the property 'NetworkCumulLossVI'
        /// </summary>
        [Test]
        public void NetworkCumulLossVITest()
        {
            // TODO unit test for the property 'NetworkCumulLossVI'
        }
        /// <summary>
        /// Test the property 'NetworkCumulLossVO'
        /// </summary>
        [Test]
        public void NetworkCumulLossVOTest()
        {
            // TODO unit test for the property 'NetworkCumulLossVO'
        }
        /// <summary>
        /// Test the property 'NetworkLossAI'
        /// </summary>
        [Test]
        public void NetworkLossAITest()
        {
            // TODO unit test for the property 'NetworkLossAI'
        }
        /// <summary>
        /// Test the property 'NetworkLossAO'
        /// </summary>
        [Test]
        public void NetworkLossAOTest()
        {
            // TODO unit test for the property 'NetworkLossAO'
        }
        /// <summary>
        /// Test the property 'NetworkLossVI'
        /// </summary>
        [Test]
        public void NetworkLossVITest()
        {
            // TODO unit test for the property 'NetworkLossVI'
        }
        /// <summary>
        /// Test the property 'NetworkLossVO'
        /// </summary>
        [Test]
        public void NetworkLossVOTest()
        {
            // TODO unit test for the property 'NetworkLossVO'
        }
        /// <summary>
        /// Test the property 'CallQualityMin'
        /// </summary>
        [Test]
        public void CallQualityMinTest()
        {
            // TODO unit test for the property 'CallQualityMin'
        }
        /// <summary>
        /// Test the property 'CallQualityMax'
        /// </summary>
        [Test]
        public void CallQualityMaxTest()
        {
            // TODO unit test for the property 'CallQualityMax'
        }
        /// <summary>
        /// Test the property 'CallQualityAvg'
        /// </summary>
        [Test]
        public void CallQualityAvgTest()
        {
            // TODO unit test for the property 'CallQualityAvg'
        }
        /// <summary>
        /// Test the property 'FpsMinVI'
        /// </summary>
        [Test]
        public void FpsMinVITest()
        {
            // TODO unit test for the property 'FpsMinVI'
        }
        /// <summary>
        /// Test the property 'FpsMinVO'
        /// </summary>
        [Test]
        public void FpsMinVOTest()
        {
            // TODO unit test for the property 'FpsMinVO'
        }
        /// <summary>
        /// Test the property 'FpsMinVIC'
        /// </summary>
        [Test]
        public void FpsMinVICTest()
        {
            // TODO unit test for the property 'FpsMinVIC'
        }
        /// <summary>
        /// Test the property 'FpsMinVOC'
        /// </summary>
        [Test]
        public void FpsMinVOCTest()
        {
            // TODO unit test for the property 'FpsMinVOC'
        }
        /// <summary>
        /// Test the property 'FpsMaxVI'
        /// </summary>
        [Test]
        public void FpsMaxVITest()
        {
            // TODO unit test for the property 'FpsMaxVI'
        }
        /// <summary>
        /// Test the property 'FpsMaxVO'
        /// </summary>
        [Test]
        public void FpsMaxVOTest()
        {
            // TODO unit test for the property 'FpsMaxVO'
        }
        /// <summary>
        /// Test the property 'FpsMaxVIC'
        /// </summary>
        [Test]
        public void FpsMaxVICTest()
        {
            // TODO unit test for the property 'FpsMaxVIC'
        }
        /// <summary>
        /// Test the property 'FpsMaxVOC'
        /// </summary>
        [Test]
        public void FpsMaxVOCTest()
        {
            // TODO unit test for the property 'FpsMaxVOC'
        }
        /// <summary>
        /// Test the property 'FpsAvgVI'
        /// </summary>
        [Test]
        public void FpsAvgVITest()
        {
            // TODO unit test for the property 'FpsAvgVI'
        }
        /// <summary>
        /// Test the property 'FpsAvgVO'
        /// </summary>
        [Test]
        public void FpsAvgVOTest()
        {
            // TODO unit test for the property 'FpsAvgVO'
        }
        /// <summary>
        /// Test the property 'FpsAvgVIC'
        /// </summary>
        [Test]
        public void FpsAvgVICTest()
        {
            // TODO unit test for the property 'FpsAvgVIC'
        }
        /// <summary>
        /// Test the property 'FpsAvgVOC'
        /// </summary>
        [Test]
        public void FpsAvgVOCTest()
        {
            // TODO unit test for the property 'FpsAvgVOC'
        }
        /// <summary>
        /// Test the property 'BitrateMinAI'
        /// </summary>
        [Test]
        public void BitrateMinAITest()
        {
            // TODO unit test for the property 'BitrateMinAI'
        }
        /// <summary>
        /// Test the property 'BitrateMinAO'
        /// </summary>
        [Test]
        public void BitrateMinAOTest()
        {
            // TODO unit test for the property 'BitrateMinAO'
        }
        /// <summary>
        /// Test the property 'BitrateMinVI'
        /// </summary>
        [Test]
        public void BitrateMinVITest()
        {
            // TODO unit test for the property 'BitrateMinVI'
        }
        /// <summary>
        /// Test the property 'BitrateMinVO'
        /// </summary>
        [Test]
        public void BitrateMinVOTest()
        {
            // TODO unit test for the property 'BitrateMinVO'
        }
        /// <summary>
        /// Test the property 'BitrateMinVIC'
        /// </summary>
        [Test]
        public void BitrateMinVICTest()
        {
            // TODO unit test for the property 'BitrateMinVIC'
        }
        /// <summary>
        /// Test the property 'BitrateMinVOC'
        /// </summary>
        [Test]
        public void BitrateMinVOCTest()
        {
            // TODO unit test for the property 'BitrateMinVOC'
        }
        /// <summary>
        /// Test the property 'BitrateMaxAI'
        /// </summary>
        [Test]
        public void BitrateMaxAITest()
        {
            // TODO unit test for the property 'BitrateMaxAI'
        }
        /// <summary>
        /// Test the property 'BitrateMaxAO'
        /// </summary>
        [Test]
        public void BitrateMaxAOTest()
        {
            // TODO unit test for the property 'BitrateMaxAO'
        }
        /// <summary>
        /// Test the property 'BitrateMaxVI'
        /// </summary>
        [Test]
        public void BitrateMaxVITest()
        {
            // TODO unit test for the property 'BitrateMaxVI'
        }
        /// <summary>
        /// Test the property 'BitrateMaxVO'
        /// </summary>
        [Test]
        public void BitrateMaxVOTest()
        {
            // TODO unit test for the property 'BitrateMaxVO'
        }
        /// <summary>
        /// Test the property 'BitrateMaxVIC'
        /// </summary>
        [Test]
        public void BitrateMaxVICTest()
        {
            // TODO unit test for the property 'BitrateMaxVIC'
        }
        /// <summary>
        /// Test the property 'BitrateMaxVOC'
        /// </summary>
        [Test]
        public void BitrateMaxVOCTest()
        {
            // TODO unit test for the property 'BitrateMaxVOC'
        }
        /// <summary>
        /// Test the property 'BitrateAvgAI'
        /// </summary>
        [Test]
        public void BitrateAvgAITest()
        {
            // TODO unit test for the property 'BitrateAvgAI'
        }
        /// <summary>
        /// Test the property 'BitrateAvgAO'
        /// </summary>
        [Test]
        public void BitrateAvgAOTest()
        {
            // TODO unit test for the property 'BitrateAvgAO'
        }
        /// <summary>
        /// Test the property 'BitrateAvgVI'
        /// </summary>
        [Test]
        public void BitrateAvgVITest()
        {
            // TODO unit test for the property 'BitrateAvgVI'
        }
        /// <summary>
        /// Test the property 'BitrateAvgVO'
        /// </summary>
        [Test]
        public void BitrateAvgVOTest()
        {
            // TODO unit test for the property 'BitrateAvgVO'
        }
        /// <summary>
        /// Test the property 'BitrateAvgVIC'
        /// </summary>
        [Test]
        public void BitrateAvgVICTest()
        {
            // TODO unit test for the property 'BitrateAvgVIC'
        }
        /// <summary>
        /// Test the property 'BitrateAvgVOC'
        /// </summary>
        [Test]
        public void BitrateAvgVOCTest()
        {
            // TODO unit test for the property 'BitrateAvgVOC'
        }
        /// <summary>
        /// Test the property 'JitterMinAI'
        /// </summary>
        [Test]
        public void JitterMinAITest()
        {
            // TODO unit test for the property 'JitterMinAI'
        }
        /// <summary>
        /// Test the property 'JitterMinAO'
        /// </summary>
        [Test]
        public void JitterMinAOTest()
        {
            // TODO unit test for the property 'JitterMinAO'
        }
        /// <summary>
        /// Test the property 'JitterMinVI'
        /// </summary>
        [Test]
        public void JitterMinVITest()
        {
            // TODO unit test for the property 'JitterMinVI'
        }
        /// <summary>
        /// Test the property 'JitterMinVO'
        /// </summary>
        [Test]
        public void JitterMinVOTest()
        {
            // TODO unit test for the property 'JitterMinVO'
        }
        /// <summary>
        /// Test the property 'JitterMinVIC'
        /// </summary>
        [Test]
        public void JitterMinVICTest()
        {
            // TODO unit test for the property 'JitterMinVIC'
        }
        /// <summary>
        /// Test the property 'JitterMinVOC'
        /// </summary>
        [Test]
        public void JitterMinVOCTest()
        {
            // TODO unit test for the property 'JitterMinVOC'
        }
        /// <summary>
        /// Test the property 'JitterMaxAI'
        /// </summary>
        [Test]
        public void JitterMaxAITest()
        {
            // TODO unit test for the property 'JitterMaxAI'
        }
        /// <summary>
        /// Test the property 'JitterMaxAO'
        /// </summary>
        [Test]
        public void JitterMaxAOTest()
        {
            // TODO unit test for the property 'JitterMaxAO'
        }
        /// <summary>
        /// Test the property 'JitterMaxVI'
        /// </summary>
        [Test]
        public void JitterMaxVITest()
        {
            // TODO unit test for the property 'JitterMaxVI'
        }
        /// <summary>
        /// Test the property 'JitterMaxVO'
        /// </summary>
        [Test]
        public void JitterMaxVOTest()
        {
            // TODO unit test for the property 'JitterMaxVO'
        }
        /// <summary>
        /// Test the property 'JitterMaxVIC'
        /// </summary>
        [Test]
        public void JitterMaxVICTest()
        {
            // TODO unit test for the property 'JitterMaxVIC'
        }
        /// <summary>
        /// Test the property 'JitterMaxVOC'
        /// </summary>
        [Test]
        public void JitterMaxVOCTest()
        {
            // TODO unit test for the property 'JitterMaxVOC'
        }
        /// <summary>
        /// Test the property 'JitterAvgAI'
        /// </summary>
        [Test]
        public void JitterAvgAITest()
        {
            // TODO unit test for the property 'JitterAvgAI'
        }
        /// <summary>
        /// Test the property 'JitterAvgAO'
        /// </summary>
        [Test]
        public void JitterAvgAOTest()
        {
            // TODO unit test for the property 'JitterAvgAO'
        }
        /// <summary>
        /// Test the property 'JitterAvgVI'
        /// </summary>
        [Test]
        public void JitterAvgVITest()
        {
            // TODO unit test for the property 'JitterAvgVI'
        }
        /// <summary>
        /// Test the property 'JitterAvgVO'
        /// </summary>
        [Test]
        public void JitterAvgVOTest()
        {
            // TODO unit test for the property 'JitterAvgVO'
        }
        /// <summary>
        /// Test the property 'JitterAvgVIC'
        /// </summary>
        [Test]
        public void JitterAvgVICTest()
        {
            // TODO unit test for the property 'JitterAvgVIC'
        }
        /// <summary>
        /// Test the property 'JitterAvgVOC'
        /// </summary>
        [Test]
        public void JitterAvgVOCTest()
        {
            // TODO unit test for the property 'JitterAvgVOC'
        }
        /// <summary>
        /// Test the property 'MaxJitterMinAI'
        /// </summary>
        [Test]
        public void MaxJitterMinAITest()
        {
            // TODO unit test for the property 'MaxJitterMinAI'
        }
        /// <summary>
        /// Test the property 'MaxJitterMinVI'
        /// </summary>
        [Test]
        public void MaxJitterMinVITest()
        {
            // TODO unit test for the property 'MaxJitterMinVI'
        }
        /// <summary>
        /// Test the property 'MaxJitterMinVIC'
        /// </summary>
        [Test]
        public void MaxJitterMinVICTest()
        {
            // TODO unit test for the property 'MaxJitterMinVIC'
        }
        /// <summary>
        /// Test the property 'MaxJitterMaxAI'
        /// </summary>
        [Test]
        public void MaxJitterMaxAITest()
        {
            // TODO unit test for the property 'MaxJitterMaxAI'
        }
        /// <summary>
        /// Test the property 'MaxJitterMaxVI'
        /// </summary>
        [Test]
        public void MaxJitterMaxVITest()
        {
            // TODO unit test for the property 'MaxJitterMaxVI'
        }
        /// <summary>
        /// Test the property 'MaxJitterMaxVIC'
        /// </summary>
        [Test]
        public void MaxJitterMaxVICTest()
        {
            // TODO unit test for the property 'MaxJitterMaxVIC'
        }
        /// <summary>
        /// Test the property 'MaxJitterAvgAI'
        /// </summary>
        [Test]
        public void MaxJitterAvgAITest()
        {
            // TODO unit test for the property 'MaxJitterAvgAI'
        }
        /// <summary>
        /// Test the property 'MaxJitterAvgVI'
        /// </summary>
        [Test]
        public void MaxJitterAvgVITest()
        {
            // TODO unit test for the property 'MaxJitterAvgVI'
        }
        /// <summary>
        /// Test the property 'MaxJitterAvgVIC'
        /// </summary>
        [Test]
        public void MaxJitterAvgVICTest()
        {
            // TODO unit test for the property 'MaxJitterAvgVIC'
        }
        /// <summary>
        /// Test the property 'VideoRecvHeightMin'
        /// </summary>
        [Test]
        public void VideoRecvHeightMinTest()
        {
            // TODO unit test for the property 'VideoRecvHeightMin'
        }
        /// <summary>
        /// Test the property 'VideoRecvHeightMax'
        /// </summary>
        [Test]
        public void VideoRecvHeightMaxTest()
        {
            // TODO unit test for the property 'VideoRecvHeightMax'
        }
        /// <summary>
        /// Test the property 'VideoRecvWidthMin'
        /// </summary>
        [Test]
        public void VideoRecvWidthMinTest()
        {
            // TODO unit test for the property 'VideoRecvWidthMin'
        }
        /// <summary>
        /// Test the property 'VideoRecvWidthMax'
        /// </summary>
        [Test]
        public void VideoRecvWidthMaxTest()
        {
            // TODO unit test for the property 'VideoRecvWidthMax'
        }
        /// <summary>
        /// Test the property 'VideoSendHeightMin'
        /// </summary>
        [Test]
        public void VideoSendHeightMinTest()
        {
            // TODO unit test for the property 'VideoSendHeightMin'
        }
        /// <summary>
        /// Test the property 'VideoSendHeightMax'
        /// </summary>
        [Test]
        public void VideoSendHeightMaxTest()
        {
            // TODO unit test for the property 'VideoSendHeightMax'
        }
        /// <summary>
        /// Test the property 'VideoSendWidthMin'
        /// </summary>
        [Test]
        public void VideoSendWidthMinTest()
        {
            // TODO unit test for the property 'VideoSendWidthMin'
        }
        /// <summary>
        /// Test the property 'VideoSendWidthMax'
        /// </summary>
        [Test]
        public void VideoSendWidthMaxTest()
        {
            // TODO unit test for the property 'VideoSendWidthMax'
        }
        /// <summary>
        /// Test the property 'ContentRecvHeightMin'
        /// </summary>
        [Test]
        public void ContentRecvHeightMinTest()
        {
            // TODO unit test for the property 'ContentRecvHeightMin'
        }
        /// <summary>
        /// Test the property 'ContentRecvHeightMax'
        /// </summary>
        [Test]
        public void ContentRecvHeightMaxTest()
        {
            // TODO unit test for the property 'ContentRecvHeightMax'
        }
        /// <summary>
        /// Test the property 'ContentRecvWidthMin'
        /// </summary>
        [Test]
        public void ContentRecvWidthMinTest()
        {
            // TODO unit test for the property 'ContentRecvWidthMin'
        }
        /// <summary>
        /// Test the property 'ContentRecvWidthMax'
        /// </summary>
        [Test]
        public void ContentRecvWidthMaxTest()
        {
            // TODO unit test for the property 'ContentRecvWidthMax'
        }
        /// <summary>
        /// Test the property 'ContentSendHeightMin'
        /// </summary>
        [Test]
        public void ContentSendHeightMinTest()
        {
            // TODO unit test for the property 'ContentSendHeightMin'
        }
        /// <summary>
        /// Test the property 'ContentSendHeightMax'
        /// </summary>
        [Test]
        public void ContentSendHeightMaxTest()
        {
            // TODO unit test for the property 'ContentSendHeightMax'
        }
        /// <summary>
        /// Test the property 'ContentSendWidthMin'
        /// </summary>
        [Test]
        public void ContentSendWidthMinTest()
        {
            // TODO unit test for the property 'ContentSendWidthMin'
        }
        /// <summary>
        /// Test the property 'ContentSendWidthMax'
        /// </summary>
        [Test]
        public void ContentSendWidthMaxTest()
        {
            // TODO unit test for the property 'ContentSendWidthMax'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayMin'
        /// </summary>
        [Test]
        public void RoundTripDelayMinTest()
        {
            // TODO unit test for the property 'RoundTripDelayMin'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayMax'
        /// </summary>
        [Test]
        public void RoundTripDelayMaxTest()
        {
            // TODO unit test for the property 'RoundTripDelayMax'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayAvg'
        /// </summary>
        [Test]
        public void RoundTripDelayAvgTest()
        {
            // TODO unit test for the property 'RoundTripDelayAvg'
        }
        /// <summary>
        /// Test the property 'RfactorMin'
        /// </summary>
        [Test]
        public void RfactorMinTest()
        {
            // TODO unit test for the property 'RfactorMin'
        }
        /// <summary>
        /// Test the property 'RfactorMax'
        /// </summary>
        [Test]
        public void RfactorMaxTest()
        {
            // TODO unit test for the property 'RfactorMax'
        }
        /// <summary>
        /// Test the property 'RfactorAvg'
        /// </summary>
        [Test]
        public void RfactorAvgTest()
        {
            // TODO unit test for the property 'RfactorAvg'
        }
        /// <summary>
        /// Test the property 'ProcessCpuLoadMin'
        /// </summary>
        [Test]
        public void ProcessCpuLoadMinTest()
        {
            // TODO unit test for the property 'ProcessCpuLoadMin'
        }
        /// <summary>
        /// Test the property 'ProcessCpuLoadMax'
        /// </summary>
        [Test]
        public void ProcessCpuLoadMaxTest()
        {
            // TODO unit test for the property 'ProcessCpuLoadMax'
        }
        /// <summary>
        /// Test the property 'ProcessCpuLoadAvg'
        /// </summary>
        [Test]
        public void ProcessCpuLoadAvgTest()
        {
            // TODO unit test for the property 'ProcessCpuLoadAvg'
        }
        /// <summary>
        /// Test the property 'SystemCpuLoadMin'
        /// </summary>
        [Test]
        public void SystemCpuLoadMinTest()
        {
            // TODO unit test for the property 'SystemCpuLoadMin'
        }
        /// <summary>
        /// Test the property 'SystemCpuLoadMax'
        /// </summary>
        [Test]
        public void SystemCpuLoadMaxTest()
        {
            // TODO unit test for the property 'SystemCpuLoadMax'
        }
        /// <summary>
        /// Test the property 'SystemCpuLoadAvg'
        /// </summary>
        [Test]
        public void SystemCpuLoadAvgTest()
        {
            // TODO unit test for the property 'SystemCpuLoadAvg'
        }
        /// <summary>
        /// Test the property 'WifiRecvStrengthMin'
        /// </summary>
        [Test]
        public void WifiRecvStrengthMinTest()
        {
            // TODO unit test for the property 'WifiRecvStrengthMin'
        }
        /// <summary>
        /// Test the property 'WifiRecvStrengthMax'
        /// </summary>
        [Test]
        public void WifiRecvStrengthMaxTest()
        {
            // TODO unit test for the property 'WifiRecvStrengthMax'
        }
        /// <summary>
        /// Test the property 'WifiRecvStrengthAvg'
        /// </summary>
        [Test]
        public void WifiRecvStrengthAvgTest()
        {
            // TODO unit test for the property 'WifiRecvStrengthAvg'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateAvgVI'
        /// </summary>
        [Test]
        public void KeyFrameRateAvgVITest()
        {
            // TODO unit test for the property 'KeyFrameRateAvgVI'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateAvgVO'
        /// </summary>
        [Test]
        public void KeyFrameRateAvgVOTest()
        {
            // TODO unit test for the property 'KeyFrameRateAvgVO'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateAvgVIC'
        /// </summary>
        [Test]
        public void KeyFrameRateAvgVICTest()
        {
            // TODO unit test for the property 'KeyFrameRateAvgVIC'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateAvgVOC'
        /// </summary>
        [Test]
        public void KeyFrameRateAvgVOCTest()
        {
            // TODO unit test for the property 'KeyFrameRateAvgVOC'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMinVI'
        /// </summary>
        [Test]
        public void KeyFrameRateMinVITest()
        {
            // TODO unit test for the property 'KeyFrameRateMinVI'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMinVO'
        /// </summary>
        [Test]
        public void KeyFrameRateMinVOTest()
        {
            // TODO unit test for the property 'KeyFrameRateMinVO'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMinVIC'
        /// </summary>
        [Test]
        public void KeyFrameRateMinVICTest()
        {
            // TODO unit test for the property 'KeyFrameRateMinVIC'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMinVOC'
        /// </summary>
        [Test]
        public void KeyFrameRateMinVOCTest()
        {
            // TODO unit test for the property 'KeyFrameRateMinVOC'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMaxVI'
        /// </summary>
        [Test]
        public void KeyFrameRateMaxVITest()
        {
            // TODO unit test for the property 'KeyFrameRateMaxVI'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMaxVO'
        /// </summary>
        [Test]
        public void KeyFrameRateMaxVOTest()
        {
            // TODO unit test for the property 'KeyFrameRateMaxVO'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMaxVIC'
        /// </summary>
        [Test]
        public void KeyFrameRateMaxVICTest()
        {
            // TODO unit test for the property 'KeyFrameRateMaxVIC'
        }
        /// <summary>
        /// Test the property 'KeyFrameRateMaxVOC'
        /// </summary>
        [Test]
        public void KeyFrameRateMaxVOCTest()
        {
            // TODO unit test for the property 'KeyFrameRateMaxVOC'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayAvgVO'
        /// </summary>
        [Test]
        public void RoundTripDelayAvgVOTest()
        {
            // TODO unit test for the property 'RoundTripDelayAvgVO'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayAvgVOC'
        /// </summary>
        [Test]
        public void RoundTripDelayAvgVOCTest()
        {
            // TODO unit test for the property 'RoundTripDelayAvgVOC'
        }
        /// <summary>
        /// Test the property 'RoundTripDelayAvgAO'
        /// </summary>
        [Test]
        public void RoundTripDelayAvgAOTest()
        {
            // TODO unit test for the property 'RoundTripDelayAvgAO'
        }

    }

}
