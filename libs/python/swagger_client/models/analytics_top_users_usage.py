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


class AnalyticsTopUsersUsage(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, last_meeting_time=None, participant_minutes=None, last_name=None, user_name=None, user_id=None, first_name=None):
        """
        AnalyticsTopUsersUsage - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'last_meeting_time': 'int',
            'participant_minutes': 'float',
            'last_name': 'str',
            'user_name': 'str',
            'user_id': 'int',
            'first_name': 'str'
        }

        self.attribute_map = {
            'last_meeting_time': 'lastMeetingTime',
            'participant_minutes': 'participantMinutes',
            'last_name': 'last_name',
            'user_name': 'userName',
            'user_id': 'userId',
            'first_name': 'first_name'
        }

        self._last_meeting_time = last_meeting_time
        self._participant_minutes = participant_minutes
        self._last_name = last_name
        self._user_name = user_name
        self._user_id = user_id
        self._first_name = first_name

    @property
    def last_meeting_time(self):
        """
        Gets the last_meeting_time of this AnalyticsTopUsersUsage.

        :return: The last_meeting_time of this AnalyticsTopUsersUsage.
        :rtype: int
        """
        return self._last_meeting_time

    @last_meeting_time.setter
    def last_meeting_time(self, last_meeting_time):
        """
        Sets the last_meeting_time of this AnalyticsTopUsersUsage.

        :param last_meeting_time: The last_meeting_time of this AnalyticsTopUsersUsage.
        :type: int
        """

        self._last_meeting_time = last_meeting_time

    @property
    def participant_minutes(self):
        """
        Gets the participant_minutes of this AnalyticsTopUsersUsage.

        :return: The participant_minutes of this AnalyticsTopUsersUsage.
        :rtype: float
        """
        return self._participant_minutes

    @participant_minutes.setter
    def participant_minutes(self, participant_minutes):
        """
        Sets the participant_minutes of this AnalyticsTopUsersUsage.

        :param participant_minutes: The participant_minutes of this AnalyticsTopUsersUsage.
        :type: float
        """

        self._participant_minutes = participant_minutes

    @property
    def last_name(self):
        """
        Gets the last_name of this AnalyticsTopUsersUsage.

        :return: The last_name of this AnalyticsTopUsersUsage.
        :rtype: str
        """
        return self._last_name

    @last_name.setter
    def last_name(self, last_name):
        """
        Sets the last_name of this AnalyticsTopUsersUsage.

        :param last_name: The last_name of this AnalyticsTopUsersUsage.
        :type: str
        """

        self._last_name = last_name

    @property
    def user_name(self):
        """
        Gets the user_name of this AnalyticsTopUsersUsage.

        :return: The user_name of this AnalyticsTopUsersUsage.
        :rtype: str
        """
        return self._user_name

    @user_name.setter
    def user_name(self, user_name):
        """
        Sets the user_name of this AnalyticsTopUsersUsage.

        :param user_name: The user_name of this AnalyticsTopUsersUsage.
        :type: str
        """

        self._user_name = user_name

    @property
    def user_id(self):
        """
        Gets the user_id of this AnalyticsTopUsersUsage.

        :return: The user_id of this AnalyticsTopUsersUsage.
        :rtype: int
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """
        Sets the user_id of this AnalyticsTopUsersUsage.

        :param user_id: The user_id of this AnalyticsTopUsersUsage.
        :type: int
        """

        self._user_id = user_id

    @property
    def first_name(self):
        """
        Gets the first_name of this AnalyticsTopUsersUsage.

        :return: The first_name of this AnalyticsTopUsersUsage.
        :rtype: str
        """
        return self._first_name

    @first_name.setter
    def first_name(self, first_name):
        """
        Sets the first_name of this AnalyticsTopUsersUsage.

        :param first_name: The first_name of this AnalyticsTopUsersUsage.
        :type: str
        """

        self._first_name = first_name

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
        if not isinstance(other, AnalyticsTopUsersUsage):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
