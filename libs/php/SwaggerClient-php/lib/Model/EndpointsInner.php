<?php
/**
 * EndpointsInner
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do, from the world's leader in cloud video communication._ # Authentication Each API request that is sent to BlueJeans requires an access token, which is obtained through the BlueJeans Authentication API. There are several methods (grant types) for obtaining an access token, which follow the OAuth2.0 specification. ## Grant Types * Authorization Code Grant – This grant type is used in an authentication flow commonly referred to as \"three-legged OAuth\". The user authenticates via a BlueJeans page, which provides an authorization code. This code, along with a few other elements, can be used to obtain an access code. * Password Credentials Grant – This grant type is used in a two-legged OAuth flow. Username and password are sent to retrieve an access code. * Client Credentials Grant – This grant type is used in a two-legged OAuth flow.  ## Access & Permissions The access level that is associated with each access token is referred to as the scope. There are three basic levels of access that BlueJeans allows, which affect the level of scope.  Three access levels exist within the Blue Jeans service today. * Meeting-level – Authentication takes place using a meeting ID and passcode, and the scope is limited to APIs that relate to the individual meeting. * User-level – Authentication either takes place via three-legged OAuth, or else a direct authorization token request containing a username or password. Access level depends on the requested scope permissions. * App-level – An application is provisioned either by BlueJeans personnel, or within the BlueJeans Enterprise Admin interface. When provisioning an app, a client key and secret are provided, which is then used to obtain an access token, via the BlueJeans Authentication API. The scope that is associated with the token will provide access to an entire enterprise and all of its users.  All endpoints in this document that require Enterprise Admin access will be marked as such. ## Testing In order to make effective use of this page, you will first use one of the authentication methods to obtain an access token. Once the token is given, use the Authenticate button up in the header to store the token. Each BlueJeans API called after that will use the access token provided.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;

/**
 * EndpointsInner Class Doc Comment
 *
 * @category    Class */
