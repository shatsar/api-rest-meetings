<?php
/**
 * EndpointIndigoSummaryStats
 *
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansMeetingsRestApi
 * @author   Swaagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans Meetings REST API
 *
 * ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace BlueJeansMeetingsRestApi\Model;

use \ArrayAccess;

/**
 * EndpointIndigoSummaryStats Class Doc Comment
 *
 * @category    Class
 * @package     BlueJeansMeetingsRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EndpointIndigoSummaryStats implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'EndpointIndigo_summaryStats';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'audio_recv_codec' => 'string',
        'audio_send_codec' => 'string',
        'content_recv' => 'bool',
        'content_send' => 'bool',
        'talk_detected' => 'bool',
        'session_relay' => 'bool',
        'session_in_relay' => 'bool',
        'session_out_relay' => 'bool',
        'audio_rtp_relay' => 'bool',
        'call_rate' => 'int',
        'cumul_loss_percent_ai' => 'float',
        'cumul_loss_percent_ao' => 'float',
        'cumul_loss_percent_vi' => 'float',
        'cumul_loss_percent_vo' => 'float',
        'cumul_loss_percent_vic' => 'float',
        'cumul_loss_percent_voc' => 'float',
        'cumul_loss_ai' => 'float',
        'cumul_loss_ao' => 'float',
        'cumul_loss_vi' => 'float',
        'cumul_loss_vo' => 'float',
        'cumul_loss_vic' => 'float',
        'cumul_loss_voc' => 'float',
        'discontinuity_count' => 'float',
        'dropped_packets_ai' => 'float',
        'dropped_packets_vi' => 'float',
        'dropped_packets_vic' => 'float',
        'mix_under_runs_ai' => 'float',
        'network_avg_loss_ai' => 'float',
        'network_avg_loss_ao' => 'float',
        'network_avg_loss_vi' => 'float',
        'network_avg_loss_vo' => 'float',
        'network_cumul_loss_ai' => 'float',
        'network_cumul_loss_ao' => 'float',
        'network_cumul_loss_vi' => 'float',
        'network_cumul_loss_vo' => 'float',
        'network_loss_ai' => 'float',
        'network_loss_ao' => 'float',
        'network_loss_vi' => 'float',
        'network_loss_vo' => 'float',
        'call_quality_min' => 'float',
        'call_quality_max' => 'float',
        'call_quality_avg' => 'float',
        'fps_min_vi' => 'float',
        'fps_min_vo' => 'float',
        'fps_min_vic' => 'float',
        'fps_min_voc' => 'float',
        'fps_max_vi' => 'float',
        'fps_max_vo' => 'float',
        'fps_max_vic' => 'float',
        'fps_max_voc' => 'float',
        'fps_avg_vi' => 'float',
        'fps_avg_vo' => 'float',
        'fps_avg_vic' => 'float',
        'fps_avg_voc' => 'float',
        'bitrate_min_ai' => 'float',
        'bitrate_min_ao' => 'float',
        'bitrate_min_vi' => 'float',
        'bitrate_min_vo' => 'float',
        'bitrate_min_vic' => 'float',
        'bitrate_min_voc' => 'float',
        'bitrate_max_ai' => 'float',
        'bitrate_max_ao' => 'float',
        'bitrate_max_vi' => 'float',
        'bitrate_max_vo' => 'float',
        'bitrate_max_vic' => 'float',
        'bitrate_max_voc' => 'float',
        'bitrate_avg_ai' => 'float',
        'bitrate_avg_ao' => 'float',
        'bitrate_avg_vi' => 'float',
        'bitrate_avg_vo' => 'float',
        'bitrate_avg_vic' => 'float',
        'bitrate_avg_voc' => 'float',
        'jitter_min_ai' => 'float',
        'jitter_min_ao' => 'float',
        'jitter_min_vi' => 'float',
        'jitter_min_vo' => 'float',
        'jitter_min_vic' => 'float',
        'jitter_min_voc' => 'float',
        'jitter_max_ai' => 'float',
        'jitter_max_ao' => 'float',
        'jitter_max_vi' => 'float',
        'jitter_max_vo' => 'float',
        'jitter_max_vic' => 'float',
        'jitter_max_voc' => 'float',
        'jitter_avg_ai' => 'float',
        'jitter_avg_ao' => 'float',
        'jitter_avg_vi' => 'float',
        'jitter_avg_vo' => 'float',
        'jitter_avg_vic' => 'float',
        'jitter_avg_voc' => 'float',
        'max_jitter_min_ai' => 'float',
        'max_jitter_min_vi' => 'float',
        'max_jitter_min_vic' => 'float',
        'max_jitter_max_ai' => 'float',
        'max_jitter_max_vi' => 'float',
        'max_jitter_max_vic' => 'float',
        'max_jitter_avg_ai' => 'float',
        'max_jitter_avg_vi' => 'float',
        'max_jitter_avg_vic' => 'float',
        'video_recv_height_min' => 'float',
        'video_recv_height_max' => 'float',
        'video_recv_width_min' => 'float',
        'video_recv_width_max' => 'float',
        'video_send_height_min' => 'float',
        'video_send_height_max' => 'float',
        'video_send_width_min' => 'float',
        'video_send_width_max' => 'float',
        'content_recv_height_min' => 'float',
        'content_recv_height_max' => 'float',
        'content_recv_width_min' => 'float',
        'content_recv_width_max' => 'float',
        'content_send_height_min' => 'float',
        'content_send_height_max' => 'float',
        'content_send_width_min' => 'float',
        'content_send_width_max' => 'float',
        'round_trip_delay_min' => 'float',
        'round_trip_delay_max' => 'float',
        'round_trip_delay_avg' => 'float',
        'rfactor_min' => 'float',
        'rfactor_max' => 'float',
        'rfactor_avg' => 'float',
        'process_cpu_load_min' => 'float',
        'process_cpu_load_max' => 'float',
        'process_cpu_load_avg' => 'float',
        'system_cpu_load_min' => 'float',
        'system_cpu_load_max' => 'float',
        'system_cpu_load_avg' => 'float',
        'wifi_recv_strength_min' => 'float',
        'wifi_recv_strength_max' => 'float',
        'wifi_recv_strength_avg' => 'float',
        'key_frame_rate_avg_vi' => 'float',
        'key_frame_rate_avg_vo' => 'float',
        'key_frame_rate_avg_vic' => 'float',
        'key_frame_rate_avg_voc' => 'float',
        'key_frame_rate_min_vi' => 'float',
        'key_frame_rate_min_vo' => 'float',
        'key_frame_rate_min_vic' => 'float',
        'key_frame_rate_min_voc' => 'float',
        'key_frame_rate_max_vi' => 'float',
        'key_frame_rate_max_vo' => 'float',
        'key_frame_rate_max_vic' => 'float',
        'key_frame_rate_max_voc' => 'float',
        'round_trip_delay_avg_vo' => 'float',
        'round_trip_delay_avg_voc' => 'float',
        'round_trip_delay_avg_ao' => 'float'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerFormats = [
        'audio_recv_codec' => null,
        'audio_send_codec' => null,
        'content_recv' => null,
        'content_send' => null,
        'talk_detected' => null,
        'session_relay' => null,
        'session_in_relay' => null,
        'session_out_relay' => null,
        'audio_rtp_relay' => null,
        'call_rate' => null,
        'cumul_loss_percent_ai' => null,
        'cumul_loss_percent_ao' => null,
        'cumul_loss_percent_vi' => null,
        'cumul_loss_percent_vo' => null,
        'cumul_loss_percent_vic' => null,
        'cumul_loss_percent_voc' => null,
        'cumul_loss_ai' => null,
        'cumul_loss_ao' => null,
        'cumul_loss_vi' => null,
        'cumul_loss_vo' => null,
        'cumul_loss_vic' => null,
        'cumul_loss_voc' => null,
        'discontinuity_count' => null,
        'dropped_packets_ai' => null,
        'dropped_packets_vi' => null,
        'dropped_packets_vic' => null,
        'mix_under_runs_ai' => null,
        'network_avg_loss_ai' => null,
        'network_avg_loss_ao' => null,
        'network_avg_loss_vi' => null,
        'network_avg_loss_vo' => null,
        'network_cumul_loss_ai' => null,
        'network_cumul_loss_ao' => null,
        'network_cumul_loss_vi' => null,
        'network_cumul_loss_vo' => null,
        'network_loss_ai' => null,
        'network_loss_ao' => null,
        'network_loss_vi' => null,
        'network_loss_vo' => null,
        'call_quality_min' => null,
        'call_quality_max' => null,
        'call_quality_avg' => null,
        'fps_min_vi' => null,
        'fps_min_vo' => null,
        'fps_min_vic' => null,
        'fps_min_voc' => null,
        'fps_max_vi' => null,
        'fps_max_vo' => null,
        'fps_max_vic' => null,
        'fps_max_voc' => null,
        'fps_avg_vi' => null,
        'fps_avg_vo' => null,
        'fps_avg_vic' => null,
        'fps_avg_voc' => null,
        'bitrate_min_ai' => null,
        'bitrate_min_ao' => null,
        'bitrate_min_vi' => null,
        'bitrate_min_vo' => null,
        'bitrate_min_vic' => null,
        'bitrate_min_voc' => null,
        'bitrate_max_ai' => null,
        'bitrate_max_ao' => null,
        'bitrate_max_vi' => null,
        'bitrate_max_vo' => null,
        'bitrate_max_vic' => null,
        'bitrate_max_voc' => null,
        'bitrate_avg_ai' => null,
        'bitrate_avg_ao' => null,
        'bitrate_avg_vi' => null,
        'bitrate_avg_vo' => null,
        'bitrate_avg_vic' => null,
        'bitrate_avg_voc' => null,
        'jitter_min_ai' => null,
        'jitter_min_ao' => null,
        'jitter_min_vi' => null,
        'jitter_min_vo' => null,
        'jitter_min_vic' => null,
        'jitter_min_voc' => null,
        'jitter_max_ai' => null,
        'jitter_max_ao' => null,
        'jitter_max_vi' => null,
        'jitter_max_vo' => null,
        'jitter_max_vic' => null,
        'jitter_max_voc' => null,
        'jitter_avg_ai' => null,
        'jitter_avg_ao' => null,
        'jitter_avg_vi' => null,
        'jitter_avg_vo' => null,
        'jitter_avg_vic' => null,
        'jitter_avg_voc' => null,
        'max_jitter_min_ai' => null,
        'max_jitter_min_vi' => null,
        'max_jitter_min_vic' => null,
        'max_jitter_max_ai' => null,
        'max_jitter_max_vi' => null,
        'max_jitter_max_vic' => null,
        'max_jitter_avg_ai' => null,
        'max_jitter_avg_vi' => null,
        'max_jitter_avg_vic' => null,
        'video_recv_height_min' => null,
        'video_recv_height_max' => null,
        'video_recv_width_min' => null,
        'video_recv_width_max' => null,
        'video_send_height_min' => null,
        'video_send_height_max' => null,
        'video_send_width_min' => null,
        'video_send_width_max' => null,
        'content_recv_height_min' => null,
        'content_recv_height_max' => null,
        'content_recv_width_min' => null,
        'content_recv_width_max' => null,
        'content_send_height_min' => null,
        'content_send_height_max' => null,
        'content_send_width_min' => null,
        'content_send_width_max' => null,
        'round_trip_delay_min' => null,
        'round_trip_delay_max' => null,
        'round_trip_delay_avg' => null,
        'rfactor_min' => null,
        'rfactor_max' => null,
        'rfactor_avg' => null,
        'process_cpu_load_min' => null,
        'process_cpu_load_max' => null,
        'process_cpu_load_avg' => null,
        'system_cpu_load_min' => null,
        'system_cpu_load_max' => null,
        'system_cpu_load_avg' => null,
        'wifi_recv_strength_min' => null,
        'wifi_recv_strength_max' => null,
        'wifi_recv_strength_avg' => null,
        'key_frame_rate_avg_vi' => null,
        'key_frame_rate_avg_vo' => null,
        'key_frame_rate_avg_vic' => null,
        'key_frame_rate_avg_voc' => null,
        'key_frame_rate_min_vi' => null,
        'key_frame_rate_min_vo' => null,
        'key_frame_rate_min_vic' => null,
        'key_frame_rate_min_voc' => null,
        'key_frame_rate_max_vi' => null,
        'key_frame_rate_max_vo' => null,
        'key_frame_rate_max_vic' => null,
        'key_frame_rate_max_voc' => null,
        'round_trip_delay_avg_vo' => null,
        'round_trip_delay_avg_voc' => null,
        'round_trip_delay_avg_ao' => null
    ];

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = [
        'audio_recv_codec' => 'audioRecvCodec',
        'audio_send_codec' => 'audioSendCodec',
        'content_recv' => 'contentRecv',
        'content_send' => 'contentSend',
        'talk_detected' => 'talkDetected',
        'session_relay' => 'sessionRelay',
        'session_in_relay' => 'sessionInRelay',
        'session_out_relay' => 'sessionOutRelay',
        'audio_rtp_relay' => 'audioRtpRelay',
        'call_rate' => 'callRate',
        'cumul_loss_percent_ai' => 'cumulLoss_Percent_AI',
        'cumul_loss_percent_ao' => 'cumulLoss_Percent_AO',
        'cumul_loss_percent_vi' => 'cumulLoss_Percent_VI',
        'cumul_loss_percent_vo' => 'cumulLoss_Percent_VO',
        'cumul_loss_percent_vic' => 'cumulLoss_Percent_VIC',
        'cumul_loss_percent_voc' => 'cumulLoss_Percent_VOC',
        'cumul_loss_ai' => 'cumulLoss_AI',
        'cumul_loss_ao' => 'cumulLoss_AO',
        'cumul_loss_vi' => 'cumulLoss_VI',
        'cumul_loss_vo' => 'cumulLoss_VO',
        'cumul_loss_vic' => 'cumulLoss_VIC',
        'cumul_loss_voc' => 'cumulLoss_VOC',
        'discontinuity_count' => 'discontinuityCount',
        'dropped_packets_ai' => 'droppedPackets_AI',
        'dropped_packets_vi' => 'droppedPackets_VI',
        'dropped_packets_vic' => 'droppedPackets_VIC',
        'mix_under_runs_ai' => 'mixUnderRuns_AI',
        'network_avg_loss_ai' => 'networkAvgLoss_AI',
        'network_avg_loss_ao' => 'networkAvgLoss_AO',
        'network_avg_loss_vi' => 'networkAvgLoss_VI',
        'network_avg_loss_vo' => 'networkAvgLoss_VO',
        'network_cumul_loss_ai' => 'networkCumulLoss_AI',
        'network_cumul_loss_ao' => 'networkCumulLoss_AO',
        'network_cumul_loss_vi' => 'networkCumulLoss_VI',
        'network_cumul_loss_vo' => 'networkCumulLoss_VO',
        'network_loss_ai' => 'networkLoss_AI',
        'network_loss_ao' => 'networkLoss_AO',
        'network_loss_vi' => 'networkLoss_VI',
        'network_loss_vo' => 'networkLoss_VO',
        'call_quality_min' => 'callQuality_Min',
        'call_quality_max' => 'callQuality_Max',
        'call_quality_avg' => 'callQuality_Avg',
        'fps_min_vi' => 'fps_Min_VI',
        'fps_min_vo' => 'fps_Min_VO',
        'fps_min_vic' => 'fps_Min_VIC',
        'fps_min_voc' => 'fps_Min_VOC',
        'fps_max_vi' => 'fps_Max_VI',
        'fps_max_vo' => 'fps_Max_VO',
        'fps_max_vic' => 'fps_Max_VIC',
        'fps_max_voc' => 'fps_Max_VOC',
        'fps_avg_vi' => 'fps_Avg_VI',
        'fps_avg_vo' => 'fps_Avg_VO',
        'fps_avg_vic' => 'fps_Avg_VIC',
        'fps_avg_voc' => 'fps_Avg_VOC',
        'bitrate_min_ai' => 'bitrate_Min_AI',
        'bitrate_min_ao' => 'bitrate_Min_AO',
        'bitrate_min_vi' => 'bitrate_Min_VI',
        'bitrate_min_vo' => 'bitrate_Min_VO',
        'bitrate_min_vic' => 'bitrate_Min_VIC',
        'bitrate_min_voc' => 'bitrate_Min_VOC',
        'bitrate_max_ai' => 'bitrate_Max_AI',
        'bitrate_max_ao' => 'bitrate_Max_AO',
        'bitrate_max_vi' => 'bitrate_Max_VI',
        'bitrate_max_vo' => 'bitrate_Max_VO',
        'bitrate_max_vic' => 'bitrate_Max_VIC',
        'bitrate_max_voc' => 'bitrate_Max_VOC',
        'bitrate_avg_ai' => 'bitrate_Avg_AI',
        'bitrate_avg_ao' => 'bitrate_Avg_AO',
        'bitrate_avg_vi' => 'bitrate_Avg_VI',
        'bitrate_avg_vo' => 'bitrate_Avg_VO',
        'bitrate_avg_vic' => 'bitrate_Avg_VIC',
        'bitrate_avg_voc' => 'bitrate_Avg_VOC',
        'jitter_min_ai' => 'jitter_Min_AI',
        'jitter_min_ao' => 'jitter_Min_AO',
        'jitter_min_vi' => 'jitter_Min_VI',
        'jitter_min_vo' => 'jitter_Min_VO',
        'jitter_min_vic' => 'jitter_Min_VIC',
        'jitter_min_voc' => 'jitter_Min_VOC',
        'jitter_max_ai' => 'jitter_Max_AI',
        'jitter_max_ao' => 'jitter_Max_AO',
        'jitter_max_vi' => 'jitter_Max_VI',
        'jitter_max_vo' => 'jitter_Max_VO',
        'jitter_max_vic' => 'jitter_Max_VIC',
        'jitter_max_voc' => 'jitter_Max_VOC',
        'jitter_avg_ai' => 'jitter_Avg_AI',
        'jitter_avg_ao' => 'jitter_Avg_AO',
        'jitter_avg_vi' => 'jitter_Avg_VI',
        'jitter_avg_vo' => 'jitter_Avg_VO',
        'jitter_avg_vic' => 'jitter_Avg_VIC',
        'jitter_avg_voc' => 'jitter_Avg_VOC',
        'max_jitter_min_ai' => 'maxJitter_Min_AI',
        'max_jitter_min_vi' => 'maxJitter_Min_VI',
        'max_jitter_min_vic' => 'maxJitter_Min_VIC',
        'max_jitter_max_ai' => 'maxJitter_Max_AI',
        'max_jitter_max_vi' => 'maxJitter_Max_VI',
        'max_jitter_max_vic' => 'maxJitter_Max_VIC',
        'max_jitter_avg_ai' => 'maxJitter_Avg_AI',
        'max_jitter_avg_vi' => 'maxJitter_Avg_VI',
        'max_jitter_avg_vic' => 'maxJitter_Avg_VIC',
        'video_recv_height_min' => 'videoRecvHeight_Min',
        'video_recv_height_max' => 'videoRecvHeight_Max',
        'video_recv_width_min' => 'videoRecvWidth_Min',
        'video_recv_width_max' => 'videoRecvWidth_Max',
        'video_send_height_min' => 'videoSendHeight_Min',
        'video_send_height_max' => 'videoSendHeight_Max',
        'video_send_width_min' => 'videoSendWidth_Min',
        'video_send_width_max' => 'videoSendWidth_Max',
        'content_recv_height_min' => 'contentRecvHeight_Min',
        'content_recv_height_max' => 'contentRecvHeight_Max',
        'content_recv_width_min' => 'contentRecvWidth_Min',
        'content_recv_width_max' => 'contentRecvWidth_Max',
        'content_send_height_min' => 'contentSendHeight_Min',
        'content_send_height_max' => 'contentSendHeight_Max',
        'content_send_width_min' => 'contentSendWidth_Min',
        'content_send_width_max' => 'contentSendWidth_Max',
        'round_trip_delay_min' => 'roundTripDelay_Min',
        'round_trip_delay_max' => 'roundTripDelay_Max',
        'round_trip_delay_avg' => 'roundTripDelay_Avg',
        'rfactor_min' => 'rfactor_Min',
        'rfactor_max' => 'rfactor_Max',
        'rfactor_avg' => 'rfactor_Avg',
        'process_cpu_load_min' => 'processCpuLoad_Min',
        'process_cpu_load_max' => 'processCpuLoad_Max',
        'process_cpu_load_avg' => 'processCpuLoad_Avg',
        'system_cpu_load_min' => 'systemCpuLoad_Min',
        'system_cpu_load_max' => 'systemCpuLoad_Max',
        'system_cpu_load_avg' => 'systemCpuLoad_Avg',
        'wifi_recv_strength_min' => 'wifiRecvStrength_Min',
        'wifi_recv_strength_max' => 'wifiRecvStrength_Max',
        'wifi_recv_strength_avg' => 'wifiRecvStrength_Avg',
        'key_frame_rate_avg_vi' => 'keyFrameRate_Avg_VI',
        'key_frame_rate_avg_vo' => 'keyFrameRate_Avg_VO',
        'key_frame_rate_avg_vic' => 'keyFrameRate_Avg_VIC',
        'key_frame_rate_avg_voc' => 'keyFrameRate_Avg_VOC',
        'key_frame_rate_min_vi' => 'keyFrameRate_Min_VI',
        'key_frame_rate_min_vo' => 'keyFrameRate_Min_VO',
        'key_frame_rate_min_vic' => 'keyFrameRate_Min_VIC',
        'key_frame_rate_min_voc' => 'keyFrameRate_Min_VOC',
        'key_frame_rate_max_vi' => 'keyFrameRate_Max_VI',
        'key_frame_rate_max_vo' => 'keyFrameRate_Max_VO',
        'key_frame_rate_max_vic' => 'keyFrameRate_Max_VIC',
        'key_frame_rate_max_voc' => 'keyFrameRate_Max_VOC',
        'round_trip_delay_avg_vo' => 'roundTripDelay_Avg_VO',
        'round_trip_delay_avg_voc' => 'roundTripDelay_Avg_VOC',
        'round_trip_delay_avg_ao' => 'roundTripDelay_Avg_AO'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'audio_recv_codec' => 'setAudioRecvCodec',
        'audio_send_codec' => 'setAudioSendCodec',
        'content_recv' => 'setContentRecv',
        'content_send' => 'setContentSend',
        'talk_detected' => 'setTalkDetected',
        'session_relay' => 'setSessionRelay',
        'session_in_relay' => 'setSessionInRelay',
        'session_out_relay' => 'setSessionOutRelay',
        'audio_rtp_relay' => 'setAudioRtpRelay',
        'call_rate' => 'setCallRate',
        'cumul_loss_percent_ai' => 'setCumulLossPercentAi',
        'cumul_loss_percent_ao' => 'setCumulLossPercentAo',
        'cumul_loss_percent_vi' => 'setCumulLossPercentVi',
        'cumul_loss_percent_vo' => 'setCumulLossPercentVo',
        'cumul_loss_percent_vic' => 'setCumulLossPercentVic',
        'cumul_loss_percent_voc' => 'setCumulLossPercentVoc',
        'cumul_loss_ai' => 'setCumulLossAi',
        'cumul_loss_ao' => 'setCumulLossAo',
        'cumul_loss_vi' => 'setCumulLossVi',
        'cumul_loss_vo' => 'setCumulLossVo',
        'cumul_loss_vic' => 'setCumulLossVic',
        'cumul_loss_voc' => 'setCumulLossVoc',
        'discontinuity_count' => 'setDiscontinuityCount',
        'dropped_packets_ai' => 'setDroppedPacketsAi',
        'dropped_packets_vi' => 'setDroppedPacketsVi',
        'dropped_packets_vic' => 'setDroppedPacketsVic',
        'mix_under_runs_ai' => 'setMixUnderRunsAi',
        'network_avg_loss_ai' => 'setNetworkAvgLossAi',
        'network_avg_loss_ao' => 'setNetworkAvgLossAo',
        'network_avg_loss_vi' => 'setNetworkAvgLossVi',
        'network_avg_loss_vo' => 'setNetworkAvgLossVo',
        'network_cumul_loss_ai' => 'setNetworkCumulLossAi',
        'network_cumul_loss_ao' => 'setNetworkCumulLossAo',
        'network_cumul_loss_vi' => 'setNetworkCumulLossVi',
        'network_cumul_loss_vo' => 'setNetworkCumulLossVo',
        'network_loss_ai' => 'setNetworkLossAi',
        'network_loss_ao' => 'setNetworkLossAo',
        'network_loss_vi' => 'setNetworkLossVi',
        'network_loss_vo' => 'setNetworkLossVo',
        'call_quality_min' => 'setCallQualityMin',
        'call_quality_max' => 'setCallQualityMax',
        'call_quality_avg' => 'setCallQualityAvg',
        'fps_min_vi' => 'setFpsMinVi',
        'fps_min_vo' => 'setFpsMinVo',
        'fps_min_vic' => 'setFpsMinVic',
        'fps_min_voc' => 'setFpsMinVoc',
        'fps_max_vi' => 'setFpsMaxVi',
        'fps_max_vo' => 'setFpsMaxVo',
        'fps_max_vic' => 'setFpsMaxVic',
        'fps_max_voc' => 'setFpsMaxVoc',
        'fps_avg_vi' => 'setFpsAvgVi',
        'fps_avg_vo' => 'setFpsAvgVo',
        'fps_avg_vic' => 'setFpsAvgVic',
        'fps_avg_voc' => 'setFpsAvgVoc',
        'bitrate_min_ai' => 'setBitrateMinAi',
        'bitrate_min_ao' => 'setBitrateMinAo',
        'bitrate_min_vi' => 'setBitrateMinVi',
        'bitrate_min_vo' => 'setBitrateMinVo',
        'bitrate_min_vic' => 'setBitrateMinVic',
        'bitrate_min_voc' => 'setBitrateMinVoc',
        'bitrate_max_ai' => 'setBitrateMaxAi',
        'bitrate_max_ao' => 'setBitrateMaxAo',
        'bitrate_max_vi' => 'setBitrateMaxVi',
        'bitrate_max_vo' => 'setBitrateMaxVo',
        'bitrate_max_vic' => 'setBitrateMaxVic',
        'bitrate_max_voc' => 'setBitrateMaxVoc',
        'bitrate_avg_ai' => 'setBitrateAvgAi',
        'bitrate_avg_ao' => 'setBitrateAvgAo',
        'bitrate_avg_vi' => 'setBitrateAvgVi',
        'bitrate_avg_vo' => 'setBitrateAvgVo',
        'bitrate_avg_vic' => 'setBitrateAvgVic',
        'bitrate_avg_voc' => 'setBitrateAvgVoc',
        'jitter_min_ai' => 'setJitterMinAi',
        'jitter_min_ao' => 'setJitterMinAo',
        'jitter_min_vi' => 'setJitterMinVi',
        'jitter_min_vo' => 'setJitterMinVo',
        'jitter_min_vic' => 'setJitterMinVic',
        'jitter_min_voc' => 'setJitterMinVoc',
        'jitter_max_ai' => 'setJitterMaxAi',
        'jitter_max_ao' => 'setJitterMaxAo',
        'jitter_max_vi' => 'setJitterMaxVi',
        'jitter_max_vo' => 'setJitterMaxVo',
        'jitter_max_vic' => 'setJitterMaxVic',
        'jitter_max_voc' => 'setJitterMaxVoc',
        'jitter_avg_ai' => 'setJitterAvgAi',
        'jitter_avg_ao' => 'setJitterAvgAo',
        'jitter_avg_vi' => 'setJitterAvgVi',
        'jitter_avg_vo' => 'setJitterAvgVo',
        'jitter_avg_vic' => 'setJitterAvgVic',
        'jitter_avg_voc' => 'setJitterAvgVoc',
        'max_jitter_min_ai' => 'setMaxJitterMinAi',
        'max_jitter_min_vi' => 'setMaxJitterMinVi',
        'max_jitter_min_vic' => 'setMaxJitterMinVic',
        'max_jitter_max_ai' => 'setMaxJitterMaxAi',
        'max_jitter_max_vi' => 'setMaxJitterMaxVi',
        'max_jitter_max_vic' => 'setMaxJitterMaxVic',
        'max_jitter_avg_ai' => 'setMaxJitterAvgAi',
        'max_jitter_avg_vi' => 'setMaxJitterAvgVi',
        'max_jitter_avg_vic' => 'setMaxJitterAvgVic',
        'video_recv_height_min' => 'setVideoRecvHeightMin',
        'video_recv_height_max' => 'setVideoRecvHeightMax',
        'video_recv_width_min' => 'setVideoRecvWidthMin',
        'video_recv_width_max' => 'setVideoRecvWidthMax',
        'video_send_height_min' => 'setVideoSendHeightMin',
        'video_send_height_max' => 'setVideoSendHeightMax',
        'video_send_width_min' => 'setVideoSendWidthMin',
        'video_send_width_max' => 'setVideoSendWidthMax',
        'content_recv_height_min' => 'setContentRecvHeightMin',
        'content_recv_height_max' => 'setContentRecvHeightMax',
        'content_recv_width_min' => 'setContentRecvWidthMin',
        'content_recv_width_max' => 'setContentRecvWidthMax',
        'content_send_height_min' => 'setContentSendHeightMin',
        'content_send_height_max' => 'setContentSendHeightMax',
        'content_send_width_min' => 'setContentSendWidthMin',
        'content_send_width_max' => 'setContentSendWidthMax',
        'round_trip_delay_min' => 'setRoundTripDelayMin',
        'round_trip_delay_max' => 'setRoundTripDelayMax',
        'round_trip_delay_avg' => 'setRoundTripDelayAvg',
        'rfactor_min' => 'setRfactorMin',
        'rfactor_max' => 'setRfactorMax',
        'rfactor_avg' => 'setRfactorAvg',
        'process_cpu_load_min' => 'setProcessCpuLoadMin',
        'process_cpu_load_max' => 'setProcessCpuLoadMax',
        'process_cpu_load_avg' => 'setProcessCpuLoadAvg',
        'system_cpu_load_min' => 'setSystemCpuLoadMin',
        'system_cpu_load_max' => 'setSystemCpuLoadMax',
        'system_cpu_load_avg' => 'setSystemCpuLoadAvg',
        'wifi_recv_strength_min' => 'setWifiRecvStrengthMin',
        'wifi_recv_strength_max' => 'setWifiRecvStrengthMax',
        'wifi_recv_strength_avg' => 'setWifiRecvStrengthAvg',
        'key_frame_rate_avg_vi' => 'setKeyFrameRateAvgVi',
        'key_frame_rate_avg_vo' => 'setKeyFrameRateAvgVo',
        'key_frame_rate_avg_vic' => 'setKeyFrameRateAvgVic',
        'key_frame_rate_avg_voc' => 'setKeyFrameRateAvgVoc',
        'key_frame_rate_min_vi' => 'setKeyFrameRateMinVi',
        'key_frame_rate_min_vo' => 'setKeyFrameRateMinVo',
        'key_frame_rate_min_vic' => 'setKeyFrameRateMinVic',
        'key_frame_rate_min_voc' => 'setKeyFrameRateMinVoc',
        'key_frame_rate_max_vi' => 'setKeyFrameRateMaxVi',
        'key_frame_rate_max_vo' => 'setKeyFrameRateMaxVo',
        'key_frame_rate_max_vic' => 'setKeyFrameRateMaxVic',
        'key_frame_rate_max_voc' => 'setKeyFrameRateMaxVoc',
        'round_trip_delay_avg_vo' => 'setRoundTripDelayAvgVo',
        'round_trip_delay_avg_voc' => 'setRoundTripDelayAvgVoc',
        'round_trip_delay_avg_ao' => 'setRoundTripDelayAvgAo'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'audio_recv_codec' => 'getAudioRecvCodec',
        'audio_send_codec' => 'getAudioSendCodec',
        'content_recv' => 'getContentRecv',
        'content_send' => 'getContentSend',
        'talk_detected' => 'getTalkDetected',
        'session_relay' => 'getSessionRelay',
        'session_in_relay' => 'getSessionInRelay',
        'session_out_relay' => 'getSessionOutRelay',
        'audio_rtp_relay' => 'getAudioRtpRelay',
        'call_rate' => 'getCallRate',
        'cumul_loss_percent_ai' => 'getCumulLossPercentAi',
        'cumul_loss_percent_ao' => 'getCumulLossPercentAo',
        'cumul_loss_percent_vi' => 'getCumulLossPercentVi',
        'cumul_loss_percent_vo' => 'getCumulLossPercentVo',
        'cumul_loss_percent_vic' => 'getCumulLossPercentVic',
        'cumul_loss_percent_voc' => 'getCumulLossPercentVoc',
        'cumul_loss_ai' => 'getCumulLossAi',
        'cumul_loss_ao' => 'getCumulLossAo',
        'cumul_loss_vi' => 'getCumulLossVi',
        'cumul_loss_vo' => 'getCumulLossVo',
        'cumul_loss_vic' => 'getCumulLossVic',
        'cumul_loss_voc' => 'getCumulLossVoc',
        'discontinuity_count' => 'getDiscontinuityCount',
        'dropped_packets_ai' => 'getDroppedPacketsAi',
        'dropped_packets_vi' => 'getDroppedPacketsVi',
        'dropped_packets_vic' => 'getDroppedPacketsVic',
        'mix_under_runs_ai' => 'getMixUnderRunsAi',
        'network_avg_loss_ai' => 'getNetworkAvgLossAi',
        'network_avg_loss_ao' => 'getNetworkAvgLossAo',
        'network_avg_loss_vi' => 'getNetworkAvgLossVi',
        'network_avg_loss_vo' => 'getNetworkAvgLossVo',
        'network_cumul_loss_ai' => 'getNetworkCumulLossAi',
        'network_cumul_loss_ao' => 'getNetworkCumulLossAo',
        'network_cumul_loss_vi' => 'getNetworkCumulLossVi',
        'network_cumul_loss_vo' => 'getNetworkCumulLossVo',
        'network_loss_ai' => 'getNetworkLossAi',
        'network_loss_ao' => 'getNetworkLossAo',
        'network_loss_vi' => 'getNetworkLossVi',
        'network_loss_vo' => 'getNetworkLossVo',
        'call_quality_min' => 'getCallQualityMin',
        'call_quality_max' => 'getCallQualityMax',
        'call_quality_avg' => 'getCallQualityAvg',
        'fps_min_vi' => 'getFpsMinVi',
        'fps_min_vo' => 'getFpsMinVo',
        'fps_min_vic' => 'getFpsMinVic',
        'fps_min_voc' => 'getFpsMinVoc',
        'fps_max_vi' => 'getFpsMaxVi',
        'fps_max_vo' => 'getFpsMaxVo',
        'fps_max_vic' => 'getFpsMaxVic',
        'fps_max_voc' => 'getFpsMaxVoc',
        'fps_avg_vi' => 'getFpsAvgVi',
        'fps_avg_vo' => 'getFpsAvgVo',
        'fps_avg_vic' => 'getFpsAvgVic',
        'fps_avg_voc' => 'getFpsAvgVoc',
        'bitrate_min_ai' => 'getBitrateMinAi',
        'bitrate_min_ao' => 'getBitrateMinAo',
        'bitrate_min_vi' => 'getBitrateMinVi',
        'bitrate_min_vo' => 'getBitrateMinVo',
        'bitrate_min_vic' => 'getBitrateMinVic',
        'bitrate_min_voc' => 'getBitrateMinVoc',
        'bitrate_max_ai' => 'getBitrateMaxAi',
        'bitrate_max_ao' => 'getBitrateMaxAo',
        'bitrate_max_vi' => 'getBitrateMaxVi',
        'bitrate_max_vo' => 'getBitrateMaxVo',
        'bitrate_max_vic' => 'getBitrateMaxVic',
        'bitrate_max_voc' => 'getBitrateMaxVoc',
        'bitrate_avg_ai' => 'getBitrateAvgAi',
        'bitrate_avg_ao' => 'getBitrateAvgAo',
        'bitrate_avg_vi' => 'getBitrateAvgVi',
        'bitrate_avg_vo' => 'getBitrateAvgVo',
        'bitrate_avg_vic' => 'getBitrateAvgVic',
        'bitrate_avg_voc' => 'getBitrateAvgVoc',
        'jitter_min_ai' => 'getJitterMinAi',
        'jitter_min_ao' => 'getJitterMinAo',
        'jitter_min_vi' => 'getJitterMinVi',
        'jitter_min_vo' => 'getJitterMinVo',
        'jitter_min_vic' => 'getJitterMinVic',
        'jitter_min_voc' => 'getJitterMinVoc',
        'jitter_max_ai' => 'getJitterMaxAi',
        'jitter_max_ao' => 'getJitterMaxAo',
        'jitter_max_vi' => 'getJitterMaxVi',
        'jitter_max_vo' => 'getJitterMaxVo',
        'jitter_max_vic' => 'getJitterMaxVic',
        'jitter_max_voc' => 'getJitterMaxVoc',
        'jitter_avg_ai' => 'getJitterAvgAi',
        'jitter_avg_ao' => 'getJitterAvgAo',
        'jitter_avg_vi' => 'getJitterAvgVi',
        'jitter_avg_vo' => 'getJitterAvgVo',
        'jitter_avg_vic' => 'getJitterAvgVic',
        'jitter_avg_voc' => 'getJitterAvgVoc',
        'max_jitter_min_ai' => 'getMaxJitterMinAi',
        'max_jitter_min_vi' => 'getMaxJitterMinVi',
        'max_jitter_min_vic' => 'getMaxJitterMinVic',
        'max_jitter_max_ai' => 'getMaxJitterMaxAi',
        'max_jitter_max_vi' => 'getMaxJitterMaxVi',
        'max_jitter_max_vic' => 'getMaxJitterMaxVic',
        'max_jitter_avg_ai' => 'getMaxJitterAvgAi',
        'max_jitter_avg_vi' => 'getMaxJitterAvgVi',
        'max_jitter_avg_vic' => 'getMaxJitterAvgVic',
        'video_recv_height_min' => 'getVideoRecvHeightMin',
        'video_recv_height_max' => 'getVideoRecvHeightMax',
        'video_recv_width_min' => 'getVideoRecvWidthMin',
        'video_recv_width_max' => 'getVideoRecvWidthMax',
        'video_send_height_min' => 'getVideoSendHeightMin',
        'video_send_height_max' => 'getVideoSendHeightMax',
        'video_send_width_min' => 'getVideoSendWidthMin',
        'video_send_width_max' => 'getVideoSendWidthMax',
        'content_recv_height_min' => 'getContentRecvHeightMin',
        'content_recv_height_max' => 'getContentRecvHeightMax',
        'content_recv_width_min' => 'getContentRecvWidthMin',
        'content_recv_width_max' => 'getContentRecvWidthMax',
        'content_send_height_min' => 'getContentSendHeightMin',
        'content_send_height_max' => 'getContentSendHeightMax',
        'content_send_width_min' => 'getContentSendWidthMin',
        'content_send_width_max' => 'getContentSendWidthMax',
        'round_trip_delay_min' => 'getRoundTripDelayMin',
        'round_trip_delay_max' => 'getRoundTripDelayMax',
        'round_trip_delay_avg' => 'getRoundTripDelayAvg',
        'rfactor_min' => 'getRfactorMin',
        'rfactor_max' => 'getRfactorMax',
        'rfactor_avg' => 'getRfactorAvg',
        'process_cpu_load_min' => 'getProcessCpuLoadMin',
        'process_cpu_load_max' => 'getProcessCpuLoadMax',
        'process_cpu_load_avg' => 'getProcessCpuLoadAvg',
        'system_cpu_load_min' => 'getSystemCpuLoadMin',
        'system_cpu_load_max' => 'getSystemCpuLoadMax',
        'system_cpu_load_avg' => 'getSystemCpuLoadAvg',
        'wifi_recv_strength_min' => 'getWifiRecvStrengthMin',
        'wifi_recv_strength_max' => 'getWifiRecvStrengthMax',
        'wifi_recv_strength_avg' => 'getWifiRecvStrengthAvg',
        'key_frame_rate_avg_vi' => 'getKeyFrameRateAvgVi',
        'key_frame_rate_avg_vo' => 'getKeyFrameRateAvgVo',
        'key_frame_rate_avg_vic' => 'getKeyFrameRateAvgVic',
        'key_frame_rate_avg_voc' => 'getKeyFrameRateAvgVoc',
        'key_frame_rate_min_vi' => 'getKeyFrameRateMinVi',
        'key_frame_rate_min_vo' => 'getKeyFrameRateMinVo',
        'key_frame_rate_min_vic' => 'getKeyFrameRateMinVic',
        'key_frame_rate_min_voc' => 'getKeyFrameRateMinVoc',
        'key_frame_rate_max_vi' => 'getKeyFrameRateMaxVi',
        'key_frame_rate_max_vo' => 'getKeyFrameRateMaxVo',
        'key_frame_rate_max_vic' => 'getKeyFrameRateMaxVic',
        'key_frame_rate_max_voc' => 'getKeyFrameRateMaxVoc',
        'round_trip_delay_avg_vo' => 'getRoundTripDelayAvgVo',
        'round_trip_delay_avg_voc' => 'getRoundTripDelayAvgVoc',
        'round_trip_delay_avg_ao' => 'getRoundTripDelayAvgAo'
    ];

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    public static function setters()
    {
        return self::$setters;
    }

    public static function getters()
    {
        return self::$getters;
    }

    

    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     * @param mixed[] $data Associated array of property values initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['audio_recv_codec'] = isset($data['audio_recv_codec']) ? $data['audio_recv_codec'] : null;
        $this->container['audio_send_codec'] = isset($data['audio_send_codec']) ? $data['audio_send_codec'] : null;
        $this->container['content_recv'] = isset($data['content_recv']) ? $data['content_recv'] : null;
        $this->container['content_send'] = isset($data['content_send']) ? $data['content_send'] : null;
        $this->container['talk_detected'] = isset($data['talk_detected']) ? $data['talk_detected'] : null;
        $this->container['session_relay'] = isset($data['session_relay']) ? $data['session_relay'] : null;
        $this->container['session_in_relay'] = isset($data['session_in_relay']) ? $data['session_in_relay'] : null;
        $this->container['session_out_relay'] = isset($data['session_out_relay']) ? $data['session_out_relay'] : null;
        $this->container['audio_rtp_relay'] = isset($data['audio_rtp_relay']) ? $data['audio_rtp_relay'] : null;
        $this->container['call_rate'] = isset($data['call_rate']) ? $data['call_rate'] : null;
        $this->container['cumul_loss_percent_ai'] = isset($data['cumul_loss_percent_ai']) ? $data['cumul_loss_percent_ai'] : null;
        $this->container['cumul_loss_percent_ao'] = isset($data['cumul_loss_percent_ao']) ? $data['cumul_loss_percent_ao'] : null;
        $this->container['cumul_loss_percent_vi'] = isset($data['cumul_loss_percent_vi']) ? $data['cumul_loss_percent_vi'] : null;
        $this->container['cumul_loss_percent_vo'] = isset($data['cumul_loss_percent_vo']) ? $data['cumul_loss_percent_vo'] : null;
        $this->container['cumul_loss_percent_vic'] = isset($data['cumul_loss_percent_vic']) ? $data['cumul_loss_percent_vic'] : null;
        $this->container['cumul_loss_percent_voc'] = isset($data['cumul_loss_percent_voc']) ? $data['cumul_loss_percent_voc'] : null;
        $this->container['cumul_loss_ai'] = isset($data['cumul_loss_ai']) ? $data['cumul_loss_ai'] : null;
        $this->container['cumul_loss_ao'] = isset($data['cumul_loss_ao']) ? $data['cumul_loss_ao'] : null;
        $this->container['cumul_loss_vi'] = isset($data['cumul_loss_vi']) ? $data['cumul_loss_vi'] : null;
        $this->container['cumul_loss_vo'] = isset($data['cumul_loss_vo']) ? $data['cumul_loss_vo'] : null;
        $this->container['cumul_loss_vic'] = isset($data['cumul_loss_vic']) ? $data['cumul_loss_vic'] : null;
        $this->container['cumul_loss_voc'] = isset($data['cumul_loss_voc']) ? $data['cumul_loss_voc'] : null;
        $this->container['discontinuity_count'] = isset($data['discontinuity_count']) ? $data['discontinuity_count'] : null;
        $this->container['dropped_packets_ai'] = isset($data['dropped_packets_ai']) ? $data['dropped_packets_ai'] : null;
        $this->container['dropped_packets_vi'] = isset($data['dropped_packets_vi']) ? $data['dropped_packets_vi'] : null;
        $this->container['dropped_packets_vic'] = isset($data['dropped_packets_vic']) ? $data['dropped_packets_vic'] : null;
        $this->container['mix_under_runs_ai'] = isset($data['mix_under_runs_ai']) ? $data['mix_under_runs_ai'] : null;
        $this->container['network_avg_loss_ai'] = isset($data['network_avg_loss_ai']) ? $data['network_avg_loss_ai'] : null;
        $this->container['network_avg_loss_ao'] = isset($data['network_avg_loss_ao']) ? $data['network_avg_loss_ao'] : null;
        $this->container['network_avg_loss_vi'] = isset($data['network_avg_loss_vi']) ? $data['network_avg_loss_vi'] : null;
        $this->container['network_avg_loss_vo'] = isset($data['network_avg_loss_vo']) ? $data['network_avg_loss_vo'] : null;
        $this->container['network_cumul_loss_ai'] = isset($data['network_cumul_loss_ai']) ? $data['network_cumul_loss_ai'] : null;
        $this->container['network_cumul_loss_ao'] = isset($data['network_cumul_loss_ao']) ? $data['network_cumul_loss_ao'] : null;
        $this->container['network_cumul_loss_vi'] = isset($data['network_cumul_loss_vi']) ? $data['network_cumul_loss_vi'] : null;
        $this->container['network_cumul_loss_vo'] = isset($data['network_cumul_loss_vo']) ? $data['network_cumul_loss_vo'] : null;
        $this->container['network_loss_ai'] = isset($data['network_loss_ai']) ? $data['network_loss_ai'] : null;
        $this->container['network_loss_ao'] = isset($data['network_loss_ao']) ? $data['network_loss_ao'] : null;
        $this->container['network_loss_vi'] = isset($data['network_loss_vi']) ? $data['network_loss_vi'] : null;
        $this->container['network_loss_vo'] = isset($data['network_loss_vo']) ? $data['network_loss_vo'] : null;
        $this->container['call_quality_min'] = isset($data['call_quality_min']) ? $data['call_quality_min'] : null;
        $this->container['call_quality_max'] = isset($data['call_quality_max']) ? $data['call_quality_max'] : null;
        $this->container['call_quality_avg'] = isset($data['call_quality_avg']) ? $data['call_quality_avg'] : null;
        $this->container['fps_min_vi'] = isset($data['fps_min_vi']) ? $data['fps_min_vi'] : null;
        $this->container['fps_min_vo'] = isset($data['fps_min_vo']) ? $data['fps_min_vo'] : null;
        $this->container['fps_min_vic'] = isset($data['fps_min_vic']) ? $data['fps_min_vic'] : null;
        $this->container['fps_min_voc'] = isset($data['fps_min_voc']) ? $data['fps_min_voc'] : null;
        $this->container['fps_max_vi'] = isset($data['fps_max_vi']) ? $data['fps_max_vi'] : null;
        $this->container['fps_max_vo'] = isset($data['fps_max_vo']) ? $data['fps_max_vo'] : null;
        $this->container['fps_max_vic'] = isset($data['fps_max_vic']) ? $data['fps_max_vic'] : null;
        $this->container['fps_max_voc'] = isset($data['fps_max_voc']) ? $data['fps_max_voc'] : null;
        $this->container['fps_avg_vi'] = isset($data['fps_avg_vi']) ? $data['fps_avg_vi'] : null;
        $this->container['fps_avg_vo'] = isset($data['fps_avg_vo']) ? $data['fps_avg_vo'] : null;
        $this->container['fps_avg_vic'] = isset($data['fps_avg_vic']) ? $data['fps_avg_vic'] : null;
        $this->container['fps_avg_voc'] = isset($data['fps_avg_voc']) ? $data['fps_avg_voc'] : null;
        $this->container['bitrate_min_ai'] = isset($data['bitrate_min_ai']) ? $data['bitrate_min_ai'] : null;
        $this->container['bitrate_min_ao'] = isset($data['bitrate_min_ao']) ? $data['bitrate_min_ao'] : null;
        $this->container['bitrate_min_vi'] = isset($data['bitrate_min_vi']) ? $data['bitrate_min_vi'] : null;
        $this->container['bitrate_min_vo'] = isset($data['bitrate_min_vo']) ? $data['bitrate_min_vo'] : null;
        $this->container['bitrate_min_vic'] = isset($data['bitrate_min_vic']) ? $data['bitrate_min_vic'] : null;
        $this->container['bitrate_min_voc'] = isset($data['bitrate_min_voc']) ? $data['bitrate_min_voc'] : null;
        $this->container['bitrate_max_ai'] = isset($data['bitrate_max_ai']) ? $data['bitrate_max_ai'] : null;
        $this->container['bitrate_max_ao'] = isset($data['bitrate_max_ao']) ? $data['bitrate_max_ao'] : null;
        $this->container['bitrate_max_vi'] = isset($data['bitrate_max_vi']) ? $data['bitrate_max_vi'] : null;
        $this->container['bitrate_max_vo'] = isset($data['bitrate_max_vo']) ? $data['bitrate_max_vo'] : null;
        $this->container['bitrate_max_vic'] = isset($data['bitrate_max_vic']) ? $data['bitrate_max_vic'] : null;
        $this->container['bitrate_max_voc'] = isset($data['bitrate_max_voc']) ? $data['bitrate_max_voc'] : null;
        $this->container['bitrate_avg_ai'] = isset($data['bitrate_avg_ai']) ? $data['bitrate_avg_ai'] : null;
        $this->container['bitrate_avg_ao'] = isset($data['bitrate_avg_ao']) ? $data['bitrate_avg_ao'] : null;
        $this->container['bitrate_avg_vi'] = isset($data['bitrate_avg_vi']) ? $data['bitrate_avg_vi'] : null;
        $this->container['bitrate_avg_vo'] = isset($data['bitrate_avg_vo']) ? $data['bitrate_avg_vo'] : null;
        $this->container['bitrate_avg_vic'] = isset($data['bitrate_avg_vic']) ? $data['bitrate_avg_vic'] : null;
        $this->container['bitrate_avg_voc'] = isset($data['bitrate_avg_voc']) ? $data['bitrate_avg_voc'] : null;
        $this->container['jitter_min_ai'] = isset($data['jitter_min_ai']) ? $data['jitter_min_ai'] : null;
        $this->container['jitter_min_ao'] = isset($data['jitter_min_ao']) ? $data['jitter_min_ao'] : null;
        $this->container['jitter_min_vi'] = isset($data['jitter_min_vi']) ? $data['jitter_min_vi'] : null;
        $this->container['jitter_min_vo'] = isset($data['jitter_min_vo']) ? $data['jitter_min_vo'] : null;
        $this->container['jitter_min_vic'] = isset($data['jitter_min_vic']) ? $data['jitter_min_vic'] : null;
        $this->container['jitter_min_voc'] = isset($data['jitter_min_voc']) ? $data['jitter_min_voc'] : null;
        $this->container['jitter_max_ai'] = isset($data['jitter_max_ai']) ? $data['jitter_max_ai'] : null;
        $this->container['jitter_max_ao'] = isset($data['jitter_max_ao']) ? $data['jitter_max_ao'] : null;
        $this->container['jitter_max_vi'] = isset($data['jitter_max_vi']) ? $data['jitter_max_vi'] : null;
        $this->container['jitter_max_vo'] = isset($data['jitter_max_vo']) ? $data['jitter_max_vo'] : null;
        $this->container['jitter_max_vic'] = isset($data['jitter_max_vic']) ? $data['jitter_max_vic'] : null;
        $this->container['jitter_max_voc'] = isset($data['jitter_max_voc']) ? $data['jitter_max_voc'] : null;
        $this->container['jitter_avg_ai'] = isset($data['jitter_avg_ai']) ? $data['jitter_avg_ai'] : null;
        $this->container['jitter_avg_ao'] = isset($data['jitter_avg_ao']) ? $data['jitter_avg_ao'] : null;
        $this->container['jitter_avg_vi'] = isset($data['jitter_avg_vi']) ? $data['jitter_avg_vi'] : null;
        $this->container['jitter_avg_vo'] = isset($data['jitter_avg_vo']) ? $data['jitter_avg_vo'] : null;
        $this->container['jitter_avg_vic'] = isset($data['jitter_avg_vic']) ? $data['jitter_avg_vic'] : null;
        $this->container['jitter_avg_voc'] = isset($data['jitter_avg_voc']) ? $data['jitter_avg_voc'] : null;
        $this->container['max_jitter_min_ai'] = isset($data['max_jitter_min_ai']) ? $data['max_jitter_min_ai'] : null;
        $this->container['max_jitter_min_vi'] = isset($data['max_jitter_min_vi']) ? $data['max_jitter_min_vi'] : null;
        $this->container['max_jitter_min_vic'] = isset($data['max_jitter_min_vic']) ? $data['max_jitter_min_vic'] : null;
        $this->container['max_jitter_max_ai'] = isset($data['max_jitter_max_ai']) ? $data['max_jitter_max_ai'] : null;
        $this->container['max_jitter_max_vi'] = isset($data['max_jitter_max_vi']) ? $data['max_jitter_max_vi'] : null;
        $this->container['max_jitter_max_vic'] = isset($data['max_jitter_max_vic']) ? $data['max_jitter_max_vic'] : null;
        $this->container['max_jitter_avg_ai'] = isset($data['max_jitter_avg_ai']) ? $data['max_jitter_avg_ai'] : null;
        $this->container['max_jitter_avg_vi'] = isset($data['max_jitter_avg_vi']) ? $data['max_jitter_avg_vi'] : null;
        $this->container['max_jitter_avg_vic'] = isset($data['max_jitter_avg_vic']) ? $data['max_jitter_avg_vic'] : null;
        $this->container['video_recv_height_min'] = isset($data['video_recv_height_min']) ? $data['video_recv_height_min'] : null;
        $this->container['video_recv_height_max'] = isset($data['video_recv_height_max']) ? $data['video_recv_height_max'] : null;
        $this->container['video_recv_width_min'] = isset($data['video_recv_width_min']) ? $data['video_recv_width_min'] : null;
        $this->container['video_recv_width_max'] = isset($data['video_recv_width_max']) ? $data['video_recv_width_max'] : null;
        $this->container['video_send_height_min'] = isset($data['video_send_height_min']) ? $data['video_send_height_min'] : null;
        $this->container['video_send_height_max'] = isset($data['video_send_height_max']) ? $data['video_send_height_max'] : null;
        $this->container['video_send_width_min'] = isset($data['video_send_width_min']) ? $data['video_send_width_min'] : null;
        $this->container['video_send_width_max'] = isset($data['video_send_width_max']) ? $data['video_send_width_max'] : null;
        $this->container['content_recv_height_min'] = isset($data['content_recv_height_min']) ? $data['content_recv_height_min'] : null;
        $this->container['content_recv_height_max'] = isset($data['content_recv_height_max']) ? $data['content_recv_height_max'] : null;
        $this->container['content_recv_width_min'] = isset($data['content_recv_width_min']) ? $data['content_recv_width_min'] : null;
        $this->container['content_recv_width_max'] = isset($data['content_recv_width_max']) ? $data['content_recv_width_max'] : null;
        $this->container['content_send_height_min'] = isset($data['content_send_height_min']) ? $data['content_send_height_min'] : null;
        $this->container['content_send_height_max'] = isset($data['content_send_height_max']) ? $data['content_send_height_max'] : null;
        $this->container['content_send_width_min'] = isset($data['content_send_width_min']) ? $data['content_send_width_min'] : null;
        $this->container['content_send_width_max'] = isset($data['content_send_width_max']) ? $data['content_send_width_max'] : null;
        $this->container['round_trip_delay_min'] = isset($data['round_trip_delay_min']) ? $data['round_trip_delay_min'] : null;
        $this->container['round_trip_delay_max'] = isset($data['round_trip_delay_max']) ? $data['round_trip_delay_max'] : null;
        $this->container['round_trip_delay_avg'] = isset($data['round_trip_delay_avg']) ? $data['round_trip_delay_avg'] : null;
        $this->container['rfactor_min'] = isset($data['rfactor_min']) ? $data['rfactor_min'] : null;
        $this->container['rfactor_max'] = isset($data['rfactor_max']) ? $data['rfactor_max'] : null;
        $this->container['rfactor_avg'] = isset($data['rfactor_avg']) ? $data['rfactor_avg'] : null;
        $this->container['process_cpu_load_min'] = isset($data['process_cpu_load_min']) ? $data['process_cpu_load_min'] : null;
        $this->container['process_cpu_load_max'] = isset($data['process_cpu_load_max']) ? $data['process_cpu_load_max'] : null;
        $this->container['process_cpu_load_avg'] = isset($data['process_cpu_load_avg']) ? $data['process_cpu_load_avg'] : null;
        $this->container['system_cpu_load_min'] = isset($data['system_cpu_load_min']) ? $data['system_cpu_load_min'] : null;
        $this->container['system_cpu_load_max'] = isset($data['system_cpu_load_max']) ? $data['system_cpu_load_max'] : null;
        $this->container['system_cpu_load_avg'] = isset($data['system_cpu_load_avg']) ? $data['system_cpu_load_avg'] : null;
        $this->container['wifi_recv_strength_min'] = isset($data['wifi_recv_strength_min']) ? $data['wifi_recv_strength_min'] : null;
        $this->container['wifi_recv_strength_max'] = isset($data['wifi_recv_strength_max']) ? $data['wifi_recv_strength_max'] : null;
        $this->container['wifi_recv_strength_avg'] = isset($data['wifi_recv_strength_avg']) ? $data['wifi_recv_strength_avg'] : null;
        $this->container['key_frame_rate_avg_vi'] = isset($data['key_frame_rate_avg_vi']) ? $data['key_frame_rate_avg_vi'] : null;
        $this->container['key_frame_rate_avg_vo'] = isset($data['key_frame_rate_avg_vo']) ? $data['key_frame_rate_avg_vo'] : null;
        $this->container['key_frame_rate_avg_vic'] = isset($data['key_frame_rate_avg_vic']) ? $data['key_frame_rate_avg_vic'] : null;
        $this->container['key_frame_rate_avg_voc'] = isset($data['key_frame_rate_avg_voc']) ? $data['key_frame_rate_avg_voc'] : null;
        $this->container['key_frame_rate_min_vi'] = isset($data['key_frame_rate_min_vi']) ? $data['key_frame_rate_min_vi'] : null;
        $this->container['key_frame_rate_min_vo'] = isset($data['key_frame_rate_min_vo']) ? $data['key_frame_rate_min_vo'] : null;
        $this->container['key_frame_rate_min_vic'] = isset($data['key_frame_rate_min_vic']) ? $data['key_frame_rate_min_vic'] : null;
        $this->container['key_frame_rate_min_voc'] = isset($data['key_frame_rate_min_voc']) ? $data['key_frame_rate_min_voc'] : null;
        $this->container['key_frame_rate_max_vi'] = isset($data['key_frame_rate_max_vi']) ? $data['key_frame_rate_max_vi'] : null;
        $this->container['key_frame_rate_max_vo'] = isset($data['key_frame_rate_max_vo']) ? $data['key_frame_rate_max_vo'] : null;
        $this->container['key_frame_rate_max_vic'] = isset($data['key_frame_rate_max_vic']) ? $data['key_frame_rate_max_vic'] : null;
        $this->container['key_frame_rate_max_voc'] = isset($data['key_frame_rate_max_voc']) ? $data['key_frame_rate_max_voc'] : null;
        $this->container['round_trip_delay_avg_vo'] = isset($data['round_trip_delay_avg_vo']) ? $data['round_trip_delay_avg_vo'] : null;
        $this->container['round_trip_delay_avg_voc'] = isset($data['round_trip_delay_avg_voc']) ? $data['round_trip_delay_avg_voc'] : null;
        $this->container['round_trip_delay_avg_ao'] = isset($data['round_trip_delay_avg_ao']) ? $data['round_trip_delay_avg_ao'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = [];

        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {

        return true;
    }


    /**
     * Gets audio_recv_codec
     * @return string
     */
    public function getAudioRecvCodec()
    {
        return $this->container['audio_recv_codec'];
    }

    /**
     * Sets audio_recv_codec
     * @param string $audio_recv_codec
     * @return $this
     */
    public function setAudioRecvCodec($audio_recv_codec)
    {
        $this->container['audio_recv_codec'] = $audio_recv_codec;

        return $this;
    }

    /**
     * Gets audio_send_codec
     * @return string
     */
    public function getAudioSendCodec()
    {
        return $this->container['audio_send_codec'];
    }

    /**
     * Sets audio_send_codec
     * @param string $audio_send_codec
     * @return $this
     */
    public function setAudioSendCodec($audio_send_codec)
    {
        $this->container['audio_send_codec'] = $audio_send_codec;

        return $this;
    }

    /**
     * Gets content_recv
     * @return bool
     */
    public function getContentRecv()
    {
        return $this->container['content_recv'];
    }

    /**
     * Sets content_recv
     * @param bool $content_recv
     * @return $this
     */
    public function setContentRecv($content_recv)
    {
        $this->container['content_recv'] = $content_recv;

        return $this;
    }

    /**
     * Gets content_send
     * @return bool
     */
    public function getContentSend()
    {
        return $this->container['content_send'];
    }

    /**
     * Sets content_send
     * @param bool $content_send
     * @return $this
     */
    public function setContentSend($content_send)
    {
        $this->container['content_send'] = $content_send;

        return $this;
    }

    /**
     * Gets talk_detected
     * @return bool
     */
    public function getTalkDetected()
    {
        return $this->container['talk_detected'];
    }

    /**
     * Sets talk_detected
     * @param bool $talk_detected
     * @return $this
     */
    public function setTalkDetected($talk_detected)
    {
        $this->container['talk_detected'] = $talk_detected;

        return $this;
    }

    /**
     * Gets session_relay
     * @return bool
     */
    public function getSessionRelay()
    {
        return $this->container['session_relay'];
    }

    /**
     * Sets session_relay
     * @param bool $session_relay
     * @return $this
     */
    public function setSessionRelay($session_relay)
    {
        $this->container['session_relay'] = $session_relay;

        return $this;
    }

    /**
     * Gets session_in_relay
     * @return bool
     */
    public function getSessionInRelay()
    {
        return $this->container['session_in_relay'];
    }

    /**
     * Sets session_in_relay
     * @param bool $session_in_relay
     * @return $this
     */
    public function setSessionInRelay($session_in_relay)
    {
        $this->container['session_in_relay'] = $session_in_relay;

        return $this;
    }

    /**
     * Gets session_out_relay
     * @return bool
     */
    public function getSessionOutRelay()
    {
        return $this->container['session_out_relay'];
    }

    /**
     * Sets session_out_relay
     * @param bool $session_out_relay
     * @return $this
     */
    public function setSessionOutRelay($session_out_relay)
    {
        $this->container['session_out_relay'] = $session_out_relay;

        return $this;
    }

    /**
     * Gets audio_rtp_relay
     * @return bool
     */
    public function getAudioRtpRelay()
    {
        return $this->container['audio_rtp_relay'];
    }

    /**
     * Sets audio_rtp_relay
     * @param bool $audio_rtp_relay
     * @return $this
     */
    public function setAudioRtpRelay($audio_rtp_relay)
    {
        $this->container['audio_rtp_relay'] = $audio_rtp_relay;

        return $this;
    }

    /**
     * Gets call_rate
     * @return int
     */
    public function getCallRate()
    {
        return $this->container['call_rate'];
    }

    /**
     * Sets call_rate
     * @param int $call_rate
     * @return $this
     */
    public function setCallRate($call_rate)
    {
        $this->container['call_rate'] = $call_rate;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_ai
     * @return float
     */
    public function getCumulLossPercentAi()
    {
        return $this->container['cumul_loss_percent_ai'];
    }

    /**
     * Sets cumul_loss_percent_ai
     * @param float $cumul_loss_percent_ai
     * @return $this
     */
    public function setCumulLossPercentAi($cumul_loss_percent_ai)
    {
        $this->container['cumul_loss_percent_ai'] = $cumul_loss_percent_ai;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_ao
     * @return float
     */
    public function getCumulLossPercentAo()
    {
        return $this->container['cumul_loss_percent_ao'];
    }

    /**
     * Sets cumul_loss_percent_ao
     * @param float $cumul_loss_percent_ao
     * @return $this
     */
    public function setCumulLossPercentAo($cumul_loss_percent_ao)
    {
        $this->container['cumul_loss_percent_ao'] = $cumul_loss_percent_ao;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_vi
     * @return float
     */
    public function getCumulLossPercentVi()
    {
        return $this->container['cumul_loss_percent_vi'];
    }

    /**
     * Sets cumul_loss_percent_vi
     * @param float $cumul_loss_percent_vi
     * @return $this
     */
    public function setCumulLossPercentVi($cumul_loss_percent_vi)
    {
        $this->container['cumul_loss_percent_vi'] = $cumul_loss_percent_vi;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_vo
     * @return float
     */
    public function getCumulLossPercentVo()
    {
        return $this->container['cumul_loss_percent_vo'];
    }

    /**
     * Sets cumul_loss_percent_vo
     * @param float $cumul_loss_percent_vo
     * @return $this
     */
    public function setCumulLossPercentVo($cumul_loss_percent_vo)
    {
        $this->container['cumul_loss_percent_vo'] = $cumul_loss_percent_vo;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_vic
     * @return float
     */
    public function getCumulLossPercentVic()
    {
        return $this->container['cumul_loss_percent_vic'];
    }

    /**
     * Sets cumul_loss_percent_vic
     * @param float $cumul_loss_percent_vic
     * @return $this
     */
    public function setCumulLossPercentVic($cumul_loss_percent_vic)
    {
        $this->container['cumul_loss_percent_vic'] = $cumul_loss_percent_vic;

        return $this;
    }

    /**
     * Gets cumul_loss_percent_voc
     * @return float
     */
    public function getCumulLossPercentVoc()
    {
        return $this->container['cumul_loss_percent_voc'];
    }

    /**
     * Sets cumul_loss_percent_voc
     * @param float $cumul_loss_percent_voc
     * @return $this
     */
    public function setCumulLossPercentVoc($cumul_loss_percent_voc)
    {
        $this->container['cumul_loss_percent_voc'] = $cumul_loss_percent_voc;

        return $this;
    }

    /**
     * Gets cumul_loss_ai
     * @return float
     */
    public function getCumulLossAi()
    {
        return $this->container['cumul_loss_ai'];
    }

    /**
     * Sets cumul_loss_ai
     * @param float $cumul_loss_ai
     * @return $this
     */
    public function setCumulLossAi($cumul_loss_ai)
    {
        $this->container['cumul_loss_ai'] = $cumul_loss_ai;

        return $this;
    }

    /**
     * Gets cumul_loss_ao
     * @return float
     */
    public function getCumulLossAo()
    {
        return $this->container['cumul_loss_ao'];
    }

    /**
     * Sets cumul_loss_ao
     * @param float $cumul_loss_ao
     * @return $this
     */
    public function setCumulLossAo($cumul_loss_ao)
    {
        $this->container['cumul_loss_ao'] = $cumul_loss_ao;

        return $this;
    }

    /**
     * Gets cumul_loss_vi
     * @return float
     */
    public function getCumulLossVi()
    {
        return $this->container['cumul_loss_vi'];
    }

    /**
     * Sets cumul_loss_vi
     * @param float $cumul_loss_vi
     * @return $this
     */
    public function setCumulLossVi($cumul_loss_vi)
    {
        $this->container['cumul_loss_vi'] = $cumul_loss_vi;

        return $this;
    }

    /**
     * Gets cumul_loss_vo
     * @return float
     */
    public function getCumulLossVo()
    {
        return $this->container['cumul_loss_vo'];
    }

    /**
     * Sets cumul_loss_vo
     * @param float $cumul_loss_vo
     * @return $this
     */
    public function setCumulLossVo($cumul_loss_vo)
    {
        $this->container['cumul_loss_vo'] = $cumul_loss_vo;

        return $this;
    }

    /**
     * Gets cumul_loss_vic
     * @return float
     */
    public function getCumulLossVic()
    {
        return $this->container['cumul_loss_vic'];
    }

    /**
     * Sets cumul_loss_vic
     * @param float $cumul_loss_vic
     * @return $this
     */
    public function setCumulLossVic($cumul_loss_vic)
    {
        $this->container['cumul_loss_vic'] = $cumul_loss_vic;

        return $this;
    }

    /**
     * Gets cumul_loss_voc
     * @return float
     */
    public function getCumulLossVoc()
    {
        return $this->container['cumul_loss_voc'];
    }

    /**
     * Sets cumul_loss_voc
     * @param float $cumul_loss_voc
     * @return $this
     */
    public function setCumulLossVoc($cumul_loss_voc)
    {
        $this->container['cumul_loss_voc'] = $cumul_loss_voc;

        return $this;
    }

    /**
     * Gets discontinuity_count
     * @return float
     */
    public function getDiscontinuityCount()
    {
        return $this->container['discontinuity_count'];
    }

    /**
     * Sets discontinuity_count
     * @param float $discontinuity_count
     * @return $this
     */
    public function setDiscontinuityCount($discontinuity_count)
    {
        $this->container['discontinuity_count'] = $discontinuity_count;

        return $this;
    }

    /**
     * Gets dropped_packets_ai
     * @return float
     */
    public function getDroppedPacketsAi()
    {
        return $this->container['dropped_packets_ai'];
    }

    /**
     * Sets dropped_packets_ai
     * @param float $dropped_packets_ai
     * @return $this
     */
    public function setDroppedPacketsAi($dropped_packets_ai)
    {
        $this->container['dropped_packets_ai'] = $dropped_packets_ai;

        return $this;
    }

    /**
     * Gets dropped_packets_vi
     * @return float
     */
    public function getDroppedPacketsVi()
    {
        return $this->container['dropped_packets_vi'];
    }

    /**
     * Sets dropped_packets_vi
     * @param float $dropped_packets_vi
     * @return $this
     */
    public function setDroppedPacketsVi($dropped_packets_vi)
    {
        $this->container['dropped_packets_vi'] = $dropped_packets_vi;

        return $this;
    }

    /**
     * Gets dropped_packets_vic
     * @return float
     */
    public function getDroppedPacketsVic()
    {
        return $this->container['dropped_packets_vic'];
    }

    /**
     * Sets dropped_packets_vic
     * @param float $dropped_packets_vic
     * @return $this
     */
    public function setDroppedPacketsVic($dropped_packets_vic)
    {
        $this->container['dropped_packets_vic'] = $dropped_packets_vic;

        return $this;
    }

    /**
     * Gets mix_under_runs_ai
     * @return float
     */
    public function getMixUnderRunsAi()
    {
        return $this->container['mix_under_runs_ai'];
    }

    /**
     * Sets mix_under_runs_ai
     * @param float $mix_under_runs_ai
     * @return $this
     */
    public function setMixUnderRunsAi($mix_under_runs_ai)
    {
        $this->container['mix_under_runs_ai'] = $mix_under_runs_ai;

        return $this;
    }

    /**
     * Gets network_avg_loss_ai
     * @return float
     */
    public function getNetworkAvgLossAi()
    {
        return $this->container['network_avg_loss_ai'];
    }

    /**
     * Sets network_avg_loss_ai
     * @param float $network_avg_loss_ai
     * @return $this
     */
    public function setNetworkAvgLossAi($network_avg_loss_ai)
    {
        $this->container['network_avg_loss_ai'] = $network_avg_loss_ai;

        return $this;
    }

    /**
     * Gets network_avg_loss_ao
     * @return float
     */
    public function getNetworkAvgLossAo()
    {
        return $this->container['network_avg_loss_ao'];
    }

    /**
     * Sets network_avg_loss_ao
     * @param float $network_avg_loss_ao
     * @return $this
     */
    public function setNetworkAvgLossAo($network_avg_loss_ao)
    {
        $this->container['network_avg_loss_ao'] = $network_avg_loss_ao;

        return $this;
    }

    /**
     * Gets network_avg_loss_vi
     * @return float
     */
    public function getNetworkAvgLossVi()
    {
        return $this->container['network_avg_loss_vi'];
    }

    /**
     * Sets network_avg_loss_vi
     * @param float $network_avg_loss_vi
     * @return $this
     */
    public function setNetworkAvgLossVi($network_avg_loss_vi)
    {
        $this->container['network_avg_loss_vi'] = $network_avg_loss_vi;

        return $this;
    }

    /**
     * Gets network_avg_loss_vo
     * @return float
     */
    public function getNetworkAvgLossVo()
    {
        return $this->container['network_avg_loss_vo'];
    }

    /**
     * Sets network_avg_loss_vo
     * @param float $network_avg_loss_vo
     * @return $this
     */
    public function setNetworkAvgLossVo($network_avg_loss_vo)
    {
        $this->container['network_avg_loss_vo'] = $network_avg_loss_vo;

        return $this;
    }

    /**
     * Gets network_cumul_loss_ai
     * @return float
     */
    public function getNetworkCumulLossAi()
    {
        return $this->container['network_cumul_loss_ai'];
    }

    /**
     * Sets network_cumul_loss_ai
     * @param float $network_cumul_loss_ai
     * @return $this
     */
    public function setNetworkCumulLossAi($network_cumul_loss_ai)
    {
        $this->container['network_cumul_loss_ai'] = $network_cumul_loss_ai;

        return $this;
    }

    /**
     * Gets network_cumul_loss_ao
     * @return float
     */
    public function getNetworkCumulLossAo()
    {
        return $this->container['network_cumul_loss_ao'];
    }

    /**
     * Sets network_cumul_loss_ao
     * @param float $network_cumul_loss_ao
     * @return $this
     */
    public function setNetworkCumulLossAo($network_cumul_loss_ao)
    {
        $this->container['network_cumul_loss_ao'] = $network_cumul_loss_ao;

        return $this;
    }

    /**
     * Gets network_cumul_loss_vi
     * @return float
     */
    public function getNetworkCumulLossVi()
    {
        return $this->container['network_cumul_loss_vi'];
    }

    /**
     * Sets network_cumul_loss_vi
     * @param float $network_cumul_loss_vi
     * @return $this
     */
    public function setNetworkCumulLossVi($network_cumul_loss_vi)
    {
        $this->container['network_cumul_loss_vi'] = $network_cumul_loss_vi;

        return $this;
    }

    /**
     * Gets network_cumul_loss_vo
     * @return float
     */
    public function getNetworkCumulLossVo()
    {
        return $this->container['network_cumul_loss_vo'];
    }

    /**
     * Sets network_cumul_loss_vo
     * @param float $network_cumul_loss_vo
     * @return $this
     */
    public function setNetworkCumulLossVo($network_cumul_loss_vo)
    {
        $this->container['network_cumul_loss_vo'] = $network_cumul_loss_vo;

        return $this;
    }

    /**
     * Gets network_loss_ai
     * @return float
     */
    public function getNetworkLossAi()
    {
        return $this->container['network_loss_ai'];
    }

    /**
     * Sets network_loss_ai
     * @param float $network_loss_ai
     * @return $this
     */
    public function setNetworkLossAi($network_loss_ai)
    {
        $this->container['network_loss_ai'] = $network_loss_ai;

        return $this;
    }

    /**
     * Gets network_loss_ao
     * @return float
     */
    public function getNetworkLossAo()
    {
        return $this->container['network_loss_ao'];
    }

    /**
     * Sets network_loss_ao
     * @param float $network_loss_ao
     * @return $this
     */
    public function setNetworkLossAo($network_loss_ao)
    {
        $this->container['network_loss_ao'] = $network_loss_ao;

        return $this;
    }

    /**
     * Gets network_loss_vi
     * @return float
     */
    public function getNetworkLossVi()
    {
        return $this->container['network_loss_vi'];
    }

    /**
     * Sets network_loss_vi
     * @param float $network_loss_vi
     * @return $this
     */
    public function setNetworkLossVi($network_loss_vi)
    {
        $this->container['network_loss_vi'] = $network_loss_vi;

        return $this;
    }

    /**
     * Gets network_loss_vo
     * @return float
     */
    public function getNetworkLossVo()
    {
        return $this->container['network_loss_vo'];
    }

    /**
     * Sets network_loss_vo
     * @param float $network_loss_vo
     * @return $this
     */
    public function setNetworkLossVo($network_loss_vo)
    {
        $this->container['network_loss_vo'] = $network_loss_vo;

        return $this;
    }

    /**
     * Gets call_quality_min
     * @return float
     */
    public function getCallQualityMin()
    {
        return $this->container['call_quality_min'];
    }

    /**
     * Sets call_quality_min
     * @param float $call_quality_min
     * @return $this
     */
    public function setCallQualityMin($call_quality_min)
    {
        $this->container['call_quality_min'] = $call_quality_min;

        return $this;
    }

    /**
     * Gets call_quality_max
     * @return float
     */
    public function getCallQualityMax()
    {
        return $this->container['call_quality_max'];
    }

    /**
     * Sets call_quality_max
     * @param float $call_quality_max
     * @return $this
     */
    public function setCallQualityMax($call_quality_max)
    {
        $this->container['call_quality_max'] = $call_quality_max;

        return $this;
    }

    /**
     * Gets call_quality_avg
     * @return float
     */
    public function getCallQualityAvg()
    {
        return $this->container['call_quality_avg'];
    }

    /**
     * Sets call_quality_avg
     * @param float $call_quality_avg
     * @return $this
     */
    public function setCallQualityAvg($call_quality_avg)
    {
        $this->container['call_quality_avg'] = $call_quality_avg;

        return $this;
    }

    /**
     * Gets fps_min_vi
     * @return float
     */
    public function getFpsMinVi()
    {
        return $this->container['fps_min_vi'];
    }

    /**
     * Sets fps_min_vi
     * @param float $fps_min_vi
     * @return $this
     */
    public function setFpsMinVi($fps_min_vi)
    {
        $this->container['fps_min_vi'] = $fps_min_vi;

        return $this;
    }

    /**
     * Gets fps_min_vo
     * @return float
     */
    public function getFpsMinVo()
    {
        return $this->container['fps_min_vo'];
    }

    /**
     * Sets fps_min_vo
     * @param float $fps_min_vo
     * @return $this
     */
    public function setFpsMinVo($fps_min_vo)
    {
        $this->container['fps_min_vo'] = $fps_min_vo;

        return $this;
    }

    /**
     * Gets fps_min_vic
     * @return float
     */
    public function getFpsMinVic()
    {
        return $this->container['fps_min_vic'];
    }

    /**
     * Sets fps_min_vic
     * @param float $fps_min_vic
     * @return $this
     */
    public function setFpsMinVic($fps_min_vic)
    {
        $this->container['fps_min_vic'] = $fps_min_vic;

        return $this;
    }

    /**
     * Gets fps_min_voc
     * @return float
     */
    public function getFpsMinVoc()
    {
        return $this->container['fps_min_voc'];
    }

    /**
     * Sets fps_min_voc
     * @param float $fps_min_voc
     * @return $this
     */
    public function setFpsMinVoc($fps_min_voc)
    {
        $this->container['fps_min_voc'] = $fps_min_voc;

        return $this;
    }

    /**
     * Gets fps_max_vi
     * @return float
     */
    public function getFpsMaxVi()
    {
        return $this->container['fps_max_vi'];
    }

    /**
     * Sets fps_max_vi
     * @param float $fps_max_vi
     * @return $this
     */
    public function setFpsMaxVi($fps_max_vi)
    {
        $this->container['fps_max_vi'] = $fps_max_vi;

        return $this;
    }

    /**
     * Gets fps_max_vo
     * @return float
     */
    public function getFpsMaxVo()
    {
        return $this->container['fps_max_vo'];
    }

    /**
     * Sets fps_max_vo
     * @param float $fps_max_vo
     * @return $this
     */
    public function setFpsMaxVo($fps_max_vo)
    {
        $this->container['fps_max_vo'] = $fps_max_vo;

        return $this;
    }

    /**
     * Gets fps_max_vic
     * @return float
     */
    public function getFpsMaxVic()
    {
        return $this->container['fps_max_vic'];
    }

    /**
     * Sets fps_max_vic
     * @param float $fps_max_vic
     * @return $this
     */
    public function setFpsMaxVic($fps_max_vic)
    {
        $this->container['fps_max_vic'] = $fps_max_vic;

        return $this;
    }

    /**
     * Gets fps_max_voc
     * @return float
     */
    public function getFpsMaxVoc()
    {
        return $this->container['fps_max_voc'];
    }

    /**
     * Sets fps_max_voc
     * @param float $fps_max_voc
     * @return $this
     */
    public function setFpsMaxVoc($fps_max_voc)
    {
        $this->container['fps_max_voc'] = $fps_max_voc;

        return $this;
    }

    /**
     * Gets fps_avg_vi
     * @return float
     */
    public function getFpsAvgVi()
    {
        return $this->container['fps_avg_vi'];
    }

    /**
     * Sets fps_avg_vi
     * @param float $fps_avg_vi
     * @return $this
     */
    public function setFpsAvgVi($fps_avg_vi)
    {
        $this->container['fps_avg_vi'] = $fps_avg_vi;

        return $this;
    }

    /**
     * Gets fps_avg_vo
     * @return float
     */
    public function getFpsAvgVo()
    {
        return $this->container['fps_avg_vo'];
    }

    /**
     * Sets fps_avg_vo
     * @param float $fps_avg_vo
     * @return $this
     */
    public function setFpsAvgVo($fps_avg_vo)
    {
        $this->container['fps_avg_vo'] = $fps_avg_vo;

        return $this;
    }

    /**
     * Gets fps_avg_vic
     * @return float
     */
    public function getFpsAvgVic()
    {
        return $this->container['fps_avg_vic'];
    }

    /**
     * Sets fps_avg_vic
     * @param float $fps_avg_vic
     * @return $this
     */
    public function setFpsAvgVic($fps_avg_vic)
    {
        $this->container['fps_avg_vic'] = $fps_avg_vic;

        return $this;
    }

    /**
     * Gets fps_avg_voc
     * @return float
     */
    public function getFpsAvgVoc()
    {
        return $this->container['fps_avg_voc'];
    }

    /**
     * Sets fps_avg_voc
     * @param float $fps_avg_voc
     * @return $this
     */
    public function setFpsAvgVoc($fps_avg_voc)
    {
        $this->container['fps_avg_voc'] = $fps_avg_voc;

        return $this;
    }

    /**
     * Gets bitrate_min_ai
     * @return float
     */
    public function getBitrateMinAi()
    {
        return $this->container['bitrate_min_ai'];
    }

    /**
     * Sets bitrate_min_ai
     * @param float $bitrate_min_ai
     * @return $this
     */
    public function setBitrateMinAi($bitrate_min_ai)
    {
        $this->container['bitrate_min_ai'] = $bitrate_min_ai;

        return $this;
    }

    /**
     * Gets bitrate_min_ao
     * @return float
     */
    public function getBitrateMinAo()
    {
        return $this->container['bitrate_min_ao'];
    }

    /**
     * Sets bitrate_min_ao
     * @param float $bitrate_min_ao
     * @return $this
     */
    public function setBitrateMinAo($bitrate_min_ao)
    {
        $this->container['bitrate_min_ao'] = $bitrate_min_ao;

        return $this;
    }

    /**
     * Gets bitrate_min_vi
     * @return float
     */
    public function getBitrateMinVi()
    {
        return $this->container['bitrate_min_vi'];
    }

    /**
     * Sets bitrate_min_vi
     * @param float $bitrate_min_vi
     * @return $this
     */
    public function setBitrateMinVi($bitrate_min_vi)
    {
        $this->container['bitrate_min_vi'] = $bitrate_min_vi;

        return $this;
    }

    /**
     * Gets bitrate_min_vo
     * @return float
     */
    public function getBitrateMinVo()
    {
        return $this->container['bitrate_min_vo'];
    }

    /**
     * Sets bitrate_min_vo
     * @param float $bitrate_min_vo
     * @return $this
     */
    public function setBitrateMinVo($bitrate_min_vo)
    {
        $this->container['bitrate_min_vo'] = $bitrate_min_vo;

        return $this;
    }

    /**
     * Gets bitrate_min_vic
     * @return float
     */
    public function getBitrateMinVic()
    {
        return $this->container['bitrate_min_vic'];
    }

    /**
     * Sets bitrate_min_vic
     * @param float $bitrate_min_vic
     * @return $this
     */
    public function setBitrateMinVic($bitrate_min_vic)
    {
        $this->container['bitrate_min_vic'] = $bitrate_min_vic;

        return $this;
    }

    /**
     * Gets bitrate_min_voc
     * @return float
     */
    public function getBitrateMinVoc()
    {
        return $this->container['bitrate_min_voc'];
    }

    /**
     * Sets bitrate_min_voc
     * @param float $bitrate_min_voc
     * @return $this
     */
    public function setBitrateMinVoc($bitrate_min_voc)
    {
        $this->container['bitrate_min_voc'] = $bitrate_min_voc;

        return $this;
    }

    /**
     * Gets bitrate_max_ai
     * @return float
     */
    public function getBitrateMaxAi()
    {
        return $this->container['bitrate_max_ai'];
    }

    /**
     * Sets bitrate_max_ai
     * @param float $bitrate_max_ai
     * @return $this
     */
    public function setBitrateMaxAi($bitrate_max_ai)
    {
        $this->container['bitrate_max_ai'] = $bitrate_max_ai;

        return $this;
    }

    /**
     * Gets bitrate_max_ao
     * @return float
     */
    public function getBitrateMaxAo()
    {
        return $this->container['bitrate_max_ao'];
    }

    /**
     * Sets bitrate_max_ao
     * @param float $bitrate_max_ao
     * @return $this
     */
    public function setBitrateMaxAo($bitrate_max_ao)
    {
        $this->container['bitrate_max_ao'] = $bitrate_max_ao;

        return $this;
    }

    /**
     * Gets bitrate_max_vi
     * @return float
     */
    public function getBitrateMaxVi()
    {
        return $this->container['bitrate_max_vi'];
    }

    /**
     * Sets bitrate_max_vi
     * @param float $bitrate_max_vi
     * @return $this
     */
    public function setBitrateMaxVi($bitrate_max_vi)
    {
        $this->container['bitrate_max_vi'] = $bitrate_max_vi;

        return $this;
    }

    /**
     * Gets bitrate_max_vo
     * @return float
     */
    public function getBitrateMaxVo()
    {
        return $this->container['bitrate_max_vo'];
    }

    /**
     * Sets bitrate_max_vo
     * @param float $bitrate_max_vo
     * @return $this
     */
    public function setBitrateMaxVo($bitrate_max_vo)
    {
        $this->container['bitrate_max_vo'] = $bitrate_max_vo;

        return $this;
    }

    /**
     * Gets bitrate_max_vic
     * @return float
     */
    public function getBitrateMaxVic()
    {
        return $this->container['bitrate_max_vic'];
    }

    /**
     * Sets bitrate_max_vic
     * @param float $bitrate_max_vic
     * @return $this
     */
    public function setBitrateMaxVic($bitrate_max_vic)
    {
        $this->container['bitrate_max_vic'] = $bitrate_max_vic;

        return $this;
    }

    /**
     * Gets bitrate_max_voc
     * @return float
     */
    public function getBitrateMaxVoc()
    {
        return $this->container['bitrate_max_voc'];
    }

    /**
     * Sets bitrate_max_voc
     * @param float $bitrate_max_voc
     * @return $this
     */
    public function setBitrateMaxVoc($bitrate_max_voc)
    {
        $this->container['bitrate_max_voc'] = $bitrate_max_voc;

        return $this;
    }

    /**
     * Gets bitrate_avg_ai
     * @return float
     */
    public function getBitrateAvgAi()
    {
        return $this->container['bitrate_avg_ai'];
    }

    /**
     * Sets bitrate_avg_ai
     * @param float $bitrate_avg_ai
     * @return $this
     */
    public function setBitrateAvgAi($bitrate_avg_ai)
    {
        $this->container['bitrate_avg_ai'] = $bitrate_avg_ai;

        return $this;
    }

    /**
     * Gets bitrate_avg_ao
     * @return float
     */
    public function getBitrateAvgAo()
    {
        return $this->container['bitrate_avg_ao'];
    }

    /**
     * Sets bitrate_avg_ao
     * @param float $bitrate_avg_ao
     * @return $this
     */
    public function setBitrateAvgAo($bitrate_avg_ao)
    {
        $this->container['bitrate_avg_ao'] = $bitrate_avg_ao;

        return $this;
    }

    /**
     * Gets bitrate_avg_vi
     * @return float
     */
    public function getBitrateAvgVi()
    {
        return $this->container['bitrate_avg_vi'];
    }

    /**
     * Sets bitrate_avg_vi
     * @param float $bitrate_avg_vi
     * @return $this
     */
    public function setBitrateAvgVi($bitrate_avg_vi)
    {
        $this->container['bitrate_avg_vi'] = $bitrate_avg_vi;

        return $this;
    }

    /**
     * Gets bitrate_avg_vo
     * @return float
     */
    public function getBitrateAvgVo()
    {
        return $this->container['bitrate_avg_vo'];
    }

    /**
     * Sets bitrate_avg_vo
     * @param float $bitrate_avg_vo
     * @return $this
     */
    public function setBitrateAvgVo($bitrate_avg_vo)
    {
        $this->container['bitrate_avg_vo'] = $bitrate_avg_vo;

        return $this;
    }

    /**
     * Gets bitrate_avg_vic
     * @return float
     */
    public function getBitrateAvgVic()
    {
        return $this->container['bitrate_avg_vic'];
    }

    /**
     * Sets bitrate_avg_vic
     * @param float $bitrate_avg_vic
     * @return $this
     */
    public function setBitrateAvgVic($bitrate_avg_vic)
    {
        $this->container['bitrate_avg_vic'] = $bitrate_avg_vic;

        return $this;
    }

    /**
     * Gets bitrate_avg_voc
     * @return float
     */
    public function getBitrateAvgVoc()
    {
        return $this->container['bitrate_avg_voc'];
    }

    /**
     * Sets bitrate_avg_voc
     * @param float $bitrate_avg_voc
     * @return $this
     */
    public function setBitrateAvgVoc($bitrate_avg_voc)
    {
        $this->container['bitrate_avg_voc'] = $bitrate_avg_voc;

        return $this;
    }

    /**
     * Gets jitter_min_ai
     * @return float
     */
    public function getJitterMinAi()
    {
        return $this->container['jitter_min_ai'];
    }

    /**
     * Sets jitter_min_ai
     * @param float $jitter_min_ai
     * @return $this
     */
    public function setJitterMinAi($jitter_min_ai)
    {
        $this->container['jitter_min_ai'] = $jitter_min_ai;

        return $this;
    }

    /**
     * Gets jitter_min_ao
     * @return float
     */
    public function getJitterMinAo()
    {
        return $this->container['jitter_min_ao'];
    }

    /**
     * Sets jitter_min_ao
     * @param float $jitter_min_ao
     * @return $this
     */
    public function setJitterMinAo($jitter_min_ao)
    {
        $this->container['jitter_min_ao'] = $jitter_min_ao;

        return $this;
    }

    /**
     * Gets jitter_min_vi
     * @return float
     */
    public function getJitterMinVi()
    {
        return $this->container['jitter_min_vi'];
    }

    /**
     * Sets jitter_min_vi
     * @param float $jitter_min_vi
     * @return $this
     */
    public function setJitterMinVi($jitter_min_vi)
    {
        $this->container['jitter_min_vi'] = $jitter_min_vi;

        return $this;
    }

    /**
     * Gets jitter_min_vo
     * @return float
     */
    public function getJitterMinVo()
    {
        return $this->container['jitter_min_vo'];
    }

    /**
     * Sets jitter_min_vo
     * @param float $jitter_min_vo
     * @return $this
     */
    public function setJitterMinVo($jitter_min_vo)
    {
        $this->container['jitter_min_vo'] = $jitter_min_vo;

        return $this;
    }

    /**
     * Gets jitter_min_vic
     * @return float
     */
    public function getJitterMinVic()
    {
        return $this->container['jitter_min_vic'];
    }

    /**
     * Sets jitter_min_vic
     * @param float $jitter_min_vic
     * @return $this
     */
    public function setJitterMinVic($jitter_min_vic)
    {
        $this->container['jitter_min_vic'] = $jitter_min_vic;

        return $this;
    }

    /**
     * Gets jitter_min_voc
     * @return float
     */
    public function getJitterMinVoc()
    {
        return $this->container['jitter_min_voc'];
    }

    /**
     * Sets jitter_min_voc
     * @param float $jitter_min_voc
     * @return $this
     */
    public function setJitterMinVoc($jitter_min_voc)
    {
        $this->container['jitter_min_voc'] = $jitter_min_voc;

        return $this;
    }

    /**
     * Gets jitter_max_ai
     * @return float
     */
    public function getJitterMaxAi()
    {
        return $this->container['jitter_max_ai'];
    }

    /**
     * Sets jitter_max_ai
     * @param float $jitter_max_ai
     * @return $this
     */
    public function setJitterMaxAi($jitter_max_ai)
    {
        $this->container['jitter_max_ai'] = $jitter_max_ai;

        return $this;
    }

    /**
     * Gets jitter_max_ao
     * @return float
     */
    public function getJitterMaxAo()
    {
        return $this->container['jitter_max_ao'];
    }

    /**
     * Sets jitter_max_ao
     * @param float $jitter_max_ao
     * @return $this
     */
    public function setJitterMaxAo($jitter_max_ao)
    {
        $this->container['jitter_max_ao'] = $jitter_max_ao;

        return $this;
    }

    /**
     * Gets jitter_max_vi
     * @return float
     */
    public function getJitterMaxVi()
    {
        return $this->container['jitter_max_vi'];
    }

    /**
     * Sets jitter_max_vi
     * @param float $jitter_max_vi
     * @return $this
     */
    public function setJitterMaxVi($jitter_max_vi)
    {
        $this->container['jitter_max_vi'] = $jitter_max_vi;

        return $this;
    }

    /**
     * Gets jitter_max_vo
     * @return float
     */
    public function getJitterMaxVo()
    {
        return $this->container['jitter_max_vo'];
    }

    /**
     * Sets jitter_max_vo
     * @param float $jitter_max_vo
     * @return $this
     */
    public function setJitterMaxVo($jitter_max_vo)
    {
        $this->container['jitter_max_vo'] = $jitter_max_vo;

        return $this;
    }

    /**
     * Gets jitter_max_vic
     * @return float
     */
    public function getJitterMaxVic()
    {
        return $this->container['jitter_max_vic'];
    }

    /**
     * Sets jitter_max_vic
     * @param float $jitter_max_vic
     * @return $this
     */
    public function setJitterMaxVic($jitter_max_vic)
    {
        $this->container['jitter_max_vic'] = $jitter_max_vic;

        return $this;
    }

    /**
     * Gets jitter_max_voc
     * @return float
     */
    public function getJitterMaxVoc()
    {
        return $this->container['jitter_max_voc'];
    }

    /**
     * Sets jitter_max_voc
     * @param float $jitter_max_voc
     * @return $this
     */
    public function setJitterMaxVoc($jitter_max_voc)
    {
        $this->container['jitter_max_voc'] = $jitter_max_voc;

        return $this;
    }

    /**
     * Gets jitter_avg_ai
     * @return float
     */
    public function getJitterAvgAi()
    {
        return $this->container['jitter_avg_ai'];
    }

    /**
     * Sets jitter_avg_ai
     * @param float $jitter_avg_ai
     * @return $this
     */
    public function setJitterAvgAi($jitter_avg_ai)
    {
        $this->container['jitter_avg_ai'] = $jitter_avg_ai;

        return $this;
    }

    /**
     * Gets jitter_avg_ao
     * @return float
     */
    public function getJitterAvgAo()
    {
        return $this->container['jitter_avg_ao'];
    }

    /**
     * Sets jitter_avg_ao
     * @param float $jitter_avg_ao
     * @return $this
     */
    public function setJitterAvgAo($jitter_avg_ao)
    {
        $this->container['jitter_avg_ao'] = $jitter_avg_ao;

        return $this;
    }

    /**
     * Gets jitter_avg_vi
     * @return float
     */
    public function getJitterAvgVi()
    {
        return $this->container['jitter_avg_vi'];
    }

    /**
     * Sets jitter_avg_vi
     * @param float $jitter_avg_vi
     * @return $this
     */
    public function setJitterAvgVi($jitter_avg_vi)
    {
        $this->container['jitter_avg_vi'] = $jitter_avg_vi;

        return $this;
    }

    /**
     * Gets jitter_avg_vo
     * @return float
     */
    public function getJitterAvgVo()
    {
        return $this->container['jitter_avg_vo'];
    }

    /**
     * Sets jitter_avg_vo
     * @param float $jitter_avg_vo
     * @return $this
     */
    public function setJitterAvgVo($jitter_avg_vo)
    {
        $this->container['jitter_avg_vo'] = $jitter_avg_vo;

        return $this;
    }

    /**
     * Gets jitter_avg_vic
     * @return float
     */
    public function getJitterAvgVic()
    {
        return $this->container['jitter_avg_vic'];
    }

    /**
     * Sets jitter_avg_vic
     * @param float $jitter_avg_vic
     * @return $this
     */
    public function setJitterAvgVic($jitter_avg_vic)
    {
        $this->container['jitter_avg_vic'] = $jitter_avg_vic;

        return $this;
    }

    /**
     * Gets jitter_avg_voc
     * @return float
     */
    public function getJitterAvgVoc()
    {
        return $this->container['jitter_avg_voc'];
    }

    /**
     * Sets jitter_avg_voc
     * @param float $jitter_avg_voc
     * @return $this
     */
    public function setJitterAvgVoc($jitter_avg_voc)
    {
        $this->container['jitter_avg_voc'] = $jitter_avg_voc;

        return $this;
    }

    /**
     * Gets max_jitter_min_ai
     * @return float
     */
    public function getMaxJitterMinAi()
    {
        return $this->container['max_jitter_min_ai'];
    }

    /**
     * Sets max_jitter_min_ai
     * @param float $max_jitter_min_ai
     * @return $this
     */
    public function setMaxJitterMinAi($max_jitter_min_ai)
    {
        $this->container['max_jitter_min_ai'] = $max_jitter_min_ai;

        return $this;
    }

    /**
     * Gets max_jitter_min_vi
     * @return float
     */
    public function getMaxJitterMinVi()
    {
        return $this->container['max_jitter_min_vi'];
    }

    /**
     * Sets max_jitter_min_vi
     * @param float $max_jitter_min_vi
     * @return $this
     */
    public function setMaxJitterMinVi($max_jitter_min_vi)
    {
        $this->container['max_jitter_min_vi'] = $max_jitter_min_vi;

        return $this;
    }

    /**
     * Gets max_jitter_min_vic
     * @return float
     */
    public function getMaxJitterMinVic()
    {
        return $this->container['max_jitter_min_vic'];
    }

    /**
     * Sets max_jitter_min_vic
     * @param float $max_jitter_min_vic
     * @return $this
     */
    public function setMaxJitterMinVic($max_jitter_min_vic)
    {
        $this->container['max_jitter_min_vic'] = $max_jitter_min_vic;

        return $this;
    }

    /**
     * Gets max_jitter_max_ai
     * @return float
     */
    public function getMaxJitterMaxAi()
    {
        return $this->container['max_jitter_max_ai'];
    }

    /**
     * Sets max_jitter_max_ai
     * @param float $max_jitter_max_ai
     * @return $this
     */
    public function setMaxJitterMaxAi($max_jitter_max_ai)
    {
        $this->container['max_jitter_max_ai'] = $max_jitter_max_ai;

        return $this;
    }

    /**
     * Gets max_jitter_max_vi
     * @return float
     */
    public function getMaxJitterMaxVi()
    {
        return $this->container['max_jitter_max_vi'];
    }

    /**
     * Sets max_jitter_max_vi
     * @param float $max_jitter_max_vi
     * @return $this
     */
    public function setMaxJitterMaxVi($max_jitter_max_vi)
    {
        $this->container['max_jitter_max_vi'] = $max_jitter_max_vi;

        return $this;
    }

    /**
     * Gets max_jitter_max_vic
     * @return float
     */
    public function getMaxJitterMaxVic()
    {
        return $this->container['max_jitter_max_vic'];
    }

    /**
     * Sets max_jitter_max_vic
     * @param float $max_jitter_max_vic
     * @return $this
     */
    public function setMaxJitterMaxVic($max_jitter_max_vic)
    {
        $this->container['max_jitter_max_vic'] = $max_jitter_max_vic;

        return $this;
    }

    /**
     * Gets max_jitter_avg_ai
     * @return float
     */
    public function getMaxJitterAvgAi()
    {
        return $this->container['max_jitter_avg_ai'];
    }

    /**
     * Sets max_jitter_avg_ai
     * @param float $max_jitter_avg_ai
     * @return $this
     */
    public function setMaxJitterAvgAi($max_jitter_avg_ai)
    {
        $this->container['max_jitter_avg_ai'] = $max_jitter_avg_ai;

        return $this;
    }

    /**
     * Gets max_jitter_avg_vi
     * @return float
     */
    public function getMaxJitterAvgVi()
    {
        return $this->container['max_jitter_avg_vi'];
    }

    /**
     * Sets max_jitter_avg_vi
     * @param float $max_jitter_avg_vi
     * @return $this
     */
    public function setMaxJitterAvgVi($max_jitter_avg_vi)
    {
        $this->container['max_jitter_avg_vi'] = $max_jitter_avg_vi;

        return $this;
    }

    /**
     * Gets max_jitter_avg_vic
     * @return float
     */
    public function getMaxJitterAvgVic()
    {
        return $this->container['max_jitter_avg_vic'];
    }

    /**
     * Sets max_jitter_avg_vic
     * @param float $max_jitter_avg_vic
     * @return $this
     */
    public function setMaxJitterAvgVic($max_jitter_avg_vic)
    {
        $this->container['max_jitter_avg_vic'] = $max_jitter_avg_vic;

        return $this;
    }

    /**
     * Gets video_recv_height_min
     * @return float
     */
    public function getVideoRecvHeightMin()
    {
        return $this->container['video_recv_height_min'];
    }

    /**
     * Sets video_recv_height_min
     * @param float $video_recv_height_min
     * @return $this
     */
    public function setVideoRecvHeightMin($video_recv_height_min)
    {
        $this->container['video_recv_height_min'] = $video_recv_height_min;

        return $this;
    }

    /**
     * Gets video_recv_height_max
     * @return float
     */
    public function getVideoRecvHeightMax()
    {
        return $this->container['video_recv_height_max'];
    }

    /**
     * Sets video_recv_height_max
     * @param float $video_recv_height_max
     * @return $this
     */
    public function setVideoRecvHeightMax($video_recv_height_max)
    {
        $this->container['video_recv_height_max'] = $video_recv_height_max;

        return $this;
    }

    /**
     * Gets video_recv_width_min
     * @return float
     */
    public function getVideoRecvWidthMin()
    {
        return $this->container['video_recv_width_min'];
    }

    /**
     * Sets video_recv_width_min
     * @param float $video_recv_width_min
     * @return $this
     */
    public function setVideoRecvWidthMin($video_recv_width_min)
    {
        $this->container['video_recv_width_min'] = $video_recv_width_min;

        return $this;
    }

    /**
     * Gets video_recv_width_max
     * @return float
     */
    public function getVideoRecvWidthMax()
    {
        return $this->container['video_recv_width_max'];
    }

    /**
     * Sets video_recv_width_max
     * @param float $video_recv_width_max
     * @return $this
     */
    public function setVideoRecvWidthMax($video_recv_width_max)
    {
        $this->container['video_recv_width_max'] = $video_recv_width_max;

        return $this;
    }

    /**
     * Gets video_send_height_min
     * @return float
     */
    public function getVideoSendHeightMin()
    {
        return $this->container['video_send_height_min'];
    }

    /**
     * Sets video_send_height_min
     * @param float $video_send_height_min
     * @return $this
     */
    public function setVideoSendHeightMin($video_send_height_min)
    {
        $this->container['video_send_height_min'] = $video_send_height_min;

        return $this;
    }

    /**
     * Gets video_send_height_max
     * @return float
     */
    public function getVideoSendHeightMax()
    {
        return $this->container['video_send_height_max'];
    }

    /**
     * Sets video_send_height_max
     * @param float $video_send_height_max
     * @return $this
     */
    public function setVideoSendHeightMax($video_send_height_max)
    {
        $this->container['video_send_height_max'] = $video_send_height_max;

        return $this;
    }

    /**
     * Gets video_send_width_min
     * @return float
     */
    public function getVideoSendWidthMin()
    {
        return $this->container['video_send_width_min'];
    }

    /**
     * Sets video_send_width_min
     * @param float $video_send_width_min
     * @return $this
     */
    public function setVideoSendWidthMin($video_send_width_min)
    {
        $this->container['video_send_width_min'] = $video_send_width_min;

        return $this;
    }

    /**
     * Gets video_send_width_max
     * @return float
     */
    public function getVideoSendWidthMax()
    {
        return $this->container['video_send_width_max'];
    }

    /**
     * Sets video_send_width_max
     * @param float $video_send_width_max
     * @return $this
     */
    public function setVideoSendWidthMax($video_send_width_max)
    {
        $this->container['video_send_width_max'] = $video_send_width_max;

        return $this;
    }

    /**
     * Gets content_recv_height_min
     * @return float
     */
    public function getContentRecvHeightMin()
    {
        return $this->container['content_recv_height_min'];
    }

    /**
     * Sets content_recv_height_min
     * @param float $content_recv_height_min
     * @return $this
     */
    public function setContentRecvHeightMin($content_recv_height_min)
    {
        $this->container['content_recv_height_min'] = $content_recv_height_min;

        return $this;
    }

    /**
     * Gets content_recv_height_max
     * @return float
     */
    public function getContentRecvHeightMax()
    {
        return $this->container['content_recv_height_max'];
    }

    /**
     * Sets content_recv_height_max
     * @param float $content_recv_height_max
     * @return $this
     */
    public function setContentRecvHeightMax($content_recv_height_max)
    {
        $this->container['content_recv_height_max'] = $content_recv_height_max;

        return $this;
    }

    /**
     * Gets content_recv_width_min
     * @return float
     */
    public function getContentRecvWidthMin()
    {
        return $this->container['content_recv_width_min'];
    }

    /**
     * Sets content_recv_width_min
     * @param float $content_recv_width_min
     * @return $this
     */
    public function setContentRecvWidthMin($content_recv_width_min)
    {
        $this->container['content_recv_width_min'] = $content_recv_width_min;

        return $this;
    }

    /**
     * Gets content_recv_width_max
     * @return float
     */
    public function getContentRecvWidthMax()
    {
        return $this->container['content_recv_width_max'];
    }

    /**
     * Sets content_recv_width_max
     * @param float $content_recv_width_max
     * @return $this
     */
    public function setContentRecvWidthMax($content_recv_width_max)
    {
        $this->container['content_recv_width_max'] = $content_recv_width_max;

        return $this;
    }

    /**
     * Gets content_send_height_min
     * @return float
     */
    public function getContentSendHeightMin()
    {
        return $this->container['content_send_height_min'];
    }

    /**
     * Sets content_send_height_min
     * @param float $content_send_height_min
     * @return $this
     */
    public function setContentSendHeightMin($content_send_height_min)
    {
        $this->container['content_send_height_min'] = $content_send_height_min;

        return $this;
    }

    /**
     * Gets content_send_height_max
     * @return float
     */
    public function getContentSendHeightMax()
    {
        return $this->container['content_send_height_max'];
    }

    /**
     * Sets content_send_height_max
     * @param float $content_send_height_max
     * @return $this
     */
    public function setContentSendHeightMax($content_send_height_max)
    {
        $this->container['content_send_height_max'] = $content_send_height_max;

        return $this;
    }

    /**
     * Gets content_send_width_min
     * @return float
     */
    public function getContentSendWidthMin()
    {
        return $this->container['content_send_width_min'];
    }

    /**
     * Sets content_send_width_min
     * @param float $content_send_width_min
     * @return $this
     */
    public function setContentSendWidthMin($content_send_width_min)
    {
        $this->container['content_send_width_min'] = $content_send_width_min;

        return $this;
    }

    /**
     * Gets content_send_width_max
     * @return float
     */
    public function getContentSendWidthMax()
    {
        return $this->container['content_send_width_max'];
    }

    /**
     * Sets content_send_width_max
     * @param float $content_send_width_max
     * @return $this
     */
    public function setContentSendWidthMax($content_send_width_max)
    {
        $this->container['content_send_width_max'] = $content_send_width_max;

        return $this;
    }

    /**
     * Gets round_trip_delay_min
     * @return float
     */
    public function getRoundTripDelayMin()
    {
        return $this->container['round_trip_delay_min'];
    }

    /**
     * Sets round_trip_delay_min
     * @param float $round_trip_delay_min
     * @return $this
     */
    public function setRoundTripDelayMin($round_trip_delay_min)
    {
        $this->container['round_trip_delay_min'] = $round_trip_delay_min;

        return $this;
    }

    /**
     * Gets round_trip_delay_max
     * @return float
     */
    public function getRoundTripDelayMax()
    {
        return $this->container['round_trip_delay_max'];
    }

    /**
     * Sets round_trip_delay_max
     * @param float $round_trip_delay_max
     * @return $this
     */
    public function setRoundTripDelayMax($round_trip_delay_max)
    {
        $this->container['round_trip_delay_max'] = $round_trip_delay_max;

        return $this;
    }

    /**
     * Gets round_trip_delay_avg
     * @return float
     */
    public function getRoundTripDelayAvg()
    {
        return $this->container['round_trip_delay_avg'];
    }

    /**
     * Sets round_trip_delay_avg
     * @param float $round_trip_delay_avg
     * @return $this
     */
    public function setRoundTripDelayAvg($round_trip_delay_avg)
    {
        $this->container['round_trip_delay_avg'] = $round_trip_delay_avg;

        return $this;
    }

    /**
     * Gets rfactor_min
     * @return float
     */
    public function getRfactorMin()
    {
        return $this->container['rfactor_min'];
    }

    /**
     * Sets rfactor_min
     * @param float $rfactor_min
     * @return $this
     */
    public function setRfactorMin($rfactor_min)
    {
        $this->container['rfactor_min'] = $rfactor_min;

        return $this;
    }

    /**
     * Gets rfactor_max
     * @return float
     */
    public function getRfactorMax()
    {
        return $this->container['rfactor_max'];
    }

    /**
     * Sets rfactor_max
     * @param float $rfactor_max
     * @return $this
     */
    public function setRfactorMax($rfactor_max)
    {
        $this->container['rfactor_max'] = $rfactor_max;

        return $this;
    }

    /**
     * Gets rfactor_avg
     * @return float
     */
    public function getRfactorAvg()
    {
        return $this->container['rfactor_avg'];
    }

    /**
     * Sets rfactor_avg
     * @param float $rfactor_avg
     * @return $this
     */
    public function setRfactorAvg($rfactor_avg)
    {
        $this->container['rfactor_avg'] = $rfactor_avg;

        return $this;
    }

    /**
     * Gets process_cpu_load_min
     * @return float
     */
    public function getProcessCpuLoadMin()
    {
        return $this->container['process_cpu_load_min'];
    }

    /**
     * Sets process_cpu_load_min
     * @param float $process_cpu_load_min
     * @return $this
     */
    public function setProcessCpuLoadMin($process_cpu_load_min)
    {
        $this->container['process_cpu_load_min'] = $process_cpu_load_min;

        return $this;
    }

    /**
     * Gets process_cpu_load_max
     * @return float
     */
    public function getProcessCpuLoadMax()
    {
        return $this->container['process_cpu_load_max'];
    }

    /**
     * Sets process_cpu_load_max
     * @param float $process_cpu_load_max
     * @return $this
     */
    public function setProcessCpuLoadMax($process_cpu_load_max)
    {
        $this->container['process_cpu_load_max'] = $process_cpu_load_max;

        return $this;
    }

    /**
     * Gets process_cpu_load_avg
     * @return float
     */
    public function getProcessCpuLoadAvg()
    {
        return $this->container['process_cpu_load_avg'];
    }

    /**
     * Sets process_cpu_load_avg
     * @param float $process_cpu_load_avg
     * @return $this
     */
    public function setProcessCpuLoadAvg($process_cpu_load_avg)
    {
        $this->container['process_cpu_load_avg'] = $process_cpu_load_avg;

        return $this;
    }

    /**
     * Gets system_cpu_load_min
     * @return float
     */
    public function getSystemCpuLoadMin()
    {
        return $this->container['system_cpu_load_min'];
    }

    /**
     * Sets system_cpu_load_min
     * @param float $system_cpu_load_min
     * @return $this
     */
    public function setSystemCpuLoadMin($system_cpu_load_min)
    {
        $this->container['system_cpu_load_min'] = $system_cpu_load_min;

        return $this;
    }

    /**
     * Gets system_cpu_load_max
     * @return float
     */
    public function getSystemCpuLoadMax()
    {
        return $this->container['system_cpu_load_max'];
    }

    /**
     * Sets system_cpu_load_max
     * @param float $system_cpu_load_max
     * @return $this
     */
    public function setSystemCpuLoadMax($system_cpu_load_max)
    {
        $this->container['system_cpu_load_max'] = $system_cpu_load_max;

        return $this;
    }

    /**
     * Gets system_cpu_load_avg
     * @return float
     */
    public function getSystemCpuLoadAvg()
    {
        return $this->container['system_cpu_load_avg'];
    }

    /**
     * Sets system_cpu_load_avg
     * @param float $system_cpu_load_avg
     * @return $this
     */
    public function setSystemCpuLoadAvg($system_cpu_load_avg)
    {
        $this->container['system_cpu_load_avg'] = $system_cpu_load_avg;

        return $this;
    }

    /**
     * Gets wifi_recv_strength_min
     * @return float
     */
    public function getWifiRecvStrengthMin()
    {
        return $this->container['wifi_recv_strength_min'];
    }

    /**
     * Sets wifi_recv_strength_min
     * @param float $wifi_recv_strength_min
     * @return $this
     */
    public function setWifiRecvStrengthMin($wifi_recv_strength_min)
    {
        $this->container['wifi_recv_strength_min'] = $wifi_recv_strength_min;

        return $this;
    }

    /**
     * Gets wifi_recv_strength_max
     * @return float
     */
    public function getWifiRecvStrengthMax()
    {
        return $this->container['wifi_recv_strength_max'];
    }

    /**
     * Sets wifi_recv_strength_max
     * @param float $wifi_recv_strength_max
     * @return $this
     */
    public function setWifiRecvStrengthMax($wifi_recv_strength_max)
    {
        $this->container['wifi_recv_strength_max'] = $wifi_recv_strength_max;

        return $this;
    }

    /**
     * Gets wifi_recv_strength_avg
     * @return float
     */
    public function getWifiRecvStrengthAvg()
    {
        return $this->container['wifi_recv_strength_avg'];
    }

    /**
     * Sets wifi_recv_strength_avg
     * @param float $wifi_recv_strength_avg
     * @return $this
     */
    public function setWifiRecvStrengthAvg($wifi_recv_strength_avg)
    {
        $this->container['wifi_recv_strength_avg'] = $wifi_recv_strength_avg;

        return $this;
    }

    /**
     * Gets key_frame_rate_avg_vi
     * @return float
     */
    public function getKeyFrameRateAvgVi()
    {
        return $this->container['key_frame_rate_avg_vi'];
    }

    /**
     * Sets key_frame_rate_avg_vi
     * @param float $key_frame_rate_avg_vi
     * @return $this
     */
    public function setKeyFrameRateAvgVi($key_frame_rate_avg_vi)
    {
        $this->container['key_frame_rate_avg_vi'] = $key_frame_rate_avg_vi;

        return $this;
    }

    /**
     * Gets key_frame_rate_avg_vo
     * @return float
     */
    public function getKeyFrameRateAvgVo()
    {
        return $this->container['key_frame_rate_avg_vo'];
    }

    /**
     * Sets key_frame_rate_avg_vo
     * @param float $key_frame_rate_avg_vo
     * @return $this
     */
    public function setKeyFrameRateAvgVo($key_frame_rate_avg_vo)
    {
        $this->container['key_frame_rate_avg_vo'] = $key_frame_rate_avg_vo;

        return $this;
    }

    /**
     * Gets key_frame_rate_avg_vic
     * @return float
     */
    public function getKeyFrameRateAvgVic()
    {
        return $this->container['key_frame_rate_avg_vic'];
    }

    /**
     * Sets key_frame_rate_avg_vic
     * @param float $key_frame_rate_avg_vic
     * @return $this
     */
    public function setKeyFrameRateAvgVic($key_frame_rate_avg_vic)
    {
        $this->container['key_frame_rate_avg_vic'] = $key_frame_rate_avg_vic;

        return $this;
    }

    /**
     * Gets key_frame_rate_avg_voc
     * @return float
     */
    public function getKeyFrameRateAvgVoc()
    {
        return $this->container['key_frame_rate_avg_voc'];
    }

    /**
     * Sets key_frame_rate_avg_voc
     * @param float $key_frame_rate_avg_voc
     * @return $this
     */
    public function setKeyFrameRateAvgVoc($key_frame_rate_avg_voc)
    {
        $this->container['key_frame_rate_avg_voc'] = $key_frame_rate_avg_voc;

        return $this;
    }

    /**
     * Gets key_frame_rate_min_vi
     * @return float
     */
    public function getKeyFrameRateMinVi()
    {
        return $this->container['key_frame_rate_min_vi'];
    }

    /**
     * Sets key_frame_rate_min_vi
     * @param float $key_frame_rate_min_vi
     * @return $this
     */
    public function setKeyFrameRateMinVi($key_frame_rate_min_vi)
    {
        $this->container['key_frame_rate_min_vi'] = $key_frame_rate_min_vi;

        return $this;
    }

    /**
     * Gets key_frame_rate_min_vo
     * @return float
     */
    public function getKeyFrameRateMinVo()
    {
        return $this->container['key_frame_rate_min_vo'];
    }

    /**
     * Sets key_frame_rate_min_vo
     * @param float $key_frame_rate_min_vo
     * @return $this
     */
    public function setKeyFrameRateMinVo($key_frame_rate_min_vo)
    {
        $this->container['key_frame_rate_min_vo'] = $key_frame_rate_min_vo;

        return $this;
    }

    /**
     * Gets key_frame_rate_min_vic
     * @return float
     */
    public function getKeyFrameRateMinVic()
    {
        return $this->container['key_frame_rate_min_vic'];
    }

    /**
     * Sets key_frame_rate_min_vic
     * @param float $key_frame_rate_min_vic
     * @return $this
     */
    public function setKeyFrameRateMinVic($key_frame_rate_min_vic)
    {
        $this->container['key_frame_rate_min_vic'] = $key_frame_rate_min_vic;

        return $this;
    }

    /**
     * Gets key_frame_rate_min_voc
     * @return float
     */
    public function getKeyFrameRateMinVoc()
    {
        return $this->container['key_frame_rate_min_voc'];
    }

    /**
     * Sets key_frame_rate_min_voc
     * @param float $key_frame_rate_min_voc
     * @return $this
     */
    public function setKeyFrameRateMinVoc($key_frame_rate_min_voc)
    {
        $this->container['key_frame_rate_min_voc'] = $key_frame_rate_min_voc;

        return $this;
    }

    /**
     * Gets key_frame_rate_max_vi
     * @return float
     */
    public function getKeyFrameRateMaxVi()
    {
        return $this->container['key_frame_rate_max_vi'];
    }

    /**
     * Sets key_frame_rate_max_vi
     * @param float $key_frame_rate_max_vi
     * @return $this
     */
    public function setKeyFrameRateMaxVi($key_frame_rate_max_vi)
    {
        $this->container['key_frame_rate_max_vi'] = $key_frame_rate_max_vi;

        return $this;
    }

    /**
     * Gets key_frame_rate_max_vo
     * @return float
     */
    public function getKeyFrameRateMaxVo()
    {
        return $this->container['key_frame_rate_max_vo'];
    }

    /**
     * Sets key_frame_rate_max_vo
     * @param float $key_frame_rate_max_vo
     * @return $this
     */
    public function setKeyFrameRateMaxVo($key_frame_rate_max_vo)
    {
        $this->container['key_frame_rate_max_vo'] = $key_frame_rate_max_vo;

        return $this;
    }

    /**
     * Gets key_frame_rate_max_vic
     * @return float
     */
    public function getKeyFrameRateMaxVic()
    {
        return $this->container['key_frame_rate_max_vic'];
    }

    /**
     * Sets key_frame_rate_max_vic
     * @param float $key_frame_rate_max_vic
     * @return $this
     */
    public function setKeyFrameRateMaxVic($key_frame_rate_max_vic)
    {
        $this->container['key_frame_rate_max_vic'] = $key_frame_rate_max_vic;

        return $this;
    }

    /**
     * Gets key_frame_rate_max_voc
     * @return float
     */
    public function getKeyFrameRateMaxVoc()
    {
        return $this->container['key_frame_rate_max_voc'];
    }

    /**
     * Sets key_frame_rate_max_voc
     * @param float $key_frame_rate_max_voc
     * @return $this
     */
    public function setKeyFrameRateMaxVoc($key_frame_rate_max_voc)
    {
        $this->container['key_frame_rate_max_voc'] = $key_frame_rate_max_voc;

        return $this;
    }

    /**
     * Gets round_trip_delay_avg_vo
     * @return float
     */
    public function getRoundTripDelayAvgVo()
    {
        return $this->container['round_trip_delay_avg_vo'];
    }

    /**
     * Sets round_trip_delay_avg_vo
     * @param float $round_trip_delay_avg_vo
     * @return $this
     */
    public function setRoundTripDelayAvgVo($round_trip_delay_avg_vo)
    {
        $this->container['round_trip_delay_avg_vo'] = $round_trip_delay_avg_vo;

        return $this;
    }

    /**
     * Gets round_trip_delay_avg_voc
     * @return float
     */
    public function getRoundTripDelayAvgVoc()
    {
        return $this->container['round_trip_delay_avg_voc'];
    }

    /**
     * Sets round_trip_delay_avg_voc
     * @param float $round_trip_delay_avg_voc
     * @return $this
     */
    public function setRoundTripDelayAvgVoc($round_trip_delay_avg_voc)
    {
        $this->container['round_trip_delay_avg_voc'] = $round_trip_delay_avg_voc;

        return $this;
    }

    /**
     * Gets round_trip_delay_avg_ao
     * @return float
     */
    public function getRoundTripDelayAvgAo()
    {
        return $this->container['round_trip_delay_avg_ao'];
    }

    /**
     * Sets round_trip_delay_avg_ao
     * @param float $round_trip_delay_avg_ao
     * @return $this
     */
    public function setRoundTripDelayAvgAo($round_trip_delay_avg_ao)
    {
        $this->container['round_trip_delay_avg_ao'] = $round_trip_delay_avg_ao;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     * @param  integer $offset Offset
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     * @param  integer $offset Offset
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     * @param  integer $offset Offset
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(\BlueJeansMeetingsRestApi\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\BlueJeansMeetingsRestApi\ObjectSerializer::sanitizeForSerialization($this));
    }
}


