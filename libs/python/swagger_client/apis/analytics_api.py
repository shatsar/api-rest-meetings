# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import sys
import os
import re

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class AnalyticsApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def get_endpoint_distribution(self, enterprise_id, **kwargs):
        """
        Endpoint Distribution
        This endpoint retrieves endpoint connection type distribution by enterprise.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_endpoint_distribution(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string
        :return: AnalyticsEndpointDistribution
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_endpoint_distribution_with_http_info(enterprise_id, **kwargs)
        else:
            (data) = self.get_endpoint_distribution_with_http_info(enterprise_id, **kwargs)
            return data

    def get_endpoint_distribution_with_http_info(self, enterprise_id, **kwargs):
        """
        Endpoint Distribution
        This endpoint retrieves endpoint connection type distribution by enterprise.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_endpoint_distribution_with_http_info(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string
        :return: AnalyticsEndpointDistribution
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'filter']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_endpoint_distribution" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_endpoint_distribution`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'filter' in params:
            query_params['filter'] = params['filter']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsEndpointDistribution',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)

    def get_feedback_comments(self, enterprise_id, start, end, **kwargs):
        """
        Survey Feedback Comments
        This endpoint lists end of meeting survey comments by enterprise by time period.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_feedback_comments(enterprise_id, start, end, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str start: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :param str end: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :return: AnalyticsFeedbackComments
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_feedback_comments_with_http_info(enterprise_id, start, end, **kwargs)
        else:
            (data) = self.get_feedback_comments_with_http_info(enterprise_id, start, end, **kwargs)
            return data

    def get_feedback_comments_with_http_info(self, enterprise_id, start, end, **kwargs):
        """
        Survey Feedback Comments
        This endpoint lists end of meeting survey comments by enterprise by time period.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_feedback_comments_with_http_info(enterprise_id, start, end, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str start: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :param str end: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :return: AnalyticsFeedbackComments
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'start', 'end']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_feedback_comments" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_feedback_comments`")
        # verify the required parameter 'start' is set
        if ('start' not in params) or (params['start'] is None):
            raise ValueError("Missing the required parameter `start` when calling `get_feedback_comments`")
        # verify the required parameter 'end' is set
        if ('end' not in params) or (params['end'] is None):
            raise ValueError("Missing the required parameter `end` when calling `get_feedback_comments`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'start' in params:
            query_params['start'] = params['start']
        if 'end' in params:
            query_params['end'] = params['end']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsFeedbackComments',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)

    def get_feedback_count(self, enterprise_id, start, end, **kwargs):
        """
        Survey Feedback Scores
        This endpoint lists end of meeting survey scores by enterprise by time period.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_feedback_count(enterprise_id, start, end, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str start: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :param str end: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :return: AnalyticsFeedbackScores
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_feedback_count_with_http_info(enterprise_id, start, end, **kwargs)
        else:
            (data) = self.get_feedback_count_with_http_info(enterprise_id, start, end, **kwargs)
            return data

    def get_feedback_count_with_http_info(self, enterprise_id, start, end, **kwargs):
        """
        Survey Feedback Scores
        This endpoint lists end of meeting survey scores by enterprise by time period.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_feedback_count_with_http_info(enterprise_id, start, end, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str start: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :param str end: Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
        :return: AnalyticsFeedbackScores
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'start', 'end']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_feedback_count" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_feedback_count`")
        # verify the required parameter 'start' is set
        if ('start' not in params) or (params['start'] is None):
            raise ValueError("Missing the required parameter `start` when calling `get_feedback_count`")
        # verify the required parameter 'end' is set
        if ('end' not in params) or (params['end'] is None):
            raise ValueError("Missing the required parameter `end` when calling `get_feedback_count`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/feedback/count'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'start' in params:
            query_params['start'] = params['start']
        if 'end' in params:
            query_params['end'] = params['end']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsFeedbackScores',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)

    def get_meeting_usage(self, enterprise_id, **kwargs):
        """
        Meeting Usage Over Time
        This endpoint reports on meeting usage.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_meeting_usage(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str client_tz: Based on standard TZ code.
        :param str filter: URL-encoded JSON string
        :return: AnalyticsUsage
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_meeting_usage_with_http_info(enterprise_id, **kwargs)
        else:
            (data) = self.get_meeting_usage_with_http_info(enterprise_id, **kwargs)
            return data

    def get_meeting_usage_with_http_info(self, enterprise_id, **kwargs):
        """
        Meeting Usage Over Time
        This endpoint reports on meeting usage.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_meeting_usage_with_http_info(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str client_tz: Based on standard TZ code.
        :param str filter: URL-encoded JSON string
        :return: AnalyticsUsage
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'client_tz', 'filter']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_usage" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_meeting_usage`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'client_tz' in params:
            query_params['clientTZ'] = params['client_tz']
        if 'filter' in params:
            query_params['filter'] = params['filter']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsUsage',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)

    def get_roi_ranges(self, enterprise_id, filter, **kwargs):
        """
        ROI Data
        This endpoint lists return on investment (ROI) data for meetings.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_roi_ranges(enterprise_id, filter, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string (required)
        :return: AnalyticsRoiData
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_roi_ranges_with_http_info(enterprise_id, filter, **kwargs)
        else:
            (data) = self.get_roi_ranges_with_http_info(enterprise_id, filter, **kwargs)
            return data

    def get_roi_ranges_with_http_info(self, enterprise_id, filter, **kwargs):
        """
        ROI Data
        This endpoint lists return on investment (ROI) data for meetings.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_roi_ranges_with_http_info(enterprise_id, filter, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string (required)
        :return: AnalyticsRoiData
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'filter']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_roi_ranges" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_roi_ranges`")
        # verify the required parameter 'filter' is set
        if ('filter' not in params) or (params['filter'] is None):
            raise ValueError("Missing the required parameter `filter` when calling `get_roi_ranges`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'filter' in params:
            query_params['filter'] = params['filter']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsRoiData',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)

    def get_top_users(self, enterprise_id, **kwargs):
        """
        Top Users
        This endpoint retrieves the top users by usage for an enterprise.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_top_users(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string
        :return: AnalyticsTopUsers
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_top_users_with_http_info(enterprise_id, **kwargs)
        else:
            (data) = self.get_top_users_with_http_info(enterprise_id, **kwargs)
            return data

    def get_top_users_with_http_info(self, enterprise_id, **kwargs):
        """
        Top Users
        This endpoint retrieves the top users by usage for an enterprise.
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_top_users_with_http_info(enterprise_id, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param int enterprise_id: The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
        :param str filter: URL-encoded JSON string
        :return: AnalyticsTopUsers
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['enterprise_id', 'filter']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_top_users" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'enterprise_id' is set
        if ('enterprise_id' not in params) or (params['enterprise_id'] is None):
            raise ValueError("Missing the required parameter `enterprise_id` when calling `get_top_users`")


        collection_formats = {}

        resource_path = '/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage'.replace('{format}', 'json')
        path_params = {}
        if 'enterprise_id' in params:
            path_params['enterprise_id'] = params['enterprise_id']

        query_params = {}
        if 'filter' in params:
            query_params['filter'] = params['filter']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='AnalyticsTopUsers',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)