/** 
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EndpointsInner implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'Endpoints_inner';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'meetingid' => 'string',
        'name' => 'string',
        'call_quality' => 'string',
        'leader' => 'string',
        'callguid' => 'string',
        'endpoint' => 'string',
        'talk_detected' => 'string',
        'secure_call' => 'string',
        'layout' => 'string',
        'sub_layout' => 'string',
        'video_recv' => 'string',
        'video_recv_local_mute' => 'string',
        'video_recv_remote_mute' => 'string',
        'audio_recv' => 'string',
        'audio_recv_local_mute' => 'string',
        'audio_recv_remote_mute' => 'string',
        'audio_recv_codec' => 'string',
        'audio_send_codec' => 'string',
        'video_recv_codec' => 'string',
        'video_recv_height' => 'string',
        'video_recv_width' => 'string',
        'video_send_codec' => 'string',
        'video_send_height' => 'string',
        'video_send_width' => 'string',
        'visibility' => 'string',
        'chat_endpoint_guid' => 'string',
        'endpoint_guid' => 'string',
        'rdc_version' => 'string',
        'rdc_controller_capable' => 'string',
        'rdc_controllee_capable' => 'string',
        'connections' => '\Swagger\Client\Model\EndpointsInnerConnections[]'
    );

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = array(
        'meetingid' => 'meetingid',
        'name' => 'name',
        'call_quality' => 'CallQuality',
        'leader' => 'Leader',
        'callguid' => 'callguid',
        'endpoint' => 'endpoint',
        'talk_detected' => 'TalkDetected',
        'secure_call' => 'SecureCall',
        'layout' => 'Layout',
        'sub_layout' => 'SubLayout',
        'video_recv' => 'VideoRecv',
        'video_recv_local_mute' => 'VideoRecvLocalMute',
        'video_recv_remote_mute' => 'VideoRecvRemoteMute',
        'audio_recv' => 'AudioRecv',
        'audio_recv_local_mute' => 'AudioRecvLocalMute',
        'audio_recv_remote_mute' => 'AudioRecvRemoteMute',
        'audio_recv_codec' => 'AudioRecvCodec',
        'audio_send_codec' => 'AudioSendCodec',
        'video_recv_codec' => 'VideoRecvCodec',
        'video_recv_height' => 'VideoRecvHeight',
        'video_recv_width' => 'VideoRecvWidth',
        'video_send_codec' => 'VideoSendCodec',
        'video_send_height' => 'VideoSendHeight',
        'video_send_width' => 'VideoSendWidth',
        'visibility' => 'visibility',
        'chat_endpoint_guid' => 'chatEndpointGuid',
        'endpoint_guid' => 'endpointGuid',
        'rdc_version' => 'RDCVersion',
        'rdc_controller_capable' => 'RDCControllerCapable',
        'rdc_controllee_capable' => 'RDCControlleeCapable',
        'connections' => 'connections'
    );

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = array(
        'meetingid' => 'setMeetingid',
        'name' => 'setName',
        'call_quality' => 'setCallQuality',
        'leader' => 'setLeader',
        'callguid' => 'setCallguid',
        'endpoint' => 'setEndpoint',
        'talk_detected' => 'setTalkDetected',
        'secure_call' => 'setSecureCall',
        'layout' => 'setLayout',
        'sub_layout' => 'setSubLayout',
        'video_recv' => 'setVideoRecv',
        'video_recv_local_mute' => 'setVideoRecvLocalMute',
        'video_recv_remote_mute' => 'setVideoRecvRemoteMute',
        'audio_recv' => 'setAudioRecv',
        'audio_recv_local_mute' => 'setAudioRecvLocalMute',
        'audio_recv_remote_mute' => 'setAudioRecvRemoteMute',
        'audio_recv_codec' => 'setAudioRecvCodec',
        'audio_send_codec' => 'setAudioSendCodec',
        'video_recv_codec' => 'setVideoRecvCodec',
        'video_recv_height' => 'setVideoRecvHeight',
        'video_recv_width' => 'setVideoRecvWidth',
        'video_send_codec' => 'setVideoSendCodec',
        'video_send_height' => 'setVideoSendHeight',
        'video_send_width' => 'setVideoSendWidth',
        'visibility' => 'setVisibility',
        'chat_endpoint_guid' => 'setChatEndpointGuid',
        'endpoint_guid' => 'setEndpointGuid',
        'rdc_version' => 'setRdcVersion',
        'rdc_controller_capable' => 'setRdcControllerCapable',
        'rdc_controllee_capable' => 'setRdcControlleeCapable',
        'connections' => 'setConnections'
    );

    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = array(
        'meetingid' => 'getMeetingid',
        'name' => 'getName',
        'call_quality' => 'getCallQuality',
        'leader' => 'getLeader',
        'callguid' => 'getCallguid',
        'endpoint' => 'getEndpoint',
        'talk_detected' => 'getTalkDetected',
        'secure_call' => 'getSecureCall',
        'layout' => 'getLayout',
        'sub_layout' => 'getSubLayout',
        'video_recv' => 'getVideoRecv',
        'video_recv_local_mute' => 'getVideoRecvLocalMute',
        'video_recv_remote_mute' => 'getVideoRecvRemoteMute',
        'audio_recv' => 'getAudioRecv',
        'audio_recv_local_mute' => 'getAudioRecvLocalMute',
        'audio_recv_remote_mute' => 'getAudioRecvRemoteMute',
        'audio_recv_codec' => 'getAudioRecvCodec',
        'audio_send_codec' => 'getAudioSendCodec',
        'video_recv_codec' => 'getVideoRecvCodec',
        'video_recv_height' => 'getVideoRecvHeight',
        'video_recv_width' => 'getVideoRecvWidth',
        'video_send_codec' => 'getVideoSendCodec',
        'video_send_height' => 'getVideoSendHeight',
        'video_send_width' => 'getVideoSendWidth',
        'visibility' => 'getVisibility',
        'chat_endpoint_guid' => 'getChatEndpointGuid',
        'endpoint_guid' => 'getEndpointGuid',
        'rdc_version' => 'getRdcVersion',
        'rdc_controller_capable' => 'getRdcControllerCapable',
        'rdc_controllee_capable' => 'getRdcControlleeCapable',
        'connections' => 'getConnections'
    );

    public static function getters()
    {
        return self::$getters;
    }

    

    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = array();

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['meetingid'] = isset($data['meetingid']) ? $data['meetingid'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['call_quality'] = isset($data['call_quality']) ? $data['call_quality'] : null;
        $this->container['leader'] = isset($data['leader']) ? $data['leader'] : null;
        $this->container['callguid'] = isset($data['callguid']) ? $data['callguid'] : null;
        $this->container['endpoint'] = isset($data['endpoint']) ? $data['endpoint'] : null;
        $this->container['talk_detected'] = isset($data['talk_detected']) ? $data['talk_detected'] : null;
        $this->container['secure_call'] = isset($data['secure_call']) ? $data['secure_call'] : null;
        $this->container['layout'] = isset($data['layout']) ? $data['layout'] : null;
        $this->container['sub_layout'] = isset($data['sub_layout']) ? $data['sub_layout'] : null;
        $this->container['video_recv'] = isset($data['video_recv']) ? $data['video_recv'] : null;
        $this->container['video_recv_local_mute'] = isset($data['video_recv_local_mute']) ? $data['video_recv_local_mute'] : null;
        $this->container['video_recv_remote_mute'] = isset($data['video_recv_remote_mute']) ? $data['video_recv_remote_mute'] : null;
        $this->container['audio_recv'] = isset($data['audio_recv']) ? $data['audio_recv'] : null;
        $this->container['audio_recv_local_mute'] = isset($data['audio_recv_local_mute']) ? $data['audio_recv_local_mute'] : null;
        $this->container['audio_recv_remote_mute'] = isset($data['audio_recv_remote_mute']) ? $data['audio_recv_remote_mute'] : null;
        $this->container['audio_recv_codec'] = isset($data['audio_recv_codec']) ? $data['audio_recv_codec'] : null;
        $this->container['audio_send_codec'] = isset($data['audio_send_codec']) ? $data['audio_send_codec'] : null;
        $this->container['video_recv_codec'] = isset($data['video_recv_codec']) ? $data['video_recv_codec'] : null;
        $this->container['video_recv_height'] = isset($data['video_recv_height']) ? $data['video_recv_height'] : null;
        $this->container['video_recv_width'] = isset($data['video_recv_width']) ? $data['video_recv_width'] : null;
        $this->container['video_send_codec'] = isset($data['video_send_codec']) ? $data['video_send_codec'] : null;
        $this->container['video_send_height'] = isset($data['video_send_height']) ? $data['video_send_height'] : null;
        $this->container['video_send_width'] = isset($data['video_send_width']) ? $data['video_send_width'] : null;
        $this->container['visibility'] = isset($data['visibility']) ? $data['visibility'] : null;
        $this->container['chat_endpoint_guid'] = isset($data['chat_endpoint_guid']) ? $data['chat_endpoint_guid'] : null;
        $this->container['endpoint_guid'] = isset($data['endpoint_guid']) ? $data['endpoint_guid'] : null;
        $this->container['rdc_version'] = isset($data['rdc_version']) ? $data['rdc_version'] : null;
        $this->container['rdc_controller_capable'] = isset($data['rdc_controller_capable']) ? $data['rdc_controller_capable'] : null;
        $this->container['rdc_controllee_capable'] = isset($data['rdc_controllee_capable']) ? $data['rdc_controllee_capable'] : null;
        $this->container['connections'] = isset($data['connections']) ? $data['connections'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = array();
        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properteis are valid
     */
    public function valid()
    {
        return true;
    }


    /**
     * Gets meetingid
     * @return string
     */
    public function getMeetingid()
    {
        return $this->container['meetingid'];
    }

    /**
     * Sets meetingid
     * @param string $meetingid
     * @return $this
     */
    public function setMeetingid($meetingid)
    {
        $this->container['meetingid'] = $meetingid;

        return $this;
    }

    /**
     * Gets name
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     * @param string $name
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets call_quality
     * @return string
     */
    public function getCallQuality()
    {
        return $this->container['call_quality'];
    }

    /**
     * Sets call_quality
     * @param string $call_quality
     * @return $this
     */
    public function setCallQuality($call_quality)
    {
        $this->container['call_quality'] = $call_quality;

        return $this;
    }

    /**
     * Gets leader
     * @return string
     */
    public function getLeader()
    {
        return $this->container['leader'];
    }

    /**
     * Sets leader
     * @param string $leader
     * @return $this
     */
    public function setLeader($leader)
    {
        $this->container['leader'] = $leader;

        return $this;
    }

    /**
     * Gets callguid
     * @return string
     */
    public function getCallguid()
    {
        return $this->container['callguid'];
    }

    /**
     * Sets callguid
     * @param string $callguid
     * @return $this
     */
    public function setCallguid($callguid)
    {
        $this->container['callguid'] = $callguid;

        return $this;
    }

    /**
     * Gets endpoint
     * @return string
     */
    public function getEndpoint()
    {
        return $this->container['endpoint'];
    }

    /**
     * Sets endpoint
     * @param string $endpoint
     * @return $this
     */
    public function setEndpoint($endpoint)
    {
        $this->container['endpoint'] = $endpoint;

        return $this;
    }

    /**
     * Gets talk_detected
     * @return string
     */
    public function getTalkDetected()
    {
        return $this->container['talk_detected'];
    }

    /**
     * Sets talk_detected
     * @param string $talk_detected
     * @return $this
     */
    public function setTalkDetected($talk_detected)
    {
        $this->container['talk_detected'] = $talk_detected;

        return $this;
    }

    /**
     * Gets secure_call
     * @return string
     */
    public function getSecureCall()
    {
        return $this->container['secure_call'];
    }

    /**
     * Sets secure_call
     * @param string $secure_call
     * @return $this
     */
    public function setSecureCall($secure_call)
    {
        $this->container['secure_call'] = $secure_call;

        return $this;
    }

    /**
     * Gets layout
     * @return string
     */
    public function getLayout()
    {
        return $this->container['layout'];
    }

    /**
     * Sets layout
     * @param string $layout
     * @return $this
     */
    public function setLayout($layout)
    {
        $this->container['layout'] = $layout;

        return $this;
    }

    /**
     * Gets sub_layout
     * @return string
     */
    public function getSubLayout()
    {
        return $this->container['sub_layout'];
    }

    /**
     * Sets sub_layout
     * @param string $sub_layout
     * @return $this
     */
    public function setSubLayout($sub_layout)
    {
        $this->container['sub_layout'] = $sub_layout;

        return $this;
    }

    /**
     * Gets video_recv
     * @return string
     */
    public function getVideoRecv()
    {
        return $this->container['video_recv'];
    }

    /**
     * Sets video_recv
     * @param string $video_recv
     * @return $this
     */
    public function setVideoRecv($video_recv)
    {
        $this->container['video_recv'] = $video_recv;

        return $this;
    }

    /**
     * Gets video_recv_local_mute
     * @return string
     */
    public function getVideoRecvLocalMute()
    {
        return $this->container['video_recv_local_mute'];
    }

    /**
     * Sets video_recv_local_mute
     * @param string $video_recv_local_mute
     * @return $this
     */
    public function setVideoRecvLocalMute($video_recv_local_mute)
    {
        $this->container['video_recv_local_mute'] = $video_recv_local_mute;

        return $this;
    }

    /**
     * Gets video_recv_remote_mute
     * @return string
     */
    public function getVideoRecvRemoteMute()
    {
        return $this->container['video_recv_remote_mute'];
    }

    /**
     * Sets video_recv_remote_mute
     * @param string $video_recv_remote_mute
     * @return $this
     */
    public function setVideoRecvRemoteMute($video_recv_remote_mute)
    {
        $this->container['video_recv_remote_mute'] = $video_recv_remote_mute;

        return $this;
    }

    /**
     * Gets audio_recv
     * @return string
     */
    public function getAudioRecv()
    {
        return $this->container['audio_recv'];
    }

    /**
     * Sets audio_recv
     * @param string $audio_recv
     * @return $this
     */
    public function setAudioRecv($audio_recv)
    {
        $this->container['audio_recv'] = $audio_recv;

        return $this;
    }

    /**
     * Gets audio_recv_local_mute
     * @return string
     */
    public function getAudioRecvLocalMute()
    {
        return $this->container['audio_recv_local_mute'];
    }

    /**
     * Sets audio_recv_local_mute
     * @param string $audio_recv_local_mute
     * @return $this
     */
    public function setAudioRecvLocalMute($audio_recv_local_mute)
    {
        $this->container['audio_recv_local_mute'] = $audio_recv_local_mute;

        return $this;
    }

    /**
     * Gets audio_recv_remote_mute
     * @return string
     */
    public function getAudioRecvRemoteMute()
    {
        return $this->container['audio_recv_remote_mute'];
    }

    /**
     * Sets audio_recv_remote_mute
     * @param string $audio_recv_remote_mute
     * @return $this
     */
    public function setAudioRecvRemoteMute($audio_recv_remote_mute)
    {
        $this->container['audio_recv_remote_mute'] = $audio_recv_remote_mute;

        return $this;
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
     * Gets video_recv_codec
     * @return string
     */
    public function getVideoRecvCodec()
    {
        return $this->container['video_recv_codec'];
    }

    /**
     * Sets video_recv_codec
     * @param string $video_recv_codec
     * @return $this
     */
    public function setVideoRecvCodec($video_recv_codec)
    {
        $this->container['video_recv_codec'] = $video_recv_codec;

        return $this;
    }

    /**
     * Gets video_recv_height
     * @return string
     */
    public function getVideoRecvHeight()
    {
        return $this->container['video_recv_height'];
    }

    /**
     * Sets video_recv_height
     * @param string $video_recv_height
     * @return $this
     */
    public function setVideoRecvHeight($video_recv_height)
    {
        $this->container['video_recv_height'] = $video_recv_height;

        return $this;
    }

    /**
     * Gets video_recv_width
     * @return string
     */
    public function getVideoRecvWidth()
    {
        return $this->container['video_recv_width'];
    }

    /**
     * Sets video_recv_width
     * @param string $video_recv_width
     * @return $this
     */
    public function setVideoRecvWidth($video_recv_width)
    {
        $this->container['video_recv_width'] = $video_recv_width;

        return $this;
    }

    /**
     * Gets video_send_codec
     * @return string
     */
    public function getVideoSendCodec()
    {
        return $this->container['video_send_codec'];
    }

    /**
     * Sets video_send_codec
     * @param string $video_send_codec
     * @return $this
     */
    public function setVideoSendCodec($video_send_codec)
    {
        $this->container['video_send_codec'] = $video_send_codec;

        return $this;
    }

    /**
     * Gets video_send_height
     * @return string
     */
    public function getVideoSendHeight()
    {
        return $this->container['video_send_height'];
    }

    /**
     * Sets video_send_height
     * @param string $video_send_height
     * @return $this
     */
    public function setVideoSendHeight($video_send_height)
    {
        $this->container['video_send_height'] = $video_send_height;

        return $this;
    }

    /**
     * Gets video_send_width
     * @return string
     */
    public function getVideoSendWidth()
    {
        return $this->container['video_send_width'];
    }

    /**
     * Sets video_send_width
     * @param string $video_send_width
     * @return $this
     */
    public function setVideoSendWidth($video_send_width)
    {
        $this->container['video_send_width'] = $video_send_width;

        return $this;
    }

    /**
     * Gets visibility
     * @return string
     */
    public function getVisibility()
    {
        return $this->container['visibility'];
    }

    /**
     * Sets visibility
     * @param string $visibility
     * @return $this
     */
    public function setVisibility($visibility)
    {
        $this->container['visibility'] = $visibility;

        return $this;
    }

    /**
     * Gets chat_endpoint_guid
     * @return string
     */
    public function getChatEndpointGuid()
    {
        return $this->container['chat_endpoint_guid'];
    }

    /**
     * Sets chat_endpoint_guid
     * @param string $chat_endpoint_guid
     * @return $this
     */
    public function setChatEndpointGuid($chat_endpoint_guid)
    {
        $this->container['chat_endpoint_guid'] = $chat_endpoint_guid;

        return $this;
    }

    /**
     * Gets endpoint_guid
     * @return string
     */
    public function getEndpointGuid()
    {
        return $this->container['endpoint_guid'];
    }

    /**
     * Sets endpoint_guid
     * @param string $endpoint_guid
     * @return $this
     */
    public function setEndpointGuid($endpoint_guid)
    {
        $this->container['endpoint_guid'] = $endpoint_guid;

        return $this;
    }

    /**
     * Gets rdc_version
     * @return string
     */
    public function getRdcVersion()
    {
        return $this->container['rdc_version'];
    }

    /**
     * Sets rdc_version
     * @param string $rdc_version
     * @return $this
     */
    public function setRdcVersion($rdc_version)
    {
        $this->container['rdc_version'] = $rdc_version;

        return $this;
    }

    /**
     * Gets rdc_controller_capable
     * @return string
     */
    public function getRdcControllerCapable()
    {
        return $this->container['rdc_controller_capable'];
    }

    /**
     * Sets rdc_controller_capable
     * @param string $rdc_controller_capable
     * @return $this
     */
    public function setRdcControllerCapable($rdc_controller_capable)
    {
        $this->container['rdc_controller_capable'] = $rdc_controller_capable;

        return $this;
    }

    /**
     * Gets rdc_controllee_capable
     * @return string
     */
    public function getRdcControlleeCapable()
    {
        return $this->container['rdc_controllee_capable'];
    }

    /**
     * Sets rdc_controllee_capable
     * @param string $rdc_controllee_capable
     * @return $this
     */
    public function setRdcControlleeCapable($rdc_controllee_capable)
    {
        $this->container['rdc_controllee_capable'] = $rdc_controllee_capable;

        return $this;
    }

    /**
     * Gets connections
     * @return \Swagger\Client\Model\EndpointsInnerConnections[]
     */
    public function getConnections()
    {
        return $this->container['connections'];
    }

    /**
     * Sets connections
     * @param \Swagger\Client\Model\EndpointsInnerConnections[] $connections
     * @return $this
     */
    public function setConnections($connections)
    {
        $this->container['connections'] = $connections;

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

