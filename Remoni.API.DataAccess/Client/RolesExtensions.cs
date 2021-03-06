// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for Roles.
    /// </summary>
    public static partial class RolesExtensions
    {
            /// <summary>
            /// Get all Roles
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// ascending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;RoleId&lt;/strong&gt; (default),
            /// &lt;strong&gt;Name&lt;/strong&gt;.&lt;/p&gt;&lt;p&gt;Note:
            /// &lt;strong&gt;orderby&lt;/strong&gt; and
            /// &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='orderbydesc'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// descending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;RoleId&lt;/strong&gt; (default),
            /// &lt;strong&gt;Name&lt;/strong&gt;.&lt;/p&gt;&lt;p&gt;Note:
            /// &lt;strong&gt;orderby&lt;/strong&gt; and
            /// &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='top'>
            /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Returns the maximum
            /// number of entities. Default and max value is 10000
            /// </param>
            /// <param name='skip'>
            /// &lt;a href="#queryoptions"&gt;Query paging&lt;/a&gt; Skips this number of
            /// entities
            /// </param>
            public static object GetCollectionAsyncByqueryOptions(this IRoles operations, string orderby = "RoleId", string orderbydesc = default(string), int? top = 10000, int? skip = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRoles)s).GetCollectionAsyncByqueryOptionsAsync(orderby, orderbydesc, top, skip), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all Roles
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// ascending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;RoleId&lt;/strong&gt; (default),
            /// &lt;strong&gt;Name&lt;/strong&gt;.&lt;/p&gt;&lt;p&gt;Note:
            /// &lt;strong&gt;orderby&lt;/strong&gt; and
            /// &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually exclusive.&lt;/p&gt;
            /// </param>
            /// <param name='orderbydesc'>
            /// &lt;p&gt;&lt;a href='#queryoptions'&gt;Sorts&lt;/a&gt; the result in
            /// descending order by the supplied property.&lt;/p&gt;&lt;p&gt;Valid values
            /// are: &lt;strong&gt;RoleId&lt;/strong&gt; (default),
            /// &lt;strong&gt;Name&lt;/strong&gt;.&lt;/p&gt;&lt;p&gt;Note:
            /// &lt;strong&gt;orderby&lt;/strong&gt; and
            /// &lt;strong&gt;orderbydesc&lt;/strong&gt; are mutually exclusive.&lt;/p&gt;
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
            public static async System.Threading.Tasks.Task<object> GetCollectionAsyncByqueryOptionsAsync(this IRoles operations, string orderby = "RoleId", string orderbydesc = default(string), int? top = 10000, int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCollectionAsyncByqueryOptionsWithHttpMessagesAsync(orderby, orderbydesc, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Role by name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='role'>
            /// name of role to retrieve. Possible values include: 'Administrator',
            /// 'User', 'ReadOnly'
            /// </param>
            public static object GetAsyncByrole(this IRoles operations, string role)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRoles)s).GetAsyncByroleAsync(role), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Role by name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='role'>
            /// name of role to retrieve. Possible values include: 'Administrator',
            /// 'User', 'ReadOnly'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<object> GetAsyncByroleAsync(this IRoles operations, string role, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAsyncByroleWithHttpMessagesAsync(role, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
