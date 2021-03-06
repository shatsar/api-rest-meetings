/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.api;

import com.bluejeans.api.rest.meetings.ApiCallback;
import com.bluejeans.api.rest.meetings.ApiClient;
import com.bluejeans.api.rest.meetings.ApiException;
import com.bluejeans.api.rest.meetings.ApiResponse;
import com.bluejeans.api.rest.meetings.Configuration;
import com.bluejeans.api.rest.meetings.Pair;
import com.bluejeans.api.rest.meetings.ProgressRequestBody;
import com.bluejeans.api.rest.meetings.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.bluejeans.api.rest.meetings.model.AnalyticsEndpointDistribution;
import com.bluejeans.api.rest.meetings.model.AnalyticsFeedbackComments;
import com.bluejeans.api.rest.meetings.model.AnalyticsFeedbackScores;
import com.bluejeans.api.rest.meetings.model.AnalyticsRoiData;
import com.bluejeans.api.rest.meetings.model.AnalyticsTopUsers;
import com.bluejeans.api.rest.meetings.model.AnalyticsUsage;
import com.bluejeans.api.rest.meetings.model.Error;
import com.bluejeans.api.rest.meetings.model.MeetingExtendedIndigo;
import com.bluejeans.api.rest.meetings.model.MeetingIndigoList;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class CommandCenterApi {
    private ApiClient apiClient;

    public CommandCenterApi() {
        this(Configuration.getDefaultApiClient());
    }

    public CommandCenterApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for getEndpointDistribution
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getEndpointDistributionCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (filter != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "filter", filter));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getEndpointDistributionValidateBeforeCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getEndpointDistribution(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getEndpointDistributionCall(enterpriseId, filter, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Endpoint Distribution
     * This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @return AnalyticsEndpointDistribution
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsEndpointDistribution getEndpointDistribution(Integer enterpriseId, String filter) throws ApiException {
        ApiResponse<AnalyticsEndpointDistribution> resp = getEndpointDistributionWithHttpInfo(enterpriseId, filter);
        return resp.getData();
    }

    /**
     * Endpoint Distribution
     * This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @return ApiResponse&lt;AnalyticsEndpointDistribution&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsEndpointDistribution> getEndpointDistributionWithHttpInfo(Integer enterpriseId, String filter) throws ApiException {
        com.squareup.okhttp.Call call = getEndpointDistributionValidateBeforeCall(enterpriseId, filter, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsEndpointDistribution>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Endpoint Distribution (asynchronously)
     * This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getEndpointDistributionAsync(Integer enterpriseId, String filter, final ApiCallback<AnalyticsEndpointDistribution> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getEndpointDistributionValidateBeforeCall(enterpriseId, filter, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsEndpointDistribution>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getFeedbackComments
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getFeedbackCommentsCall(Integer enterpriseId, String start, String end, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (start != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "start", start));
        if (end != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "end", end));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getFeedbackCommentsValidateBeforeCall(Integer enterpriseId, String start, String end, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getFeedbackComments(Async)");
        }
        
        // verify the required parameter 'start' is set
        if (start == null) {
            throw new ApiException("Missing the required parameter 'start' when calling getFeedbackComments(Async)");
        }
        
        // verify the required parameter 'end' is set
        if (end == null) {
            throw new ApiException("Missing the required parameter 'end' when calling getFeedbackComments(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getFeedbackCommentsCall(enterpriseId, start, end, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Survey Feedback Comments
     * This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @return AnalyticsFeedbackComments
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsFeedbackComments getFeedbackComments(Integer enterpriseId, String start, String end) throws ApiException {
        ApiResponse<AnalyticsFeedbackComments> resp = getFeedbackCommentsWithHttpInfo(enterpriseId, start, end);
        return resp.getData();
    }

    /**
     * Survey Feedback Comments
     * This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @return ApiResponse&lt;AnalyticsFeedbackComments&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsFeedbackComments> getFeedbackCommentsWithHttpInfo(Integer enterpriseId, String start, String end) throws ApiException {
        com.squareup.okhttp.Call call = getFeedbackCommentsValidateBeforeCall(enterpriseId, start, end, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsFeedbackComments>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Survey Feedback Comments (asynchronously)
     * This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getFeedbackCommentsAsync(Integer enterpriseId, String start, String end, final ApiCallback<AnalyticsFeedbackComments> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getFeedbackCommentsValidateBeforeCall(enterpriseId, start, end, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsFeedbackComments>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getFeedbackCount
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getFeedbackCountCall(Integer enterpriseId, String start, String end, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/feedback/count"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (start != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "start", start));
        if (end != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "end", end));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getFeedbackCountValidateBeforeCall(Integer enterpriseId, String start, String end, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getFeedbackCount(Async)");
        }
        
        // verify the required parameter 'start' is set
        if (start == null) {
            throw new ApiException("Missing the required parameter 'start' when calling getFeedbackCount(Async)");
        }
        
        // verify the required parameter 'end' is set
        if (end == null) {
            throw new ApiException("Missing the required parameter 'end' when calling getFeedbackCount(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getFeedbackCountCall(enterpriseId, start, end, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Survey Feedback Scores
     * This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @return AnalyticsFeedbackScores
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsFeedbackScores getFeedbackCount(Integer enterpriseId, String start, String end) throws ApiException {
        ApiResponse<AnalyticsFeedbackScores> resp = getFeedbackCountWithHttpInfo(enterpriseId, start, end);
        return resp.getData();
    }

    /**
     * Survey Feedback Scores
     * This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @return ApiResponse&lt;AnalyticsFeedbackScores&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsFeedbackScores> getFeedbackCountWithHttpInfo(Integer enterpriseId, String start, String end) throws ApiException {
        com.squareup.okhttp.Call call = getFeedbackCountValidateBeforeCall(enterpriseId, start, end, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsFeedbackScores>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Survey Feedback Scores (asynchronously)
     * This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getFeedbackCountAsync(Integer enterpriseId, String start, String end, final ApiCallback<AnalyticsFeedbackScores> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getFeedbackCountValidateBeforeCall(enterpriseId, start, end, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsFeedbackScores>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingLiveByEnterprise
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingLiveByEnterpriseCall(Integer enterpriseId, String meetingUuid, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()))
            .replaceAll("\\{" + "meeting_uuid" + "\\}", apiClient.escapeString(meetingUuid.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingLiveByEnterpriseValidateBeforeCall(Integer enterpriseId, String meetingUuid, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getMeetingLiveByEnterprise(Async)");
        }
        
        // verify the required parameter 'meetingUuid' is set
        if (meetingUuid == null) {
            throw new ApiException("Missing the required parameter 'meetingUuid' when calling getMeetingLiveByEnterprise(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingLiveByEnterpriseCall(enterpriseId, meetingUuid, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * List Live Meeting Endpoints by Enterprise
     * This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @return MeetingExtendedIndigo
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingExtendedIndigo getMeetingLiveByEnterprise(Integer enterpriseId, String meetingUuid) throws ApiException {
        ApiResponse<MeetingExtendedIndigo> resp = getMeetingLiveByEnterpriseWithHttpInfo(enterpriseId, meetingUuid);
        return resp.getData();
    }

    /**
     * List Live Meeting Endpoints by Enterprise
     * This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @return ApiResponse&lt;MeetingExtendedIndigo&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingExtendedIndigo> getMeetingLiveByEnterpriseWithHttpInfo(Integer enterpriseId, String meetingUuid) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingLiveByEnterpriseValidateBeforeCall(enterpriseId, meetingUuid, null, null);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * List Live Meeting Endpoints by Enterprise (asynchronously)
     * This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingLiveByEnterpriseAsync(Integer enterpriseId, String meetingUuid, final ApiCallback<MeetingExtendedIndigo> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingLiveByEnterpriseValidateBeforeCall(enterpriseId, meetingUuid, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingPastByEnterprise
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param includeEndpoints Option to include detailed data on endpoints (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingPastByEnterpriseCall(Integer enterpriseId, String meetingUuid, Boolean includeEndpoints, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid}"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()))
            .replaceAll("\\{" + "meeting_uuid" + "\\}", apiClient.escapeString(meetingUuid.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (includeEndpoints != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "includeEndpoints", includeEndpoints));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingPastByEnterpriseValidateBeforeCall(Integer enterpriseId, String meetingUuid, Boolean includeEndpoints, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getMeetingPastByEnterprise(Async)");
        }
        
        // verify the required parameter 'meetingUuid' is set
        if (meetingUuid == null) {
            throw new ApiException("Missing the required parameter 'meetingUuid' when calling getMeetingPastByEnterprise(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingPastByEnterpriseCall(enterpriseId, meetingUuid, includeEndpoints, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * List Meeting Endpoints &amp; Stats by Enterprise
     * This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param includeEndpoints Option to include detailed data on endpoints (optional)
     * @return MeetingExtendedIndigo
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingExtendedIndigo getMeetingPastByEnterprise(Integer enterpriseId, String meetingUuid, Boolean includeEndpoints) throws ApiException {
        ApiResponse<MeetingExtendedIndigo> resp = getMeetingPastByEnterpriseWithHttpInfo(enterpriseId, meetingUuid, includeEndpoints);
        return resp.getData();
    }

    /**
     * List Meeting Endpoints &amp; Stats by Enterprise
     * This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param includeEndpoints Option to include detailed data on endpoints (optional)
     * @return ApiResponse&lt;MeetingExtendedIndigo&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingExtendedIndigo> getMeetingPastByEnterpriseWithHttpInfo(Integer enterpriseId, String meetingUuid, Boolean includeEndpoints) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingPastByEnterpriseValidateBeforeCall(enterpriseId, meetingUuid, includeEndpoints, null, null);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * List Meeting Endpoints &amp; Stats by Enterprise (asynchronously)
     * This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param includeEndpoints Option to include detailed data on endpoints (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingPastByEnterpriseAsync(Integer enterpriseId, String meetingUuid, Boolean includeEndpoints, final ApiCallback<MeetingExtendedIndigo> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingPastByEnterpriseValidateBeforeCall(enterpriseId, meetingUuid, includeEndpoints, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingPastByUser
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingPastByUserCall(Integer userId, String meetingUuid, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/user/{user_id}/indigo/meetings/{meeting_uuid}"
            .replaceAll("\\{" + "user_id" + "\\}", apiClient.escapeString(userId.toString()))
            .replaceAll("\\{" + "meeting_uuid" + "\\}", apiClient.escapeString(meetingUuid.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingPastByUserValidateBeforeCall(Integer userId, String meetingUuid, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'userId' is set
        if (userId == null) {
            throw new ApiException("Missing the required parameter 'userId' when calling getMeetingPastByUser(Async)");
        }
        
        // verify the required parameter 'meetingUuid' is set
        if (meetingUuid == null) {
            throw new ApiException("Missing the required parameter 'meetingUuid' when calling getMeetingPastByUser(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingPastByUserCall(userId, meetingUuid, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * List Meeting Endpoints &amp; Stats by User
     * This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @return MeetingExtendedIndigo
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingExtendedIndigo getMeetingPastByUser(Integer userId, String meetingUuid) throws ApiException {
        ApiResponse<MeetingExtendedIndigo> resp = getMeetingPastByUserWithHttpInfo(userId, meetingUuid);
        return resp.getData();
    }

    /**
     * List Meeting Endpoints &amp; Stats by User
     * This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @return ApiResponse&lt;MeetingExtendedIndigo&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingExtendedIndigo> getMeetingPastByUserWithHttpInfo(Integer userId, String meetingUuid) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingPastByUserValidateBeforeCall(userId, meetingUuid, null, null);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * List Meeting Endpoints &amp; Stats by User (asynchronously)
     * This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param meetingUuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingPastByUserAsync(Integer userId, String meetingUuid, final ApiCallback<MeetingExtendedIndigo> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingPastByUserValidateBeforeCall(userId, meetingUuid, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingExtendedIndigo>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingUsage
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param clientTZ Based on standard TZ code. (optional, default to America/Denver)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingUsageCall(Integer enterpriseId, String clientTZ, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (clientTZ != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "clientTZ", clientTZ));
        if (filter != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "filter", filter));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingUsageValidateBeforeCall(Integer enterpriseId, String clientTZ, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getMeetingUsage(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingUsageCall(enterpriseId, clientTZ, filter, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Meeting Usage Over Time
     * This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param clientTZ Based on standard TZ code. (optional, default to America/Denver)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @return AnalyticsUsage
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsUsage getMeetingUsage(Integer enterpriseId, String clientTZ, String filter) throws ApiException {
        ApiResponse<AnalyticsUsage> resp = getMeetingUsageWithHttpInfo(enterpriseId, clientTZ, filter);
        return resp.getData();
    }

    /**
     * Meeting Usage Over Time
     * This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param clientTZ Based on standard TZ code. (optional, default to America/Denver)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @return ApiResponse&lt;AnalyticsUsage&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsUsage> getMeetingUsageWithHttpInfo(Integer enterpriseId, String clientTZ, String filter) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingUsageValidateBeforeCall(enterpriseId, clientTZ, filter, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsUsage>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Meeting Usage Over Time (asynchronously)
     * This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param clientTZ Based on standard TZ code. (optional, default to America/Denver)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingUsageAsync(Integer enterpriseId, String clientTZ, String filter, final ApiCallback<AnalyticsUsage> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingUsageValidateBeforeCall(enterpriseId, clientTZ, filter, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsUsage>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingsLiveByEnterprise
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingsLiveByEnterpriseCall(Integer enterpriseId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingsLiveByEnterpriseValidateBeforeCall(Integer enterpriseId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getMeetingsLiveByEnterprise(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingsLiveByEnterpriseCall(enterpriseId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Live Meetings Summary by Enterprise
     * This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @return MeetingIndigoList
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingIndigoList getMeetingsLiveByEnterprise(Integer enterpriseId) throws ApiException {
        ApiResponse<MeetingIndigoList> resp = getMeetingsLiveByEnterpriseWithHttpInfo(enterpriseId);
        return resp.getData();
    }

    /**
     * Live Meetings Summary by Enterprise
     * This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @return ApiResponse&lt;MeetingIndigoList&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingIndigoList> getMeetingsLiveByEnterpriseWithHttpInfo(Integer enterpriseId) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingsLiveByEnterpriseValidateBeforeCall(enterpriseId, null, null);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Live Meetings Summary by Enterprise (asynchronously)
     * This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingsLiveByEnterpriseAsync(Integer enterpriseId, final ApiCallback<MeetingIndigoList> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingsLiveByEnterpriseValidateBeforeCall(enterpriseId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingsPastByEnterprise
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param offset Page Number (optional)
     * @param limit Per page (optional)
     * @param filter URL-encoded JSON string (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingsPastByEnterpriseCall(Integer enterpriseId, Integer offset, Integer limit, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (offset != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "offset", offset));
        if (limit != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "limit", limit));
        if (filter != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "filter", filter));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingsPastByEnterpriseValidateBeforeCall(Integer enterpriseId, Integer offset, Integer limit, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getMeetingsPastByEnterprise(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingsPastByEnterpriseCall(enterpriseId, offset, limit, filter, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * List Past Meetings by Enterprise
     * This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param offset Page Number (optional)
     * @param limit Per page (optional)
     * @param filter URL-encoded JSON string (optional)
     * @return MeetingIndigoList
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingIndigoList getMeetingsPastByEnterprise(Integer enterpriseId, Integer offset, Integer limit, String filter) throws ApiException {
        ApiResponse<MeetingIndigoList> resp = getMeetingsPastByEnterpriseWithHttpInfo(enterpriseId, offset, limit, filter);
        return resp.getData();
    }

    /**
     * List Past Meetings by Enterprise
     * This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param offset Page Number (optional)
     * @param limit Per page (optional)
     * @param filter URL-encoded JSON string (optional)
     * @return ApiResponse&lt;MeetingIndigoList&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingIndigoList> getMeetingsPastByEnterpriseWithHttpInfo(Integer enterpriseId, Integer offset, Integer limit, String filter) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingsPastByEnterpriseValidateBeforeCall(enterpriseId, offset, limit, filter, null, null);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * List Past Meetings by Enterprise (asynchronously)
     * This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param offset Page Number (optional)
     * @param limit Per page (optional)
     * @param filter URL-encoded JSON string (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingsPastByEnterpriseAsync(Integer enterpriseId, Integer offset, Integer limit, String filter, final ApiCallback<MeetingIndigoList> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingsPastByEnterpriseValidateBeforeCall(enterpriseId, offset, limit, filter, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getMeetingsPastByUser
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getMeetingsPastByUserCall(Integer userId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/user/{user_id}/indigo/meetings"
            .replaceAll("\\{" + "user_id" + "\\}", apiClient.escapeString(userId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getMeetingsPastByUserValidateBeforeCall(Integer userId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'userId' is set
        if (userId == null) {
            throw new ApiException("Missing the required parameter 'userId' when calling getMeetingsPastByUser(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getMeetingsPastByUserCall(userId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * List Past Meetings by User
     * This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @return MeetingIndigoList
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public MeetingIndigoList getMeetingsPastByUser(Integer userId) throws ApiException {
        ApiResponse<MeetingIndigoList> resp = getMeetingsPastByUserWithHttpInfo(userId);
        return resp.getData();
    }

    /**
     * List Past Meetings by User
     * This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @return ApiResponse&lt;MeetingIndigoList&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<MeetingIndigoList> getMeetingsPastByUserWithHttpInfo(Integer userId) throws ApiException {
        com.squareup.okhttp.Call call = getMeetingsPastByUserValidateBeforeCall(userId, null, null);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * List Past Meetings by User (asynchronously)
     * This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
     * @param userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getMeetingsPastByUserAsync(Integer userId, final ApiCallback<MeetingIndigoList> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getMeetingsPastByUserValidateBeforeCall(userId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<MeetingIndigoList>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getRoiRanges
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getRoiRangesCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (filter != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "filter", filter));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getRoiRangesValidateBeforeCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getRoiRanges(Async)");
        }
        
        // verify the required parameter 'filter' is set
        if (filter == null) {
            throw new ApiException("Missing the required parameter 'filter' when calling getRoiRanges(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getRoiRangesCall(enterpriseId, filter, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * ROI Data
     * This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (required)
     * @return AnalyticsRoiData
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsRoiData getRoiRanges(Integer enterpriseId, String filter) throws ApiException {
        ApiResponse<AnalyticsRoiData> resp = getRoiRangesWithHttpInfo(enterpriseId, filter);
        return resp.getData();
    }

    /**
     * ROI Data
     * This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (required)
     * @return ApiResponse&lt;AnalyticsRoiData&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsRoiData> getRoiRangesWithHttpInfo(Integer enterpriseId, String filter) throws ApiException {
        com.squareup.okhttp.Call call = getRoiRangesValidateBeforeCall(enterpriseId, filter, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsRoiData>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * ROI Data (asynchronously)
     * This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getRoiRangesAsync(Integer enterpriseId, String filter, final ApiCallback<AnalyticsRoiData> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getRoiRangesValidateBeforeCall(enterpriseId, filter, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsRoiData>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTopUsers
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTopUsersCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage"
            .replaceAll("\\{" + "enterprise_id" + "\\}", apiClient.escapeString(enterpriseId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (filter != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "filter", filter));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTopUsersValidateBeforeCall(Integer enterpriseId, String filter, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'enterpriseId' is set
        if (enterpriseId == null) {
            throw new ApiException("Missing the required parameter 'enterpriseId' when calling getTopUsers(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTopUsersCall(enterpriseId, filter, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Top Users
     * This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @return AnalyticsTopUsers
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public AnalyticsTopUsers getTopUsers(Integer enterpriseId, String filter) throws ApiException {
        ApiResponse<AnalyticsTopUsers> resp = getTopUsersWithHttpInfo(enterpriseId, filter);
        return resp.getData();
    }

    /**
     * Top Users
     * This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @return ApiResponse&lt;AnalyticsTopUsers&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<AnalyticsTopUsers> getTopUsersWithHttpInfo(Integer enterpriseId, String filter) throws ApiException {
        com.squareup.okhttp.Call call = getTopUsersValidateBeforeCall(enterpriseId, filter, null, null);
        Type localVarReturnType = new TypeToken<AnalyticsTopUsers>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Top Users (asynchronously)
     * This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
     * @param enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTopUsersAsync(Integer enterpriseId, String filter, final ApiCallback<AnalyticsTopUsers> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTopUsersValidateBeforeCall(enterpriseId, filter, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<AnalyticsTopUsers>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
