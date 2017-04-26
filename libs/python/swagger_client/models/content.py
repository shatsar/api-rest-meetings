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


class Content(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id=None, content_type=None, content_description=None, content_url=None, user_id=None, content_location=None, created=None, modified=None, content_status=None, content_name=None, content_category=None, content_size=None, content_duration=None, content_properties=None):
        """
        Content - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id': 'int',
            'content_type': 'str',
            'content_description': 'str',
            'content_url': 'str',
            'user_id': 'int',
            'content_location': 'str',
            'created': 'int',
            'modified': 'int',
            'content_status': 'str',
            'content_name': 'str',
            'content_category': 'str',
            'content_size': 'int',
            'content_duration': 'int',
            'content_properties': 'ContentContentProperties'
        }

        self.attribute_map = {
            'id': 'id',
            'content_type': 'contentType',
            'content_description': 'contentDescription',
            'content_url': 'contentUrl',
            'user_id': 'userId',
            'content_location': 'contentLocation',
            'created': 'created',
            'modified': 'modified',
            'content_status': 'contentStatus',
            'content_name': 'contentName',
            'content_category': 'contentCategory',
            'content_size': 'contentSize',
            'content_duration': 'contentDuration',
            'content_properties': 'contentProperties'
        }

        self._id = id
        self._content_type = content_type
        self._content_description = content_description
        self._content_url = content_url
        self._user_id = user_id
        self._content_location = content_location
        self._created = created
        self._modified = modified
        self._content_status = content_status
        self._content_name = content_name
        self._content_category = content_category
        self._content_size = content_size
        self._content_duration = content_duration
        self._content_properties = content_properties

    @property
    def id(self):
        """
        Gets the id of this Content.

        :return: The id of this Content.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this Content.

        :param id: The id of this Content.
        :type: int
        """

        self._id = id

    @property
    def content_type(self):
        """
        Gets the content_type of this Content.

        :return: The content_type of this Content.
        :rtype: str
        """
        return self._content_type

    @content_type.setter
    def content_type(self, content_type):
        """
        Sets the content_type of this Content.

        :param content_type: The content_type of this Content.
        :type: str
        """

        self._content_type = content_type

    @property
    def content_description(self):
        """
        Gets the content_description of this Content.

        :return: The content_description of this Content.
        :rtype: str
        """
        return self._content_description

    @content_description.setter
    def content_description(self, content_description):
        """
        Sets the content_description of this Content.

        :param content_description: The content_description of this Content.
        :type: str
        """

        self._content_description = content_description

    @property
    def content_url(self):
        """
        Gets the content_url of this Content.

        :return: The content_url of this Content.
        :rtype: str
        """
        return self._content_url

    @content_url.setter
    def content_url(self, content_url):
        """
        Sets the content_url of this Content.

        :param content_url: The content_url of this Content.
        :type: str
        """

        self._content_url = content_url

    @property
    def user_id(self):
        """
        Gets the user_id of this Content.

        :return: The user_id of this Content.
        :rtype: int
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """
        Sets the user_id of this Content.

        :param user_id: The user_id of this Content.
        :type: int
        """

        self._user_id = user_id

    @property
    def content_location(self):
        """
        Gets the content_location of this Content.

        :return: The content_location of this Content.
        :rtype: str
        """
        return self._content_location

    @content_location.setter
    def content_location(self, content_location):
        """
        Sets the content_location of this Content.

        :param content_location: The content_location of this Content.
        :type: str
        """

        self._content_location = content_location

    @property
    def created(self):
        """
        Gets the created of this Content.

        :return: The created of this Content.
        :rtype: int
        """
        return self._created

    @created.setter
    def created(self, created):
        """
        Sets the created of this Content.

        :param created: The created of this Content.
        :type: int
        """

        self._created = created

    @property
    def modified(self):
        """
        Gets the modified of this Content.

        :return: The modified of this Content.
        :rtype: int
        """
        return self._modified

    @modified.setter
    def modified(self, modified):
        """
        Sets the modified of this Content.

        :param modified: The modified of this Content.
        :type: int
        """

        self._modified = modified

    @property
    def content_status(self):
        """
        Gets the content_status of this Content.

        :return: The content_status of this Content.
        :rtype: str
        """
        return self._content_status

    @content_status.setter
    def content_status(self, content_status):
        """
        Sets the content_status of this Content.

        :param content_status: The content_status of this Content.
        :type: str
        """

        self._content_status = content_status

    @property
    def content_name(self):
        """
        Gets the content_name of this Content.

        :return: The content_name of this Content.
        :rtype: str
        """
        return self._content_name

    @content_name.setter
    def content_name(self, content_name):
        """
        Sets the content_name of this Content.

        :param content_name: The content_name of this Content.
        :type: str
        """

        self._content_name = content_name

    @property
    def content_category(self):
        """
        Gets the content_category of this Content.

        :return: The content_category of this Content.
        :rtype: str
        """
        return self._content_category

    @content_category.setter
    def content_category(self, content_category):
        """
        Sets the content_category of this Content.

        :param content_category: The content_category of this Content.
        :type: str
        """

        self._content_category = content_category

    @property
    def content_size(self):
        """
        Gets the content_size of this Content.

        :return: The content_size of this Content.
        :rtype: int
        """
        return self._content_size

    @content_size.setter
    def content_size(self, content_size):
        """
        Sets the content_size of this Content.

        :param content_size: The content_size of this Content.
        :type: int
        """

        self._content_size = content_size

    @property
    def content_duration(self):
        """
        Gets the content_duration of this Content.

        :return: The content_duration of this Content.
        :rtype: int
        """
        return self._content_duration

    @content_duration.setter
    def content_duration(self, content_duration):
        """
        Sets the content_duration of this Content.

        :param content_duration: The content_duration of this Content.
        :type: int
        """

        self._content_duration = content_duration

    @property
    def content_properties(self):
        """
        Gets the content_properties of this Content.

        :return: The content_properties of this Content.
        :rtype: ContentContentProperties
        """
        return self._content_properties

    @content_properties.setter
    def content_properties(self, content_properties):
        """
        Sets the content_properties of this Content.

        :param content_properties: The content_properties of this Content.
        :type: ContentContentProperties
        """

        self._content_properties = content_properties

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
        if not isinstance(other, Content):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
