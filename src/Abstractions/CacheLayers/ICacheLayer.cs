// Copyright (c) Milo Wical. All rights reserved.

using WicalWare.Components.ResultCs;

namespace WicalWare.Components.OgreCache.Abstractions;

/// <summary>
/// Defines the basic functionality for a cache layer that can be added to
/// a composite caching structure.
/// </summary>
public partial interface ICacheLayer
{
  /// <summary>
  /// Gets the name of the cache layer.
  /// </summary>
  /// <value>The name of the caching layer.</value>
  string Name { get; }

  /// <summary>
  /// Attempts to retrieve (get) a value from the cache.
  /// </summary>
  /// <param name="retrieveCommand">The command parameters to
  /// attempt to retrieve a cached value.</param>
  /// <typeparam name="TOutput">The expected type of the retrieved value.</typeparam>
  /// <returns>The result of the retrieval attempt, which contains an
  /// <c>IRetrieveResult</c> if successful, an <c>IRetrieveError</c> otherwise.</returns>
  Result<IRetrieveResult, IRetrieveError> Retrieve<TOutput>(IRetrieveCommand<TOutput> retrieveCommand);

  /// <summary>
  /// Attempts to evict (delete) a value from the cache.
  /// </summary>
  /// <param name="evictCommand">The command parameters to
  /// attempt to evict a cached value.</param>
  /// <returns>The result of the eviction attempt, which contains an
  /// <c>IEvictResult</c> if successful, an <c>IEvictError</c> otherwise.</returns>
  Result<IEvictResult, IEvictError> Evict(IEvictCommand evictCommand);

  /// <summary>
  /// Attempts to query the cache.
  /// </summary>
  /// <param name="queryCommand">The command parameters to
  /// attempt to query the cache. This also defines the target of the lookup.</param>
  /// <typeparam name="TOutput">The expected type of the retrieved value.</typeparam>
  /// <returns>The result of the query attempt, which contains an
  /// <c>IQueryResult</c> if successful, an <c>IQueryError</c> otherwise.</returns>
  Result<IQueryResult, IQueryError> Query<TOutput>(IQueryCommand<TOutput> queryCommand);

  /// <summary>
  /// Attempts to purge (delete) ALL values from the cache.
  /// </summary>
  /// <param name="purgeCommand">The command parameters to
  /// attempt to purge all cached values.</param>
  /// <returns>The result of the purge attempt, which contains an
  /// <c>IPurgeResult</c> if successful, an <c>IPurgeError</c> otherwise.</returns>
  Result<IPurgeResult, IPurgeError> Purge(IPurgeCommand purgeCommand);
}
