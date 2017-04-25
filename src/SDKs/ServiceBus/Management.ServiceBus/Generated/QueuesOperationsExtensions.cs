// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueuesOperations.
    /// </summary>
    public static partial class QueuesOperationsExtensions
    {
            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            public static IPage<QueueResource> ListAll(this IQueuesOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListAllAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QueueResource>> ListAllAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Bus queue. This operation is idempotent.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639395.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update a queue resource.
            /// </param>
            public static QueueResource CreateOrUpdate(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, QueueCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, queueName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Bus queue. This operation is idempotent.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639395.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update a queue resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueResource> CreateOrUpdateAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, QueueCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a queue from the specified namespace in a resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639411.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static void Delete(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a queue from the specified namespace in a resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639411.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a description for the specified queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639380.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static QueueResource Get(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a description for the specified queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639380.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueResource> GetAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, queueName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an authorization rule for a queue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an authorization rule for a queue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a queue authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705609.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a queue authorization rule.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705609.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an authorization rule for a queue by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705611.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a queue by rule name.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705611.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705608.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            public static ResourceListKeys ListKeys(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705608.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705606.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            public static ResourceListKeys RegenerateKeys(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, RegenerateKeysParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings to the queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705606.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='queueName'>
            /// The queue name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationrule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> RegenerateKeysAsync(this IQueuesOperations operations, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName, RegenerateKeysParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, queueName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<QueueResource> ListAllNext(this IQueuesOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the queues within a namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639415.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QueueResource>> ListAllNextAsync(this IQueuesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this IQueuesOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all authorization rules for a queue.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt705607.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this IQueuesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

