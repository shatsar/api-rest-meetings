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


class PayloadPairingCodeWebRTC(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, endpoint_type=None, user_id=None, language_code=None, capabilities=None):
        """
        PayloadPairingCodeWebRTC - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'endpoint_type': 'int',
            'user_id': 'int',
            'language_code': 'str',
            'capabilities': 'list[str]'
        }

        self.attribute_map = {
            'endpoint_type': 'endpointType',
            'user_id': 'userId',
            'language_code': 'languageCode',
            'capabilities': 'capabilities'
        }

        self._endpoint_type = endpoint_type
        self._user_id = user_id
        self._language_code = language_code
        self._capabilities = capabilities

    @property
    def endpoint_type(self):
        """
        Gets the endpoint_type of this PayloadPairingCodeWebRTC.

        :return: The endpoint_type of this PayloadPairingCodeWebRTC.
        :rtype: int
        """
        return self._endpoint_type

    @endpoint_type.setter
    def endpoint_type(self, endpoint_type):
        """
        Sets the endpoint_type of this PayloadPairingCodeWebRTC.

        :param endpoint_type: The endpoint_type of this PayloadPairingCodeWebRTC.
        :type: int
        """

        self._endpoint_type = endpoint_type

    @property
    def user_id(self):
        """
        Gets the user_id of this PayloadPairingCodeWebRTC.

        :return: The user_id of this PayloadPairingCodeWebRTC.
        :rtype: int
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """
        Sets the user_id of this PayloadPairingCodeWebRTC.

        :param user_id: The user_id of this PayloadPairingCodeWebRTC.
        :type: int
        """

        self._user_id = user_id

    @property
    def language_code(self):
        """
        Gets the language_code of this PayloadPairingCodeWebRTC.

        :return: The language_code of this PayloadPairingCodeWebRTC.
        :rtype: str
        """
        return self._language_code

    @language_code.setter
    def language_code(self, language_code):
        """
        Sets the language_code of this PayloadPairingCodeWebRTC.

        :param language_code: The language_code of this PayloadPairingCodeWebRTC.
        :type: str
        """
        allowed_values = ["en"]
        if language_code not in allowed_values:
            raise ValueError(
                "Invalid value for `language_code` ({0}), must be one of {1}"
                .format(language_code, allowed_values)
            )

        self._language_code = language_code

    @property
    def capabilities(self):
        """
        Gets the capabilities of this PayloadPairingCodeWebRTC.

        :return: The capabilities of this PayloadPairingCodeWebRTC.
        :rtype: list[str]
        """
        return self._capabilities

    @capabilities.setter
    def capabilities(self, capabilities):
        """
        Sets the capabilities of this PayloadPairingCodeWebRTC.

        :param capabilities: The capabilities of this PayloadPairingCodeWebRTC.
        :type: list[str]
        """

        self._capabilities = capabilities

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
        if not isinstance(other, PayloadPairingCodeWebRTC):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
