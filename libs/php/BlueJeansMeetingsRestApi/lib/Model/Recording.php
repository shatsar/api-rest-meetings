<?php
/**
 * Recording
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
 * Recording Class Doc Comment
 *
 * @category    Class
 * @package     BlueJeansMeetingsRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class Recording implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'Recording';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'recording_entity_id' => 'int',
        'recording_entity_guid' => 'string',
        'recording_name' => 'string',
        'meeting_guid' => 'string',
        'chapter_count' => 'int',
        'total_size' => 'int',
        'total_duration' => 'int',
        'last_recording_date' => 'int',
        'aggregated_status' => 'string',
        'recording_thumbnail' => 'string',
        'created' => 'int',
        'aggregated_view_count' => 'int',
        'is_premium_recording' => 'bool',
        'show_premium_recording_tag' => 'bool',
        'recording_chapters' => '\BlueJeansMeetingsRestApi\Model\RecordingRecordingChapters[]'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerFormats = [
        'recording_entity_id' => null,
        'recording_entity_guid' => null,
        'recording_name' => null,
        'meeting_guid' => null,
        'chapter_count' => null,
        'total_size' => null,
        'total_duration' => null,
        'last_recording_date' => null,
        'aggregated_status' => null,
        'recording_thumbnail' => null,
        'created' => null,
        'aggregated_view_count' => null,
        'is_premium_recording' => null,
        'show_premium_recording_tag' => null,
        'recording_chapters' => null
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
        'recording_entity_id' => 'recordingEntityId',
        'recording_entity_guid' => 'recordingEntityGuid',
        'recording_name' => 'recordingName',
        'meeting_guid' => 'meetingGuid',
        'chapter_count' => 'chapterCount',
        'total_size' => 'totalSize',
        'total_duration' => 'totalDuration',
        'last_recording_date' => 'lastRecordingDate',
        'aggregated_status' => 'aggregatedStatus',
        'recording_thumbnail' => 'recordingThumbnail',
        'created' => 'created',
        'aggregated_view_count' => 'aggregatedViewCount',
        'is_premium_recording' => 'isPremiumRecording',
        'show_premium_recording_tag' => 'showPremiumRecordingTag',
        'recording_chapters' => 'recordingChapters'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'recording_entity_id' => 'setRecordingEntityId',
        'recording_entity_guid' => 'setRecordingEntityGuid',
        'recording_name' => 'setRecordingName',
        'meeting_guid' => 'setMeetingGuid',
        'chapter_count' => 'setChapterCount',
        'total_size' => 'setTotalSize',
        'total_duration' => 'setTotalDuration',
        'last_recording_date' => 'setLastRecordingDate',
        'aggregated_status' => 'setAggregatedStatus',
        'recording_thumbnail' => 'setRecordingThumbnail',
        'created' => 'setCreated',
        'aggregated_view_count' => 'setAggregatedViewCount',
        'is_premium_recording' => 'setIsPremiumRecording',
        'show_premium_recording_tag' => 'setShowPremiumRecordingTag',
        'recording_chapters' => 'setRecordingChapters'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'recording_entity_id' => 'getRecordingEntityId',
        'recording_entity_guid' => 'getRecordingEntityGuid',
        'recording_name' => 'getRecordingName',
        'meeting_guid' => 'getMeetingGuid',
        'chapter_count' => 'getChapterCount',
        'total_size' => 'getTotalSize',
        'total_duration' => 'getTotalDuration',
        'last_recording_date' => 'getLastRecordingDate',
        'aggregated_status' => 'getAggregatedStatus',
        'recording_thumbnail' => 'getRecordingThumbnail',
        'created' => 'getCreated',
        'aggregated_view_count' => 'getAggregatedViewCount',
        'is_premium_recording' => 'getIsPremiumRecording',
        'show_premium_recording_tag' => 'getShowPremiumRecordingTag',
        'recording_chapters' => 'getRecordingChapters'
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
        $this->container['recording_entity_id'] = isset($data['recording_entity_id']) ? $data['recording_entity_id'] : null;
        $this->container['recording_entity_guid'] = isset($data['recording_entity_guid']) ? $data['recording_entity_guid'] : null;
        $this->container['recording_name'] = isset($data['recording_name']) ? $data['recording_name'] : null;
        $this->container['meeting_guid'] = isset($data['meeting_guid']) ? $data['meeting_guid'] : null;
        $this->container['chapter_count'] = isset($data['chapter_count']) ? $data['chapter_count'] : null;
        $this->container['total_size'] = isset($data['total_size']) ? $data['total_size'] : null;
        $this->container['total_duration'] = isset($data['total_duration']) ? $data['total_duration'] : null;
        $this->container['last_recording_date'] = isset($data['last_recording_date']) ? $data['last_recording_date'] : null;
        $this->container['aggregated_status'] = isset($data['aggregated_status']) ? $data['aggregated_status'] : null;
        $this->container['recording_thumbnail'] = isset($data['recording_thumbnail']) ? $data['recording_thumbnail'] : null;
        $this->container['created'] = isset($data['created']) ? $data['created'] : null;
        $this->container['aggregated_view_count'] = isset($data['aggregated_view_count']) ? $data['aggregated_view_count'] : null;
        $this->container['is_premium_recording'] = isset($data['is_premium_recording']) ? $data['is_premium_recording'] : null;
        $this->container['show_premium_recording_tag'] = isset($data['show_premium_recording_tag']) ? $data['show_premium_recording_tag'] : null;
        $this->container['recording_chapters'] = isset($data['recording_chapters']) ? $data['recording_chapters'] : null;
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
     * Gets recording_entity_id
     * @return int
     */
    public function getRecordingEntityId()
    {
        return $this->container['recording_entity_id'];
    }

    /**
     * Sets recording_entity_id
     * @param int $recording_entity_id
     * @return $this
     */
    public function setRecordingEntityId($recording_entity_id)
    {
        $this->container['recording_entity_id'] = $recording_entity_id;

        return $this;
    }

    /**
     * Gets recording_entity_guid
     * @return string
     */
    public function getRecordingEntityGuid()
    {
        return $this->container['recording_entity_guid'];
    }

    /**
     * Sets recording_entity_guid
     * @param string $recording_entity_guid
     * @return $this
     */
    public function setRecordingEntityGuid($recording_entity_guid)
    {
        $this->container['recording_entity_guid'] = $recording_entity_guid;

        return $this;
    }

    /**
     * Gets recording_name
     * @return string
     */
    public function getRecordingName()
    {
        return $this->container['recording_name'];
    }

    /**
     * Sets recording_name
     * @param string $recording_name
     * @return $this
     */
    public function setRecordingName($recording_name)
    {
        $this->container['recording_name'] = $recording_name;

        return $this;
    }

    /**
     * Gets meeting_guid
     * @return string
     */
    public function getMeetingGuid()
    {
        return $this->container['meeting_guid'];
    }

    /**
     * Sets meeting_guid
     * @param string $meeting_guid
     * @return $this
     */
    public function setMeetingGuid($meeting_guid)
    {
        $this->container['meeting_guid'] = $meeting_guid;

        return $this;
    }

    /**
     * Gets chapter_count
     * @return int
     */
    public function getChapterCount()
    {
        return $this->container['chapter_count'];
    }

    /**
     * Sets chapter_count
     * @param int $chapter_count
     * @return $this
     */
    public function setChapterCount($chapter_count)
    {
        $this->container['chapter_count'] = $chapter_count;

        return $this;
    }

    /**
     * Gets total_size
     * @return int
     */
    public function getTotalSize()
    {
        return $this->container['total_size'];
    }

    /**
     * Sets total_size
     * @param int $total_size
     * @return $this
     */
    public function setTotalSize($total_size)
    {
        $this->container['total_size'] = $total_size;

        return $this;
    }

    /**
     * Gets total_duration
     * @return int
     */
    public function getTotalDuration()
    {
        return $this->container['total_duration'];
    }

    /**
     * Sets total_duration
     * @param int $total_duration
     * @return $this
     */
    public function setTotalDuration($total_duration)
    {
        $this->container['total_duration'] = $total_duration;

        return $this;
    }

    /**
     * Gets last_recording_date
     * @return int
     */
    public function getLastRecordingDate()
    {
        return $this->container['last_recording_date'];
    }

    /**
     * Sets last_recording_date
     * @param int $last_recording_date
     * @return $this
     */
    public function setLastRecordingDate($last_recording_date)
    {
        $this->container['last_recording_date'] = $last_recording_date;

        return $this;
    }

    /**
     * Gets aggregated_status
     * @return string
     */
    public function getAggregatedStatus()
    {
        return $this->container['aggregated_status'];
    }

    /**
     * Sets aggregated_status
     * @param string $aggregated_status
     * @return $this
     */
    public function setAggregatedStatus($aggregated_status)
    {
        $this->container['aggregated_status'] = $aggregated_status;

        return $this;
    }

    /**
     * Gets recording_thumbnail
     * @return string
     */
    public function getRecordingThumbnail()
    {
        return $this->container['recording_thumbnail'];
    }

    /**
     * Sets recording_thumbnail
     * @param string $recording_thumbnail
     * @return $this
     */
    public function setRecordingThumbnail($recording_thumbnail)
    {
        $this->container['recording_thumbnail'] = $recording_thumbnail;

        return $this;
    }

    /**
     * Gets created
     * @return int
     */
    public function getCreated()
    {
        return $this->container['created'];
    }

    /**
     * Sets created
     * @param int $created
     * @return $this
     */
    public function setCreated($created)
    {
        $this->container['created'] = $created;

        return $this;
    }

    /**
     * Gets aggregated_view_count
     * @return int
     */
    public function getAggregatedViewCount()
    {
        return $this->container['aggregated_view_count'];
    }

    /**
     * Sets aggregated_view_count
     * @param int $aggregated_view_count
     * @return $this
     */
    public function setAggregatedViewCount($aggregated_view_count)
    {
        $this->container['aggregated_view_count'] = $aggregated_view_count;

        return $this;
    }

    /**
     * Gets is_premium_recording
     * @return bool
     */
    public function getIsPremiumRecording()
    {
        return $this->container['is_premium_recording'];
    }

    /**
     * Sets is_premium_recording
     * @param bool $is_premium_recording
     * @return $this
     */
    public function setIsPremiumRecording($is_premium_recording)
    {
        $this->container['is_premium_recording'] = $is_premium_recording;

        return $this;
    }

    /**
     * Gets show_premium_recording_tag
     * @return bool
     */
    public function getShowPremiumRecordingTag()
    {
        return $this->container['show_premium_recording_tag'];
    }

    /**
     * Sets show_premium_recording_tag
     * @param bool $show_premium_recording_tag
     * @return $this
     */
    public function setShowPremiumRecordingTag($show_premium_recording_tag)
    {
        $this->container['show_premium_recording_tag'] = $show_premium_recording_tag;

        return $this;
    }

    /**
     * Gets recording_chapters
     * @return \BlueJeansMeetingsRestApi\Model\RecordingRecordingChapters[]
     */
    public function getRecordingChapters()
    {
        return $this->container['recording_chapters'];
    }

    /**
     * Sets recording_chapters
     * @param \BlueJeansMeetingsRestApi\Model\RecordingRecordingChapters[] $recording_chapters
     * @return $this
     */
    public function setRecordingChapters($recording_chapters)
    {
        $this->container['recording_chapters'] = $recording_chapters;

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


