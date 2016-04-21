// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ProfilesOperations.
    /// </summary>
    public static partial class ProfilesOperationsExtensions
    {
            /// <summary>
            /// Checks the availability of a Traffic Manager Relative DNS name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager name parameters supplied to the
            /// CheckTrafficManagerNameAvailability operation.
            /// </param>
            public static TrafficManagerNameAvailability CheckTrafficManagerRelativeDnsNameAvailability(this IProfilesOperations operations, CheckTrafficManagerRelativeDnsNameAvailabilityParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).CheckTrafficManagerRelativeDnsNameAvailabilityAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of a Traffic Manager Relative DNS name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager name parameters supplied to the
            /// CheckTrafficManagerNameAvailability operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficManagerNameAvailability> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this IProfilesOperations operations, CheckTrafficManagerRelativeDnsNameAvailabilityParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckTrafficManagerRelativeDnsNameAvailabilityWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profiles to
            /// be listed.
            /// </param>
            public static IEnumerable<Profile> ListAllInResourceGroup(this IProfilesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).ListAllInResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profiles to
            /// be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Profile>> ListAllInResourceGroupAsync(this IProfilesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllInResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<Profile> ListAll(this IProfilesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Profile>> ListAllAsync(this IProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            public static Profile Get(this IProfilesOperations operations, string resourceGroupName, string profileName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).GetAsync(resourceGroupName, profileName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> GetAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            public static Profile CreateOrUpdate(this IProfilesOperations operations, string resourceGroupName, string profileName, Profile parameters)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).CreateOrUpdateAsync(resourceGroupName, profileName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> CreateOrUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, Profile parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile to be deleted.
            /// </param>
            public static void Delete(this IProfilesOperations operations, string resourceGroupName, string profileName)
            {
                Task.Factory.StartNew(s => ((IProfilesOperations)s).DeleteAsync(resourceGroupName, profileName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the Update operation.
            /// </param>
            public static Profile Update(this IProfilesOperations operations, string resourceGroupName, string profileName, Profile parameters)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).UpdateAsync(resourceGroupName, profileName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the Update operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> UpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, Profile parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
