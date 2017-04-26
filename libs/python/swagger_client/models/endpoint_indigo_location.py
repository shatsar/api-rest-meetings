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


class EndpointIndigoLocation(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id=None, country_code=None, country_name=None, latitude=None, longitude=None):
        """
        EndpointIndigoLocation - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id': 'int',
            'country_code': 'str',
            'country_name': 'str',
            'latitude': 'float',
            'longitude': 'float'
        }

        self.attribute_map = {
            'id': 'id',
            'country_code': 'countryCode',
            'country_name': 'countryName',
            'latitude': 'latitude',
            'longitude': 'longitude'
        }

        self._id = id
        self._country_code = country_code
        self._country_name = country_name
        self._latitude = latitude
        self._longitude = longitude

    @property
    def id(self):
        """
        Gets the id of this EndpointIndigoLocation.

        :return: The id of this EndpointIndigoLocation.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this EndpointIndigoLocation.

        :param id: The id of this EndpointIndigoLocation.
        :type: int
        """

        self._id = id

    @property
    def country_code(self):
        """
        Gets the country_code of this EndpointIndigoLocation.

        :return: The country_code of this EndpointIndigoLocation.
        :rtype: str
        """
        return self._country_code

    @country_code.setter
    def country_code(self, country_code):
        """
        Sets the country_code of this EndpointIndigoLocation.

        :param country_code: The country_code of this EndpointIndigoLocation.
        :type: str
        """

        self._country_code = country_code

    @property
    def country_name(self):
        """
        Gets the country_name of this EndpointIndigoLocation.

        :return: The country_name of this EndpointIndigoLocation.
        :rtype: str
        """
        return self._country_name

    @country_name.setter
    def country_name(self, country_name):
        """
        Sets the country_name of this EndpointIndigoLocation.

        :param country_name: The country_name of this EndpointIndigoLocation.
        :type: str
        """

        self._country_name = country_name

    @property
    def latitude(self):
        """
        Gets the latitude of this EndpointIndigoLocation.

        :return: The latitude of this EndpointIndigoLocation.
        :rtype: float
        """
        return self._latitude

    @latitude.setter
    def latitude(self, latitude):
        """
        Sets the latitude of this EndpointIndigoLocation.

        :param latitude: The latitude of this EndpointIndigoLocation.
        :type: float
        """

        self._latitude = latitude

    @property
    def longitude(self):
        """
        Gets the longitude of this EndpointIndigoLocation.

        :return: The longitude of this EndpointIndigoLocation.
        :rtype: float
        """
        return self._longitude

    @longitude.setter
    def longitude(self, longitude):
        """
        Sets the longitude of this EndpointIndigoLocation.

        :param longitude: The longitude of this EndpointIndigoLocation.
        :type: float
        """

        self._longitude = longitude

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
        if not isinstance(other, EndpointIndigoLocation):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
