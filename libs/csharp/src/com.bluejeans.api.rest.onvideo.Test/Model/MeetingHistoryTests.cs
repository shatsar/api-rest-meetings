/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
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
using com.bluejeans.api.rest.onvideo.Api;
using com.bluejeans.api.rest.onvideo.Model;
using com.bluejeans.api.rest.onvideo.Client;
using System.Reflection;

namespace com.bluejeans.api.rest.onvideo.Test
{
    /// <summary>
    ///  Class for testing MeetingHistory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MeetingHistoryTests
    {
        // TODO uncomment below to declare an instance variable for MeetingHistory
        //private MeetingHistory instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MeetingHistory
            //instance = new MeetingHistory();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MeetingHistory
        /// </summary>
        [Test]
        public void MeetingHistoryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MeetingHistory
            //Assert.IsInstanceOfType<MeetingHistory> (instance, "variable 'instance' is a MeetingHistory");
        }

        /// <summary>
        /// Test the property 'MeetingGuid'
        /// </summary>
        [Test]
        public void MeetingGuidTest()
        {
            // TODO unit test for the property 'MeetingGuid'
        }
        /// <summary>
        /// Test the property 'MeetingNumericId'
        /// </summary>
        [Test]
        public void MeetingNumericIdTest()
        {
            // TODO unit test for the property 'MeetingNumericId'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'LeaderInfo'
        /// </summary>
        [Test]
        public void LeaderInfoTest()
        {
            // TODO unit test for the property 'LeaderInfo'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'MeetingDuration'
        /// </summary>
        [Test]
        public void MeetingDurationTest()
        {
            // TODO unit test for the property 'MeetingDuration'
        }
        /// <summary>
        /// Test the property 'MaxParticipantCount'
        /// </summary>
        [Test]
        public void MaxParticipantCountTest()
        {
            // TODO unit test for the property 'MaxParticipantCount'
        }
        /// <summary>
        /// Test the property 'TotalParticipantMinutes'
        /// </summary>
        [Test]
        public void TotalParticipantMinutesTest()
        {
            // TODO unit test for the property 'TotalParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'MaxParticipantMinutes'
        /// </summary>
        [Test]
        public void MaxParticipantMinutesTest()
        {
            // TODO unit test for the property 'MaxParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'ExtraParticipantMinutes'
        /// </summary>
        [Test]
        public void ExtraParticipantMinutesTest()
        {
            // TODO unit test for the property 'ExtraParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'IsdnEndpoints'
        /// </summary>
        [Test]
        public void IsdnEndpointsTest()
        {
            // TODO unit test for the property 'IsdnEndpoints'
        }
        /// <summary>
        /// Test the property 'TotalDialoutMinutes'
        /// </summary>
        [Test]
        public void TotalDialoutMinutesTest()
        {
            // TODO unit test for the property 'TotalDialoutMinutes'
        }
        /// <summary>
        /// Test the property 'TotalTollFreeMinutes'
        /// </summary>
        [Test]
        public void TotalTollFreeMinutesTest()
        {
            // TODO unit test for the property 'TotalTollFreeMinutes'
        }
        /// <summary>
        /// Test the property 'CallDIDMinutes'
        /// </summary>
        [Test]
        public void CallDIDMinutesTest()
        {
            // TODO unit test for the property 'CallDIDMinutes'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'MeetingStatus'
        /// </summary>
        [Test]
        public void MeetingStatusTest()
        {
            // TODO unit test for the property 'MeetingStatus'
        }
        /// <summary>
        /// Test the property 'MeetingThumbnail'
        /// </summary>
        [Test]
        public void MeetingThumbnailTest()
        {
            // TODO unit test for the property 'MeetingThumbnail'
        }
        /// <summary>
        /// Test the property 'StartTimeZone'
        /// </summary>
        [Test]
        public void StartTimeZoneTest()
        {
            // TODO unit test for the property 'StartTimeZone'
        }
        /// <summary>
        /// Test the property 'ProcessingStatus'
        /// </summary>
        [Test]
        public void ProcessingStatusTest()
        {
            // TODO unit test for the property 'ProcessingStatus'
        }
        /// <summary>
        /// Test the property 'ConcurrentCalls'
        /// </summary>
        [Test]
        public void ConcurrentCallsTest()
        {
            // TODO unit test for the property 'ConcurrentCalls'
        }
        /// <summary>
        /// Test the property 'UploadStatus'
        /// </summary>
        [Test]
        public void UploadStatusTest()
        {
            // TODO unit test for the property 'UploadStatus'
        }
        /// <summary>
        /// Test the property 'Pstnonly'
        /// </summary>
        [Test]
        public void PstnonlyTest()
        {
            // TODO unit test for the property 'Pstnonly'
        }
        /// <summary>
        /// Test the property 'ParticipantList'
        /// </summary>
        [Test]
        public void ParticipantListTest()
        {
            // TODO unit test for the property 'ParticipantList'
        }

    }

}
