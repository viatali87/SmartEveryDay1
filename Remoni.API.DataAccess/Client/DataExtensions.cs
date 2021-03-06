// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for Data.
    /// </summary>
    public static partial class DataExtensions
    {
            /// <summary>
            /// Get Data by AggregateType, UnitId and Timestamp
            /// </summary>
            /// <remarks>
            /// It is required to filter by UnitId, AggregateType and at least one
            /// Timestamp. It's possible to filter by multiple timestamps to filter by a
            /// date range.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static object GetCollectionAsyncByqueryOptions(this IData operations, System.Collections.Generic.IList<string> timestamp, string unitId, string aggregateType, string orderby = "Timestamp", string orderbydesc = default(string), int? top = 10000, int? skip = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IData)s).GetCollectionAsyncByqueryOptionsAsync(timestamp, unitId, aggregateType, orderby, orderbydesc, top, skip), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Data by AggregateType, UnitId and Timestamp
            /// </summary>
            /// <remarks>
            /// It is required to filter by UnitId, AggregateType and at least one
            /// Timestamp. It's possible to filter by multiple timestamps to filter by a
            /// date range.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetCollectionAsyncByqueryOptionsAsync(this IData operations, System.Collections.Generic.IList<string> timestamp, string unitId, string aggregateType, string orderby = "Timestamp", string orderbydesc = default(string), int? top = 10000, int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCollectionAsyncByqueryOptionsWithHttpMessagesAsync(timestamp, unitId, aggregateType, orderby, orderbydesc, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Insert Data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='data'>
            /// Collection of data points to insert
            /// </param>
            public static object PostAsyncBydata(this IData operations, System.Collections.Generic.IList<CreateDataDto> data)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IData)s).PostAsyncBydataAsync(data), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Insert Data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='data'>
            /// Collection of data points to insert
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> PostAsyncBydataAsync(this IData operations, System.Collections.Generic.IList<CreateDataDto> data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostAsyncBydataWithHttpMessagesAsync(data, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
