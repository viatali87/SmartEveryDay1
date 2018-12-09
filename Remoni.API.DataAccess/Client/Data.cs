// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client
{
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Data operations.
    /// </summary>
    public partial class Data : Microsoft.Rest.IServiceOperations<RemoniAPIClient>, IData
    {
        /// <summary>
        /// Initializes a new instance of the Data class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Data(RemoniAPIClient client)
        {
            if (client == null) 
            {
                throw new System.ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the RemoniAPIClient
        /// </summary>
        public RemoniAPIClient Client { get; private set; }

        /// <summary>
        /// Get Data by AggregateType, UnitId and Timestamp
        /// </summary>
        /// <remarks>
        /// It is required to filter by UnitId, AggregateType and at least one
        /// Timestamp. It's possible to filter by multiple timestamps to filter by a
        /// date range.
        /// </remarks>
        /// <param name='timestamp'>
        /// &lt;p&gt;&lt;a href="#queryoptions"&gt;Filters&lt;/a&gt; the result by
        /// Timestamp using the supplied operation and value.&lt;/p&gt;&lt;p&gt;Valid
        /// operations are: &lt;strong&gt;eq(datetime)&lt;/strong&gt;,
        /// &lt;strong&gt;ge(datetime)&lt;/strong&gt;,
        /// &lt;strong&gt;gt(datetime)&lt;/strong&gt;,
        /// &lt;strong&gt;le(datetime)&lt;/strong&gt;,
        /// &lt;strong&gt;lt(datetime)&lt;/strong&gt;&lt;/p&gt;
        /// </param>
        /// <param name='unitId'>
        /// &lt;p&gt;&lt;a href="#queryoptions"&gt;Filters&lt;/a&gt; the result by
        /// UnitId using the supplied operation and value.&lt;/p&gt;&lt;p&gt;Valid
        /// operations are: &lt;strong&gt;eq(int)&lt;/strong&gt;&lt;/p&gt;
        /// </param>
        /// <param name='aggregateType'>
        /// &lt;p&gt;&lt;a href="#queryoptions"&gt;Filters&lt;/a&gt; the result by
        /// AggregateType using the supplied operation and
        /// value.&lt;/p&gt;&lt;p&gt;Valid operations are:
        /// &lt;strong&gt;eq(aggregatetype)&lt;/strong&gt;&lt;/p&gt;&lt;p&gt;aggregatetype
        /// = ['Raw', 'Minutes5', 'Hour', 'Day']&lt;/p&gt;
        /// </param>
        /// <param name='orderby'>
        /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
        /// ascending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
        /// are: &lt;strong&gt;Timestamp&lt;/strong&gt;
        /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
        /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
        /// exclusive.&lt;/p&gt;
        /// </param>
        /// <param name='orderbydesc'>
        /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
        /// descending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
        /// are: &lt;strong&gt;Timestamp&lt;/strong&gt;
        /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
        /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
        /// exclusive.&lt;/p&gt;
        /// </param>
        /// <param name='top'>
        /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Returns the maximum
        /// number of entities. Default and max value is 10000
        /// </param>
        /// <param name='skip'>
        /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Skips this number of
        /// entities
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<object,DataGetCollectionAsyncByqueryOptionsHeaders>> GetCollectionAsyncByqueryOptionsWithHttpMessagesAsync(System.Collections.Generic.IList<string> timestamp, string unitId, string aggregateType, string orderby = "Timestamp", string orderbydesc = default(string), int? top = 10000, int? skip = default(int?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (timestamp == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "timestamp");
            }
            if (unitId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "unitId");
            }
            if (aggregateType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "aggregateType");
            }
            if (top > 10000)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "top", 10000);
            }
            if (top < 1)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "top", 1);
            }
            if (skip < 0)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "skip", 0);
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("orderby", orderby);
                tracingParameters.Add("orderbydesc", orderbydesc);
                tracingParameters.Add("timestamp", timestamp);
                tracingParameters.Add("unitId", unitId);
                tracingParameters.Add("aggregateType", aggregateType);
                tracingParameters.Add("top", top);
                tracingParameters.Add("skip", skip);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "GetCollectionAsyncByqueryOptions", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "Data").ToString();
            System.Collections.Generic.List<string> _queryParameters = new System.Collections.Generic.List<string>();
            if (orderby != null)
            {
                _queryParameters.Add(string.Format("orderby={0}", System.Uri.EscapeDataString(orderby)));
            }
            if (orderbydesc != null)
            {
                _queryParameters.Add(string.Format("orderbydesc={0}", System.Uri.EscapeDataString(orderbydesc)));
            }
            if (timestamp != null)
            {
                if (timestamp.Count == 0)
                {
                    _queryParameters.Add(string.Format("Timestamp={0}", System.Uri.EscapeDataString(string.Empty)));
                }
                else
                {
                    foreach (var _item in timestamp)
                    {
                        _queryParameters.Add(string.Format("Timestamp={0}", System.Uri.EscapeDataString(_item ?? string.Empty)));
                    }
                }
            }
            if (unitId != null)
            {
                _queryParameters.Add(string.Format("UnitId={0}", System.Uri.EscapeDataString(unitId)));
            }
            if (aggregateType != null)
            {
                _queryParameters.Add(string.Format("AggregateType={0}", System.Uri.EscapeDataString(aggregateType)));
            }
            if (top != null)
            {
                _queryParameters.Add(string.Format("top={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(top, this.Client.SerializationSettings).Trim('"'))));
            }
            if (skip != null)
            {
                _queryParameters.Add(string.Format("skip={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(skip, this.Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            System.Net.Http.HttpRequestMessage _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 400 && (int)_statusCode != 401 && (int)_statusCode != 500)
            {
                var ex = new Microsoft.Rest.HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.HttpOperationResponse<object,DataGetCollectionAsyncByqueryOptionsHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<System.Collections.Generic.IList<ReadDataDto>>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 400)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FourZeroZeroError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 401)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FourZeroOneError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 500)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FiveZeroZeroError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<DataGetCollectionAsyncByqueryOptionsHeaders>(Newtonsoft.Json.JsonSerializer.Create(this.Client.DeserializationSettings));
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new Microsoft.Rest.SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Insert Data
        /// </summary>
        /// <param name='data'>
        /// Collection of data points to insert
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<object,DataPostAsyncBydataHeaders>> PostAsyncBydataWithHttpMessagesAsync(System.Collections.Generic.IList<CreateDataDto> data, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (data == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "data");
            }
            if (data != null)
            {
                foreach (var element in data)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("data", data);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "PostAsyncBydata", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "Data").ToString();
            // Create HTTP transport objects
            System.Net.Http.HttpRequestMessage _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(data != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(data, this.Client.SerializationSettings);
                _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 201 && (int)_statusCode != 400 && (int)_statusCode != 401 && (int)_statusCode != 500)
            {
                var ex = new Microsoft.Rest.HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.HttpOperationResponse<object,DataPostAsyncBydataHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 201)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 400)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FourZeroZeroError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 401)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FourZeroOneError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 500)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<FiveZeroZeroError>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<DataPostAsyncBydataHeaders>(Newtonsoft.Json.JsonSerializer.Create(this.Client.DeserializationSettings));
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new Microsoft.Rest.SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
