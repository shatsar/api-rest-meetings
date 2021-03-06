/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.bluejeans.api.rest.meetings.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.meetings.Model
{
    /// <summary>
    /// Endpoint
    /// </summary>
    [DataContract]
    public partial class Endpoint :  IEquatable<Endpoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="EcMode">EcMode.</param>
        /// <param name="Creationtime">Creationtime.</param>
        /// <param name="AudioRemoteRtcpAddress">AudioRemoteRtcpAddress.</param>
        /// <param name="VideoSendCodec">VideoSendCodec.</param>
        /// <param name="AudioPlayID">AudioPlayID.</param>
        /// <param name="CallQualityRecv">CallQualityRecv.</param>
        /// <param name="SessionOut">SessionOut.</param>
        /// <param name="AudioLocalAddress">AudioLocalAddress.</param>
        /// <param name="Meetingid">Meetingid.</param>
        /// <param name="VideoSendWidth">VideoSendWidth.</param>
        /// <param name="CallQualitySend">CallQualitySend.</param>
        /// <param name="Mhaddress">Mhaddress.</param>
        /// <param name="RDCControlleeCapable">RDCControlleeCapable.</param>
        /// <param name="AudioCapName">AudioCapName.</param>
        /// <param name="ProxyInfo">ProxyInfo.</param>
        /// <param name="AudioSendCodec">AudioSendCodec.</param>
        /// <param name="Vendor">Vendor.</param>
        /// <param name="VideoRecvWidth">VideoRecvWidth.</param>
        /// <param name="Conaddress">Conaddress.</param>
        /// <param name="TalkDetected">TalkDetected.</param>
        /// <param name="SubLayout">SubLayout.</param>
        /// <param name="AudioRtcpRelay">AudioRtcpRelay.</param>
        /// <param name="AudioRecvLocalMute">AudioRecvLocalMute.</param>
        /// <param name="Name">Name.</param>
        /// <param name="VideoLocalAddress">VideoLocalAddress.</param>
        /// <param name="AudioLocalRtcpAddress">AudioLocalRtcpAddress.</param>
        /// <param name="ContentRtpRelay">ContentRtpRelay.</param>
        /// <param name="ContentLocalRtcpAddress">ContentLocalRtcpAddress.</param>
        /// <param name="RemoteConnectionCount">RemoteConnectionCount.</param>
        /// <param name="Callrate">Callrate.</param>
        /// <param name="MixerGuid">MixerGuid.</param>
        /// <param name="Transport">Transport.</param>
        /// <param name="AudioCapSelectID">AudioCapSelectID.</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="RDCControllerCapable">RDCControllerCapable.</param>
        /// <param name="Pairedname">Pairedname.</param>
        /// <param name="VideoRtcpRelay">VideoRtcpRelay.</param>
        /// <param name="EndpointCpuParams">EndpointCpuParams.</param>
        /// <param name="VideoRemoteAddress">VideoRemoteAddress.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ContentRecv">ContentRecv.</param>
        /// <param name="LocalName">LocalName.</param>
        /// <param name="BJNUserId">BJNUserId.</param>
        /// <param name="ContentRemoteAddress">ContentRemoteAddress.</param>
        /// <param name="AudioSend">AudioSend.</param>
        /// <param name="ParticipantDTMFMenus">ParticipantDTMFMenus.</param>
        /// <param name="VideoRtcpTranspor">VideoRtcpTranspor.</param>
        /// <param name="AudioRtcpTransport">AudioRtcpTransport.</param>
        /// <param name="RelayNodeId">RelayNodeId.</param>
        /// <param name="ContentRemoteRtcpAddress">ContentRemoteRtcpAddress.</param>
        /// <param name="AudioRtpRelay">AudioRtpRelay.</param>
        /// <param name="VideoRtpTransport">VideoRtpTransport.</param>
        /// <param name="ContentRecvLocalMute">ContentRecvLocalMute.</param>
        /// <param name="Layout">Layout.</param>
        /// <param name="ContentSend">ContentSend.</param>
        /// <param name="Remoteaddress">Remoteaddress.</param>
        /// <param name="MeetingGuid">MeetingGuid.</param>
        /// <param name="Connecttime">Connecttime.</param>
        /// <param name="Localaddress">Localaddress.</param>
        /// <param name="AudioRemoteAddress">AudioRemoteAddress.</param>
        /// <param name="BondedAudioGuid">BondedAudioGuid.</param>
        /// <param name="AudioRecvRemoteMute">AudioRecvRemoteMute.</param>
        /// <param name="SessionOutRelay">SessionOutRelay.</param>
        /// <param name="Leader">Leader.</param>
        /// <param name="ContentLocalAddress">ContentLocalAddress.</param>
        /// <param name="MovieCapable">MovieCapable.</param>
        /// <param name="VideoRecvLocalMute">VideoRecvLocalMute.</param>
        /// <param name="ContentRtpTransport">ContentRtpTransport.</param>
        /// <param name="RDCVersion">RDCVersion.</param>
        /// <param name="AudioRecv">AudioRecv.</param>
        /// <param name="ContentRelayServer">ContentRelayServer.</param>
        /// <param name="VideoRecv">VideoRecv.</param>
        /// <param name="Visibility">Visibility.</param>
        /// <param name="Sessionid">Sessionid.</param>
        /// <param name="ContentRtcpRelay">ContentRtcpRelay.</param>
        /// <param name="Locales">Locales.</param>
        /// <param name="Medaddress">Medaddress.</param>
        /// <param name="HtmlLayoutGuid">HtmlLayoutGuid.</param>
        /// <param name="_Endpoint">_Endpoint.</param>
        /// <param name="VideoDrop">VideoDrop.</param>
        /// <param name="ContentRtcpTransport">ContentRtcpTransport.</param>
        /// <param name="VideoRemoteRtcpAddress">VideoRemoteRtcpAddress.</param>
        /// <param name="VideoRtpRelay">VideoRtpRelay.</param>
        /// <param name="Mixaddress">Mixaddress.</param>
        /// <param name="SIPHTTPProxyTransport">SIPHTTPProxyTransport.</param>
        /// <param name="VideoRecvCodec">VideoRecvCodec.</param>
        /// <param name="AudioRecvCodec">AudioRecvCodec.</param>
        /// <param name="SessionIn">SessionIn.</param>
        /// <param name="BondedVideoGuid">BondedVideoGuid.</param>
        /// <param name="CallQuality">CallQuality.</param>
        /// <param name="Meetingjointime">Meetingjointime.</param>
        /// <param name="SessionInRelay">SessionInRelay.</param>
        /// <param name="Pairedremoteaddress">Pairedremoteaddress.</param>
        /// <param name="VideoSendHeight">VideoSendHeight.</param>
        /// <param name="VideoRecvHeight">VideoRecvHeight.</param>
        /// <param name="SecureCall">SecureCall.</param>
        /// <param name="VideoLocalRtcpAddress">VideoLocalRtcpAddress.</param>
        /// <param name="AudioPlayName">AudioPlayName.</param>
        /// <param name="VideoCapID">VideoCapID.</param>
        /// <param name="AudioRtpTransport">AudioRtpTransport.</param>
        /// <param name="MeetingInfoMode">MeetingInfoMode.</param>
        /// <param name="Callhostname">Callhostname.</param>
        /// <param name="Callguid">Callguid.</param>
        /// <param name="AudioCapID">AudioCapID.</param>
        /// <param name="VideoSend">VideoSend.</param>
        /// <param name="ContentRecvCodec">ContentRecvCodec.</param>
        /// <param name="SessionRelay">SessionRelay.</param>
        /// <param name="VideoRecvRemoteMute">VideoRecvRemoteMute.</param>
        /// <param name="Id">Id.</param>
        /// <param name="BondedVideoName">BondedVideoName.</param>
        /// <param name="IsInRoster">IsInRoster.</param>
        public Endpoint(string EcMode = default(string), string Creationtime = default(string), string AudioRemoteRtcpAddress = default(string), string VideoSendCodec = default(string), string AudioPlayID = default(string), string CallQualityRecv = default(string), string SessionOut = default(string), string AudioLocalAddress = default(string), string Meetingid = default(string), string VideoSendWidth = default(string), string CallQualitySend = default(string), string Mhaddress = default(string), string RDCControlleeCapable = default(string), string AudioCapName = default(string), string ProxyInfo = default(string), string AudioSendCodec = default(string), string Vendor = default(string), string VideoRecvWidth = default(string), string Conaddress = default(string), string TalkDetected = default(string), string SubLayout = default(string), string AudioRtcpRelay = default(string), string AudioRecvLocalMute = default(string), string Name = default(string), string VideoLocalAddress = default(string), string AudioLocalRtcpAddress = default(string), string ContentRtpRelay = default(string), string ContentLocalRtcpAddress = default(string), string RemoteConnectionCount = default(string), string Callrate = default(string), string MixerGuid = default(string), string Transport = default(string), string AudioCapSelectID = default(string), string CountryCode = default(string), string RDCControllerCapable = default(string), string Pairedname = default(string), string VideoRtcpRelay = default(string), string EndpointCpuParams = default(string), string VideoRemoteAddress = default(string), string Version = default(string), string ContentRecv = default(string), string LocalName = default(string), string BJNUserId = default(string), string ContentRemoteAddress = default(string), string AudioSend = default(string), string ParticipantDTMFMenus = default(string), string VideoRtcpTranspor = default(string), string AudioRtcpTransport = default(string), string RelayNodeId = default(string), string ContentRemoteRtcpAddress = default(string), string AudioRtpRelay = default(string), string VideoRtpTransport = default(string), string ContentRecvLocalMute = default(string), string Layout = default(string), string ContentSend = default(string), string Remoteaddress = default(string), string MeetingGuid = default(string), string Connecttime = default(string), string Localaddress = default(string), string AudioRemoteAddress = default(string), string BondedAudioGuid = default(string), string AudioRecvRemoteMute = default(string), string SessionOutRelay = default(string), string Leader = default(string), string ContentLocalAddress = default(string), string MovieCapable = default(string), string VideoRecvLocalMute = default(string), string ContentRtpTransport = default(string), string RDCVersion = default(string), string AudioRecv = default(string), string ContentRelayServer = default(string), string VideoRecv = default(string), string Visibility = default(string), string Sessionid = default(string), string ContentRtcpRelay = default(string), string Locales = default(string), string Medaddress = default(string), string HtmlLayoutGuid = default(string), string _Endpoint = default(string), string VideoDrop = default(string), string ContentRtcpTransport = default(string), string VideoRemoteRtcpAddress = default(string), string VideoRtpRelay = default(string), string Mixaddress = default(string), string SIPHTTPProxyTransport = default(string), string VideoRecvCodec = default(string), string AudioRecvCodec = default(string), string SessionIn = default(string), string BondedVideoGuid = default(string), string CallQuality = default(string), string Meetingjointime = default(string), string SessionInRelay = default(string), string Pairedremoteaddress = default(string), string VideoSendHeight = default(string), string VideoRecvHeight = default(string), string SecureCall = default(string), string VideoLocalRtcpAddress = default(string), string AudioPlayName = default(string), string VideoCapID = default(string), string AudioRtpTransport = default(string), string MeetingInfoMode = default(string), string Callhostname = default(string), string Callguid = default(string), string AudioCapID = default(string), string VideoSend = default(string), string ContentRecvCodec = default(string), string SessionRelay = default(string), string VideoRecvRemoteMute = default(string), string Id = default(string), string BondedVideoName = default(string), bool? IsInRoster = default(bool?))
        {
            this.EcMode = EcMode;
            this.Creationtime = Creationtime;
            this.AudioRemoteRtcpAddress = AudioRemoteRtcpAddress;
            this.VideoSendCodec = VideoSendCodec;
            this.AudioPlayID = AudioPlayID;
            this.CallQualityRecv = CallQualityRecv;
            this.SessionOut = SessionOut;
            this.AudioLocalAddress = AudioLocalAddress;
            this.Meetingid = Meetingid;
            this.VideoSendWidth = VideoSendWidth;
            this.CallQualitySend = CallQualitySend;
            this.Mhaddress = Mhaddress;
            this.RDCControlleeCapable = RDCControlleeCapable;
            this.AudioCapName = AudioCapName;
            this.ProxyInfo = ProxyInfo;
            this.AudioSendCodec = AudioSendCodec;
            this.Vendor = Vendor;
            this.VideoRecvWidth = VideoRecvWidth;
            this.Conaddress = Conaddress;
            this.TalkDetected = TalkDetected;
            this.SubLayout = SubLayout;
            this.AudioRtcpRelay = AudioRtcpRelay;
            this.AudioRecvLocalMute = AudioRecvLocalMute;
            this.Name = Name;
            this.VideoLocalAddress = VideoLocalAddress;
            this.AudioLocalRtcpAddress = AudioLocalRtcpAddress;
            this.ContentRtpRelay = ContentRtpRelay;
            this.ContentLocalRtcpAddress = ContentLocalRtcpAddress;
            this.RemoteConnectionCount = RemoteConnectionCount;
            this.Callrate = Callrate;
            this.MixerGuid = MixerGuid;
            this.Transport = Transport;
            this.AudioCapSelectID = AudioCapSelectID;
            this.CountryCode = CountryCode;
            this.RDCControllerCapable = RDCControllerCapable;
            this.Pairedname = Pairedname;
            this.VideoRtcpRelay = VideoRtcpRelay;
            this.EndpointCpuParams = EndpointCpuParams;
            this.VideoRemoteAddress = VideoRemoteAddress;
            this.Version = Version;
            this.ContentRecv = ContentRecv;
            this.LocalName = LocalName;
            this.BJNUserId = BJNUserId;
            this.ContentRemoteAddress = ContentRemoteAddress;
            this.AudioSend = AudioSend;
            this.ParticipantDTMFMenus = ParticipantDTMFMenus;
            this.VideoRtcpTranspor = VideoRtcpTranspor;
            this.AudioRtcpTransport = AudioRtcpTransport;
            this.RelayNodeId = RelayNodeId;
            this.ContentRemoteRtcpAddress = ContentRemoteRtcpAddress;
            this.AudioRtpRelay = AudioRtpRelay;
            this.VideoRtpTransport = VideoRtpTransport;
            this.ContentRecvLocalMute = ContentRecvLocalMute;
            this.Layout = Layout;
            this.ContentSend = ContentSend;
            this.Remoteaddress = Remoteaddress;
            this.MeetingGuid = MeetingGuid;
            this.Connecttime = Connecttime;
            this.Localaddress = Localaddress;
            this.AudioRemoteAddress = AudioRemoteAddress;
            this.BondedAudioGuid = BondedAudioGuid;
            this.AudioRecvRemoteMute = AudioRecvRemoteMute;
            this.SessionOutRelay = SessionOutRelay;
            this.Leader = Leader;
            this.ContentLocalAddress = ContentLocalAddress;
            this.MovieCapable = MovieCapable;
            this.VideoRecvLocalMute = VideoRecvLocalMute;
            this.ContentRtpTransport = ContentRtpTransport;
            this.RDCVersion = RDCVersion;
            this.AudioRecv = AudioRecv;
            this.ContentRelayServer = ContentRelayServer;
            this.VideoRecv = VideoRecv;
            this.Visibility = Visibility;
            this.Sessionid = Sessionid;
            this.ContentRtcpRelay = ContentRtcpRelay;
            this.Locales = Locales;
            this.Medaddress = Medaddress;
            this.HtmlLayoutGuid = HtmlLayoutGuid;
            this._Endpoint = _Endpoint;
            this.VideoDrop = VideoDrop;
            this.ContentRtcpTransport = ContentRtcpTransport;
            this.VideoRemoteRtcpAddress = VideoRemoteRtcpAddress;
            this.VideoRtpRelay = VideoRtpRelay;
            this.Mixaddress = Mixaddress;
            this.SIPHTTPProxyTransport = SIPHTTPProxyTransport;
            this.VideoRecvCodec = VideoRecvCodec;
            this.AudioRecvCodec = AudioRecvCodec;
            this.SessionIn = SessionIn;
            this.BondedVideoGuid = BondedVideoGuid;
            this.CallQuality = CallQuality;
            this.Meetingjointime = Meetingjointime;
            this.SessionInRelay = SessionInRelay;
            this.Pairedremoteaddress = Pairedremoteaddress;
            this.VideoSendHeight = VideoSendHeight;
            this.VideoRecvHeight = VideoRecvHeight;
            this.SecureCall = SecureCall;
            this.VideoLocalRtcpAddress = VideoLocalRtcpAddress;
            this.AudioPlayName = AudioPlayName;
            this.VideoCapID = VideoCapID;
            this.AudioRtpTransport = AudioRtpTransport;
            this.MeetingInfoMode = MeetingInfoMode;
            this.Callhostname = Callhostname;
            this.Callguid = Callguid;
            this.AudioCapID = AudioCapID;
            this.VideoSend = VideoSend;
            this.ContentRecvCodec = ContentRecvCodec;
            this.SessionRelay = SessionRelay;
            this.VideoRecvRemoteMute = VideoRecvRemoteMute;
            this.Id = Id;
            this.BondedVideoName = BondedVideoName;
            this.IsInRoster = IsInRoster;
        }
        
        /// <summary>
        /// Gets or Sets EcMode
        /// </summary>
        [DataMember(Name="EcMode", EmitDefaultValue=false)]
        public string EcMode { get; set; }

        /// <summary>
        /// Gets or Sets Creationtime
        /// </summary>
        [DataMember(Name="creationtime", EmitDefaultValue=false)]
        public string Creationtime { get; set; }

        /// <summary>
        /// Gets or Sets AudioRemoteRtcpAddress
        /// </summary>
        [DataMember(Name="audio.remote.rtcpAddress", EmitDefaultValue=false)]
        public string AudioRemoteRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendCodec
        /// </summary>
        [DataMember(Name="VideoSendCodec", EmitDefaultValue=false)]
        public string VideoSendCodec { get; set; }

        /// <summary>
        /// Gets or Sets AudioPlayID
        /// </summary>
        [DataMember(Name="AudioPlayID", EmitDefaultValue=false)]
        public string AudioPlayID { get; set; }

        /// <summary>
        /// Gets or Sets CallQualityRecv
        /// </summary>
        [DataMember(Name="CallQualityRecv", EmitDefaultValue=false)]
        public string CallQualityRecv { get; set; }

        /// <summary>
        /// Gets or Sets SessionOut
        /// </summary>
        [DataMember(Name="SessionOut", EmitDefaultValue=false)]
        public string SessionOut { get; set; }

        /// <summary>
        /// Gets or Sets AudioLocalAddress
        /// </summary>
        [DataMember(Name="audio.local.address", EmitDefaultValue=false)]
        public string AudioLocalAddress { get; set; }

        /// <summary>
        /// Gets or Sets Meetingid
        /// </summary>
        [DataMember(Name="meetingid", EmitDefaultValue=false)]
        public string Meetingid { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendWidth
        /// </summary>
        [DataMember(Name="VideoSendWidth", EmitDefaultValue=false)]
        public string VideoSendWidth { get; set; }

        /// <summary>
        /// Gets or Sets CallQualitySend
        /// </summary>
        [DataMember(Name="CallQualitySend", EmitDefaultValue=false)]
        public string CallQualitySend { get; set; }

        /// <summary>
        /// Gets or Sets Mhaddress
        /// </summary>
        [DataMember(Name="mhaddress", EmitDefaultValue=false)]
        public string Mhaddress { get; set; }

        /// <summary>
        /// Gets or Sets RDCControlleeCapable
        /// </summary>
        [DataMember(Name="RDCControlleeCapable", EmitDefaultValue=false)]
        public string RDCControlleeCapable { get; set; }

        /// <summary>
        /// Gets or Sets AudioCapName
        /// </summary>
        [DataMember(Name="AudioCapName", EmitDefaultValue=false)]
        public string AudioCapName { get; set; }

        /// <summary>
        /// Gets or Sets ProxyInfo
        /// </summary>
        [DataMember(Name="ProxyInfo", EmitDefaultValue=false)]
        public string ProxyInfo { get; set; }

        /// <summary>
        /// Gets or Sets AudioSendCodec
        /// </summary>
        [DataMember(Name="AudioSendCodec", EmitDefaultValue=false)]
        public string AudioSendCodec { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvWidth
        /// </summary>
        [DataMember(Name="VideoRecvWidth", EmitDefaultValue=false)]
        public string VideoRecvWidth { get; set; }

        /// <summary>
        /// Gets or Sets Conaddress
        /// </summary>
        [DataMember(Name="conaddress", EmitDefaultValue=false)]
        public string Conaddress { get; set; }

        /// <summary>
        /// Gets or Sets TalkDetected
        /// </summary>
        [DataMember(Name="TalkDetected", EmitDefaultValue=false)]
        public string TalkDetected { get; set; }

        /// <summary>
        /// Gets or Sets SubLayout
        /// </summary>
        [DataMember(Name="SubLayout", EmitDefaultValue=false)]
        public string SubLayout { get; set; }

        /// <summary>
        /// Gets or Sets AudioRtcpRelay
        /// </summary>
        [DataMember(Name="AudioRtcpRelay", EmitDefaultValue=false)]
        public string AudioRtcpRelay { get; set; }

        /// <summary>
        /// Gets or Sets AudioRecvLocalMute
        /// </summary>
        [DataMember(Name="AudioRecvLocalMute", EmitDefaultValue=false)]
        public string AudioRecvLocalMute { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VideoLocalAddress
        /// </summary>
        [DataMember(Name="video.local.address", EmitDefaultValue=false)]
        public string VideoLocalAddress { get; set; }

        /// <summary>
        /// Gets or Sets AudioLocalRtcpAddress
        /// </summary>
        [DataMember(Name="audio.local.rtcpAddress", EmitDefaultValue=false)]
        public string AudioLocalRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets ContentRtpRelay
        /// </summary>
        [DataMember(Name="ContentRtpRelay", EmitDefaultValue=false)]
        public string ContentRtpRelay { get; set; }

        /// <summary>
        /// Gets or Sets ContentLocalRtcpAddress
        /// </summary>
        [DataMember(Name="content.local.rtcpAddress", EmitDefaultValue=false)]
        public string ContentLocalRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets RemoteConnectionCount
        /// </summary>
        [DataMember(Name="RemoteConnectionCount", EmitDefaultValue=false)]
        public string RemoteConnectionCount { get; set; }

        /// <summary>
        /// Gets or Sets Callrate
        /// </summary>
        [DataMember(Name="callrate", EmitDefaultValue=false)]
        public string Callrate { get; set; }

        /// <summary>
        /// Gets or Sets MixerGuid
        /// </summary>
        [DataMember(Name="MixerGuid", EmitDefaultValue=false)]
        public string MixerGuid { get; set; }

        /// <summary>
        /// Gets or Sets Transport
        /// </summary>
        [DataMember(Name="transport", EmitDefaultValue=false)]
        public string Transport { get; set; }

        /// <summary>
        /// Gets or Sets AudioCapSelectID
        /// </summary>
        [DataMember(Name="AudioCapSelectID", EmitDefaultValue=false)]
        public string AudioCapSelectID { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets RDCControllerCapable
        /// </summary>
        [DataMember(Name="RDCControllerCapable", EmitDefaultValue=false)]
        public string RDCControllerCapable { get; set; }

        /// <summary>
        /// Gets or Sets Pairedname
        /// </summary>
        [DataMember(Name="pairedname", EmitDefaultValue=false)]
        public string Pairedname { get; set; }

        /// <summary>
        /// Gets or Sets VideoRtcpRelay
        /// </summary>
        [DataMember(Name="VideoRtcpRelay", EmitDefaultValue=false)]
        public string VideoRtcpRelay { get; set; }

        /// <summary>
        /// Gets or Sets EndpointCpuParams
        /// </summary>
        [DataMember(Name="EndpointCpuParams", EmitDefaultValue=false)]
        public string EndpointCpuParams { get; set; }

        /// <summary>
        /// Gets or Sets VideoRemoteAddress
        /// </summary>
        [DataMember(Name="video.remote.address", EmitDefaultValue=false)]
        public string VideoRemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecv
        /// </summary>
        [DataMember(Name="ContentRecv", EmitDefaultValue=false)]
        public string ContentRecv { get; set; }

        /// <summary>
        /// Gets or Sets LocalName
        /// </summary>
        [DataMember(Name="localName", EmitDefaultValue=false)]
        public string LocalName { get; set; }

        /// <summary>
        /// Gets or Sets BJNUserId
        /// </summary>
        [DataMember(Name="BJNUserId", EmitDefaultValue=false)]
        public string BJNUserId { get; set; }

        /// <summary>
        /// Gets or Sets ContentRemoteAddress
        /// </summary>
        [DataMember(Name="content.remote.address", EmitDefaultValue=false)]
        public string ContentRemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets AudioSend
        /// </summary>
        [DataMember(Name="AudioSend", EmitDefaultValue=false)]
        public string AudioSend { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantDTMFMenus
        /// </summary>
        [DataMember(Name="ParticipantDTMFMenus", EmitDefaultValue=false)]
        public string ParticipantDTMFMenus { get; set; }

        /// <summary>
        /// Gets or Sets VideoRtcpTranspor
        /// </summary>
        [DataMember(Name="VideoRtcpTranspor", EmitDefaultValue=false)]
        public string VideoRtcpTranspor { get; set; }

        /// <summary>
        /// Gets or Sets AudioRtcpTransport
        /// </summary>
        [DataMember(Name="AudioRtcpTransport", EmitDefaultValue=false)]
        public string AudioRtcpTransport { get; set; }

        /// <summary>
        /// Gets or Sets RelayNodeId
        /// </summary>
        [DataMember(Name="RelayNodeId", EmitDefaultValue=false)]
        public string RelayNodeId { get; set; }

        /// <summary>
        /// Gets or Sets ContentRemoteRtcpAddress
        /// </summary>
        [DataMember(Name="content.remote.rtcpAddress", EmitDefaultValue=false)]
        public string ContentRemoteRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets AudioRtpRelay
        /// </summary>
        [DataMember(Name="AudioRtpRelay", EmitDefaultValue=false)]
        public string AudioRtpRelay { get; set; }

        /// <summary>
        /// Gets or Sets VideoRtpTransport
        /// </summary>
        [DataMember(Name="VideoRtpTransport", EmitDefaultValue=false)]
        public string VideoRtpTransport { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvLocalMute
        /// </summary>
        [DataMember(Name="ContentRecvLocalMute", EmitDefaultValue=false)]
        public string ContentRecvLocalMute { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="Layout", EmitDefaultValue=false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or Sets ContentSend
        /// </summary>
        [DataMember(Name="ContentSend", EmitDefaultValue=false)]
        public string ContentSend { get; set; }

        /// <summary>
        /// Gets or Sets Remoteaddress
        /// </summary>
        [DataMember(Name="remoteaddress", EmitDefaultValue=false)]
        public string Remoteaddress { get; set; }

        /// <summary>
        /// Gets or Sets MeetingGuid
        /// </summary>
        [DataMember(Name="MeetingGuid", EmitDefaultValue=false)]
        public string MeetingGuid { get; set; }

        /// <summary>
        /// Gets or Sets Connecttime
        /// </summary>
        [DataMember(Name="connecttime", EmitDefaultValue=false)]
        public string Connecttime { get; set; }

        /// <summary>
        /// Gets or Sets Localaddress
        /// </summary>
        [DataMember(Name="localaddress", EmitDefaultValue=false)]
        public string Localaddress { get; set; }

        /// <summary>
        /// Gets or Sets AudioRemoteAddress
        /// </summary>
        [DataMember(Name="audio.remote.address", EmitDefaultValue=false)]
        public string AudioRemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets BondedAudioGuid
        /// </summary>
        [DataMember(Name="BondedAudioGuid", EmitDefaultValue=false)]
        public string BondedAudioGuid { get; set; }

        /// <summary>
        /// Gets or Sets AudioRecvRemoteMute
        /// </summary>
        [DataMember(Name="AudioRecvRemoteMute", EmitDefaultValue=false)]
        public string AudioRecvRemoteMute { get; set; }

        /// <summary>
        /// Gets or Sets SessionOutRelay
        /// </summary>
        [DataMember(Name="SessionOutRelay", EmitDefaultValue=false)]
        public string SessionOutRelay { get; set; }

        /// <summary>
        /// Gets or Sets Leader
        /// </summary>
        [DataMember(Name="Leader", EmitDefaultValue=false)]
        public string Leader { get; set; }

        /// <summary>
        /// Gets or Sets ContentLocalAddress
        /// </summary>
        [DataMember(Name="content.local.address", EmitDefaultValue=false)]
        public string ContentLocalAddress { get; set; }

        /// <summary>
        /// Gets or Sets MovieCapable
        /// </summary>
        [DataMember(Name="MovieCapable", EmitDefaultValue=false)]
        public string MovieCapable { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvLocalMute
        /// </summary>
        [DataMember(Name="VideoRecvLocalMute", EmitDefaultValue=false)]
        public string VideoRecvLocalMute { get; set; }

        /// <summary>
        /// Gets or Sets ContentRtpTransport
        /// </summary>
        [DataMember(Name="ContentRtpTransport", EmitDefaultValue=false)]
        public string ContentRtpTransport { get; set; }

        /// <summary>
        /// Gets or Sets RDCVersion
        /// </summary>
        [DataMember(Name="RDCVersion", EmitDefaultValue=false)]
        public string RDCVersion { get; set; }

        /// <summary>
        /// Gets or Sets AudioRecv
        /// </summary>
        [DataMember(Name="AudioRecv", EmitDefaultValue=false)]
        public string AudioRecv { get; set; }

        /// <summary>
        /// Gets or Sets ContentRelayServer
        /// </summary>
        [DataMember(Name="ContentRelayServer", EmitDefaultValue=false)]
        public string ContentRelayServer { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecv
        /// </summary>
        [DataMember(Name="VideoRecv", EmitDefaultValue=false)]
        public string VideoRecv { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or Sets Sessionid
        /// </summary>
        [DataMember(Name="sessionid", EmitDefaultValue=false)]
        public string Sessionid { get; set; }

        /// <summary>
        /// Gets or Sets ContentRtcpRelay
        /// </summary>
        [DataMember(Name="ContentRtcpRelay", EmitDefaultValue=false)]
        public string ContentRtcpRelay { get; set; }

        /// <summary>
        /// Gets or Sets Locales
        /// </summary>
        [DataMember(Name="locales", EmitDefaultValue=false)]
        public string Locales { get; set; }

        /// <summary>
        /// Gets or Sets Medaddress
        /// </summary>
        [DataMember(Name="medaddress", EmitDefaultValue=false)]
        public string Medaddress { get; set; }

        /// <summary>
        /// Gets or Sets HtmlLayoutGuid
        /// </summary>
        [DataMember(Name="HtmlLayoutGuid", EmitDefaultValue=false)]
        public string HtmlLayoutGuid { get; set; }

        /// <summary>
        /// Gets or Sets _Endpoint
        /// </summary>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string _Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets VideoDrop
        /// </summary>
        [DataMember(Name="VideoDrop", EmitDefaultValue=false)]
        public string VideoDrop { get; set; }

        /// <summary>
        /// Gets or Sets ContentRtcpTransport
        /// </summary>
        [DataMember(Name="ContentRtcpTransport", EmitDefaultValue=false)]
        public string ContentRtcpTransport { get; set; }

        /// <summary>
        /// Gets or Sets VideoRemoteRtcpAddress
        /// </summary>
        [DataMember(Name="video.remote.rtcpAddress", EmitDefaultValue=false)]
        public string VideoRemoteRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets VideoRtpRelay
        /// </summary>
        [DataMember(Name="VideoRtpRelay", EmitDefaultValue=false)]
        public string VideoRtpRelay { get; set; }

        /// <summary>
        /// Gets or Sets Mixaddress
        /// </summary>
        [DataMember(Name="mixaddress", EmitDefaultValue=false)]
        public string Mixaddress { get; set; }

        /// <summary>
        /// Gets or Sets SIPHTTPProxyTransport
        /// </summary>
        [DataMember(Name="SIPHTTPProxyTransport", EmitDefaultValue=false)]
        public string SIPHTTPProxyTransport { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvCodec
        /// </summary>
        [DataMember(Name="VideoRecvCodec", EmitDefaultValue=false)]
        public string VideoRecvCodec { get; set; }

        /// <summary>
        /// Gets or Sets AudioRecvCodec
        /// </summary>
        [DataMember(Name="AudioRecvCodec", EmitDefaultValue=false)]
        public string AudioRecvCodec { get; set; }

        /// <summary>
        /// Gets or Sets SessionIn
        /// </summary>
        [DataMember(Name="SessionIn", EmitDefaultValue=false)]
        public string SessionIn { get; set; }

        /// <summary>
        /// Gets or Sets BondedVideoGuid
        /// </summary>
        [DataMember(Name="BondedVideoGuid", EmitDefaultValue=false)]
        public string BondedVideoGuid { get; set; }

        /// <summary>
        /// Gets or Sets CallQuality
        /// </summary>
        [DataMember(Name="CallQuality", EmitDefaultValue=false)]
        public string CallQuality { get; set; }

        /// <summary>
        /// Gets or Sets Meetingjointime
        /// </summary>
        [DataMember(Name="meetingjointime", EmitDefaultValue=false)]
        public string Meetingjointime { get; set; }

        /// <summary>
        /// Gets or Sets SessionInRelay
        /// </summary>
        [DataMember(Name="SessionInRelay", EmitDefaultValue=false)]
        public string SessionInRelay { get; set; }

        /// <summary>
        /// Gets or Sets Pairedremoteaddress
        /// </summary>
        [DataMember(Name="pairedremoteaddress", EmitDefaultValue=false)]
        public string Pairedremoteaddress { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendHeight
        /// </summary>
        [DataMember(Name="VideoSendHeight", EmitDefaultValue=false)]
        public string VideoSendHeight { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvHeight
        /// </summary>
        [DataMember(Name="VideoRecvHeight", EmitDefaultValue=false)]
        public string VideoRecvHeight { get; set; }

        /// <summary>
        /// Gets or Sets SecureCall
        /// </summary>
        [DataMember(Name="SecureCall", EmitDefaultValue=false)]
        public string SecureCall { get; set; }

        /// <summary>
        /// Gets or Sets VideoLocalRtcpAddress
        /// </summary>
        [DataMember(Name="video.local.rtcpAddress", EmitDefaultValue=false)]
        public string VideoLocalRtcpAddress { get; set; }

        /// <summary>
        /// Gets or Sets AudioPlayName
        /// </summary>
        [DataMember(Name="AudioPlayName", EmitDefaultValue=false)]
        public string AudioPlayName { get; set; }

        /// <summary>
        /// Gets or Sets VideoCapID
        /// </summary>
        [DataMember(Name="VideoCapID", EmitDefaultValue=false)]
        public string VideoCapID { get; set; }

        /// <summary>
        /// Gets or Sets AudioRtpTransport
        /// </summary>
        [DataMember(Name="AudioRtpTransport", EmitDefaultValue=false)]
        public string AudioRtpTransport { get; set; }

        /// <summary>
        /// Gets or Sets MeetingInfoMode
        /// </summary>
        [DataMember(Name="MeetingInfoMode", EmitDefaultValue=false)]
        public string MeetingInfoMode { get; set; }

        /// <summary>
        /// Gets or Sets Callhostname
        /// </summary>
        [DataMember(Name="callhostname", EmitDefaultValue=false)]
        public string Callhostname { get; set; }

        /// <summary>
        /// Gets or Sets Callguid
        /// </summary>
        [DataMember(Name="callguid", EmitDefaultValue=false)]
        public string Callguid { get; set; }

        /// <summary>
        /// Gets or Sets AudioCapID
        /// </summary>
        [DataMember(Name="AudioCapID", EmitDefaultValue=false)]
        public string AudioCapID { get; set; }

        /// <summary>
        /// Gets or Sets VideoSend
        /// </summary>
        [DataMember(Name="VideoSend", EmitDefaultValue=false)]
        public string VideoSend { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvCodec
        /// </summary>
        [DataMember(Name="ContentRecvCodec", EmitDefaultValue=false)]
        public string ContentRecvCodec { get; set; }

        /// <summary>
        /// Gets or Sets SessionRelay
        /// </summary>
        [DataMember(Name="SessionRelay", EmitDefaultValue=false)]
        public string SessionRelay { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvRemoteMute
        /// </summary>
        [DataMember(Name="VideoRecvRemoteMute", EmitDefaultValue=false)]
        public string VideoRecvRemoteMute { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BondedVideoName
        /// </summary>
        [DataMember(Name="BondedVideoName", EmitDefaultValue=false)]
        public string BondedVideoName { get; set; }

        /// <summary>
        /// Gets or Sets IsInRoster
        /// </summary>
        [DataMember(Name="isInRoster", EmitDefaultValue=false)]
        public bool? IsInRoster { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  EcMode: ").Append(EcMode).Append("\n");
            sb.Append("  Creationtime: ").Append(Creationtime).Append("\n");
            sb.Append("  AudioRemoteRtcpAddress: ").Append(AudioRemoteRtcpAddress).Append("\n");
            sb.Append("  VideoSendCodec: ").Append(VideoSendCodec).Append("\n");
            sb.Append("  AudioPlayID: ").Append(AudioPlayID).Append("\n");
            sb.Append("  CallQualityRecv: ").Append(CallQualityRecv).Append("\n");
            sb.Append("  SessionOut: ").Append(SessionOut).Append("\n");
            sb.Append("  AudioLocalAddress: ").Append(AudioLocalAddress).Append("\n");
            sb.Append("  Meetingid: ").Append(Meetingid).Append("\n");
            sb.Append("  VideoSendWidth: ").Append(VideoSendWidth).Append("\n");
            sb.Append("  CallQualitySend: ").Append(CallQualitySend).Append("\n");
            sb.Append("  Mhaddress: ").Append(Mhaddress).Append("\n");
            sb.Append("  RDCControlleeCapable: ").Append(RDCControlleeCapable).Append("\n");
            sb.Append("  AudioCapName: ").Append(AudioCapName).Append("\n");
            sb.Append("  ProxyInfo: ").Append(ProxyInfo).Append("\n");
            sb.Append("  AudioSendCodec: ").Append(AudioSendCodec).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  VideoRecvWidth: ").Append(VideoRecvWidth).Append("\n");
            sb.Append("  Conaddress: ").Append(Conaddress).Append("\n");
            sb.Append("  TalkDetected: ").Append(TalkDetected).Append("\n");
            sb.Append("  SubLayout: ").Append(SubLayout).Append("\n");
            sb.Append("  AudioRtcpRelay: ").Append(AudioRtcpRelay).Append("\n");
            sb.Append("  AudioRecvLocalMute: ").Append(AudioRecvLocalMute).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VideoLocalAddress: ").Append(VideoLocalAddress).Append("\n");
            sb.Append("  AudioLocalRtcpAddress: ").Append(AudioLocalRtcpAddress).Append("\n");
            sb.Append("  ContentRtpRelay: ").Append(ContentRtpRelay).Append("\n");
            sb.Append("  ContentLocalRtcpAddress: ").Append(ContentLocalRtcpAddress).Append("\n");
            sb.Append("  RemoteConnectionCount: ").Append(RemoteConnectionCount).Append("\n");
            sb.Append("  Callrate: ").Append(Callrate).Append("\n");
            sb.Append("  MixerGuid: ").Append(MixerGuid).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  AudioCapSelectID: ").Append(AudioCapSelectID).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  RDCControllerCapable: ").Append(RDCControllerCapable).Append("\n");
            sb.Append("  Pairedname: ").Append(Pairedname).Append("\n");
            sb.Append("  VideoRtcpRelay: ").Append(VideoRtcpRelay).Append("\n");
            sb.Append("  EndpointCpuParams: ").Append(EndpointCpuParams).Append("\n");
            sb.Append("  VideoRemoteAddress: ").Append(VideoRemoteAddress).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ContentRecv: ").Append(ContentRecv).Append("\n");
            sb.Append("  LocalName: ").Append(LocalName).Append("\n");
            sb.Append("  BJNUserId: ").Append(BJNUserId).Append("\n");
            sb.Append("  ContentRemoteAddress: ").Append(ContentRemoteAddress).Append("\n");
            sb.Append("  AudioSend: ").Append(AudioSend).Append("\n");
            sb.Append("  ParticipantDTMFMenus: ").Append(ParticipantDTMFMenus).Append("\n");
            sb.Append("  VideoRtcpTranspor: ").Append(VideoRtcpTranspor).Append("\n");
            sb.Append("  AudioRtcpTransport: ").Append(AudioRtcpTransport).Append("\n");
            sb.Append("  RelayNodeId: ").Append(RelayNodeId).Append("\n");
            sb.Append("  ContentRemoteRtcpAddress: ").Append(ContentRemoteRtcpAddress).Append("\n");
            sb.Append("  AudioRtpRelay: ").Append(AudioRtpRelay).Append("\n");
            sb.Append("  VideoRtpTransport: ").Append(VideoRtpTransport).Append("\n");
            sb.Append("  ContentRecvLocalMute: ").Append(ContentRecvLocalMute).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  ContentSend: ").Append(ContentSend).Append("\n");
            sb.Append("  Remoteaddress: ").Append(Remoteaddress).Append("\n");
            sb.Append("  MeetingGuid: ").Append(MeetingGuid).Append("\n");
            sb.Append("  Connecttime: ").Append(Connecttime).Append("\n");
            sb.Append("  Localaddress: ").Append(Localaddress).Append("\n");
            sb.Append("  AudioRemoteAddress: ").Append(AudioRemoteAddress).Append("\n");
            sb.Append("  BondedAudioGuid: ").Append(BondedAudioGuid).Append("\n");
            sb.Append("  AudioRecvRemoteMute: ").Append(AudioRecvRemoteMute).Append("\n");
            sb.Append("  SessionOutRelay: ").Append(SessionOutRelay).Append("\n");
            sb.Append("  Leader: ").Append(Leader).Append("\n");
            sb.Append("  ContentLocalAddress: ").Append(ContentLocalAddress).Append("\n");
            sb.Append("  MovieCapable: ").Append(MovieCapable).Append("\n");
            sb.Append("  VideoRecvLocalMute: ").Append(VideoRecvLocalMute).Append("\n");
            sb.Append("  ContentRtpTransport: ").Append(ContentRtpTransport).Append("\n");
            sb.Append("  RDCVersion: ").Append(RDCVersion).Append("\n");
            sb.Append("  AudioRecv: ").Append(AudioRecv).Append("\n");
            sb.Append("  ContentRelayServer: ").Append(ContentRelayServer).Append("\n");
            sb.Append("  VideoRecv: ").Append(VideoRecv).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Sessionid: ").Append(Sessionid).Append("\n");
            sb.Append("  ContentRtcpRelay: ").Append(ContentRtcpRelay).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
            sb.Append("  Medaddress: ").Append(Medaddress).Append("\n");
            sb.Append("  HtmlLayoutGuid: ").Append(HtmlLayoutGuid).Append("\n");
            sb.Append("  _Endpoint: ").Append(_Endpoint).Append("\n");
            sb.Append("  VideoDrop: ").Append(VideoDrop).Append("\n");
            sb.Append("  ContentRtcpTransport: ").Append(ContentRtcpTransport).Append("\n");
            sb.Append("  VideoRemoteRtcpAddress: ").Append(VideoRemoteRtcpAddress).Append("\n");
            sb.Append("  VideoRtpRelay: ").Append(VideoRtpRelay).Append("\n");
            sb.Append("  Mixaddress: ").Append(Mixaddress).Append("\n");
            sb.Append("  SIPHTTPProxyTransport: ").Append(SIPHTTPProxyTransport).Append("\n");
            sb.Append("  VideoRecvCodec: ").Append(VideoRecvCodec).Append("\n");
            sb.Append("  AudioRecvCodec: ").Append(AudioRecvCodec).Append("\n");
            sb.Append("  SessionIn: ").Append(SessionIn).Append("\n");
            sb.Append("  BondedVideoGuid: ").Append(BondedVideoGuid).Append("\n");
            sb.Append("  CallQuality: ").Append(CallQuality).Append("\n");
            sb.Append("  Meetingjointime: ").Append(Meetingjointime).Append("\n");
            sb.Append("  SessionInRelay: ").Append(SessionInRelay).Append("\n");
            sb.Append("  Pairedremoteaddress: ").Append(Pairedremoteaddress).Append("\n");
            sb.Append("  VideoSendHeight: ").Append(VideoSendHeight).Append("\n");
            sb.Append("  VideoRecvHeight: ").Append(VideoRecvHeight).Append("\n");
            sb.Append("  SecureCall: ").Append(SecureCall).Append("\n");
            sb.Append("  VideoLocalRtcpAddress: ").Append(VideoLocalRtcpAddress).Append("\n");
            sb.Append("  AudioPlayName: ").Append(AudioPlayName).Append("\n");
            sb.Append("  VideoCapID: ").Append(VideoCapID).Append("\n");
            sb.Append("  AudioRtpTransport: ").Append(AudioRtpTransport).Append("\n");
            sb.Append("  MeetingInfoMode: ").Append(MeetingInfoMode).Append("\n");
            sb.Append("  Callhostname: ").Append(Callhostname).Append("\n");
            sb.Append("  Callguid: ").Append(Callguid).Append("\n");
            sb.Append("  AudioCapID: ").Append(AudioCapID).Append("\n");
            sb.Append("  VideoSend: ").Append(VideoSend).Append("\n");
            sb.Append("  ContentRecvCodec: ").Append(ContentRecvCodec).Append("\n");
            sb.Append("  SessionRelay: ").Append(SessionRelay).Append("\n");
            sb.Append("  VideoRecvRemoteMute: ").Append(VideoRecvRemoteMute).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BondedVideoName: ").Append(BondedVideoName).Append("\n");
            sb.Append("  IsInRoster: ").Append(IsInRoster).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Endpoint);
        }

        /// <summary>
        /// Returns true if Endpoint instances are equal
        /// </summary>
        /// <param name="other">Instance of Endpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endpoint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EcMode == other.EcMode ||
                    this.EcMode != null &&
                    this.EcMode.Equals(other.EcMode)
                ) && 
                (
                    this.Creationtime == other.Creationtime ||
                    this.Creationtime != null &&
                    this.Creationtime.Equals(other.Creationtime)
                ) && 
                (
                    this.AudioRemoteRtcpAddress == other.AudioRemoteRtcpAddress ||
                    this.AudioRemoteRtcpAddress != null &&
                    this.AudioRemoteRtcpAddress.Equals(other.AudioRemoteRtcpAddress)
                ) && 
                (
                    this.VideoSendCodec == other.VideoSendCodec ||
                    this.VideoSendCodec != null &&
                    this.VideoSendCodec.Equals(other.VideoSendCodec)
                ) && 
                (
                    this.AudioPlayID == other.AudioPlayID ||
                    this.AudioPlayID != null &&
                    this.AudioPlayID.Equals(other.AudioPlayID)
                ) && 
                (
                    this.CallQualityRecv == other.CallQualityRecv ||
                    this.CallQualityRecv != null &&
                    this.CallQualityRecv.Equals(other.CallQualityRecv)
                ) && 
                (
                    this.SessionOut == other.SessionOut ||
                    this.SessionOut != null &&
                    this.SessionOut.Equals(other.SessionOut)
                ) && 
                (
                    this.AudioLocalAddress == other.AudioLocalAddress ||
                    this.AudioLocalAddress != null &&
                    this.AudioLocalAddress.Equals(other.AudioLocalAddress)
                ) && 
                (
                    this.Meetingid == other.Meetingid ||
                    this.Meetingid != null &&
                    this.Meetingid.Equals(other.Meetingid)
                ) && 
                (
                    this.VideoSendWidth == other.VideoSendWidth ||
                    this.VideoSendWidth != null &&
                    this.VideoSendWidth.Equals(other.VideoSendWidth)
                ) && 
                (
                    this.CallQualitySend == other.CallQualitySend ||
                    this.CallQualitySend != null &&
                    this.CallQualitySend.Equals(other.CallQualitySend)
                ) && 
                (
                    this.Mhaddress == other.Mhaddress ||
                    this.Mhaddress != null &&
                    this.Mhaddress.Equals(other.Mhaddress)
                ) && 
                (
                    this.RDCControlleeCapable == other.RDCControlleeCapable ||
                    this.RDCControlleeCapable != null &&
                    this.RDCControlleeCapable.Equals(other.RDCControlleeCapable)
                ) && 
                (
                    this.AudioCapName == other.AudioCapName ||
                    this.AudioCapName != null &&
                    this.AudioCapName.Equals(other.AudioCapName)
                ) && 
                (
                    this.ProxyInfo == other.ProxyInfo ||
                    this.ProxyInfo != null &&
                    this.ProxyInfo.Equals(other.ProxyInfo)
                ) && 
                (
                    this.AudioSendCodec == other.AudioSendCodec ||
                    this.AudioSendCodec != null &&
                    this.AudioSendCodec.Equals(other.AudioSendCodec)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.VideoRecvWidth == other.VideoRecvWidth ||
                    this.VideoRecvWidth != null &&
                    this.VideoRecvWidth.Equals(other.VideoRecvWidth)
                ) && 
                (
                    this.Conaddress == other.Conaddress ||
                    this.Conaddress != null &&
                    this.Conaddress.Equals(other.Conaddress)
                ) && 
                (
                    this.TalkDetected == other.TalkDetected ||
                    this.TalkDetected != null &&
                    this.TalkDetected.Equals(other.TalkDetected)
                ) && 
                (
                    this.SubLayout == other.SubLayout ||
                    this.SubLayout != null &&
                    this.SubLayout.Equals(other.SubLayout)
                ) && 
                (
                    this.AudioRtcpRelay == other.AudioRtcpRelay ||
                    this.AudioRtcpRelay != null &&
                    this.AudioRtcpRelay.Equals(other.AudioRtcpRelay)
                ) && 
                (
                    this.AudioRecvLocalMute == other.AudioRecvLocalMute ||
                    this.AudioRecvLocalMute != null &&
                    this.AudioRecvLocalMute.Equals(other.AudioRecvLocalMute)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.VideoLocalAddress == other.VideoLocalAddress ||
                    this.VideoLocalAddress != null &&
                    this.VideoLocalAddress.Equals(other.VideoLocalAddress)
                ) && 
                (
                    this.AudioLocalRtcpAddress == other.AudioLocalRtcpAddress ||
                    this.AudioLocalRtcpAddress != null &&
                    this.AudioLocalRtcpAddress.Equals(other.AudioLocalRtcpAddress)
                ) && 
                (
                    this.ContentRtpRelay == other.ContentRtpRelay ||
                    this.ContentRtpRelay != null &&
                    this.ContentRtpRelay.Equals(other.ContentRtpRelay)
                ) && 
                (
                    this.ContentLocalRtcpAddress == other.ContentLocalRtcpAddress ||
                    this.ContentLocalRtcpAddress != null &&
                    this.ContentLocalRtcpAddress.Equals(other.ContentLocalRtcpAddress)
                ) && 
                (
                    this.RemoteConnectionCount == other.RemoteConnectionCount ||
                    this.RemoteConnectionCount != null &&
                    this.RemoteConnectionCount.Equals(other.RemoteConnectionCount)
                ) && 
                (
                    this.Callrate == other.Callrate ||
                    this.Callrate != null &&
                    this.Callrate.Equals(other.Callrate)
                ) && 
                (
                    this.MixerGuid == other.MixerGuid ||
                    this.MixerGuid != null &&
                    this.MixerGuid.Equals(other.MixerGuid)
                ) && 
                (
                    this.Transport == other.Transport ||
                    this.Transport != null &&
                    this.Transport.Equals(other.Transport)
                ) && 
                (
                    this.AudioCapSelectID == other.AudioCapSelectID ||
                    this.AudioCapSelectID != null &&
                    this.AudioCapSelectID.Equals(other.AudioCapSelectID)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.RDCControllerCapable == other.RDCControllerCapable ||
                    this.RDCControllerCapable != null &&
                    this.RDCControllerCapable.Equals(other.RDCControllerCapable)
                ) && 
                (
                    this.Pairedname == other.Pairedname ||
                    this.Pairedname != null &&
                    this.Pairedname.Equals(other.Pairedname)
                ) && 
                (
                    this.VideoRtcpRelay == other.VideoRtcpRelay ||
                    this.VideoRtcpRelay != null &&
                    this.VideoRtcpRelay.Equals(other.VideoRtcpRelay)
                ) && 
                (
                    this.EndpointCpuParams == other.EndpointCpuParams ||
                    this.EndpointCpuParams != null &&
                    this.EndpointCpuParams.Equals(other.EndpointCpuParams)
                ) && 
                (
                    this.VideoRemoteAddress == other.VideoRemoteAddress ||
                    this.VideoRemoteAddress != null &&
                    this.VideoRemoteAddress.Equals(other.VideoRemoteAddress)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.ContentRecv == other.ContentRecv ||
                    this.ContentRecv != null &&
                    this.ContentRecv.Equals(other.ContentRecv)
                ) && 
                (
                    this.LocalName == other.LocalName ||
                    this.LocalName != null &&
                    this.LocalName.Equals(other.LocalName)
                ) && 
                (
                    this.BJNUserId == other.BJNUserId ||
                    this.BJNUserId != null &&
                    this.BJNUserId.Equals(other.BJNUserId)
                ) && 
                (
                    this.ContentRemoteAddress == other.ContentRemoteAddress ||
                    this.ContentRemoteAddress != null &&
                    this.ContentRemoteAddress.Equals(other.ContentRemoteAddress)
                ) && 
                (
                    this.AudioSend == other.AudioSend ||
                    this.AudioSend != null &&
                    this.AudioSend.Equals(other.AudioSend)
                ) && 
                (
                    this.ParticipantDTMFMenus == other.ParticipantDTMFMenus ||
                    this.ParticipantDTMFMenus != null &&
                    this.ParticipantDTMFMenus.Equals(other.ParticipantDTMFMenus)
                ) && 
                (
                    this.VideoRtcpTranspor == other.VideoRtcpTranspor ||
                    this.VideoRtcpTranspor != null &&
                    this.VideoRtcpTranspor.Equals(other.VideoRtcpTranspor)
                ) && 
                (
                    this.AudioRtcpTransport == other.AudioRtcpTransport ||
                    this.AudioRtcpTransport != null &&
                    this.AudioRtcpTransport.Equals(other.AudioRtcpTransport)
                ) && 
                (
                    this.RelayNodeId == other.RelayNodeId ||
                    this.RelayNodeId != null &&
                    this.RelayNodeId.Equals(other.RelayNodeId)
                ) && 
                (
                    this.ContentRemoteRtcpAddress == other.ContentRemoteRtcpAddress ||
                    this.ContentRemoteRtcpAddress != null &&
                    this.ContentRemoteRtcpAddress.Equals(other.ContentRemoteRtcpAddress)
                ) && 
                (
                    this.AudioRtpRelay == other.AudioRtpRelay ||
                    this.AudioRtpRelay != null &&
                    this.AudioRtpRelay.Equals(other.AudioRtpRelay)
                ) && 
                (
                    this.VideoRtpTransport == other.VideoRtpTransport ||
                    this.VideoRtpTransport != null &&
                    this.VideoRtpTransport.Equals(other.VideoRtpTransport)
                ) && 
                (
                    this.ContentRecvLocalMute == other.ContentRecvLocalMute ||
                    this.ContentRecvLocalMute != null &&
                    this.ContentRecvLocalMute.Equals(other.ContentRecvLocalMute)
                ) && 
                (
                    this.Layout == other.Layout ||
                    this.Layout != null &&
                    this.Layout.Equals(other.Layout)
                ) && 
                (
                    this.ContentSend == other.ContentSend ||
                    this.ContentSend != null &&
                    this.ContentSend.Equals(other.ContentSend)
                ) && 
                (
                    this.Remoteaddress == other.Remoteaddress ||
                    this.Remoteaddress != null &&
                    this.Remoteaddress.Equals(other.Remoteaddress)
                ) && 
                (
                    this.MeetingGuid == other.MeetingGuid ||
                    this.MeetingGuid != null &&
                    this.MeetingGuid.Equals(other.MeetingGuid)
                ) && 
                (
                    this.Connecttime == other.Connecttime ||
                    this.Connecttime != null &&
                    this.Connecttime.Equals(other.Connecttime)
                ) && 
                (
                    this.Localaddress == other.Localaddress ||
                    this.Localaddress != null &&
                    this.Localaddress.Equals(other.Localaddress)
                ) && 
                (
                    this.AudioRemoteAddress == other.AudioRemoteAddress ||
                    this.AudioRemoteAddress != null &&
                    this.AudioRemoteAddress.Equals(other.AudioRemoteAddress)
                ) && 
                (
                    this.BondedAudioGuid == other.BondedAudioGuid ||
                    this.BondedAudioGuid != null &&
                    this.BondedAudioGuid.Equals(other.BondedAudioGuid)
                ) && 
                (
                    this.AudioRecvRemoteMute == other.AudioRecvRemoteMute ||
                    this.AudioRecvRemoteMute != null &&
                    this.AudioRecvRemoteMute.Equals(other.AudioRecvRemoteMute)
                ) && 
                (
                    this.SessionOutRelay == other.SessionOutRelay ||
                    this.SessionOutRelay != null &&
                    this.SessionOutRelay.Equals(other.SessionOutRelay)
                ) && 
                (
                    this.Leader == other.Leader ||
                    this.Leader != null &&
                    this.Leader.Equals(other.Leader)
                ) && 
                (
                    this.ContentLocalAddress == other.ContentLocalAddress ||
                    this.ContentLocalAddress != null &&
                    this.ContentLocalAddress.Equals(other.ContentLocalAddress)
                ) && 
                (
                    this.MovieCapable == other.MovieCapable ||
                    this.MovieCapable != null &&
                    this.MovieCapable.Equals(other.MovieCapable)
                ) && 
                (
                    this.VideoRecvLocalMute == other.VideoRecvLocalMute ||
                    this.VideoRecvLocalMute != null &&
                    this.VideoRecvLocalMute.Equals(other.VideoRecvLocalMute)
                ) && 
                (
                    this.ContentRtpTransport == other.ContentRtpTransport ||
                    this.ContentRtpTransport != null &&
                    this.ContentRtpTransport.Equals(other.ContentRtpTransport)
                ) && 
                (
                    this.RDCVersion == other.RDCVersion ||
                    this.RDCVersion != null &&
                    this.RDCVersion.Equals(other.RDCVersion)
                ) && 
                (
                    this.AudioRecv == other.AudioRecv ||
                    this.AudioRecv != null &&
                    this.AudioRecv.Equals(other.AudioRecv)
                ) && 
                (
                    this.ContentRelayServer == other.ContentRelayServer ||
                    this.ContentRelayServer != null &&
                    this.ContentRelayServer.Equals(other.ContentRelayServer)
                ) && 
                (
                    this.VideoRecv == other.VideoRecv ||
                    this.VideoRecv != null &&
                    this.VideoRecv.Equals(other.VideoRecv)
                ) && 
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
                ) && 
                (
                    this.Sessionid == other.Sessionid ||
                    this.Sessionid != null &&
                    this.Sessionid.Equals(other.Sessionid)
                ) && 
                (
                    this.ContentRtcpRelay == other.ContentRtcpRelay ||
                    this.ContentRtcpRelay != null &&
                    this.ContentRtcpRelay.Equals(other.ContentRtcpRelay)
                ) && 
                (
                    this.Locales == other.Locales ||
                    this.Locales != null &&
                    this.Locales.Equals(other.Locales)
                ) && 
                (
                    this.Medaddress == other.Medaddress ||
                    this.Medaddress != null &&
                    this.Medaddress.Equals(other.Medaddress)
                ) && 
                (
                    this.HtmlLayoutGuid == other.HtmlLayoutGuid ||
                    this.HtmlLayoutGuid != null &&
                    this.HtmlLayoutGuid.Equals(other.HtmlLayoutGuid)
                ) && 
                (
                    this._Endpoint == other._Endpoint ||
                    this._Endpoint != null &&
                    this._Endpoint.Equals(other._Endpoint)
                ) && 
                (
                    this.VideoDrop == other.VideoDrop ||
                    this.VideoDrop != null &&
                    this.VideoDrop.Equals(other.VideoDrop)
                ) && 
                (
                    this.ContentRtcpTransport == other.ContentRtcpTransport ||
                    this.ContentRtcpTransport != null &&
                    this.ContentRtcpTransport.Equals(other.ContentRtcpTransport)
                ) && 
                (
                    this.VideoRemoteRtcpAddress == other.VideoRemoteRtcpAddress ||
                    this.VideoRemoteRtcpAddress != null &&
                    this.VideoRemoteRtcpAddress.Equals(other.VideoRemoteRtcpAddress)
                ) && 
                (
                    this.VideoRtpRelay == other.VideoRtpRelay ||
                    this.VideoRtpRelay != null &&
                    this.VideoRtpRelay.Equals(other.VideoRtpRelay)
                ) && 
                (
                    this.Mixaddress == other.Mixaddress ||
                    this.Mixaddress != null &&
                    this.Mixaddress.Equals(other.Mixaddress)
                ) && 
                (
                    this.SIPHTTPProxyTransport == other.SIPHTTPProxyTransport ||
                    this.SIPHTTPProxyTransport != null &&
                    this.SIPHTTPProxyTransport.Equals(other.SIPHTTPProxyTransport)
                ) && 
                (
                    this.VideoRecvCodec == other.VideoRecvCodec ||
                    this.VideoRecvCodec != null &&
                    this.VideoRecvCodec.Equals(other.VideoRecvCodec)
                ) && 
                (
                    this.AudioRecvCodec == other.AudioRecvCodec ||
                    this.AudioRecvCodec != null &&
                    this.AudioRecvCodec.Equals(other.AudioRecvCodec)
                ) && 
                (
                    this.SessionIn == other.SessionIn ||
                    this.SessionIn != null &&
                    this.SessionIn.Equals(other.SessionIn)
                ) && 
                (
                    this.BondedVideoGuid == other.BondedVideoGuid ||
                    this.BondedVideoGuid != null &&
                    this.BondedVideoGuid.Equals(other.BondedVideoGuid)
                ) && 
                (
                    this.CallQuality == other.CallQuality ||
                    this.CallQuality != null &&
                    this.CallQuality.Equals(other.CallQuality)
                ) && 
                (
                    this.Meetingjointime == other.Meetingjointime ||
                    this.Meetingjointime != null &&
                    this.Meetingjointime.Equals(other.Meetingjointime)
                ) && 
                (
                    this.SessionInRelay == other.SessionInRelay ||
                    this.SessionInRelay != null &&
                    this.SessionInRelay.Equals(other.SessionInRelay)
                ) && 
                (
                    this.Pairedremoteaddress == other.Pairedremoteaddress ||
                    this.Pairedremoteaddress != null &&
                    this.Pairedremoteaddress.Equals(other.Pairedremoteaddress)
                ) && 
                (
                    this.VideoSendHeight == other.VideoSendHeight ||
                    this.VideoSendHeight != null &&
                    this.VideoSendHeight.Equals(other.VideoSendHeight)
                ) && 
                (
                    this.VideoRecvHeight == other.VideoRecvHeight ||
                    this.VideoRecvHeight != null &&
                    this.VideoRecvHeight.Equals(other.VideoRecvHeight)
                ) && 
                (
                    this.SecureCall == other.SecureCall ||
                    this.SecureCall != null &&
                    this.SecureCall.Equals(other.SecureCall)
                ) && 
                (
                    this.VideoLocalRtcpAddress == other.VideoLocalRtcpAddress ||
                    this.VideoLocalRtcpAddress != null &&
                    this.VideoLocalRtcpAddress.Equals(other.VideoLocalRtcpAddress)
                ) && 
                (
                    this.AudioPlayName == other.AudioPlayName ||
                    this.AudioPlayName != null &&
                    this.AudioPlayName.Equals(other.AudioPlayName)
                ) && 
                (
                    this.VideoCapID == other.VideoCapID ||
                    this.VideoCapID != null &&
                    this.VideoCapID.Equals(other.VideoCapID)
                ) && 
                (
                    this.AudioRtpTransport == other.AudioRtpTransport ||
                    this.AudioRtpTransport != null &&
                    this.AudioRtpTransport.Equals(other.AudioRtpTransport)
                ) && 
                (
                    this.MeetingInfoMode == other.MeetingInfoMode ||
                    this.MeetingInfoMode != null &&
                    this.MeetingInfoMode.Equals(other.MeetingInfoMode)
                ) && 
                (
                    this.Callhostname == other.Callhostname ||
                    this.Callhostname != null &&
                    this.Callhostname.Equals(other.Callhostname)
                ) && 
                (
                    this.Callguid == other.Callguid ||
                    this.Callguid != null &&
                    this.Callguid.Equals(other.Callguid)
                ) && 
                (
                    this.AudioCapID == other.AudioCapID ||
                    this.AudioCapID != null &&
                    this.AudioCapID.Equals(other.AudioCapID)
                ) && 
                (
                    this.VideoSend == other.VideoSend ||
                    this.VideoSend != null &&
                    this.VideoSend.Equals(other.VideoSend)
                ) && 
                (
                    this.ContentRecvCodec == other.ContentRecvCodec ||
                    this.ContentRecvCodec != null &&
                    this.ContentRecvCodec.Equals(other.ContentRecvCodec)
                ) && 
                (
                    this.SessionRelay == other.SessionRelay ||
                    this.SessionRelay != null &&
                    this.SessionRelay.Equals(other.SessionRelay)
                ) && 
                (
                    this.VideoRecvRemoteMute == other.VideoRecvRemoteMute ||
                    this.VideoRecvRemoteMute != null &&
                    this.VideoRecvRemoteMute.Equals(other.VideoRecvRemoteMute)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.BondedVideoName == other.BondedVideoName ||
                    this.BondedVideoName != null &&
                    this.BondedVideoName.Equals(other.BondedVideoName)
                ) && 
                (
                    this.IsInRoster == other.IsInRoster ||
                    this.IsInRoster != null &&
                    this.IsInRoster.Equals(other.IsInRoster)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.EcMode != null)
                    hash = hash * 59 + this.EcMode.GetHashCode();
                if (this.Creationtime != null)
                    hash = hash * 59 + this.Creationtime.GetHashCode();
                if (this.AudioRemoteRtcpAddress != null)
                    hash = hash * 59 + this.AudioRemoteRtcpAddress.GetHashCode();
                if (this.VideoSendCodec != null)
                    hash = hash * 59 + this.VideoSendCodec.GetHashCode();
                if (this.AudioPlayID != null)
                    hash = hash * 59 + this.AudioPlayID.GetHashCode();
                if (this.CallQualityRecv != null)
                    hash = hash * 59 + this.CallQualityRecv.GetHashCode();
                if (this.SessionOut != null)
                    hash = hash * 59 + this.SessionOut.GetHashCode();
                if (this.AudioLocalAddress != null)
                    hash = hash * 59 + this.AudioLocalAddress.GetHashCode();
                if (this.Meetingid != null)
                    hash = hash * 59 + this.Meetingid.GetHashCode();
                if (this.VideoSendWidth != null)
                    hash = hash * 59 + this.VideoSendWidth.GetHashCode();
                if (this.CallQualitySend != null)
                    hash = hash * 59 + this.CallQualitySend.GetHashCode();
                if (this.Mhaddress != null)
                    hash = hash * 59 + this.Mhaddress.GetHashCode();
                if (this.RDCControlleeCapable != null)
                    hash = hash * 59 + this.RDCControlleeCapable.GetHashCode();
                if (this.AudioCapName != null)
                    hash = hash * 59 + this.AudioCapName.GetHashCode();
                if (this.ProxyInfo != null)
                    hash = hash * 59 + this.ProxyInfo.GetHashCode();
                if (this.AudioSendCodec != null)
                    hash = hash * 59 + this.AudioSendCodec.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                if (this.VideoRecvWidth != null)
                    hash = hash * 59 + this.VideoRecvWidth.GetHashCode();
                if (this.Conaddress != null)
                    hash = hash * 59 + this.Conaddress.GetHashCode();
                if (this.TalkDetected != null)
                    hash = hash * 59 + this.TalkDetected.GetHashCode();
                if (this.SubLayout != null)
                    hash = hash * 59 + this.SubLayout.GetHashCode();
                if (this.AudioRtcpRelay != null)
                    hash = hash * 59 + this.AudioRtcpRelay.GetHashCode();
                if (this.AudioRecvLocalMute != null)
                    hash = hash * 59 + this.AudioRecvLocalMute.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.VideoLocalAddress != null)
                    hash = hash * 59 + this.VideoLocalAddress.GetHashCode();
                if (this.AudioLocalRtcpAddress != null)
                    hash = hash * 59 + this.AudioLocalRtcpAddress.GetHashCode();
                if (this.ContentRtpRelay != null)
                    hash = hash * 59 + this.ContentRtpRelay.GetHashCode();
                if (this.ContentLocalRtcpAddress != null)
                    hash = hash * 59 + this.ContentLocalRtcpAddress.GetHashCode();
                if (this.RemoteConnectionCount != null)
                    hash = hash * 59 + this.RemoteConnectionCount.GetHashCode();
                if (this.Callrate != null)
                    hash = hash * 59 + this.Callrate.GetHashCode();
                if (this.MixerGuid != null)
                    hash = hash * 59 + this.MixerGuid.GetHashCode();
                if (this.Transport != null)
                    hash = hash * 59 + this.Transport.GetHashCode();
                if (this.AudioCapSelectID != null)
                    hash = hash * 59 + this.AudioCapSelectID.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.RDCControllerCapable != null)
                    hash = hash * 59 + this.RDCControllerCapable.GetHashCode();
                if (this.Pairedname != null)
                    hash = hash * 59 + this.Pairedname.GetHashCode();
                if (this.VideoRtcpRelay != null)
                    hash = hash * 59 + this.VideoRtcpRelay.GetHashCode();
                if (this.EndpointCpuParams != null)
                    hash = hash * 59 + this.EndpointCpuParams.GetHashCode();
                if (this.VideoRemoteAddress != null)
                    hash = hash * 59 + this.VideoRemoteAddress.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.ContentRecv != null)
                    hash = hash * 59 + this.ContentRecv.GetHashCode();
                if (this.LocalName != null)
                    hash = hash * 59 + this.LocalName.GetHashCode();
                if (this.BJNUserId != null)
                    hash = hash * 59 + this.BJNUserId.GetHashCode();
                if (this.ContentRemoteAddress != null)
                    hash = hash * 59 + this.ContentRemoteAddress.GetHashCode();
                if (this.AudioSend != null)
                    hash = hash * 59 + this.AudioSend.GetHashCode();
                if (this.ParticipantDTMFMenus != null)
                    hash = hash * 59 + this.ParticipantDTMFMenus.GetHashCode();
                if (this.VideoRtcpTranspor != null)
                    hash = hash * 59 + this.VideoRtcpTranspor.GetHashCode();
                if (this.AudioRtcpTransport != null)
                    hash = hash * 59 + this.AudioRtcpTransport.GetHashCode();
                if (this.RelayNodeId != null)
                    hash = hash * 59 + this.RelayNodeId.GetHashCode();
                if (this.ContentRemoteRtcpAddress != null)
                    hash = hash * 59 + this.ContentRemoteRtcpAddress.GetHashCode();
                if (this.AudioRtpRelay != null)
                    hash = hash * 59 + this.AudioRtpRelay.GetHashCode();
                if (this.VideoRtpTransport != null)
                    hash = hash * 59 + this.VideoRtpTransport.GetHashCode();
                if (this.ContentRecvLocalMute != null)
                    hash = hash * 59 + this.ContentRecvLocalMute.GetHashCode();
                if (this.Layout != null)
                    hash = hash * 59 + this.Layout.GetHashCode();
                if (this.ContentSend != null)
                    hash = hash * 59 + this.ContentSend.GetHashCode();
                if (this.Remoteaddress != null)
                    hash = hash * 59 + this.Remoteaddress.GetHashCode();
                if (this.MeetingGuid != null)
                    hash = hash * 59 + this.MeetingGuid.GetHashCode();
                if (this.Connecttime != null)
                    hash = hash * 59 + this.Connecttime.GetHashCode();
                if (this.Localaddress != null)
                    hash = hash * 59 + this.Localaddress.GetHashCode();
                if (this.AudioRemoteAddress != null)
                    hash = hash * 59 + this.AudioRemoteAddress.GetHashCode();
                if (this.BondedAudioGuid != null)
                    hash = hash * 59 + this.BondedAudioGuid.GetHashCode();
                if (this.AudioRecvRemoteMute != null)
                    hash = hash * 59 + this.AudioRecvRemoteMute.GetHashCode();
                if (this.SessionOutRelay != null)
                    hash = hash * 59 + this.SessionOutRelay.GetHashCode();
                if (this.Leader != null)
                    hash = hash * 59 + this.Leader.GetHashCode();
                if (this.ContentLocalAddress != null)
                    hash = hash * 59 + this.ContentLocalAddress.GetHashCode();
                if (this.MovieCapable != null)
                    hash = hash * 59 + this.MovieCapable.GetHashCode();
                if (this.VideoRecvLocalMute != null)
                    hash = hash * 59 + this.VideoRecvLocalMute.GetHashCode();
                if (this.ContentRtpTransport != null)
                    hash = hash * 59 + this.ContentRtpTransport.GetHashCode();
                if (this.RDCVersion != null)
                    hash = hash * 59 + this.RDCVersion.GetHashCode();
                if (this.AudioRecv != null)
                    hash = hash * 59 + this.AudioRecv.GetHashCode();
                if (this.ContentRelayServer != null)
                    hash = hash * 59 + this.ContentRelayServer.GetHashCode();
                if (this.VideoRecv != null)
                    hash = hash * 59 + this.VideoRecv.GetHashCode();
                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();
                if (this.Sessionid != null)
                    hash = hash * 59 + this.Sessionid.GetHashCode();
                if (this.ContentRtcpRelay != null)
                    hash = hash * 59 + this.ContentRtcpRelay.GetHashCode();
                if (this.Locales != null)
                    hash = hash * 59 + this.Locales.GetHashCode();
                if (this.Medaddress != null)
                    hash = hash * 59 + this.Medaddress.GetHashCode();
                if (this.HtmlLayoutGuid != null)
                    hash = hash * 59 + this.HtmlLayoutGuid.GetHashCode();
                if (this._Endpoint != null)
                    hash = hash * 59 + this._Endpoint.GetHashCode();
                if (this.VideoDrop != null)
                    hash = hash * 59 + this.VideoDrop.GetHashCode();
                if (this.ContentRtcpTransport != null)
                    hash = hash * 59 + this.ContentRtcpTransport.GetHashCode();
                if (this.VideoRemoteRtcpAddress != null)
                    hash = hash * 59 + this.VideoRemoteRtcpAddress.GetHashCode();
                if (this.VideoRtpRelay != null)
                    hash = hash * 59 + this.VideoRtpRelay.GetHashCode();
                if (this.Mixaddress != null)
                    hash = hash * 59 + this.Mixaddress.GetHashCode();
                if (this.SIPHTTPProxyTransport != null)
                    hash = hash * 59 + this.SIPHTTPProxyTransport.GetHashCode();
                if (this.VideoRecvCodec != null)
                    hash = hash * 59 + this.VideoRecvCodec.GetHashCode();
                if (this.AudioRecvCodec != null)
                    hash = hash * 59 + this.AudioRecvCodec.GetHashCode();
                if (this.SessionIn != null)
                    hash = hash * 59 + this.SessionIn.GetHashCode();
                if (this.BondedVideoGuid != null)
                    hash = hash * 59 + this.BondedVideoGuid.GetHashCode();
                if (this.CallQuality != null)
                    hash = hash * 59 + this.CallQuality.GetHashCode();
                if (this.Meetingjointime != null)
                    hash = hash * 59 + this.Meetingjointime.GetHashCode();
                if (this.SessionInRelay != null)
                    hash = hash * 59 + this.SessionInRelay.GetHashCode();
                if (this.Pairedremoteaddress != null)
                    hash = hash * 59 + this.Pairedremoteaddress.GetHashCode();
                if (this.VideoSendHeight != null)
                    hash = hash * 59 + this.VideoSendHeight.GetHashCode();
                if (this.VideoRecvHeight != null)
                    hash = hash * 59 + this.VideoRecvHeight.GetHashCode();
                if (this.SecureCall != null)
                    hash = hash * 59 + this.SecureCall.GetHashCode();
                if (this.VideoLocalRtcpAddress != null)
                    hash = hash * 59 + this.VideoLocalRtcpAddress.GetHashCode();
                if (this.AudioPlayName != null)
                    hash = hash * 59 + this.AudioPlayName.GetHashCode();
                if (this.VideoCapID != null)
                    hash = hash * 59 + this.VideoCapID.GetHashCode();
                if (this.AudioRtpTransport != null)
                    hash = hash * 59 + this.AudioRtpTransport.GetHashCode();
                if (this.MeetingInfoMode != null)
                    hash = hash * 59 + this.MeetingInfoMode.GetHashCode();
                if (this.Callhostname != null)
                    hash = hash * 59 + this.Callhostname.GetHashCode();
                if (this.Callguid != null)
                    hash = hash * 59 + this.Callguid.GetHashCode();
                if (this.AudioCapID != null)
                    hash = hash * 59 + this.AudioCapID.GetHashCode();
                if (this.VideoSend != null)
                    hash = hash * 59 + this.VideoSend.GetHashCode();
                if (this.ContentRecvCodec != null)
                    hash = hash * 59 + this.ContentRecvCodec.GetHashCode();
                if (this.SessionRelay != null)
                    hash = hash * 59 + this.SessionRelay.GetHashCode();
                if (this.VideoRecvRemoteMute != null)
                    hash = hash * 59 + this.VideoRecvRemoteMute.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.BondedVideoName != null)
                    hash = hash * 59 + this.BondedVideoName.GetHashCode();
                if (this.IsInRoster != null)
                    hash = hash * 59 + this.IsInRoster.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
