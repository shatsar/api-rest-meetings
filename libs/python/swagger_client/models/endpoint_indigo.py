# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class EndpointIndigo(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id=None, callguid=None, name=None, endpoint=None, vendor=None, version=None, uniq_id=None, remote_address=None, leader=None, secure_call=None, nat_detected=None, proxy=None, roi_distance=None, mpls=None, video_share=None, recording=None, creation_time=None, meeting_join_time=None, meeting_leave_time=None, did_number=None, location=None, summary_stats=None, endpoint_attributes1=None, traceroute=None, mhtask_stopped=None):
        """
        EndpointIndigo - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id': 'int',
            'callguid': 'str',
            'name': 'str',
            'endpoint': 'str',
            'vendor': 'str',
            'version': 'str',
            'uniq_id': 'str',
            'remote_address': 'str',
            'leader': 'bool',
            'secure_call': 'bool',
            'nat_detected': 'bool',
            'proxy': 'bool',
            'roi_distance': 'float',
            'mpls': 'bool',
            'video_share': 'bool',
            'recording': 'bool',
            'creation_time': 'int',
            'meeting_join_time': 'int',
            'meeting_leave_time': 'int',
            'did_number': 'str',
            'location': 'EndpointIndigoLocation',
            'summary_stats': 'EndpointIndigoSummaryStats',
            'endpoint_attributes1': 'EndpointIndigoEndpointAttributes1',
            'traceroute': 'EndpointIndigoTraceroute',
            'mhtask_stopped': 'bool'
        }

        self.attribute_map = {
            'id': 'id',
            'callguid': 'callguid',
            'name': 'name',
            'endpoint': 'endpoint',
            'vendor': 'vendor',
            'version': 'version',
            'uniq_id': 'uniqId',
            'remote_address': 'remoteAddress',
            'leader': 'leader',
            'secure_call': 'secureCall',
            'nat_detected': 'natDetected',
            'proxy': 'proxy',
            'roi_distance': 'roiDistance',
            'mpls': 'mpls',
            'video_share': 'videoShare',
            'recording': 'recording',
            'creation_time': 'creationTime',
            'meeting_join_time': 'meetingJoinTime',
            'meeting_leave_time': 'meetingLeaveTime',
            'did_number': 'didNumber',
            'location': 'location',
            'summary_stats': 'summaryStats',
            'endpoint_attributes1': 'endpointAttributes1',
            'traceroute': 'traceroute',
            'mhtask_stopped': 'mhtaskStopped'
        }

        self._id = id
        self._callguid = callguid
        self._name = name
        self._endpoint = endpoint
        self._vendor = vendor
        self._version = version
        self._uniq_id = uniq_id
        self._remote_address = remote_address
        self._leader = leader
        self._secure_call = secure_call
        self._nat_detected = nat_detected
        self._proxy = proxy
        self._roi_distance = roi_distance
        self._mpls = mpls
        self._video_share = video_share
        self._recording = recording
        self._creation_time = creation_time
        self._meeting_join_time = meeting_join_time
        self._meeting_leave_time = meeting_leave_time
        self._did_number = did_number
        self._location = location
        self._summary_stats = summary_stats
        self._endpoint_attributes1 = endpoint_attributes1
        self._traceroute = traceroute
        self._mhtask_stopped = mhtask_stopped

    @property
    def id(self):
        """
        Gets the id of this EndpointIndigo.

        :return: The id of this EndpointIndigo.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this EndpointIndigo.

        :param id: The id of this EndpointIndigo.
        :type: int
        """

        self._id = id

    @property
    def callguid(self):
        """
        Gets the callguid of this EndpointIndigo.

        :return: The callguid of this EndpointIndigo.
        :rtype: str
        """
        return self._callguid

    @callguid.setter
    def callguid(self, callguid):
        """
        Sets the callguid of this EndpointIndigo.

        :param callguid: The callguid of this EndpointIndigo.
        :type: str
        """

        self._callguid = callguid

    @property
    def name(self):
        """
        Gets the name of this EndpointIndigo.

        :return: The name of this EndpointIndigo.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """
        Sets the name of this EndpointIndigo.

        :param name: The name of this EndpointIndigo.
        :type: str
        """

        self._name = name

    @property
    def endpoint(self):
        """
        Gets the endpoint of this EndpointIndigo.

        :return: The endpoint of this EndpointIndigo.
        :rtype: str
        """
        return self._endpoint

    @endpoint.setter
    def endpoint(self, endpoint):
        """
        Sets the endpoint of this EndpointIndigo.

        :param endpoint: The endpoint of this EndpointIndigo.
        :type: str
        """

        self._endpoint = endpoint

    @property
    def vendor(self):
        """
        Gets the vendor of this EndpointIndigo.

        :return: The vendor of this EndpointIndigo.
        :rtype: str
        """
        return self._vendor

    @vendor.setter
    def vendor(self, vendor):
        """
        Sets the vendor of this EndpointIndigo.

        :param vendor: The vendor of this EndpointIndigo.
        :type: str
        """

        self._vendor = vendor

    @property
    def version(self):
        """
        Gets the version of this EndpointIndigo.

        :return: The version of this EndpointIndigo.
        :rtype: str
        """
        return self._version

    @version.setter
    def version(self, version):
        """
        Sets the version of this EndpointIndigo.

        :param version: The version of this EndpointIndigo.
        :type: str
        """

        self._version = version

    @property
    def uniq_id(self):
        """
        Gets the uniq_id of this EndpointIndigo.

        :return: The uniq_id of this EndpointIndigo.
        :rtype: str
        """
        return self._uniq_id

    @uniq_id.setter
    def uniq_id(self, uniq_id):
        """
        Sets the uniq_id of this EndpointIndigo.

        :param uniq_id: The uniq_id of this EndpointIndigo.
        :type: str
        """

        self._uniq_id = uniq_id

    @property
    def remote_address(self):
        """
        Gets the remote_address of this EndpointIndigo.

        :return: The remote_address of this EndpointIndigo.
        :rtype: str
        """
        return self._remote_address

    @remote_address.setter
    def remote_address(self, remote_address):
        """
        Sets the remote_address of this EndpointIndigo.

        :param remote_address: The remote_address of this EndpointIndigo.
        :type: str
        """

        self._remote_address = remote_address

    @property
    def leader(self):
        """
        Gets the leader of this EndpointIndigo.

        :return: The leader of this EndpointIndigo.
        :rtype: bool
        """
        return self._leader

    @leader.setter
    def leader(self, leader):
        """
        Sets the leader of this EndpointIndigo.

        :param leader: The leader of this EndpointIndigo.
        :type: bool
        """

        self._leader = leader

    @property
    def secure_call(self):
        """
        Gets the secure_call of this EndpointIndigo.

        :return: The secure_call of this EndpointIndigo.
        :rtype: bool
        """
        return self._secure_call

    @secure_call.setter
    def secure_call(self, secure_call):
        """
        Sets the secure_call of this EndpointIndigo.

        :param secure_call: The secure_call of this EndpointIndigo.
        :type: bool
        """

        self._secure_call = secure_call

    @property
    def nat_detected(self):
        """
        Gets the nat_detected of this EndpointIndigo.

        :return: The nat_detected of this EndpointIndigo.
        :rtype: bool
        """
        return self._nat_detected

    @nat_detected.setter
    def nat_detected(self, nat_detected):
        """
        Sets the nat_detected of this EndpointIndigo.

        :param nat_detected: The nat_detected of this EndpointIndigo.
        :type: bool
        """

        self._nat_detected = nat_detected

    @property
    def proxy(self):
        """
        Gets the proxy of this EndpointIndigo.

        :return: The proxy of this EndpointIndigo.
        :rtype: bool
        """
        return self._proxy

    @proxy.setter
    def proxy(self, proxy):
        """
        Sets the proxy of this EndpointIndigo.

        :param proxy: The proxy of this EndpointIndigo.
        :type: bool
        """

        self._proxy = proxy

    @property
    def roi_distance(self):
        """
        Gets the roi_distance of this EndpointIndigo.

        :return: The roi_distance of this EndpointIndigo.
        :rtype: float
        """
        return self._roi_distance

    @roi_distance.setter
    def roi_distance(self, roi_distance):
        """
        Sets the roi_distance of this EndpointIndigo.

        :param roi_distance: The roi_distance of this EndpointIndigo.
        :type: float
        """

        self._roi_distance = roi_distance

    @property
    def mpls(self):
        """
        Gets the mpls of this EndpointIndigo.

        :return: The mpls of this EndpointIndigo.
        :rtype: bool
        """
        return self._mpls

    @mpls.setter
    def mpls(self, mpls):
        """
        Sets the mpls of this EndpointIndigo.

        :param mpls: The mpls of this EndpointIndigo.
        :type: bool
        """

        self._mpls = mpls

    @property
    def video_share(self):
        """
        Gets the video_share of this EndpointIndigo.

        :return: The video_share of this EndpointIndigo.
        :rtype: bool
        """
        return self._video_share

    @video_share.setter
    def video_share(self, video_share):
        """
        Sets the video_share of this EndpointIndigo.

        :param video_share: The video_share of this EndpointIndigo.
        :type: bool
        """

        self._video_share = video_share

    @property
    def recording(self):
        """
        Gets the recording of this EndpointIndigo.

        :return: The recording of this EndpointIndigo.
        :rtype: bool
        """
        return self._recording

    @recording.setter
    def recording(self, recording):
        """
        Sets the recording of this EndpointIndigo.

        :param recording: The recording of this EndpointIndigo.
        :type: bool
        """

        self._recording = recording

    @property
    def creation_time(self):
        """
        Gets the creation_time of this EndpointIndigo.

        :return: The creation_time of this EndpointIndigo.
        :rtype: int
        """
        return self._creation_time

    @creation_time.setter
    def creation_time(self, creation_time):
        """
        Sets the creation_time of this EndpointIndigo.

        :param creation_time: The creation_time of this EndpointIndigo.
        :type: int
        """

        self._creation_time = creation_time

    @property
    def meeting_join_time(self):
        """
        Gets the meeting_join_time of this EndpointIndigo.

        :return: The meeting_join_time of this EndpointIndigo.
        :rtype: int
        """
        return self._meeting_join_time

    @meeting_join_time.setter
    def meeting_join_time(self, meeting_join_time):
        """
        Sets the meeting_join_time of this EndpointIndigo.

        :param meeting_join_time: The meeting_join_time of this EndpointIndigo.
        :type: int
        """

        self._meeting_join_time = meeting_join_time

    @property
    def meeting_leave_time(self):
        """
        Gets the meeting_leave_time of this EndpointIndigo.

        :return: The meeting_leave_time of this EndpointIndigo.
        :rtype: int
        """
        return self._meeting_leave_time

    @meeting_leave_time.setter
    def meeting_leave_time(self, meeting_leave_time):
        """
        Sets the meeting_leave_time of this EndpointIndigo.

        :param meeting_leave_time: The meeting_leave_time of this EndpointIndigo.
        :type: int
        """

        self._meeting_leave_time = meeting_leave_time

    @property
    def did_number(self):
        """
        Gets the did_number of this EndpointIndigo.

        :return: The did_number of this EndpointIndigo.
        :rtype: str
        """
        return self._did_number

    @did_number.setter
    def did_number(self, did_number):
        """
        Sets the did_number of this EndpointIndigo.

        :param did_number: The did_number of this EndpointIndigo.
        :type: str
        """

        self._did_number = did_number

    @property
    def location(self):
        """
        Gets the location of this EndpointIndigo.

        :return: The location of this EndpointIndigo.
        :rtype: EndpointIndigoLocation
        """
        return self._location

    @location.setter
    def location(self, location):
        """
        Sets the location of this EndpointIndigo.

        :param location: The location of this EndpointIndigo.
        :type: EndpointIndigoLocation
        """

        self._location = location

    @property
    def summary_stats(self):
        """
        Gets the summary_stats of this EndpointIndigo.

        :return: The summary_stats of this EndpointIndigo.
        :rtype: EndpointIndigoSummaryStats
        """
        return self._summary_stats

    @summary_stats.setter
    def summary_stats(self, summary_stats):
        """
        Sets the summary_stats of this EndpointIndigo.

        :param summary_stats: The summary_stats of this EndpointIndigo.
        :type: EndpointIndigoSummaryStats
        """

        self._summary_stats = summary_stats

    @property
    def endpoint_attributes1(self):
        """
        Gets the endpoint_attributes1 of this EndpointIndigo.

        :return: The endpoint_attributes1 of this EndpointIndigo.
        :rtype: EndpointIndigoEndpointAttributes1
        """
        return self._endpoint_attributes1

    @endpoint_attributes1.setter
    def endpoint_attributes1(self, endpoint_attributes1):
        """
        Sets the endpoint_attributes1 of this EndpointIndigo.

        :param endpoint_attributes1: The endpoint_attributes1 of this EndpointIndigo.
        :type: EndpointIndigoEndpointAttributes1
        """

        self._endpoint_attributes1 = endpoint_attributes1

    @property
    def traceroute(self):
        """
        Gets the traceroute of this EndpointIndigo.

        :return: The traceroute of this EndpointIndigo.
        :rtype: EndpointIndigoTraceroute
        """
        return self._traceroute

    @traceroute.setter
    def traceroute(self, traceroute):
        """
        Sets the traceroute of this EndpointIndigo.

        :param traceroute: The traceroute of this EndpointIndigo.
        :type: EndpointIndigoTraceroute
        """

        self._traceroute = traceroute

    @property
    def mhtask_stopped(self):
        """
        Gets the mhtask_stopped of this EndpointIndigo.

        :return: The mhtask_stopped of this EndpointIndigo.
        :rtype: bool
        """
        return self._mhtask_stopped

    @mhtask_stopped.setter
    def mhtask_stopped(self, mhtask_stopped):
        """
        Sets the mhtask_stopped of this EndpointIndigo.

        :param mhtask_stopped: The mhtask_stopped of this EndpointIndigo.
        :type: bool
        """

        self._mhtask_stopped = mhtask_stopped

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        if not isinstance(other, EndpointIndigo):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
