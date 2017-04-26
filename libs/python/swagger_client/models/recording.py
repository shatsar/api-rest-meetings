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


class Recording(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, recording_entity_id=None, recording_entity_guid=None, recording_name=None, meeting_guid=None, chapter_count=None, total_size=None, total_duration=None, last_recording_date=None, aggregated_status=None, recording_thumbnail=None, created=None, aggregated_view_count=None, is_premium_recording=None, show_premium_recording_tag=None, recording_chapters=None):
        """
        Recording - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'recording_entity_id': 'int',
            'recording_entity_guid': 'str',
            'recording_name': 'str',
            'meeting_guid': 'str',
            'chapter_count': 'int',
            'total_size': 'int',
            'total_duration': 'int',
            'last_recording_date': 'int',
            'aggregated_status': 'str',
            'recording_thumbnail': 'str',
            'created': 'int',
            'aggregated_view_count': 'int',
            'is_premium_recording': 'bool',
            'show_premium_recording_tag': 'bool',
            'recording_chapters': 'list[RecordingRecordingChapters]'
        }

        self.attribute_map = {
            'recording_entity_id': 'recordingEntityId',
            'recording_entity_guid': 'recordingEntityGuid',
            'recording_name': 'recordingName',
            'meeting_guid': 'meetingGuid',
            'chapter_count': 'chapterCount',
            'total_size': 'totalSize',
            'total_duration': 'totalDuration',
            'last_recording_date': 'lastRecordingDate',
            'aggregated_status': 'aggregatedStatus',
            'recording_thumbnail': 'recordingThumbnail',
            'created': 'created',
            'aggregated_view_count': 'aggregatedViewCount',
            'is_premium_recording': 'isPremiumRecording',
            'show_premium_recording_tag': 'showPremiumRecordingTag',
            'recording_chapters': 'recordingChapters'
        }

        self._recording_entity_id = recording_entity_id
        self._recording_entity_guid = recording_entity_guid
        self._recording_name = recording_name
        self._meeting_guid = meeting_guid
        self._chapter_count = chapter_count
        self._total_size = total_size
        self._total_duration = total_duration
        self._last_recording_date = last_recording_date
        self._aggregated_status = aggregated_status
        self._recording_thumbnail = recording_thumbnail
        self._created = created
        self._aggregated_view_count = aggregated_view_count
        self._is_premium_recording = is_premium_recording
        self._show_premium_recording_tag = show_premium_recording_tag
        self._recording_chapters = recording_chapters

    @property
    def recording_entity_id(self):
        """
        Gets the recording_entity_id of this Recording.

        :return: The recording_entity_id of this Recording.
        :rtype: int
        """
        return self._recording_entity_id

    @recording_entity_id.setter
    def recording_entity_id(self, recording_entity_id):
        """
        Sets the recording_entity_id of this Recording.

        :param recording_entity_id: The recording_entity_id of this Recording.
        :type: int
        """

        self._recording_entity_id = recording_entity_id

    @property
    def recording_entity_guid(self):
        """
        Gets the recording_entity_guid of this Recording.

        :return: The recording_entity_guid of this Recording.
        :rtype: str
        """
        return self._recording_entity_guid

    @recording_entity_guid.setter
    def recording_entity_guid(self, recording_entity_guid):
        """
        Sets the recording_entity_guid of this Recording.

        :param recording_entity_guid: The recording_entity_guid of this Recording.
        :type: str
        """

        self._recording_entity_guid = recording_entity_guid

    @property
    def recording_name(self):
        """
        Gets the recording_name of this Recording.

        :return: The recording_name of this Recording.
        :rtype: str
        """
        return self._recording_name

    @recording_name.setter
    def recording_name(self, recording_name):
        """
        Sets the recording_name of this Recording.

        :param recording_name: The recording_name of this Recording.
        :type: str
        """

        self._recording_name = recording_name

    @property
    def meeting_guid(self):
        """
        Gets the meeting_guid of this Recording.

        :return: The meeting_guid of this Recording.
        :rtype: str
        """
        return self._meeting_guid

    @meeting_guid.setter
    def meeting_guid(self, meeting_guid):
        """
        Sets the meeting_guid of this Recording.

        :param meeting_guid: The meeting_guid of this Recording.
        :type: str
        """

        self._meeting_guid = meeting_guid

    @property
    def chapter_count(self):
        """
        Gets the chapter_count of this Recording.

        :return: The chapter_count of this Recording.
        :rtype: int
        """
        return self._chapter_count

    @chapter_count.setter
    def chapter_count(self, chapter_count):
        """
        Sets the chapter_count of this Recording.

        :param chapter_count: The chapter_count of this Recording.
        :type: int
        """

        self._chapter_count = chapter_count

    @property
    def total_size(self):
        """
        Gets the total_size of this Recording.

        :return: The total_size of this Recording.
        :rtype: int
        """
        return self._total_size

    @total_size.setter
    def total_size(self, total_size):
        """
        Sets the total_size of this Recording.

        :param total_size: The total_size of this Recording.
        :type: int
        """

        self._total_size = total_size

    @property
    def total_duration(self):
        """
        Gets the total_duration of this Recording.

        :return: The total_duration of this Recording.
        :rtype: int
        """
        return self._total_duration

    @total_duration.setter
    def total_duration(self, total_duration):
        """
        Sets the total_duration of this Recording.

        :param total_duration: The total_duration of this Recording.
        :type: int
        """

        self._total_duration = total_duration

    @property
    def last_recording_date(self):
        """
        Gets the last_recording_date of this Recording.

        :return: The last_recording_date of this Recording.
        :rtype: int
        """
        return self._last_recording_date

    @last_recording_date.setter
    def last_recording_date(self, last_recording_date):
        """
        Sets the last_recording_date of this Recording.

        :param last_recording_date: The last_recording_date of this Recording.
        :type: int
        """

        self._last_recording_date = last_recording_date

    @property
    def aggregated_status(self):
        """
        Gets the aggregated_status of this Recording.

        :return: The aggregated_status of this Recording.
        :rtype: str
        """
        return self._aggregated_status

    @aggregated_status.setter
    def aggregated_status(self, aggregated_status):
        """
        Sets the aggregated_status of this Recording.

        :param aggregated_status: The aggregated_status of this Recording.
        :type: str
        """

        self._aggregated_status = aggregated_status

    @property
    def recording_thumbnail(self):
        """
        Gets the recording_thumbnail of this Recording.

        :return: The recording_thumbnail of this Recording.
        :rtype: str
        """
        return self._recording_thumbnail

    @recording_thumbnail.setter
    def recording_thumbnail(self, recording_thumbnail):
        """
        Sets the recording_thumbnail of this Recording.

        :param recording_thumbnail: The recording_thumbnail of this Recording.
        :type: str
        """

        self._recording_thumbnail = recording_thumbnail

    @property
    def created(self):
        """
        Gets the created of this Recording.

        :return: The created of this Recording.
        :rtype: int
        """
        return self._created

    @created.setter
    def created(self, created):
        """
        Sets the created of this Recording.

        :param created: The created of this Recording.
        :type: int
        """

        self._created = created

    @property
    def aggregated_view_count(self):
        """
        Gets the aggregated_view_count of this Recording.

        :return: The aggregated_view_count of this Recording.
        :rtype: int
        """
        return self._aggregated_view_count

    @aggregated_view_count.setter
    def aggregated_view_count(self, aggregated_view_count):
        """
        Sets the aggregated_view_count of this Recording.

        :param aggregated_view_count: The aggregated_view_count of this Recording.
        :type: int
        """

        self._aggregated_view_count = aggregated_view_count

    @property
    def is_premium_recording(self):
        """
        Gets the is_premium_recording of this Recording.

        :return: The is_premium_recording of this Recording.
        :rtype: bool
        """
        return self._is_premium_recording

    @is_premium_recording.setter
    def is_premium_recording(self, is_premium_recording):
        """
        Sets the is_premium_recording of this Recording.

        :param is_premium_recording: The is_premium_recording of this Recording.
        :type: bool
        """

        self._is_premium_recording = is_premium_recording

    @property
    def show_premium_recording_tag(self):
        """
        Gets the show_premium_recording_tag of this Recording.

        :return: The show_premium_recording_tag of this Recording.
        :rtype: bool
        """
        return self._show_premium_recording_tag

    @show_premium_recording_tag.setter
    def show_premium_recording_tag(self, show_premium_recording_tag):
        """
        Sets the show_premium_recording_tag of this Recording.

        :param show_premium_recording_tag: The show_premium_recording_tag of this Recording.
        :type: bool
        """

        self._show_premium_recording_tag = show_premium_recording_tag

    @property
    def recording_chapters(self):
        """
        Gets the recording_chapters of this Recording.

        :return: The recording_chapters of this Recording.
        :rtype: list[RecordingRecordingChapters]
        """
        return self._recording_chapters

    @recording_chapters.setter
    def recording_chapters(self, recording_chapters):
        """
        Sets the recording_chapters of this Recording.

        :param recording_chapters: The recording_chapters of this Recording.
        :type: list[RecordingRecordingChapters]
        """

        self._recording_chapters = recording_chapters

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
        if not isinstance(other, Recording):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
