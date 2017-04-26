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


class User(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id=None, username=None, first_name=None, middle_name=None, last_name=None, email_id=None, company=None, title=None, phone=None, profile_picture=None, timezone=None, time_format=None, language=None):
        """
        User - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id': 'int',
            'username': 'str',
            'first_name': 'str',
            'middle_name': 'str',
            'last_name': 'str',
            'email_id': 'str',
            'company': 'str',
            'title': 'str',
            'phone': 'str',
            'profile_picture': 'str',
            'timezone': 'str',
            'time_format': 'int',
            'language': 'str'
        }

        self.attribute_map = {
            'id': 'id',
            'username': 'username',
            'first_name': 'firstName',
            'middle_name': 'middleName',
            'last_name': 'lastName',
            'email_id': 'emailId',
            'company': 'company',
            'title': 'title',
            'phone': 'phone',
            'profile_picture': 'profilePicture',
            'timezone': 'timezone',
            'time_format': 'timeFormat',
            'language': 'language'
        }

        self._id = id
        self._username = username
        self._first_name = first_name
        self._middle_name = middle_name
        self._last_name = last_name
        self._email_id = email_id
        self._company = company
        self._title = title
        self._phone = phone
        self._profile_picture = profile_picture
        self._timezone = timezone
        self._time_format = time_format
        self._language = language

    @property
    def id(self):
        """
        Gets the id of this User.
        Unique identifier for the user.

        :return: The id of this User.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this User.
        Unique identifier for the user.

        :param id: The id of this User.
        :type: int
        """

        self._id = id

    @property
    def username(self):
        """
        Gets the username of this User.
        User's username

        :return: The username of this User.
        :rtype: str
        """
        return self._username

    @username.setter
    def username(self, username):
        """
        Sets the username of this User.
        User's username

        :param username: The username of this User.
        :type: str
        """

        self._username = username

    @property
    def first_name(self):
        """
        Gets the first_name of this User.
        User's first name

        :return: The first_name of this User.
        :rtype: str
        """
        return self._first_name

    @first_name.setter
    def first_name(self, first_name):
        """
        Sets the first_name of this User.
        User's first name

        :param first_name: The first_name of this User.
        :type: str
        """

        self._first_name = first_name

    @property
    def middle_name(self):
        """
        Gets the middle_name of this User.
        User's middle name

        :return: The middle_name of this User.
        :rtype: str
        """
        return self._middle_name

    @middle_name.setter
    def middle_name(self, middle_name):
        """
        Sets the middle_name of this User.
        User's middle name

        :param middle_name: The middle_name of this User.
        :type: str
        """

        self._middle_name = middle_name

    @property
    def last_name(self):
        """
        Gets the last_name of this User.
        User's last name

        :return: The last_name of this User.
        :rtype: str
        """
        return self._last_name

    @last_name.setter
    def last_name(self, last_name):
        """
        Sets the last_name of this User.
        User's last name

        :param last_name: The last_name of this User.
        :type: str
        """

        self._last_name = last_name

    @property
    def email_id(self):
        """
        Gets the email_id of this User.
        User's email address

        :return: The email_id of this User.
        :rtype: str
        """
        return self._email_id

    @email_id.setter
    def email_id(self, email_id):
        """
        Sets the email_id of this User.
        User's email address

        :param email_id: The email_id of this User.
        :type: str
        """

        self._email_id = email_id

    @property
    def company(self):
        """
        Gets the company of this User.
        User's company name

        :return: The company of this User.
        :rtype: str
        """
        return self._company

    @company.setter
    def company(self, company):
        """
        Sets the company of this User.
        User's company name

        :param company: The company of this User.
        :type: str
        """

        self._company = company

    @property
    def title(self):
        """
        Gets the title of this User.
        User's title

        :return: The title of this User.
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title):
        """
        Sets the title of this User.
        User's title

        :param title: The title of this User.
        :type: str
        """

        self._title = title

    @property
    def phone(self):
        """
        Gets the phone of this User.
        User's phone

        :return: The phone of this User.
        :rtype: str
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """
        Sets the phone of this User.
        User's phone

        :param phone: The phone of this User.
        :type: str
        """

        self._phone = phone

    @property
    def profile_picture(self):
        """
        Gets the profile_picture of this User.
        Path to user's profile picture

        :return: The profile_picture of this User.
        :rtype: str
        """
        return self._profile_picture

    @profile_picture.setter
    def profile_picture(self, profile_picture):
        """
        Sets the profile_picture of this User.
        Path to user's profile picture

        :param profile_picture: The profile_picture of this User.
        :type: str
        """

        self._profile_picture = profile_picture

    @property
    def timezone(self):
        """
        Gets the timezone of this User.
        User's timezone

        :return: The timezone of this User.
        :rtype: str
        """
        return self._timezone

    @timezone.setter
    def timezone(self, timezone):
        """
        Sets the timezone of this User.
        User's timezone

        :param timezone: The timezone of this User.
        :type: str
        """

        self._timezone = timezone

    @property
    def time_format(self):
        """
        Gets the time_format of this User.
        User's preference of 12 or 24 hour time display

        :return: The time_format of this User.
        :rtype: int
        """
        return self._time_format

    @time_format.setter
    def time_format(self, time_format):
        """
        Sets the time_format of this User.
        User's preference of 12 or 24 hour time display

        :param time_format: The time_format of this User.
        :type: int
        """

        self._time_format = time_format

    @property
    def language(self):
        """
        Gets the language of this User.
        User's language code

        :return: The language of this User.
        :rtype: str
        """
        return self._language

    @language.setter
    def language(self, language):
        """
        Sets the language of this User.
        User's language code

        :param language: The language of this User.
        :type: str
        """

        self._language = language

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
        if not isinstance(other, User):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
