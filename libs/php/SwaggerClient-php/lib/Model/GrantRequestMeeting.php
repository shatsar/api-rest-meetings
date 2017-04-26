<?php
/**
 * GrantRequestMeeting
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swaagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make.
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

namespace Swagger\Client\Model;

use \ArrayAccess;

/**
 * GrantRequestMeeting Class Doc Comment
 *
 * @category    Class
 * @package     Swagger\Client
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class GrantRequestMeeting implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'GrantRequestMeeting';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'grant_type' => 'string',
        'meeting_numeric_id' => 'string',
        'meeting_passcode' => 'string'
    ];

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = [
        'grant_type' => 'grant_type',
        'meeting_numeric_id' => 'meetingNumericId',
        'meeting_passcode' => 'meetingPasscode'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'grant_type' => 'setGrantType',
        'meeting_numeric_id' => 'setMeetingNumericId',
        'meeting_passcode' => 'setMeetingPasscode'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'grant_type' => 'getGrantType',
        'meeting_numeric_id' => 'getMeetingNumericId',
        'meeting_passcode' => 'getMeetingPasscode'
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
        $this->container['grant_type'] = isset($data['grant_type']) ? $data['grant_type'] : 'meeting_passcode';
        $this->container['meeting_numeric_id'] = isset($data['meeting_numeric_id']) ? $data['meeting_numeric_id'] : null;
        $this->container['meeting_passcode'] = isset($data['meeting_passcode']) ? $data['meeting_passcode'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = [];

        if ($this->container['grant_type'] === null) {
            $invalid_properties[] = "'grant_type' can't be null";
        }
        if ($this->container['meeting_numeric_id'] === null) {
            $invalid_properties[] = "'meeting_numeric_id' can't be null";
        }
        if ($this->container['meeting_passcode'] === null) {
            $invalid_properties[] = "'meeting_passcode' can't be null";
        }
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

        if ($this->container['grant_type'] === null) {
            return false;
        }
        if ($this->container['meeting_numeric_id'] === null) {
            return false;
        }
        if ($this->container['meeting_passcode'] === null) {
            return false;
        }
        return true;
    }


    /**
     * Gets grant_type
     * @return string
     */
    public function getGrantType()
    {
        return $this->container['grant_type'];
    }

    /**
     * Sets grant_type
     * @param string $grant_type The type of access token you are requesting.
     * @return $this
     */
    public function setGrantType($grant_type)
    {
        $this->container['grant_type'] = $grant_type;

        return $this;
    }

    /**
     * Gets meeting_numeric_id
     * @return string
     */
    public function getMeetingNumericId()
    {
        return $this->container['meeting_numeric_id'];
    }

    /**
     * Sets meeting_numeric_id
     * @param string $meeting_numeric_id Meeting ID
     * @return $this
     */
    public function setMeetingNumericId($meeting_numeric_id)
    {
        $this->container['meeting_numeric_id'] = $meeting_numeric_id;

        return $this;
    }

    /**
     * Gets meeting_passcode
     * @return string
     */
    public function getMeetingPasscode()
    {
        return $this->container['meeting_passcode'];
    }

    /**
     * Sets meeting_passcode
     * @param string $meeting_passcode Pin
     * @return $this
     */
    public function setMeetingPasscode($meeting_passcode)
    {
        $this->container['meeting_passcode'] = $meeting_passcode;

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
            return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this));
    }
}


