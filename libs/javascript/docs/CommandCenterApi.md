# BlueJeansMeetingsRestApi.CommandCenterApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getEndpointDistribution**](CommandCenterApi.md#getEndpointDistribution) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution | Endpoint Distribution
[**getFeedbackComments**](CommandCenterApi.md#getFeedbackComments) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments | Survey Feedback Comments
[**getFeedbackCount**](CommandCenterApi.md#getFeedbackCount) | **GET** /v1/enterprise/{enterprise_id}/indigo/feedback/count | Survey Feedback Scores
[**getMeetingLiveByEnterprise**](CommandCenterApi.md#getMeetingLiveByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/ | List Live Meeting Endpoints by Enterprise
[**getMeetingPastByEnterprise**](CommandCenterApi.md#getMeetingPastByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid} | List Meeting Endpoints &amp; Stats by Enterprise
[**getMeetingPastByUser**](CommandCenterApi.md#getMeetingPastByUser) | **GET** /v1/user/{user_id}/indigo/meetings/{meeting_uuid} | List Meeting Endpoints &amp; Stats by User
[**getMeetingUsage**](CommandCenterApi.md#getMeetingUsage) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage | Meeting Usage Over Time
[**getMeetingsLiveByEnterprise**](CommandCenterApi.md#getMeetingsLiveByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live | Live Meetings Summary by Enterprise
[**getMeetingsPastByEnterprise**](CommandCenterApi.md#getMeetingsPastByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings | List Past Meetings by Enterprise
[**getMeetingsPastByUser**](CommandCenterApi.md#getMeetingsPastByUser) | **GET** /v1/user/{user_id}/indigo/meetings | List Past Meetings by User
[**getRoiRanges**](CommandCenterApi.md#getRoiRanges) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges | ROI Data
[**getTopUsers**](CommandCenterApi.md#getTopUsers) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/users/usage | Top Users


<a name="getEndpointDistribution"></a>
# **getEndpointDistribution**
> AnalyticsEndpointDistribution getEndpointDistribution(enterpriseId, opts)

Endpoint Distribution

This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var opts = { 
  'filter': "[{\"type\":\"date\",\"comparison\":\"gt\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"creation_time\"},{\"type\":\"date\",\"comparison\":\"lt\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"creation_time\"}]" // String | URL-encoded JSON string
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getEndpointDistribution(enterpriseId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **filter** | **String**| URL-encoded JSON string | [optional] [default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}]]

### Return type

[**AnalyticsEndpointDistribution**](AnalyticsEndpointDistribution.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFeedbackComments"></a>
# **getFeedbackComments**
> AnalyticsFeedbackComments getFeedbackComments(enterpriseId, start, end)

Survey Feedback Comments

This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var start = "2017-01-01T00:00:00-00:00"; // String | Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.

var end = "2018-01-01T00:00:00-00:00"; // String | Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFeedbackComments(enterpriseId, start, end, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **start** | **String**| Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. | [default to 2017-01-01T00:00:00-00:00]
 **end** | **String**| Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. | [default to 2018-01-01T00:00:00-00:00]

### Return type

[**AnalyticsFeedbackComments**](AnalyticsFeedbackComments.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFeedbackCount"></a>
# **getFeedbackCount**
> AnalyticsFeedbackScores getFeedbackCount(enterpriseId, start, end)

Survey Feedback Scores

This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var start = "2017-01-01T00:00:00-00:00"; // String | Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.

var end = "2018-01-01T00:00:00-00:00"; // String | Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFeedbackCount(enterpriseId, start, end, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **start** | **String**| Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. | [default to 2017-01-01T00:00:00-00:00]
 **end** | **String**| Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. | [default to 2018-01-01T00:00:00-00:00]

### Return type

[**AnalyticsFeedbackScores**](AnalyticsFeedbackScores.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingLiveByEnterprise"></a>
# **getMeetingLiveByEnterprise**
> MeetingExtendedIndigo getMeetingLiveByEnterprise(enterpriseId, meetingUuid)

List Live Meeting Endpoints by Enterprise

This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var meetingUuid = "meetingUuid_example"; // String | The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingLiveByEnterprise(enterpriseId, meetingUuid, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **meetingUuid** | **String**| The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. | 

### Return type

[**MeetingExtendedIndigo**](MeetingExtendedIndigo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingPastByEnterprise"></a>
# **getMeetingPastByEnterprise**
> MeetingExtendedIndigo getMeetingPastByEnterprise(enterpriseId, meetingUuid, opts)

List Meeting Endpoints &amp; Stats by Enterprise

This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var meetingUuid = "meetingUuid_example"; // String | The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.

var opts = { 
  'includeEndpoints': true // Boolean | Option to include detailed data on endpoints
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingPastByEnterprise(enterpriseId, meetingUuid, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **meetingUuid** | **String**| The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. | 
 **includeEndpoints** | **Boolean**| Option to include detailed data on endpoints | [optional] 

### Return type

[**MeetingExtendedIndigo**](MeetingExtendedIndigo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingPastByUser"></a>
# **getMeetingPastByUser**
> MeetingExtendedIndigo getMeetingPastByUser(userId, meetingUuid)

List Meeting Endpoints &amp; Stats by User

This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingUuid = "meetingUuid_example"; // String | The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingPastByUser(userId, meetingUuid, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingUuid** | **String**| The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. | 

### Return type

[**MeetingExtendedIndigo**](MeetingExtendedIndigo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingUsage"></a>
# **getMeetingUsage**
> AnalyticsUsage getMeetingUsage(enterpriseId, opts)

Meeting Usage Over Time

This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var opts = { 
  'clientTZ': "America/Denver", // String | Based on standard TZ code.
  'filter': "[{\"type\":\"string\",\"comparison\":\"eq\",\"value\":\"DAY\",\"field\":\"groupInterval\"},{\"type\":\"date\",\"comparison\":\"eq\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"lowts\"},{\"type\":\"date\",\"comparison\":\"eq\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"hights\"}]" // String | URL-encoded JSON string
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingUsage(enterpriseId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **clientTZ** | **String**| Based on standard TZ code. | [optional] [default to America/Denver]
 **filter** | **String**| URL-encoded JSON string | [optional] [default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}]]

### Return type

[**AnalyticsUsage**](AnalyticsUsage.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingsLiveByEnterprise"></a>
# **getMeetingsLiveByEnterprise**
> MeetingIndigoList getMeetingsLiveByEnterprise(enterpriseId)

Live Meetings Summary by Enterprise

This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingsLiveByEnterprise(enterpriseId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 

### Return type

[**MeetingIndigoList**](MeetingIndigoList.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingsPastByEnterprise"></a>
# **getMeetingsPastByEnterprise**
> MeetingIndigoList getMeetingsPastByEnterprise(enterpriseId, opts)

List Past Meetings by Enterprise

This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var opts = { 
  'offset': 56, // Number | Page Number
  'limit': 56, // Number | Per page
  'filter': "filter_example" // String | URL-encoded JSON string
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingsPastByEnterprise(enterpriseId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **offset** | **Number**| Page Number | [optional] 
 **limit** | **Number**| Per page | [optional] 
 **filter** | **String**| URL-encoded JSON string | [optional] 

### Return type

[**MeetingIndigoList**](MeetingIndigoList.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingsPastByUser"></a>
# **getMeetingsPastByUser**
> MeetingIndigoList getMeetingsPastByUser(userId)

List Past Meetings by User

This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingsPastByUser(userId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 

### Return type

[**MeetingIndigoList**](MeetingIndigoList.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getRoiRanges"></a>
# **getRoiRanges**
> AnalyticsRoiData getRoiRanges(enterpriseId, filter)

ROI Data

This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var filter = "[{\"type\":\"date\",\"comparison\":\"gt\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"startTime\"},{\"type\":\"date\",\"comparison\":\"lt\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"startTime\"}]"; // String | URL-encoded JSON string


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getRoiRanges(enterpriseId, filter, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **filter** | **String**| URL-encoded JSON string | [default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;startTime&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;startTime&quot;}]]

### Return type

[**AnalyticsRoiData**](AnalyticsRoiData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getTopUsers"></a>
# **getTopUsers**
> AnalyticsTopUsers getTopUsers(enterpriseId, opts)

Top Users

This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.CommandCenterApi();

var enterpriseId = 56; // Number | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

var opts = { 
  'filter': "[{\"type\":\"date\",\"comparison\":\"gt\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"start_time\"},{\"type\":\"date\",\"comparison\":\"lt\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"end_time\"}]" // String | URL-encoded JSON string
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getTopUsers(enterpriseId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseId** | **Number**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. | 
 **filter** | **String**| URL-encoded JSON string | [optional] [default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}]]

### Return type

[**AnalyticsTopUsers**](AnalyticsTopUsers.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

