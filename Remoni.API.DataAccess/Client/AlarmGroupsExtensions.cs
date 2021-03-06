// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for AlarmGroups.
    /// </summary>
    public static partial class AlarmGroupsExtensions
    {
            /// <summary>
            /// Get all AlarmGroups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// ascending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;AlarmGroupId&lt;/strong&gt;
            /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
            /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
            /// exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='orderbydesc'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// descending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;AlarmGroupId&lt;/strong&gt;
            /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
            /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
            /// exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='accountAccountId'>
            /// &lt;p&gt;&lt;a href="#queryoptions"&gt;Filters&lt;/a&gt; the result by
            /// Account.AccountId using the supplied operation and
            /// value.&lt;/p&gt;&lt;p&gt;Valid operations are:
            /// &lt;strong&gt;eq(int)&lt;/strong&gt;&lt;/p&gt;
            /// </param>
            /// <param name='top'>
            /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Returns the maximum
            /// number of entities. Default and max value is 10000
            /// </param>
            /// <param name='skip'>
            /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Skips this number of
            /// entities
            /// </param>
            public static object GetCollectionAsyncByqueryOptions(this IAlarmGroups operations, string orderby = "AlarmGroupId", string orderbydesc = default(string), string accountAccountId = default(string), int? top = 10000, int? skip = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlarmGroups)s).GetCollectionAsyncByqueryOptionsAsync(orderby, orderbydesc, accountAccountId, top, skip), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all AlarmGroups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// ascending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;AlarmGroupId&lt;/strong&gt;
            /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
            /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
            /// exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='orderbydesc'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// descending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;AlarmGroupId&lt;/strong&gt;
            /// (default).&lt;/p&gt;&lt;p&gt;Note: &lt;strong&gt;orderby&lt;/strong&gt;
            /// and &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually
            /// exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='accountAccountId'>
            /// &lt;p&gt;&lt;a href="#queryoptions"&gt;Filters&lt;/a&gt; the result by
            /// Account.AccountId using the supplied operation and
            /// value.&lt;/p&gt;&lt;p&gt;Valid operations are:
            /// &lt;strong&gt;eq(int)&lt;/strong&gt;&lt;/p&gt;
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
            public static async System.Threading.Tasks.Task<object> GetCollectionAsyncByqueryOptionsAsync(this IAlarmGroups operations, string orderby = "AlarmGroupId", string orderbydesc = default(string), string accountAccountId = default(string), int? top = 10000, int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCollectionAsyncByqueryOptionsWithHttpMessagesAsync(orderby, orderbydesc, accountAccountId, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new AlarmGroup
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newAlarmGroup'>
            /// The entity to create
            /// </param>
            public static object PostBynewAlarmGroup(this IAlarmGroups operations, CreateAlarmGroupDto newAlarmGroup)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlarmGroups)s).PostBynewAlarmGroupAsync(newAlarmGroup), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new AlarmGroup
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newAlarmGroup'>
            /// The entity to create
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> PostBynewAlarmGroupAsync(this IAlarmGroups operations, CreateAlarmGroupDto newAlarmGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostBynewAlarmGroupWithHttpMessagesAsync(newAlarmGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get AlarmGroup by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of entity to retrieve
            /// </param>
            public static object GetAsyncByid(this IAlarmGroups operations, int id)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlarmGroups)s).GetAsyncByidAsync(id), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get AlarmGroup by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of entity to retrieve
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetAsyncByidAsync(this IAlarmGroups operations, int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAsyncByidWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete AlarmGroup by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of entity to delete
            /// </param>
            public static object DeleteAsyncByid(this IAlarmGroups operations, int id)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlarmGroups)s).DeleteAsyncByidAsync(id), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete AlarmGroup by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of entity to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> DeleteAsyncByidAsync(this IAlarmGroups operations, int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteAsyncByidWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an AlarmGroup
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the AlarmGroup
            /// </param>
            /// <param name='alarmGroup'>
            /// The changes to apply
            /// </param>
            public static object PatchAsyncByidalarmGroup(this IAlarmGroups operations, int id, EditAlarmGroupDto alarmGroup)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlarmGroups)s).PatchAsyncByidalarmGroupAsync(id, alarmGroup), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an AlarmGroup
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The id of the AlarmGroup
            /// </param>
            /// <param name='alarmGroup'>
            /// The changes to apply
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> PatchAsyncByidalarmGroupAsync(this IAlarmGroups operations, int id, EditAlarmGroupDto alarmGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PatchAsyncByidalarmGroupWithHttpMessagesAsync(id, alarmGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
